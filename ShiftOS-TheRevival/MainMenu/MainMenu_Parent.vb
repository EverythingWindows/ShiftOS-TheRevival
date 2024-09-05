Public Class MainMenu_Parent
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This function is to check the game language and
        ' Applying it across all game components
        ' Will try to look at this code later
        'Core_CheckLang("en")
        lbl_Build.Text += My.Application.Info.Version.ToString
    End Sub

    Private Sub MouseEnterObject(sender As Object, e As EventArgs) Handles lbl_StartGame.MouseEnter, lbl_LoadGame.MouseEnter, lbl_Settings.MouseEnter, lbl_About.MouseEnter, lbl_Exit.MouseEnter
        ' To test the sudden resizing font change to bigger size when
        ' mouse is hovering/entering the label area
        '
        ' Looking for better code solution
        Dim WhichLabel As Label = CType(sender, Label)
        WhichLabel.Font = New Font("Segoe UI", 16)
        WhichLabel.ForeColor = Color.LightGreen
        Select Case WhichLabel.Name
            Case NameOf(lbl_StartGame)
                lbl_itemDesc.Text = My.Resources.en.MainMenu_StartGame
            Case NameOf(lbl_LoadGame)
                lbl_itemDesc.Text = My.Resources.id.MainMenu_LoadGame
            Case NameOf(lbl_Settings)
                lbl_itemDesc.Text = My.Resources.id.MainMenu_Settings
            Case NameOf(lbl_About)
                lbl_itemDesc.Text = My.Resources.en.MainMenu_About
            Case NameOf(lbl_Exit)
                lbl_itemDesc.Text = My.Resources.id.MainMenu_Exit
        End Select
    End Sub

    Private Sub MouseLeaveObject(sender As Object, e As EventArgs) Handles lbl_StartGame.MouseLeave, lbl_LoadGame.MouseLeave, lbl_Settings.MouseLeave, lbl_About.MouseLeave, lbl_Exit.MouseLeave
        ' To test the sudden resizing font change to smaller size when
        ' mouse is hovering/entering the label area
        '
        ' Looking for better code solution
        Dim WhichLabel As Label = CType(sender, Label)
        WhichLabel.Font = New Font("Segoe UI", 11)
        WhichLabel.ForeColor = Color.White
        lbl_itemDesc.Text = My.Resources.en.MainMenu_ItemDescBlank
    End Sub

    Private Sub Open_Settings(sender As Object, e As EventArgs) Handles lbl_Settings.Click
        ' Shows the ShiftOS Main Menu Settings form
        MainMenu_Settings.ShowDialog()
    End Sub

    Private Sub Terminate_Game(sender As Object, e As EventArgs) Handles lbl_Exit.Click
        ' Closing the application
        Close()
    End Sub

    'Private Sub MouseEnter_2(sender As Object, e As EventArgs) Handles Label2.MouseEnter

    'End Sub
End Class