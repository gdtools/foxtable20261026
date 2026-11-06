Imports System
Imports System.ComponentModel
Imports Foxtable.RibbonMenu

Namespace Foxtable
	' Token: 0x0200049A RID: 1178
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonGalleryEventArgs
		' Token: 0x06004D6D RID: 19821 RVA: 0x002019F1 File Offset: 0x001FFBF1
		Public Sub New(A_0 As Gallery, A_1 As GalleryItem)
			Me.O_oOO_.o0. = A_0
			Me.O_oOO_.o0. = A_1
		End Sub

		' Token: 0x1700118F RID: 4495
		' (get) Token: 0x06004D6E RID: 19822 RVA: 0x00201A07 File Offset: 0x001FFC07
		Public ReadOnly Property Gallery As Gallery
			Get
				Return Me.O_oOO_.o0.
			End Get
		End Property

		' Token: 0x17001190 RID: 4496
		' (get) Token: 0x06004D6F RID: 19823 RVA: 0x00201A0F File Offset: 0x001FFC0F
		Public ReadOnly Property GalleryItem As GalleryItem
			Get
				Return Me.O_oOO_.o0.
			End Get
		End Property

		' Token: 0x04002002 RID: 8194
		Private <<EMPTY_NAME>> As Gallery

		' Token: 0x04002003 RID: 8195
		Private <<EMPTY_NAME>> As GalleryItem
	End Class
End Namespace
