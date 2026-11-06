Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000127 RID: 295
	Public Class WebResourceRequestedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E57 RID: 3671 RVA: 0x00061637 File Offset: 0x0005F837
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2WebResourceRequestedEventArgs)
			MyBase.New(A_0, A_1)
			Me.Oo0Oo_0oo0.0. = A_2
		End Sub

		' Token: 0x17000286 RID: 646
		' (get) Token: 0x06000E58 RID: 3672 RVA: 0x00061648 File Offset: 0x0005F848
		Public ReadOnly Property Request As CoreWebView2WebResourceRequest
			Get
				Return Me.Oo0Oo_0oo0.0..Request
			End Get
		End Property

		' Token: 0x17000287 RID: 647
		' (get) Token: 0x06000E59 RID: 3673 RVA: 0x00061655 File Offset: 0x0005F855
		Public ReadOnly Property ResourceContext As CoreWebView2WebResourceContext
			Get
				Return Me.Oo0Oo_0oo0.0..ResourceContext
			End Get
		End Property

		' Token: 0x17000288 RID: 648
		' (get) Token: 0x06000E5A RID: 3674 RVA: 0x00061662 File Offset: 0x0005F862
		' (set) Token: 0x06000E5B RID: 3675 RVA: 0x0006166F File Offset: 0x0005F86F
		Public Property Response As CoreWebView2WebResourceResponse
			Get
				Return Me.Oo0Oo_0oo0.0..Response
			End Get
			Set(value As CoreWebView2WebResourceResponse)
				Me.Oo0Oo_0oo0.0..Response = value
			End Set
		End Property

		' Token: 0x17000289 RID: 649
		' (get) Token: 0x06000E5C RID: 3676 RVA: 0x0006167D File Offset: 0x0005F87D
		Public ReadOnly Property RequestedSourceKind As CoreWebView2WebResourceRequestSourceKinds
			Get
				Return Me.Oo0Oo_0oo0.0..RequestedSourceKind
			End Get
		End Property

		' Token: 0x06000E5D RID: 3677 RVA: 0x0006168A File Offset: 0x0005F88A
		Public Function GetDeferral() As CoreWebView2Deferral
			Return Me.Oo0Oo_0oo0.0..GetDeferral()
		End Function

		' Token: 0x04000592 RID: 1426
		Private <<EMPTY_NAME>> As CoreWebView2WebResourceRequestedEventArgs
	End Class
End Namespace
