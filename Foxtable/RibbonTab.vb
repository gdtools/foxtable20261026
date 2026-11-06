Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200048A RID: 1162
	<OoO0___o("RibbonTab")>
	<oO0oooo("1086")>
	Friend Class RibbonTab
		Inherits RibbonBase

		' Token: 0x06004D1E RID: 19742 RVA: 0x00201676 File Offset: 0x001FF876
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.OO.00o___0o. = True
			Me.OO_oOo0oo0.oO. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700116C RID: 4460
		' (get) Token: 0x06004D1F RID: 19743 RVA: 0x00201695 File Offset: 0x001FF895
		' (set) Token: 0x06004D20 RID: 19744 RVA: 0x0020169D File Offset: 0x001FF89D
		<Category("属性")>
		<TypeConverter(GetType(o0o))>
		<O_Oo00Oo000O0(100.0)>
		<DisplayName("功能区组")>
		Public Property TopTab As String
			Get
				Return Me.OO_oOo0oo0.oO.
			End Get
			Set(value As String)
				Me.OO_oOo0oo0.oO. = value
			End Set
		End Property

		' Token: 0x1700116D RID: 4461
		' (get) Token: 0x06004D21 RID: 19745 RVA: 0x002016A6 File Offset: 0x001FF8A6
		' (set) Token: 0x06004D22 RID: 19746 RVA: 0x002016C1 File Offset: 0x001FF8C1
		<Category("属性")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(2.0)>
		Public Property Text As String
			Get
				If Me.OO.00o___0o. Is Nothing Then
					Me.OO.00o___0o. = ""
				End If
				Return Me.OO.00o___0o.
			End Get
			Set(value As String)
				Me.OO.00o___0o. = value
			End Set
		End Property

		' Token: 0x1700116E RID: 4462
		' (get) Token: 0x06004D23 RID: 19747 RVA: 0x002016CA File Offset: 0x001FF8CA
		' (set) Token: 0x06004D24 RID: 19748 RVA: 0x002016D2 File Offset: 0x001FF8D2
		<DisplayName("图标")>
		<Description("一个16*16尺寸的图标，或者对应大小的图片。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		<Category("属性")>
		Public Property Image As String
			Get
				Return Me.ooo0_OoO.ooO.
			End Get
			Set(value As String)
				Me.ooo0_OoO.ooO. = value
			End Set
		End Property

		' Token: 0x1700116F RID: 4463
		' (get) Token: 0x06004D25 RID: 19749 RVA: 0x002016DB File Offset: 0x001FF8DB
		' (set) Token: 0x06004D26 RID: 19750 RVA: 0x002016E3 File Offset: 0x001FF8E3
		<DisplayName("提示")>
		<O_Oo00Oo000O0(4.0)>
		<Category("属性")>
		Public Property ToolTip As String
			Get
				Return Me.O.o_0o0.
			End Get
			Set(value As String)
				Me.O.o_0o0. = value
			End Set
		End Property

		' Token: 0x17001170 RID: 4464
		' (get) Token: 0x06004D27 RID: 19751 RVA: 0x002016EC File Offset: 0x001FF8EC
		' (set) Token: 0x06004D28 RID: 19752 RVA: 0x002016F4 File Offset: 0x001FF8F4
		<Category("属性")>
		<DisplayName("可用")>
		<O_Oo00Oo000O0(5.0)>
		<DefaultValue(True)>
		Public Property Enabled As Boolean
			Get
				Return Me.OO.00o___0o.
			End Get
			Set(value As Boolean)
				Me.OO.00o___0o. = value
			End Set
		End Property

		' Token: 0x17001171 RID: 4465
		' (get) Token: 0x06004D29 RID: 19753 RVA: 0x002016FD File Offset: 0x001FF8FD
		' (set) Token: 0x06004D2A RID: 19754 RVA: 0x00201705 File Offset: 0x001FF905
		<DefaultValue(True)>
		<DisplayName("可见")>
		<O_Oo00Oo000O0(6.0)>
		<Category("属性")>
		Public Property Visible As Boolean
			Get
				Return Me.OO_oOo0oo0.oO.
			End Get
			Set(value As Boolean)
				Me.OO_oOo0oo0.oO. = value
			End Set
		End Property

		' Token: 0x17001172 RID: 4466
		' (get) Token: 0x06004D2B RID: 19755 RVA: 0x0020170E File Offset: 0x001FF90E
		' (set) Token: 0x06004D2C RID: 19756 RVA: 0x00201715 File Offset: 0x001FF915
		<DisplayName("功能组")>
		<O_Oo00Oo000O0(7.0)>
		<Category("属性")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x17001173 RID: 4467
		' (get) Token: 0x06004D2D RID: 19757 RVA: 0x00201717 File Offset: 0x001FF917
		' (set) Token: 0x06004D2E RID: 19758 RVA: 0x0020171F File Offset: 0x001FF91F
		<O_Oo00Oo000O0(1.0)>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("选择功能区后执行。")>
		Public Property SelectTab As EventString
			Get
				Return Me.OO_oOo0oo0.oO.
			End Get
			Set(value As EventString)
				Me.OO_oOo0oo0.oO. = value
			End Set
		End Property

		' Token: 0x17001174 RID: 4468
		' (get) Token: 0x06004D2F RID: 19759 RVA: 0x00201728 File Offset: 0x001FF928
		' (set) Token: 0x06004D30 RID: 19760 RVA: 0x00201730 File Offset: 0x001FF930
		<O_Oo00Oo000O0(2.0)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("离开功能区后执行。")>
		Public Property DeselectTab As EventString
			Get
				Return Me.o__._00O0o.
			End Get
			Set(value As EventString)
				Me.o__._00O0o. = value
			End Set
		End Property

		' Token: 0x17001175 RID: 4469
		' (get) Token: 0x06004D31 RID: 19761 RVA: 0x00201739 File Offset: 0x001FF939
		' (set) Token: 0x06004D32 RID: 19762 RVA: 0x00201741 File Offset: 0x001FF941
		<O_Oo00Oo000O0(3.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Browsable(False)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Description("双击功能区的时候执行。")>
		Public Property DoubleClick As EventString
			Get
				Return Me.OO.00o___0o.
			End Get
			Set(value As EventString)
				Me.OO.00o___0o. = value
			End Set
		End Property

		' Token: 0x17001176 RID: 4470
		' (get) Token: 0x06004D33 RID: 19763 RVA: 0x0020174A File Offset: 0x001FF94A
		' (set) Token: 0x06004D34 RID: 19764 RVA: 0x00201752 File Offset: 0x001FF952
		<O_Oo00Oo000O0(4.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("鼠标进入的时候执行。")>
		<Category("事件")>
		Public Property MouseEnter As EventString
			Get
				Return Me.ooo0_OoO.ooO.
			End Get
			Set(value As EventString)
				Me.ooo0_OoO.ooO. = value
			End Set
		End Property

		' Token: 0x17001177 RID: 4471
		' (get) Token: 0x06004D35 RID: 19765 RVA: 0x0020175B File Offset: 0x001FF95B
		' (set) Token: 0x06004D36 RID: 19766 RVA: 0x00201763 File Offset: 0x001FF963
		<O_Oo00Oo000O0(5.0)>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<Description("鼠标离开的时候执行。")>
		Public Property MouseLeave As EventString
			Get
				Return Me.O0oO0OOoO_.0OO.
			End Get
			Set(value As EventString)
				Me.O0oO0OOoO_.0OO. = value
			End Set
		End Property

		' Token: 0x04001FA9 RID: 8105
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FAA RID: 8106
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FAB RID: 8107
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FAC RID: 8108
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001FAD RID: 8109
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001FAE RID: 8110
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FAF RID: 8111
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FB0 RID: 8112
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FB1 RID: 8113
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FB2 RID: 8114
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001FB3 RID: 8115
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
