Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200040C RID: 1036
	<OoO0___o("Control")>
	Friend Class PictureViewerProperty
		Inherits PropertyBase

		' Token: 0x06004422 RID: 17442 RVA: 0x001C2AD0 File Offset: 0x001C0CD0
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.OooO.o. = True
			Me.oo_o.O. = True
			Me.Ooo_O.oO. = True
			Me.O.oOOO_00O0. = True
			Me.o0O__.oO0. = True
			Me.oo_o.O. = 1
			Me.O0.0OOoo_00o_O. = 2
			Me.OooO.o. = 21
			Me.Ooo0Oo_.ooO. = CType(A_0.ChildControl, PictureViewer)
			Try
				For Each obj As Object In Me.Ooo0Oo_.ooO..Controls
					CType(obj, Control).Enabled = False
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x17000F61 RID: 3937
		' (get) Token: 0x06004423 RID: 17443 RVA: 0x001C2B80 File Offset: 0x001C0D80
		' (set) Token: 0x06004424 RID: 17444 RVA: 0x001C2B88 File Offset: 0x001C0D88
		<O_Oo00Oo000O0(2.1)>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(False)>
		<DisplayName("绑定到")>
		<Category("基本")>
		Public Property BindingField As String
			Get
				Return Me.o.o0oo_.
			End Get
			Set(value As String)
				Me.o.o0oo_. = value
			End Set
		End Property

		' Token: 0x17000F62 RID: 3938
		' (get) Token: 0x06004425 RID: 17445 RVA: 0x001C2B91 File Offset: 0x001C0D91
		' (set) Token: 0x06004426 RID: 17446 RVA: 0x001C2B99 File Offset: 0x001C0D99
		<Category("基本")>
		<O_Oo00Oo000O0(2.3)>
		<DisplayName("只读")>
		<Description("是否禁止用户修改。")>
		<MergableProperty(True)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.OooO.o.
			End Get
			Set(value As BooleanEnum)
				Me.OooO.o. = value
			End Set
		End Property

		' Token: 0x17000F63 RID: 3939
		' (get) Token: 0x06004427 RID: 17447 RVA: 0x001C2BA2 File Offset: 0x001C0DA2
		' (set) Token: 0x06004428 RID: 17448 RVA: 0x001C2BAA File Offset: 0x001C0DAA
		<DisplayName("允许打印")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(10.0)>
		<Category("输出")>
		<MergableProperty(True)>
		<Description("打印窗口时是否打印此控件。")>
		Public Property Printable As Boolean
			Get
				Return Me.Ooo_O.oO.
			End Get
			Set(value As Boolean)
				Me.Ooo_O.oO. = value
			End Set
		End Property

		' Token: 0x17000F64 RID: 3940
		' (get) Token: 0x06004429 RID: 17449 RVA: 0x001C2BB3 File Offset: 0x001C0DB3
		' (set) Token: 0x0600442A RID: 17450 RVA: 0x001C2BBB File Offset: 0x001C0DBB
		<DisplayName("另起一页")>
		<O_Oo00Oo000O0(10.1)>
		<Description("打印时是否从此控件开始另起一页。")>
		<MergableProperty(True)>
		<DefaultValue(False)>
		<Category("输出")>
		Public Property NewPage As Boolean
			Get
				Return Me.Ooo._0o0OOO_.
			End Get
			Set(value As Boolean)
				Me.Ooo._0o0OOO_. = value
			End Set
		End Property

		' Token: 0x17000F65 RID: 3941
		' (get) Token: 0x0600442B RID: 17451 RVA: 0x001C2BC4 File Offset: 0x001C0DC4
		' (set) Token: 0x0600442C RID: 17452 RVA: 0x001C2BD4 File Offset: 0x001C0DD4
		<O_Oo00Oo000O0(0.1)>
		<DisplayName("自动缩放")>
		<DefaultValue(True)>
		<Category("杂项")>
		<MergableProperty(True)>
		Public Property AutoSize As Boolean
			Get
				Return Me.Ooo0Oo_.ooO..SizeMode = PictureBoxSizeMode.Zoom
			End Get
			Set(value As Boolean)
				If value Then
					Me.Ooo0Oo_.ooO..SizeMode = PictureBoxSizeMode.Zoom
					Return
				End If
				Me.Ooo0Oo_.ooO..SizeMode = PictureBoxSizeMode.AutoSize
			End Set
		End Property

		' Token: 0x17000F66 RID: 3942
		' (get) Token: 0x0600442D RID: 17453 RVA: 0x001C2BF2 File Offset: 0x001C0DF2
		' (set) Token: 0x0600442E RID: 17454 RVA: 0x001C2C04 File Offset: 0x001C0E04
		<DisplayName("背景颜色")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(0.2)>
		<Category("杂项")>
		Public Property BackColor As Color
			Get
				Return Me.Ooo0Oo_.ooO..C1PictureBox1.BackColor
			End Get
			Set(value As Color)
				Me.Ooo0Oo_.ooO..C1PictureBox1.BackColor = value
				Me.Ooo0Oo_.ooO..Panel2.BackColor = value
			End Set
		End Property

		' Token: 0x17000F67 RID: 3943
		' (get) Token: 0x0600442F RID: 17455 RVA: 0x001C2C28 File Offset: 0x001C0E28
		' (set) Token: 0x06004430 RID: 17456 RVA: 0x001C2C30 File Offset: 0x001C0E30
		<DefaultValue(True)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("可见")>
		<Category("杂项")>
		<MergableProperty(True)>
		Public Property Visible As Boolean
			Get
				Return Me.OooO.o.
			End Get
			Set(value As Boolean)
				Me.OooO.o. = value
			End Set
		End Property

		' Token: 0x17000F68 RID: 3944
		' (get) Token: 0x06004431 RID: 17457 RVA: 0x001C2C39 File Offset: 0x001C0E39
		' (set) Token: 0x06004432 RID: 17458 RVA: 0x001C2C46 File Offset: 0x001C0E46
		<O_Oo00Oo000O0(3.0)>
		<Description("确定用户按Tab键时，该控件获得焦点的顺序。")>
		<Category("杂项")>
		<MergableProperty(False)>
		<DisplayName("Tab键顺序")>
		Public Property TabIndex As Integer
			Get
				Return Me.o_0_.Oo..TabIndex
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..TabIndex = value
			End Set
		End Property

		' Token: 0x17000F69 RID: 3945
		' (get) Token: 0x06004433 RID: 17459 RVA: 0x001C2C54 File Offset: 0x001C0E54
		' (set) Token: 0x06004434 RID: 17460 RVA: 0x001C2C69 File Offset: 0x001C0E69
		<DisplayName("显示命令")>
		<O_Oo00Oo000O0(2.1)>
		<DefaultValue(True)>
		<Category("杂项")>
		<MergableProperty(True)>
		<Description("是否显示操作命令")>
		Public Property CommandVisible As Boolean
			Get
				Return Not Me.Ooo0Oo_.ooO..SplitContainer.Panel2Collapsed
			End Get
			Set(value As Boolean)
				Me.Ooo0Oo_.ooO..SplitContainer.Panel2Collapsed = Not value
			End Set
		End Property

		' Token: 0x17000F6A RID: 3946
		' (get) Token: 0x06004435 RID: 17461 RVA: 0x001C2C7F File Offset: 0x001C0E7F
		' (set) Token: 0x06004436 RID: 17462 RVA: 0x001C2C87 File Offset: 0x001C0E87
		<DisplayName("允许打开")>
		<MergableProperty(True)>
		<Description("是否允许打开图片")>
		<O_Oo00Oo000O0(2.5)>
		<Category("杂项")>
		<DefaultValue(True)>
		Public Property OpenEnabled As Boolean
			Get
				Return Me.oo_o.O.
			End Get
			Set(value As Boolean)
				Me.oo_o.O. = value
			End Set
		End Property

		' Token: 0x17000F6B RID: 3947
		' (get) Token: 0x06004437 RID: 17463 RVA: 0x001C2C90 File Offset: 0x001C0E90
		' (set) Token: 0x06004438 RID: 17464 RVA: 0x001C2C98 File Offset: 0x001C0E98
		<Description("指定文件或者图片列附件的存放目录名称。")>
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<DisplayName("存放目录")>
		<O_Oo00Oo000O0(8.21)>
		<Category("设置")>
		Public Property FolderName As String
			Get
				Return Me.O0Oo0._.
			End Get
			Set(value As String)
				Me.O0Oo0._. = value
			End Set
		End Property

		' Token: 0x17000F6C RID: 3948
		' (get) Token: 0x06004439 RID: 17465 RVA: 0x001C2CA1 File Offset: 0x001C0EA1
		' (set) Token: 0x0600443A RID: 17466 RVA: 0x001C2CA9 File Offset: 0x001C0EA9
		<Description("指定增加文件时，默认从什么目录选择文件。")>
		<O_Oo00Oo000O0(8.22)>
		<Category("设置")>
		<DisplayName("来源目录")>
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		Public Property SourceFolder As String
			Get
				Return Me.Ooo.0_o.
			End Get
			Set(value As String)
				Me.Ooo.0_o. = value
			End Set
		End Property

		' Token: 0x17000F6D RID: 3949
		' (get) Token: 0x0600443B RID: 17467 RVA: 0x001C2CB2 File Offset: 0x001C0EB2
		' (set) Token: 0x0600443C RID: 17468 RVA: 0x001C2CBA File Offset: 0x001C0EBA
		<O_Oo00Oo000O0(8.3)>
		<DisplayName("自动复制附件")>
		<Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")>
		<DefaultValue(1)>
		<Category("设置")>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.oo_o.O.
			End Get
			Set(value As BooleanEnum)
				Me.oo_o.O. = value
			End Set
		End Property

		' Token: 0x17000F6E RID: 3950
		' (get) Token: 0x0600443D RID: 17469 RVA: 0x001C2CC3 File Offset: 0x001C0EC3
		' (set) Token: 0x0600443E RID: 17470 RVA: 0x001C2CCB File Offset: 0x001C0ECB
		<Category("设置")>
		<O_Oo00Oo000O0(8.3)>
		<DefaultValue(2)>
		<Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")>
		<DisplayName("自动删除附件")>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.O0.0OOoo_00o_O.
			End Get
			Set(value As BooleanEnum)
				Me.O0.0OOoo_00o_O. = value
			End Set
		End Property

		' Token: 0x17000F6F RID: 3951
		' (get) Token: 0x0600443F RID: 17471 RVA: 0x001C2CD4 File Offset: 0x001C0ED4
		' (set) Token: 0x06004440 RID: 17472 RVA: 0x001C2CDC File Offset: 0x001C0EDC
		<DisplayName("文件类型筛选")>
		<O_Oo00Oo000O0(8.4)>
		<Category("设置")>
		<Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*" & vbCrLf & "筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")>
		Public Property FileFilter As String
			Get
				Return Me.o0O__.oO0.
			End Get
			Set(value As String)
				Me.o0O__.oO0. = value
			End Set
		End Property

		' Token: 0x17000F70 RID: 3952
		' (get) Token: 0x06004441 RID: 17473 RVA: 0x001C2CE5 File Offset: 0x001C0EE5
		' (set) Token: 0x06004442 RID: 17474 RVA: 0x001C2CED File Offset: 0x001C0EED
		<Category("设置")>
		<DisplayName("远程文件")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(8.11)>
		Public Property Remote As Boolean
			Get
				Return Me.OooO._.
			End Get
			Set(value As Boolean)
				Me.OooO._. = value
			End Set
		End Property

		' Token: 0x17000F71 RID: 3953
		' (get) Token: 0x06004443 RID: 17475 RVA: 0x001C2CF6 File Offset: 0x001C0EF6
		' (set) Token: 0x06004444 RID: 17476 RVA: 0x001C2CFE File Offset: 0x001C0EFE
		<DisplayName("服务器地址")>
		<Category("设置")>
		<O_Oo00Oo000O0(8.12)>
		Public Property Host As String
			Get
				Return Me.oo_o.O.
			End Get
			Set(value As String)
				Me.oo_o.O. = value
			End Set
		End Property

		' Token: 0x17000F72 RID: 3954
		' (get) Token: 0x06004445 RID: 17477 RVA: 0x001C2D07 File Offset: 0x001C0F07
		' (set) Token: 0x06004446 RID: 17478 RVA: 0x001C2D0F File Offset: 0x001C0F0F
		<Category("设置")>
		<DisplayName("用户名")>
		<O_Oo00Oo000O0(8.13)>
		Public Property Account As String
			Get
				Return Me.O_O0.OO.
			End Get
			Set(value As String)
				Me.O_O0.OO. = value
			End Set
		End Property

		' Token: 0x17000F73 RID: 3955
		' (get) Token: 0x06004447 RID: 17479 RVA: 0x001C2D18 File Offset: 0x001C0F18
		' (set) Token: 0x06004448 RID: 17480 RVA: 0x001C2D20 File Offset: 0x001C0F20
		<O_Oo00Oo000O0(8.14)>
		<DisplayName("用户密码")>
		<Category("设置")>
		Public Property Password As String
			Get
				Return Me.ooO0_Oo.o_0.
			End Get
			Set(value As String)
				Me.ooO0_Oo.o_0. = value
			End Set
		End Property

		' Token: 0x17000F74 RID: 3956
		' (get) Token: 0x06004449 RID: 17481 RVA: 0x001C2D29 File Offset: 0x001C0F29
		' (set) Token: 0x0600444A RID: 17482 RVA: 0x001C2D31 File Offset: 0x001C0F31
		<DisplayName("UTF8编码")>
		<O_Oo00Oo000O0(8.141)>
		<Category("设置")>
		<DefaultValue(False)>
		Public Property UTF8 As Boolean
			Get
				Return Me.OOoo.O.
			End Get
			Set(value As Boolean)
				Me.OOoo.O. = value
			End Set
		End Property

		' Token: 0x17000F75 RID: 3957
		' (get) Token: 0x0600444B RID: 17483 RVA: 0x001C2D3A File Offset: 0x001C0F3A
		' (set) Token: 0x0600444C RID: 17484 RVA: 0x001C2D42 File Offset: 0x001C0F42
		<Category("设置")>
		<DefaultValue(21)>
		<O_Oo00Oo000O0(8.142)>
		<DisplayName("端口号")>
		Public Property Port As Integer
			Get
				Return Me.OooO.o.
			End Get
			Set(value As Integer)
				Me.OooO.o. = value
			End Set
		End Property

		' Token: 0x17000F76 RID: 3958
		' (get) Token: 0x0600444D RID: 17485 RVA: 0x001C2D4B File Offset: 0x001C0F4B
		' (set) Token: 0x0600444E RID: 17486 RVA: 0x001C2D53 File Offset: 0x001C0F53
		<O_Oo00Oo000O0(8.15)>
		<DisplayName("根目录")>
		<Category("设置")>
		Public Property RootDir As String
			Get
				Return Me.OooO._.
			End Get
			Set(value As String)
				Me.OooO._. = value
			End Set
		End Property

		' Token: 0x17000F77 RID: 3959
		' (get) Token: 0x0600444F RID: 17487 RVA: 0x001C2D5C File Offset: 0x001C0F5C
		' (set) Token: 0x06004450 RID: 17488 RVA: 0x001C2D64 File Offset: 0x001C0F64
		<Category("设置")>
		<Description("是否自动下载远程图片。")>
		<DefaultValue(True)>
		<DisplayName("自动下载图片")>
		<O_Oo00Oo000O0(8.5)>
		Public Property AutoDownload As Boolean
			Get
				Return Me.O.oOOO_00O0.
			End Get
			Set(value As Boolean)
				Me.O.oOOO_00O0. = value
			End Set
		End Property

		' Token: 0x17000F78 RID: 3960
		' (get) Token: 0x06004451 RID: 17489 RVA: 0x001C2D6D File Offset: 0x001C0F6D
		' (set) Token: 0x06004452 RID: 17490 RVA: 0x001C2D75 File Offset: 0x001C0F75
		<O_Oo00Oo000O0(8.6)>
		<Category("设置")>
		<DisplayName("自动更新文件")>
		<Description("是否自动更新远程文件")>
		<DefaultValue(True)>
		Public Property AutoUpdate As Boolean
			Get
				Return Me.o0O__.oO0.
			End Get
			Set(value As Boolean)
				Me.o0O__.oO0. = value
			End Set
		End Property

		' Token: 0x17000F79 RID: 3961
		' (get) Token: 0x06004453 RID: 17491 RVA: 0x001C2D7E File Offset: 0x001C0F7E
		' (set) Token: 0x06004454 RID: 17492 RVA: 0x001C2D8B File Offset: 0x001C0F8B
		<DisplayName("左")>
		<O_Oo00Oo000O0(1.0)>
		<Category("位置")>
		<MergableProperty(True)>
		Public Property Left As Integer
			Get
				Return Me.o_0_.Oo..Left
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Left = value
			End Set
		End Property

		' Token: 0x17000F7A RID: 3962
		' (get) Token: 0x06004455 RID: 17493 RVA: 0x001C2D99 File Offset: 0x001C0F99
		' (set) Token: 0x06004456 RID: 17494 RVA: 0x001C2DA6 File Offset: 0x001C0FA6
		<DisplayName("上")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<Category("位置")>
		Public Property Top As Integer
			Get
				Return Me.o_0_.Oo..Top
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Top = value
			End Set
		End Property

		' Token: 0x17000F7B RID: 3963
		' (get) Token: 0x06004457 RID: 17495 RVA: 0x001C2DB4 File Offset: 0x001C0FB4
		' (set) Token: 0x06004458 RID: 17496 RVA: 0x001C2DC1 File Offset: 0x001C0FC1
		<DisplayName("宽")>
		<Category("位置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property Width As Integer
			Get
				Return Me.o_0_.Oo..Width
			End Get
			Set(value As Integer)
				If Not Me.o_0_.Oo..IsFixedWidth Then
					Me.o_0_.Oo..Width = value
				End If
			End Set
		End Property

		' Token: 0x17000F7C RID: 3964
		' (get) Token: 0x06004459 RID: 17497 RVA: 0x001C2DDC File Offset: 0x001C0FDC
		' (set) Token: 0x0600445A RID: 17498 RVA: 0x001C2DE9 File Offset: 0x001C0FE9
		<O_Oo00Oo000O0(4.0)>
		<Category("位置")>
		<MergableProperty(True)>
		<DisplayName("高")>
		Public Property Height As Integer
			Get
				Return Me.o_0_.Oo..Height
			End Get
			Set(value As Integer)
				If Not Me.o_0_.Oo..IsFixedHeight Then
					Me.o_0_.Oo..Height = value
				End If
			End Set
		End Property

		' Token: 0x17000F7D RID: 3965
		' (get) Token: 0x0600445B RID: 17499 RVA: 0x001C2E04 File Offset: 0x001C1004
		' (set) Token: 0x0600445C RID: 17500 RVA: 0x001C2E11 File Offset: 0x001C1011
		<Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")>
		<DefaultValue(5)>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("锚定")>
		<MergableProperty(True)>
		<Category("位置")>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o_0_.Oo..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o_0_.Oo..Anchor = value
			End Set
		End Property

		' Token: 0x17000F7E RID: 3966
		' (get) Token: 0x0600445D RID: 17501 RVA: 0x001C2E1F File Offset: 0x001C101F
		' (set) Token: 0x0600445E RID: 17502 RVA: 0x001C2E2C File Offset: 0x001C102C
		<O_Oo00Oo000O0(5.1)>
		<Description("停靠到容器的指定边框。")>
		<DisplayName("停靠")>
		<DefaultValue(0)>
		<Category("位置")>
		<MergableProperty(True)>
		Public Property Dock As DockStyle
			Get
				Return Me.o_0_.Oo..Dock
			End Get
			Set(value As DockStyle)
				Me.o_0_.Oo..Dock = value
			End Set
		End Property

		' Token: 0x04001BBF RID: 7103
		Private <<EMPTY_NAME>> As PictureViewer

		' Token: 0x04001BC0 RID: 7104
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001BC1 RID: 7105
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BC2 RID: 7106
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BC3 RID: 7107
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BC4 RID: 7108
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BC5 RID: 7109
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BC6 RID: 7110
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BC7 RID: 7111
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BC8 RID: 7112
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BC9 RID: 7113
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BCA RID: 7114
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BCB RID: 7115
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BCC RID: 7116
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BCD RID: 7117
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BCE RID: 7118
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BCF RID: 7119
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BD0 RID: 7120
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BD1 RID: 7121
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001BD2 RID: 7122
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001BD3 RID: 7123
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BD4 RID: 7124
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
