Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000278 RID: 632
	Friend Class o_oo0
		' Token: 0x06001E4E RID: 7758 RVA: 0x000C0F14 File Offset: 0x000BF114
		Friend Sub New(A_0 As OleDbConnection, A_1 As Boolean, A_2 As Boolean)
			Me.oo.oo0o0. = New CatalogClass()
			Me.oo.oo0o0. = New ConnectionClass()
			Me.oo.oo0o0. = A_1
			Me.o0o0.0O0o00O00. = A_2
			Me.oo.oo0o0. = A_0
			Me.oo.oo0o0..ConnectionString = Me.oo.oo0o0..ConnectionString
			Me.oo.oo0o0. = New oOo_(Me)
			Me.oo.oo0o0. = New DataSet()
			Me.oo__._. = New DataTable()
			Me.o0o0.0O0o00O00. = New DataTable()
			Me.oo__._..TableName = "tblTables"
			Me.o0o0.0O0o00O00..TableName = "tblColumns"
			Dim dataTable As DataTable = Me.oo__._.
			dataTable.Columns.Add("TableName", GetType(String))
			dataTable.Columns.Add("TableCaption", GetType(String))
			Dim dataTable2 As DataTable = Me.o0o0.0O0o00O00.
			dataTable2.Columns.Add("TableName", GetType(String))
			dataTable2.Columns.Add("ColumnName", GetType(String))
			dataTable2.Columns.Add("DataType", GetType(ColumnDataTypeEnum))
			dataTable2.Columns.Add("MaxLength", GetType(Integer))
			dataTable2.Columns.Add("Caption", GetType(String))
			Me.oo.oo0o0..Tables.Add(Me.o0o0.0O0o00O00.)
			Me.oo.oo0o0..Tables.Add(Me.oo__._.)
			Me.oo.oo0o0..Relations.Add("Re1", Me.oo__._..Columns("TableName"), Me.o0o0.0O0o00O00..Columns("TableName"))
			Me.ooo.0.()
			If A_2 Then
				Me.oo.oo0o0. = "~TMPCLP"
			End If
		End Sub

		' Token: 0x06001E4F RID: 7759 RVA: 0x000C1100 File Offset: 0x000BF300
		Friend Function <<EMPTY_NAME>>() As oOo_
			Return Me.oo.oo0o0.
		End Function

		' Token: 0x06001E50 RID: 7760 RVA: 0x000C1108 File Offset: 0x000BF308
		Friend Function <<EMPTY_NAME>>() As Catalog
			Return Me.oo.oo0o0.
		End Function

		' Token: 0x06001E51 RID: 7761 RVA: 0x000C1110 File Offset: 0x000BF310
		Friend Function <<EMPTY_NAME>>() As Connection
			Return Me.oo.oo0o0.
		End Function

		' Token: 0x06001E52 RID: 7762 RVA: 0x000C1118 File Offset: 0x000BF318
		Friend Sub <<EMPTY_NAME>>()
			Try
				Me.oo.oo0o0..Open("", "", "", -1)
				Me.oo.oo0o0..ActiveConnection = Me.oo.oo0o0.
				Me.o0o0.0O0o00O00..Clear()
				Me.oo__._..Rows.Clear()
				Dim list As List(Of String) = New List(Of String)()
				Try
					For Each obj As Object In Me.oo.oo0o0..Tables
						Dim table As Table = CType(obj, Table)
						If list.Contains(table.Name) Then
							list.Remove(table.Name)
						Else
							list.Add(table.Name)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each obj2 As Object In Me.oo.oo0o0..Tables
						Dim table2 As Table = CType(obj2, Table)
						If list.Contains(table2.Name) Then
							Dim text As String = table2.Name
							If Operators.CompareString(table2.Type, "TABLE", True) = 0 Then
								If Me.o0o0.0O0o00O00. Then
									If o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) OrElse Not text.StartsWith("~TMPCLP") Then
										Continue For
									End If
									text = text.Substring(7)
								End If
								Me.oo__._..Rows.Add(New Object() { text })
								Try
									For Each obj3 As Object In table2.Columns
										Dim column As Column = CType(obj3, Column)
										If Not o_O_o_oOoo__.oO.O_..Contains(column.Name) Then
											Me.o0o0.0O0o00O00..Rows.Add(New Object() { text, column.Name, column.Type, column.DefinedSize })
										End If
									Next
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Me.oo__._..AcceptChanges()
				Me.o0o0.0O0o00O00..AcceptChanges()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.oo.oo0o0..Close()
			End Try
		End Sub

		' Token: 0x06001E53 RID: 7763 RVA: 0x000C13F0 File Offset: 0x000BF5F0
		Friend Function <<EMPTY_NAME>>(Optional A_0 As Boolean = True, Optional A_1 As Boolean = False) As Integer
			If A_0 Then
				OO_00oOO.DataTables.Save()
			End If
			Me.oo.oo0o0..Open("", "", "", -1)
			Me.oo.oo0o0..ActiveConnection = Me.oo.oo0o0.
			Dim num2 As Integer
			For Each dataRow As DataRow In Me.oo__._..[Select]("", "", DataViewRowState.Added)
				Dim text As String = Conversions.ToString(dataRow("TableName"))
				Dim text2 As String = dataRow("TableCaption").ToString()
				Dim table As Table = New TableClass()
				table.ParentCatalog = Me.oo.oo0o0.
				Dim index As Index = New IndexClass()
				table.Name = Me.oo.oo0o0. + text
				table.Columns.Append("_Identify", 3, 0)
				table.Columns.Append("_Locked", 11, 0)
				table.Columns.Append("_SortKey", 131, 0)
				Dim column As Column = table.Columns("_SortKey")
				column.Precision = 28
				column.NumericScale = 14
				column.Attributes = 2
				If Not Me.o0o0.0O0o00O00. Then
					table.Columns("_Identify").Properties("AutoIncrement").Value = True
				End If
				If Me.oo.oo0o0. Then
					table.Columns("_Locked").Attributes = 2
				End If
				If Me.oo.oo0o0. Then
					index.Name = "PrimaryKey_" + text
				Else
					index.Name = "PrimaryKey"
				End If
				index.Columns.Append("_Identify", 202, 0)
				index.PrimaryKey = True
				index.Unique = True
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
				Me.oo.oo0o0..Tables.Append(table)
				Dim num As Integer = 1
				Do
					If Me.o0o0.0O0o00O00. Then
						Dim connection As _Connection = Me.oo.oo0o0.
						Dim text3 As String = String.Concat(New String() { "Insert into [", table.Name, "] ([_Identify],[_SortKey])  values(", Conversions.ToString(num), ",", Conversions.ToString(num), ")" })
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection.Execute(text3, objectValue, -1)
					Else
						Dim connection2 As _Connection = Me.oo.oo0o0.
						Dim text4 As String = String.Concat(New String() { "Insert into [", table.Name, "] ([_SortKey])  values(", Conversions.ToString(num), ")" })
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection2.Execute(text4, objectValue, -1)
					End If
					num += 1
				Loop While num <= 10
				If Me.o0o0.0O0o00O00. Then
					Dim connection3 As _Connection = Me.oo.oo0o0.
					Dim text5 As String = String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table]  = '", table.Name, "'" })
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					connection3.Execute(text5, objectValue, -1)
					Dim connection4 As _Connection = Me.oo.oo0o0.
					Dim text6 As String = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", table.Name, "', 11)" })
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
					connection4.Execute(text6, objectValue, -1)
				End If
				If Operators.CompareString(text2, "", True) > 0 Then
					Dim connection5 As _Connection = Me.oo.oo0o0.
					Dim text7 As String = String.Concat(New String() { "Delete * From [", ooO0__OO.O0O.0o0.(), "] Where [Table]  = '", text, "'" })
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					connection5.Execute(text7, objectValue, -1)
					Dim connection6 As _Connection = Me.oo.oo0o0.
					Dim text8 As String = String.Concat(New String() { "Insert into [", ooO0__OO.O0O.0o0.(), "] ([Table],[Column],[Code],[Config]) Values('", text, "','', '','Caption" & vbVerticalTab, text2, "')" })
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
					connection6.Execute(text8, objectValue, -1)
				End If
				num2 += 1
			Next
			If Not Me.oo.oo0o0. Then
				Try
					For Each obj As Object In Me.oo__._..Rows
						Dim dataRow2 As DataRow = CType(obj, DataRow)
						If Not(dataRow2.RowState = DataRowState.Added Or dataRow2.RowState = DataRowState.Deleted) AndAlso Operators.CompareString(Conversions.ToString(dataRow2("TableName", DataRowVersion.Original)), Conversions.ToString(dataRow2("TableName", DataRowVersion.Current)), True) <> 0 Then
							Me.oo.oo0o0..Tables(Me.oo.oo0o0. + Conversions.ToString(dataRow2("TableName", DataRowVersion.Original))).Name = Me.oo.oo0o0. + Conversions.ToString(dataRow2("TableName", DataRowVersion.Current))
							num2 += 1
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			For Each dataRow3 As DataRow In Me.o0o0.0O0o00O00..[Select]("", "", DataViewRowState.Added)
				Dim column2 As Column = New ColumnClass()
				Dim dataTypeEnum As DataTypeEnum = Conversions.ToInteger(dataRow3("DataType"))
				If dataTypeEnum = 7 AndAlso Me.oo.oo0o0. Then
					dataTypeEnum = 135
				End If
				If dataTypeEnum = 20 AndAlso Not Me.oo.oo0o0. Then
					dataTypeEnum = 3
				End If
				column2.Name = Conversions.ToString(dataRow3("ColumnName"))
				column2.Type = dataTypeEnum
				If column2.Type = 202 Then
					column2.DefinedSize = Conversions.ToInteger(dataRow3("MaxLength"))
				End If
				If column2.Type = 131 Then
					column2.Precision = 28
					column2.NumericScale = 4
				End If
				If column2.Type <> 11 OrElse Me.oo.oo0o0. Then
					column2.Attributes = 2
				End If
				Me.oo.oo0o0..Tables(Me.oo.oo0o0. + Conversions.ToString(dataRow3("TableName"))).Columns.Append(column2, 202, 0)
				If dataTypeEnum = 11 Then
					If Me.oo.oo0o0. Then
						Dim connection7 As _Connection = Me.oo.oo0o0.
						Dim text9 As String = String.Concat(New String() { "update [", Me.oo.oo0o0., Conversions.ToString(dataRow3("TableName")), "] Set [", column2.Name, "] = 0" })
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection7.Execute(text9, objectValue, -1)
					Else
						Dim connection8 As _Connection = Me.oo.oo0o0.
						Dim text10 As String = String.Concat(New String() { "update [", Me.oo.oo0o0., Conversions.ToString(dataRow3("TableName")), "] Set [", column2.Name, "] = False" })
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection8.Execute(text10, objectValue, -1)
					End If
				End If
				num2 += 1
			Next
			If Not Me.oo.oo0o0. Then
				Try
					For Each obj2 As Object In Me.o0o0.0O0o00O00..Rows
						Dim dataRow4 As DataRow = CType(obj2, DataRow)
						If dataRow4.RowState = DataRowState.Modified AndAlso Operators.CompareString(Conversions.ToString(dataRow4("ColumnName", DataRowVersion.Original)), Conversions.ToString(dataRow4("ColumnName", DataRowVersion.Current)), True) <> 0 Then
							Me.oo.oo0o0..Tables(Me.oo.oo0o0. + Conversions.ToString(dataRow4("TableName"))).Columns(Conversions.ToString(dataRow4("ColumnName", DataRowVersion.Original))).Name = Conversions.ToString(dataRow4("ColumnName", DataRowVersion.Current))
							num2 += 1
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			For Each dataRow5 As DataRow In Me.o0o0.0O0o00O00..[Select]("", "", DataViewRowState.Deleted)
				Me.oo.oo0o0..Tables(Me.oo.oo0o0. + Conversions.ToString(dataRow5("TableName", DataRowVersion.Original))).Columns.Delete(Conversions.ToString(dataRow5("ColumnName", DataRowVersion.Original)))
				num2 += 1
			Next
			For Each dataRow6 As DataRow In Me.oo__._..[Select]("", "", DataViewRowState.Deleted)
				Me.oo.oo0o0..Tables.Delete(Me.oo.oo0o0. + Conversions.ToString(dataRow6("TableName", DataRowVersion.Original)))
				num2 += 1
			Next
			Me.oo.oo0o0..Close()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			oleDbCommand.Connection = Me.oo.oo0o0.
			Me.oo.oo0o0..Open()
			Try
				Try
					For Each obj3 As Object In Me.o0o0.0O0o00O00..Rows
						Dim dataRow7 As DataRow = CType(obj3, DataRow)
						If dataRow7.RowState = DataRowState.Modified Then
							If Conversions.ToInteger(dataRow7("DataType", DataRowVersion.Original)) <> Conversions.ToInteger(dataRow7("DataType", DataRowVersion.Current)) Then
								oleDbCommand.CommandText = String.Concat(New String() { "Alter Table [", Me.oo.oo0o0., Conversions.ToString(dataRow7("TableName")), "] ALTER COLUMN [", Conversions.ToString(dataRow7("ColumnName")), "] " })
								If Me.oo.oo0o0. Then
									Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow7("DataType", DataRowVersion.Current)), ColumnDataTypeEnum)
									If columnDataTypeEnum <= ColumnDataTypeEnum.[Long] Then
										Select Case columnDataTypeEnum
											Case ColumnDataTypeEnum.[Short]
												oleDbCommand.CommandText += " smallint"
											Case ColumnDataTypeEnum.[Integer]
												oleDbCommand.CommandText += " int"
											Case ColumnDataTypeEnum.[Single]
												oleDbCommand.CommandText += " real"
											Case ColumnDataTypeEnum.[Double]
												oleDbCommand.CommandText += " float"
											Case CType(6, ColumnDataTypeEnum), CType(8, ColumnDataTypeEnum), CType(9, ColumnDataTypeEnum), CType(10, ColumnDataTypeEnum)
											Case ColumnDataTypeEnum.DateTime
												oleDbCommand.CommandText += " datetime"
											Case ColumnDataTypeEnum.[Boolean]
												oleDbCommand.CommandText += " bit"
											Case Else
												If columnDataTypeEnum <> ColumnDataTypeEnum.[Byte] Then
													If columnDataTypeEnum = ColumnDataTypeEnum.[Long] Then
														oleDbCommand.CommandText += " bigint"
													End If
												Else
													oleDbCommand.CommandText += " tinyint"
												End If
										End Select
									ElseIf columnDataTypeEnum <> ColumnDataTypeEnum.[Decimal] Then
										If columnDataTypeEnum <> ColumnDataTypeEnum.[String] Then
											If columnDataTypeEnum = ColumnDataTypeEnum.Text Then
												oleDbCommand.CommandText += " ntext"
											End If
										Else
											oleDbCommand.CommandText = oleDbCommand.CommandText + " nvarchar(" + Conversions.ToString(Conversions.ToInteger(dataRow7("Maxlength"))) + ")"
										End If
									Else
										Dim value As Integer = 4
										Try
											For Each dataTable As DataTable In OO_00oOO.DataTables
												If dataTable.frd_Connection Is Me.oo.oo0o0. AndAlso Operators.CompareString(dataTable.o._OOO0oOo0__., Conversions.ToString(dataRow7("TableName")), True) = 0 AndAlso dataTable.DataCols.Contains(Conversions.ToString(dataRow7("ColumnName"))) Then
													value = dataTable.DataCols(Conversions.ToString(dataRow7("ColumnName"))).Decimals
													Exit For
												End If
											Next
										Finally
											Dim enumerator4 As IEnumerator(Of DataTable)
											If enumerator4 IsNot Nothing Then
												enumerator4.Dispose()
											End If
										End Try
										oleDbCommand.CommandText = oleDbCommand.CommandText + " numeric(28," + Conversions.ToString(value) + ")"
									End If
								Else
									Dim columnDataTypeEnum2 As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow7("DataType", DataRowVersion.Current)), ColumnDataTypeEnum)
									If columnDataTypeEnum2 <= ColumnDataTypeEnum.[Long] Then
										Select Case columnDataTypeEnum2
											Case ColumnDataTypeEnum.[Short]
												oleDbCommand.CommandText += " SMALLINT"
											Case ColumnDataTypeEnum.[Integer]
												oleDbCommand.CommandText += " INTEGER"
											Case ColumnDataTypeEnum.[Single]
												oleDbCommand.CommandText += " SINGLE"
											Case ColumnDataTypeEnum.[Double]
												oleDbCommand.CommandText += " DOUBLE"
											Case CType(6, ColumnDataTypeEnum), CType(8, ColumnDataTypeEnum), CType(9, ColumnDataTypeEnum), CType(10, ColumnDataTypeEnum)
											Case ColumnDataTypeEnum.DateTime
												oleDbCommand.CommandText += " DATETIME"
											Case ColumnDataTypeEnum.[Boolean]
												oleDbCommand.CommandText += " BIT"
											Case Else
												If columnDataTypeEnum2 <> ColumnDataTypeEnum.[Byte] Then
													If columnDataTypeEnum2 = ColumnDataTypeEnum.[Long] Then
														Continue For
													End If
												Else
													oleDbCommand.CommandText += " TINYINT"
												End If
										End Select
									ElseIf columnDataTypeEnum2 <> ColumnDataTypeEnum.[Decimal] Then
										If columnDataTypeEnum2 <> ColumnDataTypeEnum.[String] Then
											If columnDataTypeEnum2 = ColumnDataTypeEnum.Text Then
												oleDbCommand.CommandText += " TEXT"
											End If
										Else
											oleDbCommand.CommandText = oleDbCommand.CommandText + " TEXT(" + Conversions.ToString(Conversions.ToInteger(dataRow7("Maxlength"))) + ")"
										End If
									Else
										Dim value2 As Integer = 4
										Try
											For Each dataTable2 As DataTable In OO_00oOO.DataTables
												If dataTable2.frd_Connection Is Me.oo.oo0o0. AndAlso ((Not Me.o0o0.0O0o00O00. AndAlso Operators.CompareString(dataTable2.o._OOO0oOo0__., Conversions.ToString(dataRow7("TableName")), True) = 0) OrElse (Me.o0o0.0O0o00O00. AndAlso Operators.CompareString(dataTable2.Name, Conversions.ToString(dataRow7("TableName")), True) = 0)) AndAlso dataTable2.DataCols.Contains(Conversions.ToString(dataRow7("ColumnName"))) Then
													value2 = dataTable2.DataCols(Conversions.ToString(dataRow7("ColumnName"))).Decimals
													Exit For
												End If
											Next
										Finally
											Dim enumerator5 As IEnumerator(Of DataTable)
											If enumerator5 IsNot Nothing Then
												enumerator5.Dispose()
											End If
										End Try
										oleDbCommand.CommandText = oleDbCommand.CommandText + " DECIMAL(28," + Conversions.ToString(value2) + ")"
									End If
								End If
								Try
									oleDbCommand.ExecuteNonQuery()
									num2 += 1
									Continue For
								Catch a_ As Exception
									ooO.oOo0Oo.o.(a_, "")
									MessageBox.Show("修改[" + Conversions.ToString(dataRow7("ColumnName")) + "]的列类型失败，现有数据可能无法转换为新的类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Continue For
								End Try
							End If
							If Conversions.ToInteger(dataRow7("Maxlength", DataRowVersion.Current)) <> Conversions.ToInteger(dataRow7("Maxlength", DataRowVersion.Original)) AndAlso Conversions.ToInteger(dataRow7("DataType")) = 202 Then
								If Me.oo.oo0o0. Then
									oleDbCommand.CommandText = String.Concat(New String() { "Alter Table [", Me.oo.oo0o0., Conversions.ToString(dataRow7("TableName")), "] ALTER COLUMN [", Conversions.ToString(dataRow7("ColumnName")), "] nvarchar(", Conversions.ToString(Conversions.ToInteger(dataRow7("Maxlength"))), ")" })
								Else
									oleDbCommand.CommandText = String.Concat(New String() { "Alter Table [", Me.oo.oo0o0., Conversions.ToString(dataRow7("TableName")), "] ALTER COLUMN [", Conversions.ToString(dataRow7("ColumnName")), "] Text(", Conversions.ToString(Conversions.ToInteger(dataRow7("Maxlength"))), ")" })
								End If
								Try
									oleDbCommand.ExecuteNonQuery()
									num2 += 1
								Catch a_2 As Exception
									ooO.oOo0Oo.o.(a_2, "")
									MessageBox.Show("修改[" + Conversions.ToString(dataRow7("ColumnName")) + "]的长度失败，所设置的大小可能无法容纳现有数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End Try
							End If
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
			Catch a_3 As Exception
				ooO.oOo0Oo.o.(a_3, "")
			Finally
				If Me.oo.oo0o0..State = ConnectionState.Open Then
					Me.oo.oo0o0..Close()
				End If
			End Try
			Me.o0_oo0._.(A_1)
			Me.o0o0.0O0o00O00..Rows.Clear()
			Me.oo__._..Rows.Clear()
			Me.ooo.0.()
			If O_O0OO.OoO.0OO__0ooo.() IsNot Nothing AndAlso O_O0OO.OoO.0OO__0ooo.().Tables.Contains(ooO0__OO.O0O.0o0.()) Then
				o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()))
			End If
			Return num2
		End Function

		' Token: 0x06001E54 RID: 7764 RVA: 0x000C26B4 File Offset: 0x000C08B4
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim oleDbConnection As OleDbConnection
			If Not A_0 Then
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
			Else
				oleDbConnection = Me.oo.oo0o0.
			End If
			If O_O0OO.OoO.0OO__0ooo.() IsNot Nothing Then
				oleDbConnection.Open()
				Try
					For Each obj As Object In Me.o0o0.0O0o00O00..Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If dataRow.RowState <> DataRowState.Deleted AndAlso Not dataRow.IsNull("Caption") AndAlso Operators.CompareString(Conversions.ToString(dataRow("Caption")), "", True) > 0 Then
							Dim text As String = "Caption" & vbVerticalTab + Conversions.ToString(dataRow("Caption"))
							New OleDbCommand() With { .Connection = oleDbConnection, .CommandText = String.Concat(New String() { "Insert Into [", ooO0__OO.O0O.0o0.(), "] ([Table],[Column],[Config]) Values('", Conversions.ToString(dataRow("TableName")), "','", Conversions.ToString(dataRow("ColumnName")), "','", text, "')" }) }.ExecuteNonQuery()
							dataRow("Caption") = DBNull.Value
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				oleDbConnection.Close()
			End If
		End Sub

		' Token: 0x06001E55 RID: 7765 RVA: 0x000C2834 File Offset: 0x000C0A34
		Friend Sub <<EMPTY_NAME>>()
			Me.o0o0.0O0o00O00..Rows.Clear()
			Me.oo__._..Rows.Clear()
			Me.ooo.0.()
		End Sub

		' Token: 0x04000CAB RID: 3243
		Private <<EMPTY_NAME>> As oOo_

		' Token: 0x04000CAC RID: 3244
		Private <<EMPTY_NAME>> As Catalog

		' Token: 0x04000CAD RID: 3245
		Private <<EMPTY_NAME>> As Connection

		' Token: 0x04000CAE RID: 3246
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x04000CAF RID: 3247
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CB0 RID: 3248
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CB1 RID: 3249
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CB2 RID: 3250
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000CB3 RID: 3251
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000CB4 RID: 3252
		Private <<EMPTY_NAME>> As OleDbConnection
	End Class
End Namespace
