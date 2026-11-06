Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000F5 RID: 245
	Public Class DownloadStateChangedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000D4B RID: 3403 RVA: 0x0005F0DD File Offset: 0x0005D2DD
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2DownloadOperation)
			MyBase.New(A_0, A_1)
			Me.oOOo0_O.OO_. = A_2
		End Sub

		' Token: 0x1700023E RID: 574
		' (get) Token: 0x06000D4C RID: 3404 RVA: 0x0005F0EE File Offset: 0x0005D2EE
		Public ReadOnly Property ResultFilePath As String
			Get
				Return Me.oOOo0_O.OO_..ResultFilePath
			End Get
		End Property

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x06000D4D RID: 3405 RVA: 0x0005F0FB File Offset: 0x0005D2FB
		Public ReadOnly Property Uri As String
			Get
				Return Me.oOOo0_O.OO_..Uri
			End Get
		End Property

		' Token: 0x17000240 RID: 576
		' (get) Token: 0x06000D4E RID: 3406 RVA: 0x0005F108 File Offset: 0x0005D308
		Public ReadOnly Property MimeType As String
			Get
				Return Me.oOOo0_O.OO_..MimeType
			End Get
		End Property

		' Token: 0x17000241 RID: 577
		' (get) Token: 0x06000D4F RID: 3407 RVA: 0x0005F115 File Offset: 0x0005D315
		Public ReadOnly Property State As CoreWebView2DownloadState
			Get
				Return Me.oOOo0_O.OO_..State
			End Get
		End Property

		' Token: 0x17000242 RID: 578
		' (get) Token: 0x06000D50 RID: 3408 RVA: 0x0005F122 File Offset: 0x0005D322
		Public ReadOnly Property BytesReceived As Long
			Get
				Return Me.oOOo0_O.OO_..BytesReceived
			End Get
		End Property

		' Token: 0x17000243 RID: 579
		' (get) Token: 0x06000D51 RID: 3409 RVA: 0x0005F12F File Offset: 0x0005D32F
		Public ReadOnly Property CanResume As Boolean
			Get
				Return Me.oOOo0_O.OO_..CanResume
			End Get
		End Property

		' Token: 0x17000244 RID: 580
		' (get) Token: 0x06000D52 RID: 3410 RVA: 0x0005F13C File Offset: 0x0005D33C
		Public ReadOnly Property TotalBytesToReceive As ULong
			Get
				Dim result As ULong
				If Me.oOOo0_O.OO_..TotalBytesToReceive IsNot Nothing Then
					result = Me.oOOo0_O.OO_..TotalBytesToReceive.Value
				Else
					result = ULong.MaxValue
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000245 RID: 581
		' (get) Token: 0x06000D53 RID: 3411 RVA: 0x0005F178 File Offset: 0x0005D378
		Public ReadOnly Property DownloadOperation As CoreWebView2DownloadOperation
			Get
				Return Me.oOOo0_O.OO_.
			End Get
		End Property

		' Token: 0x0400051A RID: 1306
		Private <<EMPTY_NAME>> As CoreWebView2DownloadOperation
	End Class
End Namespace
