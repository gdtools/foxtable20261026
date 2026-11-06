Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001F1 RID: 497
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O_o0_0_o0
		' Token: 0x06001830 RID: 6192 RVA: 0x0009DB58 File Offset: 0x0009BD58
		Friend Sub New(A_0 As RequestEventArgs, A_1 As String, A_2 As String, A_3 As Boolean)
			Me.ooO0O.0. = A_0
			Me.o.0O__0. = A_1
			Me.O_0._00_. = A_2
			Me.ooO0O.0. = A_3
		End Sub

		' Token: 0x06001831 RID: 6193 RVA: 0x0009DB7D File Offset: 0x0009BD7D
		Public Sub New(A_0 As DataTable, A_1 As RequestEventArgs)
			Me.ooO0O.0. = A_0
			Me.ooO0O.0. = A_1
		End Sub

		' Token: 0x06001832 RID: 6194 RVA: 0x0009DB94 File Offset: 0x0009BD94
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim oleDbConnection As OleDbConnection = Nothing
			If Operators.CompareString(Me.O_0._00_., "", True) > 0 Then
				If O_O0OO.O._o_.().ContainsKey(Me.O_0._00_.) Then
					oleDbConnection = O_O0OO.O._o_.()(Me.O_0._00_.)
				Else
					Try
						For Each text As String In O_O0OO.O._o_.().Keys
							If Operators.CompareString(text, Me.O_0._00_., True) = 0 Then
								oleDbConnection = O_O0OO.O._o_.()(text)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				If oleDbConnection Is Nothing Then
					Return
				End If
			Else
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
			End If
			Dim oleDbConnection2 As OleDbConnection = oleDbConnection
			oleDbConnection2 = New OleDbConnection(oleDbConnection.ConnectionString)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Me.o.0O__0., oleDbConnection2)
			Dim dataTable As DataTable = New DataTable()
			dataTable.TableName = "temp"
			Try
				If Not Me.ooO0O.0..PostValues.ContainsKey("IgnoreSchema") OrElse Me.ooO0O.0. Then
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
					If Me.ooO0O.0. AndAlso dataTable.PrimaryKey.Length = 0 Then
						Me.ooO0O.0..AppendCookie("Error", "Select语句不包括主键，无法生成可更新DataTable！")
						Me.ooO0O.0..Response.OutputStream.Close()
						Me.ooO0O.0..Response.Close()
						Me.ooO0O.0..Response.Abort()
						Return
					End If
				End If
				oleDbDataAdapter.Fill(dataTable)
			Catch ex As Exception
				Me.ooO0O.0..AppendCookie("Error", ex.Message)
				Me.ooO0O.0..Response.OutputStream.Close()
				Me.ooO0O.0..Response.Close()
				Me.ooO0O.0..Response.Abort()
				Return
			End Try
			Dim dataSet As DataSet = New DataSet()
			dataSet.Tables.Add(dataTable)
			If Me.ooO0O.0. Then
				Dim str As String = Oo00.oo_0__0.o.(Me.o.0O__0.)
				Dim list As List(Of String) = New List(Of String)()
				oleDbDataAdapter = New OleDbDataAdapter("Select * From " + str, oleDbConnection2)
				Dim dataTable2 As DataTable = New DataTable()
				oleDbDataAdapter.FillSchema(dataTable2, SchemaType.Source)
				Try
					For Each obj As Object In dataTable2.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						list.Add(dataColumn.ColumnName.ToLower())
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Dim dataTable3 As DataTable = New DataTable()
				dataTable3.Columns.Add("Name", GetType(String))
				dataTable3.Columns.Add("Value", GetType(String))
				Dim dataRow As DataRow = dataTable3.NewRow()
				dataRow("Name") = "UpdateColumns"
				dataRow("Value") = String.Join("|", list.ToArray())
				dataTable3.Rows.Add(dataRow)
				dataTable3.AcceptChanges()
				dataSet.Tables.Add(dataTable3)
			End If
			Dim memoryStream As MemoryStream = New MemoryStream()
			dataSet.WriteXml(memoryStream, XmlWriteMode.WriteSchema)
			oleDbConnection2.Close()
			dataSet.Tables.Clear()
			dataSet.Dispose()
			dataTable.Dispose()
			oleDbDataAdapter.Dispose()
			memoryStream.Position = 0L
			New oOO_O__(memoryStream, Me.ooO0O.0..Response).oO0o0o._0.(Nothing)
		End Sub

		' Token: 0x06001833 RID: 6195 RVA: 0x0009DF18 File Offset: 0x0009C118
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim memoryStream As MemoryStream = New MemoryStream()
			If Operators.CompareString(Me.ooO0O.0..TableName, "", True) = 0 Then
				Me.ooO0O.0..TableName = "TempDataTable"
			End If
			If Me.ooO0O.0..Rows.Count = 0 Then
				Me.ooO0O.0..WriteXmlSchema(memoryStream)
			Else
				Me.ooO0O.0..WriteXml(memoryStream, XmlWriteMode.WriteSchema)
			End If
			memoryStream.Position = 0L
			New oOO_O__(memoryStream, Me.ooO0O.0..Response).oO0o0o._0.(Nothing)
		End Sub

		' Token: 0x040009F5 RID: 2549
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009F6 RID: 2550
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009F7 RID: 2551
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040009F8 RID: 2552
		Private <<EMPTY_NAME>> As RequestEventArgs

		' Token: 0x040009F9 RID: 2553
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
