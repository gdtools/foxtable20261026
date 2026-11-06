Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000122 RID: 290
	Public Class NavigationCompletedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E35 RID: 3637 RVA: 0x00061465 File Offset: 0x0005F665
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2NavigationCompletedEventArgs)
			MyBase.New(A_0, A_1)
			Me.oO_o.0_o0_. = A_2
		End Sub

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x06000E36 RID: 3638 RVA: 0x00061476 File Offset: 0x0005F676
		Public ReadOnly Property IsSuccess As Boolean
			Get
				Return Me.oO_o.0_o0_..IsSuccess
			End Get
		End Property

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x06000E37 RID: 3639 RVA: 0x00061483 File Offset: 0x0005F683
		Public ReadOnly Property NavigationId As ULong
			Get
				Return Me.oO_o.0_o0_..NavigationId
			End Get
		End Property

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x06000E38 RID: 3640 RVA: 0x00061490 File Offset: 0x0005F690
		Public ReadOnly Property WebErrorStatus As CoreWebView2WebErrorStatus
			Get
				Return Me.oO_o.0_o0_..WebErrorStatus
			End Get
		End Property

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x06000E39 RID: 3641 RVA: 0x0006149D File Offset: 0x0005F69D
		Public ReadOnly Property HttpStatusCode As Integer
			Get
				Return Me.oO_o.0_o0_..HttpStatusCode
			End Get
		End Property

		' Token: 0x0400058D RID: 1421
		Private <<EMPTY_NAME>> As CoreWebView2NavigationCompletedEventArgs
	End Class
End Namespace
