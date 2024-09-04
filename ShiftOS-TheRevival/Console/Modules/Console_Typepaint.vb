Module Console_Typepaint
    Public Sub Console_NewLine(NewString As String, RTType As String)
        ' Using the existing RichTextBox in the Console_Main, we can request
        ' A new line using Environment.NewLine
        ' And by selecting the case of new line between header, main, or
        ' footer. It is dynamically functional, rather than hard-coded.
        Select Case RTType
            Case "header"
                ' Header only limits the line to 3
                ' Future limitation code will be implemented in the future
                Console_Main.rt_header.Text = Console_Main.rt_header.Text & Environment.NewLine & NewString
            Case "main"
                Console_Main.rt_maintext.Text = Console_Main.rt_maintext.Text & Environment.NewLine & NewString
            Case "footer"
                ' Header only limits the line to 2
                ' Future limitation code will be implemented in the future
                Console_Main.rt_footer.Text = Console_Main.rt_footer.Text & Environment.NewLine & NewString
        End Select
    End Sub
End Module
