Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F0 RID: 752
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DrawRowEventArgs
		' Token: 0x0600279A RID: 10138 RVA: 0x0010B5D0 File Offset: 0x001097D0
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Integer)
			Me.ooo_OOO.O0O. = A_0
			Me.ooo_OOO.O0O. = A_1
			Me.ooo_OOO.O0O. = A_2
		End Sub

		' Token: 0x17000909 RID: 2313
		' (get) Token: 0x0600279B RID: 10139 RVA: 0x0010B5ED File Offset: 0x001097ED
		Public ReadOnly Property Table As Table
			Get
				Return Me.ooo_OOO.O0O.
			End Get
		End Property

		' Token: 0x1700090A RID: 2314
		' (get) Token: 0x0600279C RID: 10140 RVA: 0x0010B5F5 File Offset: 0x001097F5
		Public ReadOnly Property Row As Row
			Get
				Return Me.ooo_OOO.O0O.
			End Get
		End Property

		' Token: 0x1700090B RID: 2315
		' (get) Token: 0x0600279D RID: 10141 RVA: 0x0010B5FD File Offset: 0x001097FD
		' (set) Token: 0x0600279E RID: 10142 RVA: 0x0010B605 File Offset: 0x00109805
		Public Property Height As Integer
			Get
				Return Me.ooo_OOO.O0O.
			End Get
			Set(value As Integer)
				Me.ooo_OOO.O0O. = value
			End Set
		End Property

		' Token: 0x1700090C RID: 2316
		' (get) Token: 0x0600279F RID: 10143 RVA: 0x0010B60E File Offset: 0x0010980E
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400106C RID: 4204
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400106D RID: 4205
		Private <<EMPTY_NAME>> As Row

		' Token: 0x0400106E RID: 4206
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
