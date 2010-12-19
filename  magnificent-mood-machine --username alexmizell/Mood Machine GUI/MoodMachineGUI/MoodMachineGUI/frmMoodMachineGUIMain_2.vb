Imports System.Math
Imports Un4seen.Bass
Imports Un4seen.Bass.Misc.Visuals
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Collections



Public Class frmMain

    '  this all for visualisation support

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_Init(ByVal hInstance As IntPtr, ByVal hWnd As IntPtr) As Boolean
    End Function

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_PluginCreate(ByVal file As String, ByVal hPluginWnd As IntPtr, ByVal width As Integer, ByVal height As Integer, ByVal flags As Integer) As Integer
    End Function

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_PluginStart(ByVal handle As Integer) As Boolean
    End Function

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_PluginSetStream(ByVal handle As Integer, ByVal stream As Integer) As Boolean
    End Function

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_PluginRender(ByVal handle As Integer, ByVal hStream As Integer, ByVal hDC As IntPtr) As IntPtr
    End Function

    <DllImport("bass_sfx.dll")> _
    Public Shared Function BASS_SFX_PluginResize(ByVal handle As Integer, ByVal width As Integer, ByVal height As IntPtr) As Boolean
    End Function

    Private Declare Function GetDC Lib "user32.dll" (ByVal hWnd As Int32) As IntPtr
    Private Declare Function ReleaseDC Lib "user32.dll" (ByVal hWnd As Int32, ByVal hDC As IntPtr) As Int32
    Private BASS_UNICODE As Integer = -2147483648
    Private hSFX As Integer = 0
    Private hVisDC As IntPtr = IntPtr.Zero

    '' for bitblit

    'Declare Auto Function BitBlt Lib "GDI32.DLL" ( _
    ' ByVal hdcDest As IntPtr, _
    ' ByVal nXDest As Integer, _
    ' ByVal nYDest As Integer, _
    ' ByVal nWidth As Integer, _
    ' ByVal nHeight As Integer, _
    ' ByVal hdcSrc As IntPtr, _
    ' ByVal nXSrc As Integer, _
    ' ByVal nYSrc As Integer, _
    ' ByVal dwRop As Int32) As Boolean



    Dim stopWatch1 As New Stopwatch
    Dim stopWatch2 As New Stopwatch
    Dim stopWatch3 As New Stopwatch

    Dim frameDeltaTimer As Stopwatch
    Dim maxBytesPerFrame As Integer


    Dim red As Byte = 0
    Dim green As Byte = 0
    Dim blue As Byte = 0

    Dim scrollingFont As Font
    Dim rowsTall As Integer
    Dim colsWide As Integer

    Dim pixelArray As Bitmap
    Dim lastFrame As Bitmap
    Dim pixelArrayG As Graphics

    Dim lastColor As Color


    'Dim offScreen As Bitmap
    'Dim offScreenG As Graphics

    Dim solidBrush As SolidBrush

    Dim isDrag As Boolean

    Dim stream As Integer
    Dim color1 As Color = Color.Blue
    Dim color2 As Color = Color.Blue
    Dim bgColor As Color = Color.Black

    Dim rectangle As Rectangle

    Dim myVisuals As Un4seen.Bass.Misc.Visuals

    Dim Rainbow As Integer = 1

    Dim movingAverageList As List(Of Integer)
    Dim movingAverageCount As Integer







    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' stopWatch1.Start()

        SerialPort1.Open()

        'too-simple test with no timeout 
        'for determining whether we're connected to the MCU
        'slams the CPU, bad code, bad!

        SerialPort1.Write("t") ' Send reset

        While SerialPort1.BytesToRead < 1
        End While

        System.Threading.Thread.Sleep(100)

        txtRowOnDelayMS_TextChanged(sender, e)
        txtOffDelayMs_TextChanged(sender, e)
        txtNumRows_TextChanged(sender, e)

        updateNumColumns()
        updateNumLEDs()
        txtNumTLCs_TextChanged(sender, e)


        ' animation array setup
        ' animation frames are rows in the animation table
        ' other environment data (e.g. onDelayMs and numRows) is also stored in these rows and so can be animated
        ' sequences can be built up by stepping through the frames with timing information from a sequence table
        '

        'Dim dsPixelArray As New DataSet

        'dsPixelArray.Tables.Add("tblFrames")
        'dsPixelArray.Tables.Add("tblSeqs")

        '' create column for each enviromental variable
        'dsPixelArray.Tables("tblFrames").Columns.Add("numTLCs")


        ' create a column for each color and pixel



        'updateColorFaders()


        ' Add columns to the datagridview
        ' This only adds them, they are futher adjusted by the txtNumColumns changed event

        'For i = 1 To Integer.Parse(txtNumColumns.Text)

        '    Dim newColumn As New System.Windows.Forms.DataGridViewButtonColumn

        '    dgLEDMatrix.Columns.Add(newColumn)

        'Next




        ' Begin scrolling text code

        Dim matrixTall As Integer = Val(txtNumTLCRows.Text) * Val(txtNumRows.Text)
        'Dim widestLetter As Integer

        scrollingFont = New Font("Microsoft Sans Serif", 14, FontStyle.Regular, GraphicsUnit.Pixel)
        'scrollingFont = txtFontName.Font


        txtFontName.ForeColor = Color.FromArgb(0, 255, 255)
        txtFontName.Text = scrollingFont.Name

        txtSayIt.Font = scrollingFont
        txtSayIt.ForeColor = txtFontName.ForeColor



        'pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor

        pixelArray = New Bitmap(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text), Imaging.PixelFormat.Format24bppRgb)
        pixelArrayG = Graphics.FromImage(pixelArray)
        pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear

        'offScreen = New Bitmap(widestLetter, matrixTall + 5, Imaging.PixelFormat.Format24bppRgb)
        'offScreenG = Graphics.FromImage(offScreen)

        'offScreenG.TransformPoints(

        'pbOffscreen.BackgroundImageLayout = ImageLayout.Stretch
        'pbOffscreen.BackgroundImage = offScreen

        pbPixelArray.BackgroundImageLayout = ImageLayout.Stretch
        pbPixelArray.BackgroundImage = pixelArray
        pbPixelArray.Refresh()

        lastFrame = pixelArray.Clone


        'Dim point As New Point(0, 0)


        'Dim scrollingBrush As New System.Drawing.SolidBrush(txtFontName.ForeColor)
        solidBrush = New SolidBrush(Color.Black)


        'Dim format As New System.Drawing.StringFormat("Gen



        'format.LineAlignment = StringAlignment.Near
        'format.Alignment = StringAlignment.Near

        'offScreenG.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        'offScreenG.DrawString("Q", scrollingFont, scrollingBrush, point, StringFormat.GenericTypographic)

        red = TextBox1.BackColor.R
        green = TextBox1.BackColor.G
        blue = TextBox1.BackColor.B
        sendColor()


        updateColorText()
        isDrag = False

        ' init BASS API for audio processing

        Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)

        ' create input stream

        stream = Bass.BASS_StreamCreateFile("C:\Music\08 Harder Better Faster Stronger.wav", 0, 0, BASSFlag.BASS_SAMPLE_FLOAT)


        ' play stream but pause it

        Bass.BASS_ChannelPlay(stream, False)
        Bass.BASS_Pause()

        ' create visuals object
        myVisuals = New Un4seen.Bass.Misc.Visuals

        ' for spectrum analyzer
        rectangle = New Rectangle(0, 0, pixelArray.Width + 1, pixelArray.Height)
        myVisuals.MaxFrequencySpectrum = 400
        myVisuals.ScaleFactorSqr = 4

        ' for bass_sfx visualisations

        hVisDC = GetDC(pbPixelArray.Handle)

        BASS_SFX_Init(System.Diagnostics.Process.GetCurrentProcess().Handle, Me.Handle)

        BASS_SFX_PluginSetStream(hSFX, stream)

        pbMiniMe.Height = pixelArray.Height
        pbMiniMe.Width = pixelArray.Width

        hSFX = BASS_SFX_PluginCreate("Plugins\MetreX.svp", pbPixelArray.Handle, pbPixelArray.Width, pbPixelArray.Height, 0)

        'BASS_SFX_PluginResize(hSFX, pixelArray.Width, pixelArray.Height)


        BASS_SFX_PluginStart(hSFX)

        frameDeltaTimer = New Stopwatch
        movingAverageList = New List(Of Integer)

        For i = 0 To 99

            movingAverageList.Add(0)

        Next

        movingAverageCount = 0


    End Sub

    Private Sub btnPickColor_Click(ByVal sender As  _
        System.Object, _
     ByVal e As System.EventArgs) Handles btnPickColor.Click, TextBox1.DoubleClick

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color
        End If

        updateColorFaders()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If SerialPort1.IsOpen Then


            pbSerialIn.Value = SerialPort1.BytesToRead
            pbSerialOut.Value = SerialPort1.BytesToWrite
            pbSerialIn.Update()
            pbSerialOut.Update()

            Dim SerialInput As String = ""

            If SerialPort1.IsOpen Then
                While SerialPort1.BytesToRead > 0


                    SerialInput = SerialInput & Chr(SerialPort1.ReadChar)

                End While

                txtSerial.Text = txtSerial.Text & SerialInput.ToString

                txtSerial.AppendText(SerialInput)

            End If

        End If

        If cbRainbow.Checked Then

            Dim sleeptime = hsSinFreqDiv.Value / 25

            'For i = 1 To 20

            If Rainbow > 6 Then Rainbow = 1

            Select Case Rainbow

                Case 1

                    red = 255
                    green = 0
                    blue = 0

                    colorSolid()
                    'System.Threading.Thread.Sleep(sleeptime)

                Case 2
                    red = 128
                    green = 255
                    blue = 0

                    colorSolid()

                Case 3

                    red = 0
                    green = 255
                    blue = 0

                    colorSolid()

                Case 4

                    red = 0
                    green = 255
                    blue = 255

                    colorSolid()

                Case 5

                    red = 0
                    green = 0
                    blue = 255

                    colorSolid()

                Case 6

                    red = 128
                    green = 0
                    blue = 255

                    colorSolid()

            End Select

            'Next

            'red = 0
            'green = 0
            'blue = 0

            Rainbow += 1

            System.Threading.Thread.Sleep(hsSinFreqDiv.Value / 10)

        End If


        Dim rnd As New Random
        Dim color As Color
        Dim rndcolor As Integer

        If cbRandom.Checked Then

            Dim x = rnd.Next(Val(txtMatrixCols.Text))
            Dim y = rnd.Next(Val(txtMatrixRows.Text))

            ' this version picks random colors
            'red = rnd.Next(255)
            'green = rnd.Next(255)
            'blue = rnd.Next(255)

            ' this version picks between rgb
            rndcolor = Int(rnd.Next(3))

            Select Case rndcolor

                Case 0
                    color = color.Red
                Case 1
                    color = color.Blue
                Case 2
                    color = color.Lime

            End Select


            'color = color.FromArgb(red, green, blue)

            drawPixel(x, y, color)

            ' this version picks between rgb
            'rndcolor = Int(rnd.Next(3))

            'Select Case rndcolor

            '    Case 0
            '        color = color.Red
            '    Case 1
            '        color = color.Blue
            '    Case 2
            '        color = color.Lime

            'End Select


            'color = color.FromArgb(red, green, blue)

            x = rnd.Next(Val(txtMatrixCols.Text))
            y = rnd.Next(Val(txtMatrixRows.Text))

            drawPixel(x, y, color)

            x = rnd.Next(Val(txtMatrixCols.Text))
            y = rnd.Next(Val(txtMatrixRows.Text))

            drawPixel(x, y, color)

            x = rnd.Next(Val(txtMatrixCols.Text))
            y = rnd.Next(Val(txtMatrixRows.Text))

            drawPixel(x, y, color)

            x = rnd.Next(Val(txtMatrixCols.Text))
            y = rnd.Next(Val(txtMatrixRows.Text))

            drawPixel(x, y, color)

        End If

        If cbEnableSpectrum.Checked Then

            myVisuals.CreateSpectrum(stream, pixelArrayG, rectangle, color1, color2, bgColor, False, True, True)
            pbPixelArray.Refresh()

            'If SerialPort1.IsOpen Then

            ' do this the right way - delta frames, sort the pixels to minimize color changes

            'sendFrameDelta()

            ' ----------------------------------------------------------------
            ' NEW CODE ADDED TO SPEED UP SPECTRUM BARS

            ' prepare the byte array
            ' since each column is 15 tall, and since 4 bits can store 16 values, 
            ' we can pack two of those 4-bit values per byte and send the entire array state in 26 bytes
            ' BUT there can be no more than 15 pixels in a column for this to work

            Dim byteIndex As Integer = 0
            Dim byteArrayLength As Integer = Val(txtMatrixCols.Text)



            ' if there's an odd number of columns then add 1 because we're sending columns in pairs
            If Not (byteArrayLength Mod 2 = 0) Then byteArrayLength += 1

            byteArrayLength = byteArrayLength / 2

            Dim byteArray(byteArrayLength - 1) As Byte

            byteArray.Initialize()

            ' send command plus byteArrayLength bytes for columns

            For i = 0 To Val(txtMatrixCols.Text) - 1

                ' for each column, find the non-black pixel with the greatest y value

                For j = 0 To Val(txtMatrixRows.Text) - 1

                    Dim thisColor = pixelArray.GetPixel(i, j)

                    If Not (thisColor = Drawing.Color.FromArgb(255, 0, 0, 0)) Then

                        ' if i = even then pack highest 4 bits of byteArray(byteIndex)

                        If i Mod 2 = 0 Then

                            byteArray(byteIndex) = 16 - j
                            byteArray(byteIndex) = byteArray(byteIndex) << 4

                        Else

                            ' if i = odd then pack the lowest 4 bits of byteArray(byteIndex)

                            byteArray(byteIndex) = byteArray(byteIndex) Or (16 - j)
                            byteIndex += 1

                        End If

                        Exit For

                        'Else

                        '    If i Mod 2 = 0 Then

                        '        byteArray(byteIndex) = 0
                        '        byteArray(byteIndex) = byteArray(byteIndex) << 4

                        '    Else

                        '        byteArray(byteIndex) = byteArray(byteIndex) Or j

                        '        byteIndex += 1

                        '    End If

                    End If

                Next

            Next

            ' stop here to debug

            ' now send the byteArray

            If SerialPort1.IsOpen Then

                SerialPort1.Write("#")
                SerialPort1.Write(byteArray, 0, byteArrayLength)

            End If


        End If

        ' render visualizations

        If cbVis1.Checked Then

            BASS_SFX_PluginRender(hSFX, stream, hVisDC)

            'Dim bmp As Bitmap = CType(pbMiniMe.Image, Bitmap)

            'pbPixelArray.BackgroundImage = CType(copyRect(pbMiniMe, New RectangleF(0, 0, pbMiniMe.Width, pbMiniMe.Height)), Bitmap)
            'pbPixelArray.Refresh()




        End If


    End Sub

    Private Sub btnRainbow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        If SerialPort1.IsOpen Then
            SerialPort1.Write("t")
        End If


    End Sub

    Private Sub updateColorFaders()

        red = TextBox1.BackColor.R
        green = TextBox1.BackColor.G
        blue = TextBox1.BackColor.B

        tbRed.Value = red
        tbGreen.Value = green
        tbBlue.Value = blue

    End Sub

    Private Sub updateColorText()

        TextBox2.Text = "Red: " & red & ", Green: " & green & ", Blue: " & blue

    End Sub

    Private Sub colorFaderChanged()

        'updateTextBox()
        'updateColorText()
        'colorSolid()


    End Sub

    Private Sub txtSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerial.TextChanged

        ' stay at the botom of the box
        txtSerial.SelectionStart = txtSerial.Text.Length
        txtSerial.ScrollToCaret()

    End Sub

    Private Sub timerSinGenerator_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerSinGenerator.Tick


        If CheckBox1.Checked Then
            red = ((Math.Sin(stopWatch1.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 255
        End If

        If CheckBox2.Checked Then
            green = ((Math.Sin(stopWatch2.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 255
        End If

        If CheckBox3.Checked Then
            blue = ((Math.Sin(stopWatch3.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 255
        End If

        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then

            updateTextBox()
            'colorSolid()
            updateColorFaders()
            'btnColorSolid_Click(sender, e)

        End If


    End Sub

    Private Sub hsSinFreqDiv_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsSinFreqDiv.Scroll

        lblSinFreq.Text = "Sin Freq Div: " & hsSinFreqDiv.Value

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRed.Scroll


        'red = tbRed.Value
        updateTextBox()
        'colorSolid()
        'colorFaderChanged()

    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGreen.Scroll

        'green = tbGreen.Value
        updateTextBox()
        'colorSolid()
    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBlue.Scroll

        'blue = tbBlue.Value
        updateTextBox()
        'colorSolid()

    End Sub

    Private Sub colorSolid()

        'red = TextBox1.BackColor.R * 16
        'green = TextBox1.BackColor.G * 16
        'blue = TextBox1.BackColor.B * 16



        Dim rectangle As Rectangle

        Dim topLeft As Point = New Point(0, 0)
        Dim bottomRight As Point = New Point(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text))

        rectangle = New Rectangle(topLeft, bottomRight)

        solidBrush.Color = Color.FromArgb(red, green, blue)

        pixelArrayG.FillRectangle(solidBrush, rectangle)
        pbPixelArray.Refresh()

        'dgLEDMatrix.Refresh()

        'Dim hexRed As String = Hex(red).PadLeft(3, "0")
        'Dim hexGreen As String = Hex(green).PadLeft(3, "0")
        'Dim hexBlue As String = Hex(blue).PadLeft(3, "0")

        'Dim hexString As String = hexRed & hexGreen & hexBlue
        'Dim byteArray(9) As Byte


        'For i = 0 To 8

        '    byteArray(i) = Integer.Parse(hexString(i), Globalization.NumberStyles.HexNumber)

        'Next


        'txtSerial.AppendText("R: " & hexRed & " G: " & hexGreen & " B: " & hexBlue & vbCrLf)

        If SerialPort1.IsOpen Then

            Dim redByte(1) As Byte
            Dim greenByte(1) As Byte
            Dim blueByte(1) As Byte

            redByte(0) = red
            greenByte(0) = green
            blueByte(0) = blue

            SerialPort1.Write("c") ' specify a 3 byte color
            SerialPort1.Write(redByte, 0, 1)
            SerialPort1.Write(greenByte, 0, 1)
            SerialPort1.Write(blueByte, 0, 1)
            'txtSerial.AppendText("SENT c: " & red & " " & green & " " & blue & vbCrLf)

            SerialPort1.Write("a") ' execute the color all command
            'txtSerial.AppendText("SENT a" & vbCrLf)

        End If

        updateColorText()


        'updateTextBox()

    End Sub

    Private Sub updateTextBox()

        TextBox1.BackColor = Color.FromArgb(Int(red), Int(green), Int(blue))

        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            colorSolid()
        End If

    End Sub

    Private Sub tbRed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRed.ValueChanged
        'coloSolidToMatrix()

        red = tbRed.Value
        Dim redByte(1) As Byte

        redByte(0) = red

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then ' don't send color changes if we are fading solids


            'Dim hexRed As String = Hex(tbRed.Value).PadLeft(3, "0")
            'Dim byteArray(3) As Byte

            'For i = 0 To 2

            '    byteArray(i) = Integer.Parse(hexRed(i), Globalization.NumberStyles.HexNumber)

            'Next

            'Dim oEnc As System.Text.Encoder

            'oEnc.GetBytes(red)


            If SerialPort1.IsOpen Then

                SerialPort1.Write("r")
                SerialPort1.Write(redByte, 0, 1)
                'txtSerial.AppendText("SENT r: " & red & vbCrLf)

                'SerialPort1.Write("a") ' execute the color all command
                'txtSerial.AppendText("SENT a" & vbCrLf)

            End If

        End If

        updateColorText()
        updateTextBox()

    End Sub

    Private Sub tbGreen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGreen.ValueChanged
        'coloSolidToMatrix()

        green = tbGreen.Value
        Dim greenByte(1) As Byte

        greenByte(0) = green

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then

            'Dim hexGreen As String = Hex(tbGreen.Value).PadLeft(3, "0")
            'Dim byteArray(3) As Byte

            'For i = 0 To 2

            '    byteArray(i) = Integer.Parse(hexGreen(i), Globalization.NumberStyles.HexNumber)

            'Next

            If SerialPort1.IsOpen Then

                SerialPort1.Write("g")
                SerialPort1.Write(greenByte, 0, 1)
                'txtSerial.AppendText("SENT g: " & green & vbCrLf)

                'SerialPort1.Write("a") ' execute the color all command
                'txtSerial.AppendText("SENT a" & vbCrLf)

            End If
        End If


        updateColorText()
        updateTextBox()

    End Sub

    Private Sub tbBlue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBlue.ValueChanged
        'coloSolidToMatrix()

        blue = tbBlue.Value
        Dim blueByte(1) As Byte

        blueByte(0) = blue

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then

            'Dim hexBlue As String = Hex(tbBlue.Value).PadLeft(3, "0")
            'Dim byteArray(3) As Byte

            'For i = 0 To 2

            '    byteArray(i) = Integer.Parse(hexBlue(i), Globalization.NumberStyles.HexNumber)

            'Next

            If SerialPort1.IsOpen Then

                SerialPort1.Write("b")
                SerialPort1.Write(blueByte, 0, 1)
                'txtSerial.AppendText("SENT b: " & blue & vbCrLf)

                'SerialPort1.Write("a") ' execute the color all command
                'txtSerial.AppendText("SENT a" & vbCrLf)

            End If
        End If

        updateColorText()
        updateTextBox()

    End Sub



    Private Sub txtRowOnDelayMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRowOn.TextChanged

        Dim hexOnDelayMs As String = Hex(Val(txtRowOn.Text)).PadLeft(4, "0")
        Dim byteArray(4) As Byte

        For i = 0 To 3

            byteArray(i) = Integer.Parse(hexOnDelayMs(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("d")
            SerialPort1.Write(byteArray, 0, 4)

            'txtSerial.AppendText("SENT d: " & hexOnDelayMs & vbCrLf)

        End If

    End Sub

    Private Sub txtNumRows_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim numRows As Byte = 0
        Dim matrixRows As Integer = 0


        If txtNumRows.Text <> "" Then
            numRows = Integer.Parse(txtNumRows.Text)

            If numRows > 0 And numRows < 9 Then

                If Val(txtNumTLCRows.Text) > 0 And Val(txtNumTLCRows.Text) < 17 Then

                    matrixRows = numRows * Val(txtNumTLCRows.Text)

                    txtMatrixRows.Text = matrixRows







                    If SerialPort1.IsOpen Then

                        SerialPort1.Write("sr")
                        SerialPort1.Write(Chr(numRows))

                        'txtSerial.AppendText("SENT sr: " & numRows.ToString & vbCrLf)

                    End If

                    updateNumLEDs()

                    rowsTall = Val(txtNumTLCRows.Text) * Val(txtNumRows.Text)


                End If

            End If

        End If

    End Sub

    Private Sub txtNumChannels_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim numChannels As Byte = 0

        If txtNumChannels.Text <> "" Then
            numChannels = Integer.Parse(txtNumChannels.Text)
        End If

        If numChannels > 0 And numChannels < 17 Then

            If SerialPort1.IsOpen Then

                SerialPort1.Write("sc")
                SerialPort1.Write(Chr(numChannels))

                'txtSerial.AppendText("SENT sc: " & numChannels & vbCrLf)


            End If

            updateNumColumns()
            updateNumLEDs()

        End If

    End Sub

    Private Sub txtChannelsPerLED_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim channelsPerLED As Byte = 0

        If txtNumChannelsPerLED.Text <> "" Then
            channelsPerLED = Integer.Parse(txtNumChannelsPerLED.Text)
        End If

        If channelsPerLED > 0 And channelsPerLED < 17 Then

            If SerialPort1.IsOpen Then

                SerialPort1.Write("sp")
                SerialPort1.Write(Chr(channelsPerLED))

                'txtSerial.AppendText("SENT sp: " & channelsPerLED.ToString & vbCrLf)


            End If

            updateNumColumns()

        End If



    End Sub

    Private Sub txtNumTLCs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim newTLCs As Integer


        If txtNumTLCCols.Text <> "" And txtNumTLCRows.Text <> "" Then
            newTLCs = Integer.Parse(Val(txtNumTLCRows.Text) * Val(txtNumTLCCols.Text))
        End If

        If newTLCs > 0 And newTLCs < 100 Then

            txtNumTLCs.Text = newTLCs.ToString
            txtNumRows_TextChanged(sender, e)

            If SerialPort1.IsOpen Then

                'SerialPort1.Write("st")
                'SerialPort1.Write(Chr(newTLCs))
                'txtSerial.AppendText("SENT st: " & newTLCs.ToString & vbCrLf)

                SerialPort1.Write("sl")
                SerialPort1.Write(Chr(Val(txtNumTLCCols.Text)))
                'txtSerial.AppendText("SENT sl: " & txtNumTLCCols.Text & vbCrLf)

                SerialPort1.Write("sw")
                SerialPort1.Write(Chr(Val(txtNumTLCRows.Text)))
                'txtSerial.AppendText("SENT sw: " & txtNumTLCRows.Text & vbCrLf)

            End If



            updateNumColumns()




        End If

    End Sub

    Private Sub updateNumLEDs()

        If txtMatrixCols.Text <> "" And txtNumColumns.Text <> "" Then

            pixelArray = New Bitmap(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text), Imaging.PixelFormat.Format24bppRgb)
            'pixelArrayG = Graphics.FromImage(pixelArray)

            txtNumLEDs.Text = Int(Val(txtNumRows.Text) * Val(txtNumColumns.Text) * Val(txtNumTLCs.Text))

        End If

    End Sub

    Private Sub updateNumColumns()

        If Val(txtNumChannelsPerLED.Text) > 0 And Val(txtNumChannelsPerLED.Text) < 4 Then

            txtNumColumns.Text = Int(Val(txtNumChannels.Text) / Val(txtNumChannelsPerLED.Text))

            Dim numColumns As Integer = Val(txtNumColumns.Text)
            Dim matrixColumns As Integer = Val(txtNumTLCCols.Text) * numColumns

            txtMatrixCols.Text = matrixColumns

            If numColumns > 0 And numColumns <= Val(txtNumTLCCols.Text) * 16 Then

                ' set column width for existing columns


                colsWide = Val(txtNumTLCCols.Text) * Val(txtNumColumns.Text)


                updateNumLEDs()

            End If

        End If

    End Sub

    Private Sub btnColorSolid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorSolid.Click

        'If ColorDialog1.ShowDialog() = DialogResult.OK Then
        '    TextBox1.BackColor = ColorDialog1.Color
        'End If

        'red = TextBox1.BackColor.R * 16
        'green = TextBox1.BackColor.G * 16
        'blue = TextBox1.BackColor.B * 16

        'updateColorFaders()

        colorSolid()

    End Sub




    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            stopWatch1.Start()
        Else
            stopWatch1.Stop()
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            stopWatch2.Start()
        Else
            stopWatch2.Stop()
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            stopWatch3.Start()
        Else
            stopWatch3.Stop()
        End If
    End Sub

    Private Sub selectPixel(ByVal pixel As Integer)

        Dim numTLCCols As Integer = Val(txtNumTLCCols.Text)
        Dim numTLCRows As Integer = Val(txtNumTLCRows.Text)
        Dim numTLCs As Integer = Val(txtNumTLCs.Text)
        Dim numRows As Integer = Val(txtNumRows.Text)
        Dim numColumns As Integer = Val(txtNumColumns.Text)
        Dim matrixColumns As Integer = Val(txtMatrixCols.Text)
        Dim matrixRows As Integer = Val(txtMatrixRows.Text)

        Dim numLEDsPerPanel = numRows * numColumns




        Dim whichRow As Integer = Int(pixel / matrixColumns)
        Dim whichColumn As Integer = pixel Mod matrixColumns

        Dim whichTLCRow As Integer = Int(whichRow / numRows)
        Dim whichTLCCol As Integer = Int(whichColumn / numColumns)

        'lblPxl.Text = "Pixel#: " & pixel
        'lblI.Text = "I: " & whichTLCCol
        'lblJ.Text = "J: " & whichTLCRow


        Dim tlc As Integer = (whichTLCRow * numTLCCols) + whichTLCCol
        'lblTLC.Text = "TLC#: " & tlc

        Dim tlcOffset As Integer = tlc * numLEDsPerPanel

        whichRow = whichRow - (whichTLCRow * numRows)

        Dim anotherOffset = pixel - (whichRow * matrixColumns) + (whichTLCCol * numColumns)

        'whichRow = pixel
        'lblY.Text = "Y: " & whichRow

        whichColumn = pixel Mod numColumns
        'lblX.Text = "X: " & whichColumn

        Dim pixelOffset = (whichRow * numColumns) + whichColumn
        Dim totalOffset = tlcOffset + pixelOffset

        'lblArrayIndex.Text = "pixelArray Index: " & tlcOffset + pixelOffset

        'MessageBox.Show("TLC offset: " & tlcOffset & " Pixel Offset: " & pixelOffset & " pixel address: " & tlcOffset + pixelOffset)


        'Dim hexPixel As String = Hex(totalOffset).PadLeft(2, "0")
        Dim byteArray(2) As Byte

        byteArray = BitConverter.GetBytes(totalOffset)


        'For i = 0 To 1

        '    'byteArray(i) = Integer.Parse(hexPixel(i), Globalization.NumberStyles.HexNumber)
        '    byteArray = BitConverter.GetBytes(totalOffset)



        'Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("p")
            SerialPort1.Write(byteArray, 0, 2)

            'txtSerial.AppendText("SENT p: " & totalOffset & " " & byteArray.ToString & vbCrLf)

        End If

    End Sub

    Private Sub pixelOn()

        If SerialPort1.IsOpen Then

            SerialPort1.Write("o")

            'txtSerial.AppendText("SENT o" & vbCrLf)

        End If

    End Sub

    Private Sub pixelOff()

        If SerialPort1.IsOpen Then

            SerialPort1.Write("f")
            'txtSerial.AppendText("SENT f" & vbCrLf)

        End If

    End Sub

    Private Sub txtOffDelayMs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRowOff.TextChanged

        Dim hexOffDelayMs As String = Hex(Val(txtRowOff.Text)).PadLeft(4, "0")
        Dim byteArray(4) As Byte

        For i = 0 To 3

            byteArray(i) = Integer.Parse(hexOffDelayMs(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("e")
            SerialPort1.Write(byteArray, 0, 4)

            'txtSerial.AppendText("SENT e: " & hexOffDelayMs & vbCrLf)

        End If

    End Sub

    Private Sub chkFlipVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SerialPort1.Write("v")

        'txtSerial.AppendText("SENT v: " & chkFlipVertical.Checked.ToString & vbCrLf)

    End Sub

    Private Sub chkFlipHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SerialPort1.Write("h")

        'txtSerial.AppendText("SENT h: " & chkFlipHorizontal.Checked.ToString & vbCrLf)


    End Sub


    Private Sub btnSayIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSayIt.Click

        If txtSayIt.Text.Length > 0 Then

            Dim matrixColumns As Integer = Val(txtMatrixCols.Text)
            Dim matrixRows As Integer = Val(txtMatrixRows.Text)
            Dim verticalFontAdjust = Val(udVerticalFontAdjust.Text)

            Dim color As Color
            Dim farRightCol As Integer = Val(txtMatrixCols.Text) - 1

            Dim alphaBlack As Color = color.FromArgb(255, 0, 0, 0)


            Dim labelWidthTest As New Label

            labelWidthTest.Visible = False

            labelWidthTest.Font = scrollingFont
            labelWidthTest.MinimumSize = New System.Drawing.Size(1, 1)
            labelWidthTest.AutoSize = True
            labelWidthTest.Text = "W"

            Me.Controls.Add(labelWidthTest)

            Dim widestLetter = labelWidthTest.Width + 1

            'txtSerial.AppendText("widest letter: " & widestLetter.ToString & vbCrLf)
            'txtSerial.AppendText("matrixTall: " & matrixTall.ToString & vbCrLf)

            solidBrush = New SolidBrush(txtFontName.ForeColor)

            Dim messageBitmap As Bitmap = New Bitmap((widestLetter * txtSayIt.Text.Length), matrixRows + 10, Imaging.PixelFormat.Format24bppRgb)

            Dim messageBitmapG As Graphics = Graphics.FromImage(messageBitmap)

            messageBitmapG.DrawString(txtSayIt.Text, scrollingFont, solidBrush, 0, verticalFontAdjust)

            pbSayIt.Width = messageBitmapG.MeasureString(txtSayIt.Text, scrollingFont).Width + 10
            pbSayIt.Height = messageBitmapG.MeasureString(txtSayIt.Text, scrollingFont).Height


            pbSayIt.BackgroundImage = messageBitmap


            'Dim matrixSize As New Size(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text))

            'Dim rectangle As Rectangle = New Rectangle(-2, -2, Val(txtMatrixCols.Text) + 2, Val(txtMatrixRows.Text) + 2)

            'Dim croppedMessageBitmap As Bitmap = New Bitmap(messageBitmap,

            ' copy messagebitmap to pixelArray bitmap

            Dim sourceRectangle As New Rectangle



            Dim targetRectangle As New Rectangle(0, 0, matrixColumns, matrixRows)


            For column = 0 To pbSayIt.Width - 1

                '' this works, but it's very very slow

                'sourceRectangle = New Rectangle(horizontalFontAdjust + i, verticalFontAdjust, matrixColumns, matrixRows)

                'pixelArrayG.Clear(Color.Black)

                'pixelArrayG.DrawImage(messageBitmap, targetRectangle, sourceRectangle, GraphicsUnit.Pixel)

                'pbPixelArray.Refresh()

                'sendFrame()


                ' if you have a shift left routing on the MCU then you can just send a little data per frame and shift left

                For row As Integer = 0 To Val(txtMatrixRows.Text) - 1

                    ' for each row, copy the current column iteration from pixelarray to the last column of the matrix

                    color = messageBitmap.GetPixel(column, row)

                    If color = alphaBlack Then

                        '' update the datagridview
                        'dgLEDMatrix.Item(farRightCol, row).Style.BackColor = color.Black
                        'dgLEDMatrix.Item(farRightCol, row).Style.SelectionBackColor = color.Black

                        ' update the pixelArray bitmap
                        'pixelArray.SetPixel(farRightCol, row, color.Black)
                        'pbPixelArray.Refresh()

                        drawPixel(farRightCol, row, color)

                    Else

                        'MessageBox.Show(color.ToString)
                        drawPixel(farRightCol, row, color)

                    End If

                Next

                ' sleep for a speed delay
                'System.Threading.Thread.Sleep(10)

                ' now shift hard left!

                'Threading.Thread.Sleep(25)

                btnShiftLeft_Click(sender, e)

                pixelArrayG.DrawImage(pixelArray, -1, 0)

                ' pixelArrayG.DrawImage(messageBitmap, column * -1, 0, messageBitmap.Width, messageBitmap.Height)



            Next






        End If


    End Sub

    Private Sub btnChooseFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFont.Click


        FontDialog1.ShowColor = False
        FontDialog1.MinSize = 1
        FontDialog1.MaxSize = rowsTall + 5


        FontDialog1.ShowDialog()

        scrollingFont = FontDialog1.Font

        red = TextBox1.BackColor.R
        green = TextBox1.BackColor.G
        blue = TextBox1.BackColor.B


        txtFontName.Font = scrollingFont
        txtFontName.ForeColor = Color.FromArgb(red, green, blue)
        txtFontName.Text = scrollingFont.Name

        txtSayIt.Font = scrollingFont
        txtSayIt.ForeColor = txtFontName.ForeColor

        'txtSerial.AppendText("set font: " & scrollingFont.Name & vbCrLf)
        'txtSerial.AppendText("size: " & FontDialog1.Font.Size & vbCrLf)
        'txtSerial.AppendText("c: " & red & " " & green & " " & blue & vbCrLf)

    End Sub


    Private Sub dgLEDMatrix_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)

        'Dim selectedRow As Integer = sender. 'dgLEDMatrix.SelectedCells.Item(0).RowIndex
        'Dim selectedColumn As Integer = 'dgLEDMatrix.SelectedCells.Item(0).ColumnIndex

        'Dim pixel As Byte = selectedRow * Val(txtNumColumns.Text) + selectedColumn

        'red = TextBox1.BackColor.R
        'green = TextBox1.BackColor.G
        'blue = TextBox1.BackColor.B

        'dgLEDMatrix.SelectedCells.Item(0).Style.BackColor = Color.FromArgb(Int(red), Int(green), Int(blue))

        'dgLEDMatrix.SelectedCells.Item(0).Style.SelectionBackColor = Color.FromArgb(Int(red), Int(green), Int(blue))

        'selectPixel(pixel)
        'pixelOn()



    End Sub

    Private Sub drawPixel(ByVal x As Integer, ByVal y As Integer, ByVal color As Color)

        If (x >= 0) And (x < pixelArray.Width) And (y >= 0) And (y < pixelArray.Height) Then

            'txtSerial.AppendText(color.R & " " & color.G & " " & color.B & vbCrLf)

            '' update the datagridview
            'dgLEDMatrix.Item(x, y).Style.BackColor = color
            'dgLEDMatrix.Item(x, y).Style.SelectionBackColor = color

            ' update the pixelArray bitmap
            pixelArray.SetPixel(x, y, color)
            pbPixelArray.Refresh()
            'pbPixelArray.Refresh()

            ' send pixel on to the array
            ' not that easy here either
            Dim pixel As Integer = y * Val(txtMatrixCols.Text) + x


            selectPixel(pixel)

            If color <> lastColor Then

                red = color.R
                green = color.G
                blue = color.B

                sendColor()

            End If

            pixelOn()

            lastColor = color

        End If


    End Sub

    Private Sub sendFrame()

        Dim tlcCols As Integer = Val(txtNumTLCCols.Text)
        Dim tlcRows As Integer = Val(txtNumTLCRows.Text)
        Dim numRows As Integer = Val(txtNumRows.Text)
        Dim numColumns As Integer = Val(txtNumColumns.Text)
        Dim matrixColums As Integer = Val(txtMatrixCols.Text)
        Dim matrixRows As Integer = Val(txtMatrixRows.Text)

        If SerialPort1.IsOpen Then

            ' indicate that a frame transfer is about to start
            SerialPort1.Write("m")

            For i = 0 To tlcRows - 1

                For j = 0 To tlcCols - 1

                    For y As Integer = 0 To numRows - 1

                        For x As Integer = 0 To numColumns - 1

                            '        'Dim pixelOffset As Integer = i * matrixColums

                            'Dim pixel = (y * matrixColums) + x

                            'Dim whichTLCRow As Integer = Int((pixel / matrixColums) / numRows)
                            'Dim whichTLCCol As Integer = Int((pixel - (matrixColums * whichTLCRow * numRows)) / matrixColums)

                            Dim bitmapX As Integer = (j * numColumns) + x
                            Dim bitmapY As Integer = (i * numRows) + y

                            Dim color As Color = pixelArray.GetPixel(bitmapX, bitmapY)

                            '        'red = color.R
                            '        'green = color.G
                            '        'blue = color.B

                            Dim redByte(1) As Byte
                            Dim greenByte(1) As Byte
                            Dim blueByte(1) As Byte

                            redByte(0) = color.R
                            greenByte(0) = color.G
                            blueByte(0) = color.B

                            SerialPort1.Write(redByte, 0, 1)
                            SerialPort1.Write(greenByte, 0, 1)
                            SerialPort1.Write(blueByte, 0, 1)

                            '        'txtSerial.AppendText("SENT f: " & pixel & " " & red & " " & green & " " & blue & vbCrLf)
                            '        'sendColor()
                            '        'selectPixel(pixel)
                            '        'pixelOn()

                        Next

                    Next

                Next

            Next

        End If


    End Sub

    Private Sub sendColor()

        If SerialPort1.IsOpen Then

            Dim redByte(1) As Byte
            Dim greenByte(1) As Byte
            Dim blueByte(1) As Byte

            redByte(0) = red
            greenByte(0) = green
            blueByte(0) = blue

            SerialPort1.Write("c") ' specify a 3 byte color
            SerialPort1.Write(redByte, 0, 1)
            SerialPort1.Write(greenByte, 0, 1)
            SerialPort1.Write(blueByte, 0, 1)
            'txtSerial.AppendText("SENT c: " & red & " " & green & " " & blue & vbCrLf)

        End If

    End Sub

    Private Sub btnSendFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendFrame.Click

        sendFrame()

    End Sub

    Private Sub btnShiftLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShiftLeft.Click

        If SerialPort1.IsOpen Then

            SerialPort1.Write("k")

            'txtSerial.AppendText("SENT k: shift left" & vbCrLf)

        End If

        Dim pixelArrayShifted As Bitmap = pixelArray.Clone


    End Sub

    Private Sub cbDebugMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebugMode.CheckedChanged

        If SerialPort1.IsOpen Then

            SerialPort1.Write("w")

            'txtSerial.AppendText("SENT w: debug toggle" & vbCrLf)

        End If


    End Sub

    Private Sub txtSlowDown_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSlowDown.TextChanged

        Dim slowDown As String = Hex(Val(txtSlowDown.Text)).PadLeft(4, "0")
        Dim byteArray(4) As Byte

        For i = 0 To 3

            byteArray(i) = Integer.Parse(slowDown(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("x")
            SerialPort1.Write(byteArray, 0, 4)

            'txtSerial.AppendText("SENT x: " & slowDown & vbCrLf)

        End If


    End Sub



    Private Sub btnDump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDump.Click

        If SerialPort1.IsOpen Then

            SerialPort1.Write("y")

        End If

        'txtSerial.AppendText("SENT y: dump pixelArray" & vbCrLf)

    End Sub


    Private Sub cbFlipTLCVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If SerialPort1.IsOpen Then

            SerialPort1.Write("@")

        End If

        'txtSerial.AppendText("SENT @: flip TLC mapping vertically" & vbCrLf)

    End Sub


    Private Sub cbFlipTLCHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If SerialPort1.IsOpen Then

            SerialPort1.Write("!")

        End If

        'txtSerial.AppendText("SENT !: flip TLC mapping horizontally" & vbCrLf)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim newImage As Bitmap = Bitmap.FromFile(OpenFileDialog1.FileName)
            pixelArrayG.DrawImage(newImage, 0, 0, pixelArray.Width, pixelArray.Height)
            pbPixelArray.Refresh()

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        ' save bitmap
        Dim fileSave As New SaveFileDialog

        fileSave.InitialDirectory = "C:\MoodMachine\"

        If fileSave.ShowDialog = Windows.Forms.DialogResult.OK Then

            pixelArray.Save(fileSave.FileName, System.Drawing.Imaging.ImageFormat.Gif)

        End If

    End Sub



    Private Sub pbPixelArray_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPixelArray.MouseDown

        isDrag = True
        drawPixel((e.X / pbPixelArray.Width) * (pixelArray.Width - 1), (e.Y / pbPixelArray.Height) * (pixelArray.Height - 1), TextBox1.BackColor)
        pbPixelArray.Refresh()

    End Sub


    Private Sub pbPixelArray_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPixelArray.MouseMove

        If isDrag Then

            drawPixel((e.X / pbPixelArray.Width) * pixelArray.Width, (e.Y / pbPixelArray.Height) * pixelArray.Height, TextBox1.BackColor)
            pbPixelArray.Refresh()

        End If

    End Sub

    Private Sub pbPixelArray_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPixelArray.MouseUp

        isDrag = False

    End Sub


    Private Sub btnFlashbulbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlashbulbs.Click

        Dim matrixColums As Integer = Val(txtMatrixCols.Text)
        Dim matrixRows As Integer = Val(txtMatrixRows.Text)
        Dim rnd As New Random

        ' clear the matrix

        'red = 0
        'green = 0
        'blue = 0

        'colorSolid()

        ' set the on and off delays to long off, short on

        txtRowOn.Text = "500"
        txtRowOff.Text = "4095"

        'red = 255
        'green = 255
        'blue = 255

        'sendColor()

        '' pick some random LEDs to light up (let's say 10% of em)

        For tlcrows As Integer = 0 To matrixRows

            For tlcCols As Integer = 0 To matrixColums

                If Int(rnd.Next(10)) < 3 Then

                    drawPixel(tlcCols, tlcrows, Color.White)

                Else

                    drawPixel(tlcCols, tlcrows, Color.Black)

                End If

            Next

        Next


        'For i = 0 To Val(txtNumLEDs.Text) - 1

        '    Dim rnd As New Random

        '    If rnd.Next(10) = 1 Then

        '        selectPixel(i)

        '        red = 255
        '        green = 255
        '        blue = 255

        '        sendColor()

        '        pixelOn()


        '    End If

        ' next


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Dim color = PictureBox1.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Dim color = PictureBox2.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim color = PictureBox3.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim color = PictureBox4.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim color = PictureBox5.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Dim color = PictureBox6.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim color = PictureBox7.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Dim color = PictureBox8.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Dim color = PictureBox9.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Dim color = PictureBox10.BackColor

        red = color.R
        green = color.G
        blue = color.B

        colorSolid()
    End Sub


    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, TextBox1.KeyDown
        'MessageBox.Show(e.KeyValue)


        Select Case e.KeyValue

            Case Keys.F1
                PictureBox1_Click(sender, e)
            Case Keys.F2
                PictureBox2_Click(sender, e)
            Case Keys.F3
                PictureBox3_Click(sender, e)
            Case Keys.F4
                PictureBox4_Click(sender, e)
            Case Keys.F5
                PictureBox5_Click(sender, e)
            Case Keys.F6
                PictureBox6_Click(sender, e)
            Case Keys.F7
                PictureBox7_Click(sender, e)
            Case Keys.F8
                PictureBox8_Click(sender, e)
            Case Keys.F9
                PictureBox9_Click(sender, e)
            Case Keys.F10
                PictureBox10_Click(sender, e)
            Case Keys.F11
                PulseWave()
            Case Keys.F12
                Strobe()

        End Select
    End Sub


    Private Sub cbAA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAA.CheckedChanged

        If cbAA.Checked Then

            'pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor

            pixelArrayG.SmoothingMode = Drawing2D.SmoothingMode.None

            pbPixelArray.BackgroundImage = pixelArray
            pbPixelArray.Refresh()

        Else

            'pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear

            pixelArrayG.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            pbPixelArray.BackgroundImage = pixelArray
            pbPixelArray.Refresh()

        End If

    End Sub

    Private Sub PulseWave()

        txtRowOn.Text = "52"
        txtRowOff.Text = "50"

    End Sub

    Private Sub Strobe()

        txtRowOn.Text = "300"
        txtRowOff.Text = "3500"

    End Sub


    Private Sub udVerticalFontAdjust_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udVerticalFontAdjust.SelectedItemChanged

    End Sub

    Private Sub tbRowOn_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRowOn.Scroll


        txtRowOn.Text = tbRowOn.Value

    End Sub

    Private Sub tbRowOff_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRowOff.Scroll

        txtRowOff.Text = tbRowOff.Value

    End Sub

    Private Sub cbPlay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPlay.CheckedChanged, cbVis1.CheckedChanged


        If cbPlay.Checked Then

            Bass.BASS_Start()

        Else

            Bass.BASS_Pause()

        End If

    End Sub



    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        ReleaseDC(pbPixelArray.Handle, hVisDC)

    End Sub

    Private Sub sendFrameDelta()

        frameDeltaTimer.Restart()

        Dim frameDelta As New ArrayList
        Dim colorPixel As String
        Dim bytesPerFrame As Integer = 0

        ' iterate through every pixel, 

        For i = 0 To pixelArray.Width - 1

            For j = 0 To pixelArray.Height - 1

                Dim pixelNum As Integer = j * Val(txtMatrixCols.Text) + i
                Dim pixelColor = pixelArray.GetPixel(i, j)

                ' compare to pixel in last frame
                If pixelColor <> lastFrame.GetPixel(i, j) Then

                    ' pixel is different in this frame than the last
                    ' add it to the arraylist

                    colorPixel = pixelColor.R & "," & pixelColor.G & "," & pixelColor.B & "," & pixelNum

                    frameDelta.Add(colorPixel)

                End If

            Next

        Next

        ' sorting by color minimizes the color change messages
        frameDelta.Sort()

        ' now send the appropriate drawpixels/color changes

        ' iterate through the arraylist
        For i = 0 To frameDelta.Count - 1

            ' parse the items
            colorPixel = frameDelta(i)

            Dim pixelData() As String = colorPixel.Split(",")

            If red <> pixelData(0) Then

                ' red changed, send color change
                red = pixelData(0)

                Dim redByte(1) As Byte
                redByte(0) = red

                If SerialPort1.IsOpen Then

                    SerialPort1.Write("r")
                    SerialPort1.Write(redByte, 0, 1)

                End If

                bytesPerFrame += 2



            End If

            If green <> pixelData(1) Then

                ' green changed, send color change
                green = pixelData(1)

                Dim greenByte(1) As Byte
                greenByte(0) = red

                If SerialPort1.IsOpen Then

                    SerialPort1.Write("g")
                    SerialPort1.Write(greenByte, 0, 1)

                End If


                bytesPerFrame += 2


            End If

            If blue <> pixelData(2) Then

                ' blue changed, send color change
                blue = pixelData(2)

                Dim blueByte(1) As Byte
                blueByte(0) = red

                If SerialPort1.IsOpen Then

                    SerialPort1.Write("b")
                    SerialPort1.Write(blueByte, 0, 1)

                End If

                bytesPerFrame += 2

            End If

            ' color should be right, send pixel on
            selectPixel(pixelData(3))

            bytesPerFrame += 3

            pixelOn()

            bytesPerFrame += 1

        Next

        ' copy the current frame to lastFrame
        lastFrame = pixelArray.Clone

        ' clear frameDelta array
        frameDelta.Clear()

        'Dim frameRate As Single = frameDeltaTimer.ElapsedMilliseconds

        'If bytesPerFrame > maxBytesPerFrame Then

        '    maxBytesPerFrame = bytesPerFrame

        '    lblMaxBytesPerFrame.Text = "Max Bytes Per Frame: " & maxBytesPerFrame

        'End If
        
        
        If movingAverageCount > 99 Then movingAverageCount = 0

        movingAverageList(movingAverageCount) = bytesPerFrame

        lblAvgBytesPerFrame.Text = "Avg Bytes Per Frame: " & movingAverageList.Average

        lblBytesPerFrame.Text = "Bytes Per Frame: " & bytesPerFrame & " ms: " & frameDeltaTimer.ElapsedMilliseconds.ToString

        movingAverageCount += 1
        bytesPerFrame = 0

    End Sub


End Class
