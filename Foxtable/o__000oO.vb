Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200009C RID: 156
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o__000oO
		Implements IComparer(Of TreeNode)

		' Token: 0x060005C5 RID: 1477 RVA: 0x0001E181 File Offset: 0x0001C381
		Public Sub New(A_0 As Dictionary(Of TreeNode, DataRowView), A_1 As String, A_2 As Boolean)
			Me.OO0o0.0OOo_. = A_0
			Me.OO0o0.0OOo_. = New O0_(A_1, A_2)
		End Sub

		' Token: 0x060005C6 RID: 1478 RVA: 0x0001E19D File Offset: 0x0001C39D
		Public Sub New(A_0 As Dictionary(Of TreeNode, DataRowView), A_1 As String, A_2 As Boolean, A_3 As Char)
			Me.OO0o0.0OOo_. = A_0
			Me.OO0o0.0OOo_. = New O0_(A_1, A_2, A_3)
		End Sub

		' Token: 0x060005C7 RID: 1479 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		Public Function <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As TreeNode) As Integer Implements System.Collections.Generic.IComparer(Of System.Windows.Forms.TreeNode).Compare
			Dim dataRowView As DataRowView = Nothing
			Dim dataRowView2 As DataRowView = Nothing
			Dim result As Integer
			If Operators.CompareString(A_0.Text, "显示所有行", True) = 0 Then
				result = -1
			ElseIf Operators.CompareString(A_1.Text, "显示所有行", True) = 0 Then
				result = 1
			Else
				Me.OO0o0.0OOo_..TryGetValue(A_0, dataRowView)
				Me.OO0o0.0OOo_..TryGetValue(A_1, dataRowView2)
				If dataRowView Is Nothing OrElse dataRowView2 Is Nothing Then
					result = 0
				Else
					Dim num As Integer = Me.OO0o0.0OOo_..Oo_00_oO.00O0O.(dataRowView, dataRowView2)
					If num = 0 Then
						result = Comparer.DefaultInvariant.Compare(A_0.Text, A_1.Text)
					Else
						result = num
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x04000163 RID: 355
		Private <<EMPTY_NAME>> As Dictionary(Of TreeNode, DataRowView)

		' Token: 0x04000164 RID: 356
		Private <<EMPTY_NAME>> As O0_
	End Class
End Namespace
