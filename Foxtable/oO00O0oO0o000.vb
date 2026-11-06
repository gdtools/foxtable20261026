Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003D5 RID: 981
	Friend Class oO00O0oO0o000
		Inherits RadioButton
		Implements O000O

		' Token: 0x06003EAB RID: 16043 RVA: 0x001B1A84 File Offset: 0x001AFC84
		Public Sub New()
			AddHandler MyBase.Click, AddressOf Me.o._0_0.
			AddHandler MyBase.Enter, AddressOf Me.O.0o00O.
			AddHandler MyBase.GotFocus, AddressOf Me.O00_o0_.O__oo.
			Me.oo0oO_O.oooO0O. = 0
		End Sub

		' Token: 0x06003EAC RID: 16044 RVA: 0x001B1AD4 File Offset: 0x001AFCD4
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.oo0oO_O.oooO0O.
		End Function

		' Token: 0x06003EAD RID: 16045 RVA: 0x001B1ADC File Offset: 0x001AFCDC
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.oo0oO_O.oooO0O. = A_0
			Me.O00_o0_.O__oo.()
		End Sub

		' Token: 0x17000DA1 RID: 3489
		' (get) Token: 0x06003EAE RID: 16046 RVA: 0x001B1AEB File Offset: 0x001AFCEB
		' (set) Token: 0x06003EAF RID: 16047 RVA: 0x001B1AF8 File Offset: 0x001AFCF8
		Public Property Checked As Object
			Get
				Return MyBase.Checked
			End Get
			Set(value As Object)
				If value Is DBNull.Value Then
					value = False
				End If
				MyBase.Checked = Conversions.ToBoolean(value)
			End Set
		End Property

		' Token: 0x06003EB0 RID: 16048 RVA: 0x001B1B18 File Offset: 0x001AFD18
		Friend Sub <<EMPTY_NAME>>()
			Select Case Me.O00_o0_.O__oo.()
				Case 0
					If MyBase.DataBindings.Count = 0 Then
						MyBase.AutoCheck = True
						Return
					End If
					If MyBase.DataBindings.Count > 0 Then
						Dim bindingMemberInfo As BindingMemberInfo = MyBase.DataBindings(0).BindingMemberInfo
						If TypeOf MyBase.DataBindings(0).DataSource Is O_0 Then
							Dim text As String = CType(MyBase.DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
							If OO_00oOO.Tables.get_Contains(text) AndAlso OO_00oOO.Tables(text).Cols.Contains(bindingMemberInfo.BindingField) Then
								If Not OO_00oOO.Tables(text).AllowEdit Then
									MyBase.AutoCheck = False
								ElseIf Not OO_00oOO.Tables(text).Cols(bindingMemberInfo.BindingField).AllowEdit Then
									MyBase.AutoCheck = False
								ElseIf OO_00oOO.Tables(text).Current IsNot Nothing AndAlso OO_00oOO.Tables(text).Current.Locked Then
									MyBase.AutoCheck = False
								Else
									MyBase.AutoCheck = True
								End If
							End If
							bindingMemberInfo = Nothing
							Return
						End If
					End If
				Case 1
					MyBase.AutoCheck = False
					Return
				Case 2
					MyBase.AutoCheck = True
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06003EB1 RID: 16049 RVA: 0x001B1C77 File Offset: 0x001AFE77
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 Then
				MyBase.DataBindings(0).WriteValue()
			End If
		End Sub

		' Token: 0x06003EB2 RID: 16050 RVA: 0x001B1C98 File Offset: 0x001AFE98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O00_o0_.O__oo.()
		End Sub

		' Token: 0x06003EB3 RID: 16051 RVA: 0x001B1CA0 File Offset: 0x001AFEA0
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			Me.O00_o0_.O__oo.()
		End Sub

		' Token: 0x06003EB4 RID: 16052 RVA: 0x001B1CA8 File Offset: 0x001AFEA8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O00_o0_.O__oo.()
		End Sub

		' Token: 0x06003EB5 RID: 16053 RVA: 0x001B1CB0 File Offset: 0x001AFEB0
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.oo0oO_O.oooO0O.
		End Function

		' Token: 0x06003EB6 RID: 16054 RVA: 0x001B1CB8 File Offset: 0x001AFEB8
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.oo0oO_O.oooO0O. = A_0
		End Sub

		' Token: 0x0400196D RID: 6509
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x0400196E RID: 6510
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
