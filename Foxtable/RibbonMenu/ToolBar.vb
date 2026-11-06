Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001D RID: 29
	<ComVisible(True)>
	Public Class ToolBar
		Inherits RibbonItem

		' Token: 0x060000E8 RID: 232 RVA: 0x0000349E File Offset: 0x0000169E
		Friend Sub New(A_0 As RibbonToolBar)
			MyBase.New(A_0)
			Me.o__Oo__.O__. = A_0
		End Sub

		' Token: 0x060000E9 RID: 233 RVA: 0x000034AE File Offset: 0x000016AE
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonToolBar()
			Me.oOo_.0o_O_O_0. = Me.o__Oo__.O__.
			Me.o__Oo__.O__..ID = A_0
		End Sub

		' Token: 0x17000067 RID: 103
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x060000EB RID: 235 RVA: 0x000034E7 File Offset: 0x000016E7
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.o__Oo__.O__. Is Nothing Then
					Me.o__Oo__.O__. = New RibbonItemCollection(Me.o__Oo__.O__..Items)
				End If
				Return Me.o__Oo__.O__.
			End Get
		End Property

		' Token: 0x0400002A RID: 42
		Friend <<EMPTY_NAME>> As RibbonToolBar

		' Token: 0x0400002B RID: 43
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
