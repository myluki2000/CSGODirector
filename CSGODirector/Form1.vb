Imports System.Runtime.InteropServices
Imports CSGSI

Public Class CSGODirector
    Dim WithEvents GSL As New GameStateListener(3550)
    Dim CSGOMaximized As Boolean
    Private Sub CSGODirector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GSL.Start()

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        Me.Location = New Point(0, 0)
        PanelSettings.Location = New Point(-225, 0)
    End Sub

    Private Sub OnNewGameState(gs As GameState) Handles GSL.NewGameState
        Try
            If rbDirector.Checked Then

                If gs.Round.Phase = Nodes.RoundPhase.FreezeTime OrElse gs.Round.Phase = Nodes.RoundPhase.Over Then
                    If CSGOMaximized Then
                        BackColor = Color.DimGray
                        WebBrowser1.Visible = True
                        Me.Opacity = 1
                        SetCursorPos(0, 0)
                        CSGOMaximized = False
                    End If
                End If

                If gs.Round.Phase = Nodes.RoundPhase.Live AndAlso CSGOMaximized = False Then
                    BackColor = Color.DarkGray
                    WebBrowser1.Visible = False
                    Me.Opacity = 0.5
                    CSGOMaximized = True
                End If
            End If
        Catch e As Exception

        End Try
    End Sub

    Private Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub SettingsExpander_Click(sender As Object, e As EventArgs) Handles SettingsExpander.Click
        If PanelSettings.Location.X = 0 Then
            PanelSettings.Location = New Point(-225, 0)
            SettingsExpander.Text = ">"
        Else
            PanelSettings.Location = New Point(0, 0)
            SettingsExpander.Text = "<"
        End If
    End Sub

    Private Sub rbStream_CheckedChanged(sender As Object, e As EventArgs) Handles rbStream.CheckedChanged
        If rbStream.Checked Then
            WebBrowser1.Visible = True
            Me.Opacity = 1
            BackColor = Color.DimGray
        End If
    End Sub

    Private Sub rbGame_CheckedChanged(sender As Object, e As EventArgs) Handles rbGame.CheckedChanged
        If rbGame.Checked Then
            WebBrowser1.Visible = False
            Me.Opacity = 0.5
            BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnStreamURL_Click(sender As Object, e As EventArgs) Handles btnStreamURL.Click
        InputForm.ShowDialog()
    End Sub
End Class
