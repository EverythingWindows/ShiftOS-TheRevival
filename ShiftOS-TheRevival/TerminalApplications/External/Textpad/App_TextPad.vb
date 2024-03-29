﻿Imports System.IO
Imports System.ComponentModel

Module App_TextPad
    'Public WithEvents TextPad_Shortcut As BackgroundWorker

    'TextPad's RAM
    Public TextPad_FileName As String

    Public Sub TextPad_Start()
        Console.DefaultPrompt = Nothing
        Console.TextBox1.Text = Nothing
        Console.ToolBarUse = True
        Terminal_CheckFeature()
        Console.CurrentInterpreter = "textpad"
        TextPad_CheckExist(command)
        Console.ToolBar.Text = "TextPad - " & command & Environment.NewLine & "Ctrl-Q Exit | Ctrl-N New | Ctrl-O Open | Ctrl-S Save | F12 Save As"
        Console.ReleaseCursor = True
        Console.ShouldChange = True
        Console_Interpreters()
        TextRebind()
    End Sub

    Public Sub TextPad_CheckExist(TxtFileName As String)
        If File.Exists(Console.CurrentDirectory & "\" & TxtFileName) = True Then
            Console.TextBox1.Text = My.Computer.FileSystem.ReadAllText(Console.CurrentDirectory & "\" & TxtFileName)
        End If
    End Sub

    Public Sub TextPad_GenerateCP_SavedFile()
        Select Case Console.TextBox1.TextLength
            Case 1 To 9
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(1, 3)
                ChangeCP(True, GotCP)
            Case 10 To 99
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(4, 26)
                ChangeCP(True, GotCP)
            Case 100 To 999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(27, 251)
                ChangeCP(True, GotCP)
            Case 1000 To 9999
                Dim GetCP As New Random
                Dim GotCP As Integer = GetCP.Next(252, 2501)
                ChangeCP(True, GotCP)
        End Select
    End Sub

    Public Sub TextPad_WarnFile()
        NewLine("Type any filename after 'textpad'!, ex: textpad text.txt")
    End Sub
End Module
