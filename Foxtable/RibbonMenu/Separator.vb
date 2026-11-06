Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000012 RID: 18
	<ComVisible(True)>
	Public Class Separator
		Inherits RibbonItem

		' Token: 0x06000084 RID: 132 RVA: 0x00002CC9 File Offset: 0x00000EC9
		Friend Sub New(A_0 As RibbonSeparator)
			MyBase.New(A_0)
			Me.OO0.0OOo__. = A_0
		End Sub

		' Token: 0x06000085 RID: 133 RVA: 0x00002CD9 File Offset: 0x00000ED9
		Public Sub New(A_0 As String)
			Me.OO0.0OOo__. = New RibbonSeparator()
			Me.oOo_.0o_O_O_0. = Me.OO0.0OOo__.
			Me.OO0.0OOo__..ID = A_0
		End Sub

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000086 RID: 134 RVA: 0x00002D04 File Offset: 0x00000F04
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00002D0B File Offset: 0x00000F0B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Text As String
			Get
				Return ""
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04000017 RID: 23
		Friend <<EMPTY_NAME>> As RibbonSeparator
	End Class
End Namespace
