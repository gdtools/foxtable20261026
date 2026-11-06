Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports O0o0.00

Namespace Foxtable
	' Token: 0x0200010A RID: 266
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class FontDialogJs
		' Token: 0x06000DB3 RID: 3507 RVA: 0x0005FEBE File Offset: 0x0005E0BE
		Public Sub New(A_0 As WebViewer)
			Me.O.Oo0. = Nothing
			Me.O.Oo0. = Nothing
			Me.O.Oo0. = New Font("微软雅黑", 12F)
			Me.O.Oo0. = A_0
		End Sub

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0005FEF0 File Offset: 0x0005E0F0
		' (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
		Public Property CallBack As String

		' Token: 0x06000DB6 RID: 3510 RVA: 0x0005FF04 File Offset: 0x0005E104
		Public Sub ShowDialog()
			Dim oO0oo__O As FontDialogJs.oO0oo__O0 = Nothing
			oO0oo__O.O0_o0.o__. = Me
			oO0oo__O.O0_o0.o__. = -1
			oO0oo__O.O0_o0.o__. = AsyncVoidMethodBuilder.Create()
			oO0oo__O.O0_o0.o__..Start(Of FontDialogJs.oO0oo__O0)(oO0oo__O)
		End Sub

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0005FF43 File Offset: 0x0005E143
		' (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0005FF4B File Offset: 0x0005E14B
		Public Property Font As Font
			Get
				Return Me.O.Oo0.
			End Get
			Set(value As Font)
				Me.O.Oo0. = value
			End Set
		End Property

		' Token: 0x06000DB9 RID: 3513 RVA: 0x0005FF54 File Offset: 0x0005E154
		<CompilerGenerated()>
		Private Sub <<EMPTY_NAME>>()
			Dim oO As FontDialogJs.oO00 = New FontDialogJs.oO00()
			oO.O.Oo0. = Me
			oO.O.Oo0. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oO.O.Oo0.)
			End If
		End Sub

		' Token: 0x04000548 RID: 1352
		Private <<EMPTY_NAME>> As FontDialog

		' Token: 0x04000549 RID: 1353
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x0400054A RID: 1354
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400054B RID: 1355
		Private <<EMPTY_NAME>> As Font

		' Token: 0x0200010B RID: 267
		<CompilerGenerated()>
		Friend NotInheritable Class oO00
			' Token: 0x06000DBB RID: 3515 RVA: 0x0005FF9C File Offset: 0x0005E19C
			Friend Sub <<EMPTY_NAME>>()
				Me.O.Oo0..O.Oo0. = New FontDialog()
				If Me.O.Oo0..O.Oo0. IsNot Nothing Then
					Me.O.Oo0..O.Oo0..Font = Me.O.Oo0..O.Oo0.
				End If
				Me.O.Oo0. = Me.O.Oo0..O.Oo0..ShowDialog(OO_00oOO.BaseMainForm)
				If Me.O.Oo0. = DialogResult.OK AndAlso Operators.CompareString(Me.O.Oo0..CallBack, "", True) > 0 Then
					Me.O.Oo0..O.Oo0. = Me.O.Oo0..O.Oo0..Font
					Dim jobject As JObject = New JObject()
					jobject("name") = Me.O.Oo0..O.Oo0..Font.Name
					jobject("size") = Me.O.Oo0..O.Oo0..Font.Size
					jobject("bold") = Me.O.Oo0..O.Oo0..Font.Bold
					jobject("italic") = Me.O.Oo0..O.Oo0..Font.Italic
					Dim arg As String = JsonConvert.ToString(jobject.ToString())
					Dim text As String = String.Format("{0}({1})", Me.O.Oo0..CallBack, arg)
					Me.O.Oo0..O.Oo0..ExecuteScriptAsync(text)
				End If
				Me.O.Oo0..O.Oo0..Dispose()
			End Sub

			' Token: 0x0400054C RID: 1356
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x0400054D RID: 1357
			Public <<EMPTY_NAME>> As FontDialogJs
		End Class
	End Class
End Namespace
