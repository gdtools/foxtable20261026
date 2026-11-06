Imports System
Imports System.Reflection
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004C2 RID: 1218
	Friend Class oOOOo0oOOOO_
		Implements Oo0__O__O_0__

		' Token: 0x06004E8A RID: 20106 RVA: 0x00208C30 File Offset: 0x00206E30
		Public Sub New(A_0 As Table, A_1 As CellRange)
			Me.O_._0o00_. = A_0
			Me.O_._0o00_. = A_1
			Me.O_._0o00_. = A_0.foxGrid.OO_.00oO0Oo.(A_1)
		End Sub

		' Token: 0x06004E8B RID: 20107 RVA: 0x00208C58 File Offset: 0x00206E58
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim o_._0o00_. As String = Me.O_._0o00_..foxGrid.OO_.00oO0Oo.(Me.O_._0o00_.)
			Me.O_._0o00_..foxGrid.[Select](Me.O_._0o00_..r1, Me.O_._0o00_..c1, Me.O_._0o00_..r2, Me.O_._0o00_..c2)
			Dim array As String(,) = New String(Me.O_._0o00_..r2 - Me.O_._0o00_..r1 + 1 - 1, Me.O_._0o00_..c2 - Me.O_._0o00_..c1 + 1 - 1) {}
			If Operators.CompareString(Me.O_._0o00_., "", True) = 0 Then
				Dim upperBound As Integer = array.GetUpperBound(0)
				For i As Integer = 0 To upperBound
					Dim upperBound2 As Integer = array.GetUpperBound(1)
					For j As Integer = 0 To upperBound2
						array(i, j) = ""
					Next
				Next
			Else
				Dim array2 As String() = Me.O_._0o00_..Split(New Char() { vbCr })
				Dim upperBound3 As Integer = array.GetUpperBound(0)
				For k As Integer = 0 To upperBound3
					Dim array3 As String() = array2(k).Split(New Char() { vbTab })
					Dim upperBound4 As Integer = array.GetUpperBound(1)
					For l As Integer = 0 To upperBound4
						array(k, l) = array3(l)
					Next
				Next
			End If
			Dim r As Integer = Me.O_._0o00_..r1
			Dim r2 As Integer = Me.O_._0o00_..r2
			For m As Integer = r To r2
				If Me.O_._0o00_..foxGrid.Rows(m).DataIndex <> -1 Then
					Dim c As Integer = Me.O_._0o00_..c1
					Dim c2 As Integer = Me.O_._0o00_..c2
					For n As Integer = c To c2
						If Operators.CompareString(Me.O_._0o00_..foxGrid(m, n).ToString(), array(m - Me.O_._0o00_..r1, n - Me.O_._0o00_..c1), True) <> 0 Then
							If Operators.CompareString(array(m - Me.O_._0o00_..r1, n - Me.O_._0o00_..c1), "", True) = 0 Then
								Me.O_._0o00_..foxGrid(m, n) = DBNull.Value
							Else
								Me.O_._0o00_..foxGrid(m, n) = array(m - Me.O_._0o00_..r1, n - Me.O_._0o00_..c1)
							End If
							If Me.O_._0o00_..foxGrid.Rows(m).DataIndex <> -1 Then
								Oo00.o0_o._O_.(Me.O_._0o00_..View.O0O_0_0__.0O.(Me.O_._0o00_..foxGrid.Rows(m).DataIndex).Row)
								Dim o0O00o_.0Oo. As MethodInfo = Me.O_._0o00_..DataTable.O0O00o_.0Oo.
								If o0O00o_.0Oo. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
									Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.O_._0o00_., New Row(Me.O_._0o00_., Me.O_._0o00_..View.O0O_0_0__.0O.(Me.O_._0o00_..foxGrid.Rows(m).DataIndex)), Me.O_._0o00_..Cols(Me.O_._0o00_..foxGrid.Cols(n).Name), Nothing)
									Try
										o0O00o_.0Oo..Invoke(Nothing, New Object() { rowColEventArgs })
									Catch a_ As Exception
										ooO.oOo0Oo.o.(a_, "表，" + Me.O_._0o00_..DataTable.Name + "，AfterEdit")
									End Try
								End If
							End If
						End If
					Next
				End If
			Next
			Me.O_._0o00_. = o_._0o00_.
		End Sub

		' Token: 0x06004E8C RID: 20108 RVA: 0x00209048 File Offset: 0x00207248
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.oO0000.OO0oo.()
		End Sub

		' Token: 0x0400207F RID: 8319
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04002080 RID: 8320
		Private <<EMPTY_NAME>> As CellRange

		' Token: 0x04002081 RID: 8321
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
