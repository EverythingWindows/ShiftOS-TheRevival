Imports System.Media

Public Class MainMenu_Parent
    Private Property IsValidMouseButton As Boolean

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
        WhichLabel.Font = New Font("Consolas", 16)
        WhichLabel.ForeColor = Color.LightGreen
        ' Adding the sound effect to the Core_PlaySound field, this actually has better memory management than the one below
        'My.Computer.Audio.Play(My.Resources.Sound.MainMenu_Hover2, AudioPlayMode.Background)
        Core_PlaySound("MainMenu_Hover2", My.Resources.Sound.MainMenu_Hover2)
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

    Private Sub ClickAnyObject(sender As Object, e As MouseEventArgs) Handles lbl_StartGame.Click, lbl_LoadGame.Click, lbl_Settings.Click, lbl_About.Click, lbl_Exit.Click
        'My.Computer.Audio.Play(My.Resources.Sound.MainMenu_Click, AudioPlayMode.Background)

        ' The following If is available to make sure if the mouse button is Left or not.
        ' If Left, then go ahead
        If e.Button = MouseButtons.Left Then
            IsValidMouseButton = True
            Core_PlaySound("MainMenu_Click", My.Resources.Sound.MainMenu_Click)
        Else
            IsValidMouseButton = False
        End If
    End Sub

    Private Sub lbl_StartGame_Click(sender As Object, e As EventArgs) Handles lbl_StartGame.Click
        If IsValidMouseButton = True Then
            Console_Main.Show()
            Close()
        End If
    End Sub

    Private Sub Open_Settings(sender As Object, e As EventArgs) Handles lbl_Settings.Click
        If IsValidMouseButton = True Then
            ' Shows the ShiftOS Main Menu Settings form
            MainMenu_Settings.ShowDialog()
        End If
    End Sub

    Private Sub Open_About(sender As Object, e As EventArgs) Handles lbl_About.Click
        If IsValidMouseButton = True Then
            MainMenu_About.ShowDialog()
        End If
    End Sub

    Private Sub Terminate_Game(sender As Object, e As EventArgs) Handles lbl_Exit.Click
        If IsValidMouseButton = True Then
            ' Closing the application
            Close()
        End If
    End Sub


End Class