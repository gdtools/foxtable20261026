Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports O0o0.00

Namespace Foxtable
	' Token: 0x020000FC RID: 252
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ColorDialogJs
		' Token: 0x06000D7A RID: 3450 RVA: 0x0005F46E File Offset: 0x0005D66E
		Public Sub New(A_0 As WebViewer)
			Me.Oo.o. = Nothing
			Me.Oo.o. = Nothing
			Me.Oo.o. = Color.Black
			Me.Oo.o. = A_0
		End Sub

		' Token: 0x17000248 RID: 584
		' (get) Token: 0x06000D7B RID: 3451 RVA: 0x0005F496 File Offset: 0x0005D696
		' (set) Token: 0x06000D7C RID: 3452 RVA: 0x0005F49E File Offset: 0x0005D69E
		Public Property CallBack As String

		' Token: 0x06000D7D RID: 3453 RVA: 0x0005F4A8 File Offset: 0x0005D6A8
		Public Sub ShowDialog()
			Dim o_ As ColorDialogJs.O_00 = Nothing
			o_.oOO._O0OOO_o. = Me
			o_.oOO._O0OOO_o. = -1
			o_.oOO._O0OOO_o. = AsyncVoidMethodBuilder.Create()
			o_.oOO._O0OOO_o..Start(Of ColorDialogJs.O_00)(o_)
		End Sub

		' Token: 0x17000249 RID: 585
		' (get) Token: 0x06000D7E RID: 3454 RVA: 0x0005F4E7 File Offset: 0x0005D6E7
		' (set) Token: 0x06000D7F RID: 3455 RVA: 0x0005F4EF File Offset: 0x0005D6EF
		Public Property Color As Color
			Get
				Return Me.Oo.o.
			End Get
			Set(value As Color)
				Me.Oo.o. = value
			End Set
		End Property

		' Token: 0x06000D80 RID: 3456 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		<CompilerGenerated()>
		Private Sub <<EMPTY_NAME>>()
			Dim o0O_00__O As ColorDialogJs.O0O_00__O = New ColorDialogJs.O0O_00__O()
			o0O_00__O.Oo.o. = Me
			o0O_00__O.Oo.o. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf o0O_00__O.Oo.o.)
			End If
		End Sub

		' Token: 0x04000522 RID: 1314
		Private <<EMPTY_NAME>> As ColorDialog

		' Token: 0x04000523 RID: 1315
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x04000524 RID: 1316
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000525 RID: 1317
		Private <<EMPTY_NAME>> As Color

		' Token: 0x020000FD RID: 253
		<CompilerGenerated()>
		Friend NotInheritable Class O0O_00__O
			' Token: 0x06000D82 RID: 3458 RVA: 0x0005F540 File Offset: 0x0005D740
			Friend Sub <<EMPTY_NAME>>()
				Me.Oo.o..Oo.o. = New ColorDialog()
				Me.Oo.o..Oo.o..Color = Me.Oo.o..Oo.o.
				Me.Oo.o. = Me.Oo.o..Oo.o..ShowDialog(OO_00oOO.BaseMainForm)
				If Me.Oo.o. = DialogResult.OK AndAlso Me.Oo.o. = DialogResult.OK AndAlso Operators.CompareString(Me.Oo.o..CallBack, "", True) > 0 Then
					Me.Oo.o..Oo.o..ExecuteScriptAsync(Me.Oo.o..CallBack + "(" + Conversions.ToString(Me.Oo.o..Oo.o..Color.ToArgb()) + ")")
				End If
				Me.Oo.o..Oo.o..Dispose()
			End Sub

			' Token: 0x04000526 RID: 1318
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000527 RID: 1319
			Public <<EMPTY_NAME>> As ColorDialogJs
		End Class
	End Class
End Namespace
