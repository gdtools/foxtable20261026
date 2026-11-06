Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003C4 RID: 964
	Friend Class CustomCheckBox
		Inherits C1CheckBox
		Implements O000O

		' Token: 0x06003D8F RID: 15759 RVA: 0x001AC9CC File Offset: 0x001AABCC
		Friend Sub New()
			AddHandler MyBase.Click, AddressOf Me.O_._O0.
			AddHandler MyBase.Enter, AddressOf Me.O.o0.
			AddHandler MyBase.GotFocus, AddressOf Me.O.00o_O.
			Me.O.00o_O. = 0
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
		End Sub

		' Token: 0x17000D82 RID: 3458
		' (get) Token: 0x06003D90 RID: 15760 RVA: 0x001ACA37 File Offset: 0x001AAC37
		' (set) Token: 0x06003D91 RID: 15761 RVA: 0x001ACA3F File Offset: 0x001AAC3F
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O.00o_O.
			End Get
			Set(value As BooleanEnum)
				Me.O.00o_O. = value
				Me.O.00o_O.()
			End Set
		End Property

		' Token: 0x17000D83 RID: 3459
		' (get) Token: 0x06003D92 RID: 15762 RVA: 0x001ACA4E File Offset: 0x001AAC4E
		' (set) Token: 0x06003D93 RID: 15763 RVA: 0x001ACA5B File Offset: 0x001AAC5B
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

		' Token: 0x06003D94 RID: 15764 RVA: 0x001ACA7C File Offset: 0x001AAC7C
		Friend Sub <<EMPTY_NAME>>()
			Select Case Me.[ReadOnly]
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

		' Token: 0x06003D95 RID: 15765 RVA: 0x001ACBDB File Offset: 0x001AADDB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 Then
				MyBase.DataBindings(0).WriteValue()
			End If
		End Sub

		' Token: 0x06003D96 RID: 15766 RVA: 0x001ACBFC File Offset: 0x001AADFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.00o_O.()
		End Sub

		' Token: 0x06003D97 RID: 15767 RVA: 0x001ACC04 File Offset: 0x001AAE04
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			Me.O.00o_O.()
		End Sub

		' Token: 0x06003D98 RID: 15768 RVA: 0x001ACC0C File Offset: 0x001AAE0C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.00o_O.()
		End Sub

		' Token: 0x17000D84 RID: 3460
		' (get) Token: 0x06003D99 RID: 15769 RVA: 0x001ACC14 File Offset: 0x001AAE14
		' (set) Token: 0x06003D9A RID: 15770 RVA: 0x001ACC1C File Offset: 0x001AAE1C
		Public Property isWritingValue As Boolean
			Get
				Return Me.O.00o_O.
			End Get
			Set(value As Boolean)
				Me.O.00o_O. = value
			End Set
		End Property

		' Token: 0x0400191A RID: 6426
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x0400191B RID: 6427
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
