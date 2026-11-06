Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000017 RID: 23
	<ComVisible(True)>
	Public Class ToggleButton
		Inherits RibbonItem

		' Token: 0x060000AA RID: 170 RVA: 0x00003012 File Offset: 0x00001212
		Friend Sub New(A_0 As RibbonToggleButton)
			MyBase.New(A_0)
			Me.o__Oo__.O__. = A_0
		End Sub

		' Token: 0x060000AB RID: 171 RVA: 0x00003022 File Offset: 0x00001222
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonToggleButton()
			Me.oOo_.0o_O_O_0. = Me.o__Oo__.O__.
			Me.o__Oo__.O__..ID = A_0
		End Sub

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000AC RID: 172 RVA: 0x0000304D File Offset: 0x0000124D
		' (set) Token: 0x060000AD RID: 173 RVA: 0x0000305A File Offset: 0x0000125A
		Public Property Text As String
			Get
				Return Me.o__Oo__.O__..Text
			End Get
			Set(value As String)
				Me.o__Oo__.O__..Text = value
			End Set
		End Property

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000AE RID: 174 RVA: 0x00003068 File Offset: 0x00001268
		' (set) Token: 0x060000AF RID: 175 RVA: 0x00003075 File Offset: 0x00001275
		Public Property Pressed As Boolean
			Get
				Return Me.o__Oo__.O__..Pressed
			End Get
			Set(value As Boolean)
				Me.o__Oo__.O__..Pressed = value
			End Set
		End Property

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x00003083 File Offset: 0x00001283
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x00003090 File Offset: 0x00001290
		Public Property ShortcutKeys As Keys
			Get
				Return Me.o__Oo__.O__..ShortcutKeys
			End Get
			Set(value As Keys)
				Me.o__Oo__.O__..ShortcutKeys = value
			End Set
		End Property

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x0000309E File Offset: 0x0000129E
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x000030AB File Offset: 0x000012AB
		Public Property GroupName As String
			Get
				Return Me.o__Oo__.O__..ToggleGroupName
			End Get
			Set(value As String)
				Me.o__Oo__.O__..ToggleGroupName = value
				Me.o__Oo__.O__..CanDepress = (Operators.CompareString(value, "", True) = 0)
			End Set
		End Property

		' Token: 0x04000020 RID: 32
		Friend <<EMPTY_NAME>> As RibbonToggleButton
	End Class
End Namespace
