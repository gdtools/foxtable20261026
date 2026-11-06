Imports System
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices
Imports MSDASC

Namespace Foxtable
	' Token: 0x0200033F RID: 831
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000
		Inherits Form

		' Token: 0x060031ED RID: 12781 RVA: 0x00144A3C File Offset: 0x00142C3C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.000000o. IsNot Nothing Then
					Me.o.000000o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060031EE RID: 12782 RVA: 0x00144A7C File Offset: 0x00142C7C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OooOOOOO.O0O.(New Label())
			Me.o_.o0O.(New C1Button())
			Me.OO.o0O0OO.(New C1Button())
			Me.O.__0____oo.(New C1Button())
			Me.OO.o0O0OO.(New TextBox())
			Me.OooOOOOO.O0O.(New C1Button())
			Me.OO.o0O0OO.(New Label())
			Me.OO.o0O0OO.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.OO._000_O0o_.().AutoSize = True
			Me.OO._000_O0o_.().Location = New Point(10, 16)
			Me.OO._000_O0o_.().Name = "Label1"
			Me.OO._000_O0o_.().Size = New Size(107, 12)
			Me.OO._000_O0o_.().TabIndex = 11
			Me.OO._000_O0o_.().Text = "请修改连接字符串:"
			Me.o_.__o.().DialogResult = DialogResult.Cancel
			Me.o_.__o.().Location = New Point(488, 282)
			Me.o_.__o.().Name = "btnCancel"
			Me.o_.__o.().Size = New Size(75, 23)
			Me.o_.__o.().TabIndex = 10
			Me.o_.__o.().Text = "取消"
			Me.o_.__o.().UseVisualStyleBackColor = True
			Me.OO._000_O0o_.().Location = New Point(407, 282)
			Me.OO._000_O0o_.().Name = "btnOK"
			Me.OO._000_O0o_.().Size = New Size(75, 23)
			Me.OO._000_O0o_.().TabIndex = 9
			Me.OO._000_O0o_.().Text = "确定"
			Me.OO._000_O0o_.().UseVisualStyleBackColor = True
			Me.OO_._o_o0_00.().Location = New Point(12, 282)
			Me.OO_._o_o0_00.().Name = "btnCreator"
			Me.OO_._o_o0_00.().Size = New Size(75, 23)
			Me.OO_._o_o0_00.().TabIndex = 7
			Me.OO_._o_o0_00.().Text = "生成器"
			Me.OO_._o_o0_00.().UseVisualStyleBackColor = True
			Me.OO._000_O0o_.().Location = New Point(12, 38)
			Me.OO._000_O0o_.().Multiline = True
			Me.OO._000_O0o_.().Name = "TextBox1"
			Me.OO._000_O0o_.().ScrollBars = ScrollBars.Vertical
			Me.OO._000_O0o_.().Size = New Size(551, 196)
			Me.OO._000_O0o_.().TabIndex = 6
			Me.ooO._0_0O.().Location = New Point(93, 282)
			Me.ooO._0_0O.().Name = "btnTest"
			Me.ooO._0_0O.().Size = New Size(75, 23)
			Me.ooO._0_0O.().TabIndex = 12
			Me.ooO._0_0O.().Text = "测试"
			Me.ooO._0_0O.().UseVisualStyleBackColor = True
			Me.OO_._o_o0_00.().AutoSize = True
			Me.OO_._o_o0_00.().Location = New Point(10, 246)
			Me.OO_._o_o0_00.().Name = "Label2"
			Me.OO_._o_o0_00.().Size = New Size(413, 12)
			Me.OO_._o_o0_00.().TabIndex = 13
			Me.OO_._o_o0_00.().Text = "提示：此处默认是临时修改，请在启动项目后，按常规操作修改链接字符串。"
			Me.OO._000_O0o_.().AutoSize = True
			Me.OO._000_O0o_.().Location = New Point(488, 246)
			Me.OO._000_O0o_.().Name = "CheckBox1"
			Me.OO._000_O0o_.().Size = New Size(72, 16)
			Me.OO._000_O0o_.().TabIndex = 14
			Me.OO._000_O0o_.().Text = "保存设置"
			Me.OO._000_O0o_.().UseVisualStyleBackColor = True
			Me.OO._000_O0o_.().Visible = False
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(577, 315)
			MyBase.Controls.Add(Me.OO._000_O0o_.())
			MyBase.Controls.Add(Me.OO_._o_o0_00.())
			MyBase.Controls.Add(Me.ooO._0_0O.())
			MyBase.Controls.Add(Me.OO._000_O0o_.())
			MyBase.Controls.Add(Me.o_.__o.())
			MyBase.Controls.Add(Me.OO._000_O0o_.())
			MyBase.Controls.Add(Me.OO_._o_o0_00.())
			MyBase.Controls.Add(Me.OO._000_O0o_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oo0....."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "链接数据源"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060031EF RID: 12783 RVA: 0x00144F37 File Offset: 0x00143137
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o.000000o.
		End Function

		' Token: 0x060031F0 RID: 12784 RVA: 0x00144F3F File Offset: 0x0014313F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.000000o. = A_0
		End Sub

		' Token: 0x060031F1 RID: 12785 RVA: 0x00144F48 File Offset: 0x00143148
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.000000o.
		End Function

		' Token: 0x060031F2 RID: 12786 RVA: 0x00144F50 File Offset: 0x00143150
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o.000000o. = A_0
		End Sub

		' Token: 0x060031F3 RID: 12787 RVA: 0x00144F59 File Offset: 0x00143159
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o00O__.oO.
		End Function

		' Token: 0x060031F4 RID: 12788 RVA: 0x00144F64 File Offset: 0x00143164
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_ooo_0.0o_.
			Dim c1Button As C1Button = Me.o00O__.oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o00O__.oO. = A_0
			c1Button = Me.o00O__.oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060031F5 RID: 12789 RVA: 0x00144FA7 File Offset: 0x001431A7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0.0_oo.
		End Function

		' Token: 0x060031F6 RID: 12790 RVA: 0x00144FB0 File Offset: 0x001431B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.O00_.
			Dim oo0.0_oo. As C1Button = Me.Oo0.0_oo.
			If oo0.0_oo. IsNot Nothing Then
				RemoveHandler oo0.0_oo..Click, value
			End If
			Me.Oo0.0_oo. = A_0
			oo0.0_oo. = Me.Oo0.0_oo.
			If oo0.0_oo. IsNot Nothing Then
				AddHandler oo0.0_oo..Click, value
			End If
		End Sub

		' Token: 0x060031F7 RID: 12791 RVA: 0x00144FF3 File Offset: 0x001431F3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As TextBox
			Return Me.o.000000o.
		End Function

		' Token: 0x060031F8 RID: 12792 RVA: 0x00144FFB File Offset: 0x001431FB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TextBox)
			Me.o.000000o. = A_0
		End Sub

		' Token: 0x060031F9 RID: 12793 RVA: 0x00145004 File Offset: 0x00143204
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_0.0o__O.
		End Function

		' Token: 0x060031FA RID: 12794 RVA: 0x0014500C File Offset: 0x0014320C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_o_.Oo0O0_.
			Dim c1Button As C1Button = Me.o_0.0o__O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_0.0o__O. = A_0
			c1Button = Me.o_0.0o__O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060031FB RID: 12795 RVA: 0x0014504F File Offset: 0x0014324F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o00O__.oO.
		End Function

		' Token: 0x060031FC RID: 12796 RVA: 0x00145057 File Offset: 0x00143257
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o00O__.oO. = A_0
		End Sub

		' Token: 0x060031FD RID: 12797 RVA: 0x00145060 File Offset: 0x00143260
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o.000000o.
		End Function

		' Token: 0x060031FE RID: 12798 RVA: 0x00145068 File Offset: 0x00143268
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o.000000o. = A_0
		End Sub

		' Token: 0x060031FF RID: 12799 RVA: 0x00145074 File Offset: 0x00143274
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim connection As Connection = New ConnectionClass()
			Dim dataLinks As DataLinks = New DataLinksClass()
			If Operators.CompareString(Me.OO._000_O0o_.().Text, "", True) > 0 Then
				connection.ConnectionString = Me.OO._000_O0o_.().Text
			Else
				connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;"
			End If
			Try
				Dim dataSourceLocator As IDataSourceLocator = dataLinks
				Dim obj As Object = connection
				If dataSourceLocator.PromptEdit(obj) AndAlso Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", True) <> 0 Then
					Me.OO._000_O0o_.().Text = connection.ConnectionString
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06003200 RID: 12800 RVA: 0x00145120 File Offset: 0x00143320
		Private Function <<EMPTY_NAME>>(ByRef A_0 As String) As Boolean
			Dim text As String = Me.OO._000_O0o_.().Text.Trim()
			Dim result As Boolean
			If Operators.CompareString(text, "", True) = 0 Then
				result = False
			Else
				Try
					If text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						Return New O0O(text).OO._o_OO.()
					End If
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.OO._000_O0o_.().Text)
					oleDbConnection.Open()
					oleDbConnection.Close()
					Return True
				Catch ex As Exception
					A_0 = ex.Message
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x06003201 RID: 12801 RVA: 0x001451C4 File Offset: 0x001433C4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim str As String = ""
			If Me.OO.o0O0OO.(str) Then
				MessageBox.Show("链接测试成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			MessageBox.Show("链接测试失败！错误：" & vbCrLf + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06003202 RID: 12802 RVA: 0x00145210 File Offset: 0x00143410
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim str As String = ""
			If Me.OO.o0O0OO.(str) Then
				MyBase.DialogResult = DialogResult.OK
				Return
			End If
			MessageBox.Show("链接无效！ 错误:" & vbCrLf + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		' Token: 0x06003203 RID: 12803 RVA: 0x0014524E File Offset: 0x0014344E
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OO._000_O0o_.
			Me.OO.o0O0OO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003204 RID: 12804 RVA: 0x00145283 File Offset: 0x00143483
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001414 RID: 5140
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001415 RID: 5141
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001416 RID: 5142
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001417 RID: 5143
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001418 RID: 5144
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001419 RID: 5145
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TextBox

		' Token: 0x0400141A RID: 5146
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400141B RID: 5147
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400141C RID: 5148
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox
	End Class
End Namespace
