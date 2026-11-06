Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x020004B0 RID: 1200
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTrackBarEventArgs
		' Token: 0x06004D9B RID: 19867 RVA: 0x00201C02 File Offset: 0x001FFE02
		Public Sub New(A_0 As TrackBar)
			Me.O0.o0__OOo00O. = A_0
		End Sub

		' Token: 0x170011A7 RID: 4519
		' (get) Token: 0x06004D9C RID: 19868 RVA: 0x00201C11 File Offset: 0x001FFE11
		Public ReadOnly Property TrackBar As TrackBar
			Get
				Return Me.O0.o0__OOo00O.
			End Get
		End Property

		' Token: 0x04002019 RID: 8217
		Private <<EMPTY_NAME>> As TrackBar
	End Class
End Namespace
