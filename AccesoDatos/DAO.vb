Imports System.Data
Imports Microsoft.Data.Sqlite
Imports System.Data.SqlClient
Imports System.Data.OleDb

#Const DATABASE = "SQLite"
'#Const DATABASE = "SQLServer"
'#Const DATABASE = "MSAccess"

Namespace DAM
    Public Module DB
#If DATABASE = "SQLite" Then
        Public Function getConnection() As SqliteConnection
            'Console.WriteLine(Directory.GetCurrentDirectory())
            Dim connString = "Data Source=..\..\..\database.sq3"
            getConnection = New SqliteConnection(connString)
            'Console.WriteLine("State: {0}", getConnection.State)
            'Console.WriteLine("ServerVersion: {0}", getConnection.ServerVersion)
        End Function
#ElseIf DATABASE = "MSAccess" Then
        Public Function getConnection() As OleDbConnection
            Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\database.accdb;Persist Security Info=False"
            getConnection = New OleDbConnection(connString)
        End Function
#ElseIf DATABASE = "SQLServer" Then
        Public Function getConnection() As SqlConnection
            Dim connString = "Data Source=slimbook;Initial Catalog=BASE;User ID=sa;Password=Pa88word"
            getConnection = New SqlConnection(connString)
        End Function
#End If

    End Module

    Public Module Usuarios
        Public Function QryGetAll() As DataTable
            Dim query = "SELECT ID, NOMBRE, MAP FROM USUARIOS"
            Dim conn = DB.getConnection()
            conn.Open()
#If DATABASE = "SQLite" Then
            Dim sqlCommand = New SqliteCommand(query, conn)
#ElseIf DATABASE = "MSAccess" Then
            Dim sqlCommand = New OleDbCommand(query, conn)
#ElseIf DATABASE = "SQLServer" Then
            Dim sqlCommand = New SqlCommand(query, conn)
#End If
            Dim table = New DataTable()
            Dim executeReader = sqlCommand.ExecuteReader()
            table.Load(executeReader)
            sqlCommand.Dispose()
            conn.Close()
            Return table
        End Function

        Public Function QryByFiltro(filtro As String) As DataTable
            Dim query = "SELECT * FROM USUARIOS
                        WHERE NOMBRE LIKE @nombre OR EMAIL LIKE @email"
            Dim conn = DB.getConnection()
            conn.Open()
#If DATABASE = "SQLite" Then
            Dim sqlCommand = New SqliteCommand(query, conn)
#ElseIf DATABASE = "MSAccess" Then
            Dim sqlCommand = New OleDbCommand(query, conn)
#ElseIf DATABASE = "SQLServer" Then
            Dim sqlCommand = New SqlCommand(query, conn)
#End If
            sqlCommand.Parameters.AddWithValue("@nombre", filtro + "%")
            sqlCommand.Parameters.AddWithValue("@email", "%" + filtro + "%")
            Dim table = New DataTable()
            Dim executeReader = sqlCommand.ExecuteReader()
            table.Load(executeReader)
            sqlCommand.Dispose()
            conn.Close()
            Return table
        End Function

        Public Function QryGetByID(id As Integer) As DataTable
            Dim query = "SELECT * FROM USUARIOS
                    WHERE ID = @id;"
            Dim conn = DB.getConnection()
            conn.Open()
#If DATABASE = "SQLite" Then
            Dim sqlCommand = New SqliteCommand(query, conn)
#ElseIf DATABASE = "MSAccess" Then
            Dim sqlCommand = New OleDbCommand(query, conn)
#ElseIf DATABASE = "SQLServer" Then
            Dim sqlCommand = New SqlCommand(query, conn)
#End If
            sqlCommand.Parameters.AddWithValue("@id", id)
            Dim table = New DataTable()
            Dim executeReader = sqlCommand.ExecuteReader()
            table.Load(executeReader)
            sqlCommand.Dispose()
            conn.Close()
            Return table
        End Function


        Public Function CmdInsert(u As Modelos.Usuario) As Integer
            Dim id = -1
            Dim conn = DB.getConnection()
            conn.Open()
            Console.WriteLine(u.map)
            Try
                Dim cmd = conn.CreateCommand
