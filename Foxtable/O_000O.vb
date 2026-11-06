Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004C8 RID: 1224
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O_000O
		Implements Oo0__O__O_0__

		' Token: 0x06004E9C RID: 20124 RVA: 0x00209681 File Offset: 0x00207881
		Public Sub New(A_0 As DataTable)
			Me.DataTable = A_0
			Me.AllowEdit = A_0.AllowEdit
		End Sub

		' Token: 0x06004E9D RID: 20125 RVA: 0x0020969C File Offset: 0x0020789C
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.o00.oo0__00.()
		End Sub

		' Token: 0x06004E9E RID: 20126 RVA: 0x002096A4 File Offset: 0x002078A4
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim allowEdit As Boolean = Me.DataTable.AllowEdit
			Me.DataTable.AllowEdit = Me.AllowEdit
			Me.AllowEdit = allowEdit
		End Sub

		' Token: 0x04002090 RID: 8336
		Private DataTable As DataTable

		' Token: 0x04002091 RID: 8337
		Private AllowEdit As Boolean
	End Class
End Namespace
