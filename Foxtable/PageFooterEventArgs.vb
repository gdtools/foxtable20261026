Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x0200044A RID: 1098
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class PageFooterEventArgs
		Inherits BuildEventArgs

		' Token: 0x0600487F RID: 18559 RVA: 0x001E9880 File Offset: 0x001E7A80
		Public Sub New(A_0 As Book, A_1 As List(Of DataRow), A_2 As List(Of DataRow))
			MyBase.New(A_0)
			Me.oo0oOoo00o.0_0. = New List(Of DataRow)()
			Me.o0_Oo__0.0_oO_. = New List(Of DataRow)()
			Try
				For Each a_ As DataRow In A_1
					Me.oo0oOoo00o.0_0..Add(New DataRow(a_))
				Next
			Finally
				Dim enumerator As List(Of DataRow).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each a_2 As DataRow In A_2
					Me.o0_Oo__0.0_oO_..Add(New DataRow(a_2))
				Next
			Finally
				Dim enumerator2 As List(Of DataRow).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x1700104B RID: 4171
		' (get) Token: 0x06004880 RID: 18560 RVA: 0x001E9940 File Offset: 0x001E7B40
		Public ReadOnly Property PageRows As List(Of DataRow)
			Get
				Return Me.oo0oOoo00o.0_0.
			End Get
		End Property

		' Token: 0x1700104C RID: 4172
		' (get) Token: 0x06004881 RID: 18561 RVA: 0x001E9948 File Offset: 0x001E7B48
		Public ReadOnly Property TotalRows As List(Of DataRow)
			Get
				Return Me.o0_Oo__0.0_oO_.
			End Get
		End Property

		' Token: 0x04001D98 RID: 7576
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x04001D99 RID: 7577
		Private <<EMPTY_NAME>> As List(Of DataRow)
	End Class
End Namespace
