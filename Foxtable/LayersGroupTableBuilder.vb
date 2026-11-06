Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000A4 RID: 164
	<ComVisible(True)>
	<oO0oooo("3368")>
	Public Class LayersGroupTableBuilder
		' Token: 0x1700019E RID: 414
		' (get) Token: 0x06000647 RID: 1607 RVA: 0x000209FC File Offset: 0x0001EBFC
		' (set) Token: 0x06000648 RID: 1608 RVA: 0x00020A04 File Offset: 0x0001EC04
		Public Property TableName As String

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x06000649 RID: 1609 RVA: 0x00020A0D File Offset: 0x0001EC0D
		' (set) Token: 0x0600064A RID: 1610 RVA: 0x00020A15 File Offset: 0x0001EC15
		Public Property DataTable As DataTable

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x0600064B RID: 1611 RVA: 0x00020A1E File Offset: 0x0001EC1E
		' (set) Token: 0x0600064C RID: 1612 RVA: 0x00020A26 File Offset: 0x0001EC26
		Public Property PathCol As String

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x0600064D RID: 1613 RVA: 0x00020A2F File Offset: 0x0001EC2F
		' (set) Token: 0x0600064E RID: 1614 RVA: 0x00020A37 File Offset: 0x0001EC37
		Public Property NameCol As String

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x0600064F RID: 1615 RVA: 0x00020A40 File Offset: 0x0001EC40
		' (set) Token: 0x06000650 RID: 1616 RVA: 0x00020A48 File Offset: 0x0001EC48
		Public Property Separator As String

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x06000651 RID: 1617 RVA: 0x00020A54 File Offset: 0x0001EC54
		Friend ReadOnly Property Separator2 As Char
			Get
				Dim result As Char
				If Operators.CompareString(Me.Separator, "", True) > 0 Then
					result = Me.Separator(0)
				End If
				Return result
			End Get
		End Property

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x06000652 RID: 1618 RVA: 0x00020A83 File Offset: 0x0001EC83
		' (set) Token: 0x06000653 RID: 1619 RVA: 0x00020A8B File Offset: 0x0001EC8B
		Public Property lengths As Object()

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000654 RID: 1620 RVA: 0x00020A94 File Offset: 0x0001EC94
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property lengths2 As Integer()
			Get
				Dim list As List(Of Integer) = New List(Of Integer)()
				Dim result As Integer()
				If Me.lengths Is Nothing Then
					result = list.ToArray()
				Else
					Dim array As Object() = Me.lengths
					For i As Integer = 0 To array.Length - 1
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(array(i))
						list.Add(Conversions.ToInteger(objectValue))
					Next
					result = list.ToArray()
				End If
				Return result
			End Get
		End Property

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x06000655 RID: 1621 RVA: 0x00020AEC File Offset: 0x0001ECEC
		' (set) Token: 0x06000656 RID: 1622 RVA: 0x00020AF4 File Offset: 0x0001ECF4
		Friend Property Totals As List(Of o0o_)

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x06000657 RID: 1623 RVA: 0x00020AFD File Offset: 0x0001ECFD
		' (set) Token: 0x06000658 RID: 1624 RVA: 0x00020B05 File Offset: 0x0001ED05
		Public Property Filter As String

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x06000659 RID: 1625 RVA: 0x00020B0E File Offset: 0x0001ED0E
		' (set) Token: 0x0600065A RID: 1626 RVA: 0x00020B16 File Offset: 0x0001ED16
		Public Property GridTree As Boolean

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x0600065B RID: 1627 RVA: 0x00020B1F File Offset: 0x0001ED1F
		' (set) Token: 0x0600065C RID: 1628 RVA: 0x00020B27 File Offset: 0x0001ED27
		Public Property ExpandTo As Integer

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x0600065D RID: 1629 RVA: 0x00020B30 File Offset: 0x0001ED30
		' (set) Token: 0x0600065E RID: 1630 RVA: 0x00020B38 File Offset: 0x0001ED38
		Public Property OnlyGroupRows As Boolean

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x0600065F RID: 1631 RVA: 0x00020B41 File Offset: 0x0001ED41
		' (set) Token: 0x06000660 RID: 1632 RVA: 0x00020B49 File Offset: 0x0001ED49
		Public Property PreserveTo As Integer

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x06000661 RID: 1633 RVA: 0x00020B52 File Offset: 0x0001ED52
		' (set) Token: 0x06000662 RID: 1634 RVA: 0x00020B5A File Offset: 0x0001ED5A
		Public Property ShowTreeInPathCol As Boolean

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x06000663 RID: 1635 RVA: 0x00020B63 File Offset: 0x0001ED63
		<oO0oooo("3699")>
		Public ReadOnly Property Additions As MRPExtendTables

		' Token: 0x06000664 RID: 1636 RVA: 0x00020B6C File Offset: 0x0001ED6C
		Public Sub New(A_0 As String, A_1 As DataTable)
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.o_.__OOO0. = New HashSet(Of String)()
			Me.TableName = A_0
			Me.DataTable = A_1
		End Sub

		' Token: 0x06000665 RID: 1637 RVA: 0x00020BBC File Offset: 0x0001EDBC
		Public Sub New(A_0 As String)
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.o_.__OOO0. = New HashSet(Of String)()
			Me.TableName = A_0
		End Sub

		' Token: 0x06000666 RID: 1638 RVA: 0x00020BFA File Offset: 0x0001EDFA
		Public Sub New()
			Me.Totals = New List(Of o0o_)()
			Me.ExpandTo = 0
			Me.PreserveTo = -1
			Me.Additions = New MRPExtendTables()
			Me.o_.__OOO0. = New HashSet(Of String)()
		End Sub

		' Token: 0x06000667 RID: 1639 RVA: 0x00020C31 File Offset: 0x0001EE31
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

		' Token: 0x06000668 RID: 1640 RVA: 0x00020C55 File Offset: 0x0001EE55
		Public Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x06000669 RID: 1641 RVA: 0x00020C60 File Offset: 0x0001EE60
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

		' Token: 0x0600066A RID: 1642 RVA: 0x00020D25 File Offset: 0x0001EF25
		Public Sub AddTotal(Column As String, newName As String)
			Me.AddTotal(Column, newName, AggregateRange.Both, AggregateType.Sum)
		End Sub

		' Token: 0x0600066B RID: 1643 RVA: 0x00020D31 File Offset: 0x0001EF31
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As AggregateRange)
			Me.AddTotal(Column, newName, AggregateRange, AggregateType.Sum)
		End Sub

		' Token: 0x0600066C RID: 1644 RVA: 0x00020D3D File Offset: 0x0001EF3D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As Integer)
			Me.AddTotal(Column, newName, CType(AggregateRange, AggregateRange))
		End Sub

		' Token: 0x0600066D RID: 1645 RVA: 0x00020D48 File Offset: 0x0001EF48
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As AggregateRange, AggregateType As AggregateType)
			If Not Me.o_.__OOO0..Contains(newName) Then
				Me.o_.__OOO0..Add(newName)
				Me.Totals.Add(New o0o_(Column, newName, AggregateRange, AggregateType))
			End If
		End Sub

		' Token: 0x0600066E RID: 1646 RVA: 0x00020D7A File Offset: 0x0001EF7A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Column As String, newName As String, AggregateRange As Integer, AggregateType As Integer)
			Me.AddTotal(Column, newName, CType(AggregateRange, AggregateRange), CType(AggregateType, AggregateType))
		End Sub

		' Token: 0x0600066F RID: 1647 RVA: 0x00020D87 File Offset: 0x0001EF87
		Public Sub AddTotal(Count As Boolean, newName As String)
			Me.AddTotal(True, newName, AggregateRange.Both)
		End Sub

		' Token: 0x06000670 RID: 1648 RVA: 0x00020D92 File Offset: 0x0001EF92
		Public Sub AddTotal(Count As Boolean, newName As String, AggregateRange As AggregateRange)
			If Not Me.o_.__OOO0..Contains(newName) Then
				Me.o_.__OOO0..Add(newName)
				Me.Totals.Add(New o0o_(True, newName, AggregateRange))
			End If
		End Sub

		' Token: 0x06000671 RID: 1649 RVA: 0x00020DC2 File Offset: 0x0001EFC2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTotal(Count As Boolean, newName As String, AggregateRange As Integer)
			Me.AddTotal(Count, newName, CType(AggregateRange, AggregateRange))
		End Sub

		' Token: 0x06000672 RID: 1650 RVA: 0x00020DD0 File Offset: 0x0001EFD0
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
				GoTo IL_674
				IL_B3:
				num2 = 10
				Dim dataTable As DataTable = Me.Ooo.0O.()
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
				GoTo IL_674
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
				If Not Me.GridTree Then
					GoTo IL_660
				End If
				IL_400:
				num2 = 46
				OO_00oOO.DataTables(Me.TableName).oOOO.OOO_0ooO0. = True
				IL_419:
				num2 = 47
				If Not Me.ShowTreeInPathCol AndAlso Operators.CompareString(Me.NameCol, "", True) <> 0 Then
					GoTo IL_4AB
				End If
				IL_437:
				num2 = 48
				If Me.lengths2 Is Nothing OrElse Me.lengths2.Length <= 0 Then
					GoTo IL_47C
				End If
				IL_44D:
				num2 = 49
				OO_00oOO.Tables(Me.TableName).O_.o__ooo.(Me.PathCol, Me.lengths2, Me.ExpandTo)
				GoTo IL_5C8
				IL_47C:
				num2 = 51
				OO_00oOO.Tables(Me.TableName).O_.o__ooo.(Me.PathCol, Me.Separator2, Me.ExpandTo)
				GoTo IL_5C8
				IL_4AB:
				num2 = 53
				OO_00oOO.Tables(Me.TableName).O_.oOoOO0o. = Me.PathCol
				IL_4C9:
				num2 = 54
				OO_00oOO.Tables(Me.TableName).O000__.o_ooo_O. = Me.NameCol
				IL_4E7:
				num2 = 55
				OO_00oOO.Tables(Me.TableName).o__.O0o. = Me.ExpandTo
				IL_505:
				num2 = 56
				If Me.lengths2 Is Nothing OrElse Me.lengths2.Length <= 0 Then
					GoTo IL_575
				End If
				IL_51B:
				num2 = 57
				OO_00oOO.Tables(Me.TableName).OOo0_Oo._OOo.(Me.PathCol, Me.NameCol, Me.lengths2, Me.ExpandTo)
				IL_54B:
				num2 = 58
				OO_00oOO.Tables(Me.TableName).O_OO.oO0_. = String.Join(Of Integer)("", Me.lengths2)
				GoTo IL_5C8
				IL_575:
				num2 = 60
				OO_00oOO.Tables(Me.TableName).O_.o__ooo.(Me.PathCol, Me.NameCol, Me.Separator2, Me.ExpandTo)
				IL_5A5:
				num2 = 61
				OO_00oOO.Tables(Me.TableName).oO0.00. = Conversions.ToString(Me.Separator2)
				IL_5C8:
				num2 = 62
				If Not Me.ShowTreeInPathCol AndAlso Operators.CompareString(Me.NameCol, "", True) <> 0 Then
					GoTo IL_624
				End If
				IL_5E6:
				num2 = 63
				OO_00oOO.DataTables(Me.TableName).OoOo_OoOO0.o. = Me.PathCol
				IL_604:
				num2 = 64
				OO_00oOO.Tables(Me.TableName).OO0o_o0.0oOo0o. = Me.PathCol
				GoTo IL_660
				IL_624:
				num2 = 66
				OO_00oOO.DataTables(Me.TableName).OoOo_OoOO0.o. = Me.NameCol
				IL_642:
				num2 = 67
				OO_00oOO.Tables(Me.TableName).OO0o_o0.0oOo0o. = Me.NameCol
				IL_660:
				num2 = 68
				result = OO_00oOO.DataTables(Me.TableName)
				IL_674:
				GoTo IL_7DA
				IL_679:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_79B:
				GoTo IL_7CF
				IL_79D:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7AD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_79D
			End Try
			IL_7CF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7DA:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000673 RID: 1651 RVA: 0x000215DC File Offset: 0x0001F7DC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06000674 RID: 1652 RVA: 0x000215F6 File Offset: 0x0001F7F6
		Public Function BuildDataSource() As fxDataSource
			Return Me.Ooo.0O.()
		End Function

		' Token: 0x06000675 RID: 1653 RVA: 0x00021600 File Offset: 0x0001F800
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num19 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim fxDataSource As fxDataSource = Me.oo___O0.O.()
				IL_11:
				num2 = 3
				Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, Me.PathCol, DataViewRowState.CurrentRows)
				IL_33:
				num2 = 4
				Dim dictionary As Dictionary(Of DataRow, List(Of DataRow)) = New Dictionary(Of DataRow, List(Of DataRow))()
				IL_3C:
				num2 = 5
				Dim left As String = ""
				IL_45:
				num2 = 6
				Dim num3 As Integer = dataView.Count - 1
				For i As Integer = 0 To num3
					IL_5A:
					num2 = 7
					If Not dataView(i).Row.IsNull(Me.PathCol) Then
						IL_7A:
						num2 = 9
						Dim list As List(Of DataRow) = New List(Of DataRow)()
						IL_84:
						num2 = 10
						Dim text As String = dataView(i)(Me.PathCol).ToString()
						IL_A2:
						num2 = 11
						If i <= 0 OrElse Operators.CompareString(left, text, True) <> 0 Then
							IL_B9:
							num2 = 13
							Dim num4 As Integer
							If Me.lengths2 IsNot Nothing AndAlso Me.lengths2.Length > 0 Then
								IL_D5:
								num2 = 14
								If Me.lengths2.Length = 1 Then
									IL_E3:
									num2 = 15
									num4 = text.Length / Me.lengths2(0) - 1
								Else
									IL_FF:
									num2 = 17
									Dim num5 As Integer = 0
									IL_105:
									num2 = 18
									Dim num6 As Integer = 0
									IL_10B:
									num2 = 19
									num4 = -1
									While True
										IL_147:
										num2 = 21
										If num6 >= text.Length Then
											Exit For
										End If
										IL_113:
										num2 = 22
										num6 += Me.lengths2(num5)
										IL_124:
										num2 = 23
										num4 += 1
										IL_12D:
										num2 = 24
										If num5 < Me.lengths2.Length - 1 Then
											IL_13E:
											num2 = 25
											num5 += 1
										End If
									End While
								End If
							Else
								IL_157:
								num2 = 28
								If Operators.CompareString(Conversions.ToString(Me.Separator2), "", True) > 0 Then
									IL_173:
									num2 = 29
									num4 = text.Split(New Char() { Me.Separator2 }).Length - 1
								End If
							End If
							IL_192:
							num2 = 30
							list.Add(dataView(i).Row)
							IL_1AA:
							num2 = 31
							Dim num7 As Integer = i + 1
							Dim num8 As Integer = dataView.Count - 1
							For j As Integer = num7 To num8
								IL_1C3:
								num2 = 32
								Dim text2 As String = dataView(j)(Me.PathCol).ToString()
								IL_1E1:
								num2 = 33
								If Operators.CompareString(text2, text, True) = 0 Then
									IL_1F0:
									num2 = 34
									list.Add(dataView(j).Row)
								Else
									IL_20A:
									num2 = 36
									If Me.lengths2 IsNot Nothing AndAlso Me.lengths2.Length > 0 Then
										IL_220:
										num2 = 37
										If Not text2.StartsWith(text, StringComparison.OrdinalIgnoreCase) Then
											Exit For
										End If
									Else
										IL_231:
										num2 = 40
										If Operators.CompareString(Conversions.ToString(Me.Separator2), "", True) > 0 Then
											IL_24D:
											num2 = 41
											If Not text2.StartsWith(text + Conversions.ToString(Me.Separator2), StringComparison.OrdinalIgnoreCase) Then
												Exit For
											End If
										End If
									End If
								End If
								IL_26C:
								num2 = 43
							Next
							IL_27E:
							num2 = 44
							Dim dataRow As DataRow = fxDataSource.NewRow()
							IL_28A:
							num2 = 45
							dataRow(Me.PathCol) = RuntimeHelpers.GetObjectValue(dataView(i)(Me.PathCol))
							IL_2B3:
							num2 = 46
							dataRow("sys_Hierarchy_Level") = num4
							IL_2C9:
							num2 = 47
							If Operators.CompareString(Me.NameCol, "", True) > 0 Then
								IL_2E0:
								num2 = 48
								dataRow(Me.NameCol) = RuntimeHelpers.GetObjectValue(dataView(i)(Me.NameCol))
							End If
							IL_309:
							num2 = 49
							Dim enumerator As IEnumerator(Of o00_0__O) = Me.Additions.GetEnumerator()
							While enumerator.MoveNext()
								Dim o00_0__O As o00_0__O = enumerator.Current
								IL_324:
								num2 = 50
								Dim num9 As Integer = o00_0__O.oo__.0O00.().Find(text)
								IL_337:
								num2 = 51
								If num9 >= 0 Then
									IL_33F:
									num2 = 52
									dataRow(o00_0__O.o0o.OooOOo0__.()) = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()(num9)(o00_0__O.oooO00.o00O.()))
								End If
								IL_36F:
								num2 = 53
							End While
							IL_37B:
							num2 = 54
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
							IL_389:
							num2 = 55
							fxDataSource.Rows.Add(dataRow)
							IL_39A:
							num2 = 56
							dictionary(dataRow) = list
							IL_3A8:
							num2 = 57
							left = text
						End If
					End If
					IL_3AF:
					num2 = 58
				Next
				IL_3C1:
				num2 = 59
				Dim num10 As Integer = fxDataSource.Rows.Count - 1
				For k As Integer = 0 To num10
					IL_3DC:
					num2 = 60
					Dim dataRow2 As DataRow = fxDataSource.Rows(k)
					IL_3EF:
					num2 = 61
					Dim num11 As Integer = Conversions.ToInteger(dataRow2("sys_Hierarchy_Level"))
					IL_405:
					num2 = 62
					Dim enumerator2 As List(Of o0o_).Enumerator = Me.Totals.GetEnumerator()
					While enumerator2.MoveNext()
						Dim o0o_ As o0o_ = enumerator2.Current
						IL_423:
						num2 = 63
						Dim num12 As Integer = 0
						IL_429:
						num2 = 64
						Dim num13 As Double = 0.0
						IL_437:
						num2 = 65
						If o0o_.o0oO._o_.() = AggregateType.Min Then
							IL_444:
							num2 = 66
							num13 = Double.MaxValue
						Else
							IL_454:
							num2 = 68
							If o0o_.o0oO._o_.() = AggregateType.Max Then
								IL_461:
								num2 = 69
								num13 = Double.MinValue
							End If
						End If
						IL_46F:
						num2 = 70
						Dim num14 As Integer = k
						IL_476:
						num2 = 71
						Dim num15 As Integer = fxDataSource.Rows.Count - 1
						IL_489:
						num2 = 72
						If o0o_.O0OO_0.O.() = AggregateRange.Self Then
							IL_495:
							num2 = 73
							num15 = k
						Else
							IL_49E:
							num2 = 75
							If o0o_.O0OO_0.O.() = AggregateRange.[Sub] Then
								IL_4AB:
								num2 = 76
								num14 = k + 1
							End If
						End If
						IL_4B4:
						num2 = 77
						Dim num16 As Integer = num14
						Dim num17 As Integer = num15
						For l As Integer = num16 To num17
							IL_4C4:
							num2 = 78
							Dim dataRow3 As DataRow = fxDataSource.Rows(l)
							IL_4D7:
							num2 = 79
							If l > k AndAlso Conversions.ToInteger(dataRow3("sys_Hierarchy_Level")) <= num11 Then
								Exit For
							End If
							IL_4F8:
							num2 = 81
							Dim list2 As List(Of DataRow) = dictionary(dataRow3)
							IL_506:
							num2 = 82
							num12 += list2.Count
							IL_515:
							num2 = 83
							If o0o_.o0oO._o_.() <> AggregateType.Count Then
								IL_525:
								num2 = 85
								Dim enumerator3 As List(Of DataRow).Enumerator = list2.GetEnumerator()
								While enumerator3.MoveNext()
									Dim dataRow4 As DataRow = enumerator3.Current
									IL_53F:
									num2 = 86
									If Not dataRow4.IsNull(o0o_.o0oO._o_.()) Then
										IL_555:
										num2 = 88
										Select Case o0o_.o0oO._o_.()
											Case AggregateType.Sum, AggregateType.Average
												IL_57A:
												num2 = 90
												num13 += Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.()))
											Case AggregateType.Max
												IL_5B8:
												num2 = 94
												num13 = Math.Max(num13, Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.())))
											Case AggregateType.Min
												IL_597:
												num2 = 92
												num13 = Math.Min(num13, Conversions.ToDouble(dataRow4(o0o_.o0oO._o_.())))
										End Select
									End If
									IL_5D7:
									num2 = 96
								End While
								IL_5E6:
								num2 = 97
								CType(enumerator3, IDisposable).Dispose()
							End If
							IL_5F6:
							num2 = 98
						Next
						IL_608:
						num2 = 99
						If o0o_.o0oO._o_.() = AggregateType.Average AndAlso num12 > 0 Then
							IL_61A:
							num2 = 100
							num13 /= CDbl(num12)
						End If
						IL_625:
						num2 = 101
						If o0o_.o0oO._o_.() = AggregateType.Count Then
							IL_632:
							num2 = 102
							dataRow2(o0o_.Oo0oO0oOO_.0_o.()) = num12
						Else
							IL_64C:
							num2 = 104
							dataRow2(o0o_.Oo0oO0oOO_.0_o.()) = num13
						End If
						IL_664:
						num2 = 105
					End While
					IL_673:
					num2 = 106
					CType(enumerator2, IDisposable).Dispose()
					IL_683:
					num2 = 107
				Next
				IL_695:
				num2 = 108
				dictionary.Clear()
				IL_69F:
				num2 = 109
				result = fxDataSource
				IL_6A5:
				GoTo IL_8AF
				IL_6AA:
				Dim num18 As Integer = num19 + 1
				num19 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18)
				IL_870:
				GoTo IL_8A4
				IL_872:
				num19 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_882:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num19 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_872
			End Try
			IL_8A4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8AF:
			If num19 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000676 RID: 1654 RVA: 0x00021EE4 File Offset: 0x000200E4
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim fxDataSource As fxDataSource = New fxDataSource()
			fxDataSource.Columns.Add(Me.PathCol, GetType(String))
			If Operators.CompareString(Me.NameCol, "", True) > 0 Then
				fxDataSource.Columns.Add(Me.NameCol, GetType(String))
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

		' Token: 0x040001A2 RID: 418
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001A3 RID: 419
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040001A4 RID: 420
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001A5 RID: 421
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001A6 RID: 422
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001A7 RID: 423
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x040001A8 RID: 424
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As List(Of o0o_)

		' Token: 0x040001A9 RID: 425
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001AA RID: 426
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001AB RID: 427
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040001AC RID: 428
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001AD RID: 429
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040001AE RID: 430
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001AF RID: 431
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x040001B0 RID: 432
		Private <<EMPTY_NAME>> As HashSet(Of String)
	End Class
End Namespace
