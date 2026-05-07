<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsPassagerForm
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
        Me.PanelPassagers = New System.Windows.Forms.Panel()
        Me.btnContinuer = New System.Windows.Forms.Button()
        Me.PanelPassagers.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPassagers
        '
        Me.PanelPassagers.AutoScroll = True
        Me.PanelPassagers.Controls.Add(Me.btnContinuer)
        Me.PanelPassagers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPassagers.Location = New System.Drawing.Point(0, 0)
        Me.PanelPassagers.Name = "PanelPassagers"
        Me.PanelPassagers.Size = New System.Drawing.Size(780, 450)
        Me.PanelPassagers.TabIndex = 0
        '
        'btnContinuer
        '
        Me.btnContinuer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinuer.Location = New System.Drawing.Point(693, 415)
        Me.btnContinuer.Name = "btnContinuer"
        Me.btnContinuer.Size = New System.Drawing.Size(75, 23)
        Me.btnContinuer.TabIndex = 0
        Me.btnContinuer.Text = "Continuer"
        Me.btnContinuer.UseVisualStyleBackColor = True
        '
        'DetailsPassagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.PanelPassagers)
        Me.Name = "DetailsPassagerForm"
        Me.Text = "DetailsPassagerForm"
        Me.PanelPassagers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPassagers As Panel
    Friend WithEvents btnContinuer As Button
End Class
