//  Magnificent Mood Machine / LED Matrix Driver Firmware 1.0
//  By Alex Mizell based on the work of Alex Leone
//  March - July 2010

// Include ALeone's brilliant driver
#include "Tlc5940.h"

// Flag and delay factor to ease troubleshooting
boolean debugMode = false;
int slowDown = 50;

// mapping arrays!
int tlcMap[16] = {14, 9, 8, 3, 2, 13, 10, 7, 4, 1, 12, 11, 6, 5, 0}; // create the tlcMap array, initialize with 16 TLCs chained left to right
int colorMap[3] = {2, 1, 0}; // this can map any of the three color channels to any other, in this case: blue to red, green to green, red to blue.  can adjust for different wiring schemes.

// Pins for matrix expansion
int logicEnable = 2;

//  don't really need these with direct port manipulation code except to init pinmodes
//  for Atmega644P pinout scheme
int rowSelectA = 31;
int rowSelectB = 30;
int rowSelectC = 29;

int numTLCRows = 3;  // this is the default, usually set from the console software
int numTLCCols = 5;  // this is the default, usually set from the console software
int numTLCs = numTLCRows * numTLCCols;

int numRows = 5;
int numChannels = 15;  // channel 16 can be used, but not for our purposes
int channelsPerLED = 3;
int numColumns = numChannels / channelsPerLED;
int numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
int ledsPerPanel = numLEDs / numTLCs;
int matrixColumns = numTLCCols * numColumns;


// variables for flipping the display
boolean flipHorizontal = false;
boolean flipVertical = false;
boolean flipTLCMapHorizontal = false;
boolean flipTLCMapVertical = false;
int transformedRow = 0;
int transformedCol = 0;
int transformedTLCRow = 0;
int transformedTLCCol = 0;


unsigned int currentTLC = 0;
unsigned int currentArrayTLC = 0;
unsigned int tlcOffset = 0;
unsigned int arrayTlcOffset = 0;
unsigned int pixelOffset = 0;
unsigned int pixelArrayOffset = 0;
unsigned int totalByteOffset = 0;
unsigned int totalArrayOffset = 0;
unsigned int colOffset = 0;
unsigned int colArrayOffset = 0;
unsigned int tlcChannelOffset = 0;
unsigned int totalChannelOffset = 0;
unsigned int whichTLCRow = 0;
unsigned int whichTLCCol = 0;
unsigned int whichTLC = 0;

byte pixelArray[1200]; // maximum size supported for now:  16 TLCs * 5 rows * 5 columns * 3 colors = 1200 bytes for 400 RGBs




byte red = 0;
byte green = 0;
byte blue = 0;
unsigned int pixel = 0;

unsigned long onDelay = 106;
unsigned long offDelay = 53; 

byte incomingByte;
byte incomingByte2;	// for incoming serial data
byte commandInProgress = 'n';  // no command in progress
byte inputBuffer[9]={0, 0, 0, 0, 0, 0, 0 ,0 ,0};  // largest parameter data size = 9 bytes
unsigned int byteNum = 0;  //  for counting incoming bytes

void setup()
{
 
// initialize the pins as outputs:
pinMode(rowSelectA, OUTPUT);
pinMode(rowSelectB, OUTPUT);
pinMode(rowSelectC, OUTPUT);
pinMode(logicEnable, OUTPUT);

// for now, just light up the first row

digitalWrite(logicEnable, LOW);

digitalWrite(rowSelectA, LOW);
digitalWrite(rowSelectB, LOW);
digitalWrite(rowSelectC, LOW);

Tlc.init();

Tlc.clear();

Serial.begin(57600);
Serial.println("Ready.");

}

