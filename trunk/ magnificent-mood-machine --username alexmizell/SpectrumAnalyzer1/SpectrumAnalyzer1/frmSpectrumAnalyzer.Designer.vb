<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpectrumAnalyzer
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
        Me.pbLeft = New System.Windows.Forms.ProgressBar()
        Me.pbRight = New System.Windows.Forms.ProgressBar()
        Me.cbPlay = New System.Windows.Forms.CheckBox()
        Me.timerUpdateMeters = New System.Windows.Forms.Timer(Me.components)
        Me.pbSpectrum = New System.Windows.Forms.PictureBox()
        CType(Me.pbSpectrum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLeft
        '
        Me.pbLeft.Location = New System.Drawing.Point(12, 334)
        Me.pbLeft.Maximum = 40000
        Me.pbLeft.Name = "pbLeft"
        Me.pbLeft.Size = New System.Drawing.Size(643, 40)
        Me.pbLeft.TabIndex = 0
        '
        'pbRight
        '
        Me.pbRight.Location = New System.Drawing.Point(12, 380)
        Me.pbRight.Maximum = 40000
        Me.pbRight.Name = "pbRight"
        Me.pbRight.Size = New System.Drawing.Size(643, 40)
        Me.pbRight.TabIndex = 1
        '
        'cbPlay
        '
        Me.cbPlay.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbPlay.AutoSize = True
        Me.cbPlay.Location = New System.Drawing.Point(618, 442)
        Me.cbPlay.Name = "cbPlay"
        Me.cbPlay.Size = New System.Drawing.Size(37, 23)
        Me.cbPlay.TabIndex = 2
        Me.cbPlay.Text = "Play"
        Me.cbPlay.UseVisualStyleBackColor = True
        '
        'timerUpdateMeters
        '
        Me.timerUpdateMeters.Enabled = True
        Me.timerUpdateMeters.Interval = 10
        '
        'pbSpectrum
        '
        Me.pbSpectrum.BackColor = System.Drawing.Color.Black
        Me.pbSpectrum.Location = New System.Drawing.Point(12, 12)
        Me.pbSpectrum.Name = "pbSpectrum"
        Me.pbSpectrum.Size = New System.Drawing.Size(643, 306)
        Me.pbSpectrum.TabIndex = 3
        Me.pbSpectrum.TabStop = False
        '
        'frmSpectrumAnalyzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 477)
        Me.Controls.Add(Me.pbSpectrum)
        Me.Controls.Add(Me.cbPlay)
        Me.Controls.Add(Me.pbRight)
        Me.Controls.Add(Me.pbLeft)
        Me.Name = "frmSpectrumAnalyzer"
        Me.Text = "Spectrum Analyzer by Alex Mizell"
        CType(Me.pbSpectrum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLeft As System.Windows.Forms.ProgressBar
    Friend WithEvents pbRight As System.Windows.Forms.ProgressBar
    Friend WithEvents cbPlay As System.Windows.Forms.CheckBox
    Friend WithEvents timerUpdateMeters As System.Windows.Forms.Timer
    Friend WithEvents pbSpectrum As System.Windows.Forms.PictureBox

End Class
