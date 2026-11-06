Imports System

Namespace Foxtable.WinForm
	' Token: 0x020004EF RID: 1263
	<oO0oooo("3370")>
	Public Class LoadTree
		Inherits Control

		' Token: 0x060050F7 RID: 20727 RVA: 0x00219358 File Offset: 0x00217558
		Friend Sub New(A_0 As o_0)
			MyBase.New(A_0, ControlTypeEnum.LoadTree)
			Me.O.oo_oO. = A_0
			A_0.oOo0O.___ooOO0. = True
		End Sub

		' Token: 0x060050F8 RID: 20728 RVA: 0x00219374 File Offset: 0x00217574
		Public Sub Build(Table As Table, ColNames As String, PageRows As Integer, Optional DefaultFilter As String = "")
			Me.O.oo_oO..O__O_._. = Table
			Me.O.oo_oO..O_OOo0.0ooO. = ColNames
			Me.O.oo_oO..oOo0O.___ooOO0. = DefaultFilter
			Table.o.0__o0. = PageRows
			Table.O0__O_.O. = Table.DataTable.LoadOver
			Me.O.oo_oO..o000.oO0.(ColNames)
			If Me.O.oo_oO..O.0O_o0.() IsNot Nothing Then
				Me.O.oo_oO..O.0O_o0.().Visible = True
			End If
		End Sub

		' Token: 0x040021AC RID: 8620
		Private <<EMPTY_NAME>> As o_0
	End Class
End Namespace
