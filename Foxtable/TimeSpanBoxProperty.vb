Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002B1 RID: 689
	Friend Class TimeSpanBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06002480 RID: 9344 RVA: 0x000FAB00 File Offset: 0x000F8D00
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.Ooo_0__0Oo. = CType(A_0.ChildControl, C1TextBox)
			Me.o.Ooo_0__0Oo..VerticalAlign = 1
		End Sub

		' Token: 0x1700087C RID: 2172
		' (get) Token: 0x06002481 RID: 9345 RVA: 0x000FAB26 File Offset: 0x000F8D26
		' (set) Token: 0x06002482 RID: 9346 RVA: 0x000FAB2E File Offset: 0x000F8D2E
		<DisplayName("名称")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(1.0)>
		<Category("基本")>
		Public Overrides Property Name As String
			Get
				Return MyBase.Name
			End Get
			Set(value As String)
				MyBase.Name = value
				If Operators.CompareString(Me.BindingField, "", True) = 0 Then
					Me.o.Ooo_0__0Oo..Text = value
				End If
			End Set
		End Property

		' Token: 0x1700087D RID: 2173
		' (get) Token: 0x06002483 RID: 9347 RVA: 0x000FAB56 File Offset: 0x000F8D56
		' (set) Token: 0x06002484 RID: 9348 RVA: 0x000FAB5E File Offset: 0x000F8D5E
		<DisplayName("初始值")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<DefaultValue("")>
		Public Property Value As String
			Get
				Return Me.O___0O.oo.
			End Get
			Set(value As String)
				Me.O___0O.oo. = value
			End Set
		End Property

		' Token: 0x1700087E RID: 2174
		' (get) Token: 0x06002485 RID: 9349 RVA: 0x000FAB67 File Offset: 0x000F8D67
		' (set) Token: 0x06002486 RID: 9350 RVA: 0x000FAB6F File Offset: 0x000F8D6F
		<DisplayName("绑定到")>
		<MergableProperty(True)>
		<DefaultValue("")>
		<Category("基本")>
		<O_Oo00Oo000O0(2.1)>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As String)
				Me.oo.0oOO. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o.Ooo_0__0Oo..Text = value
					Return
				End If
				Me.o.Ooo_0__0Oo..Text = Me.Name
			End Set
		End Property

		' Token: 0x1700087F RID: 2175
		' (get) Token: 0x06002487 RID: 9351 RVA: 0x000FABA5 File Offset: 0x000F8DA5
		' (set) Token: 0x06002488 RID: 9352 RVA: 0x000FABAD File Offset: 0x000F8DAD
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.3)>
		<Category("基本")>
		<Description("是否禁止用户修改。")>
		<DisplayName("只读")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As BooleanEnum)
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000880 RID: 2176
		' (get) Token: 0x06002489 RID: 9353 RVA: 0x000FABB8 File Offset: 0x000F8DB8
		' (set) Token: 0x0600248A RID: 9354 RVA: 0x000FABC6 File Offset: 0x000F8DC6
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

		' Token: 0x17000881 RID: 2177
		' (get) Token: 0x0600248B RID: 9355 RVA: 0x000FABC8 File Offset: 0x000F8DC8
		' (set) Token: 0x0600248C RID: 9356 RVA: 0x000FABDA File Offset: 0x000F8DDA
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		<Category("外观")>
		<DefaultValue("(default)")>
		<O_Oo00Oo000O0(0.0)>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.o.Ooo_0__0Oo.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.o.Ooo_0__0Oo. })
			End Set
		End Property

		' Token: 0x17000882 RID: 2178
		' (get) Token: 0x0600248D RID: 9357 RVA: 0x000FABF6 File Offset: 0x000F8DF6
		' (set) Token: 0x0600248E RID: 9358 RVA: 0x000FAC03 File Offset: 0x000F8E03
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("文本位置")>
		<O_Oo00Oo000O0(1.0)>
		<Category("外观")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o.Ooo_0__0Oo..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o.Ooo_0__0Oo..TextAlign = value
			End Set
		End Property

		' Token: 0x17000883 RID: 2179
		' (get) Token: 0x0600248F RID: 9359 RVA: 0x000FAC11 File Offset: 0x000F8E11
		' (set) Token: 0x06002490 RID: 9360 RVA: 0x000FAC1E File Offset: 0x000F8E1E
		<O_Oo00Oo000O0(0.4)>
		<DisplayName("边框样式")>
		<Category("外观")>
		<MergableProperty(True)>
		<DefaultValue(2)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.Ooo_0__0Oo..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.Ooo_0__0Oo..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000884 RID: 2180
		' (get) Token: 0x06002491 RID: 9361 RVA: 0x000FAC2C File Offset: 0x000F8E2C
		' (set) Token: 0x06002492 RID: 9362 RVA: 0x000FAC39 File Offset: 0x000F8E39
		<Category("外观")>
		<MergableProperty(True)>
		<DisplayName("边框颜色")>
		<O_Oo00Oo000O0(0.41)>
		<DefaultValue(-10197916)>
		Public Property BorderColor As Color
			Get
				Return Me.o.Ooo_0__0Oo..BorderColor
			End Get
			Set(value As Color)
				Me.o.Ooo_0__0Oo..BorderColor = value
				If Me.o.Ooo_0__0Oo..BorderStyle <> BorderStyle.FixedSingle Then
					Me.o.Ooo_0__0Oo..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000885 RID: 2181
		' (get) Token: 0x06002493 RID: 9363 RVA: 0x000FAC61 File Offset: 0x000F8E61
		' (set) Token: 0x06002494 RID: 9364 RVA: 0x000FAC69 File Offset: 0x000F8E69
		<O_Oo00Oo000O0(2.0)>
		<Category("输入控制")>
		<DisplayName("输入掩码")>
		<MergableProperty(True)>
		Public Property EditMask As String
			Get
				Return Me.o.0O_ooOo00.
			End Get
			Set(value As String)
				Me.o.0O_ooOo00. = value
			End Set
		End Property

		' Token: 0x17000886 RID: 2182
		' (get) Token: 0x06002495 RID: 9365 RVA: 0x000FAC72 File Offset: 0x000F8E72
		' (set) Token: 0x06002496 RID: 9366 RVA: 0x000FAC7F File Offset: 0x000F8E7F
		<DisplayName("初始光标位置")>
		<O_Oo00Oo000O0(11.0)>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<Category("输入控制")>
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o.Ooo_0__0Oo..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o.Ooo_0__0Oo..InitialSelection = value
			End Set
		End Property

		' Token: 0x17000887 RID: 2183
		' (get) Token: 0x06002497 RID: 9367 RVA: 0x000FAC8D File Offset: 0x000F8E8D
		' (set) Token: 0x06002498 RID: 9368 RVA: 0x000FAC95 File Offset: 0x000F8E95
		<oO0oooo("0769")>
		<Category("事件")>
		<Description("值改变后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property ValueChanged As EventString
			Get
				Return Me.O00___._OO_.
			End Get
			Set(value As EventString)
				Me.O00___._OO_. = value
			End Set
		End Property

		' Token: 0x17000888 RID: 2184
		' (get) Token: 0x06002499 RID: 9369 RVA: 0x000FAC9E File Offset: 0x000F8E9E
		' (set) Token: 0x0600249A RID: 9370 RVA: 0x000FACA6 File Offset: 0x000F8EA6
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0768")>
		<Description("文本改变后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property TextChanged As EventString
			Get
				Return Me.oo.0oOO.
			End Get
			Set(value As EventString)
				Me.oo.0oOO. = value
			End Set
		End Property

		' Token: 0x04000EFF RID: 3839
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000F00 RID: 3840
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000F01 RID: 3841
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F02 RID: 3842
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F03 RID: 3843
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F04 RID: 3844
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04000F05 RID: 3845
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
