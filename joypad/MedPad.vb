Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports SlimDX
Imports SlimDX.DirectInput

Partial Public Class MedPad
    Inherits Form
    Private joystick As Joystick
    Private mouse As Mouse
    Private state As New JoystickState()
    Private numPOVs As Integer
    Public MedPar, MedPath, UniqueId, PadType, ConfigPath As String
    Public specificfile, console, portpad As String
    Private SliderCount As Integer
    Private DevCaps As SlimDX.DirectInput.Capabilities
    Dim dinput As New DirectInput()
    Dim PadGUID As Guid
    Dim Mousecode As String
    Dim assigned As Boolean
    Private fattemp = True
    Public firststart As Boolean
    Public DMedConf As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'JButtons.Parent = OvalPicture
        firststart = True
        Dim process_med() As Process
        process_med = Process.GetProcessesByName("mednafen", My.Computer.Name)
        If process_med.Length > 0 Then
            Dim RispMed = MsgBox("Mednafen is started, you have to close it to be able to configure the inputs." & vbCrLf & "Can I arrest it in your place?", vbYesNo + MsgBoxStyle.Information, "Mednafen running...")
            If RispMed = vbYes Then

                Dim myProcesses() As Process
                Dim myProcess As Process
                myProcesses = Process.GetProcessesByName("mednafen")
                For Each myProcess In myProcesses
                    Try
                        myProcess.Kill()
                    Catch
                    End Try
                Next
                Thread.Sleep(2000)
                GoTo INMEDNAFEN
            Else
                Me.Close()
                Exit Sub
            End If
        Else
INMEDNAFEN:
            JButtons.Text = ""
            LoadPad()
            ParseCommandLineArgs()

            If MCF.Text.Trim <> "" Then
                RefreshPad()
            End If
            ComboConsole.Text = console
            ComboPort.Text = portpad
            ControlSpecificFileExist()
        End If

    End Sub

    Private Sub ParseCommandLineArgs()

        Dim inputArgument As String

        For Each s As String In Environment.GetCommandLineArgs

            Select Case True
                Case s.ToLower.Contains("-folder=")
                    inputArgument = "-folder="

                    If File.Exists(s.Remove(0, inputArgument.Length) & "\mednafen.cfg") Then
                        DMedConf = "mednafen"
                        Mousecode = "0x0 "
                    ElseIf File.Exists(s.Remove(0, inputArgument.Length) & "\mednafen-09x.cfg") Then
                        DMedConf = "mednafen-09x"
                        Mousecode = "0000000000000000 "
                    End If

                    MCF.Text = s.Remove(0, inputArgument.Length) & "\" & DMedConf & ".cfg"
                Case s.ToLower.Contains("-console=")
                    inputArgument = "-console="
                    console = s.Remove(0, inputArgument.Length)
                Case s.ToLower.Contains("-port=")
                    inputArgument = "-port="
                    portpad = s.Remove(0, inputArgument.Length)
                Case s.ToLower.Contains("-file=")
                    inputArgument = "-file="
                    SpecificGame.Text = s.Remove(0, inputArgument.Length)
                Case Else
                    'inputName = ""
                    'ComboConsole.Text = ""
            End Select

        Next
        Environment.CommandLine.Remove(0, Environment.CommandLine.Length)
    End Sub

    Private Sub UpdateUI()

        If ListBox1.SelectedItem <> "Mouse" Then PadType = "joystick"
        Dim strText As String = Nothing
