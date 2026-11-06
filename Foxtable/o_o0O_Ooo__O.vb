Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Net

Namespace Foxtable
	' Token: 0x020001F7 RID: 503
	Friend Class o_o0O_Ooo__O
		' Token: 0x0600183F RID: 6207 RVA: 0x0009E601 File Offset: 0x0009C801
		Friend Sub New(A_0 As String, A_1 As HttpListenerResponse)
			Me.ooO0O.0. = A_0
			Me.ooO0O.0. = A_1
		End Sub

		' Token: 0x06001840 RID: 6208 RVA: 0x0009E618 File Offset: 0x0009C818
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim fileStream As FileStream = New FileStream(Me.ooO0O.0., FileMode.Open, FileAccess.Read, FileShare.Read)
			Dim stream As Stream = Me.ooO0O.0..OutputStream
			Try
				If Me.ooO0O.0..Headers("Content-Encoding") Is Nothing Then
					Me.ooO0O.0..ContentLength64 = fileStream.Length
				ElseIf Me.ooO0O.0..Headers("Content-Encoding").Contains("gzip") Then
					stream = New GZipStream(Me.ooO0O.0..OutputStream, CompressionMode.Compress, False)
				ElseIf Me.ooO0O.0..Headers("Content-Encoding").Contains("deflate") Then
					stream = New DeflateStream(Me.ooO0O.0..OutputStream, CompressionMode.Compress, False)
				Else
					Me.ooO0O.0..ContentLength64 = fileStream.Length
				End If
				Dim array As Byte() = New Byte(51200) {}
				Dim num As Integer = fileStream.Read(array, 0, array.Length)
				While num > 0 AndAlso stream.CanWrite
					stream.Write(array, 0, num)
					num = fileStream.Read(array, 0, array.Length)
				End While
			Catch ex As Exception
			Finally
				Try
					fileStream.Close()
					stream.Flush()
					stream.Close()
					If stream IsNot Me.ooO0O.0..OutputStream Then
						Me.ooO0O.0..OutputStream.Close()
					End If
					Me.ooO0O.0..Close()
					Me.ooO0O.0..Abort()
				Catch ex2 As Exception
				End Try
			End Try
		End Sub

		' Token: 0x04000A0E RID: 2574
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A0F RID: 2575
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
