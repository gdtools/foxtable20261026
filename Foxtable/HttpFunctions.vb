Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020001DE RID: 478
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module HttpFunctions
		' Token: 0x0600170E RID: 5902 RVA: 0x0009445B File Offset: 0x0009265B
		<oO0oooo("A0227")>
		Public Function CompressJson(token As JToken) As String
			Return token.ToString(0).Replace(vbCrLf, "")
		End Function

		' Token: 0x0600170F RID: 5903 RVA: 0x00094473 File Offset: 0x00092673
		<oO0oooo("A0227")>
		Public Function CompressJson(jsonString As String) As String
			Return JObject.Parse(jsonString).ToString(0).Replace(vbCrLf, "")
		End Function

		' Token: 0x06001710 RID: 5904 RVA: 0x00094490 File Offset: 0x00092690
		Public Function <<EMPTY_NAME>>(A_0 As String) As String
			Return JArray.Parse(A_0).ToString(0).Replace(vbCrLf, "")
		End Function

		' Token: 0x06001711 RID: 5905 RVA: 0x000944B0 File Offset: 0x000926B0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Encoding
			A_0 = A_0.Trim(New Char() { """"c }).Trim(New Char() { "'"c })
			Dim result As Encoding
			If Operators.CompareString(A_0.ToLower(), "utf-8", True) = 0 OrElse Operators.CompareString(A_0.ToLower(), "utf8", True) = 0 Then
				result = Encoding.UTF8
			ElseIf Operators.CompareString(A_0.ToLower(), "utf-16", True) = 0 OrElse Operators.CompareString(A_0.ToLower(), "utf16", True) = 0 Then
				result = Encoding.Unicode
			Else
				Try
					result = Encoding.GetEncoding(A_0)
				Catch ex As Exception
					result = Encoding.UTF8
				End Try
			End If
			Return result
		End Function
	End Module
End Namespace