AXIS:
        XAxys.Text = state.X.ToString(CultureInfo.CurrentCulture)
        PXAxys.Value = state.X.ToString(CultureInfo.CurrentCulture) + 1000
        If state.X.ToString(CultureInfo.CurrentCulture) < -500 Then
            RealMedInput.Text = ConverToMednafen(49152)
        ElseIf state.X.ToString(CultureInfo.CurrentCulture) > 500 Then
            RealMedInput.Text = ConverToMednafen(32768)
        End If

        YAxys.Text = state.Y.ToString(CultureInfo.CurrentCulture)
        PYAxys.Value = state.Y.ToString(CultureInfo.CurrentCulture) + 1000
        If state.Y.ToString(CultureInfo.CurrentCulture) < -500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(32769)
            Else
                RealMedInput.Text = ConverToMednafen(49153)
            End If
        ElseIf state.Y.ToString(CultureInfo.CurrentCulture) > 500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(49153)
            Else
                RealMedInput.Text = ConverToMednafen(32769)
            End If
        End If

        ZAxis.Text = state.Z.ToString(CultureInfo.CurrentCulture)
        PZAxis.Value = state.Z.ToString(CultureInfo.CurrentCulture) + 1000
        If state.Z.ToString(CultureInfo.CurrentCulture) < -500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(32773)
            Else
                RealMedInput.Text = ConverToMednafen(49154)
            End If
        ElseIf state.Z.ToString(CultureInfo.CurrentCulture) > 500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(32772)
            Else
                RealMedInput.Text = ConverToMednafen(32770)
            End If
        End If

        ManageAxys(ResetPad(state.X), ResetPad(state.Y), PictureAxys)

ROTATE:

        RXAxis.Text = state.RotationX.ToString(CultureInfo.CurrentCulture)
        PRXAxis.Value = state.RotationX.ToString(CultureInfo.CurrentCulture) + 1000
        If state.RotationX.ToString(CultureInfo.CurrentCulture) < -500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(49154)
            Else
                '??RealMedInput.Text = ConverToMednafen(49154)
            End If
        ElseIf state.RotationX.ToString(CultureInfo.CurrentCulture) > 500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(32770)
            Else
                '??RealMedInput.Text = ConverToMednafen(49156)
            End If
        End If

        RYAxis.Text = state.RotationY.ToString(CultureInfo.CurrentCulture)
        PRYAxis.Value = state.RotationY.ToString(CultureInfo.CurrentCulture) + 1000
        If state.RotationY.ToString(CultureInfo.CurrentCulture) < -500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(32771)
            Else
                '??RealMedInput.Text = ConverToMednafen(49155)
            End If
        ElseIf state.RotationY.ToString(CultureInfo.CurrentCulture) > 500 Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                RealMedInput.Text = ConverToMednafen(49155)
            Else
                '??RealMedInput.Text = ConverToMednafen(49155)
            End If
        End If

        If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
            ManageAxys(ResetPad(state.RotationX), ResetPad(state.RotationY), PictureRAxys)
        End If
        'ManageAxys(ResetPad(state.RotationX), ResetPad(state.RotationY), PictureRAxys)

        RZAxis.Text = state.RotationZ.ToString(CultureInfo.CurrentCulture)
        PRZAxis.Value = state.RotationZ.ToString(CultureInfo.CurrentCulture) + 1000

        If state.RotationZ.ToString(CultureInfo.CurrentCulture) < -500 Then
            RealMedInput.Text = ConverToMednafen(49155)
        ElseIf state.RotationZ.ToString(CultureInfo.CurrentCulture) > 500 Then
            RealMedInput.Text = ConverToMednafen(32771)
        End If

PLYN:
        'Dim slider As Integer() = state.GetSliders()

        'Label7.Text = slider(0).ToString(CultureInfo.CurrentCulture)
        'ProgressBar4.Value = slider(0).ToString(CultureInfo.CurrentCulture) + 1000
        'Label21.Text = slider(1).ToString(CultureInfo.CurrentCulture)
