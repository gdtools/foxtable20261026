Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000464 RID: 1124
	<OoO0___o("ContextCommand")>
	Friend Class ContextCommand
		Inherits RibbonBase

		' Token: 0x06004B63 RID: 19299 RVA: 0x001FFAAC File Offset: 0x001FDCAC
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.oOO_._0_00ooo. = True
			Me.Oo.oo. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700109D RID: 4253
		' (get) Token: 0x06004B64 RID: 19300 RVA: 0x001FFACB File Offset: 0x001FDCCB
		' (set) Token: 0x06004B65 RID: 19301 RVA: 0x001FFAD3 File Offset: 0x001FDCD3
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				Return Me.oOO_._0_00ooo.
			End Get
			Set(value As String)
				Me.oOO_._0_00ooo. = value
			End Set
		End Property

		' Token: 0x1700109E RID: 4254
		' (get) Token: 0x06004B66 RID: 19302 RVA: 0x001FFADC File Offset: 0x001FDCDC
		' (set) Token: 0x06004B67 RID: 19303 RVA: 0x001FFAE4 File Offset: 0x001FDCE4
		<DisplayName("图标")>
		<O_Oo00Oo000O0(3.0)>
		<Category("属性")>
		<Description("一个16*16尺寸的图标，或者对应大小的图片。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		Public Property Image As String
			Get
				Return Me.Oo.oo.
			End Get
			Set(value As String)
				Me.Oo.oo. = value
			End Set
		End Property

		' Token: 0x1700109F RID: 4255
		' (get) Token: 0x06004B68 RID: 19304 RVA: 0x001FFAED File Offset: 0x001FDCED
		' (set) Token: 0x06004B69 RID: 19305 RVA: 0x001FFAF5 File Offset: 0x001FDCF5
		<DisplayName("提示")>
		<O_Oo00Oo000O0(4.0)>
		<Category("属性")>
		Public Property ToolTip As String
			Get
				Return Me.Oo00O.O.
			End Get
			Set(value As String)
				Me.Oo00O.O. = value
			End Set
		End Property

		' Token: 0x170010A0 RID: 4256
		' (get) Token: 0x06004B6A RID: 19306 RVA: 0x001FFAFE File Offset: 0x001FDCFE
		' (set) Token: 0x06004B6B RID: 19307 RVA: 0x001FFB06 File Offset: 0x001FDD06
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(True)>
		<Category("属性")>
		<DisplayName("可用")>
		Public Property Enabled As Boolean
			Get
				Return Me.oOO_._0_00ooo.
			End Get
			Set(value As Boolean)
				Me.oOO_._0_00ooo. = value
			End Set
		End Property

		' Token: 0x170010A1 RID: 4257
		' (get) Token: 0x06004B6C RID: 19308 RVA: 0x001FFB0F File Offset: 0x001FDD0F
		' (set) Token: 0x06004B6D RID: 19309 RVA: 0x001FFB17 File Offset: 0x001FDD17
		<Category("属性")>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("可见")>
		<DefaultValue(True)>
		Public Property Visible As Boolean
			Get
				Return Me.Oo.oo.
			End Get
			Set(value As Boolean)
				Me.Oo.oo. = value
			End Set
		End Property

		' Token: 0x170010A2 RID: 4258
		' (get) Token: 0x06004B6E RID: 19310 RVA: 0x001FFB20 File Offset: 0x001FDD20
		' (set) Token: 0x06004B6F RID: 19311 RVA: 0x001FFB28 File Offset: 0x001FDD28
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("选中")>
		<Description("是否在菜单项目左侧显示选中标记。")>
		<DefaultValue(False)>
		<Category("属性")>
		Public Property Checked As Boolean
			Get
				Return Me.Oo00O.O.
			End Get
			Set(value As Boolean)
				Me.Oo00O.O. = value
			End Set
		End Property

		' Token: 0x170010A3 RID: 4259
		' (get) Token: 0x06004B70 RID: 19312 RVA: 0x001FFB31 File Offset: 0x001FDD31
		' (set) Token: 0x06004B71 RID: 19313 RVA: 0x001FFB39 File Offset: 0x001FDD39
		<DefaultValue(False)>
		<DisplayName("自动选中")>
		<Category("属性")>
		<O_Oo00Oo000O0(10.0)>
		<Description("单击菜单项目，是否自动切换其选中状态。")>
		Public Property CheckAutoToggle As Boolean
			Get
				Return Me.OoO.OO0.
			End Get
			Set(value As Boolean)
				Me.OoO.OO0. = value
			End Set
		End Property

		' Token: 0x170010A4 RID: 4260
		' (get) Token: 0x06004B72 RID: 19314 RVA: 0x001FFB42 File Offset: 0x001FDD42
		' (set) Token: 0x06004B73 RID: 19315 RVA: 0x001FFB4A File Offset: 0x001FDD4A
		<DefaultValue(False)>
		<Category("属性")>
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("显示分割线")>
		Public Property Delimiter As Boolean
			Get
				Return Me.O0_0.O.
			End Get
			Set(value As Boolean)
				Me.O0_0.O. = value
			End Set
		End Property

		' Token: 0x170010A5 RID: 4261
		' (get) Token: 0x06004B74 RID: 19316 RVA: 0x001FFB53 File Offset: 0x001FDD53
		' (set) Token: 0x06004B75 RID: 19317 RVA: 0x001FFB5B File Offset: 0x001FDD5B
		<Category("事件")>
		<Description("单击菜单项目后执行。")>
		<oO0oooo("1331")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property Click As EventString
			Get
				Return Me.Oo.oo.
			End Get
			Set(value As EventString)
				Me.Oo.oo. = value
			End Set
		End Property

		' Token: 0x170010A6 RID: 4262
		' (get) Token: 0x06004B76 RID: 19318 RVA: 0x001FFB64 File Offset: 0x001FDD64
		' (set) Token: 0x06004B77 RID: 19319 RVA: 0x001FFB6C File Offset: 0x001FDD6C
		<oO0oooo("1332")>
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Description("选中状态改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property CheckedChanged As EventString
			Get
				Return Me.oOO_._0_00ooo.
			End Get
			Set(value As EventString)
				Me.oOO_._0_00ooo. = value
			End Set
		End Property

		' Token: 0x04001EF0 RID: 7920
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EF1 RID: 7921
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EF2 RID: 7922
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EF3 RID: 7923
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EF4 RID: 7924
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EF5 RID: 7925
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EF6 RID: 7926
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EF7 RID: 7927
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EF8 RID: 7928
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001EF9 RID: 7929
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
