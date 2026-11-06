Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003BC RID: 956
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OoOoOO0O_O_o
		Implements IEnumerator(Of TopicLink)

		' Token: 0x06003D35 RID: 15669 RVA: 0x001AB3DC File Offset: 0x001A95DC
		Public Sub New(A_0 As C1TopicLinkCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Links = A_0
		End Sub

		' Token: 0x06003D36 RID: 15670 RVA: 0x001AB3F9 File Offset: 0x001A95F9
		Public Function get_Current() As TopicLink Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.TopicLink).get_Current
			Return New TopicLink(Me.Links(Me.Index))
		End Function

		' Token: 0x06003D37 RID: 15671 RVA: 0x001AB411 File Offset: 0x001A9611
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New TopicLink(Me.Links(Me.Index))
		End Function

		' Token: 0x06003D38 RID: 15672 RVA: 0x001AB42C File Offset: 0x001A962C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Links.Count
		End Function

		' Token: 0x06003D39 RID: 15673 RVA: 0x001AB461 File Offset: 0x001A9661
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06003D3A RID: 15674 RVA: 0x001AB46A File Offset: 0x001A966A
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06003D3B RID: 15675 RVA: 0x001AB47D File Offset: 0x001A967D
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04001909 RID: 6409
		Private Links As C1TopicLinkCollection

		' Token: 0x0400190A RID: 6410
		Private Index As Integer

		' Token: 0x0400190B RID: 6411
		Private disposedValue As Boolean
	End Class
End Namespace
