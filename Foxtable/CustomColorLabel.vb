Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020003CA RID: 970
	Friend Class CustomColorLabel
		Inherits Label

		' Token: 0x06003DF4 RID: 15860 RVA: 0x001ADD74 File Offset: 0x001ABF74
		Public Sub New()
			AddHandler MyBase.DoubleClick, AddressOf Me.O_o0oo._oO0.
			Me.AutoSize = False
			Me.Text = ""
			Me.BackColor = Color.Red
			Me.BorderStyle = BorderStyle.Fixed3D
		End Sub

		' Token: 0x17000D8B RID: 3467
		' (get) Token: 0x06003DF5 RID: 15861 RVA: 0x001ADDB2 File Offset: 0x001ABFB2
		' (set) Token: 0x06003DF6 RID: 15862 RVA: 0x001ADDBC File Offset: 0x001ABFBC
		Public Property Value As Object
			Get
				Return Me.O_o0oo._oO0.
			End Get
			Set(value As Object)
				Me.O_o0oo._oO0. = RuntimeHelpers.GetObjectValue(value)
				Dim argb As Integer
				If value Is DBNull.Value OrElse value Is Nothing Then
					If Me.BackColor <> Color.Empty Then
						Me.BackColor = Color.Empty
						Return
					End If
				ElseIf Integer.TryParse(value.ToString(), argb) Then
					If Me.BackColor <> Color.FromArgb(argb) Then
						Me.BackColor = Color.FromArgb(argb)
						Return
					End If
				ElseIf Me.BackColor <> Color.Empty Then
					Me.BackColor = Color.Empty
				End If
			End Set
		End Property

		' Token: 0x06003DF7 RID: 15863 RVA: 0x001ADE4C File Offset: 0x001AC04C
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

		' Token: 0x17000D8C RID: 3468
		' (get) Token: 0x06003DF8 RID: 15864 RVA: 0x001ADF7D File Offset: 0x001AC17D
		' (set) Token: 0x06003DF9 RID: 15865 RVA: 0x001ADF85 File Offset: 0x001AC185
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O_o0oo._oO0.
			End Get
			Set(value As BooleanEnum)
				Me.O_o0oo._oO0. = value
			End Set
		End Property

		' Token: 0x06003DFA RID: 15866 RVA: 0x001ADF90 File Offset: 0x001AC190
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.Color = Me.BackColor
			colorDialog.AnyColor = True
			If colorDialog.ShowDialog() = DialogResult.OK Then
				Me.Value = colorDialog.Color.ToArgb()
				If MyBase.DataBindings.Count > 0 Then
					MyBase.DataBindings(0).WriteValue()
				End If
				Me.O_o0oo._oO0. = RuntimeHelpers.GetObjectValue(Me.Value)
			End If
		End Sub

		' Token: 0x06003DFB RID: 15867 RVA: 0x001AE008 File Offset: 0x001AC208
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If(A_0.Msg <> 513 AndAlso A_0.Msg <> 515) OrElse Me.Oo0oO0_.o00.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x0400192D RID: 6445
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x0400192E RID: 6446
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
