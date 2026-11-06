Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DPFP
Imports DPFP.Capture

Namespace Foxtable
	' Token: 0x02000241 RID: 577
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FingerCaptureEventArgs
		' Token: 0x06001AED RID: 6893 RVA: 0x000ABCB0 File Offset: 0x000A9EB0
		Public Sub New(A_0 As String, A_1 As Sample)
			Me.OOO_.00. = A_0
			Me.OOO_.00. = A_1
		End Sub

		' Token: 0x1700061B RID: 1563
		' (get) Token: 0x06001AEE RID: 6894 RVA: 0x000ABCC6 File Offset: 0x000A9EC6
		Public ReadOnly Property Features As String
			Get
				Return Me.OOO_.00.
			End Get
		End Property

		' Token: 0x1700061C RID: 1564
		' (get) Token: 0x06001AEF RID: 6895 RVA: 0x000ABCD0 File Offset: 0x000A9ED0
		Public ReadOnly Property Image As Image
			Get
				Dim sampleConversion As SampleConversion = New SampleConversion()
				Dim result As Bitmap = Nothing
				sampleConversion.ConvertToPicture(Me.OOO_.00., result)
				Return result
			End Get
		End Property

		' Token: 0x06001AF0 RID: 6896 RVA: 0x000ABCF3 File Offset: 0x000A9EF3
		Public Sub SaveToFile(fileName As String)
			Me.Image.Save(fileName, O_O0OO.OoO_00._.(fileName))
		End Sub

		' Token: 0x04000B61 RID: 2913
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B62 RID: 2914
		Private <<EMPTY_NAME>> As Sample
	End Class
End Namespace
