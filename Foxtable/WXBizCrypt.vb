Imports System
Imports Tencent

Namespace Foxtable
	' Token: 0x020001F6 RID: 502
	Public Class WXBizCrypt
		' Token: 0x0600183A RID: 6202 RVA: 0x0009E3FC File Offset: 0x0009C5FC
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.o_.o_o_O000_0_. = A_0
			Me.OoOoo_o_.o_. = A_1
			Me.oO_0oo.0oo__0_. = A_2
			Me.O0O00.0Oo00. = New WXBizMsgCrypt(A_1, A_2, A_0)
		End Sub

		' Token: 0x0600183B RID: 6203 RVA: 0x0009E428 File Offset: 0x0009C628
		Public Function EncryptMsg(e As RequestEventArgs, sRespData As String) As String
			Dim text As String = ""
			Dim text2 As String = e.GetValues("timestamp")
			Dim text3 As String = e.GetValues("nonce")
			Dim num As Integer = Me.O0O00.0Oo00..EncryptMsg(sRespData, text2, text3, text)
			Dim result As String
			If num = 0 Then
				result = text
			Else
				result = num.ToString()
			End If
			Return result
		End Function

		' Token: 0x0600183C RID: 6204 RVA: 0x0009E480 File Offset: 0x0009C680
		Public Function DecryptMsg(e As RequestEventArgs) As String
			Dim text As String = ""
			Dim text2 As String = e.GetValues("msg_signature")
			Dim text3 As String = e.GetValues("timestamp")
			Dim text4 As String = e.GetValues("nonce")
			Dim num As Integer = Me.O0O00.0Oo00..DecryptMsg(text2, text3, text4, e.PlainText, text)
			Dim result As String
			If num = 0 Then
				result = text
			Else
				result = num.ToString()
			End If
			Return result
		End Function

		' Token: 0x0600183D RID: 6205 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
		Public Function CheckQYSignature(e As RequestEventArgs) As Integer
			Dim value As String = ""
			Dim text As String = e.GetValues("msg_signature")
			Dim text2 As String = e.GetValues("timestamp")
			Dim text3 As String = e.GetValues("nonce")
			Dim text4 As String = e.GetValues("echostr")
			Dim num As Integer = Me.O0O00.0Oo00..VerifyURL(text, text2, text3, text4, value)
			If num = 0 Then
				e.WriteString(value)
			End If
			Return num
		End Function

		' Token: 0x0600183E RID: 6206 RVA: 0x0009E568 File Offset: 0x0009C768
		Public Shared Function GetErorDesc(value As Integer) As String
			Dim result As String
			Select Case value
				Case -40010
					result = "base64解密异常"
				Case -40009
					result = "base64加密异常"
				Case -40008
					result = "解密后得到的buffer非法"
				Case -40007
					result = "AES 解密失败"
				Case -40006
					result = "AES 加密失败"
				Case -40005
					result = "corpid/appid 校验错误"
				Case -40004
					result = "AESKey 非法"
				Case -40003
					result = "sha加密生成签名失败"
				Case -40002
					result = "xml解析失败"
				Case Else
					If value = 0 Then
						result = "签名验证成功。"
					Else
						result = "未知错误"
					End If
			End Select
			Return result
		End Function

		' Token: 0x04000A0A RID: 2570
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A0B RID: 2571
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A0C RID: 2572
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A0D RID: 2573
		Private <<EMPTY_NAME>> As WXBizMsgCrypt
	End Class
End Namespace
