Imports System.Collections.ObjectModel
Imports Entidades
Public Class Gestion
    Private _Agenda2030 As List(Of ODS)
    Public ReadOnly Property Agenda2030 As ReadOnlyCollection(Of ODS)
        Get
            Return _Agenda2030.AsReadOnly
        End Get
    End Property
    Public Sub New()
        _Agenda2030 = New List(Of ODS)
    End Sub
    Public Function ModificarODS(nuevoODS As ODS) As String
        Dim numODS As Byte = nuevoODS.NumeroODS
        If Not (numODS > 0 AndAlso numODS <= 17) Then
            Return $"El ODS número {numODS} no existe"
        End If

    End Function
End Class
