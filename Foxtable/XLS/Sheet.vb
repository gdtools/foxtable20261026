Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004E7 RID: 1255
	Public Class Sheet
		' Token: 0x0600506E RID: 20590 RVA: 0x0021889C File Offset: 0x00216A9C
		Friend Sub New(A_0 As XLSheet)
			Me.Ooo_O__.0. = A_0
			Me.Ooo_O__.0. = New PrintSetting(A_0.PrintSettings)
		End Sub

		' Token: 0x1700122B RID: 4651
		' (get) Token: 0x0600506F RID: 20591 RVA: 0x002188BC File Offset: 0x00216ABC
		<oO0oooo("1312")>
		Public ReadOnly Property PrintSetting As PrintSetting
			Get
				Return Me.Ooo_O__.0.
			End Get
		End Property

		' Token: 0x1700122C RID: 4652
		' (get) Token: 0x06005070 RID: 20592 RVA: 0x002188C4 File Offset: 0x00216AC4
		' (set) Token: 0x06005071 RID: 20593 RVA: 0x002188D7 File Offset: 0x00216AD7
		<oO0oooo("1152")>
		Public Property DefaultColumnWidth As Integer
			Get
				Return C1XLBook.TwipsToPixels(CDbl(Me.Ooo_O__.0..DefaultColumnWidth))
			End Get
			Set(value As Integer)
				Me.Ooo_O__.0..DefaultColumnWidth = C1XLBook.PixelsToTwips(CDbl(value))
			End Set
		End Property

		' Token: 0x1700122D RID: 4653
		' (get) Token: 0x06005072 RID: 20594 RVA: 0x002188EB File Offset: 0x00216AEB
		' (set) Token: 0x06005073 RID: 20595 RVA: 0x002188FE File Offset: 0x00216AFE
		<oO0oooo("1152")>
		Public Property DefaultRowHeight As Integer
			Get
				Return C1XLBook.TwipsToPixels(CDbl(Me.Ooo_O__.0..DefaultRowHeight))
			End Get
			Set(value As Integer)
				Me.Ooo_O__.0..DefaultRowHeight = C1XLBook.PixelsToTwips(CDbl(value))
			End Set
		End Property

		' Token: 0x1700122E RID: 4654
		' (get) Token: 0x06005074 RID: 20596 RVA: 0x00218912 File Offset: 0x00216B12
		' (set) Token: 0x06005075 RID: 20597 RVA: 0x0021891F File Offset: 0x00216B1F
		<oO0oooo("1152")>
		Public Property GridColor As Color
			Get
				Return Me.Ooo_O__.0..GridColor
			End Get
			Set(value As Color)
				Me.Ooo_O__.0..GridColor = value
			End Set
		End Property

		' Token: 0x1700122F RID: 4655
		' (get) Token: 0x06005076 RID: 20598 RVA: 0x0021892D File Offset: 0x00216B2D
		' (set) Token: 0x06005077 RID: 20599 RVA: 0x0021893A File Offset: 0x00216B3A
		<oO0oooo("1152")>
		Public Property ShowGridLines As Boolean
			Get
				Return Me.Ooo_O__.0..ShowGridLines
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..ShowGridLines = value
			End Set
		End Property

		' Token: 0x17001230 RID: 4656
		' (get) Token: 0x06005078 RID: 20600 RVA: 0x00218948 File Offset: 0x00216B48
		' (set) Token: 0x06005079 RID: 20601 RVA: 0x00218955 File Offset: 0x00216B55
		<oO0oooo("1152")>
		Public Property ShowHeaders As Boolean
			Get
				Return Me.Ooo_O__.0..ShowHeaders
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..ShowHeaders = value
			End Set
		End Property

		' Token: 0x17001231 RID: 4657
		' (get) Token: 0x0600507A RID: 20602 RVA: 0x00218963 File Offset: 0x00216B63
		' (set) Token: 0x0600507B RID: 20603 RVA: 0x00218970 File Offset: 0x00216B70
		<oO0oooo("1152")>
		Public Property Visible As Boolean
			Get
				Return Me.Ooo_O__.0..Visible
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..Visible = True
			End Set
		End Property

		' Token: 0x17001232 RID: 4658
		' (get) Token: 0x0600507C RID: 20604 RVA: 0x0021897E File Offset: 0x00216B7E
		' (set) Token: 0x0600507D RID: 20605 RVA: 0x0021898B File Offset: 0x00216B8B
		<oO0oooo("1152")>
		Public Property Locked As Boolean
			Get
				Return Me.Ooo_O__.0..Locked
			End Get
			Set(value As Boolean)
				Me.Ooo_O__.0..Locked = True
			End Set
		End Property

		' Token: 0x17001233 RID: 4659
		' (get) Token: 0x0600507E RID: 20606 RVA: 0x00218999 File Offset: 0x00216B99
		Public ReadOnly Property Rows As RowCollection
			Get
				If Me.a Is Nothing Then
					Me.a = New RowCollection(Me.Ooo_O__.0..Rows)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17001234 RID: 4660
		' (get) Token: 0x0600507F RID: 20607 RVA: 0x002189BF File Offset: 0x00216BBF
		Public ReadOnly Property Cols As ColColection
			Get
				If Me.a Is Nothing Then
					Me.a = New ColColection(Me.Ooo_O__.0..Columns)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17001235 RID: 4661
		<EditorBrowsable(EditorBrowsableState.Always)>
		Public ReadOnly Default Property Item(Row As Integer, Col As Integer) As Cell
			Get
				Return New Cell(Me.Ooo_O__.0., Row, Col)
			End Get
		End Property

		' Token: 0x06005081 RID: 20609 RVA: 0x002189F4 File Offset: 0x00216BF4
		<oO0oooo("1153")>
		Public Sub MergeCell(RowFrom As Integer, ColFrom As Integer, RowCount As Integer, ColCount As Integer)
			Me.Ooo_O__.0..MergedCells.Add(RowFrom, ColFrom, RowCount, ColCount)
		End Sub

		' Token: 0x06005082 RID: 20610 RVA: 0x00218A0C File Offset: 0x00216C0C
		Public Sub ClearMergedCells()
			Me.Ooo_O__.0..MergedCells.Clear()
		End Sub

		' Token: 0x17001236 RID: 4662
		' (get) Token: 0x06005083 RID: 20611 RVA: 0x00218A1E File Offset: 0x00216C1E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property PrintSettings As XLPrintSettings
			Get
				Return Me.Ooo_O__.0..PrintSettings
			End Get
		End Property

		' Token: 0x17001237 RID: 4663
		' (get) Token: 0x06005084 RID: 20612 RVA: 0x00218A2B File Offset: 0x00216C2B
		' (set) Token: 0x06005085 RID: 20613 RVA: 0x00218A38 File Offset: 0x00216C38
		Public Property Name As String
			Get
				Return Me.Ooo_O__.0..Name
			End Get
			Set(value As String)
				Me.Ooo_O__.0..Name = value
			End Set
		End Property

		' Token: 0x0400219F RID: 8607
		Friend <<EMPTY_NAME>> As XLSheet

		' Token: 0x040021A0 RID: 8608
		Private <<EMPTY_NAME>> As PrintSetting

		' Token: 0x040021A1 RID: 8609
		Private a As RowCollection

		' Token: 0x040021A2 RID: 8610
		Private a As ColColection
	End Class
End Namespace
