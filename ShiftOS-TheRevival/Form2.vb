Imports System.Threading

Public Class Form2
    Public PB_value As Integer
    Public l_value As Integer
    Public StopThread As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = 0
        ProgressBar1.Value = 0
        StopThread = False
        If CheckBox1.Checked = True Then
            Dim Thread1 As New Thread(AddressOf PB_Increment)
            Dim Thread2 As New Thread(AddressOf l_Increment)
            Thread1.Start()
            Thread2.Start()
        Else
            For V As Integer = 1 To 1000
                ProgressBar1.Value = V
            Next
            For V As Integer = 1 To 1000
                Select Case V
                    Case 100
                        Label1.Text = "Finished!"
                    Case Else
                        Label1.Text = V
                End Select
            Next
        End If
    End Sub

    Private Sub PB_Increment()
        While Not StopThread
            For V As Integer = 1 To 1000
                ProgressBar1.Value = V
                If V = 1000 Then
                    StopThreads()
                End If
            Next
        End While
    End Sub

    Private Sub l_Increment()
        While Not StopThread
            For V As Integer = 1 To 1000
                Select Case V
                    Case 1000
                        Label1.Text = "Finished!"
                        StopThreads()
                    Case Else
                        Label1.Text = V
                End Select
            Next
        End While
    End Sub

    Private Sub StopThreads()
        StopThread = True
    End Sub
End Class