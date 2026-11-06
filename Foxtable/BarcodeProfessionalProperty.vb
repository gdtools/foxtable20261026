Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Microsoft.VisualBasic.CompilerServices
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable
	' Token: 0x0200003A RID: 58
	Friend Class BarcodeProfessionalProperty
		' Token: 0x060001E9 RID: 489 RVA: 0x00005272 File Offset: 0x00003472
		Public Sub New(A_0 As BarcodeProfessional)
			Me.O.0o_0_o. = A_0
		End Sub

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x060001EA RID: 490 RVA: 0x00005281 File Offset: 0x00003481
		' (set) Token: 0x060001EB RID: 491 RVA: 0x0000528E File Offset: 0x0000348E
		<Browsable(False)>
		Public Property Symbology As Symbology
			Get
				Return Me.O.0o_0_o..Symbology
			End Get
			Set(value As Symbology)
				Me.O.0o_0_o..Symbology = value
			End Set
		End Property

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x060001EC RID: 492 RVA: 0x0000529C File Offset: 0x0000349C
		' (set) Token: 0x060001ED RID: 493 RVA: 0x000052BD File Offset: 0x000034BD
		<MergableProperty(True)>
		<DisplayName("条码类型")>
		<O_Oo00Oo000O0(1.0)>
		<TypeConverter(GetType(OoOO___oo))>
		<Category("条码设置")>
		<OooO0(True)>
		Public Property CodeType As String
			Get
				Return [Enum].GetName(GetType(Symbology), Me.O.0o_0_o..Symbology)
			End Get
			Set(value As String)
				Me.O.0o_0_o..Symbology = Conversions.ToInteger([Enum].Parse(GetType(Symbology), value))
			End Set
		End Property

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x060001EE RID: 494 RVA: 0x000052DF File Offset: 0x000034DF
		' (set) Token: 0x060001EF RID: 495 RVA: 0x000052EC File Offset: 0x000034EC
		<Browsable(False)>
		<MergableProperty(True)>
		<DisplayName("条码内容")>
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置")>
		Public Overridable Property Code As String
			Get
				Return Me.O.0o_0_o..Code
			End Get
			Set(value As String)
				Me.O.0o_0_o..Code = value
			End Set
		End Property

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x000052FA File Offset: 0x000034FA
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x00005307 File Offset: 0x00003507
		<Category("条码设置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("窄条宽度")>
		<DefaultValue(0.2642)>
		Public Property BarWidth As Double
			Get
				Return Me.O.0o_0_o..BarWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..BarWidth = value
			End Set
		End Property

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x00005315 File Offset: 0x00003515
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x00005322 File Offset: 0x00003522
		<Category("条码设置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("宽窄比例")>
		<DefaultValue(2.0)>
		Public Property BarRatio As Double
			Get
				Return Me.O.0o_0_o..BarRatio
			End Get
			Set(value As Double)
				Me.O.0o_0_o..BarRatio = value
			End Set
		End Property

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x00005330 File Offset: 0x00003530
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x0000533D File Offset: 0x0000353D
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		<DefaultValue(5.08)>
		<Category("条码设置")>
		<DisplayName("条码高度")>
		Public Property BarHeight As Double
			Get
				Return Me.O.0o_0_o..BarHeight
			End Get
			Set(value As Double)
				Me.O.0o_0_o..BarHeight = value
				Me.O.0o_0_o..GuardBarHeight = value * 1.25
			End Set
		End Property

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x00005361 File Offset: 0x00003561
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x0000536E File Offset: 0x0000356E
		<MergableProperty(True)>
		<Category("条码设置")>
		<O_Oo00Oo000O0(5.1)>
		<DefaultValue(0)>
		<DisplayName("静区宽度")>
		Public Property QuietZoneWidth As Double
			Get
				Return Me.O.0o_0_o..QuietZoneWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..QuietZoneWidth = value
			End Set
		End Property

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x0000537C File Offset: 0x0000357C
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x00005389 File Offset: 0x00003589
		<DisplayName("旋转角度")>
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(0)>
		<Category("条码设置")>
		<MergableProperty(True)>
		Public Property Rotate As Rotate
			Get
				Return Me.O.0o_0_o..Rotate
			End Get
			Set(value As Rotate)
				Me.O.0o_0_o..Rotate = value
			End Set
		End Property

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x060001FA RID: 506 RVA: 0x00005397 File Offset: 0x00003597
		' (set) Token: 0x060001FB RID: 507 RVA: 0x000053A4 File Offset: 0x000035A4
		<DisplayName("增加校验")>
		<Category("条码设置")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property AddCheckSum As Boolean
			Get
				Return Me.O.0o_0_o..AddChecksum
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..AddChecksum = value
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x060001FC RID: 508 RVA: 0x000053B2 File Offset: 0x000035B2
		' (set) Token: 0x060001FD RID: 509 RVA: 0x000053BF File Offset: 0x000035BF
		<O_Oo00Oo000O0(8.0)>
		<DisplayName("保护框")>
		<DefaultValue(0)>
		<Category("条码设置")>
		<MergableProperty(True)>
		Public Property BearBarStyle As BearerBarStyle
			Get
				Return Me.O.0o_0_o..BearerBarStyle
			End Get
			Set(value As BearerBarStyle)
				Me.O.0o_0_o..BearerBarStyle = value
			End Set
		End Property

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x060001FE RID: 510 RVA: 0x000053CD File Offset: 0x000035CD
		' (set) Token: 0x060001FF RID: 511 RVA: 0x000053DA File Offset: 0x000035DA
		<DisplayName("保护框宽度")>
		<MergableProperty(True)>
		<DefaultValue(1.27)>
		<Category("条码设置")>
		<O_Oo00Oo000O0(9.0)>
		Public Property BearerBarWidth As Double
			Get
				Return Me.O.0o_0_o..BearerBarWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..BearerBarWidth = value
			End Set
		End Property

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000200 RID: 512 RVA: 0x000053E8 File Offset: 0x000035E8
		' (set) Token: 0x06000201 RID: 513 RVA: 0x000053F5 File Offset: 0x000035F5
		<DefaultValue(True)>
		<MergableProperty(True)>
		<Category("条码设置 - 文本")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("显示文本")>
		Public Property DisplayCode As Boolean
			Get
				Return Me.O.0o_0_o..DisplayCode
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..DisplayCode = value
			End Set
		End Property

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000202 RID: 514 RVA: 0x00005403 File Offset: 0x00003603
		' (set) Token: 0x06000203 RID: 515 RVA: 0x00005410 File Offset: 0x00003610
		<DisplayName("显示校验符")>
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DefaultValue(True)>
		Public Property DisplayChecksum As Boolean
			Get
				Return Me.O.0o_0_o..DisplayChecksum
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..DisplayChecksum = value
			End Set
		End Property

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000204 RID: 516 RVA: 0x0000541E File Offset: 0x0000361E
		' (set) Token: 0x06000205 RID: 517 RVA: 0x0000542B File Offset: 0x0000362B
		<O_Oo00Oo000O0(3.0)>
		<Category("条码设置 - 文本")>
		<DefaultValue(True)>
		<DisplayName("显示起止符")>
		<MergableProperty(True)>
		Public Property DisplayStartStopChar As Boolean
			Get
				Return Me.O.0o_0_o..DisplayStartStopChar
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..DisplayStartStopChar = value
			End Set
		End Property

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000206 RID: 518 RVA: 0x00005439 File Offset: 0x00003639
		' (set) Token: 0x06000207 RID: 519 RVA: 0x00005446 File Offset: 0x00003646
		<DisplayName("替换文本")>
		<O_Oo00Oo000O0(4.0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DefaultValue("")>
		Public Overridable Property HumanReadableText As String
			Get
				Return Me.O.0o_0_o..HumanReadableText
			End Get
			Set(value As String)
				Me.O.0o_0_o..HumanReadableText = value
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000208 RID: 520 RVA: 0x00005454 File Offset: 0x00003654
		' (set) Token: 0x06000209 RID: 521 RVA: 0x00005461 File Offset: 0x00003661
		<O_Oo00Oo000O0(5.0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DefaultValue(4)>
		<DisplayName("文本位置")>
		Public Property CodeAlignment As Alignment
			Get
				Return Me.O.0o_0_o..CodeAlignment
			End Get
			Set(value As Alignment)
				Me.O.0o_0_o..CodeAlignment = value
			End Set
		End Property

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600020A RID: 522 RVA: 0x0000546F File Offset: 0x0000366F
		' (set) Token: 0x0600020B RID: 523 RVA: 0x0000547C File Offset: 0x0000367C
		<MergableProperty(True)>
		<DefaultValue("")>
		<O_Oo00Oo000O0(6.0)>
		<Category("条码设置 - 文本")>
		<DisplayName("说明文本")>
		Public Overridable Property Text As String
			Get
				Return Me.O.0o_0_o..Text
			End Get
			Set(value As String)
				Me.O.0o_0_o..Text = value
			End Set
		End Property

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x0600020C RID: 524 RVA: 0x0000548A File Offset: 0x0000368A
		' (set) Token: 0x0600020D RID: 525 RVA: 0x00005497 File Offset: 0x00003697
		<DefaultValue(0)>
		<O_Oo00Oo000O0(7.0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DisplayName("说明位置")>
		Public Property TextAlignment As Alignment
			Get
				Return Me.O.0o_0_o..TextAlignment
			End Get
			Set(value As Alignment)
				Me.O.0o_0_o..TextAlignment = value
			End Set
		End Property

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x0600020E RID: 526 RVA: 0x000054A5 File Offset: 0x000036A5
		' (set) Token: 0x0600020F RID: 527 RVA: 0x000054B2 File Offset: 0x000036B2
		<DefaultValue(0)>
		<O_Oo00Oo000O0(8.0)>
		<MergableProperty(True)>
		<DisplayName("上文本间距")>
		<Category("条码设置 - 文本")>
		Public Property TopMargin As Double
			Get
				Return Me.O.0o_0_o..TopMargin
			End Get
			Set(value As Double)
				Me.O.0o_0_o..TopMargin = value
			End Set
		End Property

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000210 RID: 528 RVA: 0x000054C0 File Offset: 0x000036C0
		' (set) Token: 0x06000211 RID: 529 RVA: 0x000054CD File Offset: 0x000036CD
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("下文本间距")>
		<DefaultValue(0)>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		Public Property BottomMargin As Double
			Get
				Return Me.O.0o_0_o..BottomMargin
			End Get
			Set(value As Double)
				Me.O.0o_0_o..BottomMargin = value
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000212 RID: 530 RVA: 0x000054DB File Offset: 0x000036DB
		' (set) Token: 0x06000213 RID: 531 RVA: 0x000054E8 File Offset: 0x000036E8
		<O_Oo00Oo000O0(10.0)>
		<DefaultValue("宋体,9")>
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DisplayName("文本字体")>
		Public Property Font As Font
			Get
				Return Me.O.0o_0_o..Font
			End Get
			Set(value As Font)
				Me.O.0o_0_o..Font = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x06000214 RID: 532 RVA: 0x00005500 File Offset: 0x00003700
		' (set) Token: 0x06000215 RID: 533 RVA: 0x0000550D File Offset: 0x0000370D
		<Category("条码设置 - 文本")>
		<O_Oo00Oo000O0(11.0)>
		<DisplayName("文本颜色")>
		<DefaultValue(-16777216)>
		<MergableProperty(True)>
		Public Property ForeColor As Color
			Get
				Return Me.O.0o_0_o..ForeColor
			End Get
			Set(value As Color)
				Me.O.0o_0_o..ForeColor = value
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x06000216 RID: 534 RVA: 0x0000551B File Offset: 0x0000371B
		' (set) Token: 0x06000217 RID: 535 RVA: 0x00005528 File Offset: 0x00003728
		<Category("条码设置 - 文本")>
		<MergableProperty(True)>
		<DisplayName("说明字体")>
		<DefaultValue("宋体,9")>
		<O_Oo00Oo000O0(12.0)>
		Public Property TextFont As Font
			Get
				Return Me.O.0o_0_o..TextFont
			End Get
			Set(value As Font)
				Me.O.0o_0_o..TextFont = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x06000218 RID: 536 RVA: 0x00005540 File Offset: 0x00003740
		' (set) Token: 0x06000219 RID: 537 RVA: 0x0000554D File Offset: 0x0000374D
		<MergableProperty(True)>
		<O_Oo00Oo000O0(13.0)>
		<DefaultValue(-16777216)>
		<Category("条码设置 - 文本")>
		<DisplayName("说明颜色")>
		Public Property TextForeColor As Color
			Get
				Return Me.O.0o_0_o..TextForeColor
			End Get
			Set(value As Color)
				Me.O.0o_0_o..TextForeColor = value
			End Set
		End Property

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x0600021A RID: 538 RVA: 0x0000555B File Offset: 0x0000375B
		' (set) Token: 0x0600021B RID: 539 RVA: 0x00005568 File Offset: 0x00003768
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("编码格式")>
		<DefaultValue(0)>
		<Category("条码设置 - AztecCode")>
		<MergableProperty(True)>
		Public Property AztecCodeFormat As AztecCodeFormat
			Get
				Return Me.O.0o_0_o..AztecCodeFormat
			End Get
			Set(value As AztecCodeFormat)
				Me.O.0o_0_o..AztecCodeFormat = value
			End Set
		End Property

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x0600021C RID: 540 RVA: 0x00005576 File Offset: 0x00003776
		' (set) Token: 0x0600021D RID: 541 RVA: 0x00005583 File Offset: 0x00003783
		<MergableProperty(True)>
		<DisplayName("模组尺寸")>
		<Category("条码设置 - AztecCode")>
		<DefaultValue(1.0592)>
		<O_Oo00Oo000O0(2.0)>
		Public Property AztecCodeModuleSize As Double
			Get
				Return Me.O.0o_0_o..AztecCodeModuleSize
			End Get
			Set(value As Double)
				Me.O.0o_0_o..AztecCodeModuleSize = value
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x0600021E RID: 542 RVA: 0x00005591 File Offset: 0x00003791
		' (set) Token: 0x0600021F RID: 543 RVA: 0x0000559E File Offset: 0x0000379E
		<DefaultValue(23)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("容错比例")>
		<Category("条码设置 - AztecCode")>
		<MergableProperty(True)>
		Public Property AztecCodeErrorCorrection As Integer
			Get
				Return Me.O.0o_0_o..AztecCodeErrorCorrection
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..AztecCodeErrorCorrection = value
			End Set
		End Property

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x06000220 RID: 544 RVA: 0x000055AC File Offset: 0x000037AC
		' (set) Token: 0x06000221 RID: 545 RVA: 0x000055B9 File Offset: 0x000037B9
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DefaultValue(-1)>
		<Category("条码设置 - AztecCode")>
		Public Property AztecCodeRune As Integer
			Get
				Return Me.O.0o_0_o..AztecCodeRune
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..AztecCodeRune = value
			End Set
		End Property

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x06000222 RID: 546 RVA: 0x000055C7 File Offset: 0x000037C7
		' (set) Token: 0x06000223 RID: 547 RVA: 0x000055D4 File Offset: 0x000037D4
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("起始字符")>
		<Category("条码设置 - Codabar")>
		Public Property CodabarStartChar As CodabarStartStopChar
			Get
				Return Me.O.0o_0_o..CodabarStartChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.O.0o_0_o..CodabarStartChar = value
			End Set
		End Property

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x06000224 RID: 548 RVA: 0x000055E2 File Offset: 0x000037E2
		' (set) Token: 0x06000225 RID: 549 RVA: 0x000055EF File Offset: 0x000037EF
		<MergableProperty(True)>
		<Category("条码设置 - Codabar")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("结束字符")>
		<DefaultValue(0)>
		Public Property CodabarStopChar As CodabarStartStopChar
			Get
				Return Me.O.0o_0_o..CodabarStopChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.O.0o_0_o..CodabarStopChar = value
			End Set
		End Property

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x06000226 RID: 550 RVA: 0x000055FD File Offset: 0x000037FD
		' (set) Token: 0x06000227 RID: 551 RVA: 0x0000560A File Offset: 0x0000380A
		<Category("条码设置 - Code128")>
		<MergableProperty(True)>
		<DisplayName("字符集")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(0)>
		Public Property Code128CharSet As Code128
			Get
				Return Me.O.0o_0_o..Code128CharSet
			End Get
			Set(value As Code128)
				Me.O.0o_0_o..Code128CharSet = value
			End Set
		End Property

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x06000228 RID: 552 RVA: 0x00005618 File Offset: 0x00003818
		' (set) Token: 0x06000229 RID: 553 RVA: 0x00005625 File Offset: 0x00003825
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("编码模式")>
		<DefaultValue(0)>
		<Category("条码设置 - Code16K")>
		Public Property Code16kMode As Code16k
			Get
				Return Me.O.0o_0_o..Code16kMode
			End Get
			Set(value As Code16k)
				Me.O.0o_0_o..Code16kMode = value
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x0600022A RID: 554 RVA: 0x00005633 File Offset: 0x00003833
		' (set) Token: 0x0600022B RID: 555 RVA: 0x00005640 File Offset: 0x00003840
		<DisplayName("编码方式")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - DataMatrix")>
		Public Property DataMatrixEncoding As DataMatrixEncoding
			Get
				Return Me.O.0o_0_o..DataMatrixEncoding
			End Get
			Set(value As DataMatrixEncoding)
				Me.O.0o_0_o..DataMatrixEncoding = value
			End Set
		End Property

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x0600022C RID: 556 RVA: 0x0000564E File Offset: 0x0000384E
		' (set) Token: 0x0600022D RID: 557 RVA: 0x0000565B File Offset: 0x0000385B
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("条码设置 - DataMatrix")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("编码格式")>
		Public Property DataMatrixFormat As DataMatrixFormat
			Get
				Return Me.O.0o_0_o..DataMatrixFormat
			End Get
			Set(value As DataMatrixFormat)
				Me.O.0o_0_o..DataMatrixFormat = value
			End Set
		End Property

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x0600022E RID: 558 RVA: 0x00005669 File Offset: 0x00003869
		' (set) Token: 0x0600022F RID: 559 RVA: 0x00005676 File Offset: 0x00003876
		<DisplayName("模组尺寸")>
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<Category("条码设置 - DataMatrix")>
		<DefaultValue(1.0592)>
		Public Property DataMatrixModuleSize As Double
			Get
				Return Me.O.0o_0_o..DataMatrixModuleSize
			End Get
			Set(value As Double)
				Me.O.0o_0_o..DataMatrixModuleSize = value
			End Set
		End Property

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x06000230 RID: 560 RVA: 0x00005684 File Offset: 0x00003884
		' (set) Token: 0x06000231 RID: 561 RVA: 0x00005691 File Offset: 0x00003891
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DisplayName("处理波形符")>
		<Category("条码设置 - DataMatrix")>
		<DefaultValue(False)>
		Public Property DataMatrixProcessTilde As Boolean
			Get
				Return Me.O.0o_0_o..DataMatrixProcessTilde
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..DataMatrixProcessTilde = value
			End Set
		End Property

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x06000232 RID: 562 RVA: 0x0000569F File Offset: 0x0000389F
		' (set) Token: 0x06000233 RID: 563 RVA: 0x000056AC File Offset: 0x000038AC
		<DefaultValue(0)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - Ean And Upc")>
		<DisplayName("附加码数")>
		<MergableProperty(True)>
		Public Property EanUpcSupplement As Supplement
			Get
				Return Me.O.0o_0_o..EanUpcSupplement
			End Get
			Set(value As Supplement)
				Me.O.0o_0_o..EanUpcSupplement = value
			End Set
		End Property

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x06000234 RID: 564 RVA: 0x000056BA File Offset: 0x000038BA
		' (set) Token: 0x06000235 RID: 565 RVA: 0x000056C7 File Offset: 0x000038C7
		<Category("条码设置 - Ean And Upc")>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("附加码值")>
		<DefaultValue("0")>
		<MergableProperty(True)>
		Public Property EanUpcSupplementCode As String
			Get
				Return Me.O.0o_0_o..EanUpcSupplementCode
			End Get
			Set(value As String)
				Me.O.0o_0_o..EanUpcSupplementCode = value
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x06000236 RID: 566 RVA: 0x000056D5 File Offset: 0x000038D5
		' (set) Token: 0x06000237 RID: 567 RVA: 0x000056E2 File Offset: 0x000038E2
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<DisplayName("附加码左距")>
		<DefaultValue(3.81)>
		<Category("条码设置 - Ean And Upc")>
		Public Property EanUpcSupplementSeparation As Double
			Get
				Return Me.O.0o_0_o..EanUpcSupplementSeparation
			End Get
			Set(value As Double)
				Me.O.0o_0_o..EanUpcSupplementSeparation = value
			End Set
		End Property

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x06000238 RID: 568 RVA: 0x000056F0 File Offset: 0x000038F0
		' (set) Token: 0x06000239 RID: 569 RVA: 0x000056FD File Offset: 0x000038FD
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(3.81)>
		<Category("条码设置 - Ean And Upc")>
		<MergableProperty(True)>
		<DisplayName("附加码上距")>
		Public Property EanUpcSupplementTopMargin As Double
			Get
				Return Me.O.0o_0_o..EanUpcSupplementTopMargin
			End Get
			Set(value As Double)
				Me.O.0o_0_o..EanUpcSupplementTopMargin = value
			End Set
		End Property

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x0600023A RID: 570 RVA: 0x0000570B File Offset: 0x0000390B
		' (set) Token: 0x0600023B RID: 571 RVA: 0x00005718 File Offset: 0x00003918
		<Category("条码设置 - Ean And Upc")>
		<O_Oo00Oo000O0(5.0)>
		<MergableProperty(True)>
		<DisplayName("显示防护条")>
		<DefaultValue(True)>
		Public Property GuardBar As Boolean
			Get
				Return Me.O.0o_0_o..GuardBar
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..GuardBar = value
			End Set
		End Property

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x0600023C RID: 572 RVA: 0x00005726 File Offset: 0x00003926
		' (set) Token: 0x0600023D RID: 573 RVA: 0x00005733 File Offset: 0x00003933
		<Category("条码设置 - Ean And Upc")>
		<MergableProperty(True)>
		<DisplayName("防护条高度")>
		<DefaultValue(6.35)>
		<O_Oo00Oo000O0(6.0)>
		Public Property GuardBarHeight As Double
			Get
				Return Me.O.0o_0_o..GuardBarHeight
			End Get
			Set(value As Double)
				Me.O.0o_0_o..GuardBarHeight = value
			End Set
		End Property

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x0600023E RID: 574 RVA: 0x00005741 File Offset: 0x00003941
		' (set) Token: 0x0600023F RID: 575 RVA: 0x0000574E File Offset: 0x0000394E
		<DisplayName("编码方式")>
		<MergableProperty(True)>
		<Category("条码设置 - Ean And Upc")>
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(0)>
		Public Property UpcESystem As UpcE
			Get
				Return Me.O.0o_0_o..UpcESystem
			End Get
			Set(value As UpcE)
				Me.O.0o_0_o..UpcESystem = value
			End Set
		End Property

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x06000240 RID: 576 RVA: 0x0000575C File Offset: 0x0000395C
		' (set) Token: 0x06000241 RID: 577 RVA: 0x00005769 File Offset: 0x00003969
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(4)>
		<DisplayName("每行段数")>
		<Category("条码设置 - ExpandedStacked")>
		<MergableProperty(True)>
		Public Property SegmentsPerRow As Integer
			Get
				Return Me.O.0o_0_o..SegmentsPerRow
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..SegmentsPerRow = value
			End Set
		End Property

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x06000242 RID: 578 RVA: 0x00005777 File Offset: 0x00003977
		' (set) Token: 0x06000243 RID: 579 RVA: 0x00005784 File Offset: 0x00003984
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("格式化替换文本")>
		<DefaultValue(True)>
		<Category("条码设置 - HIBC")>
		<MergableProperty(True)>
		Public Property HibcFormatHumanReadableText As Boolean
			Get
				Return Me.O.0o_0_o..HibcFormatHumanReadableText
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..HibcFormatHumanReadableText = value
			End Set
		End Property

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x06000244 RID: 580 RVA: 0x00005792 File Offset: 0x00003992
		' (set) Token: 0x06000245 RID: 581 RVA: 0x0000579F File Offset: 0x0000399F
		<DisplayName("数据结构")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - ISBT")>
		<DefaultValue(0)>
		Public Property Isbt128DataStructure As Isbt128DataStructure
			Get
				Return Me.O.0o_0_o..Isbt128DataStructure
			End Get
			Set(value As Isbt128DataStructure)
				Me.O.0o_0_o..Isbt128DataStructure = value
			End Set
		End Property

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x06000246 RID: 582 RVA: 0x000057AD File Offset: 0x000039AD
		' (set) Token: 0x06000247 RID: 583 RVA: 0x000057BA File Offset: 0x000039BA
		<DisplayName("编码模式")>
		<Category("条码设置 - MaxiCode")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(4)>
		Public Property MaxiCodeMode As MaxiCodeModes
			Get
				Return Me.O.0o_0_o..MaxiCodeMode
			End Get
			Set(value As MaxiCodeModes)
				Me.O.0o_0_o..MaxiCodeMode = value
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x06000248 RID: 584 RVA: 0x000057C8 File Offset: 0x000039C8
		' (set) Token: 0x06000249 RID: 585 RVA: 0x000057D5 File Offset: 0x000039D5
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置 - MaxiCode")>
		<DisplayName("模式字符数量")>
		<DefaultValue(1)>
		Public Property MaxiCodeSymbolCount As Integer
			Get
				Return Me.O.0o_0_o..MaxiCodeSymbolCount
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..MaxiCodeSymbolCount = value
			End Set
		End Property

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x0600024A RID: 586 RVA: 0x000057E3 File Offset: 0x000039E3
		' (set) Token: 0x0600024B RID: 587 RVA: 0x000057F0 File Offset: 0x000039F0
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<DefaultValue(1)>
		<DisplayName("模式字符位置")>
		<Category("条码设置 - MaxiCode")>
		Public Property MaxiCodeSymbolIndex As Integer
			Get
				Return Me.O.0o_0_o..MaxiCodeSymbolIndex
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..MaxiCodeSymbolIndex = value
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x0600024C RID: 588 RVA: 0x000057FE File Offset: 0x000039FE
		' (set) Token: 0x0600024D RID: 589 RVA: 0x0000580B File Offset: 0x00003A0B
		<DefaultValue(False)>
		<MergableProperty(True)>
		<DisplayName("处理波浪符")>
		<Category("条码设置 - MaxiCode")>
		<O_Oo00Oo000O0(4.0)>
		Public Property MaxiCodeProcessTilde As Boolean
			Get
				Return Me.O.0o_0_o..MaxiCodeProcessTilde
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..MaxiCodeProcessTilde = value
			End Set
		End Property

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x0600024E RID: 590 RVA: 0x00005819 File Offset: 0x00003A19
		' (set) Token: 0x0600024F RID: 591 RVA: 0x00005826 File Offset: 0x00003A26
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("校验模式")>
		<Category("条码设置 - MSI")>
		<DefaultValue(0)>
		Public Property MsiChecksum As MsiChecksum
			Get
				Return Me.O.0o_0_o..MsiChecksum
			End Get
			Set(value As MsiChecksum)
				Me.O.0o_0_o..MsiChecksum = value
			End Set
		End Property

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x06000250 RID: 592 RVA: 0x00005834 File Offset: 0x00003A34
		' (set) Token: 0x06000251 RID: 593 RVA: 0x00005841 File Offset: 0x00003A41
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<DisplayName("编码类型")>
		<Category("条码设置 - PDF417")>
		Public Property Pdf417CompactionType As Pdf417CompactionType
			Get
				Return Me.O.0o_0_o..Pdf417CompactionType
			End Get
			Set(value As Pdf417CompactionType)
				Me.O.0o_0_o..Pdf417CompactionType = value
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x06000252 RID: 594 RVA: 0x0000584F File Offset: 0x00003A4F
		' (set) Token: 0x06000253 RID: 595 RVA: 0x0000585C File Offset: 0x00003A5C
		<O_Oo00Oo000O0(2.0)>
		<Category("条码设置 - PDF417")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		<DisplayName("编码版号")>
		Public Property MicroPdf417Version As MicroPdf417Version
			Get
				Return Me.O.0o_0_o..MicroPdf417Version
			End Get
			Set(value As MicroPdf417Version)
				Me.O.0o_0_o..MicroPdf417Version = value
			End Set
		End Property

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x06000254 RID: 596 RVA: 0x0000586A File Offset: 0x00003A6A
		' (set) Token: 0x06000255 RID: 597 RVA: 0x00005877 File Offset: 0x00003A77
		<O_Oo00Oo000O0(2.1)>
		<DefaultValue(2)>
		<MergableProperty(True)>
		<DisplayName("容错级别")>
		<Category("条码设置 - PDF417")>
		Public Property Pdf417ErrorCorrectionLevel As Pdf417ErrorCorrection
			Get
				Return Me.O.0o_0_o..Pdf417ErrorCorrectionLevel
			End Get
			Set(value As Pdf417ErrorCorrection)
				Me.O.0o_0_o..Pdf417ErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x06000256 RID: 598 RVA: 0x00005885 File Offset: 0x00003A85
		' (set) Token: 0x06000257 RID: 599 RVA: 0x00005892 File Offset: 0x00003A92
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("高度比例")>
		<DefaultValue(0)>
		Public Property Pdf417AspectRatio As Double
			Get
				Return Me.O.0o_0_o..Pdf417AspectRatio
			End Get
			Set(value As Double)
				Me.O.0o_0_o..Pdf417AspectRatio = value
			End Set
		End Property

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x06000258 RID: 600 RVA: 0x000058A0 File Offset: 0x00003AA0
		' (set) Token: 0x06000259 RID: 601 RVA: 0x000058AD File Offset: 0x00003AAD
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(0)>
		<Category("条码设置 - PDF417")>
		<DisplayName("列数")>
		<MergableProperty(True)>
		Public Property Pdf417Columns As Integer
			Get
				Return Me.O.0o_0_o..Pdf417Columns
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..Pdf417Columns = value
			End Set
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x0600025A RID: 602 RVA: 0x000058BB File Offset: 0x00003ABB
		' (set) Token: 0x0600025B RID: 603 RVA: 0x000058C8 File Offset: 0x00003AC8
		<DefaultValue(0)>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("行数")>
		Public Property Pdf417Rows As Integer
			Get
				Return Me.O.0o_0_o..Pdf417Rows
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..Pdf417Rows = value
			End Set
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x0600025C RID: 604 RVA: 0x000058D6 File Offset: 0x00003AD6
		' (set) Token: 0x0600025D RID: 605 RVA: 0x000058E3 File Offset: 0x00003AE3
		<Category("条码设置 - PDF417")>
		<O_Oo00Oo000O0(6.0)>
		<DefaultValue(False)>
		<DisplayName("右侧截断")>
		<MergableProperty(True)>
		Public Property Pdf417Truncated As Boolean
			Get
				Return Me.O.0o_0_o..Pdf417Truncated
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..Pdf417Truncated = value
			End Set
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x0600025E RID: 606 RVA: 0x000058F1 File Offset: 0x00003AF1
		' (set) Token: 0x0600025F RID: 607 RVA: 0x000058FE File Offset: 0x00003AFE
		<O_Oo00Oo000O0(7.0)>
		<MergableProperty(True)>
		<DefaultValue("000")>
		<DisplayName("文件ID")>
		<Category("条码设置 - PDF417")>
		Public Property Pdf417FileId As String
			Get
				Return Me.O.0o_0_o..Pdf417FileId
			End Get
			Set(value As String)
				Me.O.0o_0_o..Pdf417FileId = value
			End Set
		End Property

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x06000260 RID: 608 RVA: 0x0000590C File Offset: 0x00003B0C
		' (set) Token: 0x06000261 RID: 609 RVA: 0x00005919 File Offset: 0x00003B19
		<O_Oo00Oo000O0(8.0)>
		<Category("条码设置 - PDF417")>
		<MergableProperty(True)>
		<DisplayName("分段总数")>
		<DefaultValue(0)>
		Public Property Pdf417SegmentCount As Integer
			Get
				Return Me.O.0o_0_o..Pdf417SegmentCount
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..Pdf417SegmentCount = value
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x06000262 RID: 610 RVA: 0x00005927 File Offset: 0x00003B27
		' (set) Token: 0x06000263 RID: 611 RVA: 0x00005934 File Offset: 0x00003B34
		<O_Oo00Oo000O0(9.0)>
		<Category("条码设置 - PDF417")>
		<DisplayName("分段位置")>
		<DefaultValue(0)>
		<MergableProperty(True)>
		Public Property Pdf417SegmentIndex As Integer
			Get
				Return Me.O.0o_0_o..Pdf417SegmentIndex
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..Pdf417SegmentIndex = value
			End Set
		End Property

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x06000264 RID: 612 RVA: 0x00005942 File Offset: 0x00003B42
		' (set) Token: 0x06000265 RID: 613 RVA: 0x0000594F File Offset: 0x00003B4F
		<MergableProperty(True)>
		<DefaultValue(1.0592)>
		<Category("条码设置 - Pharmacode")>
		<DisplayName("条间距")>
		<O_Oo00Oo000O0(1.0)>
		Public Property PharmacodeBarsSpacing As Double
			Get
				Return Me.O.0o_0_o..PharmacodeBarsSpacing
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PharmacodeBarsSpacing = value
			End Set
		End Property

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x06000266 RID: 614 RVA: 0x0000595D File Offset: 0x00003B5D
		' (set) Token: 0x06000267 RID: 615 RVA: 0x0000596A File Offset: 0x00003B6A
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(1.5875)>
		<Category("条码设置 - Pharmacode")>
		<MergableProperty(True)>
		<DisplayName("宽条尺寸")>
		Public Property PharmacodeThickBarWidth As Double
			Get
				Return Me.O.0o_0_o..PharmacodeThickBarWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PharmacodeThickBarWidth = value
			End Set
		End Property

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x06000268 RID: 616 RVA: 0x00005978 File Offset: 0x00003B78
		' (set) Token: 0x06000269 RID: 617 RVA: 0x00005985 File Offset: 0x00003B85
		<MergableProperty(True)>
		<Category("条码设置 - Pharmacode")>
		<DisplayName("窄条尺寸")>
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(0.5283)>
		Public Property PharmacodeThinBarWidth As Double
			Get
				Return Me.O.0o_0_o..PharmacodeThinBarWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PharmacodeThinBarWidth = value
			End Set
		End Property

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x0600026A RID: 618 RVA: 0x00005993 File Offset: 0x00003B93
		' (set) Token: 0x0600026B RID: 619 RVA: 0x000059A0 File Offset: 0x00003BA0
		<MergableProperty(True)>
		<DefaultValue(5.0)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - Planet")>
		<DisplayName("短条高度")>
		Public Property PlanetHeightShortBar As Double
			Get
				Return Me.O.0o_0_o..PlanetHeightShortBar
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PlanetHeightShortBar = value
			End Set
		End Property

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x0600026C RID: 620 RVA: 0x000059AE File Offset: 0x00003BAE
		' (set) Token: 0x0600026D RID: 621 RVA: 0x000059BB File Offset: 0x00003BBB
		<DisplayName("长条高度")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(10.0)>
		<Category("条码设置 - Planet")>
		Public Property PlanetHeightTallBar As Double
			Get
				Return Me.O.0o_0_o..PlanetHeightTallBar
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PlanetHeightTallBar = value
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x0600026E RID: 622 RVA: 0x000059C9 File Offset: 0x00003BC9
		' (set) Token: 0x0600026F RID: 623 RVA: 0x000059D6 File Offset: 0x00003BD6
		<MergableProperty(True)>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("起止标记")>
		<DefaultValue(True)>
		<Category("条码设置 - Postal 4-State")>
		Public Property Postal4StateAddStartStopChar As Boolean
			Get
				Return Me.O.0o_0_o..Postal4StateAddStartStopChar
			End Get
			Set(value As Boolean)
				Me.O.0o_0_o..Postal4StateAddStartStopChar = value
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x06000270 RID: 624 RVA: 0x000059E4 File Offset: 0x00003BE4
		' (set) Token: 0x06000271 RID: 625 RVA: 0x000059F1 File Offset: 0x00003BF1
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("条间距")>
		<DefaultValue(0.795)>
		<Category("条码设置 - Postal 4-State")>
		Public Property Postal4StateBarsSpacing As Double
			Get
				Return Me.O.0o_0_o..Postal4StateBarsSpacing
			End Get
			Set(value As Double)
				Me.O.0o_0_o..Postal4StateBarsSpacing = value
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x06000272 RID: 626 RVA: 0x000059FF File Offset: 0x00003BFF
		' (set) Token: 0x06000273 RID: 627 RVA: 0x00005A0C File Offset: 0x00003C0C
		<Category("条码设置 - Postal 4-State")>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("条高度")>
		<DefaultValue(2.032)>
		<MergableProperty(True)>
		Public Property Postal4StateTrackerBarHeight As Double
			Get
				Return Me.O.0o_0_o..Postal4StateTrackerBarHeight
			End Get
			Set(value As Double)
				Me.O.0o_0_o..Postal4StateTrackerBarHeight = value
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x06000274 RID: 628 RVA: 0x00005A1A File Offset: 0x00003C1A
		' (set) Token: 0x06000275 RID: 629 RVA: 0x00005A27 File Offset: 0x00003C27
		<DefaultValue(0.5283)>
		<DisplayName("条宽度")>
		<Category("条码设置 - Postal 4-State")>
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		Public Property Postal4StateTrackerBarWidth As Double
			Get
				Return Me.O.0o_0_o..Postal4StateTrackerBarWidth
			End Get
			Set(value As Double)
				Me.O.0o_0_o..Postal4StateTrackerBarWidth = value
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x06000276 RID: 630 RVA: 0x00005A35 File Offset: 0x00003C35
		' (set) Token: 0x06000277 RID: 631 RVA: 0x00005A42 File Offset: 0x00003C42
		<DisplayName("短条高度")>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - Postnet")>
		<DefaultValue(5.0)>
		<MergableProperty(True)>
		Public Property PostnetHeightShortBar As Double
			Get
				Return Me.O.0o_0_o..PostnetHeightShortBar
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PostnetHeightShortBar = value
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x06000278 RID: 632 RVA: 0x00005A50 File Offset: 0x00003C50
		' (set) Token: 0x06000279 RID: 633 RVA: 0x00005A5D File Offset: 0x00003C5D
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(10.0)>
		<DisplayName("长条高度")>
		<Category("条码设置 - Postnet")>
		Public Property PostnetHeightTallBar As Double
			Get
				Return Me.O.0o_0_o..PostnetHeightTallBar
			End Get
			Set(value As Double)
				Me.O.0o_0_o..PostnetHeightTallBar = value
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x0600027A RID: 634 RVA: 0x00005A6B File Offset: 0x00003C6B
		' (set) Token: 0x0600027B RID: 635 RVA: 0x00005A78 File Offset: 0x00003C78
		<MergableProperty(True)>
		<DisplayName("编码版号")>
		<Category("条码设置 - QR Code")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(0)>
		Public Property MicroQRCodeVersion As MicroQRCodeVersion
			Get
				Return Me.O.0o_0_o..MicroQRCodeVersion
			End Get
			Set(value As MicroQRCodeVersion)
				Me.O.0o_0_o..MicroQRCodeVersion = value
			End Set
		End Property

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x0600027C RID: 636 RVA: 0x00005A86 File Offset: 0x00003C86
		' (set) Token: 0x0600027D RID: 637 RVA: 0x00005A93 File Offset: 0x00003C93
		<Category("条码设置 - QR Code")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("编码方式")>
		Public Property QRCodeEncoding As QRCodeEncoding
			Get
				Return Me.O.0o_0_o..QRCodeEncoding
			End Get
			Set(value As QRCodeEncoding)
				Me.O.0o_0_o..QRCodeEncoding = value
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x0600027E RID: 638 RVA: 0x00005AA1 File Offset: 0x00003CA1
		' (set) Token: 0x0600027F RID: 639 RVA: 0x00005AAE File Offset: 0x00003CAE
		<DefaultValue(0)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("编码版号")>
		<Category("条码设置 - QR Code")>
		<MergableProperty(True)>
		Public Property QRCodeVersion As QRCodeVersion
			Get
				Return Me.O.0o_0_o..QRCodeVersion
			End Get
			Set(value As QRCodeVersion)
				Me.O.0o_0_o..QRCodeVersion = value
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x06000280 RID: 640 RVA: 0x00005ABC File Offset: 0x00003CBC
		' (set) Token: 0x06000281 RID: 641 RVA: 0x00005AC9 File Offset: 0x00003CC9
		<O_Oo00Oo000O0(4.0)>
		<MergableProperty(True)>
		<DefaultValue(1)>
		<Category("条码设置 - QR Code")>
		<DisplayName("容错级别")>
		Public Property QRCodeErrorCorrectionLevel As QRCodeErrorCorrectionLevel
			Get
				Return Me.O.0o_0_o..QRCodeErrorCorrectionLevel
			End Get
			Set(value As QRCodeErrorCorrectionLevel)
				Me.O.0o_0_o..QRCodeErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000282 RID: 642 RVA: 0x00005AD7 File Offset: 0x00003CD7
		' (set) Token: 0x06000283 RID: 643 RVA: 0x00005AE4 File Offset: 0x00003CE4
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("字符编码")>
		<DefaultValue("gb2312")>
		<TypeConverter(GetType(o___o_O__))>
		<MergableProperty(True)>
		<Category("条码设置 - QR Code")>
		Public Property QRCodeByteEncodingName As String
			Get
				Return Me.O.0o_0_o..QRCodeByteEncodingName
			End Get
			Set(value As String)
				Me.O.0o_0_o..QRCodeByteEncodingName = value
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x06000284 RID: 644 RVA: 0x00005AF2 File Offset: 0x00003CF2
		' (set) Token: 0x06000285 RID: 645 RVA: 0x00005AFF File Offset: 0x00003CFF
		<DefaultValue(1.0592)>
		<O_Oo00Oo000O0(7.0)>
		<Category("条码设置 - QR Code")>
		<DisplayName("模组尺寸")>
		<MergableProperty(True)>
		Public Property QRCodeModuleSize As Double
			Get
				Return Me.O.0o_0_o..QRCodeModuleSize
			End Get
			Set(value As Double)
				Me.O.0o_0_o..QRCodeModuleSize = value
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000286 RID: 646 RVA: 0x00005B0D File Offset: 0x00003D0D
		' (set) Token: 0x06000287 RID: 647 RVA: 0x00005B1A File Offset: 0x00003D1A
		<MergableProperty(True)>
		<Category("条码设置 - Telepen")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("编码方式")>
		<DefaultValue(0)>
		Public Property TelepenEncoding As TelepenEncoding
			Get
				Return Me.O.0o_0_o..TelepenEncoding
			End Get
			Set(value As TelepenEncoding)
				Me.O.0o_0_o..TelepenEncoding = value
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x06000288 RID: 648 RVA: 0x00005B28 File Offset: 0x00003D28
		' (set) Token: 0x06000289 RID: 649 RVA: 0x00005B35 File Offset: 0x00003D35
		<O_Oo00Oo000O0(1.0)>
		<MergableProperty(True)>
		<DisplayName("编码方式")>
		<DefaultValue(0)>
		<Category("条码设置 - USPS FIM")>
		Public Property UspsFimPattern As FIM
			Get
				Return Me.O.0o_0_o..UspsFimPattern
			End Get
			Set(value As FIM)
				Me.O.0o_0_o..UspsFimPattern = value
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x0600028A RID: 650 RVA: 0x00005B43 File Offset: 0x00003D43
		' (set) Token: 0x0600028B RID: 651 RVA: 0x00005B50 File Offset: 0x00003D50
		<DefaultValue(10)>
		<O_Oo00Oo000O0(1.0)>
		<Category("条码设置 - USPS Horizontal Bars")>
		<MergableProperty(True)>
		Public Property UspsHorizontalBarsCount As Integer
			Get
				Return Me.O.0o_0_o..UspsHorizontalBarsCount
			End Get
			Set(value As Integer)
				Me.O.0o_0_o..UspsHorizontalBarsCount = value
			End Set
		End Property

		' Token: 0x0400005B RID: 91
		Private <<EMPTY_NAME>> As BarcodeProfessional
	End Class
End Namespace
