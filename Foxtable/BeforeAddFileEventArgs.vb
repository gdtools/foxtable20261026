Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200023B RID: 571
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("2638")>
	Public Class BeforeAddFileEventArgs
		' Token: 0x06001ABD RID: 6845 RVA: 0x000AB9AA File Offset: 0x000A9BAA
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol)
			Me.ooO_0oo.oOo0o. = A_0
			Me.ooO_0oo.oOo0o. = A_1
			Me.ooO_0oo.oOo0o. = A_2
		End Sub

		' Token: 0x06001ABE RID: 6846 RVA: 0x000AB9C7 File Offset: 0x000A9BC7
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol, A_3 As Boolean)
			Me.ooO_0oo.oOo0o. = A_0
			Me.ooO_0oo.oOo0o. = A_1
			Me.ooO_0oo.oOo0o. = A_2
			Me.O__00_.0. = A_3
		End Sub

		' Token: 0x170005FE RID: 1534
		' (get) Token: 0x06001ABF RID: 6847 RVA: 0x000AB9EC File Offset: 0x000A9BEC
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
		End Property

		' Token: 0x170005FF RID: 1535
		' (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000AB9F4 File Offset: 0x000A9BF4
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
		End Property

		' Token: 0x17000600 RID: 1536
		' (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000AB9FC File Offset: 0x000A9BFC
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
		End Property

		' Token: 0x17000601 RID: 1537
		' (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000ABA04 File Offset: 0x000A9C04
		' (set) Token: 0x06001AC3 RID: 6851 RVA: 0x000ABA0C File Offset: 0x000A9C0C
		Public Property Path As String
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
			Set(value As String)
				Me.ooO_0oo.oOo0o. = value
			End Set
		End Property

		' Token: 0x17000602 RID: 1538
		' (get) Token: 0x06001AC4 RID: 6852 RVA: 0x000ABA15 File Offset: 0x000A9C15
		Public ReadOnly Property IsDir As Boolean
			Get
				Return Me.O__00_.0.
			End Get
		End Property

		' Token: 0x17000603 RID: 1539
		' (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000ABA1D File Offset: 0x000A9C1D
		' (set) Token: 0x06001AC6 RID: 6854 RVA: 0x000ABA25 File Offset: 0x000A9C25
		Public Property Cancel As Boolean
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
			Set(value As Boolean)
				Me.ooO_0oo.oOo0o. = value
			End Set
		End Property

		' Token: 0x17000604 RID: 1540
		' (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000ABA30 File Offset: 0x000A9C30
		Public ReadOnly Property Form As Form
			Get
				Dim result As Form
				If OO_00oOO.Tables.get_Contains(Me.DataTable.Name) Then
					result = OO_00oOO.Tables(Me.DataTable.Name).Form
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x04000B48 RID: 2888
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B49 RID: 2889
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000B4A RID: 2890
		Private <<EMPTY_NAME>> As DataCol

		' Token: 0x04000B4B RID: 2891
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B4C RID: 2892
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B4D RID: 2893
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
