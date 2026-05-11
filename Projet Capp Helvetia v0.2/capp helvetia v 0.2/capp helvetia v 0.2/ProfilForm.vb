Public Class ProfilForm

    ' Lier le bouton "Informations personnelles" avec la fenêtre correspondante
    Private Sub btnInformationsPersonnelles_Click(sender As Object, e As EventArgs) Handles btnInformationsPersonnelles.Click
        Dim affiche As New InformationsPersonnellesForm
        affiche.Show()
    End Sub

    ' Lier le bouton "A Propos" avec la fenêtre correspondante
    Private Sub btnAPropos_Click(sender As Object, e As EventArgs) Handles btnConfidentialiteDonner.Click
        Dim affiche As New ConfidentialiteDonneesForm
        affiche.Show()
    End Sub

    ' Lier le bouton "Confidentialite" avec la fenêtre correspondante
    Private Sub btnConfidentialite_Click(sender As Object, e As EventArgs) Handles btnAPropos.Click
        Dim affiche As New AProposForm
        affiche.Show()
    End Sub

    Private Sub btnSecurite_Click(sender As Object, e As EventArgs) Handles btnSecurite.Click
        Dim affiche As New SecuriteForm
        affiche.Show()
    End Sub


End Class