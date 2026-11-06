Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200001F RID: 31
	<ComVisible(True)>
	<oO0oooo("1085")>
	Public Class Tab
		' Token: 0x060000FD RID: 253 RVA: 0x0000361E File Offset: 0x0000181E
		Friend Sub New(A_0 As RibbonTab)
			Me.OO0.0OOo__. = A_0
		End Sub

		' Token: 0x060000FE RID: 254 RVA: 0x0000362D File Offset: 0x0000182D
		Public Sub New(A_0 As String)
			Me.OO0.0OOo__. = New RibbonTab()
			Me.OO0.0OOo__..ID = A_0
		End Sub

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x060000FF RID: 255 RVA: 0x0000364C File Offset: 0x0000184C
		Public ReadOnly Property Name As String
			Get
				Return Me.OO0.0OOo__..ID
			End Get
		End Property

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000100 RID: 256 RVA: 0x00003659 File Offset: 0x00001859
		' (set) Token: 0x06000101 RID: 257 RVA: 0x00003666 File Offset: 0x00001866
		Public Property Text As String
			Get
				Return Me.OO0.0OOo__..Text
			End Get
			Set(value As String)
				Me.OO0.0OOo__..Text = value
			End Set
		End Property

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000102 RID: 258 RVA: 0x00003674 File Offset: 0x00001874
		' (set) Token: 0x06000103 RID: 259 RVA: 0x00003681 File Offset: 0x00001881
		Public Property Enabled As Boolean
			Get
				Return Me.OO0.0OOo__..Enabled
			End Get
			Set(value As Boolean)
				Me.OO0.0OOo__..Enabled = value
			End Set
		End Property

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x06000104 RID: 260 RVA: 0x0000368F File Offset: 0x0000188F
		' (set) Token: 0x06000105 RID: 261 RVA: 0x0000369C File Offset: 0x0000189C
		Public Property Image As Image
			Get
				Return Me.OO0.0OOo__..Image
			End Get
			Set(value As Image)
				Me.OO0.0OOo__..Image = value
			End Set
		End Property

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x06000106 RID: 262 RVA: 0x000036AA File Offset: 0x000018AA
		' (set) Token: 0x06000107 RID: 263 RVA: 0x000036B7 File Offset: 0x000018B7
		Public Property ToolTip As String
			Get
				Return Me.OO0.0OOo__..ToolTip
			End Get
			Set(value As String)
				Me.OO0.0OOo__..ToolTip = value
			End Set
		End Property

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x06000108 RID: 264 RVA: 0x000036C5 File Offset: 0x000018C5
		' (set) Token: 0x06000109 RID: 265 RVA: 0x000036D2 File Offset: 0x000018D2
		Public Property Visible As Boolean
			Get
				Return Me.OO0.0OOo__..Visible
			End Get
			Set(value As Boolean)
				Me.OO0.0OOo__..Visible = value
			End Set
		End Property

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x0600010A RID: 266 RVA: 0x000036E0 File Offset: 0x000018E0
		' (set) Token: 0x0600010B RID: 267 RVA: 0x000036ED File Offset: 0x000018ED
		Public Property Selected As Boolean
			Get
				Return Me.OO0.0OOo__..Selected
			End Get
			Set(value As Boolean)
				Me.OO0.0OOo__..Selected = True
			End Set
		End Property

		' Token: 0x17000079 RID: 121
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Group
			Get
				Return Me.Groups(Name)
			End Get
		End Property

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x0600010D RID: 269 RVA: 0x00003709 File Offset: 0x00001909
		Public ReadOnly Property Groups As RibbonGroupCollection
			Get
				If Me.OO0.0OOo__. Is Nothing Then
					Me.OO0.0OOo__. = New RibbonGroupCollection(Me.OO0.0OOo__..Groups)
				End If
				Return Me.OO0.0OOo__.
			End Get
		End Property

		' Token: 0x0400002E RID: 46
		Friend <<EMPTY_NAME>> As RibbonTab

		' Token: 0x0400002F RID: 47
		Private <<EMPTY_NAME>> As RibbonGroupCollection
	End Class
End Namespace
