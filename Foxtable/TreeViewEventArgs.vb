Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003E1 RID: 993
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TreeViewEventArgs
		Inherits ControlEventArgs

		' Token: 0x06003F00 RID: 16128 RVA: 0x001B2AEC File Offset: 0x001B0CEC
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As Foxtable.WinForm.TreeNode)
			MyBase.New(A_0, A_1)
			Me.O_.oOO_oO_. = A_2
		End Sub

		' Token: 0x17000DB8 RID: 3512
		' (get) Token: 0x06003F01 RID: 16129 RVA: 0x001B2AFD File Offset: 0x001B0CFD
		Public ReadOnly Property Node As Foxtable.WinForm.TreeNode
			Get
				Return Me.O_.oOO_oO_.
			End Get
		End Property

		' Token: 0x0400198D RID: 6541
		Private <<EMPTY_NAME>> As Foxtable.WinForm.TreeNode
	End Class
End Namespace
