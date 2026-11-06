Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.Map
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200015D RID: 349
	Public Class CustomMarkShape
		Inherits CustomShape

		' Token: 0x170002F7 RID: 759
		' (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00069622 File Offset: 0x00067822
		' (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0006962A File Offset: 0x0006782A
		Friend Property Map As GeoMap

		' Token: 0x06000FD6 RID: 4054 RVA: 0x00069633 File Offset: 0x00067833
		Friend Sub New(A_0 As GeoMap, A_1 As Object)
			Me.Map = A_0
			Me.ShapeTag = RuntimeHelpers.GetObjectValue(A_1)
		End Sub

		' Token: 0x06000FD7 RID: 4055 RVA: 0x00069650 File Offset: 0x00067850
		Public Overrides Sub Draw(g As Graphics, bounds As RectangleF, style As Style)
			Dim a_ As Map = New Map(Me.Map)
			Dim form As Foxtable.WinForm.Form = Nothing
			Dim parent As System.Windows.Forms.Control = Me.Map.Parent
			While parent IsNot Nothing
				If TypeOf parent Is FormPanel Then
					form = OO_00oOO.Forms(parent.Name)
					Exit While
				End If
			End While
			Dim owerDrawMarkEventArgs As OwerDrawMarkEventArgs = New OwerDrawMarkEventArgs(a_, form, g, bounds, style, RuntimeHelpers.GetObjectValue(Me.ShapeTag))
			Dim a_2 As String = "OwerDrawMark_" + Conversions.ToString(Me.Map.Tag)
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, New Object() { owerDrawMarkEventArgs }, False, form.mmname + "," + Me.Map.Name, False)
		End Sub

		' Token: 0x06000FD8 RID: 4056 RVA: 0x00069700 File Offset: 0x00067900
		Public Overrides Function GetDrawingBounds(g As Graphics, bounds As RectangleF, style As Style) As RectangleF
			Dim a_ As Map = New Map(Me.Map)
			Dim form As Foxtable.WinForm.Form = Nothing
			Dim parent As System.Windows.Forms.Control = Me.Map.Parent
			While parent IsNot Nothing
				If TypeOf parent Is FormPanel Then
					form = OO_00oOO.Forms(parent.Name)
					Exit While
				End If
			End While
			Dim owerDrawMarkEventArgs As OwerDrawMarkEventArgs = New OwerDrawMarkEventArgs(a_, form, g, bounds, style, RuntimeHelpers.GetObjectValue(Me.ShapeTag))
			Dim a_2 As String = "GetDrawingBounds_" + Conversions.ToString(Me.Map.Tag)
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, New Object() { owerDrawMarkEventArgs }, False, form.mmname + "," + Me.Map.Name, False)
			Return owerDrawMarkEventArgs.Bounds
		End Function

		' Token: 0x04000611 RID: 1553
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GeoMap

		' Token: 0x04000612 RID: 1554
		Friend ShapeTag As Object
	End Class
End Namespace
