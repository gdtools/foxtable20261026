Imports System
Imports C1.Win.C1Document
Imports C1.Win.C1Document.Export

Namespace Foxtable
	' Token: 0x02000456 RID: 1110
	Public Class PDFSource
		Inherits C1PdfDocumentSource

		' Token: 0x06004A66 RID: 19046 RVA: 0x001F57A0 File Offset: 0x001F39A0
		Public Sub Save(FileName As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Me.PdfFilter.FileName = FileName
			If Me.O00oO_00O._. IsNot Nothing Then
				Me.PdfFilter.DocumentInfo = Me.O00oO_00O._.
			End If
			MyBase.Export(Me.PdfFilter)
		End Sub

		' Token: 0x06004A67 RID: 19047 RVA: 0x001F5804 File Offset: 0x001F3A04
		Public Sub SaveToHTML(FileName As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Me.HtmlFilter.FileName = FileName
			If Me.O00oO_00O._. IsNot Nothing Then
				Me.HtmlFilter.DocumentInfo = Me.O00oO_00O._.
			End If
			MyBase.Export(Me.HtmlFilter)
		End Sub

		' Token: 0x17001088 RID: 4232
		' (get) Token: 0x06004A68 RID: 19048 RVA: 0x001F5866 File Offset: 0x001F3A66
		Public ReadOnly Property Security As PdfSecurityOptions
			Get
				Return Me.PdfFilter.PdfSecurityOptions
			End Get
		End Property

		' Token: 0x17001089 RID: 4233
		' (get) Token: 0x06004A69 RID: 19049 RVA: 0x001F5873 File Offset: 0x001F3A73
		Public ReadOnly Property DocumentInfo As DocumentInfo
			Get
				If Me.O00oO_00O._. Is Nothing Then
					Me.O00oO_00O._. = New DocumentInfo()
				End If
				Return Me.O00oO_00O._.
			End Get
		End Property

		' Token: 0x1700108A RID: 4234
		' (get) Token: 0x06004A6A RID: 19050 RVA: 0x001F588E File Offset: 0x001F3A8E
		Public ReadOnly Property PdfFilter As PdfFilter
			Get
				If Me.O00oO_00O._. Is Nothing Then
					Me.O00oO_00O._. = New PdfFilter()
				End If
				Return Me.O00oO_00O._.
			End Get
		End Property

		' Token: 0x1700108B RID: 4235
		' (get) Token: 0x06004A6B RID: 19051 RVA: 0x001F58A9 File Offset: 0x001F3AA9
		Public ReadOnly Property HtmlFilter As HtmlFilter
			Get
				If Me.O00oO_00O._. Is Nothing Then
					Me.O00oO_00O._. = New HtmlFilter()
				End If
				Return Me.O00oO_00O._.
			End Get
		End Property

		' Token: 0x04001E80 RID: 7808
		Private <<EMPTY_NAME>> As DocumentInfo

		' Token: 0x04001E81 RID: 7809
		Private <<EMPTY_NAME>> As PdfFilter

		' Token: 0x04001E82 RID: 7810
		Private <<EMPTY_NAME>> As HtmlFilter
	End Class
End Namespace
