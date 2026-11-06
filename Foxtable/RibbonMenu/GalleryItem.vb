Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001C RID: 28
	<ComVisible(True)>
	Public Class GalleryItem
		' Token: 0x060000D7 RID: 215 RVA: 0x0000339A File Offset: 0x0000159A
		Public Sub New(A_0 As RibbonGalleryItem)
			Me.OO0oOo.O_o0. = A_0
		End Sub

		' Token: 0x060000D8 RID: 216 RVA: 0x000033A9 File Offset: 0x000015A9
		Public Sub New(A_0 As String)
			Me.OO0oOo.O_o0. = New RibbonGalleryItem()
			Me.OO0oOo.O_o0..ID = A_0
		End Sub

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x000033C8 File Offset: 0x000015C8
		Public ReadOnly Property Name As String
			Get
				Return Me.OO0oOo.O_o0..ID
			End Get
		End Property

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x060000DA RID: 218 RVA: 0x000033D5 File Offset: 0x000015D5
		' (set) Token: 0x060000DB RID: 219 RVA: 0x000033E2 File Offset: 0x000015E2
		Public Property Text As String
			Get
				Return Me.OO0oOo.O_o0..Text
			End Get
			Set(value As String)
				Me.OO0oOo.O_o0..Text = value
			End Set
		End Property

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x060000DC RID: 220 RVA: 0x000033F0 File Offset: 0x000015F0
		' (set) Token: 0x060000DD RID: 221 RVA: 0x000033FD File Offset: 0x000015FD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ForeColor As Color
			Get
				Return Me.OO0oOo.O_o0..ForeColorInner
			End Get
			Set(value As Color)
				Me.OO0oOo.O_o0..ForeColorInner = value
				Me.OO0oOo.O_o0..ForeColorOuter = value
			End Set
		End Property

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x060000DE RID: 222 RVA: 0x00003417 File Offset: 0x00001617
		' (set) Token: 0x060000DF RID: 223 RVA: 0x00003424 File Offset: 0x00001624
		Public Property UserData As String
			Get
				Return Me.OO0oOo.O_o0..Description
			End Get
			Set(value As String)
				Me.OO0oOo.O_o0..Description = value
			End Set
		End Property

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x060000E0 RID: 224 RVA: 0x00003432 File Offset: 0x00001632
		' (set) Token: 0x060000E1 RID: 225 RVA: 0x0000343F File Offset: 0x0000163F
		Public Overridable Property Enabled As Boolean
			Get
				Return Me.OO0oOo.O_o0..Enabled
			End Get
			Set(value As Boolean)
				Me.OO0oOo.O_o0..Enabled = value
			End Set
		End Property

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x060000E2 RID: 226 RVA: 0x0000344D File Offset: 0x0000164D
		' (set) Token: 0x060000E3 RID: 227 RVA: 0x0000345A File Offset: 0x0000165A
		Public Property ToolTip As String
			Get
				Return Me.OO0oOo.O_o0..ToolTip
			End Get
			Set(value As String)
				Me.OO0oOo.O_o0..ToolTip = value
			End Set
		End Property

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x060000E4 RID: 228 RVA: 0x00003468 File Offset: 0x00001668
		' (set) Token: 0x060000E5 RID: 229 RVA: 0x00003475 File Offset: 0x00001675
		Public Property Image As Image
			Get
				Return Me.OO0oOo.O_o0..LargeImage
			End Get
			Set(value As Image)
				Me.OO0oOo.O_o0..LargeImage = value
			End Set
		End Property

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x060000E6 RID: 230 RVA: 0x00003483 File Offset: 0x00001683
		' (set) Token: 0x060000E7 RID: 231 RVA: 0x00003490 File Offset: 0x00001690
		Public Overridable Property Visible As Boolean
			Get
				Return Me.OO0oOo.O_o0..Visible
			End Get
			Set(value As Boolean)
				Me.OO0oOo.O_o0..Visible = value
			End Set
		End Property

		' Token: 0x04000029 RID: 41
		Friend <<EMPTY_NAME>> As RibbonGalleryItem
	End Class
End Namespace
