Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000023 RID: 35
	<ComVisible(True)>
	Public Class BottomToolBar
		Inherits RibbonItem

		' Token: 0x06000119 RID: 281 RVA: 0x00003816 File Offset: 0x00001A16
		Friend Sub New(A_0 As RibbonBottomToolBar)
			MyBase.New(A_0)
			Me.oOoOoOoO._o0. = A_0
		End Sub

		' Token: 0x17000082 RID: 130
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x0600011B RID: 283 RVA: 0x00003834 File Offset: 0x00001A34
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.oOoOoOoO._o0. Is Nothing Then
					Me.oOoOoOoO._o0. = New RibbonItemCollection(Me.oOoOoOoO._o0..Items)
				End If
				Return Me.oOoOoOoO._o0.
			End Get
		End Property

		' Token: 0x04000036 RID: 54
		Private <<EMPTY_NAME>> As RibbonBottomToolBar

		' Token: 0x04000037 RID: 55
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
