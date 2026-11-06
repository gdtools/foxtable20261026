Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000147 RID: 327
	Public Class ChartMouseEventArgs
		Inherits ControlMouseEventArgs

		' Token: 0x06000F68 RID: 3944 RVA: 0x00068AB0 File Offset: 0x00066CB0
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As MouseButtons, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As Integer, A_6 As Foxtable.WinForm.Form)
			MyBase.New(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
			Me.OOO.o_oo0o0ooO. = -1
			Me.oOo_.Oo. = -1
			Me.OOO.o_oo0o0ooO. = CType(A_0, C1Chart)
			Dim num As Integer = -1
			Dim p As Point = System.Windows.Forms.Control.MousePosition
			p = Me.OOO.o_oo0o0ooO..PointToClient(p)
			If Me.OOO.o_oo0o0ooO..ChartGroups(0).CoordToDataIndex(p.X, p.Y, 2, Me.OOO.o_oo0o0ooO., Me.oOo_.Oo., num) AndAlso num > 6 Then
				Me.OOO.o_oo0o0ooO. = -1
				Me.oOo_.Oo. = -1
			End If
		End Sub

		' Token: 0x170002B8 RID: 696
		' (get) Token: 0x06000F69 RID: 3945 RVA: 0x00068B44 File Offset: 0x00066D44
		Public ReadOnly Property SeriesIndex As Integer
			Get
				Return Me.OOO.o_oo0o0ooO.
			End Get
		End Property

		' Token: 0x170002B9 RID: 697
		' (get) Token: 0x06000F6A RID: 3946 RVA: 0x00068B4C File Offset: 0x00066D4C
		Public ReadOnly Property PointsIndex As Integer
			Get
				Return Me.oOo_.Oo.
			End Get
		End Property

		' Token: 0x040005E9 RID: 1513
		Private <<EMPTY_NAME>> As C1Chart

		' Token: 0x040005EA RID: 1514
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005EB RID: 1515
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
