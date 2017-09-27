<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_abm_tripulantes
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
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_legajo = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_legajo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(105, 81)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(121, 20)
        Me.txt_apellido.TabIndex = 24
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(151, 199)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 20)
        Me.btn_cerrar.TabIndex = 23
        Me.btn_cerrar.Text = "Cancelar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(37, 199)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(96, 20)
        Me.btn_aceptar.TabIndex = 22
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(105, 122)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 21
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(105, 41)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(121, 20)
        Me.txt_legajo.TabIndex = 20
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(42, 84)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(57, 13)
        Me.lbl_apellido.TabIndex = 19
        Me.lbl_apellido.Text = "Apellido(*):"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(42, 125)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(57, 13)
        Me.lbl_nombre.TabIndex = 18
        Me.lbl_nombre.Text = "Nombre(*):"
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(47, 44)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(52, 13)
        Me.lbl_legajo.TabIndex = 17
        Me.lbl_legajo.Text = "Legajo(*):"
        '
        'Frm_abm_tripulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_legajo)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_legajo)
        Me.Name = "Frm_abm_tripulantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Tripulantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_legajo As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_legajo As Label
End Class
