Public Class SecuriteForm

    Private Sub txtOldMdp_TextChanged(sender As Object, e As EventArgs) Handles txtOldMdp.TextChanged
        CheckForm()
    End Sub

    Private Sub txtNewMdp_TextChanged(sender As Object, e As EventArgs) Handles txtNewMdp.TextChanged
        CheckForm()
    End Sub

    Private Sub txtValidationMdp_TextChanged(sender As Object, e As EventArgs) Handles txtValidationMdp.TextChanged
        CheckForm()
    End Sub

    Private Sub CheckForm()

        ' bouton activé seulement si tous les champs sont remplis
        If txtOldMdp.Text <> "" And txtNewMdp.Text <> "" And txtValidationMdp.Text <> "" Then
            btnValider.Enabled = True
        Else
            btnValider.Enabled = False
        End If

    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click

        Dim mdp As String = txtNewMdp.Text

        Dim aMaj As Boolean = False
        Dim aMin As Boolean = False
        Dim aChiffre As Boolean = False

        For Each c As Char In mdp
            If Char.IsUpper(c) Then aMaj = True
            If Char.IsLower(c) Then aMin = True
            If Char.IsDigit(c) Then aChiffre = True
        Next

        If aMaj And aMin And aChiffre And (txtNewMdp.Text = txtValidationMdp.Text) Then
            MessageBox.Show("Validé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Erreur : mot de passe invalide ou non identique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub securite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class