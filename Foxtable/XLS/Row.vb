Imports System
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E4 RID: 1252
	<oO0oooo("1158")>
	Public Class Row
		' Token: 0x06005052 RID: 20562 RVA: 0x00218694 File Offset: 0x00216894
		Friend Sub New(A_0 As XLRow)
			Me.OoOoo.o. = A_0
		End Sub

		' Token: 0x17001224 RID: 4644
		' (get) Token: 0x06005053 RID: 20563 RVA: 0x002186A3 File Offset: 0x002168A3
		' (set) Token: 0x06005054 RID: 20564 RVA: 0x002186B6 File Offset: 0x002168B6
		Public Property Height As Integer
			Get
				Return C1XLBook.TwipsToPixels(CDbl(Me.OoOoo.o..Height))
			End Get
			Set(value As Integer)
				Me.OoOoo.o..Height = C1XLBook.PixelsToTwips(CDbl(value))
			End Set
		End Property

		' Token: 0x17001225 RID: 4645
		' (get) Token: 0x06005055 RID: 20565 RVA: 0x002186CA File Offset: 0x002168CA
		' (set) Token: 0x06005056 RID: 20566 RVA: 0x002186D7 File Offset: 0x002168D7
		Public Property PageBreak As Boolean
			Get
				Return Me.OoOoo.o..PageBreak
			End Get
			Set(value As Boolean)
				Me.OoOoo.o..PageBreak = value
			End Set
		End Property

		' Token: 0x17001226 RID: 4646
		' (get) Token: 0x06005057 RID: 20567 RVA: 0x002186E5 File Offset: 0x002168E5
		' (set) Token: 0x06005058 RID: 20568 RVA: 0x002186F2 File Offset: 0x002168F2
		Public Property Visible As Boolean
			Get
				Return Me.OoOoo.o..Visible
			End Get
			Set(value As Boolean)
				Me.OoOoo.o..Visible = value
			End Set
		End Property

		' Token: 0x17001227 RID: 4647
		' (get) Token: 0x06005059 RID: 20569 RVA: 0x00218700 File Offset: 0x00216900
		' (set) Token: 0x0600505A RID: 20570 RVA: 0x00218712 File Offset: 0x00216912
		Public Property Style As Style
			Get
				Return New Style(Me.OoOoo.o..Style)
			End Get
			Set(value As Style)
				If value Is Nothing Then
					Me.OoOoo.o..Style = Nothing
					Return
				End If
				Me.OoOoo.o..Style = value.Ooo_O__.0.
			End Set
		End Property

		' Token: 0x0400219A RID: 8602
		Friend <<EMPTY_NAME>> As XLRow
	End Class
End Namespace
