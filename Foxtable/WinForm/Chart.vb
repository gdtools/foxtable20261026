Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003A7 RID: 935
	<ComVisible(True)>
	Public Class Chart
		Inherits Control

		' Token: 0x17000CD5 RID: 3285
		' (get) Token: 0x06003B39 RID: 15161 RVA: 0x00199035 File Offset: 0x00197235
		' (set) Token: 0x06003B3A RID: 15162 RVA: 0x0019903D File Offset: 0x0019723D
		Protected Overridable Property C1Chart As C1Chart

		' Token: 0x06003B3B RID: 15163 RVA: 0x00199048 File Offset: 0x00197248
		Friend Sub <<EMPTY_NAME>>()
			Me.C1Chart.ToolTip.Enabled = True
			Me.C1Chart.ChartArea.AxisX.AnnoFormat = 0
			Me.C1Chart.ChartArea.AxisY.AnnoFormat = 0
			Me.C1Chart.ChartArea.AxisY2.AnnoFormat = 0
			Me.C1Chart.ChartArea.Style.BackColor = Color.White
			Me.C1Chart.Style.Border.Color = SystemColors.ControlDark
			Me.C1Chart.Style.Border.Thickness = 1
			Me.C1Chart.Style.Border.BorderStyle = 3
			Me.C1Chart.ChartArea.Style.Border.BorderStyle = 3
			Me.C1Chart.ChartArea.Style.Border.Rounding.All = 10
			Me.C1Chart.ChartArea.Style.Border.Thickness = 1
			Me.C1Chart.ChartArea.Style.Border.Color = SystemColors.ControlDarkDark
			Me.C1Chart.Header.Visible = False
			Me.C1Chart.Footer.Visible = False
			Me.C1Chart.ChartArea.AxisX.GridMajor.Visible = True
			Me.C1Chart.ChartArea.AxisX.ForeColor = SystemColors.ControlDarkDark
			Me.C1Chart.ChartArea.AxisY.GridMajor.Visible = True
			Me.C1Chart.ChartArea.AxisY.ForeColor = SystemColors.ControlDarkDark
			Me.C1Chart.ChartArea.AxisY2.GridMajor.Visible = True
			Me.C1Chart.ChartArea.AxisY2.ForeColor = SystemColors.ControlDarkDark
			Me.C1Chart.ColorGeneration = 10
			Me.C1Chart.UseAntiAliasedGraphics = True
			Me.C1Chart.UseDoubleBuffer = True
			Me.C1Chart.ChartGroups(0).Radar.Filled = True
			Me.C1Chart.ChartGroups(1).Radar.Filled = True
		End Sub

		' Token: 0x06003B3C RID: 15164 RVA: 0x0019929C File Offset: 0x0019749C
		Public Sub New(A_0 As C1Chart)
			MyBase.New(A_0, ControlTypeEnum.Chart)
			Me.C1Chart = A_0
			Me.o__0oo0o_O.o. = New ChartAxis(Me.C1Chart.ChartArea.AxisX)
			Me.o._0OooO_0. = New ChartAxis(Me.C1Chart.ChartArea.AxisY)
			Me.oOo.O00o0OOoo. = New ChartAxis(Me.C1Chart.ChartArea.AxisY2)
			Me.oOOO_.__oO0O. = New ChartSerialCollection(Me.C1Chart.ChartGroups(0).ChartData.SeriesList, Me.C1Chart)
			Me.OOoOO_.0. = New ChartSerialCollection(Me.C1Chart.ChartGroups(1).ChartData.SeriesList, Me.C1Chart)
		End Sub

		' Token: 0x17000CD6 RID: 3286
		' (get) Token: 0x06003B3D RID: 15165 RVA: 0x00199362 File Offset: 0x00197562
		' (set) Token: 0x06003B3E RID: 15166 RVA: 0x0019936C File Offset: 0x0019756C
		<oO0oooo("0967")>
		Public Property DataSource As String
			Get
				Return Me.o__0oo0o_O.o.
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					Me.o__0oo0o_O.o. = ""
					Me.C1Chart.DataSource = ""
					Return
				End If
				If O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(value) Then
					Dim dataSource As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(value), Me.DataFilter, "", DataViewRowState.CurrentRows)
					Me.C1Chart.DataSource = dataSource
				End If
			End Set
		End Property

		' Token: 0x17000CD7 RID: 3287
		' (get) Token: 0x06003B3F RID: 15167 RVA: 0x001993E4 File Offset: 0x001975E4
		' (set) Token: 0x06003B40 RID: 15168 RVA: 0x00199444 File Offset: 0x00197644
		<oO0oooo("0967")>
		Public Property DataTable As DataTable
			Get
				Dim result As DataTable
				If Me.oOOO_.__oO0O. IsNot Nothing Then
					result = Me.oOOO_.__oO0O.
				ElseIf Operators.CompareString(Me.DataSource, "", True) > 0 Then
					If OO_00oOO.DataTables.Contains(Me.DataSource) Then
						result = OO_00oOO.DataTables(Me.DataSource)
					Else
						result = Nothing
					End If
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As DataTable)
				Me.oOOO_.__oO0O. = value
				Dim dataSource As DataView = New DataView(value.BaseTable, Me.DataFilter, "", DataViewRowState.CurrentRows)
				Me.C1Chart.DataSource = dataSource
			End Set
		End Property

		' Token: 0x17000CD8 RID: 3288
		' (get) Token: 0x06003B41 RID: 15169 RVA: 0x0019947D File Offset: 0x0019767D
		' (set) Token: 0x06003B42 RID: 15170 RVA: 0x00199485 File Offset: 0x00197685
		<oO0oooo("0967")>
		Public Property DataFilter As String
			Get
				Return Me.o._0OooO_0.
			End Get
			Set(value As String)
				Me.o._0OooO_0. = value
				If Me.C1Chart.DataSource IsNot Nothing Then
					CType(Me.C1Chart.DataSource, DataView).RowFilter = value
				End If
			End Set
		End Property

		' Token: 0x17000CD9 RID: 3289
		' (get) Token: 0x06003B43 RID: 15171 RVA: 0x001994B1 File Offset: 0x001976B1
		' (set) Token: 0x06003B44 RID: 15172 RVA: 0x001994C9 File Offset: 0x001976C9
		Public Property VisualEffect As Boolean
			Get
				Return Me.C1Chart.VisualEffects(0).Enabled
			End Get
			Set(value As Boolean)
				Me.C1Chart.VisualEffects(0).Enabled = value
			End Set
		End Property

		' Token: 0x17000CDA RID: 3290
		' (get) Token: 0x06003B45 RID: 15173 RVA: 0x001994E2 File Offset: 0x001976E2
		Public ReadOnly Property AxisX As ChartAxis
			Get
				Return Me.o__0oo0o_O.o.
			End Get
		End Property

		' Token: 0x17000CDB RID: 3291
		' (get) Token: 0x06003B46 RID: 15174 RVA: 0x001994EA File Offset: 0x001976EA
		Public ReadOnly Property AxisY As ChartAxis
			Get
				Return Me.o._0OooO_0.
			End Get
		End Property

		' Token: 0x17000CDC RID: 3292
		' (get) Token: 0x06003B47 RID: 15175 RVA: 0x001994F2 File Offset: 0x001976F2
		Public ReadOnly Property AxisY2 As ChartAxis
			Get
				Return Me.oOo.O00o0OOoo.
			End Get
		End Property

		' Token: 0x17000CDD RID: 3293
		' (get) Token: 0x06003B48 RID: 15176 RVA: 0x001994FA File Offset: 0x001976FA
		' (set) Token: 0x06003B49 RID: 15177 RVA: 0x0019950C File Offset: 0x0019770C
		<oO0oooo("0987")>
		Public Property InVerted As Boolean
			Get
				Return Me.C1Chart.ChartArea.Inverted
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartArea.Inverted = value
			End Set
		End Property

		' Token: 0x17000CDE RID: 3294
		' (get) Token: 0x06003B4A RID: 15178 RVA: 0x0019951F File Offset: 0x0019771F
		<oO0oooo("0999")>
		Public ReadOnly Property SeriesList As ChartSerialCollection
			Get
				Return Me.oOOO_.__oO0O.
			End Get
		End Property

		' Token: 0x17000CDF RID: 3295
		' (get) Token: 0x06003B4B RID: 15179 RVA: 0x00199527 File Offset: 0x00197727
		<oO0oooo("1005")>
		Public ReadOnly Property SeriesList2 As ChartSerialCollection
			Get
				Return Me.OOoOO_.0.
			End Get
		End Property

		' Token: 0x17000CE0 RID: 3296
		' (get) Token: 0x06003B4C RID: 15180 RVA: 0x0019952F File Offset: 0x0019772F
		' (set) Token: 0x06003B4D RID: 15181 RVA: 0x00199547 File Offset: 0x00197747
		<oO0oooo("0988")>
		Public Property Stacked As Boolean
			Get
				Return Me.C1Chart.ChartGroups(0).Stacked
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(0).Stacked = value
			End Set
		End Property

		' Token: 0x17000CE1 RID: 3297
		' (get) Token: 0x06003B4E RID: 15182 RVA: 0x00199560 File Offset: 0x00197760
		' (set) Token: 0x06003B4F RID: 15183 RVA: 0x00199578 File Offset: 0x00197778
		<oO0oooo("0988")>
		Public Property Is100Percent As Boolean
			Get
				Return Me.C1Chart.ChartGroups(0).Is100Percent
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(0).Is100Percent = value
			End Set
		End Property

		' Token: 0x17000CE2 RID: 3298
		' (get) Token: 0x06003B50 RID: 15184 RVA: 0x00199591 File Offset: 0x00197791
		' (set) Token: 0x06003B51 RID: 15185 RVA: 0x001995AE File Offset: 0x001977AE
		<oO0oooo("0988")>
		Public Property BarLines As Boolean
			Get
				Return Me.C1Chart.ChartGroups(0).Bar.BarLines
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(0).Bar.BarLines = value
			End Set
		End Property

		' Token: 0x17000CE3 RID: 3299
		' (get) Token: 0x06003B52 RID: 15186 RVA: 0x001995CC File Offset: 0x001977CC
		' (set) Token: 0x06003B53 RID: 15187 RVA: 0x001995E9 File Offset: 0x001977E9
		<oO0oooo("1004")>
		Public Property BarLines2 As Boolean
			Get
				Return Me.C1Chart.ChartGroups(1).Bar.BarLines
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(1).Bar.BarLines = value
			End Set
		End Property

		' Token: 0x17000CE4 RID: 3300
		' (get) Token: 0x06003B54 RID: 15188 RVA: 0x00199607 File Offset: 0x00197807
		' (set) Token: 0x06003B55 RID: 15189 RVA: 0x0019961F File Offset: 0x0019781F
		<oO0oooo("1004")>
		Public Property Stacked2 As Boolean
			Get
				Return Me.C1Chart.ChartGroups(1).Stacked
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(1).Stacked = value
			End Set
		End Property

		' Token: 0x17000CE5 RID: 3301
		' (get) Token: 0x06003B56 RID: 15190 RVA: 0x00199638 File Offset: 0x00197838
		' (set) Token: 0x06003B57 RID: 15191 RVA: 0x00199650 File Offset: 0x00197850
		<oO0oooo("1004")>
		Public Property Is100Percent2 As Boolean
			Get
				Return Me.C1Chart.ChartGroups(1).Is100Percent
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(1).Is100Percent = value
			End Set
		End Property

		' Token: 0x17000CE6 RID: 3302
		' (get) Token: 0x06003B58 RID: 15192 RVA: 0x00199669 File Offset: 0x00197869
		' (set) Token: 0x06003B59 RID: 15193 RVA: 0x00199686 File Offset: 0x00197886
		<oO0oooo("6008")>
		Public Property PieInnerRadius As Integer
			Get
				Return Me.C1Chart.ChartGroups(0).Pie.InnerRadius
			End Get
			Set(value As Integer)
				Me.C1Chart.ChartGroups(0).Pie.InnerRadius = value
			End Set
		End Property

		' Token: 0x17000CE7 RID: 3303
		' (get) Token: 0x06003B5A RID: 15194 RVA: 0x001996A4 File Offset: 0x001978A4
		' (set) Token: 0x06003B5B RID: 15195 RVA: 0x001996C1 File Offset: 0x001978C1
		<oO0oooo("6009")>
		Public Property PieInnerRadius2 As Integer
			Get
				Return Me.C1Chart.ChartGroups(1).Pie.InnerRadius
			End Get
			Set(value As Integer)
				Me.C1Chart.ChartGroups(1).Pie.InnerRadius = value
			End Set
		End Property

		' Token: 0x17000CE8 RID: 3304
		' (get) Token: 0x06003B5C RID: 15196 RVA: 0x001996DF File Offset: 0x001978DF
		' (set) Token: 0x06003B5D RID: 15197 RVA: 0x001996F7 File Offset: 0x001978F7
		<oO0oooo("0990.htm")>
		Public Property ChartType As ChartTypeEnum
			Get
				Return Me.C1Chart.ChartGroups(0).ChartType
			End Get
			Set(value As ChartTypeEnum)
				Me.C1Chart.ChartGroups(0).ChartType = value
			End Set
		End Property

		' Token: 0x17000CE9 RID: 3305
		' (get) Token: 0x06003B5E RID: 15198 RVA: 0x00199710 File Offset: 0x00197910
		' (set) Token: 0x06003B5F RID: 15199 RVA: 0x00199728 File Offset: 0x00197928
		<oO0oooo("01003")>
		Public Property ChartType2 As ChartTypeEnum
			Get
				Return Me.C1Chart.ChartGroups(1).ChartType
			End Get
			Set(value As ChartTypeEnum)
				Me.C1Chart.ChartGroups(1).ChartType = value
			End Set
		End Property

		' Token: 0x17000CEA RID: 3306
		' (get) Token: 0x06003B60 RID: 15200 RVA: 0x00199741 File Offset: 0x00197941
		' (set) Token: 0x06003B61 RID: 15201 RVA: 0x0019975E File Offset: 0x0019795E
		<oO0oooo("01003")>
		Public Property BarClusterWidth As Integer
			Get
				Return Me.C1Chart.ChartGroups(0).Bar.ClusterWidth
			End Get
			Set(value As Integer)
				Me.C1Chart.ChartGroups(0).Bar.ClusterWidth = value
			End Set
		End Property

		' Token: 0x17000CEB RID: 3307
		' (get) Token: 0x06003B62 RID: 15202 RVA: 0x0019977C File Offset: 0x0019797C
		' (set) Token: 0x06003B63 RID: 15203 RVA: 0x00199799 File Offset: 0x00197999
		<oO0oooo("1006")>
		Public Property BarClusterWidth2 As Integer
			Get
				Return Me.C1Chart.ChartGroups(1).Bar.ClusterWidth
			End Get
			Set(value As Integer)
				Me.C1Chart.ChartGroups(1).Bar.ClusterWidth = value
			End Set
		End Property

		' Token: 0x17000CEC RID: 3308
		' (get) Token: 0x06003B64 RID: 15204 RVA: 0x001997B7 File Offset: 0x001979B7
		' (set) Token: 0x06003B65 RID: 15205 RVA: 0x001997C9 File Offset: 0x001979C9
		<oO0oooo("0991")>
		Public Property LegendVisible As Boolean
			Get
				Return Me.C1Chart.Legend.Visible
			End Get
			Set(value As Boolean)
				Me.C1Chart.Legend.Visible = value
			End Set
		End Property

		' Token: 0x17000CED RID: 3309
		' (get) Token: 0x06003B66 RID: 15206 RVA: 0x001997DC File Offset: 0x001979DC
		' (set) Token: 0x06003B67 RID: 15207 RVA: 0x001997EE File Offset: 0x001979EE
		<oO0oooo("0992")>
		Public Property LegendCompass As CompassEnum
			Get
				Return Me.C1Chart.Legend.Compass
			End Get
			Set(value As CompassEnum)
				Me.C1Chart.Legend.Compass = value
			End Set
		End Property

		' Token: 0x17000CEE RID: 3310
		' (get) Token: 0x06003B68 RID: 15208 RVA: 0x00199801 File Offset: 0x00197A01
		' (set) Token: 0x06003B69 RID: 15209 RVA: 0x00199813 File Offset: 0x00197A13
		Public Property LegendText As String
			Get
				Return Me.C1Chart.Legend.Text
			End Get
			Set(value As String)
				Me.C1Chart.Legend.Text = value
			End Set
		End Property

		' Token: 0x17000CEF RID: 3311
		' (get) Token: 0x06003B6A RID: 15210 RVA: 0x00199826 File Offset: 0x00197A26
		' (set) Token: 0x06003B6B RID: 15211 RVA: 0x0019983D File Offset: 0x00197A3D
		Public Property LegendFont As Font
			Get
				Return Me.C1Chart.Legend.Style.Font
			End Get
			Set(value As Font)
				Me.C1Chart.Legend.Style.Font = value
			End Set
		End Property

		' Token: 0x17000CF0 RID: 3312
		' (get) Token: 0x06003B6C RID: 15212 RVA: 0x00199855 File Offset: 0x00197A55
		' (set) Token: 0x06003B6D RID: 15213 RVA: 0x00199867 File Offset: 0x00197A67
		Public Property HeaderText As String
			Get
				Return Me.C1Chart.Header.Text
			End Get
			Set(value As String)
				Me.C1Chart.Header.Text = value
				Me.C1Chart.Header.Visible = (Operators.CompareString(value, "", True) > 0)
			End Set
		End Property

		' Token: 0x17000CF1 RID: 3313
		' (get) Token: 0x06003B6E RID: 15214 RVA: 0x00199899 File Offset: 0x00197A99
		' (set) Token: 0x06003B6F RID: 15215 RVA: 0x001998B0 File Offset: 0x00197AB0
		Public Property HeaderFont As Font
			Get
				Return Me.C1Chart.Header.Style.Font
			End Get
			Set(value As Font)
				Me.C1Chart.Header.Style.Font = value
			End Set
		End Property

		' Token: 0x17000CF2 RID: 3314
		' (get) Token: 0x06003B70 RID: 15216 RVA: 0x001998C8 File Offset: 0x00197AC8
		' (set) Token: 0x06003B71 RID: 15217 RVA: 0x001998DA File Offset: 0x00197ADA
		Public Property FooterText As String
			Get
				Return Me.C1Chart.Footer.Text
			End Get
			Set(value As String)
				Me.C1Chart.Footer.Text = value
				Me.C1Chart.Footer.Visible = (Operators.CompareString(value, "", True) > 0)
			End Set
		End Property

		' Token: 0x17000CF3 RID: 3315
		' (get) Token: 0x06003B72 RID: 15218 RVA: 0x0019990C File Offset: 0x00197B0C
		' (set) Token: 0x06003B73 RID: 15219 RVA: 0x00199923 File Offset: 0x00197B23
		Public Property FooterFont As Font
			Get
				Return Me.C1Chart.Footer.Style.Font
			End Get
			Set(value As Font)
				Me.C1Chart.Footer.Style.Font = value
			End Set
		End Property

		' Token: 0x06003B74 RID: 15220 RVA: 0x0019993C File Offset: 0x00197B3C
		<oO0oooo("1008")>
		Public Sub Print(ScaleToPage As Boolean, ShowPrintDialog As Boolean)
			Dim printScaleEnum As PrintScaleEnum
			If ScaleToPage Then
				printScaleEnum = 3
			End If
			Me.C1Chart.PrintDialogUsage = ShowPrintDialog
			Me.C1Chart.PrintChart(printScaleEnum)
		End Sub

		' Token: 0x06003B75 RID: 15221 RVA: 0x00199966 File Offset: 0x00197B66
		<oO0oooo("1009")>
		Public Sub PageSetup()
			Me.C1Chart.PageSetup()
		End Sub

		' Token: 0x06003B76 RID: 15222 RVA: 0x00199973 File Offset: 0x00197B73
		<oO0oooo("1010")>
		Public Sub SaveImage(FileName As String)
			Me.SaveImage(FileName, O_O0OO.OoO_00._.(FileName))
		End Sub

		' Token: 0x06003B77 RID: 15223 RVA: 0x00199984 File Offset: 0x00197B84
		<oO0oooo("1010")>
		Public Sub SaveImage(FileName As String, ImageFormat As ImageFormat)
			If Not c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)) Then
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName))
			End If
			Me.C1Chart.SaveImage(FileName, ImageFormat)
		End Sub

		' Token: 0x06003B78 RID: 15224 RVA: 0x001999DE File Offset: 0x00197BDE
		Public Sub SaveImage(stream As Stream, ImageFormat As ImageFormat)
			Me.C1Chart.SaveImage(stream, ImageFormat)
		End Sub

		' Token: 0x06003B79 RID: 15225 RVA: 0x001999ED File Offset: 0x00197BED
		Public Sub SaveImage(stream As Stream, ImageFormat As ImageFormat, sz As Size)
			Me.C1Chart.SaveImage(stream, ImageFormat, sz)
		End Sub

		' Token: 0x06003B7A RID: 15226 RVA: 0x001999FD File Offset: 0x00197BFD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetImage(ImageFormat As ImageFormat) As Image
			Me.C1Chart.Style.Border.BorderStyle = 1
			Dim image As Image = Me.C1Chart.GetImage(ImageFormat)
			Me.C1Chart.Style.Border.BorderStyle = 3
			Return image
		End Function

		' Token: 0x06003B7B RID: 15227 RVA: 0x00199A37 File Offset: 0x00197C37
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetImage() As Image
			Return Me.GetImage(ImageFormat.Bmp)
		End Function

		' Token: 0x17000CF4 RID: 3316
		' (get) Token: 0x06003B7C RID: 15228 RVA: 0x00199A44 File Offset: 0x00197C44
		Public ReadOnly Property Image As Image
			Get
				Return Me.GetImage(ImageFormat.Wmf)
			End Get
		End Property

		' Token: 0x06003B7D RID: 15229 RVA: 0x00199A51 File Offset: 0x00197C51
		Public Sub CopyImage()
			c.OOOOO.o.().Clipboard.SetImage(Me.GetImage(ImageFormat.Bmp))
		End Sub

		' Token: 0x06003B7E RID: 15230 RVA: 0x00199A70 File Offset: 0x00197C70
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function CoordToDataIndex(CoodX As Integer, CoodY As Integer, ByRef SeriesIndex As Integer, ByRef PointIndex As Integer) As Boolean
			Dim num As Integer
			Dim flag As Boolean = Me.C1Chart.ChartGroups(0).CoordToDataIndex(CoodX, CoodY, 2, SeriesIndex, PointIndex, num)
			Return(CDbl(num) <= Math.Ceiling(CDbl(Me.C1Chart.ChartGroups(0).ChartData.SeriesList(SeriesIndex).SymbolStyle.Size) / 2.0) OrElse num <= 2) AndAlso flag
		End Function

		' Token: 0x06003B7F RID: 15231 RVA: 0x00199AE8 File Offset: 0x00197CE8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function CoordToDataIndex2(CoodX As Integer, CoodY As Integer, ByRef SeriesIndex As Integer, ByRef PointIndex As Integer) As Boolean
			Dim num As Integer
			Dim flag As Boolean = Me.C1Chart.ChartGroups(1).CoordToDataIndex(CoodX, CoodY, 2, SeriesIndex, PointIndex, num)
			Return(CDbl(num) <= Math.Ceiling(CDbl(Me.C1Chart.ChartGroups(1).ChartData.SeriesList(SeriesIndex).SymbolStyle.Size) / 2.0) OrElse num <= 2) AndAlso flag
		End Function

		' Token: 0x17000CF5 RID: 3317
		' (get) Token: 0x06003B80 RID: 15232 RVA: 0x00199B5F File Offset: 0x00197D5F
		' (set) Token: 0x06003B81 RID: 15233 RVA: 0x00199B7E File Offset: 0x00197D7E
		<oO0oooo("1242")>
		Public Property PrintWidth As Double
			Get
				Return CDbl((CSng(Me.C1Chart.Width) / SysInfo.ScreenDpiX)) * 25.4
			End Get
			Set(value As Double)
				Me.C1Chart.Width = CInt(Math.Round(value / 25.4 * CDbl(SysInfo.ScreenDpiX)))
			End Set
		End Property

		' Token: 0x17000CF6 RID: 3318
		' (get) Token: 0x06003B82 RID: 15234 RVA: 0x00199BA3 File Offset: 0x00197DA3
		' (set) Token: 0x06003B83 RID: 15235 RVA: 0x00199BC2 File Offset: 0x00197DC2
		<oO0oooo("1242")>
		Public Property PrintHeight As Double
			Get
				Return CDbl((CSng(Me.C1Chart.Height) / SysInfo.ScreenDpiY)) * 25.4
			End Get
			Set(value As Double)
				Me.C1Chart.Height = CInt(Math.Round(value / 25.4 * CDbl(SysInfo.ScreenDpiY)))
			End Set
		End Property

		' Token: 0x17000CF7 RID: 3319
		' (get) Token: 0x06003B84 RID: 15236 RVA: 0x00199BE7 File Offset: 0x00197DE7
		' (set) Token: 0x06003B85 RID: 15237 RVA: 0x00199C08 File Offset: 0x00197E08
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ColorName As String
			Get
				Return [Enum].GetName(GetType(ColorGeneration), Me.C1Chart.ColorGeneration)
			End Get
			Set(value As String)
				Dim colorGeneration As ColorGeneration
				If [Enum].TryParse(Of ColorGeneration)(value, colorGeneration) Then
					Me.C1Chart.ColorGeneration = colorGeneration
				End If
			End Set
		End Property

		' Token: 0x17000CF8 RID: 3320
		' (get) Token: 0x06003B86 RID: 15238 RVA: 0x00199C2B File Offset: 0x00197E2B
		<oO0oooo("6002")>
		Public ReadOnly Property ChartAreaStyle As Style
			Get
				Return Me.C1Chart.ChartArea.Style
			End Get
		End Property

		' Token: 0x17000CF9 RID: 3321
		' (get) Token: 0x06003B87 RID: 15239 RVA: 0x00199C3D File Offset: 0x00197E3D
		<oO0oooo("6002")>
		Public ReadOnly Property PlotAreaStyle As PlotArea
			Get
				Return Me.C1Chart.ChartArea.PlotArea
			End Get
		End Property

		' Token: 0x17000CFA RID: 3322
		' (get) Token: 0x06003B88 RID: 15240 RVA: 0x00199C4F File Offset: 0x00197E4F
		<oO0oooo("6002")>
		Public ReadOnly Property Style As Style
			Get
				Return Me.C1Chart.Style
			End Get
		End Property

		' Token: 0x17000CFB RID: 3323
		' (get) Token: 0x06003B89 RID: 15241 RVA: 0x00199C5C File Offset: 0x00197E5C
		' (set) Token: 0x06003B8A RID: 15242 RVA: 0x00199C74 File Offset: 0x00197E74
		<oO0oooo("6007")>
		Public Property ShowOutLine As Boolean
			Get
				Return Me.C1Chart.ChartGroups(0).ShowOutline
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(0).ShowOutline = value
			End Set
		End Property

		' Token: 0x17000CFC RID: 3324
		' (get) Token: 0x06003B8B RID: 15243 RVA: 0x00199C8D File Offset: 0x00197E8D
		' (set) Token: 0x06003B8C RID: 15244 RVA: 0x00199CA5 File Offset: 0x00197EA5
		<oO0oooo("6007")>
		Public Property ShowOutLine2 As Boolean
			Get
				Return Me.C1Chart.ChartGroups(1).ShowOutline
			End Get
			Set(value As Boolean)
				Me.C1Chart.ChartGroups(1).ShowOutline = value
			End Set
		End Property

		' Token: 0x17000CFD RID: 3325
		' (get) Token: 0x06003B8D RID: 15245 RVA: 0x00199CBE File Offset: 0x00197EBE
		' (set) Token: 0x06003B8E RID: 15246 RVA: 0x00199CD6 File Offset: 0x00197ED6
		<oO0oooo("6007")>
		Public Property OutLineColor As Color
			Get
				Return Me.C1Chart.ChartGroups(0).OutlineColor
			End Get
			Set(value As Color)
				Me.C1Chart.ChartGroups(0).OutlineColor = value
			End Set
		End Property

		' Token: 0x17000CFE RID: 3326
		' (get) Token: 0x06003B8F RID: 15247 RVA: 0x00199CEF File Offset: 0x00197EEF
		' (set) Token: 0x06003B90 RID: 15248 RVA: 0x00199D07 File Offset: 0x00197F07
		<oO0oooo("6007")>
		Public Property OutLineColor2 As Color
			Get
				Return Me.C1Chart.ChartGroups(1).OutlineColor
			End Get
			Set(value As Color)
				Me.C1Chart.ChartGroups(1).OutlineColor = value
			End Set
		End Property

		' Token: 0x17000CFF RID: 3327
		' (get) Token: 0x06003B91 RID: 15249 RVA: 0x00199D20 File Offset: 0x00197F20
		Public ReadOnly Property LegendStyle As Style
			Get
				Return Me.C1Chart.Legend.Style
			End Get
		End Property

		' Token: 0x17000D00 RID: 3328
		' (get) Token: 0x06003B92 RID: 15250 RVA: 0x00199D32 File Offset: 0x00197F32
		Public ReadOnly Property HeaderStyle As Style
			Get
				Return Me.C1Chart.Header.Style
			End Get
		End Property

		' Token: 0x17000D01 RID: 3329
		' (get) Token: 0x06003B93 RID: 15251 RVA: 0x00199D44 File Offset: 0x00197F44
		Public ReadOnly Property FooterStyle As Style
			Get
				Return Me.C1Chart.Footer.Style
			End Get
		End Property

		' Token: 0x17000D02 RID: 3330
		' (get) Token: 0x06003B94 RID: 15252 RVA: 0x00199D56 File Offset: 0x00197F56
		' (set) Token: 0x06003B95 RID: 15253 RVA: 0x00199D63 File Offset: 0x00197F63
		Public Property ColorGeneration As ColorGeneration
			Get
				Return Me.C1Chart.ColorGeneration
			End Get
			Set(value As ColorGeneration)
				Me.C1Chart.ColorGeneration = value
			End Set
		End Property

		' Token: 0x17000D03 RID: 3331
		' (get) Token: 0x06003B96 RID: 15254 RVA: 0x00199D71 File Offset: 0x00197F71
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property PointStyles1 As PointStylesCollection
			Get
				Return Me.C1Chart.ChartGroups(0).ChartData.PointStylesList
			End Get
		End Property

		' Token: 0x17000D04 RID: 3332
		' (get) Token: 0x06003B97 RID: 15255 RVA: 0x00199D8E File Offset: 0x00197F8E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property PointStyles2 As PointStylesCollection
			Get
				Return Me.C1Chart.ChartGroups(0).ChartData.PointStylesList
			End Get
		End Property

		' Token: 0x17000D05 RID: 3333
		' (set) Token: 0x06003B98 RID: 15256 RVA: 0x00199DAC File Offset: 0x00197FAC
		Public WriteOnly Property Transparent As Boolean
			Set(value As Boolean)
				If value Then
					Me.Style.Border.BorderStyle = 1
					Me.ChartAreaStyle.Border.BorderStyle = 1
					Me.Style.BackColor = Color.Transparent
					Me.ChartAreaStyle.BackColor = Color.Transparent
					Me.PlotAreaStyle.BackColor = Color.Transparent
				End If
			End Set
		End Property

		' Token: 0x04001863 RID: 6243
		<AccessedThroughProperty("C1Chart")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Chart

		' Token: 0x04001864 RID: 6244
		Private <<EMPTY_NAME>> As ChartAxis

		' Token: 0x04001865 RID: 6245
		Private <<EMPTY_NAME>> As ChartAxis

		' Token: 0x04001866 RID: 6246
		Private <<EMPTY_NAME>> As ChartAxis

		' Token: 0x04001867 RID: 6247
		Private <<EMPTY_NAME>> As ChartSerialCollection

		' Token: 0x04001868 RID: 6248
		Private <<EMPTY_NAME>> As ChartSerialCollection

		' Token: 0x04001869 RID: 6249
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400186A RID: 6250
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400186B RID: 6251
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
