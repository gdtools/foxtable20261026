Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A9 RID: 1193
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonToggleGroupEventArgs
		' Token: 0x06004D8D RID: 19853 RVA: 0x00201B61 File Offset: 0x001FFD61
		Public Sub New(A_0 As ToggleGroup)
			Me.o_000O_o.oOo0. = A_0
		End Sub

		' Token: 0x170011A0 RID: 4512
		' (get) Token: 0x06004D8E RID: 19854 RVA: 0x00201B70 File Offset: 0x001FFD70
		Public ReadOnly Property ToggleGroup As ToggleGroup
			Get
				Return Me.o_000O_o.oOo0.
			End Get
		End Property

		' Token: 0x04002012 RID: 8210
		Private <<EMPTY_NAME>> As ToggleGroup
	End Class
End Namespace
