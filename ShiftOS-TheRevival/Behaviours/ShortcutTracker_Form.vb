Imports System.Windows.Forms

Module ShortcutTracker_Form
    Public Shortcuts As New Dictionary(Of Keys, String)
    Public SubjectForms As New List(Of Form)

    Public Sub Initialize()
        Core_AddKeybind(Keys.Control AndAlso Keys.F, "Ctrl+F")
        Core_AddKeybind(Keys.Alt, "Alt")
        Console_NewLine("Keybind has started", "main")
    End Sub

    Public Sub Core_AddKeybind(Keybind As Keys, Name As String)
        Shortcuts(Keybind) = Name
        Console_NewLine(Name & " is added to the list", "main")
    End Sub

    Public Sub AddForms(form As Form)
        If Not SubjectForms.Contains(form) Then
            SubjectForms.Add(form)
            AddHandler form.KeyDown, AddressOf HandleKeyDown
            Console_NewLine(form.Name & " has been registered", "main")
        End If
    End Sub

    Public Sub RemoveForms(form As Form)
        If SubjectForms.Contains(form) Then
            SubjectForms.Remove(form)
            AddHandler form.KeyDown, AddressOf HandleKeyDown
        End If
    End Sub

    Public Sub HandleKeyDown(sender As Object, e As KeyEventArgs)
        Console_NewLine("ShortcutTracker.vb : {shortcuts(key)} has been pressed", "main")
        Dim key As Keys = e.KeyData
        If Shortcuts.ContainsKey(key) Then
            For Each form In SubjectForms
                TryCast(form, IShortcutHandler)?.RunShortcut(Shortcuts(key))
            Next
            e.Handled = True
        End If
    End Sub
End Module

Public Interface IShortcutHandler
    Sub RunShortcut(shortcutName As String)
End Interface
