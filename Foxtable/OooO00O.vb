Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000262 RID: 610
	Friend Class OooO00O
		Inherits C1DropDownControl
		Implements O000O

		' Token: 0x06001CEC RID: 7404 RVA: 0x000B764C File Offset: 0x000B584C
		Friend Sub New()
			MyBase.DropDownClosed += AddressOf Me.o.oO00_.
			MyBase.DropDownOpened += AddressOf Me.O0o____O_oO0.0.
			MyBase.DropDownOpening += AddressOf Me.Oo0_.oO.
			AddHandler MyBase.Enter, AddressOf Me.O_oO.0__00.
			AddHandler MyBase.GotFocus, AddressOf Me.O.0oo0_.
			AddHandler MyBase.KeyDown, AddressOf Me.o.oooOOooo.
			AddHandler MyBase.KeyPress, AddressOf Me.o.oooOOooo.
			AddHandler MyBase.Validated, AddressOf Me.o.oooOOooo.
			Me.O__00_Oo0.00__. = 0
			Me.O__00_Oo0.00__. = True
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
			Me.ShowUpDownButtons = False
		End Sub

		' Token: 0x06001CED RID: 7405 RVA: 0x000B778F File Offset: 0x000B598F
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.O__00_Oo0.00__.
		End Function

		' Token: 0x06001CEE RID: 7406 RVA: 0x000B7797 File Offset: 0x000B5997
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.O__00_Oo0.00__. = A_0
			ooO_0O.o_O0.O_.(Me, Me.OO.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001CEF RID: 7407 RVA: 0x000B77B8 File Offset: 0x000B59B8
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O__00_Oo0.00__.
		End Function

		' Token: 0x06001CF0 RID: 7408 RVA: 0x000B77C0 File Offset: 0x000B59C0
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O__00_Oo0.00__. = A_0
		End Sub

		' Token: 0x06001CF1 RID: 7409 RVA: 0x000B77C9 File Offset: 0x000B59C9
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.OO.0O00.
		End Function

		' Token: 0x06001CF2 RID: 7410 RVA: 0x000B77D1 File Offset: 0x000B59D1
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.OO.0O00. = A_0
		End Sub

		' Token: 0x06001CF3 RID: 7411 RVA: 0x000B77DC File Offset: 0x000B59DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(Me.o.oooOOooo.())
			If form.Pane.ActiveControl IsNot Nothing AndAlso TypeOf form.Pane.ActiveControl Is C1TextBox Then
				CType(form.Pane.ActiveControl, C1TextBox).UpdateValueWithCurrentText()
			End If
			form.Pane.Enabled = False
			If Me.O_oO.0__00.() Then
				Me.DropDownForm.Controls.Clear()
			End If
			Dim dropDownClosedEventArgs As DropDownClosedEventArgs = New DropDownClosedEventArgs(form, A_1.Selected)
			Dim a_ As String = "DropDownClosed_" + Conversions.ToString(form.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(Me.o.oooOOooo.()).O_0.O00o_00_O., a_, New Object() { dropDownClosedEventArgs }, True, MyBase.Name, False)
		End Sub

		' Token: 0x06001CF4 RID: 7412 RVA: 0x000B78B0 File Offset: 0x000B5AB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(Me.o.oooOOooo.())
			Dim formEventArgs As FormEventArgs = New FormEventArgs(form)
			Dim a_ As String = "DropDownOpened_" + Conversions.ToString(form.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(Me.o.oooOOooo.()).O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, MyBase.Name, False)
			If Me.DropDownForm IsNot Nothing Then
				Me.DropDownForm.Owner = Nothing
			End If
		End Sub

		' Token: 0x06001CF5 RID: 7413 RVA: 0x000B7938 File Offset: 0x000B5B38
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.DropDownForm.Controls.Count > 0 AndAlso Operators.CompareString(Me.o.oooOOooo.(), Me.a, True) <> 0 Then
				Me.DropDownForm.Controls.Clear()
			End If
			If Me.DropDownForm.Controls.Count = 0 Then
				Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(Me.o.oooOOooo.())
				If form.Pane Is Nothing OrElse form.Pane.IsDisposed Then
					form.o.0_o00O.()
				ElseIf form.Pane.FindForm() IsNot Me.DropDownForm Then
					form.Close()
					form.o.0_o00O.()
				End If
				form.Pane.ooOo.o_. = Me
				form.Pane.ooOo.o_. = Nothing
				form.Pane.O00O00o_oOo.o_. = Nothing
				If TypeOf MyBase.Parent Is O_oOooO_O Then
					Dim o_oOooO_O As O_oOooO_O = CType(MyBase.Parent, O_oOooO_O)
					form.Pane.ooOo.o_. = o_oOooO_O.o.0O_O0o_.
					form.Pane.O00O00o_oOo.o_. = o_oOooO_O.o.0O_O0o_..Cols(o_oOooO_O.Cols(o_oOooO_O.Col).Name)
				End If
				If TypeOf MyBase.Parent Is OooOo0___oO Then
					Dim oooOo0___oO As OooOo0___oO = CType(MyBase.Parent, OooOo0___oO)
					form.Pane.ooOo.o_. = oooOo0___oO.O.OOoo_o0.
					Dim text As String = oooOo0___oO.Rows(oooOo0___oO.Row).UserData.ToString()
					If oooOo0___oO.O.OOoo_o0..Cols.Contains(text) Then
						form.Pane.O00O00o_oOo.o_. = oooOo0___oO.O.OOoo_o0..Cols(text)
					End If
				End If
				Me.DropDownForm.Size = form.Pane.Size
				Me.DropDownForm.Controls.Add(form.Pane)
				form.Pane.Dock = DockStyle.Fill
				Me.a = Me.o.oooOOooo.()
				Dim formEventArgs As FormEventArgs = New FormEventArgs(OO_00oOO.Forms(Me.o.oooOOooo.()))
				Dim a_ As String = "AfterLoad_" + Conversions.ToString(form.O_o_.0o0__o0O.("Key"))
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(Me.o.oooOOooo.()).O_0.O00o_00_O., a_, New Object() { formEventArgs }, True, MyBase.Name, False)
			End If
			Dim form2 As Foxtable.WinForm.Form = OO_00oOO.Forms(Me.o.oooOOooo.())
			form2.Pane.Enabled = True
			Dim formEventArgs2 As FormEventArgs = New FormEventArgs(form2)
			Dim a_2 As String = "DropDownOpening_" + Conversions.ToString(form2.O_o_.0o0__o0O.("Key"))
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(Me.o.oooOOooo.()).O_0.O00o_00_O., a_2, New Object() { formEventArgs2 }, True, MyBase.Name, False)
		End Sub

		' Token: 0x06001CF6 RID: 7414 RVA: 0x000B7C00 File Offset: 0x000B5E00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.OO.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			If Me.DropDownForm IsNot Nothing AndAlso Me.DropDownForm.IsDisposed Then
				Me.DropDownForm = Nothing
				Me.OO.o.(Me.o.oooOOooo.())
			End If
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

		' Token: 0x1700067D RID: 1661
		' (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000B7D04 File Offset: 0x000B5F04
		' (set) Token: 0x06001CF8 RID: 7416 RVA: 0x000B7D2A File Offset: 0x000B5F2A
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

		' Token: 0x06001CF9 RID: 7417 RVA: 0x000B7D38 File Offset: 0x000B5F38
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.OO.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001CFA RID: 7418 RVA: 0x000B7D52 File Offset: 0x000B5F52
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.O__00_Oo0.00__.
		End Function

		' Token: 0x06001CFB RID: 7419 RVA: 0x000B7D5C File Offset: 0x000B5F5C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(A_0, Me.O__00_Oo0.00__., True) <> 0 OrElse Me.DropDownForm Is Nothing Then
				If Me.DropDownForm IsNot Nothing AndAlso Me.DropDownForm.Controls.Count > 0 Then
					Me.DropDownForm.Controls.Clear()
				End If
				Me.O__00_Oo0.00__. = A_0
				If Operators.CompareString(A_0, "", True) > 0 AndAlso OO_00oOO.Forms.Contains(A_0) Then
					If Me.DropDownForm Is Nothing Then
						Me.DropDownForm = New DropDownForm()
						Return
					End If
				ElseIf Me.DropDownForm IsNot Nothing Then
					Dim dropDownForm As Component = Me.DropDownForm
					Me.DropDownForm = Nothing
					dropDownForm.Dispose()
				End If
			End If
		End Sub

		' Token: 0x06001CFC RID: 7420 RVA: 0x000B7DFC File Offset: 0x000B5FFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.OO.o.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06001CFD RID: 7421 RVA: 0x000B7E50 File Offset: 0x000B6050
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Space AndAlso (Operators.CompareString(Me.Text, "", True) = 0 OrElse Not Me.O.0oo0_.()) Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
				Me.OpenDropDown()
				Return
			End If
			If A_1.KeyCode = Keys.Down OrElse A_1.KeyCode = Keys.Up Then
				If TypeOf MyBase.Parent Is O_oOooO_O AndAlso Not MyBase.DroppedDown AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					If A_1.KeyCode = Keys.Down Then
						SendKeys.Send("{DOWN}")
						Return
					End If
					SendKeys.Send("{UP}")
					Return
				End If
			ElseIf Not Me.O.0oo0_.() AndAlso A_1.KeyCode = Keys.Delete Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06001CFE RID: 7422 RVA: 0x000B7F12 File Offset: 0x000B6112
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.O.0oo0_.() Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x06001CFF RID: 7423 RVA: 0x000B7F2C File Offset: 0x000B612C
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

		' Token: 0x1700067E RID: 1662
		' (get) Token: 0x06001D00 RID: 7424 RVA: 0x000B7F97 File Offset: 0x000B6197
		' (set) Token: 0x06001D01 RID: 7425 RVA: 0x000B7F9F File Offset: 0x000B619F
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06001D02 RID: 7426 RVA: 0x000B7FAD File Offset: 0x000B61AD
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.oo0O_o.ooo0.
		End Function

		' Token: 0x06001D03 RID: 7427 RVA: 0x000B7FB5 File Offset: 0x000B61B5
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.oo0O_o.ooo0. = A_0
		End Sub

		' Token: 0x04000C2A RID: 3114
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000C2B RID: 3115
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C2C RID: 3116
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000C2D RID: 3117
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C2E RID: 3118
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C2F RID: 3119
		Private a As String
	End Class
End Namespace
