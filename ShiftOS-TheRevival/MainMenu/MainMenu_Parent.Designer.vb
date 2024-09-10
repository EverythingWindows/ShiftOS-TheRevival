<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu_Parent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_GameTitle = New Label()
        lbl_StartGame = New Label()
        lbl_LoadGame = New Label()
        lbl_Settings = New Label()
        lbl_About = New Label()
        lbl_Exit = New Label()
        Label7 = New Label()
        lbl_Build = New Label()
        lbl_itemDesc = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' lbl_GameTitle
        ' 
        lbl_GameTitle.AutoSize = True
        lbl_GameTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_GameTitle.ForeColor = Color.White
        lbl_GameTitle.Location = New Point(370, 25)
        lbl_GameTitle.Name = "lbl_GameTitle"
        lbl_GameTitle.Size = New Size(113, 37)
        lbl_GameTitle.TabIndex = 0
        lbl_GameTitle.Text = "ShiftOS"
        ' 
        ' lbl_StartGame
        ' 
        lbl_StartGame.AutoSize = True
        lbl_StartGame.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_StartGame.ForeColor = Color.White
        lbl_StartGame.Location = New Point(370, 100)
        lbl_StartGame.Name = "lbl_StartGame"
        lbl_StartGame.Size = New Size(83, 20)
        lbl_StartGame.TabIndex = 1
        lbl_StartGame.Text = "Start Game"
        ' 
        ' lbl_LoadGame
        ' 
        lbl_LoadGame.AutoSize = True
        lbl_LoadGame.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_LoadGame.ForeColor = Color.White
        lbl_LoadGame.Location = New Point(370, 150)
        lbl_LoadGame.Name = "lbl_LoadGame"
        lbl_LoadGame.Size = New Size(85, 20)
        lbl_LoadGame.TabIndex = 1
        lbl_LoadGame.Text = "Load Game"
        ' 
        ' lbl_Settings
        ' 
        lbl_Settings.AutoSize = True
        lbl_Settings.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Settings.ForeColor = Color.White
        lbl_Settings.Location = New Point(370, 201)
        lbl_Settings.Name = "lbl_Settings"
        lbl_Settings.Size = New Size(62, 20)
        lbl_Settings.TabIndex = 1
        lbl_Settings.Text = "Settings"
        ' 
        ' lbl_About
        ' 
        lbl_About.AutoSize = True
        lbl_About.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_About.ForeColor = Color.White
        lbl_About.Location = New Point(370, 253)
        lbl_About.Name = "lbl_About"
        lbl_About.Size = New Size(50, 20)
        lbl_About.TabIndex = 1
        lbl_About.Text = "About"
        ' 
        ' lbl_Exit
        ' 
        lbl_Exit.AutoSize = True
        lbl_Exit.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Exit.ForeColor = Color.White
        lbl_Exit.Location = New Point(370, 306)
        lbl_Exit.Name = "lbl_Exit"
        lbl_Exit.Size = New Size(33, 20)
        lbl_Exit.TabIndex = 1
        lbl_Exit.Text = "Exit"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(86, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 45)
        Label7.TabIndex = 2
        Label7.Text = "BANNER!"
        ' 
        ' lbl_Build
        ' 
        lbl_Build.AutoSize = True
        lbl_Build.BackColor = Color.Transparent
        lbl_Build.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Build.ForeColor = Color.White
        lbl_Build.Location = New Point(351, 409)
        lbl_Build.Name = "lbl_Build"
        lbl_Build.Size = New Size(37, 15)
        lbl_Build.TabIndex = 3
        lbl_Build.Text = "build "
        ' 
        ' lbl_itemDesc
        ' 
        lbl_itemDesc.BackColor = Color.Transparent
        lbl_itemDesc.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_itemDesc.ForeColor = Color.White
        lbl_itemDesc.Location = New Point(351, 351)
        lbl_itemDesc.Name = "lbl_itemDesc"
        lbl_itemDesc.Size = New Size(315, 47)
        lbl_itemDesc.TabIndex = 3
        lbl_itemDesc.Text = "Move your mouse to any item to see its description"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(339, 433)
        Panel1.TabIndex = 4
        ' 
        ' MainMenu_Parent
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(695, 433)
        Controls.Add(lbl_itemDesc)
        Controls.Add(lbl_Build)
        Controls.Add(Label7)
        Controls.Add(lbl_Exit)
        Controls.Add(lbl_About)
        Controls.Add(lbl_Settings)
        Controls.Add(lbl_LoadGame)
        Controls.Add(lbl_StartGame)
        Controls.Add(lbl_GameTitle)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainMenu_Parent"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_GameTitle As Label
    Friend WithEvents lbl_StartGame As Label
    Friend WithEvents lbl_LoadGame As Label
    Friend WithEvents lbl_Settings As Label
    Friend WithEvents lbl_About As Label
    Friend WithEvents lbl_Exit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Build As Label
    Friend WithEvents lbl_itemDesc As Label
    Friend WithEvents Panel1 As Panel
End Class
