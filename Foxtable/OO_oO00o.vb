Imports System
Imports System.Net
Imports Foxtable.XLS
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001EF RID: 495
	Friend Class OO_oO00o
		' Token: 0x0600182C RID: 6188 RVA: 0x0009D912 File Offset: 0x0009BB12
		Friend Sub New(A_0 As HttpListenerResponse, A_1 As Book)
			Me.OO.oO00. = True
			Me.O_0._00_. = A_0
			Me.OO.oO00. = A_1
		End Sub

		' Token: 0x0600182D RID: 6189 RVA: 0x0009D930 File Offset: 0x0009BB30
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(10) + ".htm"
			Dim text2 As String = ""
			Try
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()) Then
					OO_00oOO.FileSys.CreateDirectory(O_O0OO.OoO__.0oO0oo.())
				End If
				If Me.OO.oO00. Then
					If Me.O_0._00_. Is Nothing OrElse Me.O_0._00_..Length = 0 Then
						Me.OO.oO00..Build(New Integer(-1) {})
					Else
						Me.OO.oO00..Build(Me.O_0._00_.)
					End If
				End If
				Me.OO.oO00..SaveToHTML(text)
			Catch ex As Exception
				text2 = ex.Message
			End Try
			If OO_00oOO.FileSys.FileExists(text) AndAlso Operators.CompareString(text2, "", True) = 0 Then
				New o_o0O_Ooo__O(text, Me.O_0._00_.).ooO0O.0.(Nothing)
				Return
			End If
			New oOo0_o0Oo_00(text2, Me.O_0._00_., "utf-8").Oo000.o00.(Nothing)
		End Sub

		' Token: 0x040009ED RID: 2541
		Private <<EMPTY_NAME>> As Book

		' Token: 0x040009EE RID: 2542
		Private <<EMPTY_NAME>> As HttpListenerResponse

		' Token: 0x040009EF RID: 2543
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040009F0 RID: 2544
		Friend <<EMPTY_NAME>> As Integer()
	End Class
End Namespace
