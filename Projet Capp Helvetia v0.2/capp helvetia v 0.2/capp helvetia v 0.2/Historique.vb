Public Class Historique

    Private Sub Historique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerHistorique()
    End Sub

    Private Sub ChargerHistorique()

        pnlHistorique.Controls.Clear()

        If ClientConnecte.EstConnecte = False Then

            Dim lbl As New Label()
            lbl.Text = "Aucun client connecté."
            lbl.Font = New Font("Arial", 14, FontStyle.Bold)
            lbl.AutoSize = True
            lbl.Location = New Point(20, 20)

            pnlHistorique.Controls.Add(lbl)

            Exit Sub

        End If

        Dim lstReservations = DataAccess.GetHistoriqueVols()

        Dim lblTitre As New Label()
        lblTitre.Text = "Historique de " & ClientConnecte.Prenom & " " & ClientConnecte.Nom
        lblTitre.Font = New Font("Arial", 16, FontStyle.Bold)
        lblTitre.AutoSize = True
        lblTitre.Location = New Point(10, 10)

        pnlHistorique.Controls.Add(lblTitre)

        Dim lblResume As New Label()
        lblResume.Text = "Nombre de réservations : " & lstReservations.Count
        lblResume.Font = New Font("Arial", 12)
        lblResume.AutoSize = True
        lblResume.Location = New Point(10, 40)

        pnlHistorique.Controls.Add(lblResume)

        If lstReservations.Count = 0 Then

            Dim lbl As New Label()
            lbl.Text = "Vous n'avez pas encore fait de réservation."
            lbl.Font = New Font("Arial", 14, FontStyle.Bold)
            lbl.AutoSize = True
            lbl.Location = New Point(20, 90)

            pnlHistorique.Controls.Add(lbl)

            Exit Sub

        End If

        Dim yPosition As Integer = 90

        For Each reservation In lstReservations

            Dim group As New GroupBox()

            group.Text = "Réservation #" & reservation("RES_ID").ToString()
            group.Font = New Font("Arial", 12, FontStyle.Bold)

            group.Location = New Point(10, yPosition)
            group.Size = New Size(650, 260)

            pnlHistorique.Controls.Add(group)

            Dim yInside As Integer = 30

            AjouterLabel(group, "Départ :", reservation("VILLE_DEPART").ToString(), yInside)
            AjouterLabel(group, "Arrivée :", reservation("VILLE_ARRIVEE").ToString(), yInside)

            AjouterLabel(
            group,
            "Date réservation :",
            Convert.ToDateTime(reservation("RES_DATE_RESERVATION")).ToShortDateString(),
            yInside
        )

            AjouterLabel(
            group,
            "Nombre passagers :",
            reservation("RES_NOMBRE_PASSAGERS_ESTIME").ToString(),
            yInside
        )

            AjouterLabel(
            group,
            "Durée estimée :",
            reservation("RES_DUREEESTIME").ToString() & " min",
            yInside
        )

            AjouterLabel(
            group,
            "Statut :",
            reservation("RES_STATUT").ToString(),
            yInside
        )

            AjouterLabel(
            group,
            "Montant payé :",
            reservation("RES_ACCOMPTE").ToString() & " CHF",
            yInside
        )

            yPosition += 280

        Next


    End Sub

    Private Sub AjouterLabel(parent As Control, titre As String, valeur As String, ByRef y As Integer)

        Dim lblTitre As New Label()
        lblTitre.Text = titre
        lblTitre.Font = New Font("Arial", 12)
        lblTitre.Location = New Point(10, y)
        lblTitre.AutoSize = True

        Dim lblValeur As New Label()
        lblValeur.Text = valeur
        lblValeur.Font = New Font("Arial", 12)
        lblValeur.Location = New Point(220, y)
        lblValeur.AutoSize = True

        parent.Controls.Add(lblTitre)
        parent.Controls.Add(lblValeur)

        y += 30

    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Dim form As New AccueilForm()
        form.Show()
        Close()
    End Sub
End Class