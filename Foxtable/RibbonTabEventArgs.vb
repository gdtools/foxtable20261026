Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AA RID: 1194
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTabEventArgs
		' Token: 0x06004D8F RID: 19855 RVA: 0x00201B78 File Offset: 0x001FFD78
		Public Sub New(A_0 As Tab)
			Me.O0oo0.o. = A_0
		End Sub

		' Token: 0x170011A1 RID: 4513
		' (get) Token: 0x06004D90 RID: 19856 RVA: 0x00201B87 File Offset: 0x001FFD87
		Public ReadOnly Property Tab As Tab
			Get
				Return Me.O0oo0.o.
			End Get
		End Property

		' Token: 0x04002013 RID: 8211
		Private <<EMPTY_NAME>> As Tab
	End Class
End Namespace
