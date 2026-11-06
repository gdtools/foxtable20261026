Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004C1 RID: 1217
	Friend Class O0__000O
		Implements Oo0__O__O_0__

		' Token: 0x06004E84 RID: 20100 RVA: 0x00208A10 File Offset: 0x00206C10
		Public Sub New(A_0 As Table, A_1 As String)
			Me.Oo.__O0. = New List(Of DataRow)()
			Me.Oo.__O0. = New List(Of Object)()
			Me.Oo.__O0. = A_0
			Me.Oo.__O0. = A_1
		End Sub

		' Token: 0x06004E85 RID: 20101 RVA: 0x00208A3C File Offset: 0x00206C3C
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			Me.Oo.__O0..Add(A_0)
			Me.Oo.__O0..Add(RuntimeHelpers.GetObjectValue(A_0(Me.Oo.__O0.)))
		End Sub

		' Token: 0x06004E86 RID: 20102 RVA: 0x00208A66 File Offset: 0x00206C66
		Friend Sub <<EMPTY_NAME>>()
			Me.Oo.__O0..RemoveAt(Me.Oo.__O0..Count - 1)
			Me.Oo.__O0..RemoveAt(Me.Oo.__O0..Count - 1)
		End Sub

		' Token: 0x06004E87 RID: 20103 RVA: 0x00208A98 File Offset: 0x00206C98
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.Oo.__O0..Count
		End Function

		' Token: 0x06004E88 RID: 20104 RVA: 0x00208AA8 File Offset: 0x00206CA8
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim num As Integer = Me.Oo.__O0..Count - 1
			For i As Integer = 0 To num
				Dim dataRow As DataRow = Me.Oo.__O0.(i)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(dataRow(Me.Oo.__O0.))
				If Operators.CompareString(objectValue.ToString(), Me.Oo.__O0.(i).ToString(), True) <> 0 Then
					dataRow(Me.Oo.__O0.) = RuntimeHelpers.GetObjectValue(Me.Oo.__O0.(i))
					Me.Oo.__O0.(i) = RuntimeHelpers.GetObjectValue(objectValue)
					Dim a_ As Integer = Me.Oo.__O0..View.o_o.O0ooOo.(dataRow)
					Dim o0O00o_.0Oo. As MethodInfo = Me.Oo.__O0..DataTable.O0O00o_.0Oo.
					If o0O00o_.0Oo. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
						Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.Oo.__O0., New Row(Me.Oo.__O0., Me.Oo.__O0..View.O0O_0_0__.0O.(a_)), Me.Oo.__O0..Cols(Me.Oo.__O0.), Nothing)
						Try
							o0O00o_.0Oo..Invoke(Nothing, New Object() { rowColEventArgs })
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "表，" + Me.Oo.__O0..DataTable.Name + "，AfterEdit")
						End Try
					End If
					Oo00.o0_o._O_.(Me.Oo.__O0.(i))
				End If
			Next
		End Sub

		' Token: 0x06004E89 RID: 20105 RVA: 0x00208C28 File Offset: 0x00206E28
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.Oo.__O0.()
		End Sub

		' Token: 0x0400207B RID: 8315
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400207C RID: 8316
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400207D RID: 8317
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x0400207E RID: 8318
		Private <<EMPTY_NAME>> As List(Of Object)
	End Class
End Namespace
