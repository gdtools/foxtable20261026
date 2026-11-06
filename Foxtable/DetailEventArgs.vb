Imports System
Imports System.ComponentModel
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x020002E4 RID: 740
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DetailEventArgs
		Inherits BuildEventArgs

		' Token: 0x06002732 RID: 10034 RVA: 0x0010ABA7 File Offset: 0x00108DA7
		Public Sub New(A_0 As Book, A_1 As String, A_2 As DataRow)
			MyBase.New(A_0)
			Me.OO_.0o_0. = A_1
			Me.OO_.0o_0. = A_2
		End Sub

		' Token: 0x170008C4 RID: 2244
		' (get) Token: 0x06002733 RID: 10035 RVA: 0x0010ABBE File Offset: 0x00108DBE
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.OO_.0o_0.
			End Get
		End Property

		' Token: 0x170008C5 RID: 2245
		' (get) Token: 0x06002734 RID: 10036 RVA: 0x0010ABC6 File Offset: 0x00108DC6
		Public ReadOnly Property Region As String
			Get
				Return Me.OO_.0o_0.
			End Get
		End Property

		' Token: 0x04001038 RID: 4152
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001039 RID: 4153
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
