<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_O_Mnie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_O_Mnie))
        Me.Btn_Zamknij = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkWWW = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_Wersja = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Zamknij
        '
        Me.Btn_Zamknij.Location = New System.Drawing.Point(170, 360)
        Me.Btn_Zamknij.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Zamknij.Name = "Btn_Zamknij"
        Me.Btn_Zamknij.Size = New System.Drawing.Size(248, 54)
        Me.Btn_Zamknij.TabIndex = 0
        Me.Btn_Zamknij.Text = "Close"
        Me.Btn_Zamknij.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 80)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Program for changing names of pdf according to string from inside of pdf file. Pr" &
    "ogram can also send changed pdf file to FTP."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 109)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About program"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkWWW)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 211)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 139)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'LinkWWW
        '
        Me.LinkWWW.AutoSize = True
        Me.LinkWWW.Location = New System.Drawing.Point(67, 73)
        Me.LinkWWW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkWWW.Name = "LinkWWW"
        Me.LinkWWW.Size = New System.Drawing.Size(308, 20)
        Me.LinkWWW.TabIndex = 7
        Me.LinkWWW.TabStop = True
        Me.LinkWWW.Text = "https://github.com/excelsolutions/pdf-to-ftp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "www:"
        '
        'L_Wersja
        '
        Me.L_Wersja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.L_Wersja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L_Wersja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.L_Wersja.ForeColor = System.Drawing.Color.Blue
        Me.L_Wersja.Location = New System.Drawing.Point(4, 24)
        Me.L_Wersja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Wersja.Name = "L_Wersja"
        Me.L_Wersja.Size = New System.Drawing.Size(390, 45)
        Me.L_Wersja.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.L_Wersja)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 128)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(398, 74)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'Form_O_Mnie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 428)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Zamknij)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_O_Mnie"
        Me.Text = "About program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Zamknij As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LinkWWW As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents L_Wersja As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
