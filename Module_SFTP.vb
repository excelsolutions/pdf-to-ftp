Imports System.IO
Imports Renci.SshNet
Module Module_SFTP
    Sub Send_To_FTP_SFTP(Filename_And_Path As String, New_Name As String, Address As String, Login As String, Password As String, Optional Sftp_Ftp As String = "FTP")
        Dim Filename As String = Path.GetFileName(Filename_And_Path)

        If Sftp_Ftp = "SFTP" Then
            Dim Client As SftpClient = New SftpClient(Address, Login, Password)
            Client.Connect()
            Using stream As Stream = File.OpenRead(Filename_And_Path)
                Client.UploadFile(stream, Filename_And_Path)
            End Using
        Else
            If Right(Address, 1) <> "/" Or Right(Address, 1) <> "\" Then
                Address &= "/"
            End If
            My.Computer.Network.UploadFile(Filename_And_Path, Address & "/" & Filename, Login, Password, True, 500)
        End If

    End Sub
End Module
