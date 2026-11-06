Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000171 RID: 369
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OoO00OooO_
		Implements IEnumerator(Of Strip)

		' Token: 0x06001126 RID: 4390 RVA: 0x0006B73D File Offset: 0x0006993D
		Public Sub New(A_0 As List(Of ToolStrip), A_1 As Foxtable.WinForm.Form)
			Me.O._0o0O_oo_o. = -1
			Me.O._0o0O_oo_o. = False
			Me.O._0o0O_oo_o. = A_0
			Me.O._0o0O_oo_o. = A_1
		End Sub

		' Token: 0x06001127 RID: 4391 RVA: 0x0006B761 File Offset: 0x00069961
		Public Function <<EMPTY_NAME>>() As Strip Implements System.Collections.Generic.IEnumerator(Of Foxtable.WinForm.Strip).get_Current
			Return New Strip(Me.O._0o0O_oo_o.(Me.O._0o0O_oo_o.), Me.O._0o0O_oo_o.)
		End Function

		' Token: 0x06001128 RID: 4392 RVA: 0x0006B77F File Offset: 0x0006997F
		Public Function <<EMPTY_NAME>>() As Object Implements System.Collections.IEnumerator.get_Current
			Return New Strip(Me.O._0o0O_oo_o.(Me.O._0o0O_oo_o.), Me.O._0o0O_oo_o.)
		End Function

		' Token: 0x06001129 RID: 4393 RVA: 0x0006B7A0 File Offset: 0x000699A0
		Public Function <<EMPTY_NAME>>() As Boolean Implements System.Collections.IEnumerator.MoveNext
			Me.O._0o0O_oo_o. += 1
			Return Me.O._0o0O_oo_o. < Me.O._0o0O_oo_o..Count
		End Function

		' Token: 0x0600112A RID: 4394 RVA: 0x0006B7D5 File Offset: 0x000699D5
		Public Sub <<EMPTY_NAME>>() Implements System.Collections.IEnumerator.Reset
			Me.O._0o0O_oo_o. = -1
		End Sub

		' Token: 0x0600112B RID: 4395 RVA: 0x0006B7DE File Offset: 0x000699DE
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Not Me.O._0o0O_oo_o. Then
			End If
			Me.O._0o0O_oo_o. = True
		End Sub

		' Token: 0x0600112C RID: 4396 RVA: 0x0006B7F1 File Offset: 0x000699F1
		Public Sub <<EMPTY_NAME>>() Implements System.IDisposable.Dispose
			Me.O._0o0O_oo_o.(True)
			GC.SuppressFinalize(Me)
		End Sub

		' Token: 0x04000684 RID: 1668
		Private <<EMPTY_NAME>> As List(Of ToolStrip)

		' Token: 0x04000685 RID: 1669
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000686 RID: 1670
		Friend <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x04000687 RID: 1671
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
