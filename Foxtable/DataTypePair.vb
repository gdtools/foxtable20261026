Imports System
Imports System.Collections.Generic

Namespace Foxtable
	' Token: 0x0200029B RID: 667
	Friend Class DataTypePair
		' Token: 0x0600229C RID: 8860 RVA: 0x000ECB50 File Offset: 0x000EAD50
		Public Sub New(A_0 As String, A_1 As ColumnDataTypeEnum)
			Me.Oo_00_oO.00O0O. = A_0
			Me.Oo_00_oO.00O0O. = A_1
		End Sub

		' Token: 0x17000828 RID: 2088
		' (get) Token: 0x0600229D RID: 8861 RVA: 0x000ECB66 File Offset: 0x000EAD66
		Public ReadOnly Property DisplayName As String
			Get
				Return Me.Oo_00_oO.00O0O.
			End Get
		End Property

		' Token: 0x17000829 RID: 2089
		' (get) Token: 0x0600229E RID: 8862 RVA: 0x000ECB6E File Offset: 0x000EAD6E
		Public ReadOnly Property DataType As ColumnDataTypeEnum
			Get
				Return Me.Oo_00_oO.00O0O.
			End Get
		End Property

		' Token: 0x0600229F RID: 8863 RVA: 0x000ECB78 File Offset: 0x000EAD78
		Public Shared Function CreateDataTypePairs(IsADOX As Boolean) As List(Of DataTypePair)
			Dim list As List(Of DataTypePair) = New List(Of DataTypePair)()
			list.Add(New DataTypePair("字符", ColumnDataTypeEnum.[String]))
			list.Add(New DataTypePair("日期时间", ColumnDataTypeEnum.DateTime))
			list.Add(New DataTypePair("逻辑", ColumnDataTypeEnum.[Boolean]))
			list.Add(New DataTypePair("整数", ColumnDataTypeEnum.[Integer]))
			If Not IsADOX Then
				list.Add(New DataTypePair("长整数", ColumnDataTypeEnum.[Long]))
			End If
			list.Add(New DataTypePair("短整数", ColumnDataTypeEnum.[Short]))
			list.Add(New DataTypePair("微整数", ColumnDataTypeEnum.[Byte]))
			list.Add(New DataTypePair("双精度小数", ColumnDataTypeEnum.[Double]))
			list.Add(New DataTypePair("单精度小数", ColumnDataTypeEnum.[Single]))
			list.Add(New DataTypePair("高精度小数", ColumnDataTypeEnum.[Decimal]))
			list.Add(New DataTypePair("备注", ColumnDataTypeEnum.Text))
			Return list
		End Function

		' Token: 0x04000E3B RID: 3643
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000E3C RID: 3644
		Private <<EMPTY_NAME>> As ColumnDataTypeEnum
	End Class
End Namespace
