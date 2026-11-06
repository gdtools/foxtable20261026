Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000287 RID: 647
	<ComVisible(True)>
	<oO0oooo("0677")>
	Public Class GroupTableBuilder
		' Token: 0x06001F59 RID: 8025 RVA: 0x000CA2F8 File Offset: 0x000C84F8
		Friend Sub New()
			Me.o.O0__OO. = True
			Me.O.00OOoo_0O_. = New GroupCollection()
			Me.o.O0__OO. = New TotalCollection()
			Me.oO0.O00oO. = 4
			Me.O.00_0OO0_. = -1
			Me.o.O0__OO. = New List(Of String)()
			Me.ooO.oO0O00O0. = New List(Of String)()
			Me.o0.o_O0O. = New List(Of String)()
			Me.Oo.O0O_0. = 30
		End Sub

		' Token: 0x06001F5A RID: 8026 RVA: 0x000CA360 File Offset: 0x000C8560
		Public Sub New(A_0 As String, A_1 As DataTable)
			Me.o.O0__OO. = True
			Me.O.00OOoo_0O_. = New GroupCollection()
			Me.o.O0__OO. = New TotalCollection()
			Me.oO0.O00oO. = 4
			Me.O.00_0OO0_. = -1
			Me.o.O0__OO. = New List(Of String)()
			Me.ooO.oO0O00O0. = New List(Of String)()
			Me.o0.o_O0O. = New List(Of String)()
			Me.Oo.O0O_0. = 30
			Me.o.O0__OO. = A_0
			Me.O.00OOoo_0O_. = A_1
		End Sub

		' Token: 0x06001F5B RID: 8027 RVA: 0x000CA3D8 File Offset: 0x000C85D8
		Public Sub New(A_0 As String, A_1 As DataTable, A_2 As String)
			Me.o.O0__OO. = True
			Me.O.00OOoo_0O_. = New GroupCollection()
			Me.o.O0__OO. = New TotalCollection()
			Me.oO0.O00oO. = 4
			Me.O.00_0OO0_. = -1
			Me.o.O0__OO. = New List(Of String)()
			Me.ooO.oO0O00O0. = New List(Of String)()
			Me.o0.o_O0O. = New List(Of String)()
			Me.Oo.O0O_0. = 30
			Me.o.O0__OO. = A_0
			Me.O.00OOoo_0O_. = A_1
			Me.Oo.O0O_0. = A_2
		End Sub

		' Token: 0x06001F5C RID: 8028 RVA: 0x000CA454 File Offset: 0x000C8654
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.o.O0__OO. = True
			Me.O.00OOoo_0O_. = New GroupCollection()
			Me.o.O0__OO. = New TotalCollection()
			Me.oO0.O00oO. = 4
			Me.O.00_0OO0_. = -1
			Me.o.O0__OO. = New List(Of String)()
			Me.ooO.oO0O00O0. = New List(Of String)()
			Me.o0.o_O0O. = New List(Of String)()
			Me.Oo.O0O_0. = 30
			Me.o.O0__OO. = A_0
			Me.o_O0oo__._0o. = A_1
			Me.oOO_.0___. = A_2
		End Sub

		' Token: 0x06001F5D RID: 8029 RVA: 0x000CA4D0 File Offset: 0x000C86D0
		Public Sub New(A_0 As String, A_1 As String)
			Me.o.O0__OO. = True
			Me.O.00OOoo_0O_. = New GroupCollection()
			Me.o.O0__OO. = New TotalCollection()
			Me.oO0.O00oO. = 4
			Me.O.00_0OO0_. = -1
			Me.o.O0__OO. = New List(Of String)()
			Me.ooO.oO0O00O0. = New List(Of String)()
			Me.o0.o_O0O. = New List(Of String)()
			Me.Oo.O0O_0. = 30
			Me.o.O0__OO. = A_0
			Me.o_O0oo__._0o. = A_1
		End Sub

		' Token: 0x17000713 RID: 1811
		' (get) Token: 0x06001F5E RID: 8030 RVA: 0x000CA545 File Offset: 0x000C8745
		' (set) Token: 0x06001F5F RID: 8031 RVA: 0x000CA54D File Offset: 0x000C874D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SelectString As String
			Get
				Return Me.o_O0oo__._0o.
			End Get
			Set(value As String)
				Me.o_O0oo__._0o. = value
			End Set
		End Property

		' Token: 0x17000714 RID: 1812
		' (get) Token: 0x06001F60 RID: 8032 RVA: 0x000CA556 File Offset: 0x000C8756
		' (set) Token: 0x06001F61 RID: 8033 RVA: 0x000CA55E File Offset: 0x000C875E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overridable Property ConnectionName As String
			Get
				Return Me.oOO_.0___.
			End Get
			Set(value As String)
				Me.oOO_.0___. = value
			End Set
		End Property

		' Token: 0x17000715 RID: 1813
		' (get) Token: 0x06001F62 RID: 8034 RVA: 0x000CA567 File Offset: 0x000C8767
		' (set) Token: 0x06001F63 RID: 8035 RVA: 0x000CA56F File Offset: 0x000C876F
		Public Property Decimals As Integer
			Get
				Return Me.oO0.O00oO.
			End Get
			Set(value As Integer)
				Me.oO0.O00oO. = value
			End Set
		End Property

		' Token: 0x17000716 RID: 1814
		' (get) Token: 0x06001F64 RID: 8036 RVA: 0x000CA578 File Offset: 0x000C8778
		' (set) Token: 0x06001F65 RID: 8037 RVA: 0x000CA602 File Offset: 0x000C8802
		<oO0oooo("1623")>
		Public Property FromServer As Boolean
			Get
				Return Me.SourceDataTable IsNot Nothing AndAlso Operators.CompareString(Me.SelectString, "", True) <= 0 AndAlso (Me.SourceDataTable.frd_IsOuterTable OrElse Me.SourceDataTable.frd_IsInnerTable OrElse Me.SourceDataTable.frd_IsOuterQuery OrElse Me.SourceDataTable.frd_IsInnerQuery OrElse Operators.CompareString(Me.SourceDataTable.DataServer, "", True) > 0) AndAlso Me.Oo0Oo._oO.
			End Get
			Set(value As Boolean)
				Me.Oo0Oo._oO. = value
			End Set
		End Property

		' Token: 0x17000717 RID: 1815
		' (get) Token: 0x06001F66 RID: 8038 RVA: 0x000CA60B File Offset: 0x000C880B
		' (set) Token: 0x06001F67 RID: 8039 RVA: 0x000CA613 File Offset: 0x000C8813
		<oO0oooo("3283")>
		Public Property SamePeriodGrowth As Boolean
			Get
				Return Me.O0.0_O_ooO.
			End Get
			Set(value As Boolean)
				Me.O0.0_O_ooO. = value
			End Set
		End Property

		' Token: 0x17000718 RID: 1816
		' (get) Token: 0x06001F68 RID: 8040 RVA: 0x000CA61C File Offset: 0x000C881C
		' (set) Token: 0x06001F69 RID: 8041 RVA: 0x000CA624 File Offset: 0x000C8824
		<oO0oooo("3283")>
		Public Property CircleGrowth As Boolean
			Get
				Return Me.OOo0o.O0oO.
			End Get
			Set(value As Boolean)
				Me.OOo0o.O0oO. = value
			End Set
		End Property

		' Token: 0x17000719 RID: 1817
		' (get) Token: 0x06001F6A RID: 8042 RVA: 0x000CA62D File Offset: 0x000C882D
		' (set) Token: 0x06001F6B RID: 8043 RVA: 0x000CA635 File Offset: 0x000C8835
		<oO0oooo("1618")>
		Public Property GrandProportion As Boolean
			Get
				Return Me.o_0O0Oo_0o.o.
			End Get
			Set(value As Boolean)
				Me.o_0O0Oo_0o.o. = value
			End Set
		End Property

		' Token: 0x1700071A RID: 1818
		' (get) Token: 0x06001F6C RID: 8044 RVA: 0x000CA63E File Offset: 0x000C883E
		' (set) Token: 0x06001F6D RID: 8045 RVA: 0x000CA646 File Offset: 0x000C8846
		<oO0oooo("1618")>
		Public Property GroupProportion As Boolean
			Get
				Return Me.Oo0.__.
			End Get
			Set(value As Boolean)
				Me.Oo0.__. = value
			End Set
		End Property

		' Token: 0x1700071B RID: 1819
		' (get) Token: 0x06001F6E RID: 8046 RVA: 0x000CA64F File Offset: 0x000C884F
		' (set) Token: 0x06001F6F RID: 8047 RVA: 0x000CA657 File Offset: 0x000C8857
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TableName As String
			Get
				Return Me.o.O0__OO.
			End Get
			Set(value As String)
				Me.o.O0__OO. = value
			End Set
		End Property

		' Token: 0x1700071C RID: 1820
		' (get) Token: 0x06001F70 RID: 8048 RVA: 0x000CA660 File Offset: 0x000C8860
		' (set) Token: 0x06001F71 RID: 8049 RVA: 0x000CA668 File Offset: 0x000C8868
		Public Property TableVisible As Boolean
			Get
				Return Me.o.O0__OO.
			End Get
			Set(value As Boolean)
				Me.o.O0__OO. = value
			End Set
		End Property

		' Token: 0x1700071D RID: 1821
		' (get) Token: 0x06001F72 RID: 8050 RVA: 0x000CA671 File Offset: 0x000C8871
		' (set) Token: 0x06001F73 RID: 8051 RVA: 0x000CA679 File Offset: 0x000C8879
		Public Property Caption As String
			Get
				Return Me.oO.00___0.
			End Get
			Set(value As String)
				Me.oO.00___0. = value
			End Set
		End Property

		' Token: 0x1700071E RID: 1822
		' (get) Token: 0x06001F74 RID: 8052 RVA: 0x000CA682 File Offset: 0x000C8882
		' (set) Token: 0x06001F75 RID: 8053 RVA: 0x000CA68A File Offset: 0x000C888A
		Public Property SourceDataTable As DataTable
			Get
				Return Me.O.00OOoo_0O_.
			End Get
			Set(value As DataTable)
				Me.O.00OOoo_0O_. = value
			End Set
		End Property

		' Token: 0x1700071F RID: 1823
		' (get) Token: 0x06001F76 RID: 8054 RVA: 0x000CA693 File Offset: 0x000C8893
		' (set) Token: 0x06001F77 RID: 8055 RVA: 0x000CA69B File Offset: 0x000C889B
		Public Property Filter As String
			Get
				Return Me.Oo.O0O_0.
			End Get
			Set(value As String)
				Me.Oo.O0O_0. = value
			End Set
		End Property

		' Token: 0x17000720 RID: 1824
		' (get) Token: 0x06001F78 RID: 8056 RVA: 0x000CA6A4 File Offset: 0x000C88A4
		' (set) Token: 0x06001F79 RID: 8057 RVA: 0x000CA6AC File Offset: 0x000C88AC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ExtendFilter As String
			Get
				Return Me.oO0o_.OOO0_.
			End Get
			Set(value As String)
				Me.oO0o_.OOO0_. = value
			End Set
		End Property

		' Token: 0x17000721 RID: 1825
		' (get) Token: 0x06001F7A RID: 8058 RVA: 0x000CA6B5 File Offset: 0x000C88B5
		' (set) Token: 0x06001F7B RID: 8059 RVA: 0x000CA6BD File Offset: 0x000C88BD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FromAll As Boolean
			Get
				Return Me.O.00_0OO0_.
			End Get
			Set(value As Boolean)
				Me.O.00_0OO0_. = value
			End Set
		End Property

		' Token: 0x17000722 RID: 1826
		' (get) Token: 0x06001F7C RID: 8060 RVA: 0x000CA6C6 File Offset: 0x000C88C6
		' (set) Token: 0x06001F7D RID: 8061 RVA: 0x000CA6CE File Offset: 0x000C88CE
		Public Property VerticalTotal As Boolean
			Get
				Return Me.o0.o_O0O.
			End Get
			Set(value As Boolean)
				Me.o0.o_O0O. = value
			End Set
		End Property

		' Token: 0x17000723 RID: 1827
		' (get) Token: 0x06001F7E RID: 8062 RVA: 0x000CA6D7 File Offset: 0x000C88D7
		' (set) Token: 0x06001F7F RID: 8063 RVA: 0x000CA6DF File Offset: 0x000C88DF
		<oO0oooo("2669")>
		Public Property Subtotal As Boolean
			Get
				Return Me.ooOoo__0._o_.
			End Get
			Set(value As Boolean)
				Me.ooOoo__0._o_. = value
			End Set
		End Property

		' Token: 0x17000724 RID: 1828
		' (get) Token: 0x06001F80 RID: 8064 RVA: 0x000CA6E8 File Offset: 0x000C88E8
		' (set) Token: 0x06001F81 RID: 8065 RVA: 0x000CA6F0 File Offset: 0x000C88F0
		<oO0oooo("2669")>
		Public Property SubtotalLevel As Integer
			Get
				Return Me.O.00_0OO0_.
			End Get
			Set(value As Integer)
				Me.O.00_0OO0_. = value
			End Set
		End Property

		' Token: 0x17000725 RID: 1829
		' (get) Token: 0x06001F82 RID: 8066 RVA: 0x000CA6F9 File Offset: 0x000C88F9
		Public ReadOnly Property Groups As GroupCollection
			Get
				Return Me.O.00OOoo_0O_.
			End Get
		End Property

		' Token: 0x17000726 RID: 1830
		' (get) Token: 0x06001F83 RID: 8067 RVA: 0x000CA701 File Offset: 0x000C8901
		Public ReadOnly Property Totals As TotalCollection
			Get
				Return Me.o.O0__OO.
			End Get
		End Property

		' Token: 0x06001F84 RID: 8068 RVA: 0x000CA70C File Offset: 0x000C890C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overridable Function Build(ParamArray args As Object()) As DataTable
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

		' Token: 0x06001F85 RID: 8069 RVA: 0x000CA750 File Offset: 0x000C8950
		Public Overridable Function Build() As DataTable
			If Me.SourceDataTable IsNot Nothing AndAlso OO_00oOO.Tables.get_Contains(Me.SourceDataTable.Name) Then
				OO_00oOO.Tables(Me.SourceDataTable.Name).O_0._O_0OO000O. = Me
			End If
			Return Me.Build(False)
		End Function

		' Token: 0x06001F86 RID: 8070 RVA: 0x000CA7A0 File Offset: 0x000C89A0
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer = Me.Totals.Count - 1
			For i As Integer = 0 To num
				Dim totalOn As TotalOn = Me.Totals(i)
				Dim flag As Boolean = False
				Dim num2 As Integer = i + 1
				Dim num3 As Integer = Me.Totals.Count - 1
				For j As Integer = num2 To num3
					Dim totalOn2 As TotalOn = Me.Totals(j)
					If Operators.CompareString(totalOn2.NewName, totalOn.NewName, True) = 0 AndAlso totalOn.Aggregate <> totalOn2.Aggregate Then
						flag = True
						totalOn2.NewName = totalOn2.NewName + "_" + Oo00.OoO_.__o.(totalOn2.Aggregate)
					End If
				Next
				If flag Then
					totalOn.NewName = totalOn.NewName + "_" + Oo00.OoO_.__o.(totalOn.Aggregate)
				End If
			Next
		End Sub

		' Token: 0x06001F87 RID: 8071 RVA: 0x000CA87C File Offset: 0x000C8A7C
		Public Overridable Function Build(OnlyDataTable As Boolean) As DataTable
			Me.o00OO.oOO0O_.()
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
			Dim dataTable2 As DataTable = Me.oO_oO._O__O.(dataTable, OnlyDataTable, a_)
			If Me.Subtotal AndAlso Not OnlyDataTable Then
				Me.oO0.O00oO.(dataTable2.Name, dataTable)
			End If
			Return dataTable2
		End Function

		' Token: 0x06001F88 RID: 8072 RVA: 0x000CA93C File Offset: 0x000C8B3C
		Protected Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable)
			Dim num As Integer
			Dim num13 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim table As Table = OO_00oOO.Tables(A_0)
				IL_15:
				num2 = 3
				table.SubtotalGroups.Clear()
				IL_22:
				num2 = 4
				If Me.SubtotalLevel <> -1 Then
					GoTo IL_38
				End If
				IL_2D:
				num2 = 5
				Dim num3 As Integer = Integer.MaxValue
				GoTo IL_42
				IL_38:
				num2 = 7
				num3 = Me.SubtotalLevel
				IL_42:
				num2 = 8
				If num3 <= 0 Then
					GoTo IL_2C6
				End If
				IL_4C:
				num2 = 9
				Dim num4 As Integer = Math.Min(num3 - 1, Me.Groups.Count - 2)
				IL_67:
				num2 = 10
				For i As Integer = num4 To 0 Step -1
					IL_73:
					num2 = 11
					Dim text As String = ""
					IL_7D:
					num2 = 12
					Dim enumerator As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
					While enumerator.MoveNext()
						Dim totalOn As TotalOn = enumerator.Current
						IL_9B:
						num2 = 13
						text = text + "," + totalOn.NewName
						IL_B3:
						num2 = 14
						If A_1.Columns.Contains(totalOn.NewName + "gdr") Then
							IL_D4:
							num2 = 15
							text = text + "," + totalOn.NewName + "gdr"
						End If
						IL_F1:
						num2 = 16
						Dim num5 As Integer = Me.Groups.Count - 2
						For j As Integer = 0 To num5
							IL_108:
							num2 = 17
							If j <= i Then
								IL_111:
								num2 = 19
								Dim text2 As String = totalOn.NewName + Me.Groups(j).NewName + "gpr"
								IL_139:
								num2 = 20
								If A_1.Columns.Contains(text2) Then
									IL_14B:
									num2 = 21
									text = text + "," + text2
								End If
							End If
							IL_15E:
							num2 = 22
						Next
						IL_16D:
						num2 = 23
					End While
					IL_17C:
					num2 = 24
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
					IL_18A:
					num2 = 25
					text = text.Trim(New Char() { ","c })
					IL_1A1:
					num2 = 26
					Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
					IL_1AB:
					num2 = 27
					subtotalGroup.GroupOn = Me.Groups(i).NewName
					IL_1C7:
					num2 = 28
					subtotalGroup.TotalOn = text
					IL_1D3:
					num2 = 29
					If Me.Totals.Count > 0 Then
						IL_1E4:
						num2 = 30
						If Me.Totals(0).Aggregate = 4 Then
							IL_1FB:
							num2 = 31
							subtotalGroup.Aggregate = 2
						Else
							IL_208:
							num2 = 33
							subtotalGroup.Aggregate = Me.Totals(0).Aggregate
						End If
					Else
						IL_225:
						num2 = 35
						If Me.Totals.Exprs.Count > 0 Then
							IL_23B:
							num2 = 36
							If Me.Totals.Exprs(0).Aggregate = 4 Then
								IL_257:
								num2 = 37
								subtotalGroup.Aggregate = 2
							Else
								IL_264:
								num2 = 39
								subtotalGroup.Aggregate = Me.Totals.Exprs(0).Aggregate
							End If
						End If
					End If
					IL_284:
					num2 = 40
					subtotalGroup.Caption = "小计 {0}"
					IL_293:
					num2 = 41
					table.SubtotalGroups.Add(subtotalGroup)
					IL_2A3:
					num2 = 42
					Dim num6 As Integer
					num6 += 1
					IL_2AC:
					num2 = 43
					If num6 >= num3 Then
						Exit For
					End If
					IL_2B5:
					num2 = 45
				Next
				IL_2C6:
				num2 = 46
				Dim text3 As String = ""
				IL_2D0:
				num2 = 47
				Dim enumerator2 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator2.MoveNext()
					Dim totalOn2 As TotalOn = enumerator2.Current
					IL_2EB:
					num2 = 48
					text3 = text3 + "," + totalOn2.NewName
					IL_303:
					num2 = 49
					If A_1.Columns.Contains(totalOn2.NewName + "gdr") Then
						IL_324:
						num2 = 50
						text3 = text3 + "," + totalOn2.NewName + "gdr"
					End If
					IL_341:
					num2 = 51
				End While
				IL_34D:
				num2 = 52
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_35B:
				num2 = 53
				text3 = text3.Trim(New Char() { ","c })
				IL_372:
				num2 = 54
				Dim subtotalGroup2 As SubtotalGroup = New SubtotalGroup()
				IL_37C:
				num2 = 55
				subtotalGroup2.GroupOn = "*"
				IL_38B:
				num2 = 56
				subtotalGroup2.TotalOn = text3
				IL_397:
				num2 = 57
				If Me.Totals.Count <= 0 Then
					GoTo IL_3E9
				End If
				IL_3A8:
				num2 = 58
				If Me.Totals(0).Aggregate <> 4 Then
					GoTo IL_3CC
				End If
				IL_3BF:
				num2 = 59
				subtotalGroup2.Aggregate = 2
				GoTo IL_448
				IL_3CC:
				num2 = 61
				subtotalGroup2.Aggregate = Me.Totals(0).Aggregate
				GoTo IL_448
				IL_3E9:
				num2 = 63
				If Me.Totals.Exprs.Count <= 0 Then
					GoTo IL_448
				End If
				IL_3FF:
				num2 = 64
				If Me.Totals.Exprs(0).Aggregate <> 4 Then
					GoTo IL_428
				End If
				IL_41B:
				num2 = 65
				subtotalGroup2.Aggregate = 2
				GoTo IL_448
				IL_428:
				num2 = 67
				subtotalGroup2.Aggregate = Me.Totals.Exprs(0).Aggregate
				IL_448:
				num2 = 68
				subtotalGroup2.Caption = "总计"
				IL_457:
				num2 = 69
				table.SubtotalGroups.Add(subtotalGroup2)
				IL_467:
				num2 = 70
				table.Subtotal(False)
				IL_471:
				num2 = 71
				If Me.ooO.oO0O00O0..Count <= 0 Then
					GoTo IL_5F3
				End If
				IL_485:
				num2 = 72
				Dim o_oOooO_O As O_oOooO_O = table.foxGrid
				IL_490:
				num2 = 73
				Dim num7 As Integer = o_oOooO_O.Rows.Count - 1
				Dim num8 As Integer = o_oOooO_O.Rows.Fixed + 1
				For k As Integer = num7 To num8 Step -1
					IL_4B8:
					num2 = 74
					Dim row As Row = o_oOooO_O.Rows(k)
					IL_4CB:
					num2 = 75
					If row.IsNode Then
						IL_4DA:
						num2 = 76
						If row.Node.PrevNode IsNot Nothing Then
							IL_4EE:
							num2 = 77
							Dim row2 As Row = row.Node.PrevNode.Row
							IL_504:
							num2 = 78
							Dim num9 As Integer = Me.ooO.oO0O00O0..Count - 1
							For l As Integer = 0 To num9
								IL_51E:
								num2 = 79
								Dim text4 As String = Me.ooO.oO0O00O0.(l)
								IL_530:
								num2 = 80
								Dim objectValue As Object = RuntimeHelpers.GetObjectValue(row2(text4))
								IL_543:
								num2 = 81
								If objectValue IsNot Nothing Then
									IL_54D:
									num2 = 82
									Dim s As String = objectValue.ToString()
									IL_559:
									num2 = 83
									Dim num10 As Double
									If Double.TryParse(s, num10) Then
										IL_567:
										num2 = 84
										If num10 > 0.0 Then
											IL_577:
											num2 = 85
											Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(row(text4))
											IL_58A:
											num2 = 86
											If objectValue2 IsNot Nothing Then
												IL_591:
												num2 = 87
												Dim s2 As String = objectValue2.ToString()
												IL_59D:
												num2 = 88
												Dim num11 As Double
												If Double.TryParse(s2, num11) Then
													IL_5AB:
													num2 = 89
													row(Me.o0.o_O0O.(l)) = (num11 - num10) / num10
												End If
											End If
										End If
									End If
								End If
								IL_5CF:
								num2 = 90
							Next
						End If
					End If
					IL_5E1:
					num2 = 91
				Next
				IL_5F3:
				GoTo IL_7B5
				IL_5F8:
				Dim num12 As Integer = num13 + 1
				num13 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12)
				IL_776:
				GoTo IL_7AA
				IL_778:
				num13 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_788:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num13 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_778
			End Try
			IL_7AA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7B5:
			If num13 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001F89 RID: 8073 RVA: 0x000CB124 File Offset: 0x000C9324
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001F8A RID: 8074 RVA: 0x000CB140 File Offset: 0x000C9340
		<oO0oooo("1909")>
		Public Function BuildDataSource() As fxDataSource
			Me.o00OO.oOO0O_.()
			Dim fxDataSource As fxDataSource
			If Me.FromServer OrElse Operators.CompareString(Me.SelectString, "", True) > 0 Then
				fxDataSource = Me.o0_O.00ooOo0.()
			Else
				fxDataSource = Me.O.O0_0O.()
			End If
			Dim result As fxDataSource
			If fxDataSource Is Nothing Then
				result = Nothing
			Else
				If Operators.CompareString(Me.SelectString, "", True) = 0 Then
					Me.oO0O.__o_OO_oo.(fxDataSource, Me.SourceDataTable.BaseTable)
				Else
					Me.oO0O.__o_OO_oo.(fxDataSource, Me.o.O0__OO.)
				End If
				If Me.SourceDataTable IsNot Nothing Then
					Try
						For Each totalOn As TotalOn In Me.Totals
							If fxDataSource.Columns.Contains(totalOn.NewName) AndAlso Me.SourceDataTable.DataCols(totalOn.Name).ExtendColumnType = 8 Then
								fxDataSource.Columns(totalOn.NewName).ExtendedProperties.Add("IsTimeSpan", "")
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of TotalOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				fxDataSource.O_O_O.00. = Me
				result = fxDataSource
			End If
			Return result
		End Function

		' Token: 0x06001F8B RID: 8075 RVA: 0x000CB260 File Offset: 0x000C9460
		Friend Function <<EMPTY_NAME>>() As fxDataSource
			Return Me.o00OO.oOO0O_.()
		End Function

		' Token: 0x06001F8C RID: 8076 RVA: 0x000CB268 File Offset: 0x000C9468
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As DataServerTypeEnum) As String
			If A_1.IndexOf("trim(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If A_1.IndexOf("convert", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If A_1.IndexOf("Parent(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If A_1.IndexOf("Parent.", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If A_1.IndexOf("Child(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If A_1.IndexOf("Child.", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If(A_2 = DataServerTypeEnum.Oracle OrElse A_2 = DataServerTypeEnum.SqlServer) AndAlso A_1.IndexOf("iif(", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
				A_1 = "0"
			End If
			If Operators.CompareString(A_1, "0", True) = 0 Then
				MessageBox.Show("列""" + A_0 + """不支持后台统计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
			Return A_1
		End Function

		' Token: 0x06001F8D RID: 8077 RVA: 0x000CB344 File Offset: 0x000C9544
		Private Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String) As String
			Dim text As String = A_1
			Dim match As Match = Regex.Match(A_1, "[[0-9a-zA-Z\u4e00-\u9fa5_]+]")
			While Operators.CompareString(match.ToString(), "", True) <> 0
				Dim text2 As String = match.ToString()
				Dim text3 As String = Oo00.oo0o.O0O_0__.(text2.Trim(New Char() { "["c }).Trim(New Char() { "]"c }), A_0)
				If Not Oo00.OO_O_0O0OO0_.o.(text3) Then
					text3 = "[" + text3 + "]"
				Else
					text3 = "(" + text3 + ")"
				End If
				text = text.Replace(text2, text3)
				match = match.NextMatch()
			End While
			Return text
		End Function

		' Token: 0x06001F8E RID: 8078 RVA: 0x000CB3E0 File Offset: 0x000C95E0
		Private Function <<EMPTY_NAME>>() As fxDataSource
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
				Dim dataTable As DataTable = Nothing
				IL_15:
				num2 = 4
				Dim text As String = ""
				IL_1E:
				num2 = 5
				Dim text2 As String = ""
				IL_27:
				num2 = 6
				Dim oleDbConnection As OleDbConnection = Nothing
				IL_2C:
				num2 = 7
				Dim text3 As String = ""
				IL_35:
				num2 = 8
				Dim dataServerTypeEnum As DataServerTypeEnum = DataServerTypeEnum.Access
				IL_3A:
				num2 = 9
				If Operators.CompareString(Me.SelectString, "", True) <> 0 Then
					GoTo IL_10C
				End If
				IL_53:
				num2 = 10
				dataTable = Me.SourceDataTable.BaseTable
				IL_63:
				num2 = 11
				If Operators.CompareString(Me.SourceDataTable.DataServer, "", True) <= 0 Then
					GoTo IL_C6
				End If
				IL_7F:
				num2 = 12
				Me.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()(Me.SourceDataTable.ConnectionName).oO0_0.o.()
				IL_A2:
				num2 = 13
				dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()(Me.SourceDataTable.ConnectionName).OO.OoO0.
				GoTo IL_311
				IL_C6:
				num2 = 15
				oleDbConnection = New OleDbConnection(Me.SourceDataTable.frd_Connection.ConnectionString)
				IL_E0:
				num2 = 16
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
					GoTo IL_F2
				End If
				IL_EC:
				num2 = 17
				dataServerTypeEnum = DataServerTypeEnum.Oracle
				IL_F2:
				num2 = 18
				If Not o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
					GoTo IL_311
				End If
				IL_101:
				num2 = 19
				dataServerTypeEnum = DataServerTypeEnum.SqlServer
				GoTo IL_311
				IL_10C:
				num2 = 21
				If Operators.CompareString(Me.SelectString, "", True) <= 0 Then
					GoTo IL_311
				End If
				IL_126:
				num2 = 22
				If Operators.CompareString(Me.ConnectionName, "", True) <= 0 OrElse Not O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
					GoTo IL_22B
				End If
				IL_155:
				num2 = 23
				dataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).OO.OoO0.
				IL_16F:
				num2 = 24
				Me.SelectString = Oo00.o0_o._O_.(dataServerTypeEnum, Me.SelectString, False)
				IL_186:
				num2 = 25
				Me.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				IL_1A4:
				num2 = 26
				Me.o.O0__OO. = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName).oO0_0.o.()
				IL_1C2:
				num2 = 27
				Me.o.O0__OO..[Select] = Me.SelectString
				IL_1D6:
				num2 = 28
				Me.o.O0__OO..FormData("Action") = 12.ToString()
				IL_1F9:
				num2 = 29
				Me.o.O0__OO. = Me.o.O0__OO..GetBaseDataTable()
				IL_20D:
				num2 = 30
				dataTable = Me.o.O0__OO.
				IL_218:
				num2 = 31
				Me.o.O0__OO..Reset()
				GoTo IL_311
				IL_22B:
				num2 = 33
				Dim a_ As Boolean = False
				IL_231:
				num2 = 34
				If Operators.CompareString(Me.ConnectionName, "", True) <= 0 Then
					GoTo IL_269
				End If
				IL_248:
				num2 = 35
				oleDbConnection = New OleDbConnection(O_O0OO.O._o_.()(Me.ConnectionName).ConnectionString)
				GoTo IL_283
				IL_269:
				num2 = 37
				oleDbConnection = New OleDbConnection(O_O0OO.OoO.0OO__0ooo.().ConnectionString)
				IL_27D:
				num2 = 38
				a_ = True
				IL_283:
				num2 = 39
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
					GoTo IL_295
				End If
				IL_28F:
				num2 = 40
				dataServerTypeEnum = DataServerTypeEnum.Oracle
				IL_295:
				num2 = 41
				If Not o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
					GoTo IL_2A7
				End If
				IL_2A1:
				num2 = 42
				dataServerTypeEnum = DataServerTypeEnum.SqlServer
				IL_2A7:
				num2 = 43
				Me.SelectString = Oo00.o0_o._O_.(oleDbConnection, Me.SelectString, a_)
				IL_2BF:
				num2 = 44
				Me.o.O0__OO. = New DataTable()
				IL_2CD:
				num2 = 45
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Me.SelectString, oleDbConnection)
				IL_2DF:
				num2 = 46
				oleDbDataAdapter.SelectCommand.CommandTimeout = Me.CommandTimeOut
				IL_2F4:
				num2 = 47
				oleDbDataAdapter.FillSchema(Me.o.O0__OO., SchemaType.Source)
				IL_306:
				num2 = 48
				dataTable = Me.o.O0__OO.
				IL_311:
				num2 = 49
				Dim enumerator As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_32F:
					num2 = 50
					If Operators.CompareString(text, "", True) > 0 Then
						IL_342:
						num2 = 51
						text += ","
					End If
					IL_353:
					num2 = 52
					If Operators.CompareString(text2, "", True) > 0 Then
						IL_366:
						num2 = 53
						text2 += ","
					End If
					IL_377:
					num2 = 54
					Dim text4 As String = groupOn.Name
					IL_383:
					num2 = 55
					If Me.SourceDataTable IsNot Nothing Then
						IL_391:
						num2 = 56
						If Operators.CompareString(Me.SourceDataTable.o._OOO0oOo0__., "", True) > 0 Then
							IL_3AD:
							num2 = 57
							text4 = Oo00.OoOo_oo_.o_o.(text4, Me.SourceDataTable)
							IL_3BF:
							num2 = 58
							text4 = Me.oO_oO._O__O.(groupOn.Name, text4, dataServerTypeEnum)
						Else
							IL_3DA:
							num2 = 60
							If Operators.CompareString(Me.SourceDataTable.DataCols(groupOn.Name).Expression, "", True) > 0 Then
								IL_40A:
								num2 = 61
								text4 = Me.SourceDataTable.DataCols(groupOn.Name).Expression
								IL_42B:
								num2 = 62
								Dim enumerator2 As IEnumerator(Of DataCol) = Me.SourceDataTable.DataCols.GetEnumerator()
								While enumerator2.MoveNext()
									Dim dataCol As DataCol = enumerator2.Current
									IL_44B:
									num2 = 63
									If Operators.CompareString(dataCol.Expression, "", True) > 0 Then
										IL_463:
										num2 = 64
										Dim num3 As Integer = text4.IndexOf("[" + dataCol.Name + "]", StringComparison.CurrentCultureIgnoreCase)
										IL_486:
										num2 = 65
										If num3 >= 0 Then
											IL_48E:
											num2 = 66
											text4 = text4.Substring(0, num3) + dataCol.Expression + text4.Substring(dataCol.Name.Length + 2)
										End If
									End If
									IL_4BE:
									num2 = 67
								End While
								IL_4CD:
								num2 = 68
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
								IL_4DB:
								num2 = 69
								text4 = Me.OO0__0_.o00.(Me.SourceDataTable, text4)
								IL_4EE:
								num2 = 70
								text4 = Oo00.OoOo_oo_.o_o.(text4, Me.SourceDataTable)
								IL_500:
								num2 = 71
								text4 = Oo00.ooO.ooo.(Me.SourceDataTable, text4)
								IL_512:
								num2 = 72
								text4 = Me.oO_oO._O__O.(groupOn.Name, text4, dataServerTypeEnum)
							End If
						End If
					End If
					IL_528:
					num2 = 73
					If dataTable.Columns.Contains(groupOn.Name) Then
						IL_540:
						num2 = 74
						If dataTable.Columns(groupOn.Name).DataType Is GetType(DateTime) AndAlso groupOn.DateGroup IsNot Nothing Then
							IL_570:
							num2 = 75
							groupOn.IsDate = True
						End If
					End If
					IL_57B:
					num2 = 76
					If dataTable.Columns(groupOn.Name).DataType Is GetType(DateTime) AndAlso groupOn.DateGroup IsNot Nothing Then
						IL_5AB:
						num2 = 77
						Dim str As String = o_O_o_oOoo__.OO_O0oO0.oooO_.("", text4, groupOn.DateGroup, dataServerTypeEnum)
						IL_5C5:
						num2 = 78
						text += str
						IL_5D3:
						num2 = 79
						text2 += str
						IL_5E1:
						num2 = 80
						text = text + " As [" + groupOn.NewName + "]"
					Else
						IL_600:
						num2 = 82
						Dim text5 As String = text4
						IL_607:
						num2 = 83
						If Not Oo00.OO_O_0O0OO0_.o.(text5) Then
							IL_613:
							num2 = 84
							text5 = "[" + text5 + "]"
						Else
							IL_62B:
							num2 = 86
							text5 = "(" + text5 + ")"
						End If
						IL_641:
						num2 = 87
						text += text5
						IL_64F:
						num2 = 88
						text2 += text5
						IL_65D:
						num2 = 89
						text = text + " As [" + groupOn.NewName + "]"
					End If
					IL_67A:
					num2 = 90
				End While
				IL_689:
				num2 = 91
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_697:
				num2 = 92
				Dim enumerator3 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim totalOn As TotalOn = enumerator3.Current
					IL_6B5:
					num2 = 93
					Dim str2 As String = ""
					IL_6BF:
					num2 = 94
					Dim text6 As String = totalOn.Name
					IL_6CB:
					num2 = 95
					If Me.SourceDataTable IsNot Nothing Then
						IL_6D9:
						num2 = 96
						If Operators.CompareString(Me.SourceDataTable.o._OOO0oOo0__., "", True) > 0 Then
							IL_6F5:
							num2 = 97
							text6 = Oo00.OoOo_oo_.o_o.(text6, Me.SourceDataTable)
							IL_707:
							num2 = 98
							text6 = Me.oO_oO._O__O.(totalOn.Name, text6, dataServerTypeEnum)
						Else
							IL_722:
							num2 = 100
							If Operators.CompareString(Me.SourceDataTable.DataCols(totalOn.Name).Expression, "", True) > 0 Then
								IL_752:
								num2 = 101
								text6 = Me.SourceDataTable.DataCols(totalOn.Name).Expression
								IL_773:
								num2 = 102
								Dim enumerator4 As IEnumerator(Of DataCol) = Me.SourceDataTable.DataCols.GetEnumerator()
								While enumerator4.MoveNext()
									Dim dataCol2 As DataCol = enumerator4.Current
									IL_793:
									num2 = 103
									If Operators.CompareString(dataCol2.Expression, "", True) > 0 Then
										IL_7AB:
										num2 = 104
										Dim num4 As Integer = text6.IndexOf("[" + dataCol2.Name + "]", StringComparison.CurrentCultureIgnoreCase)
										IL_7CE:
										num2 = 105
										If num4 >= 0 Then
											IL_7D6:
											num2 = 106
											text6 = text6.Substring(0, num4) + dataCol2.Expression + text6.Substring(dataCol2.Name.Length + 2)
										End If
									End If
									IL_806:
									num2 = 107
								End While
								IL_815:
								num2 = 108
								If enumerator4 IsNot Nothing Then
									enumerator4.Dispose()
								End If
								IL_823:
								num2 = 109
								text6 = Me.OO0__0_.o00.(Me.SourceDataTable, text6)
								IL_836:
								num2 = 110
								text6 = Oo00.OoOo_oo_.o_o.(text6, Me.SourceDataTable)
								IL_848:
								num2 = 111
								text6 = Oo00.ooO.ooo.(Me.SourceDataTable, text6)
								IL_85A:
								num2 = 112
								text6 = Me.oO_oO._O__O.(totalOn.Name, text6, dataServerTypeEnum)
							End If
						End If
					End If
					IL_870:
					num2 = 113
					Select Case totalOn.Aggregate
						Case 2
							IL_8A6:
							num2 = 115
							str2 = String.Concat(New String() { "Sum(", text6, ") As [", totalOn.NewName, "]" })
						Case 4
							IL_91E:
							num2 = 119
							str2 = String.Concat(New String() { "Count(", text6, ") As [", totalOn.NewName, "]" })
						Case 6
							IL_8E2:
							num2 = 117
							str2 = String.Concat(New String() { "Avg(", text6, ") As [", totalOn.NewName, "]" })
						Case 7
							IL_957:
							num2 = 121
							str2 = String.Concat(New String() { "Max(", text6, ") As [", totalOn.NewName, "]" })
						Case 8
							IL_990:
							num2 = 123
							str2 = String.Concat(New String() { "Min(", text6, ") As [", totalOn.NewName, "]" })
					End Select
					IL_9C7:
					num2 = 125
					text = text + "," + str2
					IL_9DA:
					num2 = 126
				End While
				IL_9E9:
				num2 = 127
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_9F7:
				num2 = 128
				If Operators.CompareString(Me.SelectString, "", True) <= 0 Then
					GoTo IL_A4F
				End If
				IL_A11:
				num2 = 129
				Dim text7 As String = String.Concat(New String() { "Select ", text, " From (", Me.SelectString, ") tmptbl" })
				GoTo IL_BA8
				IL_A4F:
				num2 = 131
				If Operators.CompareString(Me.SourceDataTable.o._OOO0oOo0__., "", True) <> 0 Then
					GoTo IL_B24
				End If
				IL_A70:
				num2 = 132
				If Operators.CompareString(Me.SourceDataTable.DataServer, "", True) <= 0 Then
					GoTo IL_AD2
				End If
				IL_A8F:
				num2 = 133
				text7 = String.Concat(New String() { "Select ", text, " From (", Me.SourceDataTable.HttpSelect, ") tmptbl" })
				GoTo IL_BA8
				IL_AD2:
				num2 = 135
				text7 = String.Concat(New String() { "Select ", text, " From (", Oo00.O0Oo_O.0O_0O.(Me.SourceDataTable._Adapter.SelectCommand.CommandText), ") tmptbl" })
				GoTo IL_BA8
				IL_B24:
				num2 = 137
				If dataServerTypeEnum <> DataServerTypeEnum.Oracle Then
					GoTo IL_B55
				End If
				IL_B2F:
				num2 = 138
				text7 = "Select " + text + " From " + Me.SourceDataTable.o._OOO0oOo0__.
				GoTo IL_BA8
				IL_B55:
				num2 = 140
				text7 = String.Concat(New String() { "Select ", text, " From [", Me.SourceDataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }), "]" })
				IL_BA8:
				num2 = 141
				If Me.SourceDataTable Is Nothing OrElse Operators.CompareString(Me.SourceDataTable.LoadFilter, "", True) <= 0 OrElse Me.SourceDataTable.LoadPage < 0 OrElse Operators.CompareString(Me.SourceDataTable.LoadTop, "", True) <= 0 OrElse Me.SourceDataTable.BaseTable.Rows.Count <= 0 Then
					GoTo IL_C21
				End If
				IL_C0E:
				num2 = 142
				text3 = Me.SourceDataTable.LoadFilter
				IL_C21:
				num2 = 143
				If Operators.CompareString(Me.Filter, "", True) <= 0 AndAlso Operators.CompareString(text3, "", True) <= 0 Then
					GoTo IL_CD4
				End If
				IL_C4E:
				num2 = 144
				If Operators.CompareString(Me.Filter, "", True) <= 0 OrElse Operators.CompareString(text3, "", True) <= 0 Then
					GoTo IL_CB8
				End If
				IL_C78:
				num2 = 145
				text7 = String.Concat(New String() { text7, " Where (", Me.Filter, ") And (", text3, ")" })
				GoTo IL_CD4
				IL_CB8:
				num2 = 147
				text7 = text7 + " Where " + Me.Filter + text3
				IL_CD4:
				num2 = 148
				text7 = text7 + " Group By " + text2
				IL_CEA:
				num2 = 149
				text7 = text7 + " ORDER BY " + text2
				IL_D00:
				num2 = 150
				If dataServerTypeEnum <> DataServerTypeEnum.Oracle Then
					GoTo IL_D33
				End If
				IL_D0B:
				num2 = 151
				text7 = text7.Replace("[", """").Replace("]", """")
				IL_D33:
				num2 = 152
				If Me.o.O0__OO. IsNot Nothing Then
					GoTo IL_D7F
				End If
				IL_D41:
				num2 = 153
				Dim oleDbDataAdapter2 As OleDbDataAdapter = New OleDbDataAdapter(text7, oleDbConnection)
				IL_D52:
				num2 = 154
				oleDbDataAdapter2.SelectCommand.CommandTimeout = Me.CommandTimeOut
				IL_D6A:
				num2 = 155
				oleDbDataAdapter2.Fill(fxDataSource)
				GoTo IL_E05
				IL_D7F:
				num2 = 157
				Me.o.O0__OO..[Select] = text7
				IL_D92:
				num2 = 158
				Me.o.O0__OO..FormData("Action") = 2.ToString()
				IL_DB7:
				num2 = 159
				Me.o.O0__OO..FormData("IgnoreSchema") = "True"
				IL_DD7:
				num2 = 160
				Dim baseDataTable As DataTable = Me.o.O0__OO..GetBaseDataTable()
				IL_DEA:
				num2 = 161
				If baseDataTable Is Nothing Then
					GoTo IL_E05
				End If
				IL_DF4:
				num2 = 162
				fxDataSource.Merge(baseDataTable, False, MissingSchemaAction.AddWithKey)
				IL_E05:
				num2 = 163
				If fxDataSource Is Nothing Then
					GoTo IL_F34
				End If
				IL_E12:
				num2 = 164
				Dim enumerator5 As IEnumerator = fxDataSource.Columns.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj As Object = enumerator5.Current
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					IL_E39:
					num2 = 165
					If dataColumn.DataType Is GetType(Double) OrElse dataColumn.DataType Is GetType(Single) OrElse dataColumn.DataType Is GetType(Decimal) Then
						IL_E7B:
						num2 = 166
						Dim enumerator6 As IEnumerator = fxDataSource.Rows.GetEnumerator()
						While enumerator6.MoveNext()
							Dim obj2 As Object = enumerator6.Current
							Dim dataRow As DataRow = CType(obj2, DataRow)
							IL_E9F:
							num2 = 167
							If Not dataRow.IsNull(dataColumn) Then
								IL_EB0:
								num2 = 168
								dataRow(dataColumn) = Math.Round(Conversions.ToDecimal(dataRow(dataColumn)), Me.Decimals)
							End If
							IL_EDD:
							num2 = 169
						End While
						IL_EEC:
						num2 = 170
						If TypeOf enumerator6 Is IDisposable Then
							TryCast(enumerator6, IDisposable).Dispose()
						End If
					End If
					IL_F07:
					num2 = 171
				End While
				IL_F19:
				num2 = 172
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_F34:
				num2 = 173
				result = fxDataSource
				IL_F3D:
				GoTo IL_1247
				IL_F42:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_1208:
				GoTo IL_123C
				IL_120A:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_121A:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_120A
			End Try
			IL_123C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1247:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06001F8F RID: 8079 RVA: 0x000CC65C File Offset: 0x000CA85C
		Friend Function <<EMPTY_NAME>>() As fxDataSource
			Return Me.oO_oO._O__O.()
		End Function

		' Token: 0x06001F90 RID: 8080 RVA: 0x000CC664 File Offset: 0x000CA864
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Try
				For Each groupOn As GroupOn In Me.Groups
					If Not Me.SourceDataTable.DataCols.Contains(groupOn.Name) Then
						MessageBox.Show("原数据表不存在名为""" + groupOn.Name + """的列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return Nothing
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of GroupOn)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				For Each totalOn As TotalOn In Me.Totals
					If Not Me.SourceDataTable.DataCols.Contains(totalOn.Name) Then
						MessageBox.Show("原数据表不存在名为""" + totalOn.Name + """的列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return Nothing
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of TotalOn)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Dim text As String = ""
			Dim text2 As String = ""
			Dim fxDataSource As fxDataSource = New fxDataSource()
			Dim dataTable As DataTable = Me.SourceDataTable.BaseTable
			Try
				OO_00oOO.SystemReady = False
				Dim num As Integer
				Try
					For Each groupOn2 As GroupOn In Me.Groups
						If Not fxDataSource.Columns.Contains(groupOn2.NewName) Then
							Dim dataColumn As DataColumn = dataTable.Columns(groupOn2.Name)
							If dataColumn.DataType Is GetType(DateTime) AndAlso groupOn2.DateGroup IsNot Nothing Then
								groupOn2.IsDate = True
								If Me.VerticalTotal AndAlso Not groupOn2.Vertical Then
									fxDataSource.Columns.Add(groupOn2.NewName, GetType(String), "")
								Else
									fxDataSource.Columns.Add(groupOn2.NewName, GetType(Integer), "")
								End If
								num += 1
							Else
								If Me.VerticalTotal AndAlso Not groupOn2.Vertical Then
									fxDataSource.Columns.Add(groupOn2.NewName, GetType(String), "")
								Else
									fxDataSource.Columns.Add(groupOn2.NewName, dataColumn.DataType, "")
								End If
								fxDataSource.Columns(groupOn2.NewName).MaxLength = dataColumn.MaxLength
							End If
						Else
							groupOn2.IsValid = False
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of GroupOn)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				For i As Integer = Me.Groups.Count - 1 To 0 Step -1
					If Not Me.Groups(i).IsValid Then
						Me.Groups.RemoveAt(i)
					End If
				Next
				If Me.Groups.Count = 0 Then
					Return Nothing
				End If
				Dim list As List(Of String) = New List(Of String)()
				Try
					For Each groupOn3 As GroupOn In Me.Groups
						If Not list.Contains(groupOn3.Name) Then
							list.Add(groupOn3.Name)
							Operators.CompareString(text, "", True)
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator(Of GroupOn)
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
				End Try
				Operators.CompareString(Me.Filter, "", True)
				text = Me.Filter
				Try
					For Each totalOn2 As TotalOn In Me.Totals
						Dim typeFromHandle As Type
						If totalOn2.Aggregate = 4 Then
							typeFromHandle = GetType(Long)
						ElseIf dataTable.Columns(totalOn2.Name).DataType Is GetType(Decimal) Then
							typeFromHandle = GetType(Decimal)
						Else
							typeFromHandle = GetType(Double)
						End If
						If list.Contains(totalOn2.NewName) Then
							Dim num2 As Integer = 0
							Do
								num2 += 1
							Loop While list.Contains(totalOn2.NewName + "_" + Conversions.ToString(num2))
							totalOn2.NewName = totalOn2.NewName + "_" + Conversions.ToString(num2)
						End If
						If Not fxDataSource.Columns.Contains(totalOn2.NewName) Then
							fxDataSource.Columns.Add(totalOn2.NewName, typeFromHandle)
							If totalOn2.Aggregate = 6 And num = 1 Then
								totalOn2.OOOo.o. = OoOo0O.OO_o.0o_O.(6)
								fxDataSource.Columns.Add(totalOn2.OOOo.o., GetType(Integer))
							End If
						End If
					Next
				Finally
					Dim enumerator5 As IEnumerator(Of TotalOn)
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
				End Try
				list.Clear()
				Try
					For Each groupOn4 As GroupOn In Me.Groups
						If Not list.Contains(groupOn4.Name) AndAlso Not groupOn4.IsDate Then
							list.Add(groupOn4.Name)
							If Operators.CompareString(text2, "", True) > 0 Then
								text2 += ","
							End If
							text2 += groupOn4.Name
						End If
					Next
				Finally
					Dim enumerator6 As IEnumerator(Of GroupOn)
					If enumerator6 IsNot Nothing Then
						enumerator6.Dispose()
					End If
				End Try
				Try
					For Each groupOn5 As GroupOn In Me.Groups
						If Not list.Contains(groupOn5.Name) AndAlso groupOn5.IsDate Then
							list.Add(groupOn5.Name)
							If Operators.CompareString(text2, "", True) > 0 Then
								text2 += ","
							End If
							text2 += groupOn5.Name
						End If
					Next
				Finally
					Dim enumerator7 As IEnumerator(Of GroupOn)
					If enumerator7 IsNot Nothing Then
						enumerator7.Dispose()
					End If
				End Try
				Dim dataView As DataView = New DataView(Me.SourceDataTable.BaseTable, text, text2, DataViewRowState.CurrentRows)
				Foxtable.RibbonMenu.StatusBar.Message1 = "正在统计..."
				Application.DoEvents()
				Dim num3 As Integer = dataView.Count - 1
				For j As Integer = 0 To num3
					Me.OO0__0_.o00.(dataView(j).Row)
					Dim flag As Boolean = True
					If j < dataView.Count - 1 Then
						Dim num4 As Integer = Me.Groups.Count - 1
						For k As Integer = 0 To num4
							Dim groupOn6 As GroupOn = Me.Groups(k)
							If Operators.CompareString(dataView(j)(groupOn6.Name).ToString().TrimEnd(New Char(-1) {}), dataView(j + 1)(groupOn6.Name).ToString().TrimEnd(New Char(-1) {}), True) <> 0 Then
								If Not groupOn6.IsDate Then
									flag = False
									Exit For
								End If
								Dim num5 As Integer
								If dataView(j).Row.IsNull(groupOn6.Name) Then
									num5 = -1
								Else
									num5 = Me.oO_oO._O__O.(Conversions.ToDate(dataView(j)(groupOn6.Name)), groupOn6.DateGroup)
								End If
								Dim num6 As Integer
								If dataView(j + 1).Row.IsNull(groupOn6.Name) Then
									num6 = -1
								Else
									num6 = Me.oO_oO._O__O.(Conversions.ToDate(dataView(j + 1)(groupOn6.Name)), groupOn6.DateGroup)
								End If
								If num5 <> num6 Then
									flag = False
									Exit For
								End If
							End If
						Next
					Else
						flag = False
					End If
					If Not flag Then
						Dim dataRow As DataRow = fxDataSource.NewRow()
						Dim num7 As Integer = Me.Groups.Count - 1
						For l As Integer = 0 To num7
							Dim groupOn7 As GroupOn = Me.Groups(l)
							If Me.Groups(l).IsDate Then
								If Not dataView(j).Row.IsNull(groupOn7.Name) Then
									Dim num8 As Integer = Me.oO_oO._O__O.(Conversions.ToDate(dataView(j)(groupOn7.Name)), groupOn7.DateGroup)
									If dataRow.Table.Columns(groupOn7.NewName).DataType Is GetType(String) Then
										Dim dateGroup As DateGroupEnum = groupOn7.DateGroup
										If dateGroup - 3 > 5 Then
											If dateGroup <> 9 Then
												dataRow(groupOn7.NewName) = num8
											Else
												dataRow(groupOn7.NewName) = Strings.Format(num8, "000")
											End If
										Else
											dataRow(groupOn7.NewName) = Strings.Format(num8, "00")
										End If
									Else
										dataRow(groupOn7.NewName) = num8
									End If
								End If
							ElseIf dataView.Table.Columns(groupOn7.Name).DataType Is GetType(DateTime) Then
								If Not dataView(j).Row.IsNull(groupOn7.Name) Then
									If dataView.Table.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
										dataRow(groupOn7.NewName) = Strings.Format(RuntimeHelpers.GetObjectValue(dataView(j)(groupOn7.Name)), OO_00oOO.Tables(dataView.Table.TableName).foxGrid.Cols(groupOn7.Name).Format)
									Else
										dataRow(groupOn7.NewName) = RuntimeHelpers.GetObjectValue(dataView(j)(groupOn7.Name))
									End If
								End If
							ElseIf fxDataSource.Columns(groupOn7.NewName).DataType Is GetType(String) Then
								dataRow(groupOn7.NewName) = dataView(j)(groupOn7.Name).ToString().TrimEnd(New Char(-1) {})
							Else
								dataRow(groupOn7.NewName) = RuntimeHelpers.GetObjectValue(dataView(j)(groupOn7.Name))
							End If
						Next
						Try
							For Each totalOn3 As TotalOn In Me.Totals
								Select Case totalOn3.Aggregate
									Case 2, 7, 8
										dataRow(totalOn3.NewName) = Math.Round(totalOn3.Oo_o0O00O.o0O., Me.Decimals)
									Case 4
										dataRow(totalOn3.NewName) = totalOn3.Oo_o0O00O.o0O.
									Case 6
										If num = 1 Then
											dataRow(totalOn3.NewName) = totalOn3.Oo_o0O00O.o0O.
											dataRow(totalOn3.OOOo.o.) = totalOn3.Oo_o0O00O.o0O.
										ElseIf totalOn3.Oo_o0O00O.o0O. > 0 Then
											dataRow(totalOn3.NewName) = Math.Round(totalOn3.Oo_o0O00O.o0O. / CDbl(totalOn3.Oo_o0O00O.o0O.), Me.Decimals)
										End If
								End Select
								totalOn3.Oo_o0O00O.o0O. = 0.0
								totalOn3.Oo_o0O00O.o0O. = 0
							Next
						Finally
							Dim enumerator8 As IEnumerator(Of TotalOn)
							If enumerator8 IsNot Nothing Then
								enumerator8.Dispose()
							End If
						End Try
						fxDataSource.Rows.Add(dataRow)
					End If
				Next
				If num = 1 Then
					text2 = ""
					Try
						For Each groupOn8 As GroupOn In Me.Groups
							If Operators.CompareString(text2, "", True) > 0 Then
								text2 += ","
							End If
							text2 += groupOn8.NewName
						Next
					Finally
						Dim enumerator9 As IEnumerator(Of GroupOn)
						If enumerator9 IsNot Nothing Then
							enumerator9.Dispose()
						End If
					End Try
					Dim recordIndex As Integer = 0
					Dim dataView2 As DataView = New DataView(fxDataSource, "", text2, DataViewRowState.CurrentRows)
					Dim text3 As String = OoOo0O.OO_o.0o_O.(6)
					fxDataSource.Columns.Add(text3, GetType(Boolean))
					Dim num9 As Integer = dataView2.Count - 1
					For m As Integer = 0 To num9
						Dim flag As Boolean = True
						If m > 0 Then
							Try
								For Each groupOn9 As GroupOn In Me.Groups
									If Operators.CompareString(dataView2(m)(groupOn9.NewName).ToString(), dataView2(m - 1)(groupOn9.NewName).ToString(), True) <> 0 Then
										flag = False
									End If
								Next
							Finally
								Dim enumerator10 As IEnumerator(Of GroupOn)
								If enumerator10 IsNot Nothing Then
									enumerator10.Dispose()
								End If
							End Try
							If flag Then
								dataView2(m)(text3) = True
								Try
									For Each totalOn4 As TotalOn In Me.Totals
										Select Case totalOn4.Aggregate
											Case 2, 4
												dataView2(recordIndex)(totalOn4.NewName) = Decimal.Add(Conversions.ToDecimal(dataView2(recordIndex)(totalOn4.NewName)), Conversions.ToDecimal(dataView2(m)(totalOn4.NewName)))
											Case 6
												dataView2(recordIndex)(totalOn4.NewName) = Decimal.Add(Conversions.ToDecimal(dataView2(recordIndex)(totalOn4.NewName)), Conversions.ToDecimal(dataView2(m)(totalOn4.NewName)))
												dataView2(recordIndex)(totalOn4.OOOo.o.) = Conversions.ToLong(dataView2(recordIndex)(totalOn4.OOOo.o.)) + Conversions.ToLong(dataView2(m)(totalOn4.OOOo.o.))
											Case 7
												dataView2(recordIndex)(totalOn4.NewName) = Math.Max(Conversions.ToDecimal(dataView2(recordIndex)(totalOn4.NewName)), Conversions.ToDecimal(dataView2(m)(totalOn4.NewName)))
											Case 8
												dataView2(recordIndex)(totalOn4.NewName) = Math.Min(Conversions.ToDecimal(dataView2(recordIndex)(totalOn4.NewName)), Conversions.ToDecimal(dataView2(m)(totalOn4.NewName)))
										End Select
									Next
								Finally
									Dim enumerator11 As IEnumerator(Of TotalOn)
									If enumerator11 IsNot Nothing Then
										enumerator11.Dispose()
									End If
								End Try
							End If
						End If
						If Not flag OrElse m = dataView2.Count - 1 Then
							Try
								For Each totalOn5 As TotalOn In Me.Totals
									If totalOn5.Aggregate = 6 Then
										Dim num10 As Double = Convert.ToDouble(Conversions.ToDecimal(dataView2(recordIndex)(totalOn5.NewName)))
										Dim num11 As Long = Conversions.ToLong(dataView2(recordIndex)(totalOn5.OOOo.o.))
										If num11 <> 0L Then
											dataView2(recordIndex)(totalOn5.NewName) = Math.Round(num10 / CDbl(num11), Me.Decimals)
										End If
									End If
								Next
							Finally
								Dim enumerator12 As IEnumerator(Of TotalOn)
								If enumerator12 IsNot Nothing Then
									enumerator12.Dispose()
								End If
							End Try
							recordIndex = m
						End If
						If Not flag AndAlso m = dataView2.Count - 1 Then
							Try
								For Each totalOn6 As TotalOn In Me.Totals
									If totalOn6.Aggregate = 6 Then
										Dim num12 As Double = Convert.ToDouble(Conversions.ToDecimal(dataView2(m)(totalOn6.NewName)))
										Dim num13 As Long = Conversions.ToLong(dataView2(m)(totalOn6.OOOo.o.))
										If num13 <> 0L Then
											dataView2(m)(totalOn6.NewName) = Math.Round(num12 / CDbl(num13), Me.Decimals)
										End If
									End If
								Next
							Finally
								Dim enumerator13 As IEnumerator(Of TotalOn)
								If enumerator13 IsNot Nothing Then
									enumerator13.Dispose()
								End If
							End Try
						End If
					Next
					Dim array As DataRow() = fxDataSource.[Select]("[" + text3 + "] = True")
					For n As Integer = 0 To array.Length - 1
						array(n).Delete()
					Next
					Try
						For Each totalOn7 As TotalOn In Me.Totals
							If totalOn7.Aggregate = 6 Then
								fxDataSource.Columns.Remove(totalOn7.OOOo.o.)
							End If
						Next
					Finally
						Dim enumerator14 As IEnumerator(Of TotalOn)
						If enumerator14 IsNot Nothing Then
							enumerator14.Dispose()
						End If
					End Try
					fxDataSource.Columns.Remove(text3)
					dataView2.Dispose()
				End If
				dataView.Dispose()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				OO_00oOO.SystemReady = True
				Foxtable.RibbonMenu.StatusBar.Reset()
			End Try
			Return fxDataSource
		End Function

		' Token: 0x06001F91 RID: 8081 RVA: 0x000CD900 File Offset: 0x000CBB00
		Protected Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataTable)
			Me.OO0__0_.o00.(A_0, A_1)
		End Sub

		' Token: 0x06001F92 RID: 8082 RVA: 0x000CD90C File Offset: 0x000CBB0C
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataTable)
			Dim num As Integer
			Dim num31 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim obj As Object = Nothing
				IL_0B:
				num2 = 3
				Me.o.O0__OO..Clear()
				IL_18:
				num2 = 4
				Me.ooO.oO0O00O0..Clear()
				IL_25:
				num2 = 5
				Me.o0.o_O0O..Clear()
				IL_32:
				num2 = 6
				Dim enumerator As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_4F:
					num2 = 7
					If A_0.Columns.Contains(groupOn.NewName) Then
						IL_68:
						num2 = 8
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_7F:
							num2 = 9
							A_0.Columns(groupOn.NewName).Caption = groupOn.NewCaption
						Else
							IL_A5:
							num2 = 11
							If Operators.CompareString(groupOn.NewName, groupOn.Name, True) = 0 AndAlso Me.SourceDataTable IsNot Nothing Then
								IL_C6:
								num2 = 12
								If Operators.CompareString(Me.SourceDataTable.DataCols(groupOn.Name).Caption, "", True) > 0 Then
									IL_F3:
									num2 = 13
									A_0.Columns(groupOn.NewName).Caption = Me.SourceDataTable.DataCols(groupOn.Name).Caption
								End If
							End If
						End If
					End If
					IL_129:
					num2 = 14
				End While
				IL_138:
				num2 = 15
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_146:
				num2 = 16
				Dim enumerator2 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator2.MoveNext()
					Dim totalOn As TotalOn = enumerator2.Current
					IL_164:
					num2 = 17
					If A_0.Columns.Contains(totalOn.NewName) Then
						IL_17E:
						num2 = 18
						If Operators.CompareString(totalOn.NewCaption, "", True) > 0 Then
							IL_196:
							num2 = 19
							A_0.Columns(totalOn.NewName).Caption = totalOn.NewCaption
						Else
							IL_1BC:
							num2 = 21
							If Operators.CompareString(totalOn.NewName, totalOn.Name, True) = 0 AndAlso Me.SourceDataTable IsNot Nothing Then
								IL_1DD:
								num2 = 22
								If Operators.CompareString(Me.SourceDataTable.DataCols(totalOn.Name).Caption, "", True) > 0 Then
									IL_20A:
									num2 = 23
									A_0.Columns(totalOn.NewName).Caption = Me.SourceDataTable.DataCols(totalOn.Name).Caption
								End If
							End If
						End If
						IL_240:
						num2 = 24
						If totalOn.upto AndAlso (totalOn.Aggregate = 2 OrElse totalOn.Aggregate = 7 OrElse totalOn.Aggregate = 8) Then
							IL_270:
							num2 = 25
							Dim newName As String = totalOn.NewName
							IL_27C:
							num2 = 26
							Dim list As List(Of String) = New List(Of String)()
							IL_286:
							num2 = 27
							If Me.Groups.Count > 1 Then
								IL_297:
								num2 = 28
								Dim num3 As Integer = Me.Groups.Count - 2
								For i As Integer = 0 To num3
									IL_2AE:
									num2 = 29
									list.Add(Me.Groups(i).NewName)
									IL_2CA:
									num2 = 30
								Next
							End If
							IL_2D9:
							num2 = 31
							Dim num4 As Integer = A_0.Rows.Count - 1
							For j As Integer = 1 To num4
								IL_2F3:
								num2 = 32
								Dim dataRow As DataRow = A_0.Rows(j - 1)
								IL_307:
								num2 = 33
								Dim dataRow2 As DataRow = A_0.Rows(j)
								IL_319:
								num2 = 34
								Dim num5 As Decimal
								If dataRow2.IsNull(newName) Then
									IL_327:
									num2 = 35
									num5 = 0D
								Else
									IL_334:
									num2 = 37
									num5 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow2(newName)))
								End If
								IL_34C:
								num2 = 38
								Dim num6 As Decimal
								If Not dataRow.IsNull(newName) Then
									IL_35A:
									num2 = 39
									num6 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow(newName)))
								End If
								IL_372:
								num2 = 40
								If dataRow.IsNull(newName) Or (list.Count > 0 AndAlso Oo00.o00O0O_.O.(list, dataRow, dataRow2)) Then
									IL_399:
									num2 = 41
									If totalOn.Aggregate = 2 Then
										IL_3A6:
										num2 = 42
										num6 = 0D
									Else
										IL_3B3:
										num2 = 44
										num6 = num5
									End If
								End If
								IL_3BA:
								num2 = 45
								Select Case totalOn.Aggregate
									Case 2, 4
										IL_3ED:
										num2 = 47
										dataRow2(newName) = Decimal.Add(num6, num5)
									Case 7
										IL_425:
										num2 = 51
										dataRow2(newName) = Math.Max(num6, num5)
									Case 8
										IL_409:
										num2 = 49
										dataRow2(newName) = Math.Min(num6, num5)
								End Select
								IL_43F:
								num2 = 53
							Next
						End If
					End If
					IL_451:
					num2 = 54
				End While
				IL_460:
				num2 = 55
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_46E:
				num2 = 56
				If Not(Me.Groups.Count = 1 And Me.GroupProportion) Then
					GoTo IL_49C
				End If
				IL_488:
				num2 = 57
				Me.GroupProportion = False
				IL_492:
				num2 = 58
				Me.GrandProportion = True
				IL_49C:
				num2 = 59
				If Not Me.GrandProportion Then
					GoTo IL_7BC
				End If
				IL_4AA:
				num2 = 60
				Dim enumerator3 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim totalOn2 As TotalOn = enumerator3.Current
					IL_4C8:
					num2 = 61
					Dim newName2 As String = totalOn2.NewName
					IL_4D4:
					num2 = 62
					Dim text As String = newName2 + "gdr"
					IL_4E5:
					num2 = 63
					Dim text2 As String = A_0.Columns(newName2).Caption
					IL_4FC:
					num2 = 64
					If Operators.CompareString(text2, "", True) = 0 Then
						IL_50E:
						num2 = 65
						If Me.Totals.Count = 1 Then
							IL_51F:
							num2 = 66
							text2 = "占比"
						Else
							IL_52B:
							num2 = 68
							text2 = newName2 + "占比"
						End If
					Else
						IL_53E:
						num2 = 70
						If text2.IndexOf("_") > 0 Then
							IL_550:
							num2 = 71
							text2 = text2.Substring(0, text2.LastIndexOf("_") + 1) + "占比"
						Else
							IL_577:
							num2 = 73
							If Me.Totals.Count = 1 Then
								IL_588:
								num2 = 74
								text2 = "占比"
							Else
								IL_594:
								num2 = 76
								text2 += "占比"
							End If
						End If
					End If
					IL_5A5:
					num2 = 77
					If Me.GroupProportion Then
						IL_5B0:
						num2 = 78
						text2 += "_总"
					End If
					IL_5C1:
					num2 = 79
					Me.o.O0__OO..Add(text)
					IL_5D1:
					num2 = 80
					A_0.Columns.Add(text, GetType(Double))
					IL_5EC:
					num2 = 81
					A_0.Columns(text).SetOrdinal(A_0.Columns(newName2).Ordinal + 1)
					IL_615:
					num2 = 82
					A_0.Columns(text).Caption = text2
					IL_62C:
					num2 = 83
					A_0.Columns(text).ExtendedProperties.Add("displayformat", "#0.00%")
					IL_650:
					num2 = 84
					If totalOn2.upto Then
						IL_65C:
						num2 = 85
						Dim num7 As Integer = A_0.Rows.Count - 1
						For k As Integer = 0 To num7 Step -1
							IL_673:
							num2 = 86
							If Not A_0.Rows(k).IsNull(newName2) Then
								IL_68C:
								num2 = 87
								obj = RuntimeHelpers.GetObjectValue(A_0.Rows(k)(newName2))
								Exit For
							End If
							IL_6AB:
							num2 = 89
						Next
					Else
						IL_6BC:
						num2 = 91
						obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + newName2 + "])", ""))
					End If
					IL_6E1:
					num2 = 92
					Dim num8 As Double
					If obj IsNot DBNull.Value Then
						IL_6EC:
						num2 = 93
						num8 = Conversions.ToDouble(obj)
					End If
					IL_6F7:
					num2 = 94
					If num8 <> 0.0 Then
						IL_70A:
						num2 = 95
						Dim enumerator4 As IEnumerator = A_0.Rows.GetEnumerator()
						While enumerator4.MoveNext()
							Dim obj2 As Object = enumerator4.Current
							Dim dataRow3 As DataRow = CType(obj2, DataRow)
							IL_72A:
							num2 = 96
							If Not dataRow3.IsNull(newName2) Then
								IL_738:
								num2 = 97
								dataRow3(text) = Math.Round(Conversions.ToDouble(dataRow3(newName2)) / num8, Me.Decimals + 2)
							Else
								IL_769:
								num2 = 99
								dataRow3(text) = 0
							End If
							IL_77B:
							num2 = 100
						End While
						IL_787:
						num2 = 101
						If TypeOf enumerator4 Is IDisposable Then
							TryCast(enumerator4, IDisposable).Dispose()
						End If
					End If
					IL_79F:
					num2 = 102
				End While
				IL_7AE:
				num2 = 103
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_7BC:
				num2 = 104
				If Not Me.GroupProportion OrElse Me.Groups.Count <= 1 Then
					GoTo IL_EE4
				End If
				IL_7DB:
				num2 = 105
				For l As Integer = Me.Groups.Count - 2 To 0 Step -1
					IL_7F2:
					num2 = 106
					Dim enumerator5 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
					While enumerator5.MoveNext()
						Dim totalOn3 As TotalOn = enumerator5.Current
						IL_810:
						num2 = 107
						Dim newName3 As String = totalOn3.NewName
						IL_81C:
						num2 = 108
						Dim text3 As String = newName3 + Me.Groups(l).NewName + "gpr"
						IL_83F:
						num2 = 109
						Dim text4 As String = A_0.Columns(newName3).Caption
						IL_856:
						num2 = 110
						If Operators.CompareString(text4, "", True) = 0 Then
							IL_868:
							num2 = 111
							If Me.Totals.Count = 1 Then
								IL_879:
								num2 = 112
								text4 = "占比"
							Else
								IL_885:
								num2 = 114
								text4 = newName3 + "占比"
							End If
						Else
							IL_898:
							num2 = 116
							If text4.IndexOf("_") > 0 Then
								IL_8AA:
								num2 = 117
								text4 = text4.Substring(0, text4.LastIndexOf("_") + 1) + "占比"
							Else
								IL_8D1:
								num2 = 119
								If Me.Totals.Count = 1 Then
									IL_8E2:
									num2 = 120
									text4 = "占比"
								Else
									IL_8EE:
									num2 = 122
									text4 += "占比"
								End If
							End If
						End If
						IL_8FF:
						num2 = 123
						If Me.GrandProportion AndAlso Me.Groups.Count = 2 Then
							IL_918:
							num2 = 124
							text4 += "_分"
						End If
						IL_929:
						num2 = 125
						If Me.Groups.Count > 2 Then
							IL_93A:
							num2 = 126
							text4 = text4 + "_" + Me.Groups(l).NewName
						End If
						IL_95D:
						num2 = 127
						Me.o.O0__OO..Add(text3)
						IL_96D:
						num2 = 128
						A_0.Columns.Add(text3, GetType(Double))
						IL_98B:
						num2 = 129
						A_0.Columns(text3).SetOrdinal(A_0.Columns(newName3).Ordinal + 1)
						IL_9B7:
						num2 = 130
						A_0.Columns(text3).Caption = text4
						IL_9D1:
						num2 = 131
						A_0.Columns(text3).ExtendedProperties.Add("displayformat", "#0.00%")
						IL_9F8:
						num2 = 132
						Dim num9 As Integer = A_0.Rows.Count - 1
						For m As Integer = 0 To num9
							IL_A15:
							num2 = 133
							Dim flag As Boolean = True
							IL_A1E:
							num2 = 134
							If m = 0 Then
								IL_A28:
								num2 = 135
								flag = False
							Else
								IL_A36:
								num2 = 137
								Dim num10 As Integer = l
								For n As Integer = 0 To num10
									IL_A45:
									num2 = 138
									If Operators.CompareString(A_0.Rows(m)(Me.Groups(n).NewName).ToString(), A_0.Rows(m - 1)(Me.Groups(n).NewName).ToString(), True) <> 0 Then
										IL_AA7:
										num2 = 139
										flag = False
										Exit For
									End If
									IL_AB2:
									num2 = 141
								Next
							End If
							IL_AC4:
							num2 = 142
							Dim num18 As Double
							If Not flag Then
								IL_AD1:
								num2 = 143
								If totalOn3.upto Then
									IL_AE3:
									num2 = 144
									Dim flag2 As Boolean = False
									IL_AEC:
									num2 = 145
									Dim num11 As Integer = m
									Dim num12 As Integer = A_0.Rows.Count - 1
									For num13 As Integer = num11 To num12
										IL_B0A:
										num2 = 146
										Dim num14 As Integer = Me.Groups.Count - 2
										For num15 As Integer = 0 To num14
											IL_B24:
											num2 = 147
											If Operators.CompareString(A_0.Rows(num13)(Me.Groups(num15).NewName).ToString(), A_0.Rows(m)(Me.Groups(num15).NewName).ToString(), True) <> 0 Then
												IL_B84:
												num2 = 148
												flag2 = True
												Exit For
											End If
											IL_B8F:
											num2 = 150
										Next
										IL_BA1:
										num2 = 151
										If flag2 Then
											Exit For
										End If
										IL_BAE:
										num2 = 154
										obj = RuntimeHelpers.GetObjectValue(A_0.Rows(num13)(newName3))
										IL_BCE:
										num2 = 155
									Next
								Else
									IL_BE8:
									num2 = 157
									Dim text5 As String = ""
									IL_BF5:
									num2 = 158
									Dim num16 As Integer = l
									For num17 As Integer = 0 To num16
										IL_C07:
										num2 = 159
										If Operators.CompareString(text5, "", True) > 0 Then
											IL_C1D:
											num2 = 160
											text5 += " And "
										End If
										IL_C31:
										num2 = 161
										text5 = text5 + "[" + Me.Groups(num17).NewName + "] = "
										IL_C5C:
										num2 = 162
										If A_0.Columns(Me.Groups(num17).NewName).DataType Is GetType(String) Then
											IL_C90:
											num2 = 163
											text5 = text5 + "'" + A_0.Rows(m)(Me.Groups(num17).NewName).ToString() + "'"
										Else
											IL_CD7:
											num2 = 165
											If A_0.Columns(Me.Groups(num17).NewName).DataType Is GetType(DateTime) Then
												IL_D0B:
												num2 = 166
												text5 = text5 + "#" + A_0.Rows(m)(Me.Groups(num17).NewName).ToString() + "#"
											Else
												IL_D4F:
												num2 = 168
												text5 += A_0.Rows(m)(Me.Groups(num17).NewName).ToString()
											End If
										End If
										IL_D87:
										num2 = 169
									Next
									IL_D9C:
									num2 = 170
									obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + newName3 + "])", text5))
								End If
								IL_DC1:
								num2 = 171
								If obj IsNot DBNull.Value Then
									IL_DCF:
									num2 = 172
									num18 = Conversions.ToDouble(obj)
								End If
							End If
							IL_DDD:
							num2 = 173
							If num18 <> 0.0 Then
								IL_DF3:
								num2 = 174
								If Not A_0.Rows(m).IsNull(newName3) Then
									IL_E12:
									num2 = 175
									If Not A_0.Rows(m).IsNull(newName3) Then
										IL_E2E:
										num2 = 176
										A_0.Rows(m)(text3) = Math.Round(Conversions.ToDouble(A_0.Rows(m)(newName3)) / num18, Me.Decimals + 2)
									Else
										IL_E78:
										num2 = 178
										A_0.Rows(m)(text3) = 0
									End If
								End If
							End If
							IL_E98:
							num2 = 179
						Next
						IL_EAD:
						num2 = 180
					End While
					IL_EBF:
					num2 = 181
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
					IL_ED0:
					num2 = 182
				Next
				IL_EE4:
				num2 = 183
				If Not Me.CircleGrowth Then
					GoTo IL_16B6
				End If
				IL_EF5:
				num2 = 184
				Dim list2 As List(Of String) = New List(Of String)()
				IL_F02:
				num2 = 185
				Dim text6 As String = ""
				IL_F0F:
				num2 = 186
				Dim text7 As String = ""
				IL_F1C:
				num2 = 187
				Dim enumerator6 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator6.MoveNext()
					Dim groupOn2 As GroupOn = enumerator6.Current
					IL_F3D:
					num2 = 188
					If A_1.Columns(groupOn2.Name).DataType Is GetType(DateTime) Then
						IL_F66:
						num2 = 189
						If Operators.CompareString(text6, "", True) > 0 Then
							IL_F7C:
							num2 = 190
							text6 += ","
						End If
						IL_F90:
						num2 = 191
						text6 += groupOn2.NewName
					Else
						IL_FA8:
						num2 = 193
						If Operators.CompareString(text7, "", True) > 0 Then
							IL_FBE:
							num2 = 194
							text7 += ","
						End If
						IL_FD2:
						num2 = 195
						text7 += groupOn2.NewName
						IL_FE8:
						num2 = 196
						list2.Add(groupOn2.NewName)
					End If
					IL_FFC:
					num2 = 197
				End While
				IL_100E:
				num2 = 198
				If enumerator6 IsNot Nothing Then
					enumerator6.Dispose()
				End If
				IL_101F:
				num2 = 199
				If Operators.CompareString(text6, "", True) <> 0 Then
					GoTo IL_119A
				End If
				IL_1037:
				num2 = 200
				list2.Clear()
				IL_1044:
				num2 = 201
				text7 = ""
				IL_1051:
				num2 = 202
				Dim enumerator7 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator7.MoveNext()
					Dim groupOn3 As GroupOn = enumerator7.Current
					IL_1072:
					num2 = 203
					If A_0.Columns(groupOn3.NewName).DataType Is GetType(Integer) OrElse A_0.Columns(groupOn3.NewName).DataType Is GetType(Long) OrElse A_0.Columns(groupOn3.NewName).DataType Is GetType(Short) Then
						IL_10E1:
						num2 = 204
						If Operators.CompareString(text6, "", True) > 0 Then
							IL_10F7:
							num2 = 205
							text6 += ","
						End If
						IL_110B:
						num2 = 206
						text6 += groupOn3.NewName
					Else
						IL_1123:
						num2 = 208
						If Operators.CompareString(text7, "", True) > 0 Then
							IL_1139:
							num2 = 209
							text7 += ","
						End If
						IL_114D:
						num2 = 210
						text7 += groupOn3.NewName
						IL_1163:
						num2 = 211
						list2.Add(groupOn3.NewName)
					End If
					IL_1177:
					num2 = 212
				End While
				IL_1189:
				num2 = 213
				If enumerator7 IsNot Nothing Then
					enumerator7.Dispose()
				End If
				IL_119A:
				num2 = 214
				If Operators.CompareString(text6, "", True) <= 0 Then
					GoTo IL_16B6
				End If
				IL_11B3:
				num2 = 215
				Dim enumerator8 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator8.MoveNext()
					Dim totalOn4 As TotalOn = enumerator8.Current
					IL_11D4:
					num2 = 216
					Dim newName4 As String = totalOn4.NewName
					IL_11E3:
					num2 = 217
					Dim text8 As String = newName4 + "cle"
					IL_11F7:
					num2 = 218
					Dim text9 As String = A_0.Columns(newName4).Caption
					IL_1211:
					num2 = 219
					If Operators.CompareString(text9, "", True) = 0 Then
						IL_1226:
						num2 = 220
						If Me.Totals.Count = 1 Then
							IL_123A:
							num2 = 221
							text9 = "环比增长"
						Else
							IL_124C:
							num2 = 223
							text9 = newName4 + "环比"
						End If
					Else
						IL_1262:
						num2 = 225
						If text9.IndexOf("_") > 0 Then
							IL_1277:
							num2 = 226
							text9 = text9.Substring(0, text9.LastIndexOf("_") + 1) + "环比"
						Else
							IL_12A1:
							num2 = 228
							If Me.Totals.Count = 1 Then
								IL_12B5:
								num2 = 229
								text9 = "环比增长"
							Else
								IL_12C4:
								num2 = 231
								text9 += "环比"
							End If
						End If
					End If
					IL_12D8:
					num2 = 232
					Me.o.O0__OO..Add(text8)
					IL_12EB:
					num2 = 233
					Me.ooO.oO0O00O0..Add(newName4)
					IL_12FE:
					num2 = 234
					Me.o0.o_O0O..Add(text8)
					IL_1311:
					num2 = 235
					A_0.Columns.Add(text8, GetType(Double))
					IL_132F:
					num2 = 236
					A_0.Columns(text8).SetOrdinal(A_0.Columns(newName4).Ordinal + 1)
					IL_135B:
					num2 = 237
					A_0.Columns(text8).Caption = text9
					IL_1375:
					num2 = 238
					A_0.Columns(text8).ExtendedProperties.Add("displayformat", "#0.00%")
					IL_139C:
					num2 = 239
					If list2.Count = 0 Then
						IL_13AE:
						num2 = 240
						Dim num19 As Integer = A_0.Rows.Count - 1
						For num20 As Integer = 1 To num19
							IL_13CB:
							num2 = 241
							Dim num21 As Double
							If Not A_0.Rows(num20 - 1).IsNull(newName4) Then
								IL_13E9:
								num2 = 242
								num21 = Conversions.ToDouble(A_0.Rows(num20 - 1)(newName4))
							Else
								IL_140E:
								num2 = 244
								num21 = 0.0
							End If
							IL_141F:
							num2 = 245
							Dim num22 As Double
							If Not A_0.Rows(num20).IsNull(newName4) Then
								IL_143B:
								num2 = 246
								num22 = Conversions.ToDouble(A_0.Rows(num20)(newName4))
							Else
								IL_145E:
								num2 = 248
								num22 = 0.0
							End If
							IL_146F:
							num2 = 249
							If num21 <> 0.0 Then
								IL_1482:
								num2 = 250
								A_0.Rows(num20)(text8) = Math.Round((num22 - num21) / num21, Me.Decimals)
							End If
							IL_14B4:
							num2 = 251
						Next
					Else
						IL_14CE:
						num2 = 253
						Dim dataView As DataView = New DataView(A_0, "", text7 + "," + text6, DataViewRowState.CurrentRows)
						IL_14F1:
						num2 = 254
						Dim num23 As Integer = dataView.Count - 1
						For num24 As Integer = 1 To num23
							IL_150A:
							num2 = 255
							Dim flag3 As Boolean = True
							IL_1513:
							num2 = 256
							Dim enumerator9 As List(Of String).Enumerator = list2.GetEnumerator()
							While enumerator9.MoveNext()
								Dim [property] As String = enumerator9.Current
								IL_152D:
								num2 = 257
								If Operators.CompareString(dataView(num24)([property]).ToString(), dataView(num24 - 1)([property]).ToString(), True) <> 0 Then
									IL_1567:
									num2 = 258
									flag3 = False
								End If
								IL_1570:
								num2 = 259
							End While
							IL_157F:
							num2 = 260
							CType(enumerator9, IDisposable).Dispose()
							IL_1592:
							num2 = 261
							If flag3 Then
								IL_159F:
								num2 = 262
								Dim num25 As Double
								If Not dataView(num24 - 1).Row.IsNull(newName4) Then
									IL_15BE:
									num2 = 263
									num25 = Conversions.ToDouble(dataView(num24 - 1)(newName4))
								Else
									IL_15DF:
									num2 = 265
									num25 = 0.0
								End If
								IL_15F0:
								num2 = 266
								Dim num26 As Double
								If Not dataView(num24).Row.IsNull(newName4) Then
									IL_160D:
									num2 = 267
									num26 = Conversions.ToDouble(dataView(num24)(newName4))
								Else
									IL_162C:
									num2 = 269
									num26 = 0.0
								End If
								IL_163D:
								num2 = 270
								If num25 <> 0.0 Then
									IL_1650:
									num2 = 271
									dataView(num24)(text8) = Math.Round((num26 - num25) / num25, Me.Decimals)
								End If
							End If
							IL_167E:
							num2 = 272
						Next
					End If
					IL_1693:
					num2 = 273
				End While
				IL_16A5:
				num2 = 274
				If enumerator8 IsNot Nothing Then
					enumerator8.Dispose()
				End If
				IL_16B6:
				num2 = 275
				If Not Me.SamePeriodGrowth Then
					GoTo IL_1E78
				End If
				IL_16C7:
				num2 = 276
				Dim text10 As String = ""
				IL_16D4:
				num2 = 277
				Dim left As String = ""
				IL_16E1:
				num2 = 278
				Dim enumerator10 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator10.MoveNext()
					Dim groupOn4 As GroupOn = enumerator10.Current
					IL_1702:
					num2 = 279
					If A_1.Columns(groupOn4.Name).DataType Is GetType(DateTime) Then
						IL_172B:
						num2 = 280
						If Operators.CompareString(text10, "", True) = 0 Then
							IL_1740:
							num2 = 281
							text10 = groupOn4.NewName
						Else
							IL_1751:
							num2 = 283
							If Operators.CompareString(left, "", True) = 0 Then
								IL_1766:
								num2 = 284
								left = groupOn4.NewName
								Exit While
							End If
						End If
					End If
					IL_1777:
					num2 = 286
				End While
				IL_1789:
				num2 = 287
				If enumerator10 IsNot Nothing Then
					enumerator10.Dispose()
				End If
				IL_179A:
				num2 = 288
				If Operators.CompareString(text10, "", True) <> 0 OrElse Operators.CompareString(left, "", True) <> 0 Then
					GoTo IL_18C3
				End If
				IL_17C4:
				num2 = 289
				Dim enumerator11 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator11.MoveNext()
					Dim groupOn5 As GroupOn = enumerator11.Current
					IL_17E5:
					num2 = 290
					If A_0.Columns(groupOn5.NewName).DataType Is GetType(Integer) OrElse A_0.Columns(groupOn5.NewName).DataType Is GetType(Long) OrElse A_0.Columns(groupOn5.NewName).DataType Is GetType(Short) Then
						IL_1854:
						num2 = 291
						If Operators.CompareString(text10, "", True) = 0 Then
							IL_1869:
							num2 = 292
							text10 = groupOn5.NewName
						Else
							IL_187A:
							num2 = 294
							If Operators.CompareString(left, "", True) = 0 Then
								IL_188F:
								num2 = 295
								left = groupOn5.NewName
								Exit While
							End If
						End If
					End If
					IL_18A0:
					num2 = 297
				End While
				IL_18B2:
				num2 = 298
				If enumerator11 IsNot Nothing Then
					enumerator11.Dispose()
				End If
				IL_18C3:
				num2 = 299
				If Operators.CompareString(left, "", True) <= 0 Then
					GoTo IL_1E78
				End If
				IL_18DC:
				num2 = 300
				Dim list3 As List(Of String) = New List(Of String)()
				IL_18E9:
				num2 = 301
				Dim text11 As String = ""
				IL_18F6:
				num2 = 302
				Dim enumerator12 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator12.MoveNext()
					Dim groupOn6 As GroupOn = enumerator12.Current
					IL_1917:
					num2 = 303
					If Operators.CompareString(text10, groupOn6.NewName, True) <> 0 Then
						IL_1931:
						num2 = 305
						list3.Add(groupOn6.NewName)
						IL_1945:
						num2 = 306
						If Operators.CompareString(text11, "", True) > 0 Then
							IL_195B:
							num2 = 307
							text11 += " And "
						End If
						IL_196F:
						num2 = 308
						text11 = text11 + "[" + groupOn6.NewName + "] = "
						IL_198F:
						num2 = 309
						If A_0.Columns(groupOn6.NewName).DataType Is GetType(String) Then
							IL_19B8:
							num2 = 310
							text11 = text11 + "'{" + groupOn6.NewName + "}'"
						Else
							IL_19DA:
							num2 = 312
							If A_0.Columns(groupOn6.NewName).DataType Is GetType(DateTime) Then
								IL_1A03:
								num2 = 313
								text11 = text11 + "#{" + groupOn6.NewName + "}#"
							Else
								IL_1A25:
								num2 = 315
								text11 = text11 + "{" + groupOn6.NewName + "}"
							End If
						End If
					End If
					IL_1A45:
					num2 = 316
				End While
				IL_1A57:
				num2 = 317
				If enumerator12 IsNot Nothing Then
					enumerator12.Dispose()
				End If
				IL_1A68:
				num2 = 318
				Dim enumerator13 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator13.MoveNext()
					Dim totalOn5 As TotalOn = enumerator13.Current
					IL_1A89:
					num2 = 319
					Dim newName5 As String = totalOn5.NewName
					IL_1A98:
					num2 = 320
					Dim text12 As String = newName5 + "stp"
					IL_1AAC:
					num2 = 321
					Dim text13 As String = A_0.Columns(newName5).Caption
					IL_1AC6:
					num2 = 322
					If Operators.CompareString(text13, "", True) = 0 Then
						IL_1ADB:
						num2 = 323
						If Me.Totals.Count = 1 Then
							IL_1AEF:
							num2 = 324
							text13 = "同比增长"
						Else
							IL_1B01:
							num2 = 326
							text13 = newName5 + "同比"
						End If
					Else
						IL_1B17:
						num2 = 328
						If text13.IndexOf("_") > 0 Then
							IL_1B2C:
							num2 = 329
							text13 = text13.Substring(0, text13.LastIndexOf("_") + 1) + "同比"
						Else
							IL_1B56:
							num2 = 331
							If Me.Totals.Count = 1 Then
								IL_1B6A:
								num2 = 332
								text13 = "同比增长"
							Else
								IL_1B79:
								num2 = 334
								text13 += "同比"
							End If
						End If
					End If
					IL_1B8D:
					num2 = 335
					Me.o.O0__OO..Add(text12)
					IL_1BA0:
					num2 = 336
					Me.ooO.oO0O00O0..Add(newName5)
					IL_1BB3:
					num2 = 337
					Me.o0.o_O0O..Add(text12)
					IL_1BC6:
					num2 = 338
					A_0.Columns.Add(text12, GetType(Double))
					IL_1BE4:
					num2 = 339
					A_0.Columns(text12).SetOrdinal(A_0.Columns(newName5).Ordinal + 1)
					IL_1C10:
					num2 = 340
					A_0.Columns(text12).Caption = text13
					IL_1C2A:
					num2 = 341
					A_0.Columns(text12).ExtendedProperties.Add("displayformat", "#0.00%")
					IL_1C51:
					num2 = 342
					Dim enumerator14 As IEnumerator = A_0.Rows.GetEnumerator()
					While enumerator14.MoveNext()
						Dim obj3 As Object = enumerator14.Current
						Dim dataRow4 As DataRow = CType(obj3, DataRow)
						IL_1C77:
						num2 = 343
						Dim text14 As String = text11
						IL_1C81:
						num2 = 344
						Dim enumerator15 As List(Of String).Enumerator = list3.GetEnumerator()
						While enumerator15.MoveNext()
							Dim text15 As String = enumerator15.Current
							IL_1C9B:
							num2 = 345
							text14 = text14.Replace("{" + text15 + "}", dataRow4(text15).ToString())
							IL_1CC9:
							num2 = 346
						End While
						IL_1CD8:
						num2 = 347
						CType(enumerator15, IDisposable).Dispose()
						IL_1CEB:
						num2 = 348
						If Not dataRow4.IsNull(text10) Then
							IL_1CFF:
							num2 = 349
							Dim num27 As Integer = Conversions.ToInteger(dataRow4(text10))
							IL_1D15:
							num2 = 352
							text14 = String.Concat(New String() { text14, " And [", text10, "] = ", Conversions.ToString(num27 - 1) })
							IL_1D4E:
							num2 = 353
							Dim array As DataRow() = A_0.[Select](text14)
							IL_1D5E:
							num2 = 354
							If array.Length >= 1 Then
								IL_1D6E:
								num2 = 355
								Dim dataRow5 As DataRow = array(0)
								IL_1D7A:
								num2 = 356
								Dim num28 As Double
								If Not dataRow5.IsNull(newName5) Then
									IL_1D8B:
									num2 = 357
									num28 = Conversions.ToDouble(dataRow5(newName5))
								Else
									IL_1DA3:
									num2 = 359
									num28 = 0.0
								End If
								IL_1DB4:
								num2 = 360
								Dim num29 As Double
								If Not dataRow4.IsNull(newName5) Then
									IL_1DC5:
									num2 = 361
									num29 = Conversions.ToDouble(dataRow4(newName5))
								Else
									IL_1DDD:
									num2 = 363
									num29 = 0.0
								End If
								IL_1DEE:
								num2 = 364
								If num28 > 0.0 Then
									IL_1E01:
									num2 = 365
									dataRow4(text12) = Math.Round((num29 - num28) / num28, Me.Decimals)
								End If
							End If
						End If
						IL_1E28:
						num2 = 366
					End While
					IL_1E3A:
					num2 = 367
					If TypeOf enumerator14 Is IDisposable Then
						TryCast(enumerator14, IDisposable).Dispose()
					End If
					IL_1E55:
					num2 = 368
				End While
				IL_1E67:
				num2 = 369
				If enumerator13 IsNot Nothing Then
					enumerator13.Dispose()
				End If
				IL_1E78:
				num2 = 370
				If Me.Subtotal Then
					GoTo IL_20B9
				End If
				IL_1E89:
				num2 = 372
				If Not Me.VerticalTotal Then
					GoTo IL_20B9
				End If
				IL_1E9A:
				num2 = 373
				Dim dataRow6 As DataRow = A_0.NewRow()
				IL_1EA8:
				num2 = 374
				Dim enumerator16 As IEnumerator(Of TotalOn) = Me.Totals.GetEnumerator()
				While enumerator16.MoveNext()
					Dim totalOn6 As TotalOn = enumerator16.Current
					IL_1EC9:
					num2 = 375
					Dim newName6 As String = totalOn6.NewName
					IL_1ED8:
					num2 = 376
					Select Case totalOn6.Aggregate
						Case 2, 4
							IL_1F11:
							num2 = 378
							obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Sum([" + totalOn6.NewName + "])", ""))
						Case 6
							IL_1F43:
							num2 = 380
							obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Avg([" + totalOn6.NewName + "])", ""))
						Case 7
							IL_1F72:
							num2 = 382
							obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Max([" + totalOn6.NewName + "])", ""))
						Case 8
							IL_1FA1:
							num2 = 384
							obj = RuntimeHelpers.GetObjectValue(A_0.Compute("Min([" + totalOn6.NewName + "])", ""))
					End Select
					IL_1FCE:
					num2 = 386
					If obj IsNot DBNull.Value Then
						IL_1FDC:
						num2 = 387
						dataRow6(newName6) = Math.Round(Conversions.ToDecimal(obj), Me.Decimals)
					End If
					IL_2001:
					num2 = 388
				End While
				IL_2013:
				num2 = 389
				If enumerator16 IsNot Nothing Then
					enumerator16.Dispose()
				End If
				IL_2024:
				num2 = 390
				Dim enumerator17 As IEnumerator(Of GroupOn) = Me.Groups.GetEnumerator()
				While enumerator17.MoveNext()
					Dim groupOn7 As GroupOn = enumerator17.Current
					IL_2042:
					num2 = 391
					If A_0.Columns(groupOn7.NewName).DataType Is GetType(String) Then
						IL_206B:
						num2 = 392
						dataRow6(groupOn7.NewName) = "合计"
						Exit While
					End If
					IL_2086:
					num2 = 394
				End While
				IL_2095:
				num2 = 395
				If enumerator17 IsNot Nothing Then
					enumerator17.Dispose()
				End If
				IL_20A6:
				num2 = 396
				A_0.Rows.Add(dataRow6)
				IL_20B9:
				num2 = 397
				A_0.AcceptChanges()
				IL_20C5:
				GoTo IL_274F
				IL_20CA:
				Dim num30 As Integer = num31 + 1
				num31 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num30)
				IL_2710:
				GoTo IL_2744
				IL_2712:
				num31 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2722:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num31 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_2712
			End Try
			IL_2744:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_274F:
			If num31 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001F93 RID: 8083 RVA: 0x000D008C File Offset: 0x000CE28C
		Protected Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As Boolean, A_2 As String) As DataTable
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
			Try
				For Each dataCol As DataCol In dataTable.DataCols
					If Operators.CompareString(dataCol.BaseColumn.Caption, "", True) > 0 Then
						dataCol.Caption = dataCol.BaseColumn.Caption
						dataCol.BaseColumn.Caption = ""
					End If
					If dataCol.BaseColumn.ExtendedProperties.ContainsKey("IsTimeSpan") Then
						dataCol.ExtendColumnType = 8
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim result As DataTable
			If A_1 Then
				result = dataTable
			Else
				New O_0(O_O0OO.o__.O.(), A_0)
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
				Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, Me.TableVisible, False)
				Try
					For Each text As String In Me.o.O0__OO.
						OO_00oOO.Tables(Me.TableName).foxGrid.Cols(text).Format = "#0.00%"
						OO_00oOO.DataTables(Me.TableName).DataCols(text).PercentStyle = True
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				If Operators.CompareString(A_2, Me.TableName, True) = 0 Then
					OO_00oOO.MainTable = OO_00oOO.Tables(Me.TableName)
				End If
				result = dataTable
			End If
			Return result
		End Function

		' Token: 0x06001F94 RID: 8084 RVA: 0x000D02D4 File Offset: 0x000CE4D4
		Private Sub <<EMPTY_NAME>>(A_0 As DataRow)
			Try
				For Each totalOn As TotalOn In Me.Totals
					If Not A_0.IsNull(totalOn.Name) Then
						Select Case totalOn.Aggregate
							Case 2, 6
								totalOn.Oo_o0O00O.o0O. += 1
								totalOn.Oo_o0O00O.o0O. += Convert.ToDouble(Conversions.ToDecimal(A_0(totalOn.Name)))
							Case 4
								totalOn.Oo_o0O00O.o0O. += 1
							Case 7
								totalOn.Oo_o0O00O.o0O. += 1
								If totalOn.Oo_o0O00O.o0O. = 1 Then
									totalOn.Oo_o0O00O.o0O. = Convert.ToDouble(Conversions.ToDecimal(A_0(totalOn.Name)))
								Else
									totalOn.Oo_o0O00O.o0O. = Math.Max(totalOn.Oo_o0O00O.o0O., Convert.ToDouble(Conversions.ToDecimal(A_0(totalOn.Name))))
								End If
							Case 8
								totalOn.Oo_o0O00O.o0O. += 1
								If totalOn.Oo_o0O00O.o0O. = 1 Then
									totalOn.Oo_o0O00O.o0O. = Convert.ToDouble(Conversions.ToDecimal(A_0(totalOn.Name)))
								Else
									totalOn.Oo_o0O00O.o0O. = Math.Min(totalOn.Oo_o0O00O.o0O., Convert.ToDouble(Conversions.ToDecimal(A_0(totalOn.Name))))
								End If
						End Select
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of TotalOn)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001F95 RID: 8085 RVA: 0x000D0474 File Offset: 0x000CE674
		Private Function <<EMPTY_NAME>>(A_0 As DateTime, A_1 As DateGroupEnum) As Integer
			Dim result As Integer
			Select Case A_1
				Case 1
					result = A_0.Year
				Case 2
					result = DateAndTime.DatePart(DateInterval.Quarter, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
				Case 3
					result = A_0.Month
				Case 4
					result = DateAndTime.DatePart(DateInterval.WeekOfYear, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
				Case 5
					result = A_0.Day
				Case 6
					result = A_0.Hour
				Case 7
					result = A_0.Minute
				Case 8
					result = A_0.Second
				Case 9
					result = DateAndTime.DatePart(DateInterval.DayOfYear, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
				Case 10
					result = DateAndTime.DatePart(DateInterval.Weekday, A_0, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
				Case Else
					result = 0
			End Select
			Return result
		End Function

		' Token: 0x17000727 RID: 1831
		' (get) Token: 0x06001F96 RID: 8086 RVA: 0x000D0524 File Offset: 0x000CE724
		' (set) Token: 0x06001F97 RID: 8087 RVA: 0x000D052C File Offset: 0x000CE72C
		Public Property CommandTimeOut As Integer
			Get
				Return Me.Oo.O0O_0.
			End Get
			Set(value As Integer)
				Me.Oo.O0O_0. = value
			End Set
		End Property

		' Token: 0x04000D0D RID: 3341
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D0E RID: 3342
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D0F RID: 3343
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D10 RID: 3344
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D11 RID: 3345
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D12 RID: 3346
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D13 RID: 3347
		Private <<EMPTY_NAME>> As GroupCollection

		' Token: 0x04000D14 RID: 3348
		Private <<EMPTY_NAME>> As TotalCollection

		' Token: 0x04000D15 RID: 3349
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000D16 RID: 3350
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D17 RID: 3351
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D18 RID: 3352
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D19 RID: 3353
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D1A RID: 3354
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D1B RID: 3355
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D1C RID: 3356
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D1D RID: 3357
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D1E RID: 3358
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D1F RID: 3359
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D20 RID: 3360
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D21 RID: 3361
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000D22 RID: 3362
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000D23 RID: 3363
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000D24 RID: 3364
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000D25 RID: 3365
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000D26 RID: 3366
		Protected <<EMPTY_NAME>> As HttpClient
	End Class
End Namespace
