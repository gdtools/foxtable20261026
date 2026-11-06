Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x02000173 RID: 371
	<oO0oooo("3220")>
	<ComVisible(True)>
	Public Class StripItem
		' Token: 0x0600113C RID: 4412 RVA: 0x0006BB97 File Offset: 0x00069D97
		Friend Sub New(A_0 As ToolStripItem, A_1 As Form)
			Me.oO.ooo. = A_0
			Me.oO.ooo. = A_1
		End Sub

		' Token: 0x1700039A RID: 922
		' (get) Token: 0x0600113D RID: 4413 RVA: 0x0006BBAD File Offset: 0x00069DAD
		Public ReadOnly Property Name As String
			Get
				Return Me.oO.ooo..Name
			End Get
		End Property

		' Token: 0x1700039B RID: 923
		' (get) Token: 0x0600113E RID: 4414 RVA: 0x0006BBBA File Offset: 0x00069DBA
		' (set) Token: 0x0600113F RID: 4415 RVA: 0x0006BBC7 File Offset: 0x00069DC7
		Public Property Text As String
			Get
				Return Me.oO.ooo..Text
			End Get
			Set(value As String)
				Me.oO.ooo..Text = value
			End Set
		End Property

		' Token: 0x1700039C RID: 924
		' (get) Token: 0x06001140 RID: 4416 RVA: 0x0006BBD8 File Offset: 0x00069DD8
		Public ReadOnly Property ParentItem As StripItem
			Get
				Dim result As StripItem
				If Me.oO.ooo..OwnerItem IsNot Nothing Then
					result = New StripItem(Me.oO.ooo..OwnerItem, Me.oO.ooo.)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700039D RID: 925
		' (get) Token: 0x06001141 RID: 4417 RVA: 0x0006BC0E File Offset: 0x00069E0E
		' (set) Token: 0x06001142 RID: 4418 RVA: 0x0006BC1E File Offset: 0x00069E1E
		Public Property DisplayText As Boolean
			Get
				Return Me.oO.ooo..DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
			End Get
			Set(value As Boolean)
				If value Then
					Me.oO.ooo..DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
					Return
				End If
				Me.oO.ooo..DisplayStyle = ToolStripItemDisplayStyle.Image
			End Set
		End Property

		' Token: 0x1700039E RID: 926
		' (get) Token: 0x06001143 RID: 4419 RVA: 0x0006BC3C File Offset: 0x00069E3C
		Public ReadOnly Property Index As Integer
			Get
				Dim result As Integer
				If Me.oO.ooo..Owner IsNot Nothing Then
					result = Me.oO.ooo..Owner.Items.IndexOf(Me.oO.ooo.)
				Else
					result = -1
				End If
				Return result
			End Get
		End Property

		' Token: 0x06001144 RID: 4420 RVA: 0x0006BC77 File Offset: 0x00069E77
		Public Sub PerformClick()
			Me.oO.ooo..PerformClick()
		End Sub

		' Token: 0x1700039F RID: 927
		' (get) Token: 0x06001145 RID: 4421 RVA: 0x0006BC84 File Offset: 0x00069E84
		' (set) Token: 0x06001146 RID: 4422 RVA: 0x0006BCA6 File Offset: 0x00069EA6
		Public Property TextPosition As TextPositionEnum
			Get
				Dim result As TextPositionEnum
				If Me.oO.ooo..TextImageRelation = TextImageRelation.ImageBeforeText Then
					result = TextPositionEnum.Right
				Else
					result = TextPositionEnum.Bottom
				End If
				Return result
			End Get
			Set(value As TextPositionEnum)
				If value = TextPositionEnum.Right Then
					Me.oO.ooo..TextImageRelation = TextImageRelation.ImageBeforeText
					Return
				End If
				Me.oO.ooo..TextImageRelation = TextImageRelation.ImageAboveText
			End Set
		End Property

		' Token: 0x170003A0 RID: 928
		' (get) Token: 0x06001147 RID: 4423 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		' (set) Token: 0x06001148 RID: 4424 RVA: 0x0006BCE6 File Offset: 0x00069EE6
		Public Property DockToRight As Boolean
			Get
				Return Me.oO.ooo..Alignment = ToolStripItemAlignment.Right
			End Get
			Set(value As Boolean)
				If value Then
					Me.oO.ooo..Alignment = ToolStripItemAlignment.Right
					Return
				End If
				Me.oO.ooo..Alignment = ToolStripItemAlignment.Left
			End Set
		End Property

		' Token: 0x170003A1 RID: 929
		' (get) Token: 0x06001149 RID: 4425 RVA: 0x0006BD04 File Offset: 0x00069F04
		' (set) Token: 0x0600114A RID: 4426 RVA: 0x0006BD11 File Offset: 0x00069F11
		Public Property ToolTip As String
			Get
				Return Me.oO.ooo..ToolTipText
			End Get
			Set(value As String)
				Me.oO.ooo..ToolTipText = value
			End Set
		End Property

		' Token: 0x170003A2 RID: 930
		' (get) Token: 0x0600114B RID: 4427 RVA: 0x0006BD1F File Offset: 0x00069F1F
		' (set) Token: 0x0600114C RID: 4428 RVA: 0x0006BD2C File Offset: 0x00069F2C
		Public Property Visible As Boolean
			Get
				Return Me.oO.ooo..Visible
			End Get
			Set(value As Boolean)
				Me.oO.ooo..Visible = value
			End Set
		End Property

		' Token: 0x170003A3 RID: 931
		' (get) Token: 0x0600114D RID: 4429 RVA: 0x0006BD3A File Offset: 0x00069F3A
		' (set) Token: 0x0600114E RID: 4430 RVA: 0x0006BD47 File Offset: 0x00069F47
		Public Property Enabled As Boolean
			Get
				Return Me.oO.ooo..Enabled
			End Get
			Set(value As Boolean)
				Me.oO.ooo..Enabled = value
			End Set
		End Property

		' Token: 0x170003A4 RID: 932
		' (get) Token: 0x0600114F RID: 4431 RVA: 0x0006BD58 File Offset: 0x00069F58
		' (set) Token: 0x06001150 RID: 4432 RVA: 0x0006BD88 File Offset: 0x00069F88
		Public Property ShortcutKeys As Keys
			Get
				Dim result As Keys
				If TypeOf Me.oO.ooo. Is ToolStripMenuItem Then
					result = CType(Me.oO.ooo., ToolStripMenuItem).ShortcutKeys
				Else
					result = Keys.None
				End If
				Return result
			End Get
			Set(value As Keys)
				If TypeOf Me.oO.ooo. Is ToolStripMenuItem Then
					CType(Me.oO.ooo., ToolStripMenuItem).ShortcutKeys = value
				End If
			End Set
		End Property

		' Token: 0x170003A5 RID: 933
		' (get) Token: 0x06001151 RID: 4433 RVA: 0x0006BDA8 File Offset: 0x00069FA8
		' (set) Token: 0x06001152 RID: 4434 RVA: 0x0006BDF4 File Offset: 0x00069FF4
		Public Property Checked As Boolean
			Get
				Dim checked As Boolean
				If TypeOf Me.oO.ooo. Is ToolStripMenuItem Then
					checked = CType(Me.oO.ooo., ToolStripMenuItem).Checked
				ElseIf TypeOf Me.oO.ooo. Is ToolStripButton Then
					checked = CType(Me.oO.ooo., ToolStripButton).Checked
				End If
				Return checked
			End Get
			Set(value As Boolean)
				If TypeOf Me.oO.ooo. Is ToolStripMenuItem Then
					CType(Me.oO.ooo., ToolStripMenuItem).Checked = value
					Return
				End If
				If TypeOf Me.oO.ooo. Is ToolStripButton Then
					CType(Me.oO.ooo., ToolStripButton).Checked = value
				End If
			End Set
		End Property

		' Token: 0x170003A6 RID: 934
		' (get) Token: 0x06001153 RID: 4435 RVA: 0x0006BE34 File Offset: 0x0006A034
		Public ReadOnly Property Items As StripItemCollection
			Get
				Dim result As StripItemCollection
				If TypeOf Me.oO.ooo. Is ToolStripDropDownItem Then
					result = New StripItemCollection(CType(Me.oO.ooo., ToolStripDropDownItem).DropDownItems, Me.oO.ooo.)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170003A7 RID: 935
		' (get) Token: 0x06001154 RID: 4436 RVA: 0x0006BE6F File Offset: 0x0006A06F
		Public ReadOnly Property BaseControl As Object
			Get
				Return Me.oO.ooo.
			End Get
		End Property

		' Token: 0x170003A8 RID: 936
		' (get) Token: 0x06001155 RID: 4437 RVA: 0x0006BE77 File Offset: 0x0006A077
		' (set) Token: 0x06001156 RID: 4438 RVA: 0x0006BE84 File Offset: 0x0006A084
		Public Property Image As Image
			Get
				Return Me.oO.ooo..Image
			End Get
			Set(value As Image)
				Me.oO.ooo..Image = value
			End Set
		End Property

		' Token: 0x06001157 RID: 4439 RVA: 0x0006BE94 File Offset: 0x0006A094
		Public Sub HideDropDown()
			If TypeOf Me.oO.ooo. Is ToolStripDropDownItem Then
				CType(Me.oO.ooo., ToolStripDropDownItem).HideDropDown()
			End If
			If Me.oO.ooo..IsOnDropDown Then
				Dim ownerItem As ToolStripItem = Me.oO.ooo.
				While ownerItem.IsOnDropDown
					If ownerItem.OwnerItem IsNot Nothing Then
						If Not(TypeOf ownerItem.OwnerItem Is ToolStripDropDownItem) Then
							Exit While
						End If
						ownerItem = ownerItem.OwnerItem
						CType(ownerItem, ToolStripDropDownItem).HideDropDown()
					Else
						If ownerItem.Owner IsNot Nothing AndAlso TypeOf ownerItem.Owner Is ContextMenuStrip Then
							CType(ownerItem.Owner, ContextMenuStrip).Hide()
							Return
						End If
						Exit While
					End If
				End While
			End If
		End Sub

		' Token: 0x0400068A RID: 1674
		Private <<EMPTY_NAME>> As ToolStripItem

		' Token: 0x0400068B RID: 1675
		Private <<EMPTY_NAME>> As Form
	End Class
End Namespace
