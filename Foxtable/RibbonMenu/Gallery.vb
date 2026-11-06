Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001B RID: 27
	<ComVisible(True)>
	Public Class Gallery
		Inherits RibbonItem

		' Token: 0x060000C9 RID: 201 RVA: 0x00003280 File Offset: 0x00001480
		Friend Sub New(A_0 As o_o_Oo0__o_0)
			MyBase.New(A_0)
			Me.o_.o0_o. = A_0
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x00003290 File Offset: 0x00001490
		Public Sub New(A_0 As String)
			Me.o_.o0_o. = New o_o_Oo0__o_0()
			Me.oOo_.0o_O_O_0. = Me.o_.o0_o.
			Me.o_.o0_o..ID = A_0
		End Sub

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000CB RID: 203 RVA: 0x000032BB File Offset: 0x000014BB
		' (set) Token: 0x060000CC RID: 204 RVA: 0x000032C8 File Offset: 0x000014C8
		Public Property Expanded As Boolean
			Get
				Return Me.o_.o0_o..Expanded
			End Get
			Set(value As Boolean)
				Me.o_.o0_o..Expanded = value
			End Set
		End Property

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000CD RID: 205 RVA: 0x000032D6 File Offset: 0x000014D6
		' (set) Token: 0x060000CE RID: 206 RVA: 0x000032E3 File Offset: 0x000014E3
		Public Property ItemSize As Size
			Get
				Return Me.o_.o0_o..ItemSize
			End Get
			Set(value As Size)
				Me.o_.o0_o..ItemSize = value
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000CF RID: 207 RVA: 0x000032F1 File Offset: 0x000014F1
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x000032FE File Offset: 0x000014FE
		Public Property Text As String
			Get
				Return Me.o_.o0_o..Text
			End Get
			Set(value As String)
				Me.o_.o0_o..Text = value
			End Set
		End Property

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x0000330C File Offset: 0x0000150C
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x00003319 File Offset: 0x00001519
		Public Property VerticalLayout As Boolean
			Get
				Return Me.o_.o0_o..oOoO0ooo_0O._.()
			End Get
			Set(value As Boolean)
				Me.o_.o0_o..o.o_.(value)
			End Set
		End Property

		' Token: 0x1700005B RID: 91
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As GalleryItem
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000D4 RID: 212 RVA: 0x00003335 File Offset: 0x00001535
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property MenuItem(Name As String) As Object
			Get
				Return Me.MenuItems(Name)
			End Get
		End Property

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000D5 RID: 213 RVA: 0x00003343 File Offset: 0x00001543
		Public ReadOnly Property Items As GalleryItemCollection
			Get
				If Me.o_.o0_o. Is Nothing Then
					Me.o_.o0_o. = New GalleryItemCollection(Me.o_.o0_o..Items, Me.o_.o0_o..oOoO0ooo_0O._.())
				End If
				Return Me.o_.o0_o.
			End Get
		End Property

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000D6 RID: 214 RVA: 0x00003374 File Offset: 0x00001574
		Public ReadOnly Property MenuItems As RibbonItemCollection
			Get
				If Me.o_.o0_o. Is Nothing Then
					Me.o_.o0_o. = New RibbonItemCollection(Me.o_.o0_o..MenuItems)
				End If
				Return Me.o_.o0_o.
			End Get
		End Property

		' Token: 0x04000026 RID: 38
		Friend <<EMPTY_NAME>> As o_o_Oo0__o_0

		' Token: 0x04000027 RID: 39
		Private <<EMPTY_NAME>> As RibbonItemCollection

		' Token: 0x04000028 RID: 40
		Private <<EMPTY_NAME>> As GalleryItemCollection
	End Class
End Namespace
