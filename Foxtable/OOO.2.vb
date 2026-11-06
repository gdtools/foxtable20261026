Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020000B6 RID: 182
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OOO
		Implements IComparer

		' Token: 0x06000784 RID: 1924 RVA: 0x0002F7F2 File Offset: 0x0002D9F2
		Public Sub New(A_0 As String, A_1 As Boolean, A_2 As Boolean)
			Me.o_0ooO.Oo. = vbNullChar
			Me.O_OOO.0o. = New O0_(A_0, A_1)
			Me.O_OOO.0o. = A_2
		End Sub

		' Token: 0x06000785 RID: 1925 RVA: 0x0002F815 File Offset: 0x0002DA15
		Public Sub New(A_0 As String, A_1 As Boolean, A_2 As Boolean, A_3 As Char)
			Me.o_0ooO.Oo. = vbNullChar
			Me.O_OOO.0o. = New O0_(A_0, A_1, A_3)
			Me.O_OOO.0o. = A_2
			Me.o_0ooO.Oo. = A_3
		End Sub

		' Token: 0x06000786 RID: 1926 RVA: 0x0002F844 File Offset: 0x0002DA44
		Public Function <<EMPTY_NAME>>(A_0 As Object, A_1 As Object) As Integer Implements System.Collections.IComparer.Compare
			If Not Me.O_OOO.0o. Then
				Dim num As Integer = String.Compare(CType(A_0, TreeNode).Name, CType(A_1, TreeNode).Name)
				If num <> 0 Then
					Return num
				End If
			End If
			Dim num2 As Integer = Me.O_OOO.0o..Oo_00_oO.00O0O.(CType(CType(A_0, TreeNode).Tag, DataRowView), CType(CType(A_1, TreeNode).Tag, DataRowView))
			Dim result As Integer
			If num2 = 0 Then
				result = String.Compare(CType(A_0, TreeNode).Text, CType(A_1, TreeNode).Text)
			Else
				result = num2
			End If
			Return result
		End Function

		' Token: 0x04000240 RID: 576
		Private <<EMPTY_NAME>> As O0_

		' Token: 0x04000241 RID: 577
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000242 RID: 578
		Private <<EMPTY_NAME>> As Char
	End Class
End Namespace
