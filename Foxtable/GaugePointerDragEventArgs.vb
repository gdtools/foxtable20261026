Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200014E RID: 334
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GaugePointerDragEventArgs
		Inherits GaugeItemMouseEventArgs

		' Token: 0x06000F8E RID: 3982 RVA: 0x00068E06 File Offset: 0x00067006
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As PointerDragEventArgs)
			MyBase.New(A_0, A_1, A_2)
			Me.O0_O0_.O. = A_2
		End Sub

		' Token: 0x170002D3 RID: 723
		' (get) Token: 0x06000F8F RID: 3983 RVA: 0x00068E18 File Offset: 0x00067018
		Public ReadOnly Property Pointer As C1GaugePointer
			Get
				Return Me.O0_O0_.O..Pointer
			End Get
		End Property

		' Token: 0x170002D4 RID: 724
		' (get) Token: 0x06000F90 RID: 3984 RVA: 0x00068E25 File Offset: 0x00067025
		Public ReadOnly Property NewValue As Double
			Get
				Return Me.O0_O0_.O..NewValue
			End Get
		End Property

		' Token: 0x040005F6 RID: 1526
		Private <<EMPTY_NAME>> As PointerDragEventArgs
	End Class
End Namespace
