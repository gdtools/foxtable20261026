Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004DB RID: 1243
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ColColection
		Implements IEnumerable(Of Col)

		' Token: 0x06004FFF RID: 20479 RVA: 0x00217F0B File Offset: 0x0021610B
		Public Sub New(A_0 As XLColumnCollection)
			Me.o0_.O_o. = A_0
		End Sub

		' Token: 0x17001204 RID: 4612
		' (get) Token: 0x06005000 RID: 20480 RVA: 0x00217F1A File Offset: 0x0021611A
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o0_.O_o..Count
			End Get
		End Property

		' Token: 0x17001205 RID: 4613
		' (get) Token: 0x06005001 RID: 20481 RVA: 0x00217F27 File Offset: 0x00216127
		' (set) Token: 0x06005002 RID: 20482 RVA: 0x00217F34 File Offset: 0x00216134
		Public Property Frozen As Integer
			Get
				Return Me.o0_.O_o..Frozen
			End Get
			Set(value As Integer)
				Me.o0_.O_o..Frozen = value
			End Set
		End Property

		' Token: 0x17001206 RID: 4614
		Public ReadOnly Default Property Item(Index As Integer) As Col
			Get
				Return New Col(Me.o0_.O_o.(Index))
			End Get
		End Property

		' Token: 0x06005004 RID: 20484 RVA: 0x00217F55 File Offset: 0x00216155
		Public Sub Clear()
			Me.o0_.O_o..Clear()
		End Sub

		' Token: 0x06005005 RID: 20485 RVA: 0x00217F62 File Offset: 0x00216162
		Public Function Add() As Col
			Return New Col(Me.o0_.O_o..Add())
		End Function

		' Token: 0x06005006 RID: 20486 RVA: 0x00217F74 File Offset: 0x00216174
		Public Function Insert(Index As Integer) As Col
			Return New Col(Me.o0_.O_o..Insert(Index))
		End Function

		' Token: 0x06005007 RID: 20487 RVA: 0x00217F87 File Offset: 0x00216187
		Public Sub Remove(Col As Col)
			Me.o0_.O_o..Remove(Col.o0_.O_o.)
		End Sub

		' Token: 0x06005008 RID: 20488 RVA: 0x00217F9B File Offset: 0x0021619B
		Public Sub RemoveAt(Index As Integer)
			Me.o0_.O_o..RemoveAt(Index)
		End Sub

		' Token: 0x06005009 RID: 20489 RVA: 0x00217FAA File Offset: 0x002161AA
		Public Function GetEnumerator() As IEnumerator(Of Col) Implements System.Collections.Generic.IEnumerable(Of Foxtable.XLS.Col).GetEnumerator
			Return New a(Me.o0_.O_o.)
		End Function

		' Token: 0x0600500A RID: 20490 RVA: 0x00217FB7 File Offset: 0x002161B7
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New a(Me.o0_.O_o.)
		End Function

		' Token: 0x04002178 RID: 8568
		Private <<EMPTY_NAME>> As XLColumnCollection
	End Class
End Namespace
