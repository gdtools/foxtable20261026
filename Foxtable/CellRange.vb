Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1FlexGrid

Namespace Foxtable
	' Token: 0x02000303 RID: 771
	<ComVisible(True)>
	Public Class CellRange
		' Token: 0x0600284A RID: 10314 RVA: 0x0010DCD5 File Offset: 0x0010BED5
		Public Sub New(A_0 As Table, A_1 As CellRange)
			Me.O.OoOo00O_. = A_0
			Me.O.OoOo00O_. = A_1
		End Sub

		' Token: 0x17000954 RID: 2388
		' (get) Token: 0x0600284B RID: 10315 RVA: 0x0010DCEB File Offset: 0x0010BEEB
		Public ReadOnly Property TopRow As Integer
			Get
				Return Me.O.OoOo00O_..TopRow - Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x17000955 RID: 2389
		' (get) Token: 0x0600284C RID: 10316 RVA: 0x0010DD0E File Offset: 0x0010BF0E
		Public ReadOnly Property BottomRow As Integer
			Get
				Return Me.O.OoOo00O_..BottomRow - Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x17000956 RID: 2390
		' (get) Token: 0x0600284D RID: 10317 RVA: 0x0010DD31 File Offset: 0x0010BF31
		Public ReadOnly Property LeftCol As Integer
			Get
				Return Me.O.OoOo00O_..LeftCol - Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Get
		End Property

		' Token: 0x17000957 RID: 2391
		' (get) Token: 0x0600284E RID: 10318 RVA: 0x0010DD54 File Offset: 0x0010BF54
		Public ReadOnly Property RightCol As Integer
			Get
				Return Me.O.OoOo00O_..RightCol - Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Get
		End Property

		' Token: 0x17000958 RID: 2392
		' (get) Token: 0x0600284F RID: 10319 RVA: 0x0010DD77 File Offset: 0x0010BF77
		' (set) Token: 0x06002850 RID: 10320 RVA: 0x0010DD9A File Offset: 0x0010BF9A
		Public Property RowSel As Integer
			Get
				Return Me.O.OoOo00O_..r1 - Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Get
			Set(value As Integer)
				Me.O.OoOo00O_..r1 = value + Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Set
		End Property

		' Token: 0x17000959 RID: 2393
		' (get) Token: 0x06002851 RID: 10321 RVA: 0x0010DDBE File Offset: 0x0010BFBE
		' (set) Token: 0x06002852 RID: 10322 RVA: 0x0010DDE1 File Offset: 0x0010BFE1
		Public Property RowEnd As Integer
			Get
				Return Me.O.OoOo00O_..r2 - Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Get
			Set(value As Integer)
				Me.O.OoOo00O_..r2 = value + Me.O.OoOo00O_..foxGrid.Rows.Fixed
			End Set
		End Property

		' Token: 0x1700095A RID: 2394
		' (get) Token: 0x06002853 RID: 10323 RVA: 0x0010DE05 File Offset: 0x0010C005
		' (set) Token: 0x06002854 RID: 10324 RVA: 0x0010DE28 File Offset: 0x0010C028
		Public Property ColSel As Integer
			Get
				Return Me.O.OoOo00O_..c1 - Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Get
			Set(value As Integer)
				Me.O.OoOo00O_..c1 = value + Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Set
		End Property

		' Token: 0x1700095B RID: 2395
		' (get) Token: 0x06002855 RID: 10325 RVA: 0x0010DE4C File Offset: 0x0010C04C
		' (set) Token: 0x06002856 RID: 10326 RVA: 0x0010DE6F File Offset: 0x0010C06F
		Public Property ColEnd As Integer
			Get
				Return Me.O.OoOo00O_..c2 - Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Get
			Set(value As Integer)
				Me.O.OoOo00O_..c2 = value + Me.O.OoOo00O_..foxGrid.Cols.Fixed
			End Set
		End Property

		' Token: 0x040010AF RID: 4271
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040010B0 RID: 4272
		Private <<EMPTY_NAME>> As CellRange
	End Class
End Namespace
