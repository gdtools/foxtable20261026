Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000268 RID: 616
	Friend Class O0O_O0
		Inherits C1TextBox
		Implements O000O

		' Token: 0x06001D5F RID: 7519 RVA: 0x000BA6F0 File Offset: 0x000B88F0
		Public Sub New()
			AddHandler MyBase.Enter, AddressOf Me.o_0.00o0.
			AddHandler MyBase.GotFocus, AddressOf Me.O0.oooOo0_.
			AddHandler MyBase.Validated, AddressOf Me.oO0_.o.
			AddHandler MyBase.MultilineChanged, AddressOf Me.ooO.Oo000_.
			AddHandler MyBase.KeyDown, AddressOf Me.ooO.Oo000_.
			Me.O0oO_OOOOo0o.o. = 0
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
		End Sub

		' Token: 0x06001D60 RID: 7520 RVA: 0x000BA7EF File Offset: 0x000B89EF
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.O0oO_OOOOo0o.o.
		End Function

		' Token: 0x06001D61 RID: 7521 RVA: 0x000BA7F7 File Offset: 0x000B89F7
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			MyBase.UpdateValueWithCurrentText()
			Me.O0oO_OOOOo0o.o. = A_0
			ooO_0O.o_O0.O_.(Me, Me.O0oO_OOOOo0o.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001D62 RID: 7522 RVA: 0x000BA820 File Offset: 0x000B8A20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.O0oO_OOOOo0o.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			If MyBase.[ReadOnly] Then
				If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 AndAlso Me.DataType Is GetType(DateTime) Then
					MyBase.DisplayFormat.FormatType = 2
					Return
				End If
				MyBase.DisplayFormat.FormatType = 0
				Return
			Else
				If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 AndAlso Me.DataType Is GetType(DateTime) Then
					MyBase.EditFormat.FormatType = 2
					MyBase.EditFormat.CustomFormat = MyBase.DisplayFormat.CustomFormat
					Return
				End If
				MyBase.EditFormat.FormatType = 0
				MyBase.EditFormat.CustomFormat = ""
				Return
			End If
		End Sub

		' Token: 0x17000698 RID: 1688
		' (get) Token: 0x06001D63 RID: 7523 RVA: 0x000BA8FC File Offset: 0x000B8AFC
		' (set) Token: 0x06001D64 RID: 7524 RVA: 0x000BA922 File Offset: 0x000B8B22
		Public Property Value As Object
			Get
				Dim result As Object
				If MyBase.Value Is DBNull.Value Then
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

		' Token: 0x06001D65 RID: 7525 RVA: 0x000BA930 File Offset: 0x000B8B30
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.O0oO_OOOOo0o.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001D66 RID: 7526 RVA: 0x000BA94C File Offset: 0x000B8B4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.O0oO_OOOOo0o.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001D67 RID: 7527 RVA: 0x000BA9A0 File Offset: 0x000B8BA0
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

		' Token: 0x06001D68 RID: 7528 RVA: 0x000BAA0B File Offset: 0x000B8C0B
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Multiline Then
				MyBase.VerticalAlign = 0
				Return
			End If
			MyBase.VerticalAlign = 1
		End Sub

		' Token: 0x06001D69 RID: 7529 RVA: 0x000BAA24 File Offset: 0x000B8C24
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso MyBase.FindForm().[GetType]() Is GetType(DropDownForm) AndAlso Me.Multiline AndAlso A_1.KeyCode = Keys.[Return] Then
				Me.SelectedText = vbCrLf
				A_1.Handled = True
				A_1.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x17000699 RID: 1689
		' (get) Token: 0x06001D6A RID: 7530 RVA: 0x000BAA7B File Offset: 0x000B8C7B
		' (set) Token: 0x06001D6B RID: 7531 RVA: 0x000BAA83 File Offset: 0x000B8C83
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06001D6C RID: 7532 RVA: 0x000BAA91 File Offset: 0x000B8C91
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.O0oO_OOOOo0o.o.
		End Function

		' Token: 0x06001D6D RID: 7533 RVA: 0x000BAA99 File Offset: 0x000B8C99
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.O0oO_OOOOo0o.o. = A_0
		End Sub

		' Token: 0x04000C58 RID: 3160
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000C59 RID: 3161
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
