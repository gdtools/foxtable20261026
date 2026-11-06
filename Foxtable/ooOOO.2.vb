Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003D1 RID: 977
	Friend Class ooOOO
		Inherits C1NumericEdit
		Implements O000O

		' Token: 0x06003E6E RID: 15982 RVA: 0x001B04A4 File Offset: 0x001AE6A4
		Friend Sub New()
			MyBase.DropDownOpened += AddressOf Me.OoOoo.0_.
			AddHandler MyBase.Enter, AddressOf Me.o__o00o___O.oO.
			AddHandler MyBase.GotFocus, AddressOf Me.o_0_0_._.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.OO_o_O_.o.
			AddHandler MyBase.Validated, AddressOf Me.OO_o_O_.o.
			Me.o00.Oo_OO0. = 0
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			MyBase.AutoSize = False
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.MaskInfo.AutoTabWhenFilled = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.ExitOnLeftRightKey = 3
			MyBase.ExitOnLastChar = True
			MyBase.VerticalAlign = 1
			MyBase.Padding = New Padding(1, 2, 1, 1)
			MyBase.ImeMode = ImeMode.Close
		End Sub

		' Token: 0x06003E6F RID: 15983 RVA: 0x001B059D File Offset: 0x001AE79D
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.o00.Oo_OO0.
		End Function

		' Token: 0x06003E70 RID: 15984 RVA: 0x001B05A5 File Offset: 0x001AE7A5
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.o00.Oo_OO0. = A_0
			ooO_0O.o_O0.O_.(Me, Me.o00.Oo_OO0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E71 RID: 15985 RVA: 0x001B05C6 File Offset: 0x001AE7C6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.DropDownForm.Owner = Nothing
		End Sub

		' Token: 0x06003E72 RID: 15986 RVA: 0x001B05D4 File Offset: 0x001AE7D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.o00.Oo_OO0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			If MyBase.[ReadOnly] Then
				MyBase.DisplayFormat.FormatType = 0
				Return
			End If
			MyBase.EditFormat.FormatType = 0
			MyBase.EditFormat.CustomFormat = ""
		End Sub

		' Token: 0x17000D94 RID: 3476
		' (get) Token: 0x06003E73 RID: 15987 RVA: 0x001B062C File Offset: 0x001AE82C
		' (set) Token: 0x06003E74 RID: 15988 RVA: 0x001B0652 File Offset: 0x001AE852
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

		' Token: 0x06003E75 RID: 15989 RVA: 0x001B0660 File Offset: 0x001AE860
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.o00.Oo_OO0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E76 RID: 15990 RVA: 0x001B067C File Offset: 0x001AE87C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.o00.Oo_OO0.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E77 RID: 15991 RVA: 0x001B06D0 File Offset: 0x001AE8D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If A_1.KeyCode = Keys.Right AndAlso MyBase.SelectionStart = MyBase.Text.Length Then
				SendKeys.Send("{TAB}")
				Return
			End If
			If A_1.KeyCode = Keys.Left AndAlso MyBase.SelectionStart = 0 AndAlso Me.SelectionLength = 0 Then
				SendKeys.Send("+{TAB}")
			End If
		End Sub

		' Token: 0x06003E78 RID: 15992 RVA: 0x001B072C File Offset: 0x001AE92C
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

		' Token: 0x17000D95 RID: 3477
		' (get) Token: 0x06003E79 RID: 15993 RVA: 0x001B0797 File Offset: 0x001AE997
		' (set) Token: 0x06003E7A RID: 15994 RVA: 0x001B079F File Offset: 0x001AE99F
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003E7B RID: 15995 RVA: 0x001B07AD File Offset: 0x001AE9AD
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.o00.Oo_OO0.
		End Function

		' Token: 0x06003E7C RID: 15996 RVA: 0x001B07B5 File Offset: 0x001AE9B5
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.o00.Oo_OO0. = A_0
		End Sub

		' Token: 0x04001955 RID: 6485
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001956 RID: 6486
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
