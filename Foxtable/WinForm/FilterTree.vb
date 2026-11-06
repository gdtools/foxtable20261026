Imports System
Imports System.Runtime.InteropServices

Namespace Foxtable.WinForm
	' Token: 0x020004EE RID: 1262
	<ComVisible(True)>
	<oO0oooo("3369")>
	Public Class FilterTree
		Inherits Control

		' Token: 0x060050F5 RID: 20725 RVA: 0x002192ED File Offset: 0x002174ED
		Friend Sub New(A_0 As o_o0ooOooO)
			MyBase.New(A_0, ControlTypeEnum.FilterTree)
			Me.O.00oo_OO0O. = A_0
			A_0.O_.o__. = True
		End Sub

		' Token: 0x060050F6 RID: 20726 RVA: 0x00219308 File Offset: 0x00217508
		Public Sub Build(Table As Table, ColNames As String)
			Me.O.00oo_OO0O..OOO_.00. = Table
			Me.O.00oo_OO0O..OOO_.00. = ColNames
			Me.O.00oo_OO0O..O0o.0oo0_.(ColNames)
			If Me.O.00oo_OO0O..O0o.0oo0_.() IsNot Nothing Then
				Me.O.00oo_OO0O..O0o.0oo0_.().Visible = True
			End If
		End Sub

		' Token: 0x040021AB RID: 8619
		Private <<EMPTY_NAME>> As o_o0ooOooO
	End Class
End Namespace
