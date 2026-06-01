Imports System.Runtime.Remoting.Services

Public Class ConnexionForm

    Private placeholderEmail As String = "Ex: nom@mail.com"
    Private placeholderMotdePasse As String = "Entrez votre Mot de Passe"

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

    Private Sub ConnexionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitTextBox(txtbEmailIns, placeholderEmail)
        InitTextBox(txtbMDPIns, placeholderMotdePasse)
    End Sub
End Class
