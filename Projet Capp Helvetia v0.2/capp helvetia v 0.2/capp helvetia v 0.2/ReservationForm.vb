Public Class ReservationForm

    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargerVillesDepart()
        ChargerVillesArrivee()

        ' Empêche la sélection d'une date inférieure à aujourd'hui + 48h
        dtpDateDepart.MinDate = Date.Today.AddDays(2)

        ' Sélectionne automatiquement aujourd'hui + 48h
        dtpDateDepart.Value = Date.Today.AddDays(2)

    End Sub

    Private Sub ChargerVillesDepart()

        Dim lstVilles = DataAccess.GetVilles()

        cbmVilleDepart.Items.Clear()

        For Each ville As Dictionary(Of String, Object) In lstVilles
            cbmVilleDepart.Items.Add(ville("VIL_NOM").ToString())
        Next

    End Sub

    Private Sub ChargerVillesArrivee()

        Dim lstVilles = DataAccess.GetVilles()

        cbmVilleArriver.Items.Clear()

        For Each ville As Dictionary(Of String, Object) In lstVilles
            cbmVilleArriver.Items.Add(ville("VIL_NOM").ToString())
        Next

    End Sub

    Private Sub dtpDateDepart_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateDepart.ValueChanged

        ' Vérifie si la date choisie est à moins de 48h
        If dtpDateDepart.Value.Date < Date.Today.AddDays(2) Then

            MessageBox.Show("La réservation doit être effectuée au minimum 48h avant le trajet.")

            dtpDateDepart.Value = Date.Today.AddDays(2)

        End If

    End Sub

    Private Sub cbmVilleDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmVilleDepart.SelectedIndexChanged

        ' Vérifie si la ville de départ est la même que la ville d'arrivée
        If cbmVilleDepart.Text = cbmVilleArriver.Text And cbmVilleDepart.Text <> "" Then

            MessageBox.Show("La ville de départ et la ville d'arrivée doivent être différentes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            cbmVilleDepart.SelectedIndex = -1

        End If

    End Sub

    Private Sub cbmVilleArriver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmVilleArriver.SelectedIndexChanged

        ' Vérifie si la ville d'arrivée est la même que la ville de départ
        If cbmVilleArriver.Text = cbmVilleDepart.Text And cbmVilleArriver.Text <> "" Then

            MessageBox.Show("La ville de départ et la ville d'arrivée doivent être différentes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            cbmVilleArriver.SelectedIndex = -1

        End If

    End Sub

    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        If cbmVilleDepart.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une ville de départ.")
            Return
        End If

        If cbmVilleArriver.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une ville d'arrivée.")
            Return
        End If

        If cbmVilleDepart.SelectedItem.ToString() = cbmVilleArriver.SelectedItem.ToString() Then
            MessageBox.Show("La ville de départ et d'arrivée ne peuvent pas être identiques.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim form As New DetailsPassagerForm()

        form.VilleDepart = cbmVilleDepart.Text
        form.VilleArrivee = cbmVilleArriver.Text
        form.DateReservation = dtpDateDepart.Value
        form.NbPassagers = CInt(cbmNbPassager.Text)

        form.Show()

        Close()

    End Sub

    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        Dim form As New AccueilForm

        form.Show()

        Close()

    End Sub

    Private Sub pnlReservation_Paint(sender As Object, e As PaintEventArgs) Handles pnlReservation.Paint

    End Sub

End Class