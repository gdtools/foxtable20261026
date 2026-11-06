Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F9 RID: 761
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SetupEditorEventArgs
		' Token: 0x060027E1 RID: 10209 RVA: 0x0010BA93 File Offset: 0x00109C93
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As System.Windows.Forms.Control, A_4 As RecordGrid)
			Me.OoO.Oo0O0o. = A_0
			Me.OoO.Oo0O0o. = A_1
			Me.OoO.Oo0O0o. = A_2
			Me.OoO.Oo0O0o. = A_3
			Me.OoO.Oo0O0o. = A_4
		End Sub

		' Token: 0x17000936 RID: 2358
		' (get) Token: 0x060027E2 RID: 10210 RVA: 0x0010BAC0 File Offset: 0x00109CC0
		Public ReadOnly Property Table As Table
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x17000937 RID: 2359
		' (get) Token: 0x060027E3 RID: 10211 RVA: 0x0010BAC8 File Offset: 0x00109CC8
		Public ReadOnly Property Row As Row
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x17000938 RID: 2360
		' (get) Token: 0x060027E4 RID: 10212 RVA: 0x0010BAD0 File Offset: 0x00109CD0
		Public ReadOnly Property Col As Col
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x17000939 RID: 2361
		' (get) Token: 0x060027E5 RID: 10213 RVA: 0x0010BAD8 File Offset: 0x00109CD8
		Public ReadOnly Property Editor As System.Windows.Forms.Control
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x1700093A RID: 2362
		' (get) Token: 0x060027E6 RID: 10214 RVA: 0x0010BAE0 File Offset: 0x00109CE0
		' (set) Token: 0x060027E7 RID: 10215 RVA: 0x0010BAE8 File Offset: 0x00109CE8
		Public Property Cancel As Boolean
			Get
				Return Me.OoO.Oo0O0o.
			End Get
			Set(value As Boolean)
				Me.OoO.Oo0O0o. = value
			End Set
		End Property

		' Token: 0x1700093B RID: 2363
		' (get) Token: 0x060027E8 RID: 10216 RVA: 0x0010BAF1 File Offset: 0x00109CF1
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.OoO.Oo0O0o.
			End Get
		End Property

		' Token: 0x1700093C RID: 2364
		' (get) Token: 0x060027E9 RID: 10217 RVA: 0x0010BAF9 File Offset: 0x00109CF9
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400108A RID: 4234
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400108B RID: 4235
		Private <<EMPTY_NAME>> As Row

		' Token: 0x0400108C RID: 4236
		Private <<EMPTY_NAME>> As Col

		' Token: 0x0400108D RID: 4237
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x0400108E RID: 4238
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400108F RID: 4239
		Private <<EMPTY_NAME>> As RecordGrid
	End Class
End Namespace
