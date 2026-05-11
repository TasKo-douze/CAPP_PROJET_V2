<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationsPersonnellesForm
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
        Me.btnValide = New System.Windows.Forms.Button()
        Me.grpInfosPerso = New System.Windows.Forms.GroupBox()
        Me.numTaille = New System.Windows.Forms.NumericUpDown()
        Me.numPoids = New System.Windows.Forms.NumericUpDown()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblTaille = New System.Windows.Forms.Label()
        Me.lblPoids = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNaissance = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.grpInfosPerso.SuspendLayout()
        CType(Me.numTaille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPoids, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValide
        '
        Me.btnValide.Location = New System.Drawing.Point(637, 170)
        Me.btnValide.Name = "btnValide"
        Me.btnValide.Size = New System.Drawing.Size(86, 24)
        Me.btnValide.TabIndex = 0
        Me.btnValide.Text = "Valider"
        Me.btnValide.UseVisualStyleBackColor = True
        '
        'grpInfosPerso
        '
        Me.grpInfosPerso.Controls.Add(Me.numTaille)
        Me.grpInfosPerso.Controls.Add(Me.btnValide)
        Me.grpInfosPerso.Controls.Add(Me.numPoids)
        Me.grpInfosPerso.Controls.Add(Me.txtAdresse)
        Me.grpInfosPerso.Controls.Add(Me.lblAdresse)
        Me.grpInfosPerso.Controls.Add(Me.lblTaille)
        Me.grpInfosPerso.Controls.Add(Me.lblPoids)
        Me.grpInfosPerso.Controls.Add(Me.txtEmail)
        Me.grpInfosPerso.Controls.Add(Me.txtTelephone)
        Me.grpInfosPerso.Controls.Add(Me.lblTelephone)
        Me.grpInfosPerso.Controls.Add(Me.lblEmail)
        Me.grpInfosPerso.Controls.Add(Me.TextBox1)
        Me.grpInfosPerso.Controls.Add(Me.lblNaissance)
        Me.grpInfosPerso.Controls.Add(Me.txtPrenom)
        Me.grpInfosPerso.Controls.Add(Me.txtNom)
        Me.grpInfosPerso.Controls.Add(Me.lblNom)
        Me.grpInfosPerso.Controls.Add(Me.lblPrenom)
        Me.grpInfosPerso.Location = New System.Drawing.Point(22, 25)
        Me.grpInfosPerso.Name = "grpInfosPerso"
        Me.grpInfosPerso.Size = New System.Drawing.Size(741, 210)
        Me.grpInfosPerso.TabIndex = 2
        Me.grpInfosPerso.TabStop = False
        Me.grpInfosPerso.Text = "Informations personnelles"
        '
        'numTaille
        '
        Me.numTaille.Location = New System.Drawing.Point(331, 74)
        Me.numTaille.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numTaille.Name = "numTaille"
        Me.numTaille.ReadOnly = True
        Me.numTaille.Size = New System.Drawing.Size(100, 20)
        Me.numTaille.TabIndex = 17
        '
        'numPoids
        '
        Me.numPoids.Location = New System.Drawing.Point(331, 35)
        Me.numPoids.Name = "numPoids"
        Me.numPoids.ReadOnly = True
        Me.numPoids.Size = New System.Drawing.Size(100, 20)
        Me.numPoids.TabIndex = 16
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(596, 114)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.ReadOnly = True
        Me.txtAdresse.Size = New System.Drawing.Size(100, 24)
        Me.txtAdresse.TabIndex = 15
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(521, 125)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(51, 13)
        Me.lblAdresse.TabIndex = 14
        Me.lblAdresse.Text = "Adresse :"
        '
        'lblTaille
        '
        Me.lblTaille.AutoSize = True
        Me.lblTaille.Location = New System.Drawing.Point(238, 81)
        Me.lblTaille.Name = "lblTaille"
        Me.lblTaille.Size = New System.Drawing.Size(84, 13)
        Me.lblTaille.TabIndex = 11
        Me.lblTaille.Text = "Taille ( en CM ) :"
        '
        'lblPoids
        '
        Me.lblPoids.AutoSize = True
        Me.lblPoids.Location = New System.Drawing.Point(238, 42)
        Me.lblPoids.Name = "lblPoids"
        Me.lblPoids.Size = New System.Drawing.Size(87, 13)
        Me.lblPoids.TabIndex = 10
        Me.lblPoids.Text = "Poids ( en KG )  :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(596, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(596, 35)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.ReadOnly = True
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 8
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(521, 42)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(64, 13)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.Text = "Téléphone :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(521, 81)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'lblNaissance
        '
        Me.lblNaissance.AutoSize = True
        Me.lblNaissance.Location = New System.Drawing.Point(25, 125)
        Me.lblNaissance.Name = "lblNaissance"
        Me.lblNaissance.Size = New System.Drawing.Size(87, 13)
        Me.lblNaissance.TabIndex = 4
        Me.lblNaissance.Text = "Date naissance :"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(118, 74)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.ReadOnly = True
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 3
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(118, 35)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(25, 81)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(32, 13)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom:"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(25, 42)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(49, 13)
        Me.lblPrenom.TabIndex = 0
        Me.lblPrenom.Text = "Prénom :"
        '
        'InformationsPersonnellesForm
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 277)
        Me.Controls.Add(Me.grpInfosPerso)
        Me.Name = "InformationsPersonnellesForm"
        Me.Text = "Informations personnelles"
        Me.grpInfosPerso.ResumeLayout(False)
        Me.grpInfosPerso.PerformLayout()
        CType(Me.numTaille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPoids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnValide As Button
    Friend WithEvents grpInfosPerso As GroupBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNaissance As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblTaille As Label
    Friend WithEvents lblPoids As Label
    Friend WithEvents numPoids As NumericUpDown
    Friend WithEvents numTaille As NumericUpDown
End Class
