Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000322 RID: 802
	<TypeConverter(GetType(OoO0o0oo__Oo))>
	Friend Class DataColumnProperty
		' Token: 0x06002B8C RID: 11148 RVA: 0x001300C8 File Offset: 0x0012E2C8
		Public Sub New(A_0 As DataCol)
			Me.oO.OO. = A_0
		End Sub

		' Token: 0x17000A57 RID: 2647
		' (get) Token: 0x06002B8D RID: 11149 RVA: 0x001300D8 File Offset: 0x0012E2D8
		' (set) Token: 0x06002B8E RID: 11150 RVA: 0x00130103 File Offset: 0x0012E303
		<Browsable(False)>
		Public Property Caption As String
			Get
				Dim caption As String
				If Me.oO.OO. IsNot Nothing Then
					caption = Me.oO.OO..Caption
				Else
					caption = Me.o.0OoOo.
				End If
				Return caption
			End Get
			Set(value As String)
				If Me.oO.OO. IsNot Nothing Then
					Me.oO.OO..Caption = value
					Return
				End If
				Me.o.0OoOo. = value
			End Set
		End Property

		' Token: 0x17000A58 RID: 2648
		' (get) Token: 0x06002B8F RID: 11151 RVA: 0x00130121 File Offset: 0x0012E321
		' (set) Token: 0x06002B90 RID: 11152 RVA: 0x0013012E File Offset: 0x0012E32E
		<DefaultValue(True)>
		<DisplayName("允许编辑")>
		<O_Oo00Oo000O0(0.0)>
		<Category("基本属性")>
		Public Property AllowEdit As Boolean
			Get
				Return Me.oO.OO..AllowEdit
			End Get
			Set(value As Boolean)
				Me.oO.OO..AllowEdit = value
			End Set
		End Property

		' Token: 0x17000A59 RID: 2649
		' (get) Token: 0x06002B91 RID: 11153 RVA: 0x0013013C File Offset: 0x0012E33C
		' (set) Token: 0x06002B92 RID: 11154 RVA: 0x00130149 File Offset: 0x0012E349
		<DefaultValue(False)>
		<O_Oo00Oo000O0(0.1)>
		<Category("基本属性")>
		<DisplayName("禁止重复")>
		Public Property Unique As Boolean
			Get
				Return Me.oO.OO..Unique
			End Get
			Set(value As Boolean)
				Me.oO.OO..Unique = value
			End Set
		End Property

		' Token: 0x17000A5A RID: 2650
		' (get) Token: 0x06002B93 RID: 11155 RVA: 0x00130157 File Offset: 0x0012E357
		' (set) Token: 0x06002B94 RID: 11156 RVA: 0x00130164 File Offset: 0x0012E364
		<O_Oo00Oo000O0(0.11)>
		<DisplayName("默认值")>
		<Category("基本属性")>
		Public Property DefaultValue As String
			Get
				Return Me.oO.OO..DefaultValue
			End Get
			Set(value As String)
				Me.oO.OO..DefaultValue = value
			End Set
		End Property

		' Token: 0x17000A5B RID: 2651
		' (get) Token: 0x06002B95 RID: 11157 RVA: 0x00130172 File Offset: 0x0012E372
		' (set) Token: 0x06002B96 RID: 11158 RVA: 0x0013017F File Offset: 0x0012E37F
		<Category("基本属性")>
		<DisplayName("中文输入")>
		<O_Oo00Oo000O0(0.2)>
		<DefaultValue(0)>
		<Description("选择本列时，是否自动关闭或打开中文输入模式，等于模拟Shift健。")>
		Public Property ImeMode As BooleanEnum
			Get
				Return Me.oO.OO..ImeMode
			End Get
			Set(value As BooleanEnum)
				Me.oO.OO..ImeMode = value
			End Set
		End Property

		' Token: 0x17000A5C RID: 2652
		' (get) Token: 0x06002B97 RID: 11159 RVA: 0x0013018D File Offset: 0x0012E38D
		' (set) Token: 0x06002B98 RID: 11160 RVA: 0x0013019A File Offset: 0x0012E39A
		<DisplayName("输入掩码")>
		<Category("基本属性")>
		<O_Oo00Oo000O0(2.0)>
		Public Property EditMask As String
			Get
				Return Me.oO.OO..EditMask
			End Get
			Set(value As String)
				Me.oO.OO..EditMask = value
			End Set
		End Property

		' Token: 0x17000A5D RID: 2653
		' (get) Token: 0x06002B99 RID: 11161 RVA: 0x001301A8 File Offset: 0x0012E3A8
		' (set) Token: 0x06002B9A RID: 11162 RVA: 0x001301B5 File Offset: 0x0012E3B5
		<Category("基本属性")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("数据对齐")>
		Public Property TextAlign As TextAlignEnum
			Get
				Return Me.oO.OO..TextAlign
			End Get
			Set(value As TextAlignEnum)
				Me.oO.OO..TextAlign = value
			End Set
		End Property

		' Token: 0x17000A5E RID: 2654
		' (get) Token: 0x06002B9B RID: 11163 RVA: 0x001301C3 File Offset: 0x0012E3C3
		' (set) Token: 0x06002B9C RID: 11164 RVA: 0x001301D0 File Offset: 0x0012E3D0
		<DisplayName("标题对齐")>
		<O_Oo00Oo000O0(5.0)>
		<Category("基本属性")>
		<DefaultValue(0)>
		Public Property TextAlignFixed As TextAlignEnum
			Get
				Return Me.oO.OO..TextAlignFixed
			End Get
			Set(value As TextAlignEnum)
				Me.oO.OO..TextAlignFixed = value
			End Set
		End Property

		' Token: 0x17000A5F RID: 2655
		' (get) Token: 0x06002B9D RID: 11165 RVA: 0x001301DE File Offset: 0x0012E3DE
		' (set) Token: 0x06002B9E RID: 11166 RVA: 0x001301EB File Offset: 0x0012E3EB
		<O_Oo00Oo000O0(6.0)>
		<Category("记录窗口")>
		<Description("在记录窗口显示的缩写标题。")>
		<DisplayName("缩写标题")>
		Public Property ShortCaption As String
			Get
				Return Me.oO.OO..ShortCaption
			End Get
			Set(value As String)
				Me.oO.OO..ShortCaption = value
			End Set
		End Property

		' Token: 0x17000A60 RID: 2656
		' (get) Token: 0x06002B9F RID: 11167 RVA: 0x001301F9 File Offset: 0x0012E3F9
		' (set) Token: 0x06002BA0 RID: 11168 RVA: 0x00130206 File Offset: 0x0012E406
		<DisplayName("行高倍数")>
		<O_Oo00Oo000O0(6.1)>
		<Category("记录窗口")>
		Public Property RecordRowHeight As Integer
			Get
				Return Me.oO.OO..RecordRowHeight
			End Get
			Set(value As Integer)
				Me.oO.OO..RecordRowHeight = Math.Max(1, Math.Min(value, 20))
			End Set
		End Property

		' Token: 0x17000A61 RID: 2657
		' (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00130221 File Offset: 0x0012E421
		' (set) Token: 0x06002BA2 RID: 11170 RVA: 0x0013022E File Offset: 0x0012E42E
		<Description("是否在记录窗口显示此列。")>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("在记录窗口显示")>
		<Category("记录窗口")>
		Public Property ShowInRecordGrid As BooleanEnum
			Get
				Return Me.oO.OO..ShowInRecordGrid
			End Get
			Set(value As BooleanEnum)
				Me.oO.OO..ShowInRecordGrid = value
			End Set
		End Property

		' Token: 0x17000A62 RID: 2658
		' (get) Token: 0x06002BA3 RID: 11171 RVA: 0x0013023C File Offset: 0x0012E43C
		' (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00130249 File Offset: 0x0012E449
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("使用内置输入器")>
		<DefaultValue(False)>
		<Description("对于日期列或者数值列，是否自动显示下拉日历或下拉计算器来输入数据。")>
		<Category("基本属性")>
		Public Property UsetBuildInEditor As Boolean
			Get
				Return Me.oO.OO..UsetBuildInEditor
			End Get
			Set(value As Boolean)
				Me.oO.OO..UsetBuildInEditor = value
			End Set
		End Property

		' Token: 0x17000A63 RID: 2659
		' (get) Token: 0x06002BA5 RID: 11173 RVA: 0x00130257 File Offset: 0x0012E457
		' (set) Token: 0x06002BA6 RID: 11174 RVA: 0x00130264 File Offset: 0x0012E464
		<O_Oo00Oo000O0(20.0)>
		<DisplayName("日期时间格式")>
		<DefaultValue(0)>
		<Category("基本属性")>
		Public Property DateTimeFormat As DateTimeFormatEnum
			Get
				Return Me.oO.OO..DateTimeFormat
			End Get
			Set(value As DateTimeFormatEnum)
				Me.oO.OO..DateTimeFormat = value
			End Set
		End Property

		' Token: 0x17000A64 RID: 2660
		' (get) Token: 0x06002BA7 RID: 11175 RVA: 0x00130272 File Offset: 0x0012E472
		' (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0013027F File Offset: 0x0012E47F
		<O_Oo00Oo000O0(21.0)>
		<Description("设置逻辑值的字符显示，例如：男;女")>
		<Category("基本属性")>
		<DisplayName("逻辑格式")>
		Public Property BooleanFormat As String
			Get
				Return Me.oO.OO..BooleanFormat
			End Get
			Set(value As String)
				Me.oO.OO..BooleanFormat = value
			End Set
		End Property

		' Token: 0x17000A65 RID: 2661
		' (get) Token: 0x06002BA9 RID: 11177 RVA: 0x0013028D File Offset: 0x0012E48D
		' (set) Token: 0x06002BAA RID: 11178 RVA: 0x0013029A File Offset: 0x0012E49A
		<O_Oo00Oo000O0(8.1)>
		<DisplayName("扩展列类型")>
		<Category("扩展")>
		<DefaultValue(0)>
		Public Property ExtendColumnType As ExtendColumnTypeEnum
			Get
				Return Me.oO.OO..ExtendColumnType
			End Get
			Set(value As ExtendColumnTypeEnum)
				Me.oO.OO..ExtendColumnType = value
			End Set
		End Property

		' Token: 0x17000A66 RID: 2662
		' (get) Token: 0x06002BAB RID: 11179 RVA: 0x001302A8 File Offset: 0x0012E4A8
		' (set) Token: 0x06002BAC RID: 11180 RVA: 0x001302B5 File Offset: 0x0012E4B5
		<DefaultValue(False)>
		<DisplayName("远程文件")>
		<O_Oo00Oo000O0(8.11)>
		<Category("扩展")>
		Public Property Remote As Boolean
			Get
				Return Me.oO.OO..Remote
			End Get
			Set(value As Boolean)
				Me.oO.OO..Remote = value
			End Set
		End Property

		' Token: 0x17000A67 RID: 2663
		' (get) Token: 0x06002BAD RID: 11181 RVA: 0x001302C3 File Offset: 0x0012E4C3
		' (set) Token: 0x06002BAE RID: 11182 RVA: 0x001302D0 File Offset: 0x0012E4D0
		<Category("扩展")>
		<DisplayName("服务器地址")>
		<O_Oo00Oo000O0(8.12)>
		Public Property Host As String
			Get
				Return Me.oO.OO..Host
			End Get
			Set(value As String)
				Me.oO.OO..Host = value
			End Set
		End Property

		' Token: 0x17000A68 RID: 2664
		' (get) Token: 0x06002BAF RID: 11183 RVA: 0x001302DE File Offset: 0x0012E4DE
		' (set) Token: 0x06002BB0 RID: 11184 RVA: 0x001302EB File Offset: 0x0012E4EB
		<DisplayName("用户名")>
		<Category("扩展")>
		<O_Oo00Oo000O0(8.13)>
		Public Property Account As String
			Get
				Return Me.oO.OO..Account
			End Get
			Set(value As String)
				Me.oO.OO..Account = value
			End Set
		End Property

		' Token: 0x17000A69 RID: 2665
		' (get) Token: 0x06002BB1 RID: 11185 RVA: 0x001302F9 File Offset: 0x0012E4F9
		' (set) Token: 0x06002BB2 RID: 11186 RVA: 0x00130306 File Offset: 0x0012E506
		<O_Oo00Oo000O0(8.14)>
		<Category("扩展")>
		<DisplayName("用户密码")>
		Public Property Password As String
			Get
				Return Me.oO.OO..Password
			End Get
			Set(value As String)
				Me.oO.OO..Password = value
			End Set
		End Property

		' Token: 0x17000A6A RID: 2666
		' (get) Token: 0x06002BB3 RID: 11187 RVA: 0x00130314 File Offset: 0x0012E514
		' (set) Token: 0x06002BB4 RID: 11188 RVA: 0x00130321 File Offset: 0x0012E521
		<O_Oo00Oo000O0(8.141)>
		<Category("扩展")>
		<DisplayName("UTF8编码")>
		<DefaultValue(False)>
		Public Property UTF8 As Boolean
			Get
				Return Me.oO.OO..UTF8
			End Get
			Set(value As Boolean)
				Me.oO.OO..UTF8 = value
			End Set
		End Property

		' Token: 0x17000A6B RID: 2667
		' (get) Token: 0x06002BB5 RID: 11189 RVA: 0x0013032F File Offset: 0x0012E52F
		' (set) Token: 0x06002BB6 RID: 11190 RVA: 0x0013033C File Offset: 0x0012E53C
		<DisplayName("端口号")>
		<O_Oo00Oo000O0(8.142)>
		<Category("扩展")>
		<DefaultValue(21)>
		Public Property Port As Integer
			Get
				Return Me.oO.OO..Port
			End Get
			Set(value As Integer)
				Me.oO.OO..Port = value
			End Set
		End Property

		' Token: 0x17000A6C RID: 2668
		' (get) Token: 0x06002BB7 RID: 11191 RVA: 0x0013034A File Offset: 0x0012E54A
		' (set) Token: 0x06002BB8 RID: 11192 RVA: 0x00130357 File Offset: 0x0012E557
		<O_Oo00Oo000O0(8.15)>
		<DisplayName("根目录")>
		<Category("扩展")>
		Public Property RootDir As String
			Get
				Return Me.oO.OO..RootDir
			End Get
			Set(value As String)
				Me.oO.OO..RootDir = value
			End Set
		End Property

		' Token: 0x17000A6D RID: 2669
		' (get) Token: 0x06002BB9 RID: 11193 RVA: 0x00130365 File Offset: 0x0012E565
		' (set) Token: 0x06002BBA RID: 11194 RVA: 0x00130372 File Offset: 0x0012E572
		<Category("扩展")>
		<O_Oo00Oo000O0(8.2)>
		<DisplayName("多值分隔符")>
		<DefaultValue(",")>
		Public Property Separator As String
			Get
				Return Me.oO.OO..Separator
			End Get
			Set(value As String)
				If value IsNot Nothing AndAlso value.Length = 1 Then
					Me.oO.OO..Separator = value
				End If
			End Set
		End Property

		' Token: 0x17000A6E RID: 2670
		' (get) Token: 0x06002BBB RID: 11195 RVA: 0x0013038C File Offset: 0x0012E58C
		' (set) Token: 0x06002BBC RID: 11196 RVA: 0x00130399 File Offset: 0x0012E599
		<O_Oo00Oo000O0(8.21)>
		<DisplayName("存放目录")>
		<Description("指定文件或者图片列附件的存放目录名称。")>
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<Category("扩展")>
		Public Property FolderName As String
			Get
				Return Me.oO.OO..DefaultFolder
			End Get
			Set(value As String)
				Me.oO.OO..DefaultFolder = value
			End Set
		End Property

		' Token: 0x17000A6F RID: 2671
		' (get) Token: 0x06002BBD RID: 11197 RVA: 0x001303A7 File Offset: 0x0012E5A7
		' (set) Token: 0x06002BBE RID: 11198 RVA: 0x001303B4 File Offset: 0x0012E5B4
		<DisplayName("来源目录")>
		<O_Oo00Oo000O0(8.22)>
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<Description("指定增加文件时，默认从什么目录选择文件。")>
		<Category("扩展")>
		Public Property SourceFolder As String
			Get
				Return Me.oO.OO..SourceFolder
			End Get
			Set(value As String)
				Me.oO.OO..SourceFolder = value
			End Set
		End Property

		' Token: 0x17000A70 RID: 2672
		' (get) Token: 0x06002BBF RID: 11199 RVA: 0x001303C2 File Offset: 0x0012E5C2
		' (set) Token: 0x06002BC0 RID: 11200 RVA: 0x001303CF File Offset: 0x0012E5CF
		<Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")>
		<DefaultValue(1)>
		<DisplayName("自动复制附件")>
		<O_Oo00Oo000O0(8.3)>
		<Category("扩展")>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.oO.OO..AutoCopyAttachFile
			End Get
			Set(value As BooleanEnum)
				Me.oO.OO..AutoCopyAttachFile = value
			End Set
		End Property

		' Token: 0x17000A71 RID: 2673
		' (get) Token: 0x06002BC1 RID: 11201 RVA: 0x001303DD File Offset: 0x0012E5DD
		' (set) Token: 0x06002BC2 RID: 11202 RVA: 0x001303EA File Offset: 0x0012E5EA
		<DefaultValue(2)>
		<O_Oo00Oo000O0(8.3)>
		<Category("扩展")>
		<DisplayName("自动删除附件")>
		<Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.oO.OO..AutoDeleteAttachFile
			End Get
			Set(value As BooleanEnum)
				Me.oO.OO..AutoDeleteAttachFile = value
			End Set
		End Property

		' Token: 0x17000A72 RID: 2674
		' (get) Token: 0x06002BC3 RID: 11203 RVA: 0x001303F8 File Offset: 0x0012E5F8
		' (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00130405 File Offset: 0x0012E605
		<O_Oo00Oo000O0(8.4)>
		<Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*" & vbCrLf & "筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")>
		<Category("扩展")>
		<DisplayName("文件类型筛选")>
		Public Property FileFilter As String
			Get
				Return Me.oO.OO..FileFilter
			End Get
			Set(value As String)
				Me.oO.OO..FileFilter = value
			End Set
		End Property

		' Token: 0x17000A73 RID: 2675
		' (get) Token: 0x06002BC5 RID: 11205 RVA: 0x00130413 File Offset: 0x0012E613
		' (set) Token: 0x06002BC6 RID: 11206 RVA: 0x00130420 File Offset: 0x0012E620
		<O_Oo00Oo000O0(8.5)>
		<Description("是否自动下载远程图片。")>
		<DefaultValue(True)>
		<Category("扩展")>
		<DisplayName("自动下载图片")>
		Public Property AutoDownload As Boolean
			Get
				Return Me.oO.OO..AutoDownload
			End Get
			Set(value As Boolean)
				Me.oO.OO..AutoDownload = value
			End Set
		End Property

		' Token: 0x17000A74 RID: 2676
		' (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0013042E File Offset: 0x0012E62E
		' (set) Token: 0x06002BC8 RID: 11208 RVA: 0x0013043B File Offset: 0x0012E63B
		<DisplayName("自动更新文件")>
		<O_Oo00Oo000O0(8.6)>
		<Category("扩展")>
		<Description("是否自动更新远程文件")>
		<DefaultValue(True)>
		Public Property AutoUpdate As Boolean
			Get
				Return Me.oO.OO..AutoUpdate
			End Get
			Set(value As Boolean)
				Me.oO.OO..AutoUpdate = value
			End Set
		End Property

		' Token: 0x17000A75 RID: 2677
		' (get) Token: 0x06002BC9 RID: 11209 RVA: 0x00130449 File Offset: 0x0012E649
		' (set) Token: 0x06002BCA RID: 11210 RVA: 0x00130456 File Offset: 0x0012E656
		<DefaultValue(4)>
		<O_Oo00Oo000O0(1.0)>
		<Category("数值格式")>
		<DisplayName("最大小数位数")>
		<Description("表中允许显示的最大小数位数，此设置不会影响现有数据的值，而对于新输入的数据，将删除多余的小数部分。")>
		Public Property Decimals As Integer
			Get
				Return Me.oO.OO..Decimals
			End Get
			Set(value As Integer)
				Me.oO.OO..Decimals = value
			End Set
		End Property

		' Token: 0x17000A76 RID: 2678
		' (get) Token: 0x06002BCB RID: 11211 RVA: 0x00130464 File Offset: 0x0012E664
		' (set) Token: 0x06002BCC RID: 11212 RVA: 0x00130471 File Offset: 0x0012E671
		<O_Oo00Oo000O0(1.1)>
		<DefaultValue(False)>
		<Description("当数据的实际小数位数小于""最大小数位数""的设置值时，是否用0补充。")>
		<DisplayName("固定小数位数")>
		<Category("数值格式")>
		Public Property FixedDecimals As Boolean
			Get
				Return Me.oO.OO..FixedDecimals
			End Get
			Set(value As Boolean)
				Me.oO.OO..FixedDecimals = value
			End Set
		End Property

		' Token: 0x17000A77 RID: 2679
		' (get) Token: 0x06002BCD RID: 11213 RVA: 0x0013047F File Offset: 0x0012E67F
		' (set) Token: 0x06002BCE RID: 11214 RVA: 0x0013048C File Offset: 0x0012E68C
		<DefaultValue(0)>
		<DisplayName("固定整数位数")>
		<O_Oo00Oo000O0(1.2)>
		<Category("数值格式")>
		<Description("设置在小数点左边固定显示的整数位数，例如此属性设为3，数值1将显示为""001""。默认值为0，表示不固定。")>
		Public Property FixedDigits As Integer
			Get
				Return Me.oO.OO..FixedDigits
			End Get
			Set(value As Integer)
				Me.oO.OO..FixedDigits = value
			End Set
		End Property

		' Token: 0x17000A78 RID: 2680
		' (get) Token: 0x06002BCF RID: 11215 RVA: 0x0013049A File Offset: 0x0012E69A
		' (set) Token: 0x06002BD0 RID: 11216 RVA: 0x001304A7 File Offset: 0x0012E6A7
		<DisplayName("显示千位分隔符")>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(False)>
		<Category("数值格式")>
		Public Property ThousandSeparator As Boolean
			Get
				Return Me.oO.OO..ThousandSeparator
			End Get
			Set(value As Boolean)
				Me.oO.OO..ThousandSeparator = value
			End Set
		End Property

		' Token: 0x17000A79 RID: 2681
		' (get) Token: 0x06002BD1 RID: 11217 RVA: 0x001304B5 File Offset: 0x0012E6B5
		' (set) Token: 0x06002BD2 RID: 11218 RVA: 0x001304C2 File Offset: 0x0012E6C2
		<Category("数值格式")>
		<DisplayName("按百分比格式显示")>
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(False)>
		Public Property PercentStyle As Boolean
			Get
				Return Me.oO.OO..PercentStyle
			End Get
			Set(value As Boolean)
				Me.oO.OO..PercentStyle = value
			End Set
		End Property

		' Token: 0x17000A7A RID: 2682
		' (get) Token: 0x06002BD3 RID: 11219 RVA: 0x001304D0 File Offset: 0x0012E6D0
		' (set) Token: 0x06002BD4 RID: 11220 RVA: 0x001304DD File Offset: 0x0012E6DD
		<DisplayName("显示货币符号")>
		<DefaultValue(False)>
		<Category("数值格式")>
		<O_Oo00Oo000O0(4.0)>
		Public Property ShowCurrencySymbol As Boolean
			Get
				Return Me.oO.OO..ShowCurrencySymbol
			End Get
			Set(value As Boolean)
				Me.oO.OO..ShowCurrencySymbol = value
			End Set
		End Property

		' Token: 0x17000A7B RID: 2683
		' (get) Token: 0x06002BD5 RID: 11221 RVA: 0x001304EB File Offset: 0x0012E6EB
		' (set) Token: 0x06002BD6 RID: 11222 RVA: 0x001304F8 File Offset: 0x0012E6F8
		<Category("数值格式")>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("自定义货币符号")>
		<Description("货币符号默认为人民币符号，可利用此属性设置为其他货币符号。")>
		Public Property CurrencySymbol As String
			Get
				Return Me.oO.OO..CurrencySymbol
			End Get
			Set(value As String)
				Me.oO.OO..CurrencySymbol = value
			End Set
		End Property

		' Token: 0x17000A7C RID: 2684
		' (get) Token: 0x06002BD7 RID: 11223 RVA: 0x00130506 File Offset: 0x0012E706
		' (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00130513 File Offset: 0x0012E713
		<O_Oo00Oo000O0(15.0)>
		<Category("列窗口")>
		<DisplayName("停靠位置")>
		<DefaultValue(0)>
		Public Property DockArea As DockAreaEnum
			Get
				Return Me.oO.OO..DockArea
			End Get
			Set(value As DockAreaEnum)
				Me.oO.OO..DockArea = value
			End Set
		End Property

		' Token: 0x17000A7D RID: 2685
		' (get) Token: 0x06002BD9 RID: 11225 RVA: 0x00130521 File Offset: 0x0012E721
		' (set) Token: 0x06002BDA RID: 11226 RVA: 0x0013052E File Offset: 0x0012E72E
		<O_Oo00Oo000O0(16.0)>
		<DefaultValue(False)>
		<Category("列窗口")>
		<DisplayName("独立停靠")>
		Public Property DockTitle As Boolean
			Get
				Return Me.oO.OO..DockTitle
			End Get
			Set(value As Boolean)
				Me.oO.OO..DockTitle = value
			End Set
		End Property

		' Token: 0x17000A7E RID: 2686
		' (get) Token: 0x06002BDB RID: 11227 RVA: 0x0013053C File Offset: 0x0012E73C
		' (set) Token: 0x06002BDC RID: 11228 RVA: 0x00130549 File Offset: 0x0012E749
		<DisplayName("自动打开")>
		<Category("列窗口")>
		<O_Oo00Oo000O0(17.0)>
		<Description("打开项目的时候，是否自动打开此列窗口！")>
		<DefaultValue(True)>
		Public Property AutoOpen As Boolean
			Get
				Return Me.oO.OO..AutoOpen
			End Get
			Set(value As Boolean)
				Me.oO.OO..AutoOpen = value
			End Set
		End Property

		' Token: 0x17000A7F RID: 2687
		' (get) Token: 0x06002BDD RID: 11229 RVA: 0x00130557 File Offset: 0x0012E757
		' (set) Token: 0x06002BDE RID: 11230 RVA: 0x00130564 File Offset: 0x0012E764
		<DisplayName("自动隐藏")>
		<O_Oo00Oo000O0(18.0)>
		<Category("列窗口")>
		<DefaultValue(False)>
		Public Property AutoHide As Boolean
			Get
				Return Me.oO.OO..AutoHide
			End Get
			Set(value As Boolean)
				Me.oO.OO..AutoHide = value
			End Set
		End Property

		' Token: 0x17000A80 RID: 2688
		' (get) Token: 0x06002BDF RID: 11231 RVA: 0x00130572 File Offset: 0x0012E772
		' (set) Token: 0x06002BE0 RID: 11232 RVA: 0x0013057F File Offset: 0x0012E77F
		<DefaultValue(True)>
		<O_Oo00Oo000O0(19.0)>
		<Category("列窗口")>
		<DisplayName("显示标题")>
		Public Property ShowCaption As Boolean
			Get
				Return Me.oO.OO..ShowCaption
			End Get
			Set(value As Boolean)
				Me.oO.OO..ShowCaption = value
			End Set
		End Property

		' Token: 0x17000A81 RID: 2689
		' (get) Token: 0x06002BE1 RID: 11233 RVA: 0x0013058D File Offset: 0x0012E78D
		' (set) Token: 0x06002BE2 RID: 11234 RVA: 0x0013059A File Offset: 0x0012E79A
		<DisplayName("允许关闭")>
		<O_Oo00Oo000O0(20.0)>
		<Category("列窗口")>
		<DefaultValue(True)>
		Public Property AllowClose As Boolean
			Get
				Return Me.oO.OO..AllowClose
			End Get
			Set(value As Boolean)
				Me.oO.OO..AllowClose = value
			End Set
		End Property

		' Token: 0x17000A82 RID: 2690
		' (get) Token: 0x06002BE3 RID: 11235 RVA: 0x001305A8 File Offset: 0x0012E7A8
		' (set) Token: 0x06002BE4 RID: 11236 RVA: 0x001305B5 File Offset: 0x0012E7B5
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<Description("此属性需要重新打开窗口才会生效！")>
		<O_Oo00Oo000O0(21.0)>
		<Category("列窗口")>
		<DisplayName("自定义图标")>
		Public Property DockImage As String
			Get
				Return Me.oO.OO..CustomImage
			End Get
			Set(value As String)
				Me.oO.OO..CustomImage = value
			End Set
		End Property

		' Token: 0x17000A83 RID: 2691
		' (get) Token: 0x06002BE5 RID: 11237 RVA: 0x001305C3 File Offset: 0x0012E7C3
		' (set) Token: 0x06002BE6 RID: 11238 RVA: 0x001305D0 File Offset: 0x0012E7D0
		<DefaultValue(True)>
		<O_Oo00Oo000O0(6.0)>
		<Category("列表项目")>
		<DisplayName("允许直接输入")>
		<MergableProperty(False)>
		<Description("允许用户直接输入不在列表项目中的值")>
		Public Property AllowEditValue As Boolean
			Get
				Return Me.oO.OO..AllowEditValue
			End Get
			Set(value As Boolean)
				Me.oO.OO..AllowEditValue = value
			End Set
		End Property

		' Token: 0x17000A84 RID: 2692
		' (get) Token: 0x06002BE7 RID: 11239 RVA: 0x001305DE File Offset: 0x0012E7DE
		' (set) Token: 0x06002BE8 RID: 11240 RVA: 0x001305EB File Offset: 0x0012E7EB
		<O_Oo00Oo000O0(6.1)>
		<Description("在手工输入的时候，是否提供相似项目协助用户完成输入。")>
		<MergableProperty(False)>
		<DefaultValue(False)>
		<DisplayName("启用输入助手")>
		<Category("列表项目")>
		Public Property AutoComplete As Boolean
			Get
				Return Me.oO.OO..AutoComplete
			End Get
			Set(value As Boolean)
				Me.oO.OO..AutoComplete = value
			End Set
		End Property

		' Token: 0x17000A85 RID: 2693
		' (get) Token: 0x06002BE9 RID: 11241 RVA: 0x001305F9 File Offset: 0x0012E7F9
		' (set) Token: 0x06002BEA RID: 11242 RVA: 0x00130606 File Offset: 0x0012E806
		<O_Oo00Oo000O0(1.0)>
		<Category("列表项目")>
		<DisplayName("自定义项目")>
		<Editor(GetType(ooO0o0_oO0_0), GetType(UITypeEditor))>
		<Description("可将常见值设置在列表项目中，输入的时候会自动出现一个下拉列表框，供用户选择，不同的值之间用符号|隔开，例如：博士|硕士|本科")>
		Public Property ComboList As String
			Get
				Return Me.oO.OO..ComboList
			End Get
			Set(value As String)
				Me.oO.OO..ComboList = value
			End Set
		End Property

		' Token: 0x17000A86 RID: 2694
		' (get) Token: 0x06002BEB RID: 11243 RVA: 0x00130614 File Offset: 0x0012E814
		' (set) Token: 0x06002BEC RID: 11244 RVA: 0x00130621 File Offset: 0x0012E821
		<TypeConverter(GetType(oo0OOO_0__))>
		<MergableProperty(False)>
		<Category("列表项目")>
		<DisplayName("显示列")>
		<O_Oo00Oo000O0(3.0)>
		Public Property DisplayMember As String
			Get
				Return Me.oO.OO..DisplayMember
			End Get
			Set(value As String)
				Me.oO.OO..DisplayMember = value
				If Operators.CompareString(Me.oO.OO..ValueMember, "", True) = 0 Then
					Me.oO.OO..ValueMember = value
				End If
			End Set
		End Property

		' Token: 0x17000A87 RID: 2695
		' (get) Token: 0x06002BED RID: 11245 RVA: 0x00130653 File Offset: 0x0012E853
		' (set) Token: 0x06002BEE RID: 11246 RVA: 0x00130660 File Offset: 0x0012E860
		<MergableProperty(False)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("取值列")>
		<Category("列表项目")>
		Public Property ValueMember As String
			Get
				Return Me.oO.OO..ValueMember
			End Get
			Set(value As String)
				Me.oO.OO..ValueMember = value
				If Operators.CompareString(Me.oO.OO..DisplayMember, "", True) = 0 Then
					Me.oO.OO..DisplayMember = value
				End If
			End Set
		End Property

		' Token: 0x17000A88 RID: 2696
		' (get) Token: 0x06002BEF RID: 11247 RVA: 0x00130692 File Offset: 0x0012E892
		' (set) Token: 0x06002BF0 RID: 11248 RVA: 0x0013069F File Offset: 0x0012E89F
		<Ooo0___("目录树文件(*.foxtr)|*.foxtr")>
		<Category("目录树列表")>
		<DisplayName("目录树文件")>
		<O_Oo00Oo000O0(1.0)>
		<Editor(GetType(O0_000oo), GetType(UITypeEditor))>
		Public Property TreeFile As String
			Get
				Return Me.oO.OO..TreeFile
			End Get
			Set(value As String)
				Me.oO.OO..TreeFile = value
			End Set
		End Property

		' Token: 0x17000A89 RID: 2697
		' (get) Token: 0x06002BF1 RID: 11249 RVA: 0x001306AD File Offset: 0x0012E8AD
		' (set) Token: 0x06002BF2 RID: 11250 RVA: 0x001306BA File Offset: 0x0012E8BA
		<Category("目录树列表")>
		<O_Oo00Oo000O0(2.0)>
		<TypeConverter(GetType(OoO_O0_OO0))>
		<Description("根据此表数据生成目录树")>
		<DisplayName("目录树表")>
		Public Property TreeDataTable As String
			Get
				Return Me.oO.OO..TreeSourceTable
			End Get
			Set(value As String)
				Me.oO.OO..TreeSourceTable = value
			End Set
		End Property

		' Token: 0x17000A8A RID: 2698
		' (get) Token: 0x06002BF3 RID: 11251 RVA: 0x001306C8 File Offset: 0x0012E8C8
		' (set) Token: 0x06002BF4 RID: 11252 RVA: 0x001306D5 File Offset: 0x0012E8D5
		<Description("指定用于生成目录树的列，不同的列用符号""|""隔开，例如: 产品|客户")>
		<Category("目录树列表")>
		<DisplayName("目录树列")>
		<Editor(GetType(O00_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(3.0)>
		Public Property TreeBuildCols As String
			Get
				Return Me.oO.OO..TreeBuildCols
			End Get
			Set(value As String)
				Me.oO.OO..TreeBuildCols = value
			End Set
		End Property

		' Token: 0x17000A8B RID: 2699
		' (get) Token: 0x06002BF5 RID: 11253 RVA: 0x001306E3 File Offset: 0x0012E8E3
		' (set) Token: 0x06002BF6 RID: 11254 RVA: 0x001306F0 File Offset: 0x0012E8F0
		<DisplayName("数据来源列")>
		<O_Oo00Oo000O0(4.0)>
		<Description("指定用于提交数据的列，不同的列用符号""|""隔开，例如: 产品|客户")>
		<Editor(GetType(O00_), GetType(UITypeEditor))>
		<Category("目录树列表")>
		Public Property TreeSourceCols As String
			Get
				Return Me.oO.OO..TreeSourceCols
			End Get
			Set(value As String)
				Me.oO.OO..TreeSourceCols = value
			End Set
		End Property

		' Token: 0x17000A8C RID: 2700
		' (get) Token: 0x06002BF7 RID: 11255 RVA: 0x001306FE File Offset: 0x0012E8FE
		' (set) Token: 0x06002BF8 RID: 11256 RVA: 0x0013070B File Offset: 0x0012E90B
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(O00_), GetType(UITypeEditor))>
		<Category("目录树列表")>
		<Description("指定用于接收数据的列，不同的列用符号""|""隔开，例如: 产品|客户")>
		<DisplayName("数据接收列")>
		Public Property TreeReceiveCols As String
			Get
				Return Me.oO.OO..TreeReceiveCols
			End Get
			Set(value As String)
				Me.oO.OO..TreeReceiveCols = value
			End Set
		End Property

		' Token: 0x17000A8D RID: 2701
		' (get) Token: 0x06002BF9 RID: 11257 RVA: 0x00130719 File Offset: 0x0012E919
		' (set) Token: 0x06002BFA RID: 11258 RVA: 0x00130726 File Offset: 0x0012E926
		<O_Oo00Oo000O0(5.1)>
		<DisplayName("过滤条件")>
		<Category("目录树列表")>
		Public Property TreeFilter As String
			Get
				Return Me.oO.OO..TreeFilter
			End Get
			Set(value As String)
				Me.oO.OO..TreeFilter = value
			End Set
		End Property

		' Token: 0x17000A8E RID: 2702
		' (get) Token: 0x06002BFB RID: 11259 RVA: 0x00130734 File Offset: 0x0012E934
		' (set) Token: 0x06002BFC RID: 11260 RVA: 0x00130741 File Offset: 0x0012E941
		<OooO0(True)>
		<DefaultValue(0)>
		<O_Oo00Oo000O0(6.0)>
		<DisplayName("目录树宽度")>
		<Category("目录树列表")>
		Public Property TreeWidth As Integer
			Get
				Return Me.oO.OO..DropDownWidth
			End Get
			Set(value As Integer)
				Me.oO.OO..DropDownWidth = value
			End Set
		End Property

		' Token: 0x17000A8F RID: 2703
		' (get) Token: 0x06002BFD RID: 11261 RVA: 0x0013074F File Offset: 0x0012E94F
		' (set) Token: 0x06002BFE RID: 11262 RVA: 0x0013075C File Offset: 0x0012E95C
		<Category("目录树列表")>
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(0)>
		<DisplayName("目录树高度")>
		<OooO0(True)>
		Public Property TreeHeight As Integer
			Get
				Return Me.oO.OO..DropDownHeight
			End Get
			Set(value As Integer)
				Me.oO.OO..DropDownHeight = value
			End Set
		End Property

		' Token: 0x17000A90 RID: 2704
		' (get) Token: 0x06002BFF RID: 11263 RVA: 0x0013076A File Offset: 0x0012E96A
		' (set) Token: 0x06002C00 RID: 11264 RVA: 0x00130777 File Offset: 0x0012E977
		<DefaultValue("\"c)>
		<DisplayName("路径分割符")>
		<O_Oo00Oo000O0(8.0)>
		<Category("目录树列表")>
		Public Property TreePathSeparator As Char
			Get
				Return Me.oO.OO..TreePathSeparator
			End Get
			Set(value As Char)
				Me.oO.OO..TreePathSeparator = value
			End Set
		End Property

		' Token: 0x17000A91 RID: 2705
		' (get) Token: 0x06002C01 RID: 11265 RVA: 0x00130785 File Offset: 0x0012E985
		' (set) Token: 0x06002C02 RID: 11266 RVA: 0x00130792 File Offset: 0x0012E992
		<DisplayName("分割内容")>
		<O_Oo00Oo000O0(9.0)>
		<DefaultValue(False)>
		<Category("目录树列表")>
		Public Property TreeSeparateContent As Boolean
			Get
				Return Me.oO.OO..TreeSeparateContent
			End Get
			Set(value As Boolean)
				Me.oO.OO..TreeSeparateContent = value
			End Set
		End Property

		' Token: 0x17000A92 RID: 2706
		' (get) Token: 0x06002C03 RID: 11267 RVA: 0x001307A0 File Offset: 0x0012E9A0
		' (set) Token: 0x06002C04 RID: 11268 RVA: 0x001307AD File Offset: 0x0012E9AD
		<DefaultValue("|"c)>
		<O_Oo00Oo000O0(10.0)>
		<Category("目录树列表")>
		<DisplayName("内容分割符")>
		Public Property TreeContentSeparator As Char
			Get
				Return Me.oO.OO..TreeContentSeparator
			End Get
			Set(value As Char)
				Me.oO.OO..TreeContentSeparator = value
			End Set
		End Property

		' Token: 0x17000A93 RID: 2707
		' (get) Token: 0x06002C05 RID: 11269 RVA: 0x001307BB File Offset: 0x0012E9BB
		' (set) Token: 0x06002C06 RID: 11270 RVA: 0x001307C8 File Offset: 0x0012E9C8
		<MergableProperty(False)>
		<DisplayName("数据表")>
		<O_Oo00Oo000O0(2.0)>
		<Description("候选项目来源表")>
		<Category("列表项目")>
		<TypeConverter(GetType(OoO_O0_OO0))>
		Public Property DataSource As String
			Get
				Return Me.oO.OO..DataSource
			End Get
			Set(value As String)
				Me.oO.OO..DataSource = value
				If Operators.CompareString(value, "", True) = 0 Then
					Me.ValueMember = ""
					Me.DisplayMember = ""
					Return
				End If
				Dim dataSet As DataSet = Me.oO.OO..BaseColumn.Table.DataSet
				If dataSet IsNot Nothing AndAlso dataSet.Tables.Contains(value) Then
					If Operators.CompareString(Me.DisplayMember, "", True) > 0 AndAlso Not dataSet.Tables(value).Columns.Contains(Me.DisplayMember) Then
						Me.DisplayMember = ""
					End If
					If Operators.CompareString(Me.ValueMember, "", True) > 0 AndAlso Not dataSet.Tables(value).Columns.Contains(Me.ValueMember) Then
						Me.ValueMember = ""
					End If
				End If
			End Set
		End Property

		' Token: 0x17000A94 RID: 2708
		' (get) Token: 0x06002C07 RID: 11271 RVA: 0x001308AA File Offset: 0x0012EAAA
		' (set) Token: 0x06002C08 RID: 11272 RVA: 0x001308B7 File Offset: 0x0012EAB7
		<O_Oo00Oo000O0(5.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		<Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")>
		<DisplayName("过滤条件")>
		<Editor(GetType(O0O00), GetType(UITypeEditor))>
		Public Property DataFilter As String
			Get
				Return Me.oO.OO..DataFilter
			End Get
			Set(value As String)
				Me.oO.OO..DataFilter = value
			End Set
		End Property

		' Token: 0x17000A95 RID: 2709
		' (get) Token: 0x06002C09 RID: 11273 RVA: 0x001308C5 File Offset: 0x0012EAC5
		' (set) Token: 0x06002C0A RID: 11274 RVA: 0x001308D2 File Offset: 0x0012EAD2
		<O_Oo00Oo000O0(5.1)>
		<MergableProperty(False)>
		<TypeConverter(GetType(oo0OOO_0__))>
		<DisplayName("排序方式")>
		<Description("用于设置下拉列表行的排序方式！")>
		<Category("列表项目")>
		Public Property DataSort As String
			Get
				Return Me.oO.OO..DataSort
			End Get
			Set(value As String)
				Me.oO.OO..DataSort = value
			End Set
		End Property

		' Token: 0x17000A96 RID: 2710
		' (get) Token: 0x06002C0B RID: 11275 RVA: 0x001308E0 File Offset: 0x0012EAE0
		' (set) Token: 0x06002C0C RID: 11276 RVA: 0x001308ED File Offset: 0x0012EAED
		<MergableProperty(False)>
		<O_Oo00Oo000O0(7.0)>
		<Category("列表项目")>
		<Description("是否分多列显示项目。")>
		<DefaultValue(False)>
		<DisplayName("多列显示")>
		Public Property MultiColumn As Boolean
			Get
				Return Me.oO.OO..MultiColumn
			End Get
			Set(value As Boolean)
				Me.oO.OO..MultiColumn = value
			End Set
		End Property

		' Token: 0x17000A97 RID: 2711
		' (get) Token: 0x06002C0D RID: 11277 RVA: 0x001308FB File Offset: 0x0012EAFB
		' (set) Token: 0x06002C0E RID: 11278 RVA: 0x00130908 File Offset: 0x0012EB08
		<DisplayName("每列宽度")>
		<Description("设置多列显示时，各列的宽度。")>
		<Category("列表项目")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(8.0)>
		<DefaultValue(0)>
		Public Property ColumnWidth As Integer
			Get
				Return Me.oO.OO..ColumnWidth
			End Get
			Set(value As Integer)
				Me.oO.OO..ColumnWidth = value
			End Set
		End Property

		' Token: 0x17000A98 RID: 2712
		' (get) Token: 0x06002C0F RID: 11279 RVA: 0x00130916 File Offset: 0x0012EB16
		' (set) Token: 0x06002C10 RID: 11280 RVA: 0x00130923 File Offset: 0x0012EB23
		<DefaultValue(0)>
		<O_Oo00Oo000O0(10.0)>
		<DisplayName("下拉宽度")>
		<Category("列表项目")>
		<Description("指定下拉列表的宽度，设为0使用默认宽度")>
		<MergableProperty(False)>
		Public Property DropDownWidth As Integer
			Get
				Return Me.oO.OO..DropDownWidth
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(60, value)
				End If
				Me.oO.OO..DropDownWidth = value
			End Set
		End Property

		' Token: 0x17000A99 RID: 2713
		' (get) Token: 0x06002C11 RID: 11281 RVA: 0x0013093E File Offset: 0x0012EB3E
		' (set) Token: 0x06002C12 RID: 11282 RVA: 0x0013094B File Offset: 0x0012EB4B
		<Description("指定下拉列表的高度，设为0使用默认高度")>
		<O_Oo00Oo000O0(11.0)>
		<Category("列表项目")>
		<MergableProperty(False)>
		<DefaultValue(0)>
		<DisplayName("下拉高度")>
		Public Property DropDownHeight As Integer
			Get
				Return Me.oO.OO..DropDownHeight
			End Get
			Set(value As Integer)
				If value <> 0 Then
					value = Math.Max(28, value)
				End If
				Me.oO.OO..DropDownHeight = value
			End Set
		End Property

		' Token: 0x17000A9A RID: 2714
		' (get) Token: 0x06002C13 RID: 11283 RVA: 0x00130966 File Offset: 0x0012EB66
		' (set) Token: 0x06002C14 RID: 11284 RVA: 0x00130973 File Offset: 0x0012EB73
		<Category("列表项目")>
		<Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示")>
		<MergableProperty(False)>
		<DefaultValue(11)>
		<O_Oo00Oo000O0(12.0)>
		<DisplayName("最多显示项目数")>
		Public Property MaxDropDownItems As Integer
			Get
				Return Me.oO.OO..MaxDropDownItems
			End Get
			Set(value As Integer)
				value = Math.Max(1, value)
				Me.oO.OO..MaxDropDownItems = value
			End Set
		End Property

		' Token: 0x17000A9B RID: 2715
		' (get) Token: 0x06002C15 RID: 11285 RVA: 0x0013098A File Offset: 0x0012EB8A
		' (set) Token: 0x06002C16 RID: 11286 RVA: 0x00130997 File Offset: 0x0012EB97
		<Category("列表项目")>
		<O_Oo00Oo000O0(13.0)>
		<Description("列表项目间距，单位为像素")>
		<MergableProperty(True)>
		<DefaultValue(6)>
		<DisplayName("项目间距")>
		Public Property ItemSpacing As Integer
			Get
				Return Me.oO.OO..ItemSpacing
			End Get
			Set(value As Integer)
				Me.oO.OO..ItemSpacing = value
			End Set
		End Property

		' Token: 0x17000A9C RID: 2716
		' (get) Token: 0x06002C17 RID: 11287 RVA: 0x001309A5 File Offset: 0x0012EBA5
		' (set) Token: 0x06002C18 RID: 11288 RVA: 0x001309B2 File Offset: 0x0012EBB2
		<O_Oo00Oo000O0(7.0)>
		<DefaultValue(0)>
		<Category("字典")>
		<Description("通过数据字典，可将数据显示为描述性的文本。")>
		<DisplayName("数据字典")>
		Public Property DataMapType As DataMapTypeEnum
			Get
				Return Me.oO.OO..DataMapType
			End Get
			Set(value As DataMapTypeEnum)
				Me.oO.OO..DataMapType = value
			End Set
		End Property

		' Token: 0x17000A9D RID: 2717
		' (get) Token: 0x06002C19 RID: 11289 RVA: 0x001309C0 File Offset: 0x0012EBC0
		' (set) Token: 0x06002C1A RID: 11290 RVA: 0x001309CD File Offset: 0x0012EBCD
		<Description("通过图片字典，可将数据显示为图形")>
		<DefaultValue(0)>
		<Category("字典")>
		<DisplayName("图形字典")>
		<O_Oo00Oo000O0(8.0)>
		Public Property ImageMapType As ImageMapTypeEnum
			Get
				Return Me.oO.OO..ImageMapType
			End Get
			Set(value As ImageMapTypeEnum)
				Me.oO.OO..ImageMapType = value
			End Set
		End Property

		' Token: 0x17000A9E RID: 2718
		' (get) Token: 0x06002C1B RID: 11291 RVA: 0x001309DB File Offset: 0x0012EBDB
		' (set) Token: 0x06002C1C RID: 11292 RVA: 0x001309E8 File Offset: 0x0012EBE8
		<Category("字典")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(9.0)>
		<DisplayName("文本和图形")>
		<Description("如果设置了图形字典，在单元格中是同时显示文字和图形，还是仅仅显示图形。")>
		Public Property ImageAndText As Boolean
			Get
				Return Me.oO.OO..ImageAndText
			End Get
			Set(value As Boolean)
				Me.oO.OO..ImageAndText = value
			End Set
		End Property

		' Token: 0x17000A9F RID: 2719
		' (get) Token: 0x06002C1D RID: 11293 RVA: 0x001309F6 File Offset: 0x0012EBF6
		' (set) Token: 0x06002C1E RID: 11294 RVA: 0x00130A03 File Offset: 0x0012EC03
		<Browsable(False)>
		<DefaultValue("")>
		Public Property DataMap As String
			Get
				Return Me.oO.OO..DataMap
			End Get
			Set(value As String)
				Me.oO.OO..DataMap = value
			End Set
		End Property

		' Token: 0x17000AA0 RID: 2720
		' (get) Token: 0x06002C1F RID: 11295 RVA: 0x00130A11 File Offset: 0x0012EC11
		' (set) Token: 0x06002C20 RID: 11296 RVA: 0x00130A1E File Offset: 0x0012EC1E
		<DefaultValue("")>
		<Browsable(False)>
		Public Property ImageMap As String
			Get
				Return Me.oO.OO..ImageMap
			End Get
			Set(value As String)
				Me.oO.OO..ImageMap = value
			End Set
		End Property

		' Token: 0x17000AA1 RID: 2721
		' (get) Token: 0x06002C21 RID: 11297 RVA: 0x00130A2C File Offset: 0x0012EC2C
		' (set) Token: 0x06002C22 RID: 11298 RVA: 0x00130A39 File Offset: 0x0012EC39
		<DefaultValue("")>
		<Browsable(False)>
		Public Property DataMapTable As String
			Get
				Return Me.oO.OO..DataMapTable
			End Get
			Set(value As String)
				Me.oO.OO..DataMapTable = value
			End Set
		End Property

		' Token: 0x17000AA2 RID: 2722
		' (get) Token: 0x06002C23 RID: 11299 RVA: 0x00130A47 File Offset: 0x0012EC47
		' (set) Token: 0x06002C24 RID: 11300 RVA: 0x00130A54 File Offset: 0x0012EC54
		<DefaultValue("")>
		<Browsable(False)>
		Public Property DataMapListColumns As String
			Get
				Return Me.oO.OO..DataMapListColumns
			End Get
			Set(value As String)
				Me.oO.OO..DataMapListColumns = value
			End Set
		End Property

		' Token: 0x17000AA3 RID: 2723
		' (get) Token: 0x06002C25 RID: 11301 RVA: 0x00130A62 File Offset: 0x0012EC62
		' (set) Token: 0x06002C26 RID: 11302 RVA: 0x00130A6F File Offset: 0x0012EC6F
		<DefaultValue("")>
		<Browsable(False)>
		Public Property DataMapValueColumn As String
			Get
				Return Me.oO.OO..DataMapValueColumn
			End Get
			Set(value As String)
				Me.oO.OO..DataMapValueColumn = value
			End Set
		End Property

		' Token: 0x17000AA4 RID: 2724
		' (get) Token: 0x06002C27 RID: 11303 RVA: 0x00130A7D File Offset: 0x0012EC7D
		' (set) Token: 0x06002C28 RID: 11304 RVA: 0x00130A8A File Offset: 0x0012EC8A
		<DefaultValue("")>
		<Browsable(False)>
		Public Property DataMapListColumn As String
			Get
				Return Me.oO.OO..DataMapListColumn
			End Get
			Set(value As String)
				Me.oO.OO..DataMapListColumn = value
			End Set
		End Property

		' Token: 0x17000AA5 RID: 2725
		' (get) Token: 0x06002C29 RID: 11305 RVA: 0x00130A98 File Offset: 0x0012EC98
		' (set) Token: 0x06002C2A RID: 11306 RVA: 0x00130AA5 File Offset: 0x0012ECA5
		<Browsable(False)>
		<DefaultValue("")>
		Public Property DataMapFilter As String
			Get
				Return Me.oO.OO..DataMapFilter
			End Get
			Set(value As String)
				Me.oO.OO..DataMapFilter = value
			End Set
		End Property

		' Token: 0x17000AA6 RID: 2726
		' (get) Token: 0x06002C2B RID: 11307 RVA: 0x00130AB3 File Offset: 0x0012ECB3
		' (set) Token: 0x06002C2C RID: 11308 RVA: 0x00130AC0 File Offset: 0x0012ECC0
		<Browsable(False)>
		<DefaultValue("")>
		Public Property DataMapSort As String
			Get
				Return Me.oO.OO..DataMapSort
			End Get
			Set(value As String)
				Me.oO.OO..DataMapSort = value
			End Set
		End Property

		' Token: 0x17000AA7 RID: 2727
		' (get) Token: 0x06002C2D RID: 11309 RVA: 0x00130ACE File Offset: 0x0012ECCE
		' (set) Token: 0x06002C2E RID: 11310 RVA: 0x00130ADB File Offset: 0x0012ECDB
		<Browsable(False)>
		<DefaultValue("")>
		Public Property MultiDataMap As String
			Get
				Return Me.oO.OO..MultiDataMap
			End Get
			Set(value As String)
				Me.oO.OO..MultiDataMap = value
			End Set
		End Property

		' Token: 0x17000AA8 RID: 2728
		' (get) Token: 0x06002C2F RID: 11311 RVA: 0x00130AE9 File Offset: 0x0012ECE9
		' (set) Token: 0x06002C30 RID: 11312 RVA: 0x00130AF6 File Offset: 0x0012ECF6
		<DefaultValue(False)>
		<Browsable(False)>
		Public Property MultiDataMapAutoKeys As Boolean
			Get
				Return Me.oO.OO..MultiDataMapAutoKeys
			End Get
			Set(value As Boolean)
				Me.oO.OO..MultiDataMapAutoKeys = value
			End Set
		End Property

		' Token: 0x17000AA9 RID: 2729
		' (get) Token: 0x06002C31 RID: 11313 RVA: 0x00130B04 File Offset: 0x0012ED04
		' (set) Token: 0x06002C32 RID: 11314 RVA: 0x00130B11 File Offset: 0x0012ED11
		<DefaultValue(0)>
		<Browsable(False)>
		Public Property MultiDataMapDisplayCol As Integer
			Get
				Return Me.oO.OO..MultiDataMapDisplayCol
			End Get
			Set(value As Integer)
				Me.oO.OO..MultiDataMapDisplayCol = value
			End Set
		End Property

		' Token: 0x17000AAA RID: 2730
		' (get) Token: 0x06002C33 RID: 11315 RVA: 0x00130B1F File Offset: 0x0012ED1F
		' (set) Token: 0x06002C34 RID: 11316 RVA: 0x00130B2C File Offset: 0x0012ED2C
		<DefaultValue(0)>
		<Browsable(False)>
		Public Property MultiDataMapValueCol As Integer
			Get
				Return Me.oO.OO..MultiDataMapValueCol
			End Get
			Set(value As Integer)
				Me.oO.OO..MultiDataMapValueCol = value
			End Set
		End Property

		' Token: 0x06002C35 RID: 11317 RVA: 0x00130B3C File Offset: 0x0012ED3C
		Friend Sub Apply()
			Me.oO.OO..oO0._00o_0. = Nothing
			Me.oO.OO..o_.Oo00_O_00_.()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me.oO.OO..DataTable Then
						Try
							For Each col As Col In table.Cols
								If col.DataCol Is Me.oO.OO. Then
									col.o0.O.()
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Col)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x040011A6 RID: 4518
		Friend <<EMPTY_NAME>> As DataCol

		' Token: 0x040011A7 RID: 4519
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
