Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000205 RID: 517
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wGridCell
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001880 RID: 6272 RVA: 0x0009FE7C File Offset: 0x0009E07C
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String)
			MyBase.New(A_0, A_1)
			Me.OooO_o0o0O.0_. = A_2
			Me.oOo.Oo_00O. = A_3
			Me.O0.O_oO0. = A_4
		End Sub

		' Token: 0x06001881 RID: 6273 RVA: 0x0009FEA0 File Offset: 0x0009E0A0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.O0.O_oO0., "", True) > 0 Then
				A_0.Append(" <a href='" + Me.O0.O_oO0. + "'")
			Else
				A_0.Append(" <a")
			End If
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				A_0.Append(" class='weui_grid'")
			Else
				A_0.Append(" class='weui_grid " + MyBase.[Class] + "'")
			End If
			A_0.Append(String.Concat(New String() { " id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.AppendLine(">")
			A_0.AppendLine("<div class='weui_grid_icon'>")
			A_0.AppendLine(" <i class='fox_grid_icon' style='background-image:url(" + Me.oOo.Oo_00O. + ")'></i>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("<p class='weui_grid_label'>" + Me.OooO_o0o0O.0_. + "</p>")
			A_0.AppendLine("</a>")
		End Sub

		' Token: 0x04000A46 RID: 2630
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A47 RID: 2631
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A48 RID: 2632
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
