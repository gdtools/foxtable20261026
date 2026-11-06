Imports System
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000429 RID: 1065
	Friend Class o0_00Oo0o
		Implements O_o_0o

		' Token: 0x06004615 RID: 17941 RVA: 0x001C524C File Offset: 0x001C344C
		Friend Sub New(A_0 As TreeNode, A_1 As ControlHolder)
			Me.Node = A_0
			Me.Holder = A_1
			If A_0.Parent Is Nothing Then
				Me.ParentNodes = A_0.TreeView.Nodes
			Else
				Me.ParentNodes = A_0.Parent.Nodes
			End If
			Me.Index = A_0.Index
		End Sub

		' Token: 0x06004616 RID: 17942 RVA: 0x001C52A8 File Offset: 0x001C34A8
		Friend Sub Undo() Implements Foxtable.O_o_0o.O_OO0.O.
			If Me.Node.Parent Is Nothing Then
				Me.Node.TreeView.Nodes.Remove(Me.Node)
			Else
				Me.Node.Parent.Nodes.Remove(Me.Node)
			End If
			Me.ParentNodes.Insert(Me.Index, Me.Node)
			If Not Me.Holder.Selected Then
				Me.Holder.Selected = True
			End If
		End Sub

		' Token: 0x04001C9A RID: 7322
		Private Node As TreeNode

		' Token: 0x04001C9B RID: 7323
		Private Holder As ControlHolder

		' Token: 0x04001C9C RID: 7324
		Private ParentNodes As TreeNodeCollection

		' Token: 0x04001C9D RID: 7325
		Private Index As Integer
	End Class
End Namespace
