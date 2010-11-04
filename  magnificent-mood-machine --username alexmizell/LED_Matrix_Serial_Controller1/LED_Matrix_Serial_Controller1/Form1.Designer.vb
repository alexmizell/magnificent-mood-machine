<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dsPixelArray = New System.Data.DataSet
        Me.dtRed = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.dtGreen = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.dtBlue = New System.Data.DataTable
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.txtNumRows = New System.Windows.Forms.TextBox
        Me.lblNumRows = New System.Windows.Forms.Label
        Me.txtNumChannels = New System.Windows.Forms.TextBox
        Me.lblNumChannels = New System.Windows.Forms.Label
        Me.txtNumTLCs = New System.Windows.Forms.TextBox
        Me.lblNumTLCs = New System.Windows.Forms.Label
        Me.txtNumLEDs = New System.Windows.Forms.TextBox
        Me.lblNumLEDs = New System.Windows.Forms.Label
        Me.txtChannelsPerLED = New System.Windows.Forms.TextBox
        Me.lblChannelsPerLED = New System.Windows.Forms.Label
        Me.txtNumColumns = New System.Windows.Forms.TextBox
        Me.lblNumColumns = New System.Windows.Forms.Label
        Me.btnColorSolid = New System.Windows.Forms.Button
        Me.lblOffDelayMS = New System.Windows.Forms.Label
        Me.txtOffDelayMs = New System.Windows.Forms.TextBox
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPixelArray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM3"
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
        Me.TextBox2.Location = New System.Drawing.Point(12, 146)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(572, 47)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(193, 233)
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
        Me.lblFreq.Location = New System.Drawing.Point(471, 341)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(95, 13)
        Me.lblFreq.TabIndex = 11
        Me.lblFreq.Text = "Row On Delay uS:"
        '
        'timerSinGenerator
        '
        Me.timerSinGenerator.Enabled = True
        Me.timerSinGenerator.Interval = 150
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
        Me.lblSinFreq.Size = New System.Drawing.Size(95, 13)
        Me.lblSinFreq.TabIndex = 13
        Me.lblSinFreq.Text = "Sin1 Freq Div: 600"
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
        Me.tbRed.Maximum = 4095
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(193, 45)
        Me.tbRed.TabIndex = 15
        Me.tbRed.TickFrequency = 100
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(46, 377)
        Me.tbGreen.Maximum = 4095
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(193, 45)
        Me.tbGreen.TabIndex = 15
        Me.tbGreen.TickFrequency = 100
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(46, 416)
        Me.tbBlue.Maximum = 4095
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
        Me.txtRowOnDelayMS.Location = New System.Drawing.Point(572, 338)
        Me.txtRowOnDelayMS.Name = "txtRowOnDelayMS"
        Me.txtRowOnDelayMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRowOnDelayMS.Size = New System.Drawing.Size(51, 20)
        Me.txtRowOnDelayMS.TabIndex = 17
        Me.txtRowOnDelayMS.Text = "1400"
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
        Me.dgLEDMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgLEDMatrix.ColumnHeadersVisible = False
        Me.dgLEDMatrix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgLEDMatrix.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgLEDMatrix.Location = New System.Drawing.Point(273, 47)
        Me.dgLEDMatrix.MultiSelect = False
        Me.dgLEDMatrix.Name = "dgLEDMatrix"
        Me.dgLEDMatrix.RowHeadersVisible = False
        Me.dgLEDMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLEDMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgLEDMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgLEDMatrix.ShowEditingIcon = False
        Me.dgLEDMatrix.Size = New System.Drawing.Size(273, 233)
        Me.dgLEDMatrix.TabIndex = 18
        '
        'Column0
        '
        Me.Column0.HeaderText = "Column0"
        Me.Column0.Name = "Column0"
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
        'dsPixelArray
        '
        Me.dsPixelArray.DataSetName = "dsPixelArray"
        Me.dsPixelArray.Tables.AddRange(New System.Data.DataTable() {Me.dtRed, Me.dtGreen, Me.dtBlue})
        '
        'dtRed
        '
        Me.dtRed.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.dtRed.TableName = "dtRed"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Column0"
        Me.DataColumn1.ColumnName = "Column0"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Column1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Column2"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Column3"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Column4"
        '
        'dtGreen
        '
        Me.dtGreen.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.dtGreen.TableName = "dtGreen"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Column0"
        Me.DataColumn6.ColumnName = "Column0"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Column1"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Column2"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Column3"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Column4"
        '
        'dtBlue
        '
        Me.dtBlue.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.dtBlue.TableName = "dtBlue"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "Column0"
        Me.DataColumn11.ColumnName = "Column0"
        Me.DataColumn11.DataType = GetType(Short)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Column1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Column2"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Column3"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Column4"
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
        Me.txtNumTLCs.Location = New System.Drawing.Point(408, 338)
        Me.txtNumTLCs.Name = "txtNumTLCs"
        Me.txtNumTLCs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCs.TabIndex = 19
        Me.txtNumTLCs.Text = "1"
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
        'txtChannelsPerLED
        '
        Me.txtChannelsPerLED.Location = New System.Drawing.Point(408, 391)
        Me.txtChannelsPerLED.Name = "txtChannelsPerLED"
        Me.txtChannelsPerLED.Size = New System.Drawing.Size(46, 20)
        Me.txtChannelsPerLED.TabIndex = 19
        Me.txtChannelsPerLED.Text = "3"
        Me.txtChannelsPerLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.lblOffDelayMS.Location = New System.Drawing.Point(471, 368)
        Me.lblOffDelayMS.Name = "lblOffDelayMS"
        Me.lblOffDelayMS.Size = New System.Drawing.Size(95, 13)
        Me.lblOffDelayMS.TabIndex = 11
        Me.lblOffDelayMS.Text = "Row Off Delay uS:"
        '
        'txtOffDelayMs
        '
        Me.txtOffDelayMs.Location = New System.Drawing.Point(572, 365)
        Me.txtOffDelayMs.Name = "txtOffDelayMs"
        Me.txtOffDelayMs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOffDelayMs.Size = New System.Drawing.Size(51, 20)
        Me.txtOffDelayMs.TabIndex = 17
        Me.txtOffDelayMs.Text = "1000"
        Me.txtOffDelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(788, 534)
        Me.Controls.Add(Me.btnColorSolid)
        Me.Controls.Add(Me.lblChannelsPerLED)
        Me.Controls.Add(Me.lblNumColumns)
        Me.Controls.Add(Me.lblNumLEDs)
        Me.Controls.Add(Me.lblNumTLCs)
        Me.Controls.Add(Me.lblNumChannels)
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.txtChannelsPerLED)
        Me.Controls.Add(Me.txtNumColumns)
        Me.Controls.Add(Me.txtNumLEDs)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLEDMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPixelArray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBlue, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Column0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsPixelArray As System.Data.DataSet
    Friend WithEvents dtRed As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents dtGreen As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents dtBlue As System.Data.DataTable
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents txtNumRows As System.Windows.Forms.TextBox
    Friend WithEvents lblNumRows As System.Windows.Forms.Label
    Friend WithEvents txtNumChannels As System.Windows.Forms.TextBox
    Friend WithEvents lblNumChannels As System.Windows.Forms.Label
    Friend WithEvents txtNumTLCs As System.Windows.Forms.TextBox
    Friend WithEvents lblNumTLCs As System.Windows.Forms.Label
    Friend WithEvents txtNumLEDs As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLEDs As System.Windows.Forms.Label
    Friend WithEvents txtChannelsPerLED As System.Windows.Forms.TextBox
    Friend WithEvents lblChannelsPerLED As System.Windows.Forms.Label
    Friend WithEvents txtNumColumns As System.Windows.Forms.TextBox
    Friend WithEvents lblNumColumns As System.Windows.Forms.Label
    Friend WithEvents btnColorSolid As System.Windows.Forms.Button
    Friend WithEvents lblOffDelayMS As System.Windows.Forms.Label
    Friend WithEvents txtOffDelayMs As System.Windows.Forms.TextBox

End Class
