Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x02000167 RID: 359
	<OoO0___o("Control")>
	Friend Class ControlPropertyBase
		Inherits PropertyBase

		' Token: 0x06001037 RID: 4151 RVA: 0x00069E88 File Offset: 0x00068088
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.OO.00. = True
			Me.o0o____._o. = True
			Me.Oo.OO0. = True
			Me.oO_oOo_.O_Oo0. = Cursors.[Default]
			Me.o0O0.O. = True
			Me.O._o. = False
			Me.o_O0.O_. = A_0.ChildControl
		End Sub

		' Token: 0x17000324 RID: 804
		' (get) Token: 0x06001038 RID: 4152 RVA: 0x00069ED8 File Offset: 0x000680D8
		<MergableProperty(False)>
		<O_Oo00Oo000O0(1.00001)>
		<Category("基本")>
		<DisplayName("类型")>
		Public ReadOnly Property ControlType As String
			Get
				Return MyBase.Type.ToString()
			End Get
		End Property

		' Token: 0x17000325 RID: 805
		' (get) Token: 0x06001039 RID: 4153 RVA: 0x00069EF9 File Offset: 0x000680F9
		' (set) Token: 0x0600103A RID: 4154 RVA: 0x00069F06 File Offset: 0x00068106
		<DisplayName("左")>
		<MergableProperty(True)>
		<Category("位置")>
		<O_Oo00Oo000O0(1.0)>
		Public Property Left As Integer
			Get
				Return Me.o_0_.Oo..Left
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Left = value
			End Set
		End Property

		' Token: 0x17000326 RID: 806
		' (get) Token: 0x0600103B RID: 4155 RVA: 0x00069F14 File Offset: 0x00068114
		' (set) Token: 0x0600103C RID: 4156 RVA: 0x00069F21 File Offset: 0x00068121
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("上")>
		<MergableProperty(True)>
		<Category("位置")>
		Public Property Top As Integer
			Get
				Return Me.o_0_.Oo..Top
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Top = value
			End Set
		End Property

		' Token: 0x17000327 RID: 807
		' (get) Token: 0x0600103D RID: 4157 RVA: 0x00069F2F File Offset: 0x0006812F
		' (set) Token: 0x0600103E RID: 4158 RVA: 0x00069F41 File Offset: 0x00068141
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("字体")>
		<DefaultValue("宋体,9")>
		<O_Oo00Oo000O0(3.0)>
		Public Overridable Property Font As Font
			Get
				Return Me.o_0_.Oo..ChildControl.Font
			End Get
			Set(value As Font)
				Me.o_0_.Oo..ChildControl.Font = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x17000328 RID: 808
		' (get) Token: 0x0600103F RID: 4159 RVA: 0x00069F5E File Offset: 0x0006815E
		' (set) Token: 0x06001040 RID: 4160 RVA: 0x00069F6B File Offset: 0x0006816B
		<MergableProperty(True)>
		<Category("位置")>
		<DisplayName("宽")>
		<O_Oo00Oo000O0(3.0)>
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

		' Token: 0x17000329 RID: 809
		' (get) Token: 0x06001041 RID: 4161 RVA: 0x00069F86 File Offset: 0x00068186
		' (set) Token: 0x06001042 RID: 4162 RVA: 0x00069F93 File Offset: 0x00068193
		<DisplayName("高")>
		<Category("位置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property Height As Integer
			Get
				Return Me.o_0_.Oo..Height
			End Get
			Set(value As Integer)
				If Not Me.o_0_.Oo..IsFixedHeight OrElse Not(TypeOf Me.o_0_.Oo..ChildControl Is C1Label) Then
					Me.o_0_.Oo..Height = value
				End If
			End Set
		End Property

		' Token: 0x1700032A RID: 810
		' (get) Token: 0x06001043 RID: 4163 RVA: 0x00069FC0 File Offset: 0x000681C0
		' (set) Token: 0x06001044 RID: 4164 RVA: 0x00069FCD File Offset: 0x000681CD
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("锚定")>
		<Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")>
		<Category("位置")>
		<MergableProperty(True)>
		<DefaultValue(5)>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o_0_.Oo..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o_0_.Oo..Anchor = value
			End Set
		End Property

		' Token: 0x1700032B RID: 811
		' (get) Token: 0x06001045 RID: 4165 RVA: 0x00069FDB File Offset: 0x000681DB
		' (set) Token: 0x06001046 RID: 4166 RVA: 0x00069FE8 File Offset: 0x000681E8
		<Category("位置")>
		<MergableProperty(False)>
		<DefaultValue(0)>
		<Description("停靠到容器的指定边框。")>
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

		' Token: 0x1700032C RID: 812
		' (get) Token: 0x06001047 RID: 4167 RVA: 0x00069FF6 File Offset: 0x000681F6
		' (set) Token: 0x06001048 RID: 4168 RVA: 0x00069FFE File Offset: 0x000681FE
		<O_Oo00Oo000O0(9.0)>
		<MergableProperty(True)>
		<OooO0(True)>
		<DisplayName("鼠标形状")>
		<Category("外观")>
		Public Property Cursor As Cursor
			Get
				Return Me.oO_oOo_.O_Oo0.
			End Get
			Set(value As Cursor)
				Me.oO_oOo_.O_Oo0. = value
			End Set
		End Property

		' Token: 0x1700032D RID: 813
		' (get) Token: 0x06001049 RID: 4169 RVA: 0x0006A007 File Offset: 0x00068207
		' (set) Token: 0x0600104A RID: 4170 RVA: 0x0006A014 File Offset: 0x00068214
		<DefaultValue(1)>
		<Browsable(False)>
		Public Property CursorType As CursorEnum
			Get
				Return ooO.OO_oOO0O.O00.(Me.Cursor)
			End Get
			Set(value As CursorEnum)
				Me.Cursor = ooO.OO_oOO0O.O00.(value)
			End Set
		End Property

		' Token: 0x1700032E RID: 814
		' (get) Token: 0x0600104B RID: 4171 RVA: 0x0006A022 File Offset: 0x00068222
		' (set) Token: 0x0600104C RID: 4172 RVA: 0x0006A034 File Offset: 0x00068234
		<O_Oo00Oo000O0(1.0)>
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("背景颜色")>
		Public Overridable Property BackColor As Color
			Get
				Return Me.o_0_.Oo..ChildControl.BackColor
			End Get
			Set(value As Color)
				If TypeOf Me.o_0_.Oo..ChildControl Is C1TextBox Then
					CType(Me.o_0_.Oo..ChildControl, C1TextBox).BackColor = Color.White
					CType(Me.o_0_.Oo..ChildControl, C1TextBox).BackColor = value
				Else
					Me.o_0_.Oo..ChildControl.BackColor = value
				End If
				If Me.o_0_.Oo..ControlType = ControlTypeEnum.Button Then
					CType(Me.o_0_.Oo..ChildControl, Button).UseVisualStyleBackColor = True
				End If
			End Set
		End Property

		' Token: 0x1700032F RID: 815
		' (get) Token: 0x0600104D RID: 4173 RVA: 0x0006A0BA File Offset: 0x000682BA
		' (set) Token: 0x0600104E RID: 4174 RVA: 0x0006A0CC File Offset: 0x000682CC
		<DisplayName("字体颜色")>
		<DefaultValue(-16777216)>
		<O_Oo00Oo000O0(1.01)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Overridable Property ForeColor As Color
			Get
				Return Me.o_0_.Oo..ChildControl.ForeColor
			End Get
			Set(value As Color)
				If TypeOf Me.o_0_.Oo..ChildControl Is C1TextBox Then
					CType(Me.o_0_.Oo..ChildControl, C1TextBox).ForeColor = value
					Return
				End If
				Me.o_0_.Oo..ChildControl.ForeColor = value
			End Set
		End Property

		' Token: 0x17000330 RID: 816
		' (get) Token: 0x0600104F RID: 4175 RVA: 0x0006A108 File Offset: 0x00068308
		' (set) Token: 0x06001050 RID: 4176 RVA: 0x0006A110 File Offset: 0x00068310
		<Category("杂项")>
		<O_Oo00Oo000O0(1.9)>
		<DisplayName("提示")>
		<MergableProperty(True)>
		Public Property ToolTip As String
			Get
				Return Me.o000.0o.
			End Get
			Set(value As String)
				Me.o000.0o. = value
			End Set
		End Property

		' Token: 0x17000331 RID: 817
		' (get) Token: 0x06001051 RID: 4177 RVA: 0x0006A119 File Offset: 0x00068319
		' (set) Token: 0x06001052 RID: 4178 RVA: 0x0006A121 File Offset: 0x00068321
		<Category("杂项")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("可见")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		Public Property Visible As Boolean
			Get
				Return Me.o0o____._o.
			End Get
			Set(value As Boolean)
				Me.o0o____._o. = value
			End Set
		End Property

		' Token: 0x17000332 RID: 818
		' (get) Token: 0x06001053 RID: 4179 RVA: 0x0006A12A File Offset: 0x0006832A
		' (set) Token: 0x06001054 RID: 4180 RVA: 0x0006A132 File Offset: 0x00068332
		<Category("杂项")>
		<DisplayName("可用")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.01)>
		<DefaultValue(True)>
		Public Property Enabled As Boolean
			Get
				Return Me.OO.00.
			End Get
			Set(value As Boolean)
				Me.OO.00. = value
			End Set
		End Property

		' Token: 0x17000333 RID: 819
		' (get) Token: 0x06001055 RID: 4181 RVA: 0x0006A13B File Offset: 0x0006833B
		' (set) Token: 0x06001056 RID: 4182 RVA: 0x0006A143 File Offset: 0x00068343
		<DisplayName("执行验证")>
		<Category("杂项")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<DefaultValue(True)>
		<Description("是否触发和执行Validating事件。")>
		Public Property CausesValidation As Boolean
			Get
				Return Me.Oo.OO0.
			End Get
			Set(value As Boolean)
				Me.Oo.OO0. = value
			End Set
		End Property

		' Token: 0x17000334 RID: 820
		' (get) Token: 0x06001057 RID: 4183 RVA: 0x0006A14C File Offset: 0x0006834C
		' (set) Token: 0x06001058 RID: 4184 RVA: 0x0006A159 File Offset: 0x00068359
		<MergableProperty(False)>
		<DisplayName("Tab键顺序")>
		<O_Oo00Oo000O0(3.0)>
		<Category("杂项")>
		<Description("确定用户按Tab键时，该控件获得焦点的顺序。")>
		Public Property TabIndex As Integer
			Get
				Return Me.o_0_.Oo..TabIndex
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..TabIndex = value
			End Set
		End Property

		' Token: 0x17000335 RID: 821
		' (get) Token: 0x06001059 RID: 4185 RVA: 0x0006A167 File Offset: 0x00068367
		' (set) Token: 0x0600105A RID: 4186 RVA: 0x0006A16F File Offset: 0x0006836F
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(False)>
		<MergableProperty(True)>
		<DisplayName("跳过Tab键")>
		<Description("确定用户能否使用TAB键将焦点移到该控件上。")>
		<Category("杂项")>
		Public Property TabStop As Boolean
			Get
				Return Me.o__0._oO_O_.
			End Get
			Set(value As Boolean)
				Me.o__0._oO_O_. = value
			End Set
		End Property

		' Token: 0x17000336 RID: 822
		' (get) Token: 0x0600105B RID: 4187 RVA: 0x0006A178 File Offset: 0x00068378
		' (set) Token: 0x0600105C RID: 4188 RVA: 0x0006A180 File Offset: 0x00068380
		<DefaultValue(False)>
		<Description("设置控件是否位于其它控件之上。")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.001)>
		<Category("杂项")>
		<DisplayName("最顶层")>
		Public Property TopMost As Boolean
			Get
				Return Me.o.0O_0_O_.
			End Get
			Set(value As Boolean)
				Me.o.0O_0_O_. = value
				If value Then
					Me.BackMost = False
					MyBase.Holder.BringToFront()
				End If
			End Set
		End Property

		' Token: 0x17000337 RID: 823
		' (get) Token: 0x0600105D RID: 4189 RVA: 0x0006A19E File Offset: 0x0006839E
		' (set) Token: 0x0600105E RID: 4190 RVA: 0x0006A1A6 File Offset: 0x000683A6
		<Description("设置控件是否位于其它控件之下。")>
		<Category("杂项")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.002)>
		<DisplayName("最底层")>
		<DefaultValue(False)>
		Public Property BackMost As Boolean
			Get
				Return Me.O___.O_OO_o0O.
			End Get
			Set(value As Boolean)
				Me.O___.O_OO_o0O. = value
				If value Then
					Me.TopMost = False
					MyBase.Holder.SendToBack()
				End If
			End Set
		End Property

		' Token: 0x17000338 RID: 824
		' (get) Token: 0x0600105F RID: 4191 RVA: 0x0006A1C4 File Offset: 0x000683C4
		' (set) Token: 0x06001060 RID: 4192 RVA: 0x0006A1CC File Offset: 0x000683CC
		<DisplayName("允许打印")>
		<O_Oo00Oo000O0(10.0)>
		<Category("输出")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		<Description("打印窗口时是否打印此控件。")>
		Public Property Printable As Boolean
			Get
				Return Me.o0O0.O.
			End Get
			Set(value As Boolean)
				Me.o0O0.O. = value
			End Set
		End Property

		' Token: 0x17000339 RID: 825
		' (get) Token: 0x06001061 RID: 4193 RVA: 0x0006A1D5 File Offset: 0x000683D5
		' (set) Token: 0x06001062 RID: 4194 RVA: 0x0006A1DD File Offset: 0x000683DD
		<O_Oo00Oo000O0(10.1)>
		<Category("输出")>
		<Description("打印时是否从此控件开始另起一页。")>
		<DisplayName("另起一页")>
		<MergableProperty(True)>
		<DefaultValue(False)>
		Public Property NewPage As Boolean
			Get
				Return Me.ooo_._0.
			End Get
			Set(value As Boolean)
				Me.ooo_._0. = value
			End Set
		End Property

		' Token: 0x1700033A RID: 826
		' (get) Token: 0x06001063 RID: 4195 RVA: 0x0006A1E6 File Offset: 0x000683E6
		' (set) Token: 0x06001064 RID: 4196 RVA: 0x0006A1EE File Offset: 0x000683EE
		<Description("打印此控件时是否打印边框。")>
		<O_Oo00Oo000O0(12.0)>
		<Category("输出")>
		<DefaultValue(False)>
		<MergableProperty(True)>
		<DisplayName("边框打印")>
		Public Property PrintBorder As Boolean
			Get
				Return Me.O._o.
			End Get
			Set(value As Boolean)
				Me.O._o. = value
			End Set
		End Property

		' Token: 0x1700033B RID: 827
		' (get) Token: 0x06001065 RID: 4197 RVA: 0x0006A1F7 File Offset: 0x000683F7
		' (set) Token: 0x06001066 RID: 4198 RVA: 0x0006A1FF File Offset: 0x000683FF
		<oO0oooo("0732")>
		<O_Oo00Oo000O0(1.0)>
		<Description("单击控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property Click As EventString
			Get
				Return Me.o0O._.
			End Get
			Set(value As EventString)
				Me.o0O._. = value
			End Set
		End Property

		' Token: 0x1700033C RID: 828
		' (get) Token: 0x06001067 RID: 4199 RVA: 0x0006A208 File Offset: 0x00068408
		' (set) Token: 0x06001068 RID: 4200 RVA: 0x0006A210 File Offset: 0x00068410
		<oO0oooo("0732")>
		<Category("事件")>
		<Description("用鼠标单击控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(8.9)>
		Public Property MouseClick As EventString
			Get
				Return Me.O_O_O_.___OO.
			End Get
			Set(value As EventString)
				Me.O_O_O_.___OO. = value
			End Set
		End Property

		' Token: 0x1700033D RID: 829
		' (get) Token: 0x06001069 RID: 4201 RVA: 0x0006A219 File Offset: 0x00068419
		' (set) Token: 0x0600106A RID: 4202 RVA: 0x0006A221 File Offset: 0x00068421
		<oO0oooo("0733")>
		<Description("双击控件后执行")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.1)>
		Public Property DoubleClick As EventString
			Get
				Return Me.OOoOoOO0O.O_o.
			End Get
			Set(value As EventString)
				Me.OOoOoOO0O.O_o. = value
			End Set
		End Property

		' Token: 0x1700033E RID: 830
		' (get) Token: 0x0600106B RID: 4203 RVA: 0x0006A22A File Offset: 0x0006842A
		' (set) Token: 0x0600106C RID: 4204 RVA: 0x0006A232 File Offset: 0x00068432
		<Description("选择控件后执行")>
		<oO0oooo("0734")>
		<O_Oo00Oo000O0(2.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		Public Property Enter As EventString
			Get
				Return Me.OO.00.
			End Get
			Set(value As EventString)
				Me.OO.00. = value
			End Set
		End Property

		' Token: 0x1700033F RID: 831
		' (get) Token: 0x0600106D RID: 4205 RVA: 0x0006A23B File Offset: 0x0006843B
		' (set) Token: 0x0600106E RID: 4206 RVA: 0x0006A243 File Offset: 0x00068443
		<oO0oooo("0735")>
		<Description("离开控件后执行")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property Leave As EventString
			Get
				Return Me.oOO_._OO_0_.
			End Get
			Set(value As EventString)
				Me.oOO_._OO_0_. = value
			End Set
		End Property

		' Token: 0x17000340 RID: 832
		' (get) Token: 0x0600106F RID: 4207 RVA: 0x0006A24C File Offset: 0x0006844C
		' (set) Token: 0x06001070 RID: 4208 RVA: 0x0006A254 File Offset: 0x00068454
		<oO0oooo("0736")>
		<Category("事件")>
		<Description("离开控件前执行，通常用来对输入内容进行校对。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property Validating As EventString
			Get
				Return Me.O.oO00O.
			End Get
			Set(value As EventString)
				Me.O.oO00O. = value
			End Set
		End Property

		' Token: 0x17000341 RID: 833
		' (get) Token: 0x06001071 RID: 4209 RVA: 0x0006A25D File Offset: 0x0006845D
		' (set) Token: 0x06001072 RID: 4210 RVA: 0x0006A265 File Offset: 0x00068465
		<O_Oo00Oo000O0(4.1)>
		<oO0oooo("0737")>
		<Description("从绑定字段读取数据的时候发生。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property DataFormat As EventString
			Get
				Return Me.o_.__000.
			End Get
			Set(value As EventString)
				Me.o_.__000. = value
			End Set
		End Property

		' Token: 0x17000342 RID: 834
		' (get) Token: 0x06001073 RID: 4211 RVA: 0x0006A26E File Offset: 0x0006846E
		' (set) Token: 0x06001074 RID: 4212 RVA: 0x0006A276 File Offset: 0x00068476
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0738")>
		<Category("事件")>
		<O_Oo00Oo000O0(4.2)>
		<Description("向绑定字段写入数据的时候发生。")>
		<O0O0oOO00_0OO(True)>
		Public Property DataParse As EventString
			Get
				Return Me.O0o_0_0_0.00.
			End Get
			Set(value As EventString)
				Me.O0o_0_0_0.00. = value
			End Set
		End Property

		' Token: 0x17000343 RID: 835
		' (get) Token: 0x06001075 RID: 4213 RVA: 0x0006A27F File Offset: 0x0006847F
		' (set) Token: 0x06001076 RID: 4214 RVA: 0x0006A287 File Offset: 0x00068487
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("输入字符时执行")>
		<O_Oo00Oo000O0(6.0)>
		<oO0oooo("0739")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property KeyPress As EventString
			Get
				Return Me.OO.0.
			End Get
			Set(value As EventString)
				Me.OO.0. = value
			End Set
		End Property

		' Token: 0x17000344 RID: 836
		' (get) Token: 0x06001077 RID: 4215 RVA: 0x0006A290 File Offset: 0x00068490
		' (set) Token: 0x06001078 RID: 4216 RVA: 0x0006A298 File Offset: 0x00068498
		<Description("压下按键时执行")>
		<oO0oooo("0741")>
		<O_Oo00Oo000O0(7.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property KeyDown As EventString
			Get
				Return Me.o0.O0_oOoOooOo.
			End Get
			Set(value As EventString)
				Me.o0.O0_oOoOooOo. = value
			End Set
		End Property

		' Token: 0x17000345 RID: 837
		' (get) Token: 0x06001079 RID: 4217 RVA: 0x0006A2A1 File Offset: 0x000684A1
		' (set) Token: 0x0600107A RID: 4218 RVA: 0x0006A2A9 File Offset: 0x000684A9
		<oO0oooo("0741")>
		<Description("松开按键执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(8.0)>
		Public Property KeyUp As EventString
			Get
				Return Me.O_0._oOOo_0_O0.
			End Get
			Set(value As EventString)
				Me.O_0._oOOo_0_O0. = value
			End Set
		End Property

		' Token: 0x17000346 RID: 838
		' (get) Token: 0x0600107B RID: 4219 RVA: 0x0006A2B2 File Offset: 0x000684B2
		' (set) Token: 0x0600107C RID: 4220 RVA: 0x0006A2BA File Offset: 0x000684BA
		<oO0oooo("0743")>
		<Category("事件")>
		<Description("鼠标进入控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(9.0)>
		Public Property MouseEnter As EventString
			Get
				Return Me.o_0.___.
			End Get
			Set(value As EventString)
				Me.o_0.___. = value
			End Set
		End Property

		' Token: 0x17000347 RID: 839
		' (get) Token: 0x0600107D RID: 4221 RVA: 0x0006A2C3 File Offset: 0x000684C3
		' (set) Token: 0x0600107E RID: 4222 RVA: 0x0006A2CB File Offset: 0x000684CB
		<Description("鼠标离开控件后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(10.0)>
		<oO0oooo("0744")>
		Public Property MouseLeave As EventString
			Get
				Return Me.OO_.o__OO0O0O.
			End Get
			Set(value As EventString)
				Me.OO_.o__OO0O0O. = value
			End Set
		End Property

		' Token: 0x17000348 RID: 840
		' (get) Token: 0x0600107F RID: 4223 RVA: 0x0006A2D4 File Offset: 0x000684D4
		' (set) Token: 0x06001080 RID: 4224 RVA: 0x0006A2DC File Offset: 0x000684DC
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(11.0)>
		<Description("在控件上移动鼠标的时候执行")>
		<oO0oooo("1320")>
		<O0O0oOO00_0OO(True)>
		Public Property MouseMove As EventString
			Get
				Return Me.O0_00.0.
			End Get
			Set(value As EventString)
				Me.O0_00.0. = value
			End Set
		End Property

		' Token: 0x17000349 RID: 841
		' (get) Token: 0x06001081 RID: 4225 RVA: 0x0006A2E5 File Offset: 0x000684E5
		' (set) Token: 0x06001082 RID: 4226 RVA: 0x0006A2ED File Offset: 0x000684ED
		<O_Oo00Oo000O0(12.0)>
		<Description("鼠标停留在控件上的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		<oO0oooo("0745")>
		Public Property MouseHover As EventString
			Get
				Return Me.OOoo.ooO_o0_O.
			End Get
			Set(value As EventString)
				Me.OOoo.ooO_o0_O. = value
			End Set
		End Property

		' Token: 0x1700034A RID: 842
		' (get) Token: 0x06001083 RID: 4227 RVA: 0x0006A2F6 File Offset: 0x000684F6
		' (set) Token: 0x06001084 RID: 4228 RVA: 0x0006A2FE File Offset: 0x000684FE
		<oO0oooo("0746")>
		<Description("按下鼠标后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(13.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property MouseDown As EventString
			Get
				Return Me.Oo_._0OOoo_o.
			End Get
			Set(value As EventString)
				Me.Oo_._0OOoo_o. = value
			End Set
		End Property

		' Token: 0x1700034B RID: 843
		' (get) Token: 0x06001085 RID: 4229 RVA: 0x0006A307 File Offset: 0x00068507
		' (set) Token: 0x06001086 RID: 4230 RVA: 0x0006A30F File Offset: 0x0006850F
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(14.0)>
		<Category("事件")>
		<Description("松开鼠标后执行")>
		<oO0oooo("0747")>
		<O0O0oOO00_0OO(True)>
		Public Property MouseUp As EventString
			Get
				Return Me.oOO_oo._O_0.
			End Get
			Set(value As EventString)
				Me.oOO_oo._O_0. = value
			End Set
		End Property

		' Token: 0x0400062A RID: 1578
		Friend <<EMPTY_NAME>> As Control

		' Token: 0x0400062B RID: 1579
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400062C RID: 1580
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400062D RID: 1581
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400062E RID: 1582
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400062F RID: 1583
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000630 RID: 1584
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000631 RID: 1585
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000632 RID: 1586
		Private <<EMPTY_NAME>> As Cursor

		' Token: 0x04000633 RID: 1587
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000634 RID: 1588
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000635 RID: 1589
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000636 RID: 1590
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000637 RID: 1591
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000638 RID: 1592
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000639 RID: 1593
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063A RID: 1594
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063B RID: 1595
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063C RID: 1596
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063D RID: 1597
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063E RID: 1598
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x0400063F RID: 1599
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000640 RID: 1600
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000641 RID: 1601
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000642 RID: 1602
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000643 RID: 1603
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000644 RID: 1604
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000645 RID: 1605
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000646 RID: 1606
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
