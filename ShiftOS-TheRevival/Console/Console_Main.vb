Public Class Console_Main
    Implements IShortcutHandlerR

    Public SecureType As String = ""

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
        ' This is to check either the console is in a debug state or nah
        If Console_IsDebuged = True Then
            ' If the Console enters the debug state, then it will automatically runs all available debug
            ' function. If not, then the Console will just directly runs what Terminal supposed to be
            p_Debug.Visible = True
            Console_IsFullscreen = True
            C_DF_SwitchMode()
            ' This one is to test the functionality of Console_ShowX()
            Console_ShowHeader(True)
            Console_ShowFooter(True)
            ' This one is to test the ability to change the foreground and/or background color
            Console_ColorHeader(Color.White, Color.FromArgb(12, 55, 69))
            Console_ColorFooter(Color.Black, Color.Red)
            ' The code below will test the ability to display more that one line for the header and footer
            Console_SetHeader(3)
            Console_SetFooter(2)
        Else
            p_Debug.Visible = False
            Console_IsFullscreen = False
            C_DF_SwitchMode()
            Console_ShowHeader(False)
            Console_ShowFooter(False)
        End If
        ' Add this form into the ShortcutTracker list of forms opening
        ShortcutTracker_RichText.Initialize()
        ShortcutTracker_RichText.Core_RegisterTextBox(rt_maintext, Me)
        'ShortcutTracker.Core_AddKeybind(Keys.Control Or Keys.Q, "Ctrl+Q")
        ' This is to test the writing text using the futurely designed
        ' Console_Write() sub, I already implemented this?
        'Console_Write(2, "user@shiftos $> ")            ' This will be used if the debug mode is not enabled
        Console_NewLine("user@shiftos $> ", "main")
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

    Private Sub Console_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Console_NewLine("{Me.Name} - {e.KeyCode} has been pressed", "main")
    End Sub

    'Public Sub RunShortcut(shortcutName As String) Implements IShortcutHandler.RunShortcut
    '    Console_NewLine("{Me.Name} - {e.KeyData} has been pressed", "main")
    '    Select Case shortcutName
    '        Case "Ctrl+F"
    '            Console_NewLine("Hooray!", "rt_maintext")
    '        Case "Alt"
    '            Console_NewLine("Alt is alting", "rt_maintext")
    '    End Select
    'End Sub

    Public Sub RunShortcut(shortcutName As String) Implements IShortcutHandlerR.RunShortcut
        ' Console_NewLine($"{Me.Name} - {e.KeyData} has been pressed", "main")
        Select Case shortcutName
            Case "Ctrl+F"
                Console_NewLine("Hooray!", "main")
            Case "Alt"
                Console_NewLine("Alt is alting", "main")
            Case "Ctrl+Alt+A"
                Console_Write(1, "SecureType Activated")
                Console_SecureType()
        End Select
    End Sub

    Private Sub rt_maintext_TextChanged(sender As Object, e As EventArgs) Handles rt_maintext.TextChanged
        If C_IsSecureTypeEnabled = True Then
            ' Check if text was added (not removed)
            If rt_maintext.TextLength > 0 AndAlso rt_maintext.Text.Length > SecureType.Length Then
                ' Get the last character
                Dim lastChar As Char = rt_maintext.Text.Chars(rt_maintext.TextLength - 1)
                ' Append to SecureType
                SecureType += lastChar
                ' Replace last character *
                rt_maintext.Text = rt_maintext.Text.Substring(0, rt_maintext.TextLength - 1) & "*"
                ' Move cursor to end
                Console_Focus(1)
                lbl_SecureType.Text += lastChar
            End If
        End If
    End Sub
End Class