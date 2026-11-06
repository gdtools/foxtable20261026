Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000466 RID: 1126
	<OoO0___o("ContextCommandMenu")>
	Friend Class ContextCommandMenu
		Inherits ContextCommand

		' Token: 0x06004B7F RID: 19327 RVA: 0x001FFE4B File Offset: 0x001FE04B
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010AB RID: 4267
		' (get) Token: 0x06004B80 RID: 19328 RVA: 0x001FFE5C File Offset: 0x001FE05C
		' (set) Token: 0x06004B81 RID: 19329 RVA: 0x001FFE63 File Offset: 0x001FE063
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(100.0)>
		<Category("属性")>
		<DisplayName("子菜单项目")>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010AC RID: 4268
		' (get) Token: 0x06004B82 RID: 19330 RVA: 0x001FFE65 File Offset: 0x001FE065
		' (set) Token: 0x06004B83 RID: 19331 RVA: 0x001FFE6D File Offset: 0x001FE06D
		<oO0oooo("1335")>
		<Description("展开菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property Popup As EventString
			Get
				Return Me.Oo_oo.O0O_0OO0.
			End Get
			Set(value As EventString)
				Me.Oo_oo.O0O_0OO0. = value
			End Set
		End Property

		' Token: 0x170010AD RID: 4269
		' (get) Token: 0x06004B84 RID: 19332 RVA: 0x001FFE76 File Offset: 0x001FE076
		' (set) Token: 0x06004B85 RID: 19333 RVA: 0x001FFE7E File Offset: 0x001FE07E
		<oO0oooo("1336")>
		<Description("关闭菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property Closed As EventString
			Get
				Return Me.O_o_.___oO0_O.
			End Get
			Set(value As EventString)
				Me.O_o_.___oO0_O. = value
			End Set
		End Property

		' Token: 0x170010AE RID: 4270
		' (get) Token: 0x06004B86 RID: 19334 RVA: 0x001FFE87 File Offset: 0x001FE087
		' (set) Token: 0x06004B87 RID: 19335 RVA: 0x001FFE8A File Offset: 0x001FE08A
		<Browsable(False)>
		Public Property Click As EventString
			Get
				Return Nothing
			End Get
			Set(value As EventString)
			End Set
		End Property

		' Token: 0x04001EFC RID: 7932
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001EFD RID: 7933
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
