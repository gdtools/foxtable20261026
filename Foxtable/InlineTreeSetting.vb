Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020000A3 RID: 163
	<ComVisible(True)>
	Public Class InlineTreeSetting
		' Token: 0x06000624 RID: 1572 RVA: 0x000208B7 File Offset: 0x0001EAB7
		Public Sub New()
			Me.TreeType = O0_0_0O0___O.OOO.__O_oO_.
			Me.IncludeSub = True
			Me.ExpandTo = 0
			Me.Unique = True
		End Sub

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x06000625 RID: 1573 RVA: 0x000208DB File Offset: 0x0001EADB
		' (set) Token: 0x06000626 RID: 1574 RVA: 0x000208E3 File Offset: 0x0001EAE3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TreeType As O0_0_0O0___O

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x06000627 RID: 1575 RVA: 0x000208EC File Offset: 0x0001EAEC
		' (set) Token: 0x06000628 RID: 1576 RVA: 0x000208F4 File Offset: 0x0001EAF4
		Public Property ParentCol As String

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x06000629 RID: 1577 RVA: 0x000208FD File Offset: 0x0001EAFD
		' (set) Token: 0x0600062A RID: 1578 RVA: 0x00020905 File Offset: 0x0001EB05
		Public Property ChildCol As String

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x0600062B RID: 1579 RVA: 0x0002090E File Offset: 0x0001EB0E
		' (set) Token: 0x0600062C RID: 1580 RVA: 0x00020916 File Offset: 0x0001EB16
		Public Property ValueCol As String

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x0600062D RID: 1581 RVA: 0x0002091F File Offset: 0x0001EB1F
		' (set) Token: 0x0600062E RID: 1582 RVA: 0x00020927 File Offset: 0x0001EB27
		Public Property TextCol As String

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x0600062F RID: 1583 RVA: 0x00020930 File Offset: 0x0001EB30
		' (set) Token: 0x06000630 RID: 1584 RVA: 0x00020938 File Offset: 0x0001EB38
		Public Property IncludeSub As Boolean

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000631 RID: 1585 RVA: 0x00020941 File Offset: 0x0001EB41
		' (set) Token: 0x06000632 RID: 1586 RVA: 0x00020949 File Offset: 0x0001EB49
		Public Property Subtotal As Boolean

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x06000633 RID: 1587 RVA: 0x00020952 File Offset: 0x0001EB52
		' (set) Token: 0x06000634 RID: 1588 RVA: 0x0002095A File Offset: 0x0001EB5A
		Public Property GridTree As Boolean

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x06000635 RID: 1589 RVA: 0x00020963 File Offset: 0x0001EB63
		' (set) Token: 0x06000636 RID: 1590 RVA: 0x0002096B File Offset: 0x0001EB6B
		Public Property TreeCol As String

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x06000637 RID: 1591 RVA: 0x00020974 File Offset: 0x0001EB74
		' (set) Token: 0x06000638 RID: 1592 RVA: 0x0002097C File Offset: 0x0001EB7C
		Public Property ExpandTo As Integer

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x06000639 RID: 1593 RVA: 0x00020985 File Offset: 0x0001EB85
		' (set) Token: 0x0600063A RID: 1594 RVA: 0x0002098D File Offset: 0x0001EB8D
		Public Property AggregateCols As Object()

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x0600063B RID: 1595 RVA: 0x00020996 File Offset: 0x0001EB96
		' (set) Token: 0x0600063C RID: 1596 RVA: 0x0002099E File Offset: 0x0001EB9E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ValueCols As String

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x0600063D RID: 1597 RVA: 0x000209A7 File Offset: 0x0001EBA7
		' (set) Token: 0x0600063E RID: 1598 RVA: 0x000209AF File Offset: 0x0001EBAF
		Public Property Unique As Boolean

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x0600063F RID: 1599 RVA: 0x000209B8 File Offset: 0x0001EBB8
		' (set) Token: 0x06000640 RID: 1600 RVA: 0x000209C0 File Offset: 0x0001EBC0
		Public Property SortCol As String

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x06000641 RID: 1601 RVA: 0x000209C9 File Offset: 0x0001EBC9
		' (set) Token: 0x06000642 RID: 1602 RVA: 0x000209D1 File Offset: 0x0001EBD1
		Public Property SortDesc As Boolean

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000643 RID: 1603 RVA: 0x000209DA File Offset: 0x0001EBDA
		' (set) Token: 0x06000644 RID: 1604 RVA: 0x000209E2 File Offset: 0x0001EBE2
		Public Property UseStyle As Boolean

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x06000645 RID: 1605 RVA: 0x000209EB File Offset: 0x0001EBEB
		' (set) Token: 0x06000646 RID: 1606 RVA: 0x000209F3 File Offset: 0x0001EBF3
		Public Property MergeTotal As Boolean

		' Token: 0x04000191 RID: 401
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O0_0_0O0___O

		' Token: 0x04000192 RID: 402
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000193 RID: 403
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000194 RID: 404
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000195 RID: 405
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000196 RID: 406
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000197 RID: 407
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000198 RID: 408
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000199 RID: 409
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400019A RID: 410
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400019B RID: 411
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x0400019C RID: 412
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400019D RID: 413
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400019E RID: 414
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400019F RID: 415
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001A0 RID: 416
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001A1 RID: 417
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
