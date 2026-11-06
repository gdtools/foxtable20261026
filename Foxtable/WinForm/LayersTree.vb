Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F1 RID: 1265
	Public Class LayersTree
		Inherits Control

		' Token: 0x060050FD RID: 20733 RVA: 0x00219581 File Offset: 0x00217781
		Friend Sub New(A_0 As oO_oo0Oo)
			MyBase.New(A_0, ControlTypeEnum.LayersTree)
			Me.o0_0oO.OooO. = A_0
			A_0.oOOO_0o.0o. = True
		End Sub

		' Token: 0x060050FE RID: 20734 RVA: 0x0021959A File Offset: 0x0021779A
		<oO0oooo("3373")>
		Public Sub BuildBOMTree(Table As Table, Setting As LayerTreeSetting)
			Setting.Unique = True
			Me.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.OOO.__O_oO_.)
		End Sub

		' Token: 0x060050FF RID: 20735 RVA: 0x002195AC File Offset: 0x002177AC
		<oO0oooo("3374")>
		Public Sub BuildFilterTree(Table As Table, Setting As LayerTreeSetting)
			Me.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.oOO___o.0oO.)
		End Sub

		' Token: 0x06005100 RID: 20736 RVA: 0x002195B8 File Offset: 0x002177B8
		Private Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As LayerTreeSetting, A_2 As O0_0_0O0___O)
			Me.o0_0oO.OooO..OO_0._O_. = A_0
			Me.o0_0oO.OooO..OO_0._O_. = A_2
			Me.o0_0oO.OooO..oo.00__O0o. = A_1.PathCol
			Me.o0_0oO.OooO..OO0_0O._oO0O_o. = A_1.TextCol
			Me.o0_0oO.OooO..oo__._0. = A_1.ValueCol
			Me.o0_0oO.OooO..OO_0._O_. = A_1.Subtotal
			Me.o0_0oO.OooO..OO_0o0.O_o_. = A_1.IncludeSub
			Me.o0_0oO.OooO..oo.00__O0o. = A_1.Separator2
			Me.o0_0oO.OooO..oo.00__O0o. = A_1.Lengths2
			Me.o0_0oO.OooO..OOOOO0.0. = A_1.ExpandTo
			Me.o0_0oO.OooO..o0ooOo0.0o_Oo. = A_1.GridTree
			Me.o0_0oO.OooO..o_._O0___O. = A_1.SortCol
			Me.o0_0oO.OooO..oOo.O. = A_1.SortDesc
			Me.o0_0oO.OooO..o_._O0___O. = A_1.Unique
			Me.o0_0oO.OooO..OO0_0O._oO0O_o. = A_1.MergeTotal
			If Operators.CompareString(Me.o0_0oO.OooO..oo.00__O0o., "", True) > 0 Then
				Me.o0_0oO.OooO..o.0o__.()
				Me.o0_0oO.OooO..o_oo_O0O.oO_.()
			End If
		End Sub

		' Token: 0x040021AE RID: 8622
		Private <<EMPTY_NAME>> As oO_oo0Oo
	End Class
End Namespace
