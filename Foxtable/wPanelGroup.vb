Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000216 RID: 534
	<oO0oooo("A0078")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wPanelGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018F9 RID: 6393 RVA: 0x000A2360 File Offset: 0x000A0560
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.OO_00o0O0.0__. = New List(Of wPanel)()
			Me.OO_00o0O0.0__. = A_2
		End Sub

		' Token: 0x17000584 RID: 1412
		' (get) Token: 0x060018FA RID: 6394 RVA: 0x000A237C File Offset: 0x000A057C
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_panel weui_panel_access"
			End Get
		End Property

		' Token: 0x17000585 RID: 1413
		' (get) Token: 0x060018FB RID: 6395 RVA: 0x000A2383 File Offset: 0x000A0583
		' (set) Token: 0x060018FC RID: 6396 RVA: 0x000A238B File Offset: 0x000A058B
		Public Property GroupFoot As String
			Get
				Return Me.oOooOO_0OO.o_.
			End Get
			Set(value As String)
				Me.oOooOO_0OO.o_. = value
			End Set
		End Property

		' Token: 0x17000586 RID: 1414
		' (get) Token: 0x060018FD RID: 6397 RVA: 0x000A2394 File Offset: 0x000A0594
		' (set) Token: 0x060018FE RID: 6398 RVA: 0x000A239C File Offset: 0x000A059C
		Public Property GroupHref As String
			Get
				Return Me.o0o0._OOO_0.
			End Get
			Set(value As String)
				Me.o0o0._OOO_0. = value
			End Set
		End Property

		' Token: 0x060018FF RID: 6399 RVA: 0x000A23A8 File Offset: 0x000A05A8
		Public Function Add(ID As String, Title As String, Content As String, Optional image As String = "", Optional href As String = "") As wPanel
			Dim wPanel As wPanel = New wPanel(MyBase.ID, ID, Title, Content, image, href)
			Me.OO_00o0O0.0__..Add(wPanel)
			Return wPanel
		End Function

		' Token: 0x06001900 RID: 6400 RVA: 0x000A23D8 File Offset: 0x000A05D8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
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
			A_0.AppendLine(text)
			If Operators.CompareString(Me.OO_00o0O0.0__., "", True) > 0 Then
				A_0.AppendLine("<div class='weui_panel_hd'>" + Me.OO_00o0O0.0__. + "</div>")
			End If
			A_0.AppendLine("<div class='weui_panel_bd'>")
			Try
				For Each wPanel As wPanel In Me.OO_00o0O0.0__.
					wPanel.Oo.0_O___0.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wPanel).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Operators.CompareString(Me.GroupFoot, "", True) > 0 Then
				A_0.AppendLine(String.Concat(New String() { "<a class='weui_panel_ft' href='", Me.o0o0._OOO_0., "'>", Me.GroupFoot, " </a>" }))
			End If
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A7E RID: 2686
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A7F RID: 2687
		Private <<EMPTY_NAME>> As List(Of wPanel)

		' Token: 0x04000A80 RID: 2688
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A81 RID: 2689
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
