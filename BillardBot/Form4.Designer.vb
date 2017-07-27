<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.tmrListenProcess = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BillardBot.FormSkin()
        Me.btnCheckProcesses = New BillardBot.FlatButton()
        Me.FlatButton1 = New BillardBot.FlatButton()
        Me.btnKillAllProcess = New BillardBot.FlatButton()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblHdAgent = New System.Windows.Forms.Label()
        Me.lblPlugRotator = New System.Windows.Forms.Label()
        Me.lblFronted = New System.Windows.Forms.Label()
        Me.lblPlusService = New System.Windows.Forms.Label()
        Me.lblUpdaterService = New System.Windows.Forms.Label()
        Me.lblBlueStacks = New System.Windows.Forms.Label()
        Me.lblBlueStacks2 = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrListenProcess
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnCheckProcesses)
        Me.FormSkin1.Controls.Add(Me.lblBlueStacks2)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.btnKillAllProcess)
        Me.FormSkin1.Controls.Add(Me.lblObs)
        Me.FormSkin1.Controls.Add(Me.lblHdAgent)
        Me.FormSkin1.Controls.Add(Me.lblPlugRotator)
        Me.FormSkin1.Controls.Add(Me.lblFronted)
        Me.FormSkin1.Controls.Add(Me.lblPlusService)
        Me.FormSkin1.Controls.Add(Me.lblUpdaterService)
        Me.FormSkin1.Controls.Add(Me.lblBlueStacks)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(290, 360)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Other Settings"
        '
        'btnCheckProcesses
        '
        Me.btnCheckProcesses.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckProcesses.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCheckProcesses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckProcesses.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnCheckProcesses.Location = New System.Drawing.Point(167, 323)
        Me.btnCheckProcesses.Name = "btnCheckProcesses"
        Me.btnCheckProcesses.Rounded = False
        Me.btnCheckProcesses.Size = New System.Drawing.Size(118, 32)
        Me.btnCheckProcesses.TabIndex = 11
        Me.btnCheckProcesses.Text = "Double Check"
        Me.btnCheckProcesses.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(256, 12)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(26, 25)
        Me.FlatButton1.TabIndex = 10
        Me.FlatButton1.Text = "X"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnKillAllProcess
        '
        Me.btnKillAllProcess.BackColor = System.Drawing.Color.Transparent
        Me.btnKillAllProcess.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnKillAllProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKillAllProcess.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnKillAllProcess.Location = New System.Drawing.Point(198, 285)
        Me.btnKillAllProcess.Name = "btnKillAllProcess"
        Me.btnKillAllProcess.Rounded = False
        Me.btnKillAllProcess.Size = New System.Drawing.Size(87, 32)
        Me.btnKillAllProcess.TabIndex = 9
        Me.btnKillAllProcess.Text = "Kill"
        Me.btnKillAllProcess.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.BackColor = System.Drawing.Color.Transparent
        Me.lblObs.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblObs.ForeColor = System.Drawing.Color.Red
        Me.lblObs.Location = New System.Drawing.Point(12, 289)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(134, 30)
        Me.lblObs.TabIndex = 8
        Me.lblObs.Text = "HD-OBS.exe"
        '
        'lblHdAgent
        '
        Me.lblHdAgent.AutoSize = True
        Me.lblHdAgent.BackColor = System.Drawing.Color.Transparent
        Me.lblHdAgent.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblHdAgent.ForeColor = System.Drawing.Color.Red
        Me.lblHdAgent.Location = New System.Drawing.Point(12, 257)
        Me.lblHdAgent.Name = "lblHdAgent"
        Me.lblHdAgent.Size = New System.Drawing.Size(150, 30)
        Me.lblHdAgent.TabIndex = 8
        Me.lblHdAgent.Text = "HD-Agent.exe"
        '
        'lblPlugRotator
        '
        Me.lblPlugRotator.AutoSize = True
        Me.lblPlugRotator.BackColor = System.Drawing.Color.Transparent
        Me.lblPlugRotator.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblPlugRotator.ForeColor = System.Drawing.Color.Red
        Me.lblPlugRotator.Location = New System.Drawing.Point(12, 224)
        Me.lblPlugRotator.Name = "lblPlugRotator"
        Me.lblPlugRotator.Size = New System.Drawing.Size(270, 30)
        Me.lblPlugRotator.TabIndex = 7
        Me.lblPlugRotator.Text = "HD-LogRotatorService.exe"
        '
        'lblFronted
        '
        Me.lblFronted.AutoSize = True
        Me.lblFronted.BackColor = System.Drawing.Color.Transparent
        Me.lblFronted.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblFronted.ForeColor = System.Drawing.Color.Red
        Me.lblFronted.Location = New System.Drawing.Point(12, 191)
        Me.lblFronted.Name = "lblFronted"
        Me.lblFronted.Size = New System.Drawing.Size(215, 30)
        Me.lblFronted.TabIndex = 6
        Me.lblFronted.Text = "HD-Plus-Fronted.exe"
        '
        'lblPlusService
        '
        Me.lblPlusService.AutoSize = True
        Me.lblPlusService.BackColor = System.Drawing.Color.Transparent
        Me.lblPlusService.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblPlusService.ForeColor = System.Drawing.Color.Red
        Me.lblPlusService.Location = New System.Drawing.Point(12, 158)
        Me.lblPlusService.Name = "lblPlusService"
        Me.lblPlusService.Size = New System.Drawing.Size(209, 30)
        Me.lblPlusService.TabIndex = 5
        Me.lblPlusService.Text = "HD-Plus-Service.exe"
        '
        'lblUpdaterService
        '
        Me.lblUpdaterService.AutoSize = True
        Me.lblUpdaterService.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdaterService.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblUpdaterService.ForeColor = System.Drawing.Color.Red
        Me.lblUpdaterService.Location = New System.Drawing.Point(12, 125)
        Me.lblUpdaterService.Name = "lblUpdaterService"
        Me.lblUpdaterService.Size = New System.Drawing.Size(241, 30)
        Me.lblUpdaterService.TabIndex = 4
        Me.lblUpdaterService.Text = "HD-UpdaterService.exe"
        '
        'lblBlueStacks
        '
        Me.lblBlueStacks.AutoSize = True
        Me.lblBlueStacks.BackColor = System.Drawing.Color.Transparent
        Me.lblBlueStacks.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblBlueStacks.ForeColor = System.Drawing.Color.Red
        Me.lblBlueStacks.Location = New System.Drawing.Point(12, 92)
        Me.lblBlueStacks.Name = "lblBlueStacks"
        Me.lblBlueStacks.Size = New System.Drawing.Size(194, 30)
        Me.lblBlueStacks.TabIndex = 3
        Me.lblBlueStacks.Text = "BlueStacks_old.exe"
        '
        'lblBlueStacks2
        '
        Me.lblBlueStacks2.AutoSize = True
        Me.lblBlueStacks2.BackColor = System.Drawing.Color.Transparent
        Me.lblBlueStacks2.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblBlueStacks2.ForeColor = System.Drawing.Color.Red
        Me.lblBlueStacks2.Location = New System.Drawing.Point(12, 62)
        Me.lblBlueStacks2.Name = "lblBlueStacks2"
        Me.lblBlueStacks2.Size = New System.Drawing.Size(154, 30)
        Me.lblBlueStacks2.TabIndex = 12
        Me.lblBlueStacks2.Text = "BlueStacks.exe"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 360)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProcessList"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btnKillAllProcess As FlatButton
    Friend WithEvents lblHdAgent As Label
    Friend WithEvents lblPlugRotator As Label
    Friend WithEvents lblFronted As Label
    Friend WithEvents lblPlusService As Label
    Friend WithEvents lblUpdaterService As Label
    Friend WithEvents lblBlueStacks As Label
    Friend WithEvents tmrListenProcess As Timer
    Friend WithEvents lblObs As Label
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents btnCheckProcesses As FlatButton
    Friend WithEvents lblBlueStacks2 As Label
End Class
