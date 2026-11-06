Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002FB RID: 763
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ValidateEditEventArgs
		' Token: 0x060027ED RID: 10221 RVA: 0x0010BB2A File Offset: 0x00109D2A
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As String, A_4 As RecordGrid)
			Me.o.O0o_O. = A_0
			Me.o.O0o_O. = A_1
			Me.o.O0o_O. = A_2
			Me.o.O0o_O. = A_3
			Me.o.O0o_O. = A_4
		End Sub

		' Token: 0x1700093F RID: 2367
		' (get) Token: 0x060027EE RID: 10222 RVA: 0x0010BB57 File Offset: 0x00109D57
		Public ReadOnly Property Table As Table
			Get
				Return Me.o.O0o_O.
			End Get
		End Property

		' Token: 0x17000940 RID: 2368
		' (get) Token: 0x060027EF RID: 10223 RVA: 0x0010BB5F File Offset: 0x00109D5F
		Public ReadOnly Property Row As Row
			Get
				Return Me.o.O0o_O.
			End Get
		End Property

		' Token: 0x17000941 RID: 2369
		' (get) Token: 0x060027F0 RID: 10224 RVA: 0x0010BB67 File Offset: 0x00109D67
		Public ReadOnly Property Col As Col
			Get
				Return Me.o.O0o_O.
			End Get
		End Property

		' Token: 0x17000942 RID: 2370
		' (get) Token: 0x060027F1 RID: 10225 RVA: 0x0010BB6F File Offset: 0x00109D6F
		' (set) Token: 0x060027F2 RID: 10226 RVA: 0x0010BB77 File Offset: 0x00109D77
		Public Property Text As String
			Get
				Return Me.o.O0o_O.
			End Get
			Set(value As String)
				Me.o.O0o_O. = value
			End Set
		End Property

		' Token: 0x17000943 RID: 2371
		' (get) Token: 0x060027F3 RID: 10227 RVA: 0x0010BB80 File Offset: 0x00109D80
		' (set) Token: 0x060027F4 RID: 10228 RVA: 0x0010BB88 File Offset: 0x00109D88
		Public Property Cancel As Boolean
			Get
				Return Me.o.O0o_O.
			End Get
			Set(value As Boolean)
				Me.o.O0o_O. = value
			End Set
		End Property

		' Token: 0x17000944 RID: 2372
		' (get) Token: 0x060027F5 RID: 10229 RVA: 0x0010BB91 File Offset: 0x00109D91
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.o.O0o_O.
			End Get
		End Property

		' Token: 0x17000945 RID: 2373
		' (get) Token: 0x060027F6 RID: 10230 RVA: 0x0010BB99 File Offset: 0x00109D99
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001091 RID: 4241
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001092 RID: 4242
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04001093 RID: 4243
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04001094 RID: 4244
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001095 RID: 4245
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001096 RID: 4246
		Private <<EMPTY_NAME>> As RecordGrid
	End Class
End Namespace
