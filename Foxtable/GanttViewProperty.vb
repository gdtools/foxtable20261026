Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1GanttView

Namespace Foxtable
	' Token: 0x02000166 RID: 358
	Friend Class GanttViewProperty
		Inherits ControlPropertyBase

		' Token: 0x06000FEE RID: 4078 RVA: 0x00069A8E File Offset: 0x00067C8E
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O0_oO0.o_o. = CType(A_0.ChildControl, GanttView)
		End Sub

		' Token: 0x170002FF RID: 767
		' (get) Token: 0x06000FEF RID: 4079 RVA: 0x00069AA8 File Offset: 0x00067CA8
		' (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00069AE8 File Offset: 0x00067CE8
		<Browsable(False)>
		Public Property Settings As String
			Get
				Dim tempFileName As String = Path.GetTempFileName()
				Me.O0_oO0.o_o..SaveXml(tempFileName, Encoding.UTF8)
				Dim result As String = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.UTF8)
				OO_00oOO.FileSys.DeleteFile(tempFileName)
				Return result
			End Get
			Set(value As String)
				CType(Me.O0_oO0.o_o., ISupportInitialize).BeginInit()
				Me.O0_oO0.o_o..BeginUpdate()
				Dim xmlDocument As XmlDocument = New XmlDocument()
				xmlDocument.LoadXml(value)
				Me.O0_oO0.o_o..LoadXml(xmlDocument)
				Me.O0_oO0.o_o..EndUpdate()
				CType(Me.O0_oO0.o_o., ISupportInitialize).EndInit()
			End Set
		End Property

		' Token: 0x17000300 RID: 768
		' (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00069B3A File Offset: 0x00067D3A
		<Editor("C1.Win.C1GanttView.Design.ColumnCollectionEditor, C1.Win.C1GanttView.4.Design", GetType(UITypeEditor))>
		<OooO0(True)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<DisplayName("表格列")>
		<O_Oo00Oo000O0(5.0)>
		<Category("基本")>
		Public ReadOnly Property Columns As ColumnCollection
			Get
				Return Me.O0_oO0.o_o..Columns
			End Get
		End Property

		' Token: 0x17000301 RID: 769
		' (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00069B47 File Offset: 0x00067D47
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<Category("基本")>
		<DisplayName("默认样式")>
		<OooO0(True)>
		<Editor("C1.Win.C1GanttView.Design.BarStyleCollectionEditor, C1.Win.C1GanttView.4.Design", GetType(UITypeEditor))>
		<O_Oo00Oo000O0(6.0)>
		Public ReadOnly Property BarStyles As BarStyleCollection
			Get
				Return Me.O0_oO0.o_o..BarStyles
			End Get
		End Property

		' Token: 0x17000302 RID: 770
		' (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00069B54 File Offset: 0x00067D54
		' (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00069B61 File Offset: 0x00067D61
		<Category("基本")>
		<DisplayName("表格宽度")>
		<O_Oo00Oo000O0(6.9)>
		<OooO0(True)>
		Public Property GridWidth As Integer
			Get
				Return Me.O0_oO0.o_o..GridWidth
			End Get
			Set(value As Integer)
				Me.O0_oO0.o_o..GridWidth = value
			End Set
		End Property

		' Token: 0x17000303 RID: 771
		' (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00069B6F File Offset: 0x00067D6F
		' (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00069B7C File Offset: 0x00067D7C
		<Category("基本")>
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("显示工具栏")>
		Public Property ShowToolBar As Boolean
			Get
				Return Me.O0_oO0.o_o..ShowToolbar
			End Get
			Set(value As Boolean)
				Me.O0_oO0.o_o..ShowToolbar = value
			End Set
		End Property

		' Token: 0x17000304 RID: 772
		' (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00069B8A File Offset: 0x00067D8A
		' (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00069B97 File Offset: 0x00067D97
		<OooO0(True)>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DisplayName("边框")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O0_oO0.o_o..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O0_oO0.o_o..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000305 RID: 773
		' (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00069BA5 File Offset: 0x00067DA5
		' (set) Token: 0x06000FFA RID: 4090 RVA: 0x00069BB2 File Offset: 0x00067DB2
		<Description("显示前驱任务和后续任务之间的连接线")>
		<O_Oo00Oo000O0(1.0)>
		<Category("配色")>
		<OooO0(True)>
		Public Property ShowLinks As Boolean
			Get
				Return Me.O0_oO0.o_o..ShowLinks
			End Get
			Set(value As Boolean)
				Me.O0_oO0.o_o..ShowLinks = value
			End Set
		End Property

		' Token: 0x17000306 RID: 774
		' (get) Token: 0x06000FFB RID: 4091 RVA: 0x00069BC0 File Offset: 0x00067DC0
		' (set) Token: 0x06000FFC RID: 4092 RVA: 0x00069BCD File Offset: 0x00067DCD
		<Description("是否用不同的背景颜色绘制非工作日")>
		<O_Oo00Oo000O0(2.0)>
		<Category("配色")>
		<OooO0(True)>
		Public Property ShowNonworkingTime As Boolean
			Get
				Return Me.O0_oO0.o_o..ShowNonworkingTime
			End Get
			Set(value As Boolean)
				Me.O0_oO0.o_o..ShowNonworkingTime = value
			End Set
		End Property

		' Token: 0x17000307 RID: 775
		' (get) Token: 0x06000FFD RID: 4093 RVA: 0x00069BDB File Offset: 0x00067DDB
		' (set) Token: 0x06000FFE RID: 4094 RVA: 0x00069BE8 File Offset: 0x00067DE8
		<Category("配色")>
		<OooO0(True)>
		<Description("是否高亮显示项目的起始日期和结束日期")>
		<O_Oo00Oo000O0(3.0)>
		Public Property ShowStartFinish As Boolean
			Get
				Return Me.O0_oO0.o_o..ShowStartFinish
			End Get
			Set(value As Boolean)
				Me.O0_oO0.o_o..ShowStartFinish = value
			End Set
		End Property

		' Token: 0x17000308 RID: 776
		' (get) Token: 0x06000FFF RID: 4095 RVA: 0x00069BF6 File Offset: 0x00067DF6
		' (set) Token: 0x06001000 RID: 4096 RVA: 0x00069C03 File Offset: 0x00067E03
		<O_Oo00Oo000O0(4.0)>
		<Description("是否高亮显示今天的日期")>
		<OooO0(True)>
		<Category("配色")>
		Public Property ShowToday As Boolean
			Get
				Return Me.O0_oO0.o_o..ShowToday
			End Get
			Set(value As Boolean)
				Me.O0_oO0.o_o..ShowToday = value
			End Set
		End Property

		' Token: 0x17000309 RID: 777
		' (get) Token: 0x06001001 RID: 4097 RVA: 0x00069C11 File Offset: 0x00067E11
		' (set) Token: 0x06001002 RID: 4098 RVA: 0x00069C1E File Offset: 0x00067E1E
		<O_Oo00Oo000O0(5.0)>
		<Description("任务条文本字体")>
		<OooO0(True)>
		<Category("配色")>
		Public Property BarTextFont As Font
			Get
				Return Me.O0_oO0.o_o..BarTextFont
			End Get
			Set(value As Font)
				Me.O0_oO0.o_o..BarTextFont = value
			End Set
		End Property

		' Token: 0x1700030A RID: 778
		' (get) Token: 0x06001003 RID: 4099 RVA: 0x00069C2C File Offset: 0x00067E2C
		' (set) Token: 0x06001004 RID: 4100 RVA: 0x00069C39 File Offset: 0x00067E39
		<Category("配色")>
		<O_Oo00Oo000O0(7.2)>
		<Description("表格文字颜色")>
		Public Property GridForeColor As Color
			Get
				Return Me.O0_oO0.o_o..GridForeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..GridForeColor = value
			End Set
		End Property

		' Token: 0x1700030B RID: 779
		' (get) Token: 0x06001005 RID: 4101 RVA: 0x00069C47 File Offset: 0x00067E47
		' (set) Token: 0x06001006 RID: 4102 RVA: 0x00069C54 File Offset: 0x00067E54
		<Category("配色")>
		<Description("列标题和行号颜色")>
		<O_Oo00Oo000O0(8.0)>
		Public Property FixedForeColor As Color
			Get
				Return Me.O0_oO0.o_o..FixedForeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..FixedForeColor = value
			End Set
		End Property

		' Token: 0x1700030C RID: 780
		' (get) Token: 0x06001007 RID: 4103 RVA: 0x00069C62 File Offset: 0x00067E62
		' (set) Token: 0x06001008 RID: 4104 RVA: 0x00069C6F File Offset: 0x00067E6F
		<Description("列标题和行号背景颜色")>
		<Category("配色")>
		<O_Oo00Oo000O0(9.0)>
		Public Property FixedBackColor As Color
			Get
				Return Me.O0_oO0.o_o..FixedBackColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..FixedBackColor = value
			End Set
		End Property

		' Token: 0x1700030D RID: 781
		' (get) Token: 0x06001009 RID: 4105 RVA: 0x00069C7D File Offset: 0x00067E7D
		' (set) Token: 0x0600100A RID: 4106 RVA: 0x00069C8A File Offset: 0x00067E8A
		<Description("表格线颜色")>
		<O_Oo00Oo000O0(9.1)>
		<Category("配色")>
		Public Property CellBorderColor As Color
			Get
				Return Me.O0_oO0.o_o..CellBorderColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..CellBorderColor = value
			End Set
		End Property

		' Token: 0x1700030E RID: 782
		' (get) Token: 0x0600100B RID: 4107 RVA: 0x00069C98 File Offset: 0x00067E98
		' (set) Token: 0x0600100C RID: 4108 RVA: 0x00069CA5 File Offset: 0x00067EA5
		<Description("标题行和行号的表格线颜色")>
		<Category("配色")>
		<O_Oo00Oo000O0(9.1)>
		Public Property FixedCellBorderColor As Color
			Get
				Return Me.O0_oO0.o_o..FixedCellBorderColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..FixedCellBorderColor = value
			End Set
		End Property

		' Token: 0x1700030F RID: 783
		' (get) Token: 0x0600100D RID: 4109 RVA: 0x00069CB3 File Offset: 0x00067EB3
		' (set) Token: 0x0600100E RID: 4110 RVA: 0x00069CC0 File Offset: 0x00067EC0
		<OooO0(True)>
		<Category("配色")>
		<Description("任务条文字颜色")>
		<O_Oo00Oo000O0(11.0)>
		Public Property BarTextForeColor As Color
			Get
				Return Me.O0_oO0.o_o..BarTextForeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..BarTextForeColor = value
			End Set
		End Property

		' Token: 0x17000310 RID: 784
		' (get) Token: 0x0600100F RID: 4111 RVA: 0x00069CCE File Offset: 0x00067ECE
		' (set) Token: 0x06001010 RID: 4112 RVA: 0x00069CDB File Offset: 0x00067EDB
		<Description("分组行的背景颜色")>
		<Category("配色")>
		<O_Oo00Oo000O0(12.0)>
		<OooO0(True)>
		Public Property GroupBackColor As Color
			Get
				Return Me.O0_oO0.o_o..GroupBackColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..GroupBackColor = value
			End Set
		End Property

		' Token: 0x17000311 RID: 785
		' (get) Token: 0x06001011 RID: 4113 RVA: 0x00069CE9 File Offset: 0x00067EE9
		' (set) Token: 0x06001012 RID: 4114 RVA: 0x00069CF6 File Offset: 0x00067EF6
		<O_Oo00Oo000O0(14.0)>
		<Category("配色")>
		<Description("空白区背景颜色")>
		Public Property EmptyAreaBackColor As Color
			Get
				Return Me.O0_oO0.o_o..EmptyAreaBackColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..EmptyAreaBackColor = value
			End Set
		End Property

		' Token: 0x17000312 RID: 786
		' (get) Token: 0x06001013 RID: 4115 RVA: 0x00069D04 File Offset: 0x00067F04
		' (set) Token: 0x06001014 RID: 4116 RVA: 0x00069D11 File Offset: 0x00067F11
		<Category("配色")>
		<Description("高亮区背景颜色")>
		<O_Oo00Oo000O0(16.0)>
		Public Property HighlightBackColor As Color
			Get
				Return Me.O0_oO0.o_o..HighlightBackColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..HighlightBackColor = value
			End Set
		End Property

		' Token: 0x17000313 RID: 787
		' (get) Token: 0x06001015 RID: 4117 RVA: 0x00069D1F File Offset: 0x00067F1F
		' (set) Token: 0x06001016 RID: 4118 RVA: 0x00069D2C File Offset: 0x00067F2C
		<O_Oo00Oo000O0(17.0)>
		<Category("配色")>
		<Description("高亮区文字颜色")>
		Public Property HighlightForeColor As Color
			Get
				Return Me.O0_oO0.o_o..HighlightForeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..HighlightForeColor = value
			End Set
		End Property

		' Token: 0x17000314 RID: 788
		' (get) Token: 0x06001017 RID: 4119 RVA: 0x00069D3A File Offset: 0x00067F3A
		' (set) Token: 0x06001018 RID: 4120 RVA: 0x00069D47 File Offset: 0x00067F47
		<O_Oo00Oo000O0(18.0)>
		<Category("配色")>
		<Description("拖动任务条时拖动框的颜色")>
		<OooO0(True)>
		Public Property MarqueeColor As Color
			Get
				Return Me.O0_oO0.o_o..MarqueeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..MarqueeColor = value
			End Set
		End Property

		' Token: 0x17000315 RID: 789
		' (get) Token: 0x06001019 RID: 4121 RVA: 0x00069D55 File Offset: 0x00067F55
		' (set) Token: 0x0600101A RID: 4122 RVA: 0x00069D62 File Offset: 0x00067F62
		<O_Oo00Oo000O0(19.0)>
		<Description("非工作日的背景颜色")>
		<Category("配色")>
		<OooO0(True)>
		Public Property NonworkingTimeColor As Color
			Get
				Return Me.O0_oO0.o_o..NonworkingTimeColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..NonworkingTimeColor = value
			End Set
		End Property

		' Token: 0x17000316 RID: 790
		' (get) Token: 0x0600101B RID: 4123 RVA: 0x00069D70 File Offset: 0x00067F70
		' (set) Token: 0x0600101C RID: 4124 RVA: 0x00069D7D File Offset: 0x00067F7D
		<O_Oo00Oo000O0(20.0)>
		<Category("配色")>
		<Description("项目开始日线和结束日线的颜色")>
		<OooO0(True)>
		Public Property StartFinishLineColor As Color
			Get
				Return Me.O0_oO0.o_o..StartFinishLineColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..StartFinishLineColor = value
			End Set
		End Property

		' Token: 0x17000317 RID: 791
		' (get) Token: 0x0600101D RID: 4125 RVA: 0x00069D8B File Offset: 0x00067F8B
		' (set) Token: 0x0600101E RID: 4126 RVA: 0x00069D98 File Offset: 0x00067F98
		<OooO0(True)>
		<Category("配色")>
		<O_Oo00Oo000O0(21.0)>
		<Description("今日时间线的颜色")>
		Public Property TodayLineColor As Color
			Get
				Return Me.O0_oO0.o_o..TodayLineColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..TodayLineColor = value
			End Set
		End Property

		' Token: 0x17000318 RID: 792
		' (get) Token: 0x0600101F RID: 4127 RVA: 0x00069DA6 File Offset: 0x00067FA6
		' (set) Token: 0x06001020 RID: 4128 RVA: 0x00069DB3 File Offset: 0x00067FB3
		<O_Oo00Oo000O0(22.0)>
		<Category("配色")>
		<Description("工具栏背景颜色")>
		Public Property ToolbarBackColor As Color
			Get
				Return Me.O0_oO0.o_o..ToolbarBackColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..ToolbarBackColor = value
			End Set
		End Property

		' Token: 0x17000319 RID: 793
		' (get) Token: 0x06001021 RID: 4129 RVA: 0x00069DC1 File Offset: 0x00067FC1
		' (set) Token: 0x06001022 RID: 4130 RVA: 0x00069DCE File Offset: 0x00067FCE
		<O_Oo00Oo000O0(23.0)>
		<Category("配色")>
		<Description("表格和甘特图之间的分隔条的颜色")>
		Public Property SplitterColor As Color
			Get
				Return Me.O0_oO0.o_o..SplitterColor
			End Get
			Set(value As Color)
				Me.O0_oO0.o_o..SplitterColor = value
			End Set
		End Property

		' Token: 0x1700031A RID: 794
		' (get) Token: 0x06001023 RID: 4131 RVA: 0x00069DDC File Offset: 0x00067FDC
		' (set) Token: 0x06001024 RID: 4132 RVA: 0x00069DE4 File Offset: 0x00067FE4
		<Category("GanttView事件")>
		<oO0oooo("4043")>
		<Description("编辑任务后触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property AfterEditTask As EventString
			Get
				Return Me.oOo.00.
			End Get
			Set(value As EventString)
				Me.oOo.00. = value
			End Set
		End Property

		' Token: 0x1700031B RID: 795
		' (get) Token: 0x06001025 RID: 4133 RVA: 0x00069DED File Offset: 0x00067FED
		' (set) Token: 0x06001026 RID: 4134 RVA: 0x00069DF5 File Offset: 0x00067FF5
		<oO0oooo("4043")>
		<O_Oo00Oo000O0(2.0)>
		<Description("编辑任务前触发")>
		<Category("GanttView事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeEditTask As EventString
			Get
				Return Me.oO__00o_0o._.
			End Get
			Set(value As EventString)
				Me.oO__00o_0o._. = value
			End Set
		End Property

		' Token: 0x1700031C RID: 796
		' (get) Token: 0x06001027 RID: 4135 RVA: 0x00069DFE File Offset: 0x00067FFE
		' (set) Token: 0x06001028 RID: 4136 RVA: 0x00069E06 File Offset: 0x00068006
		<Category("GanttView事件")>
		<O_Oo00Oo000O0(3.0)>
		<oO0oooo("4043")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("增加任务前触发")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeAddTask As EventString
			Get
				Return Me.oOoO.____0_O_O.
			End Get
			Set(value As EventString)
				Me.oOoO.____0_O_O. = value
			End Set
		End Property

		' Token: 0x1700031D RID: 797
		' (get) Token: 0x06001029 RID: 4137 RVA: 0x00069E0F File Offset: 0x0006800F
		' (set) Token: 0x0600102A RID: 4138 RVA: 0x00069E17 File Offset: 0x00068017
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("4043")>
		<Category("GanttView事件")>
		<O_Oo00Oo000O0(4.0)>
		<Description("删除任务前触发")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeRemoveTask As EventString
			Get
				Return Me.OO0O0_.O0oo_o.
			End Get
			Set(value As EventString)
				Me.OO0O0_.O0oo_o. = value
			End Set
		End Property

		' Token: 0x1700031E RID: 798
		' (get) Token: 0x0600102B RID: 4139 RVA: 0x00069E20 File Offset: 0x00068020
		' (set) Token: 0x0600102C RID: 4140 RVA: 0x00069E28 File Offset: 0x00068028
		<oO0oooo("4043")>
		<Category("GanttView事件")>
		<Description("移动任务前触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property BeforeMoveTasks As EventString
			Get
				Return Me.OoO_.0_0O.
			End Get
			Set(value As EventString)
				Me.OoO_.0_0O. = value
			End Set
		End Property

		' Token: 0x1700031F RID: 799
		' (get) Token: 0x0600102D RID: 4141 RVA: 0x00069E31 File Offset: 0x00068031
		' (set) Token: 0x0600102E RID: 4142 RVA: 0x00069E39 File Offset: 0x00068039
		<Description("单击任务条后触发")>
		<oO0oooo("4043")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(6.0)>
		<Category("GanttView事件")>
		<O0O0oOO00_0OO(True)>
		Public Property TaskBarClick As EventString
			Get
				Return Me.o0o.0o_o0o__00.
			End Get
			Set(value As EventString)
				Me.o0o.0o_o0o__00. = value
			End Set
		End Property

		' Token: 0x17000320 RID: 800
		' (get) Token: 0x0600102F RID: 4143 RVA: 0x00069E42 File Offset: 0x00068042
		' (set) Token: 0x06001030 RID: 4144 RVA: 0x00069E4A File Offset: 0x0006804A
		<Description("单击任务条后触发")>
		<oO0oooo("4043")>
		<Category("GanttView事件")>
		<O_Oo00Oo000O0(7.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.OO._o0_o0O000.
			End Get
			Set(value As EventString)
				Me.OO._o0_o0O000. = value
			End Set
		End Property

		' Token: 0x17000321 RID: 801
		' (get) Token: 0x06001031 RID: 4145 RVA: 0x00069E53 File Offset: 0x00068053
		' (set) Token: 0x06001032 RID: 4146 RVA: 0x00069E5B File Offset: 0x0006805B
		<oO0oooo("4043")>
		<O_Oo00Oo000O0(7.0)>
		<Description("显示任务提示信息时触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("GanttView事件")>
		<O0O0oOO00_0OO(True)>
		Public Property TaskBarTooltip As EventString
			Get
				Return Me.O_oO__o.O_.
			End Get
			Set(value As EventString)
				Me.O_oO__o.O_. = value
			End Set
		End Property

		' Token: 0x17000322 RID: 802
		' (get) Token: 0x06001033 RID: 4147 RVA: 0x00069E64 File Offset: 0x00068064
		' (set) Token: 0x06001034 RID: 4148 RVA: 0x00069E6C File Offset: 0x0006806C
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("GanttView事件")>
		<Description("绘制单元格时触发")>
		<oO0oooo("4043")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(8.0)>
		Public Property PaintDay As EventString
			Get
				Return Me.ooO._O0_O.
			End Get
			Set(value As EventString)
				Me.ooO._O0_O. = value
			End Set
		End Property

		' Token: 0x17000323 RID: 803
		' (get) Token: 0x06001035 RID: 4149 RVA: 0x00069E75 File Offset: 0x00068075
		' (set) Token: 0x06001036 RID: 4150 RVA: 0x00069E7D File Offset: 0x0006807D
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("GanttView事件")>
		<Description("单击工具栏按钮后触发")>
		<DisplayName("StripItemClik")>
		<oO0oooo("4043")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(9.0)>
		Public Property GannttStripItemClik As EventString
			Get
				Return Me.OOO.Oo.
			End Get
			Set(value As EventString)
				Me.OOO.Oo. = value
			End Set
		End Property

		' Token: 0x0400061F RID: 1567
		Friend <<EMPTY_NAME>> As GanttView

		' Token: 0x04000620 RID: 1568
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000621 RID: 1569
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000622 RID: 1570
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000623 RID: 1571
		Public <<EMPTY_NAME>> As EventString

		' Token: 0x04000624 RID: 1572
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000625 RID: 1573
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000626 RID: 1574
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000627 RID: 1575
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000628 RID: 1576
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000629 RID: 1577
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
