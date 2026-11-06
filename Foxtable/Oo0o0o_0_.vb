Imports System
Imports System.Net
Imports Foxtable.XLS
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001F0 RID: 496
	Friend Class Oo0o0o_0_
		' Token: 0x0600182E RID: 6190 RVA: 0x0009DA34 File Offset: 0x0009BC34
		Friend Sub New(A_0 As HttpListenerResponse, A_1 As Book)
			Me.O_0._00_. = True
			Me.O_0._00_. = A_0
			Me.O_0._00_. = A_1
		End Sub

		' Token: 0x0600182F RID: 6191 RVA: 0x0009DA54 File Offset: 0x0009BC54
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(10) + ".pdf"
			Dim text2 As String = ""
			Try
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()) Then
					OO_00oOO.FileSys.CreateDirectory(O_O0OO.OoO__.0oO0oo.())
				End If
				If Me.O_0._00_. Then
					If Me.O_0._00_. Is Nothing OrElse Me.O_0._00_..Length = 0 Then
						Me.O_0._00_..Build(New Integer(-1) {})
					Else
						Me.O_0._00_..Build(Me.O_0._00_.)
					End If
				End If
				Me.O_0._00_..SaveToPdf(text)
			Catch ex As Exception
				text2 = ex.Message
			End Try
			If OO_00oOO.FileSys.FileExists(text) AndAlso Operators.CompareString(text2, "", True) = 0 Then
				New o_o0O_Ooo__O(text, Me.O_0._00_.).ooO0O.0.(Nothing)
				Return
			End If
			New oOo0_o0Oo_00(text2, Me.O_0._00_., "utf-8").Oo000.o00.(Nothing)
		End Sub

		' Token: 0x040009F1 RID: 2545
		Private <<EMPTY_NAME>> As Book

		' Token: 0x040009F2 RID: 2546
		Private <<EMPTY_NAME>> As HttpListenerResponse

		' Token: 0x040009F3 RID: 2547
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040009F4 RID: 2548
		Friend <<EMPTY_NAME>> As Integer()
	End Class
End Namespace
