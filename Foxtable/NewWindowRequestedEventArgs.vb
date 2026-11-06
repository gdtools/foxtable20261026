Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000124 RID: 292
	Public Class NewWindowRequestedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E45 RID: 3653 RVA: 0x0006153F File Offset: 0x0005F73F
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2NewWindowRequestedEventArgs)
			MyBase.New(A_0, A_1)
			Me.OO0o0.0OOo_. = A_2
		End Sub

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x06000E46 RID: 3654 RVA: 0x00061550 File Offset: 0x0005F750
		' (set) Token: 0x06000E47 RID: 3655 RVA: 0x0006155D File Offset: 0x0005F75D
		Public Property Handled As Boolean
			Get
				Return Me.OO0o0.0OOo_..Handled
			End Get
			Set(value As Boolean)
				Me.OO0o0.0OOo_..Handled = value
			End Set
		End Property

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x06000E48 RID: 3656 RVA: 0x0006156B File Offset: 0x0005F76B
		Public ReadOnly Property IsUserInitiated As Boolean
			Get
				Return Me.OO0o0.0OOo_..IsUserInitiated
			End Get
		End Property

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x06000E49 RID: 3657 RVA: 0x00061578 File Offset: 0x0005F778
		' (set) Token: 0x06000E4A RID: 3658 RVA: 0x00061585 File Offset: 0x0005F785
		Public Property NewWindow As CoreWebView2
			Get
				Return Me.OO0o0.0OOo_..NewWindow
			End Get
			Set(value As CoreWebView2)
				Me.OO0o0.0OOo_..NewWindow = value
			End Set
		End Property

		' Token: 0x1700027E RID: 638
		' (get) Token: 0x06000E4B RID: 3659 RVA: 0x00061593 File Offset: 0x0005F793
		Public ReadOnly Property Uri As String
			Get
				Return Me.OO0o0.0OOo_..Uri
			End Get
		End Property

		' Token: 0x1700027F RID: 639
		' (get) Token: 0x06000E4C RID: 3660 RVA: 0x000615A0 File Offset: 0x0005F7A0
		Public ReadOnly Property WindowFeatures As CoreWebView2WindowFeatures
			Get
				Return Me.OO0o0.0OOo_..WindowFeatures
			End Get
		End Property

		' Token: 0x17000280 RID: 640
		' (get) Token: 0x06000E4D RID: 3661 RVA: 0x000615AD File Offset: 0x0005F7AD
		Public ReadOnly Property Name As String
			Get
				Return Me.OO0o0.0OOo_..Name
			End Get
		End Property

		' Token: 0x17000281 RID: 641
		' (get) Token: 0x06000E4E RID: 3662 RVA: 0x000615BA File Offset: 0x0005F7BA
		Public ReadOnly Property OriginalSourceFrameInfo As CoreWebView2FrameInfo
			Get
				Return Me.OO0o0.0OOo_..OriginalSourceFrameInfo
			End Get
		End Property

		' Token: 0x06000E4F RID: 3663 RVA: 0x000615C7 File Offset: 0x0005F7C7
		Public Function GetDeferral() As CoreWebView2Deferral
			Return Me.OO0o0.0OOo_..GetDeferral()
		End Function

		' Token: 0x0400058F RID: 1423
		Private <<EMPTY_NAME>> As CoreWebView2NewWindowRequestedEventArgs
	End Class
End Namespace
