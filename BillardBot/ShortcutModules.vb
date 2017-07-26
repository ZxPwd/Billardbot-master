Module ShortcutModules

    Public Sub KillAllBots()


        For Each p As Process In Process.GetProcesses()
            If p.ProcessName = "Bot1" Then 'Or p.ProcessName = "mspaint"
                p.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Bot1.exe")
                Form3.DebuggerList.AddItem("TERMINATED: Bot1.exe")
            End If
        Next

        For Each p2 As Process In Process.GetProcesses()
            If p2.ProcessName = "Bot2" Then 'Or p.ProcessName = "mspaint"
                p2.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Bot2.exe")
                Form3.DebuggerList.AddItem("TERMINATED: Bot2.exe")
            End If
        Next

        For Each p3 As Process In Process.GetProcesses()
            If p3.ProcessName = "Bot3" Then 'Or p.ProcessName = "mspaint"
                p3.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Bot3.exe")
                Form3.DebuggerList.AddItem("TERMINATED: Bot3.exe")
            End If
        Next

        For Each p4 As Process In Process.GetProcesses()
            If p4.ProcessName = "Bot4" Then 'Or p.ProcessName = "mspaint"
                p4.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Bot4.exe")
                Form3.DebuggerList.AddItem("TERMINATED: Bot4.exe")
            End If
        Next


    End Sub


    Public Sub KillBs()
        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Agent" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Agent.exe") 'Form3.DebuggerList.AddItem
                Form3.DebuggerList.AddItem("TERMINATED: HD-Agent.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-LogRotatorService" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-LogRotatorService.exe")
                Form3.DebuggerList.AddItem("TERMINATED: HD-LogRotatorService.exe")

            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-OBS" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-OBS.exe")
                Form3.DebuggerList.AddItem("TERMINATED: HD-OBS.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Fronted" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Fronted.exe")
                Form3.DebuggerList.AddItem("TERMINATED: HD-Plus-Fronted.exe")
            End If
        Next

        For Each p6 As Process In Process.GetProcesses()
            If p6.ProcessName = "HD-Plus-Service" Then 'Or p.ProcessName = "mspaint"
                p6.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: HD-Plus-Service.exe")
                Form3.DebuggerList.AddItem("TERMINATED: HD-Plus-Service.exe")
            End If
        Next

        'For Each p7 As Process In Process.GetProcesses()
        '    If p7.ProcessName = "BlueStacks_old" Then 'Or p.ProcessName = "mspaint"
        '        p7.Kill()
        '        Form2.DebuggerList.Items.Add("TERMINATED: BlueStacks_old.exe")
        '        Form3.DebuggerList.AddItem("TERMINATED: BlueStacks_old.exe")
        '    End If
        'Next



    End Sub

    Public Sub KillAllPRocesses()




    End Sub



    Public Sub BluestacksRestartBot()


        For Each p5 As Process In Process.GetProcesses()
            If p5.ProcessName = "Restarter" Then 'Or p.ProcessName = "mspaint"
                p5.Kill()
                Form2.DebuggerList.Items.Add("TERMINATED: Restarter.exe")
            Else
                KillAllBots()
                KillBs()
                Process.Start("Restarter.exe")
                End


            End If
        Next


    End Sub

    Public Sub StartAllBots()
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot1.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot2.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot3.exe")
        'Process.Start("C:\Users\ADmin\Documents\visual studio 2015\Projects\BillardBot\BillardBot\bin\Debug\bots\Bot4.exe")

        Process.Start("bots\Bot1.exe")
        Process.Start("bots\Bot2.exe")
        Process.Start("bots\Bot3.exe")
        Process.Start("bots\Bot4.exe")
        Form2.DebuggerList.Items.Add("STARTED: Bot1.exe")
        Form2.DebuggerList.Items.Add("STARTED: Bot2.exe")
        Form2.DebuggerList.Items.Add("STARTED: Bot3.exe")
        Form2.DebuggerList.Items.Add("STARTED: Bot4.exe")
    End Sub


End Module
