Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002AD RID: 685
	Friend Class TextBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06002426 RID: 9254 RVA: 0x000FA543 File Offset: 0x000F8743
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.00O0o_0o0. = True
			Me.oo0.O. = CType(A_0.ChildControl, C1TextBox)
			Me.oo0.O..VerticalAlign = 1
		End Sub

		' Token: 0x17000850 RID: 2128
		' (get) Token: 0x06002427 RID: 9255 RVA: 0x000FA570 File Offset: 0x000F8770
		' (set) Token: 0x06002428 RID: 9256 RVA: 0x000FA578 File Offset: 0x000F8778
		<MergableProperty(False)>
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
					Me.oo0.O..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000851 RID: 2129
		' (get) Token: 0x06002429 RID: 9257 RVA: 0x000FA5A0 File Offset: 0x000F87A0
		' (set) Token: 0x0600242A RID: 9258 RVA: 0x000FA5AD File Offset: 0x000F87AD
		<DisplayName("多行文本")>
		<Category("输入控制")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property MultiLine As Boolean
			Get
				Return Me.oo0.O..Multiline
			End Get
			Set(value As Boolean)
				If Me.oo0.O..Multiline <> value Then
					Me.oo0.O..Multiline = value
					If value Then
						Me.VeticalAlign = 0
					End If
				End If
			End Set
		End Property

		' Token: 0x17000852 RID: 2130
		' (get) Token: 0x0600242B RID: 9259 RVA: 0x000FA5D3 File Offset: 0x000F87D3
		' (set) Token: 0x0600242C RID: 9260 RVA: 0x000FA5DB File Offset: 0x000F87DB
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<Editor(GetType(O0_00_oo0oO_), GetType(UITypeEditor))>
		<DisplayName("初始值")>
		<DefaultValue("")>
		Public Property Value As String
			Get
				Return Me.o0O__OO.oOo0O0.
			End Get
			Set(value As String)
				Me.o0O__OO.oOo0O0. = value
			End Set
		End Property

		' Token: 0x17000853 RID: 2131
		' (get) Token: 0x0600242D RID: 9261 RVA: 0x000FA5E4 File Offset: 0x000F87E4
		' (set) Token: 0x0600242E RID: 9262 RVA: 0x000FA5EC File Offset: 0x000F87EC
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<DisplayName("绑定到")>
		<DefaultValue("")>
		Public Property BindingField As String
			Get
				Return Me.oOOo_o0o0O._.
			End Get
			Set(value As String)
				Me.oOOo_o0o0O._. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.oo0.O..Text = value
					Return
				End If
				Me.oo0.O..Text = Me.Name
			End Set
		End Property

		' Token: 0x17000854 RID: 2132
		' (get) Token: 0x0600242F RID: 9263 RVA: 0x000FA622 File Offset: 0x000F8822
		' (set) Token: 0x06002430 RID: 9264 RVA: 0x000FA62A File Offset: 0x000F882A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.3)>
		<DefaultValue(0)>
		<DisplayName("只读")>
		<Category("基本")>
		<Description("是否禁止用户修改。")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.oOOo_o0o0O._.
			End Get
			Set(value As BooleanEnum)
				Me.oOOo_o0o0O._. = value
			End Set
		End Property

		' Token: 0x17000855 RID: 2133
		' (get) Token: 0x06002431 RID: 9265 RVA: 0x000FA634 File Offset: 0x000F8834
		' (set) Token: 0x06002432 RID: 9266 RVA: 0x000FA642 File Offset: 0x000F8842
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

		' Token: 0x17000856 RID: 2134
		' (get) Token: 0x06002433 RID: 9267 RVA: 0x000FA644 File Offset: 0x000F8844
		' (set) Token: 0x06002434 RID: 9268 RVA: 0x000FA656 File Offset: 0x000F8856
		<O_Oo00Oo000O0(0.0)>
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		<Category("外观")>
		<DefaultValue("(default)")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.oo0.O.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.oo0.O. })
			End Set
		End Property

		' Token: 0x17000857 RID: 2135
		' (get) Token: 0x06002435 RID: 9269 RVA: 0x000FA672 File Offset: 0x000F8872
		' (set) Token: 0x06002436 RID: 9270 RVA: 0x000FA67F File Offset: 0x000F887F
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("水平对齐")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.oo0.O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.oo0.O..TextAlign = value
			End Set
		End Property

		' Token: 0x17000858 RID: 2136
		' (get) Token: 0x06002437 RID: 9271 RVA: 0x000FA68D File Offset: 0x000F888D
		' (set) Token: 0x06002438 RID: 9272 RVA: 0x000FA69A File Offset: 0x000F889A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.2)>
		<DefaultValue(0)>
		<DisplayName("垂直对齐")>
		<Category("外观")>
		Public Property VeticalAlign As VerticalAlignEnum
			Get
				Return Me.oo0.O..VerticalAlign
			End Get
			Set(value As VerticalAlignEnum)
				Me.oo0.O..VerticalAlign = value
			End Set
		End Property

		' Token: 0x17000859 RID: 2137
		' (get) Token: 0x06002439 RID: 9273 RVA: 0x000FA6A8 File Offset: 0x000F88A8
		' (set) Token: 0x0600243A RID: 9274 RVA: 0x000FA6B5 File Offset: 0x000F88B5
		<O_Oo00Oo000O0(1.3)>
		<DisplayName("滚动条")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property ScrollBars As ScrollBars
			Get
				Return Me.oo0.O..ScrollBars
			End Get
			Set(value As ScrollBars)
				Me.oo0.O..ScrollBars = value
			End Set
		End Property

		' Token: 0x1700085A RID: 2138
		' (get) Token: 0x0600243B RID: 9275 RVA: 0x000FA6C3 File Offset: 0x000F88C3
		' (set) Token: 0x0600243C RID: 9276 RVA: 0x000FA6D0 File Offset: 0x000F88D0
		<DisplayName("边框样式")>
		<O_Oo00Oo000O0(0.4)>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(1)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.oo0.O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.oo0.O..BorderStyle = value
			End Set
		End Property

		' Token: 0x1700085B RID: 2139
		' (get) Token: 0x0600243D RID: 9277 RVA: 0x000FA6DE File Offset: 0x000F88DE
		' (set) Token: 0x0600243E RID: 9278 RVA: 0x000FA6EB File Offset: 0x000F88EB
		<O_Oo00Oo000O0(0.41)>
		<DisplayName("边框颜色")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(-10197916)>
		Public Property BorderColor As Color
			Get
				Return Me.oo0.O..BorderColor
			End Get
			Set(value As Color)
				Me.oo0.O..BorderColor = value
			End Set
		End Property

		' Token: 0x1700085C RID: 2140
		' (get) Token: 0x0600243F RID: 9279 RVA: 0x000FA6F9 File Offset: 0x000F88F9
		' (set) Token: 0x06002440 RID: 9280 RVA: 0x000FA706 File Offset: 0x000F8906
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("密码字符")>
		<Category("输入控制")>
		<Description("用于屏蔽输入内容的密码字符。")>
		Public Property PasswordChar As Char
			Get
				Return Me.oo0.O..PasswordChar
			End Get
			Set(value As Char)
				Me.oo0.O..PasswordChar = value
			End Set
		End Property

		' Token: 0x1700085D RID: 2141
		' (get) Token: 0x06002441 RID: 9281 RVA: 0x000FA714 File Offset: 0x000F8914
		' (set) Token: 0x06002442 RID: 9282 RVA: 0x000FA71C File Offset: 0x000F891C
		<Category("输入控制")>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		<DisplayName("输入掩码")>
		Public Property EditMask As String
			Get
				Return Me.o.o_OOO__.
			End Get
			Set(value As String)
				Me.o.o_OOO__. = value
			End Set
		End Property

		' Token: 0x1700085E RID: 2142
		' (get) Token: 0x06002443 RID: 9283 RVA: 0x000FA725 File Offset: 0x000F8925
		' (set) Token: 0x06002444 RID: 9284 RVA: 0x000FA72D File Offset: 0x000F892D
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("格式符号")>
		<MergableProperty(True)>
		<Category("输入控制")>
		Public Property FormatString As String
			Get
				Return Me.o.O0_O_.
			End Get
			Set(value As String)
				Me.o.O0_O_. = value
			End Set
		End Property

		' Token: 0x1700085F RID: 2143
		' (get) Token: 0x06002445 RID: 9285 RVA: 0x000FA736 File Offset: 0x000F8936
		' (set) Token: 0x06002446 RID: 9286 RVA: 0x000FA73E File Offset: 0x000F893E
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("中文输入")>
		<Category("输入控制")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property ImeMode As BooleanEnum
			Get
				Return Me.o.00O0o_0o0.
			End Get
			Set(value As BooleanEnum)
				Me.o.00O0o_0o0. = value
			End Set
		End Property

		' Token: 0x17000860 RID: 2144
		' (get) Token: 0x06002447 RID: 9287 RVA: 0x000FA747 File Offset: 0x000F8947
		' (set) Token: 0x06002448 RID: 9288 RVA: 0x000FA754 File Offset: 0x000F8954
		<Description("允许用户输入的最大字符数。")>
		<DefaultValue(32767)>
		<Category("输入控制")>
		<DisplayName("最大长度")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property MaxLength As Integer
			Get
				Return Me.oo0.O..MaxLength
			End Get
			Set(value As Integer)
				Me.oo0.O..MaxLength = value
			End Set
		End Property

		' Token: 0x17000861 RID: 2145
		' (get) Token: 0x06002449 RID: 9289 RVA: 0x000FA762 File Offset: 0x000F8962
		' (set) Token: 0x0600244A RID: 9290 RVA: 0x000FA76F File Offset: 0x000F896F
		<DisplayName("自动换行")>
		<O_Oo00Oo000O0(7.0)>
		<Category("输入控制")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		Public Property WordWrap As Boolean
			Get
				Return Me.oo0.O..WordWrap
			End Get
			Set(value As Boolean)
				Me.oo0.O..WordWrap = value
			End Set
		End Property

		' Token: 0x17000862 RID: 2146
		' (get) Token: 0x0600244B RID: 9291 RVA: 0x000FA77D File Offset: 0x000F897D
		' (set) Token: 0x0600244C RID: 9292 RVA: 0x000FA785 File Offset: 0x000F8985
		<DefaultValue(False)>
		<O_Oo00Oo000O0(8.0)>
		<MergableProperty(True)>
		<Category("输入控制")>
		<DisplayName("删除前空格")>
		Public Property TrimStart As Boolean
			Get
				Return Me.oo0.O.
			End Get
			Set(value As Boolean)
				Me.oo0.O. = value
			End Set
		End Property

		' Token: 0x17000863 RID: 2147
		' (get) Token: 0x0600244D RID: 9293 RVA: 0x000FA78E File Offset: 0x000F898E
		' (set) Token: 0x0600244E RID: 9294 RVA: 0x000FA796 File Offset: 0x000F8996
		<Category("输入控制")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		<DisplayName("删除尾空格")>
		<O_Oo00Oo000O0(9.0)>
		Public Property TrimEnd As Boolean
			Get
				Return Me.o.00O0o_0o0.
			End Get
			Set(value As Boolean)
				Me.o.00O0o_0o0. = value
			End Set
		End Property

		' Token: 0x17000864 RID: 2148
		' (get) Token: 0x0600244F RID: 9295 RVA: 0x000FA79F File Offset: 0x000F899F
		' (set) Token: 0x06002450 RID: 9296 RVA: 0x000FA7AC File Offset: 0x000F89AC
		<MergableProperty(True)>
		<O_Oo00Oo000O0(10.0)>
		<DefaultValue(0)>
		<DisplayName("大小写转换")>
		<Category("输入控制")>
		<Description("否在字符键入时修改其大小写格式。")>
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.oo0.O..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.oo0.O..CharacterCasing = value
			End Set
		End Property

		' Token: 0x17000865 RID: 2149
		' (get) Token: 0x06002451 RID: 9297 RVA: 0x000FA7BA File Offset: 0x000F89BA
		' (set) Token: 0x06002452 RID: 9298 RVA: 0x000FA7C7 File Offset: 0x000F89C7
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("初始光标位置")>
		<Category("输入控制")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.oo0.O..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.oo0.O..InitialSelection = value
			End Set
		End Property

		' Token: 0x17000866 RID: 2150
		' (get) Token: 0x06002453 RID: 9299 RVA: 0x000FA7D5 File Offset: 0x000F89D5
		' (set) Token: 0x06002454 RID: 9300 RVA: 0x000FA7DD File Offset: 0x000F89DD
		<oO0oooo("0769")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("值改变后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property ValueChanged As EventString
			Get
				Return Me.o0O__OO.oOo0O0.
			End Get
			Set(value As EventString)
				Me.o0O__OO.oOo0O0. = value
			End Set
		End Property

		' Token: 0x17000867 RID: 2151
		' (get) Token: 0x06002455 RID: 9301 RVA: 0x000FA7E6 File Offset: 0x000F89E6
		' (set) Token: 0x06002456 RID: 9302 RVA: 0x000FA7EE File Offset: 0x000F89EE
		<Category("事件")>
		<oO0oooo("0768")>
		<Description("文本改变后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property TextChanged As EventString
			Get
				Return Me.oOOo_o0o0O._.
			End Get
			Set(value As EventString)
				Me.oOOo_o0o0O._. = value
			End Set
		End Property

		' Token: 0x04000EEC RID: 3820
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000EED RID: 3821
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000EEE RID: 3822
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000EEF RID: 3823
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EF0 RID: 3824
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000EF1 RID: 3825
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000EF2 RID: 3826
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EF3 RID: 3827
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EF4 RID: 3828
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000EF5 RID: 3829
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000EF6 RID: 3830
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
