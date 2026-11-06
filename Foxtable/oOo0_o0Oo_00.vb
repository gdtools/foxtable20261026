Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text

Namespace Foxtable
	' Token: 0x020001F8 RID: 504
	Friend Class oOo0_o0Oo_00
		' Token: 0x06001841 RID: 6209 RVA: 0x0009E7B4 File Offset: 0x0009C9B4
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.o.o_o_0o0O_.
		End Function

		' Token: 0x06001842 RID: 6210 RVA: 0x0009E7BC File Offset: 0x0009C9BC
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o.o_o_0o0O_. = A_0
		End Sub

		' Token: 0x06001843 RID: 6211 RVA: 0x0009E7C5 File Offset: 0x0009C9C5
		Friend Sub New(A_0 As String, A_1 As HttpListenerResponse, A_2 As String)
			Me.oO0o0o._0.("text/html")
			Me.Oo000.o00. = A_0
			Me.Oo000.o00. = A_1
			Me.o.0ooO__. = A_2
		End Sub

		' Token: 0x06001844 RID: 6212 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			If Me.Oo000.o00. IsNot Nothing Then
				Dim encoding As Encoding = HttpFunctions.OO.0o.(Me.o.0ooO__.)
				Dim memoryStream As MemoryStream = New MemoryStream(encoding.GetBytes(Me.Oo000.o00.))
				Dim stream As Stream = Me.Oo000.o00..OutputStream
				Try
					Dim array As Byte() = New Byte(51200) {}
					Me.Oo000.o00..ContentType = Me.oO0o0o._0.() + "; charset=" + Me.o.0ooO__.
					Me.Oo000.o00..ContentEncoding = encoding
					If Me.Oo000.o00..Headers("Content-Encoding") Is Nothing Then
						Me.Oo000.o00..ContentLength64 = memoryStream.Length
					ElseIf Me.Oo000.o00..Headers("Content-Encoding").Contains("gzip") Then
						stream = New GZipStream(Me.Oo000.o00..OutputStream, CompressionMode.Compress, False)
					ElseIf Me.Oo000.o00..Headers("Content-Encoding").Contains("deflate") Then
						stream = New DeflateStream(Me.Oo000.o00..OutputStream, CompressionMode.Compress, False)
					Else
						Me.Oo000.o00..ContentLength64 = memoryStream.Length
					End If
					Dim num As Integer = memoryStream.Read(array, 0, array.Length)
					While num > 0 AndAlso stream.CanWrite
						stream.Write(array, 0, num)
						num = memoryStream.Read(array, 0, array.Length)
					End While
				Catch ex As Exception
				Finally
					Try
						memoryStream.Close()
						stream.Flush()
						stream.Close()
						If stream IsNot Me.Oo000.o00..OutputStream Then
							Me.Oo000.o00..OutputStream.Close()
						End If
						Me.Oo000.o00..Close()
						Me.Oo000.o00..Abort()
					Catch ex2 As Exception
					End Try
				End Try
			End If
		End Sub

		' Token: 0x04000A10 RID: 2576
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A11 RID: 2577
		Private <<EMPTY_NAME>> As HttpListenerResponse

		' Token: 0x04000A12 RID: 2578
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A13 RID: 2579
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
