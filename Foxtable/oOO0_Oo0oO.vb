Imports System
Imports System.Collections.Generic

Namespace Foxtable
	' Token: 0x02000274 RID: 628
	Friend Class oOO0_Oo0oO
		Implements IEnumerator(Of o_0OO0_)

		' Token: 0x06001E31 RID: 7729 RVA: 0x000C0A2B File Offset: 0x000BEC2B
		Friend Sub New(A_0 As OOOO)
			Me.o_O00_.00_. = -1
			Me.o_O00_.00_. = False
			Me.o_O00_.00_. = A_0
		End Sub

		' Token: 0x06001E32 RID: 7730 RVA: 0x000C0A48 File Offset: 0x000BEC48
		Friend Function <<EMPTY_NAME>>() As Object Implements System.Collections.IEnumerator.get_Current
			Return Me.o_O00_.00_..OO00o__OOO.o0_.(Me.o_O00_.00_.)
		End Function

		' Token: 0x06001E33 RID: 7731 RVA: 0x000C0A5C File Offset: 0x000BEC5C
		Friend Function <<EMPTY_NAME>>() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.o_O00_.00_. += 1
			Return Me.o_O00_.00_. <= Me.o_O00_.00_..OO00o__OOO.o0_.() - 1
		End Function

		' Token: 0x06001E34 RID: 7732 RVA: 0x000C0A93 File Offset: 0x000BEC93
		Friend Sub <<EMPTY_NAME>>() Implements System.Collections.IEnumerator.Reset
			Me.o_O00_.00_. = -1
		End Sub

		' Token: 0x06001E35 RID: 7733 RVA: 0x000C0A9C File Offset: 0x000BEC9C
		Friend Function <<EMPTY_NAME>>() As o_0OO0_ Implements System.Collections.Generic.IEnumerator(Of Foxtable.o_0OO0_).get_Current
			Return Me.o_O00_.00_..OO00o__OOO.o0_.(Me.o_O00_.00_.)
		End Function

		' Token: 0x06001E36 RID: 7734 RVA: 0x000C0AAF File Offset: 0x000BECAF
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Not Me.o_O00_.00_. Then
			End If
			Me.o_O00_.00_. = True
		End Sub

		' Token: 0x06001E37 RID: 7735 RVA: 0x000C0AC2 File Offset: 0x000BECC2
		Friend Sub <<EMPTY_NAME>>() Implements System.IDisposable.Dispose
			Me.OO00o__OOO.o0_.(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000CA2 RID: 3234
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CA3 RID: 3235
		Private <<EMPTY_NAME>> As OOOO

		' Token: 0x04000CA4 RID: 3236
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
