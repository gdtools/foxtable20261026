Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000022 RID: 34
	<ComVisible(True)>
	Public Class TopToolBar
		Inherits RibbonItem

		' Token: 0x06000116 RID: 278 RVA: 0x000037D2 File Offset: 0x000019D2
		Friend Sub New(A_0 As RibbonTopToolBar)
			MyBase.New(A_0)
			Me.O.oOOO. = A_0
		End Sub

		' Token: 0x17000080 RID: 128
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000118 RID: 280 RVA: 0x000037F0 File Offset: 0x000019F0
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.o__Oo__.O__. Is Nothing Then
					Me.o__Oo__.O__. = New RibbonItemCollection(Me.O.oOOO..Items)
				End If
				Return Me.o__Oo__.O__.
			End Get
		End Property

		' Token: 0x04000034 RID: 52
		Private <<EMPTY_NAME>> As RibbonTopToolBar

		' Token: 0x04000035 RID: 53
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
