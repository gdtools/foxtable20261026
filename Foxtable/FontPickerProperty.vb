Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200017F RID: 383
	Friend Class FontPickerProperty
		Inherits ControlPropertyBase

		' Token: 0x060011F5 RID: 4597 RVA: 0x0006E730 File Offset: 0x0006C930
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O0_o0.o__. = CType(A_0.ChildControl, C1FontPicker)
		End Sub

		' Token: 0x170003CB RID: 971
		' (get) Token: 0x060011F6 RID: 4598 RVA: 0x0006E74A File Offset: 0x0006C94A
		' (set) Token: 0x060011F7 RID: 4599 RVA: 0x0006E752 File Offset: 0x0006C952
		<MergableProperty(True)>
		<Category("基本")>
		<Description("是否禁止用户修改。")>
		<DisplayName("只读")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.3)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O0_o0.o__.
			End Get
			Set(value As BooleanEnum)
				Me.O0_o0.o__. = value
			End Set
		End Property

		' Token: 0x170003CC RID: 972
		' (get) Token: 0x060011F8 RID: 4600 RVA: 0x0006E75B File Offset: 0x0006C95B
		' (set) Token: 0x060011F9 RID: 4601 RVA: 0x0006E763 File Offset: 0x0006C963
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(True)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<DefaultValue("")>
		Public Property BindingField As String
			Get
				Return Me.O0_o0.o__.
			End Get
			Set(value As String)
				Me.O0_o0.o__. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.O0_o0.o__..Text = value
					Return
				End If
				Me.O0_o0.o__..Text = Me.Name
			End Set
		End Property

		' Token: 0x170003CD RID: 973
		' (get) Token: 0x060011FA RID: 4602 RVA: 0x0006E79C File Offset: 0x0006C99C
		' (set) Token: 0x060011FB RID: 4603 RVA: 0x0006E7AA File Offset: 0x0006C9AA
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

		' Token: 0x170003CE RID: 974
		' (get) Token: 0x060011FC RID: 4604 RVA: 0x0006E7AC File Offset: 0x0006C9AC
		' (set) Token: 0x060011FD RID: 4605 RVA: 0x0006E7BE File Offset: 0x0006C9BE
		<O_Oo00Oo000O0(0.0)>
		<DefaultValue("(default)")>
		<DisplayName("样式")>
		<TypeConverter(GetType(o00))>
		<Category("外观")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O0_o0.o__.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O0_o0.o__. })
			End Set
		End Property

		' Token: 0x170003CF RID: 975
		' (get) Token: 0x060011FE RID: 4606 RVA: 0x0006E7DA File Offset: 0x0006C9DA
		' (set) Token: 0x060011FF RID: 4607 RVA: 0x0006E7E7 File Offset: 0x0006C9E7
		<DisplayName("边框样式")>
		<DefaultValue(2)>
		<O_Oo00Oo000O0(0.4)>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O0_o0.o__..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O0_o0.o__..BorderStyle = value
			End Set
		End Property

		' Token: 0x170003D0 RID: 976
		' (get) Token: 0x06001200 RID: 4608 RVA: 0x0006E7F5 File Offset: 0x0006C9F5
		' (set) Token: 0x06001201 RID: 4609 RVA: 0x0006E802 File Offset: 0x0006CA02
		<O_Oo00Oo000O0(0.41)>
		<DisplayName("边框颜色")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(-10197916)>
		Public Property BorderColor As Color
			Get
				Return Me.O0_o0.o__..BorderColor
			End Get
			Set(value As Color)
				Me.O0_o0.o__..BorderColor = value
				If Me.O0_o0.o__..BorderStyle <> BorderStyle.FixedSingle Then
					Me.O0_o0.o__..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x170003D1 RID: 977
		' (get) Token: 0x06001202 RID: 4610 RVA: 0x0006E82A File Offset: 0x0006CA2A
		' (set) Token: 0x06001203 RID: 4611 RVA: 0x0006E832 File Offset: 0x0006CA32
		<Category("事件")>
		<Description("选择不同字体后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		<oO0oooo("0769")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property ValueChanged As EventString
			Get
				Return Me.ooOoo.O.
			End Get
			Set(value As EventString)
				Me.ooOoo.O. = value
			End Set
		End Property

		' Token: 0x040006E2 RID: 1762
		Private <<EMPTY_NAME>> As C1FontPicker

		' Token: 0x040006E3 RID: 1763
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040006E4 RID: 1764
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040006E5 RID: 1765
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006E6 RID: 1766
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
