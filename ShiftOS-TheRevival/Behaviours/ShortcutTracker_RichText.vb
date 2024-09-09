Imports System.Windows.Forms

Module ShortcutTracker_RIchText
    Public Shortcuts As New Dictionary(Of Keys, String)
    Public SubjectRichText As New Dictionary(Of RichTextBox, IShortcutHandlerR)
    Public LastTriggeredShortcut As String = ""
    Public lastTriggerTime As Date = Date.MinValue
    Public Const CooldownMs As Integer = 250 ' Cooldown time in milliseconds

    Public Sub Initialize()
        Core_AddKeybind2(Keys.Control Or Keys.F, "Ctrl+F")
        Core_AddKeybind2(Keys.Menu Or Keys.Alt, "Alt")
        Core_AddKeybind2(Keys.Control Or Keys.Alt Or Keys.A, "Ctrl+Alt+A")
        If Console_IsDebuged = True Then
            Console_NewLine("Keybind has started", "main")
        End If
    End Sub

    Public Sub Core_AddKeybind2(Keybind As Keys, Name As String)
        Shortcuts(Keybind) = Name
        If Console_IsDebuged = True Then
            Console_NewLine(Name & " is added to the list", "main")
        End If
    End Sub

    Public Sub RegisterTextBox(textBox As RichTextBox, handler As IShortcutHandlerR)
        If Not SubjectRichText.ContainsKey(textBox) Then
            SubjectRichText(textBox) = handler
            AddHandler textBox.KeyDown, AddressOf HandleKeyDown
            If Console_IsDebuged = True Then
                Console_NewLine($"ShortcutTracker: Registered RichTextBox", "main")
            End If
        End If
    End Sub

    Public Sub UnregisterTextBox(textBox As RichTextBox)
        If SubjectRichText.ContainsKey(textBox) Then
            RemoveHandler textBox.KeyDown, AddressOf HandleKeyDown
            SubjectRichText.Remove(textBox)
            If Console_IsDebuged = True Then
                Console_NewLine($"ShortcutTracker: Unregistered RichTextBox", "main")
            End If
        End If
    End Sub

    Private Sub HandleKeyDown(sender As Object, e As KeyEventArgs)
        Console_Main.lbl_keystroke.Text = $"{e.KeyData}"
        Dim key As Keys = e.KeyData
        If Shortcuts.ContainsKey(key) Then
            Dim CurrentShortxut = Shortcuts(key)
            Dim currentTime = Date.Now
            Dim elapsedMs = (currentTime - lastTriggerTime).TotalMilliseconds
            If CurrentShortxut <> LastTriggeredShortcut OrElse elapsedMs >= CooldownMs Then
                If Console_IsDebuged = True Then
                    Console_NewLine($"ShortcutTracker: Shortcut detected - {Shortcuts(key)}", "main")
                End If
                Dim textBox = TryCast(sender, RichTextBox)
                If textBox IsNot Nothing AndAlso SubjectRichText.ContainsKey(textBox) Then
                    SubjectRichText(textBox).RunShortcut(Shortcuts(key))
                    LastTriggeredShortcut = CurrentShortxut
                    lastTriggerTime = currentTime
                    e.Handled = True
                    e.SuppressKeyPress = True
                End If
            End If
        Else
            LastTriggeredShortcut = Nothing
        End If
    End Sub
End Module

Public Interface IShortcutHandlerR
    Sub RunShortcut(shortcutName As String)
End Interface
