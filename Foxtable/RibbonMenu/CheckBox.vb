Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000013 RID: 19
	<ComVisible(True)>
	Public Class CheckBox
		Inherits RibbonItem

		' Token: 0x06000088 RID: 136 RVA: 0x00002D0D File Offset: 0x00000F0D
		Friend Sub New(A_0 As RibbonCheckBox)
			MyBase.New(A_0)
			Me.oOoOoOoO._o0. = A_0
		End Sub

		' Token: 0x06000089 RID: 137 RVA: 0x00002D1D File Offset: 0x00000F1D
		Public Sub New(A_0 As String)
			Me.oOoOoOoO._o0. = New RibbonCheckBox()
			Me.oOo_.0o_O_O_0. = Me.oOoOoOoO._o0.
			Me.oOoOoOoO._o0..ID = A_0
		End Sub

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x0600008A RID: 138 RVA: 0x00002D48 File Offset: 0x00000F48
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002D55 File Offset: 0x00000F55
		Public Property Checked As Boolean
			Get
				Return Me.oOoOoOoO._o0..Checked
			End Get
			Set(value As Boolean)
				Me.oOoOoOoO._o0..Checked = value
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x0600008C RID: 140 RVA: 0x00002D63 File Offset: 0x00000F63
		' (set) Token: 0x0600008D RID: 141 RVA: 0x00002D70 File Offset: 0x00000F70
		Public Property ShortcutKeys As Keys
			Get
				Return Me.oOoOoOoO._o0..ShortcutKeys
			End Get
			Set(value As Keys)
				Me.oOoOoOoO._o0..ShortcutKeys = value
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x0600008E RID: 142 RVA: 0x00002D7E File Offset: 0x00000F7E
		' (set) Token: 0x0600008F RID: 143 RVA: 0x00002D8B File Offset: 0x00000F8B
		Public Property Text As String
			Get
				Return Me.oOoOoOoO._o0..Text
			End Get
			Set(value As String)
				Me.oOoOoOoO._o0..Text = value
			End Set
		End Property

		' Token: 0x04000018 RID: 24
		Friend <<EMPTY_NAME>> As RibbonCheckBox
	End Class
End Namespace
