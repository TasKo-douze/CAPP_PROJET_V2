<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AProposForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AProposForm))
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtAPropos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(12, 23)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(261, 30)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "À propos de l’application"
        '
        'txtAPropos
        '
        Me.txtAPropos.AccessibleDescription = ""
        Me.txtAPropos.AccessibleName = ""
        Me.txtAPropos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPropos.Location = New System.Drawing.Point(17, 70)
        Me.txtAPropos.Multiline = True
        Me.txtAPropos.Name = "txtAPropos"
        Me.txtAPropos.ReadOnly = True
        Me.txtAPropos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAPropos.Size = New System.Drawing.Size(282, 353)
        Me.txtAPropos.TabIndex = 2
        Me.txtAPropos.TabStop = False
        Me.txtAPropos.Text = resources.GetString("txtAPropos.Text")
        '
        'AProposForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.txtAPropos)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "AProposForm"
        Me.Text = "A propos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents txtAPropos As TextBox
End Class
