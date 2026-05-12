Public Class Inscription1
    Private Sub btnSuivantIns1_Click(sender As Object, e As EventArgs) Handles btnSuivantIns1.Click

        If txtbNom.Text.Trim() = "" Or
           txtbPrenom.Text.Trim() = "" Or
           txtbRue.Text.Trim() = "" Or
           txtbVille.Text.Trim() = "" Or
           txtbNumero.Text.Trim() = "" Then

            MessageBox.Show("Veuillez remplir tous les champs")
            Exit Sub

        End If

        If Not IsNumeric(txtbNumero.Text) Then
            MessageBox.Show("Le numéro de rue doit être un nombre")
            Exit Sub
        End If

        'pour que les informations soient enregistrées
        Dim page2 As New Inscription2(
            txtbNom.Text.Trim(),
            txtbPrenom.Text.Trim(),
            txtbRue.Text.Trim(),
            txtbVille.Text.Trim(),
            CInt(txtbNumero.Text)
        )

        page2.Show()
        Me.Hide()


    End Sub
End Class