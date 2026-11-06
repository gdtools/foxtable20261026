Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000B5 RID: 181
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Oooo_0_o_0_
		Implements IComparer(Of TreeNode)

		' Token: 0x06000782 RID: 1922 RVA: 0x0002F740 File Offset: 0x0002D940
		Public Sub New(A_0 As Boolean)
			Me.OO0o0.0OOo_. = A_0
		End Sub

		' Token: 0x06000783 RID: 1923 RVA: 0x0002F750 File Offset: 0x0002D950
		Public Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As TreeNode) As Integer Implements System.Collections.Generic.IComparer(Of System.Windows.Forms.TreeNode).Compare
			Dim result As Integer
			If Operators.CompareString(A_0.Text, "显示所有行", True) = 0 Then
				result = -1
			ElseIf Operators.CompareString(A_1.Text, "显示所有行", True) = 0 Then
				result = 1
			Else
				Dim x As Integer
				Dim y As Integer
				Dim num As Integer
				If Integer.TryParse(A_0.Name, x) AndAlso Integer.TryParse(A_1.Name, y) Then
					num = Comparer(Of Integer).[Default].Compare(x, y)
				Else
					num = Comparer(Of String).[Default].Compare(A_0.Name, A_1.Name)
				End If
				If num = 0 Then
					num = String.Compare(A_0.OO_.O.(), A_1.OO_.O.())
				End If
				If Me.OO0o0.0OOo_. Then
					num = -num
				End If
				result = num
			End If
			Return result
		End Function

		' Token: 0x0400023F RID: 575
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
