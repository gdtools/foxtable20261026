Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.C1Pdf
Imports C1.Win.C1Document
Imports C1.Win.C1Document.Export
Imports C1.Win.FlexViewer
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000455 RID: 1109
	<ComVisible(True)>
	Public Class PDFCreator
		Inherits C1PdfDocument

		' Token: 0x06004A5D RID: 19037 RVA: 0x001F54AE File Offset: 0x001F36AE
		Public Sub New()
			MyBase.Security.AllowPrint = True
		End Sub

		' Token: 0x06004A5E RID: 19038 RVA: 0x001F54C4 File Offset: 0x001F36C4
		Public Sub Show()
			Dim c1PdfDocumentSource As C1PdfDocumentSource = New C1PdfDocumentSource()
			Dim memoryStream As MemoryStream = New MemoryStream()
			MyBase.Save(memoryStream)
			c1PdfDocumentSource.LoadFromStream(memoryStream)
			memoryStream.Close()
			memoryStream.Dispose()
			Dim c1FlexViewerDialog As C1FlexViewerDialog = New C1FlexViewerDialog()
			c1FlexViewerDialog.DocumentSource = c1PdfDocumentSource
			If Operators.CompareString(Me.PrintJobName, "", True) > 0 Then
				c1FlexViewerDialog.PrintJobName = Me.PrintJobName
			End If
			c1FlexViewerDialog.ShowDialog()
		End Sub

		' Token: 0x06004A5F RID: 19039 RVA: 0x001F552C File Offset: 0x001F372C
		Public Sub Print()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1PdfDocumentSource As C1PdfDocumentSource = New C1PdfDocumentSource()
				IL_0F:
				num2 = 3
				Dim memoryStream As MemoryStream = New MemoryStream()
				IL_18:
				num2 = 4
				MyBase.Save(memoryStream)
				IL_22:
				num2 = 5
				c1PdfDocumentSource.LoadFromStream(memoryStream)
				IL_2C:
				num2 = 6
				memoryStream.Close()
				IL_35:
				num2 = 7
				memoryStream.Dispose()
				IL_3E:
				num2 = 8
				Dim c1FlexViewerDialog As C1FlexViewerDialog = New C1FlexViewerDialog()
				IL_47:
				num2 = 9
				c1FlexViewerDialog.DocumentSource = c1PdfDocumentSource
				IL_52:
				num2 = 10
				c1FlexViewerDialog.WindowState = FormWindowState.Minimized
				IL_5D:
				num2 = 11
				c1FlexViewerDialog.ShowInTaskbar = False
				IL_68:
				num2 = 12
				If Operators.CompareString(Me.PrintJobName, "", True) <= 0 Then
					GoTo IL_8F
				End If
				IL_7F:
				num2 = 13
				c1FlexViewerDialog.PrintJobName = Me.PrintJobName
				IL_8F:
				num2 = 14
				c1FlexViewerDialog.Show()
				IL_99:
				num2 = 15
				c1FlexViewerDialog.Hide()
				IL_A3:
				num2 = 16
				c1FlexViewerDialog.Print()
				IL_AE:
				num2 = 17
				c1FlexViewerDialog.Close()
				IL_B8:
				num2 = 18
				c1FlexViewerDialog.Dispose()
				IL_C2:
				GoTo IL_160
				IL_C7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_121:
				GoTo IL_155
				IL_123:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_133:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_123
			End Try
			IL_155:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_160:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17001086 RID: 4230
		' (get) Token: 0x06004A60 RID: 19040 RVA: 0x001F56C0 File Offset: 0x001F38C0
		' (set) Token: 0x06004A61 RID: 19041 RVA: 0x001F56C8 File Offset: 0x001F38C8
		Public Property PrintJobName As String
			Get
				Return Me.O_0o0.OoO_o.
			End Get
			Set(value As String)
				Me.O_0o0.OoO_o. = value
			End Set
		End Property

		' Token: 0x06004A62 RID: 19042 RVA: 0x001F56D4 File Offset: 0x001F38D4
		Public Sub Save(fileName As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(fileName)
			If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			MyBase.Save(fileName)
		End Sub

		' Token: 0x06004A63 RID: 19043 RVA: 0x001F570C File Offset: 0x001F390C
		Public Sub SaveToHtmL(fileName As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(fileName)
			If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Me.HtmlFilter.FileName = fileName
			Dim c1PdfDocumentSource As C1PdfDocumentSource = New C1PdfDocumentSource()
			Dim memoryStream As MemoryStream = New MemoryStream()
			MyBase.Save(memoryStream)
			c1PdfDocumentSource.LoadFromStream(memoryStream)
			c1PdfDocumentSource.Export(Me.HtmlFilter)
		End Sub

		' Token: 0x17001087 RID: 4231
		' (get) Token: 0x06004A64 RID: 19044 RVA: 0x001F576D File Offset: 0x001F396D
		Public ReadOnly Property HtmlFilter As HtmlFilter
			Get
				If Me.O_0o0.OoO_o. Is Nothing Then
					Me.O_0o0.OoO_o. = New HtmlFilter()
					Me.O_0o0.OoO_o..DocumentInfo = New DocumentInfo()
				End If
				Return Me.O_0o0.OoO_o.
			End Get
		End Property

		' Token: 0x04001E7E RID: 7806
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E7F RID: 7807
		Private <<EMPTY_NAME>> As HtmlFilter
	End Class
End Namespace
