Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports C1.Win.C1FlexGrid

Namespace Foxtable
	' Token: 0x020004C9 RID: 1225
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O_0_Oo
		Implements Oo0__O__O_0__

		' Token: 0x06004E9F RID: 20127 RVA: 0x002096D5 File Offset: 0x002078D5
		Public Sub New(A_0 As Table)
			Me.oOOo_o0o0O._. = New List(Of String)()
			Me.oOOo_o0o0O._. = New List(Of TextAlignEnum)()
			Me.oOOo_o0o0O._. = A_0
		End Sub

		' Token: 0x06004EA0 RID: 20128 RVA: 0x002096FA File Offset: 0x002078FA
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oOOo_o0o0O._..Add(A_0)
			Me.oOOo_o0o0O._..Add(Me.oOOo_o0o0O._..foxGrid.Cols(A_0).TextAlign)
		End Sub

		' Token: 0x06004EA1 RID: 20129 RVA: 0x0020972E File Offset: 0x0020792E
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.O_oo._o.()
		End Sub

		' Token: 0x06004EA2 RID: 20130 RVA: 0x00209738 File Offset: 0x00207938
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim num As Integer = Me.oOOo_o0o0O._..Count - 1
			For i As Integer = 0 To num
				Dim textAlign As TextAlignEnum = Me.oOOo_o0o0O._..foxGrid.Cols(Me.oOOo_o0o0O._.(i)).TextAlign
				Dim textAlignEnum As TextAlignEnum = Me.oOOo_o0o0O._.(i)
				If textAlignEnum <> 1 Then
					If textAlignEnum <> 4 Then
						If textAlignEnum <> 7 Then
							Me.oOOo_o0o0O._..DataTable.DataCols(Me.oOOo_o0o0O._.(i)).TextAlign = 0
						Else
							Me.oOOo_o0o0O._..DataTable.DataCols(Me.oOOo_o0o0O._.(i)).TextAlign = 3
						End If
					Else
						Me.oOOo_o0o0O._..DataTable.DataCols(Me.oOOo_o0o0O._.(i)).TextAlign = 2
					End If
				Else
					Me.oOOo_o0o0O._..DataTable.DataCols(Me.oOOo_o0o0O._.(i)).TextAlign = 1
				End If
				Me.oOOo_o0o0O._..DataTable.DataCols(Me.oOOo_o0o0O._.(i)).O.O_OO.(False)
				Try
					For Each table As Table In OO_00oOO.Tables
						If table.DataTable Is Me.oOOo_o0o0O._..DataTable AndAlso table.foxGrid.Cols.Contains(Me.oOOo_o0o0O._.(i)) Then
							table.foxGrid.Cols(Me.oOOo_o0o0O._.(i)).TextAlign = Me.oOOo_o0o0O._.(i)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Me.oOOo_o0o0O._.(i) = textAlign
			Next
		End Sub

		' Token: 0x06004EA3 RID: 20131 RVA: 0x0020991C File Offset: 0x00207B1C
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.oOOo_o0o0O._..Count
		End Function

		' Token: 0x04002092 RID: 8338
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04002093 RID: 8339
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04002094 RID: 8340
		Private <<EMPTY_NAME>> As List(Of TextAlignEnum)
	End Class
End Namespace
