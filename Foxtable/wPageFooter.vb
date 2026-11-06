Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001FF RID: 511
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0086")>
	Public Class wPageFooter
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001857 RID: 6231 RVA: 0x0009EEE6 File Offset: 0x0009D0E6
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Integer)
			MyBase.New(A_0, A_1)
			Me.o__o.OOoO_. = New List(Of String)()
			Me.o__o.OOoO_. = A_2
			Me.o__o.OOoO_. = A_3
		End Sub

		' Token: 0x06001858 RID: 6232 RVA: 0x0009EF0C File Offset: 0x0009D10C
		Public Sub AddLink(Text As String, Href As String, Optional Attribute As String = "")
			Dim stringBuilder As StringBuilder = New StringBuilder()
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			stringBuilder.AppendLine(String.Concat(New String() { " <a href='", Href, "' class='weui-footer__link'", Attribute, ">", Text, "</a>" }))
			Me.o__o.OOoO_..Add(stringBuilder.ToString())
		End Sub

		' Token: 0x06001859 RID: 6233 RVA: 0x0009EF8C File Offset: 0x0009D18C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append("<div class='weui-footer")
			If Me.o__o.OOoO_. = 1 Then
				A_0.Append(" weui-footer_fixed-bottom")
			End If
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.AppendLine(">")
			If Me.o__o.OOoO_..Count > 0 Then
				A_0.AppendLine("<p class='weui-footer__links'" + MyBase.Attribute + ">")
				Try
					For Each value As String In Me.o__o.OOoO_.
						A_0.Append(value)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</p>")
			End If
			If Operators.CompareString(Me.o__o.OOoO_., "", True) > 0 Then
				A_0.Append("<p class='weui-footer__text'>")
				A_0.Append(Me.o__o.OOoO_.)
				A_0.AppendLine("</p>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A2E RID: 2606
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A2F RID: 2607
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000A30 RID: 2608
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
