Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004DC RID: 1244
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class a
		Implements IEnumerator(Of Col)

		' Token: 0x0600500B RID: 20491 RVA: 0x00217FC4 File Offset: 0x002161C4
		Public Sub New(A_0 As XLColumnCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Cols = A_0
		End Sub

		' Token: 0x0600500C RID: 20492 RVA: 0x00217FE1 File Offset: 0x002161E1
		Public Function get_Current() As Col Implements System.Collections.Generic.IEnumerator(Of Foxtable.XLS.Col).get_Current
			Return New Col(Me.Cols(Me.Index))
		End Function

		' Token: 0x0600500D RID: 20493 RVA: 0x00217FF9 File Offset: 0x002161F9
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Col(Me.Cols(Me.Index))
		End Function

		' Token: 0x0600500E RID: 20494 RVA: 0x00218014 File Offset: 0x00216214
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Cols.Count
		End Function

		' Token: 0x0600500F RID: 20495 RVA: 0x00218049 File Offset: 0x00216249
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x06005010 RID: 20496 RVA: 0x00218052 File Offset: 0x00216252
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06005011 RID: 20497 RVA: 0x00218065 File Offset: 0x00216265
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04002179 RID: 8569
		Private Cols As XLColumnCollection

		' Token: 0x0400217A RID: 8570
		Private Index As Integer

		' Token: 0x0400217B RID: 8571
		Private disposedValue As Boolean
	End Class
End Namespace
