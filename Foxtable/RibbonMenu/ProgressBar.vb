Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200000F RID: 15
	<ComVisible(True)>
	Public Class ProgressBar
		Inherits RibbonItem

		' Token: 0x06000066 RID: 102 RVA: 0x00002AD4 File Offset: 0x00000CD4
		Friend Sub New(A_0 As RibbonProgressBar)
			MyBase.New(A_0)
			Me.OOo.O_o. = A_0
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x00002AE4 File Offset: 0x00000CE4
		Public Sub New(A_0 As String)
			Me.OOo.O_o. = New RibbonProgressBar()
			Me.oOo_.0o_O_O_0. = Me.OOo.O_o.
			Me.OOo.O_o..ID = A_0
		End Sub

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000068 RID: 104 RVA: 0x00002B0F File Offset: 0x00000D0F
		' (set) Token: 0x06000069 RID: 105 RVA: 0x00002B1C File Offset: 0x00000D1C
		Public Property Minimum As Integer
			Get
				Return Me.OOo.O_o..Minimum
			End Get
			Set(value As Integer)
				Me.OOo.O_o..Minimum = value
			End Set
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00002B2A File Offset: 0x00000D2A
		' (set) Token: 0x0600006B RID: 107 RVA: 0x00002B37 File Offset: 0x00000D37
		Public Property Maximum As Integer
			Get
				Return Me.OOo.O_o..Maximum
			End Get
			Set(value As Integer)
				Me.OOo.O_o..Maximum = value
			End Set
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00002B45 File Offset: 0x00000D45
		' (set) Token: 0x0600006D RID: 109 RVA: 0x00002B52 File Offset: 0x00000D52
		Public Property value As Integer
			Get
				Return Me.OOo.O_o..Value
			End Get
			Set(value As Integer)
				Me.OOo.O_o..Value = value
			End Set
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00002B60 File Offset: 0x00000D60
		' (set) Token: 0x0600006F RID: 111 RVA: 0x00002B6D File Offset: 0x00000D6D
		Public Property Width As Integer
			Get
				Return Me.OOo.O_o..Width
			End Get
			Set(value As Integer)
				Me.OOo.O_o..Width = value
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x06000070 RID: 112 RVA: 0x00002B7B File Offset: 0x00000D7B
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00002B88 File Offset: 0x00000D88
		Public Property Height As Integer
			Get
				Return Me.OOo.O_o..Height
			End Get
			Set(value As Integer)
				Me.OOo.O_o..Height = value
			End Set
		End Property

		' Token: 0x04000014 RID: 20
		Friend <<EMPTY_NAME>> As RibbonProgressBar
	End Class
End Namespace
