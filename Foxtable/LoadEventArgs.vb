Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000242 RID: 578
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class LoadEventArgs
		' Token: 0x06001AF1 RID: 6897 RVA: 0x000ABD07 File Offset: 0x000A9F07
		Public Sub New(A_0 As DataTable)
			Me.OO.oO0OO0_. = A_0
		End Sub

		' Token: 0x1700061D RID: 1565
		' (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000ABD16 File Offset: 0x000A9F16
		' (set) Token: 0x06001AF3 RID: 6899 RVA: 0x000ABD1E File Offset: 0x000A9F1E
		Public Property DataTable As DataTable
			Get
				Return Me.OO.oO0OO0_.
			End Get
			Set(value As DataTable)
				Me.OO.oO0OO0_. = value
			End Set
		End Property

		' Token: 0x1700061E RID: 1566
		' (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000ABD27 File Offset: 0x000A9F27
		' (set) Token: 0x06001AF5 RID: 6901 RVA: 0x000ABD2F File Offset: 0x000A9F2F
		Public Property Cancel As Boolean
			Get
				Return Me.OO.oO0OO0_.
			End Get
			Set(value As Boolean)
				Me.OO.oO0OO0_. = value
			End Set
		End Property

		' Token: 0x1700061F RID: 1567
		' (get) Token: 0x06001AF6 RID: 6902 RVA: 0x000ABD38 File Offset: 0x000A9F38
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

		' Token: 0x04000B63 RID: 2915
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B64 RID: 2916
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
