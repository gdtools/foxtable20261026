Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x0200028A RID: 650
	<ComVisible(True)>
	<oO0oooo("0696")>
	Public Class SQLCommand
		' Token: 0x1700072F RID: 1839
		' (get) Token: 0x06001FAB RID: 8107 RVA: 0x000D090B File Offset: 0x000CEB0B
		' (set) Token: 0x06001FAC RID: 8108 RVA: 0x000D0913 File Offset: 0x000CEB13
		Public Property ThrowException As Boolean

		' Token: 0x06001FAD RID: 8109 RVA: 0x000D091C File Offset: 0x000CEB1C
		Public Sub New()
			Me.OO__00.__. = 30
			Me.Oo_oO00.0_. = New oooOo_0oo()
			Me.ThrowException = False
		End Sub

		' Token: 0x06001FAE RID: 8110 RVA: 0x000D0940 File Offset: 0x000CEB40
		<oO0oooo("3312")>
		Public Sub BeginTransaction()
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
			If oleDbConnection IsNot Nothing Then
				If Not Me.AsyncExecute OrElse o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
					Me.OO__00.__. = New OleDbConnection(oleDbConnection.ConnectionString)
					Me.OO__00.__..Open()
					Me.Oo_oO00.0_. = Me.OO__00.__..BeginTransaction()
					Return
				End If
				Throw New NotSupportedException("只有SQL Server数据源才支持多线程事务!")
			Else
				If o0O IsNot Nothing Then
					Throw New NotSupportedException("WEB数据源不支持事务!")
				End If
				Return
			End If
		End Sub

		' Token: 0x06001FAF RID: 8111 RVA: 0x000D09B5 File Offset: 0x000CEBB5
		<oO0oooo("3312")>
		Public Sub Commit()
			If Me.OO__00.__. IsNot Nothing Then
				If Me.Oo_oO00.0_. IsNot Nothing Then
					Me.Oo_oO00.0_..Commit()
					Me.Oo_oO00.0_. = Nothing
				End If
				Me.OO__00.__..Close()
				Me.OO__00.__. = Nothing
			End If
		End Sub

		' Token: 0x06001FB0 RID: 8112 RVA: 0x000D09EB File Offset: 0x000CEBEB
		<oO0oooo("3312")>
		Public Sub Rollback()
			If Me.OO__00.__. IsNot Nothing Then
				If Me.Oo_oO00.0_. IsNot Nothing Then
					Me.Oo_oO00.0_..Rollback()
					Me.Oo_oO00.0_. = Nothing
				End If
				Me.OO__00.__..Close()
				Me.OO__00.__. = Nothing
			End If
		End Sub

		' Token: 0x06001FB1 RID: 8113 RVA: 0x000D0A21 File Offset: 0x000CEC21
		Public Sub New(A_0 As String)
			Me.OO__00.__. = 30
			Me.Oo_oO00.0_. = New oooOo_0oo()
			Me.ThrowException = False
			Me.Oo._000O0O0. = A_0
		End Sub

		' Token: 0x06001FB2 RID: 8114 RVA: 0x000D0A4A File Offset: 0x000CEC4A
		Public Sub New(A_0 As String, A_1 As String)
			Me.OO__00.__. = 30
			Me.Oo_oO00.0_. = New oooOo_0oo()
			Me.ThrowException = False
			Me.Oo._000O0O0. = A_0
			Me.OO__00.__. = A_1
		End Sub

		' Token: 0x17000730 RID: 1840
		' (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000D0A7A File Offset: 0x000CEC7A
		' (set) Token: 0x06001FB4 RID: 8116 RVA: 0x000D0A82 File Offset: 0x000CEC82
		Public Property ConnectionName As String
			Get
				Return Me.OO__00.__.
			End Get
			Set(value As String)
				Me.OO__00.__. = value
			End Set
		End Property

		' Token: 0x17000731 RID: 1841
		' (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000D0A8B File Offset: 0x000CEC8B
		' (set) Token: 0x06001FB6 RID: 8118 RVA: 0x000D0A93 File Offset: 0x000CEC93
		Public Property CommandText As String
			Get
				Return Me.Oo._000O0O0.
			End Get
			Set(value As String)
				Me.Oo._000O0O0. = value
			End Set
		End Property

		' Token: 0x17000732 RID: 1842
		' (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000D0A9C File Offset: 0x000CEC9C
		Friend ReadOnly Property AsyncExecute As Boolean
			Get
				Return Thread.CurrentThread.ManagedThreadId <> Main.OO_O.o.
			End Get
		End Property

		' Token: 0x17000733 RID: 1843
		' (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000D0AB2 File Offset: 0x000CECB2
		<oO0oooo("3266")>
		Public ReadOnly Property Parameters As oooOo_0oo
			Get
				Return Me.Oo_oO00.0_.
			End Get
		End Property

		' Token: 0x06001FB9 RID: 8121 RVA: 0x000D0ABC File Offset: 0x000CECBC
		Private Sub <<EMPTY_NAME>>(ByRef A_0 As OleDbConnection, ByRef A_1 As O0O)
			If Operators.CompareString(Me.ConnectionName, "", True) = 0 Then
				A_0 = O_O0OO.OoO.0OO__0ooo.()
				Return
			End If
			If O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
				A_0 = O_O0OO.O._o_.()(Me.ConnectionName)
				Return
			End If
			If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
				A_1 = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName)
				Return
			End If
			MessageBox.Show("指定的数据源名称""" + Me.ConnectionName + """错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06001FBA RID: 8122 RVA: 0x000D0B54 File Offset: 0x000CED54
		Public Function ExecuteScalar() As Object
			Dim result As Object
			If Me.OO__00.__. IsNot Nothing Then
				result = Me.ExecuteScalar2()
			Else
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim o0O As O0O = Nothing
				Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
				If oleDbConnection IsNot Nothing Then
					If oleDbConnection IsNot O_O0OO.OoO.0OO__0ooo.() AndAlso Not Me.AsyncExecute AndAlso Me.OO__00.__. Is Nothing AndAlso O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) AndAlso OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
						result = Me.ExecuteScalar2()
					Else
						Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
						If oleDbCommand IsNot Nothing Then
							Dim state As ConnectionState = oleDbCommand.Connection.State
							Try
								If oleDbCommand.Connection.State <> ConnectionState.Open Then
									oleDbCommand.Connection.Open()
								End If
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
								Me.OO__00.__.(oleDbCommand)
								If objectValue Is DBNull.Value Then
									Return Nothing
								End If
								Return objectValue
							Catch ex As Exception
								If Me.ThrowException Then
									If ex.InnerException IsNot Nothing Then
										Throw ex.InnerException
									End If
									Throw ex
								Else
									ooO.oOo0Oo.o.(ex, "")
								End If
							Finally
								If Me.OO__00.__. Is Nothing Then
									If Me.AsyncExecute Then
										oleDbCommand.Connection.Close()
									ElseIf state <> ConnectionState.Open AndAlso Not OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection) Then
										oleDbCommand.Connection.Close()
									End If
								End If
							End Try
						End If
						result = Nothing
					End If
				ElseIf o0O IsNot Nothing Then
					Me.Oo_oO00.0_. = o0O.oO0_0.o.()
					Me.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.CommandText, False)
					Me.O_O_Oo00o_.00_.()
					Me.Oo_oO00.0_..FormData("Action") = 15.ToString()
					Me.Oo_oO00.0_..[Select] = Me.CommandText
					If Me.CommandTimeOut <> 30 Then
						Me.Oo_oO00.0_..ReadWriteTimeout = Me.CommandTimeOut
					End If
					If Me.StoredProcedure Then
						Me.Oo_oO00.0_..FormData("StoredProcedure") = "True"
					End If
					Dim dataSet As DataSet = Me.Oo_oO00.0_..oOO.__.()
					If dataSet IsNot Nothing AndAlso dataSet.Tables.Count > 0 Then
						Dim dataTable As DataTable = dataSet.Tables(0)
						Dim dataRow As DataRow = dataTable.Rows(0)
						Dim num As Integer = dataTable.Columns.Count - 1
						For i As Integer = 1 To num
							Dim dataColumn As DataColumn = dataTable.Columns(i)
							If dataRow.IsNull(dataColumn) Then
								Me.Parameters(dataColumn.ColumnName) = Nothing
							Else
								Me.Parameters(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(dataRow(dataColumn))
							End If
						Next
						If dataRow.IsNull(0) Then
							result = Nothing
						Else
							result = dataRow(0)
						End If
					Else
						result = Nothing
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06001FBB RID: 8123 RVA: 0x000D0E40 File Offset: 0x000CF040
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ExecuteScalar2() As Object
			Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
			Dim result As Object
			If oleDbCommand IsNot Nothing Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
				If objectValue Is DBNull.Value Then
					result = Nothing
				Else
					result = objectValue
				End If
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001FBC RID: 8124 RVA: 0x000D0E78 File Offset: 0x000CF078
		Public Function ExecuteNonQuery() As Integer
			Dim result As Integer
			If Me.OO__00.__. IsNot Nothing Then
				result = Me.ExecuteNonQuery2()
			Else
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim o0O As O0O = Nothing
				Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
				If oleDbConnection IsNot Nothing Then
					If oleDbConnection IsNot O_O0OO.OoO.0OO__0ooo.() AndAlso Not Me.AsyncExecute AndAlso Me.OO__00.__. Is Nothing AndAlso O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) AndAlso OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
						result = Me.ExecuteNonQuery2()
					Else
						Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
						If oleDbCommand IsNot Nothing Then
							Dim state As ConnectionState = oleDbCommand.Connection.State
							Try
								If oleDbCommand.Connection.State <> ConnectionState.Open Then
									oleDbCommand.Connection.Open()
								End If
								Dim result2 As Integer = oleDbCommand.ExecuteNonQuery()
								Me.OO__00.__.(oleDbCommand)
								Return result2
							Catch ex As Exception
								If Me.ThrowException Then
									If ex.InnerException IsNot Nothing Then
										Throw ex.InnerException
									End If
									Throw ex
								Else
									ooO.oOo0Oo.o.(ex, "")
								End If
							Finally
								If Me.OO__00.__. Is Nothing Then
									If Me.AsyncExecute Then
										oleDbCommand.Connection.Close()
									ElseIf state <> ConnectionState.Open AndAlso Not OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection) Then
										oleDbCommand.Connection.Close()
									End If
								End If
							End Try
						End If
						result = -1
					End If
				ElseIf o0O IsNot Nothing Then
					Me.Oo_oO00.0_. = o0O.oO0_0.o.()
					Me.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.CommandText, False)
					Me.O_O_Oo00o_.00_.()
					Me.Oo_oO00.0_..FormData("Action") = 16.ToString()
					Me.Oo_oO00.0_..[Select] = Me.CommandText
					If Me.CommandTimeOut <> 30 Then
						Me.Oo_oO00.0_..ReadWriteTimeout = Me.CommandTimeOut
					End If
					If Me.StoredProcedure Then
						Me.Oo_oO00.0_..FormData("StoredProcedure") = "True"
					End If
					Dim dataSet As DataSet = Me.Oo_oO00.0_..oOO.__.()
					If dataSet IsNot Nothing AndAlso dataSet.Tables.Count > 0 Then
						Dim dataTable As DataTable = dataSet.Tables(0)
						Dim dataRow As DataRow = dataTable.Rows(0)
						Dim num As Integer = dataTable.Columns.Count - 1
						For i As Integer = 1 To num
							Dim dataColumn As DataColumn = dataTable.Columns(i)
							If dataRow.IsNull(dataColumn) Then
								Me.Parameters(dataColumn.ColumnName) = Nothing
							Else
								Me.Parameters(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(dataRow(dataColumn))
							End If
						Next
						If dataRow.IsNull(0) Then
							result = 0
						Else
							result = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow(0)))))
						End If
					Else
						result = 0
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06001FBD RID: 8125 RVA: 0x000D115C File Offset: 0x000CF35C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ExecuteNonQuery2() As Integer
			Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
			Dim result As Integer
			If oleDbCommand IsNot Nothing Then
				result = oleDbCommand.ExecuteNonQuery()
			End If
			Return result
		End Function

		' Token: 0x06001FBE RID: 8126 RVA: 0x000D117C File Offset: 0x000CF37C
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable)
			If A_0.PrimaryKey.Length = 1 AndAlso Operators.CompareString(A_0.PrimaryKey(0).ColumnName, "_Identify", True) = 0 Then
				A_0.Columns("_Identify").AutoIncrement = True
				A_0.Columns("_Identify").AutoIncrementStep = 1L
				A_0.Columns("_Identify").AutoIncrementSeed = 1L
				If A_0.Rows.Count > 0 AndAlso A_0.Rows.Count > 0 Then
					A_0.Columns("_Identify").AutoIncrementSeed = CLng((Conversions.ToInteger(A_0.Compute("Max([_Identify])", "")) + 1))
				End If
			End If
		End Sub

		' Token: 0x06001FBF RID: 8127 RVA: 0x000D1244 File Offset: 0x000CF444
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function <<EMPTY_NAME>>(Optional A_0 As Boolean = False) As DataTable
			Dim dataTable As DataTable = New DataTable()
			Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.(A_0)
			Dim a_ As String = ""
			Dim result As DataTable
			If oleDbCommand Is Nothing Then
				result = Nothing
			Else
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand)
				If A_0 Then
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				End If
				oleDbDataAdapter.Fill(dataTable)
				Me.OO__00.__.(oleDbCommand)
				If A_0 Then
					o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
					If dataTable.PrimaryKey.Length > 0 Then
						dataTable.PrimaryKey(0).[ReadOnly] = False
					End If
					a_ = oleDbDataAdapter.UpdateCommand.CommandText.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)(1).Trim(New Char() { "["c, "]"c, """"c })
				End If
				Dim dataTable2 As DataTable = New DataTable(dataTable, oleDbDataAdapter, oleDbCommand.Connection, a_, O_O0OO.OoO.0OO__0ooo.())
				dataTable2.o.OOO_oO0_0O_o. = True
				dataTable2.AddByCode = True
				dataTable2.o.0O000_.()
				If A_0 And Operators.CompareString(Me.OO__00.__., "", True) = 0 Then
					dataTable2.oOo.oO. = True
					Me.Oo._000O0O0.(dataTable)
				End If
				result = dataTable2
			End If
			Return result
		End Function

		' Token: 0x06001FC0 RID: 8128 RVA: 0x000D1348 File Offset: 0x000CF548
		Public Function ExecuteReader(Optional Save As Boolean = False) As DataTable
			Dim result As DataTable
			If Me.OO__00.__. IsNot Nothing Then
				result = Me.O_O_Oo00o_.00_.(Save)
			Else
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim o0O As O0O = Nothing
				Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
				If oleDbConnection IsNot Nothing Then
					Dim dataTable As DataTable = New DataTable()
					Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.(Save)
					Dim a_ As String = ""
					If oleDbCommand Is Nothing Then
						result = Nothing
					Else
						Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand)
						Try
							If Save Then
								oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
							End If
							oleDbDataAdapter.Fill(dataTable)
							Me.OO__00.__.(oleDbCommand)
						Catch ex As Exception
							If Not Me.ThrowException Then
								ooO.oOo0Oo.o.(ex, "")
								Return Nothing
							End If
							If ex.InnerException IsNot Nothing Then
								Throw ex.InnerException
							End If
							Throw ex
						Finally
							If Me.OO__00.__. Is Nothing AndAlso Me.AsyncExecute Then
								oleDbCommand.Connection.Close()
							End If
						End Try
						If Save Then
							o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
							If dataTable.PrimaryKey.Length > 0 Then
								dataTable.PrimaryKey(0).[ReadOnly] = False
							End If
							a_ = oleDbDataAdapter.UpdateCommand.CommandText.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)(1).Trim(New Char() { "["c, "]"c, """"c })
						End If
						Dim dataTable2 As DataTable = New DataTable(dataTable, oleDbDataAdapter, oleDbCommand.Connection, a_, O_O0OO.OoO.0OO__0ooo.())
						dataTable2.o.OOO_oO0_0O_o. = True
						dataTable2.AddByCode = True
						dataTable2.o.0O000_.()
						If Save And Operators.CompareString(Me.OO__00.__., "", True) = 0 Then
							dataTable2.oOo.oO. = True
							Me.Oo._000O0O0.(dataTable)
						End If
						result = dataTable2
					End If
				Else
					If o0O IsNot Nothing Then
						Me.Oo_oO00.0_. = o0O.oO0_0.o.()
						Me.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.CommandText, False)
						Me.O_O_Oo00o_.00_.()
						Me.Oo_oO00.0_..FormData("Action") = 17.ToString()
						Me.Oo_oO00.0_..[Select] = Me.CommandText
						If Me.CommandTimeOut <> 30 Then
							Me.Oo_oO00.0_..ReadWriteTimeout = Me.CommandTimeOut
						End If
						If Me.StoredProcedure Then
							Me.Oo_oO00.0_..FormData("StoredProcedure") = "True"
						End If
						If Not Save Then
							Me.Oo_oO00.0_..FormData("IgnoreSchema") = "True"
						End If
						Dim dataSet As DataSet = Me.Oo_oO00.0_..oOO.__.()
						If dataSet IsNot Nothing AndAlso dataSet.Tables.Count > 0 Then
							Dim dataTable3 As DataTable = New DataTable(dataSet.Tables(0), Nothing, Nothing, Nothing, Nothing)
							dataTable3.o.OOO_oO0_0O_o. = True
							dataTable3.AddByCode = True
							dataTable3.o.0O000_.()
							dataTable3.ConnectionName = Me.ConnectionName
							dataTable3.DataServer = Me.Oo_oO00.0_..Oo_0oO0Oo0_.O_.
							dataTable3.HttpSelect = Me.CommandText
							If dataSet.Tables.Count > 1 Then
								Dim dataTable4 As DataTable = dataSet.Tables(1)
								Dim dataRow As DataRow = dataTable4.Rows(0)
								If Not dataRow.IsNull(0) Then
									Dim collection As String() = dataRow(0).ToString().Split(New Char() { "|"c })
									Dim list As List(Of String) = New List(Of String)()
									list.AddRange(collection)
									dataTable3.UpdateServer = dataTable3.DataServer
									dataTable3.UpdateColumns = list
									Dim text As String = Oo00.oo_0__0.o.(Me.CommandText)
									dataTable3.o._OOO0oOo0__. = text.Trim(New Char() { "["c, "]"c, """"c })
								End If
								Dim num As Integer = dataTable4.Columns.Count - 1
								For i As Integer = 1 To num
									Dim dataColumn As DataColumn = dataTable4.Columns(i)
									If dataRow.IsNull(dataColumn) Then
										Me.Parameters(dataColumn.ColumnName) = Nothing
									Else
										Me.Parameters(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(dataRow(dataColumn))
									End If
								Next
							End If
							If Save AndAlso dataTable3.BaseTable.PrimaryKey.Length > 0 Then
								dataTable3.BaseTable.PrimaryKey(0).[ReadOnly] = False
							End If
							dataSet.Tables.Clear()
							Return dataTable3
						End If
					End If
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x06001FC1 RID: 8129 RVA: 0x000D178C File Offset: 0x000CF98C
		Public Function ExecuteValues() As Dictionary(Of String, Object)
			Return Me.ExcuteValues()
		End Function

		' Token: 0x06001FC2 RID: 8130 RVA: 0x000D1794 File Offset: 0x000CF994
		Private Function <<EMPTY_NAME>>() As Dictionary(Of String, Object)
			Dim dictionary As Dictionary(Of String, Object) = New Dictionary(Of String, Object)(StringComparer.OrdinalIgnoreCase)
			Dim oleDbDataReader As OleDbDataReader = Me.O_O_Oo00o_.00_.().ExecuteReader(CommandBehavior.SingleRow)
			If oleDbDataReader.HasRows Then
				Dim fieldCount As Integer = oleDbDataReader.FieldCount
				oleDbDataReader.Read()
				Dim num As Integer = fieldCount - 1
				For i As Integer = 0 To num
					dictionary.Add(oleDbDataReader.GetName(i), RuntimeHelpers.GetObjectValue(oleDbDataReader(i)))
				Next
				oleDbDataReader.Close()
			End If
			Return dictionary
		End Function

		' Token: 0x06001FC3 RID: 8131 RVA: 0x000D1800 File Offset: 0x000CFA00
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ExcuteValues() As Dictionary(Of String, Object)
			Dim result As Dictionary(Of String, Object)
			If Me.OO__00.__. IsNot Nothing Then
				result = Me.O_O_Oo00o_.00_.()
			Else
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim o0O As O0O = Nothing
				Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
				Dim dictionary As Dictionary(Of String, Object) = New Dictionary(Of String, Object)(StringComparer.OrdinalIgnoreCase)
				If oleDbConnection IsNot Nothing Then
					Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
					If oleDbCommand IsNot Nothing Then
						Dim state As ConnectionState = oleDbCommand.Connection.State
						Try
							If oleDbCommand.Connection.State <> ConnectionState.Open Then
								oleDbCommand.Connection.Open()
							End If
							Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.SingleRow)
							If oleDbDataReader.HasRows Then
								Dim fieldCount As Integer = oleDbDataReader.FieldCount
								oleDbDataReader.Read()
								Dim num As Integer = fieldCount - 1
								For i As Integer = 0 To num
									dictionary.Add(oleDbDataReader.GetName(i), RuntimeHelpers.GetObjectValue(oleDbDataReader(i)))
								Next
								oleDbDataReader.Close()
							End If
						Catch ex As Exception
							If Me.ThrowException Then
								If ex.InnerException IsNot Nothing Then
									Throw ex.InnerException
								End If
								Throw ex
							Else
								ooO.oOo0Oo.o.(ex, "")
							End If
						Finally
							If Me.OO__00.__. Is Nothing Then
								If Me.AsyncExecute Then
									oleDbCommand.Connection.Close()
								ElseIf state <> ConnectionState.Open AndAlso Not OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection) Then
									oleDbCommand.Connection.Close()
								End If
							End If
						End Try
					End If
					result = dictionary
				ElseIf o0O IsNot Nothing Then
					Me.Oo_oO00.0_. = o0O.oO0_0.o.()
					Me.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.CommandText, False)
					Me.O_O_Oo00o_.00_.()
					Me.Oo_oO00.0_..FormData("Action") = 18.ToString()
					Me.Oo_oO00.0_..[Select] = Me.CommandText
					If Me.CommandTimeOut <> 30 Then
						Me.Oo_oO00.0_..ReadWriteTimeout = Me.CommandTimeOut
					End If
					If Me.StoredProcedure Then
						Me.Oo_oO00.0_..FormData("StoredProcedure") = "True"
					End If
					Dim dataSet As DataSet = Me.Oo_oO00.0_..oOO.__.()
					If dataSet IsNot Nothing Then
						If dataSet.Tables.Count = 2 Then
							Dim dataTable As DataTable = dataSet.Tables(1)
							Dim dataRow As DataRow = dataTable.Rows(0)
							Dim num2 As Integer = dataTable.Columns.Count - 1
							For j As Integer = 0 To num2
								Dim dataColumn As DataColumn = dataTable.Columns(j)
								If dataRow.IsNull(dataColumn) Then
									Me.Parameters(dataColumn.ColumnName) = Nothing
								Else
									Me.Parameters(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(dataRow(dataColumn))
								End If
							Next
						End If
						If dataSet.Tables.Count > 0 Then
							Dim dataTable2 As DataTable = dataSet.Tables(0)
							Dim dataRow2 As DataRow = dataTable2.Rows(0)
							Try
								For Each obj As Object In dataTable2.Columns
									Dim dataColumn2 As DataColumn = CType(obj, DataColumn)
									If dataRow2.IsNull(dataColumn2) Then
										dictionary.Add(dataColumn2.ColumnName, Nothing)
									Else
										dictionary.Add(dataColumn2.ColumnName, RuntimeHelpers.GetObjectValue(dataRow2(dataColumn2)))
									End If
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
					End If
					result = dictionary
				End If
			End If
			Return result
		End Function

		' Token: 0x06001FC4 RID: 8132 RVA: 0x000D1B80 File Offset: 0x000CFD80
		Friend Function <<EMPTY_NAME>>() As DataTable
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			Me.O_O_Oo00o_.00_.(oleDbConnection, o0O)
			Dim dataTable As DataTable = New DataTable()
			Dim dataTable2 As DataTable = Nothing
			If oleDbConnection IsNot Nothing Then
				Dim oleDbCommand As OleDbCommand = Me.O_O_Oo00o_.00_.()
				If oleDbCommand Is Nothing Then
					Return Nothing
				End If
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(oleDbCommand)
				Try
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					Return Nothing
				Finally
					If Me.OO__00.__. Is Nothing AndAlso Me.AsyncExecute Then
						oleDbCommand.Connection.Close()
					End If
				End Try
				dataTable2 = New DataTable(dataTable, Nothing, Nothing, Nothing, Nothing)
			ElseIf o0O IsNot Nothing Then
				Me.Oo_oO00.0_. = o0O.oO0_0.o.()
				Me.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.CommandText, False)
				Me.Oo_oO00.0_..FormData("Action") = 12.ToString()
				Me.Oo_oO00.0_..[Select] = Me.CommandText
				If Me.CommandTimeOut <> 30 Then
					Me.Oo_oO00.0_..ReadWriteTimeout = Me.CommandTimeOut
				End If
				Me.Oo_oO00.0_..FormData("IgnoreSchema") = "True"
				dataTable = Me.Oo_oO00.0_..GetBaseDataTable()
				dataTable2 = New DataTable(dataTable, Nothing, Nothing, Nothing, Nothing)
			End If
			dataTable2.AddByCode = True
			dataTable2.o.0O000_.()
			Return dataTable2
		End Function

		' Token: 0x17000734 RID: 1844
		' (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000D1CF4 File Offset: 0x000CFEF4
		' (set) Token: 0x06001FC6 RID: 8134 RVA: 0x000D1CFC File Offset: 0x000CFEFC
		<oO0oooo("3267")>
		Public Property StoredProcedure As Boolean
			Get
				Return Me.Oo_oO00.0_.
			End Get
			Set(value As Boolean)
				Me.Oo_oO00.0_. = value
			End Set
		End Property

		' Token: 0x06001FC7 RID: 8135 RVA: 0x000D1D05 File Offset: 0x000CFF05
		Private Function <<EMPTY_NAME>>() As OleDbCommand
			Return Me.O_O_Oo00o_.00_.(False)
		End Function

		' Token: 0x06001FC8 RID: 8136 RVA: 0x000D1D10 File Offset: 0x000CFF10
		Private Function <<EMPTY_NAME>>(Optional A_0 As Boolean = False) As OleDbCommand
			Dim num As Integer
			Dim result As OleDbCommand
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim oleDbCommand As OleDbCommand = New OleDbCommand()
				IL_10:
				num2 = 3
				Dim oleDbConnection As OleDbConnection = Nothing
				IL_15:
				num2 = 4
				Dim text As String = Me.CommandText
				IL_1F:
				num2 = 5
				If Operators.CompareString(Me.ConnectionName, "", True) <= 0 Then
					GoTo IL_C6
				End If
				IL_38:
				num2 = 6
				If Not O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					GoTo IL_65
				End If
				IL_4C:
				num2 = 7
				oleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
				GoTo IL_112
				IL_65:
				num2 = 9
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text2 As String = enumerator.Current
					IL_84:
					num2 = 10
					If Operators.CompareString(text2, Me.ConnectionName, True) = 0 Then
						IL_97:
						num2 = 11
						oleDbConnection = O_O0OO.O._o_.()(text2)
					End If
					IL_A8:
					num2 = 12
				End While
				IL_B4:
				num2 = 13
				CType(enumerator, IDisposable).Dispose()
				GoTo IL_112
				IL_C6:
				num2 = 15
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
				IL_D0:
				num2 = 16
				If Operators.CompareString(text, "", True) <= 0 OrElse Not text.StartsWith("create ", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_112
				End If
				IL_F2:
				num2 = 17
				MessageBox.Show("内部表禁止执行Create语句!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_108:
				num2 = 18
				result = Nothing
				GoTo IL_3D2
				IL_112:
				num2 = 19
				text = Oo00.o0_o._O_.(oleDbConnection, text, False)
				IL_121:
				num2 = 20
				If oleDbConnection IsNot Nothing AndAlso Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_141
				End If
				IL_137:
				num2 = 21
				result = Nothing
				GoTo IL_3D2
				IL_141:
				num2 = 22
				If Me.OO__00.__. Is Nothing Then
					GoTo IL_159
				End If
				IL_14C:
				num2 = 23
				oleDbConnection = Me.OO__00.__.
				GoTo IL_175
				IL_159:
				num2 = 25
				If Not Me.AsyncExecute Then
					GoTo IL_175
				End If
				IL_164:
				num2 = 26
				oleDbConnection = New OleDbConnection(oleDbConnection.ConnectionString)
				IL_175:
				num2 = 27
				oleDbCommand.Connection = oleDbConnection
				IL_181:
				num2 = 28
				oleDbCommand.CommandText = text
				IL_18D:
				num2 = 29
				oleDbCommand.CommandTimeout = Me.CommandTimeOut
				IL_19D:
				num2 = 30
				If Me.Oo_oO00.0_. Is Nothing Then
					GoTo IL_1BA
				End If
				IL_1A8:
				num2 = 31
				oleDbCommand.Transaction = Me.Oo_oO00.0_.
				GoTo IL_1F3
				IL_1BA:
				num2 = 33
				If Me.AsyncExecute OrElse Not OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
					GoTo IL_1F3
				End If
				IL_1D8:
				num2 = 34
				oleDbCommand.Transaction = OO_00oOO.Connections.Oo___.ooooO00.(oleDbConnection)
				IL_1F3:
				num2 = 35
				If Not Me.StoredProcedure Then
					GoTo IL_20B
				End If
				IL_1FE:
				num2 = 36
				oleDbCommand.CommandType = CommandType.StoredProcedure
				GoTo IL_216
				IL_20B:
				num2 = 38
				oleDbCommand.CommandType = CommandType.Text
				IL_216:
				num2 = 39
				If Me.Parameters.Count <= 0 Then
					GoTo IL_3CC
				End If
				IL_22A:
				num2 = 40
				Dim enumerator2 As Dictionary(Of String, Object).KeyCollection.Enumerator = Me.Parameters.Keys.GetEnumerator()
				While enumerator2.MoveNext()
					Dim text3 As String = enumerator2.Current
					IL_24D:
					num2 = 41
					Dim oleDbParameter As OleDbParameter
					If Not A_0 Then
						IL_253:
						num2 = 42
						oleDbParameter = oleDbCommand.Parameters.AddWithValue(text3, RuntimeHelpers.GetObjectValue(Me.Parameters(text3)))
					Else
						IL_27A:
						num2 = 44
						oleDbParameter = oleDbCommand.Parameters.Add(text3, Me.O_O_Oo00o_.00_.(RuntimeHelpers.GetObjectValue(Me.Parameters(text3))))
						IL_2A5:
						num2 = 45
						If TypeOf Me.Parameters(text3)Is String Then
							IL_2BC:
							num2 = 46
							oleDbParameter.Size = Me.Parameters(text3).ToString().Length
						End If
						IL_2DD:
						num2 = 47
						oleDbParameter.Value = RuntimeHelpers.GetObjectValue(Me.Parameters(text3))
					End If
					IL_2F9:
					num2 = 48
					If Me.Parameters.o0O___o_o_0o.o.(text3) Then
						IL_30B:
						num2 = 49
						oleDbParameter.Direction = ParameterDirection.InputOutput
						IL_316:
						num2 = 50
						If GetType(String) Is Me.Parameters(text3).[GetType]() Then
							IL_337:
							num2 = 51
							oleDbParameter.Size = Me.Parameters.oO_0o_.oOO0.(text3)
						End If
					End If
					IL_353:
					num2 = 52
					If Me.Parameters.oO_0o_.oOO0.(text3) Then
						IL_365:
						num2 = 53
						oleDbParameter.Direction = ParameterDirection.ReturnValue
						IL_370:
						num2 = 54
						If GetType(String) Is Me.Parameters(text3).[GetType]() Then
							IL_391:
							num2 = 55
							oleDbParameter.Size = Me.Parameters.oO_0o_.oOO0.(text3)
						End If
					End If
					IL_3AD:
					num2 = 56
				End While
				IL_3BC:
				num2 = 57
				CType(enumerator2, IDisposable).Dispose()
				IL_3CC:
				num2 = 58
				result = oleDbCommand
				IL_3D2:
				GoTo IL_510
				IL_3D7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_4D1:
				GoTo IL_505
				IL_4D3:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4E3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4D3
			End Try
			IL_505:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_510:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x17000735 RID: 1845
		' (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000D2254 File Offset: 0x000D0454
		' (set) Token: 0x06001FCA RID: 8138 RVA: 0x000D225C File Offset: 0x000D045C
		Public Property CommandTimeOut As Integer
			Get
				Return Me.OO__00.__.
			End Get
			Set(value As Integer)
				Me.OO__00.__. = value
			End Set
		End Property

		' Token: 0x06001FCB RID: 8139 RVA: 0x000D2268 File Offset: 0x000D0468
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbCommand)
			Try
				For Each obj As Object In A_0.Parameters
					Dim oleDbParameter As OleDbParameter = CType(obj, OleDbParameter)
					If((oleDbParameter.Direction = ParameterDirection.InputOutput Or oleDbParameter.Direction = ParameterDirection.Output) OrElse oleDbParameter.Direction = ParameterDirection.ReturnValue) AndAlso Me.Parameters.ContainsKey(oleDbParameter.ParameterName) Then
						Me.Parameters(oleDbParameter.ParameterName) = RuntimeHelpers.GetObjectValue(oleDbParameter.Value)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001FCC RID: 8140 RVA: 0x000D230C File Offset: 0x000D050C
		Private Sub <<EMPTY_NAME>>()
			If Me.Parameters.Count > 0 AndAlso Me.Oo_oO00.0_. IsNot Nothing Then
				Try
					For Each text As String In Me.Parameters.Keys
						Dim jobject As JObject = New JObject()
						jobject("Name") = text
						jobject("Value") = Me.Parameters(text).ToString()
						jobject("Type") = CInt(Information.VarType(RuntimeHelpers.GetObjectValue(Me.Parameters(text))))
						If Me.Parameters.oO_0o_.oOO0.(text) Then
							jobject("Return") = Me.Parameters.o0O___o_o_0o.o.(text)
						End If
						If Me.Parameters.o0O___o_o_0o.o.(text) Then
							jobject("Output") = Me.Parameters.oO_0o_.oOO0.(text)
						End If
						Me.Oo_oO00.0_..FormData.Add("@{" + text + "}", HttpFunctions.CompressJson(jobject))
					Next
				Finally
					Dim enumerator As Dictionary(Of String, Object).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x06001FCD RID: 8141 RVA: 0x000D2470 File Offset: 0x000D0670
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable)
		End Sub

		' Token: 0x06001FCE RID: 8142 RVA: 0x000D2474 File Offset: 0x000D0674
		Private Function <<EMPTY_NAME>>(A_0 As Object) As OleDbType
			Dim type As Type = A_0.[GetType]()
			Dim result As OleDbType
			If type Is GetType(String) Then
				result = OleDbType.VarWChar
			ElseIf type Is GetType(Char) Then
				result = OleDbType.VarWChar
			ElseIf type Is GetType(DateTime) Then
				result = OleDbType.[Date]
			ElseIf type Is GetType(Decimal) Then
				result = OleDbType.Numeric
			ElseIf type Is GetType(Double) Then
				result = OleDbType.[Double]
			ElseIf type Is GetType(Single) Then
				result = OleDbType.[Single]
			ElseIf type Is GetType(Long) Then
				result = OleDbType.[Integer]
			ElseIf type Is GetType(Integer) Then
				result = OleDbType.[Integer]
			ElseIf type Is GetType(Short) Then
				result = OleDbType.SmallInt
			ElseIf type Is GetType(Byte) Then
				result = OleDbType.TinyInt
			ElseIf type Is GetType(Byte()) Then
				result = OleDbType.Binary
			ElseIf type Is GetType(Boolean) Then
				result = OleDbType.[Boolean]
			End If
			Return result
		End Function

		' Token: 0x04000D2E RID: 3374
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D2F RID: 3375
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D30 RID: 3376
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D31 RID: 3377
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D32 RID: 3378
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D33 RID: 3379
		Private <<EMPTY_NAME>> As oooOo_0oo

		' Token: 0x04000D34 RID: 3380
		Private <<EMPTY_NAME>> As HttpClient

		' Token: 0x04000D35 RID: 3381
		Private <<EMPTY_NAME>> As OleDbTransaction

		' Token: 0x04000D36 RID: 3382
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000D37 RID: 3383
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
