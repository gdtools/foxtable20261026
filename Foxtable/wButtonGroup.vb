Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000204 RID: 516
	<oO0oooo("A0008")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wButtonGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600187B RID: 6267 RVA: 0x0009FC7A File Offset: 0x0009DE7A
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
			MyBase.New(A_0, A_1)
			Me.OO00000O0.0. = New List(Of wButton)()
			Me.OO00000O0.0. = A_2
		End Sub

		' Token: 0x0600187C RID: 6268 RVA: 0x0009FC98 File Offset: 0x0009DE98
		Public Function Add(ID As String, Text As String) As wButton
			Dim wButton As wButton = New wButton(MyBase.ID, ID, Text)
			Me.OO00000O0.0..Add(wButton)
			Return wButton
		End Function

		' Token: 0x0600187D RID: 6269 RVA: 0x0009FCC0 File Offset: 0x0009DEC0
		Public Function Add(ID As String, Text As String, Type As String) As wButton
			Dim wButton As wButton = New wButton(MyBase.ID, ID, Text, Type)
			Me.OO00000O0.0..Add(wButton)
			Return wButton
		End Function

		' Token: 0x0600187E RID: 6270 RVA: 0x0009FCEC File Offset: 0x0009DEEC
		Public Function Add(ID As String, Text As String, Type As String, Href As String) As wButton
			Dim wButton As wButton = New wButton(MyBase.ID, ID, Text, Type, Href)
			Me.OO00000O0.0..Add(wButton)
			Return wButton
		End Function

		' Token: 0x0600187F RID: 6271 RVA: 0x0009FD18 File Offset: 0x0009DF18
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Me.OO00000O0.0. Then
				If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
					A_0.AppendLine("<div class='fox_v_button_group'>")
				Else
					A_0.AppendLine("<div class='fox_v_button_group " + MyBase.[Class] + "'>")
				End If
				Try
					For Each wButton As wButton In Me.OO00000O0.0.
						A_0.AppendLine("<div class = 'fox_v_button'>")
						wButton.o.oOo_oo0__O0_.(A_0, A_1)
						A_0.AppendLine("</div>")
					Next
				Finally
					Dim enumerator As List(Of wButton).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</div>")
				Return
			End If
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				A_0.AppendLine("<div class='fox_h_button_group'>")
			Else
				A_0.AppendLine("<div class='fox_h_button_group " + MyBase.[Class] + "'>")
			End If
			Try
				For Each wButton2 As wButton In Me.OO00000O0.0.
					A_0.AppendLine("<div class = 'fox_h_button'>")
					wButton2.o.oOo_oo0__O0_.(A_0, A_1)
					A_0.AppendLine("</div>")
				Next
			Finally
				Dim enumerator2 As List(Of wButton).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A44 RID: 2628
		Private <<EMPTY_NAME>> As List(Of wButton)

		' Token: 0x04000A45 RID: 2629
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
