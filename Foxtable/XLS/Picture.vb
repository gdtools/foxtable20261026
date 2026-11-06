Imports System
Imports System.Drawing
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004DF RID: 1247
	Public Class Picture
		' Token: 0x06005012 RID: 20498 RVA: 0x00218074 File Offset: 0x00216274
		Public Sub New(A_0 As Image, A_1 As Integer, A_2 As Integer, A_3 As Integer, A_4 As Integer)
			A_1 = C1XLBook.PixelsToTwips(CDbl(A_1))
			A_2 = C1XLBook.PixelsToTwips(CDbl(A_2))
			A_3 = C1XLBook.PixelsToTwips(CDbl(A_3))
			A_4 = C1XLBook.PixelsToTwips(CDbl(A_4))
			Me.o0_.O_o. = New XLPictureShape(A_0, A_1, A_2, A_3, A_4)
		End Sub

		' Token: 0x06005013 RID: 20499 RVA: 0x002180B4 File Offset: 0x002162B4
		Public Sub New(A_0 As Image)
			Me.o0_.O_o. = New XLPictureShape(A_0)
		End Sub

		' Token: 0x06005014 RID: 20500 RVA: 0x002180C8 File Offset: 0x002162C8
		Public Sub New(A_0 As Image, A_1 As Integer, A_2 As Integer)
			A_1 = C1XLBook.PixelsToTwips(CDbl(A_1))
			A_2 = C1XLBook.PixelsToTwips(CDbl(A_2))
			Me.o0_.O_o. = New XLPictureShape(A_0, A_1, A_2)
		End Sub

		' Token: 0x0400218F RID: 8591
		Friend <<EMPTY_NAME>> As XLPictureShape
	End Class
End Namespace
