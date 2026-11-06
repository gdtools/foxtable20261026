Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000284 RID: 644
	<oO0oooo("0680")>
	Public Class Filler
		' Token: 0x06001F18 RID: 7960 RVA: 0x000C963B File Offset: 0x000C783B
		Public Sub New()
			Me.oo.0O_O. = True
			Me.o_0.00. = True
		End Sub

		' Token: 0x170006FE RID: 1790
		' (get) Token: 0x06001F19 RID: 7961 RVA: 0x000C9651 File Offset: 0x000C7851
		' (set) Token: 0x06001F1A RID: 7962 RVA: 0x000C9659 File Offset: 0x000C7859
		Public Property SourceTable As DataTable
			Get
				Return Me.O._00000.
			End Get
			Set(value As DataTable)
				Me.O._00000. = value
			End Set
		End Property

		' Token: 0x170006FF RID: 1791
		' (get) Token: 0x06001F1B RID: 7963 RVA: 0x000C9662 File Offset: 0x000C7862
		' (set) Token: 0x06001F1C RID: 7964 RVA: 0x000C966A File Offset: 0x000C786A
		Public Property DataTable As DataTable
			Get
				Return Me.OOo__OO.0_00.
			End Get
			Set(value As DataTable)
				Me.OOo__OO.0_00. = value
			End Set
		End Property

		' Token: 0x17000700 RID: 1792
		' (get) Token: 0x06001F1D RID: 7965 RVA: 0x000C9674 File Offset: 0x000C7874
		' (set) Token: 0x06001F1E RID: 7966 RVA: 0x000C9738 File Offset: 0x000C7938
		Public Property SourceCols As String
			Get
				Dim result As String
				If Operators.CompareString(Me.O._0o., "", True) > 0 Then
					result = Me.O._0o.
				ElseIf Operators.CompareString(Me.OOo__OO.0_00., "", True) > 0 Then
					result = Me.OOo__OO.0_00.
				Else
					Dim text As String = ""
					Try
						For Each dataCol As DataCol In Me.SourceTable.DataCols
							If Me.DataTable.DataCols.Contains(dataCol.Name) Then
								text = text + "," + dataCol.Name
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of DataCol)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text.Substring(1)
				End If
				Return result
			End Get
			Set(value As String)
				Me.O._0o. = value
			End Set
		End Property

		' Token: 0x17000701 RID: 1793
		' (get) Token: 0x06001F1F RID: 7967 RVA: 0x000C9744 File Offset: 0x000C7944
		' (set) Token: 0x06001F20 RID: 7968 RVA: 0x000C9808 File Offset: 0x000C7A08
		Public Property DataCols As String
			Get
				Dim result As String
				If Operators.CompareString(Me.OOo__OO.0_00., "", True) > 0 Then
					result = Me.OOo__OO.0_00.
				ElseIf Operators.CompareString(Me.O._0o., "", True) > 0 Then
					result = Me.O._0o.
				Else
					Dim text As String = ""
					Try
						For Each dataCol As DataCol In Me.SourceTable.DataCols
							If Me.DataTable.DataCols.Contains(dataCol.Name) Then
								text = text + "," + dataCol.Name
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of DataCol)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text.Substring(1)
				End If
				Return result
			End Get
			Set(value As String)
				Me.OOo__OO.0_00. = value
			End Set
		End Property

		' Token: 0x17000702 RID: 1794
		' (get) Token: 0x06001F21 RID: 7969 RVA: 0x000C9811 File Offset: 0x000C7A11
		' (set) Token: 0x06001F22 RID: 7970 RVA: 0x000C9819 File Offset: 0x000C7A19
		Public Property Filter As String
			Get
				Return Me.oo.0O_O.
			End Get
			Set(value As String)
				Me.oo.0O_O. = value
			End Set
		End Property

		' Token: 0x17000703 RID: 1795
		' (get) Token: 0x06001F23 RID: 7971 RVA: 0x000C9822 File Offset: 0x000C7A22
		' (set) Token: 0x06001F24 RID: 7972 RVA: 0x000C982A File Offset: 0x000C7A2A
		Public Property ExcludeExistValue As Boolean
			Get
				Return Me.O._0o.
			End Get
			Set(value As Boolean)
				Me.O._0o. = value
			End Set
		End Property

		' Token: 0x17000704 RID: 1796
		' (get) Token: 0x06001F25 RID: 7973 RVA: 0x000C9833 File Offset: 0x000C7A33
		' (set) Token: 0x06001F26 RID: 7974 RVA: 0x000C983B File Offset: 0x000C7A3B
		Public Property ExcludeNullValue As Boolean
			Get
				Return Me.OOo__OO.0_00.
			End Get
			Set(value As Boolean)
				Me.OOo__OO.0_00. = value
			End Set
		End Property

		' Token: 0x17000705 RID: 1797
		' (get) Token: 0x06001F27 RID: 7975 RVA: 0x000C9844 File Offset: 0x000C7A44
		' (set) Token: 0x06001F28 RID: 7976 RVA: 0x000C984C File Offset: 0x000C7A4C
		Public Property Distinct As Boolean
			Get
				Return Me.oo.0O_O.
			End Get
			Set(value As Boolean)
				Me.oo.0O_O. = value
			End Set
		End Property

		' Token: 0x17000706 RID: 1798
		' (get) Token: 0x06001F29 RID: 7977 RVA: 0x000C9855 File Offset: 0x000C7A55
		' (set) Token: 0x06001F2A RID: 7978 RVA: 0x000C985D File Offset: 0x000C7A5D
		Public Property Append As Boolean
			Get
				Return Me.o_0.00.
			End Get
			Set(value As Boolean)
				Me.o_0.00. = value
			End Set
		End Property

		' Token: 0x06001F2B RID: 7979 RVA: 0x000C9866 File Offset: 0x000C7A66
		Public Sub Fill()
			If Me.Distinct Then
				Me.OOo__OO.0_00.()
				Return
			End If
			Me.OOo__OO.0_00.()
		End Sub

		' Token: 0x06001F2C RID: 7980 RVA: 0x000C987D File Offset: 0x000C7A7D
		Friend Sub <<EMPTY_NAME>>()
		End Sub

		' Token: 0x06001F2D RID: 7981 RVA: 0x000C9880 File Offset: 0x000C7A80
		Friend Sub <<EMPTY_NAME>>()
			Dim array As String() = Me.SourceCols.Split(New Char() { ","c })
			Dim text As String = array(0)
			Dim num As Integer = array.Length - 1
			For i As Integer = 1 To num
				text = text + "," + array(i)
			Next
			Dim dataView As DataView = New DataView(Me.SourceTable.BaseTable, Me.Filter, text, DataViewRowState.CurrentRows)
			Dim array2 As String() = Me.DataCols.Split(New Char() { ","c })
			Dim text2 As String = array2(0)
			Dim num2 As Integer = array2.Length - 1
			For j As Integer = 1 To num2
				text2 = text2 + "," + array2(j)
			Next
			Dim dataView2 As DataView = New DataView(Me.DataTable.BaseTable, "", text2, DataViewRowState.CurrentRows)
			Dim num3 As Integer = 0
			Dim array3 As Object() = New Object(array2.Length - 1 + 1 - 1) {}
			Dim count As Integer = Me.DataTable.BaseTable.Rows.Count
			Dim list As List(Of Table) = New List(Of Table)()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable Is Me.DataTable AndAlso table.foxGrid.AllowAddNew Then
						list.Add(table)
						table.foxGrid.AllowAddNew = False
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			OO_00oOO.LockBaseMainForm()
			Me.DataTable.StopRedraw()
			Try
				Dim dataTable As DataTable = Me.DataTable.BaseTable
				Dim num4 As Integer = dataView.Count - 1
				Dim k As Integer = 0
				While k <= num4
					If Not Me.Distinct OrElse k <= 0 Then
						GoTo IL_1E7
					End If
					Dim flag As Boolean = True
					Dim num5 As Integer = array.Length - 1
					For l As Integer = 0 To num5
						If Operators.CompareString(dataView(k)(array(l)).ToString(), dataView(k - 1)(array(l)).ToString(), True) <> 0 Then
							flag = False
							Exit For
						End If
					Next
					If Not flag Then
						GoTo IL_1E7
					End If
					IL_2DB:
					k += 1
					Continue While
					IL_1E7:
					Dim flag2 As Boolean = False
					Dim num6 As Integer = array.Length - 1
					For m As Integer = 0 To num6
						If Me.ExcludeNullValue AndAlso dataView(k).Row.IsNull(array(m)) Then
							flag2 = True
							Exit For
						End If
						array3(m) = RuntimeHelpers.GetObjectValue(dataView(k)(array(m)))
					Next
					If(Me.ExcludeNullValue AndAlso flag2) OrElse (Me.ExcludeExistValue AndAlso dataView2.Find(array3) >= 0) Then
						GoTo IL_2DB
					End If
					num3 += 1
					Dim dataRow As DataRow
					If Not Me.Append AndAlso num3 <= count Then
						dataRow = dataTable.Rows(num3 - 1)
					Else
						dataRow = dataTable.NewRow()
					End If
					Dim num7 As Integer = array2.Length - 1
					For n As Integer = 0 To num7
						dataRow(array2(n)) = RuntimeHelpers.GetObjectValue(array3(n))
					Next
					If dataRow.RowState = DataRowState.Detached Then
						dataTable.Rows.Add(dataRow)
						GoTo IL_2DB
					End If
					GoTo IL_2DB
				End While
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Try
					For Each table2 As Table In list
						table2.foxGrid.AllowAddNew = True
					Next
				Finally
					Dim enumerator2 As List(Of Table).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				Me.DataTable.ResumeRedraw()
				OO_00oOO.UnlockBaseMainForm()
			End Try
		End Sub

		' Token: 0x04000CF9 RID: 3321
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000CFA RID: 3322
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000CFB RID: 3323
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CFC RID: 3324
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CFD RID: 3325
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CFE RID: 3326
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000CFF RID: 3327
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D00 RID: 3328
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D01 RID: 3329
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
