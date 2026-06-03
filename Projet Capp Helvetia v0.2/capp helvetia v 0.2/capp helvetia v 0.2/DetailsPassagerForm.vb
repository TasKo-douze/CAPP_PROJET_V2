Public Class DetailsPassagerForm

    ' pour rappele yInseder = position verticale dans le groupbox

    Public NbPassagers As Integer

    Private SupBagage As Integer = 0
    Private NbBagagesTotal As Integer = 0

    Public VilleDepart As String
    Public VilleArrivee As String
    Public DateReservation As Date

    ' Variables globales pour stocker les données du client
    Private ClientNom As String
    Private ClientPrenom As String
    Private ClientDateNaissance As Date
    Private ClientTaille As Integer
    Private ClientPoids As Integer



    Private Sub DetailsPassagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargerClient()
        GenererPassagers()
    End Sub

    Private Sub ChargerClient()

        Dim lstClients = DataAccess.GetClient()

        If lstClients.Count > 0 Then

            Dim client = lstClients(0)
            'stocke les données du client dans les variables globales en les convertissant au bon type
            ClientNom = client("CLI_NOM").ToString()
            ClientPrenom = client("CLI_PRENOM").ToString()


            ClientDateNaissance = CDate(client("CLI_DATE_NAISSANCE"))
            ClientTaille = CInt(client("CLI_TAILLE"))
            ClientPoids = CInt(client("CLI_POIDS"))


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

                AjouterChoixBagage(group, yInside)

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

        ' Format date
        dtp.Format = DateTimePickerFormat.Short

        ' Date maximum = aujourd’hui - 16 ans
        dtp.MaxDate = Date.Today.AddYears(-16)

        ' Valeur affichée par défaut
        dtp.Value = Date.Today.AddYears(-16)

        parent.Controls.Add(lbl)
        parent.Controls.Add(dtp)

        y += 30
    End Sub

    Private Sub AjouterChoixBagage(parent As Control, ByRef y As Integer)

        ' Label
        Dim lbl As New Label()
        lbl.Text = "Bagage :"
        lbl.Font = New Font("Arial", 12)
        lbl.Location = New Point(10, y)
        lbl.AutoSize = True

        ' ComboBox Oui / Non
        Dim cb As New ComboBox()
        cb.Location = New Point(200, y)
        cb.Width = 100

        cb.Items.Add("Oui")
        cb.Items.Add("Non")

        ' Empêche de taper du texte
        ' choix uniquement via la liste déroulante
        cb.DropDownStyle = ComboBoxStyle.DropDownList

        ' TextBox poids bagage
        Dim txtPoids As New TextBox()
        txtPoids.Location = New Point(320, y)
        txtPoids.Width = 80
        txtPoids.Visible = False

        txtPoids.Tag = "Bagage"

        ' Quand on change Oui/Non
        ' uand le ComboBox change, exécute ce code
        AddHandler cb.SelectedIndexChanged,
    Sub()

        If cb.Text = "Oui" Then

            txtPoids.Visible = True

        Else

            txtPoids.Visible = False
            txtPoids.Text = ""

        End If

    End Sub

        parent.Controls.Add(lbl)
        parent.Controls.Add(cb)
        parent.Controls.Add(txtPoids)

        y += 40

    End Sub

    Private Function ValidationDonnees() As Boolean
        Dim NbBagagesTotal As Integer = 0
        SupBagage = 0

        For Each ctrlGroup As Control In PanelPassagers.Controls

            If TypeOf ctrlGroup Is GroupBox Then

                Dim group As GroupBox = DirectCast(ctrlGroup, GroupBox)

                Dim nom As String = ""
                Dim prenom As String = ""
                Dim taille As Integer = 0
                Dim poids As Integer = 0
                Dim bagage As Integer = 0
                Dim dateNaissance As Date = Date.MinValue

                For Each ctrl As Control In group.Controls

                    If TypeOf ctrl Is TextBox Then

                        Dim txt As TextBox = DirectCast(ctrl, TextBox)
                        Dim tag As String = If(txt.Tag Is Nothing, "", txt.Tag.ToString())

                        ' Gestion bagage
                        If tag = "Bagage" Then

                            If txt.Visible Then

                                NbBagagesTotal += 1

                                If String.IsNullOrWhiteSpace(txt.Text) Then
                                    MessageBox.Show("Veuillez entrer le poids du bagage.")
                                    Return False
                                End If

                                If Not Integer.TryParse(txt.Text, bagage) Then
                                    MessageBox.Show("Le poids du bagage doit être un nombre.")
                                    Return False
                                End If

                                If bagage > 28 Then
                                    MessageBox.Show("Bagage refusé : poids supérieur à 28 kg.")
                                    Return False
                                End If

                                If bagage > 25 Then

                                    MessageBox.Show(
                                    "Bagage supérieur à 25 kg. Supplément de 40 CHF.",
                                    "Supplément bagage",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning)

                                    SupBagage += 40

                                End If

                            End If

                        Else

                            If String.IsNullOrWhiteSpace(txt.Text) Then
                                MessageBox.Show("Veuillez remplir tous les champs.")
                                Return False
                            End If

                            Select Case tag

                                Case "Nom :"
                                    nom = txt.Text

                                Case "Prénom :"
                                    prenom = txt.Text

                                Case "Taille :"

                                    If Not Integer.TryParse(txt.Text, taille) Then
                                        MessageBox.Show("La taille doit être un nombre.")
                                        Return False
                                    End If

                                Case "Poids :"

                                    If Not Integer.TryParse(txt.Text, poids) Then
                                        MessageBox.Show("Le poids doit être un nombre.")
                                        Return False
                                    End If

                            End Select

                        End If

                    End If

                    If TypeOf ctrl Is DateTimePicker Then

                        Dim dtp As DateTimePicker = DirectCast(ctrl, DateTimePicker)

                        dateNaissance = dtp.Value

                        Dim age As Integer = Date.Today.Year - dateNaissance.Year

                        If dateNaissance > Date.Today.AddYears(-age) Then
                            age -= 1
                        End If

                        If age < 16 Then

                            MessageBox.Show("Le passager doit avoir au minimum 16 ans.", "Âge invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Return False

                        ElseIf age < 18 Then

                            MessageBox.Show("Le passager est mineur. Le client est responsable des personnes mineures.", "Passager mineur", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        End If

                    End If

                Next



                DataAccess.InsertPassager(nom, prenom, dateNaissance, taille, poids)

            End If

        Next

        Return True

    End Function

    Private Sub btnContinuer_Click(sender As Object, e As EventArgs) Handles btnContinuer.Click



        If ValidationDonnees() Then

            MessageBox.Show("Passagers enregistrés avec succès.")

            Dim form As New RecapitulatifForm()

            ' Réservation
            form.VilleDepart = VilleDepart
            form.VilleArrivee = VilleArrivee
            form.DateReservation = DateReservation
            form.NbPassagers = NbPassagers

            ' Client
            form.ClientNom = ClientNom
            form.ClientPrenom = ClientPrenom
            form.ClientPoids = ClientPoids
            form.ClientTaille = ClientTaille

            Dim client = DataAccess.GetClient()(0)

            form.ClientEmail = client("CLI_EMAIL").ToString()
            form.ClientTelephone = client("CLI_TEL").ToString()

            form.NbBagages = NbBagagesTotal

            ' Suppléments bagages
            form.SupplementBagages = SupBagage

            form.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btnRetourDetails_Click(sender As Object, e As EventArgs) Handles btnRetourDetails.Click
        'bouton pour retourner à la page de réservation
        Dim form As New ReservationForm()
        form.Show()
        Close()
    End Sub
End Class