void matrixUpdate(){

  // row loop -- top level --
  
  //for (int row = (numRows - 1) * flipVertical; (row < numRows) && (row > -1); row = row + (1 + (flipVertical * -2))) {
  for (int row = numRows - 1; row >= 0; row--) {  // iterate backwards through rows, this makes for left-to-right strobing
  
    if (flipHorizontal == false){
      transformedRow = numRows - 1 - row; // reverse the row numbers
    }
    else{
      transformedRow = row; // do not reverse row numbers
    }
  
    // TLC row loop  -- we have to load data for every TLC before advancing the row - they all drive one unique row
    
    //Serial.println("Start row loop");
    //delay(slowDown);
    
    for (int tlcRow = 0; tlcRow < numTLCRows; tlcRow++) {  // iterate forward through tlcRows
    
      if (flipTLCMapVertical == true){
        transformedTLCRow = numTLCRows - 1 - tlcRow; // reverse the tlcRow numbers
      }
      else{
        transformedTLCRow = tlcRow; // do not reverse tlcRow numbers
      }
    
    //for (int tlcCol = 0; tlcCol < numTLCCols; tlcCol++) { 
      
          // TLC column loop
          
          //Serial.print("TLC row loop: ");
          //Serial.println(tlcRow);
          //delay(slowDown);

          for (int tlcCol = 0; tlcCol < numTLCCols; tlcCol++) {  // iterate forward through tlcCols
          
            if (flipTLCMapHorizontal == true){
              transformedTLCCol = numTLCCols - 1 - tlcCol; // reverse the tlcCols
            }
            else{
              transformedTLCCol = tlcCol; // do not reverse tlcCols
            }
          
          //for (int tlcRow = 0; tlcRow < numTLCRows; tlcRow++) {
            
            
            //Serial.print("TLC col loop: ");
            //Serial.println(tlcCol);
            //delay(slowDown);
      
            //  calculate the pixelArray offset by consulting the tlcMap array
            
            // these are for mapping to TLC channels
            currentTLC = (transformedTLCRow * numTLCCols) + transformedTLCCol;
            tlcOffset = tlcMap[currentTLC] * 16;  // offset to current tlc pixel0 in pixels
            
            
            // these are for indexing the pixel array
            currentArrayTLC = (tlcRow * numTLCCols) + tlcCol;
            arrayTlcOffset = currentArrayTLC * numRows * numColumns;
            

            //Serial.print("tlcOffset: ");
            //Serial.println(tlcOffset);
            //delay(slowDown);

            // Column loop
        
            for (int col = numColumns - 1; col >= 0; col--) { // iterate backwards through columns
            
              //Serial.print("col loop: ");
              //Serial.println(col);
              //delay(slowDown);
      
              //if (channel < numChannels) { // if col => numChannels then the channel is skipped
              
                //Serial.print("row: ");
                //Serial.println(row);
                //Serial.print("channel: ");
                //Serial.println(channel);
                
                //unsigned int channelOffset = (row * numColumns) + channel;
                //Serial.print("channelOffset: ");
                //Serial.println(channelOffset);
                //delay(slowDown);
         
                // set TLC values from pixelArray data
                // broken:  Tlc.set((((tlcRow * numTLCCols) + tlcCol) * 16) + channel, pixelArray[tlcOffset + (col)]);
                
                //broken:  Tlc.set((tlcMap[currentTLC] * 16) + channel, pixelArray[(currentTLC * numChannels * numRows) + (row * numColumns) + channel] );
                
                //Tlc.set((tlcMap[currentTLC] * 16) + channel, pixelArray[((currentTLC * numRows * numColumns * channelsPerLED) + row * numChannels * numTLCCols) + channel] * 16);
                
                // calculate row offset
                //unsigned int rowOffset = (numRows - 1 - row) * numColumns 

                // calculate pixel/element offset
            
                // add the offsets to get the element's address in pixelArray
                
                
                //short element = (numLEDs * channelsPerLED * flipVertical) + (tlcRow * numRows * numTLCCols * numChannels) + (row * numTLCCols * numChannels) + (tlcCol * numChannels) + channel;
                
                // flipping sub - also have to transform the tlcMap
               
                if (flipVertical == true){
                  transformedCol = numColumns - 1 - col; // reverse the cols
                }
                else{
                  transformedCol = col; // don't reverse
                }
                
                pixelOffset = ((col * numRows) + row);  // * channelsPerLED; // reverses rows and columns (to reflect rl positioning) then finds pixel address
                
                // set one pixel of color data from the pixelarray to the TLC columns
                
                totalByteOffset = (arrayTlcOffset + pixelOffset) * channelsPerLED;
                //tlcChannelOffset = (tlcMap[currentTLC] * 16);
                totalChannelOffset = tlcOffset + (transformedCol * channelsPerLED);

                Tlc.set(totalChannelOffset, pixelArray[totalByteOffset + colorMap[0]] * 16);
                Tlc.set(totalChannelOffset + 1, pixelArray[totalByteOffset + colorMap[1]] * 16);
                Tlc.set(totalChannelOffset + 2, pixelArray[totalByteOffset + colorMap[2]] * 16);

                //Tlc.set((tlcMap[currentTLC] * 16) + channel, pixelArray[element] * 16);  // * 16 scales 8 bit value to 12 bit

                if(debugMode == true){
                
                /*
                Serial.println("----------------------------");
                Serial.print("Tlc.set: ");
                Serial.print(totalChannelOffset, DEC);
                Serial.print(", ");
                Serial.println(pixelArray[totalByteOffset + colorMap[1]], DEC);
                //Serial.print("Mapped TLC number: ");
                //Serial.println(tlcMap[currentTLC], DEC);
                Serial.print("tlcRow: ");
                Serial.println(tlcRow, DEC);
                Serial.print("tlcCol: ");
                Serial.println(tlcCol, DEC);
                Serial.print("Tlc number: ");
                Serial.println(currentTLC, DEC);
                Serial.print("Row: ");
                Serial.println(row, DEC);
                Serial.print("Col: ");
                Serial.println(col, DEC);
                Serial.print("transformedRow: ");
                Serial.println(transformedRow, DEC);
                Serial.print("transformedCol: ");
                Serial.println(transformedCol, DEC);
                
                Serial.print("arrayTlcOffset: ");
                Serial.println(arrayTlcOffset, DEC);
                Serial.print("pixelOffset: ");
                Serial.println(pixelOffset, DEC);
                Serial.print("totalByteOffset: ");
                Serial.println(totalByteOffset, DEC);
                Serial.println("----------------------------");
 
                
                
                
                delay(slowDown);
                */
                }
                
                
      
               // }
          
          // the columns for one TLC is loaded, advance to next TLC in the row

          }

      }
      
      // one row of TLCs across the matrix has been loaded, advance to the next row of TLCs

    }
   
      digitalWrite(logicEnable, HIGH); // all rows off
      
      // all of the TLCs have been set
      // shift all of the data to the chips
      Tlc.update();
      //Serial.println("Tlc.update()");
      //delay(slowDown);
      
      // select the current row with the 74LS138
      PORTA = row;  // for 644p
      //PORTC = row; // for 328P
      //Serial.println("PORTC = row");
      //delay(slowDown);
      
      //Serial.println("offDelay");
      //delay(slowDown);
      // we need to kill some time while the logic chip flips bits, so call the serial handler while we wait
      for(int i = 0; i <= offDelay; i++){  //  <= ensures that the serial handler is called at least once for every matrix refresh
      // off delay is caused by continued serial input handling and not by useless delay
      
      // if you don't do this enough (about 55 cycles per row) then you won't kill enough time and the colors will bleed together on the matrix
      
      serialInputHandler();
      //serialInputHandler();
      
      }
      
      //Serial.println("switch on row");
      //delay(slowDown);
      digitalWrite(logicEnable, LOW);  // switch on the row 
    
      //Serial.println("onDelay");
      //delay(slowDown);
      // this delay should be at least as long as the offDelay to allow the LEDs to get some PWM cycles in before moving on to the next row
      // the ratio of off/on time will affect the overall LED brightness and the flicker frequency.  adjust high for strobing effects, low for blurring
      
      for(int i = 0; i < onDelay; i++){
      // on delay is caused by continued serial input handling and not by useless delay
      serialInputHandler();
      //serialInputHandler();
      //serialInputHandler();

      }
      
      //if(onDelay > 0){
        
      //delayMicroseconds(onDelay);
        
      //}
      
    
  }
  
}

