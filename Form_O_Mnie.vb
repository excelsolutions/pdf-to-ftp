﻿Imports System.Net.Mail
Public Class Form_O_Mnie
    Private Sub Btn_Zamknij_Click(sender As Object, e As EventArgs) Handles Btn_Zamknij.Click
        Me.Hide()
    End Sub

    Private Sub LinkMail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub LinkTel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub



    Private Sub LinkWWW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkWWW.LinkClicked
        Try
            Dim webAddress As String = "https://github.com/excelsolutions/pdf-to-ftp"
            Process.Start(webAddress)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form_O_Mnie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L_Wersja.Text = "Ver. " & Me.GetType.Assembly.GetName.Version.ToString
    End Sub

    Private Sub L_Wersja_Click(sender As Object, e As EventArgs) Handles L_Wersja.Click
        Try
            Dim webAddress As String = "https://github.com/excelsolutions/pdf-to-ftp"
            Process.Start(webAddress)
        Catch ex As Exception

        End Try

    End Sub
End Class