Public Class Form2

    Dim data As miReferenceClass
    Public Sub New(ByRef dato As miReferenceClass)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        data = dato
        Console.WriteLine($"EN FORM2 {dato.miStringDePaso}")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        data.miStringDePaso = data.miStringDePaso + "!"
        Console.WriteLine($"EN FORM2 {data.miStringDePaso}")

    End Sub


End Class