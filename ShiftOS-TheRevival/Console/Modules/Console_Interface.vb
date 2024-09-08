Module Console_Interface
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

    Public Sub Console_SetHeader(Height As Integer)
        ' To set the header to between 1 to 3.
        If Height <= 3 Then
            C_Header_Height = Height
            Console_Main.rt_header.Height = (C_TextSize + 7) * Height
        End If
    End Sub

    Public Sub Console_SetFooter(Height As Integer)
        ' To set the header to between 1 and 2.
        If Height <= 2 Then
            C_Footer_Height = Height
            Console_Main.rt_footer.Height = (C_TextSize + 7) * Height
        End If
    End Sub

    Public Sub Console_ToggleReadOnly()
        ' Toggling either the Console is readonly or writeable
        If Console_Main.rt_maintext.ReadOnly = True Then
            Console_Main.rt_maintext.ReadOnly = False
        Else
            Console_Main.rt_maintext.ReadOnly = True
        End If
    End Sub
End Module
