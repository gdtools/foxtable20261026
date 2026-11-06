Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports C1.Win.Map
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200015E RID: 350
	Public Class OwerDrawMarkEventArgs
		Inherits ControlEventArgs

		' Token: 0x170002F8 RID: 760
		' (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000697B4 File Offset: 0x000679B4
		Public ReadOnly Property GeoMap As GeoMap

		' Token: 0x170002F9 RID: 761
		' (get) Token: 0x06000FDA RID: 4058 RVA: 0x000697BC File Offset: 0x000679BC
		Public ReadOnly Property Graphics As Graphics

		' Token: 0x170002FA RID: 762
		' (get) Token: 0x06000FDB RID: 4059 RVA: 0x000697C4 File Offset: 0x000679C4
		' (set) Token: 0x06000FDC RID: 4060 RVA: 0x000697CC File Offset: 0x000679CC
		Public Property Bounds As RectangleF

		' Token: 0x170002FB RID: 763
		' (get) Token: 0x06000FDD RID: 4061 RVA: 0x000697D5 File Offset: 0x000679D5
		Public ReadOnly Property Style As Style

		' Token: 0x170002FC RID: 764
		' (get) Token: 0x06000FDE RID: 4062 RVA: 0x000697DD File Offset: 0x000679DD
		Public ReadOnly Property ShapeTag As Object

		' Token: 0x06000FDF RID: 4063 RVA: 0x000697E5 File Offset: 0x000679E5
		Public Sub New(A_0 As Map, A_1 As Form, A_2 As Graphics, A_3 As RectangleF, A_4 As Style, A_5 As Object)
			MyBase.New(A_0.BaseControl, A_1)
			Me.GeoMap = CType(A_0.BaseControl, GeoMap)
			Me.Graphics = A_2
			Me.Bounds = A_3
			Me.Style = A_4
			Me.ShapeTag = A_5
		End Sub

		' Token: 0x04000613 RID: 1555
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x04000614 RID: 1556
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Graphics

		' Token: 0x04000615 RID: 1557
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RectangleF

		' Token: 0x04000616 RID: 1558
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Style

		' Token: 0x04000617 RID: 1559
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
