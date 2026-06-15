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

        ' Autorise uniquement les chiffres
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ValidationAdresse(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress

        ' Autorise uniquement les chiffres
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ValidationVille(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress

        ' Autorise uniquement les chiffres
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ValidationTelephone(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress

        ' Autorise uniquement les chiffres et affiche un message d'erreur
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then

            MessageBox.Show("Le numéro de téléphone ne peut contenir que des chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Handled = True

        End If

    End Sub

    Private Sub ValidationEmail(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress

        ' Autorise uniquement les lettres et le symbole @
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "@" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub BoutonValider(sender As Object, e As EventArgs) Handles btnValide.Click

        DataAccess.UpdateCoordonnees(
            ClientConnecte.Email,
            txtTelephone.Text,
            txtEmail.Text,
            txtAdresse.Text,
            txtNumero.Text,
            txtVille.Text
        )

        ClientConnecte.Email = txtEmail.Text

        MessageBox.Show("Informations mises à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub grpInfosPerso_Enter(sender As Object, e As EventArgs) Handles grpInfosPerso.Enter

    End Sub

End Class