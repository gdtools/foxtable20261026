Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000F6 RID: 246
	Public Class InitializationCompletedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000D54 RID: 3412 RVA: 0x0005F180 File Offset: 0x0005D380
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2InitializationCompletedEventArgs)
			MyBase.New(A_0, A_1)
			Me.oO._O_0oO__0. = A_2
		End Sub

		' Token: 0x17000246 RID: 582
		' (get) Token: 0x06000D55 RID: 3413 RVA: 0x0005F191 File Offset: 0x0005D391
		Public ReadOnly Property IsSuccess As Boolean
			Get
				Return Me.oO._O_0oO__0..IsSuccess
			End Get
		End Property

		' Token: 0x17000247 RID: 583
		' (get) Token: 0x06000D56 RID: 3414 RVA: 0x0005F19E File Offset: 0x0005D39E
		Public ReadOnly Property InitializationException As Exception
			Get
				Return Me.oO._O_0oO__0..InitializationException
			End Get
		End Property

		' Token: 0x0400051B RID: 1307
		Private <<EMPTY_NAME>> As CoreWebView2InitializationCompletedEventArgs
	End Class
End Namespace
