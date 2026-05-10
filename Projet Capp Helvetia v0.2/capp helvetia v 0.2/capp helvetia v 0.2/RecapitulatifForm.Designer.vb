<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecapitulatifForm
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
        Me.pnlRecapitulatif = New System.Windows.Forms.Panel()
        Me.grbRecap = New System.Windows.Forms.GroupBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnReserver = New System.Windows.Forms.Button()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.grbContact = New System.Windows.Forms.GroupBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaille = New System.Windows.Forms.TextBox()
        Me.txtPoids = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblTaille = New System.Windows.Forms.Label()
        Me.lblPoids = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.grbVol = New System.Windows.Forms.GroupBox()
        Me.txtNbBagage = New System.Windows.Forms.TextBox()
        Me.lblBagage = New System.Windows.Forms.Label()
        Me.dtpDateReservation = New System.Windows.Forms.DateTimePicker()
        Me.txtNbPassager = New System.Windows.Forms.TextBox()
        Me.txtDepart = New System.Windows.Forms.TextBox()
        Me.txtArriver = New System.Windows.Forms.TextBox()
        Me.lblNbPassager = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblArriver = New System.Windows.Forms.Label()
        Me.lblDepart = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlRecapitulatif.SuspendLayout()
        Me.grbRecap.SuspendLayout()
        Me.grbContact.SuspendLayout()
        Me.grbVol.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRecapitulatif
        '
        Me.pnlRecapitulatif.AutoScroll = True
        Me.pnlRecapitulatif.Controls.Add(Me.grbRecap)
        Me.pnlRecapitulatif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRecapitulatif.Location = New System.Drawing.Point(0, 0)
        Me.pnlRecapitulatif.Name = "pnlRecapitulatif"
        Me.pnlRecapitulatif.Size = New System.Drawing.Size(800, 450)
        Me.pnlRecapitulatif.TabIndex = 0
        '
        'grbRecap
        '
        Me.grbRecap.Controls.Add(Me.btnRetour)
        Me.grbRecap.Controls.Add(Me.btnReserver)
        Me.grbRecap.Controls.Add(Me.lblPrix)
        Me.grbRecap.Controls.Add(Me.grbContact)
        Me.grbRecap.Controls.Add(Me.grbVol)
        Me.grbRecap.Controls.Add(Me.Label5)
        Me.grbRecap.Controls.Add(Me.lblDate)
        Me.grbRecap.Controls.Add(Me.lblArriver)
        Me.grbRecap.Controls.Add(Me.lblDepart)
        Me.grbRecap.Controls.Add(Me.lblVille)
        Me.grbRecap.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbRecap.Location = New System.Drawing.Point(18, 6)
        Me.grbRecap.Name = "grbRecap"
        Me.grbRecap.Size = New System.Drawing.Size(754, 851)
        Me.grbRecap.TabIndex = 0
        Me.grbRecap.TabStop = False
        Me.grbRecap.Text = "Récapitulatif"
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(565, 813)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(65, 26)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnReserver
        '
        Me.btnReserver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserver.Location = New System.Drawing.Point(642, 813)
        Me.btnReserver.Name = "btnReserver"
        Me.btnReserver.Size = New System.Drawing.Size(87, 26)
        Me.btnReserver.TabIndex = 5
        Me.btnReserver.Text = "Réserver"
        Me.btnReserver.UseVisualStyleBackColor = True
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(642, 777)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(43, 18)
        Me.lblPrix.TabIndex = 5
        Me.lblPrix.Text = "Prix: "
        '
        'grbContact
        '
        Me.grbContact.BackColor = System.Drawing.Color.Transparent
        Me.grbContact.Controls.Add(Me.txtTelephone)
        Me.grbContact.Controls.Add(Me.Label1)
        Me.grbContact.Controls.Add(Me.txtTaille)
        Me.grbContact.Controls.Add(Me.txtPoids)
        Me.grbContact.Controls.Add(Me.txtEmail)
        Me.grbContact.Controls.Add(Me.txtNom)
        Me.grbContact.Controls.Add(Me.txtPrenom)
        Me.grbContact.Controls.Add(Me.lblTaille)
        Me.grbContact.Controls.Add(Me.lblPoids)
        Me.grbContact.Controls.Add(Me.lblEmail)
        Me.grbContact.Controls.Add(Me.lblPrenom)
        Me.grbContact.Controls.Add(Me.lblNom)
        Me.grbContact.Location = New System.Drawing.Point(19, 381)
        Me.grbContact.Name = "grbContact"
        Me.grbContact.Size = New System.Drawing.Size(710, 380)
        Me.grbContact.TabIndex = 6
        Me.grbContact.TabStop = False
        Me.grbContact.Text = "Votre contact"
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelephone.Location = New System.Drawing.Point(152, 225)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.ReadOnly = True
        Me.txtTelephone.Size = New System.Drawing.Size(312, 20)
        Me.txtTelephone.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Téléphone: "
        '
        'txtTaille
        '
        Me.txtTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTaille.Location = New System.Drawing.Point(152, 320)
        Me.txtTaille.Name = "txtTaille"
        Me.txtTaille.ReadOnly = True
        Me.txtTaille.Size = New System.Drawing.Size(99, 20)
        Me.txtTaille.TabIndex = 11
        '
        'txtPoids
        '
        Me.txtPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPoids.Location = New System.Drawing.Point(152, 276)
        Me.txtPoids.Name = "txtPoids"
        Me.txtPoids.ReadOnly = True
        Me.txtPoids.Size = New System.Drawing.Size(105, 20)
        Me.txtPoids.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(127, 159)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(312, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNom.Location = New System.Drawing.Point(111, 81)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(210, 20)
        Me.txtNom.TabIndex = 8
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPrenom.Location = New System.Drawing.Point(403, 81)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.ReadOnly = True
        Me.txtPrenom.Size = New System.Drawing.Size(230, 20)
        Me.txtPrenom.TabIndex = 7
        '
        'lblTaille
        '
        Me.lblTaille.AutoSize = True
        Me.lblTaille.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaille.Location = New System.Drawing.Point(60, 319)
        Me.lblTaille.Name = "lblTaille"
        Me.lblTaille.Size = New System.Drawing.Size(86, 18)
        Me.lblTaille.TabIndex = 4
        Me.lblTaille.Text = "Taille (cm): "
        '
        'lblPoids
        '
        Me.lblPoids.AutoSize = True
        Me.lblPoids.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoids.Location = New System.Drawing.Point(58, 278)
        Me.lblPoids.Name = "lblPoids"
        Me.lblPoids.Size = New System.Drawing.Size(88, 18)
        Me.lblPoids.TabIndex = 3
        Me.lblPoids.Text = "Poids (kg): "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(60, 158)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(61, 18)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "E-mail: "
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.Location = New System.Drawing.Point(330, 80)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(67, 18)
        Me.lblPrenom.TabIndex = 1
        Me.lblPrenom.Text = "Prénom:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(60, 80)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(45, 18)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Nom:"
        '
        'grbVol
        '
        Me.grbVol.Controls.Add(Me.txtNbBagage)
        Me.grbVol.Controls.Add(Me.lblBagage)
        Me.grbVol.Controls.Add(Me.dtpDateReservation)
        Me.grbVol.Controls.Add(Me.txtNbPassager)
        Me.grbVol.Controls.Add(Me.txtDepart)
        Me.grbVol.Controls.Add(Me.txtArriver)
        Me.grbVol.Controls.Add(Me.lblNbPassager)
        Me.grbVol.Controls.Add(Me.Label2)
        Me.grbVol.Controls.Add(Me.Label3)
        Me.grbVol.Controls.Add(Me.Label4)
        Me.grbVol.Controls.Add(Me.Label6)
        Me.grbVol.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVol.Location = New System.Drawing.Point(19, 33)
        Me.grbVol.Name = "grbVol"
        Me.grbVol.Size = New System.Drawing.Size(710, 324)
        Me.grbVol.TabIndex = 5
        Me.grbVol.TabStop = False
        Me.grbVol.Text = "Vol"
        '
        'txtNbBagage
        '
        Me.txtNbBagage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNbBagage.Location = New System.Drawing.Point(515, 236)
        Me.txtNbBagage.Name = "txtNbBagage"
        Me.txtNbBagage.ReadOnly = True
        Me.txtNbBagage.Size = New System.Drawing.Size(58, 20)
        Me.txtNbBagage.TabIndex = 10
        '
        'lblBagage
        '
        Me.lblBagage.AutoSize = True
        Me.lblBagage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBagage.Location = New System.Drawing.Point(354, 236)
        Me.lblBagage.Name = "lblBagage"
        Me.lblBagage.Size = New System.Drawing.Size(150, 18)
        Me.lblBagage.TabIndex = 9
        Me.lblBagage.Text = "Nombre de Bagage:"
        '
        'dtpDateReservation
        '
        Me.dtpDateReservation.CalendarFont = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateReservation.Enabled = False
        Me.dtpDateReservation.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateReservation.Location = New System.Drawing.Point(152, 169)
        Me.dtpDateReservation.Name = "dtpDateReservation"
        Me.dtpDateReservation.Size = New System.Drawing.Size(226, 25)
        Me.dtpDateReservation.TabIndex = 8
        '
        'txtNbPassager
        '
        Me.txtNbPassager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNbPassager.Location = New System.Drawing.Point(213, 237)
        Me.txtNbPassager.Name = "txtNbPassager"
        Me.txtNbPassager.ReadOnly = True
        Me.txtNbPassager.Size = New System.Drawing.Size(58, 20)
        Me.txtNbPassager.TabIndex = 7
        '
        'txtDepart
        '
        Me.txtDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDepart.Location = New System.Drawing.Point(171, 100)
        Me.txtDepart.Name = "txtDepart"
        Me.txtDepart.ReadOnly = True
        Me.txtDepart.Size = New System.Drawing.Size(142, 20)
        Me.txtDepart.TabIndex = 6
        '
        'txtArriver
        '
        Me.txtArriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtArriver.Location = New System.Drawing.Point(431, 100)
        Me.txtArriver.Name = "txtArriver"
        Me.txtArriver.ReadOnly = True
        Me.txtArriver.Size = New System.Drawing.Size(142, 20)
        Me.txtArriver.TabIndex = 5
        '
        'lblNbPassager
        '
        Me.lblNbPassager.AutoSize = True
        Me.lblNbPassager.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbPassager.Location = New System.Drawing.Point(47, 236)
        Me.lblNbPassager.Name = "lblNbPassager"
        Me.lblNbPassager.Size = New System.Drawing.Size(160, 18)
        Me.lblNbPassager.TabIndex = 4
        Me.lblNbPassager.Text = "Nombre de passager:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Arriver: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Départ: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(60, 240)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(62, 18)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date: ..."
        '
        'lblArriver
        '
        Me.lblArriver.AutoSize = True
        Me.lblArriver.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArriver.Location = New System.Drawing.Point(60, 187)
        Me.lblArriver.Name = "lblArriver"
        Me.lblArriver.Size = New System.Drawing.Size(74, 18)
        Me.lblArriver.TabIndex = 2
        Me.lblArriver.Text = "Arriver: ..."
        '
        'lblDepart
        '
        Me.lblDepart.AutoSize = True
        Me.lblDepart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepart.Location = New System.Drawing.Point(60, 141)
        Me.lblDepart.Name = "lblDepart"
        Me.lblDepart.Size = New System.Drawing.Size(76, 18)
        Me.lblDepart.TabIndex = 1
        Me.lblDepart.Text = "Départ: ..."
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVille.Location = New System.Drawing.Point(60, 80)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(42, 18)
        Me.lblVille.TabIndex = 0
        Me.lblVille.Text = "Ville "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RecapitulatifForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlRecapitulatif)
        Me.Name = "RecapitulatifForm"
        Me.Text = "RecapitulatifForm"
        Me.pnlRecapitulatif.ResumeLayout(False)
        Me.grbRecap.ResumeLayout(False)
        Me.grbRecap.PerformLayout()
        Me.grbContact.ResumeLayout(False)
        Me.grbContact.PerformLayout()
        Me.grbVol.ResumeLayout(False)
        Me.grbVol.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRecapitulatif As Panel
    Friend WithEvents grbRecap As GroupBox
    Friend WithEvents lblVille As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblArriver As Label
    Friend WithEvents lblDepart As Label
    Friend WithEvents grbContact As GroupBox
    Friend WithEvents lblTaille As Label
    Friend WithEvents lblPoids As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents grbVol As GroupBox
    Friend WithEvents lblNbPassager As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNbPassager As TextBox
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents txtArriver As TextBox
    Friend WithEvents dtpDateReservation As DateTimePicker
    Friend WithEvents txtNbBagage As TextBox
    Friend WithEvents lblBagage As Label
    Friend WithEvents btnReserver As Button
    Friend WithEvents lblPrix As Label
    Friend WithEvents txtTaille As TextBox
    Friend WithEvents txtPoids As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents Button1 As Button
End Class
