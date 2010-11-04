Public Class frmMain

    Dim stopWatch1 As New Stopwatch
    Dim stopWatch2 As New Stopwatch
    Dim stopWatch3 As New Stopwatch

    Dim red As Short = 0
    Dim green As Short = 0
    Dim blue As Short = 0


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

        updateColorText()
        txtRowOnDelayMS_TextChanged(sender, e)
        txtOffDelayMs_TextChanged(sender, e)
        txtNumRows_TextChanged(sender, e)

        updateNumColumns()
        updateNumLEDs()


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

    End Sub

    Private Sub btnRainbow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRainbow.Click

        Dim sleeptime = hsSinFreqDiv.Value / 25

        For i = 1 To 20

            red = 4095
            green = 0
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 2048
            green = 4095
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 4095
            blue = 0

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 4095
            blue = 4095

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 0
            green = 0
            blue = 4095

            colorSolid()
            System.Threading.Thread.Sleep(sleeptime)

            red = 2048
            green = 0
            blue = 4095

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

        red = TextBox1.BackColor.R * 16
        green = TextBox1.BackColor.G * 16
        blue = TextBox1.BackColor.B * 16

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
            red = ((Math.Sin(stopWatch1.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 4095
        End If

        If CheckBox2.Checked Then
            green = ((Math.Sin(stopWatch2.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 4095
        End If

        If CheckBox3.Checked Then
            blue = ((Math.Sin(stopWatch3.ElapsedMilliseconds / hsSinFreqDiv.Value) + 1) / 2) * 4095
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
                cell.Style.BackColor = Color.FromArgb(Int(red / 16), Int(green / 16), Int(blue / 16))
                cell.Style.SelectionBackColor = Color.FromArgb(Int(red / 16), Int(green / 16), Int(blue / 16))
            Next
        Next

        dgLEDMatrix.Refresh()

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

            SerialPort1.Write("c") ' specify a 3 byte color
            SerialPort1.Write(red)
            SerialPort1.Write(green)
            SerialPort1.Write(blue)
            txtSerial.AppendText("SENT c: " & red & " " & green & " " & blue & vbCrLf)

            SerialPort1.Write("a") ' execute the color all command
            txtSerial.AppendText("SENT a" & vbCrLf)

        End If

        updateColorText()


        'updateTextBox()

    End Sub

    Private Sub updateTextBox()

        TextBox1.BackColor = Color.FromArgb(Int(red / 16), Int(green / 16), Int(blue / 16))

        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            colorSolid()
        End If

    End Sub

    Private Sub tbRed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRed.ValueChanged
        'coloSolidToMatrix()

        red = tbRed.Value

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then ' don't send 3 byte color changes if we are fading solids


            Dim hexRed As String = Hex(tbRed.Value).PadLeft(3, "0")
            Dim byteArray(3) As Byte

            For i = 0 To 2

                byteArray(i) = Integer.Parse(hexRed(i), Globalization.NumberStyles.HexNumber)

            Next

            If SerialPort1.IsOpen Then

                SerialPort1.Write("r")
                SerialPort1.Write(byteArray, 0, 3)
                txtSerial.AppendText("SENT r: " & hexRed & vbCrLf)

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

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then

            Dim hexGreen As String = Hex(tbGreen.Value).PadLeft(3, "0")
            Dim byteArray(3) As Byte

            For i = 0 To 2

                byteArray(i) = Integer.Parse(hexGreen(i), Globalization.NumberStyles.HexNumber)

            Next

            If SerialPort1.IsOpen Then

                SerialPort1.Write("g")
                SerialPort1.Write(byteArray, 0, 3)
                txtSerial.AppendText("SENT g: " & hexGreen & vbCrLf)

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

        If Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then

            Dim hexBlue As String = Hex(tbBlue.Value).PadLeft(3, "0")
            Dim byteArray(3) As Byte

            For i = 0 To 2

                byteArray(i) = Integer.Parse(hexBlue(i), Globalization.NumberStyles.HexNumber)

            Next

            If SerialPort1.IsOpen Then

                SerialPort1.Write("b")
                SerialPort1.Write(byteArray, 0, 3)
                txtSerial.AppendText("SENT b: " & hexBlue & vbCrLf)

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

                End If

            End If

        End If

    End Sub

    Private Sub txtNumChannels_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumChannels.TextChanged, txtNumTLCCols.TextChanged, txtMatrixCols.TextChanged

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
            updateNumLEDs()

        End If



    End Sub

    Private Sub txtNumTLCs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumTLCs.TextChanged, txtNumTLCRows.TextChanged, txtMatrixRows.TextChanged

        Dim newTLCs As Integer


        If txtNumTLCCols.Text <> "" And txtNumTLCRows.Text <> "" Then
            newTLCs = Integer.Parse(Val(txtNumTLCRows.Text) * Val(txtNumTLCCols.Text))
        End If

        If newTLCs > 0 And newTLCs < 100 Then

            txtNumTLCs.Text = newTLCs.ToString
            txtNumRows_TextChanged(sender, e)

            If SerialPort1.IsOpen Then

                SerialPort1.Write("st")
                SerialPort1.Write(Chr(newTLCs))

                txtSerial.AppendText("SENT st: " & newTLCs.ToString & vbCrLf)

            End If

        End If

    End Sub

    Private Sub updateNumLEDs()

        txtNumLEDs.Text = Int(Val(txtNumRows.Text) * Val(txtNumColumns.Text) * Val(txtNumTLCs.Text))

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

        Dim pixel As Byte = selectedRow * Val(txtNumColumns.Text) + selectedColumn

        red = TextBox1.BackColor.R * 16
        green = TextBox1.BackColor.G * 16
        blue = TextBox1.BackColor.B * 16

        dgLEDMatrix.SelectedCells.Item(0).Style.BackColor = Color.FromArgb(Int(red / 16), Int(green / 16), Int(blue / 16))

        dgLEDMatrix.SelectedCells.Item(0).Style.SelectionBackColor = Color.FromArgb(Int(red / 16), Int(green / 16), Int(blue / 16))

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

    Private Sub selectPixel(ByVal pixel As Byte)

        If SerialPort1.IsOpen Then

            SerialPort1.Write("p")
            SerialPort1.Write(Chr(pixel))

            txtSerial.AppendText("SENT p: " & pixel.ToString & vbCrLf)

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

End Class
