Imports System
Imports System.Net
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001F4 RID: 500
	Friend Class ooo_0O0o00
		' Token: 0x06001836 RID: 6198 RVA: 0x0009E15C File Offset: 0x0009C35C
		Public Sub New(A_0 As PrintDoc, A_1 As HttpListenerResponse)
			Me.oO0o0o._0. = A_0
			Me.oO0o0o._0. = A_1
		End Sub

		' Token: 0x06001837 RID: 6199 RVA: 0x0009E174 File Offset: 0x0009C374
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(10) + ".pdf"
			Dim text2 As String = ""
			Try
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()) Then
					OO_00oOO.FileSys.CreateDirectory(O_O0OO.OoO__.0oO0oo.())
				End If
				Me.oO0o0o._0..SavePDF(text, False)
			Catch ex As Exception
				text2 = ex.Message
			End Try
			If OO_00oOO.FileSys.FileExists(text) AndAlso Operators.CompareString(text2, "", True) = 0 Then
				New o_o0O_Ooo__O(text, Me.oO0o0o._0.).ooO0O.0.(Nothing)
				Return
			End If
			New oOo0_o0Oo_00(text2, Me.oO0o0o._0., "utf-8").Oo000.o00.(Nothing)
		End Sub

		' Token: 0x04000A04 RID: 2564
		Private <<EMPTY_NAME>> As PrintDoc

		' Token: 0x04000A05 RID: 2565
		Private <<EMPTY_NAME>> As HttpListenerResponse
	End Class
End Namespace
