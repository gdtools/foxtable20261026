Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200020C RID: 524
	<oO0oooo("A0007")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wForm
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018B2 RID: 6322 RVA: 0x000A0CCC File Offset: 0x0009EECC
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O_0.o0o_. = "post"
			Me.o.O___oOOOOoo. = A_2
		End Sub

		' Token: 0x060018B3 RID: 6323 RVA: 0x000A0CE8 File Offset: 0x0009EEE8
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.O_0.o0o_. = "post"
			Me.o.O___oOOOOoo. = A_2
			Me.O_0.o0o_. = A_3
		End Sub

		' Token: 0x060018B4 RID: 6324 RVA: 0x000A0D0C File Offset: 0x0009EF0C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append("<form method='" + Me.O_0.o0o_. + "' enctype='multipart/form-data'")
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" class='" + MyBase.[Class] + "'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.AppendLine(String.Concat(New String() { " id='", MyBase.ID, "' name ='", MyBase.ID, "' action ='", Me.o.O___oOOOOoo., "'>" }))
			Try
				For Each wElement As wElement In A_1.o0_._00..Values
					If Operators.CompareString(wElement.PID, MyBase.ID, True) = 0 Then
						CType(wElement, o_oOOOoo_O_O).OOO.__O_oO_.(A_0, A_1)
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, wElement).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</form>")
		End Sub

		' Token: 0x04000A5C RID: 2652
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A5D RID: 2653
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
