Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A8 RID: 1192
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonToolBarEventArgs
		' Token: 0x06004D8B RID: 19851 RVA: 0x00201B4A File Offset: 0x001FFD4A
		Public Sub New(A_0 As ToolBar)
			Me.o00o.0o0_0. = A_0
		End Sub

		' Token: 0x1700119F RID: 4511
		' (get) Token: 0x06004D8C RID: 19852 RVA: 0x00201B59 File Offset: 0x001FFD59
		Public ReadOnly Property ToolBar As ToolBar
			Get
				Return Me.o00o.0o0_0.
			End Get
		End Property

		' Token: 0x04002011 RID: 8209
		Private <<EMPTY_NAME>> As ToolBar
	End Class
End Namespace
