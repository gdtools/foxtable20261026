Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports O0o0.00

Namespace Foxtable
	' Token: 0x0200010D RID: 269
	Public Class MessageBoxA
		' Token: 0x06000DBF RID: 3519 RVA: 0x00060228 File Offset: 0x0005E428
		Public Shared Function Show(ParamArray args As Object()) As Task(Of DialogResult)
			Dim oO__O As MessageBoxA.oO__O = Nothing
			oO__O.Ooo_Oo_0O0o.0_. = args
			oO__O.Ooo_Oo_0O0o.0_. = -1
			oO__O.Ooo_Oo_0O0o.0_. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			oO__O.Ooo_Oo_0O0o.0_..Start(Of MessageBoxA.oO__O)(oO__O)
			Return oO__O.Ooo_Oo_0O0o.0_..Task
		End Function

		' Token: 0x06000DC0 RID: 3520 RVA: 0x00060274 File Offset: 0x0005E474
		Private Shared Function <<EMPTY_NAME>>(ParamArray A_0 As Object()) As DialogResult
			Dim result As DialogResult
			If A_0.Length = 1 Then
				result = MessageBox.Show(Conversions.ToString(A_0(0)))
			ElseIf A_0.Length = 2 Then
				result = MessageBox.Show(Conversions.ToString(A_0(0)), Conversions.ToString(A_0(1)))
			ElseIf A_0.Length = 3 Then
				Dim buttons As MessageBoxButtons = CType(Conversions.ToInteger(A_0(2)), MessageBoxButtons)
				result = MessageBox.Show(Conversions.ToString(A_0(0)), Conversions.ToString(A_0(1)), buttons)
			ElseIf A_0.Length = 4 Then
				Dim buttons2 As MessageBoxButtons = CType(Conversions.ToInteger(A_0(2)), MessageBoxButtons)
				Dim icon As MessageBoxIcon = CType(Conversions.ToInteger(A_0(3)), MessageBoxIcon)
				result = MessageBox.Show(Conversions.ToString(A_0(0)), Conversions.ToString(A_0(1)), buttons2, icon)
			End If
			Return result
		End Function

		' Token: 0x0200010E RID: 270
		<CompilerGenerated()>
		Friend NotInheritable Class O_0o_0_0O
			' Token: 0x06000DC2 RID: 3522 RVA: 0x00060316 File Offset: 0x0005E516
			Friend Sub <<EMPTY_NAME>>()
				Me.o.o_oo0OoO. = MessageBoxA.o.o_oo0OoO.(Me.o.o_oo0OoO..o.o_oo0OoO.)
			End Sub

			' Token: 0x04000552 RID: 1362
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000553 RID: 1363
			Public <<EMPTY_NAME>> As MessageBoxA.O00oo_oO_oO
		End Class

		' Token: 0x0200010F RID: 271
		<CompilerGenerated()>
		Friend NotInheritable Class O00oo_oO_oO
			' Token: 0x06000DC4 RID: 3524 RVA: 0x00060338 File Offset: 0x0005E538
			Friend Function <<EMPTY_NAME>>() As DialogResult
				Dim o_0o_0_0O As MessageBoxA.O_0o_0_0O = New MessageBoxA.O_0o_0_0O()
				o_0o_0_0O.o.o_oo0OoO. = Me
				o_0o_0_0O.o.o_oo0OoO. = DialogResult.Cancel
				If OO_00oOO.BaseMainForm IsNot Nothing Then
					OO_00oOO.BaseMainForm.Invoke(AddressOf o_0o_0_0O.o.o_oo0OoO.)
				End If
				Return o_0o_0_0O.o.o_oo0OoO.
			End Function

			' Token: 0x04000554 RID: 1364
			Public <<EMPTY_NAME>> As Object()
		End Class
	End Class
End Namespace
