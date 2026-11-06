Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020001A4 RID: 420
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O0o
		Implements IEnumerator(Of ListViewColumn)

		' Token: 0x060013D5 RID: 5077 RVA: 0x00080069 File Offset: 0x0007E269
		Public Sub New(A_0 As System.Windows.Forms.ListView.ColumnHeaderCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Columns = A_0
		End Sub

		' Token: 0x060013D6 RID: 5078 RVA: 0x00080086 File Offset: 0x0007E286
		Public Function get_Current() As ListViewColumn Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.ListViewColumn).get_Current
			Return New ListViewColumn(Me.Columns(Me.Index))
		End Function

		' Token: 0x060013D7 RID: 5079 RVA: 0x0008009E File Offset: 0x0007E29E
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New ListViewColumn(Me.Columns(Me.Index))
		End Function

		' Token: 0x060013D8 RID: 5080 RVA: 0x000800B8 File Offset: 0x0007E2B8
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index <= Me.Columns.Count - 1
		End Function

		' Token: 0x060013D9 RID: 5081 RVA: 0x000800EF File Offset: 0x0007E2EF
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x060013DA RID: 5082 RVA: 0x000800F8 File Offset: 0x0007E2F8
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x060013DB RID: 5083 RVA: 0x0008010B File Offset: 0x0007E30B
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040007C6 RID: 1990
		Private Columns As System.Windows.Forms.ListView.ColumnHeaderCollection

		' Token: 0x040007C7 RID: 1991
		Private Index As Integer

		' Token: 0x040007C8 RID: 1992
		Private disposedValue As Boolean
	End Class
End Namespace
