Imports System.IO
Imports System.Media
Imports System.Resources
' Imports System.Resoures

Module CoreFunctions
    Private ReadOnly Co_SoundPlayers As New Dictionary(Of String, SoundPlayer)
    Private ReadOnly Co_lastPlayTimes As New Dictionary(Of String, DateTime)

    Public Sub Core_CheckLang(Lang As String)
        ' This is still work-in-progress and I want to finish on
        ' working this code later on

        Select Case Lang
            Case "en"
                Core_WriteLang(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "Lang\en.resx"))
            Case "id"
        End Select
    End Sub

    Public Sub Core_WriteLang(SourceLang As String)
        ' The following code still needs to be audited because I can't figure out
        ' how to extract the lang file to the program output folder

        ' Read all string resources from the source file
        Dim LangStrings As New Dictionary(Of String, String)
        Using ResxReader As New ResXResourceReader(SourceLang)
            For Each entry As DictionaryEntry In ResxReader
                If TypeOf entry.Value Is String Then
                    LangStrings.Add(entry.Key.ToString(), entry.Value.ToString())
                End If
            Next
        End Using

        ' Get the path to the project's resource file
        Dim ProjectDir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))
        Dim ResxPath = Path.Combine(ProjectDir, "Lang\xx.resx")

        ' Write strings to the destination file
        Using ResxWriter As New ResXResourceWriter(ResxPath)
            For Each kvp As KeyValuePair(Of String, String) In LangStrings
                ResxWriter.AddResource(kvp.Key, kvp.Value)
            Next
        End Using
    End Sub

    Public Sub Core_BootOS()
        If C_IsOpened = False Then
            Console_Main.Show()
        End If
        Console_Clear(0)
        If IsColdboot = True Then
            Console_Write(2, "[ShiftKernel] : Cold boot has been initiated")
            IsColdboot = False
        Else
            Console_Write(2, "[ShiftKernel] : Reboot is initiated")
        End If
        'Console_Write(2, "user@shiftos $> ")            ' This will be used if the debug mode is not enabled
        Console_NewLine("user@shiftos $> ", "main")
        Console_Focus(1)
    End Sub

    Public Sub Core_PlaySound(SoundName As String, SoundResource As IO.UnmanagedMemoryStream)
        ' To check if the sound effect is listed in the dictionary.
        ' If not, the we'll add it to the dictionary for efficient use later
        If Not Co_SoundPlayers.ContainsKey(SoundName) Then
            Co_SoundPlayers(SoundName) = New SoundPlayer(SoundResource)
        End If
        ' This one is to check the last time the sound played for not playing
        ' the sound multiple times
        If Not Co_lastPlayTimes.ContainsKey(SoundName) Then
            Co_lastPlayTimes(SoundName) = DateTime.MinValue
        End If

        ' Only play if it's been at least 100 milliseconds since the last play
        If DateTime.Now - Co_lastPlayTimes(SoundName) > TimeSpan.FromMilliseconds(100) Then
            Co_SoundPlayers(SoundName).Play()
            Co_lastPlayTimes(SoundName) = DateTime.Now
        End If
    End Sub

    Public Sub Core_DisposeSounds()
        For Each player In Co_SoundPlayers.Values
            ' Basically, this will dispose all the player for the sound effects
            player.Dispose()
        Next
        ' Clearing all dictionary of the sound effects used in the game
        Co_SoundPlayers.Clear()
        ' Clearing all the last time the sound plays in order to not double the sound
        Co_lastPlayTimes.Clear()
    End Sub

    Public Sub Core_CaptureSecureType()
        ' Toggling the SecureType
        Console_SecureType()
        ' Debug purpose only
        Console_NewLine($"The SecureType you enterred is ""{C_SecureType}""", "main")
        ' Blank out the SecureType to Nothing, but not null
        C_SecureType = ""
    End Sub
End Module
