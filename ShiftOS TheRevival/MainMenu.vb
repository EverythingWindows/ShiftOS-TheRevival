Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Build.Text = lbl_Build.Text & My.Application.Info.Version.ToString
    End Sub
End Class