Imports System
Imports System.ComponentModel
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x020002E3 RID: 739
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BuildEventArgs
		' Token: 0x06002730 RID: 10032 RVA: 0x0010AB90 File Offset: 0x00108D90
		Public Sub New(A_0 As Book)
			Me.o._0__00_oo. = A_0
		End Sub

		' Token: 0x170008C3 RID: 2243
		' (get) Token: 0x06002731 RID: 10033 RVA: 0x0010AB9F File Offset: 0x00108D9F
		Public ReadOnly Property Book As Book
			Get
				Return Me.o._0__00_oo.
			End Get
		End Property

		' Token: 0x04001037 RID: 4151
		Private <<EMPTY_NAME>> As Book
	End Class
End Namespace
