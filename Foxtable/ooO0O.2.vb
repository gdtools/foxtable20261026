Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000131 RID: 305
	Friend NotInheritable Module ooO0O
		' Token: 0x06000E9C RID: 3740 RVA: 0x00062B3C File Offset: 0x00060D3C
		Public Function <<EMPTY_NAME>>(A_0 As PointF(), Optional A_1 As Single = -1F, Optional A_2 As Single = 2F, Optional A_3 As Single = 8F, Optional A_4 As Single = 0.5F, Optional A_5 As Integer = 3, Optional A_6 As Boolean = False) As List(Of PointF)
			Dim result As List(Of PointF)
			If A_0 Is Nothing OrElse A_0.Length < 2 Then
				result = New List(Of PointF)()
			Else
				If A_2 <= 0F Then
					Throw New ArgumentException("采样距离必须大于0", "sampleDistance")
				End If
				If A_3 <= 0F Then
					Throw New ArgumentException("箭头长度必须大于0", "arrowLength")
				End If
				If CDbl(A_1) >= 3.1415926535897931 Then
					Throw New ArgumentOutOfRangeException("arrowAngle", "箭头角度必须在0~π弧度之间（0~180°）")
				End If
				If A_4 < 0F OrElse A_4 > 1F Then
					Throw New ArgumentOutOfRangeException("tension", "张力必须在0~1之间")
				End If
				If A_5 < 2 Then
					A_5 = 2
				End If
				Dim list As List(Of PointF) = ooO0O.O_O_.0oooo_oo.(A_0, A_2, A_4)
				If list.Count < 2 OrElse A_1 <= 0F Then
					result = list
				Else
					If A_6 Then
						Dim pointF As PointF = ooO0O.O.O00.(list, A_5)
						Dim a_ As PointF = New PointF(-pointF.X, -pointF.Y)
						Dim collection As List(Of PointF) = ooO0O.O_O_.0oooo_oo.(list(0), a_, A_3, A_1)
						list.InsertRange(0, collection)
					End If
					Dim a_2 As PointF = ooO0O.O0.oo0O.(list, A_5)
					Dim collection2 As List(Of PointF) = ooO0O.O_O_.0oooo_oo.(list(list.Count - 1), a_2, A_3, A_1)
					list.AddRange(collection2)
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x06000E9D RID: 3741 RVA: 0x00062C60 File Offset: 0x00060E60
		Private Function <<EMPTY_NAME>>(A_0 As PointF(), A_1 As Single, Optional A_2 As Single = 0.5F) As List(Of PointF)
			Dim result As List(Of PointF)
			If A_0 Is Nothing OrElse A_0.Length < 2 Then
				result = New List(Of PointF)()
			Else
				Using graphicsPath As GraphicsPath = New GraphicsPath()
					If A_0.Length = 2 Then
						graphicsPath.AddLine(A_0(0), A_0(1))
					Else
						graphicsPath.AddCurve(A_0, A_2)
					End If
					Dim matrix As Matrix = New Matrix()
					graphicsPath.Flatten(matrix, 0.1F)
					Dim pathPoints As PointF() = graphicsPath.PathPoints
					Dim list As List(Of PointF) = New List(Of PointF)()
					If pathPoints.Length < 2 Then
						result = list
					Else
						list.Add(pathPoints(0))
						Dim num As Single = 0F
						Dim a_ As PointF = pathPoints(0)
						Dim num2 As Integer = pathPoints.Length - 1
						For i As Integer = 1 To num2
							Dim pointF As PointF = pathPoints(i)
							Dim num3 As Single = ooO0O.O.O00.(a_, pointF)
							If CDbl(num3) < 1E-06 Then
								a_ = pointF
							ElseIf CDbl((num + num3)) < CDbl(A_1) - 1E-06 Then
								num += num3
								a_ = pointF
							Else
								Dim num4 As Single = A_1 - num
								Dim a_2 As Single = num4 / num3
								Dim pointF2 As PointF = ooO0O.O_O_.0oooo_oo.(a_, pointF, a_2)
								list.Add(pointF2)
								a_ = pointF2
								Dim num5 As Single = num3 - num4
								While CDbl(num5) >= CDbl(A_1) + 1E-06
									pointF2 = ooO0O.O_O_.0oooo_oo.(a_, pointF, A_1 / num5)
									list.Add(pointF2)
									a_ = pointF2
									num5 -= A_1
								End While
								num = If((CDbl(num5) > 1E-06), num5, 0F)
								a_ = pointF
							End If
						Next
						Dim pointF3 As PointF = pathPoints(pathPoints.Length - 1)
						If CDbl(ooO0O.O.O00.(list(list.Count - 1), pointF3)) > 1E-06 Then
							list.Add(pointF3)
						End If
						result = list
					End If
				End Using
			End If
			Return result
		End Function

		' Token: 0x06000E9E RID: 3742 RVA: 0x00062E54 File Offset: 0x00061054
		Private Function <<EMPTY_NAME>>(A_0 As List(Of PointF), A_1 As Integer) As PointF
			Dim num As Integer = Math.Min(A_1, A_0.Count)
			Dim result As PointF
			If num < 2 Then
				result = New PointF(1F, 0F)
			Else
				Dim num2 As Single = 0F
				Dim num3 As Single = 0F
				Dim num4 As Integer = A_0.Count - num
				Dim num5 As Integer = A_0.Count - 2
				For i As Integer = num4 To num5
					Dim pointF As PointF = A_0(i)
					Dim pointF2 As PointF = A_0(i + 1)
					Dim num6 As Single = pointF2.X - pointF.X
					Dim num7 As Single = pointF2.Y - pointF.Y
					Dim num8 As Single = CSng(Math.Sqrt(CDbl((num6 * num6 + num7 * num7))))
					If CDbl(num8) > 1E-06 Then
						num2 += num6 / num8
						num3 += num7 / num8
					End If
				Next
				Dim num9 As Single = CSng(Math.Sqrt(CDbl((num2 * num2 + num3 * num3))))
				If CDbl(num9) > 1E-06 Then
					result = New PointF(num2 / num9, num3 / num9)
				Else
					result = New PointF(1F, 0F)
				End If
			End If
			Return result
		End Function

		' Token: 0x06000E9F RID: 3743 RVA: 0x00062F64 File Offset: 0x00061164
		Private Function <<EMPTY_NAME>>(A_0 As List(Of PointF), A_1 As Integer) As PointF
			Dim num As Integer = Math.Min(A_1, A_0.Count)
			Dim result As PointF
			If num < 2 Then
				result = New PointF(1F, 0F)
			Else
				Dim num2 As Single = 0F
				Dim num3 As Single = 0F
				Dim num4 As Integer = num - 1 - 1
				For i As Integer = 0 To num4
					Dim pointF As PointF = A_0(i)
					Dim pointF2 As PointF = A_0(i + 1)
					Dim num5 As Single = pointF2.X - pointF.X
					Dim num6 As Single = pointF2.Y - pointF.Y
					Dim num7 As Single = CSng(Math.Sqrt(CDbl((num5 * num5 + num6 * num6))))
					If CDbl(num7) > 1E-06 Then
						num2 += num5 / num7
						num3 += num6 / num7
					End If
				Next
				Dim num8 As Single = CSng(Math.Sqrt(CDbl((num2 * num2 + num3 * num3))))
				If CDbl(num8) > 1E-06 Then
					result = New PointF(num2 / num8, num3 / num8)
				Else
					result = New PointF(1F, 0F)
				End If
			End If
			Return result
		End Function

		' Token: 0x06000EA0 RID: 3744 RVA: 0x0006306C File Offset: 0x0006126C
		Private Function <<EMPTY_NAME>>(A_0 As PointF, A_1 As PointF, A_2 As Single, A_3 As Single) As List(Of PointF)
			Dim list As List(Of PointF) = New List(Of PointF)()
			Dim num As Single = CSng(Math.Cos(CDbl(A_3)))
			Dim num2 As Single = CSng(Math.Sin(CDbl(A_3)))
			Dim x As Single = A_0.X - (A_1.X * num - A_1.Y * num2) * A_2
			Dim y As Single = A_0.Y - (A_1.X * num2 + A_1.Y * num) * A_2
			Dim item As PointF = New PointF(x, y)
			Dim x2 As Single = A_0.X - (A_1.X * num + A_1.Y * num2) * A_2
			Dim y2 As Single = A_0.Y - (-A_1.X * num2 + A_1.Y * num) * A_2
			Dim item2 As PointF = New PointF(x2, y2)
			list.Add(item)
			list.Add(A_0)
			list.Add(item2)
			Return list
		End Function

		' Token: 0x06000EA1 RID: 3745 RVA: 0x00063138 File Offset: 0x00061338
		Private Function <<EMPTY_NAME>>(A_0 As PointF, A_1 As PointF) As Single
			Dim num As Single = A_1.X - A_0.X
			Dim num2 As Single = A_1.Y - A_0.Y
			Return CSng(Math.Sqrt(CDbl((num * num + num2 * num2))))
		End Function

		' Token: 0x06000EA2 RID: 3746 RVA: 0x00063174 File Offset: 0x00061374
		Private Function <<EMPTY_NAME>>(A_0 As PointF, A_1 As PointF, A_2 As Single) As PointF
			Dim x As Single = A_0.X + (A_1.X - A_0.X) * A_2
			Dim y As Single = A_0.Y + (A_1.Y - A_0.Y) * A_2
			Return New PointF(x, y)
		End Function
	End Module
End Namespace
