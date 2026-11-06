Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Xml
Imports C1.Win.C1GanttView

Namespace Foxtable.WinForm
	' Token: 0x020004F3 RID: 1267
	<ComVisible(True)>
	Public Class GanttView
		Inherits Control

		' Token: 0x06005114 RID: 20756 RVA: 0x002198A9 File Offset: 0x00217AA9
		Public Sub New(A_0 As GanttView)
			MyBase.New(A_0, ControlTypeEnum.GanttView)
			Me.o_.ooOO_. = A_0
		End Sub

		' Token: 0x1700126F RID: 4719
		' (set) Token: 0x06005115 RID: 20757 RVA: 0x002198BC File Offset: 0x00217ABC
		<Browsable(False)>
		Public WriteOnly Property Settings As String
			Set(value As String)
				CType(Me.o_.ooOO_., ISupportInitialize).BeginInit()
				Me.o_.ooOO_..BeginUpdate()
				Dim xmlDocument As XmlDocument = New XmlDocument()
				xmlDocument.LoadXml(value)
				CType(MyBase.BaseControl, GanttView).LoadXml(xmlDocument)
				Me.o_.ooOO_..EndUpdate()
				CType(Me.o_.ooOO_., ISupportInitialize).EndInit()
			End Set
		End Property

		' Token: 0x17001270 RID: 4720
		' (get) Token: 0x06005116 RID: 20758 RVA: 0x00219913 File Offset: 0x00217B13
		Public ReadOnly Property GanttView As C1GanttView
			Get
				Return CType(MyBase.BaseControl, C1GanttView)
			End Get
		End Property

		' Token: 0x17001271 RID: 4721
		' (get) Token: 0x06005117 RID: 20759 RVA: 0x00219920 File Offset: 0x00217B20
		' (set) Token: 0x06005118 RID: 20760 RVA: 0x0021992D File Offset: 0x00217B2D
		Public Property GridForeColor As Color
			Get
				Return Me.o_.ooOO_..GridForeColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..GridForeColor = value
			End Set
		End Property

		' Token: 0x17001272 RID: 4722
		' (get) Token: 0x06005119 RID: 20761 RVA: 0x0021993B File Offset: 0x00217B3B
		' (set) Token: 0x0600511A RID: 20762 RVA: 0x00219948 File Offset: 0x00217B48
		Public Property FixedForeColor As Color
			Get
				Return Me.o_.ooOO_..FixedForeColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..FixedForeColor = value
			End Set
		End Property

		' Token: 0x17001273 RID: 4723
		' (get) Token: 0x0600511B RID: 20763 RVA: 0x00219956 File Offset: 0x00217B56
		' (set) Token: 0x0600511C RID: 20764 RVA: 0x00219963 File Offset: 0x00217B63
		Public Property FixedBackColor As Color
			Get
				Return Me.o_.ooOO_..FixedBackColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..FixedBackColor = value
			End Set
		End Property

		' Token: 0x17001274 RID: 4724
		' (get) Token: 0x0600511D RID: 20765 RVA: 0x00219971 File Offset: 0x00217B71
		' (set) Token: 0x0600511E RID: 20766 RVA: 0x0021997E File Offset: 0x00217B7E
		Public Property CellBorderColor As Color
			Get
				Return Me.o_.ooOO_..CellBorderColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..CellBorderColor = value
			End Set
		End Property

		' Token: 0x17001275 RID: 4725
		' (get) Token: 0x0600511F RID: 20767 RVA: 0x0021998C File Offset: 0x00217B8C
		' (set) Token: 0x06005120 RID: 20768 RVA: 0x00219999 File Offset: 0x00217B99
		Public Property FixedCellBorderColor As Color
			Get
				Return Me.o_.ooOO_..FixedCellBorderColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..FixedCellBorderColor = value
			End Set
		End Property

		' Token: 0x17001276 RID: 4726
		' (get) Token: 0x06005121 RID: 20769 RVA: 0x002199A7 File Offset: 0x00217BA7
		' (set) Token: 0x06005122 RID: 20770 RVA: 0x002199B4 File Offset: 0x00217BB4
		Public Property EmptyAreaBackColor As Color
			Get
				Return Me.o_.ooOO_..EmptyAreaBackColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..EmptyAreaBackColor = value
			End Set
		End Property

		' Token: 0x17001277 RID: 4727
		' (get) Token: 0x06005123 RID: 20771 RVA: 0x002199C2 File Offset: 0x00217BC2
		' (set) Token: 0x06005124 RID: 20772 RVA: 0x002199CF File Offset: 0x00217BCF
		Public Property HighlightBackColor As Color
			Get
				Return Me.o_.ooOO_..HighlightBackColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..HighlightBackColor = value
			End Set
		End Property

		' Token: 0x17001278 RID: 4728
		' (get) Token: 0x06005125 RID: 20773 RVA: 0x002199DD File Offset: 0x00217BDD
		' (set) Token: 0x06005126 RID: 20774 RVA: 0x002199EA File Offset: 0x00217BEA
		Public Property HighlightForeColor As Color
			Get
				Return Me.o_.ooOO_..HighlightForeColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..HighlightForeColor = value
			End Set
		End Property

		' Token: 0x17001279 RID: 4729
		' (get) Token: 0x06005127 RID: 20775 RVA: 0x002199F8 File Offset: 0x00217BF8
		' (set) Token: 0x06005128 RID: 20776 RVA: 0x00219A05 File Offset: 0x00217C05
		Public Property ToolbarBackColor As Color
			Get
				Return Me.o_.ooOO_..ToolbarBackColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..ToolbarBackColor = value
			End Set
		End Property

		' Token: 0x1700127A RID: 4730
		' (get) Token: 0x06005129 RID: 20777 RVA: 0x00219A13 File Offset: 0x00217C13
		' (set) Token: 0x0600512A RID: 20778 RVA: 0x00219A20 File Offset: 0x00217C20
		Public Property SplitterColor As Color
			Get
				Return Me.o_.ooOO_..SplitterColor
			End Get
			Set(value As Color)
				Me.o_.ooOO_..SplitterColor = value
			End Set
		End Property

		' Token: 0x040021B0 RID: 8624
		Private <<EMPTY_NAME>> As GanttView
	End Class
End Namespace
