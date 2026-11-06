Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200020D RID: 525
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0077")>
	Public Class wGrid
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018B5 RID: 6325 RVA: 0x000A0E50 File Offset: 0x0009F050
		Public Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.OooO_o0o0O.0_. = New List(Of wGridCell)()
		End Sub

		' Token: 0x060018B6 RID: 6326 RVA: 0x000A0E68 File Offset: 0x0009F068
		Public Function Add(ID As String, Title As String, Image As String, href As String) As wGridCell
			Dim wGridCell As wGridCell = New wGridCell(MyBase.ID, ID, Title, Image, href)
			Me.OooO_o0o0O.0_..Add(wGridCell)
			Return wGridCell
		End Function

		' Token: 0x060018B7 RID: 6327 RVA: 0x000A0E93 File Offset: 0x0009F093
		Public Function Add(ID As String, Title As String, Image As String) As wGridCell
			Return Me.Add(ID, Title, Image, "")
		End Function

		' Token: 0x060018B8 RID: 6328 RVA: 0x000A0EA4 File Offset: 0x0009F0A4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append("<div class='weui_grids " + MyBase.[Class] + "'")
			Else
				A_0.Append("<div class='weui_grids'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.AppendLine(">")
			Try
				For Each wGridCell As wGridCell In Me.OooO_o0o0O.0_.
					wGridCell.OooO_o0o0O.0_.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wGridCell).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A5E RID: 2654
		Private <<EMPTY_NAME>> As List(Of wGridCell)
	End Class
End Namespace
