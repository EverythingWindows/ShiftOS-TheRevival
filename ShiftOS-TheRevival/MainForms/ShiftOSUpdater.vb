﻿Imports System.IO
Imports System.Net

Public Class ShiftOSUpdater
    Public HasChecked As Boolean
    Public NewVersion As String
    Public WithEvents Download As WebClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ShiftOSMenu.ShouldUpdate = True Then

        Else
            ShiftOSMenu.btn_Aboot.Enabled = True
            ShiftOSMenu.btn_Exit.Enabled = True
            ShiftOSMenu.btn_FreeRoam.Enabled = True
            ShiftOSMenu.btn_StoryMode.Enabled = True
        End If
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Download" Then
            Dim FilePut As New SaveFileDialog
            FilePut.Filter = "ShiftOS Program|*.exe"
            FilePut.Title = "Save an updated ShiftOS version"
            FilePut.ShowDialog()
            If Not FilePut.FileName = "" Then
                Button1.Enabled = False
                Button2.Enabled = False
                Dim PutTo As String = "http://github.com/EverythingWindows/ShiftOS-TheRevival/releases/download/" & NewVersion & "/ShiftOS-TheRevival.v" & NewVersion & ".exe"
                'Dim PutTo As String = "http://148.251.124.62:8080/ShiftOS/versions/ShiftOS-TheRevival.v" & NewVersion & ".exe" <= Legacy Updater
                'Dim GetTo As New Uri(PutTo)
                My.Computer.Network.DownloadFile(PutTo, FilePut.FileName)
                'Revisit this later
                'Download.DownloadFileAsync(GetTo, FilePut.FileName)
                Button1.Enabled = True
                Button2.Enabled = True
                ShiftOSMenu.btn_Aboot.Enabled = True
                ShiftOSMenu.btn_Exit.Enabled = True
                ShiftOSMenu.btn_FreeRoam.Enabled = True
                ShiftOSMenu.btn_StoryMode.Enabled = True
                Button2.Text = "Saved"
            End If
        ElseIf Button2.Text = "Update" Then
            Label2.Text = "Updating ShiftOS to " & My.Resources.CurrentVersion
            UpdateToNew()
        Else
            Close()
        End If
    End Sub
    Private Sub ShiftOSUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ShiftOSMenu.ShouldUpdate = True Then
            Button2.Text = "Update"
        End If
    End Sub

    'Will revisit this later
    'Private Sub Download_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles Download.DownloadProgressChanged
    '    ProgressBar1.Value = e.ProgressPercentage
    'End Sub
End Class