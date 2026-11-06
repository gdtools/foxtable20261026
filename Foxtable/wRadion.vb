Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200021C RID: 540
	<oO0oooo("A0052")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wRadion
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x1700058A RID: 1418
		' (get) Token: 0x06001919 RID: 6425 RVA: 0x000A31A4 File Offset: 0x000A13A4
		' (set) Token: 0x0600191A RID: 6426 RVA: 0x000A31AC File Offset: 0x000A13AC
		Public Property Text As String
			Get
				Return Me.OO.oO00.
			End Get
			Set(value As String)
				Me.OO.oO00. = value
			End Set
		End Property

		' Token: 0x1700058B RID: 1419
		' (get) Token: 0x0600191B RID: 6427 RVA: 0x000A31B5 File Offset: 0x000A13B5
		' (set) Token: 0x0600191C RID: 6428 RVA: 0x000A31BD File Offset: 0x000A13BD
		Public Property Checked As Boolean
			Get
				Return Me.OO.oO00.
			End Get
			Set(value As Boolean)
				Me.OO.oO00. = value
			End Set
		End Property

		' Token: 0x0600191D RID: 6429 RVA: 0x000A31C6 File Offset: 0x000A13C6
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.o.OOo_0__o. = True
			Me.Text = A_2
		End Sub

		' Token: 0x0600191E RID: 6430 RVA: 0x000A31DE File Offset: 0x000A13DE
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Boolean)
			MyBase.New(A_0, A_1)
			Me.o.OOo_0__o. = True
			Me.Checked = A_3
			Me.Text = A_2
		End Sub

		' Token: 0x1700058C RID: 1420
		' (get) Token: 0x0600191F RID: 6431 RVA: 0x000A31FE File Offset: 0x000A13FE
		' (set) Token: 0x06001920 RID: 6432 RVA: 0x000A3206 File Offset: 0x000A1406
		Public Property Enabled As Boolean
			Get
				Return Me.o.OOo_0__o.
			End Get
			Set(value As Boolean)
				Me.o.OOo_0__o. = value
			End Set
		End Property

		' Token: 0x1700058D RID: 1421
		' (get) Token: 0x06001921 RID: 6433 RVA: 0x000A320F File Offset: 0x000A140F
		' (set) Token: 0x06001922 RID: 6434 RVA: 0x000A3217 File Offset: 0x000A1417
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.o0O0o0OoO0.0.
			End Get
			Set(value As String)
				Me.o0O0o0OoO0.0. = value
			End Set
		End Property

		' Token: 0x1700058E RID: 1422
		' (get) Token: 0x06001923 RID: 6435 RVA: 0x000A3220 File Offset: 0x000A1420
		' (set) Token: 0x06001924 RID: 6436 RVA: 0x000A3228 File Offset: 0x000A1428
		Public Property Value As String
			Get
				Return Me.o.OOo_0__o.
			End Get
			Set(value As String)
				Me.o.OOo_0__o. = value
			End Set
		End Property

		' Token: 0x1700058F RID: 1423
		' (get) Token: 0x06001925 RID: 6437 RVA: 0x000A3231 File Offset: 0x000A1431
		Private ReadOnly Property baseclass As String
			Get
				Return "weui_check"
			End Get
		End Property

		' Token: 0x06001926 RID: 6438 RVA: 0x000A3238 File Offset: 0x000A1438
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<label class='weui_cell weui_check_label' for='" + MyBase.ID + "'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<label id='", Me.HID, "' name='", Me.HID, "' class='weui_cell weui_check_label' for='", MyBase.ID, "'>" }))
			End If
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			A_0.AppendLine(" <p>" + Me.Text + "</p>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("<div class='weui_cell_ft'>")
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<input type='radio' class='" + Me.baseclass + "'"
			Else
				text = String.Concat(New String() { "<input type='radio' class='", Me.baseclass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.PID, "' id='", MyBase.ID, "' value = '", Interaction.IIf(Operators.CompareString(Me.o.OOo_0__o., "", True) > 0, Me.o.OOo_0__o., MyBase.ID).ToString(), "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Me.Checked Then
				text += " checked"
			End If
			If Not Me.Enabled Then
				text += " disabled"
			End If
			text += "/>"
			A_0.AppendLine(text)
			A_0.AppendLine(" <span class='weui_icon_checked'></span>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</label>")
		End Sub

		' Token: 0x04000A91 RID: 2705
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A92 RID: 2706
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A93 RID: 2707
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A94 RID: 2708
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A95 RID: 2709
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
