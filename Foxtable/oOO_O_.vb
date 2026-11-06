Imports System
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200042A RID: 1066
	Friend Class oOO_O_
		Implements O_o_0o

		' Token: 0x06004617 RID: 17943 RVA: 0x001C532A File Offset: 0x001C352A
		Friend Sub New(A_0 As TreeNode, A_1 As ControlHolder)
			Me.Node = A_0
			Me.Holder = A_1
			Me.Index = A_0.Index
		End Sub

		' Token: 0x06004618 RID: 17944 RVA: 0x001C534C File Offset: 0x001C354C
		Friend Sub Undo() Implements Foxtable.O_o_0o.O_OO0.O.
			Dim nodes As TreeNodeCollection
			If Me.Node.Parent Is Nothing Then
				nodes = Me.Node.TreeView.Nodes
			Else
				nodes = Me.Node.Parent.Nodes
			End If
			nodes.Remove(Me.Node)
			nodes.Insert(Me.Index, Me.Node)
			Me.Node.TreeView.SelectedNode = Me.Node
			If Not Me.Holder.Selected Then
				Me.Holder.Selected = True
			End If
		End Sub

		' Token: 0x04001C9E RID: 7326
		Private Node As TreeNode

		' Token: 0x04001C9F RID: 7327
		Private Holder As ControlHolder

		' Token: 0x04001CA0 RID: 7328
		Private Index As Integer
	End Class
End Namespace
