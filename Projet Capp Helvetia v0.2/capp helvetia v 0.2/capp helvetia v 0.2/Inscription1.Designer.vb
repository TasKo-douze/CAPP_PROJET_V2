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
        Me.pnlInscription = New System.Windows.Forms.Panel()
        Me.btnValiderInscription = New System.Windows.Forms.Button()
        Me.lblInscription = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbPays = New System.Windows.Forms.TextBox()
        Me.txtbNumero = New System.Windows.Forms.TextBox()
        Me.txtbVille = New System.Windows.Forms.TextBox()
        Me.txtbRue = New System.Windows.Forms.TextBox()
        Me.lblPays = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblRue = New System.Windows.Forms.Label()
        Me.grpbInfoPerso = New System.Windows.Forms.GroupBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.lblCm = New System.Windows.Forms.Label()
        Me.nudPoids = New System.Windows.Forms.NumericUpDown()
        Me.nudTaille = New System.Windows.Forms.NumericUpDown()
        Me.lblTaille = New System.Windows.Forms.Label()
        Me.lblPoids = New System.Windows.Forms.Label()
        Me.mtxtbTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateNaissance = New System.Windows.Forms.Label()
        Me.dtpDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtbMDPIns = New System.Windows.Forms.TextBox()
        Me.lblMDP = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.txtbPrenom = New System.Windows.Forms.TextBox()
        Me.txtbNom = New System.Windows.Forms.TextBox()
        Me.pnlInscription.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbInfoPerso.SuspendLayout()
        CType(Me.nudPoids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTaille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInscription
        '
        Me.pnlInscription.AutoScroll = True
        Me.pnlInscription.Controls.Add(Me.btnValiderInscription)
        Me.pnlInscription.Controls.Add(Me.lblInscription)
        Me.pnlInscription.Controls.Add(Me.GroupBox1)
        Me.pnlInscription.Controls.Add(Me.grpbInfoPerso)
        Me.pnlInscription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInscription.Location = New System.Drawing.Point(0, 0)
        Me.pnlInscription.Name = "pnlInscription"
        Me.pnlInscription.Size = New System.Drawing.Size(452, 498)
        Me.pnlInscription.TabIndex = 8
        '
        'btnValiderInscription
        '
        Me.btnValiderInscription.Location = New System.Drawing.Point(289, 738)
        Me.btnValiderInscription.Name = "btnValiderInscription"
        Me.btnValiderInscription.Size = New System.Drawing.Size(75, 23)
        Me.btnValiderInscription.TabIndex = 3
        Me.btnValiderInscription.Text = "Valider"
        Me.btnValiderInscription.UseVisualStyleBackColor = True
        '
        'lblInscription
        '
        Me.lblInscription.AutoSize = True
        Me.lblInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscription.Location = New System.Drawing.Point(124, 26)
        Me.lblInscription.Name = "lblInscription"
        Me.lblInscription.Size = New System.Drawing.Size(187, 39)
        Me.lblInscription.TabIndex = 2
        Me.lblInscription.Text = "Inscription"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbPays)
        Me.GroupBox1.Controls.Add(Me.txtbNumero)
        Me.GroupBox1.Controls.Add(Me.txtbVille)
        Me.GroupBox1.Controls.Add(Me.txtbRue)
        Me.GroupBox1.Controls.Add(Me.lblPays)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.lblVille)
        Me.GroupBox1.Controls.Add(Me.lblRue)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 490)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 207)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "II. Information Adresse"
        '
        'txtbPays
        '
        Me.txtbPays.Location = New System.Drawing.Point(122, 149)
        Me.txtbPays.Name = "txtbPays"
        Me.txtbPays.ReadOnly = True
        Me.txtbPays.Size = New System.Drawing.Size(100, 20)
        Me.txtbPays.TabIndex = 7
        Me.txtbPays.Text = "Suisse"
        '
        'txtbNumero
        '
        Me.txtbNumero.Location = New System.Drawing.Point(122, 115)
        Me.txtbNumero.Name = "txtbNumero"
        Me.txtbNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtbNumero.TabIndex = 6
        '
        'txtbVille
        '
        Me.txtbVille.Location = New System.Drawing.Point(122, 80)
        Me.txtbVille.Name = "txtbVille"
        Me.txtbVille.Size = New System.Drawing.Size(100, 20)
        Me.txtbVille.TabIndex = 5
        '
        'txtbRue
        '
        Me.txtbRue.Location = New System.Drawing.Point(122, 45)
        Me.txtbRue.Name = "txtbRue"
        Me.txtbRue.Size = New System.Drawing.Size(100, 20)
        Me.txtbRue.TabIndex = 4
        '
        'lblPays
        '
        Me.lblPays.AutoSize = True
        Me.lblPays.Location = New System.Drawing.Point(6, 152)
        Me.lblPays.Name = "lblPays"
        Me.lblPays.Size = New System.Drawing.Size(33, 13)
        Me.lblPays.TabIndex = 3
        Me.lblPays.Text = "Pays:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(9, 118)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Numéro:"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Location = New System.Drawing.Point(9, 83)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(29, 13)
        Me.lblVille.TabIndex = 1
        Me.lblVille.Text = "Ville:"
        '
        'lblRue
        '
        Me.lblRue.AutoSize = True
        Me.lblRue.Location = New System.Drawing.Point(9, 52)
        Me.lblRue.Name = "lblRue"
        Me.lblRue.Size = New System.Drawing.Size(30, 13)
        Me.lblRue.TabIndex = 0
        Me.lblRue.Text = "Rue:"
        '
        'grpbInfoPerso
        '
        Me.grpbInfoPerso.Controls.Add(Me.lblKg)
        Me.grpbInfoPerso.Controls.Add(Me.lblCm)
        Me.grpbInfoPerso.Controls.Add(Me.nudPoids)
        Me.grpbInfoPerso.Controls.Add(Me.nudTaille)
        Me.grpbInfoPerso.Controls.Add(Me.lblTaille)
        Me.grpbInfoPerso.Controls.Add(Me.lblPoids)
        Me.grpbInfoPerso.Controls.Add(Me.mtxtbTelephone)
        Me.grpbInfoPerso.Controls.Add(Me.lblDateNaissance)
        Me.grpbInfoPerso.Controls.Add(Me.dtpDateNaissance)
        Me.grpbInfoPerso.Controls.Add(Me.lblTelephone)
        Me.grpbInfoPerso.Controls.Add(Me.lblPrenom)
        Me.grpbInfoPerso.Controls.Add(Me.lblNom)
        Me.grpbInfoPerso.Controls.Add(Me.txtbMDPIns)
        Me.grpbInfoPerso.Controls.Add(Me.lblMDP)
        Me.grpbInfoPerso.Controls.Add(Me.lblEmail)
        Me.grpbInfoPerso.Controls.Add(Me.txtbEmail)
        Me.grpbInfoPerso.Controls.Add(Me.txtbPrenom)
        Me.grpbInfoPerso.Controls.Add(Me.txtbNom)
        Me.grpbInfoPerso.Location = New System.Drawing.Point(81, 96)
        Me.grpbInfoPerso.Name = "grpbInfoPerso"
        Me.grpbInfoPerso.Size = New System.Drawing.Size(283, 355)
        Me.grpbInfoPerso.TabIndex = 0
        Me.grpbInfoPerso.TabStop = False
        Me.grpbInfoPerso.Text = "I. Information Personnel"
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(183, 328)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(19, 13)
        Me.lblKg.TabIndex = 20
        Me.lblKg.Text = "kg"
        '
        'lblCm
        '
        Me.lblCm.AutoSize = True
        Me.lblCm.Location = New System.Drawing.Point(183, 295)
        Me.lblCm.Name = "lblCm"
        Me.lblCm.Size = New System.Drawing.Size(21, 13)
        Me.lblCm.TabIndex = 19
        Me.lblCm.Text = "cm"
        '
        'nudPoids
        '
        Me.nudPoids.Location = New System.Drawing.Point(122, 321)
        Me.nudPoids.Name = "nudPoids"
        Me.nudPoids.Size = New System.Drawing.Size(54, 20)
        Me.nudPoids.TabIndex = 18
        '
        'nudTaille
        '
        Me.nudTaille.Location = New System.Drawing.Point(122, 288)
        Me.nudTaille.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudTaille.Name = "nudTaille"
        Me.nudTaille.Size = New System.Drawing.Size(54, 20)
        Me.nudTaille.TabIndex = 17
        '
        'lblTaille
        '
        Me.lblTaille.AutoSize = True
        Me.lblTaille.Location = New System.Drawing.Point(9, 290)
        Me.lblTaille.Name = "lblTaille"
        Me.lblTaille.Size = New System.Drawing.Size(35, 13)
        Me.lblTaille.TabIndex = 16
        Me.lblTaille.Text = "Taille:"
        '
        'lblPoids
        '
        Me.lblPoids.AutoSize = True
        Me.lblPoids.Location = New System.Drawing.Point(9, 323)
        Me.lblPoids.Name = "lblPoids"
        Me.lblPoids.Size = New System.Drawing.Size(36, 13)
        Me.lblPoids.TabIndex = 15
        Me.lblPoids.Text = "Poids:"
        '
        'mtxtbTelephone
        '
        Me.mtxtbTelephone.Location = New System.Drawing.Point(122, 186)
        Me.mtxtbTelephone.Name = "mtxtbTelephone"
        Me.mtxtbTelephone.Size = New System.Drawing.Size(100, 20)
        Me.mtxtbTelephone.TabIndex = 14
        '
        'lblDateNaissance
        '
        Me.lblDateNaissance.AutoSize = True
        Me.lblDateNaissance.Location = New System.Drawing.Point(6, 237)
        Me.lblDateNaissance.Name = "lblDateNaissance"
        Me.lblDateNaissance.Size = New System.Drawing.Size(98, 13)
        Me.lblDateNaissance.TabIndex = 13
        Me.lblDateNaissance.Text = "Date de Naissance"
        '
        'dtpDateNaissance
        '
        Me.dtpDateNaissance.CustomFormat = "dd.mm.yyyy"
        Me.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateNaissance.Location = New System.Drawing.Point(122, 237)
        Me.dtpDateNaissance.Name = "dtpDateNaissance"
        Me.dtpDateNaissance.Size = New System.Drawing.Size(100, 20)
        Me.dtpDateNaissance.TabIndex = 12
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(6, 189)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 11
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(6, 64)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(46, 13)
        Me.lblPrenom.TabIndex = 9
        Me.lblPrenom.Text = "Prenom:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(9, 34)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(32, 13)
        Me.lblNom.TabIndex = 8
        Me.lblNom.Text = "Nom:"
        '
        'txtbMDPIns
        '
        Me.txtbMDPIns.Location = New System.Drawing.Point(122, 145)
        Me.txtbMDPIns.Name = "txtbMDPIns"
        Me.txtbMDPIns.Size = New System.Drawing.Size(100, 20)
        Me.txtbMDPIns.TabIndex = 7
        '
        'lblMDP
        '
        Me.lblMDP.AutoSize = True
        Me.lblMDP.Location = New System.Drawing.Point(6, 148)
        Me.lblMDP.Name = "lblMDP"
        Me.lblMDP.Size = New System.Drawing.Size(74, 13)
        Me.lblMDP.TabIndex = 6
        Me.lblMDP.Text = "Mot de passe:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 116)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(122, 113)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtbEmail.TabIndex = 4
        '
        'txtbPrenom
        '
        Me.txtbPrenom.Location = New System.Drawing.Point(122, 61)
        Me.txtbPrenom.Name = "txtbPrenom"
        Me.txtbPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtbPrenom.TabIndex = 3
        '
        'txtbNom
        '
        Me.txtbNom.Location = New System.Drawing.Point(122, 31)
        Me.txtbNom.Name = "txtbNom"
        Me.txtbNom.Size = New System.Drawing.Size(100, 20)
        Me.txtbNom.TabIndex = 2
        '
        'Inscription1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 498)
        Me.Controls.Add(Me.pnlInscription)
        Me.Name = "Inscription1"
        Me.Text = "Form1"
        Me.pnlInscription.ResumeLayout(False)
        Me.pnlInscription.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbInfoPerso.ResumeLayout(False)
        Me.grpbInfoPerso.PerformLayout()
        CType(Me.nudPoids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTaille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInscription As Panel
    Friend WithEvents grpbInfoPerso As GroupBox
    Friend WithEvents txtbNom As TextBox
    Friend WithEvents txtbPrenom As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents lblMDP As Label
    Friend WithEvents txtbMDPIns As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents dtpDateNaissance As DateTimePicker
    Friend WithEvents lblDateNaissance As Label
    Friend WithEvents mtxtbTelephone As MaskedTextBox
    Friend WithEvents lblTaille As Label
    Friend WithEvents lblPoids As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblRue As Label
    Friend WithEvents lblKg As Label
    Friend WithEvents lblCm As Label
    Friend WithEvents nudPoids As NumericUpDown
    Friend WithEvents nudTaille As NumericUpDown
    Friend WithEvents lblPays As Label
    Friend WithEvents txtbPays As TextBox
    Friend WithEvents txtbNumero As TextBox
    Friend WithEvents txtbVille As TextBox
    Friend WithEvents txtbRue As TextBox
    Friend WithEvents lblInscription As Label
    Friend WithEvents btnValiderInscription As Button
End Class
