Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000281 RID: 641
	<ComVisible(True)>
	Public Class DataTableBuilder
		' Token: 0x06001EEF RID: 7919 RVA: 0x000C8E5B File Offset: 0x000C705B
		Public Sub New(A_0 As String)
			Me.ooo.o__oO. = New List(Of DataColBuilder)()
			Me.ooo.o__oO. = True
			Me.ooo.o__oO. = A_0
		End Sub

		' Token: 0x06001EF0 RID: 7920 RVA: 0x000C8E7C File Offset: 0x000C707C
		Public Sub New(A_0 As String, A_1 As String)
			Me.ooo.o__oO. = New List(Of DataColBuilder)()
			Me.ooo.o__oO. = True
			Me.ooo.o__oO. = A_0
			Me.OOO.00o_o_. = A_1
		End Sub

		' Token: 0x170006F1 RID: 1777
		' (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000C8EA4 File Offset: 0x000C70A4
		' (set) Token: 0x06001EF2 RID: 7922 RVA: 0x000C8EAC File Offset: 0x000C70AC
		Public Property TableName As String
			Get
				Return Me.ooo.o__oO.
			End Get
			Set(value As String)
				Me.ooo.o__oO. = value
			End Set
		End Property

		' Token: 0x170006F2 RID: 1778
		' (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000C8EB5 File Offset: 0x000C70B5
		' (set) Token: 0x06001EF4 RID: 7924 RVA: 0x000C8EBD File Offset: 0x000C70BD
		Public Property TableVisible As Boolean
			Get
				Return Me.ooo.o__oO.
			End Get
			Set(value As Boolean)
				Me.ooo.o__oO. = value
			End Set
		End Property

		' Token: 0x170006F3 RID: 1779
		' (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000C8EC6 File Offset: 0x000C70C6
		' (set) Token: 0x06001EF6 RID: 7926 RVA: 0x000C8ECE File Offset: 0x000C70CE
		Public Property Caption As String
			Get
				Return Me.OOO.00o_o_.
			End Get
			Set(value As String)
				Me.OOO.00o_o_. = value
			End Set
		End Property

		' Token: 0x06001EF7 RID: 7927 RVA: 0x000C8ED8 File Offset: 0x000C70D8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddDef(ParamArray args As Object())
			Select Case args.Length
				Case 2
					Dim name As String = Conversions.ToString(args(0))
					Dim type As Type = ooO.o.O_0000_O.(Conversions.ToString(args(1)))
					Me.AddDef(name, type)
					Return
				Case 3
					Dim name2 As String = Conversions.ToString(args(0))
					Dim type2 As Type = ooO.o.O_0000_O.(Conversions.ToString(args(1)))
					If TypeOf args(2)Is String Then
						Dim expression As String = Conversions.ToString(args(2))
						Me.AddDef(name2, type2, expression)
						Return
					End If
					If TypeOf args(2)Is Integer Then
						Dim maxlength As Integer = Conversions.ToInteger(args(2))
						Me.AddDef(name2, type2, maxlength)
						Return
					End If
				Case 4
					Dim name3 As String = Conversions.ToString(args(0))
					Dim type3 As Type = ooO.o.O_0000_O.(Conversions.ToString(args(1)))
					If TypeOf args(2)Is String AndAlso TypeOf args(3)Is String Then
						Dim expression2 As String = Conversions.ToString(args(2))
						Dim caption As String = Conversions.ToString(args(3))
						Me.AddDef(name3, type3, expression2, caption)
						Return
					End If
					If TypeOf args(2)Is Integer AndAlso TypeOf args(3)Is String Then
						Dim maxlength2 As Integer = Conversions.ToInteger(args(2))
						Dim expression3 As String = Conversions.ToString(args(3))
						Me.AddDef(name3, type3, maxlength2, expression3)
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001EF8 RID: 7928 RVA: 0x000C8FFF File Offset: 0x000C71FF
		Public Sub AddDef(Name As String, Type As Type)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type))
		End Sub

		' Token: 0x06001EF9 RID: 7929 RVA: 0x000C9013 File Offset: 0x000C7213
		Public Sub AddDef(Name As String, Type As Type, Expression As String)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type, Expression))
		End Sub

		' Token: 0x06001EFA RID: 7930 RVA: 0x000C9028 File Offset: 0x000C7228
		Public Sub AddDef(Name As String, Type As Type, Expression As String, Caption As String)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type, Expression, Caption))
		End Sub

		' Token: 0x06001EFB RID: 7931 RVA: 0x000C903F File Offset: 0x000C723F
		Public Sub AddDef(Name As String, Type As Type, Maxlength As Integer)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type, Maxlength))
		End Sub

		' Token: 0x06001EFC RID: 7932 RVA: 0x000C9054 File Offset: 0x000C7254
		Public Sub AddDef(Name As String, Type As Type, Maxlength As Integer, Expression As String)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type, Maxlength, Expression))
		End Sub

		' Token: 0x06001EFD RID: 7933 RVA: 0x000C906B File Offset: 0x000C726B
		Public Sub AddDef(Name As String, Type As Type, Maxlength As Integer, Expression As String, Caption As String)
			Me.ooo.o__oO..Add(New DataColBuilder(Name, Type, Maxlength, Expression, Caption))
		End Sub

		' Token: 0x06001EFE RID: 7934 RVA: 0x000C9084 File Offset: 0x000C7284
		Friend Function Contains(Name As String) As Boolean
			Try
				Dim enumerator As List(Of DataColBuilder).Enumerator = Me.ooo.o__oO..GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current.Name, Name, True) = 0 Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As List(Of DataColBuilder).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function

		' Token: 0x06001EFF RID: 7935 RVA: 0x000C90E4 File Offset: 0x000C72E4
		Public Function Build(Optional OnlyDataTable As Boolean = False) As DataTable
			If OO_00oOO.DataTables.Contains(Me.TableName) AndAlso Not OnlyDataTable Then
				If OO_00oOO.DataTables(Me.TableName).AddByCode Then
					OO_00oOO.DataTables.Delete(Me.TableName)
				End If
				If OO_00oOO.DataTables.Contains(Me.TableName) Then
					MessageBox.Show("表" + Me.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return Nothing
				End If
			End If
			Dim dataTable As DataTable = Me.BuildDataSource()
			dataTable.TableName = Me.TableName
			Dim result As DataTable
			If OnlyDataTable Then
				Dim dataTable2 As DataTable = New DataTable(dataTable, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
				dataTable2.o.0O000_.()
				result = dataTable2
			Else
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
				OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, Me.TableName, O_O0OO.OoO.0OO__0ooo.()))
				OO_00oOO.DataTables(Me.TableName).o.0O000_.()
				OO_00oOO.DataTables(Me.TableName).Caption = Me.Caption
				OO_00oOO.DataTables(Me.TableName).AddByCode = True
				Try
					For Each dataCol As DataCol In OO_00oOO.DataTables(Me.TableName).DataCols
						dataCol.Caption = dataCol.BaseColumn.Caption
						dataCol.BaseColumn.Caption = ""
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataCol)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				New O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables(Me.TableName).BaseTable)
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
				Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, Me.TableVisible, False)
				Try
					For Each col As Col In OO_00oOO.Tables(Me.TableName).Cols
						col.o0.O.()
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of Col)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				result = OO_00oOO.DataTables(Me.TableName)
			End If
			Return result
		End Function

		' Token: 0x06001F00 RID: 7936 RVA: 0x000C9324 File Offset: 0x000C7524
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001F01 RID: 7937 RVA: 0x000C9340 File Offset: 0x000C7540
		Public Function BuildDataSource() As fxDataSource
			Dim fxDataSource As fxDataSource = New fxDataSource()
			Dim list As List(Of String) = New List(Of String)()
			Dim list2 As List(Of Type) = New List(Of Type)()
			Dim list3 As List(Of Integer) = New List(Of Integer)()
			Dim list4 As List(Of String) = New List(Of String)()
			Dim list5 As List(Of String) = New List(Of String)()
			Try
				For Each dataColBuilder As DataColBuilder In Me.ooo.o__oO.
					list.Add(dataColBuilder.Name)
					list2.Add(dataColBuilder.Type)
					list3.Add(dataColBuilder.Maxlength)
					list4.Add(dataColBuilder.Caption)
					list5.Add(dataColBuilder.Expression)
				Next
			Finally
				Dim enumerator As List(Of DataColBuilder).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim num As Integer = list.Count - 1
			For i As Integer = 0 To num
				fxDataSource.Columns.Add(list(i), list2(i))
				If list2(i) Is GetType(String) Then
					fxDataSource.Columns(list(i)).MaxLength = list3(i)
				End If
			Next
			Dim num2 As Integer = list.Count - 1
			For j As Integer = 0 To num2
				If Operators.CompareString(list5(j), "", True) > 0 Then
					Try
						fxDataSource.Columns(list(j)).Expression = list5(j)
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						Exit Try
					End Try
				End If
			Next
			Try
				For Each obj As Object In fxDataSource.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					dataColumn.Caption = list4(list.IndexOf(dataColumn.ColumnName))
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Return fxDataSource
		End Function

		' Token: 0x04000CEB RID: 3307
		Private <<EMPTY_NAME>> As List(Of DataColBuilder)

		' Token: 0x04000CEC RID: 3308
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CED RID: 3309
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CEE RID: 3310
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
