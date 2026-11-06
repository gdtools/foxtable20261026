Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200028B RID: 651
	<oO0oooo("1627")>
	<ComVisible(True)>
	Public Class SQLCrossTableBuilder
		Inherits CrossTableBuilder

		' Token: 0x06001FCF RID: 8143 RVA: 0x000D25B3 File Offset: 0x000D07B3
		Public Sub New(A_0 As String, A_1 As String)
			Me.oo0.OoO0. = New List(Of oo0O__O0)()
			Me.oo0.OoO0. = New Dictionary(Of String, String)()
			Me.oo0.OoO0. = New Dictionary(Of String, DataTable)()
			MyBase.TableName = A_0
			Me.BaseTable = A_1
		End Sub

		' Token: 0x06001FD0 RID: 8144 RVA: 0x000D25EA File Offset: 0x000D07EA
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.oo0.OoO0. = New List(Of oo0O__O0)()
			Me.oo0.OoO0. = New Dictionary(Of String, String)()
			Me.oo0.OoO0. = New Dictionary(Of String, DataTable)()
			MyBase.TableName = A_0
			MyBase.SelectString = A_1
			MyBase.ConnectionName = A_2
		End Sub

		' Token: 0x17000736 RID: 1846
		' (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000D2628 File Offset: 0x000D0828
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Exprs As List(Of ExpressionTotal)
			Get
				Return MyBase.Totals.Exprs
			End Get
		End Property

		' Token: 0x17000737 RID: 1847
		' (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000D2635 File Offset: 0x000D0835
		' (set) Token: 0x06001FD3 RID: 8147 RVA: 0x000D263D File Offset: 0x000D083D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BaseTable As String
			Get
				Return Me.oo0.OoO0.
			End Get
			Set(value As String)
				Me.oo0.OoO0. = value
			End Set
		End Property

		' Token: 0x17000738 RID: 1848
		' (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000D2646 File Offset: 0x000D0846
		' (set) Token: 0x06001FD5 RID: 8149 RVA: 0x000D264E File Offset: 0x000D084E
		Public Overrides Property ConnectionName As String
			Get
				Return MyBase.ConnectionName
			End Get
			Set(value As String)
				MyBase.ConnectionName = value
			End Set
		End Property

		' Token: 0x17000739 RID: 1849
		' (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000D2657 File Offset: 0x000D0857
		Friend ReadOnly Property AsyncExecute As Boolean
			Get
				Return Thread.CurrentThread.ManagedThreadId <> Main.OO_O.o.
			End Get
		End Property

		' Token: 0x06001FD7 RID: 8151 RVA: 0x000D2670 File Offset: 0x000D0870
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

		' Token: 0x06001FD8 RID: 8152 RVA: 0x000D278C File Offset: 0x000D098C
		Public Sub AddTable(LeftTable As String, LeftCol As String(), RightTable As String, RightCol As String(), Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, LeftCol, RightTable, RightCol, JoinMode)
			Me.oo0.OoO0..Add(item)
		End Sub

		' Token: 0x06001FD9 RID: 8153 RVA: 0x000D27B4 File Offset: 0x000D09B4
		Public Sub AddTable(LeftTable As String, LeftCol As String, RightTable As String, RightCol As String, Optional JoinMode As JoinModeEnum = 0)
			Dim item As oo0O__O0 = New oo0O__O0(LeftTable, New String() { LeftCol }, RightTable, New String() { RightCol }, JoinMode)
			Me.oo0.OoO0..Add(item)
		End Sub

		' Token: 0x06001FDA RID: 8154 RVA: 0x000D27EC File Offset: 0x000D09EC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddCols(Table As String, ParamArray Cols As String())
			For Each key As String In Cols
				Me.oo0.OoO0..Add(key, Table)
			Next
		End Sub

		' Token: 0x06001FDB RID: 8155 RVA: 0x000D281C File Offset: 0x000D0A1C
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

		' Token: 0x06001FDC RID: 8156 RVA: 0x000D285D File Offset: 0x000D0A5D
		Public Overrides Overloads Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x06001FDD RID: 8157 RVA: 0x000D2868 File Offset: 0x000D0A68
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
			Dim result As DataTable
			If(MyBase.HGroups.Count = 0 AndAlso MyBase.HGroups.Exprs.Count = 0) OrElse (MyBase.VGroups.Count = 0 AndAlso MyBase.VGroups.Exprs.Count = 0) OrElse (MyBase.Totals.Count = 0 AndAlso MyBase.Totals.Exprs.Count = 0) Then
				result = Nothing
			Else
				Dim dataTable As DataTable = Me.BuildDataSource()
				Dim dataTable2 As DataTable = MyBase.O0oo00.0O_oO_.(dataTable, OnlyDataTable, a_)
				If MyBase.Subtotal AndAlso Not OnlyDataTable Then
					MyBase.o_o00_O.0_oo.(dataTable2.Name, dataTable)
				End If
				result = dataTable2
			End If
			Return result
		End Function

		' Token: 0x06001FDE RID: 8158 RVA: 0x000D2988 File Offset: 0x000D0B88
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001FDF RID: 8159 RVA: 0x000D29A4 File Offset: 0x000D0BA4
		Public Overrides Function BuildDataSource() As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim sqlgroupTableBuilder As SQLGroupTableBuilder = New SQLGroupTableBuilder()
				IL_10:
				num2 = 3
				New List(Of GroupOn)()
				IL_18:
				num2 = 4
				sqlgroupTableBuilder.TableName = OoOo0O.OO_o.0o_O.(6)
				IL_27:
				num2 = 5
				sqlgroupTableBuilder.BaseTable = Me.BaseTable
				IL_36:
				num2 = 6
				sqlgroupTableBuilder.Filter = MyBase.Filter
				IL_45:
				num2 = 7
				sqlgroupTableBuilder.Decimals = MyBase.Decimals
				IL_54:
				num2 = 8
				sqlgroupTableBuilder.ConnectionName = Me.ConnectionName
				IL_63:
				num2 = 9
				sqlgroupTableBuilder.Groups.AddRange(MyBase.HGroups)
				IL_78:
				num2 = 10
				sqlgroupTableBuilder.Groups.Exprs.AddRange(MyBase.HGroups.Exprs)
				IL_97:
				num2 = 11
				sqlgroupTableBuilder.Totals.Exprs.AddRange(MyBase.Totals.Exprs)
				IL_B6:
				num2 = 12
				sqlgroupTableBuilder.oOo0OO._Ooo0_o. = Me.oo0.OoO0.
				IL_C6:
				num2 = 13
				sqlgroupTableBuilder.O0__o_ooo0.O0O. = Me.oo0.OoO0.
				IL_D6:
				num2 = 14
				sqlgroupTableBuilder.CommandTimeOut = MyBase.CommandTimeOut
				IL_E6:
				num2 = 15
				Dim enumerator As List(Of CrossExpressionGroup).Enumerator = MyBase.VGroups.Exprs.GetEnumerator()
				While enumerator.MoveNext()
					Dim crossExpressionGroup As CrossExpressionGroup = enumerator.Current
					IL_106:
					num2 = 16
					Dim item As ExpressionGroup = New ExpressionGroup(crossExpressionGroup.Name, crossExpressionGroup.Expression, "")
					IL_123:
					num2 = 17
					sqlgroupTableBuilder.Groups.Exprs.Add(item)
					IL_139:
					num2 = 18
				End While
				IL_145:
				num2 = 19
				CType(enumerator, IDisposable).Dispose()
				IL_155:
				num2 = 20
				Dim enumerator2 As IEnumerator(Of CrossGroupOn) = MyBase.VGroups.GetEnumerator()
				While enumerator2.MoveNext()
					Dim crossGroupOn As CrossGroupOn = enumerator2.Current
					IL_170:
					num2 = 21
					Dim groupOn As GroupOn = New GroupOn()
					IL_17A:
					num2 = 22
					groupOn.Name = crossGroupOn.Name
					IL_18B:
					num2 = 23
					groupOn.NewName = crossGroupOn.NewName
					IL_19C:
					num2 = 24
					groupOn.DateGroup = crossGroupOn.DateGroup
					IL_1AD:
					num2 = 25
					groupOn.Pattern = crossGroupOn.Pattern
					IL_1BE:
					num2 = 26
					groupOn.Vertical = True
					IL_1C9:
					num2 = 27
					sqlgroupTableBuilder.Groups.Add(groupOn)
					IL_1DA:
					num2 = 28
				End While
				IL_1E6:
				num2 = 29
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_1F4:
				num2 = 30
				Dim enumerator3 As IEnumerator(Of CrossTotalOn) = MyBase.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim crossTotalOn As CrossTotalOn = enumerator3.Current
					IL_212:
					num2 = 31
					Dim totalOn As TotalOn = New TotalOn()
					IL_21C:
					num2 = 32
					totalOn.Name = crossTotalOn.Name
					IL_22D:
					num2 = 33
					totalOn.Aggregate = crossTotalOn.Aggregate
					IL_23E:
					num2 = 34
					totalOn.NewCaption = crossTotalOn.Caption
					IL_24F:
					num2 = 35
					totalOn.upto = crossTotalOn.upto
					IL_260:
					num2 = 36
					If totalOn.upto Then
						IL_26C:
						num2 = 37
						totalOn.NewName = totalOn.Name + "_up"
					End If
					IL_287:
					num2 = 38
					sqlgroupTableBuilder.Totals.Add(totalOn)
					IL_298:
					num2 = 39
				End While
				IL_2A7:
				num2 = 40
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_2B5:
				num2 = 41
				Dim a_ As DataTable = sqlgroupTableBuilder.oo0Oo0.0Oo_.()
				IL_2C1:
				num2 = 42
				Dim enumerator4 As List(Of ExpressionGroup).Enumerator = MyBase.HGroups.Exprs.GetEnumerator()
				While enumerator4.MoveNext()
					Dim expressionGroup As ExpressionGroup = enumerator4.Current
					IL_2E1:
					num2 = 43
					Dim groupOn2 As GroupOn = New GroupOn()
					IL_2EB:
					num2 = 44
					groupOn2.Name = expressionGroup.Name
					IL_2FC:
					num2 = 45
					groupOn2.NewCaption = expressionGroup.Caption
					IL_30D:
					num2 = 46
					sqlgroupTableBuilder.Groups.Add(groupOn2)
					IL_31E:
					num2 = 47
				End While
				IL_32A:
				num2 = 48
				CType(enumerator4, IDisposable).Dispose()
				IL_33A:
				num2 = 49
				Dim enumerator5 As List(Of CrossExpressionGroup).Enumerator = MyBase.VGroups.Exprs.GetEnumerator()
				While enumerator5.MoveNext()
					Dim crossExpressionGroup2 As CrossExpressionGroup = enumerator5.Current
					IL_35A:
					num2 = 50
					Dim groupOn3 As GroupOn = New GroupOn()
					IL_364:
					num2 = 51
					groupOn3.Name = crossExpressionGroup2.Name
					IL_375:
					num2 = 52
					groupOn3.Pattern = crossExpressionGroup2.Pattern
					IL_386:
					num2 = 53
					groupOn3.Vertical = True
					IL_391:
					num2 = 54
					sqlgroupTableBuilder.Groups.Add(groupOn3)
					IL_3A2:
					num2 = 55
				End While
				IL_3AE:
				num2 = 56
				CType(enumerator5, IDisposable).Dispose()
				IL_3BE:
				num2 = 57
				Dim enumerator6 As List(Of ExpressionTotal).Enumerator = MyBase.Totals.Exprs.GetEnumerator()
				While enumerator6.MoveNext()
					Dim expressionTotal As ExpressionTotal = enumerator6.Current
					IL_3E1:
					num2 = 58
					Dim totalOn2 As TotalOn = New TotalOn()
					IL_3EB:
					num2 = 59
					totalOn2.Name = expressionTotal.Name
					IL_3FC:
					num2 = 60
					totalOn2.NewCaption = Interaction.IIf(Operators.CompareString(expressionTotal.Caption, "", True) = 0, expressionTotal.Name, expressionTotal.Caption).ToString()
					IL_433:
					num2 = 61
					totalOn2.Aggregate = expressionTotal.Aggregate
					IL_444:
					num2 = 62
					totalOn2.upto = expressionTotal.upto
					IL_455:
					num2 = 63
					sqlgroupTableBuilder.Totals.Add(totalOn2)
					IL_466:
					num2 = 64
				End While
				IL_475:
				num2 = 65
				CType(enumerator6, IDisposable).Dispose()
				IL_485:
				num2 = 66
				Dim fxDataSource As fxDataSource = MyBase.o__.Ooo.(a_, sqlgroupTableBuilder)
				IL_494:
				num2 = 67
				fxDataSource.O_O_O.00. = Me
				IL_49F:
				num2 = 68
				result = fxDataSource
				IL_4A5:
				GoTo IL_60B
				IL_4AA:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_5CC:
				GoTo IL_600
				IL_5CE:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5DE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5CE
			End Try
			IL_600:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_60B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000D38 RID: 3384
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D39 RID: 3385
		Private <<EMPTY_NAME>> As List(Of oo0O__O0)

		' Token: 0x04000D3A RID: 3386
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000D3B RID: 3387
		Private <<EMPTY_NAME>> As Dictionary(Of String, DataTable)

		' Token: 0x04000D3C RID: 3388
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
