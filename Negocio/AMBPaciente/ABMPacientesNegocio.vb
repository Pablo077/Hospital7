Imports Modelo
Public Class ABMPacientesNegocio
    Implements Iabm
    Dim tarea As New ConsultasSQL

    Public Sub Alta(DNI As Int32, Nombre As String, Apellido As String) Implements Iabm.Alta

        tarea.Ingresar(New Pacientes() With {
            .DNI = DNI,
            .Nombre = Nombre,
            .Apellido = Apellido
        })

    End Sub

    Public Sub Eliminar(id As Int32) Implements Iabm.Eliminar
        tarea.EliminarPaciente(id)
    End Sub

    Public Sub Editar(id As Integer, DNI As Int32, Nombre As String, Apellido As String) Implements Iabm.Editar
        tarea.ActualizarPaciente(id, DNI, Nombre, Apellido)
    End Sub

    Public Function Cargar() As Object Implements Iabm.Cargar
        Cargar = tarea.CargarGrid()
    End Function
End Class
