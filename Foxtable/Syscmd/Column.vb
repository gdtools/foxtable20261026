Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x0200052A RID: 1322
	Public NotInheritable Module Column
		' Token: 0x0600572E RID: 22318 RVA: 0x0022494C File Offset: 0x00222B4C
		Private Function <<EMPTY_NAME>>(A_0 As Boolean) As Boolean
			Dim result As Boolean
			If OO_00oOO.CurrentTable Is Nothing Then
				result = False
			Else
				Dim dataTable As DataTable = OO_00oOO.DataTables(OO_00oOO.CurrentTable.DataTable.Name)
				If(dataTable.frd_Connection IsNot Nothing AndAlso o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection)) And Not A_0 Then
					MessageBox.Show("不能修改来自Oracle的数据表的结构！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				ElseIf((dataTable.frd_IsOuterQuery OrElse dataTable.frd_IsInnerQuery) And Not A_0 And Not dataTable.AddByCode) OrElse dataTable.AddByCode Then
					MessageBox.Show("对于查询表以及通过代码生成的临时表，不能直接通过菜单修改其结构。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				ElseIf(Operators.CompareString(dataTable.ConnectionName, "", True) > 0 AndAlso O_O0OO.OoO__.0oO0oo.().ContainsKey(dataTable.ConnectionName)) And Not A_0 Then
					MessageBox.Show("不能修改来自Web数据源的表的结构!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				ElseIf Operators.CompareString(dataTable.o._OOO0oOo0__., "", True) > 0 AndAlso dataTable.o._OOO0oOo0__..IndexOf("].[") > 0 AndAlso Not A_0 Then
					MessageBox.Show("不能修改非默认架构表的结构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				Else
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x0600572F RID: 22319 RVA: 0x00224A87 File Offset: 0x00222C87
		Public Sub InsertDataColumn()
		End Sub

		' Token: 0x06005730 RID: 22320 RVA: 0x00224A89 File Offset: 0x00222C89
		<oO0oooo("0026")>
		Public Sub AddDataColumn()
		End Sub

		' Token: 0x06005731 RID: 22321 RVA: 0x00224A8B File Offset: 0x00222C8B
		<oO0oooo("0025")>
		Public Sub InsertExpressionColumn()
		End Sub

		' Token: 0x06005732 RID: 22322 RVA: 0x00224A8D File Offset: 0x00222C8D
		<oO0oooo("0025")>
		Public Sub AddExpressionColumn()
		End Sub

		' Token: 0x06005733 RID: 22323 RVA: 0x00224A8F File Offset: 0x00222C8F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub EditGetValueCode()
		End Sub

		' Token: 0x06005734 RID: 22324 RVA: 0x00224A94 File Offset: 0x00222C94
		<oO0oooo("0031")>
		Public Sub EditExpression()
			If ooO.oo__.O000_o_O.() AndAlso Column.oo0Oo0Oo.OO.(True) AndAlso OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.() Then
				Dim a_ As String = ""
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				If o_oOooO_O.Cols(o_oOooO_O.Col).DataIndex <> -1 Then
					Dim dataColumn As DataColumn = OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Columns(o_oOooO_O.Cols(o_oOooO_O.Col).Name)
					Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataColumn.Table.TableName, dataColumn.ColumnName })
					If dataRow IsNot Nothing Then
						a_ = Conversions.ToString(dataRow("Expression"))
					End If
					If OO_00oOO.DataTables(dataColumn.Table.TableName).DataCols(dataColumn.ColumnName).IsTemporary Then
						If New O\u3002o\u3002\u3002\u3000(O_O0OO.OOOo.oo_OOOO_0.().Tables(dataColumn.Table.TableName), dataColumn, a_, True).ShowDialog() = DialogResult.OK Then
							If dataRow IsNot Nothing Then
								dataRow("Expression") = dataColumn.Expression
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
							End If
							OO_00oOO.CurrentTable.foxGrid.Invalidate()
						End If
					ElseIf MessageBox.Show("只有表达式列才能设置表达式，是否现在增加一个表达式列？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
						Column.AddExpressionColumn()
					End If
				End If
			End If
		End Sub

		' Token: 0x06005735 RID: 22325 RVA: 0x00224C29 File Offset: 0x00222E29
		<oO0oooo("0030")>
		Public Sub Delete()
		End Sub

		' Token: 0x06005736 RID: 22326 RVA: 0x00224C2B File Offset: 0x00222E2B
		<oO0oooo("0036")>
		Private Sub <<EMPTY_NAME>>()
		End Sub

		' Token: 0x06005737 RID: 22327 RVA: 0x00224C2D File Offset: 0x00222E2D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ChangeType()
			Column.oo0Oo0Oo.OO.()
		End Sub

		' Token: 0x06005738 RID: 22328 RVA: 0x00224C34 File Offset: 0x00222E34
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataCol, A_2 As ColumnDataTypeEnum, A_3 As ColumnDataTypeEnum, A_4 As Integer, A_5 As Integer)
			Dim text As String = ""
			Dim name As String = A_1.Name
			Dim flag As Boolean
			If A_1.IsTemporary Then
				flag = True
				text = A_1.Expression
			Else
				A_0.Save()
			End If
			If flag Then
				If Operators.CompareString(text, "", True) > 0 Then
					Try
						A_0.BaseTable.Columns.Add("_SysTemporaryColumnForTest", Oo00.OO.0O0o.(A_3), text)
					Catch ex As Exception
						Dim flag2 As Boolean = True
						Return
					Finally
						If A_0.BaseTable.Columns.Contains("_SysTemporaryColumnForTest") Then
							A_0.BaseTable.Columns.Remove("_SysTemporaryColumnForTest")
						End If
						Try
							For Each table As Table In OO_00oOO.Tables
								If table.foxGrid.Cols.Contains("_SysTemporaryColumnForTest") Then
									table.foxGrid.Cols.Remove("_SysTemporaryColumnForTest")
								End If
								table.O.__O0o0.(True, False)
							Next
						Finally
							Dim enumerator As IEnumerator(Of Table)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						Dim flag2 As Boolean
						If flag2 Then
							MessageBox.Show("更改类类型失败，原因：新的数据类型和原计算公式不匹配！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					End Try
				End If
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.())
				Try
					Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { A_0.Name, A_1.Name })
					If dataRow IsNot Nothing Then
						dataRow("DataType") = A_3
						If A_3 = ColumnDataTypeEnum.[String] Then
							dataRow("MaxLength") = A_5
						End If
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
					End If
					If A_3 = ColumnDataTypeEnum.[String] AndAlso A_2 = ColumnDataTypeEnum.[String] AndAlso A_1.BaseColumn.MaxLength <= 255 Then
						A_1.BaseColumn.MaxLength = A_5
						Return
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					Return
				End Try
			ElseIf A_2 <> A_3 OrElse A_4 <> A_5 Then
				Try
					Dim oleDbConnection As OleDbConnection = A_0.frd_Connection
					Dim o_oo As o_oo0 = New o_oo0(oleDbConnection, o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection), oleDbConnection Is O_O0OO.OoO.0OO__0ooo.())
					Dim a_2 As String
					If oleDbConnection Is O_O0OO.OoO.0OO__0ooo.() Then
						a_2 = A_0.Name
					Else
						a_2 = A_0.o._OOO0oOo0__.
					End If
					o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_1.Name).O_o0.Oo00o0.(A_3)
					If A_3 = ColumnDataTypeEnum.[String] Then
						o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_1.Name).O_o0.Oo00o0.(A_5)
					End If
					If o_oo.o0_oo0._.(True, False) = 0 Then
						Return
					End If
					If A_3 = ColumnDataTypeEnum.[String] AndAlso A_2 = ColumnDataTypeEnum.[String] AndAlso A_1.BaseColumn.MaxLength <= 255 Then
						A_1.BaseColumn.MaxLength = A_5
						Try
							For Each table2 As Table In OO_00oOO.Tables
								If table2.DataTable Is A_0 AndAlso table2.Cols.Contains(A_1.Name) Then
									table2.Cols(A_1.Name).o0.O.()
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Table)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						Return
					End If
					A_0.O_00_._.()
				Catch a_3 As Exception
					ooO.oOo0Oo.o.(a_3, "")
					Return
				End Try
			End If
			Dim dictionary As Dictionary(Of DataColumn, String) = New Dictionary(Of DataColumn, String)()
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Tables
					Dim dataTable2 As DataTable = CType(obj, DataTable)
					Try
						For Each obj2 As Object In dataTable2.Columns
							Dim dataColumn As DataColumn = CType(obj2, DataColumn)
							If Operators.CompareString(dataColumn.Expression, "", True) > 0 AndAlso dataColumn IsNot A_1.BaseColumn Then
								dictionary.Add(dataColumn, dataColumn.Expression)
								dataColumn.Expression = ""
							End If
						Next
					Finally
						Dim enumerator4 As IEnumerator
						If TypeOf enumerator4 Is IDisposable Then
							TryCast(enumerator4, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator3 As IEnumerator
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
			End Try
			Try
				Dim type As Type = Oo00.OO.0O0o.(A_3)
				A_1.BaseColumn.Unique = False
				Dim randString As String = ShareLibriay.GetRandString(8)
				A_0.OO_.OOo0o0. = randString
				If flag Then
					A_0.BaseTable.Columns.Add(randString, type)
					If A_3 = ColumnDataTypeEnum.[String] Then
						A_0.BaseTable.Columns(randString).MaxLength = A_5
					ElseIf A_3 = ColumnDataTypeEnum.Text Then
						A_0.BaseTable.Columns(randString).MaxLength = -1
					End If
					If Operators.CompareString(text, "", True) > 0 Then
						A_0.BaseTable.Columns(randString).Expression = text
					End If
					A_0.BaseTable.Columns.Remove(name)
					A_0.BaseTable.Columns(randString).ColumnName = name
				Else
					A_0.BaseTable.Columns.Add(randString, type)
					If A_3 = ColumnDataTypeEnum.[String] Then
						A_0.BaseTable.Columns(randString).MaxLength = A_5
					End If
					Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
					Try
						For Each table3 As Table In OO_00oOO.Tables
							If table3.View.o_o.O0ooOo.() Is A_0.BaseTable Then
								list.Add(New OoO_O00(table3))
							End If
						Next
					Finally
						Dim enumerator5 As IEnumerator(Of Table)
						If enumerator5 IsNot Nothing Then
							enumerator5.Dispose()
						End If
					End Try
					If type Is GetType(DateTime) AndAlso A_0.DataCols(name).IsNumeric Then
						Try
							For Each obj3 As Object In A_0.BaseTable.Rows
								Dim dataRow2 As DataRow = CType(obj3, DataRow)
								If Not dataRow2.IsNull(name) Then
									dataRow2(randString) = New DateTime(599264352000000000L).AddDays(Conversions.ToDouble(dataRow2(name)))
								End If
							Next
							GoTo IL_9BC
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					End If
					If A_0.DataCols(name).IsDate And type IsNot GetType(String) Then
						Try
							For Each obj4 As Object In A_0.BaseTable.Rows
								Dim dataRow3 As DataRow = CType(obj4, DataRow)
								If Not dataRow3.IsNull(name) Then
									dataRow3(randString) = (Conversions.ToDate(dataRow3(name)) - New DateTime(599264352000000000L)).TotalDays
								End If
							Next
							GoTo IL_9BC
						Finally
							Dim enumerator7 As IEnumerator
							If TypeOf enumerator7 Is IDisposable Then
								TryCast(enumerator7, IDisposable).Dispose()
							End If
						End Try
					End If
					If A_0.BaseTable.Columns(randString).DataType Is GetType(Boolean) Then
						Try
							For Each obj5 As Object In A_0.BaseTable.Rows
								Dim dataRow4 As DataRow = CType(obj5, DataRow)
								If dataRow4.IsNull(name) Then
									dataRow4(randString) = False
								Else
									dataRow4(randString) = Conversions.ToBoolean(dataRow4(name))
								End If
							Next
							GoTo IL_9BC
						Finally
							Dim enumerator8 As IEnumerator
							If TypeOf enumerator8 Is IDisposable Then
								TryCast(enumerator8, IDisposable).Dispose()
							End If
						End Try
					End If
					If A_0.BaseTable.Columns(name).DataType Is GetType(DateTime) Then
						Try
							For Each obj6 As Object In A_0.BaseTable.Rows
								Dim dataRow5 As DataRow = CType(obj6, DataRow)
								If Not dataRow5.IsNull(name) Then
									Dim dateTime As DateTime = Conversions.ToDate(dataRow5(name))
									Select Case A_0.DataCols(name).DateTimeFormat
										Case 0
											dataRow5(randString) = Strings.Format(dateTime, "yyyy-MM-dd")
										Case 1
											dataRow5(randString) = Strings.Format(dateTime, "HH:mm")
										Case 3
											dataRow5(randString) = Strings.Format(dateTime, "yyyy-MM-dd HH:mm")
										Case 4
											dataRow5(randString) = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss")
									End Select
								End If
							Next
							GoTo IL_9BC
						Finally
							Dim enumerator9 As IEnumerator
							If TypeOf enumerator9 Is IDisposable Then
								TryCast(enumerator9, IDisposable).Dispose()
							End If
						End Try
					End If
					If o_O_o_oOoo__.OO_.O.(type) Then
						Try
							For Each obj7 As Object In A_0.BaseTable.Rows
								Dim dataRow6 As DataRow = CType(obj7, DataRow)
								If Not dataRow6.IsNull(name) AndAlso Operators.CompareString(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataRow6(name))).Trim(), "", True) <> 0 AndAlso Not dataRow6.IsNull(name) Then
									dataRow6(randString) = Conversions.ToDecimal(dataRow6(name))
								End If
							Next
							GoTo IL_9BC
						Finally
							Dim enumerator10 As IEnumerator
							If TypeOf enumerator10 Is IDisposable Then
								TryCast(enumerator10, IDisposable).Dispose()
							End If
						End Try
					End If
					Try
						For Each obj8 As Object In A_0.BaseTable.Rows
							Dim dataRow7 As DataRow = CType(obj8, DataRow)
							dataRow7(randString) = RuntimeHelpers.GetObjectValue(dataRow7(name))
						Next
					Finally
						Dim enumerator11 As IEnumerator
						If TypeOf enumerator11 Is IDisposable Then
							TryCast(enumerator11, IDisposable).Dispose()
						End If
					End Try
					IL_9BC:
					A_0.BaseTable.AcceptChanges()
					A_0.BaseTable.Columns.Remove(name)
					A_0.BaseTable.Columns(randString).ColumnName = name
					Try
						For Each ooO_O As OoO_O00 In list
							ooO_O.O._00000.(Nothing)
						Next
					Finally
						Dim enumerator12 As List(Of OoO_O00).Enumerator
						CType(enumerator12, IDisposable).Dispose()
					End Try
				End If
				A_0.DataCols.O_0__o.o_0o.(name)
				A_1 = A_0.DataCols(name)
				If flag Then
					A_1.IsTemporary = True
				End If
				Try
					For Each dataColumn2 As DataColumn In dictionary.Keys
						dataColumn2.Expression = dictionary(dataColumn2)
					Next
				Finally
					Dim enumerator13 As Dictionary(Of DataColumn, String).KeyCollection.Enumerator
					CType(enumerator13, IDisposable).Dispose()
				End Try
				A_1.o_.Oo00_O_00_.()
				Try
					For Each table4 As Table In OO_00oOO.Tables
						If table4.foxGrid.FindForm() IsNot Nothing Then
							table4.O.__O0o0.(True, False)
						End If
					Next
				Finally
					Dim enumerator14 As IEnumerator(Of Table)
					If enumerator14 IsNot Nothing Then
						enumerator14.Dispose()
					End If
				End Try
			Catch a_4 As Exception
				ooO.oOo0Oo.o.(a_4, "")
			Finally
				OO_00oOO.MainTable.foxGrid.Refresh()
				If A_1 IsNot Nothing Then
					A_1.oO.O. = True
				End If
			End Try
		End Sub

		' Token: 0x06005739 RID: 22329 RVA: 0x00225930 File Offset: 0x00223B30
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Modify()
			Column.oo0Oo0Oo.OO.()
		End Sub

		' Token: 0x0600573A RID: 22330 RVA: 0x00225937 File Offset: 0x00223B37
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Rename()
			Column.Modify()
		End Sub

		' Token: 0x0600573B RID: 22331 RVA: 0x00225940 File Offset: 0x00223B40
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataCol, A_2 As String, A_3 As String, A_4 As String, A_5 As String)
			Dim flag As Boolean
			If A_1.IsTemporary Then
				flag = True
			End If
			If Operators.CompareString(A_5, A_4, True) <> 0 Then
				A_1.Setting.Caption = A_5
				A_1.O.O_OO.(True)
				If Operators.CompareString(A_3, A_2, True) = 0 Then
					Try
						For Each table As Table In OO_00oOO.Tables
							If Not table.O.__O0o0.(True, False) AndAlso table.DataTable Is A_0 Then
								table.O0oO0oo_O_o.Oo.(True)
							End If
						Next
						Return
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End If
			If Operators.CompareString(A_3, A_2, True) <> 0 AndAlso A_0.DataCols.O_0__o.o_0o.(A_2, A_3) Then
				If flag Then
					Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { A_0.Name, A_2 })
					If dataRow IsNot Nothing Then
						dataRow("Column") = A_3
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
					End If
				Else
					Dim oleDbConnection As OleDbConnection = A_0.frd_Connection
					If o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
						Dim oleDbCommand As OleDbCommand = New OleDbCommand(String.Concat(New String() { "exec sp_rename '", A_0.o._OOO0oOo0__., ".", A_2, "','", A_3, "','column'" }), oleDbConnection)
						Try
							oleDbConnection.Open()
							oleDbCommand.ExecuteScalar()
							GoTo IL_1E0
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "")
							Return
						Finally
							oleDbConnection.Close()
						End Try
					End If
					Dim o_oo As o_oo0 = New o_oo0(oleDbConnection, False, oleDbConnection Is O_O0OO.OoO.0OO__0ooo.())
					Dim a_2 As String
					If oleDbConnection Is O_O0OO.OoO.0OO__0ooo.() Then
						a_2 = A_0.Name
					Else
						a_2 = A_0.o._OOO0oOo0__.
					End If
					o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_2).Name = A_3
					If o_oo.o0_oo0._.(False, False) = 0 Then
						Return
					End If
					IL_1E0:
					A_0.O_00_._.()
				End If
				Try
					For Each table2 As Table In OO_00oOO.Tables
						If table2.DataTable Is A_0 Then
							table2.Cols.RenameColumn(A_2, A_3)
							table2.O.__O0o0.(A_2, A_3)
							table2._frdTableLayout.OOooOOo_.0_0_o.(A_2, A_3)
						End If
						table2.O.__O0o0.(True, False)
						table2.foxGrid.Refresh()
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				Try
					For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows
						Dim dataRow2 As DataRow = CType(obj, DataRow)
						If Operators.CompareString(Conversions.ToString(dataRow2("Table")), A_0.Name, True) = 0 AndAlso Not dataRow2.IsNull("Column") AndAlso Operators.CompareString(Conversions.ToString(dataRow2("Column")), A_2, True) = 0 Then
							dataRow2("Column") = A_3
							Exit For
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				Try
					For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows
						Dim dataRow3 As DataRow = CType(obj2, DataRow)
						If Operators.CompareString(Conversions.ToString(dataRow3("ParentTable")), A_0.Name, True) = 0 Then
							Dim text As String = vbTab + Conversions.ToString(dataRow3("ParentCols")) + vbTab
							text = text.Replace(vbTab + A_2 + vbTab, vbTab + A_3 + vbTab)
							text = text.Trim(vbTab.ToCharArray())
							If Operators.CompareString(text, Conversions.ToString(dataRow3("ParentCols")), True) <> 0 Then
								dataRow3("ParentCols") = text
							End If
						ElseIf Operators.CompareString(Conversions.ToString(dataRow3("ChildTable")), A_0.Name, True) = 0 Then
							Dim text2 As String = vbTab + Conversions.ToString(dataRow3("ChildCols")) + vbTab
							text2 = text2.Replace(vbTab + A_2 + vbTab, vbTab + A_3 + vbTab)
							text2 = text2.Trim(vbTab.ToCharArray())
							If Operators.CompareString(text2, Conversions.ToString(dataRow3("ChildCols")), True) <> 0 Then
								dataRow3("ChildCols") = text2
							End If
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator
					If TypeOf enumerator4 Is IDisposable Then
						TryCast(enumerator4, IDisposable).Dispose()
					End If
				End Try
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()), True)
				Try
					For Each obj3 As Object In O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0.Name).Columns
						Dim dataColumn As DataColumn = CType(obj3, DataColumn)
						If Operators.CompareString(dataColumn.Expression, "", True) > 0 AndAlso dataColumn.Expression.IndexOf(A_2, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
							Try
								Dim text3 As String = ShareLibriay.ReplaceFiledIgnoreCase(dataColumn.Expression, A_2, A_3)
								If Operators.CompareString(dataColumn.Expression, text3, True) <> 0 Then
									dataColumn.Expression = text3
									Dim dataRow4 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { A_0.Name, dataColumn.ColumnName })
									If dataRow4 IsNot Nothing Then
										dataRow4("Expression") = dataColumn.Expression
									End If
								End If
							Catch a_3 As Exception
								ooO.oOo0Oo.o.(a_3, "")
							End Try
						End If
					Next
				Finally
					Dim enumerator5 As IEnumerator
					If TypeOf enumerator5 Is IDisposable Then
						TryCast(enumerator5, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each obj4 As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
						Dim dataRelation As DataRelation = CType(obj4, DataRelation)
						If Operators.CompareString(dataRelation.ChildTable.TableName, A_0.Name, True) = 0 Then
							Dim text4 As String = "Child(" + dataRelation.RelationName + ")." + A_2
							Dim text5 As String = String.Concat(New String() { "Child([", dataRelation.RelationName, "]).[", A_2, "]" })
							Dim text6 As String = "Child." + A_2
							Dim text7 As String = "Child([" + dataRelation.RelationName + "])." + A_2
							Dim text8 As String = String.Concat(New String() { "Child(", dataRelation.RelationName, ").[", A_2, "]" })
							Dim text9 As String = "Child(" + dataRelation.RelationName + ")." + A_3
							Dim text10 As String = String.Concat(New String() { "Child([", dataRelation.RelationName, "]).[", A_3, "]" })
							Dim text11 As String = "Child." + A_3
							Dim text12 As String = "Child([" + dataRelation.RelationName + "])." + A_3
							Dim text13 As String = String.Concat(New String() { "Child(", dataRelation.RelationName, ").[", A_3, "]" })
							Try
								For Each obj5 As Object In dataRelation.ParentTable.Columns
									Dim dataColumn2 As DataColumn = CType(obj5, DataColumn)
									If Operators.CompareString(dataColumn2.Expression, "", True) > 0 Then
										Dim text14 As String = dataColumn2.Expression
										If text14.IndexOf(text4, StringComparison.CurrentCultureIgnoreCase) > 0 OrElse text14.IndexOf(text5, StringComparison.CurrentCultureIgnoreCase) > 0 OrElse text14.IndexOf(text6, StringComparison.CurrentCultureIgnoreCase) > 0 OrElse text14.IndexOf(text7, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text14.IndexOf(text8, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
											text14 = ShareLibriay.ReplaceFiledIgnoreCase(text14, text4, text9)
											text14 = ShareLibriay.ReplaceFiledIgnoreCase(text14, text5, text10)
											text14 = ShareLibriay.ReplaceFiledIgnoreCase(text14, text6, text11)
											text14 = ShareLibriay.ReplaceFiledIgnoreCase(text14, text7, text12)
											text14 = ShareLibriay.ReplaceFiledIgnoreCase(text14, text8, text13)
											Try
												dataColumn2.Expression = text14
												Dim dataRow5 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataRelation.ParentTable.TableName, dataColumn2.ColumnName })
												If dataRow5 IsNot Nothing Then
													dataRow5("Expression") = text14
												End If
											Catch ex As Exception
											End Try
										End If
									End If
								Next
								Continue For
							Finally
								Dim enumerator7 As IEnumerator
								If TypeOf enumerator7 Is IDisposable Then
									TryCast(enumerator7, IDisposable).Dispose()
								End If
							End Try
						End If
						If Operators.CompareString(dataRelation.ParentTable.TableName, A_0.Name, True) = 0 Then
							Dim text4 As String = "Parent(" + dataRelation.RelationName + ")." + A_2
							Dim text5 As String = String.Concat(New String() { "Parent([", dataRelation.RelationName, "]).[", A_2, "]" })
							Dim text6 As String = "Parent." + A_2
							Dim text7 As String = "Parent([" + dataRelation.RelationName + "])." + A_2
							Dim text8 As String = String.Concat(New String() { "Parent(", dataRelation.RelationName, ").[", A_2, "]" })
							Dim text9 As String = "Parent(" + dataRelation.RelationName + ")." + A_3
							Dim text10 As String = String.Concat(New String() { "Parent([", dataRelation.RelationName, "]).[", A_3, "]" })
							Dim text11 As String = "Parent." + A_3
							Dim text12 As String = "Parent([" + dataRelation.RelationName + "])." + A_3
							Dim text13 As String = String.Concat(New String() { "Parent(", dataRelation.RelationName, ").[", A_3, "]" })
							Try
								For Each obj6 As Object In dataRelation.ChildTable.Columns
									Dim dataColumn3 As DataColumn = CType(obj6, DataColumn)
									If Operators.CompareString(dataColumn3.Expression, "", True) > 0 Then
										Dim text15 As String = dataColumn3.Expression
										If text15.IndexOf(text4, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text15.IndexOf(text5, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text15.IndexOf(text6, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text15.IndexOf(text7, StringComparison.CurrentCultureIgnoreCase) >= 0 OrElse text15.IndexOf(text8, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
											text15 = ShareLibriay.ReplaceFiledIgnoreCase(text15, text4, text9)
											text15 = ShareLibriay.ReplaceFiledIgnoreCase(text15, text5, text10)
											text15 = ShareLibriay.ReplaceFiledIgnoreCase(text15, text6, text11)
											text15 = ShareLibriay.ReplaceFiledIgnoreCase(text15, text7, text12)
											text15 = ShareLibriay.ReplaceFiledIgnoreCase(text15, text8, text13)
											Try
												dataColumn3.Expression = text15
												Dim dataRow6 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { dataRelation.ChildTable.TableName, dataColumn3.ColumnName })
												If dataRow6 IsNot Nothing Then
													dataRow6("Expression") = text15
												End If
											Catch ex2 As Exception
											End Try
										End If
									End If
								Next
							Finally
								Dim enumerator8 As IEnumerator
								If TypeOf enumerator8 Is IDisposable Then
									TryCast(enumerator8, IDisposable).Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator6 As IEnumerator
					If TypeOf enumerator6 Is IDisposable Then
						TryCast(enumerator6, IDisposable).Dispose()
					End If
				End Try
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
			End If
		End Sub

		' Token: 0x0600573C RID: 22332 RVA: 0x00226678 File Offset: 0x00224878
		<oO0oooo("0039")>
		Public Sub Lock()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				Dim oooO As OOoO = New OOoO()
				If table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
					Dim dataTable As DataTable = OO_00oOO.CurrentTable.DataTable
					Dim leftCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol
					Dim rightCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol
					For i As Integer = leftCol To rightCol
						Dim name As String = table.foxGrid.Cols(i).Name
						If Not dataTable.DataCols(name).AllowEdit Then
							Return
						End If
						oooO.O__O_._.(dataTable.DataCols(name))
						dataTable.DataCols(name).AllowEdit = False
						table.foxGrid.Rows(table.foxGrid.Rows.Fixed - 1).Invalidate()
					Next
				End If
				If oooO.O__O_._.() > 0 Then
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oooO)
				End If
			End If
		End Sub

		' Token: 0x0600573D RID: 22333 RVA: 0x0022679C File Offset: 0x0022499C
		<oO0oooo("0039")>
		Public Sub UnLock()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				Dim oooO As OOoO = New OOoO()
				If table.foxGrid.Col >= table.foxGrid.Cols.Fixed Then
					Dim dataTable As DataTable = OO_00oOO.CurrentTable.DataTable
					Dim leftCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol
					Dim rightCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol
					For i As Integer = leftCol To rightCol
						Dim name As String = table.foxGrid.Cols(i).Name
						If dataTable.DataCols(name).AllowEdit Then
							Return
						End If
						oooO.O__O_._.(dataTable.DataCols(name))
						dataTable.DataCols(name).AllowEdit = True
						table.foxGrid.Rows(table.foxGrid.Rows.Fixed - 1).Invalidate()
					Next
				End If
				If oooO.O__O_._.() > 0 Then
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oooO)
				End If
			End If
		End Sub

		' Token: 0x0600573E RID: 22334 RVA: 0x002268C0 File Offset: 0x00224AC0
		<oO0oooo("0032")>
		Public Sub MoveLeft()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim cellRange As CellRange = OO_00oOO.CurrentTable.foxGrid.Selection
				OO_00oOO.CurrentTable.O.__O0o0.(cellRange.c1, cellRange.c2, cellRange.c1 - 1, True)
				OO_00oOO.CurrentTable.NeedSaveSetting = True
				cellRange = Nothing
			End If
		End Sub

		' Token: 0x0600573F RID: 22335 RVA: 0x0022691C File Offset: 0x00224B1C
		<oO0oooo("0032")>
		Public Sub MoveRight()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim cellRange As CellRange = OO_00oOO.CurrentTable.foxGrid.Selection
				OO_00oOO.CurrentTable.O.__O0o0.(cellRange.c1, cellRange.c2, cellRange.c2 + 1, True)
				OO_00oOO.CurrentTable.NeedSaveSetting = True
				cellRange = Nothing
			End If
		End Sub

		' Token: 0x06005740 RID: 22336 RVA: 0x00226978 File Offset: 0x00224B78
		<oO0oooo("0037")>
		Public Sub Hide()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.O_o0OOo_.o0..O__00.__0_O.(New ooO0O__o_o_O_(table))
				OO_00oOO.CurrentTable.NeedSaveSetting = True
				Dim leftCol As Integer = table.foxGrid.Selection.LeftCol
				Dim rightCol As Integer = table.foxGrid.Selection.RightCol
				For i As Integer = leftCol To rightCol
					table.foxGrid.Cols(i).Visible = False
				Next
				Dim num As Integer = table.foxGrid.Selection.RightCol + 1
				Dim num2 As Integer = table.foxGrid.Cols.Count - 1
				For j As Integer = num To num2
					If table.foxGrid.Cols(j).Visible Then
						table.foxGrid.Col = j
						Return
					End If
				Next
				Dim num3 As Integer = table.foxGrid.Selection.LeftCol - 1
				Dim fixed As Integer = table.foxGrid.Cols.Fixed
				For k As Integer = num3 To fixed Step -1
					If table.foxGrid.Cols(k).Visible Then
						table.foxGrid.Col = k
						Return
					End If
				Next
			End If
		End Sub

		' Token: 0x06005741 RID: 22337 RVA: 0x00226AB4 File Offset: 0x00224CB4
		<oO0oooo("0037")>
		Public Sub UnHide()
			Dim a_ As Table
			If OO_00oOO.CurrentTable IsNot Nothing Then
				a_ = OO_00oOO.CurrentTable
			Else
				If OO_00oOO.CurrentTable Is Nothing Then
					Return
				End If
				a_ = OO_00oOO.CurrentTable
			End If
			Dim tableEventArgs As TableEventArgs = New TableEventArgs(OO_00oOO.CurrentTable)
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.CurrentTable.DataTable.o_0_00_.oo0O0., "BeforeUnhideColumn", New Object() { tableEventArgs }, True, OO_00oOO.CurrentTable.DataTable.Name, False)
			New O\u3002\u3000\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3002(a_).ShowDialog()
		End Sub

		' Token: 0x06005742 RID: 22338 RVA: 0x00226B2C File Offset: 0x00224D2C
		<oO0oooo("0038")>
		Public Sub Freeze()
			Dim table As Table
			If OO_00oOO.CurrentTable IsNot Nothing Then
				table = OO_00oOO.CurrentTable
			Else
				If OO_00oOO.CurrentTable Is Nothing Then
					Return
				End If
				table = OO_00oOO.CurrentTable
			End If
			Dim o_u3002_u3000_u As O\u3002\u3000\u3002 = New O\u3002\u3000\u3002("冻结列", "冻结列数量:", 2, 0, table.foxGrid.Cols.Count - table.foxGrid.Cols.Fixed, "冻结列数超出范围")
			If o_u3002_u3000_u.ShowDialog() = DialogResult.OK Then
				table.foxGrid.Cols.Frozen = o_u3002_u3000_u.Value
				table.NeedSaveSetting = True
			End If
		End Sub

		' Token: 0x06005743 RID: 22339 RVA: 0x00226BB4 File Offset: 0x00224DB4
		<oO0oooo("0038")>
		Public Sub UnFreeze()
			Dim table As Table
			If OO_00oOO.CurrentTable IsNot Nothing Then
				table = OO_00oOO.CurrentTable
			Else
				If OO_00oOO.CurrentTable Is Nothing Then
					Return
				End If
				table = OO_00oOO.CurrentTable
			End If
			table.foxGrid.Cols.Frozen = 0
		End Sub

		' Token: 0x06005744 RID: 22340 RVA: 0x00226BEE File Offset: 0x00224DEE
		Public Sub ModifyProperty()
		End Sub

		' Token: 0x06005745 RID: 22341 RVA: 0x00226BF0 File Offset: 0x00224DF0
		<oO0oooo("A0042")>
		Public Sub Width()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New O\u3002\u3002\u3002\u3002\u3000\u3000(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005746 RID: 22342 RVA: 0x00226C0C File Offset: 0x00224E0C
		Public Sub ChangeTextAlign(Align As TextAlignEnum)
			If OO_00oOO.CurrentTable IsNot Nothing AndAlso OO_00oOO.CurrentTable.foxGrid.Col >= OO_00oOO.CurrentTable.foxGrid.Cols.Fixed Then
				Dim o_0_Oo As O_0_Oo = New O_0_Oo(OO_00oOO.CurrentTable)
				Dim leftCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol
				Dim rightCol As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol
				For i As Integer = leftCol To rightCol
					Dim dataCol As DataCol = OO_00oOO.CurrentTable.DataTable.DataCols(OO_00oOO.CurrentTable.foxGrid.Cols(i).Name)
					dataCol.TextAlign = Align
					dataCol.O.O_OO.(False)
					o_0_Oo.O_oo._o.(dataCol.Name)
					Try
						For Each table As Table In OO_00oOO.Tables
							If table.DataTable Is OO_00oOO.CurrentTable.DataTable AndAlso table.Cols.Contains(dataCol.Name) Then
								table.Cols(dataCol.Name).TextAlign = Align
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Table)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Next
				If o_0_Oo.O_oo._o.() > 0 Then
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(o_0_Oo)
				End If
			End If
		End Sub

		' Token: 0x06005747 RID: 22343 RVA: 0x00226D7C File Offset: 0x00224F7C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub GetAllValue()
		End Sub

		' Token: 0x06005748 RID: 22344 RVA: 0x00226D80 File Offset: 0x00224F80
		Private Function <<EMPTY_NAME>>(A_0 As DataCol) As Boolean
			Dim result As Boolean
			If Not ooO.oo__.O000_o_O.() Then
				result = False
			ElseIf A_0.DataTable.frd_IsInnerQuery OrElse A_0.DataTable.frd_IsOuterQuery OrElse A_0.DataTable.frd_IsTemporary OrElse A_0.DataTable.AddByCode Then
				MessageBox.Show("查询表或临时表不能转换列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.DataTable.frd_Connection) Then
				MessageBox.Show("来自Oracle的表不能转换列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x06005749 RID: 22345 RVA: 0x00226E10 File Offset: 0x00225010
		<oO0oooo("2494")>
		Public Sub DataToExp()
			OO_00oOO.CurrentTable.DataTable.Name
			If OO_00oOO.CurrentTable.foxGrid.Col > 0 Then
				Dim dataCol As DataCol = OO_00oOO.CurrentTable.DataTable.DataCols(OO_00oOO.CurrentTable.foxGrid.Cols(OO_00oOO.CurrentTable.foxGrid.Col).Name)
				If Column.oo0Oo0Oo.OO.(dataCol) Then
					If dataCol.o.O__0__Ooo0.() Then
						MessageBox.Show("不能将关联列转换为表达式列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					If dataCol.IsTemporary Then
						MessageBox.Show("[" + dataCol.Name + "]已经是表达式列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					Dim o_u3002_u3002_u3002_u3002_o_u As O\u3002\u3002\u3002\u3002_o\u3000 = New O\u3002\u3002\u3002\u3002_o\u3000()
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = True
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = dataCol
					o_u3002_u3002_u3002_u3002_o_u.oOO._o00o00__.().Text = "确定要将[" + dataCol.Name + "]转为表达式列吗？"
					o_u3002_u3002_u3002_u3002_o_u.ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x0600574A RID: 22346 RVA: 0x00226F0C File Offset: 0x0022510C
		<oO0oooo("2494")>
		Public Sub ExpToData()
			OO_00oOO.CurrentTable.DataTable.Name
			If OO_00oOO.CurrentTable.foxGrid.Col > 0 Then
				Dim dataCol As DataCol = OO_00oOO.CurrentTable.DataTable.DataCols(OO_00oOO.CurrentTable.foxGrid.Cols(OO_00oOO.CurrentTable.foxGrid.Col).Name)
				If Column.oo0Oo0Oo.OO.(dataCol) Then
					If Not dataCol.IsTemporary Then
						MessageBox.Show("[" + dataCol.Name + "]已经是数据列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					Dim o_u3002_u3002_u3002_u3002_o_u As O\u3002\u3002\u3002\u3002_o\u3000 = New O\u3002\u3002\u3002\u3002_o\u3000()
					o_u3002_u3002_u3002_u3002_o_u.O_0oo.O0. = True
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = dataCol
					o_u3002_u3002_u3002_u3002_o_u.oOO._o00o00__.().Text = "确定要将[" + dataCol.Name + "]转为数据列吗？"
					o_u3002_u3002_u3002_u3002_o_u.ShowDialog()
				End If
			End If
		End Sub
	End Module
End Namespace
