Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200040B RID: 1035
	Friend Class PictureBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06004403 RID: 17411 RVA: 0x001C297E File Offset: 0x001C0B7E
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o__o_0.0_. = True
			Me.OO0.___. = 21
			Me.OO0.___. = CType(A_0.ChildControl, CustomPictureBox)
		End Sub

		' Token: 0x17000F52 RID: 3922
		' (get) Token: 0x06004404 RID: 17412 RVA: 0x001C29A7 File Offset: 0x001C0BA7
		' (set) Token: 0x06004405 RID: 17413 RVA: 0x001C29AF File Offset: 0x001C0BAF
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		<DisplayName("图片")>
		<O_Oo00Oo000O0(3.0)>
		<Category("基本")>
		Public Property ImageFile As String
			Get
				Return Me.OO0.___.
			End Get
			Set(value As String)
				Me.OO0.___. = value
				Me.OO0.___..Image = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17000F53 RID: 3923
		' (get) Token: 0x06004406 RID: 17414 RVA: 0x001C29C9 File Offset: 0x001C0BC9
		' (set) Token: 0x06004407 RID: 17415 RVA: 0x001C29D1 File Offset: 0x001C0BD1
		<MergableProperty(True)>
		<O_Oo00Oo000O0(5.0)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		Public Property BindingField As String
			Get
				Return Me.o_._O_oO0O.
			End Get
			Set(value As String)
				Me.o_._O_oO0O. = value
			End Set
		End Property

		' Token: 0x17000F54 RID: 3924
		' (get) Token: 0x06004408 RID: 17416 RVA: 0x001C29DA File Offset: 0x001C0BDA
		' (set) Token: 0x06004409 RID: 17417 RVA: 0x001C29E7 File Offset: 0x001C0BE7
		<DefaultValue(0)>
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("缩放")>
		<Category("基本")>
		<MergableProperty(True)>
		Public Property SizeMode As ImageSizeMode
			Get
				Return Me.OO0.___..SizeMode
			End Get
			Set(value As ImageSizeMode)
				Me.OO0.___..SizeMode = value
			End Set
		End Property

		' Token: 0x17000F55 RID: 3925
		' (get) Token: 0x0600440A RID: 17418 RVA: 0x001C29F5 File Offset: 0x001C0BF5
		' (set) Token: 0x0600440B RID: 17419 RVA: 0x001C2A02 File Offset: 0x001C0C02
		<O_Oo00Oo000O0(3.0)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("外观")>
		<DisplayName("边框")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.OO0.___..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.OO0.___..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000F56 RID: 3926
		' (get) Token: 0x0600440C RID: 17420 RVA: 0x001C2A10 File Offset: 0x001C0C10
		' (set) Token: 0x0600440D RID: 17421 RVA: 0x001C2A1D File Offset: 0x001C0C1D
		<O_Oo00Oo000O0(4.0)>
		<DefaultValue(True)>
		<DisplayName("滚动条")>
		<Category("外观")>
		<Description("对于超出范围的图片，是否显示滚动条来查看。")>
		<MergableProperty(True)>
		Public Property AutoScroll As Boolean
			Get
				Return Me.OO0.___..AutoScroll
			End Get
			Set(value As Boolean)
				Me.OO0.___..AutoScroll = value
			End Set
		End Property

		' Token: 0x17000F57 RID: 3927
		' (get) Token: 0x0600440E RID: 17422 RVA: 0x001C2A2B File Offset: 0x001C0C2B
		' (set) Token: 0x0600440F RID: 17423 RVA: 0x001C2A33 File Offset: 0x001C0C33
		<Category("设置")>
		<O_Oo00Oo000O0(8.21)>
		<Editor(GetType(OOo__O), GetType(UITypeEditor))>
		<Description("指定文件或者图片列附件的存放目录名称。")>
		<DisplayName("存放目录")>
		Public Property FolderName As String
			Get
				Return Me.o_Oo.OO0_0_o0.
			End Get
			Set(value As String)
				Me.o_Oo.OO0_0_o0. = value
			End Set
		End Property

		' Token: 0x17000F58 RID: 3928
		' (get) Token: 0x06004410 RID: 17424 RVA: 0x001C2A3C File Offset: 0x001C0C3C
		' (set) Token: 0x06004411 RID: 17425 RVA: 0x001C2A44 File Offset: 0x001C0C44
		<O_Oo00Oo000O0(8.11)>
		<Category("设置")>
		<DisplayName("远程文件")>
		<DefaultValue(False)>
		Public Property Remote As Boolean
			Get
				Return Me.OO0.___.
			End Get
			Set(value As Boolean)
				Me.OO0.___. = value
			End Set
		End Property

		' Token: 0x17000F59 RID: 3929
		' (get) Token: 0x06004412 RID: 17426 RVA: 0x001C2A4D File Offset: 0x001C0C4D
		' (set) Token: 0x06004413 RID: 17427 RVA: 0x001C2A55 File Offset: 0x001C0C55
		<O_Oo00Oo000O0(8.12)>
		<Category("设置")>
		<DisplayName("服务器地址")>
		Public Property Host As String
			Get
				Return Me.O.O_OO0oO_O.
			End Get
			Set(value As String)
				Me.O.O_OO0oO_O. = value
			End Set
		End Property

		' Token: 0x17000F5A RID: 3930
		' (get) Token: 0x06004414 RID: 17428 RVA: 0x001C2A5E File Offset: 0x001C0C5E
		' (set) Token: 0x06004415 RID: 17429 RVA: 0x001C2A66 File Offset: 0x001C0C66
		<Category("设置")>
		<O_Oo00Oo000O0(8.13)>
		<DisplayName("用户名")>
		Public Property Account As String
			Get
				Return Me.o_o0o_.o.
			End Get
			Set(value As String)
				Me.o_o0o_.o. = value
			End Set
		End Property

		' Token: 0x17000F5B RID: 3931
		' (get) Token: 0x06004416 RID: 17430 RVA: 0x001C2A6F File Offset: 0x001C0C6F
		' (set) Token: 0x06004417 RID: 17431 RVA: 0x001C2A77 File Offset: 0x001C0C77
		<Category("设置")>
		<DisplayName("用户密码")>
		<O_Oo00Oo000O0(8.14)>
		Public Property Password As String
			Get
				Return Me.OoO.000o__O00.
			End Get
			Set(value As String)
				Me.OoO.000o__O00. = value
			End Set
		End Property

		' Token: 0x17000F5C RID: 3932
		' (get) Token: 0x06004418 RID: 17432 RVA: 0x001C2A80 File Offset: 0x001C0C80
		' (set) Token: 0x06004419 RID: 17433 RVA: 0x001C2A88 File Offset: 0x001C0C88
		<O_Oo00Oo000O0(8.141)>
		<Category("设置")>
		<DefaultValue(False)>
		<DisplayName("UTF8编码")>
		Public Property UTF8 As Boolean
			Get
				Return Me.o_._O_oO0O.
			End Get
			Set(value As Boolean)
				Me.o_._O_oO0O. = value
			End Set
		End Property

		' Token: 0x17000F5D RID: 3933
		' (get) Token: 0x0600441A RID: 17434 RVA: 0x001C2A91 File Offset: 0x001C0C91
		' (set) Token: 0x0600441B RID: 17435 RVA: 0x001C2A99 File Offset: 0x001C0C99
		<DefaultValue(21)>
		<O_Oo00Oo000O0(8.142)>
		<DisplayName("端口号")>
		<Category("设置")>
		Public Property Port As Integer
			Get
				Return Me.OO0.___.
			End Get
			Set(value As Integer)
				Me.OO0.___. = value
			End Set
		End Property

		' Token: 0x17000F5E RID: 3934
		' (get) Token: 0x0600441C RID: 17436 RVA: 0x001C2AA2 File Offset: 0x001C0CA2
		' (set) Token: 0x0600441D RID: 17437 RVA: 0x001C2AAA File Offset: 0x001C0CAA
		<O_Oo00Oo000O0(8.6)>
		<Category("设置")>
		<DisplayName("自动更新文件")>
		<Description("是否自动更新远程文件")>
		<DefaultValue(True)>
		Public Property AutoUpdate As Boolean
			Get
				Return Me.o__o_0.0_.
			End Get
			Set(value As Boolean)
				Me.o__o_0.0_. = value
			End Set
		End Property

		' Token: 0x17000F5F RID: 3935
		' (get) Token: 0x0600441E RID: 17438 RVA: 0x001C2AB3 File Offset: 0x001C0CB3
		' (set) Token: 0x0600441F RID: 17439 RVA: 0x001C2ABB File Offset: 0x001C0CBB
		<oO0oooo("2514")>
		<O_Oo00Oo000O0(0.0)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("显示图片文件之前执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property BeforeGetImage As EventString
			Get
				Return Me.O00oO_00O._.
			End Get
			Set(value As EventString)
				Me.O00oO_00O._. = value
			End Set
		End Property

		' Token: 0x17000F60 RID: 3936
		' (get) Token: 0x06004420 RID: 17440 RVA: 0x001C2AC4 File Offset: 0x001C0CC4
		' (set) Token: 0x06004421 RID: 17441 RVA: 0x001C2ACB File Offset: 0x001C0CCB
		<Browsable(False)>
		Public Property ToolTip As String
			Get
				Return ""
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001BB3 RID: 7091
		Private <<EMPTY_NAME>> As CustomPictureBox

		' Token: 0x04001BB4 RID: 7092
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BB5 RID: 7093
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BB6 RID: 7094
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BB7 RID: 7095
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BB8 RID: 7096
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BB9 RID: 7097
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BBA RID: 7098
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BBB RID: 7099
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BBC RID: 7100
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BBD RID: 7101
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BBE RID: 7102
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
