Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000357 RID: 855
	<DesignerGenerated()>
	Friend Partial Class O\u30020\u3002O\u3000\u3002\u3002\u3002\u3000
		Inherits Form

		' Token: 0x0600349D RID: 13469 RVA: 0x0015E7DC File Offset: 0x0015C9DC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo._oO0Oo_0. IsNot Nothing Then
					Me.Oo._oO0Oo_0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600349E RID: 13470 RVA: 0x0015E81C File Offset: 0x0015CA1C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.00Oo_0ooo_0o.(New PropertyGrid())
			Me.o.00Oo_0ooo_0o.(New C1Button())
			Me.oO00o0Oo.O.(New C1Button())
			Me.oo_.0o.(New C1Button())
			Me.o.00Oo_0ooo_0o.(New C1DockingTab())
			Me.Oo0OOoO.o_O.(New C1DockingTabPage())
			Me.o.00Oo_0ooo_0o.(New C1DockingTabPage())
			Me.Oo0OOoO.o_O.(New PropertyGrid())
			Me.o00OoO00.0o.(New C1Button())
			Me.o.00Oo_0ooo_0o.(New Label())
			Me.o.00Oo_0ooo_0o.(New C1ComboBox())
			Me.o0O_o_.O.().BeginInit()
			Me.o_oO_.OoOo.().BeginInit()
			Me.O0._O0.().BeginInit()
			Me.OO.OO_.().BeginInit()
			Me.OO.OO_.().SuspendLayout()
			Me.o00OoO00.0o.().SuspendLayout()
			Me.OO.OO_.().SuspendLayout()
			Me.OO.oO0_.().BeginInit()
			Me.OO.OO_.().BeginInit()
			MyBase.SuspendLayout()
			Me.OO.OO_.().Dock = DockStyle.Fill
			Me.OO.OO_.().Location = New Point(0, 0)
			Me.OO.OO_.().Name = "PropertyGrid1"
			Me.OO.OO_.().Size = New Size(424, 372)
			Me.OO.OO_.().TabIndex = 0
			Me.OO.OO_.().ToolbarVisible = False
			Me.o0O_o_.O.().Location = New Point(280, 464)
			Me.o0O_o_.O.().Name = "btnOK"
			Me.o0O_o_.O.().Size = New Size(75, 23)
			Me.o0O_o_.O.().TabIndex = 4
			Me.o0O_o_.O.().Text = "确定"
			Me.o0O_o_.O.().UseVisualStyleBackColor = True
			Me.o_oO_.OoOo.().Location = New Point(360, 464)
			Me.o_oO_.OoOo.().Name = "btnCancel"
			Me.o_oO_.OoOo.().Size = New Size(75, 23)
			Me.o_oO_.OoOo.().TabIndex = 5
			Me.o_oO_.OoOo.().Text = "取消"
			Me.o_oO_.OoOo.().UseVisualStyleBackColor = True
			Me.O0._O0.().Location = New Point(10, 464)
			Me.O0._O0.().Name = "btnCancelChanges"
			Me.O0._O0.().Size = New Size(137, 23)
			Me.O0._O0.().TabIndex = 2
			Me.O0._O0.().Text = "还原为默认值"
			Me.O0._O0.().UseVisualStyleBackColor = True
			Me.OO.OO_.().BorderStyle = BorderStyle.None
			Me.OO.OO_.().Controls.Add(Me.o00OoO00.0o.())
			Me.OO.OO_.().Controls.Add(Me.OO.OO_.())
			Me.OO.OO_.().Indent = 0
			Me.OO.OO_.().Location = New Point(11, 47)
			Me.OO.OO_.().Name = "C1DockingTab1"
			Me.OO.OO_.().Size = New Size(424, 397)
			Me.OO.OO_.().TabIndex = 1
			Me.OO.OO_.().TabsCanFocus = False
			Me.OO.OO_.().TabsSpacing = 2
			Me.OO.OO_.().VisualStyle = 0
			Me.o00OoO00.0o.().Controls.Add(Me.OO.OO_.())
			Me.o00OoO00.0o.().Location = New Point(0, 25)
			Me.o00OoO00.0o.().Name = "C1DockingTabPage1"
			Me.o00OoO00.0o.().Size = New Size(424, 372)
			Me.o00OoO00.0o.().TabIndex = 0
			Me.o00OoO00.0o.().Text = "样式设置"
			Me.OO.OO_.().Controls.Add(Me.o00OoO00.0o.())
			Me.OO.OO_.().Location = New Point(0, 25)
			Me.OO.OO_.().Name = "C1DockingTabPage2"
			Me.OO.OO_.().Size = New Size(424, 372)
			Me.OO.OO_.().TabIndex = 1
			Me.OO.OO_.().Text = "修改配色"
			Me.o00OoO00.0o.().Dock = DockStyle.Fill
			Me.o00OoO00.0o.().Location = New Point(0, 0)
			Me.o00OoO00.0o.().Name = "PropertyGrid2"
			Me.o00OoO00.0o.().Size = New Size(424, 372)
			Me.o00OoO00.0o.().TabIndex = 0
			Me.o00OoO00.0o.().ToolbarVisible = False
			Me.OO.oO0_.().Location = New Point(200, 464)
			Me.OO.oO0_.().Name = "btnApply"
			Me.OO.oO0_.().Size = New Size(75, 23)
			Me.OO.oO0_.().TabIndex = 3
			Me.OO.oO0_.().Text = "应用"
			Me.OO.oO0_.().UseVisualStyleBackColor = True
			Me.OO.OO_.().AutoSize = True
			Me.OO.OO_.().Location = New Point(10, 18)
			Me.OO.OO_.().Margin = New Padding(2, 0, 2, 0)
			Me.OO.OO_.().Name = "Label1"
			Me.OO.OO_.().Size = New Size(59, 12)
			Me.OO.OO_.().TabIndex = 6
			Me.OO.OO_.().Text = "选择样式:"
			Me.OO.OO_.().AllowSpinLoop = False
			Me.OO.OO_.().BackColor = Color.FromArgb(239, 239, 239)
			Me.OO.OO_.().BorderStyle = BorderStyle.FixedSingle
			Me.OO.OO_.().Cursor = Cursors.Arrow
			Me.OO.OO_.().DropDownStyle = 1
			Me.OO.OO_.().GapHeight = 0
			Me.OO.OO_.().ImagePadding = New Padding(0)
			Me.OO.OO_.().ItemsDisplayMember = ""
			Me.OO.OO_.().ItemsValueMember = ""
			Me.OO.OO_.().Location = New Point(72, 16)
			Me.OO.OO_.().Margin = New Padding(2, 2, 2, 2)
			Me.OO.OO_.().Name = "cmbThemes"
			Me.OO.OO_.().Size = New Size(182, 19)
			Me.OO.OO_.().TabIndex = 0
			Me.OO.OO_.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(446, 498)
			MyBase.Controls.Add(Me.OO.OO_.())
			MyBase.Controls.Add(Me.OO.OO_.())
			MyBase.Controls.Add(Me.OO.oO0_.())
			MyBase.Controls.Add(Me.OO.OO_.())
			MyBase.Controls.Add(Me.O0._O0.())
			MyBase.Controls.Add(Me.o_oO_.OoOo.())
			MyBase.Controls.Add(Me.o0O_o_.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.l_II_."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "表样式"
			Me.o0O_o_.O.().EndInit()
			Me.o_oO_.OoOo.().EndInit()
			Me.O0._O0.().EndInit()
			Me.OO.OO_.().EndInit()
			Me.OO.OO_.().ResumeLayout(False)
			Me.o00OoO00.0o.().ResumeLayout(False)
			Me.OO.OO_.().ResumeLayout(False)
			Me.OO.oO0_.().EndInit()
			Me.OO.OO_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600349F RID: 13471 RVA: 0x0015EFB9 File Offset: 0x0015D1B9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034A0 RID: 13472 RVA: 0x0015EFC1 File Offset: 0x0015D1C1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.O_O0o00.Ooo0_. = A_0
		End Sub

		' Token: 0x060034A1 RID: 13473 RVA: 0x0015EFCA File Offset: 0x0015D1CA
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034A2 RID: 13474 RVA: 0x0015EFD4 File Offset: 0x0015D1D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_oO_.OoOo.
			Dim o_O0o00.Ooo0_. As C1Button = Me.O_O0o00.Ooo0_.
			If o_O0o00.Ooo0_. IsNot Nothing Then
				RemoveHandler o_O0o00.Ooo0_..Click, value
			End If
			Me.O_O0o00.Ooo0_. = A_0
			o_O0o00.Ooo0_. = Me.O_O0o00.Ooo0_.
			If o_O0o00.Ooo0_. IsNot Nothing Then
				AddHandler o_O0o00.Ooo0_..Click, value
			End If
		End Sub

		' Token: 0x060034A3 RID: 13475 RVA: 0x0015F017 File Offset: 0x0015D217
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0___O.OOOoO.
		End Function

		' Token: 0x060034A4 RID: 13476 RVA: 0x0015F020 File Offset: 0x0015D220
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOO0_o.o.
			Dim o0___O.OOOoO. As C1Button = Me.O0___O.OOOoO.
			If o0___O.OOOoO. IsNot Nothing Then
				RemoveHandler o0___O.OOOoO..Click, value
			End If
			Me.O0___O.OOOoO. = A_0
			o0___O.OOOoO. = Me.O0___O.OOOoO.
			If o0___O.OOOoO. IsNot Nothing Then
				AddHandler o0___O.OOOoO..Click, value
			End If
		End Sub

		' Token: 0x060034A5 RID: 13477 RVA: 0x0015F063 File Offset: 0x0015D263
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.O_o.
		End Function

		' Token: 0x060034A6 RID: 13478 RVA: 0x0015F06C File Offset: 0x0015D26C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0._O0.
			Dim o.O_o. As C1Button = Me.O.O_o.
			If o.O_o. IsNot Nothing Then
				RemoveHandler o.O_o..Click, value
			End If
			Me.O.O_o. = A_0
			o.O_o. = Me.O.O_o.
			If o.O_o. IsNot Nothing Then
				AddHandler o.O_o..Click, value
			End If
		End Sub

		' Token: 0x060034A7 RID: 13479 RVA: 0x0015F0AF File Offset: 0x0015D2AF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034A8 RID: 13480 RVA: 0x0015F0B7 File Offset: 0x0015D2B7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O_O0o00.Ooo0_. = A_0
		End Sub

		' Token: 0x060034A9 RID: 13481 RVA: 0x0015F0C0 File Offset: 0x0015D2C0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034AA RID: 13482 RVA: 0x0015F0C8 File Offset: 0x0015D2C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_O0o00.Ooo0_. = A_0
		End Sub

		' Token: 0x060034AB RID: 13483 RVA: 0x0015F0D1 File Offset: 0x0015D2D1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O0___O.OOOoO.
		End Function

		' Token: 0x060034AC RID: 13484 RVA: 0x0015F0D9 File Offset: 0x0015D2D9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O0___O.OOOoO. = A_0
		End Sub

		' Token: 0x060034AD RID: 13485 RVA: 0x0015F0E2 File Offset: 0x0015D2E2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.O0___O.OOOoO.
		End Function

		' Token: 0x060034AE RID: 13486 RVA: 0x0015F0EA File Offset: 0x0015D2EA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.O0___O.OOOoO. = A_0
		End Sub

		' Token: 0x060034AF RID: 13487 RVA: 0x0015F0F3 File Offset: 0x0015D2F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo0000_O.0_O0.
		End Function

		' Token: 0x060034B0 RID: 13488 RVA: 0x0015F0FC File Offset: 0x0015D2FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0O.OO00OOOO_0.
			Dim ooo0000_O.0_O0. As C1Button = Me.Ooo0000_O.0_O0.
			If ooo0000_O.0_O0. IsNot Nothing Then
				RemoveHandler ooo0000_O.0_O0..Click, value
			End If
			Me.Ooo0000_O.0_O0. = A_0
			ooo0000_O.0_O0. = Me.Ooo0000_O.0_O0.
			If ooo0000_O.0_O0. IsNot Nothing Then
				AddHandler ooo0000_O.0_O0..Click, value
			End If
		End Sub

		' Token: 0x060034B1 RID: 13489 RVA: 0x0015F13F File Offset: 0x0015D33F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034B2 RID: 13490 RVA: 0x0015F147 File Offset: 0x0015D347
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_O0o00.Ooo0_. = A_0
		End Sub

		' Token: 0x060034B3 RID: 13491 RVA: 0x0015F150 File Offset: 0x0015D350
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O_O0o00.Ooo0_.
		End Function

		' Token: 0x060034B4 RID: 13492 RVA: 0x0015F158 File Offset: 0x0015D358
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o0O_o_.O.
			Dim o_O0o00.Ooo0_. As C1ComboBox = Me.O_O0o00.Ooo0_.
			If o_O0o00.Ooo0_. IsNot Nothing Then
				o_O0o00.Ooo0_..SelectedIndexChanged -= eventHandler
			End If
			Me.O_O0o00.Ooo0_. = A_0
			o_O0o00.Ooo0_. = Me.O_O0o00.Ooo0_.
			If o_O0o00.Ooo0_. IsNot Nothing Then
				o_O0o00.Ooo0_..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x060034B5 RID: 13493 RVA: 0x0015F19C File Offset: 0x0015D39C
		Public Sub New(A_0 As DataTable)
			AddHandler MyBase.Load, AddressOf Me.oO_oO.O_o_OOo.
			AddHandler MyBase.FormClosed, AddressOf Me.o0O_o_.O.
			Me.Oo._oO0Oo_0. = New LookAndFeelProperty()
			Me.o00OoO00.0o.()
			Me.Oo._oO0Oo_0. = A_0
			o_O_o_oOoo__.OOOO_OO._oo.(Me.Oo._oO0Oo_0., o_O_o_oOoo__.OOOO_OO._oo.(A_0.frd_LookAndFeel, False, vbVerticalTab, False), vbVerticalTab)
			Me.Text = Me.Text + " - " + A_0.Name
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.OO.OO_.() })
			Me.Oo._oO0Oo_0. = A_0.O0__.00.
		End Sub

		' Token: 0x060034B6 RID: 13494 RVA: 0x0015F262 File Offset: 0x0015D462
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.Oo._oO0Oo_0..O0__.00., Me.Oo._oO0Oo_0., True) <> 0 Then
				Me.Oo._oO0Oo_0..Theme = Me.Oo._oO0Oo_0.
			End If
			MyBase.Close()
		End Sub

		' Token: 0x060034B7 RID: 13495 RVA: 0x0015F294 File Offset: 0x0015D494
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO.OO_.().SelectedObject = New o_0oooo_OO(Me.Oo._oO0Oo_0., New String() { "外观", "行号颜色", "网格线" }, True, False)
			Me.o00OoO00.0o.().SelectedObject = New o_0oooo_OO(Me.Oo._oO0Oo_0., New String() { "外观", "行号颜色", "网格线" }, False, False)
			Me.OO.OO_.().Items.Add("默认")
			Me.OO.OO_.().Items.AddRange(OO_00oOO.Themes)
			Dim text As String = Me.Oo._oO0Oo_0..O0__.00.
			If Operators.CompareString(text, "(default)", True) = 0 Then
				text = "默认"
			End If
			Me.OO.OO_.().Value = text
		End Sub

		' Token: 0x060034B8 RID: 13496 RVA: 0x0015F364 File Offset: 0x0015D564
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO.00o.()
			MyBase.Close()
		End Sub

		' Token: 0x060034B9 RID: 13497 RVA: 0x0015F374 File Offset: 0x0015D574
		Private Sub <<EMPTY_NAME>>()
			Me.Oo._oO0Oo_0..frd_LookAndFeel = New LookAndFeelProperty()
			Me.Oo._oO0Oo_0..frd_LookAndFeel.UserStyle = Me.Oo._oO0Oo_0..UserStyle
			o_O_o_oOoo__.OOOO_OO._oo.(Me.Oo._oO0Oo_0..frd_LookAndFeel, o_O_o_oOoo__.OOOO_OO._oo.(Me.Oo._oO0Oo_0., False, vbVerticalTab, False), vbVerticalTab)
			Dim text As String = Me.OO.OO_.().Text
			If Operators.CompareString(text, "默认", True) = 0 Then
				text = "(default)"
			End If
			Me.Oo._oO0Oo_0..Theme = text
			Me.Oo._oO0Oo_0. = text
			Me.Oo._oO0Oo_0..OO00_o.ooOO.(False)
		End Sub

		' Token: 0x060034BA RID: 13498 RVA: 0x0015F40C File Offset: 0x0015D60C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim userStyle As String = Me.Oo._oO0Oo_0..UserStyle
			Me.Oo._oO0Oo_0. = New LookAndFeelProperty()
			Me.Oo._oO0Oo_0..UserStyle = userStyle
			Me.OO.OO_.().SelectedObject = New o_0oooo_OO(Me.Oo._oO0Oo_0., New String() { "外观", "行号颜色", "网格线" }, True, False)
			Me.o00OoO00.0o.().SelectedObject = New o_0oooo_OO(Me.Oo._oO0Oo_0., New String() { "外观", "行号颜色", "网格线" }, False, False)
		End Sub

		' Token: 0x060034BB RID: 13499 RVA: 0x0015F4A8 File Offset: 0x0015D6A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO.00o.()
		End Sub

		' Token: 0x060034BC RID: 13500 RVA: 0x0015F4B0 File Offset: 0x0015D6B0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.OO.OO_.().Text
			If Operators.CompareString(text, "默认", True) = 0 Then
				text = "(default)"
			End If
			If Operators.CompareString(Me.Oo._oO0Oo_0..O0__.00., text, True) <> 0 Then
				Me.Oo._oO0Oo_0..Theme = text
			End If
		End Sub

		' Token: 0x060034BD RID: 13501 RVA: 0x0015F4FD File Offset: 0x0015D6FD
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400157A RID: 5498
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400157B RID: 5499
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x0400157C RID: 5500
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400157D RID: 5501
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400157E RID: 5502
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400157F RID: 5503
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x04001580 RID: 5504
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04001581 RID: 5505
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04001582 RID: 5506
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x04001583 RID: 5507
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001584 RID: 5508
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001585 RID: 5509
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001586 RID: 5510
		Private <<EMPTY_NAME>> As LookAndFeelProperty

		' Token: 0x04001587 RID: 5511
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001588 RID: 5512
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
