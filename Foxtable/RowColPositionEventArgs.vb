Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F8 RID: 760
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RowColPositionEventArgs
		' Token: 0x060027DB RID: 10203 RVA: 0x0010BA4F File Offset: 0x00109C4F
		Public Sub New(A_0 As Table, A_1 As Integer)
			Me.oo0Ooo.o_0__0_. = A_0
			Me.oo0Ooo.o_0__0_. = A_1
		End Sub

		' Token: 0x17000932 RID: 2354
		' (get) Token: 0x060027DC RID: 10204 RVA: 0x0010BA65 File Offset: 0x00109C65
		Public ReadOnly Property Table As Table
			Get
				Return Me.oo0Ooo.o_0__0_.
			End Get
		End Property

		' Token: 0x17000933 RID: 2355
		' (get) Token: 0x060027DD RID: 10205 RVA: 0x0010BA6D File Offset: 0x00109C6D
		Public ReadOnly Property Position As Integer
			Get
				Return Me.oo0Ooo.o_0__0_.
			End Get
		End Property

		' Token: 0x17000934 RID: 2356
		' (get) Token: 0x060027DE RID: 10206 RVA: 0x0010BA75 File Offset: 0x00109C75
		' (set) Token: 0x060027DF RID: 10207 RVA: 0x0010BA7D File Offset: 0x00109C7D
		Public Property Cancel As Boolean
			Get
				Return Me.oo0Ooo.o_0__0_.
			End Get
			Set(value As Boolean)
				Me.oo0Ooo.o_0__0_. = value
			End Set
		End Property

		' Token: 0x17000935 RID: 2357
		' (get) Token: 0x060027E0 RID: 10208 RVA: 0x0010BA86 File Offset: 0x00109C86
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001087 RID: 4231
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001088 RID: 4232
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001089 RID: 4233
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
