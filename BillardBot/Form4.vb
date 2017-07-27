Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 350
        y = Screen.PrimaryScreen.WorkingArea.Height - 570
        Me.Location = New Point(x, y)



        tmrListenProcess.Start()

    End Sub

    Private Sub tmrListenProcess_Tick(sender As Object, e As EventArgs) Handles tmrListenProcess.Tick


        If Process.GetProcessesByName("BlueStacks_old").Count > 0 Then
            lblBlueStacks.ForeColor = Color.Lime
        Else
            lblBlueStacks.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Agent").Count > 0 Then
            lblHdAgent.ForeColor = Color.Lime
        Else
            lblHdAgent.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("D-OBS").Count > 0 Then
            lblObs.ForeColor = Color.Lime
        Else
            lblObs.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Plus-Fronted").Count > 0 Then
            lblFronted.ForeColor = Color.Lime
        Else
            lblFronted.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Plus-Service").Count > 0 Then
            lblPlusService.ForeColor = Color.Lime
        Else
            lblPlusService.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-UpdaterService").Count > 0 Then
            lblUpdaterService.ForeColor = Color.Lime
        Else
            lblUpdaterService.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("BlueStacks").Count > 0 Then
            lblBlueStacks2.ForeColor = Color.Lime
        Else
            lblBlueStacks2.ForeColor = Color.Red
        End If







    End Sub

    Private Sub btnKillAllProcess_Click(sender As Object, e As EventArgs) Handles btnKillAllProcess.Click
        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Agent" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()

            End If

        Next


        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-LogRotatorService" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()

            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-OBS" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()

            Else

            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Frontend" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()


            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Service" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
            End If
        Next

        For Each p7 As Process In Process.GetProcesses()
            If p7.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
                p7.Kill()

            End If
        Next

        For Each p8 As Process In Process.GetProcesses()
            If p8.ProcessName = "HD-UpdaterService" Then 'Or p.ProcessName = "mspaint"
                p8.Kill()

            End If
        Next
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Visible = False
    End Sub


    Private Sub btnCheckProcesses_Click(sender As Object, e As EventArgs) Handles btnCheckProcesses.Click


        If Process.GetProcessesByName("BlueStacks_old").Count > 0 Then
            lblBlueStacks.ForeColor = Color.Lime
        Else
            lblBlueStacks.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Agent").Count > 0 Then
            lblHdAgent.ForeColor = Color.Lime
        Else
            lblHdAgent.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("D-OBS").Count > 0 Then
            lblObs.ForeColor = Color.Lime
        Else
            lblObs.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Plus-Frontend").Count > 0 Then
            lblFronted.ForeColor = Color.Lime
        Else
            lblFronted.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-Plus-Service").Count > 0 Then
            lblPlusService.ForeColor = Color.Lime
        Else
            lblPlusService.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-UpdaterService").Count > 0 Then
            lblUpdaterService.ForeColor = Color.Lime
        Else
            lblUpdaterService.ForeColor = Color.Red
        End If

        If Process.GetProcessesByName("HD-LogRotatorService").Count > 0 Then
            lblPlugRotator.ForeColor = Color.Lime
        Else
            lblPlugRotator.ForeColor = Color.Red
        End If


    End Sub
End Class