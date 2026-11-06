Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200014F RID: 335
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GaugePointerValueChangedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F91 RID: 3985 RVA: 0x00068E32 File Offset: 0x00067032
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As C1GaugeBase, A_3 As C1Gauge, A_4 As C1GaugePointer)
			MyBase.New(A_0, A_1)
			Me.O0_O0_.O. = A_2
			Me.O0_O0_.O. = A_3
			Me.O0__._0o. = A_4
		End Sub

		' Token: 0x170002D5 RID: 725
		' (get) Token: 0x06000F92 RID: 3986 RVA: 0x00068E53 File Offset: 0x00067053
		Public ReadOnly Property Gauge As C1GaugeBase
			Get
				Return Me.O0_O0_.O.
			End Get
		End Property

		' Token: 0x170002D6 RID: 726
		' (get) Token: 0x06000F93 RID: 3987 RVA: 0x00068E5B File Offset: 0x0006705B
		Public ReadOnly Property Container As C1Gauge
			Get
				Return Me.O0_O0_.O.
			End Get
		End Property

		' Token: 0x170002D7 RID: 727
		' (get) Token: 0x06000F94 RID: 3988 RVA: 0x00068E63 File Offset: 0x00067063
		Public ReadOnly Property Pointer As C1GaugePointer
			Get
				Return Me.O0__._0o.
			End Get
		End Property

		' Token: 0x170002D8 RID: 728
		' (get) Token: 0x06000F95 RID: 3989 RVA: 0x00068E6B File Offset: 0x0006706B
		Public ReadOnly Property IsMainPointer As Boolean
			Get
				Return Me.O0__._0o..IsMainPointer
			End Get
		End Property

		' Token: 0x040005F7 RID: 1527
		Private <<EMPTY_NAME>> As C1GaugeBase

		' Token: 0x040005F8 RID: 1528
		Private <<EMPTY_NAME>> As C1Gauge

		' Token: 0x040005F9 RID: 1529
		Private <<EMPTY_NAME>> As C1GaugePointer
	End Class
End Namespace
