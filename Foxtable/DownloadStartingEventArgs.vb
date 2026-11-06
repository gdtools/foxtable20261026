Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000F4 RID: 244
	Public Class DownloadStartingEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000D3F RID: 3391 RVA: 0x0005EFF6 File Offset: 0x0005D1F6
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2DownloadStartingEventArgs)
			MyBase.New(A_0, A_1)
			Me.O.o0_oo. = A_2
		End Sub

		' Token: 0x17000237 RID: 567
		' (get) Token: 0x06000D40 RID: 3392 RVA: 0x0005F007 File Offset: 0x0005D207
		' (set) Token: 0x06000D41 RID: 3393 RVA: 0x0005F014 File Offset: 0x0005D214
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.O.o0_oo..Cancel
			End Get
			Set(value As Boolean)
				Me.O.o0_oo..Cancel = value
			End Set
		End Property

		' Token: 0x17000238 RID: 568
		' (get) Token: 0x06000D42 RID: 3394 RVA: 0x0005F022 File Offset: 0x0005D222
		' (set) Token: 0x06000D43 RID: 3395 RVA: 0x0005F02F File Offset: 0x0005D22F
		Public Property Handled As Boolean
			Get
				Return Me.O.o0_oo..Handled
			End Get
			Set(value As Boolean)
				Me.O.o0_oo..Handled = True
			End Set
		End Property

		' Token: 0x17000239 RID: 569
		' (get) Token: 0x06000D44 RID: 3396 RVA: 0x0005F03D File Offset: 0x0005D23D
		' (set) Token: 0x06000D45 RID: 3397 RVA: 0x0005F04A File Offset: 0x0005D24A
		Public Property ResultFilePath As String
			Get
				Return Me.O.o0_oo..ResultFilePath
			End Get
			Set(value As String)
				Me.O.o0_oo..ResultFilePath = value
			End Set
		End Property

		' Token: 0x1700023A RID: 570
		' (get) Token: 0x06000D46 RID: 3398 RVA: 0x0005F058 File Offset: 0x0005D258
		Public ReadOnly Property DownloadOperation As CoreWebView2DownloadOperation
			Get
				Return Me.O.o0_oo..DownloadOperation
			End Get
		End Property

		' Token: 0x1700023B RID: 571
		' (get) Token: 0x06000D47 RID: 3399 RVA: 0x0005F065 File Offset: 0x0005D265
		Public ReadOnly Property Uri As String
			Get
				Return Me.O.o0_oo..DownloadOperation.Uri
			End Get
		End Property

		' Token: 0x1700023C RID: 572
		' (get) Token: 0x06000D48 RID: 3400 RVA: 0x0005F078 File Offset: 0x0005D278
		Public ReadOnly Property TotalBytesToReceive As ULong
			Get
				Dim result As ULong
				If Me.O.o0_oo..DownloadOperation.TotalBytesToReceive IsNot Nothing Then
					result = Me.O.o0_oo..DownloadOperation.TotalBytesToReceive.Value
				Else
					result = ULong.MaxValue
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700023D RID: 573
		' (get) Token: 0x06000D49 RID: 3401 RVA: 0x0005F0BE File Offset: 0x0005D2BE
		Public ReadOnly Property MimeType As String
			Get
				Return Me.O.o0_oo..DownloadOperation.MimeType
			End Get
		End Property

		' Token: 0x06000D4A RID: 3402 RVA: 0x0005F0D0 File Offset: 0x0005D2D0
		Public Function GetDeferral() As CoreWebView2Deferral
			Return Me.O.o0_oo..GetDeferral()
		End Function

		' Token: 0x04000519 RID: 1305
		Private <<EMPTY_NAME>> As CoreWebView2DownloadStartingEventArgs
	End Class
End Namespace