void colorSolid(){

  //Serial.println("starting colorsolid()");
  
  // set the pixel array with a solid color
  for(int cpixel = 0; cpixel < numLEDs * channelsPerLED; cpixel = cpixel + channelsPerLED) {
  
    pixelArray[cpixel] = red;
    pixelArray[cpixel + 1] = green;
    pixelArray[cpixel + 2] = blue;
    //dirtyMatrix = true;

    }
}

void shiftLeft(){

  for(int tlcCol=0; tlcCol < numTLCCols; tlcCol++) {
      
     if (debugMode == true){
     
       Serial.println("begin shifting left");
 
     }
     
    
     for(int col=0; col < numColumns; col++) {
       
       if (debugMode == true){
       
       Serial.print("starting col ");
       Serial.println(col, DEC);
       
       }
       
       for(int tlcRow=0; tlcRow < numTLCRows; tlcRow++) {
         
         if (debugMode == true){
       
         Serial.print("starting tlcRow ");
         Serial.println(tlcRow, DEC);
       
         }
         
         int tlcOffset1 = ((tlcRow * numTLCCols) + tlcCol) * ledsPerPanel;
         
         if (debugMode == true){
       
         Serial.print("tlcOffset1:  ");
         Serial.println(tlcOffset1, DEC);
       
         }
         
         for(int row=0; row < numRows; row++) {
         
           
           
           int pixelOffset1 = (row * numColumns) + col;  
           int totalOffset1 = (tlcOffset1 + pixelOffset1) * channelsPerLED;
           
           if (debugMode == true){
       
           Serial.print("pixelOffset1: ");
           Serial.println(pixelOffset1, DEC);
           Serial.print("totalOffset1: ");
           Serial.println(totalOffset1, DEC);
             
           Serial.print("row ");
           Serial.println(row, DEC);

       
           }
           
           // for the first four columns of each panel, just go one LED to the right
           if (col < numColumns - 1){
           pixelArray[totalOffset1] = pixelArray[totalOffset1 + channelsPerLED];
           pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + channelsPerLED + 1];
           pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + channelsPerLED + 2];
           }
           else {
           
             // for the fifth column, go one TLC right (use the TLCMap) and back four pixels
             
             if(tlcCol < numTLCCols - 1) {
             
               pixelArray[totalOffset1] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED) - ((numColumns - 1) * channelsPerLED)];
               pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED)  - ((numColumns - 1) * channelsPerLED)+ 1];
               pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED)  - ((numColumns - 1) * channelsPerLED)+ 2];
               
               if (debugMode == true){
       
               Serial.println("a fifth column! ");
               
               Serial.print("totalOffset1 + (ledsPerPanel * channelsPerLED): ");
               Serial.println(totalOffset1 + (ledsPerPanel * channelsPerLED), DEC);
     
               }
             
             }
             else{
             
               // on the last column of the last TLC in the row, just return 0s to avoid reading beyond the array bounds
               
               pixelArray[totalOffset1] = 0;
               pixelArray[totalOffset1 + 1] = 0;
               pixelArray[totalOffset1 + 2] = 0;
               
               if (debugMode == true){
       
               Serial.println("a fifth column on the last tlcCol! ");
               
               Serial.println("wrote black");
     
               }
               
             
             }
             
             
             
           }
           
           
          
          
        }
        
      }
      
    }
    
  }
  

}




