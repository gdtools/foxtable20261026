Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000227 RID: 551
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0082")>
	Public Class wToast
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600199B RID: 6555 RVA: 0x000A59BC File Offset: 0x000A3BBC
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Integer)
			MyBase.New(A_0, A_1)
			Me.O_._0o0. = "default"
			Me.o00O_OO.O. = A_2
			Me.o00O_OO.O. = A_3
		End Sub

		' Token: 0x170005B7 RID: 1463
		' (get) Token: 0x0600199C RID: 6556 RVA: 0x000A59E0 File Offset: 0x000A3BE0
		' (set) Token: 0x0600199D RID: 6557 RVA: 0x000A59E8 File Offset: 0x000A3BE8
		Public Property Icon As String
			Get
				Return Me.O_._0o0.
			End Get
			Set(value As String)
				Me.O_._0o0. = value
			End Set
		End Property

		' Token: 0x170005B8 RID: 1464
		' (get) Token: 0x0600199E RID: 6558 RVA: 0x000A59F1 File Offset: 0x000A3BF1
		' (set) Token: 0x0600199F RID: 6559 RVA: 0x000A59F9 File Offset: 0x000A3BF9
		Public Property Visible As Boolean
			Get
				Return Me.o00O_OO.O.
			End Get
			Set(value As Boolean)
				Me.o00O_OO.O. = value
			End Set
		End Property

		' Token: 0x170005B9 RID: 1465
		' (get) Token: 0x060019A0 RID: 6560 RVA: 0x000A5A02 File Offset: 0x000A3C02
		' (set) Token: 0x060019A1 RID: 6561 RVA: 0x000A5A0A File Offset: 0x000A3C0A
		Public Property msec As Integer
			Get
				Return Me.O_._0o0.
			End Get
			Set(value As Integer)
				Me.O_._0o0. = value
			End Set
		End Property

		' Token: 0x060019A2 RID: 6562 RVA: 0x000A5A14 File Offset: 0x000A3C14
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim o_._0o0. As String = Me.O_._0o0.
			If Operators.CompareString(o_._0o0., "success", True) = 0 Then
				Me.O_._0o0. = "weui_icon_success"
			ElseIf Operators.CompareString(o_._0o0., "warn", True) = 0 Then
				Me.O_._0o0. = "weui_icon_warn"
			ElseIf Operators.CompareString(o_._0o0., "info", True) = 0 Then
				Me.O_._0o0. = "weui_icon_info"
			End If
			If Me.o00O_OO.O. = 0 Then
				A_0.AppendLine("<div id='" + MyBase.ID + Interaction.IIf(Me.Visible, "'>", "' style='display:none'>").ToString())
			Else
				A_0.AppendLine("<div class='weui_loading_toast' id='" + MyBase.ID + Interaction.IIf(Me.Visible, "'>", "' style='display:none'>").ToString())
			End If
			A_0.AppendLine("<div class='weui_mask_transparent'></div>")
			A_0.AppendLine(" <div class='weui_toast'>")
			If Me.o00O_OO.O. = 0 Then
				If Operators.CompareString(Me.O_._0o0., "", True) > 0 AndAlso Operators.CompareString(Me.O_._0o0., "default", True) <> 0 Then
					A_0.AppendLine(" <i class='fox_toast_icon " + Me.O_._0o0. + "'></i>")
				Else
					A_0.AppendLine(" <i class='weui_icon_toast'></i>")
				End If
			Else
				A_0.AppendLine(" <div class='weui_loading'>")
				Dim num As Integer = 0
				Do
					A_0.AppendLine(" <div class='weui_loading_leaf weui_loading_leaf_" + Conversions.ToString(num) + "'></div>")
					num += 1
				Loop While num <= 11
				A_0.AppendLine("</div>")
			End If
			A_0.AppendLine("<p class='weui_toast_content'>" + Me.o00O_OO.O. + "</p>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
			If Me.msec > 0 Then
				A_1.Scripts.Add(String.Concat(New String() { "show('", MyBase.ID, "',", Conversions.ToString(Me.msec), ");" }))
			End If
		End Sub

		' Token: 0x04000AC8 RID: 2760
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AC9 RID: 2761
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000ACA RID: 2762
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ACB RID: 2763
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000ACC RID: 2764
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
