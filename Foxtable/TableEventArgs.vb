Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002FA RID: 762
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TableEventArgs
		' Token: 0x060027EA RID: 10218 RVA: 0x0010BB06 File Offset: 0x00109D06
		Public Sub New(A_0 As Table)
			Me.o0O0Oo.OoO_. = A_0
		End Sub

		' Token: 0x1700093D RID: 2365
		' (get) Token: 0x060027EB RID: 10219 RVA: 0x0010BB15 File Offset: 0x00109D15
		Public ReadOnly Property Table As Table
			Get
				Return Me.o0O0Oo.OoO_.
			End Get
		End Property

		' Token: 0x1700093E RID: 2366
		' (get) Token: 0x060027EC RID: 10220 RVA: 0x0010BB1D File Offset: 0x00109D1D
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001090 RID: 4240
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