POV:

        Dim pov As Integer() = state.GetPointOfViewControllers()
        Dim PovC As Integer
        Dim PovAx As Integer
        Dim PovAy As Integer

        JPov.Text = pov(0).ToString(CultureInfo.CurrentCulture)
        If Int(JPov.Text) = -1 Then
            PovC = -1
            PovAx = 0
            PovAy = 0
        ElseIf CInt(JPov.Text) = 0 Then
            PovC = 0
            PovAx = 0
            PovAy = -1000
        ElseIf CInt(JPov.Text) = 31500 Then

        ElseIf CInt(JPov.Text) = 27000 Then
            PovC = 2
            PovAx = -1000
            PovAy = 0
        ElseIf CInt(JPov.Text) = 22500 Then

        ElseIf CInt(JPov.Text) = 18000 Then
            PovC = 1
            PovAx = 0
            PovAy = 1000
        ElseIf CInt(JPov.Text) = 13500 Then

        ElseIf CInt(JPov.Text) = 9000 Then
            PovC = 3
            PovAx = 1000
            PovAy = 0
        ElseIf CInt(JPov.Text) = 4500 Then
        Else
            PovC = -2
        End If

        Label9.Text = pov(1).ToString(CultureInfo.CurrentCulture)
        Label22.Text = pov(2).ToString(CultureInfo.CurrentCulture)
        Label23.Text = pov(3).ToString(CultureInfo.CurrentCulture)

        If ListBox1.SelectedItem <> "" Then
            If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") = False Then
                Select Case PovC
                    Case -1
                        PovC = -1
                    Case 0
                        PovC = 49157
                    Case 2
                        PovC = 49156
                    Case 1
                        PovC = 32773
                    Case 3
                        PovC = 32772
                End Select
                'ManageAxys(state.Z, state.RotationZ, PictureBox2)
            Else

            End If
        End If

        If CInt(PovC) > -1 And fattemp = False Then RealMedInput.Text = ConverToMednafen(PovC)

        ManageAxys(PovAx, PovAy, PicturePov)

