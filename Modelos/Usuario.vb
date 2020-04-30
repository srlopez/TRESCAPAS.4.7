Public Class Usuario
    Public id As Integer
    Public nombre As String
    Public email As String
    Public notas As String
    Public fnac As Date
    Public map As Decimal

    Public Sub New()

    End Sub
    Public Sub New(id As Integer,
                   nombre As String,
                   email As String,
                   notas As String,
                   fnac As Date,
                   map As Decimal)
        id = id
        nombre = nombre
        email = email
        notas = notas
        fnac = fnac
        map = map
    End Sub

    Public Sub New(row As DataRow)
        id = row("ID")
        nombre = row("NOMBRE")
        email = row("EMAIL") + ""
        notas = row("NOTAS") + ""
        fnac = DateTime.ParseExact(row("FNAC"), "ddMMyyyy", Nothing)
        map = row("MAP")
    End Sub

    Public Function Clone() As Usuario
        Return DirectCast(Me.MemberwiseClone(), Usuario)
    End Function
End Class


