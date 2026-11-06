Imports System
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004DA RID: 1242
	<oO0oooo("1159")>
	Public Class Col
		' Token: 0x06004FF6 RID: 20470 RVA: 0x00217E6A File Offset: 0x0021606A
		Friend Sub New(A_0 As XLColumn)
			Me.o0_.O_o. = A_0
		End Sub

		' Token: 0x17001200 RID: 4608
		' (get) Token: 0x06004FF7 RID: 20471 RVA: 0x00217E79 File Offset: 0x00216079
		' (set) Token: 0x06004FF8 RID: 20472 RVA: 0x00217E8C File Offset: 0x0021608C
		Public Property Width As Integer
			Get
				Return C1XLBook.TwipsToPixels(CDbl(Me.o0_.O_o..Width))
			End Get
			Set(value As Integer)
				Me.o0_.O_o..Width = C1XLBook.PixelsToTwips(CDbl(value))
			End Set
		End Property

		' Token: 0x17001201 RID: 4609
		' (get) Token: 0x06004FF9 RID: 20473 RVA: 0x00217EA0 File Offset: 0x002160A0
		' (set) Token: 0x06004FFA RID: 20474 RVA: 0x00217EAD File Offset: 0x002160AD
		Public Property PageBreak As Boolean
			Get
				Return Me.o0_.O_o..PageBreak
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..PageBreak = value
			End Set
		End Property

		' Token: 0x17001202 RID: 4610
		' (get) Token: 0x06004FFB RID: 20475 RVA: 0x00217EBB File Offset: 0x002160BB
		' (set) Token: 0x06004FFC RID: 20476 RVA: 0x00217EC8 File Offset: 0x002160C8
		Public Property Visible As Boolean
			Get
				Return Me.o0_.O_o..Visible
			End Get
			Set(value As Boolean)
				Me.o0_.O_o..Visible = value
			End Set
		End Property

		' Token: 0x17001203 RID: 4611
		' (get) Token: 0x06004FFD RID: 20477 RVA: 0x00217ED6 File Offset: 0x002160D6
		' (set) Token: 0x06004FFE RID: 20478 RVA: 0x00217EE8 File Offset: 0x002160E8
		Public Property Style As Style
			Get
				Return New Style(Me.o0_.O_o..Style)
			End Get
			Set(value As Style)
				If value Is Nothing Then
					Me.o0_.O_o..Style = Nothing
					Return
				End If
				Me.o0_.O_o..Style = value.Ooo_O__.0.
			End Set
		End Property

		' Token: 0x04002177 RID: 8567
		Friend <<EMPTY_NAME>> As XLColumn
	End Class
End Namespace
