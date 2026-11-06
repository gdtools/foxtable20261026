Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200018B RID: 395
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06001236 RID: 4662 RVA: 0x0006EF47 File Offset: 0x0006D147
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.O.oO0_.
			AddHandler MyBase.Load, AddressOf Me.O_.O0_oo0.
			Me.ooo0.oO0_. = New Stack(Of O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00)()
			Me.o.o0Oo_Ooo_0O.()
		End Sub

		' Token: 0x06001237 RID: 4663 RVA: 0x0006EF84 File Offset: 0x0006D184
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.ooo0.oO0_. IsNot Nothing Then
					Me.ooo0.oO0_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001238 RID: 4664 RVA: 0x0006EFC4 File Offset: 0x0006D1C4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.ooo0.oO0_. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002))
			Me.o.o0Oo_Ooo_0O.(New ImageList(Me.ooo0.oO0_.))
			Me.O_.O0_oo0.(New Label())
			Me.o.o0Oo_Ooo_0O.(New Label())
			Me.o.o0Oo_Ooo_0O.(New Timer(Me.ooo0.oO0_.))
			MyBase.SuspendLayout()
			Me.o.o0Oo_Ooo_0O.().ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), ImageListStreamer)
			Me.o.o0Oo_Ooo_0O.().TransparentColor = Color.Transparent
			Me.o.o0Oo_Ooo_0O.().Images.SetKeyName(0, "info")
			Me.o.o0Oo_Ooo_0O.().Images.SetKeyName(1, "OK")
			Me.o.o0Oo_Ooo_0O.().Images.SetKeyName(2, "alert")
			Me.o.o0Oo_Ooo_0O.().Images.SetKeyName(3, "error")
			Me.o.o0Oo_Ooo_0O.().Images.SetKeyName(4, "question")
			Me.o.o0Oo_Ooo_0O.().ImageIndex = 0
			Me.o.o0Oo_Ooo_0O.().ImageList = Me.o.o0Oo_Ooo_0O.()
			Me.o.o0Oo_Ooo_0O.().Location = New Point(10, 24)
			Me.o.o0Oo_Ooo_0O.().Name = "lblIcon"
			Me.o.o0Oo_Ooo_0O.().Size = New Size(28, 28)
			Me.o.o0Oo_Ooo_0O.().TabIndex = 0
			Me.O_.O0_oo0.().Font = New Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.O_.O0_oo0.().Location = New Point(50, 22)
			Me.O_.O0_oo0.().Name = "lblMessage"
			Me.O_.O0_oo0.().Size = New Size(237, 62)
			Me.O_.O0_oo0.().TabIndex = 1
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.FromArgb(239, 246, 253)
			MyBase.ClientSize = New Size(299, 93)
			MyBase.Controls.Add(Me.O_.O0_oo0.())
			MyBase.Controls.Add(Me.o.o0Oo_Ooo_0O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.O.O.0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "信息"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001239 RID: 4665 RVA: 0x0006F236 File Offset: 0x0006D436
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ImageList
			Return Me.o.oOoO__o.
		End Function

		' Token: 0x0600123A RID: 4666 RVA: 0x0006F23E File Offset: 0x0006D43E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ImageList)
			Me.o.oOoO__o. = A_0
		End Sub

		' Token: 0x0600123B RID: 4667 RVA: 0x0006F247 File Offset: 0x0006D447
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.oOoO__o.
		End Function

		' Token: 0x0600123C RID: 4668 RVA: 0x0006F24F File Offset: 0x0006D44F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.oOoO__o. = A_0
		End Sub

		' Token: 0x0600123D RID: 4669 RVA: 0x0006F258 File Offset: 0x0006D458
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.o0O_0OO__O.
		End Function

		' Token: 0x0600123E RID: 4670 RVA: 0x0006F260 File Offset: 0x0006D460
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.o0O_0OO__O. = A_0
		End Sub

		' Token: 0x0600123F RID: 4671 RVA: 0x0006F269 File Offset: 0x0006D469
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.o.oOoO__o.
		End Function

		' Token: 0x06001240 RID: 4672 RVA: 0x0006F274 File Offset: 0x0006D474
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.o.oOoO__o.
			Dim timer As Timer = Me.o.oOoO__o.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.o.oOoO__o. = A_0
			timer = Me.o.oOoO__o.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x06001241 RID: 4673
		Private Declare Function AnimateWindow Lib "user32" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer) As Boolean

		' Token: 0x06001242 RID: 4674 RVA: 0x0006F2B8 File Offset: 0x0006D4B8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If Me.ooo0.oO0_..Count > 0 Then
				Me.ooo0.oO0_. = Me.ooo0.oO0_..Pop()
				Me.o.o0Oo_Ooo_0O.().ImageIndex = Me.ooo0.oO0_..ooo0.oO0_.
				Me.O_.O0_oo0.().Text = Me.ooo0.oO0_..oOooOoOo._0Oo.
				Me.Text = Me.ooo0.oO0_..o_o0_0OO.OoOO.
				If Me.ooo0.oO0_..o_o0_0OO.OoOO. > 0 Then
					Me.o.o0Oo_Ooo_0O.().Interval = Me.ooo0.oO0_..o_o0_0OO.OoOO. * 1000
					Me.o.o0Oo_Ooo_0O.().Enabled = True
				Else
					Me.o.o0Oo_Ooo_0O.().Enabled = False
				End If
				A_1.Cancel = True
				Return
			End If
			Me.ooo0.oO0_. = Nothing
			O_O0OO.o.0__0_O_. = Nothing
		End Sub

		' Token: 0x06001243 RID: 4675 RVA: 0x0006F380 File Offset: 0x0006D580
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Right - MyBase.Width
			Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Bottom - MyBase.Height
			MyBase.Location = New Point(x, y)
			O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.AnimateWindow(MyBase.Handle, 1000, 393224)
			MyBase.TopMost = True
		End Sub

		' Token: 0x06001244 RID: 4676 RVA: 0x0006F3EC File Offset: 0x0006D5EC
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Integer, A_3 As Integer)
			If Me.ooo0.oO0_. IsNot Nothing Then
				Me.ooo0.oO0_..Push(Me.ooo0.oO0_.)
			End If
			Me.ooo0.oO0_. = New O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00(A_0, A_1, A_2, A_3)
			Me.o.o0Oo_Ooo_0O.().ImageIndex = A_2
			Me.O_.O0_oo0.().Text = A_0
			Me.Text = A_1
			MyBase.Show()
			If A_3 > 0 Then
				Me.o.o0Oo_Ooo_0O.().Interval = A_3 * 1000
				Me.o.o0Oo_Ooo_0O.().Enabled = True
				Return
			End If
			Me.o.o0Oo_Ooo_0O.().Enabled = False
		End Sub

		' Token: 0x06001245 RID: 4677 RVA: 0x0006F478 File Offset: 0x0006D678
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.o0Oo_Ooo_0O.().Enabled = False
			MyBase.Close()
		End Sub

		' Token: 0x0400070D RID: 1805
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400070E RID: 1806
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x0400070F RID: 1807
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000710 RID: 1808
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000711 RID: 1809
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04000712 RID: 1810
		Private Const <<EMPTY_NAME>> As Integer = 2

		' Token: 0x04000713 RID: 1811
		Private Const <<EMPTY_NAME>> As Integer = 4

		' Token: 0x04000714 RID: 1812
		Private Const <<EMPTY_NAME>> As Integer = 8

		' Token: 0x04000715 RID: 1813
		Private Const <<EMPTY_NAME>> As Integer = 16

		' Token: 0x04000716 RID: 1814
		Private Const <<EMPTY_NAME>> As Integer = 65536

		' Token: 0x04000717 RID: 1815
		Private Const <<EMPTY_NAME>> As Integer = 131072

		' Token: 0x04000718 RID: 1816
		Private Const <<EMPTY_NAME>> As Integer = 262144

		' Token: 0x04000719 RID: 1817
		Private Const <<EMPTY_NAME>> As Integer = 524288

		' Token: 0x0400071A RID: 1818
		Private <<EMPTY_NAME>> As Stack(Of O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00)

		' Token: 0x0400071B RID: 1819
		Private <<EMPTY_NAME>> As O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00

		' Token: 0x0200018C RID: 396
		Private Class oooO0o00
			' Token: 0x06001246 RID: 4678 RVA: 0x0006F48C File Offset: 0x0006D68C
			Friend Sub New(A_0 As String, A_1 As String, A_2 As Integer, A_3 As Integer)
				Me.o_o0_0OO.OoOO. = -1
				Me.oOooOoOo._0Oo. = A_0
				Me.o_o0_0OO.OoOO. = A_1
				Me.ooo0.oO0_. = A_2
				Me.o_o0_0OO.OoOO. = A_3
			End Sub

			' Token: 0x0400071C RID: 1820
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400071D RID: 1821
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400071E RID: 1822
			Friend <<EMPTY_NAME>> As Integer

			' Token: 0x0400071F RID: 1823
			Friend <<EMPTY_NAME>> As Integer
		End Class
	End Class
End Namespace
