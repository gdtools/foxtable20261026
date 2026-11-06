Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.FlexMap
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200015C RID: 348
	Public Class CustomTileSource
		Inherits ITileSource

		' Token: 0x170002F4 RID: 756
		' (get) Token: 0x06000FCE RID: 4046 RVA: 0x00069534 File Offset: 0x00067734
		' (set) Token: 0x06000FCF RID: 4047 RVA: 0x0006953C File Offset: 0x0006773C
		Friend Property Map As GeoMap

		' Token: 0x06000FD0 RID: 4048 RVA: 0x00069545 File Offset: 0x00067745
		Friend Sub New(A_0 As GeoMap)
			Me.Map = A_0
		End Sub

		' Token: 0x170002F5 RID: 757
		' (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00069554 File Offset: 0x00067754
		Public ReadOnly Property TileWidth As Integer
			Get
				Return 256
			End Get
		End Property

		' Token: 0x170002F6 RID: 758
		' (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0006955B File Offset: 0x0006775B
		Public ReadOnly Property TileHeight As Integer
			Get
				Return 256
			End Get
		End Property

		' Token: 0x06000FD3 RID: 4051 RVA: 0x00069564 File Offset: 0x00067764
		Public Sub GetTile(level As Integer, x As Integer, y As Integer, ByRef uri As String, ByRef image As Object)
			Dim a_ As Map = New Map(Me.Map)
			Dim form As Foxtable.WinForm.Form = Nothing
			Dim parent As System.Windows.Forms.Control = Me.Map.Parent
			While parent IsNot Nothing
				If TypeOf parent Is FormPanel Then
					form = OO_00oOO.Forms(parent.Name)
					Exit While
				End If
			End While
			Dim getMapTileEventArgs As GetMapTileEventArgs = New GetMapTileEventArgs(a_, form, x, y, level, uri, image)
			Dim a_2 As String = "GetMapTile_" + Conversions.ToString(Me.Map.Tag)
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, New Object() { getMapTileEventArgs }, False, form.mmname + "," + Me.Map.Name, False)
			uri = getMapTileEventArgs.URI
			image = RuntimeHelpers.GetObjectValue(getMapTileEventArgs.Image)
		End Sub

		' Token: 0x04000610 RID: 1552
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GeoMap
	End Class
End Namespace
