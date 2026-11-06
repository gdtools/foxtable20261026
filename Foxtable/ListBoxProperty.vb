Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000406 RID: 1030
	Friend Class ListBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06004393 RID: 17299 RVA: 0x001C209E File Offset: 0x001C029E
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O0.ooOo0. = 3
			Me.O0.ooOo0. = CType(A_0.ChildControl, CustomListBox)
		End Sub

		' Token: 0x17000F1D RID: 3869
		' (get) Token: 0x06004394 RID: 17300 RVA: 0x001C20BF File Offset: 0x001C02BF
		' (set) Token: 0x06004395 RID: 17301 RVA: 0x001C20CC File Offset: 0x001C02CC
		<DisplayName("边框")>
		<DefaultValue(2)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.4)>
		<Category("外观")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O0.ooOo0..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O0.ooOo0..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000F1E RID: 3870
		' (get) Token: 0x06004396 RID: 17302 RVA: 0x001C20DA File Offset: 0x001C02DA
		' (set) Token: 0x06004397 RID: 17303 RVA: 0x001C20E4 File Offset: 0x001C02E4
		<DisplayName("自定义项目")>
		<Editor(GetType(ooO0o0_oO0_0), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(1.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		Public Property ComboList As String
			Get
				Return Me.O_0__.0oo0.
			End Get
			Set(value As String)
				Me.O_0__.0oo0. = value
				Me.O0.ooOo0..Items.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { vbCr, vbLf, "|"c }, StringSplitOptions.RemoveEmptyEntries)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Me.O0.ooOo0..Items.Add(array(i))
					Next
				End If
			End Set
		End Property

		' Token: 0x17000F1F RID: 3871
		' (get) Token: 0x06004398 RID: 17304 RVA: 0x001C2156 File Offset: 0x001C0356
		' (set) Token: 0x06004399 RID: 17305 RVA: 0x001C215E File Offset: 0x001C035E
		<MergableProperty(False)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("显示列")>
		<Category("列表项目")>
		<TypeConverter(GetType(oo0OOO_0__))>
		Public Property DisplayMember As String
			Get
				Return Me.o0_._O0o.
			End Get
			Set(value As String)
				Me.o0_._O0o. = value
				If Operators.CompareString(Me.OO_oo0O0o.OO., "", True) = 0 Then
					Me.OO_oo0O0o.OO. = value
				End If
			End Set
		End Property

		' Token: 0x17000F20 RID: 3872
		' (get) Token: 0x0600439A RID: 17306 RVA: 0x001C2181 File Offset: 0x001C0381
		' (set) Token: 0x0600439B RID: 17307 RVA: 0x001C2189 File Offset: 0x001C0389
		<TypeConverter(GetType(oo0OOO_0__))>
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(False)>
		<DisplayName("取值列")>
		<Category("列表项目")>
		Public Property ValueMember As String
			Get
				Return Me.OO_oo0O0o.OO.
			End Get
			Set(value As String)
				Me.OO_oo0O0o.OO. = value
				If Operators.CompareString(Me.o0_._O0o., "", True) = 0 Then
					Me.o0_._O0o. = value
				End If
			End Set
		End Property

		' Token: 0x17000F21 RID: 3873
		' (get) Token: 0x0600439C RID: 17308 RVA: 0x001C21AC File Offset: 0x001C03AC
		' (set) Token: 0x0600439D RID: 17309 RVA: 0x001C21B4 File Offset: 0x001C03B4
		<Description("候选项目来源表")>
		<MergableProperty(False)>
		<TypeConverter(GetType(OoO_O0_OO0))>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("数据表")>
		<Category("列表项目")>
		Public Property DataSource As String
			Get
				Return Me.O000_o.oo00.
			End Get
			Set(value As String)
				Me.O000_o.oo00. = value
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

		' Token: 0x17000F22 RID: 3874
		' (get) Token: 0x0600439E RID: 17310 RVA: 0x001C2272 File Offset: 0x001C0472
		' (set) Token: 0x0600439F RID: 17311 RVA: 0x001C227A File Offset: 0x001C047A
		<MergableProperty(False)>
		<O_Oo00Oo000O0(5.0)>
		<Category("列表项目")>
		<Editor(GetType(O0O00), GetType(UITypeEditor))>
		<DisplayName("过滤条件")>
		<Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")>
		Public Property DataFilter As String
			Get
				Return Me.o_ooO0o.00_.
			End Get
			Set(value As String)
				Me.o_ooO0o.00_. = value
			End Set
		End Property

		' Token: 0x17000F23 RID: 3875
		' (get) Token: 0x060043A0 RID: 17312 RVA: 0x001C2283 File Offset: 0x001C0483
		' (set) Token: 0x060043A1 RID: 17313 RVA: 0x001C2290 File Offset: 0x001C0490
		<DefaultValue(False)>
		<O_Oo00Oo000O0(6.0)>
		<Category("列表项目")>
		<Description("是否分多列显示项目。")>
		<MergableProperty(True)>
		<DisplayName("多列显示")>
		Public Property MultiColumn As Boolean
			Get
				Return Me.O0.ooOo0..MultiColumn
			End Get
			Set(value As Boolean)
				Me.O0.ooOo0..MultiColumn = value
			End Set
		End Property

		' Token: 0x17000F24 RID: 3876
		' (get) Token: 0x060043A2 RID: 17314 RVA: 0x001C229E File Offset: 0x001C049E
		' (set) Token: 0x060043A3 RID: 17315 RVA: 0x001C22AB File Offset: 0x001C04AB
		<DisplayName("每列列宽")>
		<Description("设置多列显示时，各列的宽度。")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(7.0)>
		<Category("列表项目")>
		Public Property ColumnWidth As Integer
			Get
				Return Me.O0.ooOo0..ColumnWidth
			End Get
			Set(value As Integer)
				Me.O0.ooOo0..ColumnWidth = value
			End Set
		End Property

		' Token: 0x17000F25 RID: 3877
		' (get) Token: 0x060043A4 RID: 17316 RVA: 0x001C22B9 File Offset: 0x001C04B9
		' (set) Token: 0x060043A5 RID: 17317 RVA: 0x001C22C6 File Offset: 0x001C04C6
		<Description("项目间距，单位为像素。")>
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("项目间距")>
		<Category("列表项目")>
		<MergableProperty(True)>
		<DefaultValue(3)>
		Public Property ItemSpacing As Integer
			Get
				Return Me.O0.ooOo0..ItemSpacing
			End Get
			Set(value As Integer)
				Me.O0.ooOo0..ItemSpacing = value
			End Set
		End Property

		' Token: 0x17000F26 RID: 3878
		' (get) Token: 0x060043A6 RID: 17318 RVA: 0x001C22D4 File Offset: 0x001C04D4
		' (set) Token: 0x060043A7 RID: 17319 RVA: 0x001C22DC File Offset: 0x001C04DC
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(False)>
		<Category("基本")>
		<DisplayName("绑定到")>
		Public Property BindingField As String
			Get
				Return Me.o._Ooo0oOO.
			End Get
			Set(value As String)
				Me.o._Ooo0oOO. = value
			End Set
		End Property

		' Token: 0x17000F27 RID: 3879
		' (get) Token: 0x060043A8 RID: 17320 RVA: 0x001C22E5 File Offset: 0x001C04E5
		' (set) Token: 0x060043A9 RID: 17321 RVA: 0x001C22ED File Offset: 0x001C04ED
		<Category("基本")>
		<Description("是否禁止用户修改。")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("只读")>
		<O_Oo00Oo000O0(2.3)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O0.ooOo0.
			End Get
			Set(value As BooleanEnum)
				Me.O0.ooOo0. = value
			End Set
		End Property

		' Token: 0x17000F28 RID: 3880
		' (get) Token: 0x060043AA RID: 17322 RVA: 0x001C22F6 File Offset: 0x001C04F6
		' (set) Token: 0x060043AB RID: 17323 RVA: 0x001C22FE File Offset: 0x001C04FE
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0962")>
		<Description("选择不同项目后执行。")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.O0.ooOo0.
			End Get
			Set(value As EventString)
				Me.O0.ooOo0. = value
			End Set
		End Property

		' Token: 0x17000F29 RID: 3881
		' (get) Token: 0x060043AC RID: 17324 RVA: 0x001C2307 File Offset: 0x001C0507
		' (set) Token: 0x060043AD RID: 17325 RVA: 0x001C230F File Offset: 0x001C050F
		<Description("格式化列表项目显示值的时候执行！")>
		<Category("事件")>
		<O_Oo00Oo000O0(0.4)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0963")>
		<O0O0oOO00_0OO(True)>
		Public Property ListItemFormat As EventString
			Get
				Return Me.o0_.O0_0ooo0o.
			End Get
			Set(value As EventString)
				Me.o0_.O0_0ooo0o. = value
			End Set
		End Property

		' Token: 0x04001B9A RID: 7066
		Private <<EMPTY_NAME>> As CustomListBox

		' Token: 0x04001B9B RID: 7067
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B9C RID: 7068
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B9D RID: 7069
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B9E RID: 7070
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B9F RID: 7071
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BA0 RID: 7072
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BA1 RID: 7073
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BA2 RID: 7074
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BA3 RID: 7075
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BA4 RID: 7076
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
