//  Magnificent Mood Machine / LED Matrix Driver Firmware 1.0
//  By Alex Mizell based on the work of Alex Leone
//  March - July 2010
// 
//  Changelog:
//
//  11/12/2010 - Begin cleanup and refactoring for official version 1.0 release

// Include ALeone's driver
#include "Tlc5940.h"

// BEGIN STANDARD MATRIX GLOBALS

// Flag and delay factor to ease troubleshooting
boolean debugMode = false;
int slowDown = 50;

// mapping arrays!
//int tlcMap[16] = {9,8,3,2,10,7,4,1,11,6,5,0,0,0}; // create the tlcMap array, initialize with 3 rows x 4 columns, controller on bottom right
//int tlcMap[16] = {14,9,8,3,2,13,10,7,4,1,12,11,6,5,0}; // create the tlcMap array, initialize with 3 rows x 5 columns, controller on bottom right

int tlcMap[16] = {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}; // one TLC only

int colorMap[3] = {2, 1, 0}; // this can map any of the three color channels to any other, in this case: blue to red, green to green, red to blue.  can adjust for different wiring schemes.

// This pin connects to the 74LS138 decoder chip's enable input
int logicEnable = 2;

//  these pin numbers for Atmega644P pinout scheme, these are different for Arduino
int rowSelectA = 31;
int rowSelectB = 30;
int rowSelectC = 29;

// these environment variables set up the matrix geometry
int numTLCRows = 1;   // number of rows of TLC panels
int numTLCCols = 1;   // number of columns of TLC panels
int numTLCs = numTLCRows * numTLCCols;  // total number of TLCs chained together

unsigned int numRows = 5;  // number of rows driven by a single TLC
unsigned int numChannels = 15;  // channel 16 can be used, but not for our purposes
unsigned int channelsPerLED = 3;  //  1 for monochromatic LEDs, 3 for RGBs
unsigned int numColumns = numChannels / channelsPerLED; // 15 channels in use by one TLC divided by 3 colors per RGB LED = 5 columns per TLC
unsigned int numLEDs = numTLCRows * numRows * numColumns * numTLCCols; // total number of LEDs across all panels
unsigned int ledsPerPanel = numLEDs / numTLCs; // number of LEDs on a single panel
unsigned int matrixColumns = numTLCCols * numColumns; // number of columns across entire matrix
unsigned int matrixRows = numTLCRows * numRows;

// variables used when figuring pixelArray offsets
// see if some of these can be ditched or made local
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

unsigned int xyToPixelArrayLookup[25];  //  this speeds up the process of figuring a pixelArray index given an x,y 
unsigned int pixelArray[75];

unsigned int pixel = 0;
unsigned int red;
unsigned int green;
unsigned int blue;


// inital on/off timings - these are loaded if the mcu resets
unsigned long onDelay = 41;
unsigned long offDelay = 60; 

byte incomingByte; //  for incoming serial data
byte incomingByte2;	// for incoming serial data when the first byte is used?  do i need this?
byte commandInProgress = 'n';  // no command in progress to begin with
byte inputBuffer[16]={0, 0, 0, 0, 0, 0, 0 ,0 ,0, 0, 0, 0, 0, 0, 0, 0};  // largest parameter data size = 16 bytes
unsigned int byteNum = 0;  //  for counting incoming bytes

//  END OF STANDARD MATRIX GLOBALS

//  BEGIN PLASMA GLOBALS

float Rad2Deg = 3.14 / 180;

float c[18];  //  constants
float ct[18]; // temporary
float cv[18]; // velocity

float aspectRatio;
float wide;
float high;

float pos[5][5][2]; // position x,y = 200 bytes
float plasma[5][5][3]; // 5 rows * 5 columns * 3 colors in 4 byte floating points = 300 bytes

int plasmasize;

int dFocus = 10;
int dSpeed = 10;

int i, j;
float rgb[3];
float temp;
float focus = float(dFocus) / 50.0f + 0.3f;
float maxdiff = 0.004f * float(dSpeed);
int index;

// END PLASMA GLOBALS

