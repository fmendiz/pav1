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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.dgv_navios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_navios
        '
        Me.dgv_navios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_navios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.altura, Me.eslora, Me.manga, Me.autonomia, Me.motores, Me.tripulantes, Me.clasificacion})
        Me.dgv_navios.Location = New System.Drawing.Point(11, 75)
        Me.dgv_navios.Name = "dgv_navios"
        Me.dgv_navios.Size = New System.Drawing.Size(633, 221)
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
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(529, 314)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(115, 25)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(49, 31)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(115, 25)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Location = New System.Drawing.Point(185, 31)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(121, 25)
        Me.btn_editar.TabIndex = 3
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Location = New System.Drawing.Point(324, 31)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(121, 25)
        Me.btn_quitar.TabIndex = 4
        Me.btn_quitar.Text = "Eliminar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(471, 33)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(121, 23)
        Me.btn_buscar.TabIndex = 13
        Me.btn_buscar.Text = "Busqueda Avanzada"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'frm_navios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 351)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_navios)
        Me.Name = "frm_navios"
        Me.Text = "frm_navios"
        CType(Me.dgv_navios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_buscar As Button
End Class
