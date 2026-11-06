Imports System
Imports System.ComponentModel
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x02000449 RID: 1097
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GroupHeaderEventArgs
		Inherits BuildEventArgs

		' Token: 0x0600487A RID: 18554 RVA: 0x001E9838 File Offset: 0x001E7A38
		Public Sub New(A_0 As Book, A_1 As String, A_2 As String, A_3 As DataRow, A_4 As Boolean)
			MyBase.New(A_0)
			Me.OO_000.oo. = A_1
			Me.o00O0_.0. = A_2
			Me.OO_000.oo. = A_3
			Me.OO_000.oo. = A_4
		End Sub

		' Token: 0x17001047 RID: 4167
		' (get) Token: 0x0600487B RID: 18555 RVA: 0x001E985F File Offset: 0x001E7A5F
		Public ReadOnly Property TableName As String
			Get
				Return Me.OO_000.oo.
			End Get
		End Property

		' Token: 0x17001048 RID: 4168
		' (get) Token: 0x0600487C RID: 18556 RVA: 0x001E9867 File Offset: 0x001E7A67
		Public ReadOnly Property ColumnName As String
			Get
				Return Me.o00O0_.0.
			End Get
		End Property

		' Token: 0x17001049 RID: 4169
		' (get) Token: 0x0600487D RID: 18557 RVA: 0x001E986F File Offset: 0x001E7A6F
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.OO_000.oo.
			End Get
		End Property

		' Token: 0x1700104A RID: 4170
		' (get) Token: 0x0600487E RID: 18558 RVA: 0x001E9877 File Offset: 0x001E7A77
		Public ReadOnly Property NewPage As Boolean
			Get
				Return Me.OO_000.oo.
			End Get
		End Property

		' Token: 0x04001D93 RID: 7571
		Private <<EMPTY_NAME>> As Book

		' Token: 0x04001D94 RID: 7572
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D95 RID: 7573
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D96 RID: 7574
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001D97 RID: 7575
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
