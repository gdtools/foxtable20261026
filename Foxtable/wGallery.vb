Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001FC RID: 508
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0087")>
	Public Class wGallery
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001849 RID: 6217 RVA: 0x0009EC34 File Offset: 0x0009CE34
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean, A_3 As Boolean)
			MyBase.New(A_0, A_1)
			Me.o.O___oOOOOoo. = New List(Of String)()
			Me.o.O___oOOOOoo. = A_2
			Me.O0_O_o._. = A_3
		End Sub

		' Token: 0x0600184A RID: 6218 RVA: 0x0009EC58 File Offset: 0x0009CE58
		Public Sub AddImage(ParamArray Images As String())
			Me.o.O___oOOOOoo..AddRange(Images)
		End Sub

		' Token: 0x0600184B RID: 6219 RVA: 0x0009EC66 File Offset: 0x0009CE66
		Public Sub AddImage(Images As List(Of String))
			Me.o.O___oOOOOoo..AddRange(Images)
		End Sub

		' Token: 0x17000551 RID: 1361
		' (get) Token: 0x0600184C RID: 6220 RVA: 0x0009EC74 File Offset: 0x0009CE74
		' (set) Token: 0x0600184D RID: 6221 RVA: 0x0009EC7C File Offset: 0x0009CE7C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Delete As Boolean
			Get
				Return Me.O_0.o0o_.
			End Get
			Set(value As Boolean)
				Me.O_0.o0o_. = value
			End Set
		End Property

		' Token: 0x0600184E RID: 6222 RVA: 0x0009EC88 File Offset: 0x0009CE88
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<div id='", MyBase.ID, "' name='", MyBase.ID, "' class='weui-gallery" }))
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Not Me.o.O___oOOOOoo. Then
				A_0.Append(" style='display:none'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Me.O0_O_o._. Then
				A_0.Append(" data-autohide")
			End If
			Dim text As String = " data-images='"
			Try
				For Each str As String In Me.o.O___oOOOOoo.
					text = text + str + "|"
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.Append(text.Trim(New Char() { "|"c }) + "'")
			A_0.AppendLine(">")
			Dim str2 As String = ""
			If Me.o.O___oOOOOoo..Count > 0 Then
				str2 = Me.o.O___oOOOOoo.(0)
			End If
			If Me.O_0.o0o_. Then
				A_0.AppendLine("<span class='weui-gallery__img delete' style='background-image: url(" + str2 + ");'></span>")
			Else
				A_0.AppendLine("<span class='weui-gallery__img' style='background-image: url(" + str2 + ");'></span>")
			End If
			If Me.O_0.o0o_. Then
				A_0.AppendLine("<div class='weui-gallery__opr'>")
				A_0.AppendLine("<a class='weui-gallery__del' href='javascript:; ' data-uid='" + Me.OooO_o0o0O.0_. + "'>")
				A_0.AppendLine("<i class='weui_icon_delete weui-icon_gallery-delete'></i>")
				A_0.AppendLine("</a>")
				A_0.AppendLine("</div>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A24 RID: 2596
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A25 RID: 2597
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A26 RID: 2598
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000A27 RID: 2599
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A28 RID: 2600
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
