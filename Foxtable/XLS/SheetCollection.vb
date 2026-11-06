Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E8 RID: 1256
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SheetCollection
		Implements IEnumerable(Of Sheet)

		' Token: 0x06005086 RID: 20614 RVA: 0x00218A46 File Offset: 0x00216C46
		Public Sub New(A_0 As XLSheetCollection)
			Me.Ooo_O__.0. = A_0
		End Sub

		' Token: 0x17001238 RID: 4664
		Public ReadOnly Default Property Item(Index As Integer) As Sheet
			Get
				Return New Sheet(Me.Ooo_O__.0.(Index))
			End Get
		End Property

		' Token: 0x17001239 RID: 4665
		Public ReadOnly Default Property Item(Name As String) As Sheet
			Get
				Return New Sheet(Me.Ooo_O__.0.(Name))
			End Get
		End Property

		' Token: 0x1700123A RID: 4666
		' (get) Token: 0x06005089 RID: 20617 RVA: 0x00218A7B File Offset: 0x00216C7B
		Public ReadOnly Property Count As Integer
			Get
				Return Me.Ooo_O__.0..Count
			End Get
		End Property

		' Token: 0x1700123B RID: 4667
		' (get) Token: 0x0600508A RID: 20618 RVA: 0x00218A88 File Offset: 0x00216C88
		' (set) Token: 0x0600508B RID: 20619 RVA: 0x00218A95 File Offset: 0x00216C95
		Public Property SelectedIndex As Integer
			Get
				Return Me.Ooo_O__.0..SelectedIndex
			End Get
			Set(value As Integer)
				Me.Ooo_O__.0..SelectedIndex = value
			End Set
		End Property

		' Token: 0x0600508C RID: 20620 RVA: 0x00218AA3 File Offset: 0x00216CA3
		Public Function Add() As Sheet
			Return New Sheet(Me.Ooo_O__.0..Add())
		End Function

		' Token: 0x0600508D RID: 20621 RVA: 0x00218AB5 File Offset: 0x00216CB5
		Public Function Add(Name As String) As Sheet
			Return New Sheet(Me.Ooo_O__.0..Add(Name))
		End Function

		' Token: 0x0600508E RID: 20622 RVA: 0x00218AC8 File Offset: 0x00216CC8
		Public Sub Add(Sheet As Sheet)
			Me.Ooo_O__.0..Add(Sheet.Ooo_O__.0.)
		End Sub

		' Token: 0x0600508F RID: 20623 RVA: 0x00218ADC File Offset: 0x00216CDC
		Public Function Insert(Index As Integer) As Sheet
			Return New Sheet(Me.Ooo_O__.0..Insert(Index))
		End Function

		' Token: 0x06005090 RID: 20624 RVA: 0x00218AF0 File Offset: 0x00216CF0
		Public Function Insert(Index As Integer, Name As String) As Sheet
			Dim xlsheet As XLSheet = Me.Ooo_O__.0..Add(Name)
			Me.Ooo_O__.0..Remove(xlsheet)
			Me.Ooo_O__.0..Insert(Index, xlsheet)
			Return New Sheet(xlsheet)
		End Function

		' Token: 0x06005091 RID: 20625 RVA: 0x00218B2A File Offset: 0x00216D2A
		Public Sub Insert(Index As Integer, Sheet As Sheet)
			Me.Ooo_O__.0..Insert(Index, Sheet.Ooo_O__.0.)
		End Sub

		' Token: 0x06005092 RID: 20626 RVA: 0x00218B3F File Offset: 0x00216D3F
		Public Sub Clear()
			Me.Ooo_O__.0..Clear()
		End Sub

		' Token: 0x06005093 RID: 20627 RVA: 0x00218B4C File Offset: 0x00216D4C
		Public Sub Remove(Sheet As Sheet)
			Me.Ooo_O__.0..Remove(Sheet.Ooo_O__.0.)
		End Sub

		' Token: 0x06005094 RID: 20628 RVA: 0x00218B5F File Offset: 0x00216D5F
		Public Sub RemoveAt(Index As Integer)
			Me.Ooo_O__.0..RemoveAt(Index)
		End Sub

		' Token: 0x06005095 RID: 20629 RVA: 0x00218B6D File Offset: 0x00216D6D
		Public Sub Remove(Name As String)
			Me.Ooo_O__.0..Remove(Name)
		End Sub

		' Token: 0x06005096 RID: 20630 RVA: 0x00218B7B File Offset: 0x00216D7B
		Public Function GetEnumerator() As IEnumerator(Of Sheet) Implements System.Collections.Generic.IEnumerable(Of Foxtable.XLS.Sheet).GetEnumerator
			Return New b(Me.Ooo_O__.0.)
		End Function

		' Token: 0x06005097 RID: 20631 RVA: 0x00218B88 File Offset: 0x00216D88
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New b(Me.Ooo_O__.0.)
		End Function

		' Token: 0x040021A3 RID: 8611
		Private <<EMPTY_NAME>> As XLSheetCollection
	End Class
End Namespace
