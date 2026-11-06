Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200048B RID: 1163
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTabCollection
		' Token: 0x17001178 RID: 4472
		' (get) Token: 0x06004D38 RID: 19768 RVA: 0x00201774 File Offset: 0x001FF974
		' (set) Token: 0x06004D39 RID: 19769 RVA: 0x0020177B File Offset: 0x001FF97B
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		<Category("属性")>
		<DisplayName("功能区")>
		Public Property Tabs As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property
	End Class
End Namespace
