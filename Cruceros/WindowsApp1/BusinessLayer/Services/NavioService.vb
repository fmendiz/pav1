Public Class NavioService
    Private oNavioDao As NavioDao

    Public Sub New()
        oNavioDao = New NavioDao
    End Sub

    Public Function crear(ByVal oNavio As Navio) As Boolean
        Return oNavioDao.create(oNavio)
    End Function

    Public Function editar(ByVal oNavio As Navio) As Boolean
        Return oNavioDao.update(oNavio)
    End Function

    Public Function traerTodos() As IList(Of Navio)
        Return oNavioDao.getAll()
    End Function

End Class
