Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200046F RID: 1135
	Friend Class RibbonItem
		Inherits RibbonBase

		' Token: 0x06004C0A RID: 19466 RVA: 0x00200A6E File Offset: 0x001FEC6E
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O0o._0o_O. = True
			Me.O_0o_O.o0_O. = True
			Me.o_oo0.00OO0. = True
			Me.O0o._0o_O. = TextImageRelationEnum.Automatic
			Me.O0o._0o_O. = Color.Transparent
		End Sub

		' Token: 0x170010EE RID: 4334
		' (get) Token: 0x06004C0B RID: 19467 RVA: 0x00200A9E File Offset: 0x001FEC9E
		' (set) Token: 0x06004C0C RID: 19468 RVA: 0x00200AA6 File Offset: 0x001FECA6
		<DisplayName("大图标")>
		<O_Oo00Oo000O0(2.0)>
		<Description("一个32*32尺寸的图标，或者对应大小的图片。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("属性")>
		Public Property LargeImage As String
			Get
				Return Me.O0o._0o_O.
			End Get
			Set(value As String)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x170010EF RID: 4335
		' (get) Token: 0x06004C0D RID: 19469 RVA: 0x00200AAF File Offset: 0x001FECAF
		' (set) Token: 0x06004C0E RID: 19470 RVA: 0x00200AB7 File Offset: 0x001FECB7
		<Description("一个16*16尺寸的图标，或者对应大小的图片。")>
		<O_Oo00Oo000O0(3.0)>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("属性")>
		<DisplayName("小图标")>
		Public Property SmallImage As String
			Get
				Return Me.o._o0Oo00O.
			End Get
			Set(value As String)
				Me.o._o0Oo00O. = value
			End Set
		End Property

		' Token: 0x170010F0 RID: 4336
		' (get) Token: 0x06004C0F RID: 19471 RVA: 0x00200AC0 File Offset: 0x001FECC0
		' (set) Token: 0x06004C10 RID: 19472 RVA: 0x00200AC8 File Offset: 0x001FECC8
		<Description("图标和文本的相对位置。")>
		<Category("属性")>
		<DisplayName("图标位置")>
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(0)>
		Public Property TextImageRelation As TextImageRelationEnum
			Get
				Return Me.O0o._0o_O.
			End Get
			Set(value As TextImageRelationEnum)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x170010F1 RID: 4337
		' (get) Token: 0x06004C11 RID: 19473 RVA: 0x00200AD1 File Offset: 0x001FECD1
		' (set) Token: 0x06004C12 RID: 19474 RVA: 0x00200AD9 File Offset: 0x001FECD9
		<DisplayName("提示")>
		<Category("属性")>
		<O_Oo00Oo000O0(5.0)>
		Public Property ToolTip As String
			Get
				Return Me.o_oO.O00__.
			End Get
			Set(value As String)
				Me.o_oO.O00__. = value
			End Set
		End Property

		' Token: 0x170010F2 RID: 4338
		' (get) Token: 0x06004C13 RID: 19475 RVA: 0x00200AE2 File Offset: 0x001FECE2
		' (set) Token: 0x06004C14 RID: 19476 RVA: 0x00200AEA File Offset: 0x001FECEA
		<DisplayName("可用")>
		<DefaultValue(True)>
		<Category("属性")>
		<O_Oo00Oo000O0(6.0)>
		Public Property Enabled As Boolean
			Get
				Return Me.O0o._0o_O.
			End Get
			Set(value As Boolean)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x170010F3 RID: 4339
		' (get) Token: 0x06004C15 RID: 19477 RVA: 0x00200AF3 File Offset: 0x001FECF3
		' (set) Token: 0x06004C16 RID: 19478 RVA: 0x00200AFB File Offset: 0x001FECFB
		<O_Oo00Oo000O0(7.0)>
		<Category("属性")>
		<DisplayName("可见")>
		<DefaultValue(True)>
		Public Property Visible As Boolean
			Get
				Return Me.O_0o_O.o0_O.
			End Get
			Set(value As Boolean)
				Me.O_0o_O.o0_O. = value
			End Set
		End Property

		' Token: 0x170010F4 RID: 4340
		' (get) Token: 0x06004C17 RID: 19479 RVA: 0x00200B04 File Offset: 0x001FED04
		' (set) Token: 0x06004C18 RID: 19480 RVA: 0x00200B0C File Offset: 0x001FED0C
		<DefaultValue(16777215)>
		<Category("属性")>
		<DisplayName("字体颜色")>
		<O_Oo00Oo000O0(8.0)>
		Public Property ForeColor As Color
			Get
				Return Me.O0o._0o_O.
			End Get
			Set(value As Color)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x170010F5 RID: 4341
		' (get) Token: 0x06004C19 RID: 19481 RVA: 0x00200B15 File Offset: 0x001FED15
		' (set) Token: 0x06004C1A RID: 19482 RVA: 0x00200B1D File Offset: 0x001FED1D
		<DefaultValue(True)>
		<O_Oo00Oo000O0(8.0)>
		<Category("属性")>
		<DisplayName("自动隐藏标题")>
		<Description("当屏幕分辨率不够时，是否允许自动隐藏此按钮标题，以节省空间。")>
		Public Overridable Property AutoHideText As Boolean
			Get
				Return Me.o_oo0.00OO0.
			End Get
			Set(value As Boolean)
				Me.o_oo0.00OO0. = value
			End Set
		End Property

		' Token: 0x170010F6 RID: 4342
		' (get) Token: 0x06004C1B RID: 19483 RVA: 0x00200B26 File Offset: 0x001FED26
		' (set) Token: 0x06004C1C RID: 19484 RVA: 0x00200B2E File Offset: 0x001FED2E
		<Description("鼠标进入的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O_Oo00Oo000O0(1.0)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseEnter As EventString
			Get
				Return Me.O0o._0o_O.
			End Get
			Set(value As EventString)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x170010F7 RID: 4343
		' (get) Token: 0x06004C1D RID: 19485 RVA: 0x00200B37 File Offset: 0x001FED37
		' (set) Token: 0x06004C1E RID: 19486 RVA: 0x00200B3F File Offset: 0x001FED3F
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("鼠标离开的时候执行。")>
		<O_Oo00Oo000O0(2.0)>
		<O0O0oOO00_0OO(True)>
		Public Property MouseLeave As EventString
			Get
				Return Me.o._o0Oo00O.
			End Get
			Set(value As EventString)
				Me.o._o0Oo00O. = value
			End Set
		End Property

		' Token: 0x04001F3F RID: 7999
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F40 RID: 8000
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F41 RID: 8001
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F42 RID: 8002
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F43 RID: 8003
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F44 RID: 8004
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F45 RID: 8005
		Private <<EMPTY_NAME>> As TextImageRelationEnum

		' Token: 0x04001F46 RID: 8006
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F47 RID: 8007
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F48 RID: 8008
		Private <<EMPTY_NAME>> As Color
	End Class
End Namespace
