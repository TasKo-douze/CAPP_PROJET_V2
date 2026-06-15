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

        ' Active le bouton seulement si les 3 champs sont remplis
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

        ' Vérifie la composition du nouveau mot de passe
        For Each c As Char In mdp
            If Char.IsUpper(c) Then aMaj = True
            If Char.IsLower(c) Then aMin = True
            If Char.IsDigit(c) Then aChiffre = True
        Next

        If Not (aMaj And aMin And aChiffre) Then
            MessageBox.Show("Le mot de passe doit contenir une majuscule, une minuscule et un chiffre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Vérifie que les deux nouveaux mots de passe sont identiques
        If txtNewMdp.Text <> txtValidationMdp.Text Then
            MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Vérifie l'ancien mot de passe
        Dim ok As Boolean = DataAccess.VerifierAncienMdp(ConnexionForm.txtbEmail.Text, txtOldMdp.Text)

        If Not ok Then
            MessageBox.Show("L'ancien mot de passe est incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Met à jour le mot de passe dans la base
        DataAccess.UpdateMotDePasse(ConnexionForm.txtbEmail.Text, txtNewMdp.Text)

        MessageBox.Show("Le mot de passe a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()

    End Sub

    Private Sub SecuriteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class