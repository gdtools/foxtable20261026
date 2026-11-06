Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200046A RID: 1130
	<oO0oooo("1092")>
	Friend Class RibbonApplicationMenu
		Inherits RibbonDropDownItem

		' Token: 0x06004BD7 RID: 19415 RVA: 0x0020088E File Offset: 0x001FEA8E
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.oo00OO_0.0o000. = 400
			Me.O_0oO_0o.o_0Oo. = 6
			Me.oo00OO_0.0o000. = "文件"
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
			MyBase.Name = "开始菜单"
		End Sub

		' Token: 0x170010D4 RID: 4308
		' (get) Token: 0x06004BD8 RID: 19416 RVA: 0x002008C7 File Offset: 0x001FEAC7
		<Browsable(False)>
		Public ReadOnly Property Name As String
			Get
				Return "开始菜单"
			End Get
		End Property

		' Token: 0x170010D5 RID: 4309
		' (get) Token: 0x06004BD9 RID: 19417 RVA: 0x002008CE File Offset: 0x001FEACE
		<Browsable(False)>
		Public ReadOnly Property Enabled As Boolean
			Get
				Return True
			End Get
		End Property

		' Token: 0x170010D6 RID: 4310
		' (get) Token: 0x06004BDA RID: 19418 RVA: 0x002008D1 File Offset: 0x001FEAD1
		<Browsable(False)>
		Public ReadOnly Property TextImageRelation As TextImageRelationEnum
			Get
				Return TextImageRelationEnum.Automatic
			End Get
		End Property

		' Token: 0x170010D7 RID: 4311
		' (get) Token: 0x06004BDB RID: 19419 RVA: 0x002008D4 File Offset: 0x001FEAD4
		<Browsable(False)>
		Public ReadOnly Property LargeImage As String
			Get
				Return Nothing
			End Get
		End Property

		' Token: 0x170010D8 RID: 4312
		' (get) Token: 0x06004BDC RID: 19420 RVA: 0x002008D7 File Offset: 0x001FEAD7
		<Browsable(False)>
		Public ReadOnly Property SmallImage As String
			Get
				Return Nothing
			End Get
		End Property

		' Token: 0x170010D9 RID: 4313
		' (get) Token: 0x06004BDD RID: 19421 RVA: 0x002008DA File Offset: 0x001FEADA
		' (set) Token: 0x06004BDE RID: 19422 RVA: 0x002008DD File Offset: 0x001FEADD
		<Browsable(False)>
		Public Overrides Property AutoHideText As Boolean
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170010DA RID: 4314
		' (get) Token: 0x06004BDF RID: 19423 RVA: 0x002008DF File Offset: 0x001FEADF
		' (set) Token: 0x06004BE0 RID: 19424 RVA: 0x002008E7 File Offset: 0x001FEAE7
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				Return Me.oo00OO_0.0o000.
			End Get
			Set(value As String)
				Me.oo00OO_0.0o000. = value
			End Set
		End Property

		' Token: 0x170010DB RID: 4315
		' (get) Token: 0x06004BE1 RID: 19425 RVA: 0x002008F0 File Offset: 0x001FEAF0
		' (set) Token: 0x06004BE2 RID: 19426 RVA: 0x002008F8 File Offset: 0x001FEAF8
		<DisplayName("下拉宽度")>
		<O_Oo00Oo000O0(90.0)>
		<Category("属性")>
		<DefaultValue(400)>
		Public Property DropdownWidth As Integer
			Get
				Return Me.oo00OO_0.0o000.
			End Get
			Set(value As Integer)
				Me.oo00OO_0.0o000. = value
			End Set
		End Property

		' Token: 0x170010DC RID: 4316
		' (get) Token: 0x06004BE3 RID: 19427 RVA: 0x00200901 File Offset: 0x001FEB01
		' (set) Token: 0x06004BE4 RID: 19428 RVA: 0x00200909 File Offset: 0x001FEB09
		<O_Oo00Oo000O0(91.0)>
		<DisplayName("最近文件个数")>
		<DefaultValue(6)>
		<Description("在开始菜单右侧显示最近打开过文件的个数")>
		<Category("属性")>
		Public Property RecentFiles As Integer
			Get
				Return Me.O_0oO_0o.o_0Oo.
			End Get
			Set(value As Integer)
				Me.O_0oO_0o.o_0Oo. = value
				Main.O0O_.00_O0Oo_.()
			End Set
		End Property

		' Token: 0x170010DD RID: 4317
		' (get) Token: 0x06004BE5 RID: 19429 RVA: 0x00200917 File Offset: 0x001FEB17
		' (set) Token: 0x06004BE6 RID: 19430 RVA: 0x0020091E File Offset: 0x001FEB1E
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(102.0)>
		<Category("属性")>
		<DisplayName("右侧项目")>
		Public Property RightPaneItems As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010DE RID: 4318
		' (get) Token: 0x06004BE7 RID: 19431 RVA: 0x00200920 File Offset: 0x001FEB20
		' (set) Token: 0x06004BE8 RID: 19432 RVA: 0x00200927 File Offset: 0x001FEB27
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(103.0)>
		<DisplayName("底部项目")>
		<Category("属性")>
		Public Property BottomPaneItems As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010DF RID: 4319
		' (get) Token: 0x06004BE9 RID: 19433 RVA: 0x00200929 File Offset: 0x001FEB29
		' (set) Token: 0x06004BEA RID: 19434 RVA: 0x00200931 File Offset: 0x001FEB31
		<O0O0oOO00_0OO(True)>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("双击鼠标后执行。")>
		<Category("事件")>
		<O_Oo00Oo000O0(6.0)>
		<Browsable(False)>
		Public Property DoubleClick As EventString
			Get
				Return Me.oo00OO_0.0o000.
			End Get
			Set(value As EventString)
				Me.oo00OO_0.0o000. = value
			End Set
		End Property

		' Token: 0x04001F30 RID: 7984
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F31 RID: 7985
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F32 RID: 7986
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F33 RID: 7987
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
