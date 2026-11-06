Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000125 RID: 293
	Public Class SourceChangedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E50 RID: 3664 RVA: 0x000615D4 File Offset: 0x0005F7D4
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2SourceChangedEventArgs)
			MyBase.New(A_0, A_1)
			Me.oo.o0O. = A_2
		End Sub

		' Token: 0x17000282 RID: 642
		' (get) Token: 0x06000E51 RID: 3665 RVA: 0x000615E5 File Offset: 0x0005F7E5
		Public ReadOnly Property IsNewDocument As Boolean
			Get
				Return Me.oo.o0O..IsNewDocument
			End Get
		End Property

		' Token: 0x04000590 RID: 1424
		Private <<EMPTY_NAME>> As CoreWebView2SourceChangedEventArgs
	End Class
End Namespace
