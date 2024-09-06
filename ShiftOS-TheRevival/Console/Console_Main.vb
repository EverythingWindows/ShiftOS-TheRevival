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
        ' This one is to test the functionality of Console_ShowX()
        Console_ShowHeader(True)
        Console_ShowFooter(True)
        ' This one is to test the ability to change the foreground and/or background color
        Console_ColorFooter(Color.Red, Color.Black)
        ' This is to check either the console is in a debug state or nah
        If Console_IsDebuged = True Then
            p_Debug.Visible = True
            Console_IsFullscreen = True
            C_DF_SwitchMode()
        Else
            p_Debug.Visible = False
            Console_IsFullscreen = False
            C_DF_SwitchMode()
        End If
        ' This is to test the writing text using the futurely designed
        ' Console_Write() sub, I already implemented this?
        Console_Write(2, "user@shiftos $> ")
        Console_Focus(1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ChangeFace(ComboBox1.SelectedText, Nothing)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ChangeFace(Nothing, ComboBox2.SelectedText)
    End Sub

    Private Sub b_MultiLangTest_Click(sender As Object, e As EventArgs) Handles b_MultiLangTest.Click
        ' This is to test Multilanguage support using strings available in the
        ' resource directory. I am planning to do expand the support in the future
        Global_GameLang = cb_Lang.SelectedItem
        C_MultiLangTest()
    End Sub
End Class