Public Class AccueilForm
    Private Sub AccueilForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        DessinerDegrade(Me, e)

    End Sub

    Private Sub btnHistoriques_Click(sender As Object, e As EventArgs) Handles btnHistoriques.Click
        Historique.Show()
        Me.Hide()
    End Sub

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click
        ReservationForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        ProfilForm.Show()
        Me.Hide()
    End Sub

    Private Sub lnklDeconnexion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklDeconnexion.LinkClicked
        Dim reponse As DialogResult = MessageBox.Show(
            "Voulez-vous vraiment vous déconnecter ?",
            "Déconnexion",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question
   )

        If reponse = DialogResult.OK Then

            ClientConnecte.Deconnecter()

            ConnexionForm.Show()
            Me.Hide()

            MessageBox.Show("Déconnexion réussie !", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class