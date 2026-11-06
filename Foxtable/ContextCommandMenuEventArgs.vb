Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AE RID: 1198
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ContextCommandMenuEventArgs
		' Token: 0x06004D97 RID: 19863 RVA: 0x00201BD4 File Offset: 0x001FFDD4
		Public Sub New(A_0 As ContextCommandMenu)
			Me.Oo_oo.O0O_0OO0. = A_0
		End Sub

		' Token: 0x170011A5 RID: 4517
		' (get) Token: 0x06004D98 RID: 19864 RVA: 0x00201BE3 File Offset: 0x001FFDE3
		Public ReadOnly Property CommandMenu As ContextCommandMenu
			Get
				Return Me.Oo_oo.O0O_0OO0.
			End Get
		End Property

		' Token: 0x04002017 RID: 8215
		Private <<EMPTY_NAME>> As ContextCommandMenu
	End Class
End Namespace
