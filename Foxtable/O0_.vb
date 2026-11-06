Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200009D RID: 157
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O0_
		Implements IComparer

		' Token: 0x060005C8 RID: 1480 RVA: 0x0001E250 File Offset: 0x0001C450
		Public Sub New(A_0 As String, A_1 As Boolean)
			Me.o.oOOOo___o_. = vbNullChar
			Me.o.oOOOo___o_. = A_0
			Me.o.oOOOo___o_. = A_1
		End Sub

		' Token: 0x060005C9 RID: 1481 RVA: 0x0001E26D File Offset: 0x0001C46D
		Public Sub New(A_0 As String, A_1 As Boolean, A_2 As Char)
			Me.o.oOOOo___o_. = vbNullChar
			Me.o.oOOOo___o_. = A_0
			Me.o.oOOOo___o_. = A_1
			Me.o.oOOOo___o_. = A_2
		End Sub

		' Token: 0x060005CA RID: 1482 RVA: 0x0001E294 File Offset: 0x0001C494
		Private Function <<EMPTY_NAME>>(A_0 As DataRowView, A_1 As DataRowView) As Integer
			Dim num As Integer = 0
			If A_0.Row.IsNull(Me.o.oOOOo___o_.) OrElse A_1.Row.IsNull(Me.o.oOOOo___o_.) Then
				If Not A_0.Row.IsNull(Me.o.oOOOo___o_.) Then
					num = 1
				ElseIf Not A_1.Row.IsNull(Me.o.oOOOo___o_.) Then
					num = -1
				End If
			ElseIf Me.o.oOOOo___o_. > vbNullChar AndAlso A_0.DataView.Table.Columns(Me.o.oOOOo___o_.).DataType Is GetType(String) Then
				Dim array As String() = A_0(Me.o.oOOOo___o_.).ToString().Split(New Char() { Me.o.oOOOo___o_. })
				Dim array2 As String() = A_1(Me.o.oOOOo___o_.).ToString().Split(New Char() { Me.o.oOOOo___o_. })
				If array.All(AddressOf Me.Oo_00_oO.00O0O.) AndAlso array2.All(AddressOf Me.Oo_00_oO.00O0O.) Then
					Dim num2 As Integer = Math.Min(array.Length, array2.Length) - 1
					For i As Integer = 0 To num2
						num = Comparer(Of Integer).[Default].Compare(Conversions.ToInteger(array(i)), Conversions.ToInteger(array2(i)))
						If num <> 0 Then
							Exit For
						End If
					Next
					If num = 0 Then
						num = Comparer(Of Integer).[Default].Compare(array.Length, array2.Length)
					End If
				Else
					num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0(Me.o.oOOOo___o_.)), RuntimeHelpers.GetObjectValue(A_1(Me.o.oOOOo___o_.)))
				End If
			Else
				num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0(Me.o.oOOOo___o_.)), RuntimeHelpers.GetObjectValue(A_1(Me.o.oOOOo___o_.)))
			End If
			Dim result As Integer
			If Not Me.o.oOOOo___o_. Then
				result = num
			Else
				result = -num
			End If
			Return result
		End Function

		' Token: 0x060005CB RID: 1483 RVA: 0x0001E474 File Offset: 0x0001C674
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim num As Integer
			Return Integer.TryParse(A_0, num)
		End Function

		' Token: 0x060005CC RID: 1484 RVA: 0x0001E48C File Offset: 0x0001C68C
		Public Function <<EMPTY_NAME>>(A_0 As Object, A_1 As Object) As Integer Implements System.Collections.IComparer.Compare
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
				result = Me.Oo_00_oO.00O0O.(CType(A_0, DataRowView), CType(A_1, DataRowView))
			End If
			Return result
		End Function

		' Token: 0x04000165 RID: 357
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000166 RID: 358
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000167 RID: 359
		Private <<EMPTY_NAME>> As Char
	End Class
End Namespace
