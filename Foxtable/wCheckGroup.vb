Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000209 RID: 521
	<oO0oooo("A0053")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wCheckGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018A2 RID: 6306 RVA: 0x000A0803 File Offset: 0x0009EA03
		Friend Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.o00.0Oo. = New List(Of wCheck)()
		End Sub

		' Token: 0x060018A3 RID: 6307 RVA: 0x000A0818 File Offset: 0x0009EA18
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.o00.0Oo. = New List(Of wCheck)()
			Me.o00.0Oo. = A_2
		End Sub

		' Token: 0x1700056E RID: 1390
		' (get) Token: 0x060018A4 RID: 6308 RVA: 0x000A0834 File Offset: 0x0009EA34
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_cells weui_cells_checkbox"
			End Get
		End Property

		' Token: 0x1700056F RID: 1391
		' (get) Token: 0x060018A5 RID: 6309 RVA: 0x000A083B File Offset: 0x0009EA3B
		' (set) Token: 0x060018A6 RID: 6310 RVA: 0x000A0843 File Offset: 0x0009EA43
		Public Property Text As String
			Get
				Return Me.o00.0Oo.
			End Get
			Set(value As String)
				Me.o00.0Oo. = value
			End Set
		End Property

		' Token: 0x060018A7 RID: 6311 RVA: 0x000A084C File Offset: 0x0009EA4C
		Public Function Add(ID As String, Text As String, Optional Checked As Boolean = False) As wCheck
			Dim wCheck As wCheck = New wCheck(MyBase.ID, ID, Text, Checked)
			Me.o00.0Oo..Add(wCheck)
			Return wCheck
		End Function

		' Token: 0x060018A8 RID: 6312 RVA: 0x000A0878 File Offset: 0x0009EA78
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.Text, "", True) > 0 Then
				A_0.AppendLine("<div class='fox_group'>")
				New wGroupTitle(MyBase.ID, "", Me.Text).OooO_o0o0O.0_.(A_0, A_1)
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
				For Each wCheck As wCheck In Me.o00.0Oo.
					wCheck.OO00000O0.0.(A_0, A_1)
				Next
			Finally
				Dim enumerator As List(Of wCheck).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			If Operators.CompareString(Me.Text, "", True) > 0 Then
				A_0.AppendLine("</div>")
			End If
		End Sub

		' Token: 0x04000A55 RID: 2645
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A56 RID: 2646
		Private <<EMPTY_NAME>> As List(Of wCheck)
	End Class
End Namespace
