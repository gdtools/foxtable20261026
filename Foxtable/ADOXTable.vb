Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.OleDb
Imports ADOX
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000236 RID: 566
	<oO0oooo("2122")>
	Public Class ADOXTable
		' Token: 0x06001A6B RID: 6763 RVA: 0x000AA17C File Offset: 0x000A837C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub New(A_0 As Table, A_1 As Boolean, A_2 As Boolean, A_3 As String)
			Me.oooO__O_0o_.o_. = A_0
			Me.oooO__O_0o_.o_. = A_1
			Me.O_.0_O__OOoOo. = A_2
			Try
				For Each left As String In O_O0OO.O._o_.().Keys
					If Operators.CompareString(left, A_3, True) = 0 Then
						Me.oooO__O_0o_.o_. = left
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06001A6C RID: 6764 RVA: 0x000AA1FC File Offset: 0x000A83FC
		Public Sub Rename(newName As String)
			If Me.O_.0_O__OOoOo. Then
				Me.oooO__O_0o_.o_..Name = "~TMPCLP" + newName
				Return
			End If
			If Not Me.oooO__O_0o_.o_. Then
				Me.oooO__O_0o_.o_..Name = newName
				Return
			End If
			New SQLCommand() With { .ConnectionName = Me.oooO__O_0o_.o_., .CommandText = String.Concat(New String() { "exec sp_rename '", Me.oooO__O_0o_.o_..Name, "','", newName, "'" }) }.ExecuteNonQuery()
		End Sub

		' Token: 0x06001A6D RID: 6765 RVA: 0x000AA294 File Offset: 0x000A8494
		Public Sub AddColumn(Name As String, DataType As ADOXType, Optional Length As Integer = 16)
			If o_O_o_oOoo__.OO_.O.(Name) Then
				Dim type As DataTypeEnum = Me.ConertType(DataType)
				Dim column As Column = New ColumnClass()
				column.Name = Name
				column.Type = type
				If DataType = ADOXType.[String] Then
					column.DefinedSize = Length
				End If
				If DataType <> ADOXType.[Boolean] OrElse Me.oooO__O_0o_.o_. Then
					column.Attributes = 2
				End If
				If column.Type = 131 Then
					column.Precision = 28
					column.NumericScale = 14
				End If
				Me.oooO__O_0o_.o_..Columns.Append(column, 202, 0)
			End If
		End Sub

		' Token: 0x06001A6E RID: 6766 RVA: 0x000AA318 File Offset: 0x000A8518
		Public Sub RenameColumn(OldName As String, NewName As String)
			If Not Me.oooO__O_0o_.o_. Then
				Me.oooO__O_0o_.o_..Columns(OldName).Name = NewName
				Return
			End If
			New SQLCommand() With { .ConnectionName = Me.oooO__O_0o_.o_., .CommandText = String.Concat(New String() { "exec sp_rename '", Me.oooO__O_0o_.o_..Name, ".", OldName, "','", NewName, "','column'" }) }.ExecuteNonQuery()
		End Sub

		' Token: 0x06001A6F RID: 6767 RVA: 0x000AA3A5 File Offset: 0x000A85A5
		Public Sub DeleteColumn(Name As String)
			Me.oooO__O_0o_.o_..Columns.Delete(Name)
		End Sub

		' Token: 0x06001A70 RID: 6768 RVA: 0x000AA3B8 File Offset: 0x000A85B8
		Private Function ConertType(DataType As ADOXType) As DataTypeEnum
			Dim result As DataTypeEnum
			Select Case DataType
				Case ADOXType.[String]
					result = 202
				Case ADOXType.DateTime
					If Me.oooO__O_0o_.o_. Then
						result = 135
					Else
						result = 7
					End If
				Case ADOXType.[Boolean]
					result = 11
				Case ADOXType.Text
					result = 203
				Case ADOXType.[Integer]
					result = 3
				Case ADOXType.[Long]
					result = 20
				Case ADOXType.[Short]
					result = 2
				Case ADOXType.[Byte]
					result = 17
				Case ADOXType.[Double]
					result = 5
				Case ADOXType.[Single]
					result = 4
				Case ADOXType.[Decimal]
					result = 131
			End Select
			Return result
		End Function

		' Token: 0x04000B18 RID: 2840
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04000B19 RID: 2841
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B1A RID: 2842
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B1B RID: 2843
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
