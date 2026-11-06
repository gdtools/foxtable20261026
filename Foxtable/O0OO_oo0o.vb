Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200006F RID: 111
	Friend Class O0OO_oo0o
		Inherits C1DateEdit

		' Token: 0x060003ED RID: 1005 RVA: 0x0000DB5F File Offset: 0x0000BD5F
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As DropDownCalendar
			Return Me.OOo0_._0_0o.
		End Function

		' Token: 0x060003EE RID: 1006 RVA: 0x0000DB67 File Offset: 0x0000BD67
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As DropDownCalendar)
			Me.OOo0_._0_0o. = A_0
		End Sub

		' Token: 0x060003EF RID: 1007 RVA: 0x0000DB70 File Offset: 0x0000BD70
		Public Sub New()
			MyBase.DropDownOpened += AddressOf Me.OOo0_._0_0o.
			AddHandler MyBase.KeyDown, AddressOf Me.OOo0_._0_0o.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.OOo0_._0_0o.
			Me.OOo0_._0_0o.(CType(Me.DropDownForm, DropDownCalendar))
			MyBase.VisualStyle = 1
			MyBase.FormatType = 2
			MyBase.CustomFormat = "yyyy-MM-dd"
			MyBase.EmptyAsNull = True
			Me.DateTimeInput = False
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.MaskInfo.EditMask = "0000-00-00"
			MyBase.ErrorInfo.ShowErrorMessage = False
			Me.ShowUpDownButtons = False
			MyBase.ImeMode = ImeMode.Close
			MyBase.Calendar.TodayText = "今日"
			MyBase.Calendar.ClearText = "清除"
		End Sub

		' Token: 0x060003F0 RID: 1008 RVA: 0x0000DC54 File Offset: 0x0000BE54
		Public Function <<EMPTY_NAME>>() As Boolean
			Return MyBase.Calendar.ShowWeekNumbers
		End Function

		' Token: 0x060003F1 RID: 1009 RVA: 0x0000DC61 File Offset: 0x0000BE61
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			MyBase.Calendar.ShowWeekNumbers = A_0
		End Sub

		' Token: 0x060003F2 RID: 1010 RVA: 0x0000DC6F File Offset: 0x0000BE6F
		Public Function <<EMPTY_NAME>>() As Size
			Return MyBase.Calendar.CalendarDimensions
		End Function

		' Token: 0x060003F3 RID: 1011 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		Public Sub <<EMPTY_NAME>>(A_0 As Size)
			MyBase.Calendar.CalendarDimensions = A_0
		End Sub

		' Token: 0x060003F4 RID: 1012 RVA: 0x0000DC8A File Offset: 0x0000BE8A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.DropDownForm.Owner = Nothing
		End Sub

		' Token: 0x060003F5 RID: 1013 RVA: 0x0000DC98 File Offset: 0x0000BE98
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
			ElseIf A_1.KeyCode = Keys.Space AndAlso Operators.CompareString(MyBase.Text, "", True) = 0 Then
				MyBase.Value = Strings.Format(DateTime.Now, MyBase.CustomFormat)
				MyBase.SelectionStart = MyBase.Text.Length
			End If
		End Sub

		' Token: 0x060003F6 RID: 1014 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab Then
				Dim dateTime As DateTime
				If Operators.CompareString(MyBase.Text, "", True) > 0 AndAlso MyBase.Text.Length < 10 AndAlso DateTime.TryParse(MyBase.Text, dateTime) Then
					MyBase.Value = dateTime
					Return
				End If
			Else
				If MyBase.Text.Length = 5 AndAlso A_1.KeyCode >= Keys.D2 AndAlso A_1.KeyCode <= Keys.D9 AndAlso MyBase.SelectionStart = 5 Then
					Me.SelectedText = "0"
					Return
				End If
				If MyBase.Text.Length = 6 AndAlso MyBase.SelectionStart = 6 AndAlso A_1.KeyCode = Keys.OemMinus Then
					Dim array As String() = MyBase.Text.Split(New Char() { "-"c })
					SendKeys.Send("{BS}")
					SendKeys.Send("0")
					SendKeys.Send(array(1))
					Return
				End If
				If MyBase.Text.Length = 8 AndAlso A_1.KeyCode >= Keys.D4 AndAlso A_1.KeyCode <= Keys.D9 AndAlso MyBase.SelectionStart = 8 Then
					Me.SelectedText = "0"
					Return
				End If
				If A_1.KeyCode = Keys.Right AndAlso Operators.CompareString(MyBase.Text, "", True) > 0 Then
					Dim array2 As String() = MyBase.Text.Split(New Char() { "-"c })
					If array2.Length = 3 Then
						If array2(2).Length >= 1 Then
							Dim dateTime2 As DateTime
							If DateTime.TryParse(MyBase.Text, dateTime2) Then
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

		' Token: 0x040000D8 RID: 216
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DropDownCalendar
	End Class
End Namespace
