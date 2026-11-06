Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001A RID: 26
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ToggleGroup
		Inherits RibbonItem

		' Token: 0x060000C3 RID: 195 RVA: 0x000031F6 File Offset: 0x000013F6
		Friend Sub New(A_0 As RibbonToggleGroup)
			MyBase.New(A_0)
			Me.o__Oo__.O__. = A_0
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x00003206 File Offset: 0x00001406
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonToggleGroup()
			Me.oOo_.0o_O_O_0. = Me.o__Oo__.O__.
			Me.o__Oo__.O__..ID = A_0
		End Sub

		' Token: 0x17000054 RID: 84
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000C6 RID: 198 RVA: 0x0000323F File Offset: 0x0000143F
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.o__Oo__.O__. Is Nothing Then
					Me.o__Oo__.O__. = New RibbonItemCollection(Me.o__Oo__.O__..Items)
				End If
				Return Me.o__Oo__.O__.
			End Get
		End Property

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x00003265 File Offset: 0x00001465
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x00003272 File Offset: 0x00001472
		Public Property AllowAllButtonsUp As Boolean
			Get
				Return Me.o__Oo__.O__..AllowAllButtonsUp
			End Get
			Set(value As Boolean)
				Me.o__Oo__.O__..AllowAllButtonsUp = value
			End Set
		End Property

		' Token: 0x04000024 RID: 36
		Friend <<EMPTY_NAME>> As RibbonToggleGroup

		' Token: 0x04000025 RID: 37
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
