Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x0200052E RID: 1326
	Public NotInheritable Module Row
		' Token: 0x060057D8 RID: 22488 RVA: 0x0022BE60 File Offset: 0x0022A060
		<oO0oooo("0109")>
		Public Sub AddNew()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso (table.GridTreeVisible OrElse table.foxGrid.OO.o_o00o.()) Then
				GridTree.AddSlibing()
				Return
			End If
			Row.AddNews(1)
		End Sub

		' Token: 0x060057D9 RID: 22489 RVA: 0x0022BE98 File Offset: 0x0022A098
		<oO0oooo("0109")>
		Public Sub AddNews(Optional Rows As Integer = -1)
			If OO_00oOO.CurrentTable IsNot Nothing AndAlso Row.OO.OO_0o.() AndAlso Not OO_00oOO.CurrentTable.GridTreeVisible AndAlso Not OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.() Then
				If Rows = -1 Then
					Dim o_u3002_u3000_u As O\u3002\u3000\u3002 = New O\u3002\u3000\u3002("新增行", "请输入行数:", 5, 1, 300, "每次最多允许增加300行！")
					If o_u3002_u3000_u.ShowDialog() = DialogResult.Cancel Then
						Return
					End If
					Rows = o_u3002_u3000_u.Value
				End If
				If Rows >= 1 Then
					Try
						Dim dataTable As DataTable = OO_00oOO.CurrentTable.View.o_o.O0ooOo.()
						Dim count As Integer = OO_00oOO.CurrentTable.View.Count
						If dataTable.Rows.Count > 0 Then
							Dim dataRow As DataRow = dataTable.Rows(dataTable.Rows.Count - 1)
						End If
						OO_00oOO.CurrentTable.Rows.AddNew(Rows)
						If OO_00oOO.CurrentTable.View.Count > count Then
							OO_00oOO.CurrentTable.ClearEditInfos()
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					End Try
				End If
			End If
		End Sub

		' Token: 0x060057DA RID: 22490 RVA: 0x0022BFBC File Offset: 0x0022A1BC
		<oO0oooo("1792")>
		Public Sub Clone()
			If OO_00oOO.CurrentTable IsNot Nothing AndAlso Row.OO.OO_0o.() Then
				If OO_00oOO.CurrentTable.GridTreeVisible OrElse OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.() Then
					GridTree.Clone()
					Return
				End If
				If OO_00oOO.CurrentTable IsNot Nothing AndAlso OO_00oOO.CurrentTable.Current IsNot Nothing Then
					Dim dataTable As DataTable = OO_00oOO.CurrentTable.View.o_o.O0ooOo.()
					Dim count As Integer = dataTable.Rows.Count
					If count > 0 Then
						Dim dataRow As DataRow = dataTable.Rows(dataTable.Rows.Count - 1)
					End If
					OO_00oOO.CurrentTable.Current.Clone()
					If dataTable.Rows.Count > count Then
						OO_00oOO.CurrentTable.O_o0OOo_.o0..Clear()
						If OO_00oOO.CurrentTable.foxGrid.Row <= OO_00oOO.CurrentTable.foxGrid.Rows.Fixed Then
							OO_00oOO.CurrentTable.foxGrid.Row = OO_00oOO.CurrentTable.foxGrid.Rows.Fixed
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x060057DB RID: 22491 RVA: 0x0022C0CC File Offset: 0x0022A2CC
		<oO0oooo("1791")>
		Public Sub Insert()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing AndAlso (table.GridTreeVisible OrElse table.foxGrid.OO.o_o00o.()) Then
				GridTree.InsertSlibing()
				Return
			End If
			If Row.OO.OO_0o.() AndAlso OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Rows.InsertNew()
			End If
		End Sub

		' Token: 0x060057DC RID: 22492 RVA: 0x0022C11C File Offset: 0x0022A31C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Not OO_00oOO.CurrentTable.AllowEdit Then
				result = False
			ElseIf OO_00oOO.CurrentTable.View.o_o.O0ooOo.() IsNot Nothing AndAlso OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Row.RowState = DataRowState.Detached Then
				MessageBox.Show("在当前行输入主键值之前，不能增加新行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf OO_00oOO.CurrentTable.IsSubtotal Then
				MessageBox.Show("不能在汇总模式下增加行，请先退出汇总模式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf Not OO_00oOO.CurrentTable.AllowAddNew Then
				MessageBox.Show("增加行失败，Table""" + OO_00oOO.CurrentTable.Name + """的AllowAddNew属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060057DD RID: 22493 RVA: 0x0022C1E0 File Offset: 0x0022A3E0
		<oO0oooo("0110")>
		Public Sub Delete()
			If OO_00oOO.CurrentTable.Position >= 0 AndAlso OO_00oOO.CurrentTable.AllowEdit Then
				If OO_00oOO.CurrentTable.IsSubtotal Then
					MessageBox.Show("不能在汇总模式下删除行，请先退出汇总模式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Not OO_00oOO.CurrentTable.DataTable.DeleteRowPrompt OrElse MessageBox.Show("是否要删除选定行？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
					If Not OO_00oOO.CurrentTable.AllowDelete Then
						MessageBox.Show("删除行失败，Table""" + OO_00oOO.CurrentTable.Name + """的AllowDelete属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					If OO_00oOO.CurrentTable.GridTreeVisible Then
						Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
						Dim topRow As Integer = o_oOooO_O.Selection.TopRow
						Dim bottomRow As Integer = o_oOooO_O.Selection.BottomRow
						Dim i As Integer = topRow
						While i <= bottomRow
							If Not o_oOooO_O.Rows(i).Visible Then
								If MessageBox.Show("选定区域含有不可见的折叠行，是否继续执行删除行操作?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
									Return
								End If
								Exit While
							Else
								i += 1
							End If
						End While
					End If
					Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
					OO_00oOO.CurrentTable.ClearEditInfos()
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在删除记录..."
					Application.DoEvents()
					Dim list2 As List(Of DataTable) = New List(Of DataTable)()
					Try
						OO_00oOO.LockBaseMainForm()
						Dim list3 As List(Of DataRow) = New List(Of DataRow)()
						list2.Add(OO_00oOO.CurrentTable.DataTable.BaseTable)
						Row.OO.OO_0o.(list2, OO_00oOO.CurrentTable.DataTable.BaseTable)
						Dim topRow2 As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow
						Dim bottomRow2 As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow
						OO_00oOO.CurrentTable.foxGrid
						Dim num As Integer = topRow2
						For j As Integer = bottomRow2 To num Step -1
							Dim dataIndex As Integer = OO_00oOO.CurrentTable.foxGrid.Rows(j).DataIndex
							If dataIndex >= 0 Then
								list3.Add(OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(dataIndex).Row)
							End If
						Next
						If list3.Count > 1 Then
							If OO_00oOO.CurrentTable.GridTreeVisible Then
								Try
									For Each dataTable As DataTable In list2
										OO_00oOO.DataTables(dataTable.TableName).IsDeletingRows = True
									Next
									GoTo IL_2CF
								Finally
									Dim enumerator As List(Of DataTable).Enumerator
									CType(enumerator, IDisposable).Dispose()
								End Try
							End If
							Try
								For Each dataTable2 As DataTable In list2
									Try
										For Each table As Table In OO_00oOO.Tables
											If table.View.o_o.O0ooOo.() Is dataTable2 Then
												list.Add(New OoO_O00(table))
											End If
										Next
									Finally
										Dim enumerator3 As IEnumerator(Of Table)
										If enumerator3 IsNot Nothing Then
											enumerator3.Dispose()
										End If
									End Try
								Next
							Finally
								Dim enumerator2 As List(Of DataTable).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
						End If
						IL_2CF:
						Try
							For Each a_ As DataRow In list3
								If Not New DataRow(a_).oo.o0oOoooo.() Then
									Exit For
								End If
							Next
						Finally
							Dim enumerator4 As List(Of DataRow).Enumerator
							CType(enumerator4, IDisposable).Dispose()
						End Try
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "")
					Finally
						Foxtable.RibbonMenu.StatusBar.Message1 = ""
						Try
							For Each ooO_O As OoO_O00 In list
								ooO_O.O._00000.(Nothing)
							Next
						Finally
							Dim enumerator5 As List(Of OoO_O00).Enumerator
							CType(enumerator5, IDisposable).Dispose()
						End Try
						Try
							For Each dataTable3 As DataTable In list2
								If OO_00oOO.DataTables(dataTable3.TableName).IsDeletingRows Then
									OO_00oOO.DataTables(dataTable3.TableName).IsDeletingRows = False
									Try
										For Each table2 As Table In OO_00oOO.Tables
											If table2.View.o_o.O0ooOo.() Is dataTable3 Then
												table2.RaiseCurrentChanged()
												table2.RaisePositionChanged()
											End If
										Next
									Finally
										Dim enumerator7 As IEnumerator(Of Table)
										If enumerator7 IsNot Nothing Then
											enumerator7.Dispose()
										End If
									End Try
								End If
							Next
						Finally
							Dim enumerator6 As List(Of DataTable).Enumerator
							CType(enumerator6, IDisposable).Dispose()
						End Try
						OO_00oOO.UnlockBaseMainForm()
					End Try
				End If
			End If
		End Sub

		' Token: 0x060057DE RID: 22494 RVA: 0x0022C6E8 File Offset: 0x0022A8E8
		Friend Sub <<EMPTY_NAME>>(A_0 As List(Of DataTable), A_1 As DataTable)
			Try
				For Each obj As Object In A_1.ChildRelations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If Not A_0.Contains(dataRelation.ChildTable) Then
						A_0.Add(dataRelation.ChildTable)
						Row.OO.OO_0o.(A_0, dataRelation.ChildTable)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060057DF RID: 22495 RVA: 0x0022C764 File Offset: 0x0022A964
		<oO0oooo("0111")>
		Public Sub Lock()
			If OO_00oOO.CurrentTable.AllowEdit AndAlso OO_00oOO.CurrentTable.Position >= 0 Then
				If Not OO_00oOO.CurrentTable.AllowLockRow Then
					MessageBox.Show("锁定行失败，Table""" + OO_00oOO.CurrentTable.Name + """的AllowLockRow属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Dim num As Integer = Math.Min(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel)
				Dim num2 As Integer = Math.Max(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel)
				Dim oo___ooo As oo___ooo = New oo___ooo()
				Dim num3 As Integer = num2
				For i As Integer = num To num3
					Dim dataIndex As Integer = OO_00oOO.CurrentTable.foxGrid.Rows(i).DataIndex
					If dataIndex >= 0 Then
						Dim row As Row = OO_00oOO.CurrentTable.Rows(dataIndex)
						If row.DataRow IsNot Nothing Then
							If Not row.Locked Then
								oo___ooo.o00.oo0__00.(row.DataRow.BaseRow)
								row.Locked = True
								Oo00.o0_o._O_.(row.DataRow.BaseRow)
							End If
						End If
					End If
				Next
				If oo___ooo.o00.oo0__00.() > 0 Then
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oo___ooo)
				End If
			End If
		End Sub

		' Token: 0x060057E0 RID: 22496 RVA: 0x0022C8B0 File Offset: 0x0022AAB0
		<oO0oooo("0111")>
		Public Sub UnLock()
			If OO_00oOO.CurrentTable.Position >= 0 AndAlso OO_00oOO.CurrentTable.AllowEdit Then
				If Not OO_00oOO.CurrentTable.AllowUnLockRow Then
					MessageBox.Show("取消锁定行失败，Table""" + OO_00oOO.CurrentTable.Name + """的AllowUnlockRow属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Dim num As Integer = Math.Min(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel)
				Dim num2 As Integer = Math.Max(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel)
				Dim oo___ooo As oo___ooo = New oo___ooo()
				Dim num3 As Integer = num2
				For i As Integer = num To num3
					Dim dataIndex As Integer = OO_00oOO.CurrentTable.foxGrid.Rows(i).DataIndex
					If dataIndex >= 0 Then
						Dim row As Row = OO_00oOO.CurrentTable.Rows(dataIndex)
						If row.DataRow IsNot Nothing Then
							If row.Locked Then
								oo___ooo.o00.oo0__00.(row.DataRow.BaseRow)
								row.Locked = False
								Oo00.o0_o._O_.(row.DataRow.BaseRow)
							End If
						End If
					End If
				Next
				If oo___ooo.o00.oo0__00.() > 0 Then
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oo___ooo)
				End If
			End If
		End Sub

		' Token: 0x060057E1 RID: 22497 RVA: 0x0022C9F9 File Offset: 0x0022ABF9
		<oO0oooo("0114")>
		Public Sub Height()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				New O\u3000_\u3000(OO_00oOO.CurrentTable).ShowDialog()
			End If
		End Sub

		' Token: 0x060057E2 RID: 22498 RVA: 0x0022CA12 File Offset: 0x0022AC12
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Refresh()
			Row.Load()
		End Sub

		' Token: 0x060057E3 RID: 22499 RVA: 0x0022CA1C File Offset: 0x0022AC1C
		<oO0oooo("0115")>
		Public Sub Load()
			If Not OO_00oOO.CurrentTable.DataTable.frd_IsTemporary AndAlso OO_00oOO.CurrentTable.foxGrid.Selection.TopRow >= 0 Then
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				Dim topRow As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow
				Dim bottomRow As Integer = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					If OO_00oOO.CurrentTable.foxGrid.Rows(i).DataIndex >= 0 Then
						list.Add(New DataRow(OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(OO_00oOO.CurrentTable.foxGrid.Rows(i).DataIndex).Row))
					End If
				Next
				If Operators.CompareString(OO_00oOO.CurrentTable.DataTable.DataServer, "", True) = 0 Then
					Dim state As ConnectionState = OO_00oOO.CurrentTable.DataTable.frd_Connection.State
					Try
						If state <> ConnectionState.Open Then
							OO_00oOO.CurrentTable.DataTable.frd_Connection.Open()
						End If
						Try
							For Each dataRow As DataRow In list
								If dataRow.RowState <> 4 Then
									dataRow.Load(True)
								End If
							Next
						Finally
							Dim enumerator As List(Of DataRow).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Return
					Catch ex As Exception
						Return
					Finally
						If state <> ConnectionState.Open Then
							OO_00oOO.CurrentTable.DataTable.frd_Connection.Close()
						End If
					End Try
				End If
				Dim row As Row = OO_00oOO.CurrentTable.Current
				If row IsNot Nothing Then
					row.Load(True)
				End If
			End If
		End Sub

		' Token: 0x060057E4 RID: 22500 RVA: 0x0022CBE8 File Offset: 0x0022ADE8
		<oO0oooo("1543")>
		Public Sub HideUnSelectedRows()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.o.O0___OOo0_oO.(1)
			End If
		End Sub

		' Token: 0x060057E5 RID: 22501 RVA: 0x0022CBFC File Offset: 0x0022ADFC
		<oO0oooo("1543")>
		Public Sub HideSelectedRows()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.o.O0___OOo0_oO.(0)
			End If
		End Sub

		' Token: 0x060057E6 RID: 22502 RVA: 0x0022CC10 File Offset: 0x0022AE10
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowHideRows()
		End Sub

		' Token: 0x060057E7 RID: 22503 RVA: 0x0022CC14 File Offset: 0x0022AE14
		Public Sub MoveUp()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				If table.GridTreeVisible OrElse table.foxGrid.OO.o_o00o.() Then
					GridTree.MoveUp()
					Return
				End If
				Try
					Dim table2 As Table = table
					table2.StopRedraw()
					Dim selection As CellRange = table2.foxGrid.Selection
					If selection.TopRow <> -1 AndAlso selection.BottomRow <> -1 Then
						If table2.TopPosition = table2.BottomPosition Then
							If Not table2.Current.Move(table2.Position - 1) Then
								Return
							End If
						ElseIf table2.TopPosition <= 0 OrElse Not table2.Rows(table2.TopPosition - 1).Move(table2.BottomPosition) Then
							Return
						End If
						table2.foxGrid.[Select](selection.r1 - 1, selection.c1, selection.r2 - 1, selection.c2)
						table2.ClearEditInfos()
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					table.ResumeRedraw()
				End Try
			End If
		End Sub

		' Token: 0x060057E8 RID: 22504 RVA: 0x0022CD3C File Offset: 0x0022AF3C
		Public Sub MoveDown()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				If table.GridTreeVisible OrElse table.foxGrid.OO.o_o00o.() Then
					GridTree.MoveDown()
					Return
				End If
				Try
					Dim table2 As Table = table
					table2.StopRedraw()
					Dim selection As CellRange = table2.foxGrid.Selection
					If selection.TopRow <> -1 AndAlso selection.BottomRow <> -1 Then
						If table2.TopPosition = table2.BottomPosition Then
							If Not table2.Current.Move(table2.Position + 1) Then
								Return
							End If
						ElseIf table2.BottomPosition >= table2.ooO__oo0O.0.(False) - 1 OrElse Not table2.Rows(table2.BottomPosition + 1).Move(table2.TopPosition) Then
							Return
						End If
						table2.foxGrid.[Select](selection.r1 + 1, selection.c1, selection.r2 + 1, selection.c2)
						table2.ClearEditInfos()
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					table.ResumeRedraw()
				End Try
			End If
		End Sub
	End Module
End Namespace
