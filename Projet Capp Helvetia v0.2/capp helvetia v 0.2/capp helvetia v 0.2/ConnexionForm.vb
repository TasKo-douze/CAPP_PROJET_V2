Imports System.Drawing.Drawing2D
Imports System.Runtime.Remoting.Services

Public Class ConnexionForm

    'Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    'Me.BackColor = Color.White
    ' End Sub


    ' procédure pour crée le dégradé de couleur 
    ''Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    'Dim brush As New LinearGradientBrush(Me.ClientRectangle,
    '                                        Color.LightCoral,   ' rouge clair
    '                                        Color.SlateGray,    ' bleu gris
    '                                       LinearGradientMode.Vertical)

    '   e.Graphics.FillRectangle(brush, Me.ClientRectangle)
    'End Sub



    Private placeholderEmail As String = "Votre email"
    Private placeholderMotdePasse As String = "Votre Mot de Passe"

    Private Sub ConnexionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitTextBox(txtbEmail, placeholderEmail)
        InitTextBox(txtbMDP, placeholderMotdePasse)

        txtbMDP.UseSystemPasswordChar = False
    End Sub

    Private Sub InitTextBox(tb As TextBox, placeholder As String)
        tb.Text = placeholder
    End Sub

    Private Sub HandleEnter(tb As TextBox, placeholder As String, isPassword As Boolean)
        If tb.Text = placeholder Then
            tb.Text = ""
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

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click

        Dim email As String = txtbEmail.Text.Trim()
        Dim motdepasse As String = txtbMDP.Text.Trim()


        RecupererClient(email, motdepasse)


        AccueilForm.Show()
        Me.Hide()




    End Sub


    Private Sub lnklblInscription_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblInscription.LinkClicked
        Inscription1.Show()
        Me.Hide()
    End Sub

    Private Sub txtbEmail_Enter(sender As Object, e As EventArgs) Handles txtbEmail.Enter
        HandleEnter(txtbEmail, placeholderEmail, False)
    End Sub

    Private Sub txtbEmail_Leave(sender As Object, e As EventArgs) Handles txtbEmail.Leave
        HandleLeave(txtbEmail, placeholderEmail, False)
    End Sub

    Private Sub txtbMDP_Enter(sender As Object, e As EventArgs) Handles txtbMDP.Enter
        HandleEnter(txtbMDP, placeholderMotdePasse, False)
    End Sub

    Private Sub txtbMDP_Leave(sender As Object, e As EventArgs) Handles txtbMDP.Leave
        HandleLeave(txtbMDP, placeholderMotdePasse, False)
    End Sub

    Private Sub btnCadena_Click(sender As Object, e As EventArgs) Handles btnCadena.Click
        If txtbMDP.UseSystemPasswordChar = True Then
            txtbMDP.UseSystemPasswordChar = False
        Else
            txtbMDP.UseSystemPasswordChar = True
        End If

    End Sub
End Class
