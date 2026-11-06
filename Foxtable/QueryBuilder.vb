Imports System
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000289 RID: 649
	<ComVisible(True)>
	<oO0oooo("0695")>
	Public Class QueryBuilder
		' Token: 0x06001F9A RID: 8090 RVA: 0x000D055A File Offset: 0x000CE75A
		Public Sub New()
			Me.Oo_O.0o0_. = False
			Me.Oo.O0OOo0. = True
			Me.oO0000.OO0oo. = 30
		End Sub

		' Token: 0x06001F9B RID: 8091 RVA: 0x000D0578 File Offset: 0x000CE778
		Public Sub New(A_0 As String)
			Me.Oo_O.0o0_. = False
			Me.Oo.O0OOo0. = True
			Me.oO0000.OO0oo. = 30
			Me.TableName = A_0
		End Sub

		' Token: 0x17000728 RID: 1832
		' (get) Token: 0x06001F9C RID: 8092 RVA: 0x000D059D File Offset: 0x000CE79D
		' (set) Token: 0x06001F9D RID: 8093 RVA: 0x000D05A5 File Offset: 0x000CE7A5
		Public Property SelectString As String
			Get
				Return Me.Oo_O.0o0_.
			End Get
			Set(value As String)
				Me.Oo_O.0o0_. = value
			End Set
		End Property

		' Token: 0x17000729 RID: 1833
		' (get) Token: 0x06001F9E RID: 8094 RVA: 0x000D05AE File Offset: 0x000CE7AE
		' (set) Token: 0x06001F9F RID: 8095 RVA: 0x000D05B6 File Offset: 0x000CE7B6
		Public Property ConnectionName As String
			Get
				Return Me.OO.o_Oo.
			End Get
			Set(value As String)
				Me.OO.o_Oo. = value
			End Set
		End Property

		' Token: 0x1700072A RID: 1834
		' (get) Token: 0x06001FA0 RID: 8096 RVA: 0x000D05BF File Offset: 0x000CE7BF
		' (set) Token: 0x06001FA1 RID: 8097 RVA: 0x000D05C7 File Offset: 0x000CE7C7
		Public Property TableName As String
			Get
				Return Me.O.oooo_o.
			End Get
			Set(value As String)
				Me.O.oooo_o. = value
			End Set
		End Property

		' Token: 0x1700072B RID: 1835
		' (get) Token: 0x06001FA2 RID: 8098 RVA: 0x000D05D0 File Offset: 0x000CE7D0
		' (set) Token: 0x06001FA3 RID: 8099 RVA: 0x000D05D8 File Offset: 0x000CE7D8
		Public Property TableCaption As String
			Get
				Return Me.o_O.00o.
			End Get
			Set(value As String)
				Me.o_O.00o. = value
			End Set
		End Property

		' Token: 0x1700072C RID: 1836
		' (get) Token: 0x06001FA4 RID: 8100 RVA: 0x000D05E1 File Offset: 0x000CE7E1
		' (set) Token: 0x06001FA5 RID: 8101 RVA: 0x000D05E9 File Offset: 0x000CE7E9
		Friend Property IsDataTable As Boolean
			Get
				Return Me.Oo_O.0o0_.
			End Get
			Set(value As Boolean)
				Me.Oo_O.0o0_. = value
			End Set
		End Property

		' Token: 0x1700072D RID: 1837
		' (get) Token: 0x06001FA6 RID: 8102 RVA: 0x000D05F2 File Offset: 0x000CE7F2
		' (set) Token: 0x06001FA7 RID: 8103 RVA: 0x000D05FA File Offset: 0x000CE7FA
		Public Property TableVisible As Boolean
			Get
				Return Me.Oo.O0OOo0.
			End Get
			Set(value As Boolean)
				Me.Oo.O0OOo0. = value
			End Set
		End Property

		' Token: 0x1700072E RID: 1838
		' (get) Token: 0x06001FA8 RID: 8104 RVA: 0x000D0603 File Offset: 0x000CE803
		' (set) Token: 0x06001FA9 RID: 8105 RVA: 0x000D060B File Offset: 0x000CE80B
		Public Property TimeOut As Integer
			Get
				Return Me.oO0000.OO0oo.
			End Get
			Set(value As Integer)
				Me.oO0000.OO0oo. = value
			End Set
		End Property

		' Token: 0x06001FAA RID: 8106 RVA: 0x000D0614 File Offset: 0x000CE814
		Public Function Build() As DataTable
			Dim a_ As String = ""
			Dim result As DataTable
			If Operators.CompareString(Me.TableName, "", True) = 0 OrElse Operators.CompareString(Me.SelectString, "", True) = 0 Then
				result = Nothing
			Else
				If Me.IsDataTable Then
					a_ = "?"
				End If
				Dim left As String = OO_00oOO.MainTable.Name
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim o0O As O0O = Nothing
				Dim httpClient As HttpClient = Nothing
				If OO_00oOO.DataTables.Contains(Me.TableName) Then
					If OO_00oOO.DataTables(Me.TableName).AddByCode Then
						OO_00oOO.DataTables.Delete(Me.TableName)
					End If
					If OO_00oOO.DataTables.Contains(Me.TableName) Then
						MessageBox.Show("表" + Me.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return Nothing
					End If
				End If
				If Operators.CompareString(Me.ConnectionName, "", True) > 0 Then
					If O_O0OO.O._o_.().ContainsKey(Me.ConnectionName) Then
						oleDbConnection = O_O0OO.O._o_.()(Me.ConnectionName)
						Me.SelectString = Oo00.o0_o._O_.(oleDbConnection, Me.SelectString, False)
					ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.ConnectionName) Then
						o0O = O_O0OO.OoO__.0oO0oo.()(Me.ConnectionName)
						Me.SelectString = Oo00.o0_o._O_.(o0O.OO.OoO0., Me.SelectString, False)
						httpClient = o0O.oO0_0.o.()
						httpClient.[Select] = Me.SelectString
						If Me.IsDataTable Then
							httpClient.FormData("Action") = 1.ToString()
						Else
							httpClient.FormData("Action") = 2.ToString()
						End If
					End If
					If oleDbConnection Is Nothing AndAlso o0O Is Nothing Then
						MessageBox.Show("不存在名为""" + Me.ConnectionName + """的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return Nothing
					End If
				Else
					oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
				End If
				o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, Me.SelectString, Me.TableName, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), Me.TimeOut, Nothing, Me.ConnectionName, httpClient)
				If OO_00oOO.DataTables.Contains(Me.TableName) Then
					OO_00oOO.DataTables(Me.TableName).o.0O000_.()
					OO_00oOO.DataTables(Me.TableName).AddByCode = True
					OO_00oOO.DataTables(Me.TableName).Caption = Me.TableCaption
					OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(Me.TableName))
					Main.OO_O.o..o0_o_o_0.0O.(Me.TableName, Me.TableVisible, False)
					If Operators.CompareString(left, Me.TableName, True) = 0 Then
						OO_00oOO.MainTable = OO_00oOO.Tables(Me.TableName)
					End If
					result = OO_00oOO.DataTables(Me.TableName)
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x04000D27 RID: 3367
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D28 RID: 3368
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D29 RID: 3369
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D2A RID: 3370
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D2B RID: 3371
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D2C RID: 3372
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D2D RID: 3373
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
