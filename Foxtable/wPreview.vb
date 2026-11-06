Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000217 RID: 535
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0085")>
	Public Class wPreview
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001901 RID: 6401 RVA: 0x000A25AC File Offset: 0x000A07AC
		Friend Sub New(A_0 As String, A_1 As String, Optional A_2 As String = "", Optional A_3 As String = "")
			MyBase.New(A_0, A_1)
			Me.OO_00o0O0.0__. = New List(Of String)()
			Me.oOooOO_0OO.o_. = New List(Of String)()
			Me.OO_00o0O0.0__. = A_2
			Me.oOooOO_0OO.o_. = A_3
		End Sub

		' Token: 0x06001902 RID: 6402 RVA: 0x000A25DC File Offset: 0x000A07DC
		Public Sub AddItem(Label As String, Value As String, Optional Attribute As String = "")
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			Dim stringBuilder As StringBuilder = New StringBuilder()
			stringBuilder.AppendLine("<div class='weui-form-preview__item'" + Attribute + ">")
			stringBuilder.AppendLine("<label class='weui-form-preview__label'>" + Label + "</label>")
			stringBuilder.AppendLine("<span class='weui-form-preview__value'>" + Value + "</span>")
			stringBuilder.AppendLine("</div>")
			Me.OO_00o0O0.0__..Add(stringBuilder.ToString())
		End Sub

		' Token: 0x06001903 RID: 6403 RVA: 0x000A2670 File Offset: 0x000A0870
		Public Sub AddButton(Text As String, Href As String, Optional Type As Integer = 1, Optional Attribute As String = "")
			Dim stringBuilder As StringBuilder = New StringBuilder()
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			If Operators.CompareString(Href, "", True) > 0 Then
				stringBuilder.Append("<a")
			Else
				stringBuilder.Append("<button ")
			End If
			stringBuilder.Append(" class='weui-form-preview__btn")
			If Type = 0 Then
				stringBuilder.Append(" weui-form-preview__btn_default'")
			Else
				stringBuilder.Append(" weui-form-preview__btn_primary'")
			End If
			stringBuilder.Append(Attribute)
			If Operators.CompareString(Href, "", True) > 0 Then
				stringBuilder.AppendLine(String.Concat(New String() { " href='", Href, "'>", Text, "</a>" }))
			Else
				stringBuilder.AppendLine(">" + Text + "</button>")
			End If
			Me.oOooOO_0OO.o_..Add(stringBuilder.ToString())
		End Sub

		' Token: 0x06001904 RID: 6404 RVA: 0x000A2768 File Offset: 0x000A0968
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append("<div class='weui-form-preview")
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.AppendLine(">")
			If Operators.CompareString(Me.OO_00o0O0.0__., "", True) > 0 Then
				A_0.AppendLine("<div class='weui-form-preview__hd'>")
				A_0.AppendLine("<label class='weui-form-preview__label'>" + Me.OO_00o0O0.0__. + "</label>")
				A_0.AppendLine("<em class='weui-form-preview__value'>" + Me.oOooOO_0OO.o_. + "</em>")
				A_0.AppendLine("</div>")
			End If
			If Me.OO_00o0O0.0__..Count > 0 Then
				A_0.AppendLine("<div class='weui-form-preview__bd'>")
				Try
					For Each value As String In Me.OO_00o0O0.0__.
						A_0.Append(value)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</div>")
			End If
			If Me.oOooOO_0OO.o_..Count > 0 Then
				A_0.AppendLine("<div class='weui-form-preview__ft'>")
				Try
					For Each value2 As String In Me.oOooOO_0OO.o_.
						A_0.Append(value2)
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</div>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A82 RID: 2690
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A83 RID: 2691
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A84 RID: 2692
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000A85 RID: 2693
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
