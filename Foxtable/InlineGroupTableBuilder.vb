Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200009E RID: 158
	<oO0oooo("3367")>
	<ComVisible(True)>
	Public Class InlineGroupTableBuilder
		' Token: 0x17000180 RID: 384
		' (get) Token: 0x060005CD RID: 1485 RVA: 0x0001E4C5 File Offset: 0x0001C6C5
		' (set) Token: 0x060005CE RID: 1486 RVA: 0x0001E4CD File Offset: 0x0001C6CD
		Public Property TableName As String

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x060005CF RID: 1487 RVA: 0x0001E4D6 File Offset: 0x0001C6D6
		' (set) Token: 0x060005D0 RID: 1488 RVA: 0x0001E4DE File Offset: 0x0001C6DE
		Public Property DataTable As DataTable

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001E4E7 File Offset: 0x0001C6E7
		' (set) Token: 0x060005D2 RID: 1490 RVA: 0x0001E4EF File Offset: 0x0001C6EF
		Public Property ParentCol As String

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		' (set) Token: 0x060005D4 RID: 1492 RVA: 0x0001E500 File Offset: 0x0001C700
		Public Property ChildCol As String

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001E509 File Offset: 0x0001C709
		' (set) Token: 0x060005D6 RID: 1494 RVA: 0x0001E511 File Offset: 0x0001C711
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend Property Totals As List(Of o0o_)

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001E51A File Offset: 0x0001C71A
		' (set) Token: 0x060005D8 RID: 1496 RVA: 0x0001E522 File Offset: 0x0001C722
		Public Property Filter As String

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001E52B File Offset: 0x0001C72B
		' (set) Token: 0x060005DA RID: 1498 RVA: 0x0001E533 File Offset: 0x0001C733
		Public Property IncludeParentCol As Boolean

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x060005DB RID: 1499 RVA: 0x0001E53C File Offset: 0x0001C73C
		' (set) Token: 0x060005DC RID: 1500 RVA: 0x0001E544 File Offset: 0x0001C744
		Public Property GridTree As Boolean

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x060005DD RID: 1501 RVA: 0x0001E54D File Offset: 0x0001C74D
		' (set) Token: 0x060005DE RID: 1502 RVA: 0x0001E555 File Offset: 0x0001C755
		Public Property ExpandTo As Integer

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x060005DF RID: 1503 RVA: 0x0001E55E File Offset: 0x0001C75E
		' (set) Token: 0x060005E0 RID: 1504 RVA: 0x0001E566 File Offset: 0x0001C766
		Public Property OnlyGroupRows As Boolean

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001E56F File Offset: 0x0001C76F
		' (set) Token: 0x060005E2 RID: 1506 RVA: 0x0001E577 File Offset: 0x0001C777
		Public Property PreserveTo As Integer

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001E580 File Offset: 0x0001C780
		' (set) Token: 0x060005E4 RID: 1508 RVA: 0x0001E588 File Offset: 0x0001C788
		Public Property ShowTreeInParentCol As Boolean

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001E591 File Offset: 0x0001C791
		<oO0oooo("3699")>
		Public ReadOnly Property Additions As MRPExtendTables

		' Token: 0x060005E6 RID: 1510 RVA: 0x0001E59C File Offset: 0x0001C79C
		Public Sub New(A_0 As String, A_1 As DataTable)
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.OO_Oo.0oO. = New HashSet(Of String)()
			Me.TableName = A_0
			Me.DataTable = A_1
		End Sub

		' Token: 0x060005E7 RID: 1511 RVA: 0x0001E5EC File Offset: 0x0001C7EC
		Public Sub New(A_0 As String)
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.OO_Oo.0oO. = New HashSet(Of String)()
			Me.TableName = A_0
			Me.DataTable = Me.DataTable
		End Sub

		' Token: 0x060005E8 RID: 1512 RVA: 0x0001E641 File Offset: 0x0001C841
		Public Sub New()
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.OO_Oo.0oO. = New HashSet(Of String)()
		End Sub

		' Token: 0x060005E9 RID: 1513 RVA: 0x0001E678 File Offset: 0x0001C878
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Build(ParamArray args As Object())
			If args.Length = 0 Then
				Me.Build()
				Return
			End If
			If args.Length = 1 Then
				Me.Build(Conversions.ToBoolean(args(0)))
			End If
		End Sub

		' Token: 0x060005EA RID: 1514 RVA: 0x0001E69C File Offset: 0x0001C89C
		Public Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x060005EB RID: 1515 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(ParamArray args As Object())
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
			Dim newName As String = Conversions.ToString(args(1))
			If Not(TypeOf objectValue Is Boolean) Then
				If TypeOf objectValue Is String Then
					Dim column As String = Conversions.ToString(objectValue)
					Select Case args.Length
						Case 2
							Me.AddTotal(column, newName)
							Return
						Case 3
							Dim aggregateRange As AggregateRange = CType(Conversions.ToInteger(args(2)), AggregateRange)
							Me.AddTotal(column, newName, aggregateRange)
							Return
						Case 4
							Dim aggregateRange2 As AggregateRange = CType(Conversions.ToInteger(args(2)), AggregateRange)
							Dim aggregateType As AggregateType = CType(Conversions.ToInteger(args(3)), AggregateType)
							Me.AddTotal(column, newName, aggregateRange2, aggregateType)
						Case Else
							Return
					End Select
				End If
				Return
			End If
			Dim count As Boolean = Conversions.ToBoolean(objectValue)
			Dim num As Integer = args.Length
			If num = 2 Then
				Me.AddTotal(count, newName)
				Return
			End If
			If num <> 3 Then
				Return
			End If
			Dim aggregateRange3 As AggregateRange = CType(Conversions.ToInteger(args(2)), AggregateRange)
			Me.AddTotal(count, newName, aggregateRange3)
		End Sub

		' Token: 0x060005EC RID: 1516 RVA: 0x0001E76D File Offset: 0x0001C96D
		Public Sub AddTotal(Column As String, newName As String)
			Me.AddTotal(Column, newName, AggregateRange.Both, AggregateType.Sum)
		End Sub

		' Token: 0x060005ED RID: 1517 RVA: 0x0001E779 File Offset: 0x0001C979
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As AggregateRange)
			Me.AddTotal(Column, newName, AggregateRange, AggregateType.Sum)
		End Sub

		' Token: 0x060005EE RID: 1518 RVA: 0x0001E785 File Offset: 0x0001C985
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As Integer)
			Me.AddTotal(Column, newName, CType(AggregateRange, AggregateRange))
		End Sub

		' Token: 0x060005EF RID: 1519 RVA: 0x0001E790 File Offset: 0x0001C990
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As AggregateRange, AggregateType As AggregateType)
			If Not Me.OO_Oo.0oO..Contains(newName) Then
				Me.OO_Oo.0oO..Add(newName)
				Me.Totals.Add(New o0o_(Column, newName, AggregateRange, AggregateType))
			End If
		End Sub

		' Token: 0x060005F0 RID: 1520 RVA: 0x0001E7C2 File Offset: 0x0001C9C2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As Integer, AggregateType As Integer)
			Me.AddTotal(Column, newName, CType(AggregateRange, AggregateRange), CType(AggregateType, AggregateType))
		End Sub

		' Token: 0x060005F1 RID: 1521 RVA: 0x0001E7CF File Offset: 0x0001C9CF
		Public Sub AddTotal(Count As Boolean, newName As String)
			Me.AddTotal(True, newName, AggregateRange.Both)
		End Sub

		' Token: 0x060005F2 RID: 1522 RVA: 0x0001E7DA File Offset: 0x0001C9DA
		Public Sub AddTotal(Count As Boolean, newName As String, AggregateRange As AggregateRange)
			If Not Me.OO_Oo.0oO..Contains(newName) Then
				Me.OO_Oo.0oO..Add(newName)
				Me.Totals.Add(New o0o_(True, newName, AggregateRange))
			End If
		End Sub

		' Token: 0x060005F3 RID: 1523 RVA: 0x0001E80A File Offset: 0x0001CA0A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Count As Boolean, newName As String, AggregateRange As Integer)
			Me.AddTotal(Count, newName, CType(AggregateRange, AggregateRange))
		End Sub

		' Token: 0x060005F4 RID: 1524 RVA: 0x0001E818 File Offset: 0x0001CA18
		Public Function Build(OnlyDataTable As Boolean) As DataTable
			Dim num As Integer
			Dim result As DataTable
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.TableName, "", True) <> 0 Then
					GoTo IL_2E
				End If
				IL_1C:
				num2 = 3
				Me.TableName = Oo00.oo0o.O0O_0__.("统计表")
				IL_2E:
				num2 = 4
				If Not OO_00oOO.DataTables.Contains(Me.TableName) OrElse OnlyDataTable Then
					GoTo IL_B3
				End If
				IL_45:
				num2 = 5
				If Not OO_00oOO.DataTables(Me.TableName).AddByCode Then
					GoTo IL_70
				End If
				IL_5E:
				num2 = 6
				OO_00oOO.DataTables.Delete(Me.TableName)
				IL_70:
				num2 = 7
				If Not OO_00oOO.DataTables.Contains(Me.TableName) Then
					GoTo IL_B3
				End If
				IL_84:
				num2 = 8
				MessageBox.Show("表" + Me.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_A9:
				num2 = 9
				result = Nothing
				GoTo IL_504
				IL_B3:
				num2 = 10
				Dim dataTable As DataTable = Me.o0o0000.O00o.()
				IL_BE:
				num2 = 11
				dataTable.TableName = Me.TableName
				IL_CE:
				num2 = 12
				If Not OnlyDataTable Then
					GoTo IL_101
				End If
				IL_D4:
				num2 = 13
				Dim dataTable2 As DataTable = New DataTable(dataTable, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
				IL_EC:
				num2 = 14
				dataTable2.o.0O000_.()
				IL_F6:
				num2 = 15
				result = dataTable2
				GoTo IL_504
				IL_101:
				num2 = 16
				If Not Me.OnlyGroupRows OrElse dataTable.Rows.Count <= 0 Then
					GoTo IL_2BC
				End If
				IL_121:
				num2 = 17
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_12B:
				num2 = 18
				Dim num3 As Integer = dataTable.Rows.Count - 2
				For i As Integer = 1 To num3
					IL_146:
					num2 = 19
					If Conversions.ToInteger(dataTable.Rows(i)("sys_Hierarchy_Level")) = Conversions.ToInteger(dataTable.Rows(i + 1)("sys_Hierarchy_Level")) AndAlso Conversions.ToInteger(dataTable.Rows(i)("sys_Hierarchy_Level")) > 0 Then
						IL_1A7:
						num2 = 20
						list.Add(dataTable.Rows(i))
					Else
						IL_1C1:
						num2 = 22
						If Conversions.ToInteger(dataTable.Rows(i)("sys_Hierarchy_Level")) > Conversions.ToInteger(dataTable.Rows(i + 1)("sys_Hierarchy_Level")) Then
							IL_202:
							num2 = 23
							list.Add(dataTable.Rows(i))
						End If
					End If
					IL_21A:
					num2 = 24
				Next
				IL_22C:
				num2 = 25
				If Conversions.ToInteger(dataTable.Rows(dataTable.Rows.Count - 1)("sys_Hierarchy_Level")) <= 0 Then
					GoTo IL_27F
				End If
				IL_25B:
				num2 = 26
				list.Add(dataTable.Rows(dataTable.Rows.Count - 1))
				IL_27F:
				num2 = 27
				Dim enumerator As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataRow As DataRow = enumerator.Current
					IL_296:
					num2 = 28
					dataRow.Delete()
					IL_2A0:
					num2 = 29
				End While
				IL_2AC:
				num2 = 30
				CType(enumerator, IDisposable).Dispose()
				IL_2BC:
				num2 = 31
				If Me.PreserveTo <= -1 Then
					GoTo IL_32D
				End If
				IL_2C8:
				num2 = 32
				New List(Of DataRow)()
				IL_2D1:
				num2 = 33
				For j As Integer = dataTable.Rows.Count - 1 To 0 Step -1
					IL_2E6:
					num2 = 34
					If Conversions.ToInteger(dataTable.Rows(j)("sys_Hierarchy_Level")) > Me.PreserveTo Then
						IL_30E:
						num2 = 35
						dataTable.Rows.RemoveAt(j)
					End If
					IL_31F:
					num2 = 36
				Next
				IL_32D:
				num2 = 37
				dataTable.AcceptChanges()
				IL_337:
				num2 = 38
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
				IL_34B:
				num2 = 39
				OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, Me.TableName, O_O0OO.OoO.0OO__0ooo.()))
				IL_36C:
				num2 = 40
				OO_00oOO.DataTables(Me.TableName).o.0O000_.()
				IL_384:
				num2 = 41
				OO_00oOO.DataTables(Me.TableName).AddByCode = True
				IL_39D:
				num2 = 42
				New O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables(Me.TableName).BaseTable)
				IL_3C0:
				num2 = 43
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
				IL_3DD:
				num2 = 44
				Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, True, False)
				IL_3F2:
				num2 = 45
				If Not Me.ShowTreeInParentCol OrElse Not Me.IncludeParentCol Then
					GoTo IL_443
				End If
				IL_405:
				num2 = 46
				OO_00oOO.DataTables(Me.TableName).OoOo_OoOO0.o. = Me.ParentCol
				IL_423:
				num2 = 47
				OO_00oOO.Tables(Me.TableName).OO0o_o0.0oOo0o. = Me.ParentCol
				GoTo IL_47F
				IL_443:
				num2 = 49
				OO_00oOO.DataTables(Me.TableName).OoOo_OoOO0.o. = Me.ChildCol
				IL_461:
				num2 = 50
				OO_00oOO.Tables(Me.TableName).OO0o_o0.0oOo0o. = Me.ChildCol
				IL_47F:
				num2 = 51
				OO_00oOO.DataTables(Me.TableName).oOOO.OOO_0ooO0. = True
				IL_498:
				num2 = 52
				If Not Me.GridTree Then
					GoTo IL_4F0
				End If
				IL_4A3:
				num2 = 53
				OO_00oOO.Tables(Me.TableName).HierarchyData = True
				IL_4BC:
				num2 = 54
				If Me.ExpandTo <= -1 Then
					GoTo IL_4F0
				End If
				IL_4C8:
				num2 = 55
				CType(OO_00oOO.Tables(Me.TableName).Grid, O_oOooO_O).OoO._OOo__.(Me.ExpandTo)
				IL_4F0:
				num2 = 56
				result = OO_00oOO.DataTables(Me.TableName)
				IL_504:
				GoTo IL_63A
				IL_509:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_5FB:
				GoTo IL_62F
				IL_5FD:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_60D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5FD
			End Try
			IL_62F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_63A:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060005F5 RID: 1525 RVA: 0x0001EE84 File Offset: 0x0001D084
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x060005F6 RID: 1526 RVA: 0x0001EE9E File Offset: 0x0001D09E
		Public Function BuildDataSource() As fxDataSource
			Return Me.o0o0000.O00o.()
		End Function

		' Token: 0x060005F7 RID: 1527 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num12 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim fxDataSource As fxDataSource = Me.oO._O_0oO__0.()
				IL_11:
				num2 = 3
				Dim a_ As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, Me.ChildCol, DataViewRowState.CurrentRows)
				IL_33:
				num2 = 4
				Dim a_2 As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, Me.ParentCol, DataViewRowState.CurrentRows)
				IL_55:
				num2 = 5
				Dim text As String = String.Concat(New String() { "(", Me.ParentCol, " Is Null And ", Me.ChildCol, " Is Not Null) or (", Me.ParentCol, " = ", Me.ChildCol, ")" })
				IL_B1:
				num2 = 6
				If Operators.CompareString(Me.Filter, "", True) <= 0 Then
					GoTo IL_FC
				End If
				IL_C7:
				num2 = 7
				text = String.Concat(New String() { "(", text, ") And (", Me.Filter, ")" })
				IL_FC:
				num2 = 8
				Dim array As DataRow() = Me.DataTable.BaseTable.[Select](text, Me.ChildCol, DataViewRowState.CurrentRows)
				IL_11A:
				num2 = 9
				Dim hashSet As HashSet(Of String) = Oo00.O____0O._0.(Me.DataTable.BaseTable, Me.Filter, "", Me.ParentCol)
				IL_140:
				num2 = 10
				Dim hashSet2 As HashSet(Of String) = Oo00.O____0O._0.(Me.DataTable.BaseTable, Me.Filter, "", Me.ChildCol)
				IL_166:
				num2 = 11
				Dim dictionary As Dictionary(Of DataRow, List(Of DataRow)) = New Dictionary(Of DataRow, List(Of DataRow))()
				IL_170:
				num2 = 12
				hashSet.ExceptWith(hashSet2)
				IL_17C:
				num2 = 13
				For Each dataRow As DataRow In array
					IL_18F:
					num2 = 14
					hashSet.Add(dataRow(Me.ChildCol).ToString())
					IL_1AC:
					num2 = 15
				Next
				IL_1BD:
				num2 = 16
				Dim list As List(Of String) = New List(Of String)()
				IL_1C7:
				num2 = 17
				list.AddRange(hashSet)
				IL_1D3:
				num2 = 18
				list.Sort()
				IL_1DD:
				num2 = 19
				hashSet.Clear()
				IL_1E7:
				num2 = 20
				hashSet2.Clear()
				IL_1F1:
				num2 = 21
				Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim text2 As String = enumerator.Current
					IL_208:
					num2 = 22
					If Operators.CompareString(text2, "", True) <> 0 Then
						IL_21A:
						num2 = 24
						Me.oO._O_0oO__0.(fxDataSource, a_2, a_, text2, New List(Of String)(), dictionary, 0)
					End If
					IL_233:
					num2 = 25
				End While
				IL_23F:
				num2 = 26
				CType(enumerator, IDisposable).Dispose()
				IL_24F:
				num2 = 27
				Dim num3 As Integer = fxDataSource.Rows.Count - 1
				For j As Integer = 0 To num3
					IL_26A:
					num2 = 28
					Dim dataRow2 As DataRow = fxDataSource.Rows(j)
					IL_27D:
					num2 = 29
					Dim num4 As Integer = Conversions.ToInteger(dataRow2("sys_Hierarchy_Level"))
					IL_293:
					num2 = 30
					Dim enumerator2 As List(Of o0o_).Enumerator = Me.Totals.GetEnumerator()
					While enumerator2.MoveNext()
						Dim o0o_ As o0o_ = enumerator2.Current
						IL_2B1:
						num2 = 31
						Dim num5 As Integer = 0
						IL_2B7:
						num2 = 32
						Dim num6 As Double = 0.0
						IL_2C5:
						num2 = 33
						If o0o_.o0oO._o_.() = AggregateType.Min Then
							IL_2D2:
							num2 = 34
							num6 = Double.MaxValue
						Else
							IL_2E2:
							num2 = 36
							If o0o_.o0oO._o_.() = AggregateType.Max Then
								IL_2EF:
								num2 = 37
								num6 = Double.MinValue
							End If
						End If
						IL_2FD:
						num2 = 38
						Dim num7 As Integer = j
						IL_304:
						num2 = 39
						Dim num8 As Integer = fxDataSource.Rows.Count - 1
						IL_317:
						num2 = 40
						If o0o_.O0OO_0.O.() = AggregateRange.Self Then
							IL_323:
							num2 = 41
							num8 = j
						Else
							IL_32C:
							num2 = 43
							If o0o_.O0OO_0.O.() = AggregateRange.[Sub] Then
								IL_339:
								num2 = 44
								num7 = j + 1
							End If
						End If
						IL_342:
						num2 = 45
						Dim num9 As Integer = num7
						Dim num10 As Integer = num8
						For k As Integer = num9 To num10
							IL_352:
							num2 = 46
							Dim dataRow3 As DataRow = fxDataSource.Rows(k)
							IL_365:
							num2 = 47
							If k > j AndAlso Conversions.ToInteger(dataRow3("sys_Hierarchy_Level")) <= num4 Then
								Exit For
							End If
							IL_386:
							num2 = 49
							Dim list2 As List(Of DataRow) = dictionary(dataRow3)
							IL_394:
							num2 = 50
							num5 += list2.Count
							IL_3A3:
							num2 = 51
							If o0o_.o0oO._o_.() <> AggregateType.Count Then
								IL_3B3:
								num2 = 53
								Dim enumerator3 As List(Of DataRow).Enumerator = list2.GetEnumerator()
								While enumerator3.MoveNext()
									Dim dataRow4 As DataRow = enumerator3.Current
									IL_3CD:
									num2 = 54
									If Not dataRow4.IsNull(o0o_.o0oO._o_.()) Then
										IL_3E3:
										num2 = 56
										Select Case o0o_.o0oO._o_.()
											Case AggregateType.Sum, AggregateType.Average
												IL_408:
												num2 = 58
												num6 += Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.()))
											Case AggregateType.Max
												IL_446:
												num2 = 62
												num6 = Math.Max(num6, Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.())))
											Case AggregateType.Min
												IL_425:
												num2 = 60
												num6 = Math.Min(num6, Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.())))
										End Select
									End If
									IL_465:
									num2 = 64
								End While
								IL_474:
								num2 = 65
								CType(enumerator3, IDisposable).Dispose()
							End If
							IL_484:
							num2 = 66
						Next
						IL_496:
						num2 = 67
						If o0o_.o0oO._o_.() = AggregateType.Average AndAlso num5 > 0 Then
							IL_4A8:
							num2 = 68
							num6 /= CDbl(num5)
						End If
						IL_4B3:
						num2 = 69
						If o0o_.o0oO._o_.() = AggregateType.Count Then
							IL_4C0:
							num2 = 70
							dataRow2(o0o_.Oo0oO0oOO_.0_o.()) = num5
						Else
							IL_4DA:
							num2 = 72
							dataRow2(o0o_.Oo0oO0oOO_.0_o.()) = num6
						End If
						IL_4F2:
						num2 = 73
					End While
					IL_501:
					num2 = 74
					CType(enumerator2, IDisposable).Dispose()
					IL_511:
					num2 = 75
				Next
				IL_523:
				num2 = 76
				dictionary.Clear()
				IL_52D:
				num2 = 77
				result = fxDataSource
				IL_533:
				GoTo IL_6BD
				IL_538:
				Dim num11 As Integer = num12 + 1
				num12 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num11)
				IL_67E:
				GoTo IL_6B2
				IL_680:
				num12 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_690:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_680
			End Try
			IL_6B2:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6BD:
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060005F8 RID: 1528 RVA: 0x0001F598 File Offset: 0x0001D798
		Private Sub <<EMPTY_NAME>>(A_0 As fxDataSource, A_1 As DataView, A_2 As DataView, A_3 As String, A_4 As List(Of String), A_5 As Dictionary(Of DataRow, List(Of DataRow)), A_6 As Integer)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not A_4.Contains(A_3) Then
					GoTo IL_65
				End If
				IL_14:
				num2 = 3
				MessageBox.Show(String.Concat(New String() { "发现循环引用：", String.Join("→", A_4.ToArray()), "→", A_3, vbCrLf & "无法完成统计!" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				GoTo IL_31D
				IL_65:
				num2 = 5
				Dim dataRow As DataRow = A_0.NewRow()
				IL_6E:
				num2 = 6
				Dim text As String = ""
				IL_77:
				num2 = 7
				If A_4.Count <= 0 Then
					GoTo IL_B5
				End If
				IL_83:
				num2 = 8
				text = A_4(A_4.Count - 1)
				IL_97:
				num2 = 9
				If Not Me.IncludeParentCol Then
					GoTo IL_D1
				End If
				IL_A2:
				num2 = 10
				dataRow(Me.ParentCol) = text
				GoTo IL_D1
				IL_B5:
				num2 = 12
				If Not Me.IncludeParentCol Then
					GoTo IL_D1
				End If
				IL_C0:
				num2 = 13
				dataRow(Me.ParentCol) = A_3
				IL_D1:
				num2 = 14
				A_4.Add(A_3)
				IL_DD:
				num2 = 15
				Dim array As DataRowView() = A_2.FindRows(A_3)
				IL_EA:
				num2 = 16
				dataRow(Me.ChildCol) = A_3
				IL_FB:
				num2 = 17
				dataRow("sys_Hierarchy_Level") = A_6
				IL_110:
				num2 = 18
				Dim enumerator As IEnumerator(Of o00_0__O) = Me.Additions.GetEnumerator()
				While enumerator.MoveNext()
					Dim o00_0__O As o00_0__O = enumerator.Current
					IL_12B:
					num2 = 19
					Dim num3 As Integer = o00_0__O.oo__.0O00.().Find(A_3)
					IL_13E:
					num2 = 20
					If num3 >= 0 Then
						IL_146:
						num2 = 21
						dataRow(o00_0__O.o0o.OooOOo0__.()) = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()(num3)(o00_0__O.oooO00.o00O.()))
					End If
					IL_175:
					num2 = 22
				End While
				IL_181:
				num2 = 23
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_18F:
				num2 = 24
				A_0.Rows.Add(dataRow)
				IL_19E:
				num2 = 25
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_1A8:
				num2 = 26
				For Each dataRowView As DataRowView In array
					IL_1BB:
					num2 = 27
					If A_6 = 0 OrElse Operators.CompareString(dataRowView(Me.ParentCol).ToString(), text, True) = 0 Then
						IL_1DE:
						num2 = 28
						list.Add(dataRowView.Row)
					End If
					IL_1EF:
					num2 = 29
				Next
				IL_200:
				num2 = 30
				A_5(dataRow) = list
				IL_20D:
				num2 = 31
				array = A_1.FindRows(A_3)
				IL_21A:
				num2 = 32
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				IL_224:
				num2 = 33
				For Each dataRowView2 As DataRowView In array
					IL_23A:
					num2 = 34
					If Operators.CompareString(dataRowView2(Me.ChildCol).ToString(), A_3, True) <> 0 Then
						IL_25C:
						num2 = 36
						If Not dataRowView2.Row.IsNull(Me.ChildCol) AndAlso Not hashSet.Contains(dataRowView2(Me.ChildCol).ToString()) Then
							IL_291:
							num2 = 38
							If Operators.CompareString(dataRowView2(Me.ParentCol).ToString(), A_3, True) = 0 Then
								IL_2B0:
								num2 = 40
								hashSet.Add(dataRowView2(Me.ChildCol).ToString())
								IL_2CD:
								num2 = 41
								Dim list2 As List(Of String) = New List(Of String)()
								IL_2D7:
								num2 = 42
								list2.AddRange(A_4)
								IL_2E3:
								num2 = 43
								Me.oO._O_0oO__0.(A_0, A_1, A_2, dataRowView2(Me.ChildCol).ToString(), list2, A_5, A_6 + 1)
							End If
						End If
					End If
					IL_309:
					num2 = 44
				Next
				IL_31D:
				GoTo IL_423
				IL_322:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_3E4:
				GoTo IL_418
				IL_3E6:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3F6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3E6
			End Try
			IL_418:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_423:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060005F9 RID: 1529 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim fxDataSource As fxDataSource = New fxDataSource()
			If Me.ShowTreeInParentCol Then
				If Me.IncludeParentCol Then
					fxDataSource.Columns.Add(Me.ParentCol, GetType(String))
				End If
				fxDataSource.Columns.Add(Me.ChildCol, GetType(String))
			Else
				fxDataSource.Columns.Add(Me.ChildCol, GetType(String))
				If Me.IncludeParentCol Then
					fxDataSource.Columns.Add(Me.ParentCol, GetType(String))
				End If
			End If
			Try
				For Each o00_0__O As o00_0__O In Me.Additions
					o00_0__O.oo__.0O00.(True)
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).DataType)
					fxDataSource.Columns(o00_0__O.o0o.OooOOo0__.()).MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).MaxLength
				Next
			Finally
				Dim enumerator As IEnumerator(Of o00_0__O)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				For Each o0o_ As o0o_ In Me.Totals
					If o0o_.o0oO._o_.() = AggregateType.Count Then
						fxDataSource.Columns.Add(o0o_.Oo0oO0oOO_.0_o.(), GetType(Integer))
					Else
						fxDataSource.Columns.Add(o0o_.Oo0oO0oOO_.0_o.(), GetType(Double))
					End If
				Next
			Finally
				Dim enumerator2 As List(Of o0o_).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			fxDataSource.Columns.Add("sys_Hierarchy_Level", GetType(Integer))
			Return fxDataSource
		End Function

		' Token: 0x04000168 RID: 360
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000169 RID: 361
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400016A RID: 362
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400016B RID: 363
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400016C RID: 364
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As List(Of o0o_)

		' Token: 0x0400016D RID: 365
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400016E RID: 366
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400016F RID: 367
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000170 RID: 368
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000171 RID: 369
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000172 RID: 370
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000173 RID: 371
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000174 RID: 372
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x04000175 RID: 373
		Private <<EMPTY_NAME>> As HashSet(Of String)
	End Class
End Namespace
