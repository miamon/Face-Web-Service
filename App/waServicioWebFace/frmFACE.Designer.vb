<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFACE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConectarFace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConectarFace
        '
        Me.btnConectarFace.Location = New System.Drawing.Point(67, 35)
        Me.btnConectarFace.Name = "btnConectarFace"
        Me.btnConectarFace.Size = New System.Drawing.Size(149, 48)
        Me.btnConectarFace.TabIndex = 0
        Me.btnConectarFace.Text = "Conectar con Face"
        Me.btnConectarFace.UseVisualStyleBackColor = True
        '
        'frmFACE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 128)
        Me.Controls.Add(Me.btnConectarFace)
        Me.Name = "frmFACE"
        Me.Text = "Face WebService"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConectarFace As System.Windows.Forms.Button

End Class
