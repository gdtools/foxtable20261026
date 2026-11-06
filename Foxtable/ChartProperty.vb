Imports System
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x020003F7 RID: 1015
	Friend Class ChartProperty
		Inherits ControlPropertyBase

		' Token: 0x06004188 RID: 16776 RVA: 0x001C00AD File Offset: 0x001BE2AD
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o000o.OOoOoo. = CType(A_0.ChildControl, OO___O_)
		End Sub

		' Token: 0x17000E1E RID: 3614
		' (get) Token: 0x06004189 RID: 16777 RVA: 0x001C00C7 File Offset: 0x001BE2C7
		' (set) Token: 0x0600418A RID: 16778 RVA: 0x001C00CF File Offset: 0x001BE2CF
		<oO0oooo("6014")>
		<Description("单击某个图系或数据点后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<DisplayName("Click")>
		<Category("鼠标")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property ChartClick As EventString
			Get
				Return Me.o000o.OOoOoo.
			End Get
			Set(value As EventString)
				Me.o000o.OOoOoo. = value
			End Set
		End Property

		' Token: 0x17000E1F RID: 3615
		' (get) Token: 0x0600418B RID: 16779 RVA: 0x001C00D8 File Offset: 0x001BE2D8
		' (set) Token: 0x0600418C RID: 16780 RVA: 0x001C00E0 File Offset: 0x001BE2E0
		<Description("双击某个图系或数据点后执行")>
		<oO0oooo("6014")>
		<Category("鼠标")>
		<DisplayName("DoubleClick")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property ChartDoubleClick As EventString
			Get
				Return Me.O_0.OO.
			End Get
			Set(value As EventString)
				Me.O_0.OO. = value
			End Set
		End Property

		' Token: 0x17000E20 RID: 3616
		' (get) Token: 0x0600418D RID: 16781 RVA: 0x001C00E9 File Offset: 0x001BE2E9
		' (set) Token: 0x0600418E RID: 16782 RVA: 0x001C00F1 File Offset: 0x001BE2F1
		<oO0oooo("6014")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("鼠标")>
		<Description("鼠标悬停在某个图系或数据点后执行")>
		<DisplayName("MouseHover")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property ChartMouseHover As EventString
			Get
				Return Me.OOO.0O__OOO00_.
			End Get
			Set(value As EventString)
				Me.OOO.0O__OOO00_. = value
			End Set
		End Property

		' Token: 0x17000E21 RID: 3617
		' (get) Token: 0x0600418F RID: 16783 RVA: 0x001C00FA File Offset: 0x001BE2FA
		' (set) Token: 0x06004190 RID: 16784 RVA: 0x001C0102 File Offset: 0x001BE302
		<DisplayName("MouseDown")>
		<Description("在某个图系或数据点上按下鼠标后执行")>
		<O_Oo00Oo000O0(4.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("6014")>
		<Category("鼠标")>
		<O0O0oOO00_0OO(True)>
		Public Property ChartMouseDown As EventString
			Get
				Return Me.oo_.o0.
			End Get
			Set(value As EventString)
				Me.oo_.o0. = value
			End Set
		End Property

		' Token: 0x17000E22 RID: 3618
		' (get) Token: 0x06004191 RID: 16785 RVA: 0x001C010B File Offset: 0x001BE30B
		' (set) Token: 0x06004192 RID: 16786 RVA: 0x001C0113 File Offset: 0x001BE313
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("6014")>
		<Description("在某个图系或数据点上松开鼠标后执行")>
		<O_Oo00Oo000O0(5.0)>
		<Category("鼠标")>
		<DisplayName("MouseUp")>
		<O0O0oOO00_0OO(True)>
		Public Property ChartMouseUp As EventString
			Get
				Return Me.o_o_o.o_00.
			End Get
			Set(value As EventString)
				Me.o_o_o.o_00. = value
			End Set
		End Property

		' Token: 0x17000E23 RID: 3619
		' (get) Token: 0x06004193 RID: 16787 RVA: 0x001C011C File Offset: 0x001BE31C
		' (set) Token: 0x06004194 RID: 16788 RVA: 0x001C0124 File Offset: 0x001BE324
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<DisplayName("MouseMove")>
		<oO0oooo("6014")>
		<Description("鼠标经过某个图系或数据点时执行")>
		<Category("鼠标")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property ChartMouseMove As EventString
			Get
				Return Me.o0.0oOO0.
			End Get
			Set(value As EventString)
				Me.o0.0oOO0. = value
			End Set
		End Property

		' Token: 0x17000E24 RID: 3620
		' (get) Token: 0x06004195 RID: 16789 RVA: 0x001C012D File Offset: 0x001BE32D
		' (set) Token: 0x06004196 RID: 16790 RVA: 0x001C0135 File Offset: 0x001BE335
		<oO0oooo("6014")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("提示")>
		<DisplayName("ShowTooltip")>
		<Description("显示提示信息时执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property ChartShowTooltip As EventString
			Get
				Return Me.o_0.o_.
			End Get
			Set(value As EventString)
				Me.o_0.o_. = value
			End Set
		End Property

		' Token: 0x04001AE5 RID: 6885
		Private <<EMPTY_NAME>> As OO___O_

		' Token: 0x04001AE6 RID: 6886
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AE7 RID: 6887
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AE8 RID: 6888
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AE9 RID: 6889
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AEA RID: 6890
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AEB RID: 6891
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001AEC RID: 6892
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
