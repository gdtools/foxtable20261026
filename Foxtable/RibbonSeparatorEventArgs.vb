Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AB RID: 1195
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonSeparatorEventArgs
		' Token: 0x06004D91 RID: 19857 RVA: 0x00201B8F File Offset: 0x001FFD8F
		Public Sub New(A_0 As Separator)
			Me.O._oo0__0o. = A_0
		End Sub

		' Token: 0x170011A2 RID: 4514
		' (get) Token: 0x06004D92 RID: 19858 RVA: 0x00201B9E File Offset: 0x001FFD9E
		Public ReadOnly Property Separator As Separator
			Get
				Return Me.O._oo0__0o.
			End Get
		End Property

		' Token: 0x04002014 RID: 8212
		Private <<EMPTY_NAME>> As Separator
	End Class
End Namespace
