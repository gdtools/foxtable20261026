Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000437 RID: 1079
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module O00
		' Token: 0x0600473E RID: 18238
		Private Declare Function FileEncrypt Lib "Foxtable.IO.dll" (A_0 As String, A_1 As String, A_2 As String) As Integer

		' Token: 0x0600473F RID: 18239
		Private Declare Function FileDecrypt Lib "Foxtable.IO.dll" (A_0 As String, A_1 As String, A_2 As String) As Integer

		' Token: 0x06004740 RID: 18240
		Private Declare Function CRCFileCheck Lib "Foxtable.IO.dll" (A_0 As String, A_1 As StringBuilder) As Integer

		' Token: 0x06004741 RID: 18241
		Private Declare Function CRC32 Lib "Foxtable.IO.dll" (A_0 As String, A_1 As Integer, A_2 As StringBuilder) As Integer

		' Token: 0x06004742 RID: 18242 RVA: 0x001D7188 File Offset: 0x001D5388
		<oO0oooo("0352")>
		Public Function MD5Encrypt(strToHash As String) As String
			New MD5CryptoServiceProvider()
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(strToHash)
			Dim inArray As Byte() = md5CryptoServiceProvider.ComputeHash(bytes)
			md5CryptoServiceProvider.Clear()
			Return Convert.ToBase64String(inArray)
		End Function

		' Token: 0x06004743 RID: 18243 RVA: 0x001D71C0 File Offset: 0x001D53C0
		Public Function MD5(strToHash As String) As String
			New MD5CryptoServiceProvider()
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim bytes As Byte() = Encoding.ASCII.GetBytes(strToHash)
			Dim value As Byte() = md5CryptoServiceProvider.ComputeHash(bytes)
			md5CryptoServiceProvider.Clear()
			Return BitConverter.ToString(value).Replace("-", "")
		End Function

		' Token: 0x06004744 RID: 18244 RVA: 0x001D7206 File Offset: 0x001D5406
		<oO0oooo("0350")>
		Public Function EncryptText(Text As String, Key As String, IV As String) As String
			Return New OO_O__0oo(Key, IV).o0O_.00.(Text)
		End Function

		' Token: 0x06004745 RID: 18245 RVA: 0x001D7218 File Offset: 0x001D5418
		<oO0oooo("0351")>
		Public Function DecryptText(Text As String, Key As String, IV As String) As String
			Dim oo_O__0oo As OO_O__0oo = New OO_O__0oo(Key, IV)
			Dim result As String
			If Text Is Nothing OrElse Text.Length = 0 Then
				result = ""
			Else
				result = oo_O__0oo.OO.O0_O.(Text)
			End If
			Return result
		End Function

		' Token: 0x06004746 RID: 18246 RVA: 0x001D724C File Offset: 0x001D544C
		<oO0oooo("1489")>
		Public Function CRCCheckFile(FileName As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(32)
			Dim result As String
			If O00.CRCFileCheck(FileName, stringBuilder) = 1 Then
				result = stringBuilder.ToString().Trim()
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06004747 RID: 18247 RVA: 0x001D727C File Offset: 0x001D547C
		<oO0oooo("1490")>
		Public Function CRCCheckString(strValue As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(32)
			Dim result As String
			If O00.CRC32(strValue, strValue.Length, stringBuilder) = 1 Then
				result = stringBuilder.ToString().Trim()
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06004748 RID: 18248 RVA: 0x001D72B4 File Offset: 0x001D54B4
		<oO0oooo("1491")>
		Public Function EncryptFile(InFile As String, OutFile As String, PassWord As String) As Boolean
			Return Operators.CompareString(InFile, OutFile, True) <> 0 AndAlso O00.FileEncrypt(InFile, OutFile, PassWord) = 1
		End Function

		' Token: 0x06004749 RID: 18249 RVA: 0x001D72E4 File Offset: 0x001D54E4
		<oO0oooo("1492")>
		Public Function DecryptFile(InFile As String, OutFile As String, PassWord As String) As Boolean
			Return Operators.CompareString(InFile, OutFile, True) <> 0 AndAlso O00.FileDecrypt(InFile, OutFile, PassWord) = 1
		End Function

		' Token: 0x0600474A RID: 18250 RVA: 0x001D7311 File Offset: 0x001D5511
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String) As String
			Return New oO0o0_0oO0_oO(A_1, A_2).O_0oO0o.OO_.(A_0)
		End Function

		' Token: 0x0600474B RID: 18251 RVA: 0x001D7320 File Offset: 0x001D5520
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String) As String
			Dim oO0o0_0oO0_oO As oO0o0_0oO0_oO = New oO0o0_0oO0_oO(A_1, A_2)
			Dim result As String
			If A_0 Is Nothing OrElse A_0.Length = 0 Then
				result = ""
			Else
				result = oO0o0_0oO0_oO.o___oOo.o_OO.(A_0)
			End If
			Return result
		End Function

		' Token: 0x0600474C RID: 18252 RVA: 0x001D7354 File Offset: 0x001D5554
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String) As String
			Dim oo_O__0oo As OO_O__0oo = New OO_O__0oo(A_1, A_2)
			Dim result As String
			If A_0 Is Nothing OrElse A_0.Length = 0 Then
				result = ""
			Else
				result = oo_O__0oo.OO.O0_O.(A_0)
			End If
			Return result
		End Function

		' Token: 0x0600474D RID: 18253 RVA: 0x001D7388 File Offset: 0x001D5588
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(32)
			Dim result As String
			If O00.CRCFileCheck(A_0, stringBuilder) = 1 Then
				result = stringBuilder.ToString().Trim()
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x0600474E RID: 18254 RVA: 0x001D73B8 File Offset: 0x001D55B8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			New MD5CryptoServiceProvider()
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(A_0)
			Dim inArray As Byte() = md5CryptoServiceProvider.ComputeHash(bytes)
			md5CryptoServiceProvider.Clear()
			Return Convert.ToBase64String(inArray)
		End Function
	End Module
End Namespace
