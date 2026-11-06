Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E5 RID: 1253
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RowCollection
		Implements IEnumerable(Of Row)

		' Token: 0x0600505B RID: 20571 RVA: 0x00218735 File Offset: 0x00216935
		Public Sub New(A_0 As XLRowCollection)
			Me.OoOoo.o. = A_0
		End Sub

		' Token: 0x17001228 RID: 4648
		' (get) Token: 0x0600505C RID: 20572 RVA: 0x00218744 File Offset: 0x00216944
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OoOoo.o..Count
			End Get
		End Property

		' Token: 0x17001229 RID: 4649
		' (get) Token: 0x0600505D RID: 20573 RVA: 0x00218751 File Offset: 0x00216951
		' (set) Token: 0x0600505E RID: 20574 RVA: 0x0021875E File Offset: 0x0021695E
		Public Property Frozen As Integer
			Get
				Return Me.OoOoo.o..Frozen
			End Get
			Set(value As Integer)
				Me.OoOoo.o..Frozen = value
			End Set
		End Property

		' Token: 0x1700122A RID: 4650
		Public ReadOnly Default Property Item(Index As Integer) As Row
			Get
				Return New Row(Me.OoOoo.o.(Index))
			End Get
		End Property

		' Token: 0x06005060 RID: 20576 RVA: 0x0021877F File Offset: 0x0021697F
		Public Sub Clear()
			Me.OoOoo.o..Clear()
		End Sub

		' Token: 0x06005061 RID: 20577 RVA: 0x0021878C File Offset: 0x0021698C
		Public Function Add() As Row
			Return New Row(Me.OoOoo.o..Add())
		End Function

		' Token: 0x06005062 RID: 20578 RVA: 0x0021879E File Offset: 0x0021699E
		Public Function Insert(Index As Integer) As Row
			Return New Row(Me.OoOoo.o..Insert(Index))
		End Function

		' Token: 0x06005063 RID: 20579 RVA: 0x002187B1 File Offset: 0x002169B1
		Public Sub Remove(Row As Row)
			Me.OoOoo.o..Remove(Row.OoOoo.o.)
		End Sub

		' Token: 0x06005064 RID: 20580 RVA: 0x002187C5 File Offset: 0x002169C5
		Public Sub RemoveAt(Index As Integer)
			Me.OoOoo.o..RemoveAt(Index)
		End Sub

		' Token: 0x06005065 RID: 20581 RVA: 0x002187D4 File Offset: 0x002169D4
		Public Function GetEnumerator() As IEnumerator(Of Row) Implements System.Collections.Generic.IEnumerable(Of Foxtable.XLS.Row).GetEnumerator
			Return New c(Me.OoOoo.o.)
		End Function

		' Token: 0x06005066 RID: 20582 RVA: 0x002187E1 File Offset: 0x002169E1
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New c(Me.OoOoo.o.)
		End Function

		' Token: 0x0400219B RID: 8603
		Private <<EMPTY_NAME>> As XLRowCollection
	End Class
End Namespace
