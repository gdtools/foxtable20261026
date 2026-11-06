Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x02000530 RID: 1328
	Public NotInheritable Module Table
		' Token: 0x060057ED RID: 22509 RVA: 0x0022D04B File Offset: 0x0022B24B
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return True
		End Function

		' Token: 0x060057EE RID: 22510 RVA: 0x0022D04E File Offset: 0x0022B24E
		<oO0oooo("0003")>
		Public Sub AddDataTable()
		End Sub

		' Token: 0x060057EF RID: 22511 RVA: 0x0022D050 File Offset: 0x0022B250
		<oO0oooo("0193")>
		Public Sub ModiStructure()
		End Sub

		' Token: 0x060057F0 RID: 22512 RVA: 0x0022D052 File Offset: 0x0022B252
		<oO0oooo("0192")>
		Public Sub Copy()
		End Sub

		' Token: 0x060057F1 RID: 22513 RVA: 0x0022D054 File Offset: 0x0022B254
		<oO0oooo("0626")>
		Public Sub AddTemporaryTable()
		End Sub

		' Token: 0x060057F2 RID: 22514 RVA: 0x0022D056 File Offset: 0x0022B256
		<oO0oooo("1812")>
		Public Sub OuterTableManager()
		End Sub

		' Token: 0x060057F3 RID: 22515 RVA: 0x0022D058 File Offset: 0x0022B258
		<oO0oooo("2321")>
		Public Sub QueryManager()
		End Sub

		' Token: 0x060057F4 RID: 22516 RVA: 0x0022D05A File Offset: 0x0022B25A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddOuterTable()
		End Sub

		' Token: 0x060057F5 RID: 22517 RVA: 0x0022D05C File Offset: 0x0022B25C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ModifyOuterTableSetting()
		End Sub

		' Token: 0x060057F6 RID: 22518 RVA: 0x0022D05E File Offset: 0x0022B25E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddOuterQuery()
		End Sub

		' Token: 0x060057F7 RID: 22519 RVA: 0x0022D060 File Offset: 0x0022B260
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ModifyOuterQuerySetting()
		End Sub

		' Token: 0x060057F8 RID: 22520 RVA: 0x0022D062 File Offset: 0x0022B262
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddInnerQuery()
		End Sub

		' Token: 0x060057F9 RID: 22521 RVA: 0x0022D064 File Offset: 0x0022B264
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ModifyInnerQuery()
		End Sub

		' Token: 0x060057FA RID: 22522 RVA: 0x0022D066 File Offset: 0x0022B266
		<oO0oooo("0022")>
		Public Sub Delete()
		End Sub

		' Token: 0x060057FB RID: 22523 RVA: 0x0022D068 File Offset: 0x0022B268
		<oO0oooo("0009")>
		Public Sub Rename()
		End Sub

		' Token: 0x060057FC RID: 22524 RVA: 0x0022D06C File Offset: 0x0022B26C
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			OO_00oOO.Forms.ooO0_o._o.()
			Dim text As String = A_0.Name
			Dim text2 As String = A_0.Caption
			Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(text, text2)
			If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK AndAlso (Operators.CompareString(o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(), text2, True) <> 0 OrElse Operators.CompareString(o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.(), text, True) <> 0) Then
				Dim text3 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
				Dim text4 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
				A_0.Caption = text4
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.foxGrid.FindForm() IsNot Nothing AndAlso table.DataTable Is A_0 Then
							table._frdTableLayout.OOooOOo_.0_0_o.()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If Operators.CompareString(text4, text2, True) <> 0 Then
					A_0.OO00_o.ooOO.(False)
				End If
				If Operators.CompareString(text, text3, True) = 0 Then
					OO_00oOO.Tables(A_0.Name).O__0.0.(text)
					Return
				End If
				If Not OO_00oOO.DataTables(text).AddByCode Then
					If OO_00oOO.DataTables(text).frd_IsTemporary Then
						Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()).Rows.Find(text)
						If dataRow IsNot Nothing Then
							dataRow("Name") = text3
						End If
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()), True)
					ElseIf OO_00oOO.DataTables(text).frd_IsInnerTable Then
						Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
						o_oo.o0_oo0._.().O.0_O.(text).Name = text3
						o_oo.o0_oo0._.(False, False)
						OO_00oOO.DataTables(text).O0_o_0_.O.("~TMPCLP" + text3)
						o_oo.ooo.0.()
					Else
						Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Find(text)
						If dataRow2 IsNot Nothing Then
							dataRow2("Name") = text3
						End If
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					End If
				End If
				OO_00oOO.SystemReady = False
				ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
				Try
					Try
						For Each table2 As Table In OO_00oOO.Tables
							table2.StopRedraw()
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of Table)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
					Dim list As List(Of O_0) = New List(Of O_0)()
					Dim dataTable As DataTable = OO_00oOO.DataTables(text)
					O_O0OO.OOOo.oo_OOOO_0.().Tables(text).TableName = text3
					OO_00oOO.DataTables.OoO_00.O.(text)
					OO_00oOO.DataTables.OO0o00.0O_0o.(dataTable)
					Try
						For Each o_ As O_0 In O_O0OO.o__.O.().Values
							Dim text5 As String = o_.Oo._Oo0OO.()
							If Operators.CompareString(o_.Oo._Oo0OO.(), text, True) = 0 Then
								o_.oO._o0_o.(text3)
							ElseIf o_.Oo._Oo0OO.().StartsWith(text + ".") Then
								o_.oO._o0_o.(text3 + o_.Oo._Oo0OO.().Substring(o_.Oo._Oo0OO.().IndexOf(".")))
							ElseIf o_.Oo._Oo0OO.().EndsWith("." + text) Then
								o_.oO._o0_o.(o_.Oo._Oo0OO.().Substring(0, o_.Oo._Oo0OO.().LastIndexOf(".") + 1) + text3)
							ElseIf o_.Oo._Oo0OO.().IndexOf("." + text + ".", StringComparison.CurrentCultureIgnoreCase) > 0 Then
								o_.oO._o0_o.(o_.Oo._Oo0OO.().Replace("." + text + ".", "." + text3 + "."))
							End If
							If Operators.CompareString(o_.Oo._Oo0OO.(), text5, True) <> 0 Then
								Try
									For Each table3 As Table In OO_00oOO.Tables
										If table3.View Is o_ Then
											OO_00oOO.Tables.OO._O_o__.(table3)
											OO_00oOO.Tables.Ooo.0OOoO_0.(table3)
											If Operators.CompareString(o_.DataMember, text, True) = 0 Then
												o_.DataMember = text3
											End If
											table3.O__0.0.(text5)
											list.Add(o_)
											Exit For
										End If
									Next
								Finally
									Dim enumerator4 As IEnumerator(Of Table)
									If enumerator4 IsNot Nothing Then
										enumerator4.Dispose()
									End If
								End Try
							End If
						Next
					Finally
						Dim enumerator3 As Dictionary(Of String, O_0).ValueCollection.Enumerator
						CType(enumerator3, IDisposable).Dispose()
					End Try
					Try
						For Each o_2 As O_0 In list
							Try
								For Each key As String In O_O0OO.o__.O.().Keys
									If O_O0OO.o__.O.()(key) Is o_2 Then
										O_O0OO.o__.O.().Remove(key)
										O_O0OO.o__.O.().Add(o_2.Oo._Oo0OO.(), o_2)
										Exit For
									End If
								Next
							Finally
								Dim enumerator6 As Dictionary(Of String, O_0).KeyCollection.Enumerator
								CType(enumerator6, IDisposable).Dispose()
							End Try
						Next
					Finally
						Dim enumerator5 As List(Of O_0).Enumerator
						CType(enumerator5, IDisposable).Dispose()
					End Try
					If dataTable.frd_IsInnerTable Then
						Dim oleDbCommand As OleDbCommand = New OleDbCommand("", dataTable.frd_Connection)
						oleDbCommand.CommandText = String.Concat(New String() { "Update [", ooO0__OO.O00.O__o.(), "] Set [Table] = '~TMPCLP", text3, "' Where [Table] = '~TMPCLP", text, "'" })
						dataTable.frd_Connection.Open()
						oleDbCommand.ExecuteNonQuery()
						dataTable.frd_Connection.Close()
					End If
					Table.OO.OO_0o.(text, text3)
					Try
						For Each table4 As Table In OO_00oOO.Tables
							table4.O.__O0o0.(True, False)
							If table4.DataTable Is A_0 Then
								table4._frdTableLayout.Oo_.oo_oOo_oO.()
							End If
							table4.ResumeRedraw()
						Next
					Finally
						Dim enumerator7 As IEnumerator(Of Table)
						If enumerator7 IsNot Nothing Then
							enumerator7.Dispose()
						End If
					End Try
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					ShareLibriay.LockWindowUpdate(IntPtr.Zero)
					OO_00oOO.SystemReady = True
				End Try
			End If
		End Sub

		' Token: 0x060057FD RID: 22525 RVA: 0x0022D75C File Offset: 0x0022B95C
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow("Table")), A_0, True) = 0 Then
						dataRow("Table") = A_1
					End If
					If Operators.CompareString(Conversions.ToString(dataRow("Table")), "[" + A_0 + "]", True) = 0 Then
						dataRow("Table") = "[" + A_1 + "]"
					End If
					If Operators.CompareString(Conversions.ToString(dataRow("Table")), "{" + A_0 + "}", True) = 0 Then
						dataRow("Table") = "{" + A_1 + "}"
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
			Try
				For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow2("Table")), A_0, True) = 0 Then
						dataRow2("Table") = A_1
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
			Try
				For Each obj3 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()).Rows
					Dim dataRow3 As DataRow = CType(obj3, DataRow)
					If Not dataRow3.IsNull("Table") AndAlso Operators.CompareString(Conversions.ToString(dataRow3("Table")), A_0, True) = 0 Then
						dataRow3("Table") = A_1
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()), True)
			Try
				For Each obj4 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows
					Dim dataRow4 As DataRow = CType(obj4, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow4("Table")), A_0, True) = 0 Then
						dataRow4("Table") = A_1
					End If
				Next
			Finally
				Dim enumerator4 As IEnumerator
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()), True)
			Try
				For Each obj5 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows
					Dim dataRow5 As DataRow = CType(obj5, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow5("ParentTable")), A_0, True) = 0 Then
						dataRow5("ParentTable") = A_1
					End If
					If Operators.CompareString(Conversions.ToString(dataRow5("ChildTable")), A_0, True) = 0 Then
						dataRow5("ChildTable") = A_1
					End If
				Next
			Finally
				Dim enumerator5 As IEnumerator
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()), True)
			Dim file As String = String.Concat(New String() { OO_00oOO.ProjectPath, "Bin\", o0OoOOoOOo0.oo00o.0OoO.(""), ".DataTable.", A_0, ".dll" })
			If OO_00oOO.FileSys.FileExists(file) Then
				OO_00oOO.FileSys.RenameFile(file, o0OoOOoOOo0.oo00o.0OoO.("") + ".DataTable." + A_1 + ".dll")
			End If
		End Sub

		' Token: 0x060057FE RID: 22526 RVA: 0x0022DBA8 File Offset: 0x0022BDA8
		<oO0oooo("0091")>
		Public Sub ModifyDataRelation()
		End Sub

		' Token: 0x060057FF RID: 22527 RVA: 0x0022DBAA File Offset: 0x0022BDAA
		<oO0oooo("0011")>
		Public Sub ModifyProperty()
			If ooO.oo__.O000_o_O.() AndAlso OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.DataTable.AddByCode
			End If
		End Sub

		' Token: 0x06005800 RID: 22528 RVA: 0x0022DBCA File Offset: 0x0022BDCA
		<oO0oooo("0656")>
		Public Sub ModifyUserCellStyle()
			If ooO.oo__.O000_o_O.() AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso Not OO_00oOO.CurrentTable.DataTable.AddByCode Then
				New O\u3002\u3002\u3000\u3000\u3000\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005801 RID: 22529 RVA: 0x0022DC00 File Offset: 0x0022BE00
		<oO0oooo("0013")>
		Public Sub ModifyLookAndFeel()
			If ooO.oo__.O000_o_O.() AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso Not OO_00oOO.CurrentTable.DataTable.AddByCode Then
				New O\u30020\u3002O\u3000\u3002\u3002\u3002\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005802 RID: 22530 RVA: 0x0022DC36 File Offset: 0x0022BE36
		<oO0oooo("0157")>
		Public Sub SetMergeMode()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New O\u3000\u3000\u3000\u3000_\u3002(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005803 RID: 22531 RVA: 0x0022DC50 File Offset: 0x0022BE50
		<oO0oooo("0157")>
		Public Sub ToggleMergeMode()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.ClearEditInfos()
				If OO_00oOO.CurrentTable.MergeCols.Count > 0 Then
					OO_00oOO.CurrentTable.AllowMerge = Not OO_00oOO.CurrentTable.AllowMerge
					Return
				End If
				Table.SetMergeMode()
			End If
		End Sub

		' Token: 0x06005804 RID: 22532 RVA: 0x0022DC9D File Offset: 0x0022BE9D
		<oO0oooo("00144")>
		Public Sub SetSubtotalMode()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New du(OO_00oOO.CurrentTable, False).ShowDialog()
			End If
		End Sub

		' Token: 0x06005805 RID: 22533 RVA: 0x0022DCB7 File Offset: 0x0022BEB7
		<oO0oooo("00144")>
		Public Sub ReSubtotal()
			If OO_00oOO.CurrentTable IsNot Nothing AndAlso OO_00oOO.CurrentTable.SubtotalGroups.Count > 0 Then
				If Not OO_00oOO.CurrentTable.IsSubtotal Then
					OO_00oOO.CurrentTable.ClearEditInfos()
				End If
				OO_00oOO.CurrentTable.Subtotal(False)
			End If
		End Sub

		' Token: 0x06005806 RID: 22534 RVA: 0x0022DCF3 File Offset: 0x0022BEF3
		<oO0oooo("00144")>
		Public Sub NewSubtotalMode()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New du(OO_00oOO.CurrentTable, True).ShowDialog()
			End If
		End Sub

		' Token: 0x06005807 RID: 22535 RVA: 0x0022DD10 File Offset: 0x0022BF10
		<oO0oooo("00144")>
		Public Sub ToggleSubtotalMode()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.foxGrid
				If OO_00oOO.CurrentTable.IsSubtotal Then
					OO_00oOO.CurrentTable.Sort = ""
					OO_00oOO.CurrentTable.ClearEditInfos()
					OO_00oOO.CurrentTable.ClearSubtotal()
				ElseIf OO_00oOO.CurrentTable.SubtotalGroups.Count > 0 Then
					OO_00oOO.CurrentTable.ClearEditInfos()
					OO_00oOO.CurrentTable.Subtotal(False)
				Else
					Table.SetSubtotalMode()
				End If
			End If
		End Sub

		' Token: 0x06005808 RID: 22536 RVA: 0x0022DD90 File Offset: 0x0022BF90
		<oO0oooo("2748")>
		Public Sub ToggleGrandTotal()
			If OO_00oOO.CurrentTable IsNot Nothing AndAlso Not OO_00oOO.CurrentTable.IsSubtotal AndAlso Not OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.() Then
				If Not OO_00oOO.CurrentTable.GrandTotal Then
					Dim num As Integer
					Try
						For Each col As Col In OO_00oOO.CurrentTable.Cols
							If col.GrandTotal AndAlso col.IsNumeric() Then
								num += 1
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Col)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					If num <> 0 Then
						OO_00oOO.CurrentTable.ClearSubtotal()
						OO_00oOO.CurrentTable.GrandTotal = True
						Dim c1FlexGrid As C1FlexGrid = OO_00oOO.CurrentTable.Grid
						c1FlexGrid.TopRow = c1FlexGrid.Rows.Count - 1
						Return
					End If
					If Operators.CompareString(OO_00oOO.CurrentTable.ooo_O0oOo.0O., "", True) > 0 Then
						For Each text As String In OO_00oOO.CurrentTable.ooo_O0oOo.0O..Split(New Char() { ","c })
							If OO_00oOO.CurrentTable.Cols.Contains(text) AndAlso OO_00oOO.CurrentTable.Cols(text).IsNumeric() Then
								OO_00oOO.CurrentTable.Cols(text).GrandTotal = True
								num += 1
							End If
						Next
					End If
					If num = 0 Then
						Table.SetGrandTotal()
						Return
					End If
					OO_00oOO.CurrentTable.ClearSubtotal()
					OO_00oOO.CurrentTable.GrandTotal = True
					Dim c1FlexGrid2 As C1FlexGrid = OO_00oOO.CurrentTable.Grid
					c1FlexGrid2.TopRow = c1FlexGrid2.Rows.Count - 1
					Return
				Else
					OO_00oOO.CurrentTable.GrandTotal = False
				End If
			End If
		End Sub

		' Token: 0x06005809 RID: 22537 RVA: 0x0022DF40 File Offset: 0x0022C140
		<oO0oooo("2748")>
		Public Sub SetGrandTotal()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New o\u30000(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x0600580A RID: 22538 RVA: 0x0022DF5C File Offset: 0x0022C15C
		Public Sub ChangeFont()
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = OO_00oOO.CurrentTable.Font
			If fontDialog.ShowDialog() = DialogResult.OK Then
				OO_00oOO.CurrentTable.Font = fontDialog.Font
				OO_00oOO.CurrentTable.NeedSaveSetting = True
			End If
		End Sub

		' Token: 0x0600580B RID: 22539 RVA: 0x0022DFA4 File Offset: 0x0022C1A4
		Public Sub ChangeFontName(FontName As String)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Font = New Font(FontName, OO_00oOO.CurrentTable.Font.Size, OO_00oOO.CurrentTable.Font.Style)
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				If o_oOooO_O.TopRow > 0 Then
					o_oOooO_O.AutoSizeCols(o_oOooO_O.TopRow, 0, o_oOooO_O.BottomRow, 0, 0, 0)
				End If
			End If
		End Sub

		' Token: 0x0600580C RID: 22540 RVA: 0x0022E014 File Offset: 0x0022C214
		Public Sub ChangeFontSize(FontSize As Integer)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Font = New Font(OO_00oOO.CurrentTable.Font.Name, CSng(FontSize), OO_00oOO.CurrentTable.Font.Style)
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				If o_oOooO_O.TopRow > 0 Then
					o_oOooO_O.AutoSizeCols(o_oOooO_O.TopRow, 0, o_oOooO_O.BottomRow, 0, 0, 0)
				End If
			End If
		End Sub

		' Token: 0x0600580D RID: 22541 RVA: 0x0022E083 File Offset: 0x0022C283
		Public Sub ToggleFontBold()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Font = New Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style Xor FontStyle.Bold)
			End If
		End Sub

		' Token: 0x0600580E RID: 22542 RVA: 0x0022E0B6 File Offset: 0x0022C2B6
		Public Sub ToggleFontItalic()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Font = New Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style Xor FontStyle.Italic)
			End If
		End Sub

		' Token: 0x0600580F RID: 22543 RVA: 0x0022E0E9 File Offset: 0x0022C2E9
		Public Sub ToggleFontUnderLine()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Font = New Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style Xor FontStyle.Underline)
			End If
		End Sub

		' Token: 0x06005810 RID: 22544 RVA: 0x0022E11C File Offset: 0x0022C31C
		Public Sub ChangeBackColor(color As Color)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is OO_00oOO.CurrentTable.DataTable Then
							If table.foxGrid.Styles.Normal.BackColor = table.foxGrid.Styles.Alternate.BackColor Then
								table.foxGrid.Styles.Alternate.BackColor = color
							End If
							table.foxGrid.Styles.Normal.BackColor = color
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.BackColor = color
			End If
		End Sub

		' Token: 0x06005811 RID: 22545 RVA: 0x0022E1F0 File Offset: 0x0022C3F0
		Public Sub ChangeForeColor(color As Color)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is OO_00oOO.CurrentTable.DataTable Then
							If table.foxGrid.Styles.Normal.ForeColor = table.foxGrid.Styles.Alternate.ForeColor Then
								table.foxGrid.Styles.Alternate.ForeColor = color
							End If
							table.foxGrid.Styles.Normal.ForeColor = color
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.ForeColor = color
			End If
		End Sub

		' Token: 0x06005812 RID: 22546 RVA: 0x0022E2C4 File Offset: 0x0022C4C4
		Public Sub ChangeAlterBackColor(color As Color)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is OO_00oOO.CurrentTable.DataTable Then
							If color = table.foxGrid.Styles.Normal.BackColor Then
								table.foxGrid.Styles.Alternate.Clear(2)
							Else
								table.foxGrid.Styles.Alternate.BackColor = color
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.AlterRowBackColor = color
			End If
		End Sub

		' Token: 0x06005813 RID: 22547 RVA: 0x0022E388 File Offset: 0x0022C588
		Public Sub ChangeGridLineColor(color As Color)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is OO_00oOO.CurrentTable.DataTable Then
							table.foxGrid.Styles.Normal.Border.Color = color
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.GridColor = color
			End If
		End Sub

		' Token: 0x06005814 RID: 22548 RVA: 0x0022E418 File Offset: 0x0022C618
		Public Sub ChangeGridLineDirection(Direction As GridLineDirectionEnum)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is OO_00oOO.CurrentTable.DataTable Then
							If table.foxGrid.Styles.Normal.Border.Style Is Nothing Then
								table.foxGrid.Styles.Normal.Border.Style = 1
							End If
							Select Case Direction
								Case 0
									table.foxGrid.Styles.Normal.Border.Direction = 0
								Case 1
									table.foxGrid.Styles.Normal.Border.Direction = 1
								Case 2
									table.foxGrid.Styles.Normal.Border.Direction = 2
							End Select
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.GridLineDirection = Direction
			End If
		End Sub

		' Token: 0x06005815 RID: 22549 RVA: 0x0022E53C File Offset: 0x0022C73C
		<oO0oooo("")>
		Public Sub ToggleSortAndFilter()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.ClearEditInfos()
				If Operators.CompareString(table.View.get_Filter(), "", True) > 0 OrElse Operators.CompareString(table.View.oO_O.o_OOO.(), "", True) > 0 OrElse table.DataTable.InBackEndFilterMode Then
					If Operators.CompareString(table.View.oO_O.o_OOO.(), "", True) > 0 Then
						table.ApplySort = False
					Else
						table.View.o_O_.00o.("")
						table.View.O00o0.0_0O_.()
					End If
					If Operators.CompareString(table.View.get_Filter(), "", True) > 0 Then
						table.ApplyFilter = False
					Else
						table.View.Oo._Oo0OO.("")
					End If
					If table.AllowBackEndFilter Then
						table.DataTable.OOo_00.oo.()
						Return
					End If
				Else
					table.ApplySort = True
					If table.AllowBackEndFilter Then
						table.DataTable.OOo_00.oo.()
						Return
					End If
					table.ApplyFilter = True
				End If
			End If
		End Sub

		' Token: 0x06005816 RID: 22550 RVA: 0x0022E644 File Offset: 0x0022C844
		<oO0oooo("0034")>
		Public Sub Lock()
			If OO_00oOO.DataTables.AllowEdit AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso Not OO_00oOO.CurrentTable.DataTable.frd_IsInnerQuery AndAlso Not OO_00oOO.CurrentTable.DataTable.frd_IsOuterQuery Then
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(New O_000O(OO_00oOO.CurrentTable.DataTable))
				OO_00oOO.CurrentTable.DataTable.AllowEdit = False
			End If
		End Sub

		' Token: 0x06005817 RID: 22551 RVA: 0x0022E6B4 File Offset: 0x0022C8B4
		<oO0oooo("0034")>
		Public Sub Unlock()
			If OO_00oOO.DataTables.AllowEdit AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso Not OO_00oOO.CurrentTable.DataTable.frd_IsInnerQuery AndAlso Not OO_00oOO.CurrentTable.DataTable.frd_IsOuterQuery Then
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(New O_000O(OO_00oOO.CurrentTable.DataTable))
				OO_00oOO.CurrentTable.DataTable.AllowEdit = True
			End If
		End Sub

		' Token: 0x06005818 RID: 22552 RVA: 0x0022E724 File Offset: 0x0022C924
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub GetAllValue()
		End Sub

		' Token: 0x06005819 RID: 22553 RVA: 0x0022E728 File Offset: 0x0022C928
		<oO0oooo("0180")>
		Public Sub ExportToText()
			Dim o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u As o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 = New o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000()
			If o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.O00_0.0o00_.().ShowDialog() = DialogResult.OK Then
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.o0_0.0OOO_0Oo. = o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.O00_0.0o00_.().FileName
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.Text = o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.o0_0.0OOO_0Oo.)
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.ShowDialog()
			End If
		End Sub

		' Token: 0x0600581A RID: 22554 RVA: 0x0022E78C File Offset: 0x0022C98C
		Public Sub ExportToXML()
			Dim o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u As O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000 = New O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000()
			If o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.o0_0.0OOO_0Oo.().ShowDialog() = DialogResult.OK Then
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.oOO.O0_oo_0. = o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.o0_0.0OOO_0Oo.().FileName
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.Text = o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.oOO.O0_oo_0.)
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.ShowDialog()
			End If
		End Sub

		' Token: 0x0600581B RID: 22555 RVA: 0x0022E7F0 File Offset: 0x0022C9F0
		<oO0oooo("")>
		Public Sub Merge()
			Dim o_u3002_u3000_u3000_u3002_u3000_u As O\u3002\u3000\u3000\u3002\u3000\u3002 = New O\u3002\u3000\u3000\u3002\u3000\u3002("")
			If o_u3002_u3000_u3000_u3002_u3000_u.o0_o.__ooo_0_.() Then
				o_u3002_u3000_u3000_u3002_u3000_u.oo0o_o._.()
				o_u3002_u3000_u3000_u3002_u3000_u.ShowDialog()
			End If
		End Sub

		' Token: 0x0600581C RID: 22556 RVA: 0x0022E820 File Offset: 0x0022CA20
		<oO0oooo("0187")>
		Public Sub QuickMerge()
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "Excel(*.xls,*.xlsx)|*.XLS;*.XLSX|Access(*.mdb,*.accdb)|*.MDB;*.ACCDB|dBASE(*.dbf)|*.DBF|Text(*.txt)|*.TXT"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				New O\u3002\u3000\u3000\u3002\u3000\u3002(openFileDialog.FileName, True).ShowDialog()
			End If
		End Sub

		' Token: 0x0600581D RID: 22557 RVA: 0x0022E85C File Offset: 0x0022CA5C
		Public Sub MergeFromXML()
			Dim o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u As o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 = New o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002()
			If o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.OoO_.O.().ShowDialog() = DialogResult.OK Then
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.__O0O. = o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.OoO_.O.().FileName
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.Text = o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.__O0O.)
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.00_0_.()
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.ShowDialog()
			End If
		End Sub

		' Token: 0x0600581E RID: 22558 RVA: 0x0022E8C8 File Offset: 0x0022CAC8
		<oO0oooo("0187")>
		Public Sub MergeFromText()
			Dim o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u As O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 = New O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002()
			If o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoOO.000_o_O.().ShowDialog() = DialogResult.OK Then
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoO_.O. = o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoOO.000_o_O.().FileName
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.Oo_0.oooo__.()
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.ShowDialog()
			End If
		End Sub

		' Token: 0x0600581F RID: 22559 RVA: 0x0022E907 File Offset: 0x0022CB07
		<oO0oooo("0094")>
		Public Sub DockSetting()
			If ooO.oo__.O000_o_O.() AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso OO_00oOO.CurrentTable.IsRelation Then
				New O\u3002\u3002\u3002(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005820 RID: 22560 RVA: 0x0022E933 File Offset: 0x0022CB33
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub StatusViewer()
		End Sub

		' Token: 0x06005821 RID: 22561 RVA: 0x0022E935 File Offset: 0x0022CB35
		<oO0oooo("0191")>
		Public Sub SaveTableView()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New O\u3002\u3000\u3002\u3002O\u3002oo\u3002\u3002\u3002(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005822 RID: 22562 RVA: 0x0022E94E File Offset: 0x0022CB4E
		<oO0oooo("0191")>
		Public Sub TableViewManager()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New o\u3002o\u3002\u3002\u3000\u30020\u3002\u3000\u3002\u3002\u3000(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x06005823 RID: 22563 RVA: 0x0022E967 File Offset: 0x0022CB67
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Refresh()
			Table.Load()
		End Sub

		' Token: 0x06005824 RID: 22564 RVA: 0x0022E970 File Offset: 0x0022CB70
		<oO0oooo("0115")>
		Public Sub Load()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Main.ProcessForm.o0__.Oo0O_O0O_.("正在同步" + OO_00oOO.CurrentTable.Name + "，请稍候...")
				Main.ProcessForm.Show()
				Application.DoEvents()
				OO_00oOO.CurrentTable.DataTable.o0.o.(True, Nothing)
				Main.ProcessForm.Close()
			End If
		End Sub

		' Token: 0x06005825 RID: 22565 RVA: 0x0022E9D1 File Offset: 0x0022CBD1
		<oO0oooo("0158")>
		Public Sub BuildGroupTable()
			If Table.OO.OO_0o.() Then
				New j8(False).ShowDialog()
				OO_00oOO.MainTable.foxGrid.Focus()
			End If
		End Sub

		' Token: 0x06005826 RID: 22566 RVA: 0x0022E9F6 File Offset: 0x0022CBF6
		<oO0oooo("0158")>
		Public Sub NewGroupTable()
			If Table.OO.OO_0o.() Then
				New j8(True).ShowDialog()
				OO_00oOO.MainTable.foxGrid.Focus()
			End If
		End Sub

		' Token: 0x06005827 RID: 22567 RVA: 0x0022EA1C File Offset: 0x0022CC1C
		<oO0oooo("0158")>
		Public Sub RebuildGroupTable()
			If Table.OO.OO_0o.() Then
				Dim o_0._O_0OO000O. As GroupTableBuilder = OO_00oOO.CurrentTable.O_0._O_0OO000O.
				If o_0._O_0OO000O. IsNot Nothing Then
					If OO_00oOO.CurrentTable.O.OoOo_. IsNot Nothing AndAlso OO_00oOO.CurrentTable.O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadTop, "", True) > 0 AndAlso OO_00oOO.CurrentTable.AllowBackEndFilter Then
						Dim text As String = ""
						If Not o_0._O_0OO000O..FromAll Then
							text = OO_00oOO.CurrentTable.DataTable.LoadFilter
						End If
						If Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", True) > 0 Then
							If Operators.CompareString(text, "", True) > 0 Then
								text = "(" + text + ") And " + o_0._O_0OO000O..ExtendFilter
							Else
								text = o_0._O_0OO000O..ExtendFilter
							End If
						End If
						Dim fromServer As Boolean = o_0._O_0OO000O..FromServer
						o_0._O_0OO000O..FromServer = True
						o_0._O_0OO000O..Filter = text
						o_0._O_0OO000O..Build()
						o_0._O_0OO000O..FromServer = fromServer
					Else
						Dim text2 As String = Oo00.OoO_.__o.(OO_00oOO.CurrentTable, o_0._O_0OO000O..FromServer)
						If Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", True) > 0 Then
							If Operators.CompareString(text2, "", True) > 0 Then
								text2 = "(" + text2 + ") And " + o_0._O_0OO000O..ExtendFilter
							Else
								text2 = o_0._O_0OO000O..ExtendFilter
							End If
						End If
						o_0._O_0OO000O..Filter = text2
						o_0._O_0OO000O..Build()
					End If
					If OO_00oOO.Tables.get_Contains(o_0._O_0OO000O..TableName) Then
						OO_00oOO.MainTable = OO_00oOO.Tables(o_0._O_0OO000O..TableName)
						Return
					End If
				Else
					Table.BuildGroupTable()
				End If
			End If
		End Sub

		' Token: 0x06005828 RID: 22568 RVA: 0x0022EBB0 File Offset: 0x0022CDB0
		<oO0oooo("0165")>
		Public Sub BuildCrossTable()
			If Table.OO.OO_0o.() Then
				New mf(False).ShowDialog()
				OO_00oOO.MainTable.foxGrid.Focus()
			End If
		End Sub

		' Token: 0x06005829 RID: 22569 RVA: 0x0022EBD5 File Offset: 0x0022CDD5
		<oO0oooo("0165")>
		Public Sub NewCrossTable()
			If Table.OO.OO_0o.() Then
				New mf(True).ShowDialog()
				OO_00oOO.MainTable.foxGrid.Focus()
			End If
		End Sub

		' Token: 0x0600582A RID: 22570 RVA: 0x0022EBFC File Offset: 0x0022CDFC
		<oO0oooo("0165")>
		Public Sub RebuildCrossTable()
			If Table.OO.OO_0o.() Then
				Dim o_0._O_0OO000O. As CrossTableBuilder = OO_00oOO.CurrentTable.O_0._O_0OO000O.
				If o_0._O_0OO000O. IsNot Nothing Then
					If OO_00oOO.CurrentTable.O.OoOo_. IsNot Nothing AndAlso OO_00oOO.CurrentTable.O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadTop, "", True) > 0 AndAlso OO_00oOO.CurrentTable.AllowBackEndFilter Then
						Dim text As String = ""
						If Not o_0._O_0OO000O..FromAll Then
							text = OO_00oOO.CurrentTable.DataTable.LoadFilter
						End If
						If Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", True) > 0 Then
							If Operators.CompareString(text, "", True) > 0 Then
								text = "(" + text + ") And " + o_0._O_0OO000O..ExtendFilter
							Else
								text = o_0._O_0OO000O..ExtendFilter
							End If
						End If
						Dim fromServer As Boolean = o_0._O_0OO000O..FromServer
						o_0._O_0OO000O..FromServer = True
						o_0._O_0OO000O..Filter = text
						o_0._O_0OO000O..Build()
						o_0._O_0OO000O..FromServer = fromServer
					Else
						Dim text2 As String = Oo00.OoO_.__o.(OO_00oOO.CurrentTable, o_0._O_0OO000O..FromServer)
						If Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", True) > 0 Then
							If Operators.CompareString(text2, "", True) > 0 Then
								text2 = text2 + " And " + o_0._O_0OO000O..ExtendFilter
							Else
								text2 = o_0._O_0OO000O..ExtendFilter
							End If
						End If
						o_0._O_0OO000O..Filter = text2
						o_0._O_0OO000O..Build()
					End If
					If OO_00oOO.Tables.get_Contains(o_0._O_0OO000O..TableName) Then
						OO_00oOO.MainTable = OO_00oOO.Tables(o_0._O_0OO000O..TableName)
						Return
					End If
				Else
					Table.BuildCrossTable()
				End If
			End If
		End Sub

		' Token: 0x0600582B RID: 22571 RVA: 0x0022ED8C File Offset: 0x0022CF8C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If(OO_00oOO.CurrentTable Is Nothing OrElse OO_00oOO.CurrentTable.Rows.Count < 2) AndAlso Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadFilter, "", True) = 0 Then
				MessageBox.Show("至少要有多于一行的数据，才能进行分组统计！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x0600582C RID: 22572 RVA: 0x0022EDE8 File Offset: 0x0022CFE8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Move()
			MessageBox.Show("用鼠标左右拖动表标题，即可调整表的位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x0600582D RID: 22573 RVA: 0x0022EDFD File Offset: 0x0022CFFD
		<oO0oooo("0199")>
		Public Sub ExcelReportManager()
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				MessageBox.Show("必须先保存项目，才能管理报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			New o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002().ShowDialog()
		End Sub

		' Token: 0x0600582E RID: 22574 RVA: 0x0022EE30 File Offset: 0x0022D030
		<oO0oooo("2879")>
		Public Sub WordReportManager()
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				MessageBox.Show("必须先保存项目，才能管理报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			New o\u3000_\u3000\u3002_\u3002\u3000().ShowDialog()
		End Sub

		' Token: 0x0600582F RID: 22575 RVA: 0x0022EE63 File Offset: 0x0022D063
		Public Sub CodeReportManager()
			If ooO.oo__.O000_o_O.() Then
				New o0\u3002().ShowDialog()
			End If
		End Sub

		' Token: 0x06005830 RID: 22576 RVA: 0x0022EE78 File Offset: 0x0022D078
		<oO0oooo("1632")>
		Public Sub Recyle()
			If OO_00oOO.CurrentTable.DataTable.BaseTable.[Select]("", "", DataViewRowState.Deleted).Length = 0 Then
				MessageBox.Show("没有可回收的删除行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			New O_\u3002\u3000\u3002\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog()
		End Sub

		' Token: 0x06005831 RID: 22577 RVA: 0x0022EED4 File Offset: 0x0022D0D4
		Public Sub MoveLeft()
			Dim selectedIndex As Integer = Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex
			If selectedIndex > 0 Then
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle)
				OO_00oOO.BaseMainForm.SuspendLayout()
				Dim oo___OO0O_ As OO___OO0O_0 = Main.OO_O.o..OO_O_0Oo.___o.()
				oo___OO0O_.SuspendLayout()
				oo___OO0O_.TabPages.Insert(selectedIndex - 1, oo___OO0O_.SelectedTab)
				oo___OO0O_.SelectedIndex = selectedIndex - 1
				oo___OO0O_.ResumeLayout()
				OO_00oOO.BaseMainForm.ResumeLayout()
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
			End If
		End Sub

		' Token: 0x06005832 RID: 22578 RVA: 0x0022EF5C File Offset: 0x0022D15C
		Public Sub MoveRight()
			Dim selectedIndex As Integer = Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex
			Dim oo___OO0O_ As OO___OO0O_0 = Main.OO_O.o..OO_O_0Oo.___o.()
			If selectedIndex < oo___OO0O_.TabPages.Count - 1 Then
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle)
				OO_00oOO.BaseMainForm.SuspendLayout()
				oo___OO0O_.SuspendLayout()
				oo___OO0O_.TabPages.Insert(selectedIndex + 1, oo___OO0O_.SelectedTab)
				oo___OO0O_.SelectedIndex = selectedIndex + 1
				oo___OO0O_.ResumeLayout()
				OO_00oOO.BaseMainForm.ResumeLayout()
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
			End If
		End Sub

		' Token: 0x06005833 RID: 22579 RVA: 0x0022EFEE File Offset: 0x0022D1EE
		<oO0oooo("1797")>
		Public Sub SetFunctionColumn()
		End Sub

		' Token: 0x06005834 RID: 22580 RVA: 0x0022EFF0 File Offset: 0x0022D1F0
		<oO0oooo("3337")>
		Public Sub InlineMRPBuilder()
			New o\u3002\u3000\u3000\u3000\u3002() With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x06005835 RID: 22581 RVA: 0x0022F008 File Offset: 0x0022D208
		<oO0oooo("3341")>
		Public Sub LayersMRPBuilder()
			New di() With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x06005836 RID: 22582 RVA: 0x0022F020 File Offset: 0x0022D220
		<oO0oooo("3342")>
		Public Sub InlineGroupBuilder()
			New h0() With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x06005837 RID: 22583 RVA: 0x0022F038 File Offset: 0x0022D238
		<oO0oooo("3347")>
		Public Sub LayersGroupBuilder()
			New ev() With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x06005838 RID: 22584 RVA: 0x0022F050 File Offset: 0x0022D250
		<oO0oooo("3318")>
		Public Sub SetGridTree()
			Dim table As Table = OO_00oOO.MainTable
			If table IsNot Nothing AndAlso New O\u30020\u3000\u3002(table) With { .Owner = Main.OO_O.o. }.ShowDialog() = DialogResult.OK Then
				table.NeedSaveSetting = True
				table.oo0OO0Ooo._.(True)
			End If
		End Sub

		' Token: 0x06005839 RID: 22585 RVA: 0x0022F08D File Offset: 0x0022D28D
		Public Sub CloseGridTree()
			OO_00oOO.MainTable.CloseGridTree()
		End Sub

		' Token: 0x0600583A RID: 22586 RVA: 0x0022F099 File Offset: 0x0022D299
		Public Sub ShowGridTree()
			If Not OO_00oOO.MainTable.ShowGridTree() Then
				Table.SetGridTree()
			End If
		End Sub

		' Token: 0x0600583B RID: 22587 RVA: 0x0022F0AC File Offset: 0x0022D2AC
		<oO0oooo("3377")>
		Public Sub BatchUpdate()
			New o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000(False) With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x0600583C RID: 22588 RVA: 0x0022F0C5 File Offset: 0x0022D2C5
		<oO0oooo("3378")>
		Public Sub BatchCopy()
			New o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000(True) With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub
	End Module
End Namespace
