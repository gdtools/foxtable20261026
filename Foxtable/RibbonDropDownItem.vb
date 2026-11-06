Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200046B RID: 1131
	Friend Class RibbonDropDownItem
		Inherits RibbonItem

		' Token: 0x06004BEB RID: 19435 RVA: 0x0020093A File Offset: 0x001FEB3A
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
		End Sub

		' Token: 0x170010E0 RID: 4320
		' (get) Token: 0x06004BEC RID: 19436 RVA: 0x00200943 File Offset: 0x001FEB43
		' (set) Token: 0x06004BED RID: 19437 RVA: 0x0020094A File Offset: 0x001FEB4A
		<O_Oo00Oo000O0(100.0)>
		<DisplayName("项目")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<Category("属性")>
		Public Property Items As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property

		' Token: 0x170010E1 RID: 4321
		' (get) Token: 0x06004BEE RID: 19438 RVA: 0x0020094C File Offset: 0x001FEB4C
		' (set) Token: 0x06004BEF RID: 19439 RVA: 0x00200954 File Offset: 0x001FEB54
		<Category("事件")>
		<Description("打开下拉列表或菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property DropDown As EventString
			Get
				Return Me.OO_._O0.
			End Get
			Set(value As EventString)
				Me.OO_._O0. = value
			End Set
		End Property

		' Token: 0x170010E2 RID: 4322
		' (get) Token: 0x06004BF0 RID: 19440 RVA: 0x0020095D File Offset: 0x001FEB5D
		' (set) Token: 0x06004BF1 RID: 19441 RVA: 0x00200965 File Offset: 0x001FEB65
		<Category("事件")>
		<O_Oo00Oo000O0(4.0)>
		<Description("关闭下拉列表或菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		Public Property DropDownClosed As EventString
			Get
				Return Me.o_0O.Ooo.
			End Get
			Set(value As EventString)
				Me.o_0O.Ooo. = value
			End Set
		End Property

		' Token: 0x04001F34 RID: 7988
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F35 RID: 7989
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
