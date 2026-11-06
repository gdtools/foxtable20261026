Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000123 RID: 291
	Public Class NavigationStartingEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E3A RID: 3642 RVA: 0x000614AA File Offset: 0x0005F6AA
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2NavigationStartingEventArgs)
			MyBase.New(A_0, A_1)
			Me.O__0_0Oo.Oo000. = A_2
		End Sub

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x06000E3B RID: 3643 RVA: 0x000614BB File Offset: 0x0005F6BB
		' (set) Token: 0x06000E3C RID: 3644 RVA: 0x000614C8 File Offset: 0x0005F6C8
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.O__0_0Oo.Oo000..Cancel
			End Get
			Set(value As Boolean)
				Me.O__0_0Oo.Oo000..Cancel = True
			End Set
		End Property

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x06000E3D RID: 3645 RVA: 0x000614D6 File Offset: 0x0005F6D6
		Public ReadOnly Property IsRedirected As Boolean
			Get
				Return Me.O__0_0Oo.Oo000..IsRedirected
			End Get
		End Property

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x06000E3E RID: 3646 RVA: 0x000614E3 File Offset: 0x0005F6E3
		Public ReadOnly Property IsUserInitiated As Boolean
			Get
				Return Me.O__0_0Oo.Oo000..IsUserInitiated
			End Get
		End Property

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x06000E3F RID: 3647 RVA: 0x000614F0 File Offset: 0x0005F6F0
		Public ReadOnly Property NavigationId As ULong
			Get
				Return Me.O__0_0Oo.Oo000..NavigationId
			End Get
		End Property

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x06000E40 RID: 3648 RVA: 0x000614FD File Offset: 0x0005F6FD
		Public ReadOnly Property RequestHeaders As CoreWebView2HttpRequestHeaders
			Get
				Return Me.O__0_0Oo.Oo000..RequestHeaders
			End Get
		End Property

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x06000E41 RID: 3649 RVA: 0x0006150A File Offset: 0x0005F70A
		Public ReadOnly Property Uri As String
			Get
				Return Me.O__0_0Oo.Oo000..Uri
			End Get
		End Property

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x06000E42 RID: 3650 RVA: 0x00061517 File Offset: 0x0005F717
		' (set) Token: 0x06000E43 RID: 3651 RVA: 0x00061524 File Offset: 0x0005F724
		Public Property AdditionalAllowedFrameAncestors As String
			Get
				Return Me.O__0_0Oo.Oo000..AdditionalAllowedFrameAncestors
			End Get
			Set(value As String)
				Me.O__0_0Oo.Oo000..AdditionalAllowedFrameAncestors = value
			End Set
		End Property

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x06000E44 RID: 3652 RVA: 0x00061532 File Offset: 0x0005F732
		Public ReadOnly Property NavigationKind As CoreWebView2NavigationKind
			Get
				Return Me.O__0_0Oo.Oo000..NavigationKind
			End Get
		End Property

		' Token: 0x0400058E RID: 1422
		Private <<EMPTY_NAME>> As CoreWebView2NavigationStartingEventArgs
	End Class
End Namespace
