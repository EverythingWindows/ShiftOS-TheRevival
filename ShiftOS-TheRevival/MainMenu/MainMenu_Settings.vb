Public Class MainMenu_Settings
    Private Sub MainMenu_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    'Private Sub MainMenu_Settings_AttemptClose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    e.Cancel = False
    '    Dim Question As MsgBoxResult
    '    ' MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Settings")
    '    '
    '    ' Failed attempt to do if the settings is finished, then
    '    ' return to main menu
    '    '
    '    Question = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Settings")
    '    If Question = MsgBoxResult.Yes Then
    '        MsgBox(e.Cancel)
    '        e.Cancel = False
    '        Close()
    '    Else
    '        MsgBox("A")
    '        e.Cancel = True
    '    End If
    'End Sub
End Class