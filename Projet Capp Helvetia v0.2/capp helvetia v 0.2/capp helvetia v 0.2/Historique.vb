Public Class Historique
    Private Sub Historique_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargerHistorique()
    End Sub

    Private Sub ChargerHistorique()

        Dim lstTrajets = DataAccess.GetHistoriqueVols()
        ' -------------------------------------------------------------------------------
        ' Si aucun trajet n'est trouvé, afficher un message
        If lstTrajets.Count = 0 Then

            Dim lbl As New Label()
            lbl.Text = "Vous n'avez pas encore fait de trajet."
            lbl.Font = New Font("Arial", 14, FontStyle.Bold)
            lbl.AutoSize = True
            lbl.Location = New Point(20, 20)

            pnlHistorique.Controls.Add(lbl)

            Exit Sub

        End If


        ' si des trajets sont trouvés, les afficher dans des GroupBox

        Dim yPosition As Integer = 10

        For Each trajet In lstTrajets

            Dim group As New GroupBox()

            group.Text = "Trajet #" & trajet("TRAJ_ID").ToString()
            group.Font = New Font("Arial", 12, FontStyle.Bold)

            group.Location = New Point(10, yPosition)
            group.Size = New Size(600, 180)

            pnlHistorique.Controls.Add(group)

            Dim yInside As Integer = 30

            AjouterLabel(group, "Départ :", trajet("VILLE_DEPART").ToString(), yInside)

            AjouterLabel(group, "Arrivée :", trajet("VILLE_ARRIVEE").ToString(), yInside)

            AjouterLabel(group, "Date du vol :",
                    Convert.ToDateTime(trajet("TRAJ_DATE_EFFECTIF")).ToShortDateString(),
                    yInside)

            AjouterLabel(group, "Durée estimée :",
                    trajet("TRAJ_DUREEESTIME").ToString() & " min",
                    yInside)

            AjouterLabel(group, "Montant :",
                    trajet("TRAJ_FACTURE_MONTANT").ToString() & " CHF",
                    yInside)

            yPosition += 200

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

End Class