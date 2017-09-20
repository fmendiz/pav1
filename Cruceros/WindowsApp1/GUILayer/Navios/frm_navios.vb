Public Class frm_navios

    Private Sub llenarGrid(ByVal source As DataTable)
        dgv_navios.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgv_navios.Rows.Add(New String() {fila.Item("nombre").ToString, fila.Item("altura").ToString, fila.Item("eslora").ToString, fila.Item("manga").ToString, fila.Item("autonomia").ToString, fila.Item("motores").ToString, fila.Item("tripulantes").ToString, fila.Item("clasificacion").ToString})
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
        End If
    End Sub

    Private Sub dgv_navios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_navios.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?",
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_abm_navio.ShowDialog()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        frm_abm_navio.ShowDialog()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        frm_abm_navio.ShowDialog()
    End Sub
End Class