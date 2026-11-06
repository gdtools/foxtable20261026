Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020002AE RID: 686
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RecordGridProperty
		Inherits PropertyBase

		' Token: 0x06002457 RID: 9303 RVA: 0x000FA7F7 File Offset: 0x000F89F7
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O.OOoo_o0. = True
			Me.oo_.000o0Oo0. = True
			Me.oo.o_O_Oo. = False
			Me.O.OOoo_o0. = CType(A_0.ChildControl, O0O__)
		End Sub

		' Token: 0x17000868 RID: 2152
		' (get) Token: 0x06002458 RID: 9304 RVA: 0x000FA826 File Offset: 0x000F8A26
		' (set) Token: 0x06002459 RID: 9305 RVA: 0x000FA82E File Offset: 0x000F8A2E
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("绑定表")>
		<Category("基本")>
		<TypeConverter(GetType(ooo_0O0))>
		Public Property TableName As String
			Get
				Return Me.O.OOoo_o0.
			End Get
			Set(value As String)
				Me.O.OOoo_o0. = value
				Me.O.OOoo_o0..oo0oO_O.oooO0O.(value)
			End Set
		End Property

		' Token: 0x17000869 RID: 2153
		' (get) Token: 0x0600245A RID: 9306 RVA: 0x000FA843 File Offset: 0x000F8A43
		' (set) Token: 0x0600245B RID: 9307 RVA: 0x000FA84B File Offset: 0x000F8A4B
		<O_Oo00Oo000O0(2.01)>
		<Category("基本")>
		<Editor(GetType(O00_), GetType(UITypeEditor))>
		<DisplayName("显示列")>
		Public Property Columns As String
			Get
				Return Me.oo_.000o0Oo0.
			End Get
			Set(value As String)
				Me.oo_.000o0Oo0. = value
			End Set
		End Property

		' Token: 0x1700086A RID: 2154
		' (get) Token: 0x0600245C RID: 9308 RVA: 0x000FA854 File Offset: 0x000F8A54
		' (set) Token: 0x0600245D RID: 9309 RVA: 0x000FA85C File Offset: 0x000F8A5C
		<DefaultValue(True)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(10.0)>
		<Description("打印窗口时是否打印此控件。")>
		<DisplayName("允许打印")>
		<Category("输出")>
		Public Property Printable As Boolean
			Get
				Return Me.oo_.000o0Oo0.
			End Get
			Set(value As Boolean)
				Me.oo_.000o0Oo0. = value
			End Set
		End Property

		' Token: 0x1700086B RID: 2155
		' (get) Token: 0x0600245E RID: 9310 RVA: 0x000FA865 File Offset: 0x000F8A65
		' (set) Token: 0x0600245F RID: 9311 RVA: 0x000FA86D File Offset: 0x000F8A6D
		<DefaultValue(False)>
		<Category("输出")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(10.1)>
		<Description("打印时是否从此控件开始另起一页。")>
		<DisplayName("另起一页")>
		Public Property NewPage As Boolean
			Get
				Return Me.oo.o_O_Oo.
			End Get
			Set(value As Boolean)
				Me.oo.o_O_Oo. = value
			End Set
		End Property

		' Token: 0x1700086C RID: 2156
		' (get) Token: 0x06002460 RID: 9312 RVA: 0x000FA876 File Offset: 0x000F8A76
		' (set) Token: 0x06002461 RID: 9313 RVA: 0x000FA87E File Offset: 0x000F8A7E
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("可见")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<Category("杂项")>
		Public Property Visible As Boolean
			Get
				Return Me.O.OOoo_o0.
			End Get
			Set(value As Boolean)
				Me.O.OOoo_o0. = value
			End Set
		End Property

		' Token: 0x1700086D RID: 2157
		' (get) Token: 0x06002462 RID: 9314 RVA: 0x000FA887 File Offset: 0x000F8A87
		' (set) Token: 0x06002463 RID: 9315 RVA: 0x000FA894 File Offset: 0x000F8A94
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

		' Token: 0x1700086E RID: 2158
		' (get) Token: 0x06002464 RID: 9316 RVA: 0x000FA8A2 File Offset: 0x000F8AA2
		' (set) Token: 0x06002465 RID: 9317 RVA: 0x000FA8B4 File Offset: 0x000F8AB4
		<O_Oo00Oo000O0(3.0)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue("宋体,9")>
		<DisplayName("字体")>
		Public Overridable Property Font As Font
			Get
				Return Me.o_0_.Oo..ChildControl.Font
			End Get
			Set(value As Font)
				Me.o_0_.Oo..ChildControl.Font = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x1700086F RID: 2159
		' (get) Token: 0x06002466 RID: 9318 RVA: 0x000FA8D1 File Offset: 0x000F8AD1
		' (set) Token: 0x06002467 RID: 9319 RVA: 0x000FA8DE File Offset: 0x000F8ADE
		<O_Oo00Oo000O0(1.0)>
		<Category("位置")>
		<DisplayName("左")>
		<MergableProperty(True)>
		Public Property Left As Integer
			Get
				Return Me.o_0_.Oo..Left
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Left = value
			End Set
		End Property

		' Token: 0x17000870 RID: 2160
		' (get) Token: 0x06002468 RID: 9320 RVA: 0x000FA8EC File Offset: 0x000F8AEC
		' (set) Token: 0x06002469 RID: 9321 RVA: 0x000FA8F9 File Offset: 0x000F8AF9
		<MergableProperty(True)>
		<DisplayName("上")>
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

		' Token: 0x17000871 RID: 2161
		' (get) Token: 0x0600246A RID: 9322 RVA: 0x000FA907 File Offset: 0x000F8B07
		' (set) Token: 0x0600246B RID: 9323 RVA: 0x000FA914 File Offset: 0x000F8B14
		<Category("位置")>
		<DisplayName("宽")>
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
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

		' Token: 0x17000872 RID: 2162
		' (get) Token: 0x0600246C RID: 9324 RVA: 0x000FA92F File Offset: 0x000F8B2F
		' (set) Token: 0x0600246D RID: 9325 RVA: 0x000FA93C File Offset: 0x000F8B3C
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DisplayName("高")>
		<Category("位置")>
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

		' Token: 0x17000873 RID: 2163
		' (get) Token: 0x0600246E RID: 9326 RVA: 0x000FA957 File Offset: 0x000F8B57
		' (set) Token: 0x0600246F RID: 9327 RVA: 0x000FA964 File Offset: 0x000F8B64
		<O_Oo00Oo000O0(5.0)>
		<MergableProperty(True)>
		<DisplayName("锚定")>
		<Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")>
		<Category("位置")>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o_0_.Oo..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o_0_.Oo..Anchor = value
			End Set
		End Property

		' Token: 0x17000874 RID: 2164
		' (get) Token: 0x06002470 RID: 9328 RVA: 0x000FA972 File Offset: 0x000F8B72
		' (set) Token: 0x06002471 RID: 9329 RVA: 0x000FA97F File Offset: 0x000F8B7F
		<MergableProperty(False)>
		<Description("停靠到容器的指定边框。")>
		<DisplayName("停靠")>
		<O_Oo00Oo000O0(5.1)>
		<Category("位置")>
		Public Property Dock As DockStyle
			Get
				Return Me.o_0_.Oo..Dock
			End Get
			Set(value As DockStyle)
				Me.o_0_.Oo..Dock = value
			End Set
		End Property

		' Token: 0x04000EF7 RID: 3831
		Private <<EMPTY_NAME>> As O0O__

		' Token: 0x04000EF8 RID: 3832
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EF9 RID: 3833
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EFA RID: 3834
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000EFB RID: 3835
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000EFC RID: 3836
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
