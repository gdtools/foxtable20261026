Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003CE RID: 974
	Friend Class O_0oOoOo
		Inherits C1DropDownControl
		Implements O000O

		' Token: 0x06003E3F RID: 15935 RVA: 0x001AF658 File Offset: 0x001AD858
		Friend Sub New()
			MyBase.DropDownClosed += AddressOf Me.O_o_.O.
			AddHandler MyBase.KeyDown, AddressOf Me.O.o0O_.
			AddHandler MyBase.Enter, AddressOf Me.o000.O0_O_o.
			AddHandler MyBase.Leave, AddressOf Me.O_____0o0.__00.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.O.o0O_.
			AddHandler MyBase.GotFocus, AddressOf Me.o0ooO_O0_.O_.
			AddHandler MyBase.Validated, AddressOf Me.O.o_O.
			MyBase.DropDownOpened += AddressOf Me.O_.o0.
			AddHandler MyBase.KeyPress, AddressOf Me.O.o0O_.
			AddHandler MyBase.MouseEnter, AddressOf Me.O.o0O_.
			Me.oO._0o_O__. = 0
			Me.oO._0o_O__. = New Size(1, 1)
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			Me.DataType = GetType(DateTime)
			MyBase.DisplayFormat.FormatType = 2
			MyBase.DisplayFormat.CustomFormat = "yyyy-MM-dd"
			MyBase.EditFormat.FormatType = 2
			MyBase.EditFormat.CustomFormat = MyBase.DisplayFormat.CustomFormat
			MyBase.VerticalAlign = 1
			MyBase.EmptyAsNull = True
			Me.DateTimeInput = False
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.AutoTabWhenFilled = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.Padding = New Padding(1, 2, 1, 1)
			Me.O0O.O0.("0000-00-00")
			MyBase.ErrorInfo.ShowErrorMessage = False
			Me.ShowUpDownButtons = False
			MyBase.ImeMode = ImeMode.Close
			MyBase.AutoSize = False
		End Sub

		' Token: 0x06003E40 RID: 15936 RVA: 0x001AF811 File Offset: 0x001ADA11
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.oO._0o_O__.
		End Function

		' Token: 0x06003E41 RID: 15937 RVA: 0x001AF819 File Offset: 0x001ADA19
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.oO._0o_O__. = A_0
			ooO_0O.o_O0.O_.(Me, Me.O0O.O0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E42 RID: 15938 RVA: 0x001AF83A File Offset: 0x001ADA3A
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O.O0o0.
		End Function

		' Token: 0x06003E43 RID: 15939 RVA: 0x001AF842 File Offset: 0x001ADA42
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O.O0o0. = A_0
			If Me.oO._0o_O__. IsNot Nothing Then
				Me.oO._0o_O__..o.O_OO.().ShowWeekNumbers = True
			End If
		End Sub

		' Token: 0x06003E44 RID: 15940 RVA: 0x001AF864 File Offset: 0x001ADA64
		Public Function <<EMPTY_NAME>>() As Size
			Return Me.oO._0o_O__.
		End Function

		' Token: 0x06003E45 RID: 15941 RVA: 0x001AF86C File Offset: 0x001ADA6C
		Public Sub <<EMPTY_NAME>>(A_0 As Size)
			Me.oO._0o_O__. = A_0
			If Me.oO._0o_O__. IsNot Nothing Then
				Me.oO._0o_O__..o.O_OO.().CalendarDimensions = A_0
			End If
		End Sub

		' Token: 0x06003E46 RID: 15942 RVA: 0x001AF88E File Offset: 0x001ADA8E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			MyBase.UpdateValueWithCurrentText()
		End Sub

		' Token: 0x06003E47 RID: 15943 RVA: 0x001AF898 File Offset: 0x001ADA98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Space AndAlso Operators.CompareString(Me.Text, "", True) = 0 AndAlso Not MyBase.[ReadOnly] Then
				Me.Value = Strings.Format(DateTime.Now, MyBase.CustomFormat)
				MyBase.SelectionStart = Me.Text.Length
			End If
		End Sub

		' Token: 0x06003E48 RID: 15944 RVA: 0x001AF8F6 File Offset: 0x001ADAF6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.O0O.O0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			MyBase.MaskInfo.EditMask = Me.O0O.O0.()
			If MyBase.[ReadOnly] Then
				MyBase.DisplayFormat.FormatType = 2
			End If
		End Sub

		' Token: 0x17000D8F RID: 3471
		' (get) Token: 0x06003E49 RID: 15945 RVA: 0x001AF938 File Offset: 0x001ADB38
		' (set) Token: 0x06003E4A RID: 15946 RVA: 0x001AF96A File Offset: 0x001ADB6A
		Public Property Value As Object
			Get
				Dim result As Object
				If Not MyBase.UpdateValueWithCurrentText() Then
					result = Nothing
				ElseIf MyBase.Value Is DBNull.Value Then
					result = Nothing
				Else
					result = MyBase.Value
				End If
				Return result
			End Get
			Set(value As Object)
				MyBase.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003E4B RID: 15947 RVA: 0x001AF978 File Offset: 0x001ADB78
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.O0O.O0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E4C RID: 15948 RVA: 0x001AF992 File Offset: 0x001ADB92
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.oO._0o_O__.
		End Function

		' Token: 0x06003E4D RID: 15949 RVA: 0x001AF99A File Offset: 0x001ADB9A
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oO._0o_O__. = A_0
		End Sub

		' Token: 0x06003E4E RID: 15950 RVA: 0x001AF9A3 File Offset: 0x001ADBA3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.MaskInfo.EditMask = ""
		End Sub

		' Token: 0x06003E4F RID: 15951 RVA: 0x001AF9B5 File Offset: 0x001ADBB5
		Public Function <<EMPTY_NAME>>() As DateTimeFormatEnum
			Return Me.oO._0o_O__.
		End Function

		' Token: 0x06003E50 RID: 15952 RVA: 0x001AF9C0 File Offset: 0x001ADBC0
		Public Sub <<EMPTY_NAME>>(A_0 As DateTimeFormatEnum)
			Me.oO._0o_O__. = A_0
			Select Case A_0
				Case 0
					MyBase.DisplayFormat.CustomFormat = "yyyy-MM-dd"
					MyBase.EditFormat.CustomFormat = "yyyy-MM-dd"
					Me.O0O.O0.("0000-00-00")
					Return
				Case 1
					MyBase.DisplayFormat.CustomFormat = "HH:mm"
					MyBase.EditFormat.CustomFormat = "HH:mm"
					Me.O0O.O0.("00:00")
					Return
				Case 2
					MyBase.DisplayFormat.CustomFormat = "HH:mm:ss"
					MyBase.EditFormat.CustomFormat = "HH:mm:ss"
					Me.O0O.O0.("00:00:00")
					Return
				Case 3
					MyBase.DisplayFormat.CustomFormat = "yyyy-MM-dd HH:mm"
					MyBase.EditFormat.CustomFormat = "yyyy-MM-dd HH:mm"
					Me.O0O.O0.("0000-00-00 00:00")
					Return
				Case 4
					MyBase.DisplayFormat.CustomFormat = "yyyy-MM-dd HH:mm:ss"
					MyBase.EditFormat.CustomFormat = "yyyy-MM-dd HH:mm:ss"
					Me.O0O.O0.("0000-00-00 00:00:00")
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06003E51 RID: 15953 RVA: 0x001AFACC File Offset: 0x001ADCCC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab Then
				Dim dateTime As DateTime
				If Operators.CompareString(Me.Text, "", True) > 0 AndAlso Me.Text.Length < 10 AndAlso DateTime.TryParse(Me.Text, dateTime) Then
					Me.Value = dateTime
					Return
				End If
			ElseIf Me.O0O.O0.() Is Nothing Then
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
								Me.Value = dateTime2
								SendKeys.Send("{TAB}")
								Return
							End If
						ElseIf array2(2).Length = 2 Then
							SendKeys.Send("{TAB}")
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06003E52 RID: 15954 RVA: 0x001AFC88 File Offset: 0x001ADE88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.O0O.O0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E53 RID: 15955 RVA: 0x001AFCDC File Offset: 0x001ADEDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As String = "DataFormat_" + Conversions.ToString(MyBase.Tag)
			If oOO0oo_o0.o.O0o000_.(Me, a_) Then
				MyBase.DisplayFormat.FormatType = 1
				Return
			End If
			If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 Then
				MyBase.DisplayFormat.FormatType = 2
				Return
			End If
			MyBase.DisplayFormat.FormatType = 0
		End Sub

		' Token: 0x06003E54 RID: 15956 RVA: 0x001AFD48 File Offset: 0x001ADF48
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO._0o_O__..ClientSize = Me.oO._0o_O__..Controls(0).ClientSize
			If Me.Value Is Nothing Then
				Me.oO._0o_O__..o.O_OO.().SetDate(DateTime.Today)
			Else
				Me.oO._0o_O__..o.O_OO.().SetDate(Conversions.ToDate(Me.Value))
			End If
			Me.DropDownForm.Owner = Nothing
		End Sub

		' Token: 0x06003E55 RID: 15957 RVA: 0x001AFDBC File Offset: 0x001ADFBC
		Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
			If MyBase.[ReadOnly] AndAlso ((e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
				MyBase.FindForm().SelectNextControl(Me, True, False, True, True)
				MyBase.Focus()
				Return
			End If
			MyBase.OnKeyDown(e)
		End Sub

		' Token: 0x06003E56 RID: 15958 RVA: 0x001AFE18 File Offset: 0x001AE018
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If MyBase.[ReadOnly] Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x06003E57 RID: 15959 RVA: 0x001AFE30 File Offset: 0x001AE030
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO._0o_O__. Is Nothing Then
				Me.oO._0o_O__. = New oOo0o0__0()
				Me.DropDownForm = Me.oO._0o_O__.
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(Me), New Object() { Me.oO._0o_O__..o.O_OO.() })
				Me.oO._0o_O__..BackColor = Me.oO._0o_O__..o.O_OO.().TitleBackColor
				Me.oO._0o_O__..o.O_OO.().ShowWeekNumbers = Me.O0O.O0.()
				Me.oO._0o_O__..o.O_OO.().CalendarDimensions = Me.O.o0O_.()
			End If
		End Sub

		' Token: 0x17000D90 RID: 3472
		' (get) Token: 0x06003E58 RID: 15960 RVA: 0x001AFECF File Offset: 0x001AE0CF
		' (set) Token: 0x06003E59 RID: 15961 RVA: 0x001AFED7 File Offset: 0x001AE0D7
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003E5A RID: 15962 RVA: 0x001AFEE5 File Offset: 0x001AE0E5
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.oo0_O_Ooo._.
		End Function

		' Token: 0x06003E5B RID: 15963 RVA: 0x001AFEED File Offset: 0x001AE0ED
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.oo0_O_Ooo._. = A_0
		End Sub

		' Token: 0x04001948 RID: 6472
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001949 RID: 6473
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400194A RID: 6474
		Private <<EMPTY_NAME>> As DateTimeFormatEnum

		' Token: 0x0400194B RID: 6475
		Friend <<EMPTY_NAME>> As oOo0o0__0

		' Token: 0x0400194C RID: 6476
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400194D RID: 6477
		Private <<EMPTY_NAME>> As Size

		' Token: 0x0400194E RID: 6478
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
