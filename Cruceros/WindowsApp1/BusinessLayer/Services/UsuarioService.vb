Public Class UsuarioService
    Private oUsuarioDao As UsuarioDao

    Public Sub New()
        oUsuarioDao = New UsuarioDao
    End Sub

    Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
        Return oUsuarioDao.getUserByNamePass(nombre, password)
    End Function
End Class
