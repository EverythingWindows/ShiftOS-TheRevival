Module Console_Typeface
    Public Sub ChangeFace(face As String, size As Integer)
        If Not face = Nothing Then
            Try
                C_TextStyle = New FontFamily(face)
                face = Nothing
            Catch ex As Exception

            End Try
        End If
        If Not size = Nothing Then
            C_TextSize = size
            size = Nothing
        End If
    End Sub
End Module
