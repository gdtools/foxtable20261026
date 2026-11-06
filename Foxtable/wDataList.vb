Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200020A RID: 522
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wDataList
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018A9 RID: 6313 RVA: 0x000A0A10 File Offset: 0x0009EC10
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.o00.0Oo. = A_2
		End Sub

		' Token: 0x17000570 RID: 1392
		' (get) Token: 0x060018AA RID: 6314 RVA: 0x000A0A21 File Offset: 0x0009EC21
		' (set) Token: 0x060018AB RID: 6315 RVA: 0x000A0A29 File Offset: 0x0009EC29
		Public Property options As String
			Get
				Return Me.o00.0Oo.
			End Get
			Set(value As String)
				Me.o00.0Oo. = value
			End Set
		End Property

		' Token: 0x060018AC RID: 6316 RVA: 0x000A0A34 File Offset: 0x0009EC34
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.AppendLine("<datalist id='" + MyBase.ID + "' >")
			If Operators.CompareString(Me.options, "", True) > 0 Then
				Dim array As String() = Me.options.Split(New Char() { "|"c })
				For i As Integer = 0 To array.Length - 1
					Dim array2 As String() = array(i).Split(New Char() { ":"c })
					If array2.Length > 1 Then
						A_0.AppendLine(String.Concat(New String() { " <option value='", array2(0), "' label='", array2(1), "'/>" }))
					Else
						A_0.AppendLine(" <option value='" + array2(0) + "'>")
					End If
				Next
			End If
			A_0.AppendLine("</datalist>")
		End Sub

		' Token: 0x04000A57 RID: 2647
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
