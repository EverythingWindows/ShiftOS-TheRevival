Module Console_DebugFunctions
    Public Console_IsFullscreen As Boolean = False
    Public Console_IsDebuged As Boolean = False                             ' Remember to turn this to False if you want to release the build

    Public Sub C_DF_SwitchMode()
        ' Switching the console window state to either windowed mode
        ' or headless fullscreen

        If Console_IsFullscreen = False Then
            If Console_Main.WindowState = FormWindowState.Maximized Then
                Console_Main.WindowState = FormWindowState.Normal
            End If
            Console_Main.FormBorderStyle = FormBorderStyle.None
            Console_Main.WindowState = FormWindowState.Maximized
            Console_IsFullscreen = True
        Else
            Console_Main.FormBorderStyle = FormBorderStyle.FixedSingle
            Console_Main.WindowState = FormWindowState.Normal
            Console_IsFullscreen = False
        End If
    End Sub

    Public Sub C_MultiLangTest()
        ' Trying to implement what type of language that should be
        ' displayed when the string trigger is executed
        ' Only to know if the string will use the correct language
        ' according to the GameLang property

        Select Case Global_GameLang
            Case "en"
                Console_NewLine(String.Format("This terminal is in {0}", My.Resources.en.Debug_MultiLangTest), "main")
            Case "id"
                Console_NewLine(String.Format("Terminal ini tersedia dalam {0}", My.Resources.id.Debug_MultiLangTest), "main")
            Case Else

        End Select
        Console_Focus(1)
    End Sub
End Module
