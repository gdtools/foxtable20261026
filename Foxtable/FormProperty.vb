Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000402 RID: 1026
	<OoO0___o("Form")>
	Friend Class FormProperty
		' Token: 0x060042DF RID: 17119 RVA: 0x001C16B0 File Offset: 0x001BF8B0
		Public Sub New(A_0 As o\u3002\u3002\u3000\u3000\u3002)
			Me.o_00.OOO__o_OO. = ToolTipIcon.Info
			Me.OOo0OO00O0.0. = "提示"
			Me.o.o0o. = False
			Me.O.OO00OoO0. = True
			Me.O.00_. = True
			Me.oOO00.oo_OoO. = True
			Me.O__._. = 1000
			Me.OOOoO_oo.O. = New PrintPageProperty()
			Me.o_00.OOO__o_OO. = TabAlignment.Bottom
			Me.o0.0_0000OO. = "(default)"
			Me.OO_0O0.O. = True
			Me.oO.o0o0000OO. = A_0
			Me.FormStyle = FormStyleEnum.停靠
			Me.DockArea = 0
			Me.StartPosition = FormStartPosition.CenterScreen
		End Sub

		' Token: 0x17000EC4 RID: 3780
		' (get) Token: 0x060042E0 RID: 17120 RVA: 0x001C173C File Offset: 0x001BF93C
		<Browsable(False)>
		Public ReadOnly Property Form As o\u3002\u3002\u3000\u3000\u3002
			Get
				Return Me.oO.o0o0000OO.
			End Get
		End Property

		' Token: 0x17000EC5 RID: 3781
		' (get) Token: 0x060042E1 RID: 17121 RVA: 0x001C1744 File Offset: 0x001BF944
		<Browsable(False)>
		<OooO0(True)>
		Public ReadOnly Property Page As PrintPageProperty
			Get
				Return Me.OOOoO_oo.O.
			End Get
		End Property

		' Token: 0x17000EC6 RID: 3782
		' (get) Token: 0x060042E2 RID: 17122 RVA: 0x001C174C File Offset: 0x001BF94C
		' (set) Token: 0x060042E3 RID: 17123 RVA: 0x001C175D File Offset: 0x001BF95D
		<Browsable(False)>
		<DefaultValue("")>
		Public Property PageSetting As String
			Get
				Return o_O_o_oOoo__.OOOO_OO._oo.(Me.Page, False, vbTab, False)
			End Get
			Set(value As String)
				o_O_o_oOoo__.OOOO_OO._oo.(Me.Page, value, vbTab)
			End Set
		End Property

		' Token: 0x17000EC7 RID: 3783
		' (get) Token: 0x060042E4 RID: 17124 RVA: 0x001C176D File Offset: 0x001BF96D
		' (set) Token: 0x060042E5 RID: 17125 RVA: 0x001C1775 File Offset: 0x001BF975
		<O_Oo00Oo000O0(1.0)>
		<Category("基本")>
		<DisplayName("所有者表")>
		<MergableProperty(False)>
		<TypeConverter(GetType(OoO_O0_OO0))>
		<OooO0(True)>
		Public Property TablName As String
			Get
				Return Me.o_00.OOO__o_OO.
			End Get
			Set(value As String)
				Me.o_00.OOO__o_OO. = value
			End Set
		End Property

		' Token: 0x17000EC8 RID: 3784
		' (get) Token: 0x060042E6 RID: 17126 RVA: 0x001C177E File Offset: 0x001BF97E
		' (set) Token: 0x060042E7 RID: 17127 RVA: 0x001C178B File Offset: 0x001BF98B
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("窗口标题")>
		<Category("基本")>
		<MergableProperty(False)>
		<DefaultValue("＊　　　＊")>
		Public Property Text As String
			Get
				Return Me.oO.o0o0000OO..Text
			End Get
			Set(value As String)
				Me.oO.o0o0000OO..Text = value
			End Set
		End Property

		' Token: 0x17000EC9 RID: 3785
		' (get) Token: 0x060042E8 RID: 17128 RVA: 0x001C1799 File Offset: 0x001BF999
		' (set) Token: 0x060042E9 RID: 17129 RVA: 0x001C17A1 File Offset: 0x001BF9A1
		<Description("打开并列窗口后窗口标签显示的位置")>
		<DisplayName("标题位置")>
		<Category("基本")>
		<O_Oo00Oo000O0(3.1)>
		Public Property TabAlignment As TabAlignment
			Get
				Return Me.o_00.OOO__o_OO.
			End Get
			Set(value As TabAlignment)
				Me.o_00.OOO__o_OO. = value
			End Set
		End Property

		' Token: 0x17000ECA RID: 3786
		' (get) Token: 0x060042EA RID: 17130 RVA: 0x001C17AA File Offset: 0x001BF9AA
		' (set) Token: 0x060042EB RID: 17131 RVA: 0x001C17B4 File Offset: 0x001BF9B4
		<DisplayName("窗口类型")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(3.0)>
		<Category("基本")>
		Public Property FormStyle As FormStyleEnum
			Get
				Return Me.oO.o0o0000OO.
			End Get
			Set(value As FormStyleEnum)
				Me.oO.o0o0000OO. = value
				If value = FormStyleEnum.模式 Then
					Me.AutoOpen = False
				End If
				If Me.Form.o_0O.OO0_0_. IsNot Nothing Then
					If value = FormStyleEnum.DropDownForm Then
						If Conversions.ToInteger(Me.Form.o_0O.OO0_0_.("Type")) <> 233 Then
							Me.Form.o_0O.OO0_0_.("Type") = ControlTypeEnum.DropDownForm
							Return
						End If
					ElseIf Conversions.ToInteger(Me.Form.o_0O.OO0_0_.("Type")) <> 229 Then
						Me.Form.o_0O.OO0_0_.("Type") = ControlTypeEnum.Form
					End If
				End If
			End Set
		End Property

		' Token: 0x17000ECB RID: 3787
		' (get) Token: 0x060042EC RID: 17132 RVA: 0x001C1868 File Offset: 0x001BFA68
		' (set) Token: 0x060042ED RID: 17133 RVA: 0x001C1870 File Offset: 0x001BFA70
		<MergableProperty(False)>
		<OooO0(True)>
		<Category("基本")>
		<DisplayName("自动打开")>
		<Description("是否在启动的时候，自动打开此窗口。")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(4.0)>
		Public Property AutoOpen As Boolean
			Get
				Return Me.o0o__o._O.
			End Get
			Set(value As Boolean)
				Me.o0o__o._O. = value
				If Me.FormStyle = FormStyleEnum.模式 Then
					Me.o0o__o._O. = False
				End If
			End Set
		End Property

		' Token: 0x17000ECC RID: 3788
		' (get) Token: 0x060042EE RID: 17134 RVA: 0x001C1889 File Offset: 0x001BFA89
		' (set) Token: 0x060042EF RID: 17135 RVA: 0x001C1896 File Offset: 0x001BFA96
		<DisplayName("自动滚动")>
		<O_Oo00Oo000O0(5.2)>
		<Category("基本")>
		<MergableProperty(True)>
		<DefaultValue(False)>
		Public Property AutoScroll As Boolean
			Get
				Return Me.Form.AutoScroll
			End Get
			Set(value As Boolean)
				Me.Form.AutoScroll = value
			End Set
		End Property

		' Token: 0x17000ECD RID: 3789
		' (get) Token: 0x060042F0 RID: 17136 RVA: 0x001C18A4 File Offset: 0x001BFAA4
		' (set) Token: 0x060042F1 RID: 17137 RVA: 0x001C18B1 File Offset: 0x001BFAB1
		<DisplayName("扩展尺寸")>
		<O_Oo00Oo000O0(5.3)>
		<Category("基本")>
		<MergableProperty(True)>
		Public Property ExtendSize As Size
			Get
				Return Me.Form.AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.Form.AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x17000ECE RID: 3790
		' (get) Token: 0x060042F2 RID: 17138 RVA: 0x001C18BF File Offset: 0x001BFABF
		' (set) Token: 0x060042F3 RID: 17139 RVA: 0x001C18C7 File Offset: 0x001BFAC7
		<Browsable(False)>
		Public Property Developer As String
			Get
				Return Me.oOoo0._O00__00.
			End Get
			Set(value As String)
				Me.oOoo0._O00__00. = value
			End Set
		End Property

		' Token: 0x17000ECF RID: 3791
		' (get) Token: 0x060042F4 RID: 17140 RVA: 0x001C18D0 File Offset: 0x001BFAD0
		' (set) Token: 0x060042F5 RID: 17141 RVA: 0x001C18D8 File Offset: 0x001BFAD8
		<Category("外观")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.0)>
		<MergableProperty(False)>
		<DisplayName("窗口图标")>
		Public Property ImageFile As String
			Get
				Return Me.O00_.o00OO0o00.
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso Not value.EndsWith(".ico", StringComparison.CurrentCultureIgnoreCase) Then
					MessageBox.Show("只有Icon文件才能作为窗口图标！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.O00_.o00OO0o00. = value
				Try
					If Operators.CompareString(value, "", True) > 0 Then
						Me.oO.o0o0000OO..Icon = New Icon(value)
					End If
				Catch ex As Exception
					Me.oO.o0o0000OO..Icon = Nothing
				End Try
				If Operators.CompareString(value, "", True) > 0 Then
					Me.oO.o0o0000OO..ShowIcon = True
					Return
				End If
				Me.oO.o0o0000OO..ShowIcon = False
			End Set
		End Property

		' Token: 0x17000ED0 RID: 3792
		' (get) Token: 0x060042F6 RID: 17142 RVA: 0x001C1994 File Offset: 0x001BFB94
		' (set) Token: 0x060042F7 RID: 17143 RVA: 0x001C199C File Offset: 0x001BFB9C
		<DefaultValue("(default)")>
		<O_Oo00Oo000O0(1.0)>
		<Category("外观")>
		<DisplayName("菜单样式")>
		<TypeConverter(GetType(oo__O__O_OoO))>
		Public Property MenuTheme As String
			Get
				Return Me.o0.0_0000OO.
			End Get
			Set(value As String)
				Me.o0.0_0000OO. = value
			End Set
		End Property

		' Token: 0x17000ED1 RID: 3793
		' (get) Token: 0x060042F8 RID: 17144 RVA: 0x001C19A5 File Offset: 0x001BFBA5
		' (set) Token: 0x060042F9 RID: 17145 RVA: 0x001C19B2 File Offset: 0x001BFBB2
		<MergableProperty(False)>
		<Category("外观")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("背景颜色")>
		Public Property BackColor As Color
			Get
				Return Me.oO.o0o0000OO..BackColor
			End Get
			Set(value As Color)
				Me.oO.o0o0000OO..BackColor = value
			End Set
		End Property

		' Token: 0x17000ED2 RID: 3794
		' (get) Token: 0x060042FA RID: 17146 RVA: 0x001C19C0 File Offset: 0x001BFBC0
		' (set) Token: 0x060042FB RID: 17147 RVA: 0x001C19C8 File Offset: 0x001BFBC8
		<Category("外观")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("背景图片")>
		<MergableProperty(False)>
		Public Property BackGroundImageFile As String
			Get
				Return Me.oO._0Ooo.
			End Get
			Set(value As String)
				Me.oO._0Ooo. = value
				Me.oO.o0o0000OO..BackgroundImage = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17000ED3 RID: 3795
		' (get) Token: 0x060042FC RID: 17148 RVA: 0x001C19E2 File Offset: 0x001BFBE2
		' (set) Token: 0x060042FD RID: 17149 RVA: 0x001C19EF File Offset: 0x001BFBEF
		<O_Oo00Oo000O0(4.0)>
		<Category("外观")>
		<MergableProperty(False)>
		<DefaultValue(1)>
		<DisplayName("背景布局")>
		Public Property BackgroundImageLayout As ImageLayout
			Get
				Return Me.oO.o0o0000OO..BackgroundImageLayout
			End Get
			Set(value As ImageLayout)
				Me.oO.o0o0000OO..BackgroundImageLayout = value
			End Set
		End Property

		' Token: 0x17000ED4 RID: 3796
		' (get) Token: 0x060042FE RID: 17150 RVA: 0x001C19FD File Offset: 0x001BFBFD
		' (set) Token: 0x060042FF RID: 17151 RVA: 0x001C1A05 File Offset: 0x001BFC05
		<Category("位置")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(1)>
		<MergableProperty(False)>
		<DisplayName("初始位置")>
		Public Property StartPosition As FormStartPosition
			Get
				Return Me.o_00.OOO__o_OO.
			End Get
			Set(value As FormStartPosition)
				Me.o_00.OOO__o_OO. = value
			End Set
		End Property

		' Token: 0x17000ED5 RID: 3797
		' (get) Token: 0x06004300 RID: 17152 RVA: 0x001C1A0E File Offset: 0x001BFC0E
		' (set) Token: 0x06004301 RID: 17153 RVA: 0x001C1A16 File Offset: 0x001BFC16
		<MergableProperty(False)>
		<DefaultValue(False)>
		<Category("位置")>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("最顶层")>
		Public Property TopMost As Boolean
			Get
				Return Me.o_0O0O0_._OO.
			End Get
			Set(value As Boolean)
				Me.o_0O0O0_._OO. = value
			End Set
		End Property

		' Token: 0x17000ED6 RID: 3798
		' (get) Token: 0x06004302 RID: 17154 RVA: 0x001C1A1F File Offset: 0x001BFC1F
		' (set) Token: 0x06004303 RID: 17155 RVA: 0x001C1A27 File Offset: 0x001BFC27
		<MergableProperty(False)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("左")>
		<Category("位置")>
		Public Property Left As Integer
			Get
				Return Me.O_O0O.o.
			End Get
			Set(value As Integer)
				Me.O_O0O.o. = value
			End Set
		End Property

		' Token: 0x17000ED7 RID: 3799
		' (get) Token: 0x06004304 RID: 17156 RVA: 0x001C1A30 File Offset: 0x001BFC30
		' (set) Token: 0x06004305 RID: 17157 RVA: 0x001C1A38 File Offset: 0x001BFC38
		<O_Oo00Oo000O0(3.0)>
		<Category("位置")>
		<DisplayName("上")>
		<MergableProperty(False)>
		Public Property Top As Integer
			Get
				Return Me.OOo0OO00O0.0.
			End Get
			Set(value As Integer)
				Me.OOo0OO00O0.0. = value
			End Set
		End Property

		' Token: 0x17000ED8 RID: 3800
		' (get) Token: 0x06004306 RID: 17158 RVA: 0x001C1A44 File Offset: 0x001BFC44
		' (set) Token: 0x06004307 RID: 17159 RVA: 0x001C1A64 File Offset: 0x001BFC64
		<O_Oo00Oo000O0(4.0)>
		<Category("位置")>
		<MergableProperty(False)>
		<DisplayName("宽")>
		Public Property Width As Integer
			Get
				Return Me.oO.o0o0000OO..ClientSize.Width
			End Get
			Set(value As Integer)
				Me.oO.o0o0000OO..ClientSize = New Size(value, Me.oO.o0o0000OO..ClientSize.Height)
			End Set
		End Property

		' Token: 0x17000ED9 RID: 3801
		' (get) Token: 0x06004308 RID: 17160 RVA: 0x001C1A98 File Offset: 0x001BFC98
		' (set) Token: 0x06004309 RID: 17161 RVA: 0x001C1AB8 File Offset: 0x001BFCB8
		<O_Oo00Oo000O0(5.0)>
		<MergableProperty(False)>
		<DisplayName("高")>
		<Category("位置")>
		Public Property Height As Integer
			Get
				Return Me.oO.o0o0000OO..ClientSize.Height
			End Get
			Set(value As Integer)
				Me.oO.o0o0000OO..ClientSize = New Size(Me.oO.o0o0000OO..ClientSize.Width, value)
			End Set
		End Property

		' Token: 0x17000EDA RID: 3802
		' (get) Token: 0x0600430A RID: 17162 RVA: 0x001C1AE9 File Offset: 0x001BFCE9
		' (set) Token: 0x0600430B RID: 17163 RVA: 0x001C1AF1 File Offset: 0x001BFCF1
		<Category("停靠")>
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(False)>
		<DefaultValue(0)>
		<DisplayName("停靠区域")>
		Public Property DockArea As DockAreaEnum
			Get
				Return Me.oOo.ooo_0OOo0O.
			End Get
			Set(value As DockAreaEnum)
				Me.oOo.ooo_0OOo0O. = value
			End Set
		End Property

		' Token: 0x17000EDB RID: 3803
		' (get) Token: 0x0600430C RID: 17164 RVA: 0x001C1AFA File Offset: 0x001BFCFA
		' (set) Token: 0x0600430D RID: 17165 RVA: 0x001C1B02 File Offset: 0x001BFD02
		<DefaultValue(False)>
		<O_Oo00Oo000O0(4.0)>
		<Category("停靠")>
		<MergableProperty(False)>
		<DisplayName("独立停靠")>
		Public Property DockTitle As Boolean
			Get
				Return Me.O00_.o00OO0o00.
			End Get
			Set(value As Boolean)
				Me.O00_.o00OO0o00. = value
			End Set
		End Property

		' Token: 0x17000EDC RID: 3804
		' (get) Token: 0x0600430E RID: 17166 RVA: 0x001C1B0B File Offset: 0x001BFD0B
		' (set) Token: 0x0600430F RID: 17167 RVA: 0x001C1B13 File Offset: 0x001BFD13
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("显示标题")>
		<Category("停靠")>
		Public Property ShowDockCaption As Boolean
			Get
				Return Me.O.00_.
			End Get
			Set(value As Boolean)
				Me.O.00_. = value
			End Set
		End Property

		' Token: 0x17000EDD RID: 3805
		' (get) Token: 0x06004310 RID: 17168 RVA: 0x001C1B1C File Offset: 0x001BFD1C
		' (set) Token: 0x06004311 RID: 17169 RVA: 0x001C1B24 File Offset: 0x001BFD24
		<Category("停靠")>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("允许关闭")>
		Public Property ShowCloseButton As Boolean
			Get
				Return Me.oOO00.oo_OoO.
			End Get
			Set(value As Boolean)
				Me.oOO00.oo_OoO. = value
			End Set
		End Property

		' Token: 0x17000EDE RID: 3806
		' (get) Token: 0x06004312 RID: 17170 RVA: 0x001C1B2D File Offset: 0x001BFD2D
		' (set) Token: 0x06004313 RID: 17171 RVA: 0x001C1B35 File Offset: 0x001BFD35
		<Category("停靠")>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("自动隐藏")>
		Public Property AutoHide As Boolean
			Get
				Return Me.OO_o0O.O_0.
			End Get
			Set(value As Boolean)
				Me.OO_o0O.O_0. = value
			End Set
		End Property

		' Token: 0x17000EDF RID: 3807
		' (get) Token: 0x06004314 RID: 17172 RVA: 0x001C1B3E File Offset: 0x001BFD3E
		' (set) Token: 0x06004315 RID: 17173 RVA: 0x001C1B46 File Offset: 0x001BFD46
		<Category("杂项")>
		<O_Oo00Oo000O0(1.9)>
		<DisplayName("自动调整布局")>
		<Description("窗口大小发生变化后，是否自动调整控件大小和布局")>
		<DefaultValue(False)>
		Public Property AutoLayout As Boolean
			Get
				Return Me.OO_o__.OO.
			End Get
			Set(value As Boolean)
				Me.OO_o__.OO. = value
			End Set
		End Property

		' Token: 0x17000EE0 RID: 3808
		' (get) Token: 0x06004316 RID: 17174 RVA: 0x001C1B4F File Offset: 0x001BFD4F
		' (set) Token: 0x06004317 RID: 17175 RVA: 0x001C1B57 File Offset: 0x001BFD57
		<Description("窗口大小发生变化后，在调整控件大小的时候，是否同步调整字体大小")>
		<O_Oo00Oo000O0(1.91)>
		<DisplayName("自动调整字体")>
		<Category("杂项")>
		<DefaultValue(True)>
		Public Property AutoResizeFonts As Boolean
			Get
				Return Me.OO_0O0.O.
			End Get
			Set(value As Boolean)
				Me.OO_0O0.O. = value
			End Set
		End Property

		' Token: 0x17000EE1 RID: 3809
		' (get) Token: 0x06004318 RID: 17176 RVA: 0x001C1B60 File Offset: 0x001BFD60
		' (set) Token: 0x06004319 RID: 17177 RVA: 0x001C1B68 File Offset: 0x001BFD68
		<DisplayName("大小可调")>
		<Description("作为独立窗口时，其大小是否可调。")>
		<Category("杂项")>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(True)>
		Public Property AllowResize As Boolean
			Get
				Return Me.O.OO00OoO0.
			End Get
			Set(value As Boolean)
				Me.O.OO00OoO0. = value
			End Set
		End Property

		' Token: 0x17000EE2 RID: 3810
		' (get) Token: 0x0600431A RID: 17178 RVA: 0x001C1B71 File Offset: 0x001BFD71
		' (set) Token: 0x0600431B RID: 17179 RVA: 0x001C1B7E File Offset: 0x001BFD7E
		<Category("杂项")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("显示图标")>
		<DefaultValue(False)>
		Public Property ShowIcon As Boolean
			Get
				Return Me.oO.o0o0000OO..ShowIcon
			End Get
			Set(value As Boolean)
				Me.oO.o0o0000OO..ShowIcon = value
			End Set
		End Property

		' Token: 0x17000EE3 RID: 3811
		' (get) Token: 0x0600431C RID: 17180 RVA: 0x001C1B8C File Offset: 0x001BFD8C
		' (set) Token: 0x0600431D RID: 17181 RVA: 0x001C1B99 File Offset: 0x001BFD99
		<Category("杂项")>
		<MergableProperty(False)>
		<DefaultValue(False)>
		<DisplayName("最大化按钮")>
		<O_Oo00Oo000O0(6.0)>
		Public Property MaximizeBox As Boolean
			Get
				Return Me.oO.o0o0000OO..MaximizeBox
			End Get
			Set(value As Boolean)
				Me.oO.o0o0000OO..MaximizeBox = value
			End Set
		End Property

		' Token: 0x17000EE4 RID: 3812
		' (get) Token: 0x0600431E RID: 17182 RVA: 0x001C1BA7 File Offset: 0x001BFDA7
		' (set) Token: 0x0600431F RID: 17183 RVA: 0x001C1BB4 File Offset: 0x001BFDB4
		<O_Oo00Oo000O0(7.0)>
		<MergableProperty(False)>
		<DefaultValue(False)>
		<DisplayName("最小化按钮")>
		<Category("杂项")>
		Public Property MinimizeBox As Boolean
			Get
				Return Me.oO.o0o0000OO..MinimizeBox
			End Get
			Set(value As Boolean)
				Me.oO.o0o0000OO..MinimizeBox = value
			End Set
		End Property

		' Token: 0x17000EE5 RID: 3813
		' (get) Token: 0x06004320 RID: 17184 RVA: 0x001C1BC2 File Offset: 0x001BFDC2
		' (set) Token: 0x06004321 RID: 17185 RVA: 0x001C1BCF File Offset: 0x001BFDCF
		<O_Oo00Oo000O0(8.0)>
		<DefaultValue(True)>
		<Category("杂项")>
		<MergableProperty(False)>
		<DisplayName("显示控制框")>
		Public Property ControlBox As Boolean
			Get
				Return Me.oO.o0o0000OO..ControlBox
			End Get
			Set(value As Boolean)
				Me.oO.o0o0000OO..ControlBox = value
			End Set
		End Property

		' Token: 0x17000EE6 RID: 3814
		' (get) Token: 0x06004322 RID: 17186 RVA: 0x001C1BDD File Offset: 0x001BFDDD
		' (set) Token: 0x06004323 RID: 17187 RVA: 0x001C1BE5 File Offset: 0x001BFDE5
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("启用")>
		<Category("计时器")>
		<MergableProperty(False)>
		<Description("是否启用计时器。")>
		<DefaultValue(False)>
		Public Property TimerEnabled As Boolean
			Get
				Return Me.O0_0.0.
			End Get
			Set(value As Boolean)
				Me.O0_0.0. = value
			End Set
		End Property

		' Token: 0x17000EE7 RID: 3815
		' (get) Token: 0x06004324 RID: 17188 RVA: 0x001C1BEE File Offset: 0x001BFDEE
		' (set) Token: 0x06004325 RID: 17189 RVA: 0x001C1BF6 File Offset: 0x001BFDF6
		<O_Oo00Oo000O0(1.0)>
		<Category("计时器")>
		<MergableProperty(False)>
		<Description("计时器代码执行间隔，单位为毫秒")>
		<DefaultValue(1000)>
		<DisplayName("间隔")>
		Public Property TimerInterval As Integer
			Get
				Return Me.O__._.
			End Get
			Set(value As Integer)
				Me.O__._. = value
			End Set
		End Property

		' Token: 0x17000EE8 RID: 3816
		' (get) Token: 0x06004326 RID: 17190 RVA: 0x001C1BFF File Offset: 0x001BFDFF
		' (set) Token: 0x06004327 RID: 17191 RVA: 0x001C1C07 File Offset: 0x001BFE07
		<Category("信息提示")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("显示图标")>
		<MergableProperty(False)>
		<Description("提示信息的图标")>
		Public Property ShowToolTipIcon As ToolTipIcon
			Get
				Return Me.o_00.OOO__o_OO.
			End Get
			Set(value As ToolTipIcon)
				Me.o_00.OOO__o_OO. = value
			End Set
		End Property

		' Token: 0x17000EE9 RID: 3817
		' (get) Token: 0x06004328 RID: 17192 RVA: 0x001C1C10 File Offset: 0x001BFE10
		' (set) Token: 0x06004329 RID: 17193 RVA: 0x001C1C18 File Offset: 0x001BFE18
		<DisplayName("提示标题")>
		<Category("信息提示")>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(False)>
		<Description("提示信息的标题")>
		<DefaultValue("提示")>
		Public Property TootlTipTitle As String
			Get
				Return Me.OOo0OO00O0.0.
			End Get
			Set(value As String)
				Me.OOo0OO00O0.0. = value
			End Set
		End Property

		' Token: 0x17000EEA RID: 3818
		' (get) Token: 0x0600432A RID: 17194 RVA: 0x001C1C21 File Offset: 0x001BFE21
		' (set) Token: 0x0600432B RID: 17195 RVA: 0x001C1C29 File Offset: 0x001BFE29
		<DefaultValue(False)>
		<O_Oo00Oo000O0(3.0)>
		<Category("信息提示")>
		<MergableProperty(False)>
		<Description("是否以气球样式显示提示信息")>
		<DisplayName("气球样式")>
		Public Property ToolTipBalloon As Boolean
			Get
				Return Me.o.o0o.
			End Get
			Set(value As Boolean)
				Me.o.o0o. = value
			End Set
		End Property

		' Token: 0x17000EEB RID: 3819
		' (get) Token: 0x0600432C RID: 17196 RVA: 0x001C1C32 File Offset: 0x001BFE32
		' (set) Token: 0x0600432D RID: 17197 RVA: 0x001C1C3A File Offset: 0x001BFE3A
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0711")>
		<Category("窗口事件")>
		<Description("加载窗口后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property AfterLoad As EventString
			Get
				Return Me.o0.oO00o0o.
			End Get
			Set(value As EventString)
				Me.o0.oO00o0o. = value
			End Set
		End Property

		' Token: 0x17000EEC RID: 3820
		' (get) Token: 0x0600432E RID: 17198 RVA: 0x001C1C43 File Offset: 0x001BFE43
		' (set) Token: 0x0600432F RID: 17199 RVA: 0x001C1C4B File Offset: 0x001BFE4B
		<oO0oooo("3314")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("窗口事件")>
		<Description("窗口显示后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.01)>
		Public Property AfterShow As EventString
			Get
				Return Me.o._OO_o00OO0.
			End Get
			Set(value As EventString)
				Me.o._OO_o00OO0. = value
			End Set
		End Property

		' Token: 0x17000EED RID: 3821
		' (get) Token: 0x06004330 RID: 17200 RVA: 0x001C1C54 File Offset: 0x001BFE54
		' (set) Token: 0x06004331 RID: 17201 RVA: 0x001C1C5C File Offset: 0x001BFE5C
		<oO0oooo("2114")>
		<Category("窗口事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("作为下拉窗口显示前执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.05)>
		Public Property DropDownOpening As EventString
			Get
				Return Me.ooOOOO_oO_.0OO.
			End Get
			Set(value As EventString)
				Me.ooOOOO_oO_.0OO. = value
			End Set
		End Property

		' Token: 0x17000EEE RID: 3822
		' (get) Token: 0x06004332 RID: 17202 RVA: 0x001C1C65 File Offset: 0x001BFE65
		' (set) Token: 0x06004333 RID: 17203 RVA: 0x001C1C6D File Offset: 0x001BFE6D
		<Description("作为下拉窗口显示后执行。")>
		<oO0oooo("2113")>
		<Category("窗口事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.1)>
		Public Property DropDownOpened As EventString
			Get
				Return Me.O0_.O0O.
			End Get
			Set(value As EventString)
				Me.O0_.O0O. = value
			End Set
		End Property

		' Token: 0x17000EEF RID: 3823
		' (get) Token: 0x06004334 RID: 17204 RVA: 0x001C1C76 File Offset: 0x001BFE76
		' (set) Token: 0x06004335 RID: 17205 RVA: 0x001C1C7E File Offset: 0x001BFE7E
		<oO0oooo("2461")>
		<Category("窗口事件")>
		<Description("作为下拉窗口关闭后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.11)>
		Public Property DropDownClosed As EventString
			Get
				Return Me.oOo._o.
			End Get
			Set(value As EventString)
				Me.oOo._o. = value
			End Set
		End Property

		' Token: 0x17000EF0 RID: 3824
		' (get) Token: 0x06004336 RID: 17206 RVA: 0x001C1C87 File Offset: 0x001BFE87
		' (set) Token: 0x06004337 RID: 17207 RVA: 0x001C1C8F File Offset: 0x001BFE8F
		<oO0oooo("1546")>
		<Category("窗口事件")>
		<Description("关闭窗口后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property AfterClose As EventString
			Get
				Return Me.O.OO00OoO0.
			End Get
			Set(value As EventString)
				Me.O.OO00OoO0. = value
			End Set
		End Property

		' Token: 0x17000EF1 RID: 3825
		' (get) Token: 0x06004338 RID: 17208 RVA: 0x001C1C98 File Offset: 0x001BFE98
		' (set) Token: 0x06004339 RID: 17209 RVA: 0x001C1CA0 File Offset: 0x001BFEA0
		<oO0oooo("0712")>
		<Category("窗口事件")>
		<Description("关闭窗口前执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property BeforeClose As EventString
			Get
				Return Me.o._o_o00_.
			End Get
			Set(value As EventString)
				Me.o._o_o00_. = value
			End Set
		End Property

		' Token: 0x17000EF2 RID: 3826
		' (get) Token: 0x0600433A RID: 17210 RVA: 0x001C1CA9 File Offset: 0x001BFEA9
		' (set) Token: 0x0600433B RID: 17211 RVA: 0x001C1CB1 File Offset: 0x001BFEB1
		<oO0oooo("2740")>
		<Category("窗口事件")>
		<Description("窗口大小发生变化后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property SizeChanged As EventString
			Get
				Return Me.Oo_o._Oo.
			End Get
			Set(value As EventString)
				Me.Oo_o._Oo. = value
			End Set
		End Property

		' Token: 0x17000EF3 RID: 3827
		' (get) Token: 0x0600433C RID: 17212 RVA: 0x001C1CBA File Offset: 0x001BFEBA
		' (set) Token: 0x0600433D RID: 17213 RVA: 0x001C1CC2 File Offset: 0x001BFEC2
		<oO0oooo("1322")>
		<Category("窗口事件")>
		<Description("计时器代码")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property TimerTick As EventString
			Get
				Return Me.oo___o.0.
			End Get
			Set(value As EventString)
				Me.oo___o.0. = value
			End Set
		End Property

		' Token: 0x17000EF4 RID: 3828
		' (get) Token: 0x0600433E RID: 17214 RVA: 0x001C1CCB File Offset: 0x001BFECB
		' (set) Token: 0x0600433F RID: 17215 RVA: 0x001C1CD3 File Offset: 0x001BFED3
		<oO0oooo("6020")>
		<Category("窗口事件")>
		<Description("自动调整控件大小事执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property ResizingControl As EventString
			Get
				Return Me.Oo.O__0.
			End Get
			Set(value As EventString)
				Me.Oo.O__0. = value
			End Set
		End Property

		' Token: 0x17000EF5 RID: 3829
		' (get) Token: 0x06004340 RID: 17216 RVA: 0x001C1CDC File Offset: 0x001BFEDC
		' (set) Token: 0x06004341 RID: 17217 RVA: 0x001C1CE4 File Offset: 0x001BFEE4
		<oO0oooo("6020")>
		<Category("窗口事件")>
		<Description("自动调整控件字体时执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property ResizingFont As EventString
			Get
				Return Me.OoO.o_0o0OO_O.
			End Get
			Set(value As EventString)
				Me.OoO.o_0o0OO_O. = value
			End Set
		End Property

		' Token: 0x17000EF6 RID: 3830
		' (get) Token: 0x06004342 RID: 17218 RVA: 0x001C1CED File Offset: 0x001BFEED
		' (set) Token: 0x06004343 RID: 17219 RVA: 0x001C1CF5 File Offset: 0x001BFEF5
		<oO0oooo("0732")>
		<Category("全局事件")>
		<Description("单击控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property Click As EventString
			Get
				Return Me.o_O.O.
			End Get
			Set(value As EventString)
				Me.o_O.O. = value
			End Set
		End Property

		' Token: 0x17000EF7 RID: 3831
		' (get) Token: 0x06004344 RID: 17220 RVA: 0x001C1CFE File Offset: 0x001BFEFE
		' (set) Token: 0x06004345 RID: 17221 RVA: 0x001C1D06 File Offset: 0x001BFF06
		<oO0oooo("0732")>
		<Category("全局事件")>
		<Description("用鼠标单击控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property MouseClick As EventString
			Get
				Return Me.o.0oo.
			End Get
			Set(value As EventString)
				Me.o.0oo. = value
			End Set
		End Property

		' Token: 0x17000EF8 RID: 3832
		' (get) Token: 0x06004346 RID: 17222 RVA: 0x001C1D0F File Offset: 0x001BFF0F
		' (set) Token: 0x06004347 RID: 17223 RVA: 0x001C1D17 File Offset: 0x001BFF17
		<oO0oooo("0733")>
		<Category("全局事件")>
		<Description("双击控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.1)>
		Public Property DoubleClick As EventString
			Get
				Return Me.o000.oo__.
			End Get
			Set(value As EventString)
				Me.o000.oo__. = value
			End Set
		End Property

		' Token: 0x17000EF9 RID: 3833
		' (get) Token: 0x06004348 RID: 17224 RVA: 0x001C1D20 File Offset: 0x001BFF20
		' (set) Token: 0x06004349 RID: 17225 RVA: 0x001C1D28 File Offset: 0x001BFF28
		<oO0oooo("0734")>
		<Category("全局事件")>
		<Description("选择控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property Enter As EventString
			Get
				Return Me.Ooo_____.0.
			End Get
			Set(value As EventString)
				Me.Ooo_____.0. = value
			End Set
		End Property

		' Token: 0x17000EFA RID: 3834
		' (get) Token: 0x0600434A RID: 17226 RVA: 0x001C1D31 File Offset: 0x001BFF31
		' (set) Token: 0x0600434B RID: 17227 RVA: 0x001C1D39 File Offset: 0x001BFF39
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0735")>
		<Category("全局事件")>
		<Description("离开控件后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property Leave As EventString
			Get
				Return Me.O0_o._0OO.
			End Get
			Set(value As EventString)
				Me.O0_o._0OO. = value
			End Set
		End Property

		' Token: 0x17000EFB RID: 3835
		' (get) Token: 0x0600434C RID: 17228 RVA: 0x001C1D42 File Offset: 0x001BFF42
		' (set) Token: 0x0600434D RID: 17229 RVA: 0x001C1D4A File Offset: 0x001BFF4A
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0736")>
		<Category("全局事件")>
		<Description("离开控件前执行，通常用来对输入内容进行校对。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property Validating As EventString
			Get
				Return Me.oo0._oO0oO0.
			End Get
			Set(value As EventString)
				Me.oo0._oO0oO0. = value
			End Set
		End Property

		' Token: 0x17000EFC RID: 3836
		' (get) Token: 0x0600434E RID: 17230 RVA: 0x001C1D53 File Offset: 0x001BFF53
		' (set) Token: 0x0600434F RID: 17231 RVA: 0x001C1D5B File Offset: 0x001BFF5B
		<oO0oooo("0769")>
		<Description("值改变后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.1)>
		Public Property ValueChanged As EventString
			Get
				Return Me.oOoo.ooo.
			End Get
			Set(value As EventString)
				Me.oOoo.ooo. = value
			End Set
		End Property

		' Token: 0x17000EFD RID: 3837
		' (get) Token: 0x06004350 RID: 17232 RVA: 0x001C1D64 File Offset: 0x001BFF64
		' (set) Token: 0x06004351 RID: 17233 RVA: 0x001C1D6C File Offset: 0x001BFF6C
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0768")>
		<Category("全局事件")>
		<Description("文本改变后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.2)>
		Public Property TextChanged As EventString
			Get
				Return Me.O_ooO0__0Oo._o.
			End Get
			Set(value As EventString)
				Me.O_ooO0__0Oo._o. = value
			End Set
		End Property

		' Token: 0x17000EFE RID: 3838
		' (get) Token: 0x06004352 RID: 17234 RVA: 0x001C1D75 File Offset: 0x001BFF75
		' (set) Token: 0x06004353 RID: 17235 RVA: 0x001C1D7D File Offset: 0x001BFF7D
		<oO0oooo("0781")>
		<Description("Checked(选中)属性发生变化后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.3)>
		Public Property CheckedChanged As EventString
			Get
				Return Me.O_.o0Oo0.
			End Get
			Set(value As EventString)
				Me.O_.o0Oo0. = value
			End Set
		End Property

		' Token: 0x17000EFF RID: 3839
		' (get) Token: 0x06004354 RID: 17236 RVA: 0x001C1D86 File Offset: 0x001BFF86
		' (set) Token: 0x06004355 RID: 17237 RVA: 0x001C1D8E File Offset: 0x001BFF8E
		<oO0oooo("0739")>
		<Category("全局事件")>
		<Description("输入字符时执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property KeyPress As EventString
			Get
				Return Me.o______0oO.Oo_.
			End Get
			Set(value As EventString)
				Me.o______0oO.Oo_. = value
			End Set
		End Property

		' Token: 0x17000F00 RID: 3840
		' (get) Token: 0x06004356 RID: 17238 RVA: 0x001C1D97 File Offset: 0x001BFF97
		' (set) Token: 0x06004357 RID: 17239 RVA: 0x001C1D9F File Offset: 0x001BFF9F
		<oO0oooo("0741")>
		<Category("全局事件")>
		<Description("压下按键时执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property KeyDown As EventString
			Get
				Return Me.o_o0OO_.oo.
			End Get
			Set(value As EventString)
				Me.o_o0OO_.oo. = value
			End Set
		End Property

		' Token: 0x17000F01 RID: 3841
		' (get) Token: 0x06004358 RID: 17240 RVA: 0x001C1DA8 File Offset: 0x001BFFA8
		' (set) Token: 0x06004359 RID: 17241 RVA: 0x001C1DB0 File Offset: 0x001BFFB0
		<Description("松开按键执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0741")>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(8.0)>
		Public Property KeyUp As EventString
			Get
				Return Me.o__O0O.O_0.
			End Get
			Set(value As EventString)
				Me.o__O0O.O_0. = value
			End Set
		End Property

		' Token: 0x17000F02 RID: 3842
		' (get) Token: 0x0600435A RID: 17242 RVA: 0x001C1DB9 File Offset: 0x001BFFB9
		' (set) Token: 0x0600435B RID: 17243 RVA: 0x001C1DC1 File Offset: 0x001BFFC1
		<Description("鼠标进入控件后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<oO0oooo("0743")>
		<O_Oo00Oo000O0(9.0)>
		Public Property MouseEnter As EventString
			Get
				Return Me.O.Oo0_0.
			End Get
			Set(value As EventString)
				Me.O.Oo0_0. = value
			End Set
		End Property

		' Token: 0x17000F03 RID: 3843
		' (get) Token: 0x0600435C RID: 17244 RVA: 0x001C1DCA File Offset: 0x001BFFCA
		' (set) Token: 0x0600435D RID: 17245 RVA: 0x001C1DD2 File Offset: 0x001BFFD2
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0744")>
		<Category("全局事件")>
		<Description("鼠标离开控件后执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(10.0)>
		Public Property MouseLeave As EventString
			Get
				Return Me.O_oOo0_oOo.O0.
			End Get
			Set(value As EventString)
				Me.O_oOo0_oOo.O0. = value
			End Set
		End Property

		' Token: 0x17000F04 RID: 3844
		' (get) Token: 0x0600435E RID: 17246 RVA: 0x001C1DDB File Offset: 0x001BFFDB
		' (set) Token: 0x0600435F RID: 17247 RVA: 0x001C1DE3 File Offset: 0x001BFFE3
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1320")>
		<Category("全局事件")>
		<Description("在控件上移动鼠标的时候执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(11.0)>
		Public Property MouseMove As EventString
			Get
				Return Me.o0o0o.o__.
			End Get
			Set(value As EventString)
				Me.o0o0o.o__. = value
			End Set
		End Property

		' Token: 0x17000F05 RID: 3845
		' (get) Token: 0x06004360 RID: 17248 RVA: 0x001C1DEC File Offset: 0x001BFFEC
		' (set) Token: 0x06004361 RID: 17249 RVA: 0x001C1DF4 File Offset: 0x001BFFF4
		<oO0oooo("0745")>
		<Category("全局事件")>
		<Description("鼠标停留在控件上的时候执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(12.0)>
		Public Property MouseHover As EventString
			Get
				Return Me.oo0__o.O.
			End Get
			Set(value As EventString)
				Me.oo0__o.O. = value
			End Set
		End Property

		' Token: 0x17000F06 RID: 3846
		' (get) Token: 0x06004362 RID: 17250 RVA: 0x001C1DFD File Offset: 0x001BFFFD
		' (set) Token: 0x06004363 RID: 17251 RVA: 0x001C1E05 File Offset: 0x001C0005
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("按下鼠标后执行")>
		<oO0oooo("0746")>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(13.0)>
		Public Property MouseDown As EventString
			Get
				Return Me.O0_O_O_.O__.
			End Get
			Set(value As EventString)
				Me.O0_O_O_.O__. = value
			End Set
		End Property

		' Token: 0x17000F07 RID: 3847
		' (get) Token: 0x06004364 RID: 17252 RVA: 0x001C1E0E File Offset: 0x001C000E
		' (set) Token: 0x06004365 RID: 17253 RVA: 0x001C1E16 File Offset: 0x001C0016
		<oO0oooo("0747")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("松开鼠标后执行")>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(14.0)>
		Public Property MouseUp As EventString
			Get
				Return Me.O_o.0o.
			End Get
			Set(value As EventString)
				Me.O_o.0o. = value
			End Set
		End Property

		' Token: 0x17000F08 RID: 3848
		' (get) Token: 0x06004366 RID: 17254 RVA: 0x001C1E1F File Offset: 0x001C001F
		' (set) Token: 0x06004367 RID: 17255 RVA: 0x001C1E2C File Offset: 0x001C002C
		<OooO0(True)>
		<Browsable(False)>
		Public Property Size As Size
			Get
				Return Me.oO.o0o0000OO..Size
			End Get
			Set(value As Size)
				Me.oO.o0o0000OO..Size = value
			End Set
		End Property

		' Token: 0x17000F09 RID: 3849
		' (get) Token: 0x06004368 RID: 17256 RVA: 0x001C1E3A File Offset: 0x001C003A
		' (set) Token: 0x06004369 RID: 17257 RVA: 0x001C1E42 File Offset: 0x001C0042
		<oO0oooo("3222")>
		<Description("单击菜单项目后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("菜单事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property ItemClick As EventString
			Get
				Return Me.oo0__00.o00_.
			End Get
			Set(value As EventString)
				Me.oo0__00.o00_. = value
			End Set
		End Property

		' Token: 0x17000F0A RID: 3850
		' (get) Token: 0x0600436A RID: 17258 RVA: 0x001C1E4B File Offset: 0x001C004B
		' (set) Token: 0x0600436B RID: 17259 RVA: 0x001C1E53 File Offset: 0x001C0053
		<oO0oooo("3222")>
		<Description("鼠标进入菜单项目后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("菜单事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property ItemMouseEnter As EventString
			Get
				Return Me.OO0o_0._0_O0_O.
			End Get
			Set(value As EventString)
				Me.OO0o_0._0_O0_O. = value
			End Set
		End Property

		' Token: 0x17000F0B RID: 3851
		' (get) Token: 0x0600436C RID: 17260 RVA: 0x001C1E5C File Offset: 0x001C005C
		' (set) Token: 0x0600436D RID: 17261 RVA: 0x001C1E64 File Offset: 0x001C0064
		<Description("鼠标离开菜单项目后执行")>
		<oO0oooo("3222")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("菜单事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property ItemMouseLeave As EventString
			Get
				Return Me.oo.oO0O0o0Oo.
			End Get
			Set(value As EventString)
				Me.oo.oO0O0o0Oo. = value
			End Set
		End Property

		' Token: 0x17000F0C RID: 3852
		' (get) Token: 0x0600436E RID: 17262 RVA: 0x001C1E6D File Offset: 0x001C006D
		' (set) Token: 0x0600436F RID: 17263 RVA: 0x001C1E75 File Offset: 0x001C0075
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("菜单事件")>
		<oO0oooo("3222")>
		<Description("鼠标停留在菜单项目上时执行")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property ItemMouseHover As EventString
			Get
				Return Me.ooO.O_00.
			End Get
			Set(value As EventString)
				Me.ooO.O_00. = value
			End Set
		End Property

		' Token: 0x04001B57 RID: 6999
		Private <<EMPTY_NAME>> As o\u3002\u3002\u3000\u3000\u3002

		' Token: 0x04001B58 RID: 7000
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B59 RID: 7001
		Private <<EMPTY_NAME>> As ToolTipIcon

		' Token: 0x04001B5A RID: 7002
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B5B RID: 7003
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B5C RID: 7004
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B5D RID: 7005
		Private <<EMPTY_NAME>> As FormStyleEnum

		' Token: 0x04001B5E RID: 7006
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B5F RID: 7007
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B60 RID: 7008
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B61 RID: 7009
		Private <<EMPTY_NAME>> As FormStartPosition

		' Token: 0x04001B62 RID: 7010
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B63 RID: 7011
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B64 RID: 7012
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B65 RID: 7013
		Private <<EMPTY_NAME>> As DockAreaEnum

		' Token: 0x04001B66 RID: 7014
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B67 RID: 7015
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B68 RID: 7016
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B69 RID: 7017
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B6A RID: 7018
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B6B RID: 7019
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B6C RID: 7020
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B6D RID: 7021
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B6E RID: 7022
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B6F RID: 7023
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B70 RID: 7024
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B71 RID: 7025
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001B72 RID: 7026
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B73 RID: 7027
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B74 RID: 7028
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B75 RID: 7029
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B76 RID: 7030
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B77 RID: 7031
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B78 RID: 7032
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B79 RID: 7033
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7A RID: 7034
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7B RID: 7035
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7C RID: 7036
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7D RID: 7037
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7E RID: 7038
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B7F RID: 7039
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B80 RID: 7040
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B81 RID: 7041
		Private <<EMPTY_NAME>> As PrintPageProperty

		' Token: 0x04001B82 RID: 7042
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B83 RID: 7043
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B84 RID: 7044
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B85 RID: 7045
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B86 RID: 7046
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B87 RID: 7047
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B88 RID: 7048
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B89 RID: 7049
		Private <<EMPTY_NAME>> As TabAlignment

		' Token: 0x04001B8A RID: 7050
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B8B RID: 7051
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B8C RID: 7052
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B8D RID: 7053
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B8E RID: 7054
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B8F RID: 7055
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B90 RID: 7056
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B91 RID: 7057
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B92 RID: 7058
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B93 RID: 7059
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
