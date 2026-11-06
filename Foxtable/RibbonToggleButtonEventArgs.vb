Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x0200049B RID: 1179
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonToggleButtonEventArgs
		' Token: 0x06004D70 RID: 19824 RVA: 0x00201A17 File Offset: 0x001FFC17
		Public Sub New(A_0 As ToggleButton)
			Me.o_000O_o.oOo0. = A_0
		End Sub

		' Token: 0x17001191 RID: 4497
		' (get) Token: 0x06004D71 RID: 19825 RVA: 0x00201A26 File Offset: 0x001FFC26
		Public ReadOnly Property ToggleButton As ToggleButton
			Get
				Return Me.o_000O_o.oOo0.
			End Get
		End Property

		' Token: 0x04002004 RID: 8196
		Private <<EMPTY_NAME>> As ToggleButton
	End Class
End Namespace
