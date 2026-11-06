Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic

Namespace Foxtable
	' Token: 0x0200020B RID: 523
	<oO0oooo("A0080")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wDialog
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018AD RID: 6317 RVA: 0x000A0B10 File Offset: 0x0009ED10
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.O___oOO0o.0o. = New List(Of wButton)()
			Me.O___oOO0o.0o. = A_2
			Me.O.o__0. = A_3
		End Sub

		' Token: 0x17000571 RID: 1393
		' (get) Token: 0x060018AE RID: 6318 RVA: 0x000A0B34 File Offset: 0x0009ED34
		' (set) Token: 0x060018AF RID: 6319 RVA: 0x000A0B3C File Offset: 0x0009ED3C
		Public Property Visible As Boolean
			Get
				Return Me.O___oOO0o.0o.
			End Get
			Set(value As Boolean)
				Me.O___oOO0o.0o. = value
			End Set
		End Property

		' Token: 0x060018B0 RID: 6320 RVA: 0x000A0B48 File Offset: 0x0009ED48
		Public Function AddButton(ID As String, Text As String, Optional href As String = "") As wButton
			Dim wButton As wButton = New wButton(MyBase.ID, ID, Text, "button", href)
			wButton.o_oOO_o._oOO. = True
			Me.O___oOO0o.0o..Add(wButton)
			Return wButton
		End Function

		' Token: 0x060018B1 RID: 6321 RVA: 0x000A0B80 File Offset: 0x0009ED80
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.AppendLine(String.Concat(New String() { "<div class='weui_dialog_confirm'", Interaction.IIf(Me.Visible, "", " style='display: none;'").ToString(), " id='", MyBase.ID, "' name='", MyBase.ID, "'>" }))
			A_0.AppendLine(" <div class='weui_mask'></div>")
			A_0.AppendLine("<div class='weui_dialog'>")
			A_0.AppendLine("<div class='weui_dialog_hd'>")
			A_0.AppendLine("<strong class='weui_dialog_title'>" + Me.O___oOO0o.0o. + "</strong>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("<div class='weui_dialog_bd'>" + Me.O.o__0. + "</div>")
			A_0.AppendLine("<div class='weui_dialog_ft'>")
			Try
				For Each wButton As wButton In Me.O___oOO0o.0o.
					wButton.o.oOo_oo0__O0_.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wButton).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A58 RID: 2648
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A59 RID: 2649
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A5A RID: 2650
		Private <<EMPTY_NAME>> As List(Of wButton)

		' Token: 0x04000A5B RID: 2651
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
