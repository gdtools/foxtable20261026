Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable
	' Token: 0x020003F5 RID: 1013
	Friend Class BarCodeProperty
		Inherits ControlPropertyBase

		' Token: 0x17000DBA RID: 3514
		' (get) Token: 0x060040BE RID: 16574 RVA: 0x001BF52C File Offset: 0x001BD72C
		' (set) Token: 0x060040BF RID: 16575 RVA: 0x001BF534 File Offset: 0x001BD734
		Private Overridable Property Bar As OOo00o_0o0_

		' Token: 0x060040C0 RID: 16576 RVA: 0x001BF53D File Offset: 0x001BD73D
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.Bar = CType(A_0.ChildControl, OOo00o_0o0_)
		End Sub

		' Token: 0x17000DBB RID: 3515
		' (get) Token: 0x060040C1 RID: 16577 RVA: 0x001BF557 File Offset: 0x001BD757
		' (set) Token: 0x060040C2 RID: 16578 RVA: 0x001BF55F File Offset: 0x001BD75F
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("条码内容")>
		<Category("数据绑定")>
		<DefaultValue("")>
		<MergableProperty(True)>
		Public Property BindingField As String
			Get
				Return Me.O.0o_0_o.
			End Get
			Set(value As String)
				Me.O.0o_0_o. = value
			End Set
		End Property

		' Token: 0x17000DBC RID: 3516
		' (get) Token: 0x060040C3 RID: 16579 RVA: 0x001BF568 File Offset: 0x001BD768
		' (set) Token: 0x060040C4 RID: 16580 RVA: 0x001BF570 File Offset: 0x001BD770
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		<DisplayName("替换文本")>
		<Category("数据绑定")>
		Public Property BindingHumanReadableText As String
			Get
				Return Me.Oo_O._oOoo.
			End Get
			Set(value As String)
				Me.Oo_O._oOoo. = value
			End Set
		End Property

		' Token: 0x17000DBD RID: 3517
		' (get) Token: 0x060040C5 RID: 16581 RVA: 0x001BF579 File Offset: 0x001BD779
		' (set) Token: 0x060040C6 RID: 16582 RVA: 0x001BF581 File Offset: 0x001BD781
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		<DefaultValue("")>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("说明文本")>
		<Category("数据绑定")>
		Public Property BindingText As String
			Get
				Return Me.O___.O.
			End Get
			Set(value As String)
				Me.O___.O. = value
			End Set
		End Property

		' Token: 0x17000DBE RID: 3518
		' (get) Token: 0x060040C7 RID: 16583 RVA: 0x001BF58A File Offset: 0x001BD78A
		' (set) Token: 0x060040C8 RID: 16584 RVA: 0x001BF597 File Offset: 0x001BD797
		<Browsable(False)>
		Public Property Symbology As Symbology
			Get
				Return Me.Bar.Symbology
			End Get
			Set(value As Symbology)
				Me.Bar.Symbology = value
			End Set
		End Property

		' Token: 0x17000DBF RID: 3519
		' (get) Token: 0x060040C9 RID: 16585 RVA: 0x001BF5A5 File Offset: 0x001BD7A5
		' (set) Token: 0x060040CA RID: 16586 RVA: 0x001BF5C6 File Offset: 0x001BD7C6
		<MergableProperty(True)>
		<TypeConverter(GetType(OoOO___oo))>
		<DisplayName("条码类型")>
		<Category("条码设置")>
		<OooO0(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property CodeType As String
			Get
				Return [Enum].GetName(GetType(Symbology), Me.Bar.Symbology)
			End Get
			Set(value As String)
				Me.Bar.Symbology = Conversions.ToInteger([Enum].Parse(GetType(Symbology), value))
			End Set
		End Property

		' Token: 0x17000DC0 RID: 3520
		' (get) Token: 0x060040CB RID: 16587 RVA: 0x001BF5E8 File Offset: 0x001BD7E8
		' (set) Token: 0x060040CC RID: 16588 RVA: 0x001BF5F5 File Offset: 0x001BD7F5
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置")>
		<DisplayName("条码内容")>
		<MergableProperty(True)>
		Public Overridable Property Code As String
			Get
				Return Me.Bar.Code
			End Get
			Set(value As String)
				Me.Bar.Code = value
			End Set
		End Property

		' Token: 0x17000DC1 RID: 3521
		' (get) Token: 0x060040CD RID: 16589 RVA: 0x001BF603 File Offset: 0x001BD803
		' (set) Token: 0x060040CE RID: 16590 RVA: 0x001BF610 File Offset: 0x001BD810
		<MergableProperty(True)>
		<DisplayName("窄条宽度")>
		<DefaultValue(0.2642)>
		<O_Oo00Oo000O0(3.0)>
		<Category("条码设置")>
		Public Property BarWidth As Double
			Get
				Return Me.Bar.BarWidth
			End Get
			Set(value As Double)
				Me.Bar.BarWidth = value
			End Set
		End Property

		' Token: 0x17000DC2 RID: 3522
		' (get) Token: 0x060040CF RID: 16591 RVA: 0x001BF61E File Offset: 0x001BD81E
		' (set) Token: 0x060040D0 RID: 16592 RVA: 0x001BF62B File Offset: 0x001BD82B
		<DefaultValue(2.0)>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("宽窄比例")>
		<Category("条码设置")>
		<MergableProperty(True)>
		Public Property BarRatio As Double
			Get
				Return Me.Bar.BarRatio
			End Get
			Set(value As Double)
				Me.Bar.BarRatio = value
			End Set
		End Property

		' Token: 0x17000DC3 RID: 3523
		' (get) Token: 0x060040D1 RID: 16593 RVA: 0x001BF639 File Offset: 0x001BD839
		' (set) Token: 0x060040D2 RID: 16594 RVA: 0x001BF646 File Offset: 0x001BD846
		<DisplayName("条码高度")>
		<Category("条码设置")>
		<MergableProperty(True)>
		<DefaultValue(5.08)>
		<O_Oo00Oo000O0(5.0)>
		Public Property BarHeight As Double
			Get
				Return Me.Bar.BarHeight
			End Get
			Set(value As Double)
				Me.Bar.BarHeight = value
			End Set
		End Property

		' Token: 0x17000DC4 RID: 3524
		' (get) Token: 0x060040D3 RID: 16595 RVA: 0x001BF654 File Offset: 0x001BD854
		' (set) Token: 0x060040D4 RID: 16596 RVA: 0x001BF661 File Offset: 0x001BD861
		<Category("条码设置")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<DisplayName("静区宽度")>
		<O_Oo00Oo000O0(5.1)>
		Public Property QuietZoneWidth As Double
			Get
				Return Me.Bar.QuietZoneWidth
			End Get
			Set(value As Double)
				Me.Bar.QuietZoneWidth = value
			End Set
		End Property

		' Token: 0x17000DC5 RID: 3525
		' (get) Token: 0x060040D5 RID: 16597 RVA: 0x001BF66F File Offset: 0x001BD86F
		' (set) Token: 0x060040D6 RID: 16598 RVA: 0x001BF67C File Offset: 0x001BD87C
		<O_Oo00Oo000O0(6.0)>
		<MergableProperty(True)>
		<DisplayName("旋转角度")>
		<DefaultValue(0)>
		<Category("条码设置")>
		Public Property Rotate As Rotate
			Get
				Return Me.Bar.Rotate
			End Get
			Set(value As Rotate)
				Me.Bar.Rotate = value
			End Set
		End Property

		' Token: 0x17000DC6 RID: 3526
		' (get) Token: 0x060040D7 RID: 16599 RVA: 0x001BF68A File Offset: 0x001BD88A
		' (set) Token: 0x060040D8 RID: 16600 RVA: 0x001BF697 File Offset: 0x001BD897
		<DefaultValue(True)>
		<DisplayName("增加校验")>
		<Category("条码设置")>
		<O_Oo00Oo000O0(7.0)>
		<MergableProperty(True)>
		Public Property AddCheckSum As Boolean
			Get
				Return Me.Bar.AddChecksum
			End Get
			Set(value As Boolean)
				Me.Bar.AddChecksum = value
			End Set
		End Property

		' Token: 0x17000DC7 RID: 3527
		' (get) Token: 0x060040D9 RID: 16601 RVA: 0x001BF6A5 File Offset: 0x001BD8A5
		' (set) Token: 0x060040DA RID: 16602 RVA: 0x001BF6B2 File Offset: 0x001BD8B2
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("保护框")>
		<DefaultValue(0)>
		<Category("条码设置")>
		<MergableProperty(True)>
		Public Property BearBarStyle As BearerBarStyle
			Get
				Return Me.Bar.BearerBarStyle
			End Get
			Set(value As BearerBarStyle)
				Me.Bar.BearerBarStyle = value
			End Set
		End Property

		' Token: 0x17000DC8 RID: 3528
		' (get) Token: 0x060040DB RID: 16603 RVA: 0x001BF6C0 File Offset: 0x001BD8C0
		' (set) Token: 0x060040DC RID: 16604 RVA: 0x001BF6CD File Offset: 0x001BD8CD
		<MergableProperty(True)>
		<O_Oo00Oo000O0(9.0)>
		<DefaultValue(1.27)>
		<DisplayName("保护框宽度")>
		<Category("条码设置")>
		Public Property BearerBarWidth As Double
			Get
				Return Me.Bar.BearerBarWidth
			End Get
			Set(value As Double)
				Me.Bar.BearerBarWidth = value
			End Set
		End Property

		' Token: 0x17000DC9 RID: 3529
		' (get) Token: 0x060040DD RID: 16605 RVA: 0x001BF6DB File Offset: 0x001BD8DB
		' (set) Token: 0x060040DE RID: 16606 RVA: 0x001BF6E8 File Offset: 0x001BD8E8
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<DisplayName("显示文本")>
		<DefaultValue(True)>
		<Category("条码设置 - 文本")>
		Public Property DisplayCode As Boolean
			Get
				Return Me.Bar.DisplayCode
			End Get
			Set(value As Boolean)
				Me.Bar.DisplayCode = value
			End Set
		End Property

		' Token: 0x17000DCA RID: 3530
		' (get) Token: 0x060040DF RID: 16607 RVA: 0x001BF6F6 File Offset: 0x001BD8F6
		' (set) Token: 0x060040E0 RID: 16608 RVA: 0x001BF703 File Offset: 0x001BD903
		<DefaultValue(True)>
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		<Category("条码设置 - 文本")>
		<DisplayName("显示校验符")>
		Public Property DisplayChecksum As Boolean
			Get
				Return Me.Bar.DisplayChecksum
			End Get
			Set(value As Boolean)
				Me.Bar.DisplayChecksum = value
			End Set
		End Property

		' Token: 0x17000DCB RID: 3531
		' (get) Token: 0x060040E1 RID: 16609 RVA: 0x001BF711 File Offset: 0x001BD911
		' (set) Token: 0x060040E2 RID: 16610 RVA: 0x001BF71E File Offset: 0x001BD91E
		<MergableProperty(True)>
		<DefaultValue(True)>
		<Category("条码设置 - 文本")>
		<DisplayName("显示起止符")>
		<O_Oo00Oo000O0(3.0)>
		Public Property DisplayStartStopChar As Boolean
			Get
				Return Me.Bar.DisplayStartStopChar
			End Get
			Set(value As Boolean)
				Me.Bar.DisplayStartStopChar = value
			End Set
		End Property

		' Token: 0x17000DCC RID: 3532
		' (get) Token: 0x060040E3 RID: 16611 RVA: 0x001BF72C File Offset: 0x001BD92C
		' (set) Token: 0x060040E4 RID: 16612 RVA: 0x001BF739 File Offset: 0x001BD939
		<Category("条码设置 - 文本")>
		<DisplayName("替换文本")>
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue("")>
		<MergableProperty(True)>
		Public Overridable Property HumanReadableText As String
			Get
				Return Me.Bar.HumanReadableText
			End Get
			Set(value As String)
				Me.Bar.HumanReadableText = value
			End Set
		End Property

		' Token: 0x17000DCD RID: 3533
		' (get) Token: 0x060040E5 RID: 16613 RVA: 0x001BF747 File Offset: 0x001BD947
		' (set) Token: 0x060040E6 RID: 16614 RVA: 0x001BF754 File Offset: 0x001BD954
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DefaultValue(4)>
		<DisplayName("文本位置")>
		<O_Oo00Oo000O0(5.0)>
		Public Property CodeAlignment As Alignment
			Get
				Return Me.Bar.CodeAlignment
			End Get
			Set(value As Alignment)
				Me.Bar.CodeAlignment = value
			End Set
		End Property

		' Token: 0x17000DCE RID: 3534
		' (get) Token: 0x060040E7 RID: 16615 RVA: 0x001BF762 File Offset: 0x001BD962
		' (set) Token: 0x060040E8 RID: 16616 RVA: 0x001BF76F File Offset: 0x001BD96F
		<O_Oo00Oo000O0(6.0)>
		<MergableProperty(True)>
		<DisplayName("说明文本")>
		<DefaultValue("")>
		<Category("条码设置 - 文本")>
		Public Overridable Property Text As String
			Get
				Return Me.Bar.Text
			End Get
			Set(value As String)
				Me.Bar.Text = value
			End Set
		End Property

		' Token: 0x17000DCF RID: 3535
		' (get) Token: 0x060040E9 RID: 16617 RVA: 0x001BF77D File Offset: 0x001BD97D
		' (set) Token: 0x060040EA RID: 16618 RVA: 0x001BF78A File Offset: 0x001BD98A
		<O_Oo00Oo000O0(7.0)>
		<Category("条码设置 - 文本")>
		<DisplayName("说明位置")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property TextAlignment As Alignment
			Get
				Return Me.Bar.TextAlignment
			End Get
			Set(value As Alignment)
				Me.Bar.TextAlignment = value
			End Set
		End Property

		' Token: 0x17000DD0 RID: 3536
		' (get) Token: 0x060040EB RID: 16619 RVA: 0x001BF798 File Offset: 0x001BD998
		' (set) Token: 0x060040EC RID: 16620 RVA: 0x001BF7A5 File Offset: 0x001BD9A5
		<MergableProperty(True)>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("上文本间距")>
		<DefaultValue(0)>
		<Category("条码设置 - 文本")>
		Public Property TopMargin As Double
			Get
				Return Me.Bar.TopMargin
			End Get
			Set(value As Double)
				Me.Bar.TopMargin = value
			End Set
		End Property

		' Token: 0x17000DD1 RID: 3537
		' (get) Token: 0x060040ED RID: 16621 RVA: 0x001BF7B3 File Offset: 0x001BD9B3
		' (set) Token: 0x060040EE RID: 16622 RVA: 0x001BF7C0 File Offset: 0x001BD9C0
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DisplayName("下文本间距")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(9.0)>
		Public Property BottomMargin As Double
			Get
				Return Me.Bar.BottomMargin
			End Get
			Set(value As Double)
				Me.Bar.BottomMargin = value
			End Set
		End Property

		' Token: 0x17000DD2 RID: 3538
		' (get) Token: 0x060040EF RID: 16623 RVA: 0x001BF7CE File Offset: 0x001BD9CE
		' (set) Token: 0x060040F0 RID: 16624 RVA: 0x001BF7DB File Offset: 0x001BD9DB
		<DisplayName("文本字体")>
		<O_Oo00Oo000O0(10.0)>
		<DefaultValue("宋体,9")>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		Public Overrides Property Font As Font
			Get
				Return Me.Bar.Font
			End Get
			Set(value As Font)
				Me.Bar.Font = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x17000DD3 RID: 3539
		' (get) Token: 0x060040F1 RID: 16625 RVA: 0x001BF7F3 File Offset: 0x001BD9F3
		' (set) Token: 0x060040F2 RID: 16626 RVA: 0x001BF800 File Offset: 0x001BDA00
		<O_Oo00Oo000O0(11.0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DisplayName("文本颜色")>
		<DefaultValue(-16777216)>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.Bar.ForeColor
			End Get
			Set(value As Color)
				Me.Bar.ForeColor = value
			End Set
		End Property

		' Token: 0x17000DD4 RID: 3540
		' (get) Token: 0x060040F3 RID: 16627 RVA: 0x001BF80E File Offset: 0x001BDA0E
		' (set) Token: 0x060040F4 RID: 16628 RVA: 0x001BF81B File Offset: 0x001BDA1B
		<DefaultValue("宋体,9")>
		<O_Oo00Oo000O0(12.0)>
		<MergableProperty(True)>
		<DisplayName("说明字体")>
		<Category("条码设置 - 文本")>
		Public Property TextFont As Font
			Get
				Return Me.Bar.TextFont
			End Get
			Set(value As Font)
				Me.Bar.TextFont = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x17000DD5 RID: 3541
		' (get) Token: 0x060040F5 RID: 16629 RVA: 0x001BF833 File Offset: 0x001BDA33
		' (set) Token: 0x060040F6 RID: 16630 RVA: 0x001BF840 File Offset: 0x001BDA40
		<MergableProperty(True)>
		<DefaultValue(-16777216)>
		<O_Oo00Oo000O0(13.0)>
		<Category("条码设置 - 文本")>
		<DisplayName("说明颜色")>
		Public Property TextForeColor As Color
			Get
				Return Me.Bar.TextForeColor
			End Get
			Set(value As Color)
				Me.Bar.TextForeColor = value
			End Set
		End Property

		' Token: 0x17000DD6 RID: 3542
		' (get) Token: 0x060040F7 RID: 16631 RVA: 0x001BF84E File Offset: 0x001BDA4E
		' (set) Token: 0x060040F8 RID: 16632 RVA: 0x001BF85B File Offset: 0x001BDA5B
		<MergableProperty(True)>
		<DisplayName("编码格式")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(0)>
		<Category("条码设置 - AztecCode")>
		Public Property AztecCodeFormat As AztecCodeFormat
			Get
				Return Me.Bar.AztecCodeFormat
			End Get
			Set(value As AztecCodeFormat)
				Me.Bar.AztecCodeFormat = value
			End Set
		End Property

		' Token: 0x17000DD7 RID: 3543
		' (get) Token: 0x060040F9 RID: 16633 RVA: 0x001BF869 File Offset: 0x001BDA69
		' (set) Token: 0x060040FA RID: 16634 RVA: 0x001BF876 File Offset: 0x001BDA76
		<Category("条码设置 - AztecCode")>
		<MergableProperty(True)>
		<DefaultValue(1.0592)>
		<DisplayName("模组尺寸")>
		<O_Oo00Oo000O0(2.0)>
		Public Property AztecCodeModuleSize As Double
			Get
				Return Me.Bar.AztecCodeModuleSize
			End Get
			Set(value As Double)
				Me.Bar.AztecCodeModuleSize = value
			End Set
		End Property

		' Token: 0x17000DD8 RID: 3544
		' (get) Token: 0x060040FB RID: 16635 RVA: 0x001BF884 File Offset: 0x001BDA84
		' (set) Token: 0x060040FC RID: 16636 RVA: 0x001BF891 File Offset: 0x001BDA91
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<DisplayName("容错比例")>
		<DefaultValue(23)>
		<Category("条码设置 - AztecCode")>
		Public Property AztecCodeErrorCorrection As Integer
			Get
				Return Me.Bar.AztecCodeErrorCorrection
			End Get
			Set(value As Integer)
				Me.Bar.AztecCodeErrorCorrection = value
			End Set
		End Property

		' Token: 0x17000DD9 RID: 3545
		' (get) Token: 0x060040FD RID: 16637 RVA: 0x001BF89F File Offset: 0x001BDA9F
		' (set) Token: 0x060040FE RID: 16638 RVA: 0x001BF8AC File Offset: 0x001BDAAC
		<DefaultValue(-1)>
		<Category("条码设置 - AztecCode")>
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		Public Property AztecCodeRune As Integer
			Get
				Return Me.Bar.AztecCodeRune
			End Get
			Set(value As Integer)
				Me.Bar.AztecCodeRune = value
			End Set
		End Property

		' Token: 0x17000DDA RID: 3546
		' (get) Token: 0x060040FF RID: 16639 RVA: 0x001BF8BA File Offset: 0x001BDABA
		' (set) Token: 0x06004100 RID: 16640 RVA: 0x001BF8C7 File Offset: 0x001BDAC7
		<Category("条码设置 - Codabar")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("起始字符")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		Public Property CodabarStartChar As CodabarStartStopChar
			Get
				Return Me.Bar.CodabarStartChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.Bar.CodabarStartChar = value
			End Set
		End Property

		' Token: 0x17000DDB RID: 3547
		' (get) Token: 0x06004101 RID: 16641 RVA: 0x001BF8D5 File Offset: 0x001BDAD5
		' (set) Token: 0x06004102 RID: 16642 RVA: 0x001BF8E2 File Offset: 0x001BDAE2
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(0)>
		<Category("条码设置 - Codabar")>
		<MergableProperty(True)>
		<DisplayName("结束字符")>
		Public Property CodabarStopChar As CodabarStartStopChar
			Get
				Return Me.Bar.CodabarStopChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.Bar.CodabarStopChar = value
			End Set
		End Property

		' Token: 0x17000DDC RID: 3548
		' (get) Token: 0x06004103 RID: 16643 RVA: 0x001BF8F0 File Offset: 0x001BDAF0
		' (set) Token: 0x06004104 RID: 16644 RVA: 0x001BF8FD File Offset: 0x001BDAFD
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("字符集")>
		<DefaultValue(0)>
		<Category("条码设置 - Code128")>
		Public Property Code128CharSet As Code128
			Get
				Return Me.Bar.Code128CharSet
			End Get
			Set(value As Code128)
				Me.Bar.Code128CharSet = value
			End Set
		End Property

		' Token: 0x17000DDD RID: 3549
		' (get) Token: 0x06004105 RID: 16645 RVA: 0x001BF90B File Offset: 0x001BDB0B
		' (set) Token: 0x06004106 RID: 16646 RVA: 0x001BF918 File Offset: 0x001BDB18
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(0)>
		<Category("条码设置 - Code16K")>
		<MergableProperty(True)>
		<DisplayName("编码模式")>
		Public Property Code16kMode As Code16k
			Get
				Return Me.Bar.Code16kMode
			End Get
			Set(value As Code16k)
				Me.Bar.Code16kMode = value
			End Set
		End Property

		' Token: 0x17000DDE RID: 3550
		' (get) Token: 0x06004107 RID: 16647 RVA: 0x001BF926 File Offset: 0x001BDB26
		' (set) Token: 0x06004108 RID: 16648 RVA: 0x001BF933 File Offset: 0x001BDB33
		<DisplayName("编码方式")>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - DataMatrix")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property DataMatrixEncoding As DataMatrixEncoding
			Get
				Return Me.Bar.DataMatrixEncoding
			End Get
			Set(value As DataMatrixEncoding)
				Me.Bar.DataMatrixEncoding = value
			End Set
		End Property

		' Token: 0x17000DDF RID: 3551
		' (get) Token: 0x06004109 RID: 16649 RVA: 0x001BF941 File Offset: 0x001BDB41
		' (set) Token: 0x0600410A RID: 16650 RVA: 0x001BF94E File Offset: 0x001BDB4E
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置 - DataMatrix")>
		<DisplayName("编码格式")>
		Public Property DataMatrixFormat As DataMatrixFormat
			Get
				Return Me.Bar.DataMatrixFormat
			End Get
			Set(value As DataMatrixFormat)
				Me.Bar.DataMatrixFormat = value
			End Set
		End Property

		' Token: 0x17000DE0 RID: 3552
		' (get) Token: 0x0600410B RID: 16651 RVA: 0x001BF95C File Offset: 0x001BDB5C
		' (set) Token: 0x0600410C RID: 16652 RVA: 0x001BF969 File Offset: 0x001BDB69
		<Category("条码设置 - DataMatrix")>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("模组尺寸")>
		<DefaultValue(1.0592)>
		<MergableProperty(True)>
		Public Property DataMatrixModuleSize As Double
			Get
				Return Me.Bar.DataMatrixModuleSize
			End Get
			Set(value As Double)
				Me.Bar.DataMatrixModuleSize = value
			End Set
		End Property

		' Token: 0x17000DE1 RID: 3553
		' (get) Token: 0x0600410D RID: 16653 RVA: 0x001BF977 File Offset: 0x001BDB77
		' (set) Token: 0x0600410E RID: 16654 RVA: 0x001BF984 File Offset: 0x001BDB84
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DisplayName("处理波形符")>
		<DefaultValue(False)>
		<Category("条码设置 - DataMatrix")>
		Public Property DataMatrixProcessTilde As Boolean
			Get
				Return Me.Bar.DataMatrixProcessTilde
			End Get
			Set(value As Boolean)
				Me.Bar.DataMatrixProcessTilde = value
			End Set
		End Property

		' Token: 0x17000DE2 RID: 3554
		' (get) Token: 0x0600410F RID: 16655 RVA: 0x001BF992 File Offset: 0x001BDB92
		' (set) Token: 0x06004110 RID: 16656 RVA: 0x001BF99F File Offset: 0x001BDB9F
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("附加码数")>
		<Category("条码设置 - Ean And Upc")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		Public Property EanUpcSupplement As Supplement
			Get
				Return Me.Bar.EanUpcSupplement
			End Get
			Set(value As Supplement)
				Me.Bar.EanUpcSupplement = value
			End Set
		End Property

		' Token: 0x17000DE3 RID: 3555
		' (get) Token: 0x06004111 RID: 16657 RVA: 0x001BF9AD File Offset: 0x001BDBAD
		' (set) Token: 0x06004112 RID: 16658 RVA: 0x001BF9BA File Offset: 0x001BDBBA
		<MergableProperty(True)>
		<Category("条码设置 - Ean And Upc")>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue("0")>
		<DisplayName("附加码值")>
		Public Property EanUpcSupplementCode As String
			Get
				Return Me.Bar.EanUpcSupplementCode
			End Get
			Set(value As String)
				Me.Bar.EanUpcSupplementCode = value
			End Set
		End Property

		' Token: 0x17000DE4 RID: 3556
		' (get) Token: 0x06004113 RID: 16659 RVA: 0x001BF9C8 File Offset: 0x001BDBC8
		' (set) Token: 0x06004114 RID: 16660 RVA: 0x001BF9D5 File Offset: 0x001BDBD5
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<DisplayName("附加码左距")>
		<DefaultValue(3.81)>
		<Category("条码设置 - Ean And Upc")>
		Public Property EanUpcSupplementSeparation As Double
			Get
				Return Me.Bar.EanUpcSupplementSeparation
			End Get
			Set(value As Double)
				Me.Bar.EanUpcSupplementSeparation = value
			End Set
		End Property

		' Token: 0x17000DE5 RID: 3557
		' (get) Token: 0x06004115 RID: 16661 RVA: 0x001BF9E3 File Offset: 0x001BDBE3
		' (set) Token: 0x06004116 RID: 16662 RVA: 0x001BF9F0 File Offset: 0x001BDBF0
		<DisplayName("附加码上距")>
		<MergableProperty(True)>
		<Category("条码设置 - Ean And Upc")>
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(3.81)>
		Public Property EanUpcSupplementTopMargin As Double
			Get
				Return Me.Bar.EanUpcSupplementTopMargin
			End Get
			Set(value As Double)
				Me.Bar.EanUpcSupplementTopMargin = value
			End Set
		End Property

		' Token: 0x17000DE6 RID: 3558
		' (get) Token: 0x06004117 RID: 16663 RVA: 0x001BF9FE File Offset: 0x001BDBFE
		' (set) Token: 0x06004118 RID: 16664 RVA: 0x001BFA0B File Offset: 0x001BDC0B
		<DisplayName("显示防护条")>
		<Category("条码设置 - Ean And Upc")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property GuardBar As Boolean
			Get
				Return Me.Bar.GuardBar
			End Get
			Set(value As Boolean)
				Me.Bar.GuardBar = value
			End Set
		End Property

		' Token: 0x17000DE7 RID: 3559
		' (get) Token: 0x06004119 RID: 16665 RVA: 0x001BFA19 File Offset: 0x001BDC19
		' (set) Token: 0x0600411A RID: 16666 RVA: 0x001BFA26 File Offset: 0x001BDC26
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(6.35)>
		<Category("条码设置 - Ean And Upc")>
		<MergableProperty(True)>
		<DisplayName("防护条高度")>
		Public Property GuardBarHeight As Double
			Get
				Return Me.Bar.GuardBarHeight
			End Get
			Set(value As Double)
				Me.Bar.GuardBarHeight = value
			End Set
		End Property

		' Token: 0x17000DE8 RID: 3560
		' (get) Token: 0x0600411B RID: 16667 RVA: 0x001BFA34 File Offset: 0x001BDC34
		' (set) Token: 0x0600411C RID: 16668 RVA: 0x001BFA41 File Offset: 0x001BDC41
		<DefaultValue(0)>
		<O_Oo00Oo000O0(7.0)>
		<MergableProperty(True)>
		<Category("条码设置 - Ean And Upc")>
		<DisplayName("编码方式")>
		Public Property UpcESystem As UpcE
			Get
				Return Me.Bar.UpcESystem
			End Get
			Set(value As UpcE)
				Me.Bar.UpcESystem = value
			End Set
		End Property

		' Token: 0x17000DE9 RID: 3561
		' (get) Token: 0x0600411D RID: 16669 RVA: 0x001BFA4F File Offset: 0x001BDC4F
		' (set) Token: 0x0600411E RID: 16670 RVA: 0x001BFA5C File Offset: 0x001BDC5C
		<Category("条码设置 - ExpandedStacked")>
		<MergableProperty(True)>
		<DefaultValue(4)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("每行段数")>
		Public Property SegmentsPerRow As Integer
			Get
				Return Me.Bar.SegmentsPerRow
			End Get
			Set(value As Integer)
				Me.Bar.SegmentsPerRow = value
			End Set
		End Property

		' Token: 0x17000DEA RID: 3562
		' (get) Token: 0x0600411F RID: 16671 RVA: 0x001BFA6A File Offset: 0x001BDC6A
		' (set) Token: 0x06004120 RID: 16672 RVA: 0x001BFA77 File Offset: 0x001BDC77
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("格式化替换文本")>
		<DefaultValue(True)>
		<Category("条码设置 - HIBC")>
		Public Property HibcFormatHumanReadableText As Boolean
			Get
				Return Me.Bar.HibcFormatHumanReadableText
			End Get
			Set(value As Boolean)
				Me.Bar.HibcFormatHumanReadableText = value
			End Set
		End Property

		' Token: 0x17000DEB RID: 3563
		' (get) Token: 0x06004121 RID: 16673 RVA: 0x001BFA85 File Offset: 0x001BDC85
		' (set) Token: 0x06004122 RID: 16674 RVA: 0x001BFA92 File Offset: 0x001BDC92
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(0)>
		<Category("条码设置 - ISBT")>
		<MergableProperty(True)>
		<DisplayName("数据结构")>
		Public Property Isbt128DataStructure As Isbt128DataStructure
			Get
				Return Me.Bar.Isbt128DataStructure
			End Get
			Set(value As Isbt128DataStructure)
				Me.Bar.Isbt128DataStructure = value
			End Set
		End Property

		' Token: 0x17000DEC RID: 3564
		' (get) Token: 0x06004123 RID: 16675 RVA: 0x001BFAA0 File Offset: 0x001BDCA0
		' (set) Token: 0x06004124 RID: 16676 RVA: 0x001BFAAD File Offset: 0x001BDCAD
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - MaxiCode")>
		<MergableProperty(True)>
		<DisplayName("编码模式")>
		<DefaultValue(4)>
		Public Property MaxiCodeMode As MaxiCodeModes
			Get
				Return Me.Bar.MaxiCodeMode
			End Get
			Set(value As MaxiCodeModes)
				Me.Bar.MaxiCodeMode = value
			End Set
		End Property

		' Token: 0x17000DED RID: 3565
		' (get) Token: 0x06004125 RID: 16677 RVA: 0x001BFABB File Offset: 0x001BDCBB
		' (set) Token: 0x06004126 RID: 16678 RVA: 0x001BFAC8 File Offset: 0x001BDCC8
		<DefaultValue(1)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("模式字符数量")>
		<Category("条码设置 - MaxiCode")>
		<MergableProperty(True)>
		Public Property MaxiCodeSymbolCount As Integer
			Get
				Return Me.Bar.MaxiCodeSymbolCount
			End Get
			Set(value As Integer)
				Me.Bar.MaxiCodeSymbolCount = value
			End Set
		End Property

		' Token: 0x17000DEE RID: 3566
		' (get) Token: 0x06004127 RID: 16679 RVA: 0x001BFAD6 File Offset: 0x001BDCD6
		' (set) Token: 0x06004128 RID: 16680 RVA: 0x001BFAE3 File Offset: 0x001BDCE3
		<DisplayName("模式字符位置")>
		<DefaultValue(1)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<Category("条码设置 - MaxiCode")>
		Public Property MaxiCodeSymbolIndex As Integer
			Get
				Return Me.Bar.MaxiCodeSymbolIndex
			End Get
			Set(value As Integer)
				Me.Bar.MaxiCodeSymbolIndex = value
			End Set
		End Property

		' Token: 0x17000DEF RID: 3567
		' (get) Token: 0x06004129 RID: 16681 RVA: 0x001BFAF1 File Offset: 0x001BDCF1
		' (set) Token: 0x0600412A RID: 16682 RVA: 0x001BFAFE File Offset: 0x001BDCFE
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(False)>
		<Category("条码设置 - MaxiCode")>
		<MergableProperty(True)>
		<DisplayName("处理波浪符")>
		Public Property MaxiCodeProcessTilde As Boolean
			Get
				Return Me.Bar.MaxiCodeProcessTilde
			End Get
			Set(value As Boolean)
				Me.Bar.MaxiCodeProcessTilde = value
			End Set
		End Property

		' Token: 0x17000DF0 RID: 3568
		' (get) Token: 0x0600412B RID: 16683 RVA: 0x001BFB0C File Offset: 0x001BDD0C
		' (set) Token: 0x0600412C RID: 16684 RVA: 0x001BFB19 File Offset: 0x001BDD19
		<Category("条码设置 - MSI")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("校验模式")>
		<DefaultValue(0)>
		Public Property MsiChecksum As MsiChecksum
			Get
				Return Me.Bar.MsiChecksum
			End Get
			Set(value As MsiChecksum)
				Me.Bar.MsiChecksum = value
			End Set
		End Property

		' Token: 0x17000DF1 RID: 3569
		' (get) Token: 0x0600412D RID: 16685 RVA: 0x001BFB27 File Offset: 0x001BDD27
		' (set) Token: 0x0600412E RID: 16686 RVA: 0x001BFB34 File Offset: 0x001BDD34
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<DisplayName("编码类型")>
		<DefaultValue(0)>
		<Category("条码设置 - PDF417")>
		Public Property Pdf417CompactionType As Pdf417CompactionType
			Get
				Return Me.Bar.Pdf417CompactionType
			End Get
			Set(value As Pdf417CompactionType)
				Me.Bar.Pdf417CompactionType = value
			End Set
		End Property

		' Token: 0x17000DF2 RID: 3570
		' (get) Token: 0x0600412F RID: 16687 RVA: 0x001BFB42 File Offset: 0x001BDD42
		' (set) Token: 0x06004130 RID: 16688 RVA: 0x001BFB4F File Offset: 0x001BDD4F
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(0)>
		<Category("条码设置 - PDF417")>
		<DisplayName("编码版号")>
		Public Property MicroPdf417Version As MicroPdf417Version
			Get
				Return Me.Bar.MicroPdf417Version
			End Get
			Set(value As MicroPdf417Version)
				Me.Bar.MicroPdf417Version = value
			End Set
		End Property

		' Token: 0x17000DF3 RID: 3571
		' (get) Token: 0x06004131 RID: 16689 RVA: 0x001BFB5D File Offset: 0x001BDD5D
		' (set) Token: 0x06004132 RID: 16690 RVA: 0x001BFB6A File Offset: 0x001BDD6A
		<DisplayName("容错级别")>
		<O_Oo00Oo000O0(2.1)>
		<DefaultValue(2)>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		Public Property Pdf417ErrorCorrectionLevel As Pdf417ErrorCorrection
			Get
				Return Me.Bar.Pdf417ErrorCorrectionLevel
			End Get
			Set(value As Pdf417ErrorCorrection)
				Me.Bar.Pdf417ErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x17000DF4 RID: 3572
		' (get) Token: 0x06004133 RID: 16691 RVA: 0x001BFB78 File Offset: 0x001BDD78
		' (set) Token: 0x06004134 RID: 16692 RVA: 0x001BFB85 File Offset: 0x001BDD85
		<DefaultValue(0)>
		<O_Oo00Oo000O0(3.0)>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		<DisplayName("高度比例")>
		Public Property Pdf417AspectRatio As Double
			Get
				Return Me.Bar.Pdf417AspectRatio
			End Get
			Set(value As Double)
				Me.Bar.Pdf417AspectRatio = value
			End Set
		End Property

		' Token: 0x17000DF5 RID: 3573
		' (get) Token: 0x06004135 RID: 16693 RVA: 0x001BFB93 File Offset: 0x001BDD93
		' (set) Token: 0x06004136 RID: 16694 RVA: 0x001BFBA0 File Offset: 0x001BDDA0
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(4.0)>
		<Category("条码设置 - PDF417")>
		<DisplayName("列数")>
		Public Property Pdf417Columns As Integer
			Get
				Return Me.Bar.Pdf417Columns
			End Get
			Set(value As Integer)
				Me.Bar.Pdf417Columns = value
			End Set
		End Property

		' Token: 0x17000DF6 RID: 3574
		' (get) Token: 0x06004137 RID: 16695 RVA: 0x001BFBAE File Offset: 0x001BDDAE
		' (set) Token: 0x06004138 RID: 16696 RVA: 0x001BFBBB File Offset: 0x001BDDBB
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("行数")>
		<DefaultValue(0)>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		Public Property Pdf417Rows As Integer
			Get
				Return Me.Bar.Pdf417Rows
			End Get
			Set(value As Integer)
				Me.Bar.Pdf417Rows = value
			End Set
		End Property

		' Token: 0x17000DF7 RID: 3575
		' (get) Token: 0x06004139 RID: 16697 RVA: 0x001BFBC9 File Offset: 0x001BDDC9
		' (set) Token: 0x0600413A RID: 16698 RVA: 0x001BFBD6 File Offset: 0x001BDDD6
		<O_Oo00Oo000O0(6.0)>
		<MergableProperty(True)>
		<DisplayName("右侧截断")>
		<DefaultValue(False)>
		<Category("条码设置 - PDF417")>
		Public Property Pdf417Truncated As Boolean
			Get
				Return Me.Bar.Pdf417Truncated
			End Get
			Set(value As Boolean)
				Me.Bar.Pdf417Truncated = value
			End Set
		End Property

		' Token: 0x17000DF8 RID: 3576
		' (get) Token: 0x0600413B RID: 16699 RVA: 0x001BFBE4 File Offset: 0x001BDDE4
		' (set) Token: 0x0600413C RID: 16700 RVA: 0x001BFBF1 File Offset: 0x001BDDF1
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("文件ID")>
		<DefaultValue("000")>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		Public Property Pdf417FileId As String
			Get
				Return Me.Bar.Pdf417FileId
			End Get
			Set(value As String)
				Me.Bar.Pdf417FileId = value
			End Set
		End Property

		' Token: 0x17000DF9 RID: 3577
		' (get) Token: 0x0600413D RID: 16701 RVA: 0x001BFBFF File Offset: 0x001BDDFF
		' (set) Token: 0x0600413E RID: 16702 RVA: 0x001BFC0C File Offset: 0x001BDE0C
		<DefaultValue(0)>
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("分段总数")>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		Public Property Pdf417SegmentCount As Integer
			Get
				Return Me.Bar.Pdf417SegmentCount
			End Get
			Set(value As Integer)
				Me.Bar.Pdf417SegmentCount = value
			End Set
		End Property

		' Token: 0x17000DFA RID: 3578
		' (get) Token: 0x0600413F RID: 16703 RVA: 0x001BFC1A File Offset: 0x001BDE1A
		' (set) Token: 0x06004140 RID: 16704 RVA: 0x001BFC27 File Offset: 0x001BDE27
		<DefaultValue(0)>
		<MergableProperty(True)>
		<Category("条码设置 - PDF417")>
		<DisplayName("分段位置")>
		<O_Oo00Oo000O0(9.0)>
		Public Property Pdf417SegmentIndex As Integer
			Get
				Return Me.Bar.Pdf417SegmentIndex
			End Get
			Set(value As Integer)
				Me.Bar.Pdf417SegmentIndex = value
			End Set
		End Property

		' Token: 0x17000DFB RID: 3579
		' (get) Token: 0x06004141 RID: 16705 RVA: 0x001BFC35 File Offset: 0x001BDE35
		' (set) Token: 0x06004142 RID: 16706 RVA: 0x001BFC42 File Offset: 0x001BDE42
		<DisplayName("条间距")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(1.0592)>
		<Category("条码设置 - Pharmacode")>
		Public Property PharmacodeBarsSpacing As Double
			Get
				Return Me.Bar.PharmacodeBarsSpacing
			End Get
			Set(value As Double)
				Me.Bar.PharmacodeBarsSpacing = value
			End Set
		End Property

		' Token: 0x17000DFC RID: 3580
		' (get) Token: 0x06004143 RID: 16707 RVA: 0x001BFC50 File Offset: 0x001BDE50
		' (set) Token: 0x06004144 RID: 16708 RVA: 0x001BFC5D File Offset: 0x001BDE5D
		<DisplayName("宽条尺寸")>
		<Category("条码设置 - Pharmacode")>
		<DefaultValue(1.5875)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property PharmacodeThickBarWidth As Double
			Get
				Return Me.Bar.PharmacodeThickBarWidth
			End Get
			Set(value As Double)
				Me.Bar.PharmacodeThickBarWidth = value
			End Set
		End Property

		' Token: 0x17000DFD RID: 3581
		' (get) Token: 0x06004145 RID: 16709 RVA: 0x001BFC6B File Offset: 0x001BDE6B
		' (set) Token: 0x06004146 RID: 16710 RVA: 0x001BFC78 File Offset: 0x001BDE78
		<DefaultValue(0.5283)>
		<DisplayName("窄条尺寸")>
		<O_Oo00Oo000O0(3.0)>
		<Category("条码设置 - Pharmacode")>
		<MergableProperty(True)>
		Public Property PharmacodeThinBarWidth As Double
			Get
				Return Me.Bar.PharmacodeThinBarWidth
			End Get
			Set(value As Double)
				Me.Bar.PharmacodeThinBarWidth = value
			End Set
		End Property

		' Token: 0x17000DFE RID: 3582
		' (get) Token: 0x06004147 RID: 16711 RVA: 0x001BFC86 File Offset: 0x001BDE86
		' (set) Token: 0x06004148 RID: 16712 RVA: 0x001BFC93 File Offset: 0x001BDE93
		<DisplayName("短条高度")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(5.0)>
		<Category("条码设置 - Planet")>
		<MergableProperty(True)>
		Public Property PlanetHeightShortBar As Double
			Get
				Return Me.Bar.PlanetHeightShortBar
			End Get
			Set(value As Double)
				Me.Bar.PlanetHeightShortBar = value
			End Set
		End Property

		' Token: 0x17000DFF RID: 3583
		' (get) Token: 0x06004149 RID: 16713 RVA: 0x001BFCA1 File Offset: 0x001BDEA1
		' (set) Token: 0x0600414A RID: 16714 RVA: 0x001BFCAE File Offset: 0x001BDEAE
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(10.0)>
		<Category("条码设置 - Planet")>
		<MergableProperty(True)>
		<DisplayName("长条高度")>
		Public Property PlanetHeightTallBar As Double
			Get
				Return Me.Bar.PlanetHeightTallBar
			End Get
			Set(value As Double)
				Me.Bar.PlanetHeightTallBar = value
			End Set
		End Property

		' Token: 0x17000E00 RID: 3584
		' (get) Token: 0x0600414B RID: 16715 RVA: 0x001BFCBC File Offset: 0x001BDEBC
		' (set) Token: 0x0600414C RID: 16716 RVA: 0x001BFCC9 File Offset: 0x001BDEC9
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - Postal 4-State")>
		<DisplayName("起止标记")>
		<DefaultValue(True)>
		Public Property Postal4StateAddStartStopChar As Boolean
			Get
				Return Me.Bar.Postal4StateAddStartStopChar
			End Get
			Set(value As Boolean)
				Me.Bar.Postal4StateAddStartStopChar = value
			End Set
		End Property

		' Token: 0x17000E01 RID: 3585
		' (get) Token: 0x0600414D RID: 16717 RVA: 0x001BFCD7 File Offset: 0x001BDED7
		' (set) Token: 0x0600414E RID: 16718 RVA: 0x001BFCE4 File Offset: 0x001BDEE4
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("条间距")>
		<DefaultValue(0.795)>
		<Category("条码设置 - Postal 4-State")>
		<MergableProperty(True)>
		Public Property Postal4StateBarsSpacing As Double
			Get
				Return Me.Bar.Postal4StateBarsSpacing
			End Get
			Set(value As Double)
				Me.Bar.Postal4StateBarsSpacing = value
			End Set
		End Property

		' Token: 0x17000E02 RID: 3586
		' (get) Token: 0x0600414F RID: 16719 RVA: 0x001BFCF2 File Offset: 0x001BDEF2
		' (set) Token: 0x06004150 RID: 16720 RVA: 0x001BFCFF File Offset: 0x001BDEFF
		<DisplayName("条高度")>
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(2.032)>
		<Category("条码设置 - Postal 4-State")>
		<MergableProperty(True)>
		Public Property Postal4StateTrackerBarHeight As Double
			Get
				Return Me.Bar.Postal4StateTrackerBarHeight
			End Get
			Set(value As Double)
				Me.Bar.Postal4StateTrackerBarHeight = value
			End Set
		End Property

		' Token: 0x17000E03 RID: 3587
		' (get) Token: 0x06004151 RID: 16721 RVA: 0x001BFD0D File Offset: 0x001BDF0D
		' (set) Token: 0x06004152 RID: 16722 RVA: 0x001BFD1A File Offset: 0x001BDF1A
		<DefaultValue(0.5283)>
		<DisplayName("条宽度")>
		<O_Oo00Oo000O0(4.0)>
		<Category("条码设置 - Postal 4-State")>
		<MergableProperty(True)>
		Public Property Postal4StateTrackerBarWidth As Double
			Get
				Return Me.Bar.Postal4StateTrackerBarWidth
			End Get
			Set(value As Double)
				Me.Bar.Postal4StateTrackerBarWidth = value
			End Set
		End Property

		' Token: 0x17000E04 RID: 3588
		' (get) Token: 0x06004153 RID: 16723 RVA: 0x001BFD28 File Offset: 0x001BDF28
		' (set) Token: 0x06004154 RID: 16724 RVA: 0x001BFD35 File Offset: 0x001BDF35
		<Category("条码设置 - Postnet")>
		<MergableProperty(True)>
		<DefaultValue(5.0)>
		<DisplayName("短条高度")>
		<O_Oo00Oo000O0(1.0)>
		Public Property PostnetHeightShortBar As Double
			Get
				Return Me.Bar.PostnetHeightShortBar
			End Get
			Set(value As Double)
				Me.Bar.PostnetHeightShortBar = value
			End Set
		End Property

		' Token: 0x17000E05 RID: 3589
		' (get) Token: 0x06004155 RID: 16725 RVA: 0x001BFD43 File Offset: 0x001BDF43
		' (set) Token: 0x06004156 RID: 16726 RVA: 0x001BFD50 File Offset: 0x001BDF50
		<O_Oo00Oo000O0(2.0)>
		<MergableProperty(True)>
		<DisplayName("长条高度")>
		<DefaultValue(10.0)>
		<Category("条码设置 - Postnet")>
		Public Property PostnetHeightTallBar As Double
			Get
				Return Me.Bar.PostnetHeightTallBar
			End Get
			Set(value As Double)
				Me.Bar.PostnetHeightTallBar = value
			End Set
		End Property

		' Token: 0x17000E06 RID: 3590
		' (get) Token: 0x06004157 RID: 16727 RVA: 0x001BFD5E File Offset: 0x001BDF5E
		' (set) Token: 0x06004158 RID: 16728 RVA: 0x001BFD6B File Offset: 0x001BDF6B
		<Category("条码设置 - QR Code")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("编码版号")>
		<MergableProperty(True)>
		Public Property MicroQRCodeVersion As MicroQRCodeVersion
			Get
				Return Me.Bar.MicroQRCodeVersion
			End Get
			Set(value As MicroQRCodeVersion)
				Me.Bar.MicroQRCodeVersion = value
			End Set
		End Property

		' Token: 0x17000E07 RID: 3591
		' (get) Token: 0x06004159 RID: 16729 RVA: 0x001BFD79 File Offset: 0x001BDF79
		' (set) Token: 0x0600415A RID: 16730 RVA: 0x001BFD86 File Offset: 0x001BDF86
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("编码方式")>
		<Category("条码设置 - QR Code")>
		<MergableProperty(True)>
		Public Property QRCodeEncoding As QRCodeEncoding
			Get
				Return Me.Bar.QRCodeEncoding
			End Get
			Set(value As QRCodeEncoding)
				Me.Bar.QRCodeEncoding = value
			End Set
		End Property

		' Token: 0x17000E08 RID: 3592
		' (get) Token: 0x0600415B RID: 16731 RVA: 0x001BFD94 File Offset: 0x001BDF94
		' (set) Token: 0x0600415C RID: 16732 RVA: 0x001BFDA1 File Offset: 0x001BDFA1
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(0)>
		<Category("条码设置 - QR Code")>
		<MergableProperty(True)>
		<DisplayName("编码版号")>
		Public Property QRCodeVersion As QRCodeVersion
			Get
				Return Me.Bar.QRCodeVersion
			End Get
			Set(value As QRCodeVersion)
				Me.Bar.QRCodeVersion = value
			End Set
		End Property

		' Token: 0x17000E09 RID: 3593
		' (get) Token: 0x0600415D RID: 16733 RVA: 0x001BFDAF File Offset: 0x001BDFAF
		' (set) Token: 0x0600415E RID: 16734 RVA: 0x001BFDBC File Offset: 0x001BDFBC
		<DefaultValue(1)>
		<O_Oo00Oo000O0(4.0)>
		<Category("条码设置 - QR Code")>
		<MergableProperty(True)>
		<DisplayName("容错级别")>
		Public Property QRCodeErrorCorrectionLevel As QRCodeErrorCorrectionLevel
			Get
				Return Me.Bar.QRCodeErrorCorrectionLevel
			End Get
			Set(value As QRCodeErrorCorrectionLevel)
				Me.Bar.QRCodeErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x17000E0A RID: 3594
		' (get) Token: 0x0600415F RID: 16735 RVA: 0x001BFDCA File Offset: 0x001BDFCA
		' (set) Token: 0x06004160 RID: 16736 RVA: 0x001BFDD7 File Offset: 0x001BDFD7
		<Category("条码设置 - QR Code")>
		<DisplayName("字符编码")>
		<O_Oo00Oo000O0(5.0)>
		<TypeConverter(GetType(o___o_O__))>
		<MergableProperty(True)>
		<DefaultValue("gb2312")>
		Public Property QRCodeByteEncodingName As String
			Get
				Return Me.Bar.QRCodeByteEncodingName
			End Get
			Set(value As String)
				Me.Bar.QRCodeByteEncodingName = value
			End Set
		End Property

		' Token: 0x17000E0B RID: 3595
		' (get) Token: 0x06004161 RID: 16737 RVA: 0x001BFDE5 File Offset: 0x001BDFE5
		' (set) Token: 0x06004162 RID: 16738 RVA: 0x001BFDF2 File Offset: 0x001BDFF2
		<MergableProperty(True)>
		<DisplayName("模组尺寸")>
		<DefaultValue(1.0592)>
		<O_Oo00Oo000O0(7.0)>
		<Category("条码设置 - QR Code")>
		Public Property QRCodeModuleSize As Double
			Get
				Return Me.Bar.QRCodeModuleSize
			End Get
			Set(value As Double)
				Me.Bar.QRCodeModuleSize = value
			End Set
		End Property

		' Token: 0x17000E0C RID: 3596
		' (get) Token: 0x06004163 RID: 16739 RVA: 0x001BFE00 File Offset: 0x001BE000
		' (set) Token: 0x06004164 RID: 16740 RVA: 0x001BFE0D File Offset: 0x001BE00D
		<Category("条码设置 - Telepen")>
		<DisplayName("编码方式")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.0)>
		Public Property TelepenEncoding As TelepenEncoding
			Get
				Return Me.Bar.TelepenEncoding
			End Get
			Set(value As TelepenEncoding)
				Me.Bar.TelepenEncoding = value
			End Set
		End Property

		' Token: 0x17000E0D RID: 3597
		' (get) Token: 0x06004165 RID: 16741 RVA: 0x001BFE1B File Offset: 0x001BE01B
		' (set) Token: 0x06004166 RID: 16742 RVA: 0x001BFE28 File Offset: 0x001BE028
		<DefaultValue(0)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - USPS FIM")>
		<DisplayName("编码方式")>
		Public Property UspsFimPattern As FIM
			Get
				Return Me.Bar.UspsFimPattern
			End Get
			Set(value As FIM)
				Me.Bar.UspsFimPattern = value
			End Set
		End Property

		' Token: 0x17000E0E RID: 3598
		' (get) Token: 0x06004167 RID: 16743 RVA: 0x001BFE36 File Offset: 0x001BE036
		' (set) Token: 0x06004168 RID: 16744 RVA: 0x001BFE43 File Offset: 0x001BE043
		<Category("条码设置 - USPS Horizontal Bars")>
		<DefaultValue(10)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property UspsHorizontalBarsCount As Integer
			Get
				Return Me.Bar.UspsHorizontalBarsCount
			End Get
			Set(value As Integer)
				Me.Bar.UspsHorizontalBarsCount = value
			End Set
		End Property

		' Token: 0x04001ADF RID: 6879
		<AccessedThroughProperty("Bar")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OOo00o_0o0_

		' Token: 0x04001AE0 RID: 6880
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AE1 RID: 6881
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001AE2 RID: 6882
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
