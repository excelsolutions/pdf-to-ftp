'Program PDF-to-FTP
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

Imports UglyToad.PdfPig
Imports UglyToad.PdfPig.Content
Imports UglyToad.PdfPig.Writer
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading

Module Module1
    Public Licznik As Integer = 0
    Public Iter As Long = 0
    Public Zapisz_Log As Boolean = True
    Public Stan_FTP As Boolean = False
    Public Strony_Pliku() As Integer 'przechowuje numery stron, które spełniaja wymagania
    Public Tresc_Strony() As String 'przechowuje tekst stron, które spełniaja wymagania
    Public Dystans As Integer = 0 'Zmienna do odroczenia w czasie wykonywania sprawdzenia ftp
    Public Stan_Internetu As String

    Public Polaczenia_FTP As String
    Public Folderow_Lokalnych As String
    Public Folderow_Z_Kopiami As String
    Public Stan_Polaczenia_FTP As Boolean
    Public Stan_Folderow_Lokalnych As Boolean
    Public Stan_Folderow_Z_Kopiami As Boolean

    ' Funkcja sprawdzająca czy plik ma strukturę PDF przed próbą parsowania
    Public Function IsProbablyPdf(path As String) As Boolean
        Try
            If Not File.Exists(path) Then Return False
            Dim fi As New FileInfo(path)
            If fi.Length < 20 Then Return False
            Using fs As New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim buf(1023) As Byte
                Dim read = fs.Read(buf, 0, Math.Min(buf.Length, CInt(fs.Length)))
                Dim header = System.Text.Encoding.ASCII.GetString(buf, 0, Math.Min(8, read))
                If header.StartsWith("%PDF-") Then
                    ' opcjonalnie sprawdź czy w końcówce jest "startxref"
                    fs.Seek(Math.Max(0, fs.Length - 2048), SeekOrigin.Begin)
                    Dim tailBuf(2047) As Byte
                    Dim tailRead = fs.Read(tailBuf, 0, Math.Min(tailBuf.Length, CInt(fs.Length)))
                    Dim tail = System.Text.Encoding.ASCII.GetString(tailBuf, 0, tailRead)
                    Return tail.Contains("startxref") Or tail.Contains("xref")
                End If
            End Using
        Catch ex As Exception
            ' nic — zwrócimy false
        End Try
        Return False
    End Function

    ' Zastąpiona funkcja parsująca tekst przy użyciu PdfPig
    Public Function ParsePdfText2(PdfFileName As String, Calosc As Boolean) As String
        Dim sOut As String = ""
        Dim Licznik As Integer = 0
        ReDim Strony_Pliku(0) 'zerowanie zmiennej
        ReDim Tresc_Strony(0) 'zerowanie zmiennej

        ' Dodatkowa walidacja pliku przed parsowaniem
        If Not IsProbablyPdf(PdfFileName) Then
            Zapisz_Log_Txt($"Skipping file {PdfFileName} - File header/trailer validation failed (not a valid PDF structure).")
            Return ""
        End If

        Try
            ' ZMIANA: Dodano ParsingOptions z UseLenientParsing = True, aby obsłużyć uszkodzone pliki PDF
            Dim openOptions As New ParsingOptions() With {.UseLenientParsing = True}

            Using pdf As PdfDocument = PdfDocument.Open(PdfFileName, openOptions)
                For i As Integer = 1 To pdf.NumberOfPages
                    Dim pageText As String = ""

                    ' Jeśli potrzebujemy tekstu, pobierz go
                    ' PdfPig czasami może rzucać błędy przy uszkodzonych fontach, więc warto to zabezpieczyć
                    Try
                        pageText = pdf.GetPage(i).Text
                    Catch ex As Exception
                        pageText = ""
                    End Try

                    If Calosc = False Then
                        If Whole_File = "0" Then 'bierz poszczególne strony
                            If Half_or_Specific = 0 Then 'bierz połowę stron
                                If pdf.NumberOfPages > 1 Then 'dziel jeśli stron jest więcej niz 1!
                                    If First_Last_Pages = 0 Then 'bierz 1 połowe pliku. 
                                        If i <= Math.Round(pdf.NumberOfPages / 2, 0) Then
                                            ReDim Preserve Tresc_Strony(Licznik)
                                            Tresc_Strony(Licznik) = pageText
                                            sOut &= Tresc_Strony(Licznik)
                                            ReDim Preserve Strony_Pliku(Licznik)
                                            Strony_Pliku(Licznik) = i
                                            Licznik = Licznik + 1
                                        End If

                                    ElseIf First_Last_Pages = 1 Then 'bierz drugą połowe pliku
                                        If i > Math.Round(pdf.NumberOfPages / 2, 0) Then
                                            ReDim Preserve Tresc_Strony(Licznik)
                                            Tresc_Strony(Licznik) = pageText
                                            sOut &= Tresc_Strony(Licznik)
                                            ReDim Preserve Strony_Pliku(Licznik)
                                            Strony_Pliku(Licznik) = i
                                            Licznik = Licznik + 1
                                        End If
                                    End If
                                Else 'jesli jest 1 strona- bierz cały plik
                                    ReDim Preserve Tresc_Strony(Licznik)
                                    Tresc_Strony(Licznik) = pageText
                                    sOut &= Tresc_Strony(Licznik)
                                    ReDim Preserve Strony_Pliku(Licznik)
                                    Strony_Pliku(Licznik) = i
                                    Licznik = Licznik + 1
                                End If

                            Else 'bierz poszczególne strony wg słów kluczowych
                                If Contain_Text <> "" Then
                                    If Contain_Word = 0 Then 'bierz strony, które NIE zawieraja danego tekstu
                                        If Not pageText.Contains(Contain_Text) Then
                                            ReDim Preserve Tresc_Strony(Licznik)
                                            Tresc_Strony(Licznik) = pageText
                                            sOut &= Tresc_Strony(Licznik)
                                            ReDim Preserve Strony_Pliku(Licznik)
                                            Strony_Pliku(Licznik) = i
                                            Licznik = Licznik + 1
                                        End If

                                    ElseIf Contain_Word = 1 Then 'bierz strony, które ZAWIERAJĄ dany text
                                        If pageText.Contains(Contain_Text) Then
                                            ReDim Preserve Tresc_Strony(Licznik)
                                            Tresc_Strony(Licznik) = pageText
                                            sOut &= Tresc_Strony(Licznik)
                                            ReDim Preserve Strony_Pliku(Licznik)
                                            Strony_Pliku(Licznik) = i
                                            Licznik = Licznik + 1
                                        End If
                                    End If
                                End If
                            End If

                        Else 'bierz cały plik
                            ReDim Preserve Tresc_Strony(Licznik)
                            Tresc_Strony(Licznik) = pageText
                            sOut &= Tresc_Strony(Licznik)
                            ReDim Preserve Strony_Pliku(Licznik)
                            Strony_Pliku(Licznik) = i
                            Licznik = Licznik + 1
                        End If
                    Else
                        ' Jeśli Calosc = True (np. tylko do odczytu numeru WZ)
                        ReDim Preserve Tresc_Strony(Licznik)
                        Tresc_Strony(Licznik) = pageText
                        sOut &= Tresc_Strony(Licznik)
                        ReDim Preserve Strony_Pliku(Licznik)
                        Strony_Pliku(Licznik) = i
                        Licznik = Licznik + 1
                    End If
                Next
            End Using
        Catch ex As Exception
            ' Rozszerzone logowanie błędów
            Dim fileDetails As String = ""
            Try
                Dim fi As New FileInfo(PdfFileName)
                fileDetails = $"Size: {fi.Length} bytes, Created: {fi.CreationTime}"
            Catch
            End Try

            Zapisz_Log_Txt($"CRITICAL ERROR parsing {PdfFileName} [{fileDetails}]. Exception: {ex.ToString()}")
            Return ""
        End Try

        Return sOut
    End Function

    Public Sub Aktualizacja_Statusow(Sprawdzanie_Stanu As Boolean)
        Dim i As Int16 = 0

        If My.Forms.Form_Main.ToolStripDisableRefreshing.Text.Contains("On") Then
            Sprawdzanie_Stanu = True
            Dystans = Dystans + 1
            If Dystans >= 5 Then
                Dim thread As New Thread(AddressOf Ftp_Istnieje)
                thread.Start() 'WYSTARTOWANIE OSOBNEGO WĄTKU
                Dystans = 0
            End If
        Else
            Sprawdzanie_Stanu = False
        End If

        If Sprawdzanie_Stanu = True Then
            Try
                If IsConnectedToInternet() = False Then
                    Stan_Internetu = "No internet connection"
                    My.Forms.Form_Main.Timer_PIC.Enabled = True
                    Exit Try
                End If
                Stan_FTP = True
            Catch ex As Exception
                Try
                    Zapisz_Log_Txt(ex.Message)
                Catch ex1 As Exception
                End Try

                If Check_FTP = True Then
                    Polaczenia_FTP = "Error connection with FTP: " & Folder_FTP
                    Stan_Polaczenia_FTP = False
                    My.Forms.Form_Main.Timer_PIC.Enabled = True
                End If
            End Try

            'SOURCE FOLDER - sprawdzenie
            Try
                If Directory.Exists(Folder_PDF) Then
                    Folderow_Lokalnych = "The indicated path to the PDF files is correct."
                    Stan_Folderow_Lokalnych = True
                Else
                    Folderow_Lokalnych = "The indicated path to the PDF files is not correct."
                    Stan_Folderow_Lokalnych = False
                End If
            Catch ex As Exception
                Try
                    Zapisz_Log_Txt(ex.Message)
                Catch ex1 As Exception
                End Try
                Folderow_Lokalnych = "The indicated path to the PDF files is not correct or another unidentified error occurred."
                Stan_Folderow_Lokalnych = False
            End Try

            'DESTINATION FOLDER - sprawdzenie
            If Work_On_Copies = True Then
                Try
                    If Directory.Exists(Folder_Dest) Then
                        Folderow_Z_Kopiami = "The indicated path to the destination folder is correct."
                        Stan_Folderow_Z_Kopiami = True
                    Else
                        Folderow_Z_Kopiami = "The indicated path to the destination folder is not correct."
                        Stan_Folderow_Z_Kopiami = False
                    End If
                Catch ex As Exception
                    Try
                        Zapisz_Log_Txt(ex.Message)
                    Catch ex1 As Exception
                    End Try
                    Folderow_Z_Kopiami = "The indicated path to the destination folder is not correct or another unidentified error occurred."
                    Stan_Folderow_Z_Kopiami = False
                End Try
            End If
        End If

        'Poniższa część wykonuje sie stale, nieustannie
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

    Public Function Ftp_Exist(Sciezka_FTP As String) As Boolean
        Ftp_Exist = False
        'WYŁĄCZENIE SPRAWDZANIA FTP
        ' If 0 = 1 Then
        If Sciezka_FTP <> "" Then
            Dim request = DirectCast(WebRequest.Create(Sciezka_FTP), FtpWebRequest)
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

    Public Sub Ftp_Istnieje()
        If 0 = 1 Then ' Wyłączone wg oryginału
            If Folder_FTP <> "" Then
                Dim request = DirectCast(WebRequest.Create(Folder_FTP), FtpWebRequest)
                request.Credentials = New NetworkCredential(Login_FTP, Haslo_FTP)
                request.Method = WebRequestMethods.Ftp.ListDirectory

                Try
                    Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
                        Stan_FTP = True
                    End Using
                Catch ex As WebException
                    Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
                    If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                        Stan_FTP = False
                    End If
                End Try
            Else
                Stan_FTP = False
            End If
        End If
    End Sub

    Public Sub PDF_FTP()
    End Sub

    Public Sub Przetworz_Pliki2(Wysyłka_Na_FTP As Boolean, Zmiana_Nazwy As Boolean, Inna_Lokalizacja As Boolean, Logowanie As Boolean)
        'Wysyłka_Na_FTP- czy ma wysyłać na FTP, Zmiana_Nazwy- jesli false to zapewne przetwórz dla samego zliczenia
        Dim Wiersz(5) As String
        Dim Referencja As String = ""
        Dim itm As ListViewItem
        Dim i As Integer = 0
        Dim Ilosc_OK As Int16 = 0
        Dim Ilosc_NOK As Int16 = 0
        Dim Ilosc_OK1 As Int16 = 0
        Dim Ilosc_NOK1 As Int16 = 0
        Dim Nowa_Nazwa As String = ""
        Dim Tresc_Pliku As String = ""
        Dim Blokujacy As String = ""
        Dim Start As Long = 0
        Dim Dlugosc As Long = 0
        Dim Zabezpieczenie As Integer = 0
        Dim Znaleziono_Nr As Boolean = False
        Dim Licznik As Integer = 0
        Dim Numer As Integer = 1
        Dim Licznik_Blednych As Integer = 0
        Dim Nazwa_Pliku_Blednego As String = "Nierozpoznany_"

        For Each Plik As String In My.Computer.FileSystem.GetFiles(Folder_PDF) 'Sprawdź każdy plik w folderze
            If UCase(Mid(Plik, Plik.Length - 3, 4)) = UCase(".pdf") Then 'jesli rozszerzenie pliku to "pdf" to bierz plik do obrobki
                Tresc_Pliku = ParsePdfText2(Plik, True)
                Znaleziono_Nr = False
                i = i + 1
                Numer = 1
                Wiersz(0) = i
                Wiersz(1) = System.IO.Path.GetFileName(Plik)
                Referencja = Wytnij_String(Tresc_Pliku)

                If Referencja <> "" Then
                    Wiersz(3) = Napraw_String(Prefix & "_" & Numer & "_" & Referencja & Suffix & ".pdf") 'Nazwa pliku
                    Do While Czy_WZ_Jest_Dublem(3, Wiersz(3)) = True
                        Numer = Numer + 1
                        Wiersz(3) = Napraw_String(Prefix & "_" & Numer & "_" & Referencja & Suffix & ".pdf")
                    Loop
                    Znaleziono_Nr = True
                Else
                    Referencja = System.IO.Path.GetFileName(Plik)
                    Wiersz(3) = Referencja
                    Znaleziono_Nr = False
                End If
                Wiersz(2) = Napraw_String(Referencja)

                ' Ponowne wywołanie, aby pobrać tylko odpowiednie strony/treść
                Tresc_Pliku = ParsePdfText2(Plik, False)

                If Allow_Duplicates = 1 Or Czy_WZ_Jest_Dublem(2, Wiersz(2)) = False Then

