Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000077 RID: 119
	Friend Class oo0O0o___O
		Inherits C1TextBox

		' Token: 0x0600040C RID: 1036 RVA: 0x0000E508 File Offset: 0x0000C708
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.oo.o_Oo.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.oo.o_Oo.
			MyBase.VisualStyle = 1
			Me.DataType = GetType(DateTime)
			MyBase.FormatType = 2
			MyBase.CustomFormat = "yyyy-MM-dd"
			MyBase.EmptyAsNull = True
			Me.DateTimeInput = False
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.MaskInfo.EditMask = "0000-00-00"
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.ImeMode = ImeMode.Close
		End Sub

		' Token: 0x0600040D RID: 1037 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
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
				MyBase.Value = DateTime.Today
				MyBase.SelectionStart = Me.Text.Length
			End If
		End Sub

		' Token: 0x0600040E RID: 1038 RVA: 0x0000E66C File Offset: 0x0000C86C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab Then
				Dim dateTime As DateTime
				If Operators.CompareString(Me.Text, "", True) > 0 AndAlso Me.Text.Length < 10 AndAlso DateTime.TryParse(Me.Text, dateTime) Then
					MyBase.Value = dateTime
					Return
				End If
			Else
				If Me.Text.Length = 5 AndAlso A_1.KeyCode >= Keys.D2 AndAlso A_1.KeyCode <= Keys.D9 AndAlso MyBase.SelectionStart = 5 Then
					Me.SelectedText = "0"
					Return
				End If
				If Me.Text.Length = 6 AndAlso MyBase.SelectionStart = 6 AndAlso A_1.KeyCode = Keys.OemMinus Then
					Dim array As String() = Me.Text.Split(New Char() { "-"c })
					SendKeys.Send("{BS}")
					SendKeys.Send("0")
					SendKeys.Send(array(1))
					Return
				End If
				If Me.Text.Length = 8 AndAlso A_1.KeyCode >= Keys.D4 AndAlso A_1.KeyCode <= Keys.D9 AndAlso MyBase.SelectionStart = 8 Then
					Me.SelectedText = "0"
					Return
				End If
				If A_1.KeyCode = Keys.Right AndAlso Operators.CompareString(Me.Text, "", True) > 0 Then
					Dim array2 As String() = Me.Text.Split(New Char() { "-"c })
					If array2.Length = 3 Then
						If array2(2).Length >= 1 Then
							Dim dateTime2 As DateTime
							If DateTime.TryParse(Me.Text, dateTime2) Then
								MyBase.Value = dateTime2
								If array2(2).Length = 1 Then
									SendKeys.Send("{TAB}")
									Return
								End If
							End If
						Else
							Dim length As Integer = array2(2).Length
						End If
					End If
				End If
			End If
		End Sub
	End Class
End Namespace
