Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000501 RID: 1281
	<ComVisible(True)>
	Public Class ChartSerialCollection
		' Token: 0x0600533E RID: 21310 RVA: 0x0021D0D3 File Offset: 0x0021B2D3
		Public Sub New(A_0 As ChartDataSeriesCollection, A_1 As C1Chart)
			Me.oO0Oo._o_O_. = A_0
			Me.oO0Oo._o_O_. = A_1
		End Sub

		' Token: 0x17001377 RID: 4983
		Public ReadOnly Default Property Item(Index As Integer) As ChartSeries
			Get
				Return New ChartSeries(Me.oO0Oo._o_O_.(Index))
			End Get
		End Property

		' Token: 0x06005340 RID: 21312 RVA: 0x0021D0FC File Offset: 0x0021B2FC
		Public Function Add() As ChartSeries
			Dim chartDataSeries As ChartDataSeries = Me.oO0Oo._o_O_..AddNewSeries()
			chartDataSeries.Histogram.IntervalCreationMethod = 1
			chartDataSeries.DataLabel.Compass = 10
			chartDataSeries.DataLabel.Visible = True
			Return New ChartSeries(chartDataSeries)
		End Function

		' Token: 0x06005341 RID: 21313 RVA: 0x0021D140 File Offset: 0x0021B340
		Public Sub Clear()
			Me.oO0Oo._o_O_..RemoveAll()
		End Sub

		' Token: 0x06005342 RID: 21314 RVA: 0x0021D14D File Offset: 0x0021B34D
		Public Sub Remove(Series As ChartSeries)
			Me.oO0Oo._o_O_..Remove(Series.BaseSeries)
		End Sub

		' Token: 0x06005343 RID: 21315 RVA: 0x0021D160 File Offset: 0x0021B360
		Public Sub RemoveAt(Index As Integer)
			Me.oO0Oo._o_O_..RemoveAt(Index)
		End Sub

		' Token: 0x17001378 RID: 4984
		' (get) Token: 0x06005344 RID: 21316 RVA: 0x0021D16E File Offset: 0x0021B36E
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oO0Oo._o_O_..Count
			End Get
		End Property

		' Token: 0x06005345 RID: 21317 RVA: 0x0021D17C File Offset: 0x0021B37C
		Public Sub AddGanttSeries(taskName As String, startTime As DateTime, endTime As DateTime)
			Dim chartDataSeries As ChartDataSeries = Me.oO0Oo._o_O_..AddNewSeries()
			chartDataSeries.Label = taskName
			chartDataSeries.Y.CopyDataIn(New DateTime() { startTime })
			chartDataSeries.Y1.CopyDataIn(New DateTime() { endTime })
		End Sub

		' Token: 0x06005346 RID: 21318 RVA: 0x0021D1D0 File Offset: 0x0021B3D0
		Public Sub AddGanttSeries(taskName As String, startTimes As DateTime(), endTimes As DateTime())
			Dim chartDataSeries As ChartDataSeries = Me.oO0Oo._o_O_..AddNewSeries()
			chartDataSeries.Label = taskName
			chartDataSeries.Y.CopyDataIn(startTimes)
			chartDataSeries.Y1.CopyDataIn(endTimes)
		End Sub

		' Token: 0x06005347 RID: 21319 RVA: 0x0021D200 File Offset: 0x0021B400
		Public Sub AddGanttLabels(FormatString As String)
			Dim chartLabels As ChartLabels = Me.oO0Oo._o_O_..ChartLabels
			chartLabels.DefaultLabelStyle.BackColor = Color.Transparent
			chartLabels.DefaultLabelStyle.GradientStyle = 0
			chartLabels.DefaultLabelStyle.ForeColor = Color.Azure
			chartLabels.DefaultLabelStyle.HorizontalAlignment = 3
			Dim labelsCollection As LabelsCollection = chartLabels.LabelsCollection
			labelsCollection.Clear()
			Dim count As Integer = Me.oO0Oo._o_O_..Count
			Dim num As Integer = Me.oO0Oo._o_O_..Count - 1
			For i As Integer = 0 To num
				Dim chartDataSeries As ChartDataSeries = Me.oO0Oo._o_O_.(i)
				Dim num2 As Integer = chartDataSeries.Length - 1
				For j As Integer = 0 To num2
					Dim label As Label = labelsCollection.AddNewLabel()
					Dim dateTime As DateTime = Conversions.ToDate(chartDataSeries.Y(j))
					Dim dateTime2 As DateTime = Conversions.ToDate(chartDataSeries.Y1(j))
					label.Text = dateTime.ToString(FormatString) + "-" + dateTime2.ToString(FormatString)
					label.AttachMethod = 2
					label.AttachMethodData.GroupIndex = 0
					label.AttachMethodData.SeriesIndex = i
					label.AttachMethodData.PointIndex = j
					label.Compass = 6
					label.Offset = 0
					label.Visible = True
				Next
			Next
		End Sub

		' Token: 0x040021C0 RID: 8640
		Private <<EMPTY_NAME>> As ChartDataSeriesCollection

		' Token: 0x040021C1 RID: 8641
		Private <<EMPTY_NAME>> As C1Chart
	End Class
End Namespace
