Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x020000E5 RID: 229
	Public Class ContextMenuRequestedEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000CBD RID: 3261 RVA: 0x0005CA02 File Offset: 0x0005AC02
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2ContextMenuRequestedEventArgs)
			MyBase.New(A_0, A_1)
			Me.O.OOO0000_0. = A_2
			Me.O.OOO0000_0. = A_0
		End Sub

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x06000CBE RID: 3262 RVA: 0x0005CA1A File Offset: 0x0005AC1A
		Public ReadOnly Property ContextMenuTarget As CoreWebView2ContextMenuTarget
			Get
				Return Me.O.OOO0000_0..ContextMenuTarget
			End Get
		End Property

		' Token: 0x06000CBF RID: 3263 RVA: 0x0005CA28 File Offset: 0x0005AC28
		Public Function GetElementInfo() As Object
			Return Me.O.OOO0000_0..GetElementInfoFromPoint(Me.Location.X, Me.Location.Y)
		End Function

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0005CA5C File Offset: 0x0005AC5C
		' (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0005CA69 File Offset: 0x0005AC69
		Public Property Handled As Boolean
			Get
				Return Me.O.OOO0000_0..Handled
			End Get
			Set(value As Boolean)
				Me.O.OOO0000_0..Handled = value
			End Set
		End Property

		' Token: 0x17000219 RID: 537
		' (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0005CA77 File Offset: 0x0005AC77
		Public ReadOnly Property Location As Point
			Get
				Return Me.O.OOO0000_0..Location
			End Get
		End Property

		' Token: 0x1700021A RID: 538
		' (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0005CA84 File Offset: 0x0005AC84
		Public ReadOnly Property MenuItems As IList(Of CoreWebView2ContextMenuItem)
			Get
				Return Me.O.OOO0000_0..MenuItems
			End Get
		End Property

		' Token: 0x1700021B RID: 539
		' (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0005CA91 File Offset: 0x0005AC91
		' (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0005CA9E File Offset: 0x0005AC9E
		Public Property SelectedCommandId As Integer
			Get
				Return Me.O.OOO0000_0..SelectedCommandId
			End Get
			Set(value As Integer)
				Me.O.OOO0000_0..SelectedCommandId = value
			End Set
		End Property

		' Token: 0x06000CC6 RID: 3270 RVA: 0x0005CAAC File Offset: 0x0005ACAC
		Public Function GetDeferral() As CoreWebView2Deferral
			Return Me.O.OOO0000_0..GetDeferral()
		End Function

		' Token: 0x040004E5 RID: 1253
		Private <<EMPTY_NAME>> As CoreWebView2ContextMenuRequestedEventArgs

		' Token: 0x040004E6 RID: 1254
		Private <<EMPTY_NAME>> As WebViewer
	End Class
End Namespace
