Public Class Inscription2
    '
    ' Variables, plus garder les informations des pages précédentes
    Private nom As String
    Private prenom As String
    Private rue As String
    Private ville As String
    Private numero As Integer


    ' Constructeur est une fonction spéciale qui s’exécute automatiquement quand tu crées une fenêtre ou un objet.
    Public Sub New(nomClient As String,
                   prenomClient As String,
                   rueClient As String,
                   villeClient As String,
                   numeroClient As Integer)

        InitializeComponent()

        nom = nomClient
        prenom = prenomClient
        rue = rueClient
        ville = villeClient
        numero = numeroClient

    End Sub
    Private Sub btnSuivantIns_Click(sender As Object, e As EventArgs) Handles btnSuivantIns.Click




        Dim email As String = txtbEmail.Text.Trim()
        Dim telephone As String = txtbTelephone.Text.Trim()
        Dim motdepasse As String = txtbMDPIns.Text.Trim()

        If Not email.Contains("@") Or Not email.Contains(".") Then
            MessageBox.Show("Email invalide")
            Exit Sub
        End If

        If Not telephone Like "+41.##.###.##.##" Then
            MessageBox.Show("Téléphone invalide")
            Exit Sub

        End If

        If motdepasse = "" Then

            MessageBox.Show("Veuillez entrer un mot de passe")
            Exit Sub
        End If

        Dim page3 As New Inscription3(
            nom,
            prenom,
            rue,
            ville,
            numero,
            email,
            telephone,
            motdepasse
        )

        page3.Show()
        Me.Hide()

    End Sub


End Class