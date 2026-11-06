Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.Interop
Imports C1.Win.Map
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000160 RID: 352
	<ComVisible(True)>
	Public Class VirtualTileSource
		Inherits IMapVirtualSource

		' Token: 0x170002FD RID: 765
		' (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000698D7 File Offset: 0x00067AD7
		' (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000698DF File Offset: 0x00067ADF
		Friend Property Map As GeoMap

		' Token: 0x170002FE RID: 766
		' (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000698E8 File Offset: 0x00067AE8
		' (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000698F0 File Offset: 0x00067AF0
		Friend Property layer As VirtualLayer

		' Token: 0x06000FE7 RID: 4071 RVA: 0x000698F9 File Offset: 0x00067AF9
		Friend Sub New(A_0 As GeoMap, A_1 As VirtualLayer)
			Me.Map = A_0
			Me.layer = A_1
		End Sub

		' Token: 0x06000FE8 RID: 4072 RVA: 0x00069910 File Offset: 0x00067B10
		Public Function Request(minZoom As Double, maxZoom As Double, lowerLeft As Point, upperRight As Point) As IEnumerable(Of VectorItem)
			Dim result As IEnumerable(Of VectorItem)
			If Me.Map.Viewport.Zoom < Me.layer.MinZoom Then
				result = Nothing
			ElseIf Me.Map.Viewport.Zoom > Me.layer.MaxZoom Then
				result = Nothing
			Else
				Dim a_ As Map = New Map(Me.Map)
				Dim form As Foxtable.WinForm.Form = Nothing
				Dim parent As System.Windows.Forms.Control = Me.Map.Parent
				While parent IsNot Nothing
					If TypeOf parent Is FormPanel Then
						form = OO_00oOO.Forms(parent.Name)
						Exit While
					End If
				End While
				Dim getVirtualItemsEventArgs As GetVirtualItemsEventArgs = New GetVirtualItemsEventArgs(a_, Me.layer, form, lowerLeft, upperRight)
				Dim a_2 As String = "GetVirtualItems_" + Conversions.ToString(Me.Map.Tag)
				O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, New Object() { getVirtualItemsEventArgs }, False, form.mmname + "," + Me.Map.Name, False)
				result = getVirtualItemsEventArgs.Items
			End If
			Return result
		End Function

		' Token: 0x04000618 RID: 1560
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x04000619 RID: 1561
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As VirtualLayer
	End Class
End Namespace
