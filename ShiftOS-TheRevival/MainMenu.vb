Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Build.Text = lbl_Build.Text & My.Application.Info.Version.ToString
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label5.MouseEnter, Label6.MouseEnter
        ' To test the sudden resizing font change to bigger size when
        ' mouse is hovering/entering the label area
        '
        ' Looking for better code solution
        Dim WhichLabel As Label = CType(sender, Label)
        WhichLabel.Font = New Font("Segoe UI", 16)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label6.MouseLeave
        ' To test the sudden resizing font change to smaller size when
        ' mouse is hovering/entering the label area
        '
        ' Looking for better code solution
        Dim WhichLabel As Label = CType(sender, Label)
        WhichLabel.Font = New Font("Segoe UI", 11)
    End Sub

    'Private Sub MouseEnter_2(sender As Object, e As EventArgs) Handles Label2.MouseEnter

    'End Sub
End Class