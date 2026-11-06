Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000436 RID: 1078
	Friend Class oO0o0_0oO0_oO
		' Token: 0x0600473A RID: 18234 RVA: 0x001D7048 File Offset: 0x001D5248
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer) As Byte()
			Dim hashAlgorithm As HashAlgorithm = New SHA1CryptoServiceProvider()
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
			Return CType(Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), New Byte(A_1 - 1 + 1 - 1) {}), Byte())
		End Function

		' Token: 0x0600473B RID: 18235 RVA: 0x001D7080 File Offset: 0x001D5280
		Public Sub New(A_0 As String, A_1 As String)
			Me.O_0oO0o.OO_. = New TripleDESCryptoServiceProvider()
			Me.O_0oO0o.OO_..Key = Me.O_0oO0o.OO_.(A_0, Me.O_0oO0o.OO_..KeySize / 8)
			Me.O_0oO0o.OO_..IV = Me.O_0oO0o.OO_.(A_1, Me.O_0oO0o.OO_..BlockSize / 8)
		End Sub

		' Token: 0x0600473C RID: 18236 RVA: 0x001D70DC File Offset: 0x001D52DC
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.O_0oO0o.OO_..CreateEncryptor(), CryptoStreamMode.Write)
			cryptoStream.Write(bytes, 0, bytes.Length)
			cryptoStream.FlushFinalBlock()
			Return Convert.ToBase64String(memoryStream.ToArray())
		End Function

		' Token: 0x0600473D RID: 18237 RVA: 0x001D7128 File Offset: 0x001D5328
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.Length Mod 4 <> 0 Then
				result = ""
			Else
				Dim array As Byte() = Convert.FromBase64String(A_0)
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.O_0oO0o.OO_..CreateDecryptor(), CryptoStreamMode.Write)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.FlushFinalBlock()
				result = Encoding.Unicode.GetString(memoryStream.ToArray())
			End If
			Return result
		End Function

		' Token: 0x04001D21 RID: 7457
		Private <<EMPTY_NAME>> As TripleDESCryptoServiceProvider
	End Class
End Namespace
