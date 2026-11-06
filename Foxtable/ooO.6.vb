Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.C1Preview
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports C1.Win.C1Ribbon
Imports Foxtable.My
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable
	' Token: 0x0200043F RID: 1087
	Friend NotInheritable Module ooO
		' Token: 0x060047A6 RID: 18342
		Public Declare Ansi Function SetForegroundWindow Lib "user32" (A_0 As IntPtr) As Integer

		' Token: 0x060047A7 RID: 18343
		Public Declare Ansi Function GetLastInputInfo Lib "user32.dll" (ByRef A_0 As ooO.o0O_) As Integer

		' Token: 0x060047A8 RID: 18344
		Private Declare Function ExtractIconExW Lib "shell32.dll" (<MarshalAs(UnmanagedType.LPWStr)> <[In]()> A_0 As String, A_1 As Integer, ByRef A_2 As IntPtr, ByRef A_3 As IntPtr, A_4 As UInteger) As UInteger

		' Token: 0x060047A9 RID: 18345 RVA: 0x001DA190 File Offset: 0x001D8390
		Friend Function <<EMPTY_NAME>>(A_0 As ColumnDataTypeEnum) As String
			If A_0 <= ColumnDataTypeEnum.[Long] Then
				Select Case A_0
					Case ColumnDataTypeEnum.[Short]
						Return "介于 –32,768 到 32,767 之间的短整型"
					Case ColumnDataTypeEnum.[Integer]
						Return "介于 –2,147,483,648 到 2,147,483,647 之间的整数，超过此范围的整数可以考虑用双精度小数代替"
					Case ColumnDataTypeEnum.[Single]
						Return "单精度小数，有效数字为7位，负数范围是从 –3.402823E38 到 –1.401298E-45，正数范围从1.401298E-45 到 3.402823E38"
					Case ColumnDataTypeEnum.[Double]
						Return "双精度小数，有效数字为15位，负数范围是从 –1.79769313486232E308 到 –4.94065645841247E-324，正数范围从 4.94065645841247E-324 到 1.79769313486232E308"
					Case CType(6, ColumnDataTypeEnum), CType(8, ColumnDataTypeEnum), CType(9, ColumnDataTypeEnum), CType(10, ColumnDataTypeEnum)
					Case ColumnDataTypeEnum.DateTime
						Return "日期时间列默认只允许输入日期，如果要输入时间型数据，请在列属性设置中，将""日期时间格式""属性设置为""Time""或者""LongTime"""
					Case ColumnDataTypeEnum.[Boolean]
						Return "逻辑列只有两个值，分别为True(是)和False(否)"
					Case Else
						If A_0 = ColumnDataTypeEnum.[Byte] Then
							Return "介于 0 到 255 之间的微整数"
						End If
						If A_0 = ColumnDataTypeEnum.[Long] Then
							Return "介于 -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807之间的长整数"
						End If
				End Select
			Else
				If A_0 = ColumnDataTypeEnum.[Decimal] Then
					Return "高精度小数，有高达28位的有效数字，适用于要求使用大量有效的整数及小数位数并且没有舍入错误的财务计算，可存储的小数位数默认为4，可根据需要调整。"
				End If
				If A_0 = ColumnDataTypeEnum.[String] Then
					Return "字符列用于储存长度少于等于255的字符型数据，如果长度可能超过255，请改用备注型"
				End If
				If A_0 = ColumnDataTypeEnum.Text Then
					Return "用于输入超过255个字符的文本内容，备注型数据还可以扩展为文档型或者图片性，请在列属性设置中，选择相应的""扩展类型""即可"
				End If
			End If
			Return ""
		End Function

		' Token: 0x060047AA RID: 18346 RVA: 0x001DA25C File Offset: 0x001D845C
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataRow, A_2 As DataCol) As String
			Dim result As String
			If Operators.CompareString(A_0, "", True) = 0 Then
				result = ""
			Else
				If A_2 IsNot Nothing Then
					Dim booleanEnum As BooleanEnum = A_2.AutoCopyAttachFile
					If booleanEnum Is Nothing Then
						Dim o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u As O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002 = New O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002()
						o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.ShowDialog()
						If o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.O.0o_0_.().Checked Then
							booleanEnum = 1
						Else
							booleanEnum = 2
						End If
						If o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.O.0o_0_.().Checked Then
							A_2.AutoCopyAttachFile = booleanEnum
						End If
					End If
					If booleanEnum = 2 Then
						If A_0.StartsWith(OO_00oOO.AttachPath) Then
							A_0 = A_0.Substring(OO_00oOO.AttachPath.Length)
						ElseIf A_0.StartsWith(OO_00oOO.ProjectPath) Then
							A_0 = A_0.Substring(OO_00oOO.ProjectPath.Length)
						End If
						Return A_0
					End If
				End If
				If A_0.StartsWith("\\") Then
					A_0 = ooO.O0ooOOoO.__o.(A_0)
				End If
				Try
					Dim text As String = ""
					Dim text2 As String = ""
					Dim text3 As String = ""
					If A_2 IsNot Nothing Then
						text = A_2.DefaultFolder
						Dim beforeAttachFileEvents As BeforeAttachFileEvents = New BeforeAttachFileEvents(A_2.DataTable, A_1, A_2, OO_00oOO.FileSys.GetParentPath(A_0), OO_00oOO.FileSys.GetName(A_0), "")
						Dim a_ As String = "BeforeAttachFile"
						O_O0OO.OoO_o.oO0o0O.(A_2.DataTable.o_0_00_.oo0O0., a_, New Object() { beforeAttachFileEvents }, False, A_2.DataTable.Name, False)
						If A_2.DataTable.GlobalHandler.BeforeAttachFile Then
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeAttachFileEvents }, False, "全局表事件", False)
						End If
						If beforeAttachFileEvents.Cancel Then
							Return ""
						End If
						text2 = beforeAttachFileEvents.SubFolder
						text3 = beforeAttachFileEvents.FileName
					End If
					If Operators.CompareString(text, "", True) > 0 Then
						If Operators.CompareString(text.Substring(1, 1), ":", True) <> 0 Then
							If text.StartsWith("\\") Then
								text = ooO.O0ooOOoO.__o.(text)
							Else
								text = OO_00oOO.AttachPath + text
							End If
						End If
					Else
						text = OO_00oOO.AttachPath
					End If
					text = text.TrimEnd(New Char() { "\"c }) + "\"
					If Not A_0.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) OrElse Operators.CompareString(text3, OO_00oOO.FileSys.GetName(A_0), True) <> 0 OrElse Operators.CompareString(text2, "", True) > 0 Then
						Dim text4 As String
						If Operators.CompareString(text2, "", True) > 0 Then
							text4 = text + text2.Trim(New Char() { "\"c }) + "\"
						Else
							text4 = text
						End If
						If Not OO_00oOO.FileSys.DirectoryExists(text4) Then
							OO_00oOO.FileSys.CreateDirectory(text4)
						End If
						Dim text5 As String
						If Operators.CompareString(text3, "", True) > 0 Then
							text5 = text4 + text3
						Else
							text5 = text4 + OO_00oOO.FileSys.GetName(A_0)
						End If
						If Operators.CompareString(A_0, text5, True) <> 0 Then
							If OO_00oOO.FileSys.FileExists(text5) Then
								Dim o_u3000_u3000_u3002_u As o\u3000\u3000\u3002\u3002 = New o\u3000\u3000\u3002\u3002(text5)
								If o_u3000_u3000_u3002_u.ShowDialog() <> DialogResult.OK Then
									Return ""
								End If
								c.OOOOO.o.().FileSystem.CopyFile(A_0, o_u3000_u3000_u3002_u.O0o0o0_00OO.oO., True)
								text5 = o_u3000_u3000_u3002_u.O0o0o0_00OO.oO.
							Else
								c.OOOOO.o.().FileSystem.CopyFile(A_0, text5, True)
							End If
						End If
						result = text5.Substring(text.Length)
					Else
						result = A_0.Substring(text.Length)
					End If
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "")
					result = A_0
				End Try
			End If
			Return result
		End Function

		' Token: 0x060047AB RID: 18347 RVA: 0x001DA5D8 File Offset: 0x001D87D8
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = A_0.Substring(2)
			If text.IndexOf("\") > 0 Then
				text = text.Substring(0, text.IndexOf("\"))
			End If
			If Operators.CompareString(text, SysInfo.ComputerName, True) = 0 Then
				Dim sharePath As Dictionary(Of String, String) = OO_00oOO.HardWareInfo.SharePath
				Dim text2 As String = A_0.Substring(A_0.IndexOf("\", 2) + 1)
				If text2.IndexOf("\") > 0 Then
					text2 = text2.Substring(0, text2.IndexOf("\"))
				End If
				Try
					For Each text3 As String In sharePath.Keys
						If Operators.CompareString(text3, text2, True) = 0 Then
							A_0 = sharePath(text3) + A_0.Substring(("\\" + text + "\" + text2).Length)
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Return A_0
		End Function

		' Token: 0x060047AC RID: 18348 RVA: 0x001DA6D8 File Offset: 0x001D88D8
		Friend Function <<EMPTY_NAME>>(A_0 As DataCol) As DialogResult
			Dim result As DialogResult
			If A_0.AutoDeleteAttachFile = 2 Then
				result = DialogResult.No
			ElseIf A_0.AutoDeleteAttachFile = 1 Then
				result = DialogResult.Yes
			ElseIf A_0.AutoCopyAttachFile = 2 Then
				result = DialogResult.No
			ElseIf A_0.AutoDeleteAttachFile Is Nothing Then
				Dim o_u3002_u3002_u3002_u3002_u As O\u3002\u3002\u3002\u3002\u3000 = New O\u3002\u3002\u3002\u3002\u3000()
				If o_u3002_u3002_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
					If o_u3002_u3002_u3002_u3002_u.o_0._00O_0__O_.().Checked Then
						If o_u3002_u3002_u3002_u3002_u.O__ooooo.0.().Checked Then
							A_0.AutoDeleteAttachFile = 1
						Else
							A_0.AutoDeleteAttachFile = 2
						End If
					End If
					If o_u3002_u3002_u3002_u3002_u.O__ooooo.0.().Checked Then
						result = DialogResult.Yes
					Else
						result = DialogResult.No
					End If
				Else
					result = DialogResult.Cancel
				End If
			End If
			Return result
		End Function

		' Token: 0x060047AD RID: 18349 RVA: 0x001DA768 File Offset: 0x001D8968
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Try
				If c.OOOOO.o.().FileSystem.FileExists(A_0) AndAlso (Operators.CompareString(A_0.Substring(1, 1), ":", True) = 0 OrElse A_0.StartsWith("\\")) Then
					Process.Start(A_0)
				ElseIf c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.AttachPath + A_0) Then
					Process.Start(OO_00oOO.AttachPath + A_0)
				ElseIf c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.ProjectPath + A_0) Then
					Process.Start(OO_00oOO.ProjectPath + A_0)
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x060047AE RID: 18350 RVA: 0x001DA83C File Offset: 0x001D8A3C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If A_0.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) OrElse A_0.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) Then
				result = A_0
			ElseIf Not String.IsNullOrEmpty(Path.GetPathRoot(A_0)) Then
				result = A_0
			ElseIf c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.AttachPath + A_0) Then
				result = OO_00oOO.AttachPath + A_0
			ElseIf c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.ProjectPath + A_0) Then
				result = OO_00oOO.ProjectPath + A_0
			ElseIf c.OOOOO.o.().FileSystem.FileExists(O_O0OO.OOo_o.0o. + A_0) Then
				result = O_O0OO.OOo_o.0o. + A_0
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060047AF RID: 18351 RVA: 0x001DA904 File Offset: 0x001D8B04
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OOo_o.0o.) Then
				OO_00oOO.FileSys.CreateDirectory(O_O0OO.OOo_o.0o.)
			End If
			If Operators.CompareString(A_0, "", True) > 0 AndAlso Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(A_0), "", True) > 0 AndAlso Operators.CompareString(A_0.Substring(1, 1), ":", True) = 0 Then
				If(c.OOOOO.o.().FileSystem.GetParentPath(A_0) + "\").StartsWith(O_O0OO.OOo_o.0o., StringComparison.CurrentCultureIgnoreCase) Then
					A_0 = A_0.Substring(O_O0OO.OOo_o.0o..Length)
				ElseIf(c.OOOOO.o.().FileSystem.GetParentPath(A_0) + "\").StartsWith(OO_00oOO.ProjectPath, StringComparison.CurrentCultureIgnoreCase) Then
					A_0 = A_0.Substring(OO_00oOO.ProjectPath.Length)
				Else
					Try
						If c.OOOOO.o.().FileSystem.FileExists(O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0)) Then
							Dim o_u3000_u3000_u3002_u As o\u3000\u3000\u3002\u3002 = New o\u3000\u3000\u3002\u3002(O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0))
							If o_u3000_u3000_u3002_u.ShowDialog() <> DialogResult.OK Then
								Return ""
							End If
							c.OOOOO.o.().FileSystem.CopyFile(A_0, o_u3000_u3000_u3002_u.O0o0o0_00OO.oO., True)
							A_0 = o_u3000_u3000_u3002_u.O0o0o0_00OO.oO.
						Else
							c.OOOOO.o.().FileSystem.CopyFile(A_0, O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0), True)
						End If
					Catch ex As Exception
						Return ""
					End Try
					A_0 = c.OOOOO.o.().FileSystem.GetName(A_0)
				End If
			End If
			Return A_0
		End Function

		' Token: 0x060047B0 RID: 18352 RVA: 0x001DAADC File Offset: 0x001D8CDC
		Friend Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			A_0 = A_0.Parent
			While A_0 IsNot Nothing
				If TypeOf A_0 Is C1DockingTabPage Then
					Dim c1DockingTabPage As C1DockingTabPage = CType(A_0, C1DockingTabPage)
					CType(c1DockingTabPage.Parent, C1DockingTab).SelectedTab = c1DockingTabPage
					Return
				End If
				A_0 = A_0.Parent
			End While
		End Sub

		' Token: 0x060047B1 RID: 18353 RVA: 0x001DAB20 File Offset: 0x001D8D20
		Friend Function <<EMPTY_NAME>>(A_0 As AggregateEnum) As String
			Dim result As String = ""
			Select Case A_0
				Case 2
					result = "Sum("
				Case 4
					result = "Count("
				Case 6
					result = "Avg("
				Case 7
					result = "Max("
				Case 8
					result = "Min("
				Case 9
					result = "StDev("
				Case 10
					result = "Var("
			End Select
			Return result
		End Function

		' Token: 0x060047B2 RID: 18354 RVA: 0x001DAB9C File Offset: 0x001D8D9C
		Friend Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection) As System.Windows.Forms.Control
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If control.ContainsFocus Then
						If control.Focused Then
							Return control
						End If
						If control.HasChildren Then
							Return ooO.o.O_0000_O.(control.Controls)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x060047B3 RID: 18355 RVA: 0x001DAC1C File Offset: 0x001D8E1C
		Friend Function <<EMPTY_NAME>>(A_0 As Cursor) As CursorEnum
			Dim result As CursorEnum
			If A_0 Is Cursors.AppStarting Then
				result = CursorEnum.AppStarting
			ElseIf A_0 Is Cursors.Arrow Then
				result = CursorEnum.Arrow
			ElseIf A_0 Is Cursors.Cross Then
				result = CursorEnum.Cross
			ElseIf A_0 Is Cursors.[Default] Then
				result = CursorEnum.[Default]
			ElseIf A_0 Is Cursors.Hand Then
				result = CursorEnum.Hand
			ElseIf A_0 Is Cursors.Help Then
				result = CursorEnum.Help
			ElseIf A_0 Is Cursors.HSplit Then
				result = CursorEnum.HSplit
			ElseIf A_0 Is Cursors.IBeam Then
				result = CursorEnum.IBeam
			ElseIf A_0 Is Cursors.No Then
				result = CursorEnum.No
			ElseIf A_0 Is Cursors.NoMove2D Then
				result = CursorEnum.NoMove2D
			ElseIf A_0 Is Cursors.NoMoveHoriz Then
				result = CursorEnum.NoMoveHoriz
			ElseIf A_0 Is Cursors.NoMoveVert Then
				result = CursorEnum.NoMoveVert
			ElseIf A_0 Is Cursors.PanEast Then
				result = CursorEnum.PanEast
			ElseIf A_0 Is Cursors.PanNE Then
				result = CursorEnum.PanNE
			ElseIf A_0 Is Cursors.PanNorth Then
				result = CursorEnum.PanNorth
			ElseIf A_0 Is Cursors.PanNW Then
				result = CursorEnum.PanNW
			ElseIf A_0 Is Cursors.PanSE Then
				result = CursorEnum.PanSE
			ElseIf A_0 Is Cursors.PanSouth Then
				result = CursorEnum.PanSouth
			ElseIf A_0 Is Cursors.PanSW Then
				result = CursorEnum.PanSW
			ElseIf A_0 Is Cursors.PanWest Then
				result = CursorEnum.PanWest
			ElseIf A_0 Is Cursors.SizeAll Then
				result = CursorEnum.SizeAll
			ElseIf A_0 Is Cursors.SizeNESW Then
				result = CursorEnum.SizeNESW
			ElseIf A_0 Is Cursors.SizeNS Then
				result = CursorEnum.SizeNS
			ElseIf A_0 Is Cursors.SizeNWSE Then
				result = CursorEnum.SizeNWSE
			ElseIf A_0 Is Cursors.SizeWE Then
				result = CursorEnum.SizeWE
			ElseIf A_0 Is Cursors.UpArrow Then
				result = CursorEnum.UpArrow
			ElseIf A_0 Is Cursors.VSplit Then
				result = CursorEnum.VSplit
			ElseIf A_0 Is Cursors.WaitCursor Then
				result = CursorEnum.WaitCursor
			End If
			Return result
		End Function

		' Token: 0x060047B4 RID: 18356 RVA: 0x001DAE58 File Offset: 0x001D9058
		Friend Function <<EMPTY_NAME>>(A_0 As CursorEnum) As Cursor
			Dim result As Cursor
			Select Case A_0
				Case CursorEnum.AppStarting
					result = Cursors.AppStarting
				Case CursorEnum.Arrow
					result = Cursors.Arrow
				Case CursorEnum.Cross
					result = Cursors.Cross
				Case CursorEnum.[Default]
					result = Cursors.[Default]
				Case CursorEnum.Hand
					result = Cursors.Hand
				Case CursorEnum.Help
					result = Cursors.Help
				Case CursorEnum.HSplit
					result = Cursors.HSplit
				Case CursorEnum.IBeam
					result = Cursors.IBeam
				Case CursorEnum.No
					result = Cursors.No
				Case CursorEnum.NoMove2D
					result = Cursors.NoMove2D
				Case CursorEnum.NoMoveHoriz
					result = Cursors.NoMoveHoriz
				Case CursorEnum.NoMoveVert
					result = Cursors.NoMoveVert
				Case CursorEnum.PanEast
					result = Cursors.PanEast
				Case CursorEnum.PanNE
					result = Cursors.PanNE
				Case CursorEnum.PanNorth
					result = Cursors.PanNorth
				Case CursorEnum.PanNW
					result = Cursors.PanNW
				Case CursorEnum.PanSE
					result = Cursors.PanSE
				Case CursorEnum.PanSouth
					result = Cursors.PanSouth
				Case CursorEnum.PanSW
					result = Cursors.PanNW
				Case CursorEnum.PanWest
					result = Cursors.PanWest
				Case CursorEnum.SizeAll
					result = Cursors.SizeAll
				Case CursorEnum.SizeNESW
					result = Cursors.SizeNESW
				Case CursorEnum.SizeNS
					result = Cursors.SizeNS
				Case CursorEnum.SizeNWSE
					result = Cursors.SizeNWSE
				Case CursorEnum.SizeWE
					result = Cursors.SizeWE
				Case CursorEnum.UpArrow
					result = Cursors.UpArrow
				Case CursorEnum.VSplit
					result = Cursors.VSplit
				Case CursorEnum.WaitCursor
					result = Cursors.WaitCursor
				Case Else
					result = Cursors.[Default]
			End Select
			Return result
		End Function

		' Token: 0x060047B5 RID: 18357 RVA: 0x001DAFF0 File Offset: 0x001D91F0
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If OO_00oOO.User.Type Is Nothing Then
				result = True
			ElseIf O_O0OO.O0_00o.o0__o..DisableDevelop Then
				MessageBox.Show("本项目的开发功能已经关闭，您无法使用此功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x060047B6 RID: 18358 RVA: 0x001DB033 File Offset: 0x001D9233
		Friend Sub <<EMPTY_NAME>>()
			Process.Start("iexplore.exe", "http://www.foxtable.com")
		End Sub

		' Token: 0x060047B7 RID: 18359 RVA: 0x001DB048 File Offset: 0x001D9248
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_1E:
					num2 = 3
					table.foxGrid.Enabled = False
					IL_2D:
					num2 = 4
					Dim enumerator2 As IEnumerator = table.foxGrid.Styles.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj As Object = enumerator2.Current
						Dim cellStyle As CellStyle = CType(obj, CellStyle)
						IL_52:
						num2 = 5
						cellStyle.ForeColor = Color.Gray
						IL_60:
						num2 = 6
					End While
					IL_6B:
					num2 = 7
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
					IL_82:
					num2 = 8
				End While
				IL_8C:
				num2 = 9
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_98:
				num2 = 10
				Dim enumerator3 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator3.MoveNext()
					Dim form As Foxtable.WinForm.Form = enumerator3.Current
					IL_B2:
					num2 = 11
					If form.Opened Then
						IL_BE:
						num2 = 12
						form.Pane.Enabled = False
					End If
					IL_CE:
					num2 = 13
				End While
				IL_DA:
				num2 = 14
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_E8:
				num2 = 15
				Dim enumerator4 As IEnumerator = Main.OO_O.o..O.OOO0_OOo.().Tabs.GetEnumerator()
				While enumerator4.MoveNext()
					Dim obj2 As Object = enumerator4.Current
					Dim ribbonTab As RibbonTab = CType(obj2, RibbonTab)
					IL_111:
					num2 = 16
					ribbonTab.Enabled = False
					IL_11C:
					num2 = 17
				End While
				IL_128:
				num2 = 18
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
				IL_140:
				num2 = 19
				Main.OO_O.o..O.OOO0_OOo.().Qat.Enabled = False
				IL_158:
				num2 = 20
				Main.OO_O.o..O.OOO0_OOo.().ConfigToolBar.Enabled = False
				IL_170:
				num2 = 21
				Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.Enabled = False
				IL_188:
				num2 = 22
				O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
				IL_1BA:
				num2 = 23
				OO_00oOO.SystemReady = False
				IL_1C3:
				GoTo IL_275
				IL_1C8:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_236:
				GoTo IL_26A
				IL_238:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_248:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_238
			End Try
			IL_26A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_275:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060047B8 RID: 18360 RVA: 0x001DB2F0 File Offset: 0x001D94F0
		Friend Sub <<EMPTY_NAME>>(A_0 As Exception)
			Dim showErrorMessageEventArgs As ShowErrorMessageEventArgs = New ShowErrorMessageEventArgs(A_0, "")
			If O_O0OO.oo0_o_.o. IsNot Nothing Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowErrorMessage", New Object() { showErrorMessageEventArgs }, True, "项目", False)
			End If
		End Sub

		' Token: 0x060047B9 RID: 18361 RVA: 0x001DB331 File Offset: 0x001D9531
		Friend Sub <<EMPTY_NAME>>(A_0 As Exception, Optional A_1 As String = "")
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf ooO.OO_oOO0O.O00., New Object() { A_0, A_1 })
			End If
		End Sub

		' Token: 0x060047BA RID: 18362 RVA: 0x001DB36C File Offset: 0x001D956C
		Friend Sub <<EMPTY_NAME>>(A_0 As Exception, Optional A_1 As String = "")
			Dim showErrorMessageEventArgs As ShowErrorMessageEventArgs = New ShowErrorMessageEventArgs(A_0, A_1)
			If O_O0OO.oo0_o_.o. IsNot Nothing Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowErrorMessage", New Object() { showErrorMessageEventArgs }, True, "项目", False)
			End If
			If Not showErrorMessageEventArgs.Cancel Then
				Main.OO_O.o. = 4
				New O\u3000\u3002\u3002\u3000\u3000(A_1, A_0) With { .TopMost = True }.ShowDialog()
			End If
		End Sub

		' Token: 0x060047BB RID: 18363 RVA: 0x001DB3CC File Offset: 0x001D95CC
		Friend Function <<EMPTY_NAME>>(A_0 As C1FlexGrid, A_1 As CheckEnum) As Image
			Select Case A_1
				Case 1, 4
					Return A_0.Glyphs(2)
				Case 2, 5
					Return A_0.Glyphs(3)
				Case 6
					Return A_0.Glyphs(4)
			End Select
			Return Nothing
		End Function

		' Token: 0x060047BC RID: 18364 RVA: 0x001DB430 File Offset: 0x001D9630
		Friend Sub <<EMPTY_NAME>>()
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "Variables", o0_O.O0oO__._0OO00o. })
			If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
				Dim array As String() = Conversions.ToString(dataRow("Config")).Split(New Char() { vbCr, vbLf }, StringSplitOptions.RemoveEmptyEntries)
				For i As Integer = 0 To array.Length - 1
					Dim array2 As String() = array(i).Split(New Char() { vbTab })
					Dim left As String = array2(1)
					If Operators.CompareString(left, "String", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(String), array2(2))
					ElseIf Operators.CompareString(left, "Date", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(DateTime), array2(2))
					ElseIf Operators.CompareString(left, "Boolean", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Boolean), array2(2))
					ElseIf Operators.CompareString(left, "Integer", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Integer), array2(2))
					ElseIf Operators.CompareString(left, "Long", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Long), array2(2))
					ElseIf Operators.CompareString(left, "Single", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Single), array2(2))
					ElseIf Operators.CompareString(left, "Double", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Double), array2(2))
					ElseIf Operators.CompareString(left, "Decimal", True) = 0 Then
						OO_00oOO.Vars.Add(array2(0), GetType(Decimal), array2(2))
					End If
				Next
			End If
		End Sub

		' Token: 0x060047BD RID: 18365 RVA: 0x001DB640 File Offset: 0x001D9840
		Friend Function <<EMPTY_NAME>>(A_0 As Object, A_1 As PropertyDescriptor) As Boolean
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
				Dim category As String = A_1.Category
				IL_11:
				num2 = 3
				Dim name As String = A_1.Name
				IL_1B:
				num2 = 4
				If Not(TypeOf A_0 Is DataColumnProperty) Then
					GoTo IL_7E2
				End If
				IL_28:
				num2 = 5
				Dim dataColumnProperty As DataColumnProperty = CType(A_0, DataColumnProperty)
				IL_32:
				num2 = 6
				Dim oO.OO. As DataCol = dataColumnProperty.oO.OO.
				IL_3C:
				num2 = 7
				Dim left As String = name
				IL_42:
				num2 = 9
				If Operators.CompareString(left, "EditMask", True) <> 0 Then
					GoTo IL_9E
				End If
				IL_54:
				num2 = 10
				If dataColumnProperty.oO.OO..DataType Is GetType(String) AndAlso dataColumnProperty.oO.OO..MaxLength <> -1 AndAlso dataColumnProperty.oO.OO..MaxLength <= 255 Then
					GoTo IL_7DA
				End If
				IL_94:
				num2 = 11
				result = False
				GoTo IL_22A4
				IL_9E:
				num2 = 13
				If Operators.CompareString(left, "BooleanFormat", True) <> 0 Then
					GoTo IL_D8
				End If
				IL_B0:
				num2 = 14
				If dataColumnProperty.oO.OO..DataType Is GetType(Boolean) Then
					GoTo IL_7DA
				End If
				IL_CE:
				num2 = 15
				result = False
				GoTo IL_22A4
				IL_D8:
				num2 = 17
				If Operators.CompareString(left, "DateTimeFormat", True) <> 0 Then
					GoTo IL_112
				End If
				IL_EA:
				num2 = 18
				If dataColumnProperty.oO.OO..DataType Is GetType(DateTime) Then
					GoTo IL_7DA
				End If
				IL_108:
				num2 = 19
				result = False
				GoTo IL_22A4
				IL_112:
				num2 = 21
				If Operators.CompareString(left, "FixedDigits", True) <> 0 Then
					GoTo IL_167
				End If
				IL_124:
				num2 = 22
				If dataColumnProperty.oO.OO..DataType Is GetType(Integer) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Long) Then
					GoTo IL_7DA
				End If
				IL_15D:
				num2 = 23
				result = False
				GoTo IL_22A4
				IL_167:
				num2 = 25
				If Operators.CompareString(left, "PercentStyle", True) <> 0 AndAlso Operators.CompareString(left, "FixedDecimals", True) <> 0 AndAlso Operators.CompareString(left, "Decimals", True) <> 0 Then
					GoTo IL_206
				End If
				IL_197:
				num2 = 26
				If dataColumnProperty.oO.OO..DataType Is GetType(Single) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Double) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Decimal) Then
					GoTo IL_1EC
				End If
				IL_1E2:
				num2 = 27
				result = False
				GoTo IL_22A4
				IL_1EC:
				num2 = 29
				If dataColumnProperty.ExtendColumnType <> 8 Then
					GoTo IL_7DA
				End If
				IL_1FC:
				num2 = 30
				result = False
				GoTo IL_22A4
				IL_206:
				num2 = 32
				If Operators.CompareString(left, "ThousandSeparator", True) <> 0 AndAlso Operators.CompareString(left, "CurrencySymbol", True) <> 0 AndAlso Operators.CompareString(left, "ShowCurrencySymbol", True) <> 0 Then
					GoTo IL_30E
				End If
				IL_239:
				num2 = 33
				If dataColumnProperty.oO.OO..DataType Is GetType(Single) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Double) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Decimal) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Long) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Integer) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Short) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Byte) Then
					GoTo IL_2F4
				End If
				IL_2EA:
				num2 = 34
				result = False
				GoTo IL_22A4
				IL_2F4:
				num2 = 36
				If dataColumnProperty.ExtendColumnType <> 8 Then
					GoTo IL_7DA
				End If
				IL_304:
				num2 = 37
				result = False
				GoTo IL_22A4
				IL_30E:
				num2 = 39
				If Operators.CompareString(left, "ExtendColumnType", True) <> 0 Then
					GoTo IL_37E
				End If
				IL_320:
				num2 = 40
				If dataColumnProperty.oO.OO..DataType Is GetType(Integer) OrElse dataColumnProperty.oO.OO..DataType Is GetType(String) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Double) Then
					GoTo IL_7DA
				End If
				IL_374:
				num2 = 41
				result = False
				GoTo IL_22A4
				IL_37E:
				num2 = 43
				If Operators.CompareString(left, "Remote", True) <> 0 AndAlso Operators.CompareString(left, "AutoDeleteAttachFile", True) <> 0 Then
					GoTo IL_3E5
				End If
				IL_39F:
				num2 = 44
				If(dataColumnProperty.ExtendColumnType = 3 OrElse dataColumnProperty.ExtendColumnType = 6 OrElse dataColumnProperty.ExtendColumnType = 4) AndAlso dataColumnProperty.oO.OO..DataType Is GetType(String) Then
					GoTo IL_7DA
				End If
				IL_3DB:
				num2 = 45
				result = False
				GoTo IL_22A4
				IL_3E5:
				num2 = 47
				If Operators.CompareString(left, "Host", True) <> 0 AndAlso Operators.CompareString(left, "Account", True) <> 0 AndAlso Operators.CompareString(left, "Password", True) <> 0 AndAlso Operators.CompareString(left, "RootDir", True) <> 0 AndAlso Operators.CompareString(left, "UTF8", True) <> 0 AndAlso Operators.CompareString(left, "AutoDownload", True) <> 0 AndAlso Operators.CompareString(left, "AutoUpdate", True) <> 0 AndAlso Operators.CompareString(left, "Port", True) <> 0 Then
					GoTo IL_4DB
				End If
				IL_460:
				num2 = 48
				If(dataColumnProperty.ExtendColumnType = 3 OrElse dataColumnProperty.ExtendColumnType = 6 OrElse dataColumnProperty.ExtendColumnType = 4) AndAlso dataColumnProperty.oO.OO..DataType Is GetType(String) AndAlso dataColumnProperty.Remote Then
					GoTo IL_4AC
				End If
				IL_4A2:
				num2 = 49
				result = False
				GoTo IL_22A4
				IL_4AC:
				num2 = 51
				If Operators.CompareString(name, "AutoDownload", True) <> 0 Then
					GoTo IL_7DA
				End If
				IL_4C1:
				num2 = 52
				If dataColumnProperty.ExtendColumnType = 4 Then
					GoTo IL_7DA
				End If
				IL_4D1:
				num2 = 53
				result = False
				GoTo IL_22A4
				IL_4DB:
				num2 = 55
				If Operators.CompareString(left, "AutoCopyAttachFile", True) <> 0 AndAlso Operators.CompareString(left, "FileFilter", True) <> 0 AndAlso Operators.CompareString(left, "FolderName", True) <> 0 AndAlso Operators.CompareString(left, "SourceFolder", True) <> 0 Then
					GoTo IL_569
				End If
				IL_51A:
				num2 = 56
				If(dataColumnProperty.ExtendColumnType = 3 OrElse dataColumnProperty.ExtendColumnType = 6 OrElse dataColumnProperty.ExtendColumnType = 4) AndAlso dataColumnProperty.oO.OO..DataType Is GetType(String) AndAlso Not dataColumnProperty.Remote Then
					GoTo IL_7DA
				End If
				IL_55F:
				num2 = 57
				result = False
				GoTo IL_22A4
				IL_569:
				num2 = 59
				If Operators.CompareString(left, "DockImage", True) <> 0 AndAlso Operators.CompareString(left, "DockArea", True) <> 0 AndAlso Operators.CompareString(left, "DockTitle", True) <> 0 AndAlso Operators.CompareString(left, "AutoOpen", True) <> 0 AndAlso Operators.CompareString(left, "AutoHide", True) <> 0 AndAlso Operators.CompareString(left, "ShowCaption", True) <> 0 AndAlso Operators.CompareString(left, "AllowClose", True) <> 0 Then
					GoTo IL_633
				End If
				IL_5D5:
				num2 = 60
				If(dataColumnProperty.ExtendColumnType = 6 OrElse dataColumnProperty.ExtendColumnType = 4 OrElse dataColumnProperty.oO.OO..MaxLength < 0 OrElse dataColumnProperty.oO.OO..MaxLength > 255) AndAlso dataColumnProperty.oO.OO..DataType Is GetType(String) Then
					GoTo IL_7DA
				End If
				IL_629:
				num2 = 61
				result = False
				GoTo IL_22A4
				IL_633:
				num2 = 63
				If Operators.CompareString(left, "UsetBuildInEditor", True) <> 0 Then
					GoTo IL_760
				End If
				IL_648:
				num2 = 64
				If dataColumnProperty.oO.OO..DataType Is GetType(Single) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Double) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Decimal) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Long) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Integer) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Short) OrElse dataColumnProperty.oO.OO..DataType Is GetType(Byte) OrElse dataColumnProperty.oO.OO..DataType Is GetType(DateTime) Then
					GoTo IL_71E
				End If
				IL_714:
				num2 = 65
				result = False
				GoTo IL_22A4
				IL_71E:
				num2 = 66
				If dataColumnProperty.oO.OO..DataType IsNot GetType(DateTime) Then
					GoTo IL_7DA
				End If
				IL_73C:
				num2 = 67
				If dataColumnProperty.DateTimeFormat <> 1 AndAlso dataColumnProperty.DateTimeFormat <> 2 Then
					GoTo IL_7DA
				End If
				IL_756:
				num2 = 68
				result = False
				GoTo IL_22A4
				IL_760:
				num2 = 70
				If Operators.CompareString(left, "DataMapType", True) <> 0 AndAlso Operators.CompareString(left, "ImageMapType", True) <> 0 AndAlso Operators.CompareString(left, "ItemSpacing", True) <> 0 Then
					GoTo IL_7AC
				End If
				IL_790:
				num2 = 71
				If dataColumnProperty.oO.OO..ExtendColumnType <> 7 Then
					GoTo IL_7DA
				End If
				IL_7A2:
				num2 = 72
				result = False
				GoTo IL_22A4
				IL_7AC:
				num2 = 74
				If Operators.CompareString(left, "Separator", True) <> 0 Then
					GoTo IL_7DA
				End If
				IL_7BE:
				num2 = 75
				If dataColumnProperty.oO.OO..ExtendColumnType = 7 Then
					GoTo IL_7DA
				End If
				IL_7D0:
				num2 = 76
				result = False
				GoTo IL_22A4
				IL_7DA:
				dataColumnProperty = Nothing
				GoTo IL_229C
				IL_7E2:
				num2 = 79
				If Not(TypeOf A_0 Is TableGridProperty) Then
					GoTo IL_9C1
				End If
				IL_7F0:
				num2 = 80
				Dim tableGridProperty As TableGridProperty = CType(A_0, TableGridProperty)
				IL_7FB:
				num2 = 81
				Dim left2 As String = name
				IL_802:
				num2 = 83
				If Operators.CompareString(left2, "Connection", True) <> 0 AndAlso Operators.CompareString(left2, "SelectString", True) <> 0 Then
					GoTo IL_83C
				End If
				IL_823:
				num2 = 84
				If tableGridProperty.TableType IsNot Nothing Then
					GoTo IL_8CD
				End If
				IL_832:
				num2 = 85
				result = False
				GoTo IL_22A4
				IL_83C:
				num2 = 87
				If Operators.CompareString(left2, "RelationTable", True) <> 0 AndAlso Operators.CompareString(left2, "IsCopy", True) <> 0 Then
					GoTo IL_873
				End If
				IL_85D:
				num2 = 88
				If tableGridProperty.TableType Is Nothing Then
					GoTo IL_8CD
				End If
				IL_869:
				num2 = 89
				result = False
				GoTo IL_22A4
				IL_873:
				num2 = 91
				If Operators.CompareString(left2, "AllowEdit", True) <> 0 Then
					GoTo IL_89C
				End If
				IL_885:
				num2 = 92
				If tableGridProperty.TableType <> 2 Then
					GoTo IL_8CD
				End If
				IL_892:
				num2 = 93
				result = False
				GoTo IL_22A4
				IL_89C:
				num2 = 95
				If Operators.CompareString(left2, "Font", True) <> 0 Then
					GoTo IL_8CD
				End If
				IL_8AE:
				num2 = 96
				If tableGridProperty.TableType IsNot Nothing OrElse tableGridProperty.IsCopy Then
					GoTo IL_8CD
				End If
				IL_8C3:
				num2 = 97
				result = False
				GoTo IL_22A4
				IL_8CD:
				num2 = 98
				If A_1 Is Nothing OrElse Not O00OOOo_O0_O.Oo_o_o.__oo.(A_1) Then
					GoTo IL_9B9
				End If
				IL_8E1:
				num2 = 99
				If tableGridProperty.TableType IsNot Nothing Then
					GoTo IL_9B9
				End If
				IL_8F0:
				num2 = 100
				If Not tableGridProperty.IsCopy Then
					GoTo IL_9AF
				End If
				IL_8FF:
				num2 = 101
				Dim left3 As String = name
				IL_906:
				num2 = 103
				If Operators.CompareString(left3, "CurrentChanged", True) = 0 OrElse Operators.CompareString(left3, "PositionChanged", True) = 0 OrElse Operators.CompareString(left3, "DoubleClick", True) = 0 OrElse Operators.CompareString(left3, "KeyUp", True) = 0 OrElse Operators.CompareString(left3, "KeyDown", True) = 0 OrElse Operators.CompareString(left3, "BeforeCheckRow", True) = 0 OrElse Operators.CompareString(left3, "AfterCheckRow", True) = 0 OrElse Operators.CompareString(left3, "AfterScroll", True) = 0 OrElse Operators.CompareString(left3, "Click", True) = 0 OrElse Operators.CompareString(left3, "DoubleClickRowHeader", True) = 0 Then
					GoTo IL_9B9
				End If
				IL_9A5:
				num2 = 105
				result = False
				GoTo IL_22A4
				IL_9AF:
				num2 = 107
				result = False
				GoTo IL_22A4
				IL_9B9:
				tableGridProperty = Nothing
				GoTo IL_229C
				IL_9C1:
				num2 = 110
				If Not(TypeOf A_0 Is FormProperty) Then
					GoTo IL_C7D
				End If
				IL_9CF:
				num2 = 111
				Dim formProperty As FormProperty = CType(A_0, FormProperty)
				IL_9DA:
				num2 = 112
				Dim left4 As String = category
				IL_9E1:
				num2 = 114
				If Operators.CompareString(left4, "停靠", True) <> 0 Then
					GoTo IL_A4A
				End If
				IL_9F3:
				num2 = 115
				If Operators.CompareString(A_1.Name, "DockTitle", True) <> 0 Then
					GoTo IL_A23
				End If
				IL_A09:
				num2 = 116
				If formProperty.FormStyle = FormStyleEnum.停靠 Then
					GoTo IL_C75
				End If
				IL_A19:
				num2 = 117
				result = False
				GoTo IL_22A4
				IL_A23:
				num2 = 119
				If formProperty.FormStyle = FormStyleEnum.停靠 OrElse formProperty.FormStyle = FormStyleEnum.共有 Then
					GoTo IL_C75
				End If
				IL_A40:
				num2 = 120
				result = False
				GoTo IL_22A4
				IL_A4A:
				num2 = 122
				If Operators.CompareString(left4, "位置", True) <> 0 AndAlso Operators.CompareString(left4, "行为", True) <> 0 Then
					GoTo IL_ACE
				End If
				IL_A6B:
				num2 = 123
				If formProperty.FormStyle = FormStyleEnum.独立 OrElse formProperty.FormStyle = FormStyleEnum.模式 OrElse formProperty.FormStyle = FormStyleEnum.PopupForm Then
					GoTo IL_C75
				End If
				IL_A95:
				num2 = 124
				If Operators.CompareString(A_1.Name, "Height", True) = 0 OrElse Operators.CompareString(A_1.Name, "Width", True) = 0 Then
					GoTo IL_C75
				End If
				IL_AC4:
				num2 = 125
				result = False
				GoTo IL_22A4
				IL_ACE:
				num2 = 127
				Dim name2 As String = A_1.Name
				IL_AD9:
				num2 = 129
				If Operators.CompareString(name2, "ShowIcon", True) <> 0 AndAlso Operators.CompareString(name2, "ControlBox", True) <> 0 Then
					GoTo IL_B37
				End If
				IL_AFD:
				num2 = 130
				If formProperty.FormStyle = FormStyleEnum.独立 OrElse formProperty.FormStyle = FormStyleEnum.模式 OrElse formProperty.FormStyle = FormStyleEnum.PopupForm Then
					GoTo IL_C75
				End If
				IL_B2A:
				num2 = 131
				result = False
				GoTo IL_22A4
				IL_B37:
				num2 = 133
				If Operators.CompareString(name2, "MaximizeBox", True) <> 0 AndAlso Operators.CompareString(name2, "MinimizeBox", True) <> 0 AndAlso Operators.CompareString(name2, "ResizingControl", True) <> 0 AndAlso Operators.CompareString(name2, "ResizingFont", True) <> 0 AndAlso Operators.CompareString(name2, "AutoLayout", True) <> 0 Then
					GoTo IL_BB5
				End If
				IL_B88:
				num2 = 134
				If formProperty.FormStyle = FormStyleEnum.独立 OrElse formProperty.FormStyle = FormStyleEnum.模式 Then
					GoTo IL_C75
				End If
				IL_BA8:
				num2 = 135
				result = False
				GoTo IL_22A4
				IL_BB5:
				num2 = 137
				If Operators.CompareString(name2, "TabAlignment", True) <> 0 Then
					GoTo IL_BE9
				End If
				IL_BCA:
				num2 = 138
				If formProperty.FormStyle = FormStyleEnum.并列 Then
					GoTo IL_C75
				End If
				IL_BDC:
				num2 = 139
				result = False
				GoTo IL_22A4
				IL_BE9:
				num2 = 141
				If Operators.CompareString(name2, "AutoOpen", True) <> 0 Then
					GoTo IL_C25
				End If
				IL_BFE:
				num2 = 142
				If formProperty.FormStyle <> FormStyleEnum.模式 AndAlso formProperty.FormStyle <> FormStyleEnum.DropDownForm Then
					GoTo IL_C75
				End If
				IL_C18:
				num2 = 143
				result = False
				GoTo IL_22A4
				IL_C25:
				num2 = 145
				If Operators.CompareString(name2, "DropDownOpened", True) <> 0 AndAlso Operators.CompareString(name2, "DropDownOpening", True) <> 0 AndAlso Operators.CompareString(name2, "DropDownClosed", True) <> 0 Then
					GoTo IL_C75
				End If
				IL_C58:
				num2 = 146
				If formProperty.FormStyle = FormStyleEnum.DropDownForm Then
					GoTo IL_C75
				End If
				IL_C68:
				num2 = 147
				result = False
				GoTo IL_22A4
				IL_C75:
				formProperty = Nothing
				GoTo IL_229C
				IL_C7D:
				num2 = 150
				If Not(TypeOf A_0 Is BarCodeProperty) AndAlso Not(TypeOf A_0 Is BarcodeProfessionalProperty) Then
					GoTo IL_1489
				End If
				IL_C96:
				num2 = 151
				If Not(TypeOf A_0 Is BarCodeProperty) Then
					GoTo IL_CC3
				End If
				IL_CA4:
				num2 = 152
				Dim barCodeProperty As BarCodeProperty = CType(A_0, BarCodeProperty)
				IL_CB2:
				num2 = 153
				Dim symbology As Symbology = barCodeProperty.Symbology
				GoTo IL_CE0
				IL_CC3:
				num2 = 155
				Dim barcodeProfessionalProperty As BarcodeProfessionalProperty = CType(A_0, BarcodeProfessionalProperty)
				IL_CD1:
				num2 = 156
				symbology = barcodeProfessionalProperty.Symbology
				IL_CE0:
				num2 = 157
				Dim left5 As String = category
				IL_CEA:
				num2 = 159
				If Operators.CompareString(left5, "条码设置 - AztecCode", True) <> 0 Then
					GoTo IL_D1B
				End If
				IL_CFF:
				num2 = 160
				If symbology = 50 Then
					GoTo IL_229C
				End If
				IL_D0E:
				num2 = 161
				result = False
				GoTo IL_22A4
				IL_D1B:
				num2 = 163
				If Operators.CompareString(left5, "条码设置 - Codabar", True) <> 0 Then
					GoTo IL_D4A
				End If
				IL_D30:
				num2 = 164
				If symbology Is Nothing Then
					GoTo IL_229C
				End If
				IL_D3D:
				num2 = 165
				result = False
				GoTo IL_22A4
				IL_D4A:
				num2 = 167
				If Operators.CompareString(left5, "条码设置 - Code128", True) <> 0 Then
					GoTo IL_D7A
				End If
				IL_D5F:
				num2 = 168
				If symbology = 5 Then
					GoTo IL_229C
				End If
				IL_D6D:
				num2 = 169
				result = False
				GoTo IL_22A4
				IL_D7A:
				num2 = 171
				If Operators.CompareString(left5, "条码设置 - Code16K", True) <> 0 Then
					GoTo IL_DAA
				End If
				IL_D8F:
				num2 = 172
				If symbology = 2 Then
					GoTo IL_229C
				End If
				IL_D9D:
				num2 = 173
				result = False
				GoTo IL_22A4
				IL_DAA:
				num2 = 175
				If Operators.CompareString(left5, "条码设置 - DataMatrix", True) <> 0 Then
					GoTo IL_DDA
				End If
				IL_DBF:
				num2 = 176
				If symbology = 6 Then
					GoTo IL_229C
				End If
				IL_DCD:
				num2 = 177
				result = False
				GoTo IL_22A4
				IL_DDA:
				num2 = 179
				If Operators.CompareString(left5, "条码设置 - Ean And Upc", True) <> 0 Then
					GoTo IL_E72
				End If
				IL_DF2:
				num2 = 180
				If symbology <= 17 Then
					Select Case symbology
						Case 7, 8, 11
							GoTo IL_229C
						Case 9, 10
						Case Else
							If symbology = 17 Then
								GoTo IL_229C
							End If
					End Select
				Else
					If symbology = 18 Then
						GoTo IL_229C
					End If
					Select Case symbology
						Case 29, 31, 32, 35, 38, 39
							GoTo IL_229C
					End Select
				End If
				IL_E65:
				num2 = 193
				result = False
				GoTo IL_22A4
				IL_E72:
				num2 = 196
				If Operators.CompareString(left5, "条码设置 - ExpandedStacked", True) <> 0 Then
					GoTo IL_EB2
				End If
				IL_E87:
				num2 = 197
				If Not(symbology <> 83 And symbology <> 84) Then
					GoTo IL_229C
				End If
				IL_EA5:
				num2 = 198
				result = False
				GoTo IL_22A4
				IL_EB2:
				num2 = 200
				If Operators.CompareString(left5, "条码设置 - HIBC", True) <> 0 Then
					GoTo IL_EF4
				End If
				IL_EC7:
				num2 = 201
				Select Case symbology
					Case 58, 59, 60, 61
						IL_229C:
						num2 = 525
						result = True
						GoTo IL_22A4
					Case Else
						IL_EE7:
						num2 = 207
						result = False
						GoTo IL_22A4
				End Select
				IL_EF4:
				num2 = 210
				If Operators.CompareString(left5, "条码设置 - ISBT", True) <> 0 Then
					GoTo IL_F25
				End If
				IL_F09:
				num2 = 211
				If symbology = 57 Then
					GoTo IL_229C
				End If
				IL_F18:
				num2 = 212
				result = False
				GoTo IL_22A4
				IL_F25:
				num2 = 214
				If Operators.CompareString(left5, "条码设置 - MaxiCode", True) <> 0 Then
					GoTo IL_F56
				End If
				IL_F3A:
				num2 = 215
				If symbology = 86 Then
					GoTo IL_229C
				End If
				IL_F49:
				num2 = 216
				result = False
				GoTo IL_22A4
				IL_F56:
				num2 = 218
				If Operators.CompareString(left5, "条码设置 - MSI", True) <> 0 Then
					GoTo IL_F87
				End If
				IL_F6B:
				num2 = 219
				If symbology = 12 Then
					GoTo IL_229C
				End If
				IL_F7A:
				num2 = 220
				result = False
				GoTo IL_22A4
				IL_F87:
				num2 = 222
				If Operators.CompareString(left5, "条码设置 - PDF417", True) <> 0 Then
					GoTo IL_1055
				End If
				IL_F9F:
				num2 = 223
				Dim left6 As String = name
				IL_FA9:
				num2 = 225
				If Operators.CompareString(left6, "MicroPdf417Version", True) <> 0 Then
					GoTo IL_FD7
				End If
				IL_FBE:
				num2 = 226
				If symbology = 53 Then
					GoTo IL_1023
				End If
				IL_FCA:
				num2 = 227
				result = False
				GoTo IL_22A4
				IL_FD7:
				num2 = 229
				If Operators.CompareString(left6, "Pdf417FileId", True) <> 0 AndAlso Operators.CompareString(left6, "Pdf417SegmentCount", True) <> 0 AndAlso Operators.CompareString(left6, "Pdf417SegmentIndex", True) <> 0 Then
					GoTo IL_1023
				End If
				IL_100A:
				num2 = 230
				If symbology = 52 Then
					GoTo IL_1023
				End If
				IL_1016:
				num2 = 231
				result = False
				GoTo IL_22A4
				IL_1023:
				num2 = 232
				If symbology = 13 Then
					GoTo IL_229C
				End If
				Select Case symbology
					Case 51, 52, 53
						GoTo IL_229C
					Case Else
						IL_1048:
						num2 = 238
						result = False
						GoTo IL_22A4
				End Select
				IL_1055:
				num2 = 241
				If Operators.CompareString(left5, "条码设置 - Pharmacode", True) <> 0 Then
					GoTo IL_1086
				End If
				IL_106A:
				num2 = 242
				If symbology = 45 Then
					GoTo IL_229C
				End If
				IL_1079:
				num2 = 243
				result = False
				GoTo IL_22A4
				IL_1086:
				num2 = 245
				If Operators.CompareString(left5, "条码设置 - Planet", True) <> 0 Then
					GoTo IL_10B7
				End If
				IL_109B:
				num2 = 246
				If symbology = 14 Then
					GoTo IL_229C
				End If
				IL_10AA:
				num2 = 247
				result = False
				GoTo IL_22A4
				IL_10B7:
				num2 = 249
				If Operators.CompareString(left5, "条码设置 - Postal 4-State", True) <> 0 Then
					GoTo IL_1136
				End If
				IL_10CC:
				num2 = 250
				If Operators.CompareString(name, "Postal4StateAddStartStopChar", True) <> 0 Then
					GoTo IL_1100
				End If
				IL_10E1:
				num2 = 251
				If symbology = 30 OrElse symbology = 20 Then
					GoTo IL_1100
				End If
				IL_10F3:
				num2 = 252
				result = False
				GoTo IL_22A4
				IL_1100:
				num2 = 253
				Select Case symbology
					Case 19, 20, 21, 22
						GoTo IL_229C
					Case Else
						If symbology = 30 Then
							GoTo IL_229C
						End If
						IL_1129:
						num2 = 260
						result = False
						GoTo IL_22A4
				End Select
				IL_1136:
				num2 = 263
				If Operators.CompareString(left5, "条码设置 - Postnet", True) <> 0 Then
					GoTo IL_1167
				End If
				IL_114B:
				num2 = 264
				If symbology = 15 Then
					GoTo IL_229C
				End If
				IL_115A:
				num2 = 265
				result = False
				GoTo IL_22A4
				IL_1167:
				num2 = 267
				If Operators.CompareString(left5, "条码设置 - QR Code", True) <> 0 Then
					GoTo IL_120C
				End If
				IL_117F:
				num2 = 268
				If Not(symbology <> 41 And symbology <> 87) Then
					GoTo IL_11A7
				End If
				IL_119A:
				num2 = 269
				result = False
				GoTo IL_22A4
				IL_11A7:
				num2 = 271
				If symbology <> 87 Then
					GoTo IL_11D8
				End If
				IL_11B3:
				num2 = 272
				If Operators.CompareString(name, "QRCodeVersion", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_11CB:
				num2 = 273
				result = False
				GoTo IL_22A4
				IL_11D8:
				num2 = 275
				If symbology <> 41 Then
					GoTo IL_229C
				End If
				IL_11E7:
				num2 = 276
				If Operators.CompareString(name, "MicroQRCodeVersion", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_11FF:
				num2 = 277
				result = False
				GoTo IL_22A4
				IL_120C:
				num2 = 279
				If Operators.CompareString(left5, "条码设置 - Telepen", True) <> 0 Then
					GoTo IL_123D
				End If
				IL_1221:
				num2 = 280
				If symbology = 44 Then
					GoTo IL_229C
				End If
				IL_1230:
				num2 = 281
				result = False
				GoTo IL_22A4
				IL_123D:
				num2 = 283
				If Operators.CompareString(left5, "条码设置 - USPS FIM", True) <> 0 Then
					GoTo IL_126E
				End If
				IL_1252:
				num2 = 284
				If symbology = 42 Then
					GoTo IL_229C
				End If
				IL_1261:
				num2 = 285
				result = False
				GoTo IL_22A4
				IL_126E:
				num2 = 287
				If Operators.CompareString(left5, "条码设置 - USPS Horizontal Bars", True) <> 0 Then
					GoTo IL_129F
				End If
				IL_1283:
				num2 = 288
				If symbology = 43 Then
					GoTo IL_229C
				End If
				IL_1292:
				num2 = 289
				result = False
				GoTo IL_22A4
				IL_129F:
				num2 = 291
				If Operators.CompareString(left5, "条码设置 - 文本", True) <> 0 Then
					GoTo IL_1340
				End If
				IL_12B7:
				num2 = 292
				If symbology <= 13 Then
					If symbology <> 2 AndAlso symbology <> 6 AndAlso symbology <> 13 Then
						GoTo IL_229C
					End If
				ElseIf symbology <= 46 Then
					If symbology <> 41 AndAlso symbology <> 46 Then
						GoTo IL_229C
					End If
				ElseIf symbology - 50 > 3 AndAlso symbology - 86 > 1 Then
					GoTo IL_229C
				End If
				IL_1302:
				num2 = 294
				Dim left7 As String = name
				IL_130C:
				num2 = 296
				If Operators.CompareString(left7, "DisplayChecksum", True) <> 0 AndAlso Operators.CompareString(left7, "DisplayStartStopChar", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1333:
				num2 = 297
				result = False
				GoTo IL_22A4
				IL_1340:
				num2 = 300
				If Operators.CompareString(left5, "条码设置", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1358:
				num2 = 301
				If symbology <= 6 Then
					If symbology <> 2 Then
						If symbology <> 6 Then
							GoTo IL_229C
						End If
						GoTo IL_1424
					End If
				Else
					Select Case symbology
						Case 41, 46
							GoTo IL_1424
						Case 42, 43
						Case 44, 45
							GoTo IL_229C
						Case Else
							If symbology <> 50 AndAlso symbology - 86 > 1 Then
								GoTo IL_229C
							End If
							GoTo IL_1424
					End Select
				End If
				IL_13AD:
				num2 = 303
				Dim left8 As String = name
				IL_13B7:
				num2 = 305
				If Operators.CompareString(left8, "CodeType", True) = 0 OrElse Operators.CompareString(left8, "Rotate", True) = 0 OrElse Operators.CompareString(left8, "BarWidth", True) = 0 OrElse Operators.CompareString(left8, "BarHeight", True) = 0 OrElse Operators.CompareString(left8, "QuietZoneWidth", True) = 0 Then
					GoTo IL_229C
				End If
				IL_1417:
				num2 = 307
				result = False
				GoTo IL_22A4
				IL_1424:
				num2 = 309
				Dim left9 As String = name
				IL_142E:
				num2 = 311
				If Operators.CompareString(left9, "CodeType", True) = 0 OrElse Operators.CompareString(left9, "Code", True) = 0 OrElse Operators.CompareString(left9, "Rotate", True) = 0 OrElse Operators.CompareString(left9, "QuietZoneWidth", True) = 0 Then
					GoTo IL_229C
				End If
				IL_147C:
				num2 = 313
				result = False
				GoTo IL_22A4
				IL_1489:
				num2 = 316
				If Not(TypeOf A_0 Is TreeViewProperty) Then
					GoTo IL_152A
				End If
				IL_149A:
				num2 = 317
				Dim treeView As System.Windows.Forms.TreeView = CType(CType(A_0, TreeViewProperty).o_O0.O_., System.Windows.Forms.TreeView)
				IL_14B2:
				num2 = 318
				If Not name.StartsWith("Node") OrElse Operators.CompareString(category, "事件", True) = 0 OrElse Operators.CompareString(name, "NodesSettingString", True) = 0 Then
					GoTo IL_1500
				End If
				IL_14E4:
				num2 = 319
				If treeView.SelectedNode IsNot Nothing Then
					GoTo IL_1500
				End If
				IL_14F3:
				num2 = 320
				result = False
				GoTo IL_22A4
				IL_1500:
				num2 = 321
				If Operators.CompareString(category, "输出", True) <> 0 Then
					GoTo IL_1522
				End If
				IL_1515:
				num2 = 322
				result = False
				GoTo IL_22A4
				IL_1522:
				treeView = Nothing
				GoTo IL_229C
				IL_152A:
				num2 = 325
				If Not(TypeOf A_0 Is ChartProperty) Then
					GoTo IL_155D
				End If
				IL_1538:
				num2 = 326
				If Operators.CompareString(category, "事件", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1550:
				num2 = 327
				result = False
				GoTo IL_22A4
				IL_155D:
				num2 = 329
				If Not(TypeOf A_0 Is FileManagerProperty) Then
					GoTo IL_1677
				End If
				IL_156E:
				num2 = 330
				Dim fileManagerProperty As FileManagerProperty = CType(A_0, FileManagerProperty)
				IL_157C:
				num2 = 331
				Dim left10 As String = name
				IL_1586:
				num2 = 333
				If Operators.CompareString(left10, "Host", True) <> 0 AndAlso Operators.CompareString(left10, "Account", True) <> 0 AndAlso Operators.CompareString(left10, "Password", True) <> 0 AndAlso Operators.CompareString(left10, "RootDir", True) <> 0 AndAlso Operators.CompareString(left10, "UTF8", True) <> 0 AndAlso Operators.CompareString(left10, "AutoUpdate", True) <> 0 AndAlso Operators.CompareString(left10, "Port", True) <> 0 Then
					GoTo IL_1611
				End If
				IL_15F5:
				num2 = 334
				If fileManagerProperty.Remote Then
					GoTo IL_166F
				End If
				IL_1604:
				num2 = 335
				result = False
				GoTo IL_22A4
				IL_1611:
				num2 = 337
				If Operators.CompareString(left10, "AutoCopyAttachFile", True) <> 0 AndAlso Operators.CompareString(left10, "FileFilter", True) <> 0 AndAlso Operators.CompareString(left10, "FolderName", True) <> 0 AndAlso Operators.CompareString(left10, "SourceFolder", True) <> 0 Then
					GoTo IL_166F
				End If
				IL_1653:
				num2 = 338
				If Not fileManagerProperty.Remote Then
					GoTo IL_166F
				End If
				IL_1662:
				num2 = 339
				result = False
				GoTo IL_22A4
				IL_166F:
				fileManagerProperty = Nothing
				GoTo IL_229C
				IL_1677:
				num2 = 342
				If Not(TypeOf A_0 Is PictureViewerProperty) Then
					GoTo IL_17A0
				End If
				IL_1688:
				num2 = 343
				Dim pictureViewerProperty As PictureViewerProperty = CType(A_0, PictureViewerProperty)
				IL_1696:
				num2 = 344
				Dim left11 As String = name
				IL_16A0:
				num2 = 346
				If Operators.CompareString(left11, "Host", True) <> 0 AndAlso Operators.CompareString(left11, "Account", True) <> 0 AndAlso Operators.CompareString(left11, "Password", True) <> 0 AndAlso Operators.CompareString(left11, "RootDir", True) <> 0 AndAlso Operators.CompareString(left11, "UTF8", True) <> 0 AndAlso Operators.CompareString(left11, "AutoDownload", True) <> 0 AndAlso Operators.CompareString(left11, "AutoUpdate", True) <> 0 AndAlso Operators.CompareString(left11, "Port", True) <> 0 Then
					GoTo IL_173A
				End If
				IL_171E:
				num2 = 347
				If pictureViewerProperty.Remote Then
					GoTo IL_1798
				End If
				IL_172D:
				num2 = 348
				result = False
				GoTo IL_22A4
				IL_173A:
				num2 = 350
				If Operators.CompareString(left11, "AutoCopyAttachFile", True) <> 0 AndAlso Operators.CompareString(left11, "FileFilter", True) <> 0 AndAlso Operators.CompareString(left11, "FolderName", True) <> 0 AndAlso Operators.CompareString(left11, "SourceFolder", True) <> 0 Then
					GoTo IL_1798
				End If
				IL_177C:
				num2 = 351
				If Not pictureViewerProperty.Remote Then
					GoTo IL_1798
				End If
				IL_178B:
				num2 = 352
				result = False
				GoTo IL_22A4
				IL_1798:
				pictureViewerProperty = Nothing
				GoTo IL_229C
				IL_17A0:
				num2 = 355
				If Not(TypeOf A_0 Is PictureBoxProperty) Then
					GoTo IL_187E
				End If
				IL_17B1:
				num2 = 356
				Dim pictureBoxProperty As PictureBoxProperty = CType(A_0, PictureBoxProperty)
				IL_17BF:
				num2 = 357
				Dim left12 As String = name
				IL_17C9:
				num2 = 359
				If Operators.CompareString(left12, "Host", True) <> 0 AndAlso Operators.CompareString(left12, "Account", True) <> 0 AndAlso Operators.CompareString(left12, "Password", True) <> 0 AndAlso Operators.CompareString(left12, "UTF8", True) <> 0 AndAlso Operators.CompareString(left12, "AutoUpdate", True) <> 0 AndAlso Operators.CompareString(left12, "Port", True) <> 0 Then
					GoTo IL_1845
				End If
				IL_1829:
				num2 = 360
				If pictureBoxProperty.Remote Then
					GoTo IL_1876
				End If
				IL_1838:
				num2 = 361
				result = False
				GoTo IL_22A4
				IL_1845:
				num2 = 363
				If Operators.CompareString(left12, "FolderName", True) <> 0 Then
					GoTo IL_1876
				End If
				IL_185A:
				num2 = 364
				If Not pictureBoxProperty.Remote Then
					GoTo IL_1876
				End If
				IL_1869:
				num2 = 365
				result = False
				GoTo IL_22A4
				IL_1876:
				pictureBoxProperty = Nothing
				GoTo IL_229C
				IL_187E:
				num2 = 368
				If Not(TypeOf A_0 Is ControlPropertyBase) Then
					GoTo IL_1EEC
				End If
				IL_188F:
				num2 = 369
				Dim controlPropertyBase As ControlPropertyBase = CType(A_0, ControlPropertyBase)
				IL_189D:
				num2 = 370
				If Not(TypeOf controlPropertyBase.o_O0.O_. Is C1TextBox) Then
					GoTo IL_1953
				End If
				IL_18B4:
				num2 = 371
				Dim left13 As String = name
				IL_18BE:
				num2 = 373
				If Operators.CompareString(left13, "BackColor", True) <> 0 AndAlso Operators.CompareString(left13, "ForeColor", True) <> 0 AndAlso Operators.CompareString(left13, "BorderColor", True) <> 0 AndAlso Operators.CompareString(left13, "BorderStyle", True) <> 0 Then
					GoTo IL_19D3
				End If
				IL_1903:
				num2 = 374
				Dim left14 As String = Main.OO_O.o..o0_o_o_0.0O.(controlPropertyBase.o_O0.O_.)
				IL_191C:
				num2 = 375
				If Operators.CompareString(left14, "(none)", True) = 0 OrElse Operators.CompareString(left14, "", True) = 0 Then
					GoTo IL_19D3
				End If
				IL_1946:
				num2 = 376
				result = False
				GoTo IL_22A4
				IL_1953:
				num2 = 378
				If Not(TypeOf controlPropertyBase.o_O0.O_. Is oo00) Then
					GoTo IL_19D3
				End If
				IL_1967:
				num2 = 379
				Dim left15 As String = name
				IL_1971:
				num2 = 381
				If Operators.CompareString(left15, "Cursor", True) <> 0 AndAlso Operators.CompareString(left15, "ForeColor", True) <> 0 AndAlso Operators.CompareString(left15, "Font", True) <> 0 Then
					GoTo IL_19B1
				End If
				IL_19A4:
				num2 = 382
				result = False
				GoTo IL_22A4
				IL_19B1:
				num2 = 383
				If Operators.CompareString(category, "事件", True) <> 0 Then
					GoTo IL_19D3
				End If
				IL_19C6:
				num2 = 384
				result = False
				GoTo IL_22A4
				IL_19D3:
				controlPropertyBase = Nothing
				IL_19D6:
				num2 = 386
				Dim left16 As String = name
				IL_19E0:
				num2 = 388
				If Operators.CompareString(left16, "ForeColor", True) <> 0 AndAlso Operators.CompareString(left16, "Font", True) <> 0 Then
					GoTo IL_1ADB
				End If
				IL_1A07:
				num2 = 389
				If Not(TypeOf A_0 Is CheckBoxProperty) Then
					GoTo IL_1A51
				End If
				IL_1A15:
				num2 = 390
				If Operators.CompareString(name, "ForeColor", True) <> 0 Then
					GoTo IL_1EB6
				End If
				IL_1A2D:
				num2 = 391
				If CType(A_0, CheckBoxProperty).Appearance <> Appearance.Button Then
					GoTo IL_1EB6
				End If
				IL_1A44:
				num2 = 392
				result = False
				GoTo IL_22A4
				IL_1A51:
				num2 = 394
				Dim controlTypeEnum As ControlTypeEnum = CType(A_0, ControlPropertyBase).Type
				If controlTypeEnum <= ControlTypeEnum.PictureBox Then
					If controlTypeEnum <> ControlTypeEnum.Button Then
						If controlTypeEnum - ControlTypeEnum.Panel > 2 Then
							GoTo IL_1EB6
						End If
						GoTo IL_1A93
					End If
					IL_1AA0:
					num2 = 398
					If Operators.CompareString(name, "ForeColor", True) <> 0 Then
						GoTo IL_1EB6
					End If
					IL_1AB8:
					num2 = 399
					If CType(A_0, ButtonProperty).FlatStyle = FlatStyle.Flat Then
						GoTo IL_1EB6
					End If
					IL_1ACE:
					num2 = 400
					result = False
					GoTo IL_22A4
				End If
				If controlTypeEnum <> ControlTypeEnum.ColorLabel AndAlso controlTypeEnum - ControlTypeEnum.WebBrowser > 1 AndAlso controlTypeEnum <> ControlTypeEnum.PDFViewer Then
					GoTo IL_1EB6
				End If
				IL_1A93:
				num2 = 396
				result = False
				GoTo IL_22A4
				IL_1ADB:
				num2 = 403
				If Operators.CompareString(left16, "Cursor", True) <> 0 Then
					GoTo IL_1B15
				End If
				IL_1AF0:
				num2 = 404
				If CType(A_0, ControlPropertyBase).Type <> ControlTypeEnum.WebBrowser Then
					GoTo IL_1EB6
				End If
				IL_1B08:
				num2 = 405
				result = False
				GoTo IL_22A4
				IL_1B15:
				num2 = 407
				If Operators.CompareString(left16, "Printable", True) <> 0 AndAlso Operators.CompareString(left16, "NewPage", True) <> 0 Then
					GoTo IL_1C03
				End If
				IL_1B3C:
				num2 = 408
				Dim controlTypeEnum2 As ControlTypeEnum = CType(A_0, ControlPropertyBase).Type
				If controlTypeEnum2 <= ControlTypeEnum.DropDownBox Then
					Select Case controlTypeEnum2
						Case ControlTypeEnum.Label, ControlTypeEnum.TextBox, ControlTypeEnum.CheckBox, ControlTypeEnum.RadioButton, ControlTypeEnum.ComboBox, ControlTypeEnum.NumericComboBox, ControlTypeEnum.DateTimePicker, ControlTypeEnum.PictureBox
							GoTo IL_1EB6
						Case ControlTypeEnum.Button, ControlTypeEnum.TopicBar, ControlTypeEnum.ListBox, ControlTypeEnum.CheckedListBox, ControlTypeEnum.GroupBox, ControlTypeEnum.Panel, ControlTypeEnum.SplitContainer
						Case Else
							Select Case controlTypeEnum2
								Case ControlTypeEnum.Chart, ControlTypeEnum.ColorLabel, ControlTypeEnum.CheckedComboBox, ControlTypeEnum.Painter, ControlTypeEnum.Line, ControlTypeEnum.BarCode, ControlTypeEnum.DropDownBox
									GoTo IL_1EB6
							End Select
					End Select
				ElseIf controlTypeEnum2 = ControlTypeEnum.TimeSpanBox OrElse controlTypeEnum2 = ControlTypeEnum.Gauges OrElse controlTypeEnum2 = ControlTypeEnum.Map Then
					GoTo IL_1EB6
				End If
				IL_1BF6:
				num2 = 411
				result = False
				GoTo IL_22A4
				IL_1C03:
				num2 = 414
				If Operators.CompareString(left16, "PrintBorder", True) <> 0 Then
					GoTo IL_1C86
				End If
				IL_1C18:
				num2 = 415
				Dim controlTypeEnum3 As ControlTypeEnum = CType(A_0, ControlPropertyBase).Type
				If controlTypeEnum3 <= ControlTypeEnum.CheckedComboBox Then
					Select Case controlTypeEnum3
						Case ControlTypeEnum.Label, ControlTypeEnum.TextBox, ControlTypeEnum.ComboBox, ControlTypeEnum.NumericComboBox, ControlTypeEnum.DateTimePicker
							GoTo IL_1EB6
						Case ControlTypeEnum.Button, ControlTypeEnum.CheckBox, ControlTypeEnum.RadioButton, ControlTypeEnum.TopicBar
						Case Else
							If controlTypeEnum3 = ControlTypeEnum.CheckedComboBox Then
								GoTo IL_1EB6
							End If
					End Select
				ElseIf controlTypeEnum3 = ControlTypeEnum.DropDownBox OrElse controlTypeEnum3 = ControlTypeEnum.TimeSpanBox Then
					GoTo IL_1EB6
				End If
				IL_1C79:
				num2 = 418
				result = False
				GoTo IL_22A4
				IL_1C86:
				num2 = 421
				If Operators.CompareString(left16, "MinRows", True) <> 0 AndAlso Operators.CompareString(left16, "MaxRows", True) <> 0 Then
					GoTo IL_1CD6
				End If
				IL_1CAA:
				num2 = 422
				Dim controlTypeEnum4 As ControlTypeEnum = CType(A_0, ControlPropertyBase).Type
				If controlTypeEnum4 = ControlTypeEnum.Table Then
					GoTo IL_1EB6
				End If
				IL_1CC9:
				num2 = 425
				result = False
				GoTo IL_22A4
				IL_1CD6:
				num2 = 428
				If Operators.CompareString(left16, "BackColor", True) <> 0 AndAlso Operators.CompareString(left16, "BorderColor", True) <> 0 AndAlso Operators.CompareString(left16, "BorderSize", True) <> 0 AndAlso Operators.CompareString(left16, "MouseDownBackColor", True) <> 0 AndAlso Operators.CompareString(left16, "MouseOverBackColor", True) <> 0 Then
					GoTo IL_1DAB
				End If
				IL_1D2A:
				num2 = 429
				If Not(TypeOf A_0 Is ButtonProperty) Then
					GoTo IL_1D5B
				End If
				IL_1D38:
				num2 = 430
				If CType(A_0, ButtonProperty).FlatStyle = FlatStyle.Flat Then
					GoTo IL_1EB6
				End If
				IL_1D4E:
				num2 = 431
				result = False
				GoTo IL_22A4
				IL_1D5B:
				num2 = 433
				If Not(TypeOf A_0 Is WebBrowserProperty) Then
					GoTo IL_1D76
				End If
				IL_1D69:
				num2 = 434
				result = False
				GoTo IL_22A4
				IL_1D76:
				num2 = 436
				If Not(TypeOf A_0 Is CheckBoxProperty) Then
					GoTo IL_1EB6
				End If
				IL_1D87:
				num2 = 437
				If CType(A_0, CheckBoxProperty).Appearance <> Appearance.Button Then
					GoTo IL_1EB6
				End If
				IL_1D9E:
				num2 = 438
				result = False
				GoTo IL_22A4
				IL_1DAB:
				num2 = 440
				If Operators.CompareString(left16, "VisualStyle", True) <> 0 Then
					GoTo IL_1DF5
				End If
				IL_1DC0:
				num2 = 441
				If Not(TypeOf A_0 Is ButtonProperty) Then
					GoTo IL_1EB6
				End If
				IL_1DD1:
				num2 = 442
				If CType(A_0, ButtonProperty).FlatStyle = FlatStyle.Standard Then
					GoTo IL_1EB6
				End If
				IL_1DE8:
				num2 = 443
				result = False
				GoTo IL_22A4
				IL_1DF5:
				num2 = 445
				If Operators.CompareString(left16, "DataFormat", True) <> 0 Then
					GoTo IL_1E5E
				End If
				IL_1E0A:
				num2 = 446
				If TypeOf A_0 Is TextBoxProperty OrElse TypeOf A_0 Is ComboboxProperty OrElse TypeOf A_0 Is CheckedComboBoxProperty OrElse TypeOf A_0 Is NumericComboBoxProperty OrElse TypeOf A_0 Is DateTimePickerProperty OrElse TypeOf A_0 Is TimeSpanBoxProperty OrElse TypeOf A_0 Is LabelProperty Then
					GoTo IL_1EB6
				End If
				IL_1E51:
				num2 = 448
				result = False
				GoTo IL_22A4
				IL_1E5E:
				num2 = 450
				If Operators.CompareString(left16, "DataParse", True) <> 0 Then
					GoTo IL_1EB6
				End If
				IL_1E73:
				num2 = 451
				If TypeOf A_0 Is TextBoxProperty OrElse TypeOf A_0 Is ComboboxProperty OrElse TypeOf A_0 Is CheckedComboBoxProperty OrElse TypeOf A_0 Is NumericComboBoxProperty OrElse TypeOf A_0 Is DateTimePickerProperty OrElse TypeOf A_0 Is TimeSpanBoxProperty Then
					GoTo IL_1EB6
				End If
				IL_1EA9:
				num2 = 453
				result = False
				GoTo IL_22A4
				IL_1EB6:
				num2 = 454
				If Operators.CompareString(category, "外观", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1ECE:
				num2 = 455
				If Not(TypeOf A_0 Is ProgressBarProperty) Then
					GoTo IL_229C
				End If
				IL_1EDF:
				num2 = 456
				result = False
				GoTo IL_22A4
				IL_1EEC:
				num2 = 458
				If Not(TypeOf A_0 Is RibbonItem) Then
					GoTo IL_1F56
				End If
				IL_1EFA:
				num2 = 459
				Dim ribbonItemTypeEnum As RibbonItemTypeEnum = CType(Conversions.ToInteger(CType(A_0, RibbonItem).DataRow("Type")), RibbonItemTypeEnum)
				If ribbonItemTypeEnum <> RibbonItemTypeEnum.PaperList AndAlso ribbonItemTypeEnum <> RibbonItemTypeEnum.WindowList AndAlso ribbonItemTypeEnum - RibbonItemTypeEnum.TableViewList > 5 Then
					GoTo IL_229C
				End If
				IL_1F31:
				num2 = 461
				If Operators.CompareString(category, "事件", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1F49:
				num2 = 462
				result = False
				GoTo IL_22A4
				IL_1F56:
				num2 = 465
				If Not(TypeOf A_0 Is PrintInfo) Then
					GoTo IL_1FB8
				End If
				IL_1F64:
				num2 = 466
				Dim left17 As String = name
				IL_1F6E:
				num2 = 468
				If Operators.CompareString(left17, "PaperWidth", True) <> 0 AndAlso Operators.CompareString(left17, "PaperHeight", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1F95:
				num2 = 469
				If CType(A_0, PrintInfo).PaperRawKind = 0 Then
					GoTo IL_229C
				End If
				IL_1FAB:
				num2 = 470
				result = False
				GoTo IL_22A4
				IL_1FB8:
				num2 = 472
				If Not(TypeOf A_0 Is PrintPageProperty) Then
					GoTo IL_201A
				End If
				IL_1FC6:
				num2 = 473
				Dim left18 As String = name
				IL_1FD0:
				num2 = 475
				If Operators.CompareString(left18, "Width", True) <> 0 AndAlso Operators.CompareString(left18, "Height", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_1FF7:
				num2 = 476
				If CType(A_0, PrintPageProperty).PaperKind = PaperKind.Custom Then
					GoTo IL_229C
				End If
				IL_200D:
				num2 = 477
				result = False
				GoTo IL_22A4
				IL_201A:
				num2 = 479
				If Not(TypeOf A_0 Is FormMenuProperty) Then
					GoTo IL_206E
				End If
				IL_2028:
				num2 = 480
				Dim left19 As String = name
				IL_2032:
				num2 = 482
				If Operators.CompareString(left19, "Dock", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_204A:
				num2 = 483
				If CType(A_0, FormMenuProperty).Type = StripTypeEnum2.工具栏 Then
					GoTo IL_229C
				End If
				IL_2061:
				num2 = 484
				result = False
				GoTo IL_22A4
				IL_206E:
				num2 = 486
				If Not(TypeOf A_0 Is FormMenuItemProperty) Then
					GoTo IL_2243
				End If
				IL_207F:
				num2 = 487
				If CType(A_0, FormMenuItemProperty).Type <> StripItemTypeEnum.Separator Then
					GoTo IL_210A
				End If
				IL_2093:
				num2 = 488
				Dim left20 As String = name
				IL_209D:
				num2 = 490
				If Operators.CompareString(left20, "Name", True) = 0 OrElse Operators.CompareString(left20, "Alignment", True) = 0 OrElse Operators.CompareString(left20, "Type", True) = 0 OrElse Operators.CompareString(left20, "Type2", True) = 0 OrElse Operators.CompareString(left20, "Enabled", True) = 0 OrElse Operators.CompareString(left20, "Visible", True) = 0 Then
					GoTo IL_210A
				End If
				IL_20FD:
				num2 = 492
				result = False
				GoTo IL_22A4
				IL_210A:
				num2 = 493
				Dim left21 As String = name
				IL_2114:
				num2 = 495
				If Operators.CompareString(left21, "Checked", True) <> 0 Then
					GoTo IL_2165
				End If
				IL_2129:
				num2 = 496
				Dim formMenuItemProperty As FormMenuItemProperty = CType(A_0, FormMenuItemProperty)
				IL_2137:
				num2 = 497
				If formMenuItemProperty.Type = StripItemTypeEnum.MenuItem OrElse formMenuItemProperty.Type = StripItemTypeEnum.Button Then
					GoTo IL_215D
				End If
				IL_2150:
				num2 = 498
				result = False
				GoTo IL_22A4
				IL_215D:
				formMenuItemProperty = Nothing
				GoTo IL_229C
				IL_2165:
				num2 = 501
				If Operators.CompareString(left21, "ComboList", True) <> 0 Then
					GoTo IL_21AD
				End If
				IL_217A:
				num2 = 502
				Dim formMenuItemProperty2 As FormMenuItemProperty = CType(A_0, FormMenuItemProperty)
				IL_2188:
				num2 = 503
				If formMenuItemProperty2.Type = StripItemTypeEnum.ComboBox Then
					GoTo IL_21A5
				End If
				IL_2198:
				num2 = 504
				result = False
				GoTo IL_22A4
				IL_21A5:
				formMenuItemProperty2 = Nothing
				GoTo IL_229C
				IL_21AD:
				num2 = 507
				If Operators.CompareString(left21, "ShortcutKeys", True) <> 0 Then
					GoTo IL_21E5
				End If
				IL_21C2:
				num2 = 508
				If CType(A_0, FormMenuItemProperty).Type = StripItemTypeEnum.MenuItem Then
					GoTo IL_229C
				End If
				IL_21D8:
				num2 = 509
				result = False
				GoTo IL_22A4
				IL_21E5:
				num2 = 511
				If Operators.CompareString(left21, "DisplayText", True) <> 0 AndAlso Operators.CompareString(left21, "TextPosition", True) <> 0 Then
					GoTo IL_229C
				End If
				IL_220C:
				num2 = 512
				Dim formMenuItemProperty3 As FormMenuItemProperty = CType(A_0, FormMenuItemProperty)
				IL_221A:
				num2 = 513
				If formMenuItemProperty3.Type = StripItemTypeEnum.Button OrElse formMenuItemProperty3.Type = StripItemTypeEnum.SplitButton Then
					GoTo IL_223E
				End If
				IL_2234:
				num2 = 514
				result = False
				GoTo IL_22A4
				IL_223E:
				formMenuItemProperty3 = Nothing
				GoTo IL_229C
				IL_2243:
				num2 = 517
				If Not(TypeOf A_0 Is ProjectProperty) Then
					GoTo IL_229C
				End If
				IL_2251:
				num2 = 518
				If Not O00OOOo_O0_O.OOoo0_OO__._o.(A_1) Then
					GoTo IL_229C
				End If
				IL_225F:
				num2 = 519
				If o0OO__.OO0oO.o.() Then
					GoTo IL_2276
				End If
				IL_226C:
				num2 = 520
				result = False
				GoTo IL_22A4
				IL_2276:
				num2 = 522
				Dim o0_o_o As Oo00.o0_o_o = New Oo00.o0_o_o()
				IL_2283:
				num2 = 523
				If o0_o_o.O0.0_.() Then
					GoTo IL_229C
				End If
				IL_2292:
				num2 = 524
				result = False
				IL_22A4:
				GoTo IL_2B2E
				IL_22A9:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2AEF:
				GoTo IL_2B23
				IL_2AF1:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2B01:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2AF1
			End Try
			IL_2B23:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2B2E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060047BE RID: 18366 RVA: 0x001DE1A0 File Offset: 0x001DC3A0
		Friend Function <<EMPTY_NAME>>(A_0 As Font) As String
			Return String.Concat(New String() { A_0.Name, ",", Conversions.ToString(A_0.Size), ",", A_0.Style.ToString() }).Trim(New Char() { ","c })
		End Function

		' Token: 0x060047BF RID: 18367 RVA: 0x001DE208 File Offset: 0x001DC408
		Friend Function <<EMPTY_NAME>>(A_0 As Font) As String
			Dim text As String = "New Font(""" + A_0.Name + """," + Conversions.ToString(A_0.Size)
			Dim array As String() = A_0.Style.ToString().Split(New Char() { ","c })
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num
				If i = 0 Then
					text += ","
				Else
					text += " Or "
				End If
				Dim left As String = array(i).Trim()
				If Operators.CompareString(left, "Bold", True) = 0 Then
					text += "FontStyle.Bold"
				ElseIf Operators.CompareString(left, "Italic", True) = 0 Then
					text += "FontStyle.Italic"
				ElseIf Operators.CompareString(left, "Strikeout", True) = 0 Then
					text += "FontStyle.Strikeout"
				ElseIf Operators.CompareString(left, "Underline", True) = 0 Then
					text += "FontStyle.Underline"
				End If
			Next
			Return text.Trim(New Char() { ","c }) + ")"
		End Function

		' Token: 0x060047C0 RID: 18368 RVA: 0x001DE330 File Offset: 0x001DC530
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = ""
			For Each c As Char In A_0
				If Char.IsLetterOrDigit(c) Then
					text += Conversions.ToString(c)
				End If
			Next
			Return text
		End Function

		' Token: 0x060047C1 RID: 18369 RVA: 0x001DE374 File Offset: 0x001DC574
		Friend Sub <<EMPTY_NAME>>(A_0 As C1PrintDocument)
			Dim renderText As RenderText = New RenderText()
			renderText.Text = "www.foxtable.com"
			renderText.Width = "Parent.Width"
			renderText.Height = "Parent.Height"
			renderText.Style.TextAngle = 45F
			renderText.Style.TextAlignHorz = 1
			renderText.Style.TextAlignVert = 1
			renderText.Style.FontSize = 24F
			renderText.Style.TextColor = Color.Gray
			A_0.PageLayout.Watermark = renderText
		End Sub

		' Token: 0x060047C2 RID: 18370 RVA: 0x001DE408 File Offset: 0x001DC608
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Bitmap
			Dim registryKey As RegistryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(A_0)
			If registryKey IsNot Nothing Then
				Dim text As String = CStr(registryKey.GetValue(Nothing))
				If text Is Nothing Then
					Return Nothing
				End If
				Dim registryKey2 As RegistryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(text)
				If registryKey2 IsNot Nothing Then
					Dim text2 As String = CStr(registryKey2.GetValue(Nothing))
					Dim registryKey3 As RegistryKey = registryKey2.OpenSubKey("DefaultIcon")
					If registryKey3 IsNot Nothing Then
						Dim array As String() = CStr(registryKey3.GetValue(Nothing)).Split(New Char() { ","c })
						Dim a_ As Integer = 0
						If array.Length > 1 Then
							Integer.TryParse(array(1), a_)
						End If
						Dim intPtr As IntPtr = 0
						Dim handle As IntPtr = 0
						ooO.ExtractIconExW(array(0).Trim(New Char() { """"c }), a_, intPtr, handle, 1UI)
						If handle.ToInt32() <> 0 Then
							Dim icon As Icon = Icon.FromHandle(handle)
							If icon IsNot Nothing Then
								Return icon.ToBitmap()
							End If
						End If
					End If
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x060047C3 RID: 18371 RVA: 0x001DE504 File Offset: 0x001DC704
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Bitmap
			Dim registryKey As RegistryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(A_0)
			If registryKey IsNot Nothing Then
				Dim text As String = CStr(registryKey.GetValue(Nothing))
				If text Is Nothing Then
					Dim image As Image = OO_00oOO.GetImage("Unknow.ico")
					If image IsNot Nothing Then
						Return New Bitmap(image)
					End If
					Return Nothing
				Else
					Dim registryKey2 As RegistryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(text)
					If registryKey2 IsNot Nothing Then
						Dim text2 As String = CStr(registryKey2.GetValue(Nothing))
						Dim registryKey3 As RegistryKey = registryKey2.OpenSubKey("DefaultIcon")
						If registryKey3 IsNot Nothing Then
							Dim array As String() = CStr(registryKey3.GetValue(Nothing)).Split(New Char() { ","c })
							Dim a_ As Integer = 0
							If array.Length > 1 Then
								Integer.TryParse(array(1), a_)
							End If
							Dim handle As IntPtr = 0
							Dim intPtr As IntPtr = 0
							ooO.ExtractIconExW(array(0).Trim(New Char() { """"c }), a_, handle, intPtr, 1UI)
							If handle.ToInt32() <> 0 Then
								Dim icon As Icon = Icon.FromHandle(handle)
								If icon IsNot Nothing Then
									Return icon.ToBitmap()
								End If
							End If
						End If
					End If
				End If
			End If
			Dim image2 As Image = OO_00oOO.GetImage("Unknow.ico")
			Dim result As Bitmap
			If image2 IsNot Nothing Then
				result = New Bitmap(image2)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060047C4 RID: 18372 RVA: 0x001DE638 File Offset: 0x001DC838
		Public Function <<EMPTY_NAME>>() As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			For Each ipaddress As IPAddress In Dns.GetHostEntry(Dns.GetHostName()).AddressList
				If ipaddress.AddressFamily = AddressFamily.InterNetwork Then
					list.Add(ipaddress.ToString())
				End If
			Next
			Return list
		End Function

		' Token: 0x060047C5 RID: 18373 RVA: 0x001DE684 File Offset: 0x001DC884
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Type
			Dim left As String = Strings.LCase(A_0)
			Dim typeFromHandle As Type
			If Operators.CompareString(left, "string", True) = 0 Then
				typeFromHandle = GetType(String)
			ElseIf Operators.CompareString(left, "date", True) = 0 Then
				typeFromHandle = GetType(DateTime)
			ElseIf Operators.CompareString(left, "boolean", True) = 0 Then
				typeFromHandle = GetType(Boolean)
			ElseIf Operators.CompareString(left, "byte", True) = 0 Then
				typeFromHandle = GetType(Byte)
			ElseIf Operators.CompareString(left, "short", True) = 0 Then
				typeFromHandle = GetType(Short)
			ElseIf Operators.CompareString(left, "integer", True) = 0 Then
				typeFromHandle = GetType(Integer)
			ElseIf Operators.CompareString(left, "long", True) = 0 Then
				typeFromHandle = GetType(Long)
			ElseIf Operators.CompareString(left, "single", True) = 0 Then
				typeFromHandle = GetType(Single)
			ElseIf Operators.CompareString(left, "double", True) = 0 Then
				typeFromHandle = GetType(Double)
			ElseIf Operators.CompareString(left, "decimal", True) = 0 Then
				typeFromHandle = GetType(Decimal)
			Else
				typeFromHandle = GetType(Object)
			End If
			Return typeFromHandle
		End Function

		' Token: 0x060047C6 RID: 18374 RVA: 0x001DE7C4 File Offset: 0x001DC9C4
		Friend Function <<EMPTY_NAME>>(A_0 As Object()) As String()
			Dim list As List(Of String) = New List(Of String)()
			For i As Integer = 0 To A_0.Length - 1
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_0(i))
				list.Add(Conversions.ToString(objectValue))
			Next
			Return list.ToArray()
		End Function

		' Token: 0x060047C7 RID: 18375 RVA: 0x001DE804 File Offset: 0x001DCA04
		Public Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			Try
				New StringBuilder()
				Dim frames As StackFrame() = New StackTrace(True).GetFrames()
				If frames.Length < 3 Then
					result = False
				Else
					Dim stackFrame As StackFrame = frames(1)
					If Operators.CompareString(frames(2).GetMethod().Name, "InvokeMethod", True) = 0 AndAlso Not stackFrame.GetMethod().DeclaringType.FullName.ToLower().Contains("usercode") Then
						result = True
					Else
						result = False
					End If
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		' Token: 0x02000440 RID: 1088
		Friend Structure o0O_
			' Token: 0x04001D49 RID: 7497
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04001D4A RID: 7498
			Public <<EMPTY_NAME>> As Integer
		End Structure

		' Token: 0x02000441 RID: 1089
		' (Invoke) Token: 0x060047CB RID: 18379
		Public Delegate Sub o_0_(A_0 As Exception, A_1 As String)
	End Module
End Namespace
