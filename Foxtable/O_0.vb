Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002FD RID: 765
	<DefaultMember("Item")>
	Friend Class O_0
		Inherits BindingSource

		' Token: 0x060027F9 RID: 10233 RVA: 0x0010BCD4 File Offset: 0x00109ED4
		Friend Sub New(A_0 As Dictionary(Of String, O_0), A_1 As DataTable)
			AddHandler MyBase.CurrentChanged, AddressOf Me.o_._0O0o_OoO.
			AddHandler MyBase.PositionChanged, AddressOf Me.Oo._Oo0OO.
			If A_1.DataSet Is Nothing Then
				MyBase.DataSource = A_1
			Else
				MyBase.DataSource = A_1.DataSet
				MyBase.DataMember = A_1.TableName
			End If
			Me.O0_Oo0.0o_o0. = A_1.TableName
			Me.Oo0_.O. = True
			If A_0 IsNot Nothing Then
				A_0.Add(Me.Oo._Oo0OO.(), Me)
			End If
			If A_1.PrimaryKey.Length = 1 Then
				Dim autoIncrement As Boolean = A_1.PrimaryKey(0).AutoIncrement
			End If
			Me.O00o0.0_0O_.(True)
		End Sub

		' Token: 0x060027FA RID: 10234 RVA: 0x0010BD78 File Offset: 0x00109F78
		Friend Sub New(A_0 As DataTable, A_1 As String)
			AddHandler MyBase.CurrentChanged, AddressOf Me.o_._0O0o_OoO.
			AddHandler MyBase.PositionChanged, AddressOf Me.Oo._Oo0OO.
			SyncLock A_0
				Dim dataSource As DataView = New DataView(A_0)
				MyBase.DataSource = dataSource
				Me.O0_Oo0.0o_o0. = A_1
				O_O0OO.o__.O.().Add(Me.Oo._Oo0OO.(), Me)
				If A_0.PrimaryKey.Length = 1 Then
					Dim autoIncrement As Boolean = A_0.PrimaryKey(0).AutoIncrement
				End If
				Me.O00o0.0_0O_.(True)
			End SyncLock
		End Sub

		' Token: 0x060027FB RID: 10235 RVA: 0x0010BE20 File Offset: 0x0010A020
		Friend Sub New(A_0 As Dictionary(Of String, O_0), A_1 As O_0, A_2 As DataRelation)
			AddHandler MyBase.CurrentChanged, AddressOf Me.o_._0O0o_OoO.
			AddHandler MyBase.PositionChanged, AddressOf Me.Oo._Oo0OO.
			Me.O0_Oo0.0o_o0. = A_1
			Me.O0_Oo0.0o_o0. = A_2
			If A_1.o_o.O0ooOo.() Is A_2.ParentTable Then
				MyBase.DataSource = A_1
				MyBase.DataMember = A_2.RelationName
				Me.O0_Oo0.0o_o0. = True
				Me.O0_Oo0.0o_o0. = A_1.Oo._Oo0OO.() + "." + A_2.ChildTable.TableName
			Else
				MyBase.DataSource = A_2.DataSet
				MyBase.DataMember = A_2.ParentTable.TableName
				Me.oo0_Oo.00__. = True
				Me.O0_Oo0.0o_o0. = A_1.Oo._Oo0OO.() + "." + A_2.ParentTable.TableName
			End If
			If A_0 IsNot Nothing Then
				If A_0.ContainsKey(Me.Oo._Oo0OO.()) Then
					Return
				End If
				A_0.Add(Me.Oo._Oo0OO.(), Me)
			End If
			Dim table As DataTable = Me.o_o.O0ooOo.().Table
			If table.PrimaryKey.Length = 1 Then
				Dim autoIncrement As Boolean = table.PrimaryKey(0).AutoIncrement
			End If
			Me.O00o0.0_0O_.(True)
		End Sub

		' Token: 0x060027FC RID: 10236 RVA: 0x0010BF41 File Offset: 0x0010A141
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O_o.o_0.
		End Function

		' Token: 0x060027FD RID: 10237 RVA: 0x0010BF49 File Offset: 0x0010A149
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O_o.o_0. = A_0
		End Sub

		' Token: 0x060027FE RID: 10238 RVA: 0x0010BF54 File Offset: 0x0010A154
		Friend Sub <<EMPTY_NAME>>()
			If Me.O0OOO_0.o.() Then
				MyBase.Sort = ""
				Return
			End If
			If Me.o_o.O0ooOo.().Columns.Contains("_SortKey") Then
				MyBase.Sort = "_SortKey"
				Return
			End If
			MyBase.Sort = ""
		End Sub

		' Token: 0x060027FF RID: 10239 RVA: 0x0010BFA3 File Offset: 0x0010A1A3
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Operators.CompareString(MyBase.DataMember, "", True) = 0
		End Function

		' Token: 0x06002800 RID: 10240 RVA: 0x0010BFB9 File Offset: 0x0010A1B9
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O0_Oo0.0o_o0.
		End Function

		' Token: 0x06002801 RID: 10241 RVA: 0x0010BFC1 File Offset: 0x0010A1C1
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.oo0_Oo.00__.
		End Function

		' Token: 0x06002802 RID: 10242 RVA: 0x0010BFC9 File Offset: 0x0010A1C9
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.Oo0_.O.
		End Function

		' Token: 0x06002803 RID: 10243 RVA: 0x0010BFD4 File Offset: 0x0010A1D4
		Friend Function <<EMPTY_NAME>>() As DataView
			Dim result As DataView
			If Me.O0O_0_0__.0O.() IsNot Nothing AndAlso Me.O0O_0_0__.0O.().Count = 0 Then
				result = New DataView(Me.o_o.O0ooOo.(), "", "", DataViewRowState.None)
			ElseIf TypeOf MyBase.List Is DataView Then
				result = CType(MyBase.List, DataView)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06002804 RID: 10244 RVA: 0x0010C030 File Offset: 0x0010A230
		Friend Function <<EMPTY_NAME>>() As DataTable
			Dim result As DataTable
			If Me.O0O_0_0__.0O.() IsNot Nothing Then
				If Me.O0OOO_0.o.() Then
					result = Me.O0O_0_0__.0O.().ParentTable
				Else
					result = Me.O0O_0_0__.0O.().ChildTable
				End If
			Else
				result = Me.o_o.O0ooOo.().Table
			End If
			Return result
		End Function

		' Token: 0x06002805 RID: 10245 RVA: 0x0010C076 File Offset: 0x0010A276
		Friend Function <<EMPTY_NAME>>() As O_0
			Return Me.O0_Oo0.0o_o0.
		End Function

		' Token: 0x06002806 RID: 10246 RVA: 0x0010C07E File Offset: 0x0010A27E
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.O0_Oo0.0o_o0.
		End Function

		' Token: 0x06002807 RID: 10247 RVA: 0x0010C086 File Offset: 0x0010A286
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0_Oo0.0o_o0. = A_0
		End Sub

		' Token: 0x06002808 RID: 10248 RVA: 0x0010C08F File Offset: 0x0010A28F
		Friend Function <<EMPTY_NAME>>() As DataRelation
			Return Me.O0_Oo0.0o_o0.
		End Function

		' Token: 0x06002809 RID: 10249 RVA: 0x0010C098 File Offset: 0x0010A298
		Friend Function <<EMPTY_NAME>>() As DataRowView
			Dim result As DataRowView
			If MyBase.Position < 0 OrElse MyBase.Current Is Nothing Then
				result = Nothing
			Else
				result = CType(MyBase.Current, DataRowView)
			End If
			Return result
		End Function

		' Token: 0x0600280A RID: 10250 RVA: 0x0010C0C8 File Offset: 0x0010A2C8
		Friend Function <<EMPTY_NAME>>(A_0 As DataRow) As Integer
			Dim dataView As DataView = Me.o_o.O0ooOo.()
			If A_0.Table Is Me.o_o.O0ooOo.() Then
				For i As Integer = MyBase.Position To 0 Step -1
					If dataView(i).Row Is A_0 Then
						Return i
					End If
				Next
				Dim num As Integer = MyBase.Position + 1
				Dim num2 As Integer = dataView.Count - 1
				For j As Integer = num To num2
					If dataView(j).Row Is A_0 Then
						Return j
					End If
				Next
			Else
				Dim num3 As Integer = dataView.Count - 1
				For k As Integer = 0 To num3
					Dim flag As Boolean = True
					For Each dataColumn As DataColumn In Me.o_o.O0ooOo.().PrimaryKey
						If Operators.CompareString(dataView(k)(dataColumn.ColumnName).ToString(), A_0(dataColumn.ColumnName).ToString(), True) <> 0 Then
							flag = False
							Exit For
						End If
					Next
					If flag Then
						Return k
					End If
				Next
			End If
			Return -1
		End Function

		' Token: 0x0600280B RID: 10251 RVA: 0x0010C1D7 File Offset: 0x0010A3D7
		Friend Function <<EMPTY_NAME>>() As String
			Return MyBase.Filter
		End Function

		' Token: 0x0600280C RID: 10252 RVA: 0x0010C1DF File Offset: 0x0010A3DF
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			MyBase.Filter = A_0
		End Sub

		' Token: 0x0600280D RID: 10253 RVA: 0x0010C1E8 File Offset: 0x0010A3E8
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.o_O_.00o.
		End Function

		' Token: 0x0600280E RID: 10254 RVA: 0x0010C1F0 File Offset: 0x0010A3F0
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o_O_.00o. = A_0
		End Sub

		' Token: 0x0600280F RID: 10255 RVA: 0x0010C1FC File Offset: 0x0010A3FC
		Public Overrides Function get_Filter() As String
			Dim result As String
			If Me.o__0.O.() Then
				result = Me.o0.O0.()
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06002810 RID: 10256 RVA: 0x0010C224 File Offset: 0x0010A424
		Public Overrides Sub set_Filter(value As String)
			If Me.o_o.O0ooOo.() IsNot Nothing AndAlso Me.o_o.O0ooOo.().IsEdit Then
				Me.o_o.O0ooOo.().EndEdit()
			End If
			Dim filterEventArgs As FilterEventArgs = New FilterEventArgs(OO_00oOO.Tables(Me.Oo._Oo0OO.()), value)
			Dim a_ As String = "BeforeFilter"
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { filterEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
			If Not filterEventArgs.Cancel AndAlso OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.BeforeFilter Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { filterEventArgs }, False, "全局表事件", False)
			End If
			If Not filterEventArgs.Cancel Then
				OO_00oOO.Tables(Me.Oo._Oo0OO.()).o.oO000Ooo_.()
				value = filterEventArgs.Filter
				If Operators.CompareString(filterEventArgs.Filter, "", True) > 0 Then
					Me.Oo._Oo0OO.(filterEventArgs.Filter)
				End If
				Me.o_O_.00o.(Operators.CompareString(value, "", True) > 0)
				Dim dataRow As DataRow = Nothing
				Dim position As Integer = MyBase.Position
				If Me.o_o.O0ooOo.() IsNot Nothing Then
					dataRow = Me.o_o.O0ooOo.().Row
				End If
				If Me.O0O.o__0.() OrElse Me.O.o_OOOo_OoO.() Then
					Me.O00o0.0_0O_.(False)
					Try
						MyBase.Filter = value
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).foxGrid.O.O00O_oO_OO00.(True)
						GoTo IL_4D5
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "")
						GoTo IL_4D5
					Finally
						Me.O00o0.0_0O_.(True)
						If(Me.o_o.O0ooOo.() IsNot Nothing AndAlso Me.o_o.O0ooOo.().Row IsNot dataRow) OrElse (Me.o_o.O0ooOo.() Is Nothing AndAlso dataRow IsNot Nothing) Then
							Me.o_._0O0o_OoO.()
						End If
						If MyBase.Position <> position Then
							Me.Oo._Oo0OO.()
						End If
					End Try
				End If
				If Not Me.O0OOO_0.o.() Then
					Try
						Me.O00o0.0_0O_.(False)
						Try
							For Each table As Table In OO_00oOO.Tables
								If table.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
									table.View.O00o0.0_0O_.(False)
									table.StopRedraw()
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of Table)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).StopRedraw()
						MyBase.Filter = "False"
						Dim a_3 As Dictionary(Of DataColumn, String) = Oo00.ooO.ooo.(Me.o_o.O0ooOo.())
						Dim array As DataRow() = Me.o_o.O0ooOo.().[Select]("[System_Filter_Temporary] Is Not Null")
						For i As Integer = 0 To array.Length - 1
							array(i)("System_Filter_Temporary") = DBNull.Value
						Next
						If Operators.CompareString(value, "", True) > 0 Then
							Dim array2 As DataRow() = Me.o_o.O0ooOo.().[Select](value)
							For j As Integer = 0 To array2.Length - 1
								array2(j)("System_Filter_Temporary") = 1
							Next
							value = "[System_Filter_Temporary] = 1"
						End If
						Oo00.o0_o._O_.(a_3)
						MyBase.Filter = value
						MyBase.Position = Math.Max(0, Math.Min(position, Me.Count - 1))
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).foxGrid.O.O00O_oO_OO00.(True)
						GoTo IL_4D5
					Catch a_4 As Exception
						ooO.oOo0Oo.o.(a_4, "")
						GoTo IL_4D5
					Finally
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).ResumeRedraw()
						Me.O00o0.0_0O_.(True)
						Try
							For Each table2 As Table In OO_00oOO.Tables
								If table2.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
									table2.ResumeRedraw()
									table2.View.O00o0.0_0O_.(True)
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Table)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						If(Me.o_o.O0ooOo.() IsNot Nothing AndAlso Me.o_o.O0ooOo.().Row IsNot dataRow) OrElse (Me.o_o.O0ooOo.() Is Nothing AndAlso dataRow IsNot Nothing) Then
							Me.o_._0O0o_OoO.()
							Try
								For Each table3 As Table In OO_00oOO.Tables
									If table3.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
										table3.View.o_._0O0o_OoO.()
										table3.View.Oo._Oo0OO.()
									End If
								Next
							Finally
								Dim enumerator3 As IEnumerator(Of Table)
								If enumerator3 IsNot Nothing Then
									enumerator3.Dispose()
								End If
							End Try
						End If
						If MyBase.Position <> position Then
							Me.Oo._Oo0OO.()
						End If
					End Try
				End If
				If Me.O0O_0_0__.0O.().o_o.O0ooOo.() Is Nothing Then
					MyBase.Filter = "False"
				Else
					Dim row As DataRow = Me.O0O_0_0__.0O.().o_o.O0ooOo.().Row
					Dim text As String = Me.Oo._Oo0OO.(row, Me.O0O_0_0__.0O.())
					If Operators.CompareString(value, "", True) > 0 Then
						text = text + " And " + value
					End If
					MyBase.Filter = text
				End If
				IL_4D5:
				a_ = "AfterFilter"
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { filterEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				If OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.AfterFilter Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { filterEventArgs }, False, "全局表事件", False)
				End If
			End If
		End Sub

		' Token: 0x06002811 RID: 10257 RVA: 0x0010C830 File Offset: 0x0010AA30
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.oO0o0_.OoO_.
		End Function

		' Token: 0x06002812 RID: 10258 RVA: 0x0010C838 File Offset: 0x0010AA38
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.oO0o0_.OoO_. = A_0
		End Sub

		' Token: 0x06002813 RID: 10259 RVA: 0x0010C844 File Offset: 0x0010AA44
		Private Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataRelation) As String
			Dim text As String = ""
			Dim num As Integer = A_1.ChildColumns.Length - 1
			For i As Integer = 0 To num
				If Operators.CompareString(text, "", True) > 0 Then
					text += " And "
				End If
				If A_0.IsNull(A_1.ChildColumns(i)) Then
					text = text + "[" + A_1.ParentColumns(i).ColumnName + "] is null"
				Else
					Dim text2 As String
					If A_1.ChildColumns(i).DataType Is GetType(String) Then
						text2 = "'"
					ElseIf A_1.ChildColumns(i).DataType Is GetType(DateTime) Then
						text2 = "#"
					Else
						text2 = ""
					End If
					text = String.Concat(New String() { text, "[", A_1.ParentColumns(i).ColumnName, "] = ", text2, A_0(A_1.ChildColumns(i)).ToString(), text2 })
				End If
			Next
			Return text
		End Function

		' Token: 0x06002814 RID: 10260 RVA: 0x0010C95F File Offset: 0x0010AB5F
		Public Function <<EMPTY_NAME>>() As String
			Return Me.Oo0_.O.
		End Function

		' Token: 0x06002815 RID: 10261 RVA: 0x0010C967 File Offset: 0x0010AB67
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.Oo0_.O. = A_0
		End Sub

		' Token: 0x06002816 RID: 10262 RVA: 0x0010C970 File Offset: 0x0010AB70
		Public Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Me.OO.___OO0O.() Then
				result = Me.o_._0O0o_OoO.()
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06002817 RID: 10263 RVA: 0x0010C998 File Offset: 0x0010AB98
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			If Me.o_o.O0ooOo.() IsNot Nothing AndAlso Me.o_o.O0ooOo.().IsEdit Then
				Me.o_o.O0ooOo.().EndEdit()
			End If
			Dim sortEventArgs As SortEventArgs = New SortEventArgs(OO_00oOO.Tables(Me.Oo._Oo0OO.()), A_0)
			Dim a_ As String = "BeforeSort"
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { sortEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
			If Not sortEventArgs.Cancel AndAlso OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.BeforeSort Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { sortEventArgs }, False, "全局表事件", False)
			End If
			If Not sortEventArgs.Cancel Then
				OO_00oOO.Tables(Me.Oo._Oo0OO.()).ClearCheckedRows()
				OO_00oOO.Tables(Me.Oo._Oo0OO.()).o.oO000Ooo_.()
				If Operators.CompareString(sortEventArgs.Sort, "", True) > 0 Then
					Me.o_O_.00o.(sortEventArgs.Sort)
				End If
				A_0 = sortEventArgs.Sort
				Me.o_o00.0_o0.(Operators.CompareString(A_0, "", True) > 0)
				If Operators.CompareString(A_0, "", True) = 0 Then
					Me.O00o0.0_0O_.()
					OO_00oOO.Tables(Me.Oo._Oo0OO.()).foxGrid.O.O00O_oO_OO00.(True)
				ElseIf Me.O0O.o__0.() OrElse Me.O.o_OOOo_OoO.() OrElse Me.O0OOO_0.o.() OrElse Operators.CompareString(A_0.Trim(New Char() { "["c, "]"c }), "System_Sort_Temporary", True) = 0 Then
					MyBase.Sort = A_0
					OO_00oOO.Tables(Me.Oo._Oo0OO.()).foxGrid.O.O00O_oO_OO00.(True)
				Else
					Dim filter As String = MyBase.Filter
					Dim position As Integer = MyBase.Position
					Dim dataRow As DataRow = Nothing
					If Me.o_o.O0ooOo.() IsNot Nothing Then
						dataRow = Me.o_o.O0ooOo.().Row
					End If
					Dim array As DataRow() = Me.o_o.O0ooOo.().[Select](Me.oo_0._o.(), A_0)
					Try
						Me.O00o0.0_0O_.(False)
						Try
							For Each table As Table In OO_00oOO.Tables
								If table.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
									table.View.O00o0.0_0O_.(False)
									table.StopRedraw()
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of Table)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).StopRedraw()
						MyBase.Filter = "False"
						Dim a_2 As Dictionary(Of DataColumn, String) = Oo00.ooO.ooo.(Me.o_o.O0ooOo.())
						Dim num As Integer = array.Length - 1
						For i As Integer = 0 To num
							array(i)("System_Sort_Temporary") = i
						Next
						Oo00.o0_o._O_.(a_2)
						MyBase.Filter = filter
						MyBase.Sort = "[System_Sort_Temporary]," + Me.o_._0O0o_OoO.()
						MyBase.Position = Math.Max(0, Math.Min(position, Me.Count - 1))
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).foxGrid.O.O00O_oO_OO00.(True)
					Catch a_3 As Exception
						ooO.oOo0Oo.o.(a_3, "")
					Finally
						OO_00oOO.Tables(Me.Oo._Oo0OO.()).ResumeRedraw()
						Me.O00o0.0_0O_.(True)
						Try
							For Each table2 As Table In OO_00oOO.Tables
								If table2.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
									table2.ResumeRedraw()
									table2.View.O00o0.0_0O_.(True)
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Table)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						If(Me.o_o.O0ooOo.() IsNot Nothing AndAlso Me.o_o.O0ooOo.().Row IsNot dataRow) OrElse (Me.o_o.O0ooOo.() Is Nothing AndAlso dataRow IsNot Nothing) Then
							Me.o_._0O0o_OoO.()
							Try
								For Each table3 As Table In OO_00oOO.Tables
									If table3.Name.StartsWith(Me.Oo._Oo0OO.() + ".") Then
										table3.View.o_._0O0o_OoO.()
										table3.View.Oo._Oo0OO.()
									End If
								Next
							Finally
								Dim enumerator3 As IEnumerator(Of Table)
								If enumerator3 IsNot Nothing Then
									enumerator3.Dispose()
								End If
							End Try
						End If
						If MyBase.Position <> position Then
							Me.Oo._Oo0OO.()
						End If
					End Try
				End If
				a_ = "AfterSort"
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { sortEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				If OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.AfterSort Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { sortEventArgs }, False, "全局表事件", False)
				End If
			End If
		End Sub

		' Token: 0x06002818 RID: 10264 RVA: 0x0010CEF4 File Offset: 0x0010B0F4
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O00o000.0000.
		End Function

		' Token: 0x06002819 RID: 10265 RVA: 0x0010CEFC File Offset: 0x0010B0FC
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O00o000.0000. = A_0
		End Sub

		' Token: 0x0600281A RID: 10266 RVA: 0x0010CF08 File Offset: 0x0010B108
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As DataRowView
			Dim result As DataRowView
			If A_0 < 0 OrElse A_0 > MyBase.List.Count - 1 Then
				result = Nothing
			Else
				result = CType(MyBase.List(A_0), DataRowView)
			End If
			Return result
		End Function

		' Token: 0x0600281B RID: 10267 RVA: 0x0010CF40 File Offset: 0x0010B140
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If(Me.O0O_0_0__.0O.() And OO_00oOO.SystemReady) AndAlso OO_00oOO.Tables.get_Contains(Me.Oo._Oo0OO.()) AndAlso MyBase.List IsNot Nothing AndAlso O_O0OO.OOOo.oo_OOOO_0.() IsNot Nothing AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.o_o.O0ooOo.().TableName) AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.o_o.O0ooOo.().TableName) Is Me.o_o.O0ooOo.() Then
				Me.o_._0O0o_OoO.()
			End If
		End Sub

		' Token: 0x0600281C RID: 10268 RVA: 0x0010CFC0 File Offset: 0x0010B1C0
		Friend Sub <<EMPTY_NAME>>()
			If Not OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).IsDeletingRows Then
				Main.OO_O.o..O.ooO0. = True
				Dim tableEventArgs As TableEventArgs = New TableEventArgs(OO_00oOO.Tables(Me.Oo._Oo0OO.()))
				Dim a_ As String = "CurrentChanged"
				If OO_00oOO.Tables(Me.Oo._Oo0OO.()).o0__OOo0._oO. Is Nothing Then
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { tableEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				Else
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Tables(Me.Oo._Oo0OO.()).o0__OOo0._oO., a_, New Object() { tableEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				End If
				If OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.CurrentChanged Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { tableEventArgs }, False, "全局表事件", False)
				End If
				a_ = "CurrentChanged_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { tableEventArgs }, False, "菜单", False)
				Try
					For Each o_ As O_0 In O_O0OO.o__.O.().Values
						If o_.O0O_0_0__.0O.() Is Me AndAlso o_.O0OOO_0.o.() Then
							o_.set_Filter(o_.get_Filter())
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, O_0).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x0600281D RID: 10269 RVA: 0x0010D174 File Offset: 0x0010B374
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If(Me.O0O_0_0__.0O.() And OO_00oOO.SystemReady) AndAlso OO_00oOO.Tables.get_Contains(Me.Oo._Oo0OO.()) AndAlso MyBase.List IsNot Nothing AndAlso O_O0OO.OOOo.oo_OOOO_0.() IsNot Nothing AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(Me.o_o.O0ooOo.().TableName) AndAlso O_O0OO.OOOo.oo_OOOO_0.().Tables(Me.o_o.O0ooOo.().TableName) Is Me.o_o.O0ooOo.() Then
				Me.Oo._Oo0OO.()
			End If
		End Sub

		' Token: 0x0600281E RID: 10270 RVA: 0x0010D1F4 File Offset: 0x0010B3F4
		Friend Sub <<EMPTY_NAME>>()
			If Not OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).IsDeletingRows Then
				Dim tableEventArgs As TableEventArgs = New TableEventArgs(OO_00oOO.Tables(Me.Oo._Oo0OO.()))
				Dim a_ As String = "PositionChanged"
				If OO_00oOO.Tables(Me.Oo._Oo0OO.()).o0__OOo0._oO. Is Nothing Then
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).o_0_00_.oo0O0., a_, New Object() { tableEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				Else
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Tables(Me.Oo._Oo0OO.()).o0__OOo0._oO., a_, New Object() { tableEventArgs }, False, Me.o_o.O0ooOo.().TableName, False)
				End If
				If OO_00oOO.DataTables(Me.o_o.O0ooOo.().TableName).GlobalHandler.PositionChanged Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { tableEventArgs }, False, "全局表事件", False)
				End If
				a_ = "PositionChanged_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { tableEventArgs }, False, "菜单", False)
			End If
		End Sub

		' Token: 0x0400109B RID: 4251
		Private <<EMPTY_NAME>> As O_0

		' Token: 0x0400109C RID: 4252
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400109D RID: 4253
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400109E RID: 4254
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400109F RID: 4255
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010A0 RID: 4256
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x040010A1 RID: 4257
		Private <<EMPTY_NAME>> As DataRelation

		' Token: 0x040010A2 RID: 4258
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010A3 RID: 4259
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010A4 RID: 4260
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010A5 RID: 4261
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010A6 RID: 4262
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
