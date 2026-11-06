Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000218 RID: 536
	<oO0oooo("A0098")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wProgress
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001905 RID: 6405 RVA: 0x000A2938 File Offset: 0x000A0B38
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean, A_3 As Integer)
			MyBase.New(A_0, A_1)
			Me.O0.0O0OooO0. = A_2
			Me.O0.0O0OooO0. = A_3
		End Sub

		' Token: 0x17000587 RID: 1415
		' (get) Token: 0x06001906 RID: 6406 RVA: 0x000A2951 File Offset: 0x000A0B51
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_progress"
			End Get
		End Property

		' Token: 0x17000588 RID: 1416
		' (get) Token: 0x06001907 RID: 6407 RVA: 0x000A2958 File Offset: 0x000A0B58
		' (set) Token: 0x06001908 RID: 6408 RVA: 0x000A2960 File Offset: 0x000A0B60
		Public Property CancelCommand As String
			Get
				Return Me.O0.0O0OooO0.
			End Get
			Set(value As String)
				Me.O0.0O0OooO0. = value
			End Set
		End Property

		' Token: 0x06001909 RID: 6409 RVA: 0x000A296C File Offset: 0x000A0B6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append("<div")
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				A_0.Append(" class='" + Me.BaseClass + "'")
			Else
				A_0.Append(String.Concat(New String() { " class='", Me.BaseClass, " ", MyBase.[Class], "'" }))
			End If
			A_0.Append(String.Concat(New String() { " name='", MyBase.ID, "' id='", MyBase.ID, "'" }))
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Not Me.O0.0O0OooO0. Then
				A_0.Append(" style='display: none;'")
			End If
			A_0.AppendLine(">")
			A_0.Append(" <div class='weui_progress_bar'>")
			A_0.AppendLine("<div class='weui_progress_inner_bar' style='width:" + Conversions.ToString(Me.O0.0O0OooO0.) + "%;'></div>")
			A_0.AppendLine("</div>")
			If Operators.CompareString(Me.O0.0O0OooO0., "", True) > 0 Then
				A_0.AppendLine("<a href='javascript:;' class='weui_progress_opr'" + Me.O0.0O0OooO0. + ">")
				A_0.AppendLine("<i class='weui_icon_cancel'></i>")
				A_0.Append("</a>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A86 RID: 2694
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A87 RID: 2695
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A88 RID: 2696
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
