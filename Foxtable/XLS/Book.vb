Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.C1Excel
Imports Foxtable.My
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.XLS
	' Token: 0x020004D6 RID: 1238
	<oO0oooo("1150")>
	Public Class Book
		' Token: 0x06004FBA RID: 20410 RVA: 0x00210AE8 File Offset: 0x0020ECE8
		Public Sub New()
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, Object)()
			Me.O_0_o.Oo_oo0_O. = False
			Me.oO.o_0o__. = New Dictionary(Of String, List(Of DataRow))()
			Me.OOO0_O0.O. = New Book.O0oOOoo_ooo_O()
			Me.oOo_o0.o_0. = New Book.O0oOOoo_ooo_O()
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, Integer)()
			Me.OoO.o0. = New Dictionary(Of String, Integer)()
			Me.O.o00O0___O. = New Dictionary(Of String, Integer)()
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, String)()
			Me.O_ooo.o0. = New Dictionary(Of String, String)()
			Me.Ooo.00_O0_0_. = New Dictionary(Of String, Integer)()
			Me.o._0_Oo0o. = New Dictionary(Of String, Integer)()
			Me.OOO0_O0.O. = New List(Of Integer)()
			Me.O_0_o.Oo_oo0_O. = New RichTextBox()
			Me.oO.o_0o__. = New tempDataTableCollection()
			Me.O_0_o.Oo_oo0_O. = New List(Of O_0OO)()
			Me.O_0_o.Oo_oo0_O. = New List(Of o0__oo0OOo)()
			Me.O_ooo.o0. = True
			Me.oO.o_0o__. = New C1XLBook()
			Me.oO.o_0o__..DefaultFont = New Font("宋体", 12F, FontStyle.Regular)
			If Foxtable.My.b.O0o0oO00_.O.().Count > 61 Then
				O_O0OO.O_O.OOO_o.(True)
			End If
		End Sub

		' Token: 0x06004FBB RID: 20411 RVA: 0x00210BF4 File Offset: 0x0020EDF4
		Public Sub New(A_0 As String)
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, Object)()
			Me.O_0_o.Oo_oo0_O. = False
			Me.oO.o_0o__. = New Dictionary(Of String, List(Of DataRow))()
			Me.OOO0_O0.O. = New Book.O0oOOoo_ooo_O()
			Me.oOo_o0.o_0. = New Book.O0oOOoo_ooo_O()
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, Integer)()
			Me.OoO.o0. = New Dictionary(Of String, Integer)()
			Me.O.o00O0___O. = New Dictionary(Of String, Integer)()
			Me.O_0_o.Oo_oo0_O. = New Dictionary(Of String, String)()
			Me.O_ooo.o0. = New Dictionary(Of String, String)()
			Me.Ooo.00_O0_0_. = New Dictionary(Of String, Integer)()
			Me.o._0_Oo0o. = New Dictionary(Of String, Integer)()
			Me.OOO0_O0.O. = New List(Of Integer)()
			Me.O_0_o.Oo_oo0_O. = New RichTextBox()
			Me.oO.o_0o__. = New tempDataTableCollection()
			Me.O_0_o.Oo_oo0_O. = New List(Of O_0OO)()
			Me.O_0_o.Oo_oo0_O. = New List(Of o0__oo0OOo)()
			Me.O_ooo.o0. = True
			Me.oO.o_0o__. = New C1XLBook()
			Me.o_0Oo.0___OO0_. = A_0
			If A_0.ToLower().EndsWith(".xlsx") Then
				Me.oO.o_0o__..CompatibilityMode = 1
			Else
				Me.oO.o_0o__..CompatibilityMode = 0
			End If
			Me.oO.o_0o__..Load(ooO.OoO0o_o___.O.(A_0))
		End Sub

		' Token: 0x170011F1 RID: 4593
		' (get) Token: 0x06004FBC RID: 20412 RVA: 0x00210D14 File Offset: 0x0020EF14
		Public Shared ReadOnly Property ExtendAsm As Assembly
			Get
				If Not Book.a Then
					Book.a = True
					Book.a = Book.ooo._O.()
				End If
				Return Book.a
			End Get
		End Property

		' Token: 0x170011F2 RID: 4594
		' (get) Token: 0x06004FBD RID: 20413 RVA: 0x00210D32 File Offset: 0x0020EF32
		<oO0oooo("1953")>
		Public ReadOnly Property TempLate As String
			Get
				Return Path.GetFileNameWithoutExtension(Me.o_0Oo.0___OO0_.)
			End Get
		End Property

		' Token: 0x170011F3 RID: 4595
		' (get) Token: 0x06004FBE RID: 20414 RVA: 0x00210D3F File Offset: 0x0020EF3F
		<oO0oooo("1953")>
		Public ReadOnly Property CurrentSheetName As String
			Get
				Return Me.o0OooO_.0.
			End Get
		End Property

		' Token: 0x170011F4 RID: 4596
		' (get) Token: 0x06004FBF RID: 20415 RVA: 0x00210D47 File Offset: 0x0020EF47
		<oO0oooo("1954")>
		Public ReadOnly Property Marks As Dictionary(Of String, Object)
			Get
				Return Me.O_0_o.Oo_oo0_O.
			End Get
		End Property

		' Token: 0x170011F5 RID: 4597
		' (get) Token: 0x06004FC0 RID: 20416 RVA: 0x00210D4F File Offset: 0x0020EF4F
		' (set) Token: 0x06004FC1 RID: 20417 RVA: 0x00210D57 File Offset: 0x0020EF57
		Public Property MergeFree As Boolean
			Get
				Return Me.O_0_o.Oo_oo0_O.
			End Get
			Set(value As Boolean)
				Me.O_0_o.Oo_oo0_O. = value
			End Set
		End Property

		' Token: 0x170011F6 RID: 4598
		' (get) Token: 0x06004FC2 RID: 20418 RVA: 0x00210D60 File Offset: 0x0020EF60
		' (set) Token: 0x06004FC3 RID: 20419 RVA: 0x00210D68 File Offset: 0x0020EF68
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property PreBuild As Boolean
			Get
				Return Me.O_ooo.o0.
			End Get
			Set(value As Boolean)
				Me.O_ooo.o0. = value
			End Set
		End Property

		' Token: 0x06004FC4 RID: 20420 RVA: 0x00210D71 File Offset: 0x0020EF71
		<oO0oooo("1151")>
		Public Function Build(ParamArray Indexes As Integer()) As Boolean
			Me.oOo_o0.o_0..o__0_.oO. = Me.oO.o_0o__.
			Me.OOO0_O0.O..o__0_.oO. = Me.oO.o_0o__.
			Return Me.ooo._O.(Indexes)
		End Function

		' Token: 0x06004FC5 RID: 20421 RVA: 0x00210D9C File Offset: 0x0020EF9C
		Private Function <<EMPTY_NAME>>(ParamArray A_0 As Integer()) As Boolean
			Dim list As List(Of Integer) = New List(Of Integer)()
			Dim flag As Boolean = False
			list.AddRange(A_0)
			If Me.O_0_o.Oo_oo0_O..Count > 0 Then
				Me.ooo._O.()
			End If
			Dim result As Boolean
			Try
				Dim buildEventArgs As BuildEventArgs = New BuildEventArgs(Me)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeBuild", New Object() { buildEventArgs }, False, "Excel报表", False)
				Me.oO.o_0o__. = Me.oO.o_0o__..Sheets.Count
				Dim num As Integer = Me.oO.o_0o__. - 1
				For i As Integer = 0 To num
					If Not list.Contains(i) Then
						Dim xlsheet As XLSheet = Me.oO.o_0o__..Sheets(i)
						Dim xlsheet2 As XLSheet = xlsheet.Clone()
						Me.o0OooO_.0. = xlsheet.Name
						xlsheet2.Name = "__" + xlsheet.Name
						xlsheet2.Rows.Clear()
						xlsheet2.MergedCells.Clear()
						Me.oO.o_0o__..Sheets.Add(xlsheet2)
						xlsheet2.DefaultRowHeight = xlsheet.DefaultRowHeight
						xlsheet2.DefaultColumnWidth = xlsheet.DefaultColumnWidth
						If Not Me.o_0Oo.0___OO0_.(xlsheet) Then
							Return False
						End If
						Dim a_ As Integer = 0
						Dim a_2 As Integer = -1
						Dim num2 As Integer
						Dim num3 As Integer
						If Me.OoO.o0..ContainsKey("FooterRow".ToLower()) Then
							num2 = Me.OoO.o0.("FooterRow".ToLower())
							num3 = num2
							If Me.O.o00O0___O..ContainsKey("FooterRow".ToLower()) Then
								num3 = Me.O.o00O0___O.("FooterRow".ToLower())
							End If
						End If
						Dim num4 As Integer = Me.oOo_o0.o_0.
						For j As Integer = 0 To num4
							If num2 <= 0 OrElse j < num2 OrElse j > num3 Then
								Dim text As String = xlsheet(j, 0).Text.Trim(New Char() { " "c, vbCr, vbLf })
								If Operators.CompareString(text, "", True) > 0 Then
									If Operators.CompareString(text, "<HeaderRow>", True) = 0 And Not flag Then
										flag = True
										Dim pageHeaderEventArgs As PageHeaderEventArgs = New PageHeaderEventArgs(Me)
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageHeader", New Object() { pageHeaderEventArgs }, False, "Excel报表", False)
									End If
									If Operators.CompareString(text, "{Skip}", True) = 0 Then
										GoTo IL_30F
									End If
									If LikeOperator.LikeString(text, "<*>", CompareMethod.Text) AndAlso text.Length >= 3 AndAlso Operators.CompareString(text, "<HeaderRow>", True) <> 0 AndAlso Operators.CompareString(text, "<FooterRow>", True) <> 0 Then
										text = text.Substring(1, text.Length - 2)
										text = text.Split(New Char() { ","c })(0)
										If Me.OoO.o0..ContainsKey(text) Then
											Me.ooo._O.(xlsheet, xlsheet2, a_, a_2)
											Me.ooo._O.(text, Nothing, xlsheet, xlsheet2, 0, Nothing)
											If Me.O.o00O0___O..ContainsKey(text) Then
												j = Me.O.o00O0___O.(text)
											End If
											a_ = j + 1
											GoTo IL_30F
										End If
									End If
								End If
								Me.ooo._O.(xlsheet, j, xlsheet2, xlsheet2.Rows.Count, Nothing, 0, Nothing, Nothing)
								a_2 = j
							End If
							IL_30F:
						Next
						Me.ooo._O.(xlsheet, xlsheet2, a_, a_2)
						If Me.OOO0_O0.O..Count > 0 Then
							Dim array As Integer() = New Integer(Me.OOO0_O0.O..Count - 1 + 1 - 1) {}
							Dim array2 As Integer() = New Integer(Me.OOO0_O0.O..Count - 1 + 1 - 1) {}
							Dim array3 As String() = New String(Me.OOO0_O0.O..Count - 1 + 1 - 1) {}
							Dim array4 As String() = New String(Me.OOO0_O0.O..Count - 1 + 1 - 1) {}
							Dim num5 As Integer = Me.OOO0_O0.O..Count - 1
							For k As Integer = 0 To num5
								Dim num6 As Integer = Me.OOO0_O0.O.(k)
								array3(k) = xlsheet2(0, num6).Text
							Next
							Dim num7 As Integer = xlsheet2.Rows.Count - 1
							For l As Integer = 1 To num7
								Dim num8 As Integer = Me.OOO0_O0.O..Count - 1
								For m As Integer = 0 To num8
									Dim num6 As Integer = Me.OOO0_O0.O.(m)
									If xlsheet2(l, num6).Value Is DBNull.Value Then
										array4(m) = ""
									Else
										array4(m) = xlsheet2(l, num6).Text
									End If
									If Operators.CompareString(array4(m), "", True) > 0 AndAlso Operators.CompareString(array3(m), "", True) > 0 AndAlso Operators.CompareString(array4(m), array3(m), True) = 0 Then
										array2(m) = l
									Else
										If array2(m) > array(m) Then
											xlsheet2.MergedCells.Add(array(m), num6 - 1, array2(m) - array(m) + 1, Me.o_0Oo.0___OO0_.(xlsheet2, array(m), num6 - 1))
										End If
										array(m) = l
										array2(m) = l
										array3(m) = array4(m)
										If Not Me.MergeFree Then
											Dim num9 As Integer = m + 1
											Dim num10 As Integer = Me.OOO0_O0.O..Count - 1
											For n As Integer = num9 To num10
												If array2(n) > array(n) Then
													xlsheet2.MergedCells.Add(array(n), Me.OOO0_O0.O.(n) - 1, array2(n) - array(n) + 1, Me.o_0Oo.0___OO0_.(xlsheet2, array(n), Me.OOO0_O0.O.(n) - 1))
												End If
												array(n) = l
												array2(n) = l
												If xlsheet2(l, Me.OOO0_O0.O.(n)).Value Is DBNull.Value Then
													array3(n) = ""
												Else
													array3(n) = xlsheet2(l, Me.OOO0_O0.O.(n)).Text
												End If
												array4(n) = array3(n)
											Next
										End If
									End If
									If array2(m) > array(m) AndAlso l = xlsheet2.Rows.Count - 1 Then
										xlsheet2.MergedCells.Add(array(m), num6 - 1, array2(m) - array(m) + 1, Me.o_0Oo.0___OO0_.(xlsheet2, array(m), num6 - 1))
									End If
								Next
							Next
						End If
					End If
				Next
				For num11 As Integer = Me.oO.o_0o__. - 1 To 0 Step -1
					If Not list.Contains(num11) Then
						Me.oO.o_0o__..Sheets.RemoveAt(num11)
					End If
				Next
				Try
					For Each obj As Object In Me.oO.o_0o__..Sheets
						Dim xlsheet3 As XLSheet = CType(obj, XLSheet)
						If xlsheet3.Name.StartsWith("__") Then
							xlsheet3.Name = xlsheet3.Name.TrimStart(New Char() { "_"c })
							If xlsheet3.Columns.Count > 0 Then
								Dim list2 As List(Of XLCellRange) = New List(Of XLCellRange)()
								Try
									For Each obj2 As Object In xlsheet3.MergedCells
										Dim item As XLCellRange = CType(obj2, XLCellRange)
										list2.Add(item)
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								xlsheet3.Columns.RemoveAt(0)
								Try
									For Each xlcellRange As XLCellRange In list2
										xlsheet3.MergedCells.Add(xlcellRange)
									Next
								Finally
									Dim enumerator3 As List(Of XLCellRange).Enumerator
									CType(enumerator3, IDisposable).Dispose()
								End Try
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If O_O0OO.O00.00OO000___.() Then
					Try
						For Each obj3 As Object In Me.oO.o_0o__..Sheets
							CType(obj3, XLSheet).PrintSettings.Header = "www.foxtable.com"
						Next
					Finally
						Dim enumerator4 As IEnumerator
						If TypeOf enumerator4 Is IDisposable Then
							TryCast(enumerator4, IDisposable).Dispose()
						End If
					End Try
				End If
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterBuild", New Object() { buildEventArgs }, False, "Excel报表", False)
				result = True
			Catch a_3 As Exception
				ooO.oOo0Oo.o.(a_3, "")
				result = False
			End Try
			Return result
		End Function

		' Token: 0x06004FC6 RID: 20422 RVA: 0x00211674 File Offset: 0x0020F874
		Private Function <<EMPTY_NAME>>(A_0 As XLSheet, A_1 As Integer, A_2 As Integer) As Integer
			Try
				For Each obj As Object In A_0.MergedCells
					Dim xlcellRange As XLCellRange = CType(obj, XLCellRange)
					If xlcellRange.ColumnFrom = A_2 AndAlso xlcellRange.RowFrom = A_1 Then
						Return xlcellRange.ColumnCount
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return 1
		End Function

		' Token: 0x06004FC7 RID: 20423 RVA: 0x002116E8 File Offset: 0x0020F8E8
		Private Sub <<EMPTY_NAME>>(A_0 As XLSheet, A_1 As XLSheet, A_2 As Integer, A_3 As Integer)
			Dim a_ As Object() = New Object() { A_0, A_1, A_2, A_3, O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()) }
			O_O0OO.OoO_o.oO0o0O.(Book.ExtendAsm, "CopyMergeCells", a_, False, "", False)
		End Sub

		' Token: 0x06004FC8 RID: 20424 RVA: 0x00211748 File Offset: 0x0020F948
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataRow, A_2 As XLSheet, A_3 As XLSheet, A_4 As Integer, A_5 As List(Of DataRow))
			Dim num As Integer
			Dim num48 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = Me.OoO.o0.(A_0)
				IL_17:
				num2 = 3
				Dim num4 As Integer = num3
				IL_1D:
				num2 = 4
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_26:
				num2 = 5
				Dim list2 As List(Of DataRow) = New List(Of DataRow)()
				IL_2F:
				num2 = 6
				Dim a_ As Integer = num3
				IL_35:
				num2 = 7
				Dim a_2 As Integer = -1
				IL_3A:
				num2 = 8
				Dim num5 As Integer = 1
				IL_3F:
				num2 = 9
				If Not Me.O.o00O0___O..ContainsKey(A_0) Then
					GoTo IL_61
				End If
				IL_50:
				num2 = 10
				num4 = Me.O.o00O0___O.(A_0)
				IL_61:
				num2 = 11
				If Not Me.Ooo.00_O0_0_..ContainsKey(A_0) Then
					GoTo IL_83
				End If
				IL_72:
				num2 = 12
				Dim num6 As Integer = Me.Ooo.00_O0_0_.(A_0)
				IL_83:
				num2 = 13
				If Not Me.OoO.o0..ContainsKey("FooterRow".ToLower()) Then
					GoTo IL_F2
				End If
				IL_9D:
				num2 = 14
				Dim num7 As Integer = Me.OoO.o0.("FooterRow".ToLower())
				IL_B7:
				num2 = 15
				Dim num8 As Integer = num7
				IL_BE:
				num2 = 16
				If Not Me.O.o00O0___O..ContainsKey("FooterRow".ToLower()) Then
					GoTo IL_F2
				End If
				IL_D8:
				num2 = 17
				num8 = Me.O.o00O0___O.("FooterRow".ToLower())
				IL_F2:
				num2 = 18
				If A_1 Is Nothing OrElse A_1.Table.DataSet Is Nothing Then
					GoTo IL_275
				End If
				IL_10B:
				num2 = 19
				Dim enumerator As IEnumerator = A_1.Table.DataSet.Relations.GetEnumerator()
				Dim flag As Boolean
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					IL_138:
					num2 = 20
					If Operators.CompareString(dataRelation.ParentTable.TableName, A_1.Table.TableName, True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, Me.oO.o_0o__.(A_0).Name, True) = 0 Then
						IL_185:
						num2 = 21
						Dim sort As String = ""
						IL_18F:
						num2 = 22
						Dim filterExpression As String = ""
						IL_199:
						num2 = 23
						If Me.O_ooo.o0..ContainsKey(A_0) Then
							IL_1AA:
							num2 = 24
							sort = Me.O_ooo.o0.(A_0)
						End If
						IL_1BB:
						num2 = 25
						If Me.O_0_o.Oo_oo0_O..ContainsKey(A_0) Then
							IL_1CC:
							num2 = 26
							filterExpression = Oo00.oo0o.O0O_0__.(A_1, Me.oO.o_0o__.(A_0).Name) + " And " + Me.O_0_o.Oo_oo0_O.(A_0)
						Else
							IL_200:
							num2 = 28
							filterExpression = Oo00.oo0o.O0O_0__.(A_1, Me.oO.o_0o__.(A_0).Name)
						End If
						IL_21C:
						num2 = 29
						Dim collection As DataRow() = Me.oO.o_0o__.(A_0).BaseTable.[Select](filterExpression, sort)
						IL_23B:
						num2 = 30
						list.AddRange(collection)
						IL_247:
						num2 = 31
						flag = True
						Exit While
					End If
					IL_24E:
					num2 = 33
				End While
				IL_25D:
				num2 = 34
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_275:
				num2 = 35
				If flag Then
					GoTo IL_630
				End If
				IL_27E:
				num2 = 36
				Dim text As String = ""
				IL_288:
				num2 = 37
				If Not Me.O_0_o.Oo_oo0_O..ContainsKey(A_0) Then
					GoTo IL_2AA
				End If
				IL_299:
				num2 = 38
				text = Me.O_0_o.Oo_oo0_O.(A_0)
				IL_2AA:
				num2 = 39
				Dim text2 As String = ""
				IL_2B4:
				num2 = 40
				If Not Me.O_ooo.o0..ContainsKey(A_0) Then
					GoTo IL_2D6
				End If
				IL_2C5:
				num2 = 41
				text2 = Me.O_ooo.o0.(A_0)
				IL_2D6:
				num2 = 42
				If Me.oO.o_0o__.(A_0).BaseTable.DataSet IsNot Me.oO.o_0o__. Then
					GoTo IL_33C
				End If
				IL_2F7:
				num2 = 43
				If Operators.CompareString(text, "all", True) <> 0 Then
					GoTo IL_313
				End If
				IL_309:
				num2 = 44
				text = ""
				IL_313:
				num2 = 45
				list.AddRange(Me.oO.o_0o__.(A_0).BaseTable.[Select](text, text2))
				GoTo IL_613
				IL_33C:
				num2 = 47
				If Operators.CompareString(OO_00oOO.CurrentTable.DataTable.Name, A_0, True) <> 0 Then
					GoTo IL_363
				End If
				IL_357:
				num2 = 48
				Dim table As Table = OO_00oOO.CurrentTable
				GoTo IL_373
				IL_363:
				num2 = 50
				table = OO_00oOO.Tables(A_0)
				IL_373:
				num2 = 51
				If Me.O_0_o.Oo_oo0_O..ContainsKey(A_0) Then
					GoTo IL_562
				End If
				IL_387:
				num2 = 52
				Dim topRow As Integer = table.foxGrid.Selection.TopRow
				Dim bottomRow As Integer = table.foxGrid.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					IL_3BA:
					num2 = 53
					If i < table.foxGrid.Rows.Fixed Then
						Exit For
					End If
					IL_3D2:
					num2 = 55
					If table.foxGrid.Rows(i).DataIndex >= 0 Then
						IL_3F0:
						num2 = 56
						list.Add(table.View.O0O_0_0__.0O.(table.foxGrid.Rows(i).DataIndex).Row)
					End If
					IL_423:
					num2 = 57
				Next
				IL_432:
				num2 = 58
				If Operators.CompareString(text2, "", True) <= 0 OrElse list.Count <= 0 Then
					GoTo IL_613
				End If
				IL_455:
				num2 = 59
				Dim dataTable As DataTable = Me.ooo._O.(list(0).Table)
				IL_46D:
				num2 = 60
				dataTable.Columns.Add("Column!@#()_ForRow", GetType(DataRow))
				IL_48C:
				num2 = 61
				Dim enumerator2 As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim dataRow As DataRow = enumerator2.Current
					IL_4A3:
					num2 = 62
					dataTable.ImportRow(dataRow)
					IL_4AF:
					num2 = 63
					dataTable.Rows(dataTable.Rows.Count - 1)("Column!@#()_ForRow") = dataRow
					IL_4D8:
					num2 = 64
				End While
				IL_4E4:
				num2 = 65
				CType(enumerator2, IDisposable).Dispose()
				IL_4F4:
				num2 = 66
				list.Clear()
				IL_4FE:
				num2 = 67
				For Each dataRow2 As DataRow In dataTable.[Select]("", text2)
					IL_51D:
					num2 = 68
					list.Add(CType(dataRow2("Column!@#()_ForRow"), DataRow))
					IL_538:
					num2 = 69
				Next
				IL_549:
				num2 = 70
				dataTable.Reset()
				IL_553:
				num2 = 71
				dataTable.Dispose()
				GoTo IL_613
				IL_562:
				num2 = 73
				If Operators.CompareString(text2, "", True) <> 0 Then
					GoTo IL_585
				End If
				IL_574:
				num2 = 74
				text2 = table.View.oO_O.o_OOO.()
				IL_585:
				num2 = 75
				If Operators.CompareString(text, "ALL", True) <> 0 Then
					GoTo IL_5AA
				End If
				IL_597:
				num2 = 76
				text = table.View.oo_0._o.()
				GoTo IL_5E4
				IL_5AA:
				num2 = 78
				If Operators.CompareString(table.View.oo_0._o.(), "", True) <= 0 Then
					GoTo IL_5E4
				End If
				IL_5C7:
				num2 = 79
				text = text + " And " + table.View.oo_0._o.()
				IL_5E4:
				num2 = 80
				Dim collection2 As DataRow() = OO_00oOO.Tables(A_0).DataTable.BaseTable.[Select](text, text2)
				IL_607:
				num2 = 81
				list.AddRange(collection2)
				IL_613:
				num2 = 82
				If Operators.CompareString(A_0, Me.OOoOOo0.000., True) <> 0 Then
					GoTo IL_630
				End If
				IL_625:
				num2 = 83
				Me.OOO0_O0.O. = list
				IL_630:
				num2 = 84
				If num6 >= 0 Then
					GoTo IL_64B
				End If
				IL_638:
				num2 = 85
				num6 = Math.Abs(num6)
				IL_644:
				num2 = 86
				Dim num9 As Integer = num6
				IL_64B:
				num2 = 87
				Dim count As Integer = list.Count
				IL_657:
				num2 = 88
				If Not Me.o._0_Oo0o..ContainsKey(A_0) Then
					GoTo IL_67F
				End If
				IL_668:
				num2 = 89
				num5 = Math.Max(1, Me.o._0_Oo0o.(A_0))
				IL_67F:
				num2 = 90
				If count <> 0 OrElse num9 <= 0 Then
					GoTo IL_75E
				End If
				IL_691:
				num2 = 91
				Dim num10 As Integer = num9 - 1
				For k As Integer = 0 To num10
					IL_6A2:
					num2 = 92
					Dim detailEventArgs As DetailEventArgs = New DetailEventArgs(Me, A_0, Nothing)
					IL_6AF:
					num2 = 93
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", New Object() { detailEventArgs }, False, "Excel报表", False)
					IL_6D4:
					num2 = 94
					a_ = num3
					IL_6DB:
					num2 = 95
					Dim num11 As Integer = num3
					Dim num12 As Integer = num4
					Dim l As Integer = num11
					While l <= num12
						IL_6E8:
						num2 = 96
						If num7 <= 0 Then
							GoTo IL_6FF
						End If
						IL_6F0:
						num2 = 97
						If l < num7 OrElse l > num8 Then
							GoTo IL_6FF
						End If
						IL_726:
						num2 = 101
						l += 1
						Continue While
						IL_6FF:
						num2 = 99
						Me.ooo._O.(A_2, l, A_3, A_3.Rows.Count, Nothing, k, Nothing, list)
						IL_71F:
						num2 = 100
						a_2 = l
						GoTo IL_726
					End While
					IL_735:
					num2 = 102
					Me.ooo._O.(A_2, A_3, a_, a_2)
					IL_745:
					num2 = 103
				Next
				IL_757:
				num2 = 104
				Dim num13 As Integer = num9
				IL_75E:
				num2 = 105
				Dim num14 As Integer = count - 1
				Dim num15 As Integer = num5
				Dim num16 As Integer = 0
				While (num15 >> 31 Xor num16) <= (num15 >> 31 Xor num14)
					IL_773:
					num2 = 106
					Dim dataRow3 As DataRow
					If num16 < list.Count Then
						IL_781:
						num2 = 107
						dataRow3 = list(num16)
						IL_78F:
						num2 = 108
						list2.Add(dataRow3)
					Else
						IL_79D:
						num2 = 110
						dataRow3 = Nothing
					End If
					IL_7A3:
					num2 = 111
					If dataRow3 IsNot Nothing Then
						IL_7AD:
						num2 = 112
						Me.OOO0_O0.O..O_0o_.O_0.(num16, num5, list)
						IL_7C1:
						num2 = 113
						Dim enumerator3 As List(Of Book.Oo_0o).Enumerator = Me.OOO0_O0.O..o__0_.oO..GetEnumerator()
						While enumerator3.MoveNext()
							Dim oo_0o As Book.Oo_0o = enumerator3.Current
							IL_7E4:
							num2 = 114
							Dim groupHeaderEventArgs As GroupHeaderEventArgs = New GroupHeaderEventArgs(Me, oo_0o.O_0o_.O_0., oo_0o.OoO.o0., New DataRow(dataRow3), False)
							IL_805:
							num2 = 115
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupHeader", New Object() { groupHeaderEventArgs }, False, "Excel报表", False)
							IL_82A:
							num2 = 116
							Dim o_0o_.O_0. As Integer = oo_0o.O_0o_.O_0.
							Dim oooo.0O__oo. As Integer = oo_0o.oooo.0O__oo.
							For m As Integer = o_0o_.O_0. To oooo.0O__oo.
								IL_841:
								num2 = 117
								Me.ooo._O.(A_2, m, A_3, A_3.Rows.Count, dataRow3, 0, Nothing, Nothing)
								IL_860:
								num2 = 118
							Next
							IL_86F:
							num2 = 119
							Me.ooo._O.(A_2, A_3, oo_0o.O_0o_.O_0., oo_0o.oooo.0O__oo.)
							IL_889:
							num2 = 120
						End While
						IL_898:
						num2 = 121
						CType(enumerator3, IDisposable).Dispose()
						IL_8A8:
						num2 = 122
						Me.OOO0_O0.O..o__0_.oO..Clear()
					End If
					IL_8BB:
					num2 = 123
					Dim detailEventArgs2 As DetailEventArgs = New DetailEventArgs(Me, A_0, New DataRow(dataRow3))
					IL_8CE:
					num2 = 124
					If dataRow3 IsNot Nothing Then
						IL_8D5:
						num2 = 125
						detailEventArgs2 = New DetailEventArgs(Me, A_0, New DataRow(dataRow3))
					Else
						IL_8EA:
						num2 = 127
						detailEventArgs2 = New DetailEventArgs(Me, A_0, Nothing)
					End If
					IL_8F7:
					num2 = 128
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", New Object() { detailEventArgs2 }, False, "Excel报表", False)
					IL_91F:
					num2 = 129
					a_ = num3
					IL_929:
					num2 = 130
					Dim num17 As Integer = num3
					Dim num18 As Integer = num4
					Dim n As Integer = num17
					While n <= num18
						IL_93C:
						num2 = 131
						If num7 <= 0 Then
							GoTo IL_95C
						End If
						IL_947:
						num2 = 132
						If n < num7 OrElse n > num8 Then
							GoTo IL_95C
						End If
						IL_AFC:
						num2 = 150
						n += 1
						Continue While
						IL_95C:
						num2 = 134
						Dim text3 As String = A_2(n, 0).Text.Trim(New Char() { " "c, vbLf, vbCr })
						IL_988:
						num2 = 135
						If n > num3 AndAlso n < num4 AndAlso dataRow3 IsNot Nothing AndAlso Operators.CompareString(text3, "", True) > 0 Then
							IL_9BA:
							num2 = 136
							If LikeOperator.LikeString(text3, "<*>", CompareMethod.Text) AndAlso text3.Length >= 3 AndAlso Operators.CompareString(text3, "<HeaderRow>", True) <> 0 AndAlso Operators.CompareString(text3, "<FooterRow>", True) <> 0 Then
								IL_A03:
								num2 = 137
								text3 = text3.Substring(1, text3.Length - 2)
								IL_A1C:
								num2 = 138
								Dim array2 As String() = text3.Split(New Char() { ","c })
								IL_A36:
								num2 = 139
								text3 = array2(0)
								IL_A42:
								num2 = 140
								If Me.OoO.o0..ContainsKey(text3) Then
									IL_A57:
									num2 = 141
									Me.ooo._O.(A_2, A_3, a_, a_2)
									IL_A6A:
									num2 = 142
									Me.ooo._O.(text3, dataRow3, A_2, A_3, num16, list)
									IL_A81:
									num2 = 143
									If Me.O.o00O0___O..ContainsKey(text3) Then
										IL_A96:
										num2 = 144
										n = Me.O.o00O0___O.(text3)
									End If
									IL_AAB:
									num2 = 145
									a_ = n + 1
									GoTo IL_AFC
								End If
							End If
						End If
						IL_AB9:
						num2 = 147
						If Operators.CompareString(text3, "{Skip}", True) <> 0 Then
							IL_ACE:
							num2 = 148
							Me.ooo._O.(A_2, n, A_3, A_3.Rows.Count, dataRow3, num16, Nothing, list)
						End If
						IL_AF2:
						num2 = 149
						a_2 = n
						GoTo IL_AFC
					End While
					IL_B11:
					num2 = 151
					Me.ooo._O.(A_2, A_3, a_, a_2)
					IL_B24:
					num2 = 152
					num13 += 1
					IL_B30:
					num2 = 153
					If dataRow3 IsNot Nothing Then
						IL_B3D:
						num2 = 154
						If dataRow3 IsNot Nothing Then
							IL_B4A:
							num2 = 155
							Me.oOo_o0.o_0..oooo.0O__oo.(num16, num5, list)
							IL_B61:
							num2 = 156
							If Me.oOo_o0.o_0..o__0_.oO. Then
								IL_B77:
								num2 = 157
								If num13 < num9 Then
									IL_B86:
									num2 = 158
									Dim num19 As Integer = num13 + 1
									Dim num20 As Integer = num9
									For num21 As Integer = num19 To num20
										IL_B9B:
										num2 = 159
										detailEventArgs2 = New DetailEventArgs(Me, A_0, Nothing)
										IL_BAB:
										num2 = 160
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", New Object() { detailEventArgs2 }, False, "Excel报表", False)
										IL_BD3:
										num2 = 161
										a_ = num3
										IL_BDD:
										num2 = 162
										Dim num22 As Integer = num3
										Dim num23 As Integer = num4
										Dim num24 As Integer = num22
										While num24 <= num23
											IL_BED:
											num2 = 163
											If num7 <= 0 Then
												GoTo IL_C0A
											End If
											IL_BF8:
											num2 = 164
											If num24 < num7 OrElse num24 > num8 Then
												GoTo IL_C0A
											End If
											IL_C37:
											num2 = 168
											num24 += 1
											Continue While
											IL_C0A:
											num2 = 166
											Me.ooo._O.(A_2, num24, A_3, A_3.Rows.Count, Nothing, num16, Nothing, list)
											IL_C2D:
											num2 = 167
											a_2 = num24
											GoTo IL_C37
										End While
										IL_C49:
										num2 = 169
										Me.ooo._O.(A_2, A_3, a_, a_2)
										IL_C5C:
										num2 = 170
									Next
									IL_C71:
									num2 = 171
									num13 = num9
								End If
							End If
							IL_C7B:
							num2 = 172
							Dim num25 As Integer = Me.oOo_o0.o_0..o0.o0O__0oo..Count - 1
							For num26 As Integer = 0 To num25
								IL_C9D:
								num2 = 173
								Dim oo_0o2 As Book.Oo_0o = Me.oOo_o0.o_0..o0.o0O__0oo.(num26)
								IL_CB7:
								num2 = 174
								Dim groupFooterEventArgs As GroupFooterEventArgs = New GroupFooterEventArgs(Me, oo_0o2.O_0o_.O_0., oo_0o2.OoO.o0., oo_0o2.oO.o_0o__., Me.oO.o_0o__.(Me.oO.o_0o__.(oo_0o2.O_0o_.O_0.).Name))
								IL_CFC:
								num2 = 175
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupFooter", New Object() { groupFooterEventArgs }, False, "Excel报表", False)
								IL_D24:
								num2 = 176
								Dim o_0o_.O_0.2 As Integer = oo_0o2.O_0o_.O_0.
								Dim oooo.0O__oo.2 As Integer = oo_0o2.oooo.0O__oo.
								For num27 As Integer = o_0o_.O_0.2 To oooo.0O__oo.2
									IL_D3E:
									num2 = 177
									Me.ooo._O.(A_2, num27, A_3, A_3.Rows.Count, dataRow3, 0, oo_0o2.oO.o_0o__., Nothing)
									IL_D66:
									num2 = 178
								Next
								IL_D78:
								num2 = 179
								Me.ooo._O.(A_2, A_3, oo_0o2.O_0o_.O_0., oo_0o2.oooo.0O__oo.)
								IL_D95:
								num2 = 180
							Next
							IL_DAA:
							num2 = 181
							Me.oOo_o0.o_0..O_0o_.O_0.()
						End If
					End If
					IL_DBB:
					num2 = 182
					If num16 = count - 1 OrElse num16 + num5 >= count Then
						IL_DD5:
						num2 = 183
						If num13 < num9 Then
							IL_DE4:
							num2 = 184
							Dim num28 As Integer = num13 + 1
							Dim num29 As Integer = num9
							For num30 As Integer = num28 To num29
								IL_DF9:
								num2 = 185
								detailEventArgs2 = New DetailEventArgs(Me, A_0, Nothing)
								IL_E09:
								num2 = 186
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildDetail", New Object() { detailEventArgs2 }, False, "Excel报表", False)
								IL_E31:
								num2 = 187
								a_ = num3
								IL_E3B:
								num2 = 188
								Dim num31 As Integer = num3
								Dim num32 As Integer = num4
								Dim num33 As Integer = num31
								While num33 <= num32
									IL_E4B:
									num2 = 189
									If num7 <= 0 Then
										GoTo IL_E68
									End If
									IL_E56:
									num2 = 190
									If num33 < num7 OrElse num33 > num8 Then
										GoTo IL_E68
									End If
									IL_E95:
									num2 = 194
									num33 += 1
									Continue While
									IL_E68:
									num2 = 192
									Me.ooo._O.(A_2, num33, A_3, A_3.Rows.Count, Nothing, num16, Nothing, list)
									IL_E8B:
									num2 = 193
									a_2 = num33
									GoTo IL_E95
								End While
								IL_EA7:
								num2 = 195
								Me.ooo._O.(A_2, A_3, a_, a_2)
								IL_EBA:
								num2 = 196
							Next
							IL_ECF:
							num2 = 197
							num13 = num9
						End If
					End If
					IL_ED9:
					num2 = 198
					If num13 = num6 OrElse num16 + num5 >= count OrElse Me.oOo_o0.o_0..o__0_.oO. Then
						IL_EFE:
						num2 = 199
						num13 = 0
						IL_F07:
						num2 = 200
						If Me.OoO.o0..ContainsKey("FooterRow".ToLower()) Then
							IL_F27:
							num2 = 201
							If num7 > num4 Then
								IL_F36:
								num2 = 202
								Dim pageFooterEventArgs As PageFooterEventArgs = New PageFooterEventArgs(Me, list2, Me.oO.o_0o__.(list(0).Table.TableName))
								IL_F63:
								num2 = 203
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageFooter", New Object() { pageFooterEventArgs }, False, "Excel报表", False)
								IL_F8B:
								num2 = 204
								Dim num34 As Integer = num7
								Dim num35 As Integer = num8
								For num36 As Integer = num34 To num35
									IL_F9B:
									num2 = 205
									Me.ooo._O.(A_2, num36, A_3, A_3.Rows.Count, A_1, A_4, list2, A_5)
									IL_FBF:
									num2 = 206
								Next
								IL_FD1:
								num2 = 207
								Me.ooo._O.(A_2, A_3, num7, num8)
							End If
						End If
						IL_FE4:
						num2 = 208
						list2.Clear()
						IL_FF1:
						num2 = 209
						If num16 + num5 < count AndAlso dataRow3 IsNot Nothing Then
							IL_100A:
							num2 = 210
							If Not Me.O_0_o.Oo_oo0_O..ContainsKey(A_0) Then
								IL_101E:
								num2 = 211
								A_3.Rows(A_3.Rows.Count - 1).PageBreak = True
							Else
								IL_1046:
								num2 = 213
								Dim num37 As Integer
								num37 += 1
								IL_1052:
								num2 = 214
								If num37 = Me.O_0_o.Oo_oo0_O.(A_0) Then
									IL_1068:
									num2 = 215
									num37 = 0
									IL_1071:
									num2 = 216
									A_3.Rows(A_3.Rows.Count - 1).PageBreak = True
								End If
							End If
							IL_1097:
							num2 = 217
							If Me.OoO.o0..ContainsKey("HeaderRow".ToLower()) Then
								IL_10B7:
								num2 = 218
								Dim num38 As Integer = Me.OoO.o0.("HeaderRow".ToLower())
								IL_10D4:
								num2 = 219
								Dim num39 As Integer = num38
								IL_10DE:
								num2 = 220
								If Me.O.o00O0___O..ContainsKey("HeaderRow".ToLower()) Then
									IL_10FB:
									num2 = 221
									num39 = Me.O.o00O0___O.("HeaderRow".ToLower())
								End If
								IL_1118:
								num2 = 222
								If num39 < num3 Then
									IL_1127:
									num2 = 223
									Dim pageHeaderEventArgs As PageHeaderEventArgs = New PageHeaderEventArgs(Me)
									IL_1135:
									num2 = 224
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildPageHeader", New Object() { pageHeaderEventArgs }, False, "Excel报表", False)
									IL_115D:
									num2 = 225
									Dim num40 As Integer = num38
									Dim num41 As Integer = num39
									For num42 As Integer = num40 To num41
										IL_116D:
										num2 = 226
										Me.ooo._O.(A_2, num42, A_3, A_3.Rows.Count, A_1, A_4, Nothing, A_5)
										IL_1190:
										num2 = 227
									Next
									IL_11A2:
									num2 = 228
									Me.ooo._O.(A_2, A_3, num38, num39)
								End If
							End If
							IL_11B5:
							num2 = 229
							Me.OOO0_O0.O..o._0OOooOo_o00.(num16, num5, list)
							IL_11CC:
							num2 = 230
							Dim enumerator4 As List(Of Book.Oo_0o).Enumerator = Me.OOO0_O0.O..O._0_o0O..GetEnumerator()
							While enumerator4.MoveNext()
								Dim oo_0o3 As Book.Oo_0o = enumerator4.Current
								IL_11F2:
								num2 = 231
								Dim groupHeaderEventArgs2 As GroupHeaderEventArgs = New GroupHeaderEventArgs(Me, oo_0o3.O_0o_.O_0., oo_0o3.OoO.o0., New DataRow(dataRow3), True)
								IL_1216:
								num2 = 232
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BuildGroupHeader", New Object() { groupHeaderEventArgs2 }, False, "Excel报表", False)
								IL_123E:
								num2 = 233
								Dim o_0o_.O_0.3 As Integer = oo_0o3.O_0o_.O_0.
								Dim oooo.0O__oo.3 As Integer = oo_0o3.oooo.0O__oo.
								For num43 As Integer = o_0o_.O_0.3 To oooo.0O__oo.3
									IL_1258:
									num2 = 234
									Me.ooo._O.(A_2, num43, A_3, A_3.Rows.Count, dataRow3, 0, Nothing, Nothing)
									IL_127A:
									num2 = 235
								Next
								IL_128C:
								num2 = 236
								Me.ooo._O.(A_2, A_3, oo_0o3.O_0o_.O_0., oo_0o3.oooo.0O__oo.)
								IL_12A9:
								num2 = 237
							End While
							IL_12BB:
							num2 = 238
							CType(enumerator4, IDisposable).Dispose()
							IL_12CE:
							num2 = 239
							Me.OOO0_O0.O..O._0_o0O..Clear()
						End If
					End If
					IL_12E4:
					num2 = 240
					If num5 > 1 Then
						IL_12EF:
						num2 = 241
						Dim num44 As Integer = num16 + 1
						Dim num45 As Integer = num16 + num5 - 1
						For num46 As Integer = num44 To num45
							IL_1306:
							num2 = 242
							If num46 > list.Count - 1 Then
								Exit For
							End If
							IL_1319:
							num2 = 244
							If Not Me.OOO0_O0.O..o__0_.oO.(list(num16), list(num46)) Then
								IL_133E:
								num2 = 245
								num16 = num46 - num5
								Exit For
							End If
							IL_134D:
							num2 = 247
						Next
					End If
					IL_135F:
					num2 = 248
					num16 += num15
				End While
				IL_1381:
				GoTo IL_17B7
				IL_1386:
				Dim num47 As Integer = num48 + 1
				num48 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num47)
				IL_1778:
				GoTo IL_17AC
				IL_177A:
				num48 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_178A:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num48 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_177A
			End Try
			IL_17AC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_17B7:
			If num48 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004FC9 RID: 20425 RVA: 0x00212F30 File Offset: 0x00211130
		Private Sub <<EMPTY_NAME>>(A_0 As XLSheet, A_1 As Integer, A_2 As XLSheet, A_3 As Integer, A_4 As DataRow, A_5 As Integer, A_6 As List(Of DataRow), A_7 As List(Of DataRow))
			Dim num As Integer
			Dim num8 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim xlrow As XLRow = A_0.Rows(A_1)
				IL_16:
				num2 = 3
				Dim xlrow2 As XLRow = A_2.Rows(A_3)
				IL_27:
				num2 = 4
				xlrow2.PageBreak = xlrow.PageBreak
				IL_36:
				num2 = 5
				If xlrow.Height <= 0 Then
					GoTo IL_52
				End If
				IL_41:
				num2 = 6
				xlrow2.Height = xlrow.Height
				GoTo IL_61
				IL_52:
				num2 = 8
				xlrow2.Height = A_0.DefaultRowHeight
				IL_61:
				num2 = 9
				xlrow2.Style = xlrow.Style
				IL_71:
				num2 = 10
				xlrow2.Visible = xlrow.Visible
				IL_81:
				num2 = 11
				If A_4 Is Nothing Then
					GoTo IL_111
				End If
				IL_8B:
				num2 = 12
				If Me.oO.o_0o__..ContainsKey(A_4.Table.TableName) Then
					GoTo IL_CD
				End If
				IL_A7:
				num2 = 13
				Dim value As List(Of DataRow) = New List(Of DataRow)()
				IL_B1:
				num2 = 14
				Me.oO.o_0o__..Add(A_4.Table.TableName, value)
				IL_CD:
				num2 = 15
				If Me.oO.o_0o__.(A_4.Table.TableName).Contains(A_4) Then
					GoTo IL_111
				End If
				IL_F0:
				num2 = 16
				Me.oO.o_0o__.(A_4.Table.TableName).Add(A_4)
				IL_111:
				num2 = 17
				Dim oooOOo0.000. As Integer = Me.OOoOOo0.000.
				For i As Integer = 1 To oooOOo0.000.
					IL_124:
					num2 = 18
					A_2(A_3, i).Value = RuntimeHelpers.GetObjectValue(A_0(A_1, i).Value)
					IL_149:
					num2 = 19
					A_2(A_3, i).Style = A_0(A_1, i).Style
					IL_169:
					num2 = 20
					A_2(A_3, i).Hyperlink = A_0(A_1, i).Hyperlink
					IL_189:
					num2 = 21
					A_2(A_3, i).Formula = A_0(A_1, i).Formula
					IL_1A9:
					num2 = 22
				Next
				IL_1BB:
				num2 = 23
				Dim oooOOo0.000.2 As Integer = Me.OOoOOo0.000.
				For j As Integer = 1 To oooOOo0.000.2
					IL_1CE:
					num2 = 24
					If Operators.CompareString(A_2(A_2.Rows.Count - 1, j).Formula, "", True) <= 0 Then
						IL_1FC:
						num2 = 26
						If A_2(A_2.Rows.Count - 1, j) IsNot Nothing AndAlso Not(TypeOf A_2(A_2.Rows.Count - 1, j).Value Is XLPictureShape) Then
							IL_23D:
							num2 = 28
							Dim text As String = A_2(A_2.Rows.Count - 1, j).Text.Trim(New Char() { " "c, vbLf, vbCr })
							IL_272:
							num2 = 29
							Dim obj As Object = Nothing
							IL_278:
							num2 = 30
							If Operators.CompareString(text, "", True) > 0 Then
								IL_28E:
								num2 = 31
								If text.StartsWith("<") AndAlso text.EndsWith(">") AndAlso text.Length >= 3 Then
									IL_2C0:
									num2 = 32
									A_2(A_2.Rows.Count - 1, j).Value = Nothing
									IL_2DE:
									num2 = 33
									text = text.Substring(1, text.Length - 2)
									IL_2F4:
									num2 = 34
									If Me.Marks.ContainsKey(text) Then
										IL_306:
										num2 = 35
										obj = RuntimeHelpers.GetObjectValue(Me.Marks(text))
									Else
										IL_322:
										num2 = 37
										If Operators.CompareString(text, "index", True) = 0 AndAlso A_4 IsNot Nothing Then
											IL_338:
											num2 = 38
											obj = A_5 + 1
										Else
											While True
												IL_34B:
												num2 = 41
												Dim num3 As Integer = text.IndexOf("*[")
												IL_35C:
												num2 = 42
												Dim num4 As Integer = text.IndexOf("]*")
												IL_36D:
												num2 = 43
												If num3 < 0 OrElse num4 <= num3 Then
													Exit For
												End If
												IL_381:
												num2 = 44
												Dim a_ As String = text.Substring(num3 + 1, num4 - num3)
												IL_396:
												num2 = 45
												Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o_0Oo.0___OO0_.(a_, A_4, A_5, A_6, A_7))
												IL_3B0:
												num2 = 46
												Dim text2 As String
												If objectValue Is Nothing Then
													IL_3B7:
													num2 = 47
													text2 = ""
												Else
													IL_3C3:
													num2 = 49
													text2 = objectValue.ToString()
													IL_3CF:
													num2 = 50
													If TypeOf objectValue Is String Then
														IL_3DB:
														num2 = 51
														text2 = """" + text2 + """"
													Else
														IL_3F3:
														num2 = 53
														If TypeOf objectValue Is DateTime Then
															IL_3FF:
															num2 = 54
															text2 = "#" + text2 + "#"
														End If
													End If
												End If
												IL_415:
												num2 = 55
												text = text.Remove(num3, num4 - num3 + 2)
												IL_42A:
												num2 = 56
												text = text.Insert(num3, text2)
												IL_43A:
												num2 = 57
												num3 = text.IndexOf("*[")
												IL_44B:
												num2 = 58
												num4 = text.IndexOf("]*")
											End While
											IL_461:
											num2 = 62
											If A_4 IsNot Nothing Then
												IL_468:
												num2 = 63
												obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text, New DataRow(A_4)))
											Else
												IL_485:
												num2 = 65
												obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text))
											End If
										End If
									End If
								Else
									IL_49B:
									num2 = 67
									If text.StartsWith("[") AndAlso text.EndsWith("]") AndAlso text.Length >= 3 Then
										While True
											IL_4CD:
											num2 = 69
											Dim num5 As Integer = text.IndexOf("<*")
											IL_4DE:
											num2 = 70
											Dim num6 As Integer = text.IndexOf("*>")
											IL_4EF:
											num2 = 71
											If num5 < 0 OrElse num6 <= num5 Then
												Exit For
											End If
											IL_503:
											num2 = 72
											Dim expr As String = text.Substring(num5 + 2, num6 - num5 - 2)
											IL_51A:
											num2 = 73
											Dim objectValue2 As Object
											If A_4 IsNot Nothing Then
												IL_521:
												num2 = 74
												objectValue2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(expr, New DataRow(A_4)))
											Else
												IL_53B:
												num2 = 76
												objectValue2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(expr))
											End If
											IL_54C:
											num2 = 77
											text = text.Remove(num5, num6 - num5 + 2)
											IL_561:
											num2 = 78
											If objectValue2 IsNot Nothing Then
												IL_568:
												num2 = 79
												text = text.Insert(num5, objectValue2.ToString())
											End If
											IL_57D:
											num2 = 80
											num5 = text.IndexOf("<*")
											IL_58E:
											num2 = 81
											num6 = text.IndexOf("*>")
										End While
										IL_5A4:
										num2 = 85
										A_2(A_2.Rows.Count - 1, j).Value = Nothing
										IL_5C2:
										num2 = 86
										obj = RuntimeHelpers.GetObjectValue(Me.o_0Oo.0___OO0_.(text, A_4, A_5, A_6, A_7))
									End If
								End If
								IL_5DC:
								num2 = 87
								If obj IsNot Nothing Then
									IL_5E3:
									num2 = 88
									A_2(A_2.Rows.Count - 1, j).Value = RuntimeHelpers.GetObjectValue(obj)
								End If
							End If
						End If
					End If
					IL_607:
					num2 = 89
				Next
				IL_619:
				GoTo IL_7D3
				IL_61E:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_794:
				GoTo IL_7C8
				IL_796:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7A6:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_796
			End Try
			IL_7C8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7D3:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004FCA RID: 20426 RVA: 0x00213734 File Offset: 0x00211934
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataRow, A_2 As Integer, A_3 As List(Of DataRow), A_4 As List(Of DataRow)) As Object
			Dim num As Integer
			Dim result As Object
			Dim num15 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim obj As Object = Nothing
				IL_0C:
				num2 = 3
				A_0 = A_0.Substring(1, A_0.Length - 2)
				IL_1F:
				num2 = 4
				If Not A_0.StartsWith("!") Then
					GoTo IL_6E
				End If
				IL_2E:
				num2 = 5
				A_0 = A_0.Substring(1)
				IL_39:
				num2 = 6
				If Not OO_00oOO.Vars.VariableTable.Columns.Contains(A_0) Then
					GoTo IL_19B0
				End If
				IL_55:
				num2 = 7
				obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Vars(A_0))
				GoTo IL_19B0
				IL_6E:
				num2 = 9
				If Not A_0.StartsWith("#") Then
					GoTo IL_274
				End If
				IL_81:
				num2 = 10
				A_0 = A_0.Substring(1)
				IL_8D:
				num2 = 11
				Dim array As String() = A_0.Split(New Char() { ","c })
				IL_A3:
				num2 = 12
				If array.Length <> 2 OrElse Not Me.oO.o_0o__..ContainsKey(array(0)) Then
					GoTo IL_19B0
				End If
				IL_C4:
				num2 = 13
				Dim text As String = array(1).Trim()
				IL_D2:
				num2 = 14
				Dim text2 As String = array(0)
				IL_DB:
				num2 = 15
				array = text.Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_F8:
				num2 = 16
				If array.Length <> 2 OrElse Not Me.oO.o_0o__.(text2).BaseTable.Columns.Contains(array(1)) Then
					GoTo IL_19B0
				End If
				IL_12A:
				num2 = 17
				Dim dataTable As DataTable = New DataTable()
				IL_134:
				num2 = 18
				dataTable.Columns.Add(array(1), Me.oO.o_0o__.(text2).BaseTable.Columns(array(1)).DataType)
				IL_16D:
				num2 = 19
				Dim enumerator As List(Of DataRow).Enumerator = Me.oO.o_0o__.(text2).GetEnumerator()
				While enumerator.MoveNext()
					Dim dataRow As DataRow = enumerator.Current
					IL_18F:
					num2 = 20
					dataTable.Rows.Add(dataTable.NewRow())
					IL_1A5:
					num2 = 21
					dataTable.Rows(dataTable.Rows.Count - 1)(0) = RuntimeHelpers.GetObjectValue(dataRow(array(1)))
					IL_1D8:
					num2 = 22
				End While
				IL_1E4:
				num2 = 23
				CType(enumerator, IDisposable).Dispose()
				IL_1F4:
				num2 = 24
				If Not text.StartsWith(":") Then
					GoTo IL_257
				End If
				IL_205:
				num2 = 25
				text = text.Substring(1)
				IL_212:
				num2 = 26
				obj = RuntimeHelpers.GetObjectValue(dataTable.Compute(text, ""))
				IL_22A:
				num2 = 27
				Dim text3 As String = ""
				IL_234:
				num2 = 28
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), text3)
				IL_24B:
				num2 = 29
				obj = text3
				GoTo IL_19B0
				IL_257:
				num2 = 31
				obj = RuntimeHelpers.GetObjectValue(dataTable.Compute(text, ""))
				GoTo IL_19B0
				IL_274:
				num2 = 33
				If Not A_0.StartsWith("$") Then
					GoTo IL_3EB
				End If
				IL_287:
				num2 = 34
				A_0 = A_0.Substring(1)
				IL_293:
				num2 = 35
				Dim array2 As String() = A_0.Split(New Char() { ","c })
				IL_2A9:
				num2 = 36
				Dim text4 As String = array2(0)
				IL_2B2:
				num2 = 37
				Dim text5 As String = array2(1).Trim()
				IL_2C0:
				num2 = 38
				Dim filter As String = ""
				IL_2CA:
				num2 = 39
				If array2.Length <> 3 Then
					GoTo IL_2DD
				End If
				IL_2D4:
				num2 = 40
				filter = array2(2)
				IL_2DD:
				num2 = 41
				If Not text5.StartsWith(":") Then
					GoTo IL_301
				End If
				IL_2EE:
				num2 = 42
				Dim flag As Boolean = True
				IL_2F4:
				num2 = 43
				text5 = text5.Substring(1)
				IL_301:
				num2 = 44
				If Not Me.oO.o_0o__..Contains(text4) Then
					GoTo IL_335
				End If
				IL_313:
				num2 = 45
				obj = RuntimeHelpers.GetObjectValue(Me.oO.o_0o__.(text4).Compute(text5, filter))
				GoTo IL_399
				IL_335:
				num2 = 47
				If Not Me.DataTables.Contains(text4) Then
					GoTo IL_369
				End If
				IL_347:
				num2 = 48
				obj = RuntimeHelpers.GetObjectValue(Me.DataTables(text4).Compute(text5, filter))
				GoTo IL_399
				IL_369:
				num2 = 50
				If Not OO_00oOO.Tables.get_Contains(text4) Then
					GoTo IL_399
				End If
				IL_37A:
				num2 = 51
				obj = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables(text4).Compute(text5, filter))
				IL_399:
				num2 = 52
				If obj IsNot DBNull.Value AndAlso obj IsNot Nothing Then
					GoTo IL_3B4
				End If
				IL_3A9:
				num2 = 53
				obj = 0
				IL_3B4:
				num2 = 54
				If Not flag Then
					GoTo IL_19B0
				End If
				IL_3BE:
				num2 = 55
				Dim text6 As String = ""
				IL_3C8:
				num2 = 56
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), text6)
				IL_3DF:
				num2 = 57
				obj = text6
				GoTo IL_19B0
				IL_3EB:
				num2 = 59
				If Not A_0.StartsWith("%") Then
					GoTo IL_891
				End If
				IL_3FE:
				num2 = 60
				A_0 = A_0.Substring(1).Trim()
				IL_40F:
				num2 = 61
				Dim text7 As String = ""
				IL_419:
				num2 = 62
				Dim text8 As String = ""
				IL_423:
				num2 = 63
				If A_3 Is Nothing Then
					GoTo IL_59E
				End If
				IL_42D:
				num2 = 64
				If A_3.Count <= 0 Then
					GoTo IL_83F
				End If
				IL_43D:
				num2 = 65
				Dim array3 As String() = A_0.Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_459:
				num2 = 66
				array3(1) = array3(1).Trim(New Char() { "["c, "]"c })
				IL_479:
				num2 = 67
				If array3.Length <> 2 OrElse Not A_3(0).Table.Columns.Contains(array3(1)) Then
					GoTo IL_83F
				End If
				IL_4A6:
				num2 = 68
				Dim dataTable2 As DataTable = New DataTable()
				IL_4B0:
				num2 = 69
				dataTable2.Columns.Add(array3(1), A_3(0).Table.Columns(array3(1)).DataType)
				IL_4E4:
				num2 = 70
				Dim enumerator2 As List(Of DataRow).Enumerator = A_3.GetEnumerator()
				While enumerator2.MoveNext()
					Dim dataRow2 As DataRow = enumerator2.Current
					IL_4FB:
					num2 = 71
					dataTable2.Rows.Add(dataTable2.NewRow())
					IL_511:
					num2 = 72
					dataTable2.Rows(dataTable2.Rows.Count - 1)(0) = RuntimeHelpers.GetObjectValue(dataRow2(array3(1)))
					IL_544:
					num2 = 73
				End While
				IL_550:
				num2 = 74
				CType(enumerator2, IDisposable).Dispose()
				IL_560:
				num2 = 75
				If Not A_0.StartsWith(":") Then
					GoTo IL_582
				End If
				IL_570:
				num2 = 76
				Dim flag2 As Boolean = True
				IL_576:
				num2 = 77
				A_0 = A_0.Substring(1)
				IL_582:
				num2 = 78
				obj = RuntimeHelpers.GetObjectValue(dataTable2.Compute(A_0, ""))
				GoTo IL_83F
				IL_59E:
				num2 = 80
				If A_1 Is Nothing Then
					GoTo IL_6B5
				End If
				IL_5A7:
				num2 = 81
				Dim array4 As String() = A_0.Split(New Char() { ","c })
				IL_5BD:
				num2 = 82
				If Not A_1.Table.DataSet.Tables.Contains(array4(0)) OrElse array4.Length < 2 Then
					GoTo IL_83F
				End If
				IL_5E8:
				num2 = 83
				text8 = Oo00.oo0o.O0O_0__.(A_1, array4(0))
				IL_5F7:
				num2 = 84
				If array4.Length <> 3 Then
					GoTo IL_60A
				End If
				IL_601:
				num2 = 85
				text7 = array4(2)
				IL_60A:
				num2 = 86
				If Operators.CompareString(text8, "", True) <= 0 Then
					GoTo IL_83F
				End If
				IL_620:
				num2 = 87
				If Operators.CompareString(text7, "", True) <= 0 Then
					GoTo IL_644
				End If
				IL_633:
				num2 = 88
				text7 += " And "
				IL_644:
				num2 = 89
				text7 += text8
				IL_652:
				num2 = 90
				Dim text9 As String = array4(1).Trim()
				IL_660:
				num2 = 91
				If Not text9.StartsWith(":") Then
					GoTo IL_684
				End If
				IL_671:
				num2 = 92
				flag2 = True
				IL_677:
				num2 = 93
				text9 = text9.Substring(1)
				IL_684:
				num2 = 94
				obj = RuntimeHelpers.GetObjectValue(A_1.Table.DataSet.Tables(array4(0)).Compute(text9, text7))
				GoTo IL_83F
				IL_6B5:
				num2 = 96
				If Me.OOO0_O0.O. Is Nothing Then
					GoTo IL_83F
				End If
				IL_6C3:
				num2 = 97
				If Me.OOO0_O0.O..Count <= 0 Then
					GoTo IL_83F
				End If
				IL_6D7:
				num2 = 98
				Dim array5 As String() = A_0.Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_6F3:
				num2 = 99
				array5(1) = array5(1).Trim(New Char() { "["c, "]"c })
				IL_713:
				num2 = 100
				If array5.Length <> 2 OrElse Not Me.OOO0_O0.O.(0).Table.Columns.Contains(array5(1)) Then
					GoTo IL_83F
				End If
				IL_744:
				num2 = 101
				Dim dataTable3 As DataTable = New DataTable()
				IL_74E:
				num2 = 102
				dataTable3.Columns.Add(array5(1), Me.OOO0_O0.O.(0).Table.Columns(array5(1)).DataType)
				IL_786:
				num2 = 103
				Dim enumerator3 As List(Of DataRow).Enumerator = Me.OOO0_O0.O..GetEnumerator()
				While enumerator3.MoveNext()
					Dim dataRow3 As DataRow = enumerator3.Current
					IL_7A1:
					num2 = 104
					dataTable3.Rows.Add(dataTable3.NewRow())
					IL_7B7:
					num2 = 105
					dataTable3.Rows(dataTable3.Rows.Count - 1)(0) = RuntimeHelpers.GetObjectValue(dataRow3(array5(1)))
					IL_7EA:
					num2 = 106
				End While
				IL_7F6:
				num2 = 107
				CType(enumerator3, IDisposable).Dispose()
				IL_806:
				num2 = 108
				If Not A_0.StartsWith(":") Then
					GoTo IL_828
				End If
				IL_816:
				num2 = 109
				flag2 = True
				IL_81C:
				num2 = 110
				A_0 = A_0.Substring(1)
				IL_828:
				num2 = 111
				obj = RuntimeHelpers.GetObjectValue(dataTable3.Compute(A_0, ""))
				IL_83F:
				num2 = 112
				If obj IsNot DBNull.Value AndAlso obj IsNot Nothing Then
					GoTo IL_85A
				End If
				IL_84F:
				num2 = 113
				obj = 0
				IL_85A:
				num2 = 114
				If Not flag2 Then
					GoTo IL_19B0
				End If
				IL_864:
				num2 = 115
				Dim text10 As String = ""
				IL_86E:
				num2 = 116
				O_O0OO.o.00O_O.(Conversion.Val(RuntimeHelpers.GetObjectValue(obj)), text10)
				IL_885:
				num2 = 117
				obj = text10
				GoTo IL_19B0
				IL_891:
				num2 = 119
				If(A_1 Is Nothing OrElse Not A_0.StartsWith("&")) AndAlso Not A_0.StartsWith("&&") Then
					GoTo IL_D3D
				End If
				IL_8B4:
				num2 = 120
				A_0 = A_0.Substring(1)
				IL_8C0:
				num2 = 121
				Dim array6 As String() = A_0.Split(New Char() { ","c })
				IL_8D6:
				num2 = 122
				Dim image As Image = Nothing
				IL_8DC:
				num2 = 123
				If Not array6(0).StartsWith("&") Then
					GoTo IL_913
				End If
				IL_8EF:
				num2 = 124
				array6(0) = array6(0).Substring(1)
				IL_900:
				num2 = 125
				image = OO_00oOO.GetImage(array6(0))
				GoTo IL_BC5
				IL_913:
				num2 = 127
				If array6(0).IndexOf("+") <= 0 Then
					GoTo IL_AC4
				End If
				IL_92A:
				num2 = 128
				Dim num3 As Integer
				If Not Integer.TryParse(array6(0).Substring(array6(0).IndexOf("+") + 1), num3) Then
					GoTo IL_BC5
				End If
				IL_955:
				num2 = 129
				array6(0) = array6(0).Substring(0, array6(0).IndexOf("+"))
				IL_977:
				num2 = 130
				If array6(0).IndexOf("&") <= 0 Then
					GoTo IL_9D7
				End If
				IL_98E:
				num2 = 131
				Dim num4 As Integer
				Integer.TryParse(array6(0).Substring(array6(0).IndexOf("&") + 1), num4)
				IL_9B5:
				num2 = 132
				array6(0) = array6(0).Substring(0, array6(0).IndexOf("&"))
				IL_9D7:
				num2 = 133
				If A_2 + num3 > A_4.Count - 1 Then
					GoTo IL_BC5
				End If
				IL_9EF:
				num2 = 134
				If Not Me.OOO0_O0.O..o__0_.oO.(A_1, A_4(A_2 + num3)) Then
					GoTo IL_BC5
				End If
				IL_A11:
				num2 = 135
				If Not A_1.Table.Columns.Contains(array6(0)) Then
					GoTo IL_BC5
				End If
				IL_A30:
				num2 = 136
				Dim array7 As String() = A_4(A_2 + num3)(array6(0)).ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_A67:
				num2 = 137
				If array7.Length - 1 < num4 Then
					GoTo IL_BC5
				End If
				IL_A7A:
				num2 = 138
				Dim remoteImageFile As String = Ooo_O.GetRemoteImageFile(array7(num4), Me.oO.o_0o__.(A_1.Table.TableName).DataCols(array6(0)))
				IL_AB0:
				num2 = 139
				image = OO_00oOO.GetImage(remoteImageFile)
				GoTo IL_BC5
				IL_AC4:
				num2 = 141
				If array6(0).IndexOf("&") <= 0 Then
					GoTo IL_B24
				End If
				IL_ADB:
				num2 = 142
				Integer.TryParse(array6(0).Substring(array6(0).IndexOf("&") + 1), num4)
				IL_B02:
				num2 = 143
				array6(0) = array6(0).Substring(0, array6(0).IndexOf("&"))
				IL_B24:
				num2 = 144
				If Not A_1.Table.Columns.Contains(array6(0)) Then
					GoTo IL_BC5
				End If
				IL_B43:
				num2 = 145
				Dim array8 As String() = A_1(array6(0)).ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_B70:
				num2 = 146
				If array8.Length - 1 < num4 Then
					GoTo IL_BC5
				End If
				IL_B80:
				num2 = 147
				Dim remoteImageFile2 As String = Ooo_O.GetRemoteImageFile(array8(num4), Me.oO.o_0o__.(A_1.Table.TableName).DataCols(array6(0)))
				IL_BB6:
				num2 = 148
				image = OO_00oOO.GetImage(remoteImageFile2)
				IL_BC5:
				num2 = 149
				If image IsNot Nothing Then
					GoTo IL_BDC
				End If
				IL_BCF:
				num2 = 150
				result = Nothing
				GoTo IL_19B9
				IL_BDC:
				num2 = 151
				If array6.Length <> 1 Then
					GoTo IL_BF8
				End If
				IL_BE9:
				num2 = 152
				obj = image
				GoTo IL_19B0
				IL_BF8:
				num2 = 154
				If array6.Length <> 3 Then
					GoTo IL_C4E
				End If
				IL_C05:
				num2 = 155
				Dim a_ As Integer
				If Not Integer.TryParse(array6(1), a_) Then
					GoTo IL_19B0
				End If
				IL_C1B:
				num2 = 156
				Dim a_2 As Integer
				If Not Integer.TryParse(array6(2), a_2) Then
					GoTo IL_19B0
				End If
				IL_C31:
				num2 = 157
				obj = New Picture(image, a_, a_2).o0_.O_o.
				GoTo IL_19B0
				IL_C4E:
				num2 = 159
				If array6.Length <> 5 Then
					GoTo IL_19B0
				End If
				IL_C5E:
				num2 = 160
				Dim a_3 As Integer
				If Not Integer.TryParse(array6(1), a_3) Then
					GoTo IL_19B0
				End If
				IL_C74:
				num2 = 161
				Dim a_4 As Integer
				If Not Integer.TryParse(array6(2), a_4) Then
					GoTo IL_19B0
				End If
				IL_C8A:
				num2 = 162
				Dim num5 As Integer
				If Not Integer.TryParse(array6(3), num5) Then
					GoTo IL_19B0
				End If
				IL_CA0:
				num2 = 163
				Dim num6 As Integer
				If Not Integer.TryParse(array6(4), num6) Then
					GoTo IL_19B0
				End If
				IL_CB6:
				num2 = 164
				If num6 <> -1 OrElse num5 <= 0 Then
					GoTo IL_CE9
				End If
				IL_CC6:
				num2 = 165
				num6 = CInt(Math.Round(CDbl(image.Height) / CDbl(image.Width) * CDbl(num5)))
				IL_CE9:
				num2 = 166
				If num5 <> -1 OrElse num6 <= 0 Then
					GoTo IL_D1C
				End If
				IL_CF9:
				num2 = 167
				num5 = CInt(Math.Round(CDbl(image.Width) / CDbl(image.Height) * CDbl(num6)))
				IL_D1C:
				num2 = 168
				obj = New Picture(image, a_3, a_4, num5, num6).o0_.O_o.
				GoTo IL_19B0
				IL_D3D:
				num2 = 170
				If Not A_0.StartsWith("@") OrElse A_0.IndexOf(",") <= 0 Then
					GoTo IL_11F6
				End If
				IL_D64:
				num2 = 171
				Dim array9 As String() = A_0.Split(New Char() { ","c })
				IL_D7D:
				num2 = 172
				Dim text11 As String = array9(0).Trim().Substring(1)
				IL_D94:
				num2 = 173
				Dim text12 As String = array9(1).Trim()
				IL_DA5:
				num2 = 174
				Dim num7 As Integer = -1
				IL_DAE:
				num2 = 175
				Dim text13 As String = Nothing
				IL_DB7:
				num2 = 176
				Dim obj2 As Object = Nothing
				IL_DC0:
				num2 = 177
				If Not text12.StartsWith("&") Then
					GoTo IL_E43
				End If
				IL_DD4:
				num2 = 178
				Dim flag3 As Boolean = True
				IL_DDD:
				num2 = 179
				text12 = text12.Substring(1)
				IL_DED:
				num2 = 180
				If text12.IndexOf("&") <= 0 Then
					GoTo IL_E70
				End If
				IL_E02:
				num2 = 181
				Dim num8 As Integer
				Integer.TryParse(text12.Substring(text12.IndexOf("&") + 1), num8)
				IL_E25:
				num2 = 182
				text12 = text12.Substring(0, text12.IndexOf("&"))
				GoTo IL_E70
				IL_E43:
				num2 = 184
				If Not text12.StartsWith(":") Then
					GoTo IL_E70
				End If
				IL_E57:
				num2 = 185
				Dim flag4 As Boolean = True
				IL_E60:
				num2 = 186
				text12 = text12.Substring(1)
				IL_E70:
				num2 = 187
				If array9.Length < 3 Then
					GoTo IL_E99
				End If
				IL_E7D:
				num2 = 188
				If Integer.TryParse(array9(2), num7) Then
					GoTo IL_E99
				End If
				IL_E90:
				num2 = 189
				num7 = -1
				IL_E99:
				num2 = 190
				If Not OO_00oOO.Tables.get_Contains(text11) OrElse Not OO_00oOO.Tables(text11).Cols.Contains(text12) Then
					GoTo IL_FEB
				End If
				IL_ECD:
				num2 = 191
				If num7 <> -1 Then
					GoTo IL_F41
				End If
				IL_ED8:
				num2 = 192
				If OO_00oOO.Tables(text11).Current Is Nothing Then
					GoTo IL_FEB
				End If
				IL_EF4:
				num2 = 193
				If OO_00oOO.Tables(text11).Current.get_IsNull(text12) Then
					GoTo IL_FEB
				End If
				IL_F17:
				num2 = 194
				obj2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables(text11).Current(text12))
				GoTo IL_FEB
				IL_F41:
				num2 = 196
				If Not array9(2).StartsWith("+") Then
					GoTo IL_F73
				End If
				IL_F57:
				num2 = 197
				num7 = OO_00oOO.Tables(text11).Position + num7
				IL_F73:
				num2 = 198
				If num7 < 0 OrElse num7 >= OO_00oOO.Tables(text11).Rows.Count Then
					GoTo IL_FEB
				End If
				IL_F98:
				num2 = 199
				If OO_00oOO.Tables(text11).Rows(num7).get_IsNull(text12) Then
					GoTo IL_FEB
				End If
				IL_FBF:
				num2 = 200
				obj2 = RuntimeHelpers.GetObjectValue(OO_00oOO.Tables(text11).Rows(num7)(text12))
				IL_FEB:
				num2 = 201
				If obj2 Is Nothing Then
					GoTo IL_19B0
				End If
				IL_FF8:
				num2 = 202
				If flag3 Then
					GoTo IL_105E
				End If
				IL_1002:
				num2 = 203
				obj = RuntimeHelpers.GetObjectValue(obj2)
				IL_1011:
				num2 = 204
				If Not flag4 Then
					GoTo IL_19B0
				End If
				IL_101E:
				num2 = 205
				Dim text14 As String = ""
				IL_102B:
				num2 = 206
				Dim a_5 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(obj))
				IL_103F:
				num2 = 207
				O_O0OO.o.00O_O.(a_5, text14)
				IL_104F:
				num2 = 208
				obj = text14
				GoTo IL_19B0
				IL_105E:
				num2 = 210
				text13 = obj2.ToString()
				IL_106D:
				num2 = 211
				Dim image2 As Image = Nothing
				IL_1076:
				num2 = 212
				Dim array10 As String() = text13.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_1096:
				num2 = 213
				If array10.Length - 1 < num8 Then
					GoTo IL_10E4
				End If
				IL_10A6:
				num2 = 214
				Dim remoteImageFile3 As String = Ooo_O.GetRemoteImageFile(array10(num8), OO_00oOO.Tables(text11).DataTable.DataCols(text12))
				IL_10D5:
				num2 = 215
				image2 = OO_00oOO.GetImage(remoteImageFile3)
				IL_10E4:
				num2 = 216
				If image2 IsNot Nothing Then
					GoTo IL_10FB
				End If
				IL_10EE:
				num2 = 217
				result = Nothing
				GoTo IL_19B9
				IL_10FB:
				num2 = 218
				If array9.Length > 3 Then
					GoTo IL_1117
				End If
				IL_1108:
				num2 = 219
				obj = image2
				GoTo IL_19B0
				IL_1117:
				num2 = 221
				If array9.Length <> 5 Then
					GoTo IL_116D
				End If
				IL_1124:
				num2 = 222
				Dim a_6 As Integer
				If Not Integer.TryParse(array9(3), a_6) Then
					GoTo IL_19B0
				End If
				IL_113A:
				num2 = 223
				Dim a_7 As Integer
				If Not Integer.TryParse(array9(4), a_7) Then
					GoTo IL_19B0
				End If
				IL_1150:
				num2 = 224
				obj = New Picture(image2, a_6, a_7).o0_.O_o.
				GoTo IL_19B0
				IL_116D:
				num2 = 226
				If array9.Length <> 7 Then
					GoTo IL_19B0
				End If
				IL_117D:
				num2 = 227
				Dim a_8 As Integer
				If Not Integer.TryParse(array9(3), a_8) Then
					GoTo IL_19B0
				End If
				IL_1193:
				num2 = 228
				Dim a_9 As Integer
				If Not Integer.TryParse(array9(4), a_9) Then
					GoTo IL_19B0
				End If
				IL_11A9:
				num2 = 229
				Dim a_10 As Integer
				If Not Integer.TryParse(array9(5), a_10) Then
					GoTo IL_19B0
				End If
				IL_11BF:
				num2 = 230
				Dim a_11 As Integer
				If Not Integer.TryParse(array9(6), a_11) Then
					GoTo IL_19B0
				End If
				IL_11D5:
				num2 = 231
				obj = New Picture(image2, a_8, a_9, a_10, a_11).o0_.O_o.
				GoTo IL_19B0
				IL_11F6:
				num2 = 233
				If A_1 Is Nothing OrElse A_0.IndexOf(",") <= 0 Then
					GoTo IL_17D1
				End If
				IL_1213:
				num2 = 234
				Dim array11 As String() = A_0.Split(New Char() { ","c })
				IL_122C:
				num2 = 235
				Dim text15 As String = array11(1).Trim()
				IL_123D:
				num2 = 236
				Dim array12 As String() = array11(0).Split(New Char() { "."c })
				IL_1259:
				num2 = 237
				Dim dataRow4 As DataRow = A_1
				IL_1262:
				num2 = 238
				If Not text15.StartsWith("&") Then
					GoTo IL_1291
				End If
				IL_1276:
				num2 = 239
				text15 = text15.Substring(1)
				IL_1286:
				num2 = 240
				Dim flag5 As Boolean = True
				GoTo IL_12BE
				IL_1291:
				num2 = 242
				If Not text15.StartsWith(":") Then
					GoTo IL_12BE
				End If
				IL_12A5:
				num2 = 243
				text15 = text15.Substring(1)
				IL_12B5:
				num2 = 244
				Dim flag6 As Boolean = True
				IL_12BE:
				num2 = 245
				Dim num9 As Integer = array12.Length - 1
				Dim flag7 As Boolean
				For i As Integer = 0 To num9
					IL_12D4:
					num2 = 246
					Dim right As String = array12(i).Trim()
					IL_12E6:
					num2 = 247
					flag7 = False
					IL_12EF:
					num2 = 248
					Dim dataSet As DataSet = dataRow4.Table.DataSet
					IL_1303:
					num2 = 249
					Dim enumerator4 As IEnumerator = dataSet.Relations.GetEnumerator()
					While enumerator4.MoveNext()
						Dim obj3 As Object = enumerator4.Current
						Dim dataRelation As DataRelation = CType(obj3, DataRelation)
						IL_1327:
						num2 = 250
						If Operators.CompareString(dataRelation.ParentTable.TableName, right, True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, dataRow4.Table.TableName, True) = 0 Then
							IL_1363:
							num2 = 251
							flag7 = True
							IL_136C:
							num2 = 252
							dataRow4 = dataRow4.GetParentRow(dataRelation.RelationName)
							IL_1382:
							num2 = 253
							If dataRow4 Is Nothing Then
								Exit While
							End If
						End If
						IL_138C:
						num2 = 255
					End While
					IL_139E:
					num2 = 256
					If TypeOf enumerator4 Is IDisposable Then
						TryCast(enumerator4, IDisposable).Dispose()
					End If
					IL_13B9:
					num2 = 257
					If Not flag7 Then
						Exit For
					End If
					IL_13C3:
					num2 = 259
				Next
				IL_13D8:
				num2 = 260
				If Not flag7 OrElse dataRow4 Is Nothing OrElse dataRow4 Is A_1 Then
					GoTo IL_19B0
				End If
				IL_13F4:
				num2 = 261
				If text15.IndexOf("&") <= 0 Then
					GoTo IL_1448
				End If
				IL_1409:
				num2 = 262
				Dim num10 As Integer
				Integer.TryParse(text15.Substring(text15.IndexOf("&") + 1), num10)
				IL_142C:
				num2 = 263
				text15 = text15.Substring(0, text15.IndexOf("&"))
				IL_1448:
				num2 = 264
				If dataRow4.Table.Columns.Contains(text15) Then
					GoTo IL_1470
				End If
				IL_1463:
				num2 = 265
				result = Nothing
				GoTo IL_19B9
				IL_1470:
				num2 = 266
				If Not flag5 Then
					GoTo IL_175A
				End If
				IL_147D:
				num2 = 267
				Dim image3 As Image = Nothing
				IL_1486:
				num2 = 268
				Dim array13 As String() = dataRow4(text15).ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_14B2:
				num2 = 269
				If array13.Length - 1 < num10 Then
					GoTo IL_15E2
				End If
				IL_14C5:
				num2 = 270
				Dim imageFile As String = ""
				IL_14D2:
				num2 = 271
				If Not Me.oO.o_0o__..Contains(dataRow4.Table.TableName) Then
					GoTo IL_152B
				End If
				IL_14F1:
				num2 = 272
				imageFile = Ooo_O.GetRemoteImageFile(array13(num10), Me.oO.o_0o__.(dataRow4.Table.TableName).DataCols(text15))
				GoTo IL_15D3
				IL_152B:
				num2 = 274
				If Not Me.DataTables.Contains(dataRow4.Table.TableName) Then
					GoTo IL_1581
				End If
				IL_154A:
				num2 = 275
				imageFile = Ooo_O.GetRemoteImageFile(array13(num10), Me.DataTables(dataRow4.Table.TableName).DataCols(text15))
				GoTo IL_15D3
				IL_1581:
				num2 = 277
				If Not OO_00oOO.DataTables.Contains(dataRow4.Table.TableName) Then
					GoTo IL_15D3
				End If
				IL_159F:
				num2 = 278
				imageFile = Ooo_O.GetRemoteImageFile(array13(num10), OO_00oOO.DataTables(dataRow4.Table.TableName).DataCols(text15))
				IL_15D3:
				num2 = 279
				image3 = OO_00oOO.GetImage(imageFile)
				IL_15E2:
				num2 = 280
				If image3 IsNot Nothing Then
					GoTo IL_15F9
				End If
				IL_15EC:
				num2 = 281
				result = Nothing
				GoTo IL_19B9
				IL_15F9:
				num2 = 282
				If array11.Length <> 2 Then
					GoTo IL_1615
				End If
				IL_1606:
				num2 = 283
				obj = image3
				GoTo IL_19B0
				IL_1615:
				num2 = 285
				If array11.Length <> 4 Then
					GoTo IL_166B
				End If
				IL_1622:
				num2 = 286
				Dim a_12 As Integer
				If Not Integer.TryParse(array11(2), a_12) Then
					GoTo IL_19B0
				End If
				IL_1638:
				num2 = 287
				Dim a_13 As Integer
				If Not Integer.TryParse(array11(3), a_13) Then
					GoTo IL_19B0
				End If
				IL_164E:
				num2 = 288
				obj = New Picture(image3, a_12, a_13).o0_.O_o.
				GoTo IL_19B0
				IL_166B:
				num2 = 290
				If array11.Length <> 6 Then
					GoTo IL_19B0
				End If
				IL_167B:
				num2 = 291
				Dim a_14 As Integer
				If Not Integer.TryParse(array11(2), a_14) Then
					GoTo IL_19B0
				End If
				IL_1691:
				num2 = 292
				Dim a_15 As Integer
				If Not Integer.TryParse(array11(3), a_15) Then
					GoTo IL_19B0
				End If
				IL_16A7:
				num2 = 293
				Dim num11 As Integer
				If Not Integer.TryParse(array11(4), num11) Then
					GoTo IL_19B0
				End If
				IL_16BD:
				num2 = 294
				Dim num12 As Integer
				If Not Integer.TryParse(array11(5), num12) Then
					GoTo IL_19B0
				End If
				IL_16D3:
				num2 = 295
				If num12 <> -1 OrElse num11 <= 0 Then
					GoTo IL_1706
				End If
				IL_16E3:
				num2 = 296
				num12 = CInt(Math.Round(CDbl(image3.Height) / CDbl(image3.Width) * CDbl(num11)))
				IL_1706:
				num2 = 297
				If num11 <> -1 OrElse num12 <= 0 Then
					GoTo IL_1739
				End If
				IL_1716:
				num2 = 298
				num11 = CInt(Math.Round(CDbl(image3.Width) / CDbl(image3.Height) * CDbl(num12)))
				IL_1739:
				num2 = 299
				obj = New Picture(image3, a_14, a_15, num11, num12).o0_.O_o.
				GoTo IL_19B0
				IL_175A:
				num2 = 301
				If dataRow4.IsNull(text15) Then
					GoTo IL_19B0
				End If
				IL_176E:
				num2 = 302
				obj = RuntimeHelpers.GetObjectValue(dataRow4(text15))
				IL_1784:
				num2 = 303
				If Not flag6 Then
					GoTo IL_19B0
				End If
				IL_1791:
				num2 = 304
				Dim text16 As String = ""
				IL_179E:
				num2 = 305
				Dim a_16 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(obj))
				IL_17B2:
				num2 = 306
				O_O0OO.o.00O_O.(a_16, text16)
				IL_17C2:
				num2 = 307
				obj = text16
				GoTo IL_19B0
				IL_17D1:
				num2 = 309
				If A_1 Is Nothing OrElse Not A_0.StartsWith(":") Then
					GoTo IL_1883
				End If
				IL_17ED:
				num2 = 310
				A_0 = A_0.Substring(1).Trim()
				IL_1801:
				num2 = 311
				If Not A_1.Table.Columns.Contains(A_0) Then
					GoTo IL_19B0
				End If
				IL_181D:
				num2 = 312
				If A_1.IsNull(A_0) Then
					GoTo IL_19B0
				End If
				IL_182F:
				num2 = 313
				obj = RuntimeHelpers.GetObjectValue(A_1(A_0))
				IL_1843:
				num2 = 314
				Dim text17 As String = ""
				IL_1850:
				num2 = 315
				Dim a_17 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(obj))
				IL_1864:
				num2 = 316
				O_O0OO.o.00O_O.(a_17, text17)
				IL_1874:
				num2 = 317
				obj = text17
				GoTo IL_19B0
				IL_1883:
				num2 = 319
				If A_1 Is Nothing Then
					GoTo IL_19B0
				End If
				IL_188F:
				num2 = 320
				If Not A_1.Table.Columns.Contains(A_0) Then
					GoTo IL_18D3
				End If
				IL_18A8:
				num2 = 321
				If A_1.IsNull(A_0) Then
					GoTo IL_19B0
				End If
				IL_18BA:
				num2 = 322
				obj = RuntimeHelpers.GetObjectValue(A_1(A_0))
				GoTo IL_19B0
				IL_18D3:
				num2 = 324
				If A_0.IndexOf("+") <= 0 Then
					GoTo IL_19B0
				End If
				IL_18EA:
				num2 = 325
				Dim num13 As Integer
				If Not Integer.TryParse(A_0.Substring(A_0.IndexOf("+") + 1), num13) Then
					GoTo IL_19B0
				End If
				IL_190F:
				num2 = 326
				If A_2 + num13 > A_4.Count - 1 Then
					GoTo IL_19B0
				End If
				IL_1927:
				num2 = 327
				If Not Me.OOO0_O0.O..o__0_.oO.(A_1, A_4(A_2 + num13)) Then
					GoTo IL_19B0
				End If
				IL_1946:
				num2 = 328
				A_0 = A_0.Substring(0, A_0.IndexOf("+"))
				IL_1960:
				num2 = 329
				If Not A_1.Table.Columns.Contains(A_0) Then
					GoTo IL_19B0
				End If
				IL_1979:
				num2 = 330
				If A_4(A_2 + num13).IsNull(A_0) Then
					GoTo IL_19B0
				End If
				IL_1992:
				num2 = 331
				obj = RuntimeHelpers.GetObjectValue(A_4(A_2 + num13)(A_0))
				IL_19B0:
				num2 = 332
				result = obj
				IL_19B9:
				GoTo IL_1F3F
				IL_19BE:
				Dim num14 As Integer = num15 + 1
				num15 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num14)
				IL_1F00:
				GoTo IL_1F34
				IL_1F02:
				num15 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1F12:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num15 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_1F02
			End Try
			IL_1F34:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F3F:
			If num15 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06004FCB RID: 20427 RVA: 0x002156A8 File Offset: 0x002138A8
		Private Function <<EMPTY_NAME>>(A_0 As XLSheet) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				IL_09:
				num2 = 3
				Dim list As List(Of String) = New List(Of String)()
				IL_12:
				num2 = 4
				Me.OoO.o0..Clear()
				IL_1F:
				num2 = 5
				Me.O.o00O0___O..Clear()
				IL_2C:
				num2 = 6
				Me.O_0_o.Oo_oo0_O..Clear()
				IL_39:
				num2 = 7
				Me.O_ooo.o0..Clear()
				IL_46:
				num2 = 8
				Me.Ooo.00_O0_0_..Clear()
				IL_53:
				num2 = 9
				Me.o._0_Oo0o..Clear()
				IL_61:
				num2 = 10
				Me.OOO0_O0.O..Clear()
				IL_6F:
				num2 = 11
				Me.O_0_o.Oo_oo0_O..Clear()
				IL_7D:
				num2 = 12
				Me.OOO0_O0.O..Clear()
				IL_8B:
				num2 = 13
				Me.oOo_o0.o_0..Clear()
				IL_99:
				num2 = 14
				Me.oO.o_0o__..Clear()
				IL_A7:
				num2 = 15
				Me.oOo_o0.o_0. = A_0.Rows.Count - 1
				IL_BD:
				num2 = 16
				Me.OOoOOo0.000. = A_0.Columns.Count - 1
				IL_D3:
				num2 = 17
				Dim num3 As Integer = A_0.Columns.Count - 1
				For i As Integer = 2 To num3
					IL_EA:
					num2 = 18
					Dim text As String = A_0(0, i).Text.Trim(New Char() { " "c, vbCr, vbLf })
					IL_113:
					num2 = 19
					If Operators.CompareString(text, "<End>", True) = 0 Then
						IL_125:
						num2 = 20
						Me.OOoOOo0.000. = i - 1
						Exit For
					End If
					IL_134:
					num2 = 22
				Next
				IL_143:
				num2 = 23
				Me.OOoOOo0.000. = ""
				IL_151:
				num2 = 24
				Dim num4 As Integer = A_0.Rows.Count - 1
				For j As Integer = 0 To num4
					IL_16B:
					num2 = 25
					Dim text As String = A_0(j, 0).Text.Trim(New Char() { " "c, vbCr, vbLf })
					IL_194:
					num2 = 26
					If Operators.CompareString(text, "", True) > 0 Then
						IL_1AA:
						num2 = 27
						If LikeOperator.LikeString(text, "<*>", CompareMethod.Text) AndAlso text.Length >= 3 Then
							IL_1CC:
							num2 = 28
							text = text.Substring(1, text.Length - 2)
							IL_1E2:
							num2 = 29
							Dim array As String() = text.Split(New Char() { ","c })
							IL_1F9:
							num2 = 30
							If Me.oO.o_0o__..Contains(array(0)) OrElse OO_00oOO.Tables.get_Contains(array(0)) Then
								IL_220:
								num2 = 31
								If Not Me.OoO.o0..ContainsKey(array(0)) Then
									IL_237:
									num2 = 32
									Me.OoO.o0..Add(array(0), j)
									IL_24B:
									num2 = 33
									If Me.OOoOOo0.000. < A_0.Columns.Count - 1 Then
										IL_266:
										num2 = 34
										Dim text2 As String = A_0(j, Me.OOoOOo0.000. + 1).Text.Trim(New Char() { " "c, vbLf, vbCr })
										IL_296:
										num2 = 35
										If Operators.CompareString(text2, "", True) > 0 Then
											IL_2A9:
											num2 = 36
											If Not Me.O_0_o.Oo_oo0_O..ContainsKey(array(0)) Then
												IL_2BD:
												num2 = 37
												Me.O_0_o.Oo_oo0_O..Add(array(0), text2.Trim(New Char() { "<"c, ">"c }))
											End If
										End If
									End If
									IL_2E6:
									num2 = 38
									Dim num5 As Integer = array.Length - 1
									For k As Integer = 1 To num5
										IL_2F9:
										num2 = 39
										Dim value As Integer
										If Integer.TryParse(array(k), value) Then
											IL_30A:
											num2 = 40
											If Not Me.Ooo.00_O0_0_..ContainsKey(array(0)) Then
												IL_321:
												num2 = 41
												Me.Ooo.00_O0_0_..Add(array(0), value)
											End If
										Else
											IL_33A:
											num2 = 43
											If array(k).StartsWith("(") AndAlso array(k).EndsWith(")") Then
												IL_365:
												num2 = 44
												array(k) = array(k).Substring(1, array(k).Length - 2)
												IL_384:
												num2 = 45
												Dim array2 As String() = array(k).Split(New Char() { "|"c })
												IL_39E:
												num2 = 46
												If Integer.TryParse(array2(0), value) Then
													IL_3AE:
													num2 = 47
													If Not Me.Ooo.00_O0_0_..ContainsKey(array(0)) Then
														IL_3C2:
														num2 = 48
														Me.Ooo.00_O0_0_..Add(array(0), value)
													End If
												End If
												IL_3D6:
												num2 = 49
												If array2.Length = 2 Then
													IL_3E3:
													num2 = 50
													If Integer.TryParse(array2(1), value) Then
														IL_3F6:
														num2 = 51
														If Not Me.O_0_o.Oo_oo0_O..ContainsKey(array(0)) Then
															IL_40D:
															num2 = 52
															Me.O_0_o.Oo_oo0_O..Add(array(0), value)
														End If
													End If
												End If
											Else
												IL_426:
												num2 = 54
												If(array(k).StartsWith("{") AndAlso array(k).EndsWith("}")) OrElse array(k).StartsWith("@") Then
													IL_45C:
													num2 = 55
													array(k) = array(k).Trim(New Char() { "{"c, "}"c, "@"c })
													IL_47F:
													num2 = 56
													If Integer.TryParse(array(k), value) Then
														IL_490:
														num2 = 57
														If Not Me.o._0_Oo0o..ContainsKey(array(0)) Then
															IL_4A4:
															num2 = 58
															Me.o._0_Oo0o..Add(array(0), value)
														End If
													End If
												Else
													IL_4BA:
													num2 = 60
													If Not Me.O_ooo.o0..ContainsKey(array(0)) Then
														IL_4CE:
														num2 = 61
														Me.O_ooo.o0..Add(array(0), array(1).Replace("|", ","))
													End If
												End If
											End If
										End If
										IL_4F3:
										num2 = 62
									Next
									IL_505:
									num2 = 63
									If Operators.CompareString(Me.OOoOOo0.000., "", True) = 0 Then
										IL_51B:
										num2 = 64
										Me.OOoOOo0.000. = array(0)
									End If
									IL_528:
									num2 = 65
									list.Add(array(0))
									GoTo IL_84A
								End If
								IL_53B:
								num2 = 67
								If Not Me.O.o00O0___O..ContainsKey(array(0)) Then
									IL_54F:
									num2 = 68
									Me.O.o00O0___O..Add(array(0), j)
									GoTo IL_84A
								End If
								IL_568:
								num2 = 70
								MessageBox.Show("细节区定义错误，每个表只能在报表中有一个细节区！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								IL_57E:
								num2 = 71
								result = False
							Else
								IL_588:
								num2 = 73
								If Operators.CompareString(array(0), "HeaderRow", True) = 0 OrElse Operators.CompareString(array(0), "FooterRow", True) = 0 Then
									IL_5AD:
									num2 = 74
									If Not Me.OoO.o0..ContainsKey(array(0).ToLower()) Then
										IL_5C6:
										num2 = 75
										Me.OoO.o0..Add(array(0).ToLower(), j)
										GoTo IL_84A
									End If
									IL_5E4:
									num2 = 77
									If Not Me.O.o00O0___O..ContainsKey(array(0).ToLower()) Then
										IL_600:
										num2 = 78
										Me.O.o00O0___O..Add(array(0).ToLower(), j)
										GoTo IL_84A
									End If
									GoTo IL_84A
								Else
									IL_61E:
									num2 = 80
									If Operators.CompareString(array(0), "GroupHeader", True) = 0 Then
										IL_635:
										num2 = 81
										If array.Length < 3 Then
											GoTo IL_84A
										End If
										IL_642:
										num2 = 82
										Dim oo_0o As Book.Oo_0o = Me.OOO0_O0.O..o0.o0O__0oo.(array(1), array(2))
										IL_65A:
										num2 = 83
										If oo_0o Is Nothing Then
											IL_661:
											num2 = 84
											oo_0o = Me.OOO0_O0.O..O_0o_.O_0.(array(1), array(2))
											IL_679:
											num2 = 85
											oo_0o.O_0o_.O_0. = j
										Else
											IL_687:
											num2 = 87
											oo_0o.oooo.0O__oo. = j
										End If
										IL_693:
										num2 = 88
										If array.Length <> 4 Then
											GoTo IL_84A
										End If
										IL_6A0:
										num2 = 89
										If Operators.CompareString(array(3), "1", True) = 0 Then
											IL_6B7:
											num2 = 90
											oo_0o.oooo.0O__oo. = True
											GoTo IL_84A
										End If
										GoTo IL_84A
									Else
										IL_6C7:
										num2 = 92
										If Operators.CompareString(array(0), "GroupFooter", True) = 0 Then
											IL_6DE:
											num2 = 93
											If array.Length < 3 Then
												GoTo IL_84A
											End If
											IL_6EB:
											num2 = 94
											Dim oo_0o2 As Book.Oo_0o = Me.oOo_o0.o_0..o0.o0O__0oo.(array(1), array(2))
											IL_703:
											num2 = 95
											If oo_0o2 Is Nothing Then
												IL_70A:
												num2 = 96
												oo_0o2 = Me.oOo_o0.o_0..O_0o_.O_0.(array(1), array(2))
												IL_722:
												num2 = 97
												oo_0o2.O_0o_.O_0. = j
											Else
												IL_730:
												num2 = 99
												oo_0o2.oooo.0O__oo. = j
											End If
											IL_73C:
											num2 = 100
											If array.Length <> 4 Then
												GoTo IL_84A
											End If
											IL_749:
											num2 = 101
											If Operators.CompareString(array(3), "1", True) = 0 Then
												IL_760:
												num2 = 102
												oo_0o2.oO.o_0o__. = True
												GoTo IL_84A
											End If
											GoTo IL_84A
										Else
											IL_770:
											num2 = 104
											If Operators.CompareString(array(0), "End", True) = 0 Then
												IL_787:
												num2 = 105
												Me.oOo_o0.o_0. = j - 1
												IL_794:
												num2 = 106
												Dim num6 As Integer = A_0.Columns.Count - 2
												For l As Integer = 1 To num6
													IL_7AB:
													num2 = 107
													text = A_0(j, l).Text.Trim(New Char() { " "c, vbCr, vbLf })
													IL_7D5:
													num2 = 108
													If Operators.CompareString(text, "<M>", True) = 0 Then
														IL_7E7:
														num2 = 109
														Me.OOO0_O0.O..Add(l)
													Else
														IL_7F9:
														num2 = 111
														If Operators.CompareString(text, "<End>", True) = 0 Then
															Exit For
														End If
													End If
													IL_80B:
													num2 = 113
												Next
												GoTo IL_84A
											End If
											IL_81C:
											num2 = 115
											MessageBox.Show("细节区定义错误，表""" + array(0) + """不存在，或已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											IL_840:
											num2 = 116
											result = False
										End If
									End If
								End If
							End If
							IL_CC7:
							GoTo IL_FC1
						End If
					End If
					IL_84A:
					num2 = 117
				Next
				IL_85C:
				num2 = 118
				If Me.oOo_o0.o_0. <> 0 Then
					GoTo IL_87D
				End If
				IL_867:
				num2 = 119
				Me.oOo_o0.o_0. = A_0.Rows.Count - 1
				IL_87D:
				num2 = 120
				If Me.OOoOOo0.000. <> 0 Then
					GoTo IL_89E
				End If
				IL_888:
				num2 = 121
				Me.OOoOOo0.000. = A_0.Columns.Count - 1
				IL_89E:
				num2 = 122
				Dim enumerator As Dictionary(Of String, Integer).KeyCollection.Enumerator = Me.O.o00O0___O..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim key As String = enumerator.Current
					IL_8BE:
					num2 = 123
					Me.oOo_o0.o_0. = Math.Max(Me.oOo_o0.o_0., Me.O.o00O0___O.(key))
					IL_8DF:
					num2 = 124
				End While
				IL_8EB:
				num2 = 125
				CType(enumerator, IDisposable).Dispose()
				IL_8FB:
				num2 = 126
				Dim enumerator2 As Dictionary(Of String, Integer).KeyCollection.Enumerator = Me.OoO.o0..Keys.GetEnumerator()
				While enumerator2.MoveNext()
					Dim key2 As String = enumerator2.Current
					IL_91B:
					num2 = 127
					Me.oOo_o0.o_0. = Math.Max(Me.oOo_o0.o_0., Me.OoO.o0.(key2))
					IL_93C:
					num2 = 128
				End While
				IL_94B:
				num2 = 129
				CType(enumerator2, IDisposable).Dispose()
				IL_95E:
				num2 = 130
				Dim enumerator3 As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator3.MoveNext()
					Dim text3 As String = enumerator3.Current
					IL_978:
					num2 = 131
					If Not Me.oO.o_0o__..Contains(text3) Then
						IL_98D:
						num2 = 132
						If OO_00oOO.Tables.get_Contains(text3) Then
							IL_9A1:
							num2 = 133
							Me.oO.o_0o__..add(text3, OO_00oOO.Tables(text3).DataTable)
						End If
					End If
					IL_9C5:
					num2 = 134
				End While
				IL_9D4:
				num2 = 135
				CType(enumerator3, IDisposable).Dispose()
				IL_9E7:
				num2 = 136
				If list.Count <= 0 Then
					GoTo IL_C9B
				End If
				IL_9FA:
				num2 = 137
				Dim num7 As Integer = list.Count - 1
				For m As Integer = 1 To num7
					IL_A13:
					num2 = 138
					Dim flag As Boolean = False
					IL_A1C:
					num2 = 139
					Dim n As Integer = m - 1
					While n >= 0
						IL_A2D:
						num2 = 140
						Dim text4 As String = list(n)
						IL_A3E:
						num2 = 141
						Dim text5 As String = list(m)
						IL_A4F:
						num2 = 142
						If Me.O.o00O0___O..ContainsKey(text4) AndAlso Me.O.o00O0___O..ContainsKey(text5) AndAlso Me.OoO.o0.(text4) < Me.OoO.o0.(text5) AndAlso Me.O.o00O0___O.(text4) > Me.O.o00O0___O.(text5) Then
							IL_AB1:
							num2 = 143
							If Oo00.O____0O._0.(text4, text5, Me.oO.o_0o__.(text4).BaseTable.DataSet) Then
								IL_AD9:
								num2 = 144
								flag = True
								Exit While
							End If
							IL_AE7:
							num2 = 146
							If Me.o_0Oo.0___OO0_.(text4, text5) Then
								IL_AFC:
								num2 = 147
								result = True
								GoTo IL_CC7
							End If
							Exit While
						Else
							IL_B09:
							num2 = 150
							If Me.O.o00O0___O..ContainsKey(text4) AndAlso Not Me.O.o00O0___O..ContainsKey(text5) AndAlso Me.OoO.o0.(text4) < Me.OoO.o0.(text5) AndAlso Me.O.o00O0___O.(text4) > Me.OoO.o0.(text5) Then
								IL_B6B:
								num2 = 151
								If Oo00.O____0O._0.(text4, text5, Me.oO.o_0o__.(text4).BaseTable.DataSet) Then
									IL_B93:
									num2 = 152
									flag = True
									Exit While
								End If
								IL_BA1:
								num2 = 154
								If Me.o_0Oo.0___OO0_.(text4, text5) Then
									IL_BB6:
									num2 = 155
									result = True
									GoTo IL_CC7
								End If
								Exit While
							Else
								IL_BC3:
								num2 = 158
								If Me.O.o00O0___O..ContainsKey(text4) AndAlso Me.O.o00O0___O..ContainsKey(text5) AndAlso Me.OoO.o0.(text4) < Me.OoO.o0.(text5) AndAlso Me.O.o00O0___O.(text4) > Me.OoO.o0.(text5) Then
									IL_C1F:
									num2 = 159
									MessageBox.Show("细节区之间错位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									IL_C38:
									num2 = 160
									result = False
									GoTo IL_CC7
								End If
								IL_C45:
								num2 = 162
								n += -1
							End If
						End If
					End While
					IL_C59:
					num2 = 163
					If Not flag Then
						IL_C63:
						num2 = 164
						MessageBox.Show("子细节区必须嵌套在父表细节区之内。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						IL_C7C:
						num2 = 165
						result = False
						GoTo IL_CC7
					End If
					IL_C86:
					num2 = 166
				Next
				IL_C9B:
				num2 = 167
				Me.OOO0_O0.O..o__0_.oO.(A_0)
				IL_CAD:
				num2 = 168
				Me.oOo_o0.o_0..o__0_.oO.(A_0)
				IL_CBF:
				num2 = 169
				result = True
				GoTo IL_CC7
				IL_CCC:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_F82:
				GoTo IL_FB6
				IL_F84:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F94:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F84
			End Try
			IL_FB6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_FC1:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x170011F7 RID: 4599
		' (get) Token: 0x06004FCC RID: 20428 RVA: 0x0021669C File Offset: 0x0021489C
		' (set) Token: 0x06004FCD RID: 20429 RVA: 0x002166A9 File Offset: 0x002148A9
		Public Property DefaultFont As Font
			Get
				Return Me.oO.o_0o__..DefaultFont
			End Get
			Set(value As Font)
				Me.oO.o_0o__..DefaultFont = value
			End Set
		End Property

		' Token: 0x170011F8 RID: 4600
		' (get) Token: 0x06004FCE RID: 20430 RVA: 0x002166B7 File Offset: 0x002148B7
		Public ReadOnly Property Sheets As SheetCollection
			Get
				If Me.a Is Nothing Then
					Me.a = New SheetCollection(Me.oO.o_0o__..Sheets)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x170011F9 RID: 4601
		' (get) Token: 0x06004FCF RID: 20431 RVA: 0x002166DD File Offset: 0x002148DD
		' (set) Token: 0x06004FD0 RID: 20432 RVA: 0x002166EA File Offset: 0x002148EA
		Public Property KeepFormulas As Boolean
			Get
				Return Me.oO.o_0o__..KeepFormulas
			End Get
			Set(value As Boolean)
				Me.oO.o_0o__..KeepFormulas = value
			End Set
		End Property

		' Token: 0x06004FD1 RID: 20433 RVA: 0x002166F8 File Offset: 0x002148F8
		<oO0oooo("1151")>
		Public Function Save(FileName As String) As Boolean
			If Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(FileName), "", True) = 0 Then
				FileName = OO_00oOO.AttachPath + FileName
			End If
			If Not c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)) Then
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName))
			End If
			If c.OOOOO.o.().FileSystem.FileExists(FileName) Then
				Try
					c.OOOOO.o.().FileSystem.DeleteFile(FileName)
				Catch ex As Exception
					MessageBox.Show("文件""" + FileName + """已经被打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return False
				End Try
			End If
			If FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) Then
				Me.oO.o_0o__..Save(FileName, 2)
			Else
				Me.oO.o_0o__..Save(FileName, 0)
			End If
			Return True
		End Function

		' Token: 0x06004FD2 RID: 20434 RVA: 0x00216800 File Offset: 0x00214A00
		<oO0oooo("1146")>
		Public Function NewStyle() As Style
			Return New Style(New XLStyle(Me.oO.o_0o__.))
		End Function

		' Token: 0x06004FD3 RID: 20435 RVA: 0x00216814 File Offset: 0x00214A14
		<MethodImpl(MethodImplOptions.NoInlining)>
		Private Shared Function <<EMPTY_NAME>>() As Assembly
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "InValue", o0_O.O_0.ooo_00O_oo. })
			Dim result As Assembly
			If dataRow Is Nothing Then
				MessageBox.Show("无效配置文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				ProjectData.EndApp()
			Else
				result = o0_.Oo_0.OOo0oO0.(O00.oO_.0o_oo_0O_.(dataRow("Config").ToString(), "datatable", "datarow"), "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", False)
			End If
			Return result
		End Function

		' Token: 0x06004FD4 RID: 20436 RVA: 0x002168BC File Offset: 0x00214ABC
		Public Sub SaveToPdf(fileName As String)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(Me.o_0Oo.0___OO0_.)
			Me.Save(text)
			Dim applicationClass As ApplicationClass = New ApplicationClass()
			Dim workbook As Workbook = applicationClass.Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.ExportAsFixedFormat(0, fileName, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.Saved = True
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			applicationClass.Quit()
		End Sub

		' Token: 0x06004FD5 RID: 20437 RVA: 0x00216A08 File Offset: 0x00214C08
		<oO0oooo("3233")>
		Public Sub AddDataTable(TableName As String, ConnectionName As String, SelectString As String)
			Me.OOoOOo0.000. = True
			Dim o0__oo0OOo As o0__oo0OOo = New o0__oo0OOo()
			o0__oo0OOo.O_0O00O0_.oOo. = ConnectionName
			o0__oo0OOo.O_oo._o. = TableName
			o0__oo0OOo.Oo.__0o0_. = SelectString
			Me.O_0_o.Oo_oo0_O..Add(o0__oo0OOo)
		End Sub

		' Token: 0x06004FD6 RID: 20438 RVA: 0x00216A44 File Offset: 0x00214C44
		<oO0oooo("3233")>
		Public Sub AddDataTable(TableName As String, DataTable As DataTable)
			If DataTable.BaseTable.DataSet Is Nothing Then
				Me.OOoOOo0.000. = True
				Dim o0__oo0OOo As o0__oo0OOo = New o0__oo0OOo()
				o0__oo0OOo.O_oo._o. = TableName
				o0__oo0OOo.oo0_O0_000o.0o. = DataTable
				Me.O_0_o.Oo_oo0_O..Add(o0__oo0OOo)
				Return
			End If
			OO_00oOO.PopMessage("添加表失败，此表已属于某DataSet", "提示", 0, -1)
		End Sub

		' Token: 0x06004FD7 RID: 20439 RVA: 0x00216A97 File Offset: 0x00214C97
		<oO0oooo("3233")>
		Public Sub AddRelation(ParentTable As String, ParentColumn As String, ChildTable As String, ChildColumn As String)
			Me.AddRelation(ParentTable, New String() { ParentColumn }, ChildTable, New String() { ChildColumn })
		End Sub

		' Token: 0x06004FD8 RID: 20440 RVA: 0x00216AB8 File Offset: 0x00214CB8
		<oO0oooo("3233")>
		Public Sub AddRelation(ParentTable As String, ParentColumns As String(), ChildTable As String, ChildColumns As String())
			Me.OOoOOo0.000. = True
			Dim o_0OO As O_0OO = New O_0OO()
			o_0OO.O_oo._o. = ParentTable
			o_0OO.O_oo._o. = ParentColumns
			o_0OO.O000000o0.oO0o. = ChildTable
			o_0OO.O000000o0.oO0o. = ChildColumns
			Me.O_0_o.Oo_oo0_O..Add(o_0OO)
		End Sub

		' Token: 0x06004FD9 RID: 20441 RVA: 0x00216AFC File Offset: 0x00214CFC
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				For Each o_0OO As O_0OO In Me.O_0_o.Oo_oo0_O.
					If Operators.CompareString(o_0OO.O_oo._o., A_0, True) = 0 AndAlso Operators.CompareString(o_0OO.O000000o0.oO0o., A_1, True) = 0 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As List(Of O_0OO).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function

		' Token: 0x06004FDA RID: 20442 RVA: 0x00216B70 File Offset: 0x00214D70
		Private Sub <<EMPTY_NAME>>()
			If Me.OOoOOo0.000. Then
				Me.OOoOOo0.000. = False
				Try
					For Each o0__oo0OOo As o0__oo0OOo In Me.O_0_o.Oo_oo0_O.
						If Me.oO.o_0o__. Is Nothing Then
							Me.oO.o_0o__. = New DataSet()
							Me.oO.o_0o__..EnforceConstraints = False
						End If
						If Operators.CompareString(o0__oo0OOo.Oo.__0o0_., "", True) > 0 Then
							Dim dataTable As DataTable = New SQLCommand(o0__oo0OOo.Oo.__0o0_., o0__oo0OOo.O_0O00O0_.oOo.).ExecuteReader(False)
							dataTable.BaseTable.TableName = o0__oo0OOo.O_oo._o.
							Me.oO.o_0o__..Tables.Add(dataTable.BaseTable)
							Me.oO.o_0o__..add(o0__oo0OOo.O_oo._o., dataTable)
						ElseIf o0__oo0OOo.oo0_O0_000o.0o. IsNot Nothing Then
							Me.oO.o_0o__..Tables.Add(o0__oo0OOo.oo0_O0_000o.0o..BaseTable)
							o0__oo0OOo.oo0_O0_000o.0o..BaseTable.TableName = o0__oo0OOo.O_oo._o.
							Me.oO.o_0o__..add(o0__oo0OOo.O_oo._o., o0__oo0OOo.oo0_O0_000o.0o.)
						End If
					Next
				Finally
					Dim enumerator As List(Of o0__oo0OOo).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If Me.O_0_o.Oo_oo0_O..Count > 0 Then
					Try
						For Each o_0OO As O_0OO In Me.O_0_o.Oo_oo0_O.
							If Not Me.oO.o_0o__..Tables.Contains(o_0OO.O_oo._o..ToLower()) OrElse Not Me.oO.o_0o__..Tables.Contains(o_0OO.O000000o0.oO0o.) OrElse o_0OO.O_oo._o..Length <> o_0OO.O000000o0.oO0o..Length OrElse o_0OO.O_oo._o..Length = 0 Then
								OO_00oOO.PopMessage("创建关联失败!", "提示", 0, -1)
								Me.oO.o_0o__..Reset()
								Return
							End If
							Dim list As List(Of DataColumn) = New List(Of DataColumn)()
							Dim list2 As List(Of DataColumn) = New List(Of DataColumn)()
							Dim num As Integer = o_0OO.O_oo._o..Length - 1
							For i As Integer = 0 To num
								If Me.oO.o_0o__..Tables(o_0OO.O_oo._o.).Columns(o_0OO.O_oo._o.(i)).DataType IsNot Me.oO.o_0o__..Tables(o_0OO.O000000o0.oO0o.).Columns(o_0OO.O000000o0.oO0o.(i)).DataType Then
									OO_00oOO.PopMessage("关联列数据类型不匹配!", "提示", 0, -1)
									Me.oO.o_0o__..Reset()
									Return
								End If
								list.Add(Me.oO.o_0o__..Tables(o_0OO.O_oo._o.).Columns(o_0OO.O_oo._o.(i)))
								list2.Add(Me.oO.o_0o__..Tables(o_0OO.O000000o0.oO0o.).Columns(o_0OO.O000000o0.oO0o.(i)))
							Next
							Dim dataRelation As DataRelation = New DataRelation(o_0OO.O000000o0.oO0o., list.ToArray(), list2.ToArray())
							dataRelation.RelationName = OoOo0O.OO_o.0o_O.(10)
							Me.oO.o_0o__..Relations.Add(dataRelation)
						Next
					Finally
						Dim enumerator2 As List(Of O_0OO).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
				Try
					For Each dataTable2 As DataTable In Me.oO.o_0o__.._List.Values
						If OO_00oOO.DataTables.Contains(dataTable2.BaseTable.TableName) Then
							Dim dataTable3 As DataTable = OO_00oOO.DataTables(dataTable2.BaseTable.TableName)
							Try
								For Each dataCol As DataCol In dataTable2.DataCols
									If dataTable3.DataCols.Contains(dataCol.Name) Then
										dataCol.ExtendType = dataTable3.DataCols(dataCol.Name).ExtendType
										dataCol.Remote = dataTable3.DataCols(dataCol.Name).Remote
										If dataCol.Remote And dataTable3.DataCols(dataCol.Name).FTPClient IsNot Nothing Then
											dataCol.FTPClient = dataTable3.DataCols(dataCol.Name).FTPClient.O_O_0_O0.oOO.()
										End If
									End If
								Next
							Finally
								Dim enumerator4 As IEnumerator(Of DataCol)
								If enumerator4 IsNot Nothing Then
									enumerator4.Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator3 As Dictionary(Of String, DataTable).ValueCollection.Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x170011FA RID: 4602
		' (get) Token: 0x06004FDB RID: 20443 RVA: 0x0021705C File Offset: 0x0021525C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property DataTables As tempDataTableCollection
			Get
				If Me.OOoOOo0.000. Then
					Me.ooo._O.()
				End If
				Return Me.oO.o_0o__.
			End Get
		End Property

		' Token: 0x06004FDC RID: 20444 RVA: 0x00217074 File Offset: 0x00215274
		Public Sub SaveToHTML(fileName As String)
			If OO_00oOO.FileSys.FileExists(fileName) Then
				OO_00oOO.FileSys.DeleteFile(fileName)
			End If
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(Me.o_0Oo.0___OO0_.)
			Me.Save(text)
			Dim applicationClass As ApplicationClass = New ApplicationClass()
			Dim workbook As Workbook = applicationClass.Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.SaveAs(fileName, 44, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), 1, RuntimeHelpers.GetObjectValue(Missing.Value), False, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.Saved = True
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			applicationClass.Quit()
		End Sub

		' Token: 0x06004FDD RID: 20445 RVA: 0x002171F0 File Offset: 0x002153F0
		Public Sub SaveToMHT(fileName As String)
			If OO_00oOO.FileSys.FileExists(fileName) Then
				OO_00oOO.FileSys.DeleteFile(fileName)
			End If
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + Path.GetExtension(Me.o_0Oo.0___OO0_.)
			Me.Save(text)
			Dim applicationClass As ApplicationClass = New ApplicationClass()
			Dim workbook As Workbook = applicationClass.Workbooks.Open(text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.SaveAs(fileName, 45, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), 1, RuntimeHelpers.GetObjectValue(Missing.Value), False, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.Saved = True
			workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			applicationClass.Quit()
		End Sub

		' Token: 0x06004FDE RID: 20446 RVA: 0x0021736C File Offset: 0x0021556C
		Private Function <<EMPTY_NAME>>(A_0 As DataTable) As DataTable
			Dim dataTable As DataTable = New DataTable()
			Try
				For Each obj As Object In A_0.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					Dim dataColumn2 As DataColumn = New DataColumn(dataColumn.ColumnName, dataColumn.DataType)
					dataColumn2.MaxLength = dataColumn.MaxLength
					dataTable.Columns.Add(dataColumn2)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return dataTable
		End Function

		' Token: 0x04002146 RID: 8518
		Friend <<EMPTY_NAME>> As C1XLBook

		' Token: 0x04002147 RID: 8519
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04002148 RID: 8520
		Private <<EMPTY_NAME>> As Dictionary(Of String, Object)

		' Token: 0x04002149 RID: 8521
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400214A RID: 8522
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400214B RID: 8523
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400214C RID: 8524
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400214D RID: 8525
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400214E RID: 8526
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400214F RID: 8527
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002150 RID: 8528
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x04002151 RID: 8529
		Private <<EMPTY_NAME>> As Dictionary(Of String, List(Of DataRow))

		' Token: 0x04002152 RID: 8530
		Private <<EMPTY_NAME>> As Book.O0oOOoo_ooo_O

		' Token: 0x04002153 RID: 8531
		Private <<EMPTY_NAME>> As Book.O0oOOoo_ooo_O

		' Token: 0x04002154 RID: 8532
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x04002155 RID: 8533
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x04002156 RID: 8534
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x04002157 RID: 8535
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04002158 RID: 8536
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04002159 RID: 8537
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x0400215A RID: 8538
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)

		' Token: 0x0400215B RID: 8539
		Private <<EMPTY_NAME>> As List(Of Integer)

		' Token: 0x0400215C RID: 8540
		Private <<EMPTY_NAME>> As RichTextBox

		' Token: 0x0400215D RID: 8541
		Friend <<EMPTY_NAME>> As DataSet

		' Token: 0x0400215E RID: 8542
		Private <<EMPTY_NAME>> As tempDataTableCollection

		' Token: 0x0400215F RID: 8543
		Private <<EMPTY_NAME>> As List(Of O_0OO)

		' Token: 0x04002160 RID: 8544
		Private <<EMPTY_NAME>> As List(Of o0__oo0OOo)

		' Token: 0x04002161 RID: 8545
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002162 RID: 8546
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002163 RID: 8547
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002164 RID: 8548
		Private Shared a As Assembly

		' Token: 0x04002165 RID: 8549
		Private Shared a As Boolean

		' Token: 0x04002166 RID: 8550
		Private a As SheetCollection

		' Token: 0x020004D7 RID: 1239
		Friend Class Oo_0o
			' Token: 0x06004FDF RID: 20447 RVA: 0x002173F4 File Offset: 0x002155F4
			Public Sub New()
				Me.oO.o_0o__. = New List(Of DataRow)()
			End Sub

			' Token: 0x04002167 RID: 8551
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04002168 RID: 8552
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04002169 RID: 8553
			Friend <<EMPTY_NAME>> As Integer

			' Token: 0x0400216A RID: 8554
			Friend <<EMPTY_NAME>> As Integer

			' Token: 0x0400216B RID: 8555
			Friend <<EMPTY_NAME>> As List(Of DataRow)

			' Token: 0x0400216C RID: 8556
			Friend <<EMPTY_NAME>> As Boolean

			' Token: 0x0400216D RID: 8557
			Friend <<EMPTY_NAME>> As Boolean
		End Class

		' Token: 0x020004D8 RID: 1240
		Friend Class O0oOOoo_ooo_O
			Inherits List(Of Book.Oo_0o)

			' Token: 0x06004FE0 RID: 20448 RVA: 0x00217407 File Offset: 0x00215607
			Public Sub New()
				Me.o__0_.oO. = New List(Of Book.Oo_0o)()
				Me.o0.o0O__0oo. = New List(Of Book.Oo_0o)()
				Me.O._0_o0O. = New List(Of Book.Oo_0o)()
				Me.o__0_.oO. = New tempDataTableCollection()
			End Sub

			' Token: 0x06004FE1 RID: 20449 RVA: 0x0021743C File Offset: 0x0021563C
			Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Book.Oo_0o
				Try
					For Each oo_0o As Book.Oo_0o In Me
						If Operators.CompareString(oo_0o.O_0o_.O_0., A_0, True) = 0 AndAlso Operators.CompareString(oo_0o.OoO.o0., A_1, True) = 0 Then
							Return oo_0o
						End If
					Next
				Finally
					Dim enumerator As List(Of Book.Oo_0o).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return Nothing
			End Function

			' Token: 0x06004FE2 RID: 20450 RVA: 0x002174A8 File Offset: 0x002156A8
			Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Book.Oo_0o
				Dim oo_0o As Book.Oo_0o = New Book.Oo_0o()
				oo_0o.O_0o_.O_0. = A_0
				oo_0o.OoO.o0. = A_1
				MyBase.Add(oo_0o)
				Return oo_0o
			End Function

			' Token: 0x06004FE3 RID: 20451 RVA: 0x002174D4 File Offset: 0x002156D4
			Friend Sub <<EMPTY_NAME>>(A_0 As XLSheet)
				Try
					For Each oo_0o As Book.Oo_0o In Me
						If oo_0o.oooo.0O__oo. = 0 Then
							oo_0o.oooo.0O__oo. = oo_0o.O_0o_.O_0.
						End If
						Dim o_0o_.O_0. As Integer = oo_0o.O_0o_.O_0.
						Dim oooo.0O__oo. As Integer = oo_0o.oooo.0O__oo.
						For i As Integer = o_0o_.O_0. To oooo.0O__oo.
							A_0(i, 0).Value = "{Skip}"
						Next
					Next
				Finally
					Dim enumerator As List(Of Book.Oo_0o).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End Sub

			' Token: 0x06004FE4 RID: 20452 RVA: 0x0021755C File Offset: 0x0021575C
			Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As List(Of DataRow))
				Me.o__0_.oO..Clear()
				Dim dataRow As DataRow = A_2(A_0)
				Try
					For Each oo_0o As Book.Oo_0o In Me
						If Operators.CompareString(oo_0o.O_0o_.O_0., dataRow.Table.TableName, True) = 0 Then
							If oo_0o.oO.o_0o__..Count = 0 Then
								Me.O_0o_.O_0.(oo_0o, A_0, A_1, A_2)
								Me.o__0_.oO..Add(oo_0o)
							ElseIf Operators.CompareString(oo_0o.oO.o_0o__.(oo_0o.oO.o_0o__..Count - 1)(oo_0o.OoO.o0.).ToString(), dataRow(oo_0o.OoO.o0.).ToString(), True) <> 0 Then
								oo_0o.oO.o_0o__..Clear()
								Me.O_0o_.O_0.(oo_0o, A_0, A_1, A_2)
								Me.o__0_.oO..Add(oo_0o)
							Else
								Me.O_0o_.O_0.(oo_0o, A_0, A_1, A_2)
							End If
						End If
					Next
				Finally
					Dim enumerator As List(Of Book.Oo_0o).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End Sub

			' Token: 0x06004FE5 RID: 20453 RVA: 0x0021766C File Offset: 0x0021586C
			Private Sub <<EMPTY_NAME>>(A_0 As Book.Oo_0o, A_1 As Integer, A_2 As Integer, A_3 As List(Of DataRow))
				A_0.oO.o_0o__..Add(A_3(A_1))
				Dim num As Integer = A_1 + 1
				Dim num2 As Integer = Math.Min(A_1 + A_2 - 1, A_3.Count - 1)
				Dim num3 As Integer = num
				While num3 <= num2 AndAlso Operators.CompareString(A_3(A_1)(A_0.OoO.o0.).ToString(), A_3(num3)(A_0.OoO.o0.).ToString(), True) = 0
					A_0.oO.o_0o__..Add(A_3(num3))
					num3 += 1
				End While
			End Sub

			' Token: 0x06004FE6 RID: 20454 RVA: 0x002176FC File Offset: 0x002158FC
			Friend Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataRow) As Boolean
				Try
					For Each oo_0o As Book.Oo_0o In Me
						If Operators.CompareString(oo_0o.O_0o_.O_0., A_0.Table.TableName, True) = 0 AndAlso Operators.CompareString(A_0(oo_0o.OoO.o0.).ToString(), A_1(oo_0o.OoO.o0.).ToString(), True) <> 0 Then
							Return False
						End If
					Next
				Finally
					Dim enumerator As List(Of Book.Oo_0o).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return True
			End Function

			' Token: 0x06004FE7 RID: 20455 RVA: 0x00217790 File Offset: 0x00215990
			Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As List(Of DataRow))
				Me.O._0_o0O..Clear()
				If A_0 <> A_2.Count - 1 Then
					Try
						For Each oo_0o As Book.Oo_0o In Me
							If oo_0o.oooo.0O__oo. AndAlso (Me.o__0_.oO..Contains(oo_0o.O_0o_.O_0.) OrElse (OO_00oOO.Tables.get_Contains(oo_0o.O_0o_.O_0.) AndAlso Operators.CompareString(OO_00oOO.Tables(oo_0o.O_0o_.O_0.).DataTable.BaseTable.TableName, A_2(A_0).Table.TableName, True) = 0) OrElse Operators.CompareString(oo_0o.O_0o_.O_0., A_2(A_0).Table.TableName, True) = 0) Then
								Dim num As Integer = A_0
								If A_1 > 1 Then
									Dim num2 As Integer = A_0 + 1
									Dim num3 As Integer = Math.Min(A_0 + A_1 - 1, A_2.Count - 1)
									Dim num4 As Integer = num3
									For i As Integer = num2 To num4
										If Me.o__0_.oO.(A_2(i - 1), A_2(i)) Then
											oo_0o.oO.o_0o__..Add(A_2(i - 1))
											num = i
										End If
									Next
								End If
								If num = A_2.Count - 1 Then
									Exit For
								End If
								Dim dataRow As DataRow = A_2(num)
								If Operators.CompareString(A_2(num + 1)(oo_0o.OoO.o0.).ToString(), dataRow(oo_0o.OoO.o0.).ToString(), True) = 0 Then
									Me.O._0_o0O..Add(oo_0o)
								End If
							End If
						Next
					Finally
						Dim enumerator As List(Of Book.Oo_0o).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
			End Sub

			' Token: 0x06004FE8 RID: 20456 RVA: 0x00217944 File Offset: 0x00215B44
			Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As List(Of DataRow))
				Me.o0.o0O__0oo..Clear()
				Me.o__0_.oO. = False
				If A_0 = A_2.Count - 1 Then
					Try
						For Each oo_0o As Book.Oo_0o In Me
							If(OO_00oOO.Tables.get_Contains(oo_0o.O_0o_.O_0.) AndAlso Operators.CompareString(OO_00oOO.Tables(oo_0o.O_0o_.O_0.).DataTable.BaseTable.TableName, A_2(A_0).Table.TableName, True) = 0) OrElse Operators.CompareString(oo_0o.O_0o_.O_0., A_2(A_0).Table.TableName, True) = 0 Then
								oo_0o.oO.o_0o__..Add(A_2(A_0))
								If oo_0o.oO.o_0o__. Then
									Me.o__0_.oO. = True
								End If
								Me.o0.o0O__0oo..Add(oo_0o)
							End If
						Next
						Return
					Finally
						Dim enumerator As List(Of Book.Oo_0o).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				Dim num As Integer = MyBase.Count - 1
				For i As Integer = 0 To num
					Dim oo_0o2 As Book.Oo_0o = MyBase(i)
					If(OO_00oOO.Tables.get_Contains(oo_0o2.O_0o_.O_0.) AndAlso Operators.CompareString(OO_00oOO.Tables(oo_0o2.O_0o_.O_0.).DataTable.BaseTable.TableName, A_2(A_0).Table.TableName, True) = 0) OrElse Operators.CompareString(oo_0o2.O_0o_.O_0., A_2(A_0).Table.TableName, True) = 0 Then
						Dim num2 As Integer = A_0
						oo_0o2.oO.o_0o__..Add(A_2(num2))
						If A_1 > 1 Then
							Dim num3 As Integer = A_0 + 1
							Dim num4 As Integer = Math.Min(A_0 + A_1 - 1, A_2.Count - 1)
							Dim num5 As Integer = num4
							For j As Integer = num3 To num5
								If Me.o__0_.oO.(A_2(j), A_2(A_0)) Then
									oo_0o2.oO.o_0o__..Add(A_2(j))
									num2 = j
								End If
							Next
						End If
						If num2 = A_2.Count - 1 Then
							If oo_0o2.oO.o_0o__. Then
								Me.o__0_.oO. = True
							End If
							Me.o0.o0O__0oo..Add(oo_0o2)
						Else
							Dim dataRow As DataRow = A_2(num2)
							Dim dataRow2 As DataRow = A_2(num2 + 1)
							Dim num6 As Integer = i
							Dim num7 As Integer = MyBase.Count - 1
							Dim k As Integer = num6
							While k <= num7
								If Operators.CompareString(dataRow2(MyBase(k).OoO.o0.).ToString(), dataRow(MyBase(k).OoO.o0.).ToString(), True) <> 0 Then
									Me.o0.o0O__0oo..Add(oo_0o2)
									If oo_0o2.oO.o_0o__. Then
										Me.o__0_.oO. = True
										Exit While
									End If
									Exit While
								Else
									k += 1
								End If
							End While
						End If
					End If
				Next
			End Sub

			' Token: 0x06004FE9 RID: 20457 RVA: 0x00217C0C File Offset: 0x00215E0C
			Friend Sub <<EMPTY_NAME>>()
				Try
					For Each oo_0o As Book.Oo_0o In Me.o0.o0O__0oo.
						oo_0o.oO.o_0o__..Clear()
					Next
				Finally
					Dim enumerator As List(Of Book.Oo_0o).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.o0.o0O__0oo..Clear()
			End Sub

			' Token: 0x0400216E RID: 8558
			Friend <<EMPTY_NAME>> As List(Of Book.Oo_0o)

			' Token: 0x0400216F RID: 8559
			Friend <<EMPTY_NAME>> As List(Of Book.Oo_0o)

			' Token: 0x04002170 RID: 8560
			Friend <<EMPTY_NAME>> As List(Of Book.Oo_0o)

			' Token: 0x04002171 RID: 8561
			Friend <<EMPTY_NAME>> As Boolean

			' Token: 0x04002172 RID: 8562
			Friend <<EMPTY_NAME>> As tempDataTableCollection
		End Class
	End Class
End Namespace
