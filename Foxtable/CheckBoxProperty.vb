Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003F8 RID: 1016
	Friend Class CheckBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06004197 RID: 16791 RVA: 0x001C013E File Offset: 0x001BE33E
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O_oO0._o_0. = CType(A_0.ChildControl, C1CheckBox)
		End Sub

		' Token: 0x17000E25 RID: 3621
		' (get) Token: 0x06004198 RID: 16792 RVA: 0x001C0158 File Offset: 0x001BE358
		' (set) Token: 0x06004199 RID: 16793 RVA: 0x001C0160 File Offset: 0x001BE360
		<DisplayName("绑定到")>
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(False)>
		Public Property BindingField As String
			Get
				Return Me.oOO00oo.O.
			End Get
			Set(value As String)
				Me.oOO00oo.O. = value
			End Set
		End Property

		' Token: 0x17000E26 RID: 3622
		' (get) Token: 0x0600419A RID: 16794 RVA: 0x001C0169 File Offset: 0x001BE369
		' (set) Token: 0x0600419B RID: 16795 RVA: 0x001C0171 File Offset: 0x001BE371
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.3)>
		<Category("基本")>
		<Description("是否禁止用户修改。")>
		<DisplayName("只读")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O_oO0._o_0.
			End Get
			Set(value As BooleanEnum)
				Me.O_oO0._o_0. = value
			End Set
		End Property

		' Token: 0x17000E27 RID: 3623
		' (get) Token: 0x0600419C RID: 16796 RVA: 0x001C017A File Offset: 0x001BE37A
		' (set) Token: 0x0600419D RID: 16797 RVA: 0x001C0187 File Offset: 0x001BE387
		<O_Oo00Oo000O0(2.4)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("标题")>
		Public Overridable Property Text As String
			Get
				Return Me.O_oO0._o_0..Text
			End Get
			Set(value As String)
				Me.O_oO0._o_0..Text = value
			End Set
		End Property

		' Token: 0x17000E28 RID: 3624
		' (get) Token: 0x0600419E RID: 16798 RVA: 0x001C0195 File Offset: 0x001BE395
		' (set) Token: 0x0600419F RID: 16799 RVA: 0x001C01A2 File Offset: 0x001BE3A2
		<MergableProperty(True)>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(2.5)>
		<DisplayName("选中")>
		<Category("基本")>
		Public Property Checked As Boolean
			Get
				Return Me.O_oO0._o_0..Checked
			End Get
			Set(value As Boolean)
				Me.O_oO0._o_0..Checked = value
			End Set
		End Property

		' Token: 0x17000E29 RID: 3625
		' (get) Token: 0x060041A0 RID: 16800 RVA: 0x001C01B0 File Offset: 0x001BE3B0
		' (set) Token: 0x060041A1 RID: 16801 RVA: 0x001C01BD File Offset: 0x001BE3BD
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("外观")>
		<DisplayName("外观")>
		<O_Oo00Oo000O0(0.01)>
		Public Property Appearance As Appearance
			Get
				Return Me.O_oO0._o_0..Appearance
			End Get
			Set(value As Appearance)
				Me.O_oO0._o_0..Appearance = value
			End Set
		End Property

		' Token: 0x17000E2A RID: 3626
		' (get) Token: 0x060041A2 RID: 16802 RVA: 0x001C01CB File Offset: 0x001BE3CB
		' (set) Token: 0x060041A3 RID: 16803 RVA: 0x001C01D8 File Offset: 0x001BE3D8
		<DisplayName("复选框位置")>
		<O_Oo00Oo000O0(0.1)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(16)>
		Public Property CheckAlign As ContentAlignment
			Get
				Return Me.O_oO0._o_0..CheckAlign
			End Get
			Set(value As ContentAlignment)
				Me.O_oO0._o_0..CheckAlign = value
			End Set
		End Property

		' Token: 0x17000E2B RID: 3627
		' (get) Token: 0x060041A4 RID: 16804 RVA: 0x001C01E6 File Offset: 0x001BE3E6
		' (set) Token: 0x060041A5 RID: 16805 RVA: 0x001C01F3 File Offset: 0x001BE3F3
		<O_Oo00Oo000O0(0.2)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(16)>
		<DisplayName("文本位置")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.O_oO0._o_0..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.O_oO0._o_0..TextAlign = value
			End Set
		End Property

		' Token: 0x17000E2C RID: 3628
		' (get) Token: 0x060041A6 RID: 16806 RVA: 0x001C0201 File Offset: 0x001BE401
		' (set) Token: 0x060041A7 RID: 16807 RVA: 0x001C020E File Offset: 0x001BE40E
		<O_Oo00Oo000O0(0.3)>
		<MergableProperty(True)>
		<DefaultValue(32)>
		<DisplayName("图标位置")>
		<Category("外观")>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.O_oO0._o_0..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.O_oO0._o_0..ImageAlign = value
			End Set
		End Property

		' Token: 0x17000E2D RID: 3629
		' (get) Token: 0x060041A8 RID: 16808 RVA: 0x001C021C File Offset: 0x001BE41C
		' (set) Token: 0x060041A9 RID: 16809 RVA: 0x001C0229 File Offset: 0x001BE429
		<O_Oo00Oo000O0(0.4)>
		<Category("外观")>
		<Description("设置文本和图标的相对位置。")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("相对位置")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.O_oO0._o_0..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.O_oO0._o_0..TextImageRelation = value
			End Set
		End Property

		' Token: 0x17000E2E RID: 3630
		' (get) Token: 0x060041AA RID: 16810 RVA: 0x001C0237 File Offset: 0x001BE437
		' (set) Token: 0x060041AB RID: 16811 RVA: 0x001C0240 File Offset: 0x001BE440
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Category("外观")>
		<DisplayName("图标")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.5)>
		Public Property ImageFile As String
			Get
				Return Me.O_oO0._o_0.
			End Get
			Set(value As String)
				Dim flag As Boolean = Operators.CompareString(Me.O_oO0._o_0., "", True) = 0 And Operators.CompareString(value, "", True) > 0
				Me.O_oO0._o_0. = value
				Me.O_oO0._o_0..Image = OO_00oOO.GetImage(Me.O_oO0._o_0.)
			End Set
		End Property

		' Token: 0x17000E2F RID: 3631
		' (get) Token: 0x060041AC RID: 16812 RVA: 0x001C028F File Offset: 0x001BE48F
		' (set) Token: 0x060041AD RID: 16813 RVA: 0x001C0297 File Offset: 0x001BE497
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0781")>
		<Category("事件")>
		<Description("选中属性发生变化后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property CheckedChanged As EventString
			Get
				Return Me.O000.o.
			End Get
			Set(value As EventString)
				Me.O000.o. = value
			End Set
		End Property

		' Token: 0x17000E30 RID: 3632
		' (get) Token: 0x060041AE RID: 16814 RVA: 0x001C02A0 File Offset: 0x001BE4A0
		' (set) Token: 0x060041AF RID: 16815 RVA: 0x001C02AE File Offset: 0x001BE4AE
		<OooO0(False)>
		<Browsable(False)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17000E31 RID: 3633
		' (get) Token: 0x060041B0 RID: 16816 RVA: 0x001C02B0 File Offset: 0x001BE4B0
		' (set) Token: 0x060041B1 RID: 16817 RVA: 0x001C02C2 File Offset: 0x001BE4C2
		<TypeConverter(GetType(o00))>
		<O_Oo00Oo000O0(0.0)>
		<DisplayName("样式")>
		<Category("外观")>
		<DefaultValue("(default)")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O_oO0._o_0.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O_oO0._o_0. })
			End Set
		End Property

		' Token: 0x17000E32 RID: 3634
		' (get) Token: 0x060041B2 RID: 16818 RVA: 0x001C02DE File Offset: 0x001BE4DE
		' (set) Token: 0x060041B3 RID: 16819 RVA: 0x001C02EB File Offset: 0x001BE4EB
		<DefaultValue(-986896)>
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<Category("外观")>
		<DisplayName("背景颜色")>
		Public Overridable Property BackColor As Color
			Get
				Return Me.O_oO0._o_0..BackColor
			End Get
			Set(value As Color)
				Me.O_oO0._o_0..BackColor = value
			End Set
		End Property

		' Token: 0x04001AED RID: 6893
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001AEE RID: 6894
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AEF RID: 6895
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001AF0 RID: 6896
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AF1 RID: 6897
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
