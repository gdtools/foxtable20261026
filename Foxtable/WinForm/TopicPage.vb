Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003BE RID: 958
	<ComVisible(True)>
	Public Class TopicPage
		' Token: 0x06003D49 RID: 15689 RVA: 0x001AB623 File Offset: 0x001A9823
		Public Sub New(A_0 As C1TopicPage)
			Me.o.OOoo. = A_0
		End Sub

		' Token: 0x17000D6A RID: 3434
		' (get) Token: 0x06003D4A RID: 15690 RVA: 0x001AB632 File Offset: 0x001A9832
		Friend ReadOnly Property BasePage As C1TopicPage
			Get
				Return Me.o.OOoo.
			End Get
		End Property

		' Token: 0x17000D6B RID: 3435
		' (get) Token: 0x06003D4B RID: 15691 RVA: 0x001AB63A File Offset: 0x001A983A
		' (set) Token: 0x06003D4C RID: 15692 RVA: 0x001AB64C File Offset: 0x001A984C
		Public Property Name As String
			Get
				Return Me.o.OOoo..Tag.ToString()
			End Get
			Set(value As String)
				Me.o.OOoo..Tag = value
			End Set
		End Property

		' Token: 0x17000D6C RID: 3436
		' (get) Token: 0x06003D4D RID: 15693 RVA: 0x001AB65A File Offset: 0x001A985A
		' (set) Token: 0x06003D4E RID: 15694 RVA: 0x001AB667 File Offset: 0x001A9867
		Public Property Text As String
			Get
				Return Me.o.OOoo..Text
			End Get
			Set(value As String)
				Me.o.OOoo..Text = value
			End Set
		End Property

		' Token: 0x17000D6D RID: 3437
		' (get) Token: 0x06003D4F RID: 15695 RVA: 0x001AB675 File Offset: 0x001A9875
		' (set) Token: 0x06003D50 RID: 15696 RVA: 0x001AB682 File Offset: 0x001A9882
		Public Property ToolTip As String
			Get
				Return Me.o.OOoo..ToolTipText
			End Get
			Set(value As String)
				Me.o.OOoo..ToolTipText = value
			End Set
		End Property

		' Token: 0x17000D6E RID: 3438
		' (get) Token: 0x06003D51 RID: 15697 RVA: 0x001AB690 File Offset: 0x001A9890
		' (set) Token: 0x06003D52 RID: 15698 RVA: 0x001AB69D File Offset: 0x001A989D
		Public Property Collapsed As Boolean
			Get
				Return Me.o.OOoo..Collapsed
			End Get
			Set(value As Boolean)
				Me.o.OOoo..Collapsed = value
			End Set
		End Property

		' Token: 0x17000D6F RID: 3439
		' (get) Token: 0x06003D53 RID: 15699 RVA: 0x001AB6AB File Offset: 0x001A98AB
		' (set) Token: 0x06003D54 RID: 15700 RVA: 0x001AB6B8 File Offset: 0x001A98B8
		Public Property Visible As Boolean
			Get
				Return Me.o.OOoo..PageVisible
			End Get
			Set(value As Boolean)
				Me.o.OOoo..PageVisible = value
			End Set
		End Property

		' Token: 0x17000D70 RID: 3440
		' (get) Token: 0x06003D55 RID: 15701 RVA: 0x001AB6C6 File Offset: 0x001A98C6
		' (set) Token: 0x06003D56 RID: 15702 RVA: 0x001AB6CE File Offset: 0x001A98CE
		Public Property ImageFile As String
			Get
				Return Me.Image
			End Get
			Set(value As String)
				Me.Image = value
			End Set
		End Property

		' Token: 0x17000D71 RID: 3441
		' (get) Token: 0x06003D57 RID: 15703 RVA: 0x001AB6D8 File Offset: 0x001A98D8
		' (set) Token: 0x06003D58 RID: 15704 RVA: 0x001AB720 File Offset: 0x001A9920
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Image As String
			Get
				Dim result As String
				If Me.o.OOoo..ImageIndex >= 0 Then
					result = Me.o.OOoo..ImageList.Images.Keys(Me.o.OOoo..ImageIndex)
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
				If Me.o.OOoo..TopicBar.ImageList Is Nothing Then
					Me.o.OOoo..TopicBar.ImageList = New ImageList()
				End If
				If Me.o.OOoo..TopicBar.ImageList.Images.ContainsKey(value) Then
					Me.o.OOoo..ImageIndex = Me.o.OOoo..TopicBar.ImageList.Images.IndexOfKey(value)
					Return
				End If
				Dim image As Image = OO_00oOO.GetImage(value)
				If image IsNot Nothing Then
					Me.o.OOoo..TopicBar.ImageList.Images.Add(value, image)
				End If
				Me.o.OOoo..ImageIndex = Me.o.OOoo..TopicBar.ImageList.Images.IndexOfKey(value)
			End Set
		End Property

		' Token: 0x17000D72 RID: 3442
		' (get) Token: 0x06003D59 RID: 15705 RVA: 0x001AB7FF File Offset: 0x001A99FF
		<oO0oooo("0853")>
		Public ReadOnly Property Links As TopicLinkCollection
			Get
				If Me.a Is Nothing Then
					Me.a = New TopicLinkCollection(Me.o.OOoo..Links)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x0400190E RID: 6414
		Private <<EMPTY_NAME>> As C1TopicPage

		' Token: 0x0400190F RID: 6415
		Private a As TopicLinkCollection
	End Class
End Namespace
