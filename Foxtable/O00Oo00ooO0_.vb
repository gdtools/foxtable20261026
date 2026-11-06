Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000174 RID: 372
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O00Oo00ooO0_
		Implements IEnumerator(Of StripItem)

		' Token: 0x06001158 RID: 4440 RVA: 0x0006BF2D File Offset: 0x0006A12D
		Public Sub New(A_0 As ToolStripItemCollection, A_1 As Foxtable.WinForm.Form)
			Me.Ooo0.o. = -1
			Me.Ooo0.o. = False
			Me.Ooo0.o. = A_0
			Me.Ooo0.o. = A_1
		End Sub

		' Token: 0x06001159 RID: 4441 RVA: 0x0006BF51 File Offset: 0x0006A151
		Public Function <<EMPTY_NAME>>() As StripItem Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.StripItem).get_Current
			Return New StripItem(Me.Ooo0.o.(Me.Ooo0.o.), Me.Ooo0.o.)
		End Function

		' Token: 0x0600115A RID: 4442 RVA: 0x0006BF6F File Offset: 0x0006A16F
		Public Function <<EMPTY_NAME>>() As Object Implements System.Collections.IEnumerator.get_Current
			Return New StripItem(Me.Ooo0.o.(Me.Ooo0.o.), Me.Ooo0.o.)
		End Function

		' Token: 0x0600115B RID: 4443 RVA: 0x0006BF90 File Offset: 0x0006A190
		Public Function <<EMPTY_NAME>>() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.Ooo0.o. += 1
			Return Me.Ooo0.o. < Me.Ooo0.o..Count
		End Function

		' Token: 0x0600115C RID: 4444 RVA: 0x0006BFC5 File Offset: 0x0006A1C5
		Public Sub <<EMPTY_NAME>>() Implements System.Collections.IEnumerator.Reset
			Me.Ooo0.o. = -1
		End Sub

		' Token: 0x0600115D RID: 4445 RVA: 0x0006BFCE File Offset: 0x0006A1CE
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Not Me.Ooo0.o. Then
			End If
			Me.Ooo0.o. = True
		End Sub

		' Token: 0x0600115E RID: 4446 RVA: 0x0006BFE1 File Offset: 0x0006A1E1
		Public Sub <<EMPTY_NAME>>() Implements System.IDisposable.Dispose
			Me.OOOOO.Oo_Oo.(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x0400068C RID: 1676
		Private <<EMPTY_NAME>> As ToolStripItemCollection

		' Token: 0x0400068D RID: 1677
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400068E RID: 1678
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x0400068F RID: 1679
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
