<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Console_Main
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
        rt_header = New RichTextBox()
        rt_footer = New RichTextBox()
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
        rt_maintext.Location = New Point(0, 16)
        rt_maintext.Name = "rt_maintext"
        rt_maintext.Size = New Size(800, 418)
        rt_maintext.TabIndex = 0
        rt_maintext.Text = ""
        ' 
        ' p_Debug
        ' 
        p_Debug.Controls.Add(b_ToggleFS)
        p_Debug.Location = New Point(12, 53)
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
        ' rt_header
        ' 
        rt_header.BackColor = Color.White
        rt_header.BorderStyle = BorderStyle.None
        rt_header.Dock = DockStyle.Top
        rt_header.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        rt_header.ForeColor = Color.Black
        rt_header.Location = New Point(0, 0)
        rt_header.Name = "rt_header"
        rt_header.Size = New Size(800, 16)
        rt_header.TabIndex = 0
        rt_header.Text = ""
        ' 
        ' rt_footer
        ' 
        rt_footer.BackColor = Color.White
        rt_footer.BorderStyle = BorderStyle.None
        rt_footer.Dock = DockStyle.Bottom
        rt_footer.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        rt_footer.ForeColor = Color.Black
        rt_footer.Location = New Point(0, 434)
        rt_footer.Name = "rt_footer"
        rt_footer.Size = New Size(800, 16)
        rt_footer.TabIndex = 2
        rt_footer.Text = ""
        ' 
        ' Console_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(p_Debug)
        Controls.Add(rt_maintext)
        Controls.Add(rt_footer)
        Controls.Add(rt_header)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Console_Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Terminal"
        p_Debug.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents rt_maintext As RichTextBox
    Friend WithEvents p_Debug As Panel
    Friend WithEvents b_ToggleFS As Button
    Friend WithEvents rt_header As RichTextBox
    Friend WithEvents rt_footer As RichTextBox
End Class
