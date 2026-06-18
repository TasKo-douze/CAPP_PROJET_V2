Public Class DetailsPassagerForm


    Public NbPassagers As Integer

    Private SupBagage As Integer = 0
    Private NbBagagesTotal As Integer = 0

    Public VilleDepart As String
    Public VilleArrivee As String
    Public DateReservation As Date

    Private ClientNom As String
    Private ClientPrenom As String
    Private ClientDateNaissance As Date
    Private ClientTaille As Integer
    Private ClientPoids As Integer

    Private Structure PassagerSaisi
        Public Nom As String
        Public Prenom As String
        Public DateNaissance As Date
        Public Taille As Integer
        Public Poids As Integer
    End Structure

    Private Function CreerClePassager(nom As String, prenom As String, dateNaissance As Date) As String
        Return nom.Trim().ToUpperInvariant() & "|" & prenom.Trim().ToUpperInvariant() & "|" & dateNaissance.Date.ToString("yyyyMMdd")
    End Function



    Private Sub DetailsPassagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChargerClient()
        GenererPassagers()
    End Sub


    ''' <summary>
    ''' charge les informations du client connecté dans les variables globales
    ''' </summary>
    Private Sub ChargerClient()

        If ClientConnecte.EstConnecte = False Then
            MessageBox.Show("Aucun client connecté.")
            Return
        End If

        ClientNom = ClientConnecte.Nom
        ClientPrenom = ClientConnecte.Prenom
        ClientDateNaissance = ClientConnecte.DateNaissance
        ClientTaille = ClientConnecte.Taille
        ClientPoids = ClientConnecte.Poids

    End Sub


    ''' <summary>
    ''' genère dynamiquement les groupes de champs pour chaque passager en fonction du nombre de passagers saisi dans la page précédente
    ''' </summary>
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
                AjouterLabel(group, "Nom :", ClientNom, yInside)
                AjouterLabel(group, "Prénom :", ClientPrenom, yInside)
                AjouterLabel(group, "Date naissance :", ClientDateNaissance.ToShortDateString(), yInside)
                AjouterLabel(group, "Taille :", ClientTaille & " cm", yInside)
                AjouterLabel(group, "Poids :", ClientPoids & " kg", yInside)

                AjouterChoixBagage(group, yInside)

            Else
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

    ''' <summary>
    ''' ajoute un label pour le titre et un label pour la valeur dans le parent spécifié, et met à jour la position verticale y pour le prochain contrôle.
    ''' </summary>


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

    ''' <summary>
    ''' ajoute un TextBox pour la saisie d'informations pour chaque passager, avec un label correspondant. La position verticale y est mise à jour pour le prochain contrôle.
    ''' </summary>


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

    ''' <summary>
    ''' ajoute un DateTimePicker pour la date de naissance du passager, avec une limite maximale de date pour s'assurer que le passager a au moins 16 ans.
    ''' </summary>


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

        dtp.Format = DateTimePickerFormat.Short

        dtp.MaxDate = Date.Today.AddYears(-16)

        dtp.Value = Date.Today.AddYears(-16)

        parent.Controls.Add(lbl)
        parent.Controls.Add(dtp)

        y += 30
    End Sub


    ''' <summary>
    ''' ajoute un choix de bagage pour chaque passager, avec une option "Oui" ou "Non". Si "Oui" est sélectionné, un champ de saisie pour le poids du bagage apparaît.
    ''' </summary>



    Private Sub AjouterChoixBagage(parent As Control, ByRef y As Integer)

        Dim lbl As New Label()
        lbl.Text = "Bagage :"
        lbl.Font = New Font("Arial", 12)
        lbl.Location = New Point(10, y)
        lbl.AutoSize = True

        Dim cb As New ComboBox()
        cb.Location = New Point(200, y)
        cb.Width = 100

        cb.Items.Add("Oui")
        cb.Items.Add("Non")

        cb.DropDownStyle = ComboBoxStyle.DropDownList

        Dim txtPoids As New TextBox()
        txtPoids.Location = New Point(320, y)
        txtPoids.Width = 80
        txtPoids.Visible = False

        txtPoids.Tag = "Bagage"

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

    ''' <summary>
    ''' 
    ''' analyse les données saisies pour chaque passager, vérifie la validité des informations, et enregistre les passagers dans la base de données si nécessaire. 
    ''' Retourne True si toutes les données sont valides, sinon retourne False.
    ''' 
    ''' </summary>

    Private Function ValidationDonnees() As Boolean

        NbBagagesTotal = 0
        SupBagage = 0
        Dim passagersAInserer As New List(Of PassagerSaisi)
        Dim passagersVus As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

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

                                    MessageBox.Show("Bagage supérieur à 25 kg. Supplément de 40 CHF.", "Supplément bagage", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                                    SupBagage += 20

                                End If

                            End If

                        Else

                            If group.Text <> "Passager 1" Then

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

                If group.Text <> "Passager 1" Then

                    nom = nom.Trim()
                    prenom = prenom.Trim()

                    Dim clePassager As String = CreerClePassager(nom, prenom, dateNaissance)

                    If passagersVus.Contains(clePassager) Then
                        MessageBox.Show("Ce passager est déjà saisi dans la réservation : " & prenom & " " & nom & ".")
                        Return False
                    End If

                    passagersVus.Add(clePassager)

                    If Not DataAccess.PassagerExiste(nom, prenom, dateNaissance) Then
                        passagersAInserer.Add(New PassagerSaisi With {
                            .Nom = nom,
                            .Prenom = prenom,
                            .DateNaissance = dateNaissance,
                            .Taille = taille,
                            .Poids = poids
                        })
                    End If

                End If

            End If

        Next

        For Each passager As PassagerSaisi In passagersAInserer
            DataAccess.InsertPassager(passager.Nom, passager.Prenom, passager.DateNaissance, passager.Taille, passager.Poids)
        Next

        Return True

    End Function

    ''' <summary>
    ''' Gère le clic sur le bouton "Continuer". Valide les données saisies pour chaque passager, affiche un message de succès, puis ouvre le formulaire de récapitulatif avec les informations pertinentes.
    ''' </summary>

    Private Sub btnContinuer_Click(sender As Object, e As EventArgs) Handles btnContinuer.Click
        If ValidationDonnees() Then

            MessageBox.Show("Enregistrés avec succès.")

            Dim form As New RecapitulatifForm()

            form.VilleDepart = VilleDepart
            form.VilleArrivee = VilleArrivee
            form.DateReservation = DateReservation
            form.NbPassagers = NbPassagers

            form.ClientNom = ClientConnecte.Nom
            form.ClientPrenom = ClientConnecte.Prenom
            form.ClientEmail = ClientConnecte.Email
            form.ClientTelephone = ClientConnecte.Telephone
            form.ClientPoids = ClientConnecte.Poids
            form.ClientTaille = ClientConnecte.Taille

            form.NbBagages = NbBagagesTotal

            form.SupplementBagages = SupBagage

            form.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnRetourDetails_Click(sender As Object, e As EventArgs) Handles btnRetourDetails.Click
        Dim form As New ReservationForm()
        form.Show()
        Close()
    End Sub
End Class
