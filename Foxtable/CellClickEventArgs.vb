Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020000AA RID: 170
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CellClickEventArgs
		Inherits RowColEventArgs

		' Token: 0x060006E4 RID: 1764 RVA: 0x00026E94 File Offset: 0x00025094
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As RecordGrid, A_4 As String)
			MyBase.New(A_0, A_1, A_2, A_3)
			Me.O.OoOo00O_. = A_4
		End Sub

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x060006E5 RID: 1765 RVA: 0x00026EA9 File Offset: 0x000250A9
		Public ReadOnly Property Button As String
			Get
				Return Me.O.OoOo00O_.
			End Get
		End Property

		' Token: 0x040001E5 RID: 485
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
