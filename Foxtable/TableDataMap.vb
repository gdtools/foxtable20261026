Imports System
Imports System.Collections
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000316 RID: 790
	<oO0oooo("2653")>
	<ComVisible(True)>
	Public Class TableDataMap
		' Token: 0x17000A24 RID: 2596
		' (get) Token: 0x06002AF6 RID: 10998 RVA: 0x0012D404 File Offset: 0x0012B604
		' (set) Token: 0x06002AF7 RID: 10999 RVA: 0x0012D40C File Offset: 0x0012B60C
		Public Property DataTable As String
			Get
				Return Me.o0O0Oo.OoO_.
			End Get
			Set(value As String)
				Me.o0O0Oo.OoO_. = value
			End Set
		End Property

		' Token: 0x17000A25 RID: 2597
		' (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0012D415 File Offset: 0x0012B615
		' (set) Token: 0x06002AF9 RID: 11001 RVA: 0x0012D41D File Offset: 0x0012B61D
		Public Property ValueCol As String
			Get
				Return Me.O0o.OOo.
			End Get
			Set(value As String)
				Me.O0o.OOo. = value
			End Set
		End Property

		' Token: 0x17000A26 RID: 2598
		' (get) Token: 0x06002AFA RID: 11002 RVA: 0x0012D426 File Offset: 0x0012B626
		' (set) Token: 0x06002AFB RID: 11003 RVA: 0x0012D42E File Offset: 0x0012B62E
		Public Property DisplayCol As String
			Get
				Return Me.O_oOo._o.
			End Get
			Set(value As String)
				Me.O_oOo._o. = value
			End Set
		End Property

		' Token: 0x17000A27 RID: 2599
		' (get) Token: 0x06002AFC RID: 11004 RVA: 0x0012D437 File Offset: 0x0012B637
		' (set) Token: 0x06002AFD RID: 11005 RVA: 0x0012D43F File Offset: 0x0012B63F
		Public Property ListCols As String
			Get
				Return Me.oo_.0__O.
			End Get
			Set(value As String)
				Me.oo_.0__O. = value
			End Set
		End Property

		' Token: 0x17000A28 RID: 2600
		' (get) Token: 0x06002AFE RID: 11006 RVA: 0x0012D448 File Offset: 0x0012B648
		' (set) Token: 0x06002AFF RID: 11007 RVA: 0x0012D450 File Offset: 0x0012B650
		Public Property Filter As String
			Get
				Return Me.O__.o_O0o.
			End Get
			Set(value As String)
				Me.O__.o_O0o. = value
			End Set
		End Property

		' Token: 0x17000A29 RID: 2601
		' (get) Token: 0x06002B00 RID: 11008 RVA: 0x0012D459 File Offset: 0x0012B659
		' (set) Token: 0x06002B01 RID: 11009 RVA: 0x0012D461 File Offset: 0x0012B661
		Public Property Sort As String
			Get
				Return Me.O0O_._O.
			End Get
			Set(value As String)
				Me.O0O_._O. = value
			End Set
		End Property

		' Token: 0x06002B02 RID: 11010 RVA: 0x0012D46A File Offset: 0x0012B66A
		Public Function CreateDataMap() As IDictionary
			Return Oo00.OO.0O0o.(Me.DataTable, Me.ListCols, Me.ValueCol, Me.DisplayCol, Me.Filter, Me.Sort)
		End Function

		' Token: 0x0400116C RID: 4460
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400116D RID: 4461
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400116E RID: 4462
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400116F RID: 4463
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001170 RID: 4464
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001171 RID: 4465
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
