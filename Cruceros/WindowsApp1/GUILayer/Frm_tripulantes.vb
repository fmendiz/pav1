Public Class Frm_tripulantes
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtLegajo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_tripulantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_legajo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Frm_abm_tripulantes.ShowDialog()
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_legajo.Enabled = False
        Else
            txt_legajo.Enabled = True

        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Seguro que desea salir?",
               "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
               , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_tripulantes.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_tripulantes.Rows.Add(New String() {row.Item("legajo").ToString, row.Item("apellido").ToString, row.Item("nombre").ToString})
        Next
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT legajo, apellido, nombre FROM tripulantes WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            If txt_legajo.Text <> String.Empty Then
                filters.Add(txt_legajo.Text)
                sql += " AND legajo=@param1 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If flag_filtros Then
                llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(sql, filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenar_grid(BDHelper.getDBHelper.ConsultaSQL(sql))
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_abm_tripulantes.seleccionar_tripulante(Frm_abm_tripulantes.Opcion.update, dgv_tripulantes.CurrentRow)
        Frm_abm_tripulantes.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub dgv_tripulantes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tripulantes.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Frm_abm_tripulantes.seleccionar_tripulante(Frm_abm_tripulantes.Opcion.delete, dgv_tripulantes.CurrentRow)
        Frm_abm_tripulantes.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
End Class