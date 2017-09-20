Public Class frm_navios
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_abm_navio.ShowDialog()
    End Sub

    Private Sub llenarGrid(ByVal source As DataTable)
        dgv_navios.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgv_navios.Rows.Add(New String() {fila.Item("id_bug").ToString, fila.Item("fecha").ToString, fila.Item("titulo").ToString, fila.Item("nombre").ToString, fila.Item("n_estado").ToString, fila.Item("n_prioridad").ToString, fila.Item("n_criticidad").ToString, fila.Item("n_usuario").ToString, fila.Item("descripcion").ToString, fila.Item("id_estado").ToString, fila.Item("id_criticidad").ToString, fila.Item("id_prioridad").ToString, fila.Item("id_producto").ToString, fila.Item("asignado_a").ToString})
        Next
    End Sub

    Private Sub frm_navios_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT * FROM navios"
        'llamar a 'llenarGrid()' llenar la grilla a partir del DataTable obtenido.
        llenarGrid(BDHelper.getDBHelper.ConsultaSQL(str))

        If dgv_navios.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            clear_components()
        End If
    End Sub

    Private Sub clear_components()

    End Sub
End Class