Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x0200049C RID: 1180
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonSplitButtonEventArgs
		' Token: 0x06004D72 RID: 19826 RVA: 0x00201A2E File Offset: 0x001FFC2E
		Public Sub New(A_0 As SplitButton)
			Me.O._oo0__0o. = A_0
		End Sub

		' Token: 0x17001192 RID: 4498
		' (get) Token: 0x06004D73 RID: 19827 RVA: 0x00201A3D File Offset: 0x001FFC3D
		Public ReadOnly Property SplitButton As SplitButton
			Get
				Return Me.O._oo0__0o.
			End Get
		End Property

		' Token: 0x04002005 RID: 8197
		Private <<EMPTY_NAME>> As SplitButton
	End Class
End Namespace
