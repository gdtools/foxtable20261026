Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004C7 RID: 1223
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_o0_
		Implements Oo0__O__O_0__

		' Token: 0x06004E99 RID: 20121 RVA: 0x00209550 File Offset: 0x00207750
		Public Sub New(A_0 As Table, A_1 As Integer, A_2 As Integer)
			Me.O_o_.oo. = A_0
			Me.O_o_.oo. = A_1
			If A_2 = -1 Then
				Me.o_.00o_o000o_0. = A_0.foxGrid.Rows.DefaultSize
				Return
			End If
			Me.o_.00o_o000o_0. = A_2
		End Sub

		' Token: 0x06004E9A RID: 20122 RVA: 0x00209588 File Offset: 0x00207788
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.oo0Ooo.o_0__0_.()
		End Sub

		' Token: 0x06004E9B RID: 20123 RVA: 0x00209590 File Offset: 0x00207790
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim o_oOooO_O As O_oOooO_O = Me.O_o_.oo..foxGrid
			Dim num As Integer
			If o_oOooO_O.Rows(Me.O_o_.oo.).Height = -1 Then
				num = o_oOooO_O.Rows.DefaultSize
			Else
				num = o_oOooO_O.Rows(Me.O_o_.oo.).Height
			End If
			If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed OrElse Me.O_o_.oo..AllowResizeSingleRow Then
				o_oOooO_O.Rows(Me.O_o_.oo.).Height = Me.o_.00o_o000o_0.
			Else
				o_oOooO_O.BeginUpdate()
				o_oOooO_O.Rows.DefaultSize = Me.o_.00o_o000o_0.
				Dim fixed As Integer = o_oOooO_O.Rows.Fixed
				Dim num2 As Integer = o_oOooO_O.Rows.Count - 1
				For i As Integer = fixed To num2
					o_oOooO_O.Rows(i).Height = -1
				Next
				o_oOooO_O.EndUpdate()
			End If
			Me.o_.00o_o000o_0. = num
		End Sub

		' Token: 0x0400208D RID: 8333
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400208E RID: 8334
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400208F RID: 8335
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
