Public Class ConsultasSQL
    Dim _db As New Hospital_DBEntities

    Public Sub Ingresar(paciente As Pacientes)

        _db.Pacientes.Add(paciente)
        _db.SaveChanges()
    End Sub

    Public Function CargarGrid()

        Dim datos = (From e In _db.Pacientes Select e).ToList
        CargarGrid = datos

    End Function

    Public Sub EliminarPaciente(id As Integer)
        Dim pac = (From e In _db.Pacientes
                   Where e.Id = id
                   Select e).SingleOrDefault
        _db.Pacientes.Remove(pac)
        _db.SaveChanges()
    End Sub

    Public Sub ActualizarPaciente(id As Integer, DNI As Int32, Nombre As String, Apellido As String)
        Dim pac = (From e In _db.Pacientes
                   Where e.Id = id
                   Select e).SingleOrDefault
        With pac
            .DNI = DNI
            .Nombre = Nombre
            .Apellido = Apellido
        End With
        _db.SaveChanges()
    End Sub

End Class
