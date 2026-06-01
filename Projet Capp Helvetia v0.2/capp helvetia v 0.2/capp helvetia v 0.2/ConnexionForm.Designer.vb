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
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMDP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblConnexion
        '
        Me.lblConnexion.AutoSize = True
        Me.lblConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnexion.Location = New System.Drawing.Point(71, 64)
        Me.lblConnexion.Name = "lblConnexion"
        Me.lblConnexion.Size = New System.Drawing.Size(233, 39)
        Me.lblConnexion.TabIndex = 0
        Me.lblConnexion.Text = "Se connecter"
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(111, 150)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtbEmail.TabIndex = 1
        '
        'txtbMDP
        '
        Me.txtbMDP.Location = New System.Drawing.Point(111, 199)
        Me.txtbMDP.Name = "txtbMDP"
        Me.txtbMDP.Size = New System.Drawing.Size(150, 20)
        Me.txtbMDP.TabIndex = 2
        Me.txtbMDP.UseSystemPasswordChar = True
        '
        'btnConnexion
        '
        Me.btnConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnConnexion.Location = New System.Drawing.Point(129, 320)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(126, 31)
        Me.btnConnexion.TabIndex = 3
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'lnklblInscription
        '
        Me.lnklblInscription.AutoSize = True
        Me.lnklblInscription.BackColor = System.Drawing.Color.Transparent
        Me.lnklblInscription.LinkColor = System.Drawing.Color.Black
        Me.lnklblInscription.Location = New System.Drawing.Point(292, 422)
        Me.lnklblInscription.Name = "lnklblInscription"
        Me.lnklblInscription.Size = New System.Drawing.Size(88, 13)
        Me.lnklblInscription.TabIndex = 4
        Me.lnklblInscription.TabStop = True
        Me.lnklblInscription.Text = "Créer un compte "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(108, 134)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblMDP
        '
        Me.lblMDP.AutoSize = True
        Me.lblMDP.Location = New System.Drawing.Point(108, 183)
        Me.lblMDP.Name = "lblMDP"
        Me.lblMDP.Size = New System.Drawing.Size(75, 13)
        Me.lblMDP.TabIndex = 6
        Me.lblMDP.Text = "Mot de Passe:"
        '
        'ConnexionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 456)
        Me.Controls.Add(Me.lblMDP)
        Me.Controls.Add(Me.lblEmail)
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
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMDP As Label
End Class
