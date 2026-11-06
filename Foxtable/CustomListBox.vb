Imports System
Imports System.Data
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003D0 RID: 976
	Friend Class CustomListBox
		Inherits System.Windows.Forms.ListBox

		' Token: 0x06003E63 RID: 15971 RVA: 0x001B0068 File Offset: 0x001AE268
		Public Sub New()
			AddHandler MyBase.DrawItem, AddressOf Me.OOo.0_0.
			AddHandler MyBase.FontChanged, AddressOf Me.OOo.0_0.
			Me.O.00_Oo. = 0
			Me.O.00_Oo. = 3
			Me.O.00_Oo. = New StringFormat()
			MyBase.IntegralHeight = False
			Me.DrawMode = DrawMode.OwnerDrawFixed
			Me.O.00_Oo..LineAlignment = StringAlignment.Center
			Me.O.00_Oo..Alignment = StringAlignment.Near
			Me.O.00_Oo..FormatFlags = (Me.O.00_Oo..FormatFlags Or StringFormatFlags.NoWrap)
		End Sub

		' Token: 0x17000D91 RID: 3473
		' (get) Token: 0x06003E64 RID: 15972 RVA: 0x001B00FA File Offset: 0x001AE2FA
		' (set) Token: 0x06003E65 RID: 15973 RVA: 0x001B0102 File Offset: 0x001AE302
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O.00_Oo.
			End Get
			Set(value As BooleanEnum)
				Me.O.00_Oo. = value
			End Set
		End Property

		' Token: 0x17000D92 RID: 3474
		' (get) Token: 0x06003E66 RID: 15974 RVA: 0x001B010C File Offset: 0x001AE30C
		' (set) Token: 0x06003E67 RID: 15975 RVA: 0x001B0144 File Offset: 0x001AE344
		Public Property Value As Object
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

		' Token: 0x06003E68 RID: 15976 RVA: 0x001B0194 File Offset: 0x001AE394
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

		' Token: 0x06003E69 RID: 15977 RVA: 0x001B02C5 File Offset: 0x001AE4C5
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If(A_0.Msg <> 513 AndAlso A_0.Msg <> 515) OrElse Me.OOo.0_0.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x17000D93 RID: 3475
		' (get) Token: 0x06003E6A RID: 15978 RVA: 0x001B02F0 File Offset: 0x001AE4F0
		' (set) Token: 0x06003E6B RID: 15979 RVA: 0x001B02F8 File Offset: 0x001AE4F8
		Friend Property ItemSpacing As Integer
			Get
				Return Me.O.00_Oo.
			End Get
			Set(value As Integer)
				Me.O.00_Oo. = value
				Me.ItemHeight = CInt(Math.Ceiling(CDbl((Me.Font.Size / 9F * 12F)))) + value
			End Set
		End Property

		' Token: 0x06003E6C RID: 15980 RVA: 0x001B0328 File Offset: 0x001AE528
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawItemEventArgs)
			If A_1.Index >= 0 Then
				A_1.DrawBackground()
				A_1.DrawFocusRectangle()
				Dim s As String
				If MyBase.DataSource IsNot Nothing Then
					Dim listItemFormatEventArgs As ListItemFormatEventArgs = New ListItemFormatEventArgs(Me, Me.O.00_Oo., CType(MyBase.Items(A_1.Index), DataRowView))
					Dim a_ As String = "ListItemFormat_" + Conversions.ToString(MyBase.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.O.00_Oo..O_0.O00o_00_O., a_, New Object() { listItemFormatEventArgs }, False, Me.O.00_Oo..mmname + "," + MyBase.Name, False)
					If Operators.CompareString(listItemFormatEventArgs.Text, "", True) > 0 Then
						s = listItemFormatEventArgs.Text
					Else
						Dim dataRowView As DataRowView = CType(MyBase.Items(A_1.Index), DataRowView)
						If Operators.CompareString(MyBase.DisplayMember, "", True) > 0 Then
							s = dataRowView(MyBase.DisplayMember).ToString()
						Else
							s = dataRowView.ToString()
						End If
					End If
				Else
					s = MyBase.Items(A_1.Index).ToString()
				End If
				A_1.Graphics.DrawString(s, A_1.Font, New SolidBrush(A_1.ForeColor), A_1.Bounds, Me.O.00_Oo.)
			End If
		End Sub

		' Token: 0x06003E6D RID: 15981 RVA: 0x001B0474 File Offset: 0x001AE674
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ItemHeight = CInt(Math.Ceiling(CDbl((Me.Font.Size / 9F * 12F)))) + Me.ItemSpacing
		End Sub

		' Token: 0x04001951 RID: 6481
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001952 RID: 6482
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001953 RID: 6483
		Private <<EMPTY_NAME>> As StringFormat

		' Token: 0x04001954 RID: 6484
		Friend <<EMPTY_NAME>> As Foxtable.WinForm.Form
	End Class
End Namespace
