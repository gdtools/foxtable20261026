Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000212 RID: 530
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0058")>
	Public Class wMsgPage
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018E8 RID: 6376 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.o0oO0_.o00O0. = "success"
			Me.O___0.o_OO. = New List(Of wButton)()
			Me.O___0.o_OO. = New List(Of String)()
			Me.O___0.o_OO. = A_2
			Me.oO0Oo_.o0Oo_0o. = A_3
		End Sub

		' Token: 0x060018E9 RID: 6377 RVA: 0x000A19F0 File Offset: 0x0009FBF0
		Public Function AddButton(ID As String, Text As String, Optional href As String = "") As wButton
			Dim wButton As wButton = New wButton(MyBase.ID, ID, Text, "button", href)
			Me.O___0.o_OO..Add(wButton)
			Return wButton
		End Function

		' Token: 0x060018EA RID: 6378 RVA: 0x000A1A1E File Offset: 0x0009FC1E
		Public Sub AddExtra(text As String, Optional link As String = "")
			Me.O___0.o_OO..Add(text + vbTab + link)
		End Sub

		' Token: 0x17000581 RID: 1409
		' (get) Token: 0x060018EB RID: 6379 RVA: 0x000A1A37 File Offset: 0x0009FC37
		' (set) Token: 0x060018EC RID: 6380 RVA: 0x000A1A3F File Offset: 0x0009FC3F
		Public Property Icon As String
			Get
				Return Me.o0oO0_.o00O0.
			End Get
			Set(value As String)
				Me.o0oO0_.o00O0. = value
			End Set
		End Property

		' Token: 0x060018ED RID: 6381 RVA: 0x000A1A48 File Offset: 0x0009FC48
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHtml(sb As StringBuilder, wui As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim left As String = Me.o0oO0_.o00O0.
			If Operators.CompareString(left, "success", True) = 0 Then
				Me.o0oO0_.o00O0. = "weui_icon_success"
			ElseIf Operators.CompareString(left, "warn", True) = 0 Then
				Me.o0oO0_.o00O0. = "weui_icon_warn"
			ElseIf Operators.CompareString(left, "info", True) = 0 Then
				Me.o0oO0_.o00O0. = "weui_icon_info"
			End If
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				sb.Append("<div class='weui_msg'")
			Else
				sb.Append("<div class='weui_msg " + MyBase.[Class] + "'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				sb.Append(" " + MyBase.Attribute)
			End If
			sb.AppendLine(">")
			If Operators.CompareString(Me.o0oO0_.o00O0., "", True) > 0 Then
				sb.AppendLine("<div class='weui_icon_area'>")
				If Me.o0oO0_.o00O0..StartsWith("weui_icon", StringComparison.CurrentCultureIgnoreCase) Then
					sb.AppendLine("<i class='" + Me.o0oO0_.o00O0. + " weui_icon_msg'></i>")
				Else
					sb.AppendLine("<img class = 'weui_icon_msg' src='" + Me.o0oO0_.o00O0. + "'/>")
				End If
				sb.AppendLine("</div>")
			End If
			sb.AppendLine(" <div class='weui_text_area'>")
			sb.AppendLine("<h2 class='weui_msg_title'>" + Me.O___0.o_OO. + "</h2>")
			sb.AppendLine("<p class='weui_msg_desc'>" + Me.oO0Oo_.o0Oo_0o. + "</p>")
			sb.AppendLine("</div>")
			If Me.O___0.o_OO..Count > 0 Then
				sb.AppendLine(" <div class='weui_opr_area'>")
				sb.AppendLine("<p class='weui_btn_area'>")
				Try
					For Each wButton As wButton In Me.O___0.o_OO.
						wButton.o.oOo_oo0__O0_.(sb, wui)
					Next
				Finally
					Dim enumerator As List(Of wButton).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				sb.AppendLine("</p>")
				sb.AppendLine("</div>")
			End If
			If Me.O___0.o_OO..Count > 0 Then
				sb.AppendLine("<div class='weui_extra_area'>")
				Try
					For Each text As String In Me.O___0.o_OO.
						Dim array As String() = text.Split(New Char() { vbTab })
						sb.AppendLine(String.Concat(New String() { "<a href='", array(1), "'>", array(0), "</a>" }))
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				sb.AppendLine("</div>")
			End If
			sb.AppendLine("</div>")
		End Sub

		' Token: 0x04000A70 RID: 2672
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A71 RID: 2673
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A72 RID: 2674
		Public <<EMPTY_NAME>> As String

		' Token: 0x04000A73 RID: 2675
		Private <<EMPTY_NAME>> As List(Of wButton)

		' Token: 0x04000A74 RID: 2676
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
