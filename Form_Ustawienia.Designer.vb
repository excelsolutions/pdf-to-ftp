﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Ustawienia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Ustawienia))
        Me.Group_PDF = New System.Windows.Forms.GroupBox()
        Me.T_Sciezka_PDF = New System.Windows.Forms.TextBox()
        Me.Pic_PDF = New System.Windows.Forms.PictureBox()
        Me.Group_FTP = New System.Windows.Forms.GroupBox()
        Me.L_PIC_FTP = New System.Windows.Forms.Label()
        Me.Check_FTP = New System.Windows.Forms.CheckBox()
        Me.Pic_FTP = New System.Windows.Forms.PictureBox()
        Me.L_Haslo = New System.Windows.Forms.Label()
        Me.T_Sciezka_FTP = New System.Windows.Forms.TextBox()
        Me.T_Haslo = New System.Windows.Forms.TextBox()
        Me.L_Adres = New System.Windows.Forms.Label()
        Me.L_Login = New System.Windows.Forms.Label()
        Me.T_Login = New System.Windows.Forms.TextBox()
        Me.Btn_Zapisz = New System.Windows.Forms.Button()
        Me.Btn_Anuluj = New System.Windows.Forms.Button()
        Me.Wybor_Folderu = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.L_PIC_Rename = New System.Windows.Forms.Label()
        Me.Group_Destination = New System.Windows.Forms.GroupBox()
        Me.T_Sciezka_Destination = New System.Windows.Forms.TextBox()
        Me.Pic_Destination = New System.Windows.Forms.PictureBox()
        Me.Check_Rename = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Group_FileName = New System.Windows.Forms.GroupBox()
        Me.L_Pic_Duplicates = New System.Windows.Forms.Label()
        Me.Check_Duplicates = New System.Windows.Forms.CheckBox()
        Me.L_Wybierz_Przyklad = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.L_Pozycja_Karety = New System.Windows.Forms.Label()
        Me.T_Klucz = New System.Windows.Forms.TextBox()
        Me.T_Suffix = New System.Windows.Forms.TextBox()
        Me.Num_Dlugosc = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.L_New_File_Name = New System.Windows.Forms.Label()
        Me.T_Przykladowa_Nazwa = New System.Windows.Forms.TextBox()
        Me.T_Prefix = New System.Windows.Forms.TextBox()
        Me.L_Number_Chars = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Wybierz_Z_Zaznaczenia = New System.Windows.Forms.Button()
        Me.L_Specified_Text = New System.Windows.Forms.Label()
        Me.L_Start_Position = New System.Windows.Forms.Label()
        Me.Num_Start = New System.Windows.Forms.NumericUpDown()
        Me.Pic_Wybierz_Przyklad = New System.Windows.Forms.PictureBox()
        Me.R_Podglad = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CommitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L_Opis_Careta = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.L_Pozycja_Karety1 = New System.Windows.Forms.Label()
        Me.Btn_Wybierz_Z_Zaznaczenia1 = New System.Windows.Forms.Button()
        Me.L_Opis_Careta1 = New System.Windows.Forms.Label()
        Me.Group_Control_String = New System.Windows.Forms.GroupBox()
        Me.Pic_Sec = New System.Windows.Forms.PictureBox()
        Me.T_Control_String = New System.Windows.Forms.TextBox()
        Me.Group_Pozycja_Control_Stringu = New System.Windows.Forms.GroupBox()
        Me.L_Pic_Check = New System.Windows.Forms.Label()
        Me.Check_Check = New System.Windows.Forms.CheckBox()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.L_Specified_Text1 = New System.Windows.Forms.Label()
        Me.Num_Start1 = New System.Windows.Forms.NumericUpDown()
        Me.T_Klucz1 = New System.Windows.Forms.TextBox()
        Me.L_Start_Position1 = New System.Windows.Forms.Label()
        Me.Num_Dlugosc1 = New System.Windows.Forms.NumericUpDown()
        Me.L_Number_Chars1 = New System.Windows.Forms.Label()
        Me.Pic_Wybierz_Przyklad1 = New System.Windows.Forms.PictureBox()
        Me.R_Podglad1 = New System.Windows.Forms.RichTextBox()
        Me.L_Wybierz_Przyklad1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Group_Typ_Automatyzacji = New System.Windows.Forms.GroupBox()
        Me.L_PIC_Auto = New System.Windows.Forms.Label()
        Me.L_PIC_Save = New System.Windows.Forms.Label()
        Me.L_PIC_Send = New System.Windows.Forms.Label()
        Me.R_Send = New System.Windows.Forms.RadioButton()
        Me.R_Save = New System.Windows.Forms.RadioButton()
        Me.CheckAutomatyzacja = New System.Windows.Forms.CheckBox()
        Me.Group_Statystyka = New System.Windows.Forms.GroupBox()
        Me.L_Start = New System.Windows.Forms.Label()
        Me.T_Liczba_Bledow = New System.Windows.Forms.TextBox()
        Me.T_Czas_Startu_Automatu = New System.Windows.Forms.TextBox()
        Me.L_Liczba_Bledow = New System.Windows.Forms.Label()
        Me.L_Liczba_Cykli = New System.Windows.Forms.Label()
        Me.T_Liczba_Zmienionych_Plikow = New System.Windows.Forms.TextBox()
        Me.T_Liczba_Cykli = New System.Windows.Forms.TextBox()
        Me.L_Liczba_Zapisanych_Plikow = New System.Windows.Forms.Label()
        Me.Group_Interval = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.T_Interwal = New System.Windows.Forms.TextBox()
        Me.Num_Sekundy = New System.Windows.Forms.NumericUpDown()
        Me.Num_Minuty = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.L_Page_Settings_Opis = New System.Windows.Forms.Label()
        Me.R_Half_PDF = New System.Windows.Forms.RadioButton()
        Me.R_Pages = New System.Windows.Forms.RadioButton()
        Me.Check_Process_File = New System.Windows.Forms.CheckBox()
        Me.L_Pick_Process_File = New System.Windows.Forms.Label()
        Me.SplitC = New System.Windows.Forms.SplitContainer()
        Me.L_Polowa1 = New System.Windows.Forms.Label()
        Me.L_Polowa2 = New System.Windows.Forms.Label()
        Me.C_Group_Pages = New System.Windows.Forms.CheckBox()
        Me.L_Pic_Group_Pages = New System.Windows.Forms.Label()
        Me.R_Not_Contain = New System.Windows.Forms.RadioButton()
        Me.R_Contain = New System.Windows.Forms.RadioButton()
        Me.L_Text_ToFind = New System.Windows.Forms.Label()
        Me.L_Przyklad = New System.Windows.Forms.Label()
        Me.T_Tekst_Na_Stronach = New System.Windows.Forms.TextBox()
        Me.L_Pic_Not_Contain = New System.Windows.Forms.Label()
        Me.L_Pic_Contain = New System.Windows.Forms.Label()
        Me.L_Pic_Pages = New System.Windows.Forms.Label()
        Me.L_Pic_Half_PDF = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Group_Jezyk = New System.Windows.Forms.GroupBox()
        Me.R_Polski = New System.Windows.Forms.RadioButton()
        Me.L_Pic_Polski = New System.Windows.Forms.Label()
        Me.L_Pick_English = New System.Windows.Forms.Label()
        Me.R_English = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_Pic = New System.Windows.Forms.Timer(Me.components)
        Me.L_PIC_SFTP = New System.Windows.Forms.Label()
        Me.Check_SFTP = New System.Windows.Forms.CheckBox()
        Me.Group_PDF.SuspendLayout()
        CType(Me.Pic_PDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_FTP.SuspendLayout()
        CType(Me.Pic_FTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Group_Destination.SuspendLayout()
        CType(Me.Pic_Destination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Group_FileName.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Dlugosc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Wybierz_Przyklad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Group_Control_String.SuspendLayout()
        CType(Me.Pic_Sec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Pozycja_Control_Stringu.SuspendLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Start1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Dlugosc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Wybierz_Przyklad1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Group_Typ_Automatyzacji.SuspendLayout()
        Me.Group_Statystyka.SuspendLayout()
        Me.Group_Interval.SuspendLayout()
        CType(Me.Num_Sekundy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Minuty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.SplitC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitC.Panel1.SuspendLayout()
        Me.SplitC.Panel2.SuspendLayout()
        Me.SplitC.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Group_Jezyk.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_PDF
        '
        Me.Group_PDF.Controls.Add(Me.T_Sciezka_PDF)
        Me.Group_PDF.Controls.Add(Me.Pic_PDF)
        Me.Group_PDF.Location = New System.Drawing.Point(9, 9)
        Me.Group_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_PDF.Name = "Group_PDF"
        Me.Group_PDF.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_PDF.Size = New System.Drawing.Size(724, 120)
        Me.Group_PDF.TabIndex = 15
        Me.Group_PDF.TabStop = False
        Me.Group_PDF.Text = "Folder with PDF files"
        '
        'T_Sciezka_PDF
        '
        Me.T_Sciezka_PDF.Location = New System.Drawing.Point(9, 29)
        Me.T_Sciezka_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sciezka_PDF.Multiline = True
        Me.T_Sciezka_PDF.Name = "T_Sciezka_PDF"
        Me.T_Sciezka_PDF.Size = New System.Drawing.Size(612, 67)
        Me.T_Sciezka_PDF.TabIndex = 1
        '
        'Pic_PDF
        '
        Me.Pic_PDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_PDF.Image = Global.PDF_Reader.My.Resources.Resources.Folder
        Me.Pic_PDF.Location = New System.Drawing.Point(632, 29)
        Me.Pic_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_PDF.Name = "Pic_PDF"
        Me.Pic_PDF.Size = New System.Drawing.Size(64, 69)
        Me.Pic_PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_PDF.TabIndex = 6
        Me.Pic_PDF.TabStop = False
        '
        'Group_FTP
        '
        Me.Group_FTP.Controls.Add(Me.L_PIC_SFTP)
        Me.Group_FTP.Controls.Add(Me.Check_SFTP)
        Me.Group_FTP.Controls.Add(Me.L_PIC_FTP)
        Me.Group_FTP.Controls.Add(Me.Check_FTP)
        Me.Group_FTP.Controls.Add(Me.Pic_FTP)
        Me.Group_FTP.Controls.Add(Me.L_Haslo)
        Me.Group_FTP.Controls.Add(Me.T_Sciezka_FTP)
        Me.Group_FTP.Controls.Add(Me.T_Haslo)
        Me.Group_FTP.Controls.Add(Me.L_Adres)
        Me.Group_FTP.Controls.Add(Me.L_Login)
        Me.Group_FTP.Controls.Add(Me.T_Login)
        Me.Group_FTP.Location = New System.Drawing.Point(4, 305)
        Me.Group_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FTP.Name = "Group_FTP"
        Me.Group_FTP.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FTP.Size = New System.Drawing.Size(722, 247)
        Me.Group_FTP.TabIndex = 14
        Me.Group_FTP.TabStop = False
        Me.Group_FTP.Text = "FTP"
        '
        'L_PIC_FTP
        '
        Me.L_PIC_FTP.BackColor = System.Drawing.Color.Red
        Me.L_PIC_FTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_FTP.Location = New System.Drawing.Point(495, 25)
        Me.L_PIC_FTP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_FTP.Name = "L_PIC_FTP"
        Me.L_PIC_FTP.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_FTP.TabIndex = 30
        '
        'Check_FTP
        '
        Me.Check_FTP.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_FTP.Location = New System.Drawing.Point(524, 17)
        Me.Check_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_FTP.Name = "Check_FTP"
        Me.Check_FTP.Size = New System.Drawing.Size(171, 35)
        Me.Check_FTP.TabIndex = 12
        Me.Check_FTP.Text = "Enabled"
        Me.Check_FTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check_FTP.UseVisualStyleBackColor = True
        '
        'Pic_FTP
        '
        Me.Pic_FTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_FTP.Image = Global.PDF_Reader.My.Resources.Resources.Folder
        Me.Pic_FTP.Location = New System.Drawing.Point(628, 57)
        Me.Pic_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_FTP.Name = "Pic_FTP"
        Me.Pic_FTP.Size = New System.Drawing.Size(64, 69)
        Me.Pic_FTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_FTP.TabIndex = 7
        Me.Pic_FTP.TabStop = False
        '
        'L_Haslo
        '
        Me.L_Haslo.Location = New System.Drawing.Point(368, 128)
        Me.L_Haslo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Haslo.Name = "L_Haslo"
        Me.L_Haslo.Size = New System.Drawing.Size(210, 28)
        Me.L_Haslo.TabIndex = 11
        Me.L_Haslo.Text = "Password"
        Me.L_Haslo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Sciezka_FTP
        '
        Me.T_Sciezka_FTP.Location = New System.Drawing.Point(12, 57)
        Me.T_Sciezka_FTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sciezka_FTP.Multiline = True
        Me.T_Sciezka_FTP.Name = "T_Sciezka_FTP"
        Me.T_Sciezka_FTP.Size = New System.Drawing.Size(606, 67)
        Me.T_Sciezka_FTP.TabIndex = 2
        '
        'T_Haslo
        '
        Me.T_Haslo.Location = New System.Drawing.Point(370, 162)
        Me.T_Haslo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Haslo.Name = "T_Haslo"
        Me.T_Haslo.Size = New System.Drawing.Size(319, 26)
        Me.T_Haslo.TabIndex = 10
        '
        'L_Adres
        '
        Me.L_Adres.Location = New System.Drawing.Point(9, 25)
        Me.L_Adres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Adres.Name = "L_Adres"
        Me.L_Adres.Size = New System.Drawing.Size(297, 28)
        Me.L_Adres.TabIndex = 3
        Me.L_Adres.Text = "Address"
        Me.L_Adres.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'L_Login
        '
        Me.L_Login.Location = New System.Drawing.Point(8, 126)
        Me.L_Login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Login.Name = "L_Login"
        Me.L_Login.Size = New System.Drawing.Size(162, 28)
        Me.L_Login.TabIndex = 9
        Me.L_Login.Text = "Login"
        Me.L_Login.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Login
        '
        Me.T_Login.Location = New System.Drawing.Point(10, 160)
        Me.T_Login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Login.Name = "T_Login"
        Me.T_Login.Size = New System.Drawing.Size(316, 26)
        Me.T_Login.TabIndex = 8
        '
        'Btn_Zapisz
        '
        Me.Btn_Zapisz.Location = New System.Drawing.Point(519, 620)
        Me.Btn_Zapisz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Zapisz.Name = "Btn_Zapisz"
        Me.Btn_Zapisz.Size = New System.Drawing.Size(225, 57)
        Me.Btn_Zapisz.TabIndex = 16
        Me.Btn_Zapisz.Text = "Save"
        Me.Btn_Zapisz.UseVisualStyleBackColor = True
        '
        'Btn_Anuluj
        '
        Me.Btn_Anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Anuluj.Location = New System.Drawing.Point(284, 620)
        Me.Btn_Anuluj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Anuluj.Name = "Btn_Anuluj"
        Me.Btn_Anuluj.Size = New System.Drawing.Size(225, 57)
        Me.Btn_Anuluj.TabIndex = 17
        Me.Btn_Anuluj.Text = "Cancel"
        Me.Btn_Anuluj.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 611)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.L_PIC_Rename)
        Me.TabPage1.Controls.Add(Me.Group_Destination)
        Me.TabPage1.Controls.Add(Me.Check_Rename)
        Me.TabPage1.Controls.Add(Me.Group_PDF)
        Me.TabPage1.Controls.Add(Me.Group_FTP)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(754, 578)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Path settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'L_PIC_Rename
        '
        Me.L_PIC_Rename.BackColor = System.Drawing.Color.Lime
        Me.L_PIC_Rename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_Rename.Location = New System.Drawing.Point(508, 146)
        Me.L_PIC_Rename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_Rename.Name = "L_PIC_Rename"
        Me.L_PIC_Rename.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_Rename.TabIndex = 29
        '
        'Group_Destination
        '
        Me.Group_Destination.Controls.Add(Me.T_Sciezka_Destination)
        Me.Group_Destination.Controls.Add(Me.Pic_Destination)
        Me.Group_Destination.Location = New System.Drawing.Point(4, 178)
        Me.Group_Destination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Destination.Name = "Group_Destination"
        Me.Group_Destination.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Destination.Size = New System.Drawing.Size(724, 112)
        Me.Group_Destination.TabIndex = 16
        Me.Group_Destination.TabStop = False
        Me.Group_Destination.Text = "Destination folder for copies"
        '
        'T_Sciezka_Destination
        '
        Me.T_Sciezka_Destination.Location = New System.Drawing.Point(14, 29)
        Me.T_Sciezka_Destination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Sciezka_Destination.Multiline = True
        Me.T_Sciezka_Destination.Name = "T_Sciezka_Destination"
        Me.T_Sciezka_Destination.Size = New System.Drawing.Size(612, 67)
        Me.T_Sciezka_Destination.TabIndex = 1
        '
        'Pic_Destination
        '
        Me.Pic_Destination.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Destination.Image = Global.PDF_Reader.My.Resources.Resources.Folder
        Me.Pic_Destination.Location = New System.Drawing.Point(636, 29)
        Me.Pic_Destination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_Destination.Name = "Pic_Destination"
        Me.Pic_Destination.Size = New System.Drawing.Size(64, 69)
        Me.Pic_Destination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Destination.TabIndex = 6
        Me.Pic_Destination.TabStop = False
        '
        'Check_Rename
        '
        Me.Check_Rename.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_Rename.Location = New System.Drawing.Point(537, 138)
        Me.Check_Rename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_Rename.Name = "Check_Rename"
        Me.Check_Rename.Size = New System.Drawing.Size(168, 35)
        Me.Check_Rename.TabIndex = 13
        Me.Check_Rename.Text = "Work on copies"
        Me.Check_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check_Rename.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Group_FileName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(754, 578)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "File name settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Group_FileName
        '
        Me.Group_FileName.Controls.Add(Me.L_Pic_Duplicates)
        Me.Group_FileName.Controls.Add(Me.Check_Duplicates)
        Me.Group_FileName.Controls.Add(Me.L_Wybierz_Przyklad)
        Me.Group_FileName.Controls.Add(Me.Pic)
        Me.Group_FileName.Controls.Add(Me.L_Pozycja_Karety)
        Me.Group_FileName.Controls.Add(Me.T_Klucz)
        Me.Group_FileName.Controls.Add(Me.T_Suffix)
        Me.Group_FileName.Controls.Add(Me.Num_Dlugosc)
        Me.Group_FileName.Controls.Add(Me.Label9)
        Me.Group_FileName.Controls.Add(Me.L_New_File_Name)
        Me.Group_FileName.Controls.Add(Me.T_Przykladowa_Nazwa)
        Me.Group_FileName.Controls.Add(Me.T_Prefix)
        Me.Group_FileName.Controls.Add(Me.L_Number_Chars)
        Me.Group_FileName.Controls.Add(Me.Label8)
        Me.Group_FileName.Controls.Add(Me.Btn_Wybierz_Z_Zaznaczenia)
        Me.Group_FileName.Controls.Add(Me.L_Specified_Text)
        Me.Group_FileName.Controls.Add(Me.L_Start_Position)
        Me.Group_FileName.Controls.Add(Me.Num_Start)
        Me.Group_FileName.Controls.Add(Me.Pic_Wybierz_Przyklad)
        Me.Group_FileName.Controls.Add(Me.R_Podglad)
        Me.Group_FileName.Controls.Add(Me.L_Opis_Careta)
        Me.Group_FileName.Location = New System.Drawing.Point(20, 5)
        Me.Group_FileName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FileName.Name = "Group_FileName"
        Me.Group_FileName.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_FileName.Size = New System.Drawing.Size(690, 557)
        Me.Group_FileName.TabIndex = 0
        Me.Group_FileName.TabStop = False
        Me.Group_FileName.Text = "Position and lenght of string to be cut"
        '
        'L_Pic_Duplicates
        '
        Me.L_Pic_Duplicates.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Duplicates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Duplicates.Location = New System.Drawing.Point(26, 254)
        Me.L_Pic_Duplicates.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Duplicates.Name = "L_Pic_Duplicates"
        Me.L_Pic_Duplicates.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Duplicates.TabIndex = 39
        '
        'Check_Duplicates
        '
        Me.Check_Duplicates.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_Duplicates.AutoSize = True
        Me.Check_Duplicates.Location = New System.Drawing.Point(51, 246)
        Me.Check_Duplicates.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_Duplicates.Name = "Check_Duplicates"
        Me.Check_Duplicates.Size = New System.Drawing.Size(132, 30)
        Me.Check_Duplicates.TabIndex = 38
        Me.Check_Duplicates.Text = "Allow duplicates"
        Me.Check_Duplicates.UseVisualStyleBackColor = True
        '
        'L_Wybierz_Przyklad
        '
        Me.L_Wybierz_Przyklad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Wybierz_Przyklad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Wybierz_Przyklad.ForeColor = System.Drawing.Color.Blue
        Me.L_Wybierz_Przyklad.Location = New System.Drawing.Point(15, 285)
        Me.L_Wybierz_Przyklad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Wybierz_Przyklad.Name = "L_Wybierz_Przyklad"
        Me.L_Wybierz_Przyklad.Size = New System.Drawing.Size(328, 28)
        Me.L_Wybierz_Przyklad.TabIndex = 37
        Me.L_Wybierz_Przyklad.Text = "To see preview please load example pdf file:"
        Me.L_Wybierz_Przyklad.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Pic
        '
        Me.Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic.Image = Global.PDF_Reader.My.Resources.Resources.Checkmark_green_svg
        Me.Pic.Location = New System.Drawing.Point(454, 69)
        Me.Pic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(32, 31)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic.TabIndex = 36
        Me.Pic.TabStop = False
        '
        'L_Pozycja_Karety
        '
        Me.L_Pozycja_Karety.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Pozycja_Karety.Location = New System.Drawing.Point(632, 278)
        Me.L_Pozycja_Karety.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pozycja_Karety.Name = "L_Pozycja_Karety"
        Me.L_Pozycja_Karety.Size = New System.Drawing.Size(54, 31)
        Me.L_Pozycja_Karety.TabIndex = 20
        Me.L_Pozycja_Karety.Text = "00"
        Me.L_Pozycja_Karety.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Klucz
        '
        Me.T_Klucz.Location = New System.Drawing.Point(140, 69)
        Me.T_Klucz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Klucz.Name = "T_Klucz"
        Me.T_Klucz.Size = New System.Drawing.Size(308, 26)
        Me.T_Klucz.TabIndex = 17
        '
        'T_Suffix
        '
        Me.T_Suffix.Location = New System.Drawing.Point(366, 138)
        Me.T_Suffix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Suffix.Name = "T_Suffix"
        Me.T_Suffix.Size = New System.Drawing.Size(307, 26)
        Me.T_Suffix.TabIndex = 16
        '
        'Num_Dlugosc
        '
        Me.Num_Dlugosc.Location = New System.Drawing.Point(490, 69)
        Me.Num_Dlugosc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Dlugosc.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Num_Dlugosc.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num_Dlugosc.Name = "Num_Dlugosc"
        Me.Num_Dlugosc.Size = New System.Drawing.Size(184, 26)
        Me.Num_Dlugosc.TabIndex = 6
        Me.Num_Dlugosc.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(362, 106)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(314, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Suffix:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'L_New_File_Name
        '
        Me.L_New_File_Name.Location = New System.Drawing.Point(15, 174)
        Me.L_New_File_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_New_File_Name.Name = "L_New_File_Name"
        Me.L_New_File_Name.Size = New System.Drawing.Size(188, 28)
        Me.L_New_File_Name.TabIndex = 12
        Me.L_New_File_Name.Text = "New file name preview:"
        Me.L_New_File_Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_Przykladowa_Nazwa
        '
        Me.T_Przykladowa_Nazwa.Location = New System.Drawing.Point(20, 206)
        Me.T_Przykladowa_Nazwa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Przykladowa_Nazwa.Name = "T_Przykladowa_Nazwa"
        Me.T_Przykladowa_Nazwa.ReadOnly = True
        Me.T_Przykladowa_Nazwa.Size = New System.Drawing.Size(654, 26)
        Me.T_Przykladowa_Nazwa.TabIndex = 11
        '
        'T_Prefix
        '
        Me.T_Prefix.Location = New System.Drawing.Point(20, 138)
        Me.T_Prefix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Prefix.Name = "T_Prefix"
        Me.T_Prefix.Size = New System.Drawing.Size(307, 26)
        Me.T_Prefix.TabIndex = 14
        '
        'L_Number_Chars
        '
        Me.L_Number_Chars.Location = New System.Drawing.Point(486, 32)
        Me.L_Number_Chars.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Number_Chars.Name = "L_Number_Chars"
        Me.L_Number_Chars.Size = New System.Drawing.Size(189, 32)
        Me.L_Number_Chars.TabIndex = 5
        Me.L_Number_Chars.Text = "Number of char. to cut:"
        Me.L_Number_Chars.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 28)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Prefix:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Btn_Wybierz_Z_Zaznaczenia
        '
        Me.Btn_Wybierz_Z_Zaznaczenia.Location = New System.Drawing.Point(381, 283)
        Me.Btn_Wybierz_Z_Zaznaczenia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Wybierz_Z_Zaznaczenia.Name = "Btn_Wybierz_Z_Zaznaczenia"
        Me.Btn_Wybierz_Z_Zaznaczenia.Size = New System.Drawing.Size(195, 29)
        Me.Btn_Wybierz_Z_Zaznaczenia.TabIndex = 10
        Me.Btn_Wybierz_Z_Zaznaczenia.Text = "Pick form selection"
        Me.Btn_Wybierz_Z_Zaznaczenia.UseVisualStyleBackColor = True
        '
        'L_Specified_Text
        '
        Me.L_Specified_Text.Location = New System.Drawing.Point(135, 37)
        Me.L_Specified_Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Specified_Text.Name = "L_Specified_Text"
        Me.L_Specified_Text.Size = New System.Drawing.Size(342, 29)
        Me.L_Specified_Text.TabIndex = 18
        Me.L_Specified_Text.Text = "specified text to indicate beginning"
        Me.L_Specified_Text.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'L_Start_Position
        '
        Me.L_Start_Position.Location = New System.Drawing.Point(15, 37)
        Me.L_Start_Position.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Start_Position.Name = "L_Start_Position"
        Me.L_Start_Position.Size = New System.Drawing.Size(111, 28)
        Me.L_Start_Position.TabIndex = 4
        Me.L_Start_Position.Text = "Start position"
        Me.L_Start_Position.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Num_Start
        '
        Me.Num_Start.Location = New System.Drawing.Point(20, 69)
        Me.Num_Start.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Start.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Num_Start.Minimum = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.Num_Start.Name = "Num_Start"
        Me.Num_Start.Size = New System.Drawing.Size(106, 26)
        Me.Num_Start.TabIndex = 0
        Me.Num_Start.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Pic_Wybierz_Przyklad
        '
        Me.Pic_Wybierz_Przyklad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Wybierz_Przyklad.Image = Global.PDF_Reader.My.Resources.Resources.pdf_obrazek
        Me.Pic_Wybierz_Przyklad.Location = New System.Drawing.Point(340, 282)
        Me.Pic_Wybierz_Przyklad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_Wybierz_Przyklad.Name = "Pic_Wybierz_Przyklad"
        Me.Pic_Wybierz_Przyklad.Size = New System.Drawing.Size(32, 31)
        Me.Pic_Wybierz_Przyklad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Wybierz_Przyklad.TabIndex = 9
        Me.Pic_Wybierz_Przyklad.TabStop = False
        '
        'R_Podglad
        '
        Me.R_Podglad.ContextMenuStrip = Me.ContextMenuStrip1
        Me.R_Podglad.Location = New System.Drawing.Point(20, 322)
        Me.R_Podglad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Podglad.Name = "R_Podglad"
        Me.R_Podglad.Size = New System.Drawing.Size(654, 224)
        Me.R_Podglad.TabIndex = 8
        Me.R_Podglad.Text = resources.GetString("R_Podglad.Text")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(220, 36)
        '
        'CommitToolStripMenuItem
        '
        Me.CommitToolStripMenuItem.Name = "CommitToolStripMenuItem"
        Me.CommitToolStripMenuItem.Size = New System.Drawing.Size(219, 32)
        Me.CommitToolStripMenuItem.Text = "confirm selection"
        '
        'L_Opis_Careta
        '
        Me.L_Opis_Careta.Location = New System.Drawing.Point(580, 268)
        Me.L_Opis_Careta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Opis_Careta.Name = "L_Opis_Careta"
        Me.L_Opis_Careta.Size = New System.Drawing.Size(58, 42)
        Me.L_Opis_Careta.TabIndex = 19
        Me.L_Opis_Careta.Text = "Caret:"
        Me.L_Opis_Careta.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.L_Pozycja_Karety1)
        Me.TabPage3.Controls.Add(Me.Btn_Wybierz_Z_Zaznaczenia1)
        Me.TabPage3.Controls.Add(Me.L_Opis_Careta1)
        Me.TabPage3.Controls.Add(Me.Group_Control_String)
        Me.TabPage3.Controls.Add(Me.Group_Pozycja_Control_Stringu)
        Me.TabPage3.Controls.Add(Me.Pic_Wybierz_Przyklad1)
        Me.TabPage3.Controls.Add(Me.R_Podglad1)
        Me.TabPage3.Controls.Add(Me.L_Wybierz_Przyklad1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(754, 578)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Checking PDF algorythm"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'L_Pozycja_Karety1
        '
        Me.L_Pozycja_Karety1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Pozycja_Karety1.Location = New System.Drawing.Point(642, 254)
        Me.L_Pozycja_Karety1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pozycja_Karety1.Name = "L_Pozycja_Karety1"
        Me.L_Pozycja_Karety1.Size = New System.Drawing.Size(54, 31)
        Me.L_Pozycja_Karety1.TabIndex = 34
        Me.L_Pozycja_Karety1.Text = "00"
        Me.L_Pozycja_Karety1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Btn_Wybierz_Z_Zaznaczenia1
        '
        Me.Btn_Wybierz_Z_Zaznaczenia1.Location = New System.Drawing.Point(398, 258)
        Me.Btn_Wybierz_Z_Zaznaczenia1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Wybierz_Z_Zaznaczenia1.Name = "Btn_Wybierz_Z_Zaznaczenia1"
        Me.Btn_Wybierz_Z_Zaznaczenia1.Size = New System.Drawing.Size(189, 29)
        Me.Btn_Wybierz_Z_Zaznaczenia1.TabIndex = 32
        Me.Btn_Wybierz_Z_Zaznaczenia1.Text = "PDF to FTP - analiza"
        Me.Btn_Wybierz_Z_Zaznaczenia1.UseVisualStyleBackColor = True
        '
        'L_Opis_Careta1
        '
        Me.L_Opis_Careta1.Location = New System.Drawing.Point(591, 243)
        Me.L_Opis_Careta1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Opis_Careta1.Name = "L_Opis_Careta1"
        Me.L_Opis_Careta1.Size = New System.Drawing.Size(58, 42)
        Me.L_Opis_Careta1.TabIndex = 33
        Me.L_Opis_Careta1.Text = "Caret:"
        Me.L_Opis_Careta1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Group_Control_String
        '
        Me.Group_Control_String.Controls.Add(Me.Pic_Sec)
        Me.Group_Control_String.Controls.Add(Me.T_Control_String)
        Me.Group_Control_String.Location = New System.Drawing.Point(14, 163)
        Me.Group_Control_String.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Control_String.Name = "Group_Control_String"
        Me.Group_Control_String.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Control_String.Size = New System.Drawing.Size(684, 85)
        Me.Group_Control_String.TabIndex = 31
        Me.Group_Control_String.TabStop = False
        Me.Group_Control_String.Text = "Control string"
        '
        'Pic_Sec
        '
        Me.Pic_Sec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Sec.Image = Global.PDF_Reader.My.Resources.Resources.Checkmark_green_svg
        Me.Pic_Sec.Location = New System.Drawing.Point(644, 29)
        Me.Pic_Sec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_Sec.Name = "Pic_Sec"
        Me.Pic_Sec.Size = New System.Drawing.Size(32, 31)
        Me.Pic_Sec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Sec.TabIndex = 36
        Me.Pic_Sec.TabStop = False
        '
        'T_Control_String
        '
        Me.T_Control_String.Location = New System.Drawing.Point(18, 29)
        Me.T_Control_String.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Control_String.Name = "T_Control_String"
        Me.T_Control_String.Size = New System.Drawing.Size(616, 26)
        Me.T_Control_String.TabIndex = 28
        '
        'Group_Pozycja_Control_Stringu
        '
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.L_Pic_Check)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.Check_Check)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.Pic1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.L_Specified_Text1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.Num_Start1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.T_Klucz1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.L_Start_Position1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.Num_Dlugosc1)
        Me.Group_Pozycja_Control_Stringu.Controls.Add(Me.L_Number_Chars1)
        Me.Group_Pozycja_Control_Stringu.Location = New System.Drawing.Point(15, 5)
        Me.Group_Pozycja_Control_Stringu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Pozycja_Control_Stringu.Name = "Group_Pozycja_Control_Stringu"
        Me.Group_Pozycja_Control_Stringu.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Pozycja_Control_Stringu.Size = New System.Drawing.Size(684, 149)
        Me.Group_Pozycja_Control_Stringu.TabIndex = 30
        Me.Group_Pozycja_Control_Stringu.TabStop = False
        Me.Group_Pozycja_Control_Stringu.Text = "Define position of the control string"
        '
        'L_Pic_Check
        '
        Me.L_Pic_Check.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Check.Location = New System.Drawing.Point(20, 28)
        Me.L_Pic_Check.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Check.Name = "L_Pic_Check"
        Me.L_Pic_Check.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Check.TabIndex = 37
        '
        'Check_Check
        '
        Me.Check_Check.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_Check.AutoSize = True
        Me.Check_Check.Location = New System.Drawing.Point(45, 20)
        Me.Check_Check.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_Check.Name = "Check_Check"
        Me.Check_Check.Size = New System.Drawing.Size(213, 30)
        Me.Check_Check.TabIndex = 36
        Me.Check_Check.Text = "Turn on checking alghorytm"
        Me.Check_Check.UseVisualStyleBackColor = True
        '
        'Pic1
        '
        Me.Pic1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic1.Image = Global.PDF_Reader.My.Resources.Resources.Checkmark_green_svg
        Me.Pic1.Location = New System.Drawing.Point(453, 92)
        Me.Pic1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(32, 31)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 35
        Me.Pic1.TabStop = False
        '
        'L_Specified_Text1
        '
        Me.L_Specified_Text1.Location = New System.Drawing.Point(134, 60)
        Me.L_Specified_Text1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Specified_Text1.Name = "L_Specified_Text1"
        Me.L_Specified_Text1.Size = New System.Drawing.Size(342, 29)
        Me.L_Specified_Text1.TabIndex = 28
        Me.L_Specified_Text1.Text = "specified text to indicate beginning"
        Me.L_Specified_Text1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Num_Start1
        '
        Me.Num_Start1.Location = New System.Drawing.Point(18, 92)
        Me.Num_Start1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Start1.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.Num_Start1.Minimum = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.Num_Start1.Name = "Num_Start1"
        Me.Num_Start1.Size = New System.Drawing.Size(106, 26)
        Me.Num_Start1.TabIndex = 20
        Me.Num_Start1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'T_Klucz1
        '
        Me.T_Klucz1.Location = New System.Drawing.Point(138, 92)
        Me.T_Klucz1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Klucz1.Name = "T_Klucz1"
        Me.T_Klucz1.Size = New System.Drawing.Size(308, 26)
        Me.T_Klucz1.TabIndex = 27
        '
        'L_Start_Position1
        '
        Me.L_Start_Position1.Location = New System.Drawing.Point(14, 60)
        Me.L_Start_Position1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Start_Position1.Name = "L_Start_Position1"
        Me.L_Start_Position1.Size = New System.Drawing.Size(111, 28)
        Me.L_Start_Position1.TabIndex = 21
        Me.L_Start_Position1.Text = "Start position"
        Me.L_Start_Position1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Num_Dlugosc1
        '
        Me.Num_Dlugosc1.Location = New System.Drawing.Point(489, 92)
        Me.Num_Dlugosc1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Dlugosc1.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Num_Dlugosc1.Name = "Num_Dlugosc1"
        Me.Num_Dlugosc1.Size = New System.Drawing.Size(184, 26)
        Me.Num_Dlugosc1.TabIndex = 23
        Me.Num_Dlugosc1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'L_Number_Chars1
        '
        Me.L_Number_Chars1.Location = New System.Drawing.Point(484, 55)
        Me.L_Number_Chars1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Number_Chars1.Name = "L_Number_Chars1"
        Me.L_Number_Chars1.Size = New System.Drawing.Size(189, 32)
        Me.L_Number_Chars1.TabIndex = 22
        Me.L_Number_Chars1.Text = "Number of char. to cut:"
        Me.L_Number_Chars1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Pic_Wybierz_Przyklad1
        '
        Me.Pic_Wybierz_Przyklad1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Wybierz_Przyklad1.Image = Global.PDF_Reader.My.Resources.Resources.pdf_obrazek
        Me.Pic_Wybierz_Przyklad1.Location = New System.Drawing.Point(357, 257)
        Me.Pic_Wybierz_Przyklad1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pic_Wybierz_Przyklad1.Name = "Pic_Wybierz_Przyklad1"
        Me.Pic_Wybierz_Przyklad1.Size = New System.Drawing.Size(32, 31)
        Me.Pic_Wybierz_Przyklad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Wybierz_Przyklad1.TabIndex = 26
        Me.Pic_Wybierz_Przyklad1.TabStop = False
        '
        'R_Podglad1
        '
        Me.R_Podglad1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.R_Podglad1.Location = New System.Drawing.Point(32, 297)
        Me.R_Podglad1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Podglad1.Name = "R_Podglad1"
        Me.R_Podglad1.Size = New System.Drawing.Size(654, 267)
        Me.R_Podglad1.TabIndex = 25
        Me.R_Podglad1.Text = resources.GetString("R_Podglad1.Text")
        '
        'L_Wybierz_Przyklad1
        '
        Me.L_Wybierz_Przyklad1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Wybierz_Przyklad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Wybierz_Przyklad1.ForeColor = System.Drawing.Color.Blue
        Me.L_Wybierz_Przyklad1.Location = New System.Drawing.Point(27, 257)
        Me.L_Wybierz_Przyklad1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Wybierz_Przyklad1.Name = "L_Wybierz_Przyklad1"
        Me.L_Wybierz_Przyklad1.Size = New System.Drawing.Size(342, 28)
        Me.L_Wybierz_Przyklad1.TabIndex = 24
        Me.L_Wybierz_Przyklad1.Text = "To see preview please load example pdf file:"
        Me.L_Wybierz_Przyklad1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Group_Typ_Automatyzacji)
        Me.TabPage4.Controls.Add(Me.Group_Statystyka)
        Me.TabPage4.Controls.Add(Me.Group_Interval)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Size = New System.Drawing.Size(754, 578)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Automation"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Group_Typ_Automatyzacji
        '
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.L_PIC_Auto)
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.L_PIC_Save)
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.L_PIC_Send)
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.R_Send)
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.R_Save)
        Me.Group_Typ_Automatyzacji.Controls.Add(Me.CheckAutomatyzacja)
        Me.Group_Typ_Automatyzacji.Location = New System.Drawing.Point(4, 9)
        Me.Group_Typ_Automatyzacji.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Typ_Automatyzacji.Name = "Group_Typ_Automatyzacji"
        Me.Group_Typ_Automatyzacji.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Typ_Automatyzacji.Size = New System.Drawing.Size(700, 152)
        Me.Group_Typ_Automatyzacji.TabIndex = 38
        Me.Group_Typ_Automatyzacji.TabStop = False
        Me.Group_Typ_Automatyzacji.Text = "Operating mode od automation"
        '
        'L_PIC_Auto
        '
        Me.L_PIC_Auto.BackColor = System.Drawing.Color.Red
        Me.L_PIC_Auto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_Auto.Location = New System.Drawing.Point(9, 37)
        Me.L_PIC_Auto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_Auto.Name = "L_PIC_Auto"
        Me.L_PIC_Auto.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_Auto.TabIndex = 30
        '
        'L_PIC_Save
        '
        Me.L_PIC_Save.BackColor = System.Drawing.Color.Lime
        Me.L_PIC_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_Save.Location = New System.Drawing.Point(9, 114)
        Me.L_PIC_Save.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_Save.Name = "L_PIC_Save"
        Me.L_PIC_Save.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_Save.TabIndex = 29
        '
        'L_PIC_Send
        '
        Me.L_PIC_Send.BackColor = System.Drawing.Color.Lime
        Me.L_PIC_Send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_Send.Location = New System.Drawing.Point(316, 114)
        Me.L_PIC_Send.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_Send.Name = "L_PIC_Send"
        Me.L_PIC_Send.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_Send.TabIndex = 28
        '
        'R_Send
        '
        Me.R_Send.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Send.Checked = True
        Me.R_Send.Location = New System.Drawing.Point(345, 103)
        Me.R_Send.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Send.Name = "R_Send"
        Me.R_Send.Size = New System.Drawing.Size(240, 40)
        Me.R_Send.TabIndex = 27
        Me.R_Send.TabStop = True
        Me.R_Send.Text = "Rename and send files to FTP"
        Me.R_Send.UseVisualStyleBackColor = True
        '
        'R_Save
        '
        Me.R_Save.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Save.Location = New System.Drawing.Point(34, 105)
        Me.R_Save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Save.Name = "R_Save"
        Me.R_Save.Size = New System.Drawing.Size(240, 38)
        Me.R_Save.TabIndex = 26
        Me.R_Save.Text = "Only rename files"
        Me.R_Save.UseVisualStyleBackColor = True
        '
        'CheckAutomatyzacja
        '
        Me.CheckAutomatyzacja.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckAutomatyzacja.AutoSize = True
        Me.CheckAutomatyzacja.Location = New System.Drawing.Point(34, 29)
        Me.CheckAutomatyzacja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckAutomatyzacja.Name = "CheckAutomatyzacja"
        Me.CheckAutomatyzacja.Size = New System.Drawing.Size(345, 30)
        Me.CheckAutomatyzacja.TabIndex = 25
        Me.CheckAutomatyzacja.Text = "Turn on automation after opening the program"
        Me.CheckAutomatyzacja.UseVisualStyleBackColor = True
        '
        'Group_Statystyka
        '
        Me.Group_Statystyka.Controls.Add(Me.L_Start)
        Me.Group_Statystyka.Controls.Add(Me.T_Liczba_Bledow)
        Me.Group_Statystyka.Controls.Add(Me.T_Czas_Startu_Automatu)
        Me.Group_Statystyka.Controls.Add(Me.L_Liczba_Bledow)
        Me.Group_Statystyka.Controls.Add(Me.L_Liczba_Cykli)
        Me.Group_Statystyka.Controls.Add(Me.T_Liczba_Zmienionych_Plikow)
        Me.Group_Statystyka.Controls.Add(Me.T_Liczba_Cykli)
        Me.Group_Statystyka.Controls.Add(Me.L_Liczba_Zapisanych_Plikow)
        Me.Group_Statystyka.Location = New System.Drawing.Point(4, 286)
        Me.Group_Statystyka.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Statystyka.Name = "Group_Statystyka"
        Me.Group_Statystyka.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Statystyka.Size = New System.Drawing.Size(700, 209)
        Me.Group_Statystyka.TabIndex = 37
        Me.Group_Statystyka.TabStop = False
        Me.Group_Statystyka.Text = "Statistics"
        '
        'L_Start
        '
        Me.L_Start.AutoSize = True
        Me.L_Start.Location = New System.Drawing.Point(30, 42)
        Me.L_Start.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Start.Name = "L_Start"
        Me.L_Start.Size = New System.Drawing.Size(78, 20)
        Me.L_Start.TabIndex = 29
        Me.L_Start.Text = "Start time"
        '
        'T_Liczba_Bledow
        '
        Me.T_Liczba_Bledow.Location = New System.Drawing.Point(244, 157)
        Me.T_Liczba_Bledow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Liczba_Bledow.Name = "T_Liczba_Bledow"
        Me.T_Liczba_Bledow.ReadOnly = True
        Me.T_Liczba_Bledow.Size = New System.Drawing.Size(220, 26)
        Me.T_Liczba_Bledow.TabIndex = 36
        '
        'T_Czas_Startu_Automatu
        '
        Me.T_Czas_Startu_Automatu.Location = New System.Drawing.Point(244, 37)
        Me.T_Czas_Startu_Automatu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Czas_Startu_Automatu.Name = "T_Czas_Startu_Automatu"
        Me.T_Czas_Startu_Automatu.ReadOnly = True
        Me.T_Czas_Startu_Automatu.Size = New System.Drawing.Size(220, 26)
        Me.T_Czas_Startu_Automatu.TabIndex = 30
        '
        'L_Liczba_Bledow
        '
        Me.L_Liczba_Bledow.AutoSize = True
        Me.L_Liczba_Bledow.Location = New System.Drawing.Point(30, 162)
        Me.L_Liczba_Bledow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Liczba_Bledow.Name = "L_Liczba_Bledow"
        Me.L_Liczba_Bledow.Size = New System.Drawing.Size(115, 20)
        Me.L_Liczba_Bledow.TabIndex = 35
        Me.L_Liczba_Bledow.Text = "Count of errors"
        '
        'L_Liczba_Cykli
        '
        Me.L_Liczba_Cykli.AutoSize = True
        Me.L_Liczba_Cykli.Location = New System.Drawing.Point(30, 82)
        Me.L_Liczba_Cykli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Liczba_Cykli.Name = "L_Liczba_Cykli"
        Me.L_Liczba_Cykli.Size = New System.Drawing.Size(117, 20)
        Me.L_Liczba_Cykli.TabIndex = 31
        Me.L_Liczba_Cykli.Text = "Count of cycles"
        '
        'T_Liczba_Zmienionych_Plikow
        '
        Me.T_Liczba_Zmienionych_Plikow.Location = New System.Drawing.Point(244, 117)
        Me.T_Liczba_Zmienionych_Plikow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Liczba_Zmienionych_Plikow.Name = "T_Liczba_Zmienionych_Plikow"
        Me.T_Liczba_Zmienionych_Plikow.ReadOnly = True
        Me.T_Liczba_Zmienionych_Plikow.Size = New System.Drawing.Size(220, 26)
        Me.T_Liczba_Zmienionych_Plikow.TabIndex = 34
        '
        'T_Liczba_Cykli
        '
        Me.T_Liczba_Cykli.Location = New System.Drawing.Point(244, 77)
        Me.T_Liczba_Cykli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Liczba_Cykli.Name = "T_Liczba_Cykli"
        Me.T_Liczba_Cykli.ReadOnly = True
        Me.T_Liczba_Cykli.Size = New System.Drawing.Size(220, 26)
        Me.T_Liczba_Cykli.TabIndex = 32
        '
        'L_Liczba_Zapisanych_Plikow
        '
        Me.L_Liczba_Zapisanych_Plikow.AutoSize = True
        Me.L_Liczba_Zapisanych_Plikow.Location = New System.Drawing.Point(30, 122)
        Me.L_Liczba_Zapisanych_Plikow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Liczba_Zapisanych_Plikow.Name = "L_Liczba_Zapisanych_Plikow"
        Me.L_Liczba_Zapisanych_Plikow.Size = New System.Drawing.Size(148, 20)
        Me.L_Liczba_Zapisanych_Plikow.TabIndex = 33
        Me.L_Liczba_Zapisanych_Plikow.Text = "Count of saved files"
        '
        'Group_Interval
        '
        Me.Group_Interval.Controls.Add(Me.Label16)
        Me.Group_Interval.Controls.Add(Me.T_Interwal)
        Me.Group_Interval.Controls.Add(Me.Num_Sekundy)
        Me.Group_Interval.Controls.Add(Me.Num_Minuty)
        Me.Group_Interval.Controls.Add(Me.Label11)
        Me.Group_Interval.Controls.Add(Me.Label15)
        Me.Group_Interval.Controls.Add(Me.Label6)
        Me.Group_Interval.Location = New System.Drawing.Point(4, 171)
        Me.Group_Interval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Interval.Name = "Group_Interval"
        Me.Group_Interval.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Interval.Size = New System.Drawing.Size(700, 106)
        Me.Group_Interval.TabIndex = 23
        Me.Group_Interval.TabStop = False
        Me.Group_Interval.Text = "Interval"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(116, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 31)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "and"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Interwal
        '
        Me.T_Interwal.Location = New System.Drawing.Point(315, 58)
        Me.T_Interwal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Interwal.Name = "T_Interwal"
        Me.T_Interwal.ReadOnly = True
        Me.T_Interwal.Size = New System.Drawing.Size(124, 26)
        Me.T_Interwal.TabIndex = 28
        Me.T_Interwal.Text = "0"
        '
        'Num_Sekundy
        '
        Me.Num_Sekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Num_Sekundy.Location = New System.Drawing.Point(170, 60)
        Me.Num_Sekundy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Sekundy.Maximum = New Decimal(New Integer() {86400, 0, 0, 0})
        Me.Num_Sekundy.Name = "Num_Sekundy"
        Me.Num_Sekundy.Size = New System.Drawing.Size(93, 26)
        Me.Num_Sekundy.TabIndex = 23
        '
        'Num_Minuty
        '
        Me.Num_Minuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Num_Minuty.Location = New System.Drawing.Point(14, 60)
        Me.Num_Minuty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Num_Minuty.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.Num_Minuty.Name = "Num_Minuty"
        Me.Num_Minuty.Size = New System.Drawing.Size(93, 26)
        Me.Num_Minuty.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(14, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 28)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "[m]"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(310, 32)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Interval [s] (min=10s)"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(165, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "[s]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.L_Page_Settings_Opis)
        Me.TabPage5.Controls.Add(Me.R_Half_PDF)
        Me.TabPage5.Controls.Add(Me.R_Pages)
        Me.TabPage5.Controls.Add(Me.Check_Process_File)
        Me.TabPage5.Controls.Add(Me.L_Pick_Process_File)
        Me.TabPage5.Controls.Add(Me.SplitC)
        Me.TabPage5.Controls.Add(Me.L_Pic_Pages)
        Me.TabPage5.Controls.Add(Me.L_Pic_Half_PDF)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(754, 578)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Page settings"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'L_Page_Settings_Opis
        '
        Me.L_Page_Settings_Opis.Location = New System.Drawing.Point(24, 97)
        Me.L_Page_Settings_Opis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Page_Settings_Opis.Name = "L_Page_Settings_Opis"
        Me.L_Page_Settings_Opis.Size = New System.Drawing.Size(654, 49)
        Me.L_Page_Settings_Opis.TabIndex = 47
        Me.L_Page_Settings_Opis.Text = "If option ""Process whole PDF file"" is disabled, program will split PDF file to pa" &
    "ges usings settings on this page."
        Me.L_Page_Settings_Opis.Visible = False
        '
        'R_Half_PDF
        '
        Me.R_Half_PDF.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Half_PDF.Checked = True
        Me.R_Half_PDF.Location = New System.Drawing.Point(48, 51)
        Me.R_Half_PDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Half_PDF.Name = "R_Half_PDF"
        Me.R_Half_PDF.Size = New System.Drawing.Size(218, 40)
        Me.R_Half_PDF.TabIndex = 46
        Me.R_Half_PDF.TabStop = True
        Me.R_Half_PDF.Text = "Take half of the PDF"
        Me.R_Half_PDF.UseVisualStyleBackColor = True
        '
        'R_Pages
        '
        Me.R_Pages.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Pages.Location = New System.Drawing.Point(310, 49)
        Me.R_Pages.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Pages.Name = "R_Pages"
        Me.R_Pages.Size = New System.Drawing.Size(240, 40)
        Me.R_Pages.TabIndex = 45
        Me.R_Pages.Text = "Take specific pages"
        Me.R_Pages.UseVisualStyleBackColor = True
        '
        'Check_Process_File
        '
        Me.Check_Process_File.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_Process_File.Location = New System.Drawing.Point(45, 9)
        Me.Check_Process_File.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_Process_File.Name = "Check_Process_File"
        Me.Check_Process_File.Size = New System.Drawing.Size(220, 35)
        Me.Check_Process_File.TabIndex = 43
        Me.Check_Process_File.Text = "Process whole PDF file"
        Me.Check_Process_File.UseVisualStyleBackColor = True
        '
        'L_Pick_Process_File
        '
        Me.L_Pick_Process_File.BackColor = System.Drawing.Color.Red
        Me.L_Pick_Process_File.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pick_Process_File.Location = New System.Drawing.Point(20, 17)
        Me.L_Pick_Process_File.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pick_Process_File.Name = "L_Pick_Process_File"
        Me.L_Pick_Process_File.Size = New System.Drawing.Size(20, 22)
        Me.L_Pick_Process_File.TabIndex = 44
        '
        'SplitC
        '
        Me.SplitC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitC.Location = New System.Drawing.Point(24, 98)
        Me.SplitC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitC.Name = "SplitC"
        '
        'SplitC.Panel1
        '
        Me.SplitC.Panel1.Controls.Add(Me.L_Polowa1)
        Me.SplitC.Panel1.Controls.Add(Me.L_Polowa2)
        '
        'SplitC.Panel2
        '
        Me.SplitC.Panel2.Controls.Add(Me.C_Group_Pages)
        Me.SplitC.Panel2.Controls.Add(Me.L_Pic_Group_Pages)
        Me.SplitC.Panel2.Controls.Add(Me.R_Not_Contain)
        Me.SplitC.Panel2.Controls.Add(Me.R_Contain)
        Me.SplitC.Panel2.Controls.Add(Me.L_Text_ToFind)
        Me.SplitC.Panel2.Controls.Add(Me.L_Przyklad)
        Me.SplitC.Panel2.Controls.Add(Me.T_Tekst_Na_Stronach)
        Me.SplitC.Panel2.Controls.Add(Me.L_Pic_Not_Contain)
        Me.SplitC.Panel2.Controls.Add(Me.L_Pic_Contain)
        Me.SplitC.Size = New System.Drawing.Size(654, 394)
        Me.SplitC.SplitterDistance = 237
        Me.SplitC.SplitterWidth = 6
        Me.SplitC.TabIndex = 42
        '
        'L_Polowa1
        '
        Me.L_Polowa1.BackColor = System.Drawing.Color.Silver
        Me.L_Polowa1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Polowa1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Polowa1.Location = New System.Drawing.Point(21, 46)
        Me.L_Polowa1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Polowa1.Name = "L_Polowa1"
        Me.L_Polowa1.Size = New System.Drawing.Size(90, 158)
        Me.L_Polowa1.TabIndex = 38
        Me.L_Polowa1.Text = "First half"
        Me.L_Polowa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Polowa2
        '
        Me.L_Polowa2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_Polowa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Polowa2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Polowa2.Location = New System.Drawing.Point(120, 46)
        Me.L_Polowa2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Polowa2.Name = "L_Polowa2"
        Me.L_Polowa2.Size = New System.Drawing.Size(90, 158)
        Me.L_Polowa2.TabIndex = 39
        Me.L_Polowa2.Text = "Last half"
        Me.L_Polowa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C_Group_Pages
        '
        Me.C_Group_Pages.Appearance = System.Windows.Forms.Appearance.Button
        Me.C_Group_Pages.Location = New System.Drawing.Point(66, 248)
        Me.C_Group_Pages.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C_Group_Pages.Name = "C_Group_Pages"
        Me.C_Group_Pages.Size = New System.Drawing.Size(135, 58)
        Me.C_Group_Pages.TabIndex = 52
        Me.C_Group_Pages.Text = "Group pages"
        Me.C_Group_Pages.UseVisualStyleBackColor = True
        '
        'L_Pic_Group_Pages
        '
        Me.L_Pic_Group_Pages.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Group_Pages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Group_Pages.Location = New System.Drawing.Point(38, 268)
        Me.L_Pic_Group_Pages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Group_Pages.Name = "L_Pic_Group_Pages"
        Me.L_Pic_Group_Pages.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Group_Pages.TabIndex = 49
        '
        'R_Not_Contain
        '
        Me.R_Not_Contain.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Not_Contain.Location = New System.Drawing.Point(66, 178)
        Me.R_Not_Contain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Not_Contain.Name = "R_Not_Contain"
        Me.R_Not_Contain.Size = New System.Drawing.Size(135, 60)
        Me.R_Not_Contain.TabIndex = 48
        Me.R_Not_Contain.Text = "Take if page not contain word"
        Me.R_Not_Contain.UseVisualStyleBackColor = True
        '
        'R_Contain
        '
        Me.R_Contain.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Contain.Checked = True
        Me.R_Contain.Location = New System.Drawing.Point(66, 111)
        Me.R_Contain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Contain.Name = "R_Contain"
        Me.R_Contain.Size = New System.Drawing.Size(135, 60)
        Me.R_Contain.TabIndex = 47
        Me.R_Contain.TabStop = True
        Me.R_Contain.Text = "Take if page contain word"
        Me.R_Contain.UseVisualStyleBackColor = True
        '
        'L_Text_ToFind
        '
        Me.L_Text_ToFind.Location = New System.Drawing.Point(30, 14)
        Me.L_Text_ToFind.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Text_ToFind.Name = "L_Text_ToFind"
        Me.L_Text_ToFind.Size = New System.Drawing.Size(358, 28)
        Me.L_Text_ToFind.TabIndex = 43
        Me.L_Text_ToFind.Text = "Define text to be find in PDF file"
        Me.L_Text_ToFind.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'L_Przyklad
        '
        Me.L_Przyklad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.L_Przyklad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Przyklad.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Przyklad.Location = New System.Drawing.Point(250, 86)
        Me.L_Przyklad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Przyklad.Name = "L_Przyklad"
        Me.L_Przyklad.Size = New System.Drawing.Size(138, 212)
        Me.L_Przyklad.TabIndex = 40
        Me.L_Przyklad.Text = resources.GetString("L_Przyklad.Text")
        '
        'T_Tekst_Na_Stronach
        '
        Me.T_Tekst_Na_Stronach.Location = New System.Drawing.Point(34, 46)
        Me.T_Tekst_Na_Stronach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T_Tekst_Na_Stronach.Name = "T_Tekst_Na_Stronach"
        Me.T_Tekst_Na_Stronach.Size = New System.Drawing.Size(352, 26)
        Me.T_Tekst_Na_Stronach.TabIndex = 27
        '
        'L_Pic_Not_Contain
        '
        Me.L_Pic_Not_Contain.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Not_Contain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Not_Contain.Location = New System.Drawing.Point(38, 198)
        Me.L_Pic_Not_Contain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Not_Contain.Name = "L_Pic_Not_Contain"
        Me.L_Pic_Not_Contain.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Not_Contain.TabIndex = 41
        '
        'L_Pic_Contain
        '
        Me.L_Pic_Contain.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Contain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Contain.Location = New System.Drawing.Point(38, 132)
        Me.L_Pic_Contain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Contain.Name = "L_Pic_Contain"
        Me.L_Pic_Contain.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Contain.TabIndex = 39
        '
        'L_Pic_Pages
        '
        Me.L_Pic_Pages.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Pages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Pages.Location = New System.Drawing.Point(278, 62)
        Me.L_Pic_Pages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Pages.Name = "L_Pic_Pages"
        Me.L_Pic_Pages.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Pages.TabIndex = 37
        '
        'L_Pic_Half_PDF
        '
        Me.L_Pic_Half_PDF.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Half_PDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Half_PDF.Location = New System.Drawing.Point(20, 62)
        Me.L_Pic_Half_PDF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Half_PDF.Name = "L_Pic_Half_PDF"
        Me.L_Pic_Half_PDF.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Half_PDF.TabIndex = 37
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Group_Jezyk)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(754, 578)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Language"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Group_Jezyk
        '
        Me.Group_Jezyk.Controls.Add(Me.R_Polski)
        Me.Group_Jezyk.Controls.Add(Me.L_Pic_Polski)
        Me.Group_Jezyk.Controls.Add(Me.L_Pick_English)
        Me.Group_Jezyk.Controls.Add(Me.R_English)
        Me.Group_Jezyk.Location = New System.Drawing.Point(12, 25)
        Me.Group_Jezyk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Jezyk.Name = "Group_Jezyk"
        Me.Group_Jezyk.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Group_Jezyk.Size = New System.Drawing.Size(724, 152)
        Me.Group_Jezyk.TabIndex = 39
        Me.Group_Jezyk.TabStop = False
        Me.Group_Jezyk.Text = "Change language"
        '
        'R_Polski
        '
        Me.R_Polski.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_Polski.Location = New System.Drawing.Point(36, 42)
        Me.R_Polski.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_Polski.Name = "R_Polski"
        Me.R_Polski.Size = New System.Drawing.Size(118, 38)
        Me.R_Polski.TabIndex = 31
        Me.R_Polski.Text = "Polski"
        Me.R_Polski.UseVisualStyleBackColor = True
        '
        'L_Pic_Polski
        '
        Me.L_Pic_Polski.BackColor = System.Drawing.Color.Red
        Me.L_Pic_Polski.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pic_Polski.Location = New System.Drawing.Point(8, 51)
        Me.L_Pic_Polski.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pic_Polski.Name = "L_Pic_Polski"
        Me.L_Pic_Polski.Size = New System.Drawing.Size(20, 22)
        Me.L_Pic_Polski.TabIndex = 30
        '
        'L_Pick_English
        '
        Me.L_Pick_English.BackColor = System.Drawing.Color.Red
        Me.L_Pick_English.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Pick_English.Location = New System.Drawing.Point(8, 97)
        Me.L_Pick_English.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Pick_English.Name = "L_Pick_English"
        Me.L_Pick_English.Size = New System.Drawing.Size(20, 22)
        Me.L_Pick_English.TabIndex = 29
        '
        'R_English
        '
        Me.R_English.Appearance = System.Windows.Forms.Appearance.Button
        Me.R_English.Location = New System.Drawing.Point(33, 88)
        Me.R_English.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_English.Name = "R_English"
        Me.R_English.Size = New System.Drawing.Size(118, 38)
        Me.R_English.TabIndex = 26
        Me.R_English.Text = "English"
        Me.R_English.UseVisualStyleBackColor = True
        '
        'Timer_Pic
        '
        Me.Timer_Pic.Interval = 50
        '
        'L_PIC_SFTP
        '
        Me.L_PIC_SFTP.BackColor = System.Drawing.Color.Red
        Me.L_PIC_SFTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_PIC_SFTP.Location = New System.Drawing.Point(275, 25)
        Me.L_PIC_SFTP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_PIC_SFTP.Name = "L_PIC_SFTP"
        Me.L_PIC_SFTP.Size = New System.Drawing.Size(20, 22)
        Me.L_PIC_SFTP.TabIndex = 32
        '
        'Check_SFTP
        '
        Me.Check_SFTP.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check_SFTP.Location = New System.Drawing.Point(304, 17)
        Me.Check_SFTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Check_SFTP.Name = "Check_SFTP"
        Me.Check_SFTP.Size = New System.Drawing.Size(171, 35)
        Me.Check_SFTP.TabIndex = 31
        Me.Check_SFTP.Text = "SFTP"
        Me.Check_SFTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check_SFTP.UseVisualStyleBackColor = True
        '
        'Form_Ustawienia
        '
        Me.AcceptButton = Me.Btn_Zapisz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Anuluj
        Me.ClientSize = New System.Drawing.Size(760, 695)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Btn_Anuluj)
        Me.Controls.Add(Me.Btn_Zapisz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form_Ustawienia"
        Me.Text = "Preferences"
        Me.Group_PDF.ResumeLayout(False)
        Me.Group_PDF.PerformLayout()
        CType(Me.Pic_PDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_FTP.ResumeLayout(False)
        Me.Group_FTP.PerformLayout()
        CType(Me.Pic_FTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Group_Destination.ResumeLayout(False)
        Me.Group_Destination.PerformLayout()
        CType(Me.Pic_Destination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Group_FileName.ResumeLayout(False)
        Me.Group_FileName.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Dlugosc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Wybierz_Przyklad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Group_Control_String.ResumeLayout(False)
        Me.Group_Control_String.PerformLayout()
        CType(Me.Pic_Sec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Pozycja_Control_Stringu.ResumeLayout(False)
        Me.Group_Pozycja_Control_Stringu.PerformLayout()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Start1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Dlugosc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Wybierz_Przyklad1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Group_Typ_Automatyzacji.ResumeLayout(False)
        Me.Group_Typ_Automatyzacji.PerformLayout()
        Me.Group_Statystyka.ResumeLayout(False)
        Me.Group_Statystyka.PerformLayout()
        Me.Group_Interval.ResumeLayout(False)
        Me.Group_Interval.PerformLayout()
        CType(Me.Num_Sekundy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Minuty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.SplitC.Panel1.ResumeLayout(False)
        Me.SplitC.Panel2.ResumeLayout(False)
        Me.SplitC.Panel2.PerformLayout()
        CType(Me.SplitC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitC.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.Group_Jezyk.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group_PDF As GroupBox
    Friend WithEvents T_Sciezka_PDF As TextBox
    Friend WithEvents Pic_PDF As PictureBox
    Friend WithEvents Group_FTP As GroupBox
    Friend WithEvents L_Haslo As Label
    Friend WithEvents T_Sciezka_FTP As TextBox
    Friend WithEvents T_Haslo As TextBox
    Friend WithEvents L_Adres As Label
    Friend WithEvents L_Login As Label
    Friend WithEvents Pic_FTP As PictureBox
    Friend WithEvents T_Login As TextBox
    Friend WithEvents Btn_Zapisz As Button
    Friend WithEvents Btn_Anuluj As Button
    Friend WithEvents Wybor_Folderu As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Group_FileName As GroupBox
    Friend WithEvents Num_Dlugosc As NumericUpDown
    Friend WithEvents L_Number_Chars As Label
    Friend WithEvents L_Start_Position As Label
    Friend WithEvents Num_Start As NumericUpDown
    Friend WithEvents R_Podglad As RichTextBox
    Friend WithEvents Pic_Wybierz_Przyklad As PictureBox
    Friend WithEvents Btn_Wybierz_Z_Zaznaczenia As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CommitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents T_Przykladowa_Nazwa As TextBox
    Friend WithEvents T_Suffix As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents T_Prefix As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents L_New_File_Name As Label
    Friend WithEvents T_Klucz As TextBox
    Friend WithEvents L_Specified_Text As Label
    Friend WithEvents L_Opis_Careta As Label
    Friend WithEvents L_Pozycja_Karety As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Group_Control_String As GroupBox
    Friend WithEvents T_Control_String As TextBox
    Friend WithEvents Group_Pozycja_Control_Stringu As GroupBox
    Friend WithEvents L_Specified_Text1 As Label
    Friend WithEvents Num_Start1 As NumericUpDown
    Friend WithEvents T_Klucz1 As TextBox
    Friend WithEvents L_Start_Position1 As Label
    Friend WithEvents Num_Dlugosc1 As NumericUpDown
    Friend WithEvents L_Number_Chars1 As Label
    Friend WithEvents Pic_Wybierz_Przyklad1 As PictureBox
    Friend WithEvents R_Podglad1 As RichTextBox
    Friend WithEvents L_Wybierz_Przyklad1 As Label
    Friend WithEvents L_Pozycja_Karety1 As Label
    Friend WithEvents Btn_Wybierz_Z_Zaznaczenia1 As Button
    Friend WithEvents L_Opis_Careta1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Pic_Sec As PictureBox
    Friend WithEvents Pic As PictureBox
    Friend WithEvents L_Wybierz_Przyklad As Label
    Friend WithEvents Check_FTP As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Num_Minuty As NumericUpDown
    Friend WithEvents Group_Interval As GroupBox
    Friend WithEvents CheckAutomatyzacja As CheckBox
    Friend WithEvents Num_Sekundy As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents T_Interwal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents T_Liczba_Cykli As TextBox
    Friend WithEvents L_Liczba_Cykli As Label
    Friend WithEvents T_Czas_Startu_Automatu As TextBox
    Friend WithEvents L_Start As Label
    Friend WithEvents T_Liczba_Bledow As TextBox
    Friend WithEvents L_Liczba_Bledow As Label
    Friend WithEvents T_Liczba_Zmienionych_Plikow As TextBox
    Friend WithEvents L_Liczba_Zapisanych_Plikow As Label
    Friend WithEvents Group_Statystyka As GroupBox
    Friend WithEvents Group_Typ_Automatyzacji As GroupBox
    Friend WithEvents R_Send As RadioButton
    Friend WithEvents R_Save As RadioButton
    Friend WithEvents L_PIC_Save As Label
    Friend WithEvents L_PIC_Send As Label
    Friend WithEvents Timer_Pic As Timer
    Friend WithEvents L_PIC_Auto As Label
    Friend WithEvents Group_Destination As GroupBox
    Friend WithEvents Check_Rename As CheckBox
    Friend WithEvents T_Sciezka_Destination As TextBox
    Friend WithEvents Pic_Destination As PictureBox
    Friend WithEvents L_PIC_FTP As Label
    Friend WithEvents L_PIC_Rename As Label
    Friend WithEvents L_Pic_Check As Label
    Friend WithEvents Check_Check As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents SplitC As SplitContainer
    Friend WithEvents L_Polowa1 As Label
    Friend WithEvents L_Polowa2 As Label
    Friend WithEvents L_Przyklad As Label
    Friend WithEvents T_Tekst_Na_Stronach As TextBox
    Friend WithEvents L_Pic_Not_Contain As Label
    Friend WithEvents L_Pic_Contain As Label
    Friend WithEvents L_Pic_Pages As Label
    Friend WithEvents L_Pic_Half_PDF As Label
    Friend WithEvents Check_Process_File As CheckBox
    Friend WithEvents L_Pick_Process_File As Label
    Friend WithEvents L_Text_ToFind As Label
    Friend WithEvents R_Half_PDF As RadioButton
    Friend WithEvents R_Pages As RadioButton
    Friend WithEvents R_Not_Contain As RadioButton
    Friend WithEvents R_Contain As RadioButton
    Friend WithEvents L_Pic_Group_Pages As Label
    Friend WithEvents C_Group_Pages As CheckBox
    Friend WithEvents L_Page_Settings_Opis As Label
    Friend WithEvents L_Pic_Duplicates As Label
    Friend WithEvents Check_Duplicates As CheckBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Group_Jezyk As GroupBox
    Friend WithEvents L_Pic_Polski As Label
    Friend WithEvents L_Pick_English As Label
    Friend WithEvents R_English As RadioButton
    Friend WithEvents R_Polski As RadioButton
    Friend WithEvents L_PIC_SFTP As Label
    Friend WithEvents Check_SFTP As CheckBox
End Class
