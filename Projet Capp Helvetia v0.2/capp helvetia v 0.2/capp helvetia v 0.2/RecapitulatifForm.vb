Public Class RecapitulatifForm

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click
        ' Message indiquant la réussite de la réservation et du paiement
        MessageBox.Show("La réservation a été effectuée et le paiement a été effectué avec succès.", "Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub
End Class
