Public Class frm_abm_navio
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim str As String = "INSERT INTO navios(nombre,altura,manga,autonomia,eslora,desplazamiento,motores,tripulantes,clasificacion) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9)"

        filters.Add(txt_nombre.Text)
        filters.Add(txt_altura.Text)
        filters.Add(txt_manga.Text)
        filters.Add(txt_autonomia.Text)
        filters.Add(txt_eslora.Text)
        filters.Add(txt_desplazamiento.Text)
        filters.Add(txt_motores.Text)
        filters.Add(txt_tripulantes.Text)
        filters.Add(5)

        BDHelper.getDBHelper.EjecutarSQLConParametros(str, filters.ToArray())
    End Sub
End Class