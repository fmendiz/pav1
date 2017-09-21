Public Class NavioDao
    Public Function getAll() As IList(Of Navio)
        Dim sql As String = "Select * FROM navios WHERE 1 = 1"
        Dim oTabla As DataTable
        Dim lst As New List(Of Navio)

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        For Each row As DataRow In oTabla.Rows
            lst.Add(mapear(row))
        Next

        Return lst
    End Function

    Public Function getByParams(ByVal params As Object()) As IList(Of Navio)

        Dim lst As New List(Of Navio)
        Dim sql As String = "Select * FROM navios WHERE 1 = 1"
        Dim oNavio As Navio = Nothing

        If Not IsNothing(params(0)) Then sql += " AND nombre LIKE '%' + @param1 + '%' "
        If Not IsNothing(params(1)) Then sql += " AND altura = @param2 "
        If Not IsNothing(params(2)) Then sql += " AND manga = @param3 "
        If Not IsNothing(params(3)) Then sql += " AND eslora = @param4 "
        If Not IsNothing(params(4)) Then sql += " AND autonomia = @param5 "
        If Not IsNothing(params(5)) Then sql += " AND desplazamiento = @param6 "
        If Not IsNothing(params(6)) Then sql += " AND tripulantes = @param7 "
        If Not IsNothing(params(7)) Then sql += " AND motores = @param8 "
        If Not IsNothing(params(9)) Then sql += " AND clasificacion = @param10 "

        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql, params).Rows
            lst.Add(mapear(row))
        Next

        Return lst
    End Function

    'Funciones CRUD
    Public Function create(ByVal oNavio As Navio)
        Dim str_sql As String

        str_sql = "INSERT INTO navios (nombre, altura, manga, eslora, autonomia, desplazamiento, tripulantes, motores, clasificacion) VALUES("
        str_sql += "'" + oNavio.nombre + "','"
        str_sql += oNavio.altura + ","
        str_sql += oNavio.manga + ","
        str_sql += oNavio.eslora + ","
        str_sql += oNavio.autonomia + ","
        str_sql += oNavio.desplazamiento + ","
        str_sql += oNavio.tripulantes + ","
        str_sql += oNavio.motores + ","
        str_sql += oNavio.clasificacion + ")"

        'Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function
    'Funciones CRUD

    Public Function update(ByVal oNavio As Navio)
        Dim str_sql As String

        str_sql = "UPDATE navios SET "
        str_sql += " nombre = '" + oNavio.nombre + "','"
        str_sql += " altura = " + oNavio.altura + ","
        str_sql += " manga = " + oNavio.manga + ","
        str_sql += " eslora = " + oNavio.eslora + ","
        str_sql += " autonomia = " + oNavio.autonomia + ","
        str_sql += " desplazamiento = " + oNavio.desplazamiento + ","
        str_sql += " tripulantes = " + oNavio.tripulantes + ","
        str_sql += " motores = " + oNavio.motores + ","
        str_sql += " clasificacion = " + oNavio.clasificacion + ")"

        str_sql += " WHERE id = " + oNavio.id.ToString

        'Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function

    Private Function mapear(ByRef row As DataRow) As Navio
        Dim oNavio As New Navio

        oNavio.id = Convert.ToInt32(row.Item("id").ToString)
        oNavio.nombre = row.Item("nombre").ToString
        oNavio.altura = Convert.ToInt32(row.Item("altura").ToString)
        oNavio.manga = Convert.ToInt32(row.Item("manga").ToString)
        oNavio.eslora = Convert.ToInt32(row.Item("eslora").ToString)
        oNavio.autonomia = Convert.ToInt32(row.Item("autonomia").ToString)
        oNavio.desplazamiento = Convert.ToInt32(row.Item("desplazamiento").ToString)
        oNavio.tripulantes = Convert.ToInt32(row.Item("tripulantes").ToString)
        oNavio.motores = Convert.ToInt32(row.Item("motores").ToString)
        oNavio.clasificacion = Convert.ToInt32(row.Item("clasificacion").ToString)
        Return oNavio
    End Function
End Class
