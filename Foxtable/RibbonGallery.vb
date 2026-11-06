Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000479 RID: 1145
	<OoO0___o("RibbonGallery")>
	Friend Class RibbonGallery
		Inherits RibbonDropDownItem

		' Token: 0x06004C6B RID: 19563 RVA: 0x00200E71 File Offset: 0x001FF071
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.oO_.OO__OOo_o0. = True
			Me.oO_.OO__OOo_o0. = 72
			Me.Oo_0O0.O_o. = 60
			Me.o0oO000O.OO. = 3
			Me.Oo_0O0.O_o. = True
			Me.o0oO000O.OO. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700111A RID: 4378
		' (get) Token: 0x06004C6C RID: 19564 RVA: 0x00200EAE File Offset: 0x001FF0AE
		' (set) Token: 0x06004C6D RID: 19565 RVA: 0x00200EC9 File Offset: 0x001FF0C9
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				If Me.O_oOO_.o0. Is Nothing Then
					Me.O_oOO_.o0. = ""
				End If
				Return Me.O_oOO_.o0.
			End Get
			Set(value As String)
				Me.O_oOO_.o0. = value
			End Set
		End Property

		' Token: 0x1700111B RID: 4379
		' (get) Token: 0x06004C6E RID: 19566 RVA: 0x00200ED2 File Offset: 0x001FF0D2
		' (set) Token: 0x06004C6F RID: 19567 RVA: 0x00200EDA File Offset: 0x001FF0DA
		<Category("属性")>
		<O_Oo00Oo000O0(1.2)>
		<DisplayName("命令模式")>
		<DefaultValue(True)>
		Public Property CommandMode As Boolean
			Get
				Return Me.Oo_0O0.O_o.
			End Get
			Set(value As Boolean)
				Me.Oo_0O0.O_o. = value
			End Set
		End Property

		' Token: 0x1700111C RID: 4380
		' (get) Token: 0x06004C70 RID: 19568 RVA: 0x00200EE3 File Offset: 0x001FF0E3
		' (set) Token: 0x06004C71 RID: 19569 RVA: 0x00200EEB File Offset: 0x001FF0EB
		<O_Oo00Oo000O0(1.21)>
		<DisplayName("默认展开")>
		<DefaultValue(True)>
		<Category("属性")>
		Public Property Expand As Boolean
			Get
				Return Me.oO_.OO__OOo_o0.
			End Get
			Set(value As Boolean)
				Me.oO_.OO__OOo_o0. = value
			End Set
		End Property

		' Token: 0x1700111D RID: 4381
		' (get) Token: 0x06004C72 RID: 19570 RVA: 0x00200EF4 File Offset: 0x001FF0F4
		' (set) Token: 0x06004C73 RID: 19571 RVA: 0x00200EFC File Offset: 0x001FF0FC
		<O_Oo00Oo000O0(1.3)>
		<DisplayName("项目宽度")>
		<DefaultValue(True)>
		<Description("项目宽度，单位为像素")>
		<Category("属性")>
		Public Property ItemWidth As Integer
			Get
				Return Me.oO_.OO__OOo_o0.
			End Get
			Set(value As Integer)
				Me.oO_.OO__OOo_o0. = value
			End Set
		End Property

		' Token: 0x1700111E RID: 4382
		' (get) Token: 0x06004C74 RID: 19572 RVA: 0x00200F05 File Offset: 0x001FF105
		' (set) Token: 0x06004C75 RID: 19573 RVA: 0x00200F0D File Offset: 0x001FF10D
		<O_Oo00Oo000O0(1.31)>
		<DefaultValue(True)>
		<Description("项目高度，单位为像素")>
		<Category("属性")>
		<DisplayName("项目高度")>
		Public Property ItemHeight As Integer
			Get
				Return Me.Oo_0O0.O_o.
			End Get
			Set(value As Integer)
				Me.Oo_0O0.O_o. = value
			End Set
		End Property

		' Token: 0x1700111F RID: 4383
		' (get) Token: 0x06004C76 RID: 19574 RVA: 0x00200F16 File Offset: 0x001FF116
		' (set) Token: 0x06004C77 RID: 19575 RVA: 0x00200F1E File Offset: 0x001FF11E
		<DefaultValue(True)>
		<Description("标题是否位于图标的下面")>
		<O_Oo00Oo000O0(1.32)>
		<DisplayName("项目标题居下")>
		<Category("属性")>
		Public Property VerticalLayout As Boolean
			Get
				Return Me.o0oO000O.OO.
			End Get
			Set(value As Boolean)
				Me.o0oO000O.OO. = value
			End Set
		End Property

		' Token: 0x17001120 RID: 4384
		' (get) Token: 0x06004C78 RID: 19576 RVA: 0x00200F27 File Offset: 0x001FF127
		' (set) Token: 0x06004C79 RID: 19577 RVA: 0x00200F2F File Offset: 0x001FF12F
		<O_Oo00Oo000O0(1.4)>
		<Category("属性")>
		<DisplayName("可见项目数")>
		<DefaultValue(True)>
		<Description("横向可见项目数")>
		Public Property VisibleItems As Integer
			Get
				Return Me.o0oO000O.OO.
			End Get
			Set(value As Integer)
				If value < 1 Then
					value = 1
				End If
				Me.o0oO000O.OO. = value
			End Set
		End Property

		' Token: 0x17001121 RID: 4385
		' (get) Token: 0x06004C7A RID: 19578 RVA: 0x00200F3F File Offset: 0x001FF13F
		' (set) Token: 0x06004C7B RID: 19579 RVA: 0x00200F46 File Offset: 0x001FF146
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<Category("属性")>
		<O_Oo00Oo000O0(100.0)>
		<DisplayName("菜单项目")>
		Public Property MenuItems As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x17001122 RID: 4386
		' (get) Token: 0x06004C7C RID: 19580 RVA: 0x00200F48 File Offset: 0x001FF148
		' (set) Token: 0x06004C7D RID: 19581 RVA: 0x00200F50 File Offset: 0x001FF150
		<oO0oooo("3083")>
		<Description("非命令模式查下，选择不同项目后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.1)>
		Public Property ItemSelected As EventString
			Get
				Return Me.oO_.OO__OOo_o0.
			End Get
			Set(value As EventString)
				Me.oO_.OO__OOo_o0. = value
			End Set
		End Property

		' Token: 0x17001123 RID: 4387
		' (get) Token: 0x06004C7E RID: 19582 RVA: 0x00200F59 File Offset: 0x001FF159
		' (set) Token: 0x06004C7F RID: 19583 RVA: 0x00200F61 File Offset: 0x001FF161
		<oO0oooo("3082")>
		<Category("事件")>
		<Description("命令模式查下，单击不同项目后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.2)>
		Public Property ItemClick As EventString
			Get
				Return Me.Oo_0O0.O_o.
			End Get
			Set(value As EventString)
				Me.Oo_0O0.O_o. = value
			End Set
		End Property

		' Token: 0x04001F65 RID: 8037
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F66 RID: 8038
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F67 RID: 8039
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F68 RID: 8040
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F69 RID: 8041
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001F6A RID: 8042
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F6B RID: 8043
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F6C RID: 8044
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F6D RID: 8045
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
