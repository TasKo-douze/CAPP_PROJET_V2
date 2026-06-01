Imports System.Drawing.Drawing2D

Public Class AccueilForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackColor = Color.White
    End Sub


    ' procédure pour crée le dégradé de couleur 
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim brush As New LinearGradientBrush(Me.ClientRectangle,
                                             Color.LightCoral,   ' rouge clair
                                             Color.SlateGray,    ' bleu gris
                                             LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, Me.ClientRectangle)
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
        MessageBox.Show("Continuez sur OK pour poursuivre la déconnexion !")
        ConnexionForm.Show()
        Me.Hide()
        MessageBox.Show("Déconnexion réussite !")
    End Sub
End Class