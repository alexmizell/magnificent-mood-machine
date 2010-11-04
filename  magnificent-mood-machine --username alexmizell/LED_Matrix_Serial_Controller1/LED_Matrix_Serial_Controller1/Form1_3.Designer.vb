<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnPickColor = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRainbow = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.lblR = New System.Windows.Forms.Label
        Me.lblG = New System.Windows.Forms.Label
        Me.lblB = New System.Windows.Forms.Label
        Me.lblFreq = New System.Windows.Forms.Label
        Me.timerSinGenerator = New System.Windows.Forms.Timer(Me.components)
        Me.hsSinFreqDiv = New System.Windows.Forms.HScrollBar
        Me.lblSinFreq = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.tbRed = New System.Windows.Forms.TrackBar
        Me.tbGreen = New System.Windows.Forms.TrackBar
        Me.tbBlue = New System.Windows.Forms.TrackBar
        Me.cbCOM = New System.Windows.Forms.CheckBox
        Me.txtRowOnDelayMS = New System.Windows.Forms.TextBox
        Me.dgLEDMatrix = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtNumRows = New System.Windows.Forms.TextBox
        Me.lblNumRows = New System.Windows.Forms.Label
        Me.txtNumChannels = New System.Windows.Forms.TextBox
        Me.lblNumChannels = New System.Windows.Forms.Label
        Me.txtNumTLCs = New System.Windows.Forms.TextBox
        Me.lblNumTLCs = New System.Windows.Forms.Label
        Me.txtNumLEDs = New System.Windows.Forms.TextBox
        Me.lblNumLEDs = New System.Windows.Forms.Label
        Me.lblChannelsPerLED = New System.Windows.Forms.Label
        Me.txtNumColumns = New System.Windows.Forms.TextBox
        Me.lblNumColumns = New System.Windows.Forms.Label
        Me.btnColorSolid = New System.Windows.Forms.Button
        Me.lblOffDelayMS = New System.Windows.Forms.Label
        Me.txtOffDelayMs = New System.Windows.Forms.TextBox
        Me.pbSerialOut = New System.Windows.Forms.ProgressBar
        Me.pbSerialIn = New System.Windows.Forms.ProgressBar
        Me.txtNumTLCCols = New System.Windows.Forms.TextBox
        Me.txtNumTLCRows = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMatrixCols = New System.Windows.Forms.TextBox
        Me.txtMatrixRows = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumChannelsPerLED = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkFlipVertical = New System.Windows.Forms.CheckBox
        Me.chkFlipHorizontal = New System.Windows.Forms.CheckBox
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 57600
        Me.SerialPort1.PortName = "COM3"
        Me.SerialPort1.WriteBufferSize = 4096
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(46, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 99)
        Me.TextBox1.TabIndex = 0
        '
        'btnPickColor
        '
        Me.btnPickColor.Location = New System.Drawing.Point(12, 172)
        Me.btnPickColor.Name = "btnPickColor"
        Me.btnPickColor.Size = New System.Drawing.Size(75, 23)
        Me.btnPickColor.TabIndex = 1
        Me.btnPickColor.Text = "Pick Color"
        Me.btnPickColor.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 129)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(803, 12)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(193, 324)
        Me.txtSerial.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnRainbow
        '
        Me.btnRainbow.Location = New System.Drawing.Point(93, 172)
        Me.btnRainbow.Name = "btnRainbow"
        Me.btnRainbow.Size = New System.Drawing.Size(75, 23)
        Me.btnRainbow.TabIndex = 6
        Me.btnRainbow.Text = "Rainbow!"
        Me.btnRainbow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(93, 201)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(25, 337)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(15, 13)
        Me.lblR.TabIndex = 10
        Me.lblR.Text = "R"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.ForeColor = System.Drawing.Color.Lime
        Me.lblG.Location = New System.Drawing.Point(25, 377)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(15, 13)
        Me.lblG.TabIndex = 10
        Me.lblG.Text = "G"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(26, 416)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(14, 13)
        Me.lblB.TabIndex = 10
        Me.lblB.Text = "B"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(460, 448)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(95, 13)
        Me.lblFreq.TabIndex = 11
        Me.lblFreq.Text = "Row On Delay uS:"
        '
        'timerSinGenerator
        '
        Me.timerSinGenerator.Enabled = True
        Me.timerSinGenerator.Interval = 2
        '
        'hsSinFreqDiv
        '
        Me.hsSinFreqDiv.Location = New System.Drawing.Point(29, 464)
        Me.hsSinFreqDiv.Maximum = 5000
        Me.hsSinFreqDiv.Minimum = 1
        Me.hsSinFreqDiv.Name = "hsSinFreqDiv"
        Me.hsSinFreqDiv.Size = New System.Drawing.Size(263, 19)
        Me.hsSinFreqDiv.TabIndex = 12
        Me.hsSinFreqDiv.Value = 2000
        '
        'lblSinFreq
        '
        Me.lblSinFreq.AutoSize = True
        Me.lblSinFreq.Location = New System.Drawing.Point(26, 493)
        Me.lblSinFreq.Name = "lblSinFreq"
        Me.lblSinFreq.Size = New System.Drawing.Size(101, 13)
        Me.lblSinFreq.TabIndex = 13
        Me.lblSinFreq.Text = "Sin1 Freq Div: 2000"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(245, 337)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Sin1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(245, 377)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Sin1"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(245, 425)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Sin1"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'tbRed
        '
        Me.tbRed.LargeChange = 1
        Me.tbRed.Location = New System.Drawing.Point(46, 337)
        Me.tbRed.Maximum = 255
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(193, 45)
        Me.tbRed.TabIndex = 15
        Me.tbRed.TickFrequency = 100
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(46, 377)
        Me.tbGreen.Maximum = 255
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(193, 45)
        Me.tbGreen.TabIndex = 15
        Me.tbGreen.TickFrequency = 100
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(46, 416)
        Me.tbBlue.Maximum = 255
        Me.tbBlue.Name = "tbBlue"
        Me.tbBlue.Size = New System.Drawing.Size(193, 45)
        Me.tbBlue.TabIndex = 15
        Me.tbBlue.TickFrequency = 100
        '
        'cbCOM
        '
        Me.cbCOM.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbCOM.AutoSize = True
        Me.cbCOM.Location = New System.Drawing.Point(174, 172)
        Me.cbCOM.Name = "cbCOM"
        Me.cbCOM.Size = New System.Drawing.Size(83, 23)
        Me.cbCOM.TabIndex = 16
        Me.cbCOM.Text = "COM Enabled"
        Me.cbCOM.UseVisualStyleBackColor = True
        '
        'txtRowOnDelayMS
        '
        Me.txtRowOnDelayMS.Location = New System.Drawing.Point(561, 445)
        Me.txtRowOnDelayMS.Name = "txtRowOnDelayMS"
        Me.txtRowOnDelayMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRowOnDelayMS.Size = New System.Drawing.Size(51, 20)
        Me.txtRowOnDelayMS.TabIndex = 17
        Me.txtRowOnDelayMS.Text = "96"
        Me.txtRowOnDelayMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgLEDMatrix
        '
        Me.dgLEDMatrix.AllowUserToAddRows = False
        Me.dgLEDMatrix.AllowUserToDeleteRows = False
        Me.dgLEDMatrix.AllowUserToResizeColumns = False
        Me.dgLEDMatrix.AllowUserToResizeRows = False
        Me.dgLEDMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgLEDMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLEDMatrix.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgLEDMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLEDMatrix.ColumnHeadersVisible = False
        Me.dgLEDMatrix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLEDMatrix.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgLEDMatrix.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgLEDMatrix.Location = New System.Drawing.Point(399, 35)
        Me.dgLEDMatrix.MultiSelect = False
        Me.dgLEDMatrix.Name = "dgLEDMatrix"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLEDMatrix.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgLEDMatrix.RowHeadersVisible = False
        Me.dgLEDMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLEDMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgLEDMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgLEDMatrix.ShowEditingIcon = False
        Me.dgLEDMatrix.Size = New System.Drawing.Size(273, 233)
        Me.dgLEDMatrix.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'txtNumRows
        '
        Me.txtNumRows.Location = New System.Drawing.Point(408, 445)
        Me.txtNumRows.Name = "txtNumRows"
        Me.txtNumRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumRows.TabIndex = 19
        Me.txtNumRows.Text = "5"
        Me.txtNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(340, 448)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(62, 13)
        Me.lblNumRows.TabIndex = 20
        Me.lblNumRows.Text = "Num Rows:"
        Me.lblNumRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumChannels
        '
        Me.txtNumChannels.Location = New System.Drawing.Point(408, 365)
        Me.txtNumChannels.Name = "txtNumChannels"
        Me.txtNumChannels.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannels.TabIndex = 19
        Me.txtNumChannels.Text = "15"
        Me.txtNumChannels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumChannels
        '
        Me.lblNumChannels.AutoSize = True
        Me.lblNumChannels.Location = New System.Drawing.Point(323, 368)
        Me.lblNumChannels.Name = "lblNumChannels"
        Me.lblNumChannels.Size = New System.Drawing.Size(79, 13)
        Me.lblNumChannels.TabIndex = 20
        Me.lblNumChannels.Text = "Num Channels:"
        Me.lblNumChannels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumTLCs
        '
        Me.txtNumTLCs.Enabled = False
        Me.txtNumTLCs.Location = New System.Drawing.Point(408, 338)
        Me.txtNumTLCs.Name = "txtNumTLCs"
        Me.txtNumTLCs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCs.TabIndex = 19
        Me.txtNumTLCs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumTLCs
        '
        Me.lblNumTLCs.AutoSize = True
        Me.lblNumTLCs.Location = New System.Drawing.Point(340, 341)
        Me.lblNumTLCs.Name = "lblNumTLCs"
        Me.lblNumTLCs.Size = New System.Drawing.Size(60, 13)
        Me.lblNumTLCs.TabIndex = 20
        Me.lblNumTLCs.Text = "Num TLCs:"
        Me.lblNumTLCs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumLEDs
        '
        Me.txtNumLEDs.Enabled = False
        Me.txtNumLEDs.Location = New System.Drawing.Point(408, 471)
        Me.txtNumLEDs.Name = "txtNumLEDs"
        Me.txtNumLEDs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumLEDs.TabIndex = 19
        Me.txtNumLEDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumLEDs
        '
        Me.lblNumLEDs.AutoSize = True
        Me.lblNumLEDs.Location = New System.Drawing.Point(339, 474)
        Me.lblNumLEDs.Name = "lblNumLEDs"
        Me.lblNumLEDs.Size = New System.Drawing.Size(61, 13)
        Me.lblNumLEDs.TabIndex = 20
        Me.lblNumLEDs.Text = "Num LEDs:"
        Me.lblNumLEDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChannelsPerLED
        '
        Me.lblChannelsPerLED.AutoSize = True
        Me.lblChannelsPerLED.Location = New System.Drawing.Point(305, 394)
        Me.lblChannelsPerLED.Name = "lblChannelsPerLED"
        Me.lblChannelsPerLED.Size = New System.Drawing.Size(97, 13)
        Me.lblChannelsPerLED.TabIndex = 20
        Me.lblChannelsPerLED.Text = "Channels Per LED:"
        Me.lblChannelsPerLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumColumns
        '
        Me.txtNumColumns.Enabled = False
        Me.txtNumColumns.Location = New System.Drawing.Point(408, 418)
        Me.txtNumColumns.Name = "txtNumColumns"
        Me.txtNumColumns.Size = New System.Drawing.Size(46, 20)
        Me.txtNumColumns.TabIndex = 19
        Me.txtNumColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumColumns
        '
        Me.lblNumColumns.AutoSize = True
        Me.lblNumColumns.Location = New System.Drawing.Point(327, 421)
        Me.lblNumColumns.Name = "lblNumColumns"
        Me.lblNumColumns.Size = New System.Drawing.Size(75, 13)
        Me.lblNumColumns.TabIndex = 20
        Me.lblNumColumns.Text = "Num Columns:"
        Me.lblNumColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnColorSolid
        '
        Me.btnColorSolid.Location = New System.Drawing.Point(12, 201)
        Me.btnColorSolid.Name = "btnColorSolid"
        Me.btnColorSolid.Size = New System.Drawing.Size(75, 23)
        Me.btnColorSolid.TabIndex = 21
        Me.btnColorSolid.Text = "Fill"
        Me.btnColorSolid.UseVisualStyleBackColor = True
        '
        'lblOffDelayMS
        '
        Me.lblOffDelayMS.AutoSize = True
        Me.lblOffDelayMS.Location = New System.Drawing.Point(460, 475)
        Me.lblOffDelayMS.Name = "lblOffDelayMS"
        Me.lblOffDelayMS.Size = New System.Drawing.Size(95, 13)
        Me.lblOffDelayMS.TabIndex = 11
        Me.lblOffDelayMS.Text = "Row Off Delay uS:"
        '
        'txtOffDelayMs
        '
        Me.txtOffDelayMs.Location = New System.Drawing.Point(561, 472)
        Me.txtOffDelayMs.Name = "txtOffDelayMs"
        Me.txtOffDelayMs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffDelayMs.Size = New System.Drawing.Size(51, 20)
        Me.txtOffDelayMs.TabIndex = 17
        Me.txtOffDelayMs.Text = "48"
        Me.txtOffDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbSerialOut
        '
        Me.pbSerialOut.Location = New System.Drawing.Point(818, 381)
        Me.pbSerialOut.Maximum = 4096
        Me.pbSerialOut.Name = "pbSerialOut"
        Me.pbSerialOut.Size = New System.Drawing.Size(179, 18)
        Me.pbSerialOut.TabIndex = 22
        '
        'pbSerialIn
        '
        Me.pbSerialIn.Location = New System.Drawing.Point(818, 357)
        Me.pbSerialIn.Maximum = 4096
        Me.pbSerialIn.Name = "pbSerialIn"
        Me.pbSerialIn.Size = New System.Drawing.Size(178, 18)
        Me.pbSerialIn.TabIndex = 22
        '
        'txtNumTLCCols
        '
        Me.txtNumTLCCols.Location = New System.Drawing.Point(563, 365)
        Me.txtNumTLCCols.Name = "txtNumTLCCols"
        Me.txtNumTLCCols.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCCols.TabIndex = 19
        Me.txtNumTLCCols.Text = "1"
        Me.txtNumTLCCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumTLCRows
        '
        Me.txtNumTLCRows.Location = New System.Drawing.Point(563, 338)
        Me.txtNumTLCRows.Name = "txtNumTLCRows"
        Me.txtNumTLCRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCRows.TabIndex = 19
        Me.txtNumTLCRows.Text = "2"
        Me.txtNumTLCRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "numTLCCols: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "numTLCRows: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatrixCols
        '
        Me.txtMatrixCols.Enabled = False
        Me.txtMatrixCols.Location = New System.Drawing.Point(563, 416)
        Me.txtMatrixCols.Name = "txtMatrixCols"
        Me.txtMatrixCols.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixCols.TabIndex = 19
        Me.txtMatrixCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMatrixRows
        '
        Me.txtMatrixRows.Enabled = False
        Me.txtMatrixRows.Location = New System.Drawing.Point(563, 389)
        Me.txtMatrixRows.Name = "txtMatrixRows"
        Me.txtMatrixRows.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixRows.TabIndex = 19
        Me.txtMatrixRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "matrixCols:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "matrixRows: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumChannelsPerLED
        '
        Me.txtNumChannelsPerLED.Location = New System.Drawing.Point(408, 391)
        Me.txtNumChannelsPerLED.Name = "txtNumChannelsPerLED"
        Me.txtNumChannelsPerLED.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannelsPerLED.TabIndex = 23
        Me.txtNumChannelsPerLED.Text = "3"
        Me.txtNumChannelsPerLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(865, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Serial buffers"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(800, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "I:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(800, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "O:"
        '
        'chkFlipVertical
        '
        Me.chkFlipVertical.AutoSize = True
        Me.chkFlipVertical.Location = New System.Drawing.Point(457, 274)
        Me.chkFlipVertical.Name = "chkFlipVertical"
        Me.chkFlipVertical.Size = New System.Drawing.Size(79, 17)
        Me.chkFlipVertical.TabIndex = 25
        Me.chkFlipVertical.Text = "Flip vertical"
        Me.chkFlipVertical.UseVisualStyleBackColor = True
        '
        'chkFlipHorizontal
        '
        Me.chkFlipHorizontal.AutoSize = True
        Me.chkFlipHorizontal.Location = New System.Drawing.Point(542, 274)
        Me.chkFlipHorizontal.Name = "chkFlipHorizontal"
        Me.chkFlipHorizontal.Size = New System.Drawing.Size(90, 17)
        Me.chkFlipHorizontal.TabIndex = 25
        Me.chkFlipHorizontal.Text = "Flip horizontal"
        Me.chkFlipHorizontal.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.chkFlipHorizontal)
        Me.Controls.Add(Me.chkFlipVertical)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumChannelsPerLED)
        Me.Controls.Add(Me.pbSerialIn)
        Me.Controls.Add(Me.pbSerialOut)
        Me.Controls.Add(Me.btnColorSolid)
        Me.Controls.Add(Me.lblChannelsPerLED)
        Me.Controls.Add(Me.lblNumColumns)
        Me.Controls.Add(Me.lblNumLEDs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNumTLCs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumChannels)
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.txtNumColumns)
        Me.Controls.Add(Me.txtNumLEDs)
        Me.Controls.Add(Me.txtMatrixRows)
        Me.Controls.Add(Me.txtNumTLCRows)
        Me.Controls.Add(Me.txtMatrixCols)
        Me.Controls.Add(Me.txtNumTLCCols)
        Me.Controls.Add(Me.txtNumTLCs)
        Me.Controls.Add(Me.txtNumChannels)
        Me.Controls.Add(Me.txtNumRows)
        Me.Controls.Add(Me.dgLEDMatrix)
        Me.Controls.Add(Me.txtOffDelayMs)
        Me.Controls.Add(Me.txtRowOnDelayMS)
        Me.Controls.Add(Me.cbCOM)
        Me.Controls.Add(Me.tbBlue)
        Me.Controls.Add(Me.tbGreen)
        Me.Controls.Add(Me.tbRed)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblSinFreq)
        Me.Controls.Add(Me.lblOffDelayMS)
        Me.Controls.Add(Me.hsSinFreqDiv)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRainbow)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnPickColor)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmMain"
        Me.Text = "The Magnificent Mood Machine Controller v1.0 by Alex Mizell"
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPickColor As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnRainbow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblFreq As System.Windows.Forms.Label
    Friend WithEvents timerSinGenerator As System.Windows.Forms.Timer
    Friend WithEvents hsSinFreqDiv As System.Windows.Forms.HScrollBar
    Friend WithEvents lblSinFreq As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents tbRed As System.Windows.Forms.TrackBar
    Friend WithEvents tbGreen As System.Windows.Forms.TrackBar
    Friend WithEvents tbBlue As System.Windows.Forms.TrackBar
    Friend WithEvents cbCOM As System.Windows.Forms.CheckBox
    Friend WithEvents txtRowOnDelayMS As System.Windows.Forms.TextBox
    Friend WithEvents dgLEDMatrix As System.Windows.Forms.DataGridView
    Friend WithEvents txtNumRows As System.Windows.Forms.TextBox
    Friend WithEvents lblNumRows As System.Windows.Forms.Label
    Friend WithEvents txtNumChannels As System.Windows.Forms.TextBox
    Friend WithEvents lblNumChannels As System.Windows.Forms.Label
    Friend WithEvents txtNumTLCs As System.Windows.Forms.TextBox
    Friend WithEvents lblNumTLCs As System.Windows.Forms.Label
    Friend WithEvents txtNumLEDs As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLEDs As System.Windows.Forms.Label
    Friend WithEvents lblChannelsPerLED As System.Windows.Forms.Label
    Friend WithEvents txtNumColumns As System.Windows.Forms.TextBox
    Friend WithEvents lblNumColumns As System.Windows.Forms.Label
    Friend WithEvents btnColorSolid As System.Windows.Forms.Button
    Friend WithEvents lblOffDelayMS As System.Windows.Forms.Label
    Friend WithEvents txtOffDelayMs As System.Windows.Forms.TextBox
    Friend WithEvents pbSerialOut As System.Windows.Forms.ProgressBar
    Friend WithEvents pbSerialIn As System.Windows.Forms.ProgressBar
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNumTLCCols As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTLCRows As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMatrixCols As System.Windows.Forms.TextBox
    Friend WithEvents txtMatrixRows As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumChannelsPerLED As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkFlipVertical As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlipHorizontal As System.Windows.Forms.CheckBox

End Class
