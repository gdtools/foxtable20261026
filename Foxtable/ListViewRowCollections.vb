Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020001A9 RID: 425
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListViewRowCollections
		Implements IEnumerable(Of ListViewRow)

		' Token: 0x06001407 RID: 5127 RVA: 0x000805BD File Offset: 0x0007E7BD
		Public Sub New(A_0 As System.Windows.Forms.ListView.ListViewItemCollection)
			Me.O._OOOO0_. = A_0
		End Sub

		' Token: 0x06001408 RID: 5128 RVA: 0x000805CC File Offset: 0x0007E7CC
		Public Sub New(A_0 As System.Windows.Forms.ListView)
			Me.O._OOOO0_. = A_0.Items
			Me.O._OOOO0_. = A_0
		End Sub

		' Token: 0x1700041C RID: 1052
		' (get) Token: 0x06001409 RID: 5129 RVA: 0x000805E7 File Offset: 0x0007E7E7
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O._OOOO0_..Count
			End Get
		End Property

		' Token: 0x1700041D RID: 1053
		' (get) Token: 0x0600140A RID: 5130 RVA: 0x000805F4 File Offset: 0x0007E7F4
		Public ReadOnly Property Contains(key As String) As Boolean
			Get
				Return Me.O._OOOO0_..ContainsKey(key)
			End Get
		End Property

		' Token: 0x1700041E RID: 1054
		Public ReadOnly Default Property Item(Index As Integer) As ListViewRow
			Get
				Return New ListViewRow(Me.O._OOOO0_.(Index))
			End Get
		End Property

		' Token: 0x1700041F RID: 1055
		Public ReadOnly Default Property Item(Key As String) As ListViewRow
			Get
				Return New ListViewRow(Me.O._OOOO0_.(Key))
			End Get
		End Property

		' Token: 0x0600140D RID: 5133 RVA: 0x00080628 File Offset: 0x0007E828
		Public Function Add() As ListViewRow
			Dim result As ListViewRow
			If Me.O._OOOO0_. Is Nothing Then
				result = Nothing
			ElseIf Me.O._OOOO0_..VirtualMode Then
				Me.O._OOOO0_..VirtualListSize = Me.O._OOOO0_..VirtualListSize + 1
				result = New ListViewRow(Me.O._OOOO0_..Items(Me.O._OOOO0_..Items.Count - 1))
			Else
				Dim listViewItem As ListViewItem = New ListViewItem()
				Me.O._OOOO0_..Add(listViewItem)
				If Me.O._OOOO0_..Columns.Count > 0 Then
					listViewItem.SubItems(0).Name = Me.O._OOOO0_..Columns(0).Name
					Dim num As Integer = Me.O._OOOO0_..Columns.Count - 1
					For i As Integer = 1 To num
						listViewItem.SubItems.Add("").Name = Me.O._OOOO0_..Columns(i).Name
					Next
				End If
				result = New ListViewRow(listViewItem)
			End If
			Return result
		End Function

		' Token: 0x0600140E RID: 5134 RVA: 0x00080735 File Offset: 0x0007E935
		Public Sub Clear()
			Me.O._OOOO0_..Clear()
		End Sub

		' Token: 0x0600140F RID: 5135 RVA: 0x00080742 File Offset: 0x0007E942
		Public Sub Delete(Index As Integer)
			New ListViewRow(Me.O._OOOO0_.(Index)).Delete()
		End Sub

		' Token: 0x06001410 RID: 5136 RVA: 0x0008075A File Offset: 0x0007E95A
		Public Sub Delete(Key As String)
			New ListViewRow(Me.O._OOOO0_.(Key)).Delete()
		End Sub

		' Token: 0x06001411 RID: 5137 RVA: 0x00080772 File Offset: 0x0007E972
		Public Sub Delete(item As ListViewRow)
			item.Delete()
		End Sub

		' Token: 0x06001412 RID: 5138 RVA: 0x0008077A File Offset: 0x0007E97A
		Public Function GetEnumerator() As IEnumerator(Of ListViewRow) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.ListViewRow).GetEnumerator
			Return New O0_0oO__oo(Me.O._OOOO0_.)
		End Function

		' Token: 0x06001413 RID: 5139 RVA: 0x00080787 File Offset: 0x0007E987
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O0_0oO__oo(Me.O._OOOO0_.)
		End Function

		' Token: 0x040007D1 RID: 2001
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListView.ListViewItemCollection

		' Token: 0x040007D2 RID: 2002
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListView
	End Class
End Namespace
