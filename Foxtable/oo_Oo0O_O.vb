Imports System
Imports C1.Win.Interop

Namespace Foxtable
	' Token: 0x02000133 RID: 307
	Friend Class oo_Oo0O_O
		Inherits o_OOO

		' Token: 0x06000EAB RID: 3755 RVA: 0x000632D0 File Offset: 0x000614D0
		Protected Overridable Function <<EMPTY_NAME>>(A_0 As Double, A_1 As Double) As Point
			Dim num As Double = Math.Sin(A_1) * 3.1415926535897931
			Return New Point(A_0, num)
		End Function

		' Token: 0x06000EAC RID: 3756 RVA: 0x000632F8 File Offset: 0x000614F8
		Protected Overridable Function <<EMPTY_NAME>>(A_0 As Double, A_1 As Double) As Point
			Dim num As Double = A_1 / 3.1415926535897931
			num = Math.Max(-1.0, Math.Min(1.0, num))
			Dim num2 As Double = Math.Asin(num)
			Return New Point(A_0, num2)
		End Function
	End Class
End Namespace
