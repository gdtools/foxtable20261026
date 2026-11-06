Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Web

Namespace Foxtable
	' Token: 0x020001F5 RID: 501
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o000OOOO
		' Token: 0x06001838 RID: 6200 RVA: 0x0009E238 File Offset: 0x0009C438
		Friend Sub New(A_0 As HttpListenerResponse, A_1 As WordCreator, A_2 As String, A_3 As Boolean)
			Me.Oo000.o00. = A_0
			Me.Oo000.o00. = A_1
			Me.Oo000.o00. = A_2
			Me.Oo000.o00. = A_3
		End Sub

		' Token: 0x06001839 RID: 6201 RVA: 0x0009E260 File Offset: 0x0009C460
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Try
				Me.Oo000.o00..Save(memoryStream, 1)
				memoryStream.Position = 0L
				If Me.Oo000.o00. Then
					Me.Oo000.o00..ContentType = "application/msword"
					Me.Oo000.o00..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.Oo000.o00.), Me.Oo000.o00..ContentEncoding))
				Else
					Me.Oo000.o00..ContentType = "application/octet-stream"
					Me.Oo000.o00..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.Oo000.o00.), Me.Oo000.o00..ContentEncoding))
				End If
				Me.Oo000.o00..ContentLength64 = memoryStream.Length
				Dim array As Byte() = New Byte(51200) {}
				Dim num As Integer = memoryStream.Read(array, 0, array.Length)
				While num > 0 AndAlso Me.Oo000.o00..OutputStream.CanWrite
					Me.Oo000.o00..OutputStream.Write(array, 0, num)
					num = memoryStream.Read(array, 0, array.Length)
				End While
			Catch ex As Exception
			Finally
				Me.Oo000.o00..OutputStream.Close()
				Me.Oo000.o00..Close()
				Me.Oo000.o00..Abort()
				If memoryStream IsNot Nothing Then
					memoryStream.Close()
				End If
			End Try
		End Sub

		' Token: 0x04000A06 RID: 2566
		Private <<EMPTY_NAME>> As WordCreator

		' Token: 0x04000A07 RID: 2567
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A08 RID: 2568
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A09 RID: 2569
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
