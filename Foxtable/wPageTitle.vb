Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000214 RID: 532
	<oO0oooo("A0075")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wPageTitle
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018F1 RID: 6385 RVA: 0x000A1E94 File Offset: 0x000A0094
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.o__o.OOoO_. = A_2
			Me.OO0_OO0o0_._. = A_3
		End Sub

		' Token: 0x060018F2 RID: 6386 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.AppendLine("<div class='fox_page_header'>")
			A_0.AppendLine("<h1 class='fox_page_title'>" + Me.o__o.OOoO_. + "</h1>")
			If Operators.CompareString(Me.OO0_OO0o0_._., "", True) > 0 Then
				A_0.AppendLine("<p class='fox_page_subtitle'>" + Me.OO0_OO0o0_._. + "</p>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A76 RID: 2678
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A77 RID: 2679
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
