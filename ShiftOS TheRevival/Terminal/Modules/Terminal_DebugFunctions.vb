Module Terminal_DebugFunctions
    Public Terminal_IsFullscreen As Boolean = False

    Public Sub T_DF_SwitchMode()
        ' Switching the terminal window state to either windowed mode
        ' or headless fullscreen

        If Terminal_IsFullscreen = False Then
            Terminal_Main.FormBorderStyle = FormBorderStyle.None
            Terminal_Main.WindowState = FormWindowState.Maximized
            Terminal_IsFullscreen = True
        Else
            Terminal_Main.FormBorderStyle = FormBorderStyle.FixedSingle
            Terminal_Main.WindowState = FormWindowState.Normal
            Terminal_IsFullscreen = False
        End If
    End Sub
End Module
