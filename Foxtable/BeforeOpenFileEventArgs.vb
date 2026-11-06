Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200023E RID: 574
	<oO0oooo("2637")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeOpenFileEventArgs
		' Token: 0x06001AD9 RID: 6873 RVA: 0x000ABB82 File Offset: 0x000A9D82
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol, A_3 As String, A_4 As Boolean)
			If A_3 = DBNull.Value Then
				A_3 = Nothing
			End If
			Me.O.O00. = A_0
			Me.o0__0_0O0.oO0. = A_1
			Me.o0__0_0O0.oO0. = A_2
			Me.O.O00. = A_3
			Me.o.__0. = A_4
		End Sub

		' Token: 0x1700060F RID: 1551
		' (get) Token: 0x06001ADA RID: 6874 RVA: 0x000ABBBB File Offset: 0x000A9DBB
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.O.O00.
			End Get
		End Property

		' Token: 0x17000610 RID: 1552
		' (get) Token: 0x06001ADB RID: 6875 RVA: 0x000ABBC3 File Offset: 0x000A9DC3
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
		End Property

		' Token: 0x17000611 RID: 1553
		' (get) Token: 0x06001ADC RID: 6876 RVA: 0x000ABBCB File Offset: 0x000A9DCB
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
		End Property

		' Token: 0x17000612 RID: 1554
		' (get) Token: 0x06001ADD RID: 6877 RVA: 0x000ABBD3 File Offset: 0x000A9DD3
		' (set) Token: 0x06001ADE RID: 6878 RVA: 0x000ABBDB File Offset: 0x000A9DDB
		Public Property FileName As String
			Get
				Return Me.O.O00.
			End Get
			Set(value As String)
				Me.O.O00. = value
			End Set
		End Property

		' Token: 0x17000613 RID: 1555
		' (get) Token: 0x06001ADF RID: 6879 RVA: 0x000ABBE4 File Offset: 0x000A9DE4
		' (set) Token: 0x06001AE0 RID: 6880 RVA: 0x000ABBEC File Offset: 0x000A9DEC
		Public Property Cancel As Boolean
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
			Set(value As Boolean)
				Me.o0__0_0O0.oO0. = value
			End Set
		End Property

		' Token: 0x17000614 RID: 1556
		' (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000ABBF5 File Offset: 0x000A9DF5
		' (set) Token: 0x06001AE2 RID: 6882 RVA: 0x000ABBFD File Offset: 0x000A9DFD
		Public Property AutoUpdate As Boolean
			Get
				Return Me.o.__0.
			End Get
			Set(value As Boolean)
				Me.o.__0. = value
			End Set
		End Property

		' Token: 0x17000615 RID: 1557
		' (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000ABC08 File Offset: 0x000A9E08
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

		' Token: 0x04000B57 RID: 2903
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B58 RID: 2904
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000B59 RID: 2905
		Private <<EMPTY_NAME>> As DataCol

		' Token: 0x04000B5A RID: 2906
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B5B RID: 2907
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B5C RID: 2908
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
