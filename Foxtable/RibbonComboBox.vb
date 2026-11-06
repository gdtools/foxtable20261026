Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000474 RID: 1140
	<OoO0___o("RibbonComboBox")>
	<oO0oooo("1114")>
	Friend Class RibbonComboBox
		Inherits RibbonTextBox

		' Token: 0x06004C35 RID: 19509 RVA: 0x00200C3E File Offset: 0x001FEE3E
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O_o0oO.O00o. = 12
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001101 RID: 4353
		' (get) Token: 0x06004C36 RID: 19510 RVA: 0x00200C57 File Offset: 0x001FEE57
		' (set) Token: 0x06004C37 RID: 19511 RVA: 0x00200C5F File Offset: 0x001FEE5F
		<O_Oo00Oo000O0(6.0)>
		<Category("属性")>
		<DisplayName("最大下拉项目数")>
		<DefaultValue(12)>
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.O_o0oO.O00o.
			End Get
			Set(value As Integer)
				Me.O_o0oO.O00o. = value
			End Set
		End Property

		' Token: 0x17001102 RID: 4354
		' (get) Token: 0x06004C38 RID: 19512 RVA: 0x00200C68 File Offset: 0x001FEE68
		' (set) Token: 0x06004C39 RID: 19513 RVA: 0x00200C6F File Offset: 0x001FEE6F
		<O_Oo00Oo000O0(100.0)>
		<DisplayName("列表项目")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<Category("属性")>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x17001103 RID: 4355
		' (get) Token: 0x06004C3A RID: 19514 RVA: 0x00200C71 File Offset: 0x001FEE71
		' (set) Token: 0x06004C3B RID: 19515 RVA: 0x00200C79 File Offset: 0x001FEE79
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O_Oo00Oo000O0(10.0)>
		<Description("显示下拉列表后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property DropDown As EventString
			Get
				Return Me.O_o0oO.O00o.
			End Get
			Set(value As EventString)
				Me.O_o0oO.O00o. = value
			End Set
		End Property

		' Token: 0x17001104 RID: 4356
		' (get) Token: 0x06004C3C RID: 19516 RVA: 0x00200C82 File Offset: 0x001FEE82
		' (set) Token: 0x06004C3D RID: 19517 RVA: 0x00200C8A File Offset: 0x001FEE8A
		<Category("事件")>
		<Description("关闭下拉列表后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(11.0)>
		<O0O0oOO00_0OO(True)>
		Public Property DropDownClosed As EventString
			Get
				Return Me.OOO_0.Oooo_0.
			End Get
			Set(value As EventString)
				Me.OOO_0.Oooo_0. = value
			End Set
		End Property

		' Token: 0x17001105 RID: 4357
		' (get) Token: 0x06004C3E RID: 19518 RVA: 0x00200C93 File Offset: 0x001FEE93
		' (set) Token: 0x06004C3F RID: 19519 RVA: 0x00200C9B File Offset: 0x001FEE9B
		<O_Oo00Oo000O0(11.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("选择不同项目后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.o.Ooo0O_0O.
			End Get
			Set(value As EventString)
				Me.o.Ooo0O_0O. = value
			End Set
		End Property

		' Token: 0x04001F50 RID: 8016
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F51 RID: 8017
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F52 RID: 8018
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F53 RID: 8019
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
