Public Class Console_Main

    Private Sub ToggleFS() Handles b_ToggleFS.Click
        ' To test Console to function in Fullscreen or Windowed Mode
        ' Still in testing, since Terminal still needs to be in fullscreen anyway
        C_DF_SwitchMode()
    End Sub

    Private Sub Console_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setting the font to the saved or default one
        ' Changing the overall fontface is TBD
        C_TextSize = 11
        C_TextStyle = New FontFamily("Consolas")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ChangeFace(ComboBox1.SelectedText, Nothing)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Console_Typeface.ChangeFace(Nothing, ComboBox2.SelectedText)
    End Sub

    Private Sub b_MultiLangTest_Click(sender As Object, e As EventArgs) Handles b_MultiLangTest.Click
        ' This is to test Multilanguage support using strings available in the
        ' resource directory. I am planning to do expand the support in the future
        Global_GameLang = cb_Lang.SelectedItem
        C_MultiLangTest()
    End Sub
End Class