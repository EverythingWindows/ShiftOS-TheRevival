Public Class MainMenu_About
    Private Sub MainMenu_About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lbl_Build.Text = "build " Then
            lbl_Build.Text += My.Application.Info.Version.ToString
        End If
    End Sub

    Private Sub lbl_OK_Click(sender As Object, e As EventArgs) Handles lbl_OK.Click
        Close()
    End Sub
End Class