Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000094 RID: 148
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class MouseHoverCellEventArgs
		Inherits RowColEventArgs

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x0600057E RID: 1406 RVA: 0x0001D405 File Offset: 0x0001B605
		' (set) Token: 0x0600057F RID: 1407 RVA: 0x0001D40D File Offset: 0x0001B60D
		Public Property Hovering As Boolean

		' Token: 0x06000580 RID: 1408 RVA: 0x0001D416 File Offset: 0x0001B616
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As RecordGrid, A_4 As Boolean)
			MyBase.New(A_0, A_1, A_2, A_3)
			Me.Hovering = A_4
		End Sub

		' Token: 0x04000140 RID: 320
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
