<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription1
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
        Me.lblInscription = New System.Windows.Forms.Label()
        Me.txtbNom = New System.Windows.Forms.TextBox()
        Me.txtbPrenom = New System.Windows.Forms.TextBox()
        Me.txtbRue = New System.Windows.Forms.TextBox()
        Me.txtbVille = New System.Windows.Forms.TextBox()
        Me.txtbNumero = New System.Windows.Forms.TextBox()
        Me.btnSuivantIns1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInscription
        '
        Me.lblInscription.AutoSize = True
        Me.lblInscription.Location = New System.Drawing.Point(107, 54)
        Me.lblInscription.Name = "lblInscription"
        Me.lblInscription.Size = New System.Drawing.Size(55, 13)
        Me.lblInscription.TabIndex = 0
        Me.lblInscription.Text = "Inscription"
        '
        'txtbNom
        '
        Me.txtbNom.Location = New System.Drawing.Point(110, 125)
        Me.txtbNom.Name = "txtbNom"
        Me.txtbNom.Size = New System.Drawing.Size(100, 20)
        Me.txtbNom.TabIndex = 1
        '
        'txtbPrenom
        '
        Me.txtbPrenom.Location = New System.Drawing.Point(110, 151)
        Me.txtbPrenom.Name = "txtbPrenom"
        Me.txtbPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtbPrenom.TabIndex = 2
        '
        'txtbRue
        '
        Me.txtbRue.Location = New System.Drawing.Point(110, 225)
        Me.txtbRue.Name = "txtbRue"
        Me.txtbRue.Size = New System.Drawing.Size(100, 20)
        Me.txtbRue.TabIndex = 3
        '
        'txtbVille
        '
        Me.txtbVille.Location = New System.Drawing.Point(110, 251)
        Me.txtbVille.Name = "txtbVille"
        Me.txtbVille.Size = New System.Drawing.Size(100, 20)
        Me.txtbVille.TabIndex = 4
        '
        'txtbNumero
        '
        Me.txtbNumero.Location = New System.Drawing.Point(110, 295)
        Me.txtbNumero.Name = "txtbNumero"
        Me.txtbNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtbNumero.TabIndex = 5
        '
        'btnSuivantIns1
        '
        Me.btnSuivantIns1.Location = New System.Drawing.Point(231, 377)
        Me.btnSuivantIns1.Name = "btnSuivantIns1"
        Me.btnSuivantIns1.Size = New System.Drawing.Size(75, 23)
        Me.btnSuivantIns1.TabIndex = 6
        Me.btnSuivantIns1.Text = "Suivant"
        Me.btnSuivantIns1.UseVisualStyleBackColor = True
        '
        'InscriptionNom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSuivantIns1)
        Me.Controls.Add(Me.txtbNumero)
        Me.Controls.Add(Me.txtbVille)
        Me.Controls.Add(Me.txtbRue)
        Me.Controls.Add(Me.txtbPrenom)
        Me.Controls.Add(Me.txtbNom)
        Me.Controls.Add(Me.lblInscription)
        Me.Name = "InscriptionNom"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInscription As Label
    Friend WithEvents txtbNom As TextBox
    Friend WithEvents txtbPrenom As TextBox
    Friend WithEvents txtbRue As TextBox
    Friend WithEvents txtbVille As TextBox
    Friend WithEvents txtbNumero As TextBox
    Friend WithEvents btnSuivantIns1 As Button
End Class
