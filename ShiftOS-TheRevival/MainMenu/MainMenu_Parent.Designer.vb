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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lbl_Build = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(370, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 37)
        Label1.TabIndex = 0
        Label1.Text = "ShiftOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(370, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 1
        Label2.Text = "Start Game"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(370, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 1
        Label3.Text = "Load Game"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(370, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 1
        Label4.Text = "Settings"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(370, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 1
        Label5.Text = "About"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(370, 315)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 20)
        Label6.TabIndex = 1
        Label6.Text = "Exit"
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
        lbl_Build.ForeColor = Color.White
        lbl_Build.Location = New Point(12, 408)
        lbl_Build.Name = "lbl_Build"
        lbl_Build.Size = New Size(37, 16)
        lbl_Build.TabIndex = 3
        lbl_Build.Text = "build "
        ' 
        ' MainMenu_Parent
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(695, 433)
        Controls.Add(lbl_Build)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainMenu_Parent"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_Build As Label
End Class
