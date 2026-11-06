Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002C6 RID: 710
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OOO__0oo_oo
		' Token: 0x060025F2 RID: 9714 RVA: 0x00102109 File Offset: 0x00100309
		Public Sub New()
			Me.OO.0o. = New List(Of String)()
		End Sub

		' Token: 0x060025F3 RID: 9715 RVA: 0x0010211C File Offset: 0x0010031C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OOO__0oo_oo.oOOO)
			Dim oOOO As OOO__0oo_oo.oOOO = Me.OO.0o.
			Dim oOOO2 As OOO__0oo_oo.oOOO
			Do
				oOOO2 = oOOO
				Dim value As OOO__0oo_oo.oOOO = CType([Delegate].Combine(oOOO2, A_0), OOO__0oo_oo.oOOO)
				oOOO = Interlocked.CompareExchange(Of OOO__0oo_oo.oOOO)(Me.OO.0o., value, oOOO2)
			Loop While oOOO IsNot oOOO2
		End Sub

		' Token: 0x060025F4 RID: 9716 RVA: 0x00102154 File Offset: 0x00100354
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OOO__0oo_oo.oOOO)
			Dim oOOO As OOO__0oo_oo.oOOO = Me.OO.0o.
			Dim oOOO2 As OOO__0oo_oo.oOOO
			Do
				oOOO2 = oOOO
				Dim value As OOO__0oo_oo.oOOO = CType([Delegate].Remove(oOOO2, A_0), OOO__0oo_oo.oOOO)
				oOOO = Interlocked.CompareExchange(Of OOO__0oo_oo.oOOO)(Me.OO.0o., value, oOOO2)
			Loop While oOOO IsNot oOOO2
		End Sub

		' Token: 0x060025F5 RID: 9717 RVA: 0x00102189 File Offset: 0x00100389
		Public Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			Me.OO.0o. = A_0
			Me.oO0Oo0o_.o. = A_1
			Me.oO0Oo0o_.o. = A_2
			Me.OO.0o. = AddressOf Me.O_o0.0oo0_o.
			Me.OO.0o..Start()
		End Sub

		' Token: 0x060025F6 RID: 9718 RVA: 0x001021C4 File Offset: 0x001003C4
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.OO.0o. Is Nothing
		End Function

		' Token: 0x060025F7 RID: 9719 RVA: 0x001021E0 File Offset: 0x001003E0
		Public Sub <<EMPTY_NAME>>()
			Me.OO.0o. = True
		End Sub

		' Token: 0x060025F8 RID: 9720 RVA: 0x001021EC File Offset: 0x001003EC
		Public Sub <<EMPTY_NAME>>()
			Dim httpWebResponse As HttpWebResponse = Nothing
			Dim fileStream As FileStream = Nothing
			Dim stream As Stream = Nothing
			Try
				Dim text As String = Me.oO0Oo0o_.o. + ".fxdlif"
				Dim array As Byte() = New Byte(1024) {}
				If Me.o0O_.0o0_oO. Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.o0O_.0o0_oO., New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(Me.o0O_.0o0_oO., flag)
					If Me.o0O_.0o0_oO..State = 0S Then
						Me.o0O_.0o0_oO..State = 2S
						Me.o0O_.0o0_oO. = Nothing
					ElseIf Me.o0O_.0o0_oO..State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.o0O_.0o0_oO..State = 1S
					If flag Then
						Monitor.[Exit](Me.o0O_.0o0_oO.)
					End If
				End Try
				Me.OO.0o. = False
				Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(Me.OO.0o.), HttpWebRequest)
				httpWebRequest.Timeout = 8000
				httpWebRequest.ReadWriteTimeout = 8000
				If OO_00oOO.FileSys.FileExists(text) Then
					If Me.OO.0o..Contains(Me.OO.0o..ToLower()) Then
						fileStream = File.Open(text, FileMode.Append)
						httpWebRequest.AddRange(CInt(fileStream.Length))
					Else
						OO_00oOO.FileSys.DeleteFile(text)
						fileStream = File.Create(text)
					End If
				Else
					Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text)
					If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
						OO_00oOO.FileSys.CreateDirectory(parentPath)
					End If
					fileStream = File.Create(text)
				End If
				httpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
				If OO_00oOO.FileSys.FileExists(Me.oO0Oo0o_.o.) AndAlso Me.oO0Oo0o_.o. Then
					If Operators.CompareString(Me.o._O_o_Oo., OO_00oOO.ProjectFile, True) <> 0 OrElse Me.o0O_.0o0_oO. Is Nothing Then
						Me.o._O_o_Oo. = OO_00oOO.ProjectFile
						Dim text2 As String = OO_00oOO.ProjectPath + "RemoteFiles\_foxdownloadinfo.mdb"
						If OO_00oOO.FileSys.FileExists(text2) Then
							Me.o0O_.0o0_oO. = New OleDbConnection(Oo00.o_._0OOo.(text2))
							Me.o0O_.0o0_oO. = New OleDbDataAdapter("", Me.o0O_.0o0_oO.)
						Else
							Me.o0O_.0o0_oO. = Nothing
							Me.o0O_.0o0_oO. = Nothing
						End If
					End If
					If Me.o0O_.0o0_oO. IsNot Nothing Then
						Dim dataTable As DataTable = New DataTable()
						Me.o0O_.0o0_oO..SelectCommand.CommandText = "Select * From [Files] Where [remfile] = '" + Me.OO.0o. + "'"
						Me.o0O_.0o0_oO..Fill(dataTable)
						If dataTable.Rows.Count > 0 Then
							Dim dataRow As DataRow = dataTable.Rows(0)
							Dim fileInfo As FileInfo = New FileInfo(Me.oO0Oo0o_.o.)
							If Operators.CompareString(dataRow("remtime").ToString(), httpWebResponse.LastModified.Ticks.ToString(), True) = 0 AndAlso Operators.CompareString(dataRow("remsize").ToString(), httpWebResponse.ContentLength.ToString(), True) = 0 AndAlso fileInfo.Length = httpWebResponse.ContentLength AndAlso Operators.CompareString(dataRow("loctime").ToString(), fileInfo.LastWriteTime.Ticks.ToString(), True) = 0 Then
								httpWebResponse.Close()
								fileStream.Close()
								Dim oo.0o. As OOO__0oo_oo.oOOO = Me.OO.0o.
								If oo.0o. IsNot Nothing Then
									oo.0o.(True, Me.OO.0o., Me.oO0Oo0o_.o., True)
								End If
								If OO_00oOO.FileSys.FileExists(text) Then
									OO_00oOO.FileSys.DeleteFile(text)
								End If
								Return
							End If
						End If
					End If
				End If
				stream = httpWebResponse.GetResponseStream()
				If Me.OO.0o..Contains(Me.OO.0o..ToLower()) Then
					Me.OO.0o..Remove(Me.OO.0o..ToLower())
				End If
				Dim i As Integer = stream.Read(array, 0, array.Length)
				While i > 0
					fileStream.Write(array, 0, i)
					If Me.OO.0o. Then
						Dim oo.0o.2 As OOO__0oo_oo.oOOO = Me.OO.0o.
						If oo.0o.2 IsNot Nothing Then
							oo.0o.2(False, Me.OO.0o., Me.oO0Oo0o_.o., False)
						End If
						If Not Me.OO.0o..Contains(Me.OO.0o..ToLower()) Then
							Me.OO.0o..Add(Me.OO.0o..ToLower())
							Exit While
						End If
						Exit While
					Else
						i = stream.Read(array, 0, array.Length)
					End If
				End While
				stream.Close()
				fileStream.Close()
				httpWebResponse.Close()
				If OO_00oOO.FileSys.FileExists(Me.oO0Oo0o_.o.) Then
					OO_00oOO.FileSys.DeleteFile(Me.oO0Oo0o_.o.)
				End If
				If Not Me.OO.0o. Then
					OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(Me.oO0Oo0o_.o.))
					Dim fileInfo2 As FileInfo = New FileInfo(Me.oO0Oo0o_.o.)
					Oo00.o0_o._O_.(Me.OO.0o., httpWebResponse.LastModified.Ticks.ToString(), fileInfo2.Length.ToString(), fileInfo2.LastWriteTime.Ticks.ToString())
					Dim oo.0o.3 As OOO__0oo_oo.oOOO = Me.OO.0o.
					If oo.0o.3 IsNot Nothing Then
						oo.0o.3(True, Me.OO.0o., Me.oO0Oo0o_.o., False)
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("""" + Me.OO.0o. + """下载失败：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
				If stream IsNot Nothing Then
					stream.Close()
				End If
				If httpWebResponse IsNot Nothing Then
					httpWebResponse.Close()
				End If
				Dim oo.0o.4 As OOO__0oo_oo.oOOO = Me.OO.0o.
				If oo.0o.4 IsNot Nothing Then
					oo.0o.4(False, Me.OO.0o., Me.oO0Oo0o_.o., False)
				End If
			Finally
				Me.OO.0o. = Nothing
				If O_O0OO.oO_00Ooo___0._..Contains(Me.OO.0o..ToLower()) Then
					O_O0OO.oO_00Ooo___0._..Remove(Me.OO.0o..ToLower())
				End If
			End Try
		End Sub

		' Token: 0x04000FA2 RID: 4002
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OOO__0oo_oo.oOOO

		' Token: 0x04000FA3 RID: 4003
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FA4 RID: 4004
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FA5 RID: 4005
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FA6 RID: 4006
		Private <<EMPTY_NAME>> As Thread

		' Token: 0x04000FA7 RID: 4007
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FA8 RID: 4008
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000FA9 RID: 4009
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FAA RID: 4010
		Private <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04000FAB RID: 4011
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000FAC RID: 4012
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x020002C7 RID: 711
		' (Invoke) Token: 0x060025FC RID: 9724
		Public Delegate Sub oOOO(A_0 As Boolean, A_1 As String, A_2 As String, A_3 As Boolean)
	End Class
End Namespace
