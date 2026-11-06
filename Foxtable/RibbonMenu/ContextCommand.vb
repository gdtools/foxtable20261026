Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command

Namespace Foxtable.RibbonMenu
	' Token: 0x02000028 RID: 40
	<ComVisible(True)>
	Public Class ContextCommand
		' Token: 0x06000138 RID: 312 RVA: 0x00003B25 File Offset: 0x00001D25
		Public Sub New(A_0 As C1CommandLink)
			Me.oo0OOOO_._. = A_0
			Me.oo0OOOO_._. = A_0.Command
		End Sub

		' Token: 0x06000139 RID: 313 RVA: 0x00003B40 File Offset: 0x00001D40
		Public Sub New(A_0 As C1Command)
			Me.oo0OOOO_._. = A_0
		End Sub

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x0600013A RID: 314 RVA: 0x00003B4F File Offset: 0x00001D4F
		Public ReadOnly Property Name As String
			Get
				Return Me.oo0OOOO_._..Name
			End Get
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x0600013B RID: 315 RVA: 0x00003B5C File Offset: 0x00001D5C
		' (set) Token: 0x0600013C RID: 316 RVA: 0x00003B69 File Offset: 0x00001D69
		Public Property Text As String
			Get
				Return Me.oo0OOOO_._..Text
			End Get
			Set(value As String)
				Me.oo0OOOO_._..Text = value
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x0600013D RID: 317 RVA: 0x00003B77 File Offset: 0x00001D77
		' (set) Token: 0x0600013E RID: 318 RVA: 0x00003B84 File Offset: 0x00001D84
		Public Property ToolTip As String
			Get
				Return Me.oo0OOOO_._..ToolTipText
			End Get
			Set(value As String)
				Me.oo0OOOO_._..ToolTipText = value
			End Set
		End Property

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x0600013F RID: 319 RVA: 0x00003B92 File Offset: 0x00001D92
		' (set) Token: 0x06000140 RID: 320 RVA: 0x00003B9F File Offset: 0x00001D9F
		Public Property Enabled As Boolean
			Get
				Return Me.oo0OOOO_._..Enabled
			End Get
			Set(value As Boolean)
				Me.oo0OOOO_._..Enabled = value
			End Set
		End Property

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x06000141 RID: 321 RVA: 0x00003BAD File Offset: 0x00001DAD
		' (set) Token: 0x06000142 RID: 322 RVA: 0x00003BBA File Offset: 0x00001DBA
		Public Property Image As Image
			Get
				Return Me.oo0OOOO_._..Image
			End Get
			Set(value As Image)
				Me.oo0OOOO_._..Image = value
			End Set
		End Property

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x06000143 RID: 323 RVA: 0x00003BC8 File Offset: 0x00001DC8
		' (set) Token: 0x06000144 RID: 324 RVA: 0x00003BD5 File Offset: 0x00001DD5
		Public Property Visible As Boolean
			Get
				Return Me.oo0OOOO_._..Visible
			End Get
			Set(value As Boolean)
				Me.oo0OOOO_._..Visible = value
			End Set
		End Property

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x06000145 RID: 325 RVA: 0x00003BE3 File Offset: 0x00001DE3
		' (set) Token: 0x06000146 RID: 326 RVA: 0x00003BF0 File Offset: 0x00001DF0
		Public Property Checked As Boolean
			Get
				Return Me.oo0OOOO_._..Checked
			End Get
			Set(value As Boolean)
				Me.oo0OOOO_._..Checked = value
			End Set
		End Property

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x06000147 RID: 327 RVA: 0x00003BFE File Offset: 0x00001DFE
		' (set) Token: 0x06000148 RID: 328 RVA: 0x00003C0B File Offset: 0x00001E0B
		Public Property CheckAutoToggle As Boolean
			Get
				Return Me.oo0OOOO_._..CheckAutoToggle
			End Get
			Set(value As Boolean)
				Me.oo0OOOO_._..CheckAutoToggle = value
			End Set
		End Property

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x06000149 RID: 329 RVA: 0x00003C1C File Offset: 0x00001E1C
		' (set) Token: 0x0600014A RID: 330 RVA: 0x00003C3E File Offset: 0x00001E3E
		Public Property Delimiter As Boolean
			Get
				Dim delimiter As Boolean
				If Me.oo0OOOO_._. IsNot Nothing Then
					delimiter = Me.oo0OOOO_._..Delimiter
				End If
				Return delimiter
			End Get
			Set(value As Boolean)
				If Me.oo0OOOO_._. IsNot Nothing Then
					Me.oo0OOOO_._..Delimiter = value
				End If
			End Set
		End Property

		' Token: 0x04000041 RID: 65
		Friend <<EMPTY_NAME>> As C1CommandLink

		' Token: 0x04000042 RID: 66
		Private <<EMPTY_NAME>> As C1Command
	End Class
End Namespace
