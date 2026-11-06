Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports O0o0.00

Namespace Foxtable
	' Token: 0x020000F9 RID: 249
	Public Class ColorDialogA
		Inherits ColorDialog

		' Token: 0x06000D74 RID: 3444 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
		Public Function ShowDialog() As Task(Of DialogResult)
			Dim o0o_ As ColorDialogA.O0o_ = Nothing
			o0o_.OOo.o0o. = Me
			o0o_.OOo.o0o. = -1
			o0o_.OOo.o0o. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			o0o_.OOo.o0o..Start(Of ColorDialogA.O0o_)(o0o_)
			Return o0o_.OOo.o0o..Task
		End Function

		' Token: 0x06000D75 RID: 3445 RVA: 0x0005F32C File Offset: 0x0005D52C
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As DialogResult
			Dim oo0_0000_ As ColorDialogA.Oo0_0000_0 = New ColorDialogA.Oo0_0000_0()
			oo0_0000_.OOo.o0o. = Me
			oo0_0000_.o_o_O.0000_O. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oo0_0000_.o_o_O.0000_O.)
			End If
			Return oo0_0000_.o_o_O.0000_O.
		End Function

		' Token: 0x020000FA RID: 250
		<CompilerGenerated()>
		Friend NotInheritable Class Oo0_0000_0
			' Token: 0x06000D77 RID: 3447 RVA: 0x0005F379 File Offset: 0x0005D579
			Friend Sub <<EMPTY_NAME>>()
				Me.o_o_O.0000_O. = Me.OOo.o0o..ShowDialog()
			End Sub

			' Token: 0x0400051C RID: 1308
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x0400051D RID: 1309
			Public <<EMPTY_NAME>> As ColorDialogA
		End Class
	End Class
End Namespace
