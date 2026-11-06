Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AC RID: 1196
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ContextMenuEventArgs
		' Token: 0x06004D93 RID: 19859 RVA: 0x00201BA6 File Offset: 0x001FFDA6
		Public Sub New(A_0 As ContextMenu)
			Me.Oo_oo.O0O_0OO0. = A_0
		End Sub

		' Token: 0x170011A3 RID: 4515
		' (get) Token: 0x06004D94 RID: 19860 RVA: 0x00201BB5 File Offset: 0x001FFDB5
		Public ReadOnly Property ContextMenu As ContextMenu
			Get
				Return Me.Oo_oo.O0O_0OO0.
			End Get
		End Property

		' Token: 0x04002015 RID: 8213
		Private <<EMPTY_NAME>> As ContextMenu
	End Class
End Namespace
