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









        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Agent" Then 'Or p.ProcessName = "mspaint"
                lblHdAgent.ForeColor = Color.Red
            Else
                lblHdAgent.ForeColor = Color.Lime

            End If

        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-LogRotatorService" Then 'Or p.ProcessName = "mspaint"

                lblPlugRotator.ForeColor = Color.Red
            Else
                lblPlugRotator.ForeColor = Color.Lime

            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-OBS" Then 'Or p.ProcessName = "mspaint"
                lblObs.ForeColor = Color.Red
            Else
                lblObs.ForeColor = Color.Lime



            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Fronted" Then 'Or p.ProcessName = "mspaint"
                lblFronted.ForeColor = Color.Red
            Else
                lblFronted.ForeColor = Color.Lime
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Service" Then 'Or p.ProcessName = "mspaint"
                lblPlusService.ForeColor = Color.Red
            Else
                lblPlusService.ForeColor = Color.Lime
            End If
        Next

        For Each p7 As Process In Process.GetProcesses()
            If p7.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
                lblBlueStacks.ForeColor = Color.Red
            Else
                lblBlueStacks.ForeColor = Color.Lime

            End If
        Next

        For Each p8 As Process In Process.GetProcesses()
            If p8.ProcessName = "HD-UpdaterService" Then 'Or p.ProcessName = "mspaint"
                lblUpdaterService.ForeColor = Color.Red
            Else
                lblUpdaterService.ForeColor = Color.Lime

            End If
        Next




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
            If p6.ProcessName = "HD-Plus-Fronted" Then 'Or p.ProcessName = "mspaint"
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
End Class