Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.Sparkline
Imports Microsoft.VisualBasic

Namespace Foxtable
	' Token: 0x02000084 RID: 132
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("3740")>
	Public Class CellChart
		Inherits C1Sparkline

		' Token: 0x060004A9 RID: 1193 RVA: 0x0001B53B File Offset: 0x0001973B
		Public Sub New()
			Me.Values = New List(Of Double)()
			Me.MarkerLineColor = Me.AxisColor
			Me.MarkerLineWeight = 1F
			Me.Oo_O._o__. = Double.MinValue
			Me.Space = 1
		End Sub

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x060004AA RID: 1194 RVA: 0x0001B57B File Offset: 0x0001977B
		' (set) Token: 0x060004AB RID: 1195 RVA: 0x0001B583 File Offset: 0x00019783
		Public Property Values As List(Of Double)

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x060004AC RID: 1196 RVA: 0x0001B58C File Offset: 0x0001978C
		' (set) Token: 0x060004AD RID: 1197 RVA: 0x0001B594 File Offset: 0x00019794
		Public Property MarkerLineValue As Double

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x060004AE RID: 1198 RVA: 0x0001B59D File Offset: 0x0001979D
		' (set) Token: 0x060004AF RID: 1199 RVA: 0x0001B5A5 File Offset: 0x000197A5
		Public Property MarkerLineColor As Color

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001B5AE File Offset: 0x000197AE
		' (set) Token: 0x060004B1 RID: 1201 RVA: 0x0001B5B6 File Offset: 0x000197B6
		Public Property MarkerLineWeight As Single

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001B5BF File Offset: 0x000197BF
		' (set) Token: 0x060004B3 RID: 1203 RVA: 0x0001B5C7 File Offset: 0x000197C7
		<oO0oooo("3754")>
		Public Property StartingValue As Double
			Get
				Return Me.Oo_O._o__.
			End Get
			Set(value As Double)
				Me.Oo_O._o__. = value
			End Set
		End Property

		' Token: 0x060004B4 RID: 1204 RVA: 0x0001B5D0 File Offset: 0x000197D0
		<oO0oooo("3741")>
		Public Sub AddValues(values As IEnumerable(Of Object))
			Try
				For Each obj As Object In values
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
					Me.Values.Add(Conversion.Val(RuntimeHelpers.GetObjectValue(objectValue)))
				Next
			Finally
				Dim enumerator As IEnumerator(Of Object)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060004B5 RID: 1205 RVA: 0x0001B62C File Offset: 0x0001982C
		<oO0oooo("3741")>
		Public Sub AddValues(ParamArray values As Object())
			' The following expression was wrapped in a checked-statement
			For i As Integer = 0 To values.Length - 1
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(values(i))
				If TypeOf objectValue Is IEnumerable(Of Object) Then
					Me.AddValues(CType(objectValue, IEnumerable(Of Object)))
				Else
					Me.Values.Add(Conversion.Val(RuntimeHelpers.GetObjectValue(objectValue)))
				End If
			Next
		End Sub

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x060004B6 RID: 1206 RVA: 0x0001B67E File Offset: 0x0001987E
		' (set) Token: 0x060004B7 RID: 1207 RVA: 0x0001B68B File Offset: 0x0001988B
		Public Property AxisColor As Color
			Get
				Return MyBase.Styles.AxisColor
			End Get
			Set(value As Color)
				MyBase.Styles.AxisColor = value
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x060004B8 RID: 1208 RVA: 0x0001B699 File Offset: 0x00019899
		' (set) Token: 0x060004B9 RID: 1209 RVA: 0x0001B6A6 File Offset: 0x000198A6
		Public Property BarDistance As Integer
			Get
				Return MyBase.Styles.BarDistance
			End Get
			Set(value As Integer)
				MyBase.Styles.BarDistance = value
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x060004BA RID: 1210 RVA: 0x0001B6B4 File Offset: 0x000198B4
		' (set) Token: 0x060004BB RID: 1211 RVA: 0x0001B6C1 File Offset: 0x000198C1
		Public Property FirstMarkerColor As Color
			Get
				Return MyBase.Styles.FirstMarkerColor
			End Get
			Set(value As Color)
				MyBase.Styles.FirstMarkerColor = value
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x060004BC RID: 1212 RVA: 0x0001B6CF File Offset: 0x000198CF
		' (set) Token: 0x060004BD RID: 1213 RVA: 0x0001B6DC File Offset: 0x000198DC
		Public Property HighMarkerColor As Color
			Get
				Return MyBase.Styles.HighMarkerColor
			End Get
			Set(value As Color)
				MyBase.Styles.HighMarkerColor = value
			End Set
		End Property

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x060004BE RID: 1214 RVA: 0x0001B6EA File Offset: 0x000198EA
		' (set) Token: 0x060004BF RID: 1215 RVA: 0x0001B6F7 File Offset: 0x000198F7
		Public Property LastMarkerColor As Color
			Get
				Return MyBase.Styles.LastMarkerColor
			End Get
			Set(value As Color)
				MyBase.Styles.LastMarkerColor = value
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001B705 File Offset: 0x00019905
		' (set) Token: 0x060004C1 RID: 1217 RVA: 0x0001B712 File Offset: 0x00019912
		Public Property LowMarkerColor As Color
			Get
				Return MyBase.Styles.LowMarkerColor
			End Get
			Set(value As Color)
				MyBase.Styles.LowMarkerColor = value
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x060004C2 RID: 1218 RVA: 0x0001B720 File Offset: 0x00019920
		' (set) Token: 0x060004C3 RID: 1219 RVA: 0x0001B72D File Offset: 0x0001992D
		Public Property MarkersColor As Color
			Get
				Return MyBase.Styles.MarkersColor
			End Get
			Set(value As Color)
				MyBase.Styles.MarkersColor = value
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001B73B File Offset: 0x0001993B
		' (set) Token: 0x060004C5 RID: 1221 RVA: 0x0001B748 File Offset: 0x00019948
		Public Property NegativeColor As Color
			Get
				Return MyBase.Styles.NegativeColor
			End Get
			Set(value As Color)
				MyBase.Styles.NegativeColor = value
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001B756 File Offset: 0x00019956
		' (set) Token: 0x060004C7 RID: 1223 RVA: 0x0001B763 File Offset: 0x00019963
		Public Property SeriesColor As Color
			Get
				Return MyBase.Styles.SeriesColor
			End Get
			Set(value As Color)
				MyBase.Styles.SeriesColor = value
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001B771 File Offset: 0x00019971
		' (set) Token: 0x060004C9 RID: 1225 RVA: 0x0001B77E File Offset: 0x0001997E
		Public Property LineWeight As Double
			Get
				Return MyBase.Styles.LineWeight
			End Get
			Set(value As Double)
				MyBase.Styles.LineWeight = value
			End Set
		End Property

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x060004CA RID: 1226 RVA: 0x0001B78C File Offset: 0x0001998C
		' (set) Token: 0x060004CB RID: 1227 RVA: 0x0001B794 File Offset: 0x00019994
		Public Property ChartType As SparklineType
			Get
				Return MyBase.SparklineType
			End Get
			Set(value As SparklineType)
				MyBase.SparklineType = value
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x060004CC RID: 1228 RVA: 0x0001B79D File Offset: 0x0001999D
		' (set) Token: 0x060004CD RID: 1229 RVA: 0x0001B7A5 File Offset: 0x000199A5
		Public Property Space As Integer

		' Token: 0x060004CE RID: 1230 RVA: 0x0001B7B0 File Offset: 0x000199B0
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As PaintEventArgs)
			MyBase.OnPaint(A_0)
			If Me.MarkerLineValue <> 0.0 AndAlso Me.Values.Count > 1 Then
				Dim pen As Pen
				If Me.MarkerLineColor.A = 255 Then
					pen = New Pen(Color.FromArgb(168, CInt(Me.MarkerLineColor.R), CInt(Me.MarkerLineColor.G), CInt(Me.MarkerLineColor.B)))
				Else
					pen = New Pen(Me.MarkerLineColor)
				End If
				pen.DashStyle = DashStyle.Dot
				pen.Width = Me.MarkerLineWeight
				Dim num As Double = Double.MinValue
				Dim num2 As Double = Double.MaxValue
				Try
					For Each num3 As Double In Me.Values
						Dim num4 As Double = num3
						If num4 > num Then
							num = num4
						End If
						If num4 < num2 Then
							num2 = num4
						End If
					Next
				Finally
					Dim enumerator As List(Of Double).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If Me.MarkerLineValue >= num2 AndAlso Me.MarkerLineValue <= num AndAlso num > num2 Then
					Dim num5 As Double = CDbl((A_0.ClipRectangle.Height - 6)) / (num - num2) * (Me.MarkerLineValue - num2) + 3.0
					num5 = CDbl(A_0.ClipRectangle.Height) - num5
					If Me.ChartType = 1 Then
						num5 = Math.Min(num5, CDbl((A_0.ClipRectangle.Height - 4)))
					End If
					A_0.Graphics.DrawLine(pen, New PointF(1F, CSng(num5)), New PointF(CSng(A_0.ClipRectangle.Width), CSng(num5)))
				End If
			End If
		End Sub

		' Token: 0x040000FC RID: 252
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As List(Of Double)

		' Token: 0x040000FD RID: 253
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Double

		' Token: 0x040000FE RID: 254
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Color

		' Token: 0x040000FF RID: 255
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Single

		' Token: 0x04000100 RID: 256
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04000101 RID: 257
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
