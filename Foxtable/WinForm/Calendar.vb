Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x020004F9 RID: 1273
	<oO0oooo("2119")>
	<ComVisible(True)>
	Public Class Calendar
		Inherits Control

		' Token: 0x060051A0 RID: 20896 RVA: 0x0021AE8D File Offset: 0x0021908D
		Public Sub New(A_0 As MonthCalendar)
			MyBase.New(A_0, ControlTypeEnum.Calendar)
			Me.OOoo0_0.0__OO. = A_0
		End Sub

		' Token: 0x170012B8 RID: 4792
		' (get) Token: 0x060051A1 RID: 20897 RVA: 0x0021AE9F File Offset: 0x0021909F
		' (set) Token: 0x060051A2 RID: 20898 RVA: 0x0021AEAC File Offset: 0x002190AC
		Public Property ShowToday As Boolean
			Get
				Return Me.OOoo0_0.0__OO..ShowToday
			End Get
			Set(value As Boolean)
				Me.OOoo0_0.0__OO..ShowToday = value
			End Set
		End Property

		' Token: 0x170012B9 RID: 4793
		' (get) Token: 0x060051A3 RID: 20899 RVA: 0x0021AEBA File Offset: 0x002190BA
		' (set) Token: 0x060051A4 RID: 20900 RVA: 0x0021AEC7 File Offset: 0x002190C7
		Public Property ShowTodayCircle As Boolean
			Get
				Return Me.OOoo0_0.0__OO..ShowTodayCircle
			End Get
			Set(value As Boolean)
				Me.OOoo0_0.0__OO..ShowTodayCircle = value
			End Set
		End Property

		' Token: 0x170012BA RID: 4794
		' (get) Token: 0x060051A5 RID: 20901 RVA: 0x0021AED5 File Offset: 0x002190D5
		' (set) Token: 0x060051A6 RID: 20902 RVA: 0x0021AEE2 File Offset: 0x002190E2
		Public Property ShowWeekNumbers As Boolean
			Get
				Return Me.OOoo0_0.0__OO..ShowWeekNumbers
			End Get
			Set(value As Boolean)
				Me.OOoo0_0.0__OO..ShowWeekNumbers = value
			End Set
		End Property

		' Token: 0x170012BB RID: 4795
		' (get) Token: 0x060051A7 RID: 20903 RVA: 0x0021AEF0 File Offset: 0x002190F0
		' (set) Token: 0x060051A8 RID: 20904 RVA: 0x0021AEFD File Offset: 0x002190FD
		Public Property MaxSelectionCount As Integer
			Get
				Return Me.OOoo0_0.0__OO..MaxSelectionCount
			End Get
			Set(value As Integer)
				Me.OOoo0_0.0__OO..MaxSelectionCount = value
			End Set
		End Property

		' Token: 0x170012BC RID: 4796
		' (get) Token: 0x060051A9 RID: 20905 RVA: 0x0021AF0B File Offset: 0x0021910B
		' (set) Token: 0x060051AA RID: 20906 RVA: 0x0021AF18 File Offset: 0x00219118
		Public Property FirstDayOfWeek As Day
			Get
				Return Me.OOoo0_0.0__OO..FirstDayOfWeek
			End Get
			Set(value As Day)
				Me.OOoo0_0.0__OO..FirstDayOfWeek = value
			End Set
		End Property

		' Token: 0x170012BD RID: 4797
		' (get) Token: 0x060051AB RID: 20907 RVA: 0x0021AF28 File Offset: 0x00219128
		' (set) Token: 0x060051AC RID: 20908 RVA: 0x0021AF48 File Offset: 0x00219148
		Public Property XMonths As Integer
			Get
				Return Me.OOoo0_0.0__OO..CalendarDimensions.Width
			End Get
			Set(value As Integer)
				Me.OOoo0_0.0__OO..CalendarDimensions = New Size(value, Me.OOoo0_0.0__OO..CalendarDimensions.Height)
			End Set
		End Property

		' Token: 0x170012BE RID: 4798
		' (get) Token: 0x060051AD RID: 20909 RVA: 0x0021AF7C File Offset: 0x0021917C
		' (set) Token: 0x060051AE RID: 20910 RVA: 0x0021AF9C File Offset: 0x0021919C
		Public Property YMonths As Integer
			Get
				Return Me.OOoo0_0.0__OO..CalendarDimensions.Height
			End Get
			Set(value As Integer)
				Me.OOoo0_0.0__OO..CalendarDimensions = New Size(Me.OOoo0_0.0__OO..CalendarDimensions.Width, value)
			End Set
		End Property

		' Token: 0x170012BF RID: 4799
		' (get) Token: 0x060051AF RID: 20911 RVA: 0x0021AFCD File Offset: 0x002191CD
		' (set) Token: 0x060051B0 RID: 20912 RVA: 0x0021AFDA File Offset: 0x002191DA
		Public Property TitleBackColor As Color
			Get
				Return Me.OOoo0_0.0__OO..TitleBackColor
			End Get
			Set(value As Color)
				Me.OOoo0_0.0__OO..TitleBackColor = value
			End Set
		End Property

		' Token: 0x170012C0 RID: 4800
		' (get) Token: 0x060051B1 RID: 20913 RVA: 0x0021AFE8 File Offset: 0x002191E8
		' (set) Token: 0x060051B2 RID: 20914 RVA: 0x0021AFF5 File Offset: 0x002191F5
		Public Property TitleForeColor As Color
			Get
				Return Me.OOoo0_0.0__OO..TitleForeColor
			End Get
			Set(value As Color)
				Me.OOoo0_0.0__OO..TitleForeColor = value
			End Set
		End Property

		' Token: 0x170012C1 RID: 4801
		' (get) Token: 0x060051B3 RID: 20915 RVA: 0x0021B003 File Offset: 0x00219203
		' (set) Token: 0x060051B4 RID: 20916 RVA: 0x0021B010 File Offset: 0x00219210
		Public Property TrailingForeColor As Color
			Get
				Return Me.OOoo0_0.0__OO..TrailingForeColor
			End Get
			Set(value As Color)
				Me.OOoo0_0.0__OO..TrailingForeColor = value
			End Set
		End Property

		' Token: 0x170012C2 RID: 4802
		' (get) Token: 0x060051B5 RID: 20917 RVA: 0x0021B01E File Offset: 0x0021921E
		' (set) Token: 0x060051B6 RID: 20918 RVA: 0x0021B02B File Offset: 0x0021922B
		Public Overridable Property Width As Integer
			Get
				Return Me.OOoo0_0.0__OO..Width
			End Get
			Set(value As Integer)
			End Set
		End Property

		' Token: 0x170012C3 RID: 4803
		' (get) Token: 0x060051B7 RID: 20919 RVA: 0x0021B02D File Offset: 0x0021922D
		' (set) Token: 0x060051B8 RID: 20920 RVA: 0x0021B03A File Offset: 0x0021923A
		Public Overridable Property Height As Integer
			Get
				Return Me.OOoo0_0.0__OO..Height
			End Get
			Set(value As Integer)
			End Set
		End Property

		' Token: 0x170012C4 RID: 4804
		' (get) Token: 0x060051B9 RID: 20921 RVA: 0x0021B03C File Offset: 0x0021923C
		' (set) Token: 0x060051BA RID: 20922 RVA: 0x0021B049 File Offset: 0x00219249
		Public Property Value As DateTime
			Get
				Return Me.OOoo0_0.0__OO..SelectionStart
			End Get
			Set(value As DateTime)
				Me.OOoo0_0.0__OO..SelectionStart = value
			End Set
		End Property

		' Token: 0x040021B6 RID: 8630
		Private <<EMPTY_NAME>> As MonthCalendar
	End Class
End Namespace
