Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Web

Namespace Foxtable
	' Token: 0x020001F3 RID: 499
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_o_O00_
		' Token: 0x06001834 RID: 6196 RVA: 0x0009DF9F File Offset: 0x0009C19F
		Friend Sub New(A_0 As HttpListenerResponse, A_1 As PDFCreator, A_2 As String, A_3 As Boolean)
			Me.oO0o0o._0. = A_0
			Me.ooO0O.0. = A_1
			Me.ooO0O.0. = A_2
			Me.oO0o0o._0. = A_3
		End Sub

		' Token: 0x06001835 RID: 6197 RVA: 0x0009DFC4 File Offset: 0x0009C1C4
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Try
				Me.ooO0O.0..Save(memoryStream)
				memoryStream.Position = 0L
				If Me.oO0o0o._0. Then
					Me.oO0o0o._0..ContentType = "Application/pdf"
					Me.oO0o0o._0..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.ooO0O.0.), Me.oO0o0o._0..ContentEncoding))
				Else
					Me.oO0o0o._0..ContentType = "application/octet-stream"
					Me.oO0o0o._0..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.ooO0O.0.), Me.oO0o0o._0..ContentEncoding))
				End If
				Me.oO0o0o._0..ContentLength64 = memoryStream.Length
				Dim array As Byte() = New Byte(51200) {}
				Dim num As Integer = memoryStream.Read(array, 0, array.Length)
				While num > 0 AndAlso Me.oO0o0o._0..OutputStream.CanWrite
					Me.oO0o0o._0..OutputStream.Write(array, 0, num)
					num = memoryStream.Read(array, 0, array.Length)
				End While
			Catch ex As Exception
			Finally
				Me.oO0o0o._0..OutputStream.Close()
				Me.oO0o0o._0..Close()
				Me.oO0o0o._0..Abort()
				If memoryStream IsNot Nothing Then
					memoryStream.Close()
				End If
			End Try
		End Sub

		' Token: 0x04000A00 RID: 2560
		Private <<EMPTY_NAME>> As PDFCreator

		' Token: 0x04000A01 RID: 2561
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A02 RID: 2562
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A03 RID: 2563
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
