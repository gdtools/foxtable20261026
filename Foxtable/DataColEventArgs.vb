Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002ED RID: 749
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DataColEventArgs
		' Token: 0x06002770 RID: 10096 RVA: 0x0010AF08 File Offset: 0x00109108
		Public Sub New(A_0 As DataTable, A_1 As DataRow, A_2 As DataCol, A_3 As Object, A_4 As Object)
			If A_3 Is DBNull.Value Then
				A_3 = Nothing
			End If
			If A_4 Is DBNull.Value Then
				A_4 = Nothing
			End If
			Me.o.0OoOo. = A_0
			Me.o.0OoOo. = A_1
			Me.o.0OoOo. = A_2
			Me.o.0OoOo. = RuntimeHelpers.GetObjectValue(A_3)
			Me.OOO_00oooO_o._. = RuntimeHelpers.GetObjectValue(A_4)
		End Sub

		' Token: 0x170008EC RID: 2284
		' (get) Token: 0x06002771 RID: 10097 RVA: 0x0010AF62 File Offset: 0x00109162
		Public ReadOnly Property DataTable As DataTable
			Get
				Return Me.o.0OoOo.
			End Get
		End Property

		' Token: 0x170008ED RID: 2285
		' (get) Token: 0x06002772 RID: 10098 RVA: 0x0010AF6A File Offset: 0x0010916A
		Public ReadOnly Property DataRow As DataRow
			Get
				Return Me.o.0OoOo.
			End Get
		End Property

		' Token: 0x170008EE RID: 2286
		' (get) Token: 0x06002773 RID: 10099 RVA: 0x0010AF72 File Offset: 0x00109172
		Public ReadOnly Property DataCol As DataCol
			Get
				Return Me.o.0OoOo.
			End Get
		End Property

		' Token: 0x170008EF RID: 2287
		' (get) Token: 0x06002774 RID: 10100 RVA: 0x0010AF7A File Offset: 0x0010917A
		' (set) Token: 0x06002775 RID: 10101 RVA: 0x0010AF82 File Offset: 0x00109182
		Public Property NewValue As Object
			Get
				Return Me.o.0OoOo.
			End Get
			Set(value As Object)
				Me.o.0OoOo. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170008F0 RID: 2288
		' (get) Token: 0x06002776 RID: 10102 RVA: 0x0010AF90 File Offset: 0x00109190
		Public ReadOnly Property OldValue As Object
			Get
				Return Me.OOO_00oooO_o._.
			End Get
		End Property

		' Token: 0x170008F1 RID: 2289
		' (get) Token: 0x06002777 RID: 10103 RVA: 0x0010AF98 File Offset: 0x00109198
		' (set) Token: 0x06002778 RID: 10104 RVA: 0x0010AFA0 File Offset: 0x001091A0
		Public Property Cancel As Boolean
			Get
				Return Me.o.0OoOo.
			End Get
			Set(value As Boolean)
				Me.o.0OoOo. = value
			End Set
		End Property

		' Token: 0x170008F2 RID: 2290
		' (get) Token: 0x06002779 RID: 10105 RVA: 0x0010AFAC File Offset: 0x001091AC
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

		' Token: 0x04001058 RID: 4184
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001059 RID: 4185
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x0400105A RID: 4186
		Private <<EMPTY_NAME>> As DataCol

		' Token: 0x0400105B RID: 4187
		Private <<EMPTY_NAME>> As Object

		' Token: 0x0400105C RID: 4188
		Private <<EMPTY_NAME>> As Object

		' Token: 0x0400105D RID: 4189
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
