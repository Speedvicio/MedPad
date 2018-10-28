<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedPad
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedPad))
        Me.TimerDInput = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PadInputName = New System.Windows.Forms.CheckedListBox()
        Me.SpecialInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UnassignedAllInputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveThisPadFromConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.InputAlreadyAssigned = New System.Windows.Forms.CheckedListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ComboPort = New System.Windows.Forms.ComboBox()
        Me.ComboPad = New System.Windows.Forms.ComboBox()
        Me.ComboConsole = New System.Windows.Forms.ComboBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.JButtons = New System.Windows.Forms.Label()
        Me.PictureMouse = New System.Windows.Forms.PictureBox()
        Me.JPov = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OvalPicture = New System.Windows.Forms.PictureBox()
        Me.PRYAxis = New System.Windows.Forms.ProgressBar()
        Me.PRXAxis = New System.Windows.Forms.ProgressBar()
        Me.PYAxys = New System.Windows.Forms.ProgressBar()
        Me.PXAxys = New System.Windows.Forms.ProgressBar()
        Me.RYAxis = New System.Windows.Forms.Label()
        Me.RXAxis = New System.Windows.Forms.Label()
        Me.YAxys = New System.Windows.Forms.Label()
        Me.XAxys = New System.Windows.Forms.Label()
        Me.ZAxis = New System.Windows.Forms.Label()
        Me.PZAxis = New System.Windows.Forms.ProgressBar()
        Me.PRZAxis = New System.Windows.Forms.ProgressBar()
        Me.RZAxis = New System.Windows.Forms.Label()
        Me.PicturePov = New System.Windows.Forms.PictureBox()
        Me.PictureRAxys = New System.Windows.Forms.PictureBox()
        Me.PictureAxys = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SpecificGame = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RealMedInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MCF = New System.Windows.Forms.TextBox()
        Me.TimerControl = New System.Windows.Forms.Timer(Me.components)
        Me.TimerXInput = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SpecialInput.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureMouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.OvalPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRAxys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAxys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerDInput
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 530)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 530)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Label9"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(523, 530)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(601, 530)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(145, 530)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Label23"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(12, 520)
        Me.ProgressBar4.Maximum = 2000
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar4.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(548, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 139)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connected Input"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(453, 108)
        Me.ListBox1.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Available Gamepad Connected")
        '
        'PadInputName
        '
        Me.PadInputName.ContextMenuStrip = Me.SpecialInput
        Me.PadInputName.FormattingEnabled = True
        Me.PadInputName.HorizontalScrollbar = True
        Me.PadInputName.Location = New System.Drawing.Point(190, 164)
        Me.PadInputName.Name = "PadInputName"
        Me.PadInputName.Size = New System.Drawing.Size(196, 259)
        Me.PadInputName.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.PadInputName, "- Left Click Select a Input to Set" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Right Click Open Advanced Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Del key A" &
        "fter Selected Input Removed Assigned Key")
        '
        'SpecialInput
        '
        Me.SpecialInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnassignedAllInputToolStripMenuItem, Me.RemoveThisPadFromConfigToolStripMenuItem})
        Me.SpecialInput.Name = "SpecialInput"
        Me.SpecialInput.Size = New System.Drawing.Size(236, 48)
        '
        'UnassignedAllInputToolStripMenuItem
        '
        Me.UnassignedAllInputToolStripMenuItem.Enabled = False
        Me.UnassignedAllInputToolStripMenuItem.Name = "UnassignedAllInputToolStripMenuItem"
        Me.UnassignedAllInputToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.UnassignedAllInputToolStripMenuItem.Text = "&Unassigned All Input"
        '
        'RemoveThisPadFromConfigToolStripMenuItem
        '
        Me.RemoveThisPadFromConfigToolStripMenuItem.Enabled = False
        Me.RemoveThisPadFromConfigToolStripMenuItem.Name = "RemoveThisPadFromConfigToolStripMenuItem"
        Me.RemoveThisPadFromConfigToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RemoveThisPadFromConfigToolStripMenuItem.Text = "&Remove This Pad From Config"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(463, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button1, "Select a Game Supported By Mednafen to Save a Specific Game Input Config")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 132)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox1.TabIndex = 57
        Me.CheckBox1.Text = "Save &Per Game Input"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Check This to Save a Per Game Input Configuration")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'InputAlreadyAssigned
        '
        Me.InputAlreadyAssigned.FormattingEnabled = True
        Me.InputAlreadyAssigned.HorizontalScrollbar = True
        Me.InputAlreadyAssigned.Location = New System.Drawing.Point(392, 164)
        Me.InputAlreadyAssigned.Name = "InputAlreadyAssigned"
        Me.InputAlreadyAssigned.Size = New System.Drawing.Size(127, 259)
        Me.InputAlreadyAssigned.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.InputAlreadyAssigned, "Assigned Vaule of Input (Ready Only)")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Select"
        Me.ToolTip1.SetToolTip(Me.Button2, "Select Mednafen Configuration File")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.MedPad.My.Resources.Resources.delete
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(494, 127)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 25)
        Me.Button4.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.Button4, "Delete a Specific Game Input Config (If it exist)")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.MedPad.My.Resources.Resources.update
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(61, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button3, "Refresh Connected Device")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 76)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox2.TabIndex = 60
        Me.CheckBox2.Text = "&DInput"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Force XInput Gamepad detection How Direct Input")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ComboPort
        '
        Me.ComboPort.FormattingEnabled = True
        Me.ComboPort.Location = New System.Drawing.Point(9, 220)
        Me.ComboPort.Name = "ComboPort"
        Me.ComboPort.Size = New System.Drawing.Size(175, 21)
        Me.ComboPort.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.ComboPort, "Select A Port For Player 1 to n")
        '
        'ComboPad
        '
        Me.ComboPad.FormattingEnabled = True
        Me.ComboPad.Location = New System.Drawing.Point(9, 260)
        Me.ComboPad.Name = "ComboPad"
        Me.ComboPad.Size = New System.Drawing.Size(175, 21)
        Me.ComboPad.Sorted = True
        Me.ComboPad.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.ComboPad, "Select a Input Device")
        '
        'ComboConsole
        '
        Me.ComboConsole.FormattingEnabled = True
        Me.ComboConsole.Items.AddRange(New Object() {"cdplay", "demo", "gb", "gba", "gg", "lynx", "md", "nes", "ngp", "pce", "pce_fast", "pcfx", "psx", "sms", "snes", "snes_faust", "ss", "vb", "wswan"})
        Me.ComboConsole.Location = New System.Drawing.Point(9, 180)
        Me.ComboConsole.Name = "ComboConsole"
        Me.ComboConsole.Size = New System.Drawing.Size(175, 21)
        Me.ComboConsole.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.ComboConsole, "Select A Module (Console)")
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.HorizontalScrollbar = True
        Me.ListBox2.Location = New System.Drawing.Point(92, 55)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(427, 69)
        Me.ListBox2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox2, "Recognized Gamepad By Mednafen")
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(92, 380)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox3.TabIndex = 61
        Me.CheckBox3.Text = "&Append"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Add another input to main input")
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(445, 530)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(367, 530)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Label18"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.JButtons)
        Me.GroupBox2.Controls.Add(Me.PictureMouse)
        Me.GroupBox2.Controls.Add(Me.JPov)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.PRYAxis)
        Me.GroupBox2.Controls.Add(Me.PRXAxis)
        Me.GroupBox2.Controls.Add(Me.PYAxys)
        Me.GroupBox2.Controls.Add(Me.PXAxys)
        Me.GroupBox2.Controls.Add(Me.RYAxis)
        Me.GroupBox2.Controls.Add(Me.RXAxis)
        Me.GroupBox2.Controls.Add(Me.YAxys)
        Me.GroupBox2.Controls.Add(Me.XAxys)
        Me.GroupBox2.Controls.Add(Me.ZAxis)
        Me.GroupBox2.Controls.Add(Me.PZAxis)
        Me.GroupBox2.Controls.Add(Me.PRZAxis)
        Me.GroupBox2.Controls.Add(Me.RZAxis)
        Me.GroupBox2.Controls.Add(Me.PicturePov)
        Me.GroupBox2.Controls.Add(Me.PictureRAxys)
        Me.GroupBox2.Controls.Add(Me.PictureAxys)
        Me.GroupBox2.Location = New System.Drawing.Point(548, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 297)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Tester"
        '
        'JButtons
        '
        Me.JButtons.AutoSize = True
        Me.JButtons.BackColor = System.Drawing.Color.Transparent
        Me.JButtons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JButtons.ForeColor = System.Drawing.Color.Firebrick
        Me.JButtons.Location = New System.Drawing.Point(295, 270)
        Me.JButtons.Name = "JButtons"
        Me.JButtons.Size = New System.Drawing.Size(28, 16)
        Me.JButtons.TabIndex = 15
        Me.JButtons.Text = "....."
        Me.JButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureMouse
        '
        Me.PictureMouse.BackColor = System.Drawing.Color.White
        Me.PictureMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureMouse.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureMouse.Enabled = False
        Me.PictureMouse.Image = Global.MedPad.My.Resources.Resources.squaremouse
        Me.PictureMouse.Location = New System.Drawing.Point(17, 186)
        Me.PictureMouse.Name = "PictureMouse"
        Me.PictureMouse.Size = New System.Drawing.Size(100, 100)
        Me.PictureMouse.TabIndex = 57
        Me.PictureMouse.TabStop = False
        '
        'JPov
        '
        Me.JPov.AutoSize = True
        Me.JPov.Location = New System.Drawing.Point(123, 19)
        Me.JPov.Name = "JPov"
        Me.JPov.Size = New System.Drawing.Size(43, 13)
        Me.JPov.TabIndex = 56
        Me.JPov.Text = "  JPov  "
        Me.JPov.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OvalPicture)
        Me.Panel1.Location = New System.Drawing.Point(189, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 55
        '
        'OvalPicture
        '
        Me.OvalPicture.BackgroundImage = Global.MedPad.My.Resources.Resources.BUP
        Me.OvalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OvalPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OvalPicture.Location = New System.Drawing.Point(0, 0)
        Me.OvalPicture.Name = "OvalPicture"
        Me.OvalPicture.Size = New System.Drawing.Size(100, 100)
        Me.OvalPicture.TabIndex = 0
        Me.OvalPicture.TabStop = False
        '
        'PRYAxis
        '
        Me.PRYAxis.Enabled = False
        Me.PRYAxis.Location = New System.Drawing.Point(361, 157)
        Me.PRYAxis.Maximum = 2000
        Me.PRYAxis.Name = "PRYAxis"
        Me.PRYAxis.Size = New System.Drawing.Size(100, 23)
        Me.PRYAxis.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PRYAxis.TabIndex = 53
        '
        'PRXAxis
        '
        Me.PRXAxis.Enabled = False
        Me.PRXAxis.Location = New System.Drawing.Point(361, 126)
        Me.PRXAxis.Maximum = 2000
        Me.PRXAxis.Name = "PRXAxis"
        Me.PRXAxis.Size = New System.Drawing.Size(100, 23)
        Me.PRXAxis.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PRXAxis.TabIndex = 52
        '
        'PYAxys
        '
        Me.PYAxys.Enabled = False
        Me.PYAxys.Location = New System.Drawing.Point(189, 157)
        Me.PYAxys.Maximum = 2000
        Me.PYAxys.Name = "PYAxys"
        Me.PYAxys.Size = New System.Drawing.Size(100, 23)
        Me.PYAxys.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PYAxys.TabIndex = 51
        '
        'PXAxys
        '
        Me.PXAxys.Enabled = False
        Me.PXAxys.Location = New System.Drawing.Point(189, 125)
        Me.PXAxys.Maximum = 2000
        Me.PXAxys.Name = "PXAxys"
        Me.PXAxys.Size = New System.Drawing.Size(100, 23)
        Me.PXAxys.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PXAxys.TabIndex = 50
        '
        'RYAxis
        '
        Me.RYAxis.AutoSize = True
        Me.RYAxis.Location = New System.Drawing.Point(358, 221)
        Me.RYAxis.Name = "RYAxis"
        Me.RYAxis.Size = New System.Drawing.Size(41, 13)
        Me.RYAxis.TabIndex = 49
        Me.RYAxis.Text = "RYAzis"
        Me.RYAxis.Visible = False
        '
        'RXAxis
        '
        Me.RXAxis.AutoSize = True
        Me.RXAxis.Location = New System.Drawing.Point(358, 196)
        Me.RXAxis.Name = "RXAxis"
        Me.RXAxis.Size = New System.Drawing.Size(41, 13)
        Me.RXAxis.TabIndex = 48
        Me.RXAxis.Text = "RXAzis"
        Me.RXAxis.Visible = False
        '
        'YAxys
        '
        Me.YAxys.AutoSize = True
        Me.YAxys.Location = New System.Drawing.Point(295, 157)
        Me.YAxys.Name = "YAxys"
        Me.YAxys.Size = New System.Drawing.Size(36, 13)
        Me.YAxys.TabIndex = 47
        Me.YAxys.Text = "YAxys"
        Me.YAxys.Visible = False
        '
        'XAxys
        '
        Me.XAxys.AutoSize = True
        Me.XAxys.Location = New System.Drawing.Point(295, 125)
        Me.XAxys.Name = "XAxys"
        Me.XAxys.Size = New System.Drawing.Size(36, 13)
        Me.XAxys.TabIndex = 46
        Me.XAxys.Text = "XAxys"
        Me.XAxys.Visible = False
        '
        'ZAxis
        '
        Me.ZAxis.AutoSize = True
        Me.ZAxis.Location = New System.Drawing.Point(123, 126)
        Me.ZAxis.Name = "ZAxis"
        Me.ZAxis.Size = New System.Drawing.Size(33, 13)
        Me.ZAxis.TabIndex = 45
        Me.ZAxis.Text = "ZAxis"
        Me.ZAxis.Visible = False
        '
        'PZAxis
        '
        Me.PZAxis.Enabled = False
        Me.PZAxis.Location = New System.Drawing.Point(17, 125)
        Me.PZAxis.Maximum = 2000
        Me.PZAxis.Name = "PZAxis"
        Me.PZAxis.Size = New System.Drawing.Size(100, 24)
        Me.PZAxis.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PZAxis.TabIndex = 44
        '
        'PRZAxis
        '
        Me.PRZAxis.Enabled = False
        Me.PRZAxis.Location = New System.Drawing.Point(17, 157)
        Me.PRZAxis.Maximum = 2000
        Me.PRZAxis.Name = "PRZAxis"
        Me.PRZAxis.Size = New System.Drawing.Size(100, 23)
        Me.PRZAxis.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PRZAxis.TabIndex = 43
        '
        'RZAxis
        '
        Me.RZAxis.AutoSize = True
        Me.RZAxis.Location = New System.Drawing.Point(123, 157)
        Me.RZAxis.Name = "RZAxis"
        Me.RZAxis.Size = New System.Drawing.Size(41, 13)
        Me.RZAxis.TabIndex = 42
        Me.RZAxis.Text = "RZAxis"
        Me.RZAxis.Visible = False
        '
        'PicturePov
        '
        Me.PicturePov.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PicturePov.Enabled = False
        Me.PicturePov.Location = New System.Drawing.Point(17, 19)
        Me.PicturePov.Name = "PicturePov"
        Me.PicturePov.Size = New System.Drawing.Size(100, 100)
        Me.PicturePov.TabIndex = 41
        Me.PicturePov.TabStop = False
        '
        'PictureRAxys
        '
        Me.PictureRAxys.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureRAxys.Enabled = False
        Me.PictureRAxys.Location = New System.Drawing.Point(361, 19)
        Me.PictureRAxys.Name = "PictureRAxys"
        Me.PictureRAxys.Size = New System.Drawing.Size(100, 100)
        Me.PictureRAxys.TabIndex = 40
        Me.PictureRAxys.TabStop = False
        '
        'PictureAxys
        '
        Me.PictureAxys.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureAxys.Enabled = False
        Me.PictureAxys.Location = New System.Drawing.Point(189, 19)
        Me.PictureAxys.Name = "PictureAxys"
        Me.PictureAxys.Size = New System.Drawing.Size(100, 100)
        Me.PictureAxys.TabIndex = 39
        Me.PictureAxys.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.SpecificGame)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.InputAlreadyAssigned)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.PadInputName)
        Me.GroupBox3.Controls.Add(Me.ComboPort)
        Me.GroupBox3.Controls.Add(Me.ComboPad)
        Me.GroupBox3.Controls.Add(Me.ComboConsole)
        Me.GroupBox3.Controls.Add(Me.RealMedInput)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.MCF)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(530, 442)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mednafen Input Configurator"
        '
        'SpecificGame
        '
        Me.SpecificGame.Location = New System.Drawing.Point(143, 130)
        Me.SpecificGame.Name = "SpecificGame"
        Me.SpecificGame.Size = New System.Drawing.Size(314, 20)
        Me.SpecificGame.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Port"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Device"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Console"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Mednafen Input"
        '
        'RealMedInput
        '
        Me.RealMedInput.Location = New System.Drawing.Point(92, 403)
        Me.RealMedInput.MaxLength = 8
        Me.RealMedInput.Name = "RealMedInput"
        Me.RealMedInput.Size = New System.Drawing.Size(92, 20)
        Me.RealMedInput.TabIndex = 42
        Me.RealMedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Available Pad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mednafen Config File"
        '
        'MCF
        '
        Me.MCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MedPad.My.MySettings.Default, "MednafenPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MCF.Location = New System.Drawing.Point(119, 21)
        Me.MCF.Name = "MCF"
        Me.MCF.Size = New System.Drawing.Size(319, 20)
        Me.MCF.TabIndex = 0
        Me.MCF.Text = Global.MedPad.My.MySettings.Default.MednafenPath
        '
        'TimerControl
        '
        '
        'TimerXInput
        '
        '
        'MedPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 463)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MedPad"
        Me.Text = "MedPad - Mednafen Pad Configurator"
        Me.GroupBox1.ResumeLayout(False)
        Me.SpecialInput.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureMouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.OvalPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRAxys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAxys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerDInput As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents JPov As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PRYAxis As ProgressBar
    Friend WithEvents PRXAxis As ProgressBar
    Friend WithEvents PYAxys As ProgressBar
    Friend WithEvents PXAxys As ProgressBar
    Friend WithEvents RYAxis As Label
    Friend WithEvents RXAxis As Label
    Friend WithEvents YAxys As Label
    Friend WithEvents XAxys As Label
    Friend WithEvents ZAxis As Label
    Friend WithEvents PZAxis As ProgressBar
    Friend WithEvents PRZAxis As ProgressBar
    Friend WithEvents RZAxis As Label
    Friend WithEvents PicturePov As PictureBox
    Friend WithEvents PictureRAxys As PictureBox
    Friend WithEvents PictureAxys As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MCF As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboConsole As ComboBox
    Friend WithEvents ComboPad As ComboBox
    Friend WithEvents ComboPort As ComboBox
    Friend WithEvents PadInputName As CheckedListBox
    Friend WithEvents TimerControl As Timer
    Friend WithEvents InputAlreadyAssigned As CheckedListBox
    Friend WithEvents PictureMouse As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RealMedInput As TextBox
    Friend WithEvents SpecificGame As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents OvalPicture As PictureBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TimerXInput As Timer
    Friend WithEvents JButtons As Label
    Friend WithEvents SpecialInput As ContextMenuStrip
    Friend WithEvents UnassignedAllInputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveThisPadFromConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox3 As CheckBox
End Class
