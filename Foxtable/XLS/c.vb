Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E6 RID: 1254
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class c
		Implements IEnumerator(Of Row)

		' Token: 0x06005067 RID: 20583 RVA: 0x002187EE File Offset: 0x002169EE
		Public Sub New(A_0 As XLRowCollection)
			Me.Index = -1
			Me.disposedValue = False
			Me.Rows = A_0
		End Sub

		' Token: 0x06005068 RID: 20584 RVA: 0x0021880B File Offset: 0x00216A0B
		Public Function get_Current() As Row Implements System.Collections.Generic.IEnumerator(Of Foxtable.XLS.Row).get_Current
			Return New Row(Me.Rows(Me.Index))
		End Function

		' Token: 0x06005069 RID: 20585 RVA: 0x00218823 File Offset: 0x00216A23
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Row(Me.Rows(Me.Index))
		End Function

		' Token: 0x0600506A RID: 20586 RVA: 0x0021883C File Offset: 0x00216A3C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Index += 1
			Return Me.Index < Me.Rows.Count
		End Function

		' Token: 0x0600506B RID: 20587 RVA: 0x00218871 File Offset: 0x00216A71
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.Index = -1
		End Sub

		' Token: 0x0600506C RID: 20588 RVA: 0x0021887A File Offset: 0x00216A7A
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x0600506D RID: 20589 RVA: 0x0021888D File Offset: 0x00216A8D
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x0400219C RID: 8604
		Private Rows As XLRowCollection

		' Token: 0x0400219D RID: 8605
		Private Index As Integer

		' Token: 0x0400219E RID: 8606
		Private disposedValue As Boolean
	End Class
End Namespace
