Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200017C RID: 380
	Friend Class ColorPickerProperty
		Inherits ControlPropertyBase

		' Token: 0x060011B7 RID: 4535 RVA: 0x0006E430 File Offset: 0x0006C630
		Friend Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O0._ooOO. = CType(A_0.ChildControl, C1ColorPicker)
		End Sub

		' Token: 0x170003AD RID: 941
		' (get) Token: 0x060011B8 RID: 4536 RVA: 0x0006E44A File Offset: 0x0006C64A
		' (set) Token: 0x060011B9 RID: 4537 RVA: 0x0006E457 File Offset: 0x0006C657
		<O_Oo00Oo000O0(2.2)>
		<MergableProperty(False)>
		<Category("基本")>
		<DisplayName("默认颜色")>
		Public Property Color As Color
			Get
				Return Me.O0._ooOO..Color
			End Get
			Set(value As Color)
				Me.O0._ooOO..Color = value
			End Set
		End Property

		' Token: 0x170003AE RID: 942
		' (get) Token: 0x060011BA RID: 4538 RVA: 0x0006E465 File Offset: 0x0006C665
		' (set) Token: 0x060011BB RID: 4539 RVA: 0x0006E46D File Offset: 0x0006C66D
		<O_Oo00Oo000O0(2.3)>
		<Description("是否禁止用户修改。")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("只读")>
		<Category("基本")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O0._ooOO.
			End Get
			Set(value As BooleanEnum)
				Me.O0._ooOO. = value
			End Set
		End Property

		' Token: 0x170003AF RID: 943
		' (get) Token: 0x060011BC RID: 4540 RVA: 0x0006E476 File Offset: 0x0006C676
		' (set) Token: 0x060011BD RID: 4541 RVA: 0x0006E47E File Offset: 0x0006C67E
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.oOO._O0OOO_o.
			End Get
			Set(value As String)
				Me.oOO._O0OOO_o. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.O0._ooOO..Text = value
					Return
				End If
				Me.O0._ooOO..Text = Me.Name
			End Set
		End Property

		' Token: 0x170003B0 RID: 944
		' (get) Token: 0x060011BE RID: 4542 RVA: 0x0006E4B4 File Offset: 0x0006C6B4
		' (set) Token: 0x060011BF RID: 4543 RVA: 0x0006E4C2 File Offset: 0x0006C6C2
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

		' Token: 0x170003B1 RID: 945
		' (get) Token: 0x060011C0 RID: 4544 RVA: 0x0006E4C4 File Offset: 0x0006C6C4
		' (set) Token: 0x060011C1 RID: 4545 RVA: 0x0006E4D6 File Offset: 0x0006C6D6
		<TypeConverter(GetType(o00))>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DisplayName("样式")>
		<DefaultValue("(default)")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.O0._ooOO.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.O0._ooOO. })
			End Set
		End Property

		' Token: 0x170003B2 RID: 946
		' (get) Token: 0x060011C2 RID: 4546 RVA: 0x0006E4F2 File Offset: 0x0006C6F2
		' (set) Token: 0x060011C3 RID: 4547 RVA: 0x0006E4FF File Offset: 0x0006C6FF
		<DefaultValue(2)>
		<DisplayName("边框样式")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.4)>
		<Category("外观")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O0._ooOO..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O0._ooOO..BorderStyle = value
			End Set
		End Property

		' Token: 0x170003B3 RID: 947
		' (get) Token: 0x060011C4 RID: 4548 RVA: 0x0006E50D File Offset: 0x0006C70D
		' (set) Token: 0x060011C5 RID: 4549 RVA: 0x0006E51A File Offset: 0x0006C71A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.41)>
		<DisplayName("边框颜色")>
		<DefaultValue(-10197916)>
		<Category("外观")>
		Public Property BorderColor As Color
			Get
				Return Me.O0._ooOO..BorderColor
			End Get
			Set(value As Color)
				Me.O0._ooOO..BorderColor = value
				If Me.O0._ooOO..BorderStyle <> BorderStyle.FixedSingle Then
					Me.O0._ooOO..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x170003B4 RID: 948
		' (get) Token: 0x060011C6 RID: 4550 RVA: 0x0006E542 File Offset: 0x0006C742
		' (set) Token: 0x060011C7 RID: 4551 RVA: 0x0006E54A File Offset: 0x0006C74A
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Description("选择不同颜色后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<oO0oooo("")>
		Public Property ValueChanged As EventString
			Get
				Return Me.O0._ooOO.
			End Get
			Set(value As EventString)
				Me.O0._ooOO. = value
			End Set
		End Property

		' Token: 0x040006C9 RID: 1737
		Private <<EMPTY_NAME>> As C1ColorPicker

		' Token: 0x040006CA RID: 1738
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040006CB RID: 1739
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040006CC RID: 1740
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
