Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x0200008F RID: 143
	<ComVisible(True)>
	<oO0oooo("3388")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class MRPTableCols
		' Token: 0x0600053D RID: 1341 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
		Public Sub New()
			Me.MaterialCol = "物料"
			Me.StockCol = "库存数量"
			Me.MinimumCol = "最低库存"
			Me.QuantityCol = "计划_需求数量"
			Me.FromStockCol = "计划_来自库存"
			Me.PurchaseCol = "计划_需要采购"
			Me.PurchasePriceCol = "计划_采购单价"
			Me.PurchaseCostCol = "计划_采购成本"
			Me.ProductionCol = "计划_需要生产"
			Me.SCPriceCol = "计划_加工单价"
			Me.SCCostCol = "计划_加工成本"
			Me.ReplenishCol = "计划_补充库存"
			Me.RemainingCol = "剩余库存"
			Me.AssembleCol = "计划_用于生产"
			Me.MaintenanceCol = "计划_用于售后"
		End Sub

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x0600053E RID: 1342 RVA: 0x0001D06C File Offset: 0x0001B26C
		' (set) Token: 0x0600053F RID: 1343 RVA: 0x0001D074 File Offset: 0x0001B274
		Public Property MaterialCol As String

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000540 RID: 1344 RVA: 0x0001D07D File Offset: 0x0001B27D
		' (set) Token: 0x06000541 RID: 1345 RVA: 0x0001D085 File Offset: 0x0001B285
		Public Property StockCol As String

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000542 RID: 1346 RVA: 0x0001D08E File Offset: 0x0001B28E
		' (set) Token: 0x06000543 RID: 1347 RVA: 0x0001D096 File Offset: 0x0001B296
		Public Property MinimumCol As String

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x06000544 RID: 1348 RVA: 0x0001D09F File Offset: 0x0001B29F
		' (set) Token: 0x06000545 RID: 1349 RVA: 0x0001D0A7 File Offset: 0x0001B2A7
		Public Property QuantityCol As String

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x06000546 RID: 1350 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		' (set) Token: 0x06000547 RID: 1351 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		Public Property FromStockCol As String

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x06000548 RID: 1352 RVA: 0x0001D0C1 File Offset: 0x0001B2C1
		' (set) Token: 0x06000549 RID: 1353 RVA: 0x0001D0C9 File Offset: 0x0001B2C9
		Public Property PurchaseCol As String

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x0600054A RID: 1354 RVA: 0x0001D0D2 File Offset: 0x0001B2D2
		' (set) Token: 0x0600054B RID: 1355 RVA: 0x0001D0DA File Offset: 0x0001B2DA
		Public Property PurchasePriceCol As String

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x0600054C RID: 1356 RVA: 0x0001D0E3 File Offset: 0x0001B2E3
		' (set) Token: 0x0600054D RID: 1357 RVA: 0x0001D0EB File Offset: 0x0001B2EB
		Public Property PurchaseCostCol As String

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x0600054E RID: 1358 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		' (set) Token: 0x0600054F RID: 1359 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		Public Property ProductionCol As String

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000550 RID: 1360 RVA: 0x0001D105 File Offset: 0x0001B305
		' (set) Token: 0x06000551 RID: 1361 RVA: 0x0001D10D File Offset: 0x0001B30D
		Public Property SCPriceCol As String

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000552 RID: 1362 RVA: 0x0001D116 File Offset: 0x0001B316
		' (set) Token: 0x06000553 RID: 1363 RVA: 0x0001D11E File Offset: 0x0001B31E
		Public Property SCCostCol As String

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x06000554 RID: 1364 RVA: 0x0001D127 File Offset: 0x0001B327
		' (set) Token: 0x06000555 RID: 1365 RVA: 0x0001D12F File Offset: 0x0001B32F
		Public Property ReplenishCol As String

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x06000556 RID: 1366 RVA: 0x0001D138 File Offset: 0x0001B338
		' (set) Token: 0x06000557 RID: 1367 RVA: 0x0001D140 File Offset: 0x0001B340
		Public Property RemainingCol As String

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x06000558 RID: 1368 RVA: 0x0001D149 File Offset: 0x0001B349
		' (set) Token: 0x06000559 RID: 1369 RVA: 0x0001D151 File Offset: 0x0001B351
		Public Property AssembleCol As String

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x0600055A RID: 1370 RVA: 0x0001D15A File Offset: 0x0001B35A
		' (set) Token: 0x0600055B RID: 1371 RVA: 0x0001D162 File Offset: 0x0001B362
		Public Property MaintenanceCol As String

		' Token: 0x04000128 RID: 296
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000129 RID: 297
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012A RID: 298
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012B RID: 299
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012C RID: 300
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012D RID: 301
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012E RID: 302
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400012F RID: 303
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000130 RID: 304
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000131 RID: 305
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000132 RID: 306
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000133 RID: 307
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000134 RID: 308
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000135 RID: 309
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000136 RID: 310
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
