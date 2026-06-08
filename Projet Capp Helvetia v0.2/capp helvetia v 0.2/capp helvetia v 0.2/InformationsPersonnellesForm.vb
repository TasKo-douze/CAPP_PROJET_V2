Public Class InformationsPersonnellesForm

    Private Sub ChargementFormulaire(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infos = DataAccess.GetClientByEmail(ConnexionForm.txtbEmail.Text)

        If infos.Count > 0 Then
            Dim client = infos(0)

            txtPrenom.Text = client("CLI_PRENOM").ToString()

            txtNom.Text = client("CLI_NOM").ToString()

            txtDateNaissance.Text = Convert.ToDateTime(client("CLI_DATE_NAISSANCE")).ToString("dd.MM.yyyy")

            numPoids.Value = Convert.ToDecimal(client("CLI_POIDS"))

            numTaille.Value = Convert.ToDecimal(client("CLI_TAILLE"))

            txtTelephone.Text = client("CLI_TEL").ToString()

            txtEmail.Text = client("CLI_EMAIL").ToString()

            txtNumero.Text = client("ADR_NUM").ToString()

            txtAdresse.Text = client("ADR_RUE").ToString()

            txtVille.Text = client("ADR_VILLE").ToString()
        End If
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