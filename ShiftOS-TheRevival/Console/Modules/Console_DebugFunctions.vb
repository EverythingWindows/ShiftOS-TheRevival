Module Console_DebugFunctions
    Public Console_IsFullscreen As Boolean = False

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
End Module
