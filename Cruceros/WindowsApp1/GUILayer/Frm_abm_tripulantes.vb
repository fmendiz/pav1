Public Class Frm_abm_tripulantes
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_legajo.Text = _row_selected.Cells("col_legajo").Value
            txt_apellido.Text = _row_selected.Cells("col_apellido").Value
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value

        End If

    End Sub

    Private Sub Frm_abm_tripulantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo tripulante"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar tripulante"
                mostrar_datos()
                txt_legajo.Enabled = True
                txt_apellido.Enabled = True
                txt_nombre.Enabled = True

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Deshabilitar tripulante"
                txt_legajo.Enabled = False
                txt_apellido.Enabled = False
                txt_nombre.Enabled = False

        End Select
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_tripulante(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function existe_legajo() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from tripulantes where legajo = '" + txt_legajo.Text + "'").Rows.Count > 0
    End Function

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_legajo.Text = String.Empty Then
            txt_legajo.BackColor = Color.Red
            txt_legajo.Focus()
            Return False
        Else
            txt_legajo.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        Return True
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""

        Select Case _action
            Case Opcion.insert
                If existe_legajo() = False Then
                    If validar_campos() Then
                        str_sql = "INSERT INTO tripulantes (legajo, apellido, nombre, estado) VALUES('"
                        str_sql += txt_legajo.Text + "','"
                        str_sql += txt_apellido.Text + "','"
                        str_sql += txt_nombre.Text + "', 'S')"
                        MsgBox(str_sql)
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Tripulante insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("El número de Legajo ya existe. Ingrese otro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    'legajo = '"
                    'str_sql += txt_legajo.Text + "', 
                    str_sql = "UPDATE tripulantes Set apellido = '"
                    str_sql += txt_apellido.Text + "', nombre = '"
                    str_sql += txt_nombre.Text
                    str_sql += "' WHERE legajo = " + _row_selected.Cells("col_legajo").Value
                    MsgBox(str_sql)
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Tripulante actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar al tripulante!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea deshabilitar al tripulante seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    str_sql = "DELETE FROM tripulantes "
                    str_sql += " WHERE legajo = " + _row_selected.Cells("col_legajo").Value
                    MsgBox(str_sql)
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Tripulante Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el tripulante", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Sub lbl_nombre_Click(sender As Object, e As EventArgs) Handles lbl_nombre.Click

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class