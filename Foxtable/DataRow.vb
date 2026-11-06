Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000296 RID: 662
	<ComVisible(True)>
	<oO0oooo("1358")>
	Public Class DataRow
		' Token: 0x06002129 RID: 8489 RVA: 0x000D91C0 File Offset: 0x000D73C0
		Public Sub New(A_0 As DataRow)
			Me.OO0._o_00000. = True
			Me.OO0._o_00000. = A_0
		End Sub

		' Token: 0x170007BF RID: 1983
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(ColumnName As String) As Object
			Get
				Dim version As DataRowVersion = DataRowVersion.[Default]
				If Me.OO0._o_00000..RowState = DataRowState.Deleted Then
					version = DataRowVersion.Original
				End If
				Dim result As Object
				If Me.OO0._o_00000.(ColumnName, version) Is DBNull.Value Then
					Dim dataType As Type = Me.BaseRow.Table.Columns(ColumnName).DataType
					If dataType Is GetType(String) Then
						result = ""
					ElseIf dataType Is GetType(Boolean) Then
						result = False
					ElseIf dataType Is GetType(DateTime) Then
						result = Nothing
					Else
						result = 0
					End If
				Else
					If Me.OO0._o_00000..Table.Columns(ColumnName).DataType Is GetType(DateTime) Then
						Dim dateTime As DateTime = Conversions.ToDate(Me.OO0._o_00000.(ColumnName, version))
						If Me.OO0._o_00000..Table.DataSet Is Nothing OrElse Me.OO0._o_00000..Table.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() Then
							Return dateTime
						End If
						Select Case OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName).DataCols(ColumnName).DateTimeFormat
							Case 0
								Return dateTime.[Date]
							Case 1
								dateTime = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 2
								Return New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
							Case 3
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 4
								Return dateTime
						End Select
					End If
					result = Me.OO0._o_00000.(ColumnName, version)
				End If
				Return result
			End Get
			Set(value As Object)
				If value IsNot Nothing AndAlso value.[GetType]() Is GetType(DateTime) AndAlso DateTime.Compare(Conversions.ToDate(value), DateTime.MinValue) = 0 Then
					value = Nothing
				End If
				If Not o_O_o_oOoo__.oO.O_..Contains(ColumnName) AndAlso Me.OO0._o_00000..RowState <> DataRowState.Deleted Then
					If value Is Nothing Then
						value = DBNull.Value
					End If
					If Me.OO0._o_00000..Table.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse Operators.CompareString(ColumnName, Me.DataTable.O_.__0., True) <> 0 Then
						If Me.OO0._o_00000..HasVersion(DataRowVersion.Proposed) AndAlso Me.OO0._o_00000..RowState <> DataRowState.Detached Then
							Me.OO0._o_00000..EndEdit()
							If Me.OO0._o_00000..HasVersion(DataRowVersion.Proposed) Then
								Return
							End If
						End If
						If String.Compare(Me.OO0._o_00000.(ColumnName).ToString(), value.ToString(), False) <> 0 Then
							Me.OO0._o_00000.(ColumnName) = RuntimeHelpers.GetObjectValue(value)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170007C0 RID: 1984
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(Column As DataCol) As Object
			Get
				Return Me(Column.Name)
			End Get
			Set(value As Object)
				Me(Column.Name) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170007C1 RID: 1985
		' (get) Token: 0x0600212E RID: 8494 RVA: 0x000D9510 File Offset: 0x000D7710
		' (set) Token: 0x0600212F RID: 8495 RVA: 0x000D9580 File Offset: 0x000D7780
		<oO0oooo("2718")>
		Public Property Lines(ColumnName As String) As List(Of String)
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me(ColumnName))
				Dim result As List(Of String)
				If TypeOf objectValue Is String Then
					Dim list As List(Of String) = New List(Of String)()
					If Me.get_IsNull(ColumnName) Then
						result = list
					Else
						Dim text As String = objectValue.ToString()
						list.AddRange(text.Split(New String() { vbCrLf, vbCr, vbLf }, StringSplitOptions.None))
						result = list
					End If
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As List(Of String))
				Dim value2 As String() = value.ToArray()
				Me(ColumnName) = String.Join(vbCrLf, value2)
			End Set
		End Property

		' Token: 0x170007C2 RID: 1986
		' (get) Token: 0x06002130 RID: 8496 RVA: 0x000D95A6 File Offset: 0x000D77A6
		' (set) Token: 0x06002131 RID: 8497 RVA: 0x000D95B4 File Offset: 0x000D77B4
		<oO0oooo("2718")>
		Public Property Lines(Column As DataCol) As List(Of String)
			Get
				Return Me.get_Lines(Column.Name)
			End Get
			Set(value As List(Of String))
				Me.set_Lines(Column.Name, value)
			End Set
		End Property

		' Token: 0x170007C3 RID: 1987
		' (get) Token: 0x06002132 RID: 8498 RVA: 0x000D95C3 File Offset: 0x000D77C3
		<oO0oooo("0426")>
		Public ReadOnly Property IsNull(ColumnName As String) As Boolean
			Get
				Return Me.OO0._o_00000..IsNull(ColumnName)
			End Get
		End Property

		' Token: 0x170007C4 RID: 1988
		' (get) Token: 0x06002133 RID: 8499 RVA: 0x000D95D1 File Offset: 0x000D77D1
		<oO0oooo("0426")>
		Public ReadOnly Property IsNull(Column As DataCol) As Boolean
			Get
				Return Me.OO0._o_00000..IsNull(Column.Name)
			End Get
		End Property

		' Token: 0x170007C5 RID: 1989
		' (get) Token: 0x06002134 RID: 8500 RVA: 0x000D95E4 File Offset: 0x000D77E4
		<oO0oooo("0428")>
		Public ReadOnly Property RowState As DataRowState
			Get
				Return Me.OO0._o_00000..RowState
			End Get
		End Property

		' Token: 0x170007C6 RID: 1990
		' (get) Token: 0x06002135 RID: 8501 RVA: 0x000D95F4 File Offset: 0x000D77F4
		' (set) Token: 0x06002136 RID: 8502 RVA: 0x000D9644 File Offset: 0x000D7844
		<oO0oooo("0427")>
		Public Property Locked As Boolean
			Get
				Return Me.OO0._o_00000..Table.DataSet IsNot Nothing AndAlso Not Me.OO0._o_00000..IsNull("_Locked") AndAlso Conversions.ToBoolean(Me.OO0._o_00000.("_Locked"))
			End Get
			Set(value As Boolean)
				If Me.Locked <> value Then
					If Me.OO0._o_00000..Table.Columns("_Locked").DataType IsNot GetType(Boolean) Then
						If value Then
							Me.OO0._o_00000.("_Locked") = 1
						Else
							Me.OO0._o_00000.("_Locked") = DBNull.Value
						End If
					Else
						Me.OO0._o_00000.("_Locked") = value
					End If
					If value = Me.Locked Then
						Dim dataTable As DataTable = Me.DataTable
						If dataTable Is Nothing OrElse Me.OO0._o_00000..RowState = DataRowState.Detached Then
							Return
						End If
						Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(dataTable, New DataRow(Me.OO0._o_00000.))
						If dataTable.O0__oo_0O_.__. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
							Try
								dataTable.O0__oo_0O_.__..Invoke(Nothing, New Object() { dataRowEventArgs })
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "表，" + dataTable.Name + "，DataRowLockedChanged")
							End Try
						End If
						If dataTable.GlobalHandler.DataRowLockedChanged Then
							Try
								If O_O0OO.O0_00o.o0__o..O____O_.00. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
									O_O0OO.O0_00o.o0__o..O____O_.00..Invoke(Nothing, New Object() { dataRowEventArgs })
								End If
							Catch a_2 As Exception
								ooO.oOo0Oo.o.(a_2, "全局表事件，DataRowLockedChanged")
							End Try
						End If
					End If
					Main.OO_O.o..O.ooO0. = True
				End If
			End Set
		End Property

		' Token: 0x06002137 RID: 8503 RVA: 0x000D97DC File Offset: 0x000D79DC
		<oO0oooo("0431")>
		Public Function GetChildRows(ChildTableName As String) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim dataRelation As DataRelation = Nothing
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation2 As DataRelation = CType(obj, DataRelation)
					If dataRelation2.ParentTable Is Me.OO0._o_00000..Table And Operators.CompareString(dataRelation2.ChildTable.TableName, ChildTableName, True) = 0 Then
						dataRelation = dataRelation2
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim result As List(Of DataRow)
			If dataRelation Is Nothing Then
				result = list
			Else
				Dim childRows As DataRow() = Me.OO0._o_00000..GetChildRows(dataRelation)
				If childRows.Length = 0 Then
					result = list
				Else
					Dim num As Integer = childRows.Length - 1
					For i As Integer = 0 To num
						If childRows(i).RowState <> DataRowState.Deleted Then
							list.Add(New DataRow(childRows(i)))
						End If
					Next
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x06002138 RID: 8504 RVA: 0x000D98C8 File Offset: 0x000D7AC8
		<oO0oooo("0432")>
		Public Function GetParentRow(ParentTableName As String) As DataRow
			Dim dataRelation As DataRelation = Nothing
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation2 As DataRelation = CType(obj, DataRelation)
					If dataRelation2.ChildTable Is Me.OO0._o_00000..Table And Operators.CompareString(dataRelation2.ParentTable.TableName, ParentTableName, True) = 0 Then
						dataRelation = dataRelation2
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim parentRow As DataRow = Me.OO0._o_00000..GetParentRow(dataRelation.RelationName)
			Dim result As DataRow
			If parentRow Is Nothing Then
				result = Nothing
			Else
				result = New DataRow(parentRow)
			End If
			Return result
		End Function

		' Token: 0x06002139 RID: 8505 RVA: 0x000D9978 File Offset: 0x000D7B78
		<oO0oooo("0433")>
		Public Function GetParentRows(ParentTableName As String) As List(Of DataRow)
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim dataRelation As DataRelation = Nothing
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation2 As DataRelation = CType(obj, DataRelation)
					If dataRelation2.ChildTable Is Me.OO0._o_00000..Table And Operators.CompareString(dataRelation2.ParentTable.TableName, ParentTableName, True) = 0 Then
						dataRelation = dataRelation2
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim result As List(Of DataRow)
			If dataRelation Is Nothing Then
				result = list
			Else
				Dim parentRows As DataRow() = Me.OO0._o_00000..GetParentRows(dataRelation)
				If parentRows.Length = 0 Then
					result = list
				Else
					Dim num As Integer = parentRows.Length - 1
					For i As Integer = 0 To num
						list.Add(New DataRow(parentRows(i)))
					Next
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x0600213A RID: 8506 RVA: 0x000D9A58 File Offset: 0x000D7C58
		Friend Function <<EMPTY_NAME>>() As Boolean
			Me.OO0._o_00000. = True
			Me.Delete()
			Return Me.OO0._o_00000.
		End Function

		' Token: 0x0600213B RID: 8507 RVA: 0x000D9A70 File Offset: 0x000D7C70
		<oO0oooo("0429")>
		Public Function Delete() As Boolean
			Dim result As Boolean
			If Me.Locked Then
				result = False
			Else
				If Me.OO0._o_00000..RowState <> DataRowState.Detached Then
					If Me.OO0._o_00000..Table.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
						Dim dataTable As DataTable = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName)
						Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName), New DataRow(Me.OO0._o_00000.))
						If dataTable.O.oO0_00. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
							Try
								dataTable.O.oO0_00..Invoke(Nothing, New Object() { dataRowEventArgs })
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "表，" + Me.OO0._o_00000..Table.TableName + "，BeforeDeleteDataRow")
							End Try
						End If
						If Not dataRowEventArgs.Cancel AndAlso Me.DataTable.GlobalHandler.BeforeDeleteDataRow AndAlso OO_00oOO.SystemReady AndAlso O_O0OO.O0_00o.o0__o..ooO.0O. IsNot Nothing Then
							Try
								O_O0OO.O0_00o.o0__o..ooO.0O..Invoke(Nothing, New Object() { dataRowEventArgs })
							Catch a_2 As Exception
								ooO.oOo0Oo.o.(a_2, "全局表事件,BeforeDeleteDataRow")
							End Try
						End If
						Me.OO0._o_00000. = dataRowEventArgs.[Continue]
						If dataRowEventArgs.Cancel Then
							Return False
						End If
					End If
					Me.OO0._o_00000..Delete()
				Else
					Dim o_oOooO_O As O_oOooO_O = OO_00oOO.Tables(Me.OO0._o_00000..Table.TableName).foxGrid
					o_oOooO_O.RemoveItem(o_oOooO_O.Rows.Count - 1)
				End If
				result = (Me.OO0._o_00000..RowState = DataRowState.Deleted OrElse Me.OO0._o_00000..RowState = DataRowState.Detached)
			End If
			Return result
		End Function

		' Token: 0x0600213C RID: 8508 RVA: 0x000D9C54 File Offset: 0x000D7E54
		<oO0oooo("2096")>
		Public Sub Remove()
			Me.OO0._o_00000..RowError = "a"
			Me.OO0._o_00000..Table.Rows.Remove(Me.OO0._o_00000.)
		End Sub

		' Token: 0x0600213D RID: 8509 RVA: 0x000D9C81 File Offset: 0x000D7E81
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Refresh()
			Me.Load(True)
		End Sub

		' Token: 0x0600213E RID: 8510 RVA: 0x000D9C8C File Offset: 0x000D7E8C
		<oO0oooo("0430")>
		Public Sub Load(Optional blnSave As Boolean = True)
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName).frd_Connection)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim dataTable As DataTable = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName)
			If(Not dataTable.frd_IsOuterQuery AndAlso Not dataTable.frd_IsInnerQuery AndAlso Not dataTable.frd_IsTemporary AndAlso dataTable.BaseTable.PrimaryKey.Length <> 0) OrElse Operators.CompareString(Me.DataTable.UpdateServer, "", True) <> 0 Then
				Dim flag As Boolean = False
				If Me.OO0._o_00000..RowState = DataRowState.Added Then
					flag = True
				End If
				If blnSave Then
					If Operators.CompareString(Me.DataTable.DataServer, "", True) = 0 Then
						If dataTable._Adapter IsNot Nothing AndAlso dataTable._Adapter.UpdateCommand IsNot Nothing Then
							dataTable._Adapter.Update(New DataRow() { Me.OO0._o_00000. })
						End If
					Else
						Me.Save()
					End If
				End If
				If Not flag Then
					Dim num As Integer = Me.OO0._o_00000..Table.PrimaryKey.Length - 1
					For i As Integer = 0 To num
						If stringBuilder.Length > 0 Then
							stringBuilder.Append(" And ")
						End If
						If Me.OO0._o_00000..Table.PrimaryKey(i).DataType Is GetType(String) Then
							stringBuilder.Append(String.Concat(New String() { "[", Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName, "] = '", Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString(), "'" }))
						ElseIf Me.OO0._o_00000..Table.PrimaryKey(i).DataType Is GetType(DateTime) Then
							stringBuilder.Append(String.Concat(New String() { "[", Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName, "] = #", Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString(), "#" }))
						Else
							stringBuilder.Append("[" + Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName + "] = " + Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString())
						End If
					Next
					If Operators.CompareString(Me.DataTable.DataServer, "", True) = 0 Then
						Dim state As ConnectionState = oleDbCommand.Connection.State
						Try
							If state <> ConnectionState.Open Then
								oleDbCommand.Connection.Open()
							End If
							Dim o._OOO0oOo0__. As String = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName).o._OOO0oOo0__.
							Dim text As String = "Select * From [" + o._OOO0oOo0__. + "] Where " + stringBuilder.ToString()
							If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection) Then
								text = text.Replace("[" + o._OOO0oOo0__. + "]", o._OOO0oOo0__.)
								text = text.Replace("[", """").Replace("]", """")
							End If
							oleDbCommand.CommandText = text
							Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
							If oleDbDataReader.Read() Then
								Dim num2 As Integer = oleDbDataReader.FieldCount - 1
								For j As Integer = 0 To num2
									If Me.OO0._o_00000..Table.Columns.Contains(oleDbDataReader.GetName(j)) Then
										Dim dataColumn As DataColumn = Me.OO0._o_00000..Table.Columns(oleDbDataReader.GetName(j))
										If Operators.CompareString(dataColumn.ColumnName, "_Identify", True) <> 0 Then
											Me.OO0._o_00000.(dataColumn) = RuntimeHelpers.GetObjectValue(oleDbDataReader(j))
										End If
									End If
								Next
							End If
							oleDbDataReader.Close()
							Me.OO0._o_00000..AcceptChanges()
							Return
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "")
							Return
						Finally
							If state <> ConnectionState.Open Then
								oleDbCommand.Connection.Close()
							End If
						End Try
					End If
					Dim str As String = Oo00.oo_0__0.o.(Me.DataTable.HttpSelect)
					Dim a_2 As String = "Select * From " + str + " Where " + stringBuilder.ToString()
					Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
					httpClient.FormData.Add("IgnoreSchema", "True")
					httpClient.[Select] = a_2
					httpClient.FormData("Action") = 2.ToString()
					Dim baseDataTable As DataTable = httpClient.GetBaseDataTable()
					If baseDataTable IsNot Nothing AndAlso baseDataTable.Rows.Count > 0 Then
						Me.DataTable.BaseTable.Merge(baseDataTable, False, MissingSchemaAction.Ignore)
						baseDataTable.Dispose()
					End If
				End If
			End If
		End Sub

		' Token: 0x170007C7 RID: 1991
		' (get) Token: 0x0600213F RID: 8511 RVA: 0x000DA1E8 File Offset: 0x000D83E8
		Public ReadOnly Property BaseRow As DataRow
			Get
				Return Me.OO0._o_00000.
			End Get
		End Property

		' Token: 0x06002140 RID: 8512 RVA: 0x000DA1F0 File Offset: 0x000D83F0
		Public Function Equals(dr1 As DataRow) As Boolean
			Return dr1.BaseRow Is Me.OO0._o_00000.
		End Function

		' Token: 0x170007C8 RID: 1992
		' (get) Token: 0x06002141 RID: 8513 RVA: 0x000DA200 File Offset: 0x000D8400
		Public ReadOnly Property DataTable As DataTable
			Get
				Dim result As DataTable
				If Me.OO0._o_00000. IsNot Nothing Then
					result = Me.OO0._o_00000.
				ElseIf Me.OO0._o_00000..Table.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() AndAlso OO_00oOO.DataTables.Contains(Me.OO0._o_00000..Table.TableName) Then
					result = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName)
				ElseIf Me.OO0._o_00000..Table.ExtendedProperties.Contains("foxtable.datatable") Then
					result = CType(Me.OO0._o_00000..Table.ExtendedProperties("foxtable.datatable"), DataTable)
				ElseIf Me.OO0._o_00000..Table.ExtendedProperties.Contains("MirrorFromDataTable") Then
					result = CType(Me.OO0._o_00000..Table.ExtendedProperties("MirrorFromDataTable"), DataTable)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002142 RID: 8514 RVA: 0x000DA2F0 File Offset: 0x000D84F0
		<oO0oooo("1537")>
		Public Sub Reject()
			Me.RejectChanges()
		End Sub

		' Token: 0x06002143 RID: 8515 RVA: 0x000DA2F8 File Offset: 0x000D84F8
		<oO0oooo("2366")>
		Public Sub Accept()
			Me.OO0._o_00000..AcceptChanges()
		End Sub

		' Token: 0x06002144 RID: 8516 RVA: 0x000DA308 File Offset: 0x000D8508
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub RejectChanges()
			If Me.OO0._o_00000..RowState = DataRowState.Modified Then
				Dim list As List(Of DataColumn) = New List(Of DataColumn)()
				Try
					For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
						Dim dataRelation As DataRelation = CType(obj, DataRelation)
						If dataRelation.ParentTable Is Me.OO0._o_00000..Table AndAlso OO_00oOO.Relations(dataRelation.RelationName).CascadeUpdate Then
							For Each item As DataColumn In dataRelation.ParentColumns
								If Not list.Contains(item) Then
									list.Add(item)
								End If
							Next
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each dataColumn As DataColumn In list
						If Operators.CompareString(dataColumn.Expression, "", True) <= 0 Then
							Me.OO0._o_00000.(dataColumn) = RuntimeHelpers.GetObjectValue(Me.OO0._o_00000.(dataColumn, DataRowVersion.Original))
						End If
					Next
					GoTo IL_1D1
				Finally
					Dim enumerator2 As List(Of DataColumn).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
			End If
			If Me.OO0._o_00000..RowState = DataRowState.Added Then
				Try
					For Each obj2 As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
						Dim dataRelation2 As DataRelation = CType(obj2, DataRelation)
						If dataRelation2.ParentTable Is Me.OO0._o_00000..Table AndAlso OO_00oOO.Relations(dataRelation2.RelationName).CascadeDelete Then
							For Each dataRow As DataRow In Me.OO0._o_00000..GetChildRows(dataRelation2)
								If dataRow.RowState = DataRowState.Added Then
									dataRow.RejectChanges()
								End If
							Next
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
			End If
			IL_1D1:
			Me.OO0._o_00000..RejectChanges()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable.BaseTable Is Me.OO0._o_00000..Table Then
						table.ClearEditInfos()
					End If
					If table.Current IsNot Nothing AndAlso table.Current.DataRow.BaseRow Is Me.OO0._o_00000. AndAlso table.o00oOO00_.ooOo. IsNot Nothing AndAlso table.o00oOO00_.ooOo..FindForm() IsNot Nothing Then
						table.o00oOO00_.ooOo..Oo0o__.OO0o__O.()
					End If
				Next
			Finally
				Dim enumerator4 As IEnumerator(Of Table)
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
			End Try
			If O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.OO0._o_00000..Table.TableName) Then
				OO_00oOO.Tables(Me.OO0._o_00000..Table.TableName).RefreshChildTables()
			End If
		End Sub

		' Token: 0x06002145 RID: 8517 RVA: 0x000DA5F8 File Offset: 0x000D87F8
		Public Sub Save()
			Dim flag As Boolean = False
			If Me.DataTable IsNot Nothing AndAlso Me.DataTable._Adapter IsNot Nothing AndAlso Me.DataTable._Adapter.UpdateCommand IsNot Nothing Then
				flag = True
			End If
			If Me.BaseRow.RowState = DataRowState.Detached AndAlso Operators.CompareString(Me.BaseRow.RowError, "Mirror", True) = 0 Then
				Me.BaseRow.RowError = Nothing
				Me.BaseRow.Table.Rows.Add(Me.BaseRow)
			End If
			If Not flag AndAlso Me.BaseRow.Table.DataSet Is Nothing AndAlso Me.OO0._o_00000. Is Nothing Then
				If Me.BaseRow.Table.ExtendedProperties.ContainsKey("MirrorFromDataTable") Then
					If Operators.CompareString(Me.DataTable.UpdateServer, "", True) > 0 Then
						Dim baseRow As DataRow = Me.BaseRow
						Dim rowState As DataRowState = baseRow.RowState
						If rowState = DataRowState.Added Then
							oOO0oO000_0_0.o__o.OOO__.(Me.DataTable, New DataRow() { baseRow })
							Return
						End If
						If rowState <> DataRowState.Modified Then
							Return
						End If
						oOO0oO000_0_0.oOoOo_o.__.(Me.DataTable, New DataRow() { baseRow })
						Return
					End If
				ElseIf Me.BaseRow.Table.ExtendedProperties.Contains("DataAdapter") Then
					CType(Me.BaseRow.Table.ExtendedProperties("DataAdapter"), OleDbDataAdapter).Update(New DataRow() { Me.BaseRow })
				ElseIf Me.BaseRow.Table.ExtendedProperties.Contains("foxtable.datatable") Then
					Dim dataTable As DataTable = CType(Me.BaseRow.Table.ExtendedProperties("foxtable.datatable"), DataTable)
					If dataTable._Adapter IsNot Nothing Then
						dataTable._Adapter.Update(New DataRow() { Me.BaseRow })
					Else
						Dim baseRow2 As DataRow = Me.BaseRow
						If Operators.CompareString(Me.DataTable.UpdateServer, "", True) > 0 Then
							Dim rowState2 As DataRowState = baseRow2.RowState
							If rowState2 <> DataRowState.Added Then
								If rowState2 <> DataRowState.Deleted Then
									If rowState2 = DataRowState.Modified Then
										oOO0oO000_0_0.oOoOo_o.__.(Me.DataTable, New DataRow() { baseRow2 })
									End If
								Else
									oOO0oO000_0_0.OO.OoO0.(Me.DataTable, New DataRow() { baseRow2 })
								End If
							Else
								oOO0oO000_0_0.o__o.OOO__.(Me.DataTable, New DataRow() { baseRow2 })
							End If
						End If
					End If
				End If
				If Me.BaseRow.Table.ExtendedProperties.Contains("Mirror") AndAlso Conversions.ToBoolean(Me.BaseRow.Table.ExtendedProperties("Mirror")) Then
					Me.BaseRow.Table.Rows.Remove(Me.BaseRow)
					Return
				End If
			Else
				If(Me.BaseRow.RowState = DataRowState.Added OrElse Me.BaseRow.RowState = DataRowState.Modified) AndAlso Me.OO0._o_00000..Table.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
					Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(Me.DataTable, Me)
					If Me.DataTable.o.__Oo_Oo_. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
						Try
							Me.DataTable.o.__Oo_Oo_..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "表，" + Me.DataTable.Name + "，BeforeSaveDataRow")
						End Try
					End If
					If Not dataRowEventArgs.Cancel AndAlso Me.DataTable.GlobalHandler.BeforeSaveDataRow AndAlso OO_00oOO.SystemReady AndAlso O_O0OO.O0_00o.o0__o..O__0o._O_oo. IsNot Nothing Then
						Try
							O_O0OO.O0_00o.o0__o..O__0o._O_oo..Invoke(Nothing, New Object() { dataRowEventArgs })
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "全局表事件, BeforeSaveDataRow")
						End Try
					End If
					If dataRowEventArgs.Cancel Then
						Return
					End If
				End If
				If Operators.CompareString(Me.DataTable.DataServer, "", True) > 0 Then
					Dim baseRow3 As DataRow = Me.BaseRow
					If Operators.CompareString(Me.DataTable.UpdateServer, "", True) > 0 Then
						Dim rowState3 As DataRowState = baseRow3.RowState
						If rowState3 = DataRowState.Added Then
							oOO0oO000_0_0.o__o.OOO__.(Me.DataTable, New DataRow() { baseRow3 })
							Return
						End If
						If rowState3 = DataRowState.Deleted Then
							oOO0oO000_0_0.OO.OoO0.(Me.DataTable, New DataRow() { baseRow3 })
							Return
						End If
						If rowState3 <> DataRowState.Modified Then
							Return
						End If
						oOO0oO000_0_0.oOoOo_o.__.(Me.DataTable, New DataRow() { baseRow3 })
						Return
					End If
				Else
					Dim rowState4 As DataRowState = Me.BaseRow.RowState
					If rowState4 = DataRowState.Added Then
						Me.DataTable.oo_.0oo_.(New DataRow() { Me.BaseRow })
						Return
					End If
					If rowState4 <> DataRowState.Deleted Then
						If rowState4 <> DataRowState.Modified Then
							Return
						End If
						Me.DataTable.O0_0oOO.0.(New DataRow() { Me.BaseRow })
						Return
					Else
						Me.DataTable.oO.o_0.(New DataRow() { Me.BaseRow })
					End If
				End If
			End If
		End Sub

		' Token: 0x170007C9 RID: 1993
		' (get) Token: 0x06002146 RID: 8518 RVA: 0x000DAB0C File Offset: 0x000D8D0C
		<oO0oooo("2411")>
		Public ReadOnly Property OriginalIsNull(ColumnName As String) As Boolean
			Get
				Dim result As Boolean
				If Me.BaseRow Is Nothing Then
					result = True
				ElseIf Me.BaseRow.RowState = DataRowState.Added Then
					result = True
				Else
					Dim baseRow As DataRow = Me.BaseRow
					Dim column As DataColumn = Me.BaseRow.Table.Columns(ColumnName)
					result = Me.BaseRow.IsNull(column, DataRowVersion.Original)
				End If
				Return result
			End Get
		End Property

		' Token: 0x170007CA RID: 1994
		' (get) Token: 0x06002147 RID: 8519 RVA: 0x000DAB68 File Offset: 0x000D8D68
		<oO0oooo("2369")>
		Public ReadOnly Property OriginalValue(ColumnName As String) As Object
			Get
				Dim result As Object
				If Me.BaseRow Is Nothing Then
					result = Nothing
				ElseIf Me.BaseRow.RowState = DataRowState.Added Then
					result = Nothing
				Else
					Dim baseRow As DataRow = Me.BaseRow
					Dim column As DataColumn = Me.BaseRow.Table.Columns(ColumnName)
					If Me.BaseRow.IsNull(column, DataRowVersion.Original) Then
						Dim dataType As Type = Me.BaseRow.Table.Columns(ColumnName).DataType
						If dataType Is GetType(String) Then
							result = ""
						ElseIf dataType Is GetType(Boolean) Then
							result = False
						ElseIf dataType Is GetType(DateTime) Then
							result = Nothing
						Else
							result = 0
						End If
					Else
						If Me.BaseRow.Table.Columns(ColumnName).DataType Is GetType(DateTime) Then
							Dim dateTime As DateTime = Conversions.ToDate(Me.BaseRow(ColumnName, DataRowVersion.Original))
							Select Case OO_00oOO.DataTables(Me.BaseRow.Table.TableName).DataCols(ColumnName).DateTimeFormat
								Case 0
									Return dateTime.[Date]
								Case 1
									dateTime = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
									Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
								Case 2
									Return New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
								Case 3
									Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
								Case 4
									Return dateTime
							End Select
						End If
						result = Me.BaseRow(ColumnName, DataRowVersion.Original)
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002148 RID: 8520 RVA: 0x000DAD78 File Offset: 0x000D8F78
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function LoadPhysicalValue() As Dictionary(Of String, Object)
			Dim dictionary As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName).frd_Connection)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim result As Dictionary(Of String, Object)
			If Me.OO0._o_00000..RowState = DataRowState.Added Then
				result = dictionary
			Else
				If dictionary Is Nothing Then
					dictionary = New Dictionary(Of String, Object)()
				Else
					dictionary.Clear()
				End If
				Dim dataTable As DataTable = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName)
				If dataTable.frd_IsOuterQuery OrElse dataTable.frd_IsInnerQuery OrElse dataTable.frd_IsTemporary OrElse dataTable.BaseTable.PrimaryKey.Length = 0 Then
					result = dictionary
				Else
					Dim num As Integer = Me.OO0._o_00000..Table.PrimaryKey.Length - 1
					For i As Integer = 0 To num
						If stringBuilder.Length > 0 Then
							stringBuilder.Append(" And ")
						End If
						If Me.OO0._o_00000..Table.PrimaryKey(i).DataType Is GetType(String) Then
							stringBuilder.Append(String.Concat(New String() { "[", Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName, "] = '", Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString(), "'" }))
						ElseIf Me.OO0._o_00000..Table.PrimaryKey(i).DataType Is GetType(DateTime) Then
							stringBuilder.Append(String.Concat(New String() { "[", Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName, "] = #", Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString(), "#" }))
						Else
							stringBuilder.Append("[" + Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName + "] = " + Me.OO0._o_00000.(Me.OO0._o_00000..Table.PrimaryKey(i).ColumnName).ToString())
						End If
					Next
					Dim state As ConnectionState = oleDbCommand.Connection.State
					Try
						If state <> ConnectionState.Open Then
							oleDbCommand.Connection.Open()
						End If
						Dim o._OOO0oOo0__. As String = OO_00oOO.DataTables(Me.OO0._o_00000..Table.TableName).o._OOO0oOo0__.
						Dim text As String = "Select * From [" + o._OOO0oOo0__. + "] Where " + stringBuilder.ToString()
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection) Then
							text = text.Replace("[" + o._OOO0oOo0__. + "]", o._OOO0oOo0__.)
							text = text.Replace("[", """").Replace("]", """")
						End If
						oleDbCommand.CommandText = text
						Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
						If oleDbDataReader.Read() Then
							Dim num2 As Integer = oleDbDataReader.FieldCount - 1
							For j As Integer = 0 To num2
								Dim obj As Object = RuntimeHelpers.GetObjectValue(oleDbDataReader(j))
								Dim name As String = oleDbDataReader.GetName(j)
								If obj Is DBNull.Value Then
									obj = Nothing
								ElseIf Me.BaseRow.Table.Columns.Contains(name) AndAlso Me.BaseRow.Table.Columns(name).DataType Is GetType(DateTime) Then
									Dim dateTime As DateTime = Conversions.ToDate(obj)
									Select Case OO_00oOO.DataTables(Me.BaseRow.Table.TableName).DataCols(name).DateTimeFormat
										Case 0
											obj = dateTime.[Date]
										Case 1
											dateTime = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
											obj = dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
										Case 2
											obj = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
										Case 3
											obj = dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
										Case 4
											obj = dateTime
									End Select
								End If
								dictionary.Add(oleDbDataReader.GetName(j), RuntimeHelpers.GetObjectValue(obj))
							Next
						End If
						oleDbDataReader.Close()
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If state <> ConnectionState.Open Then
							oleDbCommand.Connection.Close()
						End If
					End Try
					result = dictionary
				End If
			End If
			Return result
		End Function

		' Token: 0x06002149 RID: 8521 RVA: 0x000DB2B8 File Offset: 0x000D94B8
		Public Function Clone() As DataRow
			Dim dataRow As DataRow = Me.DataTable.NewRow()
			If dataRow IsNot Nothing Then
				Try
					For Each obj As Object In Me.BaseRow.Table.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) AndAlso dataRow.get_IsNull(dataColumn.ColumnName) Then
							dataRow(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(Me.BaseRow(dataColumn))
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.BaseRow.Table.Rows.Add(dataRow.BaseRow)
			End If
			Return dataRow
		End Function

		' Token: 0x0600214A RID: 8522 RVA: 0x000DB384 File Offset: 0x000D9584
		<oO0oooo("2682")>
		Public Sub SetError(ColumnName As String, [Error] As String)
			Me.BaseRow.SetColumnError(ColumnName, [Error])
		End Sub

		' Token: 0x0600214B RID: 8523 RVA: 0x000DB393 File Offset: 0x000D9593
		<oO0oooo("2682")>
		Public Sub SetError(DataCol As DataCol, [Error] As String)
			Me.BaseRow.SetColumnError(DataCol.Name, [Error])
		End Sub

		' Token: 0x0600214C RID: 8524 RVA: 0x000DB3A7 File Offset: 0x000D95A7
		<oO0oooo("2683")>
		Public Function GetError(ColumnName As String) As String
			Return Me.BaseRow.GetColumnError(ColumnName)
		End Function

		' Token: 0x0600214D RID: 8525 RVA: 0x000DB3B5 File Offset: 0x000D95B5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetError(DataCol As DataCol, info As String) As String
			Return Me.BaseRow.GetColumnError(DataCol.Name)
		End Function

		' Token: 0x0600214E RID: 8526 RVA: 0x000DB3C8 File Offset: 0x000D95C8
		<oO0oooo("2684")>
		Public Sub ClearErrors()
			Me.BaseRow.ClearErrors()
		End Sub

		' Token: 0x0600214F RID: 8527 RVA: 0x000DB3D8 File Offset: 0x000D95D8
		<oO0oooo("2953")>
		Public Function SQLLoadImage(Filed As String) As Image
			Dim num As Integer
			Dim result As Image
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = Nothing
				GoTo IL_2C5
				IL_1A:
				num2 = 4
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_1B5
				End If
				IL_37:
				num2 = 5
				Dim oleDbConnection As OleDbConnection = Me.DataTable.frd_Connection
				IL_46:
				num2 = 6
				Dim text As String = Me.DataTable.o._OOO0oOo0__.
				IL_55:
				num2 = 7
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_7E
				End If
				IL_67:
				num2 = 8
				text = "[" + text + "]"
				GoTo IL_9D
				IL_7E:
				num2 = 10
				text = Oo00.oo_0__0.o.(Me.DataTable._Adapter.SelectCommand.CommandText)
				IL_9D:
				num2 = 11
				Dim text2 As String = String.Concat(New String() { "Select [", Filed, "] From ", text, " Where ", Me.OO0._o_00000.() })
				IL_D7:
				num2 = 12
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_10D
				End If
				IL_E8:
				num2 = 13
				text2 = text2.Replace("[", """").Replace("]", """")
				IL_10D:
				num2 = 14
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
				IL_11B:
				num2 = 15
				Dim image As Image = Nothing
				IL_121:
				num2 = 16
				oleDbConnection.Open()
				IL_12B:
				num2 = 17
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				IL_137:
				num2 = 18
				If Not oleDbDataReader.Read() Then
					GoTo IL_16C
				End If
				IL_143:
				num2 = 19
				If oleDbDataReader.IsDBNull(0) Then
					GoTo IL_16C
				End If
				IL_150:
				num2 = 20
				image = Image.FromStream(New MemoryStream(CType(oleDbDataReader(Filed), Byte())))
				IL_16C:
				num2 = 21
				oleDbDataReader.Close()
				IL_176:
				num2 = 22
				oleDbConnection.Close()
				IL_180:
				num2 = 23
				If Information.Err().Number = 0 Then
					GoTo IL_1AA
				End If
				IL_18F:
				num2 = 24
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_1AA:
				num2 = 25
				result = image
				GoTo IL_2C5
				IL_1B5:
				num2 = 27
				Dim text3 As String = Oo00.oo_0__0.o.(Me.DataTable.HttpSelect)
				IL_1CA:
				num2 = 28
				Dim text4 As String = String.Concat(New String() { "Select [", Filed, "] From ", text3, " Where ", Me.OO0._o_00000.() })
				IL_204:
				num2 = 29
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_23A
				End If
				IL_215:
				num2 = 30
				text4 = text4.Replace("[", """").Replace("]", """")
				IL_23A:
				num2 = 31
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
				IL_259:
				num2 = 32
				httpClient.[Select] = text4
				IL_265:
				num2 = 33
				httpClient.FormData.Add("Action", 13.ToString())
				IL_284:
				num2 = 34
				Dim memoryStream As MemoryStream = New MemoryStream()
				IL_28E:
				num2 = 35
				Dim memStream As Boolean = httpClient.GetMemStream(memoryStream)
				IL_29C:
				num2 = 36
				Dim image2 As Image = Nothing
				IL_2A2:
				num2 = 37
				If Not memStream Then
					GoTo IL_2BF
				End If
				IL_2A9:
				num2 = 38
				image2 = Image.FromStream(memoryStream)
				IL_2B5:
				num2 = 39
				memoryStream.Dispose()
				IL_2BF:
				num2 = 40
				result = image2
				IL_2C5:
				GoTo IL_3BB
				IL_2CA:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_37C:
				GoTo IL_3B0
				IL_37E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_38E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_37E
			End Try
			IL_3B0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3BB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002150 RID: 8528 RVA: 0x000DB7C8 File Offset: 0x000D99C8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLInsertImage(Field As String, Image As Image) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = False
				GoTo IL_20D
				IL_1A:
				num2 = 4
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_17B
				End If
				IL_37:
				num2 = 5
				Dim memoryStream As MemoryStream = New MemoryStream()
				IL_40:
				num2 = 6
				Image.Save(memoryStream, ImageFormat.Png)
				IL_4F:
				num2 = 7
				Dim oleDbConnection As OleDbConnection = Me.DataTable.frd_Connection
				IL_5E:
				num2 = 8
				Dim o._OOO0oOo0__. As String = Me.DataTable.o._OOO0oOo0__.
				IL_6D:
				num2 = 9
				Dim text As String = String.Concat(New String() { "Update [", o._OOO0oOo0__., "] Set [", Field, "] = ? Where ", Me.OO0._o_00000.() })
				IL_A7:
				num2 = 10
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_DD
				End If
				IL_B8:
				num2 = 11
				text = text.Replace("[", """").Replace("]", """")
				IL_DD:
				num2 = 12
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				IL_EB:
				num2 = 13
				oleDbCommand.Parameters.Add("@" + Field, OleDbType.Binary, CInt(memoryStream.Length)).Value = memoryStream.ToArray()
				IL_11E:
				num2 = 14
				oleDbConnection.Open()
				IL_128:
				num2 = 15
				oleDbCommand.ExecuteNonQuery()
				IL_133:
				num2 = 16
				oleDbConnection.Close()
				IL_13D:
				num2 = 17
				If Information.Err().Number = 0 Then
					GoTo IL_171
				End If
				IL_14C:
				num2 = 18
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_167:
				num2 = 19
				result = False
				GoTo IL_20D
				IL_171:
				num2 = 21
				result = True
				GoTo IL_20D
				IL_17B:
				num2 = 23
				If Operators.CompareString(Me.DataTable.UpdateServer, "", True) <= 0 Then
					GoTo IL_20D
				End If
				IL_197:
				num2 = 24
				If OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\TempFiles") Then
					GoTo IL_1D1
				End If
				IL_1B5:
				num2 = 25
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "Bin\TempFiles")
				IL_1D1:
				num2 = 26
				Dim text2 As String = OO_00oOO.ProjectPath + "Bin\TempFiles\" + OoOo0O.OO_o.0o_O.(8) + ".png"
				IL_1F0:
				num2 = 27
				Image.Save(text2, ImageFormat.Png)
				IL_200:
				num2 = 28
				Me.SQLInsertFile(Field, text2)
				IL_20D:
				GoTo IL_2D3
				IL_212:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_294:
				GoTo IL_2C8
				IL_296:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2A6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_296
			End Try
			IL_2C8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2D3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002151 RID: 8529 RVA: 0x000DBAD0 File Offset: 0x000D9CD0
		<oO0oooo("2952")>
		Public Function SQLLoadFile(Filed As String, FileName As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = False
				GoTo IL_2DC
				IL_1A:
				num2 = 4
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_1FA
				End If
				IL_37:
				num2 = 5
				Dim oleDbConnection As OleDbConnection = Me.DataTable.frd_Connection
				IL_46:
				num2 = 6
				Dim text As String = Me.DataTable.o._OOO0oOo0__.
				IL_55:
				num2 = 7
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_7E
				End If
				IL_67:
				num2 = 8
				text = "[" + text + "]"
				GoTo IL_9D
				IL_7E:
				num2 = 10
				text = Oo00.oo_0__0.o.(Me.DataTable._Adapter.SelectCommand.CommandText)
				IL_9D:
				num2 = 11
				Dim text2 As String = String.Concat(New String() { "Select [", Filed, "] From ", text, " Where ", Me.OO0._o_00000.() })
				IL_D7:
				num2 = 12
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_10D
				End If
				IL_E8:
				num2 = 13
				text2 = text2.Replace("[", """").Replace("]", """")
				IL_10D:
				num2 = 14
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
				IL_11B:
				num2 = 15
				Dim memoryStream As MemoryStream = Nothing
				IL_121:
				num2 = 16
				oleDbConnection.Open()
				IL_12B:
				num2 = 17
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				IL_137:
				num2 = 18
				If Not oleDbDataReader.Read() Then
					GoTo IL_167
				End If
				IL_143:
				num2 = 19
				If oleDbDataReader.IsDBNull(0) Then
					GoTo IL_167
				End If
				IL_150:
				num2 = 20
				memoryStream = New MemoryStream(CType(oleDbDataReader(Filed), Byte()))
				IL_167:
				num2 = 21
				oleDbDataReader.Close()
				IL_171:
				num2 = 22
				oleDbConnection.Close()
				IL_17B:
				num2 = 23
				If memoryStream IsNot Nothing Then
					GoTo IL_18C
				End If
				IL_182:
				num2 = 24
				result = False
				GoTo IL_2DC
				IL_18C:
				num2 = 25
				Dim fileStream As FileStream = New FileStream(FileName, FileMode.Create)
				IL_198:
				num2 = 26
				fileStream.Write(memoryStream.ToArray(), 0, CInt(memoryStream.Length))
				IL_1B2:
				num2 = 27
				fileStream.Close()
				IL_1BC:
				num2 = 28
				If Information.Err().Number = 0 Then
					GoTo IL_1F0
				End If
				IL_1CB:
				num2 = 29
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_1E6:
				num2 = 30
				result = False
				GoTo IL_2DC
				IL_1F0:
				num2 = 32
				result = True
				GoTo IL_2DC
				IL_1FA:
				num2 = 34
				Dim text3 As String = Oo00.oo_0__0.o.(Me.DataTable.HttpSelect)
				IL_20F:
				num2 = 35
				Dim text4 As String = String.Concat(New String() { "Select [", Filed, "] From ", text3, " Where ", Me.OO0._o_00000.() })
				IL_249:
				num2 = 36
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_27F
				End If
				IL_25A:
				num2 = 37
				text4 = text4.Replace("[", """").Replace("]", """")
				IL_27F:
				num2 = 38
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
				IL_29E:
				num2 = 39
				httpClient.[Select] = text4
				IL_2AA:
				num2 = 40
				httpClient.FormData.Add("Action", 13.ToString())
				IL_2C9:
				num2 = 41
				Dim file As Boolean = httpClient.GetFile(FileName)
				IL_2D6:
				num2 = 42
				result = file
				IL_2DC:
				GoTo IL_3DA
				IL_2E1:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_39B:
				GoTo IL_3CF
				IL_39D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3AD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_39D
			End Try
			IL_3CF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3DA:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002152 RID: 8530 RVA: 0x000DBEDC File Offset: 0x000DA0DC
		<oO0oooo("2951")>
		Public Function SQLInsertFile(Field As String, FileName As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = False
				GoTo IL_2E0
				IL_1A:
				num2 = 4
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_1A7
				End If
				IL_37:
				num2 = 5
				Dim fileStream As FileStream = New FileStream(FileName, FileMode.Open, FileAccess.Read)
				IL_43:
				num2 = 6
				Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
				IL_4E:
				num2 = 7
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin)
				IL_60:
				num2 = 8
				Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
				IL_78:
				num2 = 9
				Dim oleDbConnection As OleDbConnection = Me.DataTable.frd_Connection
				IL_88:
				num2 = 10
				Dim o._OOO0oOo0__. As String = Me.DataTable.o._OOO0oOo0__.
				IL_98:
				num2 = 11
				Dim text As String = String.Concat(New String() { "Update [", o._OOO0oOo0__., "] Set [", Field, "] = ? Where ", Me.OO0._o_00000.() })
				IL_D2:
				num2 = 12
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_108
				End If
				IL_E3:
				num2 = 13
				text = text.Replace("[", """").Replace("]", """")
				IL_108:
				num2 = 14
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				IL_116:
				num2 = 15
				oleDbCommand.Parameters.Add("@" + Field, OleDbType.Binary, array.Length).Value = array
				IL_140:
				num2 = 16
				oleDbConnection.Open()
				IL_14A:
				num2 = 17
				oleDbCommand.ExecuteNonQuery()
				IL_155:
				num2 = 18
				oleDbConnection.Close()
				IL_15F:
				num2 = 19
				fileStream.Close()
				IL_169:
				num2 = 20
				If Information.Err().Number = 0 Then
					GoTo IL_19D
				End If
				IL_178:
				num2 = 21
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_193:
				num2 = 22
				result = False
				GoTo IL_2E0
				IL_19D:
				num2 = 24
				result = True
				GoTo IL_2E0
				IL_1A7:
				num2 = 26
				If Operators.CompareString(Me.DataTable.UpdateServer, "", True) <= 0 Then
					GoTo IL_2E0
				End If
				IL_1C6:
				num2 = 27
				Dim text2 As String = Oo00.o.Oo0oO.(Me.DataTable.HttpSelect)
				IL_1DB:
				num2 = 28
				Dim text3 As String = String.Concat(New String() { "Update ", text2, " Set [", Field, "] = ? Where ", Me.OO0._o_00000.() })
				IL_215:
				num2 = 29
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_24B
				End If
				IL_226:
				num2 = 30
				text3 = text3.Replace("[", """").Replace("]", """")
				IL_24B:
				num2 = 31
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
				IL_26A:
				num2 = 32
				httpClient.[Select] = text3
				IL_276:
				num2 = 33
				httpClient.FormData.Add("Action", 14.ToString())
				IL_295:
				num2 = 34
				httpClient.Files.Add("InsertFile", FileName)
				IL_2AA:
				num2 = 35
				Dim data As Object = httpClient.GetData()
				IL_2B6:
				num2 = 36
				If data Is Nothing OrElse Conversion.Val(RuntimeHelpers.GetObjectValue(data)) <> 1.0 Then
					GoTo IL_2DB
				End If
				IL_2D4:
				num2 = 37
				result = True
				GoTo IL_2E0
				IL_2DB:
				num2 = 39
				result = False
				IL_2E0:
				GoTo IL_3D2
				IL_2E5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_393:
				GoTo IL_3C7
				IL_395:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3A5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_395
			End Try
			IL_3C7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3D2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002153 RID: 8531 RVA: 0x000DC2E0 File Offset: 0x000DA4E0
		<oO0oooo("2956")>
		Public Function SQLSetValue(Field As String, Value As Object) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = False
				GoTo IL_348
				IL_1A:
				num2 = 4
				Dim oleDbConnection As OleDbConnection = Nothing
				IL_1F:
				num2 = 5
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_62
				End If
				IL_3A:
				num2 = 6
				Dim flag As Boolean = Me.DataTable.DataServerType = DataServerTypeEnum.SqlServer
				IL_4C:
				num2 = 7
				Dim text As String = Oo00.oo_0__0.o.(Me.DataTable.HttpSelect)
				GoTo IL_8E
				IL_62:
				num2 = 9
				oleDbConnection = Me.DataTable.frd_Connection
				IL_72:
				num2 = 10
				text = Me.DataTable.o._OOO0oOo0__.
				IL_82:
				num2 = 11
				flag = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection)
				IL_8E:
				num2 = 12
				If text.StartsWith("(") Then
					GoTo IL_D4
				End If
				IL_9F:
				num2 = 14
				If text.StartsWith("[") OrElse text.EndsWith("]") Then
					GoTo IL_D4
				End If
				IL_BE:
				num2 = 15
				text = "[" + text + "]"
				IL_D4:
				num2 = 16
				Dim text2 As String = String.Concat(New String() { "Update ", text, " Set [", Field, "] = ??? Where ", Me.OO0._o_00000.() })
				IL_10E:
				num2 = 17
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_144
				End If
				IL_11F:
				num2 = 18
				text2 = text2.Replace("[", """").Replace("]", """")
				IL_144:
				num2 = 19
				If Value IsNot Nothing Then
					GoTo IL_165
				End If
				IL_14A:
				num2 = 20
				text2 = text2.Replace("???", "Null")
				GoTo IL_228
				IL_165:
				num2 = 22
				If Value.[GetType]() IsNot GetType(String) Then
					GoTo IL_1A5
				End If
				IL_17A:
				num2 = 23
				text2 = text2.Replace("???", "'" + Value.ToString() + "'")
				GoTo IL_228
				IL_1A5:
				num2 = 25
				If Value.[GetType]() IsNot GetType(DateTime) Then
					GoTo IL_211
				End If
				IL_1BA:
				num2 = 26
				If Not flag Then
					GoTo IL_1E9
				End If
				IL_1C1:
				num2 = 27
				text2 = text2.Replace("???", "'" + Value.ToString() + "'")
				GoTo IL_228
				IL_1E9:
				num2 = 29
				text2 = text2.Replace("???", "#" + Value.ToString() + "#")
				GoTo IL_228
				IL_211:
				num2 = 31
				text2 = text2.Replace("???", Value.ToString())
				IL_228:
				num2 = 32
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_2AE
				End If
				IL_243:
				num2 = 33
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
				IL_251:
				num2 = 34
				oleDbConnection.Open()
				IL_25B:
				num2 = 35
				oleDbCommand.ExecuteNonQuery()
				IL_266:
				num2 = 36
				oleDbConnection.Close()
				IL_270:
				num2 = 37
				If Information.Err().Number = 0 Then
					GoTo IL_2A4
				End If
				IL_27F:
				num2 = 38
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_29A:
				num2 = 39
				result = False
				GoTo IL_348
				IL_2A4:
				num2 = 41
				result = True
				GoTo IL_348
				IL_2AE:
				num2 = 43
				If Operators.CompareString(Me.DataTable.UpdateServer, "", True) <= 0 Then
					GoTo IL_348
				End If
				IL_2CA:
				num2 = 44
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
				IL_2E9:
				num2 = 45
				httpClient.[Select] = text2
				IL_2F5:
				num2 = 46
				httpClient.FormData.Add("Action", 7.ToString())
				IL_313:
				num2 = 47
				Dim data As Object = httpClient.GetData()
				IL_31F:
				num2 = 48
				If data Is Nothing Then
					GoTo IL_343
				End If
				IL_326:
				num2 = 49
				result = (Conversion.Val(RuntimeHelpers.GetObjectValue(data)) = 1.0)
				GoTo IL_348
				IL_343:
				num2 = 51
				result = False
				IL_348:
				GoTo IL_46A
				IL_34D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_42B:
				GoTo IL_45F
				IL_42D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_43D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_42D
			End Try
			IL_45F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_46A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002154 RID: 8532 RVA: 0x000DC77C File Offset: 0x000DA97C
		<oO0oooo("2955")>
		Public Function SQLGetValue(Field As String) As Object
			Dim num As Integer
			Dim result As Object
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000.() Then
					GoTo IL_1A
				End If
				IL_11:
				num2 = 3
				result = Nothing
				GoTo IL_25F
				IL_1A:
				num2 = 4
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_17F
				End If
				IL_37:
				num2 = 5
				Dim oleDbConnection As OleDbConnection = Me.DataTable.frd_Connection
				IL_46:
				num2 = 6
				Dim text As String = Me.DataTable.o._OOO0oOo0__.
				IL_55:
				num2 = 7
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_7E
				End If
				IL_67:
				num2 = 8
				text = "[" + text + "]"
				GoTo IL_9D
				IL_7E:
				num2 = 10
				text = Oo00.oo_0__0.o.(Me.DataTable._Adapter.SelectCommand.CommandText)
				IL_9D:
				num2 = 11
				Dim text2 As String = String.Concat(New String() { " Select [", Field, "] From ", text, " Where ", Me.OO0._o_00000.() })
				IL_D7:
				num2 = 12
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_10D
				End If
				IL_E8:
				num2 = 13
				text2 = text2.Replace("[", """").Replace("]", """")
				IL_10D:
				num2 = 14
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
				IL_11B:
				num2 = 15
				oleDbConnection.Open()
				IL_125:
				num2 = 16
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
				IL_136:
				num2 = 17
				oleDbConnection.Close()
				IL_140:
				num2 = 18
				If Information.Err().Number = 0 Then
					GoTo IL_174
				End If
				IL_14F:
				num2 = 19
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_16A:
				num2 = 20
				result = Nothing
				GoTo IL_25F
				IL_174:
				num2 = 22
				result = objectValue
				GoTo IL_25F
				IL_17F:
				num2 = 24
				Dim text3 As String = Oo00.oo_0__0.o.(Me.DataTable.HttpSelect)
				IL_194:
				num2 = 25
				Dim text4 As String = String.Concat(New String() { "Select [", Field, "] From ", text3, " Where ", Me.OO0._o_00000.() })
				IL_1CE:
				num2 = 26
				If Me.DataTable.DataServerType <> DataServerTypeEnum.Oracle Then
					GoTo IL_204
				End If
				IL_1DF:
				num2 = 27
				text4 = text4.Replace("[", """").Replace("]", """")
				IL_204:
				num2 = 28
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.DataTable.ConnectionName).oO0_0.o.()
				IL_223:
				num2 = 29
				httpClient.[Select] = text4
				IL_22F:
				num2 = 30
				httpClient.FormData.Add("Action", 6.ToString())
				IL_24D:
				num2 = 31
				Dim data As Object = httpClient.GetData()
				IL_259:
				num2 = 32
				result = data
				IL_25F:
				GoTo IL_335
				IL_264:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2F6:
				GoTo IL_32A
				IL_2F8:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_308:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2F8
			End Try
			IL_32A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_335:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002155 RID: 8533 RVA: 0x000DCAE4 File Offset: 0x000DACE4
		Private Function <<EMPTY_NAME>>() As String
			Dim num As Integer
			Dim result As String
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OO0._o_00000. Is Nothing Then
					GoTo IL_22
				End If
				IL_11:
				num2 = 3
				Dim dataTable As DataTable = Me.OO0._o_00000..BaseTable
				GoTo IL_31
				IL_22:
				num2 = 5
				dataTable = Me.OO0._o_00000..Table
				IL_31:
				num2 = 6
				If Operators.CompareString(Me.DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_60
				End If
				IL_4C:
				num2 = 7
				Dim flag As Boolean = Me.DataTable.DataServerType = DataServerTypeEnum.SqlServer
				GoTo IL_7C
				IL_60:
				num2 = 9
				Dim a_ As OleDbConnection = Me.DataTable.frd_Connection
				IL_70:
				num2 = 10
				flag = o_O_o_oOoo__.OOOO_OO._oo.(a_)
				IL_7C:
				num2 = 11
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_86:
				num2 = 12
				Dim num3 As Integer = dataTable.PrimaryKey.Length - 1
				For i As Integer = 0 To num3
					IL_9E:
					num2 = 13
					If stringBuilder.Length > 0 Then
						IL_AB:
						num2 = 14
						stringBuilder.Append(" And ")
					End If
					IL_BB:
					num2 = 15
					If dataTable.PrimaryKey(i).DataType Is GetType(String) Then
						IL_D9:
						num2 = 16
						stringBuilder.Append(String.Concat(New String() { "[", dataTable.PrimaryKey(i).ColumnName, "] = '", Me.OO0._o_00000.(dataTable.PrimaryKey(i).ColumnName).ToString(), "'" }))
					Else
						IL_140:
						num2 = 18
						If dataTable.PrimaryKey(i).DataType Is GetType(DateTime) Then
							IL_161:
							num2 = 19
							If flag Then
								IL_168:
								num2 = 20
								stringBuilder.Append(String.Concat(New String() { "[", dataTable.PrimaryKey(i).ColumnName, "] = '", Me.OO0._o_00000.(dataTable.PrimaryKey(i).ColumnName).ToString(), "'" }))
							Else
								IL_1CF:
								num2 = 22
								stringBuilder.Append(String.Concat(New String() { "[", dataTable.PrimaryKey(i).ColumnName, "] = #", Me.OO0._o_00000.(dataTable.PrimaryKey(i).ColumnName).ToString(), "#" }))
							End If
						Else
							IL_233:
							num2 = 24
							stringBuilder.Append("[" + dataTable.PrimaryKey(i).ColumnName + "] = " + Me.OO0._o_00000.(dataTable.PrimaryKey(i).ColumnName).ToString())
						End If
					End If
					IL_27B:
					num2 = 25
				Next
				IL_28D:
				num2 = 26
				result = stringBuilder.ToString()
				IL_298:
				GoTo IL_356
				IL_29D:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_317:
				GoTo IL_34B
				IL_319:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_329:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_319
			End Try
			IL_34B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_356:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002156 RID: 8534 RVA: 0x000DCE6C File Offset: 0x000DB06C
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Me.OO0._o_00000..RowState = DataRowState.Added Then
				MessageBox.Show("新增行必须先保存,才能提取或设置后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x06002157 RID: 8535 RVA: 0x000DCEA1 File Offset: 0x000DB0A1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>()
			Me.OO0._o_00000..EndEdit()
		End Sub

		' Token: 0x06002158 RID: 8536 RVA: 0x000DCEB0 File Offset: 0x000DB0B0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetValue(colname As String) As Object
			Dim baseRow As DataRow = Me.BaseRow
			Dim result As Object
			If baseRow Is Nothing Then
				result = Nothing
			ElseIf Not OO_00oOO.Tables.get_Contains(Me.DataTable.Name) Then
				result = baseRow(colname)
			Else
				Dim table As Table = OO_00oOO.Tables(Me.DataTable.Name)
				If table.GridTreeVisible AndAlso table.o.0ooOO_0__..Contains(colname) Then
					If table.o.0ooOO_0__..ContainsKey(baseRow) Then
						result = table.o.0ooOO_0__.(baseRow)(colname)
					Else
						result = baseRow(colname)
					End If
				Else
					result = baseRow(colname)
				End If
			End If
			Return result
		End Function

		' Token: 0x04000DBD RID: 3517
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000DBE RID: 3518
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000DBF RID: 3519
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
