Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000240 RID: 576
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FilterEventArgs
		' Token: 0x06001AE6 RID: 6886 RVA: 0x000ABC63 File Offset: 0x000A9E63
		Public Sub New(A_0 As Table, A_1 As String)
			Me.O._00000. = A_0
			Me.O._00000. = A_1
		End Sub

		' Token: 0x17000617 RID: 1559
		' (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000ABC79 File Offset: 0x000A9E79
		Public ReadOnly Property Table As Table
			Get
				Return Me.O._00000.
			End Get
		End Property

		' Token: 0x17000618 RID: 1560
		' (get) Token: 0x06001AE8 RID: 6888 RVA: 0x000ABC81 File Offset: 0x000A9E81
		' (set) Token: 0x06001AE9 RID: 6889 RVA: 0x000ABC89 File Offset: 0x000A9E89
		Public Property Filter As String
			Get
				Return Me.O._00000.
			End Get
			Set(value As String)
				Me.O._00000. = value
			End Set
		End Property

		' Token: 0x17000619 RID: 1561
		' (get) Token: 0x06001AEA RID: 6890 RVA: 0x000ABC92 File Offset: 0x000A9E92
		' (set) Token: 0x06001AEB RID: 6891 RVA: 0x000ABC9A File Offset: 0x000A9E9A
		Public Property Cancel As Boolean
			Get
				Return Me.O._00000.
			End Get
			Set(value As Boolean)
				Me.O._00000. = value
			End Set
		End Property

		' Token: 0x1700061A RID: 1562
		' (get) Token: 0x06001AEC RID: 6892 RVA: 0x000ABCA3 File Offset: 0x000A9EA3
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04000B5E RID: 2910
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000B5F RID: 2911
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B60 RID: 2912
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
