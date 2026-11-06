Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart

Namespace Foxtable.WinForm
	' Token: 0x02000502 RID: 1282
	<ComVisible(True)>
	Public Class ChartSeries
		' Token: 0x06005348 RID: 21320 RVA: 0x0021D344 File Offset: 0x0021B544
		Public Sub New(A_0 As ChartDataSeries)
			Me.o0.00O. = A_0
			Me.oO0Oo._o_O_. = New ChartDataArray(Me.o0.00O..X)
			Me.oOoo__O.o0_o0. = New ChartDataArray(Me.o0.00O..Y)
			Me.O_.oO_0____. = New ChartDataArray(Me.o0.00O..Y1)
			Me.O0_o.OO0Oo0___. = New ChartDataArray(Me.o0.00O..Y2)
			Me.o_0oO00OOo.oo. = New ChartDataArray(Me.o0.00O..Y3)
		End Sub

		' Token: 0x17001379 RID: 4985
		' (get) Token: 0x06005349 RID: 21321 RVA: 0x0021D3CC File Offset: 0x0021B5CC
		Friend ReadOnly Property BaseSeries As ChartDataSeries
			Get
				Return Me.o0.00O.
			End Get
		End Property

		' Token: 0x1700137A RID: 4986
		' (get) Token: 0x0600534A RID: 21322 RVA: 0x0021D3D4 File Offset: 0x0021B5D4
		' (set) Token: 0x0600534B RID: 21323 RVA: 0x0021D3E1 File Offset: 0x0021B5E1
		<oO0oooo("1035")>
		Public Property Text As String
			Get
				Return Me.o0.00O..Label
			End Get
			Set(value As String)
				Me.o0.00O..Label = value
			End Set
		End Property

		' Token: 0x1700137B RID: 4987
		' (get) Token: 0x0600534C RID: 21324 RVA: 0x0021D3EF File Offset: 0x0021B5EF
		' (set) Token: 0x0600534D RID: 21325 RVA: 0x0021D3FC File Offset: 0x0021B5FC
		<oO0oooo("1036")>
		Public Property TooltipText As String
			Get
				Return Me.o0.00O..TooltipText
			End Get
			Set(value As String)
				Me.o0.00O..TooltipText = value
			End Set
		End Property

		' Token: 0x1700137C RID: 4988
		' (get) Token: 0x0600534E RID: 21326 RVA: 0x0021D40A File Offset: 0x0021B60A
		' (set) Token: 0x0600534F RID: 21327 RVA: 0x0021D417 File Offset: 0x0021B617
		Public Property TooltipTextLegend As String
			Get
				Return Me.o0.00O..TooltipTextLegend
			End Get
			Set(value As String)
				Me.o0.00O..TooltipTextLegend = value
			End Set
		End Property

		' Token: 0x1700137D RID: 4989
		' (get) Token: 0x06005350 RID: 21328 RVA: 0x0021D425 File Offset: 0x0021B625
		' (set) Token: 0x06005351 RID: 21329 RVA: 0x0021D432 File Offset: 0x0021B632
		Public Property LegendEntry As Boolean
			Get
				Return Me.o0.00O..LegendEntry
			End Get
			Set(value As Boolean)
				Me.o0.00O..LegendEntry = value
			End Set
		End Property

		' Token: 0x1700137E RID: 4990
		' (get) Token: 0x06005352 RID: 21330 RVA: 0x0021D440 File Offset: 0x0021B640
		' (set) Token: 0x06005353 RID: 21331 RVA: 0x0021D44D File Offset: 0x0021B64D
		Public Property DisplayType As DisplayTypeEnum
			Get
				Return Me.o0.00O..Display
			End Get
			Set(value As DisplayTypeEnum)
				Me.o0.00O..Display = value
			End Set
		End Property

		' Token: 0x1700137F RID: 4991
		' (get) Token: 0x06005354 RID: 21332 RVA: 0x0021D45B File Offset: 0x0021B65B
		' (set) Token: 0x06005355 RID: 21333 RVA: 0x0021D468 File Offset: 0x0021B668
		<oO0oooo("1038")>
		Public Property FitType As FitTypeEnum
			Get
				Return Me.o0.00O..FitType
			End Get
			Set(value As FitTypeEnum)
				Me.o0.00O..FitType = value
			End Set
		End Property

		' Token: 0x17001380 RID: 4992
		' (get) Token: 0x06005356 RID: 21334 RVA: 0x0021D476 File Offset: 0x0021B676
		' (set) Token: 0x06005357 RID: 21335 RVA: 0x0021D484 File Offset: 0x0021B684
		<oO0oooo("")>
		Public Property Length As Integer
			Get
				Return Me.o0.00O..Length
			End Get
			Set(value As Integer)
				Me.o0.00O..PointData.Length = value
				Me.o0.00O..Y1.Length = value
				Me.o0.00O..Y2.Length = value
				Me.o0.00O..Y3.Length = value
			End Set
		End Property

		' Token: 0x17001381 RID: 4993
		' (get) Token: 0x06005358 RID: 21336 RVA: 0x0021D4D5 File Offset: 0x0021B6D5
		' (set) Token: 0x06005359 RID: 21337 RVA: 0x0021D4E7 File Offset: 0x0021B6E7
		Public Property FillColor As Color
			Get
				Return Me.o0.00O..FillStyle.Color1
			End Get
			Set(value As Color)
				Me.o0.00O..FillStyle.Color1 = value
			End Set
		End Property

		' Token: 0x17001382 RID: 4994
		' (get) Token: 0x0600535A RID: 21338 RVA: 0x0021D4FA File Offset: 0x0021B6FA
		' (set) Token: 0x0600535B RID: 21339 RVA: 0x0021D50C File Offset: 0x0021B70C
		<oO0oooo("1039")>
		Public Property LineColor As Color
			Get
				Return Me.o0.00O..LineStyle.Color
			End Get
			Set(value As Color)
				Me.o0.00O..LineStyle.Color = value
			End Set
		End Property

		' Token: 0x17001383 RID: 4995
		' (get) Token: 0x0600535C RID: 21340 RVA: 0x0021D51F File Offset: 0x0021B71F
		' (set) Token: 0x0600535D RID: 21341 RVA: 0x0021D531 File Offset: 0x0021B731
		Public Property LineThickNess As Integer
			Get
				Return Me.o0.00O..LineStyle.Thickness
			End Get
			Set(value As Integer)
				Me.o0.00O..LineStyle.Thickness = value
			End Set
		End Property

		' Token: 0x17001384 RID: 4996
		' (get) Token: 0x0600535E RID: 21342 RVA: 0x0021D544 File Offset: 0x0021B744
		' (set) Token: 0x0600535F RID: 21343 RVA: 0x0021D556 File Offset: 0x0021B756
		<oO0oooo("1041")>
		Public Property LinePattern As LinePatternEnum
			Get
				Return Me.o0.00O..LineStyle.Pattern
			End Get
			Set(value As LinePatternEnum)
				Me.o0.00O..LineStyle.Pattern = value
			End Set
		End Property

		' Token: 0x17001385 RID: 4997
		' (get) Token: 0x06005360 RID: 21344 RVA: 0x0021D569 File Offset: 0x0021B769
		' (set) Token: 0x06005361 RID: 21345 RVA: 0x0021D57B File Offset: 0x0021B77B
		<oO0oooo("1043")>
		Public Property MarkColor As Color
			Get
				Return Me.o0.00O..SymbolStyle.Color
			End Get
			Set(value As Color)
				Me.o0.00O..SymbolStyle.Color = value
			End Set
		End Property

		' Token: 0x17001386 RID: 4998
		' (get) Token: 0x06005362 RID: 21346 RVA: 0x0021D58E File Offset: 0x0021B78E
		' (set) Token: 0x06005363 RID: 21347 RVA: 0x0021D5A0 File Offset: 0x0021B7A0
		<oO0oooo("1043")>
		Public Property MarkSize As Integer
			Get
				Return Me.o0.00O..SymbolStyle.Size
			End Get
			Set(value As Integer)
				Me.o0.00O..SymbolStyle.Size = value
			End Set
		End Property

		' Token: 0x17001387 RID: 4999
		' (get) Token: 0x06005364 RID: 21348 RVA: 0x0021D5B3 File Offset: 0x0021B7B3
		' (set) Token: 0x06005365 RID: 21349 RVA: 0x0021D5C5 File Offset: 0x0021B7C5
		<oO0oooo("1043")>
		Public Property MarkShape As MarkShapeEnum
			Get
				Return Me.o0.00O..SymbolStyle.Shape
			End Get
			Set(value As MarkShapeEnum)
				Me.o0.00O..SymbolStyle.Shape = value
			End Set
		End Property

		' Token: 0x17001388 RID: 5000
		' (get) Token: 0x06005366 RID: 21350 RVA: 0x0021D5D8 File Offset: 0x0021B7D8
		' (set) Token: 0x06005367 RID: 21351 RVA: 0x0021D5EA File Offset: 0x0021B7EA
		Public Property MarkBorderColor As Color
			Get
				Return Me.o0.00O..SymbolStyle.OutlineColor
			End Get
			Set(value As Color)
				Me.o0.00O..SymbolStyle.OutlineColor = value
			End Set
		End Property

		' Token: 0x17001389 RID: 5001
		' (get) Token: 0x06005368 RID: 21352 RVA: 0x0021D5FD File Offset: 0x0021B7FD
		' (set) Token: 0x06005369 RID: 21353 RVA: 0x0021D60F File Offset: 0x0021B80F
		Public Property MarkBorderWidth As Integer
			Get
				Return Me.o0.00O..SymbolStyle.OutlineWidth
			End Get
			Set(value As Integer)
				Me.o0.00O..SymbolStyle.OutlineWidth = value
			End Set
		End Property

		' Token: 0x1700138A RID: 5002
		' (get) Token: 0x0600536A RID: 21354 RVA: 0x0021D622 File Offset: 0x0021B822
		Public ReadOnly Property X As ChartDataArray
			Get
				Return Me.oO0Oo._o_O_.
			End Get
		End Property

		' Token: 0x1700138B RID: 5003
		' (get) Token: 0x0600536B RID: 21355 RVA: 0x0021D62A File Offset: 0x0021B82A
		Public ReadOnly Property Y As ChartDataArray
			Get
				Return Me.oOoo__O.o0_o0.
			End Get
		End Property

		' Token: 0x1700138C RID: 5004
		' (get) Token: 0x0600536C RID: 21356 RVA: 0x0021D632 File Offset: 0x0021B832
		Public ReadOnly Property Y1 As ChartDataArray
			Get
				Return Me.O_.oO_0____.
			End Get
		End Property

		' Token: 0x1700138D RID: 5005
		' (get) Token: 0x0600536D RID: 21357 RVA: 0x0021D63A File Offset: 0x0021B83A
		Public ReadOnly Property Y2 As ChartDataArray
			Get
				Return Me.O0_o.OO0Oo0___.
			End Get
		End Property

		' Token: 0x1700138E RID: 5006
		' (get) Token: 0x0600536E RID: 21358 RVA: 0x0021D642 File Offset: 0x0021B842
		Public ReadOnly Property Y3 As ChartDataArray
			Get
				Return Me.o_0oO00OOo.oo.
			End Get
		End Property

		' Token: 0x1700138F RID: 5007
		' (get) Token: 0x0600536F RID: 21359 RVA: 0x0021D64A File Offset: 0x0021B84A
		' (set) Token: 0x06005370 RID: 21360 RVA: 0x0021D657 File Offset: 0x0021B857
		Public Property Offset As Integer
			Get
				Return Me.o0.00O..Offset
			End Get
			Set(value As Integer)
				Me.o0.00O..Offset = value
			End Set
		End Property

		' Token: 0x17001390 RID: 5008
		' (get) Token: 0x06005371 RID: 21361 RVA: 0x0021D665 File Offset: 0x0021B865
		<oO0oooo("0981")>
		Public ReadOnly Property Histogram As ChartHistogram
			Get
				If Me.a Is Nothing Then
					Me.a = New ChartHistogram(Me.o0.00O.)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17001391 RID: 5009
		' (get) Token: 0x06005372 RID: 21362 RVA: 0x0021D686 File Offset: 0x0021B886
		' (set) Token: 0x06005373 RID: 21363 RVA: 0x0021D698 File Offset: 0x0021B898
		<oO0oooo("0981")>
		Public Property HistogramType As HistogramTypeEnum
			Get
				Return Me.o0.00O..Histogram.DisplayType
			End Get
			Set(value As HistogramTypeEnum)
				Me.o0.00O..Histogram.DisplayType = value
			End Set
		End Property

		' Token: 0x17001392 RID: 5010
		' (get) Token: 0x06005374 RID: 21364 RVA: 0x0021D6AB File Offset: 0x0021B8AB
		' (set) Token: 0x06005375 RID: 21365 RVA: 0x0021D6BD File Offset: 0x0021B8BD
		<oO0oooo("1049")>
		Public Property DataLabelText As String
			Get
				Return Me.o0.00O..DataLabel.Text
			End Get
			Set(value As String)
				Me.o0.00O..DataLabel.Text = value
			End Set
		End Property

		' Token: 0x17001393 RID: 5011
		' (get) Token: 0x06005376 RID: 21366 RVA: 0x0021D6D0 File Offset: 0x0021B8D0
		' (set) Token: 0x06005377 RID: 21367 RVA: 0x0021D6E2 File Offset: 0x0021B8E2
		Public Property DataLabelVisible As Boolean
			Get
				Return Me.o0.00O..DataLabel.Visible
			End Get
			Set(value As Boolean)
				Me.o0.00O..DataLabel.Visible = value
			End Set
		End Property

		' Token: 0x17001394 RID: 5012
		' (get) Token: 0x06005378 RID: 21368 RVA: 0x0021D6F5 File Offset: 0x0021B8F5
		' (set) Token: 0x06005379 RID: 21369 RVA: 0x0021D70C File Offset: 0x0021B90C
		<oO0oooo("1051")>
		Public Property DataLabelBackColor As Color
			Get
				Return Me.o0.00O..DataLabel.Style.BackColor
			End Get
			Set(value As Color)
				Me.o0.00O..DataLabel.Style.BackColor = value
			End Set
		End Property

		' Token: 0x17001395 RID: 5013
		' (get) Token: 0x0600537A RID: 21370 RVA: 0x0021D724 File Offset: 0x0021B924
		' (set) Token: 0x0600537B RID: 21371 RVA: 0x0021D73B File Offset: 0x0021B93B
		<oO0oooo("1051")>
		Public Property DataLabelForeColor As Color
			Get
				Return Me.o0.00O..DataLabel.Style.ForeColor
			End Get
			Set(value As Color)
				Me.o0.00O..DataLabel.Style.ForeColor = value
			End Set
		End Property

		' Token: 0x17001396 RID: 5014
		' (get) Token: 0x0600537C RID: 21372 RVA: 0x0021D753 File Offset: 0x0021B953
		' (set) Token: 0x0600537D RID: 21373 RVA: 0x0021D775 File Offset: 0x0021B975
		Public Property DataLabelBorder As Boolean
			Get
				Return Me.o0.00O..DataLabel.Style.Border.BorderStyle <> 1
			End Get
			Set(value As Boolean)
				If value Then
					Me.o0.00O..DataLabel.Style.Border.BorderStyle = 3
					Return
				End If
				Me.o0.00O..DataLabel.Style.Border.BorderStyle = 1
			End Set
		End Property

		' Token: 0x17001397 RID: 5015
		' (get) Token: 0x0600537E RID: 21374 RVA: 0x0021D7B1 File Offset: 0x0021B9B1
		' (set) Token: 0x0600537F RID: 21375 RVA: 0x0021D7CD File Offset: 0x0021B9CD
		Public Property DataLabelBorderColor As Color
			Get
				Return Me.o0.00O..DataLabel.Style.Border.Color
			End Get
			Set(value As Color)
				Me.o0.00O..DataLabel.Style.Border.Color = value
			End Set
		End Property

		' Token: 0x17001398 RID: 5016
		' (get) Token: 0x06005380 RID: 21376 RVA: 0x0021D7EA File Offset: 0x0021B9EA
		' (set) Token: 0x06005381 RID: 21377 RVA: 0x0021D7FC File Offset: 0x0021B9FC
		Public Property DataLabelConnected As Boolean
			Get
				Return Me.o0.00O..DataLabel.Connected
			End Get
			Set(value As Boolean)
				Me.o0.00O..DataLabel.Connected = value
			End Set
		End Property

		' Token: 0x17001399 RID: 5017
		' (get) Token: 0x06005382 RID: 21378 RVA: 0x0021D80F File Offset: 0x0021BA0F
		' (set) Token: 0x06005383 RID: 21379 RVA: 0x0021D821 File Offset: 0x0021BA21
		<oO0oooo("1056")>
		Public Property DataLabelCompass As LabelCompassEnum
			Get
				Return Me.o0.00O..DataLabel.Compass
			End Get
			Set(value As LabelCompassEnum)
				Me.o0.00O..DataLabel.Compass = value
			End Set
		End Property

		' Token: 0x1700139A RID: 5018
		' (get) Token: 0x06005384 RID: 21380 RVA: 0x0021D839 File Offset: 0x0021BA39
		' (set) Token: 0x06005385 RID: 21381 RVA: 0x0021D84B File Offset: 0x0021BA4B
		<oO0oooo("6010")>
		Public Property DataLabelOffset As Integer
			Get
				Return Me.o0.00O..DataLabel.Offset
			End Get
			Set(value As Integer)
				Me.o0.00O..DataLabel.Offset = value
			End Set
		End Property

		' Token: 0x040021C2 RID: 8642
		Private <<EMPTY_NAME>> As ChartDataSeries

		' Token: 0x040021C3 RID: 8643
		Private <<EMPTY_NAME>> As ChartDataArray

		' Token: 0x040021C4 RID: 8644
		Private <<EMPTY_NAME>> As ChartDataArray

		' Token: 0x040021C5 RID: 8645
		Private <<EMPTY_NAME>> As ChartDataArray

		' Token: 0x040021C6 RID: 8646
		Private <<EMPTY_NAME>> As ChartDataArray

		' Token: 0x040021C7 RID: 8647
		Private <<EMPTY_NAME>> As ChartDataArray

		' Token: 0x040021C8 RID: 8648
		Private a As ChartHistogram
	End Class
End Namespace
