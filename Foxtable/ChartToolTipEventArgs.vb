Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000149 RID: 329
	Public Class ChartToolTipEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F73 RID: 3955 RVA: 0x00068BF3 File Offset: 0x00066DF3
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ShowTooltipEventArgs)
			MyBase.New(A_0, A_1)
			Me.O_O0_.__O. = A_2
		End Sub

		' Token: 0x170002C0 RID: 704
		' (get) Token: 0x06000F74 RID: 3956 RVA: 0x00068C04 File Offset: 0x00066E04
		' (set) Token: 0x06000F75 RID: 3957 RVA: 0x00068C11 File Offset: 0x00066E11
		Public Property ToolTipText As String
			Get
				Return Me.O_O0_.__O..TooltipText
			End Get
			Set(value As String)
				Me.O_O0_.__O..TooltipText = value
			End Set
		End Property

		' Token: 0x170002C1 RID: 705
		' (get) Token: 0x06000F76 RID: 3958 RVA: 0x00068C1F File Offset: 0x00066E1F
		Public ReadOnly Property GroupIndex As Integer
			Get
				Return Me.O_O0_.__O..GroupIndex
			End Get
		End Property

		' Token: 0x170002C2 RID: 706
		' (get) Token: 0x06000F77 RID: 3959 RVA: 0x00068C2C File Offset: 0x00066E2C
		Public ReadOnly Property SeriesIndex As Integer
			Get
				Return Me.O_O0_.__O..SeriesIndex
			End Get
		End Property

		' Token: 0x170002C3 RID: 707
		' (get) Token: 0x06000F78 RID: 3960 RVA: 0x00068C39 File Offset: 0x00066E39
		Public ReadOnly Property PointIndex As Integer
			Get
				Return Me.O_O0_.__O..PointIndex
			End Get
		End Property

		' Token: 0x040005F0 RID: 1520
		Private <<EMPTY_NAME>> As ShowTooltipEventArgs
	End Class
End Namespace
