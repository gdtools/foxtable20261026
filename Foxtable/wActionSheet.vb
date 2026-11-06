Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000201 RID: 513
	<oO0oooo("A0084")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wActionSheet
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600185E RID: 6238 RVA: 0x0009F27C File Offset: 0x0009D47C
		Friend Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.oO.0oO0. = New List(Of wActionMenu)()
		End Sub

		' Token: 0x0600185F RID: 6239 RVA: 0x0009F294 File Offset: 0x0009D494
		Public Function Add(id As String, text As String, Optional href As String = "", Optional separator As Boolean = False) As wActionMenu
			Dim wActionMenu As wActionMenu = New wActionMenu(MyBase.ID, id, text, href, separator)
			Me.oO.0oO0..Add(wActionMenu)
			Return wActionMenu
		End Function

		' Token: 0x06001860 RID: 6240 RVA: 0x0009F2C0 File Offset: 0x0009D4C0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<div  id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" class='fox_actionsheet" + MyBase.[Class] + "'")
			Else
				A_0.Append(" class='fox_actionsheet'")
			End If
			A_0.AppendLine(">")
			A_0.AppendLine("<div class='weui_mask_transition fox_mask_transition' style='display:none' id='" + MyBase.ID + "_mask'></div>")
			A_0.AppendLine("<div class='weui_actionsheet' id='" + MyBase.ID + "_sheet'>")
			A_0.AppendLine("<div class='weui_actionsheet_menu'>")
			Try
				For Each wActionMenu As wActionMenu In Me.oO.0oO0.
					wActionMenu.OO.o_0oOoo0.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wActionMenu).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A35 RID: 2613
		Private <<EMPTY_NAME>> As List(Of wActionMenu)
	End Class
End Namespace
