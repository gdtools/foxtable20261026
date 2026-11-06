Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000219 RID: 537
	<oO0oooo("A0052")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wRadioGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600190A RID: 6410 RVA: 0x000A2B06 File Offset: 0x000A0D06
		Friend Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.O0.0O0OooO0. = New List(Of wRadion)()
		End Sub

		' Token: 0x17000589 RID: 1417
		' (get) Token: 0x0600190B RID: 6411 RVA: 0x000A2B1B File Offset: 0x000A0D1B
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_cells weui_cells_radio"
			End Get
		End Property

		' Token: 0x0600190C RID: 6412 RVA: 0x000A2B22 File Offset: 0x000A0D22
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O0.0O0OooO0. = New List(Of wRadion)()
			Me.O0.0O0OooO0. = A_2
		End Sub

		' Token: 0x0600190D RID: 6413 RVA: 0x000A2B40 File Offset: 0x000A0D40
		Public Function Add(ID As String, Text As String, Optional Checked As Boolean = False) As wRadion
			Dim wRadion As wRadion = New wRadion(MyBase.ID, ID, Text, Checked)
			Me.O0.0O0OooO0..Add(wRadion)
			Return wRadion
		End Function

		' Token: 0x0600190E RID: 6414 RVA: 0x000A2B6C File Offset: 0x000A0D6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.O0.0O0OooO0., "", True) > 0 Then
				A_0.AppendLine("<div class='fox_group'>")
				New wGroupTitle(MyBase.ID, "", Me.O0.0O0OooO0.).OooO_o0o0O.0_.(A_0, A_1)
			End If
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<div class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { "<div class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " id='", MyBase.ID, "' name='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text += ">"
			A_0.AppendLine(text)
			Try
				For Each wRadion As wRadion In Me.O0.0O0OooO0.
					wRadion.O0.0O0OooO0.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wRadion).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			If Operators.CompareString(Me.O0.0O0OooO0., "", True) > 0 Then
				A_0.AppendLine("</div>")
			End If
		End Sub

		' Token: 0x04000A89 RID: 2697
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A8A RID: 2698
		Private <<EMPTY_NAME>> As List(Of wRadion)
	End Class
End Namespace
