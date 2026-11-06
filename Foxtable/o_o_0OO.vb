Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Web
Imports Foxtable.XLS

Namespace Foxtable
	' Token: 0x020001F9 RID: 505
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_o_0OO
		' Token: 0x06001845 RID: 6213 RVA: 0x0009E9FC File Offset: 0x0009CBFC
		Friend Sub New(A_0 As HttpListenerResponse, A_1 As Book, A_2 As String, A_3 As Boolean)
			Me.OO__o_OOoOo_.0. = A_0
			Me.OO__o_OOoOo_.0. = A_1
			Me.OO__o_OOoOo_.0. = A_2
			Me.OO__o_OOoOo_.0. = A_3
		End Sub

		' Token: 0x06001846 RID: 6214 RVA: 0x0009EA24 File Offset: 0x0009CC24
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Try
				If Me.OO__o_OOoOo_.0..PreBuild Then
					Me.OO__o_OOoOo_.0..Build(New Integer(-1) {})
				End If
				If Me.OO__o_OOoOo_.0..oO.o_0o__..CompatibilityMode = 1 Then
					Me.OO__o_OOoOo_.0..oO.o_0o__..Save(memoryStream, 2)
				Else
					Me.OO__o_OOoOo_.0..oO.o_0o__..Save(memoryStream, 0)
				End If
				memoryStream.Position = 0L
				If Me.OO__o_OOoOo_.0. Then
					Me.OO__o_OOoOo_.0..ContentType = "application/vnd.ms-excel"
					Me.OO__o_OOoOo_.0..AddHeader("Content-Disposition", "inline;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.OO__o_OOoOo_.0.), Me.OO__o_OOoOo_.0..ContentEncoding))
				Else
					Me.OO__o_OOoOo_.0..ContentType = "application/octet-stream"
					Me.OO__o_OOoOo_.0..AddHeader("Content-Disposition", "attachment;FileName=" + HttpUtility.UrlEncode(OO_00oOO.FileSys.GetName(Me.OO__o_OOoOo_.0.), Me.OO__o_OOoOo_.0..ContentEncoding))
				End If
				Me.OO__o_OOoOo_.0..ContentLength64 = memoryStream.Length
				Dim array As Byte() = New Byte(51200) {}
				Dim num As Integer = memoryStream.Read(array, 0, array.Length)
				While num > 0 AndAlso Me.OO__o_OOoOo_.0..OutputStream.CanWrite
					Me.OO__o_OOoOo_.0..OutputStream.Write(array, 0, num)
					num = memoryStream.Read(array, 0, array.Length)
				End While
			Catch ex As Exception
			Finally
				Me.OO__o_OOoOo_.0..OutputStream.Close()
				Me.OO__o_OOoOo_.0..Close()
				Me.OO__o_OOoOo_.0..Abort()
				If memoryStream IsNot Nothing Then
					memoryStream.Close()
				End If
			End Try
		End Sub

		' Token: 0x04000A14 RID: 2580
		Private <<EMPTY_NAME>> As Book

		' Token: 0x04000A15 RID: 2581
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A16 RID: 2582
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A17 RID: 2583
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
