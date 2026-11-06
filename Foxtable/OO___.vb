Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003BF RID: 959
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OO___
		Implements IEnumerator(Of TopicPage)

		' Token: 0x06003D5A RID: 15706 RVA: 0x001AB825 File Offset: 0x001A9A25
		Public Sub New(A_0 As C1TopicPageCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Pages = A_0
		End Sub

		' Token: 0x06003D5B RID: 15707 RVA: 0x001AB842 File Offset: 0x001A9A42
		Public Function get_Current() As TopicPage Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.TopicPage).get_Current
			Return New TopicPage(Me.Pages(Me.Index))
		End Function

		' Token: 0x06003D5C RID: 15708 RVA: 0x001AB85A File Offset: 0x001A9A5A
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New TopicPage(Me.Pages(Me.Index))
		End Function

		' Token: 0x06003D5D RID: 15709 RVA: 0x001AB874 File Offset: 0x001A9A74
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Pages.Count
		End Function

		' Token: 0x06003D5E RID: 15710 RVA: 0x001AB8A9 File Offset: 0x001A9AA9
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06003D5F RID: 15711 RVA: 0x001AB8B2 File Offset: 0x001A9AB2
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003D60 RID: 15712 RVA: 0x001AB8C5 File Offset: 0x001A9AC5
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04001910 RID: 6416
		Private Pages As C1TopicPageCollection

		' Token: 0x04001911 RID: 6417
		Private Index As Integer

		' Token: 0x04001912 RID: 6418
		Private disposedValue As Boolean
	End Class
End Namespace
