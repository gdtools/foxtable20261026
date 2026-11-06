Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000298 RID: 664
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O__
		Implements IEnumerator(Of DataRow)

		' Token: 0x06002164 RID: 8548 RVA: 0x000DD3C6 File Offset: 0x000DB5C6
		Public Sub New(A_0 As DataRow())
			Me._Index = -1
			Me.disposedValue = False
			Me._Rows = A_0
		End Sub

		' Token: 0x06002165 RID: 8549 RVA: 0x000DD3E3 File Offset: 0x000DB5E3
		Public Function get_Current() As DataRow Implements System.Collections.Generic.IEnumerator(Of Foxtable.DataRow).get_Current
			Return New DataRow(Me._Rows(Me._Index))
		End Function

		' Token: 0x06002166 RID: 8550 RVA: 0x000DD3F7 File Offset: 0x000DB5F7
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return New DataRow(Me._Rows(Me._Index))
		End Function

		' Token: 0x06002167 RID: 8551 RVA: 0x000DD40C File Offset: 0x000DB60C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me._Index += 1
			Return Me._Index < Me._Rows.Length
		End Function

		' Token: 0x06002168 RID: 8552 RVA: 0x000DD43E File Offset: 0x000DB63E
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me._Index = -1
		End Sub

		' Token: 0x06002169 RID: 8553 RVA: 0x000DD447 File Offset: 0x000DB647
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x0600216A RID: 8554 RVA: 0x000DD45A File Offset: 0x000DB65A
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000DC2 RID: 3522
		Private _Rows As DataRow()

		' Token: 0x04000DC3 RID: 3523
		Private _Index As Integer

		' Token: 0x04000DC4 RID: 3524
		Private disposedValue As Boolean
	End Class
End Namespace
