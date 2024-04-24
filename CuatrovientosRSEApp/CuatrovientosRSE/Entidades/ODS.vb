Imports System.Collections.ObjectModel

Public Class ODS
    Implements IEquatable(Of ODS)

    Private Property NumeroODS As Byte
    Private Property Nombre As String
    Private Property Descripcion As String
    Private Property _Metas As List(Of Meta)
    Public ReadOnly Property Metas As ReadOnlyCollection(Of Meta)
        Get
            Return _Metas.AsReadOnly
        End Get
    End Property
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
            For Each meta In _Metas
                metasEnMensaje += $"{meta.ToString}\n"
            Next
            Return $"{NumeroODS}: {Nombre}\n{Descripcion}\n{metasEnMensaje}"
        End If
    End Function
End Class