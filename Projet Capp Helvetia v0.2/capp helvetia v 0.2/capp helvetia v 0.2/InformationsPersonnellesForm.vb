Public Class InformationsPersonnellesForm

    Private Sub ChargementFormulaire(sender As Object, e As EventArgs) Handles MyBase.Load

        Nom = ClientConnecte.Nom
        Prenom = ClientConnecte.Prenom
        DateNaissance = ClientConnecte.DateNaissance
        Taille = ClientConnecte.Taille
        Poids = ClientConnecte.Poids
        Telephone = ClientConnecte.Telephone
        Email = ClientConnecte.Email



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

    ' Bouton Valider - met à jour le téléphone, email et adresse du client dans la BDD
    Private Sub BoutonValider(sender As Object, e As EventArgs) Handles btnValide.Click


        If txtAdresse.Text Like "*[0-9]*" Then
            MessageBox.Show("La rue ne peut pas contenir de chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If txtVille.Text Like "*[0-9]*" Then
            MessageBox.Show("La ville ne peut pas contenir de chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If txtNumero.Text Like "*[!0-9]*" Then
            MessageBox.Show("Le numéro ne peut pas contenir de lettres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        DataAccess.UpdateCoordonnees(
            ConnexionForm.txtbEmail.Text,
            txtTelephone.Text,
            txtEmail.Text,
            txtAdresse.Text,
            txtNumero.Text,
            txtVille.Text
        )
        MessageBox.Show("Informations mises à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class