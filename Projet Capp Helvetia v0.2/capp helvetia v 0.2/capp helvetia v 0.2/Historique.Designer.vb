<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historique
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHistorique = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlHistorique
        '
        Me.pnlHistorique.AutoScroll = True
        Me.pnlHistorique.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHistorique.Location = New System.Drawing.Point(0, 0)
        Me.pnlHistorique.Name = "pnlHistorique"
        Me.pnlHistorique.Size = New System.Drawing.Size(800, 450)
        Me.pnlHistorique.TabIndex = 0
        '
        'Historique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlHistorique)
        Me.Name = "Historique"
        Me.Text = "Historique"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHistorique As Panel
End Class
