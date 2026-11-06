Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200021D RID: 541
	<oO0oooo("A0048")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wSelect
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001927 RID: 6439 RVA: 0x000A3459 File Offset: 0x000A1659
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.OOOO0._0O. = True
			Me.o_0_oO0_oo_0.O. = True
			Me.OOOO0._0O. = A_2
		End Sub

		' Token: 0x06001928 RID: 6440 RVA: 0x000A3478 File Offset: 0x000A1678
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.OOOO0._0O. = True
			Me.o_0_oO0_oo_0.O. = True
			Me.OOOO0._0O. = A_2
			Me.O.0_OOOoO. = A_3
		End Sub

		' Token: 0x17000590 RID: 1424
		' (get) Token: 0x06001929 RID: 6441 RVA: 0x000A349F File Offset: 0x000A169F
		' (set) Token: 0x0600192A RID: 6442 RVA: 0x000A34A7 File Offset: 0x000A16A7
		Public Property Label As String
			Get
				Return Me.OOOO0._0O.
			End Get
			Set(value As String)
				Me.OOOO0._0O. = value
			End Set
		End Property

		' Token: 0x17000591 RID: 1425
		' (get) Token: 0x0600192B RID: 6443 RVA: 0x000A34B0 File Offset: 0x000A16B0
		' (set) Token: 0x0600192C RID: 6444 RVA: 0x000A34B8 File Offset: 0x000A16B8
		Public Property Enabled As Boolean
			Get
				Return Me.OOOO0._0O.
			End Get
			Set(value As Boolean)
				Me.OOOO0._0O. = value
			End Set
		End Property

		' Token: 0x17000592 RID: 1426
		' (get) Token: 0x0600192D RID: 6445 RVA: 0x000A34C1 File Offset: 0x000A16C1
		' (set) Token: 0x0600192E RID: 6446 RVA: 0x000A34C9 File Offset: 0x000A16C9
		Public Property Post As Boolean
			Get
				Return Me.o_0_oO0_oo_0.O.
			End Get
			Set(value As Boolean)
				Me.o_0_oO0_oo_0.O. = value
			End Set
		End Property

		' Token: 0x17000593 RID: 1427
		' (get) Token: 0x0600192F RID: 6447 RVA: 0x000A34D2 File Offset: 0x000A16D2
		' (set) Token: 0x06001930 RID: 6448 RVA: 0x000A34DA File Offset: 0x000A16DA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property required As Boolean
			Get
				Return Me.O.0_OOOoO.
			End Get
			Set(value As Boolean)
				Me.O.0_OOOoO. = value
			End Set
		End Property

		' Token: 0x17000594 RID: 1428
		' (get) Token: 0x06001931 RID: 6449 RVA: 0x000A34E3 File Offset: 0x000A16E3
		' (set) Token: 0x06001932 RID: 6450 RVA: 0x000A34EB File Offset: 0x000A16EB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.o_0_oO0_oo_0.O.
			End Get
			Set(value As String)
				Me.o_0_oO0_oo_0.O. = value
			End Set
		End Property

		' Token: 0x17000595 RID: 1429
		' (get) Token: 0x06001933 RID: 6451 RVA: 0x000A34F4 File Offset: 0x000A16F4
		Private ReadOnly Property baseClass As String
			Get
				Return "weui_select"
			End Get
		End Property

		' Token: 0x06001934 RID: 6452 RVA: 0x000A34FC File Offset: 0x000A16FC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<div class='weui_cell weui_cell_select weui_select_after'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<div class='weui_cell weui_cell_select weui_select_after' id='", Me.HID, "' name='", Me.HID, "'>" }))
			End If
			If Operators.CompareString(Me.Label, "", True) > 0 Then
				A_0.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + Me.Label + "</label></div>")
			End If
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			Me.OOOO0._0O.(A_0, A_1)
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x06001935 RID: 6453 RVA: 0x000A35C4 File Offset: 0x000A17C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui)
			Dim text As String = "<select id='" + MyBase.ID + "'"
			If Me.Post Then
				text = text + " name='" + MyBase.ID + "'"
			End If
			If Not Me.Enabled Then
				text += " disabled"
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Me.required Then
				text += " required"
			End If
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.baseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.baseClass, " ", MyBase.[Class], "'" })
			End If
			A_0.AppendLine(text + ">")
			If Operators.CompareString(Me.O.0_OOOoO., "", True) > 0 Then
				A_0.AppendLine("<option style='display: none'></option>")
				For Each text2 As String In Me.O.0_OOOoO..Split(New Char() { "|"c })
					Dim flag As Boolean
					If text2.StartsWith("[") AndAlso text2.EndsWith("]") Then
						flag = True
						text2 = text2.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
					Else
						flag = False
					End If
					Dim array2 As String() = text2.Split(New Char() { ":"c })
					If flag Then
						If array2.Length > 1 Then
							A_0.AppendLine(String.Concat(New String() { " <option  value='", array2(0), "' selected>", array2(1), "</option>" }))
						Else
							A_0.AppendLine(" <option selected>" + array2(0) + "</option>")
						End If
					ElseIf array2.Length > 1 Then
						A_0.AppendLine(String.Concat(New String() { " <option value='", array2(0), "'>", array2(1), "</option>" }))
					Else
						A_0.AppendLine(" <option>" + array2(0) + "</option>")
					End If
				Next
			End If
			A_0.AppendLine("</select>")
		End Sub

		' Token: 0x04000A96 RID: 2710
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A97 RID: 2711
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A98 RID: 2712
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A99 RID: 2713
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A9A RID: 2714
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A9B RID: 2715
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
