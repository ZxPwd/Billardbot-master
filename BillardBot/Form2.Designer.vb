<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DebuggerList = New System.Windows.Forms.ListBox()
        Me.lblDebugger = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.tmrCount = New System.Windows.Forms.Timer(Me.components)
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSecs = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.lblActionList = New System.Windows.Forms.Label()
        Me.tmrWatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartBot = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnWinPos = New System.Windows.Forms.Button()
        Me.LoopCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.iniset = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrLoadSettings = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DebuggerList
        '
        Me.DebuggerList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DebuggerList.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebuggerList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DebuggerList.FormattingEnabled = True
        Me.DebuggerList.ItemHeight = 11
        Me.DebuggerList.Location = New System.Drawing.Point(5, 182)
        Me.DebuggerList.Name = "DebuggerList"
        Me.DebuggerList.Size = New System.Drawing.Size(281, 176)
        Me.DebuggerList.TabIndex = 0
        '
        'lblDebugger
        '
        Me.lblDebugger.AutoSize = True
        Me.lblDebugger.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblDebugger.Location = New System.Drawing.Point(3, 165)
        Me.lblDebugger.Name = "lblDebugger"
        Me.lblDebugger.Size = New System.Drawing.Size(53, 11)
        Me.lblDebugger.TabIndex = 1
        Me.lblDebugger.Text = "Debugger"
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(5, 46)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(72, 26)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(83, 46)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(72, 26)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'tmrCount
        '
        Me.tmrCount.Interval = 1000
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(35, 21)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(39, 29)
        Me.lblMin.TabIndex = 4
        Me.lblMin.Text = "oo"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblSec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSec.Location = New System.Drawing.Point(78, 11)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(24, 17)
        Me.lblSec.TabIndex = 5
        Me.lblSec.Text = "SS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSec)
        Me.GroupBox1.Controls.Add(Me.lblMin)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 68)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timer"
        '
        'txtSecs
        '
        Me.txtSecs.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtSecs.Location = New System.Drawing.Point(167, 15)
        Me.txtSecs.Name = "txtSecs"
        Me.txtSecs.Size = New System.Drawing.Size(44, 24)
        Me.txtSecs.TabIndex = 1
        Me.txtSecs.Text = "15"
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtMin.Location = New System.Drawing.Point(104, 15)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(44, 24)
        Me.txtMin.TabIndex = 0
        Me.txtMin.Text = "25"
        '
        'lblActionList
        '
        Me.lblActionList.AutoSize = True
        Me.lblActionList.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold)
        Me.lblActionList.Location = New System.Drawing.Point(3, 32)
        Me.lblActionList.Name = "lblActionList"
        Me.lblActionList.Size = New System.Drawing.Size(39, 11)
        Me.lblActionList.TabIndex = 9
        Me.lblActionList.Text = "Status:"
        '
        'tmrWatchDog
        '
        '
        'tmrStartBot
        '
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(5, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Kill All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnWinPos
        '
        Me.btnWinPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWinPos.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnWinPos.Location = New System.Drawing.Point(83, 78)
        Me.btnWinPos.Name = "btnWinPos"
        Me.btnWinPos.Size = New System.Drawing.Size(72, 26)
        Me.btnWinPos.TabIndex = 11
        Me.btnWinPos.Text = "X,Y Set"
        Me.btnWinPos.UseVisualStyleBackColor = True
        '
        'LoopCheckBox
        '
        Me.LoopCheckBox.AutoSize = True
        Me.LoopCheckBox.Location = New System.Drawing.Point(7, 19)
        Me.LoopCheckBox.Name = "LoopCheckBox"
        Me.LoopCheckBox.Size = New System.Drawing.Size(91, 17)
        Me.LoopCheckBox.TabIndex = 12
        Me.LoopCheckBox.Text = "Loop Process"
        Me.LoopCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSecs)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.txtMin)
        Me.GroupBox3.Controls.Add(Me.LoopCheckBox)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 49)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options: Loop && Time to restart"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "s"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "m"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = Global.BillardBot.My.Resources.Resources.saveme
        Me.btnSave.Location = New System.Drawing.Point(237, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(27, 24)
        Me.btnSave.TabIndex = 13
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'iniset
        '
        Me.iniset.Location = New System.Drawing.Point(345, 154)
        Me.iniset.Multiline = True
        Me.iniset.Name = "iniset"
        Me.iniset.Size = New System.Drawing.Size(158, 62)
        Me.iniset.TabIndex = 40
        Me.iniset.Text = "[data]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minutes=" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seconds=" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.iniset.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 378)
        Me.Controls.Add(Me.iniset)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnWinPos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblActionList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDebugger)
        Me.Controls.Add(Me.DebuggerList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillardBot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DebuggerList As ListBox
    Friend WithEvents lblDebugger As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents tmrCount As Timer
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtSecs As TextBox
    Friend WithEvents lblActionList As Label
    Friend WithEvents tmrWatchDog As Timer
    Friend WithEvents tmrStartBot As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btnWinPos As Button
    Friend WithEvents LoopCheckBox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents iniset As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrLoadSettings As Timer
End Class
