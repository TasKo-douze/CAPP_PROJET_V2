Imports System.Drawing.Drawing2D

Public Class AccueilForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackColor = Color.White
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim brush As New LinearGradientBrush(Me.ClientRectangle,
                                             Color.LightCoral,   ' rouge clair
                                             Color.SlateGray,    ' bleu gris
                                             LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, Me.ClientRectangle)
    End Sub




End Class