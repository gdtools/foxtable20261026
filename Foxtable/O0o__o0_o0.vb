Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x02000078 RID: 120
	Friend Class O0o__o0_o0
		Inherits C1TextBox

		' Token: 0x0600040F RID: 1039 RVA: 0x0000E81C File Offset: 0x0000CA1C
		Public Sub New()
			AddHandler MyBase.KeyPress, AddressOf Me.oo.o_Oo.
			MyBase.VisualStyle = 1
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.ErrorInfo.ShowErrorMessage = False
			Me.Multiline = True
			MyBase.InitialSelection = 0
		End Sub

		' Token: 0x06000410 RID: 1040 RVA: 0x0000E878 File Offset: 0x0000CA78
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If A_1.KeyChar = "。"c AndAlso (Me.DataType Is GetType(Double) OrElse Me.DataType Is GetType(Single) OrElse Me.DataType Is GetType(Decimal)) Then
				A_1.KeyChar = "."c
			End If
		End Sub
	End Class
End Namespace
