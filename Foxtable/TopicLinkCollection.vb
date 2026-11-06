Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003BA RID: 954
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class TopicLinkCollection
		Implements IEnumerable(Of TopicLink)

		' Token: 0x06003D18 RID: 15640 RVA: 0x001AB030 File Offset: 0x001A9230
		Public Sub New(A_0 As C1TopicLinkCollection)
			Me.O._oooo0__. = A_0
		End Sub

		' Token: 0x17000D5C RID: 3420
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As TopicLink
			Get
				Return New TopicLink(Me.O._oooo0__.(Index))
			End Get
		End Property

		' Token: 0x17000D5D RID: 3421
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As TopicLink
			Get
				Try
					For Each obj As Object In Me.O._oooo0__.
						Dim c1TopicLink As C1TopicLink = CType(obj, C1TopicLink)
						If Operators.CompareString(c1TopicLink.Tag.ToString(), Name, True) = 0 Then
							Return New TopicLink(c1TopicLink)
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

		' Token: 0x17000D5E RID: 3422
		' (get) Token: 0x06003D1B RID: 15643 RVA: 0x001AB0CC File Offset: 0x001A92CC
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O._oooo0__..Count
			End Get
		End Property

		' Token: 0x06003D1C RID: 15644 RVA: 0x001AB0D9 File Offset: 0x001A92D9
		Public Sub Clear()
			Me.O._oooo0__..Clear()
		End Sub

		' Token: 0x06003D1D RID: 15645 RVA: 0x001AB0E6 File Offset: 0x001A92E6
		<oO0oooo("0860")>
		Public Function Add(Name As String, Text As String) As TopicLink
			Return Me.Add(Name, Text, "")
		End Function

		' Token: 0x06003D1E RID: 15646 RVA: 0x001AB0F8 File Offset: 0x001A92F8
		<oO0oooo("0860")>
		Public Function Add(Name As String, Text As String, ImageFile As String) As TopicLink
			Dim c1TopicLink As C1TopicLink = New C1TopicLink()
			Dim topicLink As TopicLink = New TopicLink(c1TopicLink)
			Me.O._oooo0__..Add(c1TopicLink)
			topicLink.Text = Text
			topicLink.Name = Name
			topicLink.Image = ImageFile
			Return topicLink
		End Function

		' Token: 0x06003D1F RID: 15647 RVA: 0x001AB133 File Offset: 0x001A9333
		<oO0oooo("0861")>
		Public Function Insert(Name As String, Text As String, Index As Integer) As TopicLink
			Return Me.Insert(Name, Text, "", Index)
		End Function

		' Token: 0x06003D20 RID: 15648 RVA: 0x001AB144 File Offset: 0x001A9344
		<oO0oooo("0861")>
		Public Function Insert(Name As String, Text As String, ImageFile As String, Index As Integer) As TopicLink
			Dim c1TopicLink As C1TopicLink = New C1TopicLink()
			Dim topicLink As TopicLink = New TopicLink(c1TopicLink)
			Me.O._oooo0__..Insert(Index, c1TopicLink)
			topicLink.Text = Text
			topicLink.Name = Name
			topicLink.Image = ImageFile
			Return topicLink
		End Function

		' Token: 0x06003D21 RID: 15649 RVA: 0x001AB180 File Offset: 0x001A9380
		<oO0oooo("0868")>
		Public Sub RemoveAt(Index As Integer)
			Me.O._oooo0__..RemoveAt(Index)
		End Sub

		' Token: 0x06003D22 RID: 15650 RVA: 0x001AB18E File Offset: 0x001A938E
		<oO0oooo("0866")>
		Public Sub Remove(Link As TopicLink)
			Me.O._oooo0__..Remove(Link.BaseLink)
		End Sub

		' Token: 0x06003D23 RID: 15651 RVA: 0x001AB1A1 File Offset: 0x001A93A1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of TopicLink) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.TopicLink).GetEnumerator
			Return New OoOoOO0O_O_o(Me.O._oooo0__.)
		End Function

		' Token: 0x06003D24 RID: 15652 RVA: 0x001AB1AE File Offset: 0x001A93AE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New OoOoOO0O_O_o(Me.O._oooo0__.)
		End Function

		' Token: 0x04001907 RID: 6407
		Private <<EMPTY_NAME>> As C1TopicLinkCollection
	End Class
End Namespace
