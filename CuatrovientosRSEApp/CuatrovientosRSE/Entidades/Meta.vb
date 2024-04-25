Public Class Meta
    Implements IEquatable(Of Meta)

    Public Property NumeroODS As Byte
    Public Property CaracterMeta As String
    Public Property Descripcion As String

    Public Overloads Function ToString(simple As Boolean)
        If simple Then
            Return $"{NumeroODS}.{CaracterMeta}"
        Else
            Return $"{NumeroODS}.{CaracterMeta}: {Descripcion}"
        End If
    End Function
    Public Sub New(numeroODS As Byte, caracterMeta As String)
        Me.NumeroODS = numeroODS
        Me.CaracterMeta = caracterMeta
        Me.Descripcion = ""
    End Sub
    Public Sub New(numeroODS As Byte, caracterMeta As String, descripcion As String)
        Me.NumeroODS = numeroODS
        Me.CaracterMeta = caracterMeta
        Me.Descripcion = descripcion
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Meta))
    End Function

    Public Overloads Function Equals(other As Meta) As Boolean Implements IEquatable(Of Meta).Equals
        Return other IsNot Nothing AndAlso
               NumeroODS = other.NumeroODS AndAlso
               CaracterMeta = other.CaracterMeta
    End Function

End Class
