<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription2
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
        Me.txtbTelephone = New System.Windows.Forms.TextBox()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.btnSuivantIns = New System.Windows.Forms.Button()
        Me.btnPrecedentIns = New System.Windows.Forms.Button()
        Me.txtbMDPIns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInscription
        '
        Me.lblInscription.AutoSize = True
        Me.lblInscription.Location = New System.Drawing.Point(168, 68)
        Me.lblInscription.Name = "lblInscription"
        Me.lblInscription.Size = New System.Drawing.Size(55, 13)
        Me.lblInscription.TabIndex = 0
        Me.lblInscription.Text = "Inscription"
        '
        'txtbTelephone
        '
        Me.txtbTelephone.Location = New System.Drawing.Point(154, 193)
        Me.txtbTelephone.Name = "txtbTelephone"
        Me.txtbTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtbTelephone.TabIndex = 1
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(154, 142)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtbEmail.TabIndex = 2
        '
        'btnSuivantIns
        '
        Me.btnSuivantIns.Location = New System.Drawing.Point(310, 380)
        Me.btnSuivantIns.Name = "btnSuivantIns"
        Me.btnSuivantIns.Size = New System.Drawing.Size(75, 23)
        Me.btnSuivantIns.TabIndex = 3
        Me.btnSuivantIns.Text = "Suivant"
        Me.btnSuivantIns.UseVisualStyleBackColor = True
        '
        'btnPrecedentIns
        '
        Me.btnPrecedentIns.Location = New System.Drawing.Point(42, 380)
        Me.btnPrecedentIns.Name = "btnPrecedentIns"
        Me.btnPrecedentIns.Size = New System.Drawing.Size(75, 23)
        Me.btnPrecedentIns.TabIndex = 4
        Me.btnPrecedentIns.Text = "Précédent"
        Me.btnPrecedentIns.UseVisualStyleBackColor = True
        '
        'txtbMDPIns
        '
        Me.txtbMDPIns.Location = New System.Drawing.Point(154, 256)
        Me.txtbMDPIns.Name = "txtbMDPIns"
        Me.txtbMDPIns.Size = New System.Drawing.Size(100, 20)
        Me.txtbMDPIns.TabIndex = 5
        Me.txtbMDPIns.UseSystemPasswordChar = True
        '
        'Inscription2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbMDPIns)
        Me.Controls.Add(Me.btnPrecedentIns)
        Me.Controls.Add(Me.btnSuivantIns)
        Me.Controls.Add(Me.txtbEmail)
        Me.Controls.Add(Me.txtbTelephone)
        Me.Controls.Add(Me.lblInscription)
        Me.Name = "Inscription2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInscription As Label
    Friend WithEvents txtbTelephone As TextBox
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents btnSuivantIns As Button
    Friend WithEvents btnPrecedentIns As Button
    Friend WithEvents txtbMDPIns As TextBox
End Class
