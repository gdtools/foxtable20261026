Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200027D RID: 637
	<oO0oooo("0678")>
	<ComVisible(True)>
	Public Class CrossTableBuilder
		' Token: 0x06001E7D RID: 7805 RVA: 0x000C2CBC File Offset: 0x000C0EBC
		Friend Sub New()
			Me.o0__oo.o_0o. = True
			Me.OO0o_O00.o. = New GroupCollection()
			Me.O.oOO_0. = New CrossGroupCollection()
			Me.o0__oo.o_0o. = New CrossTotalCollection()
			Me.o_o00_O.0_oo. = 4
			Me.oo.o. = "份额"
			Me.oO.00__O__. = "占比"
			Me.O.0O__oOO0. = -1
			Me.O.oOO_0. = New List(Of String)()
			Me.Oo_0O0o.ooO. = New List(Of String)()
			Me.O_O_ooo.OOOOoo. = New List(Of String)()
			Me.O0OO.00OOO_O. = 30
			Me.o.000Oo_o. = New List(Of String)()
		End Sub

		' Token: 0x06001E7E RID: 7806 RVA: 0x000C2D50 File Offset: 0x000C0F50
		Public Sub New(A_0 As String, A_1 As DataTable)
			Me.o0__oo.o_0o. = True
			Me.OO0o_O00.o. = New GroupCollection()
			Me.O.oOO_0. = New CrossGroupCollection()
			Me.o0__oo.o_0o. = New CrossTotalCollection()
			Me.o_o00_O.0_oo. = 4
			Me.oo.o. = "份额"
			Me.oO.00__O__. = "占比"
			Me.O.0O__oOO0. = -1
			Me.O.oOO_0. = New List(Of String)()
			Me.Oo_0O0o.ooO. = New List(Of String)()
			Me.O_O_ooo.OOOOoo. = New List(Of String)()
			Me.O0OO.00OOO_O. = 30
			Me.o.000Oo_o. = New List(Of String)()
			Me.o0__oo.o_0o. = A_0
			Me.o0__oo.o_0o. = A_1
		End Sub

		' Token: 0x06001E7F RID: 7807 RVA: 0x000C2DF4 File Offset: 0x000C0FF4
		Public Sub New(A_0 As String, A_1 As DataTable, A_2 As String)
			Me.o0__oo.o_0o. = True
			Me.OO0o_O00.o. = New GroupCollection()
			Me.O.oOO_0. = New CrossGroupCollection()
			Me.o0__oo.o_0o. = New CrossTotalCollection()
			Me.o_o00_O.0_oo. = 4
			Me.oo.o. = "份额"
			Me.oO.00__O__. = "占比"
			Me.O.0O__oOO0. = -1
			Me.O.oOO_0. = New List(Of String)()
			Me.Oo_0O0o.ooO. = New List(Of String)()
			Me.O_O_ooo.OOOOoo. = New List(Of String)()
			Me.O0OO.00OOO_O. = 30
			Me.o.000Oo_o. = New List(Of String)()
			Me.o0__oo.o_0o. = A_0
			Me.o0__oo.o_0o. = A_1
			Me.ooO._. = A_2
		End Sub

		' Token: 0x06001E80 RID: 7808 RVA: 0x000C2E9C File Offset: 0x000C109C
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.o0__oo.o_0o. = True
			Me.OO0o_O00.o. = New GroupCollection()
			Me.O.oOO_0. = New CrossGroupCollection()
			Me.o0__oo.o_0o. = New CrossTotalCollection()
			Me.o_o00_O.0_oo. = 4
			Me.oo.o. = "份额"
			Me.oO.00__O__. = "占比"
			Me.O.0O__oOO0. = -1
			Me.O.oOO_0. = New List(Of String)()
			Me.Oo_0O0o.ooO. = New List(Of String)()
			Me.O_O_ooo.OOOOoo. = New List(Of String)()
			Me.O0OO.00OOO_O. = 30
			Me.o.000Oo_o. = New List(Of String)()
			Me.o0__oo.o_0o. = A_0
			Me.o0o__0_.oO_. = A_1
			Me.oOOO._. = A_2
		End Sub

		' Token: 0x06001E81 RID: 7809 RVA: 0x000C2F44 File Offset: 0x000C1144
		Public Sub New(A_0 As String, A_1 As String)
			Me.o0__oo.o_0o. = True
			Me.OO0o_O00.o. = New GroupCollection()
			Me.O.oOO_0. = New CrossGroupCollection()
			Me.o0__oo.o_0o. = New CrossTotalCollection()
			Me.o_o00_O.0_oo. = 4
			Me.oo.o. = "份额"
			Me.oO.00__O__. = "占比"
			Me.O.0O__oOO0. = -1
			Me.O.oOO_0. = New List(Of String)()
			Me.Oo_0O0o.ooO. = New List(Of String)()
			Me.O_O_ooo.OOOOoo. = New List(Of String)()
			Me.O0OO.00OOO_O. = 30
			Me.o.000Oo_o. = New List(Of String)()
			Me.o0__oo.o_0o. = A_0
			Me.o0o__0_.oO_. = A_1
		End Sub

		' Token: 0x170006CA RID: 1738
		' (get) Token: 0x06001E82 RID: 7810 RVA: 0x000C2FE5 File Offset: 0x000C11E5
		' (set) Token: 0x06001E83 RID: 7811 RVA: 0x000C2FED File Offset: 0x000C11ED
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SelectString As String
			Get
				Return Me.o0o__0_.oO_.
			End Get
			Set(value As String)
				Me.o0o__0_.oO_. = value
			End Set
		End Property

		' Token: 0x170006CB RID: 1739
		' (get) Token: 0x06001E84 RID: 7812 RVA: 0x000C2FF6 File Offset: 0x000C11F6
		' (set) Token: 0x06001E85 RID: 7813 RVA: 0x000C2FFE File Offset: 0x000C11FE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overridable Property ConnectionName As String
			Get
				Return Me.oOOO._.
			End Get
			Set(value As String)
				Me.oOOO._. = value
			End Set
		End Property

		' Token: 0x170006CC RID: 1740
		' (get) Token: 0x06001E86 RID: 7814 RVA: 0x000C3007 File Offset: 0x000C1207
		' (set) Token: 0x06001E87 RID: 7815 RVA: 0x000C300F File Offset: 0x000C120F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TableName As String
			Get
				Return Me.o0__oo.o_0o.
			End Get
			Set(value As String)
				Me.o0__oo.o_0o. = value
			End Set
		End Property

		' Token: 0x170006CD RID: 1741
		' (get) Token: 0x06001E88 RID: 7816 RVA: 0x000C3018 File Offset: 0x000C1218
		' (set) Token: 0x06001E89 RID: 7817 RVA: 0x000C3020 File Offset: 0x000C1220
		Public Property Decimals As Integer
			Get
				Return Me.o_o00_O.0_oo.
			End Get
			Set(value As Integer)
				Me.o_o00_O.0_oo. = value
			End Set
		End Property

		' Token: 0x170006CE RID: 1742
		' (get) Token: 0x06001E8A RID: 7818 RVA: 0x000C302C File Offset: 0x000C122C
		' (set) Token: 0x06001E8B RID: 7819 RVA: 0x000C30B6 File Offset: 0x000C12B6
		<oO0oooo("1623")>
		Public Property FromServer As Boolean
			Get
				Return Me.SourceDataTable IsNot Nothing AndAlso Operators.CompareString(Me.SelectString, "", True) <= 0 AndAlso (Me.SourceDataTable.frd_IsOuterTable OrElse Me.SourceDataTable.frd_IsInnerTable OrElse Me.SourceDataTable.frd_IsOuterQuery OrElse Me.SourceDataTable.frd_IsInnerQuery OrElse Operators.CompareString(Me.SourceDataTable.DataServer, "", True) > 0) AndAlso Me.OoO.o_ooO.
			End Get
			Set(value As Boolean)
				Me.OoO.o_ooO. = value
			End Set
		End Property

		' Token: 0x170006CF RID: 1743
		' (get) Token: 0x06001E8C RID: 7820 RVA: 0x000C30BF File Offset: 0x000C12BF
		' (set) Token: 0x06001E8D RID: 7821 RVA: 0x000C30C7 File Offset: 0x000C12C7
		Public Property TableVisible As Boolean
			Get
				Return Me.o0__oo.o_0o.
			End Get
			Set(value As Boolean)
				Me.o0__oo.o_0o. = value
			End Set
		End Property

		' Token: 0x170006D0 RID: 1744
		' (get) Token: 0x06001E8E RID: 7822 RVA: 0x000C30D0 File Offset: 0x000C12D0
		' (set) Token: 0x06001E8F RID: 7823 RVA: 0x000C30D8 File Offset: 0x000C12D8
		Public Property Caption As String
			Get
				Return Me.OO0._O_0O.
			End Get
			Set(value As String)
				Me.OO0._O_0O. = value
			End Set
		End Property

		' Token: 0x170006D1 RID: 1745
		' (get) Token: 0x06001E90 RID: 7824 RVA: 0x000C30E1 File Offset: 0x000C12E1
		' (set) Token: 0x06001E91 RID: 7825 RVA: 0x000C30E9 File Offset: 0x000C12E9
		Public Property SourceDataTable As DataTable
			Get
				Return Me.o0__oo.o_0o.
			End Get
			Set(value As DataTable)
				Me.o0__oo.o_0o. = value
			End Set
		End Property

		' Token: 0x170006D2 RID: 1746
		' (get) Token: 0x06001E92 RID: 7826 RVA: 0x000C30F2 File Offset: 0x000C12F2
		' (set) Token: 0x06001E93 RID: 7827 RVA: 0x000C30FA File Offset: 0x000C12FA
		Public Property Filter As String
			Get
				Return Me.ooO._.
			End Get
			Set(value As String)
				Me.ooO._. = value
			End Set
		End Property

		' Token: 0x170006D3 RID: 1747
		' (get) Token: 0x06001E94 RID: 7828 RVA: 0x000C3103 File Offset: 0x000C1303
		' (set) Token: 0x06001E95 RID: 7829 RVA: 0x000C310B File Offset: 0x000C130B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ExtendFilter As String
			Get
				Return Me.oO._o_0_00o__0.
			End Get
			Set(value As String)
				Me.oO._o_0_00o__0. = value
			End Set
		End Property

		' Token: 0x170006D4 RID: 1748
		' (get) Token: 0x06001E96 RID: 7830 RVA: 0x000C3114 File Offset: 0x000C1314
		' (set) Token: 0x06001E97 RID: 7831 RVA: 0x000C311C File Offset: 0x000C131C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FromAll As Boolean
			Get
				Return Me.O_O.o.
			End Get
			Set(value As Boolean)
				Me.O_O.o. = value
			End Set
		End Property

		' Token: 0x170006D5 RID: 1749
		' (get) Token: 0x06001E98 RID: 7832 RVA: 0x000C3125 File Offset: 0x000C1325
		' (set) Token: 0x06001E99 RID: 7833 RVA: 0x000C312D File Offset: 0x000C132D
		Public Property HorizontalTotal As Boolean
			Get
				Return Me.ooO._.
			End Get
			Set(value As Boolean)
				Me.ooO._. = value
			End Set
		End Property

		' Token: 0x170006D6 RID: 1750
		' (get) Token: 0x06001E9A RID: 7834 RVA: 0x000C3136 File Offset: 0x000C1336
		' (set) Token: 0x06001E9B RID: 7835 RVA: 0x000C313E File Offset: 0x000C133E
		Public Property VerticalTotal As Boolean
			Get
				Return Me.ooOO._o__OO.
			End Get
			Set(value As Boolean)
				Me.ooOO._o__OO. = value
			End Set
		End Property

		' Token: 0x170006D7 RID: 1751
		' (get) Token: 0x06001E9C RID: 7836 RVA: 0x000C3147 File Offset: 0x000C1347
		' (set) Token: 0x06001E9D RID: 7837 RVA: 0x000C314F File Offset: 0x000C134F
		<oO0oooo("1619")>
		Public Property HorizontalProportion As Boolean
			Get
				Return Me.oo.o.
			End Get
			Set(value As Boolean)
				Me.oo.o. = value
			End Set
		End Property

		' Token: 0x170006D8 RID: 1752
		' (get) Token: 0x06001E9E RID: 7838 RVA: 0x000C3158 File Offset: 0x000C1358
		' (set) Token: 0x06001E9F RID: 7839 RVA: 0x000C3160 File Offset: 0x000C1360
		<oO0oooo("1619")>
		Public Property VerticalProportion As Boolean
			Get
				Return Me.oO.00__O__.
			End Get
			Set(value As Boolean)
				Me.oO.00__O__. = value
			End Set
		End Property

		' Token: 0x170006D9 RID: 1753
		' (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000C3169 File Offset: 0x000C1369
		' (set) Token: 0x06001EA1 RID: 7841 RVA: 0x000C3171 File Offset: 0x000C1371
		<oO0oooo("3286")>
		Public Property SamePeriodGrowth As Boolean
			Get
				Return Me.Oo.OO.
			End Get
			Set(value As Boolean)
				Me.Oo.OO. = value
			End Set
		End Property

		' Token: 0x170006DA RID: 1754
		' (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000C317A File Offset: 0x000C137A
		' (set) Token: 0x06001EA3 RID: 7843 RVA: 0x000C3182 File Offset: 0x000C1382
		<oO0oooo("3286")>
		Public Property CircleGrowth As Boolean
			Get
				Return Me.OoO_O_o._.
			End Get
			Set(value As Boolean)
				Me.OoO_O_o._. = value
			End Set
		End Property

		' Token: 0x170006DB RID: 1755
		' (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000C318B File Offset: 0x000C138B
		' (set) Token: 0x06001EA5 RID: 7845 RVA: 0x000C3193 File Offset: 0x000C1393
		<oO0oooo("2671")>
		Public Property Subtotal As Boolean
			Get
				Return Me.o.ooOo__00.
			End Get
			Set(value As Boolean)
				Me.o.ooOo__00. = value
			End Set
		End Property

		' Token: 0x170006DC RID: 1756
		' (get) Token: 0x06001EA6 RID: 7846 RVA: 0x000C319C File Offset: 0x000C139C
		' (set) Token: 0x06001EA7 RID: 7847 RVA: 0x000C31A4 File Offset: 0x000C13A4
		<oO0oooo("2671")>
		Public Property SubtotalLevel As Integer
			Get
				Return Me.O.0O__oOO0.
			End Get
			Set(value As Integer)
				Me.O.0O__oOO0. = value
			End Set
		End Property

		' Token: 0x170006DD RID: 1757
		' (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000C31B0 File Offset: 0x000C13B0
		' (set) Token: 0x06001EA9 RID: 7849 RVA: 0x000C31E1 File Offset: 0x000C13E1
		<oO0oooo("1619")>
		Public Property HorizontalProportionCaption As String
			Get
				Dim result As String
				If Operators.CompareString(Me.oo.o., "", True) > 0 Then
					result = Me.oo.o.
				Else
					result = "份额"
				End If
				Return result
			End Get
			Set(value As String)
				Me.oo.o. = value
			End Set
		End Property

		' Token: 0x170006DE RID: 1758
		' (get) Token: 0x06001EAA RID: 7850 RVA: 0x000C31EC File Offset: 0x000C13EC
		' (set) Token: 0x06001EAB RID: 7851 RVA: 0x000C321D File Offset: 0x000C141D
		<oO0oooo("1619")>
		Public Property VerticalProportionCaption As String
			Get
				Dim result As String
				If Operators.CompareString(Me.oO.00__O__., "", True) > 0 Then
					result = Me.oO.00__O__.
				Else
					result = "占比"
				End If
				Return result
			End Get
			Set(value As String)
				Me.oO.00__O__. = value
			End Set
		End Property

		' Token: 0x170006DF RID: 1759
		' (get) Token: 0x06001EAC RID: 7852 RVA: 0x000C3226 File Offset: 0x000C1426
		Public ReadOnly Property HGroups As GroupCollection
			Get
				Return Me.OO0o_O00.o.
			End Get
		End Property

		' Token: 0x170006E0 RID: 1760
		' (get) Token: 0x06001EAD RID: 7853 RVA: 0x000C322E File Offset: 0x000C142E
		Public ReadOnly Property VGroups As CrossGroupCollection
			Get
				Return Me.O.oOO_0.
			End Get
		End Property

		' Token: 0x170006E1 RID: 1761
		' (get) Token: 0x06001EAE RID: 7854 RVA: 0x000C3236 File Offset: 0x000C1436
		Public ReadOnly Property Totals As CrossTotalCollection
			Get
				Return Me.o0__oo.o_0o.
			End Get
		End Property

		' Token: 0x170006E2 RID: 1762
		' (get) Token: 0x06001EAF RID: 7855 RVA: 0x000C323E File Offset: 0x000C143E
		' (set) Token: 0x06001EB0 RID: 7856 RVA: 0x000C3246 File Offset: 0x000C1446
		Public Property OrderByTotal As Boolean
			Get
				Return Me.oOoo.O.
			End Get
			Set(value As Boolean)
				Me.oOoo.O. = value
			End Set
		End Property

		' Token: 0x170006E3 RID: 1763
		' (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000C324F File Offset: 0x000C144F
		' (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000C3257 File Offset: 0x000C1457
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HttpClient As HttpClient
			Get
				Return Me.OO0o_O00.o.
			End Get
			Set(value As HttpClient)
				Me.OO0o_O00.o. = value
			End Set
		End Property

		' Token: 0x06001EB3 RID: 7859 RVA: 0x000C3260 File Offset: 0x000C1460
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

		' Token: 0x06001EB4 RID: 7860 RVA: 0x000C32A4 File Offset: 0x000C14A4
		Public Overridable Function Build() As DataTable
			If Operators.CompareString(Me.SelectString, "", True) = 0 AndAlso OO_00oOO.Tables.get_Contains(Me.SourceDataTable.Name) Then
				OO_00oOO.Tables(Me.SourceDataTable.Name).O_0._O_0OO000O. = Me
			End If
			Return Me.Build(False)
		End Function

		' Token: 0x06001EB5 RID: 7861 RVA: 0x000C3300 File Offset: 0x000C1500
		Public Overridable Function Build(OnlyDataTable As Boolean) As DataTable
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
			Dim result As DataTable
			If(Me.HGroups.Count = 0 OrElse Me.VGroups.Count = 0) Or Me.Totals.Count = 0 Then
				result = Nothing
			Else
				Dim dataTable As DataTable = Me.BuildDataSource()
				Dim dataTable2 As DataTable = Me.O0oo00.0O_oO_.(dataTable, OnlyDataTable, a_)
				If Me.Subtotal AndAlso Not OnlyDataTable Then
					Me.o_o00_O.0_oo.(dataTable2.Name, dataTable)
				End If
				result = dataTable2
			End If
			Return result
		End Function

		' Token: 0x06001EB6 RID: 7862 RVA: 0x000C33EC File Offset: 0x000C15EC
		Protected Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable)
			Dim table As Table = OO_00oOO.Tables(A_0)
			table.SubtotalGroups.Clear()
			Dim num As Integer
			If Me.SubtotalLevel = -1 Then
				num = Integer.MaxValue
			Else
				num = Me.SubtotalLevel
			End If
			If num > 0 Then
				For i As Integer = Math.Min(Me.SubtotalLevel - 1, Me.o.000Oo_o..Count - 2)To 0 Step -1
					Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
					subtotalGroup.GroupOn = Me.o.000Oo_o.(i)
					subtotalGroup.TotalOn = Me.o0_.o..Trim(New Char() { ","c }) + "," + Me.o_o.__.
					If Me.Totals.Count > 0 Then
						If Me.Totals(0).Aggregate = 4 Then
							subtotalGroup.Aggregate = 2
						Else
							subtotalGroup.Aggregate = Me.Totals(0).Aggregate
						End If
					ElseIf Me.Totals.Exprs.Count > 0 Then
						If Me.Totals.Exprs(0).Aggregate = 4 Then
							subtotalGroup.Aggregate = 2
						Else
							subtotalGroup.Aggregate = Me.Totals.Exprs(0).Aggregate
						End If
					End If
					subtotalGroup.Caption = "小计 {0}"
					table.SubtotalGroups.Add(subtotalGroup)
					Dim num2 As Integer
					num2 += 1
					If num2 >= num Then
						Exit For
					End If
				Next
			End If
			Dim subtotalGroup2 As SubtotalGroup = New SubtotalGroup()
			subtotalGroup2.GroupOn = "*"
			If table.SubtotalGroups.Count = 0 Then
				subtotalGroup2.TotalOn = Me.o0_.o..Trim(New Char() { ","c }) + "," + Me.o_o.__.
			Else
				subtotalGroup2.TotalOn = Me.O__0O_o_.0_OO_..Trim(New Char() { ","c }) + "," + Me.o_o.__.
			End If
			If Me.Totals.Count > 0 Then
				If Me.Totals(0).Aggregate = 4 Then
					subtotalGroup2.Aggregate = 2
				Else
					subtotalGroup2.Aggregate = Me.Totals(0).Aggregate
				End If
			ElseIf Me.Totals.Exprs.Count > 0 Then
				If Me.Totals.Exprs(0).Aggregate = 4 Then
					subtotalGroup2.Aggregate = 2
				Else
					subtotalGroup2.Aggregate = Me.Totals.Exprs(0).Aggregate
				End If
			End If
			subtotalGroup2.Caption = "总计"
			table.SubtotalGroups.Add(subtotalGroup2)
			table.Subtotal(False)
			If Me.Oo_0O0o.ooO..Count > 0 Then
				Dim o_oOooO_O As O_oOooO_O = table.foxGrid
				Dim num3 As Integer = o_oOooO_O.Rows.Count - 1
				Dim num4 As Integer = o_oOooO_O.Rows.Fixed + 1
				For j As Integer = num3 To num4 Step -1
					Dim row As Row = o_oOooO_O.Rows(j)
					If row.IsNode AndAlso row.Node.PrevNode IsNot Nothing Then
						Dim row2 As Row = row.Node.PrevNode.Row
						Dim num5 As Integer = Me.Oo_0O0o.ooO..Count - 1
						For k As Integer = 0 To num5
							Dim text As String = Me.Oo_0O0o.ooO.(k)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(row2(text))
							Dim num6 As Double
							If objectValue IsNot Nothing AndAlso Double.TryParse(objectValue.ToString(), num6) AndAlso num6 > 0.0 Then
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(row(text))
								Dim num7 As Double
								If objectValue2 IsNot Nothing AndAlso Double.TryParse(objectValue2.ToString(), num7) Then
									row(Me.O_O_ooo.OOOOoo.(k)) = (num7 - num6) / num6
								End If
							End If
						Next
					End If
				Next
			End If
		End Sub

		' Token: 0x06001EB7 RID: 7863 RVA: 0x000C37C4 File Offset: 0x000C19C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x06001EB8 RID: 7864 RVA: 0x000C37E0 File Offset: 0x000C19E0
		<oO0oooo("1909")>
		Public Overridable Function BuildDataSource() As fxDataSource
			Dim groupTableBuilder As GroupTableBuilder = New GroupTableBuilder()
			Dim list As List(Of CrossTotalOn) = New List(Of CrossTotalOn)()
			groupTableBuilder.SourceDataTable = Me.SourceDataTable
			groupTableBuilder.CommandTimeOut = Me.CommandTimeOut
			groupTableBuilder.Filter = Me.Filter
			groupTableBuilder.Decimals = Me.Decimals
			groupTableBuilder.FromServer = Me.FromServer
			groupTableBuilder.TableName = OoOo0O.OO_o.0o_O.(6)
			groupTableBuilder.Groups.AddRange(Me.HGroups)
			groupTableBuilder.VerticalTotal = Me.VerticalTotal
			groupTableBuilder.SelectString = Me.SelectString
			groupTableBuilder.ConnectionName = Me.ConnectionName
			Try
				For Each crossGroupOn As CrossGroupOn In Me.VGroups
					Dim groupOn As GroupOn = New GroupOn()
					groupOn.Name = crossGroupOn.Name
					groupOn.NewName = crossGroupOn.NewName
					groupOn.DateGroup = crossGroupOn.DateGroup
					groupOn.Pattern = crossGroupOn.Pattern
					groupOn.Vertical = True
					groupTableBuilder.Groups.Add(groupOn)
				Next
			Finally
				Dim enumerator As IEnumerator(Of CrossGroupOn)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim num As Integer = Me.Totals.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = False
				Dim crossTotalOn As CrossTotalOn = Me.Totals(i)
				Dim num2 As Integer = i + 1
				Dim num3 As Integer = Me.Totals.Count - 1
				For j As Integer = num2 To num3
					Dim crossTotalOn2 As CrossTotalOn = Me.Totals(j)
					If Operators.CompareString(crossTotalOn.Name, crossTotalOn2.Name, True) = 0 AndAlso Operators.CompareString(crossTotalOn.Caption, crossTotalOn2.Caption, True) = 0 Then
						If crossTotalOn.Aggregate = crossTotalOn2.Aggregate Then
							list.Add(crossTotalOn2)
						Else
							flag = True
							crossTotalOn2.Caption = Oo00.OoO_.__o.(crossTotalOn2.Aggregate)
						End If
					End If
				Next
				If flag Then
					crossTotalOn.Caption = Oo00.OoO_.__o.(crossTotalOn.Aggregate)
				End If
			Next
			Try
				For Each item As CrossTotalOn In list
					Me.Totals.Remove(item)
				Next
			Finally
				Dim enumerator2 As List(Of CrossTotalOn).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Dim num4 As Integer = Me.Totals.Count - 1
			For k As Integer = 0 To num4
				Dim flag2 As Boolean = False
				Dim crossTotalOn3 As CrossTotalOn = Me.Totals(k)
				Dim num5 As Integer = k + 1
				Dim num6 As Integer = Me.Totals.Count - 1
				For l As Integer = num5 To num6
					Dim crossTotalOn4 As CrossTotalOn = Me.Totals(l)
					If Operators.CompareString(crossTotalOn3.Name, crossTotalOn4.Name, True) <> 0 AndAlso Operators.CompareString(crossTotalOn3.Caption, crossTotalOn4.Caption, True) = 0 AndAlso Not crossTotalOn4.Caption.StartsWith(crossTotalOn4.Name + "_") Then
						flag2 = True
						crossTotalOn4.Caption = crossTotalOn4.Name + "_" + crossTotalOn4.Caption
					End If
				Next
				If flag2 AndAlso Not crossTotalOn3.Caption.StartsWith(crossTotalOn3.Name + "_") Then
					crossTotalOn3.Caption = crossTotalOn3.Name + "_" + crossTotalOn3.Caption
				End If
			Next
			Try
				For Each crossTotalOn5 As CrossTotalOn In Me.Totals
					Dim totalOn As TotalOn = New TotalOn()
					totalOn.Name = crossTotalOn5.Name
					totalOn.Aggregate = crossTotalOn5.Aggregate
					totalOn.NewCaption = crossTotalOn5.Caption
					totalOn.upto = crossTotalOn5.upto
					If totalOn.upto Then
						totalOn.NewName = totalOn.Name + "_up"
					End If
					groupTableBuilder.Totals.Add(totalOn)
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of CrossTotalOn)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			groupTableBuilder.o00OO.oOO0O_.()
			Dim a_ As DataTable
			If Operators.CompareString(Me.SelectString, "", True) > 0 OrElse Me.FromServer Then
				a_ = groupTableBuilder.o0_O.00ooOo0.()
			Else
				a_ = groupTableBuilder.O.O0_0O.()
			End If
			Dim fxDataSource As fxDataSource = Me.o__.Ooo.(a_, groupTableBuilder)
			fxDataSource.O_O_O.00. = Me
			Return fxDataSource
		End Function

		' Token: 0x06001EB9 RID: 7865 RVA: 0x000C3C30 File Offset: 0x000C1E30
		Protected Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As Boolean, A_2 As String) As DataTable
			Dim dataTable As DataTable
			If A_1 Then
				Foxtable.RibbonMenu.StatusBar.Reset()
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
			Try
				For Each groupOn As GroupOn In Me.HGroups
					If dataTable.DataCols.Contains(groupOn.NewName) Then
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							dataTable.DataCols(groupOn.NewName).Caption = groupOn.NewCaption
						ElseIf Operators.CompareString(groupOn.NewName, groupOn.Name, True) = 0 AndAlso Me.SourceDataTable IsNot Nothing AndAlso Operators.CompareString(Me.SourceDataTable.DataCols(groupOn.Name).Caption, "", True) > 0 Then
							dataTable.DataCols(groupOn.NewName).Caption = Me.SourceDataTable.DataCols(groupOn.Name).Caption
						End If
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of GroupOn)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Dim result As DataTable
			If A_1 Then
				Foxtable.RibbonMenu.StatusBar.Reset()
				result = dataTable
			Else
				New O_0(O_O0OO.o__.O.(), A_0)
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
				Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, Me.TableVisible, False)
				Try
					For Each text As String In Me.O.oOO_0.
						OO_00oOO.Tables(Me.TableName).foxGrid.Cols(text).Format = "#0.00%"
						OO_00oOO.DataTables(Me.TableName).DataCols(text).PercentStyle = True
					Next
				Finally
					Dim enumerator3 As List(Of String).Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				If Operators.CompareString(A_2, Me.TableName, True) = 0 Then
					OO_00oOO.MainTable = OO_00oOO.Tables(Me.TableName)
				End If
				Foxtable.RibbonMenu.StatusBar.Reset()
				result = dataTable
			End If
			Return result
		End Function

		' Token: 0x06001EBA RID: 7866 RVA: 0x000C3F84 File Offset: 0x000C2184
		Protected Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As GroupTableBuilder) As fxDataSource
			Return Me.O0oo00.0O_oO_.(A_0, A_1)
		End Function

		' Token: 0x06001EBB RID: 7867 RVA: 0x000C3F90 File Offset: 0x000C2190
		Private Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As GroupTableBuilder) As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num47 As Integer
			Dim obj15 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim fxDataSource As fxDataSource = New fxDataSource()
				IL_10:
				num2 = 3
				Dim dictionary As Dictionary(Of String, GroupOn) = New Dictionary(Of String, GroupOn)()
				IL_19:
				num2 = 4
				Dim dictionary2 As Dictionary(Of String, GroupOn) = New Dictionary(Of String, GroupOn)()
				IL_22:
				num2 = 5
				Dim list As List(Of String) = New List(Of String)()
				IL_2B:
				num2 = 6
				Dim list2 As List(Of String) = New List(Of String)()
				IL_34:
				num2 = 7
				Dim text As String = ""
				IL_3D:
				num2 = 8
				Dim text2 As String = ""
				IL_46:
				num2 = 9
				Dim text3 As String = ""
				IL_50:
				num2 = 10
				Dim list3 As List(Of String) = New List(Of String)()
				IL_5A:
				num2 = 11
				Me.O.oOO_0..Clear()
				IL_68:
				num2 = 12
				Me.Oo_0O0o.ooO..Clear()
				IL_76:
				num2 = 13
				Me.O_O_ooo.OOOOoo..Clear()
				IL_84:
				num2 = 14
				Me.o.000Oo_o..Clear()
				IL_92:
				num2 = 15
				Me.o0_.o. = ""
				IL_A0:
				num2 = 16
				Me.O__0O_o_.0_OO_. = ""
				IL_AE:
				num2 = 17
				Dim enumerator As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_CC:
					num2 = 18
					If A_0.Columns.Contains(groupOn.NewName) Then
						IL_E6:
						num2 = 19
						If Not groupOn.Vertical Then
							IL_F5:
							num2 = 20
							Me.o.000Oo_o..Add(groupOn.NewName)
							IL_10A:
							num2 = 21
							dictionary.Add(groupOn.NewName, groupOn)
							IL_11D:
							num2 = 22
							list.Add(groupOn.NewName)
							IL_12E:
							num2 = 23
							If Not Me.VerticalTotal Then
								IL_139:
								num2 = 24
								fxDataSource.Columns.Add(groupOn.NewName, A_0.Columns(groupOn.NewName).DataType)
							Else
								IL_169:
								num2 = 26
								fxDataSource.Columns.Add(groupOn.NewName, GetType(String))
							End If
						Else
							IL_18C:
							num2 = 28
							dictionary2.Add(groupOn.NewName, groupOn)
							IL_19F:
							num2 = 29
							list2.Add(groupOn.NewName)
						End If
					End If
					IL_1B0:
					num2 = 30
				End While
				IL_1BF:
				num2 = 31
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_1CD:
				num2 = 32
				Dim enumerator2 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator2.MoveNext()
					Dim groupOn2 As GroupOn = enumerator2.Current
					IL_1E8:
					num2 = 33
					If Not groupOn2.Vertical Then
						IL_1F4:
						num2 = 34
						If Operators.CompareString(text2, "", True) > 0 Then
							IL_207:
							num2 = 35
							text2 += ","
						End If
						IL_218:
						num2 = 36
						text2 += groupOn2.NewName
					End If
					IL_22B:
					num2 = 37
				End While
				IL_237:
				num2 = 38
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_245:
				num2 = 39
				Dim enumerator3 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator3.MoveNext()
					Dim groupOn3 As GroupOn = enumerator3.Current
					IL_263:
					num2 = 40
					If groupOn3.Vertical Then
						IL_26F:
						num2 = 41
						If Operators.CompareString(text2, "", True) > 0 Then
							IL_282:
							num2 = 42
							text2 += ","
						End If
						IL_293:
						num2 = 43
						text2 += groupOn3.NewName
						IL_2A6:
						num2 = 44
						If Operators.CompareString(text, "", True) > 0 Then
							IL_2B9:
							num2 = 45
							text += ","
						End If
						IL_2CA:
						num2 = 46
						text += groupOn3.NewName
					End If
					IL_2DD:
					num2 = 47
				End While
				IL_2EC:
				num2 = 48
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_2FA:
				num2 = 49
				If list.Count <= 1 Then
					GoTo IL_351
				End If
				IL_307:
				num2 = 50
				text3 = list(list.Count - 2)
				IL_31C:
				num2 = 51
				Dim num3 As Integer = list.Count - 2
				For i As Integer = 0 To num3
					IL_32F:
					num2 = 52
					list3.Add(list(i))
					IL_342:
					num2 = 53
				Next
				IL_351:
				num2 = 54
				Dim array As DataRow() = A_0.[Select]("", text, DataViewRowState.CurrentRows)
				IL_365:
				num2 = 55
				Dim enumerator4 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator4.MoveNext()
					Dim totalOn As TotalOn = enumerator4.Current
					IL_383:
					num2 = 56
					totalOn.Oo_o0O00O.o0O..Clear()
					IL_392:
					num2 = 57
					If A_0.Columns.Contains(totalOn.NewName) Then
						IL_3AC:
						num2 = 58
						Dim num4 As Integer = 1
						IL_3B2:
						num2 = 59
						Dim text4 As String = ""
						IL_3BC:
						num2 = 60
						Dim num5 As Integer = array.Length - 1
						Dim j As Integer = 0
						While j <= num5
							IL_3CF:
							num2 = 61
							Dim dataRow As DataRow = array(j)
							IL_3D9:
							num2 = 62
							Dim flag As Boolean
							If j = 0 Then
								IL_3E0:
								num2 = 63
								flag = False
							Else
								IL_3E8:
								num2 = 65
								flag = True
								IL_3EE:
								num2 = 66
								Dim enumerator5 As List(Of String).Enumerator = list2.GetEnumerator()
								While enumerator5.MoveNext()
									Dim columnName As String = enumerator5.Current
									IL_405:
									num2 = 67
									If Operators.CompareString(dataRow(columnName).ToString(), array(j - 1)(columnName).ToString(), True) <> 0 Then
										IL_431:
										num2 = 68
										flag = False
										Exit While
									End If
									IL_439:
									num2 = 70
								End While
								IL_445:
								num2 = 71
								CType(enumerator5, IDisposable).Dispose()
							End If
							IL_455:
							num2 = 72
							If flag Then
								GoTo IL_86B
							End If
							IL_45F:
							num2 = 73
							text4 = totalOn.NewName + "_" + Conversions.ToString(num4)
							IL_47C:
							num2 = 74
							If Not fxDataSource.Columns.Contains(text4) Then
								IL_492:
								num2 = 76
								fxDataSource.Columns.Add(text4, A_0.Columns(totalOn.NewName).DataType)
								IL_4BB:
								num2 = 77
								totalOn.Oo_o0O00O.o0O..Add(text4)
								IL_4CC:
								num2 = 78
								If Me.SourceDataTable IsNot Nothing AndAlso Me.SourceDataTable.DataCols.Contains(totalOn.Name) Then
									IL_4F0:
									num2 = 79
									If Me.SourceDataTable.DataCols(totalOn.Name).ExtendColumnType = 8 Then
										IL_512:
										num2 = 80
										fxDataSource.Columns(text4).ExtendedProperties.Add("IsTimeSpan", "")
									End If
								End If
								IL_537:
								num2 = 81
								Dim text5 As String = ""
								IL_541:
								num2 = 82
								num4 += 1
								IL_54A:
								num2 = 83
								Me.o0_.o. = Me.o0_.o. + "," + text4
								IL_565:
								num2 = 84
								Me.O__0O_o_.0_OO_. = Me.O__0O_o_.0_OO_. + "," + text4
								IL_580:
								num2 = 85
								Dim enumerator6 As List(Of String).Enumerator = list2.GetEnumerator()
								While enumerator6.MoveNext()
									Dim text6 As String = enumerator6.Current
									IL_59A:
									num2 = 86
									If Operators.CompareString(text5, "", True) > 0 Then
										IL_5AD:
										num2 = 87
										text5 += "_"
									End If
									IL_5BE:
									num2 = 88
									If dataRow.Table.Columns(text6).DataType Is GetType(Boolean) Then
										IL_5E8:
										num2 = 89
										If Operators.CompareString(dictionary2(text6).Pattern, "", True) > 0 Then
											IL_60A:
											num2 = 90
											Dim array2 As String() = dictionary2(text6).Pattern.Split(New Char() { "|"c })
											IL_62D:
											num2 = 91
											If array2.Length = 2 Then
												IL_63A:
												num2 = 92
												Dim flag2 As Boolean = Conversions.ToBoolean(dataRow(text6))
												IL_64D:
												num2 = 93
												If flag2 Then
													IL_654:
													num2 = 94
													text5 += array2(0)
												Else
													IL_669:
													num2 = 96
													text5 += array2(1)
												End If
											End If
										End If
									Else
										IL_67E:
										num2 = 98
										If dataRow.IsNull(text6) Then
											IL_68C:
											num2 = 99
											text5 += "空"
										Else
											IL_6A2:
											num2 = 101
											If Operators.CompareString(dictionary2(text6).Pattern, "", True) > 0 AndAlso dictionary2(text6).Pattern.IndexOf("{0}") >= 0 Then
												IL_6DC:
												num2 = 102
												text5 += dictionary2(text6).Pattern.Replace("{0}", dataRow(text6).ToString())
											Else
												IL_713:
												num2 = 104
												If dataRow.Table.Columns(text6).DataType Is GetType(DateTime) Then
													IL_73D:
													num2 = 105
													Dim dateTime As DateTime = Conversions.ToDate(dataRow(text6))
													IL_750:
													num2 = 106
													If DateTime.Compare(dateTime.[Date], dateTime) = 0 Then
														IL_763:
														num2 = 107
														text5 += Strings.Format(dateTime, "yyyy-MM-dd")
													Else
														IL_782:
														num2 = 109
														If dateTime.Second = 0 Then
															IL_78E:
															num2 = 110
															text5 += Strings.Format(dateTime, "yyyy-MM-dd HH:mm")
														Else
															IL_7AD:
															num2 = 112
															text5 += Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss")
														End If
													End If
												Else
													IL_7CC:
													num2 = 114
													text5 += dataRow(text6).ToString()
												End If
											End If
										End If
									End If
									IL_7E6:
									num2 = 115
								End While
								IL_7F5:
								num2 = 116
								CType(enumerator6, IDisposable).Dispose()
								IL_805:
								num2 = 117
								If A_1.Totals.Count > 1 Then
									IL_816:
									num2 = 118
									If Me.OrderByTotal Then
										IL_821:
										num2 = 119
										text5 = totalOn.NewCaption + "_" + text5
									Else
										IL_83B:
										num2 = 121
										text5 = text5 + "_" + totalOn.NewCaption
									End If
								End If
								IL_853:
								num2 = 122
								fxDataSource.Columns(text4).Caption = text5
								GoTo IL_86B
							End If
							IL_8A9:
							num2 = 124
							j += 1
							Continue While
							IL_86B:
							num2 = 123
							dataRow.RowError = String.Concat(New String() { dataRow.RowError, totalOn.NewName, vbVerticalTab, text4, vbVerticalTab })
							GoTo IL_8A9
						End While
					End If
					IL_8BB:
					num2 = 125
				End While
				IL_8CA:
				num2 = 126
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_8D8:
				num2 = 127
				array = A_0.[Select]("", text2, DataViewRowState.CurrentRows)
				IL_8EC:
				num2 = 128
				Dim dataRow2 As DataRow = Nothing
				IL_8F5:
				num2 = 129
				Dim num6 As Integer = array.Length - 1
				For k As Integer = 0 To num6
					IL_90B:
					num2 = 130
					Dim dataRow3 As DataRow = array(k)
					IL_918:
					num2 = 131
					Dim flag As Boolean
					If k = 0 Then
						IL_922:
						num2 = 132
						flag = False
					Else
						IL_92D:
						num2 = 134
						flag = True
						IL_936:
						num2 = 135
						Dim enumerator7 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator7.MoveNext()
							Dim columnName2 As String = enumerator7.Current
							IL_950:
							num2 = 136
							If Operators.CompareString(dataRow3(columnName2).ToString(), array(k - 1)(columnName2).ToString(), True) <> 0 Then
								IL_97F:
								num2 = 137
								flag = False
								Exit While
							End If
							IL_98A:
							num2 = 139
						End While
						IL_999:
						num2 = 140
						CType(enumerator7, IDisposable).Dispose()
					End If
					IL_9AC:
					num2 = 141
					If Not flag Then
						IL_9B9:
						num2 = 142
						dataRow2 = fxDataSource.NewRow()
						IL_9C8:
						num2 = 143
						Dim enumerator8 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator8.MoveNext()
							Dim text7 As String = enumerator8.Current
							IL_9E5:
							num2 = 144
							If A_0.Columns(text7).DataType Is GetType(DateTime) Then
								IL_A0C:
								num2 = 145
								If Not dataRow3.IsNull(text7) Then
									IL_A20:
									num2 = 146
									Dim dateTime2 As DateTime = Conversions.ToDate(dataRow3(text7))
									IL_A36:
									num2 = 147
									If DateTime.Compare(dateTime2.[Date], dateTime2) = 0 Then
										IL_A4C:
										num2 = 148
										dataRow2(text7) = Strings.Format(dateTime2, "yyyy-MM-dd")
									Else
										IL_A6E:
										num2 = 150
										If dateTime2.Second = 0 Then
											IL_A7D:
											num2 = 151
											dataRow2(text7) = Strings.Format(dateTime2, "yyyy-MM-dd HH:mm")
										Else
											IL_A9F:
											num2 = 153
											dataRow2(text7) = Strings.Format(dateTime2, "yyyy-MM-dd HH:mm:ss")
										End If
									End If
								End If
							Else
								IL_AC1:
								num2 = 155
								dataRow2(text7) = RuntimeHelpers.GetObjectValue(dataRow3(text7))
							End If
							IL_ADE:
							num2 = 156
						End While
						IL_AF0:
						num2 = 157
						CType(enumerator8, IDisposable).Dispose()
						IL_B03:
						num2 = 158
						fxDataSource.Rows.Add(dataRow2)
					End If
					IL_B17:
					num2 = 159
					If Operators.CompareString(dataRow3.RowError, "", True) > 0 Then
						IL_B32:
						num2 = 160
						Dim array3 As String() = dataRow3.RowError.Trim(New Char() { vbVerticalTab }).Split(New Char() { vbVerticalTab })
						IL_B61:
						num2 = 161
						Dim num7 As Integer = array3.Length - 2
						For l As Integer = 0 To num7 Step 2
							IL_B74:
							num2 = 162
							dataRow2(array3(l + 1)) = RuntimeHelpers.GetObjectValue(dataRow3(array3(l)))
							IL_B99:
							num2 = 163
						Next
					End If
					IL_BAB:
					num2 = 164
				Next
				IL_BC0:
				num2 = 165
				Dim enumerator9 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator9.MoveNext()
					Dim totalOn2 As TotalOn = enumerator9.Current
					IL_BE1:
					num2 = 166
					If totalOn2.upto AndAlso (totalOn2.Aggregate = 2 OrElse totalOn2.Aggregate = 7 OrElse totalOn2.Aggregate = 8) Then
						IL_C14:
						num2 = 167
						Dim enumerator10 As List(Of String).Enumerator = totalOn2.Oo_o0O00O.o0O..GetEnumerator()
						While enumerator10.MoveNext()
							Dim columnName3 As String = enumerator10.Current
							IL_C36:
							num2 = 168
							Dim num8 As Integer = fxDataSource.Rows.Count - 1
							For m As Integer = 1 To num8
								IL_C54:
								num2 = 169
								Dim dataRow4 As DataRow = fxDataSource.Rows(m - 1)
								IL_C6C:
								num2 = 170
								Dim dataRow5 As DataRow = fxDataSource.Rows(m)
								IL_C82:
								num2 = 171
								Dim num9 As Decimal
								If dataRow5.IsNull(columnName3) Then
									IL_C93:
									num2 = 172
									num9 = 0D
								Else
									IL_CA3:
									num2 = 174
									num9 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow5(columnName3)))
								End If
								IL_CBE:
								num2 = 175
								Dim num10 As Decimal
								If Not dataRow4.IsNull(columnName3) Then
									IL_CCF:
									num2 = 176
									num10 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow4(columnName3)))
								End If
								IL_CEA:
								num2 = 177
								If dataRow4.IsNull(columnName3) Or (list3.Count > 0 AndAlso Oo00.o00O0O_.O.(list3, dataRow4, dataRow5)) Then
									IL_D14:
									num2 = 178
									If totalOn2.Aggregate = 2 Then
										IL_D24:
										num2 = 179
										num10 = 0D
									Else
										IL_D34:
										num2 = 181
										num10 = num9
									End If
								End If
								IL_D3E:
								num2 = 182
								Select Case totalOn2.Aggregate
									Case 2, 4
										IL_D74:
										num2 = 184
										dataRow5(columnName3) = Decimal.Add(num10, num9)
									Case 7
										IL_DB2:
										num2 = 188
										dataRow5(columnName3) = Math.Max(num10, num9)
									Case 8
										IL_D93:
										num2 = 186
										dataRow5(columnName3) = Math.Min(num10, num9)
								End Select
								IL_DCF:
								num2 = 190
							Next
							IL_DE4:
							num2 = 191
						End While
						IL_DF6:
						num2 = 192
						CType(enumerator10, IDisposable).Dispose()
					End If
					IL_E09:
					num2 = 193
				End While
				IL_E1B:
				num2 = 194
				If enumerator9 IsNot Nothing Then
					enumerator9.Dispose()
				End If
				IL_E2C:
				num2 = 195
				If Me.OrderByTotal OrElse A_1.Totals.Count <= 1 Then
					GoTo IL_F73
				End If
				IL_E4E:
				num2 = 196
				Dim list4 As List(Of String) = New List(Of String)()
				IL_E5B:
				num2 = 197
				Dim count As Integer = list.Count
				Dim num11 As Integer = fxDataSource.Columns.Count - 1
				For n As Integer = count To num11
					IL_E7F:
					num2 = 198
					Dim text8 As String = fxDataSource.Columns(n).Caption
					IL_E9A:
					num2 = 199
					text8 = text8.Substring(0, text8.LastIndexOf("_") + 1)
					IL_EB8:
					num2 = 200
					If Not list4.Contains(text8) Then
						IL_ECC:
						num2 = 203
						list4.Add(text8)
						IL_EDB:
						num2 = 204
						Dim num12 As Integer = n
						IL_EE5:
						num2 = 205
						Dim num13 As Integer = n + 1
						Dim num14 As Integer = fxDataSource.Columns.Count - 1
						For num15 As Integer = num13 To num14
							IL_F03:
							num2 = 206
							If fxDataSource.Columns(num15).Caption.StartsWith(text8) Then
								IL_F25:
								num2 = 207
								num12 += 1
								IL_F31:
								num2 = 208
								fxDataSource.Columns(num15).SetOrdinal(num12)
							End If
							IL_F4C:
							num2 = 209
						Next
					End If
					IL_F5E:
					num2 = 210
				Next
				IL_F73:
				num2 = 211
				If Not Me.VerticalProportion Then
					GoTo IL_16B9
				End If
				IL_F84:
				num2 = 212
				Dim enumerator11 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator11.MoveNext()
					Dim totalOn3 As TotalOn = enumerator11.Current
					IL_FA5:
					num2 = 213
					If A_0.Columns.Contains(totalOn3.NewName) Then
						IL_FC2:
						num2 = 214
						Dim list5 As List(Of String) = New List(Of String)()
						IL_FCF:
						num2 = 215
						Dim enumerator12 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator12.MoveNext()
							Dim obj As Object = enumerator12.Current
							Dim dataColumn As DataColumn = CType(obj, DataColumn)
							IL_FF3:
							num2 = 216
							If dataColumn.ColumnName.StartsWith(totalOn3.NewName + "_") AndAlso Versioned.IsNumeric(dataColumn.ColumnName.Substring(totalOn3.NewName.Length + 1)) Then
								IL_1039:
								num2 = 217
								list5.Add(dataColumn.ColumnName)
							End If
							IL_104D:
							num2 = 218
						End While
						IL_105C:
						num2 = 219
						If TypeOf enumerator12 Is IDisposable Then
							TryCast(enumerator12, IDisposable).Dispose()
						End If
						IL_1077:
						num2 = 220
						Dim enumerator13 As List(Of String).Enumerator = list5.GetEnumerator()
						While enumerator13.MoveNext()
							Dim text9 As String = enumerator13.Current
							IL_1094:
							num2 = 221
							Dim text10 As String = text9 + "vp"
							IL_10A8:
							num2 = 222
							Me.o0_.o. = Me.o0_.o. + "," + text10
							IL_10C6:
							num2 = 223
							fxDataSource.Columns.Add(text10, GetType(Double))
							IL_10E5:
							num2 = 224
							fxDataSource.Columns(text10).SetOrdinal(fxDataSource.Columns(text9).Ordinal + 1)
							IL_1113:
							num2 = 225
							Dim text11 As String = fxDataSource.Columns(text9).Caption
							IL_112E:
							num2 = 226
							Dim num16 As Integer = text11.Length - text11.Replace("_", "").Length
							IL_1154:
							num2 = 227
							If num16 > Me.VGroups.Count + Me.Totals.Count - 2 Then
								IL_1177:
								num2 = 228
								text11 = text11.Substring(0, text11.LastIndexOf("_") + 1)
								IL_1195:
								num2 = 229
								fxDataSource.Columns(text10).Caption = text11 + Me.VerticalProportionCaption
							Else
								IL_11BD:
								num2 = 231
								fxDataSource.Columns(text10).Caption = text11 + Me.VerticalProportionCaption
							End If
							IL_11E3:
							num2 = 232
							fxDataSource.Columns(text10).ExtendedProperties.Add("displayformat", "#0.00%")
							IL_120B:
							num2 = 233
							Me.O.oOO_0..Add(text10)
							IL_121E:
							num2 = 234
						End While
						IL_1230:
						num2 = 235
						CType(enumerator13, IDisposable).Dispose()
						IL_1243:
						num2 = 236
						Dim enumerator14 As List(Of String).Enumerator = list5.GetEnumerator()
						While enumerator14.MoveNext()
							Dim text12 As String = enumerator14.Current
							IL_1260:
							num2 = 237
							If Operators.CompareString(text3, "", True) = 0 Then
								IL_1278:
								num2 = 238
								Dim num17 As Double = 0.0
								IL_1289:
								num2 = 239
								If totalOn3.upto Then
									IL_1298:
									num2 = 240
									For num18 As Integer = fxDataSource.Rows.Count - 1 To 0 Step -1
										IL_12B0:
										num2 = 241
										If Not fxDataSource.Rows(num18).IsNull(text12) Then
											IL_12CD:
											num2 = 242
											num17 = Convert.ToDouble(Conversions.ToDecimal(fxDataSource.Rows(num18)(text12)))
											Exit For
										End If
										IL_12F9:
										num2 = 244
									Next
								Else
									IL_130C:
									num2 = 246
									Dim enumerator15 As IEnumerator = fxDataSource.Rows.GetEnumerator()
									While enumerator15.MoveNext()
										Dim obj2 As Object = enumerator15.Current
										Dim dataRow6 As DataRow = CType(obj2, DataRow)
										IL_1330:
										num2 = 247
										If Not dataRow6.IsNull(text12) Then
											IL_1341:
											num2 = 248
											num17 += Convert.ToDouble(Conversions.ToDecimal(dataRow6(text12)))
										End If
										IL_135F:
										num2 = 249
									End While
									IL_136E:
									num2 = 250
									If TypeOf enumerator15 Is IDisposable Then
										TryCast(enumerator15, IDisposable).Dispose()
									End If
								End If
								IL_1389:
								num2 = 251
								If num17 <> 0.0 Then
									IL_139F:
									num2 = 252
									Dim enumerator16 As IEnumerator = fxDataSource.Rows.GetEnumerator()
									While enumerator16.MoveNext()
										Dim obj3 As Object = enumerator16.Current
										Dim dataRow7 As DataRow = CType(obj3, DataRow)
										IL_13C3:
										num2 = 253
										If Not dataRow7.IsNull(text12) Then
											IL_13D4:
											num2 = 254
											dataRow7(text12 + "vp") = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow7(text12))) / num17, Me.Decimals + 2)
										End If
										IL_1415:
										num2 = 255
									End While
									IL_1424:
									num2 = 256
									If TypeOf enumerator16 Is IDisposable Then
										TryCast(enumerator16, IDisposable).Dispose()
									End If
								End If
							Else
								IL_1447:
								num2 = 258
								Dim right As String = OoOo0O.OO_o.0o_O.(8)
								IL_1455:
								num2 = 259
								Dim num19 As Integer = fxDataSource.Rows.Count - 1
								For num20 As Integer = 0 To num19
									IL_1473:
									num2 = 260
									Dim dataRow8 As DataRow = fxDataSource.Rows(num20)
									IL_1489:
									num2 = 261
									Dim num17 As Double
									If Operators.CompareString(dataRow8(text3).ToString(), right, True) <> 0 Then
										IL_14AA:
										num2 = 262
										right = dataRow8(text3).ToString()
										IL_14C0:
										num2 = 263
										If totalOn3.upto Then
											IL_14D2:
											num2 = 264
											Dim num21 As Integer = num20
											Dim num22 As Integer = fxDataSource.Rows.Count - 1
											For num23 As Integer = num21 To num22
												IL_14EE:
												num2 = 265
												Dim dataRow9 As DataRow = fxDataSource.Rows(num23)
												IL_1504:
												num2 = 266
												If Operators.CompareString(dataRow9(text3).ToString(), right, True) <> 0 Then
													Exit For
												End If
												IL_1525:
												num2 = 267
												If Not dataRow9.IsNull(text12) Then
													IL_1536:
													num2 = 268
													num17 = Convert.ToDouble(Conversions.ToDecimal(dataRow9(text12)))
												End If
												IL_1551:
												num2 = 271
											Next
										Else
											IL_1568:
											num2 = 273
											num17 = 0.0
											IL_1579:
											num2 = 274
											Dim num24 As Integer = num20
											Dim num25 As Integer = fxDataSource.Rows.Count - 1
											For num26 As Integer = num24 To num25
												IL_1595:
												num2 = 275
												Dim dataRow10 As DataRow = fxDataSource.Rows(num26)
												IL_15AB:
												num2 = 276
												If Operators.CompareString(dataRow10(text3).ToString(), right, True) <> 0 Then
													Exit For
												End If
												IL_15C9:
												num2 = 277
												If Not dataRow10.IsNull(text12) Then
													IL_15DA:
													num2 = 278
													num17 += Convert.ToDouble(Conversions.ToDecimal(dataRow10(text12)))
												End If
												IL_15F8:
												num2 = 281
											Next
										End If
									End If
									IL_160A:
									num2 = 282
									If Not dataRow8.IsNull(text12) Then
										IL_161B:
										num2 = 283
										dataRow8(text12 + "vp") = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow8(text12))) / num17, Me.Decimals + 2)
									End If
									IL_165C:
									num2 = 284
								Next
							End If
							IL_1671:
							num2 = 285
						End While
						IL_1683:
						num2 = 286
						CType(enumerator14, IDisposable).Dispose()
					End If
					IL_1696:
					num2 = 287
				End While
				IL_16A8:
				num2 = 288
				If enumerator11 IsNot Nothing Then
					enumerator11.Dispose()
				End If
				IL_16B9:
				num2 = 289
				If Not Me.SamePeriodGrowth Then
					GoTo IL_1FAE
				End If
				IL_16CA:
				num2 = 290
				Dim text13 As String = ""
				IL_16D7:
				num2 = 291
				Dim left As String = ""
				IL_16E4:
				num2 = 292
				Dim enumerator17 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator17.MoveNext()
					Dim groupOn4 As GroupOn = enumerator17.Current
					IL_1702:
					num2 = 293
					If Not groupOn4.Vertical Then
						IL_1711:
						num2 = 295
						If groupOn4.IsDate Then
							IL_1720:
							num2 = 296
							If Operators.CompareString(text13, "", True) = 0 Then
								IL_1735:
								num2 = 297
								text13 = groupOn4.NewName
							Else
								IL_1746:
								num2 = 299
								If Operators.CompareString(left, "", True) = 0 Then
									IL_175B:
									num2 = 300
									left = groupOn4.NewName
									Exit While
								End If
							End If
						End If
					End If
					IL_176C:
					num2 = 302
				End While
				IL_177E:
				num2 = 303
				If enumerator17 IsNot Nothing Then
					enumerator17.Dispose()
				End If
				IL_178F:
				num2 = 304
				If Operators.CompareString(left, "", True) <> 0 Then
					GoTo IL_18BB
				End If
				IL_17A7:
				num2 = 305
				Dim enumerator18 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator18.MoveNext()
					Dim groupOn5 As GroupOn = enumerator18.Current
					IL_17C8:
					num2 = 306
					If Not groupOn5.Vertical Then
						IL_17DA:
						num2 = 308
						If fxDataSource.Columns(groupOn5.NewName).DataType Is GetType(Integer) OrElse fxDataSource.Columns(groupOn5.NewName).DataType Is GetType(Long) OrElse fxDataSource.Columns(groupOn5.NewName).DataType Is GetType(Short) Then
							IL_184C:
							num2 = 309
							If Operators.CompareString(text13, "", True) = 0 Then
								IL_1861:
								num2 = 310
								text13 = groupOn5.NewName
							Else
								IL_1872:
								num2 = 312
								If Operators.CompareString(left, "", True) = 0 Then
									IL_1887:
									num2 = 313
									left = groupOn5.NewName
									Exit While
								End If
							End If
						End If
					End If
					IL_1898:
					num2 = 315
				End While
				IL_18AA:
				num2 = 316
				If enumerator18 IsNot Nothing Then
					enumerator18.Dispose()
				End If
				IL_18BB:
				num2 = 317
				If Operators.CompareString(left, "", True) <= 0 Then
					GoTo IL_1FAE
				End If
				IL_18D4:
				num2 = 318
				Dim list6 As List(Of String) = New List(Of String)()
				IL_18E1:
				num2 = 319
				Dim text14 As String = ""
				IL_18EE:
				num2 = 320
				Dim enumerator19 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator19.MoveNext()
					Dim groupOn6 As GroupOn = enumerator19.Current
					IL_190F:
					num2 = 321
					If Operators.CompareString(text13, groupOn6.NewName, True) <> 0 Then
						IL_1929:
						num2 = 323
						If Not groupOn6.Vertical Then
							IL_193B:
							num2 = 325
							list6.Add(groupOn6.NewName)
							IL_194F:
							num2 = 326
							If Operators.CompareString(text14, "", True) > 0 Then
								IL_1965:
								num2 = 327
								text14 += " And "
							End If
							IL_1979:
							num2 = 328
							text14 = text14 + "[" + groupOn6.NewName + "] = "
							IL_1999:
							num2 = 329
							If fxDataSource.Columns(groupOn6.NewName).DataType Is GetType(String) Then
								IL_19C3:
								num2 = 330
								text14 = text14 + "'{" + groupOn6.NewName + "}'"
							Else
								IL_19E5:
								num2 = 332
								If fxDataSource.Columns(groupOn6.NewName).DataType Is GetType(DateTime) Then
									IL_1A0F:
									num2 = 333
									text14 = text14 + "#{" + groupOn6.NewName + "}#"
								Else
									IL_1A31:
									num2 = 335
									text14 = text14 + "{" + groupOn6.NewName + "}"
								End If
							End If
						End If
					End If
					IL_1A51:
					num2 = 336
				End While
				IL_1A63:
				num2 = 337
				If enumerator19 IsNot Nothing Then
					enumerator19.Dispose()
				End If
				IL_1A74:
				num2 = 338
				Dim enumerator20 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator20.MoveNext()
					Dim totalOn4 As TotalOn = enumerator20.Current
					IL_1A95:
					num2 = 339
					Dim list7 As List(Of String) = New List(Of String)()
					IL_1AA2:
					num2 = 340
					If A_0.Columns.Contains(totalOn4.NewName) Then
						IL_1ABF:
						num2 = 341
						Dim enumerator21 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator21.MoveNext()
							Dim obj4 As Object = enumerator21.Current
							Dim dataColumn2 As DataColumn = CType(obj4, DataColumn)
							IL_1AE3:
							num2 = 342
							If dataColumn2.ColumnName.StartsWith(totalOn4.NewName + "_") AndAlso Versioned.IsNumeric(dataColumn2.ColumnName.Substring(totalOn4.NewName.Length + 1)) Then
								IL_1B29:
								num2 = 343
								list7.Add(dataColumn2.ColumnName)
							End If
							IL_1B3D:
							num2 = 344
						End While
						IL_1B4C:
						num2 = 345
						If TypeOf enumerator21 Is IDisposable Then
							TryCast(enumerator21, IDisposable).Dispose()
						End If
					End If
					IL_1B67:
					num2 = 346
					Dim enumerator22 As List(Of String).Enumerator = list7.GetEnumerator()
					While enumerator22.MoveNext()
						Dim text15 As String = enumerator22.Current
						IL_1B84:
						num2 = 347
						Dim text16 As String = text15 + "stp"
						IL_1B98:
						num2 = 348
						fxDataSource.Columns.Add(text16, GetType(Double))
						IL_1BB7:
						num2 = 349
						fxDataSource.Columns(text16).SetOrdinal(fxDataSource.Columns(text15).Ordinal + 1)
						IL_1BE5:
						num2 = 350
						Dim text17 As String = fxDataSource.Columns(text15).Caption
						IL_1C00:
						num2 = 351
						Dim num27 As Integer = text17.Length - text17.Replace("_", "").Length
						IL_1C26:
						num2 = 352
						If num27 > Me.VGroups.Count + Me.Totals.Count - 2 Then
							IL_1C49:
							num2 = 353
							text17 = text17.Substring(0, text17.LastIndexOf("_") + 1)
							IL_1C67:
							num2 = 354
							fxDataSource.Columns(text16).Caption = text17 + "同比"
						Else
							IL_1C8E:
							num2 = 356
							fxDataSource.Columns(text16).Caption = text17 + "同比"
						End If
						IL_1CB3:
						num2 = 357
						fxDataSource.Columns(text16).ExtendedProperties.Add("displayformat", "#0.00%")
						IL_1CDB:
						num2 = 358
						Me.O.oOO_0..Add(text16)
						IL_1CEE:
						num2 = 359
						Me.Oo_0O0o.ooO..Add(text15)
						IL_1D01:
						num2 = 360
						Me.O_O_ooo.OOOOoo..Add(text16)
						IL_1D14:
						num2 = 361
					End While
					IL_1D26:
					num2 = 362
					CType(enumerator22, IDisposable).Dispose()
					IL_1D39:
					num2 = 363
					Dim enumerator23 As List(Of String).Enumerator = list7.GetEnumerator()
					While enumerator23.MoveNext()
						Dim text18 As String = enumerator23.Current
						IL_1D56:
						num2 = 364
						Dim enumerator24 As IEnumerator = fxDataSource.Rows.GetEnumerator()
						While enumerator24.MoveNext()
							Dim obj5 As Object = enumerator24.Current
							Dim dataRow11 As DataRow = CType(obj5, DataRow)
							IL_1D7D:
							num2 = 365
							Dim text19 As String = text14
							IL_1D87:
							num2 = 366
							Dim enumerator25 As List(Of String).Enumerator = list6.GetEnumerator()
							While enumerator25.MoveNext()
								Dim text20 As String = enumerator25.Current
								IL_1DA1:
								num2 = 367
								text19 = text19.Replace("{" + text20 + "}", dataRow11(text20).ToString())
								IL_1DCF:
								num2 = 368
							End While
							IL_1DDE:
							num2 = 369
							CType(enumerator25, IDisposable).Dispose()
							IL_1DF1:
							num2 = 370
							If Not dataRow11.IsNull(text13) Then
								IL_1E05:
								num2 = 371
								Dim num28 As Integer = Conversions.ToInteger(dataRow11(text13))
								IL_1E1B:
								num2 = 374
								text19 = String.Concat(New String() { text19, " And [", text13, "] = ", Conversions.ToString(num28 - 1) })
								IL_1E54:
								num2 = 375
								Dim array4 As DataRow() = fxDataSource.[Select](text19)
								IL_1E65:
								num2 = 376
								If array4.Length >= 1 Then
									IL_1E75:
									num2 = 377
									Dim dataRow12 As DataRow = array4(0)
									IL_1E81:
									num2 = 378
									Dim num29 As Double
									If Not dataRow12.IsNull(text18) Then
										IL_1E92:
										num2 = 379
										num29 = Conversions.ToDouble(dataRow12(text18))
									Else
										IL_1EAA:
										num2 = 381
										num29 = 0.0
									End If
									IL_1EBB:
									num2 = 382
									Dim num30 As Double
									If Not dataRow11.IsNull(text18) Then
										IL_1ECC:
										num2 = 383
										num30 = Conversions.ToDouble(dataRow11(text18))
									Else
										IL_1EE4:
										num2 = 385
										num30 = 0.0
									End If
									IL_1EF5:
									num2 = 386
									If num29 > 0.0 Then
										IL_1F08:
										num2 = 387
										dataRow11(text18 + "stp") = Math.Round((num30 - num29) / num29, Me.Decimals)
									End If
								End If
							End If
							IL_1F39:
							num2 = 388
						End While
						IL_1F4B:
						num2 = 389
						If TypeOf enumerator24 Is IDisposable Then
							TryCast(enumerator24, IDisposable).Dispose()
						End If
						IL_1F66:
						num2 = 390
					End While
					IL_1F78:
					num2 = 391
					CType(enumerator23, IDisposable).Dispose()
					IL_1F8B:
					num2 = 392
				End While
				IL_1F9D:
				num2 = 393
				If enumerator20 IsNot Nothing Then
					enumerator20.Dispose()
				End If
				IL_1FAE:
				num2 = 394
				If Not Me.CircleGrowth Then
					GoTo IL_28C6
				End If
				IL_1FBF:
				num2 = 395
				Dim list8 As List(Of String) = New List(Of String)()
				IL_1FCC:
				num2 = 396
				Dim text21 As String = ""
				IL_1FD9:
				num2 = 397
				Dim text22 As String = ""
				IL_1FE6:
				num2 = 398
				Dim enumerator26 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator26.MoveNext()
					Dim groupOn7 As GroupOn = enumerator26.Current
					IL_2007:
					num2 = 399
					If Not groupOn7.Vertical Then
						IL_2019:
						num2 = 401
						If groupOn7.IsDate Then
							IL_2028:
							num2 = 402
							If Operators.CompareString(text21, "", True) > 0 Then
								IL_203E:
								num2 = 403
								text21 += ","
							End If
							IL_2052:
							num2 = 404
							text21 += groupOn7.NewName
						Else
							IL_206A:
							num2 = 406
							If Operators.CompareString(text22, "", True) > 0 Then
								IL_2080:
								num2 = 407
								text22 += ","
							End If
							IL_2094:
							num2 = 408
							text22 += groupOn7.NewName
							IL_20AA:
							num2 = 409
							list8.Add(groupOn7.NewName)
						End If
					End If
					IL_20BE:
					num2 = 410
				End While
				IL_20D0:
				num2 = 411
				If enumerator26 IsNot Nothing Then
					enumerator26.Dispose()
				End If
				IL_20E1:
				num2 = 412
				If Operators.CompareString(text21, "", True) <> 0 Then
					GoTo IL_2271
				End If
				IL_20F9:
				num2 = 413
				list8.Clear()
				IL_2106:
				num2 = 414
				text22 = ""
				IL_2113:
				num2 = 415
				Dim enumerator27 As IEnumerator(Of GroupOn) = A_1.Groups.GetEnumerator()
				While enumerator27.MoveNext()
					Dim groupOn8 As GroupOn = enumerator27.Current
					IL_2134:
					num2 = 416
					If Not groupOn8.Vertical Then
						IL_2146:
						num2 = 418
						If fxDataSource.Columns(groupOn8.NewName).DataType Is GetType(Integer) OrElse fxDataSource.Columns(groupOn8.NewName).DataType Is GetType(Long) OrElse fxDataSource.Columns(groupOn8.NewName).DataType Is GetType(Short) Then
							IL_21B8:
							num2 = 419
							If Operators.CompareString(text21, "", True) > 0 Then
								IL_21CE:
								num2 = 420
								text21 += ","
							End If
							IL_21E2:
							num2 = 421
							text21 += groupOn8.NewName
						Else
							IL_21FA:
							num2 = 423
							If Operators.CompareString(text22, "", True) > 0 Then
								IL_2210:
								num2 = 424
								text22 += ","
							End If
							IL_2224:
							num2 = 425
							text22 += groupOn8.NewName
							IL_223A:
							num2 = 426
							list8.Add(groupOn8.NewName)
						End If
					End If
					IL_224E:
					num2 = 427
				End While
				IL_2260:
				num2 = 428
				If enumerator27 IsNot Nothing Then
					enumerator27.Dispose()
				End If
				IL_2271:
				num2 = 429
				If Operators.CompareString(text21, "", True) <= 0 Then
					GoTo IL_28C6
				End If
				IL_228A:
				num2 = 430
				Dim enumerator28 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator28.MoveNext()
					Dim totalOn5 As TotalOn = enumerator28.Current
					IL_22AB:
					num2 = 431
					Dim list9 As List(Of String) = New List(Of String)()
					IL_22B8:
					num2 = 432
					If A_0.Columns.Contains(totalOn5.NewName) Then
						IL_22D5:
						num2 = 433
						Dim enumerator29 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator29.MoveNext()
							Dim obj6 As Object = enumerator29.Current
							Dim dataColumn3 As DataColumn = CType(obj6, DataColumn)
							IL_22F9:
							num2 = 434
							If dataColumn3.ColumnName.StartsWith(totalOn5.NewName + "_") AndAlso Versioned.IsNumeric(dataColumn3.ColumnName.Substring(totalOn5.NewName.Length + 1)) Then
								IL_233F:
								num2 = 435
								list9.Add(dataColumn3.ColumnName)
							End If
							IL_2353:
							num2 = 436
						End While
						IL_2362:
						num2 = 437
						If TypeOf enumerator29 Is IDisposable Then
							TryCast(enumerator29, IDisposable).Dispose()
						End If
					End If
					IL_237D:
					num2 = 438
					Dim enumerator30 As List(Of String).Enumerator = list9.GetEnumerator()
					While enumerator30.MoveNext()
						Dim text23 As String = enumerator30.Current
						IL_239A:
						num2 = 439
						Dim text24 As String = text23 + "cle"
						IL_23AE:
						num2 = 440
						fxDataSource.Columns.Add(text24, GetType(Double))
						IL_23CD:
						num2 = 441
						fxDataSource.Columns(text24).SetOrdinal(fxDataSource.Columns(text23).Ordinal + 1)
						IL_23FB:
						num2 = 442
						Dim text25 As String = fxDataSource.Columns(text23).Caption
						IL_2416:
						num2 = 443
						Dim num31 As Integer = text25.Length - text25.Replace("_", "").Length
						IL_243C:
						num2 = 444
						If num31 > Me.VGroups.Count + Me.Totals.Count - 2 Then
							IL_245F:
							num2 = 445
							text25 = text25.Substring(0, text25.LastIndexOf("_") + 1)
							IL_247D:
							num2 = 446
							fxDataSource.Columns(text24).Caption = text25 + "环比"
						Else
							IL_24A4:
							num2 = 448
							fxDataSource.Columns(text24).Caption = text25 + "环比"
						End If
						IL_24C9:
						num2 = 449
						fxDataSource.Columns(text24).ExtendedProperties.Add("displayformat", "#0.00%")
						IL_24F1:
						num2 = 450
						Me.O.oOO_0..Add(text24)
						IL_2504:
						num2 = 451
						Me.Oo_0O0o.ooO..Add(text23)
						IL_2517:
						num2 = 452
						Me.O_O_ooo.OOOOoo..Add(text24)
						IL_252A:
						num2 = 453
					End While
					IL_253C:
					num2 = 454
					CType(enumerator30, IDisposable).Dispose()
					IL_254F:
					num2 = 455
					Dim enumerator31 As List(Of String).Enumerator = list9.GetEnumerator()
					While enumerator31.MoveNext()
						Dim text26 As String = enumerator31.Current
						IL_256C:
						num2 = 456
						Dim text27 As String = text26 + "cle"
						IL_2580:
						num2 = 457
						If list8.Count = 0 Then
							IL_2592:
							num2 = 458
							Dim num32 As Integer = fxDataSource.Rows.Count - 1
							For num33 As Integer = 1 To num32
								IL_25B0:
								num2 = 459
								Dim num34 As Double
								If Not fxDataSource.Rows(num33 - 1).IsNull(text26) Then
									IL_25CF:
									num2 = 460
									num34 = Conversions.ToDouble(fxDataSource.Rows(num33 - 1)(text26))
								Else
									IL_25F5:
									num2 = 462
									num34 = 0.0
								End If
								IL_2606:
								num2 = 463
								Dim num35 As Double
								If Not fxDataSource.Rows(num33).IsNull(text26) Then
									IL_2623:
									num2 = 464
									num35 = Conversions.ToDouble(fxDataSource.Rows(num33)(text26))
								Else
									IL_2647:
									num2 = 466
									num35 = 0.0
								End If
								IL_2658:
								num2 = 467
								If num34 <> 0.0 Then
									IL_266B:
									num2 = 468
									fxDataSource.Rows(num33)(text27) = Math.Round((num35 - num34) / num34, Me.Decimals)
								End If
								IL_269E:
								num2 = 469
							Next
						Else
							IL_26B8:
							num2 = 471
							Dim dataView As DataView = New DataView(fxDataSource, "", text22 + "," + text21, DataViewRowState.CurrentRows)
							IL_26DC:
							num2 = 472
							Dim num36 As Integer = dataView.Count - 1
							For num37 As Integer = 1 To num36
								IL_26F5:
								num2 = 473
								Dim flag3 As Boolean = True
								IL_26FE:
								num2 = 474
								Dim enumerator32 As List(Of String).Enumerator = list8.GetEnumerator()
								While enumerator32.MoveNext()
									Dim [property] As String = enumerator32.Current
									IL_2718:
									num2 = 475
									If Operators.CompareString(dataView(num37)([property]).ToString(), dataView(num37 - 1)([property]).ToString(), True) <> 0 Then
										IL_2752:
										num2 = 476
										flag3 = False
									End If
									IL_275B:
									num2 = 477
								End While
								IL_276A:
								num2 = 478
								CType(enumerator32, IDisposable).Dispose()
								IL_277D:
								num2 = 479
								If flag3 Then
									IL_278A:
									num2 = 480
									Dim num38 As Double
									If Not dataView(num37 - 1).Row.IsNull(text26) Then
										IL_27A9:
										num2 = 481
										num38 = Conversions.ToDouble(dataView(num37 - 1)(text26))
									Else
										IL_27CA:
										num2 = 483
										num38 = 0.0
									End If
									IL_27DB:
									num2 = 484
									Dim num39 As Double
									If Not dataView(num37).Row.IsNull(text26) Then
										IL_27F8:
										num2 = 485
										num39 = Conversions.ToDouble(dataView(num37)(text26))
									Else
										IL_2817:
										num2 = 487
										num39 = 0.0
									End If
									IL_2828:
									num2 = 488
									If num38 <> 0.0 Then
										IL_283B:
										num2 = 489
										dataView(num37)(text27) = Math.Round((num39 - num38) / num38, Me.Decimals)
									End If
								End If
								IL_2869:
								num2 = 490
							Next
						End If
						IL_287E:
						num2 = 491
					End While
					IL_2890:
					num2 = 492
					CType(enumerator31, IDisposable).Dispose()
					IL_28A3:
					num2 = 493
				End While
				IL_28B5:
				num2 = 494
				If enumerator28 IsNot Nothing Then
					enumerator28.Dispose()
				End If
				IL_28C6:
				num2 = 495
				If Not Me.HorizontalProportion Then
					GoTo IL_2D0F
				End If
				IL_28D7:
				num2 = 496
				Dim enumerator33 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator33.MoveNext()
					Dim totalOn6 As TotalOn = enumerator33.Current
					IL_28F8:
					num2 = 497
					If A_0.Columns.Contains(totalOn6.NewName) Then
						IL_2915:
						num2 = 498
						Dim list10 As List(Of String) = New List(Of String)()
						IL_2922:
						num2 = 499
						Dim enumerator34 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator34.MoveNext()
							Dim obj7 As Object = enumerator34.Current
							Dim dataColumn4 As DataColumn = CType(obj7, DataColumn)
							IL_2946:
							num2 = 500
							If dataColumn4.ColumnName.StartsWith(totalOn6.NewName + "_") AndAlso Versioned.IsNumeric(dataColumn4.ColumnName.Substring(totalOn6.NewName.Length + 1)) Then
								IL_298C:
								num2 = 501
								list10.Add(dataColumn4.ColumnName)
							End If
							IL_29A0:
							num2 = 502
						End While
						IL_29AF:
						num2 = 503
						If TypeOf enumerator34 Is IDisposable Then
							TryCast(enumerator34, IDisposable).Dispose()
						End If
						IL_29CA:
						num2 = 504
						Dim enumerator35 As List(Of String).Enumerator = list10.GetEnumerator()
						While enumerator35.MoveNext()
							Dim text28 As String = enumerator35.Current
							IL_29E7:
							num2 = 505
							Dim text29 As String = text28 + "hp"
							IL_29FB:
							num2 = 506
							fxDataSource.Columns.Add(text29, GetType(Double))
							IL_2A1A:
							num2 = 507
							fxDataSource.Columns(text29).SetOrdinal(fxDataSource.Columns(text28).Ordinal + 1)
							IL_2A48:
							num2 = 508
							Dim text30 As String = fxDataSource.Columns(text28).Caption
							IL_2A63:
							num2 = 509
							Dim num40 As Integer = text30.Length - text30.Replace("_", "").Length
							IL_2A89:
							num2 = 510
							If num40 > Me.VGroups.Count + Me.Totals.Count - 2 Then
								IL_2AAC:
								num2 = 511
								text30 = text30.Substring(0, text30.LastIndexOf("_") + 1)
								IL_2ACA:
								num2 = 512
								fxDataSource.Columns(text29).Caption = text30 + Me.HorizontalProportionCaption
							Else
								IL_2AF2:
								num2 = 514
								fxDataSource.Columns(text29).Caption = text30 + Me.HorizontalProportionCaption
							End If
							IL_2B18:
							num2 = 515
							fxDataSource.Columns(text29).ExtendedProperties.Add("displayformat", "#0.00%")
							IL_2B40:
							num2 = 516
							Me.O.oOO_0..Add(text29)
							IL_2B53:
							num2 = 517
						End While
						IL_2B65:
						num2 = 518
						CType(enumerator35, IDisposable).Dispose()
						IL_2B78:
						num2 = 519
						Dim enumerator36 As IEnumerator = fxDataSource.Rows.GetEnumerator()
						While enumerator36.MoveNext()
							Dim obj8 As Object = enumerator36.Current
							Dim dataRow13 As DataRow = CType(obj8, DataRow)
							IL_2B9F:
							num2 = 520
							Dim num41 As Double = 0.0
							IL_2BB0:
							num2 = 521
							Dim enumerator37 As List(Of String).Enumerator = list10.GetEnumerator()
							While enumerator37.MoveNext()
								Dim columnName4 As String = enumerator37.Current
								IL_2BCA:
								num2 = 522
								If Not dataRow13.IsNull(columnName4) Then
									IL_2BDB:
									num2 = 523
									num41 += Convert.ToDouble(Conversions.ToDecimal(dataRow13(columnName4)))
								End If
								IL_2BF9:
								num2 = 524
							End While
							IL_2C08:
							num2 = 525
							CType(enumerator37, IDisposable).Dispose()
							IL_2C1B:
							num2 = 526
							If num41 <> 0.0 Then
								IL_2C31:
								num2 = 527
								Dim enumerator38 As List(Of String).Enumerator = list10.GetEnumerator()
								While enumerator38.MoveNext()
									Dim text31 As String = enumerator38.Current
									IL_2C4B:
									num2 = 528
									If Not dataRow13.IsNull(text31) Then
										IL_2C5C:
										num2 = 529
										dataRow13(text31 + "hp") = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow13(text31))) / num41, Me.Decimals + 2)
									End If
									IL_2C9D:
									num2 = 530
								End While
								IL_2CAC:
								num2 = 531
								CType(enumerator38, IDisposable).Dispose()
							End If
							IL_2CBF:
							num2 = 532
						End While
						IL_2CD1:
						num2 = 533
						If TypeOf enumerator36 Is IDisposable Then
							TryCast(enumerator36, IDisposable).Dispose()
						End If
					End If
					IL_2CEC:
					num2 = 534
				End While
				IL_2CFE:
				num2 = 535
				If enumerator33 IsNot Nothing Then
					enumerator33.Dispose()
				End If
				IL_2D0F:
				num2 = 536
				If Not Me.VerticalTotal OrElse Me.Subtotal Then
					GoTo IL_3281
				End If
				IL_2D2B:
				num2 = 537
				Dim dataRow14 As DataRow = fxDataSource.NewRow()
				IL_2D3A:
				num2 = 538
				Dim enumerator39 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator39.MoveNext()
					Dim totalOn7 As TotalOn = enumerator39.Current
					IL_2D5B:
					num2 = 539
					If A_0.Columns.Contains(totalOn7.NewName) Then
						IL_2D78:
						num2 = 540
						Dim list11 As List(Of String) = New List(Of String)()
						IL_2D85:
						num2 = 541
						Dim enumerator40 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator40.MoveNext()
							Dim obj9 As Object = enumerator40.Current
							Dim dataColumn5 As DataColumn = CType(obj9, DataColumn)
							IL_2DA9:
							num2 = 542
							If dataColumn5.ColumnName.StartsWith(totalOn7.Name + "_") AndAlso Versioned.IsNumeric(dataColumn5.ColumnName.Substring(totalOn7.Name.Length + 1)) Then
								IL_2DEF:
								num2 = 543
								list11.Add(dataColumn5.ColumnName)
							End If
							IL_2E03:
							num2 = 544
						End While
						IL_2E12:
						num2 = 545
						If TypeOf enumerator40 Is IDisposable Then
							TryCast(enumerator40, IDisposable).Dispose()
						End If
						IL_2E2D:
						num2 = 546
						Dim enumerator41 As List(Of String).Enumerator = list11.GetEnumerator()
						While enumerator41.MoveNext()
							Dim text32 As String = enumerator41.Current
							IL_2E4A:
							num2 = 547
							Dim num42 As Double = 0.0
							IL_2E5B:
							num2 = 548
							Dim enumerator42 As IEnumerator = fxDataSource.Rows.GetEnumerator()
							While enumerator42.MoveNext()
								Dim obj10 As Object = enumerator42.Current
								Dim dataRow15 As DataRow = CType(obj10, DataRow)
								IL_2E7F:
								num2 = 549
								If Not dataRow15.IsNull(text32) Then
									IL_2E90:
									num2 = 550
									num42 += Convert.ToDouble(Conversions.ToDecimal(dataRow15(text32)))
								End If
								IL_2EAE:
								num2 = 551
							End While
							IL_2EBD:
							num2 = 552
							If TypeOf enumerator42 Is IDisposable Then
								TryCast(enumerator42, IDisposable).Dispose()
							End If
							IL_2ED8:
							num2 = 553
							dataRow14(text32) = Math.Round(num42, Me.Decimals)
							IL_2EF9:
							num2 = 554
							If fxDataSource.Columns.Contains(text32 + "vp") AndAlso list.Count = 1 Then
								IL_2F23:
								num2 = 555
								dataRow14(text32 + "vp") = 1
							End If
							IL_2F42:
							num2 = 556
						End While
						IL_2F54:
						num2 = 557
						CType(enumerator41, IDisposable).Dispose()
					End If
					IL_2F67:
					num2 = 558
				End While
				IL_2F79:
				num2 = 559
				If enumerator39 IsNot Nothing Then
					enumerator39.Dispose()
				End If
				IL_2F8A:
				num2 = 560
				fxDataSource.Rows.Add(dataRow14)
				IL_2F9E:
				num2 = 561
				If Not Me.HorizontalProportion Then
					GoTo IL_320A
				End If
				IL_2FAF:
				num2 = 562
				Dim enumerator43 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator43.MoveNext()
					Dim totalOn8 As TotalOn = enumerator43.Current
					IL_2FD0:
					num2 = 563
					If A_0.Columns.Contains(totalOn8.NewName) Then
						IL_2FED:
						num2 = 564
						Dim list12 As List(Of String) = New List(Of String)()
						IL_2FFA:
						num2 = 565
						Dim enumerator44 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator44.MoveNext()
							Dim obj11 As Object = enumerator44.Current
							Dim dataColumn6 As DataColumn = CType(obj11, DataColumn)
							IL_301E:
							num2 = 566
							If dataColumn6.ColumnName.StartsWith(totalOn8.NewName + "_") AndAlso Versioned.IsNumeric(dataColumn6.ColumnName.Substring(totalOn8.NewName.Length + 1)) Then
								IL_3064:
								num2 = 567
								list12.Add(dataColumn6.ColumnName)
							End If
							IL_3078:
							num2 = 568
						End While
						IL_3087:
						num2 = 569
						If TypeOf enumerator44 Is IDisposable Then
							TryCast(enumerator44, IDisposable).Dispose()
						End If
						IL_30A2:
						num2 = 570
						Dim num43 As Double = 0.0
						IL_30B3:
						num2 = 571
						Dim enumerator45 As List(Of String).Enumerator = list12.GetEnumerator()
						While enumerator45.MoveNext()
							Dim columnName5 As String = enumerator45.Current
							IL_30CD:
							num2 = 572
							If Not dataRow14.IsNull(columnName5) Then
								IL_30DE:
								num2 = 573
								num43 += Convert.ToDouble(Conversions.ToDecimal(dataRow14(columnName5)))
							End If
							IL_30FC:
							num2 = 574
						End While
						IL_310B:
						num2 = 575
						CType(enumerator45, IDisposable).Dispose()
						IL_311E:
						num2 = 576
						If num43 <> 0.0 Then
							IL_3134:
							num2 = 577
							Dim enumerator46 As List(Of String).Enumerator = list12.GetEnumerator()
							While enumerator46.MoveNext()
								Dim text33 As String = enumerator46.Current
								IL_3151:
								num2 = 578
								If Not dataRow14.IsNull(text33) Then
									IL_3162:
									num2 = 579
									dataRow14(text33 + "hp") = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow14(text33))) / num43, Me.Decimals)
								Else
									IL_31A3:
									num2 = 581
									dataRow14(text33 + "hp") = 0
								End If
								IL_31C2:
								num2 = 582
							End While
							IL_31D4:
							num2 = 583
							CType(enumerator46, IDisposable).Dispose()
						End If
					End If
					IL_31E7:
					num2 = 584
				End While
				IL_31F9:
				num2 = 585
				If enumerator43 IsNot Nothing Then
					enumerator43.Dispose()
				End If
				IL_320A:
				num2 = 586
				Dim enumerator47 As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator47.MoveNext()
					Dim text34 As String = enumerator47.Current
					IL_3224:
					num2 = 587
					If fxDataSource.Columns(text34).DataType Is GetType(String) Then
						IL_3249:
						num2 = 588
						dataRow14(text34) = "合计"
						Exit While
					End If
					IL_325F:
					num2 = 590
				End While
				IL_326E:
				num2 = 591
				CType(enumerator47, IDisposable).Dispose()
				IL_3281:
				num2 = 592
				Me.o_o.__. = ""
				IL_3292:
				num2 = 593
				If Not Me.HorizontalTotal Then
					GoTo IL_37D3
				End If
				IL_32A3:
				num2 = 594
				Dim enumerator48 As IEnumerator(Of TotalOn) = A_1.Totals.GetEnumerator()
				While enumerator48.MoveNext()
					Dim totalOn9 As TotalOn = enumerator48.Current
					IL_32C4:
					num2 = 595
					Dim text35 As String = totalOn9.Name
					IL_32D3:
					num2 = 596
					If totalOn9.upto Then
						IL_32E2:
						num2 = 597
						text35 += "_up"
					End If
					IL_32F6:
					num2 = 598
					If Not A_0.Columns.Contains(text35) Then
						IL_330B:
						num2 = 599
						If text35.StartsWith("{") AndAlso text35.IndexOf("}.") > 0 Then
							IL_332E:
							num2 = 600
							text35 = text35.Substring(text35.IndexOf("}.") + 2)
						End If
					End If
					IL_334B:
					num2 = 601
					If A_0.Columns.Contains(text35) Then
						IL_3363:
						num2 = 602
						Dim list13 As List(Of String) = New List(Of String)()
						IL_3370:
						num2 = 603
						Dim text36 As String = ""
						IL_337D:
						num2 = 604
						Dim num44 As Double = 0.0
						IL_338E:
						num2 = 605
						Dim text37 As String
						If A_1.Totals.Count = 1 Then
							IL_33A2:
							num2 = 606
							If Not Me.VerticalProportion Then
								IL_33B0:
								num2 = 607
								text37 = "合计"
							Else
								IL_33C2:
								num2 = 609
								text37 = "合计_" + totalOn9.NewCaption
								IL_33DB:
								num2 = 610
								text36 = "合计_" + Me.VerticalProportionCaption
							End If
						Else
							IL_33F5:
							num2 = 612
							If Not Me.VerticalProportion Then
								IL_3403:
								num2 = 613
								text37 = "合计_" + totalOn9.NewCaption
							Else
								IL_341E:
								num2 = 615
								text37 = totalOn9.NewCaption + "_合计"
								IL_3437:
								num2 = 616
								text36 = totalOn9.NewCaption + "_" + Me.VerticalProportionCaption
							End If
						End If
						IL_3456:
						num2 = 617
						fxDataSource.Columns.Add(text37, GetType(Double))
						IL_3475:
						num2 = 618
						Me.o_o.__. = Me.o_o.__. + "," + text37
						IL_3493:
						num2 = 619
						If Me.VerticalProportion Then
							IL_34A1:
							num2 = 620
							fxDataSource.Columns.Add(text36, GetType(Double))
							IL_34C0:
							num2 = 621
							Me.o_o.__. = Me.o_o.__. + "," + text36
							IL_34DE:
							num2 = 622
							fxDataSource.Columns(text36).ExtendedProperties.Add("displayformat", "#0.00%")
							IL_3506:
							num2 = 623
							Me.O.oOO_0..Add(text36)
						End If
						IL_3519:
						num2 = 624
						Dim enumerator49 As IEnumerator = fxDataSource.Columns.GetEnumerator()
						While enumerator49.MoveNext()
							Dim obj12 As Object = enumerator49.Current
							Dim dataColumn7 As DataColumn = CType(obj12, DataColumn)
							IL_353D:
							num2 = 625
							If dataColumn7.ColumnName.StartsWith(text35 + "_") AndAlso Versioned.IsNumeric(dataColumn7.ColumnName.Substring(text35.Length + 1)) Then
								IL_3579:
								num2 = 626
								list13.Add(dataColumn7.ColumnName)
							End If
							IL_358D:
							num2 = 627
						End While
						IL_359C:
						num2 = 628
						If TypeOf enumerator49 Is IDisposable Then
							TryCast(enumerator49, IDisposable).Dispose()
						End If
						IL_35B7:
						num2 = 629
						Dim enumerator50 As IEnumerator = fxDataSource.Rows.GetEnumerator()
						While enumerator50.MoveNext()
							Dim obj13 As Object = enumerator50.Current
							Dim dataRow16 As DataRow = CType(obj13, DataRow)
							IL_35DE:
							num2 = 630
							Dim num45 As Double = 0.0
							IL_35EF:
							num2 = 631
							Dim enumerator51 As List(Of String).Enumerator = list13.GetEnumerator()
							While enumerator51.MoveNext()
								Dim columnName6 As String = enumerator51.Current
								IL_3609:
								num2 = 632
								If Not dataRow16.IsNull(columnName6) Then
									IL_361A:
									num2 = 633
									num45 += Convert.ToDouble(Conversions.ToDecimal(dataRow16(columnName6)))
								End If
								IL_3638:
								num2 = 634
							End While
							IL_3647:
							num2 = 635
							CType(enumerator51, IDisposable).Dispose()
							IL_365A:
							num2 = 636
							dataRow16(text37) = Math.Round(num45, Me.Decimals)
							IL_367B:
							num2 = 637
							If Me.VerticalProportion Then
								IL_3689:
								num2 = 638
								dataRow16(text36) = num45
								IL_369F:
								num2 = 639
								num44 += num45
							End If
							IL_36AC:
							num2 = 640
						End While
						IL_36BE:
						num2 = 641
						If TypeOf enumerator50 Is IDisposable Then
							TryCast(enumerator50, IDisposable).Dispose()
						End If
						IL_36D9:
						num2 = 642
						If Me.VerticalTotal Then
							IL_36E7:
							num2 = 643
							num44 /= 2.0
						End If
						IL_36FB:
						num2 = 644
						If Me.VerticalProportion AndAlso num44 <> 0.0 Then
							IL_371C:
							num2 = 645
							Dim enumerator52 As IEnumerator = fxDataSource.Rows.GetEnumerator()
							While enumerator52.MoveNext()
								Dim obj14 As Object = enumerator52.Current
								Dim dataRow17 As DataRow = CType(obj14, DataRow)
								IL_3740:
								num2 = 646
								If Not dataRow17.IsNull(text36) Then
									IL_3751:
									num2 = 647
									dataRow17(text36) = Math.Round(Convert.ToDouble(Conversions.ToDecimal(dataRow17(text36))) / num44, Me.Decimals)
								End If
								IL_3786:
								num2 = 648
							End While
							IL_3795:
							num2 = 649
							If TypeOf enumerator52 Is IDisposable Then
								TryCast(enumerator52, IDisposable).Dispose()
							End If
						End If
					End If
					IL_37B0:
					num2 = 650
				End While
				IL_37C2:
				num2 = 651
				If enumerator48 IsNot Nothing Then
					enumerator48.Dispose()
				End If
				IL_37D3:
				num2 = 652
				Me.o_o.__. = Me.o_o.__..Trim(New Char() { ","c })
				IL_37F5:
				num2 = 653
				fxDataSource.AcceptChanges()
				IL_3802:
				num2 = 654
				fxDataSource.TableName = Me.TableName
				IL_3815:
				num2 = 655
				result = fxDataSource
				IL_381E:
				GoTo IL_42B0
				IL_3823:
				Dim num46 As Integer = num47 + 1
				num47 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num46)
				IL_4271:
				GoTo IL_42A5
				IL_4273:
				num47 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4283:
			Catch obj16 When endfilter(TypeOf obj15 Is Exception And num <> 0 And num47 = 0)
				Dim ex As Exception = CType(obj16, Exception)
				GoTo IL_4273
			End Try
			IL_42A5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_42B0:
			If num47 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x170006E4 RID: 1764
		' (get) Token: 0x06001EBC RID: 7868 RVA: 0x000C8274 File Offset: 0x000C6474
		' (set) Token: 0x06001EBD RID: 7869 RVA: 0x000C827C File Offset: 0x000C647C
		Public Property CommandTimeOut As Integer
			Get
				Return Me.O0OO.00OOO_O.
			End Get
			Set(value As Integer)
				Me.O0OO.00OOO_O. = value
			End Set
		End Property

		' Token: 0x04000CBE RID: 3262
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CBF RID: 3263
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CC0 RID: 3264
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CC1 RID: 3265
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CC2 RID: 3266
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CC3 RID: 3267
		Private <<EMPTY_NAME>> As GroupCollection

		' Token: 0x04000CC4 RID: 3268
		Private <<EMPTY_NAME>> As CrossGroupCollection

		' Token: 0x04000CC5 RID: 3269
		Private <<EMPTY_NAME>> As CrossTotalCollection

		' Token: 0x04000CC6 RID: 3270
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000CC7 RID: 3271
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CC8 RID: 3272
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CC9 RID: 3273
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CCA RID: 3274
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CCB RID: 3275
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CCC RID: 3276
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CCD RID: 3277
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CCE RID: 3278
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CCF RID: 3279
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CD0 RID: 3280
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CD1 RID: 3281
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CD2 RID: 3282
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000CD3 RID: 3283
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000CD4 RID: 3284
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000CD5 RID: 3285
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000CD6 RID: 3286
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CD7 RID: 3287
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CD8 RID: 3288
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000CD9 RID: 3289
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CDA RID: 3290
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CDB RID: 3291
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CDC RID: 3292
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CDD RID: 3293
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CDE RID: 3294
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CDF RID: 3295
		Private <<EMPTY_NAME>> As HttpClient
	End Class
End Namespace
