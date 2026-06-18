Public Class RecapitulatifForm


    Public VilleDepart As String
    Public VilleArrivee As String
    Public DateReservation As Date
    Public NbPassagers As Integer
    Public NbBagages As Integer


    Public ClientNom As String
    Public ClientPrenom As String
    Public ClientEmail As String
    Public ClientTelephone As String
    Public ClientPoids As Integer
    Public ClientTaille As Integer


    Private PRIXPARPASSAGER As Double = 150
    Public PrixBase As Double
    Public SupplementBagages As Double
    Public PrixTotal As Double

    ''' <summary>
    ''' charge les informations de la réservation dans le formulaire lors du chargement de celui-ci
    ''' </summary>

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

    ''' <summary>
    ''' recupère les informations de la réservation et les enregistre dans la base de données
    ''' </summary>

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click




        Try
            DataAccess.InsertReservation(VilleDepart, VilleArrivee, DateReservation, NbPassagers, PrixTotal)

            MessageBox.Show("La réservation a été effectuée et le paiement a été effectué avec succès.", "Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
            AccueilForm.Show()

        Catch ex As Exception

            MessageBox.Show("Erreur lors de l'enregistrement de la réservation : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    ''' <summary>
    ''' affiche les informations de la réservation dans les champs correspondants du formulaire
    ''' </summary>
    Private Sub ChargerReservation()


        txtDepart.Text = VilleDepart
        txtArriver.Text = VilleArrivee

        dtpDateReservation.Value = DateReservation

        txtNbPassager.Text = NbPassagers.ToString()

        txtNbBagage.Text = NbBagages.ToString()

        PrixBase = NbPassagers * PRIXPARPASSAGER

        PrixTotal = PrixBase + SupplementBagages

        lblPrix.Text = PrixTotal.ToString("0.00") & " CHF"

    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Dim form As New DetailsPassagerForm()
        form.VilleDepart = VilleDepart
        form.VilleArrivee = VilleArrivee
        form.DateReservation = DateReservation
        form.NbPassagers = NbPassagers
        form.Show()
        Close()
    End Sub
End Class
