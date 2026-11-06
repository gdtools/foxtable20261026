Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000400 RID: 1024
	Friend Class DateTimePickerProperty
		Inherits ControlPropertyBase

		' Token: 0x0600428D RID: 17037 RVA: 0x001C11C9 File Offset: 0x001BF3C9
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.oOOOo___o_. = New Size(1, 1)
			Me.ooO_O.O_O. = CType(A_0.ChildControl, C1DropDownControl)
			Me.ooO_O.O_O..ShowUpDownButtons = False
			Me.ooO_O.O_O..VerticalAlign = 1
		End Sub

		' Token: 0x17000E9C RID: 3740
		' (get) Token: 0x0600428E RID: 17038 RVA: 0x001C1208 File Offset: 0x001BF408
		' (set) Token: 0x0600428F RID: 17039 RVA: 0x001C1210 File Offset: 0x001BF410
		<O_Oo00Oo000O0(1.0)>
		<Category("基本")>
		<DisplayName("名称")>
		<MergableProperty(False)>
		Public Overrides Property Name As String
			Get
				Return MyBase.Name
			End Get
			Set(value As String)
				MyBase.Name = value
				If Operators.CompareString(Me.BindingField, "", True) = 0 Then
					Me.ooO_O.O_O..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000E9D RID: 3741
		' (get) Token: 0x06004290 RID: 17040 RVA: 0x001C1238 File Offset: 0x001BF438
		' (set) Token: 0x06004291 RID: 17041 RVA: 0x001C1240 File Offset: 0x001BF440
		<O_Oo00Oo000O0(2.2)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("初始值")>
		Public Property Value As DateTime
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As DateTime)
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000E9E RID: 3742
		' (get) Token: 0x06004292 RID: 17042 RVA: 0x001C1249 File Offset: 0x001BF449
		' (set) Token: 0x06004293 RID: 17043 RVA: 0x001C1251 File Offset: 0x001BF451
		<Category("基本")>
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(False)>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<DisplayName("绑定到")>
		Public Property BindingField As String
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As String)
				Me.o.oOOOo___o_. = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.ooO_O.O_O..Text = value
					Return
				End If
				Me.ooO_O.O_O..Text = Me.Name
			End Set
		End Property

		' Token: 0x17000E9F RID: 3743
		' (get) Token: 0x06004294 RID: 17044 RVA: 0x001C1287 File Offset: 0x001BF487
		' (set) Token: 0x06004295 RID: 17045 RVA: 0x001C128F File Offset: 0x001BF48F
		<DisplayName("只读")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Description("禁止用户修改。")>
		<O_Oo00Oo000O0(2.3)>
		<Category("基本")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As BooleanEnum)
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000EA0 RID: 3744
		' (get) Token: 0x06004296 RID: 17046 RVA: 0x001C1298 File Offset: 0x001BF498
		' (set) Token: 0x06004297 RID: 17047 RVA: 0x001C12A0 File Offset: 0x001BF4A0
		<O_Oo00Oo000O0(20.0)>
		<Category("基本")>
		<DisplayName("日期时间格式")>
		<DefaultValue(0)>
		Public Property DateTimeFormat As DateTimeFormatEnum
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As DateTimeFormatEnum)
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000EA1 RID: 3745
		' (get) Token: 0x06004298 RID: 17048 RVA: 0x001C12AC File Offset: 0x001BF4AC
		' (set) Token: 0x06004299 RID: 17049 RVA: 0x001C12BA File Offset: 0x001BF4BA
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

		' Token: 0x17000EA2 RID: 3746
		' (get) Token: 0x0600429A RID: 17050 RVA: 0x001C12BC File Offset: 0x001BF4BC
		' (set) Token: 0x0600429B RID: 17051 RVA: 0x001C12CE File Offset: 0x001BF4CE
		<DisplayName("样式")>
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(o00))>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.ooO_O.O_O.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.ooO_O.O_O. })
			End Set
		End Property

		' Token: 0x17000EA3 RID: 3747
		' (get) Token: 0x0600429C RID: 17052 RVA: 0x001C12EA File Offset: 0x001BF4EA
		' (set) Token: 0x0600429D RID: 17053 RVA: 0x001C12F7 File Offset: 0x001BF4F7
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("文本位置")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.ooO_O.O_O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.ooO_O.O_O..TextAlign = value
			End Set
		End Property

		' Token: 0x17000EA4 RID: 3748
		' (get) Token: 0x0600429E RID: 17054 RVA: 0x001C1305 File Offset: 0x001BF505
		' (set) Token: 0x0600429F RID: 17055 RVA: 0x001C1312 File Offset: 0x001BF512
		<MergableProperty(True)>
		<DisplayName("边框样式")>
		<Category("外观")>
		<O_Oo00Oo000O0(0.2)>
		<DefaultValue(2)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.ooO_O.O_O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.ooO_O.O_O..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000EA5 RID: 3749
		' (get) Token: 0x060042A0 RID: 17056 RVA: 0x001C1320 File Offset: 0x001BF520
		' (set) Token: 0x060042A1 RID: 17057 RVA: 0x001C132D File Offset: 0x001BF52D
		<Category("外观")>
		<DisplayName("边框颜色")>
		<DefaultValue(-10197916)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.41)>
		Public Property BorderColor As Color
			Get
				Return Me.ooO_O.O_O..BorderColor
			End Get
			Set(value As Color)
				Me.ooO_O.O_O..BorderColor = value
				If Me.ooO_O.O_O..BorderStyle <> BorderStyle.FixedSingle Then
					Me.ooO_O.O_O..BorderStyle = BorderStyle.FixedSingle
				End If
			End Set
		End Property

		' Token: 0x17000EA6 RID: 3750
		' (get) Token: 0x060042A2 RID: 17058 RVA: 0x001C1355 File Offset: 0x001BF555
		' (set) Token: 0x060042A3 RID: 17059 RVA: 0x001C1362 File Offset: 0x001BF562
		<DisplayName("下拉按钮")>
		<O_Oo00Oo000O0(3.0)>
		<Category("输入控制")>
		<DefaultValue(True)>
		<MergableProperty(True)>
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.ooO_O.O_O..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.ooO_O.O_O..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x17000EA7 RID: 3751
		' (get) Token: 0x060042A4 RID: 17060 RVA: 0x001C1370 File Offset: 0x001BF570
		' (set) Token: 0x060042A5 RID: 17061 RVA: 0x001C1378 File Offset: 0x001BF578
		<DisplayName("显示周数")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.0)>
		<Category("输入控制")>
		<DefaultValue(False)>
		Public Property ShowWeekNumbers As Boolean
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As Boolean)
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000EA8 RID: 3752
		' (get) Token: 0x060042A6 RID: 17062 RVA: 0x001C1381 File Offset: 0x001BF581
		' (set) Token: 0x060042A7 RID: 17063 RVA: 0x001C1389 File Offset: 0x001BF589
		<O_Oo00Oo000O0(5.0)>
		<Category("输入控制")>
		<DisplayName("日历维数")>
		<MergableProperty(True)>
		Public Property CalendarDimensions As Size
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As Size)
				value.Width = Math.Max(1, Math.Min(6, value.Width))
				value.Height = Math.Max(1, Math.Min(6, value.Height))
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000EA9 RID: 3753
		' (get) Token: 0x060042A8 RID: 17064 RVA: 0x001C13C6 File Offset: 0x001BF5C6
		' (set) Token: 0x060042A9 RID: 17065 RVA: 0x001C13CE File Offset: 0x001BF5CE
		<Description("文本改变后执行")>
		<oO0oooo("0768")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property TextChanged As EventString
			Get
				Return Me.o.oOOOo___o_.
			End Get
			Set(value As EventString)
				Me.o.oOOOo___o_. = value
			End Set
		End Property

		' Token: 0x17000EAA RID: 3754
		' (get) Token: 0x060042AA RID: 17066 RVA: 0x001C13D7 File Offset: 0x001BF5D7
		' (set) Token: 0x060042AB RID: 17067 RVA: 0x001C13DF File Offset: 0x001BF5DF
		<oO0oooo("0769")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("值改变后执行")>
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.O0_o.0.
			End Get
			Set(value As EventString)
				Me.O0_o.0. = value
			End Set
		End Property

		' Token: 0x04001B3B RID: 6971
		Private <<EMPTY_NAME>> As C1DropDownControl

		' Token: 0x04001B3C RID: 6972
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B3D RID: 6973
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B3E RID: 6974
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04001B3F RID: 6975
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B40 RID: 6976
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B41 RID: 6977
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B42 RID: 6978
		Private <<EMPTY_NAME>> As Size

		' Token: 0x04001B43 RID: 6979
		Private <<EMPTY_NAME>> As DateTimeFormatEnum
	End Class
End Namespace
