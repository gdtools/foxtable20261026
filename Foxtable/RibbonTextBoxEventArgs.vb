Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x0200049F RID: 1183
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTextBoxEventArgs
		' Token: 0x06004D78 RID: 19832 RVA: 0x00201A73 File Offset: 0x001FFC73
		Public Sub New(A_0 As TextBox)
			Me.OOoo_o00.O___0. = A_0
		End Sub

		' Token: 0x17001195 RID: 4501
		' (get) Token: 0x06004D79 RID: 19833 RVA: 0x00201A82 File Offset: 0x001FFC82
		Public ReadOnly Property TextBox As TextBox
			Get
				Return Me.OOoo_o00.O___0.
			End Get
		End Property

		' Token: 0x17001196 RID: 4502
		' (get) Token: 0x06004D7A RID: 19834 RVA: 0x00201A8A File Offset: 0x001FFC8A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property EditBox As TextBox
			Get
				Return Me.TextBox
			End Get
		End Property

		' Token: 0x04002008 RID: 8200
		Private <<EMPTY_NAME>> As TextBox
	End Class
End Namespace
