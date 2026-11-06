Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000478 RID: 1144
	<oO0oooo("2035")>
	<OoO0___o("RibbonDatePicker")>
	Friend Class RibbonDatePicker
		Inherits RibbonItem

		' Token: 0x06004C5A RID: 19546 RVA: 0x00200DD1 File Offset: 0x001FEFD1
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O_o._0oo0o0_0. = "日期:"
			Me.OO_._O0. = 75
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001112 RID: 4370
		' (get) Token: 0x06004C5B RID: 19547 RVA: 0x00200DF5 File Offset: 0x001FEFF5
		' (set) Token: 0x06004C5C RID: 19548 RVA: 0x00200DFD File Offset: 0x001FEFFD
		<Category("属性")>
		<DefaultValue("日期:")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		Public Property Label As String
			Get
				Return Me.O_o._0oo0o0_0.
			End Get
			Set(value As String)
				Me.O_o._0oo0o0_0. = value
			End Set
		End Property

		' Token: 0x17001113 RID: 4371
		' (get) Token: 0x06004C5D RID: 19549 RVA: 0x00200E06 File Offset: 0x001FF006
		' (set) Token: 0x06004C5E RID: 19550 RVA: 0x00200E0E File Offset: 0x001FF00E
		<Category("属性")>
		<DisplayName("宽度")>
		<O_Oo00Oo000O0(1.3)>
		Public Property TextAreaWidth As Integer
			Get
				Return Me.OO_._O0.
			End Get
			Set(value As Integer)
				Me.OO_._O0. = value
			End Set
		End Property

		' Token: 0x17001114 RID: 4372
		' (get) Token: 0x06004C5F RID: 19551 RVA: 0x00200E17 File Offset: 0x001FF017
		' (set) Token: 0x06004C60 RID: 19552 RVA: 0x00200E1F File Offset: 0x001FF01F
		<Category("事件")>
		<Description("取消修改后执行。")>
		<O_Oo00Oo000O0(0.1)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCanceled As EventString
			Get
				Return Me.O_o._0oo0o0_0.
			End Get
			Set(value As EventString)
				Me.O_o._0oo0o0_0. = value
			End Set
		End Property

		' Token: 0x17001115 RID: 4373
		' (get) Token: 0x06004C61 RID: 19553 RVA: 0x00200E28 File Offset: 0x001FF028
		' (set) Token: 0x06004C62 RID: 19554 RVA: 0x00200E30 File Offset: 0x001FF030
		<Description("提交修改后执行。")>
		<O_Oo00Oo000O0(0.2)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCommitted As EventString
			Get
				Return Me.o.o_0o_O0O_.
			End Get
			Set(value As EventString)
				Me.o.o_0o_O0O_. = value
			End Set
		End Property

		' Token: 0x17001116 RID: 4374
		' (get) Token: 0x06004C63 RID: 19555 RVA: 0x00200E39 File Offset: 0x001FF039
		' (set) Token: 0x06004C64 RID: 19556 RVA: 0x00200E41 File Offset: 0x001FF041
		<O_Oo00Oo000O0(0.3)>
		<Category("事件")>
		<Description("值改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.oo_0.oo__00__.
			End Get
			Set(value As EventString)
				Me.oo_0.oo__00__. = value
			End Set
		End Property

		' Token: 0x17001117 RID: 4375
		' (get) Token: 0x06004C65 RID: 19557 RVA: 0x00200E4A File Offset: 0x001FF04A
		' (set) Token: 0x06004C66 RID: 19558 RVA: 0x00200E52 File Offset: 0x001FF052
		<O_Oo00Oo000O0(0.4)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("获得输入焦点后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property GotFocus As EventString
			Get
				Return Me.ooO_oOoo.oo.
			End Get
			Set(value As EventString)
				Me.ooO_oOoo.oo. = value
			End Set
		End Property

		' Token: 0x17001118 RID: 4376
		' (get) Token: 0x06004C67 RID: 19559 RVA: 0x00200E5B File Offset: 0x001FF05B
		' (set) Token: 0x06004C68 RID: 19560 RVA: 0x00200E63 File Offset: 0x001FF063
		<O_Oo00Oo000O0(0.5)>
		<Description("失去输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property LostFocus As EventString
			Get
				Return Me.o_0.0OooO0.
			End Get
			Set(value As EventString)
				Me.o_0.0OooO0. = value
			End Set
		End Property

		' Token: 0x17001119 RID: 4377
		' (get) Token: 0x06004C69 RID: 19561 RVA: 0x00200E6C File Offset: 0x001FF06C
		' (set) Token: 0x06004C6A RID: 19562 RVA: 0x00200E6F File Offset: 0x001FF06F
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001F5E RID: 8030
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F5F RID: 8031
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F60 RID: 8032
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F61 RID: 8033
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F62 RID: 8034
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F63 RID: 8035
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F64 RID: 8036
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
