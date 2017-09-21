Public Class frm_navios
    Private oNavioService As New NavioService

    Private Sub llenarGrid(ByVal source As IList(Of Navio))
        dgv_navios.Rows.Clear()
        For Each oNavio As Navio In source
            Dim estrellas As String = String.Empty
            dgv_navios.Rows.Add(New String() {oNavio.nombre, oNavio.altura, oNavio.eslora, oNavio.manga, oNavio.autonomia, oNavio.motores, oNavio.tripulantes, oNavio.clasificacion})
        Next
    End Sub

    Private Sub frm_navios_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)

        llenarGrid(oNavioService.traerTodos())

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