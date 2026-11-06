Imports System
Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200009A RID: 154
	Friend Class Oo0
		' Token: 0x060005B2 RID: 1458 RVA: 0x0001D924 File Offset: 0x0001BB24
		Friend Function <<EMPTY_NAME>>(A_0 As Table) As String
			Dim row As Row = Nothing
			Dim row2 As Row = Nothing
			If A_0.Rows.Count > 0 Then
				row = A_0.Rows(0)
			End If
			If A_0.Rows.Count > 1 Then
				row2 = A_0.Rows(1)
			End If
			Dim result As String
			If row IsNot Nothing AndAlso Not Me.O_OOO.0o.(New Row() { row, row2 }) Then
				result = Me.o0o0OOO.OO0o.(A_0)
			ElseIf A_0.Rows.Count = 0 Then
				result = "1"
			Else
				Dim hashSet As HashSet(Of Integer) = New HashSet(Of Integer)()
				Dim num As Integer
				For Each dataRow As DataRow In A_0.DataTable.BaseTable.[Select]("sys_Hierarchy_Level= 0", "", DataViewRowState.CurrentRows)
					If Not dataRow.IsNull(Me.OOOO._.) AndAlso Integer.TryParse(dataRow(Me.OOOO._.).ToString(), num) Then
						hashSet.Add(num)
					End If
				Next
				num = 1
				While hashSet.Contains(num)
					num += 1
				End While
				If Operators.CompareString(Me.OOOO._., "", True) > 0 AndAlso Me.O_OOO.0o. IsNot Nothing AndAlso Me.O_OOO.0o..Length > 0 Then
					result = Strings.Format(num, New String("0"c, Me.O_OOO.0o.(0)))
				Else
					result = num.ToString()
				End If
			End If
			Return result
		End Function

		' Token: 0x060005B3 RID: 1459 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		Friend Function <<EMPTY_NAME>>(A_0 As Row, A_1 As Row) As String
			Dim str As String = A_0(Me.OOOO._.).ToString()
			Dim children As List(Of Row) = A_0.GetChildren(False)
			Dim hashSet As HashSet(Of Integer) = New HashSet(Of Integer)()
			Dim result As String
			If Operators.CompareString(Conversions.ToString(Me.O_OOO.0o.), "", True) > 0 AndAlso Operators.CompareString(Me.OOOO._., "", True) > 0 Then
				If Not Me.O_OOO.0o.(New Row() { A_0, A_1 }) Then
					result = Me.o0o0OOO.OO0o.(A_0, A_1)
				ElseIf children.Count > 0 Then
					Dim num As Integer
					Try
						For Each row As Row In children
							If Not row.get_IsNull(Me.OOOO._.) Then
								Dim array As String() = row(Me.OOOO._.).ToString().Split(New Char() { Me.O_OOO.0o. })
								If Integer.TryParse(array(array.Length - 1), num) Then
									hashSet.Add(num)
								End If
							End If
						Next
					Finally
						Dim enumerator As List(Of Row).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					num = 1
					While hashSet.Contains(num)
						num += 1
					End While
					result = str + Conversions.ToString(Me.O_OOO.0o.) + num.ToString()
				Else
					result = str + Conversions.ToString(Me.O_OOO.0o.) + "1"
				End If
			ElseIf Operators.CompareString(Me.OOOO._., "", True) > 0 AndAlso Me.O_OOO.0o. IsNot Nothing AndAlso Me.O_OOO.0o..Length > 0 Then
				Dim num2 As Integer = Conversions.ToInteger(A_0("sys_Hierarchy_Level")) + 1
				Dim num3 As Integer
				If num2 <= Me.O_OOO.0o..Length - 1 Then
					num3 = Me.O_OOO.0o.(num2)
				Else
					num3 = Me.O_OOO.0o.(Me.O_OOO.0o..Length - 1)
				End If
				If children.Count > 0 Then
					Dim num As Integer
					Try
						For Each row2 As Row In children
							If Not row2.get_IsNull(Me.OOOO._.) AndAlso Integer.TryParse(Strings.Right(row2(Me.OOOO._.).ToString(), num3), num) Then
								hashSet.Add(num)
							End If
						Next
					Finally
						Dim enumerator2 As List(Of Row).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					num = 1
					While hashSet.Contains(num)
						num += 1
					End While
					result = str + Interaction.IIf(Operators.CompareString(Conversions.ToString(Me.O_OOO.0o.), vbNullChar, True) = 0, "", Me.O_OOO.0o.).ToString() + Strings.Format(num, New String("0"c, num3))
				Else
					result = str + Interaction.IIf(Operators.CompareString(Conversions.ToString(Me.O_OOO.0o.), vbNullChar, True) = 0, "", Me.O_OOO.0o.).ToString() + Strings.Format(1, New String("0"c, num3))
				End If
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x060005B4 RID: 1460 RVA: 0x0001DD8C File Offset: 0x0001BF8C
		Private Function <<EMPTY_NAME>>(A_0 As Row, A_1 As Row) As String
			Dim str As String = A_0(Me.OOOO._.).ToString()
			Dim result As String
			If A_1 Is Nothing OrElse A_1.get_IsNull(Me.OOOO._.) Then
				Dim children As List(Of Row) = A_0.GetChildren(False)
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				Try
					For Each row As Row In children
						Dim array As String() = row(Me.OOOO._.).ToString().Split(New Char() { Me.O_OOO.0o. })
						hashSet.Add(array(array.Length - 1))
					Next
				Finally
					Dim enumerator As List(Of Row).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Dim num As Integer = 1
				While hashSet.Contains("新项目" + num.ToString())
					num += 1
				End While
				Dim str2 As String = "新项目" + num.ToString()
				result = str + Conversions.ToString(Me.O_OOO.0o.) + str2
			Else
				Dim array2 As String() = A_1(Me.OOOO._.).ToString().Split(New Char() { Me.O_OOO.0o. })
				result = str + Conversions.ToString(Me.O_OOO.0o.) + array2(array2.Length - 1)
			End If
			Return result
		End Function

		' Token: 0x060005B5 RID: 1461 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		Private Function <<EMPTY_NAME>>(A_0 As Table) As String
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			Try
				For Each row As Row In A_0.Rows
					If row.Hierarchy = 0 Then
						hashSet.Add(row(Me.OOOO._.).ToString())
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Row)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim num As Integer = 1
			While hashSet.Contains("新项目" + num.ToString())
				num += 1
			End While
			Return "新项目" + num.ToString()
		End Function

		' Token: 0x060005B6 RID: 1462 RVA: 0x0001DF80 File Offset: 0x0001C180
		Friend Function <<EMPTY_NAME>>(ParamArray A_0 As Row()) As Boolean
			For Each row As Row In A_0
				If row IsNot Nothing Then
					For Each text As String In row(Me.OOOO._.).ToString().Split(New Char() { Me.O_OOO.0o. })
						Dim num As Integer
						If Operators.CompareString(text, "", True) > 0 AndAlso Not Integer.TryParse(text, num) Then
							Return False
						End If
					Next
				End If
			Next
			Return True
		End Function

		' Token: 0x060005B7 RID: 1463 RVA: 0x0001E008 File Offset: 0x0001C208
		Friend Function <<EMPTY_NAME>>(A_0 As Table) As String
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			Try
				For Each row As Row In A_0.Rows
					hashSet.Add(row(Me.O_OOO.0o.).ToString())
					hashSet.Add(row(Me.OO._o0_o_OO0O.).ToString())
				Next
			Finally
				Dim enumerator As IEnumerator(Of Row)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim num As Integer = 1
			Dim result As String
			If A_0.DataTable.DataCols(Me.O_OOO.0o.).IsNumeric Then
				While hashSet.Contains(num.ToString())
					num += 1
				End While
				result = num.ToString()
			Else
				While hashSet.Contains("新项目" + num.ToString())
					num += 1
				End While
				result = "新项目" + num.ToString()
			End If
			Return result
		End Function

		' Token: 0x060005B8 RID: 1464 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		Friend Function <<EMPTY_NAME>>(A_0 As Row) As String
			Dim table As Table = A_0.Table
			Return Me.o0Oo.0_Oo0__O.(table)
		End Function

		' Token: 0x04000158 RID: 344
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000159 RID: 345
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400015A RID: 346
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400015B RID: 347
		Friend <<EMPTY_NAME>> As Char

		' Token: 0x0400015C RID: 348
		Friend <<EMPTY_NAME>> As Integer()

		' Token: 0x0400015D RID: 349
		Friend <<EMPTY_NAME>> As String()
	End Class
End Namespace
