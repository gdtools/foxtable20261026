Imports System
Imports System.Data
Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020004C0 RID: 1216
	Friend Class o0o0o00
		Implements Oo0__O__O_0__

		' Token: 0x06004E81 RID: 20097 RVA: 0x00208840 File Offset: 0x00206A40
		Public Sub New(A_0 As Table, A_1 As DataRow, A_2 As String)
			Me.o.0000OOo_. = A_0
			Me.o.0000OOo_. = A_1
			Me.o.0000OOo_. = A_2
			Me.o.0000OOo_. = RuntimeHelpers.GetObjectValue(A_1(A_2))
		End Sub

		' Token: 0x06004E82 RID: 20098 RVA: 0x00208870 File Offset: 0x00206A70
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o.0000OOo_.(Me.o.0000OOo_.))
			Me.o.0000OOo_..foxGrid.Col = Me.o.0000OOo_..foxGrid.Cols.IndexOf(Me.o.0000OOo_.)
			If String.Compare(Me.o.0000OOo_..ToString(), objectValue.ToString(), False) <> 0 Then
				Me.o.0000OOo_.(Me.o.0000OOo_.) = RuntimeHelpers.GetObjectValue(Me.o.0000OOo_.)
				If Me.o.0000OOo_..View.o_o.O0ooOo.().Row IsNot Me.o.0000OOo_. Then
					Me.o.0000OOo_..View.Position = Me.o.0000OOo_..View.o_o.O0ooOo.(Me.o.0000OOo_.)
				End If
				Dim o0O00o_.0Oo. As MethodInfo = Me.o.0000OOo_..DataTable.O0O00o_.0Oo.
				If o0O00o_.0Oo. IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0000OOo_., New Row(Me.o.0000OOo_., Me.o.0000OOo_..View.o_o.O0ooOo.()), Me.o.0000OOo_..Cols(Me.o.0000OOo_.), Nothing)
					Try
						o0O00o_.0Oo..Invoke(Nothing, New Object() { rowColEventArgs })
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "表，" + Me.o.0000OOo_..DataTable.Name + "，AfterEdit")
					End Try
				End If
			End If
			Oo00.o0_o._O_.(Me.o.0000OOo_.)
			Me.o.0000OOo_. = RuntimeHelpers.GetObjectValue(objectValue)
		End Sub

		' Token: 0x06004E83 RID: 20099 RVA: 0x00208A08 File Offset: 0x00206C08
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.o.0000OOo_.()
		End Sub

		' Token: 0x04002077 RID: 8311
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04002078 RID: 8312
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04002079 RID: 8313
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400207A RID: 8314
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
