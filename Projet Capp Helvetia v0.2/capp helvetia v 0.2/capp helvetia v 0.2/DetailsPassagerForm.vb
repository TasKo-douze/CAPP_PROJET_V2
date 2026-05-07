Public Class DetailsPassagerForm

    Public NbPassagers As Integer = 2
    ' Variables globales pour stocker les données du client
    Public ClientNom As String
    Public ClientPrenom As String
    Public ClientDateNaissance As Date
    Public ClientTaille As Integer
    Public ClientPoids As Integer
    Public ClientBagage As Integer

    Private Sub DetailsPassagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargerClient()
        GenererPassagers()
    End Sub

    Private Sub ChargerClient()

        Dim lstClients = DataAccess.GetClient()

        If lstClients.Count > 0 Then

            Dim client = lstClients(0)

            ClientNom = client("CLI_NOM").ToString()
            ClientPrenom = client("CLI_PRENOM").ToString()


            ClientDateNaissance = New Date(1990, 1, 1)
            ClientTaille = 180
            ClientPoids = 75
            ClientBagage = 10

        Else
            MessageBox.Show("Aucun client trouvé")
        End If

    End Sub

    Private Sub GenererPassagers()

        Dim yPosition As Integer = 10

        For i As Integer = 1 To NbPassagers

            '  GroupBox
            Dim group As New GroupBox()
            group.Text = "Passager " & i
            group.Font = New Font("Arial", 12, FontStyle.Bold)
            group.Location = New Point(10, yPosition)
            group.Size = New Size(500, 220)

            PanelPassagers.Controls.Add(group)

            Dim yInside As Integer = 30

            If i = 1 Then
                '  Passager connecté
                AjouterLabel(group, "Nom :", ClientNom, yInside)
                AjouterLabel(group, "Prénom :", ClientPrenom, yInside)
                AjouterLabel(group, "Date naissance :", ClientDateNaissance.ToShortDateString(), yInside)
                AjouterLabel(group, "Taille :", ClientTaille & " cm", yInside)
                AjouterLabel(group, "Poids :", ClientPoids & " kg", yInside)
                AjouterLabel(group, "Bagage :", ClientBagage & " kg", yInside)

            Else
                '  Autres passagers
                AjouterTextBox(group, "Nom :", yInside)
                AjouterTextBox(group, "Prénom :", yInside)
                AjouterDatePicker(group, "Date naissance :", yInside)
                AjouterTextBox(group, "Taille :", yInside)
                AjouterTextBox(group, "Poids :", yInside)
                AjouterTextBox(group, "Bagage :", yInside)
            End If

            yPosition += 250
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
        lblValeur.Location = New Point(200, y)
        lblValeur.AutoSize = True

        parent.Controls.Add(lblTitre)
        parent.Controls.Add(lblValeur)

        y += 30
    End Sub

    Private Sub AjouterTextBox(parent As Control, titre As String, ByRef y As Integer)

        Dim lbl As New Label()
        lbl.Text = titre
        lbl.Font = New Font("Arial", 12)
        lbl.Location = New Point(10, y)
        lbl.AutoSize = True

        Dim txt As New TextBox()
        txt.Font = New Font("Arial", 12)
        txt.Location = New Point(200, y)
        txt.Width = 200

        parent.Controls.Add(lbl)
        parent.Controls.Add(txt)

        y += 30
    End Sub

    Private Sub AjouterDatePicker(parent As Control, titre As String, ByRef y As Integer)

        Dim lbl As New Label()
        lbl.Text = titre
        lbl.Font = New Font("Arial", 10)
        lbl.Location = New Point(10, y)
        lbl.AutoSize = True

        Dim dtp As New DateTimePicker()
        dtp.Font = New Font("Arial", 10)
        dtp.Location = New Point(200, y)
        dtp.Width = 200

        parent.Controls.Add(lbl)
        parent.Controls.Add(dtp)

        y += 30
    End Sub
End Class