Imports System.Text.RegularExpressions

Public Class Inscription1

    Private placeholderNom As String = "Entrez votre nom"
    Private placeholderPrenom As String = "Entrez votre prénom"
    Private placeholderEmail As String = "Ex: nom@mail.com"
    Private placeholderMotdePasse As String = "Entrez votre Mot de Passe"
    Private placeholderRue As String = "Rue de l'adresse"
    Private placeholderVille As String = "Ville de l'adresse"
    Private placeholderNumero As String = "Numéro de l'adresse"



    Private Sub Inscription1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitTextBox(txtbNom, placeholderNom)
        InitTextBox(txtbPrenom, placeholderPrenom)
        InitTextBox(txtbEmailIns, placeholderEmail)
        InitTextBox(txtbMDPIns, placeholderMotdePasse)
        InitTextBox(txtbRue, placeholderRue)
        InitTextBox(txtbVille, placeholderVille)
        InitTextBox(txtbNumero, placeholderNumero)

    End Sub

    Private Sub InitTextBox(tb As TextBox, placeholder As String)
        tb.BackColor = Color.Black
        tb.ForeColor = Color.Gray
        tb.BorderStyle = BorderStyle.None
        tb.Text = placeholder
    End Sub

    Private Sub HandleEnter(tb As TextBox, placeholder As String, isPassword As Boolean)
        If tb.Text = placeholder Then
            tb.Text = ""
            tb.ForeColor = Color.White
            If isPassword Then tb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub HandleLeave(tb As TextBox, placeholder As String, isPassword As Boolean)
        If tb.Text = "" Then
            tb.Text = placeholder
            tb.ForeColor = Color.Gray
            If isPassword Then tb.UseSystemPasswordChar = False
        End If
    End Sub






    Private Sub VerifierChamps()


        ' Tant que le text box est rempli le bouton de validation s'activera
        If txtbNom.Text.Trim() = "" And
       txtbPrenom.Text.Trim() = "" And
       txtbRue.Text.Trim() = "" And
       txtbVille.Text.Trim() = "" And
       txtbNumero.Text.Trim() = "" And
       txtbEmailIns.Text.Trim() = "" And
       mtxtbTelephone.Text.Trim() = "" And
       txtbMDPIns.Text.Trim() = "" Then

            btnValiderInscription.Enabled = False

        Else

            btnValiderInscription.Enabled = True

        End If

    End Sub


    'Regroupement plusieurs TextBox dans un seul événement qui vérifie si tous les champs sont remplis
    'et active quand le textbox se déclenche la procédure verifierchamps s'active
    'en gros si on ecrit le teextChanged ce lance et verifie en tant reel


    Private Sub Champs_TextChanged(sender As Object, e As EventArgs) Handles _
        txtbNom.TextChanged,
        txtbPrenom.TextChanged,
        txtbRue.TextChanged,
        txtbVille.TextChanged,
        txtbNumero.TextChanged,
        txtbEmailIns.TextChanged,
        mtxtbTelephone.TextChanged,
        txtbMDPIns.TextChanged

        VerifierChamps()

    End Sub


    Private Sub btnValiderIns_Click(sender As Object, e As EventArgs) Handles btnValiderInscription.Click

        ' Contains = doit contenire
        ' "IsNumeric"(= qui met la valeur en nombre du txtbNumero.text)
        ' "not" mets déjà de base en NON le contenue du textbox donc il va mettre le message, si le contenue est similaire la contrainte alors c'est "Exit"

        If Not IsNumeric(txtbNumero.Text) Then
            MessageBox.Show("Le numéro de rue doit être un nombre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not txtbEmailIns.Text.Contains("@") Or Not txtbEmailIns.Text.Contains(".") Then
            MessageBox.Show("Email invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        Dim motdepasse As String = txtbMDPIns.Text

        If motdepasse.Length <= 8 Or
            Not motdepasse.Any(AddressOf Char.IsUpper) Or
            Not motdepasse.Any(AddressOf Char.IsDigit) Then

            MessageBox.Show("Le mot de passe doit contenir au minimum 8 caractères, une majuscule et un chiffre.", "Mot de passe invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub

        End If



        If Not mtxtbTelephone.MaskCompleted Then
            MessageBox.Show("Téléphone incomplet", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim age As Integer = Date.Today.Year - dtpDateNaissance.Value.Year

        If dtpDateNaissance.Value.Date > Date.Today.AddYears(-age) Then
            age -= 1
        End If

        If age < 18 Then
            MessageBox.Show("Vous devez avoir au moins 18 ans pour vous inscrire.", "Inscription refusée", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ConnexionForm.Show()
            Me.Hide()
            Exit Sub
        End If


        Dim ok As Boolean = DataAccess.InscriptionClient(txtbNom.Text, txtbPrenom.Text, mtxtbTelephone.Text, txtbEmailIns.Text, txtbMDPIns.Text, dtpDateNaissance.Value, CInt(nudTaille.Value), CInt(nudPoids.Value), txtbRue.Text, txtbVille.Text, CInt(txtbNumero.Text))

        If ok Then

            AccueilForm.Show()
            MessageBox.Show("Bienvenue !")
            Me.Hide()
        Else
            MessageBox.Show("Erreur inscription", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        btnValiderInscription.Enabled = False

        mtxtbTelephone.Mask = "+41.00.000.00.00"

        dtpDateNaissance.Format = DateTimePickerFormat.Custom

        dtpDateNaissance.CustomFormat = "dd.MM.yyyy"


    End Sub


End Class








