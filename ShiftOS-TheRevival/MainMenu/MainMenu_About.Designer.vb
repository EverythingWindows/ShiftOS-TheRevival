<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu_About
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
        lbl_OK = New Button()
        lbl_Build = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        lbl_GameTitle = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lbl_OK
        ' 
        lbl_OK.Location = New Point(644, 543)
        lbl_OK.Name = "lbl_OK"
        lbl_OK.Size = New Size(108, 46)
        lbl_OK.TabIndex = 0
        lbl_OK.Text = "OK"
        lbl_OK.UseVisualStyleBackColor = True
        ' 
        ' lbl_Build
        ' 
        lbl_Build.AutoSize = True
        lbl_Build.BackColor = Color.Transparent
        lbl_Build.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Build.ForeColor = Color.White
        lbl_Build.Location = New Point(12, 577)
        lbl_Build.Name = "lbl_Build"
        lbl_Build.Size = New Size(37, 15)
        lbl_Build.TabIndex = 4
        lbl_Build.Text = "build "
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(386, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 450)
        Label1.TabIndex = 5
        Label1.Text = "Philip Adams" & vbCrLf & "Michael Van Overbeek" & vbCrLf & "Phil J. Gates"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(379, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1, 450)
        Panel1.TabIndex = 6
        ' 
        ' lbl_GameTitle
        ' 
        lbl_GameTitle.AutoSize = True
        lbl_GameTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_GameTitle.ForeColor = Color.White
        lbl_GameTitle.Location = New Point(21, 19)
        lbl_GameTitle.Name = "lbl_GameTitle"
        lbl_GameTitle.Size = New Size(133, 45)
        lbl_GameTitle.TabIndex = 7
        lbl_GameTitle.Text = "ShiftOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(160, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 21)
        Label2.TabIndex = 7
        Label2.Text = "Shift it your way"
        ' 
        ' MainMenu_About
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(764, 601)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(lbl_GameTitle)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(lbl_Build)
        Controls.Add(lbl_OK)
        Name = "MainMenu_About"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu_About"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_OK As Button
    Friend WithEvents lbl_Build As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_GameTitle As Label
    Friend WithEvents Label2 As Label
End Class
