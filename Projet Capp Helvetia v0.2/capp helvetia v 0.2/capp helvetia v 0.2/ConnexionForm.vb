Public Class ConnexionForm


    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click

        Dim email As String = txtbEmail.Text.Trim()
        Dim motdepasse As String = txtbMDP.Text.Trim()


        Dim ok As Boolean = DataAccess.Connexion(txtbEmail.Text, txtbMDP.Text)

        If ok Then

            AccueilForm.Show()
            Me.Hide()

        Else

            MessageBox.Show("Erreur identifiants")

        End If

    End Sub


    Private Sub lnklblInscription_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblInscription.LinkClicked
        Inscription1.Show()
        Me.Hide()
    End Sub




End Class