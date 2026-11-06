Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x02000498 RID: 1176
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonEventArgs
		' Token: 0x06004D69 RID: 19817 RVA: 0x002019BE File Offset: 0x001FFBBE
		Public Sub New(A_0 As Object)
			Me.OO_._O0. = RuntimeHelpers.GetObjectValue(A_0)
		End Sub

		' Token: 0x1700118D RID: 4493
		' (get) Token: 0x06004D6A RID: 19818 RVA: 0x002019D2 File Offset: 0x001FFBD2
		Public ReadOnly Property Sender As Object
			Get
				Return Me.OO_._O0.
			End Get
		End Property

		' Token: 0x04002000 RID: 8192
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
