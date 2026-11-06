Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000076 RID: 118
	Friend Class o0o0OO
		Inherits C1TextBox

		' Token: 0x06000409 RID: 1033 RVA: 0x0000E344 File Offset: 0x0000C544
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.oo.o_Oo.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.oo.o_Oo.
			MyBase.VisualStyle = 1
			Me.DataType = GetType(DateTime)
			MyBase.FormatType = 2
			MyBase.CustomFormat = "HH:mm"
			MyBase.EmptyAsNull = True
			Me.DateTimeInput = False
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.MaskInfo.EditMask = "00:00"
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.ImeMode = ImeMode.Close
		End Sub

		' Token: 0x0600040A RID: 1034 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Down Then
				If TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					SendKeys.Send("{DOWN}")
					Return
				End If
			ElseIf A_1.KeyCode = Keys.Up Then
				If TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					SendKeys.Send("{UP}")
					Return
				End If
			ElseIf A_1.KeyCode = Keys.Space AndAlso Operators.CompareString(Me.Text, "", True) = 0 Then
				MyBase.Value = DateTime.Now
				MyBase.SelectionStart = Me.Text.Length
			End If
		End Sub

		' Token: 0x0600040B RID: 1035 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			Dim dateTime As DateTime
			If(A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab) AndAlso Operators.CompareString(Me.Text, "", True) > 0 AndAlso Me.Text.Length < 10 AndAlso DateTime.TryParse(Me.Text, dateTime) Then
				MyBase.Value = dateTime
			End If
		End Sub
	End Class
End Namespace
