<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_tripulantes
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
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgv_tripulantes = New System.Windows.Forms.DataGridView()
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_legajo = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_tripulantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Location = New System.Drawing.Point(182, 344)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 40)
        Me.btn_quitar.TabIndex = 21
        Me.btn_quitar.Text = "Eliminar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Location = New System.Drawing.Point(105, 344)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(71, 40)
        Me.btn_editar.TabIndex = 20
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(34, 344)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(65, 40)
        Me.btn_nuevo.TabIndex = 19
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_tripulantes)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_legajo)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Location = New System.Drawing.Point(34, 5)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 328)
        Me.pnl_filtros.TabIndex = 18
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgv_tripulantes
        '
        Me.dgv_tripulantes.AllowUserToAddRows = False
        Me.dgv_tripulantes.AllowUserToDeleteRows = False
        Me.dgv_tripulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tripulantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_apellido, Me.col_nombre})
        Me.dgv_tripulantes.Location = New System.Drawing.Point(38, 130)
        Me.dgv_tripulantes.Name = "dgv_tripulantes"
        Me.dgv_tripulantes.ReadOnly = True
        Me.dgv_tripulantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tripulantes.Size = New System.Drawing.Size(343, 192)
        Me.dgv_tripulantes.TabIndex = 8
        '
        'col_legajo
        '
        Me.col_legajo.HeaderText = "Legajo"
        Me.col_legajo.Name = "col_legajo"
        Me.col_legajo.ReadOnly = True
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(83, 60)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Legajo:"
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(83, 23)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.Size = New System.Drawing.Size(101, 20)
        Me.txt_legajo.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(231, 88)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(368, 344)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(79, 40)
        Me.btn_salir.TabIndex = 22
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Frm_tripulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 396)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Controls.Add(Me.btn_salir)
        Me.Name = "Frm_tripulantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Tripulantes"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_tripulantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents pnl_filtros As GroupBox
    Friend WithEvents dgv_tripulantes As DataGridView
    Friend WithEvents chk_todos As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_legajo As TextBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
End Class
