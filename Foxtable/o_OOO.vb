Imports System
Imports C1.FlexMap
Imports C1.Win.Interop

Namespace Foxtable
	' Token: 0x02000132 RID: 306
	Friend MustInherit Class o_OOO
		Inherits IMapProjection

		' Token: 0x06000EA4 RID: 3748 RVA: 0x000631C4 File Offset: 0x000613C4
		Public Overridable Function <<EMPTY_NAME>>() As Boolean
			Return False
		End Function

		' Token: 0x06000EA5 RID: 3749 RVA: 0x000631C7 File Offset: 0x000613C7
		Public Overridable Function <<EMPTY_NAME>>() As Boolean
			Return False
		End Function

		' Token: 0x06000EA6 RID: 3750 RVA: 0x000631CC File Offset: 0x000613CC
		Public Overridable Function <<EMPTY_NAME>>(A_0 As Point) As Point
			Dim x As Double = A_0.X
			Dim y As Double = A_0.Y
			Dim a_ As Double = x * 0.017453292519943295
			Dim a_2 As Double = y * 0.017453292519943295
			Dim point As Point = Me.Ooo0.0O__0000O.(a_, a_2)
			Dim num As Double = point.X / 6.2831853071795862 + 0.5
			Dim num2 As Double = -point.Y / 6.2831853071795862 + 0.5
			Return New Point(num, num2)
		End Function

		' Token: 0x06000EA7 RID: 3751 RVA: 0x0006324C File Offset: 0x0006144C
		Public Overridable Function <<EMPTY_NAME>>(A_0 As Point) As Point
			Dim a_ As Double = (A_0.X - 0.5) * 6.2831853071795862
			Dim a_2 As Double = -(A_0.Y - 0.5) * 6.2831853071795862
			Dim point As Point = Me.OO0o0_o._o_o.(a_, a_2)
			Dim x As Double = point.X
			Dim y As Double = point.Y
			Return New Point(x * 57.295779513082323, y * 57.295779513082323)
		End Function

		' Token: 0x06000EA8 RID: 3752
		Protected MustOverride Function <<EMPTY_NAME>>(A_0 As Double, A_1 As Double) As Point

		' Token: 0x06000EA9 RID: 3753
		Protected MustOverride Function <<EMPTY_NAME>>(A_0 As Double, A_1 As Double) As Point

		' Token: 0x040005C7 RID: 1479
		Public Const <<EMPTY_NAME>> As Double = 0.017453292519943295

		' Token: 0x040005C8 RID: 1480
		Public Const <<EMPTY_NAME>> As Double = 57.295779513082323

		' Token: 0x040005C9 RID: 1481
		Public Const <<EMPTY_NAME>> As Double = 6.2831853071795862

		' Token: 0x040005CA RID: 1482
		Public Const <<EMPTY_NAME>> As Double = 6.2831853071795862
	End Class
End Namespace
