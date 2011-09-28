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
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPickColor = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.timerSinGenerator = New System.Windows.Forms.Timer(Me.components)
        Me.hsSinFreqDiv = New System.Windows.Forms.HScrollBar()
        Me.lblSinFreq = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.tbRed = New System.Windows.Forms.TrackBar()
        Me.tbGreen = New System.Windows.Forms.TrackBar()
        Me.tbBlue = New System.Windows.Forms.TrackBar()
        Me.txtRowOn = New System.Windows.Forms.TextBox()
        Me.btnColorSolid = New System.Windows.Forms.Button()
        Me.lblOffDelayMS = New System.Windows.Forms.Label()
        Me.txtRowOff = New System.Windows.Forms.TextBox()
        Me.txtSayIt = New System.Windows.Forms.TextBox()
        Me.btnSayIt = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnChooseFont = New System.Windows.Forms.Button()
        Me.txtFontName = New System.Windows.Forms.TextBox()
        Me.tabContainer = New System.Windows.Forms.TabControl()
        Me.tabBitMapView = New System.Windows.Forms.TabPage()
        Me.pbPixelArray = New System.Windows.Forms.PictureBox()
        Me.tabMatrixSetup = New System.Windows.Forms.TabPage()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbSpectrumAnalyzerCutoff = New System.Windows.Forms.TrackBar()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbSpectrumAnalyzerSens = New System.Windows.Forms.TrackBar()
        Me.cbFlipTLCHorizontal = New System.Windows.Forms.CheckBox()
        Me.cbFlipTLCVertical = New System.Windows.Forms.CheckBox()
        Me.cbChannels = New System.Windows.Forms.ComboBox()
        Me.chkFlipHorizontal = New System.Windows.Forms.CheckBox()
        Me.comboInputSelect = New System.Windows.Forms.ComboBox()
        Me.chkFlipVertical = New System.Windows.Forms.CheckBox()
        Me.txtNumChannelsPerLED = New System.Windows.Forms.TextBox()
        Me.lblChannelsPerLED = New System.Windows.Forms.Label()
        Me.lblNumColumns = New System.Windows.Forms.Label()
        Me.lblNumLEDs = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumTLCs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumChannels = New System.Windows.Forms.Label()
        Me.lblNumRows = New System.Windows.Forms.Label()
        Me.txtNumColumns = New System.Windows.Forms.TextBox()
        Me.txtNumLEDs = New System.Windows.Forms.TextBox()
        Me.txtMatrixRows = New System.Windows.Forms.TextBox()
        Me.txtNumTLCRows = New System.Windows.Forms.TextBox()
        Me.txtMatrixCols = New System.Windows.Forms.TextBox()
        Me.txtNumTLCCols = New System.Windows.Forms.TextBox()
        Me.txtNumTLCs = New System.Windows.Forms.TextBox()
        Me.txtNumChannels = New System.Windows.Forms.TextBox()
        Me.txtNumRows = New System.Windows.Forms.TextBox()
        Me.tabJunk = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSlowDown = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAA = New System.Windows.Forms.CheckBox()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSendFrame = New System.Windows.Forms.Button()
        Me.pbSayIt = New System.Windows.Forms.PictureBox()
        Me.btnShiftLeft = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.udVerticalFontAdjust = New System.Windows.Forms.DomainUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDump = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFlashbulbs = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.cbRandom = New System.Windows.Forms.CheckBox()
        Me.tbRowOn = New System.Windows.Forms.TrackBar()
        Me.tbRowOff = New System.Windows.Forms.TrackBar()
        Me.cbEnableSpectrum = New System.Windows.Forms.CheckBox()
        Me.cbRainbow = New System.Windows.Forms.CheckBox()
        Me.cbVis1 = New System.Windows.Forms.CheckBox()
        Me.pbMiniMe = New System.Windows.Forms.PictureBox()
        Me.lblBytesPerFrame = New System.Windows.Forms.Label()
        Me.lblAvgBytesPerFrame = New System.Windows.Forms.Label()
        Me.pbSerialOut = New System.Windows.Forms.ProgressBar()
        Me.pbSerialIn = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbOnRange = New System.Windows.Forms.CheckBox()
        Me.cbOffRange = New System.Windows.Forms.CheckBox()
        Me.lblSelectedPixel = New System.Windows.Forms.Label()
        Me.timerSpectrum = New System.Windows.Forms.Timer(Me.components)
        Me.tbHue = New System.Windows.Forms.TrackBar()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblHueValue = New System.Windows.Forms.Label()
        Me.cbRainbow2 = New System.Windows.Forms.CheckBox()
        Me.tbHueSpeed = New System.Windows.Forms.TrackBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbRainbowWave = New System.Windows.Forms.CheckBox()
        Me.lblBassLatency = New System.Windows.Forms.Label()
        Me.lblChannelPosition = New System.Windows.Forms.Label()
        Me.btnFortune = New System.Windows.Forms.Button()
        Me.cbScrollRight = New System.Windows.Forms.CheckBox()
        Me.cbstars = New System.Windows.Forms.CheckBox()
        Me.cbGameOfLife = New System.Windows.Forms.CheckBox()
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabContainer.SuspendLayout()
        Me.tabBitMapView.SuspendLayout()
        CType(Me.pbPixelArray, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMatrixSetup.SuspendLayout()
        CType(Me.tbSpectrumAnalyzerCutoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSpectrumAnalyzerSens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabJunk.SuspendLayout()
        CType(Me.pbSayIt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRowOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRowOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbHue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbHueSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBox1.BackColor = System.Drawing.Color.Aqua
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.ForeColor = System.Drawing.Color.Aqua
        Me.TextBox1.Location = New System.Drawing.Point(12, 37)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 47)
        Me.TextBox1.TabIndex = 0
        '
        'btnPickColor
        '
        Me.btnPickColor.Location = New System.Drawing.Point(12, 90)
        Me.btnPickColor.Name = "btnPickColor"
        Me.btnPickColor.Size = New System.Drawing.Size(80, 23)
        Me.btnPickColor.TabIndex = 1
        Me.btnPickColor.Text = "Pick Color"
        Me.btnPickColor.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(20, 36)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSerial.Size = New System.Drawing.Size(200, 254)
        Me.txtSerial.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(919, 62)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(73, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(227, 48)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(15, 13)
        Me.lblR.TabIndex = 10
        Me.lblR.Text = "R"
        Me.lblR.Visible = False
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.ForeColor = System.Drawing.Color.Lime
        Me.lblG.Location = New System.Drawing.Point(227, 88)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(15, 13)
        Me.lblG.TabIndex = 10
        Me.lblG.Text = "G"
        Me.lblG.Visible = False
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(228, 129)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(14, 13)
        Me.lblB.TabIndex = 10
        Me.lblB.Text = "B"
        Me.lblB.Visible = False
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(294, 383)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(49, 13)
        Me.lblFreq.TabIndex = 11
        Me.lblFreq.Text = "Row On:"
        '
        'timerSinGenerator
        '
        Me.timerSinGenerator.Interval = 2
        '
        'hsSinFreqDiv
        '
        Me.hsSinFreqDiv.Location = New System.Drawing.Point(233, 178)
        Me.hsSinFreqDiv.Maximum = 5000
        Me.hsSinFreqDiv.Minimum = 1
        Me.hsSinFreqDiv.Name = "hsSinFreqDiv"
        Me.hsSinFreqDiv.Size = New System.Drawing.Size(153, 19)
        Me.hsSinFreqDiv.TabIndex = 12
        Me.hsSinFreqDiv.Value = 2000
        Me.hsSinFreqDiv.Visible = False
        '
        'lblSinFreq
        '
        Me.lblSinFreq.AutoSize = True
        Me.lblSinFreq.Location = New System.Drawing.Point(395, 182)
        Me.lblSinFreq.Name = "lblSinFreq"
        Me.lblSinFreq.Size = New System.Drawing.Size(101, 13)
        Me.lblSinFreq.TabIndex = 13
        Me.lblSinFreq.Text = "Sin1 Freq Div: 2000"
        Me.lblSinFreq.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(443, 47)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Sin1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(443, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Sin1"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(443, 130)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Sin1"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'tbRed
        '
        Me.tbRed.LargeChange = 1
        Me.tbRed.Location = New System.Drawing.Point(248, 44)
        Me.tbRed.Maximum = 255
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(193, 45)
        Me.tbRed.TabIndex = 15
        Me.tbRed.TickFrequency = 100
        Me.tbRed.Visible = False
        '
        'tbGreen
        '
        Me.tbGreen.Location = New System.Drawing.Point(248, 84)
        Me.tbGreen.Maximum = 255
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(193, 45)
        Me.tbGreen.TabIndex = 15
        Me.tbGreen.TickFrequency = 100
        Me.tbGreen.Visible = False
        '
        'tbBlue
        '
        Me.tbBlue.Location = New System.Drawing.Point(248, 125)
        Me.tbBlue.Maximum = 255
        Me.tbBlue.Name = "tbBlue"
        Me.tbBlue.Size = New System.Drawing.Size(193, 45)
        Me.tbBlue.TabIndex = 15
        Me.tbBlue.TickFrequency = 100
        Me.tbBlue.Visible = False
        '
        'txtRowOn
        '
        Me.txtRowOn.Location = New System.Drawing.Point(685, 373)
        Me.txtRowOn.Name = "txtRowOn"
        Me.txtRowOn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRowOn.Size = New System.Drawing.Size(59, 20)
        Me.txtRowOn.TabIndex = 17
        Me.txtRowOn.Text = "43"
        Me.txtRowOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnColorSolid
        '
        Me.btnColorSolid.Location = New System.Drawing.Point(12, 119)
        Me.btnColorSolid.Name = "btnColorSolid"
        Me.btnColorSolid.Size = New System.Drawing.Size(80, 23)
        Me.btnColorSolid.TabIndex = 21
        Me.btnColorSolid.Text = "Fill"
        Me.btnColorSolid.UseVisualStyleBackColor = True
        '
        'lblOffDelayMS
        '
        Me.lblOffDelayMS.AutoSize = True
        Me.lblOffDelayMS.Location = New System.Drawing.Point(294, 410)
        Me.lblOffDelayMS.Name = "lblOffDelayMS"
        Me.lblOffDelayMS.Size = New System.Drawing.Size(49, 13)
        Me.lblOffDelayMS.TabIndex = 11
        Me.lblOffDelayMS.Text = "Row Off:"
        '
        'txtRowOff
        '
        Me.txtRowOff.Location = New System.Drawing.Point(685, 404)
        Me.txtRowOff.Name = "txtRowOff"
        Me.txtRowOff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRowOff.Size = New System.Drawing.Size(59, 20)
        Me.txtRowOff.TabIndex = 17
        Me.txtRowOff.Text = "60"
        Me.txtRowOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSayIt
        '
        Me.txtSayIt.BackColor = System.Drawing.Color.Black
        Me.txtSayIt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSayIt.ForeColor = System.Drawing.Color.Cyan
        Me.txtSayIt.Location = New System.Drawing.Point(32, 481)
        Me.txtSayIt.Multiline = True
        Me.txtSayIt.Name = "txtSayIt"
        Me.txtSayIt.Size = New System.Drawing.Size(263, 69)
        Me.txtSayIt.TabIndex = 26
        Me.txtSayIt.Text = "This is a short test message."
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
        Me.tabContainer.Controls.Add(Me.tabBitMapView)
        Me.tabContainer.Controls.Add(Me.tabMatrixSetup)
        Me.tabContainer.Controls.Add(Me.tabJunk)
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
        Me.tabBitMapView.Text = "Matrix view"
        Me.tabBitMapView.UseVisualStyleBackColor = True
        '
        'pbPixelArray
        '
        Me.pbPixelArray.Location = New System.Drawing.Point(1, 3)
        Me.pbPixelArray.Name = "pbPixelArray"
        Me.pbPixelArray.Size = New System.Drawing.Size(500, 300)
        Me.pbPixelArray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPixelArray.TabIndex = 0
        Me.pbPixelArray.TabStop = False
        '
        'tabMatrixSetup
        '
        Me.tabMatrixSetup.Controls.Add(Me.Label28)
        Me.tabMatrixSetup.Controls.Add(Me.Label26)
        Me.tabMatrixSetup.Controls.Add(Me.Label27)
        Me.tabMatrixSetup.Controls.Add(Me.tbSpectrumAnalyzerCutoff)
        Me.tabMatrixSetup.Controls.Add(Me.Label25)
        Me.tabMatrixSetup.Controls.Add(Me.tbSpectrumAnalyzerSens)
        Me.tabMatrixSetup.Controls.Add(Me.cbFlipTLCHorizontal)
        Me.tabMatrixSetup.Controls.Add(Me.cbFlipTLCVertical)
        Me.tabMatrixSetup.Controls.Add(Me.cbChannels)
        Me.tabMatrixSetup.Controls.Add(Me.chkFlipHorizontal)
        Me.tabMatrixSetup.Controls.Add(Me.comboInputSelect)
        Me.tabMatrixSetup.Controls.Add(Me.chkFlipVertical)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumChannelsPerLED)
        Me.tabMatrixSetup.Controls.Add(Me.lblChannelsPerLED)
        Me.tabMatrixSetup.Controls.Add(Me.lblNumColumns)
        Me.tabMatrixSetup.Controls.Add(Me.lblNumLEDs)
        Me.tabMatrixSetup.Controls.Add(Me.Label4)
        Me.tabMatrixSetup.Controls.Add(Me.Label2)
        Me.tabMatrixSetup.Controls.Add(Me.lblNumTLCs)
        Me.tabMatrixSetup.Controls.Add(Me.Label3)
        Me.tabMatrixSetup.Controls.Add(Me.Label1)
        Me.tabMatrixSetup.Controls.Add(Me.lblNumChannels)
        Me.tabMatrixSetup.Controls.Add(Me.lblNumRows)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumColumns)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumLEDs)
        Me.tabMatrixSetup.Controls.Add(Me.txtMatrixRows)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumTLCRows)
        Me.tabMatrixSetup.Controls.Add(Me.txtMatrixCols)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumTLCCols)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumTLCs)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumChannels)
        Me.tabMatrixSetup.Controls.Add(Me.txtNumRows)
        Me.tabMatrixSetup.Location = New System.Drawing.Point(4, 22)
        Me.tabMatrixSetup.Name = "tabMatrixSetup"
        Me.tabMatrixSetup.Size = New System.Drawing.Size(502, 304)
        Me.tabMatrixSetup.TabIndex = 2
        Me.tabMatrixSetup.Text = "Matrix setup"
        Me.tabMatrixSetup.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(332, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(150, 13)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Spectrum Analyzer Freq Cutoff"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 193)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 13)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "ASIO Input Channel:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(332, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(145, 13)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "Spectrum Analyzer Sensitivity"
        '
        'tbSpectrumAnalyzerCutoff
        '
        Me.tbSpectrumAnalyzerCutoff.Location = New System.Drawing.Point(330, 103)
        Me.tbSpectrumAnalyzerCutoff.Maximum = 2000
        Me.tbSpectrumAnalyzerCutoff.Minimum = 25
        Me.tbSpectrumAnalyzerCutoff.Name = "tbSpectrumAnalyzerCutoff"
        Me.tbSpectrumAnalyzerCutoff.Size = New System.Drawing.Size(147, 45)
        Me.tbSpectrumAnalyzerCutoff.TabIndex = 63
        Me.tbSpectrumAnalyzerCutoff.TickFrequency = 200
        Me.tbSpectrumAnalyzerCutoff.Value = 300
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 160)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "ASIO Input Device:"
        '
        'tbSpectrumAnalyzerSens
        '
        Me.tbSpectrumAnalyzerSens.Location = New System.Drawing.Point(330, 36)
        Me.tbSpectrumAnalyzerSens.Maximum = 20
        Me.tbSpectrumAnalyzerSens.Name = "tbSpectrumAnalyzerSens"
        Me.tbSpectrumAnalyzerSens.Size = New System.Drawing.Size(147, 45)
        Me.tbSpectrumAnalyzerSens.TabIndex = 63
        Me.tbSpectrumAnalyzerSens.Value = 6
        '
        'cbFlipTLCHorizontal
        '
        Me.cbFlipTLCHorizontal.AutoSize = True
        Me.cbFlipTLCHorizontal.Location = New System.Drawing.Point(340, 261)
        Me.cbFlipTLCHorizontal.Name = "cbFlipTLCHorizontal"
        Me.cbFlipTLCHorizontal.Size = New System.Drawing.Size(137, 17)
        Me.cbFlipTLCHorizontal.TabIndex = 46
        Me.cbFlipTLCHorizontal.Text = "Flip TLC Map horizontal"
        Me.cbFlipTLCHorizontal.UseVisualStyleBackColor = True
        '
        'cbFlipTLCVertical
        '
        Me.cbFlipTLCVertical.AutoSize = True
        Me.cbFlipTLCVertical.Location = New System.Drawing.Point(208, 261)
        Me.cbFlipTLCVertical.Name = "cbFlipTLCVertical"
        Me.cbFlipTLCVertical.Size = New System.Drawing.Size(126, 17)
        Me.cbFlipTLCVertical.TabIndex = 47
        Me.cbFlipTLCVertical.Text = "Flip TLC Map vertical"
        Me.cbFlipTLCVertical.UseVisualStyleBackColor = True
        '
        'cbChannels
        '
        Me.cbChannels.FormattingEnabled = True
        Me.cbChannels.Location = New System.Drawing.Point(127, 190)
        Me.cbChannels.Name = "cbChannels"
        Me.cbChannels.Size = New System.Drawing.Size(181, 21)
        Me.cbChannels.TabIndex = 61
        '
        'chkFlipHorizontal
        '
        Me.chkFlipHorizontal.AutoSize = True
        Me.chkFlipHorizontal.Location = New System.Drawing.Point(105, 261)
        Me.chkFlipHorizontal.Name = "chkFlipHorizontal"
        Me.chkFlipHorizontal.Size = New System.Drawing.Size(90, 17)
        Me.chkFlipHorizontal.TabIndex = 44
        Me.chkFlipHorizontal.Text = "Flip horizontal"
        Me.chkFlipHorizontal.UseVisualStyleBackColor = True
        '
        'comboInputSelect
        '
        Me.comboInputSelect.FormattingEnabled = True
        Me.comboInputSelect.Location = New System.Drawing.Point(127, 158)
        Me.comboInputSelect.Name = "comboInputSelect"
        Me.comboInputSelect.Size = New System.Drawing.Size(181, 21)
        Me.comboInputSelect.TabIndex = 61
        '
        'chkFlipVertical
        '
        Me.chkFlipVertical.AutoSize = True
        Me.chkFlipVertical.Location = New System.Drawing.Point(20, 261)
        Me.chkFlipVertical.Name = "chkFlipVertical"
        Me.chkFlipVertical.Size = New System.Drawing.Size(79, 17)
        Me.chkFlipVertical.TabIndex = 45
        Me.chkFlipVertical.Text = "Flip vertical"
        Me.chkFlipVertical.UseVisualStyleBackColor = True
        '
        'txtNumChannelsPerLED
        '
        Me.txtNumChannelsPerLED.Location = New System.Drawing.Point(107, 67)
        Me.txtNumChannelsPerLED.Name = "txtNumChannelsPerLED"
        Me.txtNumChannelsPerLED.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannelsPerLED.TabIndex = 43
        Me.txtNumChannelsPerLED.Text = "3"
        Me.txtNumChannelsPerLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblChannelsPerLED
        '
        Me.lblChannelsPerLED.AutoSize = True
        Me.lblChannelsPerLED.Location = New System.Drawing.Point(4, 70)
        Me.lblChannelsPerLED.Name = "lblChannelsPerLED"
        Me.lblChannelsPerLED.Size = New System.Drawing.Size(97, 13)
        Me.lblChannelsPerLED.TabIndex = 36
        Me.lblChannelsPerLED.Text = "Channels Per LED:"
        Me.lblChannelsPerLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumColumns
        '
        Me.lblNumColumns.AutoSize = True
        Me.lblNumColumns.Location = New System.Drawing.Point(26, 97)
        Me.lblNumColumns.Name = "lblNumColumns"
        Me.lblNumColumns.Size = New System.Drawing.Size(75, 13)
        Me.lblNumColumns.TabIndex = 37
        Me.lblNumColumns.Text = "Num Columns:"
        Me.lblNumColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumLEDs
        '
        Me.lblNumLEDs.AutoSize = True
        Me.lblNumLEDs.Location = New System.Drawing.Point(193, 123)
        Me.lblNumLEDs.Name = "lblNumLEDs"
        Me.lblNumLEDs.Size = New System.Drawing.Size(61, 13)
        Me.lblNumLEDs.TabIndex = 34
        Me.lblNumLEDs.Text = "Num LEDs:"
        Me.lblNumLEDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "matrixRows: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "numTLCRows: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumTLCs
        '
        Me.lblNumTLCs.AutoSize = True
        Me.lblNumTLCs.Location = New System.Drawing.Point(39, 17)
        Me.lblNumTLCs.Name = "lblNumTLCs"
        Me.lblNumTLCs.Size = New System.Drawing.Size(60, 13)
        Me.lblNumTLCs.TabIndex = 41
        Me.lblNumTLCs.Text = "Num TLCs:"
        Me.lblNumTLCs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "matrixCols:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "numTLCCols: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumChannels
        '
        Me.lblNumChannels.AutoSize = True
        Me.lblNumChannels.Location = New System.Drawing.Point(22, 44)
        Me.lblNumChannels.Name = "lblNumChannels"
        Me.lblNumChannels.Size = New System.Drawing.Size(79, 13)
        Me.lblNumChannels.TabIndex = 40
        Me.lblNumChannels.Text = "Num Channels:"
        Me.lblNumChannels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(39, 124)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(62, 13)
        Me.lblNumRows.TabIndex = 33
        Me.lblNumRows.Text = "Num Rows:"
        Me.lblNumRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumColumns
        '
        Me.txtNumColumns.Enabled = False
        Me.txtNumColumns.Location = New System.Drawing.Point(107, 94)
        Me.txtNumColumns.Name = "txtNumColumns"
        Me.txtNumColumns.Size = New System.Drawing.Size(46, 20)
        Me.txtNumColumns.TabIndex = 26
        Me.txtNumColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumLEDs
        '
        Me.txtNumLEDs.Enabled = False
        Me.txtNumLEDs.Location = New System.Drawing.Point(262, 120)
        Me.txtNumLEDs.Name = "txtNumLEDs"
        Me.txtNumLEDs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumLEDs.TabIndex = 27
        Me.txtNumLEDs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMatrixRows
        '
        Me.txtMatrixRows.Enabled = False
        Me.txtMatrixRows.Location = New System.Drawing.Point(262, 65)
        Me.txtMatrixRows.Name = "txtMatrixRows"
        Me.txtMatrixRows.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixRows.TabIndex = 24
        Me.txtMatrixRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumTLCRows
        '
        Me.txtNumTLCRows.Location = New System.Drawing.Point(262, 14)
        Me.txtNumTLCRows.Name = "txtNumTLCRows"
        Me.txtNumTLCRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCRows.TabIndex = 25
        Me.txtNumTLCRows.Text = "3"
        Me.txtNumTLCRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMatrixCols
        '
        Me.txtMatrixCols.Enabled = False
        Me.txtMatrixCols.Location = New System.Drawing.Point(262, 92)
        Me.txtMatrixCols.Name = "txtMatrixCols"
        Me.txtMatrixCols.Size = New System.Drawing.Size(46, 20)
        Me.txtMatrixCols.TabIndex = 28
        Me.txtMatrixCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumTLCCols
        '
        Me.txtNumTLCCols.Location = New System.Drawing.Point(262, 41)
        Me.txtNumTLCCols.Name = "txtNumTLCCols"
        Me.txtNumTLCCols.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCCols.TabIndex = 31
        Me.txtNumTLCCols.Text = "4"
        Me.txtNumTLCCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumTLCs
        '
        Me.txtNumTLCs.Enabled = False
        Me.txtNumTLCs.Location = New System.Drawing.Point(107, 14)
        Me.txtNumTLCs.Name = "txtNumTLCs"
        Me.txtNumTLCs.Size = New System.Drawing.Size(46, 20)
        Me.txtNumTLCs.TabIndex = 32
        Me.txtNumTLCs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumChannels
        '
        Me.txtNumChannels.Location = New System.Drawing.Point(107, 41)
        Me.txtNumChannels.Name = "txtNumChannels"
        Me.txtNumChannels.Size = New System.Drawing.Size(46, 20)
        Me.txtNumChannels.TabIndex = 29
        Me.txtNumChannels.Text = "15"
        Me.txtNumChannels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumRows
        '
        Me.txtNumRows.Location = New System.Drawing.Point(107, 121)
        Me.txtNumRows.Name = "txtNumRows"
        Me.txtNumRows.Size = New System.Drawing.Size(46, 20)
        Me.txtNumRows.TabIndex = 30
        Me.txtNumRows.Text = "5"
        Me.txtNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabJunk
        '
        Me.tabJunk.Controls.Add(Me.Label9)
        Me.tabJunk.Controls.Add(Me.txtSlowDown)
        Me.tabJunk.Controls.Add(Me.Label10)
        Me.tabJunk.Controls.Add(Me.cbAA)
        Me.tabJunk.Controls.Add(Me.txtSerial)
        Me.tabJunk.Controls.Add(Me.tbRed)
        Me.tabJunk.Controls.Add(Me.lblR)
        Me.tabJunk.Controls.Add(Me.lblG)
        Me.tabJunk.Controls.Add(Me.lblB)
        Me.tabJunk.Controls.Add(Me.CheckBox1)
        Me.tabJunk.Controls.Add(Me.CheckBox2)
        Me.tabJunk.Controls.Add(Me.CheckBox3)
        Me.tabJunk.Controls.Add(Me.tbGreen)
        Me.tabJunk.Controls.Add(Me.tbBlue)
        Me.tabJunk.Controls.Add(Me.hsSinFreqDiv)
        Me.tabJunk.Controls.Add(Me.lblSinFreq)
        Me.tabJunk.Controls.Add(Me.cbDebugMode)
        Me.tabJunk.Location = New System.Drawing.Point(4, 22)
        Me.tabJunk.Name = "tabJunk"
        Me.tabJunk.Size = New System.Drawing.Size(502, 304)
        Me.tabJunk.TabIndex = 3
        Me.tabJunk.Text = " Debug"
        Me.tabJunk.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(243, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Slow Down:"
        '
        'txtSlowDown
        '
        Me.txtSlowDown.Location = New System.Drawing.Point(239, 266)
        Me.txtSlowDown.Name = "txtSlowDown"
        Me.txtSlowDown.Size = New System.Drawing.Size(72, 20)
        Me.txtSlowDown.TabIndex = 55
        Me.txtSlowDown.Text = "50"
        Me.txtSlowDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Debug Messages:"
        '
        'cbAA
        '
        Me.cbAA.AutoSize = True
        Me.cbAA.Location = New System.Drawing.Point(417, 284)
        Me.cbAA.Name = "cbAA"
        Me.cbAA.Size = New System.Drawing.Size(79, 17)
        Me.cbAA.TabIndex = 1
        Me.cbAA.Text = "Antialiasing"
        Me.cbAA.UseVisualStyleBackColor = True
        Me.cbAA.Visible = False
        '
        'cbDebugMode
        '
        Me.cbDebugMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbDebugMode.AutoSize = True
        Me.cbDebugMode.Location = New System.Drawing.Point(237, 220)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(73, 23)
        Me.cbDebugMode.TabIndex = 39
        Me.cbDebugMode.Text = "     Debug   "
        Me.cbDebugMode.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(780, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "O:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(780, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "I:"
        '
        'btnSendFrame
        '
        Me.btnSendFrame.Location = New System.Drawing.Point(829, 62)
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
        Me.btnShiftLeft.Location = New System.Drawing.Point(29, 331)
        Me.btnShiftLeft.Name = "btnShiftLeft"
        Me.btnShiftLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnShiftLeft.TabIndex = 34
        Me.btnShiftLeft.Text = "Left"
        Me.btnShiftLeft.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Right"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(110, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Up"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(110, 360)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Down"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Matrix Shift"
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
        Me.udVerticalFontAdjust.Location = New System.Drawing.Point(312, 500)
        Me.udVerticalFontAdjust.Name = "udVerticalFontAdjust"
        Me.udVerticalFontAdjust.ReadOnly = True
        Me.udVerticalFontAdjust.Size = New System.Drawing.Size(52, 20)
        Me.udVerticalFontAdjust.TabIndex = 42
        Me.udVerticalFontAdjust.Text = "-3"
        Me.udVerticalFontAdjust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 481)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Vertical Adjust:"
        '
        'btnDump
        '
        Me.btnDump.Location = New System.Drawing.Point(919, 94)
        Me.btnDump.Name = "btnDump"
        Me.btnDump.Size = New System.Drawing.Size(73, 23)
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
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpenToolStripMenuItem.Text = "Open Bitmap"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SaveToolStripMenuItem.Text = "Save Bitmap"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Image1"
        Me.OpenFileDialog1.InitialDirectory = "C:\MoodMachine"
        '
        'btnFlashbulbs
        '
        Me.btnFlashbulbs.Location = New System.Drawing.Point(830, 95)
        Me.btnFlashbulbs.Name = "btnFlashbulbs"
        Me.btnFlashbulbs.Size = New System.Drawing.Size(80, 23)
        Me.btnFlashbulbs.TabIndex = 1
        Me.btnFlashbulbs.Text = "Flashbulbs"
        Me.btnFlashbulbs.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(117, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Hot Keys"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(68, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(101, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(133, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(164, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "4"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(198, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "5"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(61, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Lime
        Me.PictureBox2.Location = New System.Drawing.Point(94, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Blue
        Me.PictureBox3.Location = New System.Drawing.Point(127, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(158, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox4.TabIndex = 49
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox5.Location = New System.Drawing.Point(191, 189)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox5.TabIndex = 49
        Me.PictureBox5.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 219)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "6"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(101, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "7"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(133, 219)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "8"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(164, 220)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "9"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(198, 220)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "0"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Teal
        Me.PictureBox6.Location = New System.Drawing.Point(61, 235)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox6.TabIndex = 49
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(94, 235)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox7.TabIndex = 49
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox8.Location = New System.Drawing.Point(127, 235)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox8.TabIndex = 49
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox9.Location = New System.Drawing.Point(158, 235)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox9.TabIndex = 49
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Black
        Me.PictureBox10.Location = New System.Drawing.Point(191, 235)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox10.TabIndex = 49
        Me.PictureBox10.TabStop = False
        '
        'cbRandom
        '
        Me.cbRandom.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbRandom.AutoSize = True
        Me.cbRandom.Location = New System.Drawing.Point(831, 127)
        Me.cbRandom.Name = "cbRandom"
        Me.cbRandom.Size = New System.Drawing.Size(83, 23)
        Me.cbRandom.TabIndex = 50
        Me.cbRandom.Text = "   RGB Rain   "
        Me.cbRandom.UseVisualStyleBackColor = True
        '
        'tbRowOn
        '
        Me.tbRowOn.Location = New System.Drawing.Point(339, 373)
        Me.tbRowOn.Maximum = 100
        Me.tbRowOn.Name = "tbRowOn"
        Me.tbRowOn.Size = New System.Drawing.Size(347, 45)
        Me.tbRowOn.TabIndex = 51
        Me.tbRowOn.TickFrequency = 20
        '
        'tbRowOff
        '
        Me.tbRowOff.Location = New System.Drawing.Point(339, 404)
        Me.tbRowOff.Maximum = 100
        Me.tbRowOff.Name = "tbRowOff"
        Me.tbRowOff.Size = New System.Drawing.Size(347, 45)
        Me.tbRowOff.TabIndex = 51
        Me.tbRowOff.TickFrequency = 20
        '
        'cbEnableSpectrum
        '
        Me.cbEnableSpectrum.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbEnableSpectrum.AutoSize = True
        Me.cbEnableSpectrum.Location = New System.Drawing.Point(920, 127)
        Me.cbEnableSpectrum.Name = "cbEnableSpectrum"
        Me.cbEnableSpectrum.Size = New System.Drawing.Size(74, 23)
        Me.cbEnableSpectrum.TabIndex = 52
        Me.cbEnableSpectrum.Text = "  Spectrum  "
        Me.cbEnableSpectrum.UseVisualStyleBackColor = True
        '
        'cbRainbow
        '
        Me.cbRainbow.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbRainbow.AutoSize = True
        Me.cbRainbow.Location = New System.Drawing.Point(832, 215)
        Me.cbRainbow.Name = "cbRainbow"
        Me.cbRainbow.Size = New System.Drawing.Size(90, 23)
        Me.cbRainbow.TabIndex = 50
        Me.cbRainbow.Text = "Rainbow Solids"
        Me.cbRainbow.UseVisualStyleBackColor = True
        '
        'cbVis1
        '
        Me.cbVis1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbVis1.AutoSize = True
        Me.cbVis1.Location = New System.Drawing.Point(834, 244)
        Me.cbVis1.Name = "cbVis1"
        Me.cbVis1.Size = New System.Drawing.Size(82, 23)
        Me.cbVis1.TabIndex = 52
        Me.cbVis1.Text = "       Vis 1       "
        Me.cbVis1.UseVisualStyleBackColor = True
        '
        'pbMiniMe
        '
        Me.pbMiniMe.Location = New System.Drawing.Point(12, 389)
        Me.pbMiniMe.Name = "pbMiniMe"
        Me.pbMiniMe.Size = New System.Drawing.Size(100, 50)
        Me.pbMiniMe.TabIndex = 1
        Me.pbMiniMe.TabStop = False
        '
        'lblBytesPerFrame
        '
        Me.lblBytesPerFrame.AutoSize = True
        Me.lblBytesPerFrame.Location = New System.Drawing.Point(397, 459)
        Me.lblBytesPerFrame.Name = "lblBytesPerFrame"
        Me.lblBytesPerFrame.Size = New System.Drawing.Size(90, 13)
        Me.lblBytesPerFrame.TabIndex = 53
        Me.lblBytesPerFrame.Text = "Bytes Per Frame: "
        '
        'lblAvgBytesPerFrame
        '
        Me.lblAvgBytesPerFrame.AutoSize = True
        Me.lblAvgBytesPerFrame.Location = New System.Drawing.Point(397, 483)
        Me.lblAvgBytesPerFrame.Name = "lblAvgBytesPerFrame"
        Me.lblAvgBytesPerFrame.Size = New System.Drawing.Size(109, 13)
        Me.lblAvgBytesPerFrame.TabIndex = 54
        Me.lblAvgBytesPerFrame.Text = "Avg Bytes Per Frame:"
        '
        'pbSerialOut
        '
        Me.pbSerialOut.Location = New System.Drawing.Point(799, 506)
        Me.pbSerialOut.Maximum = 4096
        Me.pbSerialOut.Name = "pbSerialOut"
        Me.pbSerialOut.Size = New System.Drawing.Size(179, 18)
        Me.pbSerialOut.TabIndex = 26
        '
        'pbSerialIn
        '
        Me.pbSerialIn.Location = New System.Drawing.Point(799, 482)
        Me.pbSerialIn.Maximum = 4096
        Me.pbSerialIn.Name = "pbSerialIn"
        Me.pbSerialIn.Size = New System.Drawing.Size(178, 18)
        Me.pbSerialIn.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(848, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Serial buffers"
        '
        'cbOnRange
        '
        Me.cbOnRange.AutoSize = True
        Me.cbOnRange.Location = New System.Drawing.Point(751, 376)
        Me.cbOnRange.Name = "cbOnRange"
        Me.cbOnRange.Size = New System.Drawing.Size(76, 17)
        Me.cbOnRange.TabIndex = 57
        Me.cbOnRange.Text = "Ext Range"
        Me.cbOnRange.UseVisualStyleBackColor = True
        '
        'cbOffRange
        '
        Me.cbOffRange.AutoSize = True
        Me.cbOffRange.Location = New System.Drawing.Point(751, 406)
        Me.cbOffRange.Name = "cbOffRange"
        Me.cbOffRange.Size = New System.Drawing.Size(76, 17)
        Me.cbOffRange.TabIndex = 57
        Me.cbOffRange.Text = "Ext Range"
        Me.cbOffRange.UseVisualStyleBackColor = True
        '
        'lblSelectedPixel
        '
        Me.lblSelectedPixel.AutoSize = True
        Me.lblSelectedPixel.Location = New System.Drawing.Point(129, 76)
        Me.lblSelectedPixel.Name = "lblSelectedPixel"
        Me.lblSelectedPixel.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectedPixel.TabIndex = 1
        Me.lblSelectedPixel.Text = "Selected Pixel: "
        '
        'timerSpectrum
        '
        Me.timerSpectrum.Enabled = True
        Me.timerSpectrum.Interval = 50
        '
        'tbHue
        '
        Me.tbHue.Location = New System.Drawing.Point(110, 95)
        Me.tbHue.Maximum = 8192
        Me.tbHue.Name = "tbHue"
        Me.tbHue.Size = New System.Drawing.Size(119, 45)
        Me.tbHue.TabIndex = 1
        Me.tbHue.TickFrequency = 1024
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(155, 124)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Hue"
        '
        'lblHueValue
        '
        Me.lblHueValue.AutoSize = True
        Me.lblHueValue.Location = New System.Drawing.Point(229, 100)
        Me.lblHueValue.Name = "lblHueValue"
        Me.lblHueValue.Size = New System.Drawing.Size(13, 13)
        Me.lblHueValue.TabIndex = 59
        Me.lblHueValue.Text = "0"
        Me.lblHueValue.Visible = False
        '
        'cbRainbow2
        '
        Me.cbRainbow2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbRainbow2.AutoSize = True
        Me.cbRainbow2.Location = New System.Drawing.Point(831, 156)
        Me.cbRainbow2.Name = "cbRainbow2"
        Me.cbRainbow2.Size = New System.Drawing.Size(85, 23)
        Me.cbRainbow2.TabIndex = 50
        Me.cbRainbow2.Text = "    Hue Shift    "
        Me.cbRainbow2.UseVisualStyleBackColor = True
        '
        'tbHueSpeed
        '
        Me.tbHueSpeed.Location = New System.Drawing.Point(247, 90)
        Me.tbHueSpeed.Maximum = 8192
        Me.tbHueSpeed.Name = "tbHueSpeed"
        Me.tbHueSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbHueSpeed.Size = New System.Drawing.Size(45, 211)
        Me.tbHueSpeed.TabIndex = 60
        Me.tbHueSpeed.TickFrequency = 1024
        Me.tbHueSpeed.Value = 200
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(244, 304)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Speed"
        '
        'cbRainbowWave
        '
        Me.cbRainbowWave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbRainbowWave.AutoSize = True
        Me.cbRainbowWave.Location = New System.Drawing.Point(831, 185)
        Me.cbRainbowWave.Name = "cbRainbowWave"
        Me.cbRainbowWave.Size = New System.Drawing.Size(91, 23)
        Me.cbRainbowWave.TabIndex = 50
        Me.cbRainbowWave.Text = "Rainbow Wave"
        Me.cbRainbowWave.UseVisualStyleBackColor = True
        '
        'lblBassLatency
        '
        Me.lblBassLatency.AutoSize = True
        Me.lblBassLatency.Location = New System.Drawing.Point(804, 537)
        Me.lblBassLatency.Name = "lblBassLatency"
        Me.lblBassLatency.Size = New System.Drawing.Size(118, 13)
        Me.lblBassLatency.TabIndex = 62
        Me.lblBassLatency.Text = "Bass.Net latency:  0 ms"
        '
        'lblChannelPosition
        '
        Me.lblChannelPosition.AutoSize = True
        Me.lblChannelPosition.Location = New System.Drawing.Point(397, 507)
        Me.lblChannelPosition.Name = "lblChannelPosition"
        Me.lblChannelPosition.Size = New System.Drawing.Size(147, 13)
        Me.lblChannelPosition.TabIndex = 62
        Me.lblChannelPosition.Text = "Bass.Net Channel Position:  0"
        Me.lblChannelPosition.Visible = False
        '
        'btnFortune
        '
        Me.btnFortune.Location = New System.Drawing.Point(379, 527)
        Me.btnFortune.Name = "btnFortune"
        Me.btnFortune.Size = New System.Drawing.Size(75, 23)
        Me.btnFortune.TabIndex = 27
        Me.btnFortune.Text = "Fortune!"
        Me.btnFortune.UseVisualStyleBackColor = True
        '
        'cbScrollRight
        '
        Me.cbScrollRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbScrollRight.AutoSize = True
        Me.cbScrollRight.Location = New System.Drawing.Point(834, 278)
        Me.cbScrollRight.Name = "cbScrollRight"
        Me.cbScrollRight.Size = New System.Drawing.Size(83, 23)
        Me.cbScrollRight.TabIndex = 50
        Me.cbScrollRight.Text = "  Scroll Right  "
        Me.cbScrollRight.UseVisualStyleBackColor = True
        '
        'cbstars
        '
        Me.cbstars.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbstars.AutoSize = True
        Me.cbstars.Location = New System.Drawing.Point(834, 307)
        Me.cbstars.Name = "cbstars"
        Me.cbstars.Size = New System.Drawing.Size(83, 23)
        Me.cbstars.TabIndex = 50
        Me.cbstars.Text = "       Stars       "
        Me.cbstars.UseVisualStyleBackColor = True
        '
        'cbGameOfLife
        '
        Me.cbGameOfLife.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbGameOfLife.AutoSize = True
        Me.cbGameOfLife.Location = New System.Drawing.Point(834, 339)
        Me.cbGameOfLife.Name = "cbGameOfLife"
        Me.cbGameOfLife.Size = New System.Drawing.Size(85, 23)
        Me.cbGameOfLife.TabIndex = 50
        Me.cbGameOfLife.Text = " Game Of Life "
        Me.cbGameOfLife.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.lblChannelPosition)
        Me.Controls.Add(Me.lblBassLatency)
        Me.Controls.Add(Me.tbHueSpeed)
        Me.Controls.Add(Me.lblHueValue)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbHue)
        Me.Controls.Add(Me.lblSelectedPixel)
        Me.Controls.Add(Me.cbOffRange)
        Me.Controls.Add(Me.cbOnRange)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAvgBytesPerFrame)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblBytesPerFrame)
        Me.Controls.Add(Me.pbMiniMe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbSerialIn)
        Me.Controls.Add(Me.cbEnableSpectrum)
        Me.Controls.Add(Me.pbSerialOut)
        Me.Controls.Add(Me.cbVis1)
        Me.Controls.Add(Me.txtRowOff)
        Me.Controls.Add(Me.txtRowOn)
        Me.Controls.Add(Me.tabContainer)
        Me.Controls.Add(Me.tbRowOff)
        Me.Controls.Add(Me.tbRowOn)
        Me.Controls.Add(Me.cbGameOfLife)
        Me.Controls.Add(Me.cbstars)
        Me.Controls.Add(Me.cbScrollRight)
        Me.Controls.Add(Me.cbRainbowWave)
        Me.Controls.Add(Me.cbRainbow2)
        Me.Controls.Add(Me.cbRainbow)
        Me.Controls.Add(Me.cbRandom)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnFlashbulbs)
        Me.Controls.Add(Me.btnDump)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.udVerticalFontAdjust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnShiftLeft)
        Me.Controls.Add(Me.pbSayIt)
        Me.Controls.Add(Me.btnSendFrame)
        Me.Controls.Add(Me.txtFontName)
        Me.Controls.Add(Me.btnChooseFont)
        Me.Controls.Add(Me.btnFortune)
        Me.Controls.Add(Me.btnSayIt)
        Me.Controls.Add(Me.txtSayIt)
        Me.Controls.Add(Me.btnColorSolid)
        Me.Controls.Add(Me.lblOffDelayMS)
        Me.Controls.Add(Me.lblFreq)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnPickColor)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "The Magnificent Mood Machine Controller v1.0 by Alex Mizell"
        CType(Me.tbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabContainer.ResumeLayout(False)
        Me.tabBitMapView.ResumeLayout(False)
        Me.tabBitMapView.PerformLayout()
        CType(Me.pbPixelArray, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMatrixSetup.ResumeLayout(False)
        Me.tabMatrixSetup.PerformLayout()
        CType(Me.tbSpectrumAnalyzerCutoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSpectrumAnalyzerSens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabJunk.ResumeLayout(False)
        Me.tabJunk.PerformLayout()
        CType(Me.pbSayIt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRowOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRowOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbHue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbHueSpeed, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRowOn As System.Windows.Forms.TextBox
    Friend WithEvents btnColorSolid As System.Windows.Forms.Button
    Friend WithEvents lblOffDelayMS As System.Windows.Forms.Label
    Friend WithEvents txtRowOff As System.Windows.Forms.TextBox
    Friend WithEvents txtSayIt As System.Windows.Forms.TextBox
    Friend WithEvents btnSayIt As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnChooseFont As System.Windows.Forms.Button
    Friend WithEvents txtFontName As System.Windows.Forms.TextBox
    Friend WithEvents tabContainer As System.Windows.Forms.TabControl
    Friend WithEvents tabBitMapView As System.Windows.Forms.TabPage
    Friend WithEvents btnSendFrame As System.Windows.Forms.Button
    Friend WithEvents pbSayIt As System.Windows.Forms.PictureBox
    Friend WithEvents btnShiftLeft As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Friend WithEvents udVerticalFontAdjust As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnDump As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFlashbulbs As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents cbRandom As System.Windows.Forms.CheckBox
    Friend WithEvents cbAA As System.Windows.Forms.CheckBox
    Friend WithEvents tabMatrixSetup As System.Windows.Forms.TabPage
    Friend WithEvents cbFlipTLCHorizontal As System.Windows.Forms.CheckBox
    Friend WithEvents cbFlipTLCVertical As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlipHorizontal As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlipVertical As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumChannelsPerLED As System.Windows.Forms.TextBox
    Friend WithEvents lblChannelsPerLED As System.Windows.Forms.Label
    Friend WithEvents lblNumColumns As System.Windows.Forms.Label
    Friend WithEvents lblNumLEDs As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumTLCs As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumChannels As System.Windows.Forms.Label
    Friend WithEvents lblNumRows As System.Windows.Forms.Label
    Friend WithEvents txtNumColumns As System.Windows.Forms.TextBox
    Friend WithEvents txtNumLEDs As System.Windows.Forms.TextBox
    Friend WithEvents txtMatrixRows As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTLCRows As System.Windows.Forms.TextBox
    Friend WithEvents txtMatrixCols As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTLCCols As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTLCs As System.Windows.Forms.TextBox
    Friend WithEvents txtNumChannels As System.Windows.Forms.TextBox
    Friend WithEvents txtNumRows As System.Windows.Forms.TextBox
    Friend WithEvents tbRowOn As System.Windows.Forms.TrackBar
    Friend WithEvents tbRowOff As System.Windows.Forms.TrackBar
    Private WithEvents pbPixelArray As System.Windows.Forms.PictureBox
    Friend WithEvents tabJunk As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEnableSpectrum As System.Windows.Forms.CheckBox
    Friend WithEvents cbRainbow As System.Windows.Forms.CheckBox
    Friend WithEvents cbVis1 As System.Windows.Forms.CheckBox
    Friend WithEvents pbMiniMe As System.Windows.Forms.PictureBox
    Friend WithEvents lblBytesPerFrame As System.Windows.Forms.Label
    Friend WithEvents lblAvgBytesPerFrame As System.Windows.Forms.Label
    Friend WithEvents pbSerialOut As System.Windows.Forms.ProgressBar
    Friend WithEvents pbSerialIn As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSlowDown As System.Windows.Forms.TextBox
    Friend WithEvents cbOnRange As System.Windows.Forms.CheckBox
    Friend WithEvents cbOffRange As System.Windows.Forms.CheckBox
    Friend WithEvents lblSelectedPixel As System.Windows.Forms.Label
    Friend WithEvents timerSpectrum As System.Windows.Forms.Timer
    Friend WithEvents tbHue As System.Windows.Forms.TrackBar
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblHueValue As System.Windows.Forms.Label
    Friend WithEvents cbRainbow2 As System.Windows.Forms.CheckBox
    Friend WithEvents tbHueSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbRainbowWave As System.Windows.Forms.CheckBox
    Friend WithEvents comboInputSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lblBassLatency As System.Windows.Forms.Label
    Friend WithEvents cbChannels As System.Windows.Forms.ComboBox
    Friend WithEvents lblChannelPosition As System.Windows.Forms.Label
    Friend WithEvents btnFortune As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tbSpectrumAnalyzerSens As System.Windows.Forms.TrackBar
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tbSpectrumAnalyzerCutoff As System.Windows.Forms.TrackBar
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbScrollRight As System.Windows.Forms.CheckBox
    Friend WithEvents cbstars As System.Windows.Forms.CheckBox
    Friend WithEvents cbGameOfLife As System.Windows.Forms.CheckBox

End Class
