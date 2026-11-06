Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Text

Namespace Foxtable
	' Token: 0x020001BA RID: 442
	Friend Class ooo0
		Inherits IMBuddy

		' Token: 0x0600149C RID: 5276 RVA: 0x0008141F File Offset: 0x0007F61F
		Friend Sub New(A_0 As String, A_1 As IPEndPoint, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1, A_2)
			Me.O_oO._O. = A_0
			Me.o.OOOOo. = A_2
			Me.OO0_o.Oo0O. = A_3
			Me.O_oO._O. = DateTime.Now
		End Sub

		' Token: 0x0600149D RID: 5277 RVA: 0x0008144B File Offset: 0x0007F64B
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.O_oO._O.
		End Function

		' Token: 0x0600149E RID: 5278 RVA: 0x00081453 File Offset: 0x0007F653
		Public Function <<EMPTY_NAME>>() As String
			Return Me.o.OOOOo.
		End Function

		' Token: 0x0600149F RID: 5279 RVA: 0x0008145B File Offset: 0x0007F65B
		Public Function <<EMPTY_NAME>>() As List(Of IMBuddy)
			Return Me.O_oO._O.
		End Function

		' Token: 0x060014A0 RID: 5280 RVA: 0x00081463 File Offset: 0x0007F663
		Public Sub <<EMPTY_NAME>>(A_0 As List(Of IMBuddy))
			Me.O_oO._O. = A_0
			Me.O_oO._O. = True
		End Sub

		' Token: 0x060014A1 RID: 5281 RVA: 0x00081473 File Offset: 0x0007F673
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.OO0_o.Oo0O.
		End Function

		' Token: 0x060014A2 RID: 5282 RVA: 0x0008147C File Offset: 0x0007F67C
		Friend Function <<EMPTY_NAME>>() As String
			If Me.O_oO._O. Then
				Me.O_oO._O. = False
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Try
					For Each imbuddy As IMBuddy In Me.O_oO._O.
						stringBuilder.Append(imbuddy.Name + ",")
					Next
				Finally
					Dim enumerator As List(Of IMBuddy).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If stringBuilder.Length > 0 Then
					Me.O.o00o0OO_. = stringBuilder.ToString().Trim(New Char() { ","c })
				Else
					Me.O.o00o0OO_. = ""
				End If
			End If
			Return Me.O.o00o0OO_.
		End Function

		' Token: 0x060014A3 RID: 5283 RVA: 0x00081530 File Offset: 0x0007F730
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O.o00o0OO_. = A_0
		End Sub

		' Token: 0x060014A4 RID: 5284 RVA: 0x00081539 File Offset: 0x0007F739
		Friend Function <<EMPTY_NAME>>() As DateTime
			Return Me.O_oO._O.
		End Function

		' Token: 0x060014A5 RID: 5285 RVA: 0x00081541 File Offset: 0x0007F741
		Friend Sub <<EMPTY_NAME>>(A_0 As DateTime)
			Me.O_oO._O. = A_0
		End Sub

		' Token: 0x04000811 RID: 2065
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000812 RID: 2066
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000813 RID: 2067
		Private <<EMPTY_NAME>> As List(Of IMBuddy)

		' Token: 0x04000814 RID: 2068
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000815 RID: 2069
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000816 RID: 2070
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000817 RID: 2071
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
