Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000A5 RID: 165
	<ComVisible(True)>
	<oO0oooo("3365")>
	Public Class InlineMRPBuilder
		' Token: 0x170001AE RID: 430
		' (get) Token: 0x06000677 RID: 1655 RVA: 0x0002208C File Offset: 0x0002028C
		' (set) Token: 0x06000678 RID: 1656 RVA: 0x00022094 File Offset: 0x00020294
		Public Property BOM As BomTable

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x06000679 RID: 1657 RVA: 0x0002209D File Offset: 0x0002029D
		' (set) Token: 0x0600067A RID: 1658 RVA: 0x000220A5 File Offset: 0x000202A5
		Public Property Yield As YieldTable

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x0600067B RID: 1659 RVA: 0x000220AE File Offset: 0x000202AE
		' (set) Token: 0x0600067C RID: 1660 RVA: 0x000220B6 File Offset: 0x000202B6
		Public Property Stock As StockTable

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x0600067D RID: 1661 RVA: 0x000220BF File Offset: 0x000202BF
		' (set) Token: 0x0600067E RID: 1662 RVA: 0x000220C7 File Offset: 0x000202C7
		<oO0oooo("3731")>
		Public Property Purchase As PriceTable

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x0600067F RID: 1663 RVA: 0x000220D0 File Offset: 0x000202D0
		' (set) Token: 0x06000680 RID: 1664 RVA: 0x000220D8 File Offset: 0x000202D8
		<oO0oooo("3732")>
		Public Property Subcontract As PriceTable

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x06000681 RID: 1665 RVA: 0x000220E1 File Offset: 0x000202E1
		' (set) Token: 0x06000682 RID: 1666 RVA: 0x000220E9 File Offset: 0x000202E9
		Public Property Plan As mrpPlan

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x06000683 RID: 1667 RVA: 0x000220F2 File Offset: 0x000202F2
		<oO0oooo("3396")>
		Public ReadOnly Property Extensions As MRPExtendTables

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x06000684 RID: 1668 RVA: 0x000220FA File Offset: 0x000202FA
		<oO0oooo("3698")>
		Public ReadOnly Property Additions As MRPExtendTables

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x06000685 RID: 1669 RVA: 0x00022102 File Offset: 0x00020302
		' (set) Token: 0x06000686 RID: 1670 RVA: 0x0002210A File Offset: 0x0002030A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property QuantityType As Type

		' Token: 0x06000687 RID: 1671 RVA: 0x00022114 File Offset: 0x00020314
		Public Sub New(A_0 As String)
			Me.BOM = New BomTable()
			Me.Yield = New YieldTable()
			Me.Stock = New StockTable()
			Me.Purchase = New PriceTable()
			Me.Subcontract = New PriceTable()
			Me.Plan = New mrpPlan()
			Me.Extensions = New MRPExtendTables()
			Me.Additions = New MRPExtendTables()
			Me.QuantityType = GetType(Long)
			Me.o0oO._o_. = New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
			Me.o0oO._o_. = A_0
		End Sub

		' Token: 0x06000688 RID: 1672 RVA: 0x000221A8 File Offset: 0x000203A8
		Public Sub New()
			Me.BOM = New BomTable()
			Me.Yield = New YieldTable()
			Me.Stock = New StockTable()
			Me.Purchase = New PriceTable()
			Me.Subcontract = New PriceTable()
			Me.Plan = New mrpPlan()
			Me.Extensions = New MRPExtendTables()
			Me.Additions = New MRPExtendTables()
			Me.QuantityType = GetType(Long)
			Me.o0oO._o_. = New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
		End Sub

		' Token: 0x06000689 RID: 1673 RVA: 0x00022233 File Offset: 0x00020433
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

		' Token: 0x0600068A RID: 1674 RVA: 0x00022257 File Offset: 0x00020457
		Public Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x0600068B RID: 1675 RVA: 0x00022260 File Offset: 0x00020460
		Public Function Build(OnlyDataTable As Boolean) As DataTable
			Dim num As Integer
			Dim result As DataTable
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.o0oO._o_., "", True) <> 0 Then
					GoTo IL_2E
				End If
				IL_1C:
				num2 = 3
				Me.o0oO._o_. = Oo00.oo0o.O0O_0__.("MRP统计")
				IL_2E:
				num2 = 4
				If Operators.CompareString(Me.BOM.MaterialCol, Me.BOM.ParentCol, True) <> 0 Then
					GoTo IL_6C
				End If
				IL_4E:
				num2 = 5
				MessageBox.Show("父列和子列不能相同!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_63:
				num2 = 6
				result = Nothing
				GoTo IL_25B
				IL_6C:
				num2 = 7
				If Not OO_00oOO.DataTables.Contains(Me.o0oO._o_.) OrElse OnlyDataTable Then
					GoTo IL_F4
				End If
				IL_83:
				num2 = 8
				If Not OO_00oOO.DataTables(Me.o0oO._o_.).AddByCode Then
					GoTo IL_AF
				End If
				IL_9C:
				num2 = 9
				OO_00oOO.DataTables.Delete(Me.o0oO._o_.)
				IL_AF:
				num2 = 10
				If Not OO_00oOO.DataTables.Contains(Me.o0oO._o_.) Then
					GoTo IL_F4
				End If
				IL_C4:
				num2 = 11
				MessageBox.Show("表" + Me.o0oO._o_. + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_EA:
				num2 = 12
				result = Nothing
				GoTo IL_25B
				IL_F4:
				num2 = 13
				Dim dataTable As DataTable = Me.BuildDataSource()
				IL_FF:
				num2 = 14
				dataTable.TableName = Me.o0oO._o_.
				IL_10F:
				num2 = 15
				If Not OnlyDataTable Then
					GoTo IL_142
				End If
				IL_115:
				num2 = 16
				Dim dataTable2 As DataTable = New DataTable(dataTable, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
				IL_12D:
				num2 = 17
				dataTable2.o.0O000_.()
				IL_137:
				num2 = 18
				result = dataTable2
				GoTo IL_25B
				IL_142:
				num2 = 19
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
				IL_156:
				num2 = 20
				OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, Me.o0oO._o_., O_O0OO.OoO.0OO__0ooo.()))
				IL_177:
				num2 = 21
				OO_00oOO.DataTables(Me.o0oO._o_.).o.0O000_.()
				IL_18F:
				num2 = 22
				OO_00oOO.DataTables(Me.o0oO._o_.).AddByCode = True
				IL_1A8:
				num2 = 23
				OO_00oOO.DataTables(Me.o0oO._o_.).Caption = Me.Oo0oO0oOO_.0_o.
				IL_1C6:
				num2 = 24
				New O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables(Me.o0oO._o_.).BaseTable)
				IL_1E9:
				num2 = 25
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.o0oO._o_.))
				IL_206:
				num2 = 26
				Main.OO_O.o..o0_o_o_0.0O.(Me.o0oO._o_., True, False)
				IL_21B:
				num2 = 27
				OO_00oOO.Tables(Me.o0oO._o_.).Sort = OO_00oOO.MRP.MaterialCol
				IL_23D:
				num2 = 28
				dataTable.AcceptChanges()
				IL_247:
				num2 = 29
				result = OO_00oOO.DataTables(Me.o0oO._o_.)
				IL_25B:
				GoTo IL_325
				IL_260:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2E6:
				GoTo IL_31A
				IL_2E8:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2F8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2E8
			End Try
			IL_31A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_325:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600068C RID: 1676 RVA: 0x000225B8 File Offset: 0x000207B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x0600068D RID: 1677 RVA: 0x000225D2 File Offset: 0x000207D2
		Public Function BuildDataSource() As fxDataSource
			Return Me.OO_Oo.0oO.()
		End Function

		' Token: 0x0600068E RID: 1678 RVA: 0x000225DC File Offset: 0x000207DC
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num17 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o0oO._o_..Clear()
				IL_14:
				num2 = 3
				Dim dataView As DataView = New DataView(Me.BOM.DataTable.BaseTable, "", Me.BOM.MaterialCol, DataViewRowState.CurrentRows)
				IL_3F:
				num2 = 4
				Dim enumerator As IEnumerator(Of String) = Me.Plan.Keys.GetEnumerator()
				Dim flag As Boolean
				While enumerator.MoveNext()
					Dim key As String = enumerator.Current
					IL_5E:
					num2 = 5
					If dataView.Find(key) >= 0 Then
						IL_6C:
						num2 = 6
						flag = True
						Exit While
					End If
					IL_73:
					num2 = 8
				End While
				IL_7E:
				num2 = 9
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_8C:
				num2 = 10
				Dim dataType As Type = Me.BOM.DataTable.DataCols(Me.BOM.QuantityCol).DataType
				IL_B6:
				num2 = 11
				If dataType IsNot GetType(Single) AndAlso dataType IsNot GetType(Double) AndAlso dataType IsNot GetType(Decimal) Then
					GoTo IL_F6
				End If
				IL_E3:
				num2 = 12
				Me.QuantityType = GetType(Double)
				IL_F6:
				num2 = 13
				Dim fxDataSource As fxDataSource = New fxDataSource()
				IL_100:
				num2 = 14
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaterialCol, GetType(String))
				IL_124:
				num2 = 15
				fxDataSource.Columns(OO_00oOO.MRP.MaterialCol).MaxLength = Me.BOM.DataTable.BaseTable.Columns(Me.BOM.MaterialCol).MaxLength
				IL_16C:
				num2 = 16
				Dim enumerator2 As IEnumerator(Of o00_0__O) = Me.Additions.GetEnumerator()
				While enumerator2.MoveNext()
					Dim o00_0__O As o00_0__O = enumerator2.Current
					IL_18A:
					num2 = 17
					o00_0__O.oo__.0O00.(True)
					IL_195:
					num2 = 18
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).DataType)
					IL_1CE:
					num2 = 19
					fxDataSource.Columns(o00_0__O.o0o.OooOOo0__.()).MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).MaxLength
					IL_20B:
					num2 = 20
				End While
				IL_21A:
				num2 = 21
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_228:
				num2 = 22
				If Me.Additions.Count <= 0 Then
					GoTo IL_27C
				End If
				IL_239:
				num2 = 23
				If Operators.CompareString(OO_00oOO.MRP.MaterialCol, "物料", True) <> 0 Then
					GoTo IL_27C
				End If
				IL_253:
				num2 = 24
				fxDataSource.Columns(OO_00oOO.MRP.MaterialCol).Caption = Me.BOM.MaterialCol
				IL_27C:
				num2 = 25
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_2E8
				End If
				IL_28C:
				num2 = 26
				fxDataSource.Columns.Add(OO_00oOO.MRP.StockCol, Me.QuantityType)
				IL_2AC:
				num2 = 27
				If Operators.CompareString(Me.Stock.MinimumCol, "", True) <= 0 Then
					GoTo IL_2E8
				End If
				IL_2C8:
				num2 = 28
				fxDataSource.Columns.Add(OO_00oOO.MRP.MinimumCol, Me.QuantityType)
				IL_2E8:
				num2 = 29
				fxDataSource.Columns.Add(OO_00oOO.MRP.QuantityCol, Me.QuantityType)
				IL_308:
				num2 = 30
				If Not flag Then
					GoTo IL_3AD
				End If
				IL_312:
				num2 = 31
				fxDataSource.Columns.Add(OO_00oOO.MRP.AssembleCol, Me.QuantityType)
				IL_332:
				num2 = 32
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaintenanceCol, Me.QuantityType)
				IL_352:
				num2 = 33
				fxDataSource.Columns(OO_00oOO.MRP.AssembleCol).Expression = String.Concat(New String() { "[", OO_00oOO.MRP.QuantityCol, "] - IsNull([", OO_00oOO.MRP.MaintenanceCol, "],0)" })
				IL_3AD:
				num2 = 34
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_3DD
				End If
				IL_3BD:
				num2 = 35
				fxDataSource.Columns.Add(OO_00oOO.MRP.FromStockCol, Me.QuantityType)
				IL_3DD:
				num2 = 36
				Dim enumerator3 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
				While enumerator3.MoveNext()
					Dim o00_0__O2 As o00_0__O = enumerator3.Current
					IL_3F8:
					num2 = 37
					fxDataSource.Columns.Add(o00_0__O2.o0o.OooOOo0__.(), Me.QuantityType)
					IL_415:
					num2 = 38
				End While
				IL_421:
				num2 = 39
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_42F:
				num2 = 40
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCol, Me.QuantityType)
				IL_44F:
				num2 = 41
				If Me.Purchase.DataTable Is Nothing Then
					GoTo IL_4E7
				End If
				IL_462:
				num2 = 42
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchasePriceCol, GetType(Double))
				IL_486:
				num2 = 43
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCostCol, GetType(Double), String.Concat(New String() { "[", OO_00oOO.MRP.PurchasePriceCol, "] * [", OO_00oOO.MRP.PurchaseCol, "]" }))
				IL_4E7:
				num2 = 44
				fxDataSource.Columns.Add(OO_00oOO.MRP.ProductionCol, Me.QuantityType)
				IL_507:
				num2 = 45
				If Me.Subcontract.DataTable Is Nothing Then
					GoTo IL_59F
				End If
				IL_51A:
				num2 = 46
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCPriceCol, GetType(Double))
				IL_53E:
				num2 = 47
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCCostCol, GetType(Double), String.Concat(New String() { "[", OO_00oOO.MRP.ProductionCol, "] * [", OO_00oOO.MRP.SCPriceCol, "]" }))
				IL_59F:
				num2 = 48
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_60B
				End If
				IL_5AF:
				num2 = 49
				If Operators.CompareString(Me.Stock.MinimumCol, "", True) <= 0 Then
					GoTo IL_5EB
				End If
				IL_5CB:
				num2 = 50
				fxDataSource.Columns.Add(OO_00oOO.MRP.ReplenishCol, Me.QuantityType)
				IL_5EB:
				num2 = 51
				fxDataSource.Columns.Add(OO_00oOO.MRP.RemainingCol, Me.QuantityType)
				IL_60B:
				num2 = 52
				fxDataSource.PrimaryKey = New DataColumn() { fxDataSource.Columns(OO_00oOO.MRP.MaterialCol) }
				IL_634:
				num2 = 53
				Dim dataView2 As DataView = New DataView(Me.BOM.DataTable.BaseTable, "", Me.BOM.ParentCol, DataViewRowState.CurrentRows)
				IL_660:
				num2 = 54
				Dim dataView3 As DataView = Nothing
				IL_666:
				num2 = 55
				Dim dataView4 As DataView = Nothing
				IL_66C:
				num2 = 56
				Dim dataView5 As DataView = Nothing
				IL_672:
				num2 = 57
				Dim dataView6 As DataView = Nothing
				IL_678:
				num2 = 58
				If Me.Yield.DataTable Is Nothing OrElse Me.Yield.MaterialCol Is Nothing OrElse Me.Yield.YieldCol Is Nothing Then
					GoTo IL_6CE
				End If
				IL_6A2:
				num2 = 59
				dataView3 = New DataView(Me.Yield.DataTable.BaseTable, "", Me.Yield.MaterialCol, DataViewRowState.CurrentRows)
				IL_6CE:
				num2 = 60
				If Me.Stock.DataTable Is Nothing OrElse Me.Stock.MaterialCol Is Nothing OrElse Me.Stock.QuantityCol Is Nothing Then
					GoTo IL_724
				End If
				IL_6F8:
				num2 = 61
				dataView4 = New DataView(Me.Stock.DataTable.BaseTable, "", Me.Stock.MaterialCol, DataViewRowState.CurrentRows)
				IL_724:
				num2 = 62
				If Me.Purchase.DataTable Is Nothing OrElse Operators.CompareString(Me.Purchase.MaterialCol, "", True) <= 0 OrElse Operators.CompareString(Me.Purchase.PriceCol, "", True) <= 0 Then
					GoTo IL_792
				End If
				IL_766:
				num2 = 63
				dataView5 = New DataView(Me.Purchase.DataTable.BaseTable, "", Me.Purchase.MaterialCol, DataViewRowState.CurrentRows)
				IL_792:
				num2 = 64
				If Me.Subcontract.DataTable Is Nothing OrElse Operators.CompareString(Me.Subcontract.MaterialCol, "", True) <= 0 OrElse Operators.CompareString(Me.Subcontract.PriceCol, "", True) <= 0 Then
					GoTo IL_800
				End If
				IL_7D4:
				num2 = 65
				dataView6 = New DataView(Me.Subcontract.DataTable.BaseTable, "", Me.Subcontract.MaterialCol, DataViewRowState.CurrentRows)
				IL_800:
				num2 = 66
				Dim enumerator4 As IEnumerator(Of String) = Me.Plan.Keys.GetEnumerator()
				While enumerator4.MoveNext()
					Dim text As String = enumerator4.Current
					IL_820:
					num2 = 67
					Dim a_ As Double = Me.OO_Oo.0oO.(dataView3, text, Me.Plan(text))
					IL_83C:
					num2 = 68
					Me.OO_Oo.0oO.(fxDataSource, dataView2, dataView, dataView3, text, a_, True)
					IL_853:
					num2 = 69
				End While
				IL_85F:
				num2 = 70
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_86D:
				num2 = 71
				Dim enumerator5 As IEnumerator = fxDataSource.Rows.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj As Object = enumerator5.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_891:
					num2 = 72
					Dim text2 As String = dataRow(OO_00oOO.MRP.MaterialCol).ToString()
					IL_8AC:
					num2 = 73
					If dataView2.Find(text2) >= 0 Then
						IL_8BE:
						num2 = 74
						Dim num3 As Integer = -1
						IL_8C4:
						num2 = 75
						If dataView4 IsNot Nothing Then
							IL_8CB:
							num2 = 76
							num3 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow(OO_00oOO.MRP.MaterialCol)))
						End If
						IL_8ED:
						num2 = 77
						If num3 > -1 Then
							IL_8F8:
							num2 = 78
							Dim num4 As Double = 0.0
							IL_906:
							num2 = 79
							Dim num5 As Double = 0.0
							IL_914:
							num2 = 80
							Dim num6 As Double = Conversions.ToDouble(dataRow(OO_00oOO.MRP.QuantityCol))
							IL_92F:
							num2 = 81
							If Not dataView4(num3).Row.IsNull(Me.Stock.QuantityCol) Then
								IL_955:
								num2 = 82
								num5 = Conversions.ToDouble(dataView4(num3)(Me.Stock.QuantityCol))
								IL_978:
								num2 = 83
								If Operators.CompareString(Me.Stock.MinimumCol, "", True) > 0 AndAlso Not dataView4(num3).Row.IsNull(Me.Stock.MinimumCol) Then
									IL_9B4:
									num2 = 84
									num4 = Math.Max(0.0, Conversions.ToDouble(dataView4(num3)(Me.Stock.MinimumCol)))
								End If
							End If
							IL_9E5:
							num2 = 85
							Dim enumerator6 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
							While enumerator6.MoveNext()
								Dim o00_0__O3 As o00_0__O = enumerator6.Current
								IL_A00:
								num2 = 86
								If Not dataRow.IsNull(o00_0__O3.o0o.OooOOo0__.()) Then
									IL_A13:
									num2 = 87
									num5 += Conversions.ToDouble(dataRow(o00_0__O3.o0o.OooOOo0__.()))
								End If
								IL_A2E:
								num2 = 88
							End While
							IL_A3A:
							num2 = 89
							If enumerator6 IsNot Nothing Then
								enumerator6.Dispose()
							End If
							IL_A48:
							num2 = 90
							Dim num7 As Double
							If num4 > num5 Then
								IL_A51:
								num2 = 91
								num7 = num5 - num4
							Else
								IL_A5D:
								num2 = 93
								If num5 > num4 Then
									IL_A66:
									num2 = 94
									num7 = num5 - num4
									IL_A70:
									num2 = 95
									If num7 > num6 Then
										IL_A79:
										num2 = 96
										num7 = num6
									End If
								End If
							End If
							IL_A80:
							num2 = 97
							Me.OO_Oo.0oO.(fxDataSource, dataView2, dataView, dataView3, text2, -num7, False)
						End If
					End If
					IL_A98:
					num2 = 98
				End While
				IL_AA7:
				num2 = 99
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_ABF:
				num2 = 100
				Dim enumerator7 As IEnumerator = fxDataSource.Rows.GetEnumerator()
				While enumerator7.MoveNext()
					Dim obj2 As Object = enumerator7.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_AE3:
					num2 = 101
					Dim num8 As Double = 0.0
					IL_AF1:
					num2 = 102
					Dim enumerator8 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
					While enumerator8.MoveNext()
						Dim o00_0__O4 As o00_0__O = enumerator8.Current
						IL_B0C:
						num2 = 103
						If Not dataRow2.IsNull(o00_0__O4.o0o.OooOOo0__.()) Then
							IL_B1F:
							num2 = 104
							num8 += Conversions.ToDouble(dataRow2(o00_0__O4.o0o.OooOOo0__.()))
						End If
						IL_B3A:
						num2 = 105
					End While
					IL_B46:
					num2 = 106
					If enumerator8 IsNot Nothing Then
						enumerator8.Dispose()
					End If
					IL_B54:
					num2 = 107
					Dim num9 As Integer = -1
					IL_B5A:
					num2 = 108
					If dataView4 IsNot Nothing Then
						IL_B61:
						num2 = 109
						num9 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
					End If
					IL_B83:
					num2 = 110
					Dim num10 As Double = Conversions.ToDouble(dataRow2(OO_00oOO.MRP.QuantityCol))
					IL_B9E:
					num2 = 111
					If num9 > -1 Then
						IL_BA9:
						num2 = 112
						Dim num11 As Double = 0.0
						IL_BB7:
						num2 = 113
						Dim num12 As Double = 0.0
						IL_BC5:
						num2 = 114
						If Not dataView4(num9).Row.IsNull(Me.Stock.QuantityCol) Then
							IL_BE8:
							num2 = 115
							num11 = Conversions.ToDouble(dataView4(num9)(Me.Stock.QuantityCol))
							IL_C0B:
							num2 = 116
							dataRow2(OO_00oOO.MRP.StockCol) = num11
						End If
						IL_C26:
						num2 = 117
						If Operators.CompareString(Me.Stock.MinimumCol, "", True) > 0 AndAlso Not dataView4(num9).Row.IsNull(Me.Stock.MinimumCol) Then
							IL_C62:
							num2 = 118
							num12 = Math.Max(0.0, Conversions.ToDouble(dataView4(num9)(Me.Stock.MinimumCol)))
							IL_C93:
							num2 = 119
							dataRow2(OO_00oOO.MRP.MinimumCol) = num12
						End If
						IL_CAE:
						num2 = 120
						If num11 >= num12 AndAlso num12 > 0.0 Then
							IL_CCA:
							num2 = 121
							Dim num13 As Double = Math.Min(num11 - num12, num10)
							IL_CDB:
							num2 = 122
							num10 -= num13
							IL_CE5:
							num2 = 123
							dataRow2(OO_00oOO.MRP.FromStockCol) = num13
							IL_D00:
							num2 = 124
							num10 = Math.Max(0.0, num10 - num8)
							IL_D18:
							num2 = 125
							If dataView2.Find(dataRow2(OO_00oOO.MRP.MaterialCol).ToString()) >= 0 Then
								IL_D3B:
								num2 = 126
								dataRow2(OO_00oOO.MRP.ProductionCol) = num10
							Else
								IL_D58:
								num2 = 128
								dataRow2(OO_00oOO.MRP.PurchaseCol) = num10
							End If
							IL_D76:
							num2 = 129
							dataRow2(OO_00oOO.MRP.RemainingCol) = num11 - num13
						Else
							IL_D9C:
							num2 = 131
							If num11 < num12 Then
								IL_DAB:
								num2 = 132
								Dim num14 As Double = num12 - num11
								IL_DB8:
								num2 = 133
								num10 += num14
								IL_DC5:
								num2 = 134
								dataRow2(OO_00oOO.MRP.ReplenishCol) = num14
								IL_DE3:
								num2 = 135
								dataRow2(OO_00oOO.MRP.FromStockCol) = 0
								IL_E00:
								num2 = 136
								num10 = Math.Max(0.0, num10 - num8)
								IL_E1B:
								num2 = 137
								If dataView2.Find(dataRow2(OO_00oOO.MRP.MaterialCol).ToString()) >= 0 Then
									IL_E41:
									num2 = 138
									dataRow2(OO_00oOO.MRP.ProductionCol) = num10
								Else
									IL_E61:
									num2 = 140
									dataRow2(OO_00oOO.MRP.PurchaseCol) = num10
								End If
								IL_E7F:
								num2 = 141
								dataRow2(OO_00oOO.MRP.RemainingCol) = num12
							Else
								IL_EA2:
								num2 = 143
								Dim num15 As Double
								If num11 > num10 Then
									IL_EAE:
									num2 = 144
									num15 = num10
									IL_EB8:
									num2 = 145
									dataRow2(OO_00oOO.MRP.RemainingCol) = num11 - num10
								Else
									IL_EDB:
									num2 = 147
									If num11 > 0.0 Then
										IL_EEE:
										num2 = 148
										num15 = num11
										IL_EF8:
										num2 = 149
										dataRow2(OO_00oOO.MRP.RemainingCol) = 0
									End If
								End If
								IL_F15:
								num2 = 150
								num10 -= num15
								IL_F22:
								num2 = 151
								dataRow2(OO_00oOO.MRP.FromStockCol) = num15
								IL_F40:
								num2 = 152
								num10 = Math.Max(0.0, num10 - num8)
								IL_F5B:
								num2 = 153
								If dataView2.Find(dataRow2(OO_00oOO.MRP.MaterialCol).ToString()) >= 0 Then
									IL_F81:
									num2 = 154
									dataRow2(OO_00oOO.MRP.ProductionCol) = num10
								Else
									IL_FA4:
									num2 = 156
									dataRow2(OO_00oOO.MRP.PurchaseCol) = num10
								End If
							End If
						End If
					Else
						IL_FC4:
						num2 = 158
						num10 = Math.Max(0.0, num10 - num8)
						IL_FDF:
						num2 = 159
						If dataView2.Find(dataRow2(OO_00oOO.MRP.MaterialCol).ToString()) >= 0 Then
							IL_1005:
							num2 = 160
							dataRow2(OO_00oOO.MRP.ProductionCol) = num10
						Else
							IL_1025:
							num2 = 162
							dataRow2(OO_00oOO.MRP.PurchaseCol) = num10
						End If
					End If
					IL_1043:
					num2 = 163
					If dataView5 IsNot Nothing Then
						IL_104D:
						num2 = 164
						num9 = dataView5.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
						IL_1072:
						num2 = 165
						If num9 >= 0 Then
							IL_107D:
							num2 = 166
							dataRow2(OO_00oOO.MRP.PurchasePriceCol) = RuntimeHelpers.GetObjectValue(dataView5(num9)(Me.Purchase.PriceCol))
						End If
					End If
					IL_10B2:
					num2 = 167
					If dataView6 IsNot Nothing Then
						IL_10BC:
						num2 = 168
						num9 = dataView6.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
						IL_10E1:
						num2 = 169
						If num9 >= 0 Then
							IL_10EC:
							num2 = 170
							dataRow2(OO_00oOO.MRP.SCPriceCol) = RuntimeHelpers.GetObjectValue(dataView6(num9)(Me.Subcontract.PriceCol))
						End If
					End If
					IL_1121:
					num2 = 171
				End While
				IL_1133:
				num2 = 172
				If TypeOf enumerator7 Is IDisposable Then
					TryCast(enumerator7, IDisposable).Dispose()
				End If
				IL_114E:
				num2 = 173
				result = fxDataSource
				IL_1157:
				GoTo IL_1461
				IL_115C:
				Dim num16 As Integer = num17 + 1
				num17 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num16)
				IL_1422:
				GoTo IL_1456
				IL_1424:
				num17 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1434:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num17 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_1424
			End Try
			IL_1456:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1461:
			If num17 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600068F RID: 1679 RVA: 0x00023A70 File Offset: 0x00021C70
		Private Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataView, A_2 As DataView, A_3 As DataView, A_4 As String, A_5 As Double, A_6 As Boolean) As Boolean
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not A_6 Then
					GoTo IL_119
				End If
				IL_10:
				num2 = 3
				If A_2.Find(A_4) < 0 Then
					GoTo IL_119
				End If
				IL_20:
				num2 = 4
				Dim dataRow As DataRow = A_0.Rows.Find(A_4)
				IL_31:
				num2 = 5
				If dataRow IsNot Nothing Then
					GoTo IL_82
				End If
				IL_37:
				num2 = 6
				dataRow = A_0.NewRow()
				IL_41:
				num2 = 7
				dataRow(OO_00oOO.MRP.MaterialCol) = A_4
				IL_56:
				num2 = 8
				dataRow(OO_00oOO.MRP.QuantityCol) = A_5
				IL_70:
				num2 = 9
				A_0.Rows.Add(dataRow)
				GoTo IL_B4
				IL_82:
				num2 = 11
				dataRow(OO_00oOO.MRP.QuantityCol) = Conversions.ToDouble(dataRow(OO_00oOO.MRP.QuantityCol)) + A_5
				IL_B4:
				num2 = 12
				If Not dataRow.IsNull(OO_00oOO.MRP.MaintenanceCol) Then
					GoTo IL_E7
				End If
				IL_CA:
				num2 = 13
				dataRow(OO_00oOO.MRP.MaintenanceCol) = A_5
				GoTo IL_119
				IL_E7:
				num2 = 15
				dataRow(OO_00oOO.MRP.MaintenanceCol) = Conversions.ToDouble(dataRow(OO_00oOO.MRP.MaintenanceCol)) + A_5
				IL_119:
				num2 = 16
				Dim array As DataRowView() = A_1.FindRows(A_4)
				IL_126:
				num2 = 17
				For Each dataRowView As DataRowView In array
					IL_13C:
					num2 = 18
					If Not dataRowView.Row.IsNull(Me.BOM.MaterialCol) AndAlso Not dataRowView.Row.IsNull(Me.BOM.QuantityCol) Then
						IL_177:
						num2 = 20
						Dim text As String = dataRowView(Me.BOM.MaterialCol).ToString()
						IL_193:
						num2 = 21
						If Operators.CompareString(text, A_4, True) <> 0 Then
							IL_1A5:
							num2 = 23
							Dim num3 As Double = Me.OO_Oo.0oO.(A_3, text, Conversions.ToDouble(dataRowView(Me.BOM.QuantityCol)) * A_5)
							IL_1CE:
							num2 = 24
							Dim dataRow2 As DataRow = A_0.Rows.Find(text)
							IL_1E0:
							num2 = 25
							If dataRow2 Is Nothing Then
								IL_1EA:
								num2 = 26
								dataRow2 = A_0.NewRow()
								IL_1F5:
								num2 = 27
								dataRow2(OO_00oOO.MRP.MaterialCol) = text
								IL_20B:
								num2 = 28
								dataRow2(OO_00oOO.MRP.QuantityCol) = num3
								IL_226:
								num2 = 29
								A_0.Rows.Add(dataRow2)
								IL_236:
								num2 = 30
								Dim array3 As MRPExtendTables() = New MRPExtendTables() { Me.Extensions, Me.Additions }
								IL_253:
								num2 = 31
								For Each mrpextendTables As MRPExtendTables In array3
									IL_269:
									num2 = 32
									Dim enumerator As IEnumerator(Of o00_0__O) = mrpextendTables.GetEnumerator()
									While enumerator.MoveNext()
										Dim o00_0__O As o00_0__O = enumerator.Current
										IL_283:
										num2 = 33
										Dim num4 As Integer = o00_0__O.oo__.0O00.().Find(text)
										IL_296:
										num2 = 34
										If num4 >= 0 Then
											IL_2A1:
											num2 = 35
											dataRow2(o00_0__O.o0o.OooOOo0__.()) = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()(num4)(o00_0__O.oooO00.o00O.()))
											IL_2D1:
											num2 = 36
											If array3 Is Me.Extensions AndAlso Not o00_0__O.oo__.0O00.()(num4).Row.IsNull(o00_0__O.oooO00.o00O.()) Then
												IL_305:
												num2 = 37
												If Me.o0oO._o_..ContainsKey(text) Then
													IL_317:
													num2 = 38
													Me.o0oO._o_.(text) = Me.o0oO._o_.(text) + Conversions.ToDouble(o00_0__O.oo__.0O00.()(num4).Row(o00_0__O.oooO00.o00O.()))
												Else
													IL_35B:
													num2 = 40
													Me.o0oO._o_.(text) = Conversions.ToDouble(o00_0__O.oo__.0O00.()(num4).Row(o00_0__O.oooO00.o00O.()))
												End If
											End If
										End If
										IL_38F:
										num2 = 41
									End While
									IL_39E:
									num2 = 42
									If enumerator IsNot Nothing Then
										enumerator.Dispose()
									End If
									IL_3AC:
									num2 = 43
								Next
							Else
								IL_3C2:
								num2 = 45
								dataRow2(OO_00oOO.MRP.QuantityCol) = Conversions.ToDouble(dataRow2(OO_00oOO.MRP.QuantityCol)) + num3
							End If
							IL_3F4:
							num2 = 46
							If Me.o0oO._o_..ContainsKey(text) Then
								IL_406:
								num2 = 47
								Dim num5 As Double = Me.o0oO._o_.(text)
								IL_418:
								num2 = 48
								If num5 >= num3 Then
									IL_421:
									num2 = 49
									Me.o0oO._o_.(text) = num5 - num3
									GoTo IL_47F
								End If
								IL_438:
								num2 = 52
								If num5 > 0.0 Then
									IL_448:
									num2 = 53
									Me.o0oO._o_.(text) = 0.0
									IL_461:
									num2 = 54
									num3 -= num5
								End If
							End If
							IL_46B:
							num2 = 55
							Me.OO_Oo.0oO.(A_0, A_1, A_2, A_3, text, num3, False)
						End If
					End If
					IL_47F:
					num2 = 56
				Next
				IL_493:
				GoTo IL_5C9
				IL_498:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_58A:
				GoTo IL_5BE
				IL_58C:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_59C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_58C
			End Try
			IL_5BE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5C9:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Dim result As Boolean
			Return result
		End Function

		' Token: 0x06000690 RID: 1680 RVA: 0x0002406C File Offset: 0x0002226C
		Private Function <<EMPTY_NAME>>(A_0 As DataView, A_1 As String, A_2 As Double) As Double
			If A_0 IsNot Nothing Then
				Dim num As Integer = A_0.Find(A_1)
				If num >= 0 AndAlso Not A_0(num).Row.IsNull(Me.Yield.YieldCol) AndAlso Conversions.ToDouble(A_0(num)(Me.Yield.YieldCol)) > 0.0 Then
					If Me.QuantityType Is GetType(Long) Then
						A_2 = CDbl(CLng(Math.Ceiling(A_2 / Conversions.ToDouble(A_0(num)(Me.Yield.YieldCol)))))
					Else
						A_2 /= Conversions.ToDouble(A_0(num)(Me.Yield.YieldCol))
					End If
				End If
			End If
			Return A_2
		End Function

		' Token: 0x040001B1 RID: 433
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As BomTable

		' Token: 0x040001B2 RID: 434
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As YieldTable

		' Token: 0x040001B3 RID: 435
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As StockTable

		' Token: 0x040001B4 RID: 436
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PriceTable

		' Token: 0x040001B5 RID: 437
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PriceTable

		' Token: 0x040001B6 RID: 438
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As mrpPlan

		' Token: 0x040001B7 RID: 439
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x040001B8 RID: 440
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x040001B9 RID: 441
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Type

		' Token: 0x040001BA RID: 442
		Private <<EMPTY_NAME>> As Dictionary(Of String, Double)

		' Token: 0x040001BB RID: 443
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040001BC RID: 444
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
