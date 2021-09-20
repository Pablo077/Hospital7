<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btnABM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnABM
        '
        Me.btnABM.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnABM.Location = New System.Drawing.Point(186, 46)
        Me.btnABM.Name = "btnABM"
        Me.btnABM.Size = New System.Drawing.Size(187, 51)
        Me.btnABM.TabIndex = 0
        Me.btnABM.Text = "ABM Pacientes"
        Me.btnABM.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 450)
        Me.Controls.Add(Me.btnABM)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnABM As Button
End Class
