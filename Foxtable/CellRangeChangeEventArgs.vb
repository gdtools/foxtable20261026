Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002EB RID: 747
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CellRangeChangeEventArgs
		' Token: 0x06002762 RID: 10082 RVA: 0x0010AE51 File Offset: 0x00109051
		Public Sub New(A_0 As Table, A_1 As CellRange, A_2 As CellRange)
			Me.oOO.oO_____OO_. = A_0
			Me.oOO.oO_____OO_. = A_1
			Me.Oo_O._o__. = A_2
		End Sub

		' Token: 0x170008E1 RID: 2273
		' (get) Token: 0x06002763 RID: 10083 RVA: 0x0010AE6E File Offset: 0x0010906E
		Public ReadOnly Property Table As Table
			Get
				Return Me.oOO.oO_____OO_.
			End Get
		End Property

		' Token: 0x170008E2 RID: 2274
		' (get) Token: 0x06002764 RID: 10084 RVA: 0x0010AE76 File Offset: 0x00109076
		Public ReadOnly Property OldRange As CellRange
			Get
				Return Me.oOO.oO_____OO_.
			End Get
		End Property

		' Token: 0x170008E3 RID: 2275
		' (get) Token: 0x06002765 RID: 10085 RVA: 0x0010AE7E File Offset: 0x0010907E
		Public ReadOnly Property NewRange As CellRange
			Get
				Return Me.Oo_O._o__.
			End Get
		End Property

		' Token: 0x170008E4 RID: 2276
		' (get) Token: 0x06002766 RID: 10086 RVA: 0x0010AE86 File Offset: 0x00109086
		' (set) Token: 0x06002767 RID: 10087 RVA: 0x0010AE8E File Offset: 0x0010908E
		Public Property Cancel As Boolean
			Get
				Return Me.O.OoOo00O_.
			End Get
			Set(value As Boolean)
				Me.O.OoOo00O_. = value
			End Set
		End Property

		' Token: 0x170008E5 RID: 2277
		' (get) Token: 0x06002768 RID: 10088 RVA: 0x0010AE97 File Offset: 0x00109097
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400104F RID: 4175
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001050 RID: 4176
		Private <<EMPTY_NAME>> As CellRange

		' Token: 0x04001051 RID: 4177
		Private <<EMPTY_NAME>> As CellRange

		' Token: 0x04001052 RID: 4178
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
