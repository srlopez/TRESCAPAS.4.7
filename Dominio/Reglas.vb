
Imports AccesoDatos
Public Module Reglas
    Function EsValido(u As Modelos.Usuario) As Boolean
        If u.map < 20 Or u.map > 80 Or u.email.IndexOf("XX") > -1 Then
            Throw New System.Exception($"{u.map} no es una M.A.P. aceptable")
            Return True
        End If
        Return True
    End Function
End Module

