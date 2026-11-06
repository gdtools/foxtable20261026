Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000213 RID: 531
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wPage
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018EE RID: 6382 RVA: 0x000A1D24 File Offset: 0x0009FF24
		Friend Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.o__o.OOoO_. = True
		End Sub

		' Token: 0x060018EF RID: 6383 RVA: 0x000A1D35 File Offset: 0x0009FF35
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
			MyBase.New(A_0, A_1)
			Me.o__o.OOoO_. = True
			Me.o__o.OOoO_. = A_2
		End Sub

		' Token: 0x060018F0 RID: 6384 RVA: 0x000A1D50 File Offset: 0x0009FF50
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<div  id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" class='fox_page" + MyBase.[Class] + "'")
			Else
				A_0.Append(" class='fox_page'")
			End If
			If Not Me.o__o.OOoO_. Then
				A_0.Append(" style='display:none'")
			End If
			A_0.AppendLine(">")
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
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A75 RID: 2677
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
