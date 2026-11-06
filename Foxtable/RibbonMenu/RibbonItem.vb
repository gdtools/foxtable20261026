Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000008 RID: 8
	<oO0oooo("1100")>
	<ComVisible(True)>
	Public Class RibbonItem
		' Token: 0x0600001E RID: 30 RVA: 0x0000252F File Offset: 0x0000072F
		Friend Sub New(A_0 As RibbonItem)
			Me.oOo_.0o_O_O_0. = A_0
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x0000253E File Offset: 0x0000073E
		Public Sub New()
			Me.oOo_.0o_O_O_0. = Nothing
		End Sub

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000020 RID: 32 RVA: 0x0000254D File Offset: 0x0000074D
		Public ReadOnly Property Name As String
			Get
				Return Me.oOo_.0o_O_O_0..ID
			End Get
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000021 RID: 33 RVA: 0x0000255A File Offset: 0x0000075A
		' (set) Token: 0x06000022 RID: 34 RVA: 0x00002567 File Offset: 0x00000767
		Public Property UserData As String
			Get
				Return Me.oOo_.0o_O_O_0..Description
			End Get
			Set(value As String)
				Me.oOo_.0o_O_O_0..Description = value
			End Set
		End Property

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000023 RID: 35 RVA: 0x00002575 File Offset: 0x00000775
		' (set) Token: 0x06000024 RID: 36 RVA: 0x00002582 File Offset: 0x00000782
		Public Overridable Property Enabled As Boolean
			Get
				Return Me.oOo_.0o_O_O_0..Enabled
			End Get
			Set(value As Boolean)
				Me.oOo_.0o_O_O_0..Enabled = value
			End Set
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000025 RID: 37 RVA: 0x00002590 File Offset: 0x00000790
		' (set) Token: 0x06000026 RID: 38 RVA: 0x0000259D File Offset: 0x0000079D
		Public Property LargeImage As Image
			Get
				Return Me.oOo_.0o_O_O_0..LargeImage
			End Get
			Set(value As Image)
				Me.oOo_.0o_O_O_0..LargeImage = value
			End Set
		End Property

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000027 RID: 39 RVA: 0x000025AB File Offset: 0x000007AB
		' (set) Token: 0x06000028 RID: 40 RVA: 0x000025B8 File Offset: 0x000007B8
		Public Property SmallImage As Image
			Get
				Return Me.oOo_.0o_O_O_0..SmallImage
			End Get
			Set(value As Image)
				Me.oOo_.0o_O_O_0..SmallImage = value
			End Set
		End Property

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000029 RID: 41 RVA: 0x000025C6 File Offset: 0x000007C6
		' (set) Token: 0x0600002A RID: 42 RVA: 0x000025D3 File Offset: 0x000007D3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ForeColor As Color
			Get
				Return Me.oOo_.0o_O_O_0..ForeColorInner
			End Get
			Set(value As Color)
				Me.oOo_.0o_O_O_0..ForeColorInner = value
				Me.oOo_.0o_O_O_0..ForeColorOuter = value
			End Set
		End Property

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x0600002B RID: 43 RVA: 0x000025F0 File Offset: 0x000007F0
		' (set) Token: 0x0600002C RID: 44 RVA: 0x00002623 File Offset: 0x00000823
		Public Property TextImageRelation As TextImageRelationEnum
			Get
				Dim result As TextImageRelationEnum
				If Me.oOo_.0o_O_O_0..TextImageRelation Is Nothing Then
					result = TextImageRelationEnum.Automatic
				ElseIf Me.oOo_.0o_O_O_0..TextImageRelation = 1 Then
					result = TextImageRelationEnum.ImageAboveText
				Else
					result = TextImageRelationEnum.ImageBeforeText
				End If
				Return result
			End Get
			Set(value As TextImageRelationEnum)
				If value = TextImageRelationEnum.Automatic Then
					Me.oOo_.0o_O_O_0..TextImageRelation = 0
					Return
				End If
				If value = TextImageRelationEnum.ImageAboveText Then
					Me.oOo_.0o_O_O_0..TextImageRelation = 1
					Return
				End If
				Me.oOo_.0o_O_O_0..TextImageRelation = 2
			End Set
		End Property

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600002D RID: 45 RVA: 0x00002652 File Offset: 0x00000852
		' (set) Token: 0x0600002E RID: 46 RVA: 0x0000265F File Offset: 0x0000085F
		Public Property ToolTip As String
			Get
				Return Me.oOo_.0o_O_O_0..ToolTip
			End Get
			Set(value As String)
				Me.oOo_.0o_O_O_0..ToolTip = value
			End Set
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600002F RID: 47 RVA: 0x0000266D File Offset: 0x0000086D
		' (set) Token: 0x06000030 RID: 48 RVA: 0x0000267A File Offset: 0x0000087A
		Public Overridable Property Visible As Boolean
			Get
				Return Me.oOo_.0o_O_O_0..Visible
			End Get
			Set(value As Boolean)
				Me.oOo_.0o_O_O_0..Visible = value
			End Set
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000031 RID: 49 RVA: 0x00002688 File Offset: 0x00000888
		' (set) Token: 0x06000032 RID: 50 RVA: 0x00002698 File Offset: 0x00000898
		Public Property AutoHideText As Boolean
			Get
				Return Me.oOo_.0o_O_O_0..SupportedGroupSizing = 0
			End Get
			Set(value As Boolean)
				If value Then
					Me.oOo_.0o_O_O_0..SupportedGroupSizing = 0
					Return
				End If
				Me.oOo_.0o_O_O_0..SupportedGroupSizing = 1
			End Set
		End Property

		' Token: 0x0400000E RID: 14
		Friend <<EMPTY_NAME>> As RibbonItem
	End Class
End Namespace
