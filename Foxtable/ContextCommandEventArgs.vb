Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AD RID: 1197
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ContextCommandEventArgs
		' Token: 0x06004D95 RID: 19861 RVA: 0x00201BBD File Offset: 0x001FFDBD
		Public Sub New(A_0 As ContextCommand)
			Me.oOO_._0_00ooo. = A_0
		End Sub

		' Token: 0x170011A4 RID: 4516
		' (get) Token: 0x06004D96 RID: 19862 RVA: 0x00201BCC File Offset: 0x001FFDCC
		Public ReadOnly Property Command As ContextCommand
			Get
				Return Me.oOO_._0_00ooo.
			End Get
		End Property

		' Token: 0x04002016 RID: 8214
		Private <<EMPTY_NAME>> As ContextCommand
	End Class
End Namespace
