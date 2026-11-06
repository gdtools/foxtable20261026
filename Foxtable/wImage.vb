Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200020E RID: 526
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wImage
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018B9 RID: 6329 RVA: 0x000A0F78 File Offset: 0x0009F178
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.oo._00. = A_2
		End Sub

		' Token: 0x17000572 RID: 1394
		' (get) Token: 0x060018BA RID: 6330 RVA: 0x000A0F89 File Offset: 0x0009F189
		' (set) Token: 0x060018BB RID: 6331 RVA: 0x000A0F91 File Offset: 0x0009F191
		Public Property Image As String
			Get
				Return Me.oo._00.
			End Get
			Set(value As String)
				Me.oo._00. = value
			End Set
		End Property

		' Token: 0x060018BC RID: 6332 RVA: 0x000A0F9C File Offset: 0x0009F19C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHtml(sb As StringBuilder, wui As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Me.oo._00..StartsWith("weui_icon", StringComparison.CurrentCultureIgnoreCase) Then
				sb.Append("<i id='" + MyBase.ID + "' class='" + Me.oo._00.)
				If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
					sb.Append(" " + MyBase.[Class])
				End If
				sb.Append("'")
				If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
					sb.AppendLine(" " + MyBase.Attribute)
				End If
				sb.AppendLine("></i>")
				Return
			End If
			sb.Append(String.Concat(New String() { "<img id='", MyBase.ID, "' src='", Me.oo._00., "'" }))
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				sb.Append(" class='" + MyBase.[Class] + "'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				sb.AppendLine(" " + MyBase.Attribute)
			End If
			sb.AppendLine("/>")
		End Sub

		' Token: 0x04000A5F RID: 2655
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
