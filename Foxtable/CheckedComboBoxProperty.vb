Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003F9 RID: 1017
	Friend Class CheckedComboBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x060041B4 RID: 16820 RVA: 0x001C02FC File Offset: 0x001BE4FC
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O_oO0._o_0. = True
			Me.o0Oo._0O. = ","c
			Me.ooo.oo. = 11
			Me.O.0000_. = True
			Me.o0_oo._O_O. = True
			Me.o0Oo._0O. = CType(A_0.ChildControl, C1DropDownControl)
			Me.o0Oo._0O..VerticalAlign = 1
		End Sub

		' Token: 0x17000E33 RID: 3635
		' (get) Token: 0x060041B5 RID: 16821 RVA: 0x001C0352 File Offset: 0x001BE552
		' (set) Token: 0x060041B6 RID: 16822 RVA: 0x001C035A File Offset: 0x001BE55A
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
					Me.o0Oo._0O..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000E34 RID: 3636
		' (get) Token: 0x060041B7 RID: 16823 RVA: 0x001C0382 File Offset: 0x001BE582
		' (set) Token: 0x060041B8 RID: 16824 RVA: 0x001C038A File Offset: 0x001BE58A
		<O_Oo00Oo000O0(2.2)>
		<DisplayName("初始值")>
		<Category("基本")>
		<MergableProperty(True)>
		Public Property Value As String
			Get
				Return Me.oOo00_ooo._.
			End Get
			Set(value As String)
				Me.oOo00_ooo._. = value
			End Set
		End Property

		' Token: 0x17000E35 RID: 3637
		' (get) Token: 0x060041B9 RID: 16825 RVA: 0x001C0393 File Offset: 0x001BE593
		' (set) Token: 0x060041BA RID: 16826 RVA: 0x001C039B File Offset: 0x001BE59B
		<DisplayName("绑定到")>
		<O_Oo00Oo000O0(2.1)>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(False)>
		Public Property BindingField As String
			Get
				Return Me.O_oO0._o_0.
			End Get
			Set(value As String)
				Me.O_oO0._o_0. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o0Oo._0O..Text = value
					Return
				End If
				Me.o0Oo._0O..Text = Me.Name
			End Set
		End Property

		' Token: 0x17000E36 RID: 3638
		' (get) Token: 0x060041BB RID: 16827 RVA: 0x001C03D1 File Offset: 0x001BE5D1
		' (set) Token: 0x060041BC RID: 16828 RVA: 0x001C03D9 File Offset: 0x001BE5D9
		<O_Oo00Oo000O0(2.3)>
		<DisplayName("只读")>
		<Category("基本")>
		<Description("禁止用户修改。")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o0Oo._0O.
			End Get
			Set(value As BooleanEnum)
				Me.o0Oo._0O. = value
			End Set
		End Property

		' Token: 0x17000E37 RID: 3639
		' (get) Token: 0x060041BD RID: 16829 RVA: 0x001C03E4 File Offset: 0x001BE5E4
		' (set) Token: 0x060041BE RID: 16830 RVA: 0x001C03F2 File Offset: 0x001BE5F2
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

		' Token: 0x17000E38 RID: 3640
		' (get) Token: 0x060041BF RID: 16831 RVA: 0x001C03F4 File Offset: 0x001BE5F4
		' (set) Token: 0x060041C0 RID: 16832 RVA: 0x001C0406 File Offset: 0x001BE606
		<DisplayName("样式")>
		<Category("外观")>
		<DefaultValue("(default)")>
		<O_Oo00Oo000O0(0.0)>
		<TypeConverter(GetType(o00))>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.o0Oo._0O.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.o0Oo._0O. })
			End Set
		End Property

		' Token: 0x17000E39 RID: 3641
		' (get) Token: 0x060041C1 RID: 16833 RVA: 0x001C0422 File Offset: 0x001BE622
		' (set) Token: 0x060041C2 RID: 16834 RVA: 0x001C042F File Offset: 0x001BE62F
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("文本位置")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o0Oo._0O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o0Oo._0O..TextAlign = value
			End Set
		End Property

		' Token: 0x17000E3A RID: 3642
		' (get) Token: 0x060041C3 RID: 16835 RVA: 0x001C043D File Offset: 0x001BE63D
		' (set) Token: 0x060041C4 RID: 16836 RVA: 0x001C044A File Offset: 0x001BE64A
		<Category("外观")>
		<O_Oo00Oo000O0(0.4)>
		<DisplayName("边框样式")>
		<DefaultValue(2)>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o0Oo._0O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o0Oo._0O..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000E3B RID: 3643
		' (get) Token: 0x060041C5 RID: 16837 RVA: 0x001C0458 File Offset: 0x001BE658
		' (set) Token: 0x060041C6 RID: 16838 RVA: 0x001C0465 File Offset: 0x001BE665
		<O_Oo00Oo000O0(0.41)>
		<MergableProperty(True)>
		<DefaultValue(-10197916)>
		<DisplayName("边框颜色")>
		<Category("外观")>
		Public Property BorderColor As Color
			Get
				Return Me.o0Oo._0O..BorderColor
			End Get
			Set(value As Color)
				Me.o0Oo._0O..BorderColor = value
				If Me.o0Oo._0O..BorderStyle <> BorderStyle.FixedSingle Then
					Me.o0Oo._0O..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000E3C RID: 3644
		' (get) Token: 0x060041C7 RID: 16839 RVA: 0x001C048D File Offset: 0x001BE68D
		' (set) Token: 0x060041C8 RID: 16840 RVA: 0x001C0495 File Offset: 0x001BE695
		<DisplayName("自定义项目")>
		<O_Oo00Oo000O0(1.0)>
		<Category("列表项目")>
		<Editor(GetType(ooO0o0_oO0_0), GetType(UITypeEditor))>
		<MergableProperty(False)>
		Public Property ComboList As String
			Get
				Return Me.oO0.O.
			End Get
			Set(value As String)
				Me.oO0.O. = value
			End Set
		End Property

		' Token: 0x17000E3D RID: 3645
		' (get) Token: 0x060041C9 RID: 16841 RVA: 0x001C049E File Offset: 0x001BE69E
		' (set) Token: 0x060041CA RID: 16842 RVA: 0x001C04A6 File Offset: 0x001BE6A6
		<O_Oo00Oo000O0(3.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<DisplayName("显示列")>
		Public Property DisplayMember As String
			Get
				Return Me.OOO0o.oO000.
			End Get
			Set(value As String)
				Me.OOO0o.oO000. = value
				If Operators.CompareString(Me.O.00oOoooo., "", True) = 0 Then
					Me.O.00oOoooo. = value
				End If
			End Set
		End Property

		' Token: 0x17000E3E RID: 3646
		' (get) Token: 0x060041CB RID: 16843 RVA: 0x001C04C9 File Offset: 0x001BE6C9
		' (set) Token: 0x060041CC RID: 16844 RVA: 0x001C04D1 File Offset: 0x001BE6D1
		<MergableProperty(False)>
		<O_Oo00Oo000O0(4.0)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<DisplayName("取值列")>
		<Category("列表项目")>
		Public Property ValueMember As String
			Get
				Return Me.O.00oOoooo.
			End Get
			Set(value As String)
				Me.O.00oOoooo. = value
				If Operators.CompareString(Me.OOO0o.oO000., "", True) = 0 Then
					Me.OOO0o.oO000. = value
				End If
			End Set
		End Property

		' Token: 0x17000E3F RID: 3647
		' (get) Token: 0x060041CD RID: 16845 RVA: 0x001C04F4 File Offset: 0x001BE6F4
		' (set) Token: 0x060041CE RID: 16846 RVA: 0x001C04FC File Offset: 0x001BE6FC
		<MergableProperty(False)>
		<O_Oo00Oo000O0(2.0)>
		<Description("候选项目来源表")>
		<TypeConverter(GetType(OoO_O0_OO0))>
		<Category("列表项目")>
		<DisplayName("数据表")>
		Public Property DataSource As String
			Get
				Return Me.OO.0O0.
			End Get
			Set(value As String)
				Me.OO.0O0. = value
				If Operators.CompareString(value, "", True) = 0 Then
					Me.ValueMember = ""
					Me.DisplayMember = ""
					Return
				End If
				If OO_00oOO.DataTables.Contains(value) Then
					If Operators.CompareString(Me.DisplayMember, "", True) > 0 AndAlso Not OO_00oOO.DataTables(value).DataCols.Contains(Me.DisplayMember) Then
						Me.DisplayMember = ""
					End If
					If Operators.CompareString(Me.ValueMember, "", True) > 0 AndAlso Not OO_00oOO.DataTables(value).DataCols.Contains(Me.ValueMember) Then
						Me.ValueMember = ""
					End If
				End If
			End Set
		End Property

		' Token: 0x17000E40 RID: 3648
		' (get) Token: 0x060041CF RID: 16847 RVA: 0x001C05BA File Offset: 0x001BE7BA
		' (set) Token: 0x060041D0 RID: 16848 RVA: 0x001C05C2 File Offset: 0x001BE7C2
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(O0O00), GetType(UITypeEditor))>
		<Category("列表项目")>
		<MergableProperty(False)>
		<DisplayName("过滤条件")>
		<Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")>
		Public Property DataFilter As String
			Get
				Return Me.O0o_o0__._.
			End Get
			Set(value As String)
				Me.O0o_o0__._. = value
			End Set
		End Property

		' Token: 0x17000E41 RID: 3649
		' (get) Token: 0x060041D1 RID: 16849 RVA: 0x001C05CB File Offset: 0x001BE7CB
		' (set) Token: 0x060041D2 RID: 16850 RVA: 0x001C05D3 File Offset: 0x001BE7D3
		<DefaultValue(","c)>
		<Description("用于分隔值的符号")>
		<DisplayName("分隔符")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(6.0)>
		<Category("列表项目")>
		Public Property Separator As Char
			Get
				Return Me.o0Oo._0O.
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) <> 0 Then
					Me.o0Oo._0O. = value
				End If
			End Set
		End Property

		' Token: 0x17000E42 RID: 3650
		' (get) Token: 0x060041D3 RID: 16851 RVA: 0x001C05EF File Offset: 0x001BE7EF
		' (set) Token: 0x060041D4 RID: 16852 RVA: 0x001C05F7 File Offset: 0x001BE7F7
		<DefaultValue(False)>
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("多列显示")>
		<Category("列表项目")>
		<Description("是否分多列显示项目。")>
		<MergableProperty(True)>
		Public Property MultiColumn As Boolean
			Get
				Return Me.ooOOo.0O0O0o0.
			End Get
			Set(value As Boolean)
				Me.ooOOo.0O0O0o0. = value
			End Set
		End Property

		' Token: 0x17000E43 RID: 3651
		' (get) Token: 0x060041D5 RID: 16853 RVA: 0x001C0600 File Offset: 0x001BE800
		' (set) Token: 0x060041D6 RID: 16854 RVA: 0x001C0608 File Offset: 0x001BE808
		<Description("设置多列显示时，各列的宽度。")>
		<O_Oo00Oo000O0(8.0)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("每列宽度")>
		<Category("列表项目")>
		Public Property ColumnWidth As Integer
			Get
				Return Me.O_oO0._o_0.
			End Get
			Set(value As Integer)
				Me.O_oO0._o_0. = value
			End Set
		End Property

		' Token: 0x17000E44 RID: 3652
		' (get) Token: 0x060041D7 RID: 16855 RVA: 0x001C0611 File Offset: 0x001BE811
		' (set) Token: 0x060041D8 RID: 16856 RVA: 0x001C0619 File Offset: 0x001BE819
		<MergableProperty(True)>
		<Category("列表项目")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(9.0)>
		<Description("指定下拉列表的宽度，设为0使用默认宽度，最小宽度为130")>
		<DisplayName("下拉宽度")>
		Public Property DropDownWidth As Integer
			Get
				Return Me.ooOOo.0O0O0o0.
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(130, value)
				End If
				Me.ooOOo.0O0O0o0. = value
			End Set
		End Property

		' Token: 0x17000E45 RID: 3653
		' (get) Token: 0x060041D9 RID: 16857 RVA: 0x001C0632 File Offset: 0x001BE832
		' (set) Token: 0x060041DA RID: 16858 RVA: 0x001C063A File Offset: 0x001BE83A
		<O_Oo00Oo000O0(10.0)>
		<Description("指定下拉列表的高度，设为0使用默认高度，最小高度为52，仅在多列显示的时候有效")>
		<DefaultValue(0)>
		<DisplayName("下拉高度")>
		<MergableProperty(True)>
		<Category("列表项目")>
		Public Property DropDownHeight As Integer
			Get
				Return Me.OOO0_o0_O._0o.
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(52, value)
				End If
				Me.OOO0_o0_O._0o. = value
			End Set
		End Property

		' Token: 0x17000E46 RID: 3654
		' (get) Token: 0x060041DB RID: 16859 RVA: 0x001C0650 File Offset: 0x001BE850
		' (set) Token: 0x060041DC RID: 16860 RVA: 0x001C0658 File Offset: 0x001BE858
		<O_Oo00Oo000O0(11.0)>
		<MergableProperty(True)>
		<DefaultValue(11)>
		<DisplayName("最多显示项目数")>
		<Category("列表项目")>
		<Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示，仅在单列显示的时候有效")>
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.ooo.oo.
			End Get
			Set(value As Integer)
				value = Math.Max(1, value)
				Me.ooo.oo. = value
			End Set
		End Property

		' Token: 0x17000E47 RID: 3655
		' (get) Token: 0x060041DD RID: 16861 RVA: 0x001C066A File Offset: 0x001BE86A
		' (set) Token: 0x060041DE RID: 16862 RVA: 0x001C0672 File Offset: 0x001BE872
		<MergableProperty(True)>
		<O_Oo00Oo000O0(12.0)>
		<DefaultValue(True)>
		<Category("列表项目")>
		<Description("允许用户直接输入不在列表项目中的值")>
		<DisplayName("允许直接输入")>
		Public Property AllowEditValue As Boolean
			Get
				Return Me.O_oO0._o_0.
			End Get
			Set(value As Boolean)
				Me.O_oO0._o_0. = value
			End Set
		End Property

		' Token: 0x17000E48 RID: 3656
		' (get) Token: 0x060041DF RID: 16863 RVA: 0x001C067B File Offset: 0x001BE87B
		' (set) Token: 0x060041E0 RID: 16864 RVA: 0x001C0683 File Offset: 0x001BE883
		<DefaultValue(True)>
		<DisplayName("自动选中")>
		<Category("列表项目")>
		<Description("复选框是否在首次单击某项时切换。")>
		<O_Oo00Oo000O0(13.0)>
		<MergableProperty(True)>
		Public Property CheckOnClick As Boolean
			Get
				Return Me.O.0000_.
			End Get
			Set(value As Boolean)
				Me.O.0000_. = value
			End Set
		End Property

		' Token: 0x17000E49 RID: 3657
		' (get) Token: 0x060041E1 RID: 16865 RVA: 0x001C068C File Offset: 0x001BE88C
		' (set) Token: 0x060041E2 RID: 16866 RVA: 0x001C0694 File Offset: 0x001BE894
		<MergableProperty(True)>
		<Category("输入控制")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("输入掩码")>
		Public Property EditMask As String
			Get
				Return Me.OOOo0oOOO_o.O.
			End Get
			Set(value As String)
				Me.OOOo0oOOO_o.O. = value
			End Set
		End Property

		' Token: 0x17000E4A RID: 3658
		' (get) Token: 0x060041E3 RID: 16867 RVA: 0x001C069D File Offset: 0x001BE89D
		' (set) Token: 0x060041E4 RID: 16868 RVA: 0x001C06A5 File Offset: 0x001BE8A5
		<MergableProperty(True)>
		<DisplayName("格式符号")>
		<Category("输入控制")>
		<O_Oo00Oo000O0(2.1)>
		Public Property FormatString As String
			Get
				Return Me.ooOOo.0O0O0o0.
			End Get
			Set(value As String)
				Me.ooOOo.0O0O0o0. = value
			End Set
		End Property

		' Token: 0x17000E4B RID: 3659
		' (get) Token: 0x060041E5 RID: 16869 RVA: 0x001C06AE File Offset: 0x001BE8AE
		' (set) Token: 0x060041E6 RID: 16870 RVA: 0x001C06B6 File Offset: 0x001BE8B6
		<DisplayName("中文输入")>
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<Category("输入控制")>
		<DefaultValue(0)>
		Public Property ImeMode As BooleanEnum
			Get
				Return Me.ooOOo.0O0O0o0.
			End Get
			Set(value As BooleanEnum)
				Me.ooOOo.0O0O0o0. = value
			End Set
		End Property

		' Token: 0x17000E4C RID: 3660
		' (get) Token: 0x060041E7 RID: 16871 RVA: 0x001C06BF File Offset: 0x001BE8BF
		' (set) Token: 0x060041E8 RID: 16872 RVA: 0x001C06CC File Offset: 0x001BE8CC
		<Category("输入控制")>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("最大长度")>
		<MergableProperty(True)>
		<DefaultValue(32767)>
		<Description("允许用户输入的最大字符数。")>
		Public Property MaxLength As Integer
			Get
				Return Me.o0Oo._0O..MaxLength
			End Get
			Set(value As Integer)
				Me.o0Oo._0O..MaxLength = value
			End Set
		End Property

		' Token: 0x17000E4D RID: 3661
		' (get) Token: 0x060041E9 RID: 16873 RVA: 0x001C06DA File Offset: 0x001BE8DA
		' (set) Token: 0x060041EA RID: 16874 RVA: 0x001C06E2 File Offset: 0x001BE8E2
		<MergableProperty(True)>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("删除前空格")>
		<Category("输入控制")>
		<DefaultValue(False)>
		Public Property TrimStart As Boolean
			Get
				Return Me.O0.0.
			End Get
			Set(value As Boolean)
				Me.O0.0. = value
			End Set
		End Property

		' Token: 0x17000E4E RID: 3662
		' (get) Token: 0x060041EB RID: 16875 RVA: 0x001C06EB File Offset: 0x001BE8EB
		' (set) Token: 0x060041EC RID: 16876 RVA: 0x001C06F3 File Offset: 0x001BE8F3
		<DisplayName("删除尾空格")>
		<Category("输入控制")>
		<O_Oo00Oo000O0(9.0)>
		<DefaultValue(True)>
		<MergableProperty(True)>
		Public Property TrimEnd As Boolean
			Get
				Return Me.o0_oo._O_O.
			End Get
			Set(value As Boolean)
				Me.o0_oo._O_O. = value
			End Set
		End Property

		' Token: 0x17000E4F RID: 3663
		' (get) Token: 0x060041ED RID: 16877 RVA: 0x001C06FC File Offset: 0x001BE8FC
		' (set) Token: 0x060041EE RID: 16878 RVA: 0x001C0709 File Offset: 0x001BE909
		<DefaultValue(0)>
		<O_Oo00Oo000O0(10.0)>
		<DisplayName("大小写转换")>
		<Category("输入控制")>
		<Description("否在字符键入时修改其大小写格式。")>
		<MergableProperty(True)>
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.o0Oo._0O..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.o0Oo._0O..CharacterCasing = value
			End Set
		End Property

		' Token: 0x17000E50 RID: 3664
		' (get) Token: 0x060041EF RID: 16879 RVA: 0x001C0717 File Offset: 0x001BE917
		' (set) Token: 0x060041F0 RID: 16880 RVA: 0x001C0724 File Offset: 0x001BE924
		<O_Oo00Oo000O0(11.0)>
		<DefaultValue(0)>
		<DisplayName("初始光标位置")>
		<Category("输入控制")>
		<MergableProperty(True)>
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o0Oo._0O..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o0Oo._0O..InitialSelection = value
			End Set
		End Property

		' Token: 0x17000E51 RID: 3665
		' (get) Token: 0x060041F1 RID: 16881 RVA: 0x001C0732 File Offset: 0x001BE932
		' (set) Token: 0x060041F2 RID: 16882 RVA: 0x001C073A File Offset: 0x001BE93A
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0937")>
		<Category("事件")>
		<Description("选择不同项目后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.o0Oo._0O.
			End Get
			Set(value As EventString)
				Me.o0Oo._0O. = value
			End Set
		End Property

		' Token: 0x17000E52 RID: 3666
		' (get) Token: 0x060041F3 RID: 16883 RVA: 0x001C0743 File Offset: 0x001BE943
		' (set) Token: 0x060041F4 RID: 16884 RVA: 0x001C074B File Offset: 0x001BE94B
		<oO0oooo("0768")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("内容改变后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.3)>
		Public Property TextChanged As EventString
			Get
				Return Me.OO_OO.Oo_o0.
			End Get
			Set(value As EventString)
				Me.OO_OO.Oo_o0. = value
			End Set
		End Property

		' Token: 0x17000E53 RID: 3667
		' (get) Token: 0x060041F5 RID: 16885 RVA: 0x001C0754 File Offset: 0x001BE954
		' (set) Token: 0x060041F6 RID: 16886 RVA: 0x001C075C File Offset: 0x001BE95C
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0938")>
		<Category("事件")>
		<Description("格式化列表项目显示值的时候执行！")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.4)>
		Public Property ListItemFormat As EventString
			Get
				Return Me.OOO0_o0_O._0o.
			End Get
			Set(value As EventString)
				Me.OOO0_o0_O._0o. = value
			End Set
		End Property

		' Token: 0x04001AF2 RID: 6898
		Private <<EMPTY_NAME>> As C1DropDownControl

		' Token: 0x04001AF3 RID: 6899
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AF4 RID: 6900
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AF5 RID: 6901
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001AF6 RID: 6902
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AF7 RID: 6903
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001AF8 RID: 6904
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04001AF9 RID: 6905
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AFA RID: 6906
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001AFB RID: 6907
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001AFC RID: 6908
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AFD RID: 6909
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AFE RID: 6910
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AFF RID: 6911
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B00 RID: 6912
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B01 RID: 6913
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B02 RID: 6914
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B03 RID: 6915
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B04 RID: 6916
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B05 RID: 6917
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B06 RID: 6918
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B07 RID: 6919
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B08 RID: 6920
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B09 RID: 6921
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B0A RID: 6922
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B0B RID: 6923
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
