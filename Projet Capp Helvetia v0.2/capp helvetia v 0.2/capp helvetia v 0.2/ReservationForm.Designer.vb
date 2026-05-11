<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.lblVilleDepart = New System.Windows.Forms.Label()
        Me.lblArriveVille = New System.Windows.Forms.Label()
        Me.cbmVilleDepart = New System.Windows.Forms.ComboBox()
        Me.cbmVilleArriver = New System.Windows.Forms.ComboBox()
        Me.grbVille = New System.Windows.Forms.GroupBox()
        Me.dtpDateDepart = New System.Windows.Forms.DateTimePicker()
        Me.lblDateDepart = New System.Windows.Forms.Label()
        Me.lblNbPassager = New System.Windows.Forms.Label()
        Me.lblBagage = New System.Windows.Forms.Label()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.cbmBagage = New System.Windows.Forms.ComboBox()
        Me.cbmPassager = New System.Windows.Forms.ComboBox()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.grbVille.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(772, 388)
        Me.btnSuivant.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(136, 33)
        Me.btnSuivant.TabIndex = 0
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'lblVilleDepart
        '
        Me.lblVilleDepart.AutoSize = True
        Me.lblVilleDepart.Location = New System.Drawing.Point(7, 35)
        Me.lblVilleDepart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVilleDepart.Name = "lblVilleDepart"
        Me.lblVilleDepart.Size = New System.Drawing.Size(97, 17)
        Me.lblVilleDepart.TabIndex = 1
        Me.lblVilleDepart.Text = "Ville de départ:"
        '
        'lblArriveVille
        '
        Me.lblArriveVille.AutoSize = True
        Me.lblArriveVille.Location = New System.Drawing.Point(257, 35)
        Me.lblArriveVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArriveVille.Name = "lblArriveVille"
        Me.lblArriveVille.Size = New System.Drawing.Size(88, 17)
        Me.lblArriveVille.TabIndex = 2
        Me.lblArriveVille.Text = "Ville d'arriver:"
        '
        'cbmVilleDepart
        '
        Me.cbmVilleDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmVilleDepart.FormattingEnabled = True
        Me.cbmVilleDepart.Location = New System.Drawing.Point(10, 71)
        Me.cbmVilleDepart.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmVilleDepart.Name = "cbmVilleDepart"
        Me.cbmVilleDepart.Size = New System.Drawing.Size(170, 25)
        Me.cbmVilleDepart.TabIndex = 3
        '
        'cbmVilleArriver
        '
        Me.cbmVilleArriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmVilleArriver.FormattingEnabled = True
        Me.cbmVilleArriver.Location = New System.Drawing.Point(260, 71)
        Me.cbmVilleArriver.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmVilleArriver.Name = "cbmVilleArriver"
        Me.cbmVilleArriver.Size = New System.Drawing.Size(170, 25)
        Me.cbmVilleArriver.TabIndex = 4
        '
        'grbVille
        '
        Me.grbVille.Controls.Add(Me.dtpDateDepart)
        Me.grbVille.Controls.Add(Me.lblDateDepart)
        Me.grbVille.Controls.Add(Me.lblVilleDepart)
        Me.grbVille.Controls.Add(Me.cbmVilleArriver)
        Me.grbVille.Controls.Add(Me.cbmVilleDepart)
        Me.grbVille.Controls.Add(Me.lblArriveVille)
        Me.grbVille.Location = New System.Drawing.Point(26, 127)
        Me.grbVille.Margin = New System.Windows.Forms.Padding(4)
        Me.grbVille.Name = "grbVille"
        Me.grbVille.Padding = New System.Windows.Forms.Padding(4)
        Me.grbVille.Size = New System.Drawing.Size(472, 260)
        Me.grbVille.TabIndex = 5
        Me.grbVille.TabStop = False
        Me.grbVille.Text = "Trajet"
        '
        'dtpDateDepart
        '
        Me.dtpDateDepart.Location = New System.Drawing.Point(117, 174)
        Me.dtpDateDepart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateDepart.Name = "dtpDateDepart"
        Me.dtpDateDepart.Size = New System.Drawing.Size(198, 25)
        Me.dtpDateDepart.TabIndex = 7
        '
        'lblDateDepart
        '
        Me.lblDateDepart.AutoSize = True
        Me.lblDateDepart.Location = New System.Drawing.Point(170, 153)
        Me.lblDateDepart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateDepart.Name = "lblDateDepart"
        Me.lblDateDepart.Size = New System.Drawing.Size(104, 17)
        Me.lblDateDepart.TabIndex = 5
        Me.lblDateDepart.Text = "Date de départ :"
        '
        'lblNbPassager
        '
        Me.lblNbPassager.AutoSize = True
        Me.lblNbPassager.Location = New System.Drawing.Point(12, 35)
        Me.lblNbPassager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbPassager.Name = "lblNbPassager"
        Me.lblNbPassager.Size = New System.Drawing.Size(141, 17)
        Me.lblNbPassager.TabIndex = 6
        Me.lblNbPassager.Text = "Nombre de passager :"
        '
        'lblBagage
        '
        Me.lblBagage.AutoSize = True
        Me.lblBagage.Location = New System.Drawing.Point(241, 35)
        Me.lblBagage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBagage.Name = "lblBagage"
        Me.lblBagage.Size = New System.Drawing.Size(59, 17)
        Me.lblBagage.TabIndex = 8
        Me.lblBagage.Text = "Bagage :"
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(772, 429)
        Me.btnPrecedent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(136, 33)
        Me.btnPrecedent.TabIndex = 11
        Me.btnPrecedent.Text = "Précedent "
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.cbmBagage)
        Me.grpDetails.Controls.Add(Me.cbmPassager)
        Me.grpDetails.Controls.Add(Me.lblBagage)
        Me.grpDetails.Controls.Add(Me.lblNbPassager)
        Me.grpDetails.Location = New System.Drawing.Point(532, 127)
        Me.grpDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDetails.Size = New System.Drawing.Size(377, 152)
        Me.grpDetails.TabIndex = 12
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Détails réservation"
        '
        'cbmBagage
        '
        Me.cbmBagage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmBagage.FormattingEnabled = True
        Me.cbmBagage.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cbmBagage.Location = New System.Drawing.Point(245, 71)
        Me.cbmBagage.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmBagage.Name = "cbmBagage"
        Me.cbmBagage.Size = New System.Drawing.Size(56, 25)
        Me.cbmBagage.TabIndex = 12
        '
        'cbmPassager
        '
        Me.cbmPassager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmPassager.FormattingEnabled = True
        Me.cbmPassager.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cbmPassager.Location = New System.Drawing.Point(15, 71)
        Me.cbmPassager.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmPassager.Name = "cbmPassager"
        Me.cbmPassager.Size = New System.Drawing.Size(56, 25)
        Me.cbmPassager.TabIndex = 11
        '
        'lblReservation
        '
        Me.lblReservation.AutoSize = True
        Me.lblReservation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservation.Location = New System.Drawing.Point(22, 37)
        Me.lblReservation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(92, 21)
        Me.lblReservation.TabIndex = 13
        Me.lblReservation.Text = "Réservation"
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(933, 545)
        Me.Controls.Add(Me.lblReservation)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.grbVille)
        Me.Controls.Add(Me.btnSuivant)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReservationForm"
        Me.Text = "Réservation"
        Me.grbVille.ResumeLayout(False)
        Me.grbVille.PerformLayout()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSuivant As Button
    Friend WithEvents lblVilleDepart As Label
    Friend WithEvents lblArriveVille As Label
    Friend WithEvents cbmVilleDepart As ComboBox
    Friend WithEvents cbmVilleArriver As ComboBox
    Friend WithEvents grbVille As GroupBox
    Friend WithEvents lblNbPassager As Label
    Friend WithEvents lblBagage As Label
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents cbmPassager As ComboBox
    Friend WithEvents dtpDateDepart As DateTimePicker
    Friend WithEvents lblDateDepart As Label
    Friend WithEvents cbmBagage As ComboBox
    Friend WithEvents lblReservation As Label
End Class
