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
	' Token: 0x02000295 RID: 661
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("1428")>
	Public Class DataColCollection
		Implements IEnumerable(Of DataCol)

		' Token: 0x06002115 RID: 8469 RVA: 0x000D84AC File Offset: 0x000D66AC
		Public Sub New(A_0 As DataTable)
			Me.O_0__o.o_0o. = New Dictionary(Of String, DataCol)()
			Me.o.0OoOo. = A_0
			Try
				For Each obj As Object In Me.o.0OoOo..Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) Then
						Me.O_0__o.o_0o..Add(dataColumn.ColumnName, New DataCol(dataColumn))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002116 RID: 8470 RVA: 0x000D8548 File Offset: 0x000D6748
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O_0__o.o_0o..Remove(A_0)
			Me.O_0__o.o_0o..Add(A_0, New DataCol(Me.o.0OoOo..Columns(A_0)))
		End Sub

		' Token: 0x170007BB RID: 1979
		' (get) Token: 0x06002117 RID: 8471 RVA: 0x000D8579 File Offset: 0x000D6779
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O_0__o.o_0o..Count
			End Get
		End Property

		' Token: 0x170007BC RID: 1980
		' (get) Token: 0x06002118 RID: 8472 RVA: 0x000D8588 File Offset: 0x000D6788
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(ColumnName As String) As DataCol
			Get
				Dim result As DataCol
				If Me.O_0__o.o_0o..ContainsKey(ColumnName) Then
					result = Me.O_0__o.o_0o.(ColumnName)
				Else
					Try
						For Each text As String In Me.O_0__o.o_0o..Keys
							If Operators.CompareString(text, ColumnName, True) = 0 Then
								Return Me.O_0__o.o_0o.(text)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, DataCol).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					MessageBox.Show(Me.o.0OoOo..TableName + "不存在名为 """ + ColumnName + """的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170007BD RID: 1981
		' (get) Token: 0x06002119 RID: 8473 RVA: 0x000D863C File Offset: 0x000D683C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(idx As Integer) As DataCol
			Get
				Dim num As Integer = 0
				Try
					For Each key As String In Me.O_0__o.o_0o..Keys
						If num = idx Then
							Return Me.O_0__o.o_0o.(key)
						End If
						num += 1
					Next
				Finally
					Dim enumerator As Dictionary(Of String, DataCol).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				MessageBox.Show("列索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return Nothing
			End Get
		End Property

		' Token: 0x170007BE RID: 1982
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As DataCol
			Get
				Dim result As DataCol
				If TypeOf A_0 Is String Then
					result = Me.get_Item(A_0.ToString())
				Else
					Dim idx As Integer = -1
					If Integer.TryParse(A_0.ToString(), idx) Then
						result = Me.get_Item(idx)
					Else
						result = Me.get_Item(A_0.ToString())
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600211B RID: 8475 RVA: 0x000D870C File Offset: 0x000D690C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				Me.o.0OoOo..Columns(A_0).ColumnName = A_1
				Dim value As DataCol = Me.O_0__o.o_0o.(A_0)
				Me.O_0__o.o_0o..Remove(A_0)
				Me.O_0__o.o_0o..Add(A_1, value)
			Catch ex As Exception
				MessageBox.Show("无法重命名列""" + A_0 + """，原因：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return True
		End Function

		' Token: 0x0600211C RID: 8476 RVA: 0x000D879C File Offset: 0x000D699C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Try
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.View.o_o.O0ooOo.() Is Me.o.0OoOo. Then
							table.CloseRecordGrid()
							If table.Cols.Contains(A_0) Then
								table.Cols(A_0).CloseWindow()
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Try
					For Each table2 As Table In OO_00oOO.Tables
						If table2.foxGrid.FindForm() IsNot Nothing AndAlso Operators.CompareString(table2.DataTable.Name, Me.o.0OoOo..TableName, True) = 0 Then
							table2._frdTableLayout.OOooOOo_.0_0_o.()
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Table)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				OO_00oOO.SystemReady = False
				Me.o.0OoOo..Columns.Remove(A_0)
				OO_00oOO.SystemReady = True
				Try
					For Each table3 As Table In OO_00oOO.Tables
						If table3.View.o_o.O0ooOo.() Is Me.o.0OoOo. AndAlso table3.Cols.Contains(A_0) Then
							table3.Cols.Remove(A_0)
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of Table)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				Me.O_0__o.o_0o..Remove(A_0)
				If Not O_O0OO.o0OoO00OO.00O. Then
					Me.O_0__o.o_0o.()
				End If
				Try
					For Each table4 As Table In OO_00oOO.Tables
						If table4.foxGrid.FindForm() IsNot Nothing Then
							table4.O.__O0o0.(True, True)
							If Operators.CompareString(table4.DataTable.Name, Me.o.0OoOo..TableName, True) = 0 Then
								table4._frdTableLayout.Oo_.oo_oOo_oO.()
							End If
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator(Of Table)
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
				End Try
			Catch ex As Exception
				MessageBox.Show("无法删除列""" + A_0 + """，原因：" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return False
			End Try
			Return True
		End Function

		' Token: 0x0600211D RID: 8477 RVA: 0x000D8A2C File Offset: 0x000D6C2C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Add(ParamArray args As Object()) As DataCol
			Dim columnName As String = Conversions.ToString(args(0))
			Dim dataType As Type = ooO.o.O_0000_O.(Conversions.ToString(args(1)))
			Dim result As DataCol
			Select Case args.Length
				Case 2
					result = Me.Add(columnName, dataType)
				Case 3
					If TypeOf args(2)Is String Then
						Dim expression As String = Conversions.ToString(args(2))
						result = Me.Add(columnName, dataType, expression)
					ElseIf TypeOf args(2)Is Integer Then
						Dim maxLength As Integer = Conversions.ToInteger(args(2))
						result = Me.Add(columnName, dataType, maxLength)
					End If
				Case 4
					If TypeOf args(2)Is String AndAlso TypeOf args(3)Is String Then
						Dim expression2 As String = Conversions.ToString(args(2))
						Dim caption As String = Conversions.ToString(args(3))
						result = Me.Add(columnName, dataType, expression2, caption)
					ElseIf TypeOf args(2)Is Integer AndAlso TypeOf args(3)Is String Then
						Dim maxLength2 As Integer = Conversions.ToInteger(args(2))
						Dim expression3 As String = Conversions.ToString(args(3))
						result = Me.Add(columnName, dataType, maxLength2, expression3)
					End If
				Case 5
					Dim maxLength3 As Integer = Conversions.ToInteger(args(2))
					Dim expression4 As String = Conversions.ToString(args(3))
					Dim caption2 As String = Conversions.ToString(args(4))
					result = Me.Add(columnName, dataType, maxLength3, expression4, caption2)
			End Select
			Return result
		End Function

		' Token: 0x0600211E RID: 8478 RVA: 0x000D8B66 File Offset: 0x000D6D66
		Public Function Add(ColumnName As String, DataType As Type) As DataCol
			Return Me.Add(ColumnName, DataType, 32, "", "")
		End Function

		' Token: 0x0600211F RID: 8479 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		Public Function Add(ColumnName As String, DataType As Type, Expression As String) As DataCol
			Return Me.Add(ColumnName, DataType, 32, Expression, "")
		End Function

		' Token: 0x06002120 RID: 8480 RVA: 0x000D8B8E File Offset: 0x000D6D8E
		Public Function Add(ColumnName As String, DataType As Type, Expression As String, Caption As String) As DataCol
			Return Me.Add(ColumnName, DataType, 32, Expression, Caption)
		End Function

		' Token: 0x06002121 RID: 8481 RVA: 0x000D8B9D File Offset: 0x000D6D9D
		Public Function Add(ColumnName As String, DataType As Type, MaxLength As Integer) As DataCol
			Return Me.Add(ColumnName, DataType, MaxLength, "", "")
		End Function

		' Token: 0x06002122 RID: 8482 RVA: 0x000D8BB2 File Offset: 0x000D6DB2
		Public Function Add(ColumnName As String, DataType As Type, MaxLength As Integer, Expression As String) As DataCol
			Return Me.Add(ColumnName, DataType, MaxLength, Expression, "")
		End Function

		' Token: 0x06002123 RID: 8483 RVA: 0x000D8BC4 File Offset: 0x000D6DC4
		Public Function Add(ColumnName As String, DataType As Type, MaxLength As Integer, Expression As String, Caption As String) As DataCol
			Dim result As DataCol
			If Operators.CompareString(ColumnName, "", True) = 0 OrElse Me.Contains(ColumnName) Then
				MessageBox.Show("列" + ColumnName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			Else
				If DataType IsNot Nothing Then
					Try
						Dim dataColumn As DataColumn = New DataColumn(ColumnName, DataType)
						If DataType Is GetType(Boolean) Then
							dataColumn.DefaultValue = False
						End If
						Me.o.0OoOo..Columns.Add(dataColumn)
						If DataType Is GetType(Boolean) Then
							dataColumn.DefaultValue = Nothing
						End If
						If DataType Is GetType(String) Then
							dataColumn.MaxLength = MaxLength
						End If
						Try
							OO_00oOO.SystemReady = False
							If Operators.CompareString(Expression, "", True) > 0 Then
								dataColumn.Expression = Expression
							End If
						Catch ex As Exception
							MessageBox.Show("无法设置列""" + ColumnName + """的表达式，原因:" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							dataColumn.Expression = ""
						Finally
							OO_00oOO.SystemReady = True
						End Try
						Me.O_0__o.o_0o..Add(ColumnName, New DataCol(dataColumn))
						If Operators.CompareString(Caption, "", True) > 0 Then
							Me.O_0__o.o_0o.(ColumnName).Caption = Caption
						End If
						Me.O_0__o.o_0o.(ColumnName).IsTemporary = True
						If Not O_O0OO.o0OoO00OO.00O. Then
							Me.O_0__o.o_0o.()
						End If
						Try
							For Each table As Table In OO_00oOO.Tables
								If table.DataTable.BaseTable Is Me.o.0OoOo. AndAlso (DataType Is GetType(Double) OrElse DataType Is GetType(Decimal) OrElse DataType Is GetType(Single)) AndAlso table.foxGrid.Cols.Contains(ColumnName) Then
									table.foxGrid.Cols(ColumnName).Format = "#0.####"
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of Table)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						If Me.o.0OoOo..ChildRelations.Count > 0 OrElse Me.o.0OoOo..Rows.Count = 0 Then
							Try
								For Each table2 As Table In OO_00oOO.Tables
									If table2.DataTable.BaseTable Is Me.o.0OoOo. AndAlso Not table2.foxGrid.Cols.Contains(ColumnName) Then
										table2._frdTableLayout.OOooOOo_.0_0_o.()
										Dim objectValue As Object = RuntimeHelpers.GetObjectValue(table2.foxGrid.DataSource)
										table2.foxGrid.SuspendLayout()
										table2.foxGrid.BeginUpdate()
										table2.foxGrid.DataSource = Nothing
										table2.foxGrid.DataSource = RuntimeHelpers.GetObjectValue(objectValue)
										table2._frdTableLayout.Oo_.oo_oOo_oO.()
										table2.foxGrid.ResumeLayout()
										table2.foxGrid.EndUpdate()
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator(Of Table)
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
							End Try
						End If
						Try
							For Each table3 As Table In OO_00oOO.Tables
								If table3.foxGrid.FindForm() IsNot Nothing Then
									table3.O.__O0o0.(True, True)
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator(Of Table)
							If enumerator3 IsNot Nothing Then
								enumerator3.Dispose()
							End If
						End Try
						Return Me.O_0__o.o_0o.(ColumnName)
					Catch ex2 As Exception
						MessageBox.Show("无法增加列""" + ColumnName + """,原因:" + ex2.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End Try
				End If
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06002124 RID: 8484 RVA: 0x000D8FE4 File Offset: 0x000D71E4
		Private Sub <<EMPTY_NAME>>()
			If OO_00oOO.Tables IsNot Nothing AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.o.0OoOo..TableName) Then
				Try
					For Each table As Table In OO_00oOO.Tables
						table.O.__O0o0.(True, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06002125 RID: 8485 RVA: 0x000D9054 File Offset: 0x000D7254
		Public Sub Delete(ColumnName As String)
			Dim text As String = "只能删除用代码增加的列，其余列请通过菜单删除！"
			If Not Me.Contains(ColumnName) Then
				MessageBox.Show("没有找到要删除的列""" + ColumnName + """！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.o.0OoOo..DataSet IsNot Nothing AndAlso Not Me.O_0__o.o_0o.(ColumnName).IsTemporary Then
				MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { Me.o.0OoOo..TableName, ColumnName }) IsNot Nothing Then
				MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Me.O_0__o.o_0o.(ColumnName)
		End Sub

		' Token: 0x06002126 RID: 8486 RVA: 0x000D9114 File Offset: 0x000D7314
		Public Function Contains(ColumnName As String) As Boolean
			Dim result As Boolean
			If Me.O_0__o.o_0o..ContainsKey(ColumnName) Then
				result = True
			Else
				Try
					Dim enumerator As Dictionary(Of String, DataCol).KeyCollection.Enumerator = Me.O_0__o.o_0o..Keys.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current, ColumnName, True) = 0 Then
							Return True
						End If
					End While
				Finally
					Dim enumerator As Dictionary(Of String, DataCol).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x06002127 RID: 8487 RVA: 0x000D9188 File Offset: 0x000D7388
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of DataCol) Implements System.Collections.Generic.IEnumerable(Of Foxtable.DataCol).GetEnumerator
			Return CType(Me.O_0__o.o_0o..Values.GetEnumerator(), IEnumerator(Of DataCol))
		End Function

		' Token: 0x06002128 RID: 8488 RVA: 0x000D91A4 File Offset: 0x000D73A4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.O_0__o.o_0o..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04000DBB RID: 3515
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000DBC RID: 3516
		Friend <<EMPTY_NAME>> As Dictionary(Of String, DataCol)
	End Class
End Namespace
