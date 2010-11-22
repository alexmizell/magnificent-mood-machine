Imports Un4seen.Bass
Imports Un4seen.Bass.Misc.Visuals
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Math





Public Class frmSpectrumAnalyzer

    Dim stream As Integer
    Dim bmpSpectrum As Bitmap
    Dim gSpectrum As Graphics
    Dim brush As SolidBrush
    Dim LeftLevel As Double

    Dim rectangle As Rectangle = New Rectangle(0, 0, 26, 16)
    Dim color1 As Color = Color.Blue
    Dim color2 As Color = Color.Purple
    Dim bgColor As Color = Color.Black
    Dim lineWidth As Integer = 1
    Dim linear As Boolean = False
    Dim fullSpectrum As Boolean = False
    Dim highQuality As Boolean = True


    Dim myVisuals As Un4seen.Bass.Misc.Visuals



    Private Sub frmSpectrumAnalyzer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        bmpSpectrum = New Bitmap(25, 15, Imaging.PixelFormat.Format24bppRgb)
        gSpectrum = Graphics.FromImage(bmpSpectrum)

        pbSpectrum.BackgroundImageLayout = ImageLayout.Stretch
        pbSpectrum.BackgroundImage = bmpSpectrum

        Brush = New SolidBrush(Color.Lime)

        myVisuals = New Misc.Visuals


        ' init Bass
        Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)

        ' load a file into a stream
        stream = Bass.BASS_StreamCreateFile("J:\Music Archive\Gorillaz\Plastic Beach (Deluxe Version)\1-06 Superfast Jellyfish (feat. Gruf.wav", 0, 0, BASSFlag.BASS_SAMPLE_FLOAT)

        'stream = Bass.BASS_StreamCreateFile("J:\Mood Machine Project Files\Code Working Folder\SpectrumAnalyzer1\SpectrumAnalyzer1\bin\Debug\freq20-20000-30s.wav", 0, 0, BASSFlag.BASS_SAMPLE_FLOAT)

        If stream <> 0 Then

            ' play the file
            Bass.BASS_ChannelPlay(stream, False)

            ' but immediately pause it
            Bass.BASS_Pause()

        End If

    End Sub

    ' calculates the level of a stereo signal between 0 and 65535
    ' where 0 = silent, 32767 = 0dB and 65535 = +6dB
    Private Sub GetLevel(ByVal channel As Integer, ByRef peakL As Integer, ByRef peakR As Integer)
        Dim maxL As Single = 0.0F
        Dim maxR As Single = 0.0F

        ' length of a 50ms window in bytes
        Dim length20ms As Integer = CType(Bass.BASS_ChannelSeconds2Bytes(channel, 0.05), Integer)
        ' the number of 32-bit floats required (since length is in bytes!)
        Dim l4 As Integer = length20ms / 4  ' 32-bit = 4 bytes


        ' create a data buffer as needed
        Dim sampleData(l4 - 1) As Single

        Dim length As Integer = Bass.BASS_ChannelGetData(channel, sampleData, length20ms)

        ' the number of 32-bit floats received
        ' as less data might be returned by BASS_ChannelGetData as requested
        l4 = length / 4

        Dim a As Integer
        For a = 0 To l4 - 1 Step a + 1
            Dim absLevel As Single = Math.Abs(sampleData(a))

            ' decide on L/R channel
            If a Mod 2 = 0 Then
                ' Left channel
                If absLevel > maxL Then
                    maxL = absLevel
                End If
            Else
                ' Right channel
                If absLevel > maxR Then
                    maxR = absLevel
                End If
            End If
        Next

        ' limit the maximum peak levels to +6bB = 65535 = 0xFFFF
        ' the peak levels will be int values, where 32767 = 0dB
        ' and a float value of 1.0 also represents 0db.
        peakL = CInt(Math.Round(32767.0F * maxL)) And &HFFFF
        peakR = CInt(Math.Round(32767.0F * maxR)) And &HFFFF
    End Sub

    Private Sub cbPlay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPlay.CheckedChanged

        If cbPlay.Checked Then

            Bass.BASS_Start()

        Else

            Bass.BASS_Pause()

        End If

    End Sub

    Private Sub timerUpdateMeters_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerUpdateMeters.Tick

        ' calculate the sound level
        Dim peakL As Integer = 0
        Dim peakR As Integer = 0
        GetLevel(stream, peakL, peakR)

        '' convert the level to dB
        ''Dim dBlevelL As Double = Utils.LevelToDB(peakL, 65535)
        ''Dim dBlevelR As Double = Utils.LevelToDB(peakR, 65535)

        pbLeft.Value = peakL
        pbRight.Value = peakR

        ' get FFT data
        'GetFFT(stream)

        'bmpSpectrum = myVisuals.CreateSpectrum(stream, 25, 15, color1, color2, bgColor, False, True, True)
        myVisuals.CreateSpectrum(stream, gSpectrum, rectangle, color1, color2, bgColor, linear, fullSpectrum, highQuality)

        'myVisuals.

        pbSpectrum.Refresh()



    End Sub

    Private Sub GetFFT(ByVal stream As Integer)

        ' a 10ms window in bytes to be filled with sample data
        Dim length As Integer = CInt(Bass.BASS_ChannelSeconds2Bytes(stream, 0.05))

        ' first we need a mananged object where the sample data should be held
        ' only length/4 elements needed, since length is in byte and a float uses 4 bytes
        Dim data(length / 4 - 1) As Single

        ' create a pinned handle to a managed object
        Dim hGC As GCHandle = GCHandle.Alloc(data, GCHandleType.Pinned)

        ' get the data
        length = Bass.BASS_ChannelGetData(stream, hGC.AddrOfPinnedObject(), BASSData.BASS_DATA_FFT4096)

        Dim l4 As Integer = length / 4

        ' free the pinned handle
        hGC.Free()

        ' modded from a 30 band EQ, this is 25 bands
        Dim bands() = {31, 40, 50, 75, 105, 135, 175, 250, 320, 400, 500, 640, 800, 1000, 1600, 2000, 2500, 3150, 4000, 6200, 8000, 10000, 13000, 16000, 20000}

        'Dim Bands(0) = {}

        'vpb1.Value = Int(data((l4 * bands(0)) / 22100) * 40000)
        'vpb2.Value = Int(data((l4 * bands(2)) / 22100) * 40000)
        'vpb3.Value = Int(data((l4 * bands(3)) / 22100) * 40000)
        'vpb4.Value = Int(data((l4 * bands(4)) / 22100) * 40000)
        'vpb5.Value = Int(data((l4 * bands(5)) / 22100) * 40000)
        'vpb6.Value = Int(data((l4 * bands(7)) / 22100) * 40000)
        'vpb7.Value = Int(data((l4 * bands(8)) / 22100) * 40000)
        'vpb8.Value = Int(data((l4 * bands(9)) / 22100) * 40000)
        'vpb9.Value = Int(data((l4 * bands(10)) / 22100) * 40000)
        'vpb10.Value = Int(data((l4 * bands(12)) / 22100) * 40000)
        'vpb11.Value = Int(data((l4 * bands(13)) / 22100) * 40000)
        'vpb12.Value = Int(data((l4 * bands(15)) / 22100) * 40000)
        'vpb13.Value = Int(data((l4 * bands(16)) / 22100) * 40000)
        'vpb14.Value = Int(data((l4 * bands(18)) / 22100) * 40000)
        'vpb15.Value = Int(data((l4 * bands(20)) / 22100) * 40000)

        Dim maxLevel = bmpSpectrum.Height


        For x = 0 To bmpSpectrum.Width - 1

            ' find the level
            'Dim level As Integer = Math.Abs(Int(data((2048 * bands(x)) / 22100) * 2 * maxLevel))

            Dim level As Single = 1 + Log10(data(data.Length * bands(x) / 22100) / 32768.0) * 20 / 30

            If level < 0 Then level = 0

            level = level * maxLevel

            ' use buckets and summing
            ' total all of the energy in a given band of frequencies
            ' bandwidth is 22100/number of bands


            'Dim level As Integer = Int(Math.Abs(data((2048 * ((22100 / bmpSpectrum.Width) * x)) / 22100)) * maxLevel)
            'Dim level As Integer = Int(Math.Abs(data((128 * bands(x)) / 22100)) * maxLevel)
            'Dim level As Integer = CInt(Math.Abs(data((128 * ((22100 / bmpSpectrum.Width) * x)) / 22100)) * maxLevel)
            'Dim level As Integer = CInt(Math.Abs(Math.Log10(data((128 * ((22100 / bmpSpectrum.Width) * x)) / 22100)) * 20) * maxLevel)

            'Dim db As Single = Math.Log10(level) * 20

            Dim intLevel As Integer = CInt(level)

            ' erase the old line
            gSpectrum.DrawLine(Pens.Black, x, 0, x, maxLevel)

            ' draw a line to represent
            gSpectrum.DrawLine(Pens.Blue, x, 0, x, intLevel)
            'gSpectrum.

        Next

        pbSpectrum.Refresh()


    End Sub

End Class
