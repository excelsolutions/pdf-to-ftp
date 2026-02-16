'Program PDF-to-SFTP
'
'Niniejsze oprogramowanie jest dostarczane "takim, jakie jest", bez jakiejkolwiek gwarancji,
'wyraźnej lub dorozumianej. W żadnym wypadku autorzy ani posiadacze praw autorskich nie ponoszą
'odpowiedzialności za jakiekolwiek roszczenia, szkody lub inne zobowiązania, czy to wynikające
'z umowy, czynu niedozwolonego czy w inny sposób, powstałe w związku z oprogramowaniem lub
'korzystaniem z niego.
'
'Pobieranie i użytkowanie programu jest dobrowolne i odbywa się na wyłączną odpowiedzialność użytkownika.
'
'Kod źródłowy dostępny pod adresem: https://github.com/excelsolutions/PDF-to-FTP
'
'Program korzysta z biblioteki PdfPig (UglyToad.PdfPig) dostępnej na licencji Apache 2.0.
'Strona projektu: https://github.com/UglyToad/PdfPig
'Zastąpiono iTextSharp biblioteką PdfPig (Apache 2.0)

Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Form_Main
    Public Licznik As Long = 0
    'Zmienne do automatyzacji:
    Public Auto_Start_Time As String
    Public Auto_Ilosc_Cykli As Long = 0
    Public Auto_Ilosc_Zapisanych As Long = 0
    Public Auto_Ilosc_Error As Long = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Aktualizacja_Statusow(True)
        If IsConnectedToInternet() = False Then
            ToolStripError.Text = "No internet connection. Check again later"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
            Timer_PIC.Enabled = True
            Exit Sub
        Else
            ToolStripError.Text = "ok"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Green
            Aktualizacja_Statusow(True)
        End If

        If L_LIczba_Plikow.Text > 0 Then
            If Directory.Exists(Folder_PDF) And Stan_Folderow_Lokalnych = True And L_LIczba_Plikow.Text > 0 Then
                ToolStripError.Text = "ok"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Green
                Timer_PIC.Enabled = False
                Form_Operacje.Show()
                Me.Hide()
                Form_Operacje.Lista_Operacji.Items.Clear()
                Form_Operacje.Text = "File processing..."
                Try
                    Przetworz_Pliki2(True, True, False, True)
                Catch ex As Exception
                    Try
                        Zapisz_Log_Txt(ex.Message)
                    Catch ex1 As Exception
                    End Try

                    ToolStripError.Text = "Error while file processing. Please contact with the programmer."
                    ToolStripError.ToolTipText = ToolStripError.Text
                    ToolStripError.ForeColor = Color.Red
                End Try

            ElseIf Not Directory.Exists(Folder_PDF) Then
                Timer_PIC.Enabled = True
                ToolStripError.Text = "Selected directory doesn't exist. Please check path to folder with pdf files"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
                Exit Sub
            Else
                ToolStripError.Text = "Selected FTP location or the location of PDF or FTP files was not indicated or was indicated incorrectly. Please check the settings or check again in a few seconds"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 2 * BorderWidth
        Inicjacja_INI() 'Na wypadek braku pliki Preferences.ini
        Aktualizacja_Programu_Nowe_INI() 'Aktualizacja pliku INI o nowy jeśli ten istnieje
        WCZYTAJ_USTAWIENIA_INI()
        'Wczytanie ustawień
        'UStawienia TooTipText
        ToolTip1.SetToolTip(L_LIczba_Plikow, "Count of found '.pdf' files. Click to view the list of found files with detected reference numbers.")
        ToolTip1.SetToolTip(LL_Ilosc_plikow, "Count of found '.pdf' files. Click to view the list of found files with detected reference numbers.")
        ToolTip1.SetToolTip(Btn_Start, "Send the found files to the server")

        Me.Height = TitlebarHeight + BorderWidth * 2 + GroupBox1.Height + MenuStrip1.Height + StatusStrip1.Height
        'Me.Width = Group_FTP.Left
        Aktualizacja_Statusow(True) 'kolorki, stan ftp itp

        ' Usunięto wywołanie Sprawdz_Aktualizacje()

        If IsNumeric(CLng(Interval)) And CLng(Interval) > 0 Then
            Timer_Automat.Interval = CLng(Interval) * 1000
        End If

        If Automation = True Then
            Timer_Automat.Enabled = True
            ToolStripAutomation.Image = My.Resources.Green_Button
        End If
        'Włączenie aktualizacji ilosci plikow
        Timer_Checker.Enabled = True
    End Sub

    Private Sub Btn_Ustawienia_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub

    Private Sub ToolStripMenuOtworz_Click(sender As Object, e As EventArgs) Handles ToolStripMenuOtworz.Click
    End Sub

    Private Sub ToolStripMenuPrzeslij_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPrzeslij.Click
        If Not Directory.Exists(Folder_PDF) Then
            ToolStripError.Text = "Indicated directory with pdf files doesn't exist. Please select correct directory"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
            Exit Sub
        Else 'Jeśli folder istnieje - uruchom aplikacje
            ToolStripError.Text = "ok"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Green
            Form_Operacje.Show()
            If Work_On_Copies = True Then
                Przetworz_Pliki2(True, True, True, True)
            Else
                Przetworz_Pliki2(True, True, False, True)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuZamknij_Click(sender As Object, e As EventArgs) Handles ToolStripMenuZamknij.Click
        Me.Dispose()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
    End Sub

    Private Sub Timer_Checker_Tick(sender As Object, e As EventArgs) Handles Timer_Checker.Tick
        Dim i As Integer = 0
        Dim Folder As String = Folder_PDF
        If Folder <> "" Then
            Try
                For Each Plik As String In My.Computer.FileSystem.GetFiles(Folder)
                    If UCase(Mid(Plik, Plik.Length - 3, 4)) = UCase(".pdf") Then
                        i = i + 1
                    End If
                Next
            Catch ex As Exception
                Try
                    Zapisz_Log_Txt(ex.Message)
                Catch ex1 As Exception
                End Try
                My.Forms.Form_Main.L_LIczba_Plikow.Text = 0
            End Try
        End If
        My.Forms.Form_Main.L_LIczba_Plikow.Text = i
    End Sub

    Private Sub L_LIczba_Plikow_Click(sender As Object, e As EventArgs) Handles L_LIczba_Plikow.Click
        Aktualizacja_Statusow(True)
        Try
            ToolStripError.Text = "ok"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Green
            Aktualizacja_Statusow(True)
            Form_Operacje.Show()
            Form_Operacje.Lista_Operacji.Items.Clear()
            If Stan_Folderow_Lokalnych = True Then
                Przetworz_Pliki2(False, False, False, True) 'TEST algorytmu w wersji 2.0
            End If
            If Stan_Folderow_Lokalnych = True Then
                Timer_PIC.Enabled = False
            Else
                Timer_PIC.Enabled = True
            End If
        Catch ex As Exception
            Try
                Zapisz_Log_Txt(ex.Message)
            Catch ex1 As Exception
            End Try
            ToolStripError.Text = "Unable to show list of the files. Please contact with the programmer"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub OProgramieToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OProgramieToolStripMenuItem1.Click
        Form_O_Mnie.Show()
    End Sub

    Private Sub UstawieniaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UstawieniaToolStripMenuItem1.Click
        Me.Hide()
        Form_Ustawienia.Show()
    End Sub

    Private Sub WyjścieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WyjścieToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub Timer_PIC_Tick(sender As Object, e As EventArgs) Handles Timer_PIC.Tick
    End Sub

    Private Sub LicencjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicencjaToolStripMenuItem.Click
        Form_Licencja.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            Aktualizacja_Statusow(True)
            If Stan_Folderow_Lokalnych = True And L_LIczba_Plikow.Text > 0 Then
                ToolStripError.Text = ""
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Green
                Form_Operacje.Show()
                Form_Operacje.Lista_Operacji.Items.Clear()
                If Work_On_Copies = True Then
                    Przetworz_Pliki2(False, True, True, True)
                Else
                    Przetworz_Pliki2(False, True, False, True)
                End If
            Else
                ToolStripError.Text = "No files inside indicated directory"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
            End If
            If Stan_Polaczenia_FTP = True Then
                Timer_PIC.Enabled = False
            Else
                Timer_PIC.Enabled = True
            End If
        Catch ex As Exception
            Try
                Zapisz_Log_Txt(ex.Message)
            Catch ex1 As Exception
            End Try
            ToolStripError.Text = "Unable to show list of files. Please contact with the programmer"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub LL_Ilosc_plikow_Click(sender As Object, e As EventArgs) Handles LL_Ilosc_plikow.Click
    End Sub

    Private Sub ToolStripAutomation_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripAutomation.ButtonClick
        If Timer_Automat.Enabled = False And Interval > 0 Then
            Timer_Automat.Enabled = True
            ToolStripAutomation.Image = My.Resources.Green_Button
        Else
            Timer_Automat.Enabled = False
            ToolStripAutomation.Image = My.Resources.Red_Button
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub Timer_Automat_Tick(sender As Object, e As EventArgs) Handles Timer_Automat.Tick
        Licznik = Licznik + 1
        Try
            'STATYSTYKI
            If Licznik = 1 Then
                Auto_Start_Time = DateTime.Now
            End If
            Auto_Ilosc_Cykli = Licznik
            Form_Ustawienia.T_Czas_Startu_Automatu.Text = Auto_Start_Time
            Form_Ustawienia.T_Liczba_Cykli.Text = Auto_Ilosc_Cykli
            Form_Ustawienia.T_Liczba_Bledow.Text = Auto_Ilosc_Error
            Form_Ustawienia.T_Liczba_Zmienionych_Plikow.Text = Auto_Ilosc_Zapisanych

            L_Count_Loops.Text = Auto_Ilosc_Cykli
            L_Count_Files.Text = Auto_Ilosc_Zapisanych
            L_Current_Interval.Text = Timer_Automat.Interval / 1000 & " s"

            Aktualizacja_Statusow(True)

            If Stan_Folderow_Lokalnych = True And L_LIczba_Plikow.Text > 0 Then
                ToolStripError.Text = ""
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Green
                Form_Operacje.Lista_Operacji.Items.Clear()
                If Automation = 0 Then
                    If Work_On_Copies = True Then
                        Przetworz_Pliki2(False, True, True, True)
                    Else
                        Przetworz_Pliki2(False, True, False, True)
                    End If
                Else
                    If Work_On_Copies = True Then
                        Przetworz_Pliki2(True, True, True, True)
                    Else
                        Przetworz_Pliki2(True, True, False, True)
                    End If
                End If
            Else
                If Automation = 0 Then
                    ToolStripError.Text = "No files inside indicated directory"
                End If
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
            End If
            If Stan_Polaczenia_FTP = True Then
                Timer_PIC.Enabled = False
            Else
                Timer_PIC.Enabled = True
            End If
        Catch ex As Exception
            Try
                Zapisz_Log_Txt(ex.Message)
            Catch ex1 As Exception
            End Try

            ToolStripError.Text = "Unable to show list of files. Please contact with the programmer"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub ToolStripError_Click(sender As Object, e As EventArgs) Handles ToolStripError.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub

    Private Sub ToolStripHide_Click(sender As Object, e As EventArgs) Handles ToolStripHide.Click
        If MsgBox("This option will minimize program to system tray. You can turn off program only from task manager. Continue?", vbYesNo, "Hide program") = vbYes Then
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripDisableRefreshing.Click
        If ToolStripDisableRefreshing.BorderStyle = Border3DStyle.Raised Then
            ToolStripDisableRefreshing.BorderStyle = Border3DStyle.Sunken
            ToolStripDisableRefreshing.Text = "Check Off"
            ToolStripDisableRefreshing.BackColor = Color.Red
        Else
            ToolStripDisableRefreshing.BorderStyle = Border3DStyle.Raised
            ToolStripDisableRefreshing.Text = "Check On"
            ToolStripDisableRefreshing.BackColor = ToolStripHide.BackColor
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pic_Lista.Click
        Aktualizacja_Statusow(True)
        Try
            ToolStripError.Text = "ok"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Green
            Aktualizacja_Statusow(True)
            Form_Operacje.Show()
            Form_Operacje.Lista_Operacji.Items.Clear()
            If Stan_Folderow_Lokalnych = True Then
                Przetworz_Pliki2(False, False, False, True)
            End If
            If Stan_Folderow_Lokalnych = True Then
                Timer_PIC.Enabled = False
            Else
                Timer_PIC.Enabled = True
            End If
        Catch ex As Exception
            Try
                Zapisz_Log_Txt(ex.Message)
            Catch ex1 As Exception
            End Try
            ToolStripError.Text = "Unable to show list of the files. Please contact with the programmer"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Btn_Wyslij_FTP_Click(sender As Object, e As EventArgs)
        Aktualizacja_Statusow(True)
        If IsConnectedToInternet() = False Then
            ToolStripError.Text = "No internet connection. Check again later"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Red
            Timer_PIC.Enabled = True
            Exit Sub
        Else
            ToolStripError.Text = "ok"
            ToolStripError.ToolTipText = ToolStripError.Text
            ToolStripError.ForeColor = Color.Green
            Aktualizacja_Statusow(True)
        End If
        If L_LIczba_Plikow.Text > 0 Then
            If Directory.Exists(Folder_PDF) And Stan_Folderow_Lokalnych = True And L_LIczba_Plikow.Text > 0 Then
                ToolStripError.Text = "ok"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Green
                Timer_PIC.Enabled = False
                Form_Operacje.Show()
                Me.Hide()
                Form_Operacje.Lista_Operacji.Items.Clear()
                Form_Operacje.Text = "File processing..."
                Try
                    Przetworz_Pliki2(True, True, False, True)
                Catch ex As Exception
                    Try
                        Zapisz_Log_Txt(ex.Message)
                    Catch ex1 As Exception
                    End Try

                    ToolStripError.Text = "Error while file processing. Please contact with the programmer."
                    ToolStripError.ToolTipText = ToolStripError.Text
                    ToolStripError.ForeColor = Color.Red
                End Try

            ElseIf Not Directory.Exists(Folder_PDF) Then
                Timer_PIC.Enabled = True
                ToolStripError.Text = "Selected directory doesn't exist. Please check path to folder with pdf files"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
                Exit Sub
            Else
                ToolStripError.Text = "Selected FTP location or the location of PDF or FTP files was not indicated or was indicated incorrectly. Please check the settings or check again in a few seconds"
                ToolStripError.ToolTipText = ToolStripError.Text
                ToolStripError.ForeColor = Color.Red
            End If
        End If
    End Sub

    Public Sub Sprawdz_FTP()
        Try
            If Ftp_Exist() Then
                MsgBox("FTP: " & Folder_FTP & " ,dla loginu: " & Login_FTP & " działa poprawnie.", vbOKOnly + vbInformation, "Poprawnie")
            Else
                MsgBox("FTP: " & Folder_FTP & " ,dla loginu: " & Login_FTP & " działa niepoprawnie!.", vbOKOnly + vbExclamation, "Błąd!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ĄczenieFTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĄczenieFTPToolStripMenuItem.Click
        Sprawdz_FTP()
    End Sub

    Public Function Ftp_Exist() As Boolean
        Ftp_Exist = False
        If Folder_FTP <> "" Then
            Dim request = DirectCast(WebRequest.Create(Folder_FTP), FtpWebRequest)
            request.Credentials = New NetworkCredential(Login_FTP, Haslo_FTP)
            request.Method = WebRequestMethods.Ftp.ListDirectory
            Try
                Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                    Ftp_Exist = True
                End Using
            Catch ex As WebException
                Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
                If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                    Ftp_Exist = False
                End If
            End Try
        Else
            Ftp_Exist = False
        End If
    End Function

    Private Sub ToolStripStatusLabel2_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Form_Instrukcja.Show()
    End Sub
End Class