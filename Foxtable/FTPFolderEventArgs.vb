Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000AE RID: 174
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPFolderEventArgs
		' Token: 0x060006FD RID: 1789 RVA: 0x00027040 File Offset: 0x00025240
		Public Sub New(A_0 As String, A_1 As String)
			Me.O_.0O_o. = A_0.TrimEnd(New Char() { "/"c })
			If Operators.CompareString(Me.O_.0O_o., "", True) = 0 Then
				Me.O_.0O_o. = "/"
			End If
			Me.o_OO.00. = A_1
		End Sub

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x060006FE RID: 1790 RVA: 0x0002708F File Offset: 0x0002528F
		Public ReadOnly Property FolderName As String
			Get
				Return Me.O_.0O_o.
			End Get
		End Property

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x060006FF RID: 1791 RVA: 0x00027097 File Offset: 0x00025297
		Public ReadOnly Property FTPName As String
			Get
				Return Me.o_OO.00.
			End Get
		End Property

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000700 RID: 1792 RVA: 0x0002709F File Offset: 0x0002529F
		' (set) Token: 0x06000701 RID: 1793 RVA: 0x000270A7 File Offset: 0x000252A7
		Public Property Cancel As Boolean
			Get
				Return Me.O00_.ooO.
			End Get
			Set(value As Boolean)
				Me.O00_.ooO. = value
			End Set
		End Property

		' Token: 0x040001F5 RID: 501
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001F6 RID: 502
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001F7 RID: 503
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
