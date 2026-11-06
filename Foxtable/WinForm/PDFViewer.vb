Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports C1.Win.C1Document
Imports C1.Win.FlexViewer

Namespace Foxtable.WinForm
	' Token: 0x020004F6 RID: 1270
	<ComVisible(True)>
	Public Class PDFViewer
		Inherits Control

		' Token: 0x0600515A RID: 20826 RVA: 0x0021A304 File Offset: 0x00218504
		Friend Sub New(A_0 As C1FlexViewer)
			MyBase.New(A_0, ControlTypeEnum.PDFViewer)
			Me.Oo_.0_0O0o00o. = A_0
			Me.Oo_.0_0O0o00o..Ribbon.ConfigToolBar.Visible = False
			Me.Oo_.0_0O0o00o..Ribbon.TopToolBar.Visible = False
			Me.Oo_.0_0O0o00o..Ribbon.BottomToolBar.Visible = False
			Me.Oo_.0_0O0o00o..Ribbon.Qat.Visible = False
			Me.Oo_.0_0O0o00o..ShowOutlines = True
		End Sub

		' Token: 0x17001293 RID: 4755
		' (get) Token: 0x0600515B RID: 20827 RVA: 0x0021A385 File Offset: 0x00218585
		' (set) Token: 0x0600515C RID: 20828 RVA: 0x0021A397 File Offset: 0x00218597
		Public Property RibbonVisible As Boolean
			Get
				Return Me.Oo_.0_0O0o00o..Ribbon.Visible
			End Get
			Set(value As Boolean)
				Me.Oo_.0_0O0o00o..Ribbon.Visible = value
			End Set
		End Property

		' Token: 0x17001294 RID: 4756
		' (get) Token: 0x0600515D RID: 20829 RVA: 0x0021A3AA File Offset: 0x002185AA
		' (set) Token: 0x0600515E RID: 20830 RVA: 0x0021A3BC File Offset: 0x002185BC
		Public Property StatusBarVisible As Boolean
			Get
				Return Me.Oo_.0_0O0o00o..StatusBar.Visible
			End Get
			Set(value As Boolean)
				Me.Oo_.0_0O0o00o..StatusBar.Visible = value
			End Set
		End Property

		' Token: 0x17001295 RID: 4757
		' (get) Token: 0x0600515F RID: 20831 RVA: 0x0021A3CF File Offset: 0x002185CF
		Public ReadOnly Property BaseViewer As C1FlexViewer
			Get
				Return Me.Oo_.0_0O0o00o.
			End Get
		End Property

		' Token: 0x17001296 RID: 4758
		' (get) Token: 0x06005160 RID: 20832 RVA: 0x0021A3D7 File Offset: 0x002185D7
		Public ReadOnly Property RibbonElements As RibbonElements
			Get
				Return Me.Oo_.0_0O0o00o..RibbonElements
			End Get
		End Property

		' Token: 0x17001297 RID: 4759
		' (get) Token: 0x06005161 RID: 20833 RVA: 0x0021A3E4 File Offset: 0x002185E4
		Public ReadOnly Property StatusBarElements As StatusBarElements
			Get
				Return Me.Oo_.0_0O0o00o..StatusBarElements
			End Get
		End Property

		' Token: 0x17001298 RID: 4760
		' (get) Token: 0x06005162 RID: 20834 RVA: 0x0021A3F1 File Offset: 0x002185F1
		Public ReadOnly Property SearchBarElements As SearchBarElements
			Get
				Return Me.Oo_.0_0O0o00o..SearchBarElements
			End Get
		End Property

		' Token: 0x17001299 RID: 4761
		' (get) Token: 0x06005163 RID: 20835 RVA: 0x0021A3FE File Offset: 0x002185FE
		Public ReadOnly Property ContextMenuElements As ContextMenuElements
			Get
				Return Me.Oo_.0_0O0o00o..ContextMenuElements
			End Get
		End Property

		' Token: 0x1700129A RID: 4762
		' (get) Token: 0x06005164 RID: 20836 RVA: 0x0021A40B File Offset: 0x0021860B
		Public ReadOnly Property ToolBarElements As ToolBarElements
			Get
				Return Me.Oo_.0_0O0o00o..ToolBarElements
			End Get
		End Property

		' Token: 0x06005165 RID: 20837 RVA: 0x0021A418 File Offset: 0x00218618
		Public Sub ExecuteAction(action As FlexViewerAction)
			Me.Oo_.0_0O0o00o..ExecuteAction(action)
		End Sub

		' Token: 0x1700129B RID: 4763
		' (get) Token: 0x06005166 RID: 20838 RVA: 0x0021A426 File Offset: 0x00218626
		' (set) Token: 0x06005167 RID: 20839 RVA: 0x0021A430 File Offset: 0x00218630
		Public Property SourceDocument As PDFCreator
			Get
				Return Me.Oo_.0_0O0o00o.
			End Get
			Set(value As PDFCreator)
				Me.Oo_.0_0O0o00o. = value
				Dim c1PdfDocumentSource As C1PdfDocumentSource = New C1PdfDocumentSource()
				Dim memoryStream As MemoryStream = New MemoryStream()
				value.Save(memoryStream)
				c1PdfDocumentSource.LoadFromStream(memoryStream)
				memoryStream.Close()
				memoryStream.Dispose()
				Me.Oo_.0_0O0o00o..DocumentSource = c1PdfDocumentSource
			End Set
		End Property

		' Token: 0x06005168 RID: 20840 RVA: 0x0021A478 File Offset: 0x00218678
		Public Sub LoadFromFile(file As String)
			Dim c1PdfDocumentSource As C1PdfDocumentSource = New C1PdfDocumentSource()
			c1PdfDocumentSource.LoadFromFile(file)
			Me.Oo_.0_0O0o00o..DocumentSource = c1PdfDocumentSource
		End Sub

		' Token: 0x040021B2 RID: 8626
		Private <<EMPTY_NAME>> As C1FlexViewer

		' Token: 0x040021B3 RID: 8627
		Private <<EMPTY_NAME>> As PDFCreator
	End Class
End Namespace
