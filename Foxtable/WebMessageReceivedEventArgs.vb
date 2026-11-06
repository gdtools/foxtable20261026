Imports System
Imports System.Collections.Generic
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000126 RID: 294
	Public Class WebMessageReceivedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000E52 RID: 3666 RVA: 0x000615F2 File Offset: 0x0005F7F2
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2WebMessageReceivedEventArgs)
			MyBase.New(A_0, A_1)
			Me.o.oOoO___o__oO. = A_2
		End Sub

		' Token: 0x17000283 RID: 643
		' (get) Token: 0x06000E53 RID: 3667 RVA: 0x00061603 File Offset: 0x0005F803
		Public ReadOnly Property Source As String
			Get
				Return Me.o.oOoO___o__oO..Source
			End Get
		End Property

		' Token: 0x17000284 RID: 644
		' (get) Token: 0x06000E54 RID: 3668 RVA: 0x00061610 File Offset: 0x0005F810
		Public ReadOnly Property WebMessageAsJson As String
			Get
				Return Me.o.oOoO___o__oO..WebMessageAsJson
			End Get
		End Property

		' Token: 0x17000285 RID: 645
		' (get) Token: 0x06000E55 RID: 3669 RVA: 0x0006161D File Offset: 0x0005F81D
		Public ReadOnly Property AdditionalObjects As IReadOnlyList(Of Object)
			Get
				Return Me.o.oOoO___o__oO..AdditionalObjects
			End Get
		End Property

		' Token: 0x06000E56 RID: 3670 RVA: 0x0006162A File Offset: 0x0005F82A
		Public Function TryGetWebMessageAsString() As String
			Return Me.o.oOoO___o__oO..TryGetWebMessageAsString()
		End Function

		' Token: 0x04000591 RID: 1425
		Private <<EMPTY_NAME>> As CoreWebView2WebMessageReceivedEventArgs
	End Class
End Namespace
