Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003C9 RID: 969
	Friend Class CustomCheckedListBox
		Inherits CheckedListBox

		' Token: 0x06003DE6 RID: 15846 RVA: 0x001AD830 File Offset: 0x001ABA30
		Public Sub New()
			AddHandler MyBase.ItemCheck, AddressOf Me.OO_o_.o__.
			AddHandler MyBase.MouseDown, AddressOf Me.OO_o_.o__.
			AddHandler MyBase.SelectedIndexChanged, AddressOf Me.OO_o_.o__.
			Me.Oo0oO0_.o00. = 0
			Me.Oo0oO0_.o00. = ","
			Me.Oo0oO0_.o00. = New List(Of String)()
		End Sub

		' Token: 0x17000D87 RID: 3463
		' (get) Token: 0x06003DE7 RID: 15847 RVA: 0x001AD896 File Offset: 0x001ABA96
		' (set) Token: 0x06003DE8 RID: 15848 RVA: 0x001AD89E File Offset: 0x001ABA9E
		Friend Property [ReadOnly] As BooleanEnum
			Get
				Return Me.Oo0oO0_.o00.
			End Get
			Set(value As BooleanEnum)
				Me.Oo0oO0_.o00. = value
			End Set
		End Property

		' Token: 0x17000D88 RID: 3464
		' (get) Token: 0x06003DE9 RID: 15849 RVA: 0x001AD8A7 File Offset: 0x001ABAA7
		' (set) Token: 0x06003DEA RID: 15850 RVA: 0x001AD8AF File Offset: 0x001ABAAF
		Public Property Separator As String
			Get
				Return Me.Oo0oO0_.o00.
			End Get
			Set(value As String)
				Me.Oo0oO0_.o00. = Conversions.ToString(value(0))
			End Set
		End Property

		' Token: 0x17000D89 RID: 3465
		' (get) Token: 0x06003DEB RID: 15851 RVA: 0x001AD8C3 File Offset: 0x001ABAC3
		' (set) Token: 0x06003DEC RID: 15852 RVA: 0x001AD8E8 File Offset: 0x001ABAE8
		Public Property Value As String
			Get
				Return String.Join(Conversions.ToString(Me.Separator(0)), Me.Oo0oO0_.o00..ToArray())
			End Get
			Set(value As String)
				Me.Oo0oO0_.o00..Clear()
				Dim num As Integer = MyBase.Items.Count - 1
				For i As Integer = 0 To num
					MyBase.SetItemChecked(i, False)
				Next
				If Operators.CompareString(value, "", True) > 0 Then
					Dim list As List(Of String) = New List(Of String)()
					Dim dataView As DataView = Nothing
					If MyBase.DataSource IsNot Nothing Then
						dataView = CType(MyBase.DataSource, DataView)
					End If
					list.AddRange(value.Split(New Char() { Me.Separator(0) }))
					Try
						For Each right As String In list
							If dataView Is Nothing Then
								Dim num2 As Integer = MyBase.Items.Count - 1
								For j As Integer = 0 To num2
									If Operators.CompareString(MyBase.Items(j).ToString(), right, True) = 0 Then
										MyBase.SetItemChecked(j, True)
										Exit For
									End If
								Next
							Else
								Dim num3 As Integer = dataView.Count - 1
								For k As Integer = 0 To num3
									If Operators.CompareString(dataView(k)(MyBase.ValueMember).ToString(), right, True) = 0 Then
										MyBase.SetItemChecked(k, True)
										Exit For
									End If
								Next
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
			End Set
		End Property

		' Token: 0x17000D8A RID: 3466
		' (get) Token: 0x06003DED RID: 15853 RVA: 0x001ADA48 File Offset: 0x001ABC48
		' (set) Token: 0x06003DEE RID: 15854 RVA: 0x001ADA80 File Offset: 0x001ABC80
		Public Property SelectedValue2 As Object
			Get
				Dim result As Object
				If Me.SelectedIndex = -1 Then
					result = Nothing
				ElseIf MyBase.DataSource Is Nothing Then
					result = MyBase.SelectedItem.ToString()
				Else
					result = MyBase.SelectedValue
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.SelectedIndex = -1
					Return
				End If
				If MyBase.DataSource Is Nothing Then
					Me.SelectedIndex = MyBase.FindStringExact(value.ToString())
					Return
				End If
				Me.SelectedIndex = CType(MyBase.DataSource, DataView).Find(RuntimeHelpers.GetObjectValue(value))
			End Set
		End Property

		' Token: 0x06003DEF RID: 15855 RVA: 0x001ADAD0 File Offset: 0x001ABCD0
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			Select Case Me.[ReadOnly]
				Case 0
					If MyBase.DataBindings.Count = 0 Then
						result = True
					ElseIf MyBase.DataBindings.Count > 0 Then
						Dim bindingMemberInfo As BindingMemberInfo = MyBase.DataBindings(0).BindingMemberInfo
						If Not(TypeOf MyBase.DataBindings(0).DataSource Is O_0) Then
							result = True
						Else
							Dim text As String = CType(MyBase.DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
							If OO_00oOO.Tables.get_Contains(text) AndAlso OO_00oOO.Tables(text).Cols.Contains(bindingMemberInfo.BindingField) Then
								result = (OO_00oOO.Tables(text).Cols(bindingMemberInfo.BindingField).AllowEdit AndAlso (OO_00oOO.Tables(text).Current Is Nothing OrElse Not OO_00oOO.Tables(text).Current.Locked))
							Else
								bindingMemberInfo = Nothing
							End If
						End If
					End If
				Case 1
					result = False
				Case 2
					result = True
			End Select
			Return result
		End Function

		' Token: 0x06003DF0 RID: 15856 RVA: 0x001ADC01 File Offset: 0x001ABE01
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If(A_0.Msg <> 513 AndAlso A_0.Msg <> 515) OrElse Me.OO_o_.o__.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x06003DF1 RID: 15857 RVA: 0x001ADC2C File Offset: 0x001ABE2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim text As String = Nothing
			If MyBase.DataSource Is Nothing Then
				text = MyBase.Items(A_1.Index).ToString()
			ElseIf MyBase.ValueMember IsNot Nothing Then
				text = CType(MyBase.Items(A_1.Index), DataRowView)(MyBase.ValueMember).ToString()
			End If
			If text IsNot Nothing Then
				If A_1.NewValue = CheckState.Checked Then
					If Not Me.Oo0oO0_.o00..Contains(text) Then
						Me.Oo0oO0_.o00..Add(text)
						Return
					End If
				ElseIf Me.Oo0oO0_.o00..Contains(text) Then
					Me.Oo0oO0_.o00..Remove(text)
				End If
			End If
		End Sub

		' Token: 0x06003DF2 RID: 15858 RVA: 0x001ADCD0 File Offset: 0x001ABED0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If A_1.Button = MouseButtons.Left AndAlso Me.SelectedIndex >= 0 AndAlso Not MyBase.CheckOnClick AndAlso Me.SelectedIndex <> Me.Oo0oO0_.o00. Then
				Me.Oo0oO0_.o00. = Me.SelectedIndex
				Dim pt As Point = MyBase.PointToClient(Control.MousePosition)
				Dim itemRectangle As Rectangle = MyBase.GetItemRectangle(Me.SelectedIndex)
				If itemRectangle.Contains(pt) AndAlso pt.X < itemRectangle.X + 16 Then
					MyBase.SetItemChecked(Me.SelectedIndex, Not MyBase.GetItemChecked(Me.SelectedIndex))
				End If
			End If
		End Sub

		' Token: 0x06003DF3 RID: 15859 RVA: 0x001ADD66 File Offset: 0x001ABF66
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Oo0oO0_.o00. = Me.SelectedIndex
		End Sub

		' Token: 0x04001929 RID: 6441
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x0400192A RID: 6442
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400192B RID: 6443
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x0400192C RID: 6444
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
