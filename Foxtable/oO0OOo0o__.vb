Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000292 RID: 658
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oO0OOo0o__
		Implements IEnumerator(Of Connection)

		' Token: 0x0600203D RID: 8253 RVA: 0x000D6BE8 File Offset: 0x000D4DE8
		Public Sub New()
			Me.index = -1
			Me.disposedValue = False
		End Sub

		' Token: 0x0600203E RID: 8254 RVA: 0x000D6BFE File Offset: 0x000D4DFE
		Public Function get_Current() As Connection Implements System.Collections.Generic.IEnumerator(Of Foxtable.Connection).get_Current
			Return OO_00oOO.Connections(Me.index)
		End Function

		' Token: 0x0600203F RID: 8255 RVA: 0x000D6C15 File Offset: 0x000D4E15
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return OO_00oOO.Connections(Me.index)
		End Function

		' Token: 0x06002040 RID: 8256 RVA: 0x000D6C2C File Offset: 0x000D4E2C
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.index += 1
			Return Me.index < OO_00oOO.Connections.Count
		End Function

		' Token: 0x06002041 RID: 8257 RVA: 0x000D6C4E File Offset: 0x000D4E4E
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.index = -1
		End Sub

		' Token: 0x06002042 RID: 8258 RVA: 0x000D6C57 File Offset: 0x000D4E57
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06002043 RID: 8259 RVA: 0x000D6C6A File Offset: 0x000D4E6A
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000D56 RID: 3414
		Private index As Integer

		' Token: 0x04000D57 RID: 3415
		Private disposedValue As Boolean
	End Class
End Namespace
