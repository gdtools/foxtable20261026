Imports System
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000421 RID: 1057
	Friend Class O00oOo0O_00_O
		Implements O_o_0o

		' Token: 0x06004602 RID: 17922 RVA: 0x001C4E74 File Offset: 0x001C3074
		Friend Sub New(A_0 As C1NavBarPanel)
			Me.o.oO0O0OO_o_. = CType(A_0.Parent, C1NavBar)
			Me.o0o.OooOOo0__. = A_0
			Me.o.oO0O0OO_o_. = Me.o.oO0O0OO_o_..Panels.IndexOf(Me.o0o.OooOOo0__.)
		End Sub

		' Token: 0x06004603 RID: 17923 RVA: 0x001C4EB0 File Offset: 0x001C30B0
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Me.o.oO0O0OO_o_..Panels.Insert(Me.o.oO0O0OO_o_., Me.o0o.OooOOo0__.)
			Me.o.oO0O0OO_o_..SelectedButton = Me.o0o.OooOOo0__..Button
		End Sub

		' Token: 0x04001C85 RID: 7301
		Private <<EMPTY_NAME>> As C1NavBar

		' Token: 0x04001C86 RID: 7302
		Private <<EMPTY_NAME>> As C1NavBarPanel

		' Token: 0x04001C87 RID: 7303
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
