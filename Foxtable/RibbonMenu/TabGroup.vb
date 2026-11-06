Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000034 RID: 52
	<oO0oooo("3088")>
	<ComVisible(True)>
	Public Class TabGroup
		' Token: 0x060001AB RID: 427 RVA: 0x00004BD9 File Offset: 0x00002DD9
		Public Sub New(A_0 As RibbonContextualTabGroup)
			Me.o__Oo__.O__. = A_0
			Me.o__Oo__.O__. = New RibbonTabCollection(Me.o__Oo__.O__..Tabs)
		End Sub

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060001AC RID: 428 RVA: 0x00004BFE File Offset: 0x00002DFE
		Friend ReadOnly Property RibbonTabGroup As RibbonContextualTabGroup
			Get
				Return Me.o__Oo__.O__.
			End Get
		End Property

		' Token: 0x060001AD RID: 429 RVA: 0x00004C08 File Offset: 0x00002E08
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonContextualTabGroup()
			Me.o__Oo__.O__..Name = A_0
			Me.o__Oo__.O__..Text = A_0
			Me.o__Oo__.O__. = New RibbonTabCollection(Me.o__Oo__.O__..Tabs)
		End Sub

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x060001AE RID: 430 RVA: 0x00004C54 File Offset: 0x00002E54
		Public ReadOnly Property RibbonTabs As RibbonTabCollection
			Get
				Return Me.o__Oo__.O__.
			End Get
		End Property

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x060001AF RID: 431 RVA: 0x00004C5C File Offset: 0x00002E5C
		Public ReadOnly Property Name As String
			Get
				Return Me.o__Oo__.O__..Name
			End Get
		End Property

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x060001B0 RID: 432 RVA: 0x00004C69 File Offset: 0x00002E69
		' (set) Token: 0x060001B1 RID: 433 RVA: 0x00004C76 File Offset: 0x00002E76
		Public Property Text As String
			Get
				Return Me.o__Oo__.O__..Text
			End Get
			Set(value As String)
				Me.o__Oo__.O__..Text = value
			End Set
		End Property

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x060001B2 RID: 434 RVA: 0x00004C84 File Offset: 0x00002E84
		' (set) Token: 0x060001B3 RID: 435 RVA: 0x00004C91 File Offset: 0x00002E91
		Public Property Color As ContextualTabColor
			Get
				Return Me.o__Oo__.O__..Color
			End Get
			Set(value As ContextualTabColor)
				Me.o__Oo__.O__..Color = value
			End Set
		End Property

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x060001B4 RID: 436 RVA: 0x00004C9F File Offset: 0x00002E9F
		' (set) Token: 0x060001B5 RID: 437 RVA: 0x00004CAC File Offset: 0x00002EAC
		Public Property ForeColor As Color
			Get
				Return Me.o__Oo__.O__..ForeColor
			End Get
			Set(value As Color)
				Me.o__Oo__.O__..ForeColor = value
			End Set
		End Property

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x060001B6 RID: 438 RVA: 0x00004CBA File Offset: 0x00002EBA
		' (set) Token: 0x060001B7 RID: 439 RVA: 0x00004CC7 File Offset: 0x00002EC7
		Public Property ToolTip As String
			Get
				Return Me.o__Oo__.O__..ToolTip
			End Get
			Set(value As String)
				Me.o__Oo__.O__..ToolTip = value
			End Set
		End Property

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x060001B8 RID: 440 RVA: 0x00004CD5 File Offset: 0x00002ED5
		' (set) Token: 0x060001B9 RID: 441 RVA: 0x00004CE2 File Offset: 0x00002EE2
		Public Property Visible As Boolean
			Get
				Return Me.o__Oo__.O__..Visible
			End Get
			Set(value As Boolean)
				Me.o__Oo__.O__..Visible = value
			End Set
		End Property

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x060001BA RID: 442 RVA: 0x00004CF0 File Offset: 0x00002EF0
		' (set) Token: 0x060001BB RID: 443 RVA: 0x00004CFD File Offset: 0x00002EFD
		Public Property Clickable As Boolean
			Get
				Return Me.o__Oo__.O__..Clickable
			End Get
			Set(value As Boolean)
				Me.o__Oo__.O__..Clickable = value
			End Set
		End Property

		' Token: 0x04000055 RID: 85
		Private <<EMPTY_NAME>> As RibbonContextualTabGroup

		' Token: 0x04000056 RID: 86
		Private <<EMPTY_NAME>> As RibbonTabCollection
	End Class
End Namespace
