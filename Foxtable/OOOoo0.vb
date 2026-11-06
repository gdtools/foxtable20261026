Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200042B RID: 1067
	Friend Class OOOoo0
		Implements O_o_0o

		' Token: 0x06004619 RID: 17945 RVA: 0x001C53D8 File Offset: 0x001C35D8
		Friend Sub New(A_0 As String, A_1 As TreeNode, A_2 As PropertyBase)
			Me.Node = A_1
			Me.Obj = A_2
			Me.PropertyName = A_0
			Dim [property] As PropertyInfo = A_2.[GetType]().GetProperty(A_0)
			Me.Value = RuntimeHelpers.GetObjectValue([property].GetValue(A_2, Nothing))
		End Sub

		' Token: 0x0600461A RID: 17946 RVA: 0x001C5420 File Offset: 0x001C3620
		Friend Sub Undo() Implements Foxtable.O_o_0o.O_OO0.O.
			Dim treeView As TreeView = CType(Me.Obj.Holder.ChildControl, TreeView)
			If treeView.SelectedNode IsNot Me.Node Then
				treeView.SelectedNode = Me.Node
				Application.DoEvents()
			End If
			Me.Obj.[GetType]().GetProperty(Me.PropertyName).SetValue(Me.Obj, RuntimeHelpers.GetObjectValue(Me.Value), Nothing)
			If Not Me.Obj.Holder.Selected Then
				Me.Obj.Holder.Selected = True
			End If
		End Sub

		' Token: 0x04001CA1 RID: 7329
		Private PropertyName As String

		' Token: 0x04001CA2 RID: 7330
		Private Node As TreeNode

		' Token: 0x04001CA3 RID: 7331
		Private Obj As PropertyBase

		' Token: 0x04001CA4 RID: 7332
		Private Value As Object
	End Class
End Namespace
