Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x0200052B RID: 1323
	Public NotInheritable Module Edit
		' Token: 0x0600574B RID: 22347 RVA: 0x00226FE8 File Offset: 0x002251E8
		<oO0oooo("0140")>
		Public Sub SerialFill()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.O0O_OOoOoO.O.()
			End If
		End Sub

		' Token: 0x0600574C RID: 22348 RVA: 0x00226FFB File Offset: 0x002251FB
		<oO0oooo("0140")>
		Public Sub RepeatFill()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.oo.00O.()
			End If
		End Sub

		' Token: 0x0600574D RID: 22349 RVA: 0x00227010 File Offset: 0x00225210
		<oO0oooo("0138")>
		Public Sub Find()
			If Edit.oo0Oo0Oo.OO. Is Nothing OrElse Edit.oo0Oo0Oo.OO..IsDisposed Then
				Edit.oo0Oo0Oo.OO. = New o0o\u3002()
			End If
			Edit.oo0Oo0Oo.OO..Owner = Main.OO_O.o.
			Edit.oo0Oo0Oo.OO..o.0___.(False)
			Edit.oo0Oo0Oo.OO..Show()
		End Sub

		' Token: 0x0600574E RID: 22350 RVA: 0x00227060 File Offset: 0x00225260
		<oO0oooo("0139")>
		Public Sub Replace()
			If Edit.oo_0o_.___o0O. Is Nothing OrElse Edit.oo_0o_.___o0O..IsDisposed Then
				Edit.oo_0o_.___o0O. = New o0o\u3002()
			End If
			Edit.oo_0o_.___o0O..Owner = Main.OO_O.o.
			Edit.oo_0o_.___o0O..o.0___.(True)
			Edit.oo_0o_.___o0O..Text = "替换"
			Edit.oo_0o_.___o0O..Show()
		End Sub

		' Token: 0x0600574F RID: 22351 RVA: 0x002270BD File Offset: 0x002252BD
		Public Sub Undo()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Undo()
			End If
		End Sub

		' Token: 0x06005750 RID: 22352 RVA: 0x002270D0 File Offset: 0x002252D0
		Public Sub Redo()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				OO_00oOO.CurrentTable.Redo()
			End If
		End Sub

		' Token: 0x06005751 RID: 22353 RVA: 0x002270E3 File Offset: 0x002252E3
		Public Sub Copy()
			SendKeys.Send("^C")
		End Sub

		' Token: 0x06005752 RID: 22354 RVA: 0x002270EF File Offset: 0x002252EF
		Public Sub Paste()
			SendKeys.Send("^V")
		End Sub

		' Token: 0x06005753 RID: 22355 RVA: 0x002270FB File Offset: 0x002252FB
		Public Sub Cut()
			SendKeys.Send("^X")
		End Sub

		' Token: 0x06005754 RID: 22356 RVA: 0x00227107 File Offset: 0x00225307
		Public Sub Delete()
			SendKeys.Send("{DELETE}")
		End Sub

		' Token: 0x06005755 RID: 22357 RVA: 0x00227113 File Offset: 0x00225313
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub InsertFile()
			OO_00oOO.CurrentTable
		End Sub

		' Token: 0x06005756 RID: 22358 RVA: 0x0022711B File Offset: 0x0022531B
		<oO0oooo("0142")>
		Public Sub Symbol()
			If Edit.oo0Oo0Oo.OO. Is Nothing OrElse Edit.oo0Oo0Oo.OO..IsDisposed Then
				Edit.oo0Oo0Oo.OO. = New O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002()
			End If
			Edit.oo0Oo0Oo.OO..Owner = Main.OO_O.o.
			Edit.oo0Oo0Oo.OO..Show()
		End Sub

		' Token: 0x06005757 RID: 22359 RVA: 0x00227154 File Offset: 0x00225354
		<oO0oooo("1631")>
		Public Sub Reject()
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim cellRange As CellRange = OO_00oOO.CurrentTable.foxGrid.Selection
				If cellRange.BottomRow <> -1 AndAlso cellRange.TopRow <> -1 AndAlso cellRange.LeftCol <> -1 AndAlso cellRange.RightCol <> -1 Then
					If(cellRange.RightCol - cellRange.LeftCol + 1) * (cellRange.BottomRow - cellRange.TopRow + 1) < 500 Then
						OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(New oOOOo0oOOOO_(OO_00oOO.CurrentTable, OO_00oOO.CurrentTable.foxGrid.Selection))
					Else
						If MessageBox.Show("确定要还原选定区域吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
							Return
						End If
						OO_00oOO.CurrentTable.ClearEditInfos()
					End If
					cellRange = Nothing
					Dim table As Table = OO_00oOO.CurrentTable
					Dim num As Integer = table.TopPosition
					Dim num2 As Integer = table.BottomPosition
					For i As Integer = num To num2
						Dim dataRow As DataRow = table.Rows(i).BaseDataRow
						If dataRow.RowState = DataRowState.Modified Then
							Dim leftCol As Integer = table.foxGrid.Selection.LeftCol
							Dim rightCol As Integer = table.foxGrid.Selection.RightCol
							For j As Integer = leftCol To rightCol
								Dim name As String = table.foxGrid.Cols(j).Name
								If Operators.CompareString(dataRow(name).ToString(), dataRow(name, DataRowVersion.Original).ToString(), True) <> 0 Then
									dataRow(name) = RuntimeHelpers.GetObjectValue(dataRow(name, DataRowVersion.Original))
								End If
							Next
						End If
						list.Add(dataRow)
					Next
					Try
						For Each dataRow As DataRow In list
							Oo00.o0_o._O_.(dataRow)
						Next
					Finally
						Dim enumerator As List(Of DataRow).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
			End If
		End Sub

		' Token: 0x06005758 RID: 22360 RVA: 0x00227360 File Offset: 0x00225560
		<oO0oooo("1648")>
		Public Sub ClearZero()
			Dim table As Table = OO_00oOO.CurrentTable
			Dim leftCol As Integer = table.foxGrid.Selection.LeftCol
			Dim rightCol As Integer = table.foxGrid.Selection.RightCol
			For i As Integer = leftCol To rightCol
				Dim name As String = table.foxGrid.Cols(i).Name
				If table.DataTable.DataCols(name).IsNumeric Then
					Dim num As Integer = table.TopPosition
					Dim num2 As Integer = table.BottomPosition
					For j As Integer = num To num2
						Dim dataRow As DataRow = table.Rows(j).BaseDataRow
						If Not dataRow.IsNull(name) AndAlso Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow(name))) = 0.0 Then
							dataRow(name) = Nothing
						End If
					Next
				End If
			Next
		End Sub

		' Token: 0x04002239 RID: 8761
		Private <<EMPTY_NAME>> As o0o\u3002

		' Token: 0x0400223A RID: 8762
		Private <<EMPTY_NAME>> As o0o\u3002

		' Token: 0x0400223B RID: 8763
		Private <<EMPTY_NAME>> As O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002
	End Module
End Namespace
