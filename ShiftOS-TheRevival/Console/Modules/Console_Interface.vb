﻿Module Console_Interface
    Public Sub Console_ShowHeader(State As Boolean)
        ' This one is to toggle the visibility of header RichText
        If State = False Then
            Console_Main.rt_header.Visible = False
        ElseIf State = True Then
            Console_Main.rt_header.Visible = True
        End If
    End Sub

    Public Sub Console_ShowFooter(State As Boolean)
        ' This one is to toggle the visibility of footer RichText
        If State = False Then
            Console_Main.rt_footer.Visible = False
        ElseIf State = True Then
            Console_Main.rt_footer.Visible = True
        End If
    End Sub

    Public Sub Console_ColorHeader(Fore As Color, Back As Color)
        ' Changing the background and foreground color of the header
        If Not Fore = Nothing Then
            Console_Main.rt_header.ForeColor = Fore
        End If
        If Not Back = Nothing Then
            Console_Main.rt_header.BackColor = Back
        End If
    End Sub

    Public Sub Console_ColorFooter(Fore As Color, Back As Color)
        ' Changing the background and foreground color of the footer
        If Not Fore = Nothing Then
            Console_Main.rt_footer.ForeColor = Fore
        End If
        If Not Back = Nothing Then
            Console_Main.rt_footer.BackColor = Back
        End If
    End Sub
End Module