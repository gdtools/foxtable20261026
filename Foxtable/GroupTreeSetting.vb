Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x0200009B RID: 155
	<ComVisible(True)>
	Public Class GroupTreeSetting
		' Token: 0x1700017A RID: 378
		' (get) Token: 0x060005BA RID: 1466 RVA: 0x0001E11F File Offset: 0x0001C31F
		' (set) Token: 0x060005BB RID: 1467 RVA: 0x0001E127 File Offset: 0x0001C327
		Public Property GroupCols As Object()

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x060005BC RID: 1468 RVA: 0x0001E130 File Offset: 0x0001C330
		' (set) Token: 0x060005BD RID: 1469 RVA: 0x0001E138 File Offset: 0x0001C338
		Public Property AggregateCols As Object()

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x060005BE RID: 1470 RVA: 0x0001E141 File Offset: 0x0001C341
		' (set) Token: 0x060005BF RID: 1471 RVA: 0x0001E149 File Offset: 0x0001C349
		Public Property ValueCols As String()

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001E152 File Offset: 0x0001C352
		' (set) Token: 0x060005C1 RID: 1473 RVA: 0x0001E15A File Offset: 0x0001C35A
		Public Property SortCol As String

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001E163 File Offset: 0x0001C363
		' (set) Token: 0x060005C3 RID: 1475 RVA: 0x0001E16B File Offset: 0x0001C36B
		Public Property SortDesc As Boolean

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001E174 File Offset: 0x0001C374
		Friend ReadOnly Property GroupCols2 As String()
			Get
				Return ooO.oO0__o.0o__.(Me.GroupCols)
			End Get
		End Property

		' Token: 0x0400015E RID: 350
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x0400015F RID: 351
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x04000160 RID: 352
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String()

		' Token: 0x04000161 RID: 353
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000162 RID: 354
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
