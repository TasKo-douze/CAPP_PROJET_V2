<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfidentialiteDonneesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfidentialiteDonneesForm))
        Me.lblTitreConf = New System.Windows.Forms.Label()
        Me.lblContenue = New System.Windows.Forms.Label()
        Me.txtMessageConfidentialite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitreConf
        '
        Me.lblTitreConf.AutoSize = True
        Me.lblTitreConf.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreConf.Location = New System.Drawing.Point(12, 23)
        Me.lblTitreConf.Name = "lblTitreConf"
        Me.lblTitreConf.Size = New System.Drawing.Size(159, 30)
        Me.lblTitreConf.TabIndex = 0
        Me.lblTitreConf.Text = "Confidentialité" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblContenue
        '
        Me.lblContenue.Location = New System.Drawing.Point(14, 85)
        Me.lblContenue.Name = "lblContenue"
        Me.lblContenue.Size = New System.Drawing.Size(285, 281)
        Me.lblContenue.TabIndex = 1
        '
        'txtMessageConfidentialite
        '
        Me.txtMessageConfidentialite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessageConfidentialite.Location = New System.Drawing.Point(17, 70)
        Me.txtMessageConfidentialite.Multiline = True
        Me.txtMessageConfidentialite.Name = "txtMessageConfidentialite"
        Me.txtMessageConfidentialite.ReadOnly = True
        Me.txtMessageConfidentialite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessageConfidentialite.Size = New System.Drawing.Size(282, 353)
        Me.txtMessageConfidentialite.TabIndex = 3
        Me.txtMessageConfidentialite.TabStop = False
        Me.txtMessageConfidentialite.Text = resources.GetString("txtMessageConfidentialite.Text")
        '
        'ConfidentialiteDonneesForm
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 450)
        Me.Controls.Add(Me.txtMessageConfidentialite)
        Me.Controls.Add(Me.lblContenue)
        Me.Controls.Add(Me.lblTitreConf)
        Me.Name = "ConfidentialiteDonneesForm"
        Me.Text = "Confidentialité "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitreConf As Label
    Friend WithEvents lblContenue As Label
    Friend WithEvents txtMessageConfidentialite As TextBox
End Class
