Imports System.Media

Module CoreFunctions
    Private ReadOnly Co_SoundPlayers As New Dictionary(Of String, SoundPlayer)
    Private ReadOnly Co_lastPlayTimes As New Dictionary(Of String, DateTime)

    Public Sub Core_CheckLang(Lang As String)
        ' This is still work-in-progress and I want to finish on
        ' working this code later on

        Select Case Lang
            Case "en"
                ' My.Resources.xx = My.Resources.en
            Case "id"
        End Select
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
End Module
