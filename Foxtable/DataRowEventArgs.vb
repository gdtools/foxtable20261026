Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000097 RID: 151
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DataRowEventArgs
		' Token: 0x06000591 RID: 1425 RVA: 0x0001D561 File Offset: 0x0001B761
		Public Sub New(A_0 As DataTable, A_1 As DataRow)
			Me.ooo.0. = True
			Me.o0_oo0._. = A_0
			Me.o0_oo0._. = A_1
		End Sub

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x06000592 RID: 1426 RVA: 0x0001D57E File Offset: 0x0001B77E
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.o0_oo0._.
			End Get
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x06000593 RID: 1427 RVA: 0x0001D586 File Offset: 0x0001B786
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.o0_oo0._.
			End Get
		End Property

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x06000594 RID: 1428 RVA: 0x0001D58E File Offset: 0x0001B78E
		' (set) Token: 0x06000595 RID: 1429 RVA: 0x0001D596 File Offset: 0x0001B796
		Public Property Cancel As Boolean
			Get
				Return Me.o0_oo0._.
			End Get
			Set(value As Boolean)
				Me.o0_oo0._. = value
			End Set
		End Property

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x06000596 RID: 1430 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
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

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x06000597 RID: 1431 RVA: 0x0001D5E4 File Offset: 0x0001B7E4
		' (set) Token: 0x06000598 RID: 1432 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		Public Property [Continue] As Boolean
			Get
				Return Me.ooo.0.
			End Get
			Set(value As Boolean)
				Me.ooo.0. = value
			End Set
		End Property

		' Token: 0x0400014B RID: 331
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400014C RID: 332
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x0400014D RID: 333
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400014E RID: 334
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
