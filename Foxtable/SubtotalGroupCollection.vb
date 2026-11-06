Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000098 RID: 152
	<ComVisible(True)>
	Public Class SubtotalGroupCollection
		Implements IEnumerable(Of SubtotalGroup)

		' Token: 0x06000599 RID: 1433 RVA: 0x0001D5F5 File Offset: 0x0001B7F5
		Public Sub New()
			Me.oO0O_0.ooo00. = New List(Of SubtotalGroup)()
		End Sub

		' Token: 0x0600059A RID: 1434 RVA: 0x0001D608 File Offset: 0x0001B808
		Public Sub Add(item As SubtotalGroup)
			Me.oO0O_0.ooo00..Add(item)
		End Sub

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x0600059B RID: 1435 RVA: 0x0001D616 File Offset: 0x0001B816
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oO0O_0.ooo00..Count
			End Get
		End Property

		' Token: 0x0600059C RID: 1436 RVA: 0x0001D623 File Offset: 0x0001B823
		Public Sub Clear()
			Me.oO0O_0.ooo00..Clear()
		End Sub

		' Token: 0x0600059D RID: 1437 RVA: 0x0001D630 File Offset: 0x0001B830
		Public Function GetEnumerator() As IEnumerator(Of SubtotalGroup) Implements System.Collections.Generic.IEnumerable(Of Foxtable.SubtotalGroup).GetEnumerator
			Return CType(Me.oO0O_0.ooo00..GetEnumerator(), IEnumerator(Of SubtotalGroup))
		End Function

		' Token: 0x0600059E RID: 1438 RVA: 0x0001D647 File Offset: 0x0001B847
		Function IEnumerable_GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x17000172 RID: 370
		Public ReadOnly Default Property Item(A_0 As Integer) As SubtotalGroup
			Get
				Return Me.oO0O_0.ooo00.(A_0)
			End Get
		End Property

		' Token: 0x060005A0 RID: 1440 RVA: 0x0001D65D File Offset: 0x0001B85D
		Public Sub AddRange(items As IEnumerable(Of SubtotalGroup))
			Me.oO0O_0.ooo00..AddRange(items)
		End Sub

		' Token: 0x0400014F RID: 335
		Private <<EMPTY_NAME>> As List(Of SubtotalGroup)
	End Class
End Namespace
