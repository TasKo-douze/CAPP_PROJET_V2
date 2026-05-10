Public Class RecapitulatifForm

    ' Informations réservation

    Public VilleDepart As String
    Public VilleArrivee As String
    Public DateReservation As Date
    Public NbPassagers As Integer
    Public NbBagages As Integer

    ' Informations client

    Public ClientNom As String
    Public ClientPrenom As String
    Public ClientEmail As String
    Public ClientTelephone As String

    Public ClientPoids As Integer
    Public ClientTaille As Integer

    Private Sub RecapitulatifForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerClient()
        ChargerReservation()
    End Sub
    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click
        ' Message indiquant la réussite de la réservation et du paiement
        MessageBox.Show("La réservation a été effectuée et le paiement a été effectué avec succès.", "Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Sub ChargerClient()

        Dim lstClients = DataAccess.GetClient()

        If lstClients.Count > 0 Then
            ' Récupérer les données du client
            Dim client = lstClients(0)

            ClientNom = client("CLI_NOM").ToString()
            ClientPrenom = client("CLI_PRENOM").ToString()
            ClientEmail = client("CLI_EMAIL").ToString()
            ClientTelephone = client("CLI_TEL").ToString()

            ' Fake pour l'instant
            ClientPoids = 75
            ClientTaille = 180

            ' Affichage dans form

            txtNom.Text = ClientNom
            txtPrenom.Text = ClientPrenom
            txtEmail.Text = ClientEmail
            txtTelephone.Text = ClientTelephone

            txtPoids.Text = ClientPoids.ToString() & " kg"
            txtTaille.Text = ClientTaille.ToString() & " cm"

        Else
            ' Si aucun client n'est trouvé, afficher un message d'erreur
            MessageBox.Show("Client introuvable")

        End If

    End Sub

    Private Sub ChargerReservation()

        ' DONNÉES TEMPORAIRES
        ' a remplacer par les données de la réservation en cours de samir
        VilleDepart = "Genève"
        VilleArrivee = "Zurich"
        'date de reservation 
        DateReservation = New Date(2026, 5, 15)
        ' DateReservation = ReservationForm.dtpDate.Value

        NbPassagers = 2
        NbBagages = 2

        Dim prix As Decimal = 450

        ' AFFICHAGE

        txtDepart.Text = VilleDepart
        txtArriver.Text = VilleArrivee

        dtpDateReservation.Value = DateReservation

        txtNbPassager.Text = NbPassagers.ToString()
        txtNbBagage.Text = NbBagages.ToString()

        lblPrix.Text = prix.ToString() & " CHF"

    End Sub



End Class
