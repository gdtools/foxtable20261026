Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000297 RID: 663
	<ComVisible(True)>
	<oO0oooo("0419")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DataRowCollection
		Implements IEnumerable(Of DataRow)

		' Token: 0x06002159 RID: 8537 RVA: 0x000DCF58 File Offset: 0x000DB158
		Public Sub New(A_0 As DataTable)
			SyncLock A_0
				Me._Rows = A_0.[Select]("", "", DataViewRowState.CurrentRows)
				Me._DataTable = A_0
			End SyncLock
		End Sub

		' Token: 0x170007CB RID: 1995
		' (get) Token: 0x0600215A RID: 8538 RVA: 0x000DCFB4 File Offset: 0x000DB1B4
		Public ReadOnly Property Count As Integer
			Get
				Return Me._Rows.Length
			End Get
		End Property

		' Token: 0x0600215B RID: 8539 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
		Public Sub Clear(Optional ReLoad As Boolean = True)
			Dim dataTable As DataTable = OO_00oOO.DataTables(Me._DataTable.TableName)
			If dataTable.frd_IsTemporary Then
				Me._DataTable.Rows.Clear()
				Dim dataTable2 As Object = Me._DataTable
				SyncLock dataTable2
					Me._Rows = Me._DataTable.[Select]("", "", DataViewRowState.CurrentRows)
					GoTo IL_31E
				End SyncLock
			End If
			If dataTable.frd_IsInnerTable OrElse dataTable.frd_IsOuterTable Then
				If dataTable.frd_Connection IsNot Nothing Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand()
					Dim commandText As String
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection) Then
						commandText = "Delete From " + dataTable.o._OOO0oOo0__.
					Else
						commandText = "Delete From [" + dataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
					End If
					oleDbCommand.Connection = dataTable.frd_Connection
					oleDbCommand.CommandText = commandText
					If Operators.CompareString(dataTable.LoadFilter, "", True) > 0 Then
						oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + dataTable.LoadFilter
					End If
					Dim state As ConnectionState = dataTable.frd_Connection.State
					Try
						dataTable.frd_Connection.Open()
						oleDbCommand.ExecuteNonQuery()
						If dataTable.frd_IsInnerTable Then
							oleDbCommand.CommandText = String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table]  = '", dataTable.o._OOO0oOo0__., "'" })
							oleDbCommand.ExecuteNonQuery()
							oleDbCommand.CommandText = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", dataTable.o._OOO0oOo0__., "', 1)" })
							oleDbCommand.ExecuteNonQuery()
						End If
						If ReLoad Then
							Me._DataTable.Rows.Clear()
							dataTable.o0.o.(True, Nothing)
						End If
						GoTo IL_31E
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						GoTo IL_31E
					Finally
						If state <> ConnectionState.Open Then
							dataTable.frd_Connection.Close()
						End If
					End Try
				End If
				If Operators.CompareString(dataTable.UpdateServer, "", True) > 0 Then
					Dim o0O As O0O = O_O0OO.OoO__.0oO0oo.()(dataTable.ConnectionName)
					Dim httpClient As HttpClient = o0O.oO0_0.o.()
					Dim text As String
					If o0O.OO.OoO0. = DataServerTypeEnum.Oracle Then
						text = "Delete From " + dataTable.o._OOO0oOo0__.
					Else
						text = "Delete From [" + dataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
					End If
					If Operators.CompareString(dataTable.LoadFilter, "", True) > 0 Then
						text = text + " Where " + dataTable.LoadFilter
					End If
					httpClient.[Select] = text
					httpClient.FormData("Action") = 7.ToString()
					Try
						httpClient.GetData()
						If ReLoad Then
							Me._DataTable.Rows.Clear()
							dataTable.o0.o.(True, Nothing)
						End If
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "")
					End Try
				End If
			End If
			IL_31E:
			dataTable = Nothing
		End Sub

		' Token: 0x0600215C RID: 8540 RVA: 0x000DD324 File Offset: 0x000DB524
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Add() As DataRow
			Return OO_00oOO.DataTables(Me._DataTable.TableName).AddNew(1)
		End Function

		' Token: 0x0600215D RID: 8541 RVA: 0x000DD341 File Offset: 0x000DB541
		Public Function AddNew() As DataRow
			Return Me.Add()
		End Function

		' Token: 0x0600215E RID: 8542 RVA: 0x000DD349 File Offset: 0x000DB549
		Public Function AddNew(Count As Integer) As DataRow
			Return OO_00oOO.DataTables(Me._DataTable.TableName).AddNew(Count)
		End Function

		' Token: 0x0600215F RID: 8543 RVA: 0x000DD366 File Offset: 0x000DB566
		Public Function Delete(Index As Integer) As Boolean
			Return Me(Index).Delete()
		End Function

		' Token: 0x06002160 RID: 8544 RVA: 0x000DD374 File Offset: 0x000DB574
		Public Sub Remove(Index As Integer)
			Me(Index).BaseRow.RowError = "a"
			Me._DataTable.Rows.RemoveAt(Index)
		End Sub

		' Token: 0x170007CC RID: 1996
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As DataRow
			Get
				Return New DataRow(Me._Rows(Index))
			End Get
		End Property

		' Token: 0x06002162 RID: 8546 RVA: 0x000DD3AC File Offset: 0x000DB5AC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of DataRow) Implements System.Collections.Generic.IEnumerable(Of Foxtable.DataRow).GetEnumerator
			Return New O__(Me._Rows)
		End Function

		' Token: 0x06002163 RID: 8547 RVA: 0x000DD3B9 File Offset: 0x000DB5B9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O__(Me._Rows)
		End Function

		' Token: 0x04000DC0 RID: 3520
		Private _DataTable As DataTable

		' Token: 0x04000DC1 RID: 3521
		Friend _Rows As DataRow()
	End Class
End Namespace
