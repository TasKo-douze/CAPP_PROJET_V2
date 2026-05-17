Public Class DetailsPassagerForm

    Public NbPassagers As Integer
    Public NbBagage As Integer

    Private NombreBagagesSelectionnes As Integer = 0
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


            ClientDateNaissance = CDate(client("CLI_DATE_NAISSANCE"))
            ClientTaille = CInt(client("CLI_TAILLE"))
            ClientPoids = CInt(client("CLI_POIDS"))
            ClientBagage = CInt(client("CLI_POIDSBAGAGE"))

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

                AjouterChoixBagage(group, yInside)
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

        txt.Tag = titre

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

    Private Sub AjouterChoixBagage(parent As Control, ByRef y As Integer)

        ' creation Label
        Dim lbl As New Label()
        lbl.Text = "Bagage :"
        lbl.Font = New Font("Arial", 12)
        lbl.Location = New Point(10, y)
        lbl.AutoSize = True

        ' Combo Oui / Non
        Dim cb As New ComboBox()
        cb.Location = New Point(200, y)
        cb.Width = 100

        cb.Items.Add("Oui")
        cb.Items.Add("Non")

        cb.DropDownStyle = ComboBoxStyle.DropDownList

        ' TextBox poids bagage
        Dim txtPoidsBagage As New TextBox()
        txtPoidsBagage.Location = New Point(320, y)
        txtPoidsBagage.Width = 80
        txtPoidsBagage.Visible = False

        txtPoidsBagage.Tag = "Bagage"

        AddHandler cb.SelectedIndexChanged,
    Sub()
        ' si oui , afficher le champ pour le poids du bagage
        If cb.Text = "Oui" Then

            If NombreBagagesSelectionnes >= NbBagage Then

                MessageBox.Show(
                    "Le nombre maximum de bagages a déjà été atteint."
                )

                cb.SelectedIndex = -1
                Return

            End If

            NombreBagagesSelectionnes += 1

            txtPoidsBagage.Visible = True

        ElseIf cb.Text = "Non" Then

            txtPoidsBagage.Visible = False

        End If

    End Sub

        parent.Controls.Add(lbl)
        parent.Controls.Add(cb)
        parent.Controls.Add(txtPoidsBagage)

        y += 40

    End Sub

    Private Sub btnContinuer_Click(sender As Object, e As EventArgs) Handles btnContinuer.Click
        ' group = chaque passager
        For Each group As GroupBox In PanelPassagers.Controls

            Dim nom As String = ""
            Dim prenom As String = ""
            Dim taille As String = ""
            Dim poids As String = ""
            Dim bagage As Integer = 0
            Dim dateNaissance As Date
            ' ctrl = chaque champ d'un passager
            For Each ctrl As Control In group.Controls

                If TypeOf ctrl Is TextBox Then

                    Dim txt As TextBox = CType(ctrl, TextBox)
                    If txt.Tag IsNot Nothing AndAlso txt.Tag.ToString() = "Bagage" Then

                        If txt.Visible Then

                            If txt.Text.Trim() = "" Then

                                MessageBox.Show("Veuillez entrer le poids du bagage.")
                                Return

                            End If

                            bagage = CInt(txt.Text)

                        End If

                    End If


                    ' Vérifie si vide
                    If txt.Text.Trim() = "" Then
                        MessageBox.Show("Veuillez remplir tous les champs.")
                        Return
                    End If

                    ' Récupération des valeurs
                    Select Case txt.Tag.ToString()

                        Case "Nom :"
                            nom = txt.Text

                        Case "Prénom :"
                            prenom = txt.Text

                        Case "Taille :"
                            taille = txt.Text

                        Case "Poids :"
                            poids = txt.Text

                        Case "Bagage :"
                            bagage = txt.Text

                    End Select

                End If

                ' Date de naissance
                If TypeOf ctrl Is DateTimePicker Then

                    Dim dtp As DateTimePicker = CType(ctrl, DateTimePicker)

                    dateNaissance = dtp.Value

                    ' Calcul âge
                    Dim age As Integer = Date.Today.Year - dateNaissance.Year

                    If dateNaissance > Date.Today.AddYears(-age) Then
                        age -= 1
                    End If

                    ' Vérifie minimum 16 ans
                    If age < 16 Then

                        MessageBox.Show(
                    "Le passager est mineur. Le client est responsable des personnes mineures.",
                    "Passager mineur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    )

                    End If

                End If

            Next

            ' INSERTION EN BASE
            DataAccess.InsertPassager(
            nom,
            prenom,
            dateNaissance,
            CInt(taille),
            CInt(poids),
            CInt(bagage)
        )

        Next

        MessageBox.Show("Passagers enregistrés avec succès.")

        Dim form As New RecapitulatifForm()
        form.Show()
        Me.Close()

    End Sub

    Private Sub btnRetourDetails_Click(sender As Object, e As EventArgs) Handles btnRetourDetails.Click
        'bouton pour retourner à la page de réservation
        Dim form As New ReservationForm()
        form.Show()
        Close()
    End Sub
End Class