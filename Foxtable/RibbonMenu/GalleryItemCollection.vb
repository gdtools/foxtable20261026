Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002E RID: 46
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("3085")>
	<ComVisible(True)>
	Public Class GalleryItemCollection
		Implements IEnumerable

		' Token: 0x06000164 RID: 356 RVA: 0x00003FDE File Offset: 0x000021DE
		Public Sub New(A_0 As RibbonGalleryItemCollection, A_1 As Boolean)
			Me.OO0oOo.O_o0. = A_0
			Me.OO0oOo.O_o0. = A_1
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x00003FF4 File Offset: 0x000021F4
		Public Sub Add(Item As GalleryItem)
			Item.OO0oOo.O_o0..VerticalLayout = Me.OO0oOo.O_o0.
			Me.OO0oOo.O_o0..Add(Item.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000166 RID: 358 RVA: 0x00004019 File Offset: 0x00002219
		Public Sub Insert(Index As Integer, Item As GalleryItem)
			Me.OO0oOo.O_o0..Insert(Index, Item.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000167 RID: 359 RVA: 0x0000402D File Offset: 0x0000222D
		Public Sub Remove(Name As String)
			Me.OO0oOo.O_o0..Remove(Name)
		End Sub

		' Token: 0x06000168 RID: 360 RVA: 0x0000403B File Offset: 0x0000223B
		Public Sub Remove(Item As GalleryItem)
			Me.OO0oOo.O_o0..Remove(Item.OO0oOo.O_o0.)
		End Sub

		' Token: 0x06000169 RID: 361 RVA: 0x0000404E File Offset: 0x0000224E
		Public Sub RemoveAt(Index As Integer)
			Me.OO0oOo.O_o0..RemoveAt(Index)
		End Sub

		' Token: 0x0600016A RID: 362 RVA: 0x0000405C File Offset: 0x0000225C
		Public Function Contains(Name As String) As Boolean
			Return Me.OO0oOo.O_o0..Contains(Name)
		End Function

		' Token: 0x0600016B RID: 363 RVA: 0x0000406A File Offset: 0x0000226A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Contains(Item As RibbonItem) As Boolean
			Return Me.OO0oOo.O_o0..Contains(Item.oOo_.0o_O_O_0.)
		End Function

		' Token: 0x0600016C RID: 364 RVA: 0x0000407D File Offset: 0x0000227D
		Public Sub Clear()
			Me.OO0oOo.O_o0..Clear()
		End Sub

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x0600016D RID: 365 RVA: 0x0000408A File Offset: 0x0000228A
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OO0oOo.O_o0..Count
			End Get
		End Property

		' Token: 0x170000A6 RID: 166
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As GalleryItem
			Get
				Dim result As GalleryItem
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000A7 RID: 167
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As GalleryItem
			Get
				Dim result As GalleryItem
				If Me.OO0oOo.O_o0..Contains(A_0) Then
					result = New GalleryItem(Me.OO0oOo.O_o0.(A_0))
				Else
					MessageBox.Show("Gallery中不存在名为""" + A_0 + """的项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000A8 RID: 168
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As GalleryItem
			Get
				Dim result As GalleryItem
				If A_0 < 0 Or A_0 > Me.OO0oOo.O_o0..Count - 1 Then
					result = Nothing
				Else
					result = New GalleryItem(CType(Me.OO0oOo.O_o0.(A_0), RibbonGalleryItem))
				End If
				Return result
			End Get
		End Property

		' Token: 0x06000171 RID: 369 RVA: 0x0000415C File Offset: 0x0000235C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New GalleryItemEnumerator(Me)
		End Function

		' Token: 0x0400004C RID: 76
		Private <<EMPTY_NAME>> As RibbonGalleryItemCollection

		' Token: 0x0400004D RID: 77
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
