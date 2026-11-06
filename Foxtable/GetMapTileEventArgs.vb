Imports System
Imports System.Runtime.CompilerServices
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000151 RID: 337
	Public Class GetMapTileEventArgs
		Inherits ControlEventArgs

		' Token: 0x170002DD RID: 733
		' (get) Token: 0x06000F9C RID: 3996 RVA: 0x00068ECB File Offset: 0x000670CB
		' (set) Token: 0x06000F9D RID: 3997 RVA: 0x00068ED3 File Offset: 0x000670D3
		Public Property Z As Integer

		' Token: 0x170002DE RID: 734
		' (get) Token: 0x06000F9E RID: 3998 RVA: 0x00068EDC File Offset: 0x000670DC
		' (set) Token: 0x06000F9F RID: 3999 RVA: 0x00068EE4 File Offset: 0x000670E4
		Public Property X As Integer

		' Token: 0x170002DF RID: 735
		' (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00068EED File Offset: 0x000670ED
		' (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00068EF5 File Offset: 0x000670F5
		Public Property Y As Integer

		' Token: 0x170002E0 RID: 736
		' (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00068EFE File Offset: 0x000670FE
		' (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00068F06 File Offset: 0x00067106
		Public Property URI As String

		' Token: 0x170002E1 RID: 737
		' (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00068F0F File Offset: 0x0006710F
		' (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00068F17 File Offset: 0x00067117
		Public Property Image As Object
			<CompilerGenerated()>
			Get
				Return Me.oO_Oo.___.
			End Get
			<CompilerGenerated()>
			Set(value As Object)
				Me.oO_Oo.___. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06000FA6 RID: 4006 RVA: 0x00068F28 File Offset: 0x00067128
		Public Sub New(A_0 As Map, A_1 As Form, A_2 As Integer, A_3 As Integer, A_4 As Integer, ByRef A_5 As String, ByRef A_6 As Object)
			MyBase.New(A_0.BaseControl, A_1)
			Me.oO_Oo.___. = CType(A_0.BaseControl, GeoMap)
			Me.X = A_2
			Me.Y = A_3
			Me.Z = A_4
			Me.URI = A_5
			Me.Image = RuntimeHelpers.GetObjectValue(A_6)
		End Sub

		' Token: 0x170002E2 RID: 738
		' (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00068F81 File Offset: 0x00067181
		Public ReadOnly Property GeoMap As GeoMap
			Get
				Return Me.oO_Oo.___.
			End Get
		End Property

		' Token: 0x040005FB RID: 1531
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x040005FC RID: 1532
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005FD RID: 1533
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005FE RID: 1534
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005FF RID: 1535
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000600 RID: 1536
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
