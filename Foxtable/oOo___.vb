Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000BC RID: 188
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oOo___
		Implements IComparer(Of TreeNode)

		' Token: 0x06000835 RID: 2101 RVA: 0x00037B3B File Offset: 0x00035D3B
		Public Sub New(A_0 As O0_0_0O0___O, A_1 As Boolean)
			Me.o0.OOOo. = A_0
			Me.o0.OOOo. = A_1
		End Sub

		' Token: 0x06000836 RID: 2102 RVA: 0x00037B54 File Offset: 0x00035D54
		Public Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As TreeNode) As Integer Implements System.Collections.Generic.IComparer(Of System.Windows.Forms.TreeNode).Compare
			Dim result As Integer
			If Operators.CompareString(A_0.Text, "显示所有行", True) = 0 Then
				result = -1
			ElseIf Operators.CompareString(A_1.Text, "显示所有行", True) = 0 Then
				result = 1
			Else
				Dim array As Integer() = New Integer() { Integer.MinValue, Integer.MinValue }
				Dim array2 As Integer() = New Integer() { Integer.MinValue, Integer.MinValue }
				Dim array3 As String() = New String(1) {}
				Dim array4 As TreeNode() = New TreeNode() { A_0, A_1 }
				Dim num As Integer = 0
				Do
					If array4(num).Text.IndexOf("(") >= 0 AndAlso array4(num).Text.IndexOf(")") >= 0 Then
						array3(num) = array4(num).Text.Substring(array4(num).Text.LastIndexOf("("))
						array3(num) = array3(num).Trim(New Char() { "("c, ")"c })
						Dim array5 As String() = array3(num).Split(New Char() { ","c })
						If array5.Length = 1 Then
							Integer.TryParse(array5(0), array(num))
						ElseIf array5.Length = 2 Then
							If Me.o0.OOOo. = O0_0_0O0___O.OOO.__O_oO_. Then
								Integer.TryParse(array5(1), array(num))
							Else
								Integer.TryParse(array5(0), array(num))
								Integer.TryParse(array5(1), array2(num))
							End If
						End If
					End If
					num += 1
				Loop While num <= 1
				If array(0) = array(1) AndAlso (array2(0) > -2147483648 OrElse array2(1) > -2147483648) Then
					array(0) = array2(0)
					array(1) = array2(1)
				End If
				Dim num2 As Integer = Comparer(Of Integer).[Default].Compare(array(0), array(1))
				If Me.o0.OOOo. Then
					num2 = -num2
				End If
				If num2 = 0 Then
					result = Comparer.DefaultInvariant.Compare(A_0.Text, A_1.Text)
				Else
					result = num2
				End If
			End If
			Return result
		End Function

		' Token: 0x040002C2 RID: 706
		Private <<EMPTY_NAME>> As O0_0_0O0___O

		' Token: 0x040002C3 RID: 707
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
