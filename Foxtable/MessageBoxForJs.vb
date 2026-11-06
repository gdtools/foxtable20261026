Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000111 RID: 273
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class MessageBoxForJs
		' Token: 0x06000DC7 RID: 3527 RVA: 0x0006046E File Offset: 0x0005E66E
		Public Sub New(A_0 As WebViewer)
			Me.Ooo_Oo_0O0o.0_. = Nothing
			Me.Ooo_Oo_0O0o.0_. = A_0
		End Sub

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00060484 File Offset: 0x0005E684
		' (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0006048C File Offset: 0x0005E68C
		Public Property CallBack As String

		' Token: 0x06000DCA RID: 3530 RVA: 0x00060495 File Offset: 0x0005E695
		Public Sub ShowDialog(ParamArray args As Object())
			Me.Show(args)
		End Sub

		' Token: 0x06000DCB RID: 3531 RVA: 0x000604A0 File Offset: 0x0005E6A0
		Public Sub Show(ParamArray args As Object())
			Dim o_O0o_0O As MessageBoxForJs.O_O0o_0O0 = Nothing
			o_O0o_0O.oO.0OO_OoOoO0. = Me
			o_O0o_0O.o0_0._. = args
			o_O0o_0O.o0_0._. = -1
			o_O0o_0O.o0_0._. = AsyncVoidMethodBuilder.Create()
			o_O0o_0O.o0_0._..Start(Of MessageBoxForJs.O_O0o_0O0)(o_O0o_0O)
		End Sub

		' Token: 0x06000DCC RID: 3532 RVA: 0x000604E8 File Offset: 0x0005E6E8
		Private Function <<EMPTY_NAME>>(ParamArray A_0 As Object()) As DialogResult
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

		' Token: 0x04000559 RID: 1369
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x0400055A RID: 1370
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x02000112 RID: 274
		<CompilerGenerated()>
		Friend NotInheritable Class OoO0o0o0_O
			' Token: 0x06000DCE RID: 3534 RVA: 0x0006058C File Offset: 0x0005E78C
			Friend Sub <<EMPTY_NAME>>()
				If OO_00oOO.BaseMainForm IsNot Nothing Then
					Dim control As Control = OO_00oOO.BaseMainForm
					Dim method As [Delegate]
					If Me.o0_0._. IsNot Nothing Then
						method = Me.o0_0._.
					Else
						Dim $UNNAMED_TYPE$ As $UNNAMED_TYPE$ = AddressOf Me.OOoO_0oo.0_.
						Dim $UNNAMED_TYPE$2 As $UNNAMED_TYPE$ = $UNNAMED_TYPE$
						Me.o0_0._. = $UNNAMED_TYPE$
						method = $UNNAMED_TYPE$2
					End If
					control.Invoke(method)
				End If
			End Sub

			' Token: 0x06000DCF RID: 3535 RVA: 0x000605D0 File Offset: 0x0005E7D0
			Friend Sub <<EMPTY_NAME>>()
				Dim dialogResult As DialogResult = Me.o0_0._..Ooo_Oo_0O0o.0_.(Me.o0_0._.)
				If Not String.IsNullOrEmpty(Me.o0_0._..CallBack) Then
					Dim text As String = String.Format("{0}({1})", Me.o0_0._..CallBack, CInt(dialogResult))
					Me.o0_0._..Ooo_Oo_0O0o.0_..ExecuteScriptAsync(text)
				End If
			End Sub

			' Token: 0x0400055B RID: 1371
			Public <<EMPTY_NAME>> As Object()

			' Token: 0x0400055C RID: 1372
			Public <<EMPTY_NAME>> As MessageBoxForJs

			' Token: 0x0400055D RID: 1373
			Public <<EMPTY_NAME>> As $UNNAMED_TYPE$
		End Class
	End Class
End Namespace
