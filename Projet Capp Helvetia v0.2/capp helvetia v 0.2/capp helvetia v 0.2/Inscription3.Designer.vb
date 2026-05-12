<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription3
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
        Me.dtpDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.txtbTaille = New System.Windows.Forms.TextBox()
        Me.txtbPoids = New System.Windows.Forms.TextBox()
        Me.btnValiderIns = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpDateNaiss
        '
        Me.dtpDateNaiss.CustomFormat = "dd.mm.yyyy"
        Me.dtpDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateNaiss.Location = New System.Drawing.Point(137, 120)
        Me.dtpDateNaiss.Name = "dtpDateNaiss"
        Me.dtpDateNaiss.Size = New System.Drawing.Size(125, 20)
        Me.dtpDateNaiss.TabIndex = 0
        '
        'txtbTaille
        '
        Me.txtbTaille.Location = New System.Drawing.Point(137, 187)
        Me.txtbTaille.Name = "txtbTaille"
        Me.txtbTaille.Size = New System.Drawing.Size(100, 20)
        Me.txtbTaille.TabIndex = 1
        '
        'txtbPoids
        '
        Me.txtbPoids.Location = New System.Drawing.Point(137, 237)
        Me.txtbPoids.Name = "txtbPoids"
        Me.txtbPoids.Size = New System.Drawing.Size(100, 20)
        Me.txtbPoids.TabIndex = 2
        '
        'btnValiderIns
        '
        Me.btnValiderIns.Location = New System.Drawing.Point(310, 369)
        Me.btnValiderIns.Name = "btnValiderIns"
        Me.btnValiderIns.Size = New System.Drawing.Size(75, 23)
        Me.btnValiderIns.TabIndex = 3
        Me.btnValiderIns.Text = "Valider"
        Me.btnValiderIns.UseVisualStyleBackColor = True
        '
        'Inscription3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnValiderIns)
        Me.Controls.Add(Me.txtbPoids)
        Me.Controls.Add(Me.txtbTaille)
        Me.Controls.Add(Me.dtpDateNaiss)
        Me.Name = "Inscription3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateNaiss As DateTimePicker
    Friend WithEvents txtbTaille As TextBox
    Friend WithEvents txtbPoids As TextBox
    Friend WithEvents btnValiderIns As Button
End Class
