Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004AF RID: 1199
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTimePickerEventArgs
		' Token: 0x06004D99 RID: 19865 RVA: 0x00201BEB File Offset: 0x001FFDEB
		Public Sub New(A_0 As TimePicker)
			Me.o_000O_o.oOo0. = A_0
		End Sub

		' Token: 0x170011A6 RID: 4518
		' (get) Token: 0x06004D9A RID: 19866 RVA: 0x00201BFA File Offset: 0x001FFDFA
		Public ReadOnly Property TimePicker As TimePicker
			Get
				Return Me.o_000O_o.oOo0.
			End Get
		End Property

		' Token: 0x04002018 RID: 8216
		Private <<EMPTY_NAME>> As TimePicker
	End Class
End Namespace
