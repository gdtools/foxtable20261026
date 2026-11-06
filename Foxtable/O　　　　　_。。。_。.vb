Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace Foxtable
	' Token: 0x02000360 RID: 864
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002
		Inherits Form

		' Token: 0x060035FA RID: 13818 RVA: 0x0016CAD0 File Offset: 0x0016ACD0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oO0._oO. IsNot Nothing Then
					Me.oO0._oO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060035FB RID: 13819 RVA: 0x0016CB10 File Offset: 0x0016AD10
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo0OO00.o0O.(New C1TextBox())
			Me.o._O0_0_oo0oo.(New C1TextBox())
			Me.O__._0__o0.(New C1CheckBox())
			Me.o00_O.O0oO_00.(New Label())
			Me.o00_O.O0oO_00.(New C1Button())
			Me.o._O0_0_oo0oo.(New Label())
			Me.o0OO_0_o.0oOO.(New C1Button())
			Me.O__._0__o0.(New C1Button())
			Me.o.o_0__.(New Label())
			Me.O__._0__o0.(New FolderBrowserDialog())
			MyBase.SuspendLayout()
			Me.OO00o_._O_00.().Location = New Point(14, 77)
			Me.OO00o_._O_00.().Name = "txtFolder"
			Me.OO00o_._O_00.().[ReadOnly] = True
			Me.OO00o_._O_00.().Size = New Size(425, 21)
			Me.OO00o_._O_00.().TabIndex = 1
			Me.o00_O.O0oO_00.().Location = New Point(14, 28)
			Me.o00_O.O0oO_00.().Name = "txtName"
			Me.o00_O.O0oO_00.().Size = New Size(425, 21)
			Me.o00_O.O0oO_00.().TabIndex = 0
			Me.OO00o_._O_00.().AutoCheck = False
			Me.OO00o_._O_00.().AutoSize = True
			Me.OO00o_._O_00.().Checked = True
			Me.OO00o_._O_00.().CheckState = CheckState.Checked
			Me.OO00o_._O_00.().Location = New Point(14, 115)
			Me.OO00o_._O_00.().Name = "chkCreateFolder"
			Me.OO00o_._O_00.().Size = New Size(108, 16)
			Me.OO00o_._O_00.().TabIndex = 3
			Me.OO00o_._O_00.().Text = "创建专用文件夹"
			Me.OO00o_._O_00.().UseVisualStyleBackColor = True
			Me.OO00o_._O_00.().AutoSize = True
			Me.OO00o_._O_00.().Location = New Point(14, 13)
			Me.OO00o_._O_00.().Name = "Label1"
			Me.OO00o_._O_00.().Size = New Size(59, 12)
			Me.OO00o_._O_00.().TabIndex = 9
			Me.OO00o_._O_00.().Text = "项目名称:"
			Me.OO00o_._O_00.().Location = New Point(443, 75)
			Me.OO00o_._O_00.().Name = "btnFolderBrowser"
			Me.OO00o_._O_00.().Size = New Size(65, 23)
			Me.OO00o_._O_00.().TabIndex = 2
			Me.OO00o_._O_00.().Text = "浏览(B)"
			Me.OO00o_._O_00.().UseVisualStyleBackColor = True
			Me.o.OOoo_.().AutoSize = True
			Me.o.OOoo_.().Location = New Point(14, 62)
			Me.o.OOoo_.().Name = "Label2"
			Me.o.OOoo_.().Size = New Size(59, 12)
			Me.o.OOoo_.().TabIndex = 11
			Me.o.OOoo_.().Text = "项目位置:"
			Me.OO_o___O.0.().DialogResult = DialogResult.Cancel
			Me.OO_o___O.0.().Location = New Point(265, 240)
			Me.OO_o___O.0.().Name = "btnCancel"
			Me.OO_o___O.0.().Size = New Size(75, 23)
			Me.OO_o___O.0.().TabIndex = 6
			Me.OO_o___O.0.().Text = "取消(&X)"
			Me.OO_o___O.0.().UseVisualStyleBackColor = True
			Me.o.OOoo_.().Location = New Point(184, 240)
			Me.o.OOoo_.().Name = "btnOK"
			Me.o.OOoo_.().Size = New Size(75, 23)
			Me.o.OOoo_.().TabIndex = 5
			Me.o.OOoo_.().Text = "确定(&O)"
			Me.o.OOoo_.().UseVisualStyleBackColor = True
			Me.OO_o___O.0.().Location = New Point(14, 159)
			Me.OO_o___O.0.().Name = "lblDescription"
			Me.OO_o___O.0.().Size = New Size(496, 52)
			Me.OO_o___O.0.().TabIndex = 4
			Me.OO_o___O.0.().Text = "提示:"
			Me.OO00o_._O_00.().Description = "系统位置"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(525, 276)
			MyBase.Controls.Add(Me.OO_o___O.0.())
			MyBase.Controls.Add(Me.o.OOoo_.())
			MyBase.Controls.Add(Me.OO00o_._O_00.())
			MyBase.Controls.Add(Me.o00_O.O0oO_00.())
			MyBase.Controls.Add(Me.OO00o_._O_00.())
			MyBase.Controls.Add(Me.OO00o_._O_00.())
			MyBase.Controls.Add(Me.OO00o_._O_00.())
			MyBase.Controls.Add(Me.o.OOoo_.())
			MyBase.Controls.Add(Me.OO_o___O.0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.OO...."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "另存为"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060035FC RID: 13820 RVA: 0x0016D039 File Offset: 0x0016B239
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oO0._oO.
		End Function

		' Token: 0x060035FD RID: 13821 RVA: 0x0016D041 File Offset: 0x0016B241
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oO0._oO. = A_0
		End Sub

		' Token: 0x060035FE RID: 13822 RVA: 0x0016D04A File Offset: 0x0016B24A
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO_OooO0._0O0.
		End Function

		' Token: 0x060035FF RID: 13823 RVA: 0x0016D054 File Offset: 0x0016B254
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As KeyPressEventHandler = AddressOf Me.o._O0_0_oo0oo.
			Dim value2 As EventHandler = AddressOf Me.o.o_0__.
			Dim value3 As CancelEventHandler = AddressOf Me.o._O0_0_oo0oo.
			Dim oo_OooO0._0O0. As C1TextBox = Me.OO_OooO0._0O0.
			If oo_OooO0._0O0. IsNot Nothing Then
				RemoveHandler oo_OooO0._0O0..KeyPress, value
				RemoveHandler oo_OooO0._0O0..TextChanged, value2
				RemoveHandler oo_OooO0._0O0..Validating, value3
			End If
			Me.OO_OooO0._0O0. = A_0
			oo_OooO0._0O0. = Me.OO_OooO0._0O0.
			If oo_OooO0._0O0. IsNot Nothing Then
				AddHandler oo_OooO0._0O0..KeyPress, value
				AddHandler oo_OooO0._0O0..TextChanged, value2
				AddHandler oo_OooO0._0O0..Validating, value3
			End If
		End Sub

		' Token: 0x06003600 RID: 13824 RVA: 0x0016D0CD File Offset: 0x0016B2CD
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oO0._oO.
		End Function

		' Token: 0x06003601 RID: 13825 RVA: 0x0016D0D5 File Offset: 0x0016B2D5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oO0._oO. = A_0
		End Sub

		' Token: 0x06003602 RID: 13826 RVA: 0x0016D0DE File Offset: 0x0016B2DE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO0._oO.
		End Function

		' Token: 0x06003603 RID: 13827 RVA: 0x0016D0E6 File Offset: 0x0016B2E6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO0._oO. = A_0
		End Sub

		' Token: 0x06003604 RID: 13828 RVA: 0x0016D0EF File Offset: 0x0016B2EF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._O0_0_oo0oo.
		End Function

		' Token: 0x06003605 RID: 13829 RVA: 0x0016D0F8 File Offset: 0x0016B2F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_o_o0OO_0.o.
			Dim c1Button As C1Button = Me.o._O0_0_oo0oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o._O0_0_oo0oo. = A_0
			c1Button = Me.o._O0_0_oo0oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003606 RID: 13830 RVA: 0x0016D13B File Offset: 0x0016B33B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO_OooO0._0O0.
		End Function

		' Token: 0x06003607 RID: 13831 RVA: 0x0016D143 File Offset: 0x0016B343
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO_OooO0._0O0. = A_0
		End Sub

		' Token: 0x06003608 RID: 13832 RVA: 0x0016D14C File Offset: 0x0016B34C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo0OO00.o0O.
		End Function

		' Token: 0x06003609 RID: 13833 RVA: 0x0016D154 File Offset: 0x0016B354
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo0OO00.o0O. = A_0
		End Sub

		' Token: 0x0600360A RID: 13834 RVA: 0x0016D15D File Offset: 0x0016B35D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o_0__.
		End Function

		' Token: 0x0600360B RID: 13835 RVA: 0x0016D168 File Offset: 0x0016B368
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_o00.o0O0o.
			Dim c1Button As C1Button = Me.o.o_0__.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.o_0__. = A_0
			c1Button = Me.o.o_0__.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600360C RID: 13836 RVA: 0x0016D1AB File Offset: 0x0016B3AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oooo.O_O0O_0O0.
		End Function

		' Token: 0x0600360D RID: 13837 RVA: 0x0016D1B3 File Offset: 0x0016B3B3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oooo.O_O0O_0O0. = A_0
		End Sub

		' Token: 0x0600360E RID: 13838 RVA: 0x0016D1BC File Offset: 0x0016B3BC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As FolderBrowserDialog
			Return Me.oO0._oO.
		End Function

		' Token: 0x0600360F RID: 13839 RVA: 0x0016D1C4 File Offset: 0x0016B3C4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As FolderBrowserDialog)
			Me.oO0._oO. = A_0
		End Sub

		' Token: 0x06003610 RID: 13840 RVA: 0x0016D1D0 File Offset: 0x0016B3D0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.OO00o_._O_00.
			AddHandler MyBase.FormClosed, AddressOf Me.O_0.ooO0O.
			Me.o00_O.O0oO_00.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003611 RID: 13841 RVA: 0x0016D222 File Offset: 0x0016B422
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO00o_._O_00.().ShowDialog() = DialogResult.OK Then
				Me.OO00o_._O_00.().Value = Me.OO00o_._O_00.().SelectedPath
				Me.O__._0__o0.()
				Me.o0OO_0_o.0oOO.()
			End If
		End Sub

		' Token: 0x06003612 RID: 13842 RVA: 0x0016D254 File Offset: 0x0016B454
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer = 0
			Try
				For Each text As String In c.OOOOO.o.().FileSystem.GetDirectories(Me.OO00o_._O_00.().Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, New String() { "管理项目*" })
					If Versioned.IsNumeric(text.Substring(text.LastIndexOf("\") + "管理项目".Length + 1)) Then
						num = Convert.ToInt32(Math.Max(CDbl(num), Conversion.Val(text.Substring(text.LastIndexOf("\") + "管理项目".Length + 1))))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.oO0._oO. = "管理项目" + Conversions.ToString(num + 1)
			Me.o00_O.O0oO_00.().Value = Me.oO0._oO.
		End Sub

		' Token: 0x06003613 RID: 13843 RVA: 0x0016D340 File Offset: 0x0016B540
		Public Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.OO00o_._O_00.().Text, "", True) = 0 Or Operators.CompareString(Me.o00_O.O0oO_00.().Text, "", True) = 0 Then
				Me.OO_o___O.0.().Text = ""
				Return
			End If
			If Not Me.OO00o_._O_00.().Text.EndsWith("\") Then
				Me.OO00o_._O_00.().Value = Me.OO00o_._O_00.().Text + "\"
			End If
			Me.OO_o___O.0.().Text = String.Concat(New String() { "将创建: ", Me.OO00o_._O_00.().Text, Me.o00_O.O0oO_00.().Text, "\", Me.o00_O.O0oO_00.().Text, ooO0__OO.oo.Ooo_00.() })
		End Sub

		' Token: 0x06003614 RID: 13844 RVA: 0x0016D422 File Offset: 0x0016B622
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If A_1.KeyChar = "."c Then
				A_1.Handled = True
			End If
		End Sub

		' Token: 0x06003615 RID: 13845 RVA: 0x0016D435 File Offset: 0x0016B635
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0OO_0_o.0oOO.()
		End Sub

		' Token: 0x06003616 RID: 13846 RVA: 0x0016D440 File Offset: 0x0016B640
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile)
				IL_1E:
				num2 = 3
				Dim text2 As String = Me.OO00o_._O_00.().Text + Me.o00_O.O0oO_00.().Text + "\"
				IL_42:
				num2 = 4
				Me.OO00o_._O_00.().Value = Me.OO00o_._O_00.().Text.Trim()
				IL_5F:
				num2 = 5
				Me.o00_O.O0oO_00.().Text = Me.o00_O.O0oO_00.().Text.Trim()
				IL_7C:
				num2 = 6
				If text.EndsWith("\") Then
					GoTo IL_99
				End If
				IL_8B:
				num2 = 7
				text += "\"
				IL_99:
				num2 = 8
				If Not(Operators.CompareString(Me.OO00o_._O_00.().Text, "", True) = 0 Or Operators.CompareString(Me.o00_O.O0oO_00.().Text, "", True) = 0) Then
					GoTo IL_EB
				End If
				IL_D0:
				num2 = 9
				MessageBox.Show("请输入项目名称和位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_4FC
				IL_EB:
				num2 = 11
				If Operators.CompareString(text.ToLower(), text2.ToLower(), True) <> 0 Then
					GoTo IL_150
				End If
				IL_103:
				num2 = 12
				If Operators.CompareString((Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.()).ToLower(), c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile).ToLower(), True) <> 0 Then
					GoTo IL_150
				End If
				IL_141:
				num2 = 13
				MyBase.DialogResult = DialogResult.OK
				GoTo IL_4FC
				IL_150:
				num2 = 15
				If Not c.OOOOO.o.().FileSystem.DirectoryExists(text2) Then
					GoTo IL_1A1
				End If
				IL_166:
				num2 = 16
				If MessageBox.Show("文件夹 " + Me.OO00o_._O_00.().Text + Me.o00_O.O0oO_00.().Text + " 已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
					GoTo IL_4FC
				End If
				IL_1A1:
				num2 = 18
				Me.Cursor = Cursors.WaitCursor
				IL_1AF:
				num2 = 19
				If c.OOOOO.o.().FileSystem.DirectoryExists(text2) Then
					GoTo IL_1D9
				End If
				IL_1C5:
				num2 = 20
				c.OOOOO.o.().FileSystem.CreateDirectory(text2)
				IL_1D9:
				num2 = 21
				If Not c.OOOOO.o.().FileSystem.FileExists(text2 + Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.()) Then
					GoTo IL_22D
				End If
				IL_204:
				num2 = 22
				c.OOOOO.o.().FileSystem.DeleteFile(text2 + Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.())
				IL_22D:
				num2 = 23
				If Operators.CompareString(text, text2, True) = 0 Then
					GoTo IL_3F4
				End If
				IL_23E:
				num2 = 24
				Dim array As String() = OO_00oOO.ProjectPath.Split(New Char() { "\"c, ":"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_25E:
				num2 = 25
				If Operators.CompareString(Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile), array(array.Length - 1), True) <> 0 OrElse Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile).Length <= 1 Then
					GoTo IL_2EB
				End If
				IL_28E:
				num2 = 26
				c.OOOOO.o.().FileSystem.CopyDirectory(text, text2, True)
				IL_2A4:
				num2 = 27
				c.OOOOO.o.().FileSystem.RenameFile(text2 + c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile), Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.())
				GoTo IL_3F4
				IL_2EB:
				num2 = 29
				c.OOOOO.o.().FileSystem.CopyFile(OO_00oOO.ProjectFile, text2 + Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.())
				IL_319:
				num2 = 30
				If Not c.OOOOO.o.().FileSystem.DirectoryExists(text + "Images\") Then
					GoTo IL_362
				End If
				IL_338:
				num2 = 31
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Images\", text2 + "Images\", True)
				IL_362:
				num2 = 32
				If Not c.OOOOO.o.().FileSystem.DirectoryExists(text + "Attachments\") Then
					GoTo IL_3AB
				End If
				IL_381:
				num2 = 33
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Attachments\", text2 + "Attachments\", True)
				IL_3AB:
				num2 = 34
				If Not c.OOOOO.o.().FileSystem.DirectoryExists(text + "Bin\") Then
					GoTo IL_3F4
				End If
				IL_3CA:
				num2 = 35
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Bin\", text2 + "Bin\", True)
				IL_3F4:
				num2 = 36
				OO_00oOO.ProjectFile = text2 + Me.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.()
				IL_413:
				num2 = 37
				O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile) + "\Images\"
				IL_439:
				num2 = 38
				Dim oleDbConnectionStringBuilder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder(O_O0OO.OoO.0OO__0ooo.().ConnectionString)
				IL_44D:
				num2 = 39
				oleDbConnectionStringBuilder.DataSource = OO_00oOO.ProjectFile
				IL_45C:
				num2 = 40
				O_O0OO.OoO.0OO__0ooo.().ConnectionString = oleDbConnectionStringBuilder.ConnectionString
				IL_470:
				num2 = 41
				O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				IL_47F:
				num2 = 42
				OO_00oOO.DataTables.Save()
				IL_48D:
				num2 = 43
				If Not O_O0OO.o_Oo0_oOo.0. Then
					GoTo IL_4D1
				End If
				IL_497:
				num2 = 44
				Main.OO_O.o..Text = Main.OO_O.o..O.OOO0_OOo.().Text + " - " + c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile)
				IL_4D1:
				num2 = 45
				Main.OO_O.o..O.OOO0_OOo.().Path = OO_00oOO.ProjectPath + "Bin\"
				IL_4F2:
				num2 = 46
				MyBase.DialogResult = DialogResult.OK
				IL_4FC:
				GoTo IL_60A
				IL_501:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_5CB:
				GoTo IL_5FF
				IL_5CD:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5DD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5CD
			End Try
			IL_5FF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_60A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003617 RID: 13847 RVA: 0x0016DA7C File Offset: 0x0016BC7C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO00o_._O_00.().RootFolder = Environment.SpecialFolder.MyComputer
			Me.OO00o_._O_00.().Value = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\Foxtable项目"
			Me.O__._0__o0.()
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
				Me.Text = "保存"
			End If
		End Sub

		' Token: 0x06003618 RID: 13848 RVA: 0x0016DAD4 File Offset: 0x0016BCD4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			If Operators.CompareString(Me.o00_O.O0oO_00.().Text, "", True) > 0 AndAlso Me.o00_O.O0oO_00.().Text.IndexOf(".") >= 0 Then
				Me.o00_O.O0oO_00.().Value = Me.o00_O.O0oO_00.().Text.Replace(".", "")
			End If
		End Sub

		' Token: 0x06003619 RID: 13849 RVA: 0x0016DB37 File Offset: 0x0016BD37
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001631 RID: 5681
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001632 RID: 5682
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001633 RID: 5683
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001634 RID: 5684
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001635 RID: 5685
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001636 RID: 5686
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001637 RID: 5687
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001638 RID: 5688
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001639 RID: 5689
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400163A RID: 5690
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400163B RID: 5691
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FolderBrowserDialog

		' Token: 0x0400163C RID: 5692
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400163D RID: 5693
		Private Const <<EMPTY_NAME>> As String = "管理项目"
	End Class
End Namespace
