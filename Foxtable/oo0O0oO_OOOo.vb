Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.C1Pdf
Imports C1.Win.C1Document
Imports C1.Win.FlexViewer
Imports C1.Win.Map
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Web.WebView2.WinForms

Namespace Foxtable
	' Token: 0x020000C5 RID: 197
	<DesignerGenerated()>
	Public Partial Class oo0O0oO_OOOo
		Inherits Form

		' Token: 0x0600087B RID: 2171 RVA: 0x0003A128 File Offset: 0x00038328
		Public Sub New()
			Me.oo00O.o.()
		End Sub

		' Token: 0x0600087C RID: 2172 RVA: 0x0003A138 File Offset: 0x00038338
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0o.O_O0. IsNot Nothing Then
					Me.O0o.O_O0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600087D RID: 2173 RVA: 0x0003A178 File Offset: 0x00038378
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0o.O_O0. = New Container()
			Me.oo00O.o.(New C1PdfDocument())
			Me.O0o.O_O0.(New C1PdfDocumentSource(Me.O0o.O_O0.))
			Me.oo00O.o.(New C1FlexViewerDialog(Me.O0o.O_O0.))
			Me.oo00O.o.(New C1Map())
			Me.O0o.O_O0.(New WebView2())
			Me.oo00O.o.().BeginInit()
			Me.oo00O.o.().BeginInit()
			Me.oo00O.o.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo00O.o.().DocumentInfo.Author = ""
			Me.oo00O.o.().DocumentInfo.CreationDate = New DateTime(0L)
			Me.oo00O.o.().DocumentInfo.Creator = ""
			Me.oo00O.o.().DocumentInfo.Keywords = ""
			Me.oo00O.o.().DocumentInfo.Producer = "ComponentOne C1Pdf"
			Me.oo00O.o.().DocumentInfo.Subject = ""
			Me.oo00O.o.().DocumentInfo.Title = ""
			Me.oo00O.o.().MaxHeaderBookmarkLevel = 0
			Me.oo00O.o.().PdfVersion = "1.3"
			Me.oo00O.o.().RefDC = Nothing
			Me.oo00O.o.().RotateAngle = 0F
			Me.oo00O.o.().UseFastTextOut = True
			Me.oo00O.o.().UseFontShaping = True
			Me.oo00O.o.().AutoScaleDimensions = New SizeF(96F, 96F)
			Me.oo00O.o.().AutoScaleMode = AutoScaleMode.Dpi
			Me.oo00O.o.().ClientSize = New Size(935, 603)
			Me.oo00O.o.().Name = "C1FlexViewerDialog"
			Me.oo00O.o.().Text = "C1FlexViewerDialog1"
			Me.oo00O.o.().VisualStyleHolder = 0
			Me.oo00O.o.().DistanceScale.Alignment = ContentAlignment.BottomLeft
			Me.oo00O.o.().DistanceScale.BarStyle.BackColor = Color.Black
			Me.oo00O.o.().Enabled = False
			Me.oo00O.o.().Location = New Point(33, 12)
			Me.oo00O.o.().Name = "C1Map1"
			Me.oo00O.o.().PanTool.MarkerStyle.BackColor = Color.FromArgb(131, 176, 202)
			Me.oo00O.o.().PanTool.MarkerStyle.BackColor2 = Color.FromArgb(185, 224, 245)
			Me.oo00O.o.().PanTool.MarkerStyle.GradientStyle = 3
			Me.oo00O.o.().PanTool.PanStyle.BackColor = Color.FromArgb(243, 243, 243)
			Me.oo00O.o.().PanTool.PanStyle.BackColor2 = Color.FromArgb(204, 204, 204)
			Me.oo00O.o.().PanTool.PanStyle.GradientStyle = 3
			Me.oo00O.o.().PanTool.PanStyle.Stroke.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().PanTool.PanStyle.Stroke.Width = 1F
			Me.oo00O.o.().Proxy = Nothing
			Me.oo00O.o.().Size = New Size(464, 294)
			Me.oo00O.o.().TabIndex = 0
			Me.oo00O.o.().Text = "C1Map1"
			Me.oo00O.o.().Viewport.Padding = New Padding(3)
			Me.oo00O.o.().ZoomTool.ButtonStyle.BackColor = Color.FromArgb(243, 243, 243)
			Me.oo00O.o.().ZoomTool.ButtonStyle.BackColor2 = Color.FromArgb(204, 204, 204)
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Bottom.Width = 1F
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Left.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Left.Width = 1F
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Right.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Right.Width = 1F
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Top.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.ButtonStyle.Border.Top.Width = 1F
			Me.oo00O.o.().ZoomTool.ButtonStyle.GradientStyle = 3
			Me.oo00O.o.().ZoomTool.Margin = New Padding(20, 70, 0, 0)
			Me.oo00O.o.().ZoomTool.ThumbStyle.BackColor = Color.FromArgb(243, 243, 243)
			Me.oo00O.o.().ZoomTool.ThumbStyle.BackColor2 = Color.FromArgb(131, 176, 202)
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Bottom.Color = Color.FromArgb(138, 176, 198)
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Bottom.Width = 1F
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Left.Color = Color.FromArgb(138, 176, 198)
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Left.Width = 1F
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Right.Color = Color.FromArgb(138, 176, 198)
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Right.Width = 1F
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Top.Color = Color.FromArgb(138, 176, 198)
			Me.oo00O.o.().ZoomTool.ThumbStyle.Border.Top.Width = 1F
			Me.oo00O.o.().ZoomTool.ThumbStyle.GradientStyle = 3
			Me.oo00O.o.().ZoomTool.TrackStyle.BackColor = Color.FromArgb(203, 203, 203)
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Bottom.Width = 1F
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Left.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Left.Width = 1F
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Right.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Right.Width = 1F
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Top.Color = Color.FromArgb(168, 168, 168)
			Me.oo00O.o.().ZoomTool.TrackStyle.Border.Top.Width = 1F
			Me.oo00O.o.().AllowExternalDrop = True
			Me.oo00O.o.().CreationProperties = Nothing
			Me.oo00O.o.().DefaultBackgroundColor = Color.White
			Me.oo00O.o.().Location = New Point(469, 335)
			Me.oo00O.o.().Name = "WebView21"
			Me.oo00O.o.().Size = New Size(124, 60)
			Me.oo00O.o.().TabIndex = 1
			Me.oo00O.o.().ZoomFactor = 1.0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(800, 450)
			MyBase.Controls.Add(Me.oo00O.o.())
			MyBase.Controls.Add(Me.oo00O.o.())
			MyBase.Name = "Form4"
			Me.Text = "Form4"
			Me.oo00O.o.().EndInit()
			Me.oo00O.o.().EndInit()
			Me.oo00O.o.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600087E RID: 2174 RVA: 0x0003ACDE File Offset: 0x00038EDE
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1PdfDocument
			Return Me.O0o.O_O0.
		End Function

		' Token: 0x0600087F RID: 2175 RVA: 0x0003ACE6 File Offset: 0x00038EE6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1PdfDocument)
			Me.O0o.O_O0. = A_0
		End Sub

		' Token: 0x06000880 RID: 2176 RVA: 0x0003ACEF File Offset: 0x00038EEF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1PdfDocumentSource
			Return Me.O0o.O_O0.
		End Function

		' Token: 0x06000881 RID: 2177 RVA: 0x0003ACF7 File Offset: 0x00038EF7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1PdfDocumentSource)
			Me.O0o.O_O0. = A_0
		End Sub

		' Token: 0x06000882 RID: 2178 RVA: 0x0003AD00 File Offset: 0x00038F00
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexViewerDialog
			Return Me.O0o.O_O0.
		End Function

		' Token: 0x06000883 RID: 2179 RVA: 0x0003AD08 File Offset: 0x00038F08
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1FlexViewerDialog)
			Me.O0o.O_O0. = A_0
		End Sub

		' Token: 0x06000884 RID: 2180 RVA: 0x0003AD11 File Offset: 0x00038F11
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Map
			Return Me.O0o.O_O0.
		End Function

		' Token: 0x06000885 RID: 2181 RVA: 0x0003AD19 File Offset: 0x00038F19
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Map)
			Me.O0o.O_O0. = A_0
		End Sub

		' Token: 0x06000886 RID: 2182 RVA: 0x0003AD22 File Offset: 0x00038F22
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As WebView2
			Return Me.O0o.O_O0.
		End Function

		' Token: 0x06000887 RID: 2183 RVA: 0x0003AD2A File Offset: 0x00038F2A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As WebView2)
			Me.O0o.O_O0. = A_0
		End Sub

		' Token: 0x040002EE RID: 750
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040002EF RID: 751
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PdfDocument

		' Token: 0x040002F0 RID: 752
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PdfDocumentSource

		' Token: 0x040002F1 RID: 753
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexViewerDialog

		' Token: 0x040002F2 RID: 754
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Map

		' Token: 0x040002F3 RID: 755
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As WebView2
	End Class
End Namespace
