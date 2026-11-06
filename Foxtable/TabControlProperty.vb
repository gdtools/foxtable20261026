Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x02000411 RID: 1041
	Friend Class TabControlProperty
		Inherits ControlPropertyBase

		' Token: 0x060044B7 RID: 17591 RVA: 0x001C336D File Offset: 0x001C156D
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o.O_oO. = CType(A_0.ChildControl, C1DockingTab)
			Me.o.O_oO..TabsCanFocus = False
			Me.o.O_oO..TabLook = 3
		End Sub

		' Token: 0x17000FA9 RID: 4009
		' (get) Token: 0x060044B8 RID: 17592 RVA: 0x001C33A0 File Offset: 0x001C15A0
		' (set) Token: 0x060044B9 RID: 17593 RVA: 0x001C33AE File Offset: 0x001C15AE
		<OooO0(True)>
		<Browsable(False)>
		Public Overrides Property BackColor As Color
			Get
				Dim result As Color
				Return result
			End Get
			Set(value As Color)
			End Set
		End Property

		' Token: 0x17000FAA RID: 4010
		' (get) Token: 0x060044BA RID: 17594 RVA: 0x001C33B0 File Offset: 0x001C15B0
		' (set) Token: 0x060044BB RID: 17595 RVA: 0x001C33BE File Offset: 0x001C15BE
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

		' Token: 0x17000FAB RID: 4011
		' (get) Token: 0x060044BC RID: 17596 RVA: 0x001C33C0 File Offset: 0x001C15C0
		' (set) Token: 0x060044BD RID: 17597 RVA: 0x001C33D2 File Offset: 0x001C15D2
		<O_Oo00Oo000O0(0.0)>
		<Category("外观")>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.o.O_oO.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.o.O_oO. })
				Me.o.O_oO..TabSizeMode = 1
			End Set
		End Property

		' Token: 0x17000FAC RID: 4012
		' (get) Token: 0x060044BE RID: 17598 RVA: 0x001C33FA File Offset: 0x001C15FA
		' (set) Token: 0x060044BF RID: 17599 RVA: 0x001C3407 File Offset: 0x001C1607
		<DefaultValue(True)>
		<O_Oo00Oo000O0(0.1)>
		<MergableProperty(True)>
		<DisplayName("显示页签")>
		<Category("页签外观")>
		Public Property ShowTabs As Boolean
			Get
				Return Me.o.O_oO..ShowTabs
			End Get
			Set(value As Boolean)
				Me.o.O_oO..ShowTabs = value
			End Set
		End Property

		' Token: 0x17000FAD RID: 4013
		' (get) Token: 0x060044C0 RID: 17600 RVA: 0x001C3415 File Offset: 0x001C1615
		' (set) Token: 0x060044C1 RID: 17601 RVA: 0x001C3422 File Offset: 0x001C1622
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(0)>
		<Category("页签外观")>
		<DisplayName("页签位置")>
		<MergableProperty(True)>
		Public Property TabPosition As TabAlignment
			Get
				Return Me.o.O_oO..Alignment
			End Get
			Set(value As TabAlignment)
				Me.o.O_oO..Alignment = value
			End Set
		End Property

		' Token: 0x17000FAE RID: 4014
		' (get) Token: 0x060044C2 RID: 17602 RVA: 0x001C3430 File Offset: 0x001C1630
		' (set) Token: 0x060044C3 RID: 17603 RVA: 0x001C343D File Offset: 0x001C163D
		<DisplayName("页签对齐")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		<Category("页签外观")>
		Public Property TabAlign As StringAlignment
			Get
				Return Me.o.O_oO..AlignTabs
			End Get
			Set(value As StringAlignment)
				Me.o.O_oO..AlignTabs = value
			End Set
		End Property

		' Token: 0x17000FAF RID: 4015
		' (get) Token: 0x060044C4 RID: 17604 RVA: 0x001C344B File Offset: 0x001C164B
		' (set) Token: 0x060044C5 RID: 17605 RVA: 0x001C3458 File Offset: 0x001C1658
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<Category("页签外观")>
		<DefaultValue(False)>
		<DisplayName("多行页签")>
		Public Property MultiLine As Boolean
			Get
				Return Me.o.O_oO..MultiLine
			End Get
			Set(value As Boolean)
				Me.o.O_oO..MultiLine = value
			End Set
		End Property

		' Token: 0x17000FB0 RID: 4016
		' (get) Token: 0x060044C6 RID: 17606 RVA: 0x001C3466 File Offset: 0x001C1666
		' (set) Token: 0x060044C7 RID: 17607 RVA: 0x001C3473 File Offset: 0x001C1673
		<DefaultValue(0)>
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<Category("页签外观")>
		<DisplayName("页签文本方向")>
		Public Property TextDirection As TabTextDirectionEnum
			Get
				Return Me.o.O_oO..TextDirection
			End Get
			Set(value As TabTextDirectionEnum)
				Me.o.O_oO..TextDirection = value
			End Set
		End Property

		' Token: 0x17000FB1 RID: 4017
		' (get) Token: 0x060044C8 RID: 17608 RVA: 0x001C3481 File Offset: 0x001C1681
		' (set) Token: 0x060044C9 RID: 17609 RVA: 0x001C348E File Offset: 0x001C168E
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		<Category("页签外观")>
		<DisplayName("页签文本位置")>
		<DefaultValue(0)>
		Public Property TabLayout As ButtonLayoutEnum
			Get
				Return Me.o.O_oO..TabLayout
			End Get
			Set(value As ButtonLayoutEnum)
				Me.o.O_oO..TabLayout = value
			End Set
		End Property

		' Token: 0x17000FB2 RID: 4018
		' (get) Token: 0x060044CA RID: 17610 RVA: 0x001C349C File Offset: 0x001C169C
		' (set) Token: 0x060044CB RID: 17611 RVA: 0x001C34A9 File Offset: 0x001C16A9
		<Description("活动页签的字体是否加粗。")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(7.0)>
		<Category("页签外观")>
		<DefaultValue(False)>
		<DisplayName("粗体显示")>
		Public Property SelectedTabBold As Boolean
			Get
				Return Me.o.O_oO..SelectedTabBold
			End Get
			Set(value As Boolean)
				Me.o.O_oO..SelectedTabBold = value
			End Set
		End Property

		' Token: 0x17000FB3 RID: 4019
		' (get) Token: 0x060044CC RID: 17612 RVA: 0x001C34B7 File Offset: 0x001C16B7
		' (set) Token: 0x060044CD RID: 17613 RVA: 0x001C34C4 File Offset: 0x001C16C4
		<DisplayName("页签间距")>
		<Category("页签外观")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(8.0)>
		Public Property TabsSpacing As Integer
			Get
				Return Me.o.O_oO..TabsSpacing
			End Get
			Set(value As Integer)
				Me.o.O_oO..TabsSpacing = value
			End Set
		End Property

		' Token: 0x17000FB4 RID: 4020
		' (get) Token: 0x060044CE RID: 17614 RVA: 0x001C34D2 File Offset: 0x001C16D2
		' (set) Token: 0x060044CF RID: 17615 RVA: 0x001C34DF File Offset: 0x001C16DF
		<DefaultValue(5)>
		<O_Oo00Oo000O0(9.0)>
		<MergableProperty(True)>
		<Category("页签外观")>
		<DisplayName("页签缩进")>
		<Description("第一个页签的缩进距离。")>
		Public Property Indent As Integer
			Get
				Return Me.o.O_oO..Indent
			End Get
			Set(value As Integer)
				Me.o.O_oO..Indent = value
			End Set
		End Property

		' Token: 0x17000FB5 RID: 4021
		' (get) Token: 0x060044D0 RID: 17616 RVA: 0x001C34ED File Offset: 0x001C16ED
		' (set) Token: 0x060044D1 RID: 17617 RVA: 0x001C34FF File Offset: 0x001C16FF
		<OooO0(True)>
		<Category("选定页面")>
		<MergableProperty(False)>
		<DisplayName("页面标题")>
		<O_Oo00Oo000O0(1.0)>
		Public Property TextOfSelectedTab As String
			Get
				Return Me.o.O_oO..SelectedTab.Text
			End Get
			Set(value As String)
				Me.o.O_oO..SelectedTab.Text = value
			End Set
		End Property

		' Token: 0x17000FB6 RID: 4022
		' (get) Token: 0x060044D2 RID: 17618 RVA: 0x001C3512 File Offset: 0x001C1712
		' (set) Token: 0x060044D3 RID: 17619 RVA: 0x001C3524 File Offset: 0x001C1724
		<Category("选定页面")>
		<MergableProperty(False)>
		<DisplayName("页面名称")>
		<OooO0(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property NameOfSelectedTab As String
			Get
				Return Me.o.O_oO..SelectedTab.Name
			End Get
			Set(value As String)
				Me.o.O_oO..SelectedTab.Name = value
			End Set
		End Property

		' Token: 0x17000FB7 RID: 4023
		' (get) Token: 0x060044D4 RID: 17620 RVA: 0x001C3537 File Offset: 0x001C1737
		' (set) Token: 0x060044D5 RID: 17621 RVA: 0x001C354E File Offset: 0x001C174E
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<OooO0(True)>
		<DisplayName("页面图标")>
		<Category("选定页面")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(3.0)>
		Public Property ImageFileOfSelectedTab As String
			Get
				Return CType(Me.o.O_oO..SelectedTab, O_O_).ImageFile
			End Get
			Set(value As String)
				CType(Me.o.O_oO..SelectedTab, O_O_).ImageFile = value
			End Set
		End Property

		' Token: 0x17000FB8 RID: 4024
		' (get) Token: 0x060044D6 RID: 17622 RVA: 0x001C3566 File Offset: 0x001C1766
		' (set) Token: 0x060044D7 RID: 17623 RVA: 0x001C356E File Offset: 0x001C176E
		<Category("事件")>
		<oO0oooo("2415")>
		<Description("选定不同页面前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property SelectedIndexChanging As EventString
			Get
				Return Me.OO_._0_oO__0.
			End Get
			Set(value As EventString)
				Me.OO_._0_oO__0. = value
			End Set
		End Property

		' Token: 0x17000FB9 RID: 4025
		' (get) Token: 0x060044D8 RID: 17624 RVA: 0x001C3577 File Offset: 0x001C1777
		' (set) Token: 0x060044D9 RID: 17625 RVA: 0x001C357F File Offset: 0x001C177F
		<oO0oooo("0833")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("选定不同页面后执行。")>
		<O_Oo00Oo000O0(0.1)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.o.O_oO.
			End Get
			Set(value As EventString)
				Me.o.O_oO. = value
			End Set
		End Property

		' Token: 0x17000FBA RID: 4026
		' (get) Token: 0x060044DA RID: 17626 RVA: 0x001C3588 File Offset: 0x001C1788
		' (set) Token: 0x060044DB RID: 17627 RVA: 0x001C3604 File Offset: 0x001C1804
		<Browsable(False)>
		Public Property Pages As String
			Get
				Dim text As String = Nothing
				Dim num As Integer = Me.o.O_oO..TabPages.Count - 1
				For i As Integer = 0 To num
					Dim a_ As CustomDockingTabPageProperty = New CustomDockingTabPageProperty(CType(Me.o.O_oO..TabPages(i), O_O_))
					If i > 0 Then
						text += vbFormFeed
					End If
					text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbTab, False).Replace(vbFormFeed, "")
				Next
				Return text
			End Get
			Set(value As String)
				Dim array As String() = value.Split(New Char() { vbFormFeed })
				Me.o.O_oO..TabPages.Clear()
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim o_O_ As O_O_ = MyBase.Holder.oo_.o_O.()
					Dim a_ As Object = New CustomDockingTabPageProperty(o_O_)
					Me.o.O_oO..TabPages.Add(o_O_)
					o_O_o_oOoo__.OOOO_OO._oo.(a_, array(i), vbTab)
				Next
			End Set
		End Property

		' Token: 0x04001BF0 RID: 7152
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x04001BF1 RID: 7153
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BF2 RID: 7154
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BF3 RID: 7155
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BF4 RID: 7156
		Private <<EMPTY_NAME>> As VisualStyle
	End Class
End Namespace
