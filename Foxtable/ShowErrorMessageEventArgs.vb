Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000246 RID: 582
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ShowErrorMessageEventArgs
		' Token: 0x06001B05 RID: 6917 RVA: 0x000ABE3D File Offset: 0x000AA03D
		Public Sub New(A_0 As Exception, A_1 As String)
			Me.o0O_.00. = A_0
			Me.o0O_.00. = A_1
		End Sub

		' Token: 0x1700062B RID: 1579
		' (get) Token: 0x06001B06 RID: 6918 RVA: 0x000ABE53 File Offset: 0x000AA053
		' (set) Token: 0x06001B07 RID: 6919 RVA: 0x000ABE5B File Offset: 0x000AA05B
		Public Property Cancel As Boolean
			Get
				Return Me.o0O_.00.
			End Get
			Set(value As Boolean)
				Me.o0O_.00. = value
			End Set
		End Property

		' Token: 0x1700062C RID: 1580
		' (get) Token: 0x06001B08 RID: 6920 RVA: 0x000ABE64 File Offset: 0x000AA064
		Public ReadOnly Property ex As Exception
			Get
				Return Me.o0O_.00.
			End Get
		End Property

		' Token: 0x1700062D RID: 1581
		' (get) Token: 0x06001B09 RID: 6921 RVA: 0x000ABE6C File Offset: 0x000AA06C
		Public ReadOnly Property [Event] As String
			Get
				Return Me.o0O_.00.
			End Get
		End Property

		' Token: 0x1700062E RID: 1582
		' (get) Token: 0x06001B0A RID: 6922 RVA: 0x000ABE74 File Offset: 0x000AA074
		Public ReadOnly Property Message1 As String
			Get
				Return Me.ex.Message
			End Get
		End Property

		' Token: 0x1700062F RID: 1583
		' (get) Token: 0x06001B0B RID: 6923 RVA: 0x000ABE81 File Offset: 0x000AA081
		Public ReadOnly Property Message2 As String
			Get
				Return Me.ex.ToString()
			End Get
		End Property

		' Token: 0x04000B70 RID: 2928
		Private <<EMPTY_NAME>> As Exception

		' Token: 0x04000B71 RID: 2929
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B72 RID: 2930
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
