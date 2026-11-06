Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F1 RID: 753
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FilterRowEventArgs
		' Token: 0x060027A0 RID: 10144 RVA: 0x0010B61B File Offset: 0x0010981B
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Boolean)
			Me.O0o.0oo0_. = True
			Me.O0o.0oo0_. = A_0
			Me.O._00000. = A_1
			Me.O0o.0oo0_. = A_2
		End Sub

		' Token: 0x1700090D RID: 2317
		' (get) Token: 0x060027A1 RID: 10145 RVA: 0x0010B63F File Offset: 0x0010983F
		Public ReadOnly Property Table As Table
			Get
				Return Me.O0o.0oo0_.
			End Get
		End Property

		' Token: 0x1700090E RID: 2318
		' (get) Token: 0x060027A2 RID: 10146 RVA: 0x0010B647 File Offset: 0x00109847
		Public ReadOnly Property Row As Row
			Get
				Return Me.O._00000.
			End Get
		End Property

		' Token: 0x1700090F RID: 2319
		' (get) Token: 0x060027A3 RID: 10147 RVA: 0x0010B64F File Offset: 0x0010984F
		' (set) Token: 0x060027A4 RID: 10148 RVA: 0x0010B657 File Offset: 0x00109857
		Public Property Visible As Boolean
			Get
				Return Me.O0o.0oo0_.
			End Get
			Set(value As Boolean)
				Me.O0o.0oo0_. = value
			End Set
		End Property

		' Token: 0x17000910 RID: 2320
		' (get) Token: 0x060027A5 RID: 10149 RVA: 0x0010B660 File Offset: 0x00109860
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x0400106F RID: 4207
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001070 RID: 4208
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04001071 RID: 4209
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
