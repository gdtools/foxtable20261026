Imports System
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000079 RID: 121
	Friend Class Oooo
		Inherits C1TextBox

		' Token: 0x06000411 RID: 1041 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		Public Sub New()
			MyBase.Formatting += AddressOf Me.oo.o_Oo.
			MyBase.Parsing += AddressOf Me.oo.o_Oo.
			MyBase.VisualStyle = 1
			MyBase.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			Me.Multiline = True
			MyBase.InitialSelection = 0
			Me.DataType = GetType(String)
			Me.DateTimeInput = False
			Me.NumericInput = False
			MyBase.ParseInfo.FormatType = 1
			MyBase.FormatType = 1
		End Sub

		' Token: 0x06000412 RID: 1042 RVA: 0x0000E960 File Offset: 0x0000CB60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormatEventArgs)
			If A_1.Value IsNot Nothing Then
				Dim text As String = ""
				If O_O0OO.o.00O_O.(Conversions.ToDouble(A_1.Value), text) Then
					A_1.Text = text
				End If
			End If
		End Sub

		' Token: 0x06000413 RID: 1043 RVA: 0x0000E998 File Offset: 0x0000CB98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ParseEventArgs)
			Dim num As Double
			If A_1.Text IsNot Nothing AndAlso O_O0OO.Oo0.OoOo.(Me.Text, num) Then
				A_1.Value = num
			End If
		End Sub
	End Class
End Namespace