void setup(){
  
// initialize the pins as outputs:
pinMode(rowSelectA, OUTPUT);
pinMode(rowSelectB, OUTPUT);
pinMode(rowSelectC, OUTPUT);
pinMode(logicEnable, OUTPUT);

// for now, just light up the first row
digitalWrite(rowSelectA, LOW);
digitalWrite(rowSelectB, LOW);
digitalWrite(rowSelectC, LOW);

digitalWrite(logicEnable, LOW);  //  setting the logicEnable pin LOW turns on the selected row

Tlc.init();

Tlc.clear();

Serial.begin(57600);

// build the xyToPixelArrayLookup table
byteNum = 0;

Serial.println("Building pixelArray lookup table...");

for(int j = 0; j < matrixRows; j++){

   for(int i = 0; i < matrixColumns; i++){
   
   pixel = selectPixel(i,j);
   xyToPixelArrayLookup[byteNum] = pixel;
   
   /* Serial.print(byteNum, DEC);
   Serial.print(", ");
   Serial.println(pixel, DEC); */

   byteNum++;
   
   }
  
 }

initPlasma();

Serial.println();
Serial.println("Ready.");

}

void initPlasma(){
  
        aspectRatio = matrixColumns / matrixRows;      
  
	if(aspectRatio >= 1.0f){
		wide = 3;
		high = wide / aspectRatio;
	}
	else{
		high = 3;
		wide = high * aspectRatio;
	}

	// Set resolution of plasma
	if(aspectRatio >= 1.0f)
		plasmasize = matrixColumns;
	else
		plasmasize = matrixRows;

	for(int i=0; i<plasmasize; i++){
		for(int j=0; j<int(float(plasmasize) / aspectRatio); j++){
			plasma[i][j][0] = 0.0f;
			plasma[i][j][1] = 0.0f;
			plasma[i][j][2] = 0.0f;
			pos[i][j][0] = float(i * wide) / float(plasmasize - 1) - (wide * 0.5f);
			pos[i][j][1] = float(j * high) / (float(plasmasize) / aspectRatio - 1.0f) - (high * 0.5f);
		}
	}

	// Initialize constants
	for(i=0; i<18; i++){
		ct[i] = rsRandf(6.28);
		cv[i] = rsRandf(0.005f * float(dSpeed)) + 0.0001f;
	}
}

// Useful random number macros
// Don't forget to initialize with srand()
inline int rsRandi(int x){
	return rand() % x;
}
inline float rsRandf(float x){
	return x * (float(rand()) / float(RAND_MAX));
}

// Find absolute value and truncate to 1.0
inline float fabstrunc(float f){
	if(f >= 0.0f)
		return(f <= 1.0f ? f : 1.0f);
	else
		return(f >= -1.0f ? -f : 1.0f);
}

