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
        Me.cbmNbPassager = New System.Windows.Forms.ComboBox()
        Me.lblNbPassager = New System.Windows.Forms.Label()
        Me.dtpDateDepart = New System.Windows.Forms.DateTimePicker()
        Me.lblDateDepart = New System.Windows.Forms.Label()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.wbGoogleMaps = New System.Windows.Forms.WebBrowser()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.pnlReservation = New System.Windows.Forms.Panel()
        Me.grbVille.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.pnlReservation.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(684, 711)
        Me.btnSuivant.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(95, 33)
        Me.btnSuivant.TabIndex = 0
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'lblVilleDepart
        '
        Me.lblVilleDepart.AutoSize = True
        Me.lblVilleDepart.Location = New System.Drawing.Point(35, 61)
        Me.lblVilleDepart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVilleDepart.Name = "lblVilleDepart"
        Me.lblVilleDepart.Size = New System.Drawing.Size(97, 17)
        Me.lblVilleDepart.TabIndex = 1
        Me.lblVilleDepart.Text = "Ville de départ:"
        '
        'lblArriveVille
        '
        Me.lblArriveVille.AutoSize = True
        Me.lblArriveVille.Location = New System.Drawing.Point(313, 61)
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
        Me.cbmVilleDepart.Location = New System.Drawing.Point(38, 97)
        Me.cbmVilleDepart.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmVilleDepart.Name = "cbmVilleDepart"
        Me.cbmVilleDepart.Size = New System.Drawing.Size(170, 25)
        Me.cbmVilleDepart.TabIndex = 3
        '
        'cbmVilleArriver
        '
        Me.cbmVilleArriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmVilleArriver.FormattingEnabled = True
        Me.cbmVilleArriver.Location = New System.Drawing.Point(316, 97)
        Me.cbmVilleArriver.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmVilleArriver.Name = "cbmVilleArriver"
        Me.cbmVilleArriver.Size = New System.Drawing.Size(170, 25)
        Me.cbmVilleArriver.TabIndex = 4
        '
        'grbVille
        '
        Me.grbVille.Controls.Add(Me.cbmNbPassager)
        Me.grbVille.Controls.Add(Me.lblNbPassager)
        Me.grbVille.Controls.Add(Me.dtpDateDepart)
        Me.grbVille.Controls.Add(Me.lblDateDepart)
        Me.grbVille.Controls.Add(Me.lblVilleDepart)
        Me.grbVille.Controls.Add(Me.cbmVilleArriver)
        Me.grbVille.Controls.Add(Me.cbmVilleDepart)
        Me.grbVille.Controls.Add(Me.lblArriveVille)
        Me.grbVille.Location = New System.Drawing.Point(100, 67)
        Me.grbVille.Margin = New System.Windows.Forms.Padding(4)
        Me.grbVille.Name = "grbVille"
        Me.grbVille.Padding = New System.Windows.Forms.Padding(4)
        Me.grbVille.Size = New System.Drawing.Size(562, 296)
        Me.grbVille.TabIndex = 5
        Me.grbVille.TabStop = False
        Me.grbVille.Text = "Trajet"
        '
        'cbmNbPassager
        '
        Me.cbmNbPassager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmNbPassager.FormattingEnabled = True
        Me.cbmNbPassager.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbmNbPassager.Location = New System.Drawing.Point(38, 225)
        Me.cbmNbPassager.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmNbPassager.Name = "cbmNbPassager"
        Me.cbmNbPassager.Size = New System.Drawing.Size(170, 25)
        Me.cbmNbPassager.TabIndex = 9
        '
        'lblNbPassager
        '
        Me.lblNbPassager.AutoSize = True
        Me.lblNbPassager.Location = New System.Drawing.Point(36, 201)
        Me.lblNbPassager.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbPassager.Name = "lblNbPassager"
        Me.lblNbPassager.Size = New System.Drawing.Size(137, 17)
        Me.lblNbPassager.TabIndex = 8
        Me.lblNbPassager.Text = "Nombre de passager:"
        '
        'dtpDateDepart
        '
        Me.dtpDateDepart.Location = New System.Drawing.Point(316, 225)
        Me.dtpDateDepart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateDepart.Name = "dtpDateDepart"
        Me.dtpDateDepart.Size = New System.Drawing.Size(198, 25)
        Me.dtpDateDepart.TabIndex = 7
        '
        'lblDateDepart
        '
        Me.lblDateDepart.AutoSize = True
        Me.lblDateDepart.Location = New System.Drawing.Point(313, 204)
        Me.lblDateDepart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateDepart.Name = "lblDateDepart"
        Me.lblDateDepart.Size = New System.Drawing.Size(104, 17)
        Me.lblDateDepart.TabIndex = 5
        Me.lblDateDepart.Text = "Date de départ :"
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(80, 711)
        Me.btnPrecedent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(95, 33)
        Me.btnPrecedent.TabIndex = 11
        Me.btnPrecedent.Text = "Précedent "
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.wbGoogleMaps)
        Me.grpDetails.Location = New System.Drawing.Point(100, 408)
        Me.grpDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDetails.Size = New System.Drawing.Size(562, 268)
        Me.grpDetails.TabIndex = 12
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Détails réservation"
        '
        'wbGoogleMaps
        '
        Me.wbGoogleMaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbGoogleMaps.Location = New System.Drawing.Point(4, 22)
        Me.wbGoogleMaps.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbGoogleMaps.Name = "wbGoogleMaps"
        Me.wbGoogleMaps.Size = New System.Drawing.Size(554, 242)
        Me.wbGoogleMaps.TabIndex = 0
        '
        'lblReservation
        '
        Me.lblReservation.AutoSize = True
        Me.lblReservation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservation.Location = New System.Drawing.Point(13, 20)
        Me.lblReservation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(92, 21)
        Me.lblReservation.TabIndex = 13
        Me.lblReservation.Text = "Réservation"
        '
        'pnlReservation
        '
        Me.pnlReservation.AutoScroll = True
        Me.pnlReservation.Controls.Add(Me.lblReservation)
        Me.pnlReservation.Controls.Add(Me.grpDetails)
        Me.pnlReservation.Controls.Add(Me.btnPrecedent)
        Me.pnlReservation.Controls.Add(Me.grbVille)
        Me.pnlReservation.Controls.Add(Me.btnSuivant)
        Me.pnlReservation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReservation.Location = New System.Drawing.Point(0, 0)
        Me.pnlReservation.Name = "pnlReservation"
        Me.pnlReservation.Size = New System.Drawing.Size(800, 450)
        Me.pnlReservation.TabIndex = 14
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlReservation)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReservationForm"
        Me.Text = "Réservation"
        Me.grbVille.ResumeLayout(False)
        Me.grbVille.PerformLayout()
        Me.grpDetails.ResumeLayout(False)
        Me.pnlReservation.ResumeLayout(False)
        Me.pnlReservation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSuivant As Button
    Friend WithEvents lblVilleDepart As Label
    Friend WithEvents lblArriveVille As Label
    Friend WithEvents cbmVilleDepart As ComboBox
    Friend WithEvents cbmVilleArriver As ComboBox
    Friend WithEvents grbVille As GroupBox
    Friend WithEvents btnPrecedent As Button
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents dtpDateDepart As DateTimePicker
    Friend WithEvents lblDateDepart As Label
    Friend WithEvents lblReservation As Label
    Friend WithEvents wbGoogleMaps As WebBrowser
    Friend WithEvents cbmNbPassager As ComboBox
    Friend WithEvents lblNbPassager As Label
    Friend WithEvents pnlReservation As Panel
End Class
