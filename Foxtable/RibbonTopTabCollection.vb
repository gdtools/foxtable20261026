Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing.Design

Namespace Foxtable
	' Token: 0x0200047F RID: 1151
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonTopTabCollection
		' Token: 0x1700114F RID: 4431
		' (get) Token: 0x06004CDC RID: 19676 RVA: 0x00201373 File Offset: 0x001FF573
		' (set) Token: 0x06004CDD RID: 19677 RVA: 0x0020137A File Offset: 0x001FF57A
		<Category("属性")>
		<DisplayName("功能区组")>
		<O_Oo00Oo000O0(5.0)>
		<Editor(GetType(RibbonItemCollectionEditor), GetType(UITypeEditor))>
		Public Property Tabs As Hashtable
			Get
				Return New Hashtable()
			End Get
			Set(value As Hashtable)
			End Set
		End Property
	End Class
End Namespace
