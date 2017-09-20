Public Class UsuarioDao
    'Permite recuperar un usuario a partir de un nombre y password
    Public Function getUserByNamePass(ByVal nombre As String, ByVal password As String) As Usuario
        Dim sql As String = "Select *
                             from usuarios
                             WHERE nombre = '" + nombre + "' 
                             AND contraseña = '" + password + "'"
        Dim oTabla As DataTable
        Dim oUsuario As Usuario = Nothing

        oTabla = BDHelper.getDBHelper.ConsultaSQL(sql)
        If oTabla.Rows.Count Then
            oUsuario = map_user(oTabla.Rows(0))
        End If

        Return oUsuario
    End Function

    'Función auxiliar responsable de MAPPEAR una fila de Users a un objeto Usuario
    Private Function map_user(ByRef row As DataRow) As Usuario
        Dim oUsuario As New Usuario

        oUsuario.id = Convert.ToInt32(row.Item("id").ToString)
        oUsuario.nombre = row.Item("nombre").ToString
        oUsuario.password = row.Item("contraseña").ToString
        oUsuario.Id_perfil = Convert.ToInt32(row.Item("id_perfil").ToString)
        Return oUsuario
    End Function
End Class
