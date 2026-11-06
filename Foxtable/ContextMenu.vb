Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000467 RID: 1127
	<OoO0___o("ContextMenu")>
	Friend Class ContextMenu
		Inherits RibbonBase

		' Token: 0x06004B88 RID: 19336 RVA: 0x001FFE8C File Offset: 0x001FE08C
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010AF RID: 4271
		' (get) Token: 0x06004B89 RID: 19337 RVA: 0x001FFE9D File Offset: 0x001FE09D
		' (set) Token: 0x06004B8A RID: 19338 RVA: 0x001FFEA4 File Offset: 0x001FE0A4
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(100.0)>
		<Category("属性")>
		<DisplayName("菜单项目")>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010B0 RID: 4272
		' (get) Token: 0x06004B8B RID: 19339 RVA: 0x001FFEA6 File Offset: 0x001FE0A6
		' (set) Token: 0x06004B8C RID: 19340 RVA: 0x001FFEAE File Offset: 0x001FE0AE
		<Category("事件")>
		<oO0oooo("1329")>
		<Description("打开快捷菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property Popup As EventString
			Get
				Return Me.Oo_oo.O0O_0OO0.
			End Get
			Set(value As EventString)
				Me.Oo_oo.O0O_0OO0. = value
			End Set
		End Property

		' Token: 0x170010B1 RID: 4273
		' (get) Token: 0x06004B8D RID: 19341 RVA: 0x001FFEB7 File Offset: 0x001FE0B7
		' (set) Token: 0x06004B8E RID: 19342 RVA: 0x001FFEBF File Offset: 0x001FE0BF
		<oO0oooo("1330")>
		<Category("事件")>
		<Description("关闭快捷菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property Closed As EventString
			Get
				Return Me.O_o_.___oO0_O.
			End Get
			Set(value As EventString)
				Me.O_o_.___oO0_O. = value
			End Set
		End Property

		' Token: 0x04001EFE RID: 7934
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001EFF RID: 7935
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
