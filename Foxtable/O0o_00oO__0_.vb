Imports System

Namespace Foxtable
	' Token: 0x02000047 RID: 71
	Friend Class O0o_00oO__0_
		Implements IComparable

		' Token: 0x060002AB RID: 683 RVA: 0x00005E24 File Offset: 0x00004024
		Public Sub New(A_0 As String, A_1 As Double)
			Me.O0OOo0_._. = A_0
			Me.O0OOo0_._. = A_1
		End Sub

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x060002AC RID: 684 RVA: 0x00005E3A File Offset: 0x0000403A
		' (set) Token: 0x060002AD RID: 685 RVA: 0x00005E42 File Offset: 0x00004042
		Public Property Name As String
			Get
				Return Me.O0OOo0_._.
			End Get
			Set(value As String)
				Me.O0OOo0_._. = value
			End Set
		End Property

		' Token: 0x060002AE RID: 686 RVA: 0x00005E4B File Offset: 0x0000404B
		Public Function <<EMPTY_NAME>>() As Double
			Return Me.O0OOo0_._.
		End Function

		' Token: 0x060002AF RID: 687 RVA: 0x00005E53 File Offset: 0x00004053
		Public Sub <<EMPTY_NAME>>(A_0 As Double)
			Me.O0OOo0_._. = A_0
		End Sub

		' Token: 0x060002B0 RID: 688 RVA: 0x00005E5C File Offset: 0x0000405C
		Public Function <<EMPTY_NAME>>(A_0 As Object) As Integer Implements System.IComparable.CompareTo
			Dim o0OOo0_._. As Double = CType(A_0, O0o_00oO__0_).O0OOo0_._.
			Dim result As Integer
			If o0OOo0_._. = Me.O0OOo0_._. Then
				Dim o0OOo0_._.2 As String = CType(A_0, O0o_00oO__0_).O0OOo0_._.
				result = String.Compare(Me.O0OOo0_._., o0OOo0_._.2)
			ElseIf o0OOo0_._. > Me.O0OOo0_._. Then
				result = -1
			Else
				result = 1
			End If
			Return result
		End Function

		' Token: 0x04000066 RID: 102
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04000067 RID: 103
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
