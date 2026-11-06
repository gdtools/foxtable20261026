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
	' Token: 0x020000A6 RID: 166
	<ComVisible(True)>
	<oO0oooo("3366")>
	Public Class LayersMRPBuilder
		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x06000691 RID: 1681 RVA: 0x00024132 File Offset: 0x00022332
		' (set) Token: 0x06000692 RID: 1682 RVA: 0x0002413A File Offset: 0x0002233A
		Public Property BOM As BomTable

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x06000693 RID: 1683 RVA: 0x00024143 File Offset: 0x00022343
		' (set) Token: 0x06000694 RID: 1684 RVA: 0x0002414B File Offset: 0x0002234B
		Public Property Yield As YieldTable

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x06000695 RID: 1685 RVA: 0x00024154 File Offset: 0x00022354
		' (set) Token: 0x06000696 RID: 1686 RVA: 0x0002415C File Offset: 0x0002235C
		Public Property Stock As StockTable

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x06000697 RID: 1687 RVA: 0x00024165 File Offset: 0x00022365
		' (set) Token: 0x06000698 RID: 1688 RVA: 0x0002416D File Offset: 0x0002236D
		<oO0oooo("3731")>
		Public Property Purchase As PriceTable

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x06000699 RID: 1689 RVA: 0x00024176 File Offset: 0x00022376
		' (set) Token: 0x0600069A RID: 1690 RVA: 0x0002417E File Offset: 0x0002237E
		<oO0oooo("3732")>
		Public Property Subcontract As PriceTable

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x0600069B RID: 1691 RVA: 0x00024187 File Offset: 0x00022387
		' (set) Token: 0x0600069C RID: 1692 RVA: 0x0002418F File Offset: 0x0002238F
		Public Property Plan As mrpPlan

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x0600069D RID: 1693 RVA: 0x00024198 File Offset: 0x00022398
		<oO0oooo("3396")>
		Public ReadOnly Property Extensions As MRPExtendTables

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x0600069E RID: 1694 RVA: 0x000241A0 File Offset: 0x000223A0
		<oO0oooo("3698")>
		Public ReadOnly Property Additions As MRPExtendTables

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x0600069F RID: 1695 RVA: 0x000241A8 File Offset: 0x000223A8
		' (set) Token: 0x060006A0 RID: 1696 RVA: 0x000241B0 File Offset: 0x000223B0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property QuantityType As Type

		' Token: 0x060006A1 RID: 1697 RVA: 0x000241BC File Offset: 0x000223BC
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
			Me.o00.o_O_o__. = New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
			Me.o00.o_O_o__. = OoOo0O.OO_o.0o_O.(10)
			Me.o00.o_O_o__. = New List(Of DataRow)()
			Me.oO.O_0_o000_0. = A_0
		End Sub

		' Token: 0x060006A2 RID: 1698 RVA: 0x00024268 File Offset: 0x00022468
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
			Me.o00.o_O_o__. = New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)
			Me.o00.o_O_o__. = OoOo0O.OO_o.0o_O.(10)
			Me.o00.o_O_o__. = New List(Of DataRow)()
		End Sub

		' Token: 0x060006A3 RID: 1699 RVA: 0x0002430B File Offset: 0x0002250B
		Public Function Build() As DataTable
			Return Me.Build(False)
		End Function

		' Token: 0x060006A4 RID: 1700 RVA: 0x00024314 File Offset: 0x00022514
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
				If Operators.CompareString(Me.oO.O_0_o000_0., "", True) <> 0 Then
					GoTo IL_2E
				End If
				IL_1C:
				num2 = 3
				Me.oO.O_0_o000_0. = Oo00.oo0o.O0O_0__.("MRP统计")
				IL_2E:
				num2 = 4
				If Not OO_00oOO.DataTables.Contains(Me.oO.O_0_o000_0.) OrElse OnlyDataTable Then
					GoTo IL_B3
				End If
				IL_45:
				num2 = 5
				If Not OO_00oOO.DataTables(Me.oO.O_0_o000_0.).AddByCode Then
					GoTo IL_70
				End If
				IL_5E:
				num2 = 6
				OO_00oOO.DataTables.Delete(Me.oO.O_0_o000_0.)
				IL_70:
				num2 = 7
				If Not OO_00oOO.DataTables.Contains(Me.oO.O_0_o000_0.) Then
					GoTo IL_B3
				End If
				IL_84:
				num2 = 8
				MessageBox.Show("表" + Me.oO.O_0_o000_0. + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_A9:
				num2 = 9
				result = Nothing
				GoTo IL_4AD
				IL_B3:
				num2 = 10
				OO_00oOO.SystemReady = False
				IL_BC:
				num2 = 11
				If Operators.CompareString(Me.BOM.MaterialCol, "", True) <> 0 OrElse Operators.CompareString(Conversions.ToString(Me.BOM.Separator2), "", True) <= 0 Then
					GoTo IL_25D
				End If
				IL_FB:
				num2 = 12
				Me.BOM.MaterialCol = Me.o00.o_O_o__.
				IL_10F:
				num2 = 13
				Me.BOM.DataTable.Save()
				IL_122:
				num2 = 14
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_13C:
					num2 = 15
					If table.DataTable.BaseTable Is Me.BOM.DataTable.BaseTable Then
						IL_15D:
						num2 = 16
						table.foxGrid.AutoGenerateColumns = False
					End If
					IL_16D:
					num2 = 17
				End While
				IL_179:
				num2 = 18
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_187:
				num2 = 19
				Me.BOM.DataTable.BaseTable.Columns.Add(Me.o00.o_O_o__., GetType(String))
				IL_1B5:
				num2 = 20
				For Each dataRow As DataRow In Me.BOM.DataTable.BaseTable.[Select]("", "", DataViewRowState.CurrentRows)
					IL_1E7:
					num2 = 21
					If Not dataRow.IsNull(Me.BOM.PathCol) Then
						IL_1FE:
						num2 = 23
						Dim array2 As String() = dataRow(Me.BOM.PathCol).ToString().Split(New Char() { Me.BOM.Separator2 })
						IL_233:
						num2 = 24
						dataRow(Me.o00.o_O_o__.) = array2(array2.Length - 1)
					End If
					IL_24C:
					num2 = 25
				Next
				IL_25D:
				num2 = 26
				Dim dataTable As DataTable = Me.BuildDataSource()
				IL_268:
				num2 = 27
				If Operators.CompareString(Me.BOM.MaterialCol, Me.o00.o_O_o__., True) <> 0 OrElse Operators.CompareString(Conversions.ToString(Me.BOM.Separator2), "", True) <= 0 Then
					GoTo IL_348
				End If
				IL_2A8:
				num2 = 28
				Me.BOM.DataTable.BaseTable.Columns.Remove(Me.o00.o_O_o__.)
				IL_2CB:
				num2 = 29
				Dim enumerator2 As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator2.MoveNext()
					Dim table2 As Table = enumerator2.Current
					IL_2E5:
					num2 = 30
					If table2.DataTable.BaseTable Is Me.BOM.DataTable.BaseTable Then
						IL_306:
						num2 = 31
						table2.foxGrid.AutoGenerateColumns = True
					End If
					IL_316:
					num2 = 32
				End While
				IL_322:
				num2 = 33
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_330:
				num2 = 34
				Me.BOM.DataTable.BaseTable.AcceptChanges()
				IL_348:
				num2 = 35
				OO_00oOO.SystemReady = True
				IL_351:
				num2 = 36
				dataTable.TableName = Me.oO.O_0_o000_0.
				IL_361:
				num2 = 37
				If Not OnlyDataTable Then
					GoTo IL_394
				End If
				IL_367:
				num2 = 38
				Dim dataTable2 As DataTable = New DataTable(dataTable, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
				IL_37F:
				num2 = 39
				dataTable2.o.0O000_.()
				IL_389:
				num2 = 40
				result = dataTable2
				GoTo IL_4AD
				IL_394:
				num2 = 41
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable)
				IL_3A8:
				num2 = 42
				OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, Me.oO.O_0_o000_0., O_O0OO.OoO.0OO__0ooo.()))
				IL_3C9:
				num2 = 43
				OO_00oOO.DataTables(Me.oO.O_0_o000_0.).o.0O000_.()
				IL_3E1:
				num2 = 44
				OO_00oOO.DataTables(Me.oO.O_0_o000_0.).AddByCode = True
				IL_3FA:
				num2 = 45
				OO_00oOO.DataTables(Me.oO.O_0_o000_0.).Caption = Me.o_oo_O0O.oO_.
				IL_418:
				num2 = 46
				New O_0(O_O0OO.o__.O.(), OO_00oOO.DataTables(Me.oO.O_0_o000_0.).BaseTable)
				IL_43B:
				num2 = 47
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.oO.O_0_o000_0.))
				IL_458:
				num2 = 48
				Main.OO_O.o..o0_o_o_0.0O.(Me.oO.O_0_o000_0., True, False)
				IL_46D:
				num2 = 49
				OO_00oOO.Tables(Me.oO.O_0_o000_0.).Sort = OO_00oOO.MRP.MaterialCol
				IL_48F:
				num2 = 50
				dataTable.AcceptChanges()
				IL_499:
				num2 = 51
				result = OO_00oOO.DataTables(Me.oO.O_0_o000_0.)
				IL_4AD:
				GoTo IL_5CF
				IL_4B2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_590:
				GoTo IL_5C4
				IL_592:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5A2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_592
			End Try
			IL_5C4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5CF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060006A5 RID: 1701 RVA: 0x00024918 File Offset: 0x00022B18
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildDataSource2() As fxDataSource2
			Dim a_ As fxDataSource = Me.BuildDataSource()
			Return New fxDataSource2(a_)
		End Function

		' Token: 0x060006A6 RID: 1702 RVA: 0x00024932 File Offset: 0x00022B32
		Public Function BuildDataSource() As fxDataSource
			Return Me.o_.__OOO0.()
		End Function

		' Token: 0x060006A7 RID: 1703 RVA: 0x0002493C File Offset: 0x00022B3C
		Private Function <<EMPTY_NAME>>() As fxDataSource
			Dim num As Integer
			Dim result As fxDataSource
			Dim num19 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o00.o_O_o__..Clear()
				IL_14:
				num2 = 3
				Dim dataType As Type = Me.BOM.DataTable.DataCols(Me.BOM.QuantityCol).DataType
				IL_3D:
				num2 = 4
				If dataType IsNot GetType(Single) AndAlso dataType IsNot GetType(Double) AndAlso dataType IsNot GetType(Decimal) Then
					GoTo IL_7B
				End If
				IL_69:
				num2 = 5
				Me.QuantityType = GetType(Double)
				IL_7B:
				num2 = 6
				Dim fxDataSource As fxDataSource = New fxDataSource()
				IL_84:
				num2 = 7
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaterialCol, GetType(String))
				IL_A7:
				num2 = 8
				fxDataSource.Columns(OO_00oOO.MRP.MaterialCol).MaxLength = Me.BOM.DataTable.BaseTable.Columns(Me.BOM.MaterialCol).MaxLength
				IL_EE:
				num2 = 9
				Dim enumerator As IEnumerator(Of o00_0__O) = Me.Additions.GetEnumerator()
				While enumerator.MoveNext()
					Dim o00_0__O As o00_0__O = enumerator.Current
					IL_10C:
					num2 = 10
					o00_0__O.oo__.0O00.(True)
					IL_117:
					num2 = 11
					fxDataSource.Columns.Add(o00_0__O.o0o.OooOOo0__.(), o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).DataType)
					IL_150:
					num2 = 12
					fxDataSource.Columns(o00_0__O.o0o.OooOOo0__.()).MaxLength = o00_0__O.oo__.0O00.().BaseTable.Columns(o00_0__O.oooO00.o00O.()).MaxLength
					IL_18D:
					num2 = 13
				End While
				IL_19C:
				num2 = 14
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_1AA:
				num2 = 15
				If Me.Additions.Count <= 0 Then
					GoTo IL_1FE
				End If
				IL_1BB:
				num2 = 16
				If Operators.CompareString(OO_00oOO.MRP.MaterialCol, "物料", True) <> 0 Then
					GoTo IL_1FE
				End If
				IL_1D5:
				num2 = 17
				fxDataSource.Columns(OO_00oOO.MRP.MaterialCol).Caption = Me.BOM.MaterialCol
				IL_1FE:
				num2 = 18
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_24E
				End If
				IL_20E:
				num2 = 19
				fxDataSource.Columns.Add(OO_00oOO.MRP.StockCol, Me.QuantityType)
				IL_22E:
				num2 = 20
				fxDataSource.Columns.Add(OO_00oOO.MRP.MinimumCol, Me.QuantityType)
				IL_24E:
				num2 = 21
				fxDataSource.Columns.Add(OO_00oOO.MRP.QuantityCol, Me.QuantityType)
				IL_26E:
				num2 = 22
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_29E
				End If
				IL_27E:
				num2 = 23
				fxDataSource.Columns.Add(OO_00oOO.MRP.FromStockCol, Me.QuantityType)
				IL_29E:
				num2 = 24
				Dim enumerator2 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
				While enumerator2.MoveNext()
					Dim o00_0__O2 As o00_0__O = enumerator2.Current
					IL_2B9:
					num2 = 25
					fxDataSource.Columns.Add(o00_0__O2.o0o.OooOOo0__.(), Me.QuantityType)
					IL_2D6:
					num2 = 26
				End While
				IL_2E2:
				num2 = 27
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_2F0:
				num2 = 28
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCol, Me.QuantityType)
				IL_310:
				num2 = 29
				If Me.Purchase.DataTable Is Nothing Then
					GoTo IL_3A8
				End If
				IL_323:
				num2 = 30
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchasePriceCol, GetType(Double))
				IL_347:
				num2 = 31
				fxDataSource.Columns.Add(OO_00oOO.MRP.PurchaseCostCol, GetType(Double), String.Concat(New String() { "[", OO_00oOO.MRP.PurchasePriceCol, "] * [", OO_00oOO.MRP.PurchaseCol, "]" }))
				IL_3A8:
				num2 = 32
				fxDataSource.Columns.Add(OO_00oOO.MRP.ProductionCol, Me.QuantityType)
				IL_3C8:
				num2 = 33
				If Me.Subcontract.DataTable Is Nothing Then
					GoTo IL_460
				End If
				IL_3DB:
				num2 = 34
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCPriceCol, GetType(Double))
				IL_3FF:
				num2 = 35
				fxDataSource.Columns.Add(OO_00oOO.MRP.SCCostCol, GetType(Double), String.Concat(New String() { "[", OO_00oOO.MRP.ProductionCol, "] * [", OO_00oOO.MRP.SCPriceCol, "]" }))
				IL_460:
				num2 = 36
				If Me.Stock.DataTable Is Nothing Then
					GoTo IL_4B0
				End If
				IL_470:
				num2 = 37
				fxDataSource.Columns.Add(OO_00oOO.MRP.ReplenishCol, Me.QuantityType)
				IL_490:
				num2 = 38
				fxDataSource.Columns.Add(OO_00oOO.MRP.RemainingCol, Me.QuantityType)
				IL_4B0:
				num2 = 39
				fxDataSource.PrimaryKey = New DataColumn() { fxDataSource.Columns(OO_00oOO.MRP.MaterialCol) }
				IL_4D9:
				num2 = 40
				Dim dataView As DataView = New DataView(Me.BOM.DataTable.BaseTable, "", Me.BOM.MaterialCol, DataViewRowState.CurrentRows)
				IL_505:
				num2 = 41
				Dim dataView2 As DataView = Nothing
				IL_50B:
				num2 = 42
				Dim dataView3 As DataView = Nothing
				IL_511:
				num2 = 43
				Dim dataView4 As DataView = Nothing
				IL_517:
				num2 = 44
				Dim dataView5 As DataView = Nothing
				IL_51D:
				num2 = 45
				If Me.Yield.DataTable Is Nothing OrElse Me.Yield.MaterialCol Is Nothing OrElse Me.Yield.YieldCol Is Nothing Then
					GoTo IL_573
				End If
				IL_547:
				num2 = 46
				dataView2 = New DataView(Me.Yield.DataTable.BaseTable, "", Me.Yield.MaterialCol, DataViewRowState.CurrentRows)
				IL_573:
				num2 = 47
				If Me.Stock.DataTable Is Nothing OrElse Me.Stock.MaterialCol Is Nothing OrElse Me.Stock.QuantityCol Is Nothing Then
					GoTo IL_5C9
				End If
				IL_59D:
				num2 = 48
				dataView3 = New DataView(Me.Stock.DataTable.BaseTable, "", Me.Stock.MaterialCol, DataViewRowState.CurrentRows)
				IL_5C9:
				num2 = 49
				If Me.Purchase.DataTable Is Nothing OrElse Operators.CompareString(Me.Purchase.MaterialCol, "", True) <= 0 OrElse Operators.CompareString(Me.Purchase.PriceCol, "", True) <= 0 Then
					GoTo IL_637
				End If
				IL_60B:
				num2 = 50
				dataView4 = New DataView(Me.Purchase.DataTable.BaseTable, "", Me.Purchase.MaterialCol, DataViewRowState.CurrentRows)
				IL_637:
				num2 = 51
				If Me.Subcontract.DataTable Is Nothing OrElse Operators.CompareString(Me.Subcontract.MaterialCol, "", True) <= 0 OrElse Operators.CompareString(Me.Subcontract.PriceCol, "", True) <= 0 Then
					GoTo IL_6A5
				End If
				IL_679:
				num2 = 52
				dataView5 = New DataView(Me.Subcontract.DataTable.BaseTable, "", Me.Subcontract.MaterialCol, DataViewRowState.CurrentRows)
				IL_6A5:
				num2 = 53
				Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
				IL_6AF:
				num2 = 54
				Dim dictionary2 As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_6B9:
				num2 = 55
				Dim enumerator3 As IEnumerator(Of String) = Me.Plan.Keys.GetEnumerator()
				While enumerator3.MoveNext()
					Dim text As String = enumerator3.Current
					IL_6DC:
					num2 = 56
					Dim num3 As Integer = dataView.Find(text)
					IL_6EA:
					num2 = 57
					If num3 > -1 Then
						IL_6F5:
						num2 = 58
						If Not dataView(num3).Row.IsNull(Me.BOM.PathCol) Then
							IL_71B:
							num2 = 59
							dictionary.Add(dataView(num3)(Me.BOM.PathCol).ToString(), Me.Plan(text))
							IL_750:
							num2 = 60
							dictionary2.Add(dataView(num3)(Me.BOM.PathCol).ToString(), text)
						End If
					Else
						IL_77C:
						num2 = 62
						dictionary.Add(text, Me.Plan(text))
						IL_795:
						num2 = 63
						dictionary2.Add(text, text)
					End If
					IL_7A3:
					num2 = 64
				End While
				IL_7B2:
				num2 = 65
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_7C0:
				num2 = 66
				dataView.Sort = Me.BOM.PathCol
				IL_7D5:
				num2 = 67
				Dim enumerator4 As Dictionary(Of String, Double).KeyCollection.Enumerator = dictionary.Keys.GetEnumerator()
				Dim flag As Boolean
				While enumerator4.MoveNext()
					Dim text2 As String = enumerator4.Current
					IL_7F1:
					num2 = 68
					If Me.BOM.Separator2 > vbNullChar Then
						IL_802:
						num2 = 69
						If text2.IndexOf(Me.BOM.Separator2) > 0 Then
							IL_81A:
							num2 = 70
							flag = True
							Exit While
						End If
					Else
						IL_822:
						num2 = 73
						If Me.BOM.lengths2 IsNot Nothing AndAlso Me.BOM.lengths2.Length > 0 Then
							IL_842:
							num2 = 74
							If text2.Length > Me.BOM.lengths2(0) Then
								IL_85B:
								num2 = 75
								flag = True
								Exit While
							End If
						End If
					End If
					IL_863:
					num2 = 77
				End While
				IL_872:
				num2 = 78
				CType(enumerator4, IDisposable).Dispose()
				IL_882:
				num2 = 79
				If Not flag Then
					GoTo IL_99D
				End If
				IL_88C:
				num2 = 80
				fxDataSource.Columns.Add(OO_00oOO.MRP.AssembleCol, Me.QuantityType)
				IL_8AC:
				num2 = 81
				fxDataSource.Columns.Add(OO_00oOO.MRP.MaintenanceCol, Me.QuantityType)
				IL_8CC:
				num2 = 82
				fxDataSource.Columns(OO_00oOO.MRP.AssembleCol).Expression = String.Concat(New String() { "[", OO_00oOO.MRP.QuantityCol, "] - IsNull([", OO_00oOO.MRP.MaintenanceCol, "],0)" })
				IL_927:
				num2 = 83
				fxDataSource.Columns(OO_00oOO.MRP.AssembleCol).SetOrdinal(fxDataSource.Columns(OO_00oOO.MRP.QuantityCol).Ordinal + 1)
				IL_962:
				num2 = 84
				fxDataSource.Columns(OO_00oOO.MRP.MaintenanceCol).SetOrdinal(fxDataSource.Columns(OO_00oOO.MRP.QuantityCol).Ordinal + 2)
				IL_99D:
				num2 = 85
				Dim enumerator5 As Dictionary(Of String, Double).KeyCollection.Enumerator = dictionary.Keys.GetEnumerator()
				While enumerator5.MoveNext()
					Dim text3 As String = enumerator5.Current
					IL_9B9:
					num2 = 86
					Dim a_ As Double = Me.o_.__OOO0.(dataView2, dictionary2(text3), dictionary(text3))
					IL_9D8:
					num2 = 87
					Me.o_.__OOO0.(fxDataSource, dataView, dataView2, text3, a_, dictionary2(text3))
					IL_9F5:
					num2 = 88
				End While
				IL_A01:
				num2 = 89
				CType(enumerator5, IDisposable).Dispose()
				IL_A11:
				num2 = 90
				Dim dataView6 As DataView = New DataView(Me.BOM.DataTable.BaseTable, "", Me.BOM.MaterialCol, DataViewRowState.CurrentRows)
				IL_A3D:
				num2 = 91
				Dim enumerator6 As IEnumerator = fxDataSource.Rows.GetEnumerator()
				While enumerator6.MoveNext()
					Dim obj As Object = enumerator6.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_A61:
					num2 = 92
					If Me.o00.o_O_o__..Contains(dataRow) Then
						IL_A76:
						num2 = 93
						Dim num4 As Integer = dataView6.Find(RuntimeHelpers.GetObjectValue(dataRow(OO_00oOO.MRP.MaterialCol)))
						IL_A98:
						num2 = 94
						If num4 >= 0 Then
							IL_AA3:
							num2 = 96
							Dim a_2 As String = dataView6(num4)(Me.BOM.PathCol).ToString()
							IL_AC6:
							num2 = 97
							Dim num5 As Integer = -1
							IL_ACC:
							num2 = 98
							If dataView3 IsNot Nothing Then
								IL_AD3:
								num2 = 99
								num5 = dataView3.Find(RuntimeHelpers.GetObjectValue(dataRow(OO_00oOO.MRP.MaterialCol)))
							End If
							IL_AF5:
							num2 = 100
							If num5 > -1 Then
								IL_B00:
								num2 = 101
								Dim num6 As Double = 0.0
								IL_B0E:
								num2 = 102
								Dim num7 As Double = 0.0
								IL_B1C:
								num2 = 103
								Dim num8 As Double = Conversions.ToDouble(dataRow(OO_00oOO.MRP.QuantityCol))
								IL_B37:
								num2 = 104
								If Not dataView3(num5).Row.IsNull(Me.Stock.QuantityCol) Then
									IL_B5D:
									num2 = 105
									num7 = Conversions.ToDouble(dataView3(num5)(Me.Stock.QuantityCol))
									IL_B80:
									num2 = 106
									If Operators.CompareString(Me.Stock.MinimumCol, "", True) > 0 AndAlso Not dataView3(num5).Row.IsNull(Me.Stock.MinimumCol) Then
										IL_BBC:
										num2 = 107
										num6 = Math.Max(0.0, Conversions.ToDouble(dataView3(num5)(Me.Stock.MinimumCol)))
									End If
								End If
								IL_BED:
								num2 = 108
								Dim enumerator7 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
								While enumerator7.MoveNext()
									Dim o00_0__O3 As o00_0__O = enumerator7.Current
									IL_C08:
									num2 = 109
									If Not dataRow.IsNull(o00_0__O3.o0o.OooOOo0__.()) Then
										IL_C1B:
										num2 = 110
										num7 += Conversions.ToDouble(dataRow(o00_0__O3.o0o.OooOOo0__.()))
									End If
									IL_C36:
									num2 = 111
								End While
								IL_C42:
								num2 = 112
								If enumerator7 IsNot Nothing Then
									enumerator7.Dispose()
								End If
								IL_C50:
								num2 = 113
								Dim num9 As Double
								If num6 > num7 Then
									IL_C59:
									num2 = 114
									num9 = num7 - num6
								Else
									IL_C65:
									num2 = 116
									If num7 > num6 Then
										IL_C6E:
										num2 = 117
										num9 = num7 - num6
										IL_C78:
										num2 = 118
										If num9 > num8 Then
											IL_C81:
											num2 = 119
											num9 = num8
										End If
									End If
								End If
								IL_C88:
								num2 = 120
								Me.o_.__OOO0.(fxDataSource, dataView, dataView2, a_2, -num9, Nothing)
							End If
						End If
					End If
					IL_C9E:
					num2 = 121
				End While
				IL_CAD:
				num2 = 122
				If TypeOf enumerator6 Is IDisposable Then
					TryCast(enumerator6, IDisposable).Dispose()
				End If
				IL_CC5:
				num2 = 123
				Dim enumerator8 As IEnumerator = fxDataSource.Rows.GetEnumerator()
				While enumerator8.MoveNext()
					Dim obj2 As Object = enumerator8.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_CE9:
					num2 = 124
					Dim num10 As Double = 0.0
					IL_CF7:
					num2 = 125
					Dim enumerator9 As IEnumerator(Of o00_0__O) = Me.Extensions.GetEnumerator()
					While enumerator9.MoveNext()
						Dim o00_0__O4 As o00_0__O = enumerator9.Current
						IL_D12:
						num2 = 126
						If Not dataRow2.IsNull(o00_0__O4.o0o.OooOOo0__.()) Then
							IL_D25:
							num2 = 127
							num10 += Conversions.ToDouble(dataRow2(o00_0__O4.o0o.OooOOo0__.()))
						End If
						IL_D40:
						num2 = 128
					End While
					IL_D4F:
					num2 = 129
					If enumerator9 IsNot Nothing Then
						enumerator9.Dispose()
					End If
					IL_D60:
					num2 = 130
					Dim num11 As Integer = -1
					IL_D69:
					num2 = 131
					If dataView3 IsNot Nothing Then
						IL_D73:
						num2 = 132
						num11 = dataView3.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
					End If
					IL_D98:
					num2 = 133
					Dim num12 As Double = Conversions.ToDouble(dataRow2(OO_00oOO.MRP.QuantityCol))
					IL_DB6:
					num2 = 134
					If num11 > -1 Then
						IL_DC4:
						num2 = 135
						Dim num13 As Double = 0.0
						IL_DD5:
						num2 = 136
						Dim num14 As Double = 0.0
						IL_DE6:
						num2 = 137
						If Not dataView3(num11).Row.IsNull(Me.Stock.QuantityCol) Then
							IL_E0C:
							num2 = 138
							num13 = Conversions.ToDouble(dataView3(num11)(Me.Stock.QuantityCol))
							IL_E32:
							num2 = 139
							dataRow2(OO_00oOO.MRP.StockCol) = num13
						End If
						IL_E50:
						num2 = 140
						If Operators.CompareString(Me.Stock.MinimumCol, "", True) > 0 AndAlso Not dataView3(num11).Row.IsNull(Me.Stock.MinimumCol) Then
							IL_E8F:
							num2 = 141
							num14 = Math.Max(0.0, Conversions.ToDouble(dataView3(num11)(Me.Stock.MinimumCol)))
							IL_EC3:
							num2 = 142
							dataRow2(OO_00oOO.MRP.MinimumCol) = num14
						End If
						IL_EE1:
						num2 = 143
						If num13 >= num14 AndAlso num14 > 0.0 Then
							IL_F00:
							num2 = 144
							Dim num15 As Double = Math.Min(num13 - num14, num12)
							IL_F14:
							num2 = 145
							num12 -= num15
							IL_F21:
							num2 = 146
							dataRow2(OO_00oOO.MRP.FromStockCol) = num15
							IL_F3F:
							num2 = 147
							num12 = Math.Max(0.0, num12 - num10)
							IL_F5A:
							num2 = 148
							If Me.o00.o_O_o__..Contains(dataRow2) Then
								IL_F6F:
								num2 = 149
								dataRow2(OO_00oOO.MRP.ProductionCol) = num12
							Else
								IL_F8F:
								num2 = 151
								dataRow2(OO_00oOO.MRP.PurchaseCol) = num12
							End If
							IL_FAD:
							num2 = 152
							dataRow2(OO_00oOO.MRP.RemainingCol) = num13 - num15
						Else
							IL_FD3:
							num2 = 154
							If num13 < num14 Then
								IL_FE2:
								num2 = 155
								Dim num16 As Double = num14 - num13
								IL_FEF:
								num2 = 156
								num12 += num16
								IL_FFC:
								num2 = 157
								dataRow2(OO_00oOO.MRP.ReplenishCol) = num16
								IL_101A:
								num2 = 158
								dataRow2(OO_00oOO.MRP.FromStockCol) = 0
								IL_1037:
								num2 = 159
								num12 = Math.Max(0.0, num12 - num10)
								IL_1052:
								num2 = 160
								If Me.o00.o_O_o__..Contains(dataRow2) Then
									IL_1067:
									num2 = 161
									dataRow2(OO_00oOO.MRP.ProductionCol) = num12
								Else
									IL_1087:
									num2 = 163
									dataRow2(OO_00oOO.MRP.PurchaseCol) = num12
								End If
								IL_10A5:
								num2 = 164
								dataRow2(OO_00oOO.MRP.RemainingCol) = num14
							Else
								IL_10C8:
								num2 = 166
								Dim num17 As Double
								If num13 > num12 Then
									IL_10D4:
									num2 = 167
									num17 = num12
									IL_10DE:
									num2 = 168
									dataRow2(OO_00oOO.MRP.RemainingCol) = num13 - num12
								Else
									IL_1101:
									num2 = 170
									If num13 > 0.0 Then
										IL_1114:
										num2 = 171
										num17 = num13
										IL_111E:
										num2 = 172
										dataRow2(OO_00oOO.MRP.RemainingCol) = 0
									End If
								End If
								IL_113B:
								num2 = 173
								num12 -= num17
								IL_1148:
								num2 = 174
								dataRow2(OO_00oOO.MRP.FromStockCol) = num17
								IL_1166:
								num2 = 175
								num12 = Math.Max(0.0, num12 - num10)
								IL_1181:
								num2 = 176
								If Me.o00.o_O_o__..Contains(dataRow2) Then
									IL_1196:
									num2 = 177
									dataRow2(OO_00oOO.MRP.ProductionCol) = num12
								Else
									IL_11B9:
									num2 = 179
									dataRow2(OO_00oOO.MRP.PurchaseCol) = num12
								End If
							End If
						End If
					Else
						IL_11D9:
						num2 = 181
						num12 = Math.Max(0.0, num12 - num10)
						IL_11F4:
						num2 = 182
						If Me.o00.o_O_o__..Contains(dataRow2) Then
							IL_1209:
							num2 = 183
							dataRow2(OO_00oOO.MRP.ProductionCol) = num12
						Else
							IL_1229:
							num2 = 185
							dataRow2(OO_00oOO.MRP.PurchaseCol) = num12
						End If
					End If
					IL_1247:
					num2 = 186
					If dataView4 IsNot Nothing Then
						IL_1251:
						num2 = 187
						num11 = dataView4.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
						IL_1276:
						num2 = 188
						If num11 >= 0 Then
							IL_1281:
							num2 = 189
							dataRow2(OO_00oOO.MRP.PurchasePriceCol) = RuntimeHelpers.GetObjectValue(dataView4(num11)(Me.Purchase.PriceCol))
						End If
					End If
					IL_12B6:
					num2 = 190
					If dataView5 IsNot Nothing Then
						IL_12C0:
						num2 = 191
						num11 = dataView5.Find(RuntimeHelpers.GetObjectValue(dataRow2(OO_00oOO.MRP.MaterialCol)))
						IL_12E5:
						num2 = 192
						If num11 >= 0 Then
							IL_12F0:
							num2 = 193
							dataRow2(OO_00oOO.MRP.SCPriceCol) = RuntimeHelpers.GetObjectValue(dataView5(num11)(Me.Subcontract.PriceCol))
						End If
					End If
					IL_1325:
					num2 = 194
				End While
				IL_1337:
				num2 = 195
				If TypeOf enumerator8 Is IDisposable Then
					TryCast(enumerator8, IDisposable).Dispose()
				End If
				IL_1352:
				num2 = 196
				result = fxDataSource
				IL_135B:
				GoTo IL_16C1
				IL_1360:
				Dim num18 As Integer = num19 + 1
				num19 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18)
				IL_1682:
				GoTo IL_16B6
				IL_1684:
				num19 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1694:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num19 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_1684
			End Try
			IL_16B6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_16C1:
			If num19 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060006A8 RID: 1704 RVA: 0x00026030 File Offset: 0x00024230
		Private Function <<EMPTY_NAME>>(A_0 As DataTable, A_1 As DataView, A_2 As DataView, A_3 As String, A_4 As Double, A_5 As String) As Integer
			Dim num As Integer
			Dim result As Integer
			Dim num15 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_10:
				num2 = 3
				Dim i As Integer = A_1.Find(A_3)
				IL_1C:
				num2 = 4
				If i >= 0 OrElse Operators.CompareString(Conversions.ToString(Me.BOM.Separator2), "", True) <= 0 Then
					GoTo IL_CB
				End If
				IL_47:
				num2 = 5
				Dim value As String = A_3 + Conversions.ToString(Me.BOM.Separator2)
				IL_62:
				num2 = 6
				Dim num3 As Integer = A_1.Count - 1
				i = 0
				While i <= num3
					IL_73:
					num2 = 7
					If A_1(i)(Me.BOM.PathCol).ToString().StartsWith(value, StringComparison.OrdinalIgnoreCase) Then
						Exit While
					End If
					IL_9C:
					num2 = 9
					i += 1
				End While
				IL_AB:
				num2 = 10
				If i < A_1.Count Then
					GoTo IL_C2
				End If
				IL_B8:
				num2 = 11
				result = -1
				GoTo IL_7CF
				IL_C2:
				num2 = 13
				i -= 1
				IL_CB:
				num2 = 14
				If Operators.CompareString(Conversions.ToString(Me.BOM.Separator2), "", True) <= 0 Then
					GoTo IL_1CA
				End If
				IL_EF:
				num2 = 15
				If Operators.CompareString(A_5, "", True) <= 0 OrElse A_3.IndexOf(Me.BOM.Separator2) <= 0 Then
					GoTo IL_11D
				End If
				IL_117:
				num2 = 16
				Dim flag As Boolean = True
				IL_11D:
				num2 = 17
				Dim num4 As Integer = i + 1
				Dim num5 As Integer = A_1.Count - 1
				For j As Integer = num4 To num5
					IL_135:
					num2 = 18
					Dim text As String = A_1(j)(Me.BOM.PathCol).ToString()
					IL_157:
					num2 = 19
					If Not text.StartsWith(A_3 + Conversions.ToString(Me.BOM.Separator2), StringComparison.OrdinalIgnoreCase) Then
						Exit For
					End If
					IL_17E:
					num2 = 20
					If text.LastIndexOf(Me.BOM.Separator2) = A_3.Length Then
						IL_19C:
						num2 = 21
						list.Add(A_1(j).Row)
					End If
					IL_1B3:
					num2 = 24
				Next
				GoTo IL_317
				IL_1CA:
				num2 = 26
				If Me.BOM.lengths2 Is Nothing OrElse Me.BOM.lengths2.Length <= 0 Then
					GoTo IL_317
				End If
				IL_1F0:
				num2 = 27
				If Operators.CompareString(A_5, "", True) <= 0 OrElse A_3.Length <= Me.BOM.lengths2(0) Then
					GoTo IL_21F
				End If
				IL_219:
				num2 = 28
				flag = True
				IL_21F:
				num2 = 29
				Dim num6 As Integer = 0
				IL_225:
				num2 = 30
				If Me.BOM.lengths2.Length <> 1 Then
					GoTo IL_254
				End If
				IL_238:
				num2 = 31
				num6 = A_3.Length + Me.BOM.lengths2(0)
				GoTo IL_29F
				IL_254:
				num2 = 33
				Dim num7 As Integer = 0
				While True
					IL_291:
					num2 = 35
					If num6 > A_3.Length Then
						Exit For
					End If
					IL_25C:
					num2 = 36
					num6 += Me.BOM.lengths2(num7)
					IL_272:
					num2 = 37
					If num7 < Me.BOM.lengths2.Length - 1 Then
						IL_288:
						num2 = 38
						num7 += 1
					End If
				End While
				IL_29F:
				num2 = 40
				Dim num8 As Integer = i
				Dim num9 As Integer = A_1.Count - 1
				For k As Integer = num8 To num9
					IL_2B2:
					num2 = 41
					Dim text2 As String = A_1(k)(Me.BOM.PathCol).ToString()
					IL_2D4:
					num2 = 42
					If Not text2.StartsWith(A_3, StringComparison.OrdinalIgnoreCase) Then
						Exit For
					End If
					IL_2E3:
					num2 = 43
					If text2.Length = num6 Then
						IL_2F1:
						num2 = 44
						list.Add(A_1(k).Row)
					End If
					IL_308:
					num2 = 47
				Next
				IL_317:
				num2 = 48
				If Not flag OrElse Operators.CompareString(A_5, "", True) <= 0 Then
					GoTo IL_432
				End If
				IL_334:
				num2 = 49
				Dim dataRow As DataRow = A_0.Rows.Find(A_5)
				IL_346:
				num2 = 50
				If dataRow IsNot Nothing Then
					GoTo IL_39B
				End If
				IL_34D:
				num2 = 51
				dataRow = A_0.NewRow()
				IL_358:
				num2 = 52
				dataRow(OO_00oOO.MRP.MaterialCol) = A_5
				IL_36E:
				num2 = 53
				dataRow(OO_00oOO.MRP.QuantityCol) = A_4
				IL_389:
				num2 = 54
				A_0.Rows.Add(dataRow)
				GoTo IL_3CD
				IL_39B:
				num2 = 56
				dataRow(OO_00oOO.MRP.QuantityCol) = Conversions.ToDouble(dataRow(OO_00oOO.MRP.QuantityCol)) + A_4
				IL_3CD:
				num2 = 57
				If Not dataRow.IsNull(OO_00oOO.MRP.MaintenanceCol) Then
					GoTo IL_400
				End If
				IL_3E3:
				num2 = 58
				dataRow(OO_00oOO.MRP.MaintenanceCol) = A_4
				GoTo IL_432
				IL_400:
				num2 = 60
				dataRow(OO_00oOO.MRP.MaintenanceCol) = Conversions.ToDouble(dataRow(OO_00oOO.MRP.MaintenanceCol)) + A_4
				IL_432:
				num2 = 61
				Dim enumerator As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataRow2 As DataRow = enumerator.Current
					IL_44C:
					num2 = 62
					If Not dataRow2.IsNull(Me.BOM.MaterialCol) AndAlso Not dataRow2.IsNull(Me.BOM.QuantityCol) Then
						IL_47D:
						num2 = 64
						Dim a_ As String = dataRow2(Me.BOM.PathCol).ToString()
						IL_499:
						num2 = 65
						Dim text3 As String = dataRow2(Me.BOM.MaterialCol).ToString()
						IL_4B5:
						num2 = 66
						Dim num10 As Double = Me.o_.__OOO0.(A_2, text3, Conversions.ToDouble(dataRow2(Me.BOM.QuantityCol)) * A_4)
						IL_4DD:
						num2 = 67
						Dim dataRow3 As DataRow = A_0.Rows.Find(text3)
						IL_4EF:
						num2 = 68
						If dataRow3 Is Nothing Then
							IL_4F9:
							num2 = 69
							dataRow3 = A_0.NewRow()
							IL_504:
							num2 = 70
							dataRow3(OO_00oOO.MRP.MaterialCol) = text3
							IL_51A:
							num2 = 71
							dataRow3(OO_00oOO.MRP.QuantityCol) = num10
							IL_535:
							num2 = 72
							A_0.Rows.Add(dataRow3)
							IL_545:
							num2 = 73
							Dim array As MRPExtendTables() = New MRPExtendTables() { Me.Extensions, Me.Additions }
							IL_562:
							num2 = 74
							For Each mrpextendTables As MRPExtendTables In array
								IL_578:
								num2 = 75
								Dim enumerator2 As IEnumerator(Of o00_0__O) = mrpextendTables.GetEnumerator()
								While enumerator2.MoveNext()
									Dim o00_0__O As o00_0__O = enumerator2.Current
									IL_592:
									num2 = 76
									Dim num11 As Integer = o00_0__O.oo__.0O00.().Find(text3)
									IL_5A5:
									num2 = 77
									If num11 >= 0 Then
										IL_5B0:
										num2 = 78
										dataRow3(o00_0__O.o0o.OooOOo0__.()) = RuntimeHelpers.GetObjectValue(o00_0__O.oo__.0O00.()(num11)(o00_0__O.oooO00.o00O.()))
										IL_5E0:
										num2 = 79
										If mrpextendTables Is Me.Extensions AndAlso Not o00_0__O.oo__.0O00.()(num11).Row.IsNull(o00_0__O.oooO00.o00O.()) Then
											IL_614:
											num2 = 80
											If Me.o00.o_O_o__..ContainsKey(text3) Then
												IL_626:
												num2 = 81
												Me.o00.o_O_o__.(text3) = Me.o00.o_O_o__.(text3) + Conversions.ToDouble(o00_0__O.oo__.0O00.()(num11).Row(o00_0__O.oooO00.o00O.()))
											Else
												IL_66A:
												num2 = 83
												Me.o00.o_O_o__.(text3) = Conversions.ToDouble(o00_0__O.oo__.0O00.()(num11).Row(o00_0__O.oooO00.o00O.()))
											End If
										End If
									End If
									IL_69E:
									num2 = 84
								End While
								IL_6AD:
								num2 = 85
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
								IL_6BB:
								num2 = 86
							Next
						Else
							IL_6D1:
							num2 = 88
							dataRow3(OO_00oOO.MRP.QuantityCol) = Conversions.ToDouble(dataRow3(OO_00oOO.MRP.QuantityCol)) + num10
						End If
						IL_703:
						num2 = 89
						If Me.o00.o_O_o__..ContainsKey(text3) Then
							IL_715:
							num2 = 90
							Dim num12 As Double = Me.o00.o_O_o__.(text3)
							IL_727:
							num2 = 91
							If num12 >= num10 Then
								IL_730:
								num2 = 92
								Me.o00.o_O_o__.(text3) = num12 - num10
								GoTo IL_7A5
							End If
							IL_747:
							num2 = 95
							If num12 > 0.0 Then
								IL_757:
								num2 = 96
								Me.o00.o_O_o__.(text3) = 0.0
								IL_770:
								num2 = 97
								num10 -= num12
							End If
						End If
						IL_77A:
						num2 = 98
						Dim num13 As Integer = Me.o_.__OOO0.(A_0, A_1, A_2, a_, num10, Nothing)
						IL_78D:
						num2 = 99
						If num13 > 0 Then
							IL_795:
							num2 = 100
							Me.o00.o_O_o__..Add(dataRow3)
						End If
					End If
					IL_7A5:
					num2 = 101
				End While
				IL_7B4:
				num2 = 102
				CType(enumerator, IDisposable).Dispose()
				IL_7C4:
				num2 = 103
				result = list.Count
				IL_7CF:
				GoTo IL_9C1
				IL_7D4:
				Dim num14 As Integer = num15 + 1
				num15 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num14)
				IL_982:
				GoTo IL_9B6
				IL_984:
				num15 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_994:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num15 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_984
			End Try
			IL_9B6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9C1:
			If num15 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060006A9 RID: 1705 RVA: 0x00026A24 File Offset: 0x00024C24
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

		' Token: 0x040001BD RID: 445
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As BomTable

		' Token: 0x040001BE RID: 446
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As YieldTable

		' Token: 0x040001BF RID: 447
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As StockTable

		' Token: 0x040001C0 RID: 448
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PriceTable

		' Token: 0x040001C1 RID: 449
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PriceTable

		' Token: 0x040001C2 RID: 450
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As mrpPlan

		' Token: 0x040001C3 RID: 451
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x040001C4 RID: 452
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As MRPExtendTables

		' Token: 0x040001C5 RID: 453
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Type

		' Token: 0x040001C6 RID: 454
		Private <<EMPTY_NAME>> As Dictionary(Of String, Double)

		' Token: 0x040001C7 RID: 455
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001C8 RID: 456
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x040001C9 RID: 457
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040001CA RID: 458
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
