Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200018D RID: 397
	<DesignerGenerated()>
	Friend Partial Class oO\u3000\u3002\u3002\u3000O\u3000
		Inherits Form

		' Token: 0x06001247 RID: 4679 RVA: 0x0006F4B8 File Offset: 0x0006D6B8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OOo._o0__0Ooo_. IsNot Nothing Then
					Me.OOo._o0__0Ooo_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001248 RID: 4680 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OOo._o0__0Ooo_. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(oO\u3000\u3002\u3002\u3000O\u3000))
			Me.o___.O0OOOO.(New PictureBox())
			Me.o0_o.oO.(New Label())
			Me.o___.O0OOOO.(New Label())
			Me.O_.0OOOOO0o0.(New Label())
			Me.o___.O0OOOO.(New C1Button())
			Me.oO000._0OO0.(New Timer(Me.OOo._o0__0Ooo_.))
			CType(Me.o___.O0OOOO.(), ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.o___.O0OOOO.().Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Image)
			Me.o___.O0OOOO.().Location = New Point(12, 12)
			Me.o___.O0OOOO.().Name = "PictureBox1"
			Me.o___.O0OOOO.().Size = New Size(48, 43)
			Me.o___.O0OOOO.().TabIndex = 0
			Me.o___.O0OOOO.().TabStop = False
			Me.OO0.OO_O_oO_0.().AutoSize = True
			Me.OO0.OO_O_oO_0.().Location = New Point(66, 12)
			Me.OO0.OO_O_oO_0.().Name = "Label1"
			Me.OO0.OO_O_oO_0.().Size = New Size(95, 12)
			Me.OO0.OO_O_oO_0.().TabIndex = 1
			Me.OO0.OO_O_oO_0.().Text = "OpenQQ失去连接!"
			Me.O_.0OOOOO0o0.().AutoSize = True
			Me.O_.0OOOOO0o0.().Location = New Point(66, 34)
			Me.O_.0OOOOO0o0.().Name = "Label2"
			Me.O_.0OOOOO0o0.().Size = New Size(239, 12)
			Me.O_.0OOOOO0o0.().TabIndex = 2
			Me.O_.0OOOOO0o0.().Text = "由于网络问题，OpenQQ失去和服务器的连接!"
			Me.o0_o.oO.().AutoSize = True
			Me.o0_o.oO.().Location = New Point(66, 55)
			Me.o0_o.oO.().Name = "Label3"
			Me.o0_o.oO.().Size = New Size(119, 12)
			Me.o0_o.oO.().TabIndex = 3
			Me.o0_o.oO.().Text = "正在重新连接服务器."
			Me.OO0.OO_O_oO_0.().Location = New Point(119, 91)
			Me.OO0.OO_O_oO_0.().Name = "Button1"
			Me.OO0.OO_O_oO_0.().Size = New Size(75, 23)
			Me.OO0.OO_O_oO_0.().TabIndex = 4
			Me.OO0.OO_O_oO_0.().Text = "取消"
			Me.OO0.OO_O_oO_0.().UseVisualStyleBackColor = True
			Me.OO0.OO_O_oO_0.().VisualStyleBaseStyle = 3
			Me.o___.O0OOOO.().Enabled = True
			Me.o___.O0OOOO.().Interval = 1000
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.FromArgb(239, 246, 253)
			MyBase.ClientSize = New Size(312, 126)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.OO0.OO_O_oO_0.())
			MyBase.Controls.Add(Me.o0_o.oO.())
			MyBase.Controls.Add(Me.O_.0OOOOO0o0.())
			MyBase.Controls.Add(Me.OO0.OO_O_oO_0.())
			MyBase.Controls.Add(Me.o___.O0OOOO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Name = "Oo0o...."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "提示"
			CType(Me.o___.O0OOOO.(), ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06001249 RID: 4681 RVA: 0x0006F876 File Offset: 0x0006DA76
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PictureBox
			Return Me.oO000._0OO0.
		End Function

		' Token: 0x0600124A RID: 4682 RVA: 0x0006F87E File Offset: 0x0006DA7E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PictureBox)
			Me.oO000._0OO0. = A_0
		End Sub

		' Token: 0x0600124B RID: 4683 RVA: 0x0006F887 File Offset: 0x0006DA87
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.oO000._0OO0.
		End Function

		' Token: 0x0600124C RID: 4684 RVA: 0x0006F88F File Offset: 0x0006DA8F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO000._0OO0. = A_0
		End Sub

		' Token: 0x0600124D RID: 4685 RVA: 0x0006F898 File Offset: 0x0006DA98
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O___O_0O_O_.O.
		End Function

		' Token: 0x0600124E RID: 4686 RVA: 0x0006F8A0 File Offset: 0x0006DAA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O___O_0O_O_.O. = A_0
		End Sub

		' Token: 0x0600124F RID: 4687 RVA: 0x0006F8A9 File Offset: 0x0006DAA9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo___O___O_.O_.
		End Function

		' Token: 0x06001250 RID: 4688 RVA: 0x0006F8B1 File Offset: 0x0006DAB1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo___O___O_.O_. = A_0
		End Sub

		' Token: 0x06001251 RID: 4689 RVA: 0x0006F8BA File Offset: 0x0006DABA
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO000._0OO0.
		End Function

		' Token: 0x06001252 RID: 4690 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0.OO_O_oO_0.
			Dim c1Button As C1Button = Me.oO000._0OO0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO000._0OO0. = A_0
			c1Button = Me.oO000._0OO0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001253 RID: 4691 RVA: 0x0006F907 File Offset: 0x0006DB07
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.oO000._0OO0.
		End Function

		' Token: 0x06001254 RID: 4692 RVA: 0x0006F910 File Offset: 0x0006DB10
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.O___O_0O_O_.O.
			Dim timer As Timer = Me.oO000._0OO0.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.oO000._0OO0. = A_0
			timer = Me.oO000._0OO0.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x06001255 RID: 4693 RVA: 0x0006F954 File Offset: 0x0006DB54
		Friend Sub New(A_0 As IMClient, A_1 As IPEndPoint)
			AddHandler MyBase.FormClosing, AddressOf Me.OO0.OO_O_oO_0.
			AddHandler MyBase.Load, AddressOf Me.Oo.Oo_O0_O0.
			Me.OOo._o0__0Ooo_. = ChrW(4) + OoOo0O.OO_o.0o_O.(3) + ChrW(4)
			Me.O_.0o_o0o. = DateTime.Now
			Me.o___.O0OOOO.()
			Me.OOo._o0__0Ooo_. = A_0
			Me.O_OooO.0oOOO0. = A_1
			Me.O_OooO.0oOOO0. = New UdpClient(0)
			o0___oO.O.oOo0O0O.(Me.O_OooO.0oOOO0.)
		End Sub

		' Token: 0x06001256 RID: 4694
		Private Declare Function AnimateWindow Lib "user32" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer) As Boolean

		' Token: 0x06001257 RID: 4695 RVA: 0x0006F9DC File Offset: 0x0006DBDC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Me.o___.O0OOOO.().Enabled = False
		End Sub

		' Token: 0x06001258 RID: 4696 RVA: 0x0006F9EC File Offset: 0x0006DBEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - MyBase.Width
			Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - MyBase.Height
			MyBase.Location = New Point(x, y)
			oO\u3000\u3002\u3002\u3000O\u3000.AnimateWindow(MyBase.Handle, 300, 393224)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06001259 RID: 4697 RVA: 0x0006FA58 File Offset: 0x0006DC58
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.o0_o.oO.().Text
			Dim text2 As String = Me.o0_o.oO.().Text.Replace(".", "")
			If text.Length - text2.Length >= 6 Then
				Me.o0_o.oO.().Text = text2 + "."
			Else
				Me.o0_o.oO.().Text = text + "."
			End If
			If Not OO_00oOO.IMClients.ContainsKey(Me.OOo._o0__0Ooo_..Name) Then
				MyBase.Close()
				Return
			End If
			If Not NetworkInterface.GetIsNetworkAvailable() Then
				Me.O_.0o_o0o. = DateTime.Now
				Return
			End If
			Try
				If Me.OOo._o0__0Ooo_. Then
					If(DateTime.Now - Me.O_OooO.0oOOO0.).TotalSeconds >= 2.0 AndAlso Not Me.OOo._o0__0Ooo_..Ready AndAlso Me.OOo._o0__0Ooo_..Start(5) Then
						MyBase.Close()
					End If
				ElseIf(DateTime.Now - Me.O_.0o_o0o.).TotalSeconds >= 3.0 Then
					Dim s As String = ChrW(5) & vbVerticalTab & ChrW(5)
					Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
					Me.O_OooO.0oOOO0..Send(bytes, bytes.Length, Me.O_OooO.0oOOO0.)
					If Me.O_OooO.0oOOO0..Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Me.O_OooO.0oOOO0..Receive(ipendPoint)
						If Operators.CompareString(ipendPoint.ToString(), Me.O_OooO.0oOOO0..ToString(), True) = 0 Then
							Me.OOo._o0__0Ooo_. = True
							Me.O_OooO.0oOOO0. = DateTime.Now
						End If
					End If
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x0600125A RID: 4698 RVA: 0x0006FC38 File Offset: 0x0006DE38
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x04000720 RID: 1824
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000721 RID: 1825
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PictureBox

		' Token: 0x04000722 RID: 1826
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000723 RID: 1827
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000724 RID: 1828
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000725 RID: 1829
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000726 RID: 1830
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04000727 RID: 1831
		Private Const <<EMPTY_NAME>> As Integer = 2

		' Token: 0x04000728 RID: 1832
		Private Const <<EMPTY_NAME>> As Integer = 4

		' Token: 0x04000729 RID: 1833
		Private Const <<EMPTY_NAME>> As Integer = 8

		' Token: 0x0400072A RID: 1834
		Private Const <<EMPTY_NAME>> As Integer = 16

		' Token: 0x0400072B RID: 1835
		Private Const <<EMPTY_NAME>> As Integer = 65536

		' Token: 0x0400072C RID: 1836
		Private Const <<EMPTY_NAME>> As Integer = 131072

		' Token: 0x0400072D RID: 1837
		Private Const <<EMPTY_NAME>> As Integer = 262144

		' Token: 0x0400072E RID: 1838
		Private Const <<EMPTY_NAME>> As Integer = 524288

		' Token: 0x0400072F RID: 1839
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x04000730 RID: 1840
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x04000731 RID: 1841
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000732 RID: 1842
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000733 RID: 1843
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000734 RID: 1844
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000735 RID: 1845
		Private <<EMPTY_NAME>> As UdpClient
	End Class
End Namespace
