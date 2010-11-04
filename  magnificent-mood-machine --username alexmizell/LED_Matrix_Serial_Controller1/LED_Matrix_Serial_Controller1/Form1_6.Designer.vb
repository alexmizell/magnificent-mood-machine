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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.txtSayIt = New System.Windows.Forms.TextBox
        Me.btnSayIt = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.btnChooseFont = New System.Windows.Forms.Button
        Me.txtFontName = New System.Windows.Forms.TextBox
        Me.tabContainer = New System.Windows.Forms.TabControl
        Me.tabBitMapView = New System.Windows.Forms.TabPage
        Me.pbPixelArray = New System.Windows.Forms.PictureBox
        Me.tabDGView = New System.Windows.Forms.TabPage
        Me.btnSendFrame = New System.Windows.Forms.Button
        Me.pbSayIt = New System.Windows.Forms.PictureBox
        Me.btnShiftLeft = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbDebugMode = New System.Windows.Forms.CheckBox
        Me.txtSlowDown = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.udHorizontalFontAdjust = New System.Windows.Forms.DomainUpDown
        Me.udVerticalFontAdjust = New System.Windows.Forms.DomainUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblPxl = New System.Windows.Forms.Label
        Me.lblTLC = New System.Windows.Forms.Label
        Me.lblI = New System.Windows.Forms.Label
        Me.lblJ = New System.Windows.Forms.Label
        Me.lblX = New System.Windows.Forms.Label
        Me.lblY = New System.Windows.Forms.Label
        Me.lblArrayIndex = New System.Windows.Forms.Label
        Me.btnDump = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.cbFlipTLCVertical = New System.Windows.Forms.CheckBox
        Me.cbFlipTLCHorizontal = New System.Windows.Forms.CheckBox
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabContainer.SuspendLayout()
        Me.tabBitMapView.SuspendLayout()
        CType(Me.pbPixelArray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDGView.SuspendLayout()
        CType(Me.pbSayIt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.TextBox1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.ForeColor = System.Drawing.Color.Aqua
        Me.TextBox1.Location = New System.Drawing.Point(32, 47)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 47)
        Me.TextBox1.TabIndex = 0
        '
        'btnPickColor
        '
        Me.btnPickColor.Location = New System.Drawing.Point(29, 102)
        Me.btnPickColor.Name = "btnPickColor"
        Me.btnPickColor.Size = New System.Drawing.Size(75, 23)
        Me.btnPickColor.TabIndex = 1
        Me.btnPickColor.Text = "Pick Color"
        Me.btnPickColor.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(819, 57)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSerial.Size = New System.Drawing.Size(178, 308)
        Me.txtSerial.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'btnRainbow
        '
        Me.btnRainbow.Location = New System.Drawing.Point(110, 102)
        Me.btnRainbow.Name = "btnRainbow"
        Me.btnRainbow.Size = New System.Drawing.Size(75, 23)
        Me.btnRainbow.TabIndex = 6
        Me.btnRainbow.Text = "Rainbow!"
        Me.btnRainbow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(110, 131)
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
        Me.lblR.Location = New System.Drawing.Point(11, 245)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(15, 13)
        Me.lblR.TabIndex = 10
        Me.lblR.Text = "R"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.ForeColor = System.Drawing.Color.Lime
        Me.lblG.Location = New System.Drawing.Point(11, 285)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(15, 13)
        Me.lblG.TabIndex = 10
        Me.lblG.Text = "G"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(12, 326)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(14, 13)
        Me.lblB.TabIndex = 10
        Me.lblB.Text = "B"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(545, 506)
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
        Me.hsSinFreqDiv.Location = New System.Drawing.Point(32, 405)
        Me.hsSinFreqDiv.Maximum = 5000
        Me.hsSinFreqDiv.Minimum = 1
        Me.hsSinFreqDiv.Name = "hsSinFreqDiv"
        Me.hsSinFreqDiv.Size = New System.Drawing.Size(153, 19)
        Me.hsSinFreqDiv.TabIndex = 12
        Me.hsSinFreqDiv.Value = 2000
        '
        'lblSinFreq
        '
        Me.lblSinFreq.AutoSize = True
        Me.lblSinFreq.Location = New System.Drawing.Point(194, 409)
        Me.lblSinFreq.Name = "lblSinFreq"
        Me.lblSinFreq.Size = New System.Drawing.Size(101, 13)
        Me.lblSinFreq.TabIndex = 13
        Me.lblSinFreq.Text = "Sin1 Freq Div: 2000"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(231, 280)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Sin1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(231, 320)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Sin1"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(231, 370)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Sin1"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'tbRed
        '
        Me.tbRed.LargeChange = 1
        Me.tbRed.Location = New System.Drawing.Point(32, 280)
        Me.tbRed.Maximum = 255
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(193, 45)
        Me.tbRed.TabIndex = 15
        Me.tbRed.TickFrequency = 100
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(32, 320)
        Me.tbGreen.Maximum = 255
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(193, 45)
        Me.tbGreen.TabIndex = 15
        Me.tbGreen.TickFrequency = 100
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(32, 361)
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
        Me.cbCOM.Location = New System.Drawing.Point(191, 102)
        Me.cbCOM.Name = "cbCOM"
        Me.cbCOM.Size = New System.Drawing.Size(83, 23)
        Me.cbCOM.TabIndex = 16
        Me.cbCOM.Text = "COM Enabled"
        Me.cbCOM.UseVisualStyleBackColor = True
        '
        'txtRowOnDelayMS
        '
        Me.txtRowOnDelayMS.Location = New System.Drawing.Point(646, 503)
        Me.txtRowOnDelayMS.Name = "txtRowOnDelayMS"
        Me.txtRowOnDelayMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRowOnDelayMS.Size = New System.Drawing.Size(51, 20)
        Me.txtRowOnDelayMS.TabIndex = 17
        Me.txtRowOnDelayMS.Text = "106"
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
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLEDMatrix.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgLEDMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLEDMatrix.ColumnHeadersVisible = False
        Me.dgLEDMatrix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLEDMatrix.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgLEDMatrix.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgLEDMatrix.Location = New System.Drawing.Point(2, 3)
        Me.dgLEDMatrix.MultiSelect = False
        Me.dgLEDMatrix.Name = "dgLEDMatrix"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLEDMatrix.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgLEDMatrix.RowHeadersVisible = False
        Me.dgLEDMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLEDMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgLEDMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgLEDMatrix.ShowEditingIcon = False
        Me.dgLEDMatrix.Size = New System.Drawing.Size(500, 300)
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
        Me.txtNumRows.Location = New System.Drawing.Point(493, 503)
        Me.txtNumRows.Name = "txtNumRows"
        Me.txtNumRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumRows.TabIndex = 19
        Me.txtNumRows.Text = "5"
        Me.txtNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(425, 506)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(62, 13)
        Me.lblNumRows.TabIndex = 20
        Me.lblNumRows.Text = "Num Rows:"
        Me.lblNumRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumChannels
        '
        Me.txtNumChannels.Location = New System.Drawing.Point(493, 423)
        Me.txtNumChannels.Name = "txtNumChannels"
        Me.txtNumChannels.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannels.TabIndex = 19
        Me.txtNumChannels.Text = "15"
        Me.txtNumChannels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumChannels
        '
        Me.lblNumChannels.AutoSize = True
        Me.lblNumChannels.Location = New System.Drawing.Point(408, 426)
        Me.lblNumChannels.Name = "lblNumChannels"
        Me.lblNumChannels.Size = New System.Drawing.Size(79, 13)
        Me.lblNumChannels.TabIndex = 20
        Me.lblNumChannels.Text = "Num Channels:"
        Me.lblNumChannels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumTLCs
        '
        Me.txtNumTLCs.Enabled = False
        Me.txtNumTLCs.Location = New System.Drawing.Point(493, 396)
        Me.txtNumTLCs.Name = "txtNumTLCs"
        Me.txtNumTLCs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCs.TabIndex = 19
        Me.txtNumTLCs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumTLCs
        '
        Me.lblNumTLCs.AutoSize = True
        Me.lblNumTLCs.Location = New System.Drawing.Point(425, 399)
        Me.lblNumTLCs.Name = "lblNumTLCs"
        Me.lblNumTLCs.Size = New System.Drawing.Size(60, 13)
        Me.lblNumTLCs.TabIndex = 20
        Me.lblNumTLCs.Text = "Num TLCs:"
        Me.lblNumTLCs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumLEDs
        '
        Me.txtNumLEDs.Enabled = False
        Me.txtNumLEDs.Location = New System.Drawing.Point(493, 529)
        Me.txtNumLEDs.Name = "txtNumLEDs"
        Me.txtNumLEDs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumLEDs.TabIndex = 19
        Me.txtNumLEDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumLEDs
        '
        Me.lblNumLEDs.AutoSize = True
        Me.lblNumLEDs.Location = New System.Drawing.Point(424, 532)
        Me.lblNumLEDs.Name = "lblNumLEDs"
        Me.lblNumLEDs.Size = New System.Drawing.Size(61, 13)
        Me.lblNumLEDs.TabIndex = 20
        Me.lblNumLEDs.Text = "Num LEDs:"
        Me.lblNumLEDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChannelsPerLED
        '
        Me.lblChannelsPerLED.AutoSize = True
        Me.lblChannelsPerLED.Location = New System.Drawing.Point(390, 452)
        Me.lblChannelsPerLED.Name = "lblChannelsPerLED"
        Me.lblChannelsPerLED.Size = New System.Drawing.Size(97, 13)
        Me.lblChannelsPerLED.TabIndex = 20
        Me.lblChannelsPerLED.Text = "Channels Per LED:"
        Me.lblChannelsPerLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumColumns
        '
        Me.txtNumColumns.Enabled = False
        Me.txtNumColumns.Location = New System.Drawing.Point(493, 476)
        Me.txtNumColumns.Name = "txtNumColumns"
        Me.txtNumColumns.Size = New System.Drawing.Size(46, 20)
        Me.txtNumColumns.TabIndex = 19
        Me.txtNumColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumColumns
        '
        Me.lblNumColumns.AutoSize = True
        Me.lblNumColumns.Location = New System.Drawing.Point(412, 479)
        Me.lblNumColumns.Name = "lblNumColumns"
        Me.lblNumColumns.Size = New System.Drawing.Size(75, 13)
        Me.lblNumColumns.TabIndex = 20
        Me.lblNumColumns.Text = "Num Columns:"
        Me.lblNumColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnColorSolid
        '
        Me.btnColorSolid.Location = New System.Drawing.Point(29, 131)
        Me.btnColorSolid.Name = "btnColorSolid"
        Me.btnColorSolid.Size = New System.Drawing.Size(75, 23)
        Me.btnColorSolid.TabIndex = 21
        Me.btnColorSolid.Text = "Fill"
        Me.btnColorSolid.UseVisualStyleBackColor = True
        '
        'lblOffDelayMS
        '
        Me.lblOffDelayMS.AutoSize = True
        Me.lblOffDelayMS.Location = New System.Drawing.Point(545, 533)
        Me.lblOffDelayMS.Name = "lblOffDelayMS"
        Me.lblOffDelayMS.Size = New System.Drawing.Size(95, 13)
        Me.lblOffDelayMS.TabIndex = 11
        Me.lblOffDelayMS.Text = "Row Off Delay uS:"
        '
        'txtOffDelayMs
        '
        Me.txtOffDelayMs.Location = New System.Drawing.Point(646, 530)
        Me.txtOffDelayMs.Name = "txtOffDelayMs"
        Me.txtOffDelayMs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffDelayMs.Size = New System.Drawing.Size(51, 20)
        Me.txtOffDelayMs.TabIndex = 17
        Me.txtOffDelayMs.Text = "53"
        Me.txtOffDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbSerialOut
        '
        Me.pbSerialOut.Location = New System.Drawing.Point(819, 407)
        Me.pbSerialOut.Maximum = 4096
        Me.pbSerialOut.Name = "pbSerialOut"
        Me.pbSerialOut.Size = New System.Drawing.Size(179, 18)
        Me.pbSerialOut.TabIndex = 22
        '
        'pbSerialIn
        '
        Me.pbSerialIn.Location = New System.Drawing.Point(819, 383)
        Me.pbSerialIn.Maximum = 4096
        Me.pbSerialIn.Name = "pbSerialIn"
        Me.pbSerialIn.Size = New System.Drawing.Size(178, 18)
        Me.pbSerialIn.TabIndex = 22
        '
        'txtNumTLCCols
        '
        Me.txtNumTLCCols.Location = New System.Drawing.Point(648, 423)
        Me.txtNumTLCCols.Name = "txtNumTLCCols"
        Me.txtNumTLCCols.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCCols.TabIndex = 19
        Me.txtNumTLCCols.Text = "2"
        Me.txtNumTLCCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumTLCRows
        '
        Me.txtNumTLCRows.Location = New System.Drawing.Point(648, 396)
        Me.txtNumTLCRows.Name = "txtNumTLCRows"
        Me.txtNumTLCRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCRows.TabIndex = 19
        Me.txtNumTLCRows.Text = "2"
        Me.txtNumTLCRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 426)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "numTLCCols: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "numTLCRows: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMatrixCols
        '
        Me.txtMatrixCols.Enabled = False
        Me.txtMatrixCols.Location = New System.Drawing.Point(648, 474)
        Me.txtMatrixCols.Name = "txtMatrixCols"
        Me.txtMatrixCols.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixCols.TabIndex = 19
        Me.txtMatrixCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMatrixRows
        '
        Me.txtMatrixRows.Enabled = False
        Me.txtMatrixRows.Location = New System.Drawing.Point(648, 447)
        Me.txtMatrixRows.Name = "txtMatrixRows"
        Me.txtMatrixRows.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixRows.TabIndex = 19
        Me.txtMatrixRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(574, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "matrixCols:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "matrixRows: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumChannelsPerLED
        '
        Me.txtNumChannelsPerLED.Location = New System.Drawing.Point(493, 449)
        Me.txtNumChannelsPerLED.Name = "txtNumChannelsPerLED"
        Me.txtNumChannelsPerLED.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannelsPerLED.TabIndex = 23
        Me.txtNumChannelsPerLED.Text = "3"
        Me.txtNumChannelsPerLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(868, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Serial buffers"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(800, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "I:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(800, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "O:"
        '
        'chkFlipVertical
        '
        Me.chkFlipVertical.AutoSize = True
        Me.chkFlipVertical.Location = New System.Drawing.Point(304, 373)
        Me.chkFlipVertical.Name = "chkFlipVertical"
        Me.chkFlipVertical.Size = New System.Drawing.Size(79, 17)
        Me.chkFlipVertical.TabIndex = 25
        Me.chkFlipVertical.Text = "Flip vertical"
        Me.chkFlipVertical.UseVisualStyleBackColor = True
        '
        'chkFlipHorizontal
        '
        Me.chkFlipHorizontal.AutoSize = True
        Me.chkFlipHorizontal.Location = New System.Drawing.Point(389, 373)
        Me.chkFlipHorizontal.Name = "chkFlipHorizontal"
        Me.chkFlipHorizontal.Size = New System.Drawing.Size(90, 17)
        Me.chkFlipHorizontal.TabIndex = 25
        Me.chkFlipHorizontal.Text = "Flip horizontal"
        Me.chkFlipHorizontal.UseVisualStyleBackColor = True
        '
        'txtSayIt
        '
        Me.txtSayIt.BackColor = System.Drawing.Color.Black
        Me.txtSayIt.Location = New System.Drawing.Point(32, 481)
        Me.txtSayIt.Multiline = True
        Me.txtSayIt.Name = "txtSayIt"
        Me.txtSayIt.Size = New System.Drawing.Size(263, 69)
        Me.txtSayIt.TabIndex = 26
        Me.txtSayIt.Text = "Lorem ipsum blahbedy blah!"
        '
        'btnSayIt
        '
        Me.btnSayIt.Location = New System.Drawing.Point(298, 527)
        Me.btnSayIt.Name = "btnSayIt"
        Me.btnSayIt.Size = New System.Drawing.Size(75, 23)
        Me.btnSayIt.TabIndex = 27
        Me.btnSayIt.Text = "Say It Big"
        Me.btnSayIt.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowColor = True
        '
        'btnChooseFont
        '
        Me.btnChooseFont.Location = New System.Drawing.Point(298, 455)
        Me.btnChooseFont.Name = "btnChooseFont"
        Me.btnChooseFont.Size = New System.Drawing.Size(78, 20)
        Me.btnChooseFont.TabIndex = 28
        Me.btnChooseFont.Text = "Choose Font"
        Me.btnChooseFont.UseVisualStyleBackColor = True
        '
        'txtFontName
        '
        Me.txtFontName.BackColor = System.Drawing.Color.Black
        Me.txtFontName.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFontName.Location = New System.Drawing.Point(32, 445)
        Me.txtFontName.Multiline = True
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(263, 34)
        Me.txtFontName.TabIndex = 30
        Me.txtFontName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabContainer
        '
        Me.tabContainer.Controls.Add(Me.tabDGView)
        Me.tabContainer.Controls.Add(Me.tabBitMapView)
        Me.tabContainer.Location = New System.Drawing.Point(298, 37)
        Me.tabContainer.Name = "tabContainer"
        Me.tabContainer.Padding = New System.Drawing.Point(0, 0)
        Me.tabContainer.SelectedIndex = 0
        Me.tabContainer.Size = New System.Drawing.Size(510, 330)
        Me.tabContainer.TabIndex = 31
        '
        'tabBitMapView
        '
        Me.tabBitMapView.Controls.Add(Me.pbPixelArray)
        Me.tabBitMapView.Location = New System.Drawing.Point(4, 22)
        Me.tabBitMapView.Margin = New System.Windows.Forms.Padding(0)
        Me.tabBitMapView.Name = "tabBitMapView"
        Me.tabBitMapView.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBitMapView.Size = New System.Drawing.Size(502, 304)
        Me.tabBitMapView.TabIndex = 1
        Me.tabBitMapView.Text = "BitMapView"
        Me.tabBitMapView.UseVisualStyleBackColor = True
        '
        'pbPixelArray
        '
        Me.pbPixelArray.Location = New System.Drawing.Point(0, 3)
        Me.pbPixelArray.Name = "pbPixelArray"
        Me.pbPixelArray.Size = New System.Drawing.Size(500, 302)
        Me.pbPixelArray.TabIndex = 0
        Me.pbPixelArray.TabStop = False
        '
        'tabDGView
        '
        Me.tabDGView.Controls.Add(Me.dgLEDMatrix)
        Me.tabDGView.Location = New System.Drawing.Point(4, 22)
        Me.tabDGView.Margin = New System.Windows.Forms.Padding(0)
        Me.tabDGView.Name = "tabDGView"
        Me.tabDGView.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDGView.Size = New System.Drawing.Size(502, 304)
        Me.tabDGView.TabIndex = 0
        Me.tabDGView.Text = "DGView"
        Me.tabDGView.UseVisualStyleBackColor = True
        '
        'btnSendFrame
        '
        Me.btnSendFrame.Location = New System.Drawing.Point(191, 131)
        Me.btnSendFrame.Name = "btnSendFrame"
        Me.btnSendFrame.Size = New System.Drawing.Size(83, 23)
        Me.btnSendFrame.TabIndex = 32
        Me.btnSendFrame.Text = "Send Frame"
        Me.btnSendFrame.UseVisualStyleBackColor = True
        '
        'pbSayIt
        '
        Me.pbSayIt.BackColor = System.Drawing.Color.Black
        Me.pbSayIt.Location = New System.Drawing.Point(322, 12)
        Me.pbSayIt.Name = "pbSayIt"
        Me.pbSayIt.Size = New System.Drawing.Size(568, 19)
        Me.pbSayIt.TabIndex = 33
        Me.pbSayIt.TabStop = False
        Me.pbSayIt.Visible = False
        '
        'btnShiftLeft
        '
        Me.btnShiftLeft.Location = New System.Drawing.Point(29, 192)
        Me.btnShiftLeft.Name = "btnShiftLeft"
        Me.btnShiftLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnShiftLeft.TabIndex = 34
        Me.btnShiftLeft.Text = "Left"
        Me.btnShiftLeft.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Right"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(110, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Up"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(110, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Down"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Matrix Shift"
        '
        'cbDebugMode
        '
        Me.cbDebugMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbDebugMode.AutoSize = True
        Me.cbDebugMode.Location = New System.Drawing.Point(29, 160)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(73, 23)
        Me.cbDebugMode.TabIndex = 39
        Me.cbDebugMode.Text = "     Debug   "
        Me.cbDebugMode.UseVisualStyleBackColor = True
        '
        'txtSlowDown
        '
        Me.txtSlowDown.Location = New System.Drawing.Point(28, 234)
        Me.txtSlowDown.Name = "txtSlowDown"
        Me.txtSlowDown.Size = New System.Drawing.Size(72, 20)
        Me.txtSlowDown.TabIndex = 40
        Me.txtSlowDown.Text = "50"
        Me.txtSlowDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Slow Down:"
        '
        'udHorizontalFontAdjust
        '
        Me.udHorizontalFontAdjust.Items.Add("10")
        Me.udHorizontalFontAdjust.Items.Add("9")
        Me.udHorizontalFontAdjust.Items.Add("8")
        Me.udHorizontalFontAdjust.Items.Add("7")
        Me.udHorizontalFontAdjust.Items.Add("6")
        Me.udHorizontalFontAdjust.Items.Add("5")
        Me.udHorizontalFontAdjust.Items.Add("4")
        Me.udHorizontalFontAdjust.Items.Add("3")
        Me.udHorizontalFontAdjust.Items.Add("2")
        Me.udHorizontalFontAdjust.Items.Add("1")
        Me.udHorizontalFontAdjust.Items.Add("0")
        Me.udHorizontalFontAdjust.Items.Add("-1")
        Me.udHorizontalFontAdjust.Items.Add("-2")
        Me.udHorizontalFontAdjust.Items.Add("-3")
        Me.udHorizontalFontAdjust.Items.Add("-4")
        Me.udHorizontalFontAdjust.Items.Add("-5")
        Me.udHorizontalFontAdjust.Items.Add("-6")
        Me.udHorizontalFontAdjust.Items.Add("-7")
        Me.udHorizontalFontAdjust.Items.Add("-8")
        Me.udHorizontalFontAdjust.Items.Add("-9")
        Me.udHorizontalFontAdjust.Items.Add("-10")
        Me.udHorizontalFontAdjust.Location = New System.Drawing.Point(322, 478)
        Me.udHorizontalFontAdjust.Name = "udHorizontalFontAdjust"
        Me.udHorizontalFontAdjust.Size = New System.Drawing.Size(52, 20)
        Me.udHorizontalFontAdjust.TabIndex = 42
        Me.udHorizontalFontAdjust.Text = "0"
        Me.udHorizontalFontAdjust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'udVerticalFontAdjust
        '
        Me.udVerticalFontAdjust.Items.Add("10")
        Me.udVerticalFontAdjust.Items.Add("9")
        Me.udVerticalFontAdjust.Items.Add("8")
        Me.udVerticalFontAdjust.Items.Add("7")
        Me.udVerticalFontAdjust.Items.Add("6")
        Me.udVerticalFontAdjust.Items.Add("5")
        Me.udVerticalFontAdjust.Items.Add("4")
        Me.udVerticalFontAdjust.Items.Add("3")
        Me.udVerticalFontAdjust.Items.Add("2")
        Me.udVerticalFontAdjust.Items.Add("1")
        Me.udVerticalFontAdjust.Items.Add("0")
        Me.udVerticalFontAdjust.Items.Add("-1")
        Me.udVerticalFontAdjust.Items.Add("-2")
        Me.udVerticalFontAdjust.Items.Add("-3")
        Me.udVerticalFontAdjust.Items.Add("-4")
        Me.udVerticalFontAdjust.Items.Add("-5")
        Me.udVerticalFontAdjust.Items.Add("-6")
        Me.udVerticalFontAdjust.Items.Add("-7")
        Me.udVerticalFontAdjust.Items.Add("-8")
        Me.udVerticalFontAdjust.Items.Add("-9")
        Me.udVerticalFontAdjust.Items.Add("-10")
        Me.udVerticalFontAdjust.Location = New System.Drawing.Point(322, 504)
        Me.udVerticalFontAdjust.Name = "udVerticalFontAdjust"
        Me.udVerticalFontAdjust.ReadOnly = True
        Me.udVerticalFontAdjust.Size = New System.Drawing.Size(52, 20)
        Me.udVerticalFontAdjust.TabIndex = 42
        Me.udVerticalFontAdjust.Text = "4"
        Me.udVerticalFontAdjust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(301, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "H:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 506)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "V:"
        '
        'lblPxl
        '
        Me.lblPxl.AutoSize = True
        Me.lblPxl.Location = New System.Drawing.Point(722, 510)
        Me.lblPxl.Name = "lblPxl"
        Me.lblPxl.Size = New System.Drawing.Size(41, 13)
        Me.lblPxl.TabIndex = 44
        Me.lblPxl.Text = "pixel#: "
        '
        'lblTLC
        '
        Me.lblTLC.AutoSize = True
        Me.lblTLC.Location = New System.Drawing.Point(718, 455)
        Me.lblTLC.Name = "lblTLC"
        Me.lblTLC.Size = New System.Drawing.Size(37, 13)
        Me.lblTLC.TabIndex = 44
        Me.lblTLC.Text = "TLC#:"
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.Location = New System.Drawing.Point(722, 482)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(16, 13)
        Me.lblI.TabIndex = 44
        Me.lblI.Text = "I: "
        '
        'lblJ
        '
        Me.lblJ.AutoSize = True
        Me.lblJ.Location = New System.Drawing.Point(756, 481)
        Me.lblJ.Name = "lblJ"
        Me.lblJ.Size = New System.Drawing.Size(18, 13)
        Me.lblJ.TabIndex = 44
        Me.lblJ.Text = "J: "
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(722, 533)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(20, 13)
        Me.lblX.TabIndex = 44
        Me.lblX.Text = "X: "
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(759, 533)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(20, 13)
        Me.lblY.TabIndex = 44
        Me.lblY.Text = "Y: "
        '
        'lblArrayIndex
        '
        Me.lblArrayIndex.AutoSize = True
        Me.lblArrayIndex.Location = New System.Drawing.Point(774, 455)
        Me.lblArrayIndex.Name = "lblArrayIndex"
        Me.lblArrayIndex.Size = New System.Drawing.Size(87, 13)
        Me.lblArrayIndex.TabIndex = 44
        Me.lblArrayIndex.Text = "pixelArray Index: "
        '
        'btnDump
        '
        Me.btnDump.Location = New System.Drawing.Point(191, 160)
        Me.btnDump.Name = "btnDump"
        Me.btnDump.Size = New System.Drawing.Size(83, 23)
        Me.btnDump.TabIndex = 45
        Me.btnDump.Text = "Dump PixelArray"
        Me.btnDump.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cbFlipTLCVertical
        '
        Me.cbFlipTLCVertical.AutoSize = True
        Me.cbFlipTLCVertical.Location = New System.Drawing.Point(492, 373)
        Me.cbFlipTLCVertical.Name = "cbFlipTLCVertical"
        Me.cbFlipTLCVertical.Size = New System.Drawing.Size(126, 17)
        Me.cbFlipTLCVertical.TabIndex = 25
        Me.cbFlipTLCVertical.Text = "Flip TLC Map vertical"
        Me.cbFlipTLCVertical.UseVisualStyleBackColor = True
        '
        'cbFlipTLCHorizontal
        '
        Me.cbFlipTLCHorizontal.AutoSize = True
        Me.cbFlipTLCHorizontal.Location = New System.Drawing.Point(624, 373)
        Me.cbFlipTLCHorizontal.Name = "cbFlipTLCHorizontal"
        Me.cbFlipTLCHorizontal.Size = New System.Drawing.Size(137, 17)
        Me.cbFlipTLCHorizontal.TabIndex = 25
        Me.cbFlipTLCHorizontal.Text = "Flip TLC Map horizontal"
        Me.cbFlipTLCHorizontal.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.btnDump)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblJ)
        Me.Controls.Add(Me.lblI)
        Me.Controls.Add(Me.lblTLC)
        Me.Controls.Add(Me.lblArrayIndex)
        Me.Controls.Add(Me.lblPxl)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.udVerticalFontAdjust)
        Me.Controls.Add(Me.udHorizontalFontAdjust)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSlowDown)
        Me.Controls.Add(Me.cbDebugMode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnShiftLeft)
        Me.Controls.Add(Me.pbSayIt)
        Me.Controls.Add(Me.btnSendFrame)
        Me.Controls.Add(Me.tabContainer)
        Me.Controls.Add(Me.txtFontName)
        Me.Controls.Add(Me.btnChooseFont)
        Me.Controls.Add(Me.btnSayIt)
        Me.Controls.Add(Me.txtSayIt)
        Me.Controls.Add(Me.cbFlipTLCHorizontal)
        Me.Controls.Add(Me.cbFlipTLCVertical)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "The Magnificent Mood Machine Controller v1.0 by Alex Mizell"
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabContainer.ResumeLayout(False)
        Me.tabBitMapView.ResumeLayout(False)
        CType(Me.pbPixelArray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDGView.ResumeLayout(False)
        CType(Me.pbSayIt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents txtSayIt As System.Windows.Forms.TextBox
    Friend WithEvents btnSayIt As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnChooseFont As System.Windows.Forms.Button
    Friend WithEvents txtFontName As System.Windows.Forms.TextBox
    Friend WithEvents tabContainer As System.Windows.Forms.TabControl
    Friend WithEvents tabDGView As System.Windows.Forms.TabPage
    Friend WithEvents tabBitMapView As System.Windows.Forms.TabPage
    Friend WithEvents pbPixelArray As System.Windows.Forms.PictureBox
    Friend WithEvents btnSendFrame As System.Windows.Forms.Button
    Friend WithEvents pbSayIt As System.Windows.Forms.PictureBox
    Friend WithEvents btnShiftLeft As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtSlowDown As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents udHorizontalFontAdjust As System.Windows.Forms.DomainUpDown
    Friend WithEvents udVerticalFontAdjust As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPxl As System.Windows.Forms.Label
    Friend WithEvents lblTLC As System.Windows.Forms.Label
    Friend WithEvents lblI As System.Windows.Forms.Label
    Friend WithEvents lblJ As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblArrayIndex As System.Windows.Forms.Label
    Friend WithEvents btnDump As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cbFlipTLCVertical As System.Windows.Forms.CheckBox
    Friend WithEvents cbFlipTLCHorizontal As System.Windows.Forms.CheckBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
