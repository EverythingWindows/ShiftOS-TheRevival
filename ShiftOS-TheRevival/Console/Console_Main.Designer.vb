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
        lbl_keystroke = New Label()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        cb_Lang = New ComboBox()
        ComboBox1 = New ComboBox()
        b_MultiLangTest = New Button()
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
        rt_maintext.Location = New Point(0, 18)
        rt_maintext.Name = "rt_maintext"
        rt_maintext.ScrollBars = RichTextBoxScrollBars.None
        rt_maintext.ShortcutsEnabled = False
        rt_maintext.Size = New Size(800, 414)
        rt_maintext.TabIndex = 0
        rt_maintext.Text = ""
        ' 
        ' p_Debug
        ' 
        p_Debug.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        p_Debug.Controls.Add(lbl_keystroke)
        p_Debug.Controls.Add(Button1)
        p_Debug.Controls.Add(ComboBox2)
        p_Debug.Controls.Add(cb_Lang)
        p_Debug.Controls.Add(ComboBox1)
        p_Debug.Controls.Add(b_MultiLangTest)
        p_Debug.Controls.Add(b_ToggleFS)
        p_Debug.Location = New Point(446, 49)
        p_Debug.Name = "p_Debug"
        p_Debug.Size = New Size(342, 212)
        p_Debug.TabIndex = 1
        ' 
        ' lbl_keystroke
        ' 
        lbl_keystroke.AutoSize = True
        lbl_keystroke.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_keystroke.Location = New Point(8, 124)
        lbl_keystroke.Name = "lbl_keystroke"
        lbl_keystroke.Size = New Size(220, 15)
        lbl_keystroke.TabIndex = 4
        lbl_keystroke.Text = "Every key press should be displayed here"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(5, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 23)
        Button1.TabIndex = 3
        Button1.Text = "multicolor text"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"11", "12", "14", "16", "18", "24"})
        ComboBox2.Location = New Point(132, 34)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(65, 24)
        ComboBox2.TabIndex = 2
        ' 
        ' cb_Lang
        ' 
        cb_Lang.FormattingEnabled = True
        cb_Lang.Items.AddRange(New Object() {"en", "id"})
        cb_Lang.Location = New Point(5, 64)
        cb_Lang.Name = "cb_Lang"
        cb_Lang.Size = New Size(178, 24)
        cb_Lang.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Consolas", "Segoe UI", "Calibri", "Courier New"})
        ComboBox1.Location = New Point(5, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 24)
        ComboBox1.TabIndex = 1
        ' 
        ' b_MultiLangTest
        ' 
        b_MultiLangTest.Location = New Point(189, 64)
        b_MultiLangTest.Name = "b_MultiLangTest"
        b_MultiLangTest.Size = New Size(121, 23)
        b_MultiLangTest.TabIndex = 0
        b_MultiLangTest.Text = "multilang test"
        b_MultiLangTest.UseVisualStyleBackColor = True
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
        rt_header.ScrollBars = RichTextBoxScrollBars.None
        rt_header.Size = New Size(800, 18)
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
        rt_footer.Location = New Point(0, 432)
        rt_footer.Name = "rt_footer"
        rt_footer.ScrollBars = RichTextBoxScrollBars.None
        rt_footer.Size = New Size(800, 18)
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
        Text = "Console"
        p_Debug.ResumeLayout(False)
        p_Debug.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents rt_maintext As RichTextBox
    Friend WithEvents p_Debug As Panel
    Friend WithEvents b_ToggleFS As Button
    Friend WithEvents rt_header As RichTextBox
    Friend WithEvents rt_footer As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents b_MultiLangTest As Button
    Friend WithEvents cb_Lang As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_keystroke As Label
End Class