void matrixUpdate(){

        // plasma code here
  
        //Update constants
	for(i=0; i<18; i++){
		ct[i] += cv[i];
		if(ct[i] > 6.28)
			ct[i] -= 6.28;
		c[i] = sin(ct[i]) * focus;
	}
  
        // Update colors
	for(i=0; i<plasmasize; i++){
		for(j=0; j<int(float(plasmasize) / aspectRatio); j++){
			// Calculate vertex colors
			rgb[0] = plasma[i][j][0];
			rgb[1] = plasma[i][j][1];
			rgb[2] = plasma[i][j][2];
			plasma[i][j][0] = 0.7f
							* (c[0] * pos[i][j][0] + c[1] * pos[i][j][1]
							+ c[2] * (pos[i][j][0] * pos[i][j][0] + 1.0f)
							+ c[3] * pos[i][j][0] * pos[i][j][1]
							+ c[4] * rgb[1] + c[5] * rgb[2]);
			plasma[i][j][1] = 0.7f
							* (c[6] * pos[i][j][0] + c[7] * pos[i][j][1]
							+ c[8] * pos[i][j][0] * pos[i][j][0]
							+ c[9] * (pos[i][j][1] * pos[i][j][1] - 1.0f)
							+ c[10] * rgb[0] + c[11] * rgb[2]);
			plasma[i][j][2] = 0.7f
							* (c[12] * pos[i][j][0] + c[13] * pos[i][j][1]
							+ c[14] * (1.0f - pos[i][j][0] * pos[i][j][1])
							+ c[15] * pos[i][j][1] * pos[i][j][1]
							+ c[16] * rgb[0] + c[17] * rgb[1]);

			// Don't let the colors change too much
			temp = plasma[i][j][0] - rgb[0];
			if(temp > maxdiff)
				plasma[i][j][0] = rgb[0] + maxdiff;
			if(temp < -maxdiff)
				plasma[i][j][0] = rgb[0] - maxdiff;
			temp = plasma[i][j][1] - rgb[1];
			if(temp > maxdiff)
				plasma[i][j][1] = rgb[1] + maxdiff;
			if(temp < -maxdiff)
				plasma[i][j][1] = rgb[1] - maxdiff;
			temp = plasma[i][j][2] - rgb[2];
			if(temp > maxdiff)
				plasma[i][j][2] = rgb[2] + maxdiff;
			if(temp < -maxdiff)
				plasma[i][j][2] = rgb[2] - maxdiff;

			// Put colors into texture
			index = lookupPixel(i,j);

			pixelArray[index] = int(fabstrunc(plasma[i][j][0]) * 255);
			pixelArray[index+1] = int(fabstrunc(plasma[i][j][1]) * 255);
			pixelArray[index+2] = int(fabstrunc(plasma[i][j][2]) * 255);
		}
	}
  
	// row loop -- top level --
        for (int row = numRows - 1; row >= 0; row--) {  // iterate backwards through rows, this makes for left-to-right strobing
    
		for (int tlcRow = 0; tlcRow < numTLCRows; tlcRow++) {  // iterate forward through tlcRows

			for (int tlcCol = 0; tlcCol < numTLCCols; tlcCol++) {  // iterate forward through tlcCols
          
				//  calculate the pixelArray offset by consulting the tlcMap array
            	                //  these variables are used to map to TLC channels
				currentTLC = (tlcRow * numTLCCols) + tlcCol;
				tlcOffset = tlcMap[currentTLC] * 16;  // offset to current TLC channel 0 measured in TLC channels (hence * 16) via tlcMap[]

				// these are for indexing the pixel array
				currentArrayTLC = (tlcRow * numTLCCols) + tlcCol;
				arrayTlcOffset = currentArrayTLC * numRows * numColumns;
            
				// Column loop
        
				for (int col = numColumns - 1; col >= 0; col--) { // iterate backwards through columns
				
					// calculate the pixel's byte offset in the pixelArray
					pixelOffset = ((col * numRows) + row);  // 
					totalByteOffset = (arrayTlcOffset + pixelOffset) * channelsPerLED;
					totalChannelOffset = tlcOffset + (col * channelsPerLED);
					
					// set the TLC from the correct color bytes in the pixelArray
					Tlc.set(totalChannelOffset, pixelArray[totalByteOffset + colorMap[0]] * 16);
					Tlc.set(totalChannelOffset + 1, pixelArray[totalByteOffset + colorMap[1]] * 16);
					Tlc.set(totalChannelOffset + 2, pixelArray[totalByteOffset + colorMap[2]] * 16);
          
				// the columns for one TLC is loaded, advance to next TLC in the row
				}
				
			// loaded one column of TLCs
			}
      
		// one row of TLCs across the matrix has been loaded, advance to the next row of TLCs
		}
   
		digitalWrite(logicEnable, HIGH); // all rows off
		  
		// all of the TLCs have been set
		// shift all of the data to the chips
		Tlc.update();
		
		// select the current row with the 74LS138
		PORTA = row;  // for 644p

		for(int i = 0; i <= offDelay; i++){  //  <= ensures that the serial handler is called at least once for every matrix refresh
		
			//  Previous designers have encountered problems with color smearing because they did not allow sufficient time for the 
			//  row-switching transistors to turn off before moving to the next row.  This design includes a delay between the time
			//  that the previous row is switched off and the next switched on.  Instead of twiddling our thumbs during this time we
			//  instead run the serial input handler so that something useful can be going on.  The offDelay value should be about 55 
			//  iterations to avoid smearing in a 3 x 5 TLC matrix.  Fewer TLCs allows a slightly shorter delay.
			
				serialInputHandler();
			
		}

		digitalWrite(logicEnable, LOW);  // switch on the row
		
		// This delay should be at least as long as the offDelay to allow the LEDs to get some PWM cycles in before moving on to the 
		// next row.  The ratio of off/on time will affect the overall LED brightness and amount of visible flicker.
	  
		for(int i = 0; i < onDelay; i++){
	
			serialInputHandler();
	
		}
		
	}
  
}

