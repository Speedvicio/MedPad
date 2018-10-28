Imports System.Globalization
Imports SlimDX.XInput

Module GXInput
    Public gamepad As Controller
    Public Xstate As New State

    Public Sub CreateXInput()

        gamepad = New Controller(MedPad.ListBox1.SelectedIndex)

        MedPad.ReleaseDevice()
        MedPad.TimerXInput.Interval = 1000 \ 24
        MedPad.TimerXInput.Start()
    End Sub

    Public Sub UpdateXInput()
        If MedPad.ListBox1.SelectedItem <> "Mouse" Then MedPad.PadType = "joystick"

LEFTSTICK:
        MedPad.XAxys.Text = Fix(Xstate.Gamepad.LeftThumbX.ToString(CultureInfo.CurrentCulture) / 32.767)
        MedPad.PXAxys.Value = CInt(MedPad.XAxys.Text) + 1000
        If MedPad.XAxys.Text < -500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(49152)
        ElseIf MedPad.XAxys.Text > 500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32768)
        End If

        MedPad.YAxys.Text = Fix(Xstate.Gamepad.LeftThumbY.ToString(CultureInfo.CurrentCulture) / 32.767) * -1
        MedPad.PYAxys.Value = 1000 - CInt(MedPad.YAxys.Text) * -1
        If MedPad.YAxys.Text < -500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32769)
        ElseIf MedPad.YAxys.Text > 500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(49153)
        End If

        MedPad.ManageAxys(MedPad.XAxys.Text, MedPad.YAxys.Text, MedPad.PictureAxys)

RIGHTSTICK:

        MedPad.RXAxis.Text = Fix(Xstate.Gamepad.RightThumbX.ToString(CultureInfo.CurrentCulture) / 32.767)
        MedPad.PRXAxis.Value = CInt(MedPad.RXAxis.Text) + 1000
        If MedPad.RXAxis.Text < -500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(49154)
        ElseIf MedPad.RXAxis.Text > 500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32770)
        End If

        MedPad.RYAxis.Text = Fix(Xstate.Gamepad.RightThumbY.ToString(CultureInfo.CurrentCulture) / 32.767) * -1
        MedPad.PRYAxis.Value = 1000 - CInt(MedPad.RYAxis.Text) * -1

        If MedPad.RYAxis.Text < -500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32771)
        ElseIf MedPad.RYAxis.Text > 500 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(49155)
        End If

        MedPad.ManageAxys(MedPad.RXAxis.Text, MedPad.RYAxis.Text, MedPad.PictureRAxys)

TRIGGERS:
        'Dim slider As Integer() = state.GetSliders()

        'Label7.Text = slider(0).ToString(CultureInfo.CurrentCulture)
        'ProgressBar4.Value = slider(0).ToString(CultureInfo.CurrentCulture) + 1000
        'Label21.Text = slider(1).ToString(CultureInfo.CurrentCulture)

        MedPad.ZAxis.Text = Fix(Xstate.Gamepad.LeftTrigger.ToString(CultureInfo.CurrentCulture)) * 7.843
        MedPad.PZAxis.Value = CInt(MedPad.ZAxis.Text)
        If MedPad.ZAxis.Text >= 1000 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32772)
        End If

        MedPad.RZAxis.Text = Fix(Xstate.Gamepad.RightTrigger.ToString(CultureInfo.CurrentCulture)) * 7.843
        MedPad.PRZAxis.Value = CInt(MedPad.RZAxis.Text)
        If MedPad.RZAxis.Text >= 1000 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(32773)
        End If

BUTTON:
        Dim PovAx As Integer
        Dim PovAy As Integer
        Dim Bvalue As Integer
        Dim buttons As GamepadButtonFlags = Xstate.Gamepad.Buttons

        If buttons <> GamepadButtonFlags.None Then
            MedPad.OvalPicture.BackColor = Color.Transparent
            MedPad.OvalPicture.BackgroundImage = My.Resources.BDOWN
            Select Case buttons
                Case GamepadButtonFlags.A
                    Bvalue = 12
                Case GamepadButtonFlags.B
                    Bvalue = 13
                Case GamepadButtonFlags.Back
                    Bvalue = 5
                Case GamepadButtonFlags.DPadDown
                    PovAx = 0
                    PovAy = 1000
                    Bvalue = 1
                Case GamepadButtonFlags.DPadLeft
                    PovAx = -1000
                    PovAy = 0
                    Bvalue = 2
                Case GamepadButtonFlags.DPadRight
                    PovAx = 1000
                    PovAy = 0
                    Bvalue = 3
                Case GamepadButtonFlags.DPadUp
                    PovAx = 0
                    PovAy = -1000
                    Bvalue = 0
                Case GamepadButtonFlags.LeftShoulder
                    Bvalue = 8
                Case GamepadButtonFlags.LeftThumb
                    Bvalue = 6
                Case GamepadButtonFlags.RightShoulder
                    Bvalue = 9
                Case GamepadButtonFlags.RightThumb
                    Bvalue = 7
                Case GamepadButtonFlags.Start
                    Bvalue = 4
                Case GamepadButtonFlags.X
                    Bvalue = 14
                Case GamepadButtonFlags.Y
                    Bvalue = 15
            End Select
        Else
            PovAx = 0
            PovAy = 0
            MedPad.OvalPicture.BackColor = Color.Transparent : MedPad.OvalPicture.BackgroundImage = My.Resources.BUP
            Bvalue = -1
            'MedPad.RealMedInput.Text = ""
        End If

        MedPad.ManageAxys(PovAx, PovAy, MedPad.PicturePov)

        If Bvalue > -1 Then
            MedPad.RealMedInput.Text = MedPad.ConverToMednafen(Bvalue)
            MedPad.JButtons.Text = buttons.ToString
        Else
            MedPad.JButtons.Text = ""
        End If

    End Sub

End Module