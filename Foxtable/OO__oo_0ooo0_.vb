Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x0200007A RID: 122
	Friend Class OO__oo_0ooo0_
		Inherits C1NumericEdit

		' Token: 0x06000414 RID: 1044 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As DropDownCalculator
			Return Me.OO_o0_oO.0.
		End Function

		' Token: 0x06000415 RID: 1045 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As DropDownCalculator)
			Me.OO_o0_oO.0. = A_0
		End Sub

		' Token: 0x06000416 RID: 1046 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		Public Sub New()
			MyBase.DropDownOpened += AddressOf Me.oo.o_Oo.
			AddHandler MyBase.KeyDown, AddressOf Me.oo.o_Oo.
			Me.OO_o0_oO.0.(CType(Me.DropDownForm, DropDownCalculator))
			MyBase.VisualStyle = 1
			MyBase.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.ImeMode = ImeMode.Close
			MyBase.InitialSelection = 0
		End Sub

		' Token: 0x06000417 RID: 1047 RVA: 0x0000EA4D File Offset: 0x0000CC4D
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.DropDownForm.Owner = Nothing
		End Sub

		' Token: 0x06000418 RID: 1048 RVA: 0x0000EA5C File Offset: 0x0000CC5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Down Then
				If TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					SendKeys.Send("{DOWN}")
					Return
				End If
			ElseIf A_1.KeyCode = Keys.Up AndAlso TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
				SendKeys.Send("{UP}")
			End If
		End Sub

		' Token: 0x040000DB RID: 219
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DropDownCalculator
	End Class
End Namespace
