<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccueilForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccueilForm))
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnHistoriques = New System.Windows.Forms.Button()
        Me.btnReserver = New System.Windows.Forms.Button()
        Me.btnProfil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Location = New System.Drawing.Point(22, 18)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(109, 86)
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'btnHistoriques
        '
        Me.btnHistoriques.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistoriques.Location = New System.Drawing.Point(94, 348)
        Me.btnHistoriques.Name = "btnHistoriques"
        Me.btnHistoriques.Size = New System.Drawing.Size(165, 51)
        Me.btnHistoriques.TabIndex = 1
        Me.btnHistoriques.Text = "Historique"
        Me.btnHistoriques.UseVisualStyleBackColor = True
        '
        'btnReserver
        '
        Me.btnReserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserver.Location = New System.Drawing.Point(303, 348)
        Me.btnReserver.Name = "btnReserver"
        Me.btnReserver.Size = New System.Drawing.Size(165, 51)
        Me.btnReserver.TabIndex = 2
        Me.btnReserver.Text = "Réserver"
        Me.btnReserver.UseVisualStyleBackColor = True
        '
        'btnProfil
        '
        Me.btnProfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfil.Location = New System.Drawing.Point(522, 348)
        Me.btnProfil.Name = "btnProfil"
        Me.btnProfil.Size = New System.Drawing.Size(165, 51)
        Me.btnProfil.TabIndex = 3
        Me.btnProfil.Text = "Profil"
        Me.btnProfil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(583, 107)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnProfil)
        Me.Controls.Add(Me.btnReserver)
        Me.Controls.Add(Me.btnHistoriques)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnHistoriques As Button
    Friend WithEvents btnReserver As Button
    Friend WithEvents btnProfil As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
