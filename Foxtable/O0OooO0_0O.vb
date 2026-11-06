Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000075 RID: 117
	Friend Class O0OooO0_0O
		Inherits C1TextBox

		' Token: 0x06000406 RID: 1030 RVA: 0x0000E180 File Offset: 0x0000C380
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.Ooo._0oO.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.Ooo._0oO.
			MyBase.VisualStyle = 1
			Me.DataType = GetType(DateTime)
			MyBase.FormatType = 2
			MyBase.CustomFormat = "HH:mm:ss"
			MyBase.EmptyAsNull = True
			Me.DateTimeInput = False
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.MaskInfo.EditMask = "00:00:00"
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.ImeMode = ImeMode.Close
		End Sub

		' Token: 0x06000407 RID: 1031 RVA: 0x0000E22C File Offset: 0x0000C42C
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

		' Token: 0x06000408 RID: 1032 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			Dim dateTime As DateTime
			If(A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab) AndAlso Operators.CompareString(Me.Text, "", True) > 0 AndAlso Me.Text.Length < 10 AndAlso DateTime.TryParse(Me.Text, dateTime) Then
				MyBase.Value = dateTime
			End If
		End Sub
	End Class
End Namespace
