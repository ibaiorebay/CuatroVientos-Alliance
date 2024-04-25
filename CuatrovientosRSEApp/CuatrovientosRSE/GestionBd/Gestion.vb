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
        Dim cambios As Boolean = False
        If Not (numODS > 0 AndAlso numODS <= 17) Then
            Return $"El ODS número {numODS} no existe"
        End If
        Dim odsGuardado As ODS = _Agenda2030(_Agenda2030.IndexOf(nuevoODS))
        If CambioContieneAsrterisco(nuevoODS.Nombre, odsGuardado.Nombre, cambios) Then
            Return "El nombre del ODS no puede contener el caracter '*'"
        End If
        If CambioContieneAsrterisco(nuevoODS.Descripcion, odsGuardado.Descripcion, cambios) Then
            Return "La descripción del ODS no puede contener el caracter '*'"
        End If
        For i = 0 To nuevoODS.Metas.Count
            If odsGuardado.Metas(i) IsNot Nothing Then
                If CambioContieneAsrterisco(nuevoODS.Metas(i).Descripcion, odsGuardado.Metas(i).Descripcion, cambios) Then
                    Return $"La descripcion de la meta {nuevoODS.Metas(i).ToString(True)} no puede contener el caracter '*'"
                End If
            Else
                If nuevoODS.Metas(i).Descripcion.Contains("*") Then
                    cambios = True
                    Return $"La descripcion de la nueva meta {nuevoODS.Metas(i).ToString(True)} no puede contener el caracter '*'"
                End If
            End If
        Next
        If Not cambios Then
            Return "No has hecho cambios"
        End If
        Return ""
    End Function
    Private Function CambioContieneAsrterisco(textoNuevo As String, textoGuardado As String, ByRef cambios As Boolean) As Boolean
        If Not textoNuevo.Equals(textoGuardado) Then
            cambios = True
            If textoNuevo.Contains("*") Then
                Return True
            End If
        End If
        Return False
    End Function

End Class
