Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000307 RID: 775
	<ComVisible(True)>
	<oO0oooo("0593")>
	Public Class Row
		' Token: 0x060028C0 RID: 10432 RVA: 0x00111878 File Offset: 0x0010FA78
		Friend Sub New(A_0 As Table, A_1 As Integer)
			Me.oo_.o_O_OO0. = -1
			Me.Table = A_0
			Me.oo_.o_O_OO0. = A_1
			Dim o_oOooO_O As O_oOooO_O = A_0.foxGrid
			If o_oOooO_O.Rows(o_oOooO_O.Rows.Fixed + A_1).DataIndex > -1 Then
				Me.oo_.o_O_OO0. = A_0.View.O0O_0_0__.0O.(o_oOooO_O.Rows(o_oOooO_O.Rows.Fixed + A_1).DataIndex)
				Me.oo_.o_O_OO0. = Me.oo_.o_O_OO0..Row
			End If
		End Sub

		' Token: 0x060028C1 RID: 10433 RVA: 0x00111908 File Offset: 0x0010FB08
		Friend Sub New(A_0 As Table, A_1 As DataRowView)
			Me.oo_.o_O_OO0. = -1
			Me.Table = A_0
			Me.oo_.o_O_OO0. = A_1
			If Me.oo_.o_O_OO0. IsNot Nothing Then
				Me.oo_.o_O_OO0. = Me.oo_.o_O_OO0..Row
			End If
		End Sub

		' Token: 0x060028C2 RID: 10434 RVA: 0x0011193E File Offset: 0x0010FB3E
		Friend Sub New(A_0 As Table, A_1 As DataRow)
			Me.oo_.o_O_OO0. = -1
			Me.Table = A_0
			Me.oo_.o_O_OO0. = A_1
		End Sub

		' Token: 0x17000987 RID: 2439
		' (get) Token: 0x060028C3 RID: 10435 RVA: 0x0011195B File Offset: 0x0010FB5B
		' (set) Token: 0x060028C4 RID: 10436 RVA: 0x00111963 File Offset: 0x0010FB63
		<oO0oooo("1585")>
		Public Property Table As Table
			Get
				Return Me.oo_.o_O_OO0.
			End Get
			Private Set(value As Table)
				Me.oo_.o_O_OO0. = value
			End Set
		End Property

		' Token: 0x17000988 RID: 2440
		' (get) Token: 0x060028C5 RID: 10437 RVA: 0x0011196C File Offset: 0x0010FB6C
		<oO0oooo("0594")>
		Public ReadOnly Property DataRow As DataRow
			Get
				Dim result As DataRow
				If Me.oo_.o_O_OO0. Is Nothing Then
					result = Nothing
				Else
					result = New DataRow(Me.oo_.o_O_OO0.)
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000989 RID: 2441
		' (get) Token: 0x060028C6 RID: 10438 RVA: 0x00111992 File Offset: 0x0010FB92
		Friend ReadOnly Property BaseDataRow As DataRow
			Get
				Return Me.oo_.o_O_OO0.
			End Get
		End Property

		' Token: 0x1700098A RID: 2442
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(ColumnName As String) As Object
			Get
				Dim result As Object
				If Me.oo_.o_O_OO0. Is Nothing Then
					Dim num As Integer = Me.Table.foxGrid.Rows.Fixed + Me.oo_.o_O_OO0.
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Table.foxGrid(num, ColumnName))
					If objectValue Is DBNull.Value Then
						result = Nothing
					Else
						result = objectValue
					End If
				ElseIf Me.oo_.o_O_OO0..IsNull(ColumnName) Then
					Dim dataType As Type = Me.oo_.o_O_OO0..Table.Columns(ColumnName).DataType
					If dataType Is GetType(String) Then
						result = ""
					ElseIf dataType Is GetType(Boolean) Then
						result = False
					ElseIf dataType Is GetType(DateTime) Then
						result = Nothing
					Else
						result = 0
					End If
				Else
					If Me.oo_.o_O_OO0..Table.Columns(ColumnName).DataType Is GetType(DateTime) Then
						Dim dateTime As DateTime = Conversions.ToDate(Me.oo_.o_O_OO0.(ColumnName))
						Select Case OO_00oOO.DataTables(Me.oo_.o_O_OO0..Table.TableName).DataCols(ColumnName).DateTimeFormat
							Case 0
								Return dateTime.[Date]
							Case 1
								dateTime = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 2
								Return New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
							Case 3
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 4
								Return dateTime
						End Select
					End If
					result = Me.oo_.o_O_OO0.(ColumnName)
				End If
				Return result
			End Get
			Set(value As Object)
				If value IsNot Nothing AndAlso value.[GetType]() Is GetType(DateTime) AndAlso DateTime.Compare(Conversions.ToDate(value), DateTime.MinValue) = 0 Then
					value = Nothing
				End If
				If Not o_O_o_oOoo__.oO.O_..Contains(ColumnName) Then
					If Me.oo_.o_O_OO0. Is Nothing Then
						Me.Table.foxGrid.SetData(Me.oo_.o_O_OO0. + Me.Table.foxGrid.Rows.Fixed, ColumnName, RuntimeHelpers.GetObjectValue(value), False)
						Return
					End If
					If value Is Nothing Then
						value = DBNull.Value
					End If
					If Me.oo_.o_O_OO0..Table.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse Operators.CompareString(ColumnName, OO_00oOO.DataTables(Me.oo_.o_O_OO0..Table.TableName).O_.__0., True) <> 0 Then
						If Me.oo_.o_O_OO0..HasVersion(DataRowVersion.Proposed) Then
							Me.oo_.o_O_OO0..EndEdit()
							If Me.oo_.o_O_OO0..HasVersion(DataRowVersion.Proposed) Then
								Return
							End If
						End If
						If String.Compare(Me.oo_.o_O_OO0.(ColumnName).ToString(), value.ToString(), False) <> 0 Then
							Me.oo_.o_O_OO0.(ColumnName) = RuntimeHelpers.GetObjectValue(value)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700098B RID: 2443
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(Column As Col) As Object
			Get
				Return Me(Column.Name)
			End Get
			Set(value As Object)
				Me(Column.Name) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x1700098C RID: 2444
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(Col As Integer) As Object
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.Table.foxGrid
				Return Me(o_oOooO_O.Cols(Col + o_oOooO_O.Cols.Fixed).Name)
			End Get
			Set(value As Object)
				Dim o_oOooO_O As O_oOooO_O = Me.Table.foxGrid
				Me(o_oOooO_O.Cols(Col + o_oOooO_O.Cols.Fixed).Name) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x1700098D RID: 2445
		' (get) Token: 0x060028CD RID: 10445 RVA: 0x00111D80 File Offset: 0x0010FF80
		<oO0oooo("0595")>
		Public ReadOnly Property IsNull(ColumnName As String) As Boolean
			Get
				Dim result As Boolean
				If Me.oo_.o_O_OO0. Is Nothing Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Table.foxGrid(Me.Table.foxGrid.Rows.Fixed + Me.oo_.o_O_OO0., ColumnName))
					result = (objectValue Is DBNull.Value OrElse objectValue Is Nothing)
				Else
					result = Me.oo_.o_O_OO0..IsNull(ColumnName)
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700098E RID: 2446
		' (get) Token: 0x060028CE RID: 10446 RVA: 0x00111DE8 File Offset: 0x0010FFE8
		<oO0oooo("0595")>
		Public ReadOnly Property IsNull(Col As Integer) As Boolean
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.Table.foxGrid
				Return Me.get_IsNull(o_oOooO_O.Cols(Col + o_oOooO_O.Cols.Fixed).Name)
			End Get
		End Property

		' Token: 0x1700098F RID: 2447
		' (get) Token: 0x060028CF RID: 10447 RVA: 0x00111E24 File Offset: 0x00110024
		<oO0oooo("0595")>
		Public ReadOnly Property IsNull(Col As Col) As Boolean
			Get
				Return Me.get_IsNull(Col.Name)
			End Get
		End Property

		' Token: 0x17000990 RID: 2448
		' (get) Token: 0x060028D0 RID: 10448 RVA: 0x00111E32 File Offset: 0x00110032
		<oO0oooo("0596")>
		Public ReadOnly Property IsGroup As Boolean
			Get
				Return Me.oo_.o_O_OO0. Is Nothing
			End Get
		End Property

		' Token: 0x17000991 RID: 2449
		' (get) Token: 0x060028D1 RID: 10449 RVA: 0x00111E40 File Offset: 0x00110040
		<oO0oooo("0598")>
		Public ReadOnly Property Level As Integer
			Get
				Dim result As Integer
				If Me.oo_.o_O_OO0. IsNot Nothing Then
					result = Integer.MinValue
				Else
					Dim num As Integer = Me.Table.foxGrid.Rows.Fixed + Me.oo_.o_O_OO0.
					If Me.Table.foxGrid.Rows(num).Node IsNot Nothing Then
						result = Me.Table.foxGrid.Rows(num).Node.Level
					Else
						result = Integer.MinValue
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000992 RID: 2450
		' (get) Token: 0x060028D2 RID: 10450 RVA: 0x00111EC4 File Offset: 0x001100C4
		<oO0oooo("3386")>
		Public ReadOnly Property Hierarchy As Integer
			Get
				Dim result As Integer
				If Not Me.Table.GridTreeVisible Then
					result = -1
				ElseIf Me.Table.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level") Then
					If Not Me.oo_.o_O_OO0..IsNull("sys_Hierarchy_Level") Then
						result = Conversions.ToInteger(Me.oo_.o_O_OO0.("sys_Hierarchy_Level"))
					Else
						result = -1
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000993 RID: 2451
		' (get) Token: 0x060028D3 RID: 10451 RVA: 0x00111F30 File Offset: 0x00110130
		' (set) Token: 0x060028D4 RID: 10452 RVA: 0x00111F88 File Offset: 0x00110188
		<oO0oooo("3386")>
		Public Property Collapsed As Boolean
			Get
				Dim num As Integer = Me.Table.foxGrid.Rows.Fixed + Me.Index
				Return Me.Table.Grid.GetUserData(num, Me.Table.Grid.Cols.Fixed - 1) IsNot Nothing
			End Get
			Set(value As Boolean)
				Dim num As Integer = Me.Table.foxGrid.Rows.Fixed + Me.Index
				Dim flag As Boolean = Me.Table.Grid.GetUserData(num, Me.Table.Grid.Cols.Fixed - 1) Is Nothing
				If value <> Not flag Then
					Me.Table.foxGrid.O_._.(num, False, False)
				End If
			End Set
		End Property

		' Token: 0x17000994 RID: 2452
		' (get) Token: 0x060028D5 RID: 10453 RVA: 0x00111FF8 File Offset: 0x001101F8
		<oO0oooo("3386")>
		Public ReadOnly Property HasChild As Boolean
			Get
				If Me.Table.HierarchyData AndAlso Me.Index < Me.Table.View.Count - 1 Then
					Dim row As Row = Me.Table.Rows(Me.Index + 1)
					If Conversions.ToInteger(Me("sys_Hierarchy_Level")) < Conversions.ToInteger(row("sys_Hierarchy_Level")) Then
						Return True
					End If
				End If
				Return False
			End Get
		End Property

		' Token: 0x060028D6 RID: 10454 RVA: 0x00112070 File Offset: 0x00110270
		<oO0oooo("3386")>
		Public Function GetChildren(Optional IncludeSub As Boolean = False) As List(Of Row)
			Dim num As Integer = Me.Index + 1
			Dim num2 As Integer = Me.Table.Rows.Count - 1
			Dim list As List(Of Row) = New List(Of Row)()
			Dim num3 As Integer = Me.Hierarchy + 1
			If Me.Table.HierarchyData Then
				Dim num4 As Integer = num
				Dim num5 As Integer = num2
				For i As Integer = num4 To num5
					Dim hierarchy As Integer = Me.Table.Rows(i).Hierarchy
					If hierarchy = num3 OrElse (IncludeSub AndAlso hierarchy > num3) Then
						list.Add(Me.Table.Rows(i))
					ElseIf hierarchy < num3 Then
						Exit For
					End If
				Next
			End If
			Return list
		End Function

		' Token: 0x17000995 RID: 2453
		' (get) Token: 0x060028D7 RID: 10455 RVA: 0x00112110 File Offset: 0x00110310
		<oO0oooo("3386")>
		Public ReadOnly Property Parent As Row
			Get
				Dim num As Integer = Me.Index - 1
				Dim num2 As Integer = Me.Hierarchy - 1
				For i As Integer = num To 0 Step -1
					If Me.Table.Rows(i).Hierarchy = num2 Then
						Return Me.Table.Rows(i)
					End If
				Next
				Return Nothing
			End Get
		End Property

		' Token: 0x17000996 RID: 2454
		' (get) Token: 0x060028D8 RID: 10456 RVA: 0x0011216C File Offset: 0x0011036C
		<oO0oooo("3386")>
		Public ReadOnly Property PrevSlibing As Row
			Get
				Dim index As Integer = Me.Index
				Dim hierarchy As Integer = Me.Hierarchy
				For i As Integer = index - 1 To 0 Step -1
					Dim hierarchy2 As Integer = Me.Table.Rows(i).Hierarchy
					If hierarchy2 = Me.Hierarchy Then
						Return Me.Table.Rows(i)
					End If
					If hierarchy2 < Me.Hierarchy Then
						Exit For
					End If
				Next
				Return Nothing
			End Get
		End Property

		' Token: 0x17000997 RID: 2455
		' (get) Token: 0x060028D9 RID: 10457 RVA: 0x001121D4 File Offset: 0x001103D4
		<oO0oooo("3386")>
		Public ReadOnly Property NextSlibing As Row
			Get
				Dim index As Integer = Me.Index
				Dim hierarchy As Integer = Me.Hierarchy
				Dim num As Integer = index + 1
				Dim num2 As Integer = Me.Table.Rows.Count - 1
				For i As Integer = num To num2
					Dim hierarchy2 As Integer = Me.Table.Rows(i).Hierarchy
					If hierarchy2 = Me.Hierarchy Then
						Return Me.Table.Rows(i)
					End If
					If hierarchy2 < Me.Hierarchy Then
						Exit For
					End If
				Next
				Return Nothing
			End Get
		End Property

		' Token: 0x17000998 RID: 2456
		' (get) Token: 0x060028DA RID: 10458 RVA: 0x00112250 File Offset: 0x00110450
		<oO0oooo("3386")>
		Public ReadOnly Property Visible As Boolean
			Get
				Dim result As Boolean
				If Not Me.Table.GridTreeVisible Then
					result = True
				Else
					Dim num As Integer = 1
					If Me.oo_.o_O_OO0. >= 0 Then
						num = Me.Table.foxGrid.Rows.Fixed + Me.oo_.o_O_OO0.
					ElseIf Me.oo_.o_O_OO0. IsNot Nothing Then
						num = Me.Table.foxGrid.Rows.Fixed + CType(Me.oo_.o_O_OO0..DataView, IList).IndexOf(Me.oo_.o_O_OO0.)
					End If
					If num >= 0 Then
						result = Me.Table.foxGrid.Rows(num).Visible
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000999 RID: 2457
		' (get) Token: 0x060028DB RID: 10459 RVA: 0x001122F0 File Offset: 0x001104F0
		' (set) Token: 0x060028DC RID: 10460 RVA: 0x00112333 File Offset: 0x00110533
		<oO0oooo("0597")>
		Public Property Locked As Boolean
			Get
				Dim result As Boolean
				If Me.oo_.o_O_OO0. Is Nothing Then
					result = False
				Else
					Dim dataRow As DataRow = Me.oo_.o_O_OO0.
					result = (Not dataRow.IsNull("_Locked") AndAlso Conversions.ToBoolean(dataRow("_Locked")))
				End If
				Return result
			End Get
			Set(value As Boolean)
				If Me.oo_.o_O_OO0. IsNot Nothing Then
					New DataRow(Me.oo_.o_O_OO0.).Locked = value
					Main.OO_O.o..O.ooO0. = True
				End If
			End Set
		End Property

		' Token: 0x060028DD RID: 10461 RVA: 0x0011235C File Offset: 0x0011055C
		<oO0oooo("0599")>
		Public Function Delete() As Boolean
			Return Me.oo_.o_O_OO0. IsNot Nothing AndAlso Me.DataRow.Delete()
		End Function

		' Token: 0x060028DE RID: 10462 RVA: 0x00112382 File Offset: 0x00110582
		<oO0oooo("2736")>
		Public Sub Remove()
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.Remove()
			End If
		End Sub

		' Token: 0x060028DF RID: 10463 RVA: 0x00112398 File Offset: 0x00110598
		<oO0oooo("0600")>
		Public Function Clone() As Row
			Dim result As Row
			If Me.oo_.o_O_OO0. Is Nothing Then
				result = Nothing
			Else
				Dim dataRow As DataRow = Me.Table.DataTable.NewRow()
				If dataRow IsNot Nothing Then
					Try
						For Each obj As Object In Me.oo_.o_O_OO0..Table.Columns
							Dim dataColumn As DataColumn = CType(obj, DataColumn)
							If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) AndAlso dataRow.get_IsNull(dataColumn.ColumnName) Then
								dataRow(dataColumn.ColumnName) = RuntimeHelpers.GetObjectValue(Me.oo_.o_O_OO0.(dataColumn))
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Me.oo_.o_O_OO0..Table.Rows.Add(dataRow.BaseRow)
					If Me.Table.IsCopy Then
						Dim num As Integer = Me.Table.View.o_o.O0ooOo.(dataRow.BaseRow)
						If num >= 0 Then
							Me.Table.View.Position = num
						End If
					Else
						Me.Table.View.Position = Me.Table.View.Count - 1
					End If
					result = New Row(Me.Table, dataRow.BaseRow)
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x060028E0 RID: 10464 RVA: 0x001124EC File Offset: 0x001106EC
		Public Function Equals(r1 As Row) As Boolean
			Dim result As Boolean
			If r1 Is Nothing Then
				result = False
			ElseIf Me.oo_.o_O_OO0. IsNot Nothing Then
				result = (Me.oo_.o_O_OO0. Is r1.oo_.o_O_OO0.)
			Else
				result = (r1.oo_.o_O_OO0. Is Nothing AndAlso Me.Table Is r1.Table AndAlso Me.oo_.o_O_OO0. = r1.oo_.o_O_OO0.)
			End If
			Return result
		End Function

		' Token: 0x1700099A RID: 2458
		' (get) Token: 0x060028E1 RID: 10465 RVA: 0x00112548 File Offset: 0x00110748
		<oO0oooo("1539")>
		Public ReadOnly Property Index As Integer
			Get
				Dim result As Integer
				If Me.oo_.o_O_OO0. IsNot Nothing Then
					result = CType(Me.oo_.o_O_OO0..DataView, IList).IndexOf(Me.oo_.o_O_OO0.)
				ElseIf Me.oo_.o_O_OO0. >= 0 Then
					result = Me.oo_.o_O_OO0.
				ElseIf Me.oo_.o_O_OO0. IsNot Nothing Then
					result = Me.Table.View.o_o.O0ooOo.(Me.oo_.o_O_OO0.)
				Else
					result = -1
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700099B RID: 2459
		' (get) Token: 0x060028E2 RID: 10466 RVA: 0x001125AC File Offset: 0x001107AC
		Private ReadOnly Property GetPosition As Integer
			Get
				Dim index As Integer = Me.Index
				Dim c1FlexGrid As C1FlexGrid = Me.Table.foxGrid
				Dim fixed As Integer = c1FlexGrid.Rows.Fixed
				Dim num As Integer = c1FlexGrid.Rows.Count - 1
				For i As Integer = fixed To num
					If c1FlexGrid.Rows(i).DataIndex = index Then
						Return i
					End If
				Next
				Return -1
			End Get
		End Property

		' Token: 0x1700099C RID: 2460
		' (get) Token: 0x060028E3 RID: 10467 RVA: 0x00112614 File Offset: 0x00110814
		' (set) Token: 0x060028E4 RID: 10468 RVA: 0x0011265C File Offset: 0x0011085C
		<oO0oooo("1638")>
		Public Property Checked As Boolean
			Get
				Dim num As Integer = Me.GetPosition
				Return num >= Me.Table.foxGrid.Rows.Fixed AndAlso Me.Table.foxGrid.GetCellCheck(num, 0) = 1
			End Get
			Set(value As Boolean)
				Dim num As Integer
				Dim num5 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					If Me.Checked = value Then
						GoTo IL_25A
					End If
					IL_15:
					num2 = 4
					Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.Table, Me, Nothing, Nothing)
					IL_26:
					num2 = 5
					If Me.oo_.o_O_OO0. Is Nothing Then
						GoTo IL_25A
					End If
					IL_33:
					num2 = 7
					Dim a_ As String = "BeforeCheckRow"
					IL_3C:
					num2 = 8
					If Me.Table.o0__OOo0._oO. IsNot Nothing Then
						GoTo IL_84
					End If
					IL_4B:
					num2 = 9
					O_O0OO.OoO_o.oO0o0O.(Me.Table.DataTable.o_0_00_.oo0O0., a_, New Object() { rowColEventArgs }, False, Me.Table.DataTable.Name, False)
					GoTo IL_B6
					IL_84:
					num2 = 11
					O_O0OO.OoO_o.oO0o0O.(Me.Table.o0__OOo0._oO., a_, New Object() { rowColEventArgs }, False, Me.Table.DataTable.Name, False)
					IL_B6:
					num2 = 12
					If rowColEventArgs.Cancel OrElse Me.Table.foxGrid.FindForm() Is Nothing OrElse Not Me.Table.DataTable.GlobalHandler.BeforeCheckRow Then
						GoTo IL_10B
					End If
					IL_EA:
					num2 = 13
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColEventArgs }, False, "全局表事件", False)
					IL_10B:
					num2 = 14
					If rowColEventArgs.Cancel Then
						GoTo IL_25A
					End If
					IL_119:
					num2 = 16
					Dim num3 As Integer = Me.GetPosition
					IL_124:
					num2 = 17
					If num3 < Me.Table.foxGrid.Rows.Fixed Then
						GoTo IL_176
					End If
					IL_140:
					num2 = 18
					If Not value Then
						GoTo IL_15F
					End If
					IL_146:
					num2 = 19
					Me.Table.foxGrid.SetCellCheck(num3, 0, 1)
					GoTo IL_176
					IL_15F:
					num2 = 21
					Me.Table.foxGrid.SetCellCheck(num3, 0, 2)
					IL_176:
					num2 = 22
					rowColEventArgs = New RowColEventArgs(Me.Table, Me, Nothing, Nothing)
					IL_188:
					num2 = 23
					a_ = "AfterCheckRow"
					IL_192:
					num2 = 24
					If Me.Table.o0__OOo0._oO. IsNot Nothing Then
						GoTo IL_1DB
					End If
					IL_1A2:
					num2 = 25
					O_O0OO.OoO_o.oO0o0O.(Me.Table.DataTable.o_0_00_.oo0O0., a_, New Object() { rowColEventArgs }, False, Me.Table.DataTable.Name, False)
					GoTo IL_20D
					IL_1DB:
					num2 = 27
					O_O0OO.OoO_o.oO0o0O.(Me.Table.o0__OOo0._oO., a_, New Object() { rowColEventArgs }, False, Me.Table.DataTable.Name, False)
					IL_20D:
					num2 = 28
					If Me.Table.foxGrid.FindForm() Is Nothing OrElse Not Me.Table.DataTable.GlobalHandler.AfterCheckRow Then
						GoTo IL_25A
					End If
					IL_239:
					num2 = 29
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColEventArgs }, False, "全局表事件", False)
					IL_25A:
					GoTo IL_324
					IL_25F:
					Dim num4 As Integer = num5 + 1
					num5 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
					IL_2E5:
					GoTo IL_319
					IL_2E7:
					num5 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_2F7:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_2E7
				End Try
				IL_319:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_324:
				If num5 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x060028E5 RID: 10469 RVA: 0x001129B4 File Offset: 0x00110BB4
		<oO0oooo("1846")>
		Public Function Move(Position As Integer) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim index As Integer = Me.Index
				IL_11:
				num2 = 3
				If Me.Table.DataTable.BaseTable.Columns.Contains("_SortKey") Then
					GoTo IL_52
				End If
				IL_34:
				num2 = 4
				MessageBox.Show("此表不支持移动行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_49:
				num2 = 5
				result = False
				GoTo IL_4C0
				IL_52:
				num2 = 6
				If Operators.CompareString(Me.Table.Sort, "", True) <= 0 Then
					GoTo IL_8B
				End If
				IL_6D:
				num2 = 7
				MessageBox.Show("不能在排序状态下移动行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_82:
				num2 = 8
				result = False
				GoTo IL_4C0
				IL_8B:
				num2 = 9
				If Position >= 0 AndAlso Position <= Me.Table.ooO__oo0O.0.(False) - 1 AndAlso Position <> Me.Index Then
					GoTo IL_B6
				End If
				IL_AC:
				num2 = 10
				result = False
				GoTo IL_4C0
				IL_B6:
				num2 = 11
				Dim moveRowEventArgs As MoveRowEventArgs = New MoveRowEventArgs(Me.Table, index, Position)
				IL_C9:
				num2 = 12
				O_O0OO.OoO_o.oO0o0O.(Me.Table.DataTable.o_0_00_.oo0O0., "BeforeMoveRow", New Object() { moveRowEventArgs }, False, Me.Table.DataTable.Name, False)
				IL_104:
				num2 = 13
				If Not moveRowEventArgs.Cancel Then
					GoTo IL_11A
				End If
				IL_110:
				num2 = 14
				result = False
				GoTo IL_4C0
				IL_11A:
				num2 = 15
				If Me.Table.foxGrid.FindForm() Is Nothing OrElse Not Me.Table.DataTable.GlobalHandler.BeforeMoveRow Then
					GoTo IL_16B
				End If
				IL_146:
				num2 = 16
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeMoveRow", New Object() { moveRowEventArgs }, False, "全局表事件", False)
				IL_16B:
				num2 = 17
				If Not moveRowEventArgs.Cancel Then
					GoTo IL_181
				End If
				IL_177:
				num2 = 18
				result = False
				GoTo IL_4C0
				IL_181:
				num2 = 19
				If Position <> 0 Then
					GoTo IL_1ED
				End If
				IL_187:
				num2 = 20
				If Me.Table.ooO__oo0O.0.(False) <= 0 Then
					GoTo IL_1DE
				End If
				IL_199:
				num2 = 21
				Dim row As DataRow = Me.Table.View.O0O_0_0__.0O.(0).Row
				IL_1B4:
				num2 = 22
				Dim num3 As Decimal = Decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row("_SortKey"))), 1D)
				GoTo IL_339
				IL_1DE:
				num2 = 24
				num3 = 1D
				GoTo IL_339
				IL_1ED:
				num2 = 26
				If Position <> Me.Table.ooO__oo0O.0.(False) - 1 Then
					GoTo IL_257
				End If
				IL_201:
				num2 = 27
				Dim row2 As DataRow = Me.Table.View.O0O_0_0__.0O.(Me.Table.View.Count - 1).Row
				IL_22D:
				num2 = 28
				num3 = Decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row2("_SortKey"))), 1D)
				GoTo IL_339
				IL_257:
				num2 = 30
				If Position <= Me.Index Then
					GoTo IL_29D
				End If
				IL_263:
				num2 = 31
				Dim row3 As DataRow = Me.Table.View.O0O_0_0__.0O.(Position).Row
				IL_27E:
				num2 = 32
				Dim row4 As DataRow = Me.Table.View.O0O_0_0__.0O.(Position + 1).Row
				GoTo IL_2D5
				IL_29D:
				num2 = 34
				row3 = Me.Table.View.O0O_0_0__.0O.(Position - 1).Row
				IL_2BA:
				num2 = 35
				row4 = Me.Table.View.O0O_0_0__.0O.(Position).Row
				IL_2D5:
				num2 = 36
				Dim num4 As Decimal = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row3("_SortKey")))
				IL_2F0:
				num2 = 37
				Dim num5 As Decimal = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row4("_SortKey")))
				IL_30B:
				num2 = 38
				num3 = Me.Table.O.__O0o0.(Me.oo_.o_O_OO0., New Decimal() { num4, num5 })
				IL_339:
				num2 = 39
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_353:
					num2 = 40
					If table.DataTable.BaseTable Is Me.oo_.o_O_OO0..Table Then
						IL_36F:
						num2 = 41
						table.View.SuspendBinding()
					End If
					IL_37E:
					num2 = 42
				End While
				IL_38A:
				num2 = 43
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_398:
				num2 = 44
				Me.oo_.o_O_OO0.("_SortKey") = num3
				IL_3B2:
				num2 = 45
				Dim enumerator2 As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator2.MoveNext()
					Dim table2 As Table = enumerator2.Current
					IL_3CC:
					num2 = 46
					If table2.DataTable.BaseTable Is Me.oo_.o_O_OO0..Table Then
						IL_3E8:
						num2 = 47
						table2.View.ResumeBinding()
						IL_3F7:
						num2 = 48
						table2.ResetCurrentItem()
					End If
					IL_401:
					num2 = 49
				End While
				IL_40D:
				num2 = 50
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_41B:
				num2 = 51
				Me.Table.View.Position = Position
				IL_42F:
				num2 = 52
				O_O0OO.OoO_o.oO0o0O.(Me.Table.DataTable.o_0_00_.oo0O0., "AfterMoveRow", New Object() { moveRowEventArgs }, False, Me.Table.DataTable.Name, False)
				IL_46A:
				num2 = 53
				If Me.Table.foxGrid.FindForm() Is Nothing OrElse Not Me.Table.DataTable.GlobalHandler.AfterMoveRow Then
					GoTo IL_4BB
				End If
				IL_496:
				num2 = 54
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterMoveRow", New Object() { moveRowEventArgs }, False, "全局表事件", False)
				IL_4BB:
				num2 = 55
				result = True
				IL_4C0:
				GoTo IL_5F2
				IL_4C5:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_5B3:
				GoTo IL_5E7
				IL_5B5:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5C5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5B5
			End Try
			IL_5E7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5F2:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060028E6 RID: 10470 RVA: 0x00112FD8 File Offset: 0x001111D8
		Public Sub Save()
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.Save()
			End If
		End Sub

		' Token: 0x060028E7 RID: 10471 RVA: 0x00112FED File Offset: 0x001111ED
		<oO0oooo("2643")>
		Public Sub Reject()
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.RejectChanges()
			End If
		End Sub

		' Token: 0x060028E8 RID: 10472 RVA: 0x00113002 File Offset: 0x00111202
		Public Sub Accept()
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.Accept()
			End If
		End Sub

		' Token: 0x060028E9 RID: 10473 RVA: 0x00113017 File Offset: 0x00111217
		<oO0oooo("2895")>
		Public Sub Load(Optional blnSave As Boolean = True)
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.Load(blnSave)
			End If
		End Sub

		' Token: 0x060028EA RID: 10474 RVA: 0x00113030 File Offset: 0x00111230
		Public Sub Refresh()
			Dim num As Integer = Me.Index + Me.Table.foxGrid.Rows.Fixed
			Me.Table.foxGrid.Rows(num).Invalidate()
		End Sub

		' Token: 0x060028EB RID: 10475 RVA: 0x00113078 File Offset: 0x00111278
		Public Sub Refresh(ColName As String)
			Dim num As Integer = Me.Index + Me.Table.foxGrid.Rows.Fixed
			If Me.Table.foxGrid.Cols.Contains(ColName) Then
				Dim index As Integer = Me.Table.foxGrid.Cols(ColName).Index
				Me.Table.foxGrid.Invalidate(num, index)
			End If
		End Sub

		' Token: 0x060028EC RID: 10476 RVA: 0x001130E8 File Offset: 0x001112E8
		Public Sub EndEdit()
			If Me.DataRow IsNot Nothing Then
				Me.DataRow.BaseRow.EndEdit()
			End If
		End Sub

		' Token: 0x060028ED RID: 10477 RVA: 0x00113104 File Offset: 0x00111304
		<oO0oooo("3386")>
		Public Function GetValue(colName As String) As Object
			Dim dataRow As DataRow = Me.oo_.o_O_OO0.
			Dim result As Object
			If dataRow Is Nothing Then
				result = Nothing
			ElseIf Me.Table.GridTreeVisible AndAlso Me.Table.o.0ooOO_0__..Contains(colName) Then
				If Me.Table.o.0ooOO_0__..ContainsKey(dataRow) Then
					result = Me.Table.o.0ooOO_0__.(dataRow)(colName)
				Else
					result = dataRow(colName)
				End If
			Else
				result = dataRow(colName)
			End If
			Return result
		End Function

		' Token: 0x040010CA RID: 4298
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040010CB RID: 4299
		Private <<EMPTY_NAME>> As DataRowView

		' Token: 0x040010CC RID: 4300
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x040010CD RID: 4301
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
