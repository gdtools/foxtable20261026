Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x0200049E RID: 1182
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonMenuButtonEventArgs
		' Token: 0x06004D76 RID: 19830 RVA: 0x00201A5C File Offset: 0x001FFC5C
		Public Sub New(A_0 As MenuButton)
			Me.O.oOOO. = A_0
		End Sub

		' Token: 0x17001194 RID: 4500
		' (get) Token: 0x06004D77 RID: 19831 RVA: 0x00201A6B File Offset: 0x001FFC6B
		Public ReadOnly Property MenuButton As MenuButton
			Get
				Return Me.O.oOOO.
			End Get
		End Property

		' Token: 0x04002007 RID: 8199
		Private <<EMPTY_NAME>> As MenuButton
	End Class
End Namespace
