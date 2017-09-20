Public Class Frm_puertos
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Frm_abm_puertos.ShowDialog()
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub Frm_puertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo(cbo_ciudades, BDHelper.getDBHelper.ConsultaSQL("SELECT * From ciudades WHERE 1=1"), "nombre", "id")
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
            cbo_ciudades.Enabled = False
        Else
            txt_nombre.Enabled = True
            cbo_ciudades.Enabled = True

        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Seguro que desea salir?",
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT P.id, P.nombre, C.nombre FROM puertos P JOIN ciudades C ON P.id_ciudad = C.id  WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            If cbo_ciudades.Text <> String.Empty Then
                filters.Add(cbo_ciudades.SelectedValue)
                sql += " AND P.id_ciudad=@param1 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If txt_nombre.Text <> String.Empty Then
                filters.Add(txt_nombre.Text)
                sql += " AND P.nombre LIKE '%' + @param2 + '%' "
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

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_puertos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_puertos.Rows.Add(New String() {row.Item("P.id").ToString, row.Item("P.nombre").ToString, row.Item("C.nombre").ToString})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Frm_abm_puertos.seleccionar_puerto(Frm_abm_puertos.Opcion.update, dgv_puertos.CurrentRow)
        Frm_abm_puertos.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub dgv_puertos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_puertos.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Frm_abm_puertos.seleccionar_puerto(Frm_abm_puertos.Opcion.delete, dgv_puertos.CurrentRow)
        Frm_abm_puertos.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
End Class