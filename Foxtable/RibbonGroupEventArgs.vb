Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A7 RID: 1191
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonGroupEventArgs
		' Token: 0x06004D89 RID: 19849 RVA: 0x00201B33 File Offset: 0x001FFD33
		Public Sub New(A_0 As Group)
			Me.O0o._0o_O. = A_0
		End Sub

		' Token: 0x1700119E RID: 4510
		' (get) Token: 0x06004D8A RID: 19850 RVA: 0x00201B42 File Offset: 0x001FFD42
		Public ReadOnly Property Group As Group
			Get
				Return Me.O0o._0o_O.
			End Get
		End Property

		' Token: 0x04002010 RID: 8208
		Private <<EMPTY_NAME>> As Group
	End Class
End Namespace
