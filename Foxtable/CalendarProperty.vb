Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020002AB RID: 683
	Friend Class CalendarProperty
		Inherits ControlPropertyBase

		' Token: 0x060023FE RID: 9214 RVA: 0x000FA2DB File Offset: 0x000F84DB
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.o___O0O_O. = CType(A_0.ChildControl, MonthCalendar)
		End Sub

		' Token: 0x1700083D RID: 2109
		' (get) Token: 0x060023FF RID: 9215 RVA: 0x000FA2F5 File Offset: 0x000F84F5
		' (set) Token: 0x06002400 RID: 9216 RVA: 0x000FA302 File Offset: 0x000F8502
		<O_Oo00Oo000O0(0.1)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<DisplayName("显示今天")>
		Public Property ShowToday As Boolean
			Get
				Return Me.o.o___O0O_O..ShowToday
			End Get
			Set(value As Boolean)
				Me.o.o___O0O_O..ShowToday = value
			End Set
		End Property

		' Token: 0x1700083E RID: 2110
		' (get) Token: 0x06002401 RID: 9217 RVA: 0x000FA310 File Offset: 0x000F8510
		' (set) Token: 0x06002402 RID: 9218 RVA: 0x000FA31D File Offset: 0x000F851D
		<Category("外观")>
		<O_Oo00Oo000O0(0.2)>
		<DefaultValue(True)>
		<MergableProperty(True)>
		<DisplayName("标出今天")>
		Public Property ShowTodayCircle As Boolean
			Get
				Return Me.o.o___O0O_O..ShowTodayCircle
			End Get
			Set(value As Boolean)
				Me.o.o___O0O_O..ShowTodayCircle = value
			End Set
		End Property

		' Token: 0x1700083F RID: 2111
		' (get) Token: 0x06002403 RID: 9219 RVA: 0x000FA32B File Offset: 0x000F852B
		' (set) Token: 0x06002404 RID: 9220 RVA: 0x000FA338 File Offset: 0x000F8538
		<MergableProperty(True)>
		<DefaultValue(False)>
		<Category("外观")>
		<O_Oo00Oo000O0(0.3)>
		<DisplayName("显示周数")>
		Public Property ShowWeekNumbers As Boolean
			Get
				Return Me.o.o___O0O_O..ShowWeekNumbers
			End Get
			Set(value As Boolean)
				Me.o.o___O0O_O..ShowWeekNumbers = value
			End Set
		End Property

		' Token: 0x17000840 RID: 2112
		' (get) Token: 0x06002405 RID: 9221 RVA: 0x000FA346 File Offset: 0x000F8546
		' (set) Token: 0x06002406 RID: 9222 RVA: 0x000FA353 File Offset: 0x000F8553
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.5)>
		<DisplayName("每周第一天")>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property FirstDayOfWeek As Day
			Get
				Return Me.o.o___O0O_O..FirstDayOfWeek
			End Get
			Set(value As Day)
				Me.o.o___O0O_O..FirstDayOfWeek = value
			End Set
		End Property

		' Token: 0x17000841 RID: 2113
		' (get) Token: 0x06002407 RID: 9223 RVA: 0x000FA364 File Offset: 0x000F8564
		' (set) Token: 0x06002408 RID: 9224 RVA: 0x000FA384 File Offset: 0x000F8584
		<O_Oo00Oo000O0(0.6)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(1)>
		<DisplayName("水平月数")>
		Public Property XMonths As Integer
			Get
				Return Me.o.o___O0O_O..CalendarDimensions.Width
			End Get
			Set(value As Integer)
				Me.o.o___O0O_O..CalendarDimensions = New Size(value, Me.o.o___O0O_O..CalendarDimensions.Height)
			End Set
		End Property

		' Token: 0x17000842 RID: 2114
		' (get) Token: 0x06002409 RID: 9225 RVA: 0x000FA3B8 File Offset: 0x000F85B8
		' (set) Token: 0x0600240A RID: 9226 RVA: 0x000FA3D8 File Offset: 0x000F85D8
		<DefaultValue(1)>
		<O_Oo00Oo000O0(0.7)>
		<MergableProperty(True)>
		<DisplayName("垂直月数")>
		<Category("外观")>
		Public Property YMonths As Integer
			Get
				Return Me.o.o___O0O_O..CalendarDimensions.Height
			End Get
			Set(value As Integer)
				Me.o.o___O0O_O..CalendarDimensions = New Size(Me.o.o___O0O_O..CalendarDimensions.Width, value)
			End Set
		End Property

		' Token: 0x17000843 RID: 2115
		' (get) Token: 0x0600240B RID: 9227 RVA: 0x000FA409 File Offset: 0x000F8609
		' (set) Token: 0x0600240C RID: 9228 RVA: 0x000FA416 File Offset: 0x000F8616
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("标题背景颜色")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(-16777216)>
		Public Property TitleBackColor As Color
			Get
				Return Me.o.o___O0O_O..TitleBackColor
			End Get
			Set(value As Color)
				Me.o.o___O0O_O..TitleBackColor = value
			End Set
		End Property

		' Token: 0x17000844 RID: 2116
		' (get) Token: 0x0600240D RID: 9229 RVA: 0x000FA424 File Offset: 0x000F8624
		' (set) Token: 0x0600240E RID: 9230 RVA: 0x000FA431 File Offset: 0x000F8631
		<DisplayName("标题字体颜色")>
		<O_Oo00Oo000O0(2.2)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(-16777216)>
		Public Property TitleForeColor As Color
			Get
				Return Me.o.o___O0O_O..TitleForeColor
			End Get
			Set(value As Color)
				Me.o.o___O0O_O..TitleForeColor = value
			End Set
		End Property

		' Token: 0x17000845 RID: 2117
		' (get) Token: 0x0600240F RID: 9231 RVA: 0x000FA43F File Offset: 0x000F863F
		' (set) Token: 0x06002410 RID: 9232 RVA: 0x000FA44C File Offset: 0x000F864C
		<Category("外观")>
		<O_Oo00Oo000O0(2.3)>
		<DisplayName("非本月日期颜色")>
		<MergableProperty(True)>
		<DefaultValue(-16777216)>
		Public Property TrailingForeColor As Color
			Get
				Return Me.o.o___O0O_O..TrailingForeColor
			End Get
			Set(value As Color)
				Me.o.o___O0O_O..TrailingForeColor = value
			End Set
		End Property

		' Token: 0x17000846 RID: 2118
		' (get) Token: 0x06002411 RID: 9233 RVA: 0x000FA45A File Offset: 0x000F865A
		' (set) Token: 0x06002412 RID: 9234 RVA: 0x000FA462 File Offset: 0x000F8662
		<oO0oooo("2120")>
		<Description("选定日期发生变化后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property DateChanged As EventString
			Get
				Return Me.OO0_0oOo.o.
			End Get
			Set(value As EventString)
				Me.OO0_0oOo.o. = value
			End Set
		End Property

		' Token: 0x17000847 RID: 2119
		' (get) Token: 0x06002413 RID: 9235 RVA: 0x000FA46B File Offset: 0x000F866B
		' (set) Token: 0x06002414 RID: 9236 RVA: 0x000FA473 File Offset: 0x000F8673
		<Description("用鼠标选定日期后执行")>
		<oO0oooo("2120")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property DateSelected As EventString
			Get
				Return Me.ooO_.0O00.
			End Get
			Set(value As EventString)
				Me.ooO_.0O00. = value
			End Set
		End Property

		' Token: 0x04000EE4 RID: 3812
		Private <<EMPTY_NAME>> As MonthCalendar

		' Token: 0x04000EE5 RID: 3813
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000EE6 RID: 3814
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
