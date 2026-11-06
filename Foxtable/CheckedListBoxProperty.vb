Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003FA RID: 1018
	Friend Class CheckedListBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x060041F7 RID: 16887 RVA: 0x001C0765 File Offset: 0x001BE965
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.oo0._. = ","c
			Me.O_.o_O0O_o__. = CType(A_0.ChildControl, CheckedListBox)
		End Sub

		' Token: 0x17000E54 RID: 3668
		' (get) Token: 0x060041F8 RID: 16888 RVA: 0x001C0787 File Offset: 0x001BE987
		' (set) Token: 0x060041F9 RID: 16889 RVA: 0x001C0794 File Offset: 0x001BE994
		<DefaultValue(2)>
		<O_Oo00Oo000O0(0.4)>
		<DisplayName("边框")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O_.o_O0O_o__..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O_.o_O0O_o__..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000E55 RID: 3669
		' (get) Token: 0x060041FA RID: 16890 RVA: 0x001C07A2 File Offset: 0x001BE9A2
		' (set) Token: 0x060041FB RID: 16891 RVA: 0x001C07AA File Offset: 0x001BE9AA
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(False)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.o0Oo._0O.
			End Get
			Set(value As String)
				Me.o0Oo._0O. = value
			End Set
		End Property

		' Token: 0x17000E56 RID: 3670
		' (get) Token: 0x060041FC RID: 16892 RVA: 0x001C07B3 File Offset: 0x001BE9B3
		' (set) Token: 0x060041FD RID: 16893 RVA: 0x001C07BB File Offset: 0x001BE9BB
		<O_Oo00Oo000O0(2.3)>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<Category("基本")>
		<DisplayName("只读")>
		<Description("是否禁止用户修改。")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.oo0._.
			End Get
			Set(value As BooleanEnum)
				Me.oo0._. = value
			End Set
		End Property

		' Token: 0x17000E57 RID: 3671
		' (get) Token: 0x060041FE RID: 16894 RVA: 0x001C07C4 File Offset: 0x001BE9C4
		' (set) Token: 0x060041FF RID: 16895 RVA: 0x001C07CC File Offset: 0x001BE9CC
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("自定义项目")>
		<Category("列表项目")>
		<Editor(GetType(ooO0o0_oO0_0), GetType(UITypeEditor))>
		<MergableProperty(False)>
		Public Property ComboList As String
			Get
				Return Me.O_o._o0O.
			End Get
			Set(value As String)
				Me.O_o._o0O. = value
				Me.O_.o_O0O_o__..Items.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { vbCr, vbLf, "|"c }, StringSplitOptions.RemoveEmptyEntries)
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Me.O_.o_O0O_o__..Items.Add(array(i))
					Next
				End If
			End Set
		End Property

		' Token: 0x17000E58 RID: 3672
		' (get) Token: 0x06004200 RID: 16896 RVA: 0x001C083E File Offset: 0x001BEA3E
		' (set) Token: 0x06004201 RID: 16897 RVA: 0x001C0846 File Offset: 0x001BEA46
		<O_Oo00Oo000O0(3.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<DisplayName("显示列")>
		Public Property DisplayMember As String
			Get
				Return Me.OOO0.o.
			End Get
			Set(value As String)
				Me.OOO0.o. = value
				If Operators.CompareString(Me.O.ooo0_O., "", True) = 0 Then
					Me.O.ooo0_O. = value
				End If
			End Set
		End Property

		' Token: 0x17000E59 RID: 3673
		' (get) Token: 0x06004202 RID: 16898 RVA: 0x001C0869 File Offset: 0x001BEA69
		' (set) Token: 0x06004203 RID: 16899 RVA: 0x001C0871 File Offset: 0x001BEA71
		<MergableProperty(False)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<O_Oo00Oo000O0(4.0)>
		<Category("列表项目")>
		<DisplayName("取值列")>
		Public Property ValueMember As String
			Get
				Return Me.O.ooo0_O.
			End Get
			Set(value As String)
				Me.O.ooo0_O. = value
				If Operators.CompareString(Me.OOO0.o., "", True) = 0 Then
					Me.OOO0.o. = value
				End If
			End Set
		End Property

		' Token: 0x17000E5A RID: 3674
		' (get) Token: 0x06004204 RID: 16900 RVA: 0x001C0894 File Offset: 0x001BEA94
		' (set) Token: 0x06004205 RID: 16901 RVA: 0x001C089C File Offset: 0x001BEA9C
		<DisplayName("数据表")>
		<O_Oo00Oo000O0(2.0)>
		<Category("列表项目")>
		<Description("候选项目来源表")>
		<MergableProperty(False)>
		<TypeConverter(GetType(OoO_O0_OO0))>
		Public Property DataSource As String
			Get
				Return Me.o_.oo.
			End Get
			Set(value As String)
				Me.o_.oo. = value
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

		' Token: 0x17000E5B RID: 3675
		' (get) Token: 0x06004206 RID: 16902 RVA: 0x001C095A File Offset: 0x001BEB5A
		' (set) Token: 0x06004207 RID: 16903 RVA: 0x001C0962 File Offset: 0x001BEB62
		<DisplayName("分隔符")>
		<O_Oo00Oo000O0(5.0)>
		<DefaultValue(","c)>
		<Category("列表项目")>
		<MergableProperty(True)>
		<Description("用于分隔值的符号")>
		Public Property Separator As Char
			Get
				Return Me.oo0._.
			End Get
			Set(value As Char)
				Me.oo0._. = value
			End Set
		End Property

		' Token: 0x17000E5C RID: 3676
		' (get) Token: 0x06004208 RID: 16904 RVA: 0x001C096B File Offset: 0x001BEB6B
		' (set) Token: 0x06004209 RID: 16905 RVA: 0x001C0973 File Offset: 0x001BEB73
		<O_Oo00Oo000O0(6.0)>
		<Category("列表项目")>
		<DisplayName("过滤条件")>
		<Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")>
		<MergableProperty(False)>
		<Editor(GetType(O0O00), GetType(UITypeEditor))>
		Public Property DataFilter As String
			Get
				Return Me.O_._o.
			End Get
			Set(value As String)
				Me.O_._o. = value
			End Set
		End Property

		' Token: 0x17000E5D RID: 3677
		' (get) Token: 0x0600420A RID: 16906 RVA: 0x001C097C File Offset: 0x001BEB7C
		' (set) Token: 0x0600420B RID: 16907 RVA: 0x001C0989 File Offset: 0x001BEB89
		<DisplayName("多列显示")>
		<O_Oo00Oo000O0(7.0)>
		<Category("列表项目")>
		<Description("是否分多列显示项目。")>
		<DefaultValue(False)>
		<MergableProperty(True)>
		Public Property MultiColumn As Boolean
			Get
				Return Me.O_.o_O0O_o__..MultiColumn
			End Get
			Set(value As Boolean)
				Me.O_.o_O0O_o__..MultiColumn = value
			End Set
		End Property

		' Token: 0x17000E5E RID: 3678
		' (get) Token: 0x0600420C RID: 16908 RVA: 0x001C0997 File Offset: 0x001BEB97
		' (set) Token: 0x0600420D RID: 16909 RVA: 0x001C09A4 File Offset: 0x001BEBA4
		<DisplayName("每列列宽")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(8.0)>
		<Category("列表项目")>
		<Description("设置多列显示时，各列的宽度。")>
		<MergableProperty(True)>
		Public Property ColumnWidth As Integer
			Get
				Return Me.O_.o_O0O_o__..ColumnWidth
			End Get
			Set(value As Integer)
				Me.O_.o_O0O_o__..ColumnWidth = value
			End Set
		End Property

		' Token: 0x17000E5F RID: 3679
		' (get) Token: 0x0600420E RID: 16910 RVA: 0x001C09B2 File Offset: 0x001BEBB2
		' (set) Token: 0x0600420F RID: 16911 RVA: 0x001C09BF File Offset: 0x001BEBBF
		<Description("复选框是否在首次单击某项时切换。")>
		<MergableProperty(True)>
		<Category("列表项目")>
		<DisplayName("自动选中")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(9.0)>
		Public Property CheckOnClick As Boolean
			Get
				Return Me.O_.o_O0O_o__..CheckOnClick
			End Get
			Set(value As Boolean)
				Me.O_.o_O0O_o__..CheckOnClick = value
			End Set
		End Property

		' Token: 0x17000E60 RID: 3680
		' (get) Token: 0x06004210 RID: 16912 RVA: 0x001C09CD File Offset: 0x001BEBCD
		' (set) Token: 0x06004211 RID: 16913 RVA: 0x001C09D5 File Offset: 0x001BEBD5
		<Description("选择不同项目后执行。")>
		<O_Oo00Oo000O0(0.1)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0962")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.oo0._.
			End Get
			Set(value As EventString)
				Me.oo0._. = value
			End Set
		End Property

		' Token: 0x17000E61 RID: 3681
		' (get) Token: 0x06004212 RID: 16914 RVA: 0x001C09DE File Offset: 0x001BEBDE
		' (set) Token: 0x06004213 RID: 16915 RVA: 0x001C09E6 File Offset: 0x001BEBE6
		<O_Oo00Oo000O0(0.0)>
		<Description("某一项目的选中状态将要改变时执行。")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0965")>
		Public Property ItemCheck As EventString
			Get
				Return Me.o_.oo.
			End Get
			Set(value As EventString)
				Me.o_.oo. = value
			End Set
		End Property

		' Token: 0x17000E62 RID: 3682
		' (get) Token: 0x06004214 RID: 16916 RVA: 0x001C09EF File Offset: 0x001BEBEF
		' (set) Token: 0x06004215 RID: 16917 RVA: 0x001C09F7 File Offset: 0x001BEBF7
		<oO0oooo("0963")>
		<O_Oo00Oo000O0(0.4)>
		<Category("事件")>
		<Description("格式化列表项目显示值的时候执行！")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ListItemFormat As EventString
			Get
				Return Me.O_o._o0O.
			End Get
			Set(value As EventString)
				Me.O_o._o0O. = value
			End Set
		End Property

		' Token: 0x04001B0C RID: 6924
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001B0D RID: 6925
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B0E RID: 6926
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B0F RID: 6927
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04001B10 RID: 6928
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B11 RID: 6929
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B12 RID: 6930
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B13 RID: 6931
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B14 RID: 6932
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B15 RID: 6933
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B16 RID: 6934
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B17 RID: 6935
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