/*void shiftLeft(){

  // shift the entire pixel array one pixel to the left
  // this sould be possible copying data from 75 bytes forward and ignoring the last column
  //  of course it's not that easy, durp
  
  //byte pixelArrayCopy[1200];
  
  //pixelArrayCopy = pixelArray;
 
 
  if (debugMode == true){
          
  Serial.println("RCVD: k shift left");
  Serial.print("numTLCColumns: ");
  Serial.println(numTLCCols, DEC);
  Serial.print("numTLCRows: ");
  Serial.println(numTLCRows, DEC);
  Serial.print("numColumns: ");
  Serial.println(numColumns, DEC);
  Serial.print("numRows: ");
  Serial.println(numRows, DEC);
          
  }
 
  for (int i1 = 0; i1 < numTLCCols; i1++) {
  
    for (int j1 = 0; j1 < numTLCRows; j1++) {
  
      int tlcOffset1 = (j1 * numTLCCols) + i1;
      
      for (int x1 = 0; x1 < numColumns; x1++) {
    
        for (int y1 = 0; y1 < numRows; y1++) { 
 
          if (debugMode == true){
          Serial.print("col after init: ");
          Serial.println(x1, DEC);
          }

          int totalOffset1 = (tlcOffset1 + ((y1 * numColumns) + x1)) * channelsPerLED; 
          
          if (debugMode == true){
          Serial.print("col after offsets: ");
          Serial.println(x1, DEC);
          }
          
          //int currentPixel = ((tlcRow * numRows * matrixColumns) + (row * matrixColumns) + (tlcCol * numColumns) + col) * channelsPerLED;
          
          
          if (x1 < numColumns - 1){ // do this on every column but the last on each TLC
          
          // for most columns you just read the color data from one pixel (3 channels) to the right:
          pixelArray[totalOffset1] = pixelArray[totalOffset1 + channelsPerLED];
          pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + 1 + channelsPerLED];
          pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + 2 + channelsPerLED];
          
          }
          
          else { // do this on the last column
          
          
          
            // but for this one you have to read a whole TLC to the right
          
            // unless it's the far right TLC, in which case just return 0s
          
            if(i1 < numTLCCols - 1) {
            
              pixelArray[totalOffset1] = pixelArray[totalOffset1 + (numLEDs * channelsPerLED)];
              pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + 1 + (numLEDs * channelsPerLED)];
              pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + 2 + (numLEDs * channelsPerLED)];
            
              }
          
            else {
          
              pixelArray[totalOffset1] = 0;
              pixelArray[totalOffset1 + 1] = 0;
              pixelArray[totalOffset1 + 2] = 0;
          
              }
          
          
          }
          

          if (debugMode == true){
          

            Serial.print("tlcCol: ");
            Serial.println(j1, DEC);
            Serial.print("tlcRow: ");
            Serial.println(i1, DEC);
            Serial.print("col: ");
            Serial.println(x1, DEC);
            Serial.print("row: ");
            Serial.println(y1);
            Serial.print("totalOffset: ");
            Serial.println(totalOffset1, DEC);
            //Serial.print("color: ");
            //Serial.print(pixelArray[totalOffset1 + (numLEDs * channelsPerLED)], DEC);
            //Serial.print(" ");
            //Serial.print(pixelArray[totalOffset1 + 1 + (numLEDs * channelsPerLED)], DEC);
            //Serial.print(" ");
            //Serial.println(pixelArray[totalOffset1 + 2 + (numLEDs * channelsPerLED)], DEC);

            delay(slowDown);
          
          }
        
        }
      }
    }
  }
}*/

/*void shiftRight(){

  // shift the entire pixel array one pixel to the left
  // this sould be possible copying data from 75 bytes forward and ignoring the last column
  //  of course it's not that easy, durp 
 
  if (debugMode == true){
          
  Serial.println("RCVD: whatever shift right");

  }
 
  for (int i = numTLCCols - 1; i >= 0; i--) {  // do the columns in reverse to avoid overwriting the pixels you need to read from
  
    for (int j = 0; j < numTLCRows; j++) {
  
      int tlcOffset1 = ((j * numTLCCols) + i) * numLEDs;
      
      for (int x = numColumns - 1; x >= 0; x--) { // do the columns in reverse
    
        for (int y = 0; y < numRows; y++) { 
 
          if (debugMode == true){
          Serial.print("col after init: ");
          Serial.println(x, DEC);
          }

          int totalOffset1 = (tlcOffset1 + ((y * numColumns) + x)) * channelsPerLED; 
          
          if (debugMode == true){
          Serial.print("col after offsets: ");
          Serial.println(x, DEC);
          }
          
          //int currentPixel = ((tlcRow * numRows * matrixColumns) + (row * matrixColumns) + (tlcCol * numColumns) + col) * channelsPerLED;
          
          
          if (x > 0){ // do this on every column but the first on each TLC
          
          // for most columns you just read the color data from one pixel (3 channels) to the right:
          pixelArray[totalOffset1] = pixelArray[totalOffset1 - channelsPerLED];
          pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + 1 - channelsPerLED];
          pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + 2 - channelsPerLED];
          
          }
          
          else { // do this on the first column
          
          // but for this one you have to read a whole TLC to the left
          
          // but if this is the first column on the first TLC column you don't want to try and read negative pixelArray indices, so just return black in that case
                          
          if (i > 0 && y > 0){
            
            pixelArray[totalOffset1] = pixelArray[totalOffset1 - (numLEDs * channelsPerLED)];
            pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + 1 - (numLEDs * channelsPerLED)];
            pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + 2 - (numLEDs * channelsPerLED)];
            
            }
          else {
          
            pixelArray[totalOffset1] = 0;
            pixelArray[totalOffset1 + 1] = 0;
            pixelArray[totalOffset1 + 2] = 0;
          
            }
          
          }
          

          if (debugMode == true){
          
            Serial.print("numColumns: ");
            Serial.println(numColumns, DEC);
            Serial.print("numRows: ");
            Serial.println(numRows, DEC);
            Serial.print("tlcCol: ");
            Serial.println(j, DEC);
            Serial.print("tlcRow: ");
            Serial.println(i, DEC);
            Serial.print("col: ");
            Serial.println(x, DEC);
            Serial.print("row: ");
            Serial.println(y);
            Serial.print("totalOffset: ");
            Serial.println(totalOffset1, DEC);
            Serial.print("color: ");
            Serial.print(pixelArray[totalOffset1 + (numLEDs * channelsPerLED)], DEC);
            Serial.print(" ");
            Serial.print(pixelArray[totalOffset1 + 1 + (numLEDs * channelsPerLED)], DEC);
            Serial.print(" ");
            Serial.println(pixelArray[totalOffset1 + 2 + (numLEDs * channelsPerLED)], DEC);

            delay(slowDown);
          
          }
        
        }
      }
    }
  }
}
*/

