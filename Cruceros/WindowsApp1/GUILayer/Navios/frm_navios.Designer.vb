<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_navios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_navios = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.altura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eslora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autonomia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tripulantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.lbl_cant_motores = New System.Windows.Forms.Label()
        Me.lbl_clasificacion = New System.Windows.Forms.Label()
        Me.lbl_filtrar = New System.Windows.Forms.Label()
        CType(Me.dgv_navios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_navios
        '
        Me.dgv_navios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_navios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.altura, Me.eslora, Me.manga, Me.autonomia, Me.motores, Me.tripulantes, Me.clasificacion})
        Me.dgv_navios.Location = New System.Drawing.Point(11, 127)
        Me.dgv_navios.Name = "dgv_navios"
        Me.dgv_navios.Size = New System.Drawing.Size(633, 271)
        Me.dgv_navios.TabIndex = 0
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'altura
        '
        Me.altura.HeaderText = "altura"
        Me.altura.Name = "altura"
        Me.altura.Width = 70
        '
        'eslora
        '
        Me.eslora.HeaderText = "eslora"
        Me.eslora.Name = "eslora"
        Me.eslora.Width = 70
        '
        'manga
        '
        Me.manga.HeaderText = "manga"
        Me.manga.Name = "manga"
        Me.manga.Width = 70
        '
        'autonomia
        '
        Me.autonomia.HeaderText = "autonomia"
        Me.autonomia.Name = "autonomia"
        Me.autonomia.Width = 70
        '
        'motores
        '
        Me.motores.HeaderText = "motores"
        Me.motores.Name = "motores"
        Me.motores.Width = 70
        '
        'tripulantes
        '
        Me.tripulantes.HeaderText = "tripulantes"
        Me.tripulantes.Name = "tripulantes"
        Me.tripulantes.Width = 70
        '
        'clasificacion
        '
        Me.clasificacion.HeaderText = "clasificacion"
        Me.clasificacion.Name = "clasificacion"
        Me.clasificacion.Width = 70
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(49, 81)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(115, 25)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(324, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(185, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(324, 37)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 12
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(471, 83)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(121, 23)
        Me.Buscar.TabIndex = 13
        Me.Buscar.Text = "Busqueda Avanzada"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'lbl_cant_motores
        '
        Me.lbl_cant_motores.AutoSize = True
        Me.lbl_cant_motores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant_motores.ForeColor = System.Drawing.Color.Gray
        Me.lbl_cant_motores.Location = New System.Drawing.Point(182, 19)
        Me.lbl_cant_motores.Name = "lbl_cant_motores"
        Me.lbl_cant_motores.Size = New System.Drawing.Size(96, 15)
        Me.lbl_cant_motores.TabIndex = 15
        Me.lbl_cant_motores.Text = "Cant motores:"
        '
        'lbl_clasificacion
        '
        Me.lbl_clasificacion.AutoSize = True
        Me.lbl_clasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clasificacion.ForeColor = System.Drawing.Color.Gray
        Me.lbl_clasificacion.Location = New System.Drawing.Point(321, 19)
        Me.lbl_clasificacion.Name = "lbl_clasificacion"
        Me.lbl_clasificacion.Size = New System.Drawing.Size(93, 15)
        Me.lbl_clasificacion.TabIndex = 16
        Me.lbl_clasificacion.Text = "Clasificacion:"
        '
        'lbl_filtrar
        '
        Me.lbl_filtrar.AutoSize = True
        Me.lbl_filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filtrar.ForeColor = System.Drawing.Color.Gray
        Me.lbl_filtrar.Location = New System.Drawing.Point(81, 36)
        Me.lbl_filtrar.Name = "lbl_filtrar"
        Me.lbl_filtrar.Size = New System.Drawing.Size(52, 18)
        Me.lbl_filtrar.TabIndex = 17
        Me.lbl_filtrar.Text = "Filtrar"
        '
        'frm_navios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 456)
        Me.Controls.Add(Me.lbl_filtrar)
        Me.Controls.Add(Me.lbl_clasificacion)
        Me.Controls.Add(Me.lbl_cant_motores)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_navios)
        Me.Name = "frm_navios"
        Me.Text = "frm_navios"
        CType(Me.dgv_navios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_navios As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents altura As DataGridViewTextBoxColumn
    Friend WithEvents eslora As DataGridViewTextBoxColumn
    Friend WithEvents manga As DataGridViewTextBoxColumn
    Friend WithEvents autonomia As DataGridViewTextBoxColumn
    Friend WithEvents motores As DataGridViewTextBoxColumn
    Friend WithEvents tripulantes As DataGridViewTextBoxColumn
    Friend WithEvents clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Buscar As Button
    Friend WithEvents lbl_cant_motores As Label
    Friend WithEvents lbl_clasificacion As Label
    Friend WithEvents lbl_filtrar As Label
End Class
