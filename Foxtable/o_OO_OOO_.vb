Imports System
Imports System.Collections.Generic

Namespace Foxtable
	' Token: 0x02000277 RID: 631
	Friend Class o_OO_OOO_
		Implements IEnumerator(Of O_0O_)

		' Token: 0x06001E47 RID: 7751 RVA: 0x000C0E6A File Offset: 0x000BF06A
		Friend Sub New(A_0 As oOo_)
			Me.O0o00_0__.___0. = -1
			Me.O0o00_0__.___0. = False
			Me.O0o00_0__.___0. = A_0
		End Sub

		' Token: 0x06001E48 RID: 7752 RVA: 0x000C0E87 File Offset: 0x000BF087
		Friend Function <<EMPTY_NAME>>() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.O0o00_0__.___0..O.0_O.(Me.O0o00_0__.___0.)
		End Function

		' Token: 0x06001E49 RID: 7753 RVA: 0x000C0E9C File Offset: 0x000BF09C
		Friend Function <<EMPTY_NAME>>() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.O0o00_0__.___0. += 1
			Return Me.O0o00_0__.___0. <= Me.O0o00_0__.___0..O.0_O.() - 1
		End Function

		' Token: 0x06001E4A RID: 7754 RVA: 0x000C0ED3 File Offset: 0x000BF0D3
		Friend Sub <<EMPTY_NAME>>() Implements System.Collections.IEnumerator.Reset
			Me.O0o00_0__.___0. = -1
		End Sub

		' Token: 0x06001E4B RID: 7755 RVA: 0x000C0EDC File Offset: 0x000BF0DC
		Friend Function <<EMPTY_NAME>>() As O_0O_ Implements System.Collections.Generic.IEnumerator(Of Foxtable.O_0O_).get_Current
			Return Me.O0o00_0__.___0..O.0_O.(Me.O0o00_0__.___0.)
		End Function

		' Token: 0x06001E4C RID: 7756 RVA: 0x000C0EEF File Offset: 0x000BF0EF
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Not Me.O0o00_0__.___0. Then
			End If
			Me.O0o00_0__.___0. = True
		End Sub

		' Token: 0x06001E4D RID: 7757 RVA: 0x000C0F02 File Offset: 0x000BF102
		Friend Sub <<EMPTY_NAME>>() Implements System.IDisposable.Dispose
			Me.O.0_O.(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000CA8 RID: 3240
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CA9 RID: 3241
		Private <<EMPTY_NAME>> As oOo_

		' Token: 0x04000CAA RID: 3242
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
