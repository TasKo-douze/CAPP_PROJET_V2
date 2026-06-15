Public Class InformationsPersonnellesForm

    Private Sub ChargementFormulaire(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNom.Text = ClientConnecte.Nom
        txtPrenom.Text = ClientConnecte.Prenom
        txtDateNaissance.Text = ClientConnecte.DateNaissance.ToString("dd.MM.yyyy")
        numTaille.Value = ClientConnecte.Taille
        numPoids.Value = ClientConnecte.Poids
        txtTelephone.Text = ClientConnecte.Telephone
        txtEmail.Text = ClientConnecte.Email
        txtNumero.Text = ClientConnecte.Numero.ToString()
        txtAdresse.Text = ClientConnecte.Rue
        txtVille.Text = ClientConnecte.Ville
    End Sub



    Private Sub ValidationNumero(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



    Private Sub ValidationRue(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub


    Private Sub ValidationVille(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub BoutonValider(sender As Object, e As EventArgs) Handles btnValide.Click
        ' ... tes validations restent identiques ...

        DataAccess.UpdateCoordonnees(
        ClientConnecte.Email,      ' ← REMPLACE ConnexionForm.txtbEmail.Text
        txtTelephone.Text,
        txtEmail.Text,
        txtAdresse.Text,
        txtNumero.Text,
        txtVille.Text
    )

        ClientConnecte.Email = txtEmail.Text   ' ← AJOUTE cette ligne

        MessageBox.Show("Informations mises à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub grpInfosPerso_Enter(sender As Object, e As EventArgs) Handles grpInfosPerso.Enter

    End Sub
End Class