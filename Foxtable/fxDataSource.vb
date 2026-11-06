Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000238 RID: 568
	Public Class fxDataSource
		Inherits DataTable

		' Token: 0x06001A72 RID: 6770 RVA: 0x000AA44D File Offset: 0x000A864D
		Public Sub Combine(LeftCol As String, RightTable As fxDataSource, RightCol As String)
			Oo00.oO.OO.(Me, LeftCol, RightTable, RightCol)
		End Sub

		' Token: 0x06001A73 RID: 6771 RVA: 0x000AA458 File Offset: 0x000A8658
		Public Sub Combine(LeftCol As String(), RightTable As fxDataSource, RightCol As String())
			Oo00.oO.OO.(Me, LeftCol, RightTable, RightCol)
		End Sub

		' Token: 0x06001A74 RID: 6772 RVA: 0x000AA463 File Offset: 0x000A8663
		Public Sub Union(DataTable2 As fxDataSource)
			MyBase.Merge(DataTable2, False, MissingSchemaAction.Ignore)
		End Sub

		' Token: 0x06001A75 RID: 6773 RVA: 0x000AA46E File Offset: 0x000A866E
		Public Function ConvetToDataTable() As DataTable
			Dim dataTable As DataTable = New DataTable(Me, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.())
			dataTable.o.0O000_.()
			Return dataTable
		End Function

		' Token: 0x06001A76 RID: 6774 RVA: 0x000AA488 File Offset: 0x000A8688
		Public Sub Show(TableName As String, Optional TableCaption As String = "")
			Dim left As String = OO_00oOO.MainTable.Name
			If OO_00oOO.DataTables.Contains(TableName) Then
				If OO_00oOO.DataTables(TableName).AddByCode Then
					OO_00oOO.DataTables.Delete(TableName)
				End If
				If OO_00oOO.DataTables.Contains(TableName) Then
					MessageBox.Show("表" + TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
			End If
			MyBase.TableName = TableName
			O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(Me)
			OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(Me, Nothing, Nothing, TableName, O_O0OO.OoO.0OO__0ooo.()))
			OO_00oOO.DataTables(TableName).o.0O000_.()
			OO_00oOO.DataTables(TableName).AddByCode = True
			OO_00oOO.DataTables(TableName).Caption = TableCaption
			Dim dataTable As DataTable = OO_00oOO.DataTables(TableName)
			Try
				For Each dataCol As DataCol In dataTable.DataCols
					If Operators.CompareString(dataCol.BaseColumn.Caption, "", True) > 0 Then
						dataCol.Caption = dataCol.BaseColumn.Caption
						dataCol.BaseColumn.Caption = ""
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			New O_0(O_O0OO.o__.O.(), Me)
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(TableName))
			Main.OO_O.o..o0_o_o_0.0O.(TableName, True, False)
			If Operators.CompareString(left, TableName, True) = 0 Then
				OO_00oOO.MainTable = OO_00oOO.Tables(TableName)
			End If
		End Sub

		' Token: 0x06001A77 RID: 6775 RVA: 0x000AA620 File Offset: 0x000A8820
		Public Function ToDataTable() As DataTable
			Dim dataTable As DataTable = New DataTable(Me, Nothing, Nothing, "", Nothing)
			dataTable.o.0O000_.()
			Try
				For Each dataCol As DataCol In dataTable.DataCols
					If Operators.CompareString(dataCol.BaseColumn.Caption, "", True) > 0 Then
						dataCol.Caption = dataCol.BaseColumn.Caption
						dataCol.BaseColumn.Caption = ""
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return dataTable
		End Function

		' Token: 0x04000B28 RID: 2856
		Friend <<EMPTY_NAME>> As GroupTableBuilder

		' Token: 0x04000B29 RID: 2857
		Friend <<EMPTY_NAME>> As CrossTableBuilder
	End Class
End Namespace
