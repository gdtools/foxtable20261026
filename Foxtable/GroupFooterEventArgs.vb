Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x02000448 RID: 1096
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GroupFooterEventArgs
		Inherits BuildEventArgs

		' Token: 0x06004875 RID: 18549 RVA: 0x001E9748 File Offset: 0x001E7948
		Public Sub New(A_0 As Book, A_1 As String, A_2 As String, A_3 As List(Of DataRow), A_4 As List(Of DataRow))
			MyBase.New(A_0)
			Me.OO_000.oo. = New List(Of DataRow)()
			Me.o00O0_.0. = New List(Of DataRow)()
			Me.OO_000.oo. = A_1
			Me.OO_O.00_oo. = A_2
			Try
				For Each a_ As DataRow In A_3
					Me.OO_000.oo..Add(New DataRow(a_))
				Next
			Finally
				Dim enumerator As List(Of DataRow).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each a_2 As DataRow In A_4
					Me.o00O0_.0..Add(New DataRow(a_2))
				Next
			Finally
				Dim enumerator2 As List(Of DataRow).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x17001043 RID: 4163
		' (get) Token: 0x06004876 RID: 18550 RVA: 0x001E9818 File Offset: 0x001E7A18
		Public ReadOnly Property TableName As String
			Get
				Return Me.OO_000.oo.
			End Get
		End Property

		' Token: 0x17001044 RID: 4164
		' (get) Token: 0x06004877 RID: 18551 RVA: 0x001E9820 File Offset: 0x001E7A20
		Public ReadOnly Property ColumnName As String
			Get
				Return Me.OO_O.00_oo.
			End Get
		End Property

		' Token: 0x17001045 RID: 4165
		' (get) Token: 0x06004878 RID: 18552 RVA: 0x001E9828 File Offset: 0x001E7A28
		Public ReadOnly Property GroupRows As List(Of DataRow)
			Get
				Return Me.OO_000.oo.
			End Get
		End Property

		' Token: 0x17001046 RID: 4166
		' (get) Token: 0x06004879 RID: 18553 RVA: 0x001E9830 File Offset: 0x001E7A30
		Public ReadOnly Property TotalRows As List(Of DataRow)
			Get
				Return Me.o00O0_.0.
			End Get
		End Property

		' Token: 0x04001D8F RID: 7567
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D90 RID: 7568
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D91 RID: 7569
		Private <<EMPTY_NAME>> As List(Of DataRow)

		' Token: 0x04001D92 RID: 7570
		Private <<EMPTY_NAME>> As List(Of DataRow)
	End Class
End Namespace
