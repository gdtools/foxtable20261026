Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000200 RID: 512
	<oO0oooo("A0084")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wActionMenu
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600185A RID: 6234 RVA: 0x0009F0EC File Offset: 0x0009D2EC
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As Boolean)
			MyBase.New(A_0, A_1)
			Me.OO0.__ooO_. = True
			Me.oO.0oO0. = A_2
			Me.oO0._o___O. = A_3
			Me.OO.o_0oOoo0. = A_4
		End Sub

		' Token: 0x17000556 RID: 1366
		' (get) Token: 0x0600185B RID: 6235 RVA: 0x0009F114 File Offset: 0x0009D314
		' (set) Token: 0x0600185C RID: 6236 RVA: 0x0009F11C File Offset: 0x0009D31C
		Public Property Visible As Boolean
			Get
				Return Me.OO0.__ooO_.
			End Get
			Set(value As Boolean)
				Me.OO0.__ooO_. = value
			End Set
		End Property

		' Token: 0x0600185D RID: 6237 RVA: 0x0009F128 File Offset: 0x0009D328
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Me.OO.o_0oOoo0. Then
				A_0.AppendLine("</div>")
				A_0.AppendLine("<div class='weui_actionsheet_action'>")
			End If
			A_0.Append(String.Concat(New String() { "<div id='", MyBase.ID, "' name='", MyBase.ID, "' class='weui_actionsheet_cell" }))
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Not Me.Visible Then
				A_0.Append(" style='display:none;'")
			End If
			A_0.Append(">")
			If Operators.CompareString(Me.oO0._o___O., "", True) > 0 Then
				A_0.Append("<a href='" + Me.oO0._o___O. + "'>")
			End If
			A_0.Append(Me.oO.0oO0.)
			If Operators.CompareString(Me.oO0._o___O., "", True) > 0 Then
				A_0.Append("</a>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A31 RID: 2609
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A32 RID: 2610
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A33 RID: 2611
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A34 RID: 2612
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
