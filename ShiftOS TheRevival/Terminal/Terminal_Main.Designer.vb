<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal_Main
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
        rt_maintext = New RichTextBox()
        p_Debug = New Panel()
        b_ToggleFS = New Button()
        p_Debug.SuspendLayout()
        SuspendLayout()
        ' 
        ' rt_maintext
        ' 
        rt_maintext.BackColor = Color.Black
        rt_maintext.BorderStyle = BorderStyle.None
        rt_maintext.Dock = DockStyle.Fill
        rt_maintext.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        rt_maintext.ForeColor = Color.White
        rt_maintext.Location = New Point(0, 0)
        rt_maintext.Name = "rt_maintext"
        rt_maintext.Size = New Size(800, 450)
        rt_maintext.TabIndex = 0
        rt_maintext.Text = ""
        ' 
        ' p_Debug
        ' 
        p_Debug.Controls.Add(b_ToggleFS)
        p_Debug.Location = New Point(12, 63)
        p_Debug.Name = "p_Debug"
        p_Debug.Size = New Size(200, 100)
        p_Debug.TabIndex = 1
        ' 
        ' b_ToggleFS
        ' 
        b_ToggleFS.Location = New Point(5, 5)
        b_ToggleFS.Name = "b_ToggleFS"
        b_ToggleFS.Size = New Size(75, 23)
        b_ToggleFS.TabIndex = 0
        b_ToggleFS.Text = "toggle fs"
        b_ToggleFS.UseVisualStyleBackColor = True
        ' 
        ' Terminal_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(p_Debug)
        Controls.Add(rt_maintext)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Terminal_Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Terminal"
        p_Debug.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents rt_maintext As RichTextBox
    Friend WithEvents p_Debug As Panel
    Friend WithEvents b_ToggleFS As Button
End Class
