Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000410 RID: 1040
	Friend Class SplitContainerProperty
		Inherits ControlPropertyBase

		' Token: 0x06004496 RID: 17558 RVA: 0x001C3188 File Offset: 0x001C1388
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O00o.__OOo_. = FixedPanel.Panel1
			Me.O00o.__OOo_. = CType(A_0.ChildControl, o0000O)
		End Sub

		' Token: 0x17000F99 RID: 3993
		' (get) Token: 0x06004497 RID: 17559 RVA: 0x001C31A9 File Offset: 0x001C13A9
		' (set) Token: 0x06004498 RID: 17560 RVA: 0x001C31B6 File Offset: 0x001C13B6
		<DefaultValue(0)>
		<O_Oo00Oo000O0(5.1)>
		<Category("位置")>
		<Description("停靠到容器的指定边框。")>
		<MergableProperty(False)>
		<DisplayName("停靠")>
		Public Property Dock As DockStyle
			Get
				Return Me.o_0_.Oo..Dock
			End Get
			Set(value As DockStyle)
				Me.o_0_.Oo..Dock = value
			End Set
		End Property

		' Token: 0x17000F9A RID: 3994
		' (get) Token: 0x06004499 RID: 17561 RVA: 0x001C31C4 File Offset: 0x001C13C4
		' (set) Token: 0x0600449A RID: 17562 RVA: 0x001C31D1 File Offset: 0x001C13D1
		<Category("基本")>
		<O_Oo00Oo000O0(3.2)>
		<MergableProperty(True)>
		<DefaultValue(1)>
		<Description("指示水平分割还是垂直分割")>
		<DisplayName("方向")>
		Public Property Orientation As Orientation
			Get
				Return Me.O00o.__OOo_..Orientation
			End Get
			Set(value As Orientation)
				Me.O00o.__OOo_..Orientation = value
			End Set
		End Property

		' Token: 0x17000F9B RID: 3995
		' (get) Token: 0x0600449B RID: 17563 RVA: 0x001C31DF File Offset: 0x001C13DF
		' (set) Token: 0x0600449C RID: 17564 RVA: 0x001C31F1 File Offset: 0x001C13F1
		<DisplayName("样式")>
		<TypeConverter(GetType(o00))>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DefaultValue("(none)")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O00o.__OOo_.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O00o.__OOo_. })
			End Set
		End Property

		' Token: 0x17000F9C RID: 3996
		' (get) Token: 0x0600449D RID: 17565 RVA: 0x001C320D File Offset: 0x001C140D
		' (set) Token: 0x0600449E RID: 17566 RVA: 0x001C321A File Offset: 0x001C141A
		<O_Oo00Oo000O0(3.1)>
		<DisplayName("边框")>
		<Category("外观")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O00o.__OOo_..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O00o.__OOo_..BorderStyle = value
				Me.O00o.__OOo_..Invalidate()
			End Set
		End Property

		' Token: 0x17000F9D RID: 3997
		' (get) Token: 0x0600449F RID: 17567 RVA: 0x001C3233 File Offset: 0x001C1433
		' (set) Token: 0x060044A0 RID: 17568 RVA: 0x001C3240 File Offset: 0x001C1440
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.4)>
		<DisplayName("分割条宽度")>
		<Category("外观")>
		<DefaultValue(4)>
		Public Property SplitterWidth As Integer
			Get
				Return Me.O00o.__OOo_..SplitterWidth
			End Get
			Set(value As Integer)
				Me.O00o.__OOo_..SplitterWidth = value
			End Set
		End Property

		' Token: 0x17000F9E RID: 3998
		' (get) Token: 0x060044A1 RID: 17569 RVA: 0x001C324E File Offset: 0x001C144E
		' (set) Token: 0x060044A2 RID: 17570 RVA: 0x001C3256 File Offset: 0x001C1456
		<O_Oo00Oo000O0(3.5)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(False)>
		<DisplayName("固定分割条")>
		<Description("是否禁止移动分割条。")>
		Public Property IsSplitterFixed As Boolean
			Get
				Return Me.O00o.__OOo_.
			End Get
			Set(value As Boolean)
				Me.O00o.__OOo_. = value
			End Set
		End Property

		' Token: 0x17000F9F RID: 3999
		' (get) Token: 0x060044A3 RID: 17571 RVA: 0x001C325F File Offset: 0x001C145F
		' (set) Token: 0x060044A4 RID: 17572 RVA: 0x001C326C File Offset: 0x001C146C
		<O_Oo00Oo000O0(3.6)>
		<MergableProperty(True)>
		<DisplayName("固定分区")>
		<OooO0(True)>
		<DefaultValue(1)>
		<Category("外观")>
		<Description("固定其中一个分区的大小，使得其大小不随分区面板大小的调整而调整。")>
		Public Property FixedPanel As FixedPanel
			Get
				Return Me.O00o.__OOo_..FixedPanel
			End Get
			Set(value As FixedPanel)
				Me.O00o.__OOo_..FixedPanel = value
			End Set
		End Property

		' Token: 0x17000FA0 RID: 4000
		' (get) Token: 0x060044A5 RID: 17573 RVA: 0x001C327A File Offset: 0x001C147A
		' (set) Token: 0x060044A6 RID: 17574 RVA: 0x001C328C File Offset: 0x001C148C
		<Category("外观(Panel1)")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("背景颜色")>
		<MergableProperty(True)>
		Public Property BackColorOfPanel1 As Color
			Get
				Return Me.O00o.__OOo_..oo0oO_O.oooO0O.().BackColor
			End Get
			Set(value As Color)
				Me.O00o.__OOo_..oo0oO_O.oooO0O.().BackColor = value
			End Set
		End Property

		' Token: 0x17000FA1 RID: 4001
		' (get) Token: 0x060044A7 RID: 17575 RVA: 0x001C329F File Offset: 0x001C149F
		' (set) Token: 0x060044A8 RID: 17576 RVA: 0x001C32B1 File Offset: 0x001C14B1
		<DefaultValue(False)>
		<MergableProperty(False)>
		<DisplayName("自动滚动")>
		<O_Oo00Oo000O0(4.0)>
		<Category("外观(Panel1)")>
		Public Property Panel1IsAutoScroll As Boolean
			Get
				Return Me.O00o.__OOo_..oo0oO_O.oooO0O.().AutoScroll
			End Get
			Set(value As Boolean)
				Me.O00o.__OOo_..oo0oO_O.oooO0O.().AutoScroll = value
			End Set
		End Property

		' Token: 0x17000FA2 RID: 4002
		' (get) Token: 0x060044A9 RID: 17577 RVA: 0x001C32C4 File Offset: 0x001C14C4
		' (set) Token: 0x060044AA RID: 17578 RVA: 0x001C32CC File Offset: 0x001C14CC
		<DefaultValue(False)>
		<Category("外观(Panel1)")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("默认隐藏")>
		Public Property Panel1Collapsed As Boolean
			Get
				Return Me.O.Oo_.
			End Get
			Set(value As Boolean)
				Me.O.Oo_. = value
			End Set
		End Property

		' Token: 0x17000FA3 RID: 4003
		' (get) Token: 0x060044AB RID: 17579 RVA: 0x001C32D5 File Offset: 0x001C14D5
		' (set) Token: 0x060044AC RID: 17580 RVA: 0x001C32E7 File Offset: 0x001C14E7
		<Category("外观(Panel2)")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("背景颜色")>
		<MergableProperty(True)>
		Public Property BackColorOfPanel2 As Color
			Get
				Return Me.O00o.__OOo_..o.Oo0oo000O.().BackColor
			End Get
			Set(value As Color)
				Me.O00o.__OOo_..o.Oo0oo000O.().BackColor = value
			End Set
		End Property

		' Token: 0x17000FA4 RID: 4004
		' (get) Token: 0x060044AD RID: 17581 RVA: 0x001C32FA File Offset: 0x001C14FA
		' (set) Token: 0x060044AE RID: 17582 RVA: 0x001C330C File Offset: 0x001C150C
		<MergableProperty(False)>
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(False)>
		<DisplayName("自动滚动")>
		<Category("外观(Panel2)")>
		Public Property Panel2IsAutoScroll As Boolean
			Get
				Return Me.O00o.__OOo_..o.Oo0oo000O.().AutoScroll
			End Get
			Set(value As Boolean)
				Me.O00o.__OOo_..o.Oo0oo000O.().AutoScroll = value
			End Set
		End Property

		' Token: 0x17000FA5 RID: 4005
		' (get) Token: 0x060044AF RID: 17583 RVA: 0x001C331F File Offset: 0x001C151F
		' (set) Token: 0x060044B0 RID: 17584 RVA: 0x001C3327 File Offset: 0x001C1527
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("默认隐藏")>
		<Category("外观(Panel2)")>
		<MergableProperty(False)>
		<DefaultValue(False)>
		Public Property Panel2Collapsed As Boolean
			Get
				Return Me.Ooo0_O0._OO.
			End Get
			Set(value As Boolean)
				Me.Ooo0_O0._OO. = value
			End Set
		End Property

		' Token: 0x17000FA6 RID: 4006
		' (get) Token: 0x060044B1 RID: 17585 RVA: 0x001C3330 File Offset: 0x001C1530
		' (set) Token: 0x060044B2 RID: 17586 RVA: 0x001C333D File Offset: 0x001C153D
		<Browsable(False)>
		<O_Oo00Oo000O0(400.0)>
		Public Property SplitterDistance2 As Integer
			Get
				Return Me.O00o.__OOo_..SplitterDistance
			End Get
			Set(value As Integer)
				Me.O00o.__OOo_. = value
			End Set
		End Property

		' Token: 0x17000FA7 RID: 4007
		' (get) Token: 0x060044B3 RID: 17587 RVA: 0x001C3346 File Offset: 0x001C1546
		' (set) Token: 0x060044B4 RID: 17588 RVA: 0x001C3353 File Offset: 0x001C1553
		<Browsable(False)>
		<O_Oo00Oo000O0(400.0)>
		<DefaultValue(1)>
		Public Property FixedPanel2 As FixedPanel
			Get
				Return Me.O00o.__OOo_..FixedPanel
			End Get
			Set(value As FixedPanel)
				Me.O00o.__OOo_. = value
			End Set
		End Property

		' Token: 0x17000FA8 RID: 4008
		' (get) Token: 0x060044B5 RID: 17589 RVA: 0x001C335C File Offset: 0x001C155C
		' (set) Token: 0x060044B6 RID: 17590 RVA: 0x001C3364 File Offset: 0x001C1564
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0829")>
		<Category("事件")>
		<Description("移动分割条之后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property SplitterMoved As EventString
			Get
				Return Me.O00o.__OOo_.
			End Get
			Set(value As EventString)
				Me.O00o.__OOo_. = value
			End Set
		End Property

		' Token: 0x04001BE7 RID: 7143
		Private <<EMPTY_NAME>> As o0000O

		' Token: 0x04001BE8 RID: 7144
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BE9 RID: 7145
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BEA RID: 7146
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BEB RID: 7147
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BEC RID: 7148
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001BED RID: 7149
		Friend <<EMPTY_NAME>> As FixedPanel

		' Token: 0x04001BEE RID: 7150
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BEF RID: 7151
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
