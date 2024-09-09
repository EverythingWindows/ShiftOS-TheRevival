Imports System.Windows.Forms

Module ShortcutTracker_RichText
    Public Shortcuts As New Dictionary(Of Keys, String)                             ' Dictionary of what shortcuts that can be used to trigger some functions
    Public SubjectRichText As New Dictionary(Of RichTextBox, IShortcutHandlerR)     ' This one makes a dictionary of textboxs that will use this module
    Public LastTriggeredShortcut As String = ""                                     ' To keep track of what shortcut was triggered last time in order to not trigger it again
    Public LastTriggerTime As Date = Date.MinValue                                  ' This one is for keeping track of how many miliseconds
    Public Const CooldownMs As Integer = 250                                        ' Cooldown time is in miliseconds

    Public Sub Initialize()
        Core_AddKeybind_Textbox(Keys.Control Or Keys.F, "Ctrl+F")                   ' Placeholder shortcut to test the functionality
        Core_AddKeybind_Textbox(Keys.Menu Or Keys.Alt, "Alt")                       ' This one acts as a placeholder too
        Core_AddKeybind_Textbox(Keys.Control Or Keys.Alt Or Keys.A, "Ctrl+Alt+A")   ' To test the SecureType
        If Console_IsDebuged = True Then                                            ' Debug purpose
            Console_NewLine("Keybind has started", "main")
        End If
    End Sub

    Public Sub Core_AddKeybind_Textbox(Keybind As Keys, Name As String)
        Shortcuts(Keybind) = Name
        If Console_IsDebuged = True Then                                            ' Debug purpose
            Console_NewLine(Name & " is added to the list", "main")
        End If
    End Sub

    Public Sub Core_RegisterTextBox(TargetTextBox As RichTextBox, handler As IShortcutHandlerR)
        ' Checking if the textbox already exists or not
        If Not SubjectRichText.ContainsKey(TargetTextBox) Then
            ' This will add the textbox into the dictionary if not exists yet
            SubjectRichText(TargetTextBox) = handler
            ' This one is to add the functionality of Core_HandleKeyDown to the textbox itself
            AddHandler TargetTextBox.KeyDown, AddressOf Core_HandleKeyDown
            If Console_IsDebuged = True Then
                Console_NewLine($"ShortcutTracker: Registered RichTextBox", "main") ' Debug purpose
            End If
        End If
    End Sub

    Public Sub Core_UnregisterTextBox(textBox As RichTextBox)
        ' Checking if the textbox already exists or not
        If SubjectRichText.ContainsKey(textBox) Then
            ' This one is to remove the functionality of Core_HandleKeyDown to the textbox itself
            RemoveHandler textBox.KeyDown, AddressOf Core_HandleKeyDown
            SubjectRichText.Remove(textBox)
            If Console_IsDebuged = True Then                                        ' Debug purpose
                Console_NewLine($"ShortcutTracker: Unregistered RichTextBox", "main")
            End If
        End If
    End Sub

    Private Sub Core_HandleKeyDown(sender As Object, e As KeyEventArgs)
        ' This one is for debugging by letting the lbl_Keystroke know about what key is pressed, the result is very raw
        Console_Main.lbl_keystroke.Text = $"{e.KeyData}"
        ' Defining the KeyData as the key
        Dim key As Keys = e.KeyData
        ' Checking if the shortcut dictionary contains the shortcut triggered
        If Shortcuts.ContainsKey(key) Then
            ' Define the current shortcut as the triggered shortcut to check its duplication later
            Dim CurrentShortxut = Shortcuts(key)
            ' Letting the module know that the time of trigger is right now
            Dim CurrentTime = Date.Now
            ' Defining the total of miliseconds of delay between the current and the last keystroke pressed
            Dim ElapsedMS = (CurrentTime - LastTriggerTime).TotalMilliseconds
            ' Checking if the shortcut is what's listed or the time has passed beyond the cooldown
            If CurrentShortxut <> LastTriggeredShortcut OrElse elapsedMs >= CooldownMs Then
                If Console_IsDebuged = True Then
                    ' Debug purpose
                    Console_NewLine($"ShortcutTracker: Shortcut detected - {Shortcuts(key)}", "main")
                End If
                Dim textBox = TryCast(sender, RichTextBox)
                If textBox IsNot Nothing AndAlso SubjectRichText.ContainsKey(textBox) Then
                    ' To run the shortcut trigger based on what shortcut is pressed
                    SubjectRichText(textBox).RunShortcut(Shortcuts(key))
                    ' Define the last triggered shortcut
                    LastTriggeredShortcut = CurrentShortxut
                    ' Define the last triggered time
                    LastTriggerTime = CurrentTime
                    ' To know that the EventArgs is already handled
                    e.Handled = True
                    ' To know that the key has been surpressed until further notice
                    e.SuppressKeyPress = True
                End If
            End If
        Else
            ' Clear the last triggered shortcut if the list of shortcut isn't listed
            LastTriggeredShortcut = Nothing
        End If
    End Sub
End Module

Public Interface IShortcutHandlerR
    Sub RunShortcut(shortcutName As String)
End Interface
