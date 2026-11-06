Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command

Namespace Foxtable.WinForm
	' Token: 0x02000518 RID: 1304
	<ComVisible(True)>
	<oO0oooo("0872")>
	Public Class NavBar
		Inherits Control

		' Token: 0x06005558 RID: 21848 RVA: 0x002210BD File Offset: 0x0021F2BD
		Friend Sub New(A_0 As O_OOO)
			MyBase.New(A_0, ControlTypeEnum.NavBar)
			Me.o.oO_oo_O. = A_0
		End Sub

		' Token: 0x1700146C RID: 5228
		' (get) Token: 0x06005559 RID: 21849 RVA: 0x002210CF File Offset: 0x0021F2CF
		' (set) Token: 0x0600555A RID: 21850 RVA: 0x002210DC File Offset: 0x0021F2DC
		Public Property ButtonFont As Font
			Get
				Return Me.o.oO_oo_O..ButtonFont
			End Get
			Set(value As Font)
				Me.o.oO_oo_O..ButtonFont = value
			End Set
		End Property

		' Token: 0x1700146D RID: 5229
		' (get) Token: 0x0600555B RID: 21851 RVA: 0x002210EA File Offset: 0x0021F2EA
		' (set) Token: 0x0600555C RID: 21852 RVA: 0x002210F7 File Offset: 0x0021F2F7
		Public Property ButtonHeight As Integer
			Get
				Return Me.o.oO_oo_O..ButtonHeight
			End Get
			Set(value As Integer)
				Me.o.oO_oo_O..ButtonHeight = value
			End Set
		End Property

		' Token: 0x1700146E RID: 5230
		' (get) Token: 0x0600555D RID: 21853 RVA: 0x00221105 File Offset: 0x0021F305
		' (set) Token: 0x0600555E RID: 21854 RVA: 0x00221112 File Offset: 0x0021F312
		Public Property ButtonImageSize As Size
			Get
				Return Me.o.oO_oo_O..ImageScalingSize
			End Get
			Set(value As Size)
				Me.o.oO_oo_O..ImageScalingSize = value
			End Set
		End Property

		' Token: 0x1700146F RID: 5231
		' (get) Token: 0x0600555F RID: 21855 RVA: 0x00221120 File Offset: 0x0021F320
		' (set) Token: 0x06005560 RID: 21856 RVA: 0x0022112D File Offset: 0x0021F32D
		Public Property HeaderFont As Font
			Get
				Return Me.o.oO_oo_O..PanelHeaderFont
			End Get
			Set(value As Font)
				Me.o.oO_oo_O..PanelHeaderFont = value
			End Set
		End Property

		' Token: 0x17001470 RID: 5232
		' (get) Token: 0x06005561 RID: 21857 RVA: 0x0022113B File Offset: 0x0021F33B
		' (set) Token: 0x06005562 RID: 21858 RVA: 0x00221148 File Offset: 0x0021F348
		Public Property HeaderHeight As Integer
			Get
				Return Me.o.oO_oo_O..PanelHeaderHeight
			End Get
			Set(value As Integer)
				Me.o.oO_oo_O..PanelHeaderHeight = value
			End Set
		End Property

		' Token: 0x17001471 RID: 5233
		' (get) Token: 0x06005563 RID: 21859 RVA: 0x00221156 File Offset: 0x0021F356
		' (set) Token: 0x06005564 RID: 21860 RVA: 0x00221163 File Offset: 0x0021F363
		Public Property StackButtonCount As Integer
			Get
				Return Me.o.oO_oo_O..StackButtonCount
			End Get
			Set(value As Integer)
				Me.o.oO_oo_O..StackButtonCount = value
			End Set
		End Property

		' Token: 0x17001472 RID: 5234
		' (get) Token: 0x06005565 RID: 21861 RVA: 0x00221171 File Offset: 0x0021F371
		' (set) Token: 0x06005566 RID: 21862 RVA: 0x0022117E File Offset: 0x0021F37E
		Public Property StripHeight As Integer
			Get
				Return Me.o.oO_oo_O..StripHeight
			End Get
			Set(value As Integer)
				Me.o.oO_oo_O..StripHeight = value
			End Set
		End Property

		' Token: 0x17001473 RID: 5235
		' (set) Token: 0x06005567 RID: 21863 RVA: 0x0022118C File Offset: 0x0021F38C
		<Browsable(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public WriteOnly Property Panels As String
			Set(value As String)
				Dim array As String() = value.Split(New Char() { vbFormFeed })
				Me.o.oO_oo_O..Panels.Clear()
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim navPage As NavPage = New NavPage()
					Me.o.oO_oo_O..Panels.Add(navPage)
					o_O_o_oOoo__.OOOO_OO._oo.(navPage, array(i), vbTab)
				Next
			End Set
		End Property

		' Token: 0x17001474 RID: 5236
		' (get) Token: 0x06005568 RID: 21864 RVA: 0x002211F0 File Offset: 0x0021F3F0
		' (set) Token: 0x06005569 RID: 21865 RVA: 0x002211FD File Offset: 0x0021F3FD
		<oO0oooo("0874")>
		Public Property SelectedIndex As Integer
			Get
				Return Me.o.oO_oo_O..SelectedButtonIndex
			End Get
			Set(value As Integer)
				Me.o.oO_oo_O..SelectedButtonIndex = value
			End Set
		End Property

		' Token: 0x17001475 RID: 5237
		' (get) Token: 0x0600556A RID: 21866 RVA: 0x0022120B File Offset: 0x0021F40B
		' (set) Token: 0x0600556B RID: 21867 RVA: 0x0022121D File Offset: 0x0021F41D
		<oO0oooo("0875")>
		Public Property SelectedPage As NavPage
			Get
				Return CType(Me.o.oO_oo_O..SelectedPanel, NavPage)
			End Get
			Set(value As NavPage)
				Me.o.oO_oo_O..SelectedButton = value.Button
			End Set
		End Property

		' Token: 0x17001476 RID: 5238
		' (get) Token: 0x0600556C RID: 21868 RVA: 0x00221230 File Offset: 0x0021F430
		<oO0oooo("0873")>
		Public ReadOnly Property NavPages As NavPageCollection
			Get
				Return New NavPageCollection(Me.o.oO_oo_O..Panels)
			End Get
		End Property

		' Token: 0x17001477 RID: 5239
		' (get) Token: 0x0600556D RID: 21869 RVA: 0x00221244 File Offset: 0x0021F444
		' (set) Token: 0x0600556E RID: 21870 RVA: 0x00221252 File Offset: 0x0021F452
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x04002207 RID: 8711
		Private <<EMPTY_NAME>> As O_OOO
	End Class
End Namespace
