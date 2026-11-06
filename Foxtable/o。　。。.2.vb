Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002C5 RID: 709
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3002\u3000\u3002\u3002\u3000
		Inherits Form

		' Token: 0x060025DC RID: 9692 RVA: 0x00101ABC File Offset: 0x000FFCBC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OoOoO.OO. IsNot Nothing Then
					Me.OoOoO.OO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060025DD RID: 9693 RVA: 0x00101AFC File Offset: 0x000FFCFC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OoOoO.OO. = New Container()
			Me.O.OooOO__O_.(New ProgressBar())
			Me.O.OooOO__O_.(New Label())
			Me.O.OooOO__O_.(New C1Button())
			Me.O.OooOO__O_.(New Timer(Me.OoOoO.OO.))
			MyBase.SuspendLayout()
			Me.o.0o__0O0.().Location = New Point(12, 80)
			Me.o.0o__0O0.().Name = "ProgressBar1"
			Me.o.0o__0O0.().Size = New Size(453, 23)
			Me.o.0o__0O0.().TabIndex = 0
			Me.o.0o__0O0.().Location = New Point(12, 18)
			Me.o.0o__0O0.().Name = "Label1"
			Me.o.0o__0O0.().Size = New Size(453, 48)
			Me.o.0o__0O0.().TabIndex = 1
			Me.o.0o__0O0.().Location = New Point(201, 135)
			Me.o.0o__0O0.().Name = "Button1"
			Me.o.0o__0O0.().Size = New Size(75, 23)
			Me.o.0o__0O0.().TabIndex = 2
			Me.o.0o__0O0.().Text = "取消"
			Me.o.0o__0O0.().UseVisualStyleBackColor = True
			Me.o.0o__0O0.().Enabled = True
			Me.o.0o__0O0.().Interval = 300
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(477, 172)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.o.0o__0O0.())
			MyBase.Controls.Add(Me.o.0o__0O0.())
			MyBase.Controls.Add(Me.o.0o__0O0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0......"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "正在上传"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060025DE RID: 9694 RVA: 0x00101D0E File Offset: 0x000FFF0E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ProgressBar
			Return Me.OoOoO.OO.
		End Function

		' Token: 0x060025DF RID: 9695 RVA: 0x00101D16 File Offset: 0x000FFF16
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ProgressBar)
			Me.OoOoO.OO. = A_0
		End Sub

		' Token: 0x060025E0 RID: 9696 RVA: 0x00101D1F File Offset: 0x000FFF1F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.OooOO__O_.
		End Function

		' Token: 0x060025E1 RID: 9697 RVA: 0x00101D27 File Offset: 0x000FFF27
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.OooOO__O_. = A_0
		End Sub

		' Token: 0x060025E2 RID: 9698 RVA: 0x00101D30 File Offset: 0x000FFF30
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OooOO__O_.
		End Function

		' Token: 0x060025E3 RID: 9699 RVA: 0x00101D38 File Offset: 0x000FFF38
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.O_0_0.
			Dim o.OooOO__O_. As C1Button = Me.O.OooOO__O_.
			If o.OooOO__O_. IsNot Nothing Then
				RemoveHandler o.OooOO__O_..Click, value
			End If
			Me.O.OooOO__O_. = A_0
			o.OooOO__O_. = Me.O.OooOO__O_.
			If o.OooOO__O_. IsNot Nothing Then
				AddHandler o.OooOO__O_..Click, value
			End If
		End Sub

		' Token: 0x060025E4 RID: 9700 RVA: 0x00101D7B File Offset: 0x000FFF7B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.OoOoO.OO.
		End Function

		' Token: 0x060025E5 RID: 9701 RVA: 0x00101D84 File Offset: 0x000FFF84
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.o_0O0.0OOo.
			Dim ooOoO.OO. As Timer = Me.OoOoO.OO.
			If ooOoO.OO. IsNot Nothing Then
				RemoveHandler ooOoO.OO..Tick, value
			End If
			Me.OoOoO.OO. = A_0
			ooOoO.OO. = Me.OoOoO.OO.
			If ooOoO.OO. IsNot Nothing Then
				AddHandler ooOoO.OO..Tick, value
			End If
		End Sub

		' Token: 0x060025E6 RID: 9702 RVA: 0x00101DC7 File Offset: 0x000FFFC7
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.O.OooOO__O_.
		End Function

		' Token: 0x060025E7 RID: 9703 RVA: 0x00101DD0 File Offset: 0x000FFFD0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.oO___ = AddressOf Me.oO0oO_O.00OOO_.
			Dim a_2 As FTPClient.ooo__O = AddressOf Me.oO0oO_O.00OOO_.
			Dim a_3 As FTPClient.o0_O_0_0 = AddressOf Me.o.0o__0O0.
			Dim a_4 As FTPClient.OoO_00_o = AddressOf Me.o.O_0_0.
			Dim a_5 As FTPClient.OOOOO00OoOOo = AddressOf Me.o.0o__0O0.
			Dim o.OooOO__O_. As FTPClient = Me.O.OooOO__O_.
			If o.OooOO__O_. IsNot Nothing Then
				RemoveHandler o.OooOO__O_..UploadCompleted, a_
				RemoveHandler o.OooOO__O_..UploadError, a_2
				RemoveHandler o.OooOO__O_..UploadProgressChanged, a_3
				RemoveHandler o.OooOO__O_..ShowError, a_4
				RemoveHandler o.OooOO__O_..ShowMessage, a_5
			End If
			Me.O.OooOO__O_. = A_0
			o.OooOO__O_. = Me.O.OooOO__O_.
			If o.OooOO__O_. IsNot Nothing Then
				AddHandler o.OooOO__O_..UploadCompleted, a_
				AddHandler o.OooOO__O_..UploadError, a_2
				AddHandler o.OooOO__O_..UploadProgressChanged, a_3
				AddHandler o.OooOO__O_..ShowError, a_4
				AddHandler o.OooOO__O_..ShowMessage, a_5
			End If
		End Sub

		' Token: 0x060025E8 RID: 9704 RVA: 0x00101E90 File Offset: 0x00100090
		Public Sub New(A_0 As FTPClient, A_1 As String, A_2 As String)
			AddHandler MyBase.Activated, AddressOf Me.O0_o__o.oo0.
			AddHandler MyBase.FormClosed, AddressOf Me.o.O_0_0.
			Me.o.0o__0O0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O.OooOO__O_.(A_0)
			Me.OoOoO.OO. = A_1
			Me.oOO._o0O. = A_2
			Me.Text = "上传文件:" + OO_00oOO.FileSys.GetName(A_1)
		End Sub

		' Token: 0x060025E9 RID: 9705 RVA: 0x00101F12 File Offset: 0x00100112
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Me.o.0o__0O0.().o0O_0_.00_oooo.(Me.OoOoO.OO., Me.oOO._o0O., False)
			End If
		End Sub

		' Token: 0x060025EA RID: 9706 RVA: 0x00101F3C File Offset: 0x0010013C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.o0.0o00o_0o0., "", True) > 0 Then
				Me.o.0o__0O0.().Text = Me.o0.0o00o_0o0.
				Me.o.0o__0O0.().Value = Me.OoOoO.OO.
				Me.o0.0o00o_0o0. = ""
			End If
			If Operators.CompareString(Me.O00o0o.o., "", True) > 0 Then
				Me.o.0o__0O0.().Text = Me.O00o0o.o.
				Me.O00o0o.o. = ""
			End If
		End Sub

		' Token: 0x060025EB RID: 9707 RVA: 0x00101FBA File Offset: 0x001001BA
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060025EC RID: 9708 RVA: 0x00101FC3 File Offset: 0x001001C3
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0.0o00o_0o0. = "上传过程出现意外错误，上传失败...."
			Me.O00o0o.o. = "关闭"
		End Sub

		' Token: 0x060025ED RID: 9709 RVA: 0x00101FDC File Offset: 0x001001DC
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Long, A_2 As Long, A_3 As Long, A_4 As TimeSpan)
			Me.OoOoO.OO. = CInt(Math.Round(100.0 * Math.Round(CDbl((A_2 + A_3)) / CDbl(A_1), 4)))
			Me.o0.0o00o_0o0. = String.Concat(New String() { "总大小:", Strings.Format(CInt(Math.Round(CDbl(A_1) / 1024.0)), "#,##0"), "K, 已完成:", Strings.Format(CInt(Math.Round(CDbl((A_2 + A_3)) / 1024.0)), "#,##0"), "K, 平均速度:", Conversions.ToString(CInt(Math.Round(CDbl(A_3) / A_4.TotalSeconds / 1024.0))), "K/S" })
		End Sub

		' Token: 0x060025EE RID: 9710 RVA: 0x001020AC File Offset: 0x001002AC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Me.o0.0o00o_0o0. = A_0 + "," + A_1
		End Sub

		' Token: 0x060025EF RID: 9711 RVA: 0x001020C0 File Offset: 0x001002C0
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0.0o00o_0o0. = A_0
		End Sub

		' Token: 0x060025F0 RID: 9712 RVA: 0x001020C9 File Offset: 0x001002C9
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0o__0O0.().o_0_.__0OO.()
			Me.O.OooOO__O_.(Nothing)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060025F1 RID: 9713 RVA: 0x001020E4 File Offset: 0x001002E4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.O.OooOO__O_.(Nothing)
			Me.o.0o__0O0.().Enabled = False
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000F96 RID: 3990
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000F97 RID: 3991
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ProgressBar

		' Token: 0x04000F98 RID: 3992
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000F99 RID: 3993
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000F9A RID: 3994
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04000F9B RID: 3995
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04000F9C RID: 3996
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F9D RID: 3997
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F9E RID: 3998
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000F9F RID: 3999
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FA0 RID: 4000
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FA1 RID: 4001
		Private a As Integer
	End Class
End Namespace
