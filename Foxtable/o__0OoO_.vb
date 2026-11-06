Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000264 RID: 612
	Friend Class o__0OoO_
		Inherits C1TextBox
		Implements O000O

		' Token: 0x06001D07 RID: 7431 RVA: 0x000B8054 File Offset: 0x000B6254
		Public Sub New()
			AddHandler MyBase.Enter, AddressOf Me.Oo_oO._0_.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.O0oo_oo.0.
			MyBase.Formatting += AddressOf Me.O0oo_oo.0.
			MyBase.Parsing += AddressOf Me.O0oo_oo.0.
			AddHandler MyBase.GotFocus, AddressOf Me.O0oo_oo.0.
			Me.O_o.0. = 0
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.AutoTabWhenFilled = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.AutoSize = False
			MyBase.VerticalAlign = 1
			MyBase.Padding = New Padding(1, 2, 1, 1)
			Me.DateTimeInput = False
			Me.NumericInput = False
			MyBase.ExitOnLeftRightKey = 3
			MyBase.ExitOnLastChar = True
			Me.DataType = GetType(String)
			MyBase.ParseInfo.FormatType = 1
			MyBase.FormatType = 1
		End Sub

		' Token: 0x06001D08 RID: 7432 RVA: 0x000B8176 File Offset: 0x000B6376
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.O_o.0.
		End Function

		' Token: 0x06001D09 RID: 7433 RVA: 0x000B817E File Offset: 0x000B637E
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.O_o.0. = A_0
			ooO_0O.o_O0.O_.(Me, Me.O_o.0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001D0A RID: 7434 RVA: 0x000B819F File Offset: 0x000B639F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.O_o.0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x17000680 RID: 1664
		' (get) Token: 0x06001D0B RID: 7435 RVA: 0x000B81BC File Offset: 0x000B63BC
		' (set) Token: 0x06001D0C RID: 7436 RVA: 0x000B8220 File Offset: 0x000B6420
		Public Property Value As Object
			Get
				Dim result As Object
				Dim num As Double
				If MyBase.Value Is DBNull.Value Then
					result = Nothing
				ElseIf Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(MyBase.Value)) Then
					result = Conversions.ToDouble(MyBase.Value)
				ElseIf O_O0OO.Oo0.OoOo.(MyBase.Value.ToString(), num) Then
					result = num
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing OrElse Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(value)) Then
					MyBase.Value = RuntimeHelpers.GetObjectValue(value)
					Return
				End If
				Dim num As Double
				If O_O0OO.Oo0.OoOo.(value.ToString(), num) Then
					MyBase.Value = num
				End If
			End Set
		End Property

		' Token: 0x06001D0D RID: 7437 RVA: 0x000B8265 File Offset: 0x000B6465
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.O_o.0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001D0E RID: 7438 RVA: 0x000B8280 File Offset: 0x000B6480
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If A_1.KeyCode = Keys.Right AndAlso MyBase.SelectionStart = Me.Text.Length Then
				SendKeys.Send("{TAB}")
				Return
			End If
			If A_1.KeyCode = Keys.Left AndAlso MyBase.SelectionStart = 0 AndAlso Me.SelectionLength = 0 Then
				SendKeys.Send("+{TAB}")
			End If
		End Sub

		' Token: 0x06001D0F RID: 7439 RVA: 0x000B82DC File Offset: 0x000B64DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormatEventArgs)
			If A_1.Value IsNot Nothing Then
				Dim text As String = ""
				If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(A_1.Value)) AndAlso O_O0OO.o.00O_O.(Conversions.ToDouble(A_1.Value), text) Then
					A_1.Text = text
					Return
				End If
				Dim num As Double
				If A_1.Value IsNot Nothing AndAlso TypeOf A_1.Value Is String AndAlso O_O0OO.Oo0.OoOo.(A_1.Value.ToString(), num) Then
					A_1.Text = A_1.Value.ToString()
				End If
			End If
		End Sub

		' Token: 0x06001D10 RID: 7440 RVA: 0x000B8360 File Offset: 0x000B6560
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ParseEventArgs)
			Dim num As Double
			If A_1.Text IsNot Nothing AndAlso O_O0OO.Oo0.OoOo.(Me.Text, num) Then
				A_1.Value = num
			End If
		End Sub

		' Token: 0x06001D11 RID: 7441 RVA: 0x000B8390 File Offset: 0x000B6590
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.O_o.0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x17000681 RID: 1665
		' (get) Token: 0x06001D12 RID: 7442 RVA: 0x000B83E3 File Offset: 0x000B65E3
		' (set) Token: 0x06001D13 RID: 7443 RVA: 0x000B83EB File Offset: 0x000B65EB
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06001D14 RID: 7444 RVA: 0x000B83F9 File Offset: 0x000B65F9
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.O_o.0.
		End Function

		' Token: 0x06001D15 RID: 7445 RVA: 0x000B8401 File Offset: 0x000B6601
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.O_o.0. = A_0
		End Sub

		' Token: 0x04000C31 RID: 3121
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000C32 RID: 3122
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
