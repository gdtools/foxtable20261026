Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000290 RID: 656
	<ComVisible(True)>
	Public Class Connection
		' Token: 0x06002020 RID: 8224 RVA: 0x000D5EB9 File Offset: 0x000D40B9
		Public Sub New(A_0 As String, A_1 As String)
			Me.Oo___.ooooO00. = A_0
			Me.o0_O.00. = A_1
		End Sub

		' Token: 0x17000747 RID: 1863
		' (get) Token: 0x06002021 RID: 8225 RVA: 0x000D5ECF File Offset: 0x000D40CF
		Public ReadOnly Property Name As String
			Get
				Return Me.Oo___.ooooO00.
			End Get
		End Property

		' Token: 0x17000748 RID: 1864
		' (get) Token: 0x06002022 RID: 8226 RVA: 0x000D5ED7 File Offset: 0x000D40D7
		Public ReadOnly Property ConnectionString As String
			Get
				Return Me.o0_O.00.
			End Get
		End Property

		' Token: 0x17000749 RID: 1865
		' (get) Token: 0x06002023 RID: 8227 RVA: 0x000D5EE0 File Offset: 0x000D40E0
		Public ReadOnly Property Type As Integer
			Get
				Dim result As Integer
				If Me.ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse Me.ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
					result = 1
				Else
					result = 0
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700074A RID: 1866
		' (get) Token: 0x06002024 RID: 8228 RVA: 0x000D5F1C File Offset: 0x000D411C
		<oO0oooo("A286")>
		Public ReadOnly Property FormData As Dictionary(Of String, String)
			Get
				Dim result As Dictionary(Of String, String)
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					result = O_O0OO.OoO__.0oO0oo.()(Me.Name).oOOO.000_O.()
				Else
					result = New Dictionary(Of String, String)()
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700074B RID: 1867
		' (get) Token: 0x06002025 RID: 8229 RVA: 0x000D5F5C File Offset: 0x000D415C
		<oO0oooo("A286")>
		Public ReadOnly Property Cookies As Dictionary(Of String, String)
			Get
				Dim result As Dictionary(Of String, String)
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					result = O_O0OO.OoO__.0oO0oo.()(Me.Name).oO0_0.o.()
				Else
					result = New Dictionary(Of String, String)()
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700074C RID: 1868
		' (get) Token: 0x06002026 RID: 8230 RVA: 0x000D5F9C File Offset: 0x000D419C
		' (set) Token: 0x06002027 RID: 8231 RVA: 0x000D5FD2 File Offset: 0x000D41D2
		Public Property TimeOut As Integer
			Get
				Dim result As Integer
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					result = O_O0OO.OoO__.0oO0oo.()(Me.Name).OO._o_OO.()
				End If
				Return result
			End Get
			Set(value As Integer)
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					O_O0OO.OoO__.0oO0oo.()(Me.Name).OO.OoO0.(value)
				End If
			End Set
		End Property

		' Token: 0x1700074D RID: 1869
		' (get) Token: 0x06002028 RID: 8232 RVA: 0x000D5FFC File Offset: 0x000D41FC
		' (set) Token: 0x06002029 RID: 8233 RVA: 0x000D603A File Offset: 0x000D423A
		<oO0oooo("A286")>
		Public Property DataServer As String
			Get
				Dim result As String
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					result = O_O0OO.OoO__.0oO0oo.()(Me.Name).oOOO.000_O.()
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					O_O0OO.OoO__.0oO0oo.()(Me.Name).O_0_O_0_o_.0.(value)
				End If
			End Set
		End Property

		' Token: 0x0600202A RID: 8234 RVA: 0x000D6064 File Offset: 0x000D4264
		Public Function GetTableNames() As Object
			Dim list As List(Of String) = New List(Of String)()
			If O_O0OO.O._o_.().ContainsKey(Me.Name) Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(Me.Name)
				oleDbConnection.Open()
				Dim dataTable As DataTable
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
					Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", oleDbConnection)
					dataTable = New DataTable()
					dbDataAdapter.Fill(dataTable)
					Try
						For Each obj As Object In dataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							list.Add(String.Concat(New String() { """", dataRow("OWNER").ToString(), """.""", dataRow("TABLE_NAME").ToString(), """" }))
						Next
						GoTo IL_1B3
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				dataTable = oleDbConnection.GetSchema("Tables")
				For Each dataRow2 As DataRow In dataTable.[Select]("[TABLE_TYPE]='TABLE'")
					Dim text As String = Conversions.ToString(dataRow2("TABLE_NAME"))
					If Not dataRow2.IsNull("TABLE_SCHEMA") AndAlso Operators.CompareString(dataRow2("TABLE_SCHEMA").ToString(), "dbo", True) <> 0 Then
						text = String.Concat(New String() { "[", dataRow2("TABLE_SCHEMA").ToString(), "].[", text, "]" })
					End If
					If Not text.StartsWith("~") Then
						list.Add(text)
					End If
				Next
				IL_1B3:
				oleDbConnection.Close()
			ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
				list = O_O0OO.OoO__.0oO0oo.()(Me.Name).OO._o_OO.()
			End If
			Dim result As Object
			If ooO.o.O_0000_O.() Then
				result = list.ToArray()
			Else
				result = list
			End If
			Return result
		End Function

		' Token: 0x0600202B RID: 8235 RVA: 0x000D6278 File Offset: 0x000D4478
		Public Function GetViewNames() As Object
			Dim list As List(Of String) = New List(Of String)()
			If O_O0OO.O._o_.().ContainsKey(Me.Name) Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(Me.Name)
				oleDbConnection.Open()
				Dim dataTable As DataTable
				If o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
					Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,view_name from all_views where owner not LIKE '%SYS%'", oleDbConnection)
					dataTable = New DataTable()
					dbDataAdapter.Fill(dataTable)
					Try
						For Each obj As Object In dataTable.Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							list.Add(String.Concat(New String() { """", dataRow("OWNER").ToString(), """.""", dataRow("VIEW_NAME").ToString(), """" }))
						Next
						GoTo IL_13C
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				dataTable = oleDbConnection.GetSchema("Tables")
				Dim array As DataRow() = dataTable.[Select]("[TABLE_TYPE]='VIEW'")
				For i As Integer = 0 To array.Length - 1
					Dim text As String = Conversions.ToString(array(i)("TABLE_NAME"))
					If Not text.StartsWith("~") Then
						list.Add(text)
					End If
				Next
				IL_13C:
				oleDbConnection.Close()
			Else
				list = O_O0OO.OoO__.0oO0oo.()(Me.Name).O_0_O_0_o_.0.()
			End If
			Dim result As Object
			If ooO.o.O_0000_O.() Then
				result = list.ToArray()
			Else
				result = list
			End If
			Return result
		End Function

		' Token: 0x1700074E RID: 1870
		' (get) Token: 0x0600202C RID: 8236 RVA: 0x000D6404 File Offset: 0x000D4604
		Public ReadOnly Property SourceType As Integer
			Get
				Dim result As Integer
				If O_O0OO.O._o_.().ContainsKey(Me.Name) Then
					result = CInt(Oo00.OoO_.__o.(O_O0OO.O._o_.()(Me.Name)))
				ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					Dim oo.OoO0. As DataServerTypeEnum = O_O0OO.OoO__.0oO0oo.()(Me.Name).OO.OoO0.
					If oo.OoO0. = DataServerTypeEnum.Access OrElse oo.OoO0. = DataServerTypeEnum.Buildin Then
						result = 1
					Else
						result = CInt(O_O0OO.OoO__.0oO0oo.()(Me.Name).OO.OoO0.)
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600202D RID: 8237 RVA: 0x000D6488 File Offset: 0x000D4688
		<oO0oooo("2933")>
		Public Sub BeginTransaction()
			If Me.Oo___.ooooO00.() Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(Me.Name)
				If Not OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
					If oleDbConnection.State <> ConnectionState.Open Then
						oleDbConnection.Open()
					End If
					Dim value As OleDbTransaction = oleDbConnection.BeginTransaction()
					OO_00oOO.Connections.Oo___.ooooO00..Add(oleDbConnection, value)
				End If
			End If
		End Sub

		' Token: 0x0600202E RID: 8238 RVA: 0x000D64E8 File Offset: 0x000D46E8
		<oO0oooo("2933")>
		Public Sub Commit()
			If Me.Oo___.ooooO00.() Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(Me.Name)
				If OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
					Dim oleDbTransaction As OleDbTransaction = OO_00oOO.Connections.Oo___.ooooO00.(oleDbConnection)
					OO_00oOO.Connections.Oo___.ooooO00..Remove(oleDbConnection)
					oleDbTransaction.Commit()
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
					End If
				End If
			End If
		End Sub

		' Token: 0x0600202F RID: 8239 RVA: 0x000D6558 File Offset: 0x000D4758
		<oO0oooo("2933")>
		Public Sub Rollback()
			If Me.Oo___.ooooO00.() Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(Me.Name)
				If OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection) Then
					Dim oleDbTransaction As OleDbTransaction = OO_00oOO.Connections.Oo___.ooooO00.(oleDbConnection)
					OO_00oOO.Connections.Oo___.ooooO00..Remove(oleDbConnection)
					oleDbTransaction.Rollback()
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
					End If
				End If
			End If
		End Sub

		' Token: 0x06002030 RID: 8240 RVA: 0x000D65C8 File Offset: 0x000D47C8
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Not O_O0OO.O._o_.().ContainsKey(Me.Name) Then
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Name) Then
					MessageBox.Show("Web数据源不支持事务", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x04000D53 RID: 3411
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D54 RID: 3412
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
