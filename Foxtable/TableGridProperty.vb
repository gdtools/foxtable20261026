Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000412 RID: 1042
	<EditorBrowsable(EditorBrowsableState.Never)>
	<OoO0___o("Table")>
	Public Class TableGridProperty
		Inherits PropertyBase

		' Token: 0x060044DC RID: 17628 RVA: 0x001C3674 File Offset: 0x001C1874
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.OOooOOo_.0_0_o. = True
			Me.o0__o.ooO. = True
			Me.O_0_._0o. = True
			Me.o_0o0_._0. = True
			Me.oOo_0o0.O00o. = 0
			Me.oOo_0o0.O00o. = SystemColors.Control
			Me.O_0_._0o. = "(default)"
			Me.o00o_0_o_.O0. = Color.FloralWhite
			Me.O0O0Ooo.0oO. = SystemColors.ControlText
			Me.O0.0O__OOOOOOO. = True
			Me.o_o_._O. = True
			Me.O0O0Ooo.0oO. = 1
			Me.OOooOOo_.0_0_o. = CType(A_0.ChildControl, oOo__OO_)
		End Sub

		' Token: 0x17000FBB RID: 4027
		' (get) Token: 0x060044DD RID: 17629 RVA: 0x001C36FD File Offset: 0x001C18FD
		' (set) Token: 0x060044DE RID: 17630 RVA: 0x001C3705 File Offset: 0x001C1905
		<Description("是否突出显示选定行")>
		<O_Oo00Oo000O0(5.1)>
		<DisplayName("整行突出")>
		<Category("外观")>
		Public Property ListMode As Boolean
			Get
				Return Me.o_o.___.
			End Get
			Set(value As Boolean)
				Me.o_o.___. = value
			End Set
		End Property

		' Token: 0x17000FBC RID: 4028
		' (get) Token: 0x060044DF RID: 17631 RVA: 0x001C370E File Offset: 0x001C190E
		' (set) Token: 0x060044E0 RID: 17632 RVA: 0x001C371B File Offset: 0x001C191B
		<Description("确定用户按Tab键时，该控件获得焦点的顺序。")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("Tab键顺序")>
		<Category("杂项")>
		Public Property TabIndex As Integer
			Get
				Return Me.o_0_.Oo..TabIndex
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..TabIndex = value
			End Set
		End Property

		' Token: 0x17000FBD RID: 4029
		' (get) Token: 0x060044E1 RID: 17633 RVA: 0x001C3729 File Offset: 0x001C1929
		' (set) Token: 0x060044E2 RID: 17634 RVA: 0x001C3731 File Offset: 0x001C1931
		<DisplayName("类型")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.9)>
		<Category("基本")>
		Public Property TableType As TableTypeEnum
			Get
				Return Me.O0Oooo_.O00_o_.
			End Get
			Set(value As TableTypeEnum)
				Me.O0Oooo_.O00_o_. = value
				If value = 2 Then
					Me.o_o_._O. = False
				End If
			End Set
		End Property

		' Token: 0x17000FBE RID: 4030
		' (get) Token: 0x060044E3 RID: 17635 RVA: 0x001C3745 File Offset: 0x001C1945
		' (set) Token: 0x060044E4 RID: 17636 RVA: 0x001C374D File Offset: 0x001C194D
		<O_Oo00Oo000O0(2.0)>
		<Category("基本")>
		<TypeConverter(GetType(ooo_0O0))>
		<DisplayName("绑定表")>
		Public Property RelationTable As String
			Get
				Return Me.O0Oooo_.O00_o_.
			End Get
			Set(value As String)
				Me.O0Oooo_.O00_o_. = value
				Me.OOooOOo_.0_0_o..ooO.Oo000_.(value)
			End Set
		End Property

		' Token: 0x17000FBF RID: 4031
		' (get) Token: 0x060044E5 RID: 17637 RVA: 0x001C3762 File Offset: 0x001C1962
		' (set) Token: 0x060044E6 RID: 17638 RVA: 0x001C376A File Offset: 0x001C196A
		<TypeConverter(GetType(OOO__oooOOo))>
		<O_Oo00Oo000O0(2.1)>
		<Category("基本")>
		<DisplayName("数据源")>
		Public Property Connection As String
			Get
				Return Me.o00o_0_o_.O0.
			End Get
			Set(value As String)
				Me.o00o_0_o_.O0. = value
			End Set
		End Property

		' Token: 0x17000FC0 RID: 4032
		' (get) Token: 0x060044E7 RID: 17639 RVA: 0x001C3773 File Offset: 0x001C1973
		' (set) Token: 0x060044E8 RID: 17640 RVA: 0x001C377B File Offset: 0x001C197B
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<DisplayName("Select语句")>
		<Editor(GetType(o0O_O__o000), GetType(UITypeEditor))>
		Public Property SelectString As String
			Get
				Return Me.o0_.oo__0__00o.
			End Get
			Set(value As String)
				Me.o0_.oo__0__00o. = value
			End Set
		End Property

		' Token: 0x17000FC1 RID: 4033
		' (get) Token: 0x060044E9 RID: 17641 RVA: 0x001C3784 File Offset: 0x001C1984
		' (set) Token: 0x060044EA RID: 17642 RVA: 0x001C37DA File Offset: 0x001C19DA
		<DisplayName("作为副本")>
		<O_Oo00Oo000O0(2.3)>
		<DefaultValue(False)>
		<Category("基本")>
		Public Property IsCopy As Boolean
			Get
				Return(Operators.CompareString(Me.RelationTable, "", True) <= 0 OrElse Not OO_00oOO.Tables.get_Contains(Me.RelationTable) OrElse Not OO_00oOO.Tables(Me.RelationTable).IsRelation) AndAlso Me.oOOooo0.0.
			End Get
			Set(value As Boolean)
				Me.oOOooo0.0. = value
			End Set
		End Property

		' Token: 0x17000FC2 RID: 4034
		' (get) Token: 0x060044EB RID: 17643 RVA: 0x001C37E3 File Offset: 0x001C19E3
		' (set) Token: 0x060044EC RID: 17644 RVA: 0x001C37EB File Offset: 0x001C19EB
		<DisplayName("允许编辑")>
		<Category("基本")>
		<O_Oo00Oo000O0(2.4)>
		Public Property AllowEdit As Boolean
			Get
				Return Me.o_o_._O.
			End Get
			Set(value As Boolean)
				Me.o_o_._O. = value
			End Set
		End Property

		' Token: 0x17000FC3 RID: 4035
		' (get) Token: 0x060044ED RID: 17645 RVA: 0x001C37F4 File Offset: 0x001C19F4
		' (set) Token: 0x060044EE RID: 17646 RVA: 0x001C37FC File Offset: 0x001C19FC
		<O_Oo00Oo000O0(2.5)>
		<Description("是否启动单击列标题自动排序的功能")>
		<DisplayName("允许单击排序")>
		<Category("杂项")>
		Public Property AllowClickSort As Boolean
			Get
				Return Me.o_O00oO_o.OO.
			End Get
			Set(value As Boolean)
				Me.o_O00oO_o.OO. = value
			End Set
		End Property

		' Token: 0x17000FC4 RID: 4036
		' (get) Token: 0x060044EF RID: 17647 RVA: 0x001C3805 File Offset: 0x001C1A05
		' (set) Token: 0x060044F0 RID: 17648 RVA: 0x001C380D File Offset: 0x001C1A0D
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(O0_OoO_O), GetType(UITypeEditor))>
		<MergableProperty(False)>
		<Description("批量设置要显示的列及其列宽，例如：日期|90|产品|120|客户|120|数量|60。")>
		<DisplayName("显示列")>
		<Category("基本")>
		Public Property ColumnList As String
			Get
				Return Me.O_.0Oo_O.
			End Get
			Set(value As String)
				Me.O_.0Oo_O. = value
			End Set
		End Property

		' Token: 0x17000FC5 RID: 4037
		' (get) Token: 0x060044F1 RID: 17649 RVA: 0x001C3816 File Offset: 0x001C1A16
		' (set) Token: 0x060044F2 RID: 17650 RVA: 0x001C381E File Offset: 0x001C1A1E
		<O_Oo00Oo000O0(0.0)>
		<DisplayName("样式")>
		<Category("外观")>
		<TypeConverter(GetType(o00))>
		<DefaultValue("(default)")>
		Public Property Theme As String
			Get
				Return Me.O_0_._0o.
			End Get
			Set(value As String)
				Me.O_0_._0o. = value
			End Set
		End Property

		' Token: 0x17000FC6 RID: 4038
		' (get) Token: 0x060044F3 RID: 17651 RVA: 0x001C3827 File Offset: 0x001C1A27
		' (set) Token: 0x060044F4 RID: 17652 RVA: 0x001C3839 File Offset: 0x001C1A39
		<DefaultValue("宋体,9")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("字体")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Overridable Property Font As Font
			Get
				Return Me.o_0_.Oo..ChildControl.Font
			End Get
			Set(value As Font)
				Me.o_0_.Oo..ChildControl.Font = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x17000FC7 RID: 4039
		' (get) Token: 0x060044F5 RID: 17653 RVA: 0x001C3856 File Offset: 0x001C1A56
		' (set) Token: 0x060044F6 RID: 17654 RVA: 0x001C385E File Offset: 0x001C1A5E
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("显示行号列")>
		<Category("外观")>
		Public Property RowHeaderVisible As Boolean
			Get
				Return Me.o_0o0_._0.
			End Get
			Set(value As Boolean)
				Me.o_0o0_._0. = value
			End Set
		End Property

		' Token: 0x17000FC8 RID: 4040
		' (get) Token: 0x060044F7 RID: 17655 RVA: 0x001C3867 File Offset: 0x001C1A67
		' (set) Token: 0x060044F8 RID: 17656 RVA: 0x001C386F File Offset: 0x001C1A6F
		<O_Oo00Oo000O0(3.0)>
		<Category("外观")>
		<DisplayName("显示复选框")>
		Public Property ShowCheckBox As Boolean
			Get
				Return Me.oo_O.oOo_0o_O.
			End Get
			Set(value As Boolean)
				Me.oo_O.oOo_0o_O. = value
			End Set
		End Property

		' Token: 0x17000FC9 RID: 4041
		' (get) Token: 0x060044F9 RID: 17657 RVA: 0x001C3878 File Offset: 0x001C1A78
		' (set) Token: 0x060044FA RID: 17658 RVA: 0x001C3880 File Offset: 0x001C1A80
		<DisplayName("网格线方向")>
		<O_Oo00Oo000O0(4.0)>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property GridLineDirection As GridLineDirectionEnum
			Get
				Return Me.oOo_0o0.O00o.
			End Get
			Set(value As GridLineDirectionEnum)
				Me.oOo_0o0.O00o. = value
			End Set
		End Property

		' Token: 0x17000FCA RID: 4042
		' (get) Token: 0x060044FB RID: 17659 RVA: 0x001C3889 File Offset: 0x001C1A89
		' (set) Token: 0x060044FC RID: 17660 RVA: 0x001C3891 File Offset: 0x001C1A91
		<Category("外观")>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("网格线颜色")>
		Public Property GridColor As Color
			Get
				Return Me.oOo_0o0.O00o.
			End Get
			Set(value As Color)
				Me.oOo_0o0.O00o. = value
			End Set
		End Property

		' Token: 0x17000FCB RID: 4043
		' (get) Token: 0x060044FD RID: 17661 RVA: 0x001C389A File Offset: 0x001C1A9A
		' (set) Token: 0x060044FE RID: 17662 RVA: 0x001C38A2 File Offset: 0x001C1AA2
		<DefaultValue(1)>
		<DisplayName("网格线宽度")>
		<O_Oo00Oo000O0(5.01)>
		<Category("外观")>
		Public Property BorderWidth As Integer
			Get
				Return Me.O0O0Ooo.0oO.
			End Get
			Set(value As Integer)
				Me.O0O0Ooo.0oO. = value
			End Set
		End Property

		' Token: 0x17000FCC RID: 4044
		' (get) Token: 0x060044FF RID: 17663 RVA: 0x001C38AB File Offset: 0x001C1AAB
		' (set) Token: 0x06004500 RID: 17664 RVA: 0x001C38B3 File Offset: 0x001C1AB3
		<DisplayName("显示焦点框")>
		<O_Oo00Oo000O0(5.11)>
		<Description("是否显示焦点框")>
		<Category("外观")>
		Public Property FocusRect As Boolean
			Get
				Return Me.O0.0O__OOOOOOO.
			End Get
			Set(value As Boolean)
				Me.O0.0O__OOOOOOO. = value
			End Set
		End Property

		' Token: 0x17000FCD RID: 4045
		' (get) Token: 0x06004501 RID: 17665 RVA: 0x001C38BC File Offset: 0x001C1ABC
		' (set) Token: 0x06004502 RID: 17666 RVA: 0x001C38C4 File Offset: 0x001C1AC4
		<O_Oo00Oo000O0(6.0)>
		<Description("列表模式下的选定行背景颜色。")>
		<DisplayName("选定行背景颜色")>
		<Category("外观")>
		Public Property CurrentRowBackColor As Color
			Get
				Return Me.o00o_0_o_.O0.
			End Get
			Set(value As Color)
				Me.o00o_0_o_.O0. = value
			End Set
		End Property

		' Token: 0x17000FCE RID: 4046
		' (get) Token: 0x06004503 RID: 17667 RVA: 0x001C38CD File Offset: 0x001C1ACD
		' (set) Token: 0x06004504 RID: 17668 RVA: 0x001C38D5 File Offset: 0x001C1AD5
		<Description("列表模式下的选定行字体颜色。")>
		<DisplayName("选定行字体颜色")>
		<O_Oo00Oo000O0(7.0)>
		<Category("外观")>
		Public Property CurrentRowForeColor As Color
			Get
				Return Me.O0O0Ooo.0oO.
			End Get
			Set(value As Color)
				Me.O0O0Ooo.0oO. = value
			End Set
		End Property

		' Token: 0x17000FCF RID: 4047
		' (get) Token: 0x06004505 RID: 17669 RVA: 0x001C38DE File Offset: 0x001C1ADE
		' (set) Token: 0x06004506 RID: 17670 RVA: 0x001C38E6 File Offset: 0x001C1AE6
		<DefaultValue(True)>
		<DisplayName("可见")>
		<MergableProperty(True)>
		<Category("杂项")>
		<O_Oo00Oo000O0(2.0)>
		Public Property Visible As Boolean
			Get
				Return Me.OOooOOo_.0_0_o.
			End Get
			Set(value As Boolean)
				Me.OOooOOo_.0_0_o. = value
			End Set
		End Property

		' Token: 0x17000FD0 RID: 4048
		' (get) Token: 0x06004507 RID: 17671 RVA: 0x001C38EF File Offset: 0x001C1AEF
		' (set) Token: 0x06004508 RID: 17672 RVA: 0x001C38FC File Offset: 0x001C1AFC
		<DisplayName("左")>
		<Category("位置")>
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		Public Property Left As Integer
			Get
				Return Me.o_0_.Oo..Left
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Left = value
			End Set
		End Property

		' Token: 0x17000FD1 RID: 4049
		' (get) Token: 0x06004509 RID: 17673 RVA: 0x001C390A File Offset: 0x001C1B0A
		' (set) Token: 0x0600450A RID: 17674 RVA: 0x001C3917 File Offset: 0x001C1B17
		<DisplayName("上")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<Category("位置")>
		Public Property Top As Integer
			Get
				Return Me.o_0_.Oo..Top
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Top = value
			End Set
		End Property

		' Token: 0x17000FD2 RID: 4050
		' (get) Token: 0x0600450B RID: 17675 RVA: 0x001C3925 File Offset: 0x001C1B25
		' (set) Token: 0x0600450C RID: 17676 RVA: 0x001C3932 File Offset: 0x001C1B32
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<Category("位置")>
		<DisplayName("宽")>
		Public Property Width As Integer
			Get
				Return Me.o_0_.Oo..Width
			End Get
			Set(value As Integer)
				If Not Me.o_0_.Oo..IsFixedWidth Then
					Me.o_0_.Oo..Width = value
				End If
			End Set
		End Property

		' Token: 0x17000FD3 RID: 4051
		' (get) Token: 0x0600450D RID: 17677 RVA: 0x001C394D File Offset: 0x001C1B4D
		' (set) Token: 0x0600450E RID: 17678 RVA: 0x001C395A File Offset: 0x001C1B5A
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<Category("位置")>
		<DisplayName("高")>
		Public Property Height As Integer
			Get
				Return Me.o_0_.Oo..Height
			End Get
			Set(value As Integer)
				If Not Me.o_0_.Oo..IsFixedHeight Then
					Me.o_0_.Oo..Height = value
				End If
			End Set
		End Property

		' Token: 0x17000FD4 RID: 4052
		' (get) Token: 0x0600450F RID: 17679 RVA: 0x001C3975 File Offset: 0x001C1B75
		' (set) Token: 0x06004510 RID: 17680 RVA: 0x001C3982 File Offset: 0x001C1B82
		<Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")>
		<O_Oo00Oo000O0(5.0)>
		<Category("位置")>
		<DefaultValue(5)>
		<MergableProperty(True)>
		<DisplayName("锚定")>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o_0_.Oo..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o_0_.Oo..Anchor = value
			End Set
		End Property

		' Token: 0x17000FD5 RID: 4053
		' (get) Token: 0x06004511 RID: 17681 RVA: 0x001C3990 File Offset: 0x001C1B90
		' (set) Token: 0x06004512 RID: 17682 RVA: 0x001C399D File Offset: 0x001C1B9D
		<Description("停靠到容器的指定边框。")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<Category("位置")>
		<DisplayName("停靠")>
		<O_Oo00Oo000O0(5.1)>
		Public Property Dock As DockStyle
			Get
				Return Me.o_0_.Oo..Dock
			End Get
			Set(value As DockStyle)
				Me.o_0_.Oo..Dock = value
			End Set
		End Property

		' Token: 0x17000FD6 RID: 4054
		' (get) Token: 0x06004513 RID: 17683 RVA: 0x001C39AB File Offset: 0x001C1BAB
		' (set) Token: 0x06004514 RID: 17684 RVA: 0x001C39B3 File Offset: 0x001C1BB3
		<DefaultValue(True)>
		<O_Oo00Oo000O0(10.0)>
		<Category("输出")>
		<MergableProperty(True)>
		<Description("打印窗口时是否打印此控件。")>
		<DisplayName("允许打印")>
		Public Property Printable As Boolean
			Get
				Return Me.o0__o.ooO.
			End Get
			Set(value As Boolean)
				Me.o0__o.ooO. = value
			End Set
		End Property

		' Token: 0x17000FD7 RID: 4055
		' (get) Token: 0x06004515 RID: 17685 RVA: 0x001C39BC File Offset: 0x001C1BBC
		' (set) Token: 0x06004516 RID: 17686 RVA: 0x001C39C4 File Offset: 0x001C1BC4
		<MergableProperty(True)>
		<Description("打印时是否从此控件开始另起一页。")>
		<O_Oo00Oo000O0(10.1)>
		<DisplayName("另起一页")>
		<DefaultValue(False)>
		<Category("输出")>
		Public Property NewPage As Boolean
			Get
				Return Me.oOo.0OO0O_O.
			End Get
			Set(value As Boolean)
				Me.oOo.0OO0O_O. = value
			End Set
		End Property

		' Token: 0x17000FD8 RID: 4056
		' (get) Token: 0x06004517 RID: 17687 RVA: 0x001C39CD File Offset: 0x001C1BCD
		' (set) Token: 0x06004518 RID: 17688 RVA: 0x001C39D5 File Offset: 0x001C1BD5
		<Category("输出")>
		<O_Oo00Oo000O0(12.0)>
		<MergableProperty(True)>
		<Description("设置最少行数，不够自动补空行。")>
		<DisplayName("最少行数")>
		<DefaultValue(0)>
		Public Property MinRows As Integer
			Get
				Return Me.o.00OO.
			End Get
			Set(value As Integer)
				Me.o.00OO. = value
			End Set
		End Property

		' Token: 0x17000FD9 RID: 4057
		' (get) Token: 0x06004519 RID: 17689 RVA: 0x001C39DE File Offset: 0x001C1BDE
		' (set) Token: 0x0600451A RID: 17690 RVA: 0x001C39E6 File Offset: 0x001C1BE6
		<MergableProperty(True)>
		<O_Oo00Oo000O0(12.1)>
		<Description("设置每页最大打印行数，如果设为0，则不限制。")>
		<Category("输出")>
		<DisplayName("最大行数")>
		<DefaultValue(0)>
		Public Property MaxRows As Integer
			Get
				Return Me.o0__o.ooO.
			End Get
			Set(value As Integer)
				Me.o0__o.ooO. = value
			End Set
		End Property

		' Token: 0x17000FDA RID: 4058
		' (get) Token: 0x0600451B RID: 17691 RVA: 0x001C39EF File Offset: 0x001C1BEF
		' (set) Token: 0x0600451C RID: 17692 RVA: 0x001C39F7 File Offset: 0x001C1BF7
		<O_Oo00Oo000O0(13.0)>
		<DisplayName("打印行号")>
		<Category("输出")>
		<MergableProperty(True)>
		Public Property PrintRowNumber As Boolean
			Get
				Return Me.O_0_._0o.
			End Get
			Set(value As Boolean)
				Me.O_0_._0o. = value
			End Set
		End Property

		' Token: 0x17000FDB RID: 4059
		' (get) Token: 0x0600451D RID: 17693 RVA: 0x001C3A00 File Offset: 0x001C1C00
		' (set) Token: 0x0600451E RID: 17694 RVA: 0x001C3A08 File Offset: 0x001C1C08
		<O_Oo00Oo000O0(4.001)>
		<DisplayName("最顶层")>
		<Description("设置控件是否位于其它控件之上。")>
		<DefaultValue(False)>
		<Category("杂项")>
		<MergableProperty(True)>
		Public Property TopMost As Boolean
			Get
				Return Me.OOOo_OO_0o.0o.
			End Get
			Set(value As Boolean)
				Me.OOOo_OO_0o.0o. = value
				If value Then
					Me.BackMost = False
					MyBase.Holder.BringToFront()
				End If
			End Set
		End Property

		' Token: 0x17000FDC RID: 4060
		' (get) Token: 0x0600451F RID: 17695 RVA: 0x001C3A26 File Offset: 0x001C1C26
		' (set) Token: 0x06004520 RID: 17696 RVA: 0x001C3A2E File Offset: 0x001C1C2E
		<MergableProperty(True)>
		<Description("设置控件是否位于其它控件之下。")>
		<O_Oo00Oo000O0(4.002)>
		<DisplayName("最底层")>
		<DefaultValue(False)>
		<Category("杂项")>
		Public Property BackMost As Boolean
			Get
				Return Me.oO0_._.
			End Get
			Set(value As Boolean)
				Me.oO0_._. = value
				If value Then
					Me.TopMost = False
					MyBase.Holder.SendToBack()
				End If
			End Set
		End Property

		' Token: 0x17000FDD RID: 4061
		' (get) Token: 0x06004521 RID: 17697 RVA: 0x001C3A4C File Offset: 0x001C1C4C
		' (set) Token: 0x06004522 RID: 17698 RVA: 0x001C3A54 File Offset: 0x001C1C54
		<Category("A.编辑")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0605")>
		<Description("进入单元格，准备编辑的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(1.0)>
		Public Property PrepareEdit As EventString
			Get
				Return Me.o.00OO.
			End Get
			Set(value As EventString)
				Me.o.00OO. = value
			End Set
		End Property

		' Token: 0x17000FDE RID: 4062
		' (get) Token: 0x06004523 RID: 17699 RVA: 0x001C3A5D File Offset: 0x001C1C5D
		' (set) Token: 0x06004524 RID: 17700 RVA: 0x001C3A65 File Offset: 0x001C1C65
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<oO0oooo("0615")>
		<Description("真正有了编辑单元格动作的时候执行，例如用户通过键盘输入内容，或者用鼠标单击了下拉按钮。")>
		<O_Oo00Oo000O0(2.0)>
		<O0O0oOO00_0OO(True)>
		Public Property StartEdit As EventString
			Get
				Return Me.oo._Oo_.
			End Get
			Set(value As EventString)
				Me.oo._Oo_. = value
			End Set
		End Property

		' Token: 0x17000FDF RID: 4063
		' (get) Token: 0x06004525 RID: 17701 RVA: 0x001C3A6E File Offset: 0x001C1C6E
		' (set) Token: 0x06004526 RID: 17702 RVA: 0x001C3A76 File Offset: 0x001C1C76
		<Browsable(False)>
		<Category("A.编辑")>
		<Description("单元格真正进入编辑状态之前执行，此时编辑框(Editor)已经初始化，可以设置其属性。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.1)>
		Public Property SetupEditor As EventString
			Get
				Return Me.o0_.oo__0__00o.
			End Get
			Set(value As EventString)
				Me.o0_.oo__0__00o. = value
			End Set
		End Property

		' Token: 0x17000FE0 RID: 4064
		' (get) Token: 0x06004527 RID: 17703 RVA: 0x001C3A7F File Offset: 0x001C1C7F
		' (set) Token: 0x06004528 RID: 17704 RVA: 0x001C3A87 File Offset: 0x001C1C87
		<Description("结束编辑单元格前执行，通常用于验证输入的内容。")>
		<Category("A.编辑")>
		<oO0oooo("0617")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		<O0O0oOO00_0OO(True)>
		Public Property ValidateEdit As EventString
			Get
				Return Me.oo.0_oOO0_O_.
			End Get
			Set(value As EventString)
				Me.oo.0_oOO0_O_. = value
			End Set
		End Property

		' Token: 0x17000FE1 RID: 4065
		' (get) Token: 0x06004529 RID: 17705 RVA: 0x001C3A90 File Offset: 0x001C1C90
		' (set) Token: 0x0600452A RID: 17706 RVA: 0x001C3A98 File Offset: 0x001C1C98
		<oO0oooo("0616")>
		<Description("结束编辑单元格后执行，通常用于执行一些特定的操作和计算。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<O_Oo00Oo000O0(4.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterEdit As EventString
			Get
				Return Me.ooO0_._O_o.
			End Get
			Set(value As EventString)
				Me.ooO0_._O_o. = value
			End Set
		End Property

		' Token: 0x17000FE2 RID: 4066
		' (get) Token: 0x0600452B RID: 17707 RVA: 0x001C3AA1 File Offset: 0x001C1CA1
		' (set) Token: 0x0600452C RID: 17708 RVA: 0x001C3AA9 File Offset: 0x001C1CA9
		<Category("A.编辑")>
		<oO0oooo("0619")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("编辑框中内容发生变化时执行。")>
		<O_Oo00Oo000O0(4.1)>
		Public Property ChangeEdit As EventString
			Get
				Return Me.o0._0o0o.
			End Get
			Set(value As EventString)
				Me.o0._0o0o. = value
			End Set
		End Property

		' Token: 0x17000FE3 RID: 4067
		' (get) Token: 0x0600452D RID: 17709 RVA: 0x001C3AB2 File Offset: 0x001C1CB2
		' (set) Token: 0x0600452E RID: 17710 RVA: 0x001C3ABA File Offset: 0x001C1CBA
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("在编辑框(Editor)输入一字符键时执行。")>
		<Category("A.编辑")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0620")>
		<O_Oo00Oo000O0(4.2)>
		Public Property KeyPressEdit As EventString
			Get
				Return Me.O_Oo.OOO0_0O00.
			End Get
			Set(value As EventString)
				Me.O_Oo.OOO0_0O00. = value
			End Set
		End Property

		' Token: 0x17000FE4 RID: 4068
		' (get) Token: 0x0600452F RID: 17711 RVA: 0x001C3AC3 File Offset: 0x001C1CC3
		' (set) Token: 0x06004530 RID: 17712 RVA: 0x001C3ACB File Offset: 0x001C1CCB
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0622")>
		<Description("在编辑状态时，按下一按键时执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("A.编辑")>
		<O_Oo00Oo000O0(4.3)>
		Public Property KeyDownEdit As EventString
			Get
				Return Me.O0.0O__OOOOOOO.
			End Get
			Set(value As EventString)
				Me.O0.0O__OOOOOOO. = value
			End Set
		End Property

		' Token: 0x17000FE5 RID: 4069
		' (get) Token: 0x06004531 RID: 17713 RVA: 0x001C3AD4 File Offset: 0x001C1CD4
		' (set) Token: 0x06004532 RID: 17714 RVA: 0x001C3ADC File Offset: 0x001C1CDC
		<oO0oooo("0623")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("A.编辑")>
		<Description("在编辑状态时，松开一按键时执行。")>
		<O_Oo00Oo000O0(4.4)>
		Public Property KeyUpEdit As EventString
			Get
				Return Me.o_0ooo._.
			End Get
			Set(value As EventString)
				Me.o_0ooo._. = value
			End Set
		End Property

		' Token: 0x17000FE6 RID: 4070
		' (get) Token: 0x06004533 RID: 17715 RVA: 0x001C3AE5 File Offset: 0x001C1CE5
		' (set) Token: 0x06004534 RID: 17716 RVA: 0x001C3AED File Offset: 0x001C1CED
		<oO0oooo("0642")>
		<Category("A.编辑")>
		<Description("单击单元格按钮后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(4.5)>
		<O0O0oOO00_0OO(True)>
		Public Property CellButtonClick As EventString
			Get
				Return Me.OOO0_0_.oo.
			End Get
			Set(value As EventString)
				Me.OOO0_0_.oo. = value
			End Set
		End Property

		' Token: 0x17000FE7 RID: 4071
		' (get) Token: 0x06004535 RID: 17717 RVA: 0x001C3AF6 File Offset: 0x001C1CF6
		' (set) Token: 0x06004536 RID: 17718 RVA: 0x001C3AFE File Offset: 0x001C1CFE
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("某一列的内容变化前执行，通常用户验证该列内容。")>
		<oO0oooo("0624")>
		<Category("B.数据")>
		<DisplayName("DataColChanging")>
		<O_Oo00Oo000O0(5.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataColChanging As EventString
			Get
				Return Me.o.OO0o0___.
			End Get
			Set(value As EventString)
				Me.o.OO0o0___. = value
			End Set
		End Property

		' Token: 0x17000FE8 RID: 4072
		' (get) Token: 0x06004537 RID: 17719 RVA: 0x001C3B07 File Offset: 0x001C1D07
		' (set) Token: 0x06004538 RID: 17720 RVA: 0x001C3B0F File Offset: 0x001C1D0F
		<DisplayName("DataColChanged")>
		<oO0oooo("0625")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("B.数据")>
		<Description("某一列的内容变化后执行，通常用于执行一些特定的操作和计算。")>
		<O_Oo00Oo000O0(6.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataColChanged As EventString
			Get
				Return Me.O__._OO0.
			End Get
			Set(value As EventString)
				Me.O__._OO0. = value
			End Set
		End Property

		' Token: 0x17000FE9 RID: 4073
		' (get) Token: 0x06004539 RID: 17721 RVA: 0x001C3B18 File Offset: 0x001C1D18
		' (set) Token: 0x0600453A RID: 17722 RVA: 0x001C3B20 File Offset: 0x001C1D20
		<Description("保存某一行之前执行，通常用于对数据进行保存前的验证！。")>
		<Category("B.数据")>
		<oO0oooo("0628")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(6.1)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeSaveDataRow As EventString
			Get
				Return Me.oo0._OOOo.
			End Get
			Set(value As EventString)
				Me.oo0._OOOo. = value
			End Set
		End Property

		' Token: 0x17000FEA RID: 4074
		' (get) Token: 0x0600453B RID: 17723 RVA: 0x001C3B29 File Offset: 0x001C1D29
		' (set) Token: 0x0600453C RID: 17724 RVA: 0x001C3B31 File Offset: 0x001C1D31
		<Description("保存某一行之后执行，通常用于对数据进行保存前的验证！。")>
		<oO0oooo("3755")>
		<Category("B.数据")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(6.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterSaveDataRow As EventString
			Get
				Return Me.o.O0o0o_0_o.
			End Get
			Set(value As EventString)
				Me.o.O0o0o_0_o. = value
			End Set
		End Property

		' Token: 0x17000FEB RID: 4075
		' (get) Token: 0x0600453D RID: 17725 RVA: 0x001C3B3A File Offset: 0x001C1D3A
		' (set) Token: 0x0600453E RID: 17726 RVA: 0x001C3B42 File Offset: 0x001C1D42
		<oO0oooo("0629")>
		<Category("C.增加行")>
		<Description("增加行之前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(8.1)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeAddDataRow As EventString
			Get
				Return Me.oo0OO.0o.
			End Get
			Set(value As EventString)
				Me.oo0OO.0o. = value
			End Set
		End Property

		' Token: 0x17000FEC RID: 4076
		' (get) Token: 0x0600453F RID: 17727 RVA: 0x001C3B4B File Offset: 0x001C1D4B
		' (set) Token: 0x06004540 RID: 17728 RVA: 0x001C3B53 File Offset: 0x001C1D53
		<Description("增加一行时执行，此时DataRow还处于孤立状态，并未真正增加到DataTable中。")>
		<oO0oooo("0630")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("C.增加行")>
		<O_Oo00Oo000O0(9.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowAdding As EventString
			Get
				Return Me.O00o.0o_0o_.
			End Get
			Set(value As EventString)
				Me.O00o.0o_0o_. = value
			End Set
		End Property

		' Token: 0x17000FED RID: 4077
		' (get) Token: 0x06004541 RID: 17729 RVA: 0x001C3B5C File Offset: 0x001C1D5C
		' (set) Token: 0x06004542 RID: 17730 RVA: 0x001C3B64 File Offset: 0x001C1D64
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("C.增加行")>
		<Description("增加一行后执行，此时DataRow已经真正增加到DataTable中。")>
		<O_Oo00Oo000O0(10.0)>
		<oO0oooo("0631")>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowAdded As EventString
			Get
				Return Me.oO_.oOO_oo0o.
			End Get
			Set(value As EventString)
				Me.oO_.oOO_oo0o. = value
			End Set
		End Property

		' Token: 0x17000FEE RID: 4078
		' (get) Token: 0x06004543 RID: 17731 RVA: 0x001C3B6D File Offset: 0x001C1D6D
		' (set) Token: 0x06004544 RID: 17732 RVA: 0x001C3B75 File Offset: 0x001C1D75
		<Description("删除行之前执行。")>
		<oO0oooo("0632")>
		<Category("D.删除行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(10.1)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeDeleteDataRow As EventString
			Get
				Return Me.oOOo._Oooo_o_.
			End Get
			Set(value As EventString)
				Me.oOOo._Oooo_o_. = value
			End Set
		End Property

		' Token: 0x17000FEF RID: 4079
		' (get) Token: 0x06004545 RID: 17733 RVA: 0x001C3B7E File Offset: 0x001C1D7E
		' (set) Token: 0x06004546 RID: 17734 RVA: 0x001C3B86 File Offset: 0x001C1D86
		<Description("删除某一行时执行。")>
		<oO0oooo("0633")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("D.删除行")>
		<O_Oo00Oo000O0(11.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowDeleting As EventString
			Get
				Return Me.O00.Ooo0oO__o.
			End Get
			Set(value As EventString)
				Me.O00.Ooo0oO__o. = value
			End Set
		End Property

		' Token: 0x17000FF0 RID: 4080
		' (get) Token: 0x06004547 RID: 17735 RVA: 0x001C3B8F File Offset: 0x001C1D8F
		' (set) Token: 0x06004548 RID: 17736 RVA: 0x001C3B97 File Offset: 0x001C1D97
		<oO0oooo("0634")>
		<Category("D.删除行")>
		<Description("删除某一行之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(12.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowDeleted As EventString
			Get
				Return Me.oo._0_ooO000o.
			End Get
			Set(value As EventString)
				Me.oo._0_ooO000o. = value
			End Set
		End Property

		' Token: 0x17000FF1 RID: 4081
		' (get) Token: 0x06004549 RID: 17737 RVA: 0x001C3BA0 File Offset: 0x001C1DA0
		' (set) Token: 0x0600454A RID: 17738 RVA: 0x001C3BA8 File Offset: 0x001C1DA8
		<Description("行的锁定状态发生变化之前执行。")>
		<Category("E.锁定行")>
		<oO0oooo("0635")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(13.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowLockedChanging As EventString
			Get
				Return Me.oOoO.o____o_0.
			End Get
			Set(value As EventString)
				Me.oOoO.o____o_0. = value
			End Set
		End Property

		' Token: 0x17000FF2 RID: 4082
		' (get) Token: 0x0600454B RID: 17739 RVA: 0x001C3BB1 File Offset: 0x001C1DB1
		' (set) Token: 0x0600454C RID: 17740 RVA: 0x001C3BB9 File Offset: 0x001C1DB9
		<oO0oooo("0636")>
		<Description("行的锁定状态发生变化之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("E.锁定行")>
		<O_Oo00Oo000O0(14.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DataRowLockedChanged As EventString
			Get
				Return Me.Oo0.0oo_.
			End Get
			Set(value As EventString)
				Me.Oo0.0oo_. = value
			End Set
		End Property

		' Token: 0x17000FF3 RID: 4083
		' (get) Token: 0x0600454D RID: 17741 RVA: 0x001C3BC2 File Offset: 0x001C1DC2
		' (set) Token: 0x0600454E RID: 17742 RVA: 0x001C3BCA File Offset: 0x001C1DCA
		<oO0oooo("0641")>
		<Category("F.选择")>
		<Description("选择不同记录后执行，也就是Current属性发生变化后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(14.0)>
		<O0O0oOO00_0OO(True)>
		Public Property CurrentChanged As EventString
			Get
				Return Me.o0oO._0.
			End Get
			Set(value As EventString)
				Me.o0oO._0. = value
			End Set
		End Property

		' Token: 0x17000FF4 RID: 4084
		' (get) Token: 0x0600454F RID: 17743 RVA: 0x001C3BD3 File Offset: 0x001C1DD3
		' (set) Token: 0x06004550 RID: 17744 RVA: 0x001C3BDB File Offset: 0x001C1DDB
		<oO0oooo("0640")>
		<Category("F.选择")>
		<Description("选择不同行后执行，也就是Position属性发生变化后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(15.0)>
		<O0O0oOO00_0OO(True)>
		Public Property PositionChanged As EventString
			Get
				Return Me.oO._O0oo_00.
			End Get
			Set(value As EventString)
				Me.oO._O0oo_00. = value
			End Set
		End Property

		' Token: 0x17000FF5 RID: 4085
		' (get) Token: 0x06004551 RID: 17745 RVA: 0x001C3BE4 File Offset: 0x001C1DE4
		' (set) Token: 0x06004552 RID: 17746 RVA: 0x001C3BEC File Offset: 0x001C1DEC
		<Description("选择不同的单元格前执行，也就是表的RowSel、ColSel属性发生变化前执行。")>
		<Category("F.选择")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(16.0)>
		<oO0oooo("0644")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeSelChange As EventString
			Get
				Return Me.oO0._0O_O0oO.
			End Get
			Set(value As EventString)
				Me.oO0._0O_O0oO. = value
			End Set
		End Property

		' Token: 0x17000FF6 RID: 4086
		' (get) Token: 0x06004553 RID: 17747 RVA: 0x001C3BF5 File Offset: 0x001C1DF5
		' (set) Token: 0x06004554 RID: 17748 RVA: 0x001C3BFD File Offset: 0x001C1DFD
		<Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")>
		<oO0oooo("0645")>
		<Category("F.选择")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(16.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterSelChange As EventString
			Get
				Return Me.O0O0__.o.
			End Get
			Set(value As EventString)
				Me.O0O0__.o. = value
			End Set
		End Property

		' Token: 0x17000FF7 RID: 4087
		' (get) Token: 0x06004555 RID: 17749 RVA: 0x001C3C06 File Offset: 0x001C1E06
		' (set) Token: 0x06004556 RID: 17750 RVA: 0x001C3C0E File Offset: 0x001C1E0E
		<Description("选择不同的区域前执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0646")>
		<Category("F.选择")>
		<O_Oo00Oo000O0(17.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeSelRangeChange As EventString
			Get
				Return Me.O.00_oO_OooOoO.
			End Get
			Set(value As EventString)
				Me.O.00_oO_OooOoO. = value
			End Set
		End Property

		' Token: 0x17000FF8 RID: 4088
		' (get) Token: 0x06004557 RID: 17751 RVA: 0x001C3C17 File Offset: 0x001C1E17
		' (set) Token: 0x06004558 RID: 17752 RVA: 0x001C3C1F File Offset: 0x001C1E1F
		<oO0oooo("0647")>
		<Description("选择不同的区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("F.选择")>
		<O_Oo00Oo000O0(17.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterSelRangeChange As EventString
			Get
				Return Me.O0o_.o_O.
			End Get
			Set(value As EventString)
				Me.O0o_.o_O. = value
			End Set
		End Property

		' Token: 0x17000FF9 RID: 4089
		' (get) Token: 0x06004559 RID: 17753 RVA: 0x001C3C28 File Offset: 0x001C1E28
		' (set) Token: 0x0600455A RID: 17754 RVA: 0x001C3C30 File Offset: 0x001C1E30
		<oO0oooo("1639")>
		<Category("G.复选")>
		<Description("修改行复选框状态前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(19.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeCheckRow As EventString
			Get
				Return Me.OO.0_O_OO.
			End Get
			Set(value As EventString)
				Me.OO.0_O_OO. = value
			End Set
		End Property

		' Token: 0x17000FFA RID: 4090
		' (get) Token: 0x0600455B RID: 17755 RVA: 0x001C3C39 File Offset: 0x001C1E39
		' (set) Token: 0x0600455C RID: 17756 RVA: 0x001C3C41 File Offset: 0x001C1E41
		<oO0oooo("1640")>
		<Category("G.复选")>
		<Description("修改行复选框状态后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(19.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterCheckRow As EventString
			Get
				Return Me.Oo.OoO0.
			End Get
			Set(value As EventString)
				Me.Oo.OoO0. = value
			End Set
		End Property

		' Token: 0x17000FFB RID: 4091
		' (get) Token: 0x0600455D RID: 17757 RVA: 0x001C3C4A File Offset: 0x001C1E4A
		' (set) Token: 0x0600455E RID: 17758 RVA: 0x001C3C52 File Offset: 0x001C1E52
		<oO0oooo("1847")>
		<Category("H.调整")>
		<Description("移动行后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(18.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterMoveRow As EventString
			Get
				Return Me.o0000oO_oo.__o.
			End Get
			Set(value As EventString)
				Me.o0000oO_oo.__o. = value
			End Set
		End Property

		' Token: 0x17000FFC RID: 4092
		' (get) Token: 0x0600455F RID: 17759 RVA: 0x001C3C5B File Offset: 0x001C1E5B
		' (set) Token: 0x06004560 RID: 17760 RVA: 0x001C3C63 File Offset: 0x001C1E63
		<oO0oooo("2271")>
		<Category("H.调整")>
		<Description("移动行前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(17.9)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeMoveRow As EventString
			Get
				Return Me.ooO0._oOoo.
			End Get
			Set(value As EventString)
				Me.ooO0._oOoo. = value
			End Set
		End Property

		' Token: 0x17000FFD RID: 4093
		' (get) Token: 0x06004561 RID: 17761 RVA: 0x001C3C6C File Offset: 0x001C1E6C
		' (set) Token: 0x06004562 RID: 17762 RVA: 0x001C3C74 File Offset: 0x001C1E74
		<Description("拖动列之前发生。")>
		<oO0oooo("0648")>
		<Category("H.调整")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(19.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeDragColumn As EventString
			Get
				Return Me.Oo_O.__0o_o__O.
			End Get
			Set(value As EventString)
				Me.Oo_O.__0o_o__O. = value
			End Set
		End Property

		' Token: 0x17000FFE RID: 4094
		' (get) Token: 0x06004563 RID: 17763 RVA: 0x001C3C7D File Offset: 0x001C1E7D
		' (set) Token: 0x06004564 RID: 17764 RVA: 0x001C3C85 File Offset: 0x001C1E85
		<oO0oooo("0649")>
		<Category("H.调整")>
		<Description("拖动列之后发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(20.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterDragColumn As EventString
			Get
				Return Me.o.00Oo__oO_o0o.
			End Get
			Set(value As EventString)
				Me.o.00Oo__oO_o0o. = value
			End Set
		End Property

		' Token: 0x17000FFF RID: 4095
		' (get) Token: 0x06004565 RID: 17765 RVA: 0x001C3C8E File Offset: 0x001C1E8E
		' (set) Token: 0x06004566 RID: 17766 RVA: 0x001C3C96 File Offset: 0x001C1E96
		<oO0oooo("0650")>
		<Category("H.调整")>
		<Description("调整冻结区之前发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(21.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeFreezeColumn As EventString
			Get
				Return Me.Oo0oo0.0O0o.
			End Get
			Set(value As EventString)
				Me.Oo0oo0.0O0o. = value
			End Set
		End Property

		' Token: 0x17001000 RID: 4096
		' (get) Token: 0x06004567 RID: 17767 RVA: 0x001C3C9F File Offset: 0x001C1E9F
		' (set) Token: 0x06004568 RID: 17768 RVA: 0x001C3CA7 File Offset: 0x001C1EA7
		<oO0oooo("0651")>
		<Category("H.调整")>
		<Description("调整冻结区之后发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(22.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterFreezeColumn As EventString
			Get
				Return Me.O_O0o0.Oo__0O.
			End Get
			Set(value As EventString)
				Me.O_O0o0.Oo__0O. = value
			End Set
		End Property

		' Token: 0x17001001 RID: 4097
		' (get) Token: 0x06004569 RID: 17769 RVA: 0x001C3CB0 File Offset: 0x001C1EB0
		' (set) Token: 0x0600456A RID: 17770 RVA: 0x001C3CB8 File Offset: 0x001C1EB8
		<oO0oooo("0652")>
		<Category("H.调整")>
		<Description("调整列宽之前发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(23.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeResizeColumn As EventString
			Get
				Return Me.o0._O_.
			End Get
			Set(value As EventString)
				Me.o0._O_. = value
			End Set
		End Property

		' Token: 0x17001002 RID: 4098
		' (get) Token: 0x0600456B RID: 17771 RVA: 0x001C3CC1 File Offset: 0x001C1EC1
		' (set) Token: 0x0600456C RID: 17772 RVA: 0x001C3CC9 File Offset: 0x001C1EC9
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0653")>
		<Category("H.调整")>
		<Description("调整列宽之后发生。")>
		<O_Oo00Oo000O0(24.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterResizeColumn As EventString
			Get
				Return Me.O___oo.O_00O.
			End Get
			Set(value As EventString)
				Me.O___oo.O_00O. = value
			End Set
		End Property

		' Token: 0x17001003 RID: 4099
		' (get) Token: 0x0600456D RID: 17773 RVA: 0x001C3CD2 File Offset: 0x001C1ED2
		' (set) Token: 0x0600456E RID: 17774 RVA: 0x001C3CDA File Offset: 0x001C1EDA
		<Category("H.调整")>
		<oO0oooo("0654")>
		<Description("调整行高之前发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(25.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeResizeRow As EventString
			Get
				Return Me.oO.o0_.
			End Get
			Set(value As EventString)
				Me.oO.o0_. = value
			End Set
		End Property

		' Token: 0x17001004 RID: 4100
		' (get) Token: 0x0600456F RID: 17775 RVA: 0x001C3CE3 File Offset: 0x001C1EE3
		' (set) Token: 0x06004570 RID: 17776 RVA: 0x001C3CEB File Offset: 0x001C1EEB
		<Description("调整行高之后发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0655")>
		<Category("H.调整")>
		<O_Oo00Oo000O0(26.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterResizeRow As EventString
			Get
				Return Me.O.oO_o_oOoo_.
			End Get
			Set(value As EventString)
				Me.O.oO_o_oOoo_. = value
			End Set
		End Property

		' Token: 0x17001005 RID: 4101
		' (get) Token: 0x06004571 RID: 17777 RVA: 0x001C3CF4 File Offset: 0x001C1EF4
		' (set) Token: 0x06004572 RID: 17778 RVA: 0x001C3CFC File Offset: 0x001C1EFC
		<oO0oooo("0656")>
		<Category("I.绘制")>
		<Description("绘制某一单元格的时候执行，该事件执行非常频繁，对性能影响极大，代码必需简洁高效,不能有耗时的计算和操作。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(28.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DrawCell As EventString
			Get
				Return Me.OO0_o_0oOO.0.
			End Get
			Set(value As EventString)
				Me.OO0_o_0oOO.0. = value
			End Set
		End Property

		' Token: 0x17001006 RID: 4102
		' (get) Token: 0x06004573 RID: 17779 RVA: 0x001C3D05 File Offset: 0x001C1F05
		' (set) Token: 0x06004574 RID: 17780 RVA: 0x001C3D0D File Offset: 0x001C1F0D
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1952")>
		<Category("I.绘制")>
		<Description("绘制某一行之前执行，通常用于动态设置行高。")>
		<O_Oo00Oo000O0(28.1)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeDrawRow As EventString
			Get
				Return Me.OoO0.O__0o.
			End Get
			Set(value As EventString)
				Me.OoO0.O__0o. = value
			End Set
		End Property

		' Token: 0x17001007 RID: 4103
		' (get) Token: 0x06004575 RID: 17781 RVA: 0x001C3D16 File Offset: 0x001C1F16
		' (set) Token: 0x06004576 RID: 17782 RVA: 0x001C3D1E File Offset: 0x001C1F1E
		<Description("重新加载数据之前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2057")>
		<Category("J.加载")>
		<O_Oo00Oo000O0(29.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeLoad As EventString
			Get
				Return Me.Oo__O.o.
			End Get
			Set(value As EventString)
				Me.Oo__O.o. = value
			End Set
		End Property

		' Token: 0x17001008 RID: 4104
		' (get) Token: 0x06004577 RID: 17783 RVA: 0x001C3D27 File Offset: 0x001C1F27
		' (set) Token: 0x06004578 RID: 17784 RVA: 0x001C3D2F File Offset: 0x001C1F2F
		<oO0oooo("2058")>
		<Description("重新加载数据之后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("J.加载")>
		<O_Oo00Oo000O0(30.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterLoad As EventString
			Get
				Return Me.oO.0oo0Oo.
			End Get
			Set(value As EventString)
				Me.oO.0oo0Oo. = value
			End Set
		End Property

		' Token: 0x17001009 RID: 4105
		' (get) Token: 0x06004579 RID: 17785 RVA: 0x001C3D38 File Offset: 0x001C1F38
		' (set) Token: 0x0600457A RID: 17786 RVA: 0x001C3D40 File Offset: 0x001C1F40
		<oO0oooo("2059")>
		<Category("K.筛选")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("筛选数据之前执行。")>
		<O_Oo00Oo000O0(31.0)>
		Public Property BeforeFilter As EventString
			Get
				Return Me.o0_00O.0o00__.
			End Get
			Set(value As EventString)
				Me.o0_00O.0o00__. = value
			End Set
		End Property

		' Token: 0x1700100A RID: 4106
		' (get) Token: 0x0600457B RID: 17787 RVA: 0x001C3D49 File Offset: 0x001C1F49
		' (set) Token: 0x0600457C RID: 17788 RVA: 0x001C3D51 File Offset: 0x001C1F51
		<oO0oooo("2060")>
		<Description("筛选数据之后执行。")>
		<Category("K.筛选")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(32.0)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterFilter As EventString
			Get
				Return Me.o000o.o0_0o.
			End Get
			Set(value As EventString)
				Me.o000o.o0_0o. = value
			End Set
		End Property

		' Token: 0x1700100B RID: 4107
		' (get) Token: 0x0600457D RID: 17789 RVA: 0x001C3D5A File Offset: 0x001C1F5A
		' (set) Token: 0x0600457E RID: 17790 RVA: 0x001C3D62 File Offset: 0x001C1F62
		<oO0oooo("2061")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("数据排序之前执行。")>
		<O0O0oOO00_0OO(True)>
		<Category("L.排序")>
		<O_Oo00Oo000O0(33.0)>
		Public Property BeforeSort As EventString
			Get
				Return Me.OOooOo_0_.O_O_.
			End Get
			Set(value As EventString)
				Me.OOooOo_0_.O_O_. = value
			End Set
		End Property

		' Token: 0x1700100C RID: 4108
		' (get) Token: 0x0600457F RID: 17791 RVA: 0x001C3D6B File Offset: 0x001C1F6B
		' (set) Token: 0x06004580 RID: 17792 RVA: 0x001C3D73 File Offset: 0x001C1F73
		<oO0oooo("2062")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("数据排序之后执行。")>
		<Category("L.排序")>
		<O_Oo00Oo000O0(34.0)>
		Public Property AfterSort As EventString
			Get
				Return Me.o_0ooo.OoO.
			End Get
			Set(value As EventString)
				Me.o_0ooo.OoO. = value
			End Set
		End Property

		' Token: 0x1700100D RID: 4109
		' (get) Token: 0x06004581 RID: 17793 RVA: 0x001C3D7C File Offset: 0x001C1F7C
		' (set) Token: 0x06004582 RID: 17794 RVA: 0x001C3D84 File Offset: 0x001C1F84
		<oO0oooo("1499")>
		<Category("M.鼠标与键盘")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("双击单元格后执行。")>
		<O_Oo00Oo000O0(37.0)>
		Public Property DoubleClick As EventString
			Get
				Return Me.OO0_oO.o000o_O.
			End Get
			Set(value As EventString)
				Me.OO0_oO.o000o_O. = value
			End Set
		End Property

		' Token: 0x1700100E RID: 4110
		' (get) Token: 0x06004583 RID: 17795 RVA: 0x001C3D8D File Offset: 0x001C1F8D
		' (set) Token: 0x06004584 RID: 17796 RVA: 0x001C3D95 File Offset: 0x001C1F95
		<Description("单击单元格后执行。")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2386")>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.0)>
		Public Property Click As EventString
			Get
				Return Me.o0o00.O.
			End Get
			Set(value As EventString)
				Me.o0o00.O. = value
			End Set
		End Property

		' Token: 0x1700100F RID: 4111
		' (get) Token: 0x06004585 RID: 17797 RVA: 0x001C3D9E File Offset: 0x001C1F9E
		' (set) Token: 0x06004586 RID: 17798 RVA: 0x001C3DA6 File Offset: 0x001C1FA6
		<oO0oooo("2678")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("鼠标进入某个单元格的时候执行。")>
		<Category("M.鼠标与键盘")>
		<O_Oo00Oo000O0(37.5)>
		Public Property MouseEnterCell As EventString
			Get
				Return Me.oO00._o0O_.
			End Get
			Set(value As EventString)
				Me.oO00._o0O_. = value
			End Set
		End Property

		' Token: 0x17001010 RID: 4112
		' (get) Token: 0x06004587 RID: 17799 RVA: 0x001C3DAF File Offset: 0x001C1FAF
		' (set) Token: 0x06004588 RID: 17800 RVA: 0x001C3DB7 File Offset: 0x001C1FB7
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2679")>
		<Category("M.鼠标与键盘")>
		<Description("鼠标离开某个单元格的时候执行。")>
		<O_Oo00Oo000O0(37.51)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseLeaveCell As EventString
			Get
				Return Me.o00OO.o0.
			End Get
			Set(value As EventString)
				Me.o00OO.o0. = value
			End Set
		End Property

		' Token: 0x17001011 RID: 4113
		' (get) Token: 0x06004589 RID: 17801 RVA: 0x001C3DC0 File Offset: 0x001C1FC0
		' (set) Token: 0x0600458A RID: 17802 RVA: 0x001C3DC8 File Offset: 0x001C1FC8
		<oO0oooo("3750")>
		<Category("M.鼠标与键盘")>
		<Description("鼠标停留在某个单元格的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(37.55)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseHoverCell As EventString
			Get
				Return Me.O.O0oo00oO.
			End Get
			Set(value As EventString)
				Me.O.O0oo00oO. = value
			End Set
		End Property

		' Token: 0x17001012 RID: 4114
		' (get) Token: 0x0600458B RID: 17803 RVA: 0x001C3DD1 File Offset: 0x001C1FD1
		' (set) Token: 0x0600458C RID: 17804 RVA: 0x001C3DD9 File Offset: 0x001C1FD9
		<oO0oooo("1642")>
		<Category("M.鼠标与键盘")>
		<Description("压下按键时执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(38.0)>
		Public Property KeyDown As EventString
			Get
				Return Me.O.0_0_0Oo00.
			End Get
			Set(value As EventString)
				Me.O.0_0_0Oo00. = value
			End Set
		End Property

		' Token: 0x17001013 RID: 4115
		' (get) Token: 0x0600458D RID: 17805 RVA: 0x001C3DE2 File Offset: 0x001C1FE2
		' (set) Token: 0x0600458E RID: 17806 RVA: 0x001C3DEA File Offset: 0x001C1FEA
		<oO0oooo("1643")>
		<Category("M.鼠标与键盘")>
		<Description("松开按键执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(39.0)>
		Public Property KeyUp As EventString
			Get
				Return Me.oo0OO.___0__0.
			End Get
			Set(value As EventString)
				Me.oo0OO.___0__0. = value
			End Set
		End Property

		' Token: 0x17001014 RID: 4116
		' (get) Token: 0x0600458F RID: 17807 RVA: 0x001C3DF3 File Offset: 0x001C1FF3
		' (set) Token: 0x06004590 RID: 17808 RVA: 0x001C3DFB File Offset: 0x001C1FFB
		<oO0oooo("2929")>
		<Category("M.鼠标与键盘")>
		<Description("双击行头时执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(37.6)>
		<O0O0oOO00_0OO(True)>
		Public Property DoubleClickRowHeader As EventString
			Get
				Return Me.oooo_0_.O_O0.
			End Get
			Set(value As EventString)
				Me.oooo_0_.O_O0. = value
			End Set
		End Property

		' Token: 0x17001015 RID: 4117
		' (get) Token: 0x06004591 RID: 17809 RVA: 0x001C3E04 File Offset: 0x001C2004
		' (set) Token: 0x06004592 RID: 17810 RVA: 0x001C3E0C File Offset: 0x001C200C
		<oO0oooo("2210")>
		<Category("N.附件")>
		<Description("向图片列或文件列添加文件的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(35.1)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeAttachFile As EventString
			Get
				Return Me.OoooO.0O_o.
			End Get
			Set(value As EventString)
				Me.OoooO.0O_o. = value
			End Set
		End Property

		' Token: 0x17001016 RID: 4118
		' (get) Token: 0x06004593 RID: 17811 RVA: 0x001C3E15 File Offset: 0x001C2015
		' (set) Token: 0x06004594 RID: 17812 RVA: 0x001C3E1D File Offset: 0x001C201D
		<oO0oooo("2637")>
		<Category("N.附件")>
		<Description("打开附件文件或者图片的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(35.2)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeOpenFile As EventString
			Get
				Return Me.o.0_oOoo.
			End Get
			Set(value As EventString)
				Me.o.0_oOoo. = value
			End Set
		End Property

		' Token: 0x17001017 RID: 4119
		' (get) Token: 0x06004595 RID: 17813 RVA: 0x001C3E26 File Offset: 0x001C2026
		' (set) Token: 0x06004596 RID: 17814 RVA: 0x001C3E2E File Offset: 0x001C202E
		<oO0oooo("2638")>
		<Category("N.附件")>
		<Description("添加附件文件或者图片的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(35.0)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeAddFile As EventString
			Get
				Return Me.oo.oOo_oo0O_.
			End Get
			Set(value As EventString)
				Me.oo.oOo_oo0O_. = value
			End Set
		End Property

		' Token: 0x17001018 RID: 4120
		' (get) Token: 0x06004597 RID: 17815 RVA: 0x001C3E37 File Offset: 0x001C2037
		' (set) Token: 0x06004598 RID: 17816 RVA: 0x001C3E3F File Offset: 0x001C203F
		<oO0oooo("2716")>
		<Category("N.附件")>
		<Description("删除附件文件或图片的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(35.3)>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeDeleteFile As EventString
			Get
				Return Me.O0_0_0o._OoO00.
			End Get
			Set(value As EventString)
				Me.O0_0_0o._OoO00. = value
			End Set
		End Property

		' Token: 0x17001019 RID: 4121
		' (get) Token: 0x06004599 RID: 17817 RVA: 0x001C3E48 File Offset: 0x001C2048
		' (set) Token: 0x0600459A RID: 17818 RVA: 0x001C3E50 File Offset: 0x001C2050
		<oO0oooo("0662")>
		<Category("O.杂项")>
		<Description("显示快捷菜单之前执行，可以在此禁止显示快捷菜单，或更改要显示的快捷菜单。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(36.0)>
		Public Property BeforeShowContextMenu As EventString
			Get
				Return Me.oO0OOO.O_.
			End Get
			Set(value As EventString)
				Me.oO0OOO.O_. = value
			End Set
		End Property

		' Token: 0x1700101A RID: 4122
		' (get) Token: 0x0600459B RID: 17819 RVA: 0x001C3E59 File Offset: 0x001C2059
		' (set) Token: 0x0600459C RID: 17820 RVA: 0x001C3E61 File Offset: 0x001C2061
		<oO0oooo("2357")>
		<Category("O.杂项")>
		<Description("滚动表格后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(40.0)>
		Public Property AfterScroll As EventString
			Get
				Return Me.o_oO.O_O.
			End Get
			Set(value As EventString)
				Me.o_oO.O_O. = value
			End Set
		End Property

		' Token: 0x04001BF5 RID: 7157
		Private <<EMPTY_NAME>> As oOo__OO_

		' Token: 0x04001BF6 RID: 7158
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BF7 RID: 7159
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BF8 RID: 7160
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BF9 RID: 7161
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BFA RID: 7162
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001BFB RID: 7163
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001BFC RID: 7164
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BFD RID: 7165
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BFE RID: 7166
		Private <<EMPTY_NAME>> As TableTypeEnum

		' Token: 0x04001BFF RID: 7167
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C00 RID: 7168
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C01 RID: 7169
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C02 RID: 7170
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C03 RID: 7171
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C04 RID: 7172
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C05 RID: 7173
		Private <<EMPTY_NAME>> As GridLineDirectionEnum

		' Token: 0x04001C06 RID: 7174
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001C07 RID: 7175
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C08 RID: 7176
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001C09 RID: 7177
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001C0A RID: 7178
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C0B RID: 7179
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C0C RID: 7180
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C0D RID: 7181
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C0E RID: 7182
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C0F RID: 7183
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C10 RID: 7184
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C11 RID: 7185
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C12 RID: 7186
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C13 RID: 7187
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C14 RID: 7188
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C15 RID: 7189
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C16 RID: 7190
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C17 RID: 7191
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C18 RID: 7192
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C19 RID: 7193
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1A RID: 7194
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1B RID: 7195
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1C RID: 7196
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1D RID: 7197
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1E RID: 7198
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C1F RID: 7199
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C20 RID: 7200
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C21 RID: 7201
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C22 RID: 7202
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C23 RID: 7203
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C24 RID: 7204
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C25 RID: 7205
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C26 RID: 7206
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C27 RID: 7207
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C28 RID: 7208
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C29 RID: 7209
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2A RID: 7210
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2B RID: 7211
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2C RID: 7212
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2D RID: 7213
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2E RID: 7214
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C2F RID: 7215
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C30 RID: 7216
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C31 RID: 7217
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C32 RID: 7218
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C33 RID: 7219
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C34 RID: 7220
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C35 RID: 7221
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C36 RID: 7222
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C37 RID: 7223
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C38 RID: 7224
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C39 RID: 7225
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3A RID: 7226
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3B RID: 7227
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3C RID: 7228
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3D RID: 7229
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3E RID: 7230
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C3F RID: 7231
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C40 RID: 7232
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C41 RID: 7233
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C42 RID: 7234
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C43 RID: 7235
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C44 RID: 7236
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C45 RID: 7237
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C46 RID: 7238
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C47 RID: 7239
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C48 RID: 7240
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001C49 RID: 7241
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C4A RID: 7242
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C4B RID: 7243
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001C4C RID: 7244
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001C4D RID: 7245
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
