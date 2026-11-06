Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020000AB RID: 171
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPBeforeListDetailsEventArgs
		' Token: 0x060006E6 RID: 1766 RVA: 0x00026EB4 File Offset: 0x000250B4
		Public Sub New(A_0 As String, A_1 As List(Of String), A_2 As String)
			Me.o_._Ooo_o_O_O. = New List(Of String())()
			Me.o_._Ooo_o_O_O. = New List(Of String)()
			Me.o_._Ooo_o_O_O. = A_0
			Me.O0_.000. = A_2
			Try
				For Each text As String In A_1
					Me.Infos.Add(text.Split(New Char() { "*"c }))
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x060006E7 RID: 1767 RVA: 0x00026F44 File Offset: 0x00025144
		Public ReadOnly Property CurFolder As String
			Get
				Return Me.o_._Ooo_o_O_O.
			End Get
		End Property

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x060006E8 RID: 1768 RVA: 0x00026F4C File Offset: 0x0002514C
		Public ReadOnly Property Infos As List(Of String())
			Get
				Return Me.o_._Ooo_o_O_O.
			End Get
		End Property

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x060006E9 RID: 1769 RVA: 0x00026F54 File Offset: 0x00025154
		Public ReadOnly Property FTPName As String
			Get
				Return Me.O0_.000.
			End Get
		End Property

		' Token: 0x060006EA RID: 1770 RVA: 0x00026F5C File Offset: 0x0002515C
		Public Sub Remove(Item As String())
			Me.o_._Ooo_o_O_O..Add(Item(0))
		End Sub

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x060006EB RID: 1771 RVA: 0x00026F6C File Offset: 0x0002516C
		Friend ReadOnly Property RemovedItems As String()
			Get
				Dim array As String() = Me.o_._Ooo_o_O_O..ToArray()
				Array.Sort(Of String)(array)
				Return array
			End Get
		End Property

		' Token: 0x040001E6 RID: 486
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001E7 RID: 487
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001E8 RID: 488
		Private <<EMPTY_NAME>> As List(Of String())

		' Token: 0x040001E9 RID: 489
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
