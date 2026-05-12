<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnexionForm
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
        Me.lblConnexion = New System.Windows.Forms.Label()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.txtbMDP = New System.Windows.Forms.TextBox()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.lnklblInscription = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblConnexion
        '
        Me.lblConnexion.AutoSize = True
        Me.lblConnexion.Location = New System.Drawing.Point(111, 72)
        Me.lblConnexion.Name = "lblConnexion"
        Me.lblConnexion.Size = New System.Drawing.Size(57, 13)
        Me.lblConnexion.TabIndex = 0
        Me.lblConnexion.Text = "Connexion"
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(98, 107)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtbEmail.TabIndex = 1
        '
        'txtbMDP
        '
        Me.txtbMDP.Location = New System.Drawing.Point(98, 146)
        Me.txtbMDP.Name = "txtbMDP"
        Me.txtbMDP.Size = New System.Drawing.Size(100, 20)
        Me.txtbMDP.TabIndex = 2
        '
        'btnConnexion
        '
        Me.btnConnexion.Location = New System.Drawing.Point(114, 205)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(75, 23)
        Me.btnConnexion.TabIndex = 3
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'lnklblInscription
        '
        Me.lnklblInscription.AutoSize = True
        Me.lnklblInscription.Location = New System.Drawing.Point(261, 374)
        Me.lnklblInscription.Name = "lnklblInscription"
        Me.lnklblInscription.Size = New System.Drawing.Size(88, 13)
        Me.lnklblInscription.TabIndex = 4
        Me.lnklblInscription.TabStop = True
        Me.lnklblInscription.Text = "Créer un compte "
        '
        'ConnexionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 448)
        Me.Controls.Add(Me.lnklblInscription)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.txtbMDP)
        Me.Controls.Add(Me.txtbEmail)
        Me.Controls.Add(Me.lblConnexion)
        Me.Name = "ConnexionForm"
        Me.Text = "ConnexionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConnexion As Label
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents txtbMDP As TextBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents lnklblInscription As LinkLabel
End Class
