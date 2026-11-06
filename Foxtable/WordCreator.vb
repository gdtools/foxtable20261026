Imports System
Imports System.Drawing
Imports C1.C1Word
Imports C1.C1Word.Objects

Namespace Foxtable
	' Token: 0x02000462 RID: 1122
	Public Class WordCreator
		Inherits C1WordDocument

		' Token: 0x06004B38 RID: 19256 RVA: 0x001FB360 File Offset: 0x001F9560
		Public Sub Save(Filename As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(Filename)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			MyBase.Save(Filename)
		End Sub

		' Token: 0x06004B39 RID: 19257 RVA: 0x001FB398 File Offset: 0x001F9598
		Public Sub DrawLine(pen As Pen, pt1 As PointF, pt2 As PointF)
			If(pt1.X < pt2.X AndAlso pt1.Y > pt2.Y) OrElse (pt2.X < pt1.X AndAlso pt2.Y > pt1.Y) Then
				Dim array As PointF() = New PointF() { pt1, pt2, pt1, pt2 }
				MyBase.DrawPolyline(pen, array)
				Return
			End If
			MyBase.DrawLine(pen, pt1, pt2)
		End Sub

		' Token: 0x06004B3A RID: 19258 RVA: 0x001FB420 File Offset: 0x001F9620
		Public Sub DrawLine(pen As Pen, x1 As Single, y1 As Single, x2 As Single, y2 As Single)
			If(x1 < x2 AndAlso y1 > y2) OrElse (x2 < x1 AndAlso y2 > y1) Then
				Dim pt As PointF = New PointF(x1, y1)
				Dim pt2 As PointF = New PointF(x2, y2)
				Me.DrawLine(pen, pt, pt2)
				Return
			End If
			MyBase.DrawLine(pen, x1, y1, x2, y2)
		End Sub

		' Token: 0x06004B3B RID: 19259 RVA: 0x001FB46C File Offset: 0x001F966C
		Public Sub NewPage()
			MyBase.Add(New RtfSection() With { .AutoNewPage = True })
		End Sub

		' Token: 0x17001097 RID: 4247
		' (get) Token: 0x06004B3C RID: 19260 RVA: 0x001FB48D File Offset: 0x001F968D
		Public ReadOnly Property Columns As RtfColumnCollection
			Get
				Return MyBase.MainSection.Columns
			End Get
		End Property

		' Token: 0x17001098 RID: 4248
		' (get) Token: 0x06004B3D RID: 19261 RVA: 0x001FB49A File Offset: 0x001F969A
		Public ReadOnly Property Header As RtfHeader
			Get
				Return MyBase.MainSection.Header
			End Get
		End Property

		' Token: 0x17001099 RID: 4249
		' (get) Token: 0x06004B3E RID: 19262 RVA: 0x001FB4A7 File Offset: 0x001F96A7
		Public ReadOnly Property Footer As RtfFooter
			Get
				Return MyBase.MainSection.Footer
			End Get
		End Property

		' Token: 0x1700109A RID: 4250
		' (get) Token: 0x06004B3F RID: 19263 RVA: 0x001FB4B4 File Offset: 0x001F96B4
		' (set) Token: 0x06004B40 RID: 19264 RVA: 0x001FB4C1 File Offset: 0x001F96C1
		Public Property PageSize As SizeF
			Get
				Return MyBase.MainSection.PageSize
			End Get
			Set(value As SizeF)
				MyBase.MainSection.PageSize = value
			End Set
		End Property
	End Class
End Namespace
