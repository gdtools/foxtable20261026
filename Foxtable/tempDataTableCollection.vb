Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200044F RID: 1103
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class tempDataTableCollection
		' Token: 0x060048D4 RID: 18644 RVA: 0x001EBFAD File Offset: 0x001EA1AD
		Public Sub New()
			Me._List = New Dictionary(Of String, DataTable)()
		End Sub

		' Token: 0x060048D5 RID: 18645 RVA: 0x001EBFC0 File Offset: 0x001EA1C0
		Friend Sub add(name As String, dt As DataTable)
			Me._List.Add(name, dt)
		End Sub

		' Token: 0x1700104D RID: 4173
		Public ReadOnly Default Property Item(A_0 As String) As DataTable
			Get
				Try
					For Each text As String In Me._List.Keys
						If Operators.CompareString(text, A_0, True) = 0 Then
							Return Me._List(text)
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return Nothing
			End Get
		End Property

		' Token: 0x060048D7 RID: 18647 RVA: 0x001EC040 File Offset: 0x001EA240
		Public Function Contains(name As String) As Boolean
			Try
				Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator = Me._List.Keys.GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current, name, True) = 0 Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function

		' Token: 0x04001DBF RID: 7615
		Friend _List As Dictionary(Of String, DataTable)
	End Class
End Namespace
