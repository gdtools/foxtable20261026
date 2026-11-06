Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001A8 RID: 424
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ListViewImageManger
		' Token: 0x060013F9 RID: 5113 RVA: 0x000803C2 File Offset: 0x0007E5C2
		Public Sub New(A_0 As ListView)
			Me.oOO_O_.OOO0o_. = A_0
			Me.oo.oO_. = A_0.LargeImageList
			Me.OO._0_o. = A_0.SmallImageList
		End Sub

		' Token: 0x17000418 RID: 1048
		' (get) Token: 0x060013FA RID: 5114 RVA: 0x000803E9 File Offset: 0x0007E5E9
		' (set) Token: 0x060013FB RID: 5115 RVA: 0x000803F6 File Offset: 0x0007E5F6
		Public Property LargeSize As Size
			Get
				Return Me.oo.oO_..ImageSize
			End Get
			Set(value As Size)
				Me.oo.oO_..ImageSize = value
			End Set
		End Property

		' Token: 0x17000419 RID: 1049
		' (get) Token: 0x060013FC RID: 5116 RVA: 0x00080404 File Offset: 0x0007E604
		' (set) Token: 0x060013FD RID: 5117 RVA: 0x00080411 File Offset: 0x0007E611
		Public Property SmallSize As Size
			Get
				Return Me.OO._0_o..ImageSize
			End Get
			Set(value As Size)
				Me.OO._0_o..ImageSize = value
			End Set
		End Property

		' Token: 0x060013FE RID: 5118 RVA: 0x0008041F File Offset: 0x0007E61F
		Public Sub AddImage(Key As String, SmallImageFile As String, LargeImageFile As String)
			If Operators.CompareString(LargeImageFile, "", True) > 0 Then
				Me.AddLargeImage(Key, LargeImageFile)
			End If
			If Operators.CompareString(SmallImageFile, "", True) > 0 Then
				Me.AddSmallImage(Key, SmallImageFile)
			End If
		End Sub

		' Token: 0x060013FF RID: 5119 RVA: 0x00080450 File Offset: 0x0007E650
		Public Sub AddLargeImage(Key As String, ImageFile As String)
			If Not Me.oo.oO_..Images.ContainsKey(Key) Then
				Dim image As Image = OO_00oOO.GetImage(ImageFile)
				If image IsNot Nothing Then
					Me.oo.oO_..Images.Add(Key, image)
					Return
				End If
				Me.oo.oO_..Images.Add(Key, New Bitmap(Me.LargeSize.Width, Me.LargeSize.Height))
			End If
		End Sub

		' Token: 0x06001400 RID: 5120 RVA: 0x000804C0 File Offset: 0x0007E6C0
		Public Sub AddSmallImage(Key As String, ImageFile As String)
			If Not Me.OO._0_o..Images.ContainsKey(Key) Then
				Dim image As Image = OO_00oOO.GetImage(ImageFile)
				If image IsNot Nothing Then
					Me.OO._0_o..Images.Add(Key, image)
					Return
				End If
				Me.OO._0_o..Images.Add(Key, New Bitmap(Me.SmallSize.Width, Me.SmallSize.Height))
			End If
		End Sub

		' Token: 0x06001401 RID: 5121 RVA: 0x0008052F File Offset: 0x0007E72F
		Public Sub RemoveImage(Key As String)
			Me.RemoveLargeImage(Key)
			Me.RemoveSmallImage(Key)
		End Sub

		' Token: 0x06001402 RID: 5122 RVA: 0x0008053F File Offset: 0x0007E73F
		Public Sub RemoveLargeImage(Key As String)
			If Me.oo.oO_..Images.ContainsKey(Key) Then
				Me.oo.oO_..Images.RemoveByKey(Key)
			End If
		End Sub

		' Token: 0x06001403 RID: 5123 RVA: 0x00080565 File Offset: 0x0007E765
		Public Sub RemoveSmallImage(Key As String)
			If Me.OO._0_o..Images.ContainsKey(Key) Then
				Me.oo.oO_..Images.RemoveByKey(Key)
			End If
		End Sub

		' Token: 0x06001404 RID: 5124 RVA: 0x0008058B File Offset: 0x0007E78B
		Public Sub Clear()
			Me.LargeImages.Clear()
			Me.SmallImages.Clear()
		End Sub

		' Token: 0x1700041A RID: 1050
		' (get) Token: 0x06001405 RID: 5125 RVA: 0x000805A3 File Offset: 0x0007E7A3
		Public ReadOnly Property LargeImages As ImageList.ImageCollection
			Get
				Return Me.oo.oO_..Images
			End Get
		End Property

		' Token: 0x1700041B RID: 1051
		' (get) Token: 0x06001406 RID: 5126 RVA: 0x000805B0 File Offset: 0x0007E7B0
		Public ReadOnly Property SmallImages As ImageList.ImageCollection
			Get
				Return Me.OO._0_o..Images
			End Get
		End Property

		' Token: 0x040007CE RID: 1998
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x040007CF RID: 1999
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x040007D0 RID: 2000
		Private <<EMPTY_NAME>> As ListView
	End Class
End Namespace
