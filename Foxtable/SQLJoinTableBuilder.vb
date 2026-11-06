Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000239 RID: 569
	<oO0oooo("2314")>
	<ComVisible(True)>
	Public Class SQLJoinTableBuilder
		' Token: 0x06001A78 RID: 6776 RVA: 0x000AA6B8 File Offset: 0x000A88B8
		Public Sub New(A_0 As String, A_1 As String)
			Me.oOo0OO._Ooo0_o. = 30
			Me.Oo.Oo__00. = True
			Me.Oo.Oo__00. = New List(Of SQLJoinTableBuilder)()
			Me.oO._00OO0. = New List(Of SQLJoinTableBuilder)()
			Me.OoO0_ooO_.ooO0. = New List(Of SQLJoinTableBuilder)()
			Me.oO_0o_.oOO0. = New List(Of oo0O__O0)()
			Me.Oo.Oo__00. = New Dictionary(Of String, String())()
			Me.oO_0o_.oOO0. = DataServerTypeEnum.Access
			Me.TableName = A_0
			Me.BaseTable = A_1
		End Sub

		' Token: 0x170005E4 RID: 1508
		' (get) Token: 0x06001A79 RID: 6777 RVA: 0x000AA726 File Offset: 0x000A8926
		' (set) Token: 0x06001A7A RID: 6778 RVA: 0x000AA72E File Offset: 0x000A892E
		Public Property ConnectionName As String
			Get
				Return Me.oOo0OO._Ooo0_o.
			End Get
			Set(value As String)
				Me.oOo0OO._Ooo0_o. = value
			End Set
		End Property

		' Token: 0x170005E5 RID: 1509
		' (get) Token: 0x06001A7B RID: 6779 RVA: 0x000AA737 File Offset: 0x000A8937
		' (set) Token: 0x06001A7C RID: 6780 RVA: 0x000AA73F File Offset: 0x000A893F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BaseTable As String
			Get
				Return Me.O._0000.
			End Get
			Set(value As String)
				Me.O._0000. = value
			End Set
		End Property

		' Token: 0x170005E6 RID: 1510
		' (get) Token: 0x06001A7D RID: 6781 RVA: 0x000AA748 File Offset: 0x000A8948
		' (set) Token: 0x06001A7E RID: 6782 RVA: 0x000AA750 File Offset: 0x000A8950
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TableName As String
			Get
				Return Me.OoO0_ooO_.ooO0.
			End Get
			Set(value As String)
				Me.OoO0_ooO_.ooO0. = value
			End Set
		End Property

		' Token: 0x170005E7 RID: 1511
		' (get) Token: 0x06001A7F RID: 6783 RVA: 0x000AA759 File Offset: 0x000A8959
		Friend ReadOnly Property AsyncExecute As Boolean
			Get
				Return Thread.CurrentThread.ManagedThreadId <> Main.OO_O.o.
			End Get
		End Property

		' Token: 0x06001A80 RID: 6784 RVA: 0x000AA770 File Offset: 0x000A8970
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddTable(ParamArray args As Object())
			If args.Length >= 4 Then
				Dim leftTable As String = Conversions.ToString(args(0))
				Dim rightTable As String = Conversions.ToString(args(2))
				Dim num As Integer = args.Length
				If num <> 4 Then
					If num <> 5 Then
						Return
					End If
					Dim joinMode As JoinModeEnum = Conversions.ToInteger(args(4))
					If TypeOf args(1)Is String AndAlso TypeOf args(3)Is String Then
						Dim leftCol As String = Conversions.ToString(args(1))
						Dim rightCol As String = Conversions.ToString(args(3))
						Me.AddTable(leftTable, leftCol, rightTable, rightCol, joinMode)
						Return
					End If
					If TypeOf args(1)Is String() AndAlso TypeOf args(3)Is String() Then
						Dim leftCol2 As String() = CType(args(1), String())
						Dim rightCol2 As String() = CType(args(3), String())
						Me.AddTable(leftTable, leftCol2, rightTable, rightCol2, joinMode)
					End If
				Else
					If TypeOf args(1)Is String AndAlso TypeOf args(3)Is String Then
						Dim leftCol3 As String = Conversions.ToString(args(1))
						Dim rightCol3 As String = Conversions.ToString(args(3))
						Me.AddTable(leftTable, leftCol3, rightTable, rightCol3, 0)
						Return
					End If
					If TypeOf args(1)Is String() AndAlso TypeOf args(3)Is String() Then
						Dim leftCol4 As String() = CType(args(1), String())
						Dim rightCol4 As String() = CType(args(3), String())
						Me.AddTable(leftTable, leftCol4, rightTable, rightCol4, 0)
						Return
					End If
				End If
			End If
		End Sub

		' Token: 0x06001A81 RID: 6785 RVA: 0x000AA88C File Offset: 0x000A8A8C
		Public Sub AddTable(LeftTable As String, LeftCol As String, RightTable As String, RightCol As String, Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, New String() { LeftCol }, RightTable, New String() { RightCol }, JoinMode)
			Me.oO_0o_.oOO0..Add(item)
		End Sub

		' Token: 0x06001A82 RID: 6786 RVA: 0x000AA8C4 File Offset: 0x000A8AC4
		Public Sub AddTable(LeftTable As String, LeftCol As String(), RightTable As String, RightCol As String(), Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode)
			Me.oO_0o_.oOO0..Add(item)
		End Sub

		' Token: 0x06001A83 RID: 6787 RVA: 0x000AA8EC File Offset: 0x000A8AEC
		Public Sub AddCols(ParamArray Names As Object())
			If Not(TypeOf Names(Names.Length - 1)Is Boolean) Then
				' The following expression was wrapped in a checked-statement
				For i As Integer = 0 To Names.Length - 1
					Dim text As String = Conversions.ToString(Names(i))
					Me.Oo.Oo__00..Add(text, New String() { text, "0" })
				Next
				Return
			End If
			Dim num As Integer = Names.Length - 2
			If Not Conversions.ToBoolean(Names(Names.Length - 1)) Then
				Dim num2 As Integer = num
				For j As Integer = 0 To num2
					Me.Oo.Oo__00..Add(Names(j).ToString(), New String() { Names(j).ToString(), "0" })
				Next
				Return
			End If
			Dim num3 As Integer = num
			For k As Integer = 0 To num3
				Me.Oo.Oo__00..Add(Names(k).ToString(), New String() { Names(k).ToString(), "1" })
			Next
		End Sub

		' Token: 0x06001A84 RID: 6788 RVA: 0x000AA9DC File Offset: 0x000A8BDC
		Public Sub AddExp(Name As String, Expression As String, Optional Group As Boolean = False)
			If Not Group Then
				Me.Oo.Oo__00..Add(Name, New String() { Expression, "0" })
				Return
			End If
			Me.Oo.Oo__00..Add(Name, New String() { Expression, "1" })
		End Sub

		' Token: 0x170005E8 RID: 1512
		' (get) Token: 0x06001A85 RID: 6789 RVA: 0x000AAA29 File Offset: 0x000A8C29
		' (set) Token: 0x06001A86 RID: 6790 RVA: 0x000AAA31 File Offset: 0x000A8C31
		Public Property Filter As String
			Get
				Return Me.o_OOOO0O.O0.
			End Get
			Set(value As String)
				Me.o_OOOO0O.O0. = value
			End Set
		End Property

		' Token: 0x170005E9 RID: 1513
		' (get) Token: 0x06001A87 RID: 6791 RVA: 0x000AAA3A File Offset: 0x000A8C3A
		' (set) Token: 0x06001A88 RID: 6792 RVA: 0x000AAA42 File Offset: 0x000A8C42
		Public Property Order As String
			Get
				Return Me.O.o__OOo0_O_.
			End Get
			Set(value As String)
				Me.O.o__OOo0_O_. = value
			End Set
		End Property

		' Token: 0x170005EA RID: 1514
		' (get) Token: 0x06001A89 RID: 6793 RVA: 0x000AAA4B File Offset: 0x000A8C4B
		' (set) Token: 0x06001A8A RID: 6794 RVA: 0x000AAA53 File Offset: 0x000A8C53
		Public Property Top As String
			Get
				Return Me.oo.___OOoO00_.
			End Get
			Set(value As String)
				Me.oo.___OOoO00_. = value
			End Set
		End Property

		' Token: 0x170005EB RID: 1515
		' (get) Token: 0x06001A8B RID: 6795 RVA: 0x000AAA5C File Offset: 0x000A8C5C
		' (set) Token: 0x06001A8C RID: 6796 RVA: 0x000AAA64 File Offset: 0x000A8C64
		Public Property CommandTimeOut As Integer
			Get
				Return Me.oOo0OO._Ooo0_o.
			End Get
			Set(value As Integer)
				Me.oOo0OO._Ooo0_o. = value
			End Set
		End Property

		' Token: 0x170005EC RID: 1516
		' (get) Token: 0x06001A8D RID: 6797 RVA: 0x000AAA6D File Offset: 0x000A8C6D
		' (set) Token: 0x06001A8E RID: 6798 RVA: 0x000AAA75 File Offset: 0x000A8C75
		Public Property TableVisible As Boolean
			Get
				Return Me.Oo.Oo__00.
			End Get
			Set(value As Boolean)
				Me.Oo.Oo__00. = value
			End Set
		End Property

		' Token: 0x170005ED RID: 1517
		' (get) Token: 0x06001A8F RID: 6799 RVA: 0x000AAA7E File Offset: 0x000A8C7E
		' (set) Token: 0x06001A90 RID: 6800 RVA: 0x000AAA86 File Offset: 0x000A8C86
		Public Property Caption As String
			Get
				Return Me.OOO0.0OO__.
			End Get
			Set(value As String)
				Me.OOO0.0OO__. = value
			End Set
		End Property

		' Token: 0x170005EE RID: 1518
		' (get) Token: 0x06001A91 RID: 6801 RVA: 0x000AAA8F File Offset: 0x000A8C8F
		' (set) Token: 0x06001A92 RID: 6802 RVA: 0x000AAA97 File Offset: 0x000A8C97
		Public Property Distinct As Boolean
			Get
				Return Me.oO._00OO0.
			End Get
			Set(value As Boolean)
				Me.oO._00OO0. = value
			End Set
		End Property

		' Token: 0x06001A93 RID: 6803 RVA: 0x000AAAA0 File Offset: 0x000A8CA0
		Public Sub Union(Builder As SQLJoinTableBuilder, Optional All As Boolean = False)
			If All Then
				Me.oO._00OO0..Add(Builder)
				Return
			End If
			Me.Oo.Oo__00..Add(Builder)
		End Sub

		' Token: 0x06001A94 RID: 6804 RVA: 0x000AAAC0 File Offset: 0x000A8CC0
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.ConnectionName, "", True) > 0 Then
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
					Me.oO_0o_.oOO0. = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.
					Return
				End If
				If O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(Me.ConnectionName)) Then
						Me.oO_0o_.oOO0. = DataServerTypeEnum.Oracle
						Return
					End If
					If o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.O._o_.()(Me.ConnectionName)) Then
						Me.oO_0o_.oOO0. = DataServerTypeEnum.SqlServer
					End If
				End If
			End If
		End Sub

		' Token: 0x06001A95 RID: 6805 RVA: 0x000AAB5E File Offset: 0x000A8D5E
		Public Sub Merge(Builder As SQLJoinTableBuilder)
			Me.OoO0_ooO_.ooO0..Add(Builder)
		End Sub

		' Token: 0x06001A96 RID: 6806 RVA: 0x000AAB6C File Offset: 0x000A8D6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Build(ParamArray args As Object()) As DataTable
			Dim result As DataTable
			If args.Length = 0 Then
				result = Me.Build()
			ElseIf args.Length = 1 AndAlso TypeOf args(1)Is Boolean Then
				Dim onlyDataTable As Boolean = Conversions.ToBoolean(args(1))
				result = Me.Build(onlyDataTable)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001A97 RID: 6807 RVA: 0x000AABAD File Offset: 0x000A8DAD
		Public Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x06001A98 RID: 6808 RVA: 0x000AABB8 File Offset: 0x000A8DB8
		Public Function Build(OnlyDataTable As Boolean) As DataTable
			Dim a_ As String = OO_00oOO.MainTable.Name
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
			Try
				For Each sqljoinTableBuilder As SQLJoinTableBuilder In Me.OoO0_ooO_.ooO0.
					Dim table As DataTable = sqljoinTableBuilder.BuildDataSource()
					dataTable.Merge(table, False, MissingSchemaAction.Ignore)
				Next
			Finally
				Dim enumerator As List(Of SQLJoinTableBuilder).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return Me.oOo0OO._Ooo0_o.(dataTable, OnlyDataTable, a_)
		End Function

		' Token: 0x06001A99 RID: 6809 RVA: 0x000AACA8 File Offset: 0x000A8EA8
		Public Function BuildSql() As String
			Dim num2 As Integer
			Dim result As String
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Me.oOo0OO._Ooo0_o.()
				IL_08:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0F:
				num = 3
				Dim text As String = ""
				IL_18:
				num = 4
				Dim text2 As String = Oo00.o.oo_0.(Me.BaseTable)
				IL_27:
				num = 5
				Dim text3 As String = ""
				IL_30:
				num = 6
				Dim text4 As String = ""
				IL_39:
				num = 7
				Dim text5 As String = Me.Filter
				IL_43:
				num = 8
				Dim enumerator As Dictionary(Of String, String()).KeyCollection.Enumerator = Me.Oo.Oo__00..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text6 As String = enumerator.Current
					IL_65:
					num = 9
					If Operators.CompareString(text, "", True) > 0 Then
						IL_78:
						num = 10
						text += ","
					End If
					IL_89:
					num = 11
					Dim array As String() = Me.Oo.Oo__00.(text6)
					IL_9B:
					num = 12
					text += array(0)
					IL_AB:
					num = 13
					If Operators.CompareString(text6, array(0), True) <> 0 Then
						IL_BC:
						num = 14
						text = text + " As [" + text6 + "]"
					End If
					IL_D4:
					num = 15
					If Operators.CompareString(array(1), "1", True) = 0 Then
						IL_E8:
						num = 16
						If Operators.CompareString(text3, "", True) > 0 Then
							IL_FB:
							num = 17
							text3 += ","
						End If
						IL_10C:
						num = 18
						text3 += array(0)
					End If
					IL_11C:
					num = 19
				End While
				IL_12B:
				num = 20
				CType(enumerator, IDisposable).Dispose()
				IL_13B:
				num = 21
				Dim num3 As Integer = Me.oO_0o_.oOO0..Count - 1
				For i As Integer = 0 To num3
					IL_155:
					num = 22
					Dim oo0O__O As oo0O__O0 = Me.oO_0o_.oOO0.(i)
					IL_167:
					num = 23
					Dim name As String = [Enum].GetName(GetType(JoinModeEnum), oo0O__O.oO_0o_.oOO0.)
					IL_187:
					num = 24
					text2 = String.Concat(New String() { text2, " ", name, " JOIN ", Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.), " ON ", Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.), ".[", oo0O__O.oO_0o_.oOO0.(0), "] = ", Oo00.o.oo_0.(oo0O__O.O_o.O00Oo.), ".[", oo0O__O.Column(0), "]" })
					IL_224:
					num = 25
					If oo0O__O.Column.Length > 1 Then
						IL_236:
						num = 26
						Dim num4 As Integer = oo0O__O.Column.Length - 1
						For j As Integer = 1 To num4
							IL_24E:
							num = 27
							text2 = String.Concat(New String() { text2, " And ", Oo00.o.oo_0.(oo0O__O.o0O___o_o_0o.o.), ".[", oo0O__O.oO_0o_.oOO0.(j), "] = ", Oo00.o.oo_0.(oo0O__O.O_o.O00Oo.), ".[", oo0O__O.Column(j), "]" })
							IL_2C5:
							num = 28
						Next
					End If
					IL_2D7:
					num = 29
					text2 = "(" + text2 + ")"
					IL_2ED:
					num = 30
				Next
				IL_2FF:
				num = 31
				If Operators.CompareString(Me.Top, "", True) <= 0 Then
					GoTo IL_37F
				End If
				IL_316:
				num = 32
				If Me.oO_0o_.oOO0. <> DataServerTypeEnum.Oracle Then
					GoTo IL_365
				End If
				IL_322:
				num = 33
				If Operators.CompareString(text5, "", True) <= 0 Then
					GoTo IL_34E
				End If
				IL_335:
				num = 34
				text5 = text5 + " And ROWNUM <= " + Me.Top
				GoTo IL_37F
				IL_34E:
				num = 36
				text5 = "ROWNUM <= " + Me.Top
				GoTo IL_37F
				IL_365:
				num = 38
				text4 = "Top " + Me.Top.ToString()
				IL_37F:
				num = 39
				If Not Me.Distinct Then
					GoTo IL_3C3
				End If
				IL_38A:
				num = 40
				text = String.Concat(New String() { "Select Distinct ", text4, " ", text, " From ", text2 })
				GoTo IL_3FA
				IL_3C3:
				num = 42
				text = String.Concat(New String() { "Select ", text4, " ", text, " From ", text2 })
				IL_3FA:
				num = 43
				If Operators.CompareString(text5, "", True) <= 0 Then
					GoTo IL_420
				End If
				IL_40D:
				num = 44
				text = text + " Where " + text5
				IL_420:
				num = 45
				If Operators.CompareString(text3, "", True) <= 0 Then
					GoTo IL_446
				End If
				IL_433:
				num = 46
				text = text + " Group By " + text3
				IL_446:
				num = 47
				If Operators.CompareString(Me.Order, "", True) <= 0 Then
					GoTo IL_474
				End If
				IL_45D:
				num = 48
				text = text + " Order By " + Me.Order
				IL_474:
				num = 49
				Dim enumerator2 As List(Of SQLJoinTableBuilder).Enumerator = Me.Oo.Oo__00..GetEnumerator()
				While enumerator2.MoveNext()
					Dim sqljoinTableBuilder As SQLJoinTableBuilder = enumerator2.Current
					IL_48F:
					num = 50
					text = text + " UNION " + sqljoinTableBuilder.BuildSql()
					IL_4A7:
					num = 51
				End While
				IL_4B3:
				num = 52
				CType(enumerator2, IDisposable).Dispose()
				IL_4C3:
				num = 53
				Dim enumerator3 As List(Of SQLJoinTableBuilder).Enumerator = Me.oO._00OO0..GetEnumerator()
				While enumerator3.MoveNext()
					Dim sqljoinTableBuilder2 As SQLJoinTableBuilder = enumerator3.Current
					IL_4DE:
					num = 54
					text = text + " UNION All " + sqljoinTableBuilder2.BuildSql()
					IL_4F6:
					num = 55
				End While
				IL_502:
				num = 56
				CType(enumerator3, IDisposable).Dispose()
				IL_512:
				num = 57
				result = text
				IL_518:
				GoTo IL_652
				IL_51D:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_613:
				GoTo IL_647
				IL_615:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_625:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_615
			End Try
			IL_647:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_652:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06001A9A RID: 6810 RVA: 0x000AB32C File Offset: 0x000A952C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001A9B RID: 6811 RVA: 0x000AB348 File Offset: 0x000A9548
		Public Function BuildDataSource() As fxDataSource
			Dim fxDataSource As fxDataSource = New fxDataSource()
			Dim text As String = Me.BuildSql()
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			If Operators.CompareString(Me.ConnectionName, "", True) > 0 Then
				If O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					oleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
				ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
					o0O = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName)
				End If
				If oleDbConnection Is Nothing AndAlso o0O Is Nothing Then
					MessageBox.Show("不存在名为""" + Me.ConnectionName + """的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return Nothing
				End If
			Else
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
			End If
			If oleDbConnection IsNot Nothing Then
				text = Oo00.o0_o._O_.(oleDbConnection, text, False)
				If Me.AsyncExecute Then
					oleDbConnection = New OleDbConnection(oleDbConnection.ConnectionString)
				End If
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, oleDbConnection)
				oleDbDataAdapter.SelectCommand.CommandTimeout = Me.CommandTimeOut
				If Me.AsyncExecute Then
					oleDbConnection.Open()
				End If
				Try
					oleDbDataAdapter.Fill(fxDataSource)
					GoTo IL_1AC
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					GoTo IL_1AC
				Finally
					If Me.AsyncExecute Then
						oleDbConnection.Close()
					End If
				End Try
			End If
			text = Oo00.o0_o._O_.(Me.oO_0o_.oOO0., text, False)
			Dim httpClient As HttpClient = o0O.oO0_0.o.()
			httpClient.[Select] = text
			httpClient.FormData("Action") = 2.ToString()
			httpClient.FormData("IgnoreSchema") = "True"
			Dim baseDataTable As DataTable = httpClient.GetBaseDataTable()
			If baseDataTable IsNot Nothing AndAlso baseDataTable.Columns.Count > 0 Then
				fxDataSource.Merge(baseDataTable, False, MissingSchemaAction.AddWithKey)
				baseDataTable.Dispose()
			End If
			IL_1AC:
			Try
				For Each obj As Object In fxDataSource.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					If dataColumn.ColumnName.StartsWith("~TMPCLP") Then
						dataColumn.Caption = dataColumn.ColumnName.Substring(7)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return fxDataSource
		End Function

		' Token: 0x06001A9C RID: 6812 RVA: 0x000AB594 File Offset: 0x000A9794
		Private Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As Boolean, A_2 As String) As DataTable
			A_0.TableName = Me.TableName
			Dim dataTable As DataTable
			If A_1 Then
				dataTable = New DataTable(A_0, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
				dataTable.o.0O000_.()
			Else
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(A_0)
				OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(A_0, Nothing, Nothing, Me.TableName, O_O0OO.OoO.0OO__0ooo.()))
				OO_00oOO.DataTables(Me.TableName).o.0O000_.()
				OO_00oOO.DataTables(Me.TableName).AddByCode = True
				OO_00oOO.DataTables(Me.TableName).Caption = Me.Caption
				dataTable = OO_00oOO.DataTables(Me.TableName)
			End If
			Dim result As DataTable
			If A_1 Then
				result = dataTable
			Else
				New O_0(O_O0OO.o__.O.(), A_0)
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
				Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, Me.TableVisible, False)
				If Operators.CompareString(A_2, Me.TableName, True) = 0 Then
					OO_00oOO.MainTable = OO_00oOO.Tables(Me.TableName)
				End If
				result = dataTable
			End If
			Return result
		End Function

		' Token: 0x04000B2A RID: 2858
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B2B RID: 2859
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B2C RID: 2860
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B2D RID: 2861
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B2E RID: 2862
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000B2F RID: 2863
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B30 RID: 2864
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B31 RID: 2865
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B32 RID: 2866
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B33 RID: 2867
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B34 RID: 2868
		Private <<EMPTY_NAME>> As List(Of SQLJoinTableBuilder)

		' Token: 0x04000B35 RID: 2869
		Private <<EMPTY_NAME>> As List(Of SQLJoinTableBuilder)

		' Token: 0x04000B36 RID: 2870
		Private <<EMPTY_NAME>> As List(Of SQLJoinTableBuilder)

		' Token: 0x04000B37 RID: 2871
		Private <<EMPTY_NAME>> As List(Of oo0O__O0)

		' Token: 0x04000B38 RID: 2872
		Private <<EMPTY_NAME>> As Dictionary(Of String, String())

		' Token: 0x04000B39 RID: 2873
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B3A RID: 2874
		Private <<EMPTY_NAME>> As DataServerTypeEnum
	End Class
End Namespace
