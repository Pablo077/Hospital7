Imports Negocio
Public Class frmABMPacientes

    Dim tarea As New ABMPacientesNegocio
    Dim id As Integer

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If tbxDNI.Text = "" Or tbxNombre.Text = "" Or tbxApellido.Text = "" Then
            MsgBox("Por favor complete todo los campos")
        Else
            tarea.Alta(Convert.ToInt32(tbxDNI.Text), tbxNombre.Text, tbxApellido.Text)
            CargarDataGridView()
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If tbxDNI.Text = "" Or tbxNombre.Text = "" Or tbxApellido.Text = "" Or id.ToString = "" Then
            MsgBox("Por favor complete todo los campos")
        Else
            tarea.Editar(id, tbxDNI.Text, tbxNombre.Text, tbxApellido.Text)
            CargarDataGridView()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If id = vbEmpty Then
            MsgBox("Seleccione un paciente")
        Else
            tarea.Eliminar(id)
            MsgBox("Se elimino el paciente")
            CargarDataGridView()
        End If

    End Sub

    Private Sub frmABMPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataGridView()
    End Sub

    Private Sub CargarDataGridView()
        dgvPacientes.DataSource = tarea.Cargar()
    End Sub

    Private Sub dgvPacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellClick
        id = dgvPacientes.CurrentRow.Cells(0).Value
        tbxDNI.Text = dgvPacientes.CurrentRow.Cells(1).Value
        tbxNombre.Text = dgvPacientes.CurrentRow.Cells(2).Value
        tbxApellido.Text = dgvPacientes.CurrentRow.Cells(3).Value
    End Sub
End Class