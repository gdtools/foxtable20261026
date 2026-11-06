Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000146 RID: 326
	Public Class ChartEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F62 RID: 3938 RVA: 0x00068984 File Offset: 0x00066B84
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form)
			MyBase.New(A_0, A_1)
			Me.o.OO. = -1
			Me.o0OO.000_o. = -1
			Me.O.o_Ooooo0OO_. = -1
			Me.o.OO. = CType(A_0, C1Chart)
			Dim num As Integer = -1
			Dim p As Point = System.Windows.Forms.Control.MousePosition
			p = Me.o.OO..PointToClient(p)
			Me.ooo_.Oo_. = p.X
			Me.O.0oO. = p.Y
			If Me.o.OO..ChartGroups(0).CoordToDataIndex(p.X, p.Y, 2, Me.o.OO., Me.o0OO.000_o., num) Then
				If num <= 6 Then
					Me.O.o_Ooooo0OO_. = 0
					Return
				End If
				Me.o.OO. = -1
				Me.o0OO.000_o. = -1
			End If
			If Me.o.OO..ChartGroups(1).CoordToDataIndex(p.X, p.Y, 2, Me.o.OO., Me.o0OO.000_o., num) Then
				If num <= 6 Then
					Me.O.o_Ooooo0OO_. = 1
					Return
				End If
				Me.o.OO. = -1
				Me.o0OO.000_o. = -1
			End If
		End Sub

		' Token: 0x170002B3 RID: 691
		' (get) Token: 0x06000F63 RID: 3939 RVA: 0x00068A87 File Offset: 0x00066C87
		Public ReadOnly Property SeriesIndex As Integer
			Get
				Return Me.o.OO.
			End Get
		End Property

		' Token: 0x170002B4 RID: 692
		' (get) Token: 0x06000F64 RID: 3940 RVA: 0x00068A8F File Offset: 0x00066C8F
		Public ReadOnly Property PointsIndex As Integer
			Get
				Return Me.o0OO.000_o.
			End Get
		End Property

		' Token: 0x170002B5 RID: 693
		' (get) Token: 0x06000F65 RID: 3941 RVA: 0x00068A97 File Offset: 0x00066C97
		Public ReadOnly Property GroupsIndex As Integer
			Get
				Return Me.O.o_Ooooo0OO_.
			End Get
		End Property

		' Token: 0x170002B6 RID: 694
		' (get) Token: 0x06000F66 RID: 3942 RVA: 0x00068A9F File Offset: 0x00066C9F
		Public ReadOnly Property X As Integer
			Get
				Return Me.ooo_.Oo_.
			End Get
		End Property

		' Token: 0x170002B7 RID: 695
		' (get) Token: 0x06000F67 RID: 3943 RVA: 0x00068AA7 File Offset: 0x00066CA7
		Public ReadOnly Property Y As Integer
			Get
				Return Me.O.0oO.
			End Get
		End Property

		' Token: 0x040005E3 RID: 1507
		Private <<EMPTY_NAME>> As C1Chart

		' Token: 0x040005E4 RID: 1508
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005E5 RID: 1509
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005E6 RID: 1510
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005E7 RID: 1511
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005E8 RID: 1512
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
