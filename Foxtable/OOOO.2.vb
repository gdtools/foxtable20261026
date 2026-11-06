Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000273 RID: 627
	<DefaultMember("Item")>
	Friend Class OOOO
		Implements IEnumerable(Of o_0OO0_)

		' Token: 0x06001E27 RID: 7719 RVA: 0x000C0712 File Offset: 0x000BE912
		Friend Sub New(A_0 As DataRow)
			Me.OO00o__OOO.o0_. = A_0
		End Sub

		' Token: 0x06001E28 RID: 7720 RVA: 0x000C0724 File Offset: 0x000BE924
		Friend Function <<EMPTY_NAME>>(A_0 As String) As o_0OO0_
			For Each dataRow As DataRow In Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current)
				If Operators.CompareString(Conversions.ToString(dataRow("ColumnName")), A_0, True) = 0 Then
					Return New o_0OO0_(dataRow)
				End If
			Next
			MessageBox.Show("列[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Return Nothing
		End Function

		' Token: 0x06001E29 RID: 7721 RVA: 0x000C079C File Offset: 0x000BE99C
		Friend Function <<EMPTY_NAME>>(A_0 As Integer) As o_0OO0_
			Dim childRows As DataRow() = Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current)
			Dim result As o_0OO0_
			If childRows.Length > A_0 AndAlso A_0 >= 0 Then
				result = New o_0OO0_(childRows(A_0))
			Else
				MessageBox.Show("列索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001E2A RID: 7722 RVA: 0x000C07EA File Offset: 0x000BE9EA
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current).Length
		End Function

		' Token: 0x06001E2B RID: 7723 RVA: 0x000C0804 File Offset: 0x000BEA04
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			If o_O_o_oOoo__.oO.O_..Contains(A_0) Then
				result = False
			Else
				Dim childRows As DataRow() = Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current)
				For i As Integer = 0 To childRows.Length - 1
					If Operators.CompareString(Conversions.ToString(childRows(i)("ColumnName")), A_0, True) = 0 Then
						Return True
					End If
				Next
				result = False
			End If
			Return result
		End Function

		' Token: 0x06001E2C RID: 7724 RVA: 0x000C0868 File Offset: 0x000BEA68
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As ColumnDataTypeEnum, Optional A_2 As Integer = -2147483648) As o_0OO0_
			Dim result As o_0OO0_
			If Me.O_o0.Oo00o0.(A_0) Then
				MessageBox.Show("列[" + A_0 + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			ElseIf Not o_O_o_oOoo__.OO_.O.(A_0) Then
				result = Nothing
			ElseIf A_2 <> -2147483648 AndAlso Not o_0OO0_.O_o0.Oo00o0.(A_2) Then
				result = Nothing
			Else
				Dim dataRow As DataRow = Me.OO00o__OOO.o0_..Table.DataSet.Tables("tblColumns").NewRow()
				dataRow("TableName") = RuntimeHelpers.GetObjectValue(Me.OO00o__OOO.o0_.("TableName"))
				dataRow("ColumnName") = A_0
				dataRow("DataType") = A_1
				If A_2 <> -2147483648 Then
					dataRow("MaxLength") = A_2
				Else
					dataRow("MaxLength") = 16
				End If
				Me.OO00o__OOO.o0_..Table.DataSet.Tables("tblColumns").Rows.Add(dataRow)
				result = New o_0OO0_(dataRow)
			End If
			Return result
		End Function

		' Token: 0x06001E2D RID: 7725 RVA: 0x000C098C File Offset: 0x000BEB8C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			For Each dataRow As DataRow In Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current)
				If Operators.CompareString(Conversions.ToString(dataRow("ColumnName")), A_0, True) = 0 Then
					dataRow.Delete()
				End If
			Next
		End Sub

		' Token: 0x06001E2E RID: 7726 RVA: 0x000C09E0 File Offset: 0x000BEBE0
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim childRows As DataRow() = Me.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current)
			If childRows.Length > A_0 And A_0 >= 0 Then
				childRows(A_0).Delete()
			End If
		End Sub

		' Token: 0x06001E2F RID: 7727 RVA: 0x000C0A1B File Offset: 0x000BEC1B
		Friend Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New oOO0_Oo0oO(Me)
		End Function

		' Token: 0x06001E30 RID: 7728 RVA: 0x000C0A23 File Offset: 0x000BEC23
		Friend Function <<EMPTY_NAME>>() As IEnumerator(Of o_0OO0_) Implements System.Collections.Generic.IEnumerable(Of Foxtable.o_0OO0_).GetEnumerator
			Return New oOO0_Oo0oO(Me)
		End Function

		' Token: 0x04000CA1 RID: 3233
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
