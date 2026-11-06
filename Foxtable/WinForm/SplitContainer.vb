Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x02000520 RID: 1312
	<ComVisible(True)>
	Public Class SplitContainer
		Inherits Control

		' Token: 0x0600562C RID: 22060 RVA: 0x00222461 File Offset: 0x00220661
		Public Sub New(A_0 As SplitContainer)
			MyBase.New(A_0, ControlTypeEnum.SplitContainer)
			Me.Oooo.Oo_0O. = FixedPanel.Panel1
			A_0.Panel1MinSize = 0
			A_0.Panel2MinSize = 0
			Me.Oooo.Oo_0O. = A_0
		End Sub

		' Token: 0x170014D2 RID: 5330
		' (get) Token: 0x0600562D RID: 22061 RVA: 0x00222488 File Offset: 0x00220688
		' (set) Token: 0x0600562E RID: 22062 RVA: 0x00222495 File Offset: 0x00220695
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.Oooo.Oo_0O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.Oooo.Oo_0O..BorderStyle = value
			End Set
		End Property

		' Token: 0x170014D3 RID: 5331
		' (get) Token: 0x0600562F RID: 22063 RVA: 0x002224A3 File Offset: 0x002206A3
		' (set) Token: 0x06005630 RID: 22064 RVA: 0x002224B0 File Offset: 0x002206B0
		Public Property Orientation As Orientation
			Get
				Return Me.Oooo.Oo_0O..Orientation
			End Get
			Set(value As Orientation)
				Me.Oooo.Oo_0O..Orientation = value
			End Set
		End Property

		' Token: 0x170014D4 RID: 5332
		' (get) Token: 0x06005631 RID: 22065 RVA: 0x002224BE File Offset: 0x002206BE
		' (set) Token: 0x06005632 RID: 22066 RVA: 0x002224CB File Offset: 0x002206CB
		<oO0oooo("0821")>
		Public Property FixedPanel As FixedPanel
			Get
				Return Me.Oooo.Oo_0O..FixedPanel
			End Get
			Set(value As FixedPanel)
				Me.Oooo.Oo_0O..FixedPanel = value
			End Set
		End Property

		' Token: 0x170014D5 RID: 5333
		' (get) Token: 0x06005633 RID: 22067 RVA: 0x002224D9 File Offset: 0x002206D9
		' (set) Token: 0x06005634 RID: 22068 RVA: 0x002224E6 File Offset: 0x002206E6
		Public Property SplitterWidth As Integer
			Get
				Return Me.Oooo.Oo_0O..SplitterWidth
			End Get
			Set(value As Integer)
				Me.Oooo.Oo_0O..SplitterWidth = value
			End Set
		End Property

		' Token: 0x170014D6 RID: 5334
		' (get) Token: 0x06005635 RID: 22069 RVA: 0x002224F4 File Offset: 0x002206F4
		' (set) Token: 0x06005636 RID: 22070 RVA: 0x00222501 File Offset: 0x00220701
		Public Property IsSplitterFixed As Boolean
			Get
				Return Me.Oooo.Oo_0O..IsSplitterFixed
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..IsSplitterFixed = value
			End Set
		End Property

		' Token: 0x170014D7 RID: 5335
		' (get) Token: 0x06005637 RID: 22071 RVA: 0x0022250F File Offset: 0x0022070F
		' (set) Token: 0x06005638 RID: 22072 RVA: 0x00222517 File Offset: 0x00220717
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SplitterDistance2 As Integer
			Get
				Return Me.Oooo.Oo_0O.
			End Get
			Set(value As Integer)
				Me.Oooo.Oo_0O. = value
			End Set
		End Property

		' Token: 0x170014D8 RID: 5336
		' (get) Token: 0x06005639 RID: 22073 RVA: 0x00222520 File Offset: 0x00220720
		' (set) Token: 0x0600563A RID: 22074 RVA: 0x00222528 File Offset: 0x00220728
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FixedPanel2 As FixedPanel
			Get
				Return Me.Oooo.Oo_0O.
			End Get
			Set(value As FixedPanel)
				Me.Oooo.Oo_0O. = value
			End Set
		End Property

		' Token: 0x170014D9 RID: 5337
		' (get) Token: 0x0600563B RID: 22075 RVA: 0x00222531 File Offset: 0x00220731
		' (set) Token: 0x0600563C RID: 22076 RVA: 0x0022253E File Offset: 0x0022073E
		Public Property SplitterDistance As Integer
			Get
				Return Me.Oooo.Oo_0O..SplitterDistance
			End Get
			Set(value As Integer)
				Me.Oooo.Oo_0O..SplitterDistance = value
			End Set
		End Property

		' Token: 0x170014DA RID: 5338
		' (get) Token: 0x0600563D RID: 22077 RVA: 0x0022254C File Offset: 0x0022074C
		' (set) Token: 0x0600563E RID: 22078 RVA: 0x0022255E File Offset: 0x0022075E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackColorOfPanel1 As Color
			Get
				Return Me.Oooo.Oo_0O..Panel1.BackColor
			End Get
			Set(value As Color)
				If Me.Oooo.Oo_0O..Panel1.BackColor <> value Then
					Me.Oooo.Oo_0O..Panel1.BackColor = value
				End If
			End Set
		End Property

		' Token: 0x170014DB RID: 5339
		' (get) Token: 0x0600563F RID: 22079 RVA: 0x00222589 File Offset: 0x00220789
		' (set) Token: 0x06005640 RID: 22080 RVA: 0x0022259B File Offset: 0x0022079B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Panel1IsAutoScroll As Boolean
			Get
				Return Me.Oooo.Oo_0O..Panel1.AutoScroll
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Panel1.AutoScroll = value
			End Set
		End Property

		' Token: 0x170014DC RID: 5340
		' (get) Token: 0x06005641 RID: 22081 RVA: 0x002225AE File Offset: 0x002207AE
		' (set) Token: 0x06005642 RID: 22082 RVA: 0x002225C0 File Offset: 0x002207C0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackColorOfPanel2 As Color
			Get
				Return Me.Oooo.Oo_0O..Panel2.BackColor
			End Get
			Set(value As Color)
				If Me.Oooo.Oo_0O..Panel2.BackColor <> value Then
					Me.Oooo.Oo_0O..Panel2.BackColor = value
				End If
			End Set
		End Property

		' Token: 0x170014DD RID: 5341
		' (get) Token: 0x06005643 RID: 22083 RVA: 0x002225EB File Offset: 0x002207EB
		' (set) Token: 0x06005644 RID: 22084 RVA: 0x002225FD File Offset: 0x002207FD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Panel2IsAutoScroll As Boolean
			Get
				Return Me.Oooo.Oo_0O..Panel2.AutoScroll
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Panel2.AutoScroll = value
			End Set
		End Property

		' Token: 0x170014DE RID: 5342
		' (get) Token: 0x06005645 RID: 22085 RVA: 0x00222610 File Offset: 0x00220810
		' (set) Token: 0x06005646 RID: 22086 RVA: 0x0022261D File Offset: 0x0022081D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Panel1Collapsed As Boolean
			Get
				Return Me.Oooo.Oo_0O..Panel1Collapsed
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Panel1Collapsed = value
			End Set
		End Property

		' Token: 0x170014DF RID: 5343
		' (get) Token: 0x06005647 RID: 22087 RVA: 0x0022262B File Offset: 0x0022082B
		' (set) Token: 0x06005648 RID: 22088 RVA: 0x00222638 File Offset: 0x00220838
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Panel2Collapsed As Boolean
			Get
				Return Me.Oooo.Oo_0O..Panel2Collapsed
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Panel2Collapsed = value
			End Set
		End Property

		' Token: 0x170014E0 RID: 5344
		' (get) Token: 0x06005649 RID: 22089 RVA: 0x00222646 File Offset: 0x00220846
		<oO0oooo("1918")>
		Public ReadOnly Property Panel1 As SplitPanel
			Get
				Return New SplitPanel(Me.Oooo.Oo_0O..Panel1)
			End Get
		End Property

		' Token: 0x170014E1 RID: 5345
		' (get) Token: 0x0600564A RID: 22090 RVA: 0x00222658 File Offset: 0x00220858
		<oO0oooo("1918")>
		Public ReadOnly Property Panel2 As SplitPanel
			Get
				Return New SplitPanel(Me.Oooo.Oo_0O..Panel2)
			End Get
		End Property

		' Token: 0x04002225 RID: 8741
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04002226 RID: 8742
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04002227 RID: 8743
		Private <<EMPTY_NAME>> As FixedPanel
	End Class
End Namespace
