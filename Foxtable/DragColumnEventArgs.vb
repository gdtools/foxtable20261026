Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002EE RID: 750
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DragColumnEventArgs
		' Token: 0x0600277A RID: 10106 RVA: 0x0010AFF0 File Offset: 0x001091F0
		Public Sub New(A_0 As Table, A_1 As Integer, A_2 As Integer, A_3 As Integer)
			Me.oOOo0_O.OO_. = A_0
			Me.oOOo0_O.OO_. = A_1
			Me.o0OO_0._. = A_2
			Me.o_0oO.OOo. = A_3
		End Sub

		' Token: 0x170008F3 RID: 2291
		' (get) Token: 0x0600277B RID: 10107 RVA: 0x0010B015 File Offset: 0x00109215
		Public ReadOnly Property Table As Table
			Get
				Return Me.oOOo0_O.OO_.
			End Get
		End Property

		' Token: 0x170008F4 RID: 2292
		' (get) Token: 0x0600277C RID: 10108 RVA: 0x0010B01D File Offset: 0x0010921D
		Public ReadOnly Property c1 As Integer
			Get
				Return Me.oOOo0_O.OO_.
			End Get
		End Property

		' Token: 0x170008F5 RID: 2293
		' (get) Token: 0x0600277D RID: 10109 RVA: 0x0010B025 File Offset: 0x00109225
		Public ReadOnly Property c2 As Integer
			Get
				Return Me.o0OO_0._.
			End Get
		End Property

		' Token: 0x170008F6 RID: 2294
		' (get) Token: 0x0600277E RID: 10110 RVA: 0x0010B02D File Offset: 0x0010922D
		' (set) Token: 0x0600277F RID: 10111 RVA: 0x0010B035 File Offset: 0x00109235
		Public Property Position As Integer
			Get
				Return Me.o_0oO.OOo.
			End Get
			Set(value As Integer)
				Me.o_0oO.OOo. = value
			End Set
		End Property

		' Token: 0x170008F7 RID: 2295
		' (get) Token: 0x06002780 RID: 10112 RVA: 0x0010B03E File Offset: 0x0010923E
		' (set) Token: 0x06002781 RID: 10113 RVA: 0x0010B046 File Offset: 0x00109246
		Public Property Cancel As Boolean
			Get
				Return Me.oOOo0_O.OO_.
			End Get
			Set(value As Boolean)
				Me.oOOo0_O.OO_. = value
			End Set
		End Property

		' Token: 0x170008F8 RID: 2296
		' (get) Token: 0x06002782 RID: 10114 RVA: 0x0010B04F File Offset: 0x0010924F
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400105E RID: 4190
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400105F RID: 4191
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001060 RID: 4192
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001061 RID: 4193
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001062 RID: 4194
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
