Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000211 RID: 529
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wLabel
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018E5 RID: 6373 RVA: 0x000A18A4 File Offset: 0x0009FAA4
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.O.__00oOO_o0O0. = A_2
		End Sub

		' Token: 0x17000580 RID: 1408
		' (get) Token: 0x060018E6 RID: 6374 RVA: 0x000A18B5 File Offset: 0x0009FAB5
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_label"
			End Get
		End Property

		' Token: 0x060018E7 RID: 6375 RVA: 0x000A18BC File Offset: 0x0009FABC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = "<label"
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text = text + ">" + Me.O.__00oOO_o0O0. + "</label>"
			A_0.AppendLine(text)
		End Sub

		' Token: 0x04000A6F RID: 2671
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
