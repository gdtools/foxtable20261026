Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000E6 RID: 230
	Public Class DOMContentLoadedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000CC7 RID: 3271 RVA: 0x0005CAB9 File Offset: 0x0005ACB9
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2DOMContentLoadedEventArgs)
			MyBase.New(A_0, A_1)
			Me.OO_.0o_0. = A_2
		End Sub

		' Token: 0x1700021C RID: 540
		' (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0005CACA File Offset: 0x0005ACCA
		Public ReadOnly Property NavigationId As ULong
			Get
				Return Me.OO_.0o_0..NavigationId
			End Get
		End Property

		' Token: 0x040004E7 RID: 1255
		Private <<EMPTY_NAME>> As CoreWebView2DOMContentLoadedEventArgs
	End Class
End Namespace
