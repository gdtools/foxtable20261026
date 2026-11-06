Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A1 RID: 1185
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonNumericBoxEventArgs
		' Token: 0x06004D7D RID: 19837 RVA: 0x00201AA9 File Offset: 0x001FFCA9
		Public Sub New(A_0 As NumericBox)
			Me.o0_.OO. = A_0
		End Sub

		' Token: 0x17001198 RID: 4504
		' (get) Token: 0x06004D7E RID: 19838 RVA: 0x00201AB8 File Offset: 0x001FFCB8
		Public ReadOnly Property NumericBox As NumericBox
			Get
				Return Me.o0_.OO.
			End Get
		End Property

		' Token: 0x0400200A RID: 8202
		Private <<EMPTY_NAME>> As NumericBox
	End Class
End Namespace
