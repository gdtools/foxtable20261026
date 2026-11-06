Imports System
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000423 RID: 1059
	Friend Class ParentChildPair
		' Token: 0x06004606 RID: 17926 RVA: 0x001C4F4F File Offset: 0x001C314F
		Friend Sub New(A_0 As ControlHolder)
			Me.Holder = A_0
			Me.Parent = A_0.Parent
		End Sub

		' Token: 0x04001C8B RID: 7307
		Friend Holder As ControlHolder

		' Token: 0x04001C8C RID: 7308
		Friend Parent As Control
	End Class
End Namespace
