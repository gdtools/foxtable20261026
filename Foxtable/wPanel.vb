Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000215 RID: 533
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0078")>
	Public Class wPanel
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018F3 RID: 6387 RVA: 0x000A1F21 File Offset: 0x000A0121
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String)
			MyBase.New(A_0, A_1)
			Me.Oo.0_O___0. = New List(Of String)()
			Me.ooO_0o0.OooOO. = A_2
			Me.O0_OOooo.0O0O. = A_3
			Me.Oo.0_O___0. = A_4
			Me.O_00O0.00. = A_5
		End Sub

		' Token: 0x17000582 RID: 1410
		' (get) Token: 0x060018F4 RID: 6388 RVA: 0x000A1F55 File Offset: 0x000A0155
		' (set) Token: 0x060018F5 RID: 6389 RVA: 0x000A1F5D File Offset: 0x000A015D
		<oO0oooo("A0142")>
		Public Property badge As String
			Get
				Return Me.o.0OOoo.
			End Get
			Set(value As String)
				Me.o.0OOoo. = value
			End Set
		End Property

		' Token: 0x17000583 RID: 1411
		' (get) Token: 0x060018F6 RID: 6390 RVA: 0x000A1F68 File Offset: 0x000A0168
		Private ReadOnly Property BaseClass As String
			Get
				Dim result As String
				If Operators.CompareString(Me.Oo.0_O___0., "", True) > 0 OrElse Operators.CompareString(Me.O_00O0.00., "", True) > 0 Then
					result = "weui_media_box weui_media_text weui_media_appmsg"
				Else
					result = "weui_media_box weui_media_text"
				End If
				Return result
			End Get
		End Property

		' Token: 0x060018F7 RID: 6391 RVA: 0x000A1FAC File Offset: 0x000A01AC
		Public Sub AddFoot(text As String, Optional link As String = "")
			Me.Oo.0_O___0..Add(text + vbTab + link)
		End Sub

		' Token: 0x060018F8 RID: 6392 RVA: 0x000A1FC8 File Offset: 0x000A01C8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = Interaction.IIf(Operators.CompareString(Me.O_00O0.00., "", True) > 0, "<a", "<div").ToString()
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Operators.CompareString(Me.O_00O0.00., "", True) > 0 Then
				text = text + " href='" + Me.O_00O0.00. + "'"
			End If
			text += ">"
			A_0.AppendLine(text)
			If Operators.CompareString(Me.Oo.0_O___0., "", True) > 0 Then
				A_0.AppendLine(" <div class='weui_media_hd'>")
				A_0.AppendLine("<img class='weui_media_appmsg_thumb' src='" + Me.Oo.0_O___0. + "'/>")
				A_0.AppendLine("</div>")
			End If
			A_0.AppendLine("<div class='weui_media_bd'>")
			If Operators.CompareString(Me.badge, "", True) > 0 Then
				If Operators.CompareString(Me.badge.Trim(), "", True) = 0 Then
					A_0.AppendLine("<h4 class='weui_media_title'>" + Me.ooO_0o0.OooOO. + "<span class='weui-badge weui-badge_dot'></span></h4>")
				Else
					A_0.AppendLine(String.Concat(New String() { "<h4 class='weui_media_title'>", Me.ooO_0o0.OooOO., "<span class='weui-badge'>", Me.badge, "</span></h4>" }))
				End If
			Else
				A_0.AppendLine("<h4 class='weui_media_title'>" + Me.ooO_0o0.OooOO. + "</h4>")
			End If
			A_0.AppendLine("<p class='weui_media_desc'>" + Me.O0_OOooo.0O0O. + "</p>")
			If Me.Oo.0_O___0..Count > 0 Then
				A_0.AppendLine(" <ul class='weui_media_info'>")
				Try
					For Each text2 As String In Me.Oo.0_O___0.
						Dim array As String() = text2.Split(New Char() { vbTab })
						Dim text3 As String
						If array(0).StartsWith("|") Then
							text3 = "<li class='weui_media_info_meta weui_media_info_meta_extra'>"
							array(0) = array(0).Trim(New Char() { "|"c })
						Else
							text3 = "<li class='weui_media_info_meta'>"
						End If
						If Operators.CompareString(array(1), "", True) > 0 Then
							text3 = String.Concat(New String() { text3, "<a href='", array(1), "'>", array(0), "</a></li>" })
						Else
							text3 = text3 + array(0) + "</li>"
						End If
						A_0.AppendLine(text3)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</ul>")
			End If
			A_0.AppendLine("</div>")
			If Operators.CompareString(Me.O_00O0.00., "", True) = 0 Then
				A_0.AppendLine("</div>")
				Return
			End If
			A_0.AppendLine("</a>")
		End Sub

		' Token: 0x04000A78 RID: 2680
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A79 RID: 2681
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A7A RID: 2682
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A7B RID: 2683
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A7C RID: 2684
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A7D RID: 2685
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
