Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020000B1 RID: 177
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class NetworkAvailabilityEventArgs
		' Token: 0x06000712 RID: 1810 RVA: 0x000271A8 File Offset: 0x000253A8
		Public Sub New(A_0 As Boolean)
			Me.Oo_oOO_._Oo_o. = A_0
		End Sub

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x06000713 RID: 1811 RVA: 0x000271B7 File Offset: 0x000253B7
		Public ReadOnly Property IsAvailable As Boolean
			Get
				Return Me.Oo_oOO_._Oo_o.
			End Get
		End Property

		' Token: 0x04000203 RID: 515
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
