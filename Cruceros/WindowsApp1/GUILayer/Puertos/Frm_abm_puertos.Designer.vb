<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_abm_puertos
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cbo_ciudad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(156, 199)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 28)
        Me.btn_cancelar.TabIndex = 26
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(42, 199)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(96, 28)
        Me.btn_aceptar.TabIndex = 25
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 73)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 24
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(114, 41)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(121, 20)
        Me.txt_id.TabIndex = 23
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(55, 110)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(53, 13)
        Me.lbl_ciudad.TabIndex = 22
        Me.lbl_ciudad.Text = "Ciudad(*):"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(51, 76)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(57, 13)
        Me.lbl_nombre.TabIndex = 21
        Me.lbl_nombre.Text = "Nombre(*):"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(25, 44)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(83, 13)
        Me.lbl_id.TabIndex = 20
        Me.lbl_id.Text = "Identificación(*):"
        '
        'cbo_ciudad
        '
        Me.cbo_ciudad.FormattingEnabled = True
        Me.cbo_ciudad.Location = New System.Drawing.Point(114, 107)
        Me.cbo_ciudad.Name = "cbo_ciudad"
        Me.cbo_ciudad.Size = New System.Drawing.Size(121, 21)
        Me.cbo_ciudad.TabIndex = 19
        '
        'Frm_abm_puertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 255)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_ciudad)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.cbo_ciudad)
        Me.Name = "Frm_abm_puertos"
        Me.Text = "Actualizar Puertos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents cbo_ciudad As ComboBox
End Class
