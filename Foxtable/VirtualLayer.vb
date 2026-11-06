Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.Map

Namespace Foxtable
	' Token: 0x0200015F RID: 351
	<ComVisible(True)>
	Public Class VirtualLayer
		Inherits VirtualLayer

		' Token: 0x06000FE0 RID: 4064 RVA: 0x00069824 File Offset: 0x00067A24
		Friend Sub New(A_0 As GeoMap, A_1 As Double)
			MyBase.MinZoom = A_1
			MyBase.Slices.Add(New MapSlice(0.0, 1, 1))
			MyBase.Slices.Add(New MapSlice(MyBase.MinZoom, 720, 720))
			MyBase.ItemsSource = New VirtualTileSource(A_0, Me)
		End Sub

		' Token: 0x06000FE1 RID: 4065 RVA: 0x00069886 File Offset: 0x00067A86
		Friend Sub New(A_0 As GeoMap, A_1 As Double, A_2 As Double)
			Me.New(A_0, A_1)
			MyBase.MaxZoom = A_2
		End Sub

		' Token: 0x06000FE2 RID: 4066 RVA: 0x00069897 File Offset: 0x00067A97
		Public Sub SetSlices(longSlices As Integer, latSlices As Integer)
			MyBase.Slices.Clear()
			MyBase.Slices.Add(New MapSlice(0.0, 1, 1))
			MyBase.Slices.Add(New MapSlice(MyBase.MinZoom, latSlices, longSlices))
		End Sub
	End Class
End Namespace
