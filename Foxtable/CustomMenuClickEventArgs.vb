Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000186 RID: 390
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CustomMenuClickEventArgs
		Inherits OpenQQMenuEventArgs

		' Token: 0x06001218 RID: 4632 RVA: 0x0006E939 File Offset: 0x0006CB39
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Integer, A_4 As String, A_5 As DateTime)
			MyBase.New(A_1, A_2, A_3, A_4, A_5)
			Me.o0o0O._o0Oo. = A_0
		End Sub

		' Token: 0x170003E0 RID: 992
		' (get) Token: 0x06001219 RID: 4633 RVA: 0x0006E950 File Offset: 0x0006CB50
		Public ReadOnly Property MenuText As String
			Get
				Return Me.o0o0O._o0Oo.
			End Get
		End Property

		' Token: 0x040006F8 RID: 1784
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
