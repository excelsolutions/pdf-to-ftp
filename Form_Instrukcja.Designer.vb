<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Instrukcja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Instrukcja))
        Me.Rich_Manual = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Rich_Manual
        '
        Me.Rich_Manual.Location = New System.Drawing.Point(12, 12)
        Me.Rich_Manual.Name = "Rich_Manual"
        Me.Rich_Manual.Size = New System.Drawing.Size(1176, 653)
        Me.Rich_Manual.TabIndex = 1
        Me.Rich_Manual.Text = ""
        '
        'Form_Instrukcja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 682)
        Me.Controls.Add(Me.Rich_Manual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Instrukcja"
        Me.Text = "Form_Instrukcja"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rich_Manual As RichTextBox
End Class
