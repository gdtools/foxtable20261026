Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x02000468 RID: 1128
	Friend Class ContextMenuCollection
		' Token: 0x170010B2 RID: 4274
		' (get) Token: 0x06004B90 RID: 19344 RVA: 0x001FFED0 File Offset: 0x001FE0D0
		' (set) Token: 0x06004B91 RID: 19345 RVA: 0x001FFED7 File Offset: 0x001FE0D7
		<O_Oo00Oo000O0(5.0)>
		<Category("属性")>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<DisplayName("快捷菜单")>
		Public Property ContextMenus As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property
	End Class
End Namespace
