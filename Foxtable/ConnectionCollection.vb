Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000291 RID: 657
	<oO0oooo("1944")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ConnectionCollection
		Implements IEnumerable(Of Connection)

		' Token: 0x06002031 RID: 8241 RVA: 0x000D6613 File Offset: 0x000D4813
		Public Sub New()
			Me.Oo___.ooooO00. = New Dictionary(Of OleDbConnection, OleDbTransaction)()
		End Sub

		' Token: 0x1700074F RID: 1871
		' (get) Token: 0x06002032 RID: 8242 RVA: 0x000D6626 File Offset: 0x000D4826
		Public ReadOnly Property Count As Integer
			Get
				Return O_O0OO.O._o_.().Count + O_O0OO.OoO__.0oO0oo.().Count
			End Get
		End Property

		' Token: 0x06002033 RID: 8243 RVA: 0x000D6640 File Offset: 0x000D4840
		Public Function Contains(ConnectionName As String) As Boolean
			Dim result As Boolean
			If O_O0OO.O._o_.().ContainsKey(ConnectionName) OrElse O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName) Then
				result = True
			Else
				Try
					Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(enumerator.Current, ConnectionName, True) = 0 Then
							Return True
						End If
					End While
				Finally
					Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Try
					Dim enumerator2 As Dictionary(Of String, O0O).KeyCollection.Enumerator = O_O0OO.OoO__.0oO0oo.().Keys.GetEnumerator()
					While enumerator2.MoveNext()
						If Operators.CompareString(enumerator2.Current, ConnectionName, True) = 0 Then
							Return True
						End If
					End While
				Finally
					Dim enumerator2 As Dictionary(Of String, O0O).KeyCollection.Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x17000750 RID: 1872
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Connection
			Get
				Dim index As Integer = -1
				Dim result As Connection
				If Integer.TryParse(A_0.ToString(), index) Then
					result = Me.get_Item(index)
				Else
					result = Me.get_Item(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000751 RID: 1873
		' (get) Token: 0x06002035 RID: 8245 RVA: 0x000D6748 File Offset: 0x000D4948
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(ConnectionName As String) As Connection
			Get
				Dim result As Connection
				If O_O0OO.O._o_.().ContainsKey(ConnectionName) Then
					Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(ConnectionName)
					result = New Connection(ConnectionName, oleDbConnection.ConnectionString)
				ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName) Then
					result = New Connection(ConnectionName, O_O0OO.OoO__.0oO0oo.()(ConnectionName).oO0_0.o.())
				Else
					Try
						For Each text As String In O_O0OO.O._o_.().Keys
							If Operators.CompareString(text, ConnectionName, True) = 0 Then
								Dim oleDbConnection2 As OleDbConnection = O_O0OO.O._o_.()(text)
								Return New Connection(text, oleDbConnection2.ConnectionString)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Try
						For Each text2 As String In O_O0OO.OoO__.0oO0oo.().Keys
							If Operators.CompareString(text2, ConnectionName, True) = 0 Then
								Return New Connection(text2, O_O0OO.OoO__.0oO0oo.()(text2).oO0_0.o.())
							End If
						Next
					Finally
						Dim enumerator2 As Dictionary(Of String, O0O).KeyCollection.Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					MessageBox.Show("不存在名为""" + ConnectionName + """的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000752 RID: 1874
		' (get) Token: 0x06002036 RID: 8246 RVA: 0x000D68A0 File Offset: 0x000D4AA0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Index As Integer) As Connection
			Get
				If Index <= O_O0OO.O._o_.().Count + O_O0OO.OoO__.0oO0oo.().Count - 1 Then
					Dim num As Integer
					Try
						For Each text As String In O_O0OO.O._o_.().Keys
							If num = Index Then
								Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(text)
								Return New Connection(text, oleDbConnection.ConnectionString)
							End If
							num += 1
						Next
					Finally
						Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Try
						For Each text2 As String In O_O0OO.OoO__.0oO0oo.().Keys
							If num = Index Then
								Return New Connection(text2, O_O0OO.OoO__.0oO0oo.()(text2).oO0_0.o.())
							End If
							num += 1
						Next
					Finally
						Dim enumerator2 As Dictionary(Of String, O0O).KeyCollection.Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
				Return Nothing
			End Get
		End Property

		' Token: 0x06002037 RID: 8247 RVA: 0x000D699C File Offset: 0x000D4B9C
		Public Sub Delete(ConnectionName As String)
			Try
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current.ConnectionName, ConnectionName, True) = 0 Then
						MessageBox.Show("该数据源仍在使用，不能被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End While
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			O_O0OO.O._o_.().Remove(ConnectionName)
			O_O0OO.o_Oo_000_.0o_0.().Remove(ConnectionName)
			O_O0OO.OoO__.0oO0oo.().Remove(ConnectionName)
		End Sub

		' Token: 0x06002038 RID: 8248 RVA: 0x000D6A28 File Offset: 0x000D4C28
		Public Sub Add(ConnectionName As String, ConnectionString As String)
			Try
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current, ConnectionName, True) = 0 Then
						MessageBox.Show("数据连接""" + ConnectionName + """已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				End While
			Finally
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				If ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
					Dim o0O As O0O = New O0O(ConnectionString)
					If o0O.OO._o_OO.() Then
						O_O0OO.OoO__.0oO0oo.().Add(ConnectionName, o0O)
					End If
				Else
					Dim o_0oOo_OO As O_0oOo_OO = New O_0oOo_OO()
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(ConnectionString)
					oleDbConnection.Open()
					o_0oOo_OO.oo.00O0__o.(True)
					oleDbConnection.Close()
					O_O0OO.O._o_.().Add(ConnectionName, oleDbConnection)
					O_O0OO.o_Oo_000_.0o_0.().Add(ConnectionName, o_0oOo_OO)
				End If
			Catch ex As Exception
				MessageBox.Show("创建外部连接""" + ConnectionName + """失败，原因：" & vbCrLf & vbCrLf + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06002039 RID: 8249 RVA: 0x000D6B58 File Offset: 0x000D4D58
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function TestConnString(ConnectionString As String, Optional ByRef ErrMsg As String = "") As Boolean
			Dim result As Boolean
			Try
				If ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
					result = New O0O(ConnectionString).OO._o_OO.()
				Else
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(ConnectionString)
					oleDbConnection.Open()
					oleDbConnection.Close()
					result = True
				End If
			Catch ex As Exception
				ErrMsg = ex.Message
				result = False
			End Try
			Return result
		End Function

		' Token: 0x0600203A RID: 8250 RVA: 0x000D6BD0 File Offset: 0x000D4DD0
		Public Function TryConnect(ConnectionString As String, Optional ByRef ErrMsg As String = "") As Boolean
			Return Me.TestConnString(ConnectionString, ErrMsg)
		End Function

		' Token: 0x0600203B RID: 8251 RVA: 0x000D6BDA File Offset: 0x000D4DDA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Connection) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Connection).GetEnumerator
			Return New oO0OOo0o__()
		End Function

		' Token: 0x0600203C RID: 8252 RVA: 0x000D6BE1 File Offset: 0x000D4DE1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New oO0OOo0o__()
		End Function

		' Token: 0x04000D55 RID: 3413
		Friend <<EMPTY_NAME>> As Dictionary(Of OleDbConnection, OleDbTransaction)
	End Class
End Namespace
