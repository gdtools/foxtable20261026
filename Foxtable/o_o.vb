Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000BB RID: 187
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_o
		Implements IComparer(Of TreeNode)

		' Token: 0x06000833 RID: 2099 RVA: 0x00037A59 File Offset: 0x00035C59
		Public Sub New(A_0 As Boolean)
			Me.OO0o0.0OOo_. = A_0
		End Sub

		' Token: 0x06000834 RID: 2100 RVA: 0x00037A68 File Offset: 0x00035C68
		Public Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As TreeNode) As Integer Implements System.Collections.Generic.IComparer(Of System.Windows.Forms.TreeNode).Compare
			Dim text As String = A_0.Text
			Dim text2 As String = A_1.Text
			Dim result As Integer
			If Operators.CompareString(text, "显示所有行", True) = 0 Then
				result = -1
			ElseIf Operators.CompareString(text2, "显示所有行", True) = 0 Then
				result = 1
			Else
				If text.IndexOf("(") > 0 AndAlso text.EndsWith(")") Then
					text = text.Substring(0, text.IndexOf("("))
				End If
				If text2.IndexOf("(") > 0 AndAlso text2.EndsWith(")") Then
					text2 = text2.Substring(0, text2.IndexOf("("))
				End If
				If Me.OO0o0.0OOo_. Then
					result = -String.Compare(A_0.Text, A_1.Text, True)
				Else
					result = String.Compare(A_0.Text, A_1.Text, True)
				End If
			End If
			Return result
		End Function

		' Token: 0x040002C1 RID: 705
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
