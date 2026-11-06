Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000276 RID: 630
	<DefaultMember("Items")>
	Friend Class oOo_
		Implements IEnumerable(Of O_0O_)

		' Token: 0x06001E3E RID: 7742 RVA: 0x000C0BE3 File Offset: 0x000BEDE3
		Friend Sub New(A_0 As o_oo0)
			Me.O.0_O. = A_0
		End Sub

		' Token: 0x06001E3F RID: 7743 RVA: 0x000C0BF4 File Offset: 0x000BEDF4
		Friend Function <<EMPTY_NAME>>(A_0 As String) As O_0O_
			For Each dataRow As DataRow In Me.O.0_O..oo__._..[Select]("", "", DataViewRowState.CurrentRows)
				If Operators.CompareString(A_0, Conversions.ToString(dataRow("TableName")), True) = 0 Then
					Return New O_0O_(dataRow)
				End If
			Next
			MessageBox.Show("表[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Return Nothing
		End Function

		' Token: 0x06001E40 RID: 7744 RVA: 0x000C0C74 File Offset: 0x000BEE74
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As O_0O_
			Dim num As Integer = 0
			For Each a_ As DataRow In Me.O.0_O..oo__._..[Select]("", "", DataViewRowState.CurrentRows)
				If num = A_0 Then
					Return New O_0O_(a_)
				End If
				num += 1
			Next
			MessageBox.Show("表索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Return Nothing
		End Function

		' Token: 0x06001E41 RID: 7745 RVA: 0x000C0CDC File Offset: 0x000BEEDC
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Not Me.oooO__O_0o_.o_.(A_0) Then
				MessageBox.Show("表[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			For Each dataRow As DataRow In Me.O.0_O..oo__._..[Select]("", "", DataViewRowState.CurrentRows)
				If Operators.CompareString(A_0, Conversions.ToString(dataRow("TableName")), True) = 0 Then
					dataRow.Delete()
					Return
				End If
			Next
		End Sub

		' Token: 0x06001E42 RID: 7746 RVA: 0x000C0D60 File Offset: 0x000BEF60
		Friend Function <<EMPTY_NAME>>(A_0 As String) As O_0O_
			Dim result As O_0O_
			If Me.oooO__O_0o_.o_.(A_0) Then
				MessageBox.Show("表[" + A_0 + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			ElseIf Not o_O_o_oOoo__.O_o_._o0.(A_0) Then
				result = Nothing
			Else
				Dim dataRow As DataRow = Me.O.0_O..oo__._..NewRow()
				dataRow("TableName") = A_0
				Me.O.0_O..oo__._..Rows.Add(dataRow)
				result = New O_0O_(dataRow)
			End If
			Return result
		End Function

		' Token: 0x06001E43 RID: 7747 RVA: 0x000C0DDF File Offset: 0x000BEFDF
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.O.0_O..oo__._..[Select]("", "", DataViewRowState.CurrentRows).Length
		End Function

		' Token: 0x06001E44 RID: 7748 RVA: 0x000C0E00 File Offset: 0x000BF000
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim array As DataRow() = Me.O.0_O..oo__._..[Select]("", "", DataViewRowState.CurrentRows)
			For i As Integer = 0 To array.Length - 1
				If Operators.CompareString(Conversions.ToString(array(i)("TableName")), A_0, True) = 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x06001E45 RID: 7749 RVA: 0x000C0E5A File Offset: 0x000BF05A
		Friend Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New o_OO_OOO_(Me)
		End Function

		' Token: 0x06001E46 RID: 7750 RVA: 0x000C0E62 File Offset: 0x000BF062
		Friend Function <<EMPTY_NAME>>() As IEnumerator(Of O_0O_) Implements System.Collections.Generic.IEnumerable(Of Foxtable.O_0O_).GetEnumerator
			Return New o_OO_OOO_(Me)
		End Function

		' Token: 0x04000CA7 RID: 3239
		Private <<EMPTY_NAME>> As o_oo0
	End Class
End Namespace
