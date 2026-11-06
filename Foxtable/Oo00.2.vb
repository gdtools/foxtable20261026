Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1FlexGrid
Imports Foxtable.RibbonMenu
Imports Foxtable.Syscmd
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports MSScriptControl

Namespace Foxtable
	' Token: 0x02000432 RID: 1074
	Friend NotInheritable Module Oo00
		' Token: 0x060046CA RID: 18122 RVA: 0x001CDF20 File Offset: 0x001CC120
		Public Sub <<EMPTY_NAME>>()
			Try
				New ScriptControlClass()
			Catch ex As Exception
				New Process() With { .File = O_O0OO.o.00O_O.() + "\regscript.bat", .WaitForClose = True }.Start()
				New ScriptControlClass()
			End Try
		End Sub

		' Token: 0x060046CB RID: 18123 RVA: 0x001CDF80 File Offset: 0x001CC180
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(A_0) Then
				MessageBox.Show("已经存在同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = o_O_o_oOoo__.O_o_._o0.(A_0)
			End If
			Return result
		End Function

		' Token: 0x060046CC RID: 18124 RVA: 0x001CDFC0 File Offset: 0x001CC1C0
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable, Optional A_1 As Boolean = True)
			If A_0.ExtendedProperties.ContainsKey("DataAdapter") Then
				CType(A_0.ExtendedProperties("DataAdapter"), OleDbDataAdapter).Update(A_0)
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 AndAlso A_1 AndAlso Main.OO_O.o. IsNot Nothing Then
					Main.OO_O.o..o._oOO0. = True
					Return
				End If
			ElseIf A_0.ExtendedProperties.ContainsKey("WebUpdater") Then
				Dim a_ As DataTable = CType(A_0.ExtendedProperties("WebUpdater"), DataTable)
				Dim array As DataRow() = A_0.[Select]("", "", DataViewRowState.ModifiedCurrent)
				If array.Length > 0 Then
					oOO0oO000_0_0.oOoOo_o.__.(a_, array)
				End If
				array = A_0.[Select]("", "", DataViewRowState.Added)
				If array.Length > 0 Then
					oOO0oO000_0_0.o__o.OOO__.(a_, array)
				End If
				array = A_0.[Select]("", "", DataViewRowState.Deleted)
				If array.Length > 0 Then
					oOO0oO000_0_0.OO.OoO0.(a_, array)
				End If
			End If
		End Sub

		' Token: 0x060046CD RID: 18125 RVA: 0x001CE0B5 File Offset: 0x001CC2B5
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			CType(A_0.Table.ExtendedProperties("DataAdapter"), OleDbDataAdapter).Update(New DataRow() { A_0 })
		End Sub

		' Token: 0x060046CE RID: 18126 RVA: 0x001CE0E1 File Offset: 0x001CC2E1
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.
		End Function

		' Token: 0x060046CF RID: 18127 RVA: 0x001CE0F8 File Offset: 0x001CC2F8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.
		End Function

		' Token: 0x060046D0 RID: 18128 RVA: 0x001CE110 File Offset: 0x001CC310
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.ToLower().EndsWith("accdb") Then
				result = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.
			Else
				result = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=" + O_O0OO.oO_00Ooo___0._.
			End If
			Return result
		End Function

		' Token: 0x060046D1 RID: 18129 RVA: 0x001CE160 File Offset: 0x001CC360
		Friend Function <<EMPTY_NAME>>(A_0 As o_oo0, A_1 As DataTable, A_2 As String, A_3 As String) As Boolean
			Dim result As Boolean
			If A_0.o0_oo0._.().oooO__O_0o_.o_.(A_2) Then
				MessageBox.Show(A_2 + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				A_0.o0_oo0._.().O_.0_O__OOoOo.(A_2)
				A_0.o0_oo0._.().O.0_O.(A_2).ooo.O_0_O.(A_3)
				For Each dataRow As DataRow In A_1.[Select]("", "ID", DataViewRowState.CurrentRows)
					If Not dataRow.IsNull("列名") Then
						Dim a_ As String = Conversions.ToString(dataRow("列名"))
						Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow("类型")), ColumnDataTypeEnum)
						Dim a_2 As Integer
						If Not dataRow.IsNull("长度") Then
							a_2 = Conversions.ToInteger(dataRow("长度"))
						End If
						A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().O_o0.Oo00o0.(a_, columnDataTypeEnum, Integer.MinValue)
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] Then
							A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().OO00o__OOO.o0_.(a_).O_o0.Oo00o0.(a_2)
						End If
						If Not dataRow.IsNull("标题") Then
							A_0.o0_oo0._.().O.0_O.(A_2).o_O00_.00_.().OO00o__OOO.o0_.(a_).O.0_.(Conversions.ToString(dataRow("标题")))
						End If
					End If
				Next
				result = True
			End If
			Return result
		End Function

		' Token: 0x060046D2 RID: 18130 RVA: 0x001CE2C0 File Offset: 0x001CC4C0
		Friend Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If Operators.CompareString(A_1.Value, "", True) = 0 Then
				MessageBox.Show("请输入关联名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 Then
				If Not o_O_o_oOoo__.O_o_._o0.(A_1.Value, "关联名称", 64, False) Then
					A_1.Cancel = True
				End If
				If o_O_o_oOoo__.oo.O0o0o.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Columns("Name"), A_1.Value) Then
					MessageBox.Show("已经存在同名关联，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x060046D3 RID: 18131 RVA: 0x001CE378 File Offset: 0x001CC578
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable, A_2 As DataTable) As Boolean
			Dim text As String = "关联名称不能和现有列的列名相同！"
			Try
				Dim enumerator As IEnumerator = A_1.Columns.GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(CType(enumerator.Current, DataColumn).ColumnName, A_0, True) = 0 Then
						MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				Dim enumerator2 As IEnumerator = A_2.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					If Operators.CompareString(CType(enumerator2.Current, DataColumn).ColumnName, A_0, True) = 0 Then
						MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
				End While
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Return True
		End Function

		' Token: 0x060046D4 RID: 18132 RVA: 0x001CE45C File Offset: 0x001CC65C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If(dataRelation.ParentTable Is O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0) OrElse dataRelation.ChildTable Is O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0)) AndAlso Operators.CompareString(dataRelation.RelationName, A_1, True) = 0 Then
						MessageBox.Show("列名不能和关联名相同！", "提示", MessageBoxButtons.OK)
						Return False
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return True
		End Function

		' Token: 0x060046D5 RID: 18133 RVA: 0x001CE50C File Offset: 0x001CC70C
		Friend Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If String.IsNullOrWhiteSpace(A_1.Value) Then
				MessageBox.Show("请输入窗口名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 Then
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(String.Concat(New String() { "select Count(*) From [", ooO0__OO.oo._O.(), "] Where ([Type] = ", Conversions.ToString(229), " Or [Type] = ", Conversions.ToString(233), ") and [Name] = '", A_1.Value, "'" }), O_O0OO.OoO.0OO__0ooo.())
				O_O0OO.OoO.0OO__0ooo.().Open()
				If Conversions.ToInteger(RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())) > 0 Then
					MessageBox.Show("已经存在同名窗口，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					A_1.Cancel = True
				End If
				O_O0OO.OoO.0OO__0ooo.().Close()
			End If
		End Sub

		' Token: 0x060046D6 RID: 18134 RVA: 0x001CE604 File Offset: 0x001CC804
		Friend Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If String.IsNullOrWhiteSpace(A_1.Value) Then
				MessageBox.Show("请输入函数名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 Then
				Dim array As DataRow() = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o.00_0o0__OoO.()).[Select]("[Type] = " + Conversions.ToString(9))
				For i As Integer = 0 To array.Length - 1
					Dim text As String = array(i)("Name").ToString()
					If text.StartsWith("![") AndAlso text.EndsWith("]!") Then
						text = text.Trim(New Char() { "!"c }).TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
					End If
					If Operators.CompareString(text, A_1.Value, True) = 0 Then
						MessageBox.Show("已经存在同名函数，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						A_1.Cancel = True
						Return
					End If
				Next
			End If
		End Sub

		' Token: 0x060046D7 RID: 18135 RVA: 0x001CE718 File Offset: 0x001CC918
		Friend Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If String.IsNullOrWhiteSpace(A_1.Value) Then
				MessageBox.Show("请输入目录名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 Then
				For Each dataRow As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o.00_0o0__OoO.()).[Select]("[Type] = " + Conversions.ToString(43))
					Dim left As String = dataRow("Name").ToString()
					Dim right As String = ""
					If A_1.parentNode IsNot Nothing Then
						right = A_1.parentNode.FullPath
					End If
					If Operators.CompareString(left, A_1.Value, True) = 0 AndAlso Operators.CompareString(dataRow("Path").ToString(), right, True) = 0 Then
						MessageBox.Show("已经存在同名目录，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						A_1.Cancel = True
						Return
					End If
				Next
			End If
		End Sub

		' Token: 0x060046D8 RID: 18136 RVA: 0x001CE810 File Offset: 0x001CCA10
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, Optional A_2 As DataSet = Nothing) As Boolean
			If A_2 Is Nothing Then
				A_2 = O_O0OO.OOOo.oo_OOOO_0.()
			End If
			Try
				For Each obj As Object In A_2.Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If Operators.CompareString(dataRelation.ParentTable.TableName, A_0, True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, A_1, True) = 0 Then
						Return True
					End If
					If Operators.CompareString(dataRelation.ChildTable.TableName, A_0, True) = 0 AndAlso Operators.CompareString(dataRelation.ParentTable.TableName, A_1, True) = 0 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x060046D9 RID: 18137 RVA: 0x001CE8CC File Offset: 0x001CCACC
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As DataRow) As Boolean
			Dim result As Boolean
			If Oo00.O____0O._0.(A_2("ParentTable").ToString(), A_2("ChildTable").ToString(), Nothing) AndAlso A_2.RowState = DataRowState.Detached Then
				result = True
			Else
				Try
					For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						If dataRow IsNot A_2 Then
							If Operators.CompareString(dataRow("ParentTable").ToString(), A_0, True) = 0 AndAlso Operators.CompareString(dataRow("ChildTable").ToString(), A_1, True) = 0 Then
								Return True
							End If
							If Operators.CompareString(dataRow("ParentTable").ToString(), A_1, True) = 0 AndAlso Operators.CompareString(dataRow("ChildTable").ToString(), A_0, True) = 0 Then
								Return True
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x060046DA RID: 18138 RVA: 0x001CE9E4 File Offset: 0x001CCBE4
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim dataRelation As DataRelation = O_O0OO.OOOo.oo_OOOO_0.().Relations(A_0)
			Dim parentTable As DataTable = dataRelation.ParentTable
			Dim childTable As DataTable = dataRelation.ChildTable
			Try
				For Each table As Foxtable.Table In OO_00oOO.Tables
					If table.DataTable.BaseTable Is parentTable OrElse table.DataTable.BaseTable Is childTable Then
						table._frdTableLayout.OOooOOo_.0_0_o.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Foxtable.Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim value As String = String.Concat(New String() { ".", dataRelation.ParentTable.TableName, ".", dataRelation.ChildTable.TableName, "." })
			Dim value2 As String = String.Concat(New String() { ".", dataRelation.ChildTable.TableName, ".", dataRelation.ParentTable.TableName, "." })
			For i As Integer = OO_00oOO.Tables.Count - 1 To 0 Step -1
				Dim table2 As Foxtable.Table = OO_00oOO.Tables(i)
				If table2.View.O0O_0_0__.0O.() IsNot Nothing Then
					Dim text As String = "." + table2.View.Oo._Oo0OO.() + "."
					If text.IndexOf(value) >= 0 OrElse text.IndexOf(value2) >= 0 Then
						Dim a_ As Boolean = OO_00oOO.SystemReady
						OO_00oOO.SystemReady = False
						table2.Filter = ""
						OO_00oOO.SystemReady = a_
						O_O0OO.o__.O.().Remove(table2.View.Oo._Oo0OO.())
						OO_00oOO.Tables.OO._O_o__.(table2.Name)
						Dim o_oOooO_O As O_oOooO_O = table2.foxGrid
						Dim fixed As Integer = o_oOooO_O.Cols.Fixed
						Dim num As Integer = o_oOooO_O.Cols.Count - 1
						For j As Integer = fixed To num
							o_oOooO_O.Cols(j).Editor = Nothing
						Next
						Dim o_ As O_0 = o_oOooO_O.o.0O_O0o_..View
						table2.foxGrid = Nothing
						o_oOooO_O.o.0O_O0o_. = Nothing
						If o_oOooO_O.FindForm() IsNot Nothing Then
							Dim parent As System.Windows.Forms.Control = o_oOooO_O.Parent
							While Not(TypeOf parent Is o_O0_0O0)
								parent = parent.Parent
							End While
							CType(parent, o_O0_0O0).o_o.O___0o.(o_oOooO_O)
						End If
						o_oOooO_O.SetDataBinding(Nothing, Nothing)
						o_.Dispose()
						o_oOooO_O.o.o0OO00oO_0.()
						o_oOooO_O.Dispose()
					End If
				End If
			Next
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.())
			For k As Integer = dataTable.Rows.Count - 1 To 0 Step -1
				Dim text2 As String = "." + dataTable.Rows(k)("Table").ToString() + "."
				If text2.IndexOf(value2) >= 0 OrElse text2.IndexOf(value2) > 0 Then
					dataTable.Rows(k).Delete()
				End If
			Next
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
			O_O0OO.OOOo.oo_OOOO_0.().Relations.Remove(A_0)
			Dim list As List(Of Foxtable.Table) = New List(Of Foxtable.Table)()
			Try
				For Each table3 As Foxtable.Table In OO_00oOO.Tables
					If table3.foxGrid.FindForm() IsNot Nothing AndAlso table3.O.__O0o0.(False, False) Then
						list.Add(table3)
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of Foxtable.Table)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Try
				For Each table4 As Foxtable.Table In OO_00oOO.Tables
					If table4.DataTable.BaseTable Is parentTable OrElse table4.DataTable.BaseTable Is childTable Then
						table4._frdTableLayout.Oo_.oo_oOo_oO.()
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of Foxtable.Table)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			Try
				For Each table5 As Foxtable.Table In list
					Dim tableEventArgs As TableEventArgs = New TableEventArgs(table5)
					O_O0OO.OoO_o.oO0o0O.(table5.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", New Object() { tableEventArgs }, True, table5.DataTable.Name, False)
				Next
			Finally
				Dim enumerator4 As List(Of Foxtable.Table).Enumerator
				CType(enumerator4, IDisposable).Dispose()
			End Try
			Main.OO_O.o..Refresh()
		End Sub

		' Token: 0x060046DB RID: 18139 RVA: 0x001CEE6C File Offset: 0x001CD06C
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean, Optional A_2 As Boolean = True)
			Dim list As List(Of O_0) = New List(Of O_0)()
			Dim list2 As List(Of O_0) = New List(Of O_0)()
			If O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(A_0) Then
				Dim o0Oo As O0Oo = CType(O_O0OO.OOOo.oo_OOOO_0.().Relations(A_0), O0Oo)
				If o0Oo.oo0__.0Oo0o_.() <> 2 Then
					If o0Oo.ParentTable Is o0Oo.ChildTable Then
						list.Add(OO_00oOO.Tables(o0Oo.ParentTable.TableName).View)
					Else
						Try
							For Each o_ As O_0 In O_O0OO.o__.O.().Values
								If(o_.O0O_0_0__.0O.() Is Nothing OrElse o_.O0O_0_0__.0O.().ParentTable IsNot o_.O0O_0_0__.0O.().ChildTable) AndAlso Not o_.O0O.o__0.() Then
									If o_.o_o.O0ooOo.() Is o0Oo.ParentTable Then
										list.Add(o_)
									ElseIf o_.o_o.O0ooOo.() Is o0Oo.ChildTable AndAlso o0Oo.oo0__.0Oo0o_.() = 1 Then
										list2.Add(o_)
									End If
								End If
							Next
						Finally
							Dim enumerator As Dictionary(Of String, O_0).ValueCollection.Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
					End If
					Try
						For Each o_2 As O_0 In list
							If o_2.o_oo._0Oo.() Then
								o0OoOOoOOo0.o_OOo_0.0O.(O_O0OO.o__.O.(), o_2, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, False)
							Else
								o0OoOOoOOo0.o_OOo_0.0O.(O_O0OO.o__.O.(), o_2, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, True)
							End If
						Next
					Finally
						Dim enumerator2 As List(Of O_0).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					Try
						For Each o_3 As O_0 In list2
							If o_3.o_oo._0Oo.() Then
								o0OoOOoOOo0.O_0_Oo_00.O.(O_O0OO.o__.O.(), o_3, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, False)
							Else
								o0OoOOoOOo0.O_0_Oo_00.O.(O_O0OO.o__.O.(), o_3, O_O0OO.OOOo.oo_OOOO_0.(), o0Oo, True)
							End If
						Next
					Finally
						Dim enumerator3 As List(Of O_0).Enumerator
						CType(enumerator3, IDisposable).Dispose()
					End Try
				End If
				If A_2 Then
					Dim list3 As List(Of Foxtable.Table) = New List(Of Foxtable.Table)()
					Try
						For Each table As Foxtable.Table In OO_00oOO.Tables
							If table.foxGrid.FindForm() IsNot Nothing AndAlso table.O.__O0o0.(False, False) Then
								list3.Add(table)
							End If
						Next
					Finally
						Dim enumerator4 As IEnumerator(Of Foxtable.Table)
						If enumerator4 IsNot Nothing Then
							enumerator4.Dispose()
						End If
					End Try
					OO_00oOO.Tables.OO._O_o__.()
					Main.OO_O.o..o0_o_o_0.0O.(o0Oo, A_1)
					OO_00oOO.Tables(o0Oo.ParentTable.TableName).View.o_._0O0o_OoO.()
					OO_00oOO.Tables(o0Oo.ChildTable.TableName).View.o_._0O0o_OoO.()
					Try
						For Each table2 As Foxtable.Table In list3
							Dim tableEventArgs As TableEventArgs = New TableEventArgs(table2)
							O_O0OO.OoO_o.oO0o0O.(table2.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", New Object() { tableEventArgs }, True, table2.DataTable.Name, False)
						Next
					Finally
						Dim enumerator5 As List(Of Foxtable.Table).Enumerator
						CType(enumerator5, IDisposable).Dispose()
					End Try
				End If
			End If
		End Sub

		' Token: 0x060046DC RID: 18140 RVA: 0x001CF19C File Offset: 0x001CD39C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String) As MultiColumnDictionary
			Dim num As Integer
			Dim result As MultiColumnDictionary
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(A_0) Then
					GoTo IL_204
				End If
				IL_1E:
				num2 = 3
				If Not O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0).Columns.Contains(A_2) Then
					GoTo IL_204
				End If
				IL_40:
				num2 = 4
				If Not O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0).Columns.Contains(A_3) Then
					GoTo IL_204
				End If
				IL_62:
				num2 = 5
				Dim dataView As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0))
				IL_7B:
				num2 = 6
				If Operators.CompareString(A_4, "", True) <= 0 Then
					GoTo IL_A5
				End If
				IL_8D:
				num2 = 7
				A_4 = A_4 + " And " + A_2 + " Is Not Null"
				GoTo IL_B5
				IL_A5:
				num2 = 9
				A_4 = A_2 + " Is Not Null"
				IL_B5:
				num2 = 10
				dataView.RowFilter = A_4
				IL_C1:
				num2 = 11
				dataView.Sort = A_5
				IL_CD:
				num2 = 12
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_163
				End If
				IL_E2:
				num2 = 13
				Dim list As List(Of String) = New List(Of String)()
				IL_EC:
				num2 = 14
				list.AddRange(A_1.Split(New Char() { ","c }))
				IL_107:
				num2 = 15
				Dim num3 As Integer = list.Count - 1
				For i As Integer = 0 To num3
					IL_11A:
					num2 = 16
					list(i) = list(i).Trim()
					IL_134:
					num2 = 17
				Next
				IL_143:
				num2 = 18
				result = New MultiColumnDictionary(dataView, A_2, list.ToArray(), list.IndexOf(A_3))
				GoTo IL_209
				IL_163:
				num2 = 20
				Dim list2 As List(Of String) = New List(Of String)()
				IL_16D:
				num2 = 21
				Dim enumerator As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0).Columns.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					IL_19C:
					num2 = 22
					If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) Then
						IL_1B2:
						num2 = 23
						list2.Add(dataColumn.ColumnName)
					End If
					IL_1C3:
					num2 = 24
				End While
				IL_1CF:
				num2 = 25
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_1E7:
				num2 = 26
				result = New MultiColumnDictionary(dataView, A_2, list2.ToArray(), list2.IndexOf(A_3))
				GoTo IL_209
				IL_204:
				num2 = 27
				result = Nothing
				IL_209:
				GoTo IL_2CB
				IL_20E:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_28C:
				GoTo IL_2C0
				IL_28E:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_29E:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_28E
			End Try
			IL_2C0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2CB:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046DD RID: 18141 RVA: 0x001CF49C File Offset: 0x001CD69C
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Dim text As String = "一二三四五六七八九十"
			Dim num As Integer = 0
			Do
				Dim dataRow As DataRow = A_0.NewRow()
				dataRow("列名") = "第" + Conversions.ToString(text(num)) + "列"
				dataRow("类型") = ColumnDataTypeEnum.[String]
				dataRow("标题") = ""
				dataRow("长度") = "16"
				A_0.Rows.Add(dataRow)
				num += 1
			Loop While num <= 9
		End Sub

		' Token: 0x060046DE RID: 18142 RVA: 0x001CF528 File Offset: 0x001CD728
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			If A_0.HasVersion(DataRowVersion.Original) AndAlso A_0.Table.DataSet IsNot Nothing Then
				Try
					For Each obj As Object In A_0.Table.Columns
						Dim dataColumn As DataColumn = CType(obj, DataColumn)
						If(Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) OrElse Operators.CompareString(dataColumn.ColumnName, "_SortKey", True) = 0 OrElse (Operators.CompareString(dataColumn.ColumnName, "_Locked", True) = 0 AndAlso OO_00oOO.DataTables(A_0.Table.TableName).O000_00._0_o.)) AndAlso String.Compare(A_0(dataColumn, DataRowVersion.Current).ToString(), A_0(dataColumn, DataRowVersion.Original).ToString(), StringComparison.Ordinal) <> 0 Then
							Return
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				A_0.AcceptChanges()
			End If
		End Sub

		' Token: 0x060046DF RID: 18143 RVA: 0x001CF630 File Offset: 0x001CD830
		Friend Function <<EMPTY_NAME>>(A_0 As C1FlexGrid, A_1 As String) As Boolean
			Dim text As String = "_Identify"
			Dim list As List(Of String) = New List(Of String)()
			Dim text2 As String = ""
			Dim result As Boolean
			If A_0.Cols.Count - A_0.Cols.Fixed > 253 Then
				MessageBox.Show("列数超过253,无法导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf A_0.Cols.Fixed = A_0.Cols.Count Then
				MessageBox.Show("没有数据可导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(A_1, "")
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
				If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
					Dim text3 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
					Dim text4 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
					Foxtable.RibbonMenu.StatusBar.Message1 = "导入进程:"
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = True
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = 0
					Foxtable.RibbonMenu.StatusBar.Message2 = "0%"
					Application.DoEvents()
					Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
					Try
						o_oo.o0_oo0._.().Open("", "", "", -1)
						o_oo.o0_oo0._.().ActiveConnection = o_oo.o0_oo0._.()
						Dim table As ADOX.Table = New TableClass()
						Dim index As Index = New IndexClass()
						table.Name = "~TMPCLP" + text3
						table.Columns.Append("_Identify", 3, 0)
						table.Columns.Append("_Locked", 11, 0)
						index.Name = "PrimaryKey"
						index.Columns.Append("_Identify", 202, 0)
						index.PrimaryKey = True
						index.Unique = True
						table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
						Dim fixed As Integer = A_0.Cols.Fixed
						Dim num As Integer = A_0.Cols.Count - 1
						For i As Integer = fixed To num
							Dim item As String = A_0(0, i).ToString()
							Dim num2 As Integer = 16
							If Not o_O_o_oOoo__.oO.O_..Contains(item) Then
								Dim fixed2 As Integer = A_0.Rows.Fixed
								Dim num3 As Integer = A_0.Rows.Count - 1
								For j As Integer = fixed2 To num3
									If A_0(j, i) IsNot Nothing Then
										num2 = Math.Max(num2, A_0(j, i).ToString().Length)
									End If
								Next
								If num2 <= 255 Then
									table.Columns.Append(A_0(0, i).ToString(), 202, num2)
								Else
									table.Columns.Append(A_0(0, i).ToString(), 203, 0)
								End If
								table.Columns(A_0(0, i).ToString()).Attributes = 2
								text += ","
								text = text + "[" + A_0(0, i).ToString() + "]"
								list.Add(A_0(0, i).ToString())
							End If
						Next
						text = "(" + text + ")"
						o_oo.o0_oo0._.().Tables.Append(table)
						Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = 5
						Foxtable.RibbonMenu.StatusBar.Message2 = "50%"
						Application.DoEvents()
						Dim fixed3 As Integer = A_0.Rows.Fixed
						Dim num4 As Integer = A_0.Rows.Count - 1
						Dim objectValue As Object
						For k As Integer = fixed3 To num4
							text2 = (k - A_0.Rows.Fixed + 1).ToString()
							Try
								For Each text5 As String In list
									text2 += ","
									If A_0(k, text5) Is Nothing OrElse A_0(k, text5) Is DBNull.Value Then
										text2 += "Null"
									Else
										text2 = text2 + "'" + A_0(k, text5).ToString() + "'"
									End If
								Next
							Finally
								Dim enumerator As List(Of String).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							If k Mod 100 = 0 Then
								Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = CInt(Math.Round(CDbl((k - A_0.Rows.Fixed)) / CDbl((A_0.Rows.Count - A_0.Rows.Fixed)) / 2.0 * 100.0)) + 50
								Foxtable.RibbonMenu.StatusBar.Message2 = Foxtable.RibbonMenu.StatusBar.ProgressBar.Value.ToString() + "%"
								Application.DoEvents()
							End If
							Dim connection As _Connection = o_oo.o0_oo0._.()
							Dim text6 As String = String.Concat(New String() { "Insert into [~TMPCLP", text3, "] ", text, " values (", text2, ")" })
							objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
							connection.Execute(text6, objectValue, -1)
						Next
						Dim connection2 As _Connection = o_oo.o0_oo0._.()
						Dim text7 As String = String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table]  = '", table.Name, "'" })
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection2.Execute(text7, objectValue, -1)
						Dim connection3 As _Connection = o_oo.o0_oo0._.()
						Dim text8 As String = String.Concat(New String() { "Insert into [", ooO0__OO.O00.O__o.(), "] ([Table],[Identify]) values ('", table.Name, "',", Conversions.ToString(A_0.Rows.Count - A_0.Rows.Fixed + 1), ")" })
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						connection3.Execute(text8, objectValue, -1)
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If o_oo.o0_oo0._.().State = 1 Then
							o_oo.o0_oo0._.().Close()
						End If
						o_oo.ooo.0.()
					End Try
					If o_oo.o0_oo0._.().oooO__O_0o_.o_.(text3) Then
						O_O0OO.OoO.0OO__0ooo.().Open()
						o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text3, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
						OO_00oOO.DataTables(text3).Caption = text4
						OO_00oOO.DataTables(text3).o.0O000_.()
						O_O0OO.OoO.0OO__0ooo.().Close()
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text3))
						Main.OO_O.o..o0_o_o_0.0O.(text3, True, False)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
						MessageBox.Show("导入成功，新表中每一列的数据类型均默认为字符型，请重新设置为正确的类型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						If Operators.CompareString(text4, "", True) > 0 Then
							OO_00oOO.DataTables(text3).OO00_o.ooOO.(False)
						End If
						O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
					End If
					Foxtable.RibbonMenu.StatusBar.Message1 = ""
					Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = False
					Foxtable.RibbonMenu.StatusBar.Message2 = ""
					result = True
				Else
					result = False
				End If
			End If
			Return result
		End Function

		' Token: 0x060046E0 RID: 18144 RVA: 0x001CFD84 File Offset: 0x001CDF84
		Friend Function <<EMPTY_NAME>>(A_0 As C1FlexGrid, A_1 As String, A_2 As TableMergeTypeEnum) As Boolean
			Dim dataTable As DataTable = OO_00oOO.MainTable.DataTable.BaseTable
			Dim flag As Boolean = True
			If OO_00oOO.MainTable.DataTable.frd_IsInnerTable Then
				If Not A_0.Cols.Contains("_Identify") Then
					flag = False
				End If
			Else
				Dim primaryKey As DataColumn() = dataTable.PrimaryKey
				Dim i As Integer = 0
				While i < primaryKey.Length
					Dim dataColumn As DataColumn = primaryKey(i)
					If Not A_0.Cols.Contains(dataColumn.ColumnName) Then
						flag = False
						If dataTable.PrimaryKey.Length <> 1 OrElse Not dataTable.PrimaryKey(0).AutoIncrement Then
							MessageBox.Show("对于非兼容外部表，如果主键列不是自动增量型，则所有主键列必须在要合并的表中，有同名、同类型的对应列，否则无法合并。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return False
						End If
						Exit While
					Else
						i += 1
					End If
				End While
			End If
			Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并..."
			Application.DoEvents()
			Try
				OO_00oOO.MainTable.StopRedraw()
				Application.DoEvents()
				Dim fixed As Integer = A_0.Rows.Fixed
				Dim num As Integer = A_0.Rows.Count - 1
				For j As Integer = fixed To num
					Dim dataRow As DataRow = Nothing
					If flag And A_2 <> 2 Then
						Dim array As Object() = New Object(dataTable.PrimaryKey.Length - 1 + 1 - 1) {}
						Dim num2 As Integer = dataTable.PrimaryKey.Length - 1
						For k As Integer = 0 To num2
							array(k) = RuntimeHelpers.GetObjectValue(A_0(j, dataTable.PrimaryKey(k).ColumnName))
						Next
						dataRow = dataTable.Rows.Find(array)
					End If
					If A_2 Is Nothing OrElse dataRow Is Nothing Then
						If dataRow Is Nothing Then
							dataRow = dataTable.NewRow()
						End If
						Try
							For Each obj As Object In dataTable.Columns
								Dim dataColumn2 As DataColumn = CType(obj, DataColumn)
								If A_0.Cols.Contains(dataColumn2.ColumnName) AndAlso A_0(j, dataColumn2.ColumnName) IsNot Nothing Then
									dataRow(dataColumn2) = RuntimeHelpers.GetObjectValue(A_0(j, dataColumn2.ColumnName))
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If dataRow.RowState = DataRowState.Detached Then
							dataTable.Rows.Add(dataRow)
						End If
						Dim num3 As Integer
						num3 += 1
						If num3 Mod 100 = 0 Then
							Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并，已经合并" + Conversions.ToString(num3) + "条记录"
							Application.DoEvents()
						End If
					End If
				Next
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Return False
			Finally
				OO_00oOO.MainTable.ResumeRedraw()
				Foxtable.RibbonMenu.StatusBar.Message1 = ""
			End Try
			Return True
		End Function

		' Token: 0x060046E1 RID: 18145 RVA: 0x001D004C File Offset: 0x001CE24C
		Friend Function <<EMPTY_NAME>>(A_0 As ColumnDataTypeEnum) As Type
			If A_0 <= ColumnDataTypeEnum.[Byte] Then
				Select Case A_0
					Case ColumnDataTypeEnum.[Short]
						Return GetType(Short)
					Case ColumnDataTypeEnum.[Integer]
						Return GetType(Integer)
					Case ColumnDataTypeEnum.[Single]
						Return GetType(Single)
					Case ColumnDataTypeEnum.[Double]
						Return GetType(Double)
					Case CType(6, ColumnDataTypeEnum), CType(8, ColumnDataTypeEnum), CType(9, ColumnDataTypeEnum), CType(10, ColumnDataTypeEnum)
					Case ColumnDataTypeEnum.DateTime
						Return GetType(DateTime)
					Case ColumnDataTypeEnum.[Boolean]
						Return GetType(Boolean)
					Case Else
						If A_0 = ColumnDataTypeEnum.[Byte] Then
							Return GetType(Byte)
						End If
				End Select
			Else
				If A_0 = ColumnDataTypeEnum.[Long] Then
					Return GetType(Long)
				End If
				If A_0 = ColumnDataTypeEnum.[Decimal] Then
					Return GetType(Decimal)
				End If
				If A_0 - ColumnDataTypeEnum.[String] <= 1 Then
					Return GetType(String)
				End If
			End If
			Return GetType(Object)
		End Function

		' Token: 0x060046E2 RID: 18146 RVA: 0x001D0148 File Offset: 0x001CE348
		Friend Function <<EMPTY_NAME>>(A_0 As Type, A_1 As DataCol) As ColumnDataTypeEnum
			Dim result As ColumnDataTypeEnum
			If A_0 Is GetType(Boolean) Then
				result = ColumnDataTypeEnum.[Boolean]
			ElseIf A_0 Is GetType(Byte) Then
				result = ColumnDataTypeEnum.[Byte]
			ElseIf A_0 Is GetType(DateTime) Then
				result = ColumnDataTypeEnum.DateTime
			ElseIf A_0 Is GetType(Decimal) Then
				result = ColumnDataTypeEnum.[Decimal]
			ElseIf A_0 Is GetType(Double) Then
				result = ColumnDataTypeEnum.[Double]
			ElseIf A_0 Is GetType(Integer) Then
				result = ColumnDataTypeEnum.[Integer]
			ElseIf A_0 Is GetType(Long) Then
				result = ColumnDataTypeEnum.[Long]
			ElseIf A_0 Is GetType(Short) Then
				result = ColumnDataTypeEnum.[Short]
			ElseIf A_0 Is GetType(Single) Then
				result = ColumnDataTypeEnum.[Single]
			ElseIf A_0 Is GetType(String) Then
				If A_1.BaseColumn.MaxLength >= 1 AndAlso A_1.BaseColumn.MaxLength <= 255 Then
					result = ColumnDataTypeEnum.[String]
				Else
					result = ColumnDataTypeEnum.Text
				End If
			End If
			Return result
		End Function

		' Token: 0x060046E3 RID: 18147 RVA: 0x001D0240 File Offset: 0x001CE440
		Friend Function <<EMPTY_NAME>>(A_0 As Type, A_1 As DataCol) As ADOXType
			Dim result As ADOXType
			If A_0 Is GetType(Boolean) Then
				result = ADOXType.[Boolean]
			ElseIf A_0 Is GetType(Byte) Then
				result = ADOXType.[Byte]
			ElseIf A_0 Is GetType(DateTime) Then
				result = ADOXType.DateTime
			ElseIf A_0 Is GetType(Decimal) Then
				result = ADOXType.[Decimal]
			ElseIf A_0 Is GetType(Double) Then
				result = ADOXType.[Double]
			ElseIf A_0 Is GetType(Integer) Then
				result = ADOXType.[Integer]
			ElseIf A_0 Is GetType(Long) Then
				result = ADOXType.[Long]
			ElseIf A_0 Is GetType(Short) Then
				result = ADOXType.[Short]
			ElseIf A_0 Is GetType(Single) Then
				result = ADOXType.[Single]
			ElseIf A_0 Is GetType(String) Then
				If A_1.BaseColumn.MaxLength >= 1 AndAlso A_1.BaseColumn.MaxLength <= 255 Then
					result = ADOXType.[String]
				Else
					result = ADOXType.Text
				End If
			End If
			Return result
		End Function

		' Token: 0x060046E4 RID: 18148 RVA: 0x001D0328 File Offset: 0x001CE528
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			Dim num3 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Not O_O0OO.O_O00OOooo.O_. Then
					GoTo IL_27
				End If
				IL_09:
				num = 2
				MessageBox.Show("正在加载数据的过程中，暂不能关闭项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_1E:
				num = 3
				result = False
				GoTo IL_7C0
				IL_27:
				num = 4
				If OO_00oOO.CurrentTable Is Nothing Then
					GoTo IL_C8
				End If
				IL_33:
				num = 5
				If OO_00oOO.CurrentTable.foxGrid.Editor Is Nothing Then
					GoTo IL_74
				End If
				IL_46:
				num = 6
				OO_00oOO.CurrentTable.foxGrid.FinishEditing()
				IL_58:
				num = 7
				If OO_00oOO.CurrentTable.foxGrid.Editor Is Nothing Then
					GoTo IL_74
				End If
				IL_6B:
				num = 8
				result = False
				GoTo IL_7C0
				IL_74:
				num = 9
				If OO_00oOO.CurrentTable.o00oOO00_.ooOo. Is Nothing Then
					GoTo IL_C8
				End If
				IL_83:
				num = 10
				If OO_00oOO.CurrentTable.o00oOO00_.ooOo..Editor Is Nothing Then
					GoTo IL_C8
				End If
				IL_97:
				num = 11
				OO_00oOO.CurrentTable.o00oOO00_.ooOo..FinishEditing()
				IL_AA:
				num = 12
				If OO_00oOO.CurrentTable.o00oOO00_.ooOo..Editor Is Nothing Then
					GoTo IL_C8
				End If
				IL_BE:
				num = 13
				result = False
				GoTo IL_7C0
				IL_C8:
				num = 14
				Dim flag As Boolean
				Select Case O_O0OO.O0_00o.o0__o..BackPeriod
					Case 1
						IL_F9:
						num = 16
						If DateTime.Compare(DateTime.Today.AddDays(-1.0), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0 Then
							Exit Select
						End If
						IL_128:
						num = 17
						flag = True
					Case 2
						IL_165:
						num = 22
						If DateTime.Compare(DateTime.Today.AddDays(-7.0), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0 Then
							Exit Select
						End If
						IL_191:
						num = 23
						flag = True
					Case 3
						IL_133:
						num = 19
						If DateTime.Compare(DateTime.Today.AddMonths(-1), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0 Then
							Exit Select
						End If
						IL_15A:
						num = 20
						flag = True
					Case 4
						IL_199:
						num = 25
						If DateTime.Compare(DateTime.Today.AddMonths(-3), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0 Then
							Exit Select
						End If
						IL_1BE:
						num = 26
						flag = True
					Case 5
						IL_1C6:
						num = 28
						If DateTime.Compare(DateTime.Today.AddYears(-1), O_O0OO.O0_00o.o0__o..LastBackUpdate) < 0 Then
							Exit Select
						End If
						IL_1EA:
						num = 29
						flag = True
				End Select
				IL_1F0:
				num = 31
				If Not flag Then
					GoTo IL_205
				End If
				IL_1F7:
				num = 32
				Project.Backup("", True)
				IL_205:
				num = 33
				Dim beforeCloseProjectEventArgs As BeforeCloseProjectEventArgs = New BeforeCloseProjectEventArgs()
				IL_20F:
				num = 34
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCloseProject", New Object() { beforeCloseProjectEventArgs }, False, "项目", False)
				IL_234:
				num = 35
				If Not beforeCloseProjectEventArgs.Cancel Then
					GoTo IL_24A
				End If
				IL_240:
				num = 36
				result = False
				GoTo IL_7C0
				IL_24A:
				num = 37
				If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\TempFiles") Then
					GoTo IL_2BF
				End If
				IL_268:
				num = 38
				Dim enumerator As IEnumerator(Of String) = OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Bin\TempFiles").GetEnumerator()
				While enumerator.MoveNext()
					Dim file As String = enumerator.Current
					IL_296:
					num = 39
					OO_00oOO.FileSys.DeleteFile(file)
					IL_2A5:
					num = 40
				End While
				IL_2B1:
				num = 41
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_2BF:
				num = 42
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + "Bin\TempFiles") Then
					GoTo IL_334
				End If
				IL_2DD:
				num = 43
				Dim enumerator2 As IEnumerator(Of String) = OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + "Bin\TempFiles").GetEnumerator()
				While enumerator2.MoveNext()
					Dim file2 As String = enumerator2.Current
					IL_30B:
					num = 44
					OO_00oOO.FileSys.DeleteFile(file2)
					IL_31A:
					num = 45
				End While
				IL_326:
				num = 46
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_334:
				num = 47
				If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "HttpTempFiles\") Then
					GoTo IL_3A9
				End If
				IL_352:
				num = 48
				Dim enumerator3 As IEnumerator(Of String) = OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "HttpTempFiles\").GetEnumerator()
				While enumerator3.MoveNext()
					Dim file3 As String = enumerator3.Current
					IL_380:
					num = 49
					OO_00oOO.FileSys.DeleteFile(file3)
					IL_38F:
					num = 50
				End While
				IL_39B:
				num = 51
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_3A9:
				num = 52
				Dim enumerator4 As Dictionary(Of String, IMServer).ValueCollection.Enumerator = OO_00oOO.IMServers.Values.GetEnumerator()
				While enumerator4.MoveNext()
					Dim imserver As IMServer = enumerator4.Current
					IL_3C8:
					num = 53
					If Not imserver.o0oo__0Oo_.o00. Then
						IL_3D4:
						num = 54
						imserver.[Stop]()
					End If
					IL_3DE:
					num = 55
				End While
				IL_3EA:
				num = 56
				CType(enumerator4, IDisposable).Dispose()
				IL_3FA:
				num = 57
				OO_00oOO.IMServers.Clear()
				IL_407:
				num = 58
				Dim enumerator5 As Dictionary(Of String, IMClient).ValueCollection.Enumerator = OO_00oOO.IMClients.Values.GetEnumerator()
				While enumerator5.MoveNext()
					Dim imclient As IMClient = enumerator5.Current
					IL_426:
					num = 59
					If Not imclient.O0_OOo.O. Then
						IL_432:
						num = 60
						imclient.[Stop]()
					End If
					IL_43C:
					num = 61
				End While
				IL_448:
				num = 62
				CType(enumerator5, IDisposable).Dispose()
				IL_458:
				num = 63
				OO_00oOO.IMClients.Clear()
				IL_465:
				num = 64
				Dim enumerator6 As Dictionary(Of String, UDPClient).ValueCollection.Enumerator = OO_00oOO.UDPClients.Values.GetEnumerator()
				While enumerator6.MoveNext()
					Dim udpclient As UDPClient = enumerator6.Current
					IL_484:
					num = 65
					If Not udpclient.O00ooo._. Then
						IL_490:
						num = 66
						udpclient.[Stop]()
					End If
					IL_49A:
					num = 67
				End While
				IL_4A6:
				num = 68
				CType(enumerator6, IDisposable).Dispose()
				IL_4B6:
				num = 69
				OO_00oOO.UDPClients.Clear()
				IL_4C3:
				num = 70
				If Not OO_00oOO.HttpServer.IsRunning Then
					GoTo IL_4DF
				End If
				IL_4D2:
				num = 71
				OO_00oOO.HttpServer.Close()
				IL_4DF:
				num = 72
				Dim enumerator7 As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator7.MoveNext()
					Dim dataTable As DataTable = enumerator7.Current
					IL_4F9:
					num = 73
					If dataTable.frd_IsTemporary OrElse dataTable.frd_IsOuterQuery OrElse dataTable.frd_IsInnerQuery Then
						IL_517:
						num = 74
						dataTable.BaseTable.AcceptChanges()
					End If
					IL_526:
					num = 75
				End While
				IL_532:
				num = 76
				If enumerator7 IsNot Nothing Then
					enumerator7.Dispose()
				End If
				IL_540:
				num = 77
				If beforeCloseProjectEventArgs.SkipSave OrElse Operators.CompareString(OO_00oOO.ProjectFile, "", True) <= 0 OrElse (Not O_O0OO.OoO.0OO__0ooo.().HasChanges() AndAlso Not O_O0OO.OOOo.oo_OOOO_0.().HasChanges() AndAlso Not Main.OO_O.o..o._oOO0. AndAlso Not Oo00.o00O0O_.O.()) Then
					GoTo IL_5DC
				End If
				IL_58D:
				num = 78
				Dim dialogResult As DialogResult = MessageBox.Show("保存修改吗？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				IL_5A4:
				num = 79
				If dialogResult <> DialogResult.Cancel Then
					If dialogResult <> DialogResult.Yes Then
						GoTo IL_5DC
					End If
					IL_5B1:
					num = 81
					Project.Save()
					IL_5B9:
					num = 82
					If Not O_O0OO.OOOo.oo_OOOO_0.().HasChanges() Then
						GoTo IL_5DC
					End If
					IL_5C8:
					num = 83
					result = False
					GoTo IL_7C0
				End If
				IL_5D2:
				num = 85
				result = False
				GoTo IL_7C0
				IL_5DC:
				num = 87
				If Not Oo00.o.00. Then
					GoTo IL_6FB
				End If
				IL_5E9:
				num = 88
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "PublishConfigString", o0_O.O00__0OO_o.o0O. })
				IL_624:
				num = 89
				If dataRow IsNot Nothing Then
					GoTo IL_6A3
				End If
				IL_62B:
				num = 90
				Dim dataTable2 As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.())
				IL_644:
				num = 91
				dataRow = dataTable2.NewRow()
				IL_650:
				num = 92
				dataRow("Name") = "PublishConfigString"
				IL_664:
				num = 93
				dataRow("Type") = o0_O.O00__0OO_o.o0O.
				IL_67A:
				num = 94
				dataRow("Config") = 0
				IL_68F:
				num = 95
				dataTable2.Rows.Add(dataRow)
				IL_6A0:
				dataTable2 = Nothing
				IL_6A3:
				num = 97
				Dim s As String = dataRow("Config").ToString()
				IL_6B9:
				num = 98
				Dim num2 As Integer
				Integer.TryParse(s, num2)
				IL_6C6:
				num = 99
				num2 += Oo00.o.00. / 2
				IL_6D5:
				num = 100
				dataRow("Config") = num2
				IL_6EB:
				num = 101
				Oo00.o0_o._O_.(dataRow.Table, True)
				IL_6FB:
				num = 102
				Dim enumerator8 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator8.MoveNext()
					Dim form As Foxtable.WinForm.Form = enumerator8.Current
					IL_715:
					num = 103
					form.Close()
					IL_71F:
					num = 104
					If form.Opened Then
						IL_72B:
						num = 105
						result = False
						GoTo IL_7C0
					End If
					IL_735:
					num = 106
				End While
				IL_741:
				num = 107
				If enumerator8 IsNot Nothing Then
					enumerator8.Dispose()
				End If
				IL_74F:
				num = 108
				Dim enumerator9 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator9.MoveNext()
					Dim table As Foxtable.Table = enumerator9.Current
					IL_769:
					num = 109
					table.CloseRecordGrid()
					IL_773:
					num = 110
				End While
				IL_77F:
				num = 111
				If enumerator9 IsNot Nothing Then
					enumerator9.Dispose()
				End If
				IL_78D:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_794:
				num = 113
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()) Then
					GoTo IL_7BB
				End If
				IL_7A8:
				num = 114
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.OoO__.0oO0oo.(), DeleteDirectoryOption.DeleteAllContents)
				IL_7BB:
				num = 115
				result = True
				IL_7C0:
				GoTo IL_9E2
				IL_7C5:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_9A3:
				GoTo IL_9D7
				IL_9A5:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_9B5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num3 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9A5
			End Try
			IL_9D7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9E2:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060046E5 RID: 18149 RVA: 0x001D0D3C File Offset: 0x001CEF3C
		Friend Sub <<EMPTY_NAME>>()
			If Not O_O0OO.O0_00o.o0__o..HasUsers Then
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
				Dim array As DataRow() = dataTable.[Select]("[Type] = " + Conversions.ToString(0))
				If array Is Nothing OrElse array.Length = 0 Then
					Dim dataRow As DataRow = dataTable.NewRow()
					Dim userProperty As UserProperty = New UserProperty()
					userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.("888", O_O0OO.O_O._Oo.().Substring(0, 8), O_O0OO.O_O._Oo.().Substring(O_O0OO.O_O._Oo.().Length - 8)))
					userProperty.Type = 0
					dataRow("Name") = "开发者"
					dataRow("Type") = 0
					dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, False, vbVerticalTab, False)
					dataTable.Rows.Add(dataRow)
				End If
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(1))
				If array Is Nothing OrElse array.Length = 0 Then
					Dim dataRow2 As DataRow = dataTable.NewRow()
					Dim userProperty2 As UserProperty = New UserProperty()
					userProperty2.Type = 1
					userProperty2.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.("888", O_O0OO.O_O._Oo.().Substring(0, 8), O_O0OO.O_O._Oo.().Substring(O_O0OO.O_O._Oo.().Length - 8)))
					dataRow2("Name") = "管理员"
					dataRow2("Type") = 1
					dataRow2("Config") = o_O_o_oOoo__.OOOO_OO._oo.(userProperty2, False, vbVerticalTab, False)
					dataTable.Rows.Add(dataRow2)
				End If
				Oo00.o0_o._O_.(dataTable, True)
			End If
		End Sub

		' Token: 0x060046E6 RID: 18150 RVA: 0x001D0EDC File Offset: 0x001CF0DC
		Friend Function <<EMPTY_NAME>>(A_0 As Foxtable.Table, A_1 As Boolean) As String
			Dim text As String = ""
			If Operators.CompareString(A_0.View.get_Filter(), "", True) > 0 AndAlso Not A_1 Then
				text = A_0.Filter
			End If
			If A_0.IsChild Then
				Dim row As DataRow = A_0.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row
				Try
					For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
						Dim dataRelation As DataRelation = CType(obj, DataRelation)
						If dataRelation.ParentTable Is row.Table AndAlso dataRelation.ChildTable Is A_0.View.o_o.O0ooOo.() Then
							Dim num As Integer = dataRelation.ParentColumns.Length - 1
							For i As Integer = 0 To num
								If Operators.CompareString(text, "", True) > 0 Then
									text += " And "
								End If
								If dataRelation.ParentColumns(i).DataType Is GetType(String) Then
									text = String.Concat(New String() { text, "[", dataRelation.ChildColumns(i).ColumnName, "] = '", row(dataRelation.ParentColumns(i)).ToString(), "'" })
								ElseIf dataRelation.ParentColumns(i).DataType Is GetType(DateTime) Then
									text = String.Concat(New String() { text, "[", dataRelation.ChildColumns(i).ColumnName, "] = #", row(dataRelation.ParentColumns(i)).ToString(), "#" })
								Else
									text = String.Concat(New String() { text, "[", dataRelation.ChildColumns(i).ColumnName, "] = ", row(dataRelation.ParentColumns(i)).ToString() })
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
			End If
			Return text
		End Function

		' Token: 0x060046E7 RID: 18151 RVA: 0x001D111C File Offset: 0x001CF31C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim array As String() = A_0.Split(New Char() { "."c })
			Dim key As String = array(array.Length - 2)
			Dim a_ As String = array(array.Length - 1)
			Return OO_00oOO.DataTables(O_O0OO.o__.O.()(key).o_o.O0ooOo.().TableName).DataCols(a_).IsNumeric
		End Function

		' Token: 0x060046E8 RID: 18152 RVA: 0x001D1178 File Offset: 0x001CF378
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim array As String() = A_0.Split(New Char() { "."c })
			Dim key As String = array(array.Length - 2)
			Dim a_ As String = array(array.Length - 1)
			Return OO_00oOO.DataTables(O_O0OO.o__.O.()(key).o_o.O0ooOo.().TableName).DataCols(a_).IsDate
		End Function

		' Token: 0x060046E9 RID: 18153 RVA: 0x001D11D4 File Offset: 0x001CF3D4
		Friend Sub <<EMPTY_NAME>>()
			Dim array As String() = New String() { "Table", "ParentTable", "ChildTable" }
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim dataTableNames As List(Of String) = OO_00oOO.DataTables.GetDataTableNames()
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables
					Dim dataTable As DataTable = CType(obj, DataTable)
					If Operators.CompareString(dataTable.TableName, ooO0__OO.oo._O.(), True) <> 0 Then
						For Each text As String In array
							If dataTable.Columns.Contains(text) Then
								Try
									For Each obj2 As Object In dataTable.Rows
										Dim dataRow As DataRow = CType(obj2, DataRow)
										If dataRow.RowState <> DataRowState.Deleted AndAlso dataRow.RowState <> DataRowState.Detached Then
											For Each text2 As String In dataRow(text).ToString().Split(New Char() { "."c })
												text2 = text2.Trim(New Char() { "{"c, "}"c, "["c, "]"c })
												Dim flag As Boolean = False
												Try
													Dim enumerator3 As List(Of String).Enumerator = dataTableNames.GetEnumerator()
													While enumerator3.MoveNext()
														If Operators.CompareString(enumerator3.Current, text2, True) = 0 Then
															flag = True
														End If
													End While
												Finally
													Dim enumerator3 As List(Of String).Enumerator
													CType(enumerator3, IDisposable).Dispose()
												End Try
												If Operators.CompareString(text2, "", True) > 0 AndAlso Not flag AndAlso Operators.CompareString(text2, "(ProjectIdentify)", True) <> 0 Then
													list.Add(dataRow)
													Exit For
												End If
											Next
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
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
				For Each dataRow2 As DataRow In list
					dataRow2.Delete()
				Next
			Finally
				Dim enumerator4 As List(Of DataRow).Enumerator
				CType(enumerator4, IDisposable).Dispose()
			End Try
			If O_O0OO.OoO.0OO__0ooo.().HasChanges() Then
				Try
					For Each obj3 As Object In O_O0OO.OoO.0OO__0ooo.().Tables
						Oo00.o0_o._O_.(CType(obj3, DataTable), True)
					Next
				Finally
					Dim enumerator5 As IEnumerator
					If TypeOf enumerator5 Is IDisposable Then
						TryCast(enumerator5, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060046EA RID: 18154 RVA: 0x001D14C0 File Offset: 0x001CF6C0
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Binding
			Dim num As Integer = A_1.LastIndexOf("."c)
			If num > 0 AndAlso num < A_1.Length - 1 Then
				Dim text As String = A_1.Substring(0, num)
				Dim o_ As O_0 = Nothing
				If O_O0OO.o__.O.().ContainsKey(text) Then
					o_ = O_O0OO.o__.O.()(text)
				Else
					Try
						For Each text2 As String In O_O0OO.o__.O.().Keys
							If Operators.CompareString(text2, text, True) = 0 Then
								o_ = O_O0OO.o__.O.()(text2)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, O_0).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				If o_ IsNot Nothing Then
					Dim text3 As String = A_1.Substring(num + 1)
					If OO_00oOO.Tables(o_.Oo._Oo0OO.()).DataTable.DataCols.Contains(text3) Then
						Return New Binding(A_0, o_, text3)
					End If
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x060046EB RID: 18155 RVA: 0x001D15B0 File Offset: 0x001CF7B0
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As String) As String
			Dim text As String = ""
			Dim text2 As String = ""
			Try
				For Each obj As Object In A_0.Table.DataSet.Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If Operators.CompareString(dataRelation.ParentTable.TableName, A_0.Table.TableName, True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, A_1, True) = 0 Then
						Dim num As Integer = dataRelation.ParentColumns.Length - 1
						For i As Integer = 0 To num
							If A_0.IsNull(dataRelation.ParentColumns(i)) Then
								text = "False"
								Exit For
							End If
							If Operators.CompareString(text, "", True) > 0 Then
								text += " And "
							End If
							If dataRelation.ParentColumns(i).DataType Is GetType(String) Then
								text2 = "'"
							ElseIf dataRelation.ParentColumns(i).DataType Is GetType(DateTime) Then
								text2 = "#"
							End If
							text = String.Concat(New String() { text, "[", dataRelation.ChildColumns(i).ColumnName, "] = ", text2, A_0(dataRelation.ParentColumns(i)).ToString(), text2 })
						Next
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return text
		End Function

		' Token: 0x060046EC RID: 18156 RVA: 0x001D1754 File Offset: 0x001CF954
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As Foxtable.Table)
			Dim text As String = A_1.Name
			Dim num As Integer = -1
			Dim flag As Boolean = OO_00oOO.MainTable Is A_1
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			Dim num2 As Integer = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
			For i As Integer = 0 To num2
				If Operators.CompareString(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(i).Name, text, True) = 0 Then
					num = i
				End If
			Next
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
			Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(text)
			For j As Integer = dataTable.DataSet.Relations.Count - 1 To 0 Step -1
				Dim o0Oo As O0Oo = CType(dataTable.DataSet.Relations(j), O0Oo)
				If Operators.CompareString(o0Oo.ParentTable.TableName, text, True) = 0 OrElse Operators.CompareString(o0Oo.ChildTable.TableName, text, True) = 0 Then
					Oo00.OO.0O0o.(o0Oo.RelationName)
					If o0Oo.oo0__.0Oo0o_.() IsNot Nothing Then
						list.Add(o0Oo.oo0__.0Oo0o_.())
					End If
				End If
			Next
			If num > -1 Then
				Main.OO_O.o..OO_O_0Oo.___o.().TabPages.RemoveAt(num)
				OO_00oOO.Tables.OO._O_o__.(text)
				OO_00oOO.DataTables.OoO_00.O.(text)
				O_O0OO.o__.O.().Remove(text)
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(text)
			End If
			o0OoOOoOOo0.OOOOO.o000.(A_0, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), True, False, Nothing)
			Try
				For Each a_ As DataRow In list
					o0OoOOoOOo0.OO0._Oo0o.(a_, O_O0OO.OOOo.oo_OOOO_0.())
				Next
			Finally
				Dim enumerator As List(Of DataRow).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Oo00.oO.OO.(OO_00oOO.DataTables(text).BaseTable)
			OO_00oOO.DataTables(text).o0O.ooO00.()
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text))
			Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(A_0("Name")), True, True)
			Try
				For Each dataRow As DataRow In list
					Oo00.o00O0O_.O.(dataRow("Name").ToString(), True, True)
				Next
			Finally
				Dim enumerator2 As List(Of DataRow).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			If num > -1 Then
				Dim oo___OO0O_ As OO___OO0O_0 = Main.OO_O.o..OO_O_0Oo.___o.()
				oo___OO0O_.TabPages.Insert(num, oo___OO0O_.TabPages(oo___OO0O_.TabPages.Count - 1))
			End If
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
			If flag Then
				OO_00oOO.MainTable = OO_00oOO.Tables(text)
				OO_00oOO.CurrentTable = OO_00oOO.MainTable
			End If
		End Sub

		' Token: 0x060046ED RID: 18157 RVA: 0x001D1A40 File Offset: 0x001CFC40
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Dim dictionary As Dictionary(Of DataColumn, String) = New Dictionary(Of DataColumn, String)()
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Operators.CompareString(A_0.TableName, Conversions.ToString(dataRow("Table")), True) = 0 Then
						Dim text As String = Conversions.ToString(dataRow("Column"))
						Dim value As String = Conversions.ToString(dataRow("Expression"))
						Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow("DataType")), ColumnDataTypeEnum)
						Dim maxLength As Integer
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] AndAlso Not dataRow.IsNull("Maxlength") Then
							maxLength = Conversions.ToInteger(dataRow("Maxlength"))
						Else
							maxLength = -1
						End If
						If A_0.Columns.Contains(text) Then
							dataRow.Delete()
						Else
							Dim type As Type = Oo00.OO.0O0o.(columnDataTypeEnum)
							Dim dataColumn As DataColumn = A_0.Columns.Add(text, type)
							If columnDataTypeEnum = ColumnDataTypeEnum.[String] Then
								dataColumn.MaxLength = maxLength
							End If
							dictionary.Add(dataColumn, value)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each dataColumn2 As DataColumn In dictionary.Keys
					Try
						dataColumn2.Expression = dictionary(dataColumn2)
					Catch a_ As Exception
						MessageBox.Show(String.Concat(New String() { "无法[", dataColumn2.ColumnName, "]列的表达式设置为:" & vbCrLf, dictionary(dataColumn2), vbCrLf & "如果确定表达式无语法错误，且参与运算的各列的名称准确无误，那么请检查各列的数据类型是否正确，例如只有数值列才能参与加、减、乘、除等数学运算！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
						ooO.oOo0Oo.o.(a_, "")
					End Try
				Next
			Finally
				Dim enumerator2 As Dictionary(Of DataColumn, String).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x060046EE RID: 18158 RVA: 0x001D1C70 File Offset: 0x001CFE70
		Friend Function <<EMPTY_NAME>>(A_0 As OleDbConnection, A_1 As String, Optional A_2 As Boolean = False) As String
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0) Then
				A_1 = A_1.Replace("{", "").Replace("}", "")
			Else
				If A_0 Is O_O0OO.OoO.0OO__0ooo.() OrElse A_2 Then
					A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "{", "[~TMPCLP")
				Else
					A_1 = A_1.Replace("{", "[")
				End If
				A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "}", "]")
			End If
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, vbCrLf & "Where ", vbCrLf & " Where ")
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, vbCrLf & "Order By ", vbCrLf & " Order By ")
			Return A_1
		End Function

		' Token: 0x060046EF RID: 18159 RVA: 0x001D1D10 File Offset: 0x001CFF10
		Friend Function <<EMPTY_NAME>>(A_0 As DataServerTypeEnum, A_1 As String, Optional A_2 As Boolean = False) As String
			If A_0 = DataServerTypeEnum.Oracle Then
				A_1 = A_1.Replace("{", "").Replace("}", "")
			Else
				If A_0 = DataServerTypeEnum.Buildin OrElse A_2 Then
					A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "{", "[~TMPCLP")
				Else
					A_1 = A_1.Replace("{", "[")
				End If
				A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, "}", "]")
			End If
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, vbCrLf & "Where ", vbCrLf & " Where ")
			A_1 = ShareLibriay.ReplaceIgnoreCase(A_1, vbCrLf & "Order By ", vbCrLf & " Order By ")
			Return A_1
		End Function

		' Token: 0x060046F0 RID: 18160 RVA: 0x001D1DA8 File Offset: 0x001CFFA8
		Friend Function <<EMPTY_NAME>>(A_0 As OleDbDataAdapter) As String
			Dim commandText As String = A_0.UpdateCommand.CommandText
			Dim num As Integer
			Dim num2 As Integer
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.SelectCommand.Connection) Then
				num = commandText.IndexOf("""")
				num2 = commandText.IndexOf("""", num + 1)
			Else
				num = commandText.IndexOf("[")
				num2 = commandText.IndexOf("]")
			End If
			Return commandText.Substring(num + 1, num2 - num - 1)
		End Function

		' Token: 0x060046F1 RID: 18161 RVA: 0x001D1E18 File Offset: 0x001D0018
		Friend Function <<EMPTY_NAME>>() As String
			Return o_o_O0OO_0__.O.ooOo__o000OO.()
		End Function

		' Token: 0x060046F2 RID: 18162 RVA: 0x001D1E1F File Offset: 0x001D001F
		Friend Function <<EMPTY_NAME>>() As String
			Return o_o_O0OO_0__.O0_O_o.o_.()
		End Function

		' Token: 0x060046F3 RID: 18163 RVA: 0x001D1E28 File Offset: 0x001D0028
		Friend Sub <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As String, ByRef A_2 As String, ByRef A_3 As String, ByRef A_4 As String, ByRef A_5 As String)
			A_0 = A_0.Trim()
			If A_0.StartsWith("select ", StringComparison.CurrentCultureIgnoreCase) Then
				Dim array As String() = Regex.Split(A_0, "[\s]+")
				Dim num As Integer
				If Operators.CompareString(array(1).ToLower(), "top", True) = 0 Then
					num = 1
				ElseIf Operators.CompareString(array(2).ToLower(), "top", True) = 0 Then
					num = 2
				End If
				If num > 0 Then
					A_2 = array(num + 1)
					If Operators.CompareString(array(num + 2).ToLower(), "percent", True) = 0 Then
						A_2 = A_2 + " " + array(num + 2)
					End If
				End If
				Dim num2 As Integer = -1
				Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0)
				If match.Success Then
					A_0 = A_0.Substring(match.Index + match.Length)
				End If
				If A_0.StartsWith("(") Then
					Dim num3 As Integer = 1
					Dim num4 As Integer = A_0.Length - 1
					For i As Integer = 1 To num4
						If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
							num3 += 1
						End If
						If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
							num3 -= 1
						End If
						If num3 = 0 Then
							num2 = i + 1
							Exit For
						End If
					Next
				End If
				If num2 = -1 Then
					match = New Regex("[\s]*[\S]+[\s]*", RegexOptions.IgnoreCase).Match(A_0)
					If match.Success Then
						num2 = match.Index + match.Length
					End If
				End If
				If num2 > -1 Then
					A_0 = A_0.Substring(num2)
				End If
				array = Regex.Split(A_0, "[\s]+")
				Dim num5 As Integer = array.Length - 1
				For j As Integer = array.Length - 1 To 0 Step -1
					If Operators.CompareString(array(j).ToLower(), "by", True) = 0 Then
						If Operators.CompareString(array(j - 1), "order", True) = 0 Then
							Dim num6 As Integer = j + 1
							Dim num7 As Integer = num5
							For k As Integer = num6 To num7
								A_5 = A_5 + array(k) + " "
							Next
							A_5 = A_5.Trim()
							num5 = j - 2
						End If
						If Operators.CompareString(array(j - 1).ToLower(), "group", True) = 0 Then
							Dim num8 As Integer = j + 1
							Dim num9 As Integer = num5
							For l As Integer = num8 To num9
								A_3 = A_3 + array(l) + " "
							Next
							A_3 = A_3.Trim()
							num5 = j - 2
						End If
					ElseIf Operators.CompareString(array(j).ToLower(), "having", True) = 0 Then
						Dim num10 As Integer = j + 1
						Dim num11 As Integer = num5
						For m As Integer = num10 To num11
							A_4 = A_4 + array(m) + " "
						Next
						A_4 = A_4.Trim()
						num5 = j - 1
					ElseIf Operators.CompareString(array(j).ToLower(), "where", True) = 0 Then
						Dim num12 As Integer = j + 1
						Dim num13 As Integer = num5
						For n As Integer = num12 To num13
							A_1 = A_1 + array(n) + " "
						Next
						A_1 = A_1.Trim()
						num5 = j - 1
					End If
				Next
			End If
		End Sub

		' Token: 0x060046F4 RID: 18164 RVA: 0x001D2134 File Offset: 0x001D0334
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim array As String() = Regex.Split(A_0, "[\s]+")
			A_0 = ""
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num
				If Operators.CompareString(array(i), "From", True) = 0 Then
					Return array(i + 1).TrimStart(New Char() { "("c }).TrimEnd(New Char() { ")"c })
				End If
			Next
			Return ""
		End Function

		' Token: 0x060046F5 RID: 18165 RVA: 0x001D21A8 File Offset: 0x001D03A8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim num As Integer = 0
			Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0, num)
			If match.Success Then
				num = match.Index + match.Length
			End If
			If A_0(num) = "("c Then
				Dim num2 As Integer = 1
				Dim num3 As Integer = num + 1
				Dim num4 As Integer = A_0.Length - 1
				For i As Integer = num3 To num4
					If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
						num2 += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
						num2 -= 1
					End If
					If num2 = 0 Then
						Return i + 1
					End If
				Next
			End If
			Return num
		End Function

		' Token: 0x060046F6 RID: 18166 RVA: 0x001D2254 File Offset: 0x001D0454
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim startat As Integer = 0
			Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(match.Index + match.Length)
			End If
			startat = 0
			If A_0.StartsWith("(") Then
				Dim num As Integer = 1
				Dim num2 As Integer = A_0.Length - 1
				For i As Integer = 1 To num2
					If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
						num += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
						num -= 1
					End If
					If num = 0 Then
						startat = i
						Exit For
					End If
				Next
			End If
			match = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(0, match.Index)
			End If
			match = New Regex("[\s]+order[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			Dim result As String
			If match.Success Then
				result = A_0.Substring(0, match.Index)
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060046F7 RID: 18167 RVA: 0x001D235C File Offset: 0x001D055C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = Oo00.oo_0__0.o.(A_0).Trim()
			Dim result As String
			If text.StartsWith("(") AndAlso text.EndsWith(")") Then
				result = text
			Else
				Dim array As String() = Regex.Split(text, "[\s]+")
				If array.Length >= 3 AndAlso Operators.CompareString(array(array.Length - 2), "as", True) = 0 Then
					result = array(array.Length - 1)
				ElseIf array.Length >= 2 Then
					result = array(array.Length - 1)
				Else
					result = text
				End If
			End If
			Return result
		End Function

		' Token: 0x060046F8 RID: 18168 RVA: 0x001D23D8 File Offset: 0x001D05D8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim regex As Regex = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase)
			Dim match As Match = regex.Match(A_0)
			If match.Success Then
				A_0 = A_0.Substring(match.Index + match.Length)
			End If
			If A_0.StartsWith("(") Then
				Dim num As Integer = 1
				Dim num2 As Integer = A_0.Length - 1
				Dim i As Integer = 1
				While i <= num2
					If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
						num += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
						num -= 1
					End If
					If num = 0 Then
						match = regex.Match(A_0)
						If match.Success Then
							A_0 = A_0.Substring(1, i - 1)
							Return Oo00.o_OoO._0_00.(A_0)
						End If
						Return A_0
					Else
						i += 1
					End If
				End While
			End If
			Return Regex.Split(A_0, "[\s]+")(0)
		End Function

		' Token: 0x060046F9 RID: 18169 RVA: 0x001D24BC File Offset: 0x001D06BC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim startat As Integer = 0
			Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(match.Index + match.Length)
			End If
			If A_0.StartsWith("(") Then
				Dim num As Integer = 1
				Dim num2 As Integer = A_0.Length - 1
				For i As Integer = 1 To num2
					If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
						num += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
						num -= 1
					End If
					If num = 0 Then
						Dim text As String = A_0.Substring(0, i + 1)
						If A_0.Length > i + 1 Then
							A_0 = A_0.Substring(i + 1).Trim()
							Dim array As String() = Regex.Split(A_0, "[\s]+")
							If array.Length > 1 AndAlso Operators.CompareString(array(0).ToLower(), "as", True) = 0 Then
								Return Oo00.o0oO.Oo__oOO0.(String.Concat(New String() { text, " ", array(0), " ", array(1) }))
							End If
							If array.Length > 0 Then
								Dim left As String = array(0).ToLower()
								If Operators.CompareString(left, "where", True) <> 0 AndAlso Operators.CompareString(left, "group", True) <> 0 AndAlso Operators.CompareString(left, "order", True) <> 0 AndAlso Operators.CompareString(left, "having", True) <> 0 AndAlso Operators.CompareString(left, "inner", True) <> 0 AndAlso Operators.CompareString(left, "left", True) <> 0 AndAlso Operators.CompareString(left, "right", True) <> 0 AndAlso Operators.CompareString(left, "full", True) <> 0 AndAlso Operators.CompareString(left, "join", True) <> 0 Then
									Return Oo00.o0oO.Oo__oOO0.(text + " " + array(0))
								End If
							End If
						End If
						Return Oo00.o0oO.Oo__oOO0.(text.Trim())
					End If
				Next
			End If
			If A_0.StartsWith("[") Then
				Dim num3 As Integer = 1
				Dim num4 As Integer = A_0.Length - 1
				For j As Integer = 1 To num4
					If Operators.CompareString(Conversions.ToString(A_0(j)), "[", True) = 0 Then
						num3 += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(j)), "]", True) = 0 Then
						num3 -= 1
					End If
					If num3 = 0 Then
						Return A_0.Substring(0, j + 1)
					End If
				Next
			Else
				Dim array As String() = Regex.Split(A_0, "[\s]+")
				If array.Length >= 3 AndAlso Operators.CompareString(array(1), "as", True) = 0 Then
					Return String.Concat(New String() { array(0), " ", array(1), " ", array(2) })
				End If
				If array.Length >= 2 Then
					Dim left2 As String = array(1)
					If Operators.CompareString(left2, "where", True) = 0 OrElse Operators.CompareString(left2, "group", True) = 0 OrElse Operators.CompareString(left2, "order", True) = 0 OrElse Operators.CompareString(left2, "having", True) = 0 Then
						Return array(0)
					End If
					If Operators.CompareString(left2, "inner", True) = 0 OrElse Operators.CompareString(left2, "left", True) = 0 OrElse Operators.CompareString(left2, "right", True) = 0 OrElse Operators.CompareString(left2, "full", True) = 0 OrElse Operators.CompareString(left2, "join", True) = 0 Then
						Return array(0)
					End If
					Return array(0) + " " + array(1)
				End If
			End If
			match = New Regex("[\s]+join[\s]+", RegexOptions.IgnoreCase).Match(A_0)
			If match.Success Then
				match = New Regex("[\s]+on[\s]+", RegexOptions.IgnoreCase).Match(A_0, match.Index + 1)
				If match.Success Then
					startat = match.Index
				End If
			End If
			Dim matchCollection As MatchCollection = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase).Matches(A_0, startat)
			If matchCollection.Count > 0 Then
				If A_0.IndexOf("FoxTempaX", StringComparison.Ordinal) > matchCollection(matchCollection.Count - 1).Index Then
					A_0 = A_0.Substring(0, matchCollection(0).Index)
				Else
					A_0 = A_0.Substring(0, matchCollection(matchCollection.Count - 1).Index)
				End If
			End If
			match = New Regex("[\s]+group[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(0, match.Index)
			End If
			match = New Regex("[\s]+order[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(0, match.Index)
			End If
			Return A_0
		End Function

		' Token: 0x060046FA RID: 18170 RVA: 0x001D2978 File Offset: 0x001D0B78
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim startat As Integer = 0
			Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
			If match.Success Then
				A_0 = A_0.Substring(match.Index + match.Length)
			End If
			Dim array As String()
			If A_0.StartsWith("(") Then
				Dim num As Integer = 1
				Dim num2 As Integer = A_0.Length - 1
				For i As Integer = 1 To num2
					If Operators.CompareString(Conversions.ToString(A_0(i)), "(", True) = 0 Then
						num += 1
					End If
					If Operators.CompareString(Conversions.ToString(A_0(i)), ")", True) = 0 Then
						num -= 1
					End If
					If num = 0 Then
						Dim text As String = A_0.Substring(0, i + 1)
						If A_0.Length > i + 1 Then
							A_0 = A_0.Substring(i + 1).Trim()
							array = Regex.Split(A_0, "[\s]+")
							If array.Length > 1 AndAlso Operators.CompareString(array(0).ToLower(), "as", True) = 0 Then
								Return Oo00.o0oO.Oo__oOO0.(String.Concat(New String() { text, " ", array(0), " ", array(1) }))
							End If
							If array.Length > 0 Then
								Dim left As String = array(0).ToLower()
								If Operators.CompareString(left, "where", True) <> 0 AndAlso Operators.CompareString(left, "group", True) <> 0 AndAlso Operators.CompareString(left, "order", True) <> 0 AndAlso Operators.CompareString(left, "having", True) <> 0 AndAlso Operators.CompareString(left, "inner", True) <> 0 AndAlso Operators.CompareString(left, "left", True) <> 0 AndAlso Operators.CompareString(left, "right", True) <> 0 AndAlso Operators.CompareString(left, "full", True) <> 0 AndAlso Operators.CompareString(left, "join", True) <> 0 Then
									Return Oo00.o0oO.Oo__oOO0.(text + " " + array(0))
								End If
							End If
						End If
						Return Oo00.o0oO.Oo__oOO0.(text.Trim())
					End If
				Next
			End If
			array = Regex.Split(A_0, "[\s]+")
			Dim result As String
			If array.Length >= 3 AndAlso Operators.CompareString(array(1), "as", True) = 0 Then
				result = String.Concat(New String() { array(0), " ", array(1), " ", array(2) })
			Else
				If array.Length >= 2 Then
					Dim left2 As String = array(1)
					If Operators.CompareString(left2, "where", True) = 0 OrElse Operators.CompareString(left2, "group", True) = 0 OrElse Operators.CompareString(left2, "order", True) = 0 OrElse Operators.CompareString(left2, "having", True) = 0 Then
						Return array(0)
					End If
				End If
				match = New Regex("[\s]+join[\s]+", RegexOptions.IgnoreCase).Match(A_0)
				If match.Success Then
					match = New Regex("[\s]+on[\s]+", RegexOptions.IgnoreCase).Match(A_0, match.Index + 1)
					If match.Success Then
						startat = match.Index
					End If
				End If
				Dim matchCollection As MatchCollection = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase).Matches(A_0, startat)
				If matchCollection.Count > 0 Then
					If A_0.IndexOf("FoxTempaX", StringComparison.Ordinal) > matchCollection(matchCollection.Count - 1).Index Then
						A_0 = A_0.Substring(0, matchCollection(0).Index)
					Else
						A_0 = A_0.Substring(0, matchCollection(matchCollection.Count - 1).Index)
					End If
				End If
				match = New Regex("[\s]+group[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
				If match.Success Then
					A_0 = A_0.Substring(0, match.Index)
				End If
				match = New Regex("[\s]+order[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, startat)
				If match.Success Then
					A_0 = A_0.Substring(0, match.Index)
				End If
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060046FB RID: 18171 RVA: 0x001D2D40 File Offset: 0x001D0F40
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			If A_0.StartsWith("(") Then
				Dim array As String() = Regex.Split(A_0, "[\s]+")
				Dim text As String = ""
				If Operators.CompareString(array(0), "(select", True) = 0 OrElse (array.Length > 1 AndAlso Operators.CompareString(array(1), "select", True) = 0) Then
					Dim array2 As String() = array
					Dim i As Integer = 0
					While i < array2.Length
						If Operators.CompareString(array2(i), "Row_Number()", True) = 0 Then
							Dim matchCollection As MatchCollection = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase).Matches(A_0)
							If matchCollection.Count <= 0 Then
								Exit While
							End If
							text = A_0.Substring(0, matchCollection(matchCollection.Count - 1).Index)
							Dim num As Integer = A_0.LastIndexOf(")")
							If num > 0 Then
								text += A_0.Substring(num)
								Exit While
							End If
							text = ""
							Exit While
						Else
							' The following expression was wrapped in a checked-statement
							i += 1
						End If
					End While
					If Operators.CompareString(text, "", True) > 0 Then
						A_0 = text
					End If
				End If
			End If
			Return A_0
		End Function

		' Token: 0x060046FC RID: 18172 RVA: 0x001D2E34 File Offset: 0x001D1034
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim num As Integer = Oo00.OoO_.__o.(A_0)
			Dim match As Match = New Regex("[\s]+where[\s]+", RegexOptions.IgnoreCase).Match(A_0, num)
			If match.Success Then
				A_0 = A_0.Substring(0, match.Index)
			End If
			match = New Regex("\s+top\s\d+\s+(percent\s+)*", RegexOptions.IgnoreCase).Match(A_0)
			If match.Index < num Then
				A_0 = A_0.Substring(0, match.Index) + " " + A_0.Substring(match.Index + match.Length)
			End If
			Return A_0
		End Function

		' Token: 0x060046FD RID: 18173 RVA: 0x001D2EBC File Offset: 0x001D10BC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim match As Match = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase).Match(A_0)
			Dim result As String
			If match.Success Then
				Dim num As Integer = match.Index
				match = New Regex("[\s]+top[\s]+", RegexOptions.IgnoreCase).Match(A_0)
				If match.Success AndAlso match.Index < num Then
					result = A_0
				Else
					num = Oo00.OoO_.__o.(A_0)
					match = New Regex("[\s]+order[\s]+by[\s]+", RegexOptions.IgnoreCase).Match(A_0, num)
					If match.Success Then
						A_0 = A_0.Substring(0, match.Index) + A_0.Substring(match.Index)
					End If
					result = A_0
				End If
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060046FE RID: 18174 RVA: 0x001D2F5C File Offset: 0x001D115C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Foxtable.Table) As String
			Return Oo00.OoOo_oo_.o_o.(A_0, A_1.DataTable)
		End Function

		' Token: 0x060046FF RID: 18175 RVA: 0x001D2F6C File Offset: 0x001D116C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable) As String
			Dim text As String = Oo00.oo0o.O0O_0__.(A_0, A_1)
			Dim flag As Boolean
			If Operators.CompareString(A_1.DataServer, "", True) > 0 Then
				flag = (A_1.DataServerType = DataServerTypeEnum.Oracle)
			Else
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1.frd_Connection)
			End If
			If flag Then
				text = text.Replace("[", """").Replace("]", """")
			End If
			Dim result As String
			If Oo00.OO_O_0O0OO0_.o.(text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })) Then
				result = "(" + text + ")"
			ElseIf text.StartsWith("[") AndAlso text.EndsWith("]") Then
				result = text
			ElseIf flag Then
				result = """" + text + """"
			ElseIf text.IndexOf(".") >= 0 Then
				result = text
			Else
				result = "[" + text + "]"
			End If
			Return result
		End Function

		' Token: 0x06004700 RID: 18176 RVA: 0x001D3064 File Offset: 0x001D1264
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			For Each value As String In New String() { "[", "]", "(", ")", "+", "-", "*", "/", "%", "^", "&", "|", "=", """", "'" }
				If A_0.IndexOf(value) >= 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x06004701 RID: 18177 RVA: 0x001D311A File Offset: 0x001D131A
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Foxtable.Table) As String
			Return Oo00.oo0o.O0O_0__.(A_0, A_1.DataTable)
		End Function

		' Token: 0x06004702 RID: 18178 RVA: 0x001D3128 File Offset: 0x001D1328
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable) As String
			Dim flag As Boolean
			If Operators.CompareString(A_1.DataServer, "", True) > 0 Then
				flag = (A_1.DataServerType = DataServerTypeEnum.Oracle)
			Else
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_1.frd_Connection)
			End If
			Dim result As String
			If A_1.DataCols.Contains(A_0) AndAlso Operators.CompareString(A_1.DataCols(A_0).Expression, "", True) > 0 Then
				Dim expression As String = A_1.DataCols(A_0).Expression
				Dim text As String = expression
				Dim match As Match = Regex.Match(expression, "[[0-9a-zA-Z\u4e00-\u9fa5_]+]")
				While Operators.CompareString(match.ToString(), "", True) <> 0
					Dim text2 As String = match.ToString()
					Dim text3 As String = Oo00.oo0o.O0O_0__.(text2.Trim(New Char() { "["c }).Trim(New Char() { "]"c }), A_1)
					If Not Oo00.OO_O_0O0OO0_.o.(text3) Then
						text3 = "[" + text3 + "]"
					Else
						text3 = "(" + text3 + ")"
					End If
					text = text.Replace(text2, text3)
					match = match.NextMatch()
				End While
				text = Oo00.ooO.ooo.(A_1, text)
				result = text
			ElseIf A_1.frd_IsInnerTable Then
				result = A_0
			Else
				Dim text4 As String
				If Operators.CompareString(A_1.DataServer, "", True) > 0 Then
					text4 = A_1.HttpSelect
				Else
					text4 = A_1.frd_SelectCommandString
				End If
				Dim match2 As Match = New Regex("[\s]+from[\s\[\{]+", RegexOptions.IgnoreCase).Match(text4)
				If match2.Success Then
					text4 = text4.Substring(0, match2.Index)
				End If
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Regex.Split(text4, "[\s]+"))
				list.RemoveAt(0)
				If Operators.CompareString(list(0), "All", True) = 0 OrElse Operators.CompareString(list(0), "DISTINCT", True) = 0 OrElse Operators.CompareString(list(0), "DISTINCTROW", True) = 0 Then
					list.RemoveAt(0)
				End If
				If Operators.CompareString(list(0), "Top", True) = 0 Then
					list.RemoveAt(0)
					list.RemoveAt(0)
					If Operators.CompareString(list(0), "PERCENT", True) = 0 Then
						list.RemoveAt(0)
					End If
				End If
				text4 = String.Join(" ", list.ToArray())
				Dim array As String() = text4.Split(New Char() { ","c })
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim text5 As String = array(i).Trim(New Char() { " "c })
					If text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Dim text6 As String = text5.Substring(0, text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase)).Trim()
						Dim text7 As String = text5.Substring(text5.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) + 4).Trim()
						Dim flag2 As Boolean
						If Operators.CompareString(text7.Trim(), A_0, True) = 0 Then
							flag2 = True
						ElseIf flag Then
							If text7.EndsWith("""" + A_0 + """", StringComparison.CurrentCultureIgnoreCase) Then
								flag2 = True
							End If
						ElseIf text7.EndsWith("[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase) Then
							flag2 = True
						End If
						If flag2 Then
							Dim text8 As String = text6
							Dim num2 As Integer = A_1.BaseTable.Columns.IndexOf(A_0)
							If num2 > 0 Then
								Dim columnName As String = A_1.BaseTable.Columns(num2 - 1).ColumnName
								flag2 = False
								For j As Integer = i - 1 To 0 Step -1
									text7 = array(j).Trim()
									If Operators.CompareString(text7, columnName, True) = 0 OrElse Operators.CompareString(text7, "*", True) = 0 OrElse text7.EndsWith(".*") Then
										flag2 = True
									ElseIf text7.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
										flag2 = True
									ElseIf Operators.CompareString(text7.Trim(), columnName, True) = 0 Then
										flag2 = True
									ElseIf flag Then
										If text7.EndsWith("""" + columnName + """", StringComparison.CurrentCultureIgnoreCase) Then
											flag2 = True
										End If
									ElseIf text7.EndsWith("[" + columnName + "]", StringComparison.CurrentCultureIgnoreCase) Then
										flag2 = True
									End If
									If flag2 Then
										Exit For
									End If
									text8 = array(j) + "," + text8
								Next
							End If
							Return text8
						End If
					Else
						If Operators.CompareString(text5, A_0, True) = 0 Then
							Return A_0
						End If
						If text5.EndsWith("." + A_0) Then
							Return text5
						End If
						If flag Then
							If text5.EndsWith(".""" + A_0 + """", StringComparison.CurrentCultureIgnoreCase) Then
								Return text5
							End If
							If text5.EndsWith("""" + A_0 + """", StringComparison.CurrentCultureIgnoreCase) Then
								Return text5
							End If
						Else
							If text5.EndsWith(".[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase) Then
								Return text5
							End If
							If text5.EndsWith("[" + A_0 + "]", StringComparison.CurrentCultureIgnoreCase) Then
								Return text5
							End If
						End If
					End If
				Next
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06004703 RID: 18179 RVA: 0x001D3634 File Offset: 0x001D1834
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable) As Dictionary(Of DataColumn, String)
			Dim dictionary As Dictionary(Of DataColumn, String) = New Dictionary(Of DataColumn, String)()
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ParentTable Is A_0 Then
						Try
							For Each obj2 As Object In dataRelation.ChildTable.Columns
								Dim dataColumn As DataColumn = CType(obj2, DataColumn)
								If Operators.CompareString(dataColumn.Expression, "", True) > 0 AndAlso dataColumn.Expression.IndexOf("parent", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
									dictionary.Add(dataColumn, dataColumn.Expression)
									dataColumn.Expression = Nothing
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return dictionary
		End Function

		' Token: 0x06004704 RID: 18180 RVA: 0x001D3730 File Offset: 0x001D1930
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of DataColumn, String))
			Try
				For Each dataColumn As DataColumn In A_0.Keys
					dataColumn.Expression = A_0(dataColumn)
				Next
			Finally
				Dim enumerator As Dictionary(Of DataColumn, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06004705 RID: 18181 RVA: 0x001D378C File Offset: 0x001D198C
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String) As List(Of String)
			Return New List(Of String)(Oo00.O____0O._0.(A_0, A_1, A_2, A_3))
		End Function

		' Token: 0x06004706 RID: 18182 RVA: 0x001D379C File Offset: 0x001D199C
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String) As HashSet(Of String)
			Dim ndx As Integer = A_0.Columns.IndexOf(A_3)
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			If Operators.CompareString(A_2, "", True) = 0 Then
				A_2 = A_3
			End If
			Dim dataView As DataView = New DataView(A_0, A_1, A_2, DataViewRowState.CurrentRows)
			Dim result As HashSet(Of String)
			If dataView.Count = 0 Then
				result = hashSet
			ElseIf Operators.CompareString(A_2, A_3, True) = 0 Then
				Dim text As String = dataView(0)(ndx).ToString()
				hashSet.Add(text)
				Dim num As Integer = dataView.Count - 1
				For i As Integer = 1 To num
					Dim text2 As String = dataView(i)(ndx).ToString()
					If Operators.CompareString(text, text2, True) <> 0 Then
						hashSet.Add(text2)
						text = text2
					End If
				Next
				result = hashSet
			Else
				Dim num2 As Integer = dataView.Count - 1
				For j As Integer = 0 To num2
					Dim text2 As String = dataView(j)(ndx).ToString()
					hashSet.Add(text2)
				Next
				result = hashSet
			End If
			Return result
		End Function

		' Token: 0x06004707 RID: 18183 RVA: 0x001D38A0 File Offset: 0x001D1AA0
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As String, ParamArray A_3 As String()) As List(Of String())
			Operators.CompareString(A_2, "", True)
			Dim text As String = A_2
			If Operators.CompareString(text, "", True) = 0 Then
				For Each str As String In A_3
					If Operators.CompareString(text, "", True) > 0 Then
						text += ","
					End If
					text += str
				Next
			End If
			Dim list As List(Of String()) = New List(Of String())()
			Dim dataView As DataView = New DataView(A_0, A_1, text, DataViewRowState.CurrentRows)
			Dim result As List(Of String())
			If dataView.Count = 0 Then
				result = list
			Else
				Dim num As Integer = A_3.Length - 1
				Dim array As Integer() = New Integer(num + 1 - 1) {}
				Dim array2 As String() = New String(num + 1 - 1) {}
				Dim num2 As Integer = num
				For j As Integer = 0 To num2
					array(j) = A_0.Columns.IndexOf(A_3(j))
				Next
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				Dim num3 As Integer = dataView.Count - 1
				For k As Integer = 0 To num3
					Dim text2 As String = ""
					array2 = CType(Array.CreateInstance(GetType(String), A_3.Length), String())
					Dim num4 As Integer = num
					For l As Integer = 0 To num4
						array2(l) = dataView(k)(array(l)).ToString()
						text2 = text2 + "," + array2(l)
					Next
					Dim count As Integer = hashSet.Count
					hashSet.Add(text2)
					If count < hashSet.Count Then
						list.Add(array2)
					End If
				Next
				result = list
			End If
			Return result
		End Function

		' Token: 0x06004708 RID: 18184 RVA: 0x001D3A22 File Offset: 0x001D1C22
		Public Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As DataTable, A_3 As String)
			Oo00.oO.OO.(A_0, New String() { A_1 }, A_2, New String() { A_3 })
		End Sub

		' Token: 0x06004709 RID: 18185 RVA: 0x001D3A40 File Offset: 0x001D1C40
		Public Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String(), A_2 As DataTable, A_3 As String())
			Dim text As String = ""
			Dim num As Integer = A_1.Length - 1
			For i As Integer = 0 To num
				text = text + ",[" + A_1(i) + "]"
			Next
			text = text.Trim(New Char() { ","c })
			Dim dataView As DataView = New DataView(A_0, "", text, DataViewRowState.CurrentRows)
			Dim array As Object() = New Object(A_1.Length - 1 + 1 - 1) {}
			Dim dictionary As Dictionary(Of DataRow, DataRow) = New Dictionary(Of DataRow, DataRow)()
			Try
				For Each obj As Object In A_2.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim num2 As Integer = A_3.Length - 1
					For j As Integer = 0 To num2
						array(j) = RuntimeHelpers.GetObjectValue(dataRow(A_3(j)))
					Next
					Dim num3 As Integer = dataView.Find(array)
					If num3 < 0 Then
						Dim dataRow2 As DataRow = A_0.NewRow()
						Dim num4 As Integer = A_1.Length - 1
						For k As Integer = 0 To num4
							dataRow2(A_1(k)) = RuntimeHelpers.GetObjectValue(array(k))
						Next
						A_0.Rows.Add(dataRow2)
						dictionary.Add(dataRow2, dataRow)
					Else
						dictionary.Add(dataView(num3).Row, dataRow)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim list As List(Of String) = New List(Of String)()
			Try
				For Each obj2 As Object In A_2.Columns
					Dim dataColumn As DataColumn = CType(obj2, DataColumn)
					Dim flag As Boolean = False
					Dim num5 As Integer = A_3.Length - 1
					For l As Integer = 0 To num5
						If Operators.CompareString(A_3(l), dataColumn.ColumnName, True) = 0 Then
							flag = True
							Exit For
						End If
					Next
					If Not flag Then
						If A_0.Columns.Contains(dataColumn.ColumnName) Then
							Dim num6 As Integer = 0
							Do
								num6 += 1
							Loop While A_0.Columns.Contains(dataColumn.ColumnName + Conversions.ToString(num6))
							dataColumn.ColumnName += Conversions.ToString(num6)
						End If
						A_0.Columns.Add(dataColumn.ColumnName, dataColumn.DataType)
						If dataColumn.DataType Is GetType(String) Then
							A_0.Columns(dataColumn.ColumnName).MaxLength = dataColumn.MaxLength
						End If
						A_0.Columns(dataColumn.ColumnName).Caption = dataColumn.Caption
						list.Add(dataColumn.ColumnName)
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each dataRow3 As DataRow In dictionary.Keys
					Dim dataRow4 As DataRow = dictionary(dataRow3)
					Try
						For Each columnName As String In list
							dataRow3(columnName) = RuntimeHelpers.GetObjectValue(dataRow4(columnName))
						Next
					Finally
						Dim enumerator4 As List(Of String).Enumerator
						CType(enumerator4, IDisposable).Dispose()
					End Try
				Next
			Finally
				Dim enumerator3 As Dictionary(Of DataRow, DataRow).KeyCollection.Enumerator
				CType(enumerator3, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x0600470A RID: 18186 RVA: 0x001D3DD0 File Offset: 0x001D1FD0
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ParentTable IsNot dataRelation.ChildTable AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, A_0, True) = 0 Then
						Operators.CompareString(dataRelation.ParentTable.TableName, A_1, True)
						If Oo00.OO.0O0o.(dataRelation, A_1) Then
							Return True
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x0600470B RID: 18187 RVA: 0x001D3E70 File Offset: 0x001D2070
		Private Function <<EMPTY_NAME>>(A_0 As DataRelation, A_1 As String) As Boolean
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ParentTable IsNot dataRelation.ChildTable AndAlso dataRelation.ChildTable Is A_0.ParentTable Then
						If Operators.CompareString(dataRelation.ParentTable.TableName, A_1, True) = 0 Then
							Return True
						End If
						If Oo00.OO.0O0o.(dataRelation, A_1) Then
							Return True
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x0600470C RID: 18188 RVA: 0x001D3F10 File Offset: 0x001D2110
		Friend Function <<EMPTY_NAME>>(A_0 As JoinTableProperty) As String
			Dim sqljoinTableBuilder As SQLJoinTableBuilder = New SQLJoinTableBuilder("temptable", A_0.BaseTable)
			sqljoinTableBuilder.Filter = A_0.Filter
			sqljoinTableBuilder.Order = A_0.Order
			sqljoinTableBuilder.Top = A_0.Top
			sqljoinTableBuilder.Distinct = A_0.Distinct
			If Operators.CompareString(A_0.LinkTables, "", True) > 0 Then
				Dim array As String() = A_0.LinkTables.Split(New Char() { vbLf })
				For i As Integer = 0 To array.Length - 1
					Dim array2 As String() = array(i).Split(New Char() { vbTab })
					If Operators.CompareString(array2(0), "", True) > 0 AndAlso Operators.CompareString(array2(1), "", True) > 0 AndAlso Operators.CompareString(array2(2), "", True) > 0 AndAlso Operators.CompareString(array2(3), "", True) > 0 Then
						Dim leftCol As String() = array2(1).Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries)
						Dim rightCol As String() = array2(3).Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries)
						sqljoinTableBuilder.AddTable(array2(0), leftCol, array2(2), rightCol, Conversions.ToInteger([Enum].Parse(GetType(JoinModeEnum), array2(4))))
					End If
				Next
			End If
			If Operators.CompareString(A_0.Columns, "", True) > 0 Then
				Dim array3 As String() = A_0.Columns.Split(New Char() { vbLf })
				For j As Integer = 0 To array3.Length - 1
					Dim array4 As String() = array3(j).Split(New Char() { vbTab })
					If Operators.CompareString(array4(1), "", True) > 0 Then
						If Operators.CompareString(array4(2), "1", True) = 0 Then
							sqljoinTableBuilder.AddExp(array4(1), array4(0), True)
						Else
							sqljoinTableBuilder.AddExp(array4(1), array4(0), False)
						End If
					ElseIf Operators.CompareString(array4(2), "1", True) = 0 Then
						sqljoinTableBuilder.AddCols(New Object() { array4(0), True })
					Else
						sqljoinTableBuilder.AddCols(New Object() { array4(0), False })
					End If
				Next
			End If
			Return sqljoinTableBuilder.BuildSql()
		End Function

		' Token: 0x0600470D RID: 18189 RVA: 0x001D4144 File Offset: 0x001D2344
		Friend Function <<EMPTY_NAME>>(A_0 As OleDbConnection) As DataServerTypeEnum
			Dim provider As String = A_0.Provider
			Dim result As DataServerTypeEnum
			If provider.StartsWith("Microsoft.Jet.OLEDB.4.0", StringComparison.CurrentCultureIgnoreCase) OrElse provider.StartsWith("Microsoft.ACE.OLEDB.12.0", StringComparison.CurrentCultureIgnoreCase) Then
				result = DataServerTypeEnum.Access
			ElseIf o_O_o_oOoo__.OOOO_OO._oo.(A_0) Then
				result = DataServerTypeEnum.SqlServer
			ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0) Then
				result = DataServerTypeEnum.Oracle
			End If
			Return result
		End Function

		' Token: 0x0600470E RID: 18190 RVA: 0x001D4194 File Offset: 0x001D2394
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As FTPClient, A_3 As String) As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim beforeAddFileEventArgs As BeforeAddFileEventArgs = New BeforeAddFileEventArgs(A_1.DataTable, A_0, A_1)
			Dim a_ As String = "BeforeAddFile"
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, New Object() { beforeAddFileEventArgs }, False, A_1.DataTable.Name, False)
			Dim result As List(Of String)
			If beforeAddFileEventArgs.Cancel Then
				result = list
			Else
				If A_1.DataTable.GlobalHandler.BeforeAddFile Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeAddFileEventArgs }, False, "全局表事件", False)
				End If
				If beforeAddFileEventArgs.Cancel Then
					result = list
				Else
					If A_2 Is Nothing Then
						Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
						Try
							If Operators.CompareString(beforeAddFileEventArgs.Path, "", True) > 0 Then
								openFileDialog.InitialDirectory = beforeAddFileEventArgs.Path.Replace("/", "\")
							ElseIf Operators.CompareString(A_1.LastFolder, "", True) > 0 AndAlso OO_00oOO.FileSys.DirectoryExists(A_1.LastFolder) Then
								openFileDialog.InitialDirectory = A_1.LastFolder
							ElseIf Operators.CompareString(A_1.SourceFolder, "", True) > 0 AndAlso OO_00oOO.FileSys.DirectoryExists(A_1.SourceFolder) Then
								openFileDialog.InitialDirectory = A_1.SourceFolder
							ElseIf Operators.CompareString(A_1.DefaultFolder, "", True) > 0 Then
								Dim text As String = A_1.DefaultFolder
								If Operators.CompareString(text.Substring(1, 1), ":", True) <> 0 AndAlso Not text.StartsWith("\\") Then
									text = OO_00oOO.ProjectPath + "Attachments\" + text.Trim(New Char() { "\"c })
								End If
								If OO_00oOO.FileSys.DirectoryExists(text) Then
									openFileDialog.InitialDirectory = text
								End If
							End If
							openFileDialog.Multiselect = True
							If Operators.CompareString(A_3, "", True) = 0 Then
								openFileDialog.Filter = A_1.FileFilter
							Else
								openFileDialog.Filter = A_3
							End If
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "")
						End Try
						If openFileDialog.ShowDialog() = DialogResult.OK Then
							A_1.LastFolder = OO_00oOO.FileSys.GetParentPath(openFileDialog.FileName)
							For Each text2 As String In openFileDialog.FileNames
								text2 = ooO.oO0__o.0o__.(text2, A_0, A_1)
								list.Add(text2)
							Next
						End If
					Else
						Dim list2 As List(Of String)
						If Operators.CompareString(beforeAddFileEventArgs.Path, "", True) > 0 Then
							list2 = A_2.SelectFile(beforeAddFileEventArgs.Path.Replace("\", "/"))
						Else
							list2 = A_2.SelectFile()
						End If
						If list2 IsNot Nothing Then
							list = list2
						End If
					End If
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x0600470F RID: 18191 RVA: 0x001D4464 File Offset: 0x001D2664
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As FTPClient, A_3 As String) As String
			Dim beforeAddFileEventArgs As BeforeAddFileEventArgs = New BeforeAddFileEventArgs(A_1.DataTable, A_0, A_1, True)
			Dim a_ As String = "BeforeAddFile"
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, New Object() { beforeAddFileEventArgs }, False, A_1.DataTable.Name, False)
			Dim result As String
			If beforeAddFileEventArgs.Cancel Then
				result = ""
			Else
				If A_1.DataTable.GlobalHandler.BeforeAddFile Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeAddFileEventArgs }, False, "全局表事件", False)
				End If
				If beforeAddFileEventArgs.Cancel Then
					result = ""
				Else
					If A_2 Is Nothing Then
						Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
						If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
							Dim text As String = folderBrowserDialog.SelectedPath
							Dim text2 As String
							If Operators.CompareString(A_1.DefaultFolder, "", True) > 0 Then
								text2 = A_1.DefaultFolder
								If Operators.CompareString(text2.Substring(1, 1), ":", True) <> 0 AndAlso Not text2.StartsWith("\\") Then
									text2 = OO_00oOO.ProjectPath + "Attachments\" + text2.Trim(New Char() { "\"c })
								End If
							Else
								text2 = OO_00oOO.ProjectPath + "Attachments\"
							End If
							If Operators.CompareString(text.TrimEnd(New Char() { "\"c }) + "\", text2.TrimEnd(New Char() { "\"c }) + "\", True) = 0 Then
								text = "\"
							ElseIf text.StartsWith(text2, StringComparison.CurrentCultureIgnoreCase) Then
								text = text.Substring(text2.Length).Trim(New Char() { "\"c })
							End If
							Return "[" + text + "]"
						End If
					Else
						Dim text3 As String
						If Operators.CompareString(beforeAddFileEventArgs.Path, "", True) > 0 Then
							text3 = A_2.SelectFolder(beforeAddFileEventArgs.Path)
						Else
							text3 = A_2.SelectFolder()
						End If
						If Operators.CompareString(text3, "", True) > 0 Then
							Return "[" + text3 + "]"
						End If
					End If
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x06004710 RID: 18192 RVA: 0x001D467C File Offset: 0x001D287C
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As String) As Boolean
			Dim beforeDeleteFileEventArgs As BeforeDeleteFileEventArgs = New BeforeDeleteFileEventArgs(A_1.DataTable, A_0, A_1, A_2)
			Dim a_ As String = "BeforeDeleteFile"
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, New Object() { beforeDeleteFileEventArgs }, False, A_1.DataTable.Name, False)
			Dim result As Boolean
			If beforeDeleteFileEventArgs.Cancel Then
				result = False
			Else
				If A_1.DataTable.GlobalHandler.BeforeDeleteFile Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeDeleteFileEventArgs }, False, "全局表事件", False)
				End If
				If beforeDeleteFileEventArgs.Cancel Then
					result = False
				ElseIf A_2.StartsWith("[") AndAlso A_2.EndsWith("]") Then
					result = True
				Else
					Dim flag As Boolean
					If beforeDeleteFileEventArgs.HaveSetDeleteMode Then
						flag = beforeDeleteFileEventArgs.DeleteLocalFile
					Else
						Dim dialogResult As DialogResult = ooO.o.O_0000_O.(A_1)
						If dialogResult = DialogResult.Yes Then
							flag = True
						ElseIf dialogResult = DialogResult.Cancel Then
							Return False
						End If
					End If
					If flag Then
						A_1.O_0o_O.ooOO.(A_2)
					End If
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x06004711 RID: 18193 RVA: 0x001D476C File Offset: 0x001D296C
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As FTPClient, A_3 As String, A_4 As Boolean)
			Dim text As String = Oo00.ooO.ooo.(A_0, A_1, A_2, A_3, A_4)
			If Operators.CompareString(text, "", True) > 0 Then
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.FileName = OO_00oOO.FileSys.GetName(text)
				saveFileDialog.Filter = Path.GetExtension(text).Trim(New Char() { "."c }) + "|*" + Path.GetExtension(text)
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					OO_00oOO.FileSys.CopyFile(text, saveFileDialog.FileName, True)
				End If
			End If
		End Sub

		' Token: 0x06004712 RID: 18194 RVA: 0x001D47F4 File Offset: 0x001D29F4
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As FTPClient, A_3 As String, A_4 As Boolean) As Boolean
			Dim text As String = Oo00.ooO.ooo.(A_0, A_1, A_2, A_3, A_4)
			If Operators.CompareString(text, "", True) > 0 Then
				Try
					Process.Start(text)
					Return True
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
			Return False
		End Function

		' Token: 0x06004713 RID: 18195 RVA: 0x001D4854 File Offset: 0x001D2A54
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataCol, A_2 As FTPClient, A_3 As String, A_4 As Boolean) As String
			Dim beforeOpenFileEventArgs As BeforeOpenFileEventArgs = New BeforeOpenFileEventArgs(A_1.DataTable, A_0, A_1, A_3, A_4)
			Dim a_ As String = "BeforeOpenFile"
			O_O0OO.OoO_o.oO0o0O.(A_1.DataTable.o_0_00_.oo0O0., a_, New Object() { beforeOpenFileEventArgs }, False, A_1.DataTable.Name, False)
			Dim result As String
			If beforeOpenFileEventArgs.Cancel Then
				result = ""
			Else
				If A_1.DataTable.GlobalHandler.BeforeOpenFile Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeOpenFileEventArgs }, False, "全局表事件", False)
				End If
				If beforeOpenFileEventArgs.Cancel Then
					result = ""
				Else
					A_3 = beforeOpenFileEventArgs.FileName
					If A_2 Is Nothing Then
						A_3 = A_3.Replace("/", "\")
						If A_3.StartsWith("[") AndAlso A_3.EndsWith("]") Then
							Dim text As String = A_3.Substring(1)
							text = text.Substring(0, text.Length - 1)
							text = text.Trim()
							If Operators.CompareString(text, "", True) = 0 OrElse text.Length = 1 OrElse (Not text.StartsWith("\\") AndAlso Operators.CompareString(text.Substring(1, 1), ":", True) <> 0) Then
								text = text.Trim(New Char() { "\"c })
								If Operators.CompareString(text, "", True) = 0 Then
									text = OO_00oOO.ProjectPath + "Attachments\"
								ElseIf Operators.CompareString(A_1.DefaultFolder, "", True) > 0 Then
									text = A_1.DefaultFolder.Trim(New Char() { "\"c }) + "\" + text
									If Operators.CompareString(text.Substring(1, 1), ":", True) <> 0 AndAlso Not text.StartsWith("\\") Then
										text = OO_00oOO.ProjectPath + "Attachments\" + text
									End If
								Else
									text = OO_00oOO.ProjectPath + "Attachments\" + text
								End If
							End If
							If OO_00oOO.FileSys.DirectoryExists(text) Then
								Process.Start(text)
							Else
								MessageBox.Show("未找到以下目录:" & vbCrLf + text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Return ""
						End If
						If Operators.CompareString(A_3.Substring(1, 1), ":", True) <> 0 AndAlso Not A_3.StartsWith("\\") Then
							If Operators.CompareString(A_1.DefaultFolder, "", True) > 0 Then
								A_3 = A_1.DefaultFolder.TrimEnd(New Char() { "\"c }) + "\" + A_3
								If Operators.CompareString(A_3.Substring(1, 1), ":", True) <> 0 AndAlso Not A_3.StartsWith("\\") Then
									A_3 = OO_00oOO.ProjectPath + "Attachments\" + A_3.Trim(New Char() { "\"c })
								End If
							Else
								A_3 = ooO.OoO0o_o___.O.(A_3)
							End If
						End If
						If OO_00oOO.FileSys.FileExists(A_3) Then
							Return A_3
						End If
						MessageBox.Show("未找到以下文件：" & vbCrLf + beforeOpenFileEventArgs.FileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						A_3 = A_3.Replace("\", "/")
						If A_3.StartsWith("[") AndAlso A_3.EndsWith("]") Then
							Dim text2 As String = A_3.Substring(1)
							text2 = text2.Substring(0, text2.Length - 1)
							A_2.OpenManager(text2)
							Return ""
						End If
						Dim fileName As String = beforeOpenFileEventArgs.FileName
						Dim text3 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + fileName.Replace("/", "\").Trim(New Char() { "\"c })
						If O_O0OO.oO_00Ooo___0._..Contains(fileName.ToLower()) Then
							MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return ""
						End If
						Dim flag As Boolean
						If A_2 IsNot Nothing AndAlso beforeOpenFileEventArgs.AutoUpdate AndAlso OO_00oOO.FileSys.FileExists(text3) AndAlso Not A_2.O_O_0_O0.oOO.(fileName, text3) Then
							flag = True
						End If
						If(Not OO_00oOO.FileSys.FileExists(text3) OrElse flag) AndAlso New O\u3000O\u3000(A_2, fileName, text3).ShowDialog() = DialogResult.Cancel Then
							Return ""
						End If
						If OO_00oOO.FileSys.FileExists(text3) Then
							Return text3
						End If
					End If
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x06004714 RID: 18196 RVA: 0x001D4C94 File Offset: 0x001D2E94
		Friend Function <<EMPTY_NAME>>() As String
			If Operators.CompareString(Oo00.o0.__oO0_., O_O0OO.O_O._Oo.(), True) <> 0 Then
				Oo00.o0.__oO0_. = O_O0OO.O_O._Oo.()
				Oo00.o.OO0. = Oo00.o0.__oO0_.
				Oo00.o.OO0. = o0OO__.O.0ooOoO_0_.(Oo00.o.OO0.)
				Oo00.o.OO0. = Oo00.o.OO0..Substring(0, 6)
			End If
			Return Oo00.o.OO0.
		End Function

		' Token: 0x06004715 RID: 18197 RVA: 0x001D4CEC File Offset: 0x001D2EEC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As DataCol
			Dim num As Integer = A_0.LastIndexOf(".")
			If num > 0 Then
				Dim text As String = A_0.Substring(0, num)
				Dim text2 As String = A_0.Substring(num + 1)
				If Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(text2, "", True) > 0 AndAlso OO_00oOO.Tables.get_Contains(text) AndAlso OO_00oOO.Tables(text).Cols.Contains(text2) Then
					Return OO_00oOO.Tables(text).Cols(text2).DataCol
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x06004716 RID: 18198 RVA: 0x001D4D80 File Offset: 0x001D2F80
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim text As String = ""
			If OO_00oOO.DataTables.Contains("DataTableName") Then
				text = OO_00oOO.DataTables(A_0).Developer
			Else
				Dim developerValider As O_O0OO.DeveloperValider = New O_O0OO.DeveloperValider()
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { A_0, "" })
				If dataRow IsNot Nothing Then
					o_O_o_oOoo__.OOOO_OO._oo.(developerValider, Conversions.ToString(dataRow("Config")), vbVerticalTab)
					text = developerValider.Developer
				End If
			End If
			Dim result As Boolean
			If Operators.CompareString(text, "", True) > 0 AndAlso OO_00oOO.User.Type IsNot Nothing AndAlso Operators.CompareString(OO_00oOO.User.Name, text, True) <> 0 Then
				MessageBox.Show("此表的责任设计者为""" + text + """, 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004717 RID: 18199 RVA: 0x001D4E64 File Offset: 0x001D3064
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			If Oo00.o.00. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(Oo00.o.00., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(Oo00.o.00., flag)
				If Oo00.o.00..State = 0S Then
					Oo00.o.00..State = 2S
					Oo00.o.00. = Nothing
				ElseIf Oo00.o.00..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				Oo00.o.00..State = 1S
				If flag Then
					Monitor.[Exit](Oo00.o.00.)
				End If
			End Try
			If Oo00.OOooo0O_OO._. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(Oo00.OOooo0O_OO._., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag2 As Boolean = False
			Try
				Monitor.Enter(Oo00.OOooo0O_OO._., flag2)
				If Oo00.OOooo0O_OO._..State = 0S Then
					Oo00.OOooo0O_OO._..State = 2S
					Oo00.o.00. = Nothing
				ElseIf Oo00.OOooo0O_OO._..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				Oo00.OOooo0O_OO._..State = 1S
				If flag2 Then
					Monitor.[Exit](Oo00.OOooo0O_OO._.)
				End If
			End Try
			If Operators.CompareString(Oo00.O_.oo00., OO_00oOO.ProjectFile, True) <> 0 Then
				Oo00.O_.oo00. = OO_00oOO.ProjectFile
				Dim text As String = OO_00oOO.ProjectPath + "RemoteFiles\_foxdownloadinfo.mdb"
				If Not OO_00oOO.FileSys.FileExists(text) Then
					Dim catalogClass As CatalogClass = New CatalogClass()
					Dim table As ADOX.Table = New TableClass()
					Guid.NewGuid().ToString()
					catalogClass.Create(Oo00.o00.0OO.(text))
					table = New TableClass()
					table.Name = "Files"
					table.Columns.Append("remfile", 202, 255)
					table.Columns.Append("remtime", 202, 24)
					table.Columns.Append("remsize", 202, 24)
					table.Columns.Append("loctime", 202, 24)
					catalogClass.Tables.Append(table)
					CType(catalogClass.ActiveConnection, Connection).Close()
				End If
				Oo00.o.00. = New OleDbConnection(Oo00.o_._0OOo.(text))
				Oo00.o.00. = New OleDbCommand("", Oo00.o.00.)
			End If
			Oo00.o.00..Open()
			Oo00.o.00..CommandText = "Select Count(*) From [Files] Where [remfile] = '" + A_0 + "'"
			If Conversions.ToInteger(Oo00.o.00..ExecuteScalar()) = 0 Then
				Oo00.o.00..CommandText = String.Concat(New String() { "Insert Into [Files] ([remfile],[remtime],[remsize],[loctime]) Values('", A_0, "','", A_1, "','", A_2, "', '", A_3, "')" })
			Else
				Oo00.o.00..CommandText = String.Concat(New String() { "Update [Files] Set [remtime] = '", A_1, "', [remsize] = '", A_2, "',[locTime] = '", A_3, "' Where [remfile] = '", A_0, "'" })
			End If
			Oo00.o.00..ExecuteNonQuery()
			Oo00.o.00..Close()
		End Sub

		' Token: 0x06004718 RID: 18200 RVA: 0x001D5178 File Offset: 0x001D3378
		Friend Function <<EMPTY_NAME>>(A_0 As Foxtable.Table) As Boolean
			If A_0.AllowBackEndFilter AndAlso Not A_0.IsRelation AndAlso A_0.DataTable.SourceType > 0 Then
				If A_0.Cols(A_0.ColSel).DataCol.IsTemporary Then
					Dim expression As String = A_0.Cols(A_0.ColSel).DataCol.Expression
					If Operators.CompareString(expression, "", True) = 0 Then
						Return False
					End If
					If expression.IndexOf("trim(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If expression.IndexOf("convert", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If expression.IndexOf("Parent(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If expression.IndexOf("Parent.", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If expression.IndexOf("Child(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If expression.IndexOf("Child.", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
					If(o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.DataTable.frd_Connection) OrElse o_O_o_oOoo__.OOOO_OO._oo.(A_0.DataTable.frd_Connection)) AndAlso expression.IndexOf("iif(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
						Return False
					End If
				End If
				If Operators.CompareString(A_0.DataTable.LoadTop, "", True) > 0 Then
					Return True
				End If
			End If
			Return False
		End Function

		' Token: 0x06004719 RID: 18201 RVA: 0x001D52DC File Offset: 0x001D34DC
		Friend Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String) As String
			If o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.frd_Connection) Then
				While True
					Dim num As Integer = A_1.IndexOf("len(", StringComparison.CurrentCultureIgnoreCase)
					If num < 0 Then
						Exit For
					End If
					A_1 = A_1.Substring(0, num) + "LENGTH(" + A_1.Substring(num + 4)
				End While
				While True
					Dim num As Integer = A_1.IndexOf("isnull(", StringComparison.CurrentCultureIgnoreCase)
					If num < 0 Then
						Exit For
					End If
					A_1 = A_1.Substring(0, num) + "NVL(" + A_1.Substring(num + 7)
				End While
				While True
					Dim num As Integer = A_1.IndexOf("substring(", StringComparison.CurrentCultureIgnoreCase)
					If num < 0 Then
						Exit For
					End If
					A_1 = A_1.Substring(0, num) + "SUBSTR(" + A_1.Substring(num + 10)
				End While
			ElseIf Not o_O_o_oOoo__.OOOO_OO._oo.(A_0.frd_Connection) Then
				While True
					Dim num As Integer = A_1.IndexOf("substring(", StringComparison.CurrentCultureIgnoreCase)
					If num < 0 Then
						Exit For
					End If
					A_1 = A_1.Substring(0, num) + "MID(" + A_1.Substring(num + 10)
				End While
			End If
			Return A_1
		End Function

		' Token: 0x0600471A RID: 18202 RVA: 0x001D53CC File Offset: 0x001D35CC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.StartsWith("[") AndAlso A_0.EndsWith("]") Then
				result = A_0
			Else
				result = "{" + A_0 + "}"
			End If
			Return result
		End Function

		' Token: 0x0600471B RID: 18203 RVA: 0x001D540C File Offset: 0x001D360C
		Public Function <<EMPTY_NAME>>(A_0 As AggregateEnum) As String
			Select Case A_0
				Case 2
					Return "合计"
				Case 4
					Return "记录数"
				Case 6
					Return "平均"
				Case 7
					Return "最大"
				Case 8
					Return "最小"
			End Select
			Return ""
		End Function

		' Token: 0x0600471C RID: 18204 RVA: 0x001D5470 File Offset: 0x001D3670
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Oo00.oo_0__0.o.(A_0)
			A_0 = A_0.Replace(vbCr, " ")
			A_0 = A_0.Replace(vbLf, " ")
			A_0 = A_0.Replace("  ", " ")
			A_0 = A_0.Replace("  ", " ")
			Dim array As String() = A_0.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
			Dim str As String
			If Operators.CompareString(array(1), "Distinct", True) = 0 Then
				str = "Select Distinct"
			Else
				str = "Select"
			End If
			Dim num As Integer
			If Operators.CompareString(array(1), "top", True) = 0 Then
				If Operators.CompareString(array(3), "PERCENT", True) = 0 Then
					num = 4
				Else
					num = 3
				End If
			ElseIf Operators.CompareString(array(2), "top", True) = 0 Then
				If Operators.CompareString(array(4), "PERCENT", True) = 0 Then
					num = 5
				Else
					num = 4
				End If
			ElseIf Operators.CompareString(array(1), "Distinct", True) = 0 Then
				num = 2
			Else
				num = 1
			End If
			Dim startIndex As Integer = A_0.IndexOf(" " + array(num) + " ", StringComparison.CurrentCultureIgnoreCase) + 1
			A_0 = str + " " + A_0.Substring(startIndex)
			Return A_0
		End Function

		' Token: 0x0600471D RID: 18205 RVA: 0x001D559C File Offset: 0x001D379C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim flag As Boolean
			Dim num As Integer
			Do
				flag = False
				num += 1
				Dim right As String = A_0 + Conversions.ToString(num)
				Try
					Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current.Name, right, True) = 0 Then
							flag = True
							Exit While
						End If
					End While
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			Loop While flag
			Return A_0 + Conversions.ToString(num)
		End Function

		' Token: 0x0600471E RID: 18206 RVA: 0x001D5614 File Offset: 0x001D3814
		Friend Function <<EMPTY_NAME>>() As Boolean
			Try
				Dim enumerator As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					If enumerator.Current.NeedSaveSetting Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As IEnumerator(Of Foxtable.Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x0600471F RID: 18207 RVA: 0x001D5668 File Offset: 0x001D3868
		Friend Function <<EMPTY_NAME>>(A_0 As List(Of String), A_1 As DataRow, A_2 As DataRow) As Boolean
			Try
				For Each columnName As String In A_0
					If Operators.CompareString(A_1(columnName).ToString(), A_2(columnName).ToString(), True) <> 0 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function

		' Token: 0x04001CFB RID: 7419
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001CFC RID: 7420
		Private <<EMPTY_NAME>> As Integer = 2

		' Token: 0x04001CFD RID: 7421
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001CFE RID: 7422
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001CFF RID: 7423
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D00 RID: 7424
		Private <<EMPTY_NAME>> As OleDbCommand

		' Token: 0x04001D01 RID: 7425
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x04001D02 RID: 7426
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04001D03 RID: 7427
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x02000433 RID: 1075
		Friend Class o0_o_o
			' Token: 0x06004720 RID: 18208 RVA: 0x001D56D8 File Offset: 0x001D38D8
			Public Sub New()
				Me.O0.0_. = Oo00.O_.0_0__o0.()
				Me.O0O.O000. = Me.O0.0_..Substring(24, 4) + o0OO__.o_o.0OOoO0O0.()
				Me.O_o.o_0oOo. = Me.O0.0_..Substring(8, 4)
				Me.O_O0_0_O.o_oo. = Oo00.O_00O_o.0o_.()
				Me.OO0_.o_oOO00. = ""
				Me.OoOO00o.oo. = "A8d5WJZGnluJO/h4uElNcg=="
				Me.O._O_. = "my"
				Me.o_O__0O.o. = "home"
				Me.OOO.o0O0o0_O. = "2048"
				Me.o___o0o._O. = ""
				Me.oOo._. = ""
				Me.OoO.oo0. = ""
				Me.oO0_o0.O0o. = ""
				Me.O0o_.OO0O0. = ""
				Me.o.oO_Oo_0__0o. = ""
				Me.O_oOo._0. = "htm"
			End Sub

			' Token: 0x06004721 RID: 18209 RVA: 0x001D57B8 File Offset: 0x001D39B8
			Friend Function <<EMPTY_NAME>>() As Boolean
				Dim num As Integer
				Dim result As Boolean
				Dim num8 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Me.OOO.o0O0o0_O. = Me.OOO.o0O0o0_O..TrimEnd(New Char() { "."c })
					IL_25:
					num2 = 3
					If Versioned.IsNumeric(Me.OOO.o0O0o0_O.) Then
						GoTo IL_41
					End If
					IL_34:
					num2 = 4
					Me.o.oO_Oo_0__0o. = "web"
					IL_41:
					num2 = 5
					If Conversion.Val(Me.OOO.o0O0o0_O.) <> 0.0 Then
						GoTo IL_66
					End If
					IL_59:
					num2 = 6
					Me.o.oO_Oo_0__0o. = "http"
					IL_66:
					num2 = 7
					If Operators.CompareString(Me.o.oO_Oo_0__0o., "", True) <> 0 Then
						GoTo IL_3A8
					End If
					IL_7E:
					num2 = 8
					Me.o_o0Ooo._O. = CLng(CInt(Math.Floor(Conversion.Val(Me.OOO.o0O0o0_O.))))
					IL_98:
					num2 = 9
					If Me.OOO.o0O0o0_O..IndexOf(".") < 0 Then
						GoTo IL_D1
					End If
					IL_AE:
					num2 = 10
					Me.o___o0o._O. = Me.OOO.o0O0o0_O..Substring(Me.OOO.o0O0o0_O..IndexOf("."c) + 1)
					IL_D1:
					num2 = 11
					If Me.o_o0Ooo._O. <= 0L Then
						GoTo IL_2C4
					End If
					IL_E1:
					num2 = 12
					If Me.o_o0Ooo._O. <> 0L Then
						GoTo IL_FF
					End If
					IL_EC:
					num2 = 13
					Me.o.oO_Oo_0__0o. = "ssl"
					GoTo IL_2C4
					IL_FF:
					num2 = 15
					Me.OOO.o0O0o0_O. = Me.o_o0Ooo._O..ToString()
					IL_113:
					num2 = 16
					Dim num3 As Integer = 1
					Do
						IL_119:
						num2 = 17
						Me.oOo._. = Strings.Right(Me.OOO.o0O0o0_O., 4)
						IL_12E:
						num2 = 18
						Me.o_o0Ooo._O. = Long.Parse(Me.oOo._.)
						IL_142:
						num2 = 19
						Me.oOo._. = Me.o_o0Ooo._O..ToString()
						IL_156:
						num2 = 20
						If num3 = 1 Then
							IL_15E:
							num2 = 21
							Me.O0o_.OO0O0. = Me.oOo._.
						Else
							IL_172:
							num2 = 23
							If Me.o_o0Ooo._O. > 0L Then
								IL_17F:
								num2 = 24
								Me.oO0_o0.O0o. = Me.oOo._. + Conversions.ToString(Me.O_oOo._0.(num3 - 2))
							End If
							IL_1A7:
							num2 = 25
							If Operators.CompareString(Me.O0o_.OO0O0., "", True) > 0 Then
								IL_1BE:
								num2 = 26
								If Me.o_o0Ooo._O. = 0L OrElse Me.OoO.oo0..Length < 4 OrElse Me.oOo._..EndsWith("0") Then
									IL_1E9:
									num2 = 27
									Me.O0o_.OO0O0. = Me.oO0_o0.O0o. + "z" + Me.O0o_.OO0O0.
								Else
									IL_20A:
									num2 = 29
									Me.O0o_.OO0O0. = Me.oO0_o0.O0o. + Me.O0o_.OO0O0.
								End If
							Else
								IL_226:
								num2 = 31
								Me.O0o_.OO0O0. = Me.oO0_o0.O0o.
							End If
						End If
						IL_235:
						num2 = 32
						Me.OoO.oo0. = Me.oOo._.
						IL_244:
						num2 = 33
						If Me.OOO.o0O0o0_O..Length <= 4 Then
							Exit Do
						End If
						IL_255:
						num2 = 36
						Me.OOO.o0O0o0_O. = Me.OOO.o0O0o0_O..Substring(0, Me.OOO.o0O0o0_O..Length - 4)
						IL_277:
						num2 = 37
						num3 += 1
					Loop While num3 <= 4
					IL_288:
					num2 = 38
					Me.O0o_.OO0O0. = Me.O0o_.OO0O0..Replace("ftp", "")
					IL_2A6:
					num2 = 39
					Me.O0o_.OO0O0. = Me.O0o_.OO0O0..Replace("http", "d")
					IL_2C4:
					num2 = 40
					If Operators.CompareString(Me.o___o0o._O., "", True) <= 0 Then
						GoTo IL_397
					End If
					IL_2DE:
					num2 = 41
					If Operators.CompareString(Me.O0o_.OO0O0., "", True) <> 0 Then
						GoTo IL_304
					End If
					IL_2F4:
					num2 = 42
					Me.O0o_.OO0O0. = "https"
					GoTo IL_31D
					IL_304:
					num2 = 44
					Me.O0o_.OO0O0. += "sll"
					IL_31D:
					num2 = 45
					Dim num4 As Integer = Me.o___o0o._O..Length - Me.o___o0o._O..TrimStart(New Char() { "0"c }).Length
					IL_349:
					num2 = 46
					If num4 <= 0 Then
						GoTo IL_373
					End If
					IL_351:
					num2 = 47
					Me.O0o_.OO0O0. += "w".PadLeft(num4, "w"c)
					IL_373:
					num2 = 48
					Me.O0o_.OO0O0. += Conversions.ToString(Conversions.ToInteger(Me.o___o0o._O.))
					IL_397:
					num2 = 49
					Me.o.oO_Oo_0__0o. = Me.O0o_.OO0O0.
					GoTo IL_3B7
					IL_3A8:
					num2 = 51
					Me.o.oO_Oo_0__0o. = Me.O0o_.OO0O0.
					IL_3B7:
					num2 = 52
					If Operators.CompareString(Me.o.oO_Oo_0__0o., Me.O0o_.OO0O0., True) <> 0 Then
						GoTo IL_655
					End If
					IL_3D1:
					num2 = 53
					If Operators.CompareString(Me.O_O0_0_O.o_oo., "", True) <> 0 Then
						GoTo IL_3F1
					End If
					IL_3E7:
					num2 = 54
					result = False
					GoTo IL_655
					IL_3F1:
					num2 = 55
					Dim o_O0_0_O.o_oo. As String = Me.O_O0_0_O.o_oo.
					IL_3FC:
					num2 = 56
					Me.O_O0_0_O.o_oo. = o0OO__.oOO.o_.()
					IL_40A:
					num2 = 57
					Integer.TryParse(Me.O0O.O000., Me.O0.0_.)
					IL_41F:
					num2 = 58
					Integer.TryParse(Me.O_o.o_0oOo., Me.O_o.o_0oOo.)
					IL_434:
					num2 = 59
					If Me.O_o.o_0oOo. <> 0 Then
						GoTo IL_44A
					End If
					IL_43F:
					num2 = 60
					Me.O_o.o_0oOo. = 17
					IL_44A:
					num2 = 61
					Me.O00O.00_0_. = Me.O0.0_.(Me.O0.0_., Me.O_o.o_0oOo.)
					IL_465:
					num2 = 62
					Me.O0O.O000. = O00.EncryptText(Me.O00O.00_0_., "my", "home")
					IL_483:
					num2 = 63
					Me.oOO.o_O. = O00.ooo000o_0.00o0.(Me.O0O.O000., Me.O._O_., Me.o_O__0O.o.)
					IL_4A3:
					num2 = 64
					Me.O0O.O000. = o_O_o_oOoo__.OOOO_OO._oo.(O00.MD5Encrypt(Me.oOO.o_O.).Trim(New Char() { "="c }))
					IL_4CC:
					num2 = 65
					Me.OO0_.o_oOO00. = ""
					IL_4DA:
					num2 = 66
					Dim num5 As Integer = 0
					Do
						IL_4E0:
						num2 = 67
						Me.OO0_.o_oOO00. += Conversions.ToString(CInt((Me.O0O.O000.(num5) Mod vbTab + ChrW(1))))
						IL_50B:
						num2 = 68
						num5 += 1
					Loop While num5 <= 7
					IL_519:
					num2 = 69
					Me.O.__OO_o0_o. = Me.O0.0_.(Conversions.ToInteger(Me.OO0_.o_oOO00.))
					IL_533:
					num2 = 70
					Dim a_ As String = O00.ooo000o_0.00o0.(Me.O.__OO_o0_o., o_O0_0_O.o_oo..Substring(4, 4), o_O0_0_O.o_oo..Substring(8, 4))
					IL_555:
					num2 = 71
					Me.O0O.O000. = o_o_O0OO_0__.o000oOoo.0.(a_)
					IL_565:
					num2 = 72
					Me.OO0_.o_oOO00. = ""
					IL_573:
					num2 = 73
					Dim num6 As Integer = 0
					Do
						IL_579:
						num2 = 74
						Me.OO0_.o_oOO00. += Conversions.ToString(CInt((Me.O0O.O000.(num6) Mod vbTab + ChrW(1))))
						IL_5A4:
						num2 = 75
						num6 += 1
					Loop While num6 <= 3
					IL_5B2:
					num2 = 76
					Integer.TryParse(Me.OO0_.o_oOO00., Me.O0.0_.)
					IL_5C7:
					num2 = 77
					Integer.TryParse(Me.O_O0_0_O.o_oo., Me.OO_0_0_O00.o.)
					IL_5DC:
					num2 = 78
					If Operators.CompareString(O00.EncryptText((Me.O0.0_. + Me.OO_0_0_O00.o.).ToString(), Me.O._O_., Me.o_O__0O.o.), Me.OoOO00o.oo., True) <> 0 AndAlso Operators.CompareString(O00.EncryptText((Me.O0.0_. - Me.OO_0_0_O00.o.).ToString(), Me.O._O_., Me.o_O__0O.o.), Me.OoOO00o.oo., True) <> 0 Then
						GoTo IL_650
					End If
					IL_649:
					num2 = 79
					result = True
					GoTo IL_655
					IL_650:
					num2 = 81
					result = False
					IL_655:
					GoTo IL_7EF
					IL_65A:
					Dim num7 As Integer = num8 + 1
					num8 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
					IL_7B0:
					GoTo IL_7E4
					IL_7B2:
					num8 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_7C2:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_7B2
				End Try
				IL_7E4:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_7EF:
				If num8 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x06004722 RID: 18210 RVA: 0x001D5FDC File Offset: 0x001D41DC
			Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As String
				Dim num As Integer
				Dim result As String
				Dim num6 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Dim text As String = ""
					IL_10:
					num2 = 3
					A_0 += 1111
					IL_1B:
					num2 = 4
					If A_0 Mod A_1 <> 0 Then
						GoTo IL_29
					End If
					IL_22:
					num2 = 5
					A_0 += 7
					IL_29:
					num2 = 6
					Dim num3 As Integer = 1
					Do
						IL_2E:
						num2 = 7
						Dim num4 As Integer = A_0 / A_1
						IL_35:
						num2 = 8
						text += Conversions.ToString(num4)
						IL_47:
						num2 = 9
						A_0 = (A_0 - A_1 * num4) * 10
						IL_55:
						num2 = 10
						num3 += 1
					Loop While num3 <= 1000
					IL_67:
					num2 = 11
					text = text.Trim(New Char() { "0"c })
					IL_7E:
					num2 = 12
					If text.Length > 8 Then
						GoTo IL_94
					End If
					IL_8B:
					num2 = 13
					Dim text2 As String = text
					GoTo IL_AA
					IL_94:
					num2 = 15
					text2 = text.Substring(text.Length - 8, 8)
					IL_AA:
					num2 = 16
					result = text2
					IL_B0:
					GoTo IL_146
					IL_B5:
					Dim num5 As Integer = num6 + 1
					num6 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
					IL_107:
					GoTo IL_13B
					IL_109:
					num6 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_119:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_109
				End Try
				IL_13B:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_146:
				If num6 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x06004723 RID: 18211 RVA: 0x001D6154 File Offset: 0x001D4354
			Private Function <<EMPTY_NAME>>(A_0 As Integer) As String
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
					Dim text As String = ""
					IL_10:
					num2 = 3
					Dim text2 As String = "lyeshwiqbjs"
					IL_19:
					num2 = 4
					Dim dateTime As DateTime = New DateTime(598950720000000000L).AddDays(CDbl((A_0 Mod 9999)))
					IL_3C:
					num2 = 5
					Dim year As Integer = dateTime.Year
					IL_47:
					num2 = 6
					Dim month As Integer = dateTime.Month
					IL_52:
					num2 = 7
					Dim day As Integer = dateTime.Day
					IL_5D:
					num2 = 8
					Dim text3 As String = year.ToString()
					IL_68:
					num2 = 9
					Dim text4 As String = ""
					IL_72:
					num2 = 10
					Dim str As String = ""
					IL_7C:
					num2 = 11
					Dim str2 As String = ""
					IL_86:
					num2 = 12
					Dim num3 As Integer = text3.Length - 1
					For i As Integer = 0 To num3
						IL_99:
						num2 = 13
						text4 += Conversions.ToString(text2(Integer.Parse(Conversions.ToString(text3(i)))))
						IL_C4:
						num2 = 14
					Next
					IL_D3:
					num2 = 15
					If month >= 10 Then
						GoTo IL_FB
					End If
					IL_DC:
					num2 = 16
					str = "ling" + Conversions.ToString(text2(month))
					GoTo IL_130
					IL_FB:
					num2 = 18
					If month <> 10 Then
						GoTo IL_110
					End If
					IL_104:
					num2 = 19
					str = "yishi"
					GoTo IL_130
					IL_110:
					num2 = 21
					str = "yishi" + Conversions.ToString(text2(month Mod 10))
					IL_130:
					num2 = 22
					If day >= 10 Then
						GoTo IL_158
					End If
					IL_139:
					num2 = 23
					str2 = "ling" + Conversions.ToString(text2(day))
					GoTo IL_1C4
					IL_158:
					num2 = 25
					If day >= 10 Then
						GoTo IL_180
					End If
					IL_161:
					num2 = 26
					str2 = "ling" + Conversions.ToString(text2(10))
					GoTo IL_1C4
					IL_180:
					num2 = 28
					str2 = Strings.Mid(text2, day / 10 + 1, 1) + "shi"
					IL_19E:
					num2 = 29
					If day Mod 10 <= 0 Then
						GoTo IL_1C4
					End If
					IL_1A9:
					num2 = 30
					str2 += Strings.Mid(text2, day Mod 10 + 1, 1)
					IL_1C4:
					num2 = 31
					For Each b As Byte In Encoding.Unicode.GetBytes(str2 + text4 + str)
						IL_1EA:
						num2 = 32
						text += b.ToString()
						IL_1FD:
						num2 = 33
					Next
					IL_20E:
					num2 = 34
					result = text
					IL_214:
					GoTo IL_2F2
					IL_219:
					Dim num4 As Integer = num5 + 1
					num5 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
					IL_2B3:
					GoTo IL_2E7
					IL_2B5:
					num5 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_2C5:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_2B5
				End Try
				IL_2E7:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_2F2:
				If num5 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x04001D04 RID: 7428
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D05 RID: 7429
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D06 RID: 7430
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D07 RID: 7431
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D08 RID: 7432
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D09 RID: 7433
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04001D0A RID: 7434
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04001D0B RID: 7435
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04001D0C RID: 7436
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D0D RID: 7437
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D0E RID: 7438
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D0F RID: 7439
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D10 RID: 7440
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D11 RID: 7441
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D12 RID: 7442
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D13 RID: 7443
			Private <<EMPTY_NAME>> As Long

			' Token: 0x04001D14 RID: 7444
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D15 RID: 7445
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D16 RID: 7446
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D17 RID: 7447
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D18 RID: 7448
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D19 RID: 7449
			Private <<EMPTY_NAME>> As String

			' Token: 0x04001D1A RID: 7450
			Private <<EMPTY_NAME>> As String
		End Class
	End Module
End Namespace
