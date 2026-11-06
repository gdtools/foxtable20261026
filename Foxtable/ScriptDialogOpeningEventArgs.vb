Imports System
Imports Foxtable.WinForm
Imports Microsoft.Web.WebView2.Core

Namespace Foxtable
	' Token: 0x02000100 RID: 256
	Public Class ScriptDialogOpeningEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000D87 RID: 3463 RVA: 0x0005F746 File Offset: 0x0005D946
		Public Sub New(A_0 As WebViewer, A_1 As Form, A_2 As CoreWebView2ScriptDialogOpeningEventArgs)
			MyBase.New(A_0, A_1)
			Me.o.0o00oo_OOo. = A_2
			Me.o.0o00oo_OOo. = A_0
		End Sub

		' Token: 0x06000D88 RID: 3464 RVA: 0x0005F75E File Offset: 0x0005D95E
		Public Sub Accept()
			Me.o.0o00oo_OOo..Accept()
		End Sub

		' Token: 0x06000D89 RID: 3465 RVA: 0x0005F76B File Offset: 0x0005D96B
		Public Function GetDeferral() As CoreWebView2Deferral
			Return Me.o.0o00oo_OOo..GetDeferral()
		End Function

		' Token: 0x1700024A RID: 586
		' (get) Token: 0x06000D8A RID: 3466 RVA: 0x0005F778 File Offset: 0x0005D978
		Public ReadOnly Property DefaultText As String
			Get
				Return Me.o.0o00oo_OOo..DefaultText
			End Get
		End Property

		' Token: 0x1700024B RID: 587
		' (get) Token: 0x06000D8B RID: 3467 RVA: 0x0005F785 File Offset: 0x0005D985
		Public ReadOnly Property Kind As CoreWebView2ScriptDialogKind
			Get
				Return Me.o.0o00oo_OOo..Kind
			End Get
		End Property

		' Token: 0x1700024C RID: 588
		' (get) Token: 0x06000D8C RID: 3468 RVA: 0x0005F792 File Offset: 0x0005D992
		Public ReadOnly Property Message As String
			Get
				Return Me.o.0o00oo_OOo..Message
			End Get
		End Property

		' Token: 0x1700024D RID: 589
		' (get) Token: 0x06000D8D RID: 3469 RVA: 0x0005F79F File Offset: 0x0005D99F
		' (set) Token: 0x06000D8E RID: 3470 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		Public Property ResultText As String
			Get
				Return Me.o.0o00oo_OOo..ResultText
			End Get
			Set(value As String)
				Me.o.0o00oo_OOo..ResultText = value
			End Set
		End Property

		' Token: 0x1700024E RID: 590
		' (get) Token: 0x06000D8F RID: 3471 RVA: 0x0005F7BA File Offset: 0x0005D9BA
		Public ReadOnly Property Uri As String
			Get
				Return Me.o.0o00oo_OOo..Uri
			End Get
		End Property

		' Token: 0x0400052D RID: 1325
		Private <<EMPTY_NAME>> As CoreWebView2ScriptDialogOpeningEventArgs

		' Token: 0x0400052E RID: 1326
		Private <<EMPTY_NAME>> As WebViewer
	End Class
End Namespace
