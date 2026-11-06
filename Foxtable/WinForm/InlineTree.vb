Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F0 RID: 1264
	Public Class InlineTree
		Inherits Control

		' Token: 0x060050F9 RID: 20729 RVA: 0x002193E9 File Offset: 0x002175E9
		Friend Sub New(A_0 As oo__)
			MyBase.New(A_0, ControlTypeEnum.InlineTree)
			Me.o0_0oO.OooO. = A_0
			A_0.oO0.00ooO. = True
		End Sub

		' Token: 0x060050FA RID: 20730 RVA: 0x00219402 File Offset: 0x00217602
		<oO0oooo("3371")>
		Public Sub BuildBOMTree(Table As Table, Setting As InlineTreeSetting)
			Setting.Unique = True
			Me.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.OOO.__O_oO_.)
		End Sub

		' Token: 0x060050FB RID: 20731 RVA: 0x00219414 File Offset: 0x00217614
		<oO0oooo("3372")>
		Public Sub BuildFilterTree(Table As Table, Setting As InlineTreeSetting)
			Me.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.oOO___o.0oO.)
		End Sub

		' Token: 0x060050FC RID: 20732 RVA: 0x00219420 File Offset: 0x00217620
		Private Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As InlineTreeSetting, A_2 As O0_0_0O0___O)
			Me.o0_0oO.OooO..O_OOo0o0__0.0_. = A_0
			Me.o0_0oO.OooO..O_OOo0o0__0.0_. = A_2
			Me.o0_0oO.OooO..oO0.o_O. = A_1.ParentCol
			Me.o0_0oO.OooO..O_o_o.oo0_. = A_1.ChildCol
			Me.o0_0oO.OooO..Ooo_00_OO.0Oo_. = A_1.ValueCol
			If Operators.CompareString(A_1.TextCol, "", True) > 0 Then
				Me.o0_0oO.OooO..o0O_Oo0_O._. = A_1.TextCol
			Else
				Me.o0_0oO.OooO..o0O_Oo0_O._. = A_1.ChildCol
			End If
			Me.o0_0oO.OooO..o.ooO_. = A_1.IncludeSub
			Me.o0_0oO.OooO..O_00.0___0. = A_1.Subtotal
			Me.o0_0oO.OooO..o__oO0.OOo_O. = A_1.GridTree
			Me.o0_0oO.OooO..o_.0Oo_oo0_. = A_1.ExpandTo
			Me.o0_0oO.OooO..oO0__0_oO0.O_0. = A_1.SortCol
			Me.o0_0oO.OooO..oO0.o_O. = A_1.SortDesc
			Me.o0_0oO.OooO..Ooo_00_OO.0Oo_. = A_1.Unique
			Me.o0_0oO.OooO..O0.OOo0O. = A_1.MergeTotal
			If Operators.CompareString(Me.o0_0oO.OooO..oO0.o_O., "", True) > 0 AndAlso Operators.CompareString(Me.o0_0oO.OooO..O_o_o.oo0_., "", True) > 0 Then
				Me.o0_0oO.OooO..Oo0___O.0.()
				Me.o0_0oO.OooO..oOo0Ooo.O_Oo0.()
			End If
		End Sub

		' Token: 0x040021AD RID: 8621
		Private <<EMPTY_NAME>> As oo__
	End Class
End Namespace
