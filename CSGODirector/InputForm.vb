Public Class InputForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CSGODirector.WebBrowser1.Navigate("http://player.twitch.tv/?channel=" & TextBox1.Text)
        Me.Close()
    End Sub
End Class