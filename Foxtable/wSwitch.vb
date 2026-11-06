Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000225 RID: 549
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0049")>
	Public Class wSwitch
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600198D RID: 6541 RVA: 0x000A555F File Offset: 0x000A375F
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O_____O.oo_oo. = True
			Me.O.000oO__0. = True
			Me.o0O.00_o_0_o0. = A_2
		End Sub

		' Token: 0x0600198E RID: 6542 RVA: 0x000A557E File Offset: 0x000A377E
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Boolean)
			MyBase.New(A_0, A_1)
			Me.O_____O.oo_oo. = True
			Me.O.000oO__0. = True
			Me.o0O.00_o_0_o0. = A_3
			Me.o0O.00_o_0_o0. = A_2
		End Sub

		' Token: 0x170005B2 RID: 1458
		' (get) Token: 0x0600198F RID: 6543 RVA: 0x000A55A5 File Offset: 0x000A37A5
		' (set) Token: 0x06001990 RID: 6544 RVA: 0x000A55AD File Offset: 0x000A37AD
		Public Property Enabled As Boolean
			Get
				Return Me.O_____O.oo_oo.
			End Get
			Set(value As Boolean)
				Me.O_____O.oo_oo. = value
			End Set
		End Property

		' Token: 0x170005B3 RID: 1459
		' (get) Token: 0x06001991 RID: 6545 RVA: 0x000A55B6 File Offset: 0x000A37B6
		' (set) Token: 0x06001992 RID: 6546 RVA: 0x000A55BE File Offset: 0x000A37BE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.O.000oO__0.
			End Get
			Set(value As String)
				Me.O.000oO__0. = value
			End Set
		End Property

		' Token: 0x170005B4 RID: 1460
		' (get) Token: 0x06001993 RID: 6547 RVA: 0x000A55C7 File Offset: 0x000A37C7
		' (set) Token: 0x06001994 RID: 6548 RVA: 0x000A55CF File Offset: 0x000A37CF
		Public Property Value As String
			Get
				Return Me.O_____O.oo_oo.
			End Get
			Set(value As String)
				Me.O_____O.oo_oo. = value
			End Set
		End Property

		' Token: 0x170005B5 RID: 1461
		' (get) Token: 0x06001995 RID: 6549 RVA: 0x000A55D8 File Offset: 0x000A37D8
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_switch"
			End Get
		End Property

		' Token: 0x170005B6 RID: 1462
		' (get) Token: 0x06001996 RID: 6550 RVA: 0x000A55DF File Offset: 0x000A37DF
		' (set) Token: 0x06001997 RID: 6551 RVA: 0x000A55E7 File Offset: 0x000A37E7
		Public Property Post As Boolean
			Get
				Return Me.O.000oO__0.
			End Get
			Set(value As Boolean)
				Me.O.000oO__0. = value
			End Set
		End Property

		' Token: 0x06001998 RID: 6552 RVA: 0x000A55F0 File Offset: 0x000A37F0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<div class='weui_cell weui_cell_switch'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<div class='weui_cell weui_cell_switch' id='", Me.HID, "' name='", Me.HID, "'>" }))
			End If
			A_0.AppendLine("<div class='weui_cell_hd weui_cell_primary'>" + Me.o0O.00_o_0_o0. + "</div>")
			A_0.AppendLine("  <div class='weui_cell_ft'>")
			Dim text As String = "<input type='checkbox'"
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = text + " id='" + MyBase.ID + "'"
			If Me.Post Then
				text = text + " name='" + MyBase.ID + "'"
			End If
			If Operators.CompareString(Me.O_____O.oo_oo., "", True) > 0 Then
				text = text + " value='" + Me.O_____O.oo_oo. + "'"
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Me.o0O.00_o_0_o0. Then
				text += " checked"
			End If
			If Not Me.Enabled Then
				text += " disabled"
			End If
			text += "/>"
			A_0.AppendLine(text)
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000AC0 RID: 2752
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AC1 RID: 2753
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AC2 RID: 2754
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AC3 RID: 2755
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AC4 RID: 2756
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AC5 RID: 2757
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
