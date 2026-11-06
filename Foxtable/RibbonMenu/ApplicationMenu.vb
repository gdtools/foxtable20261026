Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000024 RID: 36
	<ComVisible(True)>
	Public Class ApplicationMenu
		Inherits RibbonItem

		' Token: 0x0600011C RID: 284 RVA: 0x0000385A File Offset: 0x00001A5A
		Friend Sub New(A_0 As RibbonApplicationMenu)
			MyBase.New(A_0)
			Me.oOoOoOoO._o0. = A_0
		End Sub

		' Token: 0x0600011D RID: 285 RVA: 0x0000386A File Offset: 0x00001A6A
		Public Sub New()
			Me.oOoOoOoO._o0. = New RibbonApplicationMenu()
			Me.oOo_.0o_O_O_0. = Me.oOoOoOoO._o0.
		End Sub

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x0600011E RID: 286 RVA: 0x00003889 File Offset: 0x00001A89
		' (set) Token: 0x0600011F RID: 287 RVA: 0x00003896 File Offset: 0x00001A96
		Public Property Text As String
			Get
				Return Me.oOoOoOoO._o0..Text
			End Get
			Set(value As String)
				Me.oOoOoOoO._o0..Text = value
			End Set
		End Property

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x06000120 RID: 288 RVA: 0x000038A4 File Offset: 0x00001AA4
		' (set) Token: 0x06000121 RID: 289 RVA: 0x000038BA File Offset: 0x00001ABA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DropdownWidth As Integer
			Get
				Return Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.DropDownWidth
			End Get
			Set(value As Integer)
				Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.DropDownWidth = value
			End Set
		End Property

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000122 RID: 290 RVA: 0x000038D1 File Offset: 0x00001AD1
		' (set) Token: 0x06000123 RID: 291 RVA: 0x000038D8 File Offset: 0x00001AD8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property RecentFiles As Integer
			Get
				Return O_O0OO.o0OoO00OO.00O.
			End Get
			Set(value As Integer)
				O_O0OO.o0OoO00OO.00O. = value
			End Set
		End Property

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x06000124 RID: 292 RVA: 0x000038E0 File Offset: 0x00001AE0
		Public ReadOnly Property LeftItems As RibbonItemCollection
			Get
				If Me.oOoOoOoO._o0. Is Nothing Then
					Me.oOoOoOoO._o0. = New RibbonItemCollection(Me.oOoOoOoO._o0..LeftPaneItems)
				End If
				Return Me.oOoOoOoO._o0.
			End Get
		End Property

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x06000125 RID: 293 RVA: 0x00003906 File Offset: 0x00001B06
		Public ReadOnly Property RightItems As RibbonItemCollection
			Get
				If Me.o0O__.O. Is Nothing Then
					Me.o0O__.O. = New RibbonItemCollection(Me.oOoOoOoO._o0..RightPaneItems)
				End If
				Return Me.o0O__.O.
			End Get
		End Property

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x06000126 RID: 294 RVA: 0x0000392C File Offset: 0x00001B2C
		Public ReadOnly Property BottomItems As RibbonItemCollection
			Get
				If Me.Oo._o_0O. Is Nothing Then
					Me.Oo._o_0O. = New RibbonItemCollection(Me.oOoOoOoO._o0..BottomPaneItems)
				End If
				Return Me.Oo._o_0O.
			End Get
		End Property

		' Token: 0x04000038 RID: 56
		Private <<EMPTY_NAME>> As RibbonApplicationMenu

		' Token: 0x04000039 RID: 57
		Private <<EMPTY_NAME>> As RibbonItemCollection

		' Token: 0x0400003A RID: 58
		Private <<EMPTY_NAME>> As RibbonItemCollection

		' Token: 0x0400003B RID: 59
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
