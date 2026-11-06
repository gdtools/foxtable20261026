Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.RibbonMenu
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200029A RID: 666
	<oO0oooo("0365")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class DataTableCollection
		Implements IEnumerable(Of DataTable)

		' Token: 0x06002281 RID: 8833 RVA: 0x000EA1B1 File Offset: 0x000E83B1
		Public Sub New()
			Me.OO0o00.0O_0o. = New Dictionary(Of String, DataTable)()
			Me.OO0o00.0O_0o. = True
		End Sub

		' Token: 0x06002282 RID: 8834 RVA: 0x000EA1CB File Offset: 0x000E83CB
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Me.OO0o00.0O_0o..Add(A_0.Name, A_0)
		End Sub

		' Token: 0x06002283 RID: 8835 RVA: 0x000EA1DF File Offset: 0x000E83DF
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO0o00.0O_0o..Remove(A_0)
		End Sub

		' Token: 0x17000822 RID: 2082
		' (get) Token: 0x06002284 RID: 8836 RVA: 0x000EA1F0 File Offset: 0x000E83F0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(TableName As String) As DataTable
			Get
				Dim result As DataTable
				If Me.OO0o00.0O_0o..ContainsKey(TableName) Then
					result = Me.OO0o00.0O_0o.(TableName)
				Else
					Try
						For Each text As String In Me.OO0o00.0O_0o..Keys
							If Operators.CompareString(text, TableName, True) = 0 Then
								Return Me.OO0o00.0O_0o.(text)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					MessageBox.Show("不存在名称为""" + TableName + """的DataTable！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000823 RID: 2083
		' (get) Token: 0x06002285 RID: 8837 RVA: 0x000EA29C File Offset: 0x000E849C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Index As Integer) As DataTable
			Get
				Return Me.OO0o00.0O_0o.(O_O0OO.OOOo.oo_OOOO_0.().Tables(Index).TableName)
			End Get
		End Property

		' Token: 0x17000824 RID: 2084
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As DataTable
			Get
				Dim index As Integer = -1
				Dim result As DataTable
				If Integer.TryParse(A_0.ToString(), index) Then
					result = Me.get_Item(index)
				Else
					result = Me.get_Item(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002287 RID: 8839 RVA: 0x000EA2F6 File Offset: 0x000E84F6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of DataTable) Implements System.Collections.Generic.IEnumerable(Of Foxtable.DataTable).GetEnumerator
			Return CType(Me.OO0o00.0O_0o..Values.GetEnumerator(), IEnumerator(Of DataTable))
		End Function

		' Token: 0x06002288 RID: 8840 RVA: 0x000EA312 File Offset: 0x000E8512
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.OO0o00.0O_0o..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x06002289 RID: 8841 RVA: 0x000EA330 File Offset: 0x000E8530
		Public Function Contains(DataTableName As String) As Boolean
			Dim result As Boolean
			If Me.OO0o00.0O_0o..ContainsKey(DataTableName) Then
				result = True
			Else
				Try
					Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator = Me.OO0o00.0O_0o..Keys.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current, DataTableName, True) = 0 Then
							Return True
						End If
					End While
				Finally
					Dim enumerator As Dictionary(Of String, DataTable).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x17000825 RID: 2085
		' (get) Token: 0x0600228A RID: 8842 RVA: 0x000EA3A4 File Offset: 0x000E85A4
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OO0o00.0O_0o..Count
			End Get
		End Property

		' Token: 0x0600228B RID: 8843 RVA: 0x000EA3B4 File Offset: 0x000E85B4
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As List(Of String), A_3 As List(Of Type), A_4 As List(Of Integer), A_5 As List(Of String), A_6 As List(Of String))
			Dim dataTable As DataTable = New DataTable()
			If OO_00oOO.DataTables.Contains(A_0) Then
				MessageBox.Show("表" + A_0 + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Oo00.o.O0_O0.(A_0) AndAlso A_2.Count <> 0 AndAlso A_2.Count = A_3.Count AndAlso A_2.Count = A_4.Count AndAlso A_2.Count = A_5.Count Then
				dataTable.TableName = A_0
				Dim num As Integer = A_2.Count - 1
				For i As Integer = 0 To num
					If Not o_O_o_oOoo__.O_o_._o0.(A_2(i), "列名", 64, False) Then
						Return
					End If
					dataTable.Columns.Add(A_2(i), A_3(i))
					If A_3(i) Is GetType(String) Then
						dataTable.Columns(A_2(i)).MaxLength = A_4(i)
					End If
				Next
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
				Dim num2 As Integer = A_2.Count - 1
				For j As Integer = 0 To num2
					If Operators.CompareString(A_6(j), "", True) > 0 Then
						Try
							dataTable.Columns(A_2(j)).Expression = A_6(j)
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "")
							Exit Try
						End Try
					End If
				Next
				Me.OO0o00.0O_0o..Add(A_0, New DataTable(dataTable, Nothing, Nothing, A_0, O_O0OO.OoO.0OO__0ooo.()))
				OO_00oOO.DataTables(A_0).o.0O000_.()
				OO_00oOO.DataTables(A_0).Caption = A_1
				OO_00oOO.DataTables(A_0).AddByCode = True
				Try
					For Each dataCol As DataCol In OO_00oOO.DataTables(A_0).DataCols
						dataCol.Caption = A_5(A_2.IndexOf(dataCol.Name))
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataCol)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600228C RID: 8844 RVA: 0x000EA5FC File Offset: 0x000E87FC
		Public Sub Delete(DataTableName As String)
			If Not Me.OO0o00.0O_0o..ContainsKey(DataTableName) Then
				MessageBox.Show("找不到你要删除的表[" + DataTableName + "]！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Not Me.OO0o00.0O_0o.(DataTableName).AddByCode Then
				MessageBox.Show("只能删除用代码增加的表，其余表请通过菜单删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Me.Remove(DataTableName)
		End Sub

		' Token: 0x0600228D RID: 8845 RVA: 0x000EA664 File Offset: 0x000E8864
		Private Sub Remove(TableName As String)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim enumerator As Dictionary(Of String, DataTable).ValueCollection.Enumerator = Me.OO0o00.0O_0o..Values.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_1E:
					num = 2
					If Operators.CompareString(dataTable.Name, TableName, True) = 0 Then
						IL_30:
						num = 3
						TableName = dataTable.Name
						Exit While
					End If
					IL_3D:
					num = 5
				End While
				IL_48:
				num = 6
				CType(enumerator, IDisposable).Dispose()
				IL_57:
				num = 7
				If Not Me.OO0o00.0O_0o..ContainsKey(TableName) Then
					GoTo IL_342
				End If
				IL_6A:
				num = 8
				Dim enumerator2 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator2.MoveNext()
					Dim form As Foxtable.WinForm.Form = enumerator2.Current
					IL_83:
					num = 9
					If form.Opened AndAlso Operators.CompareString(form.o_o0__00._., TableName, True) = 0 AndAlso (form.FormStyle = FormStyleEnum.主窗口 OrElse form.FormStyle = FormStyleEnum.停靠 OrElse form.FormStyle = FormStyleEnum.并列) Then
						IL_BC:
						num = 10
						form.Close()
					End If
					IL_C6:
					num = 11
				End While
				IL_D2:
				num = 12
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_E0:
				num = 13
				Dim enumerator3 As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator3.MoveNext()
					Dim table As Table = enumerator3.Current
					IL_FA:
					num = 14
					If table.IsCopy AndAlso Operators.CompareString(table.DataTable.Name, TableName, True) = 0 Then
						IL_11B:
						num = 15
						table.foxGrid.Enabled = False
						IL_12B:
						num = 16
						table.StopRedraw()
					End If
					IL_135:
					num = 17
				End While
				IL_141:
				num = 18
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_14F:
				num = 19
				Dim enumerator4 As IEnumerator = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.GetEnumerator()
				While enumerator4.MoveNext()
					Dim obj As Object = enumerator4.Current
					Dim c1DockingTabPage As C1DockingTabPage = CType(obj, C1DockingTabPage)
					IL_178:
					num = 20
					If Operators.CompareString(c1DockingTabPage.Name, TableName, True) = 0 Then
						IL_18B:
						num = 21
						Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Remove(c1DockingTabPage)
						IL_1A4:
						num = 22
						Dim oo0__Oo As Oo0__Oo = CType(c1DockingTabPage, Oo0__Oo)
						IL_1B0:
						num = 23
						oo0__Oo.O_000__.o.(Nothing)
						IL_1BB:
						num = 24
						oo0__Oo.O_000__.o.(Nothing)
						IL_1C6:
						oo0__Oo = Nothing
						IL_1C9:
						num = 26
						c1DockingTabPage.Controls.Clear()
						IL_1D8:
						num = 27
						c1DockingTabPage.Dispose()
						Exit While
					End If
					IL_1E4:
					num = 29
				End While
				IL_1F3:
				num = 30
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
				IL_20B:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_212:
				num = 32
				Dim a_ As Boolean = OO_00oOO.SystemReady
				IL_21C:
				num = 33
				OO_00oOO.SystemReady = False
				IL_225:
				num = 34
				Dim dataTable2 As DataTable = OO_00oOO.DataTables(TableName).BaseTable
				IL_23A:
				num = 35
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.Tables(TableName).foxGrid
				IL_24F:
				num = 36
				Dim o_ As O_0 = OO_00oOO.Tables(TableName).View
				IL_264:
				num = 37
				o_O_o_oOoo__.oo.O0o0o.(OO_00oOO.Tables(TableName))
				IL_277:
				num = 38
				OO_00oOO.Tables(TableName).foxGrid = Nothing
				IL_28B:
				num = 39
				OO_00oOO.Tables.OO._O_o__.(TableName)
				IL_299:
				num = 40
				OO_00oOO.DataTables.OoO_00.O.(TableName)
				IL_2A7:
				num = 41
				O_O0OO.o__.O.().Remove(O_O0OO.o__.O.()(TableName).Oo._Oo0OO.())
				IL_2C5:
				num = 42
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(TableName)
				IL_2D8:
				num = 43
				o_oOooO_O.o.0O_O0o_. = Nothing
				IL_2E3:
				num = 44
				o_oOooO_O.SetDataBinding(Nothing, Nothing)
				IL_2EF:
				num = 45
				o_.Dispose()
				IL_2F9:
				num = 46
				dataTable2.Reset()
				IL_303:
				num = 47
				dataTable2.Dispose()
				IL_30D:
				num = 48
				o_oOooO_O.o.o0OO00oO_0.()
				IL_317:
				num = 49
				o_oOooO_O.Controls.Clear()
				IL_326:
				num = 50
				o_oOooO_O.Dispose()
				IL_330:
				num = 51
				OO_00oOO.SystemReady = a_
				IL_33A:
				num = 52
				GC.Collect()
				IL_342:
				GoTo IL_468
				IL_347:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_429:
				GoTo IL_45D
				IL_42B:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_43B:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_42B
			End Try
			IL_45D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_468:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600228E RID: 8846 RVA: 0x000EAB00 File Offset: 0x000E8D00
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As Boolean
			Dim result As Boolean
			If Me.Count = 1 Then
				MessageBox.Show("至少要保留一个表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Try
					For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
						Dim dataRelation As DataRelation = CType(obj, DataRelation)
						If Operators.CompareString(dataRelation.ParentTable.TableName, A_0, True) = 0 Or Operators.CompareString(dataRelation.ChildTable.TableName, A_0, True) = 0 Then
							MessageBox.Show("请在删除表[" + A_0 + "]之前，先删除有关的表间关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return False
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Not OO_00oOO.MainTable.DataTable.AddByCode AndAlso MessageBox.Show("表删除操作是不可撤销的，确定要删除表[" + A_0 + "]吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
					result = False
				Else
					If Not OO_00oOO.DataTables(A_0).AddByCode Then
						If OO_00oOO.DataTables(A_0).frd_IsTemporary Then
							Try
								For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()).Rows
									Dim dataRow As DataRow = CType(obj2, DataRow)
									If Operators.CompareString(Conversions.ToString(dataRow("Name")), A_0, True) = 0 Then
										dataRow.Delete()
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()), True)
						ElseIf OO_00oOO.DataTables(A_0).frd_IsInnerTable Then
							Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
							o_oo.o0_oo0._.().oooO__O_0o_.o_.(A_0)
							o_oo.o0_oo0._.(True, False)
							Dim oleDbCommand As OleDbCommand = New OleDbCommand(String.Concat(New String() { "Delete * From [", ooO0__OO.O00.O__o.(), "] Where [Table] = '~TMPCLP", A_0, "'" }), OO_00oOO.DataTables(A_0).frd_Connection)
							OO_00oOO.DataTables(A_0).frd_Connection.Open()
							oleDbCommand.ExecuteNonQuery()
							OO_00oOO.DataTables(A_0).frd_Connection.Close()
						Else
							Try
								For Each obj3 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows
									Dim dataRow2 As DataRow = CType(obj3, DataRow)
									If Operators.CompareString(Conversions.ToString(dataRow2("Name")), A_0, True) = 0 Then
										dataRow2.Delete()
									End If
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						End If
					End If
					Dim num As Integer = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
					For i As Integer = 0 To num
						Dim c1DockingTabPage As C1DockingTabPage = Main.OO_O.o..OO_O_0Oo.___o.().TabPages(i)
						If Operators.CompareString(c1DockingTabPage.Name, A_0, True) = 0 Then
							If i > 0 Then
								Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = i - 1
							Else
								Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = i + 1
							End If
							Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Remove(c1DockingTabPage)
							Exit For
						End If
					Next
					Dim table As Table = OO_00oOO.Tables(A_0)
					Dim dataTable As DataTable = OO_00oOO.Tables(A_0).DataTable.BaseTable
					OO_00oOO.Tables.OO._O_o__.(A_0)
					OO_00oOO.DataTables.OoO_00.O.(A_0)
					O_O0OO.o__.O.().Remove(O_O0OO.o__.O.()(A_0).Oo._Oo0OO.())
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(A_0)
					table.OO0_.__.()
					dataTable.Reset()
					dataTable.Dispose()
					Me.OO0o00.0O_0o.(A_0)
					GC.Collect()
					GC.Collect()
					GC.Collect()
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x0600228F RID: 8847 RVA: 0x000EAF38 File Offset: 0x000E9138
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow("Table")), A_0, True) = 0 Then
						dataRow.Delete()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
			Try
				For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow2("Table")), A_0, True) = 0 OrElse Operators.CompareString(Conversions.ToString(dataRow2("Table")), "{" + A_0 + "}", True) = 0 OrElse Operators.CompareString(Conversions.ToString(dataRow2("Table")), "[" + A_0 + "]", True) = 0 Then
						dataRow2.Delete()
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
			Try
				For Each obj3 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows
					Dim dataRow3 As DataRow = CType(obj3, DataRow)
					If Operators.CompareString(Conversions.ToString(dataRow3("Table")), A_0, True) = 0 Then
						dataRow3.Delete()
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
			End Try
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()), True)
			Dim file As String = String.Concat(New String() { OO_00oOO.ProjectPath, "Bin\", o0OoOOoOOo0.oo00o.0OoO.(""), ".DataTable.", A_0, ".dll" })
			If OO_00oOO.FileSys.FileExists(file) Then
				OO_00oOO.FileSys.DeleteFile(file)
			End If
		End Sub

		' Token: 0x06002290 RID: 8848 RVA: 0x000EB1B4 File Offset: 0x000E93B4
		Public Function Save() As Boolean
			Dim list As List(Of String) = New List(Of String)()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				If o_oOooO_O.Editor IsNot Nothing Then
					o_oOooO_O.FinishEditing()
				End If
			End If
			Dim cancelEventArgs As CancelEventArgs = New CancelEventArgs()
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeSaveProject", New Object() { cancelEventArgs }, False, "项目", False)
			Dim result As Boolean
			If cancelEventArgs.Cancel Then
				result = False
			Else
				Try
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在保存，请稍候..."
					Application.DoEvents()
					Try
						For Each dataTable As DataTable In Me.OO0o00.0O_0o..Values
							If Operators.CompareString(dataTable.DataServer, "", True) > 0 Then
								If Operators.CompareString(dataTable.UpdateServer, "", True) > 0 Then
									If Not dataTable.o.o_O.() Then
										Return False
									End If
									Try
										For Each table As Table In OO_00oOO.Tables
											If table.View.o_o.O0ooOo.() Is dataTable.BaseTable Then
												table.Oo._0oO.()
											End If
										Next
									Finally
										Dim enumerator2 As IEnumerator(Of Table)
										If enumerator2 IsNot Nothing Then
											enumerator2.Dispose()
										End If
									End Try
									dataTable.O0o0.O_0_.()
								End If
							ElseIf dataTable.frd_IsTemporary OrElse dataTable.frd_IsInnerQuery OrElse dataTable.frd_IsOuterQuery Then
								dataTable.BaseTable.AcceptChanges()
							ElseIf Not dataTable.o.o_O.() Then
								Return False
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, DataTable).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					O_O0OO.OoO.0OO__0ooo.().Open()
					Try
						For Each oleDbConnection As OleDbConnection In O_O0OO.O._o_.().Values
							oleDbConnection.Open()
						Next
					Finally
						Dim enumerator3 As Dictionary(Of String, OleDbConnection).ValueCollection.Enumerator
						CType(enumerator3, IDisposable).Dispose()
					End Try
					Try
						For Each dataTable2 As DataTable In Me.OO0o00.0O_0o..Values
							If Operators.CompareString(dataTable2.UpdateServer, "", True) <= 0 Then
								dataTable2.oo_o0.0_.()
								If dataTable2.frd_IsInnerTable Then
									dataTable2.oO.o_0.(True, False)
								Else
									If Not dataTable2.AddByCode Then
										Try
											For Each table2 As Table In OO_00oOO.Tables
												If table2.View.o_o.O0ooOo.() Is dataTable2.BaseTable Then
													table2.Oo._0oO.()
												End If
											Next
										Finally
											Dim enumerator5 As IEnumerator(Of Table)
											If enumerator5 IsNot Nothing Then
												enumerator5.Dispose()
											End If
										End Try
									End If
									If dataTable2.frd_IsOuterTable Then
										list.Add(dataTable2.Name)
									End If
								End If
							End If
						Next
					Finally
						Dim enumerator4 As Dictionary(Of String, DataTable).ValueCollection.Enumerator
						CType(enumerator4, IDisposable).Dispose()
					End Try
					If list.Count > 0 Then
						Dim num As Integer = O_O0OO.OOOo.oo_OOOO_0.().Relations.Count - 1
						For i As Integer = 0 To num
							Try
								For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
									Dim dataRelation As DataRelation = CType(obj, DataRelation)
									If OO_00oOO.DataTables(dataRelation.ParentTable.TableName).frd_IsOuterTable AndAlso OO_00oOO.DataTables(dataRelation.ChildTable.TableName).frd_IsOuterTable Then
										Dim num2 As Integer = list.IndexOf(dataRelation.ParentTable.TableName)
										Dim num3 As Integer = list.IndexOf(dataRelation.ChildTable.TableName)
										If num2 > num3 Then
											list.Remove(dataRelation.ChildTable.TableName)
											list.Remove(dataRelation.ParentTable.TableName)
											list.Insert(num3, dataRelation.ParentTable.TableName)
											list.Insert(num2, dataRelation.ChildTable.TableName)
										End If
									End If
								Next
							Finally
								Dim enumerator6 As IEnumerator
								If TypeOf enumerator6 Is IDisposable Then
									TryCast(enumerator6, IDisposable).Dispose()
								End If
							End Try
						Next
						If O_O0OO.OOOo.oo_OOOO_0.().HasChanges() Then
							Dim num4 As Integer = list.Count - 1
							For j As Integer = 0 To num4
								Dim a_ As String = list(j)
								OO_00oOO.DataTables(a_).oo_.0oo_.(New DataRow(-1) {})
								OO_00oOO.DataTables(a_).O0_0oOO.0.(New DataRow(-1) {})
							Next
							For k As Integer = list.Count - 1 To 0 Step -1
								Dim a_2 As String = list(k)
								OO_00oOO.DataTables(a_2).oO.o_0.(New DataRow(-1) {})
							Next
						End If
					End If
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()), True)
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterSaveProject", Nothing, False, "项目", False)
					Main.OO_O.o..o._oOO0. = False
					Try
						For Each table3 As Table In OO_00oOO.Tables
							If table3.IsChild Then
								table3.Refresh()
							End If
							table3.foxGrid.Invalidate()
						Next
					Finally
						Dim enumerator7 As IEnumerator(Of Table)
						If enumerator7 IsNot Nothing Then
							enumerator7.Dispose()
						End If
					End Try
					result = Not O_O0OO.OOOo.oo_OOOO_0.().HasChanges()
				Catch ex As Exception
					result = False
				Finally
					Foxtable.RibbonMenu.StatusBar.Message1 = ""
					O_O0OO.OoO.0OO__0ooo.().Close()
					Try
						For Each oleDbConnection2 As OleDbConnection In O_O0OO.O._o_.().Values
							oleDbConnection2.Close()
						Next
					Finally
						Dim enumerator8 As Dictionary(Of String, OleDbConnection).ValueCollection.Enumerator
						CType(enumerator8, IDisposable).Dispose()
					End Try
				End Try
			End If
			Return result
		End Function

		' Token: 0x06002291 RID: 8849 RVA: 0x000EB82C File Offset: 0x000E9A2C
		Private Function GetTopParentName(re1 As DataRelation) As String
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If dataRelation.ChildTable Is re1.ParentTable Then
						Return Me.GetTopParentName(dataRelation)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return re1.ParentTable.TableName
		End Function

		' Token: 0x17000826 RID: 2086
		' (get) Token: 0x06002292 RID: 8850 RVA: 0x000EB8AC File Offset: 0x000E9AAC
		' (set) Token: 0x06002293 RID: 8851 RVA: 0x000EB8B4 File Offset: 0x000E9AB4
		Public Property AllowEdit As Boolean
			Get
				Return Me.OO0o00.0O_0o.
			End Get
			Set(value As Boolean)
				Me.OO0o00.0O_0o. = value
				Main.OO_O.o..Refresh()
			End Set
		End Property

		' Token: 0x17000827 RID: 2087
		' (get) Token: 0x06002294 RID: 8852 RVA: 0x000EB8C8 File Offset: 0x000E9AC8
		' (set) Token: 0x06002295 RID: 8853 RVA: 0x000EB8E8 File Offset: 0x000E9AE8
		Public Property PreserveEditMode As Boolean
			Get
				Dim oo0o00.0O_0o. As BooleanEnum = Me.OO0o00.0O_0o.
				Return Me.OO0o00.0O_0o. = 1
			End Get
			Set(value As Boolean)
				If value Then
					Me.OO0o00.0O_0o. = 1
				Else
					Me.OO0o00.0O_0o. = 2
				End If
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						dataTable.o0.0o_0.()
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x06002296 RID: 8854 RVA: 0x000EB948 File Offset: 0x000E9B48
		Public Sub RejectChanges()
			O_O0OO.OOOo.oo_OOOO_0.().RejectChanges()
			Try
				For Each table As Table In OO_00oOO.Tables
					table.ClearEditInfos()
					If Not table.IsRelation Then
						table.RefreshChildTables()
					End If
					table.NeedSaveSetting = False
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002297 RID: 8855 RVA: 0x000EB9B4 File Offset: 0x000E9BB4
		<oO0oooo("2755")>
		Public Sub Load(DataTableNames As String)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj5 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim array As String() = DataTableNames.Split(New Char() { "|"c })
				IL_1B:
				num2 = 3
				Dim array2 As String() = array
				Dim i As Integer = 0
				While i < array2.Length
					Dim text As String = array2(i)
					IL_2F:
					num2 = 4
					Dim flag As Boolean = False
					IL_34:
					num2 = 5
					If OO_00oOO.DataTables.Contains(text) Then
						IL_44:
						num2 = 6
						MessageBox.Show("[" + text + "]已经加载!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						IL_6A:
						num2 = 8
						Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.())
						IL_82:
						num2 = 9
						Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
						While enumerator.MoveNext()
							Dim obj As Object = enumerator.Current
							Dim dataRow As DataRow = CType(obj, DataRow)
							IL_A3:
							num2 = 10
							If Operators.CompareString(Conversions.ToString(dataRow("Name")), text, True) = 0 Then
								IL_C1:
								num2 = 11
								flag = True
								IL_C7:
								num2 = 12
								o0OoOOoOOo0.OOOOO.o000.(dataRow, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), True, False, Nothing)
							End If
							IL_101:
							num2 = 13
						End While
						IL_10D:
						num2 = 14
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
						IL_125:
						dataTable = Nothing
						IL_128:
						num2 = 16
						If Not flag Then
							IL_12F:
							num2 = 17
							o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), Me, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
						End If
						IL_15F:
						num2 = 18
						If OO_00oOO.DataTables.Contains(text) Then
							IL_173:
							num2 = 20
							i += 1
							Continue While
						End If
					End If
					IL_8AD:
					GoTo IL_AD7
				End While
				IL_187:
				num2 = 21
				Dim enumerator2 As IEnumerator = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_1BD:
					num2 = 22
					Dim right As String = Conversions.ToString(dataRow2("ParentTable"))
					IL_1D3:
					num2 = 23
					Dim left As String = Conversions.ToString(dataRow2("ChildTable"))
					IL_1E9:
					num2 = 24
					Dim flag2 As Boolean = False
					IL_1EF:
					num2 = 25
					For Each text2 As String In array
						IL_201:
						num2 = 26
						If Operators.CompareString(text2, right, True) = 0 OrElse Operators.CompareString(left, text2, True) = 0 Then
							IL_21C:
							num2 = 27
							flag2 = True
						End If
						IL_222:
						num2 = 28
					Next
					IL_233:
					num2 = 29
					If flag2 Then
						IL_23A:
						num2 = 30
						o0OoOOoOOo0.OO0._Oo0o.(dataRow2, O_O0OO.OOOo.oo_OOOO_0.())
						IL_249:
						num2 = 31
						Oo00.o00O0O_.O.(Conversions.ToString(dataRow2("Name")), False, False)
					End If
					IL_264:
					num2 = 32
				End While
				IL_273:
				num2 = 33
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_28B:
				num2 = 34
				Dim enumerator3 As IEnumerator = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.GetEnumerator()
				While enumerator3.MoveNext()
					Dim obj3 As Object = enumerator3.Current
					Dim dataRow3 As DataRow = CType(obj3, DataRow)
					IL_2C1:
					num2 = 35
					Dim text3 As String = Conversions.ToString(dataRow3("Table"))
					IL_2D7:
					num2 = 36
					Dim flag3 As Boolean = False
					IL_2DD:
					num2 = 37
					For Each left2 As String In array
						IL_2EF:
						num2 = 38
						If Operators.CompareString(left2, text3, True) = 0 Then
							IL_2FE:
							num2 = 39
							flag3 = True
						End If
						IL_304:
						num2 = 40
					Next
					IL_315:
					num2 = 41
					If flag3 Then
						IL_31F:
						num2 = 42
						Dim a_ As String = Conversions.ToString(dataRow3("Column"))
						IL_335:
						num2 = 43
						Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow3("DataType")), ColumnDataTypeEnum)
						IL_34B:
						num2 = 44
						Dim a_2 As Integer
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] AndAlso Not dataRow3.IsNull("Maxlength") Then
							IL_365:
							num2 = 45
							a_2 = Conversions.ToInteger(dataRow3("Maxlength"))
						Else
							IL_37D:
							num2 = 47
							a_2 = -1
						End If
						IL_383:
						num2 = 48
						o0OoOOoOOo0.O0OoO_0o.O.(O_O0OO.OOOo.oo_OOOO_0.().Tables(text3), a_, columnDataTypeEnum, String.Empty, a_2)
					End If
					IL_3A7:
					num2 = 49
				End While
				IL_3B6:
				num2 = 50
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
				IL_3CE:
				num2 = 51
				For Each a_3 As String In array
					IL_3E3:
					num2 = 52
					OO_00oOO.DataTables(a_3).o.0O000_.()
					IL_3F7:
					num2 = 53
					OO_00oOO.DataTables(a_3).o0O.ooO00.()
					IL_40B:
					num2 = 54
					Dim enumerator4 As IEnumerator(Of DataCol) = OO_00oOO.DataTables(a_3).DataCols.GetEnumerator()
					While enumerator4.MoveNext()
						Dim dataCol As DataCol = enumerator4.Current
						IL_431:
						num2 = 55
						dataCol.o_.Oo00_O_00_.()
						IL_43B:
						num2 = 56
					End While
					IL_447:
					num2 = 57
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
					IL_455:
					num2 = 58
				Next
				IL_469:
				num2 = 59
				Dim enumerator5 As IEnumerator = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj4 As Object = enumerator5.Current
					Dim dataRow4 As DataRow = CType(obj4, DataRow)
					IL_49F:
					num2 = 60
					Dim text4 As String = Conversions.ToString(dataRow4("Table"))
					IL_4B5:
					num2 = 61
					Dim flag4 As Boolean = False
					IL_4BB:
					num2 = 62
					For Each left3 As String In array
						IL_4CD:
						num2 = 63
						If Operators.CompareString(left3, text4, True) = 0 Then
							IL_4DC:
							num2 = 64
							flag4 = True
						End If
						IL_4E2:
						num2 = 65
					Next
					IL_4F3:
					num2 = 66
					If flag4 Then
						IL_4FA:
						num2 = 67
						Dim name As String = Conversions.ToString(dataRow4("Column"))
						IL_510:
						num2 = 68
						Dim text5 As String = Conversions.ToString(dataRow4("Expression"))
						IL_526:
						num2 = 69
						If Operators.CompareString(text5, "", True) = 0 Then
							IL_538:
							num2 = 70
							text5 = String.Empty
						End If
						IL_542:
						num2 = 71
						Me.OO0o00.0O_0o.(OO_00oOO.DataTables(text4).BaseTable.Columns(name), text5)
					End If
					IL_56A:
					num2 = 72
				End While
				IL_579:
				num2 = 73
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_591:
				num2 = 74
				OO_00oOO.Tables.OO._O_o__.()
				IL_59E:
				num2 = 75
				For Each a_4 As String In array
					IL_5B0:
					num2 = 76
					Main.OO_O.o..o0_o_o_0.0O.(a_4, True, True)
					IL_5C1:
					num2 = 77
				Next
				IL_5D2:
				num2 = 78
				Dim enumerator6 As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator6.MoveNext()
					Dim table As Table = enumerator6.Current
					IL_5EF:
					num2 = 79
					Dim flag5 As Boolean = False
					IL_5F5:
					num2 = 80
					For Each left4 As String In array
						IL_607:
						num2 = 81
						If Operators.CompareString(left4, table.DataTable.Name, True) = 0 Then
							IL_620:
							num2 = 82
							flag5 = True
						End If
						IL_626:
						num2 = 83
					Next
					IL_637:
					num2 = 84
					If flag5 Then
						IL_641:
						num2 = 85
						If table.IsRelation Then
							IL_650:
							num2 = 86
							If table.foxGrid.FindForm() Is Nothing Then
								IL_664:
								num2 = 88
								table.foxGrid.Visible = False
								IL_674:
								num2 = 89
								Main.OO_O.o..Controls.Add(table.foxGrid)
								IL_68D:
								num2 = 90
								table.O.__O0o0.(True)
								IL_699:
								num2 = 91
								Main.OO_O.o..Controls.Remove(table.foxGrid)
								IL_6B2:
								num2 = 92
								table.foxGrid.Visible = True
								IL_6C2:
								num2 = 93
								If table._frdAutoOpen Then
									IL_6CE:
									num2 = 94
									table.Visible = True
								End If
								IL_6D9:
								num2 = 95
								table.foxGrid.o_.o. = table.foxGrid.BottomRow
							End If
						Else
							IL_6F9:
							num2 = 97
							If table.TableType Is Nothing AndAlso Not table.View.O0O.o__0.() Then
								IL_719:
								num2 = 98
								Dim enumerator7 As IEnumerator(Of Col) = table.Cols.GetEnumerator()
								While enumerator7.MoveNext()
									Dim col As Col = enumerator7.Current
									IL_735:
									num2 = 99
									If col.DataCol.ExtendType = 4 OrElse col.DataCol.ExtendType = 6 OrElse (col.DataCol.IsString AndAlso (col.DataCol.MaxLength = -1 OrElse col.DataCol.MaxLength > 2048)) Then
										IL_786:
										num2 = 100
										If col.DataCol.AutoOpen Then
											IL_797:
											num2 = 101
											col.OpenWindow(0)
										End If
									End If
									IL_7A2:
									num2 = 102
								End While
								IL_7B1:
								num2 = 103
								If enumerator7 IsNot Nothing Then
									enumerator7.Dispose()
								End If
							End If
						End If
					End If
					IL_7BF:
					num2 = 104
				End While
				IL_7CE:
				num2 = 105
				If enumerator6 IsNot Nothing Then
					enumerator6.Dispose()
				End If
				IL_7DC:
				num2 = 106
				Dim enumerator8 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator8.MoveNext()
					Dim form As Foxtable.WinForm.Form = enumerator8.Current
					IL_7F9:
					num2 = 107
					If form.AutoOpen AndAlso form.FormStyle <> FormStyleEnum.模式 Then
						IL_812:
						num2 = 108
						If form.FormStyle = FormStyleEnum.主窗口 OrElse form.FormStyle = FormStyleEnum.停靠 OrElse form.FormStyle = FormStyleEnum.并列 Then
							IL_832:
							num2 = 109
							Dim flag6 As Boolean = False
							IL_838:
							num2 = 110
							For Each left5 As String In array
								IL_84A:
								num2 = 111
								If Operators.CompareString(left5, form.TableName, True) = 0 Then
									IL_85E:
									num2 = 112
									flag6 = True
								End If
								IL_864:
								num2 = 113
							Next
							IL_875:
							num2 = 114
							If flag6 Then
								IL_87C:
								num2 = 115
								form.Open(Integer.MaxValue, Integer.MaxValue)
							End If
						End If
					End If
					IL_890:
					num2 = 116
				End While
				IL_89F:
				num2 = 117
				If enumerator8 IsNot Nothing Then
					enumerator8.Dispose()
					GoTo IL_8AD
				End If
				GoTo IL_8AD
				IL_8B2:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_A98:
				GoTo IL_ACC
				IL_A9A:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_AAA:
			Catch obj6 When endfilter(TypeOf obj5 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj6, Exception)
				GoTo IL_A9A
			End Try
			IL_ACC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AD7:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002298 RID: 8856 RVA: 0x000EC4BC File Offset: 0x000EA6BC
		Private Sub <<EMPTY_NAME>>(A_0 As DataColumn, A_1 As String)
			Try
				A_0.Expression = A_1
			Catch a_ As Exception
				MessageBox.Show(String.Concat(New String() { "无法将[", A_0.Table.TableName, "]表的[", A_0.ColumnName, "]列的表达式设置为:" & vbCrLf, A_1, vbCrLf & "如果确定表达式无语法错误，且参与运算的各列的名称准确无误，那么请检查各列的数据类型是否正确，例如只有数值列才能参与加、减、乘、除等数学运算！" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06002299 RID: 8857 RVA: 0x000EC550 File Offset: 0x000EA750
		<oO0oooo("2756")>
		Public Sub Unload(DataTableNames As String)
			Try
				OO_00oOO.LockBaseMainForm()
				Dim array As String() = DataTableNames.Split(New Char() { "|"c })
				Try
					For Each relation As Relation In OO_00oOO.Relations
						Dim right As String = relation.ParentTable.Name
						Dim right2 As String = relation.ChildTable.Name
						Dim flag As Boolean
						Dim flag2 As Boolean
						For Each left As String In array
							If Operators.CompareString(left, right, True) = 0 Then
								flag = True
							End If
							If Operators.CompareString(left, right2, True) = 0 Then
								flag2 = True
							End If
						Next
						If flag Xor flag2 Then
							MessageBox.Show("关联表必须同步卸载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Relation)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				For Each a_ As String In array
					Try
						For Each dataCol As DataCol In OO_00oOO.DataTables(a_).DataCols
							If Operators.CompareString(dataCol.Expression, "", True) > 0 Then
								dataCol.Expression = String.Empty
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of DataCol)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				Next
				For k As Integer = OO_00oOO.Relations.Count - 1 To 0 Step -1
					Dim relation2 As Relation = OO_00oOO.Relations(k)
					Dim right3 As String = relation2.ParentTable.Name
					Dim right4 As String = relation2.ChildTable.Name
					Dim flag3 As Boolean = False
					Dim flag4 As Boolean = False
					For Each left2 As String In array
						If Operators.CompareString(left2, right3, True) = 0 Then
							flag3 = True
						End If
						If Operators.CompareString(left2, right4, True) = 0 Then
							flag4 = True
						End If
					Next
					If flag3 AndAlso flag4 Then
						Oo00.OO.0O0o.(relation2.Name)
					End If
				Next
				For Each tableName As String In array
					Me.Remove(tableName)
				Next
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				OO_00oOO.UnlockBaseMainForm()
			End Try
		End Sub

		' Token: 0x0600229A RID: 8858 RVA: 0x000EC7C4 File Offset: 0x000EA9C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetDetailNames() As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			O_O0OO.OoO.0OO__0ooo.().Open()
			Dim array As DataRow() = O_O0OO.OoO.0OO__0ooo.().GetSchema("Tables").[Select]("[TABLE_TYPE]='TABLE' ")
			For i As Integer = 0 To array.Length - 1
				Dim text As String = Conversions.ToString(array(i)("TABLE_NAME"))
				If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) AndAlso text.StartsWith("~TMPCLP") Then
					list.Add(text.Substring(7) + ".1")
				End If
			Next
			O_O0OO.OoO.0OO__0ooo.().Close()
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.())
			Try
				For Each obj As Object In dataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim otherTableTypeEnum As OtherTableTypeEnum = Conversions.ToInteger(dataRow("Type"))
					Dim text2 As String = Conversions.ToString(dataRow("Name"))
					If otherTableTypeEnum = 2 Then
						text2 += ".2"
					ElseIf otherTableTypeEnum Is Nothing Then
						text2 = text2 + ".3." + dataRow("DataSource").ToString()
					ElseIf otherTableTypeEnum = 1 Then
						text2 = text2 + ".4." + dataRow("DataSource").ToString()
					End If
					list.Add(text2)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()).Rows
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					list.Add(Conversions.ToString(dataRow2("Name")) + ".5")
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Return list
		End Function

		' Token: 0x0600229B RID: 8859 RVA: 0x000EC9D0 File Offset: 0x000EABD0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetDataTableNames() As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			O_O0OO.OoO.0OO__0ooo.().Open()
			Dim array As DataRow() = O_O0OO.OoO.0OO__0ooo.().GetSchema("Tables").[Select]("[TABLE_TYPE]='TABLE' ")
			For i As Integer = 0 To array.Length - 1
				Dim text As String = Conversions.ToString(array(i)("TABLE_NAME"))
				If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) AndAlso text.StartsWith("~TMPCLP") Then
					list.Add(text.Substring(7))
				End If
			Next
			O_O0OO.OoO.0OO__0ooo.().Close()
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.())
			Try
				For Each obj As Object In dataTable.Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					list.Add(Conversions.ToString(dataRow("Name")))
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each obj2 As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()).Rows
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					list.Add(Conversions.ToString(dataRow2("Name")))
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Return list
		End Function

		' Token: 0x04000E38 RID: 3640
		Friend <<EMPTY_NAME>> As Dictionary(Of String, DataTable)

		' Token: 0x04000E39 RID: 3641
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E3A RID: 3642
		Private <<EMPTY_NAME>> As BooleanEnum
	End Class
End Namespace
