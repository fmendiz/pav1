<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(81, 61)
        Me.txt_password.MaxLength = 10
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(162, 20)
        Me.txt_password.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(164, 100)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(80, 23)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(80, 100)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(78, 23)
        Me.btn_ingresar.TabIndex = 8
        Me.btn_ingresar.Text = "&Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(81, 28)
        Me.txt_usuario.MaxLength = 10
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(163, 20)
        Me.txt_usuario.TabIndex = 4
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(14, 64)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(64, 13)
        Me.lbl_password.TabIndex = 7
        Me.lbl_password.Text = "Contraseña:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(33, 31)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuario.TabIndex = 5
        Me.lbl_usuario.Text = "Usuario:"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 146)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Name = "frm_login"
        Me.Text = "frm_login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_usuario As Label
End Class
