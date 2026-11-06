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
	' Token: 0x02000233 RID: 563
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class O\u3000O\u3000
		Inherits Form

		' Token: 0x06001A2B RID: 6699 RVA: 0x000A794C File Offset: 0x000A5B4C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.o0O_. IsNot Nothing Then
					Me.o.o0O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001A2C RID: 6700 RVA: 0x000A798C File Offset: 0x000A5B8C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.o0O_. = New Container()
			Me.o___Oo_oo_.O_.(New ProgressBar())
			Me.o___Oo_oo_.O_.(New Label())
			Me.o___Oo_oo_.O_.(New C1Button())
			Me.o___Oo_oo_.O_.(New Timer(Me.o.o0O_.))
			MyBase.SuspendLayout()
			Me.o___Oo_oo_.O_.().Location = New Point(12, 80)
			Me.o___Oo_oo_.O_.().Name = "ProgressBar1"
			Me.o___Oo_oo_.O_.().Size = New Size(453, 23)
			Me.o___Oo_oo_.O_.().TabIndex = 0
			Me.o___Oo_oo_.O_.().Location = New Point(12, 18)
			Me.o___Oo_oo_.O_.().Name = "Label1"
			Me.o___Oo_oo_.O_.().Size = New Size(453, 48)
			Me.o___Oo_oo_.O_.().TabIndex = 1
			Me.O._0Ooo0_.().Location = New Point(201, 135)
			Me.O._0Ooo0_.().Name = "Button1"
			Me.O._0Ooo0_.().Size = New Size(75, 23)
			Me.O._0Ooo0_.().TabIndex = 2
			Me.O._0Ooo0_.().Text = "取消"
			Me.O._0Ooo0_.().UseVisualStyleBackColor = True
			Me.o___Oo_oo_.O_.().Enabled = True
			Me.o___Oo_oo_.O_.().Interval = 300
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(477, 172)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.O._0Ooo0_.())
			MyBase.Controls.Add(Me.o___Oo_oo_.O_.())
			MyBase.Controls.Add(Me.o___Oo_oo_.O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O...o0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "正在下载"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001A2D RID: 6701 RVA: 0x000A7B9E File Offset: 0x000A5D9E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ProgressBar
			Return Me.o.o0O_.
		End Function

		' Token: 0x06001A2E RID: 6702 RVA: 0x000A7BA6 File Offset: 0x000A5DA6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ProgressBar)
			Me.o.o0O_. = A_0
		End Sub

		' Token: 0x06001A2F RID: 6703 RVA: 0x000A7BAF File Offset: 0x000A5DAF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.o0O_.
		End Function

		' Token: 0x06001A30 RID: 6704 RVA: 0x000A7BB7 File Offset: 0x000A5DB7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.o0O_. = A_0
		End Sub

		' Token: 0x06001A31 RID: 6705 RVA: 0x000A7BC0 File Offset: 0x000A5DC0
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o0O_.
		End Function

		' Token: 0x06001A32 RID: 6706 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O._0Ooo0_.
			Dim c1Button As C1Button = Me.o.o0O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.o0O_. = A_0
			c1Button = Me.o.o0O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001A33 RID: 6707 RVA: 0x000A7C0B File Offset: 0x000A5E0B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.o.o0O_.
		End Function

		' Token: 0x06001A34 RID: 6708 RVA: 0x000A7C14 File Offset: 0x000A5E14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.O_._oo0oO__O_.
			Dim timer As Timer = Me.o.o0O_.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.o.o0O_. = A_0
			timer = Me.o.o0O_.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x06001A35 RID: 6709 RVA: 0x000A7C57 File Offset: 0x000A5E57
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.o.o0O_.
		End Function

		' Token: 0x06001A36 RID: 6710 RVA: 0x000A7C60 File Offset: 0x000A5E60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.oO_o_0OOo__0 = AddressOf Me.O.oo0_ooOo.
			Dim a_2 As FTPClient.O__0O000__Oo = AddressOf Me.O._0Ooo0_.
			Dim a_3 As FTPClient.o0O_O00o_0_o = AddressOf Me.O._0Ooo0_.
			Dim a_4 As FTPClient.OoO_00_o = AddressOf Me.O._0Ooo0_.
			Dim a_5 As FTPClient.OOOOO00OoOOo = AddressOf Me.O._0Ooo0_.
			Dim ftpclient As FTPClient = Me.o.o0O_.
			If ftpclient IsNot Nothing Then
				RemoveHandler ftpclient.DownloadCompleted, a_
				RemoveHandler ftpclient.DownloadError, a_2
				RemoveHandler ftpclient.DownloadProgressChanged, a_3
				RemoveHandler ftpclient.ShowError, a_4
				RemoveHandler ftpclient.ShowMessage, a_5
			End If
			Me.o.o0O_. = A_0
			ftpclient = Me.o.o0O_.
			If ftpclient IsNot Nothing Then
				AddHandler ftpclient.DownloadCompleted, a_
				AddHandler ftpclient.DownloadError, a_2
				AddHandler ftpclient.DownloadProgressChanged, a_3
				AddHandler ftpclient.ShowError, a_4
				AddHandler ftpclient.ShowMessage, a_5
			End If
		End Sub

		' Token: 0x06001A37 RID: 6711 RVA: 0x000A7D20 File Offset: 0x000A5F20
		Public Sub New(A_0 As FTPClient, A_1 As String, A_2 As String)
			AddHandler MyBase.Activated, AddressOf Me.OO0.oo0.
			AddHandler MyBase.FormClosed, AddressOf Me.O._0Ooo0_.
			Me.o___Oo_oo_.O_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o___Oo_oo_.O_.(A_0)
			Me.o_0.o0O. = A_1
			Me.o.o0O_. = A_2
			Me.Text = "下载文件:" + OO_00oOO.FileSys.GetName(A_1)
		End Sub

		' Token: 0x06001A38 RID: 6712 RVA: 0x000A7DA4 File Offset: 0x000A5FA4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(Me.o.o0O_.)
				If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					OO_00oOO.FileSys.CreateDirectory(parentPath)
				End If
				Me.o___Oo_oo_.O_.().O_O0Ooo_00.o.(Me.o_0.o0O., Me.o.o0O_., False)
			End If
		End Sub

		' Token: 0x06001A39 RID: 6713 RVA: 0x000A7E04 File Offset: 0x000A6004
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.OO0OOoO.oo0., "", True) > 0 Then
				Me.o___Oo_oo_.O_.().Text = Me.OO0OOoO.oo0.
				Me.o___Oo_oo_.O_.().Value = Me.o.00_O_.
				Me.OO0OOoO.oo0. = ""
			End If
			If Operators.CompareString(Me.o0.O0o0OOO_., "", True) > 0 Then
				Me.O._0Ooo0_.().Text = Me.o0.O0o0OOO_.
				Me.o0.O0o0OOO_. = ""
			End If
			SyncLock Me
				If MyBase.Visible AndAlso Me.o.00_O_. AndAlso (DateTime.Now - Me.o.00_O_.).TotalSeconds > 2.0 AndAlso Me.o___Oo_oo_.O_.().AsyncState = Oo_0.OOoo0_OO__._o. Then
					Me.o___Oo_oo_.O_.().O_O0Ooo_00.o.(Me.o_0.o0O., Me.o.o0O_., False)
					Me.o.00_O_. = False
				End If
			End SyncLock
		End Sub

		' Token: 0x06001A3A RID: 6714 RVA: 0x000A7F0C File Offset: 0x000A610C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06001A3B RID: 6715 RVA: 0x000A7F18 File Offset: 0x000A6118
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean)
			SyncLock Me
				If A_1 AndAlso Not Me.o.00_O_. Then
					Me.o.00_O_. = True
					Me.o.00_O_. = DateTime.Now
					Me.OO0OOoO.oo0. = "下载过程出现意外错误，正在准备重新尝试...."
				Else
					Me.o0.O0o0OOO_. = "关闭"
				End If
			End SyncLock
		End Sub

		' Token: 0x06001A3C RID: 6716 RVA: 0x000A7F84 File Offset: 0x000A6184
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Long, A_2 As Long, A_3 As Long, A_4 As TimeSpan)
			Me.o.00_O_. = CInt(Math.Round(100.0 * Math.Round(CDbl((A_2 + A_3)) / CDbl(A_1), 4)))
			Me.OO0OOoO.oo0. = String.Concat(New String() { "总大小:", Strings.Format(CInt(Math.Round(CDbl(A_1) / 1024.0)), "#,##0"), "K, 已完成:", Strings.Format(CInt(Math.Round(CDbl((A_2 + A_3)) / 1024.0)), "#,##0"), "K, 平均速度:", Conversions.ToString(CInt(Math.Round(CDbl(A_3) / A_4.TotalSeconds / 1024.0))), "K/S" })
		End Sub

		' Token: 0x06001A3D RID: 6717 RVA: 0x000A8054 File Offset: 0x000A6254
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Me.OO0OOoO.oo0. = A_0 + "," + A_1
		End Sub

		' Token: 0x06001A3E RID: 6718 RVA: 0x000A8068 File Offset: 0x000A6268
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO0OOoO.oo0. = A_0
		End Sub

		' Token: 0x06001A3F RID: 6719 RVA: 0x000A8071 File Offset: 0x000A6271
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o___Oo_oo_.O_.().o_0_.__0OO.()
			Me.o___Oo_oo_.O_.(Nothing)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06001A40 RID: 6720 RVA: 0x000A808C File Offset: 0x000A628C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.o___Oo_oo_.O_.(Nothing)
			Me.o___Oo_oo_.O_.().Enabled = False
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000AFE RID: 2814
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000AFF RID: 2815
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ProgressBar

		' Token: 0x04000B00 RID: 2816
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000B01 RID: 2817
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000B02 RID: 2818
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04000B03 RID: 2819
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04000B04 RID: 2820
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B05 RID: 2821
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B06 RID: 2822
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B07 RID: 2823
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000B08 RID: 2824
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B09 RID: 2825
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000B0A RID: 2826
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B0B RID: 2827
		Private a As Integer
	End Class
End Namespace
