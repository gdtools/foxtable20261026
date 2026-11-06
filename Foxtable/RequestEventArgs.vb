Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Web
Imports Foxtable.XLS
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020001E2 RID: 482
	Public Class RequestEventArgs
		' Token: 0x17000521 RID: 1313
		' (get) Token: 0x06001780 RID: 6016 RVA: 0x0009644A File Offset: 0x0009464A
		' (set) Token: 0x06001781 RID: 6017 RVA: 0x00096452 File Offset: 0x00094652
		Public Property Cancel As Boolean

		' Token: 0x06001782 RID: 6018 RVA: 0x0009645C File Offset: 0x0009465C
		Friend Sub New(A_0 As HttpListenerContext, A_1 As String, A_2 As List(Of String))
			Me.oo_OO_0._O0O. = New Dictionary(Of String, String)()
			Me.oo_OO_0._O0O. = New Dictionary(Of String, List(Of String))()
			Me.o0__O0.o_0. = New HttpDictionary()
			Me.o0__0oOoo_.o. = New HttpDictionary()
			Me.O.OOooO0o_O__o. = New HttpDictionary()
			Me.o_00.OO0O. = New HttpDictionary()
			Me.o0__O0.o_0. = "utf-8"
			Me.Oo._00O_0Oo. = "utf-8"
			Me.oo_OO_0._O0O. = -1
			Me.oo_OO_0._O0O. = A_0
			Me.o0__O0.o_0. = A_0.Request
			Me.o0__O0.o_0. = A_0.Response
			Me.O_OOo_.0oO_. = A_1
			Me.oo_OO_0._O0O. = A_2
		End Sub

		' Token: 0x17000522 RID: 1314
		' (get) Token: 0x06001783 RID: 6019 RVA: 0x000964FB File Offset: 0x000946FB
		Public ReadOnly Property Context As HttpListenerContext
			Get
				Return Me.oo_OO_0._O0O.
			End Get
		End Property

		' Token: 0x17000523 RID: 1315
		' (get) Token: 0x06001784 RID: 6020 RVA: 0x00096503 File Offset: 0x00094703
		' (set) Token: 0x06001785 RID: 6021 RVA: 0x0009650B File Offset: 0x0009470B
		<oO0oooo("A278")>
		Public Property AsyncExecute As Boolean
			Get
				Return Me.o0__0oOoo_.o.
			End Get
			Set(value As Boolean)
				Me.o0__0oOoo_.o. = True
			End Set
		End Property

		' Token: 0x17000524 RID: 1316
		' (get) Token: 0x06001786 RID: 6022 RVA: 0x00096514 File Offset: 0x00094714
		' (set) Token: 0x06001787 RID: 6023 RVA: 0x0009651C File Offset: 0x0009471C
		<oO0oooo("A3275")>
		Public Property CacheTime As Integer
			Get
				Return Me.oo_OO_0._O0O.
			End Get
			Set(value As Integer)
				Me.oo_OO_0._O0O. = value
				Me.o0__O0.o_0..Headers("Cache-Control") = "max-age=" + Conversions.ToString(value)
			End Set
		End Property

		' Token: 0x17000525 RID: 1317
		' (set) Token: 0x06001788 RID: 6024 RVA: 0x0009654C File Offset: 0x0009474C
		<oO0oooo("A278")>
		Public WriteOnly Property Handled As Boolean
			Set(value As Boolean)
				If value Then
					Me.o0__O0.o_0..Clear()
					Me.oo_OO_0._O0O..Clear()
					Try
						For Each text As String In Me.oo_OO_0._O0O..Keys
						Next
					Finally
						Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.oo_OO_0._O0O..Clear()
					Try
						Me.Request.InputStream.Close()
						If Not Me.oo0o.oo_oOoOo0. Then
							Me.Response.OutputStream.Close()
							Me.Response.Close()
							Me.Response.Abort()
						End If
					Catch ex As Exception
					End Try
				End If
			End Set
		End Property

		' Token: 0x17000526 RID: 1318
		' (get) Token: 0x06001789 RID: 6025 RVA: 0x00096620 File Offset: 0x00094820
		Public ReadOnly Property Request As HttpListenerRequest
			Get
				Return Me.o0__O0.o_0.
			End Get
		End Property

		' Token: 0x17000527 RID: 1319
		' (get) Token: 0x0600178A RID: 6026 RVA: 0x00096628 File Offset: 0x00094828
		Public ReadOnly Property Response As HttpListenerResponse
			Get
				Return Me.o0__O0.o_0.
			End Get
		End Property

		' Token: 0x17000528 RID: 1320
		' (get) Token: 0x0600178B RID: 6027 RVA: 0x00096630 File Offset: 0x00094830
		<oO0oooo("A0113")>
		Public ReadOnly Property Values As HttpDictionary
			Get
				If Not Me.O_0O00.o. Then
					Me.O0_OO0oOO.O_0O.()
				End If
				Return Me.o0__O0.o_0.
			End Get
		End Property

		' Token: 0x17000529 RID: 1321
		' (get) Token: 0x0600178C RID: 6028 RVA: 0x00096646 File Offset: 0x00094846
		<oO0oooo("A0030")>
		Public ReadOnly Property Files As Dictionary(Of String, List(Of String))
			Get
				Return Me.oo_OO_0._O0O.
			End Get
		End Property

		' Token: 0x1700052A RID: 1322
		' (get) Token: 0x0600178D RID: 6029 RVA: 0x0009664E File Offset: 0x0009484E
		<oO0oooo("A0042")>
		Public ReadOnly Property Cookies As HttpDictionary
			Get
				If Not Me.O_0O00.o. Then
					Me.O0_OO0oOO.O_0O.()
				End If
				Return Me.o_00.OO0O.
			End Get
		End Property

		' Token: 0x0600178E RID: 6030 RVA: 0x00096664 File Offset: 0x00094864
		<oO0oooo("A0042")>
		Public Sub AppendCookie(name As String, value As String)
			value = OO_00oOO.o_.0_OoOo0_0.(value)
			If value.IndexOf("'") >= 0 Then
				value = value.Replace("'", "%27")
			End If
			Dim cookie As Cookie = New Cookie(OO_00oOO.o_.0_OoOo0_0.(name), value)
			Me.Response.AppendCookie(cookie)
		End Sub

		' Token: 0x1700052B RID: 1323
		' (get) Token: 0x0600178F RID: 6031 RVA: 0x000966B2 File Offset: 0x000948B2
		<oO0oooo("A0006")>
		Public ReadOnly Property Host As String
			Get
				Return Me.Request.Url.Host
			End Get
		End Property

		' Token: 0x1700052C RID: 1324
		' (get) Token: 0x06001790 RID: 6032 RVA: 0x000966C4 File Offset: 0x000948C4
		<oO0oooo("A0006")>
		Public ReadOnly Property Port As Integer
			Get
				Return Me.Request.Url.Port
			End Get
		End Property

		' Token: 0x1700052D RID: 1325
		' (get) Token: 0x06001791 RID: 6033 RVA: 0x000966D8 File Offset: 0x000948D8
		<oO0oooo("A0006")>
		Public ReadOnly Property path As String
			Get
				Dim text As String = HttpUtility.UrlDecode(Me.Request.RawUrl)
				If Operators.CompareString(text, "", True) > 0 AndAlso text.IndexOf("?") >= 0 Then
					text = text.Substring(0, text.IndexOf("?"))
				End If
				Return text.Trim(New Char() { "/"c }).Trim(New Char() { "\"c }).Replace("/", "\")
			End Get
		End Property

		' Token: 0x1700052E RID: 1326
		' (get) Token: 0x06001792 RID: 6034 RVA: 0x00096758 File Offset: 0x00094958
		' (set) Token: 0x06001793 RID: 6035 RVA: 0x00096760 File Offset: 0x00094960
		Public Property RequestEncoding As String
			Get
				Return Me.o0__O0.o_0.
			End Get
			Set(value As String)
				Me.o0__O0.o_0. = value
			End Set
		End Property

		' Token: 0x1700052F RID: 1327
		' (get) Token: 0x06001794 RID: 6036 RVA: 0x00096769 File Offset: 0x00094969
		' (set) Token: 0x06001795 RID: 6037 RVA: 0x00096771 File Offset: 0x00094971
		<oO0oooo("A0022")>
		Public Property ResponseEncoding As String
			Get
				Return Me.Oo._00O_0Oo.
			End Get
			Set(value As String)
				Me.Oo._00O_0Oo. = value
			End Set
		End Property

		' Token: 0x17000530 RID: 1328
		' (get) Token: 0x06001796 RID: 6038 RVA: 0x0009677A File Offset: 0x0009497A
		' (set) Token: 0x06001797 RID: 6039 RVA: 0x00096787 File Offset: 0x00094987
		Public Property StatusCode As Integer
			Get
				Return Me.Response.StatusCode
			End Get
			Set(value As Integer)
				Me.Response.StatusCode = value
			End Set
		End Property

		' Token: 0x17000531 RID: 1329
		' (get) Token: 0x06001798 RID: 6040 RVA: 0x00096795 File Offset: 0x00094995
		<oO0oooo("A3279")>
		Public ReadOnly Property Headers As NameValueCollection
			Get
				Return Me.Request.Headers
			End Get
		End Property

		' Token: 0x17000532 RID: 1330
		' (get) Token: 0x06001799 RID: 6041 RVA: 0x000967A2 File Offset: 0x000949A2
		<oO0oooo("A3279")>
		Public ReadOnly Property ResponseHeaders As NameValueCollection
			Get
				Return Me.Response.Headers
			End Get
		End Property

		' Token: 0x17000533 RID: 1331
		' (get) Token: 0x0600179A RID: 6042 RVA: 0x000967AF File Offset: 0x000949AF
		' (set) Token: 0x0600179B RID: 6043 RVA: 0x000967BC File Offset: 0x000949BC
		Public Property StatusDescription As String
			Get
				Return Me.Response.StatusDescription
			End Get
			Set(value As String)
				Me.Response.StatusDescription = value
			End Set
		End Property

		' Token: 0x0600179C RID: 6044 RVA: 0x000967CC File Offset: 0x000949CC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SaveFile(ID As String, idx As Integer, LocalFileName As String)
			OO_00oOO.FileSys.GetParentPath(LocalFileName)
			If Me.Files.ContainsKey(ID) AndAlso Me.Files.Count > idx Then
				Me.SaveFile(ID, Me.Files(ID)(idx), LocalFileName)
			End If
		End Sub

		' Token: 0x0600179D RID: 6045 RVA: 0x0009681C File Offset: 0x00094A1C
		<oO0oooo("A0030")>
		Public Sub SaveFile(Key As String, UploadFile As String, LocalFile As String)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(UploadFile, "", True) <> 0 Then
					GoTo IL_67
				End If
				IL_17:
				num2 = 3
				If Not OO_00oOO.FileSys.FileExists(Me.oo_OO_0._O0O.(Key + "_" + UploadFile)) Then
					GoTo IL_110
				End If
				IL_3F:
				num2 = 4
				OO_00oOO.FileSys.DeleteFile(Me.oo_OO_0._O0O.(Key + "_" + UploadFile))
				GoTo IL_110
				IL_67:
				num2 = 6
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(LocalFile)
				IL_75:
				num2 = 7
				If Not Me.Files.ContainsKey(Key) OrElse Not Me.Files(Key).Contains(UploadFile) Then
					GoTo IL_110
				End If
				IL_9C:
				num2 = 10
				If Operators.CompareString(parentPath, "", True) <= 0 Then
					GoTo IL_CC
				End If
				IL_AE:
				num2 = 11
				If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					GoTo IL_CC
				End If
				IL_BE:
				num2 = 12
				OO_00oOO.FileSys.CreateDirectory(parentPath)
				IL_CC:
				num2 = 13
				If Not OO_00oOO.FileSys.FileExists(LocalFile) Then
					GoTo IL_EA
				End If
				IL_DC:
				num2 = 14
				OO_00oOO.FileSys.DeleteFile(LocalFile)
				IL_EA:
				num2 = 15
				OO_00oOO.FileSys.MoveFile(Me.oo_OO_0._O0O.(Key + "_" + UploadFile), LocalFile, True)
				IL_110:
				GoTo IL_1A2
				IL_115:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_163:
				GoTo IL_197
				IL_165:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_175:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_165
			End Try
			IL_197:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1A2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000534 RID: 1332
		' (get) Token: 0x0600179E RID: 6046 RVA: 0x000969F0 File Offset: 0x00094BF0
		' (set) Token: 0x0600179F RID: 6047 RVA: 0x000969F8 File Offset: 0x00094BF8
		<oO0oooo("A0108")>
		Public Property PlainText As String
			Get
				Return Me.O.OOooO0o_O__o.
			End Get
			Friend Set(value As String)
				Me.O.OOooO0o_O__o. = value
			End Set
		End Property

		' Token: 0x17000535 RID: 1333
		' (get) Token: 0x060017A0 RID: 6048 RVA: 0x00096A01 File Offset: 0x00094C01
		<oO0oooo("A0113")>
		Public ReadOnly Property PostValues As HttpDictionary
			Get
				Return Me.O.OOooO0o_O__o.
			End Get
		End Property

		' Token: 0x17000536 RID: 1334
		' (get) Token: 0x060017A1 RID: 6049 RVA: 0x00096A09 File Offset: 0x00094C09
		<oO0oooo("A0113")>
		Public ReadOnly Property GetValues As HttpDictionary
			Get
				If Not Me.O_0O00.o. Then
					Me.O0_OO0oOO.O_0O.()
				End If
				Return Me.o0__0oOoo_.o.
			End Get
		End Property

		' Token: 0x060017A2 RID: 6050 RVA: 0x00096A20 File Offset: 0x00094C20
		<oO0oooo("A0010")>
		Public Sub WriteString(value As String, ContentType As String)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.("")
				Me.ResponseHeaders.Add("Development_Tool", "Foxtable 2022")
				Me.oo0o.oo_oOoOo0. = True
				If value Is Nothing Then
					value = ""
				End If
				Dim oOo0_o0Oo_ As oOo0_o0Oo_00 = New oOo0_o0Oo_00(value, Me.Response, Me.Oo._00O_0Oo.)
				If Operators.CompareString(ContentType, "text/html", True) <> 0 Then
					oOo0_o0Oo_.oO0o0o._0.(ContentType)
				End If
				ThreadPool.QueueUserWorkItem(AddressOf oOo0_o0Oo_.Oo000.o00., Nothing)
			End If
		End Sub

		' Token: 0x060017A3 RID: 6051 RVA: 0x00096AA1 File Offset: 0x00094CA1
		Public Sub WriteString(value As String)
			Me.WriteString(value, "text/html")
		End Sub

		' Token: 0x060017A4 RID: 6052 RVA: 0x00096AAF File Offset: 0x00094CAF
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.("")
				Me.oo0o.oo_oOoOo0. = True
				If A_0 Is Nothing Then
					A_0 = ""
				End If
				New oOo0_o0Oo_00(A_0, Me.Response, Me.Oo._00O_0Oo.).Oo000.o00.(Nothing)
			End If
		End Sub

		' Token: 0x060017A5 RID: 6053 RVA: 0x00096AED File Offset: 0x00094CED
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.("")
				Me.oo0o.oo_oOoOo0. = True
				New O_o0_0_o0(Me, A_0, A_1, A_2).OO0.0_0O0O_0_0.(Nothing)
			End If
		End Sub

		' Token: 0x060017A6 RID: 6054 RVA: 0x00096B18 File Offset: 0x00094D18
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Dim memoryStream As MemoryStream = Nothing
				Dim flag As Boolean
				Try
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(A_1).ConnectionString)
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(A_0, oleDbConnection)
					oleDbConnection.Open()
					Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
					If oleDbDataReader.Read() Then
						If Not oleDbDataReader.IsDBNull(0) Then
							memoryStream = New MemoryStream(CType(oleDbDataReader(0), Byte()))
						Else
							flag = True
						End If
					End If
					oleDbDataReader.Close()
					oleDbConnection.Close()
				Catch ex As Exception
					Me.AppendCookie("Error", ex.Message)
					Me.o_O.oO.("")
					Return
				End Try
				If memoryStream Is Nothing Then
					If flag Then
						Me.AppendCookie("IsNull", "True")
					Else
						Me.AppendCookie("Error", "获取文件失败，错误未知")
					End If
					Me.o_O.oO.("")
					Return
				End If
				memoryStream.Position = 0L
				New oOO_O__(memoryStream, Me.Response).oO0o0o._0.(Nothing)
			End If
		End Sub

		' Token: 0x060017A7 RID: 6055 RVA: 0x00096C24 File Offset: 0x00094E24
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(A_1).ConnectionString)
				Try
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(A_0, oleDbConnection)
					Try
						Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Me.oo_OO_0._O0O..Keys.GetEnumerator()
						If enumerator.MoveNext() Then
							Dim key As String = enumerator.Current
							Dim memoryStream As MemoryStream = New MemoryStream()
							Dim fileStream As FileStream = File.Open(Me.oo_OO_0._O0O.(key), FileMode.Open)
							Dim array As Byte() = New Byte(51200) {}
							For i As Integer = fileStream.Read(array, 0, array.Length)To 0 + 1
								memoryStream.Write(array, 0, i)
							Next
							fileStream.Dispose()
							oleDbCommand.Parameters.Add("@File", OleDbType.Binary, CInt(memoryStream.Length)).Value = memoryStream.ToArray()
							OO_00oOO.FileSys.DeleteFile(Me.oo_OO_0._O0O.(key))
							memoryStream.Dispose()
						End If
					Finally
						Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					oleDbConnection.Open()
					Me.o_O.oO.(oleDbCommand.ExecuteNonQuery().ToString())
				Catch ex As Exception
					Me.AppendCookie("Error", ex.Message)
					Me.o_O.oO.("")
				Finally
					oleDbConnection.Close()
				End Try
			End If
		End Sub

		' Token: 0x060017A8 RID: 6056 RVA: 0x00096DE4 File Offset: 0x00094FE4
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(A_0, ".html", True) = 0 OrElse Operators.CompareString(A_0, ".htm", True) = 0 OrElse Operators.CompareString(A_0, ".css", True) = 0 OrElse Operators.CompareString(A_0, ".js", True) = 0 OrElse Operators.CompareString(A_0, ".txt", True) = 0 Then
				Me.Response.ContentEncoding = HttpFunctions.OO.0o.(Me.Oo._00O_0Oo.)
				If Operators.CompareString(A_0, ".html", True) = 0 OrElse Operators.CompareString(A_0, ".htm", True) = 0 Then
					Me.Response.ContentType = "text/html; charset=" + Me.Oo._00O_0Oo.
					Return
				End If
				If Operators.CompareString(A_0, ".css", True) = 0 Then
					Me.Response.ContentType = "text/css; charset=" + Me.Oo._00O_0Oo.
					Return
				End If
				If Operators.CompareString(A_0, ".js", True) = 0 Then
					Me.Response.ContentType = "application/x-javascript; charset=" + Me.Oo._00O_0Oo.
					Return
				End If
				If Operators.CompareString(A_0, ".txt", True) = 0 Then
					Me.Response.ContentType = "text/plain; charset=" + Me.Oo._00O_0Oo.
					Return
				End If
			Else
				If Operators.CompareString(A_0, ".xls", True) = 0 OrElse Operators.CompareString(A_0, ".xlsx", True) = 0 Then
					Me.Response.ContentType = "application/vnd.ms-excel"
					Return
				End If
				If Operators.CompareString(A_0, ".doc", True) = 0 OrElse Operators.CompareString(A_0, ".docx", True) = 0 Then
					Me.Response.ContentType = "application/msword"
					Return
				End If
				If Operators.CompareString(A_0, ".mdb", True) = 0 Then
					Me.Response.ContentType = "application/msaccess"
					Return
				End If
				If Operators.CompareString(A_0, ".pdf", True) = 0 Then
					Me.Response.ContentType = "application/pdf"
					Return
				End If
				If Operators.CompareString(A_0, ".zip", True) = 0 OrElse Operators.CompareString(A_0, ".rar", True) = 0 Then
					Me.Response.ContentType = "application/x-zip-compressed"
					Return
				End If
				If Operators.CompareString(A_0, ".gif", True) = 0 Then
					Me.Response.ContentType = "image/gif"
					Return
				End If
				If Operators.CompareString(A_0, ".jpg", True) = 0 OrElse Operators.CompareString(A_0, ".jpeg", True) = 0 Then
					Me.Response.ContentType = "image/jpeg"
					Return
				End If
				If Operators.CompareString(A_0, ".png", True) = 0 Then
					Me.Response.ContentType = "image/png"
					Return
				End If
				Me.Response.ContentType = "application/octet-stream"
			End If
		End Sub

		' Token: 0x060017A9 RID: 6057 RVA: 0x00097050 File Offset: 0x00095250
		<oO0oooo("A0291")>
		Public Sub WriteExcelAsHTML(workbook As Workbook)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm"
			Dim text2 As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm"
			workbook.SaveAs(text, 44, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), 1, RuntimeHelpers.GetObjectValue(Missing.Value), False, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.Saved = True
			workbook.Application.Quit()
			OO_00oOO.FileSys.CopyFile(text, text2)
			Me.WriteFile(text2, "")
		End Sub

		' Token: 0x060017AA RID: 6058 RVA: 0x00097118 File Offset: 0x00095318
		<oO0oooo("A0291")>
		Public Sub WriteExcelAsPDF(workbook As Workbook)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".pdf"
			workbook.ExportAsFixedFormat(0, text, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			workbook.Saved = True
			workbook.Application.Quit()
			Me.WriteFile(text, "")
		End Sub

		' Token: 0x060017AB RID: 6059 RVA: 0x000971A8 File Offset: 0x000953A8
		Public Sub WriteWordAsHTML(document As Document)
			Dim obj As Object = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm"
			Dim obj2 As Object = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".htm"
			Dim obj3 As Object = 8
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim obj4 As Object = False
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			document.SaveAs2(obj, obj3, objectValue, objectValue2, obj4, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14)
			Dim application As _Application = document.Application
			objectValue14 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue13 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue12 = RuntimeHelpers.GetObjectValue(Missing.Value)
			application.Quit(objectValue14, objectValue13, objectValue12)
			OO_00oOO.FileSys.CopyFile(obj.ToString(), obj2.ToString())
			Me.WriteFile(obj2.ToString(), "")
		End Sub

		' Token: 0x060017AC RID: 6060 RVA: 0x0009731C File Offset: 0x0009551C
		Public Sub WriteWordAsPDF(document As Document)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(6) + ".pdf"
			Dim text2 As String = text
			Dim wdExportFormat As WdExportFormat = 17
			Dim flag As Boolean = False
			Dim wdExportOptimizeFor As WdExportOptimizeFor = 0
			Dim wdExportRange As WdExportRange = 0
			Dim num As Integer = 1
			Dim num2 As Integer = 1
			Dim wdExportItem As WdExportItem = 0
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = True
			Dim wdExportCreateBookmarks As WdExportCreateBookmarks = 0
			Dim flag4 As Boolean = True
			Dim flag5 As Boolean = True
			Dim flag6 As Boolean = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			document.ExportAsFixedFormat(text2, wdExportFormat, flag, wdExportOptimizeFor, wdExportRange, num, num2, wdExportItem, flag2, flag3, wdExportCreateBookmarks, flag4, flag5, flag6, objectValue)
			Dim application As _Application = document.Application
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			application.Quit(objectValue, objectValue2, objectValue3)
			Me.WriteFile(text, "")
		End Sub

		' Token: 0x060017AD RID: 6061 RVA: 0x000973A0 File Offset: 0x000955A0
		<oO0oooo("A0148")>
		Public Sub WriteBook(Book As Book, fileName As String, Optional Inline As Boolean = True)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				If Operators.CompareString(Me.Request.Headers("Range"), "", True) > 0 AndAlso Operators.CompareString(Me.Request.Headers("range").Substring(6).Split(New Char() { "-"c })(0).Trim(), "0", True) <> 0 Then
					Me.Response.ContentLength64 = 0L
					Me.Response.OutputStream.Close()
					Me.Response.Close()
					Me.Response.Abort()
					Return
				End If
				If Operators.CompareString(Path.GetExtension(fileName), ".xls", True) = 0 Then
					Book.oO.o_0o__..CompatibilityMode = 0
				ElseIf Operators.CompareString(Path.GetExtension(fileName), ".xlsx", True) = 0 Then
					Book.oO.o_0o__..CompatibilityMode = 1
				End If
				Me.Response.ContentEncoding = HttpFunctions.OO.0o.(Me.ResponseEncoding)
				ThreadPool.QueueUserWorkItem(AddressOf New o_o_0OO(Me.Response, Book, fileName, Inline).OO__o_OOoOo_.0., Nothing)
			End If
		End Sub

		' Token: 0x060017AE RID: 6062 RVA: 0x000974CC File Offset: 0x000956CC
		<oO0oooo("A6051")>
		Public Sub WriteWordCreator(Creator As WordCreator, FileName As String, Optional Inline As Boolean = True)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				If Operators.CompareString(Me.Request.Headers("Range"), "", True) > 0 AndAlso Operators.CompareString(Me.Request.Headers("range").Substring(6).Split(New Char() { "-"c })(0).Trim(), "0", True) <> 0 Then
					Me.Response.ContentLength64 = 0L
					Me.Response.OutputStream.Close()
					Me.Response.Close()
					Me.Response.Abort()
					Return
				End If
				Me.Response.ContentEncoding = HttpFunctions.OO.0o.(Me.ResponseEncoding)
				ThreadPool.QueueUserWorkItem(AddressOf New o000OOOO(Me.Response, Creator, FileName, Inline).Oo000.o00., Nothing)
			End If
		End Sub

		' Token: 0x060017AF RID: 6063 RVA: 0x000975B8 File Offset: 0x000957B8
		Public Sub WritePDFCreator(Creator As PDFCreator, FileName As String, Optional Inline As Boolean = True)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				If Operators.CompareString(Me.Request.Headers("Range"), "", True) > 0 AndAlso Operators.CompareString(Me.Request.Headers("range").Substring(6).Split(New Char() { "-"c })(0).Trim(), "0", True) <> 0 Then
					Me.Response.ContentLength64 = 0L
					Me.Response.OutputStream.Close()
					Me.Response.Close()
					Me.Response.Abort()
					Return
				End If
				Me.Response.ContentEncoding = HttpFunctions.OO.0o.(Me.ResponseEncoding)
				ThreadPool.QueueUserWorkItem(AddressOf New o_o_O00_(Me.Response, Creator, FileName, Inline).ooO0O.0., Nothing)
			End If
		End Sub

		' Token: 0x060017B0 RID: 6064 RVA: 0x000976A3 File Offset: 0x000958A3
		<oO0oooo("A0288")>
		Public Sub WriteBookAsHTML(Book As Book)
			Me.WriteBookAsHTML(Book, True)
		End Sub

		' Token: 0x060017B1 RID: 6065 RVA: 0x000976B0 File Offset: 0x000958B0
		<oO0oooo("A0288")>
		Public Sub WriteBookAsHTML(Book As Book, Build As Boolean)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Me.oO_.0.(".htm")
				ThreadPool.QueueUserWorkItem(AddressOf New OO_oO00o(Me.Response, Book) With { .OO.oO00. = Build }.OO.oO00., Nothing)
			End If
		End Sub

		' Token: 0x060017B2 RID: 6066 RVA: 0x000976FC File Offset: 0x000958FC
		<oO0oooo("A0288")>
		Public Sub WriteBookAsHTML(Book As Book, ParamArray Indexes As Integer())
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Me.oO_.0.(".htm")
				ThreadPool.QueueUserWorkItem(AddressOf New OO_oO00o(Me.Response, Book) With { .O_0._00_. = Indexes }.OO.oO00., Nothing)
			End If
		End Sub

		' Token: 0x060017B3 RID: 6067 RVA: 0x00097748 File Offset: 0x00095948
		<oO0oooo("0288")>
		Public Sub WriteBookAsPDF(Book As Book)
			Me.WriteBookAsPDF(Book, True)
		End Sub

		' Token: 0x060017B4 RID: 6068 RVA: 0x00097754 File Offset: 0x00095954
		<oO0oooo("A0288")>
		Public Sub WriteBookAsPDF(Book As Book, Build As Boolean)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Me.oO_.0.(".pdf")
				ThreadPool.QueueUserWorkItem(AddressOf New Oo0o0o_0_(Me.Response, Book) With { .O_0._00_. = Build }.O_0._00_., Nothing)
			End If
		End Sub

		' Token: 0x060017B5 RID: 6069 RVA: 0x000977A0 File Offset: 0x000959A0
		<oO0oooo("A0288")>
		Public Sub WriteBookAsPDF(Book As Book, ParamArray Indexes As Integer())
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Me.oO_.0.(".pdf")
				ThreadPool.QueueUserWorkItem(AddressOf New Oo0o0o_0_(Me.Response, Book) With { .O_0._00_. = Indexes }.O_0._00_., Nothing)
			End If
		End Sub

		' Token: 0x060017B6 RID: 6070 RVA: 0x000977EC File Offset: 0x000959EC
		<oO0oooo("A0290")>
		Public Sub WriteReportAsPDF(PrintDoc As PrintDoc)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oo0o.oo_oOoOo0. = True
				Me.oO_.0.(".pdf")
				ThreadPool.QueueUserWorkItem(AddressOf New ooo_0O0o00(PrintDoc, Me.Response).oO0o0o._0., Nothing)
			End If
		End Sub

		' Token: 0x060017B7 RID: 6071 RVA: 0x00097826 File Offset: 0x00095A26
		<oO0oooo("A0162")>
		Public Sub WriteDataTable(dt As DataTable)
			If Not Me.oo0o.oo_oOoOo0. AndAlso dt IsNot Nothing Then
				Me.oO.O_0_OO.("")
				Me.oo0o.oo_oOoOo0. = True
				ThreadPool.QueueUserWorkItem(AddressOf New O_o0_0_o0(dt.BaseTable, Me).O_0._00_., Nothing)
			End If
		End Sub

		' Token: 0x060017B8 RID: 6072 RVA: 0x00097863 File Offset: 0x00095A63
		Public Sub WriteDataTable(SelectString As String, ConnectionName As String)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.("")
				Me.oo0o.oo_oOoOo0. = True
				ThreadPool.QueueUserWorkItem(AddressOf New O_o0_0_o0(Me, SelectString, ConnectionName, False).OO0.0_0O0O_0_0., Nothing)
			End If
		End Sub

		' Token: 0x060017B9 RID: 6073 RVA: 0x0009789A File Offset: 0x00095A9A
		Private Sub <<EMPTY_NAME>>(A_0 As DataTable)
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.("")
				Me.oo0o.oo_oOoOo0. = True
				New O_o0_0_o0(A_0, Me).O_0._00_.(2)
			End If
		End Sub

		' Token: 0x060017BA RID: 6074 RVA: 0x000978C8 File Offset: 0x00095AC8
		<oO0oooo("A0015")>
		Public Sub WriteFile(FileName As String, Optional ContentType As String = "")
			If Not Me.oo0o.oo_oOoOo0. Then
				Me.oO.O_0_OO.(FileName)
				If Not FileName.StartsWith("//") AndAlso FileName.Length > 2 AndAlso Operators.CompareString(Conversions.ToString(FileName(1)), ":", True) <> 0 AndAlso Operators.CompareString(Me.O_OOo_.0oO_., "", True) > 0 Then
					FileName = Me.O_OOo_.0oO_..TrimEnd(New Char() { "/"c }) + "/" + FileName
				End If
				If OO_00oOO.FileSys.FileExists(FileName) Then
					If Operators.CompareString(ContentType, "", True) = 0 Then
						Dim a_ As String = Path.GetExtension(FileName).ToLower()
						Me.oO_.0.(a_)
					Else
						Me.Response.ContentType = ContentType
					End If
					Me.oo0o.oo_oOoOo0. = True
					If Operators.CompareString(Me.Request.Headers("Range"), "", True) > 0 Then
						If Operators.CompareString(Me.Request.Headers("range").Substring(6).Split(New Char() { "-"c })(0).Trim(), "0", True) <> 0 Then
							Me.Response.ContentLength64 = 0L
							Me.Response.OutputStream.Close()
							Me.Response.Close()
							Me.Response.Abort()
							Return
						End If
						Dim fileInfo As FileInfo = New FileInfo(FileName)
						Me.Response.Headers.Add("Content-Range", "bytes 0-" + Conversions.ToString(fileInfo.Length - 1L) + "/" + Conversions.ToString(fileInfo.Length))
					End If
					ThreadPool.QueueUserWorkItem(AddressOf New o_o0O_Ooo__O(FileName, Me.Response).ooO0O.0., Nothing)
				End If
			End If
		End Sub

		' Token: 0x060017BB RID: 6075 RVA: 0x00097A90 File Offset: 0x00095C90
		Private Sub <<EMPTY_NAME>>()
			Me.O_0O00.o. = True
			If Operators.CompareString(Me.Request.Url.Query, "", True) > 0 Then
				Dim array As String() = Me.Request.Url.Query.TrimStart(New Char() { "?"c }).Split(New Char() { "&"c })
				For i As Integer = 0 To array.Length - 1
					Dim array2 As String() = array(i).Split(New Char() { "="c })
					If array2.Length = 2 Then
						array2(0) = OO_00oOO.O_0.0O__O0.(array2(0))
						array2(1) = OO_00oOO.O_0.0O__O0.(array2(1))
						If Not Me.o0__O0.o_0..ContainsKey(array2(0)) Then
							Me.o0__O0.o_0..Add(array2(0), array2(1))
							Me.o0__0oOoo_.o..Add(array2(0), array2(1))
						End If
					End If
				Next
			End If
			Try
				For Each obj As Object In Me.Request.Cookies
					Dim cookie As Cookie = CType(obj, Cookie)
					Me.Cookies.Add(OO_00oOO.O_0.0O__O0.(cookie.Name), OO_00oOO.O_0.0O__O0.(cookie.Value))
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060017BC RID: 6076 RVA: 0x00097BD8 File Offset: 0x00095DD8
		Friend Sub <<EMPTY_NAME>>()
			Dim flag As Boolean = False
			Try
				Dim flag2 As Boolean = True
				If OO_00oOO.HttpServer.UserProcessHosts.Contains("*") Then
					flag2 = False
				ElseIf OO_00oOO.HttpServer.UserProcessHosts.Count > 0 Then
					Dim host As String = Me.Host
					Try
						For Each right As String In OO_00oOO.HttpServer.UserProcessHosts
							If Operators.CompareString(host, right, True) = 0 Then
								flag2 = False
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				If Not Me.Request.HasEntityBody Then
					Dim text As String = Me.path
					If Operators.CompareString(Me.O_OOo_.0oO_., "", True) > 0 Then
						text = Me.O_OOo_.0oO_..TrimEnd(New Char() { "\"c }) + "\" + text.Trim(New Char() { "\"c })
						If OO_00oOO.FileSys.FileExists(text) Then
							Dim extension As String = Path.GetExtension(text)
							If Operators.CompareString(extension, "", True) > 0 AndAlso Me.oo_OO_0._O0O..Contains(extension.ToLower()) Then
								Me.Request.InputStream.Close()
								flag = True
								Me.WriteFile(text, "")
							End If
						End If
					End If
				ElseIf flag2 Then
					Dim text2 As String = Me.Request.ContentType.ToLower()
					If text2.StartsWith("application/json") OrElse text2.StartsWith("text/plain") OrElse text2.StartsWith("text/xml") OrElse text2.StartsWith("text/html") Then
						Dim encoding As Encoding = Me.O0_OO0oOO.O_0O.()
						Dim streamReader As StreamReader = New StreamReader(Me.Request.InputStream, encoding)
						Me.O.OOooO0o_O__o. = streamReader.ReadToEnd()
					ElseIf text2.StartsWith("application/x-www-form-urlencoded") Then
						Dim encoding2 As Encoding = Me.O0_OO0oOO.O_0O.()
						Dim array As String() = New StreamReader(Me.Request.InputStream, encoding2).ReadToEnd().Split(New Char() { "&"c })
						For i As Integer = 0 To array.Length - 1
							Dim array2 As String() = array(i).Split(New Char() { "="c })
							If array2.Length >= 2 Then
								Dim key As String = HttpUtility.UrlDecode(array2(0))
								If Not Me.o0__O0.o_0..ContainsKey(key) Then
									Me.o0__O0.o_0..Add(key, HttpUtility.UrlDecode(array2(1)))
									Me.O.OOooO0o_O__o..Add(key, HttpUtility.UrlDecode(array2(1)))
								End If
							End If
						Next
					ElseIf text2.StartsWith("multipart/form-data;") Then
						Dim encoding3 As Encoding = HttpFunctions.OO.0o.(Me.o0__O0.o_0.)
						HttpFunctions.OO.0o.(Me.Oo._00O_0Oo.)
						Dim bufferedStream As BufferedStream = New BufferedStream(Me.Request.InputStream)
						Dim array3 As String() = Me.Request.ContentType.Split(New Char() { ";"c })
						Dim text3 As String = ""
						For Each text4 As String In array3
							text4 = text4.Trim()
							If text4.ToLower().StartsWith("boundary=") Then
								text3 = text4
								Exit For
							End If
						Next
						text3 = text3.Replace("boundary=", "").Trim()
						Dim bytes As Byte() = encoding3.GetBytes("--" + text3 + vbCrLf)
						Dim bytes2 As Byte() = encoding3.GetBytes("--" + text3 + "--" & vbCrLf)
						Dim stream As Stream = Nothing
						Dim flag3 As Boolean = False
						Dim flag4 As Boolean = False
						Dim text5 As String = ""
						Dim text6 As String = ""
						While True
							Dim array5 As Byte() = Me.O0_OO0oOO.O_0O.(bufferedStream)
							If array5.Length = 0 Then
								GoTo IL_73A
							End If
							If Me.o.0OoO.(bytes, array5) Then
								If Operators.CompareString(text6, "", True) > 0 AndAlso stream IsNot Nothing AndAlso stream.Length > 0L Then
									Me.O0_OO0oOO.O_0O.(stream)
									If Not flag4 Then
										Dim text7 As String = encoding3.GetString(CType(stream, MemoryStream).ToArray())
										If text7.StartsWith("%") Then
											text7 = HttpUtility.UrlDecode(text7)
										End If
										If Not Me.o0__O0.o_0..ContainsKey(text6) Then
											Me.o0__O0.o_0..Add(text6, text7)
											Me.O.OOooO0o_O__o..Add(text6, text7)
										End If
									Else
										Operators.CompareString(text5, "", True)
									End If
								End If
								If stream IsNot Nothing AndAlso stream.Length > 0L Then
									stream.Close()
									stream.Dispose()
								End If
								text5 = ""
								flag4 = False
								flag3 = True
								stream = New MemoryStream()
								Dim bytes3 As Byte() = Me.O0_OO0oOO.O_0O.(bufferedStream)
								Dim bytes4 As Byte() = Me.O0_OO0oOO.O_0O.(bufferedStream)
								Dim [string] As String = encoding3.GetString(bytes3)
								Dim string2 As String = encoding3.GetString(bytes4)
								text6 = [string].Substring("Content-Disposition: form-data; name=".Length).Replace(vbCrLf, "")
								If text6.IndexOf(";") > 0 Then
									text6 = text6.Substring(0, text6.IndexOf(";"))
								End If
								If text6.StartsWith("%") Then
									text6 = HttpUtility.UrlDecode(text6)
								Else
									text6 = text6.Replace("""", "")
								End If
								If string2.Contains("Content-Type") Then
									flag4 = True
									Dim num As Integer = [string].IndexOf("filename=")
									text5 = Path.GetFileName([string].Substring(num + 9).Replace("""", "").Replace(vbCrLf, ""))
									If Operators.CompareString(text5, "", True) > 0 Then
										If Not Me.oo_OO_0._O0O..ContainsKey(text6) Then
											Me.oo_OO_0._O0O..Add(text6, New List(Of String)())
										End If
										text5 = Me.O0_OO0oOO.O_0O.(text6, text5)
										Dim text8 As String = OO_00oOO.ProjectPath + "HttpTempFiles\" + OoOo0O.OO_o.0o_O.(12)
										If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "HttpTempFiles\") Then
											OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "HttpTempFiles\")
										End If
										stream = File.Create(text8)
										Me.oo_OO_0._O0O.(text6).Add(text5)
										Me.oo_OO_0._O0O..Add(text6 + "_" + text5, text8)
									End If
								End If
							Else
								If Me.o.0OoO.(bytes2, array5) Then
									Exit For
								End If
								If flag3 Then
									Dim string3 As String = encoding3.GetString(array5)
									If Not string3.StartsWith("Content-Transfer-Encoding:", StringComparison.OrdinalIgnoreCase) Then
										flag3 = False
										If Operators.CompareString(string3, vbCrLf, True) <> 0 Then
											stream.Write(array5, 0, array5.Length)
										End If
									End If
								Else
									stream.Write(array5, 0, array5.Length)
								End If
							End If
						End While
						If Operators.CompareString(text6, "", True) > 0 AndAlso stream IsNot Nothing AndAlso stream.Length > 0L Then
							Me.O0_OO0oOO.O_0O.(stream)
							If Not flag4 Then
								Dim text9 As String = encoding3.GetString(CType(stream, MemoryStream).ToArray())
								If text9.StartsWith("%") Then
									text9 = HttpUtility.UrlDecode(text9)
								End If
								If Not Me.o0__O0.o_0..ContainsKey(text6) Then
									Me.o0__O0.o_0..Add(text6, text9)
									Me.O.OOooO0o_O__o..Add(text6, text9)
								End If
							End If
						End If
						If stream IsNot Nothing AndAlso stream.Length > 0L Then
							stream.Close()
							stream.Dispose()
						End If
						IL_73A:
						Me.Request.InputStream.Close()
						bufferedStream.Close()
					End If
				End If
			Catch a_ As Exception
				ooO.OO_oOO0O.O00.(a_)
			Finally
				Dim o0oo.Oo. As Object = OO_00oOO.HttpServer.o0oo.Oo.
				SyncLock o0oo.Oo.
					OO_00oOO.HttpServer.o.oOOoOOO..Remove(Me)
					If Not flag Then
						OO_00oOO.HttpServer.oo._o_oo_..Enqueue(Me)
					End If
				End SyncLock
			End Try
		End Sub

		' Token: 0x060017BD RID: 6077 RVA: 0x00098400 File Offset: 0x00096600
		Private Function <<EMPTY_NAME>>() As Encoding
			If Operators.CompareString(Me.Request.ContentType, "", True) > 0 Then
				For Each text As String In Me.Request.ContentType.ToLower().Split(New Char() { ";"c })
					text = text.Trim().ToLower()
					If text.StartsWith("charset") Then
						Dim array2 As String() = text.Split(New Char() { "="c })
						If array2.Length = 2 Then
							Return HttpFunctions.OO.0o.(array2(1).Trim())
						End If
					End If
				Next
			End If
			Try
				For Each o_O_O0_O As O_O_O0_O In OO_00oOO.HttpServer.o.oOOoOOO.
					If Operators.CompareString(o_O_O0_O.O0oO.o_OOoO_., "*", True) = 0 OrElse Operators.CompareString(o_O_O0_O.O0oO.o_OOoO_., Me.Host, True) = 0 Then
						If Operators.CompareString(o_O_O0_O.O.__0O., "*", True) = 0 Then
							Return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.)
						End If
						If Operators.CompareString(Me.path, o_O_O0_O.O.__0O., True) = 0 Then
							Return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.)
						End If
						If Me.path.IndexOf("/") > 0 AndAlso Me.path.StartsWith(o_O_O0_O.O.__0O. + "/") Then
							Return HttpFunctions.OO.0o.(o_O_O0_O.oO._0O_.)
						End If
					End If
				Next
			Finally
				Dim enumerator As List(Of O_O_O0_O).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return Encoding.UTF8
		End Function

		' Token: 0x060017BE RID: 6078 RVA: 0x000985AC File Offset: 0x000967AC
		Private Sub <<EMPTY_NAME>>(A_0 As Stream)
			Dim length As Long = A_0.Length
			If length > 2L Then
				A_0.Position = length - 2L
				If A_0.ReadByte() = 13 AndAlso A_0.ReadByte() = 10 Then
					A_0.SetLength(length - 2L)
				End If
			End If
		End Sub

		' Token: 0x060017BF RID: 6079 RVA: 0x000985F0 File Offset: 0x000967F0
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
			If A_1.StartsWith("image%3A", StringComparison.CurrentCultureIgnoreCase) AndAlso A_1.IndexOf(".") = -1 Then
				A_1 = A_1.Replace("%", "") + ".jpg"
			End If
			If Me.oo_OO_0._O0O..ContainsKey(A_0 + "_" + A_1) Then
				Dim num As Integer = 1
				Dim num2 As Integer = A_1.LastIndexOf(".")
				Dim text As String
				While True
					text = String.Concat(New String() { A_1.Substring(0, num2), "(", Conversions.ToString(num), ").", A_1.Substring(num2 + 1) })
					If Not Me.oo_OO_0._O0O..ContainsKey(A_0 + "_" + text) Then
						Exit For
					End If
					num += 1
				End While
				A_1 = text
			End If
			Return A_1
		End Function

		' Token: 0x060017C0 RID: 6080 RVA: 0x000986C0 File Offset: 0x000968C0
		Private Function <<EMPTY_NAME>>(A_0 As Stream) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim num As Integer
			Do
				num = A_0.ReadByte()
				If num = -1 Then
					Exit Do
				End If
				memoryStream.WriteByte(CByte(num))
			Loop While num <> 10
			Return memoryStream.ToArray()
		End Function

		' Token: 0x060017C1 RID: 6081 RVA: 0x000986F4 File Offset: 0x000968F4
		Private Function <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Byte()) As Boolean
			Dim num As Integer = A_0.Length
			Dim result As Boolean
			If A_0.Length <> A_1.Length Then
				result = False
			Else
				Dim num2 As Integer = num - 1
				For i As Integer = 0 To num2
					If A_0(i) <> A_1(i) Then
						Return False
					End If
				Next
				result = True
			End If
			Return result
		End Function

		' Token: 0x060017C2 RID: 6082 RVA: 0x00098730 File Offset: 0x00096930
		Public Sub Redirect(url As String)
			Me.o._oOOO00_o_0O. = True
			Me.Response.Redirect(url)
		End Sub

		' Token: 0x060017C3 RID: 6083 RVA: 0x00098748 File Offset: 0x00096948
		<oO0oooo("A283")>
		Public Sub AsDataServer(ConnectionName As String)
			If Operators.CompareString(ConnectionName, "", True) = 0 Then
				Me.AppendCookie("Error", "服务端不能使用内部数据源!")
				Return
			End If
			If O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName) Then
				Me.AppendCookie("Error", "服务端不能使用Web数据源!")
				Return
			End If
			If Not O_O0OO.O._o_.().ContainsKey(ConnectionName) Then
				Me.AppendCookie("Error", "服务端指定的本地数据源不存在！")
				Return
			End If
			If Operators.CompareString(ConnectionName, "", True) > 0 AndAlso o_O_o_oOoo__.OO0O_0.0O0o0_o.(New OleDbConnection(OO_00oOO.Connections(ConnectionName).ConnectionString)) Then
				Me.AppendCookie("Error", "服务端不能使用Oracle数据源!")
				Return
			End If
			If Me.PostValues.ContainsKey("Action") Then
				Me.AsyncExecute = True
				ThreadPool.QueueUserWorkItem(AddressOf Me.OO.oo., ConnectionName)
			End If
		End Sub

		' Token: 0x060017C4 RID: 6084 RVA: 0x00098818 File Offset: 0x00096A18
		<oO0oooo("A0288")>
		Public Sub AsReportServer(path As String)
			Dim text As String = O_O0OO.OoO__.0oO0oo.() + Me.path.Substring(path.Length)
			If OO_00oOO.FileSys.FileExists(text) Then
				Me.WriteFile(text, "")
			End If
		End Sub

		' Token: 0x060017C5 RID: 6085 RVA: 0x0009885C File Offset: 0x00096A5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Try
				If Me.PostValues.ContainsKey("Select") Then
					Me.PostValues("Select") = O00.oO_.0o_oo_0O_.(Me.PostValues("Select"), "fox", "table")
				End If
				Me.o.0OoO.(RuntimeHelpers.GetObjectValue(A_0))
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.Handled = True
			End Try
		End Sub

		' Token: 0x060017C6 RID: 6086 RVA: 0x000988F8 File Offset: 0x00096AF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim text As String = A_0.ToString()
			Dim oO0o0O_OO As oO0o0O_OO = CType(Conversions.ToInteger(Me.PostValues("Action")), oO0o0O_OO)
			Dim text2 As String = Me.PostValues("Datatable")
			Select Case oO0o0O_OO
				Case oO0o0O_OO.O.o__0., oO0o0O_OO.O0_0.0_.
					Dim a_ As Boolean = oO0o0O_OO = oO0o0O_OO.O.o__0.
					Dim text3 As String
					If Me.PostValues.ContainsKey("Select") Then
						text3 = Me.PostValues("Select")
					Else
						If Me.PostValues.ContainsKey("Distinct") Then
							text3 = "Select Distinct"
						Else
							text3 = "Select"
						End If
						If Me.PostValues.ContainsKey("Top") Then
							text3 = text3 + " Top " + Me.PostValues("Top")
						End If
						If Me.PostValues.ContainsKey("Fields") Then
							text3 = String.Concat(New String() { text3, " ", Me.PostValues("Fields"), " From ", text2 })
						Else
							text3 = text3 + " * From " + text2
						End If
						If Me.PostValues.ContainsKey("Where") Then
							text3 = text3 + " Where " + Me.PostValues("Where")
						End If
						If Me.PostValues.ContainsKey("OrderBy") Then
							text3 = text3 + " Order By" + Me.PostValues("Where")
						End If
					End If
					If Operators.CompareString(text3, "", True) = 0 Then
						Me.AppendCookie("Error", "未指定表或未定义查询语句!")
						Return
					End If
					Me.oO.O_0_OO.(text3, text, a_)
				Case oO0o0O_OO.O0oOO0_O.oO., oO0o0O_OO.oOo.o_o0_o0o_., oO0o0O_OO.o_o0_.Oo_.
					Me.oO.O_0_OO.(text, text2)
					Return
				Case oO0o0O_OO.OoOO.O0_00_o., oO0o0O_OO.o.oO0o00O_0.
					If Me.PostValues.ContainsKey("Select") Then
						Dim sqlcommand As SQLCommand = New SQLCommand(Me.PostValues("Select"), text)
						Dim obj As Object
						If oO0o0O_OO = oO0o0O_OO.OoOO.O0_00_o. Then
							obj = RuntimeHelpers.GetObjectValue(sqlcommand.ExecuteScalar())
						Else
							obj = sqlcommand.ExecuteNonQuery()
						End If
						If obj IsNot Nothing Then
							Me.o_O.oO.(obj.ToString())
							Return
						End If
						Me.o_O.oO.("")
						Return
					End If
				Case oO0o0O_OO.OoOo0o.00OO.
				Case oO0o0O_OO.OO.0OO0.
					Dim dataServerTypeEnum As DataServerTypeEnum
					If Operators.CompareString(text, "", True) = 0 Then
						dataServerTypeEnum = DataServerTypeEnum.Buildin
					Else
						Try
							Dim oleDbConnection As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(text).ConnectionString)
							If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
								dataServerTypeEnum = DataServerTypeEnum.Oracle
							ElseIf o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
								dataServerTypeEnum = DataServerTypeEnum.SqlServer
							Else
								dataServerTypeEnum = DataServerTypeEnum.Access
							End If
							If oO0o0O_OO = oO0o0O_OO.OO.0OO0. Then
								oleDbConnection.Open()
								oleDbConnection.Close()
							End If
						Catch ex As Exception
							Me.AppendCookie("Error", ex.Message)
						End Try
					End If
					Dim num As Integer = CInt(dataServerTypeEnum)
					Me.o_O.oO.(num.ToString())
					Return
				Case oO0o0O_OO.oO_00O._.
					Me.o_O.oO.(String.Join("|", CType(OO_00oOO.Connections(text).GetTableNames(), List(Of String)).ToArray()))
					Return
				Case oO0o0O_OO.o.Oo0oooOoo0.
					Me.o_O.oO.(String.Join("|", CType(OO_00oOO.Connections(text).GetViewNames(), List(Of String)).ToArray()))
					Return
				Case oO0o0O_OO.O_O__0.0_ooO_.
					Dim selectCommandText As String = Me.PostValues("Select")
					Dim oleDbConnection2 As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(text).ConnectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection2)
					Dim dataSet As DataSet = New DataSet()
					Dim dataTable As DataTable = New DataTable()
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection2) Then
						dataTable.TableName = "Oracle"
					ElseIf o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection2) Then
						dataTable.TableName = "SQLServer"
					Else
						dataTable.TableName = "Access"
					End If
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
					dataSet.Tables.Add(dataTable)
					Dim memoryStream As MemoryStream = New MemoryStream()
					dataSet.WriteXml(memoryStream, XmlWriteMode.WriteSchema)
					memoryStream.Position = 0L
					New oOO_O__(memoryStream, Me.Response).oO0o0o._0.(Nothing)
					Return
				Case oO0o0O_OO.Oo_0._o.
					If Me.PostValues.ContainsKey("Select") Then
						Me.O0O_.o__0O.(Me.PostValues("Select"), text)
						Return
					End If
				Case oO0o0O_OO.ooo__.O_oo.
					Me.o__.O00.(Me.PostValues("Select"), text)
					Return
				Case oO0o0O_OO.O00.Oo_00Oooo0., oO0o0O_OO.o0O.o0_0o_O0Oo.
					If Me.PostValues.ContainsKey("Select") Then
						Dim oleDbConnection3 As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(text).ConnectionString)
						Dim oleDbCommand As OleDbCommand = New OleDbCommand(Me.PostValues("Select"), oleDbConnection3)
						If Me.PostValues.ContainsKey("StoredProcedure") Then
							oleDbCommand.CommandType = CommandType.StoredProcedure
						End If
						Me.o.0OoO.(oleDbCommand)
						Dim obj2 As Object
						Try
							oleDbConnection3.Open()
							If oO0o0O_OO = oO0o0O_OO.O00.Oo_00Oooo0. Then
								obj2 = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
							Else
								obj2 = oleDbCommand.ExecuteNonQuery()
							End If
						Catch ex2 As Exception
							Me.AppendCookie("Error", ex2.Message)
							Me.o_O.oO.("")
							Exit Try
						Finally
							oleDbConnection3.Close()
						End Try
						Dim dataTable2 As DataTable = New DataTable()
						dataTable2.TableName = "ReturnValue"
						Dim dataRow As DataRow = dataTable2.NewRow()
						dataTable2.Rows.Add(dataRow)
						If obj2 Is Nothing OrElse obj2 Is DBNull.Value Then
							dataTable2.Columns.Add(OoOo0O.OO_o.0o_O.(4), GetType(String))
						Else
							dataTable2.Columns.Add(OoOo0O.OO_o.0o_O.(4), obj2.[GetType]())
						End If
						dataRow(0) = RuntimeHelpers.GetObjectValue(obj2)
						Me.oO.O_0_OO.(oleDbCommand, dataTable2)
						Me.oO.O_0_OO.(dataTable2)
						Return
					End If
				Case oO0o0O_OO.oo_.ooO., oO0o0O_OO.OOo.oOo0o_00__.
					If Me.PostValues.ContainsKey("Select") Then
						Dim oleDbConnection4 As OleDbConnection = New OleDbConnection(OO_00oOO.Connections(text).ConnectionString)
						Dim oleDbCommand2 As OleDbCommand = New OleDbCommand(Me.PostValues("Select"), oleDbConnection4)
						If Me.PostValues.ContainsKey("StoredProcedure") Then
							oleDbCommand2.CommandType = CommandType.StoredProcedure
						End If
						Me.o.0OoO.(oleDbCommand2)
						Dim dataSet2 As DataSet = New DataSet()
						Dim dataTable3 As DataTable = New DataTable()
						dataTable3.TableName = "DataTable"
						Try
							If oO0o0O_OO = oO0o0O_OO.oo_.ooO. AndAlso Not Me.PostValues.ContainsKey("IgnoreSchema") Then
								Oo00.oo_0__0.o.(oleDbCommand2.CommandText)
								New OleDbDataAdapter(oleDbCommand2.CommandText, oleDbConnection4).FillSchema(dataTable3, SchemaType.Source)
							End If
							Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter(oleDbCommand2)
							dataTable3.BeginLoadData()
							dbDataAdapter.Fill(dataTable3)
							dataTable3.EndLoadData()
							dataSet2.Tables.Add(dataTable3)
							Dim dataTable4 As DataTable = New DataTable()
							dataTable4.TableName = "Params"
							dataTable4.Columns.Add("_Columns", GetType(String))
							Dim dataRow2 As DataRow = dataTable4.NewRow()
							dataTable4.Rows.Add(dataRow2)
							Me.oO.O_0_OO.(oleDbCommand2, dataTable4)
							dataSet2.Tables.Add(dataTable4)
							If oO0o0O_OO = oO0o0O_OO.oo_.ooO. AndAlso Not Me.PostValues.ContainsKey("IgnoreSchema") AndAlso dataTable3.PrimaryKey.Length > 0 Then
								Dim str As String = Oo00.oo_0__0.o.(oleDbCommand2.CommandText)
								Dim list As List(Of String) = New List(Of String)()
								Dim dbDataAdapter2 As DbDataAdapter = New OleDbDataAdapter("Select * From " + str, oleDbConnection4)
								Dim dataTable5 As DataTable = New DataTable()
								dbDataAdapter2.FillSchema(dataTable5, SchemaType.Source)
								Try
									For Each obj3 As Object In dataTable5.Columns
										Dim dataColumn As DataColumn = CType(obj3, DataColumn)
										list.Add(dataColumn.ColumnName.ToLower())
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								dataRow2("_Columns") = String.Join("|", list.ToArray())
							End If
						Catch ex3 As Exception
							Me.AppendCookie("Error", ex3.Message)
							Me.Response.OutputStream.Close()
							Me.Response.Close()
							Me.Response.Abort()
							Exit Try
						End Try
						If dataSet2.Tables.Count > 0 Then
							dataSet2.AcceptChanges()
							Dim memoryStream2 As MemoryStream = New MemoryStream()
							dataSet2.WriteXml(memoryStream2, XmlWriteMode.WriteSchema)
							dataSet2.Dispose()
							memoryStream2.Position = 0L
							New oOO_O__(memoryStream2, Me.Response).oO0o0o._0.(Nothing)
							Return
						End If
						Me.Response.OutputStream.Close()
						Me.Response.Close()
						Me.Response.Abort()
						Return
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x060017C7 RID: 6087 RVA: 0x000991F8 File Offset: 0x000973F8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim text As String = vbVerticalTab & vbTab
			Dim text2 As String = vbTab & vbVerticalTab
			Dim text3 As String = ""
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(O_O0OO.O._o_.()(A_0).ConnectionString)
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", oleDbConnection)
			If Not A_1.StartsWith("[") AndAlso Not A_1.EndsWith("]") AndAlso Not A_1.StartsWith("(") Then
				A_1 = "[" + A_1 + "]"
			End If
			oleDbConnection.Open()
			Try
				For Each text4 As String In Me.PostValues.Keys
					If text4.StartsWith("[[Row") AndAlso text4.EndsWith("]]") Then
						Dim text5 As String = ""
						Dim text6 As String = ""
						Dim array As String() = O00.oO_.0o_oo_0O_.(Me.PostValues(text4), "fox", "table").Split(New String() { text2 }, StringSplitOptions.None)
						Dim array2 As String() = array(0).Split(New String() { text }, StringSplitOptions.None)
						Dim array3 As String() = array(1).Split(New String() { text }, StringSplitOptions.None)
						Dim num As Integer = array2.Length - 1
						For i As Integer = 0 To num Step 2
							text5 = String.Concat(New String() { text5, Interaction.IIf(Operators.CompareString(text5, "", True) > 0, ",", "Set ").ToString(), "[", array2(i), "] = ?" })
							Me.o.0OoO.(oleDbCommand, "@" + array2(i), array2(i + 1))
						Next
						Dim num2 As Integer = array3.Length - 1
						For j As Integer = 0 To num2 Step 2
							text6 = String.Concat(New String() { text6, Interaction.IIf(Operators.CompareString(text6, "", True) > 0, " And ", "").ToString(), "[", array3(j), "] =  ?" })
							Me.o.0OoO.(oleDbCommand, "@@" + array3(j), array3(j + 1))
						Next
						oleDbCommand.CommandText = String.Concat(New String() { "Update ", A_1, " ", text5, " Where ", text6 })
						Try
							Dim value As Integer = oleDbCommand.ExecuteNonQuery()
							text3 = text3 + "|" + Conversions.ToString(value)
							oleDbCommand.Parameters.Clear()
						Catch ex As Exception
							text3 = text3 + "|" + ex.Message
							Exit Try
						End Try
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			oleDbConnection.Close()
			Me.o_O.oO.(text3.Trim(New Char() { "|"c }))
		End Sub

		' Token: 0x060017C8 RID: 6088 RVA: 0x00099524 File Offset: 0x00097724
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim flag As Boolean = Me.PostValues.ContainsKey("AutoIncrement")
			Dim text As String = vbVerticalTab & vbTab
			Dim text2 As String = ""
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(O_O0OO.O._o_.()(A_0).ConnectionString)
			Dim flag2 As Boolean = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection)
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", oleDbConnection)
			If Not A_1.StartsWith("[") AndAlso Not A_1.EndsWith("]") AndAlso Not A_1.StartsWith("(") Then
				A_1 = "[" + A_1 + "]"
			End If
			oleDbConnection.Open()
			Try
				For Each text3 As String In Me.PostValues.Keys
					If text3.StartsWith("[[Row") AndAlso text3.EndsWith("]]") Then
						Dim text4 As String = Nothing
						Dim text5 As String = Nothing
						Dim array As String() = O00.oO_.0o_oo_0O_.(Me.PostValues(text3), "fox", "table").Split(New String() { text }, StringSplitOptions.None)
						Dim num As Integer = array.Length - 1
						For i As Integer = 0 To num Step 2
							text4 = String.Concat(New String() { text4, Interaction.IIf(Operators.CompareString(text4, "", True) > 0, ",", "").ToString(), "[", array(i), "]" })
							text5 = text5 + Interaction.IIf(Operators.CompareString(text5, "", True) > 0, ",", "").ToString() + "?"
							Me.o.0OoO.(oleDbCommand, "@" + array(i), array(i + 1))
						Next
						Dim text6 As String = String.Concat(New String() { "Insert into ", A_1, " (", text4, ") Values (", text5, ")" })
						If flag AndAlso flag2 Then
							text6 += ";Select @@IDENTITY"
						End If
						oleDbCommand.CommandText = text6
						Try
							Dim num2 As Integer
							If flag Then
								If flag2 Then
									num2 = Conversions.ToInteger(oleDbCommand.ExecuteScalar())
								Else
									num2 = oleDbCommand.ExecuteNonQuery()
									If num2 = 1 Then
										oleDbCommand.CommandText = "Select @@IDENTITY"
										oleDbCommand.Parameters.Clear()
										num2 = Conversions.ToInteger(oleDbCommand.ExecuteScalar())
									End If
								End If
							Else
								num2 = oleDbCommand.ExecuteNonQuery()
							End If
							oleDbCommand.Parameters.Clear()
							text2 = text2 + "|" + Conversions.ToString(num2)
						Catch ex As Exception
							text2 = text2 + "|" + ex.Message
							Exit Try
						End Try
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			oleDbConnection.Close()
			Me.o_O.oO.(text2.Trim(New Char() { "|"c }))
		End Sub

		' Token: 0x060017C9 RID: 6089 RVA: 0x00099854 File Offset: 0x00097A54
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim text As String = vbVerticalTab & vbTab
			Dim text2 As String = ""
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(O_O0OO.O._o_.()(A_0).ConnectionString)
			o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection)
			Dim oleDbCommand As OleDbCommand = New OleDbCommand("", oleDbConnection)
			If Not A_1.StartsWith("[") AndAlso Not A_1.EndsWith("]") AndAlso Not A_1.StartsWith("(") Then
				A_1 = "[" + A_1 + "]"
			End If
			oleDbConnection.Open()
			Try
				For Each text3 As String In Me.PostValues.Keys
					If text3.StartsWith("[[Row") AndAlso text3.EndsWith("]]") Then
						Dim text4 As String = Nothing
						Dim array As String() = O00.oO_.0o_oo_0O_.(Me.PostValues(text3), "fox", "table").Split(New String() { text }, StringSplitOptions.None)
						Dim num As Integer = array.Length - 1
						For i As Integer = 0 To num Step 2
							text4 = String.Concat(New String() { text4, Interaction.IIf(Operators.CompareString(text4, "", True) > 0, " And ", "").ToString(), "[", array(i), "] =  ?" })
							Me.o.0OoO.(oleDbCommand, "@@" + array(i), array(i + 1))
						Next
						oleDbCommand.CommandText = "Delete From " + A_1 + " Where " + text4
						Try
							Dim num2 As Integer = oleDbCommand.ExecuteNonQuery()
							oleDbCommand.Parameters.Clear()
							text2 = text2 + "|" + Conversions.ToString(num2)
							If num2 <> 0 AndAlso num2 <> 1 Then
								Exit Try
							End If
						Catch ex As Exception
							text2 = text2 + "|" + ex.Message
							Exit Try
						End Try
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			oleDbConnection.Close()
			Me.o_O.oO.(text2.Trim(New Char() { "|"c }))
		End Sub

		' Token: 0x060017CA RID: 6090 RVA: 0x00099AAC File Offset: 0x00097CAC
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim oO0o0O_OO As oO0o0O_OO = CType(Conversions.ToInteger(Me.PostValues("Action")), oO0o0O_OO)
			If oO0o0O_OO = oO0o0O_OO.O0oOO0_O.oO. Then
				Me.OO.O0o.(A_0, A_1)
				Return
			End If
			If oO0o0O_OO = oO0o0O_OO.oOo.o_o0_o0o_. Then
				Me.o_0_0.OO0oOo.(A_0, A_1)
				Return
			End If
			If oO0o0O_OO = oO0o0O_OO.o_o0_.Oo_. Then
				Me.Ooo_oO0.O0.(A_0, A_1)
			End If
		End Sub

		' Token: 0x060017CB RID: 6091 RVA: 0x00099AF8 File Offset: 0x00097CF8
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbCommand, A_1 As String, A_2 As String)
			Dim text As String = A_2.Substring(0, 2)
			A_2 = A_2.Substring(2)
			If Operators.CompareString(A_2, "{{null}}", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, DBNull.Value)
				Return
			End If
			Dim left As String = text
			If Operators.CompareString(left, "sr", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, A_2)
				Return
			End If
			If Operators.CompareString(left, "bl", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToBoolean(A_2))
				Return
			End If
			If Operators.CompareString(left, "dt", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, DateTime.FromBinary(Conversions.ToLong(A_2)))
				Return
			End If
			If Operators.CompareString(left, "bt", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToByte(A_2))
				Return
			End If
			If Operators.CompareString(left, "st", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToShort(A_2))
				Return
			End If
			If Operators.CompareString(left, "in", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToInteger(A_2))
				Return
			End If
			If Operators.CompareString(left, "lg", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToLong(A_2))
				Return
			End If
			If Operators.CompareString(left, "sg", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToSingle(A_2))
				Return
			End If
			If Operators.CompareString(left, "db", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToDouble(A_2))
				Return
			End If
			If Operators.CompareString(left, "dm", True) = 0 Then
				A_0.Parameters.AddWithValue(A_1, Conversions.ToDecimal(A_2))
				Return
			End If
			A_0.Parameters.AddWithValue(A_1, A_2)
		End Sub

		' Token: 0x060017CC RID: 6092 RVA: 0x00099CCC File Offset: 0x00097ECC
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbCommand)
			Try
				For Each text As String In Me.PostValues.Keys
					If text.StartsWith("@{") AndAlso text.EndsWith("}") Then
						Dim jobject As JObject = JObject.Parse(Me.PostValues(text))
						Dim oleDbParameter As OleDbParameter = A_0.Parameters.AddWithValue(jobject("Name").ToString(), RuntimeHelpers.GetObjectValue(oOO0oO000_0_0.o.oOoO___o__oO.(jobject)))
						If jobject("Return") IsNot Nothing Then
							oleDbParameter.Direction = ParameterDirection.ReturnValue
							oleDbParameter.Size = Conversions.ToInteger(jobject("Return").ToString())
						ElseIf jobject("Output") IsNot Nothing Then
							oleDbParameter.Direction = ParameterDirection.InputOutput
							oleDbParameter.Size = Conversions.ToInteger(jobject("Output").ToString())
						End If
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x060017CD RID: 6093 RVA: 0x00099DDC File Offset: 0x00097FDC
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbCommand, A_1 As DataTable)
			Dim dataRow As DataRow = A_1.Rows(0)
			Try
				For Each obj As Object In A_0.Parameters
					Dim oleDbParameter As OleDbParameter = CType(obj, OleDbParameter)
					If(oleDbParameter.Direction = ParameterDirection.InputOutput Or oleDbParameter.Direction = ParameterDirection.Output) OrElse oleDbParameter.Direction = ParameterDirection.ReturnValue Then
						If oleDbParameter.IsNullable Then
							A_1.Columns.Add(oleDbParameter.ParameterName, GetType(String))
						Else
							A_1.Columns.Add(oleDbParameter.ParameterName, oleDbParameter.Value.[GetType]())
							dataRow(oleDbParameter.ParameterName) = RuntimeHelpers.GetObjectValue(oleDbParameter.Value)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060017CE RID: 6094 RVA: 0x00099EBC File Offset: 0x000980BC
		Private Sub <<EMPTY_NAME>>(Optional A_0 As String = "")
			Dim text As String = ""
			If Operators.CompareString(A_0, "", True) > 0 Then
				text = Path.GetExtension(A_0)
			End If
			Dim left As String = text.ToLower()
			If Operators.CompareString(left, ".zip", True) <> 0 AndAlso Operators.CompareString(left, ".rar", True) <> 0 AndAlso Operators.CompareString(left, ".png", True) <> 0 AndAlso Operators.CompareString(left, ".jpg", True) <> 0 AndAlso Operators.CompareString(left, ".gif", True) <> 0 AndAlso Operators.CompareString(left, ".xlsx", True) <> 0 AndAlso Operators.CompareString(left, ".docx", True) <> 0 AndAlso Me.o0__O0.o_0..Headers("Accept-Encoding") IsNot Nothing Then
				If Me.o0__O0.o_0..Headers("Accept-Encoding").Contains("gzip") Then
					Me.o0__O0.o_0..AddHeader("Content-Encoding", "gzip")
					Return
				End If
				If Me.o0__O0.o_0..Headers("Accept-Encoding").Contains("deflate") Then
					Me.o0__O0.o_0..AddHeader("Content-Encoding", "deflate")
				End If
			End If
		End Sub

		' Token: 0x04000980 RID: 2432
		Private <<EMPTY_NAME>> As HttpListenerContext

		' Token: 0x04000981 RID: 2433
		Private <<EMPTY_NAME>> As HttpListenerRequest

		' Token: 0x04000982 RID: 2434
		Private <<EMPTY_NAME>> As HttpListenerResponse

		' Token: 0x04000983 RID: 2435
		Friend <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000984 RID: 2436
		Friend <<EMPTY_NAME>> As Dictionary(Of String, List(Of String))

		' Token: 0x04000985 RID: 2437
		Friend <<EMPTY_NAME>> As HttpDictionary

		' Token: 0x04000986 RID: 2438
		Private <<EMPTY_NAME>> As HttpDictionary

		' Token: 0x04000987 RID: 2439
		Private <<EMPTY_NAME>> As HttpDictionary

		' Token: 0x04000988 RID: 2440
		Private <<EMPTY_NAME>> As HttpDictionary

		' Token: 0x04000989 RID: 2441
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400098A RID: 2442
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400098B RID: 2443
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400098C RID: 2444
		Private <<EMPTY_NAME>> As Object

		' Token: 0x0400098D RID: 2445
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400098E RID: 2446
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400098F RID: 2447
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000990 RID: 2448
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000991 RID: 2449
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000992 RID: 2450
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000993 RID: 2451
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000994 RID: 2452
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
