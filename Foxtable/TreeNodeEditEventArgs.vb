Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A8 RID: 680
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TreeNodeEditEventArgs
		Inherits ControlEventArgs

		' Token: 0x060023E8 RID: 9192 RVA: 0x000F9C14 File Offset: 0x000F7E14
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As Foxtable.WinForm.TreeNode, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.o_0_0.O_o__0o. = A_2
			Me.o_0_0.O_o__0o. = A_3
		End Sub

		' Token: 0x1700083A RID: 2106
		' (get) Token: 0x060023E9 RID: 9193 RVA: 0x000F9C2D File Offset: 0x000F7E2D
		Public ReadOnly Property Node As Foxtable.WinForm.TreeNode
			Get
				Return Me.o_0_0.O_o__0o.
			End Get
		End Property

		' Token: 0x1700083B RID: 2107
		' (get) Token: 0x060023EA RID: 9194 RVA: 0x000F9C35 File Offset: 0x000F7E35
		Public ReadOnly Property NewText As String
			Get
				Return Me.o_0_0.O_o__0o.
			End Get
		End Property

		' Token: 0x04000EDB RID: 3803
		Private <<EMPTY_NAME>> As Foxtable.WinForm.TreeNode

		' Token: 0x04000EDC RID: 3804
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
