Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F7 RID: 759
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class MoveRowEventArgs
		' Token: 0x060027D4 RID: 10196 RVA: 0x0010B9FC File Offset: 0x00109BFC
		Public Sub New(A_0 As Table, A_1 As Integer, A_2 As Integer)
			Me.o0o.OooOOo0__. = A_0
			Me.o0o.OooOOo0__. = A_1
			Me.o0_ooOo0__0.0_. = A_2
		End Sub

		' Token: 0x1700092D RID: 2349
		' (get) Token: 0x060027D5 RID: 10197 RVA: 0x0010BA19 File Offset: 0x00109C19
		Public ReadOnly Property Table As Table
			Get
				Return Me.o0o.OooOOo0__.
			End Get
		End Property

		' Token: 0x1700092E RID: 2350
		' (get) Token: 0x060027D6 RID: 10198 RVA: 0x0010BA21 File Offset: 0x00109C21
		Public ReadOnly Property OldIndex As Integer
			Get
				Return Me.o0o.OooOOo0__.
			End Get
		End Property

		' Token: 0x1700092F RID: 2351
		' (get) Token: 0x060027D7 RID: 10199 RVA: 0x0010BA29 File Offset: 0x00109C29
		Public ReadOnly Property NewIndex As Integer
			Get
				Return Me.o0_ooOo0__0.0_.
			End Get
		End Property

		' Token: 0x17000930 RID: 2352
		' (get) Token: 0x060027D8 RID: 10200 RVA: 0x0010BA31 File Offset: 0x00109C31
		' (set) Token: 0x060027D9 RID: 10201 RVA: 0x0010BA39 File Offset: 0x00109C39
		Public Property Cancel As Boolean
			Get
				Return Me.o0o.OooOOo0__.
			End Get
			Set(value As Boolean)
				Me.o0o.OooOOo0__. = value
			End Set
		End Property

		' Token: 0x17000931 RID: 2353
		' (get) Token: 0x060027DA RID: 10202 RVA: 0x0010BA42 File Offset: 0x00109C42
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001083 RID: 4227
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001084 RID: 4228
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001085 RID: 4229
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001086 RID: 4230
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
