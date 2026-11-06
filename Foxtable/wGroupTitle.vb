Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000224 RID: 548
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wGroupTitle
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001988 RID: 6536 RVA: 0x000A5444 File Offset: 0x000A3644
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.Text = A_2
		End Sub

		' Token: 0x170005B0 RID: 1456
		' (get) Token: 0x06001989 RID: 6537 RVA: 0x000A5455 File Offset: 0x000A3655
		' (set) Token: 0x0600198A RID: 6538 RVA: 0x000A545D File Offset: 0x000A365D
		Public Property Text As String
			Get
				Return Me.OooO_o0o0O.0_.
			End Get
			Set(value As String)
				Me.OooO_o0o0O.0_. = value
			End Set
		End Property

		' Token: 0x170005B1 RID: 1457
		' (get) Token: 0x0600198B RID: 6539 RVA: 0x000A5466 File Offset: 0x000A3666
		Public ReadOnly Property baseClass As String
			Get
				Return "weui_cells_title"
			End Get
		End Property

		' Token: 0x0600198C RID: 6540 RVA: 0x000A5470 File Offset: 0x000A3670
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = String.Concat(New String() { "<div id='", MyBase.ID, "' name='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				text = String.Concat(New String() { text, " class='", Me.baseClass, " ", MyBase.[Class], "'" })
			Else
				text = text + " class='" + Me.baseClass + "'"
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text = text + ">" + Me.Text + "</div>"
			A_0.AppendLine(text)
		End Sub

		' Token: 0x04000ABF RID: 2751
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
