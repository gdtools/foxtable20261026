Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002EC RID: 748
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ChangeEditEventArgs
		' Token: 0x06002769 RID: 10089 RVA: 0x0010AEA4 File Offset: 0x001090A4
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As String, A_4 As RecordGrid)
			Me.o.0000OOo_. = A_0
			Me.o.0000OOo_. = A_1
			Me.o.0000OOo_. = A_2
			Me.o.OO. = A_3
			Me.o.0000OOo_. = A_4
		End Sub

		' Token: 0x170008E6 RID: 2278
		' (get) Token: 0x0600276A RID: 10090 RVA: 0x0010AED1 File Offset: 0x001090D1
		Public ReadOnly Property Table As Table
			Get
				Return Me.o.0000OOo_.
			End Get
		End Property

		' Token: 0x170008E7 RID: 2279
		' (get) Token: 0x0600276B RID: 10091 RVA: 0x0010AED9 File Offset: 0x001090D9
		Public ReadOnly Property Row As Row
			Get
				Return Me.o.0000OOo_.
			End Get
		End Property

		' Token: 0x170008E8 RID: 2280
		' (get) Token: 0x0600276C RID: 10092 RVA: 0x0010AEE1 File Offset: 0x001090E1
		Public ReadOnly Property Col As Col
			Get
				Return Me.o.0000OOo_.
			End Get
		End Property

		' Token: 0x170008E9 RID: 2281
		' (get) Token: 0x0600276D RID: 10093 RVA: 0x0010AEE9 File Offset: 0x001090E9
		Public ReadOnly Property Text As String
			Get
				Return Me.o.OO.
			End Get
		End Property

		' Token: 0x170008EA RID: 2282
		' (get) Token: 0x0600276E RID: 10094 RVA: 0x0010AEF1 File Offset: 0x001090F1
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.o.0000OOo_.
			End Get
		End Property

		' Token: 0x170008EB RID: 2283
		' (get) Token: 0x0600276F RID: 10095 RVA: 0x0010AEF9 File Offset: 0x001090F9
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001053 RID: 4179
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001054 RID: 4180
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04001055 RID: 4181
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04001056 RID: 4182
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001057 RID: 4183
		Private <<EMPTY_NAME>> As RecordGrid
	End Class
End Namespace
