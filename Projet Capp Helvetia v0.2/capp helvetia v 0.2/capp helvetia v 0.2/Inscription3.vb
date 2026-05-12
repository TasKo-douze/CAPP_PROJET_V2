Imports capp_helvetia_v_0._2.Inscription3

Public Class Inscription3


    Private nom As String
        Private prenom As String
        Private rue As String
        Private ville As String
        Private numero As Integer
        Private email As String
    Private telephone As String
    Private motdepasse As String

    Public Sub New(nomClient As String,
                   prenomClient As String,
                   rueClient As String,
                   villeClient As String,
                   numeroClient As Integer,
                   emailClient As String,
                   telephoneClient As String,
                   motdepasseClient As String)

        InitializeComponent()

        nom = nomClient
        prenom = prenomClient
        rue = rueClient
        ville = villeClient
        numero = numeroClient
        email = emailClient
        telephone = telephoneClient
        motdepasse = motdepasseClient

    End Sub

    Private Sub btnValiderIns_Click(sender As Object, e As EventArgs) Handles btnValiderIns.Click

        If txtbPoids.Text.Trim() = "" Or txtbTaille.Text.Trim() = "" Then

            MessageBox.Show("Veuillez remplir tous les champs")
            Exit Sub

        End If

        If Not IsNumeric(txtbPoids.Text) Then

            MessageBox.Show("Le poids doit être un nombre")
            Exit Sub

        End If

        If Not IsNumeric(txtbTaille.Text) Then

            MessageBox.Show("La taille doit être un nombre")
            Exit Sub

        End If

        Dim poids As Integer = CInt(txtbPoids.Text)
        Dim taille As Integer = CInt(txtbTaille.Text)
        Dim dateNaissance As Date = dtpDateNaiss.Value

        If taille > 200 Then

            MessageBox.Show("Taille invalide")
            Exit Sub

        End If

        If poids > 100 Then

            MessageBox.Show("Poids invalide")
            Exit Sub

        End If

        Dim ok As Boolean = DataAccess.InscriptionClient(
        nom,
        prenom,
        telephone,
        email,
        motdepasse,
        dateNaissance,
        taille,
        poids,
        rue,
        ville,
        numero
    )

        If ok Then


            AccueilForm.Show()

            Me.Hide()

        Else

            MessageBox.Show("Erreur inscription")

        End If

    End Sub

End Class






