
Imports AccesoDatos
Public Module UseCase
    Public Function CrearUsuario(u As Modelos.Usuario) As Integer
        If Reglas.EsValido(u) Then
            Return DAM.Usuarios.CmdInsert(u)
        End If
        Return -1
    End Function


    Public Function EliminiarUsuario(u As Modelos.Usuario) As Integer
        Return DAM.Usuarios.CmdDelete(u)
    End Function

    Public Function ActualizarUsuario(u As Modelos.Usuario) As Integer
        Return IIf(Reglas.EsValido(u),
                   DAM.Usuarios.CmdUpdate(u),
                   -1)
    End Function

    Public Function ObtenerUsuarios() As DataTable
        Return DAM.Usuarios.QryGetAll()
    End Function
    Public Function ObtenerUsuariosByFiltro(f As String) As DataTable
        Return DAM.Usuarios.QryByFiltro(f)
    End Function

    Public Function ObtenerUsuarioByID(id) As DataTable
        Return DAM.Usuarios.QryGetByID(id)
    End Function

End Module

