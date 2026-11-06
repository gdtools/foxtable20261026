Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000208 RID: 520
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wCheck
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x17000568 RID: 1384
		' (get) Token: 0x06001894 RID: 6292 RVA: 0x000A0558 File Offset: 0x0009E758
		' (set) Token: 0x06001895 RID: 6293 RVA: 0x000A0560 File Offset: 0x0009E760
		Public Property Text As String
			Get
				Return Me.o00.0Oo.
			End Get
			Set(value As String)
				Me.o00.0Oo. = value
			End Set
		End Property

		' Token: 0x17000569 RID: 1385
		' (get) Token: 0x06001896 RID: 6294 RVA: 0x000A0569 File Offset: 0x0009E769
		' (set) Token: 0x06001897 RID: 6295 RVA: 0x000A0571 File Offset: 0x0009E771
		Public Property Checked As Boolean
			Get
				Return Me.OO00000O0.0.
			End Get
			Set(value As Boolean)
				Me.OO00000O0.0. = value
			End Set
		End Property

		' Token: 0x06001898 RID: 6296 RVA: 0x000A057A File Offset: 0x0009E77A
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.oo_O.oO_o0. = True
			Me.Text = A_2
		End Sub

		' Token: 0x06001899 RID: 6297 RVA: 0x000A0592 File Offset: 0x0009E792
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Boolean)
			MyBase.New(A_0, A_1)
			Me.oo_O.oO_o0. = True
			Me.Checked = A_3
			Me.Text = A_2
		End Sub

		' Token: 0x1700056A RID: 1386
		' (get) Token: 0x0600189A RID: 6298 RVA: 0x000A05B2 File Offset: 0x0009E7B2
		' (set) Token: 0x0600189B RID: 6299 RVA: 0x000A05BA File Offset: 0x0009E7BA
		Public Property Enabled As Boolean
			Get
				Return Me.oo_O.oO_o0.
			End Get
			Set(value As Boolean)
				Me.oo_O.oO_o0. = value
			End Set
		End Property

		' Token: 0x1700056B RID: 1387
		' (get) Token: 0x0600189C RID: 6300 RVA: 0x000A05C3 File Offset: 0x0009E7C3
		' (set) Token: 0x0600189D RID: 6301 RVA: 0x000A05CB File Offset: 0x0009E7CB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.o.0_0OO00Ooo_0.
			End Get
			Set(value As String)
				Me.o.0_0OO00Ooo_0. = value
			End Set
		End Property

		' Token: 0x1700056C RID: 1388
		' (get) Token: 0x0600189E RID: 6302 RVA: 0x000A05D4 File Offset: 0x0009E7D4
		Private ReadOnly Property baseclass As String
			Get
				Return "weui_check"
			End Get
		End Property

		' Token: 0x1700056D RID: 1389
		' (get) Token: 0x0600189F RID: 6303 RVA: 0x000A05DB File Offset: 0x0009E7DB
		' (set) Token: 0x060018A0 RID: 6304 RVA: 0x000A05E3 File Offset: 0x0009E7E3
		Public Property Value As String
			Get
				Return Me.o_o0OOO_0.o0o.
			End Get
			Set(value As String)
				Me.o_o0OOO_0.o0o. = value
			End Set
		End Property

		' Token: 0x060018A1 RID: 6305 RVA: 0x000A05EC File Offset: 0x0009E7EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<label class='weui_cell weui_check_label' for='" + MyBase.ID + "'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<label id='", Me.HID, "' name='", Me.HID, "' class='weui_cell weui_check_label' for='", MyBase.ID, "'>" }))
			End If
			A_0.AppendLine("<div class='weui_cell_hd'>")
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<input type='checkbox' class='" + Me.baseclass + "'"
			Else
				text = String.Concat(New String() { "<input type='checkbox' class='", Me.baseclass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'" })
			If Operators.CompareString(Me.o_o0OOO_0.o0o., "", True) > 0 Then
				text = text + " value='" + Me.o_o0OOO_0.o0o. + "'"
			End If
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
			A_0.AppendLine("<i class='weui_icon_checked'></i>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			A_0.AppendLine("<p>" + Me.Text + "</p>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</label>")
		End Sub

		' Token: 0x04000A50 RID: 2640
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A51 RID: 2641
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A52 RID: 2642
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A53 RID: 2643
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A54 RID: 2644
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
