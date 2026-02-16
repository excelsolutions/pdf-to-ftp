Public Class Form_Instrukcja
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_Instrukcja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rich_Manual.LoadFile("Instrukcja.rtf")
    End Sub

    Private Sub Rich_Manual_TextChanged(sender As Object, e As EventArgs) Handles Rich_Manual.TextChanged

    End Sub
End Class