Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200014C RID: 332
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GaugeItemEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F81 RID: 3969 RVA: 0x00068D54 File Offset: 0x00066F54
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ItemEventArgs)
			MyBase.New(A_0, A_1)
			Me.ooo.0_. = A_2
		End Sub

		' Token: 0x170002C8 RID: 712
		' (get) Token: 0x06000F82 RID: 3970 RVA: 0x00068D65 File Offset: 0x00066F65
		Public ReadOnly Property Gauge As C1GaugeBase
			Get
				Return Me.ooo.0_..Gauge
			End Get
		End Property

		' Token: 0x170002C9 RID: 713
		' (get) Token: 0x06000F83 RID: 3971 RVA: 0x00068D72 File Offset: 0x00066F72
		Public ReadOnly Property Container As C1Gauge
			Get
				Return Me.ooo.0_..Container
			End Get
		End Property

		' Token: 0x170002CA RID: 714
		' (get) Token: 0x06000F84 RID: 3972 RVA: 0x00068D7F File Offset: 0x00066F7F
		Public ReadOnly Property Item As Object
			Get
				Return Me.ooo.0_..Item
			End Get
		End Property

		' Token: 0x170002CB RID: 715
		' (get) Token: 0x06000F85 RID: 3973 RVA: 0x00068D8C File Offset: 0x00066F8C
		Public ReadOnly Property ItemEnabled As Boolean
			Get
				Return Me.ooo.0_..ItemEnabled
			End Get
		End Property

		' Token: 0x170002CC RID: 716
		' (get) Token: 0x06000F86 RID: 3974 RVA: 0x00068D99 File Offset: 0x00066F99
		Public ReadOnly Property ItemHot As Boolean
			Get
				Return Me.ooo.0_..ItemHot
			End Get
		End Property

		' Token: 0x170002CD RID: 717
		' (get) Token: 0x06000F87 RID: 3975 RVA: 0x00068DA6 File Offset: 0x00066FA6
		Public ReadOnly Property ItemPressed As Boolean
			Get
				Return Me.ooo.0_..ItemPressed
			End Get
		End Property

		' Token: 0x040005F4 RID: 1524
		Private <<EMPTY_NAME>> As ItemEventArgs
	End Class
End Namespace