void loop()
{
  
 //serialInputHandler();  // read some bytes
 matrixUpdate();  // always with the matrix updates
 
}
 
void serialInputHandler(){
 
      // serial input handler
   if(Serial.available() > 0){  // don't do any serial handling unless there is a byte waiting
         
         incomingByte = Serial.read();  // read the byte
         //fastUpdate();
         
         //matrixUpdate();
         //Serial.println(incomingByte, BYTE);
         
         //switch(incomingByte){  
           
         //case 255:  // if the byte is 255 then just like never mind then
         //break;

         //default:  // anything other than -1 needs to be handled
         
         switch(commandInProgress){  // is there a command in progress?
           
             case byte('c'):  //  (c)olor command is in progress, reading 3 bytes of color data into red, green and blue
             inputBuffer[byteNum] = incomingByte;
             byteNum++;
             
             //matrixUpdate();
             //fastUpdate();
             
             if(byteNum > 2){  // fires if the input buffer has been filled
             //matrixUpdate();
             red = inputBuffer[0];
             //matrixUpdate();
             green = inputBuffer[1];
             //matrixUpdate();
             blue = inputBuffer[2];
             
             //matrixUpdate();
             //fastUpdate();
             
             //matrixUpdate();
             
             if(debugMode == true){
               Serial.print("RCVD c: ");
               Serial.print(red, HEX);
               Serial.print(" ");
               Serial.print(green, HEX);
               Serial.print(" ");
               Serial.println(blue, HEX);
               }
             
             
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "c" command
             
             }    
             break;
             
             case byte('p'):  //  (p)ixel command is in progress, reading 2 bytes of pixel offset data
             inputBuffer[byteNum] = incomingByte;
             byteNum++;
                
             if(byteNum > 1){  // fires if the input buffer has been filled
   
             pixel = (inputBuffer[1] * 256) + inputBuffer[0];
             
             if(debugMode == true){
               Serial.print("RCVD p: (");
               Serial.print(inputBuffer[1] * 256, DEC);
               Serial.print(" * 256) + ");
               Serial.print(inputBuffer[0], DEC);
               Serial.print(" = ");
               Serial.println(pixel, DEC);
               }
             
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "c" command
             
             }    
             break;
             
             case byte('r'):  // 'set red' in progress
             red = incomingByte;
             //byteNum++;
             //if(byteNum > 2){  // get 3 bytes of color data
             //matrixUpdate();
             //red = inputBuffer[0] * 256 + inputBuffer[1] * 16 + inputBuffer[2];
             //Serial.print("RCVD r: ");
             //Serial.println(red, DEC);
             //byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "r" command
             //}    
             break;
             
             case byte('g'):  // 'set green' in progress
             //inputBuffer[byteNum] = incomingByte;
             green = incomingByte;             
             //byteNum++;
             //if(byteNum > 2){  // get 3 bytes of color data
             //matrixUpdate();
             //green = inputBuffer[0] * 256 + inputBuffer[1] * 16 + inputBuffer[2];
             //Serial.print("RCVD g: ");
             //Serial.println(green, DEC);
             //byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "g" command
             //}    
             break;
             
             case byte('b'):  // 'set blue' in progress
             //inputBuffer[byteNum] = incomingByte;
             //byteNum++;
             blue = incomingByte;
             //if(byteNum > 2){  // get 3 bytes of color data
             //matrixUpdate();
             //blue = inputBuffer[0] * 256 + inputBuffer[1] * 16 + inputBuffer[2];
             //Serial.print("RCVD b: ");
             //Serial.println(blue, DEC);
             //byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "b" command
             //}    
             break;
         
             case byte('d'): //  ON (d)elay setting, get one int from serial and set the onDelay variable with it
             inputBuffer[byteNum] = incomingByte;
             byteNum++;
             if(byteNum > 3){  // get 4 bytes, then do this
             onDelay = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
             // feedback
             if (debugMode == true){             
               Serial.print("RCVD d: ");
               Serial.println(onDelay);
               }
               
             // cleanup
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "d" command
             }
             break;
             
             case byte('e'): //  OFF d(e)lay setting, get one int from serial and set the offDelayMs variable with it
             // add incoming byte to buffer
             inputBuffer[byteNum] = incomingByte;
             byteNum++;
             // check if all data has been received
             if(byteNum > 3){  // get 4 bytes, then do this
             // do it      
             offDelay = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
             // feedback
             if (debugMode == true){             
               Serial.print("RCVD e: ");
               Serial.println(offDelay);
               }
             
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "e" command
             }
             break;
             
             case byte('x'): //  slowDown delay
             // add incoming byte to buffer
             inputBuffer[byteNum] = incomingByte;
             byteNum++;
             // check if all data has been received
             if(byteNum > 3){  // get 4 bytes, then do this
             // do it      
             slowDown = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
             // feedback
             if (debugMode == true){             
               Serial.print("RCVD x: ");
               Serial.println(slowDown);
               }
             
             // cleanup
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "e" command
             }
             break;
             
             case byte('m'): //  get an entire frame's worth of data
             //inputBuffer[byteNum] = incomingByte;
             
             pixelArray[byteNum] = incomingByte;
             
             if(debugMode == true){
               Serial.print("z: ");
               Serial.print(byteNum, DEC);
               Serial.print(", ");
               Serial.print(incomingByte, DEC);
               Serial.println();
             }
             
             byteNum++;
             
             if(byteNum > (numLEDs * channelsPerLED) - 1){  // get color data for every pixel      
             
             // cleanup
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "m" command
             }
             break;

             case byte('*'): //  load a new tlcMap array
             //inputBuffer[byteNum] = incomingByte;
             
             tlcMap[byteNum] = incomingByte;
             
             if(debugMode == true){
               Serial.print("*: ");
               Serial.print(byteNum, DEC);
               Serial.print(", ");
               Serial.print(incomingByte, DEC);
               Serial.println();
             }
             
             byteNum++;
             
             if(byteNum > numTLCs - 1){  // get a tlcMap byte for every TLC (0-based array)     
             
             // cleanup
             byteNum = 0; // reinit byteNum
             commandInProgress = 'n'; // end of the "m" command
             }
             break;
             
             case byte('s'): //  's'et a parameter, followed by a second char byte indicating the param to be set, then the data
                 
                 //Serial.println("beginning set command");
                 
                 //incomingByte2 = Serial.read();  // read the byte
                 
                 switch(incomingByte){
                 
                     case('r'):  // setting the numRows variable
                     //Serial.println("beginning set rows");
                     // try to pull data
                     incomingByte = Serial.read();  // compensates for ascii - byte conversion *FIX THIS*
                     while(incomingByte == 255){  // 207 = 255 - 48, wait for valid serial data if necessary
                     incomingByte = Serial.read();
                     }                 
                     //Serial.print("RECD sr: ");
                     //Serial.println(incomingByte, DEC);
                     if(incomingByte > 0 && incomingByte < 9){   // numRows should be between 1 and 8
                     numRows = incomingByte;
                     
                     
                     numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
                     ledsPerPanel = numLEDs / numTLCs;
                     
                     }
                     commandInProgress = 'n'; // end of the "sr" command
                     break;
                     
                     case('c'):  // setting the numChannels variable
                     //Serial.println("beginning set rows");
                     // try to pull data
                     incomingByte = Serial.read();  // compensates for ascii - byte conversion *FIX THIS*
                     while(incomingByte == 255){  // wait for valid serial data if necessary
                     incomingByte = Serial.read();  // hex byte to ascii
                     }
                     //incomingByte = incomingByte - 47; // hex/ascii to byte conversion
                     //Serial.print("RECD sc: ");
                     //Serial.println(incomingByte, DEC);
                     if(incomingByte > 0 && incomingByte < 17){   // numChannels should be between 1 and 16
                     numChannels = incomingByte;
                     
                     numColumns = numChannels / channelsPerLED; // recalculate dependent variables
                     numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
                     matrixColumns = numTLCCols * numColumns;
                     
                     }
                     commandInProgress = 'n'; // end of the "sc" command
                     break;                

                     case('p'):  // setting the channelsPerLED variable
                     //Serial.println("beginning set rows");
                     // try to pull data
                     incomingByte = Serial.read();  
                     while(incomingByte == 255){  // wait for valid serial data if necessary
                     incomingByte = Serial.read();
                     }
                     //Serial.print("RECD sp: ");
                     //Serial.println(incomingByte, DEC);
                     if(incomingByte > 0 && incomingByte < 17){   // channelsPerLED should be between 1 and 16
                     channelsPerLED = incomingByte;
                     
                     numColumns = numChannels / channelsPerLED; // recalculate dependent variables
                     numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
                     matrixColumns = numTLCCols * numColumns;
                     
                     }
                     commandInProgress = 'n'; // end of the "sp" command
                     break;
                  
                     //case('t'):  // setting the numTLCs variable
                     //Serial.println("beginning set rows");
                     // try to pull data
                     //incomingByte = Serial.read();  
                     //while(incomingByte == 255){  // wait for valid serial data if necessary
                     //incomingByte = Serial.read();
                     //}
                     //Serial.print("RECD st: ");
                     //Serial.println(incomingByte, DEC);
                     //if(incomingByte > 0 && incomingByte < 101){   // numTLCs should be between 1 and 100
                     //numTLCs = incomingByte;
                     //}
                     //commandInProgress = 'n'; // end of the "st" command
                     //break;
                     
                     case('l'):  // setting numTLCCols
                     //Serial.println("beginning set rows");
                     // try to pull data
                     incomingByte = Serial.read();  
                     while(incomingByte == 255){  // wait for valid serial data if necessary
                     incomingByte = Serial.read();
                     }
                     Serial.print("RECD sl: ");
                     Serial.println(incomingByte, DEC);
                     if(incomingByte > 0 && incomingByte < 21){   // numTLCCols should be between 1 and 20
                     
                     numTLCCols = incomingByte;
                     
                     numTLCs = numTLCRows * numTLCCols;
                     numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
                     matrixColumns = numTLCCols * numColumns;
                     #define NUM_TLCS = numTLCs;
                     
                     }
                     commandInProgress = 'n'; // end of the "st" command
                     break;
                     
                     case('w'):  // setting the numTLCRows
                     //Serial.println("beginning set rows");
                     // try to pull data
                     incomingByte = Serial.read();  
                     while(incomingByte == 255){  // wait for valid serial data if necessary
                     incomingByte = Serial.read();
                     }
                     Serial.print("RECD sw: ");
                     Serial.println(incomingByte, DEC);
                     if(incomingByte > 0 && incomingByte < 21){   // numTLCRows should be between 1 and 20
                     
                     numTLCRows = incomingByte;
                     
                     numTLCs = numTLCRows * numTLCCols;  // recalculate dependents
                     numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
                     #define NUM_TLCS = numTLCs;
                     
                     }
                     commandInProgress = 'n'; // end of the "st" command
                     break;
                     
                     
                     } // end set commands
             break;
             
             case byte('n'): // no command was in progress, new command starting
        
                 //incomingByte = Serial.read();  // read the byte
                 
                 switch(incomingByte){
                 
                     /* case byte('c'): // specify a (c)olor, parameters are 9 bytes of RGB color space data
                                  
                                  // get 9 bytes of RGB color data
                                  for(byteNum = 0; byteNum < 9; byteNum++){
                                  
                                          while(Serial.available() > 0){
                                          incomingByte = Serial.read();                                    
                                          }
                                                                                                         
                                  inputBuffer[byteNum] = incomingByte;
                                  
                                  }
                                  //if(byteNum > 8){  // fires if the input buffer has been filled
                                  red = inputBuffer[0] * 256 + inputBuffer[1] * 16 + inputBuffer[2];  // this would be prettier if it was shifty
                                  green = inputBuffer[3] * 256 + inputBuffer[4] * 16 + inputBuffer[5];
                                  blue = inputBuffer[6] * 256 + inputBuffer[7] * 16 + inputBuffer[8];
                                  Serial.print("RCVD c: ");
                                  Serial.print(red, HEX);
                                  Serial.print(" ");
                                  Serial.print(green, HEX);
                                  Serial.print(" ");
                                  Serial.println(blue, HEX);
                                  byteNum = 0; // reinit byteNum
                                  }    
                                  break; */
                     
                     case byte('c'):
                     //Serial.println("Starting c:");
                     commandInProgress = 'c';
                     break;

                     case byte('t'):  // s(T)atus, send parameter dump, reset command state, send "Ready."
                     
                     Serial.println("---------------------");
                     
                     Serial.print("numTLCCols: ");
                     Serial.println(numTLCCols, DEC);
                     Serial.print("numTLCRows: ");
                     Serial.println(numTLCRows, DEC);
                     
                     Serial.print("numTLCs: ");
                     Serial.println(numTLCs, DEC);
                     
                     Serial.print("numRows: ");
                     Serial.println(numRows, DEC);
                     
                     Serial.print("numColumns: ");
                     Serial.println(numColumns, DEC);
                     
                     Serial.print("numChannels: ");
                     Serial.println(numChannels, DEC);
                     Serial.print("channelsPerLED: ");
                     Serial.println(channelsPerLED, DEC);

                     Serial.print("numLEDs: ");
                     Serial.println(numLEDs, DEC);
                     Serial.print("red: ");
                     
                     Serial.print(red, DEC);
                     Serial.print(" green: ");
                     Serial.print(green, DEC);
                     Serial.print(" blue: ");
                     Serial.println(blue, DEC);
                     Serial.print("onDelay: ");
                     Serial.println(onDelay, DEC);
                     Serial.print("offDelay: ");
                     Serial.println(offDelay, DEC);
                     //Serial.print("last commandInProgress: ");
                     //Serial.println(commandInProgress, BYTE);
                     Serial.print("current pixel: ");
                     Serial.println(pixel, DEC);
                     //Serial.print("byteNum: ");
                     //Serial.println(byteNum, DEC);
                     Serial.print("Available memory: ");
                     Serial.println(availableMemory(), DEC);
                     Serial.println();
                     Serial.println("Ready.");

                     break;
                     
                     case byte('y'): // dump the pixel array to serial port for examination
                     
                     if(debugMode == true){
                     Serial.println("RCVD y: dump pixelArray");
                     }
                     
                     for (int i = 0; i < (numLEDs * channelsPerLED) - 1; i = i + channelsPerLED) {
                       
                    
                     //Serial.print("pixelArrayOffset: ");
                     Serial.print(i, DEC);
                     Serial.print(" contains ");
                     Serial.print(pixelArray[i], HEX);
                     //Serial.print(", ");
                     Serial.print(pixelArray[i + 1], HEX);
                     //Serial.print(", ");
                     Serial.println(pixelArray[i + 2], HEX);
                     
                     
                     }
                     
                     break;
                       
                     
                     
                     case byte('p'): // get two bytes specifying a pixel offset in pixelArray
                     commandInProgress = 'p';
                     break;
                     
                     case byte('d'): // ON delay setting, parameter is one unsigned long (4 bytes), minimum number of microseconds to keep a row lit
                     commandInProgress = 'd';
                     break;
                     
                     case byte('e'): // OFF delay setting, parameter is one unsigned long (4 bytes), turns all LEDs off for this number of microseconds before lighting next row
                     commandInProgress = 'e';
                     break;
                     
                     case byte('x'): // slowDown delay
                     commandInProgress = 'x';
                     break;
                     
                     case byte('r'): // Set red level, parameter is 3 bytes of color
                     commandInProgress = 'r';
                     break;
                     
                     case byte('g'): // Set green level, parameter is 3 bytes of color
                     commandInProgress = 'g';
                     break;
                     
                     case byte('b'): // Set blue level, parameter is 3 bytes of color
                     commandInProgress = 'b';
                     break;
                     
                     case byte('s'): // Sets a parameter, followed by another char indicating which parameter will be set and then the param data
                     commandInProgress = 's';
                     break;
                     
                     case byte('m'): // receive a frame's worth (numLEDs * channelsPerLED) of color data.  a bit slow at the moment.
                     commandInProgress = 'm';
                     
                     if(debugMode == true){
                     
                       Serial.print("Number of bytes to read: ");
                       Serial.println((numLEDs * channelsPerLED) - 1, DEC);
                       
                     }
                     
                     
                     break;

                     case byte('*'): // Load a new TLC Map array on the fly, size is numTLCs.  
                     commandInProgress = '*';
                     
                     if(debugMode == true){
                     
                       Serial.println("RCVD: * load tlcMap array ");
                       //Serial.println((numLEDs * channelsPerLED) - 1, DEC);
                       
                     }
                     
                     break;

                     
                     /*case byte('p'): // Specifies a (p)ixel, parameter is one byte index in pixelArray
                         //Serial.println("beginning set pixel");
                         // try to pull data
                         incomingByte = Serial.read();
                         
                         if(debugMode == true){
                           Serial.print("read from serial and got: ");
                           Serial.println(incomingByte, DEC);
                           }
                           
                         while(incomingByte == 255){  // wait for valid serial data if necessary
                             incomingByte = Serial.read();
                             //matrixUpdate();
                             //Serial.println(incomingByte, DEC);
                         }
                         
                         if(debugMode == true){
                           Serial.print("RCVD p: ");
                           Serial.println(incomingByte, DEC);
                           }
                           
                         if(incomingByte < numLEDs){   // pixel should be between 0 and numLEDs - 1 (cause pixelArray is a 0 based array)
                           pixel = incomingByte;
                         }
                         
                     break;
                     */
                     
                     case byte('a'): // Color (a)ll pixels, no parameter, rgb are taken from global variables
                     colorSolid();
                     break;
                     
                     case byte('k'): // shift matrix left
                     shiftLeft();
                     break;
                     
                     case byte('o'): // turn current pixel (o)n with current RGB values
                     
                     // figure out the tlcRow from pixel
                     
                     //int ledsPerRow = numTLCCols * numColumns;
                     //whichTLCRow = int(( pixel / ledsPerRow) / numRows);
                     //whichTLCCol = int(( pixel - (ledsPerRow * whichTLCRow * numRows)) / ledsPerRow);
                     
                     //whichTLC = (whichTLCRow * numTLCCol) + whichTLCCol;
                     
                     //tlcOffset = whichTLC * numRows * numColumns * channelsPerLED; // 1050
                     //channelOffset = (pixel * channelsPerLED) - tlcOffset; // 69
                     pixelArrayOffset = pixel * channelsPerLED;
                     
                     pixelArray[pixelArrayOffset] = red;
                     pixelArray[pixelArrayOffset + 1] = green;
                     pixelArray[pixelArrayOffset + 2] = blue;
                     
                     //dirtyMatrix = true;
                     if(debugMode == true){
                       Serial.print("RCVD o: ");
                       Serial.print(pixel, DEC);
                       Serial.print(" ");
                       Serial.print(red, DEC);
                       Serial.print(" ");
                       Serial.print(green, DEC);
                       Serial.print(" ");
                       Serial.println(blue, DEC);
                       }
                     
                     break;
                     
                     case byte('f'): // turn current pixel o(f)f
                     
                     pixelArrayOffset = pixel * channelsPerLED;
                     
                     pixelArray[pixelArrayOffset] = 0;
                     pixelArray[pixelArrayOffset + 1] = 0;
                     pixelArray[pixelArrayOffset + 2] = 0;
                     //dirtyMatrix = true;
                     
                     if(debugMode == true){
                       Serial.print("RCVD f: ");
                       Serial.println(pixel, DEC);
                       }
                       
                     break;
                     
                     case byte('h'): // flip horizontal
                     
                     flipHorizontal = !flipHorizontal;
                     flipTLCMapHorizontal = !flipTLCMapHorizontal;
                     
                     //dirtyMatrix = true;
                     
                     if(debugMode == true){
                       Serial.print("RCVD h: flipHorizontal ");
                       Serial.println(flipHorizontal, DEC);
                       }
                       
                     break;
                     
                     case byte('v'): // flip vertical
                     
                     flipVertical = !flipVertical;
                     flipTLCMapVertical = !flipTLCMapVertical;
                     
                     //dirtyMatrix = true;
                     if(debugMode == true){
                       Serial.print("RCVD v: flip vertical");
                       Serial.println(flipVertical, DEC);
                       }
                       
                     break;
                     
                     case byte('@'): // flip TLC vertically

                     flipTLCMapVertical = !flipTLCMapVertical;
  
                     if(debugMode == true){
                       Serial.print("RCVD @: flip TLC map vertically ");
                       Serial.println(flipTLCMapVertical, DEC);
                       }
                       
                     break;
                     
                     case byte('!'): // flip TLC map horizontal
                     
                     flipTLCMapHorizontal = !flipTLCMapHorizontal;
                     
                     
                     if(debugMode == true){
                       Serial.print("RCVD !: flip TLC map horizontal ");
                       Serial.println(flipTLCMapHorizontal, DEC);
                       }
                       
                     break;
                     
                     case byte('w'): // flip debugMode state
                     
                     debugMode = !debugMode;
                     
                     //dirtyMatrix = true;
                     if(debugMode == true){
                       Serial.print("RCVD w: flip debugMode ");
                       Serial.println(flipVertical, DEC);
                       }
                       
                     break;  
                 
                 }  // end incoming byte
             }  // end command in progress
         //}
     } // end serial handler
   
 }
 
// this function will return the number of bytes currently free in RAM
// written by David A. Mellis
// based on code by Rob Faludi http://www.faludi.com
int availableMemory() {
  int size = 4096; // 4k SRAM
  byte *buf;

  while ((buf = (byte *) malloc(--size)) == NULL)
    ;

  free(buf);

  return size;
}
 
