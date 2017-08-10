<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.tmrWatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCount = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartBot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMousePosition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMousePositionAddItem = New System.Windows.Forms.Timer(Me.components)
        Me.ControlTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnStartBs = New BillardBot.FlatButton()
        Me.btnWinPos = New BillardBot.FlatButton()
        Me.btnStart = New BillardBot.FlatButton()
        Me.btnKillAll = New BillardBot.FlatButton()
        Me.btnStop = New BillardBot.FlatButton()
        Me.btnMoreOptions = New BillardBot.FlatButton()
        Me.btnStopCoordinates = New BillardBot.FlatButton()
        Me.btnGetCoordinates = New BillardBot.FlatButton()
        Me.txtMin = New BillardBot.FlatTextBox()
        Me.txtSecs = New BillardBot.FlatTextBox()
        Me.btnSave = New BillardBot.FlatButton()
        Me.LoopCheckBox = New BillardBot.FlatCheckBox()
        Me.posXbox = New BillardBot.FlatTextBox()
        Me.posYbox = New BillardBot.FlatTextBox()
        Me.tmrCheckRunningBots = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMath = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBitBull = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BillardBot.FormSkin()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatTabControl1 = New BillardBot.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DebuggerList = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRestarterBot = New BillardBot.FlatButton()
        Me.lblClosedTimes = New System.Windows.Forms.Label()
        Me.btnResetClosed = New BillardBot.FlatButton()
        Me.BtnSaveLog = New BillardBot.FlatButton()
        Me.btnClearLog = New BillardBot.FlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblActiveBots = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSaveResultsToLog = New BillardBot.FlatButton()
        Me.txtFinalResults = New System.Windows.Forms.TextBox()
        Me.FlatButton3 = New BillardBot.FlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtStartLootDate = New System.Windows.Forms.TextBox()
        Me.lblStartLootDate = New System.Windows.Forms.Label()
        Me.lblLootResults = New System.Windows.Forms.Label()
        Me.FlatButton2 = New BillardBot.FlatButton()
        Me.FlatButton1 = New BillardBot.FlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndingLoot = New BillardBot.FlatTextBox()
        Me.txtStartingLoot = New BillardBot.FlatTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BotBox1 = New BillardBot.FlatCheckBox()
        Me.BotBox4 = New BillardBot.FlatCheckBox()
        Me.BotBox2 = New BillardBot.FlatCheckBox()
        Me.BotBox3 = New BillardBot.FlatCheckBox()
        Me.btnOpenLogs = New BillardBot.FlatButton()
        Me.FlatComboBox1 = New BillardBot.FlatComboBox()
        Me.CoordinatesList = New BillardBot.FlatListBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDebugger = New BillardBot.FlatStatusBar()
        Me.FlatMini1 = New BillardBot.FlatMini()
        Me.FlatClose1 = New BillardBot.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrWatchDog
        '
        '
        'tmrCount
        '
        Me.tmrCount.Interval = 1000
        '
        'tmrStartBot
        '
        '
        'tmrMousePosition
        '
        '
        'tmrMousePositionAddItem
        '
        Me.tmrMousePositionAddItem.Interval = 800
        '
        'btnStartBs
        '
        Me.btnStartBs.BackColor = System.Drawing.Color.Transparent
        Me.btnStartBs.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStartBs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartBs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStartBs.Location = New System.Drawing.Point(255, 4)
        Me.btnStartBs.Name = "btnStartBs"
        Me.btnStartBs.Rounded = False
        Me.btnStartBs.Size = New System.Drawing.Size(56, 30)
        Me.btnStartBs.TabIndex = 16
        Me.btnStartBs.Text = "BS"
        Me.btnStartBs.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnStartBs, "Start BlueStacks if it isn't already active")
        '
        'btnWinPos
        '
        Me.btnWinPos.BackColor = System.Drawing.Color.Transparent
        Me.btnWinPos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnWinPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWinPos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnWinPos.Location = New System.Drawing.Point(193, 4)
        Me.btnWinPos.Name = "btnWinPos"
        Me.btnWinPos.Rounded = False
        Me.btnWinPos.Size = New System.Drawing.Size(61, 30)
        Me.btnWinPos.TabIndex = 3
        Me.btnWinPos.Text = "PoS"
        Me.btnWinPos.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnWinPos, "Position the bot to the top left corner")
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(6, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Rounded = False
        Me.btnStart.Size = New System.Drawing.Size(61, 30)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnStart, "Start all AutoIT Bots")
        '
        'btnKillAll
        '
        Me.btnKillAll.BackColor = System.Drawing.Color.Transparent
        Me.btnKillAll.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnKillAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKillAll.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnKillAll.Location = New System.Drawing.Point(131, 4)
        Me.btnKillAll.Name = "btnKillAll"
        Me.btnKillAll.Rounded = False
        Me.btnKillAll.Size = New System.Drawing.Size(61, 30)
        Me.btnKillAll.TabIndex = 2
        Me.btnKillAll.Text = "Kill All"
        Me.btnKillAll.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnKillAll, "Kill process of all bots and bluestacks")
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStop.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnStop.Location = New System.Drawing.Point(69, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Rounded = False
        Me.btnStop.Size = New System.Drawing.Size(61, 30)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnStop, "Stop all AutoIT Bots")
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreOptions.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnMoreOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreOptions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMoreOptions.Location = New System.Drawing.Point(7, 104)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Rounded = False
        Me.btnMoreOptions.Size = New System.Drawing.Size(133, 25)
        Me.btnMoreOptions.TabIndex = 21
        Me.btnMoreOptions.Text = "Processes"
        Me.btnMoreOptions.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnMoreOptions, "Extra options to see what processes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are left opened from Bluestacks")
        '
        'btnStopCoordinates
        '
        Me.btnStopCoordinates.BackColor = System.Drawing.Color.Transparent
        Me.btnStopCoordinates.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStopCoordinates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopCoordinates.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStopCoordinates.Location = New System.Drawing.Point(7, 135)
        Me.btnStopCoordinates.Name = "btnStopCoordinates"
        Me.btnStopCoordinates.Rounded = False
        Me.btnStopCoordinates.Size = New System.Drawing.Size(133, 27)
        Me.btnStopCoordinates.TabIndex = 18
        Me.btnStopCoordinates.Text = "Stop"
        Me.btnStopCoordinates.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnStopCoordinates, "Stop searching for coordinates")
        '
        'btnGetCoordinates
        '
        Me.btnGetCoordinates.BackColor = System.Drawing.Color.Transparent
        Me.btnGetCoordinates.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnGetCoordinates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetCoordinates.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGetCoordinates.Location = New System.Drawing.Point(7, 73)
        Me.btnGetCoordinates.Name = "btnGetCoordinates"
        Me.btnGetCoordinates.Rounded = False
        Me.btnGetCoordinates.Size = New System.Drawing.Size(133, 25)
        Me.btnGetCoordinates.TabIndex = 17
        Me.btnGetCoordinates.Text = "Search"
        Me.btnGetCoordinates.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnGetCoordinates, "Start searching for coordinates")
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.Transparent
        Me.txtMin.Location = New System.Drawing.Point(11, 19)
        Me.txtMin.MaxLength = 32767
        Me.txtMin.Multiline = False
        Me.txtMin.Name = "txtMin"
        Me.txtMin.ReadOnly = False
        Me.txtMin.Size = New System.Drawing.Size(47, 29)
        Me.txtMin.TabIndex = 7
        Me.txtMin.Text = "25"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMin.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.txtMin, "Set minutes of botting before restarting")
        Me.txtMin.UseSystemPasswordChar = False
        '
        'txtSecs
        '
        Me.txtSecs.BackColor = System.Drawing.Color.Transparent
        Me.txtSecs.Location = New System.Drawing.Point(62, 19)
        Me.txtSecs.MaxLength = 32767
        Me.txtSecs.Multiline = False
        Me.txtSecs.Name = "txtSecs"
        Me.txtSecs.ReadOnly = False
        Me.txtSecs.Size = New System.Drawing.Size(47, 29)
        Me.txtSecs.TabIndex = 8
        Me.txtSecs.Text = "15"
        Me.txtSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSecs.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.txtSecs, "Set seconds of botting before restarting")
        Me.txtSecs.UseSystemPasswordChar = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.Cyan
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Cyan
        Me.btnSave.Location = New System.Drawing.Point(115, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(78, 26)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.btnSave, "Save your set minutes from Settings Tab")
        '
        'LoopCheckBox
        '
        Me.LoopCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LoopCheckBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LoopCheckBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LoopCheckBox.Checked = False
        Me.LoopCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoopCheckBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LoopCheckBox.Location = New System.Drawing.Point(39, 22)
        Me.LoopCheckBox.Name = "LoopCheckBox"
        Me.LoopCheckBox.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.LoopCheckBox.Size = New System.Drawing.Size(112, 22)
        Me.LoopCheckBox.TabIndex = 0
        Me.LoopCheckBox.Text = "Always Loop"
        Me.ControlTip.SetToolTip(Me.LoopCheckBox, "Automatically start botting when opened")
        '
        'posXbox
        '
        Me.posXbox.BackColor = System.Drawing.Color.Transparent
        Me.posXbox.Location = New System.Drawing.Point(44, 179)
        Me.posXbox.MaxLength = 32767
        Me.posXbox.Multiline = False
        Me.posXbox.Name = "posXbox"
        Me.posXbox.ReadOnly = False
        Me.posXbox.Size = New System.Drawing.Size(116, 29)
        Me.posXbox.TabIndex = 12
        Me.posXbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.posXbox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.posXbox, "Get your X mouse coordinates")
        Me.posXbox.UseSystemPasswordChar = False
        '
        'posYbox
        '
        Me.posYbox.BackColor = System.Drawing.Color.Transparent
        Me.posYbox.Location = New System.Drawing.Point(234, 179)
        Me.posYbox.MaxLength = 32767
        Me.posYbox.Multiline = False
        Me.posYbox.Name = "posYbox"
        Me.posYbox.ReadOnly = False
        Me.posYbox.Size = New System.Drawing.Size(118, 29)
        Me.posYbox.TabIndex = 13
        Me.posYbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.posYbox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ControlTip.SetToolTip(Me.posYbox, "Get your Y mouse coordinates")
        Me.posYbox.UseSystemPasswordChar = False
        '
        'tmrCheckRunningBots
        '
        Me.tmrCheckRunningBots.Interval = 1000
        '
        'tmrMath
        '
        Me.tmrMath.Interval = 1000
        '
        'tmrBitBull
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.lblDebugger)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(385, 526)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "BillardBot - Miniclip 8 Ball Pool"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "DATE: 08-10-17"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(3, 77)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(374, 420)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DebuggerList)
        Me.TabPage1.Controls.Add(Me.btnStartBs)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.lblSec)
        Me.TabPage1.Controls.Add(Me.btnWinPos)
        Me.TabPage1.Controls.Add(Me.btnStart)
        Me.TabPage1.Controls.Add(Me.lblMin)
        Me.TabPage1.Controls.Add(Me.btnKillAll)
        Me.TabPage1.Controls.Add(Me.btnStop)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(366, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BillardBot"
        '
        'DebuggerList
        '
        Me.DebuggerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DebuggerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DebuggerList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DebuggerList.ForeColor = System.Drawing.Color.YellowGreen
        Me.DebuggerList.FormattingEnabled = True
        Me.DebuggerList.ItemHeight = 17
        Me.DebuggerList.Location = New System.Drawing.Point(3, 180)
        Me.DebuggerList.Name = "DebuggerList"
        Me.DebuggerList.Size = New System.Drawing.Size(360, 189)
        Me.DebuggerList.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRestarterBot)
        Me.Panel1.Controls.Add(Me.lblClosedTimes)
        Me.Panel1.Controls.Add(Me.btnResetClosed)
        Me.Panel1.Controls.Add(Me.BtnSaveLog)
        Me.Panel1.Controls.Add(Me.btnClearLog)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblActiveBots)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(8, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 129)
        Me.Panel1.TabIndex = 15
        '
        'btnRestarterBot
        '
        Me.btnRestarterBot.BackColor = System.Drawing.Color.Transparent
        Me.btnRestarterBot.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRestarterBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestarterBot.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRestarterBot.Location = New System.Drawing.Point(6, 73)
        Me.btnRestarterBot.Name = "btnRestarterBot"
        Me.btnRestarterBot.Rounded = False
        Me.btnRestarterBot.Size = New System.Drawing.Size(227, 24)
        Me.btnRestarterBot.TabIndex = 0
        Me.btnRestarterBot.Text = "RestarterBot"
        Me.btnRestarterBot.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblClosedTimes
        '
        Me.lblClosedTimes.AutoSize = True
        Me.lblClosedTimes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosedTimes.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblClosedTimes.Location = New System.Drawing.Point(93, 38)
        Me.lblClosedTimes.Name = "lblClosedTimes"
        Me.lblClosedTimes.Size = New System.Drawing.Size(19, 21)
        Me.lblClosedTimes.TabIndex = 19
        Me.lblClosedTimes.Text = "0"
        '
        'btnResetClosed
        '
        Me.btnResetClosed.BackColor = System.Drawing.Color.Transparent
        Me.btnResetClosed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResetClosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetClosed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnResetClosed.Location = New System.Drawing.Point(184, 38)
        Me.btnResetClosed.Name = "btnResetClosed"
        Me.btnResetClosed.Rounded = False
        Me.btnResetClosed.Size = New System.Drawing.Size(49, 23)
        Me.btnResetClosed.TabIndex = 25
        Me.btnResetClosed.Text = "Reset"
        Me.btnResetClosed.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BtnSaveLog
        '
        Me.BtnSaveLog.BackColor = System.Drawing.Color.Transparent
        Me.BtnSaveLog.BaseColor = System.Drawing.Color.Cyan
        Me.BtnSaveLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveLog.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnSaveLog.Location = New System.Drawing.Point(94, 100)
        Me.BtnSaveLog.Name = "BtnSaveLog"
        Me.BtnSaveLog.Rounded = False
        Me.BtnSaveLog.Size = New System.Drawing.Size(139, 24)
        Me.BtnSaveLog.TabIndex = 24
        Me.BtnSaveLog.Text = "Save Log"
        Me.BtnSaveLog.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClearLog
        '
        Me.btnClearLog.BackColor = System.Drawing.Color.Transparent
        Me.btnClearLog.BaseColor = System.Drawing.Color.Cyan
        Me.btnClearLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearLog.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClearLog.Location = New System.Drawing.Point(6, 100)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Rounded = False
        Me.btnClearLog.Size = New System.Drawing.Size(82, 24)
        Me.btnClearLog.TabIndex = 23
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(9, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "RESET TIMES:"
        '
        'lblActiveBots
        '
        Me.lblActiveBots.AutoSize = True
        Me.lblActiveBots.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveBots.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveBots.ForeColor = System.Drawing.Color.Silver
        Me.lblActiveBots.Location = New System.Drawing.Point(8, 21)
        Me.lblActiveBots.Name = "lblActiveBots"
        Me.lblActiveBots.Size = New System.Drawing.Size(109, 13)
        Me.lblActiveBots.TabIndex = 20
        Me.lblActiveBots.Text = "STATUS: Waiting..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(9, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "_______________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(57, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "LIST OF ACTIVE BOTS"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblSec.ForeColor = System.Drawing.Color.Gray
        Me.lblSec.Location = New System.Drawing.Point(325, 7)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(32, 24)
        Me.lblSec.TabIndex = 14
        Me.lblSec.Text = "SS"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Tahoma", 50.0!)
        Me.lblMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMin.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblMin.Location = New System.Drawing.Point(255, 66)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(107, 81)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "oo"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnSaveResultsToLog)
        Me.TabPage2.Controls.Add(Me.txtFinalResults)
        Me.TabPage2.Controls.Add(Me.FlatButton3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(366, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Progress Stats"
        '
        'btnSaveResultsToLog
        '
        Me.btnSaveResultsToLog.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveResultsToLog.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSaveResultsToLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveResultsToLog.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSaveResultsToLog.Location = New System.Drawing.Point(234, 200)
        Me.btnSaveResultsToLog.Name = "btnSaveResultsToLog"
        Me.btnSaveResultsToLog.Rounded = False
        Me.btnSaveResultsToLog.Size = New System.Drawing.Size(119, 32)
        Me.btnSaveResultsToLog.TabIndex = 14
        Me.btnSaveResultsToLog.Text = "Save To Log"
        Me.btnSaveResultsToLog.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtFinalResults
        '
        Me.txtFinalResults.Location = New System.Drawing.Point(14, 238)
        Me.txtFinalResults.Multiline = True
        Me.txtFinalResults.Name = "txtFinalResults"
        Me.txtFinalResults.Size = New System.Drawing.Size(339, 121)
        Me.txtFinalResults.TabIndex = 12
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(14, 200)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(214, 32)
        Me.FlatButton3.TabIndex = 11
        Me.FlatButton3.Text = "Add Final Results"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtStartLootDate)
        Me.GroupBox1.Controls.Add(Me.lblStartLootDate)
        Me.GroupBox1.Controls.Add(Me.lblLootResults)
        Me.GroupBox1.Controls.Add(Me.FlatButton2)
        Me.GroupBox1.Controls.Add(Me.FlatButton1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEndingLoot)
        Me.GroupBox1.Controls.Add(Me.txtStartingLoot)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 188)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistics "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtStartLootDate
        '
        Me.txtStartLootDate.Location = New System.Drawing.Point(9, 126)
        Me.txtStartLootDate.Name = "txtStartLootDate"
        Me.txtStartLootDate.Size = New System.Drawing.Size(327, 23)
        Me.txtStartLootDate.TabIndex = 11
        '
        'lblStartLootDate
        '
        Me.lblStartLootDate.AutoSize = True
        Me.lblStartLootDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblStartLootDate.Location = New System.Drawing.Point(6, 107)
        Me.lblStartLootDate.Name = "lblStartLootDate"
        Me.lblStartLootDate.Size = New System.Drawing.Size(161, 19)
        Me.lblStartLootDate.TabIndex = 26
        Me.lblStartLootDate.Text = "Set date of coin records:"
        '
        'lblLootResults
        '
        Me.lblLootResults.AutoSize = True
        Me.lblLootResults.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLootResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLootResults.Location = New System.Drawing.Point(49, 75)
        Me.lblLootResults.Name = "lblLootResults"
        Me.lblLootResults.Size = New System.Drawing.Size(23, 25)
        Me.lblLootResults.TabIndex = 25
        Me.lblLootResults.Text = "0"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatButton2.Location = New System.Drawing.Point(253, 94)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(81, 26)
        Me.FlatButton2.TabIndex = 24
        Me.FlatButton2.Text = "Set Date"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Cyan
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.ForeColor = System.Drawing.Color.Cyan
        Me.FlatButton1.Location = New System.Drawing.Point(11, 155)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(323, 26)
        Me.FlatButton1.TabIndex = 22
        Me.FlatButton1.Text = "save"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(203, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "End Loot"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(12, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Start Loot"
        '
        'txtEndingLoot
        '
        Me.txtEndingLoot.BackColor = System.Drawing.Color.Transparent
        Me.txtEndingLoot.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndingLoot.Location = New System.Drawing.Point(206, 34)
        Me.txtEndingLoot.MaxLength = 32767
        Me.txtEndingLoot.Multiline = False
        Me.txtEndingLoot.Name = "txtEndingLoot"
        Me.txtEndingLoot.ReadOnly = False
        Me.txtEndingLoot.Size = New System.Drawing.Size(128, 31)
        Me.txtEndingLoot.TabIndex = 1
        Me.txtEndingLoot.Text = "0"
        Me.txtEndingLoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEndingLoot.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEndingLoot.UseSystemPasswordChar = False
        '
        'txtStartingLoot
        '
        Me.txtStartingLoot.BackColor = System.Drawing.Color.Transparent
        Me.txtStartingLoot.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingLoot.Location = New System.Drawing.Point(9, 34)
        Me.txtStartingLoot.MaxLength = 32767
        Me.txtStartingLoot.Multiline = False
        Me.txtStartingLoot.Name = "txtStartingLoot"
        Me.txtStartingLoot.ReadOnly = False
        Me.txtStartingLoot.Size = New System.Drawing.Size(128, 31)
        Me.txtStartingLoot.TabIndex = 0
        Me.txtStartingLoot.Text = "0"
        Me.txtStartingLoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtStartingLoot.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtStartingLoot.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.btnOpenLogs)
        Me.TabPage3.Controls.Add(Me.FlatComboBox1)
        Me.TabPage3.Controls.Add(Me.btnMoreOptions)
        Me.TabPage3.Controls.Add(Me.btnStopCoordinates)
        Me.TabPage3.Controls.Add(Me.btnGetCoordinates)
        Me.TabPage3.Controls.Add(Me.CoordinatesList)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.posXbox)
        Me.TabPage3.Controls.Add(Me.posYbox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(366, 372)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BotBox1)
        Me.GroupBox4.Controls.Add(Me.BotBox4)
        Me.GroupBox4.Controls.Add(Me.BotBox2)
        Me.GroupBox4.Controls.Add(Me.BotBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 53)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "How many bots you want to run at a time?"
        '
        'BotBox1
        '
        Me.BotBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BotBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BotBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BotBox1.Checked = False
        Me.BotBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BotBox1.Location = New System.Drawing.Point(6, 19)
        Me.BotBox1.Name = "BotBox1"
        Me.BotBox1.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.BotBox1.Size = New System.Drawing.Size(42, 22)
        Me.BotBox1.TabIndex = 24
        Me.BotBox1.Text = "1"
        '
        'BotBox4
        '
        Me.BotBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BotBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BotBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BotBox4.Checked = False
        Me.BotBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BotBox4.Location = New System.Drawing.Point(143, 19)
        Me.BotBox4.Name = "BotBox4"
        Me.BotBox4.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.BotBox4.Size = New System.Drawing.Size(43, 22)
        Me.BotBox4.TabIndex = 24
        Me.BotBox4.Text = "6"
        '
        'BotBox2
        '
        Me.BotBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BotBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BotBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BotBox2.Checked = False
        Me.BotBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BotBox2.Location = New System.Drawing.Point(49, 19)
        Me.BotBox2.Name = "BotBox2"
        Me.BotBox2.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.BotBox2.Size = New System.Drawing.Size(43, 22)
        Me.BotBox2.TabIndex = 24
        Me.BotBox2.Text = "2"
        '
        'BotBox3
        '
        Me.BotBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BotBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BotBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BotBox3.Checked = False
        Me.BotBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BotBox3.Location = New System.Drawing.Point(96, 19)
        Me.BotBox3.Name = "BotBox3"
        Me.BotBox3.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.BotBox3.Size = New System.Drawing.Size(43, 22)
        Me.BotBox3.TabIndex = 24
        Me.BotBox3.Text = "4"
        '
        'btnOpenLogs
        '
        Me.btnOpenLogs.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenLogs.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnOpenLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenLogs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOpenLogs.Location = New System.Drawing.Point(281, 214)
        Me.btnOpenLogs.Name = "btnOpenLogs"
        Me.btnOpenLogs.Rounded = False
        Me.btnOpenLogs.Size = New System.Drawing.Size(81, 24)
        Me.btnOpenLogs.TabIndex = 23
        Me.btnOpenLogs.Text = "Open"
        Me.btnOpenLogs.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Location = New System.Drawing.Point(7, 214)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(268, 24)
        Me.FlatComboBox1.TabIndex = 22
        '
        'CoordinatesList
        '
        Me.CoordinatesList.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CoordinatesList.items = New String() {""}
        Me.CoordinatesList.Location = New System.Drawing.Point(3, 244)
        Me.CoordinatesList.Name = "CoordinatesList"
        Me.CoordinatesList.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CoordinatesList.Size = New System.Drawing.Size(360, 125)
        Me.CoordinatesList.TabIndex = 16
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(198, 181)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(30, 23)
        Me.Label39.TabIndex = 15
        Me.Label39.Text = "Y:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.txtSecs)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(150, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 57)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Min+Sec"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LoopCheckBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(150, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 57)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loop settings"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(9, 181)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 23)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(305, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Version: 2.0"
        '
        'lblDebugger
        '
        Me.lblDebugger.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblDebugger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDebugger.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDebugger.ForeColor = System.Drawing.Color.White
        Me.lblDebugger.Location = New System.Drawing.Point(0, 503)
        Me.lblDebugger.Name = "lblDebugger"
        Me.lblDebugger.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDebugger.ShowTimeDate = False
        Me.lblDebugger.Size = New System.Drawing.Size(385, 23)
        Me.lblDebugger.TabIndex = 12
        Me.lblDebugger.TextColor = System.Drawing.Color.White
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(334, 17)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 5
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(358, 17)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 4
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 526)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillardBot"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents btnWinPos As FlatButton
    Friend WithEvents btnKillAll As FlatButton
    Friend WithEvents btnStop As FlatButton
    Friend WithEvents btnStart As FlatButton
    Friend WithEvents txtSecs As FlatTextBox
    Friend WithEvents txtMin As FlatTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As FlatButton
    Friend WithEvents LoopCheckBox As FlatCheckBox
    Friend WithEvents lblDebugger As FlatStatusBar
    Friend WithEvents lblSec As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents tmrWatchDog As Timer
    Friend WithEvents tmrCount As Timer
    Friend WithEvents tmrStartBot As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnRestarterBot As FlatButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents posYbox As FlatTextBox
    Friend WithEvents posXbox As FlatTextBox
    Friend WithEvents tmrMousePosition As Timer
    Friend WithEvents tmrMousePositionAddItem As Timer
    Friend WithEvents CoordinatesList As FlatListBox
    Friend WithEvents btnStopCoordinates As FlatButton
    Friend WithEvents btnGetCoordinates As FlatButton
    Friend WithEvents btnMoreOptions As FlatButton
    Friend WithEvents btnStartBs As FlatButton
    Friend WithEvents ControlTip As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrCheckRunningBots As Timer
    Friend WithEvents lblActiveBots As Label
    Friend WithEvents BtnSaveLog As FlatButton
    Friend WithEvents btnClearLog As FlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DebuggerList As ListBox
    Friend WithEvents lblClosedTimes As Label
    Friend WithEvents btnResetClosed As FlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndingLoot As FlatTextBox
    Friend WithEvents txtStartingLoot As FlatTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tmrMath As Timer
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents btnOpenLogs As FlatButton
    Friend WithEvents FlatComboBox1 As FlatComboBox
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents lblLootResults As Label
    Friend WithEvents lblStartLootDate As Label
    Friend WithEvents txtStartLootDate As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents txtFinalResults As TextBox
    Friend WithEvents btnSaveResultsToLog As FlatButton
    Friend WithEvents BotBox4 As FlatCheckBox
    Friend WithEvents BotBox3 As FlatCheckBox
    Friend WithEvents BotBox2 As FlatCheckBox
    Friend WithEvents BotBox1 As FlatCheckBox
    Friend WithEvents tmrBitBull As Timer
    Friend WithEvents GroupBox4 As GroupBox
End Class
