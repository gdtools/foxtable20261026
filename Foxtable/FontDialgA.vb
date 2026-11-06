Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000107 RID: 263
	Public Class FontDialgA
		Inherits FontDialog

		' Token: 0x06000DAD RID: 3501 RVA: 0x0005FD30 File Offset: 0x0005DF30
		Public Function ShowDialog() As Task(Of DialogResult)
			Dim ooo0_ooo As FontDialgA.OOo0_ooo = Nothing
			ooo0_ooo.O0.O_o_O_O__O. = Me
			ooo0_ooo.O0.O_o_O_O__O. = -1
			ooo0_ooo.O0.O_o_O_O__O. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			ooo0_ooo.O0.O_o_O_O__O..Start(Of FontDialgA.OOo0_ooo)(ooo0_ooo)
			Return ooo0_ooo.O0.O_o_O_O__O..Task
		End Function

		' Token: 0x06000DAE RID: 3502 RVA: 0x0005FD7C File Offset: 0x0005DF7C
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As DialogResult
			Dim oo_o As FontDialgA.OO_o = New FontDialgA.OO_o()
			oo_o.O0.O_o_O_O__O. = Me
			oo_o.Oo_o00oO_.O. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oo_o.Oo_o00oO_.O.)
			End If
			Return oo_o.Oo_o00oO_.O.
		End Function

		' Token: 0x02000108 RID: 264
		<CompilerGenerated()>
		Friend NotInheritable Class OO_o
			' Token: 0x06000DB0 RID: 3504 RVA: 0x0005FDC9 File Offset: 0x0005DFC9
			Friend Sub <<EMPTY_NAME>>()
				Me.Oo_o00oO_.O. = Me.O0.O_o_O_O__O..ShowDialog()
			End Sub

			' Token: 0x04000542 RID: 1346
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000543 RID: 1347
			Public <<EMPTY_NAME>> As FontDialgA
		End Class
	End Class
End Namespace
