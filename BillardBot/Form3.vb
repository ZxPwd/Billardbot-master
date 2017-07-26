Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Collections
Imports System.IO
Imports System.Text
Imports System.Net
Imports System
Public Class Form3
    Dim sec As Integer
    Dim min As Integer


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

    Dim CheckLoop = ReadIniValue("C:\BillardBot\settings.ini", "data", "Loop")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoadSettings.Start()




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
        DebuggerList.AddItem("Form Loaded")

        If CheckLoop = "LoopTrue" Then
            LoopCheckBox.Checked = True
            System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1911, 1024) '  Close habbo "Room Explorer"
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width - 385
            y = Screen.PrimaryScreen.WorkingArea.Height - 1050
            Me.Location = New Point(x, y)

            DebuggerList.AddItem("Botting Started!")
            Threading.Thread.Sleep(500)
            DebuggerList.AddItem("SET: " + txtMin.Text + " minutes " + txtSecs.Text + " seconds")
            min = txtMin.Text ' SETS he minutes from textbox
            sec = txtSecs.Text ' SETS he seconds from textbox
            StartAllBots()
            tmrCount.Start()
            tmrWatchDog.Start()
        ElseIf CheckLoop = "LoopFalse" Then
            LoopCheckBox.Checked = False

        Else
            DebuggerList.AddItem("Loop not activated")
        End If

        'Dim LoopTrue As String = "looptrue.txt"
        'Dim Filename As String = System.IO.Path.GetFileName(LoopTrue)
        'If System.IO.File.Exists(LoopTrue) Then
        '    LoopCheckBox.Checked = True
        'Else
        '    LoopCheckBox.Checked = False
        'End If



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

        If sec = 5 Then
            lblDebugger.Text = ("Less then 5 minutes remaining!")
        ElseIf sec = 4 Then
            lblDebugger.Text = ("Less then 4 minutes remaining!")
        ElseIf sec = 3 Then
            lblDebugger.Text = ("Less then 3 minutes remaining!")
        ElseIf sec = 2 Then
            lblDebugger.Text = ("Less then 2 minutes remaining!")
        ElseIf sec = 1 Then
            lblDebugger.Text = ("Less then 1 minute remaining!")
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(1911, 1024) '  Close habbo "Room Explorer"
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

        DebuggerList.AddItem("Botting Started!")
        Threading.Thread.Sleep(500)
        DebuggerList.AddItem("SET: " + txtMin.Text + " minutes " + txtSecs.Text + " seconds")
        min = txtMin.Text ' SETS he minutes from textbox
        sec = txtSecs.Text ' SETS he seconds from textbox
        StartAllBots()
        tmrCount.Start()
        tmrWatchDog.Start()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        lblDebugger.Text = ("Status:")
        DebuggerList.AddItem("Botting Stopped!")
        DebuggerList.AddItem("RESETED: min + sec")

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
            End
        Else
            lblDebugger.Text = ("Status: Listening...") 'TELLS ME WHEN THE TIMER IS ACTIVE


        End If
    End Sub

    Private Sub tmrStartBot_Tick(sender As Object, e As EventArgs) Handles tmrStartBot.Tick
        ' lblDebugger.Text = ("Debugger: Bot is active! // Listening...")

    End Sub
    Private Sub btnKillAll_Click(sender As Object, e As EventArgs) Handles btnKillAll.Click
        KillBs()
        KillAllBots()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWinPos.Click
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 385
        y = Screen.PrimaryScreen.WorkingArea.Height - 1050
        Me.Location = New Point(x, y)


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
        KillAllBots() ' From ShortcutModules
        KillBs() ' Kill BlueStacks Processes
        Thread.Sleep(1500)
        BluestacksRestartBot() ' From ShortcutModules
    End Sub

    Private Sub tmrLoadSettings_Tick(sender As Object, e As EventArgs) Handles tmrLoadSettings.Tick

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
End Class
