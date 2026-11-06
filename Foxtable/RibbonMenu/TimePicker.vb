Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon

Namespace Foxtable.RibbonMenu
	' Token: 0x0200000C RID: 12
	<ComVisible(True)>
	Public Class TimePicker
		Inherits RibbonItem

		' Token: 0x06000043 RID: 67 RVA: 0x00002820 File Offset: 0x00000A20
		Friend Sub New(A_0 As RibbonTimePicker)
			MyBase.New(A_0)
			Me.o__Oo__.O__. = A_0
		End Sub

		' Token: 0x06000044 RID: 68 RVA: 0x00002830 File Offset: 0x00000A30
		Public Sub New(A_0 As String)
			Me.o__Oo__.O__. = New RibbonTimePicker()
			Me.oOo_.0o_O_O_0. = Me.o__Oo__.O__.
			Me.o__Oo__.O__..ID = A_0
		End Sub

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000045 RID: 69 RVA: 0x0000285B File Offset: 0x00000A5B
		' (set) Token: 0x06000046 RID: 70 RVA: 0x00002868 File Offset: 0x00000A68
		Public Property Value As TimeSpan
			Get
				Return Me.o__Oo__.O__..Value
			End Get
			Set(value As TimeSpan)
				Me.o__Oo__.O__..Value = value
			End Set
		End Property

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000047 RID: 71 RVA: 0x00002876 File Offset: 0x00000A76
		' (set) Token: 0x06000048 RID: 72 RVA: 0x00002883 File Offset: 0x00000A83
		Public Property Label As String
			Get
				Return Me.o__Oo__.O__..Label
			End Get
			Set(value As String)
				Me.o__Oo__.O__..Label = value
			End Set
		End Property

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000049 RID: 73 RVA: 0x00002891 File Offset: 0x00000A91
		' (set) Token: 0x0600004A RID: 74 RVA: 0x0000289E File Offset: 0x00000A9E
		Public Property TextAreaWidth As Integer
			Get
				Return Me.o__Oo__.O__..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.o__Oo__.O__..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x0600004B RID: 75 RVA: 0x000028AC File Offset: 0x00000AAC
		Public ReadOnly Property ValueIsNull As Boolean
			Get
				Return Me.o__Oo__.O__..ValueIsNull
			End Get
		End Property

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600004C RID: 76 RVA: 0x000028B9 File Offset: 0x00000AB9
		' (set) Token: 0x0600004D RID: 77 RVA: 0x000028C9 File Offset: 0x00000AC9
		Public Property LongTimeFormat As Boolean
			Get
				Return Me.o__Oo__.O__..StandardFormat = 1
			End Get
			Set(value As Boolean)
				If value Then
					Me.o__Oo__.O__..StandardFormat = 1
					Return
				End If
				Me.o__Oo__.O__..StandardFormat = 0
			End Set
		End Property

		' Token: 0x04000011 RID: 17
		Friend <<EMPTY_NAME>> As RibbonTimePicker
	End Class
End Namespace
