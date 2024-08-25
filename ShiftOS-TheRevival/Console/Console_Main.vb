Public Class Console_Main
    Public C_TextSize As Integer
    Public C_TextStyle As FontFamily

    Private Sub ToggleFS() Handles b_ToggleFS.Click
        ' To test Console to function in Fullscreen or Windowed Mode
        ' Still in testing, since Terminal still needs to be in fullscreen anyway
        C_DF_SwitchMode()
    End Sub

    Private Sub Console_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_TextSize = 11
        C_TextStyle = New FontFamily("Consolas")
    End Sub
End Class