Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb

Namespace Foxtable
	' Token: 0x02000096 RID: 150
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class UpdateRowEventArgs
		Inherits DataRowEventArgs

		' Token: 0x0600058D RID: 1421 RVA: 0x0001D4B7 File Offset: 0x0001B6B7
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As OleDbRowUpdatedEventArgs)
			MyBase.New(A_0, A_1)
			Me.O__00.__0_O. = A_2
		End Sub

		' Token: 0x0600058E RID: 1422 RVA: 0x0001D4C8 File Offset: 0x0001B6C8
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As Integer, A_3 As Integer)
			MyBase.New(A_0, A_1)
			Me.O__00.__0_O. = A_2
			Me.oO_o_0.0. = A_3
		End Sub

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x0600058F RID: 1423 RVA: 0x0001D4E4 File Offset: 0x0001B6E4
		Public ReadOnly Property StatementType As Integer
			Get
				Dim result As Integer
				If Me.O__00.__0_O. IsNot Nothing Then
					Select Case Me.O__00.__0_O..StatementType
						Case System.Data.StatementType.Insert
							result = 0
						Case System.Data.StatementType.Update
							result = 1
						Case System.Data.StatementType.Delete
							result = 2
					End Select
				Else
					result = Me.O__00.__0_O.
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x06000590 RID: 1424 RVA: 0x0001D530 File Offset: 0x0001B730
		Public ReadOnly Property Success As Boolean
			Get
				Dim result As Boolean
				If Me.O__00.__0_O. IsNot Nothing Then
					result = (Me.O__00.__0_O..RecordsAffected > 0)
				Else
					result = (Me.oO_o_0.0. <> 0)
				End If
				Return result
			End Get
		End Property

		' Token: 0x04000148 RID: 328
		Private <<EMPTY_NAME>> As OleDbRowUpdatedEventArgs

		' Token: 0x04000149 RID: 329
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400014A RID: 330
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
