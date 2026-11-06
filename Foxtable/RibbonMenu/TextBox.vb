Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200000B RID: 11
	<ComVisible(True)>
	Public Class TextBox
		Inherits RibbonItem

		' Token: 0x0600003B RID: 59 RVA: 0x00002794 File Offset: 0x00000994
		Friend Sub New(A_0 As RibbonTextBox)
			MyBase.New(A_0)
			Me.o__Oo__.O__. = A_0
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x000027A4 File Offset: 0x000009A4
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonTextBox()
			Me.oOo_.0o_O_O_0. = Me.o__Oo__.O__.
			Me.o__Oo__.O__..ID = A_0
		End Sub

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x0600003D RID: 61 RVA: 0x000027CF File Offset: 0x000009CF
		' (set) Token: 0x0600003E RID: 62 RVA: 0x000027DC File Offset: 0x000009DC
		Public Property Text As String
			Get
				Return Me.o__Oo__.O__..Text
			End Get
			Set(value As String)
				Me.o__Oo__.O__..Text = value
			End Set
		End Property

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x0600003F RID: 63 RVA: 0x000027EA File Offset: 0x000009EA
		' (set) Token: 0x06000040 RID: 64 RVA: 0x000027F7 File Offset: 0x000009F7
		Public Property Label As String
			Get
				Return Me.o__Oo__.O__..Label
			End Get
			Set(value As String)
				Me.o__Oo__.O__..Label = value
			End Set
		End Property

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000041 RID: 65 RVA: 0x00002805 File Offset: 0x00000A05
		' (set) Token: 0x06000042 RID: 66 RVA: 0x00002812 File Offset: 0x00000A12
		Public Property TextAreaWidth As Integer
			Get
				Return Me.o__Oo__.O__..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.o__Oo__.O__..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x04000010 RID: 16
		Friend <<EMPTY_NAME>> As RibbonTextBox
	End Class
End Namespace
