Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq
Imports O0o0.00

Namespace Foxtable
	' Token: 0x020001E3 RID: 483
	<ComVisible(True)>
	<oO0oooo("A0163")>
	Public Class HttpClient
		' Token: 0x17000537 RID: 1335
		' (get) Token: 0x060017CF RID: 6095 RVA: 0x00099FE7 File Offset: 0x000981E7
		' (set) Token: 0x060017D0 RID: 6096 RVA: 0x00099FEF File Offset: 0x000981EF
		Public Property EncodeCookie As Boolean

		' Token: 0x060017D1 RID: 6097 RVA: 0x00099FF8 File Offset: 0x000981F8
		Public Sub New(A_0 As String)
			Me.o00__oO.0OO. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.o.__00OOO. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.o0Oo0o.o_O. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.o00__oO.0OO. = New HttpFilleCollection()
			Me.oOO0.0oOOOo. = "utf-8"
			Me.O00_OO0.oooO. = "utf-8"
			Me.O_o0.00. = -1
			Me.oOO0.0oOOOo. = -1
			Me.O_O.0o. = New Dictionary(Of String, String)()
			Me.O_o0.00. = False
			Me.oOo0_.O_O0. = ""
			Me.oOO0.0oOOOo. = True
			Me.oo__.o_. = True
			Me.EncodeCookie = True
			Me.ResponseHeaders = New NameValueCollection()
			Me.O_0_.0O. = CType(WebRequest.Create(A_0), HttpWebRequest)
			Me.O_0_.0O..ServicePoint.Expect100Continue = False
			Me.O0o__._0_0O___. = New Uri(A_0).Host
			Me.Oo_0oO0Oo0_.O_. = A_0
		End Sub

		' Token: 0x060017D2 RID: 6098 RVA: 0x0009A0E1 File Offset: 0x000982E1
		Public Sub Reset()
			Me.O_0_.0O. = CType(WebRequest.Create(Me.Oo_0oO0Oo0_.O_.), HttpWebRequest)
			Me.o0Oo0o.o_O..Clear()
			Me.O0o__._0_0O___. = New Uri(Me.Oo_0oO0Oo0_.O_.).Host
		End Sub

		' Token: 0x17000538 RID: 1336
		' (get) Token: 0x060017D3 RID: 6099 RVA: 0x0009A11A File Offset: 0x0009831A
		<oO0oooo("A0159")>
		Public ReadOnly Property FormData As Dictionary(Of String, String)
			Get
				Return Me.o00__oO.0OO.
			End Get
		End Property

		' Token: 0x17000539 RID: 1337
		' (get) Token: 0x060017D4 RID: 6100 RVA: 0x0009A122 File Offset: 0x00098322
		<oO0oooo("A0158")>
		Public ReadOnly Property SCookies As Dictionary(Of String, String)
			Get
				Return Me.o.__00OOO.
			End Get
		End Property

		' Token: 0x1700053A RID: 1338
		' (get) Token: 0x060017D5 RID: 6101 RVA: 0x0009A12A File Offset: 0x0009832A
		<oO0oooo("A0158")>
		Public ReadOnly Property RCookies As Dictionary(Of String, String)
			Get
				Return Me.o0Oo0o.o_O.
			End Get
		End Property

		' Token: 0x060017D6 RID: 6102 RVA: 0x0009A134 File Offset: 0x00098334
		Friend Function <<EMPTY_NAME>>() As HttpClient
			Dim httpClient As HttpClient = New HttpClient(Me.Oo_0oO0Oo0_.O_.)
			Try
				For Each key As String In Me.o00__oO.0OO..Keys
					httpClient.FormData(key) = Me.o00__oO.0OO.(key)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each key2 As String In Me.o.__00OOO..Keys
					httpClient.SCookies(key2) = Me.o.__00OOO.(key2)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			httpClient.Timeout = Me.Timeout
			httpClient.ReadWriteTimeout = Me.Timeout
			Return httpClient
		End Function

		' Token: 0x060017D7 RID: 6103 RVA: 0x0009A220 File Offset: 0x00098420
		Public Function Clone() As HttpClient
			Dim httpClient As HttpClient = New HttpClient(Me.Oo_0oO0Oo0_.O_.)
			Try
				For Each key As String In Me.o00__oO.0OO..Keys
					httpClient.FormData(key) = Me.o00__oO.0OO.(key)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each key2 As String In Me.o.__00OOO..Keys
					httpClient.SCookies(key2) = Me.o.__00OOO.(key2)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Try
				For Each key3 As String In Me.Files.Keys
					httpClient.Files.Add(key3, Me.o00__oO.0OO.(key3))
				Next
			Finally
				Dim enumerator3 As Dictionary(Of String, List(Of String)).KeyCollection.Enumerator
				CType(enumerator3, IDisposable).Dispose()
			End Try
			Try
				For Each key4 As String In Me.Headers.Keys
					httpClient.Headers.Add(key4, Me.O_O.0o.(key4))
				Next
			Finally
				Dim enumerator4 As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator4, IDisposable).Dispose()
			End Try
			httpClient.Method = Me.Method
			httpClient.Timeout = Me.Timeout
			httpClient.SkipError = Me.SkipError
			httpClient.ReadWriteTimeout = Me.ReadWriteTimeout
			httpClient.Content = Me.Content
			httpClient.ContentType = Me.ContentType
			httpClient.UserAgent = Me.UserAgent
			httpClient.Accept = Me.Accept
			httpClient.RequestEncoding = Me.RequestEncoding
			httpClient.ResponseEncoding = Me.ResponseEncoding
			httpClient.EncodeCookie = Me.EncodeCookie
			Return httpClient
		End Function

		' Token: 0x1700053B RID: 1339
		' (get) Token: 0x060017D8 RID: 6104 RVA: 0x0009A430 File Offset: 0x00098630
		<oO0oooo("A0161")>
		Public ReadOnly Property Files As HttpFilleCollection
			Get
				Return Me.o00__oO.0OO.
			End Get
		End Property

		' Token: 0x1700053C RID: 1340
		' (get) Token: 0x060017D9 RID: 6105 RVA: 0x0009A438 File Offset: 0x00098638
		' (set) Token: 0x060017DA RID: 6106 RVA: 0x0009A440 File Offset: 0x00098640
		Public Property RequestEncoding As String
			Get
				Return Me.oOO0.0oOOOo.
			End Get
			Set(value As String)
				Me.oOO0.0oOOOo. = value
			End Set
		End Property

		' Token: 0x1700053D RID: 1341
		' (get) Token: 0x060017DB RID: 6107 RVA: 0x0009A449 File Offset: 0x00098649
		' (set) Token: 0x060017DC RID: 6108 RVA: 0x0009A451 File Offset: 0x00098651
		Public Property ResponseEncoding As String
			Get
				Return Me.O00_OO0.oooO.
			End Get
			Set(value As String)
				Me.O00_OO0.oooO. = value
			End Set
		End Property

		' Token: 0x1700053E RID: 1342
		' (get) Token: 0x060017DD RID: 6109 RVA: 0x0009A45A File Offset: 0x0009865A
		' (set) Token: 0x060017DE RID: 6110 RVA: 0x0009A462 File Offset: 0x00098662
		Public Property Timeout As Integer
			Get
				Return Me.O_o0.00.
			End Get
			Set(value As Integer)
				Me.O_o0.00. = value
			End Set
		End Property

		' Token: 0x1700053F RID: 1343
		' (get) Token: 0x060017DF RID: 6111 RVA: 0x0009A46B File Offset: 0x0009866B
		' (set) Token: 0x060017E0 RID: 6112 RVA: 0x0009A473 File Offset: 0x00098673
		Public Property UserAgent As String
			Get
				Return Me.ooooO._o_0O__.
			End Get
			Set(value As String)
				Me.ooooO._o_0O__. = value
			End Set
		End Property

		' Token: 0x17000540 RID: 1344
		' (get) Token: 0x060017E1 RID: 6113 RVA: 0x0009A47C File Offset: 0x0009867C
		' (set) Token: 0x060017E2 RID: 6114 RVA: 0x0009A484 File Offset: 0x00098684
		Public Property ReadWriteTimeout As Integer
			Get
				Return Me.oOO0.0oOOOo.
			End Get
			Set(value As Integer)
				Me.oOO0.0oOOOo. = value
			End Set
		End Property

		' Token: 0x17000541 RID: 1345
		' (get) Token: 0x060017E3 RID: 6115 RVA: 0x0009A48D File Offset: 0x0009868D
		' (set) Token: 0x060017E4 RID: 6116 RVA: 0x0009A495 File Offset: 0x00098695
		<oO0oooo("A0165")>
		Public Property Content As String
			Get
				Return Me.O00oo.O___.
			End Get
			Set(value As String)
				Me.O00oo.O___. = value
			End Set
		End Property

		' Token: 0x17000542 RID: 1346
		' (get) Token: 0x060017E5 RID: 6117 RVA: 0x0009A49E File Offset: 0x0009869E
		' (set) Token: 0x060017E6 RID: 6118 RVA: 0x0009A4A6 File Offset: 0x000986A6
		Public Property ContentType As String
			Get
				Return Me.O__oo.0OoooO.
			End Get
			Set(value As String)
				Me.O__oo.0OoooO. = value
			End Set
		End Property

		' Token: 0x17000543 RID: 1347
		' (get) Token: 0x060017E7 RID: 6119 RVA: 0x0009A4AF File Offset: 0x000986AF
		<oO0oooo("A0246")>
		Public ReadOnly Property Headers As Dictionary(Of String, String)
			Get
				Return Me.O_O.0o.
			End Get
		End Property

		' Token: 0x060017E8 RID: 6120 RVA: 0x0009A4B8 File Offset: 0x000986B8
		<oO0oooo("0162")>
		Public Function GetDataTable() As DataTable
			Dim baseDataTable As DataTable = Me.GetBaseDataTable()
			Dim result As DataTable
			If baseDataTable IsNot Nothing Then
				Dim dataTable As DataTable = New DataTable(baseDataTable, Nothing, Nothing, Nothing, Nothing)
				dataTable.o.0O000_.()
				If dataTable.BaseTable.ExtendedProperties.ContainsKey("HttpSelect") Then
					Dim a_ As String = dataTable.BaseTable.ExtendedProperties("HttpSelect").ToString()
					Dim dataTable2 As DataTable = dataTable
					Dim dataTable3 As DataTable = dataTable2
					Dim a_2 As String = dataTable2.LoadFilter
					Dim dataTable4 As DataTable = dataTable
					Dim dataTable5 As DataTable = dataTable4
					Dim a_3 As String = dataTable4.LoadTop
					Dim dataTable6 As DataTable = dataTable
					Dim dataTable7 As DataTable = dataTable
					Dim dataTable8 As DataTable = dataTable
					Dim dataTable9 As DataTable = dataTable8
					Dim a_4 As String = dataTable8.LoadOrder
					Oo00.ooO.ooo.(a_, a_2, a_3, dataTable6.o0_oO00.0oO_., dataTable7.O0o0__o.0000__., a_4)
					dataTable9.LoadOrder = a_4
					dataTable5.LoadTop = a_3
					dataTable3.LoadFilter = a_2
					dataTable.ooO.oO0O0_oo. = False
				End If
				result = dataTable
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060017E9 RID: 6121 RVA: 0x0009A574 File Offset: 0x00098774
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetBaseDataTable() As DataTable
			Dim dataSet As DataSet = Me.oOO.__.()
			Dim result As DataTable
			If dataSet IsNot Nothing AndAlso dataSet.Tables.Count > 0 Then
				Dim dataTable As DataTable = dataSet.Tables(0)
				dataSet.Tables.Remove(dataTable)
				dataSet.Dispose()
				dataTable.AcceptChanges()
				If dataSet.Tables.Count > 0 Then
					Try
						For Each obj As Object In dataSet.Tables(0).Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							If Operators.CompareString(dataRow("Name").ToString(), "UpdateColumns", True) = 0 Then
								Dim collection As String() = dataRow("Value").ToString().Split(New Char() { "|"c })
								Dim list As List(Of String) = New List(Of String)()
								list.AddRange(collection)
								dataTable.ExtendedProperties.Add("UpdateColumns", list)
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				dataSet.Tables.Clear()
				dataSet.Dispose()
				result = dataTable
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060017EA RID: 6122 RVA: 0x0009A6A4 File Offset: 0x000988A4
		Friend Function <<EMPTY_NAME>>() As DataSet
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim stream As Stream = Nothing
			Dim stream2 As Stream = Nothing
			Try
				Me.FormData.ContainsKey("Action")
				Dim dataSet As DataSet = New DataSet()
				If Me.o00__oO.0OO. IsNot Nothing Then
					httpWebResponse = Me.o00__oO.0OO.
				Else
					Me.oo__.o_.()
					httpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
					Me.oOO.__.(httpWebResponse)
				End If
				If Me.RCookies.ContainsKey("Error") Then
					Throw New Exception(Me.RCookies("Error"))
				End If
				stream = httpWebResponse.GetResponseStream()
				stream2 = stream
				If httpWebResponse.Headers("Content-Encoding") IsNot Nothing Then
					If httpWebResponse.Headers("Content-Encoding").Contains("gzip") Then
						stream = New GZipStream(stream, CompressionMode.Decompress, False)
					ElseIf httpWebResponse.Headers("Content-Encoding").Contains("deflate") Then
						stream = New DeflateStream(stream, CompressionMode.Decompress, False)
					End If
				End If
				dataSet.ReadXml(stream)
				dataSet.AcceptChanges()
				Return dataSet
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If Me.O_o0.00. Then
							Return Nothing
						End If
					End If
				End If
				If Not Me.O_o0.00. Then
					ooO.oOo0Oo.o.(ex, "")
				Else
					Me.RCookies("Error") = ex.Message
				End If
			Finally
				If stream IsNot Nothing AndAlso stream IsNot stream2 Then
					stream.Dispose()
				ElseIf stream2 IsNot Nothing Then
					stream2.Dispose()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x060017EB RID: 6123 RVA: 0x0009A898 File Offset: 0x00098A98
		<oO0oooo("A0160")>
		Public Function GetFile(FileName As String) As Boolean
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim stream As Stream = Nothing
			Dim stream2 As Stream = Nothing
			Dim fileStream As FileStream = Nothing
			Try
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
				If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					OO_00oOO.FileSys.CreateDirectory(parentPath)
				End If
				If Me.o00__oO.0OO. IsNot Nothing Then
					httpWebResponse = Me.o00__oO.0OO.
				Else
					Me.oo__.o_.()
					httpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
					Me.oOO.__.(httpWebResponse)
				End If
				If Me.RCookies.ContainsKey("Error") Then
					Throw New Exception(Me.RCookies("Error"))
				End If
				If Me.RCookies.ContainsKey("IsNull") Then
					Return False
				End If
				stream = httpWebResponse.GetResponseStream()
				stream2 = stream
				If httpWebResponse.Headers("Content-Encoding") IsNot Nothing Then
					If httpWebResponse.Headers("Content-Encoding").Contains("gzip") Then
						stream = New GZipStream(stream, CompressionMode.Decompress, False)
					ElseIf httpWebResponse.Headers("Content-Encoding").Contains("deflate") Then
						stream = New DeflateStream(stream, CompressionMode.Decompress, False)
					End If
				End If
				Dim array As Byte() = New Byte(512) {}
				Dim i As Integer = stream.Read(array, 0, array.Length)
				fileStream = New FileStream(FileName, FileMode.Create)
				While i > 0
					fileStream.Write(array, 0, i)
					i = stream.Read(array, 0, array.Length)
				End While
				Return True
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If Me.O_o0.00. Then
							Return False
						End If
					End If
				End If
				If Not Me.O_o0.00. Then
					ooO.oOo0Oo.o.(ex, "")
				Else
					Me.RCookies("Error") = ex.Message
				End If
			Finally
				If stream IsNot Nothing AndAlso stream IsNot stream2 Then
					stream.Dispose()
				ElseIf stream2 IsNot Nothing Then
					stream2.Dispose()
				End If
				If fileStream IsNot Nothing Then
					fileStream.Dispose()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
			End Try
			Return False
		End Function

		' Token: 0x060017EC RID: 6124 RVA: 0x0009AB00 File Offset: 0x00098D00
		Public Function GetFileAsync(FileName As String) As Task(Of Boolean)
			Dim o__oOoo0Oo0_O As HttpClient.O__oOoo0Oo0_O = Nothing
			o__oOoo0Oo0_O.O_.ooO_00o0. = Me
			o__oOoo0Oo0_O.O_.ooO_00o0. = FileName
			o__oOoo0Oo0_O.O_.ooO_00o0. = -1
			o__oOoo0Oo0_O.O_.ooO_00o0. = AsyncTaskMethodBuilder(Of Boolean).Create()
			o__oOoo0Oo0_O.O_.ooO_00o0..Start(Of HttpClient.O__oOoo0Oo0_O)(o__oOoo0Oo0_O)
			Return o__oOoo0Oo0_O.O_.ooO_00o0..Task
		End Function

		' Token: 0x060017ED RID: 6125 RVA: 0x0009AB54 File Offset: 0x00098D54
		Public Function GetDataAsync() As Task(Of String)
			Dim oo____o As HttpClient.oo____o = Nothing
			oo____o.OO00OOo.o0_. = Me
			oo____o.O_.ooO_00o0. = -1
			oo____o.O_.ooO_00o0. = AsyncTaskMethodBuilder(Of String).Create()
			oo____o.O_.ooO_00o0..Start(Of HttpClient.oo____o)(oo____o)
			Return oo____o.O_.ooO_00o0..Task
		End Function

		' Token: 0x060017EE RID: 6126 RVA: 0x0009ABA0 File Offset: 0x00098DA0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetMemStream(mem As MemoryStream) As Boolean
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim stream As Stream = Nothing
			Dim stream2 As Stream = Nothing
			Try
				If Me.o00__oO.0OO. IsNot Nothing Then
					httpWebResponse = Me.o00__oO.0OO.
				Else
					Me.oo__.o_.()
					httpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
					Me.oOO.__.(httpWebResponse)
				End If
				If Me.RCookies.ContainsKey("Error") Then
					Throw New Exception(Me.RCookies("Error"))
				End If
				stream = httpWebResponse.GetResponseStream()
				stream2 = stream
				Dim array As Byte() = New Byte(512) {}
				Dim i As Integer = stream.Read(array, 0, array.Length)
				If i = 0 Then
					stream.Close()
					Return False
				End If
				While i > 0
					mem.Write(array, 0, i)
					i = stream.Read(array, 0, array.Length)
				End While
				Return True
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If Me.O_o0.00. Then
							Return False
						End If
					End If
				End If
				If Not Me.O_o0.00. Then
					ooO.oOo0Oo.o.(ex, "")
				Else
					Me.RCookies("Error") = ex.Message
				End If
			Finally
				If stream IsNot Nothing AndAlso stream IsNot stream2 Then
					stream.Dispose()
				ElseIf stream2 IsNot Nothing Then
					stream2.Dispose()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
			End Try
			Return False
		End Function

		' Token: 0x060017EF RID: 6127 RVA: 0x0009AD5C File Offset: 0x00098F5C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetMediaFile(path As String, Optional NewName As String = Nothing) As String
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim stream As Stream = Nothing
			Dim stream2 As Stream = Nothing
			Dim stream3 As Stream = Nothing
			Try
				Dim text As String = path
				If Not OO_00oOO.FileSys.DirectoryExists(path) Then
					OO_00oOO.FileSys.CreateDirectory(path)
				End If
				If Me.o00__oO.0OO. IsNot Nothing Then
					httpWebResponse = Me.o00__oO.0OO.
				Else
					Me.oo__.o_.()
					httpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
					Me.oOO.__.(httpWebResponse)
				End If
				If Me.RCookies.ContainsKey("Error") Then
					Throw New Exception(Me.RCookies("Error"))
				End If
				Dim text2 As String = httpWebResponse.Headers("Content-disposition")
				Dim flag As Boolean
				If NewName IsNot Nothing Then
					If text2 IsNot Nothing AndAlso text2.ToLower().IndexOf("filename=") >= 0 Then
						text = Path.Combine(text, NewName)
						flag = True
					End If
				ElseIf text2 IsNot Nothing Then
					For Each text2 As String In text2.Split(New Char() { ";"c })
						text2 = text2.Trim()
						If text2.StartsWith("filename=") Then
							text2 = text2.Split(New Char() { "="c })(1).Trim(New Char() { """"c })
							text = Path.Combine(text, text2)
							flag = True
						End If
					Next
				End If
				stream = httpWebResponse.GetResponseStream()
				stream2 = stream
				If httpWebResponse.Headers("Content-Encoding") IsNot Nothing Then
					If httpWebResponse.Headers("Content-Encoding").Contains("gzip") Then
						stream = New GZipStream(stream, CompressionMode.Decompress, False)
					ElseIf httpWebResponse.Headers("Content-Encoding").Contains("deflate") Then
						stream = New DeflateStream(stream, CompressionMode.Decompress, False)
					End If
				End If
				Dim array2 As Byte() = New Byte(512) {}
				Dim j As Integer = stream.Read(array2, 0, array2.Length)
				If j = 0 Then
					stream.Close()
					Return ""
				End If
				If flag Then
					stream3 = New FileStream(text, FileMode.Create)
				Else
					stream3 = New MemoryStream()
				End If
				While j > 0
					stream3.Write(array2, 0, j)
					j = stream.Read(array2, 0, array2.Length)
				End While
				If Not flag Then
					text = Encoding.GetEncoding(Me.O00_OO0.oooO.).GetString(CType(stream3, MemoryStream).ToArray())
				End If
				If stream IsNot httpWebResponse.GetResponseStream() Then
					httpWebResponse.GetResponseStream().Close()
				End If
				Return text
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If Me.O_o0.00. Then
							Return ""
						End If
					End If
				End If
				If Not Me.O_o0.00. Then
					ooO.oOo0Oo.o.(ex, "")
				Else
					Me.RCookies("Error") = ex.Message
				End If
			Finally
				If stream IsNot Nothing AndAlso stream IsNot stream2 Then
					stream.Dispose()
				ElseIf stream2 IsNot Nothing Then
					stream2.Dispose()
				End If
				If stream3 IsNot Nothing Then
					stream3.Dispose()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
			End Try
			Return ""
		End Function

		' Token: 0x060017F0 RID: 6128 RVA: 0x0009B0BC File Offset: 0x000992BC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetData(SkipErr As Boolean) As String
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim stream As Stream = Nothing
			Dim stream2 As Stream = Nothing
			Dim memoryStream As MemoryStream = Nothing
			Try
				Dim encoding As Encoding = Encoding.GetEncoding(Me.O00_OO0.oooO.)
				If Me.o00__oO.0OO. IsNot Nothing Then
					httpWebResponse = Me.o00__oO.0OO.
				Else
					Me.oo__.o_.()
					httpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
					Me.oOO.__.(httpWebResponse)
				End If
				If Me.RCookies.ContainsKey("Error") Then
					Throw New Exception(Me.RCookies("Error"))
				End If
				memoryStream = New MemoryStream()
				stream = httpWebResponse.GetResponseStream()
				stream2 = stream
				Dim array As Byte() = New Byte(512) {}
				If httpWebResponse.Headers("Content-Encoding") IsNot Nothing Then
					If httpWebResponse.Headers("Content-Encoding").Contains("gzip") Then
						stream = New GZipStream(stream, CompressionMode.Decompress, False)
					ElseIf httpWebResponse.Headers("Content-Encoding").Contains("deflate") Then
						stream = New DeflateStream(stream, CompressionMode.Decompress, False)
					End If
				End If
				For i As Integer = stream.Read(array, 0, array.Length)To 0 + 1
					memoryStream.Write(array, 0, i)
				Next
				Dim flag As Boolean
				If memoryStream.Length >= 3L Then
					memoryStream.Position = 0L
					If memoryStream.Read(array, 0, 3) = 3 AndAlso array(0) = 239 AndAlso array(1) = 187 AndAlso array(2) = 191 Then
						flag = True
					End If
				End If
				Dim [string] As String
				If flag Then
					[string] = Encoding.UTF8.GetString(memoryStream.ToArray(), 3, CInt((memoryStream.Length - 3L)))
				Else
					[string] = encoding.GetString(memoryStream.ToArray())
				End If
				Return [string]
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If SkipErr OrElse Me.O_o0.00. Then
							Return ""
						End If
					End If
				End If
				If SkipErr OrElse Me.O_o0.00. Then
					Me.RCookies("Error") = ex.Message
				Else
					ooO.oOo0Oo.o.(ex, "")
				End If
			Finally
				If stream IsNot Nothing AndAlso stream IsNot stream2 Then
					stream.Dispose()
				ElseIf stream2 IsNot Nothing Then
					stream2.Dispose()
				End If
				If memoryStream IsNot Nothing Then
					memoryStream.Dispose()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
			End Try
			Return ""
		End Function

		' Token: 0x060017F1 RID: 6129 RVA: 0x0009B374 File Offset: 0x00099574
		<oO0oooo("A0294")>
		Public Function GetData() As String
			Return Me.GetData(False)
		End Function

		' Token: 0x060017F2 RID: 6130 RVA: 0x0009B380 File Offset: 0x00099580
		Public Function ReadOpenAiSseAsync(Optional chunkHandler As Action(Of String, String) = Nothing, Optional SSECancellation As CancellationTokenSource = Nothing) As Task(Of JObject)
			Dim ooOOO_000_O0o As HttpClient.OoOOO_000_O0o = Nothing
			ooOOO_000_O0o.OO00OOo.o0_. = Me
			ooOOO_000_O0o.OO00OOo.o0_. = chunkHandler
			ooOOO_000_O0o.OO00OOo.o0_. = SSECancellation
			ooOOO_000_O0o.OO00OOo.o0_. = -1
			ooOOO_000_O0o.OO00OOo.o0_. = AsyncTaskMethodBuilder(Of JObject).Create()
			ooOOO_000_O0o.OO00OOo.o0_..Start(Of HttpClient.OoOOO_000_O0o)(ooOOO_000_O0o)
			Return ooOOO_000_O0o.OO00OOo.o0_..Task
		End Function

		' Token: 0x060017F3 RID: 6131 RVA: 0x0009B3DC File Offset: 0x000995DC
		Public Function ReadOpenAiSseAsync(Optional chunkHandler As Action(Of String, String) = Nothing) As Task(Of JObject)
			Dim oo00OO_O0_o_ As HttpClient.oo00OO_O0_o_ = Nothing
			oo00OO_O0_o_.O__.o0o. = Me
			oo00OO_O0_o_.O__.o0o. = chunkHandler
			oo00OO_O0_o_.O__.o0o. = -1
			oo00OO_O0_o_.O__.o0o. = AsyncTaskMethodBuilder(Of JObject).Create()
			oo00OO_O0_o_.O__.o0o..Start(Of HttpClient.oo00OO_O0_o_)(oo00OO_O0_o_)
			Return oo00OO_O0_o_.O__.o0o..Task
		End Function

		' Token: 0x060017F4 RID: 6132 RVA: 0x0009B430 File Offset: 0x00099630
		Private Sub <<EMPTY_NAME>>(A_0 As Action(Of String, String), A_1 As String, A_2 As String)
			Dim oo0OO As HttpClient.oo0OO = New HttpClient.oo0OO()
			oo0OO.Oo_O_o0__._0_. = A_0
			oo0OO.Oo_O_o0__._0_. = A_1
			oo0OO.o_O_ooO.0OO. = A_2
			If oo0OO.Oo_O_o0__._0_. IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oo0OO.Oo_O_o0__._0_.)
			End If
		End Sub

		' Token: 0x060017F5 RID: 6133 RVA: 0x0009B478 File Offset: 0x00099678
		Private Function <<EMPTY_NAME>>(A_0 As Action(Of String, String)) As Task(Of JObject)
			Dim oooO_ As HttpClient.oooO_ = Nothing
			oooO_.OOO._OO__0OO. = Me
			oooO_.OOO._OO__0OO. = A_0
			oooO_.OOO._OO__0OO. = -1
			oooO_.O__.o0o. = AsyncTaskMethodBuilder(Of JObject).Create()
			oooO_.O__.o0o..Start(Of HttpClient.oooO_)(oooO_)
			Return oooO_.O__.o0o..Task
		End Function

		' Token: 0x060017F6 RID: 6134 RVA: 0x0009B4CC File Offset: 0x000996CC
		Private Sub <<EMPTY_NAME>>(A_0 As HttpWebResponse)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator = A_0.Cookies.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cookie As Cookie = CType(obj, Cookie)
					IL_24:
					num2 = 3
					Me.RCookies.Add(OO_00oOO.O_0.0O__O0.(cookie.Name), OO_00oOO.O_0.0O__O0.(cookie.Value))
					IL_49:
					num2 = 4
				End While
				IL_53:
				num2 = 5
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_68:
				num2 = 6
				Me.LastModified = A_0.LastModified
				IL_76:
				num2 = 7
				Me.ResponseContentType = A_0.ContentType
				IL_84:
				num2 = 8
				Me.ResponseContentLength = A_0.ContentLength
				IL_92:
				num2 = 9
				Me.StatusCode = CInt(A_0.StatusCode)
				IL_A1:
				num2 = 10
				Me.StatusDescription = A_0.StatusDescription
				IL_B0:
				num2 = 11
				Dim num3 As Integer = A_0.Headers.Count - 1
				For i As Integer = 0 To num3
					IL_C7:
					num2 = 12
					Me.ResponseHeaders.Add(A_0.Headers.Keys(i), A_0.Headers(i))
					IL_F4:
					num2 = 13
				Next
				IL_103:
				GoTo IL_18D
				IL_108:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_14E:
				GoTo IL_182
				IL_150:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_160:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_150
			End Try
			IL_182:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_18D:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000544 RID: 1348
		' (set) Token: 0x060017F7 RID: 6135 RVA: 0x0009B68C File Offset: 0x0009988C
		Friend WriteOnly Property [Select] As String
			Set(value As String)
				Me.FormData("Select") = O00.ooo000o_0.00o0.(value, "fox", "table")
			End Set
		End Property

		' Token: 0x060017F8 RID: 6136 RVA: 0x0009B6B0 File Offset: 0x000998B0
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.Files.Count <= 0 Then
					GoTo IL_24
				End If
				IL_17:
				num2 = 3
				Me.O0o__._0_0O___.()
				GoTo IL_3D8
				IL_24:
				num2 = 5
				Dim text As String = ""
				IL_2C:
				num2 = 6
				Dim encoding As Encoding = Encoding.GetEncoding(Me.oOO0.0oOOOo.)
				IL_3B:
				num2 = 7
				If Me.Timeout <= 0 Then
					GoTo IL_5F
				End If
				IL_46:
				num2 = 8
				Me.O_0_.0O..Timeout = Me.Timeout * 1000
				IL_5F:
				num2 = 9
				If Me.ReadWriteTimeout <= 0 Then
					GoTo IL_85
				End If
				IL_6B:
				num2 = 10
				Me.O_0_.0O..ReadWriteTimeout = Me.ReadWriteTimeout * 1000
				IL_85:
				num2 = 11
				Dim cookieContainer As CookieContainer = New CookieContainer()
				IL_8F:
				num2 = 12
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Me.o.__00OOO..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text2 As String = enumerator.Current
					IL_AF:
					num2 = 13
					Dim cookie As Cookie
					If Me.EncodeCookie Then
						IL_BA:
						num2 = 14
						cookie = New Cookie(OO_00oOO.o_.0_OoOo0_0.(text2), OO_00oOO.o_.0_OoOo0_0.(Me.o.__00OOO.(text2)))
					Else
						IL_DF:
						num2 = 16
						cookie = New Cookie(OO_00oOO.o_.0_OoOo0_0.(text2), Me.o.__00OOO.(text2))
					End If
					IL_FD:
					num2 = 17
					cookie.Domain = Me.O0o__._0_0O___.
					IL_10D:
					num2 = 18
					cookieContainer.Add(cookie)
					IL_119:
					num2 = 19
				End While
				IL_125:
				num2 = 20
				CType(enumerator, IDisposable).Dispose()
				IL_135:
				num2 = 21
				Me.O_0_.0O..CookieContainer = cookieContainer
				IL_145:
				num2 = 22
				If Operators.CompareString(Me.Method, "", True) <= 0 Then
					GoTo IL_1C8
				End If
				IL_15C:
				num2 = 23
				Me.O_0_.0O..Method = Me.Method
				IL_170:
				num2 = 24
				If Operators.CompareString(Me.ContentType, "", True) <= 0 Then
					GoTo IL_19B
				End If
				IL_187:
				num2 = 25
				Me.O_0_.0O..ContentType = Me.ContentType
				IL_19B:
				num2 = 26
				If Operators.CompareString(Me.O_0_.0O..Method, "post", True) <> 0 Then
					GoTo IL_321
				End If
				IL_1B9:
				num2 = 27
				text = Me.Content
				GoTo IL_321
				IL_1C8:
				num2 = 29
				If Me.o00__oO.0OO..Count <= 0 Then
					GoTo IL_2A2
				End If
				IL_1DC:
				num2 = 30
				Me.O_0_.0O..Method = "post"
				IL_1EF:
				num2 = 31
				Me.O_0_.0O..ContentType = "application/x-www-form-urlencoded; charset=" + Me.oOO0.0oOOOo.
				IL_20D:
				num2 = 32
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator = Me.o00__oO.0OO..Keys.GetEnumerator()
				While enumerator2.MoveNext()
					Dim text3 As String = enumerator2.Current
					IL_22D:
					num2 = 33
					text = String.Concat(New String() { text, OO_00oOO.o_.0_OoOo0_0.(text3), "=", OO_00oOO.o_.0_OoOo0_0.(Me.o00__oO.0OO.(text3)), "&" })
					IL_26F:
					num2 = 34
				End While
				IL_27B:
				num2 = 35
				CType(enumerator2, IDisposable).Dispose()
				IL_28B:
				num2 = 36
				text = text.Trim(New Char() { "&"c })
				GoTo IL_321
				IL_2A2:
				num2 = 38
				If Operators.CompareString(Me.Content, "", True) <= 0 Then
					GoTo IL_321
				End If
				IL_2B9:
				num2 = 39
				Me.O_0_.0O..Method = "post"
				IL_2CC:
				num2 = 40
				If Operators.CompareString(Me.ContentType, "", True) <= 0 Then
					GoTo IL_2F9
				End If
				IL_2E3:
				num2 = 41
				Me.O_0_.0O..ContentType = Me.ContentType
				GoTo IL_317
				IL_2F9:
				num2 = 43
				Me.O_0_.0O..ContentType = "text/plain; charset=" + Me.oOO0.0oOOOo.
				IL_317:
				num2 = 44
				text = Me.Content
				IL_321:
				num2 = 45
				Me.O.__oOOoO0oo.()
				IL_32A:
				num2 = 46
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_3D8
				End If
				IL_33F:
				num2 = 47
				Dim memoryStream As MemoryStream = New MemoryStream(encoding.GetBytes(text))
				IL_351:
				num2 = 48
				Dim array As Byte() = New Byte(51200) {}
				IL_360:
				num2 = 49
				Me.O_0_.0O..ContentLength = memoryStream.Length
				IL_375:
				num2 = 50
				Dim requestStream As Stream = Me.O_0_.0O..GetRequestStream()
				IL_385:
				num2 = 51
				Dim num3 As Integer = memoryStream.Read(array, 0, array.Length)
				While True
					IL_3BC:
					num2 = 53
					If num3 <= 0 Then
						Exit For
					End If
					IL_39A:
					num2 = 54
					requestStream.Write(array, 0, num3)
					IL_3A9:
					num2 = 55
					num3 = memoryStream.Read(array, 0, array.Length)
				End While
				IL_3C4:
				num2 = 57
				requestStream.Close()
				IL_3CE:
				num2 = 58
				memoryStream.Dispose()
				IL_3D8:
				GoTo IL_516
				IL_3DD:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_4D7:
				GoTo IL_50B
				IL_4D9:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4E9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4D9
			End Try
			IL_50B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_516:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060017F9 RID: 6137 RVA: 0x0009BBF8 File Offset: 0x00099DF8
		Private Sub <<EMPTY_NAME>>()
			If Me.Headers.Count > 0 Then
				Try
					For Each text As String In Me.Headers.Keys
						Dim left As String = text
						If Operators.CompareString(left, "Accept", True) = 0 Then
							Me.O_0_.0O..Accept = Me.Headers(text)
						ElseIf Operators.CompareString(left, "Expect", True) = 0 Then
							Me.O_0_.0O..Expect = Me.Headers(text)
						ElseIf Operators.CompareString(left, "UserAgent", True) = 0 Then
							Me.O_0_.0O..UserAgent = Me.Headers(text)
						ElseIf Operators.CompareString(left, "ContentType", True) = 0 Then
							Me.O_0_.0O..ContentType = Me.Headers(text)
						ElseIf Operators.CompareString(left, "TransferEncoding", True) = 0 Then
							Me.O_0_.0O..TransferEncoding = Me.Headers(text)
						ElseIf Operators.CompareString(left, "Connection", True) = 0 Then
							Me.O_0_.0O..Connection = Me.Headers(text)
						ElseIf Operators.CompareString(left, "IfModifiedSince", True) = 0 Then
							Dim ifModifiedSince As DateTime
							If DateTime.TryParse(Me.Headers(text), ifModifiedSince) Then
								Me.O_0_.0O..IfModifiedSince = ifModifiedSince
							End If
						ElseIf Operators.CompareString(left, "Referer", True) = 0 Then
							Me.O_0_.0O..Referer = Me.Headers(text)
						Else
							Me.O_0_.0O..Headers.Add(text, Me.Headers(text))
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			If Not String.IsNullOrEmpty(Me.UserAgent) Then
				Me.O_0_.0O..UserAgent = Me.UserAgent
			End If
			If Not String.IsNullOrEmpty(Me.Accept) Then
				Me.O_0_.0O..Accept = Me.Accept
			End If
			If Me.gzip Then
				Me.O_0_.0O..Headers.Add("Accept-Encoding", "gzip")
			End If
			If Me.deflate Then
				Me.O_0_.0O..Headers.Add("Accept-Encoding", "deflate")
			End If
		End Sub

		' Token: 0x060017FA RID: 6138 RVA: 0x0009BE5C File Offset: 0x0009A05C
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				IL_09:
				num2 = 3
				Dim encoding As Encoding = Encoding.GetEncoding(Me.oOO0.0oOOOo.)
				IL_17:
				num2 = 4
				Me.O_0_.0O..Headers.Add("charset", Me.oOO0.0oOOOo.)
				IL_34:
				num2 = 5
				If Me.Timeout <= 0 Then
					GoTo IL_58
				End If
				IL_3F:
				num2 = 6
				Me.O_0_.0O..Timeout = Me.Timeout * 1000
				IL_58:
				num2 = 7
				If Me.ReadWriteTimeout <= 0 Then
					GoTo IL_7C
				End If
				IL_63:
				num2 = 8
				Me.O_0_.0O..ReadWriteTimeout = Me.ReadWriteTimeout * 1000
				IL_7C:
				num2 = 9
				Dim cookieContainer As CookieContainer = New CookieContainer()
				IL_86:
				num2 = 10
				If Me.o.__00OOO..Count <= 0 Then
					GoTo IL_140
				End If
				IL_9A:
				num2 = 11
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Me.o.__00OOO..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_BA:
					num2 = 12
					Dim cookie As Cookie
					If Me.EncodeCookie Then
						IL_C5:
						num2 = 13
						cookie = New Cookie(OO_00oOO.o_.0_OoOo0_0.(text), OO_00oOO.o_.0_OoOo0_0.(Me.o.__00OOO.(text)))
					Else
						IL_EA:
						num2 = 15
						cookie = New Cookie(OO_00oOO.o_.0_OoOo0_0.(text), Me.o.__00OOO.(text))
					End If
					IL_108:
					num2 = 16
					cookie.Domain = Me.O0o__._0_0O___.
					IL_118:
					num2 = 17
					cookieContainer.Add(cookie)
					IL_124:
					num2 = 18
				End While
				IL_130:
				num2 = 19
				CType(enumerator, IDisposable).Dispose()
				IL_140:
				num2 = 20
				Me.O_0_.0O..CookieContainer = cookieContainer
				IL_150:
				num2 = 21
				Me.O.__oOOoO0oo.()
				IL_159:
				num2 = 22
				Dim str As String = "----" + OoOo0O.OO_o.0o_O.(34)
				IL_16F:
				num2 = 23
				Me.O_0_.0O..ContentType = "multipart/form-data; boundary=" + str
				IL_189:
				num2 = 24
				Me.O_0_.0O..Method = "post"
				IL_19C:
				num2 = 25
				Dim requestStream As Stream = Me.O_0_.0O..GetRequestStream()
				IL_1AC:
				num2 = 26
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_1B6:
				num2 = 27
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator = Me.o00__oO.0OO..Keys.GetEnumerator()
				While enumerator2.MoveNext()
					Dim text2 As String = enumerator2.Current
					IL_1D6:
					num2 = 28
					stringBuilder.AppendLine("--" + str)
					IL_1ED:
					num2 = 29
					stringBuilder.AppendLine("Content-Disposition: form-data; name=""" + text2 + """")
					IL_209:
					num2 = 30
					stringBuilder.AppendLine()
					IL_214:
					num2 = 31
					stringBuilder.AppendLine(Me.o00__oO.0OO.(text2))
					IL_22C:
					num2 = 32
				End While
				IL_238:
				num2 = 33
				CType(enumerator2, IDisposable).Dispose()
				IL_248:
				num2 = 34
				Dim bytes As Byte() = encoding.GetBytes(stringBuilder.ToString())
				IL_25A:
				num2 = 35
				requestStream.Write(bytes, 0, bytes.Length)
				IL_26B:
				num2 = 36
				Dim enumerator3 As Dictionary(Of String, List(Of String)).KeyCollection.Enumerator = Me.Files.Keys.GetEnumerator()
				While enumerator3.MoveNext()
					Dim text3 As String = enumerator3.Current
					IL_28E:
					num2 = 37
					Dim enumerator4 As List(Of String).Enumerator = Me.Files(text3).GetEnumerator()
					While enumerator4.MoveNext()
						Dim path As String = enumerator4.Current
						IL_2B3:
						num2 = 38
						stringBuilder = New StringBuilder()
						IL_2BD:
						num2 = 39
						stringBuilder.AppendLine("--" + str)
						IL_2D4:
						num2 = 40
						stringBuilder.AppendLine(String.Concat(New String() { "Content-Disposition: form-data; name=""", text3, """; filename=""", OO_00oOO.FileSys.GetName(path), """" }))
						IL_316:
						num2 = 41
						stringBuilder.AppendLine("Content-Type: application/octet-stream")
						IL_326:
						num2 = 42
						stringBuilder.AppendLine()
						IL_331:
						num2 = 43
						bytes = encoding.GetBytes(stringBuilder.ToString())
						IL_343:
						num2 = 44
						requestStream.Write(bytes, 0, bytes.Length)
						IL_354:
						num2 = 45
						Dim fileStream As FileStream = New FileStream(path, FileMode.Open)
						IL_361:
						num2 = 46
						Dim array As Byte() = New Byte(51200) {}
						IL_370:
						num2 = 47
						Dim num3 As Integer = fileStream.Read(array, 0, array.Length)
						While True
							IL_3A7:
							num2 = 49
							If num3 <= 0 Then
								Exit For
							End If
							IL_385:
							num2 = 50
							requestStream.Write(array, 0, num3)
							IL_394:
							num2 = 51
							num3 = fileStream.Read(array, 0, array.Length)
						End While
						IL_3AF:
						num2 = 53
						fileStream.Close()
						IL_3B9:
						num2 = 54
						bytes = encoding.GetBytes(vbCrLf)
						IL_3C9:
						num2 = 55
						requestStream.Write(bytes, 0, bytes.Length)
						IL_3DA:
						num2 = 56
					End While
					IL_3E9:
					num2 = 57
					CType(enumerator4, IDisposable).Dispose()
					IL_3F9:
					num2 = 58
				End While
				IL_408:
				num2 = 59
				CType(enumerator3, IDisposable).Dispose()
				IL_418:
				num2 = 60
				bytes = encoding.GetBytes("--" + str + "--" & vbCrLf)
				IL_434:
				num2 = 61
				requestStream.Write(bytes, 0, bytes.Length)
				IL_445:
				num2 = 62
				requestStream.Close()
				IL_44F:
				GoTo IL_59D
				IL_454:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_55E:
				GoTo IL_592
				IL_560:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_570:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_560
			End Try
			IL_592:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_59D:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000545 RID: 1349
		' (get) Token: 0x060017FB RID: 6139 RVA: 0x0009C42C File Offset: 0x0009A62C
		' (set) Token: 0x060017FC RID: 6140 RVA: 0x0009C434 File Offset: 0x0009A634
		Public Property LastModified As DateTime

		' Token: 0x17000546 RID: 1350
		' (get) Token: 0x060017FD RID: 6141 RVA: 0x0009C43D File Offset: 0x0009A63D
		' (set) Token: 0x060017FE RID: 6142 RVA: 0x0009C445 File Offset: 0x0009A645
		Public Property StatusCode As Integer

		' Token: 0x17000547 RID: 1351
		' (get) Token: 0x060017FF RID: 6143 RVA: 0x0009C44E File Offset: 0x0009A64E
		' (set) Token: 0x06001800 RID: 6144 RVA: 0x0009C456 File Offset: 0x0009A656
		Public Property StatusDescription As String

		' Token: 0x17000548 RID: 1352
		' (get) Token: 0x06001801 RID: 6145 RVA: 0x0009C45F File Offset: 0x0009A65F
		' (set) Token: 0x06001802 RID: 6146 RVA: 0x0009C467 File Offset: 0x0009A667
		Public Property ResponseContentType As String

		' Token: 0x17000549 RID: 1353
		' (get) Token: 0x06001803 RID: 6147 RVA: 0x0009C470 File Offset: 0x0009A670
		' (set) Token: 0x06001804 RID: 6148 RVA: 0x0009C478 File Offset: 0x0009A678
		Public Property ResponseContentLength As Long

		' Token: 0x1700054A RID: 1354
		' (get) Token: 0x06001805 RID: 6149 RVA: 0x0009C481 File Offset: 0x0009A681
		' (set) Token: 0x06001806 RID: 6150 RVA: 0x0009C489 File Offset: 0x0009A689
		Public Property ResponseHeaders As NameValueCollection

		' Token: 0x06001807 RID: 6151 RVA: 0x0009C494 File Offset: 0x0009A694
		<oO0oooo("A3278")>
		Public Function GetInformation() As Boolean
			Try
				Me.oo__.o_.()
				Dim a_ As HttpWebResponse = CType(Me.O_0_.0O..GetResponse(), HttpWebResponse)
				Me.oOO.__.(a_)
				Me.o00__oO.0OO. = a_
				Return True
			Catch ex As Exception
				If TypeOf ex Is WebException Then
					Dim ex2 As WebException = CType(ex, WebException)
					If TypeOf ex2.Response Is HttpWebResponse Then
						Me.StatusCode = CInt(CType(ex2.Response, HttpWebResponse).StatusCode)
						Me.StatusDescription = CType(ex2.Response, HttpWebResponse).StatusDescription
						If Me.O_o0.00. Then
							Return False
						End If
					End If
				End If
				If Not Me.O_o0.00. Then
					ooO.oOo0Oo.o.(ex, "")
				Else
					Me.RCookies("Error") = ex.Message
				End If
			End Try
			Return False
		End Function

		' Token: 0x06001808 RID: 6152 RVA: 0x0009C574 File Offset: 0x0009A774
		Public Sub Close()
			If Me.o00__oO.0OO. IsNot Nothing Then
				Me.o00__oO.0OO..Close()
			End If
		End Sub

		' Token: 0x1700054B RID: 1355
		' (get) Token: 0x06001809 RID: 6153 RVA: 0x0009C589 File Offset: 0x0009A789
		' (set) Token: 0x0600180A RID: 6154 RVA: 0x0009C591 File Offset: 0x0009A791
		Public Property Accept As String
			Get
				Return Me.O_O__ooOO_._O.
			End Get
			Set(value As String)
				Me.O_O__ooOO_._O. = value
			End Set
		End Property

		' Token: 0x1700054C RID: 1356
		' (get) Token: 0x0600180B RID: 6155 RVA: 0x0009C59A File Offset: 0x0009A79A
		' (set) Token: 0x0600180C RID: 6156 RVA: 0x0009C5A2 File Offset: 0x0009A7A2
		<oO0oooo("A0294")>
		Public Property SkipError As Boolean
			Get
				Return Me.O_o0.00.
			End Get
			Set(value As Boolean)
				Me.O_o0.00. = value
			End Set
		End Property

		' Token: 0x1700054D RID: 1357
		' (get) Token: 0x0600180D RID: 6157 RVA: 0x0009C5AB File Offset: 0x0009A7AB
		' (set) Token: 0x0600180E RID: 6158 RVA: 0x0009C5B3 File Offset: 0x0009A7B3
		Public Property Method As String
			Get
				Return Me.oOo0_.O_O0.
			End Get
			Set(value As String)
				Me.oOo0_.O_O0. = value
			End Set
		End Property

		' Token: 0x1700054E RID: 1358
		' (get) Token: 0x0600180F RID: 6159 RVA: 0x0009C5BC File Offset: 0x0009A7BC
		' (set) Token: 0x06001810 RID: 6160 RVA: 0x0009C5C4 File Offset: 0x0009A7C4
		Public Property gzip As Boolean
			Get
				Return Me.oOO0.0oOOOo.
			End Get
			Set(value As Boolean)
				Me.oOO0.0oOOOo. = value
			End Set
		End Property

		' Token: 0x1700054F RID: 1359
		' (get) Token: 0x06001811 RID: 6161 RVA: 0x0009C5CD File Offset: 0x0009A7CD
		' (set) Token: 0x06001812 RID: 6162 RVA: 0x0009C5D5 File Offset: 0x0009A7D5
		Public Property deflate As Boolean
			Get
				Return Me.oo__.o_.
			End Get
			Set(value As Boolean)
				Me.oo__.o_. = True
			End Set
		End Property

		' Token: 0x17000550 RID: 1360
		' (get) Token: 0x06001813 RID: 6163 RVA: 0x0009C5DE File Offset: 0x0009A7DE
		' (set) Token: 0x06001814 RID: 6164 RVA: 0x0009C5EB File Offset: 0x0009A7EB
		Public Property Referer As String
			Get
				Return Me.O_0_.0O..Referer
			End Get
			Set(value As String)
				Me.O_0_.0O..Referer = value
			End Set
		End Property

		' Token: 0x06001815 RID: 6165 RVA: 0x0009C5F9 File Offset: 0x0009A7F9
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As String
			Return Me.GetData()
		End Function

		' Token: 0x04000995 RID: 2453
		Private <<EMPTY_NAME>> As HttpWebRequest

		' Token: 0x04000996 RID: 2454
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000997 RID: 2455
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000998 RID: 2456
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000999 RID: 2457
		Private <<EMPTY_NAME>> As HttpFilleCollection

		' Token: 0x0400099A RID: 2458
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400099B RID: 2459
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400099C RID: 2460
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400099D RID: 2461
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400099E RID: 2462
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400099F RID: 2463
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009A0 RID: 2464
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009A1 RID: 2465
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040009A2 RID: 2466
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009A3 RID: 2467
		Private <<EMPTY_NAME>> As HttpWebResponse

		' Token: 0x040009A4 RID: 2468
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009A5 RID: 2469
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040009A6 RID: 2470
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009A7 RID: 2471
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040009A8 RID: 2472
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040009A9 RID: 2473
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040009AA RID: 2474
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040009AB RID: 2475
		Private <<EMPTY_NAME>> As CancellationTokenSource

		' Token: 0x040009AC RID: 2476
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040009AD RID: 2477
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040009AE RID: 2478
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009AF RID: 2479
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040009B0 RID: 2480
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Long

		' Token: 0x040009B1 RID: 2481
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As NameValueCollection

		' Token: 0x020001E4 RID: 484
		<CompilerGenerated()>
		Friend NotInheritable Class o0oO
			' Token: 0x06001817 RID: 6167 RVA: 0x0009C609 File Offset: 0x0009A809
			Friend Function <<EMPTY_NAME>>() As Boolean
				Return Me.O_0_.0O..GetFile(Me.O_0_.0O.)
			End Function

			' Token: 0x040009B2 RID: 2482
			Public <<EMPTY_NAME>> As String

			' Token: 0x040009B3 RID: 2483
			Public <<EMPTY_NAME>> As HttpClient
		End Class

		' Token: 0x020001E7 RID: 487
		<CompilerGenerated()>
		Friend NotInheritable Class o_00oOo
			' Token: 0x0600181D RID: 6173 RVA: 0x0009C804 File Offset: 0x0009AA04
			Friend Function <<EMPTY_NAME>>() As Task(Of JObject)
				Dim a As HttpClient.o_00oOo.a = Nothing
				a.OoOO0o0O.o0. = Me
				a.OoOO0o0O.o0. = -1
				a.OoOO0o0O.o0. = AsyncTaskMethodBuilder(Of JObject).Create()
				a.OoOO0o0O.o0..Start(Of HttpClient.o_00oOo.a)(a)
				Return a.OoOO0o0O.o0..Task
			End Function

			' Token: 0x040009BD RID: 2493
			Public <<EMPTY_NAME>> As Action(Of String, String)

			' Token: 0x040009BE RID: 2494
			Public <<EMPTY_NAME>> As HttpClient
		End Class

		' Token: 0x020001EA RID: 490
		<CompilerGenerated()>
		Friend NotInheritable Class o_O_
			' Token: 0x06001823 RID: 6179 RVA: 0x0009CA4C File Offset: 0x0009AC4C
			Friend Function <<EMPTY_NAME>>() As Task(Of JObject)
				Dim a As HttpClient.o_O_.a = Nothing
				a.Oo_O_o0__._0_. = Me
				a.Oo_O_o0__._0_. = -1
				a.Oo_O_o0__._0_. = AsyncTaskMethodBuilder(Of JObject).Create()
				a.Oo_O_o0__._0_..Start(Of HttpClient.o_O_.a)(a)
				Return a.Oo_O_o0__._0_..Task
			End Function

			' Token: 0x040009C9 RID: 2505
			Public <<EMPTY_NAME>> As Action(Of String, String)

			' Token: 0x040009CA RID: 2506
			Public <<EMPTY_NAME>> As HttpClient
		End Class

		' Token: 0x020001ED RID: 493
		<CompilerGenerated()>
		Friend NotInheritable Class oo0OO
			' Token: 0x06001829 RID: 6185 RVA: 0x0009CC82 File Offset: 0x0009AE82
			Friend Sub <<EMPTY_NAME>>()
				Me.Oo_O_o0__._0_.(Me.Oo_O_o0__._0_., Me.o_O_ooO.0OO.)
			End Sub

			' Token: 0x040009D4 RID: 2516
			Public <<EMPTY_NAME>> As Action(Of String, String)

			' Token: 0x040009D5 RID: 2517
			Public <<EMPTY_NAME>> As String

			' Token: 0x040009D6 RID: 2518
			Public <<EMPTY_NAME>> As String
		End Class
	End Class
End Namespace
