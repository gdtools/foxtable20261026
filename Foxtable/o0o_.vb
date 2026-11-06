Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000A1 RID: 161
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o0o_
		' Token: 0x060005FA RID: 1530 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As AggregateType
			Return Me.O0OO_0.O.
		End Function

		' Token: 0x060005FB RID: 1531 RVA: 0x0001FBDC File Offset: 0x0001DDDC
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As AggregateType)
			Me.O0OO_0.O. = A_0
		End Sub

		' Token: 0x060005FC RID: 1532 RVA: 0x0001FBE5 File Offset: 0x0001DDE5
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O0OO_0.O.
		End Function

		' Token: 0x060005FD RID: 1533 RVA: 0x0001FBED File Offset: 0x0001DDED
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0OO_0.O. = A_0
		End Sub

		' Token: 0x060005FE RID: 1534 RVA: 0x0001FBF6 File Offset: 0x0001DDF6
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As AggregateRange
			Return Me.O0OO_0.O.
		End Function

		' Token: 0x060005FF RID: 1535 RVA: 0x0001FBFE File Offset: 0x0001DDFE
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As AggregateRange)
			Me.O0OO_0.O. = A_0
		End Sub

		' Token: 0x06000600 RID: 1536 RVA: 0x0001FC08 File Offset: 0x0001DE08
		Public Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Operators.CompareString(Me.O0_O00.o., "", True) = 0 Then
				result = Me.o0oO._o_.()
			Else
				result = Me.O0_O00.o.
			End If
			Return result
		End Function

		' Token: 0x06000601 RID: 1537 RVA: 0x0001FC39 File Offset: 0x0001DE39
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0_O00.o. = A_0
		End Sub

		' Token: 0x06000602 RID: 1538 RVA: 0x0001FC42 File Offset: 0x0001DE42
		Public Sub New(A_0 As String)
			Me.New(A_0, A_0)
		End Sub

		' Token: 0x06000603 RID: 1539 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		Public Sub New(A_0 As String, A_1 As String)
			Me.New(A_0, A_1, AggregateRange.Both)
		End Sub

		' Token: 0x06000604 RID: 1540 RVA: 0x0001FC57 File Offset: 0x0001DE57
		Public Sub New(A_0 As String, A_1 As String, A_2 As AggregateRange)
			Me.New(A_0, A_1, A_2, AggregateType.Sum)
		End Sub

		' Token: 0x06000605 RID: 1541 RVA: 0x0001FC63 File Offset: 0x0001DE63
		Public Sub New(A_0 As String, A_1 As String, A_2 As AggregateRange, A_3 As AggregateType)
			Me.O0OO_0.O.(AggregateType.Sum)
			Me.O0OO_0.O.(AggregateRange.Both)
			Me.O0_O00.o.(A_0)
			Me.O0OO_0.O.(A_1)
			Me.O0OO_0.O.(A_2)
			Me.O0OO_0.O.(A_3)
		End Sub

		' Token: 0x06000606 RID: 1542 RVA: 0x0001FC96 File Offset: 0x0001DE96
		Public Sub New(A_0 As Boolean, A_1 As String)
			Me.New(True, A_1, AggregateRange.Both)
		End Sub

		' Token: 0x06000607 RID: 1543 RVA: 0x0001FCA1 File Offset: 0x0001DEA1
		Public Sub New(A_0 As Boolean, A_1 As String, A_2 As AggregateRange)
			Me.O0OO_0.O.(AggregateType.Sum)
			Me.O0OO_0.O.(AggregateRange.Both)
			Me.O0OO_0.O.(A_1)
			Me.O0OO_0.O.(AggregateType.Count)
			Me.O0OO_0.O.(A_2)
		End Sub

		' Token: 0x04000180 RID: 384
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As AggregateType

		' Token: 0x04000181 RID: 385
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000182 RID: 386
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As AggregateRange

		' Token: 0x04000183 RID: 387
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
