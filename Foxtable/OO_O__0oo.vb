Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200043A RID: 1082
	Friend NotInheritable Class OO_O__0oo
		' Token: 0x0600477B RID: 18299 RVA: 0x001D8570 File Offset: 0x001D6770
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer) As Byte()
			Dim hashAlgorithm As HashAlgorithm = New SHA1CryptoServiceProvider()
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
			Return CType(Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), New Byte(A_1 - 1 + 1 - 1) {}), Byte())
		End Function

		' Token: 0x0600477C RID: 18300 RVA: 0x001D85A8 File Offset: 0x001D67A8
		Public Sub New(A_0 As String, A_1 As String)
			Me.o0O_.00. = New TripleDESCryptoServiceProvider()
			Me.o0O_.00..Key = Me.o0O_.00.(A_0, Me.o0O_.00..KeySize / 8)
			Me.o0O_.00..IV = Me.o0O_.00.(A_1, Me.o0O_.00..BlockSize / 8)
		End Sub

		' Token: 0x0600477D RID: 18301 RVA: 0x001D8604 File Offset: 0x001D6804
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.o0O_.00..CreateEncryptor(), CryptoStreamMode.Write)
			cryptoStream.Write(bytes, 0, bytes.Length)
			cryptoStream.FlushFinalBlock()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

		' Token: 0x0600477E RID: 18302 RVA: 0x001D8650 File Offset: 0x001D6850
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.Length Mod 4 <> 0 Then
				result = ""
			Else
				Dim array As Byte() = Convert.FromBase64String(A_0)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.o0O_.00..CreateDecryptor(), CryptoStreamMode.Write)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				result = Encoding.Unicode.GetString(memoryStream.ToArray())
			End If
			Return result
		End Function

		' Token: 0x04001D37 RID: 7479
		Private <<EMPTY_NAME>> As TripleDESCryptoServiceProvider
	End Class
End Namespace
