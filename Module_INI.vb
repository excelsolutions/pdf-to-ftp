'Program PDF-to-FTP
'
'Niniejsze oprogramowanie jest dostarczane "takim, jakie jest", bez jakiejkolwiek gwarancji.
'Pobieranie i użytkowanie programu jest dobrowolne i odbywa się na wyłączną odpowiedzialność użytkownika.
'
'Kod źródłowy dostępny pod adresem: https://github.com/excelsolutions/PDF-to-FTP

Imports System.IO
Imports System.Drawing

Module Module_INI
    'SEKCJA 1 ŚCIEZKI
    Public Folder_PDF As String
    Public Folder_FTP As String
    Public Folder_Dest As String
    'SEKCJA 2 Login i hasło do FTP
    Public Login_FTP As String
    Public Haslo_FTP As String
    ' SEKCJA 3 Ustawienia ciągu znaków do pozyskania z pliku PDF
    Public Start_Pos As String
    Public Lenght_Text As String
    Public Prefix As String
    Public Suffix As String
    Public Klucz As String '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
    'SEKCJA 4 Ustawienia ciągu znaków do rozpoznawania prawidłowego pliku
    Public Start_Pos_Sec As String
    Public Lenght_Text_Sec As String
    Public Klucz_Sec As String '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
    Public Control_String As String
    Public Checking_File As String 'do sprawdzania czy program ma weryfikowac pdf
    'SEKCJA 5 Inne ustawienia
    Public Check_FTP As String
    Public Interval As String '                 interwał automatyzacji
    Public Automation As String
    Public Type_Of_Automat As String
    Public Work_On_Copies As String
    Public Allow_Duplicates As String
    Public SFTP As String
    'Sekcja 6 Dzielenie plikow
    Public Whole_File As String 'procesuj caly plik czy tylko część
    Public Half_or_Specific As String 'bierz połowe stron czy określ jakie chcesz brać
    Public Contain_Word As String 'strony do wzięcia mają zawierac słowa czy nie
    Public First_Last_Pages As String 'bierz 1 czy 2 połowę plik updf
    Public Contain_Text As String 'jesli ten tekst znajdzie się na stronie PDF to program ma brac ją do dalszego procesowania
    Public Group_Pages As String 'grupowanie stron ze znalezionym słowem lub zapis jako osobna strona
    Public Jezyk As String 'język programu, opisów, podpowiedzi


    Sub ZAPISZ_USTAWIENIA_INI()
        'SEKCJA 1 Ściezki dostępu do folderów
        Folder_PDF = Form_Ustawienia.T_Sciezka_PDF.Text
        Folder_FTP = Form_Ustawienia.T_Sciezka_FTP.Text
        'SEKCJA 2 Login i hasło do FTP
        Login_FTP = Form_Ustawienia.T_Login.Text
        Haslo_FTP = Form_Ustawienia.T_Haslo.Text
        ' SEKCJA 3 Ustawienia ciągu znaków do pozyskania z pliku PDF
        Start_Pos = Form_Ustawienia.Num_Start.Value
        Lenght_Text = Form_Ustawienia.Num_Dlugosc.Value
        Prefix = Form_Ustawienia.T_Prefix.Text
        Suffix = Form_Ustawienia.T_Suffix.Text
        '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        Klucz = Form_Ustawienia.T_Klucz.Text
        'SEKCJA 4 Ustawienia ciągu znaków do rozpoznawania prawidłowego pliku
        Start_Pos_Sec = Form_Ustawienia.Num_Start1.Value
        Lenght_Text_Sec = Form_Ustawienia.Num_Dlugosc1.Value
        Klucz_Sec = Form_Ustawienia.T_Klucz1.Text
        '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        Control_String = Form_Ustawienia.T_Control_String.Text
        Checking_File = Form_Ustawienia.Check_Check.CheckState
        'SEKCJA 5 Inne ustawienia
        Check_FTP = Form_Ustawienia.Check_FTP.CheckState
        Interval = Form_Ustawienia.T_Interwal.Text
        Automation = Form_Ustawienia.CheckAutomatyzacja.CheckState
        Work_On_Copies = Form_Ustawienia.Check_Rename.CheckState
        Folder_Dest = Form_Ustawienia.T_Sciezka_Destination.Text
        If Form_Ustawienia.R_Save.Checked = True Then
            Type_Of_Automat = "Only_Save"
        Else
            Type_Of_Automat = "Save_And_Send"
        End If

        Whole_File = My.Forms.Form_Ustawienia.Check_Process_File.CheckState
        If My.Forms.Form_Ustawienia.L_Polowa1.BackColor = Color.Silver Then
            First_Last_Pages = 0 '1 połowa
        Else
            First_Last_Pages = 1 '2 połowa
        End If

        If My.Forms.Form_Ustawienia.R_Contain.Checked = True Then
            Contain_Word = 1
        Else
            Contain_Word = 0
        End If

        If My.Forms.Form_Ustawienia.R_Half_PDF.Checked = True Then
            Half_or_Specific = 0 'bierz jedna albo 2 połowe
        Else
            Half_or_Specific = 1 'bierz okreslone strony z PDF
        End If
        Contain_Text = My.Forms.Form_Ustawienia.T_Tekst_Na_Stronach.Text
        If My.Forms.Form_Ustawienia.C_Group_Pages.Checked = True Then
            Group_Pages = 1 'grupuj strony z tym samym słowem
        Else
            Group_Pages = 0 'Zapisuj strony ze znalezionym słowem osobno
        End If
        Allow_Duplicates = Form_Ustawienia.Check_Duplicates.CheckState
        'Język
        If My.Forms.Form_Ustawienia.R_Polski.Checked = True Then
            Jezyk = "pl"
        ElseIf My.Forms.Form_Ustawienia.R_English.Checked = True Then
            Jezyk = "en"
        Else
            Jezyk = "en"
        End If

        If My.Forms.Form_Ustawienia.Check_SFTP.Checked = True Then
            SFTP = "SFTP"
        Else
            SFTP = "FTP"
        End If


        'Sciezka do pliku ustawień INI
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile

        ' Load and existing file
        ini.Load(Directory & "\Preferences.ini")
        'Zapis wszystkich sekcji - ZMIANA NA SetKeyValue
        ini.SetKeyValue("ACCESS_PATH", "Folder_PDF", Folder_PDF)
        ini.SetKeyValue("ACCESS_PATH", "Folder_FTP", Folder_FTP)
        ini.SetKeyValue("ACCESS_PATH", "Folder_Dest", Folder_Dest)
        ini.SetKeyValue("FTP", "Login_FTP", Login_FTP)
        ini.SetKeyValue("FTP", "Password_FTP", Haslo_FTP)

        ini.SetKeyValue("STRING_TO_GET", "Start_Pos", Start_Pos)
        ini.SetKeyValue("STRING_TO_GET", "Lenght_Text", Lenght_Text)
        ini.SetKeyValue("STRING_TO_GET", "Prefix", Prefix)
        ini.SetKeyValue("STRING_TO_GET", "Suffix", Suffix)
        ini.SetKeyValue("STRING_TO_GET", "Key", Klucz)

        ini.SetKeyValue("PDF_CHECK_KEY", "Start_Pos_Sec", Start_Pos_Sec)
        ini.SetKeyValue("PDF_CHECK_KEY", "Lenght_Text_Sec", Lenght_Text_Sec)
        ini.SetKeyValue("PDF_CHECK_KEY", "Key_Sec", Klucz_Sec)
        ini.SetKeyValue("PDF_CHECK_KEY", "Control_String", Control_String)
        ini.SetKeyValue("PDF_CHECK_KEY", "Checking_File", Checking_File)

        ini.SetKeyValue("OTHER_SETTINGS", "Check_FTP", Check_FTP)
        ini.SetKeyValue("OTHER_SETTINGS", "Interval", Interval)
        ini.SetKeyValue("OTHER_SETTINGS", "Automation", Automation)
        ini.SetKeyValue("OTHER_SETTINGS", "Type_Of_Automat", Type_Of_Automat)
        ini.SetKeyValue("OTHER_SETTINGS", "Work_On_Copies", Work_On_Copies)
        ini.SetKeyValue("OTHER_SETTINGS", "Allow_Duplicates", Allow_Duplicates)
        ini.SetKeyValue("OTHER_SETTINGS", "Language", Jezyk)
        ini.SetKeyValue("OTHER_SETTINGS", "SFTP", SFTP)

        ini.SetKeyValue("SPLITTING FILES", "Whole_File", Whole_File)
        ini.SetKeyValue("SPLITTING FILES", "Half_or_Specific", Half_or_Specific)
        ini.SetKeyValue("SPLITTING FILES", "Contain_Word", Contain_Word)
        ini.SetKeyValue("SPLITTING FILES", "First_Last_Pages", First_Last_Pages)
        ini.SetKeyValue("SPLITTING FILES", "Contain_Text", Contain_Text)
        ini.SetKeyValue("SPLITTING FILES", "Group_Pages", Group_Pages)

        'Save the INI
        ini.Save(Directory & "\Preferences.ini")
    End Sub

    Sub WCZYTAJ_USTAWIENIA_INI()
        'Sciezka do pliku ustawień INI
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile

        ' Load and existing file
        ini.Load(Directory & "\Preferences.ini")

        'SEKCJA 1 Ściezki dostępu do folderów
        Folder_PDF = ini.GetKeyValue("ACCESS_PATH", "Folder_PDF")
        Folder_FTP = ini.GetKeyValue("ACCESS_PATH", "Folder_FTP")
        'SEKCJA 2 Login i hasło do FTP
        Login_FTP = ini.GetKeyValue("FTP", "Login_FTP")
        Haslo_FTP = ini.GetKeyValue("FTP", "Password_FTP")
        ' SEKCJA 3 Ustawienia ciągu znaków do pozyskania z pliku PDF
        Start_Pos = ini.GetKeyValue("STRING_TO_GET", "Start_Pos")
        Lenght_Text = ini.GetKeyValue("STRING_TO_GET", "Lenght_Text")
        Prefix = ini.GetKeyValue("STRING_TO_GET", "Prefix")
        Suffix = ini.GetKeyValue("STRING_TO_GET", "Suffix")
        '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        Klucz = ini.GetKeyValue("STRING_TO_GET", "Key")
        'SEKCJA 4 Ustawienia ciągu znaków do rozpoznawania prawidłowego pliku
        Start_Pos_Sec = ini.GetKeyValue("PDF_CHECK_KEY", "Start_Pos_Sec")
        Lenght_Text_Sec = ini.GetKeyValue("PDF_CHECK_KEY", "Lenght_Text_Sec")
        Klucz_Sec = ini.GetKeyValue("PDF_CHECK_KEY", "Key_Sec")
        '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        Control_String = ini.GetKeyValue("PDF_CHECK_KEY", "Control_String")

        Checking_File = ini.GetKeyValue("PDF_CHECK_KEY", "Checking_File")

        'SEKCJA 5 Inne ustawienia
        Check_FTP = ini.GetKeyValue("OTHER_SETTINGS", "Check_FTP")
        Interval = ini.GetKeyValue("OTHER_SETTINGS", "Interval")
        Automation = ini.GetKeyValue("OTHER_SETTINGS", "Automation")
        Type_Of_Automat = ini.GetKeyValue("OTHER_SETTINGS", "Type_Of_Automat")

        '--- POPRAWIONA SEKCJA POBIERANIA WARTOŚCI (BEZ RENAMEKEY) ---

        ' Work_On_Copies
        Work_On_Copies = ini.GetKeyValue("OTHER_SETTINGS", "Work_On_Copies")
        If String.IsNullOrEmpty(Work_On_Copies) Then
            ' Próba pobrania ze starej nazwy, jeśli istniała (dla kompatybilności), lub ustawienie domyślnej
            ' W tym przypadku nazwa jest ta sama, więc po prostu ustawiamy domyślną 0
            Work_On_Copies = "0"
            ini.SetKeyValue("OTHER_SETTINGS", "Work_On_Copies", "0")
            ini.Save(Directory & "\Preferences.ini")
        End If

        Folder_Dest = ini.GetKeyValue("ACCESS_PATH", "Folder_Dest")
        Whole_File = ini.GetKeyValue("SPLITTING FILES", "Whole_File")
        Half_or_Specific = ini.GetKeyValue("SPLITTING FILES", "Half_or_Specific")
        Contain_Word = ini.GetKeyValue("SPLITTING FILES", "Contain_Word")
        Contain_Text = ini.GetKeyValue("SPLITTING FILES", "Contain_Text")
        First_Last_Pages = ini.GetKeyValue("SPLITTING FILES", "First_Last_Pages")

        ' Group_Pages
        Group_Pages = ini.GetKeyValue("SPLITTING FILES", "Group_Pages")
        If String.IsNullOrEmpty(Group_Pages) Then
            Group_Pages = "1" ' Domyślnie włączone grupowanie
            ini.SetKeyValue("SPLITTING FILES", "Group_Pages", "1")
            ini.Save(Directory & "\Preferences.ini")
        End If

        ' Allow_Duplicates
        Allow_Duplicates = ini.GetKeyValue("OTHER_SETTINGS", "Allow_Duplicates")
        If String.IsNullOrEmpty(Allow_Duplicates) Then
            Allow_Duplicates = "1"
            ini.SetKeyValue("OTHER_SETTINGS", "Allow_Duplicates", "1")
            ini.Save(Directory & "\Preferences.ini")
        End If

        ' Language
        Jezyk = ini.GetKeyValue("OTHER_SETTINGS", "Language")
        If String.IsNullOrEmpty(Jezyk) Then
            Jezyk = "en"
            ini.SetKeyValue("OTHER_SETTINGS", "Language", "en")
            ini.Save(Directory & "\Preferences.ini")
        End If

        ' SFTP
        SFTP = ini.GetKeyValue("OTHER_SETTINGS", "SFTP")
        If String.IsNullOrEmpty(SFTP) Then
            SFTP = "FTP"
            ini.SetKeyValue("OTHER_SETTINGS", "SFTP", "FTP")
            ini.Save(Directory & "\Preferences.ini")
        End If

        'Wczytywanie wartości do Form_Ustawienia
        Form_Ustawienia.T_Sciezka_PDF.Text = Folder_PDF
        Form_Ustawienia.T_Sciezka_FTP.Text = Folder_FTP
        Form_Ustawienia.T_Login.Text = Login_FTP
        Form_Ustawienia.T_Haslo.Text = Haslo_FTP
        Form_Ustawienia.Num_Start.Value = Val(Start_Pos)
        Form_Ustawienia.Num_Dlugosc.Value = Val(Lenght_Text)
        Form_Ustawienia.T_Prefix.Text = Prefix
        Form_Ustawienia.T_Suffix.Text = Suffix
        Form_Ustawienia.T_Klucz.Text = Klucz
        Form_Ustawienia.Num_Start1.Value = Val(Start_Pos_Sec)
        Form_Ustawienia.Num_Dlugosc1.Value = Val(Lenght_Text_Sec)
        Form_Ustawienia.T_Klucz1.Text = Klucz_Sec
        Form_Ustawienia.T_Control_String.Text = Control_String
        Form_Ustawienia.Check_Check.CheckState = Val(Checking_File)
        Form_Ustawienia.Check_FTP.Checked = (Val(Check_FTP) = 1)
        Form_Ustawienia.T_Interwal.Text = Interval
        Form_Ustawienia.CheckAutomatyzacja.Checked = (Val(Automation) = 1)
        If Val(Automation) = 1 Then
            Form_Ustawienia.L_PIC_Auto.BackColor = Color.Lime
            Form_Main.ToolStripAutomation.Visible = True
            Form_Main.ToolStripStatusLabel1.Visible = True
        Else
            Form_Ustawienia.L_PIC_Auto.BackColor = Color.Red
            Form_Main.ToolStripAutomation.Visible = False
            Form_Main.ToolStripStatusLabel1.Visible = False
        End If

        If Type_Of_Automat = "Only_Save" Then 'ustawienia automatu
            Form_Ustawienia.R_Save.Checked = True
        Else
            Form_Ustawienia.R_Send.Checked = True
        End If

        If Work_On_Copies = Nothing Then
            Work_On_Copies = "0"
        End If
        If Val(Work_On_Copies) = 1 Then 'czy ma kopiowac pliki w inne miejsce
            Form_Ustawienia.Check_Rename.Checked = True
            Form_Ustawienia.L_PIC_Rename.BackColor = Color.Lime
        Else
            Form_Ustawienia.Check_Rename.Checked = False
            Form_Ustawienia.L_PIC_Rename.BackColor = Color.Red
        End If


        Form_Ustawienia.T_Sciezka_Destination.Text = Folder_Dest
        Form_Ustawienia.Check_Process_File.Checked = (Val(Whole_File) = 1)
        Form_Ustawienia.T_Tekst_Na_Stronach.Text = Contain_Text

        Form_Ustawienia.Aktualizuj_Kolor()
        If Val(Whole_File) = 1 Then
            My.Forms.Form_Ustawienia.Check_Process_File.Checked = True
            My.Forms.Form_Ustawienia.L_Pick_Process_File.BackColor = Color.Lime
            My.Forms.Form_Ustawienia.SplitC.Visible = False
            My.Forms.Form_Ustawienia.R_Half_PDF.Visible = False
            My.Forms.Form_Ustawienia.R_Pages.Visible = False
            My.Forms.Form_Ustawienia.L_Pic_Half_PDF.Visible = False
            My.Forms.Form_Ustawienia.L_Pic_Pages.Visible = False
            My.Forms.Form_Ustawienia.L_Page_Settings_Opis.Visible = True
        Else
            My.Forms.Form_Ustawienia.Check_Process_File.Checked = False
            My.Forms.Form_Ustawienia.L_Pick_Process_File.BackColor = Color.Red
            My.Forms.Form_Ustawienia.SplitC.Visible = True
            My.Forms.Form_Ustawienia.R_Half_PDF.Visible = True
            My.Forms.Form_Ustawienia.R_Pages.Visible = True
            My.Forms.Form_Ustawienia.L_Pic_Half_PDF.Visible = True
            My.Forms.Form_Ustawienia.L_Pic_Pages.Visible = True
            My.Forms.Form_Ustawienia.L_Page_Settings_Opis.Visible = False
        End If

        If Val(First_Last_Pages) = 0 Then '0 - pierwsza połowa, 1- druga połowa
            My.Forms.Form_Ustawienia.L_Polowa1.BackColor = Color.Silver
            My.Forms.Form_Ustawienia.L_Polowa2.BackColor = Color.WhiteSmoke
        Else
            My.Forms.Form_Ustawienia.L_Polowa2.BackColor = Color.Silver
            My.Forms.Form_Ustawienia.L_Polowa1.BackColor = Color.WhiteSmoke
        End If

        If Val(Contain_Word) = 1 Then
            My.Forms.Form_Ustawienia.R_Contain.Checked = True
            My.Forms.Form_Ustawienia.L_Pic_Contain.BackColor = Color.Lime
            My.Forms.Form_Ustawienia.R_Not_Contain.Checked = False
            My.Forms.Form_Ustawienia.L_Pic_Not_Contain.BackColor = Color.Red
        Else
            My.Forms.Form_Ustawienia.R_Contain.Checked = False
            My.Forms.Form_Ustawienia.L_Pic_Contain.BackColor = Color.Red
            My.Forms.Form_Ustawienia.R_Not_Contain.Checked = True
            My.Forms.Form_Ustawienia.L_Pic_Not_Contain.BackColor = Color.Lime
        End If
        If Val(Half_or_Specific) = 0 Then '0- bierz rowne polowy, 1- bierz poszczegolne strony
            My.Forms.Form_Ustawienia.R_Half_PDF.Checked = True
            My.Forms.Form_Ustawienia.R_Pages.Checked = False
            My.Forms.Form_Ustawienia.L_Pic_Half_PDF.BackColor = Color.Lime
            My.Forms.Form_Ustawienia.L_Pic_Pages.BackColor = Color.Red
            My.Forms.Form_Ustawienia.SplitC.Panel1.Enabled = True
            My.Forms.Form_Ustawienia.SplitC.Panel2.Enabled = False
        Else
            My.Forms.Form_Ustawienia.R_Half_PDF.Checked = False
            My.Forms.Form_Ustawienia.R_Pages.Checked = True
            My.Forms.Form_Ustawienia.L_Pic_Half_PDF.BackColor = Color.Red
            My.Forms.Form_Ustawienia.L_Pic_Pages.BackColor = Color.Lime
            My.Forms.Form_Ustawienia.SplitC.Panel1.Enabled = False
            My.Forms.Form_Ustawienia.SplitC.Panel2.Enabled = True
        End If
        If Val(Group_Pages) = 1 Then
            My.Forms.Form_Ustawienia.C_Group_Pages.Checked = True
        Else
            My.Forms.Form_Ustawienia.C_Group_Pages.Checked = False
        End If
        If Val(Allow_Duplicates) = 1 Then
            My.Forms.Form_Ustawienia.Check_Duplicates.Checked = True
        Else
            My.Forms.Form_Ustawienia.Check_Duplicates.Checked = False
        End If

        Select Case Jezyk
            Case "pl"
                My.Forms.Form_Ustawienia.R_Polski.Checked = True
                My.Forms.Form_Ustawienia.R_English.Checked = False
            Case "en"
                My.Forms.Form_Ustawienia.R_Polski.Checked = False
                My.Forms.Form_Ustawienia.R_English.Checked = True
        End Select

        If SFTP = "SFTP" Then
            My.Forms.Form_Ustawienia.Check_SFTP.Checked = True
            My.Forms.Form_Ustawienia.L_PIC_SFTP.BackColor = Color.Lime
        Else
            My.Forms.Form_Ustawienia.Check_SFTP.Checked = False
            My.Forms.Form_Ustawienia.L_PIC_SFTP.BackColor = Color.Red
        End If
    End Sub

    Sub Inicjacja_INI()
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim ini As New IniFile
        If File.Exists(Directory & "\Preferences.ini") Then
        Else
            My.Computer.FileSystem.WriteAllText(Directory & "\Preferences.ini", "[FTP_DANE]", False)
            ZAPISZ_USTAWIENIA_INI()
        End If
    End Sub

    Sub Ujawnij_Zmienne()
        Debug.Print("Folder_PDF- " & Folder_PDF)
        Debug.Print("Folder_FTP- " & Folder_FTP)
        'SEKCJA 2 Login i hasło do FTP
        Debug.Print("Login_FTP- " & Login_FTP)
        Debug.Print("Haslo_FTP- " & Haslo_FTP)
        ' SEKCJA 3 Ustawienia ciągu znaków do pozyskania z pliku PDF
        Debug.Print("Start_Pos- " & Start_Pos)
        Debug.Print("Lenght_Text- " & Lenght_Text)
        Debug.Print("Prefix- " & Prefix)
        Debug.Print("Suffix- " & Suffix)
        Debug.Print("Klucz- " & Klucz) '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        'SEKCJA 4 Ustawienia ciągu znaków do rozpoznawania prawidłowego pliku
        Debug.Print("Start_Pos_Sec- " & Start_Pos_Sec)
        Debug.Print("Lenght_Text_Sec- " & Lenght_Text_Sec)
        Debug.Print("Klucz_Sec- " & Klucz_Sec) '    Ciąg znaków, który ma być znaleziony i od którego nalezy poruszać się w prawo lub w lewo celem wyłuskania ciągu znaków
        Debug.Print("Control_String- " & Control_String)
        'SEKCJA 5 Inne ustawienia
        Debug.Print("Check_FTP- " & Check_FTP)
        Debug.Print("Interval- " & Interval) '  
    End Sub

    Public Sub Aktualizacja_Programu_Nowe_INI()
        'Procedura na wypadek jak zmieni się plik INI- dojdzie tam parę kluczy
        Dim Directory As String = My.Application.Info.DirectoryPath
        Dim Ini_Original As New IniFile
        Dim Ini_New As New IniFile

        ' Load and existing file
        Ini_Original.Load(Directory & "\Preferences.ini")
        If File.Exists(Directory & "\New_Preferences.ini") Then
            Ini_New.Load(Directory & "\New_Preferences.ini")

            ' Iteracja po nowym pliku i dodawanie brakujących kluczy do starego
            For Each sSection As String In Ini_New.Sections
                For Each sKey As String In Ini_New.GetSectionKeys(sSection)
                    ' Sprawdź czy klucz istnieje w oryginalnym pliku
                    Dim originalVal As String = Ini_Original.GetKeyValue(sSection, sKey)

                    ' Jeśli klucz nie istnieje (zwraca pusty ciąg w naszej prostej implementacji), dodaj go z wartością z nowego pliku
                    If String.IsNullOrEmpty(originalVal) Then
                        Dim newVal As String = Ini_New.GetKeyValue(sSection, sKey)
                        Ini_Original.SetKeyValue(sSection, sKey, newVal)
                    End If
                Next
            Next

            Ini_Original.Save(Directory & "\Preferences.ini")
            'usunięcie pliku New_Preferences
            My.Computer.FileSystem.DeleteFile(Directory & "\New_Preferences.ini")
        End If
    End Sub
End Module