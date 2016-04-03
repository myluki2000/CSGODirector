Imports CSGSI

Public Class Form1
    Dim WithEvents GSL As New GameStateListener(3550)
    Dim CSGOMaximized As Boolean
    Dim counter As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GSL.Start()
    End Sub

    Private Sub OnNewGameState(gs As GameState) Handles GSL.NewGameState
        Try
            If CheckBox1.Checked Then

                If gs.Round.Phase = Nodes.RoundPhase.FreezeTime OrElse gs.Round.Phase = Nodes.RoundPhase.Over Then
                    If CSGOMaximized AndAlso counter = NumericUpDown1.Value Then
                        MaximizeWindow("chrome")
                        MaximizeWindow("firefox")
                        MaximizeWindow("vlc")

                        SetCursorPos(0, 0)
                        CSGOMaximized = False
                    End If

                    counter += 1
                End If

                If gs.Round.Phase = Nodes.RoundPhase.Live AndAlso CSGOMaximized = False Then
                    MaximizeWindow("csgo")
                    CSGOMaximized = True
                    counter = 0
                End If
            End If
        Catch e As Exception

        End Try
    End Sub

    Private Sub MaximizeWindow(ByVal procName As String)
        Dim procArray() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(procName)
        If procArray.Length > 0 Then
            Dim i As Integer = 0
            For i = 0 To procArray.Length - 1
                If Not procArray(i).MainWindowTitle = "" Then ShowPreviousInstance(procArray(i).MainWindowHandle)
            Next
        End If
    End Sub

    Private SW_RESTORE As Integer = 9
    Private Declare Auto Function IsIconic Lib "user32" (ByVal hWnd As IntPtr) As Boolean
    Private Declare Auto Function SetForegroundWindow Lib "user32" (ByVal hwnd As IntPtr) As Long
    Private Declare Auto Function ShowWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As IntPtr

    Private Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer

    Private Function ShowPreviousInstance(ByVal handle As IntPtr) As Boolean
        If handle.ToInt32 <> IntPtr.Zero.ToInt32 Then
            Try
                If IsIconic(handle) Then
                    ShowWindow(handle, SW_RESTORE)
                End If
                SetForegroundWindow(handle)
                ShowPreviousInstance = True
            Catch ex As System.Exception
                ShowPreviousInstance = False
            End Try
        Else
            ShowPreviousInstance = False
        End If
    End Function
End Class
