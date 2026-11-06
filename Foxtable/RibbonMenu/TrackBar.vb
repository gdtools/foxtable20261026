Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x02000010 RID: 16
	<ComVisible(True)>
	Public Class TrackBar
		Inherits RibbonItem

		' Token: 0x06000072 RID: 114 RVA: 0x00002B96 File Offset: 0x00000D96
		Friend Sub New(A_0 As RibbonTrackBar)
			MyBase.New(A_0)
			Me.O.oOOO. = A_0
		End Sub

		' Token: 0x06000073 RID: 115 RVA: 0x00002BA6 File Offset: 0x00000DA6
		Public Sub New(A_0 As String)
			Me.O.oOOO. = New RibbonTrackBar()
			Me.oOo_.0o_O_O_0. = Me.O.oOOO.
			Me.O.oOOO..ID = A_0
		End Sub

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000074 RID: 116 RVA: 0x00002BD1 File Offset: 0x00000DD1
		' (set) Token: 0x06000075 RID: 117 RVA: 0x00002BDE File Offset: 0x00000DDE
		Public Property Minimum As Integer
			Get
				Return Me.O.oOOO..Minimum
			End Get
			Set(value As Integer)
				Me.O.oOOO..Minimum = value
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000076 RID: 118 RVA: 0x00002BEC File Offset: 0x00000DEC
		' (set) Token: 0x06000077 RID: 119 RVA: 0x00002BF9 File Offset: 0x00000DF9
		Public Property Maximum As Integer
			Get
				Return Me.O.oOOO..Maximum
			End Get
			Set(value As Integer)
				Me.O.oOOO..Maximum = value
			End Set
		End Property

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00002C07 File Offset: 0x00000E07
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00002C14 File Offset: 0x00000E14
		Public Property value As Integer
			Get
				Return Me.O.oOOO..Value
			End Get
			Set(value As Integer)
				Me.O.oOOO..Value = value
			End Set
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00002C22 File Offset: 0x00000E22
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00002C2F File Offset: 0x00000E2F
		Public Property Width As Integer
			Get
				Return Me.O.oOOO..Width
			End Get
			Set(value As Integer)
				Me.O.oOOO..Width = value
			End Set
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00002C3D File Offset: 0x00000E3D
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00002C4A File Offset: 0x00000E4A
		Public Property StepFrequency As Integer
			Get
				Return Me.O.oOOO..StepFrequency
			End Get
			Set(value As Integer)
				Me.O.oOOO..StepFrequency = value
			End Set
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00002C58 File Offset: 0x00000E58
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00002C65 File Offset: 0x00000E65
		Public Property TickFrequency As Integer
			Get
				Return Me.O.oOOO..TickFrequency
			End Get
			Set(value As Integer)
				Me.O.oOOO..TickFrequency = value
			End Set
		End Property

		' Token: 0x04000015 RID: 21
		Friend <<EMPTY_NAME>> As RibbonTrackBar
	End Class
End Namespace
