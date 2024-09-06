Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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

    Public Sub Console_Clear(Type As Integer)
        ' The clear function has several configs using the Type integer to
        ' choose whether only main text, with or without header, and/or
        ' with or without footer

        Select Case Type
            Case 0
                ' Clear All
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_maintext.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
            Case 1
                ' Clear just main
                Console_Main.rt_maintext.Text = Nothing
            Case 2
                ' Clear just header
                Console_Main.rt_header.Text = Nothing
            Case 3
                ' Clear just footer
                Console_Main.rt_footer.Text = Nothing
            Case 4
                ' Clear header and main
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_maintext.Text = Nothing
            Case 5
                ' Clear main and footer
                Console_Main.rt_maintext.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
            Case 6
                ' Clear header and footer
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
        End Select
    End Sub

    Public Sub Console_Focus(Type As Integer)
        ' The focus function has several configs using the Type integer to
        ' choose whether only main text, with or without header, and/or
        ' with or without footer
        Select Case Type
            Case 0
                ' Clear All
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_maintext.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
            Case 1
                ' Clear just main
                Console_Main.rt_maintext.SelectionStart = Console_Main.rt_maintext.Text.Length
                Console_Main.rt_maintext.ScrollToCaret()
            Case 2
                ' Clear just header
                Console_Main.rt_header.Text = Nothing
            Case 3
                ' Clear just footer
                Console_Main.rt_footer.Text = Nothing
            Case 4
                ' Clear header and main
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_maintext.Text = Nothing
            Case 5
                ' Clear main and footer
                Console_Main.rt_maintext.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
            Case 6
                ' Clear header and footer
                Console_Main.rt_header.Text = Nothing
                Console_Main.rt_footer.Text = Nothing
        End Select
    End Sub
End Module
