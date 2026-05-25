Public Class InformationsPersonnellesForm

    Private Sub InformationsPersonnellesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' récupère les informations du client connecté avec son email
        Dim client = DataAccess.GetClientByEmail(ConnexionForm.txtbEmail.Text)

        ' vérifie si le client existe
        If client.Count > 0 Then

            ' affiche le prénom
            txtPrenom.Text = client(0)("CLI_PRENOM").ToString()

            ' affiche le nom
            txtNom.Text = client(0)("CLI_NOM").ToString()

            ' affiche la date de naissance
            txtDateNaissance.Text = client(0)("CLI_DATE_NAISSANCE").ToString()

            ' affiche le poids
            numPoids.Value = CDec(client(0)("CLI_POIDS"))

            ' affiche la taille
            numTaille.Value = CDec(client(0)("CLI_TAILLE"))

            ' affiche le téléphone
            txtTelephone.Text = client(0)("CLI_TEL").ToString()

            ' affiche l'email
            txtEmail.Text = client(0)("CLI_EMAIL").ToString()

            ' affiche l'adresse
            txtAdresse.Text = client(0)("ADR_RUE").ToString() & " " &
                              client(0)("ADR_NUM").ToString() & ", " &
                              client(0)("ADR_VILLE").ToString() & ", " &
                              client(0)("ADR_PAYS").ToString()

        End If

    End Sub

End Class