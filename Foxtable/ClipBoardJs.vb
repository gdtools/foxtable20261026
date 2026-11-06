Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020000F8 RID: 248
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ClipBoardJs
		' Token: 0x06000D5D RID: 3421 RVA: 0x0005F215 File Offset: 0x0005D415
		Public Sub SetDataObject(data As Object)
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data))
		End Sub

		' Token: 0x06000D5E RID: 3422 RVA: 0x0005F222 File Offset: 0x0005D422
		Public Sub SetImage(image As Image)
			Clipboard.SetImage(image)
		End Sub

		' Token: 0x06000D5F RID: 3423 RVA: 0x0005F22A File Offset: 0x0005D42A
		Public Sub SetData(format As String, data As Object)
			Clipboard.SetData(format, RuntimeHelpers.GetObjectValue(data))
		End Sub

		' Token: 0x06000D60 RID: 3424 RVA: 0x0005F238 File Offset: 0x0005D438
		Public Sub SetAudio(audioStream As Stream)
			Clipboard.SetAudio(audioStream)
		End Sub

		' Token: 0x06000D61 RID: 3425 RVA: 0x0005F240 File Offset: 0x0005D440
		Public Sub SetAudio(audioBytes As Byte())
			Clipboard.SetAudio(audioBytes)
		End Sub

		' Token: 0x06000D62 RID: 3426 RVA: 0x0005F248 File Offset: 0x0005D448
		Public Sub SetText(text As String)
			Clipboard.SetText(text)
		End Sub

		' Token: 0x06000D63 RID: 3427 RVA: 0x0005F250 File Offset: 0x0005D450
		Public Sub SetText(text As String, format As TextDataFormat)
			Clipboard.SetText(text, format)
		End Sub

		' Token: 0x06000D64 RID: 3428 RVA: 0x0005F259 File Offset: 0x0005D459
		Public Sub Clear()
			Clipboard.Clear()
		End Sub

		' Token: 0x06000D65 RID: 3429 RVA: 0x0005F260 File Offset: 0x0005D460
		Public Sub SetDataObject(data As Object, copy As Boolean, retryTimes As Integer, retryDelay As Integer)
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data), copy, retryTimes, retryDelay)
		End Sub

		' Token: 0x06000D66 RID: 3430 RVA: 0x0005F271 File Offset: 0x0005D471
		Public Sub SetDataObject(data As Object, copy As Boolean)
			Clipboard.SetDataObject(RuntimeHelpers.GetObjectValue(data), copy)
		End Sub

		' Token: 0x06000D67 RID: 3431 RVA: 0x0005F27F File Offset: 0x0005D47F
		Public Function ContainsImage() As Boolean
			Return Clipboard.ContainsImage()
		End Function

		' Token: 0x06000D68 RID: 3432 RVA: 0x0005F286 File Offset: 0x0005D486
		Public Function ContainsText() As Boolean
			Return Clipboard.ContainsText()
		End Function

		' Token: 0x06000D69 RID: 3433 RVA: 0x0005F28D File Offset: 0x0005D48D
		Public Function ContainsText(format As TextDataFormat) As Boolean
			Return Clipboard.ContainsText(format)
		End Function

		' Token: 0x06000D6A RID: 3434 RVA: 0x0005F295 File Offset: 0x0005D495
		Public Function ContainsData(format As String) As Boolean
			Return Clipboard.ContainsData(format)
		End Function

		' Token: 0x06000D6B RID: 3435 RVA: 0x0005F29D File Offset: 0x0005D49D
		Public Function GetData(format As String) As Object
			Return Clipboard.GetData(format)
		End Function

		' Token: 0x06000D6C RID: 3436 RVA: 0x0005F2A5 File Offset: 0x0005D4A5
		Public Function GetImage() As Image
			Return Clipboard.GetImage()
		End Function

		' Token: 0x06000D6D RID: 3437 RVA: 0x0005F2AC File Offset: 0x0005D4AC
		Public Function GetText() As String
			Return Clipboard.GetText()
		End Function

		' Token: 0x06000D6E RID: 3438 RVA: 0x0005F2B3 File Offset: 0x0005D4B3
		Public Function GetText(format As TextDataFormat) As String
			Return Clipboard.GetText(format)
		End Function

		' Token: 0x06000D6F RID: 3439 RVA: 0x0005F2BB File Offset: 0x0005D4BB
		Public Function ContainsAudio() As Boolean
			Return Clipboard.ContainsAudio()
		End Function

		' Token: 0x06000D70 RID: 3440 RVA: 0x0005F2C2 File Offset: 0x0005D4C2
		Public Function GetDataObject() As IDataObject
			Return Clipboard.GetDataObject()
		End Function

		' Token: 0x06000D71 RID: 3441 RVA: 0x0005F2C9 File Offset: 0x0005D4C9
		Public Function ContainsFileDropList() As Boolean
			Return Clipboard.ContainsFileDropList()
		End Function

		' Token: 0x06000D72 RID: 3442 RVA: 0x0005F2D0 File Offset: 0x0005D4D0
		Public Function GetAudioStream() As Stream
			Return Clipboard.GetAudioStream()
		End Function
	End Class
End Namespace
