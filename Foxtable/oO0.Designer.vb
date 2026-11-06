Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001D2 RID: 466
	Friend Class oO0
		Inherits UserControl

		' Token: 0x060015C5 RID: 5573 RVA: 0x000906D8 File Offset: 0x0008E8D8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooO._OoO0_0.
		End Function

		' Token: 0x060015C6 RID: 5574 RVA: 0x000906E0 File Offset: 0x0008E8E0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooO._OoO0_0. = A_0
		End Sub

		' Token: 0x060015C7 RID: 5575 RVA: 0x000906E9 File Offset: 0x0008E8E9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ProgressBar
			Return Me.O_oo__._O.
		End Function

		' Token: 0x060015C8 RID: 5576 RVA: 0x000906F1 File Offset: 0x0008E8F1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ProgressBar)
			Me.O_oo__._O. = A_0
		End Sub

		' Token: 0x060015C9 RID: 5577 RVA: 0x000906FA File Offset: 0x0008E8FA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PictureBox
			Return Me.O_oo__._O.
		End Function

		' Token: 0x060015CA RID: 5578 RVA: 0x00090702 File Offset: 0x0008E902
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PictureBox)
			Me.O_oo__._O. = A_0
		End Sub

		' Token: 0x060015CB RID: 5579 RVA: 0x0009070B File Offset: 0x0008E90B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O._oooooooOO.
		End Function

		' Token: 0x060015CC RID: 5580 RVA: 0x00090714 File Offset: 0x0008E914
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.O0O_0O0.Oo.
			Dim o._oooooooOO. As Label = Me.O._oooooooOO.
			If o._oooooooOO. IsNot Nothing Then
				RemoveHandler o._oooooooOO..Click, value
			End If
			Me.O._oooooooOO. = A_0
			o._oooooooOO. = Me.O._oooooooOO.
			If o._oooooooOO. IsNot Nothing Then
				AddHandler o._oooooooOO..Click, value
			End If
		End Sub

		' Token: 0x060015CD RID: 5581 RVA: 0x00090757 File Offset: 0x0008E957
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0Oo0O0.0__0oo.
		End Function

		' Token: 0x060015CE RID: 5582 RVA: 0x0009075F File Offset: 0x0008E95F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0Oo0O0.0__0oo. = A_0
		End Sub

		' Token: 0x060015CF RID: 5583 RVA: 0x00090768 File Offset: 0x0008E968
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOo0.oo__0_oo.
		End Function

		' Token: 0x060015D0 RID: 5584 RVA: 0x00090770 File Offset: 0x0008E970
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.o_.0o0O__.
			Dim label As Label = Me.oOo0.oo__0_oo.
			If label IsNot Nothing Then
				RemoveHandler label.Click, value
			End If
			Me.oOo0.oo__0_oo. = A_0
			label = Me.oOo0.oo__0_oo.
			If label IsNot Nothing Then
				AddHandler label.Click, value
			End If
		End Sub

		' Token: 0x060015D1 RID: 5585 RVA: 0x000907B3 File Offset: 0x0008E9B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.O__0O_O_O.
		End Function

		' Token: 0x060015D2 RID: 5586 RVA: 0x000907BB File Offset: 0x0008E9BB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.O__0O_O_O. = A_0
		End Sub

		' Token: 0x060015D3 RID: 5587 RVA: 0x000907C4 File Offset: 0x0008E9C4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_o_O.0.
		End Function

		' Token: 0x060015D4 RID: 5588 RVA: 0x000907CC File Offset: 0x0008E9CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.o.oo00_.
			Dim label As Label = Me.o_o_O.0.
			If label IsNot Nothing Then
				RemoveHandler label.SizeChanged, value
			End If
			Me.o_o_O.0. = A_0
			label = Me.o_o_O.0.
			If label IsNot Nothing Then
				AddHandler label.SizeChanged, value
			End If
		End Sub

		' Token: 0x060015D5 RID: 5589 RVA: 0x00090810 File Offset: 0x0008EA10
		Friend Sub New(A_0 As IMClient, A_1 As IMBuddy, A_2 As String, A_3 As SendTypeEnum)
			Me.o_.0o0O__.()
			Me.o_o0_0.o_o_0. = A_0
			Me.O_oo__._O. = A_1
			Me.O_oo__._O. = A_2
			Me.o_.0o0O__.().Image = ooO.o.O_0000_O.(Path.GetExtension(A_2))
			Me.o0O.Oo. = OoOo0O.OO_o.0o_O.(10)
			Me.O_oo__._O. = A_3
			If A_1 Is Nothing Then
				Me.Oo_.OO.().Text = "向服务器发送文件:"
			ElseIf TypeOf A_1 Is ooo0 OrElse TypeOf A_1 Is O_0OOOoO Then
				Me.Oo_.OO.().Text = "向" + A_1.SimpleName + "分享:"
			Else
				Me.Oo_.OO.().Text = "向" + A_1.SimpleName + "发送文件:"
			End If
			Me.o_.0o0O__.().Minimum = 0
			Me.o_.0o0O__.().Maximum = 100
			If Me.O_oo__._O. Is Nothing OrElse TypeOf Me.O_oo__._O. Is ooo0 OrElse TypeOf Me.O_oo__._O. Is O_0OOOoO Then
				Me.o.oo00_.().Visible = False
			End If
		End Sub

		' Token: 0x060015D6 RID: 5590 RVA: 0x00090917 File Offset: 0x0008EB17
		Public Function <<EMPTY_NAME>>() As SendTypeEnum
			Return Me.O_oo__._O.
		End Function

		' Token: 0x060015D7 RID: 5591 RVA: 0x00090920 File Offset: 0x0008EB20
		Private Sub <<EMPTY_NAME>>()
			Me.o.0_oOOooo.(New Label())
			Me.ooO._OoO0_0.(New ProgressBar())
			Me.ooO._OoO0_0.(New PictureBox())
			Me.oOO.o00O00O0o_.(New Label())
			Me.ooO._OoO0_0.(New Label())
			Me.O00_o_0_.o.(New Label())
			Me.O._oooooooOO.(New Label())
			Me.ooo_.o___o.(New Label())
			CType(Me.o_.0o0O__.(), ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Oo_.OO.().AutoSize = True
			Me.Oo_.OO.().ForeColor = Color.DarkGray
			Me.Oo_.OO.().Location = New Point(44, 4)
			Me.Oo_.OO.().Name = "lblBuddy"
			Me.Oo_.OO.().Size = New Size(77, 12)
			Me.Oo_.OO.().TabIndex = 0
			Me.Oo_.OO.().Text = "发送文件请求"
			Me.o_.0o0O__.().Anchor = (AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_.0o0O__.().Location = New Point(0, 44)
			Me.o_.0o0O__.().Name = "ProgressBar1"
			Me.o_.0o0O__.().Size = New Size(261, 10)
			Me.o_.0o0O__.().TabIndex = 1
			Me.o_.0o0O__.().Location = New Point(2, 2)
			Me.o_.0o0O__.().Name = "PictureBox1"
			Me.o_.0o0O__.().Size = New Size(32, 32)
			Me.o_.0o0O__.().SizeMode = PictureBoxSizeMode.StretchImage
			Me.o_.0o0O__.().TabIndex = 3
			Me.o_.0o0O__.().TabStop = False
			Me.OO0.oo_o00o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO0.oo_o00o.().AutoSize = True
			Me.OO0.oo_o00o.().Cursor = Cursors.Hand
			Me.OO0.oo_o00o.().ForeColor = SystemColors.MenuHighlight
			Me.OO0.oo_o00o.().Location = New Point(228, 80)
			Me.OO0.oo_o00o.().Name = "lblCancel"
			Me.OO0.oo_o00o.().Size = New Size(29, 12)
			Me.OO0.oo_o00o.().TabIndex = 4
			Me.OO0.oo_o00o.().Text = "取消"
			Me.OO_.0OOo.().AutoSize = True
			Me.OO_.0OOo.().ForeColor = SystemColors.ControlText
			Me.OO_.0OOo.().Location = New Point(44, 21)
			Me.OO_.0OOo.().Name = "lblFileName"
			Me.OO_.0OOo.().Size = New Size(77, 12)
			Me.OO_.0OOo.().TabIndex = 5
			Me.OO_.0OOo.().Text = "foxtable.exe"
			Me.o.oo00_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o.oo00_.().AutoSize = True
			Me.o.oo00_.().Cursor = Cursors.Hand
			Me.o.oo00_.().ForeColor = SystemColors.MenuHighlight
			Me.o.oo00_.().Location = New Point(146, 80)
			Me.o.oo00_.().Name = "lblSendOffline"
			Me.o.oo00_.().Size = New Size(77, 12)
			Me.o.oo00_.().TabIndex = 6
			Me.o.oo00_.().Text = "发送离线文件"
			Me.o_.0o0O__.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o_.0o0O__.().AutoSize = True
			Me.o_.0o0O__.().ForeColor = SystemColors.ControlText
			Me.o_.0o0O__.().Location = New Point(2, 60)
			Me.o_.0o0O__.().Name = "lblSpeed"
			Me.o_.0o0O__.().Size = New Size(0, 12)
			Me.o_.0o0O__.().TabIndex = 8
			Me.o_0O.00.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o_0O.00.().AutoSize = True
			Me.o_0O.00.().ForeColor = SystemColors.ControlText
			Me.o_0O.00.().Location = New Point(228, 60)
			Me.o_0O.00.().Name = "lblProgress"
			Me.o_0O.00.().Size = New Size(29, 12)
			Me.o_0O.00.().TabIndex = 9
			Me.o_0O.00.().Text = "进度"
			Me.BackColor = Color.FromArgb(239, 246, 253)
			MyBase.Controls.Add(Me.o_0O.00.())
			MyBase.Controls.Add(Me.o_.0o0O__.())
			MyBase.Controls.Add(Me.o.oo00_.())
			MyBase.Controls.Add(Me.OO_.0OOo.())
			MyBase.Controls.Add(Me.OO0.oo_o00o.())
			MyBase.Controls.Add(Me.o_.0o0O__.())
			MyBase.Controls.Add(Me.o_.0o0O__.())
			MyBase.Controls.Add(Me.Oo_.OO.())
			MyBase.Name = "O..OO.o."
			MyBase.Size = New Size(261, 96)
			CType(Me.o_.0o0O__.(), ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060015D8 RID: 5592 RVA: 0x00090E04 File Offset: 0x0008F004
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			CType(MyBase.FindForm(), o\u3000\u3002\u3000\u3002\u3000).oOOOO.O.(Me)
			Dim str As String = vbVerticalTab
			Dim text As String = "%5" + str + Me.o0O.Oo.
			If Me.O_oo__._O. Is Nothing OrElse TypeOf Me.O_oo__._O. Is ooo0 OrElse TypeOf Me.O_oo__._O. Is O_0OOOoO Then
				Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(text)
			Else
				Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(Me.O_oo__._O..Name, text)
			End If
			Dim flag As Boolean
			Dim expression As Boolean
			Try
				For Each o_0__O_o_O As O_0__O_o_O In Me.o_o0_0.o_o_0..ooOooo.oO..Values
					If Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), Me.o0O.Oo., True) = 0 Then
						o_0__O_o_O.O0.0O0o_O. = True
						If TypeOf o_0__O_o_O.o_0.Oo_0O0_.()Is ooo0 OrElse TypeOf o_0__O_o_O.o_0.Oo_0O0_.()Is O_0OOOoO Then
							flag = True
						End If
						If Operators.CompareString(o_0__O_o_O.o_OoO._.(), "", True) > 0 Then
							expression = True
							Exit For
						End If
						Exit For
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, O_0__O_o_O).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim a_ As String
			If flag Then
				a_ = ChrW(2) & "{我方取消上传文件""" + OO_00oOO.FileSys.GetName(Me.O_oo__._O.) + """}" & ChrW(2)
				Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(Me.O_oo__._O.), a_, 2, 1, Me.o_o0_0.o_o_0..UserName)
				Return
			End If
			a_ = String.Concat(New String() { ChrW(2) & "{我方取消", Interaction.IIf(expression, "离线", "").ToString(), "发送文件""", OO_00oOO.FileSys.GetName(Me.O_oo__._O.), """}" & ChrW(2) })
			Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(Me.O_oo__._O.), a_, 2, 1, Nothing)
		End Sub

		' Token: 0x060015D9 RID: 5593 RVA: 0x00090FD8 File Offset: 0x0008F1D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0O.00.().Left = MyBase.Width - Me.o_0O.00.().Width - 4
		End Sub

		' Token: 0x060015DA RID: 5594 RVA: 0x00090FFC File Offset: 0x0008F1FC
		Friend Sub <<EMPTY_NAME>>()
			Me.O_oo__._O. = True
			Dim parameter As Object() = New Object() { Me.O_oo__._O., Me.O_oo__._O., Me.o_.0o0O__.(), Me }
			AddressOf Me.o_o0_0.o_o_0..O00__O._O_00o..Start(parameter)
		End Sub

		' Token: 0x060015DB RID: 5595 RVA: 0x00091058 File Offset: 0x0008F258
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.O_oo__._O. Then
				Me.O_oo__._O. = True
				Dim str As String = vbVerticalTab
				Dim a_ As String = "%7" + str + Me.o0O.Oo.
				Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(Me.O_oo__._O..Name, a_)
				Dim parameter As Object() = New Object() { Me.O_oo__._O., Me.O_oo__._O., Me.o_.0o0O__.(), Me, True }
				AddressOf Me.o_o0_0.o_o_0..O00__O._O_00o..Start(parameter)
				Dim a_2 As String = ChrW(2) & "(我方选择离线发送文件""" + OO_00oOO.FileSys.GetName(Me.O_oo__._O.) + """)" & ChrW(2)
				Me.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(Me.O_oo__._O.), a_2, 2, 1, Nothing)
			End If
		End Sub

		' Token: 0x040008FF RID: 2303
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000900 RID: 2304
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ProgressBar

		' Token: 0x04000901 RID: 2305
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PictureBox

		' Token: 0x04000902 RID: 2306
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000903 RID: 2307
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000904 RID: 2308
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000905 RID: 2309
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000906 RID: 2310
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000907 RID: 2311
		Friend <<EMPTY_NAME>> As IMClient

		' Token: 0x04000908 RID: 2312
		Friend <<EMPTY_NAME>> As IMBuddy

		' Token: 0x04000909 RID: 2313
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400090A RID: 2314
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400090B RID: 2315
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400090C RID: 2316
		Friend <<EMPTY_NAME>> As SendTypeEnum
	End Class
End Namespace
