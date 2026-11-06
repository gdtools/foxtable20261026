Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020001AB RID: 427
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O0_0oO__oo
		Implements IEnumerator(Of ListViewRow)

		' Token: 0x06001437 RID: 5175 RVA: 0x00080CAB File Offset: 0x0007EEAB
		Public Sub New(A_0 As System.Windows.Forms.ListView.ListViewItemCollection)
			Me.index = -1
			Me.disposedValue = False
			Me.items = A_0
		End Sub

		' Token: 0x06001438 RID: 5176 RVA: 0x00080CC8 File Offset: 0x0007EEC8
		Public Function get_Current() As ListViewRow Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.ListViewRow).get_Current
			Return New ListViewRow(Me.items(Me.index))
		End Function

		' Token: 0x06001439 RID: 5177 RVA: 0x00080CE0 File Offset: 0x0007EEE0
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New ListViewRow(Me.items(Me.index))
		End Function

		' Token: 0x0600143A RID: 5178 RVA: 0x00080CF8 File Offset: 0x0007EEF8
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.index += 1
			Return Me.index <= Me.items.Count - 1
		End Function

		' Token: 0x0600143B RID: 5179 RVA: 0x00080D2F File Offset: 0x0007EF2F
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.index = -1
		End Sub

		' Token: 0x0600143C RID: 5180 RVA: 0x00080D38 File Offset: 0x0007EF38
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x0600143D RID: 5181 RVA: 0x00080D4B File Offset: 0x0007EF4B
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040007D4 RID: 2004
		Private items As System.Windows.Forms.ListView.ListViewItemCollection

		' Token: 0x040007D5 RID: 2005
		Private index As Integer

		' Token: 0x040007D6 RID: 2006
		Private disposedValue As Boolean
	End Class
End Namespace
