Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports C1.Win.C1Ribbon

Namespace Foxtable
	' Token: 0x0200047E RID: 1150
	Friend Class RibbonTopTab
		Inherits RibbonBase

		' Token: 0x06004CCE RID: 19662 RVA: 0x002012C1 File Offset: 0x001FF4C1
		Friend Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.o00o.0o0_0. = 3
			Me.o00o.0o0_0. = System.Drawing.Color.Transparent
			Me.o00o.0o0_0. = True
			Me.o0_o.o. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001149 RID: 4425
		' (get) Token: 0x06004CCF RID: 19663 RVA: 0x002012F2 File Offset: 0x001FF4F2
		' (set) Token: 0x06004CD0 RID: 19664 RVA: 0x0020130D File Offset: 0x001FF50D
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.o00o.0o0_0. Is Nothing Then
					Me.o00o.0o0_0. = ""
				End If
				Return Me.o00o.0o0_0.
			End Get
			Set(value As String)
				Me.o00o.0o0_0. = value
			End Set
		End Property

		' Token: 0x1700114A RID: 4426
		' (get) Token: 0x06004CD1 RID: 19665 RVA: 0x00201316 File Offset: 0x001FF516
		' (set) Token: 0x06004CD2 RID: 19666 RVA: 0x0020131E File Offset: 0x001FF51E
		<DisplayName("提示")>
		<O_Oo00Oo000O0(3.0)>
		<Category("属性")>
		Public Property ToolTip As String
			Get
				Return Me.o0_o.o.
			End Get
			Set(value As String)
				Me.o0_o.o. = value
			End Set
		End Property

		' Token: 0x1700114B RID: 4427
		' (get) Token: 0x06004CD3 RID: 19667 RVA: 0x00201327 File Offset: 0x001FF527
		' (set) Token: 0x06004CD4 RID: 19668 RVA: 0x0020132F File Offset: 0x001FF52F
		<DefaultValue(16777215)>
		<O_Oo00Oo000O0(4.0)>
		<Category("属性")>
		<DisplayName("背景颜色")>
		Public Property Color As ContextualTabColor
			Get
				Return Me.o00o.0o0_0.
			End Get
			Set(value As ContextualTabColor)
				Me.o00o.0o0_0. = value
			End Set
		End Property

		' Token: 0x1700114C RID: 4428
		' (get) Token: 0x06004CD5 RID: 19669 RVA: 0x00201338 File Offset: 0x001FF538
		' (set) Token: 0x06004CD6 RID: 19670 RVA: 0x00201340 File Offset: 0x001FF540
		<DisplayName("字体颜色")>
		<O_Oo00Oo000O0(5.0)>
		<Category("属性")>
		Public Property ForeColor As Color
			Get
				Return Me.o00o.0o0_0.
			End Get
			Set(value As Color)
				Me.o00o.0o0_0. = value
			End Set
		End Property

		' Token: 0x1700114D RID: 4429
		' (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00201349 File Offset: 0x001FF549
		' (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00201351 File Offset: 0x001FF551
		<DefaultValue(True)>
		<O_Oo00Oo000O0(6.0)>
		<Category("属性")>
		<DisplayName("可见")>
		Public Property Visible As Boolean
			Get
				Return Me.o00o.0o0_0.
			End Get
			Set(value As Boolean)
				Me.o00o.0o0_0. = value
			End Set
		End Property

		' Token: 0x1700114E RID: 4430
		' (get) Token: 0x06004CD9 RID: 19673 RVA: 0x0020135A File Offset: 0x001FF55A
		' (set) Token: 0x06004CDA RID: 19674 RVA: 0x00201362 File Offset: 0x001FF562
		<DefaultValue(True)>
		<Category("属性")>
		<O_Oo00Oo000O0(7.0)>
		<DisplayName("可选")>
		Public Property Clickable As Boolean
			Get
				Return Me.o0_o.o.
			End Get
			Set(value As Boolean)
				Me.o0_o.o. = value
			End Set
		End Property

		' Token: 0x04001F8E RID: 8078
		Private <<EMPTY_NAME>> As ContextualTabColor

		' Token: 0x04001F8F RID: 8079
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04001F90 RID: 8080
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F91 RID: 8081
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F92 RID: 8082
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F93 RID: 8083
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
