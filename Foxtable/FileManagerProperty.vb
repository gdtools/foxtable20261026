Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000401 RID: 1025
	<OoO0___o("Control")>
	Friend Class FileManagerProperty
		Inherits PropertyBase

		' Token: 0x060042AC RID: 17068 RVA: 0x001C13E8 File Offset: 0x001BF5E8
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O___o.o. = True
			Me.o_o0.0o. = True
			Me.oO_.0o. = True
			Me.o_o0.0o. = 1
			Me.oO_.0o. = 2
			Me.O___o.o. = 21
			Me.O___o.o. = CType(A_0.ChildControl, FileManager)
			Try
				For Each obj As Object In Me.O___o.o..Controls
					CType(obj, Control).Enabled = False
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x17000EAB RID: 3755
		' (get) Token: 0x060042AD RID: 17069 RVA: 0x001C148C File Offset: 0x001BF68C
		' (set) Token: 0x060042AE RID: 17070 RVA: 0x001C1494 File Offset: 0x001BF694
		<MergableProperty(False)>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.O.0OoOOOoO0o.
			End Get
			Set(value As String)
				Me.O.0OoOOOoO0o. = value
			End Set
		End Property

		' Token: 0x17000EAC RID: 3756
		' (get) Token: 0x060042AF RID: 17071 RVA: 0x001C149D File Offset: 0x001BF69D
		' (set) Token: 0x060042B0 RID: 17072 RVA: 0x001C14A5 File Offset: 0x001BF6A5
		<O_Oo00Oo000O0(2.3)>
		<Description("是否禁止用户修改。")>
		<MergableProperty(True)>
		<DisplayName("只读")>
		<Category("基本")>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O___o.o.
			End Get
			Set(value As BooleanEnum)
				Me.O___o.o. = value
			End Set
		End Property

		' Token: 0x17000EAD RID: 3757
		' (get) Token: 0x060042B1 RID: 17073 RVA: 0x001C14AE File Offset: 0x001BF6AE
		' (set) Token: 0x060042B2 RID: 17074 RVA: 0x001C14B6 File Offset: 0x001BF6B6
		<MergableProperty(True)>
		<DisplayName("可见")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(2.0)>
		<Category("杂项")>
		Public Property Visible As Boolean
			Get
				Return Me.O___o.o.
			End Get
			Set(value As Boolean)
				Me.O___o.o. = value
			End Set
		End Property

		' Token: 0x17000EAE RID: 3758
		' (get) Token: 0x060042B3 RID: 17075 RVA: 0x001C14BF File Offset: 0x001BF6BF
		' (set) Token: 0x060042B4 RID: 17076 RVA: 0x001C14D4 File Offset: 0x001BF6D4
		<DisplayName("显示命令")>
		<DefaultValue(True)>
		<Category("杂项")>
		<Description("是否显示操作命令")>
		<O_Oo00Oo000O0(2.1)>
		<MergableProperty(True)>
		Public Property CommandVisible As Boolean
			Get
				Return Not Me.O___o.o..SplitContainer1.Panel2Collapsed
			End Get
			Set(value As Boolean)
				Me.O___o.o..SplitContainer1.Panel2Collapsed = Not value
			End Set
		End Property

		' Token: 0x17000EAF RID: 3759
		' (get) Token: 0x060042B5 RID: 17077 RVA: 0x001C14EA File Offset: 0x001BF6EA
		' (set) Token: 0x060042B6 RID: 17078 RVA: 0x001C14F2 File Offset: 0x001BF6F2
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.5)>
		<DisplayName("允许打开")>
		<DefaultValue(True)>
		<Category("杂项")>
		<Description("是否允许打开文件")>
		Public Property OpenEnabled As Boolean
			Get
				Return Me.o_o0.0o.
			End Get
			Set(value As Boolean)
				Me.o_o0.0o. = value
			End Set
		End Property

		' Token: 0x17000EB0 RID: 3760
		' (get) Token: 0x060042B7 RID: 17079 RVA: 0x001C14FB File Offset: 0x001BF6FB
		' (set) Token: 0x060042B8 RID: 17080 RVA: 0x001C1503 File Offset: 0x001BF703
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(8.21)>
		<Description("指定文件或者图片列附件的存放目录名称。")>
		<DisplayName("存放目录")>
		<Category("设置")>
		Public Property FolderName As String
			Get
				Return Me.Oo0.O0oo00O0o.
			End Get
			Set(value As String)
				Me.Oo0.O0oo00O0o. = value
			End Set
		End Property

		' Token: 0x17000EB1 RID: 3761
		' (get) Token: 0x060042B9 RID: 17081 RVA: 0x001C150C File Offset: 0x001BF70C
		' (set) Token: 0x060042BA RID: 17082 RVA: 0x001C1514 File Offset: 0x001BF714
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(8.22)>
		<DisplayName("来源目录")>
		<Category("设置")>
		<Description("指定增加文件时，默认从什么目录选择文件。")>
		Public Property SourceFolder As String
			Get
				Return Me.O___o0o.O.
			End Get
			Set(value As String)
				Me.O___o0o.O. = value
			End Set
		End Property

		' Token: 0x17000EB2 RID: 3762
		' (get) Token: 0x060042BB RID: 17083 RVA: 0x001C151D File Offset: 0x001BF71D
		' (set) Token: 0x060042BC RID: 17084 RVA: 0x001C1525 File Offset: 0x001BF725
		<DefaultValue(1)>
		<DisplayName("自动复制附件")>
		<Description("在文件列或者图片列中，增加项目的时候，是否自动将该项目对应的文件复制到本地。")>
		<O_Oo00Oo000O0(8.3)>
		<Category("设置")>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.o_o0.0o.
			End Get
			Set(value As BooleanEnum)
				Me.o_o0.0o. = value
			End Set
		End Property

		' Token: 0x17000EB3 RID: 3763
		' (get) Token: 0x060042BD RID: 17085 RVA: 0x001C152E File Offset: 0x001BF72E
		' (set) Token: 0x060042BE RID: 17086 RVA: 0x001C1536 File Offset: 0x001BF736
		<DefaultValue(2)>
		<O_Oo00Oo000O0(8.3)>
		<Description("在文件列或者图片列中，删除某项目的时候，是否自动删除该项目对应的文件，该属性仅对复制到本地的文件有效")>
		<Category("设置")>
		<DisplayName("自动删除附件")>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.oO_.0o.
			End Get
			Set(value As BooleanEnum)
				Me.oO_.0o. = value
			End Set
		End Property

		' Token: 0x17000EB4 RID: 3764
		' (get) Token: 0x060042BF RID: 17087 RVA: 0x001C153F File Offset: 0x001BF73F
		' (set) Token: 0x060042C0 RID: 17088 RVA: 0x001C1547 File Offset: 0x001BF747
		<O_Oo00Oo000O0(8.4)>
		<Category("设置")>
		<DisplayName("文件类型筛选")>
		<Description("例如文本文件：Text files (*.txt)|*.txt|All files (*.*)|*.*" & vbCrLf & "筛选图片文件：Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*")>
		Public Property FileFilter As String
			Get
				Return Me.oO_.0oOOo.
			End Get
			Set(value As String)
				Me.oO_.0oOOo. = value
			End Set
		End Property

		' Token: 0x17000EB5 RID: 3765
		' (get) Token: 0x060042C1 RID: 17089 RVA: 0x001C1550 File Offset: 0x001BF750
		' (set) Token: 0x060042C2 RID: 17090 RVA: 0x001C1558 File Offset: 0x001BF758
		<Category("设置")>
		<DisplayName("远程文件")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(8.11)>
		Public Property Remote As Boolean
			Get
				Return Me.OO._0Oo_OOOo0.
			End Get
			Set(value As Boolean)
				Me.OO._0Oo_OOOo0. = value
			End Set
		End Property

		' Token: 0x17000EB6 RID: 3766
		' (get) Token: 0x060042C3 RID: 17091 RVA: 0x001C1561 File Offset: 0x001BF761
		' (set) Token: 0x060042C4 RID: 17092 RVA: 0x001C1569 File Offset: 0x001BF769
		<Category("设置")>
		<DisplayName("服务器地址")>
		<O_Oo00Oo000O0(8.12)>
		Public Property Host As String
			Get
				Return Me.o_o0.0o.
			End Get
			Set(value As String)
				Me.o_o0.0o. = value
			End Set
		End Property

		' Token: 0x17000EB7 RID: 3767
		' (get) Token: 0x060042C5 RID: 17093 RVA: 0x001C1572 File Offset: 0x001BF772
		' (set) Token: 0x060042C6 RID: 17094 RVA: 0x001C157A File Offset: 0x001BF77A
		<Category("设置")>
		<O_Oo00Oo000O0(8.13)>
		<DisplayName("用户名")>
		Public Property Account As String
			Get
				Return Me.oO_.0o.
			End Get
			Set(value As String)
				Me.oO_.0o. = value
			End Set
		End Property

		' Token: 0x17000EB8 RID: 3768
		' (get) Token: 0x060042C7 RID: 17095 RVA: 0x001C1583 File Offset: 0x001BF783
		' (set) Token: 0x060042C8 RID: 17096 RVA: 0x001C158B File Offset: 0x001BF78B
		<O_Oo00Oo000O0(8.14)>
		<Category("设置")>
		<DisplayName("用户密码")>
		Public Property Password As String
			Get
				Return Me.OoO0._oo_O.
			End Get
			Set(value As String)
				Me.OoO0._oo_O. = value
			End Set
		End Property

		' Token: 0x17000EB9 RID: 3769
		' (get) Token: 0x060042C9 RID: 17097 RVA: 0x001C1594 File Offset: 0x001BF794
		' (set) Token: 0x060042CA RID: 17098 RVA: 0x001C159C File Offset: 0x001BF79C
		<Category("设置")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(8.141)>
		<DisplayName("UTF8编码")>
		Public Property UTF8 As Boolean
			Get
				Return Me.oo.OO0O_.
			End Get
			Set(value As Boolean)
				Me.oo.OO0O_. = value
			End Set
		End Property

		' Token: 0x17000EBA RID: 3770
		' (get) Token: 0x060042CB RID: 17099 RVA: 0x001C15A5 File Offset: 0x001BF7A5
		' (set) Token: 0x060042CC RID: 17100 RVA: 0x001C15AD File Offset: 0x001BF7AD
		<DefaultValue(21)>
		<Category("设置")>
		<DisplayName("端口号")>
		<O_Oo00Oo000O0(8.142)>
		Public Property Port As Integer
			Get
				Return Me.O___o.o.
			End Get
			Set(value As Integer)
				Me.O___o.o. = value
			End Set
		End Property

		' Token: 0x17000EBB RID: 3771
		' (get) Token: 0x060042CD RID: 17101 RVA: 0x001C15B6 File Offset: 0x001BF7B6
		' (set) Token: 0x060042CE RID: 17102 RVA: 0x001C15BE File Offset: 0x001BF7BE
		<Category("设置")>
		<DisplayName("根目录")>
		<O_Oo00Oo000O0(8.15)>
		Public Property RootDir As String
			Get
				Return Me.oo.OO0O_.
			End Get
			Set(value As String)
				Me.oo.OO0O_. = value
			End Set
		End Property

		' Token: 0x17000EBC RID: 3772
		' (get) Token: 0x060042CF RID: 17103 RVA: 0x001C15C7 File Offset: 0x001BF7C7
		' (set) Token: 0x060042D0 RID: 17104 RVA: 0x001C15CF File Offset: 0x001BF7CF
		<Description("是否自动更新远程文件")>
		<O_Oo00Oo000O0(8.6)>
		<DisplayName("自动更新文件")>
		<DefaultValue(True)>
		<Category("设置")>
		Public Property AutoUpdate As Boolean
			Get
				Return Me.oO_.0o.
			End Get
			Set(value As Boolean)
				Me.oO_.0o. = value
			End Set
		End Property

		' Token: 0x17000EBD RID: 3773
		' (get) Token: 0x060042D1 RID: 17105 RVA: 0x001C15D8 File Offset: 0x001BF7D8
		' (set) Token: 0x060042D2 RID: 17106 RVA: 0x001C15E5 File Offset: 0x001BF7E5
		<Description("确定用户按Tab键时，该控件获得焦点的顺序。")>
		<Category("杂项")>
		<MergableProperty(False)>
		<O_Oo00Oo000O0(3.0)>
		<DisplayName("Tab键顺序")>
		Public Property TabIndex As Integer
			Get
				Return Me.o_0_.Oo..TabIndex
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..TabIndex = value
			End Set
		End Property

		' Token: 0x17000EBE RID: 3774
		' (get) Token: 0x060042D3 RID: 17107 RVA: 0x001C15F3 File Offset: 0x001BF7F3
		' (set) Token: 0x060042D4 RID: 17108 RVA: 0x001C1600 File Offset: 0x001BF800
		<Category("位置")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("左")>
		<MergableProperty(True)>
		Public Property Left As Integer
			Get
				Return Me.o_0_.Oo..Left
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Left = value
			End Set
		End Property

		' Token: 0x17000EBF RID: 3775
		' (get) Token: 0x060042D5 RID: 17109 RVA: 0x001C160E File Offset: 0x001BF80E
		' (set) Token: 0x060042D6 RID: 17110 RVA: 0x001C161B File Offset: 0x001BF81B
		<Category("位置")>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("上")>
		Public Property Top As Integer
			Get
				Return Me.o_0_.Oo..Top
			End Get
			Set(value As Integer)
				Me.o_0_.Oo..Top = value
			End Set
		End Property

		' Token: 0x17000EC0 RID: 3776
		' (get) Token: 0x060042D7 RID: 17111 RVA: 0x001C1629 File Offset: 0x001BF829
		' (set) Token: 0x060042D8 RID: 17112 RVA: 0x001C1636 File Offset: 0x001BF836
		<MergableProperty(True)>
		<DisplayName("宽")>
		<O_Oo00Oo000O0(3.0)>
		<Category("位置")>
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

		' Token: 0x17000EC1 RID: 3777
		' (get) Token: 0x060042D9 RID: 17113 RVA: 0x001C1651 File Offset: 0x001BF851
		' (set) Token: 0x060042DA RID: 17114 RVA: 0x001C165E File Offset: 0x001BF85E
		<MergableProperty(True)>
		<DisplayName("高")>
		<O_Oo00Oo000O0(4.0)>
		<Category("位置")>
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

		' Token: 0x17000EC2 RID: 3778
		' (get) Token: 0x060042DB RID: 17115 RVA: 0x001C1679 File Offset: 0x001BF879
		' (set) Token: 0x060042DC RID: 17116 RVA: 0x001C1686 File Offset: 0x001BF886
		<MergableProperty(True)>
		<DisplayName("锚定")>
		<Category("位置")>
		<O_Oo00Oo000O0(5.0)>
		<Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o_0_.Oo..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o_0_.Oo..Anchor = value
			End Set
		End Property

		' Token: 0x17000EC3 RID: 3779
		' (get) Token: 0x060042DD RID: 17117 RVA: 0x001C1694 File Offset: 0x001BF894
		' (set) Token: 0x060042DE RID: 17118 RVA: 0x001C16A1 File Offset: 0x001BF8A1
		<DisplayName("停靠")>
		<Category("位置")>
		<Description("停靠到容器的指定边框。")>
		<O_Oo00Oo000O0(5.1)>
		<MergableProperty(False)>
		Public Property Dock As DockStyle
			Get
				Return Me.o_0_.Oo..Dock
			End Get
			Set(value As DockStyle)
				Me.o_0_.Oo..Dock = value
			End Set
		End Property

		' Token: 0x04001B44 RID: 6980
		Private <<EMPTY_NAME>> As FileManager

		' Token: 0x04001B45 RID: 6981
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B46 RID: 6982
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B47 RID: 6983
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B48 RID: 6984
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B49 RID: 6985
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001B4A RID: 6986
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B4B RID: 6987
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B4C RID: 6988
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B4D RID: 6989
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B4E RID: 6990
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B4F RID: 6991
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B50 RID: 6992
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001B51 RID: 6993
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B52 RID: 6994
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B53 RID: 6995
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B54 RID: 6996
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B55 RID: 6997
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B56 RID: 6998
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
