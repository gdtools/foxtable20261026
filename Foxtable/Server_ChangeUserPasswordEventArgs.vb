Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000187 RID: 391
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Server_ChangeUserPasswordEventArgs
		' Token: 0x0600121A RID: 4634 RVA: 0x0006E958 File Offset: 0x0006CB58
		Friend Sub New(A_0 As String, A_1 As IMServer, A_2 As String, A_3 As String, A_4 As oO__oO_0_O)
			Me.O0_00._0o0. = A_0
			Me.O0_00._0o0. = A_1
			Me.oo00.o_. = A_2
			Me.o_O0_o.OO00oO. = A_3
			Me.O0_00._0o0. = A_4
		End Sub

		' Token: 0x170003E1 RID: 993
		' (get) Token: 0x0600121B RID: 4635 RVA: 0x0006E985 File Offset: 0x0006CB85
		' (set) Token: 0x0600121C RID: 4636 RVA: 0x0006E98D File Offset: 0x0006CB8D
		Public Property AsyncExecute As Boolean
			Get
				Return Me.O0_00._0o0.
			End Get
			Set(value As Boolean)
				Me.O0_00._0o0. = True
			End Set
		End Property

		' Token: 0x170003E2 RID: 994
		' (get) Token: 0x0600121D RID: 4637 RVA: 0x0006E996 File Offset: 0x0006CB96
		Public ReadOnly Property UserName As String
			Get
				Return Me.O0_00._0o0.
			End Get
		End Property

		' Token: 0x170003E3 RID: 995
		' (get) Token: 0x0600121E RID: 4638 RVA: 0x0006E99E File Offset: 0x0006CB9E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.O0_00._0o0.
			End Get
		End Property

		' Token: 0x170003E4 RID: 996
		' (get) Token: 0x0600121F RID: 4639 RVA: 0x0006E9A6 File Offset: 0x0006CBA6
		Public ReadOnly Property OldPassword As String
			Get
				Return Me.oo00.o_.
			End Get
		End Property

		' Token: 0x170003E5 RID: 997
		' (get) Token: 0x06001220 RID: 4640 RVA: 0x0006E9AE File Offset: 0x0006CBAE
		Public ReadOnly Property NewPassword As String
			Get
				Return Me.o_O0_o.OO00oO.
			End Get
		End Property

		' Token: 0x170003E6 RID: 998
		' (get) Token: 0x06001221 RID: 4641 RVA: 0x0006E9B6 File Offset: 0x0006CBB6
		' (set) Token: 0x06001222 RID: 4642 RVA: 0x0006E9BE File Offset: 0x0006CBBE
		Public Property ReturnMessage As String
			Get
				Return Me.o.0OOoO0.
			End Get
			Set(value As String)
				Me.o.0OOoO0. = value
			End Set
		End Property

		' Token: 0x06001223 RID: 4643 RVA: 0x0006E9C7 File Offset: 0x0006CBC7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.o.0OOoO0., "", True) > 0 Then
				Me.O0_00._0o0..O0o_.Oo0oo.(Me.O0_00._0o0..Oo0oo._.(), Me.ReturnMessage)
			End If
		End Sub

		' Token: 0x170003E7 RID: 999
		' (set) Token: 0x06001224 RID: 4644 RVA: 0x0006E9FC File Offset: 0x0006CBFC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public WriteOnly Property Handled As Boolean
			Set(value As Boolean)
				If value Then
					Dim method As o_OOO_o0_ = AddressOf Me.ooO.o_Oo.
					If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						OO_00oOO.BaseMainForm.Invoke(method)
					End If
				End If
			End Set
		End Property

		' Token: 0x040006F9 RID: 1785
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006FA RID: 1786
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x040006FB RID: 1787
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006FC RID: 1788
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006FD RID: 1789
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006FE RID: 1790
		Private <<EMPTY_NAME>> As oO__oO_0_O

		' Token: 0x040006FF RID: 1791
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
