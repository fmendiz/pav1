<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_puertos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgv_puertos = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_ciudades = New System.Windows.Forms.ComboBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_puertos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Location = New System.Drawing.Point(177, 357)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 39)
        Me.btn_quitar.TabIndex = 16
        Me.btn_quitar.Text = "Eliminar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(363, 356)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(79, 40)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Location = New System.Drawing.Point(100, 357)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(71, 40)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(29, 357)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(65, 40)
        Me.btn_nuevo.TabIndex = 14
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_puertos)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.lbl_nombre)
        Me.pnl_filtros.Controls.Add(Me.txt_nombre)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_ciudades)
        Me.pnl_filtros.Controls.Add(Me.lbl_ciudad)
        Me.pnl_filtros.Location = New System.Drawing.Point(29, 22)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 328)
        Me.pnl_filtros.TabIndex = 13
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgv_puertos
        '
        Me.dgv_puertos.AllowUserToAddRows = False
        Me.dgv_puertos.AllowUserToDeleteRows = False
        Me.dgv_puertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_puertos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_ciudad, Me.col_id})
        Me.dgv_puertos.Location = New System.Drawing.Point(74, 130)
        Me.dgv_puertos.Name = "dgv_puertos"
        Me.dgv_puertos.ReadOnly = True
        Me.dgv_puertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_puertos.Size = New System.Drawing.Size(244, 192)
        Me.dgv_puertos.TabIndex = 8
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_ciudad
        '
        Me.col_ciudad.HeaderText = "Ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        Me.col_ciudad.ReadOnly = True
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(74, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(23, 25)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(293, 87)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_ciudades
        '
        Me.cbo_ciudades.FormattingEnabled = True
        Me.cbo_ciudades.Location = New System.Drawing.Point(74, 48)
        Me.cbo_ciudades.Name = "cbo_ciudades"
        Me.cbo_ciudades.Size = New System.Drawing.Size(181, 21)
        Me.cbo_ciudades.TabIndex = 1
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(27, 51)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(43, 13)
        Me.lbl_ciudad.TabIndex = 0
        Me.lbl_ciudad.Text = "Ciudad:"
        '
        'Frm_puertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 407)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "Frm_puertos"
        Me.Text = "Consulta de Puertos"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_puertos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents pnl_filtros As GroupBox
    Friend WithEvents dgv_puertos As DataGridView
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_ciudad As DataGridViewTextBoxColumn
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents chk_todos As CheckBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents cbo_ciudades As ComboBox
    Friend WithEvents lbl_ciudad As Label
End Class
