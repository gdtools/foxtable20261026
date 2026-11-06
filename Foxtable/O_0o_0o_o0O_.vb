Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000309 RID: 777
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O_0o_0o_o0O_
		Implements IEnumerator(Of Row)

		' Token: 0x060028FC RID: 10492 RVA: 0x00113FCA File Offset: 0x001121CA
		Friend Sub New(A_0 As Table)
			Me.index = -1
			Me.disposedValue = False
			Me.Table = A_0
		End Sub

		' Token: 0x060028FD RID: 10493 RVA: 0x00113FE7 File Offset: 0x001121E7
		Public Function get_Current() As Row Implements System.Collections.Generic.IEnumerator(Of Foxtable.Row).get_Current
			Return Me.Table(Me.index, False)
		End Function

		' Token: 0x060028FE RID: 10494 RVA: 0x00113FFB File Offset: 0x001121FB
		Public Function get_Current1() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.Table(Me.index, False)
		End Function

		' Token: 0x060028FF RID: 10495 RVA: 0x00114010 File Offset: 0x00112210
		Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.index += 1
			Return Me.index <= Me.Table.ooO__oo0O.0.(False) - 1
		End Function

		' Token: 0x06002900 RID: 10496 RVA: 0x00114048 File Offset: 0x00112248
		Public Sub Reset() Implements System.Collections.IEnumerator.Reset
			Me.index = -1
		End Sub

		' Token: 0x06002901 RID: 10497 RVA: 0x00114051 File Offset: 0x00112251
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not Me.disposedValue Then
			End If
			Me.disposedValue = True
		End Sub

		' Token: 0x06002902 RID: 10498 RVA: 0x00114064 File Offset: 0x00112264
		Public Sub Dispose() Implements System.IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x040010CF RID: 4303
		Private Table As Table

		' Token: 0x040010D0 RID: 4304
		Private index As Integer

		' Token: 0x040010D1 RID: 4305
		Private disposedValue As Boolean
	End Class
End Namespace