#If DATABASE = "SQLite" Then
                cmd.CommandText = "INSERT INTO USUARIOS 
                 (NOMBRE, EMAIL, NOTAS, FNAC, MAP) VALUES 
                 (@nombre, @email, @notas, @fnac, @map);
                 SELECT last_insert_rowid();"
                cmd.Parameters.AddWithValue("@nombre", u.nombre)
                cmd.Parameters.AddWithValue("@email", u.email)
                cmd.Parameters.AddWithValue("@notas", u.notas)
                cmd.Parameters.AddWithValue("@fnac", Format(u.fnac, "ddMMyyyy"))
                cmd.Parameters.AddWithValue("@map", u.map)
                'cmd.Parameters.Add("@map", SqlDbType.Decimal, 0)
                'Dim param = cmd.Parameters("@map")
                'param.Precision = 4
                'param.Scale = 2
                'param.Value = u.map
#ElseIf DATABASE = "MSAccess" Then
            cmd.CommandText = "INSERT INTO USUARIOS 
                 (NOMBRE, EMAIL, NOTAS, FNAC, MAP) VALUES 
                 (@nombre, @email, @notas, @fnac, @map)"
                cmd.Parameters.AddWithValue("@nombre", u.nombre)
                cmd.Parameters.AddWithValue("@email", u.email)
                cmd.Parameters.AddWithValue("@notas", u.notas)
                cmd.Parameters.AddWithValue("@fnac", Format(u.fnac, "ddMMyyyy"))
                cmd.Parameters.AddWithValue("@map", u.map)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@Identity"
#ElseIf DATABASE = "SQLServer" Then
            cmd.CommandText = "INSERT INTO USUARIOS 
                 (NOMBRE, EMAIL, NOTAS, FNAC, MAP) VALUES 
                 (@nombre, @email, @notas, @fnac, @map);
                 SELECT IDENT_CURRENT('USUARIOS')"
            cmd.Parameters.AddWithValue("@nombre", u.nombre)
            cmd.Parameters.AddWithValue("@email", u.email)
            cmd.Parameters.AddWithValue("@notas", u.notas)
            cmd.Parameters.AddWithValue("@fnac", u.fnac)
            cmd.Parameters.AddWithValue("@map", u.map)
#End If
                id = cmd.ExecuteScalar()

            Catch ex As Exception
                Throw ex
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            Return id
        End Function

        Public Function CmdUpdate(u As Modelos.Usuario) As Integer
            Dim ret As Integer = -1
            Dim conn = DB.getConnection()
            conn.Open()
            Try
                Dim cmd = conn.CreateCommand
                cmd.CommandText = "UPDATE USUARIOS SET
                    NOMBRE = @nombre,
                    EMAIL = @email,
                    NOTAS = @notas, 
                    FNAC = @fnac,
                    MAP = @map 
                WHERE ID = @id;"
                cmd.Parameters.AddWithValue("@nombre", u.nombre)
                cmd.Parameters.AddWithValue("@email", u.email)
                cmd.Parameters.AddWithValue("@notas", u.notas)
#If DATABASE = "SQLServer" Then
                cmd.Parameters.AddWithValue("@fnac", u.fnac)
#Else
                cmd.Parameters.AddWithValue("@fnac", Format(u.fnac, "ddMMyyyy"))
#End If
                cmd.Parameters.AddWithValue("@map", u.map)
                cmd.Parameters.AddWithValue("@id", u.id)
                ret = cmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            Return ret
        End Function

        Public Function CmdDelete(u As Modelos.Usuario) As Integer
            Dim ret As Integer = -1
            Dim conn = DB.getConnection()
            conn.Open()
            Try
                Dim cmd = conn.CreateCommand
                cmd.CommandText = "DELETE FROM USUARIOS
                WHERE ID = @id;"
                cmd.Parameters.AddWithValue("@id", u.id)
                ret = cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
                Console.WriteLine(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            Return ret
        End Function
    End Module

End Namespace

