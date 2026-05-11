<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecuriteForm
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
        Me.grpAncienMdp = New System.Windows.Forms.GroupBox()
        Me.txtOldMdp = New System.Windows.Forms.TextBox()
        Me.lblOldMdp = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpNewMdp = New System.Windows.Forms.GroupBox()
        Me.lblConditionMdp = New System.Windows.Forms.Label()
        Me.txtNewMdp = New System.Windows.Forms.TextBox()
        Me.txtValidationMdp = New System.Windows.Forms.TextBox()
        Me.lblValidationMdp = New System.Windows.Forms.Label()
        Me.lblNewMdp = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.grpAncienMdp.SuspendLayout()
        Me.grpNewMdp.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAncienMdp
        '
        Me.grpAncienMdp.Controls.Add(Me.txtOldMdp)
        Me.grpAncienMdp.Controls.Add(Me.lblOldMdp)
        Me.grpAncienMdp.Location = New System.Drawing.Point(12, 39)
        Me.grpAncienMdp.Name = "grpAncienMdp"
        Me.grpAncienMdp.Size = New System.Drawing.Size(321, 102)
        Me.grpAncienMdp.TabIndex = 0
        Me.grpAncienMdp.TabStop = False
        Me.grpAncienMdp.Text = "Ancien mot de passe"
        '
        'txtOldMdp
        '
        Me.txtOldMdp.Location = New System.Drawing.Point(23, 55)
        Me.txtOldMdp.Name = "txtOldMdp"
        Me.txtOldMdp.Size = New System.Drawing.Size(127, 20)
        Me.txtOldMdp.TabIndex = 1
        Me.txtOldMdp.UseSystemPasswordChar = True
        '
        'lblOldMdp
        '
        Me.lblOldMdp.AutoSize = True
        Me.lblOldMdp.Location = New System.Drawing.Point(20, 29)
        Me.lblOldMdp.Name = "lblOldMdp"
        Me.lblOldMdp.Size = New System.Drawing.Size(130, 13)
        Me.lblOldMdp.TabIndex = 0
        Me.lblOldMdp.Text = "Entrez votre mot de passe"
        '
        'grpNewMdp
        '
        Me.grpNewMdp.Controls.Add(Me.lblConditionMdp)
        Me.grpNewMdp.Controls.Add(Me.txtNewMdp)
        Me.grpNewMdp.Controls.Add(Me.txtValidationMdp)
        Me.grpNewMdp.Controls.Add(Me.lblValidationMdp)
        Me.grpNewMdp.Controls.Add(Me.lblNewMdp)
        Me.grpNewMdp.Location = New System.Drawing.Point(12, 166)
        Me.grpNewMdp.Name = "grpNewMdp"
        Me.grpNewMdp.Size = New System.Drawing.Size(321, 243)
        Me.grpNewMdp.TabIndex = 1
        Me.grpNewMdp.TabStop = False
        Me.grpNewMdp.Text = "Nouveau mot de passe"
        '
        'lblConditionMdp
        '
        Me.lblConditionMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditionMdp.Location = New System.Drawing.Point(6, 27)
        Me.lblConditionMdp.Name = "lblConditionMdp"
        Me.lblConditionMdp.Size = New System.Drawing.Size(309, 30)
        Me.lblConditionMdp.TabIndex = 4
        Me.lblConditionMdp.Text = "Le mot de passe doit contenir au minimum : 1 majuscule, 1 minuscule et 1 chiffre." &
    ""
        '
        'txtNewMdp
        '
        Me.txtNewMdp.Location = New System.Drawing.Point(23, 108)
        Me.txtNewMdp.Name = "txtNewMdp"
        Me.txtNewMdp.Size = New System.Drawing.Size(127, 20)
        Me.txtNewMdp.TabIndex = 2
        Me.txtNewMdp.UseSystemPasswordChar = True
        '
        'txtValidationMdp
        '
        Me.txtValidationMdp.Location = New System.Drawing.Point(23, 187)
        Me.txtValidationMdp.Name = "txtValidationMdp"
        Me.txtValidationMdp.Size = New System.Drawing.Size(127, 20)
        Me.txtValidationMdp.TabIndex = 3
        Me.txtValidationMdp.UseSystemPasswordChar = True
        '
        'lblValidationMdp
        '
        Me.lblValidationMdp.AutoSize = True
        Me.lblValidationMdp.Location = New System.Drawing.Point(20, 159)
        Me.lblValidationMdp.Name = "lblValidationMdp"
        Me.lblValidationMdp.Size = New System.Drawing.Size(185, 13)
        Me.lblValidationMdp.TabIndex = 2
        Me.lblValidationMdp.Text = "Répétez votre nouveau mot de passe"
        '
        'lblNewMdp
        '
        Me.lblNewMdp.AutoSize = True
        Me.lblNewMdp.Location = New System.Drawing.Point(20, 82)
        Me.lblNewMdp.Name = "lblNewMdp"
        Me.lblNewMdp.Size = New System.Drawing.Size(175, 13)
        Me.lblNewMdp.TabIndex = 1
        Me.lblNewMdp.Text = "Entrez votre nouveau mot de passe"
        '
        'btnValider
        '
        Me.btnValider.Location = New System.Drawing.Point(242, 415)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 2
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'SecuriteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.grpNewMdp)
        Me.Controls.Add(Me.grpAncienMdp)
        Me.Name = "SecuriteForm"
        Me.Text = "Sécurité"
        Me.grpAncienMdp.ResumeLayout(False)
        Me.grpAncienMdp.PerformLayout()
        Me.grpNewMdp.ResumeLayout(False)
        Me.grpNewMdp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAncienMdp As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grpNewMdp As GroupBox
    Friend WithEvents lblOldMdp As Label
    Friend WithEvents lblNewMdp As Label
    Friend WithEvents lblValidationMdp As Label
    Friend WithEvents txtOldMdp As TextBox
    Friend WithEvents txtNewMdp As TextBox
    Friend WithEvents txtValidationMdp As TextBox
    Friend WithEvents btnValider As Button
    Friend WithEvents lblConditionMdp As Label
End Class
