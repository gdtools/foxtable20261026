Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200013E RID: 318
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O00o
		Inherits C1FontPicker
		Implements O000O

		' Token: 0x06000F49 RID: 3913 RVA: 0x00068360 File Offset: 0x00066560
		Public Sub New()
			MyBase.DropDownClosed += AddressOf Me.O__00_Oo0.00__.
			AddHandler MyBase.Enter, AddressOf Me.OO.0O00.
			AddHandler MyBase.GotFocus, AddressOf Me.O__00_Oo0.00__.
			Me.OoO0O0.0O_oo. = 0
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.AutoSize = False
			MyBase.VerticalAlign = 1
			MyBase.Padding = New Padding(1, 2, 1, 1)
		End Sub

		' Token: 0x06000F4A RID: 3914 RVA: 0x00068407 File Offset: 0x00066607
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.OoO0O0.0O_oo.
		End Function

		' Token: 0x06000F4B RID: 3915 RVA: 0x0006840F File Offset: 0x0006660F
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.OoO0O0.0O_oo. = A_0
			ooO_0O.o_O0.O_.(Me, Me.OoO0O0.0O_oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F4C RID: 3916 RVA: 0x00068430 File Offset: 0x00066630
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.OoO0O0.0O_oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F4D RID: 3917 RVA: 0x0006844C File Offset: 0x0006664C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count > 0 Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MyBase.DataBindings(0).BindingManagerBase.Current)
				If TypeOf objectValue Is DataRowView Then
					Dim row As DataRow = CType(objectValue, DataRowView).Row
					Dim bindingField As String = MyBase.DataBindings(0).BindingMemberInfo.BindingField
					If Operators.CompareString(row(bindingField).ToString(), Me.Text, True) <> 0 AndAlso MyBase.UpdateValueWithCurrentText() Then
						MyBase.DataBindings(0).WriteValue()
						CType(objectValue, DataRowView).Row.EndEdit()
					End If
				End If
			End If
		End Sub

		' Token: 0x06000F4E RID: 3918 RVA: 0x0006851C File Offset: 0x0006671C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.OoO0O0.0O_oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F4F RID: 3919 RVA: 0x00068536 File Offset: 0x00066736
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.OoO0O0.0O_oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F50 RID: 3920 RVA: 0x00068550 File Offset: 0x00066750
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.OoO0O0.0O_oo.
		End Function

		' Token: 0x06000F51 RID: 3921 RVA: 0x00068558 File Offset: 0x00066758
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.OoO0O0.0O_oo. = A_0
		End Sub

		' Token: 0x040005DF RID: 1503
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040005E0 RID: 1504
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
