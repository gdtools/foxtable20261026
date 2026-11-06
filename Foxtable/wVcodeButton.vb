Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200022B RID: 555
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wVcodeButton
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060019EB RID: 6635 RVA: 0x000A7250 File Offset: 0x000A5450
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.OoOoo_o_.o_. = A_2
		End Sub

		' Token: 0x170005CA RID: 1482
		' (get) Token: 0x060019EC RID: 6636 RVA: 0x000A7261 File Offset: 0x000A5461
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui-vcode-btn"
			End Get
		End Property

		' Token: 0x060019ED RID: 6637 RVA: 0x000A7268 File Offset: 0x000A5468
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = "<a href='javascript:;'"
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text = text + ">" + Me.OoOoo_o_.o_. + "</a>"
			A_0.AppendLine(text)
		End Sub

		' Token: 0x04000AE6 RID: 2790
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
