Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x0200052F RID: 1327
	<oO0oooo("0116")>
	Public NotInheritable Module Sort
		' Token: 0x060057E9 RID: 22505 RVA: 0x0022CE6C File Offset: 0x0022B06C
		Public Sub Ascending()
			Sort.OO.OO_0o.(False)
		End Sub

		' Token: 0x060057EA RID: 22506 RVA: 0x0022CE74 File Offset: 0x0022B074
		Public Sub Descending()
			Sort.OO.OO_0o.(True)
		End Sub

		' Token: 0x060057EB RID: 22507 RVA: 0x0022CE7C File Offset: 0x0022B07C
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.ClearEditInfos()
				Dim text As String = ""
				Dim text2 As String = ""
				Dim leftCol As Integer = table.foxGrid.Selection.LeftCol
				Dim rightCol As Integer = table.foxGrid.Selection.RightCol
				For i As Integer = leftCol To rightCol
					If Operators.CompareString(text2, "", True) > 0 Then
						text2 += ","
					End If
					Dim text3 As String = table.foxGrid.Cols(i).Name.ToLower()
					text2 += text3
					If A_0 Then
						text2 += " DESC"
					End If
					If table.O_O__.ooOo..ContainsKey(text3.ToLower()) Then
						table.O_O__.ooOo..Remove(text3)
					End If
				Next
				Try
					For Each text4 As String In table.O_O__.ooOo..Keys
						If Operators.CompareString(text, "", True) > 0 Then
							text += ","
						End If
						If table.O_O__.ooOo.(text4) = ListSortDirection.Descending Then
							text = text + text4 + " DESC"
						Else
							text += text4
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, ListSortDirection).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If Operators.CompareString(text2, "", True) > 0 Then
					If Operators.CompareString(text, "", True) > 0 Then
						table.Sort = text2 + "," + text
						Return
					End If
					table.Sort = text2
				End If
			End If
		End Sub

		' Token: 0x060057EC RID: 22508 RVA: 0x0022D014 File Offset: 0x0022B214
		Public Sub UnSort()
			Dim table As Table = OO_00oOO.CurrentTable
			If table IsNot Nothing Then
				table.ClearEditInfos()
				table.View.o_O_.00o.("")
				table.Sort = ""
			End If
		End Sub
	End Module
End Namespace
