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


    ' Prix
    Private PRIXPARPASSAGER As Double = 150
    Public PrixBase As Double
    Public SupplementBagages As Double
    Public PrixTotal As Double

    Private Sub RecapitulatifForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDepart.Text = VilleDepart
        txtArriver.Text = VilleArrivee

        dtpDateReservation.Value = DateReservation

        txtNbPassager.Text = NbPassagers.ToString()

        txtNom.Text = ClientNom
        txtPrenom.Text = ClientPrenom
        txtEmail.Text = ClientEmail
        txtTelephone.Text = ClientTelephone

        txtPoids.Text = ClientPoids & " kg"
        txtTaille.Text = ClientTaille & " cm"
        ChargerReservation()
    End Sub
    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click
        ' Message indiquant la réussite de la réservation et du paiement
        MessageBox.Show("La réservation a été effectuée et le paiement a été effectué avec succès.", "Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub



    Private Sub ChargerReservation()

        ' Affichage réservation

        txtDepart.Text = VilleDepart
        txtArriver.Text = VilleArrivee

        dtpDateReservation.Value = DateReservation

        txtNbPassager.Text = NbPassagers.ToString()

        txtNbBagage.Text = NbBagages.ToString()

        ' Prix : 150 CHF par passager
        PrixBase = NbPassagers * PRIXPARPASSAGER

        PrixTotal = PrixBase + SupplementBagages

        lblPrix.Text = PrixTotal.ToString("0.00") & " CHF"

    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        'bouton pour revenir à la page précédente (DetailsPassagerForm)
        Dim form As New DetailsPassagerForm()
        form.Show()
        Close()
    End Sub
End Class
