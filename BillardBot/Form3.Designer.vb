<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.tmrWatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCount = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartBot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoadSettings = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BillardBot.FormSkin()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblDebugger = New BillardBot.FlatStatusBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LoopCheckBox = New BillardBot.FlatCheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMin = New BillardBot.FlatTextBox()
        Me.txtSecs = New BillardBot.FlatTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New BillardBot.FlatButton()
        Me.btnWinPos = New BillardBot.FlatButton()
        Me.btnKillAll = New BillardBot.FlatButton()
        Me.btnStop = New BillardBot.FlatButton()
        Me.btnStart = New BillardBot.FlatButton()
        Me.DebuggerList = New BillardBot.FlatListBox()
        Me.FlatMini1 = New BillardBot.FlatMini()
        Me.FlatClose1 = New BillardBot.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lblSec)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.lblMin)
        Me.FormSkin1.Controls.Add(Me.lblDebugger)
        Me.FormSkin1.Controls.Add(Me.GroupBox3)
        Me.FormSkin1.Controls.Add(Me.GroupBox2)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Controls.Add(Me.DebuggerList)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(376, 385)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "BillardBot - Miniclip 8 Ball Pool"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblSec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSec.Location = New System.Drawing.Point(344, 144)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(24, 17)
        Me.lblSec.TabIndex = 14
        Me.lblSec.Text = "SS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "RUN RS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(292, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Version: 1.3"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.lblMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMin.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblMin.Location = New System.Drawing.Point(282, 142)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(64, 48)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "oo"
        '
        'lblDebugger
        '
        Me.lblDebugger.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblDebugger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDebugger.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDebugger.ForeColor = System.Drawing.Color.White
        Me.lblDebugger.Location = New System.Drawing.Point(0, 362)
        Me.lblDebugger.Name = "lblDebugger"
        Me.lblDebugger.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblDebugger.ShowTimeDate = False
        Me.lblDebugger.Size = New System.Drawing.Size(376, 23)
        Me.lblDebugger.TabIndex = 12
        Me.lblDebugger.TextColor = System.Drawing.Color.White
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LoopCheckBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(134, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 53)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loop settings"
        '
        'LoopCheckBox
        '
        Me.LoopCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LoopCheckBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LoopCheckBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LoopCheckBox.Checked = False
        Me.LoopCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoopCheckBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LoopCheckBox.Location = New System.Drawing.Point(9, 17)
        Me.LoopCheckBox.Name = "LoopCheckBox"
        Me.LoopCheckBox.Options = BillardBot.FlatCheckBox._Options.Style1
        Me.LoopCheckBox.Size = New System.Drawing.Size(112, 22)
        Me.LoopCheckBox.TabIndex = 0
        Me.LoopCheckBox.Text = "Always Loop"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.txtSecs)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(123, 53)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Min+Sec"
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
        Me.txtSecs.UseSystemPasswordChar = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnWinPos)
        Me.GroupBox1.Controls.Add(Me.btnKillAll)
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 58)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(275, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Rounded = False
        Me.btnSave.Size = New System.Drawing.Size(61, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnWinPos
        '
        Me.btnWinPos.BackColor = System.Drawing.Color.Transparent
        Me.btnWinPos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnWinPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWinPos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnWinPos.Location = New System.Drawing.Point(213, 20)
        Me.btnWinPos.Name = "btnWinPos"
        Me.btnWinPos.Rounded = False
        Me.btnWinPos.Size = New System.Drawing.Size(61, 30)
        Me.btnWinPos.TabIndex = 3
        Me.btnWinPos.Text = "PoS"
        Me.btnWinPos.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnKillAll
        '
        Me.btnKillAll.BackColor = System.Drawing.Color.Transparent
        Me.btnKillAll.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnKillAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKillAll.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnKillAll.Location = New System.Drawing.Point(151, 20)
        Me.btnKillAll.Name = "btnKillAll"
        Me.btnKillAll.Rounded = False
        Me.btnKillAll.Size = New System.Drawing.Size(61, 30)
        Me.btnKillAll.TabIndex = 2
        Me.btnKillAll.Text = "Kill.All"
        Me.btnKillAll.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStop.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.btnStop.Location = New System.Drawing.Point(89, 20)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Rounded = False
        Me.btnStop.Size = New System.Drawing.Size(61, 30)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(27, 20)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Rounded = False
        Me.btnStart.Size = New System.Drawing.Size(61, 30)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DebuggerList
        '
        Me.DebuggerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DebuggerList.items = New String() {""}
        Me.DebuggerList.Location = New System.Drawing.Point(4, 203)
        Me.DebuggerList.Name = "DebuggerList"
        Me.DebuggerList.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DebuggerList.Size = New System.Drawing.Size(368, 156)
        Me.DebuggerList.TabIndex = 6
        Me.DebuggerList.Text = "FlatListBox1"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(325, 17)
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
        Me.FlatClose1.Location = New System.Drawing.Point(349, 17)
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
        Me.ClientSize = New System.Drawing.Size(376, 385)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents btnWinPos As FlatButton
    Friend WithEvents btnKillAll As FlatButton
    Friend WithEvents btnStop As FlatButton
    Friend WithEvents btnStart As FlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSecs As FlatTextBox
    Friend WithEvents txtMin As FlatTextBox
    Friend WithEvents DebuggerList As FlatListBox
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
    Friend WithEvents tmrLoadSettings As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
