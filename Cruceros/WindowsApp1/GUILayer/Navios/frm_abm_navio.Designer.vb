<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abm_navio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abm_navio))
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_eslora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_manga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_desplazamiento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_autonomia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_motores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_tripulantes = New System.Windows.Forms.TextBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_estrella1 = New System.Windows.Forms.Button()
        Me.btn_estrella2 = New System.Windows.Forms.Button()
        Me.btn_estrella3 = New System.Windows.Forms.Button()
        Me.btn_estrella4 = New System.Windows.Forms.Button()
        Me.btn_estrella5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(40, 56)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(188, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(40, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Altura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(192, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Eslora:"
        '
        'txt_eslora
        '
        Me.txt_eslora.Location = New System.Drawing.Point(192, 107)
        Me.txt_eslora.Name = "txt_eslora"
        Me.txt_eslora.Size = New System.Drawing.Size(112, 20)
        Me.txt_eslora.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(40, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Manga:"
        '
        'txt_manga
        '
        Me.txt_manga.Location = New System.Drawing.Point(40, 165)
        Me.txt_manga.Name = "txt_manga"
        Me.txt_manga.Size = New System.Drawing.Size(112, 20)
        Me.txt_manga.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(192, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Desplazamiento:"
        '
        'txt_desplazamiento
        '
        Me.txt_desplazamiento.Location = New System.Drawing.Point(192, 165)
        Me.txt_desplazamiento.Name = "txt_desplazamiento"
        Me.txt_desplazamiento.Size = New System.Drawing.Size(112, 20)
        Me.txt_desplazamiento.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(40, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Autonomia:"
        '
        'txt_autonomia
        '
        Me.txt_autonomia.Location = New System.Drawing.Point(40, 223)
        Me.txt_autonomia.Name = "txt_autonomia"
        Me.txt_autonomia.Size = New System.Drawing.Size(112, 20)
        Me.txt_autonomia.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(195, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Motores:"
        '
        'txt_motores
        '
        Me.txt_motores.Location = New System.Drawing.Point(192, 223)
        Me.txt_motores.Name = "txt_motores"
        Me.txt_motores.Size = New System.Drawing.Size(112, 20)
        Me.txt_motores.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(40, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tripulantes:"
        '
        'txt_tripulantes
        '
        Me.txt_tripulantes.Location = New System.Drawing.Point(40, 279)
        Me.txt_tripulantes.Name = "txt_tripulantes"
        Me.txt_tripulantes.Size = New System.Drawing.Size(112, 20)
        Me.txt_tripulantes.TabIndex = 14
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(40, 107)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(112, 20)
        Me.txt_altura.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(195, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Clasificacion:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(270, 404)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 20
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(185, 404)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 21
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_estrella1
        '
        Me.btn_estrella1.BackColor = System.Drawing.Color.Transparent
        Me.btn_estrella1.BackgroundImage = CType(resources.GetObject("btn_estrella1.BackgroundImage"), System.Drawing.Image)
        Me.btn_estrella1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estrella1.Location = New System.Drawing.Point(192, 279)
        Me.btn_estrella1.Name = "btn_estrella1"
        Me.btn_estrella1.Size = New System.Drawing.Size(25, 25)
        Me.btn_estrella1.TabIndex = 22
        Me.btn_estrella1.UseVisualStyleBackColor = False
        '
        'btn_estrella2
        '
        Me.btn_estrella2.BackColor = System.Drawing.Color.Transparent
        Me.btn_estrella2.BackgroundImage = CType(resources.GetObject("btn_estrella2.BackgroundImage"), System.Drawing.Image)
        Me.btn_estrella2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estrella2.Location = New System.Drawing.Point(224, 279)
        Me.btn_estrella2.Name = "btn_estrella2"
        Me.btn_estrella2.Size = New System.Drawing.Size(25, 25)
        Me.btn_estrella2.TabIndex = 23
        Me.btn_estrella2.UseVisualStyleBackColor = False
        '
        'btn_estrella3
        '
        Me.btn_estrella3.BackColor = System.Drawing.Color.Transparent
        Me.btn_estrella3.BackgroundImage = CType(resources.GetObject("btn_estrella3.BackgroundImage"), System.Drawing.Image)
        Me.btn_estrella3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estrella3.Location = New System.Drawing.Point(258, 279)
        Me.btn_estrella3.Name = "btn_estrella3"
        Me.btn_estrella3.Size = New System.Drawing.Size(25, 25)
        Me.btn_estrella3.TabIndex = 24
        Me.btn_estrella3.UseVisualStyleBackColor = False
        '
        'btn_estrella4
        '
        Me.btn_estrella4.BackColor = System.Drawing.Color.Transparent
        Me.btn_estrella4.BackgroundImage = CType(resources.GetObject("btn_estrella4.BackgroundImage"), System.Drawing.Image)
        Me.btn_estrella4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estrella4.Location = New System.Drawing.Point(289, 279)
        Me.btn_estrella4.Name = "btn_estrella4"
        Me.btn_estrella4.Size = New System.Drawing.Size(25, 25)
        Me.btn_estrella4.TabIndex = 25
        Me.btn_estrella4.UseVisualStyleBackColor = False
        '
        'btn_estrella5
        '
        Me.btn_estrella5.BackColor = System.Drawing.Color.Transparent
        Me.btn_estrella5.BackgroundImage = CType(resources.GetObject("btn_estrella5.BackgroundImage"), System.Drawing.Image)
        Me.btn_estrella5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estrella5.Location = New System.Drawing.Point(320, 279)
        Me.btn_estrella5.Name = "btn_estrella5"
        Me.btn_estrella5.Size = New System.Drawing.Size(25, 25)
        Me.btn_estrella5.TabIndex = 26
        Me.btn_estrella5.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(40, 344)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(40, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Cubiertas:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(223, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(254, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 23)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Editar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frm_abm_navio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 440)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_estrella5)
        Me.Controls.Add(Me.btn_estrella4)
        Me.Controls.Add(Me.btn_estrella3)
        Me.Controls.Add(Me.btn_estrella2)
        Me.Controls.Add(Me.btn_estrella1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_tripulantes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_motores)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_autonomia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_desplazamiento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_manga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_eslora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "frm_abm_navio"
        Me.Text = "Navios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_eslora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_manga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_desplazamiento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_autonomia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_motores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_tripulantes As TextBox
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_estrella1 As Button
    Friend WithEvents btn_estrella2 As Button
    Friend WithEvents btn_estrella3 As Button
    Friend WithEvents btn_estrella4 As Button
    Friend WithEvents btn_estrella5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
