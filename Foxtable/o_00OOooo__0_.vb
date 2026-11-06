Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.C1Preview
Imports C1.C1Preview.Export
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Preview
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000453 RID: 1107
	Friend Class o_00OOooo__0_
		' Token: 0x060049D1 RID: 18897 RVA: 0x001F1C67 File Offset: 0x001EFE67
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As C1PrintDocument
			Return Me.oOO_0o_.oOo_o0.
		End Function

		' Token: 0x060049D2 RID: 18898 RVA: 0x001F1C70 File Offset: 0x001EFE70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As C1PrintDocument)
			Dim pageEventHandler As PageEventHandler = AddressOf Me.OoO0000.0.
			Dim c1PrintDocument As C1PrintDocument = Me.oOO_0o_.oOo_o0.
			If c1PrintDocument IsNot Nothing Then
				c1PrintDocument.PageAdded -= pageEventHandler
			End If
			Me.oOO_0o_.oOo_o0. = A_0
			c1PrintDocument = Me.oOO_0o_.oOo_o0.
			If c1PrintDocument IsNot Nothing Then
				c1PrintDocument.PageAdded += pageEventHandler
			End If
		End Sub

		' Token: 0x060049D3 RID: 18899 RVA: 0x001F1CB4 File Offset: 0x001EFEB4
		Friend Sub New(A_0 As PrintInfo, Optional A_1 As Boolean = False)
			Me.O0Oo.Oooo0. = Nothing
			Me.o.o0o__0o0. = 0.0
			Me.OooO.00. = 0.0
			Me.O0.o___. = 0.0
			Me.oOOO0.O_O_o_0o. = 1.0
			Me.O_oo000._. = 0.0
			Me.oOO_0o_.oOo_o0. = 0
			Me.OooO.00. = -1
			Me.o.o0o__0o0. = New List(Of String)()
			Try
				Me.O0Oo.Oooo0. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
				If A_1 Then
					Me.O0Oo.Oooo0..Text = "生成进度"
				End If
				Me.O0Oo.Oooo0..Show(Main.OO_O.o.)
				Application.DoEvents()
				Me.O0Oo.Oooo0. = A_0
				Me.o.o0o__0o0. = A_0.Table.foxGrid
				Me.oOO_0o_.oOo_o0.(New C1PrintDocument())
				Me.oo0.__0Oo.().DefaultUnit = 3
				If Operators.CompareString(Me.O0Oo.Oooo0..WaterMark, "", True) > 0 Then
					Dim image As Image = OO_00oOO.GetImage(Me.O0Oo.Oooo0..WaterMark)
					If image IsNot Nothing Then
						Dim renderImage As RenderImage = New RenderImage(image)
						renderImage.Style.ImageAlign.AlignHorz = 1
						renderImage.Style.ImageAlign.AlignVert = 1
						Me.oo0.__0Oo.().PageLayout.Watermark = renderImage
					End If
				End If
				Me.o.o0o__0o0. = Graphics.FromHwnd(IntPtr.Zero)
				If Me.O0Oo.Oooo0..ExtendMemoRow OrElse Me.O0Oo.Oooo0..WrapMemo Then
					Try
						For Each obj As Object In A_0.Table.DataTable.BaseTable.Columns
							Dim dataColumn As DataColumn = CType(obj, DataColumn)
							If Me.o.o0o__0o0..Cols.Contains(dataColumn.ColumnName) AndAlso Me.o.o0o__0o0..Cols(dataColumn.ColumnName).Visible AndAlso (dataColumn.DataType Is GetType(String) And (dataColumn.MaxLength = -1 Or dataColumn.MaxLength > 255)) Then
								Me.o.o0o__0o0..Add(dataColumn.ColumnName)
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Dim pageSettings As C1PageSettings = Me.oo0.__0Oo.().PageLayout.PageSettings
				pageSettings.PaperKind = Me.o.o0o__0o0..PrintParameters.PrintDocument.DefaultPageSettings.PaperSize.Kind
				pageSettings.Landscape = A_0.LandScape
				If pageSettings.PaperKind = PaperKind.Custom Then
					Me.oo0.__0Oo.().PageLayout.PageSettings.Width = A_0.PaperWidth
					Me.oo0.__0Oo.().PageLayout.PageSettings.Height = A_0.PaperHeight
				End If
				pageSettings.LeftMargin = A_0.LeftMargin
				pageSettings.RightMargin = A_0.RightMargin
				pageSettings.TopMargin = A_0.TopMargin
				pageSettings.BottomMargin = A_0.BottomMargin
				If Operators.CompareString(A_0.PaperSource, "", True) > 0 Then
					Try
						For Each obj2 As Object In pageSettings.PageLayout.PageSettings.ToPageSettings().PrinterSettings.PaperSources
							Dim paperSource As PaperSource = CType(obj2, PaperSource)
							If Operators.CompareString(paperSource.SourceName, A_0.PaperSource, True) = 0 Then
								pageSettings.PaperSourceKind = paperSource.Kind
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				End If
				Me.O0Oo.Oooo0. = New StringFormat()
				Me.O0Oo.Oooo0..Alignment = StringAlignment.Near
				Me.O0Oo.Oooo0..LineAlignment = StringAlignment.Near
				Me.o.o0o__0o0. = Me.o.o0o__0o0..DpiX
				Me.o.OO__0. = CSng(Me.O0Oo.Oooo0..PageSettings.PrinterResolution.X)
				Dim pageSettings2 As C1PageSettings = Me.oo0.__0Oo.().PageLayout.PageSettings
				Me.OooO.00. = pageSettings2.Width.Value - pageSettings2.LeftMargin.Value - pageSettings2.RightMargin.Value
				Me.o.o0o__0o0. = pageSettings2.Height.Value - pageSettings2.TopMargin.Value - pageSettings2.BottomMargin.Value
				Me.O0.o___. = Me.OooO.00. - Utils.ConvertUnits(LineDef.[Default].Width.Value * 2.0, LineDef.[Default].Width.Units, 3, Me.o.OO__0., Me.o.OO__0.)
				Me.O0.o___. = Utils.ConvertUnits(Me.O0.o___., 3, 5, Me.o.OO__0., Me.o.o0o__0o0.)
				Dim color As Color = Me.o.o0o__0o0..Styles.Normal.Border.Color
				Dim style As BorderStyleEnum = Me.o.o0o__0o0..Styles.Normal.Border.Style
				If style = 7 Then
					Me.oOO_0o_.oOo_o0. = New LineDef(LineDef.[Default].Width, color, DashStyle.Dot)
				Else
					Me.oOO_0o_.oOo_o0. = New LineDef(LineDef.[Default].Width, color, DashStyle.Solid)
				End If
				Me.o0000_Ooo.O_.()
				Me.O0Oo.Oooo0..Oo0._.("创建表格中...")
				Application.DoEvents()
				Me.o____._O000.()
				Me.O__0ooo_o._.()
				Me.o0_.oO_O0.()
				Me.O_o.Oo___.()
				Me.O_0O0_o_._0_0.()
				If Not Me.O0Oo.Oooo0..Ooo_oo._o.() Then
					Me.oo0.__0Oo.()
				End If
				If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
					Me.O0Oo.Oooo0..Close()
					Me.O0Oo.Oooo0. = True
				Else
					If Me.O0Oo.Oooo0..RepeatFixedRows AndAlso Me.o.o0o__0o0..Rows.Fixed > 0 Then
						Me.O0Oo.Oooo0..RowGroups(0, Me.o.o0o__0o0..Rows.Fixed).PageHeader = True
					End If
					If Me.O0Oo.Oooo0..PrintFixedCols AndAlso Me.O0Oo.Oooo0..RepeatFixedCols AndAlso Me.o.o0o__0o0..Cols.Fixed > 0 Then
						Me.O0Oo.Oooo0..ColGroups(0, Me.o.o0o__0o0..Cols.Fixed).PageHeader = True
					End If
					Me.oo0.__0Oo.().Body.Children.Add(Me.O0Oo.Oooo0.)
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x060049D4 RID: 18900 RVA: 0x001F2394 File Offset: 0x001F0594
		Friend Sub <<EMPTY_NAME>>()
			If Not Me.O0Oo.Oooo0. Then
				Me.O0Oo.Oooo0..Oo0._.("准备生成页面...")
				Application.DoEvents()
				Me.oo0.__0Oo.().Generate()
				If Not Me.oo0.__0Oo.().Cancel Then
					Me.O0Oo.Oooo0..Oo0._.("准备预览...")
					Me.O0Oo.Oooo0..Ooo_oo._o.().Enabled = False
					Application.DoEvents()
					Dim c1PrintPreviewDialog As C1PrintPreviewDialog = New C1PrintPreviewDialog()
					c1PrintPreviewDialog.PreviewPane.ZoomMode = 0
					c1PrintPreviewDialog.ShowInTaskbar = False
					c1PrintPreviewDialog.Text = "打印预览"
					c1PrintPreviewDialog.Icon = a.O_.o_0oo_000_.()
					c1PrintPreviewDialog.Document = Me.oo0.__0Oo.()
					c1PrintPreviewDialog.WindowState = FormWindowState.Maximized
					Application.DoEvents()
					c1PrintPreviewDialog.PreviewPane.PrinterSettings = Me.O0Oo.Oooo0..PrinterSettings
					Me.O0Oo.Oooo0..Close()
					c1PrintPreviewDialog.ShowDialog()
					Me.oo0.__0Oo.().Body.Children.Clear()
					Me.oo0.__0Oo.().Dispose()
					Me.oOO_0o_.oOo_o0.(Nothing)
					Me.O0Oo.Oooo0..Dispose()
					Me.O0Oo.Oooo0. = Nothing
					c1PrintPreviewDialog.Dispose()
					Me.o.o0o__0o0..Dispose()
					Me.o.o0o__0o0. = Nothing
					GC.Collect()
				End If
			End If
		End Sub

		' Token: 0x060049D5 RID: 18901 RVA: 0x001F24C8 File Offset: 0x001F06C8
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Not Me.O0Oo.Oooo0. Then
				Me.O0Oo.Oooo0..Oo0._.("准备生成页面...")
				Application.DoEvents()
				Me.oo0.__0Oo.().Generate()
				If Not Me.oo0.__0Oo.().Cancel Then
					Me.O0Oo.Oooo0..Oo0._.("正在保存...")
					Me.O0Oo.Oooo0..Ooo_oo._o.().Enabled = False
					Application.DoEvents()
					New PdfExporter() With { .Document = Me.oo0.__0Oo.(), .ShowOptions = False, .Preview = False }.Export(A_0)
					Me.O0Oo.Oooo0..Close()
					Me.oo0.__0Oo.().Body.Children.Clear()
					Me.oo0.__0Oo.().Dispose()
					Me.oOO_0o_.oOo_o0.(Nothing)
					Me.O0Oo.Oooo0..Dispose()
					Me.O0Oo.Oooo0. = Nothing
					Me.o.o0o__0o0..Dispose()
					Me.o.o0o__0o0. = Nothing
					GC.Collect()
				End If
			End If
		End Sub

		' Token: 0x060049D6 RID: 18902 RVA: 0x001F25B8 File Offset: 0x001F07B8
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Not Me.O0Oo.Oooo0. Then
				Me.O0Oo.Oooo0..Oo0._.("准备生成页面...")
				Application.DoEvents()
				Me.oo0.__0Oo.().Generate()
				If Not Me.oo0.__0Oo.().Cancel Then
					Me.O0Oo.Oooo0..Oo0._.("正在保存...")
					Me.O0Oo.Oooo0..Ooo_oo._o.().Enabled = False
					Application.DoEvents()
					New HtmlExporter() With { .Document = Me.oo0.__0Oo.(), .ShowOptions = False, .Preview = False }.Export(A_0)
					Me.O0Oo.Oooo0..Close()
					Me.oo0.__0Oo.().Body.Children.Clear()
					Me.oo0.__0Oo.().Dispose()
					Me.oOO_0o_.oOo_o0.(Nothing)
					Me.O0Oo.Oooo0..Dispose()
					Me.O0Oo.Oooo0. = Nothing
					Me.o.o0o__0o0..Dispose()
					Me.o.o0o__0o0. = Nothing
					GC.Collect()
				End If
			End If
		End Sub

		' Token: 0x060049D7 RID: 18903 RVA: 0x001F26A8 File Offset: 0x001F08A8
		Friend Sub <<EMPTY_NAME>>(A_0 As PrinterSettings)
			If Not Me.O0Oo.Oooo0. Then
				Me.O0Oo.Oooo0..Oo0._.("准备生成页面...")
				Application.DoEvents()
				Me.oo0.__0Oo.().Generate()
				If Not Me.oo0.__0Oo.().Cancel Then
					Me.O0Oo.Oooo0..Close()
					Application.DoEvents()
					Me.oo0.__0Oo.().Print(A_0, True)
					Me.oo0.__0Oo.().Body.Children.Clear()
					Me.oo0.__0Oo.().Dispose()
					Me.oOO_0o_.oOo_o0.(Nothing)
					Me.O0Oo.Oooo0..Dispose()
					Me.O0Oo.Oooo0. = Nothing
					Me.o.o0o__0o0..Dispose()
					Me.o.o0o__0o0. = Nothing
					GC.Collect()
				End If
			End If
		End Sub

		' Token: 0x060049D8 RID: 18904 RVA: 0x001F275B File Offset: 0x001F095B
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.oOO_0o_.oOo_o0.
		End Function

		' Token: 0x060049D9 RID: 18905 RVA: 0x001F2763 File Offset: 0x001F0963
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.oOO_0o_.oOo_o0. = A_0
			If Me.oOO_0o_.oOo_o0. Mod 20 = 0 Then
				Me.O0Oo.Oooo0..Oo0._.("已处理数据" + Conversions.ToString(Me.oOO_0o_.oOo_o0.) + "行...")
				Application.DoEvents()
			End If
		End Sub

		' Token: 0x060049DA RID: 18906 RVA: 0x001F27A1 File Offset: 0x001F09A1
		Public Function <<EMPTY_NAME>>() As RenderTable
			Return Me.O0Oo.Oooo0.
		End Function

		' Token: 0x060049DB RID: 18907 RVA: 0x001F27AC File Offset: 0x001F09AC
		Friend Sub <<EMPTY_NAME>>()
			Me.O0Oo.Oooo0. = New RenderTable(Me.oo0.__0Oo.())
			Me.O0Oo.Oooo0..Height = Unit.Auto
			If Me.O0Oo.Oooo0..FitIntoPage OrElse Me.O0Oo.Oooo0..ExtendLastCol Then
				Me.O0Oo.Oooo0..Width = New Unit("100%parent")
				Me.O0Oo.Oooo0..SplitHorzBehavior = 0
			Else
				Me.O0Oo.Oooo0..Width = Unit.Auto
				Me.O0Oo.Oooo0..SplitHorzBehavior = 1
			End If
			Me.O0Oo.Oooo0..Style.GridLines.All = Me.oOO_0o_.oOo_o0.
			Dim direction As BorderDirEnum = Me.o.o0o__0o0..Styles.Normal.Border.Direction
			If direction <> 1 Then
				If direction = 2 Then
					Me.O0Oo.Oooo0..Style.GridLines.Horz = LineDef.Empty
				End If
			Else
				Me.O0Oo.Oooo0..Style.GridLines.Vert = LineDef.Empty
			End If
			Dim normal As CellStyle = Me.o.o0o__0o0..Styles.Normal
			If(normal.BackColor.IsEmpty OrElse normal.BackColor.Equals(Color.Transparent)) AndAlso Not Me.O0o.__.(Me.o.o0o__0o0..BackColor) Then
				normal.BackColor = Me.o.o0o__0o0..BackColor
			End If
			Me.OoO0000.0.(Me.O0Oo.Oooo0..CellStyle, normal, False)
			Me.OoO0000.0.(Me.O0Oo.Oooo0..Style, normal, False)
			If Me.O0Oo.Oooo0..AdjustFontSize Then
				Me.O0Oo.Oooo0..CellStyle.Font = New Font(normal.Font.Name, CSng((CDbl(normal.Font.Size) / Me.oOOO0.O_O_o_0o.)), normal.Font.Style, normal.Font.Unit)
				Me.O0Oo.Oooo0..Style.Font = New Font(normal.Font.Name, CSng((CDbl(normal.Font.Size) / Me.oOOO0.O_O_o_0o.)), normal.Font.Style, normal.Font.Unit)
			Else
				Me.O0Oo.Oooo0..CellStyle.Font = CType(normal.Font.Clone(), Font)
				Me.O0Oo.Oooo0..Style.Font = CType(normal.Font.Clone(), Font)
			End If
			Me.O0Oo.Oooo0..Style.TextAlignVert = 1
			Me.O0Oo.Oooo0..CellStyle.TextAlignVert = 1
			If Me.o.o0o__0o0..BackgroundImage IsNot Nothing Then
				normal.BackgroundImage = Me.o.o0o__0o0..BackgroundImage
				normal.BackgroundImageLayout = 11
			End If
			Me.O0Oo.Oooo0..CellStyle.Padding.All = "1pt"
		End Sub

		' Token: 0x060049DC RID: 18908 RVA: 0x001F2A84 File Offset: 0x001F0C84
		Private Sub <<EMPTY_NAME>>(A_0 As Style, A_1 As CellStyle, A_2 As Boolean)
			If A_0 IsNot Nothing AndAlso A_1 IsNot Nothing Then
				If Me.O0Oo.Oooo0..CellStyle.TextColor <> A_1.ForeColor AndAlso Not A_1.ForeColor.IsEmpty AndAlso Not A_1.ForeColor.Equals(Color.Transparent) Then
					A_0.TextColor = A_1.ForeColor
				End If
				If Me.O0Oo.Oooo0..CellStyle.BackColor <> A_1.BackColor AndAlso Not Me.O0o.__.(A_1.BackColor) Then
					A_0.BackColor = A_1.BackColor
				End If
				If A_2 Then
					A_0.FontBold = A_1.Font.Bold
					A_0.FontItalic = A_1.Font.Italic
					A_0.FontUnderline = A_1.Font.Underline
					A_0.FontStrikeout = A_1.Font.Strikeout
				End If
			End If
		End Sub

		' Token: 0x060049DD RID: 18909 RVA: 0x001F2B74 File Offset: 0x001F0D74
		Private Function <<EMPTY_NAME>>(A_0 As Color) As Boolean
			Return A_0.Equals(SystemColors.Window) OrElse A_0.Equals(Color.White) OrElse A_0.IsEmpty OrElse A_0.Equals(Color.Transparent)
		End Function

		' Token: 0x060049DE RID: 18910 RVA: 0x001F2BD8 File Offset: 0x001F0DD8
		Private Sub <<EMPTY_NAME>>()
			Me.oOOO0.O_O_o_0o. = 1.0
			Dim count As Boolean = Me.o.o0o__0o0..Cols.Count <> 0
			Dim count2 As Integer = Me.o.o0o__0o0..Rows.Count
			If count AndAlso count2 <> 0 Then
				Me.o.o0o__0o0..BeginUpdate()
				Dim width As Integer = Me.o.o0o__0o0..Cols(0).Width
				Me.o.o0o__0o0..AutoSizeCols(0, 0, Me.o.o0o__0o0..Rows.Count - 1, 0, 0, 0)
				If Me.o.o0o__0o0..Cols(0).Width > width And CDbl(Me.o.o0o__0o0..Cols(0).Width) < Me.O0.o___. Then
					Me.O0.o___. = Me.o.o0o__0o0..Cols(0).Width
				Else
					Me.O0.o___. = width
				End If
				Me.o.o0o__0o0..Cols(0).Width = width
				Me.o.o0o__0o0..EndUpdate()
				If Me.O0Oo.Oooo0..FitIntoPage OrElse Me.O0Oo.Oooo0..ExtendLastCol Then
					Dim num As Double = 0.0
					Try
						For Each obj As Object In Me.o.o0o__0o0..Cols
							Dim column As Column = CType(obj, Column)
							If column.Visible AndAlso Not(column.Index < Me.o.o0o__0o0..Cols.Fixed And Not Me.O0Oo.Oooo0..PrintFixedCols) Then
								Me.OooO.00. += 1
								If column.Index = 0 Then
									num += CDbl(Me.O0.o___.)
								Else
									num += Math.Min(Me.O0.o___., CDbl(column.WidthDisplay))
								End If
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					num = Utils.ConvertUnits(num, 5, 3, Me.o.o0o__0o0., Me.o.OO__0.)
					Me.oOOO0.O_O_o_0o. = num / Me.OooO.00.
					If Me.oOOO0.O_O_o_0o. < 1.0 AndAlso Me.O0Oo.Oooo0..ExtendLastCol Then
						Me.oOOO0.O_O_o_0o. = 1.0
					End If
				End If
			End If
		End Sub

		' Token: 0x060049DF RID: 18911 RVA: 0x001F2E18 File Offset: 0x001F1018
		Private Function <<EMPTY_NAME>>(A_0 As String) As RenderText
			Return New RenderText() With { .Text = Me.oOO_0o_.oOo_o0.(A_0), .Width = New Unit("100%parent"), .Height = New Unit("100%parent"), .Style = { .TextAlignVert = 1 }, .X = 0, .Y = 0 }
		End Function

		' Token: 0x060049E0 RID: 18912 RVA: 0x001F2E7C File Offset: 0x001F107C
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If String.IsNullOrEmpty(A_0) Then
				result = ""
			Else
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Today]", Strings.Format(DateTime.Today, "yyyy-MM-dd"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Time]", Strings.Format(DateTime.Now, "HH:mm:ss"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[ShortTime]", Strings.Format(DateTime.Now, "HH:mm"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Year]", DateTime.Today.Year.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Month]", DateTime.Today.Month.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Day]", DateTime.Today.Day.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Hour]", DateTime.Now.Hour.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Minute]", DateTime.Now.Minute.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Second]", DateTime.Now.Second.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[WeekDay]", DateTime.Today.DayOfWeek.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableName]", Me.O0Oo.Oooo0..Table.DataTable.Name)
				If Operators.CompareString(Me.O0Oo.Oooo0..Table.DataTable.Caption, "", True) > 0 Then
					A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableCaption]", Me.O0Oo.Oooo0..Table.DataTable.Caption)
				Else
					A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableCaption]", Me.O0Oo.Oooo0..Table.DataTable.Name)
				End If
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060049E1 RID: 18913 RVA: 0x001F3084 File Offset: 0x001F1284
		Private Sub <<EMPTY_NAME>>()
			Dim renderArea As RenderArea = New RenderArea()
			If Operators.CompareString(Me.O0Oo.Oooo0..PageHeader, "", True) > 0 Then
				Dim renderArea2 As RenderArea = New RenderArea()
				renderArea2.Style.Font = Me.O0Oo.Oooo0..PageHeaderFont
				Dim array As String() = Me.O0Oo.Oooo0..PageHeader.Split(New Char() { "|"c })
				If array.Length > 0 AndAlso array(0).Length > 0 Then
					Dim renderText As RenderText = Me.oo0.__0Oo.(array(0))
					renderText.Height = Unit.Auto
					renderText.Style.TextAlignHorz = 0
					If Me.O0Oo.Oooo0..PageHeaderLine Then
						renderText.Style.Borders.Bottom = LineDef.[Default]
						renderText.Style.Padding.Bottom = "0.3mm"
					End If
					renderArea2.Children.Add(renderText)
				End If
				If array.Length > 1 AndAlso array(1).Length > 0 Then
					Dim renderText2 As RenderText = Me.oo0.__0Oo.(array(1))
					renderText2.Height = Unit.Auto
					renderText2.Style.TextAlignHorz = 1
					If Me.O0Oo.Oooo0..PageHeaderLine Then
						renderText2.Style.Borders.Bottom = LineDef.[Default]
						renderText2.Style.Padding.Bottom = "0.3mm"
					End If
					renderArea2.Children.Add(renderText2)
				End If
				If array.Length > 2 AndAlso array(2).Length > 0 Then
					Dim renderText3 As RenderText = Me.oo0.__0Oo.(array(2))
					renderText3.Height = Unit.Auto
					renderText3.Style.TextAlignHorz = 2
					If Me.O0Oo.Oooo0..PageHeaderLine Then
						renderText3.Style.Borders.Bottom = LineDef.[Default]
						renderText3.Style.Padding.Bottom = "0.3mm"
					End If
					renderArea2.Children.Add(renderText3)
				End If
				renderArea.Children.Add(renderArea2)
			End If
			If(Operators.CompareString(Me.O0Oo.Oooo0..Title, "", True) > 0 OrElse Operators.CompareString(Me.O0Oo.Oooo0..SubTitle, "", True) > 0) And Me.O0Oo.Oooo0..PrintTitle Then
				Dim renderText4 As RenderText = Nothing
				Dim renderArea3 As RenderArea = Nothing
				If Operators.CompareString(Me.O0Oo.Oooo0..Title, "", True) > 0 Then
					renderText4 = Me.oo0.__0Oo.(Me.O0Oo.Oooo0..Title)
					renderText4.Style.TextAlignHorz = 1
					renderText4.Height = Unit.Auto
					renderText4.Style.Font = Me.O0Oo.Oooo0..TitleFont
					renderText4.BreakBefore = 3
					renderText4.BreakAfter = 3
					If renderArea.Children.Count > 0 Then
						renderText4.Y = "prev.bottom"
						renderText4.Style.Spacing.Top = Conversions.ToString(Me.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm"
					End If
					renderText4.Style.Spacing.Bottom = Me.O0Oo.Oooo0..SpaceAfterTitle
				End If
				If Operators.CompareString(Me.O0Oo.Oooo0..SubTitle, "", True) > 0 Then
					renderArea3 = New RenderArea()
					renderArea3.Style.Font = Me.O0Oo.Oooo0..SubtitleFont
					Dim array2 As String() = Me.O0Oo.Oooo0..SubTitle.Split(New Char() { "|"c })
					If array2.Length > 0 AndAlso array2(0).Length > 0 Then
						Dim renderText5 As RenderText = Me.oo0.__0Oo.(array2(0))
						renderText5.Height = Unit.Auto
						renderText5.Style.TextAlignHorz = 0
						renderArea3.Children.Add(renderText5)
					End If
					If array2.Length > 1 AndAlso array2(1).Length > 0 Then
						Dim renderText6 As RenderText = Me.oo0.__0Oo.(array2(1))
						renderText6.Height = Unit.Auto
						renderText6.Style.TextAlignHorz = 1
						renderArea3.Children.Add(renderText6)
					End If
					If array2.Length > 2 AndAlso array2(2).Length > 0 Then
						Dim renderText7 As RenderText = Me.oo0.__0Oo.(array2(2))
						renderText7.Height = Unit.Auto
						renderText7.Style.TextAlignHorz = 2
						renderArea3.Children.Add(renderText7)
					End If
					renderArea3.Y = "prev.bottom"
					If renderArea.Children.Count > 0 AndAlso renderText4 Is Nothing Then
						renderArea3.Style.Spacing.Top = Conversions.ToString(Me.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm"
					End If
					renderArea3.Style.Spacing.Bottom = Conversions.ToString(Me.O0Oo.Oooo0..SpaceAfterSubtitle) + "mm"
				End If
				If Me.O0Oo.Oooo0..OnlyPrintTitleOnFirstPage Then
					Dim renderArea4 As RenderArea = CType(renderArea.Clone(False, True), RenderArea)
					If renderText4 IsNot Nothing Then
						renderArea4.Children.Add(renderText4)
					End If
					If renderArea3 IsNot Nothing Then
						renderArea4.Children.Add(renderArea3)
					End If
					Dim pageLayout As PageLayout = Me.oo0.__0Oo.().PageLayout.Clone()
					pageLayout.PageSettings = Me.oo0.__0Oo.().PageLayout.PageSettings
					pageLayout.PageHeader = renderArea4
					Me.oo0.__0Oo.().PageLayouts.FirstPage = pageLayout
					renderArea.Style.Spacing.Bottom = Conversions.ToString(Me.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm"
				Else
					If renderText4 IsNot Nothing Then
						renderArea.Children.Add(renderText4)
					End If
					If renderArea3 IsNot Nothing Then
						renderArea.Children.Add(renderArea3)
					End If
				End If
			Else
				renderArea.Style.Spacing.Bottom = Conversions.ToString(Me.O0Oo.Oooo0..SpaceAfterPagerHeader) + "mm"
			End If
			If renderArea.Children.Count > 0 Then
				Me.oo0.__0Oo.().PageLayout.PageHeader = renderArea
			End If
		End Sub

		' Token: 0x060049E2 RID: 18914 RVA: 0x001F3680 File Offset: 0x001F1880
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.O0Oo.Oooo0..PageFooter, "", True) > 0 Then
				Dim renderArea As RenderArea = New RenderArea()
				renderArea.Style.Font = Me.O0Oo.Oooo0..PageFooterFont
				Dim array As String() = Me.O0Oo.Oooo0..PageFooter.Split(New Char() { "|"c })
				If array.Length > 0 AndAlso array(0).Length > 0 Then
					Dim renderText As RenderText = Me.oo0.__0Oo.(array(0))
					renderText.Height = Unit.Auto
					renderText.Style.TextAlignHorz = 0
					If Me.O0Oo.Oooo0..PageFooterLine Then
						renderText.Style.Borders.Top = LineDef.[Default]
						renderText.Style.Padding.Top = "0.3mm"
					End If
					renderArea.Children.Add(renderText)
				End If
				If array.Length > 1 AndAlso array(1).Length > 0 Then
					Dim renderText2 As RenderText = Me.oo0.__0Oo.(array(1))
					renderText2.Height = Unit.Auto
					renderText2.Style.TextAlignHorz = 1
					If Me.O0Oo.Oooo0..PageFooterLine Then
						renderText2.Style.Borders.Top = LineDef.[Default]
						renderText2.Style.Padding.Top = "0.3mm"
					End If
					renderArea.Children.Add(renderText2)
				End If
				If array.Length > 2 AndAlso array(2).Length > 0 Then
					Dim renderText3 As RenderText = Me.oo0.__0Oo.(array(2))
					renderText3.Height = Unit.Auto
					renderText3.Style.TextAlignHorz = 2
					If Me.O0Oo.Oooo0..PageFooterLine Then
						renderText3.Style.Borders.Top = LineDef.[Default]
						renderText3.Style.Padding.Top = "0.3mm"
					End If
					renderArea.Children.Add(renderText3)
				End If
				renderArea.Style.Spacing.Top = Conversions.ToString(Me.O0Oo.Oooo0..SpaceBeforePagerFooter) + "mm"
				Me.oo0.__0Oo.().PageLayout.PageFooter = renderArea
			End If
		End Sub

		' Token: 0x060049E3 RID: 18915 RVA: 0x001F3898 File Offset: 0x001F1A98
		Private Sub <<EMPTY_NAME>>()
			Me.O0Oo.Oooo0..Cols.Count = 0
			Dim num As Integer = 0
			Me.O_oo000._. = 0.0
			Try
				For Each obj As Object In Me.o.o0o__0o0..Cols
					Dim column As Column = CType(obj, Column)
					If column.Visible AndAlso Not(column.Index < Me.o.o0o__0o0..Cols.Fixed And Not Me.O0Oo.Oooo0..PrintFixedCols) Then
						Me.oo0.__0Oo.(num, column.Index)
						num += 1
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060049E4 RID: 18916 RVA: 0x001F3958 File Offset: 0x001F1B58
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As TableCol
			Dim tableCol As TableCol = Me.O0Oo.Oooo0..Cols(A_0)
			Dim column As Column = Me.o.o0o__0o0..Cols(A_1)
			Dim num As Double = Math.Min(CDbl(Me.o.o0o__0o0..Cols(A_1).WidthDisplay), Me.O0.o___.)
			If A_1 = 0 Then
				num = CDbl(Me.O0.o___.)
			End If
			num = Utils.ConvertUnits(num, 5, 3, Me.o.o0o__0o0., Me.o.OO__0.)
			If Me.O0Oo.Oooo0..FitIntoPage OrElse Me.O0Oo.Oooo0..ExtendLastCol Then
				num = num / Me.OooO.00. / Me.oOOO0.O_O_o_0o. * 100.0
				If Me.O_oo000._. + num > 99.0 OrElse A_0 = Me.OooO.00. Then
					num = Math.Round(100.0 - Me.O_oo000._., 2)
				End If
				Dim ptr As Double = Me.O_oo000._.
				Me.O_oo000._. = ptr + num
				Dim text As String = num.ToString() + "%parent.width"
				text = text.Replace(",", ".")
				tableCol.Width = text
			Else
				tableCol.Width = num
			End If
			If A_1 < Me.o.o0o__0o0..Cols.Fixed Then
				Me.OoO0000.0.(tableCol.CellStyle, column.StyleFixedDisplay, False)
			End If
			If A_1 > Me.o.o0o__0o0..Cols.Fixed AndAlso Me.o.o0o__0o0..Contains(Me.o.o0o__0o0..Cols(A_1).Name) Then
				tableCol.CellStyle.Padding.All = "2pt"
			End If
			tableCol.Style.TextAlignVert = 1
			If A_1 < Me.o.o0o__0o0..Cols.Fixed Then
				tableCol.Style.TextAlignHorz = 1
			Else
				Dim textAlign As TextAlignEnum = column.StyleDisplay.TextAlign
				If textAlign <> 1 Then
					If textAlign <> 7 Then
						If textAlign = 10 Then
							tableCol.Style.TextAlignHorz = 1
						End If
					Else
						tableCol.Style.TextAlignHorz = 2
					End If
				Else
					tableCol.Style.TextAlignHorz = 0
				End If
			End If
			Return tableCol
		End Function

		' Token: 0x060049E5 RID: 18917 RVA: 0x001F3B70 File Offset: 0x001F1D70
		Private Sub <<EMPTY_NAME>>()
			Me.O0Oo.Oooo0..Rows.Count = 0
			Dim num As Integer = 0
			Dim num2 As Integer = Me.o.o0o__0o0..Rows.Fixed - 1
			For i As Integer = 0 To num2
				Dim row As Row = Me.o.o0o__0o0..Rows(i)
				If row.Visible Then
					Me.oo0.__0Oo.(num, row.Index)
					num += 1
					If num Mod 100 = 0 Then
						Application.DoEvents()
						If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
							Me.O0Oo.Oooo0. = True
							Return
						End If
					End If
				End If
			Next
			Dim num3 As Integer = Me.o.o0o__0o0..Rows.Fixed
			Dim num4 As Integer = Me.o.o0o__0o0..Rows.Count - 1
			If Me.O0Oo.Oooo0..OnlySelectedRows Then
				num3 = Me.o.o0o__0o0..Selection.TopRow
				num4 = Me.o.o0o__0o0..Selection.BottomRow
			End If
			Dim num5 As Integer = num3
			Dim num6 As Integer = num4
			For j As Integer = num5 To num6
				Dim row As Row = Me.o.o0o__0o0..Rows(j)
				If row.Visible Then
					Me.oo0.__0Oo.(num, row.Index)
					num += 1
					If num Mod 100 = 0 Then
						Application.DoEvents()
						If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
							Me.O0Oo.Oooo0. = True
							Return
						End If
					End If
				End If
			Next
		End Sub

		' Token: 0x060049E6 RID: 18918 RVA: 0x001F3CC0 File Offset: 0x001F1EC0
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As TableRow
			Dim tableRow As TableRow = Me.O0Oo.Oooo0..Rows(A_0)
			Dim row As Row = Me.o.o0o__0o0..Rows(A_1)
			If A_1 < Me.o.o0o__0o0..Rows.Fixed Then
				Me.OoO0000.0.(tableRow.CellStyle, row.StyleFixedDisplay, False)
			End If
			Dim num As Double = CDbl(row.HeightDisplay)
			Dim num2 As Integer = 0
			If A_1 >= Me.o.o0o__0o0..Rows.Fixed AndAlso Me.O0Oo.Oooo0..ExtendMemoRow Then
				num2 = Me.OoO0000.0.(A_1)
			End If
			If num >= CDbl(num2) Then
				If Me.O0Oo.Oooo0..FitIntoPage AndAlso Me.O0Oo.Oooo0..AdjustFontSize Then
					num /= Me.oOOO0.O_O_o_0o.
				End If
				tableRow.Height = Utils.ConvertUnits(num, 5, 3, Me.o.o0o__0o0..DpiY, Me.o.OO__0.)
				Me.o.o0o__0o0..Rows(A_1).UserData = Nothing
			Else
				tableRow.Height = Unit.Auto
			End If
			If A_1 < Me.o.o0o__0o0..Rows.Fixed Then
				tableRow.Style.GridLines.All = Me.oOO_0o_.oOo_o0.
			End If
			Return tableRow
		End Function

		' Token: 0x060049E7 RID: 18919 RVA: 0x001F3DE4 File Offset: 0x001F1FE4
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer = 0
			Dim num2 As Integer = Me.o.o0o__0o0..Rows.Fixed - 1
			For i As Integer = 0 To num2
				Dim row As Row = Me.o.o0o__0o0..Rows(i)
				If row.Visible Then
					Dim num3 As Integer = 0
					Try
						For Each obj As Object In Me.o.o0o__0o0..Cols
							Dim column As Column = CType(obj, Column)
							If column.Visible AndAlso Not(column.Index < Me.o.o0o__0o0..Cols.Fixed And Not Me.O0Oo.Oooo0..PrintFixedCols) Then
								Me.O_0O0_o_._0_0.(num, num3, row.Index, column.Index)
								num3 += 1
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					num += 1
					Me.oOO_0o_.oOo_o0.(num)
					If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
						Me.O0Oo.Oooo0. = True
						Exit For
					End If
				End If
			Next
			Dim num4 As Integer = Me.o.o0o__0o0..Rows.Fixed
			Dim num5 As Integer = Me.o.o0o__0o0..Rows.Count - 1
			If Me.O0Oo.Oooo0..OnlySelectedRows Then
				num4 = Me.o.o0o__0o0..Selection.TopRow
				num5 = Me.o.o0o__0o0..Selection.BottomRow
			End If
			Dim num6 As Integer = num4
			Dim num7 As Integer = num5
			For j As Integer = num6 To num7
				Dim row As Row = Me.o.o0o__0o0..Rows(j)
				If row.Visible Then
					Dim num8 As Integer = 0
					Try
						For Each obj2 As Object In Me.o.o0o__0o0..Cols
							Dim column2 As Column = CType(obj2, Column)
							If column2.Visible AndAlso Not(column2.Index < Me.o.o0o__0o0..Cols.Fixed And Not Me.O0Oo.Oooo0..PrintFixedCols) Then
								Me.O_0O0_o_._0_0.(num, num8, row.Index, column2.Index)
								num8 += 1
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					num += 1
					Me.oOO_0o_.oOo_o0.(num)
					If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
						Me.O0Oo.Oooo0. = True
						Return
					End If
				End If
			Next
		End Sub

		' Token: 0x060049E8 RID: 18920 RVA: 0x001F4058 File Offset: 0x001F2258
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Boolean
			Dim allowMerging As AllowMergingEnum = Me.o.o0o__0o0..AllowMerging
			Dim result As Boolean
			If allowMerging IsNot Nothing Then
				If allowMerging <> 6 Then
					If allowMerging <> 7 Then
						result = (Me.o.o0o__0o0..Rows(A_0).AllowMerging OrElse Me.o.o0o__0o0..Cols(A_1).AllowMerging)
					Else
						result = (Me.o.o0o__0o0..Rows(A_0).IsNode OrElse A_0 < Me.o.o0o__0o0..Rows.Fixed)
					End If
				Else
					result = True
				End If
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x060049E9 RID: 18921 RVA: 0x001F40EC File Offset: 0x001F22EC
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As Integer) As TableCell
			Dim result As TableCell
			If Not Me.O0o.__.(A_2, A_3) Then
				result = Me.oo0.__0Oo.(A_0, A_1, A_2, A_3)
			Else
				Dim cellRange As CellRange = Me.o.o0o__0o0..OO_.00oO0Oo.(A_2, A_3, False)
				While cellRange.r1 < cellRange.r2
					If Me.o.o0o__0o0..Rows(cellRange.r1).Visible Then
						Exit While
					End If
					cellRange.r1 += 1
				End While
				While cellRange.c1 < cellRange.c2 AndAlso Not Me.o.o0o__0o0..Cols(cellRange.c1).Visible
					cellRange.c1 += 1
				End While
				Dim num As Integer = cellRange.r1 + 1
				Dim r As Integer = cellRange.r2
				Dim num2 As Integer
				For i As Integer = num To r
					If Not Me.o.o0o__0o0..Rows(i).Visible Then
						num2 += 1
					End If
				Next
				Dim num3 As Integer = cellRange.c1 + 1
				Dim c As Integer = cellRange.c2
				Dim num4 As Integer
				For j As Integer = num3 To c
					If Not Me.o.o0o__0o0..Cols(j).Visible Then
						num4 += 1
					End If
				Next
				cellRange.r2 -= num2
				cellRange.c2 -= num4
				If cellRange.IsSingleCell Then
					result = Me.oo0.__0Oo.(A_0, A_1, A_2, A_3)
				ElseIf A_2 > cellRange.r1 Then
					result = Nothing
				ElseIf A_3 > cellRange.c1 Then
					result = Nothing
				Else
					Dim tableCell As TableCell = Me.oo0.__0Oo.(A_0, A_1, A_2, A_3)
					tableCell.SpanCols = Math.Abs(cellRange.c2 - cellRange.c1) + 1
					tableCell.SpanRows = Math.Abs(cellRange.r2 - cellRange.r1) + 1
					tableCell.VertSplitBehavior = 1
					result = tableCell
				End If
			End If
			Return result
		End Function

		' Token: 0x060049EA RID: 18922 RVA: 0x001F42C4 File Offset: 0x001F24C4
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As Integer) As TableCell
			Dim image As Image = Nothing
			Dim a_ As CheckEnum = 0
			Dim text As String = Me.o.o0o__0o0..GetDataDisplay(A_2, A_3, image, a_)
			Dim image2 As Image = ooO.oO0__o.0o__.(Me.o.o0o__0o0., a_)
			Dim flag As Boolean = False
			If image2 IsNot Nothing Then
				image = image2
				text = Nothing
			End If
			Dim cellStyle As CellStyle
			If A_2 >= Me.o.o0o__0o0..Rows.Fixed And A_3 >= Me.o.o0o__0o0..Cols.Fixed Then
				cellStyle = Me.o.o0o__0o0..Cols(A_3).StyleDisplay
			Else
				cellStyle = Me.o.o0o__0o0..GetCellStyleDisplay(A_2, A_3)
			End If
			Dim styleDisplay As CellStyle = Me.o.o0o__0o0..Cols(A_3).StyleDisplay
			Dim bitmap As Bitmap = Nothing
			If Me.o.o0o__0o0..Cols(A_3).WidthDisplay > 0 AndAlso Me.o.o0o__0o0..Rows(A_2).HeightDisplay > 0 Then
				bitmap = New Bitmap(Me.o.o0o__0o0..Cols(A_3).WidthDisplay, Me.o.o0o__0o0..Rows(A_2).HeightDisplay)
				Dim graphics As Graphics = Graphics.FromImage(bitmap)
				Dim ownerDrawCellEventArgs As OwnerDrawCellEventArgs = New OwnerDrawCellEventArgs(Nothing, graphics, A_2, A_3, Nothing, New Rectangle(0, 0, bitmap.Width, bitmap.Height), text, image)
				Me.o.o0o__0o0..OO_.00oO0Oo.(Me.o.o0o__0o0., ownerDrawCellEventArgs, Me.O0Oo.Oooo0..ExcuteDrawCell, True, flag)
				graphics.Dispose()
				If Operators.CompareString(ownerDrawCellEventArgs.Text, "", True) > 0 AndAlso image2 Is Nothing Then
					text = ownerDrawCellEventArgs.Text
				End If
				If Operators.CompareString(text, " ", True) = 0 Then
					text = ""
				End If
				If ownerDrawCellEventArgs.Image IsNot Nothing Then
					image = ownerDrawCellEventArgs.Image
				End If
				If ownerDrawCellEventArgs.Style IsNot Nothing AndAlso Me.O0Oo.Oooo0..EnableStyle Then
					cellStyle = ownerDrawCellEventArgs.Style
				End If
				If A_1 = 0 AndAlso A_0 >= Me.o.o0o__0o0..Rows.Fixed AndAlso Me.O0Oo.Oooo0..PrintFixedCols AndAlso Me.O0Oo.Oooo0..Renumber Then
					text = (A_0 - Me.o.o0o__0o0..Rows.Fixed + 1).ToString()
				End If
			End If
			flag = (flag OrElse image IsNot Nothing OrElse image2 IsNot Nothing)
			Dim tableCell As TableCell = Me.O0Oo.Oooo0..Cells(A_0, A_1)
			If A_0 >= Me.o.o0o__0o0..Rows.Fixed AndAlso flag Then
				If image Is Nothing Then
					tableCell.Style.BackgroundImage = bitmap
				End If
				tableCell.Style.BackgroundImageAlign.AlignVert = 1
				tableCell.Style.BackgroundImageAlign.AlignHorz = 1
				Dim renderObject As RenderObject = Me.O0o.__.(A_0, A_1, A_2, A_3, cellStyle, text, image, image2 IsNot Nothing)
				If renderObject IsNot Nothing Then
					renderObject.Style.Parents = tableCell.CellStyle
					tableCell.RenderObject = renderObject
				End If
			Else
				tableCell.Text = text
				If cellStyle.BackColor <> styleDisplay.BackColor Then
					tableCell.Style.BackColor = cellStyle.BackColor
				End If
				If cellStyle.ForeColor <> styleDisplay.ForeColor Then
					tableCell.Style.TextColor = cellStyle.ForeColor
				End If
				If A_2 < Me.o.o0o__0o0..Rows.Fixed Then
					tableCell.Style.TextAlignHorz = 1
				ElseIf cellStyle.TextAlign <> styleDisplay.TextAlign Then
					Dim textAlign As TextAlignEnum = cellStyle.TextAlign
					If textAlign <> 1 Then
						If textAlign <> 7 Then
							If textAlign = 10 Then
								tableCell.Style.TextAlignHorz = 1
							End If
						Else
							tableCell.Style.TextAlignHorz = 2
						End If
					Else
						tableCell.Style.TextAlignHorz = 0
					End If
				End If
			End If
			Return tableCell
		End Function

		' Token: 0x060049EB RID: 18923 RVA: 0x001F466C File Offset: 0x001F286C
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As Integer, A_4 As CellStyle, A_5 As String, A_6 As Image, A_7 As Boolean) As RenderObject
			Dim renderObject As RenderObject = Nothing
			If Not Me.o.o0o__0o0..Cols(A_3).ImageAndText Then
				A_5 = Nothing
			End If
			Dim flag As Boolean = A_6 IsNot Nothing
			Dim flag2 As Boolean = Not String.IsNullOrEmpty(A_5)
			Dim result As RenderObject
			If Not flag AndAlso Not flag2 Then
				result = Nothing
			Else
				If flag2 AndAlso (Not flag OrElse A_2 < Me.o.o0o__0o0..Rows.Fixed) Then
					Dim renderText As RenderText = New RenderText()
					renderText.Text = A_5
					renderObject = renderText
					renderText.Style.WordWrap = True
					If Not Me.O0Oo.Oooo0..Rows(A_0).Height.IsAuto OrElse Operators.CompareString(Conversions.ToString(Me.o.o0o__0o0..Rows(A_2).UserData), Me.o.o0o__0o0..Cols(A_3).Name, True) <> 0 Then
						renderText.Height = "parent.height"
						If A_2 < Me.o.o0o__0o0..Rows.Fixed Then
							Dim textAlignFixed As TextAlignEnum = Me.o.o0o__0o0..Cols(A_3).TextAlignFixed
							If textAlignFixed <> 1 Then
								If textAlignFixed <> 7 Then
									renderText.Style.TextAlignHorz = 1
								Else
									renderText.Style.TextAlignHorz = 2
								End If
							Else
								renderText.Style.TextAlignHorz = 0
							End If
						Else
							Dim textAlign As TextAlignEnum = Me.o.o0o__0o0..Cols(A_3).TextAlign
							If textAlign <> 1 Then
								If textAlign <> 4 Then
									If textAlign <> 7 Then
										If Versioned.IsNumeric(A_5) Then
											renderText.Style.TextAlignHorz = 2
										Else
											renderText.Style.TextAlignHorz = 0
										End If
									Else
										renderText.Style.TextAlignHorz = 2
									End If
								Else
									renderText.Style.TextAlignHorz = 1
								End If
							Else
								renderText.Style.TextAlignHorz = 0
							End If
						End If
						If renderText.Style.TextAlignHorz Is Nothing Then
							renderText.Style.Spacing.Left = CDbl((2F / Me.o.o0o__0o0.)) * 25.4
						ElseIf renderText.Style.TextAlignHorz = 2 Then
							renderText.Style.Spacing.Right = CDbl((2F / Me.o.o0o__0o0.)) * 25.4
						End If
						If A_2 < Me.o.o0o__0o0..Rows.Fixed Then
						End If
					End If
				ElseIf flag Then
					Dim renderImage As RenderImage = New RenderImage(A_6)
					If A_7 Then
						renderImage.Style.ImageAlign.AlignHorz = 1
					Else
						renderImage.Style.ImageAlign.AlignHorz = 0
					End If
					renderImage.Style.ImageAlign.AlignVert = 1
					renderImage.Style.ImageAlign.StretchHorz = False
					renderImage.Style.ImageAlign.StretchVert = False
					renderImage.Style.Spacing.Left = CDbl((2F / Me.o.o0o__0o0.)) * 25.4
					renderImage.Style.Spacing.Right = CDbl((2F / Me.o.o0o__0o0.)) * 25.4
					renderImage.Height = "parent.height"
					If flag2 Then
						Dim renderArea As RenderArea = New RenderArea()
						renderArea.Height = "parent.height"
						renderArea.Stacking = 1
						Dim renderText As RenderText = New RenderText()
						renderText.Height = "parent.height"
						renderText.Text = A_5
						renderArea.Children.Add(renderImage)
						renderArea.Children.Add(renderText)
						renderObject = renderArea
					Else
						renderObject = renderImage
					End If
				End If
				If renderObject IsNot Nothing AndAlso A_4 IsNot Nothing Then
					Me.OoO0000.0.(renderObject.Style, A_4, True)
				End If
				result = renderObject
			End If
			Return result
		End Function

		' Token: 0x060049EC RID: 18924 RVA: 0x001F4A24 File Offset: 0x001F2C24
		Private Function <<EMPTY_NAME>>(A_0 As Integer) As Integer
			Dim num As Integer = 0
			Try
				For Each obj As Object In Me.o.o0o__0o0..Cols
					Dim column As Column = CType(obj, Column)
					If column.Index >= Me.o.o0o__0o0..Cols.Fixed AndAlso Me.o.o0o__0o0..Contains(column.Name) Then
						Dim a_ As Integer = CInt(Math.Round(Math.Min(CDbl(column.WidthDisplay), Me.O0.o___.) - Utils.ConvertUnits(2.0, 6, 5, Me.o.OO__0., Me.o.o0o__0o0.)))
						Dim dataDisplay As String = Me.o.o0o__0o0..GetDataDisplay(A_0, column.Name)
						Dim num2 As Integer = Me.O0o.__.(dataDisplay, Me.o.o0o__0o0..Font, a_) + 2
						If num2 > num Then
							num = num2
							Me.o.o0o__0o0..Rows(A_0).UserData = column.Name
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return num
		End Function

		' Token: 0x060049ED RID: 18925 RVA: 0x001F4B40 File Offset: 0x001F2D40
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Font, A_2 As Integer) As Integer
			Dim layoutArea As SizeF = New SizeF(CSng(A_2), 0F)
			Return CInt(Math.Round(CDbl(Me.o.o0o__0o0..MeasureString(A_0, A_1, layoutArea, Me.O0Oo.Oooo0.).Height)))
		End Function

		' Token: 0x060049EE RID: 18926 RVA: 0x001F4B80 File Offset: 0x001F2D80
		Private Sub <<EMPTY_NAME>>(A_0 As C1PrintDocument, A_1 As PageEventArgs)
			Me.O0Oo.Oooo0..Oo0._.("正在生成第" + Conversions.ToString(Me.oo0.__0Oo.().Pages.Count) + "页...")
			Application.DoEvents()
			If Me.O0Oo.Oooo0..Ooo_oo._o.() Then
				Me.oo0.__0Oo.().Cancel = True
			End If
		End Sub

		' Token: 0x04001E3E RID: 7742
		Private <<EMPTY_NAME>> As PrintInfo

		' Token: 0x04001E3F RID: 7743
		Private <<EMPTY_NAME>> As O_oOooO_O

		' Token: 0x04001E40 RID: 7744
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PrintDocument

		' Token: 0x04001E41 RID: 7745
		Private <<EMPTY_NAME>> As RenderTable

		' Token: 0x04001E42 RID: 7746
		Private <<EMPTY_NAME>> As Single

		' Token: 0x04001E43 RID: 7747
		Private <<EMPTY_NAME>> As Single

		' Token: 0x04001E44 RID: 7748
		Private <<EMPTY_NAME>> As StringFormat

		' Token: 0x04001E45 RID: 7749
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001E46 RID: 7750
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001E47 RID: 7751
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001E48 RID: 7752
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001E49 RID: 7753
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001E4A RID: 7754
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E4B RID: 7755
		Private <<EMPTY_NAME>> As Graphics

		' Token: 0x04001E4C RID: 7756
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E4D RID: 7757
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E4E RID: 7758
		Private <<EMPTY_NAME>> As LineDef

		' Token: 0x04001E4F RID: 7759
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001E50 RID: 7760
		Private <<EMPTY_NAME>> As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000

		' Token: 0x04001E51 RID: 7761
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