BUTTON:

        Dim buttons As Boolean() = state.GetButtons()
        Dim BconV As Integer = 0
        For b As Integer = 0 To buttons.Length - 1
            If buttons(b) Then
                OvalPicture.BackColor = Color.Transparent
                OvalPicture.BackgroundImage = My.Resources.BDOWN
                'JButtons.BackColor = Color.Firebrick
                If LCase(ListBox2.SelectedItem.ToString).Contains("xinput unknown") Then
                    If b <= 3 Then
                        BconV = 12
                    ElseIf b = 6 Then
                        BconV = -1
                    ElseIf b = 7 Then
                        BconV = -3
                    ElseIf b > 7 And b <= 9 Then
                        BconV = -2
                    Else
                        BconV = 4
                    End If
                Else
                    BconV = 0
                End If

                RealMedInput.Text = ConverToMednafen(b + BconV)
                strText += b.ToString("00 ", CultureInfo.CurrentCulture)
            End If
        Next

        If JButtons.Text = "" Then OvalPicture.BackColor = Color.Transparent : OvalPicture.BackgroundImage = My.Resources.BUP

        JButtons.Text = strText

        fattemp = False
    End Sub

    Private Function ResetPad(currentinputvalue As String)
        If currentinputvalue < -1000 Then
            ResetPad = 1000 + Val(currentinputvalue)
        ElseIf currentinputvalue > 1000 Then
            ResetPad = Val(currentinputvalue) - 1000
        Else
            ResetPad = Val(currentinputvalue)
        End If

    End Function

    Public Function ManageAxys(Ax As Integer, Ay As Integer, square As PictureBox)
        square.Refresh()
        Dim Cfocus As Cursor = Cursors.Cross

        Dim Afocus As Graphics = square.CreateGraphics()
        Dim rectangle As New Rectangle(New Point(CInt(Math.Round((Ax / 1400) * (square.Width - Cfocus.Size.Width))),
                                                 CInt(Math.Round((Ay / 1400) * (square.Height - Cfocus.Size.Height)))),
                                             New Size(Cfocus.Size.Width, Cfocus.Size.Height))

        rectangle.Location = New Point(rectangle.Width +
        rectangle.Location.X, rectangle.Height + rectangle.Location.Y)
        rectangle.Size = Cursor.Size

        Cfocus.Draw(Afocus, rectangle)

        Afocus.DrawLine(Pens.Red, CInt(square.Width / 2), 0, CInt(square.Width / 2), square.Height)
        Afocus.DrawLine(Pens.Red, 0, CInt(square.Height / 2), square.Width, CInt(square.Height / 2))
    End Function

    Public Function ConverToMednafen(InputValue As Integer) As String
        Dim InpuToConvert As UInt32
        InpuToConvert = Convert.ToUInt32(InputValue)
        If DMedConf = "mednafen-09x" Then
            ConverToMednafen = InpuToConvert.ToString("x8")
        Else
            Select Case InputValue
                Case >= 32768
                    ConverToMednafen = InpuToConvert.ToString("x8")
                    If ConverToMednafen.Contains("0000800") Then
                        ConverToMednafen = Replace(ConverToMednafen, "0000800", "abs_") & "+"
                    ElseIf ConverToMednafen.Contains("0000c00") Then
                        ConverToMednafen = Replace(ConverToMednafen, "0000c00", "abs_") & "-"
                    End If
                Case Else
                    ConverToMednafen = "button_" & InputValue
            End Select
        End If
    End Function

    Public Sub ReleaseDevice()
        TimerDInput.[Stop]()

        If joystick IsNot Nothing Then
            joystick.Unacquire()
            joystick.Dispose()
        End If
        joystick = Nothing
        mouse = Nothing
    End Sub

    Private Sub LoadPad()
        ReleaseDevice()
        Dim attached As Integer = 0

        If CheckBox2.Checked = False Then
            pnp.GetUSBDevices()
        Else
            For Each device As DeviceInstance In dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)
                If LCase(device.ProductName).Contains("xbox") Then ListBox1.Items.Add(device.ProductName & " GUID " & device.InstanceGuid.ToString)
            Next
        End If

        For Each device As DeviceInstance In dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)
            If LCase(device.ProductName).Contains("xbox") = False Then ListBox1.Items.Add(device.ProductName & " GUID " & device.InstanceGuid.ToString)
        Next

        For Each device As DeviceInstance In dinput.GetDevices(DeviceClass.Pointer, DeviceEnumerationFlags.AttachedOnly)
            ListBox1.Items.Add(device.Type.ToString)
        Next

        If ListBox1.Items.Count <= 0 Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("There are no device attached to the system.")
            Return
        End If
    End Sub

    Private Sub CreateDevice()
        Try
            joystick = New Joystick(dinput, PadGUID)
            joystick.Properties.AutoCenter = True
            joystick.SetCooperativeLevel(Me, CooperativeLevel.Nonexclusive Or CooperativeLevel.Foreground)
            Exit Try
        Catch generatedExceptionName As DirectInputException
        End Try

        For Each deviceObject As DeviceObjectInstance In joystick.GetObjects()
            If (deviceObject.ObjectType And ObjectDeviceType.Axis) <> 0 Then
                joystick.GetObjectPropertiesById(CInt(deviceObject.ObjectType)).SetRange(-1000, 1000)
            End If

            Unlocking(deviceObject)
        Next

        'MsgBox( joystick.Properties.TypeName)    p_vid

        joystick.Acquire()

        TimerXInput.Stop()
        TimerDInput.Interval = 1000 \ 24
        TimerDInput.Start()
    End Sub

    Private Sub Unlocking(ByVal d As DeviceObjectInstance)
        If ObjectGuid.XAxis = d.ObjectTypeGuid Then
            XAxys.Enabled = True
            PictureAxys.Enabled = True
        End If
        If ObjectGuid.YAxis = d.ObjectTypeGuid Then
            YAxys.Enabled = True
            PictureAxys.Enabled = True
        End If
        If ObjectGuid.ZAxis = d.ObjectTypeGuid Then
            PZAxis.Enabled = True
        End If
        If ObjectGuid.RotationalXAxis = d.ObjectTypeGuid Then
            Label18.Enabled = True
            PictureRAxys.Enabled = True
            PRXAxis.Enabled = True
        End If
        If ObjectGuid.RotationalYAxis = d.ObjectTypeGuid Then
            Label19.Enabled = True
            PictureRAxys.Enabled = True
            PRYAxis.Enabled = True
        End If
        If ObjectGuid.RotationalZAxis = d.ObjectTypeGuid Then
            RZAxis.Enabled = True
            PRZAxis.Enabled = True

        End If
        If ObjectGuid.Slider = d.ObjectTypeGuid Then
            Select Case System.Math.Max(Interlocked.Increment(SliderCount), SliderCount - 1)
                Case 0
                    Label21.Enabled = True
                    Exit Select
                Case 1
                    Label7.Enabled = True
                    Exit Select
            End Select
        End If
        If ObjectGuid.PovController = d.ObjectTypeGuid Then
            Select Case System.Math.Max(Interlocked.Increment(numPOVs), numPOVs - 1)
                Case 0
                    Label9.Enabled = True
                    Exit Select
                Case 1
                    PicturePov.Enabled = True
                    JPov.Enabled = True
                    Exit Select
                Case 2
                    Label22.Enabled = True
                    Exit Select
                Case 3
                    Label23.Enabled = True
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub Lock()
        PicturePov.Enabled = False
        PictureAxys.Enabled = False
        PictureRAxys.Enabled = False
        PXAxys.Enabled = False
        PYAxys.Enabled = False
        PRXAxis.Enabled = False
        PRYAxis.Enabled = False
        PZAxis.Enabled = False
        PRZAxis.Enabled = False
        PictureMouse.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDInput.Tick
        ReadImmediateData()
    End Sub

    Private Sub ReadImmediateData()
        Try
            If joystick.Acquire().IsFailure Then
                Return
            End If
            If joystick.Poll().IsFailure Then
                Return
            End If
            state = joystick.GetCurrentState()
            If Result.Last.IsFailure Then
                Return
            End If
            UpdateUI()
        Catch
            If ListBox2.Items.Count > 1 Or ListBox1.Items.Count > 1 Then
                Button3.PerformClick()
            End If
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Lock()
        If ListBox1.SelectedItem = Nothing Then Exit Sub
        If ListBox1.SelectedItem = "There are no device attached to the system." Then Exit Sub
        ReleaseDevice()

        If ListBox2.Items.Count > 0 Then
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
        End If

        If ListBox1.SelectedItem.ToString.Contains("XInput Unknown") Then
            CreateXInput()
        ElseIf ListBox1.SelectedItem <> "Mouse" Then
            If ListBox1.SelectedItem <> "" Then
                Dim splitGuid() As String = Split(ListBox1.SelectedItem, " GUID ")
                PadGUID = New Guid(splitGuid(1).Trim)
                CreateDevice()
                RealMedInput.Text = ""
                UpdateUI()
            End If
        ElseIf ListBox1.SelectedItem = "Mouse" Then
            ReleaseDevice()
            PictureMouse.Enabled = True
        Else
            Lock()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim browsefiledialog1 As New OpenFileDialog()
        browsefiledialog1.Filter = "Mednafen Config File|mednafen-09x.cfg;mednafen.cfg"
        browsefiledialog1.Title = "Choose Mednafen Config File"
        browsefiledialog1.ShowDialog()

        If browsefiledialog1.FileName <> "" Then
            MCF.Text = browsefiledialog1.FileName
            RefreshPad()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MCF.Text.Trim <> "" Then MedPath = Path.GetDirectoryName(MCF.Text)
        ListBox1.Items.Clear()
        If ListBox1.Items.Count > 1 Then Lock()
        LoadPad()
        If File.Exists(MedPath & "\mednafen.exe") = True Then RefreshPad()
    End Sub

    Private Sub LaunchPar()
        If File.Exists(MedPath & "\mednafen.exe") = False Then Exit Sub

        Dim startInfo As ProcessStartInfo
        startInfo = New ProcessStartInfo
        startInfo.EnvironmentVariables("MEDNAFEN_NOPOPUPS") = "1"
        startInfo.Arguments = MedPar
        startInfo.FileName = MedPath & "\mednafen.exe"
        startInfo.UseShellExecute = False
        Dim shell As Process
        shell = New Process
        shell.StartInfo = startInfo
        shell.Start()

        'Process.Start(MedPath & "\mednafen.exe", MedPar)
        RealMedInput.Text = ""
        MedPar = ""
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox1.Items.Count <> ListBox2.Items.Count Then Button3.PerformClick() : Exit Sub

        If ListBox1.Items.Count > 0 And ListBox2.SelectedItem <> "" Then
            ListBox1.SelectedIndex = ListBox2.SelectedIndex

            If ListBox1.SelectedItem <> "Mouse" Then
                Dim splitpad() As String
                Dim splitid() As String
                splitpad = Split(ListBox2.SelectedItem, " ")
                PadType = LCase(splitpad(0).Trim)
                splitid = Split(ListBox2.SelectedItem, " ID:")

                Dim i As Integer
                If DMedConf = "mednafen" Then
                    i = 0
                Else
                    i = 1
                End If

                splitid = Split(splitid(i), " ")
                UniqueId = splitid(1).Trim
            End If

            RealMedInput.Text = ""
        End If

        If PadInputName.Items.Count > 0 Then
            For i = 0 To PadInputName.Items.Count - 1
                PadInputName.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboConsole.SelectedIndexChanged
        If ComboConsole.Text.Trim <> "" Then
            ComboPort.Items.Clear()
            ComboPort.Text = ""
            ComboPad.Items.Clear()
            ComboPad.Text = ""
            ParseTypePad()
        End If
    End Sub

    Private Sub ComboPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPort.SelectedIndexChanged
        ParseListInput()
    End Sub

    Private Sub ComboPad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPad.SelectedIndexChanged
        ParseNameListInput()
        ControlSpecificFileExist()
        AssignedInputValue()
    End Sub

    Private Sub TimerControl_Tick(sender As Object, e As EventArgs) Handles TimerControl.Tick
        If RealMedInput.Text.Trim <> "" Then
            Dim prova As String = " " & Chr(34) & PadType & " " & UniqueId & " " & RealMedInput.Text.Trim & Chr(34)
            MedPar = MedPar.Trim & prova
            TimerControl.Stop()
            AlreadyAssigned()
            If assigned = False Then
                If CheckBox1.Checked = False Then
                    ConfigPath = MedPath & "\" & DMedConf & ".cfg"
                Else
                    ConfigPath = MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg"
                End If
                EditConfig()
                AssignedInputValue()
                PadInputName.SetItemChecked(PadInputName.SelectedIndex, True)
            End If
            PadInputName.SelectedIndex = -1
        End If
    End Sub

    Private Sub RefreshPad()
        If MCF.Text.Trim = "" Then Exit Sub
        MedPar = Path.GetFileName(MCF.Text)
        MedPath = Path.GetDirectoryName(MCF.Text)

        If File.Exists(MedPath & "\mednafen.cfg") Then
            DMedConf = "mednafen"
        ElseIf File.Exists(MedPath & "\mednafen-09x.cfg") Then
            DMedConf = "mednafen-09x"
        End If

        If File.Exists(MedPath & "\mednafen.exe") = True Then
            LaunchPar()
            ParseJoypad()
        Else
            MCF.Text = ""
        End If
    End Sub

    Private Sub PadInputName_Click(sender As Object, e As EventArgs) Handles PadInputName.Click
        If PadInputName.SelectedItem <> "" Then
            RealMedInput.Text = ""
            RealMedInput.Focus()
            TimerControl.Stop()
            ReadParameter()
            If InputAlreadyAssigned.SelectedItem.ToString <> "Not Setted" Then
                CheckBox3.Enabled = True
            Else
                CheckBox3.Enabled = False
            End If
            TimerControl.Interval = 1000 \ 24
            TimerControl.Start()
        End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles RealMedInput.KeyUp
        PadType = "keyboard"
        tasti = e.KeyData.ToString
        vbkey = e.KeyData
        TransKeyTosdlKey()
        RealMedInput.Text = sdlKey
        If PadInputName.SelectedIndex < 0 Then Exit Sub
        If tasti <> "" Then
            Dim prova As String
            If vbkey = 46 Then
                prova = " " & Chr(34) & Nothing & Chr(34)
                RealMedInput.Text = ""
            Else
                prova = " " & Chr(34) & "keyboard " & sdlKey & Chr(34)
            End If

            AlreadyAssigned()
            If assigned = False Then
                MedPar = MedPar.Trim & prova
                If CheckBox1.Checked = False Then
                    ConfigPath = MedPath & "\" & DMedConf & ".cfg"
                Else
                    ConfigPath = MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg"
                End If
                EditConfig()
                AssignedInputValue()
                PadInputName.SetItemChecked(PadInputName.SelectedIndex, True)
            End If
            PadInputName.SelectedIndex = -1
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureMouse.MouseLeave
        PictureMouse.Refresh()
        RealMedInput.Text = ""
        PadType = ""
        Me.ActiveControl = Nothing
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureMouse.MouseClick
        Select Case (e.Button)
            Case MouseButtons.Left
                RealMedInput.Text = "00000000"
            Case MouseButtons.Right
                RealMedInput.Text = "00000002"
            Case MouseButtons.Middle
                RealMedInput.Text = "00000001"
            Case MouseButtons.XButton1
                RealMedInput.Text = "00000005"
            Case MouseButtons.XButton2
                RealMedInput.Text = "00000006"
        End Select

        ConvertNewMouse()
        MedMouse()
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureMouse.MouseWheel
        If e.Delta > 0 Then
            RealMedInput.Text = "00000003"
        ElseIf e.Delta < 0 Then
            RealMedInput.Text = "00000004"
        End If

        ConvertNewMouse()
        MedMouse()
    End Sub

    Private Sub PadInputName_MouseEnter(sender As Object, e As System.EventArgs) Handles PadInputName.MouseEnter
        PadInputName.Focus()
    End Sub

    Private Sub PadInputName_MouseLeave(sender As Object, e As System.EventArgs) Handles PadInputName.MouseLeave
        Me.ActiveControl = Nothing
    End Sub

    Private Sub PadInputName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PadInputName.SelectedIndexChanged
        If PadInputName.SelectedIndex >= 0 Then
            PadInputName.SetItemChecked(PadInputName.SelectedIndex, False)
            If InputAlreadyAssigned.Items.Count > 0 Then InputAlreadyAssigned.SelectedIndex = PadInputName.SelectedIndex
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureMouse.MouseMove
        If DMedConf = "mednafen-09x" Then
            If e.X > 0 And e.X < 90 Then
                Select Case e.X
                    Case < 25, > 75
                        If e.Y > 40 And e.Y < 60 Then
                            RealMedInput.Text = "00008000"
                            ConvertNewMouse()
                            MedMouse()
                            Exit Sub
                        End If
                End Select
            End If

            If e.Y > 0 And e.Y < 90 Then
                Select Case e.Y
                    Case < 25, > 75
                        If e.X > 40 And e.X < 60 Then
                            RealMedInput.Text = "00008001"
                            ConvertNewMouse()
                            MedMouse()
                            Exit Sub
                        End If
                End Select
            End If
        Else

            If e.X > 0 And e.X < 90 Then
                Select Case e.X
                    Case > 75
                        If e.Y > 40 And e.Y < 60 Then
                            RealMedInput.Text = "rel_x+"
                            MedMouse()
                            Exit Sub
                        End If
                    Case < 25
                        If e.Y > 40 And e.Y < 60 Then
                            RealMedInput.Text = "rel_x-"
                            MedMouse()
                            Exit Sub
                        End If
                End Select
            End If

            If e.Y > 0 And e.Y < 90 Then
                Select Case e.Y
                    Case > 75
                        If e.X > 40 And e.X < 60 Then
                            RealMedInput.Text = "rel_y+"
                            MedMouse()
                            Exit Sub
                        End If
                    Case < 25
                        If e.X > 40 And e.X < 60 Then
                            RealMedInput.Text = "rel_y-"
                            MedMouse()
                            Exit Sub
                        End If
                End Select
            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureMouse.MouseEnter
        ReleaseDevice()
        TimerControl.Stop()
        PictureMouse.Refresh()
        PictureMouse.Focus()
        Dim MLines As Graphics = PictureMouse.CreateGraphics()
        MLines.DrawLine(Pens.Red, CInt(PictureMouse.Width / 2), 0, CInt(PictureMouse.Width / 2), PictureMouse.Height)
        MLines.DrawLine(Pens.Red, 0, CInt(PictureMouse.Height / 2), PictureMouse.Width, CInt(PictureMouse.Height / 2))

        Dim buttonCentre As Point = New Point(PictureMouse.Width / 2, PictureMouse.Height / 2)
        Dim p As Point = PictureMouse.PointToScreen(buttonCentre)
        Cursor.Position = p
        If ListBox2.Items.Count > 0 Then PadType = LCase(ListBox2.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If File.Exists(MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg") Then
            Dim RDel = MsgBox("Do you want to delete this configuration file?", vbYesNo + MsgBoxStyle.Information, "Delete Specific Game Input Config...")
            If RDel = vbYes Then
                File.Delete(MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg")
                ControlSpecificFileExist()
                PadInputName.Items.Clear()
                InputAlreadyAssigned.Items.Clear()
            End If
        End If
    End Sub

    Private Sub SpecificGame_TextChanged(sender As Object, e As EventArgs) Handles SpecificGame.TextChanged
        ControlSpecificFileExist()
    End Sub

    Public Sub ControlSpecificFileExist()
        If File.Exists(MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg") Then
            Button4.Enabled = True
            CheckBox1.Checked = True
            SpecificGame.BackColor = Color.LightGreen
        Else
            Button4.Enabled = False
            CheckBox1.Checked = False
            SpecificGame.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub TimerXInput_Tick(sender As Object, e As EventArgs) Handles TimerXInput.Tick
        If gamepad.IsConnected = True Then
            Xstate = (gamepad.GetState())
            UpdateXInput()
        Else
            TimerXInput.Stop()
        End If
    End Sub

    Private Sub SpecialInput_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SpecialInput.Opening
        If File.Exists(MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg") And CheckBox1.Checked = True Then
            UnassignedAllInputToolStripMenuItem.Enabled = True
            RemoveThisPadFromConfigToolStripMenuItem.Enabled = True
            ConfigPath = MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg"
        Else
            UnassignedAllInputToolStripMenuItem.Enabled = False
            RemoveThisPadFromConfigToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub UnassignedAllInputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnassignedAllInputToolStripMenuItem.Click
        If InputAlreadyAssigned.Items.Count < 0 Then Exit Sub
        ResetThisPad()
        InputAlreadyAssigned.Items.Clear()
        PerAInputValue()
    End Sub

    Private Sub RemoveThisPadFromConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveThisPadFromConfigToolStripMenuItem.Click
        If InputAlreadyAssigned.Items.Count < 0 Then Exit Sub
        RemoveThisPad()
        InputAlreadyAssigned.Items.Clear()
        PerAInputValue()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browsefiledialog1 As New OpenFileDialog()
        browsefiledialog1.Filter = "All Mednafen Supported File|*.*"
        browsefiledialog1.Title = "Choose Mednafen Supported File"
        browsefiledialog1.ShowDialog()

        If browsefiledialog1.FileName <> "" Then
            SpecificGame.Text = Path.GetFileNameWithoutExtension(browsefiledialog1.FileName)
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub MedMouse()
        If PadInputName.SelectedIndex < 0 Then Exit Sub
        If RealMedInput.Text.Trim <> "" And PadType = "mouse" Then
            Dim prova As String = " " & Chr(34) & "mouse " & Mousecode & RealMedInput.Text & Chr(34)
            AlreadyAssigned()
            If assigned = False Then
                MedPar = MedPar.Trim & prova
                If CheckBox1.Checked = False Then
                    ConfigPath = MedPath & "\" & DMedConf & ".cfg"
                Else
                    ConfigPath = MedPath & "\pgconfig\" & SpecificGame.Text & "." & ComboConsole.Text & ".cfg"
                End If
                EditConfig()
                AssignedInputValue()
                PadInputName.SetItemChecked(PadInputName.SelectedIndex, True)
            End If
            PadInputName.SelectedIndex = -1
        End If
    End Sub

    Private Sub ConvertNewMouse()

        If DMedConf = "mednafen" Then
            RealMedInput.Text = Replace(RealMedInput.Text, "0000000", "button_")
        End If
    End Sub

    Private Sub AlreadyAssigned()
        assigned = False
        'Dim count As Integer = 0
        'For Each myItem In InputAlreadyAssigned.Items
        'If myItem = PadType & " " & RealMedInput.Text Then
        'Dim response = MsgBox(PadInputName.SelectedItem & " already assigned to " & PadInputName.Items(count) & vbCrLf &
        '                             "Do you want to assign it anyway?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Input assigned...")
        'If response = MsgBoxResult.Ok Then
        'assigned = False
        'Else
        'assigned = True
        'End If
        'Exit For
        'End If
        'count += 1
        'Next
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RealMedInput.KeyDown
        TimerControl.Stop()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ReleaseDevice()
    End Sub

End Class