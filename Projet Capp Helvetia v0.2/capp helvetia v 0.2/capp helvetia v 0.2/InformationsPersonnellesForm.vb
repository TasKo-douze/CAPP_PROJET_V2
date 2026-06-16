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

    Private Sub ValidationAdresse(sender As Object, e As KeyPressEventArgs) Handles txtAdresse.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidationVille(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidationTelephone(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValidationEmail(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> "@"c AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> "_"c AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Function ValiderTelephone(tel As String) As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^\+41\.\d{2}\.\d{3}\.\d{2}\.\d{2}$")
        Return regex.IsMatch(tel)
    End Function

    Private Function ValiderEmail(email As String) As Boolean
        Dim posAt As Integer = email.IndexOf("@")
        If posAt < 1 Then Return False
        Dim domaine As String = email.Substring(posAt + 1)
        Return domaine.Contains(".") AndAlso Not domaine.StartsWith(".") AndAlso Not domaine.EndsWith(".")
    End Function

    Private Sub BoutonValider(sender As Object, e As EventArgs) Handles btnValide.Click
        If Not ValiderTelephone(txtTelephone.Text) Then
            MessageBox.Show("Le numéro de téléphone doit être au format +41.xx.xxx.xx.xx (ex: +41.79.123.45.67).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelephone.Focus()
            Exit Sub
        End If

        If Not ValiderEmail(txtEmail.Text) Then
            MessageBox.Show("L'adresse email doit contenir un @ et un domaine valide (ex: nom@exemple.ch).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtAdresse.Text) Then
            MessageBox.Show("L'adresse ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdresse.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtVille.Text) Then
            MessageBox.Show("La ville ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVille.Focus()
            Exit Sub
        End If

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