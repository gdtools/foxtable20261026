Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004B9 RID: 1209
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class DataReceivedEventArgs
		' Token: 0x06004E61 RID: 20065 RVA: 0x00208411 File Offset: 0x00206611
		Public Sub New(A_0 As Port)
			Me.oo._Oo0. = A_0
		End Sub

		' Token: 0x170011A8 RID: 4520
		' (get) Token: 0x06004E62 RID: 20066 RVA: 0x00208420 File Offset: 0x00206620
		Public ReadOnly Property Port As Port
			Get
				Return Me.oo._Oo0.
			End Get
		End Property

		' Token: 0x04002071 RID: 8305
		Private <<EMPTY_NAME>> As Port
	End Class
End Namespace
