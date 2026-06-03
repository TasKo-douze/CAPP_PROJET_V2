Public Class ReservationForm

    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Charge les villes dans les deux ComboBox au démarrage
        ChargerVillesDepart()
        ChargerVillesArrivee()

    End Sub

    Private Sub ChargerVillesDepart()

        ' Récupère les villes et les affiche dans la ComboBox de départ
        Dim lstVilles = DataAccess.GetVilles()

        cbmVilleDepart.Items.Clear()

        For Each ville In lstVilles
            cbmVilleDepart.Items.Add(ville("VIL_NOM"))
        Next

    End Sub

    Private Sub ChargerVillesArrivee()

        ' Récupère les villes et les affiche dans la ComboBox d'arrivée
        Dim lstVilles = DataAccess.GetVilles()

        cbmVilleArriver.Items.Clear()

        For Each ville In lstVilles
            cbmVilleArriver.Items.Add(ville("VIL_NOM"))
        Next

    End Sub



    Private Sub dtpDateDepart_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateDepart.ValueChanged

        ' Vérifie si la date choisie est déjà passée
        If dtpDateDepart.Value.Date < Date.Today Then

            ' Affiche un message d'erreur pour une date passée
            MessageBox.Show("Vous ne pouvez pas sélectionner une date déjà passée.")

            ' Remet automatiquement la date à aujourd'hui + 2 jours
            dtpDateDepart.Value = Date.Today.AddDays(2)

            ' Vérifie si la date choisie est à moins de 48h
        ElseIf dtpDateDepart.Value.Date < Date.Today.AddDays(2) Then

            ' Affiche un message d'erreur pour le délai de 48h
            MessageBox.Show("La réservation doit être effectuée au minimum 48h avant le trajet.")

            ' Remet automatiquement la date à aujourd'hui + 2 jours
            dtpDateDepart.Value = Date.Today.AddDays(2)

        End If

    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        ' Condition pour pouvoir passer à la suite
        If cbmVilleDepart.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une ville de départ.")
            Return
        End If

        If cbmVilleArriver.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une ville d'arrivée.")
            Return
        End If

        ' Bouton pour passer à la page de détails des passagers


        Dim form As New DetailsPassagerForm()

        form.VilleDepart = cbmVilleDepart.Text
        form.VilleArrivee = cbmVilleArriver.Text
        form.DateReservation = dtpDateDepart.Value
        form.NbPassagers = CInt(cbmNbPassager.Text)


        form.Show()
        Close()

    End Sub

    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        ' Retour à la page d'accueil
        Dim form As New AccueilForm
        form.Show()
        Close()

    End Sub

    Private Sub pnlReservation_Paint(sender As Object, e As PaintEventArgs) Handles pnlReservation.Paint

    End Sub
End Class