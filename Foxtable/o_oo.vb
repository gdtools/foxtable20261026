Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x0200008A RID: 138
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_oo
		Implements IComparer(Of DataRow)

		' Token: 0x06000510 RID: 1296 RVA: 0x0001CCBA File Offset: 0x0001AEBA
		Public Sub New(A_0 As String, A_1 As Boolean)
			Me.OO0._o_00000. = A_0
			Me.OO0._o_00000. = A_1
		End Sub

		' Token: 0x06000511 RID: 1297 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		Private Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataRow) As Integer
			Dim num As Integer = 0
			Dim result As Integer
			If A_0.IsNull(Me.OO0._o_00000.) AndAlso A_1.IsNull(Me.OO0._o_00000.) Then
				result = -1
			Else
				If A_0.IsNull(Me.OO0._o_00000.) OrElse A_1.IsNull(Me.OO0._o_00000.) Then
					If Not A_0.IsNull(Me.OO0._o_00000.) Then
						num = 1
					ElseIf Not A_1.IsNull(Me.OO0._o_00000.) Then
						num = -1
					End If
				Else
					num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0(Me.OO0._o_00000.)), RuntimeHelpers.GetObjectValue(A_1(Me.OO0._o_00000.)))
				End If
				If Not Me.OO0._o_00000. Then
					result = num
				Else
					result = -num
				End If
			End If
			Return result
		End Function

		' Token: 0x06000512 RID: 1298 RVA: 0x0001CD7C File Offset: 0x0001AF7C
		Public Function <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataRow) As Integer Implements System.Collections.Generic.IComparer(Of System.Data.DataRow).Compare
			Dim result As Integer
			If A_0 Is Nothing OrElse A_1 Is Nothing Then
				If A_0 IsNot Nothing Then
					result = 1
				ElseIf A_1 IsNot Nothing Then
					result = -1
				Else
					result = 0
				End If
			Else
				result = Me.OO0._o_00000.(A_0, A_1)
			End If
			Return result
		End Function

		' Token: 0x04000115 RID: 277
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000116 RID: 278
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
