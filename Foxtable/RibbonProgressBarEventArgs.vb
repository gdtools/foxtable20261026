Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A2 RID: 1186
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonProgressBarEventArgs
		' Token: 0x06004D7F RID: 19839 RVA: 0x00201AC0 File Offset: 0x001FFCC0
		Public Sub New(A_0 As ProgressBar)
			Me.O._oo0__0o. = A_0
		End Sub

		' Token: 0x17001199 RID: 4505
		' (get) Token: 0x06004D80 RID: 19840 RVA: 0x00201ACF File Offset: 0x001FFCCF
		Public ReadOnly Property ProgressBar As ProgressBar
			Get
				Return Me.O._oo0__0o.
			End Get
		End Property

		' Token: 0x0400200B RID: 8203
		Private <<EMPTY_NAME>> As ProgressBar
	End Class
End Namespace
