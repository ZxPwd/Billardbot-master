Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Collections
Imports System.IO
Imports System.Text
Imports System.Net
Imports System
Imports System.ComponentModel

Public Class Form3
    Dim sec As Integer
    Dim min As Integer
    Dim CheckLoop = ReadIniValue("C:\BillardBot\settings.ini", "data", "Loop") ' Moved

#Region "Section - Declarations"

    Public Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    'Private Declare Sub mouse_event Lib "user32" (ByVal dwflags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cbuttons As Integer, ByVal dwextrainfo As Integer)
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2

    'Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    'Public Const MOUSEEVENTF_LEFTDOWN = &H2
    ' Public Const MOUSEEVENTF_LEFTUP = &H4
    ' Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    'Private Const MOUSEEVENTF_RIGHTUP = &H10

    Public progress As Integer = 0
    Public countdown As Integer = 0

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Const MOUSEEVENTF_ABSOLUTE = &H8000 ' absolute move
    Private Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Private Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Private Const MOUSEEVENTF_MOVE = &H1 ' mouse move
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Declare Function SetCursorPos& Lib "user32" (ByVal p As Point)



#End Region

#Region "Section - DLL Imports &&&& Mouse Events (CLICK)"
    <DllImport("kernel32.dll")>
    Private Overloads Shared Function WritePrivateProfileString(
ByVal lpApplicationName As String,
ByVal lpKeyName As String,
ByVal lpString As String,
ByVal lpFileName As String) As Integer
    End Function
    <DllImport("kernel32.dll")>
    Private Overloads Shared Function GetPrivateProfileString(
    ByVal lpApplicationName As String,
    ByVal lpKeyName As String,
    ByVal lpDefault As String,
    ByVal lpReturnedString As StringBuilder,
    ByVal nSize As Integer,
    ByVal lpFileName As String) As Integer
    End Function


