Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.FlexMap
Imports C1.Win.Interop
Imports C1.Win.Map
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x02000134 RID: 308
	<ComVisible(True)>
	Public Class GeoMap
		Inherits C1Map
		Implements O0_0_0_0_

		' Token: 0x06000EAD RID: 3757 RVA: 0x00063340 File Offset: 0x00061540
		Public Sub New()
			MyBase.DistanceScale.Alignment = ContentAlignment.BottomLeft
			MyBase.DistanceScale.BarStyle.BackColor = Color.Black
			MyBase.PanTool.MarkerStyle.BackColor = Color.FromArgb(131, 176, 202)
			MyBase.PanTool.MarkerStyle.BackColor2 = Color.FromArgb(185, 224, 245)
			MyBase.PanTool.MarkerStyle.GradientStyle = 3
			MyBase.PanTool.PanStyle.BackColor = Color.FromArgb(243, 243, 243)
			MyBase.PanTool.PanStyle.BackColor2 = Color.FromArgb(204, 204, 204)
			MyBase.PanTool.PanStyle.GradientStyle = 3
			MyBase.PanTool.PanStyle.Stroke.Color = Color.FromArgb(168, 168, 168)
			MyBase.PanTool.PanStyle.Stroke.Width = 1F
			MyBase.Viewport.Padding = New Padding(3)
			MyBase.ZoomTool.ButtonStyle.BackColor = Color.FromArgb(243, 243, 243)
			MyBase.ZoomTool.ButtonStyle.BackColor2 = Color.FromArgb(204, 204, 204)
			MyBase.ZoomTool.ButtonStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.ButtonStyle.Border.Bottom.Width = 1F
			MyBase.ZoomTool.ButtonStyle.Border.Left.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.ButtonStyle.Border.Left.Width = 1F
			MyBase.ZoomTool.ButtonStyle.Border.Right.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.ButtonStyle.Border.Right.Width = 1F
			MyBase.ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3
			MyBase.ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3
			MyBase.ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3
			MyBase.ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3
			MyBase.ZoomTool.ButtonStyle.Border.Top.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.ButtonStyle.Border.Top.Width = 1F
			MyBase.ZoomTool.ButtonStyle.GradientStyle = 3
			MyBase.ZoomTool.Margin = New Padding(20, 70, 0, 0)
			MyBase.ZoomTool.ThumbStyle.BackColor = Color.FromArgb(243, 243, 243)
			MyBase.ZoomTool.ThumbStyle.BackColor2 = Color.FromArgb(131, 176, 202)
			MyBase.ZoomTool.ThumbStyle.Border.Bottom.Color = Color.FromArgb(138, 176, 198)
			MyBase.ZoomTool.ThumbStyle.Border.Bottom.Width = 1F
			MyBase.ZoomTool.ThumbStyle.Border.Left.Color = Color.FromArgb(138, 176, 198)
			MyBase.ZoomTool.ThumbStyle.Border.Left.Width = 1F
			MyBase.ZoomTool.ThumbStyle.Border.Right.Color = Color.FromArgb(138, 176, 198)
			MyBase.ZoomTool.ThumbStyle.Border.Right.Width = 1F
			MyBase.ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3
			MyBase.ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3
			MyBase.ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3
			MyBase.ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3
			MyBase.ZoomTool.ThumbStyle.Border.Top.Color = Color.FromArgb(138, 176, 198)
			MyBase.ZoomTool.ThumbStyle.Border.Top.Width = 1F
			MyBase.ZoomTool.ThumbStyle.GradientStyle = 3
			MyBase.ZoomTool.TrackStyle.BackColor = Color.FromArgb(203, 203, 203)
			MyBase.ZoomTool.TrackStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.TrackStyle.Border.Bottom.Width = 1F
			MyBase.ZoomTool.TrackStyle.Border.Left.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.TrackStyle.Border.Left.Width = 1F
			MyBase.ZoomTool.TrackStyle.Border.Right.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.TrackStyle.Border.Right.Width = 1F
			MyBase.ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3
			MyBase.ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3
			MyBase.ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3
			MyBase.ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3
			MyBase.ZoomTool.TrackStyle.Border.Top.Color = Color.FromArgb(168, 168, 168)
			MyBase.ZoomTool.TrackStyle.Border.Top.Width = 1F
			MyBase.Viewport.Center = New Point(103.72, 34.5)
			MyBase.Viewport.Zoom = 3.2
		End Sub

		' Token: 0x06000EAE RID: 3758 RVA: 0x00063A80 File Offset: 0x00061C80
		Public Function CreatePolygon(points As IEnumerable(Of GeoPoint)) As VectorPolygon
			Return Me.CreatePolygon(New IEnumerable(Of GeoPoint)() { points })
		End Function

		' Token: 0x06000EAF RID: 3759 RVA: 0x00063A92 File Offset: 0x00061C92
		Public Function CreatePolygon(pointsString As String, Optional enclaves As Integer = -1) As VectorPolygon
			Return Me.CreatePolygon(Me.O0o000O._oo.(pointsString, enclaves))
		End Function

		' Token: 0x06000EB0 RID: 3760 RVA: 0x00063AA4 File Offset: 0x00061CA4
		Public Function CreatePolygon(pointsArray As IEnumerable(Of IEnumerable(Of GeoPoint))) As VectorPolygon
			Dim vectorPolygon As VectorPolygon = New VectorPolygon()
			Dim list As List(Of GeoLinearRing) = New List(Of GeoLinearRing)()
			Try
				For Each enumerable As IEnumerable(Of GeoPoint) In pointsArray
					list.Add(New GeoLinearRing(enumerable))
				Next
			Finally
				Dim enumerator As IEnumerator(Of IEnumerable(Of GeoPoint))
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			vectorPolygon.Geometry = New GeoPolygon(list)
			Return vectorPolygon
		End Function

		' Token: 0x06000EB1 RID: 3761 RVA: 0x00063B0C File Offset: 0x00061D0C
		Public Function CreateLine(points As IEnumerable(Of GeoPoint)) As VectorPolyline
			Return Me.CreateLine(New IEnumerable(Of GeoPoint)() { points })
		End Function

		' Token: 0x06000EB2 RID: 3762 RVA: 0x00063B1E File Offset: 0x00061D1E
		Public Function CreateLine(pointsString As String, Optional enclaves As Integer = -1) As VectorPolyline
			Return Me.CreateLine(Me.O0o000O._oo.(pointsString, enclaves))
		End Function

		' Token: 0x06000EB3 RID: 3763 RVA: 0x00063B30 File Offset: 0x00061D30
		Public Function CreateLine(pointss As IEnumerable(Of IEnumerable(Of GeoPoint))) As VectorPolyline
			Dim vectorPolyline As VectorPolyline = New VectorPolyline()
			Dim list As List(Of GeoLinearRing) = New List(Of GeoLinearRing)()
			Try
				For Each enumerable As IEnumerable(Of GeoPoint) In pointss
					list.Add(New GeoLinearRing(enumerable))
				Next
			Finally
				Dim enumerator As IEnumerator(Of IEnumerable(Of GeoPoint))
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			vectorPolyline.Geometry = New GeoMultiLineString(list)
			Return vectorPolyline
		End Function

		' Token: 0x06000EB4 RID: 3764 RVA: 0x00063B98 File Offset: 0x00061D98
		Public Function CreateLineWithArrow(p1 As GeoPoint, p2 As GeoPoint, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Return Me.CreateLineWithArrow(New GeoPoint() { p1, p2 }, False, arrowLength, arrowAngle)
		End Function

		' Token: 0x06000EB5 RID: 3765 RVA: 0x00063BB2 File Offset: 0x00061DB2
		Public Function CreateLineWithArrow(p1 As GeoPoint, p2 As GeoPoint, Both As Boolean, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Return Me.CreateLineWithArrow(New GeoPoint() { p1, p2 }, Both, arrowLength, arrowAngle)
		End Function

		' Token: 0x06000EB6 RID: 3766 RVA: 0x00063BCD File Offset: 0x00061DCD
		Public Function CreateLineWithArrow(points As IEnumerable(Of GeoPoint), Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Return Me.CreateLineWithArrow(points, False, arrowLength, arrowAngle)
		End Function

		' Token: 0x06000EB7 RID: 3767 RVA: 0x00063BDC File Offset: 0x00061DDC
		Public Function CreateLineWithArrow(points As IEnumerable(Of GeoPoint), Both As Boolean, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			list.AddRange(points)
			Me.CreateArrowPoints(list, arrowLength, arrowAngle, Both)
			Return Me.CreateLine(list)
		End Function

		' Token: 0x06000EB8 RID: 3768 RVA: 0x00063C08 File Offset: 0x00061E08
		Public Function CreateLineWithArrow(pointsString As String, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Return Me.CreateLineWithArrow(pointsString, False, arrowLength, arrowAngle)
		End Function

		' Token: 0x06000EB9 RID: 3769 RVA: 0x00063C14 File Offset: 0x00061E14
		Public Function CreateLineWithArrow(pointsString As String, Both As Boolean, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Dim array As String() = pointsString.Split(New Char() { ","c, "，"c })
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				Dim item As GeoPoint = New GeoPoint(num2, num3)
				list.Add(item)
			Next
			Me.CreateArrowPoints(list, arrowLength, arrowAngle, Both)
			Return Me.CreateLine(list)
		End Function

		' Token: 0x06000EBA RID: 3770 RVA: 0x00063C8E File Offset: 0x00061E8E
		Public Function CreatePlaceMark(point As GeoPoint) As VectorPlacemark
			Return New VectorPlacemark() With { .Geometry = point }
		End Function

		' Token: 0x06000EBB RID: 3771 RVA: 0x00063C9C File Offset: 0x00061E9C
		Public Function CreatePlaceMark(points As IEnumerable(Of GeoPoint)) As VectorPlacemark
			Dim vectorPlacemark As VectorPlacemark = New VectorPlacemark()
			If points.Count() = 1 Then
				vectorPlacemark.Geometry = points.First()
			Else
				vectorPlacemark.Geometry = New GeoMultiPoint(points)
			End If
			Return vectorPlacemark
		End Function

		' Token: 0x06000EBC RID: 3772 RVA: 0x00063CD4 File Offset: 0x00061ED4
		Public Function CreatePlaceMark(pointsString As String) As VectorPlacemark
			Dim array As String() = pointsString.Split(New Char() { ","c })
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				Dim item As GeoPoint = New GeoPoint(num2, num3)
				list.Add(item)
			Next
			Return Me.CreatePlaceMark(list)
		End Function

		' Token: 0x06000EBD RID: 3773 RVA: 0x00063D3C File Offset: 0x00061F3C
		Public Function CreateCircle(p1 As GeoPoint, p2 As GeoPoint) As VectorPolygon
			Dim num As Double = p2.X - p1.X
			Dim num2 As Double = p2.Y - p1.Y
			Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num4 As Integer = 0
			Do
				Dim num5 As Double = CDbl(num4) * 3.1415926535897931 / 180.0
				Dim num6 As Double = p1.X + num3 * Math.Cos(num5)
				Dim num7 As Double = p1.Y + num3 * Math.Sin(num5)
				list.Add(New GeoPoint(num6, num7))
				num4 += 1
			Loop While num4 <= 359
			Return Me.CreatePolygon(list)
		End Function

		' Token: 0x06000EBE RID: 3774 RVA: 0x00063DD8 File Offset: 0x00061FD8
		Public Function CreateCircle(p1 As GeoPoint, p2 As GeoPoint, Pixel As Boolean) As VectorPolygon
			Dim result As VectorPolygon
			If Not Pixel Then
				result = Me.CreateCircle(p1, p2)
			Else
				Dim point As Point = MyBase.GeographicToScreen(p1.Location)
				Dim point2 As Point = MyBase.GeographicToScreen(p2.Location)
				Dim num As Double = point2.X - point.X
				Dim num2 As Double = point2.Y - point.Y
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
				Dim num4 As Integer = 0
				Do
					Dim num5 As Double = CDbl(num4) * 3.1415926535897931 / 180.0
					Dim num6 As Double = point.X + num3 * Math.Cos(num5)
					Dim num7 As Double = point.Y + num3 * Math.Sin(num5)
					Dim point3 As Point
					point3..ctor(num6, num7)
					point3 = MyBase.ScreenToGeographic(point3)
					list.Add(New GeoPoint(point3.X, point3.Y))
					num4 += 1
				Loop While num4 <= 359
				result = Me.CreatePolygon(list)
			End If
			Return result
		End Function

		' Token: 0x06000EBF RID: 3775 RVA: 0x00063ED0 File Offset: 0x000620D0
		Public Function CreateCircle(pointsString As String, Optional Pixel As Boolean = False) As VectorPolygon
			Dim array As String() = pointsString.Split(New Char() { ","c })
			Dim result As VectorPolygon
			If array.Length = 4 Then
				Dim p As GeoPoint = New GeoPoint(Conversions.ToDouble(array(0)), Conversions.ToDouble(array(1)))
				Dim p2 As GeoPoint = New GeoPoint(Conversions.ToDouble(array(2)), Conversions.ToDouble(array(3)))
				result = Me.CreateCircle(p, p2, Pixel)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06000EC0 RID: 3776 RVA: 0x00063F30 File Offset: 0x00062130
		Public Function CreatePie(p1 As GeoPoint, p2 As GeoPoint, sweepAngle As Double) As VectorPolygon
			Dim a_ As Point = MyBase.GeographicToScreen(p1.Location)
			Dim a_2 As Point = MyBase.GeographicToScreen(p2.Location)
			Dim num As Double = a_2.X - a_.X
			Dim num2 As Double = a_2.Y - a_.Y
			Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num4 As Double = Me.O0o000O._oo.(a_, a_2)
			Dim num5 As Double = num4
			Dim num6 As Double = num4 + sweepAngle
			Dim num7 As Integer = 1
			If sweepAngle < 0.0 Then
				num7 = -1
			End If
			list.Add(p1)
			Dim num8 As Double = num6
			Dim num9 As Double = CDbl(num7)
			Dim flag As Boolean = num9 >= 0.0
			num4 = num5
			While If(flag, (num4 <= num8), (num4 >= num8))
				Dim num10 As Double = num4 * 3.1415926535897931 / 180.0
				Dim num11 As Double = a_.X + num3 * Math.Cos(num10)
				Dim num12 As Double = a_.Y + num3 * Math.Sin(num10)
				Dim point As Point
				point..ctor(num11, num12)
				point = MyBase.ScreenToGeographic(point)
				list.Add(New GeoPoint(point.X, point.Y))
				num4 += num9
			End While
			Return Me.CreatePolygon(list)
		End Function

		' Token: 0x06000EC1 RID: 3777 RVA: 0x00064070 File Offset: 0x00062270
		Public Function CreateArc(p1 As GeoPoint, p2 As GeoPoint, sweepAngle As Double) As VectorPolyline
			Dim a_ As Point = MyBase.GeographicToScreen(p1.Location)
			Dim a_2 As Point = MyBase.GeographicToScreen(p2.Location)
			Dim num As Double = a_2.X - a_.X
			Dim num2 As Double = a_2.Y - a_.Y
			Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num4 As Double = Me.O0o000O._oo.(a_, a_2)
			Dim num5 As Double = num4
			Dim num6 As Double = num4 + sweepAngle
			Dim num7 As Integer = 1
			If sweepAngle < 0.0 Then
				num7 = -1
			End If
			Dim num8 As Double = num6
			Dim num9 As Double = CDbl(num7)
			Dim flag As Boolean = num9 >= 0.0
			num4 = num5
			While If(flag, (num4 <= num8), (num4 >= num8))
				Dim num10 As Double = num4 * 3.1415926535897931 / 180.0
				Dim num11 As Double = a_.X + num3 * Math.Cos(num10)
				Dim num12 As Double = a_.Y + num3 * Math.Sin(num10)
				Dim point As Point
				point..ctor(num11, num12)
				point = MyBase.ScreenToGeographic(point)
				list.Add(New GeoPoint(point.X, point.Y))
				num4 += num9
			End While
			Return Me.CreateLine(list)
		End Function

		' Token: 0x06000EC2 RID: 3778 RVA: 0x000641A8 File Offset: 0x000623A8
		Private Function <<EMPTY_NAME>>(A_0 As Point, A_1 As Point) As Double
			Dim x As Double = A_1.X - A_0.X
			Dim num As Double = Math.Atan2(A_1.Y - A_0.Y, x) * 57.295779513082323
			If num < 0.0 Then
				num += 360.0
			End If
			Return num
		End Function

		' Token: 0x06000EC3 RID: 3779 RVA: 0x00064200 File Offset: 0x00062400
		Public Function CreateLinkArc(gp1 As GeoPoint, gp2 As GeoPoint, curvature As Double) As VectorPolyline
			Dim pointF As PointF = MyBase.GeographicToScreen(gp1.Location).ToPointF()
			Dim pointF2 As PointF = MyBase.GeographicToScreen(gp2.Location).ToPointF()
			Dim result As VectorPolyline
			If Math.Abs(pointF.X - pointF2.X) < 1E-06F AndAlso Math.Abs(pointF.Y - pointF2.Y) < 1E-06F Then
				result = Me.CreateLine(New GeoPoint() { gp1, gp2 })
			ElseIf Math.Abs(curvature) < 9.9999999747524271E-07 Then
				result = Me.CreateLine(New GeoPoint() { gp1, gp2 })
			Else
				Dim num As Single = pointF2.X - pointF.X
				Dim num2 As Single = pointF2.Y - pointF.Y
				Dim num3 As Single = CSng(Math.Sqrt(CDbl((num * num + num2 * num2))))
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature))
				curvature = curvature * CDbl(num3) / 2.0
				Dim num4 As Double = Math.Atan2(CDbl(num2), CDbl(num))
				Dim num5 As Single = CSng((-CSng(Math.Sin(num4))))
				Dim num6 As Single = CSng(Math.Cos(num4))
				Dim num7 As Single = (pointF.X + pointF2.X) / 2F
				Dim num8 As Double = CDbl(((pointF.Y + pointF2.Y) / 2F))
				Dim num9 As Double = CDbl(num7) + CDbl(num5) * curvature
				Dim num10 As Double = num8 + CDbl(num6) * curvature
				Dim num11 As Double = CDbl(pointF.X)
				Dim num12 As Double = CDbl(pointF.Y)
				Dim num13 As Double = CDbl(pointF2.X)
				Dim num14 As Double = CDbl(pointF2.Y)
				Dim num15 As Double = num9
				Dim num16 As Double = num10
				Dim num17 As Double = 2.0 * (num13 - num11)
				Dim num18 As Double = 2.0 * (num14 - num12)
				Dim num19 As Double = num13 * num13 - num11 * num11 + (num14 * num14 - num12 * num12)
				Dim num20 As Double = 2.0 * (num15 - num11)
				Dim num21 As Double = 2.0 * (num16 - num12)
				Dim num22 As Double = num15 * num15 - num11 * num11 + (num16 * num16 - num12 * num12)
				Dim num23 As Double = num17 * num21 - num20 * num18
				If Math.Abs(num23) < 9.9999999747524271E-07 Then
					result = Me.CreateLine(New GeoPoint() { gp1, gp2 })
				Else
					Dim num24 As Double = (num21 * num19 - num18 * num22) / num23
					Dim num25 As Double = (num17 * num22 - num20 * num19) / num23
					Dim num26 As Double = CDbl(CSng(Math.Sqrt((num11 - num24) * (num11 - num24) + (num12 - num25) * (num12 - num25))))
					Dim num27 As Double = CDbl(CSng((Math.Atan2(num12 - num25, num11 - num24) * 180.0 / 3.1415926535897931)))
					Dim num28 As Double = CDbl(CSng((Math.Atan2(num14 - num25, num13 - num24) * 180.0 / 3.1415926535897931)))
					Dim num29 As Double = Math.Atan2(num16 - num25, num15 - num24) * 180.0 / 3.1415926535897931
					Dim num30 As Double = (num28 - num27 + 360.0) Mod 360.0
					Dim num31 As Double = If(((num29 - num27 + 360.0) Mod 360.0 <= num30), num30, (-(360.0 - num30)))
					Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
					list.Add(gp1)
					Dim num32 As Double = Math.Abs(num31)
					Dim num33 As Integer = CInt(Math.Round(Math.Max(10.0, Math.Abs(num31))))
					If num32 < 1.0 Then
						result = Me.CreateLine(New GeoPoint() { gp1, gp2 })
					Else
						Dim num34 As Double = num31 / CDbl(num33)
						Dim num35 As Integer = num33 - 1
						For i As Integer = 1 To num35
							Dim num36 As Double = (num27 + num34 * CDbl(i)) * 3.1415926535897931 / 180.0
							Dim num37 As Double = num24 + num26 * Math.Cos(num36)
							Dim num38 As Double = num25 + num26 * Math.Sin(num36)
							Dim point As Point
							point..ctor(num37, num38)
							point = MyBase.ScreenToGeographic(point)
							list.Add(New GeoPoint(point.X, point.Y))
						Next
						list.Add(gp2)
						result = Me.CreateLine(list)
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06000EC4 RID: 3780 RVA: 0x0006463D File Offset: 0x0006283D
		Public Function CreateBezierCurve(GeoPointString As String) As VectorPolyline
			Return Me.CreateBezierCurve(Me.O0o000O._oo.(GeoPointString, 0)(0))
		End Function

		' Token: 0x06000EC5 RID: 3781 RVA: 0x00064653 File Offset: 0x00062853
		Public Function CreateBezierCurve(GeoPoints As IEnumerable(Of GeoPoint)) As VectorPolyline
			Return Me.O0o000O._oo.(GeoPoints, False, False)
		End Function

		' Token: 0x06000EC6 RID: 3782 RVA: 0x0006465E File Offset: 0x0006285E
		Public Function CreateBezierCurveArrow(GeoPointString As String, Optional Both As Boolean = False) As VectorPolyline
			Return Me.CreateBezierCurveArrow(Me.O0o000O._oo.(GeoPointString, 0)(0), Both)
		End Function

		' Token: 0x06000EC7 RID: 3783 RVA: 0x00064675 File Offset: 0x00062875
		Public Function CreateBezierCurveArrow(GeoPoints As IEnumerable(Of GeoPoint), Optional Both As Boolean = False) As VectorPolyline
			Return Me.O0o000O._oo.(GeoPoints, True, Both)
		End Function

		' Token: 0x06000EC8 RID: 3784 RVA: 0x00064680 File Offset: 0x00062880
		Private Function <<EMPTY_NAME>>(A_0 As IEnumerable(Of GeoPoint), A_1 As Boolean, Optional A_2 As Boolean = False) As VectorPolyline
			Dim list As List(Of PointF) = New List(Of PointF)()
			Try
				For Each geoPoint As GeoPoint In A_0
					Dim location As Point = geoPoint.Location
					list.Add(MyBase.GeographicToScreen(location).ToPointF())
				Next
			Finally
				Dim enumerator As IEnumerator(Of GeoPoint)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim result As VectorPolyline
			If list.Count = 2 Then
				If A_1 Then
					result = Me.CreateLineWithArrow(A_0, A_2, 8.0, 30.0)
				Else
					result = Me.CreateLine(A_0)
				End If
			ElseIf list.Count > 2 Then
				If A_1 Then
					list = ooO0O.O_O_.0oooo_oo.(list.ToArray(), 0.5235988F, 2F, 8F, 0.5F, 3, A_2)
				Else
					list = ooO0O.O_O_.0oooo_oo.(list.ToArray(), -1F, 2F, 8F, 0.5F, 3, False)
				End If
				Dim list2 As List(Of GeoPoint) = New List(Of GeoPoint)()
				Try
					For Each pointF As PointF In list
						Dim point As Point = New Point(CDbl(pointF.X), CDbl(pointF.Y))
						point = MyBase.ScreenToGeographic(point)
						list2.Add(New GeoPoint(point.X, point.Y))
					Next
				Finally
					Dim enumerator2 As List(Of PointF).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				result = Me.CreateLine(list2)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06000EC9 RID: 3785 RVA: 0x000647F8 File Offset: 0x000629F8
		Public Function CreateCurve(p1 As GeoPoint, p2 As GeoPoint, curvature As Double, vault As Single) As VectorPolyline
			Dim pointF As PointF = MyBase.GeographicToScreen(p1.Location).ToPointF()
			Dim pointF2 As PointF = MyBase.GeographicToScreen(p2.Location).ToPointF()
			Dim result As VectorPolyline
			If pointF.Equals(pointF2) Then
				result = Me.CreateLine(New GeoPoint() { p1, p2 })
			ElseIf Math.Abs(curvature) < 0.001 Then
				result = Me.CreateLine(New GeoPoint() { p1, p2 })
			Else
				vault = Math.Max(0F, Math.Min(1F, vault))
				Dim num As Double = CDbl((pointF2.X - pointF.X))
				Dim num2 As Double = CDbl((pointF2.Y - pointF.Y))
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature))
				curvature = curvature * num3 / 2.0
				Dim num4 As Integer = CInt(Math.Round(Math.Max(60.0, num3)))
				Dim num5 As Double = CDbl(pointF.X) + num * CDbl(vault)
				Dim num6 As Double = CDbl(pointF.Y) + num2 * CDbl(vault)
				Dim num7 As Double = -num2
				Dim num8 As Double = num
				If num3 > 0.001 Then
					num7 /= num3
					num8 /= num3
				End If
				Dim num9 As Double = num5 + num7 * curvature * (num3 / 100.0)
				Dim num10 As Double = num6 + num8 * curvature * (num3 / 100.0)
				Dim pointF3 As PointF = New PointF(CSng(num9), CSng(num10))
				Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
				list.Add(p1)
				Dim num11 As Integer = num4 - 1
				For i As Integer = 1 To num11
					Dim num12 As Double = CDbl(i) / CDbl(num4)
					Dim num13 As Double = (1.0 - num12) * (1.0 - num12) * CDbl(pointF.X) + 2.0 * (1.0 - num12) * num12 * CDbl(pointF3.X) + num12 * num12 * CDbl(pointF2.X)
					Dim num14 As Double = (1.0 - num12) * (1.0 - num12) * CDbl(pointF.Y) + 2.0 * (1.0 - num12) * num12 * CDbl(pointF3.Y) + num12 * num12 * CDbl(pointF2.Y)
					Dim point As Point
					point..ctor(num13, num14)
					point = MyBase.ScreenToGeographic(point)
					list.Add(New GeoPoint(point.X, point.Y))
				Next
				list.Add(p2)
				result = Me.CreateLine(list)
			End If
			Return result
		End Function

		' Token: 0x06000ECA RID: 3786 RVA: 0x00064AB8 File Offset: 0x00062CB8
		Public Function CreateCurveWithArrow(p1 As GeoPoint, p2 As GeoPoint, curvature As Double, vault As Double, Optional arrowLength As Double = 8.0, Optional arrowAngle As Double = 30.0) As VectorPolyline
			Dim pointF As PointF = MyBase.GeographicToScreen(p1.Location).ToPointF()
			Dim pointF2 As PointF = MyBase.GeographicToScreen(p2.Location).ToPointF()
			Dim result As VectorPolyline
			If pointF.Equals(pointF2) Then
				result = Me.CreateLine(New GeoPoint() { p1, p2 })
			ElseIf Math.Abs(curvature) < 0.001 Then
				result = Me.CreateLine(New GeoPoint() { p1, p2 })
			Else
				vault = Math.Max(0.0, Math.Min(1.0, vault))
				Dim num As Double = CDbl((pointF2.X - pointF.X))
				Dim num2 As Double = CDbl((pointF2.Y - pointF.Y))
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature))
				curvature = curvature * num3 / 2.0
				Dim num4 As Integer = CInt(Math.Round(Math.Max(60.0, num3)))
				Dim num5 As Double = CDbl(pointF.X) + num * vault
				Dim num6 As Double = CDbl(pointF.Y) + num2 * vault
				Dim num7 As Double = -num2
				Dim num8 As Double = num
				If num3 > 0.001 Then
					num7 /= num3
					num8 /= num3
				End If
				Dim num9 As Double = num5 + num7 * curvature * (num3 / 100.0)
				Dim num10 As Double = num6 + num8 * curvature * (num3 / 100.0)
				Dim pointF3 As PointF = New PointF(CSng(num9), CSng(num10))
				Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
				list.Add(p1)
				Dim num11 As Integer = num4 - 1
				For i As Integer = 1 To num11
					Dim num12 As Double = CDbl(i) / CDbl(num4)
					Dim num13 As Double = (1.0 - num12) * (1.0 - num12) * CDbl(pointF.X) + 2.0 * (1.0 - num12) * num12 * CDbl(pointF3.X) + num12 * num12 * CDbl(pointF2.X)
					Dim num14 As Double = (1.0 - num12) * (1.0 - num12) * CDbl(pointF.Y) + 2.0 * (1.0 - num12) * num12 * CDbl(pointF3.Y) + num12 * num12 * CDbl(pointF2.Y)
					Dim point As Point
					point..ctor(num13, num14)
					point = MyBase.ScreenToGeographic(point)
					list.Add(New GeoPoint(point.X, point.Y))
				Next
				list.Add(p2)
				Dim num15 As Double = CDbl((pointF2.X - pointF3.X))
				Dim num16 As Double = CDbl((pointF2.Y - pointF3.Y))
				Dim num17 As Double = CDbl(CSng(Math.Sqrt(num15 * num15 + num16 * num16)))
				If num17 < 0.001 Then
					result = Me.CreateLine(New GeoPoint() { p1, p2 })
				Else
					Dim num18 As Double = num15 / num17
					Dim num19 As Double = num16 / num17
					Dim num20 As Double = arrowAngle * 3.1415926535897931 / 180.0
					Dim num21 As Double = CDbl(CSng(Math.Cos(num20)))
					Dim num22 As Double = CDbl(CSng(Math.Sin(num20)))
					Dim num23 As Double = num18 * num21 + num19 * num22
					Dim num24 As Double = -num18 * num22 + num19 * num21
					Dim num25 As Double = num18 * num21 - num19 * num22
					Dim num26 As Double = num18 * num22 + num19 * num21
					Dim pointF4 As PointF = New PointF(CSng((CDbl(pointF2.X) - num23 * arrowLength)), CSng((CDbl(pointF2.Y) - num24 * arrowLength)))
					Dim pointF5 As PointF = New PointF(CSng((CDbl(pointF2.X) - num25 * arrowLength)), CSng((CDbl(pointF2.Y) - num26 * arrowLength)))
					Dim point2 As Point
					point2..ctor(CDbl(pointF4.X), CDbl(pointF4.Y))
					Dim point3 As Point
					point3..ctor(CDbl(pointF5.X), CDbl(pointF5.Y))
					point2 = MyBase.ScreenToGeographic(point2)
					point3 = MyBase.ScreenToGeographic(point3)
					list.Add(New GeoPoint(point2.X, point2.Y))
					list.Add(p2)
					list.Add(New GeoPoint(point3.X, point3.Y))
					result = Me.CreateLine(list)
				End If
			End If
			Return result
		End Function

		' Token: 0x06000ECB RID: 3787 RVA: 0x00064F0A File Offset: 0x0006310A
		Public Sub CreateArrowPoints(LinePoints As List(Of GeoPoint), arrowLength As Double, arrowAngle As Double)
			Me.CreateArrowPoints(LinePoints, arrowLength, arrowAngle, False)
		End Sub

		' Token: 0x06000ECC RID: 3788 RVA: 0x00064F18 File Offset: 0x00063118
		Public Sub CreateArrowPoints(LinePoints As List(Of GeoPoint), arrowLength As Double, arrowAngle As Double, isBothEnds As Boolean)
			Dim o0OO0O0o As GeoMap.O0OO0O0o = New GeoMap.O0OO0O0o()
			o0OO0O0o.O.oO_O_. = Me
			o0OO0O0o.OO0o._. = arrowLength
			o0OO0O0o.O.oO_O_. = arrowAngle
			If LinePoints.Count < 2 Then
				Throw New ArgumentException("至少需要两个点才能绘制线条!")
			End If
			Dim func As Func(Of GeoPoint, GeoPoint, List(Of GeoPoint)) = AddressOf o0OO0O0o.O.oO_O_.
			Dim arg As GeoPoint = LinePoints(LinePoints.Count - 2)
			Dim geoPoint As GeoPoint = LinePoints(LinePoints.Count - 1)
			Dim list As List(Of GeoPoint) = func(arg, geoPoint)
			If list.Count = 2 Then
				LinePoints.Add(list(0))
				LinePoints.Add(geoPoint)
				LinePoints.Add(list(1))
			End If
			If isBothEnds Then
				Dim arg2 As GeoPoint = LinePoints(1)
				Dim geoPoint2 As GeoPoint = LinePoints(0)
				Dim list2 As List(Of GeoPoint) = func(arg2, geoPoint2)
				If list2.Count = 2 Then
					LinePoints.Insert(0, list2(1))
					LinePoints.Insert(0, geoPoint2)
					LinePoints.Insert(0, list2(0))
				End If
			End If
		End Sub

		' Token: 0x06000ECD RID: 3789 RVA: 0x00065004 File Offset: 0x00063204
		Public Function CreateRectangle(p1 As GeoPoint, p2 As GeoPoint) As VectorPolygon
			Dim geoPoint As GeoPoint = New GeoPoint(p1.X, p2.Y)
			Dim geoPoint2 As GeoPoint = New GeoPoint(p2.X, p1.Y)
			Return Me.CreatePolygon(New GeoPoint() { p1, geoPoint, p2, geoPoint2 })
		End Function

		' Token: 0x06000ECE RID: 3790 RVA: 0x00065054 File Offset: 0x00063254
		Public Function CreateRectangle(pointsString As String) As VectorPolygon
			Dim array As String() = pointsString.Split(New Char() { ","c })
			Dim result As VectorPolygon
			If array.Length = 4 Then
				Dim p As GeoPoint = New GeoPoint(Conversions.ToDouble(array(0)), Conversions.ToDouble(array(1)))
				Dim p2 As GeoPoint = New GeoPoint(Conversions.ToDouble(array(2)), Conversions.ToDouble(array(3)))
				result = Me.CreateRectangle(p, p2)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06000ECF RID: 3791 RVA: 0x000650B4 File Offset: 0x000632B4
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer) As List(Of List(Of GeoPoint))
			Dim list As List(Of List(Of GeoPoint)) = New List(Of List(Of GeoPoint))()
			Dim array As String() = A_0.Split(New Char() { vbLf, "|"c })
			For i As Integer = 0 To array.Length - 1
				Dim array2 As String() = array(i).Split(New Char() { ","c, "，"c })
				Dim list2 As List(Of GeoPoint) = New List(Of GeoPoint)()
				Dim num As Integer = array2.Length - 1
				For j As Integer = 0 To num Step 2
					Dim num2 As Double = Conversions.ToDouble(array2(j))
					Dim num3 As Double = Conversions.ToDouble(array2(j + 1))
					Dim item As GeoPoint = New GeoPoint(num2, num3)
					list2.Add(item)
				Next
				list.Add(list2)
				If A_1 > 0 AndAlso list.Count > A_1 + 1 Then
					Exit For
				End If
			Next
			Return list
		End Function

		' Token: 0x06000ED0 RID: 3792 RVA: 0x00065174 File Offset: 0x00063374
		Public Function AddVirtualLayer(minZoom As Double) As VirtualLayer
			Dim virtualLayer As VirtualLayer = New VirtualLayer(Me, minZoom)
			MyBase.Layers.Add(virtualLayer)
			Return virtualLayer
		End Function

		' Token: 0x06000ED1 RID: 3793 RVA: 0x00065198 File Offset: 0x00063398
		Public Function AddVirtualLayer(minZoom As Double, maxZoom As Double) As VirtualLayer
			Dim virtualLayer As VirtualLayer = New VirtualLayer(Me, minZoom, maxZoom)
			MyBase.Layers.Add(virtualLayer)
			Return virtualLayer
		End Function

		' Token: 0x1700029B RID: 667
		' (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000651BC File Offset: 0x000633BC
		Public ReadOnly Property MouseGeoPosition As GeoPoint
			Get
				Dim point As Point = MyBase.PointToClient(Control.MousePosition)
				Dim point2 As Point = MyBase.ScreenToGeographic(point)
				Return New GeoPoint(point2.X, point2.Y)
			End Get
		End Property

		' Token: 0x06000ED3 RID: 3795 RVA: 0x000651F5 File Offset: 0x000633F5
		Public Sub CenterTo(X As Double, Y As Double)
			MyBase.Viewport.Center = New Point(X, Y)
		End Sub

		' Token: 0x1700029C RID: 668
		' (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0006520C File Offset: 0x0006340C
		' (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00065244 File Offset: 0x00063444
		Public Property Center As GeoPoint
			Get
				Return New GeoPoint(MyBase.Viewport.Center.X, MyBase.Viewport.Center.X)
			End Get
			Set(value As GeoPoint)
				MyBase.Viewport.Center = value.Location
			End Set
		End Property

		' Token: 0x06000ED6 RID: 3798 RVA: 0x00065258 File Offset: 0x00063458
		Public Function CreatFromJsonObject(FeatureItem As JObject, Optional MaxCount As Integer = -1) As VectorItem
			Dim text As String = FeatureItem("geometry")("type").ToString()
			Dim left As String = text
			Dim result As VectorItem
			If Operators.CompareString(left, "Polygon", True) = 0 Then
				Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
				Try
					For Each jtoken As JToken In FeatureItem("geometry")("coordinates")
						Dim jarray As JArray = CType(jtoken, JArray)
						Try
							For Each jtoken2 As JToken In jarray
								Dim jarray2 As JArray = CType(jtoken2, JArray)
								Dim item As GeoPoint = New GeoPoint(CDbl(jarray2(0)), CDbl(jarray2(1)))
								list.Add(item)
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of JToken)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator(Of JToken)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				result = Me.CreatePolygon(list)
			ElseIf Operators.CompareString(left, "MultiPolygon", True) = 0 Then
				Dim list2 As List(Of List(Of GeoPoint)) = New List(Of List(Of GeoPoint))()
				Try
					For Each jtoken3 As JToken In FeatureItem("geometry")("coordinates")
						Dim jarray3 As JArray = CType(jtoken3, JArray)
						Dim list3 As List(Of GeoPoint) = New List(Of GeoPoint)()
						Try
							For Each jtoken4 As JToken In jarray3
								Dim jarray4 As JArray = CType(jtoken4, JArray)
								Try
									For Each jtoken5 As JToken In jarray4
										Dim jarray5 As JArray = CType(jtoken5, JArray)
										Dim item2 As GeoPoint = New GeoPoint(CDbl(jarray5(0)), CDbl(jarray5(1)))
										list3.Add(item2)
									Next
								Finally
									Dim enumerator5 As IEnumerator(Of JToken)
									If enumerator5 IsNot Nothing Then
										enumerator5.Dispose()
									End If
								End Try
							Next
						Finally
							Dim enumerator4 As IEnumerator(Of JToken)
							If enumerator4 IsNot Nothing Then
								enumerator4.Dispose()
							End If
						End Try
						list2.Add(list3)
						If MaxCount > 0 AndAlso list2.Count >= MaxCount Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of JToken)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
				result = Me.CreatePolygon(list2)
			ElseIf Operators.CompareString(left, "Point", True) = 0 Then
				Dim jtoken6 As JToken = FeatureItem("geometry")("coordinates")
				Dim geometry As GeoPoint = New GeoPoint(CDbl(jtoken6(0)), CDbl(jtoken6(1)))
				result = New VectorPlacemark() With { .Geometry = geometry }
			ElseIf Operators.CompareString(left, "MultiPoint", True) = 0 OrElse Operators.CompareString(left, "LineString", True) = 0 Then
				New List(Of List(Of GeoPoint))()
				Dim list4 As List(Of GeoPoint) = New List(Of GeoPoint)()
				Try
					For Each jtoken7 As JToken In FeatureItem("geometry")("coordinates")
						Dim jarray6 As JArray = CType(jtoken7, JArray)
						Dim item3 As GeoPoint = New GeoPoint(CDbl(jarray6(0)), CDbl(jarray6(1)))
						list4.Add(item3)
					Next
				Finally
					Dim enumerator6 As IEnumerator(Of JToken)
					If enumerator6 IsNot Nothing Then
						enumerator6.Dispose()
					End If
				End Try
				If Operators.CompareString(text, "LineString", True) = 0 Then
					result = Me.CreateLine(list4)
				Else
					result = Me.CreatePlaceMark(list4)
				End If
			ElseIf Operators.CompareString(left, "MultiLineString", True) = 0 Then
				Dim list5 As List(Of List(Of GeoPoint)) = New List(Of List(Of GeoPoint))()
				Try
					For Each jtoken8 As JToken In FeatureItem("geometry")("coordinates")
						Dim jarray7 As JArray = CType(jtoken8, JArray)
						Dim list6 As List(Of GeoPoint) = New List(Of GeoPoint)()
						Try
							For Each jtoken9 As JToken In jarray7
								Dim jarray8 As JArray = CType(jtoken9, JArray)
								Dim item4 As GeoPoint = New GeoPoint(CDbl(jarray8(0)), CDbl(jarray8(1)))
								list6.Add(item4)
							Next
						Finally
							Dim enumerator8 As IEnumerator(Of JToken)
							If enumerator8 IsNot Nothing Then
								enumerator8.Dispose()
							End If
						End Try
						list5.Add(list6)
						If MaxCount > 0 AndAlso list5.Count >= MaxCount Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator7 As IEnumerator(Of JToken)
					If enumerator7 IsNot Nothing Then
						enumerator7.Dispose()
					End If
				End Try
				result = Me.CreateLine(list5)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06000ED7 RID: 3799 RVA: 0x000656D0 File Offset: 0x000638D0
		Public Function CreateRecordsFromKML(filepath As String) As List(Of VectorRecord)
			Dim list As List(Of VectorRecord) = New List(Of VectorRecord)()
			Using stream As Stream = File.OpenRead(filepath)
				Dim enumerable As IEnumerable(Of GeoGeometryRecord) = KmlReader.Read(stream)
				Try
					For Each geoGeometryRecord As GeoGeometryRecord In enumerable
						Dim a_ As VectorItem = GeoMap.O0o000O._oo.(geoGeometryRecord)
						list.Add(New VectorRecord(a_, geoGeometryRecord.Data))
					Next
				Finally
					Dim enumerator As IEnumerator(Of GeoGeometryRecord)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Using
			Return list
		End Function

		' Token: 0x06000ED8 RID: 3800 RVA: 0x0006575C File Offset: 0x0006395C
		Public Function CreateRecordsFromSHP(shpFile As String, dbfFile As String) As List(Of VectorRecord)
			Dim list As List(Of VectorRecord) = New List(Of VectorRecord)()
			Using stream As Stream = File.OpenRead(shpFile)
				Using stream2 As Stream = File.OpenRead(dbfFile)
					Dim enumerable As IEnumerable(Of GeoGeometryRecord) = ShapeReader.Read(stream, stream2)
					Try
						For Each geoGeometryRecord As GeoGeometryRecord In enumerable
							Dim a_ As VectorItem = GeoMap.O0o000O._oo.(geoGeometryRecord)
							list.Add(New VectorRecord(a_, geoGeometryRecord.Data))
						Next
					Finally
						Dim enumerator As IEnumerator(Of GeoGeometryRecord)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End Using
			End Using
			Return list
		End Function

		' Token: 0x06000ED9 RID: 3801 RVA: 0x0006580C File Offset: 0x00063A0C
		Private Shared Function <<EMPTY_NAME>>(A_0 As GeoGeometryRecord) As VectorItem
			Dim vectorItem As VectorItem
			Select Case A_0.Geometry.Type
				Case 1, 4
					vectorItem = New VectorPlacemark()
				Case 2, 5
					vectorItem = New VectorPolyline()
				Case 3, 6
					vectorItem = New VectorPolygon()
				Case Else
					Return Nothing
			End Select
			vectorItem.GeometryData = WkCoder.ToBase64String(A_0.Geometry, 1)
			Return vectorItem
		End Function

		' Token: 0x06000EDA RID: 3802 RVA: 0x00065878 File Offset: 0x00063A78
		Public Function GetKmlStyleColor(s As String) As Color
			Dim result As Color
			Dim num As UInteger
			If String.IsNullOrEmpty(s) Then
				result = Color.Empty
			ElseIf Not UInteger.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, num) Then
				result = Color.Empty
			Else
				Dim alpha As Integer = CInt(CByte(((num And 4278190080UI) >> 24)))
				Dim blue As Byte = CByte(((num And 16711680UI) >> 16))
				Dim green As Byte = CByte(((num And 65280UI) >> 8))
				Dim red As Byte = CByte((num And 255UI))
				result = Color.FromArgb(alpha, CInt(red), CInt(green), CInt(blue))
			End If
			Return result
		End Function

		' Token: 0x06000EDB RID: 3803 RVA: 0x000658E8 File Offset: 0x00063AE8
		Public Function CreateMarkShape() As CustomMarkShape
			Return Me.CreateMarkShape("")
		End Function

		' Token: 0x06000EDC RID: 3804 RVA: 0x000658F8 File Offset: 0x00063AF8
		Public Function CreateMarkShape(ShapeTag As String) As CustomMarkShape
			If Me.O.oO_O_. Is Nothing Then
				Me.O.oO_O_. = New Dictionary(Of String, CustomMarkShape)(StringComparer.OrdinalIgnoreCase)
			End If
			Dim result As CustomMarkShape
			If Me.O.oO_O_..ContainsKey(ShapeTag) Then
				result = Me.O.oO_O_.(ShapeTag)
			Else
				Dim customMarkShape As CustomMarkShape = New CustomMarkShape(Me, ShapeTag)
				Me.O.oO_O_..Add(ShapeTag, customMarkShape)
				result = customMarkShape
			End If
			Return result
		End Function

		' Token: 0x06000EDD RID: 3805 RVA: 0x00065952 File Offset: 0x00063B52
		Public Function CreateMarkShape(ShapeTag As Object) As CustomMarkShape
			Return New CustomMarkShape(Me, RuntimeHelpers.GetObjectValue(ShapeTag))
		End Function

		' Token: 0x06000EDE RID: 3806 RVA: 0x00065960 File Offset: 0x00063B60
		Public Function CreateTextShape(text As String) As MarkTextShape
			Return New MarkTextShape(text)
		End Function

		' Token: 0x06000EDF RID: 3807 RVA: 0x00065968 File Offset: 0x00063B68
		Public Function CreateTextShape(text As String, margin As Integer) As MarkTextShape
			Return New MarkTextShape(text, margin)
		End Function

		' Token: 0x06000EE0 RID: 3808 RVA: 0x00065971 File Offset: 0x00063B71
		Public Function CreateImageShape(ImageFile As String) As MarkImageShape
			Return New MarkImageShape(OO_00oOO.GetImage(ImageFile))
		End Function

		' Token: 0x06000EE1 RID: 3809 RVA: 0x0006597E File Offset: 0x00063B7E
		Public Function CreateImageShape(image As Image) As MarkImageShape
			Return New MarkImageShape(image)
		End Function

		' Token: 0x06000EE2 RID: 3810 RVA: 0x00065988 File Offset: 0x00063B88
		Private Function <<EMPTY_NAME>>(A_0 As Point()) As PointF
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			For Each point As Point In A_0
				num += CDbl(point.X)
				num2 += CDbl(point.Y)
			Next
			Return New PointF(CSng((num / CDbl(A_0.Length))), CSng((num2 / CDbl(A_0.Length))))
		End Function

		' Token: 0x06000EE3 RID: 3811 RVA: 0x000659EC File Offset: 0x00063BEC
		Private Function <<EMPTY_NAME>>(A_0 As Point(), A_1 As Double) As Point()
			Dim result As Point()
			If A_0 Is Nothing OrElse A_0.Length < 2 Then
				result = If((A_0 Is Nothing), New Point(-1) {}, A_0)
			Else
				Dim pointF As PointF = Me.O0o000O._oo.(A_0)
				Dim num As Double = A_1 * 3.1415926535897931 / 180.0
				Dim num2 As Double = Math.Cos(num)
				Dim num3 As Double = Math.Sin(num)
				Dim array As Point() = New Point(A_0.Length - 1 + 1 - 1) {}
				Dim num4 As Integer = A_0.Length - 1
				For i As Integer = 0 To num4
					Dim num5 As Double = CDbl((CSng(A_0(i).X) - pointF.X))
					Dim num6 As Double = CDbl((CSng(A_0(i).Y) - pointF.Y))
					Dim num7 As Double = num5 * num2 - num6 * num3
					Dim num8 As Double = num5 * num3 + num6 * num2
					array(i) = New Point(CInt(Math.Round(num7 + CDbl(pointF.X))), CInt(Math.Round(num8 + CDbl(pointF.Y))))
				Next
				result = array
			End If
			Return result
		End Function

		' Token: 0x06000EE4 RID: 3812 RVA: 0x00065ADC File Offset: 0x00063CDC
		Public Function RolateGeoPoints(geoPoints As IEnumerable(Of GeoPoint), angle As Double) As List(Of GeoPoint)
			Dim list As List(Of Point) = New List(Of Point)()
			Try
				For Each geoPoint As GeoPoint In geoPoints
					Dim point As Point = MyBase.GeographicToScreen(geoPoint.Location)
					list.Add(New Point(CInt(Math.Round(point.X)), CInt(Math.Round(point.Y))))
				Next
			Finally
				Dim enumerator As IEnumerator(Of GeoPoint)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim array As Point() = Me.O._O0O0_o.(list.ToArray(), angle)
			Dim list2 As List(Of GeoPoint) = New List(Of GeoPoint)()
			For Each point2 As Point In array
				Dim point3 As Point
				point3..ctor(CDbl(point2.X), CDbl(point2.Y))
				point3 = MyBase.ScreenToGeographic(point3)
				list2.Add(New GeoPoint(point3.X, point3.Y))
			Next
			list = Nothing
			Return list2
		End Function

		' Token: 0x06000EE5 RID: 3813 RVA: 0x00065BC8 File Offset: 0x00063DC8
		Public Function RolateGeoPointString(geoPointsString As String, angle As Double) As String
			Dim array As String() = geoPointsString.Split(New Char() { ","c })
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				list.Add(New GeoPoint(num2, num3))
			Next
			list = Me.RolateGeoPoints(list, angle)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Try
				For Each geoPoint As GeoPoint In list
					stringBuilder.Append(Conversions.ToString(geoPoint.X) + "," + Conversions.ToString(geoPoint.Y) + ",")
				Next
			Finally
				Dim enumerator As List(Of GeoPoint).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x06000EE6 RID: 3814 RVA: 0x00065CBC File Offset: 0x00063EBC
		Public Function MoveGeoPointString(geoPointsString As String, dx As Integer, dy As Integer) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array As String() = geoPointsString.Split(New Char() { ","c })
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				Dim point As Point
				point..ctor(num2, num3)
				point = MyBase.GeographicToScreen(point)
				Dim pointF As PointF = point.ToPointF()
				point..ctor(CDbl((pointF.X + CSng(dx))), CDbl((pointF.Y + CSng(dy))))
				point = MyBase.ScreenToGeographic(point)
				stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y) + ",")
			Next
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x06000EE7 RID: 3815 RVA: 0x00065D98 File Offset: 0x00063F98
		Public Function AlignGeoPointString(TargettItemPointString As String, TargetItemType As String, ItemPointString As String, ItemType As String, Direction As String) As String
			Dim list As List(Of Point) = New List(Of Point)()
			Dim list2 As List(Of Point) = New List(Of Point)()
			Dim array As String() = TargettItemPointString.Split(New Char() { ","c })
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				list.Add(New Point(num2, num3))
			Next
			array = ItemPointString.Split(New Char() { ","c })
			Dim num4 As Integer = array.Length - 2
			For j As Integer = 0 To num4 Step 2
				Dim num5 As Double = Conversions.ToDouble(array(j))
				Dim num6 As Double = Conversions.ToDouble(array(j + 1))
				list2.Add(New Point(num5, num6))
			Next
			Dim array2 As Point() = Me.o_0__oo.oo_.(list.ToArray(), TargetItemType, list2.ToArray(), ItemType, Direction)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim num7 As Integer = array2.Length - 1
			For k As Integer = 0 To num7
				stringBuilder.Append(Conversions.ToString(array2(k).X) + "," + Conversions.ToString(array2(k).Y) + ",")
			Next
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x06000EE8 RID: 3816 RVA: 0x00065EDC File Offset: 0x000640DC
		Private Function <<EMPTY_NAME>>(A_0 As Point(), A_1 As String, A_2 As Point(), A_3 As String, A_4 As String) As Point()
			If Operators.CompareString(A_1, "Diamond", True) = 0 Then
				Dim point As Point = A_0(0)
				Dim point2 As Point = A_0(1)
				A_0(0) = New Point(point.X, point2.Y)
				A_0(1) = New Point(point.X + (point2.X - point.X) * 2.0, point2.Y + (point.Y - point2.Y) * 2.0)
			ElseIf Operators.CompareString(A_1, "Circle", True) = 0 Then
				Dim point3 As Point = A_0(0)
				Dim point4 As Point = A_0(1)
				point3 = MyBase.GeographicToScreen(point3)
				point4 = MyBase.GeographicToScreen(point4)
				Dim num As Double = point4.X - point3.X
				Dim num2 As Double = point4.Y - point3.Y
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				A_0(0) = New Point(point3.X - num3, point3.Y - num3)
				A_0(1) = New Point(point3.X + num3, point3.Y + num3)
				A_0(0) = MyBase.ScreenToGeographic(A_0(0))
				A_0(1) = MyBase.ScreenToGeographic(A_0(1))
			End If
			If Operators.CompareString(A_3, "Diamond", True) = 0 Then
				Dim point5 As Point = A_2(0)
				Dim point6 As Point = A_2(1)
				A_2(0) = New Point(point5.X, point6.Y)
				A_2(1) = New Point(point5.X + (point6.X - point5.X) * 2.0, point6.Y + (point5.Y - point6.Y) * 2.0)
			ElseIf Operators.CompareString(A_3, "Circle", True) = 0 Then
				Dim point7 As Point = A_2(0)
				Dim point8 As Point = A_2(1)
				point7 = MyBase.GeographicToScreen(point7)
				point8 = MyBase.GeographicToScreen(point8)
				Dim num4 As Double = point8.X - point7.X
				Dim num5 As Double = point8.Y - point7.Y
				Dim num6 As Double = Math.Sqrt(num4 * num4 + num5 * num5)
				A_2(0) = New Point(point7.X - num6, point7.Y - num6)
				A_2(1) = New Point(point7.X + num6, point7.Y + num6)
				A_2(0) = MyBase.ScreenToGeographic(A_2(0))
				A_2(1) = MyBase.ScreenToGeographic(A_2(1))
			End If
			Dim num7 As Double
			Dim num8 As Double
			If Operators.CompareString(A_4, "left", True) = 0 Then
				num7 = Me.O0o000O._oo.(A_2, True, False) - Me.O0o000O._oo.(A_0, True, False)
			ElseIf Operators.CompareString(A_4, "right", True) = 0 Then
				num7 = Me.O0o000O._oo.(A_2, True, True) - Me.O0o000O._oo.(A_0, True, True)
			ElseIf Operators.CompareString(A_4, "top", True) = 0 Then
				num8 = Me.O0o000O._oo.(A_2, False, True) - Me.O0o000O._oo.(A_0, False, True)
			ElseIf Operators.CompareString(A_4, "bottom", True) = 0 Then
				num8 = Me.O0o000O._oo.(A_2, False, False) - Me.O0o000O._oo.(A_0, False, False)
			End If
			Dim num9 As Integer = A_2.Length - 1
			For i As Integer = 0 To num9
				A_2(i).X = A_2(i).X - num7
				A_2(i).Y = A_2(i).Y - num8
			Next
			If Operators.CompareString(A_3, "Diamond", True) = 0 Then
				Dim point9 As Point = A_2(0)
				Dim point10 As Point = A_2(1)
				A_2(0) = New Point(point9.X, (point9.Y + point10.Y) / 2.0)
				A_2(1) = New Point((point9.X + point10.X) / 2.0, point10.Y)
			ElseIf Operators.CompareString(A_3, "Circle", True) = 0 Then
				Dim point11 As Point = A_2(0)
				Dim point12 As Point = A_2(1)
				A_2(0) = New Point((point11.X + point12.X) / 2.0, (point11.Y + point12.Y) / 2.0)
				A_2(1) = New Point((point11.X + point12.X) / 2.0, point11.Y)
			End If
			Return A_2
		End Function

		' Token: 0x06000EE9 RID: 3817 RVA: 0x0006639C File Offset: 0x0006459C
		Private Function <<EMPTY_NAME>>(A_0 As Point(), A_1 As Boolean, A_2 As Boolean) As Double
			Dim num As Double
			If A_2 Then
				num = Double.MinValue
			Else
				num = Double.MaxValue
			End If
			Dim num2 As Integer = A_0.Length - 1
			For i As Integer = 0 To num2
				If A_2 Then
					If A_1 Then
						num = Math.Max(num, A_0(i).X)
					Else
						num = Math.Max(num, A_0(i).Y)
					End If
				ElseIf A_1 Then
					num = Math.Min(num, A_0(i).X)
				Else
					num = Math.Min(num, A_0(i).Y)
				End If
			Next
			Return num
		End Function

		' Token: 0x06000EEA RID: 3818 RVA: 0x00066430 File Offset: 0x00064630
		Public Function SameGeoPointString(TargettItemPointString As String, TargetItemType As String, ItemPointString As String, ItemType As String) As String
			Dim list As List(Of Point) = New List(Of Point)()
			Dim list2 As List(Of Point) = New List(Of Point)()
			Dim array As String() = TargettItemPointString.Split(New Char() { ","c })
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				list.Add(New Point(num2, num3))
			Next
			array = ItemPointString.Split(New Char() { ","c })
			Dim num4 As Integer = array.Length - 2
			For j As Integer = 0 To num4 Step 2
				Dim num5 As Double = Conversions.ToDouble(array(j))
				Dim num6 As Double = Conversions.ToDouble(array(j + 1))
				list2.Add(New Point(num5, num6))
			Next
			Dim array2 As Point() = Me.O._O0O0_o.(list.ToArray(), TargetItemType, list2.ToArray(), ItemType)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim num7 As Integer = array2.Length - 1
			For k As Integer = 0 To num7
				stringBuilder.Append(Conversions.ToString(array2(k).X) + "," + Conversions.ToString(array2(k).Y) + ",")
			Next
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x06000EEB RID: 3819 RVA: 0x00066574 File Offset: 0x00064774
		Private Function <<EMPTY_NAME>>(A_0 As Point(), A_1 As String, A_2 As Point(), A_3 As String) As Point()
			If Operators.CompareString(A_1, "Diamond", True) = 0 Then
				Dim point As Point = A_0(0)
				Dim point2 As Point = A_0(1)
				A_0(0) = New Point(point.X, point2.Y)
				A_0(1) = New Point(point.X + (point2.X - point.X) * 2.0, point2.Y + (point.Y - point2.Y) * 2.0)
			ElseIf Operators.CompareString(A_1, "Circle", True) = 0 Then
				Dim point3 As Point = A_0(0)
				Dim point4 As Point = A_0(1)
				point3 = MyBase.GeographicToScreen(point3)
				point4 = MyBase.GeographicToScreen(point4)
				Dim num As Double = point4.X - point3.X
				Dim num2 As Double = point4.Y - point3.Y
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				A_0(0) = New Point(point3.X - num3, point3.Y - num3)
				A_0(1) = New Point(point3.X + num3, point3.Y + num3)
				A_0(0) = MyBase.ScreenToGeographic(A_0(0))
				A_0(1) = MyBase.ScreenToGeographic(A_0(1))
			ElseIf(Operators.CompareString(A_1, "Line", True) = 0 OrElse Operators.CompareString(A_1, "Bezier", True) = 0) AndAlso A_0.Length > 2 Then
				Return A_2
			End If
			If Operators.CompareString(A_3, "Diamond", True) = 0 Then
				Dim point5 As Point = A_2(0)
				Dim point6 As Point = A_2(1)
				A_2(0) = New Point(point5.X, point6.Y)
				A_2(1) = New Point(point5.X + (point6.X - point5.X) * 2.0, point6.Y + (point5.Y - point6.Y) * 2.0)
			ElseIf Operators.CompareString(A_3, "Circle", True) = 0 Then
				Dim point7 As Point = A_2(0)
				Dim point8 As Point = A_2(1)
				point7 = MyBase.GeographicToScreen(point7)
				point8 = MyBase.GeographicToScreen(point8)
				Dim num4 As Double = point8.X - point7.X
				Dim num5 As Double = point8.Y - point7.Y
				Dim num6 As Double = Math.Sqrt(num4 * num4 + num5 * num5)
				A_2(0) = New Point(point7.X - num6, point7.Y - num6)
				A_2(1) = New Point(point7.X + num6, point7.Y + num6)
				A_2(0) = MyBase.ScreenToGeographic(A_2(0))
				A_2(1) = MyBase.ScreenToGeographic(A_2(1))
			ElseIf(Operators.CompareString(A_3, "Line", True) = 0 OrElse Operators.CompareString(A_3, "Bezier", True) = 0) AndAlso A_2.Length > 2 Then
				Return A_2
			End If
			Dim num7 As Double = Math.Abs(A_0(1).X - A_0(0).X)
			Dim num8 As Double = Math.Abs(A_0(1).Y - A_0(0).Y)
			If Operators.CompareString(A_3, "Line", True) = 0 OrElse Operators.CompareString(A_3, "Bezier", True) = 0 Then
				If Math.Round(A_2(0).X, 6) = Math.Round(A_2(1).X, 6) Then
					If A_2(1).Y > A_2(0).Y Then
						A_2(1).Y = A_2(0).Y + num8
					Else
						A_2(1).Y = A_2(0).Y - num8
					End If
				ElseIf Math.Round(A_2(0).Y, 6) = Math.Round(A_2(1).Y, 6) Then
					If A_2(1).X > A_2(0).X Then
						A_2(1).X = A_2(0).X + num7
					Else
						A_2(1).X = A_2(0).X - num7
					End If
				Else
					If A_2(1).Y > A_2(0).Y Then
						A_2(1).Y = A_2(0).Y + num8
					Else
						A_2(1).Y = A_2(0).Y - num8
					End If
					If A_2(1).X > A_2(0).X Then
						A_2(1).X = A_2(0).X + num7
					Else
						A_2(1).X = A_2(0).X - num7
					End If
				End If
			Else
				If A_2(1).Y > A_2(0).Y Then
					A_2(1).Y = A_2(0).Y + num8
				Else
					A_2(1).Y = A_2(0).Y - num8
				End If
				If A_2(1).X > A_2(0).X Then
					A_2(1).X = A_2(0).X + num7
				Else
					A_2(1).X = A_2(0).X - num7
				End If
			End If
			If Operators.CompareString(A_3, "Diamond", True) = 0 Then
				Dim point9 As Point = A_2(0)
				Dim point10 As Point = A_2(1)
				A_2(0) = New Point(point9.X, (point9.Y + point10.Y) / 2.0)
				A_2(1) = New Point((point9.X + point10.X) / 2.0, point10.Y)
			ElseIf Operators.CompareString(A_3, "Circle", True) = 0 Then
				Dim point11 As Point = A_2(0)
				Dim point12 As Point = A_2(1)
				A_2(0) = New Point((point11.X + point12.X) / 2.0, (point11.Y + point12.Y) / 2.0)
				A_2(1) = New Point(point12.X, (point11.Y + point12.Y) / 2.0)
			End If
			Return A_2
		End Function

		' Token: 0x1700029D RID: 669
		' (get) Token: 0x06000EEC RID: 3820 RVA: 0x00066C50 File Offset: 0x00064E50
		' (set) Token: 0x06000EED RID: 3821 RVA: 0x00066CCC File Offset: 0x00064ECC
		Public Property TileSource As TileSoureEnum
			Get
				Dim result As TileSoureEnum
				If MyBase.TileLayer.TileSource Is Nothing Then
					result = TileSoureEnum.None
				ElseIf TypeOf MyBase.TileLayer.TileSource Is VirtualEarthRoadSource Then
					result = TileSoureEnum.Road
				ElseIf TypeOf MyBase.TileLayer.TileSource Is VirtualEarthAerialSource Then
					result = TileSoureEnum.Aerial
				ElseIf TypeOf MyBase.TileLayer.TileSource Is VirtualEarthHybridSource Then
					result = TileSoureEnum.Hybrid
				ElseIf TypeOf MyBase.TileLayer.TileSource Is CustomTileSource Then
					result = TileSoureEnum.Custom
				Else
					result = TileSoureEnum.None
				End If
				Return result
			End Get
			Set(value As TileSoureEnum)
				Select Case value
					Case TileSoureEnum.None
						MyBase.TileLayer.TileSource = Nothing
						Return
					Case TileSoureEnum.Road
						MyBase.TileLayer.TileSource = New VirtualEarthRoadSource()
						Return
					Case TileSoureEnum.Aerial
						MyBase.TileLayer.TileSource = New VirtualEarthAerialSource()
						Return
					Case TileSoureEnum.Hybrid
						MyBase.TileLayer.TileSource = New VirtualEarthHybridSource()
						Return
					Case TileSoureEnum.Custom
						MyBase.TileLayer.TileSource = New CustomTileSource(Me)
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x1700029E RID: 670
		' (get) Token: 0x06000EEE RID: 3822 RVA: 0x00066D47 File Offset: 0x00064F47
		' (set) Token: 0x06000EEF RID: 3823 RVA: 0x00066D5A File Offset: 0x00064F5A
		Public Property Zoom As Double
			Get
				Return Math.Round(MyBase.Viewport.Zoom, 6)
			End Get
			Set(value As Double)
				MyBase.Viewport.Zoom = value
			End Set
		End Property

		' Token: 0x1700029F RID: 671
		' (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00066D68 File Offset: 0x00064F68
		' (set) Token: 0x06000EF1 RID: 3825 RVA: 0x00066D75 File Offset: 0x00064F75
		Public Property MaxZoom As Double
			Get
				Return MyBase.Viewport.MaxZoom
			End Get
			Set(value As Double)
				MyBase.Viewport.MaxZoom = value
			End Set
		End Property

		' Token: 0x170002A0 RID: 672
		' (get) Token: 0x06000EF2 RID: 3826 RVA: 0x00066D83 File Offset: 0x00064F83
		' (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00066D90 File Offset: 0x00064F90
		Public Property MinZoom As Double
			Get
				Return MyBase.Viewport.MinZoom
			End Get
			Set(value As Double)
				MyBase.Viewport.MinZoom = value
			End Set
		End Property

		' Token: 0x170002A1 RID: 673
		' (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00066D9E File Offset: 0x00064F9E
		' (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00066DAB File Offset: 0x00064FAB
		Public Property ZoomToolVisible As Boolean
			Get
				Return MyBase.ZoomTool.Visible
			End Get
			Set(value As Boolean)
				MyBase.ZoomTool.Visible = value
			End Set
		End Property

		' Token: 0x170002A2 RID: 674
		' (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00066DB9 File Offset: 0x00064FB9
		' (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00066DC6 File Offset: 0x00064FC6
		Public Property PanToolVisible As Boolean
			Get
				Return MyBase.PanTool.Visible
			End Get
			Set(value As Boolean)
				MyBase.PanTool.Visible = value
			End Set
		End Property

		' Token: 0x170002A3 RID: 675
		' (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00066DD4 File Offset: 0x00064FD4
		' (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00066DE1 File Offset: 0x00064FE1
		Public Property DistanceScaleVisible As Boolean
			Get
				Return MyBase.DistanceScale.Visible
			End Get
			Set(value As Boolean)
				MyBase.DistanceScale.Visible = value
			End Set
		End Property

		' Token: 0x170002A4 RID: 676
		' (get) Token: 0x06000EFA RID: 3834 RVA: 0x00066DEF File Offset: 0x00064FEF
		' (set) Token: 0x06000EFB RID: 3835 RVA: 0x00066DF7 File Offset: 0x00064FF7
		Public Property CurrentTabOrder As Integer
			Get
				Return Me.O.oO_O_.
			End Get
			Set(value As Integer)
				Me.O.oO_O_. = value
			End Set
		End Property

		' Token: 0x170002A5 RID: 677
		' (get) Token: 0x06000EFC RID: 3836 RVA: 0x00066E00 File Offset: 0x00065000
		' (set) Token: 0x06000EFD RID: 3837 RVA: 0x00066E08 File Offset: 0x00065008
		Public Property MaxTabOrder As Integer
			Get
				Return Me.OO0o._.
			End Get
			Set(value As Integer)
				Me.OO0o._. = value
			End Set
		End Property

		' Token: 0x06000EFE RID: 3838 RVA: 0x00066E11 File Offset: 0x00065011
		Public Sub StartSetTabOrder() Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			oOO0oo_o0.O00OO_O_oO_.o.(Me, MyBase.Controls)
		End Sub

		' Token: 0x06000EFF RID: 3839 RVA: 0x00066E1F File Offset: 0x0006501F
		Public Sub StopSetTabOrder() Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			oOO0oo_o0.O._0O0__o.(MyBase.Controls)
		End Sub

		' Token: 0x06000F00 RID: 3840 RVA: 0x00066E2C File Offset: 0x0006502C
		Public Function GetGeoPointByDistanceAngle(startPoint As GeoPoint, distanceKm As Double, angleY As Double) As GeoPoint
			angleY = -angleY
			Dim num As Double = startPoint.X * 3.1415926535897931 / 180.0
			Dim num2 As Double = startPoint.Y * 3.1415926535897931 / 180.0
			Dim num3 As Double = (90.0 - angleY) * 3.1415926535897931 / 180.0
			Dim num4 As Double = distanceKm / 6371.0
			Dim num5 As Double = Math.Asin(Math.Sin(num2) * Math.Cos(num4) + Math.Cos(num2) * Math.Sin(num4) * Math.Cos(num3))
			Dim num6 As Double = num + Math.Atan2(Math.Sin(num3) * Math.Sin(num4) * Math.Cos(num2), Math.Cos(num4) - Math.Sin(num2) * Math.Sin(num5))
			Dim num7 As Double = num5 * 180.0 / 3.1415926535897931
			Dim num8 As Double
			num8 = num6 * 180.0 / 3.1415926535897931
			While num8 > 180.0
				num8 -= 360.0
			End While
			While num8 < -180.0
				num8 += 360.0
			End While
			Return New GeoPoint(num8, num7)
		End Function

		' Token: 0x06000F01 RID: 3841 RVA: 0x00066F64 File Offset: 0x00065164
		Public Function IsGeoPointInPolygon(gp As GeoPoint, polygon As VectorPolygon) As Boolean
			Dim point As Point
			point..ctor(gp.X, gp.Y)
			Dim a_ As PointF = MyBase.GeographicToScreen(point).ToPointF()
			Dim list As List(Of PointF) = New List(Of PointF)()
			If TypeOf polygon.Geometry Is GeoPolygon Then
				Try
					For Each geoLinearRing As GeoLinearRing In CType(polygon.Geometry, GeoPolygon).Rings
						list.Clear()
						Try
							For Each geoPoint As GeoPoint In geoLinearRing.Points
								point = New Point(geoPoint.X, geoPoint.Y)
								list.Add(MyBase.GeographicToScreen(point).ToPointF())
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of GeoPoint)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						If Me.OoO_0o.0O00.(a_, list) Then
							Return True
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of GeoLinearRing)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			Return False
		End Function

		' Token: 0x06000F02 RID: 3842 RVA: 0x00067074 File Offset: 0x00065274
		Private Function <<EMPTY_NAME>>(A_0 As PointF, A_1 As List(Of PointF)) As Boolean
			Dim result As Boolean
			If A_1.Count < 3 Then
				result = False
			Else
				Dim count As Integer = A_1.Count
				Dim num As Integer = count - 1
				For i As Integer = 0 To num
					Dim a_ As PointF = A_1(i)
					Dim a_2 As PointF = A_1((i + 1) Mod count)
					If Me.OoO_0o.0O00.(A_0, a_, a_2) Then
						Return True
					End If
				Next
				Dim flag As Boolean = False
				Dim num2 As Integer = count - 1
				For j As Integer = 0 To num2
					Dim pointF As PointF = A_1(j)
					Dim pointF2 As PointF = A_1((j + 1) Mod count)
					Dim y As Single = pointF.Y
					Dim y2 As Single = pointF2.Y
					If y <> y2 AndAlso (y > A_0.Y Xor y2 > A_0.Y) Then
						Dim num3 As Single = (A_0.Y - y) / (y2 - y)
						If pointF.X + num3 * (pointF2.X - pointF.X) > A_0.X Then
							flag = Not flag
						End If
					End If
				Next
				result = flag
			End If
			Return result
		End Function

		' Token: 0x06000F03 RID: 3843 RVA: 0x0006717C File Offset: 0x0006537C
		Private Function <<EMPTY_NAME>>(A_0 As PointF, A_1 As PointF, A_2 As PointF) As Boolean
			Return A_0.X >= Math.Min(A_1.X, A_2.X) - 0.0001F AndAlso A_0.X <= Math.Max(A_1.X, A_2.X) + 0.0001F AndAlso A_0.Y >= Math.Min(A_1.Y, A_2.Y) - 0.0001F AndAlso A_0.Y <= Math.Max(A_1.Y, A_2.Y) + 0.0001F AndAlso Math.Abs((A_2.X - A_1.X) * (A_0.Y - A_1.Y) - (A_2.Y - A_1.Y) * (A_0.X - A_1.X)) < 0.0001F
		End Function

		' Token: 0x06000F04 RID: 3844 RVA: 0x0006726C File Offset: 0x0006546C
		Public Function CreateEllipse(PointsString As String) As VectorPolygon
			Dim array As String() = PointsString.Split(New Char() { ","c })
			Dim result As VectorPolygon
			If array.Length = 4 Then
				Dim gp As GeoPoint = New GeoPoint(Conversions.ToDouble(array(0)), Conversions.ToDouble(array(1)))
				Dim gp2 As GeoPoint = New GeoPoint(Conversions.ToDouble(array(2)), Conversions.ToDouble(array(3)))
				result = Me.CreateEllipse(gp, gp2)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06000F05 RID: 3845 RVA: 0x000672CC File Offset: 0x000654CC
		Public Function CreateEllipse(gp1 As GeoPoint, gp2 As GeoPoint) As VectorPolygon
			Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
			Dim num As Double = Math.Min(gp1.X, gp2.X)
			Dim num2 As Double = Math.Max(gp1.X, gp2.X)
			Dim num3 As Double = Math.Min(gp1.Y, gp2.Y)
			Dim num4 As Double = Math.Max(gp1.Y, gp2.Y)
			Dim point As Point
			point..ctor(num, num3)
			Dim point2 As Point
			point2..ctor(num2, num4)
			point = MyBase.GeographicToScreen(point)
			point2 = MyBase.GeographicToScreen(point2)
			num = Math.Min(point.X, point2.X)
			num2 = Math.Max(point.X, point2.X)
			num3 = Math.Min(point.Y, point2.Y)
			num4 = Math.Max(point.Y, point2.Y)
			Dim num5 As Double = (num + num2) / 2.0
			Dim num6 As Double = (num3 + num4) / 2.0
			Dim num7 As Double = (num2 - num) / 2.0
			Dim num8 As Double = (num4 - num3) / 2.0
			Dim num9 As Integer = 0
			Do
				Dim num10 As Double = CDbl(num9) * 3.1415926535897931 / 180.0
				Dim num11 As Double = num5 + num7 * Math.Cos(num10)
				Dim num12 As Double = num6 + num8 * Math.Sin(num10)
				Dim point3 As Point
				point3..ctor(num11, num12)
				point3 = MyBase.ScreenToGeographic(point3)
				list.Add(New GeoPoint(point3.X, point3.Y))
				num9 += 1
			Loop While num9 <= 359
			Return Me.CreatePolygon(list)
		End Function

		' Token: 0x06000F06 RID: 3846 RVA: 0x0006745C File Offset: 0x0006565C
		Public Function CreateDiamond(gp1 As GeoPoint, gp2 As GeoPoint) As VectorPolygon
			Return Me.CreateDiamond(gp1, gp2, False)
		End Function

		' Token: 0x06000F07 RID: 3847 RVA: 0x00067468 File Offset: 0x00065668
		Public Function CreateDiamond(gp1 As GeoPoint, gp2 As GeoPoint, diagonal As Boolean) As VectorPolygon
			Dim result As VectorPolygon
			If diagonal Then
				Dim point As Point = MyBase.GeographicToScreen(gp1.Location)
				Dim point2 As Point = MyBase.GeographicToScreen(gp2.Location)
				Dim point3 As Point
				point3..ctor(point2.X, point.Y)
				Dim point4 As Point
				point4..ctor(point.X, point2.Y)
				Dim point5 As Point
				point5..ctor((point.X + point3.X) / 2.0, point.Y)
				Dim point6 As Point
				point6..ctor(point3.X, (point.Y + point4.Y) / 2.0)
				Dim point7 As Point
				point7..ctor((point.X + point3.X) / 2.0, point2.Y)
				Dim point8 As Point
				point8..ctor(point.X, (point.Y + point4.Y) / 2.0)
				point5 = MyBase.ScreenToGeographic(point5)
				point6 = MyBase.ScreenToGeographic(point6)
				point7 = MyBase.ScreenToGeographic(point7)
				point8 = MyBase.ScreenToGeographic(point8)
				result = Me.CreatePolygon(New GeoPoint() { New GeoPoint(point5.X, point5.Y), New GeoPoint(point6.X, point6.Y), New GeoPoint(point7.X, point7.Y), New GeoPoint(point8.X, point8.Y) })
			Else
				Dim point9 As Point = MyBase.GeographicToScreen(gp1.Location)
				Dim point10 As Point = MyBase.GeographicToScreen(gp2.Location)
				Dim point11 As Point
				point11..ctor(point9.X + (point10.X - point9.X) * 2.0, point9.Y)
				Dim point12 As Point
				point12..ctor(point10.X, point10.Y + (point9.Y - point10.Y) * 2.0)
				point11 = MyBase.ScreenToGeographic(point11)
				point12 = MyBase.ScreenToGeographic(point12)
				result = Me.CreatePolygon(New GeoPoint() { gp1, gp2, New GeoPoint(point11.X, point11.Y), New GeoPoint(point12.X, point12.Y) })
			End If
			Return result
		End Function

		' Token: 0x06000F08 RID: 3848 RVA: 0x000676BD File Offset: 0x000658BD
		Public Function CreateDiamond(PointsString As String) As VectorPolygon
			Return Me.CreateDiamond(PointsString, False)
		End Function

		' Token: 0x06000F09 RID: 3849 RVA: 0x000676C8 File Offset: 0x000658C8
		Public Function CreateDiamond(PointsString As String, diagonal As Boolean) As VectorPolygon
			Dim array As String() = PointsString.Split(New Char() { ","c })
			Dim result As VectorPolygon
			If array.Length = 4 Then
				Dim gp As GeoPoint = New GeoPoint(Conversions.ToDouble(array(0)), Conversions.ToDouble(array(1)))
				Dim gp2 As GeoPoint = New GeoPoint(Conversions.ToDouble(array(2)), Conversions.ToDouble(array(3)))
				result = Me.CreateDiamond(gp, gp2, diagonal)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x170002A6 RID: 678
		' (get) Token: 0x06000F0A RID: 3850 RVA: 0x00067728 File Offset: 0x00065928
		' (set) Token: 0x06000F0B RID: 3851 RVA: 0x00067754 File Offset: 0x00065954
		Public Property UseGallPetersProjection As Boolean
			Get
				Return TypeOf CType(MyBase.CoordinateSystem, GeographicCoordinateSystem).Projection Is oo_Oo0O_O
			End Get
			Set(value As Boolean)
				Dim geographicCoordinateSystem As GeographicCoordinateSystem = CType(MyBase.CoordinateSystem, GeographicCoordinateSystem)
				geographicCoordinateSystem.Projection = New oo_Oo0O_O()
			End Set
		End Property

		' Token: 0x06000F0C RID: 3852 RVA: 0x00067778 File Offset: 0x00065978
		Public Function ToScreenPoint(point As GeoPoint) As Point
			Dim point2 As Point = point.Location
			point2 = MyBase.GeographicToScreen(point2)
			Return New Point(CInt(Math.Round(point2.X)), CInt(Math.Round(point2.Y)))
		End Function

		' Token: 0x06000F0D RID: 3853 RVA: 0x000677B4 File Offset: 0x000659B4
		Public Function ToScreenPointsString(points As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array As String() = points.Split(New Char() { ","c })
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				Dim point As Point
				point..ctor(num2, num3)
				point = MyBase.GeographicToScreen(point)
				stringBuilder.Append(Conversions.ToString(CInt(Math.Round(point.X))) + "," + Conversions.ToString(CInt(Math.Round(point.Y))) + ",")
			Next
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x06000F0E RID: 3854 RVA: 0x00067868 File Offset: 0x00065A68
		Public Function ToGeoPoint(point As Point) As GeoPoint
			Dim point2 As Point
			point2..ctor(CDbl(point.X), CDbl(point.Y))
			point2 = MyBase.ScreenToGeographic(point2)
			Return New GeoPoint(point2.X, point2.Y)
		End Function

		' Token: 0x06000F0F RID: 3855 RVA: 0x000678A8 File Offset: 0x00065AA8
		Public Function ToGeoPointsString(points As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array As String() = points.Split(New Char() { ","c })
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num Step 2
				Dim num2 As Double = Conversions.ToDouble(array(i))
				Dim num3 As Double = Conversions.ToDouble(array(i + 1))
				Dim point As Point
				point..ctor(num2, num3)
				point = MyBase.ScreenToGeographic(point)
				stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y) + ",")
			Next
			Return stringBuilder.ToString().Trim(New Char() { ","c })
		End Function

		' Token: 0x040005CB RID: 1483
		Friend <<EMPTY_NAME>> As Dictionary(Of String, CustomMarkShape)

		' Token: 0x040005CC RID: 1484
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040005CD RID: 1485
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x02000136 RID: 310
		<CompilerGenerated()>
		Friend NotInheritable Class O0OO0O0o
			' Token: 0x06000F17 RID: 3863 RVA: 0x00067958 File Offset: 0x00065B58
			Friend Function <<EMPTY_NAME>>(A_0 As GeoPoint, A_1 As GeoPoint) As List(Of GeoPoint)
				Dim list As List(Of GeoPoint) = New List(Of GeoPoint)()
				Dim pointF As PointF = Me.O.oO_O_..GeographicToScreen(A_0.Location).ToPointF()
				Dim pointF2 As PointF = Me.O.oO_O_..GeographicToScreen(A_1.Location).ToPointF()
				Dim num As Double = CDbl((pointF2.X - pointF.X))
				Dim num2 As Double = CDbl((pointF2.Y - pointF.Y))
				Dim num3 As Double = Math.Sqrt(num * num + num2 * num2)
				Dim result As List(Of GeoPoint)
				If num3 <= 0.0 Then
					result = list
				Else
					Dim num4 As Double = num / num3
					Dim num5 As Double = num2 / num3
					Dim num6 As Double = -num4
					Dim num7 As Double = -num5
					Dim num8 As Double = Me.O.oO_O_. / 180.0 * 3.1415926535897931
					Dim num9 As Double = Math.Cos(num8)
					Dim num10 As Double = Math.Sin(num8)
					Dim num11 As Double = CDbl(pointF2.X) + (num6 * num9 - num7 * num10) * Me.OO0o._.
					Dim num12 As Double = CDbl(pointF2.Y) + (num6 * num10 + num7 * num9) * Me.OO0o._.
					Dim num13 As Double = CDbl(pointF2.X) + (num6 * num9 + num7 * num10) * Me.OO0o._.
					Dim num14 As Double = CDbl(pointF2.Y) + (-num6 * num10 + num7 * num9) * Me.OO0o._.
					Dim point As Point
					point..ctor(num11, num12)
					Dim point2 As Point
					point2..ctor(num13, num14)
					point = Me.O.oO_O_..ScreenToGeographic(point)
					point2 = Me.O.oO_O_..ScreenToGeographic(point2)
					list.Add(New GeoPoint(point.X, point.Y))
					list.Add(New GeoPoint(point2.X, point2.Y))
					result = list
				End If
				Return result
			End Function

			' Token: 0x040005CE RID: 1486
			Public <<EMPTY_NAME>> As Double

			' Token: 0x040005CF RID: 1487
			Public <<EMPTY_NAME>> As Double

			' Token: 0x040005D0 RID: 1488
			Public <<EMPTY_NAME>> As GeoMap
		End Class
	End Class
End Namespace
