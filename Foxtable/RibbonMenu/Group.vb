Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001E RID: 30
	<oO0oooo("1088")>
	<ComVisible(True)>
	Public Class Group
		' Token: 0x060000EC RID: 236 RVA: 0x0000350D File Offset: 0x0000170D
		Friend Sub New(A_0 As RibbonGroup)
			Me.OO0oOo.O_o0. = A_0
		End Sub

		' Token: 0x060000ED RID: 237 RVA: 0x0000351C File Offset: 0x0000171C
		Public Sub New(A_0 As String)
			Me.OO0oOo.O_o0. = New RibbonGroup()
			Me.OO0oOo.O_o0..ID = A_0
		End Sub

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x060000EE RID: 238 RVA: 0x0000353B File Offset: 0x0000173B
		Public ReadOnly Property Name As String
			Get
				Return Me.OO0oOo.O_o0..ID
			End Get
		End Property

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x060000EF RID: 239 RVA: 0x00003548 File Offset: 0x00001748
		' (set) Token: 0x060000F0 RID: 240 RVA: 0x00003555 File Offset: 0x00001755
		Public Property Text As String
			Get
				Return Me.OO0oOo.O_o0..Text
			End Get
			Set(value As String)
				Me.OO0oOo.O_o0..Text = value
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x00003563 File Offset: 0x00001763
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x00003570 File Offset: 0x00001770
		Public Property Enabled As Boolean
			Get
				Return Me.OO0oOo.O_o0..Enabled
			End Get
			Set(value As Boolean)
				Me.OO0oOo.O_o0..Enabled = value
			End Set
		End Property

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x0000357E File Offset: 0x0000177E
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x0000358B File Offset: 0x0000178B
		Public Property Image As Image
			Get
				Return Me.OO0oOo.O_o0..Image
			End Get
			Set(value As Image)
				Me.OO0oOo.O_o0..Image = value
			End Set
		End Property

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x00003599 File Offset: 0x00001799
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x000035A6 File Offset: 0x000017A6
		Public Property ToolTip As String
			Get
				Return Me.OO0oOo.O_o0..ToolTip
			End Get
			Set(value As String)
				Me.OO0oOo.O_o0..ToolTip = value
			End Set
		End Property

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x000035B4 File Offset: 0x000017B4
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x000035C1 File Offset: 0x000017C1
		Public Property Visible As Boolean
			Get
				Return Me.OO0oOo.O_o0..Visible
			End Get
			Set(value As Boolean)
				Me.OO0oOo.O_o0..Visible = value
			End Set
		End Property

		' Token: 0x1700006F RID: 111
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x060000FA RID: 250 RVA: 0x000035DD File Offset: 0x000017DD
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.OO0oOo.O_o0. Is Nothing Then
					Me.OO0oOo.O_o0. = New RibbonItemCollection(Me.OO0oOo.O_o0..Items)
				End If
				Return Me.OO0oOo.O_o0.
			End Get
		End Property

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x060000FB RID: 251 RVA: 0x00003603 File Offset: 0x00001803
		' (set) Token: 0x060000FC RID: 252 RVA: 0x00003610 File Offset: 0x00001810
		Public Property HasLauncherButton As Boolean
			Get
				Return Me.OO0oOo.O_o0..HasLauncherButton
			End Get
			Set(value As Boolean)
				Me.OO0oOo.O_o0..HasLauncherButton = value
			End Set
		End Property

		' Token: 0x0400002C RID: 44
		Friend <<EMPTY_NAME>> As RibbonGroup

		' Token: 0x0400002D RID: 45
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
