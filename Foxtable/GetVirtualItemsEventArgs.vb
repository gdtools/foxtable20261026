Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports C1.Win.Interop
Imports C1.Win.Map
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000139 RID: 313
	Public Class GetVirtualItemsEventArgs
		Inherits ControlEventArgs

		' Token: 0x170002A7 RID: 679
		' (get) Token: 0x06000F2A RID: 3882 RVA: 0x00068005 File Offset: 0x00066205
		' (set) Token: 0x06000F2B RID: 3883 RVA: 0x0006800D File Offset: 0x0006620D
		Private Property lowerLeft As Point

		' Token: 0x170002A8 RID: 680
		' (get) Token: 0x06000F2C RID: 3884 RVA: 0x00068016 File Offset: 0x00066216
		' (set) Token: 0x06000F2D RID: 3885 RVA: 0x0006801E File Offset: 0x0006621E
		Private Property upperRight As Point

		' Token: 0x170002A9 RID: 681
		' (get) Token: 0x06000F2E RID: 3886 RVA: 0x00068027 File Offset: 0x00066227
		Public ReadOnly Property Items As List(Of VectorItem)

		' Token: 0x170002AA RID: 682
		' (get) Token: 0x06000F2F RID: 3887 RVA: 0x0006802F File Offset: 0x0006622F
		Public ReadOnly Property Layer As VirtualLayer

		' Token: 0x06000F30 RID: 3888 RVA: 0x00068038 File Offset: 0x00066238
		Friend Sub New(A_0 As Map, A_1 As VirtualLayer, A_2 As Form, A_3 As Point, A_4 As Point)
			MyBase.New(A_0.BaseControl, A_2)
			Me.Items = New List(Of VectorItem)()
			Me.Layer = A_1
			Me.o0o0_O.0O__O_. = CType(A_0.BaseControl, GeoMap)
			Me.lowerLeft = A_3
			Me.upperRight = A_4
		End Sub

		' Token: 0x170002AB RID: 683
		' (get) Token: 0x06000F31 RID: 3889 RVA: 0x00068085 File Offset: 0x00066285
		Public ReadOnly Property GeoMap As GeoMap
			Get
				Return Me.o0o0_O.0O__O_.
			End Get
		End Property

		' Token: 0x170002AC RID: 684
		' (get) Token: 0x06000F32 RID: 3890 RVA: 0x00068090 File Offset: 0x00066290
		Public ReadOnly Property X1 As Double
			Get
				Return Me.lowerLeft.X
			End Get
		End Property

		' Token: 0x170002AD RID: 685
		' (get) Token: 0x06000F33 RID: 3891 RVA: 0x000680AC File Offset: 0x000662AC
		Public ReadOnly Property X2 As Double
			Get
				Return Me.upperRight.X
			End Get
		End Property

		' Token: 0x170002AE RID: 686
		' (get) Token: 0x06000F34 RID: 3892 RVA: 0x000680C8 File Offset: 0x000662C8
		Public ReadOnly Property Y1 As Double
			Get
				Return Me.lowerLeft.Y
			End Get
		End Property

		' Token: 0x170002AF RID: 687
		' (get) Token: 0x06000F35 RID: 3893 RVA: 0x000680E4 File Offset: 0x000662E4
		Public ReadOnly Property Y2 As Double
			Get
				Return Me.upperRight.Y
			End Get
		End Property

		' Token: 0x040005D6 RID: 1494
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x040005D7 RID: 1495
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Point

		' Token: 0x040005D8 RID: 1496
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Point

		' Token: 0x040005D9 RID: 1497
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As List(Of VectorItem)

		' Token: 0x040005DA RID: 1498
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As VirtualLayer
	End Class
End Namespace
