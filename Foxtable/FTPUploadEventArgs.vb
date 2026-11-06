Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000B0 RID: 176
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FTPUploadEventArgs
		' Token: 0x0600070A RID: 1802 RVA: 0x00027118 File Offset: 0x00025318
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.oo0__.0Oo0o_. = A_0
			Me.o.O0_o. = A_1.TrimEnd(New Char() { "/"c })
			If Operators.CompareString(Me.o.O0_o., "", True) = 0 Then
				Me.o.O0_o. = "/"
			End If
			Me.oOO___O.0Ooo. = A_2
		End Sub

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x0600070B RID: 1803 RVA: 0x0002716E File Offset: 0x0002536E
		Public ReadOnly Property LocalFile As String
			Get
				Return Me.oo0__.0Oo0o_.
			End Get
		End Property

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x0600070C RID: 1804 RVA: 0x00027176 File Offset: 0x00025376
		Public ReadOnly Property CurFolder As String
			Get
				Return Me.o.O0_o.
			End Get
		End Property

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x0600070D RID: 1805 RVA: 0x0002717E File Offset: 0x0002537E
		Public ReadOnly Property FTPName As String
			Get
				Return Me.oOO___O.0Ooo.
			End Get
		End Property

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x0600070E RID: 1806 RVA: 0x00027186 File Offset: 0x00025386
		' (set) Token: 0x0600070F RID: 1807 RVA: 0x0002718E File Offset: 0x0002538E
		Public Property Cancel As Boolean
			Get
				Return Me.O_.0O_o.
			End Get
			Set(value As Boolean)
				Me.O_.0O_o. = True
			End Set
		End Property

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x06000710 RID: 1808 RVA: 0x00027197 File Offset: 0x00025397
		' (set) Token: 0x06000711 RID: 1809 RVA: 0x0002719F File Offset: 0x0002539F
		Public Property CancelAll As Boolean
			Get
				Return Me.o_OO.00.
			End Get
			Set(value As Boolean)
				Me.o_OO.00. = value
			End Set
		End Property

		' Token: 0x040001FE RID: 510
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001FF RID: 511
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000200 RID: 512
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000201 RID: 513
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000202 RID: 514
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
