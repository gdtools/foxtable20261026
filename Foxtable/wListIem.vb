Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000206 RID: 518
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0076")>
	Public Class wListIem
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001882 RID: 6274 RVA: 0x0009FFF7 File Offset: 0x0009E1F7
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String)
			MyBase.New(A_0, A_1)
			Me.oO0Oo_.o0Oo_0o. = A_2
			Me.o0oO0_.o00O0. = A_3
			Me.O_00o.o_0. = A_4
			Me.O___0.o_OO. = A_5
		End Sub

		' Token: 0x17000560 RID: 1376
		' (get) Token: 0x06001883 RID: 6275 RVA: 0x000A0020 File Offset: 0x0009E220
		' (set) Token: 0x06001884 RID: 6276 RVA: 0x000A0028 File Offset: 0x0009E228
		Public Property Content As String
			Get
				Return Me.oO0Oo_.o0Oo_0o.
			End Get
			Set(value As String)
				Me.oO0Oo_.o0Oo_0o. = value
			End Set
		End Property

		' Token: 0x17000561 RID: 1377
		' (get) Token: 0x06001885 RID: 6277 RVA: 0x000A0031 File Offset: 0x0009E231
		' (set) Token: 0x06001886 RID: 6278 RVA: 0x000A0039 File Offset: 0x0009E239
		Public Property SubContent As String
			Get
				Return Me.o0oO0_.o00O0.
			End Get
			Set(value As String)
				Me.o0oO0_.o00O0. = value
			End Set
		End Property

		' Token: 0x17000562 RID: 1378
		' (get) Token: 0x06001887 RID: 6279 RVA: 0x000A0042 File Offset: 0x0009E242
		' (set) Token: 0x06001888 RID: 6280 RVA: 0x000A004A File Offset: 0x0009E24A
		Public Property Href As String
			Get
				Return Me.O_00o.o_0.
			End Get
			Set(value As String)
				Me.O_00o.o_0. = value
			End Set
		End Property

		' Token: 0x17000563 RID: 1379
		' (get) Token: 0x06001889 RID: 6281 RVA: 0x000A0053 File Offset: 0x0009E253
		' (set) Token: 0x0600188A RID: 6282 RVA: 0x000A005B File Offset: 0x0009E25B
		Public Property Image As String
			Get
				Return Me.O___0.o_OO.
			End Get
			Set(value As String)
				Me.O___0.o_OO. = value
			End Set
		End Property

		' Token: 0x17000564 RID: 1380
		' (get) Token: 0x0600188B RID: 6283 RVA: 0x000A0064 File Offset: 0x0009E264
		' (set) Token: 0x0600188C RID: 6284 RVA: 0x000A006C File Offset: 0x0009E26C
		<oO0oooo("A0141")>
		Public Property badge As String
			Get
				Return Me.o.0oOOo.
			End Get
			Set(value As String)
				Me.o.0oOOo. = value
			End Set
		End Property

		' Token: 0x17000565 RID: 1381
		' (get) Token: 0x0600188D RID: 6285 RVA: 0x000A0075 File Offset: 0x0009E275
		Private ReadOnly Property baseClass As String
			Get
				Return "weui_cell"
			End Get
		End Property

		' Token: 0x0600188E RID: 6286 RVA: 0x000A007C File Offset: 0x0009E27C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = Interaction.IIf(Operators.CompareString(Me.Href, "", True) > 0, "<a", "<div").ToString()
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.baseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.baseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Operators.CompareString(Me.Href, "", True) > 0 Then
				text = text + " href='" + Me.Href + "'"
			End If
			text += ">"
			A_0.AppendLine(text)
			If Operators.CompareString(Me.Image, "", True) > 0 Then
				A_0.AppendLine("<div class='weui_cell_hd'><img src='" + Me.Image + "' style='width:20px;margin-right:5px;display:block'/></div>")
			End If
			If Operators.CompareString(Me.Content, "", True) > 0 Then
				A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
				A_0.AppendLine("<span>" + Me.Content + "</span>")
				If Operators.CompareString(Me.badge, "", True) > 0 Then
					If Operators.CompareString(Me.badge.Trim(), "", True) > 0 Then
						A_0.AppendLine("<span class='weui-badge'>" + Me.badge + "</span>")
					Else
						A_0.AppendLine("<span class='weui-badge weui-badge_dot'></span>")
					End If
				End If
				A_0.AppendLine("</div>")
			End If
			If Operators.CompareString(Me.SubContent, "", True) > 0 Then
				A_0.AppendLine("  <div class='weui_cell_ft'>" + Me.SubContent + "</div>")
			End If
			If Operators.CompareString(Me.Href, "", True) = 0 Then
				A_0.AppendLine("</div>")
				Return
			End If
			A_0.AppendLine("</a>")
		End Sub

		' Token: 0x04000A49 RID: 2633
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A4A RID: 2634
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A4B RID: 2635
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A4C RID: 2636
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A4D RID: 2637
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
