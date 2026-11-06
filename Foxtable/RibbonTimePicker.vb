Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200047D RID: 1149
	<OoO0___o("RibbonTimePicker")>
	<oO0oooo("3090")>
	Friend Class RibbonTimePicker
		Inherits RibbonItem

		' Token: 0x06004CB9 RID: 19641 RVA: 0x002011EC File Offset: 0x001FF3EC
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.OOoo_o00.O___0. = "标题:"
			Me.OOoo_o00.O___0. = 60
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700113F RID: 4415
		' (get) Token: 0x06004CBA RID: 19642 RVA: 0x00201210 File Offset: 0x001FF410
		' (set) Token: 0x06004CBB RID: 19643 RVA: 0x0020122B File Offset: 0x001FF42B
		<DefaultValue("标题:")>
		<Category("属性")>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("标题")>
		Public Property Label As String
			Get
				If Me.OOoo_o00.O___0. Is Nothing Then
					Me.OOoo_o00.O___0. = ""
				End If
				Return Me.OOoo_o00.O___0.
			End Get
			Set(value As String)
				Me.OOoo_o00.O___0. = value
			End Set
		End Property

		' Token: 0x17001140 RID: 4416
		' (get) Token: 0x06004CBC RID: 19644 RVA: 0x00201234 File Offset: 0x001FF434
		' (set) Token: 0x06004CBD RID: 19645 RVA: 0x0020123C File Offset: 0x001FF43C
		<O_Oo00Oo000O0(1.2)>
		<Category("属性")>
		<DisplayName("初始值")>
		Public Property Value As TimeSpan
			Get
				Return Me.OOoo_o00.O___0.
			End Get
			Set(value As TimeSpan)
				Me.OOoo_o00.O___0. = value
			End Set
		End Property

		' Token: 0x17001141 RID: 4417
		' (get) Token: 0x06004CBE RID: 19646 RVA: 0x00201245 File Offset: 0x001FF445
		' (set) Token: 0x06004CBF RID: 19647 RVA: 0x0020124D File Offset: 0x001FF44D
		<DisplayName("宽度")>
		<O_Oo00Oo000O0(1.3)>
		<Category("属性")>
		Public Property TextAreaWidth As Integer
			Get
				Return Me.OOoo_o00.O___0.
			End Get
			Set(value As Integer)
				Me.OOoo_o00.O___0. = value
			End Set
		End Property

		' Token: 0x17001142 RID: 4418
		' (get) Token: 0x06004CC0 RID: 19648 RVA: 0x00201256 File Offset: 0x001FF456
		' (set) Token: 0x06004CC1 RID: 19649 RVA: 0x0020125E File Offset: 0x001FF45E
		<Category("属性")>
		<O_Oo00Oo000O0(1.4)>
		<DisplayName("长时间格式")>
		Public Property LongTimeFormat As Boolean
			Get
				Return Me.OOoo_o00.O___0.
			End Get
			Set(value As Boolean)
				Me.OOoo_o00.O___0. = value
			End Set
		End Property

		' Token: 0x17001143 RID: 4419
		' (get) Token: 0x06004CC2 RID: 19650 RVA: 0x00201267 File Offset: 0x001FF467
		' (set) Token: 0x06004CC3 RID: 19651 RVA: 0x0020126F File Offset: 0x001FF46F
		<O_Oo00Oo000O0(0.1)>
		<Description("取消修改后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCanceled As EventString
			Get
				Return Me.OOoo_o00.O___0.
			End Get
			Set(value As EventString)
				Me.OOoo_o00.O___0. = value
			End Set
		End Property

		' Token: 0x17001144 RID: 4420
		' (get) Token: 0x06004CC4 RID: 19652 RVA: 0x00201278 File Offset: 0x001FF478
		' (set) Token: 0x06004CC5 RID: 19653 RVA: 0x00201280 File Offset: 0x001FF480
		<O_Oo00Oo000O0(0.2)>
		<Category("事件")>
		<Description("提交修改后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property ChangeCommitted As EventString
			Get
				Return Me.OoOO000_0O_.o.
			End Get
			Set(value As EventString)
				Me.OoOO000_0O_.o. = value
			End Set
		End Property

		' Token: 0x17001145 RID: 4421
		' (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00201289 File Offset: 0x001FF489
		' (set) Token: 0x06004CC7 RID: 19655 RVA: 0x00201291 File Offset: 0x001FF491
		<O_Oo00Oo000O0(0.3)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<Description("值改变后执行。")>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.O_.OOo0.
			End Get
			Set(value As EventString)
				Me.O_.OOo0. = value
			End Set
		End Property

		' Token: 0x17001146 RID: 4422
		' (get) Token: 0x06004CC8 RID: 19656 RVA: 0x0020129A File Offset: 0x001FF49A
		' (set) Token: 0x06004CC9 RID: 19657 RVA: 0x002012A2 File Offset: 0x001FF4A2
		<Description("获得输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.4)>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property GotFocus As EventString
			Get
				Return Me.o0.0o_ooOO_o.
			End Get
			Set(value As EventString)
				Me.o0.0o_ooOO_o. = value
			End Set
		End Property

		' Token: 0x17001147 RID: 4423
		' (get) Token: 0x06004CCA RID: 19658 RVA: 0x002012AB File Offset: 0x001FF4AB
		' (set) Token: 0x06004CCB RID: 19659 RVA: 0x002012B3 File Offset: 0x001FF4B3
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.5)>
		<Category("事件")>
		<Description("失去输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		Public Property LostFocus As EventString
			Get
				Return Me.oOO_.O.
			End Get
			Set(value As EventString)
				Me.oOO_.O. = value
			End Set
		End Property

		' Token: 0x17001148 RID: 4424
		' (get) Token: 0x06004CCC RID: 19660 RVA: 0x002012BC File Offset: 0x001FF4BC
		' (set) Token: 0x06004CCD RID: 19661 RVA: 0x002012BF File Offset: 0x001FF4BF
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001F85 RID: 8069
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F86 RID: 8070
		Private <<EMPTY_NAME>> As TimeSpan

		' Token: 0x04001F87 RID: 8071
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F88 RID: 8072
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F89 RID: 8073
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F8A RID: 8074
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F8B RID: 8075
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F8C RID: 8076
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F8D RID: 8077
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
