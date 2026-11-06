Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200023C RID: 572
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("2209")>
	Public Class BeforeAttachFileEvents
		' Token: 0x06001AC8 RID: 6856 RVA: 0x000ABA74 File Offset: 0x000A9C74
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol, A_3 As String, A_4 As String, A_5 As String)
			If A_4 = DBNull.Value Then
				A_4 = Nothing
			End If
			Me.oo00.0oOoO0o. = A_0
			Me.oo00.0oOoO0o. = A_1
			Me.oo00.0oOoO0o. = A_2
			Me.oO.O0O00oo_. = A_5
			Me.oo00.0oOoO0o. = A_4
			Me.o.0O. = A_3
		End Sub

		' Token: 0x17000605 RID: 1541
		' (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000ABAC0 File Offset: 0x000A9CC0
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.oo00.0oOoO0o.
			End Get
		End Property

		' Token: 0x17000606 RID: 1542
		' (get) Token: 0x06001ACA RID: 6858 RVA: 0x000ABAC8 File Offset: 0x000A9CC8
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.oo00.0oOoO0o.
			End Get
		End Property

		' Token: 0x17000607 RID: 1543
		' (get) Token: 0x06001ACB RID: 6859 RVA: 0x000ABAD0 File Offset: 0x000A9CD0
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.oo00.0oOoO0o.
			End Get
		End Property

		' Token: 0x17000608 RID: 1544
		' (get) Token: 0x06001ACC RID: 6860 RVA: 0x000ABAD8 File Offset: 0x000A9CD8
		' (set) Token: 0x06001ACD RID: 6861 RVA: 0x000ABAE0 File Offset: 0x000A9CE0
		Public Property SubFolder As String
			Get
				Return Me.oO.O0O00oo_.
			End Get
			Set(value As String)
				Me.oO.O0O00oo_. = value
			End Set
		End Property

		' Token: 0x17000609 RID: 1545
		' (get) Token: 0x06001ACE RID: 6862 RVA: 0x000ABAE9 File Offset: 0x000A9CE9
		Public ReadOnly Property SourceFolder As String
			Get
				Return Me.o.0O.
			End Get
		End Property

		' Token: 0x1700060A RID: 1546
		' (get) Token: 0x06001ACF RID: 6863 RVA: 0x000ABAF1 File Offset: 0x000A9CF1
		' (set) Token: 0x06001AD0 RID: 6864 RVA: 0x000ABAF9 File Offset: 0x000A9CF9
		Public Property FileName As String
			Get
				Return Me.oo00.0oOoO0o.
			End Get
			Set(value As String)
				Me.oo00.0oOoO0o. = value
			End Set
		End Property

		' Token: 0x1700060B RID: 1547
		' (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000ABB02 File Offset: 0x000A9D02
		' (set) Token: 0x06001AD2 RID: 6866 RVA: 0x000ABB0A File Offset: 0x000A9D0A
		Public Property Cancel As Boolean
			Get
				Return Me.ooO_0oo.oOo0o.
			End Get
			Set(value As Boolean)
				Me.ooO_0oo.oOo0o. = value
			End Set
		End Property

		' Token: 0x1700060C RID: 1548
		' (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000ABB14 File Offset: 0x000A9D14
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

		' Token: 0x04000B4E RID: 2894
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B4F RID: 2895
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000B50 RID: 2896
		Private <<EMPTY_NAME>> As DataCol

		' Token: 0x04000B51 RID: 2897
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B52 RID: 2898
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B53 RID: 2899
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B54 RID: 2900
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
