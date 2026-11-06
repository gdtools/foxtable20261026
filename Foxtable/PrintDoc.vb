Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports C1.C1Preview
Imports C1.C1Preview.Export
Imports C1.Win.C1Preview
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200045B RID: 1115
	<oO0oooo("1167")>
	Public Class PrintDoc
		Inherits C1PrintDocument

		' Token: 0x06004A8D RID: 19085 RVA: 0x001F65C4 File Offset: 0x001F47C4
		Public Sub New()
			MyBase.PageAdded += AddressOf Me.Document_PageAdded
			Me.OoO0000.0. = True
			Me.OoO0000.0. = 12
			MyBase.DefaultUnit = 3
			MyBase.ScriptingOptions.ExternalAssemblies.Add(Application.ExecutablePath)
			MyBase.ScriptingOptions.Namespaces.Add("Foxtable")
		End Sub

		' Token: 0x06004A8E RID: 19086 RVA: 0x001F662B File Offset: 0x001F482B
		<oO0oooo("3246")>
		Public Sub Preview()
			Me.Preview(False)
		End Sub

		' Token: 0x06004A8F RID: 19087 RVA: 0x001F6634 File Offset: 0x001F4834
		<oO0oooo("3246")>
		Public Sub Preview(DisablePrintButton As Boolean)
			Me.OoO0000.0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
			Me.OoO0000.0..Oo0._.("准备生成页面...")
			Me.OoO0000.0..Show(Main.OO_O.o.)
			Application.DoEvents()
			Try
				If O_O0OO.O00.00OO000___.() Then
					ooO.O._oO_0O__o__o.(Me)
				End If
				MyBase.Generate()
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Me.OoO0000.0..Close()
			End Try
			If MyBase.Cancel Then
				Me.OoO0000.0..Close()
				Return
			End If
			Me.OoO0000.0..Oo0._.("准备预览...")
			Me.OoO0000.0..Ooo_oo._o.().Enabled = False
			Application.DoEvents()
			Dim c1PrintPreviewDialog As C1PrintPreviewDialog = New C1PrintPreviewDialog()
			c1PrintPreviewDialog.ShowInTaskbar = False
			c1PrintPreviewDialog.PreviewPane.ZoomMode = 0
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = Me.AutoRotate
			c1PrintPreviewDialog.PreviewPane.PrintOptions.CenterPage = False
			c1PrintPreviewDialog.PreviewPane.PrintOptions.PageScaling = 0
			c1PrintPreviewDialog.Text = "打印预览"
			c1PrintPreviewDialog.Icon = a.O_.o_0oo_000_.()
			c1PrintPreviewDialog.Document = Me
			c1PrintPreviewDialog.PreviewPane.PrinterSettings = MyBase.PageLayout.PageSettings.ToPageSettings().PrinterSettings
			c1PrintPreviewDialog.PreviewPane.PrinterSettings.PrinterName = Me.PrinterName
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = Me.AutoRotate
			If Operators.CompareString(Me.PaperSource, "", True) > 0 Then
				Try
					For Each obj As Object In c1PrintPreviewDialog.PreviewPane.PrinterSettings.PaperSources
						Dim paperSource As PaperSource = CType(obj, PaperSource)
						If Operators.CompareString(paperSource.SourceName, Me.PaperSource, True) = 0 Then
							MyBase.PageLayout.PageSettings.PaperSourceKind = paperSource.Kind
							c1PrintPreviewDialog.PreviewPane.PageSettings.PaperSource = paperSource
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			c1PrintPreviewDialog.WindowState = FormWindowState.Maximized
			Application.DoEvents()
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = Me.AutoRotate
			Me.OoO0000.0..Close()
			If DisablePrintButton Then
				c1PrintPreviewDialog.Show()
				c1PrintPreviewDialog.Hide()
				O_O0OO.o00.0.(c1PrintPreviewDialog)
				c1PrintPreviewDialog.ShowDialog()
			Else
				c1PrintPreviewDialog.ShowDialog()
			End If
			Me.OoO0000.0..Dispose()
			Me.OoO0000.0. = Nothing
			c1PrintPreviewDialog.Dispose()
			MyBase.Body.Children.Clear()
			MyBase.Dispose()
			GC.Collect()
		End Sub

		' Token: 0x06004A90 RID: 19088 RVA: 0x001F68D4 File Offset: 0x001F4AD4
		Public Sub Print()
			Me.OoO0000.0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
			Me.OoO0000.0..Oo0._.("准备生成页面...")
			Me.OoO0000.0..Show(Main.OO_O.o.)
			Application.DoEvents()
			If O_O0OO.O00.00OO000___.() Then
				ooO.O._oO_0O__o__o.(Me)
			End If
			MyBase.Generate()
			If MyBase.Cancel Then
				Me.OoO0000.0..Close()
				Return
			End If
			Me.OoO0000.0..Oo0._.("开始打印...")
			Me.OoO0000.0..Ooo_oo._o.().Enabled = False
			Application.DoEvents()
			Dim printerSettings As PrinterSettings = MyBase.PageLayout.PageSettings.ToPageSettings().PrinterSettings
			Dim c1PrintManager As C1PrintManager = New C1PrintManager()
			c1PrintManager.PrintOptions.AutoRotate = Me.AutoRotate
			c1PrintManager.PrintOptions.CenterPage = False
			c1PrintManager.PrintOptions.PageScaling = 0
			If Operators.CompareString(Me.PrinterName, "", True) > 0 Then
				printerSettings.PrinterName = Me.PrinterName
			End If
			If Operators.CompareString(Me.PaperSource, "", True) > 0 Then
				Try
					For Each obj As Object In printerSettings.PaperSources
						Dim paperSource As PaperSource = CType(obj, PaperSource)
						If Operators.CompareString(paperSource.SourceName, Me.PaperSource, True) = 0 Then
							MyBase.PageLayout.PageSettings.PaperSourceKind = paperSource.Kind
						End If
					Next
					GoTo IL_165
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			c1PrintManager.PrintOptions.AutoPaperSource = True
			IL_165:
			c1PrintManager.Document = Me
			c1PrintManager.Print(printerSettings)
			Me.OoO0000.0..Close()
			Me.OoO0000.0..Dispose()
			Me.OoO0000.0. = Nothing
			MyBase.Body.Children.Clear()
			MyBase.Dispose()
			GC.Collect()
		End Sub

		' Token: 0x06004A91 RID: 19089 RVA: 0x001F6A9C File Offset: 0x001F4C9C
		<oO0oooo("2450")>
		Public Sub SaveHTM(FileName As String, ShowProcess As Boolean)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			If ShowProcess Then
				Me.OoO0000.0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
				Me.OoO0000.0..Text = "生成进度"
				Me.OoO0000.0..Oo0._.("准备生成页面...")
				Me.OoO0000.0..Show(Main.OO_O.o.)
			End If
			Application.DoEvents()
			If O_O0OO.O00.00OO000___.() Then
				ooO.O._oO_0O__o__o.(Me)
			End If
			MyBase.Generate()
			If Not MyBase.Cancel Then
				If ShowProcess Then
					Me.OoO0000.0..Oo0._.("正在保存...")
					Me.OoO0000.0..Ooo_oo._o.().Enabled = False
				End If
				Application.DoEvents()
				New HtmlExporter() With { .Document = Me, .FixedPositioning = True, .ShowOptions = False, .Preview = False }.Export(FileName)
				If ShowProcess Then
					Me.OoO0000.0..Close()
					Me.OoO0000.0..Dispose()
					Me.OoO0000.0. = Nothing
				End If
				MyBase.Body.Children.Clear()
				MyBase.Dispose()
				GC.Collect()
			End If
		End Sub

		' Token: 0x06004A92 RID: 19090 RVA: 0x001F6BBA File Offset: 0x001F4DBA
		<oO0oooo("2450")>
		Public Sub SaveHTM(FileName As String)
			Me.SaveHTM(FileName, False)
		End Sub

		' Token: 0x06004A93 RID: 19091 RVA: 0x001F6BC4 File Offset: 0x001F4DC4
		<oO0oooo("2450")>
		Public Sub SavePDF(FileName As String, ShowProcess As Boolean)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			If ShowProcess Then
				Me.OoO0000.0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
				Me.OoO0000.0..Text = "生成进度"
				Me.OoO0000.0..Oo0._.("准备生成页面...")
				Me.OoO0000.0..Show(Main.OO_O.o.)
			End If
			Application.DoEvents()
			If O_O0OO.O00.00OO000___.() Then
				ooO.O._oO_0O__o__o.(Me)
			End If
			MyBase.Generate()
			If Not MyBase.Cancel Then
				If ShowProcess Then
					Me.OoO0000.0..Oo0._.("正在保存...")
					Me.OoO0000.0..Ooo_oo._o.().Enabled = False
				End If
				Application.DoEvents()
				New PdfExporter() With { .Document = Me, .ShowOptions = False, .Preview = False }.Export(FileName)
				If ShowProcess Then
					Me.OoO0000.0..Close()
					Me.OoO0000.0..Dispose()
					Me.OoO0000.0. = Nothing
				End If
				MyBase.Body.Children.Clear()
				MyBase.Dispose()
				GC.Collect()
			End If
		End Sub

		' Token: 0x06004A94 RID: 19092 RVA: 0x001F6CDB File Offset: 0x001F4EDB
		<oO0oooo("2450")>
		Public Sub SavePDF(FileName As String)
			Me.SavePDF(FileName, True)
		End Sub

		' Token: 0x06004A95 RID: 19093 RVA: 0x001F6CE8 File Offset: 0x001F4EE8
		<oO0oooo("2450")>
		Public Sub SaveImage(FileName As String, Resolution As Single, ShowProcess As Boolean)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			If ShowProcess Then
				Me.OoO0000.0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
				Me.OoO0000.0..Text = "生成进度"
				Me.OoO0000.0..Oo0._.("准备生成页面...")
				Me.OoO0000.0..Show(Main.OO_O.o.)
			End If
			Application.DoEvents()
			If O_O0OO.O00.00OO000___.() Then
				ooO.O._oO_0O__o__o.(Me)
			End If
			MyBase.Generate()
			If Not MyBase.Cancel Then
				If ShowProcess Then
					Me.OoO0000.0..Oo0._.("正在保存...")
					Me.OoO0000.0..Ooo_oo._o.().Enabled = False
				End If
				Application.DoEvents()
				New ImageExporter() With { .ImageFormat = O_O0OO.OoO_00._.(FileName), .Resolution = Resolution, .Document = Me, .ShowOptions = False, .Preview = False }.Export(FileName)
				If ShowProcess Then
					Me.OoO0000.0..Close()
					Me.OoO0000.0..Dispose()
					Me.OoO0000.0. = Nothing
				End If
				MyBase.Body.Children.Clear()
				MyBase.Dispose()
				GC.Collect()
			End If
		End Sub

		' Token: 0x06004A96 RID: 19094 RVA: 0x001F6E12 File Offset: 0x001F5012
		<oO0oooo("2450")>
		Public Sub SaveImage(FileName As String, Optional Resolution As Single = 150F)
			Me.SaveImage(FileName, Resolution, False)
		End Sub

		' Token: 0x06004A97 RID: 19095 RVA: 0x001F6E1D File Offset: 0x001F501D
		<oO0oooo("2450")>
		Public Sub SaveImage(FileName As String, showProcess As Boolean)
			Me.SaveImage(FileName, 150F, showProcess)
		End Sub

		' Token: 0x06004A98 RID: 19096 RVA: 0x001F6E2C File Offset: 0x001F502C
		Private Sub Document_PageAdded(sender As C1PrintDocument, e As PageEventArgs)
			If Me.OoO0000.0. IsNot Nothing Then
				Me.OoO0000.0..Oo0._.("正在生成第" + Conversions.ToString(MyBase.Pages.Count) + "页...")
				Application.DoEvents()
				If Me.OoO0000.0..Ooo_oo._o.() Then
					MyBase.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x1700108C RID: 4236
		' (get) Token: 0x06004A99 RID: 19097 RVA: 0x001F6E84 File Offset: 0x001F5084
		' (set) Token: 0x06004A9A RID: 19098 RVA: 0x001F6E8C File Offset: 0x001F508C
		<oO0oooo("1588")>
		Public Property PrinterName As String
			Get
				Return Me.OoO0000.0.
			End Get
			Set(value As String)
				Try
					Dim enumerator As List(Of String).Enumerator = OO_00oOO.InstalledPrinters.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current, value, True) = 0 Then
							Me.OoO0000.0. = value
						End If
					End While
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End Set
		End Property

		' Token: 0x1700108D RID: 4237
		' (get) Token: 0x06004A9B RID: 19099 RVA: 0x001F6EE8 File Offset: 0x001F50E8
		' (set) Token: 0x06004A9C RID: 19100 RVA: 0x001F6EF0 File Offset: 0x001F50F0
		<oO0oooo("1589")>
		Public Property AutoRotate As Boolean
			Get
				Return Me.OoO0000.0.
			End Get
			Set(value As Boolean)
				Me.OoO0000.0. = value
			End Set
		End Property

		' Token: 0x1700108E RID: 4238
		' (get) Token: 0x06004A9D RID: 19101 RVA: 0x001F6EF9 File Offset: 0x001F50F9
		<oO0oooo("1188")>
		Public ReadOnly Property PageSetting As C1PageSettings
			Get
				Return MyBase.PageLayout.PageSettings
			End Get
		End Property

		' Token: 0x1700108F RID: 4239
		' (get) Token: 0x06004A9E RID: 19102 RVA: 0x001F6F06 File Offset: 0x001F5106
		' (set) Token: 0x06004A9F RID: 19103 RVA: 0x001F6F13 File Offset: 0x001F5113
		<oO0oooo("1197")>
		Public Property PageHeader As RenderObject
			Get
				Return MyBase.PageLayout.PageHeader
			End Get
			Set(value As RenderObject)
				MyBase.PageLayout.PageHeader = value
			End Set
		End Property

		' Token: 0x17001090 RID: 4240
		' (get) Token: 0x06004AA0 RID: 19104 RVA: 0x001F6F21 File Offset: 0x001F5121
		' (set) Token: 0x06004AA1 RID: 19105 RVA: 0x001F6F2E File Offset: 0x001F512E
		<oO0oooo("1197")>
		Public Property PageFooter As RenderObject
			Get
				Return MyBase.PageLayout.PageFooter
			End Get
			Set(value As RenderObject)
				MyBase.PageLayout.PageFooter = value
			End Set
		End Property

		' Token: 0x17001091 RID: 4241
		' (get) Token: 0x06004AA2 RID: 19106 RVA: 0x001F6F3C File Offset: 0x001F513C
		' (set) Token: 0x06004AA3 RID: 19107 RVA: 0x001F6F49 File Offset: 0x001F5149
		<oO0oooo("1198")>
		Public Property WaterMark As RenderObject
			Get
				Return MyBase.PageLayout.Watermark
			End Get
			Set(value As RenderObject)
				MyBase.PageLayout.Watermark = value
			End Set
		End Property

		' Token: 0x17001092 RID: 4242
		' (get) Token: 0x06004AA4 RID: 19108 RVA: 0x001F6F57 File Offset: 0x001F5157
		' (set) Token: 0x06004AA5 RID: 19109 RVA: 0x001F6F60 File Offset: 0x001F5160
		Public Property PaperSource As String
			Get
				Return Me.oo00.0.
			End Get
			Set(value As String)
				Dim printerSettings As PrinterSettings = New PrinterSettings()
				If Operators.CompareString(Me.PrinterName, "", True) > 0 Then
					printerSettings.PrinterName = Me.PrinterName
				Else
					printerSettings.PrinterName = MyBase.PageLayout.PageSettings.ToPageSettings().PrinterSettings.PrinterName
				End If
				Try
					Dim enumerator As IEnumerator = printerSettings.PaperSources.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(CType(enumerator.Current, PaperSource).SourceName, value, True) = 0 Then
							Me.oo00.0. = value
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x17001093 RID: 4243
		' (get) Token: 0x06004AA6 RID: 19110 RVA: 0x001F7014 File Offset: 0x001F5214
		<oO0oooo("1193")>
		Public ReadOnly Property Columns As PageColumnDefCollection
			Get
				Return MyBase.PageLayout.Columns
			End Get
		End Property

		' Token: 0x04001E9E RID: 7838
		Private <<EMPTY_NAME>> As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000

		' Token: 0x04001E9F RID: 7839
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EA0 RID: 7840
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EA1 RID: 7841
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001EA2 RID: 7842
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
