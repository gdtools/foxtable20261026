Imports System
Imports System.ComponentModel
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000247 RID: 583
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SortEventArgs
		' Token: 0x06001B0C RID: 6924 RVA: 0x000ABE8E File Offset: 0x000AA08E
		Public Sub New(A_0 As Table, A_1 As String)
			Me.oo.o0O. = A_0
			Me.oo.o0O. = A_1
		End Sub

		' Token: 0x17000630 RID: 1584
		' (get) Token: 0x06001B0D RID: 6925 RVA: 0x000ABEA4 File Offset: 0x000AA0A4
		Public ReadOnly Property Table As Table
			Get
				Return Me.oo.o0O.
			End Get
		End Property

		' Token: 0x17000631 RID: 1585
		' (get) Token: 0x06001B0E RID: 6926 RVA: 0x000ABEAC File Offset: 0x000AA0AC
		' (set) Token: 0x06001B0F RID: 6927 RVA: 0x000ABEB4 File Offset: 0x000AA0B4
		Public Property Sort As String
			Get
				Return Me.oo.o0O.
			End Get
			Set(value As String)
				Me.oo.o0O. = value
			End Set
		End Property

		' Token: 0x17000632 RID: 1586
		' (get) Token: 0x06001B10 RID: 6928 RVA: 0x000ABEBD File Offset: 0x000AA0BD
		' (set) Token: 0x06001B11 RID: 6929 RVA: 0x000ABEC5 File Offset: 0x000AA0C5
		Public Property Cancel As Boolean
			Get
				Return Me.oo.o0O.
			End Get
			Set(value As Boolean)
				Me.oo.o0O. = value
			End Set
		End Property

		' Token: 0x17000633 RID: 1587
		' (get) Token: 0x06001B12 RID: 6930 RVA: 0x000ABECE File Offset: 0x000AA0CE
		Public ReadOnly Property Form As Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04000B73 RID: 2931
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000B74 RID: 2932
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B75 RID: 2933
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
