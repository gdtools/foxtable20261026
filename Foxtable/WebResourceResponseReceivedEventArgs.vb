Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000128 RID: 296
	Public Class WebResourceResponseReceivedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E5E RID: 3678 RVA: 0x00061697 File Offset: 0x0005F897
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2WebResourceResponseReceivedEventArgs)
			MyBase.New(A_0, A_1)
			Me.Oo0Oo_0oo0.0. = A_2
		End Sub

		' Token: 0x1700028A RID: 650
		' (get) Token: 0x06000E5F RID: 3679 RVA: 0x000616A8 File Offset: 0x0005F8A8
		Public ReadOnly Property Request As CoreWebView2WebResourceRequest
			Get
				Return Me.Oo0Oo_0oo0.0..Request
			End Get
		End Property

		' Token: 0x1700028B RID: 651
		' (get) Token: 0x06000E60 RID: 3680 RVA: 0x000616B5 File Offset: 0x0005F8B5
		Public ReadOnly Property Response As CoreWebView2WebResourceResponseView
			Get
				Return Me.Oo0Oo_0oo0.0..Response
			End Get
		End Property

		' Token: 0x04000593 RID: 1427
		Private <<EMPTY_NAME>> As CoreWebView2WebResourceResponseReceivedEventArgs
	End Class
End Namespace
