Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000408 RID: 1032
	Friend Class NumericComboBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x060043CF RID: 17359 RVA: 0x001C25FB File Offset: 0x001C07FB
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o0.OOOo. = CType(A_0.ChildControl, C1DropDownControl)
			Me.o0.OOOo..VerticalAlign = 1
		End Sub

		' Token: 0x17000F3A RID: 3898
		' (get) Token: 0x060043D0 RID: 17360 RVA: 0x001C2621 File Offset: 0x001C0821
		' (set) Token: 0x060043D1 RID: 17361 RVA: 0x001C2629 File Offset: 0x001C0829
		<MergableProperty(False)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("名称")>
		<Category("基本")>
		Public Overrides Property Name As String
			Get
				Return MyBase.Name
			End Get
			Set(value As String)
				MyBase.Name = value
				If Operators.CompareString(Me.BindingField, "", True) = 0 Then
					Me.o0.OOOo..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000F3B RID: 3899
		' (get) Token: 0x060043D2 RID: 17362 RVA: 0x001C2651 File Offset: 0x001C0851
		' (set) Token: 0x060043D3 RID: 17363 RVA: 0x001C265C File Offset: 0x001C085C
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("初始值")>
		Public Property Value As String
			Get
				Return Me.oo_._o_0_OO_00.
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					Me.oo_._o_0_OO_00. = ""
					Return
				End If
				Dim num As Decimal = 0D
				If Decimal.TryParse(value, num) Then
					Me.oo_._o_0_OO_00. = value
				End If
			End Set
		End Property

		' Token: 0x17000F3C RID: 3900
		' (get) Token: 0x060043D4 RID: 17364 RVA: 0x001C269C File Offset: 0x001C089C
		' (set) Token: 0x060043D5 RID: 17365 RVA: 0x001C26A4 File Offset: 0x001C08A4
		<Category("基本")>
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(False)>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<DisplayName("绑定到")>
		Public Property BindingField As String
			Get
				Return Me.OO__0o_.0.
			End Get
			Set(value As String)
				Me.OO__0o_.0. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o0.OOOo..Text = value
					Return
				End If
				Me.o0.OOOo..Text = Me.Name
			End Set
		End Property

		' Token: 0x17000F3D RID: 3901
		' (get) Token: 0x060043D6 RID: 17366 RVA: 0x001C26DA File Offset: 0x001C08DA
		' (set) Token: 0x060043D7 RID: 17367 RVA: 0x001C26E2 File Offset: 0x001C08E2
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.3)>
		<DisplayName("只读")>
		<Category("基本")>
		<Description("禁止用户修改。")>
		<MergableProperty(True)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o0.OOOo.
			End Get
			Set(value As BooleanEnum)
				Me.o0.OOOo. = value
			End Set
		End Property

		' Token: 0x17000F3E RID: 3902
		' (get) Token: 0x060043D8 RID: 17368 RVA: 0x001C26EC File Offset: 0x001C08EC
		' (set) Token: 0x060043D9 RID: 17369 RVA: 0x001C26FA File Offset: 0x001C08FA
		<Browsable(False)>
		<OooO0(False)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17000F3F RID: 3903
		' (get) Token: 0x060043DA RID: 17370 RVA: 0x001C26FC File Offset: 0x001C08FC
		' (set) Token: 0x060043DB RID: 17371 RVA: 0x001C270E File Offset: 0x001C090E
		<DisplayName("样式")>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(o00))>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.o0.OOOo.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.o0.OOOo. })
			End Set
		End Property

		' Token: 0x17000F40 RID: 3904
		' (get) Token: 0x060043DC RID: 17372 RVA: 0x001C272A File Offset: 0x001C092A
		' (set) Token: 0x060043DD RID: 17373 RVA: 0x001C2737 File Offset: 0x001C0937
		<DisplayName("边框样式")>
		<O_Oo00Oo000O0(0.2)>
		<DefaultValue(2)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o0.OOOo..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o0.OOOo..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000F41 RID: 3905
		' (get) Token: 0x060043DE RID: 17374 RVA: 0x001C2745 File Offset: 0x001C0945
		' (set) Token: 0x060043DF RID: 17375 RVA: 0x001C2752 File Offset: 0x001C0952
		<DefaultValue(-10197916)>
		<O_Oo00Oo000O0(0.41)>
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("边框颜色")>
		Public Property BorderColor As Color
			Get
				Return Me.o0.OOOo..BorderColor
			End Get
			Set(value As Color)
				Me.o0.OOOo..BorderColor = value
				If Me.o0.OOOo..BorderStyle <> BorderStyle.FixedSingle Then
					Me.o0.OOOo..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000F42 RID: 3906
		' (get) Token: 0x060043E0 RID: 17376 RVA: 0x001C277A File Offset: 0x001C097A
		' (set) Token: 0x060043E1 RID: 17377 RVA: 0x001C2787 File Offset: 0x001C0987
		<DefaultValue(0)>
		<DisplayName("文本位置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("外观")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o0.OOOo..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o0.OOOo..TextAlign = value
			End Set
		End Property

		' Token: 0x17000F43 RID: 3907
		' (get) Token: 0x060043E2 RID: 17378 RVA: 0x001C2795 File Offset: 0x001C0995
		' (set) Token: 0x060043E3 RID: 17379 RVA: 0x001C279D File Offset: 0x001C099D
		<O_Oo00Oo000O0(1.1)>
		<MergableProperty(True)>
		<DisplayName("格式符号")>
		<Category("输入控制")>
		Public Property FormatString As String
			Get
				Return Me.o0.OOOo.
			End Get
			Set(value As String)
				Me.o0.OOOo. = value
			End Set
		End Property

		' Token: 0x17000F44 RID: 3908
		' (get) Token: 0x060043E4 RID: 17380 RVA: 0x001C27A6 File Offset: 0x001C09A6
		' (set) Token: 0x060043E5 RID: 17381 RVA: 0x001C27B3 File Offset: 0x001C09B3
		<O_Oo00Oo000O0(2.0)>
		<Category("输入控制")>
		<DefaultValue(True)>
		<DisplayName("微调按钮")>
		<MergableProperty(True)>
		Public Property ShowUpDownButtons As Boolean
			Get
				Return Me.o0.OOOo..ShowUpDownButtons
			End Get
			Set(value As Boolean)
				Me.o0.OOOo..ShowUpDownButtons = value
			End Set
		End Property

		' Token: 0x17000F45 RID: 3909
		' (get) Token: 0x060043E6 RID: 17382 RVA: 0x001C27C1 File Offset: 0x001C09C1
		' (set) Token: 0x060043E7 RID: 17383 RVA: 0x001C27CE File Offset: 0x001C09CE
		<O_Oo00Oo000O0(3.0)>
		<Category("输入控制")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<DisplayName("下拉按钮")>
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.o0.OOOo..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.o0.OOOo..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x17000F46 RID: 3910
		' (get) Token: 0x060043E8 RID: 17384 RVA: 0x001C27DC File Offset: 0x001C09DC
		' (set) Token: 0x060043E9 RID: 17385 RVA: 0x001C27E4 File Offset: 0x001C09E4
		<DisplayName("微调增量")>
		<O_Oo00Oo000O0(4.0)>
		<Category("输入控制")>
		<Description("单击微调按钮时，增加或减少的值。")>
		<MergableProperty(True)>
		<DefaultValue(1)>
		Public Property Increment As Integer
			Get
				Return Me.o0.OOOo.
			End Get
			Set(value As Integer)
				Me.o0.OOOo. = value
			End Set
		End Property

		' Token: 0x17000F47 RID: 3911
		' (get) Token: 0x060043EA RID: 17386 RVA: 0x001C27ED File Offset: 0x001C09ED
		' (set) Token: 0x060043EB RID: 17387 RVA: 0x001C27F5 File Offset: 0x001C09F5
		<oO0oooo("0768")>
		<O_Oo00Oo000O0(0.1)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("文本改变后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property TextChanged As EventString
			Get
				Return Me.o0.OOOo.
			End Get
			Set(value As EventString)
				Me.o0.OOOo. = value
			End Set
		End Property

		' Token: 0x17000F48 RID: 3912
		' (get) Token: 0x060043EC RID: 17388 RVA: 0x001C27FE File Offset: 0x001C09FE
		' (set) Token: 0x060043ED RID: 17389 RVA: 0x001C2806 File Offset: 0x001C0A06
		<Category("事件")>
		<oO0oooo("0769")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("值改变后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property ValueChanged As EventString
			Get
				Return Me.OO__0o_.0.
			End Get
			Set(value As EventString)
				Me.OO__0o_.0. = value
			End Set
		End Property

		' Token: 0x04001BA7 RID: 7079
		Private <<EMPTY_NAME>> As C1DropDownControl

		' Token: 0x04001BA8 RID: 7080
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001BA9 RID: 7081
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BAA RID: 7082
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BAB RID: 7083
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001BAC RID: 7084
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BAD RID: 7085
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BAE RID: 7086
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
