Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020000A9 RID: 169
	<oO0oooo("2716")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeDeleteFileEventArgs
		' Token: 0x060006D8 RID: 1752 RVA: 0x00026DBC File Offset: 0x00024FBC
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol, A_3 As String)
			Me.O_0O_._o. = False
			If A_3 = DBNull.Value Then
				A_3 = Nothing
			End If
			Me.o0.OO0OOOO000_. = A_0
			Me.o0.OO0OOOO000_. = A_1
			Me.o0.OO0OOOO000_. = A_2
			Me.o0.OO0OOOO000_. = A_3
		End Sub

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x060006D9 RID: 1753 RVA: 0x00026DF4 File Offset: 0x00024FF4
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x060006DA RID: 1754 RVA: 0x00026DFC File Offset: 0x00024FFC
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
		End Property

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x060006DB RID: 1755 RVA: 0x00026E04 File Offset: 0x00025004
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
		End Property

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x060006DC RID: 1756 RVA: 0x00026E0C File Offset: 0x0002500C
		' (set) Token: 0x060006DD RID: 1757 RVA: 0x00026E14 File Offset: 0x00025014
		Public Property FileName As String
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
			Set(value As String)
				Me.o0.OO0OOOO000_. = value
			End Set
		End Property

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x060006DE RID: 1758 RVA: 0x00026E1D File Offset: 0x0002501D
		' (set) Token: 0x060006DF RID: 1759 RVA: 0x00026E25 File Offset: 0x00025025
		Public Property Cancel As Boolean
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
			Set(value As Boolean)
				Me.o0.OO0OOOO000_. = value
			End Set
		End Property

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x060006E0 RID: 1760 RVA: 0x00026E2E File Offset: 0x0002502E
		' (set) Token: 0x060006E1 RID: 1761 RVA: 0x00026E36 File Offset: 0x00025036
		Public Property DeleteLocalFile As Boolean
			Get
				Return Me.O_oo_O.__o00.
			End Get
			Set(value As Boolean)
				Me.O_0O_._o. = True
				Me.O_oo_O.__o00. = value
			End Set
		End Property

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x060006E2 RID: 1762 RVA: 0x00026E46 File Offset: 0x00025046
		Friend ReadOnly Property HaveSetDeleteMode As Boolean
			Get
				Return Me.O_0O_._o.
			End Get
		End Property

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x060006E3 RID: 1763 RVA: 0x00026E50 File Offset: 0x00025050
		Public ReadOnly Property Form As Form
			Get
				Dim result As Form
				If OO_00oOO.Tables.get_Contains(Me.DataTable.Name) Then
					result = OO_00oOO.Tables(Me.DataTable.Name).Form
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x040001DE RID: 478
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040001DF RID: 479
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x040001E0 RID: 480
		Private <<EMPTY_NAME>> As DataCol

		' Token: 0x040001E1 RID: 481
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001E2 RID: 482
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001E3 RID: 483
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001E4 RID: 484
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