#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrCheckRunningBots.Start()
        lblClosedTimes.Text = My.Settings.Closed.ToString()





        If Process.GetProcessesByName("Bot1").Count > 0 Then
            KillAllBots()
        ElseIf Process.GetProcessesByName("Bot2").Count > 0 Then
            KillAllBots()
        ElseIf Process.GetProcessesByName("Bot3").Count > 0 Then
            KillAllBots()
        ElseIf Process.GetProcessesByName("Bot4").Count > 0 Then
            KillAllBots()
        End If





        If Not Directory.Exists("C:\BillardBot") Then
            Directory.CreateDirectory("C:\BillardBot")
            File.Create("C:\BillardBot\settings.ini")
            MsgBox("File Created, Restart Bot")
            WritePrivateProfileString("data", "Minutes", "25", "C:\BillardBot\settings.ini")
            WritePrivateProfileString("data", "Seconds", "15", "C:\BillardBot\settings.ini")

            Dim path As String
            Dim returnValue As String
            path = "C:\BillardBot\settings.ini"
            returnValue = Form2.iniset.Text
            File.WriteAllText(path, returnValue)

        End If

        CheckLoop = ReadIniValue("C:\BillardBot\settings.ini", "data", "Loop")
        txtMin.Text = ReadIniValue("C:\BillardBot\settings.ini", "data", "Minutes")
        txtSecs.Text = ReadIniValue("C:\BillardBot\settings.ini", "data", "Seconds")
        DebuggerList.Items.Add("Form Loaded" & " @ " & My.Computer.Clock.LocalTime)

        ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
        ';;;;;;;;;;;; BELOW HERE IS THE CHECKBOX FOR LOOPING THE BOT          ;;;;;;;;;;;;;
        ';;;;;;;;;;;; IF ITS CHECKED THEN IT WILL AUTOMATICALLY START THE BOT ;;;;;;;;;;;;;
        ';;;;;;;;;;;; WHEN THE RESTARTERBOT OPENS IT                          ;;;;;;;;;;;;;
        ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;



        If CheckLoop = "LoopTrue" Then
            LoopCheckBox.Checked = True
            System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1911, 1024) ' MOVES CURSOR TO BOTTOM RIGHT CORNER *DO NOT REMOVE THIS*
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) ' MOVES CURSOR TO BOTTOM RIGHT CORNER *DO NOT REMOVE THIS*
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' MOVES CURSOR TO BOTTOM RIGHT CORNER *DO NOT REMOVE THIS*

            Dim x As Integer ' Positions the window to the bottom right so it's not in the way of bluestacks
            Dim y As Integer ' Positions the window to the bottom right so it's not in the way of bluestacks
            x = Screen.PrimaryScreen.WorkingArea.Width - 385 ' Positions the window to the bottom right so it's not in the way of bluestacks
            y = Screen.PrimaryScreen.WorkingArea.Height - 1050 ' Positions the window to the bottom right so it's not in the way of bluestacks
            Me.Location = New Point(x, y) ' Positions the window to the bottom right so it's not in the way of bluestacks

            DebuggerList.Items.Add("Botting Started!")
            Threading.Thread.Sleep(500)
            DebuggerList.Items.Add("Timer set to: " + txtMin.Text + " minutes " + txtSecs.Text + " seconds")
            min = txtMin.Text ' SETS he minutes from textbox
            sec = txtSecs.Text ' SETS he seconds from textbox
            StartAllBots()
            tmrCount.Start()
            tmrWatchDog.Start()
        ElseIf CheckLoop = "LoopFalse" Then
            LoopCheckBox.Checked = False

        Else
            DebuggerList.Items.Add("Loop not activated")
        End If






        ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
        ';;;;;;;;;;;;               THIS IS THE END OF THE CHECKBOX           ;;;;;;;;;;;;;
        ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;



    End Sub

    Private Sub tmrCount_Tick(sender As Object, e As EventArgs) Handles tmrCount.Tick



        If min = 0 And sec = 0 Then
            'timer has finished countdown, stop the timer
            'and exit the subroutine
            tmrCount.Stop()
            Exit Sub
        End If

        If sec > 0 Then
            sec = sec - 1
        ElseIf sec <= 0 Then
            min = min - 1
            sec = 59
        End If

        lblMin.Text = min.ToString

        'check if the seconds is less than 10
        'if it is then append a zero in front of it
        If sec < 10 Then
            lblSec.Text = "0" & sec.ToString
        Else
            lblSec.Text = sec.ToString
        End If

        'lblMin.Text = min
        lblSec.Text = sec


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1911, 1024) '  Close habbo "Room Explorer"
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

        DebuggerList.Items.Add("Botting Started!")
        Threading.Thread.Sleep(500)
        DebuggerList.Items.Add("SET: " + txtMin.Text + " minutes " + txtSecs.Text + " seconds")
        min = txtMin.Text ' SETS he minutes from textbox
        sec = txtSecs.Text ' SETS he seconds from textbox
        StartAllBots()
        tmrCount.Start()
        tmrWatchDog.Start()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        lblDebugger.Text = ("Status: Bot Stopped")
        DebuggerList.Items.Add("Botting Stopped. Reseted minutes + sec")

        KillAllBots()
        tmrCount.Stop()
        tmrStartBot.Stop()
        tmrWatchDog.Stop()




    End Sub



    Private Sub tmrWatchDog_Tick(sender As Object, e As EventArgs) Handles tmrWatchDog.Tick

        'IF The timer is at 0 minutes and 0 seconds
        'THEN i want to turn EVERYTHING OFF! and Terminate/Kill the Processes of all bots
        'that are running.

        '1) TURN OFF EVERYTHING
        '2) KILL PROCESSES OF ALL ACTIVE RUNNING BOTS!
        '3) START PROCESS OF BLUESTACKS RESTART BOT // MADE IN VB.NET
        If lblMin.Text = "0" Then
            My.Settings.Closed = My.Settings.Closed + 1
            My.Settings.Save()

            Dim dateAsString = DateTime.Now.ToString("HH-mm-d-MMM")
            FileOpen(1, My.Application.Info.DirectoryPath & "\logs\" & dateAsString.ToString() & ".txt", OpenMode.Output)
            For i = 0 To DebuggerList.Items.Count - 1
                PrintLine(1, DebuggerList.Items(i))
            Next
            FileClose()

            'ActionList.Items.Add("LOOP: Elapsed Time") ' TELLS ME WHEN IT STOPPED TO KEEP TRACK OF HOW MANY TIME IT RAN
            'lblActionList.Text = ("ActionList: Stopped Listening") ' SO I KNOW ITS NOT LISTENING ANYMORE
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''BELOW HERE ENTER CODE TO KILL ALL BOTS AND START BS RESTART BOT''''''''
            '
            KillAllBots() ' From ShortcutModules
            KillBs() ' Kill BlueStacks Processes
            Thread.Sleep(1500)
            BluestacksRestartBot() ' From ShortcutModules
            '''''''''''
            tmrWatchDog.Stop() ' STOPPING ALL TIMERS IN PROGRAM! -- include others if added
            tmrCount.Stop()    ' STOPPING ALL TIMERS IN PROGRAM! -- include others if added
            tmrStartBot.Stop() ' STOPPING ALL TIMERS IN PROGRAM! -- include others if added




            End ' This is where the program stops <------
        Else
            lblDebugger.Text = ("Status: Bot is currently active!") 'TELLS ME WHEN THE TIMER IS ACTIVE


        End If
    End Sub

    Private Sub tmrStartBot_Tick(sender As Object, e As EventArgs) Handles tmrStartBot.Tick
        ' lblDebugger.Text = ("Debugger: Bot is active! // Listening...")

    End Sub
    Private Sub btnKillAll_Click(sender As Object, e As EventArgs) Handles btnKillAll.Click
        KillBs2() ' KillBs2 = with message prompt
        KillAllBots2() ' KillAllBots2 = with message prompt

        lblDebugger.Text = ("Status: KillBs() & KillAllBots()")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWinPos.Click
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 385
        y = Screen.PrimaryScreen.WorkingArea.Height - 1050
        Me.Location = New Point(x, y)
        lblDebugger.Text = ("Status: Positioned Form to top left")


    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        WritePrivateProfileString("data", "Minutes", (txtMin.Text), "C:\BillardBot\settings.ini")
        WritePrivateProfileString("data", "Seconds", (txtSecs.Text), "C:\BillardBot\settings.ini")

        If LoopCheckBox.Checked = True Then
            ' SAVE 
            WritePrivateProfileString("data", "Loop", ("LoopTrue"), "C:\BillardBot\settings.ini")
        Else
            If LoopCheckBox.Checked = False Then
                WritePrivateProfileString("data", "Loop", ("LoopFalse"), "C:\BillardBot\settings.ini")
            End If
        End If
        lblDebugger.Text = ("Status: Settings Saved!")
    End Sub

    Private Sub LoopCheckBox_CheckedChanged(sender As Object) Handles LoopCheckBox.CheckedChanged
        If LoopCheckBox.Checked = True Then
            ' SAVE 
            WritePrivateProfileString("data", "Loop", ("LoopTrue"), "C:\BillardBot\settings.ini")
        Else
            If LoopCheckBox.Checked = False Then
                WritePrivateProfileString("data", "Loop", ("LoopFalse"), "C:\BillardBot\settings.ini")
            End If
        End If
    End Sub

    Private Sub btnRestartBot_Click(sender As Object, e As EventArgs) Handles btnRestartBot.Click
        My.Settings.Closed = My.Settings.Closed + 1
        My.Settings.Save()

        Dim dateAsString = DateTime.Now.ToString("HH-mm-d-MMM")
        FileOpen(1, My.Application.Info.DirectoryPath & "\logs\" & dateAsString.ToString() & ".txt", OpenMode.Output)
        For i = 0 To DebuggerList.Items.Count - 1
            PrintLine(1, DebuggerList.Items(i))
        Next
        FileClose()




        KillAllBots() ' From ShortcutModules
        KillBs() ' Kill BlueStacks Processes
        Thread.Sleep(1500)
        BluestacksRestartBot() ' From ShortcutModules
    End Sub



    Private Sub tmrMousePosition_Tick(sender As Object, e As EventArgs) Handles tmrMousePosition.Tick
        posXbox.Text = (Cursor.Position.X)
        posYbox.Text = (Cursor.Position.Y)
    End Sub



    Private Sub btnGetCoordinates_Click(sender As Object, e As EventArgs) Handles btnGetCoordinates.Click
        tmrMousePosition.Start()
        tmrMousePositionAddItem.Start()
    End Sub

    Private Sub tmrMousePositionAddItem_Tick(sender As Object, e As EventArgs) Handles tmrMousePositionAddItem.Tick
        ' If you push Left-ALT key it will send the pos in the listbox.
        If My.Computer.Keyboard.AltKeyDown Then
            CoordinatesList.AddItem("X: " + posXbox.Text + ", " + "Y: " + posYbox.Text + " -- Coordinates Added")
        End If
    End Sub

    Private Sub btnStopCoordinates_Click(sender As Object, e As EventArgs) Handles btnStopCoordinates.Click
        tmrMousePosition.Stop()
        tmrMousePositionAddItem.Stop()
    End Sub

    Dim DocOptions As New Form4
    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 385
        y = Screen.PrimaryScreen.WorkingArea.Height - 1050
        Me.Location = New Point(x, y)
        DocOptions.Visible = True
    End Sub

    Private Sub btnStartBs_Click(sender As Object, e As EventArgs) Handles btnStartBs.Click





        lblDebugger.Text = ("Status: BlueStacks Started!")
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub


    Private Sub tmrCheckRunningBots_Tick(sender As Object, e As EventArgs) Handles tmrCheckRunningBots.Tick
        Dim proc As Integer = Process.GetProcessesByName("Bot").GetUpperBound(0) + 1


        If Process.GetProcessesByName("Bot").Count > 0 Then
            lblActiveBots.Text = ("STATUS: There is" & " " & proc & " " & "bots runnings")
            lblActiveBots.ForeColor = Color.Lime


        Else
            'lblActiveBots.Text = ("STATUS: There is ") + ("( ") + proc + (" )") + ("bot running!")
            lblActiveBots.ForeColor = Color.Orange
            lblActiveBots.Text = ("STATUS: There is" & " " & proc & " " & "bots runnings")


        End If









    End Sub

    Private Sub btnStartBotx2_Click(sender As Object, e As EventArgs) Handles btnStartBotx2.Click

        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1911, 1024) '  Close habbo "Room Explorer"
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

        DebuggerList.Items.Add("Botting Started!")
        Threading.Thread.Sleep(500)
        DebuggerList.Items.Add("SET: " + txtMin.Text + " minutes " + txtSecs.Text + " seconds")
        min = txtMin.Text ' SETS he minutes from textbox
        sec = txtSecs.Text ' SETS he seconds from textbox
        StartAllBots()
        StartAllBots()
        tmrCount.Start()
        tmrWatchDog.Start()
    End Sub

    'Sub status(ByVal status As String)
    '    lblStatus.Text = status & " @ " & My.Computer.Clock.LocalTime
    'End Sub
    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        DebuggerList.Items.Clear()
        DebuggerList.Items.Add(" @ " & My.Computer.Clock.LocalTime)
    End Sub

    Private Sub BtnSaveLog_Click(sender As Object, e As EventArgs) Handles BtnSaveLog.Click

        Dim dateAsString = DateTime.Now.ToString("HH-mm-d-MMM")
        FileOpen(1, My.Application.Info.DirectoryPath & "\logs\" & dateAsString.ToString() & ".txt", OpenMode.Output)
        For i = 0 To DebuggerList.Items.Count - 1
            PrintLine(1, DebuggerList.Items(i))
        Next
        FileClose()


    End Sub





    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click



        Dim dateAsString = DateTime.Now.ToString("HH-mm-d-MMM")
        FileOpen(1, My.Application.Info.DirectoryPath & "\logs\" & dateAsString.ToString() & ".txt", OpenMode.Output)
        For i = 0 To DebuggerList.Items.Count - 1
            PrintLine(1, DebuggerList.Items(i))
        Next
        FileClose()


    End Sub

    Private Sub btnResetClosed_Click(sender As Object, e As EventArgs) Handles btnResetClosed.Click
        My.Settings.Closed = 0
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Closed = My.Settings.Closed + 1
        My.Settings.Save()
    End Sub
End Class
