Imports System.Collections.ObjectModel

Public Class ODS
    Implements IEquatable(Of ODS)

    Public Property NumeroODS As Byte
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Metas As List(Of Meta)
    Public Property Imagen As String = $"ODS{NumeroODS}.png"
    Public Sub New(numeroODS As Byte)
        Me.NumeroODS = numeroODS
        Me.Nombre = ""
        Me.Descripcion = ""
        Me.Descripcion = ""
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, ODS))
    End Function

    Public Overloads Function Equals(other As ODS) As Boolean Implements IEquatable(Of ODS).Equals
        Return other IsNot Nothing AndAlso
               NumeroODS = other.NumeroODS
    End Function
    Public Function ODS(simple As Boolean)
        If simple Then
            Return $"{NumeroODS}: {Nombre}"
        Else
            Dim metasEnMensaje As String = ""
            For Each meta In Metas
                metasEnMensaje += $"{meta.ToString(False)}\n"
            Next
            Return $"{NumeroODS}: {Nombre}\n{Descripcion}\n{metasEnMensaje}"
        End If
    End Function
End Class