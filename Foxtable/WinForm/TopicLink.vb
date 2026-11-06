Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003BB RID: 955
	<ComVisible(True)>
	Public Class TopicLink
		' Token: 0x06003D25 RID: 15653 RVA: 0x001AB1BB File Offset: 0x001A93BB
		Public Sub New(A_0 As C1TopicLink)
			Me.o.OOoo. = A_0
		End Sub

		' Token: 0x17000D5F RID: 3423
		' (get) Token: 0x06003D26 RID: 15654 RVA: 0x001AB1CA File Offset: 0x001A93CA
		Friend ReadOnly Property BaseLink As C1TopicLink
			Get
				Return Me.o.OOoo.
			End Get
		End Property

		' Token: 0x17000D60 RID: 3424
		' (get) Token: 0x06003D27 RID: 15655 RVA: 0x001AB1D2 File Offset: 0x001A93D2
		' (set) Token: 0x06003D28 RID: 15656 RVA: 0x001AB1E4 File Offset: 0x001A93E4
		Public Property Name As String
			Get
				Return Me.o.OOoo..Tag.ToString()
			End Get
			Set(value As String)
				Me.o.OOoo..Tag = value
			End Set
		End Property

		' Token: 0x17000D61 RID: 3425
		' (get) Token: 0x06003D29 RID: 15657 RVA: 0x001AB1F2 File Offset: 0x001A93F2
		' (set) Token: 0x06003D2A RID: 15658 RVA: 0x001AB1FF File Offset: 0x001A93FF
		Public Property Text As String
			Get
				Return Me.o.OOoo..Text
			End Get
			Set(value As String)
				Me.o.OOoo..Text = value
			End Set
		End Property

		' Token: 0x17000D62 RID: 3426
		' (get) Token: 0x06003D2B RID: 15659 RVA: 0x001AB20D File Offset: 0x001A940D
		' (set) Token: 0x06003D2C RID: 15660 RVA: 0x001AB21A File Offset: 0x001A941A
		Public Property ToolTip As String
			Get
				Return Me.o.OOoo..ToolTipText
			End Get
			Set(value As String)
				Me.o.OOoo..ToolTipText = value
			End Set
		End Property

		' Token: 0x17000D63 RID: 3427
		' (get) Token: 0x06003D2D RID: 15661 RVA: 0x001AB228 File Offset: 0x001A9428
		' (set) Token: 0x06003D2E RID: 15662 RVA: 0x001AB235 File Offset: 0x001A9435
		Public Property Visible As Boolean
			Get
				Return Me.o.OOoo..Visible
			End Get
			Set(value As Boolean)
				Me.o.OOoo..Visible = value
			End Set
		End Property

		' Token: 0x17000D64 RID: 3428
		' (get) Token: 0x06003D2F RID: 15663 RVA: 0x001AB243 File Offset: 0x001A9443
		' (set) Token: 0x06003D30 RID: 15664 RVA: 0x001AB250 File Offset: 0x001A9450
		Public Property Enabled As Boolean
			Get
				Return Me.o.OOoo..Enabled
			End Get
			Set(value As Boolean)
				Me.o.OOoo..Enabled = value
			End Set
		End Property

		' Token: 0x17000D65 RID: 3429
		' (get) Token: 0x06003D31 RID: 15665 RVA: 0x001AB25E File Offset: 0x001A945E
		' (set) Token: 0x06003D32 RID: 15666 RVA: 0x001AB266 File Offset: 0x001A9466
		<oO0oooo("0859")>
		Public Property ImageFile As String
			Get
				Return Me.Image
			End Get
			Set(value As String)
				Me.Image = value
			End Set
		End Property

		' Token: 0x17000D66 RID: 3430
		' (get) Token: 0x06003D33 RID: 15667 RVA: 0x001AB270 File Offset: 0x001A9470
		' (set) Token: 0x06003D34 RID: 15668 RVA: 0x001AB2BC File Offset: 0x001A94BC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Image As String
			Get
				Dim result As String
				If Me.o.OOoo..ImageIndex >= 0 Then
					result = Me.o.OOoo..TopicPage.ImageList.Images.Keys(Me.o.OOoo..ImageIndex)
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					Me.o.OOoo..ImageIndex = -1
					Return
				End If
				If Me.o.OOoo..TopicPage.ImageList Is Nothing Then
					If Me.o.OOoo..TopicPage.TopicBar.ImageList Is Nothing Then
						Me.o.OOoo..TopicPage.TopicBar.ImageList = New ImageList()
					End If
					Me.o.OOoo..TopicPage.ImageList = Me.o.OOoo..TopicPage.TopicBar.ImageList
				End If
				If Me.o.OOoo..TopicPage.ImageList.Images.ContainsKey(value) Then
					Me.o.OOoo..ImageIndex = Me.o.OOoo..TopicPage.ImageList.Images.IndexOfKey(value)
					Return
				End If
				Dim image As Image = OO_00oOO.GetImage(value)
				If image IsNot Nothing Then
					Me.o.OOoo..TopicPage.ImageList.Images.Add(value, image)
				End If
				Me.o.OOoo..ImageIndex = Me.o.OOoo..TopicPage.ImageList.Images.IndexOfKey(value)
			End Set
		End Property

		' Token: 0x04001908 RID: 6408
		Private <<EMPTY_NAME>> As C1TopicLink
	End Class
End Namespace
