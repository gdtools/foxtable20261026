Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003FC RID: 1020
	Friend Class ComboboxProperty
		Inherits ControlPropertyBase

		' Token: 0x06004223 RID: 16931 RVA: 0x001C0AEC File Offset: 0x001BECEC
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O_.o_. = True
			Me.o0__Oo.0__. = 11
			Me.o_00o.00O0o_0. = True
			Me.O_OO.O0o000o0O. = 6
			Me.oo.O0o0o. = CType(A_0.ChildControl, C1DropDownControl)
			Me.oo.O0o0o..VerticalAlign = 1
		End Sub

		' Token: 0x17000E69 RID: 3689
		' (get) Token: 0x06004224 RID: 16932 RVA: 0x001C0B3A File Offset: 0x001BED3A
		' (set) Token: 0x06004225 RID: 16933 RVA: 0x001C0B42 File Offset: 0x001BED42
		<DisplayName("名称")>
		<Category("基本")>
		<O_Oo00Oo000O0(1.0)>
		Public Overrides Property Name As String
			Get
				Return MyBase.Name
			End Get
			Set(value As String)
				MyBase.Name = value
				If Operators.CompareString(Me.BindingField, "", True) = 0 Then
					Me.oo.O0o0o..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000E6A RID: 3690
		' (get) Token: 0x06004226 RID: 16934 RVA: 0x001C0B6A File Offset: 0x001BED6A
		' (set) Token: 0x06004227 RID: 16935 RVA: 0x001C0B72 File Offset: 0x001BED72
		<O_Oo00Oo000O0(2.2)>
		<DisplayName("初始值")>
		<MergableProperty(False)>
		<DefaultValue("")>
		<Category("基本")>
		Public Property Value As String
			Get
				Return Me.o0O0O._.
			End Get
			Set(value As String)
				Me.o0O0O._. = value
			End Set
		End Property

		' Token: 0x17000E6B RID: 3691
		' (get) Token: 0x06004228 RID: 16936 RVA: 0x001C0B7B File Offset: 0x001BED7B
		' (set) Token: 0x06004229 RID: 16937 RVA: 0x001C0B83 File Offset: 0x001BED83
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(False)>
		Public Property BindingField As String
			Get
				Return Me.O_.o_.
			End Get
			Set(value As String)
				Me.O_.o_. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.oo.O0o0o..Text = value
					Return
				End If
				Me.oo.O0o0o..Text = Me.Name
			End Set
		End Property

		' Token: 0x17000E6C RID: 3692
		' (get) Token: 0x0600422A RID: 16938 RVA: 0x001C0BB9 File Offset: 0x001BEDB9
		' (set) Token: 0x0600422B RID: 16939 RVA: 0x001C0BC1 File Offset: 0x001BEDC1
		<MergableProperty(True)>
		<Category("基本")>
		<O_Oo00Oo000O0(2.3)>
		<DisplayName("只读")>
		<Description("禁止用户修改。")>
		<DefaultValue(0)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.0OOO_.
			End Get
			Set(value As BooleanEnum)
				Me.o.0OOO_. = value
			End Set
		End Property

		' Token: 0x17000E6D RID: 3693
		' (get) Token: 0x0600422C RID: 16940 RVA: 0x001C0BCC File Offset: 0x001BEDCC
		' (set) Token: 0x0600422D RID: 16941 RVA: 0x001C0BDA File Offset: 0x001BEDDA
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

		' Token: 0x17000E6E RID: 3694
		' (get) Token: 0x0600422E RID: 16942 RVA: 0x001C0BDC File Offset: 0x001BEDDC
		' (set) Token: 0x0600422F RID: 16943 RVA: 0x001C0BEE File Offset: 0x001BEDEE
		<O_Oo00Oo000O0(0.0)>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		<Category("外观")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.oo.O0o0o.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.oo.O0o0o. })
			End Set
		End Property

		' Token: 0x17000E6F RID: 3695
		' (get) Token: 0x06004230 RID: 16944 RVA: 0x001C0C0A File Offset: 0x001BEE0A
		' (set) Token: 0x06004231 RID: 16945 RVA: 0x001C0C17 File Offset: 0x001BEE17
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("文本位置")>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.oo.O0o0o..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.oo.O0o0o..TextAlign = value
			End Set
		End Property

		' Token: 0x17000E70 RID: 3696
		' (get) Token: 0x06004232 RID: 16946 RVA: 0x001C0C25 File Offset: 0x001BEE25
		' (set) Token: 0x06004233 RID: 16947 RVA: 0x001C0C32 File Offset: 0x001BEE32
		<DisplayName("边框样式")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(2)>
		<O_Oo00Oo000O0(0.4)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.oo.O0o0o..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.oo.O0o0o..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000E71 RID: 3697
		' (get) Token: 0x06004234 RID: 16948 RVA: 0x001C0C40 File Offset: 0x001BEE40
		' (set) Token: 0x06004235 RID: 16949 RVA: 0x001C0C4D File Offset: 0x001BEE4D
		<DisplayName("边框颜色")>
		<O_Oo00Oo000O0(0.41)>
		<MergableProperty(True)>
		<DefaultValue(-10197916)>
		<Category("外观")>
		Public Property BorderColor As Color
			Get
				Return Me.oo.O0o0o..BorderColor
			End Get
			Set(value As Color)
				Me.oo.O0o0o..BorderColor = value
				If Me.oo.O0o0o..BorderStyle <> BorderStyle.FixedSingle Then
					Me.oo.O0o0o..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000E72 RID: 3698
		' (get) Token: 0x06004236 RID: 16950 RVA: 0x001C0C75 File Offset: 0x001BEE75
		' (set) Token: 0x06004237 RID: 16951 RVA: 0x001C0C7D File Offset: 0x001BEE7D
		<Description("允许用户直接输入不在列表项目中的值")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(13.0)>
		<DisplayName("允许直接输入")>
		<Category("列表项目")>
		Public Property AllowEditValue As Boolean
			Get
				Return Me.O_.o_.
			End Get
			Set(value As Boolean)
				Me.O_.o_. = value
			End Set
		End Property

		' Token: 0x17000E73 RID: 3699
		' (get) Token: 0x06004238 RID: 16952 RVA: 0x001C0C86 File Offset: 0x001BEE86
		' (set) Token: 0x06004239 RID: 16953 RVA: 0x001C0C8E File Offset: 0x001BEE8E
		<Category("列表项目")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(13.1)>
		<DisplayName("启用输入助手")>
		<Description("在手工输入的时候，是否启用输入助手，以提高用户输入效率。")>
		<DefaultValue(False)>
		Public Property AutoComplete As Boolean
			Get
				Return Me.o.o_Oo.
			End Get
			Set(value As Boolean)
				Me.o.o_Oo. = value
			End Set
		End Property

		' Token: 0x17000E74 RID: 3700
		' (get) Token: 0x0600423A RID: 16954 RVA: 0x001C0C97 File Offset: 0x001BEE97
		' (set) Token: 0x0600423B RID: 16955 RVA: 0x001C0C9F File Offset: 0x001BEE9F
		<DisplayName("自定义项目")>
		<MergableProperty(True)>
		<Editor(GetType(ooO0o0_oO0_0), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.0)>
		<Category("列表项目")>
		Public Property ComboList As String
			Get
				Return Me.oo00o_.OooO.
			End Get
			Set(value As String)
				Me.oo00o_.OooO. = value
			End Set
		End Property

		' Token: 0x17000E75 RID: 3701
		' (get) Token: 0x0600423C RID: 16956 RVA: 0x001C0CA8 File Offset: 0x001BEEA8
		' (set) Token: 0x0600423D RID: 16957 RVA: 0x001C0CB0 File Offset: 0x001BEEB0
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("显示列")>
		<Category("列表项目")>
		<TypeConverter(GetType(oo0OOO_0__))>
		<MergableProperty(False)>
		Public Property DisplayMember As String
			Get
				Return Me.O_OO.O0o000o0O.
			End Get
			Set(value As String)
				Me.O_OO.O0o000o0O. = value
				If Operators.CompareString(Me.oOo.___oOooo0_., "", True) = 0 Then
					Me.oOo.___oOooo0_. = value
				End If
			End Set
		End Property

		' Token: 0x17000E76 RID: 3702
		' (get) Token: 0x0600423E RID: 16958 RVA: 0x001C0CD3 File Offset: 0x001BEED3
		' (set) Token: 0x0600423F RID: 16959 RVA: 0x001C0CDB File Offset: 0x001BEEDB
		<Category("列表项目")>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("取值列")>
		<TypeConverter(GetType(oo0OOO_0__))>
		<MergableProperty(False)>
		Public Property ValueMember As String
			Get
				Return Me.oOo.___oOooo0_.
			End Get
			Set(value As String)
				Me.oOo.___oOooo0_. = value
				If Operators.CompareString(Me.O_OO.O0o000o0O., "", True) = 0 Then
					Me.O_OO.O0o000o0O. = value
				End If
			End Set
		End Property

		' Token: 0x17000E77 RID: 3703
		' (get) Token: 0x06004240 RID: 16960 RVA: 0x001C0CFE File Offset: 0x001BEEFE
		' (set) Token: 0x06004241 RID: 16961 RVA: 0x001C0D08 File Offset: 0x001BEF08
		<DisplayName("数据表")>
		<TypeConverter(GetType(OoO_O0_OO0))>
		<O_Oo00Oo000O0(3.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		<Description("候选项目来源表")>
		Public Property DataSource As String
			Get
				Return Me.oo_O_Oo0_.O.
			End Get
			Set(value As String)
				Me.oo_O_Oo0_.O. = value
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

		' Token: 0x17000E78 RID: 3704
		' (get) Token: 0x06004242 RID: 16962 RVA: 0x001C0DC6 File Offset: 0x001BEFC6
		' (set) Token: 0x06004243 RID: 16963 RVA: 0x001C0DCE File Offset: 0x001BEFCE
		<Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("过滤条件")>
		<Category("列表项目")>
		<MergableProperty(False)>
		<Editor(GetType(O0O00), GetType(UITypeEditor))>
		Public Property DataFilter As String
			Get
				Return Me.o._o__0o0OOoo_.
			End Get
			Set(value As String)
				Me.o._o__0o0OOoo_. = value
			End Set
		End Property

		' Token: 0x17000E79 RID: 3705
		' (get) Token: 0x06004244 RID: 16964 RVA: 0x001C0DD7 File Offset: 0x001BEFD7
		' (set) Token: 0x06004245 RID: 16965 RVA: 0x001C0DDF File Offset: 0x001BEFDF
		<O_Oo00Oo000O0(7.0)>
		<Description("是否分多列显示项目。")>
		<DefaultValue(False)>
		<MergableProperty(True)>
		<Category("列表项目")>
		<DisplayName("多列显示")>
		Public Property MultiColumn As Boolean
			Get
				Return Me.o.0o.
			End Get
			Set(value As Boolean)
				Me.o.0o. = value
			End Set
		End Property

		' Token: 0x17000E7A RID: 3706
		' (get) Token: 0x06004246 RID: 16966 RVA: 0x001C0DE8 File Offset: 0x001BEFE8
		' (set) Token: 0x06004247 RID: 16967 RVA: 0x001C0DF0 File Offset: 0x001BEFF0
		<Category("列表项目")>
		<DisplayName("每列宽度")>
		<O_Oo00Oo000O0(8.0)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Description("设置多列显示时，各列的宽度。")>
		Public Property ColumnWidth As Integer
			Get
				Return Me.O_.o_.
			End Get
			Set(value As Integer)
				Me.O_.o_. = value
			End Set
		End Property

		' Token: 0x17000E7B RID: 3707
		' (get) Token: 0x06004248 RID: 16968 RVA: 0x001C0DF9 File Offset: 0x001BEFF9
		' (set) Token: 0x06004249 RID: 16969 RVA: 0x001C0E01 File Offset: 0x001BF001
		<DefaultValue(0)>
		<O_Oo00Oo000O0(10.0)>
		<Category("列表项目")>
		<MergableProperty(True)>
		<DisplayName("下拉宽度")>
		<Description("指定下拉列表的宽度，设为0使用默认宽度，最小宽度为60")>
		Public Property DropDownWidth As Integer
			Get
				Return Me.oOo00_._oo__.
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(60, value)
				End If
				Me.oOo00_._oo__. = value
			End Set
		End Property

		' Token: 0x17000E7C RID: 3708
		' (get) Token: 0x0600424A RID: 16970 RVA: 0x001C0E17 File Offset: 0x001BF017
		' (set) Token: 0x0600424B RID: 16971 RVA: 0x001C0E1F File Offset: 0x001BF01F
		<O_Oo00Oo000O0(11.0)>
		<Description("指定下拉列表的高度，设为0使用默认高度，最小高度为28")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("下拉高度")>
		<Category("列表项目")>
		Public Property DropDownHeight As Integer
			Get
				Return Me.O.oo_o00o__.
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(28, value)
				End If
				Me.O.oo_o00o__. = value
			End Set
		End Property

		' Token: 0x17000E7D RID: 3709
		' (get) Token: 0x0600424C RID: 16972 RVA: 0x001C0E35 File Offset: 0x001BF035
		' (set) Token: 0x0600424D RID: 16973 RVA: 0x001C0E3D File Offset: 0x001BF03D
		<O_Oo00Oo000O0(12.0)>
		<MergableProperty(True)>
		<DefaultValue(11)>
		<DisplayName("最多显示项目数")>
		<Category("列表项目")>
		<Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示")>
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.o0__Oo.0__.
			End Get
			Set(value As Integer)
				value = Math.Max(1, value)
				Me.o0__Oo.0__. = value
			End Set
		End Property

		' Token: 0x17000E7E RID: 3710
		' (get) Token: 0x0600424E RID: 16974 RVA: 0x001C0E4F File Offset: 0x001BF04F
		' (set) Token: 0x0600424F RID: 16975 RVA: 0x001C0E57 File Offset: 0x001BF057
		<DefaultValue(6)>
		<MergableProperty(True)>
		<DisplayName("项目间距")>
		<O_Oo00Oo000O0(13.0)>
		<Category("列表项目")>
		<Description("列表项目间距，单位为像素")>
		Public Property ItemSpacing As Integer
			Get
				Return Me.O_OO.O0o000o0O.
			End Get
			Set(value As Integer)
				Me.O_OO.O0o000o0O. = value
			End Set
		End Property

		' Token: 0x17000E7F RID: 3711
		' (get) Token: 0x06004250 RID: 16976 RVA: 0x001C0E60 File Offset: 0x001BF060
		' (set) Token: 0x06004251 RID: 16977 RVA: 0x001C0E68 File Offset: 0x001BF068
		<Category("输入控制")>
		<MergableProperty(True)>
		<DisplayName("输入掩码")>
		<O_Oo00Oo000O0(2.0)>
		Public Property EditMask As String
			Get
				Return Me.o00__O.0.
			End Get
			Set(value As String)
				Me.o00__O.0. = value
			End Set
		End Property

		' Token: 0x17000E80 RID: 3712
		' (get) Token: 0x06004252 RID: 16978 RVA: 0x001C0E71 File Offset: 0x001BF071
		' (set) Token: 0x06004253 RID: 16979 RVA: 0x001C0E79 File Offset: 0x001BF079
		<DisplayName("格式符号")>
		<Category("输入控制")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		Public Property FormatString As String
			Get
				Return Me.oOo00_._oo__.
			End Get
			Set(value As String)
				Me.oOo00_._oo__. = value
			End Set
		End Property

		' Token: 0x17000E81 RID: 3713
		' (get) Token: 0x06004254 RID: 16980 RVA: 0x001C0E82 File Offset: 0x001BF082
		' (set) Token: 0x06004255 RID: 16981 RVA: 0x001C0E8A File Offset: 0x001BF08A
		<DisplayName("中文输入")>
		<O_Oo00Oo000O0(3.0)>
		<Category("输入控制")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property ImeMode As BooleanEnum
			Get
				Return Me.oOo00_._oo__.
			End Get
			Set(value As BooleanEnum)
				Me.oOo00_._oo__. = value
			End Set
		End Property

		' Token: 0x17000E82 RID: 3714
		' (get) Token: 0x06004256 RID: 16982 RVA: 0x001C0E93 File Offset: 0x001BF093
		' (set) Token: 0x06004257 RID: 16983 RVA: 0x001C0EA0 File Offset: 0x001BF0A0
		<Category("输入控制")>
		<DefaultValue(32767)>
		<DisplayName("最大长度")>
		<MergableProperty(True)>
		<Description("允许用户输入的最大字符数。")>
		<O_Oo00Oo000O0(5.0)>
		Public Property MaxLength As Integer
			Get
				Return Me.oo.O0o0o..MaxLength
			End Get
			Set(value As Integer)
				Me.oo.O0o0o..MaxLength = value
			End Set
		End Property

		' Token: 0x17000E83 RID: 3715
		' (get) Token: 0x06004258 RID: 16984 RVA: 0x001C0EAE File Offset: 0x001BF0AE
		' (set) Token: 0x06004259 RID: 16985 RVA: 0x001C0EB6 File Offset: 0x001BF0B6
		<MergableProperty(True)>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("删除前空格")>
		<Category("输入控制")>
		<DefaultValue(False)>
		Public Property TrimStart As Boolean
			Get
				Return Me.o.0o00OOO_oO0o.
			End Get
			Set(value As Boolean)
				Me.o.0o00OOO_oO0o. = value
			End Set
		End Property

		' Token: 0x17000E84 RID: 3716
		' (get) Token: 0x0600425A RID: 16986 RVA: 0x001C0EBF File Offset: 0x001BF0BF
		' (set) Token: 0x0600425B RID: 16987 RVA: 0x001C0EC7 File Offset: 0x001BF0C7
		<O_Oo00Oo000O0(9.0)>
		<Category("输入控制")>
		<DisplayName("删除尾空格")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		Public Property TrimEnd As Boolean
			Get
				Return Me.o_00o.00O0o_0.
			End Get
			Set(value As Boolean)
				Me.o_00o.00O0o_0. = value
			End Set
		End Property

		' Token: 0x17000E85 RID: 3717
		' (get) Token: 0x0600425C RID: 16988 RVA: 0x001C0ED0 File Offset: 0x001BF0D0
		' (set) Token: 0x0600425D RID: 16989 RVA: 0x001C0EDD File Offset: 0x001BF0DD
		<DefaultValue(0)>
		<O_Oo00Oo000O0(10.0)>
		<DisplayName("大小写转换")>
		<MergableProperty(True)>
		<Description("否在字符键入时修改其大小写格式。")>
		<Category("输入控制")>
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.oo.O0o0o..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.oo.O0o0o..CharacterCasing = value
			End Set
		End Property

		' Token: 0x17000E86 RID: 3718
		' (get) Token: 0x0600425E RID: 16990 RVA: 0x001C0EEB File Offset: 0x001BF0EB
		' (set) Token: 0x0600425F RID: 16991 RVA: 0x001C0EF8 File Offset: 0x001BF0F8
		<DisplayName("初始光标位置")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(11.0)>
		<Category("输入控制")>
		<MergableProperty(True)>
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.oo.O0o0o..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.oo.O0o0o..InitialSelection = value
			End Set
		End Property

		' Token: 0x17000E87 RID: 3719
		' (get) Token: 0x06004260 RID: 16992 RVA: 0x001C0F06 File Offset: 0x001BF106
		' (set) Token: 0x06004261 RID: 16993 RVA: 0x001C0F0E File Offset: 0x001BF10E
		<Description("文本改变后执行")>
		<oO0oooo("0768")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property TextChanged As EventString
			Get
				Return Me.O00.000Oo00.
			End Get
			Set(value As EventString)
				Me.O00.000Oo00. = value
			End Set
		End Property

		' Token: 0x17000E88 RID: 3720
		' (get) Token: 0x06004262 RID: 16994 RVA: 0x001C0F17 File Offset: 0x001BF117
		' (set) Token: 0x06004263 RID: 16995 RVA: 0x001C0F1F File Offset: 0x001BF11F
		<Description("值改变后执行")>
		<oO0oooo("0769")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.o.0o00OOO_oO0o.
			End Get
			Set(value As EventString)
				Me.o.0o00OOO_oO0o. = value
			End Set
		End Property

		' Token: 0x17000E89 RID: 3721
		' (get) Token: 0x06004264 RID: 16996 RVA: 0x001C0F28 File Offset: 0x001BF128
		' (set) Token: 0x06004265 RID: 16997 RVA: 0x001C0F30 File Offset: 0x001BF130
		<Description("从下拉列表中选择不同项目后执行。")>
		<oO0oooo("0937")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.3)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.o.0OOO_.
			End Get
			Set(value As EventString)
				Me.o.0OOO_. = value
			End Set
		End Property

		' Token: 0x17000E8A RID: 3722
		' (get) Token: 0x06004266 RID: 16998 RVA: 0x001C0F39 File Offset: 0x001BF139
		' (set) Token: 0x06004267 RID: 16999 RVA: 0x001C0F41 File Offset: 0x001BF141
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("格式化列表项目显示值的时候执行！")>
		<O_Oo00Oo000O0(0.4)>
		<O0O0oOO00_0OO(True)>
		<Category("事件")>
		<oO0oooo("0938")>
		Public Property ListItemFormat As EventString
			Get
				Return Me.O.oo_o00o__.
			End Get
			Set(value As EventString)
				Me.O.oo_o00o__. = value
			End Set
		End Property

		' Token: 0x04001B1C RID: 6940
		Private <<EMPTY_NAME>> As C1DropDownControl

		' Token: 0x04001B1D RID: 6941
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B1E RID: 6942
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B1F RID: 6943
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B20 RID: 6944
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B21 RID: 6945
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B22 RID: 6946
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B23 RID: 6947
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B24 RID: 6948
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B25 RID: 6949
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B26 RID: 6950
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B27 RID: 6951
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B28 RID: 6952
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B29 RID: 6953
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B2A RID: 6954
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B2B RID: 6955
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B2C RID: 6956
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B2D RID: 6957
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B2E RID: 6958
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B2F RID: 6959
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B30 RID: 6960
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B31 RID: 6961
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B32 RID: 6962
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B33 RID: 6963
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B34 RID: 6964
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B35 RID: 6965
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B36 RID: 6966
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B37 RID: 6967
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
