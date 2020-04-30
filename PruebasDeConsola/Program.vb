Imports System.Data
Imports AccesoDatos
Imports Dominio


Module Program
    Sub Main(args As String())
        Randomize()

        Console.WriteLine("PRUEBAS DE ACCESO A DATOS")

        'INSERT
        Dim u = New Modelos.Usuario()
        u.nombre = "Us#" + CStr(CInt(1000 * Rnd()))
        u.notas = "notas"
        u.email = "email"
        u.map = CInt(10000 * Rnd()) \ 100
        u.fnac = Today
        u.id = DAM.Usuarios.CmdInsert(u)
        'u.id = UseCase.CrearUsuario(u)
        Console.WriteLine($"ID insertado {u.id}")

        'UPDATE
        u.nombre = "CAMBIO#" + CStr(CInt(1000 * Rnd()))
        Console.WriteLine($"#actualizados {DAM.Usuarios.CmdUpdate(u)}")

        'SELECT
        Dim tab = DAM.Usuarios.QryGetAll()
        For Each row In tab.Rows
            Console.WriteLine($"{row("ID")}: {row("NOMBRE")} {row("MAP")}")
        Next

        'DELETE
        Console.WriteLine($"#actualizados {DAM.Usuarios.CmdDelete(u)}")

        'SELECT
        For Each row In DAM.Usuarios.QryGetAll().Rows
            Console.WriteLine($"{row("ID")}: {row("NOMBRE")} {row("MAP")}")
        Next

        Console.WriteLine("PRUEBAS DE CASOS DE USO")
        u = New Modelos.Usuario()
        u.nombre = "CU#" + CStr(CInt(1000 * Rnd()))
        u.notas = "CUnotas"
        u.email = "CUemail"
        u.map = CInt(10000 * Rnd()) \ 100
        u.fnac = Today
        u.id = UseCase.CrearUsuario(u)

        tab = UseCase.ObtenerUsuarios()
        For Each row In tab.Rows
            Console.WriteLine($"{row("ID")}: {row("NOMBRE")} {row("MAP")}")
        Next
        Console.WriteLine("FIN")
        Console.ReadLine()
    End Sub
End Module

