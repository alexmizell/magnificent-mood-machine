Public Class frmMain



    Dim stopWatch1 As New Stopwatch
    Dim stopWatch2 As New Stopwatch
    Dim stopWatch3 As New Stopwatch

    Dim red As Byte = 0
    Dim green As Byte = 0
    Dim blue As Byte = 0

    Dim scrollingFont As Font
    Dim rowsTall As Integer
    Dim colsWide As Integer

    Dim pixelArray As Bitmap
    Dim pixelArrayG As Graphics

    'Dim offScreen As Bitmap
    'Dim offScreenG As Graphics

    Dim solidBrush As SolidBrush


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'stopWatch1.Start()

        SerialPort1.Open()

        ' too-simple test with no timeout 
        ' for determining whether we're connected to the MCU
        ' slams the CPU, bad code, bad!

        'SerialPort1.Write("t") ' Send reset

        While SerialPort1.BytesToRead < 1
        End While

        cbCOM.Checked = True

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



        dgLEDMatrix.DefaultCellStyle.BackColor = Color.Black
        dgLEDMatrix.DefaultCellStyle.SelectionBackColor = Color.Black

        'updateColorFaders()


        ' Add columns to the datagridview
        ' This only adds them, they are futher adjusted by the txtNumColumns changed event

        'For i = 1 To Integer.Parse(txtNumColumns.Text)

        '    Dim newColumn As New System.Windows.Forms.DataGridViewButtonColumn

        '    dgLEDMatrix.Columns.Add(newColumn)

        'Next


        ' Add rows to the data grid view
        For i = 1 To Integer.Parse(txtNumRows.Text)
            dgLEDMatrix.Rows.Add()
        Next


        ' Begin scrolling text code

        Dim matrixTall As Integer = Val(txtNumTLCRows.Text) * Val(txtNumRows.Text)
        'Dim widestLetter As Integer

        scrollingFont = New Font("Century Gothic", 10, FontStyle.Regular, GraphicsUnit.Pixel)
        'scrollingFont = txtFontName.Font


        txtFontName.ForeColor = Color.FromArgb(0, 255, 0)
        txtFontName.Text = scrollingFont.Name

        txtSayIt.Font = scrollingFont
        txtSayIt.ForeColor = txtFontName.ForeColor



        'pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor

        pixelArray = New Bitmap(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text), Imaging.PixelFormat.Format24bppRgb)
        pixelArrayG = Graphics.FromImage(pixelArray)
        pixelArrayG.InterpolationMode = Drawing2D.InterpolationMode.Low

        'offScreen = New Bitmap(widestLetter, matrixTall + 5, Imaging.PixelFormat.Format24bppRgb)
        'offScreenG = Graphics.FromImage(offScreen)

        'offScreenG.TransformPoints(

        'pbOffscreen.BackgroundImageLayout = ImageLayout.Stretch
        'pbOffscreen.BackgroundImage = offScreen

        pbPixelArray.BackgroundImageLayout = ImageLayout.Stretch
        pbPixelArray.BackgroundImage = pixelArray
        pbPixelArray.Refresh()



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


        updateColorText()

    End Sub

    Private Sub btnPickColor_Click(ByVal sender As  _
        System.Object, _
     ByVal e As System.EventArgs) Handles btnPickColor.Click, TextBox1.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = ColorDialog1.Color
        End If

        updateColorFaders()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If cbCOM.Checked Then

            pbSerialIn.Value = SerialPort1.BytesToRead
            pbSerialOut.Value = SerialPort1.BytesToWrite
            pbSerialIn.Update()
            pbSerialOut.Update()

            Dim SerialInput As String = ""

            If SerialPort1.IsOpen Then
                While SerialPort1.BytesToRead > 0


                    SerialInput = SerialInput & Chr(SerialPort1.ReadChar)

                End While

                'txtSerial.Text = txtSerial.Text & SerialInput.ToString

                txtSerial.AppendText(SerialInput)

            End If
        End If

    End Sub

    Private Sub btnRainbow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRainbow.Click

        Dim sleeptime = hsSinFreqDiv.Value / 25

        For i = 1 To 20

            red = 255
            green = 0
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 128
            green = 255
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 255
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 255
            blue = 255

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 0
            blue = 255

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 128
            green = 0
            blue = 255

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

        Next

        red = 0
        green = 0
        blue = 0

        colorSolid()

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

        For Each row As DataGridViewRow In dgLEDMatrix.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Style.BackColor = Color.FromArgb(Int(red), Int(green), Int(blue))
                cell.Style.SelectionBackColor = Color.FromArgb(Int(red), Int(green), Int(blue))
            Next
        Next

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
            txtSerial.AppendText("SENT c: " & red & " " & green & " " & blue & vbCrLf)

            SerialPort1.Write("a") ' execute the color all command
            txtSerial.AppendText("SENT a" & vbCrLf)

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
                txtSerial.AppendText("SENT r: " & red & vbCrLf)

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
                txtSerial.AppendText("SENT g: " & green & vbCrLf)

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
                txtSerial.AppendText("SENT b: " & blue & vbCrLf)

                'SerialPort1.Write("a") ' execute the color all command
                'txtSerial.AppendText("SENT a" & vbCrLf)

            End If
        End If

        updateColorText()
        updateTextBox()

    End Sub

    Private Sub cbCOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCOM.Click

        If SerialPort1.IsOpen Then

            SerialPort1.Close()
            cbCOM.Checked = False

        Else

            SerialPort1.Open()
            cbCOM.Checked = True

        End If

    End Sub

    Private Sub txtRowOnDelayMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRowOnDelayMS.TextChanged

        Dim hexOnDelayMs As String = Hex(Val(txtRowOnDelayMS.Text)).PadLeft(4, "0")
        Dim byteArray(4) As Byte

        For i = 0 To 3

            byteArray(i) = Integer.Parse(hexOnDelayMs(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("d")
            SerialPort1.Write(byteArray, 0, 4)

            txtSerial.AppendText("SENT d: " & hexOnDelayMs & vbCrLf)

        End If

    End Sub

    Private Sub txtNumRows_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRows.TextChanged

        Dim numRows As Byte = 0
        Dim matrixRows As Integer = 0


        If txtNumRows.Text <> "" Then
            numRows = Integer.Parse(txtNumRows.Text)

            If numRows > 0 And numRows < 9 Then

                If Val(txtNumTLCRows.Text) > 0 And Val(txtNumTLCRows.Text) < 17 Then

                    matrixRows = numRows * Val(txtNumTLCRows.Text)

                    txtMatrixRows.Text = matrixRows

                    ' set row height for existing rows
                    For Each rowHeight As DataGridViewRow In dgLEDMatrix.Rows
                        rowHeight.Height = Int(dgLEDMatrix.Height / matrixRows)
                    Next

                    If dgLEDMatrix.Rows.Count < matrixRows Then

                        ' set row height for new rows
                        dgLEDMatrix.RowTemplate.Height = Int(dgLEDMatrix.Height / matrixRows)

                        ' add rows
                        For i = 1 To (matrixRows - dgLEDMatrix.Rows.Count)
                            dgLEDMatrix.Rows.Add()
                            'dgLEDMatrix.Rows(i).Height = Int(dgLEDMatrix.Height / matrixRows)
                        Next


                        dgLEDMatrix.Update()

                    End If





                    If dgLEDMatrix.Rows.Count > matrixRows Then

                        ' delete rows
                        For i = 1 To dgLEDMatrix.Rows.Count - matrixRows
                            dgLEDMatrix.Rows.RemoveAt(dgLEDMatrix.Rows.Count - 2)
                        Next

                    End If

                    If SerialPort1.IsOpen Then

                        SerialPort1.Write("sr")
                        SerialPort1.Write(Chr(numRows))

                        txtSerial.AppendText("SENT sr: " & numRows.ToString & vbCrLf)

                    End If

                    updateNumLEDs()

                    rowsTall = Val(txtNumTLCRows.Text) * Val(txtNumRows.Text)


                End If

            End If

        End If

    End Sub

    Private Sub txtNumChannels_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumChannels.TextChanged

        Dim numChannels As Byte = 0

        If txtNumChannels.Text <> "" Then
            numChannels = Integer.Parse(txtNumChannels.Text)
        End If

        If numChannels > 0 And numChannels < 17 Then

            If SerialPort1.IsOpen Then

                SerialPort1.Write("sc")
                SerialPort1.Write(Chr(numChannels))

                txtSerial.AppendText("SENT sc: " & numChannels & vbCrLf)


            End If

            updateNumColumns()
            updateNumLEDs()

        End If

    End Sub

    Private Sub txtChannelsPerLED_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumChannelsPerLED.TextChanged

        Dim channelsPerLED As Byte = 0

        If txtNumChannelsPerLED.Text <> "" Then
            channelsPerLED = Integer.Parse(txtNumChannelsPerLED.Text)
        End If

        If channelsPerLED > 0 And channelsPerLED < 17 Then

            If SerialPort1.IsOpen Then

                SerialPort1.Write("sp")
                SerialPort1.Write(Chr(channelsPerLED))

                txtSerial.AppendText("SENT sp: " & channelsPerLED.ToString & vbCrLf)


            End If

            updateNumColumns()

        End If



    End Sub

    Private Sub txtNumTLCs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTLCRows.TextChanged, txtMatrixRows.TextChanged, txtNumTLCCols.TextChanged, txtMatrixCols.TextChanged

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
                txtSerial.AppendText("SENT sl: " & txtNumTLCCols.Text & vbCrLf)

                SerialPort1.Write("sw")
                SerialPort1.Write(Chr(Val(txtNumTLCRows.Text)))
                txtSerial.AppendText("SENT sw: " & txtNumTLCRows.Text & vbCrLf)

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

                For Each colWidth As System.Windows.Forms.DataGridViewColumn In dgLEDMatrix.Columns

                    colWidth.Width = dgLEDMatrix.Width / matrixColumns

                Next

                If dgLEDMatrix.Columns.Count < matrixColumns Then

                    ' add columns
                    For i = 1 To (matrixColumns - dgLEDMatrix.Columns.Count)
                        dgLEDMatrix.Columns.Add("Column" & dgLEDMatrix.Columns.Count + i, "Column" & dgLEDMatrix.Columns.Count + i)
                    Next

                    dgLEDMatrix.Update()

                End If

                If dgLEDMatrix.Columns.Count > matrixColumns Then

                    ' delete columns
                    For i = 1 To dgLEDMatrix.Columns.Count - numColumns
                        dgLEDMatrix.Columns.RemoveAt(dgLEDMatrix.Columns.Count - 1)
                    Next
                End If

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


    Private Sub dgLEDMatrix_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLEDMatrix.CellClick

        Dim selectedRow As Integer = dgLEDMatrix.SelectedCells.Item(0).RowIndex
        Dim selectedColumn As Integer = dgLEDMatrix.SelectedCells.Item(0).ColumnIndex

        ' it's not that simple - you have to figure in TLC cols and row
        '
        Dim pixel As Integer = selectedRow * Val(txtMatrixCols.Text) + selectedColumn

        red = TextBox1.BackColor.R
        green = TextBox1.BackColor.G
        blue = TextBox1.BackColor.B

        dgLEDMatrix.SelectedCells.Item(0).Style.BackColor = Color.FromArgb(Int(red), Int(green), Int(blue))

        dgLEDMatrix.SelectedCells.Item(0).Style.SelectionBackColor = Color.FromArgb(Int(red), Int(green), Int(blue))

        pixelArray.SetPixel(selectedColumn, selectedRow, Color.FromArgb(red, green, blue))
        pbPixelArray.Refresh()

        selectPixel(pixel)
        pixelOn()

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

        lblPxl.Text = "Pixel#: " & pixel
        lblI.Text = "I: " & whichTLCCol
        lblJ.Text = "J: " & whichTLCRow


        Dim tlc As Integer = (whichTLCRow * numTLCCols) + whichTLCCol
        lblTLC.Text = "TLC#: " & tlc

        Dim tlcOffset As Integer = tlc * numLEDsPerPanel

        whichRow = whichRow - (whichTLCRow * numRows)

        Dim anotherOffset = pixel - (whichRow * matrixColumns) + (whichTLCCol * numColumns)

        'whichRow = pixel
        lblY.Text = "Y: " & whichRow

        whichColumn = pixel Mod numColumns
        lblX.Text = "X: " & whichColumn

        Dim pixelOffset = (whichRow * numColumns) + whichColumn
        Dim totalOffset = tlcOffset + pixelOffset

        lblArrayIndex.Text = "pixelArray Index: " & tlcOffset + pixelOffset

        'MessageBox.Show("TLC offset: " & tlcOffset & " Pixel Offset: " & pixelOffset & " pixel address: " & tlcOffset + pixelOffset)


        Dim hexPixel As String = Hex(totalOffset).PadLeft(2, "0")
        Dim byteArray(2) As Byte

        For i = 0 To 1

            byteArray(i) = Integer.Parse(hexPixel(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("p")
            SerialPort1.Write(byteArray, 0, 2)

            txtSerial.AppendText("SENT p: " & totalOffset & vbCrLf)

        End If

    End Sub

    Private Sub pixelOn()

        If SerialPort1.IsOpen Then

            SerialPort1.Write("o")

            txtSerial.AppendText("SENT o" & vbCrLf)

        End If

    End Sub

    Private Sub pixelOff()

        If SerialPort1.IsOpen Then

            SerialPort1.Write("f")
            txtSerial.AppendText("SENT f" & vbCrLf)

        End If

    End Sub

    Private Sub txtOffDelayMs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffDelayMs.TextChanged

        Dim hexOffDelayMs As String = Hex(Val(txtOffDelayMs.Text)).PadLeft(4, "0")
        Dim byteArray(4) As Byte

        For i = 0 To 3

            byteArray(i) = Integer.Parse(hexOffDelayMs(i), Globalization.NumberStyles.HexNumber)

        Next

        If SerialPort1.IsOpen Then

            SerialPort1.Write("e")
            SerialPort1.Write(byteArray, 0, 4)

            txtSerial.AppendText("SENT e: " & hexOffDelayMs & vbCrLf)

        End If

    End Sub

    Private Sub chkFlipVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlipVertical.CheckedChanged

        SerialPort1.Write("v")

        txtSerial.AppendText("SENT v: " & chkFlipVertical.Checked.ToString & vbCrLf)

    End Sub

    Private Sub chkFlipHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlipHorizontal.CheckedChanged

        SerialPort1.Write("h")

        txtSerial.AppendText("SENT h: " & chkFlipHorizontal.Checked.ToString & vbCrLf)


    End Sub


    Private Sub btnSayIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSayIt.Click


        'Dim message As Char() = txtSayIt.Text

        'For Each character As Char In message


        '    ' now shift it into the pixelArray one column at a time

        '    Dim charWidth As Integer = offScreenG.MeasureString(character, scrollingFont).Width

        '    For x As Integer = 0 To charWidth

        '        ' write char into offscreen buffer

        '        offScreenG.Clear(Color.Black)
        '        solidBrush.Color = txtFontName.ForeColor
        '        offScreenG.DrawString(character, scrollingFont, solidBrush, 0, 0)
        '        pbOffscreen.Refresh()

        '        For y As Integer = 0 To rowsTall - 1

        '            ' read from the first column of the offscreen buffer
        '            ' write to the far right column of pixelArray, we are scrolling text left

        '            Dim color As Color = offScreen.GetPixel(0, y)

        '            drawPixel(colsWide - 1, y, color)

        '        Next

        '        ' transform both onscreen and offscreen bitmaps one to the left
        '        offScreenG.TranslateTransform(-1, 0)

        '        pixelArrayG.TranslateTransform(-1, 0)
        '        pixelArrayG.DrawImage(pixelArray, 0, 0)
        '        pbPixelArray.Refresh()

        '    Next

        '    offScreenG.ResetTransform()

        'Next

        If txtSayIt.Text.Length > 0 Then

            Dim matrixColumns As Integer = Val(txtMatrixCols.Text)
            Dim matrixRows As Integer = Val(txtMatrixRows.Text)
            Dim horizontalFontAdjust = Val(udHorizontalFontAdjust.Text)
            Dim verticalFontAdjust = Val(udVerticalFontAdjust.Text)


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

            Dim messageBitmap As Bitmap = New Bitmap(widestLetter * txtSayIt.Text.Length, matrixRows + 10, Imaging.PixelFormat.Format24bppRgb)

            Dim messageBitmapG As Graphics = Graphics.FromImage(messageBitmap)

            messageBitmapG.DrawString(txtSayIt.Text, scrollingFont, solidBrush, 0, 0)

            pbSayIt.Width = messageBitmapG.MeasureString(txtSayIt.Text, scrollingFont).Width
            pbSayIt.Height = messageBitmapG.MeasureString(txtSayIt.Text, scrollingFont).Height


            pbSayIt.BackgroundImage = messageBitmap


            'Dim matrixSize As New Size(Val(txtMatrixCols.Text), Val(txtMatrixRows.Text))

            'Dim rectangle As Rectangle = New Rectangle(-2, -2, Val(txtMatrixCols.Text) + 2, Val(txtMatrixRows.Text) + 2)

            'Dim croppedMessageBitmap As Bitmap = New Bitmap(messageBitmap,

            ' copy messagebitmap to pixelArray bitmap

            Dim sourceRectangle As New Rectangle



            Dim targetRectangle As New Rectangle(0, 0, matrixColumns, matrixRows)


            For i = 0 To pbSayIt.Width

                sourceRectangle = New Rectangle(horizontalFontAdjust + i, verticalFontAdjust, matrixColumns, matrixRows)

                pixelArrayG.Clear(Color.Black)

                pixelArrayG.DrawImage(messageBitmap, targetRectangle, sourceRectangle, GraphicsUnit.Pixel)

                pbPixelArray.Refresh()

                sendFrame()


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

        txtSerial.AppendText("set font: " & scrollingFont.Name & vbCrLf)
        txtSerial.AppendText("size: " & FontDialog1.Font.Size & vbCrLf)
        txtSerial.AppendText("c: " & red & " " & green & " " & blue & vbCrLf)

    End Sub


    Private Sub dgLEDMatrix_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgLEDMatrix.DragEnter

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

        txtSerial.AppendText(color.R & " " & color.G & " " & color.B & vbCrLf)

        ' update the datagridview
        dgLEDMatrix.Item(x, y).Style.BackColor = color
        dgLEDMatrix.Item(x, y).Style.SelectionBackColor = color

        ' update the pixelArray bitmap
        pixelArray.SetPixel(x, y, color)
        pbPixelArray.Refresh()

        ' send pixel on to the array
        ' not that easy here either
        Dim pixel As Integer = y * Val(txtMatrixCols.Text) + x


        selectPixel(pixel)

        red = color.R
        green = color.G
        blue = color.B

        pixelOn()

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
            txtSerial.AppendText("SENT c: " & red & " " & green & " " & blue & vbCrLf)

        End If

    End Sub

    Private Sub btnSendFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendFrame.Click

        sendFrame()

    End Sub

    Private Sub btnShiftLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShiftLeft.Click

        If SerialPort1.IsOpen Then

            SerialPort1.Write("k")

            txtSerial.AppendText("SENT k: shift left" & vbCrLf)

        End If

    End Sub

    Private Sub cbDebugMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebugMode.CheckedChanged

        If SerialPort1.IsOpen Then

            SerialPort1.Write("w")

            txtSerial.AppendText("SENT w: debug toggle" & vbCrLf)

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

            txtSerial.AppendText("SENT x: " & slowDown & vbCrLf)

        End If


    End Sub



    Private Sub btnDump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDump.Click

        If SerialPort1.IsOpen Then

            SerialPort1.Write("y")

        End If

        txtSerial.AppendText("SENT y: dump pixelArray" & vbCrLf)

    End Sub


    Private Sub cbFlipTLCVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFlipTLCVertical.CheckedChanged

        If SerialPort1.IsOpen Then

            SerialPort1.Write("@")

        End If

        txtSerial.AppendText("SENT @: flip TLC mapping vertically" & vbCrLf)

    End Sub


    Private Sub cbFlipTLCHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFlipTLCHorizontal.CheckedChanged

        If SerialPort1.IsOpen Then

            SerialPort1.Write("!")

        End If

        txtSerial.AppendText("SENT !: flip TLC mapping horizontally" & vbCrLf)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        Dim openFile As String
        openFile = OpenFileDialog1.ShowDialog()

        MessageBox.Show(openFile)


    End Sub

End Class
