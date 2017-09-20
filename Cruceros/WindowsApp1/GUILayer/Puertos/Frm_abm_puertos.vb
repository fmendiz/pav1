Public Class Frm_abm_puertos
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Frm_abm_puertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_puertos.llenarCombo(cbo_ciudad, BDHelper.getDBHelper.ConsultaSQL("SELECT * From ciudades  WHERE 1=1"), "nombre", "id")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo puerto"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Puerto"
                mostrar_datos()
                txt_id.Enabled = True
                txt_nombre.Enabled = True
                cbo_ciudad.Enabled = True

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Puerto"
                txt_id.Enabled = False
                txt_nombre.Enabled = False
                cbo_ciudad.Enabled = False

        End Select

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_puerto(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_id.Text = _row_selected.Cells("col_id").Value
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            cbo_ciudad.Text = _row_selected.Cells("col_ciudad").Value

        End If

    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""

        Select Case _action
            Case Opcion.insert
                If existe_id() = False Then
                    If validar_campos() Then
                        str_sql = "INSERT INTO puertos (id, nombre, id_ciudad) VALUES('"
                        str_sql += txt_id.Text + "','"
                        str_sql += txt_nombre.Text + "','"
                        str_sql += cbo_ciudad.SelectedValue.ToString + ")"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Puerto insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Esta Identificación ya existe. Ingrese nuevamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    'id = '"
                    'str_sql += txt_id.Text + "', 
                    str_sql = "UPDATE puertos Set nombre = '"
                    str_sql += txt_nombre.Text + "', id_ciudad = "
                    str_sql += cbo_ciudad.SelectedValue.ToString
                    str_sql += " WHERE id = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Puerto actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el puerto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar el puerto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Puerto Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el puerto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_id.Text = String.Empty Then
            txt_id.BackColor = Color.Red
            txt_id.Focus()
            Return False
        Else
            txt_id.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If cbo_ciudad.Text = String.Empty Then
            cbo_ciudad.BackColor = Color.Red
            cbo_ciudad.Focus()
            Return False
        Else
            cbo_ciudad.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_id() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from puertos where id = '" + txt_id.Text + "'").Rows.Count > 0
    End Function

End Class