void colorSolid(){
	
	// set the pixel array with a solid color
	for(int cpixel = 0; cpixel < numLEDs * channelsPerLED; cpixel = cpixel + channelsPerLED) {
  
		pixelArray[cpixel] = red;
		pixelArray[cpixel + 1] = green;
		pixelArray[cpixel + 2] = blue;

        }
}

void shiftLeft(){

	// we will iterate through all TLCs
	for(int tlcCol=0; tlcCol < numTLCCols; tlcCol++) {
      
		if (debugMode){
     
			Serial.println("begin shifting left");
 
		}
     
		for(int col=0; col < numColumns; col++) {
       
			if (debugMode){
       
				Serial.print("starting col ");
				Serial.println(col, DEC);
       
			}
       
			for(int tlcRow=0; tlcRow < numTLCRows; tlcRow++) {
         
				if (debugMode){
       
					Serial.print("starting tlcRow ");
					Serial.println(tlcRow, DEC);
       
				}
         
				int tlcOffset1 = ((tlcRow * numTLCCols) + tlcCol) * ledsPerPanel;
         
				if (debugMode){
       
					Serial.print("tlcOffset1:  ");
					Serial.println(tlcOffset1, DEC);
       
				}
         
				for(int row=0; row < numRows; row++) {
         
					int pixelOffset1 = (row * numColumns) + col;  
					int totalOffset1 = (tlcOffset1 + pixelOffset1) * channelsPerLED;
			   
					if (debugMode){
		   
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
           
						// for the fifth column, go one TLC right (use the TLCMap) and then back four pixels (numColumns - 1)
             
						if(tlcCol < numTLCCols - 1) {
             
							pixelArray[totalOffset1] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED) - ((numColumns - 1) * channelsPerLED)];
							pixelArray[totalOffset1 + 1] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED)  - ((numColumns - 1) * channelsPerLED)+ 1];
							pixelArray[totalOffset1 + 2] = pixelArray[totalOffset1 + (ledsPerPanel * channelsPerLED)  - ((numColumns - 1) * channelsPerLED)+ 2];
               
							if (debugMode){
       
								Serial.println("a fifth column! ");
								Serial.print("totalOffset1 + (ledsPerPanel * channelsPerLED): ");
								Serial.println(totalOffset1 + (ledsPerPanel * channelsPerLED), DEC);
     
							}
             
						}
						
						else{
             
							// on the last column of the last TLC in the row, just return zeros to avoid reading beyond the array bounds
               
							pixelArray[totalOffset1] = 0;
							pixelArray[totalOffset1 + 1] = 0;
							pixelArray[totalOffset1 + 2] = 0;
               
							if (debugMode){
       
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

void loop(){
  
 matrixUpdate();  // always with the matrix updates
 
}
 
void serialInputHandler(){
 
	// serial input handler
	if(Serial.available() > 0){  // don't do any serial handling unless there is a byte waiting
         
		incomingByte = Serial.read();  // read a byte
         
        switch(commandInProgress){  // is there a command in progress?
           
            case byte('c'):  // (c)olor command is in progress, reading 3 bytes of color data into red, green and blue
            
				inputBuffer[byteNum] = incomingByte;
				byteNum++;
             
				if(byteNum > 2){  // fires if the input buffer has been filled
					
					red = inputBuffer[0];
					green = inputBuffer[1];
					blue = inputBuffer[2];
            
					if(debugMode){
					
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
                commandInProgress = 'n'; // end of the "r" command
				break;
             
            case byte('g'):  // 'set green' in progress
             
				green = incomingByte;             
				commandInProgress = 'n'; // end of the "g" command
				break;
             
            case byte('b'):  // 'set blue' in progress
				
				blue = incomingByte;
				commandInProgress = 'n'; // end of the "b" command
				break;
         
            case byte('d'): //  ON (d)elay setting, get one int from serial and set the onDelay variable with it
				
				inputBuffer[byteNum] = incomingByte;
				byteNum++;
             
				if(byteNum > 3){  // get 4 bytes, then do this
					
					onDelay = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
					if (debugMode){             
						
						Serial.print("RCVD d: ");
						Serial.println(onDelay);
					}

					byteNum = 0; // reinit byteNum
					commandInProgress = 'n'; // end of the "d" command
					
				}
				
				break;
             
            case byte('e'): //  OFF d(e)lay setting, get one int from serial and set the offDelayMs variable with it

				inputBuffer[byteNum] = incomingByte;
				byteNum++;
				
				if(byteNum > 3){  // get 4 bytes, then do this
				
					offDelay = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
					if (debugMode == true){
				
						Serial.print("RCVD e: ");
						Serial.println(offDelay);
					}
             
					byteNum = 0; // reinit byteNum
					commandInProgress = 'n'; // end of the "e" command
				
				}
				
				break;
             
            case byte('x'): //  change slowDown delay
			
				inputBuffer[byteNum] = incomingByte;
				byteNum++;
             
				if(byteNum > 3){  // get 4 bytes, then do this
				
					slowDown = (inputBuffer[0] * 4096) + (inputBuffer[1] * 256) + (inputBuffer[2] * 16) + inputBuffer[3];
             
					if (debugMode){             
						
						Serial.print("RCVD x: ");
						Serial.println(slowDown);
					}

					byteNum = 0; // reinit byteNum
					commandInProgress = 'n'; // end of the "e" command
				}
				
				break;
             
            case byte('m'): //  get an entire frame's worth of data
            
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
				
					byteNum = 0; // reinit byteNum
					commandInProgress = 'n'; // end of the "m" command
					
				}
				
				break;

            case byte('*'): //  load a new tlcMap array
				
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
             
					byteNum = 0; // reinit byteNum
					commandInProgress = 'n'; // end of the "m" command
				}
				
				break;

            
            case byte('s'): //  's'et a parameter, followed by a second char indicating the param to be set, then the data
                 
		//  's' commands are two-tiered, so the next byte in the buffer specifies which 's'et command we are running
                switch(incomingByte){
                 
                    case('r'):  // setting the numRows variable

						incomingByte = Serial.read(); 
                     
						//  take another look at this line when time allows (we can't send value of 255?)
						while(incomingByte == 255){  // wait for valid serial data if necessary
					
							incomingByte = Serial.read();
						
						}
						
						if(incomingByte > 0 && incomingByte < 9){   // numRows should be between 1 and 8
						
							numRows = incomingByte;
							
							// recalculate dependent variables
							numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
							ledsPerPanel = numLEDs / numTLCs;
                                                        matrixRows = numTLCRows * numRows;
							
						}
					 
						commandInProgress = 'n'; // end of the "sr" command
                    
						break;
                     
                    case('c'):  // setting the numChannels variable

						incomingByte = Serial.read();
                     
						//  this doesn't seem right
						while(incomingByte == 255){  // wait for valid serial data if necessary
							
							incomingByte = Serial.read(); 
							
						}
						
						if(incomingByte > 0 && incomingByte < 17){   // numChannels should be between 1 and 16
						
							numChannels = incomingByte;
							
							// recalculate dependent variables
							numColumns = numChannels / channelsPerLED; // recalculate dependent variables
							numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
							matrixColumns = numTLCCols * numColumns;
                     
						}
						
						commandInProgress = 'n'; // end of the "sc" command
						
						break;                

                    case('p'):  // setting the channelsPerLED variable
                    
						incomingByte = Serial.read();  
						
						while(incomingByte == 255){  // wait for valid serial data if necessary
							
							incomingByte = Serial.read();
						
						}
						
						if(incomingByte > 0 && incomingByte < 17){   // channelsPerLED should be between 1 and 16
						
							channelsPerLED = incomingByte;
                     
							// recalculate dependent variables
							numColumns = numChannels / channelsPerLED;
							numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
							matrixColumns = numTLCCols * numColumns;
                     
						}
						
						commandInProgress = 'n'; // end of the "sp" command
						
						break;
                     
                    case('l'):  // setting numTLCCols

						incomingByte = Serial.read();  
                     
						while(incomingByte == 255){  // wait for valid serial data if necessary
							
							incomingByte = Serial.read();
						
						}
						
						if(debugMode){
							
							Serial.print("RECD sl: ");
							Serial.println(incomingByte, DEC);
							
						}
						
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
                    
						incomingByte = Serial.read();  
						
						while(incomingByte == 255){  // wait for valid serial data if necessary
						
							incomingByte = Serial.read();
						}
						
						if(debugMode){
					
							Serial.print("RECD sw: ");
							Serial.println(incomingByte, DEC);
						}
						
						if(incomingByte > 0 && incomingByte < 21){   // numTLCRows should be between 1 and 20
                     
						numTLCRows = incomingByte;
						
						// recalculate dependent variables
						numTLCs = numTLCRows * numTLCCols;  // recalculate dependents
						numLEDs = numTLCRows * numRows * numColumns * numTLCCols;
						#define NUM_TLCS = numTLCs;
                                                matrixRows = numTLCRows * numRows;
                     
						}
						
						commandInProgress = 'n'; // end of the "st" command
						
						break;
                     
                } // end set commands
					
				break;
             
            case byte('n'): // no command was in progress, new command starting
                 
                switch(incomingByte){
                     
                    case byte('c'):
					 
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
                     
						if(debugMode){
							
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
                     
						if(debugMode){
                     
							Serial.print("Number of bytes to read: ");
							Serial.println((numLEDs * channelsPerLED) - 1, DEC);
                       
						}
                     
						break;

                    case byte('*'): // Load a new TLC Map array on the fly, size is numTLCs.  
                    
						commandInProgress = '*';
                     
						if(debugMode){
                     
							Serial.println("RCVD: * load tlcMap array ");
                       
						}
                     
						break;
                     
                    case byte('a'): // Color (a)ll pixels, no parameter, rgb are taken from global variables
                    
						colorSolid();
						break;
                     
                    case byte('k'): // shift matrix left
						
						shiftLeft();
						break;
                     
                    case byte('o'): // turn current pixel (o)n with current RGB values
                    
						pixelArrayOffset = pixel * channelsPerLED;
                     
						pixelArray[pixelArrayOffset] = red;
						pixelArray[pixelArrayOffset + 1] = green;
						pixelArray[pixelArrayOffset + 2] = blue;
                     
						if(debugMode){
							
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
                     
						if(debugMode){
						
							Serial.print("RCVD f: ");
							Serial.println(pixel, DEC);
						}
                       
						break;
                     
                     
                    case byte('w'): // flip debugMode state
                     
						debugMode = !debugMode;
                     
						if(debugMode == true){
					
							Serial.print("RCVD w: flip debugMode ");
							Serial.println(debugMode, DEC);
						
						}
                       
						break;


                      //  any command that didn't fit one of those case statements just got ignored

                }  // end new command starting
				 
            }  // end commandInProgress

          }  // end serial.available
   
	}  // end serial handler
 
int availableMemory(){

// this function will return the number of bytes currently free in RAM
// written by David A. Mellis
// based on code by Rob Faludi http://www.faludi.com

  int size = 4096; // 4k SRAM
  byte *buf;

  while ((buf = (byte *) malloc(--size)) == NULL);

  free(buf);

  return size;
}

int selectPixel(int x, int y){
  
  pixel = (y * matrixColumns) + x;

  unsigned int whichRow = pixel / matrixColumns;
  unsigned int whichColumn = pixel % matrixColumns;
  unsigned int whichTLCRow = whichRow / numRows;
  unsigned int whichTLCCol = whichColumn / numColumns;
  unsigned int whichTLC = (whichTLCRow * numTLCCols) + whichTLCCol;
  unsigned int tlcOffset2 = whichTLC * ledsPerPanel;
  
  whichRow = whichRow - (whichTLCRow * numRows);
  
  //unsigned int anotherOffset = pixel - (whichRow * matrixColumns) + (whichTLCCol * numColumns);
  
  whichColumn = pixel % numColumns;
  
  unsigned int pixelOffset2 = (whichRow * numColumns) + whichColumn;
  pixel = tlcOffset2 + pixelOffset2;

  /* if (debugMode){
  
     Serial.print("selectPixel(x,y,pixel): ");
     Serial.print(x, DEC);
     Serial.print(", ");
     Serial.print(y, DEC);
     Serial.print(", ");
     Serial.println(pixel);
  
  } */
  
  return pixel;

}

int lookupPixel(int x, int y){
  
  pixel = (y * matrixColumns) + x;
  pixel = xyToPixelArrayLookup[pixel];

  /* if (debugMode){
  
     Serial.print("selectPixel(x,y,pixel): ");
     Serial.print(x, DEC);
     Serial.print(", ");
     Serial.print(y, DEC);
     Serial.print(", ");
     Serial.println(pixel);
  
  } */
  
  return pixel;

}

