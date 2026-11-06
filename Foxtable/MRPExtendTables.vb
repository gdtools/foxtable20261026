Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000092 RID: 146
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class MRPExtendTables
		Implements IEnumerable(Of o00_0__O)

		' Token: 0x06000572 RID: 1394 RVA: 0x0001D353 File Offset: 0x0001B553
		Public Sub New()
			Me.oOO.0_O0. = New Collection(Of o00_0__O)()
		End Sub

		' Token: 0x06000573 RID: 1395 RVA: 0x0001D366 File Offset: 0x0001B566
		Public Sub Add(DataTable As DataTable, MaterialCol As String, QuantityCol As String, NewName As String)
			Me.oOO.0_O0..Add(New o00_0__O(DataTable, MaterialCol, QuantityCol, NewName))
		End Sub

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x06000574 RID: 1396 RVA: 0x0001D37D File Offset: 0x0001B57D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oOO.0_O0..Count
			End Get
		End Property

		' Token: 0x06000575 RID: 1397 RVA: 0x0001D38A File Offset: 0x0001B58A
		Public Sub Clear()
			Me.oOO.0_O0..Clear()
		End Sub

		' Token: 0x06000576 RID: 1398 RVA: 0x0001D397 File Offset: 0x0001B597
		Public Function GetEnumerator() As IEnumerator(Of o00_0__O) Implements System.Collections.Generic.IEnumerable(Of Foxtable.o00_0__O).GetEnumerator
			Return Me.oOO.0_O0..GetEnumerator()
		End Function

		' Token: 0x06000577 RID: 1399 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x0400013E RID: 318
		Private <<EMPTY_NAME>> As Collection(Of o00_0__O)
	End Class
End Namespace
