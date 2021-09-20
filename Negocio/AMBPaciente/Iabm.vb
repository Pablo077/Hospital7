Public Interface Iabm
    Sub Alta(DNI As Int32, Nombre As String, Apellido As String)
    Sub Eliminar(id As Int32)
    Sub Editar(id As Integer, DNI As Int32, Nombre As String, Apellido As String)
    Function Cargar()
End Interface
