Imports System
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x020001AD RID: 429
	Friend Class ListViewProperty
		Inherits ControlPropertyBase

		' Token: 0x06001441 RID: 5185 RVA: 0x00080D73 File Offset: 0x0007EF73
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O._OOOO0_. = CType(A_0.ChildControl, o00_o00)
		End Sub

		' Token: 0x17000431 RID: 1073
		' (get) Token: 0x06001442 RID: 5186 RVA: 0x00080D8D File Offset: 0x0007EF8D
		' (set) Token: 0x06001443 RID: 5187 RVA: 0x00080D95 File Offset: 0x0007EF95
		<oO0oooo("2872")>
		<Description("双击某行或在某行按回车键后触发！")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.1)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property RowActivate As EventString
			Get
				Return Me.oOO_O_.OOO0o_.
			End Get
			Set(value As EventString)
				Me.oOO_O_.OOO0o_. = value
			End Set
		End Property

		' Token: 0x17000432 RID: 1074
		' (get) Token: 0x06001444 RID: 5188 RVA: 0x00080D9E File Offset: 0x0007EF9E
		' (set) Token: 0x06001445 RID: 5189 RVA: 0x00080DA6 File Offset: 0x0007EFA6
		<Description("行的复选框状态即将改变时触发！")>
		<oO0oooo("2789")>
		<O_Oo00Oo000O0(0.2)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property RowChecking As EventString
			Get
				Return Me.oO._oooooO0oo0.
			End Get
			Set(value As EventString)
				Me.oO._oooooO0oo0. = value
			End Set
		End Property

		' Token: 0x17000433 RID: 1075
		' (get) Token: 0x06001446 RID: 5190 RVA: 0x00080DAF File Offset: 0x0007EFAF
		' (set) Token: 0x06001447 RID: 5191 RVA: 0x00080DB7 File Offset: 0x0007EFB7
		<oO0oooo("2790")>
		<Description("行的复选框状态改变后触发！")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.3)>
		Public Property RowChecked As EventString
			Get
				Return Me.o_o__000O.o.
			End Get
			Set(value As EventString)
				Me.o_o__000O.o. = value
			End Set
		End Property

		' Token: 0x17000434 RID: 1076
		' (get) Token: 0x06001448 RID: 5192 RVA: 0x00080DC0 File Offset: 0x0007EFC0
		' (set) Token: 0x06001449 RID: 5193 RVA: 0x00080DC8 File Offset: 0x0007EFC8
		<Description("行的选中状态发生变化后触发！")>
		<oO0oooo("2786")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.4)>
		Public Property RowSelectionChanged As EventString
			Get
				Return Me.o_.o_OO_O.
			End Get
			Set(value As EventString)
				Me.o_.o_OO_O. = value
			End Set
		End Property

		' Token: 0x17000435 RID: 1077
		' (get) Token: 0x0600144A RID: 5194 RVA: 0x00080DD1 File Offset: 0x0007EFD1
		' (set) Token: 0x0600144B RID: 5195 RVA: 0x00080DD9 File Offset: 0x0007EFD9
		<Description("编辑标题前触发！")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("2787")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.5)>
		Public Property BeforeEdit As EventString
			Get
				Return Me.o._ooO0.
			End Get
			Set(value As EventString)
				Me.o._ooO0. = value
			End Set
		End Property

		' Token: 0x17000436 RID: 1078
		' (get) Token: 0x0600144C RID: 5196 RVA: 0x00080DE2 File Offset: 0x0007EFE2
		' (set) Token: 0x0600144D RID: 5197 RVA: 0x00080DEA File Offset: 0x0007EFEA
		<Category("事件")>
		<oO0oooo("2788")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.6)>
		<O0O0oOO00_0OO(True)>
		<Description("编辑标题前触发！")>
		Public Property AfterEdit As EventString
			Get
				Return Me.o_OOOOO_.0ooo.
			End Get
			Set(value As EventString)
				Me.o_OOOOO_.0ooo. = value
			End Set
		End Property

		' Token: 0x17000437 RID: 1079
		' (get) Token: 0x0600144E RID: 5198 RVA: 0x00080DF3 File Offset: 0x0007EFF3
		' (set) Token: 0x0600144F RID: 5199 RVA: 0x00080DFB File Offset: 0x0007EFFB
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O_Oo00Oo000O0(0.7)>
		<oO0oooo("2783")>
		<Description("在虚拟模式下生成指定位置的行时触发！")>
		<O0O0oOO00_0OO(True)>
		Public Property RetrieveVirtualRow As EventString
			Get
				Return Me.Oo.O0_oOOoo0.
			End Get
			Set(value As EventString)
				Me.Oo.O0_oOOoo0. = value
			End Set
		End Property

		' Token: 0x17000438 RID: 1080
		' (get) Token: 0x06001450 RID: 5200 RVA: 0x00080E04 File Offset: 0x0007F004
		' (set) Token: 0x06001451 RID: 5201 RVA: 0x00080E0C File Offset: 0x0007F00C
		<Description("开始拖动行前触发！")>
		<oO0oooo("2784")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.71)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeDragRow As EventString
			Get
				Return Me.o0OO.o.
			End Get
			Set(value As EventString)
				Me.o0OO.o. = value
			End Set
		End Property

		' Token: 0x17000439 RID: 1081
		' (get) Token: 0x06001452 RID: 5202 RVA: 0x00080E15 File Offset: 0x0007F015
		' (set) Token: 0x06001453 RID: 5203 RVA: 0x00080E1D File Offset: 0x0007F01D
		<Description("接收到拖动过来的行前触发！")>
		<oO0oooo("2785")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.71)>
		Public Property BeforeDropRow As EventString
			Get
				Return Me.ooO0o00O_.ooo0.
			End Get
			Set(value As EventString)
				Me.ooO0o00O_.ooo0. = value
			End Set
		End Property

		' Token: 0x1700043A RID: 1082
		' (get) Token: 0x06001454 RID: 5204 RVA: 0x00080E26 File Offset: 0x0007F026
		' (set) Token: 0x06001455 RID: 5205 RVA: 0x00080E2E File Offset: 0x0007F02E
		<O_Oo00Oo000O0(0.72)>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("2874")>
		<Category("事件")>
		<Description("绘制单元格的时候触发")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property DrawViewCell As EventString
			Get
				Return Me.O.0OOO__oO_0_.
			End Get
			Set(value As EventString)
				Me.O.0OOO__oO_0_. = value
			End Set
		End Property

		' Token: 0x040007D8 RID: 2008
		Private <<EMPTY_NAME>> As o00_o00

		' Token: 0x040007D9 RID: 2009
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DA RID: 2010
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DB RID: 2011
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DC RID: 2012
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DD RID: 2013
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DE RID: 2014
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007DF RID: 2015
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007E0 RID: 2016
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007E1 RID: 2017
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x040007E2 RID: 2018
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
