Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command

Namespace Foxtable.WinForm
	' Token: 0x02000522 RID: 1314
	<ComVisible(True)>
	Public Class TabControl
		Inherits Control

		' Token: 0x06005659 RID: 22105 RVA: 0x002228A5 File Offset: 0x00220AA5
		Public Sub New(A_0 As C1DockingTab)
			MyBase.New(A_0, ControlTypeEnum.TabControl)
			Me.oO.ooo. = A_0
			A_0.TabsCanFocus = False
		End Sub

		' Token: 0x170014E8 RID: 5352
		' (get) Token: 0x0600565A RID: 22106 RVA: 0x002228C0 File Offset: 0x00220AC0
		' (set) Token: 0x0600565B RID: 22107 RVA: 0x002228CE File Offset: 0x00220ACE
		Public Overrides Property BackColor As Color
			Get
				Dim result As Color
				Return result
			End Get
			Set(value As Color)
			End Set
		End Property

		' Token: 0x170014E9 RID: 5353
		' (get) Token: 0x0600565C RID: 22108 RVA: 0x002228D0 File Offset: 0x00220AD0
		' (set) Token: 0x0600565D RID: 22109 RVA: 0x002228DD File Offset: 0x00220ADD
		Public Property TabPosition As TabAlignment
			Get
				Return Me.oO.ooo..Alignment
			End Get
			Set(value As TabAlignment)
				Me.oO.ooo..Alignment = value
			End Set
		End Property

		' Token: 0x170014EA RID: 5354
		' (get) Token: 0x0600565E RID: 22110 RVA: 0x002228EB File Offset: 0x00220AEB
		' (set) Token: 0x0600565F RID: 22111 RVA: 0x002228F8 File Offset: 0x00220AF8
		Public Property ShowTabs As Boolean
			Get
				Return Me.oO.ooo..ShowTabs
			End Get
			Set(value As Boolean)
				Me.oO.ooo..ShowTabs = value
			End Set
		End Property

		' Token: 0x170014EB RID: 5355
		' (get) Token: 0x06005660 RID: 22112 RVA: 0x00222906 File Offset: 0x00220B06
		' (set) Token: 0x06005661 RID: 22113 RVA: 0x00222913 File Offset: 0x00220B13
		Public Property TabAlign As StringAlignment
			Get
				Return Me.oO.ooo..AlignTabs
			End Get
			Set(value As StringAlignment)
				Me.oO.ooo..AlignTabs = value
			End Set
		End Property

		' Token: 0x170014EC RID: 5356
		' (get) Token: 0x06005662 RID: 22114 RVA: 0x00222921 File Offset: 0x00220B21
		' (set) Token: 0x06005663 RID: 22115 RVA: 0x0022292E File Offset: 0x00220B2E
		Public Property MultiLine As Boolean
			Get
				Return Me.oO.ooo..MultiLine
			End Get
			Set(value As Boolean)
				Me.oO.ooo..MultiLine = value
			End Set
		End Property

		' Token: 0x170014ED RID: 5357
		' (get) Token: 0x06005664 RID: 22116 RVA: 0x0022293C File Offset: 0x00220B3C
		' (set) Token: 0x06005665 RID: 22117 RVA: 0x00222949 File Offset: 0x00220B49
		Public Property TextDirection As TabTextDirectionEnum
			Get
				Return Me.oO.ooo..TextDirection
			End Get
			Set(value As TabTextDirectionEnum)
				Me.oO.ooo..TextDirection = value
			End Set
		End Property

		' Token: 0x170014EE RID: 5358
		' (get) Token: 0x06005666 RID: 22118 RVA: 0x00222957 File Offset: 0x00220B57
		' (set) Token: 0x06005667 RID: 22119 RVA: 0x00222964 File Offset: 0x00220B64
		Public Property TabLayout As ButtonLayoutEnum
			Get
				Return Me.oO.ooo..TabLayout
			End Get
			Set(value As ButtonLayoutEnum)
				Me.oO.ooo..TabLayout = value
			End Set
		End Property

		' Token: 0x170014EF RID: 5359
		' (get) Token: 0x06005668 RID: 22120 RVA: 0x00222972 File Offset: 0x00220B72
		' (set) Token: 0x06005669 RID: 22121 RVA: 0x0022297F File Offset: 0x00220B7F
		Public Property SelectedTabBold As Boolean
			Get
				Return Me.oO.ooo..SelectedTabBold
			End Get
			Set(value As Boolean)
				Me.oO.ooo..SelectedTabBold = value
			End Set
		End Property

		' Token: 0x170014F0 RID: 5360
		' (get) Token: 0x0600566A RID: 22122 RVA: 0x0022298D File Offset: 0x00220B8D
		' (set) Token: 0x0600566B RID: 22123 RVA: 0x0022299A File Offset: 0x00220B9A
		Public Property TabsSpacing As Integer
			Get
				Return Me.oO.ooo..TabsSpacing
			End Get
			Set(value As Integer)
				Me.oO.ooo..TabsSpacing = value
			End Set
		End Property

		' Token: 0x170014F1 RID: 5361
		' (get) Token: 0x0600566C RID: 22124 RVA: 0x002229A8 File Offset: 0x00220BA8
		' (set) Token: 0x0600566D RID: 22125 RVA: 0x002229B5 File Offset: 0x00220BB5
		Public Property Indent As Integer
			Get
				Return Me.oO.ooo..Indent
			End Get
			Set(value As Integer)
				Me.oO.ooo..Indent = value
			End Set
		End Property

		' Token: 0x170014F2 RID: 5362
		' (set) Token: 0x0600566E RID: 22126 RVA: 0x002229C4 File Offset: 0x00220BC4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public WriteOnly Property Pages As String
			Set(value As String)
				Dim array As String() = value.Split(New Char() { vbFormFeed })
				Me.oO.ooo..TabPages.Clear()
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim tabPage As TabPage = New TabPage()
					Me.oO.ooo..TabPages.Add(tabPage)
					o_O_o_oOoo__.OOOO_OO._oo.(tabPage, array(i), vbTab)
				Next
			End Set
		End Property

		' Token: 0x170014F3 RID: 5363
		' (get) Token: 0x0600566F RID: 22127 RVA: 0x00222A28 File Offset: 0x00220C28
		' (set) Token: 0x06005670 RID: 22128 RVA: 0x00222A35 File Offset: 0x00220C35
		<oO0oooo("0831")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.oO.ooo..SelectedIndex
			End Get
			Set(value As Integer)
				Me.oO.ooo..SelectedIndex = value
			End Set
		End Property

		' Token: 0x170014F4 RID: 5364
		' (get) Token: 0x06005671 RID: 22129 RVA: 0x00222A43 File Offset: 0x00220C43
		' (set) Token: 0x06005672 RID: 22130 RVA: 0x00222A55 File Offset: 0x00220C55
		Public Property SelectedPage As TabPage
			Get
				Return CType(Me.oO.ooo..SelectedTab, TabPage)
			End Get
			Set(value As TabPage)
				Me.oO.ooo..SelectedTab = value
			End Set
		End Property

		' Token: 0x170014F5 RID: 5365
		' (get) Token: 0x06005673 RID: 22131 RVA: 0x00222A63 File Offset: 0x00220C63
		<oO0oooo("0830")>
		Public ReadOnly Property TabPages As TabPageCollection
			Get
				Return New TabPageCollection(Me.oO.ooo..TabPages)
			End Get
		End Property

		' Token: 0x06005674 RID: 22132 RVA: 0x00222A78 File Offset: 0x00220C78
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function AddPage() As TabPage
			Dim tabPage As TabPage = New TabPage()
			Me.oO.ooo..TabPages.Add(tabPage)
			Return tabPage
		End Function

		' Token: 0x170014F6 RID: 5366
		' (get) Token: 0x06005675 RID: 22133 RVA: 0x00222AA0 File Offset: 0x00220CA0
		' (set) Token: 0x06005676 RID: 22134 RVA: 0x00222AAE File Offset: 0x00220CAE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x04002229 RID: 8745
		Private <<EMPTY_NAME>> As C1DockingTab
	End Class
End Namespace
