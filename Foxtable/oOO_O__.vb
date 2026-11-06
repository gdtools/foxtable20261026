Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports System.Net

Namespace Foxtable
	' Token: 0x02000226 RID: 550
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oOO_O__
		' Token: 0x06001999 RID: 6553 RVA: 0x000A57C9 File Offset: 0x000A39C9
		Friend Sub New(A_0 As MemoryStream, A_1 As HttpListenerResponse)
			Me.oO0o0o._0. = A_0
			Me.oO0o0o._0. = A_1
		End Sub

		' Token: 0x0600199A RID: 6554 RVA: 0x000A57E0 File Offset: 0x000A39E0
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim stream As Stream = Me.oO0o0o._0..OutputStream
			Try
				Me.oO0o0o._0..ContentType = "text/xml"
				If Me.oO0o0o._0..Headers("Content-Encoding") Is Nothing Then
					Me.oO0o0o._0..ContentLength64 = Me.oO0o0o._0..Length
				ElseIf Me.oO0o0o._0..Headers("Content-Encoding").Contains("gzip") Then
					stream = New GZipStream(Me.oO0o0o._0..OutputStream, CompressionMode.Compress, False)
				ElseIf Me.oO0o0o._0..Headers("Content-Encoding").Contains("deflate") Then
					stream = New DeflateStream(Me.oO0o0o._0..OutputStream, CompressionMode.Compress, False)
				Else
					Me.oO0o0o._0..ContentLength64 = Me.oO0o0o._0..Length
				End If
				Dim array As Byte() = New Byte(51200) {}
				Dim num As Integer = Me.oO0o0o._0..Read(array, 0, array.Length)
				While num > 0 AndAlso stream.CanWrite
					stream.Write(array, 0, num)
					num = Me.oO0o0o._0..Read(array, 0, array.Length)
				End While
			Catch ex As Exception
			Finally
				Try
					Me.oO0o0o._0..Close()
					stream.Flush()
					stream.Close()
					If stream IsNot Me.oO0o0o._0..OutputStream Then
						Me.oO0o0o._0..OutputStream.Close()
					End If
					Me.oO0o0o._0..Close()
					Me.oO0o0o._0..Abort()
				Catch ex2 As Exception
				End Try
			End Try
		End Sub

		' Token: 0x04000AC6 RID: 2758
		Private <<EMPTY_NAME>> As MemoryStream

		' Token: 0x04000AC7 RID: 2759
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
