Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.FlexMap
Imports C1.Win.Map

Namespace Foxtable
	' Token: 0x0200013A RID: 314
	<ComVisible(True)>
	Public Class VectorRecord
		' Token: 0x170002B0 RID: 688
		' (get) Token: 0x06000F36 RID: 3894 RVA: 0x000680FF File Offset: 0x000662FF
		Public ReadOnly Property VectorItem As VectorItem

		' Token: 0x170002B1 RID: 689
		' (get) Token: 0x06000F37 RID: 3895 RVA: 0x00068107 File Offset: 0x00066307
		Public ReadOnly Property Data As IGeoGeometryRecordData

		' Token: 0x06000F38 RID: 3896 RVA: 0x0006810F File Offset: 0x0006630F
		Friend Sub New(A_0 As VectorItem, A_1 As IGeoGeometryRecordData)
			Me.VectorItem = A_0
			Me.Data = A_1
		End Sub

		' Token: 0x040005DB RID: 1499
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As VectorItem

		' Token: 0x040005DC RID: 1500
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As IGeoGeometryRecordData
	End Class
End Namespace
