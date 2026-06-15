Imports System.Drawing.Drawing2D

Module StyleFormulaire



    Public Sub DessinerDegrade(formulaire As Form, e As PaintEventArgs)

        Dim brush As New LinearGradientBrush(
            formulaire.ClientRectangle,
            Color.LightCoral,
            Color.SlateGray,
            LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, formulaire.ClientRectangle)

    End Sub

End Module
