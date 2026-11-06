Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x02000499 RID: 1177
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonButtonEventArgs
		' Token: 0x06004D6B RID: 19819 RVA: 0x002019DA File Offset: 0x001FFBDA
		Public Sub New(A_0 As Button)
			Me.o0o__0.OO0O. = A_0
		End Sub

		' Token: 0x1700118E RID: 4494
		' (get) Token: 0x06004D6C RID: 19820 RVA: 0x002019E9 File Offset: 0x001FFBE9
		Public ReadOnly Property Button As Button
			Get
				Return Me.o0o__0.OO0O.
			End Get
		End Property

		' Token: 0x04002001 RID: 8193
		Private <<EMPTY_NAME>> As Button
	End Class
End Namespace
