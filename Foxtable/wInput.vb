Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200020F RID: 527
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0045")>
	Public Class wInput
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018BD RID: 6333 RVA: 0x000A10F3 File Offset: 0x0009F2F3
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O_ooo.0. = True
			Me.O.OO0O_Oo_O. = False
			Me.O_00o_.OO. = True
			Me.O.OO0O_Oo_O. = A_2
		End Sub

		' Token: 0x060018BE RID: 6334 RVA: 0x000A1119 File Offset: 0x0009F319
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.O_ooo.0. = True
			Me.O.OO0O_Oo_O. = False
			Me.O_00o_.OO. = True
			Me.O.OO0O_Oo_O. = A_2
			Me.o_O__oo__.00oO. = A_3
		End Sub

		' Token: 0x17000573 RID: 1395
		' (get) Token: 0x060018BF RID: 6335 RVA: 0x000A1147 File Offset: 0x0009F347
		' (set) Token: 0x060018C0 RID: 6336 RVA: 0x000A114F File Offset: 0x0009F34F
		Public Property Enabled As Boolean
			Get
				Return Me.O_ooo.0.
			End Get
			Set(value As Boolean)
				Me.O_ooo.0. = value
			End Set
		End Property

		' Token: 0x17000574 RID: 1396
		' (get) Token: 0x060018C1 RID: 6337 RVA: 0x000A1158 File Offset: 0x0009F358
		' (set) Token: 0x060018C2 RID: 6338 RVA: 0x000A1160 File Offset: 0x0009F360
		Public Property [Readonly] As Boolean
			Get
				Return Me.O.OO0O_Oo_O.
			End Get
			Set(value As Boolean)
				Me.O.OO0O_Oo_O. = value
			End Set
		End Property

		' Token: 0x17000575 RID: 1397
		' (get) Token: 0x060018C3 RID: 6339 RVA: 0x000A1169 File Offset: 0x0009F369
		' (set) Token: 0x060018C4 RID: 6340 RVA: 0x000A1171 File Offset: 0x0009F371
		Public Property Placeholder As String
			Get
				Return Me.oo_.0O_o0.
			End Get
			Set(value As String)
				Me.oo_.0O_o0. = value
			End Set
		End Property

		' Token: 0x17000576 RID: 1398
		' (get) Token: 0x060018C5 RID: 6341 RVA: 0x000A117A File Offset: 0x0009F37A
		' (set) Token: 0x060018C6 RID: 6342 RVA: 0x000A1182 File Offset: 0x0009F382
		Public Property Value As String
			Get
				Return Me.oo_.___.
			End Get
			Set(value As String)
				Me.oo_.___. = value
			End Set
		End Property

		' Token: 0x17000577 RID: 1399
		' (get) Token: 0x060018C7 RID: 6343 RVA: 0x000A118B File Offset: 0x0009F38B
		' (set) Token: 0x060018C8 RID: 6344 RVA: 0x000A1193 File Offset: 0x0009F393
		<oO0oooo("A0047")>
		Public Property Max As String
			Get
				Return Me.O_00o_.OO.
			End Get
			Set(value As String)
				Me.O_00o_.OO. = value
			End Set
		End Property

		' Token: 0x17000578 RID: 1400
		' (get) Token: 0x060018C9 RID: 6345 RVA: 0x000A119C File Offset: 0x0009F39C
		' (set) Token: 0x060018CA RID: 6346 RVA: 0x000A11A4 File Offset: 0x0009F3A4
		<oO0oooo("A0047")>
		Public Property Min As String
			Get
				Return Me.Oo.Oo0o__OO.
			End Get
			Set(value As String)
				Me.Oo.Oo0o__OO. = value
			End Set
		End Property

		' Token: 0x17000579 RID: 1401
		' (get) Token: 0x060018CB RID: 6347 RVA: 0x000A11AD File Offset: 0x0009F3AD
		' (set) Token: 0x060018CC RID: 6348 RVA: 0x000A11B5 File Offset: 0x0009F3B5
		Public Property Required As Boolean
			Get
				Return Me.o_O__oo__.00oO.
			End Get
			Set(value As Boolean)
				Me.o_O__oo__.00oO. = value
			End Set
		End Property

		' Token: 0x1700057A RID: 1402
		' (get) Token: 0x060018CD RID: 6349 RVA: 0x000A11BE File Offset: 0x0009F3BE
		Private ReadOnly Property baseClass As String
			Get
				Return "weui_input"
			End Get
		End Property

		' Token: 0x1700057B RID: 1403
		' (get) Token: 0x060018CE RID: 6350 RVA: 0x000A11C5 File Offset: 0x0009F3C5
		' (set) Token: 0x060018CF RID: 6351 RVA: 0x000A11CD File Offset: 0x0009F3CD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HID As String
			Get
				Return Me.o_O0oo.OOo.
			End Get
			Set(value As String)
				Me.o_O0oo.OOo. = value
			End Set
		End Property

		' Token: 0x1700057C RID: 1404
		' (get) Token: 0x060018D0 RID: 6352 RVA: 0x000A11D6 File Offset: 0x0009F3D6
		' (set) Token: 0x060018D1 RID: 6353 RVA: 0x000A11DE File Offset: 0x0009F3DE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property list As String
			Get
				Return Me.O___.Oo.
			End Get
			Set(value As String)
				Me.O___.Oo. = value
			End Set
		End Property

		' Token: 0x1700057D RID: 1405
		' (get) Token: 0x060018D2 RID: 6354 RVA: 0x000A11E7 File Offset: 0x0009F3E7
		' (set) Token: 0x060018D3 RID: 6355 RVA: 0x000A11EF File Offset: 0x0009F3EF
		<oO0oooo("A0047")>
		Public Property [Step] As String
			Get
				Return Me.O0_.o_o.
			End Get
			Set(value As String)
				Me.O0_.o_o. = value
			End Set
		End Property

		' Token: 0x1700057E RID: 1406
		' (get) Token: 0x060018D4 RID: 6356 RVA: 0x000A11F8 File Offset: 0x0009F3F8
		' (set) Token: 0x060018D5 RID: 6357 RVA: 0x000A1200 File Offset: 0x0009F400
		Public Property Post As Boolean
			Get
				Return Me.O_00o_.OO.
			End Get
			Set(value As Boolean)
				Me.O_00o_.OO. = value
			End Set
		End Property

		' Token: 0x060018D6 RID: 6358 RVA: 0x000A120C File Offset: 0x0009F40C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.HID, "", True) = 0 Then
				A_0.AppendLine("<div class='weui_cell'>")
			Else
				A_0.AppendLine(String.Concat(New String() { "<div class='weui_cell' id='", Me.HID, "' name='", Me.HID, "'>" }))
			End If
			If Operators.CompareString(Me.O.OO0O_Oo_O., "", True) > 0 Then
				A_0.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + Me.O.OO0O_Oo_O. + "</label></div>")
			End If
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			Me.O_ooo.0.(A_0, A_1)
			A_0.AppendLine("</div>")
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x060018D7 RID: 6359 RVA: 0x000A12D4 File Offset: 0x0009F4D4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui)
			Dim text As String = "<input id='" + MyBase.ID + "'"
			If Me.Post Then
				text = text + " name='" + MyBase.ID + "'"
			End If
			If Operators.CompareString(Me.o_O__oo__.00oO., "", True) > 0 Then
				text = text + " type='" + Me.o_O__oo__.00oO. + "'"
			End If
			If Operators.CompareString(Me.oo_.0O_o0., "", True) > 0 Then
				text = text + " placeholder='" + Me.oo_.0O_o0. + "'"
			End If
			If Operators.CompareString(Me.O_00o_.OO., "", True) > 0 Then
				text = text + " max='" + Me.O_00o_.OO. + "'"
			End If
			If Operators.CompareString(Me.Oo.Oo0o__OO., "", True) > 0 Then
				text = text + " min='" + Me.Oo.Oo0o__OO. + "'"
			End If
			If Operators.CompareString(Me.O0_.o_o., "", True) > 0 Then
				text = text + " step='" + Me.O0_.o_o. + "'"
			End If
			If Not Me.O_ooo.0. Then
				text += " disabled"
			End If
			If Me.O.OO0O_Oo_O. Then
				text += " readonly"
			End If
			If Me.o_O__oo__.00oO. Then
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
			If Operators.CompareString(Me.oo_.___., "", True) > 0 Then
				text = text + " value='" + Me.oo_.___. + "'"
			End If
			If Operators.CompareString(Me.O___.Oo., "", True) > 0 Then
				text = text + " list='" + Me.O___.Oo. + "'"
			End If
			A_0.AppendLine(text + "/>")
		End Sub

		' Token: 0x04000A60 RID: 2656
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A61 RID: 2657
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A62 RID: 2658
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A63 RID: 2659
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A64 RID: 2660
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A65 RID: 2661
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A66 RID: 2662
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A67 RID: 2663
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A68 RID: 2664
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A69 RID: 2665
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A6A RID: 2666
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A6B RID: 2667
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A6C RID: 2668
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
