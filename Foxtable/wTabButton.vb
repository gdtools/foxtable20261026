Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200021F RID: 543
	<oO0oooo("A0081")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wTabButton
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600193A RID: 6458 RVA: 0x000A3B24 File Offset: 0x000A1D24
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String)
			MyBase.New(A_0, A_1)
			Me.o__O0.oO_oo0. = A_2
			Me.o0OO0.oo0OO. = A_3
			Me.OoOoO0oO0o_.00. = A_4
			Me.OO_.o0O. = A_5
		End Sub

		' Token: 0x0600193B RID: 6459 RVA: 0x000A3B50 File Offset: 0x000A1D50
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.OoOoO0oO0o_.00., "", True) = 0 Then
				A_0.Append(String.Concat(New String() { "<div id='", MyBase.ID, "' name='", MyBase.ID, "' class='weui_navbar_item" }))
				If Me.o0OO0.oo0OO. Then
					A_0.Append(" weui_bar_item_on")
				End If
				If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
					A_0.Append(" " + MyBase.[Class])
				End If
				A_0.Append("'")
				If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
					A_0.Append(" " + MyBase.Attribute)
				End If
				If Operators.CompareString(Me.o0OO0.oo0OO., "", True) > 0 Then
					A_0.Append(" data-tab-page='" + Me.o0OO0.oo0OO. + "'")
					A_0.Append(" data-tab='" + MyBase.PID + "'>")
				Else
					A_0.AppendLine(">")
				End If
				A_0.AppendLine("<p class='weui_tabbar_label'>" + Me.o__O0.oO_oo0. + "</p>")
				A_0.AppendLine("</div>")
				Return
			End If
			If Operators.CompareString(Me.OO_.o0O., "", True) = 0 Then
				Me.OO_.o0O. = "javascript:;"
			End If
			A_0.Append(String.Concat(New String() { "<a  id='", MyBase.ID, "' name='", MyBase.ID, "' href='", Me.OO_.o0O., "' class='weui_tabbar_item" }))
			If Me.o0OO0.oo0OO. Then
				A_0.Append(" weui_bar_item_on")
			End If
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Operators.CompareString(Me.o0OO0.oo0OO., "", True) > 0 Then
				A_0.Append(" data-tab-page='" + Me.o0OO0.oo0OO. + "'")
				A_0.Append(" data-tab='" + MyBase.PID + "'>")
			Else
				A_0.AppendLine(">")
			End If
			A_0.AppendLine("<div class='weui_tabbar_icon'>")
			A_0.AppendLine("<img src='" + Me.OoOoO0oO0o_.00. + "'>")
			A_0.AppendLine(" </div>")
			A_0.AppendLine("<p class='weui_tabbar_label'>" + Me.o__O0.oO_oo0. + "</p>")
			A_0.AppendLine("</a>")
		End Sub

		' Token: 0x04000A9F RID: 2719
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AA0 RID: 2720
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AA1 RID: 2721
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AA2 RID: 2722
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AA3 RID: 2723
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
