Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000BE RID: 190
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class O0O
		' Token: 0x06000837 RID: 2103 RVA: 0x00037D43 File Offset: 0x00035F43
		Public Sub New(A_0 As String)
			Me.OO.OoO0. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.Oo_.O_O0oO__. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.OO.OoO0. = 30
			Me.OO._o_OO.(A_0)
		End Sub

		' Token: 0x06000838 RID: 2104 RVA: 0x00037D7A File Offset: 0x00035F7A
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.OO.OoO0.
		End Function

		' Token: 0x06000839 RID: 2105 RVA: 0x00037D82 File Offset: 0x00035F82
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OO.OoO0. = A_0
		End Sub

		' Token: 0x0600083A RID: 2106 RVA: 0x00037D8B File Offset: 0x00035F8B
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.OO.OoO0.
		End Function

		' Token: 0x0600083B RID: 2107 RVA: 0x00037D93 File Offset: 0x00035F93
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO.OoO0. = A_0
			Me.OO._o_OO.()
		End Sub

		' Token: 0x0600083C RID: 2108 RVA: 0x00037DA4 File Offset: 0x00035FA4
		Friend Sub <<EMPTY_NAME>>()
			Me.OO.OoO0..Clear()
			Me.Oo_.O_O0oO__..Clear()
			Dim stringReader As StringReader = New StringReader(Me.oO0_0.o.())
			Me.Oo_.O_O0oO__. = stringReader.ReadLine()
			Dim dictionary As Dictionary(Of String, String) = Nothing
			While stringReader.Peek() <> -1
				Dim text As String = stringReader.ReadLine()
				If Operators.CompareString(text, "", True) > 0 Then
					text = text.Trim()
				End If
				If Operators.CompareString(text.Trim(), "-FormData-", True) = 0 Then
					dictionary = Me.OO.OoO0.
				ElseIf Operators.CompareString(text.Trim(), "-Cookies-", True) = 0 Then
					dictionary = Me.Oo_.O_O0oO__.
				ElseIf dictionary IsNot Nothing AndAlso Operators.CompareString(text, "", True) > 0 Then
					Dim array As String() = text.Split(New Char() { ":"c })
					If array.Length = 2 Then
						dictionary(array(0)) = array(1)
					End If
				End If
			End While
		End Sub

		' Token: 0x0600083D RID: 2109 RVA: 0x00037E80 File Offset: 0x00036080
		Friend Function <<EMPTY_NAME>>() As HttpClient
			Dim httpClient As HttpClient = New HttpClient(Me.Oo_.O_O0oO__.)
			Try
				For Each key As String In Me.OO.OoO0..Keys
					httpClient.FormData(key) = Me.OO.OoO0.(key)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each key2 As String In Me.Oo_.O_O0oO__..Keys
					httpClient.SCookies(key2) = Me.Oo_.O_O0oO__.(key2)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			If Me.OO._o_OO.() > 0 Then
				httpClient.Timeout = Me.OO._o_OO.()
				httpClient.ReadWriteTimeout = Me.OO._o_OO.()
			End If
			Return httpClient
		End Function

		' Token: 0x0600083E RID: 2110 RVA: 0x00037F74 File Offset: 0x00036174
		Friend Function <<EMPTY_NAME>>() As Boolean
			Me.OO.OoO0. = False
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			httpClient.FormData("Action") = 9.ToString()
			Dim data As String = httpClient.GetData(True)
			If httpClient.RCookies.ContainsKey("Error") Then
				Throw New Exception(httpClient.RCookies("Error"))
			End If
			Dim num As Integer = -1
			If Operators.CompareString(data, "", True) > 0 AndAlso Not Integer.TryParse(data, num) Then
				num = -1
			End If
			If num >= 0 AndAlso [Enum].IsDefined(GetType(DataServerTypeEnum), num) Then
				Me.OO.OoO0. = CType(num, DataServerTypeEnum)
				Me.OO.OoO0. = True
				Return True
			End If
			Throw New Exception("无法连接服务端数据源！")
		End Function

		' Token: 0x0600083F RID: 2111 RVA: 0x00038034 File Offset: 0x00036234
		Friend Function <<EMPTY_NAME>>() As List(Of String)
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			httpClient.FormData("Action") = 10.ToString()
			Dim data As String = httpClient.GetData()
			Dim list As List(Of String) = New List(Of String)()
			If Operators.CompareString(data, "", True) > 0 Then
				list.AddRange(data.ToString().Split(New Char() { "|"c }))
			End If
			Return list
		End Function

		' Token: 0x06000840 RID: 2112 RVA: 0x0003809C File Offset: 0x0003629C
		Public Function <<EMPTY_NAME>>() As List(Of String)
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			httpClient.FormData("Action") = 11.ToString()
			Dim data As String = httpClient.GetData()
			Dim list As List(Of String) = New List(Of String)()
			If Operators.CompareString(data, "", True) > 0 Then
				list.AddRange(data.ToString().Split(New Char() { "|"c }))
			End If
			Return list
		End Function

		' Token: 0x06000841 RID: 2113 RVA: 0x00038104 File Offset: 0x00036304
		Friend Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Boolean = False) As DataTable
			Dim a_ As String = A_0
			If Not A_1 Then
				If Me.OO.OoO0. = DataServerTypeEnum.Oracle Then
					a_ = "Select * From " + A_0
				ElseIf Not A_0.StartsWith("[") Then
					a_ = "Select * From [" + A_0 + "]"
				Else
					a_ = "Select * From " + A_0
				End If
			End If
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			httpClient.FormData("Action") = 12.ToString()
			httpClient.[Select] = a_
			Return httpClient.GetBaseDataTable()
		End Function

		' Token: 0x06000842 RID: 2114 RVA: 0x00038188 File Offset: 0x00036388
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As DataTable
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			If A_1 Then
				httpClient.[Select] = A_0
			Else
				httpClient.FormData("DataTable") = A_0
			End If
			httpClient.FormData("Action") = 1.ToString()
			Return httpClient.GetBaseDataTable()
		End Function

		' Token: 0x06000843 RID: 2115 RVA: 0x000381D8 File Offset: 0x000363D8
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As DataTable
			Dim httpClient As HttpClient = Me.oO0_0.o.()
			If A_1 Then
				httpClient.[Select] = A_0
			Else
				httpClient.FormData("DataTable") = A_0
			End If
			httpClient.FormData("Action") = 2.ToString()
			Return httpClient.GetBaseDataTable()
		End Function

		' Token: 0x06000844 RID: 2116 RVA: 0x00038228 File Offset: 0x00036428
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, String)
			Return Me.OO.OoO0.
		End Function

		' Token: 0x06000845 RID: 2117 RVA: 0x00038230 File Offset: 0x00036430
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, String)
			Return Me.Oo_.O_O0oO__.
		End Function

		' Token: 0x06000846 RID: 2118 RVA: 0x00038238 File Offset: 0x00036438
		Public Function <<EMPTY_NAME>>() As String
			Return Me.Oo_.O_O0oO__.
		End Function

		' Token: 0x06000847 RID: 2119 RVA: 0x00038240 File Offset: 0x00036440
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.Oo_.O_O0oO__. = A_0
		End Sub

		' Token: 0x040002CF RID: 719
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040002D0 RID: 720
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040002D1 RID: 721
		Friend <<EMPTY_NAME>> As DataServerTypeEnum

		' Token: 0x040002D2 RID: 722
		Private <<EMPTY_NAME>> As String

		' Token: 0x040002D3 RID: 723
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040002D4 RID: 724
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040002D5 RID: 725
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
