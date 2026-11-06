Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.C1Zip
Imports Foxtable.My
Imports Foxtable.WinForm
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace Foxtable.Syscmd
	' Token: 0x0200052D RID: 1325
	Public NotInheritable Module Project
		' Token: 0x0600578C RID: 22412 RVA: 0x00228E16 File Offset: 0x00227016
		Public Sub Create()
		End Sub

		' Token: 0x0600578D RID: 22413 RVA: 0x00228E18 File Offset: 0x00227018
		Public Sub Open()
			If Oo00.OO_O_0O0OO0_.o.() Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog = New OpenFileDialog()
				Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\Foxtable项目"
				If Not OO_00oOO.FileSys.FileExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				If Project.OO.OO_0o. IsNot Nothing Then
					openFileDialog.InitialDirectory = Project.OO.OO_0o.
				Else
					openFileDialog.InitialDirectory = text
				End If
				openFileDialog.CheckFileExists = True
				openFileDialog.Filter = "Table文件(*" + ooO0__OO.oo.Ooo_00.() + ")|*" + ooO0__OO.oo.Ooo_00.()
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Project.OO.OO_0o. = OO_00oOO.FileSys.GetParentPath(openFileDialog.FileName)
					Project.Open(openFileDialog.FileName, New String(-1) {})
				End If
			End If
		End Sub

		' Token: 0x0600578E RID: 22414 RVA: 0x00228ED8 File Offset: 0x002270D8
		<oO0oooo("2236")>
		Public Sub OpenCaseStudy()
			If Oo00.OO_O_0O0OO0_.o.() Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.CheckFileExists = True
				openFileDialog.InitialDirectory = O_O0OO.o.00O_O.() + "CaseStudy"
				openFileDialog.Filter = "Table文件(*" + ooO0__OO.oo.Ooo_00.() + ")|*" + ooO0__OO.oo.Ooo_00.()
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Project.Open(openFileDialog.FileName, New String(-1) {})
				End If
			End If
		End Sub

		' Token: 0x0600578F RID: 22415 RVA: 0x00228F48 File Offset: 0x00227148
		<oO0oooo("2495")>
		Public Function Open(FileName As String, ParamArray args As String()) As Boolean
			Dim result As Boolean
			If Path.GetFileNameWithoutExtension(FileName).IndexOf(".") >= 0 Then
				MessageBox.Show("项目文件名不能包括符号"".""，请改名后再打开此文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				OO_00oOO.OpenFileArgs.Clear()
				OO_00oOO.OpenFileArgs.AddRange(args)
				If Operators.CompareString(OO_00oOO.ProjectFile, "", True) > 0 AndAlso OO_00oOO.CurrentTable IsNot Nothing AndAlso Not Oo00.OO_O_0O0OO0_.o.() Then
					result = False
				Else
					Try
						OO_00oOO.FileWatcher.Enabled = False
						If Main.OO_O.o..Visible Then
							Main.ProcessForm.o0__.Oo0O_O0O_.("正在打开文件，请稍候...")
							Main.ProcessForm.Show()
						End If
						Application.DoEvents()
						OO_00oOO.SystemReady = False
						O_O0OO.o0OoO00OO.00O. = True
						If o0OoOOoOOo0.oO.0_0oOOo.(FileName) Then
							OO_00oOO.Vars.Clear()
							OO_00oOO.Functions.ThrowException = False
							OO_00oOO.Functions.Clear()
							OO_00oOO.Functions.O__00.__0_O.(False, "")
							ooO.O._oO_0O__o__o.()
							OO_00oOO.Ports.Clear()
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Initialize", Nothing, True, "项目", True)
							OO_00oOO.FileWatcher.initialize()
							Main.OO_O.o..o_O.o__. = True
							Main.OO_O.o..ooo.Oo0.()
							Main.OO_O.o..o_O.o__. = False
							Main.OO_O.o. = 4
							Main.ProcessForm.Close()
							OO_00oOO.SystemReady = True
							O_O0OO.o0OoO00OO.00O. = False
							Main.OO_O.o..o_0.O.()
							Dim list As List(Of O_0) = New List(Of O_0)()
							list.AddRange(O_O0OO.o__.O.().Values)
							Try
								For Each o_ As O_0 In list
									If o_.o_oo._0Oo.() Then
										o_.o_._0O0o_OoO.()
									End If
								Next
							Finally
								Dim enumerator As List(Of O_0).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							If OO_00oOO.User.Type IsNot Nothing OrElse Not O_O0OO.o00.0.(O_O0OO.O0_00o.o0__o.) Then
								Try
									For Each form As Foxtable.WinForm.Form In OO_00oOO.Forms
										If form.AutoOpen AndAlso form.FormStyle <> FormStyleEnum.模式 AndAlso ((form.FormStyle <> FormStyleEnum.主窗口 AndAlso form.FormStyle <> FormStyleEnum.停靠 AndAlso form.FormStyle <> FormStyleEnum.并列) OrElse (Operators.CompareString(form.TableName, "", True) <> 0 AndAlso OO_00oOO.Tables.get_Contains(form.TableName))) Then
											Main.OO_O.o. = 4
											form.Open(Integer.MaxValue, Integer.MaxValue)
										End If
									Next
								Finally
									Dim enumerator2 As IEnumerator(Of Foxtable.WinForm.Form)
									If enumerator2 IsNot Nothing Then
										enumerator2.Dispose()
									End If
								End Try
							End If
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "LoadUserSetting", Nothing, True, "项目", True)
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterOpenProject", Nothing, False, "项目", True)
							If c.OOOOO.o.().FileSystem.FileExists(O_O0OO.o0OoO00OO.00O.) Then
								Operators.CompareString(O_O0OO.o0OoO00OO.00O., FileName, True)
							End If
							Dim array As String() = New String() { "RibbonMenu", "UserFunctions", "PublicCode", "Timers" }
							Dim flag As Boolean = False
							For Each text As String In array
								If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { text, o0_O.o0O.o_. }) Is Nothing Then
									flag = True
									Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
									dataRow("Name") = text
									dataRow("Type") = o0_O.o0O.o_.
									dataRow("Config") = OoOo0O.OO_o.0o_O.(8)
									O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
								End If
							Next
							If o0OoOOoOOo0.oOOo_O._o0. Then
								o0OoOOoOOo0.oOOo_O._o0. = False
								flag = True
								For Each dataRow2 As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()).[Select]("[Type] = " + Conversions.ToString(233) + " Or [Type] = " + Conversions.ToString(229))
									If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { dataRow2("Key"), o0_O.o0O.o_. }) Is Nothing Then
										Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
										dataRow("Name") = RuntimeHelpers.GetObjectValue(dataRow2("Key"))
										dataRow("Type") = o0_O.o0O.o_.
										dataRow("Config") = OoOo0O.OO_o.0o_O.(8)
										O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
									End If
								Next
							End If
							If flag Then
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False)
							End If
							If Not Main.OO_O.o..IsDisposed Then
								Try
									For Each table As Table In OO_00oOO.Tables
										If table.oo.o_ooO. AndAlso Operators.CompareString(table.o.Ooo__., "", True) > 0 Then
											table.OpenLoadTree()
										End If
										If table.o0o0oOOo0__.o. AndAlso Operators.CompareString(table.O00.o_0OO__., "", True) > 0 Then
											table.OpenFilterTree()
										End If
										If table.Oo.Oo0OoOOoo_. Then
											Dim num As Integer = 0
											If Operators.CompareString(table.ooo_O0oOo.0O., "", True) > 0 Then
												For Each text2 As String In table.ooo_O0oOo.0O..Split(New Char() { ","c })
													If table.Cols.Contains(text2) AndAlso table.Cols(text2).IsNumeric() Then
														table.Cols(text2).GrandTotal = True
														num += 1
													End If
												Next
											End If
											If num > 0 Then
												table.GrandTotal = True
											End If
										End If
									Next
								Finally
									Dim enumerator3 As IEnumerator(Of Table)
									If enumerator3 IsNot Nothing Then
										enumerator3.Dispose()
									End If
								End Try
								Main.OO_O.o..OO_O_0Oo.___o.().Refresh()
								Try
									For Each table2 As Table In OO_00oOO.Tables
										If table2.foxGrid.CanFocus Then
											table2.foxGrid.Refresh()
										End If
									Next
								Finally
									Dim enumerator4 As IEnumerator(Of Table)
									If enumerator4 IsNot Nothing Then
										enumerator4.Dispose()
									End If
								End Try
							End If
							result = True
						Else
							OO_00oOO.FileWatcher.initialize()
							result = False
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						Application.[Exit]()
					Finally
						OO_00oOO.SystemReady = True
						O_O0OO.o0OoO00OO.00O. = O_O0OO.OoO_o.oO0o0O.()
						Main.ProcessForm.Close()
					End Try
				End If
			End If
			Return result
		End Function

		' Token: 0x06005790 RID: 22416 RVA: 0x002296C0 File Offset: 0x002278C0
		<oO0oooo("0008")>
		Public Sub ModifyProperty()
		End Sub

		' Token: 0x06005791 RID: 22417 RVA: 0x002296C2 File Offset: 0x002278C2
		<oO0oooo("0006")>
		Public Sub Compact(Optional ShowMessage As Boolean = True)
			Oo00.oO.OO.()
			If OO_00oOO.CompactAccessFile(OO_00oOO.ProjectFile, O_O0OO.oO_00Ooo___0._., True) AndAlso ShowMessage Then
				MessageBox.Show("压缩完成，建议定期执行此命令！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x06005792 RID: 22418 RVA: 0x002296F4 File Offset: 0x002278F4
		<oO0oooo("0005")>
		Public Sub Backup(Optional Path As String = "", Optional Auto As Boolean = False)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			Dim text As String
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				text = Strings.Format(DateTime.Now, "yyyyMMddHHmm") + ".zip"
			Else
				text = Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmm") + ".zip"
			End If
			If Operators.CompareString(Path, "", True) = 0 Then
				If Operators.CompareString(O_O0OO.O0_00o.o0__o..BackupPath, "", True) = 0 Then
					Path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\Foxtable_backup"
				Else
					Path = O_O0OO.O0_00o.o0__o..BackupPath
				End If
			End If
			If Not OO_00oOO.FileSys.FileExists(Path) Then
				OO_00oOO.FileSys.CreateDirectory(Path)
			End If
			If Not Auto Then
				saveFileDialog.FileName = text
				saveFileDialog.InitialDirectory = Path
				saveFileDialog.Filter = "Zip 文件(*.Zip)|*.Zip"
				saveFileDialog.OverwritePrompt = True
				saveFileDialog.CheckPathExists = True
				If saveFileDialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If
				text = saveFileDialog.FileName
			Else
				text = Path.Trim(New Char() { "\"c }) + "\" + text
			End If
			If Operators.CompareString(OO_00oOO.FileSys.GetParentPath(text), OO_00oOO.FileSys.GetParentPath(OO_00oOO.ProjectFile), True) = 0 Then
				MessageBox.Show("备份文件不能和管理项目处于同一文件夹下！", "备份失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim c1ZipFile As C1ZipFile = New C1ZipFile(text, True)
			c1ZipFile.Entries.Add(OO_00oOO.ProjectFile)
			If O_O0OO.O0_00o.o0__o..IncludeAttatchMents Then
				If c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "Images\") Then
					Try
						For Each text2 As String In OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Images", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, New String(-1) {})
							c1ZipFile.Entries.Add(text2, text2.Substring(OO_00oOO.ProjectPath.Length))
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				If c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "Attachments\") Then
					Try
						For Each text3 As String In OO_00oOO.FileSys.GetFiles(OO_00oOO.ProjectPath + "Attachments", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, New String(-1) {})
							c1ZipFile.Entries.Add(text3, text3.Substring(OO_00oOO.ProjectPath.Length))
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of String)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				End If
			End If
			c1ZipFile.Close()
			O_O0OO.O0_00o.o0__o..LastBackUpdate = DateTime.Today
			O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
		End Sub

		' Token: 0x06005793 RID: 22419 RVA: 0x002299C4 File Offset: 0x00227BC4
		Public Sub Save()
			Main.OO_O.o..O0__O.OOOO.()
			O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				Project.SaveAs()
				Return
			End If
			OO_00oOO.DataTables.Save()
		End Sub

		' Token: 0x06005794 RID: 22420 RVA: 0x002299FF File Offset: 0x00227BFF
		Public Sub SaveAs()
		End Sub

		' Token: 0x06005795 RID: 22421 RVA: 0x00229A04 File Offset: 0x00227C04
		Public Sub [Exit]()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Main.OO_O.o..Close()
				IL_13:
				GoTo IL_6E
				IL_15:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2F:
				GoTo IL_63
				IL_31:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_41:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_31
			End Try
			IL_63:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06005796 RID: 22422 RVA: 0x00229A98 File Offset: 0x00227C98
		Public Sub [Exit](blnSave As Boolean)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not blnSave Then
					GoTo IL_28
				End If
				IL_0C:
				num2 = 3
				If Not OO_00oOO.DataTables.Save() Then
					GoTo IL_86
				End If
				IL_1A:
				num2 = 4
				Main.OO_O.o..Close()
				GoTo IL_86
				IL_28:
				num2 = 6
				O_O0OO.OOOo.oo_OOOO_0.().RejectChanges()
				IL_34:
				num2 = 7
				O_O0OO.OoO.0OO__0ooo.().RejectChanges()
				IL_40:
				num2 = 8
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_57:
					num2 = 9
					table.NeedSaveSetting = False
					IL_62:
					num2 = 10
				End While
				IL_6D:
				num2 = 11
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_79:
				num2 = 12
				Main.OO_O.o..Close()
				IL_86:
				GoTo IL_10C
				IL_8B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_CD:
				GoTo IL_101
				IL_CF:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_DF:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CF
			End Try
			IL_101:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_10C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06005797 RID: 22423 RVA: 0x00229BCC File Offset: 0x00227DCC
		Public Sub DesignRibbonMenu()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If O_O0OO.o0OoO00OO.00O. Is Nothing Then
					GoTo IL_23
				End If
				IL_10:
				num2 = 3
				O_O0OO.o0OoO00OO.00O..oOooOoOo._0Oo.().PerformClick()
				GoTo IL_2B
				IL_23:
				num2 = 5
				ooO.oo__.O000_o_O.()
				IL_2B:
				GoTo IL_96
				IL_2D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_57:
				GoTo IL_8B
				IL_59:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_69:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_59
			End Try
			IL_8B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_96:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06005798 RID: 22424 RVA: 0x00229C88 File Offset: 0x00227E88
		Public Sub ModifyOuterDataSource()
			If ooO.oo__.O000_o_O.() Then
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
					MessageBox.Show("请先保存才能设置外部数据源!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Dim o_u3000_u As O\u3000\u3002 = New O\u3000\u3002()
				o_u3000_u.ShowDialog()
				If o_u3000_u.o0oo_o_0OOo_.O. Then
					MessageBox.Show("必须重新打开项目，对现有数据源的设置才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Project.Open(OO_00oOO.ProjectFile, New String(-1) {})
				End If
			End If
		End Sub

		' Token: 0x06005799 RID: 22425 RVA: 0x00229CF9 File Offset: 0x00227EF9
		Public Sub Import()
		End Sub

		' Token: 0x0600579A RID: 22426 RVA: 0x00229CFB File Offset: 0x00227EFB
		Public Sub ImportFromXML()
		End Sub

		' Token: 0x0600579B RID: 22427 RVA: 0x00229CFD File Offset: 0x00227EFD
		Public Sub ImportFromText()
		End Sub

		' Token: 0x0600579C RID: 22428 RVA: 0x00229CFF File Offset: 0x00227EFF
		<oO0oooo("0184")>
		Public Sub QuickImport()
		End Sub

		' Token: 0x0600579D RID: 22429 RVA: 0x00229D01 File Offset: 0x00227F01
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Export()
		End Sub

		' Token: 0x0600579E RID: 22430 RVA: 0x00229D03 File Offset: 0x00227F03
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ExportToAccess()
		End Sub

		' Token: 0x0600579F RID: 22431 RVA: 0x00229D08 File Offset: 0x00227F08
		<oO0oooo("0179")>
		Public Sub ExportToExcel()
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "Excel 2003文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				New O\u3002\u3002\u3000\u3002\u3002\u3000\u3000_(saveFileDialog.FileName).ShowDialog()
			End If
		End Sub

		' Token: 0x060057A0 RID: 22432 RVA: 0x00229D40 File Offset: 0x00227F40
		<oO0oooo("0182")>
		Public Sub QuickExport()
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.OverwritePrompt = False
			AddHandler saveFileDialog.FileOk, AddressOf Project.Oo_.0OO0O_o.
			saveFileDialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx|Access 文件(*.mdb)|*.mdb|Access 2007文件(*.accdb)|*.accdb|dBASE文件(*.dbf)|*.dbf|Text(*.txt)|*.txt"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				New O\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3000(saveFileDialog.FileName).ShowDialog()
			End If
		End Sub

		' Token: 0x060057A1 RID: 22433 RVA: 0x00229D94 File Offset: 0x00227F94
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			Dim saveFileDialog As SaveFileDialog = CType(A_0, SaveFileDialog)
			Dim extension As String = Path.GetExtension(saveFileDialog.FileName)
			If(Operators.CompareString(extension, ".dbf", True) = 0 OrElse Operators.CompareString(extension, ".txt", True) = 0) AndAlso c.OOOOO.o.().FileSystem.FileExists(saveFileDialog.FileName) AndAlso MessageBox.Show(saveFileDialog.FileName + "已经存在，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060057A2 RID: 22434 RVA: 0x00229E0E File Offset: 0x0022800E
		Public Sub Users()
			New o\u3002\u3000\u3002_().ShowDialog()
		End Sub

		' Token: 0x060057A3 RID: 22435 RVA: 0x00229E1C File Offset: 0x0022801C
		<oO0oooo("0607")>
		Public Sub SwitchUser()
			Dim a_ As DataTable = O_O0OO.OoO_o.oO0o0O.()
			Dim o_u3002_u3002_u3002_u3002_u3002_u3000_u As O\u3002\u3002\u3002\u3002\u3002\u3000\u3002 = New O\u3002\u3002\u3002\u3002\u3002\u3000\u3002(a_, O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), OO_00oOO.FileSys.GetParentPath(OO_00oOO.ProjectFile), O_O0OO.O0_00o.o0__o..OoOO.O0OoOoOO0.)
			If o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Tag Is Nothing Then
				o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Text = O_O0OO.O0_00o.o0__o..LogTip
			End If
			o_u3002_u3002_u3002_u3002_u3002_u3000_u.o0O.OO00OOOO_0. = True
			If o_u3002_u3002_u3002_u3002_u3002_u3000_u.ShowDialog() = DialogResult.OK Then
				OO_00oOO.O0o_00Oo0.o_o. = o_u3002_u3002_u3002_u3002_u3002_u3000_u.OooO.00o.
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "LoadUserSetting", Nothing, False, "项目", True)
				Dim a_2 As String = "LoadUserSetting_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, Nothing, False, "菜单", False)
			End If
		End Sub

		' Token: 0x060057A4 RID: 22436 RVA: 0x00229EEB File Offset: 0x002280EB
		Public Sub CommandWindow()
		End Sub

		' Token: 0x060057A5 RID: 22437 RVA: 0x00229EED File Offset: 0x002280ED
		Public Sub ExecuteSQL()
			ooO.oo__.O000_o_O.()
		End Sub

		' Token: 0x060057A6 RID: 22438 RVA: 0x00229EF8 File Offset: 0x002280F8
		<oO0oooo("1486")>
		Public Sub FunctionManager()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				ooO.oo__.O000_o_O.()
				IL_0F:
				GoTo IL_6E
				IL_11:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2F:
				GoTo IL_63
				IL_31:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_41:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_31
			End Try
			IL_63:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060057A7 RID: 22439 RVA: 0x00229F8C File Offset: 0x0022818C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Refresh()
			Project.Load()
		End Sub

		' Token: 0x060057A8 RID: 22440 RVA: 0x00229F94 File Offset: 0x00228194
		Public Sub Load()
			Try
				Main.ProcessForm.o0__.Oo0O_O0O_.("开始同步数据，请稍候...")
				Main.ProcessForm.Show()
				Application.DoEvents()
				O_O0OO.OoO.0OO__0ooo.().Open()
				Try
					For Each oleDbConnection As OleDbConnection In O_O0OO.O._o_.().Values
						oleDbConnection.Open()
					Next
				Finally
					Dim enumerator As Dictionary(Of String, OleDbConnection).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				OO_00oOO.SystemReady = False
				ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						Main.ProcessForm.o0__.Oo0O_O0O_.("正在同步" + dataTable.Name + "，请稍候...")
						Application.DoEvents()
						dataTable.o0.o.(True, Nothing)
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of DataTable)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				OO_00oOO.SystemReady = True
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Application.[Exit]()
			Finally
				O_O0OO.OoO.0OO__0ooo.().Close()
				Try
					For Each oleDbConnection2 As OleDbConnection In O_O0OO.O._o_.().Values
						oleDbConnection2.Close()
					Next
				Finally
					Dim enumerator3 As Dictionary(Of String, OleDbConnection).ValueCollection.Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				OO_00oOO.SystemReady = True
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				Main.ProcessForm.Close()
			End Try
		End Sub

		' Token: 0x060057A9 RID: 22441 RVA: 0x0022A130 File Offset: 0x00228330
		<oO0oooo("0657")>
		Public Sub EditMyTimers()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				ooO.oo__.O000_o_O.()
				IL_0F:
				GoTo IL_6E
				IL_11:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2F:
				GoTo IL_63
				IL_31:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_41:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_31
			End Try
			IL_63:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060057AA RID: 22442 RVA: 0x0022A1C4 File Offset: 0x002283C4
		<oO0oooo("0007")>
		Public Sub Initialize()
			If Operators.CompareString(O_O0OO.o0OoO00OO.00O., OO_00oOO.ProjectFile, True) = 0 Then
				MessageBox.Show("这是一个未保存的临时文件，无需初始化!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Oo00.OO_O_0O0OO0_.o.() AndAlso New oo\u3000\u3000\u3000\u3002().ShowDialog() = DialogResult.OK Then
				MessageBox.Show("初始化结束，将重新打开项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Project.Open(OO_00oOO.ProjectFile, New String(-1) {})
			End If
		End Sub

		' Token: 0x060057AB RID: 22443 RVA: 0x0022A22F File Offset: 0x0022842F
		<oO0oooo("0698")>
		Public Sub FormDesigner()
			If ooO.oo__.O000_o_O.() AndAlso OO_00oOO.MainTable.DataTable.AddByCode Then
				MessageBox.Show("不能在临时表中设计窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x060057AC RID: 22444 RVA: 0x0022A25C File Offset: 0x0022845C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub MainFormDesigner()
			Project.FormDesigner()
		End Sub

		' Token: 0x060057AD RID: 22445 RVA: 0x0022A264 File Offset: 0x00228464
		<oO0oooo("1510")>
		Public Sub ModiProjectInfo()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not ooO.oo__.O000_o_O.() Then
					GoTo IL_649
				End If
				IL_13:
				num2 = 4
				Dim projectInfo As ProjectInfo = New ProjectInfo()
				IL_1B:
				num2 = 5
				Dim o__u3000_u3000_u As o_\u3000\u3000\u3000 = New o_\u3000\u3000\u3000()
				IL_24:
				num2 = 6
				Dim dataRow As DataRow = Nothing
				IL_29:
				num2 = 7
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "ProjectInfo", o0_O.o0o0OOO00.0O_. })
				IL_63:
				num2 = 8
				If dataRow2 Is Nothing Then
					GoTo IL_96
				End If
				IL_69:
				num2 = 9
				If dataRow2.IsNull("Config") Then
					GoTo IL_96
				End If
				IL_7A:
				num2 = 10
				o_O_o_oOoo__.OOOO_OO._oo.(projectInfo, dataRow2("Config").ToString(), vbVerticalTab)
				IL_96:
				num2 = 11
				Dim dataRow3 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00.MD5Encrypt(O_O0OO.O_O._Oo.()).Substring(0, 12), o0_O.O_o0.0_o0o_. })
				IL_DD:
				num2 = 12
				If dataRow3 Is Nothing Then
					GoTo IL_124
				End If
				IL_E4:
				num2 = 13
				If dataRow3.IsNull("Config") Then
					GoTo IL_124
				End If
				IL_F5:
				num2 = 14
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Value = O00.oO_.0o_oo_0O_.(dataRow3("Config").ToString(), "fox", "fox")
				IL_124:
				num2 = 15
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().SelectedObject = projectInfo
				IL_134:
				num2 = 16
				If OO_00oOO.User.Type Is Nothing Then
					GoTo IL_153
				End If
				IL_143:
				num2 = 17
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Enabled = False
				IL_153:
				num2 = 18
				Dim left As String = o0OO__.OO0oO.o.(1925, 75, False).Trim()
				IL_16A:
				num2 = 19
				Dim text As String = ""
				IL_174:
				num2 = 20
				Dim text2 As String = ""
				IL_17E:
				num2 = 21
				o0OO__.oOO.o_.(text, text2)
				IL_18A:
				num2 = 22
				Dim text3 As String = text + text2
				IL_198:
				num2 = 23
				text3 = O00.ooo000o_0.00o0.(text3, text2, text)
				IL_1A8:
				num2 = 24
				text3 = Strings.Left(O00.MD5Encrypt(text3), 75)
				IL_1BB:
				num2 = 25
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible = (Operators.CompareString(left, text3, True) = 0)
				IL_1D7:
				num2 = 26
				If Operators.CompareString(left, text3, True) <> 0 Then
					GoTo IL_2DA
				End If
				IL_1E9:
				num2 = 27
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "foxtable", o0_O.Oo00.0. })
				IL_227:
				num2 = 28
				If dataRow Is Nothing Then
					GoTo IL_276
				End If
				IL_22E:
				num2 = 30
				If dataRow.IsNull("Config") Then
					GoTo IL_276
				End If
				IL_23F:
				num2 = 31
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible = (Operators.CompareString(dataRow("Config").ToString(), O00.MD5Encrypt(text + text2), True) = 0)
				IL_276:
				num2 = 32
				o__u3000_u3000_u.O._0_O0_0oo.().Checked = O_O0OO.O0_00o.o0__o..o0o_oO0_o.O.
				IL_28F:
				num2 = 33
				o__u3000_u3000_u.o._0O0ooo0o.().Checked = O_O0OO.O0_00o.o0__o..oOO._0_0Oo.
				IL_2A8:
				num2 = 34
				o__u3000_u3000_u.OOo_00Oo.o__o.().Checked = O_O0OO.O0_00o.o0__o..oOO0_o_._ooO.
				IL_2C1:
				num2 = 35
				o__u3000_u3000_u.o_oOOO0_o0_.0_.().Checked = O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o.
				IL_2DA:
				num2 = 36
				If o__u3000_u3000_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_649
				End If
				IL_2EA:
				num2 = 37
				If Not o__u3000_u3000_u.o_oOOO0_o0_.0_.().TabVisible Then
					GoTo IL_3A5
				End If
				IL_2FE:
				num2 = 38
				If dataRow IsNot Nothing OrElse o__u3000_u3000_u.OOo.O_O. Then
					GoTo IL_37C
				End If
				IL_30E:
				num2 = 39
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_32C:
				num2 = 40
				dataRow("Name") = "foxtable"
				IL_340:
				num2 = 41
				dataRow("Type") = o0_O.Oo00.0.
				IL_359:
				num2 = 42
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
				IL_37C:
				num2 = 43
				If o__u3000_u3000_u.OOo.O_O. Then
					GoTo IL_3A5
				End If
				IL_388:
				num2 = 44
				dataRow("Config") = O00.MD5Encrypt(text + text2)
				IL_3A5:
				num2 = 45
				If dataRow2 IsNot Nothing Then
					GoTo IL_417
				End If
				IL_3AC:
				num2 = 46
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_3CA:
				num2 = 47
				dataRow2("Name") = "ProjectInfo"
				IL_3DE:
				num2 = 48
				dataRow2("Type") = o0_O.o0o0OOO00.0O_.
				IL_3F4:
				num2 = 49
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow2)
				IL_417:
				num2 = 50
				dataRow2("Config") = o_O_o_oOoo__.OOOO_OO._oo.(projectInfo, False, vbVerticalTab, False)
				IL_430:
				num2 = 51
				If dataRow3 IsNot Nothing OrElse o__u3000_u3000_u.OOo.O_O. Then
					GoTo IL_4BA
				End If
				IL_443:
				num2 = 52
				dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_461:
				num2 = 53
				dataRow3("Name") = O00.MD5Encrypt(O_O0OO.O_O._Oo.()).Substring(0, 12)
				IL_482:
				num2 = 54
				dataRow3("Type") = o0_O.O_o0.0_o0o_.
				IL_497:
				num2 = 55
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow3)
				IL_4BA:
				num2 = 56
				If o__u3000_u3000_u.OOo.O_O. Then
					GoTo IL_543
				End If
				IL_4C6:
				num2 = 57
				If Operators.CompareString(o__u3000_u3000_u.o_oOOO0_o0_.0_.().Text.Trim(), "", True) <> 0 Then
					GoTo IL_50B
				End If
				IL_4E7:
				num2 = 58
				dataRow3("Config") = DBNull.Value
				IL_4FB:
				num2 = 59
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = False
				GoTo IL_543
				IL_50B:
				num2 = 61
				dataRow3("Config") = O00.ooo000o_0.00o0.(o__u3000_u3000_u.o_oOOO0_o0_.0_.().Text, "fox", "fox")
				IL_535:
				num2 = 62
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = True
				IL_543:
				num2 = 63
				If o__u3000_u3000_u.OOo.O_O. Then
					GoTo IL_5B5
				End If
				IL_54F:
				num2 = 64
				O_O0OO.O0_00o.o0__o..o0o_oO0_o.O. = o__u3000_u3000_u.O._0_O0_0oo.().Checked
				IL_568:
				num2 = 65
				O_O0OO.O0_00o.o0__o..oOO._0_0Oo. = o__u3000_u3000_u.o._0O0ooo0o.().Checked
				IL_581:
				num2 = 66
				O_O0OO.O0_00o.o0__o..oOO0_o_._ooO. = o__u3000_u3000_u.OOo_00Oo.o__o.().Checked
				IL_59A:
				num2 = 67
				O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. = o__u3000_u3000_u.o_oOOO0_o0_.0_.().Checked
				GoTo IL_61D
				IL_5B5:
				num2 = 69
				O_O0OO.O0_00o.o0__o..o0o_oO0_o.O. = False
				IL_5C3:
				num2 = 70
				O_O0OO.O0_00o.o0__o..oOO._0_0Oo. = False
				IL_5D1:
				num2 = 71
				O_O0OO.O0_00o.o0__o..oOO0_o_._ooO. = False
				IL_5DF:
				num2 = 72
				O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. = False
				IL_5ED:
				num2 = 73
				If dataRow3 Is Nothing Then
					GoTo IL_5FE
				End If
				IL_5F4:
				num2 = 74
				dataRow3.Delete()
				IL_5FE:
				num2 = 75
				If dataRow Is Nothing Then
					GoTo IL_60F
				End If
				IL_605:
				num2 = 76
				dataRow.Delete()
				IL_60F:
				num2 = 77
				O_O0OO.O0_00o.o0__o..oO_._Ooo_0. = False
				IL_61D:
				num2 = 78
				O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				IL_62C:
				num2 = 79
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
				IL_649:
				GoTo IL_7DB
				IL_64E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_79C:
				GoTo IL_7D0
				IL_79E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7AE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_79E
			End Try
			IL_7D0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7DB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060057AE RID: 22446 RVA: 0x0022AA70 File Offset: 0x00228C70
		Public Sub ShowTableCaption()
			Main.OO_O.o..OO_O_0Oo.___o.().Padding = New Point(6, 3)
		End Sub

		' Token: 0x060057AF RID: 22447 RVA: 0x0022AA88 File Offset: 0x00228C88
		Public Sub HideTableCaption()
			Main.OO_O.o..OO_O_0Oo.___o.().Padding = New Point(-5000, -100)
		End Sub

		' Token: 0x060057B0 RID: 22448 RVA: 0x0022AAA5 File Offset: 0x00228CA5
		<oO0oooo("2297")>
		Public Sub ToAccess()
			New O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002().ShowDialog()
		End Sub

		' Token: 0x060057B1 RID: 22449 RVA: 0x0022AAB2 File Offset: 0x00228CB2
		<oO0oooo("2297")>
		Public Sub Redirect()
		End Sub

		' Token: 0x060057B2 RID: 22450 RVA: 0x0022AAB4 File Offset: 0x00228CB4
		Public Sub StopRedraw()
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
		End Sub

		' Token: 0x060057B3 RID: 22451 RVA: 0x0022AAC6 File Offset: 0x00228CC6
		Public Sub ResumeRedraw()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
		End Sub

		' Token: 0x060057B4 RID: 22452 RVA: 0x0022AAD3 File Offset: 0x00228CD3
		<oO0oooo("1540")>
		Public Sub PublishProject()
			MessageBox.Show("您正在使用的版本不具备发布功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x060057B5 RID: 22453 RVA: 0x0022AAE8 File Offset: 0x00228CE8
		Private Sub <<EMPTY_NAME>>()
			o0OO__.OO0oO.o.(2)
		End Sub

		' Token: 0x060057B6 RID: 22454 RVA: 0x0022AAF1 File Offset: 0x00228CF1
		<oO0oooo("0325")>
		Public Sub Variable()
		End Sub

		' Token: 0x060057B7 RID: 22455 RVA: 0x0022AAF3 File Offset: 0x00228CF3
		<oO0oooo("")>
		Public Sub VBCode()
		End Sub

		' Token: 0x060057B8 RID: 22456 RVA: 0x0022AAF5 File Offset: 0x00228CF5
		<oO0oooo("1936")>
		Public Sub Refrence()
		End Sub

		' Token: 0x060057B9 RID: 22457 RVA: 0x0022AAF7 File Offset: 0x00228CF7
		<oO0oooo("1953")>
		Public Sub ExcelVBCode()
			ooO.oo__.O000_o_O.()
		End Sub

		' Token: 0x060057BA RID: 22458 RVA: 0x0022AAFF File Offset: 0x00228CFF
		<oO0oooo("1963")>
		Public Sub SetFileWatcher()
			ooO.oo__.O000_o_O.()
		End Sub

		' Token: 0x060057BB RID: 22459 RVA: 0x0022AB07 File Offset: 0x00228D07
		Public Sub SetDeviceWatcher()
			If ooO.oo__.O000_o_O.() Then
				MessageBox.Show("你正在使用的版本不具备设备监视功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x060057BC RID: 22460 RVA: 0x0022AB23 File Offset: 0x00228D23
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetPortWatcher()
			Project.SetDeviceWatcher()
		End Sub

		' Token: 0x060057BD RID: 22461 RVA: 0x0022AB2A File Offset: 0x00228D2A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetSMSWatcher()
			Project.SetDeviceWatcher()
		End Sub

		' Token: 0x060057BE RID: 22462 RVA: 0x0022AB34 File Offset: 0x00228D34
		Public Sub SetIMWatcher()
			If ooO.oo__.O000_o_O.() Then
				Dim o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u As o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002 = New o\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000\u3002(o_o_oOo__.OOOO_0.oO00_o.)
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.Text = "网络监视器"
				Dim num As Integer = o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages.Count - 1
				For i As Integer = 0 To num
					o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.oOoo0.___.().TabPages(i).TabVisible = (i = 7)
				Next
				o_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u3000_u.ShowDialog()
			End If
		End Sub

		' Token: 0x060057BF RID: 22463 RVA: 0x0022AB9A File Offset: 0x00228D9A
		<oO0oooo("1987")>
		Public Sub ViewCode()
			If ooO.oo__.O000_o_O.() Then
				OO_00oOO.oo0oOO.o.(OO_00oOO.OoOO.O_Oo_0.0., "")
			End If
		End Sub

		' Token: 0x060057C0 RID: 22464 RVA: 0x0022ABAE File Offset: 0x00228DAE
		Public Sub ViewStructure()
			If ooO.oo__.O000_o_O.() Then
				If O_O0OO.O0_00o.o0__o..O0OOO0_0._o_o. AndAlso Not Project.oOOoOOOo._O.() Then
					MessageBox.Show(O_O0OO.OO0._0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				OO_00oOO.ExportStructure()
			End If
		End Sub

		' Token: 0x060057C1 RID: 22465 RVA: 0x0022ABE3 File Offset: 0x00228DE3
		<oO0oooo("2024")>
		Public Sub EditTree()
			New Oo\u3000\u3000\u3002\u3000\u3002\u3002().ShowDialog(Main.OO_O.o.)
		End Sub

		' Token: 0x060057C2 RID: 22466 RVA: 0x0022ABF5 File Offset: 0x00228DF5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub QRCode()
		End Sub

		' Token: 0x060057C3 RID: 22467 RVA: 0x0022ABF7 File Offset: 0x00228DF7
		Public Sub BarCode()
			New o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002().ShowDialog()
		End Sub

		' Token: 0x060057C4 RID: 22468 RVA: 0x0022AC04 File Offset: 0x00228E04
		<oO0oooo("2245")>
		Public Sub Update()
			Project.Update(True, True)
		End Sub

		' Token: 0x060057C5 RID: 22469 RVA: 0x0022AC0E File Offset: 0x00228E0E
		Public Function Update(Prom1 As Boolean, Prom2 As Boolean) As Boolean
			Return Project.Update(Prom1, Prom2, True)
		End Function

		' Token: 0x060057C6 RID: 22470 RVA: 0x0022AC18 File Offset: 0x00228E18
		Public Function Update(Prom1 As Boolean, Prom2 As Boolean, ShowUI As Boolean) As Boolean
			Dim result As Boolean
			If Operators.CompareString(O_O0OO.O0_00o.o0__o..UpdatePath, "", True) = 0 Then
				MessageBox.Show("未定义在线升级路径!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
				ooO.SetForegroundWindow(Main.OO_O.o..Handle)
				result = False
			Else
				If O_O0OO.O0_00o.o0__o..RemoteUpdate Then
					Try
						ShareLibriay.Network.Ping("www.baidu.com")
					Catch ex As Exception
						MessageBox.Show("必须连接互联网才能升级!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
						ooO.SetForegroundWindow(Main.OO_O.o..Handle)
						Return False
					End Try
				End If
				Try
					Dim text As String = O_O0OO.O0_00o.o0__o..UpdatePath.TrimEnd(New Char() { "/"c, "\"c }) + "/update.txt"
					Dim text2 As String = OO_00oOO.ProjectPath + OoOo0O.OO_o.0o_O.(6) + ".txt"
					Dim text3 As String = O_O0OO.O0_00o.o0__o..UpdatePath.TrimEnd(New Char() { "/"c, "\"c }) + "/update1.zip"
					Dim text4 As String = O_O0OO.O0_00o.o0__o..UpdatePath.TrimEnd(New Char() { "/"c, "\"c }) + "/update2.zip"
					Dim text5 As String = OO_00oOO.ProjectPath + OoOo0O.OO_o.0o_O.(6) + ".zip"
					Dim textBox As System.Windows.Forms.TextBox = New System.Windows.Forms.TextBox()
					If O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) Then
						text = text + "?rndkey=" + OoOo0O.OO_o.0o_O.(6)
						text3 = text3 + "?rndkey=" + OoOo0O.OO_o.0o_O.(6)
						text4 = text4 + "?rndkey=" + OoOo0O.OO_o.0o_O.(6)
					End If
					If Not O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) And Not O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
						text = text.Replace("/", "\")
						text2 = text
						text3 = text3.Replace("/", "\")
						text4 = text4.Replace("/", "\")
						text5 = text3
					Else
						ShareLibriay.Network.DownloadFile(text, text2)
					End If
					textBox.Text = OO_00oOO.FileSys.ReadAllText(text2)
					Dim dateTime As DateTime
					Dim flag As Boolean
					Dim flag2 As Boolean
					If textBox.Lines(0).IndexOf("|") > 0 Then
						Dim s As String = textBox.Lines(0).Substring(0, textBox.Lines(0).IndexOf("|"))
						Dim s2 As String = textBox.Lines(0).Substring(textBox.Lines(0).IndexOf("|") + 1)
						Dim t As DateTime
						If Not DateTime.TryParse(s, dateTime) OrElse Not DateTime.TryParse(s2, t) Then
							flag = False
						Else
							dateTime = dateTime.[Date].AddHours(CDbl(dateTime.Hour)).AddMinutes(CDbl(dateTime.Minute))
							If DateTime.Compare(t, Conversions.ToDate(OO_00oOO.ApplicationVertion())) <> 0 Then
								flag2 = True
								If Not O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) And Not O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
									text5 = text4
								End If
							End If
						End If
					Else
						flag = False
					End If
					If flag Then
						If Prom1 Then
							MessageBox.Show("版本信息的日期格式错误，请检查update.txt文件的内容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
							ooO.SetForegroundWindow(Main.OO_O.o..Handle)
						End If
						Return False
					End If
					If DateTime.Compare(dateTime, O_O0OO.O0_00o.o0__o..PublishDate) <= 0 Then
						If Prom1 Then
							MessageBox.Show("您目前已经是最新的版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
							ooO.SetForegroundWindow(Main.OO_O.o..Handle)
						End If
						If O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) OrElse O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
							OO_00oOO.FileSys.DeleteFile(text2)
						End If
						Return False
					End If
					If Prom2 AndAlso MessageBox.Show("检测到的最新版本为:" + Conversions.ToString(dateTime) + "，是否现在升级？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) = DialogResult.No Then
						If O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) OrElse O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
							OO_00oOO.FileSys.DeleteFile(text2)
						End If
						ooO.SetForegroundWindow(Main.OO_O.o..Handle)
						Return False
					End If
					If flag2 Then
						If O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) OrElse O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
							If text4.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase) Then
								If Not Project.oOOoOOOo._O.(text4, text5, ShowUI) Then
									MessageBox.Show("远程升级包下载失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									ooO.SetForegroundWindow(Main.OO_O.o..Handle)
									Return False
								End If
							Else
								ShareLibriay.Network.DownloadFile(text4, text5, "", "", ShowUI, 300000, True)
							End If
						End If
					ElseIf O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) OrElse O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
						If text4.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase) Then
							If Not Project.oOOoOOOo._O.(text3, text5, ShowUI) Then
								MessageBox.Show("远程升级包下载失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								ooO.SetForegroundWindow(Main.OO_O.o..Handle)
								Return False
							End If
						Else
							ShareLibriay.Network.DownloadFile(text3, text5, "", "", ShowUI, 300000, True)
						End If
					End If
					Dim zipFile As ZipFile = New ZipFile()
					zipFile.Open(text5)
					If flag2 Then
						zipFile.ExtractAll(OO_00oOO.ApplicationPath + "\update_Fox_Path")
						Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "PublishProperty", o0_O.OOo._ooO_O_o0. })
						If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
							Dim complieProperty As ComplieProperty = New ComplieProperty()
							Dim a_ As String = dataRow("Config").ToString()
							o_O_o_oOoo__.OOOO_OO._oo.(complieProperty, a_, vbVerticalTab)
							If OO_00oOO.FileSys.FileExists(OO_00oOO.ApplicationPath + "\update_Fox_Path\" + complieProperty.FileName + ".exe") Then
								OO_00oOO.FileSys.CopyFile(OO_00oOO.ApplicationPath + "\update_Fox_Path\" + complieProperty.FileName + ".exe", OO_00oOO.ApplicationPath + complieProperty.FileName + ".exe", True)
								OO_00oOO.FileSys.DeleteFile(OO_00oOO.ApplicationPath + "\update_Fox_Path\" + complieProperty.FileName + ".exe")
							End If
							If OO_00oOO.FileSys.FileExists(OO_00oOO.ApplicationPath + "\update_Fox_Path\Copyfile.exe") Then
								OO_00oOO.FileSys.CopyFile(OO_00oOO.ApplicationPath + "\update_Fox_Path\Copyfile.exe", OO_00oOO.ApplicationPath + "Copyfile.exe", True)
								OO_00oOO.FileSys.DeleteFile(OO_00oOO.ApplicationPath + "\update_Fox_Path\Copyfile.exe")
							End If
						End If
					Else
						zipFile.ExtractAll(OO_00oOO.ProjectPath)
					End If
					zipFile.Close()
					If O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) OrElse O_O0OO.O0_00o.o0__o..UpdatePath.StartsWith("ftp", StringComparison.CurrentCultureIgnoreCase) Then
						OO_00oOO.FileSys.DeleteFile(text2)
						OO_00oOO.FileSys.DeleteFile(text5)
					End If
					If c.Oo.__O0.().CommandLineArgs.Count = 1 AndAlso Operators.CompareString(c.Oo.__O0.().CommandLineArgs(0), "fox", True) = 0 Then
						MessageBox.Show("在线升级结束，请重新启动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
					End If
					OO_00oOO.SystemReady = False
					Project.[Exit](False)
					Return True
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "在线升级失败！")
					ooO.SetForegroundWindow(Main.OO_O.o..Handle)
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x060057C7 RID: 22471 RVA: 0x0022B45C File Offset: 0x0022965C
		<oO0oooo("1466")>
		Public Sub OpenUserMenu()
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
			Main.OO_O.o..o0_o_o_0.0O.(False)
			Main.OO_O.o..OOoO0O_o_o.0_0.()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
		End Sub

		' Token: 0x060057C8 RID: 22472 RVA: 0x0022B48F File Offset: 0x0022968F
		<oO0oooo("1466")>
		Public Sub OpenSystemMenu()
			ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle)
			Main.OO_O.o..o0_o_o_0.0O.(True)
			Main.OO_O.o..OOoO0O_o_o.0_0.()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
		End Sub

		' Token: 0x060057C9 RID: 22473 RVA: 0x0022B4C2 File Offset: 0x002296C2
		Public Sub Version()
			New O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000().ShowDialog()
		End Sub

		' Token: 0x060057CA RID: 22474 RVA: 0x0022B4CF File Offset: 0x002296CF
		Public Sub UpdateFoxTable()
			o0OO__.OO0oO.o.(1)
		End Sub

		' Token: 0x060057CB RID: 22475 RVA: 0x0022B4D8 File Offset: 0x002296D8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetUKey()
		End Sub

		' Token: 0x060057CC RID: 22476 RVA: 0x0022B4DC File Offset: 0x002296DC
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If OO_00oOO.User.Type Is Nothing Then
				result = True
			ElseIf Operators.CompareString(O_O0OO.O0_00o.o0__o..Developer, "", True) > 0 AndAlso Operators.CompareString(O_O0OO.O0_00o.o0__o..Developer, OO_00oOO.User.Name, True) <> 0 Then
				MessageBox.Show("此任务的责任设计者为""" + O_O0OO.O0_00o.o0__o..Developer + """, 请不要越权设计!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060057CD RID: 22477 RVA: 0x0022B55C File Offset: 0x0022975C
		Public Sub NewExcelTemplate()
			If Project.O_.o__0O.() AndAlso Project.Oo_00o.OoO.() Then
				Dim text As String = OO_00oOO.ProjectPath + "Attachments"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "Excel文件|*.xls"
				saveFileDialog.InitialDirectory = text
				saveFileDialog.Title = "新建模版"
				AddHandler saveFileDialog.FileOk, AddressOf Project.O0O0o.Oo0OO_oO.
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					If OO_00oOO.FileSys.FileExists(saveFileDialog.FileName) Then
						OO_00oOO.FileSys.DeleteFile(saveFileDialog.FileName)
					End If
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "blank.xls", saveFileDialog.FileName)
					New o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000(saveFileDialog.FileName).Show()
				End If
			End If
		End Sub

		' Token: 0x060057CE RID: 22478 RVA: 0x0022B634 File Offset: 0x00229834
		Public Sub OpenExcelTemplate()
			If Project.O_.o__0O.() AndAlso Project.Oo_00o.OoO.() Then
				Dim text As String = OO_00oOO.ProjectPath + "Attachments"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Excel文件|*.xls;*.xlsx"
				openFileDialog.InitialDirectory = text
				AddHandler openFileDialog.FileOk, AddressOf Project.O0O0o.Oo0OO_oO.
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					If OO_00oOO.FileSys.FileExists(openFileDialog.FileName) AndAlso OO_00oOO.FileIsOpened(openFileDialog.FileName) Then
						MessageBox.Show("此报表模版已经被其它进程打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					New o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000(openFileDialog.FileName).Show()
				End If
			End If
		End Sub

		' Token: 0x060057CF RID: 22479 RVA: 0x0022B6F4 File Offset: 0x002298F4
		Public Sub NewWordTemplate()
			If Project.O_.o__0O.() AndAlso Project.Oo_.0OO0O_o.() Then
				Dim text As String = OO_00oOO.ProjectPath + "Attachments"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "Word文件|*.doc"
				saveFileDialog.Title = "新建模版"
				saveFileDialog.InitialDirectory = text
				AddHandler saveFileDialog.FileOk, AddressOf Project.O0O0o.Oo0OO_oO.
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					If OO_00oOO.FileSys.FileExists(saveFileDialog.FileName) Then
						OO_00oOO.FileSys.DeleteFile(saveFileDialog.FileName)
					End If
					OO_00oOO.FileSys.CopyFile(O_O0OO.o.00O_O.() + "blank.doc", saveFileDialog.FileName)
					New O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002(saveFileDialog.FileName).Show()
				End If
			End If
		End Sub

		' Token: 0x060057D0 RID: 22480 RVA: 0x0022B7CC File Offset: 0x002299CC
		Public Sub OpenWordTemplate()
			If Project.O_.o__0O.() AndAlso Project.Oo_.0OO0O_o.() Then
				Dim text As String = OO_00oOO.ProjectPath + "Attachments"
				If Not OO_00oOO.FileSys.DirectoryExists(text) Then
					OO_00oOO.FileSys.CreateDirectory(text)
				End If
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.Filter = "Word文件|*.doc;*.docx"
				openFileDialog.InitialDirectory = text
				AddHandler openFileDialog.FileOk, AddressOf Project.O0O0o.Oo0OO_oO.
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					If OO_00oOO.FileSys.FileExists(openFileDialog.FileName) AndAlso OO_00oOO.FileIsOpened(openFileDialog.FileName) Then
						MessageBox.Show("此报表模版已经被其它进程打开，请先关闭之！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					New O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002(openFileDialog.FileName).Show()
				End If
			End If
		End Sub

		' Token: 0x060057D1 RID: 22481 RVA: 0x0022B88C File Offset: 0x00229A8C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Try
				For Each obj As Object In Application.OpenForms
					Dim form As System.Windows.Forms.Form = CType(obj, System.Windows.Forms.Form)
					If TypeOf form Is O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002 OrElse TypeOf form Is o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000 Then
						MessageBox.Show("请先关闭已经打开的报表设计器!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim result As Boolean
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				MessageBox.Show("必须先保存项目，才能设计报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf o_O_o_oOoo__.OOOO_OO._oo.() Then
				MessageBox.Show("本机的.NET Framework 2.0版本过低，无法启动报表设计器，建议升级到.NET Framework 2.0 SP2。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Dim text As String = O_O0OO.o.00O_O.() + "downloadnetsp2.htm"
				If OO_00oOO.FileSys.FileExists(text) Then
					New Process() With { .File = text }.Start()
				End If
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060057D2 RID: 22482 RVA: 0x0022B984 File Offset: 0x00229B84
		Private Function <<EMPTY_NAME>>() As Boolean
			If Not Project.oOOoOOOo._O. Then
				Project.oOOoOOOo._O. = True
				Try
					New ApplicationClass().Quit()
					Project.Oo_.0OO0O_o. = True
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
			Dim result As Boolean
			If Not Project.Oo_.0OO0O_o. Then
				MessageBox.Show("本计算机没有安装Excel或安装不正确，无法启动Excel报表设计器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060057D3 RID: 22483 RVA: 0x0022B9FC File Offset: 0x00229BFC
		Private Function <<EMPTY_NAME>>() As Boolean
			If Not Project.oOOO.ooO0. Then
				Project.oOOO.ooO0. = True
				Try
					Dim application As _Application = New ApplicationClass()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					application.Quit(objectValue, objectValue2, objectValue3)
					Project.o_OOo_o.o_oo00. = True
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
			Dim result As Boolean
			If Not Project.o_OOo_o.o_oo00. Then
				MessageBox.Show("本计算机没有安装Word或安装不正确，无法启动Word报表设计器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060057D4 RID: 22484 RVA: 0x0022BA9C File Offset: 0x00229C9C
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			Dim fileDialog As FileDialog = CType(A_0, FileDialog)
			If Operators.CompareString(OO_00oOO.FileSys.GetParentPath(fileDialog.FileName).Trim(New Char() { "\"c }), OO_00oOO.ProjectPath + "Attachments", True) <> 0 Then
				MessageBox.Show("报表模版必须位于Attachments文件夹中!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060057D5 RID: 22485 RVA: 0x0022BB04 File Offset: 0x00229D04
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O_O0OO.O_O._Oo.().Substring(0, 12), o0_O.O_o0.0_o0o_. })
				IL_48:
				num2 = 3
				If(dataRow Is Nothing OrElse dataRow.IsNull("Config")) AndAlso Not O_O0OO.O0_00o.o0__o..oO_._Ooo_0. Then
					GoTo IL_147
				End If
				IL_6B:
				num2 = 4
				o0OO__.OO0oO.o.(1925, 75, False).Trim()
				IL_80:
				num2 = 5
				Dim text As String = ""
				IL_89:
				num2 = 6
				Dim text2 As String = ""
				IL_92:
				num2 = 7
				o0OO__.oOO.o_.(text, text2)
				IL_9D:
				num2 = 8
				Dim text3 As String = text + text2
				IL_AA:
				num2 = 9
				text3 = O00.ooo000o_0.00o0.(text3, text2, text)
				IL_BA:
				num2 = 10
				text3 = Strings.Left(O00.MD5Encrypt(text3), 75)
				IL_CD:
				num2 = 11
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "foxtable", o0_O.Oo00.0. })
				IL_10B:
				num2 = 12
				If dataRow2 Is Nothing OrElse Operators.CompareString(dataRow2("Config").ToString(), O00.MD5Encrypt(text + text2), True) <> 0 Then
					GoTo IL_140
				End If
				IL_139:
				num2 = 13
				result = True
				GoTo IL_14C
				IL_140:
				num2 = 14
				result = False
				GoTo IL_14C
				IL_147:
				num2 = 16
				result = True
				IL_14C:
				GoTo IL_1E2
				IL_151:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1A3:
				GoTo IL_1D7
				IL_1A5:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1B5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1A5
			End Try
			IL_1D7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1E2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060057D6 RID: 22486 RVA: 0x0022BD18 File Offset: 0x00229F18
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean) As Boolean
			Dim match As Match = New Regex("^ftp://(.+?:.+?)@(.+?)(/.+)", RegexOptions.IgnoreCase).Match(A_0)
			Dim result As Boolean
			If match.Success AndAlso match.Groups(0).Success AndAlso match.Groups(1).Success AndAlso match.Groups(2).Success Then
				Dim array As String() = match.Groups(1).Value.Split(New Char() { ":"c })
				If array.Length = 2 Then
					Dim ftpclient As FTPClient = New FTPClient()
					Dim array2 As String() = match.Groups(2).Value.Split(New Char() { ":"c })
					If array2.Length = 2 Then
						ftpclient.Host = array2(0)
						ftpclient.Port = Conversions.ToInteger(array2(1))
					Else
						ftpclient.Host = match.Groups(2).Value
					End If
					ftpclient.Account = array(0)
					ftpclient.Password = array(1)
					result = ftpclient.Download(match.Groups(3).Value, A_1, A_2)
				Else
					result = False
				End If
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x060057D7 RID: 22487 RVA: 0x0022BE46 File Offset: 0x0022A046
		<oO0oooo("3307")>
		Public Sub Options()
			New o\u3002\u3000\u3000\u3002\u3002\u30020\u3002() With { .Owner = Main.OO_O.o. }.ShowDialog()
		End Sub

		' Token: 0x0400223C RID: 8764
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400223D RID: 8765
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400223E RID: 8766
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400223F RID: 8767
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002240 RID: 8768
		Private <<EMPTY_NAME>> As Boolean
	End Module
End Namespace
