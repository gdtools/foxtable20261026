Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000207 RID: 519
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0076")>
	Public Class wListGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600188F RID: 6287 RVA: 0x000A02E5 File Offset: 0x0009E4E5
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O.__00oOO_o0O0. = New List(Of wListIem)()
			Me.O.__00oOO_o0O0. = A_2
		End Sub

		' Token: 0x17000566 RID: 1382
		' (get) Token: 0x06001890 RID: 6288 RVA: 0x000A0304 File Offset: 0x0009E504
		Private ReadOnly Property BaseClass As String
			Get
				Dim result As String
				If Me.Link Then
					result = "weui_cells weui_cells_access"
				Else
					result = "weui_cells"
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000567 RID: 1383
		' (get) Token: 0x06001891 RID: 6289 RVA: 0x000A0328 File Offset: 0x0009E528
		Private ReadOnly Property Link As Boolean
			Get
				Try
					Dim enumerator As List(Of wListIem).Enumerator = Me.O.__00oOO_o0O0..GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current.Href, "", True) > 0 Then
							Return True
						End If
					End While
				Finally
					Dim enumerator As List(Of wListIem).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return False
			End Get
		End Property

		' Token: 0x06001892 RID: 6290 RVA: 0x000A0390 File Offset: 0x0009E590
		Public Function Add(ID As String, Content As String, Optional Description As String = "", Optional href As String = "", Optional image As String = "") As wListIem
			Dim wListIem As wListIem = New wListIem(MyBase.ID, ID, Content, Description, href, image)
			Me.O.__00oOO_o0O0..Add(wListIem)
			Return wListIem
		End Function

		' Token: 0x06001893 RID: 6291 RVA: 0x000A03C0 File Offset: 0x0009E5C0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHtml(sb As StringBuilder, wui As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.O.__00oOO_o0O0., "", True) > 0 Then
				sb.AppendLine("<div class='fox_group'>")
				New wGroupTitle(MyBase.ID, "", Me.O.__00oOO_o0O0.).OooO_o0o0O.0_.(sb, wui)
			End If
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<div class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { "<div class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " id='", MyBase.ID, "' name='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text += ">"
			sb.AppendLine(text)
			Try
				For Each wListIem As wListIem In Me.O.__00oOO_o0O0.
					wListIem.O.__00oOO_o0O0.(sb, wui)
				Next
			Finally
				Dim enumerator As List(Of wListIem).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			sb.AppendLine("</div>")
			If Operators.CompareString(Me.O.__00oOO_o0O0., "", True) > 0 Then
				sb.AppendLine("</div>")
			End If
		End Sub

		' Token: 0x04000A4E RID: 2638
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A4F RID: 2639
		Private <<EMPTY_NAME>> As List(Of wListIem)
	End Class
End Namespace