#Region "Wysyłka na FTP"
                    If Wysyłka_Na_FTP = True And Stan_FTP = True Then
                        Dim remoteLOC As String = Folder_FTP & Wiersz(3)
                        Try
                            Dim info As New FileInfo(Plik)
                            If Sprawdz_PDF(Plik, Znaleziono_Nr) = True And FilenameIsOK(Wiersz(3)) Then
                                If Whole_File = 0 Then
                                    If IsFileOpen(info) Then
                                        If Not File.Exists(Folder_PDF & "Temporary_File" & i & ".pdf") Then
                                            Extract_Specific_Pages(Plik, Folder_PDF & "Temporary_File" & i & ".pdf", Strony_Pliku)
                                            Send_To_FTP_SFTP(Folder_Dest & "Temporary_File" & i & ".pdf", Wiersz(3), Folder_FTP, Login_FTP, Haslo_FTP, SFTP)
                                            My.Computer.FileSystem.DeleteFile(Folder_PDF & "Temporary_File" & i & ".pdf")
                                            Wiersz(4) = "File is locked"
                                            Wiersz(5) = "OK"
                                            Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                        Else
                                            Wiersz(5) = "NOK"
                                            Nowa_Nazwa = System.IO.Path.GetFileName(Plik)
                                            Wiersz(3) = "Unable to save copy of pdf file. File not send to FTP."
                                            Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                        End If
                                    Else
                                        Extract_Specific_Pages(Plik, Folder_PDF & "Temporary_File" & i & ".pdf", Strony_Pliku)
                                        Send_To_FTP_SFTP(Folder_PDF & "Temporary_File" & i & ".pdf", Wiersz(3), Folder_FTP, Login_FTP, Haslo_FTP, SFTP)
                                        My.Computer.FileSystem.DeleteFile(Plik)
                                        My.Computer.FileSystem.DeleteFile(Folder_PDF & "Temporary_File" & i & ".pdf")
                                        Wiersz(4) = "OK"
                                        Wiersz(5) = "OK"
                                        Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                    End If
                                Else
                                    Send_To_FTP_SFTP(Plik, Wiersz(3), Folder_FTP, Login_FTP, Haslo_FTP, SFTP)
                                    If Not IsFileOpen(info) Then
                                        My.Computer.FileSystem.DeleteFile(Plik)
                                    End If
                                    Wiersz(4) = "OK"
                                    Wiersz(5) = "OK"
                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                End If

                            Else
                                Wiersz(5) = "NOK"
                                Nowa_Nazwa = System.IO.Path.GetFileName(Plik)
                                Wiersz(3) = "Incorrect delivery note number inside PDF file"
                                My.Computer.FileSystem.WriteAllText(Folder_PDF & Nowa_Nazwa & ".txt", "Plik PDF nie został wysłany. Struktura pliku odbiega od ustawionego wzorca. Problem z odczytem numeru referencyjnego. " & vbCrLf &
                                "Odczytana referencja: " & Referencja & vbCrLf &
                                "Nazwa pliku: " & Wiersz(3) & vbCrLf &
                                "Treść pliku PDF: " & vbCrLf &
                                Tresc_Pliku, False)
                                Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                            End If

                        Catch ex As Exception
                            Try
                                Zapisz_Log_Txt(ex.Message)
                                My.Computer.FileSystem.WriteAllText(Folder_PDF & Wiersz(1) & ".txt", "Plik PDF nie został wysłany. " & vbCrLf &
                            "Odczytana referencja: " & Referencja & vbCrLf &
                            "Nazwa pliku: " & Wiersz(3) & vbCrLf &
                            "Treść pliku PDF: " & vbCrLf &
                            ParsePdfText2(Plik, False), False)
                                Wiersz(5) = "NOK"
                                Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                            Catch ex1 As Exception
                                Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                            End Try
                        End Try
