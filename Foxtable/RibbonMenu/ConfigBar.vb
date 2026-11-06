Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000021 RID: 33
	<oO0oooo("1094")>
	<ComVisible(True)>
	Public Class ConfigBar
		Inherits RibbonItem

		' Token: 0x06000113 RID: 275 RVA: 0x0000378E File Offset: 0x0000198E
		Friend Sub New(A_0 As RibbonConfigToolBar)
			MyBase.New(A_0)
			Me.oo0OOOO_._. = A_0
		End Sub

		' Token: 0x1700007E RID: 126
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000115 RID: 277 RVA: 0x000037AC File Offset: 0x000019AC
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.oo0OOOO_._. Is Nothing Then
					Me.oo0OOOO_._. = New RibbonItemCollection(Me.oo0OOOO_._..Items)
				End If
				Return Me.oo0OOOO_._.
			End Get
		End Property

		' Token: 0x04000032 RID: 50
		Private <<EMPTY_NAME>> As RibbonConfigToolBar

		' Token: 0x04000033 RID: 51
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
