<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnInformationsPersonnelles = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnHistorique = New System.Windows.Forms.Button()
        Me.btnAPropos = New System.Windows.Forms.Button()
        Me.btnConfidentialiteDonner = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSecurite = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnInformationsPersonnelles
        '
        Me.btnInformationsPersonnelles.Location = New System.Drawing.Point(195, 126)
        Me.btnInformationsPersonnelles.Name = "btnInformationsPersonnelles"
        Me.btnInformationsPersonnelles.Size = New System.Drawing.Size(138, 36)
        Me.btnInformationsPersonnelles.TabIndex = 3
        Me.btnInformationsPersonnelles.Text = "Informations personnelles"
        Me.btnInformationsPersonnelles.UseVisualStyleBackColor = True
        '
        'btnHistorique
        '
        Me.btnHistorique.Location = New System.Drawing.Point(195, 185)
        Me.btnHistorique.Name = "btnHistorique"
        Me.btnHistorique.Size = New System.Drawing.Size(138, 36)
        Me.btnHistorique.TabIndex = 4
        Me.btnHistorique.Text = "Historique"
        Me.btnHistorique.UseVisualStyleBackColor = True
        '
        'btnAPropos
        '
        Me.btnAPropos.Location = New System.Drawing.Point(195, 316)
        Me.btnAPropos.Name = "btnAPropos"
        Me.btnAPropos.Size = New System.Drawing.Size(138, 36)
        Me.btnAPropos.TabIndex = 5
        Me.btnAPropos.Text = "A propos"
        Me.btnAPropos.UseVisualStyleBackColor = True
        '
        'btnConfidentialiteDonner
        '
        Me.btnConfidentialiteDonner.Location = New System.Drawing.Point(195, 249)
        Me.btnConfidentialiteDonner.Name = "btnConfidentialiteDonner"
        Me.btnConfidentialiteDonner.Size = New System.Drawing.Size(138, 36)
        Me.btnConfidentialiteDonner.TabIndex = 6
        Me.btnConfidentialiteDonner.Text = "Confidentialité"
        Me.btnConfidentialiteDonner.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(12, 64)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(201, 37)
        Me.lblTitre.TabIndex = 7
        Me.lblTitre.Text = "VOTRE PROFIL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(12, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(51, 26)
        Me.btnMenu.TabIndex = 8
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnSecurite
        '
        Me.btnSecurite.Location = New System.Drawing.Point(195, 383)
        Me.btnSecurite.Name = "btnSecurite"
        Me.btnSecurite.Size = New System.Drawing.Size(138, 36)
        Me.btnSecurite.TabIndex = 9
        Me.btnSecurite.Text = "Sécurité"
        Me.btnSecurite.UseVisualStyleBackColor = True
        '
        'ProfilForm
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.btnSecurite)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnConfidentialiteDonner)
        Me.Controls.Add(Me.btnAPropos)
        Me.Controls.Add(Me.btnHistorique)
        Me.Controls.Add(Me.btnInformationsPersonnelles)
        Me.Name = "ProfilForm"
        Me.Text = "Profil"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnInformationsPersonnelles As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnHistorique As Button
    Friend WithEvents btnAPropos As Button
    Friend WithEvents btnConfidentialiteDonner As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnSecurite As Button
End Class