#End Region

#Region "Zapis plików"
                    Else 'Jeśli wybraliśmy BEZ WYSYŁANIA plików na serwer
                        Try
                            Dim info As New FileInfo(Plik)
                            If IsFileOpen(info) Then
                                Dim LockedFileProcesses = WhoIsLocking(Plik)
                                If LockedFileProcesses.Count > 0 Then
                                    For Each Item In LockedFileProcesses
                                        Blokujacy = Blokujacy & "; " & Item.ProcessName.ToString
                                    Next
                                End If
                                Wiersz(3) = "File is locked by: " & Blokujacy
                                Wiersz(4) = "NOK"
                                Wiersz(5) = "NOK"
                                Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                Nowa_Nazwa = Plik
                                Exit Try
                            End If

                            If System.IO.Path.GetFileName(Plik) <> Wiersz(3) Then
                                If Sprawdz_PDF(Plik, Znaleziono_Nr) = True And FilenameIsOK(Wiersz(3)) Then
                                    If Strony_Pliku.Length = 1 And Strony_Pliku(0) = 0 Then
                                        Wiersz(3) = "No matching pages found."
                                        Wiersz(4) = "NOK"
                                        Wiersz(5) = "NOK"
                                        Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                        Nowa_Nazwa = Plik
                                        Exit Try
                                    End If

                                    If Zmiana_Nazwy = True Then
                                        If Inna_Lokalizacja = False Then
                                            If Not File.Exists(Folder_PDF & Wiersz(3)) Then
                                                If Whole_File = 0 Then
                                                    If Group_Pages = 1 Then
                                                        If FilenameIsOK(Folder_PDF) Then
                                                            Extract_Specific_Pages(Plik, Folder_PDF & Wiersz(3), Strony_Pliku)
                                                        Else
                                                            Licznik_Blednych = Licznik_Blednych + 1
                                                            Extract_Specific_Pages(Plik, Nazwa_Pliku_Blednego & Licznik_Blednych, Strony_Pliku)
                                                        End If
                                                    ElseIf Group_Pages = 0 Then
                                                        ' Dla stron, które nie mają być zgrupowane
                                                        Dim Strona(0) As Integer
                                                        Dim Stron_Ilosc As Integer = 0
                                                        Licznik = 0
                                                        For Each pageNumber As Integer In Strony_Pliku
                                                            Referencja = Wytnij_String(Tresc_Strony(Licznik))
                                                            If Licznik > 1 Then
                                                                If Referencja = Wytnij_String(Tresc_Strony(Licznik - 1)) Then
                                                                    Stron_Ilosc = Stron_Ilosc + 1
                                                                    ReDim Preserve Strona(Stron_Ilosc)
                                                                    Strona(Stron_Ilosc) = pageNumber
                                                                    If FilenameIsOK(Referencja) Then
                                                                        Extract_Specific_Pages(Plik, Folder_PDF & Referencja & ".pdf", Strona)
                                                                    Else
                                                                        Licznik_Blednych = Licznik_Blednych + 1
                                                                        Extract_Specific_Pages(Plik, Folder_PDF & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                    End If
                                                                Else
                                                                    ReDim Strona(0)
                                                                    Stron_Ilosc = 0
                                                                    Strona(Stron_Ilosc) = pageNumber
                                                                    If FilenameIsOK(Referencja) Then
                                                                        Extract_Specific_Pages(Plik, Folder_PDF & Referencja & ".pdf", Strona)
                                                                    Else
                                                                        Licznik_Blednych = Licznik_Blednych + 1
                                                                        Extract_Specific_Pages(Plik, Folder_PDF & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                    End If
                                                                End If
                                                            Else
                                                                ReDim Strona(0)
                                                                Stron_Ilosc = 0
                                                                Strona(Stron_Ilosc) = pageNumber
                                                                If FilenameIsOK(Referencja) Then
                                                                    Extract_Specific_Pages(Plik, Folder_PDF & Referencja & ".pdf", Strona)
                                                                Else
                                                                    Licznik_Blednych = Licznik_Blednych + 1
                                                                    Extract_Specific_Pages(Plik, Folder_PDF & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                End If
                                                            End If
                                                            Licznik = Licznik + 1
                                                        Next
                                                    Else
                                                        Extract_Specific_Pages(Plik, Folder_PDF & Wiersz(3), Strony_Pliku)
                                                    End If
                                                    My.Computer.FileSystem.DeleteFile(Plik)
                                                    Wiersz(4) = "renamed"
                                                    Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                Else
                                                    My.Computer.FileSystem.RenameFile(Plik, Wiersz(3))
                                                    Wiersz(4) = "renamed"
                                                    Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                End If
                                            Else
                                                ' Gdy plik już istnieje
                                                If Whole_File = 0 Then
                                                    Wiersz(4) = "OK"
                                                    Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                Else
                                                    Wiersz(4) = "OK"
                                                    Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                End If
                                            End If
                                        Else ' Inna_lokalizacja=true
                                            If Whole_File = 0 Then
                                                If Not File.Exists(Folder_Dest & Wiersz(3)) Then
                                                    If Group_Pages = 1 Then
                                                        Extract_Specific_Pages(Plik, Folder_Dest & Wiersz(3), Strony_Pliku)
                                                    ElseIf Group_Pages = 0 Then
                                                        ' Tutaj podobna logika pętli jak wyżej dla Group_Pages=0
                                                        Dim Strona(0) As Integer
                                                        Dim Stron_Ilosc As Integer = 0
                                                        Licznik = 0
                                                        For Each pageNumber As Integer In Strony_Pliku
                                                            Referencja = Wytnij_String(Tresc_Strony(Licznik))
                                                            If Licznik >= 1 Then
                                                                If Referencja = Wytnij_String(Tresc_Strony(Licznik - 1)) Then
                                                                    Stron_Ilosc = Stron_Ilosc + 1
                                                                    ReDim Preserve Strona(Stron_Ilosc)
                                                                    Strona(Stron_Ilosc) = pageNumber
                                                                    If FilenameIsOK(Referencja) Then
                                                                        Extract_Specific_Pages(Plik, Folder_Dest & Referencja & ".pdf", Strona)
                                                                    Else
                                                                        Licznik_Blednych = Licznik_Blednych + 1
                                                                        Extract_Specific_Pages(Plik, Folder_Dest & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                    End If
                                                                Else
                                                                    ReDim Strona(0)
                                                                    Stron_Ilosc = 0
                                                                    Strona(Stron_Ilosc) = pageNumber
                                                                    If FilenameIsOK(Referencja) Then
                                                                        Extract_Specific_Pages(Plik, Folder_Dest & Referencja & ".pdf", Strona)
                                                                    Else
                                                                        Licznik_Blednych = Licznik_Blednych + 1
                                                                        Extract_Specific_Pages(Plik, Folder_Dest & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                    End If
                                                                End If
                                                            Else
                                                                ReDim Strona(0)
                                                                Stron_Ilosc = 0
                                                                Strona(Stron_Ilosc) = pageNumber
                                                                If FilenameIsOK(Referencja) Then
                                                                    Extract_Specific_Pages(Plik, Folder_Dest & Referencja & ".pdf", Strona)
                                                                Else
                                                                    Licznik_Blednych = Licznik_Blednych + 1
                                                                    Extract_Specific_Pages(Plik, Folder_Dest & Nazwa_Pliku_Blednego & Licznik_Blednych & ".pdf", Strona)
                                                                End If
                                                            End If
                                                            Licznik = Licznik + 1
                                                        Next
                                                    Else
                                                        Extract_Specific_Pages(Plik, Folder_Dest & Wiersz(3), Strony_Pliku)
                                                    End If
                                                    Wiersz(4) = "moved & renamed pages"
                                                    Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                Else
                                                    Wiersz(4) = "FILE EXIST"
                                                    Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                End If
                                            Else
                                                If Not File.Exists(Folder_Dest & Wiersz(3)) Then
                                                    My.Computer.FileSystem.MoveFile(Plik, Folder_Dest & Wiersz(3))
                                                    Wiersz(4) = "moved & renamed"
                                                    Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                Else
                                                    My.Computer.FileSystem.DeleteFile(Plik)
                                                    Wiersz(4) = "FILE EXIST"
                                                    Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                                    Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                                End If
                                                Wiersz(5) = "NOK"
                                            End If
                                        End If
#End Region

#Region "Podgląd plików"
                                    Else 'do podglądu
                                        If Inna_Lokalizacja = False Then
                                            If Not File.Exists(Folder_PDF & Wiersz(3)) Then
                                                Nowa_Nazwa = Plik
                                                Wiersz(4) = "NOK"
                                            Else
                                                Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                                Wiersz(4) = "OK"
                                            End If
                                            Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                        Else
                                            If Not File.Exists(Folder_Dest & Wiersz(3)) Then
                                                Nowa_Nazwa = Plik
                                                Wiersz(4) = "NOK"
                                            Else
                                                Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                                Wiersz(4) = "OK"
                                            End If
                                        End If
                                    End If
                                Else
                                    Wiersz(3) = "Incorrect delivery note number inside PDF file"
                                    Wiersz(4) = "NOK"
                                    Wiersz(5) = "NOK"
                                    Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                End If
                                Wiersz(5) = "NOK"
                            Else
                                'Plik ma już poprawna nazwę
                                If Sprawdz_PDF(Plik, Znaleziono_Nr) = True And FilenameIsOK(Wiersz(3)) Then
                                    If Inna_Lokalizacja = False Then
                                        Nowa_Nazwa = Folder_PDF & Wiersz(3)
                                        Wiersz(4) = "OK"
                                        Wiersz(5) = "NOK"
                                        Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                    Else
                                        If File.Exists(Folder_Dest & Wiersz(3)) Then
                                            Wiersz(4) = "OK"
                                            Wiersz(5) = "NOK"
                                            Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                            Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                            If Not IsFileOpen(info) Then
                                                My.Computer.FileSystem.DeleteFile(Plik)
                                            Else
                                                Wiersz(4) = "OK"
                                                Wiersz(5) = "NOK"
                                            End If
                                        Else
                                            My.Computer.FileSystem.MoveFile(Plik, Folder_Dest & Wiersz(3))
                                            Wiersz(4) = "moved"
                                            Wiersz(5) = "NOK"
                                            Form_Main.Auto_Ilosc_Zapisanych = Form_Main.Auto_Ilosc_Zapisanych + 1
                                            Nowa_Nazwa = Folder_Dest & Wiersz(3)
                                        End If
                                    End If
                                Else
                                    Wiersz(3) = "Incorrect delivery note number inside PDF file"
                                    Wiersz(4) = "NOK"
                                    Wiersz(5) = "NOK"
                                    Form_Main.Auto_Ilosc_Error = Form_Main.Auto_Ilosc_Error + 1
                                    Nowa_Nazwa = Plik
                                End If
                            End If
                        Catch ex As Exception
                            Try
                                Nowa_Nazwa = Plik
                                Zapisz_Log_Txt(ex.Message)
                            Catch ex1 As Exception
                            End Try
                        End Try
                    End If
#End Region

                    If Logowanie = True Then
                        itm = New ListViewItem(Wiersz)
                        Form_Operacje.Lista_Operacji.Items.Add(itm)
                        If Wysyłka_Na_FTP = False Then
                            If Zmiana_Nazwy = True Then
                                itm.Tag = Nowa_Nazwa
                            Else
                                itm.Tag = Plik
                            End If
                        End If
                        'Kolorowanie wierszy...
                        If Wiersz(4) = "NOK" Then
                            If Zmiana_Nazwy = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(4).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK1 = Ilosc_NOK1 + 1
                        ElseIf Wiersz(4) = "OK" Or Wiersz(4) = "renamed" Or Wiersz(4) = "moved & renamed" Or Wiersz(4) = "moved" Or Wiersz(4) = "moved & renamed pages" Or Wiersz(4) = "FILE EXIST" Then
                            If Zmiana_Nazwy = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(4).BackColor = System.Drawing.Color.Lime
                            End If
                            Ilosc_OK1 = Ilosc_OK1 + 1
                        Else
                            If Zmiana_Nazwy = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(4).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK1 = Ilosc_NOK1 + 1
                        End If

                        If Wiersz(5) = "NOK" Then
                            If Wysyłka_Na_FTP = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(5).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK = Ilosc_NOK + 1
                        ElseIf Wiersz(5) = "OK" Then
                            If Wysyłka_Na_FTP = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(5).BackColor = System.Drawing.Color.Lime
                            End If
                            Ilosc_OK = Ilosc_OK + 1
                        Else
                            If Wysyłka_Na_FTP = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(5).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK = Ilosc_NOK + 1
                        End If
                    End If
                Else
                    ' DUBEL
                    Wiersz(3) = "Duplicate name. This file will not be processed."
                    Wiersz(4) = "NOK"
                    Wiersz(5) = "NOK"
                    If Logowanie = True Then
                        itm = New ListViewItem(Wiersz)
                        Form_Operacje.Lista_Operacji.Items.Add(itm)
                        itm.Tag = Plik
                        If Wiersz(4) = "NOK" Then
                            If Zmiana_Nazwy = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(4).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK1 = Ilosc_NOK1 + 1
                        End If
                        If Wiersz(5) = "NOK" Then
                            If Wysyłka_Na_FTP = True Then
                                itm.UseItemStyleForSubItems = False
                                itm.SubItems(5).BackColor = System.Drawing.Color.Red
                            End If
                            Ilosc_NOK = Ilosc_NOK + 1
                        End If
                    End If
                End If
            End If
        Next

        If Logowanie = True Then
            'Podsumowanie w ListView - kod bez zmian
            Wiersz(0) = "..........................................................................................................."
            Wiersz(1) = "..........................................................................................................."
            Wiersz(2) = "..........................................................................................................."
            Wiersz(3) = "..........................................................................................................."
            Wiersz(4) = "..........................................................................................................."
            Wiersz(5) = "..........................................................................................................."
            itm = New ListViewItem(Wiersz)
            Form_Operacje.Lista_Operacji.Items.Add(itm)

            Wiersz(0) = ""
            Wiersz(1) = ""
            Wiersz(2) = ""
            Wiersz(3) = "Summary"
            Wiersz(4) = ""
            Wiersz(5) = ""
            itm = New ListViewItem(Wiersz)
            Form_Operacje.Lista_Operacji.Items.Add(itm)

            Wiersz(0) = ""
            Wiersz(1) = ""
            Wiersz(2) = ""
            Wiersz(3) = "Count of successful transmissions:"
            Wiersz(4) = Ilosc_OK1
            Wiersz(5) = Ilosc_OK
            itm = New ListViewItem(Wiersz)
            Form_Operacje.Lista_Operacji.Items.Add(itm)
            itm.UseItemStyleForSubItems = False
            itm.SubItems(4).BackColor = System.Drawing.Color.Lime
            itm.SubItems(5).BackColor = System.Drawing.Color.Lime

            Wiersz(0) = ""
            Wiersz(1) = ""
            Wiersz(2) = ""
            Wiersz(3) = "Count of failed transmissions:"
            Wiersz(4) = Ilosc_NOK1
            Wiersz(5) = Ilosc_NOK
            itm = New ListViewItem(Wiersz)
            Form_Operacje.Lista_Operacji.Items.Add(itm)
            itm.UseItemStyleForSubItems = False
            itm.SubItems(4).BackColor = System.Drawing.Color.Red
            itm.SubItems(5).BackColor = System.Drawing.Color.Red
        End If
    End Sub

    Public Function Czy_WZ_Jest_Dublem(Kolumna_Z_Ciagami As Integer, Sprawdzany_Ciag As String) As Boolean
        Dim Licznik As Int16 = 0
        For i = 0 To Form_Operacje.Lista_Operacji.Items.Count - 1 Step 1
            If Form_Operacje.Lista_Operacji.Items(i).SubItems(Kolumna_Z_Ciagami).Text = Sprawdzany_Ciag Then
                Licznik = Licznik + 1
            End If
        Next
        If Licznik > 0 Then
            Czy_WZ_Jest_Dublem = True
        Else
            Czy_WZ_Jest_Dublem = False
        End If
    End Function

    Public Function Sprawdz_PDF(Sciezka_Do_Pliku As String, Znaleziono_Nr As Boolean) As Boolean
        If Checking_File = True Then
            Dim Text As String = ParsePdfText2(Sciezka_Do_Pliku, True)
            Dim Znaleziona_pozycja1 As Long = 0
            If Text <> "" And Klucz_Sec IsNot Nothing Then
                Znaleziona_pozycja1 = Text.IndexOf(Klucz_Sec, RichTextBoxFinds.MatchCase)
            Else
                Znaleziona_pozycja1 = -1
            End If
            If Klucz_Sec <> "" And Znaleziona_pozycja1 + Start_Pos_Sec > 0 Then
                If Mid(Text, Znaleziona_pozycja1 + Start_Pos_Sec, Lenght_Text_Sec) = Control_String Then
                    Sprawdz_PDF = True
                Else
                    Sprawdz_PDF = False
                End If
            Else
                If Start_Pos_Sec > 0 Then
                    If Mid(Text, Start_Pos_Sec, Lenght_Text_Sec) = Control_String Then
                        Sprawdz_PDF = True
                    Else
                        Sprawdz_PDF = False
                    End If
                Else
                    Sprawdz_PDF = False
                End If
            End If
        Else
            If Znaleziono_Nr = True Then
                Sprawdz_PDF = True
            Else
                Sprawdz_PDF = False
            End If
        End If
    End Function

    Public Function Wytnij_String(Tresc As String) As String
        Dim Pozycja_Startowa As Long = 0
        If Tresc <> "" Then
            If Klucz <> "" And Klucz <> String.Empty Then
                Pozycja_Startowa = InStr(Tresc, Klucz) - 1
            Else
                Pozycja_Startowa = 0
            End If
            If Start_Pos + Pozycja_Startowa > 0 And Pozycja_Startowa > -1 Then
                Try
                    Wytnij_String = Tresc.Substring(Start_Pos + Pozycja_Startowa - 1, Lenght_Text)
                Catch ex As Exception
                    Wytnij_String = ""
                End Try
            Else
                Wytnij_String = ""
            End If
        Else
            Wytnij_String = ""
        End If
    End Function

    Public Function Napraw_String(Tresc As String)
        Dim Poprawiany_String As String = Tresc
        Poprawiany_String = Replace(Poprawiany_String, vbLf, "")
        Poprawiany_String = Replace(Poprawiany_String, vbCr, "")
        Poprawiany_String = Replace(Poprawiany_String, vbCrLf, "")
        Poprawiany_String = Replace(Poprawiany_String, vbFormFeed, "")
        Poprawiany_String = Replace(Poprawiany_String, vbNewLine, "")
        Poprawiany_String = Replace(Poprawiany_String, vbTab, "")
        Napraw_String = Poprawiany_String
    End Function

    Function IsFileOpen(ByVal file As FileInfo) As Boolean
        Dim stream As FileStream = Nothing
        IsFileOpen = False
        Try
            stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            stream.Close()
        Catch ex As Exception
            If TypeOf ex Is IOException AndAlso IsFileLocked(ex) Then
                IsFileOpen = True
            End If
        End Try
    End Function

    Public Function IsFileLocked(exception As Exception) As Boolean
        Dim errorCode As Integer = Marshal.GetHRForException(exception) And ((1 << 16) - 1)
        Return errorCode = 32 OrElse errorCode = 33
    End Function

    Public Function IsConnectedToInternet() As Boolean
        If My.Computer.Network.IsAvailable Then
            Try
                Dim IPHost As IPHostEntry = Dns.GetHostEntry("www.google.com")
                Return True
            Catch
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function FilenameIsOK(ByVal fileNameAndPath As String) As Boolean
        Dim fileName = fileNameAndPath
        For Each c In Path.GetInvalidFileNameChars()
            If fileName.Contains(c) Then
                Return False
            End If
        Next
        If fileName.Contains(";") Or fileName.Contains(":") Then
            Return False
        End If
        Return True
    End Function

    Public Sub Zapisz_Log_Txt(Tresc As String)
        Try
            Dim strFile As String = "Error_Log.txt"
            Dim fileExists As Boolean = File.Exists(strFile)
            Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
                sw.WriteLine(
                    IIf(fileExists,
                        "Error Message in  Occured at-- " & DateTime.Now & ". Error details: " & Tresc,
                        "Start Error Log for today" & "Error details: " & Tresc))
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' Zastąpiona funkcja przy użyciu PdfPig
    Public Sub ExtractPages(ByVal sourcePdfPath As String, ByVal outputPdfPath As String, ByVal startPage As Integer, ByVal endPage As Integer)
        ' WYpakuj strony od 1 wskazanej do n-tej
        Try
            ' Używamy PdfDocumentBuilder do tworzenia nowego PDF
            Dim builder As New PdfDocumentBuilder()

            Using sourcePdf As PdfDocument = PdfDocument.Open(sourcePdfPath)
                For i As Integer = startPage To endPage
                    ' Dodajemy stronę ze źródłowego PDF do nowego buildera
                    ' Uwaga: w PdfPig indeksowanie stron przy pobieraniu jest zazwyczaj 1-based, 
                    ' ale AddPage bierze obiekt strony lub indeks. Tutaj najbezpieczniej:
                    builder.AddPage(sourcePdf, i)
                Next
            End Using

            ' Zapisz plik
            Dim fileBytes As Byte() = builder.Build()
            File.WriteAllBytes(outputPdfPath, fileBytes)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ' Zastąpiona funkcja przy użyciu PdfPig
    Public Sub Extract_Specific_Pages(ByVal sourcePdfPath As String, ByVal outputPdfPath As String, ByVal extractThesePages As Integer())
        ' Wypakuj poszczególne wskazane w tablicy strony
        Try
            Dim builder As New PdfDocumentBuilder()

            Using sourcePdf As PdfDocument = PdfDocument.Open(sourcePdfPath)
                For Each pageNumber As Integer In extractThesePages
                    If pageNumber > 0 And pageNumber <= sourcePdf.NumberOfPages Then
                        builder.AddPage(sourcePdf, pageNumber)
                    End If
                Next
            End Using

            Dim fileBytes As Byte() = builder.Build()
            File.WriteAllBytes(outputPdfPath, fileBytes)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Module