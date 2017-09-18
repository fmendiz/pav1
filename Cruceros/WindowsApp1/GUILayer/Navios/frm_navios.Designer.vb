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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.altura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eslora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autonomia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tripulantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Buscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.altura, Me.eslora, Me.manga, Me.autonomia, Me.motores, Me.tripulantes, Me.clasificacion})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(633, 271)
        Me.DataGridView1.TabIndex = 0
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
        Me.Button1.Location = New System.Drawing.Point(529, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(148, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(287, 472)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(317, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(31, 123)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(287, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(31, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(251, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(423, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(31, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(102, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(161, 80)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 11
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(171, 123)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 12
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(494, 121)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(122, 23)
        Me.Buscar.TabIndex = 13
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'frm_navios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 515)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frm_navios"
        Me.Text = "frm_navios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents altura As DataGridViewTextBoxColumn
    Friend WithEvents eslora As DataGridViewTextBoxColumn
    Friend WithEvents manga As DataGridViewTextBoxColumn
    Friend WithEvents autonomia As DataGridViewTextBoxColumn
    Friend WithEvents motores As DataGridViewTextBoxColumn
    Friend WithEvents tripulantes As DataGridViewTextBoxColumn
    Friend WithEvents clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Buscar As Button
End Class
