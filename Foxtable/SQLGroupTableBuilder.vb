Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200028C RID: 652
	<ComVisible(True)>
	<oO0oooo("1626")>
	Public Class SQLGroupTableBuilder
		Inherits GroupTableBuilder

		' Token: 0x06001FE0 RID: 8160 RVA: 0x000D2FE4 File Offset: 0x000D11E4
		Public Sub New()
			Me.oOo0OO._Ooo0_o. = New List(Of oo0O__O0)()
			Me.O0__o_ooo0.O0O. = New Dictionary(Of String, String)()
			Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access
			Me.FromServer = True
		End Sub

		' Token: 0x06001FE1 RID: 8161 RVA: 0x000D3010 File Offset: 0x000D1210
		Public Sub New(A_0 As String, A_1 As String)
			Me.oOo0OO._Ooo0_o. = New List(Of oo0O__O0)()
			Me.O0__o_ooo0.O0O. = New Dictionary(Of String, String)()
			Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access
			Me.FromServer = True
			MyBase.TableName = A_0
			Me.BaseTable = A_1
		End Sub

		' Token: 0x06001FE2 RID: 8162 RVA: 0x000D304C File Offset: 0x000D124C
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.oOo0OO._Ooo0_o. = New List(Of oo0O__O0)()
			Me.O0__o_ooo0.O0O. = New Dictionary(Of String, String)()
			Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.Access
			Me.FromServer = True
			MyBase.TableName = A_0
			MyBase.SelectString = A_1
			MyBase.ConnectionName = A_2
		End Sub

		' Token: 0x1700073A RID: 1850
		' (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000D3098 File Offset: 0x000D1298
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Exprs As List(Of ExpressionTotal)
			Get
				Return MyBase.Totals.Exprs
			End Get
		End Property

		' Token: 0x1700073B RID: 1851
		' (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000D30A5 File Offset: 0x000D12A5
		' (set) Token: 0x06001FE5 RID: 8165 RVA: 0x000D30AD File Offset: 0x000D12AD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BaseTable As String
			Get
				Return Me.O0__o_ooo0.O0O.
			End Get
			Set(value As String)
				Me.O0__o_ooo0.O0O. = value
			End Set
		End Property

		' Token: 0x1700073C RID: 1852
		' (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000D30B6 File Offset: 0x000D12B6
		' (set) Token: 0x06001FE7 RID: 8167 RVA: 0x000D30BE File Offset: 0x000D12BE
		Public Overrides Property ConnectionName As String
			Get
				Return MyBase.ConnectionName
			End Get
			Set(value As String)
				MyBase.ConnectionName = value
			End Set
		End Property

		' Token: 0x1700073D RID: 1853
		' (get) Token: 0x06001FE8 RID: 8168 RVA: 0x000D30C7 File Offset: 0x000D12C7
		Friend ReadOnly Property AsyncExecute As Boolean
			Get
				Return Thread.CurrentThread.ManagedThreadId <> Main.OO_O.o.
			End Get
		End Property

		' Token: 0x06001FE9 RID: 8169 RVA: 0x000D30E0 File Offset: 0x000D12E0
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

		' Token: 0x06001FEA RID: 8170 RVA: 0x000D31FC File Offset: 0x000D13FC
		Public Sub AddTable(LeftTable As String, LeftCol As String, RightTable As String, RightCol As String, Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, New String() { LeftCol }, RightTable, New String() { RightCol }, JoinMode)
			Me.oOo0OO._Ooo0_o..Add(item)
		End Sub

		' Token: 0x06001FEB RID: 8171 RVA: 0x000D3234 File Offset: 0x000D1434
		Public Sub AddTable(LeftTable As String, LeftCol As String(), RightTable As String, RightCol As String(), Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode)
			Me.oOo0OO._Ooo0_o..Add(item)
		End Sub

		' Token: 0x06001FEC RID: 8172 RVA: 0x000D325C File Offset: 0x000D145C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddCols(Table As String, ParamArray Cols As String())
			For Each key As String In Cols
				Me.O0__o_ooo0.O0O..Add(key, Table)
			Next
		End Sub

		' Token: 0x06001FED RID: 8173 RVA: 0x000D328C File Offset: 0x000D148C
		Friend Function <<EMPTY_NAME>>() As DataTable
			Me.O0__o_ooo0.O0O.()
			Dim a_ As DataTable = Me.o0_._00OOOoo0O.()
			Return Me.O0__o_ooo0.O0O.(a_)
		End Function

		' Token: 0x06001FEE RID: 8174 RVA: 0x000D32B0 File Offset: 0x000D14B0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overrides Overloads Function Build(ParamArray args As Object()) As DataTable
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

		' Token: 0x06001FEF RID: 8175 RVA: 0x000D32F1 File Offset: 0x000D14F1
		Public Overrides Overloads Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x06001FF0 RID: 8176 RVA: 0x000D32FC File Offset: 0x000D14FC
		Public Overrides Overloads Function Build(OnlyDataTable As Boolean) As DataTable
			Dim a_ As String = OO_00oOO.MainTable.Name
			If OO_00oOO.DataTables.Contains(MyBase.TableName) AndAlso Not OnlyDataTable Then
				If OO_00oOO.DataTables(MyBase.TableName).AddByCode Then
					OO_00oOO.DataTables.Delete(MyBase.TableName)
				End If
				If OO_00oOO.DataTables.Contains(MyBase.TableName) Then
					MessageBox.Show("表" + MyBase.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return Nothing
				End If
			End If
			Dim dataTable As DataTable = Me.BuildDataSource()
			Dim dataTable2 As DataTable = MyBase.oO_oO._O__O.(dataTable, OnlyDataTable, a_)
			If MyBase.Subtotal AndAlso Not OnlyDataTable Then
				MyBase.oO0.O00oO.(dataTable2.Name, dataTable)
			End If
			Return dataTable2
		End Function

		' Token: 0x06001FF1 RID: 8177 RVA: 0x000D33B8 File Offset: 0x000D15B8
		Private Sub <<EMPTY_NAME>>()
			If MyBase.SourceDataTable IsNot Nothing Then
				If Operators.CompareString(MyBase.SourceDataTable.DataServer, "", True) > 0 Then
					Me.oOo0OO._Ooo0_o. = O_O0OO.OoO__.0oO0oo.()(MyBase.SourceDataTable.ConnectionName).OO.OoO0.
					Me.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()(MyBase.SourceDataTable.ConnectionName).oO0_0.o.()
					Return
				End If
				If o_O_o_oOoo__.OOOO_OO._oo.(MyBase.SourceDataTable.frd_Connection) Then
					Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.SqlServer
					Return
				End If
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(MyBase.SourceDataTable.frd_Connection) Then
					Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.Oracle
					Return
				End If
			ElseIf Operators.CompareString(Me.ConnectionName, "", True) > 0 Then
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
					Me.oOo0OO._Ooo0_o. = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.
					Me.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
					Return
				End If
				If O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(Me.ConnectionName)) Then
						Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.Oracle
						Return
					End If
					If o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.O._o_.()(Me.ConnectionName)) Then
						Me.oOo0OO._Ooo0_o. = DataServerTypeEnum.SqlServer
					End If
				End If
			End If
		End Sub

		' Token: 0x06001FF2 RID: 8178 RVA: 0x000D3510 File Offset: 0x000D1710
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001FF3 RID: 8179 RVA: 0x000D352C File Offset: 0x000D172C
		Public Function BuildDataSource() As fxDataSource
			Me.O0__o_ooo0.O0O.()
			Dim dataTable As DataTable = Me.o0_._00OOOoo0O.()
			Dim fxDataSource As fxDataSource = Me.O0__o_ooo0.O0O.(dataTable)
			Try
				For Each expressionGroup As ExpressionGroup In MyBase.Groups.Exprs
					fxDataSource.Columns(expressionGroup.Name).Caption = expressionGroup.Caption
					Dim groupOn As GroupOn = New GroupOn()
					groupOn.Name = expressionGroup.Name
					groupOn.NewCaption = expressionGroup.Caption
					MyBase.Groups.Add(groupOn)
				Next
			Finally
				Dim enumerator As List(Of ExpressionGroup).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each expressionTotal As ExpressionTotal In MyBase.Totals.Exprs
					fxDataSource.Columns(expressionTotal.Name).Caption = expressionTotal.Caption
					Dim totalOn As TotalOn = New TotalOn()
					totalOn.Name = expressionTotal.Name
					totalOn.NewName = expressionTotal.Name
					totalOn.NewCaption = expressionTotal.Caption
					totalOn.Aggregate = expressionTotal.Aggregate
					totalOn.upto = expressionTotal.upto
					MyBase.Totals.Add(totalOn)
				Next
			Finally
				Dim enumerator2 As List(Of ExpressionTotal).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			MyBase.oO0O.__o_OO_oo.(fxDataSource, dataTable)
			fxDataSource.O_O_O.00. = Me
			Return fxDataSource
		End Function

		' Token: 0x06001FF4 RID: 8180 RVA: 0x000D36B0 File Offset: 0x000D18B0
		Private Function <<EMPTY_NAME>>() As DataTable
			Dim num As Integer
			Dim result As DataTable
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = ""
				IL_10:
				num2 = 3
				Dim dataTable As DataTable = New DataTable()
				IL_19:
				num2 = 4
				If Not Me.BaseTable.StartsWith("[") OrElse Not Me.BaseTable.EndsWith("]") Then
					GoTo IL_4B
				End If
				IL_3F:
				num2 = 5
				Dim text2 As String = Me.BaseTable
				GoTo IL_64
				IL_4B:
				num2 = 7
				text2 = "{" + Me.BaseTable + "}"
				IL_64:
				num2 = 8
				If Operators.CompareString(MyBase.SelectString, "", True) <= 0 Then
					GoTo IL_94
				End If
				IL_7A:
				num2 = 9
				text2 = "(" + MyBase.SelectString + ") tmptbl"
				IL_94:
				num2 = 10
				Dim enumerator As IEnumerator(Of GroupOn) = MyBase.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_B2:
					num2 = 11
					If Me.O0__o_ooo0.O0O..ContainsKey(groupOn.Name) Then
						IL_C9:
						num2 = 12
						text = String.Concat(New String() { text, "{", Me.O0__o_ooo0.O0O.(groupOn.Name), "}.[", groupOn.Name, "]," })
					Else
						IL_117:
						num2 = 14
						If groupOn.Name.IndexOf(".") > 0 Then
							IL_12E:
							num2 = 15
							text = text + groupOn.Name + ","
						Else
							IL_148:
							num2 = 17
							text = text + "[" + groupOn.Name + "],"
						End If
					End If
					IL_165:
					num2 = 18
				End While
				IL_174:
				num2 = 19
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_182:
				num2 = 20
				Dim enumerator2 As List(Of ExpressionGroup).Enumerator = MyBase.Groups.Exprs.GetEnumerator()
				While enumerator2.MoveNext()
					Dim expressionGroup As ExpressionGroup = enumerator2.Current
					IL_1A2:
					num2 = 21
					text = String.Concat(New String() { text, "(", expressionGroup.Expression, ") As [", expressionGroup.Name, "]," })
					IL_1E3:
					num2 = 22
				End While
				IL_1EF:
				num2 = 23
				CType(enumerator2, IDisposable).Dispose()
				IL_1FF:
				num2 = 24
				Dim enumerator3 As IEnumerator(Of TotalOn) = MyBase.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim totalOn As TotalOn = enumerator3.Current
					IL_21D:
					num2 = 25
					If Me.O0__o_ooo0.O0O..ContainsKey(totalOn.Name) Then
						IL_234:
						num2 = 26
						text = String.Concat(New String() { text, "{", Me.O0__o_ooo0.O0O.(totalOn.Name), "}.[", totalOn.Name, "]," })
					Else
						IL_282:
						num2 = 28
						If totalOn.Name.IndexOf(".") > 0 Then
							IL_299:
							num2 = 29
							text = text + totalOn.Name + ","
						Else
							IL_2B3:
							num2 = 31
							text = text + "[" + totalOn.Name + "],"
						End If
					End If
					IL_2D0:
					num2 = 32
				End While
				IL_2DF:
				num2 = 33
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_2ED:
				num2 = 34
				Dim enumerator4 As List(Of ExpressionTotal).Enumerator = MyBase.Totals.Exprs.GetEnumerator()
				While enumerator4.MoveNext()
					Dim expressionTotal As ExpressionTotal = enumerator4.Current
					IL_30D:
					num2 = 35
					text = String.Concat(New String() { text, "(", expressionTotal.Expression, ") As [", expressionTotal.Name, "]," })
					IL_34E:
					num2 = 36
				End While
				IL_35A:
				num2 = 37
				CType(enumerator4, IDisposable).Dispose()
				IL_36A:
				num2 = 38
				text = text.Trim(New Char() { ","c })
				IL_381:
				num2 = 39
				Dim num3 As Integer = Me.oOo0OO._Ooo0_o..Count - 1
				For i As Integer = 0 To num3
					IL_39B:
					num2 = 40
					Dim oo0O__O As oo0O__O0 = Me.oOo0OO._Ooo0_o.(i)
					IL_3AD:
					num2 = 41
					Dim name As String = [Enum].GetName(GetType(JoinModeEnum), oo0O__O.oO_0o_.oOO0.)
					IL_3CD:
					num2 = 42
					text2 = String.Concat(New String() { text2, " ", name, " JOIN {", oo0O__O.o0O___o_o_0o.o., "} ON {", oo0O__O.o0O___o_o_0o.o., "}.[", oo0O__O.oO_0o_.oOO0.(0), "] = {", oo0O__O.O_o.O00Oo., "}.[", oo0O__O.Column(0), "]" })
					IL_45B:
					num2 = 43
					If oo0O__O.Column.Length > 1 Then
						IL_46D:
						num2 = 44
						Dim num4 As Integer = oo0O__O.Column.Length - 1
						For j As Integer = 1 To num4
							IL_482:
							num2 = 45
							text2 = String.Concat(New String() { text2, " And {", oo0O__O.o0O___o_o_0o.o., "}.[", oo0O__O.oO_0o_.oOO0.(j), "] = {", oo0O__O.O_o.O00Oo., "}.[", oo0O__O.Column(j), "]" })
							IL_4EF:
							num2 = 46
						Next
					End If
					IL_4FE:
					num2 = 47
					If i < Me.oOo0OO._Ooo0_o..Count - 1 Then
						IL_512:
						num2 = 48
						text2 = "(" + text2 + ")"
					End If
					IL_528:
					num2 = 49
				Next
				IL_53A:
				num2 = 50
				Dim text3 As String = "Select " + text + " From " + text2
				IL_552:
				num2 = 51
				If Me.o.O0__OO. IsNot Nothing Then
					GoTo IL_750
				End If
				IL_560:
				num2 = 52
				Dim oleDbConnection As OleDbConnection = Nothing
				IL_566:
				num2 = 53
				If Operators.CompareString(Me.ConnectionName, "", True) <= 0 Then
					GoTo IL_642
				End If
				IL_580:
				num2 = 54
				If Not O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					GoTo IL_5AC
				End If
				IL_595:
				num2 = 55
				oleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
				GoTo IL_60B
				IL_5AC:
				num2 = 57
				Dim enumerator5 As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator5.MoveNext()
					Dim text4 As String = enumerator5.Current
					IL_5CB:
					num2 = 58
					If Operators.CompareString(text4, Me.ConnectionName, True) = 0 Then
						IL_5DE:
						num2 = 59
						oleDbConnection = O_O0OO.O._o_.()(text4)
					End If
					IL_5EF:
					num2 = 60
				End While
				IL_5FB:
				num2 = 61
				CType(enumerator5, IDisposable).Dispose()
				IL_60B:
				num2 = 62
				If oleDbConnection IsNot Nothing Then
					GoTo IL_657
				End If
				IL_612:
				num2 = 63
				MessageBox.Show("不存在名为""" + Me.ConnectionName + """的数据源!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_638:
				num2 = 64
				result = Nothing
				GoTo IL_7D7
				IL_642:
				num2 = 66
				If Me.o.O0__OO. IsNot Nothing Then
					GoTo IL_657
				End If
				IL_64D:
				num2 = 67
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
				IL_657:
				num2 = 68
				text3 = Oo00.o0_o._O_.(oleDbConnection, text3, False)
				IL_666:
				num2 = 69
				If Not Me.AsyncExecute Then
					GoTo IL_682
				End If
				IL_671:
				num2 = 70
				oleDbConnection = New OleDbConnection(oleDbConnection.ConnectionString)
				IL_682:
				num2 = 71
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text3, oleDbConnection)
				IL_690:
				num2 = 72
				oleDbDataAdapter.SelectCommand.CommandTimeout = MyBase.CommandTimeOut
				IL_6A5:
				num2 = 73
				Information.Err().Clear()
				IL_6B2:
				num2 = 74
				If Not Me.AsyncExecute Then
					GoTo IL_6C7
				End If
				IL_6BD:
				num2 = 75
				oleDbConnection.Open()
				IL_6C7:
				num2 = 76
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_6D5:
				num2 = 77
				If Not Me.AsyncExecute Then
					GoTo IL_6EA
				End If
				IL_6E0:
				num2 = 78
				oleDbConnection.Close()
				IL_6EA:
				num2 = 79
				If Information.Err().Number = 0 Then
					GoTo IL_71E
				End If
				IL_6F9:
				num2 = 80
				MessageBox.Show("统计错误，错误提示：" & vbCrLf + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				IL_71E:
				num2 = 81
				If dataTable.Columns.Count <> 0 Then
					GoTo IL_745
				End If
				IL_72F:
				num2 = 82
				MessageBox.Show("生成的SQL语句错误，无法继续统计！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_745:
				num2 = 83
				result = dataTable
				GoTo IL_7D7
				IL_750:
				num2 = 85
				text3 = Oo00.o0_o._O_.(Me.oOo0OO._Ooo0_o., text3, False)
				IL_763:
				num2 = 86
				Me.o.O0__OO..FormData("IgnoreSchema") = "True"
				IL_780:
				num2 = 87
				Me.o.O0__OO..FormData("Action") = 12.ToString()
				IL_7A3:
				num2 = 88
				Me.o.O0__OO..[Select] = text3
				IL_7B3:
				num2 = 89
				dataTable = Me.o.O0__OO..GetBaseDataTable()
				IL_7C3:
				num2 = 90
				Me.o.O0__OO..Reset()
				IL_7D1:
				num2 = 91
				result = dataTable
				IL_7D7:
				GoTo IL_999
				IL_7DC:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_95A:
				GoTo IL_98E
				IL_95C:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_96C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_95C
			End Try
			IL_98E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_999:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06001FF5 RID: 8181 RVA: 0x000D407C File Offset: 0x000D227C
		Private Function <<EMPTY_NAME>>(A_0 As DataTable) As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num6 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim fxDataSource As fxDataSource = New fxDataSource()
				IL_10:
				num2 = 3
				Dim text As String = ""
				IL_19:
				num2 = 4
				Dim text2 As String = ""
				IL_22:
				num2 = 5
				If Not Me.BaseTable.StartsWith("[") OrElse Not Me.BaseTable.EndsWith("]") Then
					GoTo IL_54
				End If
				IL_48:
				num2 = 6
				Dim text3 As String = Me.BaseTable
				GoTo IL_6D
				IL_54:
				num2 = 8
				text3 = "{" + Me.BaseTable + "}"
				IL_6D:
				num2 = 9
				Dim oleDbConnection As OleDbConnection = Nothing
				IL_73:
				num2 = 10
				If Operators.CompareString(MyBase.SelectString, "", True) <= 0 Then
					GoTo IL_A4
				End If
				IL_8A:
				num2 = 11
				text3 = "(" + MyBase.SelectString + ") tmptbl"
				IL_A4:
				num2 = 12
				Dim enumerator As IEnumerator(Of GroupOn) = MyBase.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_C2:
					num2 = 13
					If Operators.CompareString(text, "", True) > 0 Then
						IL_D5:
						num2 = 14
						text += ","
					End If
					IL_E6:
					num2 = 15
					If Operators.CompareString(text2, "", True) > 0 Then
						IL_F9:
						num2 = 16
						text2 += ","
					End If
					IL_10A:
					num2 = 17
					If A_0.Columns(groupOn.SourceName).DataType Is GetType(DateTime) AndAlso groupOn.DateGroup IsNot Nothing Then
						IL_13F:
						num2 = 18
						groupOn.IsDate = True
						IL_14A:
						num2 = 19
						Dim text4 As String
						If Me.O0__o_ooo0.O0O..ContainsKey(groupOn.Name) Then
							IL_161:
							num2 = 20
							text4 = Me.O0__o_ooo0.O0O.(groupOn.Name)
						Else
							IL_17A:
							num2 = 22
							If groupOn.Name.IndexOf(".") > 0 Then
								IL_191:
								num2 = 23
								text4 = groupOn.Name.Substring(0, groupOn.Name.IndexOf("."))
								IL_1B4:
								num2 = 24
								text4 = text4.Trim(New Char() { "{"c, "}"c })
							Else
								IL_1D2:
								num2 = 26
								text4 = ""
							End If
						End If
						IL_1DC:
						num2 = 27
						Dim str As String = o_O_o_oOoo__.OO_O0oO0.oooO_.(text4, groupOn.SourceName, groupOn.DateGroup, Me.oOo0OO._Ooo0_o.)
						IL_1FC:
						num2 = 28
						text += str
						IL_20A:
						num2 = 29
						text2 += str
						IL_218:
						num2 = 30
						text = text + " As [" + groupOn.NewName + "]"
					Else
						IL_23A:
						num2 = 32
						Dim str2 As String
						If Me.O0__o_ooo0.O0O..ContainsKey(groupOn.Name) Then
							IL_251:
							num2 = 33
							str2 = String.Concat(New String() { "{", Me.O0__o_ooo0.O0O.(groupOn.Name), "}.[", groupOn.Name, "]" })
						Else
							IL_29A:
							num2 = 35
							If groupOn.Name.IndexOf(".") > 0 Then
								IL_2B1:
								num2 = 36
								str2 = groupOn.Name
							Else
								IL_2BF:
								num2 = 38
								str2 = "[" + groupOn.Name + "]"
							End If
						End If
						IL_2DA:
						num2 = 39
						text += str2
						IL_2E8:
						num2 = 40
						text2 += str2
						IL_2F6:
						num2 = 41
						If Operators.CompareString(groupOn.Name, groupOn.NewName, True) <> 0 Then
							IL_30F:
							num2 = 42
							text = text + " As [" + groupOn.NewName + "]"
						End If
					End If
					IL_32C:
					num2 = 43
				End While
				IL_33B:
				num2 = 44
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_349:
				num2 = 45
				Dim enumerator2 As List(Of ExpressionGroup).Enumerator = MyBase.Groups.Exprs.GetEnumerator()
				While enumerator2.MoveNext()
					Dim expressionGroup As ExpressionGroup = enumerator2.Current
					IL_36C:
					num2 = 46
					If Operators.CompareString(text, "", True) > 0 Then
						IL_37F:
						num2 = 47
						text += ","
					End If
					IL_390:
					num2 = 48
					If Operators.CompareString(text2, "", True) > 0 Then
						IL_3A3:
						num2 = 49
						text2 += ","
					End If
					IL_3B4:
					num2 = 50
					text = String.Concat(New String() { text, "(", expressionGroup.Expression, ") As [", expressionGroup.Name, "]" })
					IL_3F5:
					num2 = 51
					text2 = text2 + "(" + expressionGroup.Expression + ")"
					IL_412:
					num2 = 52
				End While
				IL_421:
				num2 = 53
				CType(enumerator2, IDisposable).Dispose()
				IL_431:
				num2 = 54
				Dim enumerator3 As IEnumerator(Of TotalOn) = MyBase.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim totalOn As TotalOn = enumerator3.Current
					IL_44F:
					num2 = 55
					Dim text5 As String = ""
					IL_459:
					num2 = 56
					If Me.O0__o_ooo0.O0O..ContainsKey(totalOn.Name) Then
						IL_470:
						num2 = 57
						text5 = String.Concat(New String() { "({", Me.O0__o_ooo0.O0O.(totalOn.Name), "}.[", totalOn.Name, "]) As [", totalOn.NewName, "]" })
					Else
						IL_4CE:
						num2 = 59
						If totalOn.Name.IndexOf(".") > 0 Then
							IL_4E8:
							num2 = 60
							If Operators.CompareString(totalOn.Name, totalOn.NewName, True) <> 0 Then
								IL_501:
								num2 = 61
								text5 = String.Concat(New String() { "(", totalOn.Name, ") As [", totalOn.NewName, "]" })
							Else
								IL_542:
								num2 = 63
								Dim array As String() = totalOn.Name.Split(New Char() { "."c })
								IL_55E:
								num2 = 64
								array(1) = array(1).Trim(New Char() { "["c, "]"c })
								IL_57E:
								num2 = 65
								text5 = String.Concat(New String() { "(", totalOn.Name, ") As [", array(1), "]" })
							End If
						Else
							IL_5B9:
							num2 = 67
							text5 = String.Concat(New String() { "([", totalOn.Name, "]) As [", totalOn.NewName, "]" })
						End If
					End If
					IL_5F5:
					num2 = 68
					Select Case totalOn.Aggregate
						Case 2
							IL_628:
							num2 = 70
							text5 = "Sum" + text5
						Case 4
							IL_64E:
							num2 = 74
							text5 = "Count" + text5
						Case 6
							IL_63B:
							num2 = 72
							text5 = "Avg" + text5
						Case 7
							IL_661:
							num2 = 76
							text5 = "Max" + text5
						Case 8
							IL_674:
							num2 = 78
							text5 = "Min" + text5
					End Select
					IL_685:
					num2 = 80
					text = text + "," + text5
					IL_698:
					num2 = 81
				End While
				IL_6A7:
				num2 = 82
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_6B5:
				num2 = 83
				Dim enumerator4 As List(Of ExpressionTotal).Enumerator = MyBase.Totals.Exprs.GetEnumerator()
				While enumerator4.MoveNext()
					Dim expressionTotal As ExpressionTotal = enumerator4.Current
					IL_6D8:
					num2 = 84
					Dim text6 As String = String.Concat(New String() { "(", expressionTotal.Expression, ") As [", expressionTotal.Name, "]" })
					IL_714:
					num2 = 85
					Select Case expressionTotal.Aggregate
						Case 2
							IL_747:
							num2 = 87
							text6 = "Sum" + text6
						Case 4
							IL_76D:
							num2 = 91
							text6 = "Count" + text6
						Case 6
							IL_75A:
							num2 = 89
							text6 = "Avg" + text6
						Case 7
							IL_780:
							num2 = 93
							text6 = "Max" + text6
						Case 8
							IL_793:
							num2 = 95
							text6 = "Min" + text6
					End Select
					IL_7A4:
					num2 = 97
					text = text + "," + text6
					IL_7B7:
					num2 = 98
				End While
				IL_7C6:
				num2 = 99
				CType(enumerator4, IDisposable).Dispose()
				IL_7D6:
				num2 = 100
				Dim num3 As Integer = Me.oOo0OO._Ooo0_o..Count - 1
				For i As Integer = 0 To num3
					IL_7F0:
					num2 = 101
					Dim oo0O__O As oo0O__O0 = Me.oOo0OO._Ooo0_o.(i)
					IL_802:
					num2 = 102
					Dim name As String = [Enum].GetName(GetType(JoinModeEnum), oo0O__O.oO_0o_.oOO0.)
					IL_822:
					num2 = 103
					text3 = String.Concat(New String() { text3, " ", name, " JOIN {", oo0O__O.o0O___o_o_0o.o., "} ON {", oo0O__O.o0O___o_o_0o.o., "}.[", oo0O__O.oO_0o_.oOO0.(0), "] = {", oo0O__O.O_o.O00Oo., "}.[", oo0O__O.Column(0), "]" })
					IL_8B0:
					num2 = 104
					If oo0O__O.Column.Length > 1 Then
						IL_8C2:
						num2 = 105
						Dim num4 As Integer = oo0O__O.Column.Length - 1
						For j As Integer = 1 To num4
							IL_8D7:
							num2 = 106
							text3 = String.Concat(New String() { text3, " And {", oo0O__O.o0O___o_o_0o.o., "}.[", oo0O__O.oO_0o_.oOO0.(j), "] = {", oo0O__O.O_o.O00Oo., "}.[", oo0O__O.Column(j), "]" })
							IL_944:
							num2 = 107
						Next
					End If
					IL_953:
					num2 = 108
					If i < Me.oOo0OO._Ooo0_o..Count - 1 Then
						IL_967:
						num2 = 109
						text3 = "(" + text3 + ")"
					End If
					IL_97D:
					num2 = 110
				Next
				IL_98F:
				num2 = 111
				Dim text7 As String = "Select " + text + " From " + text3
				IL_9A7:
				num2 = 112
				If Operators.CompareString(MyBase.Filter, "", True) <= 0 Then
					GoTo IL_9D5
				End If
				IL_9BE:
				num2 = 113
				text7 = text7 + " Where " + MyBase.Filter
				IL_9D5:
				num2 = 114
				text7 = text7 + " Group By " + text2
				IL_9E8:
				num2 = 115
				text7 = text7 + " ORDER BY " + text2
				IL_9FB:
				num2 = 116
				If Me.o.O0__OO. IsNot Nothing Then
					GoTo IL_BAF
				End If
				IL_A09:
				num2 = 117
				If Operators.CompareString(Me.ConnectionName, "", True) <= 0 Then
					GoTo IL_AB0
				End If
				IL_A23:
				num2 = 118
				If Not O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
					GoTo IL_A4F
				End If
				IL_A38:
				num2 = 119
				oleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
				GoTo IL_ABA
				IL_A4F:
				num2 = 121
				Dim enumerator5 As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator5.MoveNext()
					Dim text8 As String = enumerator5.Current
					IL_A6E:
					num2 = 122
					If Operators.CompareString(text8, Me.ConnectionName, True) = 0 Then
						IL_A81:
						num2 = 123
						oleDbConnection = O_O0OO.O._o_.()(text8)
					End If
					IL_A92:
					num2 = 124
				End While
				IL_A9E:
				num2 = 125
				CType(enumerator5, IDisposable).Dispose()
				GoTo IL_ABA
				IL_AB0:
				num2 = 127
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
				IL_ABA:
				num2 = 128
				text7 = Oo00.o0_o._O_.(oleDbConnection, text7, False)
				IL_ACC:
				num2 = 129
				If Not Me.AsyncExecute Then
					GoTo IL_AEE
				End If
				IL_ADA:
				num2 = 130
				oleDbConnection = New OleDbConnection(oleDbConnection.ConnectionString)
				IL_AEE:
				num2 = 131
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text7, oleDbConnection)
				IL_AFF:
				num2 = 132
				oleDbDataAdapter.SelectCommand.CommandTimeout = MyBase.CommandTimeOut
				IL_B17:
				num2 = 133
				Information.Err().Clear()
				IL_B27:
				num2 = 134
				If Not Me.AsyncExecute Then
					GoTo IL_B42
				End If
				IL_B35:
				num2 = 135
				oleDbConnection.Open()
				IL_B42:
				num2 = 136
				oleDbDataAdapter.Fill(fxDataSource)
				IL_B52:
				num2 = 137
				If Not Me.AsyncExecute Then
					GoTo IL_B6D
				End If
				IL_B60:
				num2 = 138
				oleDbConnection.Close()
				IL_B6D:
				num2 = 139
				If Information.Err().Number = 0 Then
					GoTo IL_C5A
				End If
				IL_B82:
				num2 = 140
				MessageBox.Show("统计错误，错误原因：" & vbCrLf + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				GoTo IL_C5A
				IL_BAF:
				num2 = 142
				text7 = Oo00.o0_o._O_.(Me.oOo0OO._Ooo0_o., text7, False)
				IL_BC5:
				num2 = 143
				Me.o.O0__OO..[Select] = text7
				IL_BD8:
				num2 = 144
				Me.o.O0__OO..FormData("IgnoreSchema") = "True"
				IL_BF8:
				num2 = 145
				Me.o.O0__OO..FormData("Action") = 2.ToString()
				IL_C1D:
				num2 = 146
				Dim baseDataTable As DataTable = Me.o.O0__OO..GetBaseDataTable()
				IL_C30:
				num2 = 147
				If baseDataTable Is Nothing OrElse baseDataTable.Columns.Count <= 0 Then
					GoTo IL_C5A
				End If
				IL_C49:
				num2 = 148
				fxDataSource.Merge(baseDataTable, False, MissingSchemaAction.Add)
				IL_C5A:
				num2 = 149
				Dim enumerator6 As IEnumerator = fxDataSource.Columns.GetEnumerator()
				While enumerator6.MoveNext()
					Dim obj As Object = enumerator6.Current
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					IL_C81:
					num2 = 150
					If dataColumn.DataType Is GetType(Double) OrElse dataColumn.DataType Is GetType(Single) OrElse dataColumn.DataType Is GetType(Decimal) Then
						IL_CC3:
						num2 = 151
						Dim enumerator7 As IEnumerator = fxDataSource.Rows.GetEnumerator()
						While enumerator7.MoveNext()
							Dim obj2 As Object = enumerator7.Current
							Dim dataRow As DataRow = CType(obj2, DataRow)
							IL_CE7:
							num2 = 152
							If Not dataRow.IsNull(dataColumn) Then
								IL_CF8:
								num2 = 153
								dataRow(dataColumn) = Math.Round(Conversions.ToDecimal(dataRow(dataColumn)), MyBase.Decimals)
							End If
							IL_D25:
							num2 = 154
						End While
						IL_D34:
						num2 = 155
						If TypeOf enumerator7 Is IDisposable Then
							TryCast(enumerator7, IDisposable).Dispose()
						End If
					End If
					IL_D4F:
					num2 = 156
				End While
				IL_D61:
				num2 = 157
				If TypeOf enumerator6 Is IDisposable Then
					TryCast(enumerator6, IDisposable).Dispose()
				End If
				IL_D7C:
				num2 = 158
				Dim enumerator8 As IEnumerator(Of GroupOn) = MyBase.Groups.GetEnumerator()
				While enumerator8.MoveNext()
					Dim groupOn2 As GroupOn = enumerator8.Current
					IL_D9A:
					num2 = 159
					groupOn2.Name = groupOn2.SourceName
					IL_DAE:
					num2 = 160
				End While
				IL_DBD:
				num2 = 161
				If enumerator8 IsNot Nothing Then
					enumerator8.Dispose()
				End If
				IL_DCE:
				num2 = 162
				result = fxDataSource
				IL_DD7:
				GoTo IL_10B5
				IL_DDC:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_1076:
				GoTo IL_10AA
				IL_1078:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1088:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_1078
			End Try
			IL_10AA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_10B5:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x1700073E RID: 1854
		' (get) Token: 0x06001FF6 RID: 8182 RVA: 0x000D5164 File Offset: 0x000D3364
		' (set) Token: 0x06001FF7 RID: 8183 RVA: 0x000D516C File Offset: 0x000D336C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FromServer As Boolean

		' Token: 0x04000D3D RID: 3389
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D3E RID: 3390
		Friend <<EMPTY_NAME>> As List(Of oo0O__O0)

		' Token: 0x04000D3F RID: 3391
		Friend <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000D40 RID: 3392
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D41 RID: 3393
		Private <<EMPTY_NAME>> As DataServerTypeEnum

		' Token: 0x04000D42 RID: 3394
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
