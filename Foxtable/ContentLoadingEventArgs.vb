Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000E3 RID: 227
	Public Class ContentLoadingEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000CB5 RID: 3253 RVA: 0x0005C951 File Offset: 0x0005AB51
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2ContentLoadingEventArgs)
			MyBase.New(A_0, A_1)
			Me.Oo___.ooooO00. = A_2
		End Sub

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0005C962 File Offset: 0x0005AB62
		Public ReadOnly Property IsErrorPage As Boolean
			Get
				Return Me.Oo___.ooooO00..IsErrorPage
			End Get
		End Property

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0005C96F File Offset: 0x0005AB6F
		Public ReadOnly Property NavigationId As ULong
			Get
				Return Me.Oo___.ooooO00..NavigationId
			End Get
		End Property

		' Token: 0x040004E0 RID: 1248
		Private <<EMPTY_NAME>> As CoreWebView2ContentLoadingEventArgs
	End Class
End Namespace
