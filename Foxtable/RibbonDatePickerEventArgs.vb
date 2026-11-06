Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004A0 RID: 1184
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonDatePickerEventArgs
		' Token: 0x06004D7B RID: 19835 RVA: 0x00201A92 File Offset: 0x001FFC92
		Public Sub New(A_0 As DatePicker)
			Me.OO_._O0. = A_0
		End Sub

		' Token: 0x17001197 RID: 4503
		' (get) Token: 0x06004D7C RID: 19836 RVA: 0x00201AA1 File Offset: 0x001FFCA1
		Public ReadOnly Property DatePicker As DatePicker
			Get
				Return Me.OO_._O0.
			End Get
		End Property

		' Token: 0x04002009 RID: 8201
		Private <<EMPTY_NAME>> As DatePicker
	End Class
End Namespace
