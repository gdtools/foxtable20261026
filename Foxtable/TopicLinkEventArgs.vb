Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003E0 RID: 992
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TopicLinkEventArgs
		Inherits ControlEventArgs

		' Token: 0x06003EFD RID: 16125 RVA: 0x001B2AB0 File Offset: 0x001B0CB0
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As C1TopicBarClickEventArgs)
			MyBase.New(A_0, A_1)
			Me.O._oooo0__. = New TopicLink(A_2.Link)
			Me.O._oooo0__. = New TopicPage(A_2.Page)
		End Sub

		' Token: 0x17000DB6 RID: 3510
		' (get) Token: 0x06003EFE RID: 16126 RVA: 0x001B2ADC File Offset: 0x001B0CDC
		Public ReadOnly Property Link As TopicLink
			Get
				Return Me.O._oooo0__.
			End Get
		End Property

		' Token: 0x17000DB7 RID: 3511
		' (get) Token: 0x06003EFF RID: 16127 RVA: 0x001B2AE4 File Offset: 0x001B0CE4
		Public ReadOnly Property Page As TopicPage
			Get
				Return Me.O._oooo0__.
			End Get
		End Property

		' Token: 0x0400198B RID: 6539
		Private <<EMPTY_NAME>> As TopicLink

		' Token: 0x0400198C RID: 6540
		Private <<EMPTY_NAME>> As TopicPage
	End Class
End Namespace
