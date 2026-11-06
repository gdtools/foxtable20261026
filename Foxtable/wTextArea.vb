Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000223 RID: 547
	<oO0oooo("A0050")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wTextArea
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001977 RID: 6519 RVA: 0x000A51A5 File Offset: 0x000A33A5
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Integer)
			MyBase.New(A_0, A_1)
			Me.o0oO._0o0_O. = True
			Me.o0O_ooo0_00.0_. = False
			Me.O0O_O_oO_0.o. = True
			Me.o0oO._0o0_O. = A_2
		End Sub

		' Token: 0x170005A8 RID: 1448
		' (get) Token: 0x06001978 RID: 6520 RVA: 0x000A51CB File Offset: 0x000A33CB
		' (set) Token: 0x06001979 RID: 6521 RVA: 0x000A51D3 File Offset: 0x000A33D3
		Public Property Enabled As Boolean
			Get
				Return Me.o0oO._0o0_O.
			End Get
			Set(value As Boolean)
				Me.o0oO._0o0_O. = value
			End Set
		End Property

		' Token: 0x170005A9 RID: 1449
		' (get) Token: 0x0600197A RID: 6522 RVA: 0x000A51DC File Offset: 0x000A33DC
		' (set) Token: 0x0600197B RID: 6523 RVA: 0x000A51E4 File Offset: 0x000A33E4
		Public Property [Readonly] As Boolean
			Get
				Return Me.o0O_ooo0_00.0_.
			End Get
			Set(value As Boolean)
				Me.o0O_ooo0_00.0_. = value
			End Set
		End Property

		' Token: 0x170005AA RID: 1450
		' (get) Token: 0x0600197C RID: 6524 RVA: 0x000A51ED File Offset: 0x000A33ED
		' (set) Token: 0x0600197D RID: 6525 RVA: 0x000A51F5 File Offset: 0x000A33F5
		Public Property Placeholder As String
			Get
				Return Me.o0oO._0o0_O.
			End Get
			Set(value As String)
				Me.o0oO._0o0_O. = value
			End Set
		End Property

		' Token: 0x170005AB RID: 1451
		' (get) Token: 0x0600197E RID: 6526 RVA: 0x000A51FE File Offset: 0x000A33FE
		' (set) Token: 0x0600197F RID: 6527 RVA: 0x000A5206 File Offset: 0x000A3406
		Public Property Value As String
			Get
				Return Me.O_._0o0.
			End Get
			Set(value As String)
				Me.O_._0o0. = value
			End Set
		End Property

		' Token: 0x170005AC RID: 1452
		' (get) Token: 0x06001980 RID: 6528 RVA: 0x000A520F File Offset: 0x000A340F
		' (set) Token: 0x06001981 RID: 6529 RVA: 0x000A5217 File Offset: 0x000A3417
		Public Property required As Boolean
			Get
				Return Me.Oo_o00oo.0o.
			End Get
			Set(value As Boolean)
				Me.Oo_o00oo.0o. = value
			End Set
		End Property

		' Token: 0x170005AD RID: 1453
		' (get) Token: 0x06001982 RID: 6530 RVA: 0x000A5220 File Offset: 0x000A3420
		Friend ReadOnly Property baseClass As String
			Get
				Return "weui_textarea"
			End Get
		End Property

		' Token: 0x170005AE RID: 1454
		' (get) Token: 0x06001983 RID: 6531 RVA: 0x000A5227 File Offset: 0x000A3427
		' (set) Token: 0x06001984 RID: 6532 RVA: 0x000A522F File Offset: 0x000A342F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.Oo_o00oo.0o.
			End Get
			Set(value As String)
				Me.Oo_o00oo.0o. = value
			End Set
		End Property

		' Token: 0x170005AF RID: 1455
		' (get) Token: 0x06001985 RID: 6533 RVA: 0x000A5238 File Offset: 0x000A3438
		' (set) Token: 0x06001986 RID: 6534 RVA: 0x000A5240 File Offset: 0x000A3440
		Public Property Post As Boolean
			Get
				Return Me.O0O_O_oO_0.o.
			End Get
			Set(value As Boolean)
				Me.O0O_O_oO_0.o. = value
			End Set
		End Property

		' Token: 0x06001987 RID: 6535 RVA: 0x000A524C File Offset: 0x000A344C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<div class='weui_cell'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<div class='weui_cell' id='", Me.HID, "' name='", Me.HID, "'>" }))
			End If
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			Dim text As String = "<textarea id='" + MyBase.ID + "'"
			If Me.Post Then
				text = text + " name='" + MyBase.ID + "'"
			End If
			If Operators.CompareString(Me.Placeholder, "", True) > 0 Then
				text = text + " placeholder='" + Me.Placeholder + "'"
			End If
			If Not Me.Enabled Then
				text += " disabled"
			End If
			If Me.[Readonly] Then
				text += " readonly"
			End If
			If Me.required Then
				text += " required"
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.baseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.baseClass, " ", MyBase.[Class], "'" })
			End If
			If Me.o0oO._0o0_O. > 0 Then
				text = text + " rows='" + Conversions.ToString(Me.o0oO._0o0_O.) + "'"
			End If
			A_0.AppendLine(text + ">" + Me.Value + "</textarea>")
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000AB7 RID: 2743
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AB8 RID: 2744
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AB9 RID: 2745
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000ABA RID: 2746
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ABB RID: 2747
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ABC RID: 2748
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000ABD RID: 2749
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ABE RID: 2750
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
