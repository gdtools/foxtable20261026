Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000308 RID: 776
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("1438")>
	Public Class RowCollection
		Implements IEnumerable(Of Row)

		' Token: 0x060028EE RID: 10478 RVA: 0x00113184 File Offset: 0x00111384
		Friend Sub New(A_0 As Table)
			Me.oo0Ooo.o_0__0_. = A_0
		End Sub

		' Token: 0x1700099D RID: 2461
		' (get) Token: 0x060028EF RID: 10479 RVA: 0x00113193 File Offset: 0x00111393
		Friend ReadOnly Property View As O_0
			Get
				Return Me.oo0Ooo.o_0__0_..View
			End Get
		End Property

		' Token: 0x1700099E RID: 2462
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As Row
			Get
				Return New Row(Me.oo0Ooo.o_0__0_., Me.View.O0O_0_0__.0O.(Index))
			End Get
		End Property

		' Token: 0x1700099F RID: 2463
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer, IncludeGroup As Boolean) As Row
			Get
				Dim result As Row
				If IncludeGroup Then
					result = New Row(Me.oo0Ooo.o_0__0_., Index)
				Else
					result = New Row(Me.oo0Ooo.o_0__0_., Me.View.O0O_0_0__.0O.(Index))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009A0 RID: 2464
		' (get) Token: 0x060028F2 RID: 10482 RVA: 0x001131F4 File Offset: 0x001113F4
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oo0Ooo.o_0__0_..ooO__oo0O.0.(False)
			End Get
		End Property

		' Token: 0x170009A1 RID: 2465
		' (get) Token: 0x060028F3 RID: 10483 RVA: 0x00113202 File Offset: 0x00111402
		Public ReadOnly Property Count(IncludeGroup As Boolean) As Integer
			Get
				Return Me.oo0Ooo.o_0__0_..ooO__oo0O.0.(IncludeGroup)
			End Get
		End Property

		' Token: 0x060028F4 RID: 10484 RVA: 0x00113210 File Offset: 0x00111410
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Row) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Row).GetEnumerator
			Return New O_0o_0o_o0O_(Me.oo0Ooo.o_0__0_.)
		End Function

		' Token: 0x060028F5 RID: 10485 RVA: 0x0011321D File Offset: 0x0011141D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O_0o_0o_o0O_(Me.oo0Ooo.o_0__0_.)
		End Function

		' Token: 0x060028F6 RID: 10486 RVA: 0x0011322A File Offset: 0x0011142A
		Public Function Delete(Index As Integer) As Boolean
			Return Me(Index).Delete()
		End Function

		' Token: 0x060028F7 RID: 10487 RVA: 0x00113238 File Offset: 0x00111438
		Public Function InsertNew() As Row
			Dim topRow As Integer = Me.oo0Ooo.o_0__0_..foxGrid.TopRow
			If Me.oo0Ooo.o_0__0_..foxGrid.Editor IsNot Nothing Then
				Me.oo0Ooo.o_0__0_..foxGrid.FinishEditing()
			End If
			Dim result As Row
			If Me.oo0Ooo.o_0__0_..foxGrid.Editor IsNot Nothing Then
				result = Nothing
			ElseIf Not Me.oo0Ooo.o_0__0_..O.00O0.() Then
				result = Nothing
			ElseIf Not Me.oo0Ooo.o_0__0_.() Then
				result = Nothing
			ElseIf Not Me.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().Columns.Contains("_SortKey") Then
				MessageBox.Show("此表不支持插入行功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			ElseIf Operators.CompareString(Me.oo0Ooo.o_0__0_..View.oO_O.o_OOO.(), "", True) > 0 Then
				MessageBox.Show("不能在排序状态下插入行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			Else
				Me.oo0Ooo.o_0__0_..StopRedraw()
				Dim num As Decimal
				If Me.oo0Ooo.o_0__0_..Position < 0 Then
					num = 1D
				ElseIf Me.oo0Ooo.o_0__0_..Position = 0 Then
					num = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(0)("_SortKey"))), 1D)
				Else
					Dim num2 As Integer
					For i As Integer = Me.View.Position To Me.View.Count - 1
						num2 = i
						If Me.View.O0O_0_0__.0O.(i).Row.RowState <> DataRowState.Added Then
							Exit For
						End If
					Next
					Dim num3 As Integer
					For i As Integer = Me.View.Position - 1 To 0 Step -1
						num3 = i
						If Me.View.O0O_0_0__.0O.(i).Row.RowState <> DataRowState.Added Then
							Exit For
						End If
					Next
					If num3 = num2 Then
						num = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.o_o.O0ooOo.()("_SortKey"))), 1D)
					Else
						If Me.View.O0O_0_0__.0O.(num3).Row.RowState = DataRowState.Added AndAlso Me.View.O0O_0_0__.0O.(num2).Row.RowState = DataRowState.Added Then
							Dim num4 As Decimal = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num2)("_SortKey"))), 1D)
							If Me.View.Position = num2 Then
								num = num4
								num4 = Decimal.Subtract(num4, 1D)
							End If
							Dim dictionary As Dictionary(Of DataRow, Decimal) = New Dictionary(Of DataRow, Decimal)()
							Dim num5 As Integer = num2 - 1
							Dim num6 As Integer = num3
							For j As Integer = num5 To num6 Step -1
								dictionary.Add(Me.View.O0O_0_0__.0O.(j).Row, num4)
								If j = Me.View.Position Then
									num = Decimal.Subtract(num4, 1D)
									num4 = Decimal.Subtract(num4, 2D)
								Else
									num4 = Decimal.Subtract(num4, 1D)
								End If
							Next
							Try
								For Each dataRow As DataRow In dictionary.Keys
									dataRow("_SortKey") = dictionary(dataRow)
								Next
								GoTo IL_65C
							Finally
								Dim enumerator As Dictionary(Of DataRow, Decimal).KeyCollection.Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
						End If
						If Me.View.O0O_0_0__.0O.(num3).Row.RowState = DataRowState.Added Then
							Dim num7 As Decimal = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num2)("_SortKey"))), 1D)
							If Me.View.Position = num2 Then
								num = num7
								num7 = Decimal.Subtract(num7, 1D)
							End If
							Dim num8 As Integer = num2 - 1
							Dim num9 As Integer = num3
							For k As Integer = num8 To num9 Step -1
								If k = Me.View.Position Then
									num = num7
									Me.View.O0O_0_0__.0O.(k)("_SortKey") = Decimal.Subtract(num7, 1D)
									num7 = Decimal.Subtract(num7, 2D)
								Else
									Me.View.O0O_0_0__.0O.(k)("_SortKey") = num7
									num7 = Decimal.Subtract(num7, 1D)
								End If
							Next
						ElseIf Me.View.O0O_0_0__.0O.(num2).Row.RowState = DataRowState.Added Then
							Dim num10 As Decimal = Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num3)("_SortKey"))), 1D)
							Dim num11 As Integer = num3 + 1
							Dim num12 As Integer = num2
							For l As Integer = num11 To num12
								If l = Me.View.Position Then
									num = num10
									Me.View.O0O_0_0__.0O.(l)("_SortKey") = Decimal.Add(num10, 1D)
									num10 = Decimal.Add(num10, 2D)
								Else
									Me.View.O0O_0_0__.0O.(l)("_SortKey") = num10
									num10 = Decimal.Add(num10, 1D)
								End If
							Next
						Else
							Dim num13 As Decimal = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num3)("_SortKey")))
							Dim d As Decimal = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num2)("_SortKey")))
							Dim num14 As Integer = num2 - num3 + 1
							Dim num15 As Decimal = Math.Round(Decimal.Divide(Decimal.Subtract(d, num13), New Decimal(num14)), 14)
							Dim num16 As Decimal = Decimal.Add(num13, num15)
							If num14 = 2 Then
								num = num16
							Else
								If Me.View.Position = num2 Then
									num = Decimal.Add(num13, Decimal.Multiply(num15, New Decimal(num14 - 1)))
								End If
								Dim num17 As Integer = num3 + 1
								Dim num18 As Integer = num2 - 1
								For m As Integer = num17 To num18
									If m = Me.View.Position Then
										num = num16
										Me.View.O0O_0_0__.0O.(m)("_SortKey") = Decimal.Add(num16, num15)
										num16 = Decimal.Add(Decimal.Add(num16, num15), num15)
									Else
										Me.View.O0O_0_0__.0O.(m)("_SortKey") = num16
										num16 = Decimal.Add(num16, num15)
									End If
								Next
							End If
						End If
					End If
				End If
				IL_65C:
				Dim dataRow2 As DataRow = Me.oo0Ooo.o_0__0_..DataTable.BaseTable.NewRow()
				If Me.oo0Ooo.o_0__0_..IsChild Then
					Dim dataRelation As DataRelation = Me.oo0Ooo.o_0__0_..View.O0O_0_0__.0O.()
					Dim num19 As Integer = dataRelation.ChildColumns.Length - 1
					For n As Integer = 0 To num19
						dataRow2(dataRelation.ChildColumns(n).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(n).ColumnName))
					Next
				End If
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable.BaseTable Is Me.oo0Ooo.o_0__0_..DataTable.BaseTable Then
							table.View.SuspendBinding()
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				dataRow2("_SortKey") = num
				Me.oo0Ooo.o_0__0_..DataTable.BaseTable.Rows.Add(dataRow2)
				Try
					For Each table2 As Table In OO_00oOO.Tables
						If table2.DataTable.BaseTable Is Me.oo0Ooo.o_0__0_..DataTable.BaseTable Then
							table2.View.ResumeBinding()
							table2.ResetCurrentItem()
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of Table)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				Me.oo0Ooo.o_0__0_..Position = Me.oo0Ooo.o_0__0_..FindRow(New DataRow(dataRow2))
				Me.oo0Ooo.o_0__0_..foxGrid.TopRow = topRow
				Me.oo0Ooo.o_0__0_..ResumeRedraw()
				result = Me.oo0Ooo.o_0__0_..Current
			End If
			Return result
		End Function

		' Token: 0x060028F8 RID: 10488 RVA: 0x00113A88 File Offset: 0x00111C88
		Public Function AddNew(Optional count As Integer = 1) As Row
			If Me.oo0Ooo.o_0__0_..foxGrid.Editor IsNot Nothing Then
				Me.oo0Ooo.o_0__0_..foxGrid.FinishEditing()
			End If
			Dim result As Row
			If Me.oo0Ooo.o_0__0_..foxGrid.Editor IsNot Nothing Then
				result = Nothing
			ElseIf Not Me.oo0Ooo.o_0__0_..O.00O0.() Then
				result = Nothing
			ElseIf Not Me.oo0Ooo.o_0__0_.() Then
				result = Nothing
			Else
				Dim tableName As String = Me.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().TableName
				Dim dataRow As DataRow = Nothing
				Try
					If count > 5 Then
						Me.oo0Ooo.o_0__0_..foxGrid.BeginUpdate()
					End If
					For i As Integer = 1 To count
						Dim dataRow2 As DataRow = Me.oo0Ooo.o_0__0_.()
						If dataRow2 Is Nothing Then
							Return Nothing
						End If
						If i = 1 Then
							dataRow = dataRow2
						End If
						If dataRow2.RowState = DataRowState.Detached Then
							Exit For
						End If
						dataRow2.EndEdit()
					Next
					If dataRow.RowState <> DataRowState.Detached Then
						Me.View.Position = Me.View.Count - count
						If Me.View.o_o.O0ooOo.() IsNot Nothing AndAlso Me.View.o_o.O0ooOo.().Row IsNot dataRow Then
							Me.View.Position = Me.View.o_o.O0ooOo.(dataRow)
						End If
					End If
					If Me.oo0Ooo.o_0__0_..foxGrid.Row <= Me.oo0Ooo.o_0__0_..foxGrid.Rows.Fixed AndAlso Me.View.o_o.O0ooOo.() IsNot Nothing Then
						Me.oo0Ooo.o_0__0_..foxGrid.Row = Me.oo0Ooo.o_0__0_..foxGrid.Rows.Fixed
						Me.oo0Ooo.o_0__0_..View.o_._0O0o_OoO.()
						Me.oo0Ooo.o_0__0_..View.Oo._Oo0OO.()
					End If
					If Me.View.o_o.O0ooOo.() IsNot Nothing AndAlso Me.View.o_o.O0ooOo.().Row Is dataRow Then
						Dim position As Integer = Me.View.Position
						If Me.oo0Ooo.o_0__0_..GrandTotal AndAlso Me.View.Count = 1 AndAlso Me.oo0Ooo.o_0__0_..Grid.Row = Me.oo0Ooo.o_0__0_..Grid.Rows.Count - 1 Then
							Me.oo0Ooo.o_0__0_..Grid.Row = Me.oo0Ooo.o_0__0_..Grid.Rows.Fixed
						End If
						Return New Row(Me.oo0Ooo.o_0__0_., Me.View.o_o.O0ooOo.())
					End If
					If dataRow IsNot Nothing Then
						Return New Row(Me.oo0Ooo.o_0__0_., dataRow)
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					If count > 5 Then
						Me.oo0Ooo.o_0__0_..foxGrid.EndUpdate()
					End If
				End Try
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060028F9 RID: 10489 RVA: 0x00113D5C File Offset: 0x00111F5C
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim dataRowEventArgs As DataRowEventArgs = New DataRowEventArgs(OO_00oOO.DataTables(Me.View.o_o.O0ooOo.().TableName), Nothing)
			Dim a_ As String = "BeforeAddDataRow"
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.View.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { dataRowEventArgs }, False, Me.oo0Ooo.o_0__0_..DataTable.Name, False)
			If Not dataRowEventArgs.Cancel AndAlso Me.oo0Ooo.o_0__0_..DataTable.GlobalHandler.BeforeAddDataRow Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { dataRowEventArgs }, False, "全局表事件", False)
			End If
			Return Not dataRowEventArgs.Cancel
		End Function

		' Token: 0x060028FA RID: 10490 RVA: 0x00113E18 File Offset: 0x00112018
		Private Function <<EMPTY_NAME>>() As DataRow
			Dim tableName As String = Me.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().TableName
			Dim result As DataRow
			Try
				If OO_00oOO.DataTables(tableName).BaseTable.PrimaryKey.Length > 0 AndAlso Not OO_00oOO.DataTables(tableName).frd_AutoIncrement Then
					Dim dataRowView As DataRowView = CType(Me.oo0Ooo.o_0__0_..View.AddNew(), DataRowView)
					If dataRowView.IsEdit AndAlso dataRowView.Row.Table.PrimaryKey.Length = 1 AndAlso Not dataRowView.Row.IsNull(dataRowView.Row.Table.PrimaryKey(0)) Then
						dataRowView.EndEdit()
					End If
					result = dataRowView.Row
				Else
					Dim dataRow As DataRow = Me.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().NewRow()
					If Me.oo0Ooo.o_0__0_..IsChild Then
						Dim dataRelation As DataRelation = Me.oo0Ooo.o_0__0_..View.O0O_0_0__.0O.()
						Dim num As Integer = dataRelation.ChildColumns.Length - 1
						For i As Integer = 0 To num
							dataRow(dataRelation.ChildColumns(i).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(i).ColumnName))
						Next
					End If
					Me.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().Rows.Add(dataRow)
					result = dataRow
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x060028FB RID: 10491 RVA: 0x00113FBC File Offset: 0x001121BC
		Public Sub Remove(Index As Integer)
			Me(Index).Remove()
		End Sub

		' Token: 0x040010CE RID: 4302
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
