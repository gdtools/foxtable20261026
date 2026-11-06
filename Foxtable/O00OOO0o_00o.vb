Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004C6 RID: 1222
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O00OOO0o_00o
		Implements Oo0__O__O_0__

		' Token: 0x06004E96 RID: 20118 RVA: 0x00209494 File Offset: 0x00207694
		Public Sub New(A_0 As Table, A_1 As Integer, A_2 As Integer)
			Me.O.OooO. = A_0
			Me.O.OooO. = A_1
			If A_2 = -1 Then
				Me.o._Oo__. = A_0.foxGrid.Rows.DefaultSize
				Return
			End If
			Me.o._Oo__. = A_2
		End Sub

		' Token: 0x06004E97 RID: 20119 RVA: 0x002094CC File Offset: 0x002076CC
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.O.OooO.()
		End Sub

		' Token: 0x06004E98 RID: 20120 RVA: 0x002094D4 File Offset: 0x002076D4
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim o_oOooO_O As O_oOooO_O = Me.O.OooO..foxGrid
			Dim num As Integer
			If o_oOooO_O.Rows(Me.O.OooO.).Height = -1 Then
				num = o_oOooO_O.Rows.DefaultSize
			Else
				num = o_oOooO_O.Rows(Me.O.OooO.).Height
			End If
			o_oOooO_O.Rows(Me.O.OooO.).Height = Me.o._Oo__.
			Me.o._Oo__. = num
		End Sub

		' Token: 0x0400208A RID: 8330
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400208B RID: 8331
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400208C RID: 8332
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
