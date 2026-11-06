Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020002F6 RID: 758
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class MaintableChangingEventArgs
		' Token: 0x060027CF RID: 10191 RVA: 0x0010B9C5 File Offset: 0x00109BC5
		Public Sub New(A_0 As String, A_1 As String)
			Me.OO0o0_o._o_o. = A_0
			Me.Ooo0.0O__0000O. = A_1
		End Sub

		' Token: 0x1700092A RID: 2346
		' (get) Token: 0x060027D0 RID: 10192 RVA: 0x0010B9DB File Offset: 0x00109BDB
		Public ReadOnly Property OldTableName As String
			Get
				Return Me.OO0o0_o._o_o.
			End Get
		End Property

		' Token: 0x1700092B RID: 2347
		' (get) Token: 0x060027D1 RID: 10193 RVA: 0x0010B9E3 File Offset: 0x00109BE3
		Public ReadOnly Property NewTableName As String
			Get
				Return Me.Ooo0.0O__0000O.
			End Get
		End Property

		' Token: 0x1700092C RID: 2348
		' (get) Token: 0x060027D2 RID: 10194 RVA: 0x0010B9EB File Offset: 0x00109BEB
		' (set) Token: 0x060027D3 RID: 10195 RVA: 0x0010B9F3 File Offset: 0x00109BF3
		Public Property Cancel As Boolean
			Get
				Return Me.OO0o0_o._o_o.
			End Get
			Set(value As Boolean)
				Me.OO0o0_o._o_o. = value
			End Set
		End Property

		' Token: 0x04001080 RID: 4224
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001081 RID: 4225
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001082 RID: 4226
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
