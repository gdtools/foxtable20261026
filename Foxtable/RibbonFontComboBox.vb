Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000481 RID: 1153
	<OoO0___o("RibbonFontComboBox")>
	<oO0oooo("1124")>
	Friend Class RibbonFontComboBox
		Inherits RibbonTextBox

		' Token: 0x06004CE1 RID: 19681 RVA: 0x002013B1 File Offset: 0x001FF5B1
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.oO_.OO__OOo_o0. = 8
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001151 RID: 4433
		' (get) Token: 0x06004CE2 RID: 19682 RVA: 0x002013C9 File Offset: 0x001FF5C9
		' (set) Token: 0x06004CE3 RID: 19683 RVA: 0x002013D1 File Offset: 0x001FF5D1
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(8)>
		<Category("属性")>
		<DisplayName("最大下拉项目数")>
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.oO_.OO__OOo_o0.
			End Get
			Set(value As Integer)
				Me.oO_.OO__OOo_o0. = value
			End Set
		End Property

		' Token: 0x17001152 RID: 4434
		' (get) Token: 0x06004CE4 RID: 19684 RVA: 0x002013DA File Offset: 0x001FF5DA
		' (set) Token: 0x06004CE5 RID: 19685 RVA: 0x002013E2 File Offset: 0x001FF5E2
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(10.0)>
		<Description("显示下拉列表后执行。")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property DropDown As EventString
			Get
				Return Me.OO_._O0.
			End Get
			Set(value As EventString)
				Me.OO_._O0. = value
			End Set
		End Property

		' Token: 0x17001153 RID: 4435
		' (get) Token: 0x06004CE6 RID: 19686 RVA: 0x002013EB File Offset: 0x001FF5EB
		' (set) Token: 0x06004CE7 RID: 19687 RVA: 0x002013F3 File Offset: 0x001FF5F3
		<O_Oo00Oo000O0(11.0)>
		<Category("事件")>
		<Description("关闭下拉列表后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property DropDownClosed As EventString
			Get
				Return Me.o_0O.Ooo.
			End Get
			Set(value As EventString)
				Me.o_0O.Ooo. = value
			End Set
		End Property

		' Token: 0x17001154 RID: 4436
		' (get) Token: 0x06004CE8 RID: 19688 RVA: 0x002013FC File Offset: 0x001FF5FC
		' (set) Token: 0x06004CE9 RID: 19689 RVA: 0x00201404 File Offset: 0x001FF604
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O_Oo00Oo000O0(11.0)>
		<O0O0oOO00_0OO(True)>
		<Description("选择不同项目后执行。")>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.o._000O0.
			End Get
			Set(value As EventString)
				Me.o._000O0. = value
			End Set
		End Property

		' Token: 0x17001155 RID: 4437
		' (get) Token: 0x06004CEA RID: 19690 RVA: 0x00201410 File Offset: 0x001FF610
		<Browsable(False)>
		Public ReadOnly Property MaxLength As Integer
			Get
				Dim result As Integer
				Return result
			End Get
		End Property

		' Token: 0x04001F95 RID: 8085
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F96 RID: 8086
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F97 RID: 8087
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F98 RID: 8088
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
