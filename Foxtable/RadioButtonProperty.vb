Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200040F RID: 1039
	Friend Class RadioButtonProperty
		Inherits ControlPropertyBase

		' Token: 0x0600447F RID: 17535 RVA: 0x001C3026 File Offset: 0x001C1226
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.oO0000.OO0oo. = CType(A_0.ChildControl, RadioButton)
		End Sub

		' Token: 0x17000F8E RID: 3982
		' (get) Token: 0x06004480 RID: 17536 RVA: 0x001C3040 File Offset: 0x001C1240
		' (set) Token: 0x06004481 RID: 17537 RVA: 0x001C3048 File Offset: 0x001C1248
		<O_Oo00Oo000O0(2.2)>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<DisplayName("绑定到")>
		<MergableProperty(False)>
		<Category("基本")>
		<DefaultValue("")>
		Public Property BindingField As String
			Get
				Return Me.Oo.O0OOo0.
			End Get
			Set(value As String)
				Me.Oo.O0OOo0. = value
			End Set
		End Property

		' Token: 0x17000F8F RID: 3983
		' (get) Token: 0x06004482 RID: 17538 RVA: 0x001C3051 File Offset: 0x001C1251
		' (set) Token: 0x06004483 RID: 17539 RVA: 0x001C3059 File Offset: 0x001C1259
		<DisplayName("只读")>
		<Description("是否禁止用户修改。")>
		<O_Oo00Oo000O0(2.3)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("基本")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.oO0000.OO0oo.
			End Get
			Set(value As BooleanEnum)
				Me.oO0000.OO0oo. = value
			End Set
		End Property

		' Token: 0x17000F90 RID: 3984
		' (get) Token: 0x06004484 RID: 17540 RVA: 0x001C3062 File Offset: 0x001C1262
		' (set) Token: 0x06004485 RID: 17541 RVA: 0x001C306F File Offset: 0x001C126F
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.4)>
		<DisplayName("标题")>
		<Category("基本")>
		Public Overridable Property Text As String
			Get
				Return Me.oO0000.OO0oo..Text
			End Get
			Set(value As String)
				Me.oO0000.OO0oo..Text = value
			End Set
		End Property

		' Token: 0x17000F91 RID: 3985
		' (get) Token: 0x06004486 RID: 17542 RVA: 0x001C307D File Offset: 0x001C127D
		' (set) Token: 0x06004487 RID: 17543 RVA: 0x001C308A File Offset: 0x001C128A
		<Category("基本")>
		<O_Oo00Oo000O0(2.5)>
		<DisplayName("选中")>
		<MergableProperty(True)>
		<DefaultValue(False)>
		Public Property Checked As Boolean
			Get
				Return Me.oO0000.OO0oo..Checked
			End Get
			Set(value As Boolean)
				Me.oO0000.OO0oo..Checked = value
			End Set
		End Property

		' Token: 0x17000F92 RID: 3986
		' (get) Token: 0x06004488 RID: 17544 RVA: 0x001C3098 File Offset: 0x001C1298
		' (set) Token: 0x06004489 RID: 17545 RVA: 0x001C30A5 File Offset: 0x001C12A5
		<DisplayName("外观样式")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.01)>
		<Category("外观")>
		Public Property Appearance As Appearance
			Get
				Return Me.oO0000.OO0oo..Appearance
			End Get
			Set(value As Appearance)
				Me.oO0000.OO0oo..Appearance = value
			End Set
		End Property

		' Token: 0x17000F93 RID: 3987
		' (get) Token: 0x0600448A RID: 17546 RVA: 0x001C30B3 File Offset: 0x001C12B3
		' (set) Token: 0x0600448B RID: 17547 RVA: 0x001C30BC File Offset: 0x001C12BC
		<DisplayName("图标")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property ImageFile As String
			Get
				Return Me.oO0000.OO0oo.
			End Get
			Set(value As String)
				Dim flag As Boolean = Operators.CompareString(Me.oO0000.OO0oo., "", True) = 0 And Operators.CompareString(value, "", True) > 0
				Me.oO0000.OO0oo. = value
				Me.oO0000.OO0oo..Image = OO_00oOO.GetImage(Me.oO0000.OO0oo.)
			End Set
		End Property

		' Token: 0x17000F94 RID: 3988
		' (get) Token: 0x0600448C RID: 17548 RVA: 0x001C310B File Offset: 0x001C130B
		' (set) Token: 0x0600448D RID: 17549 RVA: 0x001C3118 File Offset: 0x001C1318
		<Category("外观")>
		<O_Oo00Oo000O0(0.2)>
		<DisplayName("文本位置")>
		<MergableProperty(True)>
		<DefaultValue(16)>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.oO0000.OO0oo..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.oO0000.OO0oo..TextAlign = value
			End Set
		End Property

		' Token: 0x17000F95 RID: 3989
		' (get) Token: 0x0600448E RID: 17550 RVA: 0x001C3126 File Offset: 0x001C1326
		' (set) Token: 0x0600448F RID: 17551 RVA: 0x001C3133 File Offset: 0x001C1333
		<DefaultValue(16)>
		<O_Oo00Oo000O0(0.3)>
		<DisplayName("单选框位置")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property CheckAlign As ContentAlignment
			Get
				Return Me.oO0000.OO0oo..CheckAlign
			End Get
			Set(value As ContentAlignment)
				Me.oO0000.OO0oo..CheckAlign = value
			End Set
		End Property

		' Token: 0x17000F96 RID: 3990
		' (get) Token: 0x06004490 RID: 17552 RVA: 0x001C3141 File Offset: 0x001C1341
		' (set) Token: 0x06004491 RID: 17553 RVA: 0x001C314E File Offset: 0x001C134E
		<Category("外观")>
		<DefaultValue(32)>
		<DisplayName("图标位置")>
		<O_Oo00Oo000O0(0.4)>
		<MergableProperty(True)>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.oO0000.OO0oo..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.oO0000.OO0oo..ImageAlign = value
			End Set
		End Property

		' Token: 0x17000F97 RID: 3991
		' (get) Token: 0x06004492 RID: 17554 RVA: 0x001C315C File Offset: 0x001C135C
		' (set) Token: 0x06004493 RID: 17555 RVA: 0x001C3169 File Offset: 0x001C1369
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("外观")>
		<Description("设置文本和图标的相对位置。")>
		<O_Oo00Oo000O0(0.5)>
		<DisplayName("相对位置")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.oO0000.OO0oo..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.oO0000.OO0oo..TextImageRelation = value
			End Set
		End Property

		' Token: 0x17000F98 RID: 3992
		' (get) Token: 0x06004494 RID: 17556 RVA: 0x001C3177 File Offset: 0x001C1377
		' (set) Token: 0x06004495 RID: 17557 RVA: 0x001C317F File Offset: 0x001C137F
		<Description("选中属性发生变化后执行。")>
		<O_Oo00Oo000O0(0.1)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<oO0oooo("0781")>
		<O0O0oOO00_0OO(True)>
		Public Property CheckedChanged As EventString
			Get
				Return Me.oO0000.OO0oo.
			End Get
			Set(value As EventString)
				Me.oO0000.OO0oo. = value
			End Set
		End Property

		' Token: 0x04001BE2 RID: 7138
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001BE3 RID: 7139
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BE4 RID: 7140
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001BE5 RID: 7141
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BE6 RID: 7142
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
