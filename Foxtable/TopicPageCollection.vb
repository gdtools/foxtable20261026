Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003BD RID: 957
	<oO0oooo("0841")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class TopicPageCollection
		Implements IEnumerable(Of TopicPage)

		' Token: 0x06003D3C RID: 15676 RVA: 0x001AB48C File Offset: 0x001A968C
		Public Sub New(A_0 As C1TopicBar)
			Me.O._oooo0__. = A_0
			Me.O._oooo0__. = A_0.Pages
		End Sub

		' Token: 0x17000D67 RID: 3431
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As TopicPage
			Get
				Return New TopicPage(Me.O._oooo0__.(Index))
			End Get
		End Property

		' Token: 0x17000D68 RID: 3432
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As TopicPage
			Get
				Try
					For Each obj As Object In Me.O._oooo0__.
						Dim c1TopicPage As C1TopicPage = CType(obj, C1TopicPage)
						If Operators.CompareString(c1TopicPage.Tag.ToString(), Name, True) = 0 Then
							Return New TopicPage(c1TopicPage)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return Nothing
			End Get
		End Property

		' Token: 0x17000D69 RID: 3433
		' (get) Token: 0x06003D3F RID: 15679 RVA: 0x001AB534 File Offset: 0x001A9734
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O._oooo0__..Count
			End Get
		End Property

		' Token: 0x06003D40 RID: 15680 RVA: 0x001AB541 File Offset: 0x001A9741
		Public Sub Clear()
			Me.O._oooo0__..Clear()
		End Sub

		' Token: 0x06003D41 RID: 15681 RVA: 0x001AB54E File Offset: 0x001A974E
		<oO0oooo("0842")>
		Public Function Add(Name As String, Text As String) As TopicPage
			Return Me.Add(Name, Text, "")
		End Function

		' Token: 0x06003D42 RID: 15682 RVA: 0x001AB560 File Offset: 0x001A9760
		<oO0oooo("0842")>
		Public Function Add(Name As String, Text As String, ImageFile As String) As TopicPage
			Dim c1TopicPage As C1TopicPage = New C1TopicPage()
			Dim topicPage As TopicPage = New TopicPage(c1TopicPage)
			Me.O._oooo0__..Add(c1TopicPage)
			topicPage.Text = Text
			topicPage.Name = Name
			topicPage.Image = ImageFile
			Return topicPage
		End Function

		' Token: 0x06003D43 RID: 15683 RVA: 0x001AB59B File Offset: 0x001A979B
		<oO0oooo("0843")>
		Public Function Insert(Name As String, Text As String, Index As Integer) As TopicPage
			Return Me.Insert(Name, Text, "", Index)
		End Function

		' Token: 0x06003D44 RID: 15684 RVA: 0x001AB5AC File Offset: 0x001A97AC
		<oO0oooo("0843")>
		Public Function Insert(Name As String, Text As String, ImageFile As String, Index As Integer) As TopicPage
			Dim c1TopicPage As C1TopicPage = New C1TopicPage()
			Dim topicPage As TopicPage = New TopicPage(c1TopicPage)
			Me.O._oooo0__..Insert(Index, c1TopicPage)
			topicPage.Text = Text
			topicPage.Name = Name
			topicPage.Image = ImageFile
			Return topicPage
		End Function

		' Token: 0x06003D45 RID: 15685 RVA: 0x001AB5E8 File Offset: 0x001A97E8
		<oO0oooo("0845")>
		Public Sub RemoveAt(Index As Integer)
			Me.O._oooo0__..RemoveAt(Index)
		End Sub

		' Token: 0x06003D46 RID: 15686 RVA: 0x001AB5F6 File Offset: 0x001A97F6
		<oO0oooo("0844")>
		Public Sub Remove(Page As TopicPage)
			Me.O._oooo0__..Remove(Page.BasePage)
		End Sub

		' Token: 0x06003D47 RID: 15687 RVA: 0x001AB609 File Offset: 0x001A9809
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of TopicPage) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.TopicPage).GetEnumerator
			Return New OO___(Me.O._oooo0__.)
		End Function

		' Token: 0x06003D48 RID: 15688 RVA: 0x001AB616 File Offset: 0x001A9816
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New OO___(Me.O._oooo0__.)
		End Function

		' Token: 0x0400190C RID: 6412
		Private <<EMPTY_NAME>> As C1TopicPageCollection

		' Token: 0x0400190D RID: 6413
		Private <<EMPTY_NAME>> As C1TopicBar
	End Class
End Namespace
