Public Class Meta
    Implements IEquatable(Of Meta)

    Private Property NumeroODS As Byte
    Private Property NumeroMeta As Byte
    Private Property Descripcion As String

    Public Overloads Function ToString()
        Return $"{NumeroODS}.{NumeroMeta}: {Descripcion}"
    End Function
    Public Sub New(numeroODS As Byte, numeroMeta As Byte)
        Me.NumeroODS = numeroODS
        Me.NumeroMeta = numeroMeta
        Me.Descripcion = ""
    End Sub
    Public Sub New(numeroODS As Byte, numeroMeta As Byte, descripcion As String)
        Me.NumeroODS = numeroODS
        Me.NumeroMeta = numeroMeta
        Me.Descripcion = descripcion
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Meta))
    End Function

    Public Overloads Function Equals(other As Meta) As Boolean Implements IEquatable(Of Meta).Equals
        Return other IsNot Nothing AndAlso
               NumeroODS = other.NumeroODS AndAlso
               NumeroMeta = other.NumeroMeta
    End Function

End Class
